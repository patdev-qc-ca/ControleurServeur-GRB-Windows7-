using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleurServeur
{
    public partial class SynchoniserPunch : Form
    {
        internal Connection mdbodbc = new Connection();
        internal Connection sqlodbc = new Connection();
        internal string[] NomMois = { "", "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "août", "septembre", "octobre", "novembre", "décembre" };
        internal string[] NomJourSemaine = { "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" };
        object sortie;
        public SynchoniserPunch()
        {
            InitializeComponent();
        }
        internal string TouverDernieretDateSQL()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            rst.Open("SELECT TOP (1) [DATE]  FROM [DBO].[PUNCH] ORDER BY DATE DESC", sqlodbc, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, -1);
            if (!rst.EOF)
            {
                return rst.Fields[0].Value;
            }
            rst.Close();
            return DateTime.Today.ToShortDateString();
        }
        internal string TouverDernieretDateMDB()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            rst.Open("SELECT  * FROM GRB_PUNCH ORDER BY DATE DESC", mdbodbc, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, -1);
            if (!rst.EOF)
            {
                return rst.Fields[3].Value;
            }
            rst.Close();
            return DateTime.Today.ToShortDateString();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime dt = DateTime.Parse(linkLabel1.Text);
            string fDate = $"{NomJourSemaine[(int)dt.DayOfWeek]}, le {dt.Day} {NomMois[dt.Month]} {dt.Year}";
            MessageBox.Show(fDate, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Voulez vous exclure les punchs d'aujourd'hui, avant d'importer?\nDes clones peuvent survenir", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                sqlodbc.Execute("DELETE FROM PUNCH WHERE DATE='" + linkLabel1.Text + "'", out sortie, -1);
                ADODB.Recordset rst = new ADODB.Recordset();
                rst.Open("SELECT *  FROM [DBO].[PUNCH] WHERE date='" + linkLabel6.Text + "'ORDER BY DATE DESC", sqlodbc, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, -1);
                while (!rst.EOF)
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[0].Value}"));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[1].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[3].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[5].Value}"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[7].Value}"));
                    itm.Checked = true;
                    rst.MoveNext();
                }
                rst.Close();
                MessageBox.Show(sortie.ToString() + " affectes\nIl y a maintenant " + listView1.Items.Count + " items corespondant dans la table Punch", Application.ProductName);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mdbodbc.Close();
            sqlodbc.Close();
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rstSQL = new ADODB.Recordset();
            ADODB.Recordset rstMDB = new ADODB.Recordset();
            rstSQL.Open("SELECT *  FROM [DBO].[PUNCH]", sqlodbc, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, -1);
            rstMDB.Open("SELECT *  FROM [GRB_PUNCH]", mdbodbc, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, -1);
            while (!rstMDB.EOF)
            {
                rstSQL.AddNew();
                rstSQL.Fields[1].Value = rstMDB.Fields[1].Value;
                rstSQL.Fields[2].Value = rstMDB.Fields[2].Value;
                rstSQL.Fields[3].Value = rstMDB.Fields[3].Value;
                rstSQL.Fields[4].Value = rstMDB.Fields[4].Value;
                rstSQL.Fields[5].Value = rstMDB.Fields[5].Value;
                rstSQL.Fields[6].Value = rstMDB.Fields[6].Value;
                rstSQL.Fields[7].Value = rstMDB.Fields[7].Value;
                rstSQL.Fields[8].Value = rstMDB.Fields[8].Value;
                rstSQL.Fields[9].Value = rstMDB.Fields[9].Value;
                rstSQL.Fields[10].Value = rstMDB.Fields[10].Value;
                rstSQL.Fields[11].Value = rstMDB.Fields[11].Value;
                rstSQL.Fields[12].Value = rstMDB.Fields[12].Value;
                rstSQL.Fields[13].Value = rstMDB.Fields[13].Value;
                rstSQL.Fields[14].Value = rstMDB.Fields[14].Value;
                rstSQL.Fields[15].Value = DBNull.Value;
                rstSQL.Update();
                rstMDB.MoveNext();
            }
            rstMDB.Close();
            rstSQL.Close();
            listView1.Items.Clear();
            ADODB.Recordset rst = new ADODB.Recordset();
            rst.Open("SELECT *  FROM [DBO].[PUNCH] WHERE date='" + linkLabel6.Text + "'ORDER BY DATE DESC", sqlodbc, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, -1);
            while (!rst.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[0].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[1].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[3].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[5].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[7].Value}"));
                itm.Checked = true;
                Application.DoEvents();
                rst.MoveNext();
            }
            rst.Close();
            linkLabel1.Text = TouverDernieretDateSQL();//sert de véerification que les donnes ont bien étées intégrées
            DateTime dt = DateTime.Parse(linkLabel1.Text);
            label4.Text = $"{NomJourSemaine[(int)dt.DayOfWeek]}, le {dt.Day} {NomMois[dt.Month]} {dt.Year}";
            sqlodbc.Execute("UPDATE PUNCH SET DUREE=DATEDIFF(MINUTE, [HEUREDÉBUT],[HEUREFIN]) WHERE DUREE IS NULL", out sortie, -1);
            MessageBox.Show(sortie.ToString() + " modifications ont étées apportées au champ durée", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sqlodbc.Execute("UPDATE PUNCH SET FACTURÉ=0, NOFACTURE=0 WHERE NOFACTURE IS NULL OR NOFACTURE=''", out sortie, -1);
            MessageBox.Show(sortie.ToString() + " ont  étés corrigés", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            sqlodbc.Execute("UPDATE PUNCH SET KM=0, NBREKM=0 WHERE NBREKM ='' OR NBREKM IS NULL", out sortie, -1);
            MessageBox.Show(sortie.ToString() + " modifications ont étées apportées au champ durée", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void SynchoniserPunch_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Text = Application.ProductName + " v:" + Application.ProductVersion + "  " + Environment.OSVersion.ToString();
            linkLabel1.Text = DateTime.Today.AddDays(-1).ToShortDateString();
            linkLabel2.Text = "AutoGRB";
            sqlodbc.Open($"Provider=SQLOLEDB;Data Source=production\\sqlexpress;Initial Catalog=autogrb;", "sa", "$NK#Bpl9YCm!0EKeZLdzp$Qetrz9g9bdQK7LO8L!u4oyv4rO2AOEvceyu8XIo", -1);
            linkLabel5.Text = "\\\\GRB-DC\\d$\\GRB\\bdgrb\\SEEGRB\\data.mdb".ToLower();
            mdbodbc.Open($"Provider=Microsoft.Jet.OLEDB.4.0;User ID = Admin;Data Source={linkLabel5.Text};Persist Security Info=False", "Admin", string.Empty, -1);
            linkLabel3.Text = sqlodbc.Provider;
            linkLabel5.Enabled = false;
            linkLabel1.Text = TouverDernieretDateSQL();
            linkLabel6.Text = TouverDernieretDateMDB();
            DateTime dt = DateTime.Parse(linkLabel1.Text);
            label4.Text = $"{NomJourSemaine[(int)dt.DayOfWeek]}, le {dt.Day} {NomMois[dt.Month]} {dt.Year}";
            dt = DateTime.Parse(linkLabel6.Text);
            label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Text = $"{NomJourSemaine[(int)dt.DayOfWeek]}, le {dt.Day} {NomMois[dt.Month]} {dt.Year}";
            linkLabel4.Text = mdbodbc.Provider;
            if (dt == DateTime.Today)
            {
                label4.ForeColor = Color.Red;
            }
            else { label4.ForeColor = Color.Green; }
            ADODB.Recordset rst = new ADODB.Recordset();
            rst.Open("SELECT *  FROM [DBO].[PUNCH] WHERE date='" + linkLabel1.Text + "'ORDER BY DATE DESC", sqlodbc, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, -1);
            while (!rst.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[0].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[1].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[3].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[5].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[7].Value}"));
                itm.Checked = true;
                rst.MoveNext();
            }
            rst.Close();
            ADODB.Recordset rst1 = new ADODB.Recordset();
            rst1.Open("SELECT *  FROM GRB_PUNCH WHERE date>'" + linkLabel1.Text + "'ORDER BY DATE DESC", mdbodbc, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, -1);
            while (!rst1.EOF)
            {
                ListViewItem itm1 = listView2.Items.Add(string.Empty);
                itm1.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst1.Fields[0].Value}"));
                itm1.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst1.Fields[1].Value}"));
                itm1.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst1.Fields[3].Value}"));
                itm1.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst1.Fields[5].Value}"));
                itm1.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst1.Fields[7].Value}"));
                itm1.Checked = true;
                rst1.MoveNext();
            }
            rst1.Close();
            if (linkLabel1.Text == DateTime.Today.ToShortDateString()) { button1.Enabled = true; }
            if (listView2.Items.Count > 0)
            {
                button2.Text = $"Importer les {listView2.Items.Count} entrées";
                button2.Enabled = true;
            }
        }

    }
}
