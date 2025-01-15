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
    public class ViewListeContact : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewListeContact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Text1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Text6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbldepartement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(994, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 60);
            this.pictureBox1.TabIndex = 429;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Text1
            // 
            this.Text1.Text = "Contact";
            this.Text1.Width = 151;
            // 
            // Text2
            // 
            this.Text2.Text = "Compagnie";
            this.Text2.Width = 317;
            // 
            // Text3
            // 
            this.Text3.Text = "Téléphonne";
            this.Text3.Width = 80;
            // 
            // Text8
            // 
            this.Text8.Text = "Pagette";
            this.Text8.Width = 80;
            // 
            // Text7
            // 
            this.Text7.Text = "Celullaire";
            this.Text7.Width = 80;
            // 
            // Text4
            // 
            this.Text4.Text = "Poste#";
            this.Text4.Width = 52;
            // 
            // Text5
            // 
            this.Text5.Text = "Fax";
            this.Text5.Width = 80;
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
            this.Text8,
            this.Text7,
            this.Text4,
            this.Text5,
            this.Text6});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1145, 709);
            this.listView1.TabIndex = 428;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Text6
            // 
            this.Text6.Text = "E-Mail";
            this.Text6.Width = 170;
            // 
            // lbldepartement
            // 
            this.lbldepartement.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldepartement.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartement.Location = new System.Drawing.Point(0, 0);
            this.lbldepartement.Name = "lbldepartement";
            this.lbldepartement.Size = new System.Drawing.Size(1150, 44);
            this.lbldepartement.TabIndex = 427;
            this.lbldepartement.Tag = "";
            this.lbldepartement.Text = "Liste des Contacts";
            this.lbldepartement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewListeContact
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
            this.Name = "ViewListeContact";
            this.Load += new System.EventHandler(this.InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        internal PictureBox pictureBox1;
        internal ColumnHeader Text1;
        internal ColumnHeader Text2;
        internal ColumnHeader Text3;
        internal ColumnHeader Text8;
        internal ColumnHeader Text7;
        internal ColumnHeader Text4;
        internal ColumnHeader Text5;
        internal ListView listView1;
        internal ColumnHeader Text6;
        internal Label lbldepartement;

        public ViewListeContact()
        {
            InitializeComponent();
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        internal static ADODB.Recordset DataSource;
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
