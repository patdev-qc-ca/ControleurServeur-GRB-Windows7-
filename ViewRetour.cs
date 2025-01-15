
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
    public class ViewRetour : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRetour));
            lblTitreCommande = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblFournisseur = new System.Windows.Forms.Label();
            lblTitreProjet = new System.Windows.Forms.Label();
            lblNoProjet = new System.Windows.Forms.Label();
            lblTitreRMA = new System.Windows.Forms.Label();
            lblNoRMA = new System.Windows.Forms.Label();
            lblTitreDate = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblTitreFournisseur = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            lblTitreQte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitrePiece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreManufact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreTransport = new System.Windows.Forms.Label();
            Shape42 = new System.Windows.Forms.Panel();
            Shape41 = new System.Windows.Forms.Panel();
            lblTitreRecepteur = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblTitreDateReception = new System.Windows.Forms.Label();
            Shape39 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            lblTitreExpiditeur = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblNoPage = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            Shape39.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitreCommande
            // 
            lblTitreCommande.AutoSize = true;
            lblTitreCommande.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreCommande.Location = new System.Drawing.Point(10, 3);
            lblTitreCommande.Name = "lblTitreCommande";
            lblTitreCommande.Size = new System.Drawing.Size(342, 36);
            lblTitreCommande.TabIndex = 418;
            lblTitreCommande.Tag = "";
            lblTitreCommande.Text = "RETOUR DE MARCHANDISE";
            lblTitreCommande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(638, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblFournisseur
            // 
            lblFournisseur.BackColor = System.Drawing.Color.White;
            lblFournisseur.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFournisseur.Location = new System.Drawing.Point(106, 42);
            lblFournisseur.Name = "lblFournisseur";
            lblFournisseur.Size = new System.Drawing.Size(200, 19);
            lblFournisseur.TabIndex = 522;
            lblFournisseur.Text = "lblFournisseur";
            // 
            // lblTitreProjet
            // 
            lblTitreProjet.AutoSize = true;
            lblTitreProjet.BackColor = System.Drawing.Color.White;
            lblTitreProjet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjet.Location = new System.Drawing.Point(36, 61);
            lblTitreProjet.Name = "lblTitreProjet";
            lblTitreProjet.Size = new System.Drawing.Size(63, 18);
            lblTitreProjet.TabIndex = 525;
            lblTitreProjet.Text = "# Projet :";
            // 
            // lblNoProjet
            // 
            lblNoProjet.BackColor = System.Drawing.Color.White;
            lblNoProjet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoProjet.Location = new System.Drawing.Point(106, 61);
            lblNoProjet.Name = "lblNoProjet";
            lblNoProjet.Size = new System.Drawing.Size(200, 19);
            lblNoProjet.TabIndex = 526;
            lblNoProjet.Text = "lblNoProjet";
            // 
            // lblTitreRMA
            // 
            lblTitreRMA.AutoSize = true;
            lblTitreRMA.BackColor = System.Drawing.Color.White;
            lblTitreRMA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreRMA.Location = new System.Drawing.Point(44, 81);
            lblTitreRMA.Name = "lblTitreRMA";
            lblTitreRMA.Size = new System.Drawing.Size(55, 18);
            lblTitreRMA.TabIndex = 527;
            lblTitreRMA.Text = "# RMA :";
            // 
            // lblNoRMA
            // 
            lblNoRMA.BackColor = System.Drawing.Color.White;
            lblNoRMA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoRMA.Location = new System.Drawing.Point(106, 80);
            lblNoRMA.Name = "lblNoRMA";
            lblNoRMA.Size = new System.Drawing.Size(200, 19);
            lblNoRMA.TabIndex = 528;
            lblNoRMA.Text = "lblNoRMA";
            // 
            // lblTitreDate
            // 
            lblTitreDate.AutoSize = true;
            lblTitreDate.BackColor = System.Drawing.Color.White;
            lblTitreDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreDate.Location = new System.Drawing.Point(62, 99);
            lblTitreDate.Name = "lblTitreDate";
            lblTitreDate.Size = new System.Drawing.Size(37, 18);
            lblTitreDate.TabIndex = 531;
            lblTitreDate.Text = "Date";
            // 
            // lblDate
            // 
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDate.Location = new System.Drawing.Point(106, 99);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(200, 19);
            lblDate.TabIndex = 532;
            lblDate.Text = "lblDate";
            // 
            // lblTitreFournisseur
            // 
            lblTitreFournisseur.AutoSize = true;
            lblTitreFournisseur.BackColor = System.Drawing.Color.White;
            lblTitreFournisseur.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreFournisseur.Location = new System.Drawing.Point(18, 43);
            lblTitreFournisseur.Name = "lblTitreFournisseur";
            lblTitreFournisseur.Size = new System.Drawing.Size(81, 18);
            lblTitreFournisseur.TabIndex = 533;
            lblTitreFournisseur.Text = "Fournisseur";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lblTitreQte,
            lblTitrePiece,
            lblTitreDescription,
            lblTitreManufact});
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(22, 132);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(772, 835);
            listView1.TabIndex = 534;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // lblTitreQte
            // 
            lblTitreQte.Text = "Quantité";
            // 
            // lblTitrePiece
            // 
            lblTitrePiece.Text = "# Piece";
            lblTitrePiece.Width = 93;
            // 
            // lblTitreDescription
            // 
            lblTitreDescription.Text = "Description";
            lblTitreDescription.Width = 315;
            // 
            // lblTitreManufact
            // 
            lblTitreManufact.Text = "Manufacturier";
            lblTitreManufact.Width = 289;
            // 
            // lblTitreTransport
            // 
            lblTitreTransport.AutoSize = true;
            lblTitreTransport.Location = new System.Drawing.Point(44, 999);
            lblTitreTransport.Name = "lblTitreTransport";
            lblTitreTransport.Size = new System.Drawing.Size(83, 13);
            lblTitreTransport.TabIndex = 535;
            lblTitreTransport.Text = "lblTitreTransport";
            // 
            // Shape42
            // 
            Shape42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Shape42.Location = new System.Drawing.Point(124, 990);
            Shape42.Name = "Shape42";
            Shape42.Size = new System.Drawing.Size(200, 40);
            Shape42.TabIndex = 536;
            // 
            // Shape41
            // 
            Shape41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Shape41.Location = new System.Drawing.Point(124, 1036);
            Shape41.Name = "Shape41";
            Shape41.Size = new System.Drawing.Size(200, 40);
            Shape41.TabIndex = 538;
            // 
            // lblTitreRecepteur
            // 
            lblTitreRecepteur.AutoSize = true;
            lblTitreRecepteur.Location = new System.Drawing.Point(44, 1045);
            lblTitreRecepteur.Name = "lblTitreRecepteur";
            lblTitreRecepteur.Size = new System.Drawing.Size(75, 13);
            lblTitreRecepteur.TabIndex = 537;
            lblTitreRecepteur.Text = "Ramassé par :";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Location = new System.Drawing.Point(440, 1036);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(200, 40);
            panel1.TabIndex = 542;
            // 
            // lblTitreDateReception
            // 
            lblTitreDateReception.AutoSize = true;
            lblTitreDateReception.Location = new System.Drawing.Point(360, 1045);
            lblTitreDateReception.Name = "lblTitreDateReception";
            lblTitreDateReception.Size = new System.Drawing.Size(33, 13);
            lblTitreDateReception.TabIndex = 541;
            lblTitreDateReception.Text = "Date:";
            // 
            // Shape39
            // 
            Shape39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Shape39.Controls.Add(label2);
            Shape39.Location = new System.Drawing.Point(440, 990);
            Shape39.Name = "Shape39";
            Shape39.Size = new System.Drawing.Size(200, 40);
            Shape39.TabIndex = 540;
            // 
            // label2
            // 
            label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label2.Location = new System.Drawing.Point(135, -1);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 22);
            label2.TabIndex = 0;
            label2.Text = "No: ";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitreExpiditeur
            // 
            lblTitreExpiditeur.AutoSize = true;
            lblTitreExpiditeur.Location = new System.Drawing.Point(360, 999);
            lblTitreExpiditeur.Name = "lblTitreExpiditeur";
            lblTitreExpiditeur.Size = new System.Drawing.Size(72, 13);
            lblTitreExpiditeur.TabIndex = 539;
            lblTitreExpiditeur.Text = "Expédié par : ";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblNoPage});
            statusStrip1.Location = new System.Drawing.Point(0, 1039);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(818, 22);
            statusStrip1.TabIndex = 543;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblNoPage
            // 
            lblNoPage.Name = "lblNoPage";
            lblNoPage.Size = new System.Drawing.Size(803, 17);
            lblNoPage.Spring = true;
            lblNoPage.Text = "Page %p de %P";
            lblNoPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewRetour
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(Shape41);
            Controls.Add(lblTitreDateReception);
            Controls.Add(lblTitreRecepteur);
            Controls.Add(Shape39);
            Controls.Add(lblTitreExpiditeur);
            Controls.Add(Shape42);
            Controls.Add(lblTitreTransport);
            Controls.Add(listView1);
            Controls.Add(lblFournisseur);
            Controls.Add(lblTitreProjet);
            Controls.Add(lblNoProjet);
            Controls.Add(lblTitreRMA);
            Controls.Add(lblNoRMA);
            Controls.Add(lblTitreDate);
            Controls.Add(lblDate);
            Controls.Add(lblTitreFournisseur);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitreCommande);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewRetour";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(ViewBonTravail_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            Shape39.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label lblTitreCommande;
        internal static Label lblFournisseur;
        internal static Label lblTitreProjet;
        internal static Label lblNoProjet;
        internal static Label lblTitreRMA;
        internal static Label lblNoRMA;
        internal static Label lblTitreDate;
        internal static Label lblDate;
        internal static ListView listView1;
        internal static ColumnHeader lblTitreQte;
        internal static ColumnHeader lblTitrePiece;
        internal static ColumnHeader lblTitreDescription;
        internal static ColumnHeader lblTitreManufact;
        internal static Label lblTitreTransport;
        internal static Panel Shape42;
        internal static Panel Shape41;
        internal static Label lblTitreRecepteur;
        internal static Panel panel1;
        internal static Label lblTitreDateReception;
        internal static Panel Shape39;
        internal static Label label2;
        internal static Label lblTitreExpiditeur;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel lblNoPage;
        internal static Label lblTitreFournisseur;

        public ViewRetour()
        {
            InitializeComponent();
        }
        private void ViewBonTravail_Load(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        Bitmap memoryImage;
        internal static bool Orientation;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.DefaultPageSettings.Color = false;
                printDocument1.DefaultPageSettings.Landscape = !ControleurServeur.Program.isLandscape; //pour le mode paysage
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.PrinterSettings.Copies = 1;
                printDialog1.Document = printDocument1;
                printDocument1.PrintPage += new PrintPageEventHandler(ImpressionFormulaire);
                Graphics myGraphics = CreateGraphics();
                Size s = Size;
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
            }
            if (MessageBox.Show("Voulez vous fermer cette vue?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
