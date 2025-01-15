using System;
using System.Drawing;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using System.Diagnostics;
using System.Web.UI.WebControls;
using ListView = System.Windows.Forms.ListView;
using Button = System.Windows.Forms.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using RadioButton = System.Windows.Forms.RadioButton;
using TextBox = System.Windows.Forms.TextBox;
using Label = System.Windows.Forms.Label;
using ListViewItem = System.Windows.Forms.ListViewItem;
using System.Collections.Generic;

namespace ControleurServeur
{
    internal class CatalogueMec : Form
    {
        object sortie;
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public CatalogueMec() : base()
        {
           InitializeComponent();
        }

        public CatalogueMec(string text1, string text2, string text3)
        {
           InitializeComponent();
            AfficherForm(text1, text2, text3);   
        }

        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!(components is null))
                {
                   components.Dispose();
                }
            }
            base.Dispose(Disposing);
        }
        private System.ComponentModel.IContainer components;
        internal static ToolTip ToolTip1;
        internal static ColumnHeader _lvwCategorie_ColumnHeader_1;
        internal static ListView lvwCategorie;
        internal static Button cmdRechercheCategorie;
        internal static ColumnHeader _lvwRechercheAchat_ColumnHeader_1;
        internal static ColumnHeader _lvwRechercheAchat_ColumnHeader_2;
        internal static ListView lvwRechercheAchat;
        internal static ColumnHeader _lvwRechercheJob_ColumnHeader_1;
        internal static ColumnHeader _lvwRechercheJob_ColumnHeader_2;
        internal static ListView lvwRechercheJob;
        internal static Button cmdRechercheJob;
        internal static Button cmdCopier;
        internal static Button cmdTotal;
        internal static Button cmdRechercheInventaire;
        internal static ColumnHeader _lvwFabricant_ColumnHeader_1;
        internal static ColumnHeader _lvwFabricant_ColumnHeader_2;
        internal static ColumnHeader _lvwFabricant_ColumnHeader_3;
        internal static ColumnHeader _lvwFabricant_ColumnHeader_4;
        internal static ListView lvwFabricant;
        internal static ColumnHeader _lvwPieces_ColumnHeader_1;
        internal static ColumnHeader _lvwPieces_ColumnHeader_2;
        internal static ColumnHeader _lvwPieces_ColumnHeader_3;
        internal static ColumnHeader _lvwPieces_ColumnHeader_4;
        internal static ListView lvwPieces;
        internal static Button cmdChangerCategorie;
        internal static Button cmdDemande;
        internal static ColumnHeader _lvwDescription_ColumnHeader_1;
        internal static ColumnHeader _lvwDescription_ColumnHeader_2;
        internal static ColumnHeader _lvwDescription_ColumnHeader_3;
        internal static ColumnHeader _lvwDescription_ColumnHeader_4;
        internal static ListView lvwDescription;
        internal static Button cmdRechercheDescrFR;
        internal static TextBox txtTauxChange;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_1;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_2;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_3;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_4;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_5;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_6;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_7;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_8;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_9;
        internal static ColumnHeader _lvwfournisseur_ColumnHeader_10;
        internal static ListView lvwfournisseur;
        internal static Button cmdAddFrs;
        internal static Button cmdSuppFrs;
        internal static Button cmdModifFrs;
        internal static CheckBox chkquoter;
        internal static RadioButton optUSA;
        internal static RadioButton optCAN;
        internal static TextBox txtPrixList;
        internal static TextBox txtPrixNet;
        internal static TextBox txtPrixSpecial;
        internal static MaskedTextBox mskValide;
        internal static MaskedTextBox mskEscompte;
        internal static Button cmdEnrFrs;
        internal static Button cmdAnnulFrs;
        internal static ComboBox cmbfrs;
        internal static ComboBox cmbPersRess;
        internal static RadioButton optSpain;
        internal static Label lblDevise1;
        internal static Label lblDevise2;
        internal static Label _Label1_5;
        internal static PictureBox imgCanada;
        internal static PictureBox imgEU;
        internal static Label _Label1_14;
        internal static Label _Label1_16;
        internal static Label _Label1_19;
        internal static Label _Label1_24;
        internal static Label _Label1_20;
        internal static Label _Label1_2;
        internal static Label _Label1_23;
        internal static PictureBox imgSpain;
        internal static GroupBox frafournisseur;
        internal static ComboBox cmbCategorie;
        internal static TextBox txtNoItemGRB;
        internal static ComboBox cmbNoItem;
        internal static Button CmdModif;
        internal static Button CmdFerme;
        internal static Button CmdSupp;
        internal static Button CmdAdd;
        internal static TextBox txtComment;
        internal static ComboBox cmbFabricant;
        internal static TextBox txtFabricant;
        internal static TextBox txtDescriptionEN;
        internal static TextBox txtDescriptionFR;
        internal static TextBox txtNoItem;
        internal static Button CmdAnul;
        internal static Button CmdEnr;
        internal static TextBox txtCategorie;
        internal static Button cmdRechercherPiece;
        internal static ComboBox cmbDescriptionFR;
        internal static Button cmdRechercherManufact;
        internal static CheckBox chkInventaire;
        internal static TextBox txtQuantiteCommande;
        internal static CheckBox chkMinimum;
        internal static TextBox txtQuantiteStock;
        internal static TextBox txtQuantiteMinimum;
        internal static TextBox txtQuantitéBoite;
        internal static CheckBox chkBoite;
        internal static Label Label11;
        internal static Label Label5;
        internal static GroupBox fraQuantité;
        internal static ComboBox cmbLocalisation;
        internal static TextBox txtLocalisation;
        internal static Button cmdRechercheAchat;
        internal static Label Label4;
        internal static Label Label2;
        internal static Label _Label1_25;
        internal static Label _Label1_6;
        internal static Label _Label1_4;
        internal static Label _Label1_3;
        internal static Label _Label1_1;
        private System.Windows.Forms.Panel panel1;
        internal static Label _Label1_0;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            lvwCategorie = new System.Windows.Forms.ListView();
            _lvwCategorie_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdRechercheCategorie = new System.Windows.Forms.Button();
            lvwRechercheAchat = new System.Windows.Forms.ListView();
            _lvwRechercheAchat_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwRechercheAchat_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwRechercheJob = new System.Windows.Forms.ListView();
            _lvwRechercheJob_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwRechercheJob_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdRechercheJob = new System.Windows.Forms.Button();
            cmdCopier = new System.Windows.Forms.Button();
            cmdTotal = new System.Windows.Forms.Button();
            cmdRechercheInventaire = new System.Windows.Forms.Button();
            lvwFabricant = new System.Windows.Forms.ListView();
            _lvwFabricant_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwFabricant_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwFabricant_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwFabricant_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwPieces = new System.Windows.Forms.ListView();
            _lvwPieces_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPieces_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPieces_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPieces_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdChangerCategorie = new System.Windows.Forms.Button();
            cmdDemande = new System.Windows.Forms.Button();
            lvwDescription = new System.Windows.Forms.ListView();
            _lvwDescription_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwDescription_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwDescription_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwDescription_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdRechercheDescrFR = new System.Windows.Forms.Button();
            frafournisseur = new System.Windows.Forms.GroupBox();
            txtTauxChange = new System.Windows.Forms.TextBox();
            lvwfournisseur = new System.Windows.Forms.ListView();
            _lvwfournisseur_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwfournisseur_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwfournisseur_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwfournisseur_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwfournisseur_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwfournisseur_ColumnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwfournisseur_ColumnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwfournisseur_ColumnHeader_8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwfournisseur_ColumnHeader_9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwfournisseur_ColumnHeader_10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdAddFrs = new System.Windows.Forms.Button();
            cmdSuppFrs = new System.Windows.Forms.Button();
            cmdModifFrs = new System.Windows.Forms.Button();
            chkquoter = new System.Windows.Forms.CheckBox();
            optUSA = new System.Windows.Forms.RadioButton();
            optCAN = new System.Windows.Forms.RadioButton();
            txtPrixList = new System.Windows.Forms.TextBox();
            txtPrixNet = new System.Windows.Forms.TextBox();
            txtPrixSpecial = new System.Windows.Forms.TextBox();
            mskValide = new System.Windows.Forms.MaskedTextBox();
            mskEscompte = new System.Windows.Forms.MaskedTextBox();
            cmdEnrFrs = new System.Windows.Forms.Button();
            cmdAnnulFrs = new System.Windows.Forms.Button();
            cmbfrs = new System.Windows.Forms.ComboBox();
            cmbPersRess = new System.Windows.Forms.ComboBox();
            optSpain = new System.Windows.Forms.RadioButton();
            lblDevise1 = new System.Windows.Forms.Label();
            lblDevise2 = new System.Windows.Forms.Label();
            _Label1_5 = new System.Windows.Forms.Label();
            imgCanada = new System.Windows.Forms.PictureBox();
            imgEU = new System.Windows.Forms.PictureBox();
            _Label1_14 = new System.Windows.Forms.Label();
            _Label1_16 = new System.Windows.Forms.Label();
            _Label1_19 = new System.Windows.Forms.Label();
            _Label1_24 = new System.Windows.Forms.Label();
            _Label1_20 = new System.Windows.Forms.Label();
            _Label1_2 = new System.Windows.Forms.Label();
            _Label1_23 = new System.Windows.Forms.Label();
            imgSpain = new System.Windows.Forms.PictureBox();
            cmbCategorie = new System.Windows.Forms.ComboBox();
            txtNoItemGRB = new System.Windows.Forms.TextBox();
            cmbNoItem = new System.Windows.Forms.ComboBox();
            CmdModif = new System.Windows.Forms.Button();
            CmdFerme = new System.Windows.Forms.Button();
            CmdSupp = new System.Windows.Forms.Button();
            CmdAdd = new System.Windows.Forms.Button();
            txtComment = new System.Windows.Forms.TextBox();
            cmbFabricant = new System.Windows.Forms.ComboBox();
            txtFabricant = new System.Windows.Forms.TextBox();
            txtDescriptionEN = new System.Windows.Forms.TextBox();
            txtDescriptionFR = new System.Windows.Forms.TextBox();
            txtNoItem = new System.Windows.Forms.TextBox();
            CmdAnul = new System.Windows.Forms.Button();
            CmdEnr = new System.Windows.Forms.Button();
            txtCategorie = new System.Windows.Forms.TextBox();
            cmdRechercherPiece = new System.Windows.Forms.Button();
            cmbDescriptionFR = new System.Windows.Forms.ComboBox();
            cmdRechercherManufact = new System.Windows.Forms.Button();
            chkInventaire = new System.Windows.Forms.CheckBox();
            fraQuantité = new System.Windows.Forms.GroupBox();
            txtQuantiteCommande = new System.Windows.Forms.TextBox();
            chkMinimum = new System.Windows.Forms.CheckBox();
            txtQuantiteStock = new System.Windows.Forms.TextBox();
            txtQuantiteMinimum = new System.Windows.Forms.TextBox();
            txtQuantitéBoite = new System.Windows.Forms.TextBox();
            chkBoite = new System.Windows.Forms.CheckBox();
            Label11 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            cmbLocalisation = new System.Windows.Forms.ComboBox();
            txtLocalisation = new System.Windows.Forms.TextBox();
            cmdRechercheAchat = new System.Windows.Forms.Button();
            Label4 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            _Label1_25 = new System.Windows.Forms.Label();
            _Label1_6 = new System.Windows.Forms.Label();
            _Label1_4 = new System.Windows.Forms.Label();
            _Label1_3 = new System.Windows.Forms.Label();
            _Label1_1 = new System.Windows.Forms.Label();
            _Label1_0 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            frafournisseur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(imgCanada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgEU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgSpain)).BeginInit();
            fraQuantité.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lvwCategorie
            // 
            lvwCategorie.BackColor = System.Drawing.SystemColors.Window;
            lvwCategorie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwCategorie_ColumnHeader_1});
            lvwCategorie.ForeColor = System.Drawing.SystemColors.WindowText;
            lvwCategorie.FullRowSelect = true;
            lvwCategorie.GridLines = true;
            lvwCategorie.HideSelection = false;
            lvwCategorie.Location = new System.Drawing.Point(175, 498);
            lvwCategorie.Name = "lvwCategorie";
            lvwCategorie.Size = new System.Drawing.Size(281, 129);
            lvwCategorie.TabIndex = 82;
            lvwCategorie.UseCompatibleStateImageBehavior = false;
            lvwCategorie.View = System.Windows.Forms.View.Details;
            lvwCategorie.DoubleClick += new System.EventHandler(lvwCategorie_DoubleClick);
            lvwCategorie.Leave += new System.EventHandler(lvwCategorie_Leave);
            // 
            // _lvwCategorie_ColumnHeader_1
            // 
            _lvwCategorie_ColumnHeader_1.Text = "Catégorie";
            _lvwCategorie_ColumnHeader_1.Width = 447;
            // 
            // cmdRechercheCategorie
            // 
            cmdRechercheCategorie.BackColor = System.Drawing.Color.Black;
            cmdRechercheCategorie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercheCategorie.ForeColor = System.Drawing.Color.White;
            cmdRechercheCategorie.Location = new System.Drawing.Point(688, 8);
            cmdRechercheCategorie.Name = "cmdRechercheCategorie";
            cmdRechercheCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercheCategorie.Size = new System.Drawing.Size(25, 25);
            cmdRechercheCategorie.TabIndex = 81;
            cmdRechercheCategorie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cmdRechercheCategorie.UseVisualStyleBackColor = true;
            cmdRechercheCategorie.Click += new System.EventHandler(cmdRechercheCategorie_Click);
            // 
            // lvwRechercheAchat
            // 
            lvwRechercheAchat.BackColor = System.Drawing.SystemColors.Window;
            lvwRechercheAchat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwRechercheAchat_ColumnHeader_1,
            _lvwRechercheAchat_ColumnHeader_2});
            lvwRechercheAchat.Dock = System.Windows.Forms.DockStyle.Top;
            lvwRechercheAchat.ForeColor = System.Drawing.SystemColors.WindowText;
            lvwRechercheAchat.FullRowSelect = true;
            lvwRechercheAchat.GridLines = true;
            lvwRechercheAchat.HideSelection = false;
            lvwRechercheAchat.Location = new System.Drawing.Point(0, 234);
            lvwRechercheAchat.Name = "lvwRechercheAchat";
            lvwRechercheAchat.Size = new System.Drawing.Size(555, 129);
            lvwRechercheAchat.TabIndex = 79;
            lvwRechercheAchat.UseCompatibleStateImageBehavior = false;
            lvwRechercheAchat.View = System.Windows.Forms.View.Details;
            lvwRechercheAchat.Visible = false;
            lvwRechercheAchat.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(lvwRechercheAchat_ColumnClick);
            lvwRechercheAchat.Leave += new System.EventHandler(lvwRechercheAchat_Leave);
            // 
            // _lvwRechercheAchat_ColumnHeader_1
            // 
            _lvwRechercheAchat_ColumnHeader_1.Text = "No. Job";
            _lvwRechercheAchat_ColumnHeader_1.Width = 170;
            // 
            // _lvwRechercheAchat_ColumnHeader_2
            // 
            _lvwRechercheAchat_ColumnHeader_2.Text = "Nbre fois";
            _lvwRechercheAchat_ColumnHeader_2.Width = 170;
            // 
            // lvwRechercheJob
            // 
            lvwRechercheJob.BackColor = System.Drawing.SystemColors.Window;
            lvwRechercheJob.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwRechercheJob_ColumnHeader_1,
            _lvwRechercheJob_ColumnHeader_2});
            lvwRechercheJob.Dock = System.Windows.Forms.DockStyle.Top;
            lvwRechercheJob.ForeColor = System.Drawing.SystemColors.WindowText;
            lvwRechercheJob.FullRowSelect = true;
            lvwRechercheJob.GridLines = true;
            lvwRechercheJob.HideSelection = false;
            lvwRechercheJob.Location = new System.Drawing.Point(0, 363);
            lvwRechercheJob.Name = "lvwRechercheJob";
            lvwRechercheJob.Size = new System.Drawing.Size(555, 129);
            lvwRechercheJob.TabIndex = 15;
            lvwRechercheJob.UseCompatibleStateImageBehavior = false;
            lvwRechercheJob.View = System.Windows.Forms.View.Details;
            lvwRechercheJob.Visible = false;
            lvwRechercheJob.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(lvwRechercheJob_ColumnClick);
            lvwRechercheJob.Leave += new System.EventHandler(lvwRechercheJob_Leave);
            // 
            // _lvwRechercheJob_ColumnHeader_1
            // 
            _lvwRechercheJob_ColumnHeader_1.Text = "No. Job";
            _lvwRechercheJob_ColumnHeader_1.Width = 170;
            // 
            // _lvwRechercheJob_ColumnHeader_2
            // 
            _lvwRechercheJob_ColumnHeader_2.Text = "Nbre fois";
            _lvwRechercheJob_ColumnHeader_2.Width = 170;
            // 
            // cmdRechercheJob
            // 
            cmdRechercheJob.AutoSize = true;
            cmdRechercheJob.BackColor = System.Drawing.Color.Black;
            cmdRechercheJob.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercheJob.Font = new System.Drawing.Font("Calibri", 8.25F);
            cmdRechercheJob.ForeColor = System.Drawing.Color.White;
            cmdRechercheJob.Location = new System.Drawing.Point(67, 201);
            cmdRechercheJob.Name = "cmdRechercheJob";
            cmdRechercheJob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercheJob.Size = new System.Drawing.Size(159, 24);
            cmdRechercheJob.TabIndex = 38;
            cmdRechercheJob.Text = "Recherche dans jobs / soums";
            cmdRechercheJob.UseVisualStyleBackColor = true;
            cmdRechercheJob.Click += new System.EventHandler(cmdRechercheJob_Click);
            // 
            // cmdCopier
            // 
            cmdCopier.BackColor = System.Drawing.Color.Black;
            cmdCopier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdCopier.ForeColor = System.Drawing.Color.White;
            cmdCopier.Location = new System.Drawing.Point(240, 400);
            cmdCopier.Name = "cmdCopier";
            cmdCopier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCopier.Size = new System.Drawing.Size(89, 33);
            cmdCopier.TabIndex = 69;
            cmdCopier.Text = "&Copier";
            cmdCopier.UseVisualStyleBackColor = true;
            cmdCopier.Click += new System.EventHandler(cmdCopier_Click);
            // 
            // cmdTotal
            // 
            cmdTotal.AutoSize = true;
            cmdTotal.BackColor = System.Drawing.Color.Black;
            cmdTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdTotal.Font = new System.Drawing.Font("Calibri", 8.25F);
            cmdTotal.ForeColor = System.Drawing.Color.White;
            cmdTotal.Location = new System.Drawing.Point(8, 201);
            cmdTotal.Name = "cmdTotal";
            cmdTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdTotal.Size = new System.Drawing.Size(57, 24);
            cmdTotal.TabIndex = 37;
            cmdTotal.Text = "Total";
            cmdTotal.UseVisualStyleBackColor = true;
            cmdTotal.Click += new System.EventHandler(cmdTotal_Click);
            // 
            // cmdRechercheInventaire
            // 
            cmdRechercheInventaire.BackColor = System.Drawing.Color.Black;
            cmdRechercheInventaire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercheInventaire.ForeColor = System.Drawing.Color.White;
            cmdRechercheInventaire.Location = new System.Drawing.Point(32, 400);
            cmdRechercheInventaire.Name = "cmdRechercheInventaire";
            cmdRechercheInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercheInventaire.Size = new System.Drawing.Size(97, 33);
            cmdRechercheInventaire.TabIndex = 67;
            cmdRechercheInventaire.Text = "Inventaire";
            cmdRechercheInventaire.UseVisualStyleBackColor = true;
            cmdRechercheInventaire.Click += new System.EventHandler(cmdRechercheInventaire_Click);
            // 
            // lvwFabricant
            // 
            lvwFabricant.BackColor = System.Drawing.SystemColors.Window;
            lvwFabricant.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwFabricant_ColumnHeader_1,
            _lvwFabricant_ColumnHeader_2,
            _lvwFabricant_ColumnHeader_3,
            _lvwFabricant_ColumnHeader_4});
            lvwFabricant.ForeColor = System.Drawing.SystemColors.WindowText;
            lvwFabricant.FullRowSelect = true;
            lvwFabricant.GridLines = true;
            lvwFabricant.HideSelection = false;
            lvwFabricant.Location = new System.Drawing.Point(32, 439);
            lvwFabricant.Name = "lvwFabricant";
            lvwFabricant.Size = new System.Drawing.Size(553, 129);
            lvwFabricant.TabIndex = 4;
            lvwFabricant.UseCompatibleStateImageBehavior = false;
            lvwFabricant.View = System.Windows.Forms.View.Details;
            lvwFabricant.Visible = false;
            lvwFabricant.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(lvwFabricant_ColumnClick);
            lvwFabricant.DoubleClick += new System.EventHandler(lvwFabricant_DoubleClick);
            lvwFabricant.KeyDown += new System.Windows.Forms.KeyEventHandler(lvwFabricant_KeyDown);
            lvwFabricant.Leave += new System.EventHandler(lvwFabricant_Leave);
            // 
            // _lvwFabricant_ColumnHeader_1
            // 
            _lvwFabricant_ColumnHeader_1.Text = "Manufacturier";
            _lvwFabricant_ColumnHeader_1.Width = 140;
            // 
            // _lvwFabricant_ColumnHeader_2
            // 
            _lvwFabricant_ColumnHeader_2.Text = "No. Pièce";
            _lvwFabricant_ColumnHeader_2.Width = 217;
            // 
            // _lvwFabricant_ColumnHeader_3
            // 
            _lvwFabricant_ColumnHeader_3.Text = "Description française";
            _lvwFabricant_ColumnHeader_3.Width = 410;
            // 
            // _lvwFabricant_ColumnHeader_4
            // 
            _lvwFabricant_ColumnHeader_4.Text = "Description anglaise";
            _lvwFabricant_ColumnHeader_4.Width = 410;
            // 
            // lvwPieces
            // 
            lvwPieces.BackColor = System.Drawing.SystemColors.Window;
            lvwPieces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwPieces_ColumnHeader_1,
            _lvwPieces_ColumnHeader_2,
            _lvwPieces_ColumnHeader_3,
            _lvwPieces_ColumnHeader_4});
            lvwPieces.ForeColor = System.Drawing.SystemColors.WindowText;
            lvwPieces.FullRowSelect = true;
            lvwPieces.GridLines = true;
            lvwPieces.HideSelection = false;
            lvwPieces.Location = new System.Drawing.Point(32, 574);
            lvwPieces.Name = "lvwPieces";
            lvwPieces.Size = new System.Drawing.Size(553, 129);
            lvwPieces.TabIndex = 5;
            lvwPieces.UseCompatibleStateImageBehavior = false;
            lvwPieces.View = System.Windows.Forms.View.Details;
            lvwPieces.Visible = false;
            lvwPieces.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(lvwPieces_ColumnClick);
            lvwPieces.DoubleClick += new System.EventHandler(lvwPieces_DoubleClick);
            lvwPieces.KeyDown += new System.Windows.Forms.KeyEventHandler(lvwPieces_KeyDown);
            lvwPieces.Leave += new System.EventHandler(lvwPieces_Leave);
            // 
            // _lvwPieces_ColumnHeader_1
            // 
            _lvwPieces_ColumnHeader_1.Text = "No Pièce";
            _lvwPieces_ColumnHeader_1.Width = 217;
            // 
            // _lvwPieces_ColumnHeader_2
            // 
            _lvwPieces_ColumnHeader_2.Text = "Manufacturier";
            _lvwPieces_ColumnHeader_2.Width = 140;
            // 
            // _lvwPieces_ColumnHeader_3
            // 
            _lvwPieces_ColumnHeader_3.Text = "Description française";
            _lvwPieces_ColumnHeader_3.Width = 410;
            // 
            // _lvwPieces_ColumnHeader_4
            // 
            _lvwPieces_ColumnHeader_4.Text = "Description anglaise";
            _lvwPieces_ColumnHeader_4.Width = 410;
            // 
            // cmdChangerCategorie
            // 
            cmdChangerCategorie.BackColor = System.Drawing.Color.Black;
            cmdChangerCategorie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdChangerCategorie.ForeColor = System.Drawing.Color.White;
            cmdChangerCategorie.Location = new System.Drawing.Point(536, 32);
            cmdChangerCategorie.Name = "cmdChangerCategorie";
            cmdChangerCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdChangerCategorie.Size = new System.Drawing.Size(121, 25);
            cmdChangerCategorie.TabIndex = 3;
            cmdChangerCategorie.Text = "Changer de catégorie";
            cmdChangerCategorie.UseVisualStyleBackColor = true;
            cmdChangerCategorie.Click += new System.EventHandler(cmdChangerCategorie_Click);
            // 
            // cmdDemande
            // 
            cmdDemande.BackColor = System.Drawing.Color.Black;
            cmdDemande.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdDemande.ForeColor = System.Drawing.Color.White;
            cmdDemande.Location = new System.Drawing.Point(136, 400);
            cmdDemande.Name = "cmdDemande";
            cmdDemande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDemande.Size = new System.Drawing.Size(97, 33);
            cmdDemande.TabIndex = 68;
            cmdDemande.Text = "Demande de prix";
            cmdDemande.UseVisualStyleBackColor = true;
            cmdDemande.Click += new System.EventHandler(cmdDemande_Click);
            // 
            // lvwDescription
            // 
            lvwDescription.BackColor = System.Drawing.SystemColors.Window;
            lvwDescription.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwDescription_ColumnHeader_1,
            _lvwDescription_ColumnHeader_2,
            _lvwDescription_ColumnHeader_3,
            _lvwDescription_ColumnHeader_4});
            lvwDescription.Dock = System.Windows.Forms.DockStyle.Top;
            lvwDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            lvwDescription.FullRowSelect = true;
            lvwDescription.GridLines = true;
            lvwDescription.HideSelection = false;
            lvwDescription.Location = new System.Drawing.Point(0, 0);
            lvwDescription.Name = "lvwDescription";
            lvwDescription.Size = new System.Drawing.Size(555, 129);
            lvwDescription.TabIndex = 6;
            lvwDescription.UseCompatibleStateImageBehavior = false;
            lvwDescription.View = System.Windows.Forms.View.Details;
            lvwDescription.Visible = false;
            lvwDescription.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(lvwDescription_ColumnClick);
            lvwDescription.DoubleClick += new System.EventHandler(lvwDescription_DoubleClick);
            lvwDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(lvwDescription_KeyDown);
            lvwDescription.Leave += new System.EventHandler(lvwDescription_Leave);
            // 
            // _lvwDescription_ColumnHeader_1
            // 
            _lvwDescription_ColumnHeader_1.Text = "Description française";
            _lvwDescription_ColumnHeader_1.Width = 410;
            // 
            // _lvwDescription_ColumnHeader_2
            // 
            _lvwDescription_ColumnHeader_2.Text = "Description anglais";
            _lvwDescription_ColumnHeader_2.Width = 410;
            // 
            // _lvwDescription_ColumnHeader_3
            // 
            _lvwDescription_ColumnHeader_3.Text = "Manufacturier";
            _lvwDescription_ColumnHeader_3.Width = 140;
            // 
            // _lvwDescription_ColumnHeader_4
            // 
            _lvwDescription_ColumnHeader_4.Text = "NoItem";
            _lvwDescription_ColumnHeader_4.Width = 217;
            // 
            // cmdRechercheDescrFR
            // 
            cmdRechercheDescrFR.BackColor = System.Drawing.Color.Black;
            cmdRechercheDescrFR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercheDescrFR.ForeColor = System.Drawing.Color.White;
            cmdRechercheDescrFR.Location = new System.Drawing.Point(688, 60);
            cmdRechercheDescrFR.Name = "cmdRechercheDescrFR";
            cmdRechercheDescrFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercheDescrFR.Size = new System.Drawing.Size(25, 25);
            cmdRechercheDescrFR.TabIndex = 9;
            cmdRechercheDescrFR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cmdRechercheDescrFR.UseVisualStyleBackColor = true;
            cmdRechercheDescrFR.Click += new System.EventHandler(cmdRechercheDescrFR_Click);
            // 
            // frafournisseur
            // 
            frafournisseur.BackColor = System.Drawing.Color.Black;
            frafournisseur.Controls.Add(txtTauxChange);
            frafournisseur.Controls.Add(cmdAddFrs);
            frafournisseur.Controls.Add(cmdSuppFrs);
            frafournisseur.Controls.Add(cmdModifFrs);
            frafournisseur.Controls.Add(chkquoter);
            frafournisseur.Controls.Add(optUSA);
            frafournisseur.Controls.Add(optCAN);
            frafournisseur.Controls.Add(txtPrixList);
            frafournisseur.Controls.Add(txtPrixNet);
            frafournisseur.Controls.Add(txtPrixSpecial);
            frafournisseur.Controls.Add(mskValide);
            frafournisseur.Controls.Add(mskEscompte);
            frafournisseur.Controls.Add(cmdEnrFrs);
            frafournisseur.Controls.Add(cmdAnnulFrs);
            frafournisseur.Controls.Add(cmbfrs);
            frafournisseur.Controls.Add(cmbPersRess);
            frafournisseur.Controls.Add(optSpain);
            frafournisseur.Controls.Add(lblDevise1);
            frafournisseur.Controls.Add(lblDevise2);
            frafournisseur.Controls.Add(_Label1_5);
            frafournisseur.Controls.Add(imgCanada);
            frafournisseur.Controls.Add(imgEU);
            frafournisseur.Controls.Add(_Label1_14);
            frafournisseur.Controls.Add(_Label1_16);
            frafournisseur.Controls.Add(_Label1_19);
            frafournisseur.Controls.Add(_Label1_24);
            frafournisseur.Controls.Add(_Label1_20);
            frafournisseur.Controls.Add(_Label1_2);
            frafournisseur.Controls.Add(_Label1_23);
            frafournisseur.Controls.Add(imgSpain);
            frafournisseur.ForeColor = System.Drawing.Color.White;
            frafournisseur.Location = new System.Drawing.Point(32, 232);
            frafournisseur.Name = "frafournisseur";
            frafournisseur.Padding = new System.Windows.Forms.Padding(0);
            frafournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            frafournisseur.Size = new System.Drawing.Size(681, 161);
            frafournisseur.TabIndex = 41;
            frafournisseur.TabStop = false;
            frafournisseur.Text = "Fournisseur";
            // 
            // txtTauxChange
            // 
            txtTauxChange.AcceptsReturn = true;
            txtTauxChange.BackColor = System.Drawing.Color.Black;
            txtTauxChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTauxChange.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTauxChange.Location = new System.Drawing.Point(576, 128);
            txtTauxChange.MaxLength = 0;
            txtTauxChange.Name = "txtTauxChange";
            txtTauxChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTauxChange.Size = new System.Drawing.Size(57, 22);
            txtTauxChange.TabIndex = 76;
            txtTauxChange.Visible = false;
            // 
            // lvwfournisseur
            // 
            lvwfournisseur.BackColor = System.Drawing.SystemColors.Window;
            lvwfournisseur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwfournisseur_ColumnHeader_1,
            _lvwfournisseur_ColumnHeader_2,
            _lvwfournisseur_ColumnHeader_3,
            _lvwfournisseur_ColumnHeader_4,
            _lvwfournisseur_ColumnHeader_5,
            _lvwfournisseur_ColumnHeader_6,
            _lvwfournisseur_ColumnHeader_7,
            _lvwfournisseur_ColumnHeader_8,
            _lvwfournisseur_ColumnHeader_9,
            _lvwfournisseur_ColumnHeader_10});
            lvwfournisseur.Dock = System.Windows.Forms.DockStyle.Top;
            lvwfournisseur.ForeColor = System.Drawing.SystemColors.WindowText;
            lvwfournisseur.FullRowSelect = true;
            lvwfournisseur.GridLines = true;
            lvwfournisseur.HideSelection = false;
            lvwfournisseur.Location = new System.Drawing.Point(0, 129);
            lvwfournisseur.Name = "lvwfournisseur";
            lvwfournisseur.Size = new System.Drawing.Size(555, 105);
            lvwfournisseur.TabIndex = 42;
            lvwfournisseur.UseCompatibleStateImageBehavior = false;
            lvwfournisseur.View = System.Windows.Forms.View.Details;
            lvwfournisseur.DoubleClick += new System.EventHandler(lvwFournisseur_DoubleClick);
            lvwfournisseur.KeyDown += new System.Windows.Forms.KeyEventHandler(lvwfournisseur_KeyDown);
            // 
            // _lvwfournisseur_ColumnHeader_1
            // 
            _lvwfournisseur_ColumnHeader_1.Text = "Fournisseur";
            _lvwfournisseur_ColumnHeader_1.Width = 236;
            // 
            // _lvwfournisseur_ColumnHeader_2
            // 
            _lvwfournisseur_ColumnHeader_2.Text = "Pers. Ress.";
            _lvwfournisseur_ColumnHeader_2.Width = 133;
            // 
            // _lvwfournisseur_ColumnHeader_3
            // 
            _lvwfournisseur_ColumnHeader_3.Text = "Date";
            _lvwfournisseur_ColumnHeader_3.Width = 117;
            // 
            // _lvwfournisseur_ColumnHeader_4
            // 
            _lvwfournisseur_ColumnHeader_4.Text = "Par";
            _lvwfournisseur_ColumnHeader_4.Width = 54;
            // 
            // _lvwfournisseur_ColumnHeader_5
            // 
            _lvwfournisseur_ColumnHeader_5.Text = "Valide";
            _lvwfournisseur_ColumnHeader_5.Width = 117;
            // 
            // _lvwfournisseur_ColumnHeader_6
            // 
            _lvwfournisseur_ColumnHeader_6.Text = "Prix listé";
            _lvwfournisseur_ColumnHeader_6.Width = 108;
            // 
            // _lvwfournisseur_ColumnHeader_7
            // 
            _lvwfournisseur_ColumnHeader_7.Text = "Escompte";
            _lvwfournisseur_ColumnHeader_7.Width = 105;
            // 
            // _lvwfournisseur_ColumnHeader_8
            // 
            _lvwfournisseur_ColumnHeader_8.Text = "Prix net";
            _lvwfournisseur_ColumnHeader_8.Width = 108;
            // 
            // _lvwfournisseur_ColumnHeader_9
            // 
            _lvwfournisseur_ColumnHeader_9.Text = "Prix spécial";
            _lvwfournisseur_ColumnHeader_9.Width = 115;
            // 
            // _lvwfournisseur_ColumnHeader_10
            // 
            _lvwfournisseur_ColumnHeader_10.Text = "Quoter";
            _lvwfournisseur_ColumnHeader_10.Width = 80;
            // 
            // cmdAddFrs
            // 
            cmdAddFrs.BackColor = System.Drawing.Color.Black;
            cmdAddFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAddFrs.ForeColor = System.Drawing.Color.White;
            cmdAddFrs.Location = new System.Drawing.Point(8, 128);
            cmdAddFrs.Name = "cmdAddFrs";
            cmdAddFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAddFrs.Size = new System.Drawing.Size(73, 25);
            cmdAddFrs.TabIndex = 62;
            cmdAddFrs.Text = "&Ajouter";
            cmdAddFrs.UseVisualStyleBackColor = true;
            cmdAddFrs.Click += new System.EventHandler(cmdAddFrs_Click);
            // 
            // cmdSuppFrs
            // 
            cmdSuppFrs.BackColor = System.Drawing.Color.Black;
            cmdSuppFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdSuppFrs.ForeColor = System.Drawing.Color.White;
            cmdSuppFrs.Location = new System.Drawing.Point(88, 128);
            cmdSuppFrs.Name = "cmdSuppFrs";
            cmdSuppFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSuppFrs.Size = new System.Drawing.Size(73, 25);
            cmdSuppFrs.TabIndex = 65;
            cmdSuppFrs.Text = "&Supprimer";
            cmdSuppFrs.UseVisualStyleBackColor = true;
            cmdSuppFrs.Click += new System.EventHandler(cmdSuppFrs_Click);
            // 
            // cmdModifFrs
            // 
            cmdModifFrs.BackColor = System.Drawing.Color.Black;
            cmdModifFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdModifFrs.ForeColor = System.Drawing.Color.White;
            cmdModifFrs.Location = new System.Drawing.Point(168, 128);
            cmdModifFrs.Name = "cmdModifFrs";
            cmdModifFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdModifFrs.Size = new System.Drawing.Size(73, 25);
            cmdModifFrs.TabIndex = 66;
            cmdModifFrs.Text = "&Modifier";
            cmdModifFrs.UseVisualStyleBackColor = true;
            cmdModifFrs.Click += new System.EventHandler(cmdModifFrs_Click);
            // 
            // chkquoter
            // 
            chkquoter.BackColor = System.Drawing.Color.Black;
            chkquoter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkquoter.ForeColor = System.Drawing.Color.White;
            chkquoter.Location = new System.Drawing.Point(8, 96);
            chkquoter.Name = "chkquoter";
            chkquoter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkquoter.Size = new System.Drawing.Size(89, 17);
            chkquoter.TabIndex = 61;
            chkquoter.Text = "Quoter :";
            chkquoter.UseVisualStyleBackColor = true;
            // 
            // optUSA
            // 
            optUSA.BackColor = System.Drawing.Color.Black;
            optUSA.ForeColor = System.Drawing.Color.White;
            optUSA.Location = new System.Drawing.Point(576, 24);
            optUSA.Name = "optUSA";
            optUSA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optUSA.Size = new System.Drawing.Size(49, 17);
            optUSA.TabIndex = 56;
            optUSA.TabStop = true;
            optUSA.Text = "USA";
            optUSA.UseVisualStyleBackColor = true;
            optUSA.CheckedChanged += new System.EventHandler(optUSA_CheckedChanged);
            // 
            // optCAN
            // 
            optCAN.BackColor = System.Drawing.Color.Black;
            optCAN.Checked = true;
            optCAN.ForeColor = System.Drawing.Color.White;
            optCAN.Location = new System.Drawing.Point(528, 24);
            optCAN.Name = "optCAN";
            optCAN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optCAN.Size = new System.Drawing.Size(49, 17);
            optCAN.TabIndex = 55;
            optCAN.TabStop = true;
            optCAN.Text = "CAN";
            optCAN.UseVisualStyleBackColor = true;
            optCAN.CheckedChanged += new System.EventHandler(optCAN_CheckedChanged);
            // 
            // txtPrixList
            // 
            txtPrixList.AcceptsReturn = true;
            txtPrixList.BackColor = System.Drawing.Color.Black;
            txtPrixList.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixList.ForeColor = System.Drawing.SystemColors.WindowText;
            txtPrixList.Location = new System.Drawing.Point(424, 24);
            txtPrixList.MaxLength = 0;
            txtPrixList.Name = "txtPrixList";
            txtPrixList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixList.Size = new System.Drawing.Size(73, 22);
            txtPrixList.TabIndex = 48;
            txtPrixList.Leave += new System.EventHandler(txtPrixList_Leave);
            // 
            // txtPrixNet
            // 
            txtPrixNet.AcceptsReturn = true;
            txtPrixNet.BackColor = System.Drawing.Color.Black;
            txtPrixNet.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixNet.ForeColor = System.Drawing.SystemColors.WindowText;
            txtPrixNet.Location = new System.Drawing.Point(424, 72);
            txtPrixNet.MaxLength = 0;
            txtPrixNet.Name = "txtPrixNet";
            txtPrixNet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixNet.Size = new System.Drawing.Size(57, 22);
            txtPrixNet.TabIndex = 52;
            txtPrixNet.TextChanged += new System.EventHandler(txtPrixNet_TextChanged);
            txtPrixNet.Enter += new System.EventHandler(txtPrixNet_Enter);
            txtPrixNet.Leave += new System.EventHandler(txtPrixNet_Leave);
            // 
            // txtPrixSpecial
            // 
            txtPrixSpecial.AcceptsReturn = true;
            txtPrixSpecial.BackColor = System.Drawing.Color.Black;
            txtPrixSpecial.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixSpecial.ForeColor = System.Drawing.SystemColors.WindowText;
            txtPrixSpecial.Location = new System.Drawing.Point(424, 96);
            txtPrixSpecial.MaxLength = 0;
            txtPrixSpecial.Name = "txtPrixSpecial";
            txtPrixSpecial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixSpecial.Size = new System.Drawing.Size(57, 22);
            txtPrixSpecial.TabIndex = 54;
            txtPrixSpecial.TextChanged += new System.EventHandler(txtPrixSpecial_TextChanged);
            txtPrixSpecial.Leave += new System.EventHandler(txtPrixSpecial_Leave);
            // 
            // mskValide
            // 
            mskValide.Location = new System.Drawing.Point(104, 72);
            mskValide.Name = "mskValide";
            mskValide.Size = new System.Drawing.Size(81, 22);
            mskValide.TabIndex = 46;
            // 
            // mskEscompte
            // 
            mskEscompte.Location = new System.Drawing.Point(424, 48);
            mskEscompte.Name = "mskEscompte";
            mskEscompte.Size = new System.Drawing.Size(57, 22);
            mskEscompte.TabIndex = 50;
            // 
            // cmdEnrFrs
            // 
            cmdEnrFrs.BackColor = System.Drawing.Color.Black;
            cmdEnrFrs.ForeColor = System.Drawing.Color.White;
            cmdEnrFrs.Location = new System.Drawing.Point(8, 128);
            cmdEnrFrs.Name = "cmdEnrFrs";
            cmdEnrFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdEnrFrs.Size = new System.Drawing.Size(73, 25);
            cmdEnrFrs.TabIndex = 63;
            cmdEnrFrs.Text = "&Enregistre";
            cmdEnrFrs.UseVisualStyleBackColor = true;
            cmdEnrFrs.Click += new System.EventHandler(cmdEnrFrs_Click);
            // 
            // cmdAnnulFrs
            // 
            cmdAnnulFrs.BackColor = System.Drawing.Color.Black;
            cmdAnnulFrs.ForeColor = System.Drawing.Color.White;
            cmdAnnulFrs.Location = new System.Drawing.Point(88, 128);
            cmdAnnulFrs.Name = "cmdAnnulFrs";
            cmdAnnulFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnulFrs.Size = new System.Drawing.Size(73, 25);
            cmdAnnulFrs.TabIndex = 64;
            cmdAnnulFrs.Text = "A&nnuler";
            cmdAnnulFrs.UseVisualStyleBackColor = true;
            cmdAnnulFrs.Click += new System.EventHandler(cmdAnnulFrs_Click);
            // 
            // cmbfrs
            // 
            cmbfrs.BackColor = System.Drawing.SystemColors.Window;
            cmbfrs.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbfrs.Location = new System.Drawing.Point(104, 24);
            cmbfrs.Name = "cmbfrs";
            cmbfrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbfrs.Size = new System.Drawing.Size(185, 22);
            cmbfrs.TabIndex = 44;
            cmbfrs.SelectedIndexChanged += new System.EventHandler(cmbfrs_SelectedIndexChanged);
            // 
            // cmbPersRess
            // 
            cmbPersRess.BackColor = System.Drawing.SystemColors.Window;
            cmbPersRess.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbPersRess.Location = new System.Drawing.Point(104, 48);
            cmbPersRess.Name = "cmbPersRess";
            cmbPersRess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbPersRess.Size = new System.Drawing.Size(145, 22);
            cmbPersRess.TabIndex = 45;
            // 
            // optSpain
            // 
            optSpain.BackColor = System.Drawing.Color.Black;
            optSpain.ForeColor = System.Drawing.Color.White;
            optSpain.Location = new System.Drawing.Point(624, 24);
            optSpain.Name = "optSpain";
            optSpain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optSpain.Size = new System.Drawing.Size(49, 17);
            optSpain.TabIndex = 57;
            optSpain.TabStop = true;
            optSpain.Text = "SPA";
            optSpain.UseVisualStyleBackColor = true;
            optSpain.CheckedChanged += new System.EventHandler(optSpain_CheckedChanged);
            // 
            // lblDevise1
            // 
            lblDevise1.BackColor = System.Drawing.Color.Black;
            lblDevise1.ForeColor = System.Drawing.Color.White;
            lblDevise1.Location = new System.Drawing.Point(520, 128);
            lblDevise1.Name = "lblDevise1";
            lblDevise1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDevise1.Size = new System.Drawing.Size(57, 17);
            lblDevise1.TabIndex = 78;
            lblDevise1.Text = "1$ CAN =";
            lblDevise1.Visible = false;
            // 
            // lblDevise2
            // 
            lblDevise2.BackColor = System.Drawing.Color.Black;
            lblDevise2.ForeColor = System.Drawing.Color.White;
            lblDevise2.Location = new System.Drawing.Point(637, 128);
            lblDevise2.Name = "lblDevise2";
            lblDevise2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDevise2.Size = new System.Drawing.Size(38, 17);
            lblDevise2.TabIndex = 77;
            lblDevise2.Text = "$ USA";
            lblDevise2.Visible = false;
            // 
            // _Label1_5
            // 
            _Label1_5.BackColor = System.Drawing.Color.Black;
            _Label1_5.ForeColor = System.Drawing.Color.White;
            _Label1_5.Location = new System.Drawing.Point(192, 72);
            _Label1_5.Name = "_Label1_5";
            _Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_5.Size = new System.Drawing.Size(65, 17);
            _Label1_5.TabIndex = 60;
            _Label1_5.Text = "AA-MM-JJ";
            // 
            // imgCanada
            // 
            imgCanada.Location = new System.Drawing.Point(544, 48);
            imgCanada.Name = "imgCanada";
            imgCanada.Size = new System.Drawing.Size(112, 71);
            imgCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgCanada.TabIndex = 79;
            imgCanada.TabStop = false;
            imgCanada.Visible = false;
            // 
            // imgEU
            // 
            imgEU.Location = new System.Drawing.Point(544, 48);
            imgEU.Name = "imgEU";
            imgEU.Size = new System.Drawing.Size(112, 71);
            imgEU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgEU.TabIndex = 80;
            imgEU.TabStop = false;
            imgEU.Visible = false;
            // 
            // _Label1_14
            // 
            _Label1_14.BackColor = System.Drawing.Color.Black;
            _Label1_14.ForeColor = System.Drawing.Color.White;
            _Label1_14.Location = new System.Drawing.Point(8, 24);
            _Label1_14.Name = "_Label1_14";
            _Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_14.Size = new System.Drawing.Size(81, 17);
            _Label1_14.TabIndex = 43;
            _Label1_14.Text = "Distributeur :";
            // 
            // _Label1_16
            // 
            _Label1_16.BackColor = System.Drawing.Color.Black;
            _Label1_16.ForeColor = System.Drawing.Color.White;
            _Label1_16.Location = new System.Drawing.Point(344, 24);
            _Label1_16.Name = "_Label1_16";
            _Label1_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_16.Size = new System.Drawing.Size(65, 17);
            _Label1_16.TabIndex = 47;
            _Label1_16.Text = "Prix Listé :";
            // 
            // _Label1_19
            // 
            _Label1_19.BackColor = System.Drawing.Color.Black;
            _Label1_19.ForeColor = System.Drawing.Color.White;
            _Label1_19.Location = new System.Drawing.Point(344, 48);
            _Label1_19.Name = "_Label1_19";
            _Label1_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_19.Size = new System.Drawing.Size(73, 17);
            _Label1_19.TabIndex = 49;
            _Label1_19.Text = "Escompte :";
            // 
            // _Label1_24
            // 
            _Label1_24.BackColor = System.Drawing.Color.Black;
            _Label1_24.ForeColor = System.Drawing.Color.White;
            _Label1_24.Location = new System.Drawing.Point(8, 48);
            _Label1_24.Name = "_Label1_24";
            _Label1_24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_24.Size = new System.Drawing.Size(105, 17);
            _Label1_24.TabIndex = 58;
            _Label1_24.Text = "Pers. Ress :";
            // 
            // _Label1_20
            // 
            _Label1_20.BackColor = System.Drawing.Color.Black;
            _Label1_20.ForeColor = System.Drawing.Color.White;
            _Label1_20.Location = new System.Drawing.Point(344, 72);
            _Label1_20.Name = "_Label1_20";
            _Label1_20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_20.Size = new System.Drawing.Size(73, 17);
            _Label1_20.TabIndex = 51;
            _Label1_20.Text = "Prix Net :";
            // 
            // _Label1_2
            // 
            _Label1_2.BackColor = System.Drawing.Color.Black;
            _Label1_2.ForeColor = System.Drawing.Color.White;
            _Label1_2.Location = new System.Drawing.Point(344, 96);
            _Label1_2.Name = "_Label1_2";
            _Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_2.Size = new System.Drawing.Size(81, 17);
            _Label1_2.TabIndex = 53;
            _Label1_2.Text = "Prix Spécial :";
            // 
            // _Label1_23
            // 
            _Label1_23.BackColor = System.Drawing.Color.Black;
            _Label1_23.ForeColor = System.Drawing.Color.White;
            _Label1_23.Location = new System.Drawing.Point(8, 72);
            _Label1_23.Name = "_Label1_23";
            _Label1_23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_23.Size = new System.Drawing.Size(97, 17);
            _Label1_23.TabIndex = 59;
            _Label1_23.Text = "Valide jusqu\'au :";
            // 
            // imgSpain
            // 
            imgSpain.Location = new System.Drawing.Point(544, 48);
            imgSpain.Name = "imgSpain";
            imgSpain.Size = new System.Drawing.Size(112, 71);
            imgSpain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgSpain.TabIndex = 81;
            imgSpain.TabStop = false;
            imgSpain.Visible = false;
            // 
            // cmbCategorie
            // 
            cmbCategorie.BackColor = System.Drawing.Color.White;
            cmbCategorie.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbCategorie.Location = new System.Drawing.Point(376, 8);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbCategorie.Size = new System.Drawing.Size(281, 22);
            cmbCategorie.TabIndex = 0;
            cmbCategorie.Text = "cmbCategorie";
            cmbCategorie.SelectedIndexChanged += new System.EventHandler(cmbCategorie_SelectedIndexChanged);
            // 
            // txtNoItemGRB
            // 
            txtNoItemGRB.AcceptsReturn = true;
            txtNoItemGRB.BackColor = System.Drawing.Color.White;
            txtNoItemGRB.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoItemGRB.ForeColor = System.Drawing.SystemColors.WindowText;
            txtNoItemGRB.Location = new System.Drawing.Point(128, 152);
            txtNoItemGRB.MaxLength = 0;
            txtNoItemGRB.Name = "txtNoItemGRB";
            txtNoItemGRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoItemGRB.Size = new System.Drawing.Size(129, 22);
            txtNoItemGRB.TabIndex = 24;
            // 
            // cmbNoItem
            // 
            cmbNoItem.BackColor = System.Drawing.Color.White;
            cmbNoItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbNoItem.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbNoItem.Location = new System.Drawing.Point(128, 120);
            cmbNoItem.Name = "cmbNoItem";
            cmbNoItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbNoItem.Size = new System.Drawing.Size(129, 22);
            cmbNoItem.TabIndex = 17;
            cmbNoItem.Text = "cmbNoItem";
            cmbNoItem.Visible = false;
            cmbNoItem.SelectedIndexChanged += new System.EventHandler(cmbNoItem_SelectedIndexChanged);
            // 
            // CmdModif
            // 
            CmdModif.BackColor = System.Drawing.Color.Black;
            CmdModif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdModif.ForeColor = System.Drawing.Color.White;
            CmdModif.Location = new System.Drawing.Point(528, 400);
            CmdModif.Name = "CmdModif";
            CmdModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdModif.Size = new System.Drawing.Size(89, 33);
            CmdModif.TabIndex = 74;
            CmdModif.Text = "&Modifier";
            CmdModif.UseVisualStyleBackColor = true;
            CmdModif.Click += new System.EventHandler(CmdModif_Click);
            // 
            // CmdFerme
            // 
            CmdFerme.BackColor = System.Drawing.Color.Black;
            CmdFerme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdFerme.ForeColor = System.Drawing.Color.White;
            CmdFerme.Location = new System.Drawing.Point(624, 400);
            CmdFerme.Name = "CmdFerme";
            CmdFerme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdFerme.Size = new System.Drawing.Size(89, 33);
            CmdFerme.TabIndex = 75;
            CmdFerme.Text = "&Fermer";
            CmdFerme.UseVisualStyleBackColor = true;
            CmdFerme.Click += new System.EventHandler(CmdFerme_Click);
            // 
            // CmdSupp
            // 
            CmdSupp.BackColor = System.Drawing.Color.Black;
            CmdSupp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdSupp.ForeColor = System.Drawing.Color.White;
            CmdSupp.Location = new System.Drawing.Point(432, 400);
            CmdSupp.Name = "CmdSupp";
            CmdSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdSupp.Size = new System.Drawing.Size(89, 33);
            CmdSupp.TabIndex = 72;
            CmdSupp.Text = "&Supprimer";
            CmdSupp.UseVisualStyleBackColor = true;
            CmdSupp.Click += new System.EventHandler(CmdSupp_Click);
            // 
            // CmdAdd
            // 
            CmdAdd.BackColor = System.Drawing.Color.Black;
            CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdAdd.ForeColor = System.Drawing.Color.White;
            CmdAdd.Location = new System.Drawing.Point(336, 400);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAdd.Size = new System.Drawing.Size(89, 33);
            CmdAdd.TabIndex = 71;
            CmdAdd.Text = "&Ajouter";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += new System.EventHandler(CmdAdd_Click);
            // 
            // txtComment
            // 
            txtComment.AcceptsReturn = true;
            txtComment.BackColor = System.Drawing.Color.White;
            txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtComment.ForeColor = System.Drawing.SystemColors.WindowText;
            txtComment.Location = new System.Drawing.Point(376, 128);
            txtComment.MaxLength = 100;
            txtComment.Name = "txtComment";
            txtComment.ReadOnly = true;
            txtComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtComment.Size = new System.Drawing.Size(305, 22);
            txtComment.TabIndex = 25;
            // 
            // cmbFabricant
            // 
            cmbFabricant.BackColor = System.Drawing.Color.White;
            cmbFabricant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbFabricant.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbFabricant.Location = new System.Drawing.Point(128, 64);
            cmbFabricant.Name = "cmbFabricant";
            cmbFabricant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbFabricant.Size = new System.Drawing.Size(129, 22);
            cmbFabricant.TabIndex = 10;
            cmbFabricant.Text = "cmbFabricant";
            cmbFabricant.SelectedIndexChanged += new System.EventHandler(cmbFabricant_SelectedIndexChanged);
            // 
            // txtFabricant
            // 
            txtFabricant.AcceptsReturn = true;
            txtFabricant.BackColor = System.Drawing.Color.White;
            txtFabricant.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtFabricant.Enabled = false;
            txtFabricant.ForeColor = System.Drawing.SystemColors.WindowText;
            txtFabricant.Location = new System.Drawing.Point(128, 88);
            txtFabricant.MaxLength = 0;
            txtFabricant.Name = "txtFabricant";
            txtFabricant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtFabricant.Size = new System.Drawing.Size(129, 22);
            txtFabricant.TabIndex = 8;
            // 
            // txtDescriptionEN
            // 
            txtDescriptionEN.AcceptsReturn = true;
            txtDescriptionEN.BackColor = System.Drawing.Color.White;
            txtDescriptionEN.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDescriptionEN.ForeColor = System.Drawing.SystemColors.WindowText;
            txtDescriptionEN.Location = new System.Drawing.Point(376, 96);
            txtDescriptionEN.MaxLength = 100;
            txtDescriptionEN.Name = "txtDescriptionEN";
            txtDescriptionEN.ReadOnly = true;
            txtDescriptionEN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDescriptionEN.Size = new System.Drawing.Size(305, 22);
            txtDescriptionEN.TabIndex = 21;
            // 
            // txtDescriptionFR
            // 
            txtDescriptionFR.AcceptsReturn = true;
            txtDescriptionFR.BackColor = System.Drawing.Color.White;
            txtDescriptionFR.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDescriptionFR.ForeColor = System.Drawing.SystemColors.WindowText;
            txtDescriptionFR.Location = new System.Drawing.Point(376, 64);
            txtDescriptionFR.MaxLength = 100;
            txtDescriptionFR.Name = "txtDescriptionFR";
            txtDescriptionFR.ReadOnly = true;
            txtDescriptionFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDescriptionFR.Size = new System.Drawing.Size(305, 22);
            txtDescriptionFR.TabIndex = 14;
            // 
            // txtNoItem
            // 
            txtNoItem.AcceptsReturn = true;
            txtNoItem.BackColor = System.Drawing.SystemColors.Window;
            txtNoItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoItem.ForeColor = System.Drawing.SystemColors.WindowText;
            txtNoItem.Location = new System.Drawing.Point(128, 120);
            txtNoItem.MaxLength = 0;
            txtNoItem.Name = "txtNoItem";
            txtNoItem.ReadOnly = true;
            txtNoItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoItem.Size = new System.Drawing.Size(129, 22);
            txtNoItem.TabIndex = 18;
            txtNoItem.TextChanged += new System.EventHandler(txtNoItem_TextChanged);
            // 
            // CmdAnul
            // 
            CmdAnul.BackColor = System.Drawing.Color.Black;
            CmdAnul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdAnul.ForeColor = System.Drawing.Color.White;
            CmdAnul.Location = new System.Drawing.Point(432, 400);
            CmdAnul.Name = "CmdAnul";
            CmdAnul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAnul.Size = new System.Drawing.Size(89, 33);
            CmdAnul.TabIndex = 73;
            CmdAnul.Text = "A&nnuler";
            CmdAnul.UseVisualStyleBackColor = true;
            CmdAnul.Click += new System.EventHandler(CmdAnul_Click);
            // 
            // CmdEnr
            // 
            CmdEnr.BackColor = System.Drawing.Color.Black;
            CmdEnr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdEnr.ForeColor = System.Drawing.Color.White;
            CmdEnr.Location = new System.Drawing.Point(336, 400);
            CmdEnr.Name = "CmdEnr";
            CmdEnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdEnr.Size = new System.Drawing.Size(89, 33);
            CmdEnr.TabIndex = 70;
            CmdEnr.Text = "&Enregistre";
            CmdEnr.UseVisualStyleBackColor = true;
            CmdEnr.Click += new System.EventHandler(CmdEnr_Click);
            // 
            // txtCategorie
            // 
            txtCategorie.AcceptsReturn = true;
            txtCategorie.BackColor = System.Drawing.SystemColors.Window;
            txtCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCategorie.ForeColor = System.Drawing.SystemColors.WindowText;
            txtCategorie.Location = new System.Drawing.Point(376, 8);
            txtCategorie.MaxLength = 0;
            txtCategorie.Name = "txtCategorie";
            txtCategorie.ReadOnly = true;
            txtCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCategorie.Size = new System.Drawing.Size(281, 22);
            txtCategorie.TabIndex = 2;
            // 
            // cmdRechercherPiece
            // 
            cmdRechercherPiece.BackColor = System.Drawing.Color.Black;
            cmdRechercherPiece.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercherPiece.ForeColor = System.Drawing.Color.White;
            cmdRechercherPiece.Location = new System.Drawing.Point(264, 120);
            cmdRechercherPiece.Name = "cmdRechercherPiece";
            cmdRechercherPiece.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercherPiece.Size = new System.Drawing.Size(25, 25);
            cmdRechercherPiece.TabIndex = 19;
            cmdRechercherPiece.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cmdRechercherPiece.UseVisualStyleBackColor = true;
            cmdRechercherPiece.Click += new System.EventHandler(cmdRechercherPiece_Click);
            // 
            // cmbDescriptionFR
            // 
            cmbDescriptionFR.BackColor = System.Drawing.SystemColors.Window;
            cmbDescriptionFR.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbDescriptionFR.Location = new System.Drawing.Point(376, 64);
            cmbDescriptionFR.Name = "cmbDescriptionFR";
            cmbDescriptionFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbDescriptionFR.Size = new System.Drawing.Size(305, 22);
            cmbDescriptionFR.TabIndex = 13;
            cmbDescriptionFR.SelectedIndexChanged += new System.EventHandler(cmbDescriptionFR_SelectedIndexChanged);
            // 
            // cmdRechercherManufact
            // 
            cmdRechercherManufact.BackColor = System.Drawing.Color.Black;
            cmdRechercherManufact.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercherManufact.ForeColor = System.Drawing.Color.White;
            cmdRechercherManufact.Location = new System.Drawing.Point(264, 64);
            cmdRechercherManufact.Name = "cmdRechercherManufact";
            cmdRechercherManufact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercherManufact.Size = new System.Drawing.Size(25, 25);
            cmdRechercherManufact.TabIndex = 11;
            cmdRechercherManufact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cmdRechercherManufact.UseVisualStyleBackColor = true;
            cmdRechercherManufact.Click += new System.EventHandler(cmdRechercherManufact_Click);
            // 
            // chkInventaire
            // 
            chkInventaire.BackColor = System.Drawing.Color.Black;
            chkInventaire.ForeColor = System.Drawing.Color.White;
            chkInventaire.Location = new System.Drawing.Point(376, 152);
            chkInventaire.Name = "chkInventaire";
            chkInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkInventaire.Size = new System.Drawing.Size(89, 25);
            chkInventaire.TabIndex = 26;
            chkInventaire.Text = "Présent dans l\'inventaire";
            chkInventaire.UseVisualStyleBackColor = true;
            chkInventaire.CheckStateChanged += new System.EventHandler(chkInventaire_CheckStateChanged);
            // 
            // fraQuantité
            // 
            fraQuantité.BackColor = System.Drawing.Color.Black;
            fraQuantité.Controls.Add(txtQuantiteCommande);
            fraQuantité.Controls.Add(chkMinimum);
            fraQuantité.Controls.Add(txtQuantiteStock);
            fraQuantité.Controls.Add(txtQuantiteMinimum);
            fraQuantité.Controls.Add(txtQuantitéBoite);
            fraQuantité.Controls.Add(chkBoite);
            fraQuantité.Controls.Add(Label11);
            fraQuantité.Controls.Add(Label5);
            fraQuantité.ForeColor = System.Drawing.Color.White;
            fraQuantité.Location = new System.Drawing.Point(480, 152);
            fraQuantité.Name = "fraQuantité";
            fraQuantité.Padding = new System.Windows.Forms.Padding(0);
            fraQuantité.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraQuantité.Size = new System.Drawing.Size(233, 65);
            fraQuantité.TabIndex = 28;
            fraQuantité.TabStop = false;
            fraQuantité.Text = "Quantité";
            // 
            // txtQuantiteCommande
            // 
            txtQuantiteCommande.AcceptsReturn = true;
            txtQuantiteCommande.BackColor = System.Drawing.SystemColors.Window;
            txtQuantiteCommande.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuantiteCommande.Enabled = false;
            txtQuantiteCommande.ForeColor = System.Drawing.SystemColors.WindowText;
            txtQuantiteCommande.Location = new System.Drawing.Point(192, 40);
            txtQuantiteCommande.MaxLength = 0;
            txtQuantiteCommande.Name = "txtQuantiteCommande";
            txtQuantiteCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQuantiteCommande.Size = new System.Drawing.Size(33, 22);
            txtQuantiteCommande.TabIndex = 36;
            txtQuantiteCommande.Leave += new System.EventHandler(txtQuantiteCommande_Leave);
            // 
            // chkMinimum
            // 
            chkMinimum.BackColor = System.Drawing.Color.Black;
            chkMinimum.ForeColor = System.Drawing.Color.White;
            chkMinimum.Location = new System.Drawing.Point(120, 16);
            chkMinimum.Name = "chkMinimum";
            chkMinimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkMinimum.Size = new System.Drawing.Size(74, 17);
            chkMinimum.TabIndex = 31;
            chkMinimum.Text = "Minimum :";
            chkMinimum.UseVisualStyleBackColor = true;
            chkMinimum.CheckStateChanged += new System.EventHandler(chkMinimum_CheckStateChanged);
            // 
            // txtQuantiteStock
            // 
            txtQuantiteStock.AcceptsReturn = true;
            txtQuantiteStock.BackColor = System.Drawing.SystemColors.Window;
            txtQuantiteStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuantiteStock.ForeColor = System.Drawing.SystemColors.WindowText;
            txtQuantiteStock.Location = new System.Drawing.Point(80, 40);
            txtQuantiteStock.MaxLength = 0;
            txtQuantiteStock.Name = "txtQuantiteStock";
            txtQuantiteStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQuantiteStock.Size = new System.Drawing.Size(33, 22);
            txtQuantiteStock.TabIndex = 33;
            txtQuantiteStock.Leave += new System.EventHandler(txtQuantiteStock_Leave);
            // 
            // txtQuantiteMinimum
            // 
            txtQuantiteMinimum.AcceptsReturn = true;
            txtQuantiteMinimum.BackColor = System.Drawing.SystemColors.Window;
            txtQuantiteMinimum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuantiteMinimum.Enabled = false;
            txtQuantiteMinimum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtQuantiteMinimum.Location = new System.Drawing.Point(192, 16);
            txtQuantiteMinimum.MaxLength = 0;
            txtQuantiteMinimum.Name = "txtQuantiteMinimum";
            txtQuantiteMinimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQuantiteMinimum.Size = new System.Drawing.Size(33, 22);
            txtQuantiteMinimum.TabIndex = 32;
            txtQuantiteMinimum.Leave += new System.EventHandler(txtQuantiteMinimum_Leave);
            // 
            // txtQuantitéBoite
            // 
            txtQuantitéBoite.AcceptsReturn = true;
            txtQuantitéBoite.BackColor = System.Drawing.SystemColors.Window;
            txtQuantitéBoite.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuantitéBoite.Enabled = false;
            txtQuantitéBoite.ForeColor = System.Drawing.SystemColors.WindowText;
            txtQuantitéBoite.Location = new System.Drawing.Point(80, 16);
            txtQuantitéBoite.MaxLength = 0;
            txtQuantitéBoite.Name = "txtQuantitéBoite";
            txtQuantitéBoite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQuantitéBoite.Size = new System.Drawing.Size(33, 22);
            txtQuantitéBoite.TabIndex = 30;
            txtQuantitéBoite.Leave += new System.EventHandler(txtQuantitéBoite_Leave);
            // 
            // chkBoite
            // 
            chkBoite.BackColor = System.Drawing.Color.Black;
            chkBoite.ForeColor = System.Drawing.Color.White;
            chkBoite.Location = new System.Drawing.Point(8, 16);
            chkBoite.Name = "chkBoite";
            chkBoite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkBoite.Size = new System.Drawing.Size(73, 17);
            chkBoite.TabIndex = 29;
            chkBoite.Text = "Par Boîte :";
            chkBoite.UseVisualStyleBackColor = true;
            chkBoite.CheckStateChanged += new System.EventHandler(chkBoite_CheckStateChanged);
            // 
            // Label11
            // 
            Label11.BackColor = System.Drawing.Color.Black;
            Label11.ForeColor = System.Drawing.Color.White;
            Label11.Location = new System.Drawing.Point(120, 40);
            Label11.Name = "Label11";
            Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label11.Size = new System.Drawing.Size(73, 17);
            Label11.TabIndex = 35;
            Label11.Text = "À commander :";
            // 
            // Label5
            // 
            Label5.BackColor = System.Drawing.Color.Black;
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(8, 40);
            Label5.Name = "Label5";
            Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label5.Size = new System.Drawing.Size(73, 17);
            Label5.TabIndex = 34;
            Label5.Text = "Stock :";
            // 
            // cmbLocalisation
            // 
            cmbLocalisation.BackColor = System.Drawing.SystemColors.Window;
            cmbLocalisation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbLocalisation.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbLocalisation.Location = new System.Drawing.Point(368, 200);
            cmbLocalisation.Name = "cmbLocalisation";
            cmbLocalisation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbLocalisation.Size = new System.Drawing.Size(105, 22);
            cmbLocalisation.TabIndex = 39;
            cmbLocalisation.SelectedIndexChanged += new System.EventHandler(cmbLocalisation_SelectedIndexChanged);
            // 
            // txtLocalisation
            // 
            txtLocalisation.AcceptsReturn = true;
            txtLocalisation.BackColor = System.Drawing.SystemColors.Window;
            txtLocalisation.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtLocalisation.ForeColor = System.Drawing.SystemColors.WindowText;
            txtLocalisation.Location = new System.Drawing.Point(368, 200);
            txtLocalisation.MaxLength = 0;
            txtLocalisation.Name = "txtLocalisation";
            txtLocalisation.ReadOnly = true;
            txtLocalisation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtLocalisation.Size = new System.Drawing.Size(105, 22);
            txtLocalisation.TabIndex = 40;
            txtLocalisation.Text = "Text1";
            // 
            // cmdRechercheAchat
            // 
            cmdRechercheAchat.BackColor = System.Drawing.Color.Black;
            cmdRechercheAchat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercheAchat.Font = new System.Drawing.Font("Calibri", 8.25F);
            cmdRechercheAchat.ForeColor = System.Drawing.Color.White;
            cmdRechercheAchat.Location = new System.Drawing.Point(222, 201);
            cmdRechercheAchat.Name = "cmdRechercheAchat";
            cmdRechercheAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercheAchat.Size = new System.Drawing.Size(127, 24);
            cmdRechercheAchat.TabIndex = 80;
            cmdRechercheAchat.Text = "Recherche dans achats";
            cmdRechercheAchat.UseVisualStyleBackColor = true;
            cmdRechercheAchat.Click += new System.EventHandler(cmdRechercheAchat_Click);
            // 
            // Label4
            // 
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(368, 184);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(65, 17);
            Label4.TabIndex = 27;
            Label4.Text = "Localisation :";
            // 
            // Label2
            // 
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(256, 8);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(121, 17);
            Label2.TabIndex = 1;
            Label2.Text = "Catégorie de pièce :";
            // 
            // _Label1_25
            // 
            _Label1_25.BackColor = System.Drawing.Color.Black;
            _Label1_25.ForeColor = System.Drawing.Color.White;
            _Label1_25.Location = new System.Drawing.Point(32, 152);
            _Label1_25.Name = "_Label1_25";
            _Label1_25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_25.Size = new System.Drawing.Size(113, 17);
            _Label1_25.TabIndex = 23;
            _Label1_25.Text = "Pièce GRB :";
            // 
            // _Label1_6
            // 
            _Label1_6.BackColor = System.Drawing.Color.Black;
            _Label1_6.ForeColor = System.Drawing.Color.White;
            _Label1_6.Location = new System.Drawing.Point(296, 128);
            _Label1_6.Name = "_Label1_6";
            _Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_6.Size = new System.Drawing.Size(81, 17);
            _Label1_6.TabIndex = 22;
            _Label1_6.Text = "Commentaire :";
            // 
            // _Label1_4
            // 
            _Label1_4.BackColor = System.Drawing.Color.Black;
            _Label1_4.ForeColor = System.Drawing.Color.White;
            _Label1_4.Location = new System.Drawing.Point(296, 96);
            _Label1_4.Name = "_Label1_4";
            _Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_4.Size = new System.Drawing.Size(73, 17);
            _Label1_4.TabIndex = 20;
            _Label1_4.Text = "Desc. EN :";
            // 
            // _Label1_3
            // 
            _Label1_3.BackColor = System.Drawing.Color.Black;
            _Label1_3.ForeColor = System.Drawing.Color.White;
            _Label1_3.Location = new System.Drawing.Point(296, 64);
            _Label1_3.Name = "_Label1_3";
            _Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_3.Size = new System.Drawing.Size(73, 17);
            _Label1_3.TabIndex = 12;
            _Label1_3.Text = "Desc. FR :";
            // 
            // _Label1_1
            // 
            _Label1_1.BackColor = System.Drawing.Color.Black;
            _Label1_1.ForeColor = System.Drawing.Color.White;
            _Label1_1.Location = new System.Drawing.Point(32, 64);
            _Label1_1.Name = "_Label1_1";
            _Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_1.Size = new System.Drawing.Size(89, 17);
            _Label1_1.TabIndex = 7;
            _Label1_1.Text = "Manufacturier :";
            // 
            // _Label1_0
            // 
            _Label1_0.BackColor = System.Drawing.Color.Black;
            _Label1_0.ForeColor = System.Drawing.Color.White;
            _Label1_0.Location = new System.Drawing.Point(32, 120);
            _Label1_0.Name = "_Label1_0";
            _Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_0.Size = new System.Drawing.Size(73, 17);
            _Label1_0.TabIndex = 16;
            _Label1_0.Text = "Pièce :";
            // 
            // panel1
            // 
            panel1.Controls.Add(lvwRechercheJob);
            panel1.Controls.Add(lvwRechercheAchat);
            panel1.Controls.Add(lvwfournisseur);
            panel1.Controls.Add(lvwCategorie);
            panel1.Controls.Add(lvwDescription);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(774, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(555, 709);
            panel1.TabIndex = 82;
            // 
            // CatalogueMec
            // 
            AcceptButton = CmdEnr;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1329, 709);
            Controls.Add(panel1);
            Controls.Add(cmdRechercheCategorie);
            Controls.Add(cmdRechercheJob);
            Controls.Add(cmdCopier);
            Controls.Add(cmdTotal);
            Controls.Add(cmdRechercheInventaire);
            Controls.Add(lvwFabricant);
            Controls.Add(lvwPieces);
            Controls.Add(cmdChangerCategorie);
            Controls.Add(cmdDemande);
            Controls.Add(cmdRechercheDescrFR);
            Controls.Add(frafournisseur);
            Controls.Add(cmbCategorie);
            Controls.Add(txtNoItemGRB);
            Controls.Add(cmbNoItem);
            Controls.Add(CmdModif);
            Controls.Add(CmdFerme);
            Controls.Add(CmdSupp);
            Controls.Add(CmdAdd);
            Controls.Add(txtComment);
            Controls.Add(cmbFabricant);
            Controls.Add(txtFabricant);
            Controls.Add(txtDescriptionEN);
            Controls.Add(txtDescriptionFR);
            Controls.Add(txtNoItem);
            Controls.Add(CmdAnul);
            Controls.Add(CmdEnr);
            Controls.Add(txtCategorie);
            Controls.Add(cmdRechercherPiece);
            Controls.Add(cmbDescriptionFR);
            Controls.Add(cmdRechercherManufact);
            Controls.Add(chkInventaire);
            Controls.Add(fraQuantité);
            Controls.Add(cmbLocalisation);
            Controls.Add(txtLocalisation);
            Controls.Add(cmdRechercheAchat);
            Controls.Add(Label4);
            Controls.Add(Label2);
            Controls.Add(_Label1_25);
            Controls.Add(_Label1_6);
            Controls.Add(_Label1_4);
            Controls.Add(_Label1_3);
            Controls.Add(_Label1_1);
            Controls.Add(_Label1_0);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            Location = new System.Drawing.Point(97, 68);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CatalogueMec";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ControleurServeur.CatalogueMec";
            Load += new System.EventHandler(FrCatalogueMec_Load);
            Click += new System.EventHandler(FrCatalogueMec_Click);
            frafournisseur.ResumeLayout(false);
            frafournisseur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(imgCanada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgEU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgSpain)).EndInit();
            fraQuantité.ResumeLayout(false);
            fraQuantité.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        private const short I_COL_DES_DESCR_FR = 0;
        private const short I_COL_DES_DESCR_EN = 1;
        private const short I_COL_DES_FABRICANT = 2;
        private const short I_COL_DES_PIECE = 3;
        private const short I_COL_PIECE_PIECE = 0;
        private const short I_COL_PIECE_FABRICANT = 1;
        private const short I_COL_PIECE_DESCR_FR = 2;
        private const short I_COL_PIECE_DESCR_EN = 3;
        private const short I_COL_MAN_FABRICANT = 0;
        private const short I_COL_MAN_PIECE = 1;
        private const short I_COL_MAN_DESCR_FR = 2;
        private const short I_COL_MAN_DESCR_EN = 3;
        private const short I_COL_FRS_FRS = 0;
        private const short I_COL_FRS_PERS_RESS = 1;
        private const short I_COL_FRS_DATE = 2;
        private const short I_COL_FRS_ENTRER_PAR = 3;
        private const short I_COL_FRS_VALIDE = 4;
        private const short I_COL_FRS_PRIX_LIST = 5;
        private const short I_COL_FRS_ESCOMPTE = 6;
        private const short I_COL_FRS_PRIX_NET = 7;
        private const short I_COL_FRS_PRIX_SP = 8;
        private const short I_COL_FRS_QUOTER = 9;
        private const short I_COL_JOB_NUMERO = 0;
        private const short I_COL_JOB_QUANTITE = 1;
        private const short I_COL_ACHAT_NUMERO = 0;
        private const short I_COL_ACHAT_QUANTITE = 1;
        public enum enumModeCatalogueMec { MODE_AJOUT_MODIF_MEC = 0, MODE_INACTIF = 1, MODE_AJOUT_MODIF_FRS = 2 }
        public EnumModeDemande m_eDemande;
        public bool m_bDemandeAnnuler;
        public bool m_bAjout;
        public string m_sCategorieCopie;
        public bool m_bAnnulerCopie;
        private bool m_bRempliManuel;
        private string m_sNoItem;
        private List<String> m_collPieceDescFR;
        private bool m_bBloqueDescription;
        private enumModeCatalogueMec m_eMode;
        public string m_sSelectCategorie;
        public string m_sSelectFabricant;
        public string m_sSelectNoItem;
        private string m_sQteStockAvant;
        private bool m_bCopiePiece;
        public bool lastentry;
        public string sChoisirTous;
        private double TwipsToPixelsY = 0.3d;
        public void ViderChamps_frs()
        {
            try
            {
               cmbfrs.SelectedIndex = -1;
               txtPrixSpecial.Text = string.Empty;
               cmbPersRess.SelectedIndex = -1;
               txtPrixList.Text = string.Empty;
               mskEscompte.Text = string.Empty;
               txtPrixNet.Text = string.Empty;
               mskValide.Text = string.Empty;
               chkquoter.CheckState = CheckState.Unchecked;
               optCAN.Checked = true;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "ViderChamps_frs", ex); }
        }
        public void ViderChamps_piece()
        {
            try
            {
                // Vide les champs pieces
               txtNoItemGRB.Text = string.Empty;
               txtDescriptionEN.Text = string.Empty;
               txtComment.Text = string.Empty;
               txtQuantitéBoite.Text = string.Empty;
               txtQuantiteCommande.Text = string.Empty;
               txtQuantiteMinimum.Text = string.Empty;
               txtQuantiteStock.Text = string.Empty;
               txtLocalisation.Text = string.Empty;
               cmbLocalisation.SelectedIndex = -1;
               chkBoite.CheckState = CheckState.Unchecked;
               chkInventaire.CheckState = CheckState.Unchecked;
               chkMinimum.CheckState = CheckState.Unchecked;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "ViderChamps_piece", ex); }
        }
        public void BarrerChamps_piece(bool bLocked)
        {
            try
            {
                // Barre les champs
               txtNoItem.ReadOnly = bLocked;
               txtNoItemGRB.ReadOnly = bLocked;
               txtDescriptionEN.ReadOnly = bLocked;
               txtDescriptionFR.ReadOnly = bLocked;
               txtComment.ReadOnly = bLocked;
               frafournisseur.Enabled = bLocked;
               chkInventaire.Enabled = !bLocked;
                if (chkInventaire.Enabled == true)
                {
                    if (chkInventaire.CheckState == CheckState.Checked)
                    {
                       fraQuantité.Enabled = true;
                    }
                    else
                    {
                       fraQuantité.Enabled = false;
                    }
                }
                else
                {
                   fraQuantité.Enabled = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "BarrerChamps_piece", ex); }
        }
        public void MontrerControles(enumModeCatalogueMec eMode)
        {
            try
            {
                var bTable = default(bool);
                var bFabricant = default(bool);
                var bNoItem = default(bool);
                var bLocalisation = default(bool);
                var bCmdAddFRS = default(bool);
                var bCmdModifFRS = default(bool);
                var bCmdSuppFRS = default(bool);
                var bCmdEnrFRS = default(bool);
                var bCmdAnnulFRS = default(bool);
                var bCmdAdd = default(bool);
                var bCmdModif = default(bool);
                var bCmdSupp = default(bool);
                var bCmdFermer = default(bool);
                var bCmdEnr = default(bool);
                var bCmdAnnul = default(bool);
                var bFraFRS = default(bool);
                var bLvwFRS = default(bool);
                var bCmdSearchMan = default(bool);
                var bCmdSearchPiece = default(bool);
                var bCmdSearchDescr = default(bool);
                var bCmdDemande = default(bool);
                bool bCategorie;
                var bCmbDescFR = default(bool);
                var bCopier = default(bool);
                var bChangerCat = default(bool);
                var bInventaire = default(bool);
               m_eMode = eMode;
                switch (eMode)
                {
                    case enumModeCatalogueMec.MODE_INACTIF:
                        {
                            bTable = true;
                            bFabricant = true;
                            bNoItem = true;
                            bCmdAddFRS = true;
                            bCmdModifFRS = true;
                            bCmdSuppFRS = true;
                            bCmdAdd = true;
                            bCmdModif = true;
                            bCmdSupp = true;
                            bCmdFermer = true;
                            bFraFRS = true;
                            bLvwFRS = true;
                            bCmdSearchMan = true;
                            bCmdSearchPiece = true;
                            bCmdSearchDescr = true;
                            bCmdDemande = true;
                            bCategorie = true;
                            bCopier = true;
                            bCmbDescFR = true;
                            bInventaire = true;
                            break;
                        }
                    case enumModeCatalogueMec.MODE_AJOUT_MODIF_MEC:
                        {
                            bCmdAddFRS = true;
                            bCmdModifFRS = true;
                            bCmdSuppFRS = true;
                            bCmdEnr = true;
                            bFabricant = true; // GLL 2017-10-10
                           txtFabricant.Enabled = true; // GLL 2017-10-10
                            bCmdAnnul = true;
                            bLvwFRS = true;
                            bCmdSearchDescr = true;
                            bLocalisation = true;
                            bChangerCat = true;
                            break;
                        }
                    case enumModeCatalogueMec.MODE_AJOUT_MODIF_FRS:
                        {
                            bCmdEnrFRS = true;
                            bCmdAnnulFRS = true;
                            bFraFRS = true;
                            break;
                        }
                }
               cmbCategorie.Visible = bTable;
               txtCategorie.Visible = !bTable;
               cmbDescriptionFR.Visible = bCmbDescFR;
               txtDescriptionFR.Visible = !bCmbDescFR;
               cmbFabricant.Visible = bFabricant;
               txtFabricant.Visible = bFabricant;
               cmbNoItem.Visible = bNoItem;
               txtNoItem.Visible = !bNoItem;
               cmbLocalisation.Visible = bLocalisation;
               txtLocalisation.Visible = !bLocalisation;
               frafournisseur.Enabled = bFraFRS;
               lvwfournisseur.Visible = bLvwFRS;
               cmdAddFrs.Visible = bCmdAddFRS;
               cmdModifFrs.Visible = bCmdModifFRS;
               cmdSuppFrs.Visible = bCmdSuppFRS;
               cmdEnrFrs.Visible = bCmdEnrFRS;
               cmdAnnulFrs.Visible = bCmdAnnulFRS;
               CmdAdd.Visible = bCmdAdd;
               CmdModif.Visible = bCmdModif;
               CmdSupp.Visible = bCmdSupp;
               CmdFerme.Visible = bCmdFermer;
               CmdEnr.Visible = bCmdEnr;
               CmdAnul.Visible = bCmdAnnul;
               cmdDemande.Visible = bCmdDemande;
               cmdCopier.Visible = bCopier;
               cmdRechercheDescrFR.Enabled = bCmdSearchDescr;
               cmdRechercherPiece.Enabled = bCmdSearchPiece;
               cmdRechercherManufact.Enabled = bCmdSearchMan;
               cmdChangerCategorie.Visible = bChangerCat;
               cmdRechercheInventaire.Visible = bInventaire;
               lblDevise1.Visible = false;
               txtTauxChange.Visible = false;
               lblDevise2.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "MontrerControles", ex); }
        }

        private void RemplirComboPersRess()
        {
            try
            {
                ADODB.Recordset rstContact;
                ADODB.Recordset rstContactFRS;
               cmbPersRess.Items.Clear();
                rstContactFRS = new ADODB.Recordset();
                rstContact = new ADODB.Recordset();
                rstContactFRS.Open("SELECT * FROM ContactFRS WHERE NoFRS = " + cmbfrs.Text.Split('-')[0], odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                while (!rstContactFRS.EOF)
                {
                    rstContact.Open(Operators.ConcatenateObject("SELECT NomContact, IDContact FROM Contact WHERE IDContact = ", rstContactFRS.Fields["NoContact"].Value), odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    if (!rstContact.EOF)
                    {
                       cmbPersRess.Items.Add(new ListItem($"{rstContact.Fields["NomContact"].Value}", $"{rstContact.Fields["IDContact"].Value}"));
                    }
                    rstContact.Close();
                    rstContactFRS.MoveNext();
                }
                rstContactFRS.Close();
                rstContactFRS = null;
                if (cmbPersRess.Items.Count == 0)
                {
                    rstContact.Open("SELECT NomContact, IDContact FROM Contact WHERE Supprimé=0ORDER BY NomContact", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    while (!rstContact.EOF)
                    {
                       cmbPersRess.Items.Add(new ListItem($"{rstContact.Fields["NomContact"].Value}", $"{rstContact.Fields["IDContact"].Value}"));
                        rstContact.MoveNext();
                    }
                    rstContact.Close();
                }
                rstContact = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "RemplirComboPersRess", ex); }
        }
        private void chkBoite_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == enumModeCatalogueMec.MODE_AJOUT_MODIF_MEC)
                {
                    if (chkBoite.CheckState == CheckState.Checked)
                    {
                       txtQuantitéBoite.Enabled = true;
                    }
                    else
                    {
                       txtQuantitéBoite.Enabled = false;
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "chkBoite_Click", ex); }
        }
        private void chkInventaire_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == enumModeCatalogueMec.MODE_AJOUT_MODIF_MEC)
                {
                    if (chkInventaire.CheckState == CheckState.Checked)
                    {
                       fraQuantité.Enabled = true;
                       cmbLocalisation.Enabled = true;
                    }
                    else
                    {
                       fraQuantité.Enabled = false;
                       cmbLocalisation.Enabled = false;
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "chkInventaire_Click", ex); }
        }
        private void chkMinimum_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == enumModeCatalogueMec.MODE_AJOUT_MODIF_MEC)
                {
                    if (chkMinimum.CheckState == CheckState.Checked)
                    {
                       txtQuantiteMinimum.Enabled = true;
                       txtQuantiteCommande.Enabled = true;
                    }
                    else
                    {
                       txtQuantiteMinimum.Enabled = false;
                       txtQuantiteCommande.Enabled = false;
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "chkMinimum_Click", ex); }
        }
        private void cmbDescriptionFR_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstCatMec;
                string sNoItem;
                short X;
               txtDescriptionFR.Text =cmbDescriptionFR.Text;
                if (m_bBloqueDescription == false)
                {
                    var loopTo = (short)(cmbNoItem.Items.Count - 1);
                    for (X = 0; X <= loopTo; X++)
                    {
                        if (cmbNoItem.Items[X].ToString() ==m_collPieceDescFR[cmbDescriptionFR.SelectedIndex + 1])
                        {
                           cmbNoItem.SelectedIndex = X;
                            break;
                        }
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmbDescriptionFR_Click", ex); }
        }
        private void cmbfrs_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbfrs.SelectedIndex != -1)
                {
                    ListItem it = (ListItem)cmbfrs.Items[cmbfrs.SelectedIndex];
                   cmbfrs.Tag = it.Value;
                   RemplirComboPersRess();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmbfrs_Click", ex); }
        }
        private void cmbLocalisation_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
               txtLocalisation.Text =cmbLocalisation.Text;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CatalogueMec", "cmbLocalisation_Click", ex);
            }
        }
        private void CmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
               m_bBloqueDescription = true;
                AddItemMec addItem = new AddItemMec();
                addItem.MdiParent = Conteneur.Mdi;
                addItem.Show();
               m_bBloqueDescription = false;
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "CmdAdd_Click", ex); }
        }
        private void cmdAddFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbNoItem.Items.Count > 0)
                {
                   m_bAjout = true;
                   BarrerChamps_piece(true);
                   ViderChamps_frs();
                   cmbfrs.Focus();
                   MontrerControles(enumModeCatalogueMec.MODE_AJOUT_MODIF_FRS);
                   AfficherDrapeau();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdAddFrs_Click", ex); }
        }
        private void cmdAnnulFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
               MontrerControles(enumModeCatalogueMec.MODE_INACTIF);
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdAnnulFrs_Click", ex); }
        }
        private void CmdAnul_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
               txtPrixNet.Enabled = true;
               txtPrixSpecial.Enabled = true;
               m_bBloqueDescription = true;
               AfficherItem();
               txtFabricant.Top = (int)Math.Round(TwipsToPixelsY * 1320d); // GLL 2017-10-10
               cmbFabricant.Visible = true; // GLL 2017-10-10
               m_bBloqueDescription = false;
               m_bCopiePiece = false;
               cmbFabricant.Visible = false;
               cmbNoItem.Visible = false;
               MontrerControles(enumModeCatalogueMec.MODE_INACTIF);
               BarrerChamps_piece(true);
               m_sQteStockAvant = "";
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "CmdAnul_Click", ex); }
        }
        private void EnregistrerItem()
        {
            try
            {
                ADODB.Recordset rstItem;
                ADODB.Recordset rstItemFRS;
                ADODB.Recordset rstItemFRSDest;
                ADODB.Recordset rstVerif;
                ADODB.Recordset rstInventaire;
                ADODB.Recordset rstInvModif;
                string sNomFab;
                string sNoPiece;
                short X;
                var sPieceModif = default(string);
                string sLettre;
                sNomFab =txtFabricant.Text;
                sNoPiece =txtNoItem.Text;
                if (m_bCopiePiece == true |m_bCopiePiece == false & (Strings.UCase(sNoPiece) ?? "") != (Strings.UCase(m_sNoItem) ?? ""))
                {
                    rstVerif = new ADODB.Recordset();
                    rstVerif.Open("SELECT * FROM CatalogueMec WHERE PIECE = '" + Strings.Replace(sNoPiece, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    if (!rstVerif.EOF)
                    {
                        Interaction.MsgBox("Le numéro " + sNoPiece + " existe déjà!", MsgBoxStyle.OkOnly, "Erreur");
                        rstVerif.Close();
                        rstVerif = null;
                        return;
                    }
                    rstVerif.Close();
                    rstVerif = null;
                }
                if (string.IsNullOrEmpty(txtFabricant.Text) | string.IsNullOrEmpty(txtNoItem.Text) | string.IsNullOrEmpty(txtDescriptionFR.Text))
                {
                    Interaction.MsgBox("Les champs Manufacturier, Pièce et Desc. FR doivent être remplis!", MsgBoxStyle.OkOnly, "Erreur");
                    return;
                }
                rstItem = new ADODB.Recordset();
                rstItem.Open("SELECT * FROM CatalogueMec WHERE PIECE = '" + Strings.Replace(m_sNoItem, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                rstItemFRS = new ADODB.Recordset();
                rstItemFRS.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(Conversions.ToString(rstItem.Fields["PIECE"].Value), "'", "''") + "' AND Type = 'M'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                if (m_bCopiePiece == false)
                {
                    while (!rstItemFRS.EOF)
                    {
                        rstItemFRS.Fields["PIECE"].Value =txtNoItem.Text;
                        rstItemFRS.Update();
                        rstItemFRS.MoveNext();
                    }
                }
                else
                {
                    rstItemFRSDest = new ADODB.Recordset();
                    rstItemFRSDest.Open("SELECT * FROM PiecesFRS", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    while (!rstItemFRS.EOF)
                    {
                        rstItemFRSDest.AddNew();
                        rstItemFRSDest.Fields["IDFRS"].Value = rstItemFRS.Fields["IDFRS"].Value;
                        rstItemFRSDest.Fields["PIECE"].Value = sNoPiece;
                        rstItemFRSDest.Fields["PRIX_SP"].Value = rstItemFRS.Fields["PRIX_SP"].Value;
                        rstItemFRSDest.Fields["PERS_RESS"].Value = rstItemFRS.Fields["PERS_RESS"].Value;
                        rstItemFRSDest.Fields["PRIX_LIST"].Value = rstItemFRS.Fields["PRIX_LIST"].Value;
                        rstItemFRSDest.Fields["ESCOMPTE"].Value = rstItemFRS.Fields["ESCOMPTE"].Value;
                        rstItemFRSDest.Fields["PRIX_NET"].Value = rstItemFRS.Fields["PRIX_NET"].Value;
                        rstItemFRSDest.Fields["DATE"].Value = rstItemFRS.Fields["DATE"].Value;
                        rstItemFRSDest.Fields["ENTRER_PAR"].Value = rstItemFRS.Fields["ENTRER_PAR"].Value;
                        rstItemFRSDest.Fields["VALIDE"].Value = rstItemFRS.Fields["VALIDE"].Value;
                        rstItemFRSDest.Fields["QUOTER"].Value = rstItemFRS.Fields["QUOTER"].Value;
                        rstItemFRSDest.Fields["DeviseMonétaire"].Value = rstItemFRS.Fields["DeviseMonétaire"].Value;
                        rstItemFRSDest.Fields["Type"].Value = rstItemFRS.Fields["Type"].Value;
                        rstItemFRSDest.Update();
                        rstItemFRS.MoveNext();
                    }
                    rstItemFRSDest.Close();
                    rstItemFRSDest = null;
                }
                rstItemFRS.Close();
                rstItemFRS = null;
                if (m_bCopiePiece == true)
                {
                    rstItem.AddNew();
                }
                rstItem.Fields["CATEGORIE"].Value =txtCategorie.Text;
                rstItem.Fields["PIECE"].Value = sNoPiece;
                for (X = 1; X <= sNoPiece.Length; X++)
                {
                    sLettre = Strings.Mid(sNoPiece, X, 1);
                    if (sLettre[X] >= 48 & sLettre[X] <= 57 | sLettre[X] >= 65 & sLettre[X] <= 90 | sLettre[X] >= 97 & sLettre[X] <= 122)
                    {
                        sPieceModif = sPieceModif + sLettre;
                    }
                }
                rstItem.Fields["PIECE_MODIF"].Value = sPieceModif;
                rstItem.Fields["FABRICANT"].Value = sNomFab;
                rstItem.Fields["PIECE_GRB"].Value =txtNoItemGRB.Text;
                rstItem.Fields["DESC_EN"].Value =txtDescriptionEN.Text;
                rstItem.Fields["DESC_FR"].Value =txtDescriptionFR.Text;
                rstItem.Fields["COMMENTAIRE"].Value =txtComment.Text;
                rstItem.Update();
                rstItem.Close();
                rstItem = null;
                if (chkInventaire.CheckState == CheckState.Checked)
                {
                    rstInventaire = new ADODB.Recordset();
                    if (m_bCopiePiece == true)
                    {
                        rstInventaire.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + Strings.Replace(sNoPiece, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstInventaire.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + Strings.Replace(m_sNoItem, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    }
                    if (rstInventaire.EOF)
                    {
                        rstInventaire.AddNew();
                    }
                    rstInventaire.Fields["NoItem"].Value =txtNoItem.Text;
                    rstInventaire.Fields["Description"].Value =txtDescriptionFR.Text;
                    rstInventaire.Fields["Manufacturier"].Value = sNomFab;
                    if (chkBoite.CheckState == CheckState.Checked)
                    {
                        rstInventaire.Fields["CommandeParBoite"].Value = true;
                        rstInventaire.Fields["QteBoite"].Value =txtQuantitéBoite.Text;
                    }
                    else
                    {
                        rstInventaire.Fields["CommandeParBoite"].Value = false;
                        rstInventaire.Fields["QteBoite"].Value = "";
                    }
                    rstItemFRS = new ADODB.Recordset();
                    rstItemFRS.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(txtNoItem.Text, "'", "''") + "' AND IDFRS = 717", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    if (rstItemFRS.EOF)
                    {
                        rstItemFRS.AddNew();
                        rstItemFRS.Fields["PIECE"].Value =txtNoItem.Text;
                        rstItemFRS.Fields["IDFRS"].Value = 717;
                        rstItemFRS.Fields["Type"].Value = "M";
                        rstItemFRS.Fields["PERS_RESS"].Value = DBNull.Value;
                        rstItemFRS.Fields["PRIX_LIST"].Value = "0";
                        rstItemFRS.Fields["ESCOMPTE"].Value = "0";
                        rstItemFRS.Fields["PRIX_NET"].Value = "0";
                        rstItemFRS.Fields["PrixReel"].Value = "0";
                        rstItemFRS.Fields["DATE"].Value = ConvertDate(DateTime.Today);
                        rstItemFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                        rstItemFRS.Fields["DeviseMonétaire"].Value = "CAN";
                        rstItemFRS.Update();
                    }
                    if (chkBoite.CheckState == CheckState.Checked)
                    {
                        if (IsNumeric(rstItemFRS.Fields["PRIX_LIST"].Value))
                        {
                            rstInventaire.Fields["Prix Liste"].Value = Math.Round(Operators.DivideObject(rstItemFRS.Fields["PRIX_LIST"].Value, double.Parse(txtQuantitéBoite.Text)), 6);
                        }
                        else
                        {
                            rstInventaire.Fields["Prix Liste"].Value = "0";
                        }
                        if (IsNumeric(rstItemFRS.Fields["ESCOMPTE"].Value))
                        {
                            rstInventaire.Fields["Escompte"].Value = rstItemFRS.Fields["ESCOMPTE"].Value;
                        }
                        else
                        {
                            rstInventaire.Fields["Escompte"].Value = "0";
                        }
                        if (IsNumeric(rstItemFRS.Fields["PRIX_NET"].Value))
                        {
                            rstInventaire.Fields["Prix net"].Value = Math.Round(Operators.DivideObject(rstItemFRS.Fields["PRIX_NET"].Value, double.Parse(txtQuantitéBoite.Text)), 6);
                        }
                        else
                        {
                            rstInventaire.Fields["Prix net"].Value = "0";
                        }
                    }
                    else
                    {
                        rstInventaire.Fields["Prix Liste"].Value = rstItemFRS.Fields["PRIX_LIST"].Value;
                        rstInventaire.Fields["Escompte"].Value = rstItemFRS.Fields["ESCOMPTE"].Value;
                        rstInventaire.Fields["Prix net"].Value = rstItemFRS.Fields["PRIX_NET"].Value;
                    }
                    rstItemFRS.Close();
                    rstItemFRS = null;
                    rstInventaire.Fields["Commentaires"].Value =txtComment.Text;
                    rstInventaire.Fields["Localisation"].Value =cmbLocalisation.Text;
                    if (!string.IsNullOrEmpty(Strings.Trim(txtQuantiteStock.Text)))
                    {
                        rstInventaire.Fields["QuantitéStock"].Value =txtQuantiteStock.Text;
                    }
                    else
                    {
                        rstInventaire.Fields["QuantitéStock"].Value = "0";
                    }
                    if (chkMinimum.CheckState == CheckState.Checked)
                    {
                        rstInventaire.Fields["Minimum"].Value = true;
                        if (!string.IsNullOrEmpty(Strings.Trim(txtQuantiteMinimum.Text)))
                        {
                            rstInventaire.Fields["QuantitéMinimum"].Value =txtQuantiteMinimum.Text;
                        }
                        else
                        {
                            rstInventaire.Fields["QuantitéMinimum"].Value = "0";
                        }
                        if (Conversions.ToBoolean(Strings.Trim(txtQuantiteCommande.Text)) == true)
                        {
                            rstInventaire.Fields["Commande"].Value =txtQuantiteCommande.Text;
                        }
                        else
                        {
                            rstInventaire.Fields["Commande"].Value = "0";
                        }
                    }
                    else
                    {
                        rstInventaire.Fields["Minimum"].Value = false;
                        rstInventaire.Fields["QuantitéMinimum"].Value = "";
                        rstInventaire.Fields["Commande"].Value = "";
                    }
                    rstInventaire.Update();
                    rstInventaire.Close();
                    rstInventaire = null;
                }
                else if (m_bCopiePiece == true)
                {
                    odbc.Execute("DELETE FROM InventaireMec WHERE NoItem = '" + sNoPiece.Replace("'", "''") + "'", out sortie, -1);
                }
                else
                {
                    odbc.Execute("DELETE FROM InventaireMec WHERE NoItem = '" + m_sNoItem.Replace("'", "''") + "'", out sortie, -1);
                }
                if (m_bCopiePiece == false)
                {
                    if ((txtQuantiteStock.Text ?? "") != (m_sQteStockAvant ?? "") | !string.IsNullOrEmpty(m_sQteStockAvant) &m_sQteStockAvant != "0" &chkInventaire.CheckState == CheckState.Unchecked)
                    {
                        if (string.IsNullOrEmpty(m_sQteStockAvant))
                        {
                           m_sQteStockAvant = "0";
                        }
                        if (!IsNumeric(txtQuantiteStock.Text))
                        {
                           txtQuantiteStock.Text = "0";
                        }
                        rstInvModif = new ADODB.Recordset();
                        rstInvModif.Open("SELECT * FROM InventaireMecModif", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                        rstInvModif.AddNew();
                        rstInvModif.Fields["Date"].Value = ConvertDate(DateTime.Today);
                        rstInvModif.Fields["IDProjet"].Value = Interaction.InputBox("Précisez l'ajustement d'inventaire");
                        rstInvModif.Fields["NoItem"].Value =txtNoItem.Text;
                        if (chkInventaire.CheckState == CheckState.Checked)
                        {
                            rstInvModif.Fields["Quantité"].Value = double.Parse(txtQuantiteStock.Text) - double.Parse(m_sQteStockAvant);
                        }
                        else
                        {
                            rstInvModif.Fields["Quantité"].Value = 0d - double.Parse(m_sQteStockAvant);
                        }
                        rstInvModif.Fields["User"].Value = Conteneur.idInitiales.Text;
                        rstInvModif.Update();
                        rstInvModif.Close();
                        rstInvModif = null;
                    }
                }
                if ((Strings.UCase(sNoPiece) ?? "") != (Strings.UCase(m_sNoItem) ?? "") &m_bCopiePiece == false)
                {
                   ModifierNoItem(m_sNoItem, sNoPiece);
                }
               m_sQteStockAvant = "";
               m_bRempliManuel = true;
               m_sSelectNoItem = sNoPiece;
               m_sSelectFabricant = sNomFab;
               RemplirComboLocalisation();
               RemplirComboFabricant();
               MontrerControles(enumModeCatalogueMec.MODE_INACTIF);
               BarrerChamps_piece(true);
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "EnregistrerItem", ex); }
        }
        private void cmdChangerCategorie_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstPiece;
                ChoixCategorie cat = new ChoixCategorie(EnumCatalogue.MECANIQUE);
                cat.MdiParent = Conteneur.Mdi;
                cat.Show();
                if ((txtCategorie.Text ?? "") != (m_sCategorieCopie ?? ""))
                {
                    if (m_bAnnulerCopie == false)
                    {
                        rstPiece = new ADODB.Recordset();
                        rstPiece.Open("SELECT * FROM CatalogueMec WHERE PIECE = '" + Strings.Replace(cmbNoItem.Text, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                        rstPiece.Fields["CATEGORIE"].Value =m_sCategorieCopie;
                        rstPiece.Update();
                        rstPiece.Close();
                        rstPiece = null;
                       ViderChamps_piece();
                       m_sSelectFabricant =txtFabricant.Text;
                       RemplirComboFabricant();
                       MontrerControles(enumModeCatalogueMec.MODE_INACTIF);
                       BarrerChamps_piece(true);
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdChangerCategorie_Click", ex); }
        }
        private void cmdCopier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
               m_bCopiePiece = true;
               CmdModif_Click(CmdModif, new EventArgs());
               chkInventaire.CheckState = CheckState.Unchecked;
               chkBoite.CheckState = CheckState.Unchecked;
               chkMinimum.CheckState = CheckState.Unchecked;
               txtQuantitéBoite.Text = "";
               txtQuantiteStock.Text = "";
               txtQuantiteMinimum.Text = "";
               txtQuantiteCommande.Text = "";
               cmbLocalisation.Text = "";
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdCopier_Click", ex); }
        }
        private void cmdDemande_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                DemandePrix dp = new DemandePrix(this);
                dp.MdiParent = Conteneur.Mdi;
                dp.Show();
                if (m_bDemandeAnnuler == false)
                {
                    ChoixDemande cd = new ChoixDemande(EnumCatalogue.MECANIQUE,m_eDemande);
                    cd.Show();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdDemande_Click", ex); }
        }
        private void CmdEnr_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                short X;
                bool bContinuer;
               txtFabricant.Top = (int)Math.Round(TwipsToPixelsY * 1320d);
               cmbFabricant.Visible = false;
                if ((Strings.UCase(txtNoItem.Text) ?? "") != (Strings.UCase(m_sNoItem) ?? "") &m_bCopiePiece == false)
                {
                    if (Interaction.MsgBox("Le numéro de pièce sera modifié dans toutes les soumissions, les projets et les achats. " + "\n" + "Voulez-vous continuer ?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
                    {
                        bContinuer = true;
                    }
                    else
                    {
                        bContinuer = false;
                    }
                }
                else
                {
                    bContinuer = true;
                }
                if (bContinuer == true)
                {
                   EnregistrerItem();
                    if (m_eMode == enumModeCatalogueMec.MODE_INACTIF)
                    {
                       m_bCopiePiece = false;
                    }
                   RemplirComboDescription();
                   m_bBloqueDescription = true;
                    for (X = 0; X <= (short)(cmbDescriptionFR.Items.Count - 1); X++)
                    {

                        if ((cmbDescriptionFR.Items[X].ToString() ?? "") == (txtDescriptionFR.Text ?? ""))
                        {
                           cmbDescriptionFR.SelectedIndex = X;
                            break;
                        }
                    }
                   m_bBloqueDescription = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "CmdEnr_Click", ex); }
        }
        private void ModifierNoItem(string sAncienNoItem, string sNouveauNoItem)
        {
            try
            {
                var iRecordProjet = default(short);
                var iRecordSoum = default(short);
                var iRecordAchat = default(short);
                object argRecordsAffected = iRecordProjet;
                odbc.Execute("UPDATE Projet_Pieces SET NumItem = '" + Strings.Replace(sNouveauNoItem, "'", "''") + "' WHERE NumItem = '" + sAncienNoItem.Replace("'", "''") + "' AND Type = 'M'", out argRecordsAffected);
                iRecordProjet = Conversions.ToShort(argRecordsAffected);
                object argRecordsAffected1 = iRecordSoum;
                odbc.Execute("UPDATE Soumission_Pieces SET NumItem = '" + Strings.Replace(sNouveauNoItem, "'", "''") + "' WHERE NumItem = '" + sAncienNoItem.Replace("'", "''") + "' AND Type = 'M'", out argRecordsAffected1);
                iRecordSoum = Conversions.ToShort(argRecordsAffected1);
                object argRecordsAffected2 = iRecordAchat;
                odbc.Execute("UPDATE Achat_Pieces SET PIECE = '" + Strings.Replace(sNouveauNoItem, "'", "''") + "' WHERE PIECE = '" + sAncienNoItem.Replace("'", "''") + "' AND Left(IDAchat, 1) = 'M'", out argRecordsAffected2);
                iRecordAchat = Conversions.ToShort(argRecordsAffected2);
                odbc.Execute("UPDATE InventaireMecModif SET NoItem = '" + sNouveauNoItem.Replace("'", "''") + "' WHERE NoItem = '" + sAncienNoItem.Replace("'", "''") + "'", out sortie, -1);
                Interaction.MsgBox("Numéros de pièces modifiés" + "\n" + "\n" + "Projets : " + iRecordProjet + "\n" + "Soumissions : " + iRecordSoum + "\n" + "Achats : " + iRecordAchat, MsgBoxStyle.OkOnly);
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "ModifierNoItem", ex); }
        }
        private void cmdEnrFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                short X;
                if (string.IsNullOrEmpty(Strings.Trim(txtPrixList.Text)) & string.IsNullOrEmpty(Strings.Trim(mskEscompte.Text)) & string.IsNullOrEmpty(Strings.Trim(txtPrixNet.Text)) & string.IsNullOrEmpty(Strings.Trim(txtPrixSpecial.Text)))
                {
                   txtPrixList.Text = "0";
                   mskEscompte.Text = "0";
                   txtPrixNet.Text = "0";
                }
                if (string.IsNullOrEmpty(Strings.Trim(txtPrixList.Text)))
                {
                    if (string.IsNullOrEmpty(Strings.Trim(txtPrixSpecial.Text)))
                    {
                        Interaction.MsgBox("Vous devez remplir le prix listé!", MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                }
                if (string.IsNullOrEmpty(Strings.Trim(txtPrixNet.Text)) & string.IsNullOrEmpty(Strings.Trim(txtPrixSpecial.Text)))
                {
                    Interaction.MsgBox("Vous devez remplir le prix net ou le prix spécial!", MsgBoxStyle.OkOnly, "Erreur");
                    return;
                }
                if (optUSA.Checked == true |optSpain.Checked == true)
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTauxChange.Text)))
                    {
                        if (!IsNumeric(txtTauxChange.Text))
                        {
                            Interaction.MsgBox("Le taux de change doit être numérique!", MsgBoxStyle.OkOnly, "Erreur");
                            return;
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("Le taux de change ne doit pas être vide!", MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                }
                if ((Strings.Trim(txtPrixNet.Text) ?? "") != (Strings.Trim(txtPrixList.Text) ?? "") & string.IsNullOrEmpty(Strings.Trim(txtPrixSpecial.Text)))
                {
                   CalculerPrixNet();
                }
                if (cmbfrs.SelectedIndex > -1)
                {
                   EnregistrerFRS();
                }
                else
                {
                    Interaction.MsgBox("Vous devez choisir un fournisseur!", MsgBoxStyle.OkOnly, "Erreur");
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdEnrFrs_Click", ex); }
        }
        private void EnregistrerFRS()
        {
            try
            {
                ADODB.Recordset rstItemFRS;
                ADODB.Recordset rstInv;
                ADODB.Recordset rstConfig;
                bool bDistribExiste;
                var X = default(short);
                if (!string.IsNullOrEmpty(txtPrixSpecial.Text))
                {
                    if (!IsNumeric(txtPrixSpecial.Text))
                    {
                        Interaction.MsgBox("Le prix spécial est invalide!", MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(txtPrixNet.Text))
                {
                    if (!IsNumeric(txtPrixNet.Text))
                    {
                        Interaction.MsgBox("Le prix net est invalide!", MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(txtPrixList.Text))
                {
                    if (!IsNumeric(txtPrixList.Text))
                    {
                        Interaction.MsgBox("Le prix listé est invalide!", MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(Strings.Trim(mskValide.Text)))
                {
                    if (Information.IsDate(mskValide.Text) == false)
                    {
                        Interaction.MsgBox("La date de validité est invalide!", MsgBoxStyle.OkOnly, "Erreur");
                        return;
                    }
                }
                bDistribExiste = false;
                if (m_bAjout == true)
                {
                    if (lvwfournisseur.Items.Count > 0)
                    {
                        var loopTo = (short)lvwfournisseur.Items.Count;
                        for (X = 1; X <= loopTo; X++)
                        {
                            if ((lvwfournisseur.Items[X].Text ?? "") == (cmbfrs.Text ?? ""))
                            {
                                bDistribExiste = true;
                                break;
                            }
                        }
                    }
                    if (bDistribExiste == true)
                    {
                        if (!string.IsNullOrEmpty(txtPrixSpecial.Text))
                        {
                            if (!string.IsNullOrEmpty(lvwfournisseur.Items[X].SubItems[I_COL_FRS_PRIX_SP].Text))
                            {
                                Interaction.MsgBox("Ce distributeur est déjà ajouté avec un prix spécial", MsgBoxStyle.OkOnly, "Erreur");
                                return;
                            }
                        }
                        else if (!string.IsNullOrEmpty(lvwfournisseur.Items[X].SubItems[I_COL_FRS_PRIX_NET].Text))
                        {
                            Interaction.MsgBox("Ce distributeur est déjà ajouté avec un prix net", MsgBoxStyle.OkOnly, "Erreur");
                            return;
                        }
                    }
                }
                rstItemFRS = new ADODB.Recordset();
                if (m_bAjout == true)
                {
                    rstItemFRS.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(txtNoItem.Text, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    rstItemFRS.AddNew();
                   m_bAjout = false;
                }
                else
                {
                    rstItemFRS.Open(Operators.ConcatenateObject("SELECT * FROM PiecesFRS WHERE noEnreg = ",lvwfournisseur.FocusedItem.Tag), odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                }
                rstItemFRS.Fields["PIECE"].Value =cmbNoItem.Text;
                rstItemFRS.Fields["IDFRS"].Value =cmbfrs.Tag;
                rstItemFRS.Fields["Type"].Value = "M";
                if (cmbPersRess.SelectedIndex > -1)
                {
                    ListItem iti = (ListItem)cmbPersRess.SelectedItem;
                    rstItemFRS.Fields["PERS_RESS"].Value = iti.Value;
                }
                else
                {
                    rstItemFRS.Fields["PERS_RESS"].Value = DBNull.Value;
                }
                rstItemFRS.Fields["PRIX_LIST"].Value =txtPrixList.Text;
                rstItemFRS.Fields["ESCOMPTE"].Value =mskEscompte.Text;
                if (!string.IsNullOrEmpty(txtPrixSpecial.Text) | !string.IsNullOrEmpty(txtPrixNet.Text))
                {
                    if (!string.IsNullOrEmpty(txtPrixNet.Text))
                    {
                        rstItemFRS.Fields["PRIX_NET"].Value =txtPrixNet.Text;
                        rstItemFRS.Fields["PrixReel"].Value =txtPrixNet.Text;
                    }
                    else
                    {
                        rstItemFRS.Fields["PRIX_NET"].Value = string.Empty;
                    }
                    if (!string.IsNullOrEmpty(txtPrixSpecial.Text))
                    {
                        rstItemFRS.Fields["PRIX_SP"].Value =txtPrixSpecial.Text;
                        rstItemFRS.Fields["PrixReel"].Value =txtPrixNet.Text;
                    }
                    else
                    {
                        rstItemFRS.Fields["PRIX_SP"].Value = string.Empty;
                    }
                }
                rstItemFRS.Fields["DATE"].Value = ConvertDate(DateTime.Today);
                rstItemFRS.Fields["VALIDE"].Value =mskValide.Text;
                rstItemFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                if ((int)chkquoter.CheckState == 1)
                {
                    rstItemFRS.Fields["Quoter"].Value = true;
                }
                else
                {
                    rstItemFRS.Fields["Quoter"].Value = false;
                }
                if (optCAN.Checked == true)
                {
                    rstItemFRS.Fields["DeviseMonétaire"].Value = "CAN";
                }
                else if (optUSA.Checked == true)
                {
                    rstItemFRS.Fields["DeviseMonétaire"].Value = "USA";
                }
                else
                {
                    rstItemFRS.Fields["DeviseMonétaire"].Value = "SPA";
                }
                rstItemFRS.Update();
                rstItemFRS.Close();
                rstItemFRS = null;
                if (optUSA.Checked == true |optSpain.Checked == true)
                {
                    rstConfig = new ADODB.Recordset();
                    rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    if (optUSA.Checked == true)
                    {
                        rstConfig.Fields["TauxAmericain"].Value =txtTauxChange.Text;
                    }
                    else
                    {
                        rstConfig.Fields["TauxEspagnol"].Value =txtTauxChange.Text;
                    }
                    rstConfig.Update();
                    rstConfig.Close();
                    rstConfig = null;
                }
               MontrerControles(enumModeCatalogueMec.MODE_INACTIF);
                ListItem it = (ListItem)cmbfrs.SelectedItem;
                if (it.Value == "717")
                {
                    rstInv = new ADODB.Recordset();
                    rstInv.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + Strings.Replace(txtNoItem.Text, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    if (!rstInv.EOF)
                    {
                        if (!string.IsNullOrEmpty(txtPrixNet.Text))
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInv.Fields["CommandeParBoite"].Value, true, false)))
                            {
                                rstInv.Fields["Prix Liste"].Value = Operators.DivideObject(double.Parse(txtPrixList.Text), rstInv.Fields["QteBoite"].Value);
                                rstInv.Fields["Escompte"].Value =mskEscompte.Text;
                                rstInv.Fields["Prix net"].Value = Operators.DivideObject(double.Parse(txtPrixNet.Text), rstInv.Fields["QteBoite"].Value);
                            }
                            else
                            {
                                rstInv.Fields["Prix Liste"].Value =txtPrixList.Text;
                                rstInv.Fields["Escompte"].Value =mskEscompte.Text;
                                rstInv.Fields["Prix net"].Value =txtPrixNet.Text;
                            }
                        }
                        else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInv.Fields["CommandeParBoite"].Value, true, false)))
                        {
                            rstInv.Fields["Prix Liste"].Value = Operators.DivideObject(double.Parse(txtPrixSpecial.Text), rstInv.Fields["QteBoite"].Value);
                            rstInv.Fields["Escompte"].Value = "";
                            rstInv.Fields["Prix net"].Value = Operators.DivideObject(double.Parse(txtPrixSpecial.Text), rstInv.Fields["QteBoite"].Value);
                        }
                        else
                        {
                            rstInv.Fields["Prix Liste"].Value =txtPrixSpecial.Text;
                            rstInv.Fields["Escompte"].Value = "";
                            rstInv.Fields["Prix net"].Value =txtPrixSpecial.Text;
                        }
                        rstInv.Update();
                    }
                    rstInv.Close();
                    rstInv = null;
                }
               RemplirListViewFournisseur();
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "EnregistrerFRS", ex); }
        }
        private void CmdFerme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
               Close();
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "CmdFerme_Click", ex); }
        }
        private void CmdModif_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbNoItem.Items.Count > 0)
                {
                   MontrerControles(enumModeCatalogueMec.MODE_AJOUT_MODIF_MEC);
                   txtFabricant.Top = (int)Math.Round(TwipsToPixelsY * 960d);
                   cmbFabricant.Visible = false;
                   m_sQteStockAvant =txtQuantiteStock.Text;
                   BarrerChamps_piece(false);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "CmdModif_Click", ex); }
        }
        private void cmdModifFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwfournisseur.Items.Count > 0)
                {
                   ModifierFournisseur();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdModifFrs_Click", ex); }
        }
        private void cmdRechercheCategorie_Click(object eventSender, EventArgs eventArgs)
        {
            ADODB.Recordset rstcatalog;
            string sDescription;
            ListViewItem itmDescription;
            sDescription = Interaction.InputBox("Quelle est la catégorie à rechercher");
            if (!string.IsNullOrEmpty(sDescription))
            {
               lvwCategorie.Items.Clear();
                sDescription = Strings.Replace(sDescription, "'", "''");
                sDescription = "%" + sDescription + "%";
                rstcatalog = new ADODB.Recordset();

                rstcatalog.Open("SELECT DISTINCT CATEGORIE FROM CatalogueMec WHERE  Categorie LIKE '" + sDescription + "'  ORDER BY CATEGORIE", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                while (!rstcatalog.EOF)
                {
                    itmDescription =lvwCategorie.Items.Add("");
                    itmDescription.Tag = rstcatalog.Fields["CATEGORIE"].Value;
                    itmDescription.Text = Conversions.ToString(rstcatalog.Fields["CATEGORIE"].Value);
                    rstcatalog.MoveNext();
                }
                rstcatalog.Close();
                rstcatalog = null;
                if (lvwCategorie.Items.Count > 0)
                {
                   lvwCategorie.Visible = true;
                   lvwCategorie.Focus();
                }
                else
                {
                    Interaction.MsgBox("Aucun enregistrement trouvé!");
                }
            }
            return;
        }
        private void cmdRechercheDescrFR_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstDescription;
                string sDescription;
                ListViewItem itmDescription;
                sDescription = Interaction.InputBox("Quelle est la description à rechercher");
                if (!string.IsNullOrEmpty(sDescription))
                {
                   lvwDescription.Items.Clear();
                    sDescription = sDescription.Replace("'", "''");
                    sDescription = "%" + sDescription + "%";
                    rstDescription = new ADODB.Recordset();
                    rstDescription.Open("SELECT * FROM CatalogueMec WHERE DESC_FR LIKE '" + sDescription + "' OR DESC_EN LIKE '" + sDescription + "' ORDER BY DESC_FR, DESC_EN", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    while (!rstDescription.EOF)
                    {
                        itmDescription =lvwDescription.Items.Add(string.Empty);
                        itmDescription.Tag = rstDescription.Fields["CATEGORIE"].Value;

                        if (!(rstDescription.Fields["DESC_FR"].Value is DBNull))
                        {
                            itmDescription.Text = Strings.Trim(Conversions.ToString(rstDescription.Fields["DESC_FR"].Value));
                        }
                        else
                        {
                            itmDescription.Text = string.Empty;
                        }

                        if (!(rstDescription.Fields["DESC_EN"].Value is DBNull))
                        {
                            if (itmDescription.SubItems.Count > I_COL_DES_DESCR_EN)
                            {
                                itmDescription.SubItems[I_COL_DES_DESCR_EN].Text = Strings.Trim(Conversions.ToString(rstDescription.Fields["DESC_EN"].Value));
                            }
                            else
                            {
                                itmDescription.SubItems.Insert(I_COL_DES_DESCR_EN, new ListViewItem.ListViewSubItem(null, Strings.Trim(Conversions.ToString(rstDescription.Fields["DESC_EN"].Value))));
                            }
                        }
                        else if (itmDescription.SubItems.Count > I_COL_DES_DESCR_EN)
                        {
                            itmDescription.SubItems[I_COL_DES_DESCR_EN].Text = string.Empty;
                        }
                        else
                        {
                            itmDescription.SubItems.Insert(I_COL_DES_DESCR_EN, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }

                        if (!(rstDescription.Fields["FABRICANT"].Value is DBNull))
                        {
                            if (itmDescription.SubItems.Count > I_COL_DES_FABRICANT)
                            {
                                itmDescription.SubItems[I_COL_DES_FABRICANT].Text = Strings.Trim(Conversions.ToString(rstDescription.Fields["FABRICANT"].Value));
                            }
                            else
                            {
                                itmDescription.SubItems.Insert(I_COL_DES_FABRICANT, new ListViewItem.ListViewSubItem(null, Strings.Trim(Conversions.ToString(rstDescription.Fields["FABRICANT"].Value))));
                            }
                        }
                        else if (itmDescription.SubItems.Count > I_COL_DES_FABRICANT)
                        {
                            itmDescription.SubItems[I_COL_DES_FABRICANT].Text = string.Empty;
                        }
                        else
                        {
                            itmDescription.SubItems.Insert(I_COL_DES_FABRICANT, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        if (itmDescription.SubItems.Count > I_COL_DES_PIECE)
                        {
                            itmDescription.SubItems[I_COL_DES_PIECE].Text = Strings.Trim(Conversions.ToString(rstDescription.Fields["PIECE"].Value));
                        }
                        else
                        {
                            itmDescription.SubItems.Insert(I_COL_DES_PIECE, new ListViewItem.ListViewSubItem(null, Strings.Trim(Conversions.ToString(rstDescription.Fields["PIECE"].Value))));
                        }
                        rstDescription.MoveNext();
                    }
                    rstDescription.Close();
                    rstDescription = null;
                    if (lvwDescription.Items.Count > 0)
                    {
                       lvwDescription.Visible = true;
                       lvwDescription.Focus();
                    }
                    else
                    {
                        Interaction.MsgBox("Aucun enregistrement trouvé!");
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdRechercheDescrFR_Click", ex); }
        }
        private void cmdRechercheInventaire_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RechercheInventaire ri = new RechercheInventaire(EnumCatalogue.MECANIQUE);

                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdRechercheInventaire_Click", ex); }
        }
        private void cmdRechercheJob_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ListViewItem itmProjSoum;
                Cursor.Current = Cursors.WaitCursor;
               lvwRechercheJob.Items.Clear();
                rstProjSoum = new ADODB.Recordset();
                rstProjSoum.Open("SELECT DISTINCT IDProjet, Qté As QtéTotale FROM Projet_Pieces WHERE TRIM(NumItem) = '" + Strings.Trim(Strings.Replace(txtNoItem.Text, "'", "''")) + "' And Type = 'M' GROUP BY IDProjet", odbc, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly);
                while (!rstProjSoum.EOF)
                {
                    itmProjSoum =lvwRechercheJob.Items.Add(string.Empty);
                    itmProjSoum.Text = Conversions.ToString(rstProjSoum.Fields["IDProjet"].Value);

                    if (itmProjSoum.SubItems.Count > I_COL_JOB_QUANTITE)
                    {
                        itmProjSoum.SubItems[I_COL_JOB_QUANTITE].Text = Conversions.ToString(rstProjSoum.Fields["QtéTotale"].Value);
                    }
                    else
                    {
                        itmProjSoum.SubItems.Insert(I_COL_JOB_QUANTITE, new ListViewItem.ListViewSubItem(null, Conversions.ToString(rstProjSoum.Fields["QtéTotale"].Value)));
                    }
                    rstProjSoum.MoveNext();
                }
                rstProjSoum.Close();
                rstProjSoum.Open("SELECT DISTINCT IDSoumission, SUM(Qté) As QtéTotale FROM Soumission_Pieces WHERE TRIM(NumItem) = '" + Strings.Trim(Strings.Replace(txtNoItem.Text, "'", "''")) + "' And Type = 'M' GROUP BY IDSoumission", odbc, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly);
                while (!rstProjSoum.EOF)
                {
                    itmProjSoum =lvwRechercheJob.Items.Add(string.Empty);
                    itmProjSoum.Text = Conversions.ToString(rstProjSoum.Fields["IDSoumission"].Value);
                    if (itmProjSoum.SubItems.Count > I_COL_JOB_QUANTITE)
                    {
                        itmProjSoum.SubItems[I_COL_JOB_QUANTITE].Text = Conversions.ToString(rstProjSoum.Fields["QtéTotale"].Value);
                    }
                    else
                    {
                        itmProjSoum.SubItems.Insert(I_COL_JOB_QUANTITE, new ListViewItem.ListViewSubItem(null, Conversions.ToString(rstProjSoum.Fields["QtéTotale"].Value)));
                    }
                    rstProjSoum.MoveNext();
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                Cursor.Current = Cursors.Default;
                if (lvwRechercheJob.Items.Count > 0)
                {
                   lvwRechercheJob.Visible = true;
                   lvwRechercheJob.Focus();
                }
                else
                {
                    Interaction.MsgBox("Cette pièce n'a jamais été utilisée dans les jobs!", MsgBoxStyle.OkOnly);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdRechercheJob_Click", ex); }
        }
        private void cmdRechercheAchat_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstAchat;
                ListViewItem itmAchat;
                Cursor.Current = Cursors.WaitCursor;
               lvwRechercheAchat.Items.Clear();
                rstAchat = new ADODB.Recordset();
                rstAchat.Open("SELECT DISTINCT (IDAchat + '-' + RIGHT('00' & IndexAchat,3)) As NumeroAchat, SUM(Qté) As QtéTotale FROM Achat_Pieces WHERE TRIM(PIECE) = '" + Strings.Trim(Strings.Replace(txtNoItem.Text, "'", "''")) + "' GROUP BY (IDAchat + '-' + RIGHT('00' & IndexAchat,3))", odbc, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly);
                while (!rstAchat.EOF)
                {
                    itmAchat =lvwRechercheAchat.Items.Add(string.Empty);
                    itmAchat.Text = Conversions.ToString(rstAchat.Fields["NumeroAchat"].Value);
                    if (itmAchat.SubItems.Count > I_COL_ACHAT_QUANTITE)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_QUANTITE].Text = Conversions.ToString(rstAchat.Fields["QtéTotale"].Value);
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_QUANTITE, new ListViewItem.ListViewSubItem(null, Conversions.ToString(rstAchat.Fields["QtéTotale"].Value)));
                    }
                    rstAchat.MoveNext();
                }
                rstAchat.Close();
                rstAchat = null;
                Cursor.Current = Cursors.Default;
                if (lvwRechercheAchat.Items.Count > 0)
                {
                   lvwRechercheAchat.Visible = true;
                   lvwRechercheAchat.Focus();
                }
                else
                {
                    Interaction.MsgBox("Cette pièce n'a jamais été utilisée dans les achats!", MsgBoxStyle.OkOnly);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdRechercheAchat_Click", ex); }
        }
        private void cmdRechercherManufact_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstManufact;
                string sManufact;
                ListViewItem itmManufact;
                sManufact = Interaction.InputBox("Quel est le manufacturier à rechercher");
                sManufact = Strings.Replace(sManufact, "'", "''");
                if (!string.IsNullOrEmpty(sManufact))
                {
                   lvwFabricant.Items.Clear();
                    rstManufact = new ADODB.Recordset();
                    rstManufact.Open("SELECT * FROM CatalogueMec WHERE FABRICANT like '%" + sManufact + "% ORDER BY FABRICANT", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    while (!rstManufact.EOF)
                    {
                        itmManufact =lvwFabricant.Items.Add("");
                        itmManufact.Tag = rstManufact.Fields["CATEGORIE"].Value;
                        itmManufact.Text = Conversions.ToString(rstManufact.Fields["FABRICANT"].Value);
                        if (itmManufact.SubItems.Count > I_COL_MAN_PIECE)
                        {
                            itmManufact.SubItems[I_COL_MAN_PIECE].Text = Strings.Trim(Conversions.ToString(rstManufact.Fields["PIECE"].Value));
                        }
                        else
                        {
                            itmManufact.SubItems.Insert(I_COL_MAN_PIECE, new ListViewItem.ListViewSubItem(null, Strings.Trim(Conversions.ToString(rstManufact.Fields["PIECE"].Value))));
                        }

                        if (!(rstManufact.Fields["DESC_FR"].Value is DBNull))
                        {
                            if (itmManufact.SubItems.Count > I_COL_MAN_DESCR_FR)
                            {
                                itmManufact.SubItems[I_COL_MAN_DESCR_FR].Text = Strings.Trim(Conversions.ToString(rstManufact.Fields["DESC_FR"].Value));
                            }
                            else
                            {
                                itmManufact.SubItems.Insert(I_COL_MAN_DESCR_FR, new ListViewItem.ListViewSubItem(null, Strings.Trim(Conversions.ToString(rstManufact.Fields["DESC_FR"].Value))));
                            }
                        }
                        else if (itmManufact.SubItems.Count > I_COL_MAN_DESCR_FR)
                        {
                            itmManufact.SubItems[I_COL_MAN_DESCR_FR].Text = string.Empty;
                        }
                        else
                        {
                            itmManufact.SubItems.Insert(I_COL_MAN_DESCR_FR, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }

                        if (!(rstManufact.Fields["DESC_EN"].Value is DBNull))
                        {
                            if (itmManufact.SubItems.Count > I_COL_MAN_DESCR_EN)
                            {
                                itmManufact.SubItems[I_COL_MAN_DESCR_EN].Text = Strings.Trim(Conversions.ToString(rstManufact.Fields["DESC_EN"].Value));
                            }
                            else
                            {
                                itmManufact.SubItems.Insert(I_COL_MAN_DESCR_EN, new ListViewItem.ListViewSubItem(null, Strings.Trim(Conversions.ToString(rstManufact.Fields["DESC_EN"].Value))));
                            }
                        }
                        else if (itmManufact.SubItems.Count > I_COL_MAN_DESCR_EN)
                        {
                            itmManufact.SubItems[I_COL_MAN_DESCR_EN].Text = string.Empty;
                        }
                        else
                        {
                            itmManufact.SubItems.Insert(I_COL_MAN_DESCR_EN, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        rstManufact.MoveNext();
                    }
                    rstManufact.Close();
                    rstManufact = null;
                    if (lvwFabricant.Items.Count > 0)
                    {
                       lvwFabricant.Visible = true;
                       lvwFabricant.Focus();
                    }
                    else
                    {
                        Interaction.MsgBox("Aucun enregistrement trouvé!");
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdRechercherManufact_Click", ex); }
        }
        private void cmdTotal_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sAnnee;
                ADODB.Recordset rstTotal;
                double dblTotalProj;
                double dblTotalAchat;
                sAnnee = Interaction.InputBox("Pour quelle année? (AAAA)");
                if (Strings.Len(sAnnee) == 4)
                {
                    if (IsNumeric(sAnnee))
                    {
                        if (Conversions.ToShort(sAnnee) <= System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today))
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            rstTotal = new ADODB.Recordset();
                            rstTotal.Open("SELECT SUM(Qté) As Total FROM Projet_Pieces " +
                                "INNER JOIN ProjetMec ON Projet_Pieces.IDProjet = ProjetMec.IDProjet WHERE TRIM(NumItem) = '" + Strings.Trim(Strings.Replace(txtNoItem.Text, "'", "''")) + "' AND Type = 'M' AND Left(Creer, 4) = '" + sAnnee + "' AND RIGHT(Projet_Pieces.IDProjet,2) < '60'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);

                            if (!(rstTotal.Fields["Total"].Value is DBNull))
                            {
                                dblTotalProj = double.Parse(rstTotal.Fields["Total"].Value);
                            }
                            else
                            {
                                dblTotalProj = 0d;
                            }
                            rstTotal.Close();
                            rstTotal.Open("SELECT SUM(Qté) As Total FROM Achat_Pieces " +
                                "INNER JOIN Achat ON Achat_Pieces.IDAchat = Achat.IDAchat AND Achat_Pieces.IndexAchat = Achat.IndexAchat" +
                                " WHERE TRIM(PIECE) = '" + Strings.Trim(Strings.Replace(txtNoItem.Text, "'", "''")) + "' AND Left(DateAchat,4) = '" + sAnnee + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);

                            if (!(rstTotal.Fields["Total"].Value is DBNull))
                            {
                                dblTotalAchat = double.Parse(rstTotal.Fields["Total"].Value);
                            }
                            else
                            {
                                dblTotalAchat = 0d;
                            }
                            rstTotal.Close();
                            rstTotal = null;
                            Cursor.Current = Cursors.Default;
                            Interaction.MsgBox("Quantité utilisée en " + sAnnee + " : " + "\n" + "\n" + "Projets : " + dblTotalProj + "\n" + "Achats : " + dblTotalAchat);
                        }
                        else
                        {
                            Interaction.MsgBox("Année trop grande!", MsgBoxStyle.OkOnly, "Erreur");
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("Année non numérique!", MsgBoxStyle.OkOnly, "Erreur");
                    }
                }
                else if (Strings.Len(sAnnee) != 0)
                {
                    Interaction.MsgBox("L'année doit être sur 4 chiffres!", MsgBoxStyle.OkOnly, "Erreur");
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdTotal_Click", ex); }
        }
        private void FrCatalogueMec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
               lvwDescription.Visible = false;
               lvwFabricant.Visible = false;
               lvwPieces.Visible = false;
               lvwRechercheJob.Visible = false;
               lvwRechercheAchat.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "Form_Click", ex); }
        }
        private void frafournisseur_Click()
        {
            try
            {
               lvwDescription.Visible = false;
               lvwFabricant.Visible = false;
               lvwPieces.Visible = false;
               lvwRechercheJob.Visible = false;
               lvwRechercheAchat.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "aFournisseur_Click", ex); }
        }
        private void fraQuantité_Click()
        {
            try
            {
               lvwDescription.Visible = false;
               lvwFabricant.Visible = false;
               lvwPieces.Visible = false;
               lvwRechercheJob.Visible = false;
               lvwRechercheAchat.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "aQuantité_Click", ex); }
        }


        private void lvwCategorie_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            ListViewItem itmDescription;
            short X;
            if (lvwCategorie.Items.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                itmDescription =lvwCategorie.FocusedItem;
               cmbCategorie.Text =lvwCategorie.FocusedItem.Text;
               cmbCategorie_SelectedIndexChanged(cmbCategorie, new EventArgs());
               lvwCategorie.Visible = false;
                Cursor.Current = Cursors.Default;
            }
            return;
        }
        private void lvwCategorie_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwCategorie.Visible == true)
                {
                   lvwCategorie.Visible = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("mCatalogueElec", "lvwCategorie_LostFocus", ex); }
        }
        private void lvwDescription_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            short KeyCode = (short)eventArgs.KeyCode;
            short Shift = (short)((int)eventArgs.KeyData / 0x10000);
            try
            {
                if (KeyCode == (int)Keys.Return)
                {
                   lvwDescription_DoubleClick(lvwDescription, new EventArgs());
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwDescription_KeyDown", ex); }
        }
        private void lvwFabricant_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader =lvwFabricant.Columns[eventArgs.Column];
            try
            {
               lvwFabricant.Sort();
                if (lvwFabricant.Sorting == SortOrder.Ascending)
                {
                   lvwFabricant.Sorting = SortOrder.Descending;
                }
                else
                {
                   lvwFabricant.Sorting = SortOrder.Ascending;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwFabricant_ColumnClick", ex); }
        }
        private void lvwDescription_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader =lvwDescription.Columns[eventArgs.Column];
            try
            {
               lvwDescription.Sort();
                if (lvwDescription.Sorting == SortOrder.Ascending)
                {
                   lvwDescription.Sorting = SortOrder.Descending;
                }
                else
                {
                   lvwDescription.Sorting = SortOrder.Ascending;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwDescription_ColumnClick", ex); }
        }
        private void lvwFabricant_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            short KeyCode = (short)eventArgs.KeyCode;
            short Shift = (short)((int)eventArgs.KeyData / 0x10000);
            try
            {
                if (KeyCode == (int)Keys.Return)
                {
                   lvwFabricant_DoubleClick(lvwFabricant, new EventArgs());
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwFabricant_KeyDown", ex); }
        }
        private void lvwPieces_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader =lvwPieces.Columns[eventArgs.Column];
            try
            {
               lvwPieces.Sort();
                if (lvwPieces.Sorting == SortOrder.Ascending)
                {
                   lvwPieces.Sorting = SortOrder.Descending;
                }
                else
                {
                   lvwPieces.Sorting = SortOrder.Ascending;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwPieces_ColumnClick", ex); }
        }
        private void lvwPieces_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            short KeyCode = (short)eventArgs.KeyCode;
            short Shift = (short)((int)eventArgs.KeyData / 0x10000);
            try
            {
                if (KeyCode == (int)Keys.Return)
                {
                   lvwPieces_DoubleClick(lvwPieces, new EventArgs());
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwPieces_KeyDown", ex); }
        }
        private void lvwRechercheJob_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader =lvwRechercheJob.Columns[eventArgs.Column];
            try
            {
                if (lvwRechercheJob.Sorting == SortOrder.Ascending)
                {
                   lvwRechercheJob.Sorting = SortOrder.Descending;
                }
                else
                {
                   lvwRechercheJob.Sorting = SortOrder.Ascending;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwRechercheJob_ColumnClick", ex); }
        }
        private void lvwRechercheAchat_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader =lvwRechercheAchat.Columns[eventArgs.Column];
            try
            {
                if (lvwRechercheAchat.Sorting == SortOrder.Ascending)
                {
                   lvwRechercheAchat.Sorting = SortOrder.Descending;
                }
                else
                {
                   lvwRechercheAchat.Sorting = SortOrder.Ascending;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwRechercheAchat_ColumnClick", ex); }
        }
        private void lvwFabricant_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ListViewItem itmFabricant;
                short X;
                Cursor.Current = Cursors.WaitCursor;
                itmFabricant =lvwFabricant.FocusedItem;
               m_sSelectCategorie = Strings.Trim(Conversions.ToString(itmFabricant.Tag));
               m_sSelectFabricant = Strings.Trim(itmFabricant.Text);
               m_sSelectNoItem = Strings.Trim(itmFabricant.SubItems[I_COL_MAN_PIECE].Text);
               RemplirComboCategorie();
               lvwFabricant.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwFabricant_DblClick", ex); }
        }
        private void lvwDescription_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ListViewItem itmDescription;
                short X;
                Cursor.Current = Cursors.WaitCursor;
                if (lvwDescription.Items.Count > 0)
                {
                    itmDescription =lvwDescription.FocusedItem;
                    if (m_eMode == enumModeCatalogueMec.MODE_INACTIF)
                    {
                       m_sSelectCategorie = Strings.Trim(Conversions.ToString(itmDescription.Tag));
                       m_sSelectFabricant = Strings.Trim(itmDescription.SubItems[I_COL_DES_FABRICANT].Text);
                       m_sSelectNoItem = Strings.Trim(itmDescription.SubItems[I_COL_DES_PIECE].Text);
                       RemplirComboCategorie();
                    }
                    else
                    {
                       txtDescriptionFR.Text = itmDescription.Text;
                       txtDescriptionEN.Text = itmDescription.SubItems[I_COL_DES_DESCR_EN].Text;
                    }
                   lvwDescription.Visible = false;
                    Cursor.Current = Cursors.Default;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwDescription_DblClick", ex); }
        }
        private void CmdSupp_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sDescription;
                short X;

                if (cmbNoItem.Items.Count > 0)
                {
                    if (Interaction.MsgBox("Voulez-vous vraiment effacer la pièce " +txtNoItem.Text + "?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
                    {






                        if (chkInventaire.CheckState == CheckState.Checked)
                        {
                            odbc.Execute("DELETE FROM InventaireMec WHERE NoItem = '" + cmbNoItem.Text.Replace("'", "''") + "'", out sortie, -1);
                        }
                        odbc.Execute("DELETE FROM CatalogueMec WHERE PIECE = '" + cmbNoItem.Text.Replace("'", "''") + "'", out sortie, -1);
                        odbc.Execute("DELETE FROM PiecesFRS WHERE PIECE = '" + cmbNoItem.Text.Replace("'", "''") + "'", out sortie, -1);
                       m_bRempliManuel = true;
                       m_sSelectNoItem = string.Empty;
                        if (cmbNoItem.Items.Count > 1)
                        {
                           m_sSelectFabricant =cmbFabricant.Text;
                        }
                        else
                        {
                           m_sSelectFabricant = "";
                        }
                       RemplirComboFabricant();
                        if (cmbFabricant.Items.Count == 0)
                        {
                           cmbNoItem.Items.Clear();
                           cmbCategorie.Items.RemoveAt(cmbCategorie.SelectedIndex);
                            if (cmbCategorie.Items.Count > 0)
                            {
                               cmbCategorie.SelectedIndex = 0;
                            }
                            else
                            {
                               ViderChamps_frs();
                               lvwfournisseur.Items.Clear();
                               ViderChamps_piece();
                            }
                        }
                        sDescription =txtDescriptionFR.Text;
                        var loopTo = (short)(cmbDescriptionFR.Items.Count - 1);
                        for (X = 0; X <= loopTo; X++)
                        {
                            if ((cmbDescriptionFR.Items[X].ToString() ?? "") == (sDescription ?? ""))
                            {
                               m_bBloqueDescription = true;
                               cmbDescriptionFR.SelectedIndex = X;
                               m_bBloqueDescription = false;
                                break;
                            }
                        }
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "CmdSupp_Click", ex); }
        }
        private void AfficherItem()
        {
            try
            {
                ADODB.Recordset rstItem;
                ADODB.Recordset rstInventaire;
                short X;
               ViderChamps_piece();
                rstItem = new ADODB.Recordset();
                rstItem.Open("SELECT * FROM CatalogueMec WHERE PIECE = '" + Strings.Replace(m_sNoItem, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                if (!rstItem.EOF)
                {
                    if (!(rstItem.Fields["PIECE_GRB"].Value is DBNull))
                    {
                       txtNoItemGRB.Text = Strings.Trim(Conversions.ToString(rstItem.Fields["PIECE_GRB"].Value));
                    }
                    else
                    {
                       txtNoItemGRB.Text = string.Empty;
                    }
                    if (!(rstItem.Fields["DESC_EN"].Value is DBNull))
                    {
                       txtDescriptionEN.Text = Strings.Trim(Conversions.ToString(rstItem.Fields["DESC_EN"].Value));
                    }
                    else
                    {
                       txtDescriptionEN.Text = string.Empty;
                    }
                    if (!(rstItem.Fields["FABRICANT"].Value is DBNull))
                    {
                       txtFabricant.Text = Strings.Trim(Conversions.ToString(rstItem.Fields["FABRICANT"].Value));
                    }
                    else
                    {
                       txtFabricant.Text = string.Empty;
                    }
                    if (!(rstItem.Fields["DESC_FR"].Value is DBNull))
                    {
                        var loopTo = (short)(cmbDescriptionFR.Items.Count - 1);
                        for (X = 0; X <= loopTo; X++)
                        {
                            if (cmbDescriptionFR.Items[X].ToString() == rstItem.Fields["DESC_FR"].Value)
                            {
                               cmbDescriptionFR.SelectedIndex = X;
                                break;
                            }
                        }
                    }
                    else if (cmbDescriptionFR.SelectedIndex == -1)
                    {
                       cmbDescriptionFR_SelectedIndexChanged(cmbDescriptionFR, new EventArgs());
                    }
                    else
                    {
                       cmbDescriptionFR.SelectedIndex = -1;
                    }
                    if (!(rstItem.Fields["COMMENTAIRE"].Value is DBNull))
                    {
                       txtComment.Text = Strings.Trim(Conversions.ToString(rstItem.Fields["COMMENTAIRE"].Value));
                    }
                    else
                    {
                       txtComment.Text = string.Empty;
                    }
                   RemplirListViewFournisseur();
                }
                else
                {
                    Interaction.MsgBox("Impossible de trouver la pièce!", MsgBoxStyle.OkOnly, "Erreur");
                }
                rstItem.Close();
                rstItem = null;
                rstInventaire = new ADODB.Recordset();
                rstInventaire.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + Strings.Replace(txtNoItem.Text, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                if (!rstInventaire.EOF)
                {
                   chkInventaire.CheckState = CheckState.Checked;
                   chkBoite.CheckState = (CheckState)Math.Abs(Conversions.ToShort(rstInventaire.Fields["CommandeParBoite"].Value));
                    if (chkBoite.CheckState == CheckState.Checked)
                    {
                       txtQuantitéBoite.Text = Conversions.ToString(rstInventaire.Fields["QteBoite"].Value);
                    }
                    var loopTo1 = (short)(cmbLocalisation.Items.Count - 1);
                    for (X = 0; X <= loopTo1; X++)
                    {
                        if (cmbLocalisation.Items[X].ToString() == rstInventaire.Fields["Localisation"].Value)
                        {
                           cmbLocalisation.SelectedIndex = X;
                            break;
                        }
                    }
                   txtQuantiteStock.Text = Conversions.ToString(rstInventaire.Fields["QuantitéStock"].Value);
                   chkMinimum.CheckState = (CheckState)Math.Abs(Conversions.ToShort(rstInventaire.Fields["Minimum"].Value));
                   txtQuantiteMinimum.Text = Conversions.ToString(rstInventaire.Fields["QuantitéMinimum"].Value);
                   txtQuantiteCommande.Text = Conversions.ToString(rstInventaire.Fields["Commande"].Value);
                }
                rstInventaire.Close();
                rstInventaire = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "AfficherItem", ex); }
        }
        private void AfficherFRS()
        {
            try
            {
                ADODB.Recordset rstItemFRS;
                short X;
                rstItemFRS = new ADODB.Recordset();
                rstItemFRS.Open(Operators.ConcatenateObject("SELECT * FROM PiecesFRS WHERE NoEnreg = ",lvwfournisseur.FocusedItem.Tag), odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                for (X = 0; X <= (short)(cmbfrs.Items.Count - 1); X++)
                {
                    if ((cmbfrs.Items[X].ToString() ?? "") == (lvwfournisseur.FocusedItem.Text ?? ""))
                    {
                       cmbfrs.SelectedIndex = X;
                        break;
                    }
                }
                if (!(rstItemFRS.Fields["PERS_RESS"].Value is DBNull))
                {
                    for (X = 0; X <= (short)(cmbPersRess.Items.Count - 1); X++)
                    {
                        if (cmbPersRess.Items[X].ToString() == rstItemFRS.Fields["PERS_RESS"].Value)
                        {
                           cmbPersRess.SelectedIndex = X;
                            break;
                        }
                    }
                }
                else
                {
                   cmbPersRess.SelectedIndex = -1;
                }
                if (!(rstItemFRS.Fields["PRIX_LIST"].Value is DBNull))
                {
                   txtPrixList.Text = Conversions.ToString(rstItemFRS.Fields["PRIX_LIST"].Value);
                }
                else
                {
                   txtPrixList.Text = string.Empty;
                }
                if (!(rstItemFRS.Fields["ESCOMPTE"].Value is DBNull))
                {
                   mskEscompte.Text = Conversions.ToString(rstItemFRS.Fields["ESCOMPTE"].Value);
                }
                else
                {
                   mskEscompte.Text = string.Empty;
                }
                if (!(rstItemFRS.Fields["PRIX_NET"].Value is DBNull))
                {
                   txtPrixNet.Text = Conversions.ToString(rstItemFRS.Fields["PRIX_NET"].Value);
                }
                else
                {
                   txtPrixNet.Text = string.Empty;
                }
                if (!(rstItemFRS.Fields["PRIX_SP"].Value is DBNull))
                {
                   txtPrixSpecial.Text = Conversions.ToString(rstItemFRS.Fields["PRIX_SP"].Value);
                }
                else
                {
                   txtPrixSpecial.Text = string.Empty;
                }
                if (!(rstItemFRS.Fields["VALIDE"].Value is DBNull))
                {
                   mskValide.Text = Conversions.ToString(rstItemFRS.Fields["VALIDE"].Value);
                }
                else
                {
                   mskValide.Text = string.Empty;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstItemFRS.Fields["quoter"].Value, true, false)))
                {
                   chkquoter.CheckState = CheckState.Checked;
                }
                else
                {
                   chkquoter.CheckState = CheckState.Unchecked;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstItemFRS.Fields["DeviseMonétaire"].Value, "CAN", false)))
                {
                   optCAN.Checked = true;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstItemFRS.Fields["DeviseMonétaire"].Value, "USA", false)))
                {
                   optUSA.Checked = true;
                }
                else
                {
                   optSpain.Checked = true;
                }
               AfficherDrapeau();
                rstItemFRS.Close();
                rstItemFRS = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "AfficherFRS", ex); }
        }
        private void cmbNoItem_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
               txtNoItem.Text =cmbNoItem.Text;
               m_sNoItem =txtNoItem.Text;
               m_bBloqueDescription = true;
               AfficherItem();
               m_bBloqueDescription = false;
               RemplirComboFRS();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmbNoItem_Click", ex); }
        }
        private void cmbFabricant_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
               txtFabricant.Text =cmbFabricant.Text;
               RemplirComboDescription();
               m_bBloqueDescription = true;
                if (m_bRempliManuel == true)
                {
                   RemplirComboNoItem();
                   m_bRempliManuel = false;
                }
                else
                {
                   RemplirComboNoItem();
                }
               m_bBloqueDescription = false;
                Cursor.Current = Cursors.Default;
                if (sChoisirTous == ")")
                {
                   RemplirComboCategorie();
                }

                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmbFabricant_Click", ex); }
        }
        private void cmdSuppFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwfournisseur.Items.Count > 0)
                {
                   SupprimerFournisseur();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdSuppFrs_Click", ex); }
        }
        private void FrCatalogueMec_Load(object eventSender, EventArgs eventArgs)
        {
            try
            {
               ActiverBoutonsGroupe();
               m_bBloqueDescription = true;
               m_collPieceDescFR = new List<String>();
               BarrerChamps_piece(true);
               MontrerControles(enumModeCatalogueMec.MODE_INACTIF);
               RemplirComboLocalisation();
               RemplirComboCategorie();
               m_bBloqueDescription = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "Form_Load", ex); }
        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
               CmdAdd.Enabled = g_bModificationCatalogueMec;
               CmdSupp.Enabled = g_bModificationCatalogueMec;
               CmdModif.Enabled = g_bModificationCatalogueMec;
               cmdAddFrs.Enabled = g_bModificationCatalogueMec;
               cmdSuppFrs.Enabled = g_bModificationCatalogueMec;
               cmdModifFrs.Enabled = g_bModificationCatalogueMec;
               cmdDemande.Enabled = g_bModificationCatalogueMec;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "ActiverBoutonsGroupe", ex); }
        }
        public void RemplirComboFabricant()
        {

            ADODB.Recordset rstFabricant;
            string sCategorie;
            short X;
            sCategorie = Strings.Replace(cmbCategorie.Text, "'", "''");
            rstFabricant = new ADODB.Recordset();
            rstFabricant.Open("SELECT DISTINCT FABRICANT FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY FABRICANT", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
           cmbFabricant.Items.Clear();
           sChoisirTous = "";
           cmbFabricant.Items.Add("-- CHOISIR TOUS --");
            if (!rstFabricant.EOF)
                rstFabricant.MoveFirst();
            while (!rstFabricant.EOF)
            {
                if (!(rstFabricant.Fields["Fabricant"].Value is DBNull))
                {
                   cmbFabricant.Items.Add(Strings.Trim(Conversions.ToString(rstFabricant.Fields["FABRICANT"].Value)));
                    if (string.IsNullOrEmpty(sChoisirTous))
                    {
                       sChoisirTous = " AND (FABRICANT = '" + Strings.Trim(Conversions.ToString(rstFabricant.Fields["FABRICANT"].Value)) + "'";
                    }
                    else
                    {
                       sChoisirTous =sChoisirTous + " OR FABRICANT = '" + Strings.Trim(Conversions.ToString(rstFabricant.Fields["FABRICANT"].Value)) + "'";
                    }
                }
                rstFabricant.MoveNext();
            }
           sChoisirTous =sChoisirTous + ")";
            rstFabricant.Close();
            rstFabricant = null;
            if (cmbFabricant.Items.Count > 0)
            {
                if (!string.IsNullOrEmpty(m_sSelectFabricant))
                {
                    var loopTo = (short)(cmbFabricant.Items.Count - 1);
                    for (X = 0; X <= loopTo; X++)
                    {
                        if ((cmbFabricant.Items[X].ToString() ?? "") == (Strings.UCase(m_sSelectFabricant) ?? ""))
                        {
                           cmbFabricant.SelectedIndex = X;
                           m_sSelectFabricant = "";
                            break;
                        }
                    }
                }
                else
                {
                   cmbFabricant.SelectedIndex = 0;
                }
            }
            else
            {
               cmbNoItem.Items.Clear();
               cmbDescriptionFR.Items.Clear();
            }
            return;
        }
        private void cmdRechercherPiece_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstPiece;
                string sPiece;
                ListViewItem itmPiece;
                short X;
                var sPieceModif = default(string);
                sPiece = Interaction.InputBox("Quelle est la pièce à rechercher?");
                if (!string.IsNullOrEmpty(sPiece))
                {
                    string sLettre = sPiece;
                    for (X = 1; X <= sPiece.Length; X++)
                    {
                        if (sLettre[X] >= 48 & sLettre[X] <= 57 | sLettre[X] >= 65 & sLettre[X] <= 90 | sLettre[X] >= 97 & sLettre[X] <= 122)
                        {
                            sPieceModif += sLettre;
                        }
                    }
                   lvwPieces.Items.Clear();
                    rstPiece = new ADODB.Recordset();
                    rstPiece.Open("SELECT * FROM CatalogueMec WHERE  PIECE_MODIF like '%" + sPieceModif + "% ORDER BY PIECE", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    while (!rstPiece.EOF)
                    {
                        itmPiece =lvwPieces.Items.Add(string.Empty);
                        itmPiece.Text = Conversions.ToString(rstPiece.Fields["PIECE"].Value);
                        if (!(rstPiece.Fields["FABRICANT"].Value is DBNull))
                        {
                            if (itmPiece.SubItems.Count > I_COL_PIECE_FABRICANT)
                            {
                                itmPiece.SubItems[I_COL_PIECE_FABRICANT].Text = Conversions.ToString(rstPiece.Fields["FABRICANT"].Value);
                            }
                            else
                            {
                                itmPiece.SubItems.Insert(I_COL_PIECE_FABRICANT, new ListViewItem.ListViewSubItem(null, Conversions.ToString(rstPiece.Fields["FABRICANT"].Value)));
                            }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_PIECE_FABRICANT)
                        {
                            itmPiece.SubItems[I_COL_PIECE_FABRICANT].Text = string.Empty;
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_PIECE_FABRICANT, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        if (!(rstPiece.Fields["DESC_FR"].Value is DBNull))
                        {
                            if (itmPiece.SubItems.Count > I_COL_PIECE_DESCR_FR)
                            {
                                itmPiece.SubItems[I_COL_PIECE_DESCR_FR].Text = Conversions.ToString(rstPiece.Fields["DESC_FR"].Value);
                            }
                            else
                            {
                                itmPiece.SubItems.Insert(I_COL_PIECE_DESCR_FR, new ListViewItem.ListViewSubItem(null, Conversions.ToString(rstPiece.Fields["DESC_FR"].Value)));
                            }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_PIECE_DESCR_FR)
                        {
                            itmPiece.SubItems[I_COL_PIECE_DESCR_FR].Text = string.Empty;
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_PIECE_DESCR_FR, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }

                        if (!(rstPiece.Fields["DESC_EN"].Value is DBNull))
                        {
                            if (itmPiece.SubItems.Count > I_COL_PIECE_DESCR_EN)
                            {
                                itmPiece.SubItems[I_COL_PIECE_DESCR_EN].Text = Conversions.ToString(rstPiece.Fields["DESC_EN"].Value);
                            }
                            else
                            {
                                itmPiece.SubItems.Insert(I_COL_PIECE_DESCR_EN, new ListViewItem.ListViewSubItem(null, Conversions.ToString(rstPiece.Fields["DESC_EN"].Value)));
                            }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_PIECE_DESCR_EN)
                        {
                            itmPiece.SubItems[I_COL_PIECE_DESCR_EN].Text = string.Empty;
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_PIECE_DESCR_EN, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        itmPiece.Tag = rstPiece.Fields["CATEGORIE"].Value;
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstPiece = null;
                    if (lvwPieces.Items.Count > 0)
                    {
                       lvwPieces.Visible = true;
                       lvwPieces.Focus();
                    }
                    else
                    {
                        Interaction.MsgBox("Aucun enregistrement trouvé!");
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmdRechercherPiece_Click", ex); }
        }
        public void AfficherForm(string sCategorie, string sNomFab, string sNoItem)
        {
            try
            {
                short X;
               BarrerChamps_piece(true);
               MontrerControles(enumModeCatalogueMec.MODE_INACTIF);
               RemplirComboCategorie();
                if (!string.IsNullOrEmpty(sCategorie))
                {
                    for (X = 0; X <= (short)(cmbCategorie.Items.Count - 1); X++)
                    {
                        if ((cmbCategorie.Items[X].ToString() ?? "") == (sCategorie ?? ""))
                        {
                           cmbCategorie.SelectedIndex = X;
                            break;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(sNomFab))
                {
                    for (X = 0; X <= (short)(cmbFabricant.Items.Count - 1); X++)
                    {
                        if ((cmbFabricant.Items[X].ToString() ?? "") == (sNomFab ?? ""))
                        {
                           cmbFabricant.SelectedIndex = X;
                            break;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(sNoItem))
                {
                    for (X = 0; X <= (short)(cmbNoItem.Items.Count - 1); X++)
                    {
                        if ((cmbNoItem.Items[X].ToString() ?? "") == (sNoItem ?? ""))
                        {
                           cmbNoItem.SelectedIndex = X;
                            break;
                        }
                    }
                }
               Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "AfficherForm", ex); }
        }
        public void RemplirComboNoItem()
        {
            ADODB.Recordset rstNoItem;
            string sCategorie;
            short X;
            string sFabricant;
            sCategorie = Strings.Replace(cmbCategorie.Text, "'", "''");
            sFabricant = Strings.Replace(cmbFabricant.Text, "'", "''");
            rstNoItem = new ADODB.Recordset();
            if (sFabricant == "-- CHOISIR TOUS --")
            {
                if (cmbCategorie.Text == "Équipements et outillages - Sécurité/nettoyage" |cmbCategorie.Text == "Quincaillerie - Boulons Hex. (Bolts) 1/4-20" |cmbCategorie.Text == "Quincaillerie - Rondelle plate (Washer)" |sChoisirTous == ")")
                {
                    rstNoItem.Open("SELECT PIECE FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstNoItem.Open("SELECT PIECE FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "'" +sChoisirTous + " ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                }
            }
            else
            {
                rstNoItem.Open("SELECT PIECE FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "' AND FABRICANT = '" + sFabricant + "' ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            }
           cmbNoItem.Items.Clear();
            while (!rstNoItem.EOF)
            {
                if (!(rstNoItem.Fields["PIECE"].Value is DBNull))
                {
                   cmbNoItem.Items.Add(Strings.Trim(Conversions.ToString(rstNoItem.Fields["PIECE"].Value)));
                }
                rstNoItem.MoveNext();
            }
            rstNoItem.Close();
            rstNoItem = null;
            if (cmbNoItem.Items.Count > 0)
            {
                if (!string.IsNullOrEmpty(m_sSelectNoItem))
                {
                    for (X = 0; X <= (short)(cmbNoItem.Items.Count - 1); X++)
                    {
                        if ((cmbNoItem.Items[X].ToString() ?? "") == (m_sSelectNoItem ?? ""))
                        {
                           cmbNoItem.SelectedIndex = X;
                           m_sSelectNoItem = "";
                            break;
                        }
                    }
                }
                else
                {
                   cmbNoItem.SelectedIndex = 0;
                }
            }
            return;
        }
        private void CalculerPrixReel(string sNoItem)
        {
            try
            {
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstConfig;
                string sPrixCalcul;
                string sTauxUSA;
                string sTauxSPA;
                rstConfig = new ADODB.Recordset();
                rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly);
                sTauxUSA = Conversions.ToString(rstConfig.Fields["TauxAmericain"].Value);
                sTauxSPA = Conversions.ToString(rstConfig.Fields["TauxEspagnol"].Value);
                rstConfig.Close();
                rstConfig = null;
                rstPieceFRS = new ADODB.Recordset();
                rstPieceFRS.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                rstPieceFRS.Open("SELECT PrixReel, PRIX_NET, PRIX_SP, DeviseMonétaire FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(sNoItem, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                while (!rstPieceFRS.EOF)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstPieceFRS.Fields["PRIX_NET"].Value, string.Empty, false)))
                    {
                        sPrixCalcul = Conversions.ToString(rstPieceFRS.Fields["PRIX_NET"].Value).Replace(".", ",");
                    }
                    else
                    {
                        sPrixCalcul = Conversions.ToString(rstPieceFRS.Fields["PRIX_SP"].Value).Replace(".", ",");
                    }
                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "USA")
                    {
                        rstPieceFRS.Fields["PrixReel"].Value = Conversion_Renamed(Math.Round(double.Parse(sPrixCalcul) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_DECIMAL, 4);
                    }
                    else if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "SPA")
                    {
                        rstPieceFRS.Fields["PrixReel"].Value = Conversion_Renamed(Math.Round(double.Parse(sPrixCalcul) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_DECIMAL, 4);
                    }
                    else
                    {
                        rstPieceFRS.Fields["PrixReel"].Value = Conversion_Renamed(sPrixCalcul, EnumConvert.MODE_DECIMAL, 4);
                    }
                    rstPieceFRS.Update();
                    rstPieceFRS.MoveNext();
                }
                rstPieceFRS.Close();
                rstPieceFRS = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "CalculerPrixReel", ex); }
        }
        public void RemplirListViewFournisseur()
        {
            /*       try
                   {
                       ADODB.Recordset rstPieceFRS;
                       ADODB.Recordset rstContact;
                       short X;
                       ListViewItem itmFRS;
                       Color lCouleur;
                      lvwfournisseur.Items.Clear();
                       lvwfournisseur.Visible = true;
                      CalculerPrixReel(txtNoItem.Text);
                       rstPieceFRS = new ADODB.Recordset();
                       rstPieceFRS.Open("SELECT PiecesFRS.*, FOURNISSEUR.NomFournisseur FROM PiecesFRS INNER JOIN Fournisseur ON PiecesFRS.IDFRS = Fournisseur.IDFRS WHERE PIECE = '" + Strings.Replace(cmbNoItem.Text, "'", "''") + "' AND Type = 'M' ORDER BY PrixReel", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                       rstContact = new ADODB.Recordset();
                       while (!rstPieceFRS.EOF)
                       {
                           if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPieceFRS.Fields["DeviseMonétaire"].Value, "CAN", false)))
                           {
                               lCouleur = (COLOR_ROUGE);
                           }
                           else
                           {
                               lCouleur = (COLOR_BLEU);
                           }
                           itmFRS =lvwfournisseur.Items.Add(string.Empty);
                           itmFRS.Text = Conversions.ToString(rstPieceFRS.Fields["NomFournisseur"].Value);
                           itmFRS.ForeColor = (lCouleur);
                           itmFRS.Tag = rstPieceFRS.Fields["NoEnreg"].Value;
                           if (!string.IsNullOrEmpty($"{rstPieceFRS.Fields["PERS_RESS"].Value}".Trim()))
                           {
                               rstContact.Open("SELECT NomContact FROM Contact WHERE IDContact = " + rstPieceFRS.Fields["PERS_RESS"].Value, odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                               if (!rstContact.EOF)
                               {
                                   if (itmFRS.SubItems.Count > I_COL_FRS_PERS_RESS)
                                   {
                                       itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text = Conversions.ToString(rstContact.Fields["NomContact"].Value);
                                   }
                                   else
                                   {
                                       itmFRS.SubItems.Insert(I_COL_FRS_PERS_RESS, new ListViewItem.ListViewSubItem(null, (rstContact.Fields["NomContact"].Value)));
                                   }
                               }
                               else if (itmFRS.SubItems.Count > I_COL_FRS_PERS_RESS)
                               {
                                   itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text = string.Empty;
                               }
                               else
                               {
                                   itmFRS.SubItems.Insert(I_COL_FRS_PERS_RESS, new ListViewItem.ListViewSubItem(null, string.Empty));
                               }
                               itmFRS.SubItems[I_COL_FRS_PERS_RESS].ForeColor = (lCouleur);
                               rstContact.Close();
                           }
                           if (!(rstPieceFRS.Fields["Date"].Value is DBNull))
                           {
                               if (itmFRS.SubItems.Count > I_COL_FRS_DATE)
                               {
                                   itmFRS.SubItems[I_COL_FRS_DATE].Text = (rstPieceFRS.Fields["Date"].Value);
                               }
                               else
                               {
                                   itmFRS.SubItems.Insert(I_COL_FRS_DATE, new ListViewItem.ListViewSubItem(null,$"{rstPieceFRS.Fields["Date"].Value}"));
                               }
                           }
                           else if (itmFRS.SubItems.Count > I_COL_FRS_DATE)
                           {
                               itmFRS.SubItems[I_COL_FRS_DATE].Text = string.Empty;
                           }
                           else
                           {
                               itmFRS.SubItems.Insert(I_COL_FRS_DATE, new ListViewItem.ListViewSubItem(null, string.Empty));
                           }
                           itmFRS.SubItems[I_COL_FRS_DATE].ForeColor = (lCouleur);
                           if (!(rstPieceFRS.Fields["Entrer_par"].Value is DBNull))
                           {
                               if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR)
                               {
                                   itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = (rstPieceFRS.Fields["entrer_par"].Value);
                               }
                               else
                               {
                                   itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, $"{rstPieceFRS.Fields["entrer_par"].Value}"));
                               }
                           }
                           else if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR)
                           {
                               itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = string.Empty;
                           }
                           else
                           {
                               itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, string.Empty));
                           }
                           itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].ForeColor = (lCouleur);
                           if (!(rstPieceFRS.Fields["Valide"].Value is DBNull))
                           {
                               if (itmFRS.SubItems.Count > I_COL_FRS_VALIDE)
                               {
                                   itmFRS.SubItems[I_COL_FRS_VALIDE].Text = (rstPieceFRS.Fields["Valide"].Value);
                               }
                               else
                               {
                                   itmFRS.SubItems.Insert(I_COL_FRS_VALIDE, new ListViewItem.ListViewSubItem(null, $"{rstPieceFRS.Fields["Valide"].Value}"));
                               }
                               itmFRS.SubItems[I_COL_FRS_VALIDE].ForeColor = (lCouleur);
                           }
                           else if (itmFRS.SubItems.Count > I_COL_FRS_VALIDE)
                           {
                               itmFRS.SubItems[I_COL_FRS_VALIDE].Text = string.Empty;
                           }
                           else
                           {
                               itmFRS.SubItems.Insert(I_COL_FRS_VALIDE, new ListViewItem.ListViewSubItem(null, string.Empty));
                           }
                           if ((!(rstPieceFRS.Fields["PRIX_LIST"].Value is DBNull) || (rstPieceFRS.Fields["PRIX_LIST"].Value!=string.Empty)))
                           {
                               if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                               {
                                   itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = Conversion_Renamed(rstPieceFRS.Fields["prix_list"].Value, EnumConvert.MODE_ARGENT, 4);
                               }
                               else
                               {
                                   itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, Conversion_Renamed((rstPieceFRS.Fields["prix_list"].Value), EnumConvert.MODE_ARGENT, 4)));
                               }
                               itmFRS.SubItems[I_COL_FRS_PRIX_LIST].ForeColor = (lCouleur);
                           }
                           else if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                           {
                               itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = string.Empty;
                           }
                           else
                           {
                               itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, string.Empty));
                           }
                           if (!string.IsNullOrEmpty(Strings.Trim(Conversions.ToString(rstPieceFRS.Fields["ESCOMPTE"].Value))))
                           {
                               if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE)
                               {
                                   itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = Conversion_Renamed(Strings.Replace(Conversions.ToString(rstPieceFRS.Fields["ESCOMPTE"].Value), "_", string.Empty), EnumConvert.MODE_POURCENT);
                               }
                               else
                               {
                                   itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Strings.Replace(Conversions.ToString(rstPieceFRS.Fields["ESCOMPTE"].Value), "_", string.Empty), EnumConvert.MODE_POURCENT)));
                               }
                           }
                           else if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE)
                           {
                               itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = string.Empty;
                           }
                           else
                           {
                               itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem(null, string.Empty));
                           }
                           itmFRS.SubItems[I_COL_FRS_ESCOMPTE].ForeColor = (lCouleur);
                           if (rstPieceFRS.Fields["PRIX_NET"].Value != string.Empty)
                           {
                               if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET)
                               {
                                   itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = Conversion_Renamed(Math.Round(double.Parse(Strings.Replace(Conversions.ToString(rstPieceFRS.Fields["PRIX_NET"].Value), ".", ",")), 4).ToString(), EnumConvert.MODE_ARGENT, 4);
                               }
                               else
                               {
                                   itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Math.Round(double.Parse(Strings.Replace(Conversions.ToString(rstPieceFRS.Fields["PRIX_NET"].Value), ".", ",")), 4).ToString(), EnumConvert.MODE_ARGENT, 4)));
                               }
                           }
                           else if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET)
                           {
                               itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = string.Empty;
                           }
                           else
                           {
                               itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem(null, string.Empty));
                           }
                           itmFRS.SubItems[I_COL_FRS_PRIX_NET].ForeColor = (lCouleur);
                           if (rstPieceFRS.Fields["PRIX_SP"].Value != string.Empty)
                           {
                               if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP)
                               {
                                   itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = Conversion_Renamed(Conversions.ToString(Math.Round(rstPieceFRS.Fields["PRIX_SP"].Value, 4)), EnumConvert.MODE_ARGENT, 4);
                               }
                               else
                               {
                                   itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem(null, Conversion_Renamed(Conversions.ToString(Math.Round(rstPieceFRS.Fields["PRIX_SP"].Value, 4)), EnumConvert.MODE_ARGENT, 4)));
                               }
                           }
                           else if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP)
                           {
                               itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = string.Empty;
                           }
                           else
                           {
                               itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem(null, string.Empty));
                           }
                           itmFRS.SubItems[I_COL_FRS_PRIX_SP].ForeColor = (lCouleur);
                           if ((bool)rstPieceFRS.Fields["QUOTER"].Value == true)
                           {
                               if (itmFRS.SubItems.Count > I_COL_FRS_QUOTER)
                               {
                                   itmFRS.SubItems[I_COL_FRS_QUOTER].Text = "Oui";
                               }
                               else
                               {
                                   itmFRS.SubItems.Insert(I_COL_FRS_QUOTER, new ListViewItem.ListViewSubItem(null, "Oui"));
                               }
                           }
                           else if (itmFRS.SubItems.Count > I_COL_FRS_QUOTER)
                           {
                               itmFRS.SubItems[I_COL_FRS_QUOTER].Text = "Non";
                           }
                           else
                           {
                               itmFRS.SubItems.Insert(I_COL_FRS_QUOTER, new ListViewItem.ListViewSubItem(null, "Non"));
                           }
                           itmFRS.SubItems[I_COL_FRS_QUOTER].ForeColor = (lCouleur);
                           rstPieceFRS.MoveNext();
                       }
                      lvwfournisseur.Refresh();
                       rstPieceFRS.Close();
                       rstPieceFRS = null;
                       rstContact = null;
                       return;
                   }
                   catch (ExceptiON ex) { AfficherErreur("CatalogueMec", "RemplirListViewFournisseur", ex); }*/
        }
        private void lvwDescription_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwDescription.Visible == true)
                {
                   lvwDescription.Visible = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwDescription_LostFocus", ex); }
        }
        private void lvwRechercheJob_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwRechercheJob.Visible == true)
                {
                   lvwRechercheJob.Visible = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwRechercheJob_LostFocus", ex); }
        }
        private void lvwRechercheAchat_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwRechercheAchat.Visible == true)
                {
                   lvwRechercheAchat.Visible = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwRechercheAchat_LostFocus", ex); }
        }
        private void lvwFabricant_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwFabricant.Visible == true)
                {
                   lvwFabricant.Visible = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwFabricant_LostFocus", ex); }
        }
        private void lvwFournisseur_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwfournisseur.Items.Count > 0)
                {
                   ModifierFournisseur();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwFournisseur_DblClick", ex); }
        }
        private void lvwfournisseur_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            short KeyCode = (short)eventArgs.KeyCode;
            short Shift = (short)((int)eventArgs.KeyData / 0x10000);
            try
            {
                if (lvwfournisseur.Items.Count > 0)
                {
                    if (KeyCode == (int)Keys.Delete)
                    {
                       SupprimerFournisseur();
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwfournisseur_KeyDown", ex); }
        }
        private void ModifierFournisseur()
        {
            try
            {
               BarrerChamps_piece(true);
               MontrerControles(enumModeCatalogueMec.MODE_AJOUT_MODIF_FRS);
               m_bAjout = false;
               AfficherFRS();
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "ModifierFournisseur", ex); }
        }
        private void SupprimerFournisseur()
        {
            try
            {
                if (Interaction.MsgBox("Voulez-vous vraiment effacer le fournisseur " +lvwfournisseur.FocusedItem.Text + "?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
                {
                    odbc.Execute("DELETE FROM PiecesFRS WHERE NoEnreg = " + lvwfournisseur.FocusedItem.Tag, out sortie, -1);
                   RemplirListViewFournisseur();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "SupprimerFournisseur", ex); }
        }
        private void lvwPieces_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ListViewItem itmPieces;
                short X;
                Cursor.Current = Cursors.WaitCursor;
                itmPieces =lvwPieces.FocusedItem;
               m_sSelectCategorie = Conversions.ToString(itmPieces.Tag).Trim();
               m_sSelectFabricant = itmPieces.SubItems[I_COL_PIECE_FABRICANT].Text.Trim();
               m_sSelectNoItem = itmPieces.Text.Trim();
               RemplirComboCategorie();
               lvwPieces.Visible = false;
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwPieces_DblClick", ex); }
        }
        private void lvwPieces_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwPieces.Visible == true)
                {
                   lvwPieces.Visible = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "lvwPieces_LostFocus", ex); }
        }
        private void mskEscompte_GotFocus()
        {
            try
            {
                if (mskEscompte.Enabled == true)
                {
                   mskEscompte.Mask = "0,####";
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "mskEscompte_GotFocus", ex); }
        }
        private void mskEscompte_LostFocus()
        {
            try
            {
               mskEscompte.Mask = string.Empty;
                if (mskEscompte.Text == "0,____")
                {
                   mskEscompte.Text = string.Empty;
                }
               CalculerPrixNet();
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "mskEscompte_LostFocus", ex); }
        }
        private void optCAN_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(((dynamic)eventSender).Checked))
            {
               AfficherDrapeau();
                return;
            }
        }
        private void AfficherDrapeau()
        {
            try
            {
                if (optCAN.Checked == true)
                {
                   imgCanada.Visible = true;
                   imgEU.Visible = false;
                   imgSpain.Visible = false;
                   lblDevise1.Visible = false;
                   txtTauxChange.Visible = false;
                   lblDevise2.Visible = false;
                }
                else
                {
                    if (optUSA.Checked == true)
                    {
                       imgEU.Visible = true;
                       imgCanada.Visible = false;
                       imgSpain.Visible = false;
                    }
                    else
                    {
                       imgSpain.Visible = true;
                       imgCanada.Visible = false;
                       imgEU.Visible = false;
                    }
                   AfficherTauxChange();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "AfficherDrapeau", ex); }
        }
        private void AfficherTauxChange()
        {
            try
            {
                ADODB.Recordset rstConfig;
                rstConfig = new ADODB.Recordset();
                rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                if (optUSA.Checked == true)
                {
                   lblDevise2.Text = "$ USA";
                   txtTauxChange.Text = Conversions.ToString(rstConfig.Fields["TauxAmericain"].Value);
                }
                else
                {
                   lblDevise2.Text = "$ SPA";
                   txtTauxChange.Text = Conversions.ToString(rstConfig.Fields["TauxEspagnol"].Value);
                }
               lblDevise1.Visible = true;
               txtTauxChange.Visible = true;
               lblDevise2.Visible = true;
                rstConfig.Close();
                rstConfig = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "AfficherTauxChange", ex); }
        }
        private void optSpain_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (((dynamic)eventSender).Checked)
            {
               AfficherDrapeau();
                return;
            }
        }
        private void optUSA_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(((dynamic)eventSender).Checked))
            {
               AfficherDrapeau();
                return;
            }
        }
        private void txtNoItem_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == (int)EnumModeCatalogueElec.MODE_AJOUT_MODIF_ELEC)
                {
                   txtNoItemGRB.Text += "GRB";
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtNoItem_Change", ex); }
        }
        private void txtPrixList_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPrixList.Text))
                {
                   txtPrixList.Text.Replace(".", ",");
                    if (!IsNumeric(txtPrixList.Text))
                    {
                        Interaction.MsgBox("Valeur non numérique!", MsgBoxStyle.OkOnly, "Erreur");
                       txtPrixList.Text = string.Empty;
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtPrixList_LostFocus", ex); }
        }
        private void txtPrixNet_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (txtPrixNet.Text.Length > 0)
                {
                   txtPrixSpecial.Text = string.Empty;
                   txtPrixSpecial.Enabled = false;
                }
                else
                {
                   txtPrixSpecial.Enabled = true;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtPrixNet_Change", ex); }
        }
        private void txtPrixSpecial_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (txtPrixSpecial.Text.Length > 0)
                {
                   mskEscompte.Text = string.Empty;
                   txtPrixNet.Text = string.Empty;
                   mskEscompte.Enabled = false;
                   txtPrixNet.Enabled = false;
                }
                else
                {
                   mskEscompte.Enabled = true;
                   txtPrixNet.Enabled = true;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtPrixSpecial_Change", ex); }
        }
        private void txtPrixNet_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
               CalculerPrixNet();
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtPrixNet_GotFocus", ex); }
        }
        private void CalculerPrixNet()
        {
            try
            {
                double dblEscompte;
                double dblPrix;
                string sPrix;
                if (txtPrixNet.ReadOnly == false)
                {
                   mskEscompte.Text = Strings.Replace(mskEscompte.Text, "_", string.Empty);
                   mskEscompte.Text = Strings.Replace(mskEscompte.Text, ".", ",");
                    if (!string.IsNullOrEmpty(mskEscompte.Text))
                    {
                        dblEscompte = double.Parse(mskEscompte.Text);
                    }
                    else
                    {
                        dblEscompte = 0d;
                    }
                    if (!string.IsNullOrEmpty(txtPrixList.Text))
                    {
                        sPrix = Strings.Replace(txtPrixList.Text, ".", ",");
                        if (IsNumeric(sPrix))
                        {
                            dblPrix = double.Parse(sPrix);
                        }
                        else
                        {
                            dblPrix = 0d;
                        }
                    }
                    else
                    {
                        dblPrix = 0d;
                    }
                   txtPrixNet.Text = Math.Round(dblPrix * (1d - dblEscompte), 4).ToString();
                   txtPrixNet.Text = Strings.Replace(txtPrixNet.Text, ".", ",");
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "CalculerPrixNet", ex); }
        }
        private void txtPrixNet_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (txtPrixNet.Text == "$0,00")
                {
                   txtPrixNet.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtPrixNet_LostFocus", ex); }
        }
        private void mskValide_GotFocus()
        {
            try
            {
                if (mskValide.Text.Length == 10)
                {
                   mskValide.Text = Droite(mskValide.Text, 8);
                }
               mskValide.Mask = "##-##-##";
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "mskValide_GotFocus", ex); }
        }
        private void mskValide_LostFocus()
        {
            try
            {
               mskValide.Mask = string.Empty;

                if (mskValide.Text == "__-__-__")
                {

                   mskValide.Text = string.Empty;
                }

                else if (mskValide.Text.Length == 8)
                {
                    if (Information.IsDate(mskValide.Text))
                    {
                       mskValide.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateAndTime.DateSerial(Conversions.ToInteger(Strings.Left(mskValide.Text, 2)), Conversions.ToInteger(Strings.Mid(mskValide.Text, 4, 2)), Conversions.ToInteger(Droite(mskValide.Text, 2)))) + Strings.Mid(mskValide.Text, 3, 8);
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "mskValide_LostFocus", ex); }
        }
        private void cmbCategorie_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
               txtCategorie.Text =cmbCategorie.Text;
                Cursor.Current = Cursors.WaitCursor;
               m_bBloqueDescription = true;
               m_bRempliManuel = true;
               cmbFabricant.Items.Clear();
               cmbNoItem.Items.Clear();
               ViderChamps_piece();
               RemplirComboFabricant();
               m_bBloqueDescription = false;
                Cursor.Current = Cursors.Default;
                return;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "cmbCategorie_Click", ex); }
        }
        public void RemplirComboCategorie()
        {
            try
            {
                ADODB.Recordset rstCatalogueMec;
                short X;
               cmbCategorie.Items.Clear();
                rstCatalogueMec = new ADODB.Recordset();
                rstCatalogueMec.Open("SELECT DISTINCT CATEGORIE FROM CatalogueMec ORDER BY CATEGORIE", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                while (!rstCatalogueMec.EOF)
                {
                    if (!(rstCatalogueMec.Fields["CATEGORIE"].Value is DBNull))
                    {
                       cmbCategorie.Items.Add(Strings.Trim(Conversions.ToString(rstCatalogueMec.Fields["CATEGORIE"].Value)));
                    }
                    rstCatalogueMec.MoveNext();
                }
                rstCatalogueMec.Close();
                rstCatalogueMec = null;
                // Si le combo n'est pas vide, on sélectionne le premier
                if (cmbCategorie.Items.Count > 0)
                {
                    if (!string.IsNullOrEmpty(m_sSelectCategorie))
                    {
                        var loopTo = (short)(cmbCategorie.Items.Count - 1);
                        for (X = 0; X <= loopTo; X++)
                        {
                            if ((cmbCategorie.Items[X].ToString() ?? "") == (m_sSelectCategorie ?? ""))
                            {
                               cmbCategorie.SelectedIndex = X;
                               m_sSelectCategorie = "";
                                break;
                            }
                        }
                    }
                    else
                    {
                       cmbCategorie.SelectedIndex = 0;
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "RemplirComboCategorie", ex); }
        }
        private void RemplirComboDescription()
        {
            ADODB.Recordset rstCatMec;
            string sPiece;
            string sCategorie;
            string sFabricant;
            if (m_collPieceDescFR.Count > 0)m_collPieceDescFR.Clear();
           cmbDescriptionFR.Items.Clear();
            sCategorie = Strings.Replace(cmbCategorie.Text, "'", "''");
            sFabricant = Strings.Replace(cmbFabricant.Text, "'", "''");
            rstCatMec = new ADODB.Recordset();
            if (sFabricant == "-- CHOISIR TOUS --")
            {
                if (cmbCategorie.Text == "Équipements et outillages - Sécurité/nettoyage" |cmbCategorie.Text == "Quincaillerie - Boulons Hex. (Bolts) 1/4-20" |cmbCategorie.Text == "Quincaillerie - Rondelle plate (Washer)" |sChoisirTous == ")")
                {
                    rstCatMec.Open("SELECT * FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstCatMec.Open("SELECT * FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "'" +sChoisirTous + " ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                }
            }
            else
            {
                rstCatMec.Open("SELECT * FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "' AND FABRICANT = '" + sFabricant + "' ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            }

            while (!rstCatMec.EOF)
            {
                if (!(rstCatMec.Fields["DESC_FR"].Value is DBNull))
                {
                    if (rstCatMec.Fields["DESC_FR"].Value != string.Empty)
                    {
                       cmbDescriptionFR.Items.Add(rstCatMec.Fields["DESC_FR"].Value);
                        sPiece = Conversions.ToString(rstCatMec.Fields["PIECE"].Value);
                       m_collPieceDescFR.Add(sPiece);
                    }
                }
                rstCatMec.MoveNext();
            }
            rstCatMec.Close();
            rstCatMec = null;
            return;
        }
        private void RemplirComboFRS()
        {
            try
            {
                Program.fournisseurs.Clear();
                ADODB.Recordset rstPieceFRS;
               cmbfrs.Items.Clear();
                rstPieceFRS = new ADODB.Recordset();
                rstPieceFRS.Open("SELECT * FROM Fournisseur WHERE Supprimé= 0   ORDER BY NomFournisseur", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                while (!rstPieceFRS.EOF)
                {
                    Program.fournisseurs.Add(new ListItem($"{rstPieceFRS.Fields["NomFournisseur"].Value}", $"{rstPieceFRS.Fields["IDFRS"].Value}"));
                   cmbfrs.Items.Add($"{ rstPieceFRS.Fields["IDFRS"].Value}-{rstPieceFRS.Fields["NomFournisseur"].Value}");
                    rstPieceFRS.MoveNext();
                }
                rstPieceFRS.Close();
                rstPieceFRS = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "RemplirComboFRS", ex); }
        }
        private void txtPrixSpecial_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
               txtPrixSpecial.Text = Strings.Replace(txtPrixSpecial.Text, ".", ",");
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtPrixSpecial_LostFocus", ex); }
        }
        private void RemplirComboLocalisation()
        {
            try
            {
                ADODB.Recordset rstLocalisation;
                rstLocalisation = new ADODB.Recordset();
                rstLocalisation.Open("SELECT DISTINCT Localisation FROM InventaireMec", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
               cmbLocalisation.Items.Clear();
                while (!rstLocalisation.EOF)
                {
                    if (!(rstLocalisation.Fields["Localisation"].Value is DBNull))
                    {
                        if (!string.IsNullOrEmpty(Conversions.ToString(rstLocalisation.Fields["Localisation"].Value).Trim()))
                        {
                           cmbLocalisation.Items.Add(rstLocalisation.Fields["Localisation"].Value);
                        }
                    }
                    rstLocalisation.MoveNext();
                }
                rstLocalisation.Close();
                rstLocalisation = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "RemplirComboLocalisation", ex); }
        }
        private void txtQuantitéBoite_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
               txtQuantitéBoite.Text = Strings.Replace(txtQuantitéBoite.Text, ".", ",");
                if (!IsNumeric(txtQuantitéBoite.Text) |txtQuantitéBoite.Text == "0")
                {
                   txtQuantitéBoite.Text = "1";
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtQuantitéBoite_LostFocus", ex); }
        }
        private void txtQuantiteCommande_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
               txtQuantiteCommande.Text =txtQuantiteCommande.Text.Replace(".", ",");
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtQuantiteCommande_LostFocus", ex); }
        }
        private void txtQuantiteMinimum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
               txtQuantiteMinimum.Text =txtQuantiteMinimum.Text.Replace(".", ",");
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtQuantiteMinimum_LostFocus", ex); }
        }
        private void txtQuantiteStock_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
               txtQuantiteStock.Text =txtQuantiteStock.Text.Replace(".", ",");
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtQuantiteStock_LostFocus", ex); }
        }
    }
}