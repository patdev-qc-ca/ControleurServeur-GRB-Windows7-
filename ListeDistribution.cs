using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControleurServeur
{
    public partial class ListeDistribution : Form
    {
        public ListeDistribution() => InitializeComponent();
        int newIdContactClient = 0;
        int newIdContactFournisseur = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            Recordset rd = new Recordset();
            listView1.Items.Clear();
            rd.Open("SELECT * FROM [DBO].[LISTEDISTRIBUTION]", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}"));
                itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[9].Value}"));
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Recordset rd = new Recordset();
            listView1.Items.Clear();
            object resultat;
            rd.Open("SELECT * FROM [DBO].[LISTEDISTRIBUTION] " +
                "JOIN  [DBO].[CLIENT] ON [DBO].[CLIENT].NOMCLIENT=[DBO].[LISTEDISTRIBUTION].NOMCOMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                rd.Fields[6].Value = 1;
                rd.Update();
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            button7_Click(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Recordset rd = new Recordset();
            listView1.Items.Clear();
            object resultat;
            rd.Open("SELECT * FROM [DBO].[LISTEDISTRIBUTION] " +
                "JOIN [DBO].[FOURNISSEUR] ON [DBO].[FOURNISSEUR].NOMFOURNISSEUR=[DBO].[LISTEDISTRIBUTION].NOMCOMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                rd.Fields[7].Value = 1;
                rd.Update();
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            button7_Click(sender, e);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Recordset rd = new Recordset();
            listView1.Items.Clear();
            rd.Open("SELECT [DBO].[CONTACT].[TITRE],[DBO].[LISTEDISTRIBUTION].* FROM [DBO].[LISTEDISTRIBUTION]" +
                "JOIN [DBO].[CONTACT] ON [DBO].[CONTACT].COMPAGNIE=[DBO].[LISTEDISTRIBUTION].NOMCOMPAGNIE " +
                "WHERE TITRE LIKE '%PRÉSIDENT %' OR TITRE LIKE '%PRESIDENT %' OR TITRE = 'PRÉS.' OR TITRE = 'PRES.' " +
                "ORDER BY TITRE\r\n", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                rd.Fields[9].Value = 1;
                rd.Update();
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}"));
                itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[9].Value}"));
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            rd.Open("SELECT [DBO].[CONTACT].[TITRE],[DBO].[LISTEDISTRIBUTION].* FROM [DBO].[LISTEDISTRIBUTION] " +
                "JOIN [DBO].[CONTACT] ON [DBO].[CONTACT].COMPAGNIE=[DBO].[LISTEDISTRIBUTION].NOMCOMPAGNIE " +
                "WHERE TITRE LIKE '%MEAT%' " +
                "ORDER BY TITRE ", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                rd.Fields[10].Value = 1;
                rd.Update();
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            button7_Click(sender, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Program.UpdateSQL($"DELETE FROM [dbo].[LISTEDISTRIBUTION]  WHERE ID={listView1.FocusedItem.Text}");
            button7_Click(sender, e);
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            panel1.Visible = true;
            ListViewItem item = listView1.FocusedItem;
            textBox1.Enabled = false;
            textBox1.Text = item.SubItems[0].Text;
            textBox2.Text = item.SubItems[2].Text;
            textBox3.Text = item.SubItems[3].Text;
            textBox4.Text = item.SubItems[4].Text;
            if (item.SubItems[6].Text.ToLower() == "true") { checkBox1.Checked = true; }
            if (item.SubItems[7].Text.ToLower() == "true") { checkBox2.Checked = true; }
            if (item.SubItems[8].Text.ToLower() == "true") { checkBox3.Checked = true; }
            if (item.SubItems[9].Text.ToLower() == "true") { checkBox4.Checked = true; }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Mettre à jour")
            {
                Program.UpdateSQL($"UPDATE [DBO].[LISTEDISTRIBUTION] " +
                    $"SET [NOMCOMPAGNIE] = '{textBox1.Text.Replace("'", "''")}'," +
                    $"[EMAIL] =  {textBox2.Text}," +
                    $"[ISCLIENT] = {checkBox1.Checked}," +
                    $"[ISFOURNISSEUR] =  {checkBox2.Checked}," +
                    $"[ISCHEFENTREPRISE] = {checkBox3.Checked}," +
                    $"[ISMEATPROCESSING] = {checkBox4.Checked} WHERE ID='{textBox1.Text}'");
            }
            else
            {
                Program.UpdateSQL($"INSERT INTO [DBO].[LISTEDISTRIBUTION]([NOCONTACT],[CONTACT],[NOMCOMPAGNIE]," +
                    $"[EMAIL],[ISCONTACT],[ISCLIENT],[ISFOURNISSEUR],[ISCHEFENTREPRISE],[ISMEATPROCESSING])VALUES(" +
                    $"{int.Parse(comboBox1.Text)},{textBox2.Text},{textBox3.Text},{textBox4.Text},'1'," +
                    $"'{checkBox1.Checked}','{checkBox2.Checked}','{checkBox3.Checked}','{checkBox4.Checked}'");
            }
            panel1.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button4.Text = "Enregistrer";
            label1.Text = "Contact #";
            Recordset rd = new Recordset();
            rd.Open("SELECT TOP (1) [IDCONTACT]+1  FROM [DBO].[CONTACT] ORDER BY IDCONTACT DESC", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF) { textBox1.Text = rd.Fields[0].Value; } else { textBox1.Text = "1"; }
            rd.Close();
            rd = null;
            rd.Open("SELECT TOP (1) [no_enreg]+1  FROM [dbo].[ContactClient] ORDER BY [no_enreg] DESC", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF) { newIdContactClient = (int)rd.Fields[0].Value; } else { newIdContactClient = 1; }
            rd.Close();
            rd = null;
            rd.Open("SELECT TOP (1) [no_enreg]+1  FROM [dbo].[ContactFRS] " +
                "ORDER BY [no_enreg] DESC", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF) { newIdContactFournisseur = (int)rd.Fields[0].Value; } else { newIdContactFournisseur = 1; }
            rd.Close();
            rd = null;
            comboBox1.Visible = true;
            textBox1.Visible = false;
            rd.Open("SELECT [ID],[CONTACT],[NOMCOMPAGNIE],[EMAIL],[ISCONTACT],[ISCLIENT],[ISFOURNISSEUR]," +
                "[ISCHEFENTREPRISE],[ISMEATPROCESSING]FROM [DBO].[LISTEDISTRIBUTION] " +
                "ORDER BY NOMCOMPAGNIE,CONTACT", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                comboBox1.Items.Add($"{rd.Fields[1].Value}@{rd.Fields[2].Value}");
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
        }
        private void button8_Click(object sender, EventArgs e) => panel1.Visible = false;
    }
}