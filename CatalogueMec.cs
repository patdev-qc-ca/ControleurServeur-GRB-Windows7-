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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;
using ComboBox = System.Windows.Forms.ComboBox;

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
        internal ToolTip ToolTip1;
        internal ColumnHeader _lvwCategorie_ColumnHeader_1;
        internal ListView lvwCategorie;
        internal Button cmdRechercheCategorie;
        internal ColumnHeader _lvwRechercheAchat_ColumnHeader_1;
        internal ColumnHeader _lvwRechercheAchat_ColumnHeader_2;
        internal ListView lvwRechercheAchat;
        internal ColumnHeader _lvwRechercheJob_ColumnHeader_1;
        internal ColumnHeader _lvwRechercheJob_ColumnHeader_2;
        internal ListView lvwRechercheJob;
        internal Button cmdRechercheJob;
        internal Button cmdCopier;
        internal Button cmdTotal;
        internal Button cmdRechercheInventaire;
        internal ColumnHeader _lvwFabricant_ColumnHeader_1;
        internal ColumnHeader _lvwFabricant_ColumnHeader_2;
        internal ColumnHeader _lvwFabricant_ColumnHeader_3;
        internal ColumnHeader _lvwFabricant_ColumnHeader_4;
        internal ListView lvwFabricant;
        internal ColumnHeader _lvwPieces_ColumnHeader_1;
        internal ColumnHeader _lvwPieces_ColumnHeader_2;
        internal ColumnHeader _lvwPieces_ColumnHeader_3;
        internal ColumnHeader _lvwPieces_ColumnHeader_4;
        internal ListView lvwPieces;
        internal Button cmdChangerCategorie;
        internal Button cmdDemande;
        internal ColumnHeader _lvwDescription_ColumnHeader_1;
        internal ColumnHeader _lvwDescription_ColumnHeader_2;
        internal ColumnHeader _lvwDescription_ColumnHeader_3;
        internal ColumnHeader _lvwDescription_ColumnHeader_4;
        internal ListView lvwDescription;
        internal Button cmdRechercheDescrFR;
        internal TextBox txtTauxChange;
        internal Button cmdAddFrs;
        internal Button cmdSuppFrs;
        internal Button cmdModifFrs;
        internal CheckBox chkquoter;
        internal RadioButton optUSA;
        internal RadioButton optCAN;
        internal TextBox txtPrixList;
        internal TextBox txtPrixNet;
        internal TextBox txtPrixSpecial;
        internal MaskedTextBox mskValide;
        internal MaskedTextBox mskEscompte;
        internal Button cmdEnrFrs;
        internal Button cmdAnnulFrs;
        internal ComboBox cmbfrs;
        internal ComboBox cmbPersRess;
        internal RadioButton optSpain;
        internal Label lblDevise1;
        internal Label lblDevise2;
        internal Label _Label1_5;
        internal PictureBox imgCanada;
        internal PictureBox imgEU;
        internal Label _Label1_14;
        internal Label _Label1_16;
        internal Label _Label1_19;
        internal Label _Label1_24;
        internal Label _Label1_20;
        internal Label _Label1_2;
        internal Label _Label1_23;
        internal PictureBox imgSpain;
        internal GroupBox frafournisseur;
        internal ComboBox cmbCategorie;
        internal TextBox txtNoItemGRB;
        internal ComboBox cmbNoItem;
        internal Button CmdModif;
        internal Button CmdFerme;
        internal Button CmdSupp;
        internal Button CmdAdd;
        internal TextBox txtComment;
        internal ComboBox cmbFabricant;
        internal TextBox txtFabricant;
        internal TextBox txtDescriptionEN;
        internal TextBox txtDescriptionFR;
        internal TextBox txtNoItem;
        internal Button CmdAnul;
        internal Button CmdEnr;
        internal TextBox txtCategorie;
        internal Button cmdRechercherPiece;
        internal ComboBox cmbDescriptionFR;
        internal Button cmdRechercherManufact;
        internal CheckBox chkInventaire;
        internal TextBox txtQuantiteCommande;
        internal CheckBox chkMinimum;
        internal TextBox txtQuantiteStock;
        internal TextBox txtQuantiteMinimum;
        internal TextBox txtQuantitéBoite;
        internal CheckBox chkBoite;
        internal Label Label11;
        internal Label Label5;
        internal GroupBox fraQuantité;
        internal ComboBox cmbLocalisation;
        internal TextBox txtLocalisation;
        internal Button cmdRechercheAchat;
        internal Label Label4;
        internal Label Label2;
        internal Label _Label1_25;
        internal Label _Label1_6;
        internal Label _Label1_4;
        internal Label _Label1_3;
        internal Label _Label1_1;
        internal ListView lvwfournisseur;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_1;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_2;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_3;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_4;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_5;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_6;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_7;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_8;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_9;
        internal ColumnHeader _lvwfournisseur_ColumnHeader_10;
        internal Label _Label1_0;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogueMec));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lvwCategorie = new System.Windows.Forms.ListView();
            this._lvwCategorie_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdRechercheCategorie = new System.Windows.Forms.Button();
            this.lvwRechercheAchat = new System.Windows.Forms.ListView();
            this._lvwRechercheAchat_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwRechercheAchat_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwRechercheJob = new System.Windows.Forms.ListView();
            this._lvwRechercheJob_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwRechercheJob_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdRechercheJob = new System.Windows.Forms.Button();
            this.cmdCopier = new System.Windows.Forms.Button();
            this.cmdTotal = new System.Windows.Forms.Button();
            this.cmdRechercheInventaire = new System.Windows.Forms.Button();
            this.lvwFabricant = new System.Windows.Forms.ListView();
            this._lvwFabricant_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwFabricant_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwFabricant_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwFabricant_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwPieces = new System.Windows.Forms.ListView();
            this._lvwPieces_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwPieces_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwPieces_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwPieces_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdChangerCategorie = new System.Windows.Forms.Button();
            this.cmdDemande = new System.Windows.Forms.Button();
            this.lvwDescription = new System.Windows.Forms.ListView();
            this._lvwDescription_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwDescription_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwDescription_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwDescription_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdRechercheDescrFR = new System.Windows.Forms.Button();
            this.frafournisseur = new System.Windows.Forms.GroupBox();
            this.txtTauxChange = new System.Windows.Forms.TextBox();
            this.cmdAddFrs = new System.Windows.Forms.Button();
            this.cmdSuppFrs = new System.Windows.Forms.Button();
            this.cmdModifFrs = new System.Windows.Forms.Button();
            this.chkquoter = new System.Windows.Forms.CheckBox();
            this.optUSA = new System.Windows.Forms.RadioButton();
            this.optCAN = new System.Windows.Forms.RadioButton();
            this.txtPrixList = new System.Windows.Forms.TextBox();
            this.txtPrixNet = new System.Windows.Forms.TextBox();
            this.txtPrixSpecial = new System.Windows.Forms.TextBox();
            this.mskValide = new System.Windows.Forms.MaskedTextBox();
            this.mskEscompte = new System.Windows.Forms.MaskedTextBox();
            this.cmdEnrFrs = new System.Windows.Forms.Button();
            this.cmdAnnulFrs = new System.Windows.Forms.Button();
            this.cmbfrs = new System.Windows.Forms.ComboBox();
            this.cmbPersRess = new System.Windows.Forms.ComboBox();
            this.optSpain = new System.Windows.Forms.RadioButton();
            this.lblDevise1 = new System.Windows.Forms.Label();
            this.lblDevise2 = new System.Windows.Forms.Label();
            this._Label1_5 = new System.Windows.Forms.Label();
            this.imgCanada = new System.Windows.Forms.PictureBox();
            this.imgEU = new System.Windows.Forms.PictureBox();
            this._Label1_14 = new System.Windows.Forms.Label();
            this._Label1_16 = new System.Windows.Forms.Label();
            this._Label1_19 = new System.Windows.Forms.Label();
            this._Label1_24 = new System.Windows.Forms.Label();
            this._Label1_20 = new System.Windows.Forms.Label();
            this._Label1_2 = new System.Windows.Forms.Label();
            this._Label1_23 = new System.Windows.Forms.Label();
            this.imgSpain = new System.Windows.Forms.PictureBox();
            this.lvwfournisseur = new System.Windows.Forms.ListView();
            this._lvwfournisseur_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwfournisseur_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwfournisseur_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwfournisseur_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwfournisseur_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwfournisseur_ColumnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwfournisseur_ColumnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwfournisseur_ColumnHeader_8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwfournisseur_ColumnHeader_9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwfournisseur_ColumnHeader_10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.txtNoItemGRB = new System.Windows.Forms.TextBox();
            this.cmbNoItem = new System.Windows.Forms.ComboBox();
            this.CmdModif = new System.Windows.Forms.Button();
            this.CmdFerme = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbFabricant = new System.Windows.Forms.ComboBox();
            this.txtFabricant = new System.Windows.Forms.TextBox();
            this.txtDescriptionEN = new System.Windows.Forms.TextBox();
            this.txtDescriptionFR = new System.Windows.Forms.TextBox();
            this.txtNoItem = new System.Windows.Forms.TextBox();
            this.CmdAnul = new System.Windows.Forms.Button();
            this.CmdEnr = new System.Windows.Forms.Button();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.cmdRechercherPiece = new System.Windows.Forms.Button();
            this.cmbDescriptionFR = new System.Windows.Forms.ComboBox();
            this.cmdRechercherManufact = new System.Windows.Forms.Button();
            this.chkInventaire = new System.Windows.Forms.CheckBox();
            this.fraQuantité = new System.Windows.Forms.GroupBox();
            this.txtQuantiteCommande = new System.Windows.Forms.TextBox();
            this.chkMinimum = new System.Windows.Forms.CheckBox();
            this.txtQuantiteStock = new System.Windows.Forms.TextBox();
            this.txtQuantiteMinimum = new System.Windows.Forms.TextBox();
            this.txtQuantitéBoite = new System.Windows.Forms.TextBox();
            this.chkBoite = new System.Windows.Forms.CheckBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.cmbLocalisation = new System.Windows.Forms.ComboBox();
            this.txtLocalisation = new System.Windows.Forms.TextBox();
            this.cmdRechercheAchat = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this._Label1_25 = new System.Windows.Forms.Label();
            this._Label1_6 = new System.Windows.Forms.Label();
            this._Label1_4 = new System.Windows.Forms.Label();
            this._Label1_3 = new System.Windows.Forms.Label();
            this._Label1_1 = new System.Windows.Forms.Label();
            this._Label1_0 = new System.Windows.Forms.Label();
            this.frafournisseur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpain)).BeginInit();
            this.fraQuantité.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwCategorie
            // 
            this.lvwCategorie.BackColor = System.Drawing.SystemColors.Window;
            this.lvwCategorie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwCategorie_ColumnHeader_1});
            this.lvwCategorie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwCategorie.FullRowSelect = true;
            this.lvwCategorie.GridLines = true;
            this.lvwCategorie.HideSelection = false;
            this.lvwCategorie.Location = new System.Drawing.Point(121, 63);
            this.lvwCategorie.Name = "lvwCategorie";
            this.lvwCategorie.Size = new System.Drawing.Size(591, 112);
            this.lvwCategorie.TabIndex = 82;
            this.lvwCategorie.UseCompatibleStateImageBehavior = false;
            this.lvwCategorie.View = System.Windows.Forms.View.Details;
            this.lvwCategorie.Visible = false;
            this.lvwCategorie.DoubleClick += new System.EventHandler(this.lvwCategorie_DoubleClick);
            this.lvwCategorie.Leave += new System.EventHandler(this.lvwCategorie_Leave);
            // 
            // _lvwCategorie_ColumnHeader_1
            // 
            this._lvwCategorie_ColumnHeader_1.Text = "Catégorie";
            this._lvwCategorie_ColumnHeader_1.Width = 447;
            // 
            // cmdRechercheCategorie
            // 
            this.cmdRechercheCategorie.BackColor = System.Drawing.Color.Black;
            this.cmdRechercheCategorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRechercheCategorie.BackgroundImage")));
            this.cmdRechercheCategorie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRechercheCategorie.ForeColor = System.Drawing.Color.White;
            this.cmdRechercheCategorie.Location = new System.Drawing.Point(688, 8);
            this.cmdRechercheCategorie.Name = "cmdRechercheCategorie";
            this.cmdRechercheCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercheCategorie.Size = new System.Drawing.Size(25, 25);
            this.cmdRechercheCategorie.TabIndex = 81;
            this.cmdRechercheCategorie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdRechercheCategorie.UseVisualStyleBackColor = true;
            this.cmdRechercheCategorie.Click += new System.EventHandler(this.cmdRechercheCategorie_Click);
            // 
            // lvwRechercheAchat
            // 
            this.lvwRechercheAchat.BackColor = System.Drawing.SystemColors.Window;
            this.lvwRechercheAchat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwRechercheAchat_ColumnHeader_1,
            this._lvwRechercheAchat_ColumnHeader_2});
            this.lvwRechercheAchat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwRechercheAchat.FullRowSelect = true;
            this.lvwRechercheAchat.GridLines = true;
            this.lvwRechercheAchat.HideSelection = false;
            this.lvwRechercheAchat.Location = new System.Drawing.Point(119, 63);
            this.lvwRechercheAchat.Name = "lvwRechercheAchat";
            this.lvwRechercheAchat.Size = new System.Drawing.Size(591, 112);
            this.lvwRechercheAchat.TabIndex = 79;
            this.lvwRechercheAchat.UseCompatibleStateImageBehavior = false;
            this.lvwRechercheAchat.View = System.Windows.Forms.View.Details;
            this.lvwRechercheAchat.Visible = false;
            this.lvwRechercheAchat.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwRechercheAchat_ColumnClick);
            this.lvwRechercheAchat.Leave += new System.EventHandler(this.lvwRechercheAchat_Leave);
            // 
            // _lvwRechercheAchat_ColumnHeader_1
            // 
            this._lvwRechercheAchat_ColumnHeader_1.Text = "No. Job";
            this._lvwRechercheAchat_ColumnHeader_1.Width = 170;
            // 
            // _lvwRechercheAchat_ColumnHeader_2
            // 
            this._lvwRechercheAchat_ColumnHeader_2.Text = "Nbre fois";
            this._lvwRechercheAchat_ColumnHeader_2.Width = 170;
            // 
            // lvwRechercheJob
            // 
            this.lvwRechercheJob.BackColor = System.Drawing.SystemColors.Window;
            this.lvwRechercheJob.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwRechercheJob_ColumnHeader_1,
            this._lvwRechercheJob_ColumnHeader_2});
            this.lvwRechercheJob.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwRechercheJob.FullRowSelect = true;
            this.lvwRechercheJob.GridLines = true;
            this.lvwRechercheJob.HideSelection = false;
            this.lvwRechercheJob.Location = new System.Drawing.Point(119, 63);
            this.lvwRechercheJob.Name = "lvwRechercheJob";
            this.lvwRechercheJob.Size = new System.Drawing.Size(591, 112);
            this.lvwRechercheJob.TabIndex = 15;
            this.lvwRechercheJob.UseCompatibleStateImageBehavior = false;
            this.lvwRechercheJob.View = System.Windows.Forms.View.Details;
            this.lvwRechercheJob.Visible = false;
            this.lvwRechercheJob.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwRechercheJob_ColumnClick);
            this.lvwRechercheJob.Leave += new System.EventHandler(this.lvwRechercheJob_Leave);
            // 
            // _lvwRechercheJob_ColumnHeader_1
            // 
            this._lvwRechercheJob_ColumnHeader_1.Text = "No. Job";
            this._lvwRechercheJob_ColumnHeader_1.Width = 170;
            // 
            // _lvwRechercheJob_ColumnHeader_2
            // 
            this._lvwRechercheJob_ColumnHeader_2.Text = "Nbre fois";
            this._lvwRechercheJob_ColumnHeader_2.Width = 170;
            // 
            // cmdRechercheJob
            // 
            this.cmdRechercheJob.AutoSize = true;
            this.cmdRechercheJob.BackColor = System.Drawing.Color.Black;
            this.cmdRechercheJob.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdRechercheJob.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.cmdRechercheJob.ForeColor = System.Drawing.Color.White;
            this.cmdRechercheJob.Location = new System.Drawing.Point(67, 201);
            this.cmdRechercheJob.Name = "cmdRechercheJob";
            this.cmdRechercheJob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercheJob.Size = new System.Drawing.Size(159, 24);
            this.cmdRechercheJob.TabIndex = 38;
            this.cmdRechercheJob.Text = "Recherche dans jobs / soums";
            this.cmdRechercheJob.UseVisualStyleBackColor = true;
            this.cmdRechercheJob.Click += new System.EventHandler(this.cmdRechercheJob_Click);
            // 
            // cmdCopier
            // 
            this.cmdCopier.BackColor = System.Drawing.Color.Black;
            this.cmdCopier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCopier.ForeColor = System.Drawing.Color.White;
            this.cmdCopier.Location = new System.Drawing.Point(240, 400);
            this.cmdCopier.Name = "cmdCopier";
            this.cmdCopier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCopier.Size = new System.Drawing.Size(89, 33);
            this.cmdCopier.TabIndex = 69;
            this.cmdCopier.Text = "&Copier";
            this.cmdCopier.UseVisualStyleBackColor = true;
            this.cmdCopier.Click += new System.EventHandler(this.cmdCopier_Click);
            // 
            // cmdTotal
            // 
            this.cmdTotal.AutoSize = true;
            this.cmdTotal.BackColor = System.Drawing.Color.Black;
            this.cmdTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdTotal.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.cmdTotal.ForeColor = System.Drawing.Color.White;
            this.cmdTotal.Location = new System.Drawing.Point(8, 201);
            this.cmdTotal.Name = "cmdTotal";
            this.cmdTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdTotal.Size = new System.Drawing.Size(57, 24);
            this.cmdTotal.TabIndex = 37;
            this.cmdTotal.Text = "Total";
            this.cmdTotal.UseVisualStyleBackColor = true;
            this.cmdTotal.Click += new System.EventHandler(this.cmdTotal_Click);
            // 
            // cmdRechercheInventaire
            // 
            this.cmdRechercheInventaire.BackColor = System.Drawing.Color.Black;
            this.cmdRechercheInventaire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdRechercheInventaire.ForeColor = System.Drawing.Color.White;
            this.cmdRechercheInventaire.Location = new System.Drawing.Point(32, 400);
            this.cmdRechercheInventaire.Name = "cmdRechercheInventaire";
            this.cmdRechercheInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercheInventaire.Size = new System.Drawing.Size(97, 33);
            this.cmdRechercheInventaire.TabIndex = 67;
            this.cmdRechercheInventaire.Text = "Inventaire";
            this.cmdRechercheInventaire.UseVisualStyleBackColor = true;
            this.cmdRechercheInventaire.Click += new System.EventHandler(this.cmdRechercheInventaire_Click);
            // 
            // lvwFabricant
            // 
            this.lvwFabricant.BackColor = System.Drawing.SystemColors.Window;
            this.lvwFabricant.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwFabricant_ColumnHeader_1,
            this._lvwFabricant_ColumnHeader_2,
            this._lvwFabricant_ColumnHeader_3,
            this._lvwFabricant_ColumnHeader_4});
            this.lvwFabricant.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwFabricant.FullRowSelect = true;
            this.lvwFabricant.GridLines = true;
            this.lvwFabricant.HideSelection = false;
            this.lvwFabricant.Location = new System.Drawing.Point(121, 63);
            this.lvwFabricant.Name = "lvwFabricant";
            this.lvwFabricant.Size = new System.Drawing.Size(591, 112);
            this.lvwFabricant.TabIndex = 4;
            this.lvwFabricant.UseCompatibleStateImageBehavior = false;
            this.lvwFabricant.View = System.Windows.Forms.View.Details;
            this.lvwFabricant.Visible = false;
            this.lvwFabricant.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwFabricant_ColumnClick);
            this.lvwFabricant.DoubleClick += new System.EventHandler(this.lvwFabricant_DoubleClick);
            this.lvwFabricant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwFabricant_KeyDown);
            this.lvwFabricant.Leave += new System.EventHandler(this.lvwFabricant_Leave);
            // 
            // _lvwFabricant_ColumnHeader_1
            // 
            this._lvwFabricant_ColumnHeader_1.Text = "Manufacturier";
            this._lvwFabricant_ColumnHeader_1.Width = 140;
            // 
            // _lvwFabricant_ColumnHeader_2
            // 
            this._lvwFabricant_ColumnHeader_2.Text = "No. Pièce";
            this._lvwFabricant_ColumnHeader_2.Width = 217;
            // 
            // _lvwFabricant_ColumnHeader_3
            // 
            this._lvwFabricant_ColumnHeader_3.Text = "Description française";
            this._lvwFabricant_ColumnHeader_3.Width = 410;
            // 
            // _lvwFabricant_ColumnHeader_4
            // 
            this._lvwFabricant_ColumnHeader_4.Text = "Description anglaise";
            this._lvwFabricant_ColumnHeader_4.Width = 410;
            // 
            // lvwPieces
            // 
            this.lvwPieces.BackColor = System.Drawing.SystemColors.Window;
            this.lvwPieces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwPieces_ColumnHeader_1,
            this._lvwPieces_ColumnHeader_2,
            this._lvwPieces_ColumnHeader_3,
            this._lvwPieces_ColumnHeader_4});
            this.lvwPieces.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwPieces.FullRowSelect = true;
            this.lvwPieces.GridLines = true;
            this.lvwPieces.HideSelection = false;
            this.lvwPieces.Location = new System.Drawing.Point(119, 62);
            this.lvwPieces.Name = "lvwPieces";
            this.lvwPieces.Size = new System.Drawing.Size(591, 112);
            this.lvwPieces.TabIndex = 5;
            this.lvwPieces.UseCompatibleStateImageBehavior = false;
            this.lvwPieces.View = System.Windows.Forms.View.Details;
            this.lvwPieces.Visible = false;
            this.lvwPieces.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwPieces_ColumnClick);
            this.lvwPieces.DoubleClick += new System.EventHandler(this.lvwPieces_DoubleClick);
            this.lvwPieces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwPieces_KeyDown);
            this.lvwPieces.Leave += new System.EventHandler(this.lvwPieces_Leave);
            // 
            // _lvwPieces_ColumnHeader_1
            // 
            this._lvwPieces_ColumnHeader_1.Text = "No Pièce";
            this._lvwPieces_ColumnHeader_1.Width = 217;
            // 
            // _lvwPieces_ColumnHeader_2
            // 
            this._lvwPieces_ColumnHeader_2.Text = "Manufacturier";
            this._lvwPieces_ColumnHeader_2.Width = 140;
            // 
            // _lvwPieces_ColumnHeader_3
            // 
            this._lvwPieces_ColumnHeader_3.Text = "Description française";
            this._lvwPieces_ColumnHeader_3.Width = 410;
            // 
            // _lvwPieces_ColumnHeader_4
            // 
            this._lvwPieces_ColumnHeader_4.Text = "Description anglaise";
            this._lvwPieces_ColumnHeader_4.Width = 410;
            // 
            // cmdChangerCategorie
            // 
            this.cmdChangerCategorie.BackColor = System.Drawing.Color.Black;
            this.cmdChangerCategorie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdChangerCategorie.ForeColor = System.Drawing.Color.White;
            this.cmdChangerCategorie.Location = new System.Drawing.Point(536, 32);
            this.cmdChangerCategorie.Name = "cmdChangerCategorie";
            this.cmdChangerCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdChangerCategorie.Size = new System.Drawing.Size(121, 25);
            this.cmdChangerCategorie.TabIndex = 3;
            this.cmdChangerCategorie.Text = "Changer de catégorie";
            this.cmdChangerCategorie.UseVisualStyleBackColor = true;
            this.cmdChangerCategorie.Click += new System.EventHandler(this.cmdChangerCategorie_Click);
            // 
            // cmdDemande
            // 
            this.cmdDemande.BackColor = System.Drawing.Color.Black;
            this.cmdDemande.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDemande.ForeColor = System.Drawing.Color.White;
            this.cmdDemande.Location = new System.Drawing.Point(136, 400);
            this.cmdDemande.Name = "cmdDemande";
            this.cmdDemande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDemande.Size = new System.Drawing.Size(97, 33);
            this.cmdDemande.TabIndex = 68;
            this.cmdDemande.Text = "Demande de prix";
            this.cmdDemande.UseVisualStyleBackColor = true;
            this.cmdDemande.Click += new System.EventHandler(this.cmdDemande_Click);
            // 
            // lvwDescription
            // 
            this.lvwDescription.BackColor = System.Drawing.SystemColors.Window;
            this.lvwDescription.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwDescription_ColumnHeader_1,
            this._lvwDescription_ColumnHeader_2,
            this._lvwDescription_ColumnHeader_3,
            this._lvwDescription_ColumnHeader_4});
            this.lvwDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwDescription.FullRowSelect = true;
            this.lvwDescription.GridLines = true;
            this.lvwDescription.HideSelection = false;
            this.lvwDescription.Location = new System.Drawing.Point(119, 62);
            this.lvwDescription.Name = "lvwDescription";
            this.lvwDescription.Size = new System.Drawing.Size(591, 112);
            this.lvwDescription.TabIndex = 6;
            this.lvwDescription.UseCompatibleStateImageBehavior = false;
            this.lvwDescription.View = System.Windows.Forms.View.Details;
            this.lvwDescription.Visible = false;
            this.lvwDescription.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwDescription_ColumnClick);
            this.lvwDescription.DoubleClick += new System.EventHandler(this.lvwDescription_DoubleClick);
            this.lvwDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwDescription_KeyDown);
            this.lvwDescription.Leave += new System.EventHandler(this.lvwDescription_Leave);
            // 
            // _lvwDescription_ColumnHeader_1
            // 
            this._lvwDescription_ColumnHeader_1.Text = "Description française";
            this._lvwDescription_ColumnHeader_1.Width = 410;
            // 
            // _lvwDescription_ColumnHeader_2
            // 
            this._lvwDescription_ColumnHeader_2.Text = "Description anglais";
            this._lvwDescription_ColumnHeader_2.Width = 410;
            // 
            // _lvwDescription_ColumnHeader_3
            // 
            this._lvwDescription_ColumnHeader_3.Text = "Manufacturier";
            this._lvwDescription_ColumnHeader_3.Width = 140;
            // 
            // _lvwDescription_ColumnHeader_4
            // 
            this._lvwDescription_ColumnHeader_4.Text = "NoItem";
            this._lvwDescription_ColumnHeader_4.Width = 217;
            // 
            // cmdRechercheDescrFR
            // 
            this.cmdRechercheDescrFR.BackColor = System.Drawing.Color.Black;
            this.cmdRechercheDescrFR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRechercheDescrFR.BackgroundImage")));
            this.cmdRechercheDescrFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRechercheDescrFR.ForeColor = System.Drawing.Color.White;
            this.cmdRechercheDescrFR.Location = new System.Drawing.Point(688, 60);
            this.cmdRechercheDescrFR.Name = "cmdRechercheDescrFR";
            this.cmdRechercheDescrFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercheDescrFR.Size = new System.Drawing.Size(25, 25);
            this.cmdRechercheDescrFR.TabIndex = 9;
            this.cmdRechercheDescrFR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdRechercheDescrFR.UseVisualStyleBackColor = true;
            this.cmdRechercheDescrFR.Click += new System.EventHandler(this.cmdRechercheDescrFR_Click);
            // 
            // frafournisseur
            // 
            this.frafournisseur.BackColor = System.Drawing.Color.Black;
            this.frafournisseur.Controls.Add(this.txtTauxChange);
            this.frafournisseur.Controls.Add(this.lvwfournisseur);
            this.frafournisseur.Controls.Add(this.cmdAddFrs);
            this.frafournisseur.Controls.Add(this.cmdSuppFrs);
            this.frafournisseur.Controls.Add(this.cmdModifFrs);
            this.frafournisseur.Controls.Add(this.chkquoter);
            this.frafournisseur.Controls.Add(this.optUSA);
            this.frafournisseur.Controls.Add(this.optCAN);
            this.frafournisseur.Controls.Add(this.txtPrixList);
            this.frafournisseur.Controls.Add(this.txtPrixNet);
            this.frafournisseur.Controls.Add(this.txtPrixSpecial);
            this.frafournisseur.Controls.Add(this.mskValide);
            this.frafournisseur.Controls.Add(this.mskEscompte);
            this.frafournisseur.Controls.Add(this.cmdEnrFrs);
            this.frafournisseur.Controls.Add(this.cmdAnnulFrs);
            this.frafournisseur.Controls.Add(this.cmbfrs);
            this.frafournisseur.Controls.Add(this.cmbPersRess);
            this.frafournisseur.Controls.Add(this.optSpain);
            this.frafournisseur.Controls.Add(this.lblDevise1);
            this.frafournisseur.Controls.Add(this.lblDevise2);
            this.frafournisseur.Controls.Add(this._Label1_5);
            this.frafournisseur.Controls.Add(this.imgCanada);
            this.frafournisseur.Controls.Add(this.imgEU);
            this.frafournisseur.Controls.Add(this._Label1_14);
            this.frafournisseur.Controls.Add(this._Label1_16);
            this.frafournisseur.Controls.Add(this._Label1_19);
            this.frafournisseur.Controls.Add(this._Label1_24);
            this.frafournisseur.Controls.Add(this._Label1_20);
            this.frafournisseur.Controls.Add(this._Label1_2);
            this.frafournisseur.Controls.Add(this._Label1_23);
            this.frafournisseur.Controls.Add(this.imgSpain);
            this.frafournisseur.ForeColor = System.Drawing.Color.White;
            this.frafournisseur.Location = new System.Drawing.Point(8, 231);
            this.frafournisseur.Name = "frafournisseur";
            this.frafournisseur.Padding = new System.Windows.Forms.Padding(0);
            this.frafournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frafournisseur.Size = new System.Drawing.Size(705, 161);
            this.frafournisseur.TabIndex = 41;
            this.frafournisseur.TabStop = false;
            this.frafournisseur.Text = "Fournisseur";
            // 
            // txtTauxChange
            // 
            this.txtTauxChange.AcceptsReturn = true;
            this.txtTauxChange.BackColor = System.Drawing.Color.Black;
            this.txtTauxChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTauxChange.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTauxChange.Location = new System.Drawing.Point(576, 128);
            this.txtTauxChange.MaxLength = 0;
            this.txtTauxChange.Name = "txtTauxChange";
            this.txtTauxChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTauxChange.Size = new System.Drawing.Size(57, 22);
            this.txtTauxChange.TabIndex = 76;
            // 
            // cmdAddFrs
            // 
            this.cmdAddFrs.BackColor = System.Drawing.Color.Black;
            this.cmdAddFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAddFrs.ForeColor = System.Drawing.Color.White;
            this.cmdAddFrs.Location = new System.Drawing.Point(8, 128);
            this.cmdAddFrs.Name = "cmdAddFrs";
            this.cmdAddFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAddFrs.Size = new System.Drawing.Size(73, 25);
            this.cmdAddFrs.TabIndex = 62;
            this.cmdAddFrs.Text = "&Ajouter";
            this.cmdAddFrs.UseVisualStyleBackColor = true;
            this.cmdAddFrs.Click += new System.EventHandler(this.cmdAddFrs_Click);
            // 
            // cmdSuppFrs
            // 
            this.cmdSuppFrs.BackColor = System.Drawing.Color.Black;
            this.cmdSuppFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSuppFrs.ForeColor = System.Drawing.Color.White;
            this.cmdSuppFrs.Location = new System.Drawing.Point(88, 128);
            this.cmdSuppFrs.Name = "cmdSuppFrs";
            this.cmdSuppFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSuppFrs.Size = new System.Drawing.Size(73, 25);
            this.cmdSuppFrs.TabIndex = 65;
            this.cmdSuppFrs.Text = "&Supprimer";
            this.cmdSuppFrs.UseVisualStyleBackColor = true;
            this.cmdSuppFrs.Click += new System.EventHandler(this.cmdSuppFrs_Click);
            // 
            // cmdModifFrs
            // 
            this.cmdModifFrs.BackColor = System.Drawing.Color.Black;
            this.cmdModifFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdModifFrs.ForeColor = System.Drawing.Color.White;
            this.cmdModifFrs.Location = new System.Drawing.Point(168, 128);
            this.cmdModifFrs.Name = "cmdModifFrs";
            this.cmdModifFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdModifFrs.Size = new System.Drawing.Size(73, 25);
            this.cmdModifFrs.TabIndex = 66;
            this.cmdModifFrs.Text = "&Modifier";
            this.cmdModifFrs.UseVisualStyleBackColor = true;
            this.cmdModifFrs.Click += new System.EventHandler(this.cmdModifFrs_Click);
            // 
            // chkquoter
            // 
            this.chkquoter.BackColor = System.Drawing.Color.Black;
            this.chkquoter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkquoter.ForeColor = System.Drawing.Color.White;
            this.chkquoter.Location = new System.Drawing.Point(8, 96);
            this.chkquoter.Name = "chkquoter";
            this.chkquoter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkquoter.Size = new System.Drawing.Size(89, 17);
            this.chkquoter.TabIndex = 61;
            this.chkquoter.Text = "Quoter :";
            this.chkquoter.UseVisualStyleBackColor = true;
            // 
            // optUSA
            // 
            this.optUSA.BackColor = System.Drawing.Color.Black;
            this.optUSA.ForeColor = System.Drawing.Color.White;
            this.optUSA.Location = new System.Drawing.Point(576, 24);
            this.optUSA.Name = "optUSA";
            this.optUSA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optUSA.Size = new System.Drawing.Size(49, 17);
            this.optUSA.TabIndex = 56;
            this.optUSA.TabStop = true;
            this.optUSA.Text = "USA";
            this.optUSA.UseVisualStyleBackColor = true;
            this.optUSA.CheckedChanged += new System.EventHandler(this.optUSA_CheckedChanged);
            // 
            // optCAN
            // 
            this.optCAN.BackColor = System.Drawing.Color.Black;
            this.optCAN.Checked = true;
            this.optCAN.ForeColor = System.Drawing.Color.White;
            this.optCAN.Location = new System.Drawing.Point(528, 24);
            this.optCAN.Name = "optCAN";
            this.optCAN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optCAN.Size = new System.Drawing.Size(49, 17);
            this.optCAN.TabIndex = 55;
            this.optCAN.TabStop = true;
            this.optCAN.Text = "CAN";
            this.optCAN.UseVisualStyleBackColor = true;
            this.optCAN.CheckedChanged += new System.EventHandler(this.optCAN_CheckedChanged);
            // 
            // txtPrixList
            // 
            this.txtPrixList.AcceptsReturn = true;
            this.txtPrixList.BackColor = System.Drawing.Color.White;
            this.txtPrixList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrixList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrixList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrixList.Location = new System.Drawing.Point(424, 24);
            this.txtPrixList.MaxLength = 0;
            this.txtPrixList.Name = "txtPrixList";
            this.txtPrixList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrixList.Size = new System.Drawing.Size(73, 15);
            this.txtPrixList.TabIndex = 48;
            this.txtPrixList.Leave += new System.EventHandler(this.txtPrixList_Leave);
            // 
            // txtPrixNet
            // 
            this.txtPrixNet.AcceptsReturn = true;
            this.txtPrixNet.BackColor = System.Drawing.Color.White;
            this.txtPrixNet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrixNet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrixNet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrixNet.Location = new System.Drawing.Point(424, 72);
            this.txtPrixNet.MaxLength = 0;
            this.txtPrixNet.Name = "txtPrixNet";
            this.txtPrixNet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrixNet.Size = new System.Drawing.Size(57, 15);
            this.txtPrixNet.TabIndex = 52;
            this.txtPrixNet.TextChanged += new System.EventHandler(this.txtPrixNet_TextChanged);
            this.txtPrixNet.Enter += new System.EventHandler(this.txtPrixNet_Enter);
            this.txtPrixNet.Leave += new System.EventHandler(this.txtPrixNet_Leave);
            // 
            // txtPrixSpecial
            // 
            this.txtPrixSpecial.AcceptsReturn = true;
            this.txtPrixSpecial.BackColor = System.Drawing.Color.White;
            this.txtPrixSpecial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrixSpecial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrixSpecial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrixSpecial.Location = new System.Drawing.Point(424, 96);
            this.txtPrixSpecial.MaxLength = 0;
            this.txtPrixSpecial.Name = "txtPrixSpecial";
            this.txtPrixSpecial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrixSpecial.Size = new System.Drawing.Size(57, 15);
            this.txtPrixSpecial.TabIndex = 54;
            this.txtPrixSpecial.TextChanged += new System.EventHandler(this.txtPrixSpecial_TextChanged);
            this.txtPrixSpecial.Leave += new System.EventHandler(this.txtPrixSpecial_Leave);
            // 
            // mskValide
            // 
            this.mskValide.BackColor = System.Drawing.Color.White;
            this.mskValide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskValide.Location = new System.Drawing.Point(104, 72);
            this.mskValide.Name = "mskValide";
            this.mskValide.Size = new System.Drawing.Size(81, 15);
            this.mskValide.TabIndex = 46;
            // 
            // mskEscompte
            // 
            this.mskEscompte.BackColor = System.Drawing.Color.White;
            this.mskEscompte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskEscompte.Location = new System.Drawing.Point(424, 48);
            this.mskEscompte.Name = "mskEscompte";
            this.mskEscompte.Size = new System.Drawing.Size(57, 15);
            this.mskEscompte.TabIndex = 50;
            // 
            // cmdEnrFrs
            // 
            this.cmdEnrFrs.BackColor = System.Drawing.Color.Black;
            this.cmdEnrFrs.ForeColor = System.Drawing.Color.White;
            this.cmdEnrFrs.Location = new System.Drawing.Point(8, 128);
            this.cmdEnrFrs.Name = "cmdEnrFrs";
            this.cmdEnrFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdEnrFrs.Size = new System.Drawing.Size(73, 25);
            this.cmdEnrFrs.TabIndex = 63;
            this.cmdEnrFrs.Text = "&Enregistre";
            this.cmdEnrFrs.UseVisualStyleBackColor = true;
            this.cmdEnrFrs.Click += new System.EventHandler(this.cmdEnrFrs_Click);
            // 
            // cmdAnnulFrs
            // 
            this.cmdAnnulFrs.BackColor = System.Drawing.Color.Black;
            this.cmdAnnulFrs.ForeColor = System.Drawing.Color.White;
            this.cmdAnnulFrs.Location = new System.Drawing.Point(88, 128);
            this.cmdAnnulFrs.Name = "cmdAnnulFrs";
            this.cmdAnnulFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnulFrs.Size = new System.Drawing.Size(73, 25);
            this.cmdAnnulFrs.TabIndex = 64;
            this.cmdAnnulFrs.Text = "A&nnuler";
            this.cmdAnnulFrs.UseVisualStyleBackColor = true;
            this.cmdAnnulFrs.Click += new System.EventHandler(this.cmdAnnulFrs_Click);
            // 
            // cmbfrs
            // 
            this.cmbfrs.BackColor = System.Drawing.SystemColors.Window;
            this.cmbfrs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbfrs.Location = new System.Drawing.Point(104, 24);
            this.cmbfrs.Name = "cmbfrs";
            this.cmbfrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbfrs.Size = new System.Drawing.Size(185, 22);
            this.cmbfrs.TabIndex = 44;
            this.cmbfrs.SelectedIndexChanged += new System.EventHandler(this.cmbfrs_SelectedIndexChanged);
            // 
            // cmbPersRess
            // 
            this.cmbPersRess.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPersRess.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbPersRess.Location = new System.Drawing.Point(104, 48);
            this.cmbPersRess.Name = "cmbPersRess";
            this.cmbPersRess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPersRess.Size = new System.Drawing.Size(145, 22);
            this.cmbPersRess.TabIndex = 45;
            // 
            // optSpain
            // 
            this.optSpain.BackColor = System.Drawing.Color.Black;
            this.optSpain.ForeColor = System.Drawing.Color.White;
            this.optSpain.Location = new System.Drawing.Point(624, 24);
            this.optSpain.Name = "optSpain";
            this.optSpain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optSpain.Size = new System.Drawing.Size(49, 17);
            this.optSpain.TabIndex = 57;
            this.optSpain.TabStop = true;
            this.optSpain.Text = "SPA";
            this.optSpain.UseVisualStyleBackColor = true;
            this.optSpain.CheckedChanged += new System.EventHandler(this.optSpain_CheckedChanged);
            // 
            // lblDevise1
            // 
            this.lblDevise1.BackColor = System.Drawing.Color.Black;
            this.lblDevise1.ForeColor = System.Drawing.Color.White;
            this.lblDevise1.Location = new System.Drawing.Point(520, 128);
            this.lblDevise1.Name = "lblDevise1";
            this.lblDevise1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevise1.Size = new System.Drawing.Size(57, 17);
            this.lblDevise1.TabIndex = 78;
            this.lblDevise1.Text = "1$ CAN =";
            // 
            // lblDevise2
            // 
            this.lblDevise2.BackColor = System.Drawing.Color.Black;
            this.lblDevise2.ForeColor = System.Drawing.Color.White;
            this.lblDevise2.Location = new System.Drawing.Point(637, 128);
            this.lblDevise2.Name = "lblDevise2";
            this.lblDevise2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevise2.Size = new System.Drawing.Size(38, 17);
            this.lblDevise2.TabIndex = 77;
            this.lblDevise2.Text = "$ USA";
            // 
            // _Label1_5
            // 
            this._Label1_5.BackColor = System.Drawing.Color.Black;
            this._Label1_5.ForeColor = System.Drawing.Color.White;
            this._Label1_5.Location = new System.Drawing.Point(192, 72);
            this._Label1_5.Name = "_Label1_5";
            this._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_5.Size = new System.Drawing.Size(65, 17);
            this._Label1_5.TabIndex = 60;
            this._Label1_5.Text = "AA-MM-JJ";
            // 
            // imgCanada
            // 
            this.imgCanada.BackgroundImage = global::ControleurServeur.Properties.Resources.Flgcan;
            this.imgCanada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCanada.Location = new System.Drawing.Point(544, 47);
            this.imgCanada.Name = "imgCanada";
            this.imgCanada.Size = new System.Drawing.Size(112, 71);
            this.imgCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCanada.TabIndex = 79;
            this.imgCanada.TabStop = false;
            // 
            // imgEU
            // 
            this.imgEU.BackgroundImage = global::ControleurServeur.Properties.Resources.Flgusa02;
            this.imgEU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgEU.Location = new System.Drawing.Point(544, 47);
            this.imgEU.Name = "imgEU";
            this.imgEU.Size = new System.Drawing.Size(112, 71);
            this.imgEU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEU.TabIndex = 80;
            this.imgEU.TabStop = false;
            // 
            // _Label1_14
            // 
            this._Label1_14.BackColor = System.Drawing.Color.Black;
            this._Label1_14.ForeColor = System.Drawing.Color.White;
            this._Label1_14.Location = new System.Drawing.Point(8, 24);
            this._Label1_14.Name = "_Label1_14";
            this._Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_14.Size = new System.Drawing.Size(81, 17);
            this._Label1_14.TabIndex = 43;
            this._Label1_14.Text = "Distributeur :";
            // 
            // _Label1_16
            // 
            this._Label1_16.BackColor = System.Drawing.Color.Black;
            this._Label1_16.ForeColor = System.Drawing.Color.White;
            this._Label1_16.Location = new System.Drawing.Point(344, 24);
            this._Label1_16.Name = "_Label1_16";
            this._Label1_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_16.Size = new System.Drawing.Size(65, 17);
            this._Label1_16.TabIndex = 47;
            this._Label1_16.Text = "Prix Listé :";
            // 
            // _Label1_19
            // 
            this._Label1_19.BackColor = System.Drawing.Color.Black;
            this._Label1_19.ForeColor = System.Drawing.Color.White;
            this._Label1_19.Location = new System.Drawing.Point(344, 48);
            this._Label1_19.Name = "_Label1_19";
            this._Label1_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_19.Size = new System.Drawing.Size(73, 17);
            this._Label1_19.TabIndex = 49;
            this._Label1_19.Text = "Escompte :";
            // 
            // _Label1_24
            // 
            this._Label1_24.BackColor = System.Drawing.Color.Black;
            this._Label1_24.ForeColor = System.Drawing.Color.White;
            this._Label1_24.Location = new System.Drawing.Point(8, 48);
            this._Label1_24.Name = "_Label1_24";
            this._Label1_24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_24.Size = new System.Drawing.Size(105, 17);
            this._Label1_24.TabIndex = 58;
            this._Label1_24.Text = "Pers. Ress :";
            // 
            // _Label1_20
            // 
            this._Label1_20.BackColor = System.Drawing.Color.Black;
            this._Label1_20.ForeColor = System.Drawing.Color.White;
            this._Label1_20.Location = new System.Drawing.Point(344, 72);
            this._Label1_20.Name = "_Label1_20";
            this._Label1_20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_20.Size = new System.Drawing.Size(73, 17);
            this._Label1_20.TabIndex = 51;
            this._Label1_20.Text = "Prix Net :";
            // 
            // _Label1_2
            // 
            this._Label1_2.BackColor = System.Drawing.Color.Black;
            this._Label1_2.ForeColor = System.Drawing.Color.White;
            this._Label1_2.Location = new System.Drawing.Point(344, 96);
            this._Label1_2.Name = "_Label1_2";
            this._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_2.Size = new System.Drawing.Size(81, 17);
            this._Label1_2.TabIndex = 53;
            this._Label1_2.Text = "Prix Spécial :";
            // 
            // _Label1_23
            // 
            this._Label1_23.BackColor = System.Drawing.Color.Black;
            this._Label1_23.ForeColor = System.Drawing.Color.White;
            this._Label1_23.Location = new System.Drawing.Point(8, 72);
            this._Label1_23.Name = "_Label1_23";
            this._Label1_23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_23.Size = new System.Drawing.Size(97, 17);
            this._Label1_23.TabIndex = 59;
            this._Label1_23.Text = "Valide jusqu\'au :";
            // 
            // imgSpain
            // 
            this.imgSpain.BackgroundImage = global::ControleurServeur.Properties.Resources.Flgspain;
            this.imgSpain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSpain.Location = new System.Drawing.Point(544, 48);
            this.imgSpain.Name = "imgSpain";
            this.imgSpain.Size = new System.Drawing.Size(112, 71);
            this.imgSpain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSpain.TabIndex = 81;
            this.imgSpain.TabStop = false;
            // 
            // lvwfournisseur
            // 
            this.lvwfournisseur.BackColor = System.Drawing.SystemColors.Window;
            this.lvwfournisseur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwfournisseur_ColumnHeader_1,
            this._lvwfournisseur_ColumnHeader_2,
            this._lvwfournisseur_ColumnHeader_3,
            this._lvwfournisseur_ColumnHeader_4,
            this._lvwfournisseur_ColumnHeader_5,
            this._lvwfournisseur_ColumnHeader_6,
            this._lvwfournisseur_ColumnHeader_7,
            this._lvwfournisseur_ColumnHeader_8,
            this._lvwfournisseur_ColumnHeader_9,
            this._lvwfournisseur_ColumnHeader_10});
            this.lvwfournisseur.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwfournisseur.FullRowSelect = true;
            this.lvwfournisseur.GridLines = true;
            this.lvwfournisseur.HideSelection = false;
            this.lvwfournisseur.Location = new System.Drawing.Point(6, 20);
            this.lvwfournisseur.Name = "lvwfournisseur";
            this.lvwfournisseur.Size = new System.Drawing.Size(691, 105);
            this.lvwfournisseur.TabIndex = 83;
            this.lvwfournisseur.UseCompatibleStateImageBehavior = false;
            this.lvwfournisseur.View = System.Windows.Forms.View.Details;
            // 
            // _lvwfournisseur_ColumnHeader_1
            // 
            this._lvwfournisseur_ColumnHeader_1.Text = "Fournisseur";
            this._lvwfournisseur_ColumnHeader_1.Width = 236;
            // 
            // _lvwfournisseur_ColumnHeader_2
            // 
            this._lvwfournisseur_ColumnHeader_2.Text = "Pers. Ress.";
            this._lvwfournisseur_ColumnHeader_2.Width = 133;
            // 
            // _lvwfournisseur_ColumnHeader_3
            // 
            this._lvwfournisseur_ColumnHeader_3.Text = "Date";
            this._lvwfournisseur_ColumnHeader_3.Width = 117;
            // 
            // _lvwfournisseur_ColumnHeader_4
            // 
            this._lvwfournisseur_ColumnHeader_4.Text = "Par";
            this._lvwfournisseur_ColumnHeader_4.Width = 54;
            // 
            // _lvwfournisseur_ColumnHeader_5
            // 
            this._lvwfournisseur_ColumnHeader_5.Text = "Valide";
            this._lvwfournisseur_ColumnHeader_5.Width = 117;
            // 
            // _lvwfournisseur_ColumnHeader_6
            // 
            this._lvwfournisseur_ColumnHeader_6.Text = "Prix listé";
            this._lvwfournisseur_ColumnHeader_6.Width = 108;
            // 
            // _lvwfournisseur_ColumnHeader_7
            // 
            this._lvwfournisseur_ColumnHeader_7.Text = "Escompte";
            this._lvwfournisseur_ColumnHeader_7.Width = 105;
            // 
            // _lvwfournisseur_ColumnHeader_8
            // 
            this._lvwfournisseur_ColumnHeader_8.Text = "Prix net";
            this._lvwfournisseur_ColumnHeader_8.Width = 108;
            // 
            // _lvwfournisseur_ColumnHeader_9
            // 
            this._lvwfournisseur_ColumnHeader_9.Text = "Prix spécial";
            this._lvwfournisseur_ColumnHeader_9.Width = 115;
            // 
            // _lvwfournisseur_ColumnHeader_10
            // 
            this._lvwfournisseur_ColumnHeader_10.Text = "Quoter";
            this._lvwfournisseur_ColumnHeader_10.Width = 80;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.BackColor = System.Drawing.Color.White;
            this.cmbCategorie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCategorie.Location = new System.Drawing.Point(376, 8);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCategorie.Size = new System.Drawing.Size(281, 22);
            this.cmbCategorie.TabIndex = 0;
            this.cmbCategorie.Text = "cmbCategorie";
            this.cmbCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbCategorie_SelectedIndexChanged);
            // 
            // txtNoItemGRB
            // 
            this.txtNoItemGRB.AcceptsReturn = true;
            this.txtNoItemGRB.BackColor = System.Drawing.Color.White;
            this.txtNoItemGRB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoItemGRB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoItemGRB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNoItemGRB.Location = new System.Drawing.Point(128, 152);
            this.txtNoItemGRB.MaxLength = 0;
            this.txtNoItemGRB.Name = "txtNoItemGRB";
            this.txtNoItemGRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoItemGRB.Size = new System.Drawing.Size(129, 15);
            this.txtNoItemGRB.TabIndex = 24;
            // 
            // cmbNoItem
            // 
            this.cmbNoItem.BackColor = System.Drawing.Color.White;
            this.cmbNoItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbNoItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbNoItem.Location = new System.Drawing.Point(128, 120);
            this.cmbNoItem.Name = "cmbNoItem";
            this.cmbNoItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbNoItem.Size = new System.Drawing.Size(129, 22);
            this.cmbNoItem.TabIndex = 17;
            this.cmbNoItem.Text = "cmbNoItem";
            this.cmbNoItem.SelectedIndexChanged += new System.EventHandler(this.cmbNoItem_SelectedIndexChanged);
            // 
            // CmdModif
            // 
            this.CmdModif.BackColor = System.Drawing.Color.Black;
            this.CmdModif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdModif.ForeColor = System.Drawing.Color.White;
            this.CmdModif.Location = new System.Drawing.Point(528, 400);
            this.CmdModif.Name = "CmdModif";
            this.CmdModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdModif.Size = new System.Drawing.Size(89, 33);
            this.CmdModif.TabIndex = 74;
            this.CmdModif.Text = "&Modifier";
            this.CmdModif.UseVisualStyleBackColor = true;
            this.CmdModif.Click += new System.EventHandler(this.CmdModif_Click);
            // 
            // CmdFerme
            // 
            this.CmdFerme.BackColor = System.Drawing.Color.Black;
            this.CmdFerme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdFerme.ForeColor = System.Drawing.Color.White;
            this.CmdFerme.Location = new System.Drawing.Point(624, 400);
            this.CmdFerme.Name = "CmdFerme";
            this.CmdFerme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdFerme.Size = new System.Drawing.Size(89, 33);
            this.CmdFerme.TabIndex = 75;
            this.CmdFerme.Text = "&Fermer";
            this.CmdFerme.UseVisualStyleBackColor = true;
            this.CmdFerme.Click += new System.EventHandler(this.CmdFerme_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.BackColor = System.Drawing.Color.Black;
            this.CmdSupp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdSupp.ForeColor = System.Drawing.Color.White;
            this.CmdSupp.Location = new System.Drawing.Point(432, 400);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdSupp.Size = new System.Drawing.Size(89, 33);
            this.CmdSupp.TabIndex = 72;
            this.CmdSupp.Text = "&Supprimer";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.BackColor = System.Drawing.Color.Black;
            this.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdAdd.ForeColor = System.Drawing.Color.White;
            this.CmdAdd.Location = new System.Drawing.Point(336, 400);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAdd.Size = new System.Drawing.Size(89, 33);
            this.CmdAdd.TabIndex = 71;
            this.CmdAdd.Text = "&Ajouter";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // txtComment
            // 
            this.txtComment.AcceptsReturn = true;
            this.txtComment.BackColor = System.Drawing.Color.White;
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtComment.Location = new System.Drawing.Point(376, 128);
            this.txtComment.MaxLength = 100;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtComment.Size = new System.Drawing.Size(305, 15);
            this.txtComment.TabIndex = 25;
            // 
            // cmbFabricant
            // 
            this.cmbFabricant.BackColor = System.Drawing.Color.White;
            this.cmbFabricant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFabricant.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbFabricant.Location = new System.Drawing.Point(128, 64);
            this.cmbFabricant.Name = "cmbFabricant";
            this.cmbFabricant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbFabricant.Size = new System.Drawing.Size(129, 22);
            this.cmbFabricant.TabIndex = 10;
            this.cmbFabricant.Text = "cmbFabricant";
            this.cmbFabricant.SelectedIndexChanged += new System.EventHandler(this.cmbFabricant_SelectedIndexChanged);
            // 
            // txtFabricant
            // 
            this.txtFabricant.AcceptsReturn = true;
            this.txtFabricant.BackColor = System.Drawing.Color.White;
            this.txtFabricant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFabricant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFabricant.Enabled = false;
            this.txtFabricant.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFabricant.Location = new System.Drawing.Point(128, 88);
            this.txtFabricant.MaxLength = 0;
            this.txtFabricant.Name = "txtFabricant";
            this.txtFabricant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFabricant.Size = new System.Drawing.Size(129, 15);
            this.txtFabricant.TabIndex = 8;
            // 
            // txtDescriptionEN
            // 
            this.txtDescriptionEN.AcceptsReturn = true;
            this.txtDescriptionEN.BackColor = System.Drawing.Color.White;
            this.txtDescriptionEN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescriptionEN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescriptionEN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescriptionEN.Location = new System.Drawing.Point(376, 96);
            this.txtDescriptionEN.MaxLength = 100;
            this.txtDescriptionEN.Name = "txtDescriptionEN";
            this.txtDescriptionEN.ReadOnly = true;
            this.txtDescriptionEN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescriptionEN.Size = new System.Drawing.Size(305, 15);
            this.txtDescriptionEN.TabIndex = 21;
            // 
            // txtDescriptionFR
            // 
            this.txtDescriptionFR.AcceptsReturn = true;
            this.txtDescriptionFR.BackColor = System.Drawing.Color.White;
            this.txtDescriptionFR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescriptionFR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescriptionFR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescriptionFR.Location = new System.Drawing.Point(376, 64);
            this.txtDescriptionFR.MaxLength = 100;
            this.txtDescriptionFR.Name = "txtDescriptionFR";
            this.txtDescriptionFR.ReadOnly = true;
            this.txtDescriptionFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescriptionFR.Size = new System.Drawing.Size(305, 15);
            this.txtDescriptionFR.TabIndex = 14;
            // 
            // txtNoItem
            // 
            this.txtNoItem.AcceptsReturn = true;
            this.txtNoItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNoItem.Location = new System.Drawing.Point(128, 120);
            this.txtNoItem.MaxLength = 0;
            this.txtNoItem.Name = "txtNoItem";
            this.txtNoItem.ReadOnly = true;
            this.txtNoItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoItem.Size = new System.Drawing.Size(129, 22);
            this.txtNoItem.TabIndex = 18;
            this.txtNoItem.TextChanged += new System.EventHandler(this.txtNoItem_TextChanged);
            // 
            // CmdAnul
            // 
            this.CmdAnul.BackColor = System.Drawing.Color.Black;
            this.CmdAnul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdAnul.ForeColor = System.Drawing.Color.White;
            this.CmdAnul.Location = new System.Drawing.Point(432, 400);
            this.CmdAnul.Name = "CmdAnul";
            this.CmdAnul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAnul.Size = new System.Drawing.Size(89, 33);
            this.CmdAnul.TabIndex = 73;
            this.CmdAnul.Text = "A&nnuler";
            this.CmdAnul.UseVisualStyleBackColor = true;
            this.CmdAnul.Click += new System.EventHandler(this.CmdAnul_Click);
            // 
            // CmdEnr
            // 
            this.CmdEnr.BackColor = System.Drawing.Color.Black;
            this.CmdEnr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdEnr.ForeColor = System.Drawing.Color.White;
            this.CmdEnr.Location = new System.Drawing.Point(336, 400);
            this.CmdEnr.Name = "CmdEnr";
            this.CmdEnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdEnr.Size = new System.Drawing.Size(89, 33);
            this.CmdEnr.TabIndex = 70;
            this.CmdEnr.Text = "&Enregistre";
            this.CmdEnr.UseVisualStyleBackColor = true;
            this.CmdEnr.Click += new System.EventHandler(this.CmdEnr_Click);
            // 
            // txtCategorie
            // 
            this.txtCategorie.AcceptsReturn = true;
            this.txtCategorie.BackColor = System.Drawing.SystemColors.Window;
            this.txtCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategorie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCategorie.Location = new System.Drawing.Point(376, 8);
            this.txtCategorie.MaxLength = 0;
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.ReadOnly = true;
            this.txtCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCategorie.Size = new System.Drawing.Size(281, 22);
            this.txtCategorie.TabIndex = 2;
            // 
            // cmdRechercherPiece
            // 
            this.cmdRechercherPiece.BackColor = System.Drawing.Color.Black;
            this.cmdRechercherPiece.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRechercherPiece.BackgroundImage")));
            this.cmdRechercherPiece.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRechercherPiece.ForeColor = System.Drawing.Color.White;
            this.cmdRechercherPiece.Location = new System.Drawing.Point(264, 120);
            this.cmdRechercherPiece.Name = "cmdRechercherPiece";
            this.cmdRechercherPiece.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercherPiece.Size = new System.Drawing.Size(25, 25);
            this.cmdRechercherPiece.TabIndex = 19;
            this.cmdRechercherPiece.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdRechercherPiece.UseVisualStyleBackColor = true;
            this.cmdRechercherPiece.Click += new System.EventHandler(this.cmdRechercherPiece_Click);
            // 
            // cmbDescriptionFR
            // 
            this.cmbDescriptionFR.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDescriptionFR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDescriptionFR.Location = new System.Drawing.Point(376, 64);
            this.cmbDescriptionFR.Name = "cmbDescriptionFR";
            this.cmbDescriptionFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDescriptionFR.Size = new System.Drawing.Size(305, 22);
            this.cmbDescriptionFR.TabIndex = 13;
            this.cmbDescriptionFR.SelectedIndexChanged += new System.EventHandler(this.cmbDescriptionFR_SelectedIndexChanged);
            // 
            // cmdRechercherManufact
            // 
            this.cmdRechercherManufact.BackColor = System.Drawing.Color.Black;
            this.cmdRechercherManufact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRechercherManufact.BackgroundImage")));
            this.cmdRechercherManufact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdRechercherManufact.ForeColor = System.Drawing.Color.White;
            this.cmdRechercherManufact.Location = new System.Drawing.Point(264, 64);
            this.cmdRechercherManufact.Name = "cmdRechercherManufact";
            this.cmdRechercherManufact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercherManufact.Size = new System.Drawing.Size(25, 25);
            this.cmdRechercherManufact.TabIndex = 11;
            this.cmdRechercherManufact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdRechercherManufact.UseVisualStyleBackColor = true;
            this.cmdRechercherManufact.Click += new System.EventHandler(this.cmdRechercherManufact_Click);
            // 
            // chkInventaire
            // 
            this.chkInventaire.BackColor = System.Drawing.Color.Black;
            this.chkInventaire.ForeColor = System.Drawing.Color.White;
            this.chkInventaire.Location = new System.Drawing.Point(321, 152);
            this.chkInventaire.Name = "chkInventaire";
            this.chkInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkInventaire.Size = new System.Drawing.Size(161, 25);
            this.chkInventaire.TabIndex = 26;
            this.chkInventaire.Text = "Présent dans l\'inventaire";
            this.chkInventaire.UseVisualStyleBackColor = true;
            this.chkInventaire.CheckStateChanged += new System.EventHandler(this.chkInventaire_CheckStateChanged);
            // 
            // fraQuantité
            // 
            this.fraQuantité.BackColor = System.Drawing.Color.Black;
            this.fraQuantité.Controls.Add(this.txtQuantiteCommande);
            this.fraQuantité.Controls.Add(this.chkMinimum);
            this.fraQuantité.Controls.Add(this.txtQuantiteStock);
            this.fraQuantité.Controls.Add(this.txtQuantiteMinimum);
            this.fraQuantité.Controls.Add(this.txtQuantitéBoite);
            this.fraQuantité.Controls.Add(this.chkBoite);
            this.fraQuantité.Controls.Add(this.Label11);
            this.fraQuantité.Controls.Add(this.Label5);
            this.fraQuantité.ForeColor = System.Drawing.Color.White;
            this.fraQuantité.Location = new System.Drawing.Point(480, 152);
            this.fraQuantité.Name = "fraQuantité";
            this.fraQuantité.Padding = new System.Windows.Forms.Padding(0);
            this.fraQuantité.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraQuantité.Size = new System.Drawing.Size(233, 65);
            this.fraQuantité.TabIndex = 28;
            this.fraQuantité.TabStop = false;
            this.fraQuantité.Text = "Quantité";
            // 
            // txtQuantiteCommande
            // 
            this.txtQuantiteCommande.AcceptsReturn = true;
            this.txtQuantiteCommande.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantiteCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantiteCommande.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiteCommande.Enabled = false;
            this.txtQuantiteCommande.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantiteCommande.Location = new System.Drawing.Point(192, 40);
            this.txtQuantiteCommande.MaxLength = 0;
            this.txtQuantiteCommande.Name = "txtQuantiteCommande";
            this.txtQuantiteCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantiteCommande.Size = new System.Drawing.Size(33, 15);
            this.txtQuantiteCommande.TabIndex = 36;
            this.txtQuantiteCommande.Leave += new System.EventHandler(this.txtQuantiteCommande_Leave);
            // 
            // chkMinimum
            // 
            this.chkMinimum.BackColor = System.Drawing.Color.Black;
            this.chkMinimum.ForeColor = System.Drawing.Color.White;
            this.chkMinimum.Location = new System.Drawing.Point(120, 16);
            this.chkMinimum.Name = "chkMinimum";
            this.chkMinimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkMinimum.Size = new System.Drawing.Size(74, 17);
            this.chkMinimum.TabIndex = 31;
            this.chkMinimum.Text = "Minimum :";
            this.chkMinimum.UseVisualStyleBackColor = true;
            this.chkMinimum.CheckStateChanged += new System.EventHandler(this.chkMinimum_CheckStateChanged);
            // 
            // txtQuantiteStock
            // 
            this.txtQuantiteStock.AcceptsReturn = true;
            this.txtQuantiteStock.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantiteStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantiteStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiteStock.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantiteStock.Location = new System.Drawing.Point(80, 40);
            this.txtQuantiteStock.MaxLength = 0;
            this.txtQuantiteStock.Name = "txtQuantiteStock";
            this.txtQuantiteStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantiteStock.Size = new System.Drawing.Size(33, 15);
            this.txtQuantiteStock.TabIndex = 33;
            this.txtQuantiteStock.Leave += new System.EventHandler(this.txtQuantiteStock_Leave);
            // 
            // txtQuantiteMinimum
            // 
            this.txtQuantiteMinimum.AcceptsReturn = true;
            this.txtQuantiteMinimum.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantiteMinimum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantiteMinimum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiteMinimum.Enabled = false;
            this.txtQuantiteMinimum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantiteMinimum.Location = new System.Drawing.Point(192, 16);
            this.txtQuantiteMinimum.MaxLength = 0;
            this.txtQuantiteMinimum.Name = "txtQuantiteMinimum";
            this.txtQuantiteMinimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantiteMinimum.Size = new System.Drawing.Size(33, 15);
            this.txtQuantiteMinimum.TabIndex = 32;
            this.txtQuantiteMinimum.Leave += new System.EventHandler(this.txtQuantiteMinimum_Leave);
            // 
            // txtQuantitéBoite
            // 
            this.txtQuantitéBoite.AcceptsReturn = true;
            this.txtQuantitéBoite.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantitéBoite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantitéBoite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantitéBoite.Enabled = false;
            this.txtQuantitéBoite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantitéBoite.Location = new System.Drawing.Point(80, 16);
            this.txtQuantitéBoite.MaxLength = 0;
            this.txtQuantitéBoite.Name = "txtQuantitéBoite";
            this.txtQuantitéBoite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantitéBoite.Size = new System.Drawing.Size(33, 15);
            this.txtQuantitéBoite.TabIndex = 30;
            this.txtQuantitéBoite.Leave += new System.EventHandler(this.txtQuantitéBoite_Leave);
            // 
            // chkBoite
            // 
            this.chkBoite.BackColor = System.Drawing.Color.Black;
            this.chkBoite.ForeColor = System.Drawing.Color.White;
            this.chkBoite.Location = new System.Drawing.Point(8, 16);
            this.chkBoite.Name = "chkBoite";
            this.chkBoite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBoite.Size = new System.Drawing.Size(73, 17);
            this.chkBoite.TabIndex = 29;
            this.chkBoite.Text = "Par Boîte :";
            this.chkBoite.UseVisualStyleBackColor = true;
            this.chkBoite.CheckStateChanged += new System.EventHandler(this.chkBoite_CheckStateChanged);
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Black;
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(120, 40);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(73, 17);
            this.Label11.TabIndex = 35;
            this.Label11.Text = "À commander :";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(8, 40);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(73, 17);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Stock :";
            // 
            // cmbLocalisation
            // 
            this.cmbLocalisation.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLocalisation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLocalisation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbLocalisation.Location = new System.Drawing.Point(368, 200);
            this.cmbLocalisation.Name = "cmbLocalisation";
            this.cmbLocalisation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbLocalisation.Size = new System.Drawing.Size(105, 22);
            this.cmbLocalisation.TabIndex = 39;
            this.cmbLocalisation.SelectedIndexChanged += new System.EventHandler(this.cmbLocalisation_SelectedIndexChanged);
            // 
            // txtLocalisation
            // 
            this.txtLocalisation.AcceptsReturn = true;
            this.txtLocalisation.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocalisation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalisation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLocalisation.Location = new System.Drawing.Point(368, 200);
            this.txtLocalisation.MaxLength = 0;
            this.txtLocalisation.Name = "txtLocalisation";
            this.txtLocalisation.ReadOnly = true;
            this.txtLocalisation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLocalisation.Size = new System.Drawing.Size(105, 22);
            this.txtLocalisation.TabIndex = 40;
            this.txtLocalisation.Text = "Text1";
            // 
            // cmdRechercheAchat
            // 
            this.cmdRechercheAchat.BackColor = System.Drawing.Color.Black;
            this.cmdRechercheAchat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdRechercheAchat.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.cmdRechercheAchat.ForeColor = System.Drawing.Color.White;
            this.cmdRechercheAchat.Location = new System.Drawing.Point(222, 201);
            this.cmdRechercheAchat.Name = "cmdRechercheAchat";
            this.cmdRechercheAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercheAchat.Size = new System.Drawing.Size(127, 24);
            this.cmdRechercheAchat.TabIndex = 80;
            this.cmdRechercheAchat.Text = "Recherche dans achats";
            this.cmdRechercheAchat.UseVisualStyleBackColor = true;
            this.cmdRechercheAchat.Click += new System.EventHandler(this.cmdRechercheAchat_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Black;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(368, 184);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(65, 17);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Localisation :";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(256, 8);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(121, 17);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Catégorie de pièce :";
            // 
            // _Label1_25
            // 
            this._Label1_25.BackColor = System.Drawing.Color.Black;
            this._Label1_25.ForeColor = System.Drawing.Color.White;
            this._Label1_25.Location = new System.Drawing.Point(32, 152);
            this._Label1_25.Name = "_Label1_25";
            this._Label1_25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_25.Size = new System.Drawing.Size(113, 17);
            this._Label1_25.TabIndex = 23;
            this._Label1_25.Text = "Pièce GRB :";
            // 
            // _Label1_6
            // 
            this._Label1_6.BackColor = System.Drawing.Color.Black;
            this._Label1_6.ForeColor = System.Drawing.Color.White;
            this._Label1_6.Location = new System.Drawing.Point(296, 128);
            this._Label1_6.Name = "_Label1_6";
            this._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_6.Size = new System.Drawing.Size(81, 17);
            this._Label1_6.TabIndex = 22;
            this._Label1_6.Text = "Commentaire :";
            // 
            // _Label1_4
            // 
            this._Label1_4.BackColor = System.Drawing.Color.Black;
            this._Label1_4.ForeColor = System.Drawing.Color.White;
            this._Label1_4.Location = new System.Drawing.Point(296, 96);
            this._Label1_4.Name = "_Label1_4";
            this._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_4.Size = new System.Drawing.Size(73, 17);
            this._Label1_4.TabIndex = 20;
            this._Label1_4.Text = "Desc. EN :";
            // 
            // _Label1_3
            // 
            this._Label1_3.BackColor = System.Drawing.Color.Black;
            this._Label1_3.ForeColor = System.Drawing.Color.White;
            this._Label1_3.Location = new System.Drawing.Point(296, 64);
            this._Label1_3.Name = "_Label1_3";
            this._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_3.Size = new System.Drawing.Size(73, 17);
            this._Label1_3.TabIndex = 12;
            this._Label1_3.Text = "Desc. FR :";
            // 
            // _Label1_1
            // 
            this._Label1_1.BackColor = System.Drawing.Color.Black;
            this._Label1_1.ForeColor = System.Drawing.Color.White;
            this._Label1_1.Location = new System.Drawing.Point(32, 64);
            this._Label1_1.Name = "_Label1_1";
            this._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_1.Size = new System.Drawing.Size(89, 17);
            this._Label1_1.TabIndex = 7;
            this._Label1_1.Text = "Manufacturier :";
            // 
            // _Label1_0
            // 
            this._Label1_0.BackColor = System.Drawing.Color.Black;
            this._Label1_0.ForeColor = System.Drawing.Color.White;
            this._Label1_0.Location = new System.Drawing.Point(32, 120);
            this._Label1_0.Name = "_Label1_0";
            this._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_0.Size = new System.Drawing.Size(73, 17);
            this._Label1_0.TabIndex = 16;
            this._Label1_0.Text = "Pièce :";
            // 
            // CatalogueMec
            // 
            this.AcceptButton = this.CmdEnr;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(723, 442);
            this.Controls.Add(this.lvwRechercheAchat);
            this.Controls.Add(this.lvwRechercheJob);
            this.Controls.Add(this.lvwPieces);
            this.Controls.Add(this.lvwDescription);
            this.Controls.Add(this.lvwFabricant);
            this.Controls.Add(this.cmdRechercheCategorie);
            this.Controls.Add(this.lvwCategorie);
            this.Controls.Add(this.cmdRechercheJob);
            this.Controls.Add(this.cmdCopier);
            this.Controls.Add(this.cmdTotal);
            this.Controls.Add(this.cmdRechercheInventaire);
            this.Controls.Add(this.cmdChangerCategorie);
            this.Controls.Add(this.cmdDemande);
            this.Controls.Add(this.cmdRechercheDescrFR);
            this.Controls.Add(this.frafournisseur);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.txtNoItemGRB);
            this.Controls.Add(this.cmbNoItem);
            this.Controls.Add(this.CmdModif);
            this.Controls.Add(this.CmdFerme);
            this.Controls.Add(this.CmdSupp);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbFabricant);
            this.Controls.Add(this.txtFabricant);
            this.Controls.Add(this.txtDescriptionEN);
            this.Controls.Add(this.txtDescriptionFR);
            this.Controls.Add(this.txtNoItem);
            this.Controls.Add(this.CmdAnul);
            this.Controls.Add(this.CmdEnr);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.cmdRechercherPiece);
            this.Controls.Add(this.cmbDescriptionFR);
            this.Controls.Add(this.cmdRechercherManufact);
            this.Controls.Add(this.chkInventaire);
            this.Controls.Add(this.fraQuantité);
            this.Controls.Add(this.cmbLocalisation);
            this.Controls.Add(this.txtLocalisation);
            this.Controls.Add(this.cmdRechercheAchat);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this._Label1_25);
            this.Controls.Add(this._Label1_6);
            this.Controls.Add(this._Label1_4);
            this.Controls.Add(this._Label1_3);
            this.Controls.Add(this._Label1_1);
            this.Controls.Add(this._Label1_0);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(97, 68);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CatalogueMec";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.CatalogueMec";
            this.Load += new System.EventHandler(this.FrCatalogueMec_Load);
            this.Click += new System.EventHandler(this.FrCatalogueMec_Click);
            this.frafournisseur.ResumeLayout(false);
            this.frafournisseur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpain)).EndInit();
            this.fraQuantité.ResumeLayout(false);
            this.fraQuantité.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
                txtDescriptionFR.Text = cmbDescriptionFR.Text;
                if (m_bBloqueDescription == false)
                {
                    var loopTo = (short)(cmbNoItem.Items.Count - 1);
                    for (X = 0; X <= loopTo; X++)
                    {
                        if (cmbNoItem.Items[X].ToString() == m_collPieceDescFR[cmbDescriptionFR.SelectedIndex + 1])
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
                txtLocalisation.Text = cmbLocalisation.Text;
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
                sNomFab = txtFabricant.Text;
                sNoPiece = txtNoItem.Text;
                if (m_bCopiePiece == true | m_bCopiePiece == false & (Strings.UCase(sNoPiece) ?? "") != (Strings.UCase(m_sNoItem) ?? ""))
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
                        rstItemFRS.Fields["PIECE"].Value = txtNoItem.Text;
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
                rstItem.Fields["CATEGORIE"].Value = txtCategorie.Text;
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
                rstItem.Fields["PIECE_GRB"].Value = txtNoItemGRB.Text;
                rstItem.Fields["DESC_EN"].Value = txtDescriptionEN.Text;
                rstItem.Fields["DESC_FR"].Value = txtDescriptionFR.Text;
                rstItem.Fields["COMMENTAIRE"].Value = txtComment.Text;
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
                    rstInventaire.Fields["NoItem"].Value = txtNoItem.Text;
                    rstInventaire.Fields["Description"].Value = txtDescriptionFR.Text;
                    rstInventaire.Fields["Manufacturier"].Value = sNomFab;
                    if (chkBoite.CheckState == CheckState.Checked)
                    {
                        rstInventaire.Fields["CommandeParBoite"].Value = true;
                        rstInventaire.Fields["QteBoite"].Value = txtQuantitéBoite.Text;
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
                        rstItemFRS.Fields["PIECE"].Value = txtNoItem.Text;
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
                    rstInventaire.Fields["Commentaires"].Value = txtComment.Text;
                    rstInventaire.Fields["Localisation"].Value = cmbLocalisation.Text;
                    if (!string.IsNullOrEmpty(Strings.Trim(txtQuantiteStock.Text)))
                    {
                        rstInventaire.Fields["QuantitéStock"].Value = txtQuantiteStock.Text;
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
                            rstInventaire.Fields["QuantitéMinimum"].Value = txtQuantiteMinimum.Text;
                        }
                        else
                        {
                            rstInventaire.Fields["QuantitéMinimum"].Value = "0";
                        }
                        if (Conversions.ToBoolean(Strings.Trim(txtQuantiteCommande.Text)) == true)
                        {
                            rstInventaire.Fields["Commande"].Value = txtQuantiteCommande.Text;
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
                    if ((txtQuantiteStock.Text ?? "") != (m_sQteStockAvant ?? "") | !string.IsNullOrEmpty(m_sQteStockAvant) & m_sQteStockAvant != "0" & chkInventaire.CheckState == CheckState.Unchecked)
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
                        rstInvModif.Fields["NoItem"].Value = txtNoItem.Text;
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
                if ((Strings.UCase(sNoPiece) ?? "") != (Strings.UCase(m_sNoItem) ?? "") & m_bCopiePiece == false)
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
                        rstPiece.Open("SELECT * FROM CatalogueMec WHERE PIECE = '" + cmbNoItem.Text.Replace("'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                        rstPiece.Fields["CATEGORIE"].Value = m_sCategorieCopie;
                        rstPiece.Update();
                        rstPiece.Close();
                        rstPiece = null;
                        ViderChamps_piece();
                        m_sSelectFabricant = txtFabricant.Text;
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
                    ChoixDemande cd = new ChoixDemande(EnumCatalogue.MECANIQUE, m_eDemande);
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
                if ((Strings.UCase(txtNoItem.Text) ?? "") != (Strings.UCase(m_sNoItem) ?? "") & m_bCopiePiece == false)
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
                if (optUSA.Checked == true | optSpain.Checked == true)
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
                    rstItemFRS.Open(Operators.ConcatenateObject("SELECT * FROM PiecesFRS WHERE noEnreg = ", lvwfournisseur.FocusedItem.Tag), odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                }
                rstItemFRS.Fields["PIECE"].Value = cmbNoItem.Text;
                rstItemFRS.Fields["IDFRS"].Value = cmbfrs.Tag;
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
                rstItemFRS.Fields["PRIX_LIST"].Value = txtPrixList.Text;
                rstItemFRS.Fields["ESCOMPTE"].Value = mskEscompte.Text;
                if (!string.IsNullOrEmpty(txtPrixSpecial.Text) | !string.IsNullOrEmpty(txtPrixNet.Text))
                {
                    if (!string.IsNullOrEmpty(txtPrixNet.Text))
                    {
                        rstItemFRS.Fields["PRIX_NET"].Value = txtPrixNet.Text;
                        rstItemFRS.Fields["PrixReel"].Value = txtPrixNet.Text;
                    }
                    else
                    {
                        rstItemFRS.Fields["PRIX_NET"].Value = string.Empty;
                    }
                    if (!string.IsNullOrEmpty(txtPrixSpecial.Text))
                    {
                        rstItemFRS.Fields["PRIX_SP"].Value = txtPrixSpecial.Text;
                        rstItemFRS.Fields["PrixReel"].Value = txtPrixNet.Text;
                    }
                    else
                    {
                        rstItemFRS.Fields["PRIX_SP"].Value = string.Empty;
                    }
                }
                rstItemFRS.Fields["DATE"].Value = ConvertDate(DateTime.Today);
                rstItemFRS.Fields["VALIDE"].Value = mskValide.Text;
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
                if (optUSA.Checked == true | optSpain.Checked == true)
                {
                    rstConfig = new ADODB.Recordset();
                    rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    if (optUSA.Checked == true)
                    {
                        rstConfig.Fields["TauxAmericain"].Value = txtTauxChange.Text;
                    }
                    else
                    {
                        rstConfig.Fields["TauxEspagnol"].Value = txtTauxChange.Text;
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
                                rstInv.Fields["Escompte"].Value = mskEscompte.Text;
                                rstInv.Fields["Prix net"].Value = Operators.DivideObject(double.Parse(txtPrixNet.Text), rstInv.Fields["QteBoite"].Value);
                            }
                            else
                            {
                                rstInv.Fields["Prix Liste"].Value = txtPrixList.Text;
                                rstInv.Fields["Escompte"].Value = mskEscompte.Text;
                                rstInv.Fields["Prix net"].Value = txtPrixNet.Text;
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
                            rstInv.Fields["Prix Liste"].Value = txtPrixSpecial.Text;
                            rstInv.Fields["Escompte"].Value = "";
                            rstInv.Fields["Prix net"].Value = txtPrixSpecial.Text;
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
                    m_sQteStockAvant = txtQuantiteStock.Text;
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
            ADODB.Recordset rstcatalog= new ADODB.Recordset();
            ListViewItem itmDescription;
             string sDescription = Interaction.InputBox("Quelle est la catégorie à rechercher");
            if (!string.IsNullOrEmpty(sDescription))
            {
                lvwCategorie.Items.Clear();
                sDescription = Strings.Replace(sDescription, "'", "''");
                rstcatalog.Open("SELECT DISTINCT CATEGORIE FROM CatalogueMec WHERE  Categorie LIKE '%" + sDescription + "%'  ORDER BY CATEGORIE", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                while (!rstcatalog.EOF)
                {
                    itmDescription = lvwCategorie.Items.Add("");
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
                        itmDescription = lvwDescription.Items.Add(string.Empty);
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
                    itmProjSoum = lvwRechercheJob.Items.Add(string.Empty);
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
                    itmProjSoum = lvwRechercheJob.Items.Add(string.Empty);
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
                    itmAchat = lvwRechercheAchat.Items.Add(string.Empty);
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
                    rstManufact.Open("SELECT * FROM CatalogueMec WHERE FABRICANT like '%" + sManufact + "%' ORDER BY FABRICANT", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    while (!rstManufact.EOF)
                    {
                        itmManufact = lvwFabricant.Items.Add("");
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
                double dbTotal = 0d; // sert pour l'émulation SUM(QTÉ)
                sAnnee = Interaction.InputBox("Pour quelle année? (AAAA)");
                if (Strings.Len(sAnnee) == 4)
                {
                    if (IsNumeric(sAnnee))
                    {
                        if (Conversions.ToShort(sAnnee) <= System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today))
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            rstTotal = new ADODB.Recordset();
                            rstTotal.Open("SELECT Qté FROM Projet_Pieces " +// sum ne marche pas sur un nvarchar en SQL
                                "INNER JOIN ProjetMec ON Projet_Pieces.IDProjet = ProjetMec.IDProjet WHERE TRIM(NumItem) = '" + Strings.Trim(Strings.Replace(txtNoItem.Text, "'", "''")) + "' AND Type = 'M' AND Left(Creer, 4) = '" + sAnnee + "' AND RIGHT(Projet_Pieces.IDProjet,2) < '60'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                            while (!rstTotal.EOF)
                            {
                                if(!(rstTotal.Fields is DBNull))
                                {
                                    dbTotal += double.Parse(rstTotal.Fields[0].Value);
                                }
                            }
                            if (dbTotal > 0) { 
                                dblTotalProj = dbTotal;
                            }
                            else
                            {
                                dblTotalProj = 0d;
                            }
                            rstTotal.Close();
                            rstTotal.Open("SELECT SUM(Qté) As Total FROM Achat_Pieces " +
                                "INNER JOIN Achat ON Achat_Pieces.IDAchat = Achat.IDAchat AND Achat_Pieces.IndexAchat = Achat.IndexAchat" +
                                " WHERE TRIM(PIECE) = '" + Strings.Trim(Strings.Replace(txtNoItem.Text, "'", "''")) + "' AND Left(DateAchat,4) = '" + sAnnee + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                            dbTotal = 0d;
                            while (!rstTotal.EOF)
                            {
                                if (!(rstTotal.Fields is DBNull))
                                {
                                    dbTotal += double.Parse(rstTotal.Fields[0].Value);
                                }
                            }
                            if (dbTotal > 0)
                            {
                                dblTotalAchat = dbTotal;
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
                lvwDescription.Visible = true;
                lvwFabricant.Visible = true;
                lvwPieces.Visible = true;
                lvwRechercheJob.Visible = true;
                lvwRechercheAchat.Visible = true;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "Form_Click", ex); }
        }
        private void frafournisseur_Click()
        {
            try
            {
                lvwDescription.Visible = true;
                lvwFabricant.Visible = true;
                lvwPieces.Visible = true;
                lvwRechercheJob.Visible = true;
                lvwRechercheAchat.Visible = true;
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "aFournisseur_Click", ex); }
        }
        private void fraQuantité_Click()
        {
            try
            {
                lvwDescription.Visible = true;
                lvwFabricant.Visible = true;
                lvwPieces.Visible = true;
                lvwRechercheJob.Visible = true;
                lvwRechercheAchat.Visible = true;
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
                itmDescription = lvwCategorie.FocusedItem;
                cmbCategorie.Text = lvwCategorie.FocusedItem.Text;
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
            var ColumnHeader = lvwFabricant.Columns[eventArgs.Column];
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
            var ColumnHeader = lvwDescription.Columns[eventArgs.Column];
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
            var ColumnHeader = lvwPieces.Columns[eventArgs.Column];
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
            var ColumnHeader = lvwRechercheJob.Columns[eventArgs.Column];
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
            var ColumnHeader = lvwRechercheAchat.Columns[eventArgs.Column];
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
                itmFabricant = lvwFabricant.FocusedItem;
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
                    itmDescription = lvwDescription.FocusedItem;
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
                    if (Interaction.MsgBox("Voulez-vous vraiment effacer la pièce " + txtNoItem.Text + "?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
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
                            m_sSelectFabricant = cmbFabricant.Text;
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
                        sDescription = txtDescriptionFR.Text;
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
                ADODB.Recordset rstItemFRS = new ADODB.Recordset();
                short X;
                rstItemFRS.Open("SELECT * FROM PiecesFRS WHERE NoEnreg = "+ lvwfournisseur.FocusedItem.Tag.ToString(), odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
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
                txtNoItem.Text = cmbNoItem.Text;
                m_sNoItem = txtNoItem.Text;
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
                txtFabricant.Text = cmbFabricant.Text;
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
                        sChoisirTous = sChoisirTous + " OR FABRICANT = '" + Strings.Trim(Conversions.ToString(rstFabricant.Fields["FABRICANT"].Value)) + "'";
                    }
                }
                rstFabricant.MoveNext();
            }
            sChoisirTous = sChoisirTous + ")";
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
            lvwPieces.Columns.Clear();
            lvwPieces.Columns.Add("FABRICANT");
            lvwPieces.Columns.Add("DESCR_FR");
            lvwPieces.Columns.Add("DESCR_EN");
            lvwPieces.Columns.Add("CATEGORIE");
            ADODB.Recordset rd = new ADODB.Recordset();
            Color lCouleur;
            lvwPieces.Items.Clear();
            lvwPieces.Visible = true;
            string sPiece = Interaction.InputBox("Quelle est la pièce à rechercher?");
            string sPieceModif = string.Empty;
            if (!string.IsNullOrEmpty(sPiece))
            {
                string sLettre = sPiece;
                for (int X = 1; X <= sPiece.Length; X++)
                {
                    if (sLettre[X] >= 48 & sLettre[X] <= 57 | sLettre[X] >= 65 & sLettre[X] <= 90 | sLettre[X] >= 97 & sLettre[X] <= 122)
                    {
                        sPieceModif += sLettre;
                    }
                }
            }
                rd.Open("SELECT * FROM CatalogueMec WHERE  PIECE_MODIF like '%" + sPieceModif + "%' ORDER BY PIECE", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            if (rd.EOF) return; ///pour pas planter par une erreur SQl avec champs vide vue que c le firstStart
            while (!rd.EOF)
            {
                ListViewItem itm = lvwPieces.Items.Add(string.Empty);
                if (rd.Fields["DeviseMonétaire"].Value == "CAN")
                {
                    lCouleur = (COLOR_ROUGE);
                }
                else
                {
                    lCouleur = (COLOR_BLEU);
                }
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                if (rd.Fields[2].Value is DBNull)
                {
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                }
                else
                {
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                    itm.ForeColor = (lCouleur);
                }
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, rd.Fields[3].Value));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                if ($"{rd.Fields[6].Value}" == "0")
                { itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"0.00$")); }
                else
                {
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}$"));
                }
                if (rd.Fields[7].Value == "0")
                {
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"0.00%"));
                }
                else
                {
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}%"));

                }
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}$"));
                if (rd.Fields[8].Value == "0") { itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"0.00$")); }
                itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[9].Value}"));
                if ((bool)rd.Fields[10].Value == true)
                {
                    itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"Oui"));

                }
                else
                {
                    itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"Non"));

                }
                itm.SubItems.Insert(10, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[12].Value}"));
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            return;
            /*       try
                   {
                       ADODB.Recordset rstPiece;
                       string sPiece;
                       ListViewItem itmPiece;
                       short X;
                       var sPieceModif = default();
                      
                            rstPiece = new ADODB.Recordset();
                           rstPiece.Open("", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                           while (!rstPiece.EOF)
                           {
                               itmPiece = lvwPieces.Items.Add(string.Empty);
                               itmPiece.Text = Conversions.ToString(rstPiece.Fields["PIECE"].Value);
                               if (!(rstPiece.Fields["FABRICANT"].Value is DBNull))
                               {
                                   if (itmPiece.SubItems.Count > I_COL_PIECE_)
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
                                   if (itmPiece.SubItems.Count > I_COL_PIECE_)
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
                                   if (itmPiece.SubItems.Count > I_COL_PIECE_)
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
            */
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
                if (cmbCategorie.Text == "Équipements et outillages - Sécurité/nettoyage" | cmbCategorie.Text == "Quincaillerie - Boulons Hex. (Bolts) 1/4-20" | cmbCategorie.Text == "Quincaillerie - Rondelle plate (Washer)" | sChoisirTous == ")")
                {
                    rstNoItem.Open("SELECT PIECE FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstNoItem.Open("SELECT PIECE FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "'" + sChoisirTous + " ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
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
            lvwfournisseur.Columns.Clear();
            lvwfournisseur.Columns.Add("Fournisseur");
            lvwfournisseur.Columns.Add("Pers. Ress.");
            lvwfournisseur.Columns.Add("Date");
            lvwfournisseur.Columns.Add("Par");
            lvwfournisseur.Columns.Add("Valide");
            lvwfournisseur.Columns.Add("Prix listé");
            lvwfournisseur.Columns.Add("Escompte");
            lvwfournisseur.Columns.Add("Prix net");
            lvwfournisseur.Columns.Add("Prix spécial");
            lvwfournisseur.Columns.Add("Quoter");
            lvwfournisseur.Columns.Add("Position");
            ADODB.Recordset rd = new ADODB.Recordset();
            Color lCouleur;
            lvwfournisseur.Items.Clear();
            lvwfournisseur.Visible = true;
            CalculerPrixReel(txtNoItem.Text);
            rd.Open("SELECT DISTINCT [NOMFOURNISSEUR],'',[PERS_RESS],[DATE],[ENTRER_PAR],[VALIDE],[PRIX_LIST],[ESCOMPTE],[PRIX_NET],[PRIX_SP]," +
                "[QUOTER],[DEVISEMONÉTAIRE], PIECESFRS.[NOENREG] ,[PRIXREEL] FROM [DBO].[PIECESFRS] " +
                "INNER JOIN FOURNISSEUR ON PIECESFRS.IDFRS = FOURNISSEUR.IDFRS " +
                " WHERE PIECE = '" + cmbNoItem.Text +
                "' AND TYPE = 'M' ORDER BY PRIXREEL", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            if (rd.EOF) return; ///pour pas planter par une erreur SQl avec champs vide vue que c le firstStart
            while (!rd.EOF)
            {
                ListViewItem itm = lvwfournisseur.Items.Add(string.Empty);
                if (rd.Fields["DeviseMonétaire"].Value == "CAN")
                {
                    lCouleur = (COLOR_ROUGE);
                }
                else
                {
                    lCouleur = (COLOR_BLEU);
                }
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                if (rd.Fields[2].Value is DBNull)
                {
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                }
                else
                {
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                    itm.ForeColor = (lCouleur);
                }
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, rd.Fields[3].Value));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                if ($"{rd.Fields[6].Value}" == "0")
                { itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"0.00$")); }
                else { 
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}$"));
                }
                if (rd.Fields[7].Value == "0")
                {
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"0.00%"));
                }else{
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}%"));

                }
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}$"));
                if (rd.Fields[8].Value == "0") { itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"0.00$")); }
                itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[9].Value}"));
                if ((bool)rd.Fields[10].Value == true)
                {
                    itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"Oui"));

                }
                else
                {
                    itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"Non"));

                }
                itm.SubItems.Insert(10, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[12].Value}"));
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            return;
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
                if (Interaction.MsgBox("Voulez-vous vraiment effacer le fournisseur " + lvwfournisseur.FocusedItem.Text + "?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
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
                itmPieces = lvwPieces.FocusedItem;
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
                txtCategorie.Text = cmbCategorie.Text;
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
            if (m_collPieceDescFR.Count > 0) m_collPieceDescFR.Clear();
            cmbDescriptionFR.Items.Clear();
            sCategorie = Strings.Replace(cmbCategorie.Text, "'", "''");
            sFabricant = Strings.Replace(cmbFabricant.Text, "'", "''");
            rstCatMec = new ADODB.Recordset();
            if (sFabricant == "-- CHOISIR TOUS --")
            {
                if (cmbCategorie.Text == "Équipements et outillages - Sécurité/nettoyage" | cmbCategorie.Text == "Quincaillerie - Boulons Hex. (Bolts) 1/4-20" | cmbCategorie.Text == "Quincaillerie - Rondelle plate (Washer)" | sChoisirTous == ")")
                {
                    rstCatMec.Open("SELECT * FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstCatMec.Open("SELECT * FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "'" + sChoisirTous + " ORDER BY TRIM(PIECE)", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
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
                    cmbfrs.Items.Add($"{rstPieceFRS.Fields["IDFRS"].Value}-{rstPieceFRS.Fields["NomFournisseur"].Value}");
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
                if (!IsNumeric(txtQuantitéBoite.Text) | txtQuantitéBoite.Text == "0")
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
                txtQuantiteCommande.Text = txtQuantiteCommande.Text.Replace(".", ",");
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtQuantiteCommande_LostFocus", ex); }
        }
        private void txtQuantiteMinimum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtQuantiteMinimum.Text = txtQuantiteMinimum.Text.Replace(".", ",");
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtQuantiteMinimum_LostFocus", ex); }
        }
        private void txtQuantiteStock_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtQuantiteStock.Text = txtQuantiteStock.Text.Replace(".", ",");
                return;
            }
            catch (Exception ex) { AfficherErreur("CatalogueMec", "txtQuantiteStock_LostFocus", ex); }
        }
    }
}