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
    public class ViewListePiece : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewListePiece));
            ViewTitre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblProjet = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            lblTitreProjet = new System.Windows.Forms.Label();
            lblsoumission = new System.Windows.Forms.Label();
            lblTitreSoumission = new System.Windows.Forms.Label();
            lblTitreDescription = new System.Windows.Forms.Label();
            lblTitreNoFacture = new System.Windows.Forms.Label();
            lbldescription = new System.Windows.Forms.Label();
            lblNoFacture = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            lblTitreQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreNoItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreDescription1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreManufacturier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Label3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // ViewTitre
            // 
            ViewTitre.AutoSize = true;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(11, 8);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(193, 36);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Liste de pieces";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(972, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblProjet
            // 
            lblProjet.AutoSize = true;
            lblProjet.BackColor = System.Drawing.Color.White;
            lblProjet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjet.Location = new System.Drawing.Point(148, 51);
            lblProjet.Name = "lblProjet";
            lblProjet.Size = new System.Drawing.Size(68, 19);
            lblProjet.TabIndex = 566;
            lblProjet.Text = "lblProjet";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = System.Drawing.Color.White;
            lblClient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClient.Location = new System.Drawing.Point(513, 51);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(49, 19);
            lblClient.TabIndex = 522;
            lblClient.Text = "99999";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.White;
            Label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.Location = new System.Drawing.Point(449, 69);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(62, 19);
            Label5.TabIndex = 525;
            Label5.Text = "Contact";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = System.Drawing.Color.White;
            lblContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblContact.Location = new System.Drawing.Point(513, 69);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(79, 19);
            lblContact.TabIndex = 526;
            lblContact.Text = "lblContact";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.White;
            Label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label12.Location = new System.Drawing.Point(449, 51);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(48, 19);
            Label12.TabIndex = 533;
            Label12.Text = "Client";
            // 
            // lblTitreProjet
            // 
            lblTitreProjet.AutoSize = true;
            lblTitreProjet.BackColor = System.Drawing.Color.White;
            lblTitreProjet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjet.Location = new System.Drawing.Point(17, 51);
            lblTitreProjet.Name = "lblTitreProjet";
            lblTitreProjet.Size = new System.Drawing.Size(100, 19);
            lblTitreProjet.TabIndex = 552;
            lblTitreProjet.Text = "lblTitreProjet";
            // 
            // lblsoumission
            // 
            lblsoumission.AutoSize = true;
            lblsoumission.BackColor = System.Drawing.Color.White;
            lblsoumission.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblsoumission.Location = new System.Drawing.Point(147, 69);
            lblsoumission.Name = "lblsoumission";
            lblsoumission.Size = new System.Drawing.Size(101, 19);
            lblsoumission.TabIndex = 553;
            lblsoumission.Text = "lblsoumission";
            // 
            // lblTitreSoumission
            // 
            lblTitreSoumission.AutoSize = true;
            lblTitreSoumission.BackColor = System.Drawing.Color.White;
            lblTitreSoumission.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreSoumission.Location = new System.Drawing.Point(15, 69);
            lblTitreSoumission.Name = "lblTitreSoumission";
            lblTitreSoumission.Size = new System.Drawing.Size(135, 19);
            lblTitreSoumission.TabIndex = 554;
            lblTitreSoumission.Text = "lblTitreSoumission";
            // 
            // lblTitreDescription
            // 
            lblTitreDescription.AutoSize = true;
            lblTitreDescription.BackColor = System.Drawing.Color.White;
            lblTitreDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreDescription.Location = new System.Drawing.Point(16, 88);
            lblTitreDescription.Name = "lblTitreDescription";
            lblTitreDescription.Size = new System.Drawing.Size(94, 19);
            lblTitreDescription.TabIndex = 559;
            lblTitreDescription.Text = "Description: ";
            // 
            // lblTitreNoFacture
            // 
            lblTitreNoFacture.AutoSize = true;
            lblTitreNoFacture.BackColor = System.Drawing.Color.White;
            lblTitreNoFacture.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreNoFacture.Location = new System.Drawing.Point(17, 108);
            lblTitreNoFacture.Name = "lblTitreNoFacture";
            lblTitreNoFacture.Size = new System.Drawing.Size(60, 19);
            lblTitreNoFacture.TabIndex = 560;
            lblTitreNoFacture.Text = "Facture";
            // 
            // lbldescription
            // 
            lbldescription.AutoSize = true;
            lbldescription.BackColor = System.Drawing.Color.White;
            lbldescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbldescription.Location = new System.Drawing.Point(147, 88);
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new System.Drawing.Size(102, 19);
            lbldescription.TabIndex = 569;
            lbldescription.Text = "lbldescription";
            // 
            // lblNoFacture
            // 
            lblNoFacture.AutoSize = true;
            lblNoFacture.BackColor = System.Drawing.Color.White;
            lblNoFacture.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoFacture.Location = new System.Drawing.Point(147, 108);
            lblNoFacture.Name = "lblNoFacture";
            lblNoFacture.Size = new System.Drawing.Size(97, 19);
            lblNoFacture.TabIndex = 585;
            lblNoFacture.Text = "lblNoFacture";
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.Color.White;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lblTitreQuantite,
            lblTitreNoItem,
            lblTitreDescription1,
            lblTitreManufacturier,
            lblTitreid,
            Label3});
            listView1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(17, 142);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1121, 641);
            listView1.TabIndex = 586;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // lblTitreQuantite
            // 
            lblTitreQuantite.Text = "Quantité";
            lblTitreQuantite.Width = 84;
            // 
            // lblTitreNoItem
            // 
            lblTitreNoItem.Text = "#Item";
            lblTitreNoItem.Width = 129;
            // 
            // lblTitreDescription1
            // 
            lblTitreDescription1.Text = "Description";
            lblTitreDescription1.Width = 330;
            // 
            // lblTitreManufacturier
            // 
            lblTitreManufacturier.Text = "Manufacturier";
            lblTitreManufacturier.Width = 286;
            // 
            // lblTitreid
            // 
            lblTitreid.Text = "#ID";
            // 
            // Label3
            // 
            Label3.Text = "CSA Vérifié";
            Label3.Width = 87;
            // 
            // ViewListePiece
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1150, 795);
            Controls.Add(listView1);
            Controls.Add(lblNoFacture);
            Controls.Add(lbldescription);
            Controls.Add(lblProjet);
            Controls.Add(lblClient);
            Controls.Add(Label5);
            Controls.Add(lblContact);
            Controls.Add(Label12);
            Controls.Add(lblTitreProjet);
            Controls.Add(lblsoumission);
            Controls.Add(lblTitreSoumission);
            Controls.Add(lblTitreDescription);
            Controls.Add(lblTitreNoFacture);
            Controls.Add(pictureBox1);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewListePiece";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label ViewTitre;
        internal static Label lblProjet;
        internal static Label lblClient;
        internal static Label Label5;
        internal static Label lblContact;
        internal static Label Label12;
        internal static Label lblTitreProjet;
        internal static Label lblsoumission;
        internal static Label lblTitreSoumission;
        internal static Label lblTitreDescription;
        internal static Label lblTitreNoFacture;
        internal static Label lbldescription;
        internal static ListView listView1;
        internal static ColumnHeader lblTitreQuantite;
        internal static ColumnHeader lblTitreNoItem;
        internal static ColumnHeader lblTitreDescription1;
        internal static ColumnHeader lblTitreManufacturier;
        internal static ColumnHeader lblTitreid;
        internal static ColumnHeader Label3;
        internal static Label lblNoFacture;

        public ViewListePiece()
        {
            InitializeComponent();
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        internal static ADODB.Recordset DataSource;
        internal static  bool Orientation;
        public static Label lblDate;
        Bitmap memoryImage;
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
