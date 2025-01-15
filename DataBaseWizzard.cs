using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleurServeur
{
    public partial class DataBaseWizzard : Form
    {
        private string defaultRootMDB = "\\\\GRB-DC\\BDGRB\\SEEGRB\\";
        public int y = 0;
        public DataBaseWizzard()
        {
            InitializeComponent();
            textBox1.Text = defaultRootMDB + "data.mdb";
            Program.ListerTableSurLeServeur();
            foreach (string p in Program.TablesSQL) { listSQL.Items.Add(p); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "mdb";
            openFileDialog1.InitialDirectory = defaultRootMDB;
            openFileDialog1.FileName = "*.mdb";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName.ToUpper();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Program.Gauche(textBox1.Text, 2) == "\\\\")
            {
                if (MessageBox.Show(Application.ProductName + " a détecté une adresse UNC pour la localisation de la base de donnée\nIl est préférable de travailler avec une base locale pour éviter de corrompre la source initiale\n\nVoulez vous l'importer localement?", Application.ProductName + "." + Name + ".Access", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        File.Copy(textBox1.Text, Environment.CurrentDirectory + "\\import.mdb", true);
                        textBox1.Text = Environment.CurrentDirectory + "\\import.mdb";
                    }
                    catch (Exception ex) { Program.AfficherErreur(Name, "AccessDB.Import.CopieLocale", ex); }
                }
                else
                {
                    switch (MessageBox.Show("Êtes vous rèllement sur de vouloir travailler directerment sur la source originale sans sauvegarde?", Application.ProductName + "." + Name + ".Access", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                    {
                        case DialogResult.No:
                            {
                                try
                                {
                                    File.Copy(textBox1.Text, Environment.CurrentDirectory + "\\import.mdb", true);
                                    textBox1.Text = Environment.CurrentDirectory + "\\import.mdb";
                                }
                                catch (Exception ex) { Program.AfficherErreur(Name, "AccessDB.Import.CopieLocale", ex); }
                            }
                            break;
                        case DialogResult.Cancel: { return; } break;
                    }
                }
                Program.OuvrirConnectionMDB(textBox1.Text);
                OleDbConnection conmdb = new OleDbConnection(Program.mdbodbc.ConnectionString);
                conmdb.Open();
                comboBox1.Items.Clear();
                foreach (DataRow r in conmdb.GetSchema("Tables").Select("TABLE_TYPE = 'TABLE'"))
                {
                    Conteneur.txtStatus.Text = ($"Table {r["TABLE_NAME"].ToString().ToUpper()} trouvée");
                    if (r["TABLE_NAME"].ToString().ToUpper() != "MSYSCOMPACTERROR") //ne pas importer la table des erreurs d'acces
                    {
                        comboBox1.Items.Add(r["TABLE_NAME"].ToString());
                    }
                }
                conmdb.Close();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                listView1.Columns.Clear();
                listView1.Items.Clear();
                if (listView1.Items.Count < 0) { button2.Enabled = false; }
                Recordset rd = new Recordset();
                rd.Open($"SELECT * FROM {comboBox1.Text}", Program.mdbodbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                y = rd.Fields.Count;
                if (!rd.EOF)
                {
                    for (int x = 0; x < y; x++) { listView1.Columns.Add(rd.Fields[x].Name); }
                }
                while (!rd.EOF)
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    for (int x = 0; x < y; x++)
                    {
                        if (($"{rd.Fields[x].Value}".ToLower() == "false") | ($"{rd.Fields[x].Value}".ToLower() == "true"))
                        {
                            itm.SubItems.Insert(x, new ListViewItem.ListViewSubItem(null, $"{Program.Bool2Int((bool)rd.Fields[x].Value)}"));
                        }
                        else
                        {
                            itm.SubItems.Insert(x, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[x].Value}"));
                        }
                    }
                    rd.MoveNext();
                }
                rd.Close();
                rd = null;
                button2.Enabled = true;
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recordset sr = new Recordset();
            ListViewItem item = listView1.FocusedItem;
            sr.Open($"SELECT * FROM {Program.Droite(comboBox1.Text, comboBox1.Text.Length - 4)} where {listView1.Columns[0].Text}={item.Text}", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!sr.EOF)
            {
                sr.AddNew();
                for (int x = 0; x < y; x++)
                {
                    sr.Fields[x].Value = item.SubItems[x].Text;
                }
                sr.Update();
            }
            sr.Close();
            sr = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recordset sr = new Recordset();
            Application.DoEvents();
            ListViewItem item = listView1.FocusedItem;
            sr.Open($"SELECT * FROM {Program.Droite(comboBox1.Text, comboBox1.Text.Length - 4)}", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!sr.EOF)
            {
                foreach (ListViewItem p in listView1.Items)
                {
                    if ($"{sr.Fields[0].Value}" == p.SubItems[0].Text){p.ForeColor = Color.BlueViolet;}
                }
                sr.MoveNext();
            }
            sr.Close();
            sr = null;
            for (int a = 0; a < listView1.Items.Count; a++)
            {
                if (listView1.Items[a].ForeColor != Color.BlueViolet)
                {
                    listView1.Items[a].Checked = true;
                }
            }
            foreach (ListViewItem t in listView1.Items)
            {
                if (t.Checked)
                {
                    Recordset rst = new Recordset();
                    Recordset rs = new Recordset();
                    listView1.FocusedItem = t;
                    rst.Open($"SELECT *  FROM {Program.Droite(comboBox1.Text, comboBox1.Text.Length - 4)}", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                    rst.Open($"SELECT *  FROM {comboBox1.Text}", Program.mdbodbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                    rst.AddNew();
                    for (int b = Program.ImportRestraint(comboBox1.Text); b < y; b++)
                    {
                        rst.Fields[b].Value = rs.Fields[b].Value;
                    }
                    rst.Update();
                    rst.Close();
                    rst = null;
                }
            }
        }
    }
}