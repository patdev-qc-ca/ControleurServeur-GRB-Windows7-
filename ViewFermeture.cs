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
namespace ControleurServeur
{
    public class ViewFermeture : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFermeture));
            ViewTitre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTitre = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            txtNomJour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtProjet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtJournee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtKM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();// ViewTitre
            ViewTitre.BackColor = System.Drawing.SystemColors.Window;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(11, -4);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(818, 77);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Solution GRB Inc.";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;// pictureBox1
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(843, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);// lblTitre
            lblTitre.AutoSize = true;
            lblTitre.BackColor = System.Drawing.Color.White;
            lblTitre.Location = new System.Drawing.Point(14, 60);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new System.Drawing.Size(83, 13);
            lblTitre.TabIndex = 520;
            lblTitre.Text = "Feuille de temps";// listView1
            listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            txtNomJour,
            txtProjet,
            txtClient,
            txtDescription,
            txtJournee,
            txtA,
            txtTotal,
            txtKM});
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.HotTracking = true;
            listView1.HoverSelection = true;
            listView1.Location = new System.Drawing.Point(17, 86);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(994, 640);
            listView1.TabIndex = 521;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;// txtNomJour
            txtNomJour.Text = "Journée";// txtProjet
            txtProjet.Text = "Projet";
            txtProjet.Width = 97;// txtClient
            txtClient.Text = "Client";
            txtClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtClient.Width = 231;// txtDescription
            txtDescription.Text = "Description";
            txtDescription.Width = 348;// txtJournee
            txtJournee.Text = "De";
            txtJournee.Width = 74;// txtA
            txtA.Text = "À";// txtTotal
            txtTotal.Text = "Total";// txtKM
            txtKM.Text = "KM";// statusStrip1
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1});
            statusStrip1.Location = new System.Drawing.Point(0, 747);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1023, 22);
            statusStrip1.TabIndex = 522;
            statusStrip1.Text = "statusStrip1";// toolStripStatusLabel1
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(1008, 17);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolStripStatusLabel1.Click += new System.EventHandler(toolStripStatusLabel1_Click);// ViewFermeture
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1023, 769);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(lblTitre);
            Controls.Add(pictureBox1);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewFermeture";
            Text = Name;
            Load += new System.EventHandler(InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label ViewTitre;
        internal static ListView listView1;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel toolStripStatusLabel1;
        internal static ColumnHeader txtNomJour;
        internal static ColumnHeader txtProjet;
        internal static ColumnHeader txtClient;
        internal static ColumnHeader txtDescription;
        internal static ColumnHeader txtJournee;
        internal static ColumnHeader txtA;
        internal static ColumnHeader txtTotal;
        internal static ColumnHeader txtKM;
        internal static Label lblTitre;
        public ViewFermeture()
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
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }
    }
}