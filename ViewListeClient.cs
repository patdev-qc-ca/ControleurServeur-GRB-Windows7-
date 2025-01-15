using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleurServeur;
namespace ControleurServeur
{
    public class ViewListeClient : Form
    {
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewListeClient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Text6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdresseLiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VilleLiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProvEtatLiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodePostalLiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Commentaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbldepartement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(994, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 62);
            this.pictureBox1.TabIndex = 426;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Text1
            // 
            this.Text1.Text = "Contact";
            this.Text1.Width = 102;
            // 
            // Text2
            // 
            this.Text2.Text = "Compagnie";
            this.Text2.Width = 202;
            // 
            // Text3
            // 
            this.Text3.Text = "Téléphonne";
            this.Text3.Width = 73;
            // 
            // Text5
            // 
            this.Text5.Text = "Fax";
            this.Text5.Width = 59;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Text1,
            this.Text2,
            this.Text3,
            this.Text5,
            this.Text6,
            this.AdresseLiv,
            this.VilleLiv,
            this.ProvEtatLiv,
            this.CodePostalLiv,
            this.Commentaire});
            this.listView1.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1126, 722);
            this.listView1.TabIndex = 425;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Text6
            // 
            this.Text6.Text = "E-Mail";
            this.Text6.Width = 135;
            // 
            // AdresseLiv
            // 
            this.AdresseLiv.Text = "Adresse";
            this.AdresseLiv.Width = 123;
            // 
            // VilleLiv
            // 
            this.VilleLiv.Text = "Ville";
            this.VilleLiv.Width = 140;
            // 
            // ProvEtatLiv
            // 
            this.ProvEtatLiv.Text = "Prov";
            this.ProvEtatLiv.Width = 76;
            // 
            // CodePostalLiv
            // 
            this.CodePostalLiv.Text = "C.P.";
            this.CodePostalLiv.Width = 50;
            // 
            // Commentaire
            // 
            this.Commentaire.Text = "Commentaire";
            this.Commentaire.Width = 162;
            // 
            // lbldepartement
            // 
            this.lbldepartement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldepartement.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartement.Location = new System.Drawing.Point(-1, 9);
            this.lbldepartement.Name = "lbldepartement";
            this.lbldepartement.Size = new System.Drawing.Size(1151, 34);
            this.lbldepartement.TabIndex = 424;
            this.lbldepartement.Tag = "";
            this.lbldepartement.Text = "Liste des clients";
            this.lbldepartement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 795);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbldepartement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewListeClient";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        internal PictureBox pictureBox1;
        internal ColumnHeader Text1;
        internal ColumnHeader Text2;
        internal ColumnHeader Text3;
        internal ColumnHeader Text5;
        internal ListView listView1;
        internal ColumnHeader Text6;
        internal Label lbldepartement;
        internal ColumnHeader AdresseLiv;
        internal ColumnHeader VilleLiv;
        internal ColumnHeader ProvEtatLiv;
        internal ColumnHeader CodePostalLiv;
        internal ColumnHeader Commentaire;

        public ViewListeClient()
        {
            InitializeComponent();
/*
 * 0[NomClient]
1[Compagnie]
2[Telephonne]
3[Fax]
4[Pagette]
5[Cellulaire]
6[ContactGRB]
7[Email]
8[AdresseLiv]
9[VilleLiv]
10[Prov / EtatLiv]
11[PaysLiv]
12[CodePostalLiv]
13[noposte]
14[Commentaire]
15[SiteWeb]
16[DateCréation]
17[UserCréation]
18[DateModification]
19[UserModification]
20[EntryIDOutlook]
21[Béton]
22[Pavé]
23[Pharmaceutique]
24[Agroalimentaire]
25[Meuble]
26[Meunerie]
27[Manufacturier]
28[Autre]
29[Consultant]
30[Asphalte]
31[ICPI]
32[Potentiel]
33[ProduitsChimiques]
34[Supprimé]
35[NomContact]
*/
         while (!DataSource.EOF) {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[35].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[1].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[2].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[3].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[7].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[8].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[9].Value}"));
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[10].Value}"));
                itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[12].Value}"));
                itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[14].Value}"));
                DataSource.MoveNext();
            }
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        Bitmap memoryImage;
        internal static ADODB.Recordset DataSource;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.DefaultPageSettings.Color = false;
            printDocument1.DefaultPageSettings.Landscape = Program.isLandscape; //pour le mode paysage
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.PrinterSettings.Copies = 1;
            printDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(Program.ImpressionFormulaire);
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Left, Top, 0, 0, s);
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
            memoryImage.Save($"{Name}_{Program.Now2String()}.png", System.Drawing.Imaging.ImageFormat.Png);
            if (MessageBox.Show("Voulez vous fermer cette vue?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
