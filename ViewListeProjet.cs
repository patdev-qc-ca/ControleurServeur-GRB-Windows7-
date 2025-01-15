
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
    public class ViewListeProjet : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewListeProjet));
            Text4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            listView1 = new System.Windows.Forms.ListView();
            Text5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblDateDebut = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            lblDateFin = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            ViewTitre = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // Text4
            // 
            Text4.Text = "Numéro de projet";
            Text4.Width = 113;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Text4,
            Text5});
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(21, 105);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(785, 997);
            listView1.TabIndex = 560;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // Text5
            // 
            Text5.Text = "Nombre d\'heures";
            Text5.Width = 642;
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.BackColor = System.Drawing.Color.White;
            lblDateDebut.Location = new System.Drawing.Point(93, 62);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new System.Drawing.Size(69, 13);
            lblDateDebut.TabIndex = 552;
            lblDateDebut.Text = "lblDateDebut";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(27, 79);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(44, 13);
            Label5.TabIndex = 553;
            Label5.Text = "Date fin";
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.BackColor = System.Drawing.Color.White;
            lblDateFin.Location = new System.Drawing.Point(93, 79);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new System.Drawing.Size(54, 13);
            lblDateFin.TabIndex = 554;
            lblDateFin.Text = "lblDateFin";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.White;
            Label12.Location = new System.Drawing.Point(27, 62);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(60, 13);
            Label12.TabIndex = 555;
            Label12.Text = "Date début";
            // 
            // ViewTitre
            // 
            ViewTitre.Dock = System.Windows.Forms.DockStyle.Top;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(0, 0);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(818, 45);
            ViewTitre.TabIndex = 551;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Solution GRB Inc.";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1});
            statusStrip1.Location = new System.Drawing.Point(0, 1039);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(818, 22);
            statusStrip1.TabIndex = 561;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(803, 17);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "lblNoPage";
            toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(666, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 62);
            pictureBox1.TabIndex = 562;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // ViewListeProjet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(lblDateDebut);
            Controls.Add(Label5);
            Controls.Add(lblDateFin);
            Controls.Add(Label12);
            Controls.Add(ViewTitre);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewListeProjet";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(InitFormulaire);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static ColumnHeader Text4;
        internal static ListView listView1;
        internal static Label lblDateDebut;
        internal static Label Label5;
        internal static Label lblDateFin;
        internal static Label Label12;
        internal static Label ViewTitre;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
        internal static ColumnHeader Text5;

        public ViewListeProjet()
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
            toolStripStatusLabel1.Text = $"     {ControleurServeur.Program.IdNomEmploye} {DateTime.Now.ToString()}";
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
