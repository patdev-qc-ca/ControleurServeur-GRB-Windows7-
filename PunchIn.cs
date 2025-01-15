using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public partial class PunchIn : Form
    {
        public PunchIn()
        {
            InitializeComponent();
        }

        private void PunchIn_Load(object sender, EventArgs e)
        {
            cmbEmploye.Items.Add(IdNomEmploye);
            cmbEmploye.Text = IdNomEmploye;
            for (int x = 0; x < 24; x++)
            {
                mskHeure.Items.Add(Droite($"0{x}:00", 5));
                mskHeure.Items.Add(Droite($"0{x}:15", 5));
                mskHeure.Items.Add(Droite($"0{x}:30", 5));
                mskHeure.Items.Add(Droite($"0{x}:45", 5));
            }

        }

        private void optTypePunch0_CheckedChanged(object sender, EventArgs e) => lblPrefixe.Text = "E";
        private void optTypePunch1_CheckedChanged(object sender, EventArgs e) => lblPrefixe.Text = "M";

        private void txtNoProjet_TextChanged(object sender, EventArgs e)
        {
            if (txtNoProjet.Text.Length == 8)
            {
                picTypePunch.Text = lblPrefixe.Text + txtNoProjet.Text;
            }
            else
            {
                picTypePunch.Text = string.Empty;
            }
        }

        private void lblPrefixe_TextChanged(object sender, EventArgs e)
        {
            picTypePunch.Text = lblPrefixe.Text + txtNoProjet.Text;
        }

        private void picTypePunch_TextChanged(object sender, EventArgs e)
        {
            if (picTypePunch.Text.Length == 9)
            {
                SqlConnection sql = new SqlConnection(StringSQL);
                sql.Open();
                SqlDataReader rd = new SqlCommand($"SELECT DISTINCT NOMCLIENT,IDCLIENT FROM [DBO].[PROJSOUM] " +
                    $"JOIN CLIENT ON PROJSOUM.NOCLIENT = CLIENT.IDCLIENT" +
                    $" WHERE IDPROJSOUM = '{picTypePunch.Text}'", sql).ExecuteReader();
                if (rd.Read())
                {
                    txtClient.Text = rd[0].ToString();
                    m_iIDClient = (int)rd[1];
                    cmdOK.Enabled = true;
                }
                else
                {
                    txtClient.Text = "Client Inconnu";
                    cmdOK.Enabled = false;
                }
                rd.Close();
                SqlDataReader rd1 = new SqlCommand("SELECT DISTINCT [NAME]  FROM [DBO].[TBL_PUNCH_TYPE] WHERE MODE = 'E' ORDER BY NAME", sql).ExecuteReader();
                cmbType.Items.Clear();
                while (rd1.Read())
                {
                    cmbType.Items.Add(rd1[0].ToString());
                }
                if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
                rd1.Close();
                SqlDataReader rd2 = new SqlCommand($"SELECT DISTINCT TRIM([COMMENTAIRE])  FROM [DBO].[PUNCH] WHERE  [NOPROJET]= '{picTypePunch.Text}' ORDER BY TRIM([COMMENTAIRE])\r\n", sql).ExecuteReader();
                while (rd2.Read())
                {
                   comboBox1.Items.Add(rd2[0].ToString());
                }
                rd2.Close();
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                    button1.Enabled = true;
                }
                sql.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCommentaires.Text = comboBox1.Text;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            object sortie;
            string sql = "INSERT INTO [DBO].[PUNCH]([NOEMPLOYE],[NOPROJET],[DATE],[MODIFDÉBUT],[HEUREDÉBUT],[MODIFFIN],[HEUREFIN]," +
                "[COMMENTAIRE],[FACTURÉ],[NOFACTURE],[NOCLIENT],[KM],[NBREKM],[TYPE],[DUREE])VALUES(";
            sql += $"{IdNoEmploye},";//<NoEmploye, int,>
            sql += $"'{picTypePunch.Text}',";//<NoProjet
            sql += $"'{DateTime.Today.ToShortDateString()}',";//Date
            sql += $"{0},";           //ModifDébut
            if (mskHeure.Text == "") { mskHeure.Text = DateTime.Now.ToShortTimeString(); }
            sql += $"'{mskHeure.Text}',";//HeureDébut
            sql += $"{0},";//ModifFin
            /// ne pas utiliser DBNull.value => plante dans SQL
            /// patch Erreur SQL DBNULL dans la classe parente Punch.ListePunch
            sql += $"'{mskHeure.Text}',";//HeureFin 
            if (txtCommentaires.Text == "") { MessageBox.Show("Un commentaire doit être fourni", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            sql += $"'{txtCommentaires.Text}',";//Commentaire
            sql += $"{0},";//Facturé
            sql += $"{0},";//NoFacture
            sql += $"{m_iIDClient},";//NoClient
            if (chkKM.Checked){sql += $"{1},";}else{sql += $"{0},";}//KM
            if (chkKM.Checked)
            {
                if (txtKM.Text != "")
                {
                    sql += $"{txtKM.Text},";
                }
                else
                {
                    sql += $"{0},";
                }
            } //NbreKM
            else
            {
                sql += $"{0},";

            }
            if (cmbType.Text == "") { MessageBox.Show("Un type doit être sélectionné", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);return; }
            sql += $"'{cmbType.Text}',";//Type
            sql += $"{0})";//[Duree][nvarchar](10) NULL
            Clipboard.SetText(sql);
            odbc.Execute(sql, out sortie, -1);
            if (int.Parse(sortie.ToString()) > 0) { Close(); } 
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}