using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using System.Diagnostics;
using ControleurServeur;
using ADODB;
using System.Collections.Generic;
using System.Security.Policy;
using Microsoft.Office.Interop.Outlook;
using Exception = System.Exception;
using Application = System.Windows.Forms.Application;
using System.Drawing;
using Microsoft.Extensions.Logging;
#pragma warning disable CS0414
namespace ControleurServeur
{
    internal class ChoixDemande : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixDemande() : base()
        {
            InitializeComponent();
        }
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!(components is null)){components.Dispose();}
            }
            base.Dispose(Disposing);
        }
        private System.ComponentModel.IContainer components;
        internal ToolTip ToolTip1;
        internal ColumnHeader _lvwCategorie_ColumnHeader_1;
        internal ListView lvwCategorie;
        internal ColumnHeader _lvwPiece_ColumnHeader_1;
        internal ColumnHeader _lvwPiece_ColumnHeader_2;
        internal ColumnHeader _lvwPiece_ColumnHeader_3;
        internal ColumnHeader _lvwPiece_ColumnHeader_4;
        internal ColumnHeader _lvwPiece_ColumnHeader_5;
        internal ListView lvwPiece;
        internal Button cmdDeselectAll;
        internal Button cmdSelectAll;
        internal ComboBox cmbTri;
        internal Button cmdRechercher;
        internal TextBox txtRechercher;
        internal Button cmdRafraichir;
        internal Button cmdTri;
        internal Button cmdFermer;
        internal TextBox txtCommentaire;
        internal TextBox txtNoGRB;
        internal MaskedTextBox mskDateRequise;
        internal Button cmdLangage;
        internal ComboBox cmbCategorie;
        internal Button cmdImprimer;
        internal Button cmdOK;
        internal ComboBox cmbManufacturier;
        internal TextBox txtNoPiece;
        internal TextBox txtDescription;
        internal Button cmdAjouter;
        internal ColumnHeader _lvwManufacturier_ColumnHeader_1;
        internal ListView lvwManufacturier;
        internal ColumnHeader _lvwNouvellesPieces_ColumnHeader_1;
        internal ColumnHeader _lvwNouvellesPieces_ColumnHeader_2;
        internal ColumnHeader _lvwNouvellesPieces_ColumnHeader_3;
        internal ColumnHeader _lvwNouvellesPieces_ColumnHeader_4;
        internal ColumnHeader _lvwNouvellesPieces_ColumnHeader_5;
        internal ListView lvwNouvellesPieces;
        internal ColumnHeader _lvwFournisseur_ColumnHeader_1;
        internal ColumnHeader _lvwFournisseur_ColumnHeader_2;
        internal ListView lvwFournisseur;
        internal Label lblFormatDate;
        internal Label lblDescription;
        internal Label lblManufacturier;
        internal Label lblNoPiece;
        internal Label lblCommentaire;
        internal Label lblNoGRB;
        internal Label lblDateRequise;
        internal Label lblCategorie;
        internal Label label1;
        internal ComboBox comboBox1;
        internal static bool Télécommande;
        internal static ListView.SelectedListViewItemCollection items;
        #endregion
        private enum EnumType{TYPE_PROJET = 0,TYPE_SOUMISSION = 1}
        private enum EnumMode{Fournisseur = 0,PIECE = 1,Categorie = 2,NOUVELLE_PIECE = 3,Manufacturier = 4}
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lvwCategorie = new System.Windows.Forms.ListView();
            this._lvwCategorie_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwPiece = new System.Windows.Forms.ListView();
            this._lvwPiece_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwPiece_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwPiece_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwPiece_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwPiece_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdDeselectAll = new System.Windows.Forms.Button();
            this.cmdSelectAll = new System.Windows.Forms.Button();
            this.cmbTri = new System.Windows.Forms.ComboBox();
            this.cmdRechercher = new System.Windows.Forms.Button();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.cmdRafraichir = new System.Windows.Forms.Button();
            this.cmdTri = new System.Windows.Forms.Button();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.txtNoGRB = new System.Windows.Forms.TextBox();
            this.mskDateRequise = new System.Windows.Forms.MaskedTextBox();
            this.cmdLangage = new System.Windows.Forms.Button();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmbManufacturier = new System.Windows.Forms.ComboBox();
            this.txtNoPiece = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.lvwManufacturier = new System.Windows.Forms.ListView();
            this._lvwManufacturier_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwNouvellesPieces = new System.Windows.Forms.ListView();
            this._lvwNouvellesPieces_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwNouvellesPieces_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwNouvellesPieces_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwNouvellesPieces_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwNouvellesPieces_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwFournisseur = new System.Windows.Forms.ListView();
            this._lvwFournisseur_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwFournisseur_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFormatDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblManufacturier = new System.Windows.Forms.Label();
            this.lblNoPiece = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.lblNoGRB = new System.Windows.Forms.Label();
            this.lblDateRequise = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvwCategorie
            // 
            this.lvwCategorie.BackColor = System.Drawing.Color.Black;
            this.lvwCategorie.CheckBoxes = true;
            this.lvwCategorie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwCategorie_ColumnHeader_1});
            this.lvwCategorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwCategorie.ForeColor = System.Drawing.Color.White;
            this.lvwCategorie.FullRowSelect = true;
            this.lvwCategorie.GridLines = true;
            this.lvwCategorie.HideSelection = false;
            this.lvwCategorie.Location = new System.Drawing.Point(8, 51);
            this.lvwCategorie.Name = "lvwCategorie";
            this.lvwCategorie.Size = new System.Drawing.Size(682, 258);
            this.lvwCategorie.TabIndex = 6;
            this.lvwCategorie.UseCompatibleStateImageBehavior = false;
            this.lvwCategorie.View = System.Windows.Forms.View.Details;
            this.lvwCategorie.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwCategorie_ColumnClick);
            this.lvwCategorie.SelectedIndexChanged += new System.EventHandler(this.lvwCategorie_SelectedIndexChanged);
            // 
            // _lvwCategorie_ColumnHeader_1
            // 
            this._lvwCategorie_ColumnHeader_1.Text = "CatégorieFournisseur";
            this._lvwCategorie_ColumnHeader_1.Width = 821;
            // 
            // lvwPiece
            // 
            this.lvwPiece.BackColor = System.Drawing.Color.Black;
            this.lvwPiece.CheckBoxes = true;
            this.lvwPiece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwPiece_ColumnHeader_1,
            this._lvwPiece_ColumnHeader_2,
            this._lvwPiece_ColumnHeader_3,
            this._lvwPiece_ColumnHeader_4,
            this._lvwPiece_ColumnHeader_5});
            this.lvwPiece.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPiece.ForeColor = System.Drawing.Color.White;
            this.lvwPiece.FullRowSelect = true;
            this.lvwPiece.GridLines = true;
            this.lvwPiece.HideSelection = false;
            this.lvwPiece.Location = new System.Drawing.Point(8, 64);
            this.lvwPiece.Name = "lvwPiece";
            this.lvwPiece.Size = new System.Drawing.Size(859, 265);
            this.lvwPiece.TabIndex = 13;
            this.lvwPiece.UseCompatibleStateImageBehavior = false;
            this.lvwPiece.View = System.Windows.Forms.View.Details;
            this.lvwPiece.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwPiece_ColumnClick);
            this.lvwPiece.DoubleClick += new System.EventHandler(this.lvwPiece_DoubleClick);
            // 
            // _lvwPiece_ColumnHeader_1
            // 
            this._lvwPiece_ColumnHeader_1.Text = "Quantité";
            this._lvwPiece_ColumnHeader_1.Width = 170;
            // 
            // _lvwPiece_ColumnHeader_2
            // 
            this._lvwPiece_ColumnHeader_2.Text = "Pièce";
            this._lvwPiece_ColumnHeader_2.Width = 170;
            // 
            // _lvwPiece_ColumnHeader_3
            // 
            this._lvwPiece_ColumnHeader_3.Text = "Description française";
            this._lvwPiece_ColumnHeader_3.Width = 170;
            // 
            // _lvwPiece_ColumnHeader_4
            // 
            this._lvwPiece_ColumnHeader_4.Text = "Description anglaise";
            this._lvwPiece_ColumnHeader_4.Width = 170;
            // 
            // _lvwPiece_ColumnHeader_5
            // 
            this._lvwPiece_ColumnHeader_5.Text = "Fabricant";
            this._lvwPiece_ColumnHeader_5.Width = 170;
            // 
            // cmdDeselectAll
            // 
            this.cmdDeselectAll.AutoSize = true;
            this.cmdDeselectAll.BackColor = System.Drawing.Color.Black;
            this.cmdDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDeselectAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeselectAll.ForeColor = System.Drawing.Color.White;
            this.cmdDeselectAll.Location = new System.Drawing.Point(63, 345);
            this.cmdDeselectAll.Name = "cmdDeselectAll";
            this.cmdDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDeselectAll.Size = new System.Drawing.Size(53, 25);
            this.cmdDeselectAll.TabIndex = 20;
            this.cmdDeselectAll.Text = "Aucun";
            this.cmdDeselectAll.UseVisualStyleBackColor = true;
            this.cmdDeselectAll.Click += new System.EventHandler(this.cmdDeSelectAll_Click);
            // 
            // cmdSelectAll
            // 
            this.cmdSelectAll.AutoSize = true;
            this.cmdSelectAll.BackColor = System.Drawing.Color.Black;
            this.cmdSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSelectAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectAll.ForeColor = System.Drawing.Color.White;
            this.cmdSelectAll.Location = new System.Drawing.Point(8, 345);
            this.cmdSelectAll.Name = "cmdSelectAll";
            this.cmdSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSelectAll.Size = new System.Drawing.Size(49, 26);
            this.cmdSelectAll.TabIndex = 19;
            this.cmdSelectAll.Text = "Tous";
            this.cmdSelectAll.UseVisualStyleBackColor = true;
            this.cmdSelectAll.Click += new System.EventHandler(this.cmdSelectAll_Click);
            // 
            // cmbTri
            // 
            this.cmbTri.BackColor = System.Drawing.Color.Black;
            this.cmbTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTri.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTri.ForeColor = System.Drawing.Color.White;
            this.cmbTri.Items.AddRange(new object[] {
            "Pièce",
            "Desc. Fr",
            "Desc. An",
            "Fabricant"});
            this.cmbTri.Location = new System.Drawing.Point(296, 48);
            this.cmbTri.Name = "cmbTri";
            this.cmbTri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTri.Size = new System.Drawing.Size(129, 22);
            this.cmbTri.TabIndex = 4;
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.BackColor = System.Drawing.Color.Black;
            this.cmdRechercher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRechercher.ForeColor = System.Drawing.Color.White;
            this.cmdRechercher.Location = new System.Drawing.Point(794, 20);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercher.Size = new System.Drawing.Size(73, 25);
            this.cmdRechercher.TabIndex = 1;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = true;
            this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
            // 
            // txtRechercher
            // 
            this.txtRechercher.AcceptsReturn = true;
            this.txtRechercher.BackColor = System.Drawing.Color.Black;
            this.txtRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.Color.White;
            this.txtRechercher.Location = new System.Drawing.Point(667, 23);
            this.txtRechercher.MaxLength = 0;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRechercher.Size = new System.Drawing.Size(121, 22);
            this.txtRechercher.TabIndex = 3;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // cmdRafraichir
            // 
            this.cmdRafraichir.BackColor = System.Drawing.Color.Black;
            this.cmdRafraichir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdRafraichir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRafraichir.ForeColor = System.Drawing.Color.White;
            this.cmdRafraichir.Location = new System.Drawing.Point(512, 48);
            this.cmdRafraichir.Name = "cmdRafraichir";
            this.cmdRafraichir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRafraichir.Size = new System.Drawing.Size(65, 21);
            this.cmdRafraichir.TabIndex = 7;
            this.cmdRafraichir.Text = "Rafraichir";
            this.cmdRafraichir.UseVisualStyleBackColor = true;
            this.cmdRafraichir.Click += new System.EventHandler(this.cmdRafraichir_Click);
            // 
            // cmdTri
            // 
            this.cmdTri.BackColor = System.Drawing.Color.Black;
            this.cmdTri.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdTri.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTri.ForeColor = System.Drawing.Color.White;
            this.cmdTri.Location = new System.Drawing.Point(440, 48);
            this.cmdTri.Name = "cmdTri";
            this.cmdTri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdTri.Size = new System.Drawing.Size(65, 21);
            this.cmdTri.TabIndex = 5;
            this.cmdTri.Text = "Trier";
            this.cmdTri.UseVisualStyleBackColor = true;
            this.cmdTri.Click += new System.EventHandler(this.cmdTri_Click);
            // 
            // cmdFermer
            // 
            this.cmdFermer.BackColor = System.Drawing.Color.Black;
            this.cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermer.ForeColor = System.Drawing.Color.White;
            this.cmdFermer.Location = new System.Drawing.Point(794, 400);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFermer.Size = new System.Drawing.Size(73, 25);
            this.cmdFermer.TabIndex = 31;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.Cmdfermer_Click);
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.AcceptsReturn = true;
            this.txtCommentaire.BackColor = System.Drawing.Color.Black;
            this.txtCommentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentaire.ForeColor = System.Drawing.Color.White;
            this.txtCommentaire.Location = new System.Drawing.Point(487, 361);
            this.txtCommentaire.MaxLength = 0;
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommentaire.Size = new System.Drawing.Size(380, 33);
            this.txtCommentaire.TabIndex = 29;
            // 
            // txtNoGRB
            // 
            this.txtNoGRB.AcceptsReturn = true;
            this.txtNoGRB.BackColor = System.Drawing.Color.Black;
            this.txtNoGRB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoGRB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoGRB.ForeColor = System.Drawing.Color.White;
            this.txtNoGRB.Location = new System.Drawing.Point(336, 368);
            this.txtNoGRB.MaxLength = 0;
            this.txtNoGRB.Name = "txtNoGRB";
            this.txtNoGRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoGRB.Size = new System.Drawing.Size(81, 22);
            this.txtNoGRB.TabIndex = 27;
            // 
            // mskDateRequise
            // 
            this.mskDateRequise.AllowPromptAsInput = false;
            this.mskDateRequise.BackColor = System.Drawing.Color.Black;
            this.mskDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDateRequise.ForeColor = System.Drawing.Color.White;
            this.mskDateRequise.Location = new System.Drawing.Point(336, 344);
            this.mskDateRequise.Name = "mskDateRequise";
            this.mskDateRequise.Size = new System.Drawing.Size(81, 22);
            this.mskDateRequise.TabIndex = 23;
            this.mskDateRequise.Enter += new System.EventHandler(this.mskDateRequise_Enter);
            this.mskDateRequise.Leave += new System.EventHandler(this.mskDateRequise_Leave);
            // 
            // cmdLangage
            // 
            this.cmdLangage.BackColor = System.Drawing.Color.Black;
            this.cmdLangage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdLangage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLangage.ForeColor = System.Drawing.Color.White;
            this.cmdLangage.Location = new System.Drawing.Point(487, 400);
            this.cmdLangage.Name = "cmdLangage";
            this.cmdLangage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLangage.Size = new System.Drawing.Size(143, 25);
            this.cmdLangage.TabIndex = 21;
            this.cmdLangage.Text = "En anglais";
            this.cmdLangage.UseVisualStyleBackColor = true;
            this.cmdLangage.Click += new System.EventHandler(this.cmdLangage_Click);
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.BackColor = System.Drawing.Color.Black;
            this.cmbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCategorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorie.ForeColor = System.Drawing.Color.White;
            this.cmbCategorie.Location = new System.Drawing.Point(308, 17);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCategorie.Size = new System.Drawing.Size(249, 22);
            this.cmbCategorie.TabIndex = 2;
            this.cmbCategorie.Text = "cmbCategorie";
            this.cmbCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbCategorie_SelectedIndexChanged);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.BackColor = System.Drawing.Color.Black;
            this.cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimer.ForeColor = System.Drawing.Color.White;
            this.cmdImprimer.Location = new System.Drawing.Point(636, 400);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImprimer.Size = new System.Drawing.Size(73, 25);
            this.cmdImprimer.TabIndex = 30;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Black;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.Color.White;
            this.cmdOK.Location = new System.Drawing.Point(715, 400);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(73, 25);
            this.cmdOK.TabIndex = 25;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmbManufacturier
            // 
            this.cmbManufacturier.BackColor = System.Drawing.Color.Black;
            this.cmbManufacturier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbManufacturier.ForeColor = System.Drawing.Color.White;
            this.cmbManufacturier.Location = new System.Drawing.Point(176, 96);
            this.cmbManufacturier.Name = "cmbManufacturier";
            this.cmbManufacturier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbManufacturier.Size = new System.Drawing.Size(145, 22);
            this.cmbManufacturier.Sorted = true;
            this.cmbManufacturier.TabIndex = 17;
            this.cmbManufacturier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbManufacturier_KeyPress);
            // 
            // txtNoPiece
            // 
            this.txtNoPiece.AcceptsReturn = true;
            this.txtNoPiece.BackColor = System.Drawing.Color.Black;
            this.txtNoPiece.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoPiece.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPiece.ForeColor = System.Drawing.Color.White;
            this.txtNoPiece.Location = new System.Drawing.Point(176, 64);
            this.txtNoPiece.MaxLength = 37;
            this.txtNoPiece.Name = "txtNoPiece";
            this.txtNoPiece.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoPiece.Size = new System.Drawing.Size(145, 22);
            this.txtNoPiece.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(336, 80);
            this.txtDescription.MaxLength = 61;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Size = new System.Drawing.Size(153, 35);
            this.txtDescription.TabIndex = 16;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.BackColor = System.Drawing.Color.Black;
            this.cmdAjouter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjouter.ForeColor = System.Drawing.Color.White;
            this.cmdAjouter.Location = new System.Drawing.Point(504, 88);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAjouter.Size = new System.Drawing.Size(73, 25);
            this.cmdAjouter.TabIndex = 14;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.Cmdajouter_Click);
            // 
            // lvwManufacturier
            // 
            this.lvwManufacturier.BackColor = System.Drawing.Color.Black;
            this.lvwManufacturier.CheckBoxes = true;
            this.lvwManufacturier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwManufacturier_ColumnHeader_1});
            this.lvwManufacturier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwManufacturier.ForeColor = System.Drawing.Color.White;
            this.lvwManufacturier.FullRowSelect = true;
            this.lvwManufacturier.GridLines = true;
            this.lvwManufacturier.HideSelection = false;
            this.lvwManufacturier.Location = new System.Drawing.Point(8, 64);
            this.lvwManufacturier.Name = "lvwManufacturier";
            this.lvwManufacturier.Size = new System.Drawing.Size(682, 257);
            this.lvwManufacturier.TabIndex = 8;
            this.lvwManufacturier.UseCompatibleStateImageBehavior = false;
            this.lvwManufacturier.View = System.Windows.Forms.View.Details;
            this.lvwManufacturier.SelectedIndexChanged += new System.EventHandler(this.lvwManufacturier_SelectedIndexChanged);
            // 
            // _lvwManufacturier_ColumnHeader_1
            // 
            this._lvwManufacturier_ColumnHeader_1.Text = "Manufacturier";
            this._lvwManufacturier_ColumnHeader_1.Width = 586;
            // 
            // lvwNouvellesPieces
            // 
            this.lvwNouvellesPieces.BackColor = System.Drawing.Color.Black;
            this.lvwNouvellesPieces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwNouvellesPieces_ColumnHeader_1,
            this._lvwNouvellesPieces_ColumnHeader_2,
            this._lvwNouvellesPieces_ColumnHeader_3,
            this._lvwNouvellesPieces_ColumnHeader_4,
            this._lvwNouvellesPieces_ColumnHeader_5});
            this.lvwNouvellesPieces.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwNouvellesPieces.ForeColor = System.Drawing.Color.White;
            this.lvwNouvellesPieces.FullRowSelect = true;
            this.lvwNouvellesPieces.GridLines = true;
            this.lvwNouvellesPieces.HideSelection = false;
            this.lvwNouvellesPieces.Location = new System.Drawing.Point(40, 96);
            this.lvwNouvellesPieces.Name = "lvwNouvellesPieces";
            this.lvwNouvellesPieces.Size = new System.Drawing.Size(569, 217);
            this.lvwNouvellesPieces.TabIndex = 18;
            this.lvwNouvellesPieces.UseCompatibleStateImageBehavior = false;
            this.lvwNouvellesPieces.View = System.Windows.Forms.View.Details;
            this.lvwNouvellesPieces.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwNouvellesPieces_ColumnClick);
            this.lvwNouvellesPieces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwNouvellesPieces_KeyDown);
            // 
            // _lvwNouvellesPieces_ColumnHeader_1
            // 
            this._lvwNouvellesPieces_ColumnHeader_1.Text = "Quantité";
            this._lvwNouvellesPieces_ColumnHeader_1.Width = 170;
            // 
            // _lvwNouvellesPieces_ColumnHeader_2
            // 
            this._lvwNouvellesPieces_ColumnHeader_2.Text = "Pièce";
            this._lvwNouvellesPieces_ColumnHeader_2.Width = 170;
            // 
            // _lvwNouvellesPieces_ColumnHeader_3
            // 
            this._lvwNouvellesPieces_ColumnHeader_3.Text = "Description";
            this._lvwNouvellesPieces_ColumnHeader_3.Width = 170;
            // 
            // _lvwNouvellesPieces_ColumnHeader_4
            // 
            this._lvwNouvellesPieces_ColumnHeader_4.Text = "Manufacturier";
            this._lvwNouvellesPieces_ColumnHeader_4.Width = 170;
            // 
            // _lvwNouvellesPieces_ColumnHeader_5
            // 
            this._lvwNouvellesPieces_ColumnHeader_5.Text = "CatégorieFournisseur";
            this._lvwNouvellesPieces_ColumnHeader_5.Width = 170;
            // 
            // lvwFournisseur
            // 
            this.lvwFournisseur.BackColor = System.Drawing.Color.Black;
            this.lvwFournisseur.CheckBoxes = true;
            this.lvwFournisseur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwFournisseur_ColumnHeader_1,
            this._lvwFournisseur_ColumnHeader_2});
            this.lvwFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFournisseur.ForeColor = System.Drawing.Color.White;
            this.lvwFournisseur.FullRowSelect = true;
            this.lvwFournisseur.GridLines = true;
            this.lvwFournisseur.HideSelection = false;
            this.lvwFournisseur.Location = new System.Drawing.Point(8, 48);
            this.lvwFournisseur.Name = "lvwFournisseur";
            this.lvwFournisseur.Size = new System.Drawing.Size(569, 289);
            this.lvwFournisseur.TabIndex = 9;
            this.lvwFournisseur.UseCompatibleStateImageBehavior = false;
            this.lvwFournisseur.View = System.Windows.Forms.View.Details;
            this.lvwFournisseur.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwFournisseur_ColumnClick);
            // 
            // _lvwFournisseur_ColumnHeader_1
            // 
            this._lvwFournisseur_ColumnHeader_1.Text = "Nom Fournisseur";
            this._lvwFournisseur_ColumnHeader_1.Width = 386;
            // 
            // _lvwFournisseur_ColumnHeader_2
            // 
            this._lvwFournisseur_ColumnHeader_2.Text = "Langage de la demande";
            this._lvwFournisseur_ColumnHeader_2.Width = 100;
            // 
            // lblFormatDate
            // 
            this.lblFormatDate.BackColor = System.Drawing.Color.Black;
            this.lblFormatDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatDate.ForeColor = System.Drawing.Color.White;
            this.lblFormatDate.Location = new System.Drawing.Point(424, 344);
            this.lblFormatDate.Name = "lblFormatDate";
            this.lblFormatDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFormatDate.Size = new System.Drawing.Size(57, 17);
            this.lblFormatDate.TabIndex = 24;
            this.lblFormatDate.Text = "AA-MM-JJ";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Black;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(336, 64);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(73, 17);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description :";
            // 
            // lblManufacturier
            // 
            this.lblManufacturier.BackColor = System.Drawing.Color.Black;
            this.lblManufacturier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturier.ForeColor = System.Drawing.Color.White;
            this.lblManufacturier.Location = new System.Drawing.Point(96, 96);
            this.lblManufacturier.Name = "lblManufacturier";
            this.lblManufacturier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblManufacturier.Size = new System.Drawing.Size(73, 17);
            this.lblManufacturier.TabIndex = 15;
            this.lblManufacturier.Text = "Manufacturier :";
            // 
            // lblNoPiece
            // 
            this.lblNoPiece.BackColor = System.Drawing.Color.Black;
            this.lblNoPiece.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPiece.ForeColor = System.Drawing.Color.White;
            this.lblNoPiece.Location = new System.Drawing.Point(96, 64);
            this.lblNoPiece.Name = "lblNoPiece";
            this.lblNoPiece.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNoPiece.Size = new System.Drawing.Size(73, 17);
            this.lblNoPiece.TabIndex = 10;
            this.lblNoPiece.Text = "No de pièce :";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.BackColor = System.Drawing.Color.Black;
            this.lblCommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.ForeColor = System.Drawing.Color.White;
            this.lblCommentaire.Location = new System.Drawing.Point(487, 345);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCommentaire.Size = new System.Drawing.Size(148, 17);
            this.lblCommentaire.TabIndex = 28;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // lblNoGRB
            // 
            this.lblNoGRB.BackColor = System.Drawing.Color.Black;
            this.lblNoGRB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoGRB.ForeColor = System.Drawing.Color.White;
            this.lblNoGRB.Location = new System.Drawing.Point(248, 368);
            this.lblNoGRB.Name = "lblNoGRB";
            this.lblNoGRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNoGRB.Size = new System.Drawing.Size(81, 17);
            this.lblNoGRB.TabIndex = 26;
            this.lblNoGRB.Text = "# GRB :";
            this.lblNoGRB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDateRequise
            // 
            this.lblDateRequise.BackColor = System.Drawing.Color.Black;
            this.lblDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRequise.ForeColor = System.Drawing.Color.White;
            this.lblDateRequise.Location = new System.Drawing.Point(248, 344);
            this.lblDateRequise.Name = "lblDateRequise";
            this.lblDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateRequise.Size = new System.Drawing.Size(81, 17);
            this.lblDateRequise.TabIndex = 22;
            this.lblDateRequise.Text = "Date Requise :";
            this.lblDateRequise.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCategorie
            // 
            this.lblCategorie.BackColor = System.Drawing.Color.Black;
            this.lblCategorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.ForeColor = System.Drawing.Color.White;
            this.lblCategorie.Location = new System.Drawing.Point(207, 20);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCategorie.Size = new System.Drawing.Size(105, 17);
            this.lblCategorie.TabIndex = 0;
            this.lblCategorie.Text = "Categorie de pièce :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(307, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 22);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ChoixDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(882, 431);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwCategorie);
            this.Controls.Add(this.lvwPiece);
            this.Controls.Add(this.cmdDeselectAll);
            this.Controls.Add(this.cmdSelectAll);
            this.Controls.Add(this.cmbTri);
            this.Controls.Add(this.cmdRechercher);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.cmdRafraichir);
            this.Controls.Add(this.cmdTri);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.txtNoGRB);
            this.Controls.Add(this.mskDateRequise);
            this.Controls.Add(this.cmdLangage);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmbManufacturier);
            this.Controls.Add(this.txtNoPiece);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lvwManufacturier);
            this.Controls.Add(this.lvwNouvellesPieces);
            this.Controls.Add(this.lvwFournisseur);
            this.Controls.Add(this.lblFormatDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblManufacturier);
            this.Controls.Add(this.lblNoPiece);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.lblNoGRB);
            this.Controls.Add(this.lblDateRequise);
            this.Controls.Add(this.lblCategorie);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixDemande";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.ChoixDemande";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChoixDemande_FormClosed);
            this.Load += new System.EventHandler(this.ChoixDemande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private const int I_CMB_PIECE = 0;
        private const int I_CMB_DESCRIPTION_FR = 1;
        private const int I_CMB_DESCRIPTION_EN = 2;
        private const int I_CMB_FABRICANT = 3;
        private const int I_COL_QUANTITE = 0;
        private const int I_COL_PIECE = 1;
        private const int I_COL_DESC_FR = 2;
        private const int I_COL_DESC_EN = 3;
        private const int I_COL_FABRICANT = 4;
        private const int I_COL_NOM_FRS = 0;
        private const int I_COL_LANGAGE = 1;
        private const int I_COL_QTE = 0;
        private const int I_COL_NO_PIECE = 1;
        private const int I_COL_DESCRIPTION = 2;
        private const int I_COL_MANUFACT = 3;
        private const int I_COL_CATEGORIE = 4;
        private const string S_DEMANDE_FRANCAIS = "En français";
        private const string S_DEMANDE_ANGLAIS = "En anglais";
        private const string S_FRANCAIS = "Français";
        private const string S_ANGLAIS = "Anglais";
        private EnumMode m_eMode;
        private EnumModeDemande m_eDemande;
        private EnumCatalogue m_eCatalogue;
        private List<String> m_collPiece = new List<String>();
        private List<String> m_collQuantite = new List<String>();
        private List<String> m_collDescriptionFR = new List<String>();
        private List<String> m_collDescriptionEN = new List<String>();
        private List<String> m_collCategorie = new List<String>();
        private List<String> m_collManufacturier = new List<String>();
        private bool m_bPiece;
        private string m_sCategorie;
        private string m_sLangage;
        private bool m_bProjSoum;
        private bool m_bAchat;
        private string m_sNoProjSoum;
        private string m_sNoAchat;
        private int m_iIndexAchat;
        private int m_iIndexRecherche;
        private string m_sTri;
        private EnumType m_eType;
        public static bool m_bAnnulerContact;
        public static string m_sContact;
        private EnumCatalogue eCatalogue;
        private EnumCatalogue eLECTRIQUE;
        private Program.EnumModeDemande eDemande;
        public ChoixDemande(bool télécommande)
        {
            Icon = Conteneur.ActiveForm.Icon;
            Télécommande = télécommande;
            InitializeComponent();
            List<String> Distributeurs = new List<String>();
            lvwPiece.Items.Clear();
            lvwPiece.Columns[3].Text = "Fournisseur";
            Afficher(eLECTRIQUE, EnumModeDemande.MODE_PIECE);
            ModeTelecomande(Télécommande);
            ADODB.Recordset rd = new ADODB.Recordset();
            rd.Open($" SELECT DISTINCT NOMFOURNISSEUR FROM [DBO].[ACHAT_PIECES] " +
                $"JOIN [DBO].[FOURNISSEUR] ON [DBO].[ACHAT_PIECES].IDFRS=[DBO].[FOURNISSEUR].IDFRS " +
                $"WHERE  [IDACHAT]= '{Gauche(ACHAT.cmbNoAchat.Text, 9)}' AND INDEXACHAT = '{int.Parse(Droite(ACHAT.cmbNoAchat.Text, 3))}' " +
                $"ORDER BY NomFournisseur DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                Distributeurs.Add($"{rd.Fields[0].Value}");
                ListViewItem ifrs = lvwFournisseur.Items.Add(string.Empty);
                ifrs.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                comboBox1.Items.Add($"{rd.Fields[0].Value}");
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            Conteneur.txtStatus.Text = $"{Distributeurs.Count} distributeurs trouvés pour le projet {Gauche(ACHAT.cmbNoAchat.Text, 9)}";
            items = ACHAT.lvwAchat.SelectedItems;
            lvwPiece.ForeColor = Color.CadetBlue;
            foreach (ListViewItem p in items)
            {
                ListViewItem itm = lvwPiece.Items.Add(string.Empty);
                itm.Text = p.SubItems[0].Text;
                itm.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null, p.SubItems[1].Text));
                itm.SubItems.Insert(I_COL_DESC_FR, new ListViewItem.ListViewSubItem(null, p.SubItems[2].Text));
                itm.SubItems.Insert(I_COL_DESC_EN, new ListViewItem.ListViewSubItem(null, p.SubItems[7].Text));
                itm.SubItems.Insert(I_COL_FABRICANT, new ListViewItem.ListViewSubItem(null, p.SubItems[3].Text));
                itm.Checked = false;
            }
        }
        private void ModeTelecomande(bool télécommande)
        {
            lblCategorie.Visible = !télécommande;
            cmbCategorie.Visible = !télécommande;
            cmbTri.Visible = !télécommande;
            cmdTri.Visible = !télécommande;
            cmdRafraichir.Visible = !télécommande;
            label1.Visible = télécommande;
            label1.Text = lvwPiece.Columns[3].Text;
            cmdLangage.Visible = télécommande;
            mskDateRequise.Visible = télécommande;
            mskDateRequise.Text = Droite(DateTime.Today.AddDays(2).ToShortDateString(),8);
            lblDateRequise.Visible = télécommande;
            lblNoGRB.Visible = télécommande;
            txtNoGRB.Text = ACHAT.cmbNoAchat.Text;
            txtCommentaire.Visible = télécommande;
            lblCommentaire.Visible = télécommande;
        }
        public ChoixDemande(string text, EnumCatalogue eCatalogue, Program.EnumModeDemande mODE_PIECE)
        {
            InitializeComponent();
            Text = text;
            eCatalogue = eCatalogue;
            eDemande = mODE_PIECE;
            Afficher(eLECTRIQUE, eDemande);
        }
        public ChoixDemande(EnumCatalogue eLECTRIQUE, Program.EnumModeDemande eDemande)
        {
            InitializeComponent();
            eLECTRIQUE = eLECTRIQUE;
            eDemande = eDemande;
            Afficher(eLECTRIQUE, eDemande);
        }
        [Obsolete]
        public void Afficher(EnumCatalogue eCatalogue, EnumModeDemande eDemande)
        {
            try
            {
                m_eCatalogue = eCatalogue;
                m_eDemande = eDemande;
                m_bProjSoum = false;
                switch (eDemande){
					case EnumModeDemande.MODE_FOURNISSEUR:{RemplirListViewFournisseur(false);AfficherControles(EnumMode.Fournisseur); break;}
                    case EnumModeDemande.MODE_PIECE:{RemplirComboCategorie();AfficherControles(EnumMode.PIECE); break;}
                    case EnumModeDemande.MODE_CATEGORIE:{RemplirListViewCatalogue();AfficherControles(EnumMode.Categorie); break;}
                    case EnumModeDemande.MODE_NOUVELLE:{RemplirComboCategorie();AfficherControles(EnumMode.NOUVELLE_PIECE);
                            /*            if (m_eDemande == EnumModeDemande.MODE_NOUVELLE)
                                        {
                                            RemplirComboManufacturiers();
                                        }*/
                            break;}
                }
                Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "Afficher", ex); }
        }
        private void RemplirListViewFournisseur(bool v)
        {
            ADODB.Recordset rstFRS;
            ListViewItem itmFRS;
            string sWhere;
            m_bPiece = v;
            lvwFournisseur.Items.Clear();
            rstFRS = new Recordset();
            if (v == false)
            {
                rstFRS.Open("SELECT NomFournisseur, IDFRS FROM Fournisseur WHERE Supprimé = 0 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else
            {
                sWhere = "PIECE IN (";
                for (int i = 1; i < m_collPiece.Count; i++){if (i != m_collPiece.Count) { sWhere += "'" + m_collPiece[i].Replace("'", "''") + "', "; } else { sWhere += "'" + m_collPiece[i].Replace("'", "''") + "')"; }
                }
                rstFRS.Open("SELECT DISTINCT Fournisseur.NomFournisseur, Fournisseur.IDFRS FROM PiecesFRS " +
                    "INNER JOIN Fournisseur ON PiecesFRS.IDFRS = Fournisseur.IDFRS " +
                    "WHERE " + sWhere + " " +
                    "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
        }
        public void AfficherProjetSoumission(string sNoProjSoum, EnumCatalogue eCatalogue, EnumModeDemande eDemande, int iType)
        {
            try
            {
                m_eCatalogue = eCatalogue;
                m_eDemande = eDemande;
                m_sNoProjSoum = sNoProjSoum;
                m_eType = (EnumType)iType;
                txtNoGRB.Text = sNoProjSoum;
                RemplirListViewPieceProjetSoumission();
                AfficherControles(EnumMode.PIECE);
                cmbTri.Visible = false;
                cmdTri.Visible = false;
                cmdRafraichir.Visible = false;
                cmbCategorie.Visible = false;
                lblCategorie.Visible = false;
                m_bProjSoum = true;
                Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "AfficherProjet", ex); }
        }
        public void AfficherAchat(string sNoAchat, EnumCatalogue eCatalogue, EnumModeDemande eDemande)
        {
            try
            {
                m_eCatalogue = eCatalogue;
                m_eDemande = eDemande;
                txtNoGRB.Text = sNoAchat;
                m_sNoAchat = Gauche(sNoAchat, 9);
                m_iIndexAchat = int.Parse(Droite(sNoAchat, 3));
                RemplirListViewPieceAchat();
                AfficherControles(EnumMode.PIECE);
                cmbTri.Visible = false;
                cmdTri.Visible = false;
                cmdRafraichir.Visible = false;
                cmbCategorie.Visible = false;
                lblCategorie.Visible = false;
                m_bAchat = true;
                Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "AfficherProjet", ex); }
        }
        [Obsolete]
        private void AfficherControles(EnumMode eMode)
        {
            try
            {
                var bCategorie = default(bool);
                var bLvwPiece = default(bool);
                var bLvwFournisseur = default(bool);
                var bLvwCategorie = default(bool);
                var bLvwManufacturier = default(bool);
                var bLvwNouvelle = default(bool);
                var bCmdOK = default(bool);
                var bCmdImprimer = default(bool);
                var bCmdLangage = default(bool);
                var bNoGRB = default(bool);
                var bDate = default(bool);
                var bCommentaire = default(bool);
                var bNoPiece = default(bool);
                var bManufact = default(bool);
                var bDescription = default(bool);
                var bCmdAjouter = default(bool);
                var bRechercher = default(bool);
                var bTri = default(bool);
                var bSelectAll = default(bool);
                var bDeselectAll = default(bool);
                m_eMode = eMode;
                switch (eMode){case EnumMode.Fournisseur:{bLvwFournisseur = true;
                            bCmdImprimer = true;
                            bCmdLangage = true;
                            bNoGRB = true;
                            bDate = true;
                            bCommentaire = true;
                            bRechercher = true;
                            bSelectAll = true;
                            bDeselectAll = true; break;}
                    case EnumMode.PIECE:{bCategorie = true;
                            bLvwPiece = true;
                            bCmdOK = true;
                            bTri = true;
                            bSelectAll = true;
                            bDeselectAll = true; break;}
                    case EnumMode.Manufacturier:{bLvwManufacturier = true;
                            bCmdOK = true;
                            bSelectAll = true;
                            bDeselectAll = true; break;}
                    case EnumMode.Categorie:{bLvwCategorie = true;
                            bCmdOK = true;
                            bSelectAll = true;
                            bDeselectAll = true; break;}
                    case EnumMode.NOUVELLE_PIECE:{bLvwNouvelle = true;
                            bNoPiece = true;
                            bManufact = true;
                            bDescription = true;
                            bCategorie = true;
                            bCmdOK = true;
                            bCmdAjouter = true; break;}
                }
                lblCategorie.Visible = bCategorie;
                cmbCategorie.Visible = bCategorie;
                lvwPiece.Visible = bLvwPiece;
                lvwFournisseur.Visible = bLvwFournisseur;
                lvwCategorie.Visible = bLvwCategorie;
                lvwNouvellesPieces.Visible = bLvwNouvelle;
                lvwManufacturier.Visible = bLvwManufacturier;
                cmdSelectAll.Visible = bSelectAll;
                cmdDeselectAll.Visible = bDeselectAll;
                cmdOK.Visible = bCmdOK;
                lblNoPiece.Visible = bNoPiece;
                txtNoPiece.Visible = bNoPiece;
                lblManufacturier.Visible = bManufact;
                cmbManufacturier.Visible = bManufact;
                lblDescription.Visible = bDescription;
                txtDescription.Visible = bDescription;
                cmdAjouter.Visible = bCmdAjouter;
                cmdImprimer.Visible = bCmdImprimer;
                cmdLangage.Visible = bCmdLangage;
                lblNoGRB.Visible = bNoGRB;
                txtNoGRB.Visible = bNoGRB;
                lblDateRequise.Visible = bDate;
                mskDateRequise.Visible = bDate;
                lblFormatDate.Visible = bDate;
                lblCommentaire.Visible = bCommentaire;
                txtCommentaire.Visible = bCommentaire;
                txtRechercher.Visible = bRechercher;
                cmdRechercher.Visible = bRechercher;
                cmbTri.Visible = bTri;
                cmdRafraichir.Visible = bTri;
                cmdTri.Visible = bTri;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "AfficherControles", ex); }
        }
        private void RemplirListViewManufacturier()
        {
            try
            {
                ADODB.Recordset rstManufact;
                string sWhere;
                lvwManufacturier.Items.Clear();
                lvwManufacturier.Sort();
                sWhere = "CATEGORIE In (";
                for (int i = 0; i < m_collCategorie.Count; i++){if (i != m_collCategorie.Count) { sWhere += "'" + m_collCategorie[i].Replace("'", "''") + "',"; } else { sWhere += "'" + m_collCategorie[i].Replace("'", "''") + "')"; }
                }
                rstManufact = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE){rstManufact.Open("SELECT DISTINCT FABRICANT FROM CatalogueElec WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}else{rstManufact.Open("SELECT DISTINCT FABRICANT FROM CatalogueMec WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}
                Clipboard.SetText("SELECT DISTINCT FABRICANT FROM CatalogueMec WHERE " + sWhere);
                while (!rstManufact.EOF){lvwManufacturier.Items.Add(rstManufact.Fields["FABRICANT"].Value);
                    rstManufact.MoveNext();}
                rstManufact.Close();
                rstManufact = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "RemplirListViewManufacturier", ex); }
        }
        private void RemplirComboCategorie()
        {
            try
            {
                ADODB.Recordset rstCategorie = new ADODB.Recordset();
                cmbCategorie.Items.Clear();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE){rstCategorie.Open("SELECT DISTINCT TRIM(UPPER(CATEGORIE)) FROM CATALOGUEELEC ORDER BY TRIM(UPPER(CATEGORIE))", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}else{rstCategorie.Open(" SELECT DISTINCT TRIM(UPPER(CATEGORIE)) FROM CATALOGUEMEC ORDER BY TRIM(UPPER(CATEGORIE))", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}
                while (!rstCategorie.EOF){if (!(rstCategorie.Fields[0].Value is DBNull))
                    {
                        cmbCategorie.Items.Add(rstCategorie.Fields[0].Value);
                        m_collCategorie.Add($"{rstCategorie.Fields[0].Value}");
                    }
                    rstCategorie.MoveNext();}
                rstCategorie.Close();
                rstCategorie = null;
                if (cmbCategorie.Items.Count > 0){cmbCategorie.SelectedIndex = 0;}
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "RemplirComboCategorie", ex); }
        }
        private void RemplirListViewCatalogue()
        {
            try
            {
                ADODB.Recordset rstCategorie;
                lvwCategorie.Items.Clear();
                rstCategorie = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE){rstCategorie.Open("SELECT DISTINCT CATEGORIE FROM CatalogueElec ORDER BY CATEGORIE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}else{rstCategorie.Open("SELECT DISTINCT CATEGORIE FROM CatalogueMec ORDER BY CATEGORIE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}
                while (!rstCategorie.EOF){lvwCategorie.Items.Add(rstCategorie.Fields["CATEGORIE"].Value);
                    rstCategorie.MoveNext();}
                rstCategorie.Close();
                rstCategorie = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "RemplirListViewCatalogue", ex); }
        }
        private int TrouverIndexPiece(string sPiece, string sDescriptionFR, string sDescriptionEN, string sFabricant, int iIndexActuel)
        {
            int TrouverIndexPieceRet = default;
            try
            {
                int iIndex;
                string sTri = string.Empty;
                bool bDebut;
                sTri.ToUpper();
                sPiece.ToUpper();
                sDescriptionFR.ToUpper();
                sDescriptionEN.ToUpper();
                sFabricant.ToUpper();
                if (!string.IsNullOrEmpty(sTri)){bDebut = false;
                    switch (cmbTri.SelectedIndex)
                    {
                        case I_CMB_PIECE:
                            {
                                if (Strings.InStr(1, sPiece, sTri) > 0)
                                {
                                    bDebut = true;
                                }
                                break;
                            }
                        case I_CMB_DESCRIPTION_FR:
                            {
                                if (Strings.InStr(1, sDescriptionFR, sTri) > 0)
                                {
                                    bDebut = true;
                                }
                                break;
                            }
                        case I_CMB_DESCRIPTION_EN:
                            {
                                if (Strings.InStr(1, sDescriptionEN, sTri) > 0)
                                {
                                    bDebut = true;
                                }
                                break;
                            }
                        case I_CMB_FABRICANT:
                            {
                                if (Strings.InStr(1, sFabricant, sTri) > 0)
                                {
                                    bDebut = true;
                                }
                                break;
                            }
                    }
                    if (bDebut == true)
                    {
                        iIndex = (int)(iIndexActuel + 1);
                    }
                    else
                    {
                        iIndex = 0;
                    }
                }
                else{iIndex = 0;}
                TrouverIndexPieceRet = iIndex;
                return TrouverIndexPieceRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDemande", "TrouverIndexPiece", ex);
                return 0;
            }
        }
        private void RemplirListViewPieceProjetSoumission()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ListViewItem itmPiece;
                lvwPiece.Items.Clear();
                lvwPiece.Enabled = true;
                rstPiece = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    rstPiece.Open("SELECT Qté, NumItem, Desc_FR, Desc_EN, Manufact, IDFRS, PieceExtraChargeable, PieceExtraNonChargeable FROM Projet_Pieces " +
                    "WHERE (IDProjet = '" + m_sNoProjSoum + "') AND (IDFRS = 0 AND NumItem <> 'Texte') ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); ;
                }
                else { rstPiece.Open("SELECT Qté, NumItem, Desc_FR, Desc_En, Manufact, IDFRS, PieceExtraChargeable, PieceExtraNonChargeable FROM Soumission_Pieces " +
                    "WHERE (IDSoumission = '" + m_sNoProjSoum + "') AND (IDFRS = 0 AND NumItem <> 'Texte') ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                while (!rstPiece.EOF)
                {
                    if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(rstPiece.Fields["PieceExtraChargeable"].Value, false, false), Operators.ConditionalCompareObjectEqual(rstPiece.Fields["PieceExtraNonChargeable"].Value, false, false))))
                    {
                        itmPiece = lvwPiece.Items.Add(string.Empty);
                        itmPiece.Text = $"{rstPiece.Fields["Qté"].Value}";
                        itmPiece.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["NumItem"].Value}"));
                        itmPiece.SubItems.Insert(I_COL_DESC_FR, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["Desc_FR"].Value}"));
                        itmPiece.SubItems.Insert(I_COL_DESC_EN, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["Desc_EN"].Value}"));
                        itmPiece.SubItems.Insert(I_COL_FABRICANT, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["Manufact"].Value}"));
                    }
                    rstPiece.MoveNext();
                }
                rstPiece.Close();
                rstPiece = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "RemplirListViewPieceProjet", ex); }
        }
        private void RemplirListViewPieceAchat()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ListViewItem itmPiece;
                lvwPiece.Items.Clear();
                rstPiece = new Recordset();
                rstPiece.Open("SELECT Qté, PIECE, Desc_FR, Desc_EN, Manufact, IDFRS FROM Achat_Pieces " +
                    "WHERE IDAchat = '" + m_sNoAchat + "' AND IndexAchat = " + m_iIndexAchat + " AND IDFRS = 0 ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF){itmPiece = lvwPiece.Items.Add(string.Empty);
                    itmPiece.Text = $"{rstPiece.Fields["Qté"].Value}";
                    itmPiece.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["PIECE"].Value}"));
                    itmPiece.SubItems.Insert(I_COL_DESC_EN, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["Desc_En"].Value}"));
                    itmPiece.SubItems.Insert(I_COL_FABRICANT, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["Manufact"].Value}"));
                    rstPiece.MoveNext();}
                rstPiece.Close();
                rstPiece = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "RemplirListViewPieceProjet", ex); }
        }
        private void cmbCategorie_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                AjouterPieceCollection();
                if (Télécommande == false){RemplirListViewPiece();
                    //                CocherCases();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "cmbCategorie_Click", ex); }
        }
        private void RemplirListViewPiece()
        {
            ADODB.Recordset rstPiece = new ADODB.Recordset();
            string sCategorie;
            var sOrderBy = default(string);
            var iIndex = default(int);
            int i;
            sCategorie = cmbCategorie.Text.Replace("'", "''");
            lvwPiece.Items.Clear();
            try
            {
                switch (cmbTri.SelectedIndex)
                {
                    case I_CMB_PIECE: { sOrderBy = "PIECE"; break; }
                    case I_CMB_DESCRIPTION_FR: { sOrderBy = "DESC_FR"; break; }
                    case I_CMB_DESCRIPTION_EN: { sOrderBy = "DESC_EN"; break; }
                    case I_CMB_FABRICANT: { sOrderBy = "FABRICANT"; break; }
                    default: { sOrderBy = "PIECE"; break; }
                }
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE) { rstPiece.Open("SELECT DISTINCT PIECE, PIECE_MODIF, DESC_FR,DESC_EN,  FABRICANT FROM CATALOGUEELEC " +
                    "WHERE CATEGORIE = '" + sCategorie + "' ORDER BY " + sOrderBy, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); ; } else { 
                    rstPiece.Open("SELECT DISTINCT PIECE, PIECE_MODIF, DESC_FR,DESC_EN,  FABRICANT FROM CATALOGUEMEC WHERE CATEGORIE = '" + sCategorie + "' ORDER BY " + sOrderBy, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                while (!rstPiece.EOF)
                {
                    ListViewItem itmPiece = lvwPiece.Items.Add(string.Empty);
                    itmPiece.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields[0].Value}"));
                    itmPiece.SubItems.Insert(I_COL_DESC_FR, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields[1].Value}"));
                    itmPiece.SubItems.Insert(I_COL_DESC_EN, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields[2].Value}"));
                    itmPiece.SubItems.Insert(I_COL_FABRICANT, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields[3].Value}"));
                    rstPiece.MoveNext();
                }
                rstPiece.Close();
                rstPiece = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "RemplirListViewPiece", ex); }
        }
        private void RemplirComboManufacturiers()
        {
            try
            {
                ADODB.Recordset rstPiece;
                cmbManufacturier.Items.Clear();
                rstPiece = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE){rstPiece.Open("SELECT DISTINCT FABRICANT FROM CatalogueElec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}else{rstPiece.Open("SELECT DISTINCT FABRICANT FROM CatalogueMec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}
                while (!rstPiece.EOF){if (!(rstPiece.Fields["FABRICANT"].Value is DBNull))
                    {
                        cmbManufacturier.Items.Add(rstPiece.Fields["FABRICANT"].Value);
                    }
                    rstPiece.MoveNext();}
                rstPiece.Close();
                rstPiece = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "RemplirComboManufacturiers", ex); }
        }
        /*        private void CocherCases(){try
                    {
                                int i2;
                        var loopTo = (int)m_collCategorie.Count;
                        for (int i = 1; i <= loopTo; i++){if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(m_collCategorie[i], cmbCategorie.Text, false)))
                            {
                                var loopTo1 = (int)lvwPiece.Items.Count;
                                for (int i2 = 1; i2 <= loopTo1; i2++)
                                {
                                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwPiece.Items[i2].SubItems[I_COL_PIECE].Text, m_collPiece[i], false)))
                                    {
                                        lvwPiece.Items[i2].Checked = true;
                                    }
                                }
                            }
                        }
                        return;
                    }
                    catch (Exception ex) {AfficherErreur("ChoixDemande", "CocherCases", ex); }
                }*/
        private void cmbManufacturier_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            char KeyAscii = eventArgs.KeyChar;
            if (KeyAscii <= 122 & KeyAscii >= 97)
            {
                KeyAscii = (char)(KeyAscii - 32);
            }
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }
        private void Cmdajouter_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstPiece;
                var bTrouver = default(bool);
                ListViewItem itmPiece;
                string sQuantite;
                if (string.IsNullOrEmpty(txtNoPiece.Text) | string.IsNullOrEmpty(cmbManufacturier.Text) | string.IsNullOrEmpty(txtDescription.Text)){MessageBox.Show("Vous devez absolument remplir tous les champs!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;}
                if (Strings.InStr(1, txtNoPiece.Text, "'") > 0){MessageBox.Show("Numéro invalide! Le numéro ne doit pas contenir d'appostrophes!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;}
                rstPiece = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE){rstPiece.Open("SELECT * FROM CatalogueElec WHERE PIECE = '" + Strings.Replace(txtNoPiece.Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}else{rstPiece.Open("SELECT * FROM CatalogueMec WHERE PIECE = '" + Strings.Replace(txtNoPiece.Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}
                if (rstPiece.EOF == false){bTrouver = true;}
                rstPiece.Close();
                rstPiece = null;
                if (bTrouver == true){MessageBox.Show("Le numéro de pièce existe déjà!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;}
                sQuantite = Interaction.InputBox("Quelle est la quantité?");
                if (!string.IsNullOrEmpty(sQuantite)){if (!IsNumeric(sQuantite))
                    {
                        MessageBox.Show("Quantité non numérique!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else{sQuantite = "1";}
                itmPiece = lvwNouvellesPieces.Items.Add(string.Empty);
                itmPiece.Text = sQuantite;
                if (itmPiece.SubItems.Count > I_COL_NO_PIECE){itmPiece.SubItems[I_COL_NO_PIECE].Text = txtNoPiece.Text;}else{itmPiece.SubItems.Insert(I_COL_NO_PIECE, new ListViewItem.ListViewSubItem(null, txtNoPiece.Text));}
                if (itmPiece.SubItems.Count > I_COL_DESCRIPTION){itmPiece.SubItems[I_COL_DESCRIPTION].Text = txtDescription.Text;}else{itmPiece.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, txtDescription.Text));}
                if (itmPiece.SubItems.Count > I_COL_MANUFACT){itmPiece.SubItems[I_COL_MANUFACT].Text = cmbManufacturier.Text;}else{itmPiece.SubItems.Insert(I_COL_MANUFACT, new ListViewItem.ListViewSubItem(null, cmbManufacturier.Text));}
                if (itmPiece.SubItems.Count > I_COL_CATEGORIE){itmPiece.SubItems[I_COL_CATEGORIE].Text = cmbCategorie.Text;}else{itmPiece.SubItems.Insert(I_COL_CATEGORIE, new ListViewItem.ListViewSubItem(null, cmbCategorie.Text));}
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdAjouter_Click", ex); }
        }
        private void Cmdfermer_Click(object eventSender, EventArgs eventArgs){try{Close();return;}catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdFermer_Click", ex); }}
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ListViewItem itmFRS;
                if (lvwFournisseur.Items.Count > 0){if (VerifierSiChecked() == true)
                    {
                        for (int i = 0; i <lvwFournisseur.Items.Count; i++){if (lvwFournisseur.Items[i].Checked == true)
                            {
                                itmFRS = lvwFournisseur.Items[i];
                                m_sLangage = itmFRS.SubItems[I_COL_LANGAGE].Text;
                                Form f = new ChoixContactFRS();
                                f.Text = itmFRS.Tag.ToString();
                                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                                f.ShowDialog();
                                if (m_bAnnulerContact == false)
                                {
                                    if (m_eDemande == EnumModeDemande.MODE_NOUVELLE)
                                    {
                                        EnregistrerDemandePrixNouvellesPieces();
                                    }
                                    else
                                    {
                                        EnregistrerDemandePrix(int.Parse(itmFRS.Tag.ToString()));
                                    }
                                    ImprimerDemandePrix(int.Parse(itmFRS.Tag.ToString()));
                                }
                            }
                        }
                        if (m_eDemande == EnumModeDemande.MODE_NOUVELLE){EnregistrerPieces();}
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdImprimer_Click", ex); }
        }
        private void EnregistrerPieces()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstPiecesFRS;
                rstPiece = new Recordset();
                rstPiecesFRS = new Recordset();
                for (int iPieces = 0; iPieces <m_collPiece.Count; iPieces++){if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                    {
                        rstPiece.Open("SELECT * FROM CatalogueElec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstPiece.Open("SELECT * FROM CatalogueMec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    rstPiece.AddNew();
                    rstPiece.Fields["PIECE"].Value = m_collPiece[iPieces];
                    rstPiece.Fields["PIECE_GRB"].Value = Operators.ConcatenateObject(m_collPiece[iPieces], "GRB");
                    rstPiece.Fields["DESC_FR"].Value = m_collDescriptionFR[iPieces];
                    rstPiece.Fields["FABRICANT"].Value = m_collManufacturier[iPieces];
                    rstPiece.Fields["CATEGORIE"].Value = m_collCategorie[iPieces];
                    rstPiece.Update();
                    rstPiecesFRS.Open("SELECT * FROM PiecesFRS", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    for (int iFRS = 0; iFRS <= lvwFournisseur.Items.Count; iFRS++)
                    {
                        if (lvwFournisseur.Items[iFRS].Checked == true){rstPiecesFRS.AddNew();
                            rstPiecesFRS.Fields["IDFRS"].Value = lvwFournisseur.Items[iFRS].Tag;
                            rstPiecesFRS.Fields["PIECE"].Value = m_collPiece[iPieces];
                            rstPiecesFRS.Fields["DATE"].Value = ConvertDate(DateTime.Today);
                            rstPiecesFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                            rstPiecesFRS.Fields["PRIX_SP"].Value = string.Empty;
                            rstPiecesFRS.Fields["PERS_RESS"].Value = string.Empty;
                            rstPiecesFRS.Fields["PRIX_LIST"].Value = "0";
                            rstPiecesFRS.Fields["ESCOMPTE"].Value = "0";
                            rstPiecesFRS.Fields["PRIX_NET"].Value = "0";
                            rstPiecesFRS.Fields["DeviseMonétaire"].Value = "CAN";
                            rstPiecesFRS.Fields["PrixReel"].Value = "0";
                            rstPiecesFRS.Fields["Type"].Value = "M";
                            rstPiecesFRS.Update();}
                    }
                    rstPiecesFRS.Close();
                    rstPiece.Close();}
                rstPiece = null;
                rstPiecesFRS = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "EnregistrerPieces", ex); }
        }
        private void cmdLangage_Click(object eventSender, EventArgs eventArgs)
        {
            if (Télécommande == true)
            {
                if ((cmdLangage.Text ?? string.Empty) == S_ANGLAIS) { cmdLangage.Text = S_DEMANDE_ANGLAIS; } else { cmdLangage.Text = S_DEMANDE_FRANCAIS; }
                if ((cmdLangage.Text ?? string.Empty) == S_FRANCAIS) { cmdLangage.Text = S_DEMANDE_FRANCAIS; } else { cmdLangage.Text = S_DEMANDE_ANGLAIS; }
            }
            else
            {
                try{if ((cmdLangage.Text ?? "") == S_DEMANDE_FRANCAIS) { 
                        lvwFournisseur.FocusedItem.SubItems.Insert(I_COL_LANGAGE, new ListViewItem.ListViewSubItem(null, S_FRANCAIS)); cmdLangage.Text = S_DEMANDE_ANGLAIS; 
                    } else { 
                        lvwFournisseur.FocusedItem.SubItems.Insert(I_COL_LANGAGE, new ListViewItem.ListViewSubItem(null, S_ANGLAIS)); cmdLangage.Text = S_DEMANDE_FRANCAIS; 
                    }
                    lvwFournisseur.Focus();
                    return;}
                catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdLangage_Click", ex); }
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Télécommande == true) {
                    ViewDemandePrix.itm = lvwPiece.Items;
                    if (cmdLangage.Visible==true &(cmdLangage.Text == S_ANGLAIS | cmdLangage.Text==S_DEMANDE_ANGLAIS) ){
                        ViewDemandePrix.lblTitreDemande.Text = "Price and Delivery Request";
                        ViewDemandePrix.lblTitreFournisseur.Text = "Supplier :";
                        ViewDemandePrix.lblTitreContact.Text = "Contact :";
                        ViewDemandePrix.lblTitreTransport.Text = "Transport :";
                        ViewDemandePrix.lblTitreDateReq.Text = "Required Date :";
                        ViewDemandePrix.lblTitreNoSoum.Text = "Your Ref # :";
                        ViewDemandePrix.lblTitreTel.Text = "Telephone :";
                        ViewDemandePrix.lblTitreFax.Text = "Fax :";
                        ViewDemandePrix.lblTitreNoGRB.Text = "OUR # :";
                        ViewDemandePrix.lblTitreDate.Text = "Date :";
                        ViewDemandePrix.lblTitreComPar.Text = "Purchaser :";
                        ViewDemandePrix.lblTitrePage.Text = "Page :";
                        ViewDemandePrix.lblTitreQte.Text = "Qty";
                        ViewDemandePrix.lblTitrePiece.Text = "Part Number";
                        ViewDemandePrix.lblTitreDescription.Text = "Description";
                        ViewDemandePrix.lblTitreManufact.Text = "Manufacturer";
                        ViewDemandePrix.lblTitreDelais.Text = "Delay";
                        ViewDemandePrix.lblTitreCommentaire.Text = "Comments :";
                        ViewDemandePrix.lblPrixValide.Text = "Valid price for";
                        ViewDemandePrix.lblJours.Text = "Days";
                        ViewDemandePrix.lblPiedPage.Text = "THIS IS NOT AN ORDER";
                    }
                    if(MessageBox.Show("Voulez vous générer les demandes pour chaque fournisseur présent dans la liste des demandes ?", Application.ProductName + ".EmulateurCrystal.Wizzard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach( string st in comboBox1.Items){ViewDemandePrix dm = new ViewDemandePrix(st);
                            dm.MdiParent = Conteneur.Mdi;
                            dm.Show();                            
                        }
                    ;}else{    if (comboBox1.Text == "") { MessageBox.Show("Choisir un fournisseur dans la liste déroulante", Application.ProductName + ".EmulateurCrystal.Wizzard.Preview." + Name);return; }
                        ViewDemandePrix dm = new ViewDemandePrix(comboBox1.Text);
                        dm.MdiParent = Conteneur.Mdi;
                        dm.Show();
                    }
                }
                else{if (m_eMode == EnumMode.PIECE)
                    {
                        AjouterPieceCollection();
                        AfficherFournisseur();
                    }
                    else if (m_eMode == EnumMode.NOUVELLE_PIECE)
                    {
                        AjouterNouvellePieceCollection();
                        //               RemplirListViewFournisseur(false);
                        AfficherControles(EnumMode.Fournisseur);
                    }
                    else if (m_eMode == EnumMode.Manufacturier)
                    {
                        AjouterManufacturierCollection();
                        //          RemplirListViewFournisseur(false);
                        AfficherControles(EnumMode.Fournisseur);
                    }
                    else
                    {
                        AjouterCategorieCollection();
                        if (VerifierSiChecked() == true){RemplirListViewManufacturier();
                            AfficherControles(EnumMode.Manufacturier);}
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdOK_Click", ex); }
        }
        private void AjouterNouvellePieceCollection()
        {
            try
            {
                ListViewItem itmPiece;
                for (int i = 1; i <lvwNouvellesPieces.Items.Count ; i++){itmPiece = lvwNouvellesPieces.Items[i];
                    m_collQuantite.Add(itmPiece.Text);
                    m_collPiece.Add(itmPiece.SubItems[I_COL_NO_PIECE].Text);
                    m_collDescriptionFR.Add(itmPiece.SubItems[I_COL_DESCRIPTION].Text);
                    m_collManufacturier.Add(itmPiece.SubItems[I_COL_MANUFACT].Text);
                    m_collCategorie.Add(itmPiece.SubItems[I_COL_CATEGORIE].Text);}
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "AjouterNouvellePieceCollection", ex); }
        }
        private void AjouterManufacturierCollection()
        {
            try
            {
                for (int i = 0; i <lvwManufacturier.Items.Count; i++){if (lvwManufacturier.Items[i].Checked == true)
                    {
                        m_collManufacturier.Add(lvwManufacturier.Items[i].Text);
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "AjouterManufacturierCollection", ex); }
        }
        private void AjouterCategorieCollection()
        {
            try
            {
                for (int i = 0; i <lvwCategorie.Items.Count; i++){if (lvwCategorie.Items[i].Checked == true)
                    {
                        m_collCategorie.Add(lvwCategorie.Items[i].Text);
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "AjouterCategorieCollection", ex); }
        }
        private void cmdRechercher_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                var bTrouver = default(bool);
                if (cmdRechercher.Text == "Rechercher"){
                    for (int i = 0; i <lvwFournisseur.Items.Count; i++)
                    {
                        if (Strings.InStr(1, Strings.UCase(lvwFournisseur.Items[i].Text), txtRechercher.Text.ToUpper()) > 0){bTrouver = true;
                            lvwFournisseur.Items[i].Selected = true;
                            lvwFournisseur.Items[i].EnsureVisible();
                            lvwFournisseur.Focus();
                            m_iIndexRecherche = i;
                            break;}
                    }
                    if (bTrouver == true){cmdRechercher.Text = "Suivant";}else{MessageBox.Show("Aucun fournisseur trouvé!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);}
                }
                else{
                    for (int i = m_iIndexRecherche++; i <lvwFournisseur.Items.Count; i++)
                    {
                        if (Strings.InStr(1, Strings.UCase(lvwFournisseur.Items[i].Text), Strings.UCase(txtRechercher.Text)) > 0){bTrouver = true;
                            lvwFournisseur.Items[i].Selected = true;
                            lvwFournisseur.Items[i].EnsureVisible();
                            lvwFournisseur.Focus();
                            m_iIndexRecherche = i;
                            break;}
                    }
                    if (bTrouver == false)
                    {
                        MessageBox.Show("Aucun fournisseur trouvé!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmdRechercher.Text = "Rechercher";
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdRechercher_Click", ex); }
        }
        private void cmdSelectAll_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Télécommande == true) { m_eMode = EnumMode.PIECE; cmdDeselectAll.Text = "Télécomandé";cmdDeselectAll.Enabled = false; }
                var lvwSource = default(ListView);
                switch (m_eMode){case EnumMode.PIECE: { lvwSource = lvwPiece; break; }
                    case EnumMode.Categorie: { lvwSource = lvwCategorie; break; }
                    case EnumMode.Fournisseur: { lvwSource = lvwFournisseur; break; }
                    case EnumMode.Manufacturier: { lvwSource = lvwManufacturier; break; }
                }
                for (int i = 0; i < lvwSource.Items.Count; i++)
                    lvwSource.Items[i].Checked = true;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdSelectAll_Click", ex); }
        }
        private void cmdDeSelectAll_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Télécommande == true) { m_eMode = EnumMode.PIECE; }
                var lvwSource = default(ListView);
                switch (m_eMode){case EnumMode.PIECE: { lvwSource = lvwPiece; break; }
                    case EnumMode.Categorie: { lvwSource = lvwCategorie; break; }
                    case EnumMode.Fournisseur: { lvwSource = lvwFournisseur; break; }
                    case EnumMode.Manufacturier: { lvwSource = lvwManufacturier; break; }
                }
                for (int i = 0; i <lvwSource.Items.Count; i++)
                    lvwSource.Items[i].Checked = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdSelectAll_Click", ex); }
        }
        private void cmdTri_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_sTri = Interaction.InputBox("Quel est la pièce à trier?");
                if (!string.IsNullOrEmpty(m_sTri)){lvwCategorie.Enabled = true;
                    lvwPiece.Enabled = true;
                    lvwFournisseur.Enabled = true;
                    lvwNouvellesPieces.Enabled = true;
                    AjouterPieceCollection();
                    //                  RemplirListViewPiece();
                }return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdTri_Click", ex); }
        }
        private void cmdRafraichir_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(m_sTri)){m_sTri = string.Empty;
                    //    RemplirListViewPiece();
                }return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "cmdRafraichir_Click", ex); }
        }
        private void ChoixDemande_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                m_collPiece = new List<String>();
                m_collQuantite = new List<String>();
                m_collDescriptionFR = new List<String>();
                m_collDescriptionEN = new List<String>();
                m_collCategorie = new List<String>();
                m_collManufacturier = new List<String>();
                cmbTri.SelectedIndex = I_CMB_PIECE;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "Form_Load", ex); }
        }
        private void ChoixDemande_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            try
            {
                m_sTri = string.Empty;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "Form_Unload", ex); }
        }
        private void lvwCategorie_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader = lvwCategorie.Columns[eventArgs.Column];
            try
            {
                lvwCategorie.Sort();
                if (lvwCategorie.Sorting == SortOrder.Ascending){lvwCategorie.Sorting = SortOrder.Descending;}else{lvwCategorie.Sorting = SortOrder.Ascending;}
                lvwCategorie.Sorting.GetHashCode();
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "lvwCategorie_ColumnClick", ex); }
        }
        private void lvwFournisseur_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader = lvwFournisseur.Columns[eventArgs.Column];
            try
            {
                lvwFournisseur.Sort();
                if (lvwFournisseur.Sorting == SortOrder.Ascending){lvwFournisseur.Sorting = SortOrder.Descending;}else{lvwFournisseur.Sorting = SortOrder.Ascending;}
                lvwFournisseur.Sorting.GetHashCode();
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "lvwFournisseur_ColumnClick", ex); }
        }
        private void lvwFournisseur_ItemClick(ListViewItem Item)
        {
            try
            {
                if ((Item.SubItems[I_COL_LANGAGE].Text ?? "") == S_FRANCAIS){cmdLangage.Text = S_DEMANDE_ANGLAIS;}else{cmdLangage.Text = S_DEMANDE_FRANCAIS;}
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "lvwFournisseur_ItemClick", ex); }
        }
        private void lvwNouvellesPieces_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader = lvwNouvellesPieces.Columns[eventArgs.Column];
            try
            {
                lvwNouvellesPieces.Sort();
                if (lvwNouvellesPieces.Sorting == SortOrder.Ascending){lvwNouvellesPieces.Sorting = SortOrder.Descending;}else{lvwNouvellesPieces.Sorting = SortOrder.Ascending;}
                lvwNouvellesPieces.Sorting.GetHashCode();
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "lvwNouvellesPieces_ColumnClick", ex); }
        }
        private void lvwNouvellesPieces_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (eventArgs.KeyCode == Keys.Delete){lvwNouvellesPieces.Items.RemoveAt(lvwNouvellesPieces.FocusedItem.Index);}
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "lvwNouvellesPieces_KeyDown", ex); }
        }
        private void lvwPiece_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader = lvwPiece.Columns[eventArgs.Column];
            try
            {
                lvwPiece.Sort();
                if (lvwPiece.Sorting == SortOrder.Ascending){lvwPiece.Sorting = SortOrder.Descending;}else{lvwPiece.Sorting = SortOrder.Ascending;}
                lvwPiece.Sorting.GetHashCode();
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "lvwPiece_ColumnClick", ex); }
        }
        private void lvwPiece_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sQuantite;
                if (lvwPiece.Items.Count > 0){sQuantite = Interaction.InputBox("Quelle est la quantité?");
                    if (!string.IsNullOrEmpty(sQuantite))
                    {
                        if (IsNumeric(sQuantite)){lvwPiece.FocusedItem.Text = sQuantite;}
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "lvwPiece_DblClick", ex); }
        }
        private void AfficherFournisseur()
        {
            try
            {
                if (lvwPiece.Items.Count > 0){if (VerifierSiChecked() == true)
                    {
                        //                       RemplirListViewFournisseur(true);
                        if (lvwFournisseur.Items.Count > 0){AfficherControles(EnumMode.Fournisseur);}
                        else{MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);}
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "AfficherFournisseur", ex); }
        }
        private void AjouterPieceCollection()
        {
            try
            {
                bool bPieceExiste;
                int iQuantite;
                ADODB.Recordset rstTempDP;
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE) { UpdateSQL("DELETE FROM TempDP WHERE TYPE = 'E'"); ; } else { UpdateSQL("DELETE FROM TempDP WHERE TYPE = 'M'"); }
                rstTempDP = new Recordset();
                rstTempDP.Open("SELECT * FROM TempDP", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                for (int i = 0; i < lvwPiece.Items.Count; i++)
                {
                    if (lvwPiece.Items[i].Checked == true)
                    {
                        bPieceExiste = false;
                        for (int i2 = 1; i2 <= m_collPiece.Count; i2++)
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwPiece.Items[i].SubItems[I_COL_PIECE].Text, m_collPiece[i2], false))) { bPieceExiste = true; break; }
                            if (bPieceExiste == false)
                            {
                                m_collCategorie.Add(m_sCategorie);
                                m_collPiece.Add(lvwPiece.Items[i].SubItems[I_COL_PIECE].Text);
                                m_collDescriptionFR.Add(lvwPiece.Items[i].SubItems[I_COL_DESC_FR].Text);
                                m_collDescriptionEN.Add(lvwPiece.Items[i].SubItems[I_COL_DESC_EN].Text);
                                m_collManufacturier.Add(lvwPiece.Items[i].SubItems[I_COL_FABRICANT].Text);
                                if (!string.IsNullOrEmpty(lvwPiece.Items[i].Text)) { m_collQuantite.Add(lvwPiece.Items[i].Text); } else { m_collQuantite.Add("1"); }
                                rstTempDP.AddNew();
                                rstTempDP.Fields["PIECE"].Value = lvwPiece.Items[i].SubItems[I_COL_PIECE].Text;
                                rstTempDP.Fields["ORDRE"].Value = i;
                                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE) { rstTempDP.Fields["TYPE"].Value = "E"; } else { rstTempDP.Fields["TYPE"].Value = "M"; }
                                rstTempDP.Update();
                            }
                            else if (m_bProjSoum == true)
                            {
                                iQuantite = (int)Math.Round(Conversion.Val(m_collQuantite[i2]) + Conversion.Val(lvwPiece.Items[i].Text));
                                m_collQuantite.Remove(m_collQuantite[i2]);
                                if (m_collQuantite.Count > 0)
                                {
                                    if (m_collQuantite.Count < i2) { m_collQuantite.Add(iQuantite.ToString()); }
                                    else if (i2 > 1) { m_collQuantite.Insert(i2--, iQuantite.ToString()); }
                                    else { m_collQuantite.Insert(1, iQuantite.ToString()); }
                                }
                                else
                                {
                                    m_collQuantite.Add(iQuantite.ToString());
                                }
                            }
                        }
                    }
                }
                rstTempDP.Close();
                rstTempDP = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "AjouterPieceCollection", ex); }
        }
        private bool VerifierSiChecked()
        {
            bool VerifierSiCheckedRet = default;
            try
            {
                ListView lvwSource;
                if (lvwPiece.Visible == true){lvwSource = lvwPiece;}
                else if (lvwFournisseur.Visible == true){lvwSource = lvwFournisseur;}else{lvwSource = lvwCategorie;}
                VerifierSiCheckedRet = false;
                for (int i = 0; i <lvwSource.Items.Count; i++){if (lvwSource.Items[i].Checked == true)
                    {
                        VerifierSiCheckedRet = true;
                        break;
                    }
                }
                return VerifierSiCheckedRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDemande", "VerifierSiChecked", ex);
                return false;
            }
        }
        private void EnregistrerDemandePrixNouvellesPieces()
        {
            try
            {
                ADODB.Recordset rstImpDP;
                string sNomTable;
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE){sNomTable = "ImpressionDemandePrixElec";}else{sNomTable = "ImpressionDemandePrixMec";}
                rstImpDP = new Recordset();
                rstImpDP.CursorLocation = CursorLocationEnum.adUseClient;
                rstImpDP.Open("SELECT * FROM " + sNomTable, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                for (int i = 0; i <m_collPiece.Count; i++){rstImpDP.AddNew();
                    rstImpDP.Fields["NoPiece"].Value = m_collPiece[i];
                    rstImpDP.Fields["Qte"].Value = m_collQuantite[i];
                    rstImpDP.Fields["Description"].Value = m_collDescriptionFR[i];
                    rstImpDP.Fields["Manufacturier"].Value = m_collManufacturier[i];
                    rstImpDP.Update();}
                rstImpDP.Requery();
                var loopTo1 = (int)rstImpDP.RecordCount;
                for (int i = 15; i >= loopTo1; i += -1){rstImpDP.AddNew();
                    rstImpDP.Fields["NoPiece"].Value = string.Empty;
                    rstImpDP.Fields["Qte"].Value = string.Empty;
                    rstImpDP.Fields["Description"].Value = string.Empty;
                    rstImpDP.Fields["Manufacturier"].Value = string.Empty;
                    rstImpDP.Update();}
                rstImpDP.Close();
                rstImpDP = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "EnregistrerDemandePrixNouvellesPieces", ex); }
        }
        private void EnregistrerDemandePrix(int iIDFRS)
        {
            try
            {
                ADODB.Recordset rstImpDP;
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstPiece;
                string sNomTable;
                string sWhere;
                string sCategorie;
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE){sNomTable = "ImpressionDemandePrixElec";}else{sNomTable = "ImpressionDemandePrixMec";}
                rstImpDP = new Recordset();
                rstPiece = new Recordset();
                rstPieceFRS = new Recordset();
                rstImpDP.CursorLocation = CursorLocationEnum.adUseClient;
                rstImpDP.Open("SELECT * FROM " + sNomTable, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (m_eDemande != EnumModeDemande.MODE_PIECE){switch (m_eDemande)
                    {
                        case EnumModeDemande.MODE_FOURNISSEUR:
                            {
                                rstPieceFRS.Open("SELECT * FROM PiecesFRS WHERE IDFRS = " + iIDFRS + " ORDER BY PIECE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                break;
                            }
                        case EnumModeDemande.MODE_CATEGORIE:
                            {
                                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                                {
                                    sWhere = " AND CatalogueElec.CATEGORIE In (";
                                }
                                else
                                {
                                    sWhere = " AND CatalogueMec.CATEGORIE In (";
                                }
                                var loopTo = (int)m_collCategorie.Count;
                                for (int i = 1; i <= loopTo; i++)
                                {
                                    sCategorie = m_collCategorie[i].Replace("'", "''");
                                    if (i != m_collCategorie.Count)
                                    {
                                        sWhere += "'" + sCategorie + "',";
                                    }
                                    else
                                    {
                                        sWhere += "'" + sCategorie + "')";
                                    }
                                }
                                rstPieceFRS.Open("SELECT PiecesFRS.* FROM PiecesFRS " +
                                    "INNER JOIN CatalogueMec ON PiecesFRS.PIECE = CatalogueMec.PIECE " +
                                    "WHERE PiecesFRS.IDFRS = " + iIDFRS + sWhere + " ORDER BY PiecesFRS.PIECE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                break;
                            }
                    }
                    while (!rstPieceFRS.EOF)
                    {
                        if ($"{rstPieceFRS.Fields["Type"].Value}".Substring(0, 1) == "E"){rstPiece.Open("SELECT FABRICANT, DESC_FR, DESC_EN FROM CatalogueElec " +
                                "WHERE PIECE = '" + $"{rstPieceFRS.Fields["PIECE"].Value}".Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}
                        else{rstPiece.Open("SELECT FABRICANT, DESC_FR, DESC_EN FROM CatalogueMec " +
                                "WHERE PIECE = '" + $"{rstPieceFRS.Fields["PIECE"].Value}".Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);}
                        if (!rstPiece.EOF){if (m_collManufacturier.Count > 0)
                            {
                                var loopTo1 = (int)m_collManufacturier.Count;
                                for (int i = 1; i <= loopTo1; i++)
                                {
                                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(m_collManufacturier[(int)i], rstPiece.Fields["FABRICANT"].Value, false)))
                                    {
                                        rstImpDP.AddNew();
                                        rstImpDP.Fields["NoPiece"].Value = rstPieceFRS.Fields["PIECE"].Value;
                                        rstImpDP.Fields["Qte"].Value = "1";
                                        if ((m_sLangage ?? "") == S_FRANCAIS) { rstImpDP.Fields["Description"].Value = rstPiece.Fields["DESC_FR"].Value; } else { rstImpDP.Fields["Description"].Value = rstPiece.Fields["DESC_EN"].Value; }
                                        rstImpDP.Fields["Manufacturier"].Value = rstPiece.Fields["FABRICANT"].Value;
                                        rstImpDP.Update();
                                    }
                                }
                            }
                            else
                            {
                                rstImpDP.AddNew();
                                rstImpDP.Fields["NoPiece"].Value = rstPieceFRS.Fields["PIECE"].Value;
                                rstImpDP.Fields["Qte"].Value = "1";
                                if ((m_sLangage ?? "") == S_FRANCAIS) { rstImpDP.Fields["Description"].Value = rstPiece.Fields["DESC_FR"].Value; } else { rstImpDP.Fields["Description"].Value = rstPiece.Fields["DESC_EN"].Value; }
                                rstImpDP.Fields["Manufacturier"].Value = rstPiece.Fields["FABRICANT"].Value;
                                rstImpDP.Update();
                            }
                        }
                        else { rstPieceFRS.Delete(); }
                        rstPiece.Close();
                        rstPieceFRS.MoveNext();
                    }
                    rstPiece = null;
                    rstPieceFRS.Close();
                    rstPieceFRS = null;}else{if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                    {
                        rstPieceFRS.Open("SELECT PiecesFRS.PIECE FROM PiecesFRS " +
                            "INNER JOIN TempDP ON PiecesFRS.PIECE = TempDP.PIECE " +
                            "WHERE PiecesFRS.IDFRS = " + iIDFRS + " AND TempDP.TYPE = 'E' " +
                            "GROUP BY PiecesFRS.PIECE, ORDRE ORDER BY TempDP.ORDRE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstPieceFRS.Open("SELECT PiecesFRS.PIECE FROM PiecesFRS " +
                            "INNER JOIN TempDP ON PiecesFRS.PIECE = TempDP.PIECE " +
                            "WHERE PiecesFRS.IDFRS = " + iIDFRS + " AND TempDP.TYPE = 'M' " +
                            "GROUP BY PiecesFRS.PIECE, ORDRE ORDER BY TempDP.ORDRE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    while (!rstPieceFRS.EOF)
                    {
                        for (int i = 1; i < m_collPiece.Count; i++){if (m_collPiece[i] != $"{rstPieceFRS.Fields["PIECE"].Value}".Trim())
                            {
                                rstImpDP.AddNew();
                                rstImpDP.Fields["NoPiece"].Value = m_collPiece[i];
                                rstImpDP.Fields["Qte"].Value = m_collQuantite[i];
                                if ((m_sLangage ?? "") == S_FRANCAIS) { rstImpDP.Fields["Description"].Value = m_collDescriptionFR[i]; } else { rstImpDP.Fields["Description"].Value = m_collDescriptionEN[i]; }
                                rstImpDP.Fields["Manufacturier"].Value = m_collManufacturier[i];
                                rstImpDP.Update();
                                break;
                            }
                        }
                        rstPieceFRS.MoveNext();
                    }
                    rstPieceFRS.Close();
                    rstPieceFRS = null;}
                rstImpDP.Requery();
                for (int i = 15; i >=(rstImpDP.RecordCount + 1) ; i--){rstImpDP.AddNew();
                    rstImpDP.Fields["NoPiece"].Value = string.Empty;
                    rstImpDP.Fields["Qte"].Value = string.Empty;
                    rstImpDP.Fields["Description"].Value = string.Empty;
                    rstImpDP.Fields["Manufacturier"].Value = string.Empty;
                    rstImpDP.Update();}
                rstImpDP.Close();
                rstImpDP = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "EnregistrerDemandePrix", ex); }
        }
        [Obsolete]
        private void ImprimerDemandePrix(int iIDFRS)
        {
            try
            {
                ADODB.Recordset rstImpDP;
                ADODB.Recordset rstFRS;
                string sNomTable;
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE){sNomTable = "ImpressionDemandePrixElec";}else{sNomTable = "ImpressionDemandePrixMec";}
                rstFRS = new Recordset();
                rstImpDP = new Recordset();
                rstFRS.Open("SELECT * FROM Fournisseur WHERE IDFRS = " + iIDFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstImpDP.Open("SELECT * FROM " + sNomTable, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViewDemandePrix.Orientation = false;
                if ((m_sLangage ?? "") == S_ANGLAIS){ViewDemandePrix.lblTitreDemande.Text = "Price and Delivery Request";
                    ViewDemandePrix.lblTitreFournisseur.Text = "Supplier :";
                    ViewDemandePrix.lblTitreContact.Text = "Contact :";
                    ViewDemandePrix.lblTitreTransport.Text = "Transport :";
                    ViewDemandePrix.lblTitreDateReq.Text = "Required Date :";
                    ViewDemandePrix.lblTitreNoSoum.Text = "Your Ref # :";
                    ViewDemandePrix.lblTitreTel.Text = "Telephone :";
                    ViewDemandePrix.lblTitreFax.Text = "Fax :";
                    ViewDemandePrix.lblTitreNoGRB.Text = "OUR # :";
                    ViewDemandePrix.lblTitreDate.Text = "Date :";
                    ViewDemandePrix.lblTitreComPar.Text = "Purchaser :";
                    ViewDemandePrix.lblTitrePage.Text = "Page :";
                    ViewDemandePrix.lblTitreQte.Text = "Qty";
                    ViewDemandePrix.lblTitrePiece.Text = "Part Number";
                    ViewDemandePrix.lblTitreDescription.Text = "Description";
                    ViewDemandePrix.lblTitreManufact.Text = "Manufacturer";
                    ViewDemandePrix.lblTitreDelais.Text = "Delay";
                    ViewDemandePrix.lblTitreCommentaire.Text = "Comments :";
                    ViewDemandePrix.lblPrixValide.Text = "Valid price for";
                    ViewDemandePrix.lblJours.Text = "Days";
                    ViewDemandePrix.lblPiedPage.Text = "THIS IS NOT AN ORDER";}
                ViewDemandePrix.lblFournisseur.Text = rstFRS.Fields["NomFournisseur"].Value;
                ViewDemandePrix.lblContact.Text = m_sContact;
                if (!(rstFRS.Fields["CondTransport"].Value is DBNull)) { ViewDemandePrix.lblTransport.Text = rstFRS.Fields["CondTransport"].Value; } else { ViewDemandePrix.lblTransport.Text = ""; }
                ViewDemandePrix.lblDateRequise.Text = mskDateRequise.Text;
                ViewDemandePrix.lblTel.Text = rstFRS.Fields["Telephonne"].Value;
                ViewDemandePrix.lblFax.Text = rstFRS.Fields["Fax"].Value;
                ViewDemandePrix.lblNoGRB.Text = txtNoGRB.Text;
                ViewDemandePrix.lblDate.Text = ConvertDate(DateTime.Today);
                ViewDemandePrix.lblCommandePar.Text = IdNomEmploye;
                ViewDemandePrix.lblCommentaire.Text = txtCommentaire.Text;
                ViewDemandePrix.Orientation = false;
                ViewDemandePrix f = new ViewDemandePrix();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                UpdateSQL("DELETE FROM " + sNomTable);
                rstImpDP.Close();
                rstImpDP = null;
                rstFRS.Close();
                rstFRS = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "ImprimerDemandePrix", ex); }
        }
        private void mskDateRequise_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Strings.Len(mskDateRequise.Text) == 10){mskDateRequise.Text = Droite(mskDateRequise.Text, 8);}
                mskDateRequise.Mask = "##-##-##";
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "mskDateRequise_GotFocus", ex); }
        }
        private void mskDateRequise_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskDateRequise.Mask = string.Empty;
                if (mskDateRequise.Text == "__-__-__"){mskDateRequise.Text = string.Empty;}
                else if (Strings.Len(mskDateRequise.Text) == 8){if (Information.IsDate(mskDateRequise.Text))
                    {
                        mskDateRequise.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateAndTime.DateSerial(int.Parse(Gauche(mskDateRequise.Text, 2)),
                            int.Parse(mskDateRequise.Text.Substring(4, 2)),
                            int.Parse(Droite(mskDateRequise.Text, 2)))) + mskDateRequise.Text.Substring(3, 8);
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "mskDateRequise_LostFocus", ex); }
        }
        private void txtRechercher_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                cmdRechercher.Text = "Rechercher";
                return;
            }
            catch (Exception ex) { AfficherErreur("ChoixDemande", "txtRechercher_Change", ex); }
        }
        private void lvwCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPiece.Items.Count > 0)
            {
            }
        }
        private void lvwManufacturier_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
 /*       public ChoixDemande(bool télécommande)
        {
            Télécommande = télécommande;
            InitializeComponent();
            List<String> Distributeurs = new List<String>();
            lvwPiece.Items.Clear();
            lvwPiece.Columns[3].Text = "Fournisseur";
            Afficher(eLECTRIQUE, EnumModeDemande.MODE_PIECE);
            ModeTelecomande(Télécommande);
            Recordset rd = new Recordset();
            rd.Open($" SELECT DISTINCT NOMFOURNISSEUR FROM [DBO].[ACHAT_PIECES] " +
                $"JOIN [DBO].[FOURNISSEUR] ON [DBO].[ACHAT_PIECES].IDFRS=[DBO].[FOURNISSEUR].IDFRS " +
                $"WHERE  [IDACHAT]= '{Gauche(ACHAT.cmbNoAchat.Text,9)}' AND INDEXACHAT = '{int.Parse(Droite(ACHAT.cmbNoAchat.Text,3))}' " +
                $"ORDER BY NomFournisseur DESC",odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                Distributeurs.Add($"{rd.Fields[0].Value}");
                ListViewItem ifrs=lvwFournisseur.Items.Add(string.Empty);
                ifrs.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null,$"{rd.Fields[0].Value}"));
                comboBox1.Items.Add($"{rd.Fields[0].Value}");
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            Conteneur.txtStatus.Text = $"{Distributeurs.Count} distributeurs trouvés pour le projet {Gauche(ACHAT.cmbNoAchat.Text, 9)}";
            items = ACHAT.lvwAchat.SelectedItems;
            lvwPiece.ForeColor = Color.CadetBlue;
            foreach(ListViewItem p in items)
            {
               ListViewItem itm =lvwPiece.Items.Add(string.Empty);
                itm.Text = p.SubItems[0].Text;
                itm.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null, p.SubItems[1].Text));
                itm.SubItems.Insert(I_COL_DESC_FR, new ListViewItem.ListViewSubItem(null, p.SubItems[2].Text));
                itm.SubItems.Insert(I_COL_DESC_EN, new ListViewItem.ListViewSubItem(null, p.SubItems[7].Text));
                itm.SubItems.Insert(I_COL_FABRICANT, new ListViewItem.ListViewSubItem(null, p.SubItems[3].Text));
                itm.Checked = false;
            }
        }*/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdDeSelectAll_Click(sender, e);
            for(int a= 0  ; a<lvwPiece.Items.Count; a++)
            {
                if (lvwPiece.Items[a].SubItems[3].Text == comboBox1.Text) lvwPiece.Items[a].Checked = true;
            }
        }
    }
}