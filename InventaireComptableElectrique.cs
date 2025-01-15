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
    public class InventaireComptableElectrique : Form
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
            listView1 = new System.Windows.Forms.ListView();
            NoItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Manufacturier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            QteBoite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Commentaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Localisation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            QteStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            comPerBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Escompte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            PrixNet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            button4 = new System.Windows.Forms.Button();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.Color.Black;
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
            listView1.Size = new System.Drawing.Size(1045, 587);
            listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // NoItem
            // 
            NoItem.Text = "Item #";
            NoItem.Width = 69;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 142;
            // 
            // Manufacturier
            // 
            Manufacturier.Text = "Manufacturier";
            Manufacturier.Width = 96;
            // 
            // QteBoite
            // 
            QteBoite.Text = "Qté par boite";
            QteBoite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            QteBoite.Width = 79;
            // 
            // Commentaire
            // 
            Commentaire.Text = "Commentaire";
            Commentaire.Width = 138;
            // 
            // Localisation
            // 
            Localisation.Text = "Localisation";
            Localisation.Width = 119;
            // 
            // QteStock
            // 
            QteStock.Text = "Stock";
            QteStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comPerBox
            // 
            comPerBox.Text = "Vient en boite";
            comPerBox.Width = 84;
            // 
            // Escompte
            // 
            Escompte.Text = "Escompte";
            Escompte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PrixNet
            // 
            PrixNet.Text = "Prix net";
            PrixNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Total
            // 
            Total.Text = "Total";
            Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Date
            // 
            Date.Text = "Date recue";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 638);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1045, 38);
            panel1.TabIndex = 1;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(792, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(253, 38);
            panel3.TabIndex = 4;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = System.Drawing.Color.Maroon;
            button3.Enabled = false;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.ForeColor = System.Drawing.Color.CadetBlue;
            button3.Location = new System.Drawing.Point(25, 11);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(65, 26);
            button3.TabIndex = 5;
            button3.Text = "&Imprimer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = System.Drawing.Color.Maroon;
            button2.Enabled = false;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.Color.CadetBlue;
            button2.Location = new System.Drawing.Point(85, 11);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(114, 26);
            button2.TabIndex = 4;
            button2.Text = "Exp&orter vers Excel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = System.Drawing.Color.Maroon;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.BurlyWood;
            button1.Location = new System.Drawing.Point(195, 11);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(55, 26);
            button1.TabIndex = 3;
            button1.Text = "&Fermer";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
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
            panel2.Size = new System.Drawing.Size(581, 38);
            panel2.TabIndex = 3;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBox2.ForeColor = System.Drawing.Color.White;
            checkBox2.Location = new System.Drawing.Point(307, 21);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(137, 18);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "inclure la date recquise";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBox1.ForeColor = System.Drawing.Color.White;
            checkBox1.Location = new System.Drawing.Point(307, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(166, 18);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "inclure la date de commande";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.ForeColor = System.Drawing.Color.White;
            button4.Location = new System.Drawing.Point(475, 12);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Rechercher";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_Click);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(165, 16);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(136, 22);
            dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(30, 16);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Black;
            label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            label3.Location = new System.Drawing.Point(143, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(19, 14);
            label3.TabIndex = 2;
            label3.Text = "au";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            label2.Location = new System.Drawing.Point(3, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(21, 14);
            label2.TabIndex = 1;
            label2.Text = "Du";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            label1.Location = new System.Drawing.Point(0, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 14);
            label1.TabIndex = 0;
            label1.Text = "Recherche par interval";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Black;
            panel4.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.ForeColor = System.Drawing.Color.White;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1045, 51);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(listView1);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(0, 51);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1045, 587);
            panel5.TabIndex = 3;
            // 
            // InventaireComptableElectrique
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1045, 676);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Icon = global::ControleurServeur.Properties.Resources.Auteur;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InventaireComptableElectrique";
            ShowInTaskbar = false;
            Text = System.Windows.Forms.Application.ProductName + ".InventaireComptableElectrique";
            Load += new System.EventHandler(InventaireComptableElectrique_Load);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion
        internal static ListView listView1;
        internal static ColumnHeader NoItem;
        internal static ColumnHeader Description;
        internal static ColumnHeader Manufacturier;
        internal static ColumnHeader QteBoite;
        internal static ColumnHeader Commentaire;
        internal static ColumnHeader Localisation;
        internal static ColumnHeader QteStock;
        internal static ColumnHeader comPerBox;
        internal static Panel panel1;
        internal static ColumnHeader Escompte;
        internal static ColumnHeader PrixNet;
        internal static ColumnHeader Total;
        internal static ColumnHeader Date;
        internal static Panel panel2;
        internal static System.Windows.Forms.Button button4;
        internal static DateTimePicker dateTimePicker2;
        internal static DateTimePicker dateTimePicker1;
        internal static System.Windows.Forms.Label label3;
        internal static System.Windows.Forms.Label label2;
        internal static System.Windows.Forms.Label label1;
        internal static Panel panel3;
        internal static System.Windows.Forms.Button button3;
        internal static System.Windows.Forms.Button button2;
        internal static System.Windows.Forms.Button button1;
        internal static System.Windows.Forms.CheckBox checkBox2;
        internal static System.Windows.Forms.CheckBox checkBox1;
        internal static Panel panel4;
        internal static Panel panel5;

        public InventaireComptableElectrique()
        {
            InitializeComponent();
        }
        private void InventaireComptableElectrique_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(30);
                SqlConnection con = new SqlConnection(Program.StringSQL);
                if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
                SqlDataReader reader = new SqlCommand($"SELECT DISTINCT *,[DBO].[Achat_Pieces].* FROM InventaireElec " +
                    $"JOIN [DBO].[Achat_Pieces] on[DBO].[InventaireElec].NoItem =[DBO].[Achat_Pieces].[PIECE]", con).ExecuteReader();
                while (reader.Read())
                {
                    /*
                    ID 0 : NoEnreg
                    ID 1 : NoItem
                    ID 2 : Description
                    ID 3 : Manufacturier
                    ID 4 : QteBoite
                    ID 5 : Prix Liste
                    ID 6 : Escompte
                    ID 7 : Prix net
                    ID 8 : Commentaires
                    ID 9 : Localisation
                    ID 10 : DeviseMonétaire
                    ID 11 : QuantitéStock
                    ID 12 : QuantitéCommandée
                    ID 13 : Minimum
                    ID 14 : QuantitéMinimum
                    ID 15 : Commande
                    ID 16 : NoProjet
                    ID 17 : CommandeParBoite
                    ID 18 : NoEnreg
                    ID 19 : IDAchat
                    ID 20 : IndexAchat
                    ID 21 : PIECE
                    ID 22 : NuméroLigne
                    ID 23 : Qté
                    ID 24 : Desc_FR
                    ID 25 : Desc_EN
                    ID 26 : Manufact
                    ID 27 : Prix_list
                    ID 28 : Escompte
                    ID 29 : Prix_net
                    ID 30 : IDFRS
                    ID 31 : Prix_total
                    ID 32 : Type
                    ID 33 : Commandé
                    ID 34 : Retour
                    ID 35 : NoRetour
                    ID 36 : Recu
                    ID 37 : DateRéception
                    ID 38 : QuantitéRecue
                    ID 39 : DateCommande
                    ID 40 : DateRequise
                    ID 41 : Inutile
                    ID 42 : CommandeAnnulée
                    ID 43 : DateRetour
                    ID 44 : PrixOrigine
                    ID 45 : Devise
                    ID 46 : NoEnreg
                    ID 47 : IDAchat
                    ID 48 : IndexAchat
                    ID 49 : PIECE
                    ID 50 : NuméroLigne
                    ID 51 : Qté
                    ID 52 : Desc_FR
                    ID 53 : Desc_EN
                    ID 54 : Manufact
                    ID 55 : Prix_list
                    ID 56 : Escompte
                    ID 57 : Prix_net
                    ID 58 : IDFRS
                    ID 59 : Prix_total
                    ID 60 : Type
                    ID 61 : Commandé
                    ID 62 : Retour
                    ID 63 : NoRetour
                    ID 64 : Recu
                    ID 65 : DateRéception
                    ID 66 : QuantitéRecue
                    ID 67 : DateCommande
                    ID 68 : DateRequise
                    ID 69 : Inutile
                    ID 70 : CommandeAnnulée
                    ID 71 : DateRetour
                    ID 72 : PrixOrigine
                    ID 73 : Devise
                    */
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
            oXLSheet.Range["A1: K1"].Value = new object[] { "NOITEM", "DESCRIPTION", "MANUFACTURIER", "QUANTITÉ PAR BOITE", "COMMENTAIRES", "LOCALISATION", "QUANTITÉSTOCK",
                "COMMANDÉPARBOITE", "ESCOMPTE", "PRIX NET", "TOTAL" };
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
                string sql = $"SELECT DISTINCT *,[DBO].[ACHAT_PIECES].* FROM INVENTAIREELEC JOIN [DBO].[ACHAT_PIECES] ON[DBO].[INVENTAIREELEC].NOITEM =[DBO].[ACHAT_PIECES].[PIECE] WHERE DATERÉCEPTION BETWEEN '{ConvertToUSDate(dateTimePicker1.Value)}' AND '{ConvertToUSDate(dateTimePicker2.Value)}'";
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