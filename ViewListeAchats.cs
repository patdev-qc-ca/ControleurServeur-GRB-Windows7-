
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
    public class ViewListeAchats : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewListeAchats));
            lblNumero = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            lblGTotal = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            txtIndexAchat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtRaison = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ViewTitre = new System.Windows.Forms.Label();
            lblDateImpression = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = System.Drawing.Color.White;
            lblNumero.Location = new System.Drawing.Point(114, 35);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new System.Drawing.Size(54, 13);
            lblNumero.TabIndex = 552;
            lblNumero.Text = "lblNumero";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(70, 52);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(30, 13);
            Label5.TabIndex = 553;
            Label5.Text = "Date";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Location = new System.Drawing.Point(114, 52);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(40, 13);
            lblDate.TabIndex = 554;
            lblDate.Text = "lblDate";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.White;
            Label12.Location = new System.Drawing.Point(12, 35);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(97, 13);
            Label12.TabIndex = 555;
            Label12.Text = "Numéro d\'ACHAT :";
            // 
            // lblGTotal
            // 
            lblGTotal.AutoSize = true;
            lblGTotal.BackColor = System.Drawing.Color.White;
            lblGTotal.Location = new System.Drawing.Point(1045, 773);
            lblGTotal.Name = "lblGTotal";
            lblGTotal.Size = new System.Drawing.Size(42, 13);
            lblGTotal.TabIndex = 557;
            lblGTotal.Text = "TOTAL";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = System.Drawing.Color.White;
            lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotal.Location = new System.Drawing.Point(1089, 773);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(49, 13);
            lblTotal.TabIndex = 558;
            lblTotal.Text = "lblTotal";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            txtIndexAchat,
            txtRaison,
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            columnHeader5,
            columnHeader6,
            columnHeader7,
            columnHeader8,
            columnHeader9,
            columnHeader10,
            columnHeader11});
            listView1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(21, 77);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1117, 671);
            listView1.TabIndex = 560;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtIndexAchat
            // 
            txtIndexAchat.Text = "IndexAchat";
            txtIndexAchat.Width = 69;
            // 
            // txtRaison
            // 
            txtRaison.Text = "Raison";
            txtRaison.Width = 90;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Qui";
            columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 43;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantité";
            columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Piece #";
            columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Description";
            columnHeader5.Width = 229;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Manufacturier";
            columnHeader6.Width = 141;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Fournisseur";
            columnHeader7.Width = 107;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Prix listé";
            columnHeader8.Width = 56;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Esc";
            columnHeader9.Width = 55;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Prix net";
            columnHeader10.Width = 50;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Prix total";
            columnHeader11.Width = 57;
            // 
            // ViewTitre
            // 
            ViewTitre.Dock = System.Windows.Forms.DockStyle.Top;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(0, 0);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(1150, 35);
            ViewTitre.TabIndex = 551;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Liste des achats";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateImpression
            // 
            lblDateImpression.AutoSize = true;
            lblDateImpression.Location = new System.Drawing.Point(17, 773);
            lblDateImpression.Name = "lblDateImpression";
            lblDateImpression.Size = new System.Drawing.Size(90, 13);
            lblDateImpression.TabIndex = 561;
            lblDateImpression.Text = "lblDateImpression";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(998, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(152, 71);
            pictureBox1.TabIndex = 562;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // ViewListeAchats
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1150, 795);
            Controls.Add(pictureBox1);
            Controls.Add(lblDateImpression);
            Controls.Add(lblNumero);
            Controls.Add(Label5);
            Controls.Add(lblDate);
            Controls.Add(Label12);
            Controls.Add(lblGTotal);
            Controls.Add(lblTotal);
            Controls.Add(listView1);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewListeAchats";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label ViewTitre;
        internal static Label lblNumero;
        internal static Label Label5;
        internal static Label lblDate;
        internal static Label Label12;
        internal static Label lblGTotal;
        internal static Label lblTotal;
        internal static ListView listView1;
        internal static ColumnHeader txtIndexAchat;
        internal static ColumnHeader txtRaison;
        internal static ColumnHeader columnHeader1;
        internal static ColumnHeader columnHeader2;
        internal static ColumnHeader columnHeader3;
        internal static ColumnHeader columnHeader4;
        internal static ColumnHeader columnHeader5;
        internal static ColumnHeader columnHeader6;
        internal static ColumnHeader columnHeader7;
        internal static ColumnHeader columnHeader8;
        internal static ColumnHeader columnHeader9;
        internal static ColumnHeader columnHeader10;
        internal static Label lblDateImpression;
        private PictureBox pictureBox1;
        internal static ColumnHeader columnHeader11;

        public ViewListeAchats()
        {
            InitializeComponent();
        }
        private void InitFormulaire(object sender, EventArgs e)
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
