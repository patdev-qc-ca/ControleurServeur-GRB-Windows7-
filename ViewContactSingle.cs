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
namespace ControleurServeur
{
    public class ViewContactSingle : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewContactSingle));
            this.ViewTitre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewTitre
            // 
            this.ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTitre.Location = new System.Drawing.Point(55, 36);
            this.ViewTitre.Name = "ViewTitre";
            this.ViewTitre.Size = new System.Drawing.Size(492, 78);
            this.ViewTitre.TabIndex = 386;
            this.ViewTitre.Tag = "";
            this.ViewTitre.Text = "Contacts";
            this.ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 386;
            this.label5.Text = "Nom du contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 388;
            this.label6.Text = "Compagnie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 390;
            this.label7.Text = "Téléphone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 392;
            this.label8.Text = "Pagette";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(245, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 394;
            this.label9.Text = "Cellulaire ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(245, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 19);
            this.label11.TabIndex = 398;
            this.label11.Text = "Fax";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(245, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 400;
            this.label12.Text = "E-mail";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1105);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 406;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(733, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel2.Text = "Page 1 sur 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(640, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 69);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewContactSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(818, 1061);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewTitre);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewContactSingle";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ViewContactSingle";
            this.Load += new System.EventHandler(this.ViewContact_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal Label ViewTitre;
        internal Label label5;
        internal Label label6;
        internal Label label7;
        internal Label label8;
        internal Label label9;
        internal Label label11;
        internal Label label12;
        internal StatusStrip statusStrip1;
        internal ToolStripStatusLabel toolStripStatusLabel1;
        internal ToolStripStatusLabel toolStripStatusLabel2;
        internal PictureBox pictureBox1;
        public string txtNomContact;
        public string txtTitre;
        public string txtTelDomicile;
        public string txtPoste;
        public string txtEmail;
        public string txtPagette;
        public string txtFax;
        public string txtCellulaire;
        public string txtTelephone;
        public string txtCompagnie;
        public ViewContactSingle()
        {
            InitializeComponent();
        }
        public ViewContactSingle(string txtCompagnie, string txtNomContact)
        {
            InitializeComponent();
            txtCompagnie = txtCompagnie;
            txtNomContact = txtNomContact;
            EnumContact();
        }
        public ViewContactSingle(string txtNomContact, string txtTitre, string txtTelDomicile, string txtPoste, string txtEmail, string txtPagette, string txtFax,
            string txtCellulaire, string txtTelephone, string txtCompagnie)
        {
            InitializeComponent();
            txtTelDomicile = txtTelDomicile;
            txtPoste = txtPoste;
            txtEmail = txtEmail;
            txtPagette = txtPagette;
            txtFax = txtFax;
            txtCellulaire = txtCellulaire;
            txtTelephone = txtTelephone;
            txtCompagnie = txtCompagnie;
        }
        private void EnumContact()
        {
            ADODB.Recordset rd = new ADODB.Recordset();
            if (!string.IsNullOrEmpty(txtCompagnie))
            {
                rd.Open($"SELECT COMPAGNIE,NOMCONTACT,  TELEPHONNE, NOPOSTE,PAGETTE,CELLULAIRE, FAX, [E-MAIL] FROM [DBO].[CONTACT] " +
                    $"WHERE [COMPAGNIE] LIKE  '%{txtCompagnie}%' AND SUPPRIMÉ= 0   and NomContact like '%{txtNomContact}%'" +
                    $" ORDER BY Compagnie,NOMCONTACT", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else
            {
                MessageBox.Show("Le parametre d'information Compagnie est invalide",Application.ProductName+".EnumContactParEntreprise");
                return;
            }
            while (!rd.EOF)
            {
                txtCompagnie = $"{rd.Fields["Compagnie"].Value}";
                txtNomContact = $"{rd.Fields["NomContact"].Value}";
                txtTelephone = $"{rd.Fields["Telephonne"].Value}";
                txtPoste = $"{rd.Fields["noposte"].Value}";
                txtPagette = $"{rd.Fields["Pagette"].Value}";
                txtCellulaire = $"{rd.Fields["Cellulaire"].Value}";
                txtFax = $"{rd.Fields["Fax"].Value}";
                txtEmail = $"{rd.Fields["E-mail"].Value}";
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
        }
        private void ViewContact_Load(object sender, EventArgs e)
        {
            ViewTitre.Text = "Contact individuel de " + txtCompagnie;
            toolStripStatusLabel1.Text = $"{Program.IdNomEmploye} {DateTime.Now.ToString()}";
            label5.Text = "Nom du contact " + Contact.cmbContact.Text;
            label6.Text = "Compagnie " + txtCompagnie;
            label7.Text = "Téléphone " + txtTelephone;
            if (txtPoste != string.Empty) { label7.Text += " poste " + txtPoste; }
            label8.Text = "Pagette " + txtPagette;
            label9.Text = "Cellulaire " + txtCellulaire;
            label11.Text = "Fax " + txtFax;
            label12.Text = "E-mail " + txtEmail;
        }
        Bitmap memoryImage;
        internal static bool Orientation;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
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
            if (MessageBox.Show("Voulez vous fermer cette vue?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}