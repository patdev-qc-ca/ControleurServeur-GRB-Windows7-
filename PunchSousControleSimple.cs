using ADODB;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static ControleurServeur.Program;

namespace ControleurServeur
{
    public partial class PunchSousControleSimple : Form
    {
        private System.Windows.Forms.ListViewItem item;

        public string heurePunch { get;  set; }
        public int idPunch { get;  set; }
        public int idEmployePunch { get;  set; }

        public PunchSousControleSimple()
        {
            InitializeComponent();
        }

        public PunchSousControleSimple(System.Windows.Forms.ListViewItem item)
        {
            InitializeComponent();
            item = item;
            txtNoProjet.Enabled = false;
            optHeure0.Enabled = false;
            optHeure1.Checked = true;
            optHeure1.Enabled = false;
            cmdOK.Text = "Punch out";
            cmbEmploye.Text = Punch.cmbHeureSemaine.Text;
            lblPrefixe.Text = Gauche(item.SubItems[1].Text, 1);
            txtNoProjet.Text = Droite(item.SubItems[1].Text, 8);
            picTypePunch.Text = item.SubItems[1].Text;
            txtClient.Text = item.SubItems[4].Text;
            if (lblPrefixe.Text.ToLower() == "e") { optTypePunch0.Checked = true; } else { optTypePunch1.Checked = true; }
            txtClient.Text = item.SubItems[4].Text;
            cmbType.Text = item.SubItems[5].Text;
            txtCommentaires.Text = item.SubItems[6].Text;
            optHeure1.Checked = true;
            mskHeure.Text = Gauche(DateTime.Now.ToShortTimeString(), 5);
            txtKM.Text = item.SubItems[7].Text;
        }
        public PunchSousControleSimple(System.Windows.Forms.ListViewItem item,bool ModifierIn,bool ModifierOut)
        {
            InitializeComponent();
            item = item;
            cmdOK.Text = "Modifier";
            cmbEmploye.Text = Punch.cmbHeureSemaine.Text;
            lblPrefixe.Text = Gauche(item.SubItems[1].Text, 1);
            txtNoProjet.Text = Droite(item.SubItems[1].Text, 8);
            picTypePunch.Text = item.SubItems[1].Text;
            if (lblPrefixe.Text.ToLower() == "e") { optTypePunch0.Checked = true; } else { optTypePunch1.Checked = true; }
            if (item.SubItems[4].Text!=string.Empty) txtClient.Text = item.SubItems[4].Text;
            cmbType.Text = item.SubItems[5].Text;
            txtCommentaires.Text = item.SubItems[6].Text;
            optHeure1.Checked = true;
            if (ModifierIn==true | ModifierOut == true)
            {
                mskHeure.Enabled = true;
                mskHeure.Focus();
            }
            mskHeure.Text = Gauche(DateTime.Now.ToShortTimeString(), 5);
            if (ModifierIn == true) {mskHeure.Text = item.SubItems[2].Text;}
            if (ModifierOut == true){mskHeure.Text = item.SubItems[3].Text;}
        }

        private void txtNoProjet_TextChanged(object sender, EventArgs e)
        {
            picTypePunch.Text = $"{lblPrefixe.Text}{txtNoProjet.Text}";
            string npr = txtNoProjet.Text;
            if (npr.Length > 5 & npr.Length < 10)
            {
                npr = Gauche(txtNoProjet.Text, 5) + "-" + Droite(txtNoProjet.Text, 2);
                picTypePunch.Text = lblPrefixe.Text + npr;
                Punch.idProjet = lblPrefixe.Text + npr;
                picTypePunch.Text = lblPrefixe.Text + npr;
                if (txtNoProjet.Text.Length == 7)
                {
                    SqlConnection sql = new SqlConnection(StringSQL);
                    sql.Open();
                    try
                    {
                        SqlDataReader rd = new SqlCommand($"SELECT DISTINCT NOMCLIENT,IDCLIENT FROM [DBO].[PROJSOUM] " +
                            $"JOIN CLIENT ON PROJSOUM.NOCLIENT = CLIENT.IDCLIENT" +
                            $" WHERE IDPROJSOUM = '{lblPrefixe.Text + npr}'", sql).ExecuteReader();
                        if (rd.Read())
                        {
                            txtClient.Text = rd[0].ToString();
                            m_iIDClient=(int) rd[1];
                            RemplirComboCommentaires();
                            cmdOK.Enabled = true;
                        }
                        else
                        {
                            txtClient.Text = "Client Inconnu";
                            cmdOK.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {AfficherErreur(Name, "GetClientFromProject", ex);                    }
                    Text = m_iIDClient.ToString();
                }
            }
        }
        private void RemplirComboCommentaires()
        {
            if (picTypePunch.Text != "")
            {
                comboBox1.Items.Clear();
                button1.Enabled = false;
                ADODB.Recordset rd = new ADODB.Recordset();
                rd.Open($"SELECT DISTINCT TRIM(COMMENTAIRE) FROM PUNCH WHERE NOPROJET='{picTypePunch.Text}' AND  COMMENTAIRE!='' AND COMMENTAIRE NOT LIKE 'hi'", odbc,CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                while (!rd.EOF)
                {
                    comboBox1.Items.Add(rd.Fields[0].Value);
                }
                if (comboBox1.Items.Count > 0) { button1.Enabled = true; }

            }
        }
        private void PunchSousControleSimple_Load(object sender, EventArgs e)
        {
            RemplirComboType();
            m_datDateChoisie = DateTime.Now;
            ADODB.Recordset rstEmploye = new ADODB.Recordset();
            rstEmploye.Open("SELECT DISTINCT FAMILLE.FAMILLE FROM EMPLOYÉS " +
            "INNER JOIN FAMILLE ON EMPLOYÉS.FAMILLE = FAMILLE.IDFAMILLE " +
            "WHERE NOEMPLOYE = '" + Program.IdNoEmploye + "'", Program.odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, -1);
            if (!rstEmploye.EOF)
            {
                switch (rstEmploye.Fields["Famille"].Value)
                {
                    case "Électrique":
                        {
                            optTypePunch0.Checked = true;
                            lblPrefixe.Text = "E";
                            break;
                        }
                    case "Mécanique":
                        {
                            optTypePunch1.Checked = true;
                            lblPrefixe.Text = "M";
                            break;
                        }
                    default:
                        {
                            optTypePunch0.Checked = true;
                            lblPrefixe.Text = "E";
                            break;
                        }
                }
            }
            else
            {
                optTypePunch0.Checked = true;
            }
            rstEmploye.Close();
            rstEmploye = null;
            txtNoProjet.Visible = true;
            picTypePunch.Enabled = true;
            cmbType.SelectedIndex = -1;
            mskHeure.Text = string.Empty;
            optHeure0.Checked = true;
            txtCommentaires.Text = string.Empty;
            chkKM.CheckState = CheckState.Unchecked;
            txtKM.Text = string.Empty;
            chkDiner.Visible = false;
            optHeureDiner0.Visible = false;
            optHeureDiner1.Visible = false;
            txtNoProjet.Focus();
            Punch.m_ePunch = Punch.enumPunch.I_PUNCH_IN;
            for (int x = 0; x < 24; x++)
            {
                mskHeure.Items.Add(Droite($"0{x}:00", 5));
                mskHeure.Items.Add(Droite($"0{x}:15", 5));
                mskHeure.Items.Add(Droite($"0{x}:30", 5));
                mskHeure.Items.Add(Droite($"0{x}:45", 5));
            }
            mskHeure.Text = Droite($"0{DateTime.Now.Hour}:00", 5);
            cmbEmploye.Items.Clear();
            foreach (DB_Employe p in Employes)
            {
                cmbEmploye.Items.Add(new ListItem(p.Employes, p.Noemploye.ToString()));
                if (cmbEmploye.Items.Count == 1)
                {
                    cmbEmploye.SelectedIndex = 0;
                }
            }
            cmbEmploye.Text = IdNomEmploye;
            RemplirListeCommentaire();
            if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                button1.Enabled = true;
            }
        }
        private void RemplirListeCommentaire()
        {
            if (picTypePunch.Text != "")
            {
                comboBox1.Items.Clear();
                ADODB.Recordset sq = new ADODB.Recordset();
                sq.Open($"SELECT DISTINCT TRIM([COMMENTAIRE])  FROM [DBO].[PUNCH] WHERE  [NOPROJET]= '{picTypePunch.Text}' ORDER BY trim([Commentaire])", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                while (!sq.EOF)
                {
                    comboBox1.Items.Add(sq.Fields[0].Value);
                    sq.MoveNext();
                }
                sq.Close();

            }
        }
        private void RemplirComboType()
        {
            bool bInstallation;
            string sType = "";
            string sNumero = string.Empty;
            cmbType.Items.Clear();
            ADODB.Recordset sq = new ADODB.Recordset();
            sq.Open($"SELECT DISTINCT [NAME]  FROM [DBO].[TBL_PUNCH_TYPE] WHERE MODE = '{lblPrefixe.Text}' ORDER BY NAME", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!sq.EOF)
            {
                cmbType.Items.Add(sq.Fields[0].Value);
                sq.MoveNext();
            }
            sq.Close();
        }
        private void optTypePunch0_CheckedChanged(object sender, EventArgs e) => lblPrefixe.Text = "E";
        private void optTypePunch1_CheckedChanged(object sender, EventArgs e) => lblPrefixe.Text = "M";
        private void optHeureDiner0_CheckedChanged(object sender, EventArgs e)
        {
            if (optHeure0.Checked)
            {
                mskHeure.Enabled = false;
            }
            else
            {
                mskHeure.Enabled = true;
                if (Punch.m_bModifPunch == false)
                {
                    mskHeure.Focus();
                }
            }
            return;
        }
        string RetourneLesQuart(DateTime dt)
        {
            if (dt.Minute > 0 && dt.Minute < 5) { return $"{dt.Hour}:00"; }
            if (dt.Minute > 5 && dt.Minute < 24) { return $"{dt.Hour}:15"; }
            if (dt.Minute > 24 && dt.Minute < 35) { return $"{dt.Hour}:30"; }
            if (dt.Minute > 35 && dt.Minute < 54) { return $"{dt.Hour}:45"; }
            if (dt.Minute > 54) { return $"{dt.AddHours(+1).Hour}:00"; }
            return dt.ToString();
        }
        string RetourneLesQuart(int heure,int minute)
        {
            if (minute > 0 && minute < 5) { return Droite($"0{heure}:00",5); }
            if (minute > 5 && minute < 24) { return Droite($"0{heure}:15", 5); }
            if (minute > 24 && minute < 35) { return Droite($"0{heure}:30", 5); }
            if (minute > 35 && minute < 54) { return Droite($"0{heure}:45", 5); }
            if (minute > 54) { return Droite($"{heure+1}:00",5); }
            return Droite($"0{heure}:{minute}",5);
        }
        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtCommentaires.Text.Length < 3)
            {
                MessageBox.Show("UnauthorizedAccessException: commentaire inexistant", Application.ProductName + "." + Name + ".Enregistre", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (cmdOK.Text == "Punch out")
            {
                ADODB.Recordset rstPunch = new Recordset();
                if (item.SubItems[8].Text != "")
                {
                    rstPunch.Open($"select * from punch where idpunch='{Punch.lvwJour.FocusedItem.SubItems[8].Text}' ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstPunch.Open($"select * from punch where idpunch='{idPunch}' ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                }
                if (!rstPunch.EOF)
                {
                    rstPunch.Fields["Modiffin"].Value = 0;
                    rstPunch.Fields["Facturé"].Value = 0;
                    if (optHeure0.Checked){rstPunch.Fields["HeureFin"].Value = RetourneLesQuart(DateTime.Now);}
                    if (optHeure1.Checked){rstPunch.Fields["HeureFin"].Value = mskHeure.Text;}
                    rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                    rstPunch.Fields["NoClient"].Value = m_iIDClient;
                    if (chkKM.Checked)
                    {
                        rstPunch.Fields["KM"].Value = true;
                        if (!string.IsNullOrEmpty(txtKM.Text)){rstPunch.Fields["KM"].Value = 1;rstPunch.Fields["NbreKM"].Value = txtKM.Text;}
                        else{rstPunch.Fields["KM"].Value = 0;rstPunch.Fields["NbreKM"].Value = 0;}
                    }
                    else
                    {
                        rstPunch.Fields["KM"].Value = 0;
                        rstPunch.Fields["NbreKM"].Value = 0;
                    }

                    rstPunch.Fields["Type"].Value = cmbType.Text;
                    rstPunch.Update();
                }
                rstPunch.Close();
                rstPunch = null;
            }
            else if (cmdOK.Text == "Modifier")
            {
                ADODB.Recordset rstPunch = new Recordset();
                rstPunch.Open($"select * from punch where [NoProjet]='{item.SubItems[1].Text}' " +
                    $"and HeureDébut='{item.SubItems[2].Text}' and HeureFin is null"
                    , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstPunch.EOF)
                {
                    rstPunch.Fields["NoEmploye"].Value = IdNoEmploye;
                    rstPunch.Fields["NoProjet"].Value = picTypePunch.Text;
                    rstPunch.Fields["Date"].Value = DateTime.Today.ToShortDateString();
                    rstPunch.Fields["Modiffin"].Value = 0;
                    rstPunch.Fields["Facturé"].Value = 0;
                    if (optHeure0.Checked)
                    {
                        rstPunch.Fields["HeureFin"].Value = RetourneLesQuart(DateTime.Now);
                    }
                    if (optHeure1.Checked)
                    {
                        rstPunch.Fields["HeureFin"].Value = mskHeure.Text;
                    }
                    rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                    rstPunch.Fields["NoClient"].Value = m_iIDClient;
                    if (chkKM.Checked)
                    {
                        rstPunch.Fields["KM"].Value = true;
                        if (!string.IsNullOrEmpty(txtKM.Text))
                        {
                            rstPunch.Fields["KM"].Value = 1;
                            rstPunch.Fields["NbreKM"].Value = txtKM.Text;
                        }
                        else
                        {
                            rstPunch.Fields["KM"].Value = 0;
                            rstPunch.Fields["NbreKM"].Value = 0;
                        }
                    }
                    else
                    {
                        rstPunch.Fields["KM"].Value = 0;
                        rstPunch.Fields["NbreKM"].Value = 0;
                    }
                    rstPunch.Fields["Type"].Value = cmbType.Text;
                    rstPunch.Update();
                }
                rstPunch.Close();
                rstPunch = null;
            }
            else
            {
                ADODB.Recordset rstPunch = new Recordset();
                rstPunch.Open($" SELECT * FROM PUNCH ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstPunch.EOF)
                {
                    rstPunch.AddNew();
                    rstPunch.Fields["NoEmploye"].Value = IdNoEmploye;
                    rstPunch.Fields["NoProjet"].Value = picTypePunch.Text;
                    rstPunch.Fields["Date"].Value = DateTime.Today.ToShortDateString();
                    rstPunch.Fields["ModifDébut"].Value = 0;
                    rstPunch.Fields["Facturé"].Value = 0;
                    if (optHeure0.Checked)
                    {
                        rstPunch.Fields["HeureDébut"].Value = RetourneLesQuart(DateTime.Now);
                    }
                    if (optHeure1.Checked)
                    {
                        rstPunch.Fields["HeureDébut"].Value = mskHeure.Text;
                    }
                    rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                    rstPunch.Fields["NoClient"].Value = m_iIDClient;
                    if (chkKM.Checked)
                    {
                        rstPunch.Fields["KM"].Value = true;
                        if (!string.IsNullOrEmpty(txtKM.Text)){rstPunch.Fields["KM"].Value = 1;rstPunch.Fields["NbreKM"].Value = txtKM.Text;}
                        else{rstPunch.Fields["KM"].Value = 0;rstPunch.Fields["NbreKM"].Value = 0;}
                    }
                    else{rstPunch.Fields["KM"].Value = 0;rstPunch.Fields["NbreKM"].Value = 0;}
                    rstPunch.Fields["Type"].Value = cmbType.Text;
                    rstPunch.Update();
                }
                rstPunch.Close();
                rstPunch = null;
            }
            DateTime dt = DateTime.Now;
            Close();
        }
        private string GetHeure(string sHeure)
        {
            string GetHeureRet = default;
            try
            {
                DateTime datHeure;
                bool b24Heure;
                if (IsNumeric(Gauche(sHeure, 2)) & IsNumeric(sHeure.Substring(4, 2)))
                {
                    if (int.Parse(Gauche(sHeure, 2)) < 0 | int.Parse(Gauche(sHeure, 2)) > 24 | int.Parse(sHeure.Substring(4, 2)) < 0 | int.Parse(sHeure.Substring(4, 2)) > 59)
                    {
                        MessageBox.Show("Heure incorrecte!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);return GetHeureRet;
                    }
                }
                else
                {
                    MessageBox.Show("Heure incorrecte!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);return GetHeureRet;
                }
                sHeure = sHeure.Replace("AM", "");
                if (sHeure.Contains("PM"))
                {
                    sHeure = sHeure.Replace("PM", "").Trim();
                    sHeure = DateTime.Parse(sHeure).AddHours(12).ToShortTimeString();
                    b24Heure = true;
                }
                sHeure = Gauche(sHeure, 5);
                if (Gauche(sHeure, 2) != "24")
                {
                    datHeure = DateTime.FromOADate(int.Parse(Gauche(sHeure, 2)));
                    if (datHeure.Minute <= 5) { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 0, 0); }
                    else
                    if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datHeure) <= 24) { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 15, 0); }
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datHeure) <= 35) { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 30, 0); }
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datHeure) <= 54) { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 45, 0); }
                    else { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure) + 1, 0, 0); }
                    GetHeureRet = Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 2) + ":" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datHeure), 2);
                }
                else
                {
                    GetHeureRet = sHeure;
                }
                return GetHeureRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "GetHeure", ex); return GetHeureRet;
            }
        }

        private void cmdAnnuler_Click(object sender, EventArgs e) => Close();

        private void mskHeure_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e) => txtCommentaires.Text = comboBox1.Text;
        private void txtCommentaires_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach(char p in txtCommentaires.Text)
            {
                if (p == '=')
                {
                    MessageBox.Show("Commentaire rejeté\nÉgalitées non permises", Application.ProductName + ".Sécurité.InjectionSQL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCommentaires.Text = Gauche(txtCommentaires.Text, i);
                    return;
                }
                i++;
            }
        }

        private void optHeureDiner1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optHeureDiner0_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chkDiner_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkKM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void fraHeure_Enter(object sender, EventArgs e)
        {

        }

        private void optHeure1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optHeure0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picTypePunch_Enter(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmploye_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lblPrefixe_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void lblprojet_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
