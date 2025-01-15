using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public  class InventaireComptablMecanique : Form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            button4 = new System.Windows.Forms.Button();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            Total = new System.Windows.Forms.ColumnHeader();
            PrixNet = new System.Windows.Forms.ColumnHeader();
            Escompte = new System.Windows.Forms.ColumnHeader();
            comPerBox = new System.Windows.Forms.ColumnHeader();
            QteStock = new System.Windows.Forms.ColumnHeader();
            Localisation = new System.Windows.Forms.ColumnHeader();
            Commentaire = new System.Windows.Forms.ColumnHeader();
            QteBoite = new System.Windows.Forms.ColumnHeader();
            Manufacturier = new System.Windows.Forms.ColumnHeader();
            Description = new System.Windows.Forms.ColumnHeader();
            NoItem = new System.Windows.Forms.ColumnHeader();
            Date = new System.Windows.Forms.ColumnHeader();
            listView1 = new System.Windows.Forms.ListView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();//checkBox2
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = System.Drawing.Color.White;
            checkBox2.Location = new System.Drawing.Point(307, 21);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(135, 17);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "inclure la date recquise";
            checkBox2.UseVisualStyleBackColor = true;//checkBox1
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = System.Drawing.Color.White;
            checkBox1.Location = new System.Drawing.Point(307, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(162, 17);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "inclure la date de commande";
            checkBox1.UseVisualStyleBackColor = true;//button4
            button4.Location = new System.Drawing.Point(475, 12);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Rechercher";
            button4.UseVisualStyleBackColor = true;//dateTimePicker2
            dateTimePicker2.Location = new System.Drawing.Point(165, 16);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(136, 20);
            dateTimePicker2.TabIndex = 4;//dateTimePicker1
            dateTimePicker1.Location = new System.Drawing.Point(30, 16);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            dateTimePicker1.TabIndex = 3;//label3
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Black;
            label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            label3.Location = new System.Drawing.Point(143, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(19, 14);
            label3.TabIndex = 2;
            label3.Text = "au";//label1
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            label1.Location = new System.Drawing.Point(0, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 14);
            label1.TabIndex = 0;
            label1.Text = "Recherche par interval";//panel2
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(581, 39);
            panel2.TabIndex = 3;//label2
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            label2.Location = new System.Drawing.Point(3, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(21, 14);
            label2.TabIndex = 1;
            label2.Text = "Du";//button3
            button3.AutoSize = true;
            button3.BackColor = System.Drawing.Color.Maroon;
            button3.Enabled = false;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button3.ForeColor = System.Drawing.Color.CadetBlue;
            button3.Location = new System.Drawing.Point(25, 11);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(59, 25);
            button3.TabIndex = 5;
            button3.Text = "&Imprimer";
            button3.UseVisualStyleBackColor = true;//button2
            button2.AutoSize = true;
            button2.BackColor = System.Drawing.Color.Maroon;
            button2.Enabled = false;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button2.ForeColor = System.Drawing.Color.CadetBlue;
            button2.Location = new System.Drawing.Point(85, 11);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(110, 25);
            button2.TabIndex = 4;
            button2.Text = "Exp&orter vers Excel";
            button2.UseVisualStyleBackColor = true;//button1
            button1.AutoSize = true;
            button1.BackColor = System.Drawing.Color.Maroon;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button1.ForeColor = System.Drawing.Color.BurlyWood;
            button1.Location = new System.Drawing.Point(195, 11);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(55, 25);
            button1.TabIndex = 3;
            button1.Text = "&Fermer";
            button1.UseVisualStyleBackColor = true;//panel3
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(547, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(253, 39);
            panel3.TabIndex = 4;//panel1
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 411);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 39);
            panel1.TabIndex = 3;//Total
            Total.Text = "Total";
            Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;//PrixNet
            PrixNet.Text = "Prix net";
            PrixNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;//Escompte
            Escompte.Text = "Escompte";
            Escompte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;//comPerBox
            comPerBox.Text = "Vient en boite";
            comPerBox.Width = 84;//QteStock
            QteStock.Text = "Stock";
            QteStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;//Localisation
            Localisation.Text = "Localisation";
            Localisation.Width = 119;//Commentaire
            Commentaire.Text = "Commentaire";
            Commentaire.Width = 138;//QteBoite
            QteBoite.Text = "Qté par boite";
            QteBoite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            QteBoite.Width = 79;//Manufacturier
            Manufacturier.Text = "Manufacturier";
            Manufacturier.Width = 100;//Description
            Description.Text = "Description";
            Description.Width = 142;//NoItem
            NoItem.Text = "Item #";
            NoItem.Width = 69;//Date
            Date.Text = "Date recue";//listView1
            listView1.BackColor = System.Drawing.Color.Black;
            listView1.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            NoItem,
            Description,
            Manufacturier,
            QteBoite,
            Commentaire,
            Localisation,
            QteStock,
            comPerBox,
            Escompte,
            PrixNet,
            Total,
            Date});
            listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listView1.ForeColor = System.Drawing.Color.Lavender;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(800, 450);
            listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;//InventaireComptablMecanique
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Name = "InventaireComptablMecanique";
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Text = "ControleurServeur." + Name;
            ShowInTaskbar = false;
            Load += new System.EventHandler(InventaireComptablMecanique_Load);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        internal static System.Windows.Forms.CheckBox checkBox2;
        internal static System.Windows.Forms.CheckBox checkBox1;
        internal static System.Windows.Forms.Button button4;
        internal static System.Windows.Forms.DateTimePicker dateTimePicker2;
        internal static System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal static System.Windows.Forms.Label label3;
        internal static System.Windows.Forms.Label label1;
        internal static System.Windows.Forms.Panel panel2;
        internal static System.Windows.Forms.Label label2;
        internal static System.Windows.Forms.Button button3;
        internal static System.Windows.Forms.Button button2;
        internal static System.Windows.Forms.Button button1;
        internal static System.Windows.Forms.Panel panel3;
        internal static System.Windows.Forms.Panel panel1;
        internal static System.Windows.Forms.ColumnHeader Total;
        internal static System.Windows.Forms.ColumnHeader PrixNet;
        internal static System.Windows.Forms.ColumnHeader Escompte;
        internal static System.Windows.Forms.ColumnHeader comPerBox;
        internal static System.Windows.Forms.ColumnHeader QteStock;
        internal static System.Windows.Forms.ColumnHeader Localisation;
        internal static System.Windows.Forms.ColumnHeader Commentaire;
        internal static System.Windows.Forms.ColumnHeader QteBoite;
        internal static System.Windows.Forms.ColumnHeader Manufacturier;
        internal static System.Windows.Forms.ColumnHeader Description;
        internal static System.Windows.Forms.ColumnHeader NoItem;
        internal static System.Windows.Forms.ColumnHeader Date;
        internal static System.Windows.Forms.ListView listView1;
        public InventaireComptablMecanique()
        {
            InitializeComponent();
        }
        private void InventaireComptablMecanique_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(30);
                SqlConnection con = new SqlConnection(Program.StringSQL);
                if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
                SqlDataReader reader = new SqlCommand($"SELECT DISTINCT *,[DBO].[ACHAT_PIECES].* FROM INVENTAIREMEC " +
                    $"JOIN [DBO].[ACHAT_PIECES] ON[DBO].[INVENTAIREMEC].NOITEM =[DBO].[ACHAT_PIECES].[PIECE]", con).ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.Tag = reader[0].ToString();
                    itm.SubItems.Insert(0x00, new ListViewItem.ListViewSubItem(null, reader[1].ToString()));
                    itm.SubItems.Insert(0x01, new ListViewItem.ListViewSubItem(null, reader[2].ToString()));
                    itm.SubItems.Insert(0x02, new ListViewItem.ListViewSubItem(null, reader[3].ToString()));
                    itm.SubItems.Insert(0x03, new ListViewItem.ListViewSubItem(null, reader[4].ToString()));
                    itm.SubItems.Insert(0x04, new ListViewItem.ListViewSubItem(null, reader[8].ToString()));
                    itm.SubItems.Insert(0x05, new ListViewItem.ListViewSubItem(null, reader[9].ToString()));
                    itm.SubItems.Insert(0x06, new ListViewItem.ListViewSubItem(null, reader[11].ToString()));
                    itm.SubItems.Insert(0x07, new ListViewItem.ListViewSubItem(null, reader[17].ToString()));
                    itm.SubItems.Insert(0x08, new ListViewItem.ListViewSubItem(null, reader[6].ToString()));
                    itm.SubItems.Insert(0x09, new ListViewItem.ListViewSubItem(null, reader[7].ToString()));
                    double valeur = Math.Round(float.Parse(reader[11].ToString()) * float.Parse(reader[7].ToString()), 2);
                    itm.SubItems.Insert(0x0A, new ListViewItem.ListViewSubItem(null, valeur.ToString()));
                    if (valeur == 0d) { itm.SubItems[0x09].ForeColor = COLOR_JAUNE; }
                    else if (valeur < 0d) { itm.SubItems[0x09].ForeColor = COLOR_ROUGE; }
                    else { itm.SubItems[0x09].ForeColor = COLOR_VERT_FORET; }
                    if (valeur == 0d) { itm.SubItems[0x09].ForeColor = COLOR_JAUNE; }
                    else if (valeur < 0d) { itm.SubItems[0x09].ForeColor = COLOR_ROUGE; }
                    else { itm.SubItems[0x09].ForeColor = COLOR_VERT_FORET; }
                    if (reader[65].ToString() != string.Empty)
                    {
itm.SubItems.Insert(0x0B, new ListViewItem.ListViewSubItem(null, reader[65].ToString()));
                    }
                    else
                    {
itm.SubItems.Insert(0x0B, new ListViewItem.ListViewSubItem(null, "Inconnue"));
                    }
                    if (reader[65].ToString() != string.Empty)
                    {
itm.SubItems.Insert(0x0B, new ListViewItem.ListViewSubItem(null, reader[65].ToString()));
                    }
                    else
                    {
itm.SubItems.Insert(0x0B, new ListViewItem.ListViewSubItem(null, "Inconnue"));
                    }
                }
                con.Close();
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireComptableElectrique", "InventaireComptableElectrique_Load", ex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int iCount;
            Microsoft.Office.Interop.Excel.Application oXLApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oXLBook = oXLApp.Workbooks.Add(string.Empty);
            Microsoft.Office.Interop.Excel.Worksheet oXLSheet = oXLBook.Worksheets[1];
            oXLApp.Visible = true;
            oXLSheet.Range["A1: K1"].Font.Bold = true;
            oXLSheet.Name = "Inventaire Comptable Électrique";
            oXLSheet.Range["A:K"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            oXLSheet.Range["A1: K1"].Value = new object[] { "NOITEM", "DESCRIPTION", "MANUFACTURIER", "QUANTITÉ PAR BOITE", "COMMENTAIRES", "LOCALISATION", "QUANTITÉSTOCK", "COMMANDÉPARBOITE", "ESCOMPTE", "PRIX NET", "TOTAL" };
            for (int X = 0; X < listView1.Items.Count; X++)
            {
                oXLSheet.Range["A:K"].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                oXLSheet.Range[$"A{X + 2}: K{X + 2}"].Value = new object[]
                {
                    listView1.Items[X].Text,
                    listView1.Items[X].SubItems[1].Text,
                    listView1.Items[X].SubItems[2].Text,
                    listView1.Items[X].SubItems[3].Text,
                    listView1.Items[X].SubItems[4].Text,
                    listView1.Items[X].SubItems[5].Text,
                    listView1.Items[X].SubItems[6].Text,
                    listView1.Items[X].SubItems[7].Text,
                    listView1.Items[X].SubItems[8].Text,
                    listView1.Items[X].SubItems[9].Text,
                    listView1.Items[X].SubItems[10].Text,
                    listView1.Items[X].SubItems[11].Text,
                };
            }
            oXLBook.SaveAs(Filename: $"{RootExcel}Inventaire Comptable Électrique {ConvertToUSDate(DateTime.Now)}.xlsx");
            oXLBook.Close();
            oXLApp.Application.Quit();
        }
        private void button1_Click(object sender, EventArgs e) => Close();
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            e.Graphics.DrawString($"\t\tInventaire comptable électrique {DateTime.Now.ToString()}\t {IdNomEmploye}", printFont, System.Drawing.Brushes.Black, 0, 0);//sert a éviter de mordre le text comme c le cas dans le rapport sous VB6
            //équivaut a un retrait de 16pixels du top a cause du titre  page
            string cmds = "\n\n";
            foreach (ListViewItem p in listView1.Items)
            {
                cmds += $"\t{p.Text}\t{p.SubItems[1].Text}\t{p.SubItems[2].Text}\t{p.SubItems[3].Text}" +
                    $"\t{p.SubItems[4].Text}\t{p.SubItems[5].Text}\t{p.SubItems[6].Text}\t{p.SubItems[7].Text}\t{p.SubItems[8].Text}" +
                    $"\t{p.SubItems[9].Text}\t{p.SubItems[10].Text}\t{p.SubItems[11].Text}\n";
            }
            printFont = new System.Drawing.Font("calibri", 8, System.Drawing.FontStyle.Bold);
            e.Graphics.DrawString(cmds, printFont, System.Drawing.Brushes.Black, 0, 0);
            e.Graphics.DrawIcon(Icon, e.PageSettings.PaperSize.Width - 32, 3);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.DefaultPageSettings.Color = false;
            printDocument1.DefaultPageSettings.Landscape = isLandscape;
            /*   format de page personalisé ex pour une photo                 
            PaperSize ps = new PaperSize();
            ps.Height = 400; // 4"
            ps.Width = 500; // 5"
            printDocument1.DefaultPageSettings.PaperSize = ps;
            */
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.PrinterSettings.Copies = 1;
            printDialog1.Document = printDocument1;
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog();
                PrintPreviewDialog1.ClientSize = new System.Drawing.Size(300, 400);
                PrintPreviewDialog1.Location = new System.Drawing.Point(29, 29);
                PrintPreviewDialog1.Name = Text;
                PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(250, 375);
                PrintPreviewDialog1.UseAntiAlias = true;
                PrintPreviewDialog1.Document = printDocument1;
                Text = "Impression sur " + printDialog1.PrinterSettings.PrinterName;
                if (PrintPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                SqlConnection con = new SqlConnection(Program.StringSQL);
                if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
                string sql = $"SELECT DISTINCT *,[DBO].[ACHAT_PIECES].* FROM INVENTAIREMEC " +
                    $"JOIN [DBO].[ACHAT_PIECES] ON[DBO].[INVENTAIREELEC].NOITEM =[DBO].[ACHAT_PIECES].[PIECE] " +
                    $"WHERE DATERÉCEPTION BETWEEN '{ConvertToUSDate(dateTimePicker1.Value)}' AND '{ConvertToUSDate(dateTimePicker2.Value)}'";
                if (checkBox1.Checked) { sql += $" OR DATECOMMANDE BETWEEN '{ConvertToUSDate(dateTimePicker1.Value)}' AND '{ConvertToUSDate(dateTimePicker2.Value)}'"; }
                if (checkBox2.Checked) { sql += $" OR DATEREQUISE BETWEEN '{ConvertToUSDate(dateTimePicker1.Value)}' AND '{ConvertToUSDate(dateTimePicker2.Value)}'"; }
                sql += " ORDER BY [DBO].[ACHAT_PIECES].DATERÉCEPTION,[DBO].[ACHAT_PIECES].DATECOMMANDE DESC";
                Clipboard.SetText(sql, TextDataFormat.Text);
                SqlDataReader reader = new SqlCommand(sql, con).ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.Tag = reader[0].ToString();
                    itm.SubItems.Insert(0x00, new ListViewItem.ListViewSubItem(null, reader[1].ToString()));
                    itm.SubItems.Insert(0x01, new ListViewItem.ListViewSubItem(null, reader[2].ToString()));
                    itm.SubItems.Insert(0x02, new ListViewItem.ListViewSubItem(null, reader[3].ToString()));
                    itm.SubItems.Insert(0x03, new ListViewItem.ListViewSubItem(null, reader[4].ToString()));
                    itm.SubItems.Insert(0x04, new ListViewItem.ListViewSubItem(null, reader[8].ToString()));
                    itm.SubItems.Insert(0x05, new ListViewItem.ListViewSubItem(null, reader[9].ToString()));
                    itm.SubItems.Insert(0x06, new ListViewItem.ListViewSubItem(null, reader[11].ToString()));
                    itm.SubItems.Insert(0x07, new ListViewItem.ListViewSubItem(null, reader[17].ToString()));
                    itm.SubItems.Insert(0x08, new ListViewItem.ListViewSubItem(null, reader[6].ToString()));
                    itm.SubItems.Insert(0x09, new ListViewItem.ListViewSubItem(null, reader[7].ToString()));
                    double valeur = Math.Round(float.Parse(reader[11].ToString()) * float.Parse(reader[7].ToString()), 2);
                    itm.SubItems.Insert(0x0A, new ListViewItem.ListViewSubItem(null, valeur.ToString()));
                    if (valeur == 0d) { itm.SubItems[0x09].ForeColor = COLOR_JAUNE; }
                    else if (valeur < 0d) { itm.SubItems[0x09].ForeColor = COLOR_ROUGE; }
                    else { itm.SubItems[0x09].ForeColor = COLOR_VERT_FORET; }
                    if (reader[65].ToString() != string.Empty)
                    {
itm.SubItems.Insert(0x0B, new ListViewItem.ListViewSubItem(null, reader[65].ToString()));
                    }
                    else
                    {
itm.SubItems.Insert(0x0B, new ListViewItem.ListViewSubItem(null, "Inconnue"));
                    }
                }
                con.Close();
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireComptableElectrique", "InventaireComptableElectrique_Load", ex);
            }
        }
    }
}
