
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleurServeur;
namespace ControleurServeur
{
    public class ViewFaxFrancais : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFaxFrancais));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblTitreBC = new System.Windows.Forms.Label();
            lblTitreNoSoum = new System.Windows.Forms.Label();
            txtDate = new System.Windows.Forms.TextBox();
            txtProjet = new System.Windows.Forms.TextBox();
            txtlAttention = new System.Windows.Forms.TextBox();
            txtFax = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            txtEntreprise = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            txtPage = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            txtDe = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            txtSujet = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            txtMessage = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::ControleurServeur.Properties.Resources.logo_GRB_inc_2;
            pictureBox1.Location = new System.Drawing.Point(233, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(275, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(386, 145);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(139, 16);
            label4.TabIndex = 8;
            label4.Text = "Fax: (450) 372-3860";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(220, 145);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 16);
            label3.TabIndex = 7;
            label3.Text = "Tel: (450) 372-0021";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(250, 127);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(258, 16);
            label2.TabIndex = 6;
            label2.Text = "St-Alphonse-de-Granby, QC J0E 2A4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(275, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(169, 16);
            label1.TabIndex = 5;
            label1.Text = "149, rue Pierre Paradis,";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(68, 200);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(44, 16);
            label7.TabIndex = 332;
            label7.Text = "Date ";
            // 
            // lblTitreBC
            // 
            lblTitreBC.AutoSize = true;
            lblTitreBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreBC.Location = new System.Drawing.Point(452, 200);
            lblTitreBC.Name = "lblTitreBC";
            lblTitreBC.Size = new System.Drawing.Size(56, 16);
            lblTitreBC.TabIndex = 336;
            lblTitreBC.Text = "Projet#";
            // 
            // lblTitreNoSoum
            // 
            lblTitreNoSoum.AutoSize = true;
            lblTitreNoSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreNoSoum.Location = new System.Drawing.Point(68, 226);
            lblTitreNoSoum.Name = "lblTitreNoSoum";
            lblTitreNoSoum.Size = new System.Drawing.Size(114, 16);
            lblTitreNoSoum.TabIndex = 334;
            lblTitreNoSoum.Text = "À l\'attention de ";
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(181, 199);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(252, 20);
            txtDate.TabIndex = 358;
            // 
            // txtProjet
            // 
            txtProjet.Location = new System.Drawing.Point(515, 199);
            txtProjet.Name = "txtProjet";
            txtProjet.Size = new System.Drawing.Size(143, 20);
            txtProjet.TabIndex = 359;
            // 
            // txtlAttention
            // 
            txtlAttention.Location = new System.Drawing.Point(578, 329);
            txtlAttention.Name = "txtlAttention";
            txtlAttention.Size = new System.Drawing.Size(80, 20);
            txtlAttention.TabIndex = 360;
            // 
            // txtFax
            // 
            txtFax.Location = new System.Drawing.Point(181, 252);
            txtFax.Name = "txtFax";
            txtFax.Size = new System.Drawing.Size(476, 20);
            txtFax.TabIndex = 362;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label9.Location = new System.Drawing.Point(68, 278);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(86, 16);
            label9.TabIndex = 361;
            label9.Text = "Télécopie#";
            // 
            // txtEntreprise
            // 
            txtEntreprise.Location = new System.Drawing.Point(181, 225);
            txtEntreprise.Name = "txtEntreprise";
            txtEntreprise.Size = new System.Drawing.Size(477, 20);
            txtEntreprise.TabIndex = 364;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label12.Location = new System.Drawing.Point(68, 252);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(78, 16);
            label12.TabIndex = 363;
            label12.Text = "Entreprise";
            // 
            // txtPage
            // 
            txtPage.Location = new System.Drawing.Point(578, 299);
            txtPage.Name = "txtPage";
            txtPage.Size = new System.Drawing.Size(79, 20);
            txtPage.TabIndex = 366;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label13.Location = new System.Drawing.Point(345, 299);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(232, 16);
            label13.TabIndex = 365;
            label13.Text = "nombre de page incluant celle ci";
            // 
            // txtDe
            // 
            txtDe.Location = new System.Drawing.Point(181, 325);
            txtDe.Name = "txtDe";
            txtDe.Size = new System.Drawing.Size(360, 20);
            txtDe.TabIndex = 368;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label14.Location = new System.Drawing.Point(547, 329);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(29, 16);
            label14.TabIndex = 367;
            label14.Text = "de ";
            // 
            // txtSujet
            // 
            txtSujet.Location = new System.Drawing.Point(181, 278);
            txtSujet.Name = "txtSujet";
            txtSujet.Size = new System.Drawing.Size(315, 20);
            txtSujet.TabIndex = 370;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label15.Location = new System.Drawing.Point(68, 329);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(44, 16);
            label15.TabIndex = 369;
            label15.Text = "Objet";
            // 
            // txtMessage
            // 
            txtMessage.Location = new System.Drawing.Point(68, 390);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new System.Drawing.Size(608, 369);
            txtMessage.TabIndex = 372;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(68, 371);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 16);
            label5.TabIndex = 371;
            label5.Text = "Message";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 952);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(818, 109);
            panel1.TabIndex = 373;
            // 
            // label6
            // 
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(818, 109);
            label6.TabIndex = 0;
            label6.Text = resources.GetString("label6.Text");
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(0, 889);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(818, 63);
            label8.TabIndex = 374;
            label8.Text = "SI VOUS N\'AVEZ PAS REÇU LE NOMBRE DE PAGE(S) INSCRIT, VEUILLEZ COMMUNIQUER AVEC N" +
    "OUS";
            label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewFaxFrancais
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(txtMessage);
            Controls.Add(label5);
            Controls.Add(txtSujet);
            Controls.Add(label15);
            Controls.Add(txtDe);
            Controls.Add(label14);
            Controls.Add(txtPage);
            Controls.Add(label13);
            Controls.Add(txtEntreprise);
            Controls.Add(label12);
            Controls.Add(txtFax);
            Controls.Add(label9);
            Controls.Add(txtlAttention);
            Controls.Add(txtProjet);
            Controls.Add(txtDate);
            Controls.Add(lblTitreBC);
            Controls.Add(lblTitreNoSoum);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewFaxFrancais";
            ShowInTaskbar = false;
            Text = "ViewFaxFrancais";
            Load += new System.EventHandler(ViewFaxFrancais_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label label4;
        internal static Label label3;
        internal static Label label2;
        internal static Label label1;
        internal static Label label7;
        internal static Label lblTitreBC;
        internal static Label lblTitreNoSoum;
        internal static TextBox txtDate;
        internal static TextBox txtProjet;
        internal static TextBox txtlAttention;
        internal static TextBox txtFax;
        internal static Label label9;
        internal static TextBox txtEntreprise;
        internal static Label label12;
        internal static TextBox txtPage;
        internal static Label label13;
        internal static TextBox txtDe;
        internal static Label label14;
        internal static TextBox txtSujet;
        internal static Label label15;
        internal static TextBox txtMessage;
        internal static Label label5;
        internal static Panel panel1;
        internal static Label label6;
        internal static Label label8;

        private void PrintForm()
        {
            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Left, Top, 0, 0, s);
        }
        public ViewFaxFrancais()
        {
            InitializeComponent();
        }
        public ViewFaxFrancais(string lblDate, string lblNoProjetSoum, string lblProjet, string lblAttention,
            string lblEntreprise, string lblFax, string lblSujet, string lblPage, string lblDe, string lblMessage)
        {
            InitializeComponent();
            lblDate = lblDate;
            lblNoProjetSoum = lblNoProjetSoum;
            lblProjet = lblProjet;
            lblAttention = lblAttention;
            lblEntreprise = lblEntreprise;
            lblFax = lblFax;
            if (lblProjet == "" & lblNoProjetSoum != "")
            {
                txtDe.Text = "Soumission n~" + lblNoProjetSoum;
            }
            else
            {
                lblDe = lblDe;
            }
            lblSujet = lblSujet;
            lblPage = lblPage;
            lblMessage = lblMessage;
        }
        private void ViewFaxFrancais_Load(object sender, EventArgs e)
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
