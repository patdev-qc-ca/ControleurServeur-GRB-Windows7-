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
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public class ViewBackOrder : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBackOrder));
            ViewTitre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTitre = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            lblProjetAchat = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            lblTitreNoProjet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtNoItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreFournisseur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ViewTitre
            // 
            ViewTitre.AutoSize = true;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(11, 9);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(223, 36);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Rupture de stock";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.Location = new System.Drawing.Point(844, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(174, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.BackColor = System.Drawing.Color.White;
            lblTitre.Location = new System.Drawing.Point(14, 42);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new System.Drawing.Size(149, 13);
            lblTitre.TabIndex = 520;
            lblTitre.Text = "Pièces électriques non reçues";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(14, 71);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(30, 13);
            Label5.TabIndex = 525;
            Label5.Text = "Date";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Location = new System.Drawing.Point(61, 71);
            lblDate.MinimumSize = new System.Drawing.Size(60, 19);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(60, 19);
            lblDate.TabIndex = 526;
            lblDate.Text = "lblDate";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(14, 89);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(41, 13);
            Label6.TabIndex = 527;
            Label6.Text = "Projet#";
            // 
            // lblProjetAchat
            // 
            lblProjetAchat.AutoSize = true;
            lblProjetAchat.BackColor = System.Drawing.Color.White;
            lblProjetAchat.Location = new System.Drawing.Point(61, 89);
            lblProjetAchat.MinimumSize = new System.Drawing.Size(60, 19);
            lblProjetAchat.Name = "lblProjetAchat";
            lblProjetAchat.Size = new System.Drawing.Size(72, 19);
            lblProjetAchat.TabIndex = 528;
            lblProjetAchat.Text = "lblProjetAchat";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lblTitreNoProjet,
            lblTitreQuantite,
            txtNoItem,
            lblTitreDescription,
            lblTitreFournisseur,
            columnHeader1,
            columnHeader2});
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(16, 119);
            listView1.Margin = new System.Windows.Forms.Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(996, 613);
            listView1.TabIndex = 529;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // lblTitreNoProjet
            // 
            lblTitreNoProjet.Text = "Projet#";
            lblTitreNoProjet.Width = 98;
            // 
            // lblTitreQuantite
            // 
            lblTitreQuantite.Text = "Quantité";
            lblTitreQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lblTitreQuantite.Width = 62;
            // 
            // txtNoItem
            // 
            txtNoItem.Text = "Item#";
            txtNoItem.Width = 90;
            // 
            // lblTitreDescription
            // 
            lblTitreDescription.Text = "Description";
            lblTitreDescription.Width = 252;
            // 
            // lblTitreFournisseur
            // 
            lblTitreFournisseur.Text = "Fournisseur";
            lblTitreFournisseur.Width = 275;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date Commande";
            columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date Requise";
            columnHeader2.Width = 97;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1});
            statusStrip1.Location = new System.Drawing.Point(0, 747);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            statusStrip1.Size = new System.Drawing.Size(1023, 22);
            statusStrip1.TabIndex = 530;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(1012, 17);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewBackOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1023, 769);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(lblTitre);
            Controls.Add(Label5);
            Controls.Add(lblDate);
            Controls.Add(Label6);
            Controls.Add(lblProjetAchat);
            Controls.Add(pictureBox1);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewBackOrder";
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
        internal static System.Windows.Forms.Label Label1;
        internal static Label lblTitre;
        internal static Label Label5;
        internal static Label lblDate;
        internal static Label Label6;
        internal static Label lblProjetAchat;
        internal static ListView listView1;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel toolStripStatusLabel1;
        internal static ColumnHeader lblTitreNoProjet;
        internal static ColumnHeader lblTitreQuantite;
        internal static ColumnHeader txtNoItem;
        internal static ColumnHeader lblTitreDescription;
        internal static ColumnHeader lblTitreFournisseur;
        internal static ColumnHeader columnHeader1;
        internal static ColumnHeader columnHeader2;

        public ViewBackOrder()
        {
            InitializeComponent();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            Text = ControleurServeur.ViewBackOrder.lblTitreProjetAchat.Text;
            Top = 0;
            Left = -2;
            Height = 1150;
            Width = 808;
        }
        public ViewBackOrder(string noProjet, bool landscape)
        {
            InitializeComponent();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            Top = 0;
            Left = -2;
            if (landscape == true)
            {
                Height = 808;
                Width = 1150;
            }
            else
            {
                Height = 1150;
                Width = 808;
            }
            EnumDatas(noProjet);
        }
               public static Label lblTitreProjetAchat;
        internal static ADODB.Recordset DataSource=new Recordset();
        private void EnumDatas(string noProjet)
        {
            int idProjet = int.Parse(Droite(noProjet, 5));
            MessageBox.Show(idProjet.ToString());
            try
            {
                ADODB.Recordset rd = new ADODB.Recordset();
                rd.Open($"SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                    $"INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                    $"WHERE  Commandé = 1 and Right(Left(IDProjet,6),5)='{noProjet}' and Type ='E' " +
                    $"ORDER BY NomFournisseur ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ControleurServeur.ViewBackOrder.Orientation = !isLandscape;
                Text = $"Projet {noProjet}: Pièces commandées non reçues";
                toolStripStatusLabel1.Text = webServer + "/?test&" + Text.Split(':')[0];
                lblProjetAchat.Text = noProjet;
                DateTime dt = DateTime.Now;
                lblDate.Text = GetNomJourDateFr(dt.DayOfWeek) + ", " + dt.ToLongDateString() + " " + dt.ToLongTimeString();
                listView1.Items.Clear();
                while (!(rd.EOF))
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[29].Value}"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[23].Value}"));
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[24].Value}"));
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                    rd.MoveNext();
                }
                rd.Close();
                rd = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmdImprimerPieces_Click", ex); }
        }
        private void RemplirDatas()
        {
            if (DataSource.EOF) {
                MessageBox.Show("Aucune donnée dans le tampon", Application.ProductName); return;
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
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            RemplirDatas();
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
