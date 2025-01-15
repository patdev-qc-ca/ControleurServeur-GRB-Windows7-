
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
    public class ViewSommairePunchGRB : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSommairePunchGRB));
            ViewTitre = new System.Windows.Forms.Label();
            lblDateDebut = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            lblDateFin = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label31 = new System.Windows.Forms.Label();
            lblGrandTotalKM = new System.Windows.Forms.Label();
            lblGrandTotal = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            txtNomJour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtProjet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Text1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtJournee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Text2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // ViewTitre
            // 
            ViewTitre.Dock = System.Windows.Forms.DockStyle.Top;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(0, 0);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(818, 83);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Solution GRB Inc.";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.BackColor = System.Drawing.Color.White;
            lblDateDebut.Location = new System.Drawing.Point(120, 53);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new System.Drawing.Size(37, 13);
            lblDateDebut.TabIndex = 522;
            lblDateDebut.Text = "99999";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(18, 70);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(44, 13);
            Label5.TabIndex = 525;
            Label5.Text = "Date fin";
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.BackColor = System.Drawing.Color.White;
            lblDateFin.Location = new System.Drawing.Point(120, 70);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new System.Drawing.Size(54, 13);
            lblDateFin.TabIndex = 526;
            lblDateFin.Text = "lblDateFin";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.White;
            Label12.Location = new System.Drawing.Point(18, 53);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(60, 13);
            Label12.TabIndex = 533;
            Label12.Text = "Date début";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(635, 1082);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(90, 13);
            Label3.TabIndex = 541;
            Label3.Text = "TOTAL HEURES";
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.BackColor = System.Drawing.Color.White;
            Label31.Location = new System.Drawing.Point(664, 1105);
            Label31.Name = "Label31";
            Label31.Size = new System.Drawing.Size(61, 13);
            Label31.TabIndex = 546;
            Label31.Text = "TOTAL KM";
            // 
            // lblGrandTotalKM
            // 
            lblGrandTotalKM.AutoSize = true;
            lblGrandTotalKM.BackColor = System.Drawing.Color.White;
            lblGrandTotalKM.Location = new System.Drawing.Point(731, 1105);
            lblGrandTotalKM.Name = "lblGrandTotalKM";
            lblGrandTotalKM.Size = new System.Drawing.Size(86, 13);
            lblGrandTotalKM.TabIndex = 548;
            lblGrandTotalKM.Text = "lblGrandTotalKM";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = System.Drawing.Color.White;
            lblGrandTotal.Location = new System.Drawing.Point(731, 1082);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new System.Drawing.Size(70, 13);
            lblGrandTotal.TabIndex = 549;
            lblGrandTotal.Text = "lblGrandTotal";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            txtNomJour,
            txtProjet,
            Text1,
            txtDescription,
            txtJournee,
            txtA,
            txtTotal,
            Text2});
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(16, 92);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(785, 975);
            listView1.TabIndex = 550;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtNomJour
            // 
            txtNomJour.Text = "Employé";
            txtNomJour.Width = 146;
            // 
            // txtProjet
            // 
            txtProjet.Text = "NoProjet";
            txtProjet.Width = 90;
            // 
            // Text1
            // 
            Text1.Text = "Date";
            Text1.Width = 67;
            // 
            // txtDescription
            // 
            txtDescription.Text = "Commentaire";
            txtDescription.Width = 301;
            // 
            // txtJournee
            // 
            txtJournee.Text = "Début à";
            // 
            // txtA
            // 
            txtA.Text = "Fin à";
            // 
            // txtTotal
            // 
            txtTotal.Text = "Total";
            // 
            // Text2
            // 
            Text2.Text = "NbreKM";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.Location = new System.Drawing.Point(638, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(180, 83);
            pictureBox1.TabIndex = 551;
            pictureBox1.TabStop = false;
            // 
            // ViewSommairePunchGRB
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Controls.Add(lblDateDebut);
            Controls.Add(Label5);
            Controls.Add(lblDateFin);
            Controls.Add(Label12);
            Controls.Add(Label3);
            Controls.Add(Label31);
            Controls.Add(lblGrandTotalKM);
            Controls.Add(lblGrandTotal);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewSommairePunchGRB";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(ViewBonTravail_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label ViewTitre;
        internal static Label lblDateDebut;
        internal static Label Label5;
        internal static Label lblDateFin;
        internal static Label Label12;
        internal static Label Label3;
        internal static Label Label31;
        internal static Label lblGrandTotalKM;
        internal static ListView listView1;
        internal static ColumnHeader txtNomJour;
        internal static ColumnHeader txtProjet;
        internal static ColumnHeader Text1;
        internal static ColumnHeader txtDescription;
        internal static ColumnHeader txtJournee;
        internal static ColumnHeader txtA;
        internal static ColumnHeader txtTotal;
        internal static ColumnHeader Text2;
        private PictureBox pictureBox1;
        internal static Label lblGrandTotal;

        public ViewSommairePunchGRB()
        {
            InitializeComponent();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        private void ViewBonTravail_Load(object sender, EventArgs e) => Text = Application.ProductName + "." + Name;
        Bitmap memoryImage;
        PrintDocument printDocument1 = new PrintDocument();
        private void pictureBox1_Click(object sender, EventArgs e)
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