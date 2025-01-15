using ADODB;
using Stripe.Climate;
using Stripe;
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
    public  class ViewContactEntreprise : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewContactEntreprise));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Compagnie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Téléphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pagette = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cellulaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewTitre = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Compagnie,
            this.NomContact,
            this.Téléphone,
            this.Poste,
            this.Pagette,
            this.Cellulaire,
            this.Fax,
            this.EMail});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 74);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(1128, 696);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Compagnie
            // 
            this.Compagnie.Text = "Compagnie";
            this.Compagnie.Width = 301;
            // 
            // NomContact
            // 
            this.NomContact.Text = "Nom du contact";
            this.NomContact.Width = 164;
            // 
            // Téléphone
            // 
            this.Téléphone.Text = "Téléphone";
            this.Téléphone.Width = 110;
            // 
            // Poste
            // 
            this.Poste.Text = "Poste";
            // 
            // Pagette
            // 
            this.Pagette.Text = "Pagette";
            this.Pagette.Width = 110;
            // 
            // Cellulaire
            // 
            this.Cellulaire.Text = "Cellulaire";
            this.Cellulaire.Width = 110;
            // 
            // Fax
            // 
            this.Fax.Text = "Fax";
            this.Fax.Width = 110;
            // 
            // EMail
            // 
            this.EMail.Text = "E-Mail";
            this.EMail.Width = 246;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(964, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 69);
            this.pictureBox1.TabIndex = 417;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewTitre
            // 
            this.ViewTitre.AutoSize = true;
            this.ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTitre.Location = new System.Drawing.Point(12, 9);
            this.ViewTitre.Name = "ViewTitre";
            this.ViewTitre.Size = new System.Drawing.Size(120, 36);
            this.ViewTitre.TabIndex = 408;
            this.ViewTitre.Tag = "";
            this.ViewTitre.Text = "Contacts";
            this.ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 773);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 416;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1065, 17);
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
            // ViewContactEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 795);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewTitre);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewContactEntreprise";
            this.Text = "ViewContactEntreprise";
            this.Load += new System.EventHandler(this.ViewContactEntreprise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal ListView listView1;
        internal PictureBox pictureBox1;
        internal Label ViewTitre;
        internal StatusStrip statusStrip1;
        internal ToolStripStatusLabel toolStripStatusLabel1;
        internal ToolStripStatusLabel toolStripStatusLabel2;
        internal ColumnHeader Compagnie;
        internal ColumnHeader NomContact;
        internal ColumnHeader Téléphone;
        internal ColumnHeader Pagette;
        internal ColumnHeader Cellulaire;
        internal ColumnHeader Fax;
        internal ColumnHeader EMail;
        internal ColumnHeader Poste;
        internal static string txtEntreprise;
        ADODB.Recordset rd = new Recordset();
        internal static ADODB.Recordset DataSource;

        private void RemplirDatas()
        {
            if (DataSource.EOF)
            {
                MessageBox.Show("Aucune donnée dans le tampon", System.Windows.Forms.Application.ProductName); return;
            }
            else
            {
                while (!DataSource.EOF)
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[1].Value}"));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[4].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[3].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[5].Value}"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[45].Value}"));
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[36].Value}"));
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[37].Value}"));
                    DataSource.MoveNext();
                }
            }
        }
        private void EnumContactParEntreprise()
        {
            if (!string.IsNullOrEmpty(txtEntreprise))
            {
                rd.Open($"SELECT UPPER(COMPAGNIE), NOMCONTACT, TELEPHONNE, NOPOSTE, PAGETTE, CELLULAIRE, FAX, [E-MAIL] FROM [DBO].[CONTACT] " +
                    $"WHERE[COMPAGNIE] LIKE  '%{txtEntreprise}%' ORDER BY NOMCONTACT, COMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else
            {
                Program.AfficherErreur("ViewContactEntreprise", "EnumContactParEntreprise", new Exception("Le parametre d'information Compagnie est invalide"));
            }
            listView1.Items.Clear();
            while (!rd.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            return;
        }
        public ViewContactEntreprise() => InitializeComponent();
        public ViewContactEntreprise(string textEntreprise)
        {
            InitializeComponent();
            txtEntreprise = textEntreprise;
        }
        private void ViewContactEntreprise_Load(object sender, EventArgs e)
        {
            ViewTitre.Text = "Liste pour " + txtEntreprise;
            toolStripStatusLabel1 .Text= " Cliquez sur le logo pour lancer l'impression";
            EnumContactParEntreprise();
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
