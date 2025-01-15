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
    public class ViewCommandeRecue : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCommandeRecue));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbldatereq = new System.Windows.Forms.Label();
            lbltitrefournisseur = new System.Windows.Forms.Label();
            lblfournisseur = new System.Windows.Forms.Label();
            Label19 = new System.Windows.Forms.Label();
            lblprojet = new System.Windows.Forms.Label();
            lblNoProjet = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            Text1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtNoItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtManufact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtLocalisation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(973, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lbldatereq
            // 
            lbldatereq.BackColor = System.Drawing.Color.White;
            lbldatereq.Location = new System.Drawing.Point(920, 741);
            lbldatereq.Name = "lbldatereq";
            lbldatereq.Size = new System.Drawing.Size(101, 19);
            lbldatereq.TabIndex = 565;
            lbldatereq.Text = "lbldatereq";
            // 
            // lbltitrefournisseur
            // 
            lbltitrefournisseur.AutoSize = true;
            lbltitrefournisseur.BackColor = System.Drawing.Color.White;
            lbltitrefournisseur.Location = new System.Drawing.Point(17, 19);
            lbltitrefournisseur.MinimumSize = new System.Drawing.Size(60, 19);
            lbltitrefournisseur.Name = "lbltitrefournisseur";
            lbltitrefournisseur.Size = new System.Drawing.Size(85, 19);
            lbltitrefournisseur.TabIndex = 531;
            lbltitrefournisseur.Text = "lbltitrefournisseur";
            // 
            // lblfournisseur
            // 
            lblfournisseur.BackColor = System.Drawing.Color.White;
            lblfournisseur.Location = new System.Drawing.Point(123, 19);
            lblfournisseur.MinimumSize = new System.Drawing.Size(60, 19);
            lblfournisseur.Name = "lblfournisseur";
            lblfournisseur.Size = new System.Drawing.Size(286, 19);
            lblfournisseur.TabIndex = 532;
            lblfournisseur.Text = "lblfournisseur";
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.BackColor = System.Drawing.Color.White;
            Label19.Location = new System.Drawing.Point(803, 741);
            Label19.Name = "Label19";
            Label19.Size = new System.Drawing.Size(100, 13);
            Label19.TabIndex = 559;
            Label19.Text = "Date de commande";
            // 
            // lblprojet
            // 
            lblprojet.AutoSize = true;
            lblprojet.BackColor = System.Drawing.Color.White;
            lblprojet.Location = new System.Drawing.Point(462, 19);
            lblprojet.Name = "lblprojet";
            lblprojet.Size = new System.Drawing.Size(43, 13);
            lblprojet.TabIndex = 560;
            lblprojet.Text = "lblprojet";
            // 
            // lblNoProjet
            // 
            lblNoProjet.AutoSize = true;
            lblNoProjet.BackColor = System.Drawing.Color.White;
            lblNoProjet.Location = new System.Drawing.Point(415, 19);
            lblNoProjet.Name = "lblNoProjet";
            lblNoProjet.Size = new System.Drawing.Size(41, 13);
            lblNoProjet.TabIndex = 561;
            lblNoProjet.Text = "Projet#";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Text1,
            txtNoItem,
            txtDescription,
            txtManufact,
            txtLocalisation,
            columnHeader1});
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(12, 74);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1126, 664);
            listView1.TabIndex = 566;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Text1
            // 
            Text1.Text = "Quantité";
            // 
            // txtNoItem
            // 
            txtNoItem.Text = "Item#";
            // 
            // txtDescription
            // 
            txtDescription.Text = "Description";
            // 
            // txtManufact
            // 
            txtManufact.Text = "Manufacturier";
            // 
            // txtLocalisation
            // 
            txtLocalisation.Text = "Localisation";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Quantité Reçue";
            // 
            // ViewCommandeRecue
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1150, 795);
            Controls.Add(listView1);
            Controls.Add(lbldatereq);
            Controls.Add(lbltitrefournisseur);
            Controls.Add(lblfournisseur);
            Controls.Add(Label19);
            Controls.Add(lblprojet);
            Controls.Add(lblNoProjet);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewCommandeRecue";
            ShowInTaskbar = false;
            Load += new System.EventHandler(InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label lbldatereq;
        internal static Label lbltitrefournisseur;
        internal static Label lblfournisseur;
        internal static Label Label19;
        internal static Label lblprojet;
        internal static ListView listView1;
        internal static ColumnHeader Text1;
        internal static ColumnHeader txtNoItem;
        internal static ColumnHeader txtDescription;
        internal static ColumnHeader txtManufact;
        internal static ColumnHeader txtLocalisation;
        internal static ColumnHeader columnHeader1;
        internal static Label lblNoProjet;

        public ViewCommandeRecue()
        {
            InitializeComponent();
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        internal static  ADODB.Recordset DataSource;
        Bitmap memoryImage;
        internal static  bool Orientation;
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
