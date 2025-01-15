using ADODB;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleurServeur;
namespace ControleurServeur
{
    public class ViewDemandePrix : Form
    {
        private IContainer components = null;
        internal static ADODB.Recordset Database= new Recordset();
        internal static ListView.ListViewItemCollection itm;
        private string st;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDemandePrix));
            lblTitreDemande = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblNoSoum = new System.Windows.Forms.Label();
            lblTitreDateReq = new System.Windows.Forms.Label();
            lblFournisseur = new System.Windows.Forms.Label();
            lblTitreContact = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            lblTitreTel = new System.Windows.Forms.Label();
            lblTel = new System.Windows.Forms.Label();
            lblTitreFax = new System.Windows.Forms.Label();
            lblFax = new System.Windows.Forms.Label();
            lblTitreFournisseur = new System.Windows.Forms.Label();
            lblPage = new System.Windows.Forms.Label();
            lblTitreComPar = new System.Windows.Forms.Label();
            lblCommandePar = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblTransport = new System.Windows.Forms.Label();
            lblTitreTransport = new System.Windows.Forms.Label();
            lblDateRequise = new System.Windows.Forms.Label();
            lblTitreNoGRB = new System.Windows.Forms.Label();
            lblTitreDate = new System.Windows.Forms.Label();
            lblTitreNoSoum = new System.Windows.Forms.Label();
            lblNoGRB = new System.Windows.Forms.Label();
            lblTitrePage = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            lblTitreQte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitrePiece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreManufact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreDelais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label2 = new System.Windows.Forms.Label();
            lblPrixValide = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            lblJours = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblPiedPage = new System.Windows.Forms.ToolStripStatusLabel();
            lblTitreCommentaire = new System.Windows.Forms.Label();
            lblCommentaire = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitreDemande
            // 
            lblTitreDemande.AutoSize = true;
            lblTitreDemande.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreDemande.Location = new System.Drawing.Point(45, 24);
            lblTitreDemande.Name = "lblTitreDemande";
            lblTitreDemande.Size = new System.Drawing.Size(365, 36);
            lblTitreDemande.TabIndex = 418;
            lblTitreDemande.Tag = "";
            lblTitreDemande.Text = "Demande de prix et livraison";
            lblTitreDemande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(970, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblNoSoum
            // 
            lblNoSoum.AutoSize = true;
            lblNoSoum.BackColor = System.Drawing.Color.White;
            lblNoSoum.Location = new System.Drawing.Point(378, 93);
            lblNoSoum.Name = "lblNoSoum";
            lblNoSoum.Size = new System.Drawing.Size(58, 13);
            lblNoSoum.TabIndex = 563;
            lblNoSoum.Text = "lblNoSoum";
            // 
            // lblTitreDateReq
            // 
            lblTitreDateReq.AutoSize = true;
            lblTitreDateReq.BackColor = System.Drawing.Color.White;
            lblTitreDateReq.Location = new System.Drawing.Point(18, 148);
            lblTitreDateReq.Name = "lblTitreDateReq";
            lblTitreDateReq.Size = new System.Drawing.Size(67, 13);
            lblTitreDateReq.TabIndex = 565;
            lblTitreDateReq.Text = "Date requise";
            // 
            // lblFournisseur
            // 
            lblFournisseur.BackColor = System.Drawing.Color.White;
            lblFournisseur.Location = new System.Drawing.Point(88, 93);
            lblFournisseur.Name = "lblFournisseur";
            lblFournisseur.Size = new System.Drawing.Size(167, 19);
            lblFournisseur.TabIndex = 522;
            lblFournisseur.Text = "lblFournisseur";
            // 
            // lblTitreContact
            // 
            lblTitreContact.AutoSize = true;
            lblTitreContact.BackColor = System.Drawing.Color.White;
            lblTitreContact.Location = new System.Drawing.Point(14, 111);
            lblTitreContact.MinimumSize = new System.Drawing.Size(60, 19);
            lblTitreContact.Name = "lblTitreContact";
            lblTitreContact.Size = new System.Drawing.Size(60, 19);
            lblTitreContact.TabIndex = 525;
            lblTitreContact.Text = "Contact";
            // 
            // lblContact
            // 
            lblContact.BackColor = System.Drawing.Color.White;
            lblContact.Location = new System.Drawing.Point(88, 111);
            lblContact.MinimumSize = new System.Drawing.Size(60, 19);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(126, 19);
            lblContact.TabIndex = 526;
            lblContact.Text = "lblContact";
            // 
            // lblTitreTel
            // 
            lblTitreTel.AutoSize = true;
            lblTitreTel.BackColor = System.Drawing.Color.White;
            lblTitreTel.Location = new System.Drawing.Point(230, 111);
            lblTitreTel.MinimumSize = new System.Drawing.Size(60, 19);
            lblTitreTel.Name = "lblTitreTel";
            lblTitreTel.Size = new System.Drawing.Size(60, 19);
            lblTitreTel.TabIndex = 527;
            lblTitreTel.Text = "Téléphone";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BackColor = System.Drawing.Color.White;
            lblTel.Location = new System.Drawing.Point(300, 111);
            lblTel.MinimumSize = new System.Drawing.Size(60, 19);
            lblTel.Name = "lblTel";
            lblTel.Size = new System.Drawing.Size(60, 19);
            lblTel.TabIndex = 528;
            lblTel.Text = "lblTel";
            // 
            // lblTitreFax
            // 
            lblTitreFax.AutoSize = true;
            lblTitreFax.BackColor = System.Drawing.Color.White;
            lblTitreFax.Location = new System.Drawing.Point(232, 129);
            lblTitreFax.Name = "lblTitreFax";
            lblTitreFax.Size = new System.Drawing.Size(27, 13);
            lblTitreFax.TabIndex = 529;
            lblTitreFax.Text = "Fax:";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.BackColor = System.Drawing.Color.White;
            lblFax.Location = new System.Drawing.Point(297, 129);
            lblFax.MinimumSize = new System.Drawing.Size(60, 19);
            lblFax.Name = "lblFax";
            lblFax.Size = new System.Drawing.Size(60, 19);
            lblFax.TabIndex = 530;
            lblFax.Text = "lblFax";
            // 
            // lblTitreFournisseur
            // 
            lblTitreFournisseur.AutoSize = true;
            lblTitreFournisseur.BackColor = System.Drawing.Color.White;
            lblTitreFournisseur.Location = new System.Drawing.Point(14, 93);
            lblTitreFournisseur.MinimumSize = new System.Drawing.Size(60, 19);
            lblTitreFournisseur.Name = "lblTitreFournisseur";
            lblTitreFournisseur.Size = new System.Drawing.Size(67, 19);
            lblTitreFournisseur.TabIndex = 533;
            lblTitreFournisseur.Text = "Fournisseur: ";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.BackColor = System.Drawing.Color.White;
            lblPage.Location = new System.Drawing.Point(544, 148);
            lblPage.Name = "lblPage";
            lblPage.Size = new System.Drawing.Size(42, 13);
            lblPage.TabIndex = 541;
            lblPage.Text = "lblPage";
            // 
            // lblTitreComPar
            // 
            lblTitreComPar.AutoSize = true;
            lblTitreComPar.BackColor = System.Drawing.Color.White;
            lblTitreComPar.Location = new System.Drawing.Point(489, 129);
            lblTitreComPar.Name = "lblTitreComPar";
            lblTitreComPar.Size = new System.Drawing.Size(50, 13);
            lblTitreComPar.TabIndex = 543;
            lblTitreComPar.Text = "Acheteur";
            // 
            // lblCommandePar
            // 
            lblCommandePar.AutoSize = true;
            lblCommandePar.BackColor = System.Drawing.Color.White;
            lblCommandePar.Location = new System.Drawing.Point(545, 129);
            lblCommandePar.Name = "lblCommandePar";
            lblCommandePar.Size = new System.Drawing.Size(86, 13);
            lblCommandePar.TabIndex = 549;
            lblCommandePar.Text = "lblCommandePar";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Location = new System.Drawing.Point(544, 111);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(40, 13);
            lblDate.TabIndex = 550;
            lblDate.Text = "lblDate";
            // 
            // lblTransport
            // 
            lblTransport.AutoSize = true;
            lblTransport.BackColor = System.Drawing.Color.White;
            lblTransport.Location = new System.Drawing.Point(297, 148);
            lblTransport.Name = "lblTransport";
            lblTransport.Size = new System.Drawing.Size(62, 13);
            lblTransport.TabIndex = 551;
            lblTransport.Text = "lblTransport";
            // 
            // lblTitreTransport
            // 
            lblTitreTransport.AutoSize = true;
            lblTitreTransport.BackColor = System.Drawing.Color.White;
            lblTitreTransport.Location = new System.Drawing.Point(230, 148);
            lblTitreTransport.Name = "lblTitreTransport";
            lblTitreTransport.Size = new System.Drawing.Size(52, 13);
            lblTitreTransport.TabIndex = 552;
            lblTitreTransport.Text = "Transport";
            // 
            // lblDateRequise
            // 
            lblDateRequise.AutoSize = true;
            lblDateRequise.BackColor = System.Drawing.Color.White;
            lblDateRequise.Location = new System.Drawing.Point(88, 148);
            lblDateRequise.Name = "lblDateRequise";
            lblDateRequise.Size = new System.Drawing.Size(79, 13);
            lblDateRequise.TabIndex = 553;
            lblDateRequise.Text = "lblDateRequise";
            // 
            // lblTitreNoGRB
            // 
            lblTitreNoGRB.AutoSize = true;
            lblTitreNoGRB.BackColor = System.Drawing.Color.White;
            lblTitreNoGRB.Location = new System.Drawing.Point(489, 93);
            lblTitreNoGRB.Name = "lblTitreNoGRB";
            lblTitreNoGRB.Size = new System.Drawing.Size(46, 13);
            lblTitreNoGRB.TabIndex = 554;
            lblTitreNoGRB.Text = "# GRB: ";
            // 
            // lblTitreDate
            // 
            lblTitreDate.AutoSize = true;
            lblTitreDate.BackColor = System.Drawing.Color.White;
            lblTitreDate.Location = new System.Drawing.Point(489, 111);
            lblTitreDate.Name = "lblTitreDate";
            lblTitreDate.Size = new System.Drawing.Size(30, 13);
            lblTitreDate.TabIndex = 559;
            lblTitreDate.Text = "Date";
            // 
            // lblTitreNoSoum
            // 
            lblTitreNoSoum.AutoSize = true;
            lblTitreNoSoum.BackColor = System.Drawing.Color.White;
            lblTitreNoSoum.Location = new System.Drawing.Point(300, 93);
            lblTitreNoSoum.Name = "lblTitreNoSoum";
            lblTitreNoSoum.Size = new System.Drawing.Size(78, 13);
            lblTitreNoSoum.TabIndex = 560;
            lblTitreNoSoum.Text = "Votre # Soum: ";
            // 
            // lblNoGRB
            // 
            lblNoGRB.AutoSize = true;
            lblNoGRB.BackColor = System.Drawing.Color.White;
            lblNoGRB.Location = new System.Drawing.Point(544, 93);
            lblNoGRB.Name = "lblNoGRB";
            lblNoGRB.Size = new System.Drawing.Size(54, 13);
            lblNoGRB.TabIndex = 569;
            lblNoGRB.Text = "lblNoGRB";
            // 
            // lblTitrePage
            // 
            lblTitrePage.AutoSize = true;
            lblTitrePage.BackColor = System.Drawing.Color.White;
            lblTitrePage.Location = new System.Drawing.Point(489, 148);
            lblTitrePage.Name = "lblTitrePage";
            lblTitrePage.Size = new System.Drawing.Size(32, 13);
            lblTitrePage.TabIndex = 585;
            lblTitrePage.Text = "Page";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lblTitreQte,
            lblTitrePiece,
            lblTitreDescription,
            lblTitreManufact,
            lblTitreDelais});
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(21, 176);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1117, 471);
            listView1.TabIndex = 586;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // lblTitreQte
            // 
            lblTitreQte.Text = "Quantité";
            // 
            // lblTitrePiece
            // 
            lblTitrePiece.Text = "# Pièce";
            lblTitrePiece.Width = 120;
            // 
            // lblTitreDescription
            // 
            lblTitreDescription.Text = "Description";
            lblTitreDescription.Width = 480;
            // 
            // lblTitreManufact
            // 
            lblTitreManufact.Text = "Manufacturier";
            lblTitreManufact.Width = 373;
            // 
            // lblTitreDelais
            // 
            lblTitreDelais.Text = "Délais";
            lblTitreDelais.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(258, 650);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(414, 36);
            label2.TabIndex = 587;
            label2.Text = "CECI N\'EST PAS UNE COMMANDE";
            // 
            // lblPrixValide
            // 
            lblPrixValide.AutoSize = true;
            lblPrixValide.Location = new System.Drawing.Point(909, 697);
            lblPrixValide.Name = "lblPrixValide";
            lblPrixValide.Size = new System.Drawing.Size(85, 13);
            lblPrixValide.TabIndex = 588;
            lblPrixValide.Text = "Prix valide pour: ";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(912, 713);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(35, 20);
            textBox1.TabIndex = 589;
            // 
            // lblJours
            // 
            lblJours.AutoSize = true;
            lblJours.Location = new System.Drawing.Point(953, 716);
            lblJours.Name = "lblJours";
            lblJours.Size = new System.Drawing.Size(32, 13);
            lblJours.TabIndex = 590;
            lblJours.Text = "Jours";
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblPiedPage});
            statusStrip1.Location = new System.Drawing.Point(0, 773);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1150, 22);
            statusStrip1.TabIndex = 591;
            // 
            // lblPiedPage
            // 
            lblPiedPage.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            lblPiedPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPiedPage.Name = "lblPiedPage";
            lblPiedPage.Size = new System.Drawing.Size(1135, 17);
            lblPiedPage.Spring = true;
            lblPiedPage.Text = "149, rue Pierre-Paradis, St-Alphonse-de-Granby, QC, J0E 2A0, Tel: (450) 372-0021," +
    " Fax: (450) 372-3860";
            // 
            // lblTitreCommentaire
            // 
            lblTitreCommentaire.AutoSize = true;
            lblTitreCommentaire.Location = new System.Drawing.Point(32, 685);
            lblTitreCommentaire.Name = "lblTitreCommentaire";
            lblTitreCommentaire.Size = new System.Drawing.Size(68, 13);
            lblTitreCommentaire.TabIndex = 592;
            lblTitreCommentaire.Text = "Commentaire";
            // 
            // lblCommentaire
            // 
            lblCommentaire.Location = new System.Drawing.Point(32, 701);
            lblCommentaire.Multiline = true;
            lblCommentaire.Name = "lblCommentaire";
            lblCommentaire.Size = new System.Drawing.Size(842, 40);
            lblCommentaire.TabIndex = 593;
            // 
            // ViewDemandePrix
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1150, 795);
            Controls.Add(lblCommentaire);
            Controls.Add(lblTitreCommentaire);
            Controls.Add(statusStrip1);
            Controls.Add(lblJours);
            Controls.Add(textBox1);
            Controls.Add(lblPrixValide);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(lblTitrePage);
            Controls.Add(lblNoGRB);
            Controls.Add(lblNoSoum);
            Controls.Add(lblTitreDateReq);
            Controls.Add(lblFournisseur);
            Controls.Add(lblTitreContact);
            Controls.Add(lblContact);
            Controls.Add(lblTitreTel);
            Controls.Add(lblTel);
            Controls.Add(lblTitreFax);
            Controls.Add(lblFax);
            Controls.Add(lblTitreFournisseur);
            Controls.Add(lblPage);
            Controls.Add(lblTitreComPar);
            Controls.Add(lblCommandePar);
            Controls.Add(lblDate);
            Controls.Add(lblTransport);
            Controls.Add(lblTitreTransport);
            Controls.Add(lblDateRequise);
            Controls.Add(lblTitreNoGRB);
            Controls.Add(lblTitreDate);
            Controls.Add(lblTitreNoSoum);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitreDemande);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewDemandePrix";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal static PictureBox pictureBox1;
        internal static Label lblTitreDemande;
        internal static Label lblNoSoum;
        internal static Label lblTitreDateReq;
        internal static Label lblFournisseur;
        internal static Label lblTitreContact;
        internal static Label lblContact;
        internal static Label lblTitreTel;
        internal static Label lblTel;
        internal static Label lblTitreFax;
        internal static Label lblFax;
        internal static Label lblTitreFournisseur;
        internal static Label lblPage;
        internal static Label lblTitreComPar;
        internal static Label lblCommandePar;
        internal static Label lblDate;
        internal static Label lblTransport;
        internal static Label lblTitreTransport;
        internal static Label lblDateRequise;
        internal static Label lblTitreNoGRB;
        internal static Label lblTitreDate;
        internal static Label lblTitreNoSoum;
        internal static Label lblNoGRB;
        internal static ListView listView1;
        internal static ColumnHeader lblTitreQte;
        internal static ColumnHeader lblTitrePiece;
        internal static ColumnHeader lblTitreDescription;
        internal static ColumnHeader lblTitreManufact;
        internal static ColumnHeader lblTitreDelais;
        internal static Label label2;
        internal static Label lblPrixValide;
        internal static TextBox textBox1;
        internal static Label lblJours;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel lblPiedPage;
        internal static Label lblTitreCommentaire;
        internal static TextBox lblCommentaire;
        internal static Label lblTitrePage;
        internal static ListView.SelectedListViewItemCollection it;
        #endregion
        public ViewDemandePrix()
        {
            InitializeComponent();
            Text = Name;
            int nbPages = 1;
            if (!Database.EOF)
            {
                lblFournisseur.Text = Database.Fields[6].Value;
                if ((Database.Fields[7].Value is DBNull) & (Database.Fields[8].Value is DBNull)) { lblContact.Visible = false; lblTitreContact.Visible = false; }
                if ((Database.Fields[7].Value is DBNull) & (!(Database.Fields[8].Value is DBNull))) { lblContact.Text = Database.Fields[8].Value; }
                if ((!(Database.Fields[7].Value is DBNull) & (Database.Fields[8].Value is DBNull))) { lblContact.Text = Database.Fields[7].Value; }
                lblTitreDateReq.Text = Database.Fields[5].Value;
                if (ACHAT.cmbNoAchat.Text != "") { lblTitreNoSoum.Text = " ACHAT"; lblNoSoum.Text = ACHAT.cmbNoAchat.Text; }
                lblDate.Text = DateTime.Now.ToString();
                lblCommandePar.Text = Program.IdNomEmploye;
                lblDateRequise.Text = Database.Fields[5].Value;
                if (it.Count > 26) { nbPages += it.Count % 26; }
                lblPage.Text = $"{nbPages}";
                lblPrixValide.Text = "Délais maximal pour reception";
                if (lblTitreDateReq.Text != "") { textBox1.Text = "14"; } else { textBox1.Text = "28"; }
            }
            if (it.Count > 0)
            {
                listView1.ForeColor = Color.DarkBlue;
                foreach (ListViewItem item in it)
                {
                    if (item.SubItems[7].Text == BonCommande.cmbFournisseur.Text)
                    {
                        listView1.Items.Add(item);
                    }
                }
            }
        }
        public ViewDemandePrix(string st)
        {
            InitializeComponent();
            st = st;
            ADODB.Recordset rd = new ADODB.Recordset();
            ADODB.Recordset soum = new ADODB.Recordset();
            Text = $"Demande de prix pour {st}";
            lblCommandePar.Text = Program.IdNomEmploye;
            lblDate.Text = DateTime.Today.ToLongDateString();
            lblNoGRB.Text = ACHAT.cmbNoAchat.Text;
            textBox1.Text = "15";//existe til une soumission liée?
            soum.Open($"SELECT [IDSOUMISSION] FROM [DBO].[SOUMISSION_PIECES] WHERE IDSOUMISSION='{Program.Gauche(ACHAT.cmbNoAchat.Text, 9)}'", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!soum.EOF) { lblNoSoum.Text = $"{soum.Fields[0].Value}"; } else { lblTitreNoSoum.Visible = lblTitreNoSoum.Visible = false; lblNoSoum.Visible = false; }
            soum.Close();
            soum = null;
            string sql = $" SELECT DISTINCT [DBO].[FOURNISSEUR] .NOMFOURNISSEUR,[DBO].[FOURNISSEUR].TELEPHONNE,[DBO].[FOURNISSEUR].FAX,[DBO].[FOURNISSEUR].REP,PIECE, NUMÉROLIGNE, " +
                $"QTÉ, DESC_FR, DESC_EN, MANUFACT, DATEREQUISE,[CONDTRANSPORT],[PAYS] FROM [DBO].[ACHAT_PIECES] " +
                $"JOIN [DBO].[FOURNISSEUR] ON [DBO].[ACHAT_PIECES].IDFRS=[DBO].[FOURNISSEUR].IDFRS " +
                $"WHERE  [IDACHAT]= '{Program.Gauche(ACHAT.cmbNoAchat.Text, 9)}' AND INDEXACHAT = '{int.Parse(Program.Droite(ACHAT.cmbNoAchat.Text, 3))}' " +
                $"AND [DBO].[FOURNISSEUR].NOMFOURNISSEUR='{st}' " +
                $"ORDER BY NOMFOURNISSEUR DESC";
            rd.Open(sql, Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                lblFournisseur.Text = st;
                if ($"{rd.Fields[3].Value}" != string.Empty) { lblContact.Text = $"{rd.Fields[3].Value}"; } else { lblContact.Visible = false; lblTitreContact.Visible = false; }
                if ($"{rd.Fields[1].Value}" != string.Empty) { lblTel.Text = $"{rd.Fields[1].Value}"; } else { lblTel.Visible = false; lblTitreTel.Visible = false; }
                if ($"{rd.Fields[2].Value}" != string.Empty) { lblFax.Text = $"{rd.Fields[2].Value}"; } else { lblFax.Visible = false; lblTitreFax.Visible = false; }
                lblDateRequise.Text = DateTime.Today.AddDays(3).ToShortDateString(); 
            lblPage.Text = "1";
         }else return;
            for (int a = 0; a<itm.Count; a++) 
            { 
                if (itm[a].Checked)
                {
                    ListViewItem itm0 = listView1.Items.Add(string.Empty);
                    itm0.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, itm[a].SubItems[0].Text));
                    itm0.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, itm[a].SubItems[1].Text));
                    itm0.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, itm[a].SubItems[2].Text));
                    itm0.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, itm[a].SubItems[4].Text));
                    itm0.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, lblDateRequise.Text));
                }
            }
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name +" Fournisseur: " +st;
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
