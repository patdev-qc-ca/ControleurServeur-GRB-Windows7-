using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ADODB;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ListViewItem = System.Windows.Forms.ListViewItem;
#pragma warning disable CS0649
namespace ControleurServeur
{
    internal class Fournisseurs : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public Fournisseurs() : base()
        {
            InitializeComponent();
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
        internal System.Windows.Forms.Button cmdcatmod;
        internal System.Windows.Forms.Button cmb_modAnu;
        internal System.Windows.Forms.Button cmdCatAdd;
        internal System.Windows.Forms.Button cmdcatval;
        internal System.Windows.Forms.TextBox txtmodcat;
        internal GroupBox CatMod;
        internal System.Windows.Forms.Button cmdAnnuller;
        internal System.Windows.Forms.Button cmdcatenr;
        internal ColumnHeader _Lst_Cat_ColumnHeader_1;
        internal System.Windows.Forms.ListView Lst_Cat;
        internal GroupBox _Categorie;
        internal ComboBox cmbcatégorie;
        internal System.Windows.Forms.Button cmdMailListFournisseur;
        internal System.Windows.Forms.Label lblEtatOutlook;
        internal System.Windows.Forms.Panel fraEtatOutlook;
        internal System.Windows.Forms.Button cmdFax;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.Button cmdMailListContact;
        internal System.Windows.Forms.TextBox txtContactTitre;
        internal System.Windows.Forms.TextBox txtContactPage;
        internal System.Windows.Forms.TextBox txtContactEmail;
        internal System.Windows.Forms.TextBox txtContactPoste;
        internal System.Windows.Forms.TextBox txtContactTel;
        internal ComboBox cmbcontact;
        internal System.Windows.Forms.TextBox txtContactFax;
        internal System.Windows.Forms.TextBox txtContactCell;
        internal System.Windows.Forms.Button cmdsupcontact;
        internal System.Windows.Forms.TextBox txtContactDom;
        internal System.Windows.Forms.Button CmdAddCont;
        internal System.Windows.Forms.Button cmdEnregistrerContact;
        internal System.Windows.Forms.Button cmdAnnulerContact;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.Label _Label1_8;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label _Label1_7;
        internal System.Windows.Forms.Label _Label1_5;
        internal System.Windows.Forms.Label _Label1_4;
        internal System.Windows.Forms.Label _Label1_3;
        internal System.Windows.Forms.Label _Label1_2;
        internal System.Windows.Forms.Label _Label1_1;
        internal System.Windows.Forms.Label _Label1_6;
        internal GroupBox fraContact;
        internal System.Windows.Forms.Button cmdRafraichir;
        internal System.Windows.Forms.Button cmdreport;
        internal System.Windows.Forms.TextBox txtSiteWeb;
        internal System.Windows.Forms.Button cmdrenommer;
        internal System.Windows.Forms.TextBox txtCommentaire;
        internal System.Windows.Forms.TextBox txtRechercher;
        internal System.Windows.Forms.Button CmdModif;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtTelephone;
        internal System.Windows.Forms.TextBox txtCP;
        internal System.Windows.Forms.TextBox txtPays;
        internal System.Windows.Forms.TextBox txtProvEtat;
        internal System.Windows.Forms.TextBox txtVille;
        internal System.Windows.Forms.TextBox txtAdresse;
        internal System.Windows.Forms.Button CmdFerme;
        internal System.Windows.Forms.Button CmdSupp;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button CmdEnr;
        internal ComboBox cmbFournisseur;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblUserModification;
        internal System.Windows.Forms.Label lblUserCreation;
        internal System.Windows.Forms.Label lblDateModification;
        internal System.Windows.Forms.Label lblDateCreation;
        internal System.Windows.Forms.Label _Label12_3;
        internal System.Windows.Forms.Label _Label12_2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label _Label12_1;
        internal System.Windows.Forms.Label lblRechercher;
        internal System.Windows.Forms.Label _Label12_0;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label _Label1_0;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._Categorie = new System.Windows.Forms.GroupBox();
            this.cmdcatmod = new System.Windows.Forms.Button();
            this.cmb_modAnu = new System.Windows.Forms.Button();
            this.cmdCatAdd = new System.Windows.Forms.Button();
            this.cmdcatval = new System.Windows.Forms.Button();
            this.fraEtatOutlook = new System.Windows.Forms.Panel();
            this.lblEtatOutlook = new System.Windows.Forms.Label();
            this.CatMod = new System.Windows.Forms.GroupBox();
            this.txtmodcat = new System.Windows.Forms.TextBox();
            this.cmdAnnuller = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdcatenr = new System.Windows.Forms.Button();
            this.Lst_Cat = new System.Windows.Forms.ListView();
            this._Lst_Cat_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbcatégorie = new System.Windows.Forms.ComboBox();
            this.cmdMailListFournisseur = new System.Windows.Forms.Button();
            this.cmdFax = new System.Windows.Forms.Button();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.fraContact = new System.Windows.Forms.GroupBox();
            this.cmdMailListContact = new System.Windows.Forms.Button();
            this.txtContactTitre = new System.Windows.Forms.TextBox();
            this.txtContactPage = new System.Windows.Forms.TextBox();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.txtContactPoste = new System.Windows.Forms.TextBox();
            this.txtContactTel = new System.Windows.Forms.TextBox();
            this.cmbcontact = new System.Windows.Forms.ComboBox();
            this.txtContactFax = new System.Windows.Forms.TextBox();
            this.txtContactCell = new System.Windows.Forms.TextBox();
            this.cmdsupcontact = new System.Windows.Forms.Button();
            this.txtContactDom = new System.Windows.Forms.TextBox();
            this.CmdAddCont = new System.Windows.Forms.Button();
            this.cmdEnregistrerContact = new System.Windows.Forms.Button();
            this.cmdAnnulerContact = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this._Label1_8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this._Label1_7 = new System.Windows.Forms.Label();
            this._Label1_5 = new System.Windows.Forms.Label();
            this._Label1_4 = new System.Windows.Forms.Label();
            this._Label1_3 = new System.Windows.Forms.Label();
            this._Label1_2 = new System.Windows.Forms.Label();
            this._Label1_1 = new System.Windows.Forms.Label();
            this._Label1_6 = new System.Windows.Forms.Label();
            this.cmdRafraichir = new System.Windows.Forms.Button();
            this.cmdreport = new System.Windows.Forms.Button();
            this.txtSiteWeb = new System.Windows.Forms.TextBox();
            this.cmdrenommer = new System.Windows.Forms.Button();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.CmdModif = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.txtProvEtat = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.CmdFerme = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdEnr = new System.Windows.Forms.Button();
            this.cmbFournisseur = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblUserModification = new System.Windows.Forms.Label();
            this.lblUserCreation = new System.Windows.Forms.Label();
            this.lblDateModification = new System.Windows.Forms.Label();
            this.lblDateCreation = new System.Windows.Forms.Label();
            this._Label12_3 = new System.Windows.Forms.Label();
            this._Label12_2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this._Label12_1 = new System.Windows.Forms.Label();
            this.lblRechercher = new System.Windows.Forms.Label();
            this._Label12_0 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this._Label1_0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNomFournisseur = new System.Windows.Forms.TextBox();
            this.cmdRechercher = new System.Windows.Forms.Button();
            this._Categorie.SuspendLayout();
            this.fraEtatOutlook.SuspendLayout();
            this.CatMod.SuspendLayout();
            this.fraContact.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Categorie
            // 
            this._Categorie.BackColor = System.Drawing.Color.Black;
            this._Categorie.Controls.Add(this.cmdcatmod);
            this._Categorie.Controls.Add(this.cmb_modAnu);
            this._Categorie.Controls.Add(this.cmdCatAdd);
            this._Categorie.Controls.Add(this.cmdcatval);
            this._Categorie.Controls.Add(this.fraEtatOutlook);
            this._Categorie.Controls.Add(this.CatMod);
            this._Categorie.Controls.Add(this.cmdAnnuller);
            this._Categorie.Controls.Add(this.listView1);
            this._Categorie.Controls.Add(this.cmdcatenr);
            this._Categorie.Controls.Add(this.Lst_Cat);
            this._Categorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Categorie.ForeColor = System.Drawing.Color.White;
            this._Categorie.Location = new System.Drawing.Point(1, 48);
            this._Categorie.Name = "_Categorie";
            this._Categorie.Padding = new System.Windows.Forms.Padding(0);
            this._Categorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Categorie.Size = new System.Drawing.Size(613, 445);
            this._Categorie.TabIndex = 79;
            this._Categorie.TabStop = false;
            this._Categorie.Text = "Frame1";
            this._Categorie.Visible = false;
            // 
            // cmdcatmod
            // 
            this.cmdcatmod.AutoSize = true;
            this.cmdcatmod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdcatmod.BackColor = System.Drawing.Color.Black;
            this.cmdcatmod.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdcatmod.Enabled = false;
            this.cmdcatmod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdcatmod.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcatmod.ForeColor = System.Drawing.Color.White;
            this.cmdcatmod.Location = new System.Drawing.Point(404, 397);
            this.cmdcatmod.Name = "cmdcatmod";
            this.cmdcatmod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdcatmod.Size = new System.Drawing.Size(63, 23);
            this.cmdcatmod.TabIndex = 83;
            this.cmdcatmod.Text = "Modifier";
            this.cmdcatmod.UseVisualStyleBackColor = true;
            this.cmdcatmod.Click += new System.EventHandler(this.cmdcatmod_Click);
            // 
            // cmb_modAnu
            // 
            this.cmb_modAnu.AutoSize = true;
            this.cmb_modAnu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmb_modAnu.BackColor = System.Drawing.Color.Black;
            this.cmb_modAnu.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_modAnu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_modAnu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_modAnu.ForeColor = System.Drawing.Color.White;
            this.cmb_modAnu.Location = new System.Drawing.Point(404, 397);
            this.cmb_modAnu.Name = "cmb_modAnu";
            this.cmb_modAnu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_modAnu.Size = new System.Drawing.Size(62, 23);
            this.cmb_modAnu.TabIndex = 89;
            this.cmb_modAnu.Text = "Annuller";
            this.cmb_modAnu.UseVisualStyleBackColor = true;
            this.cmb_modAnu.Click += new System.EventHandler(this.cmb_modAnu_Click);
            // 
            // cmdCatAdd
            // 
            this.cmdCatAdd.AutoSize = true;
            this.cmdCatAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdCatAdd.BackColor = System.Drawing.Color.Black;
            this.cmdCatAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCatAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCatAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCatAdd.ForeColor = System.Drawing.Color.White;
            this.cmdCatAdd.Location = new System.Drawing.Point(344, 397);
            this.cmdCatAdd.Name = "cmdCatAdd";
            this.cmdCatAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCatAdd.Size = new System.Drawing.Size(57, 23);
            this.cmdCatAdd.TabIndex = 82;
            this.cmdCatAdd.Text = "Ajouter";
            this.cmdCatAdd.UseVisualStyleBackColor = true;
            this.cmdCatAdd.Click += new System.EventHandler(this.cmdCatAdd_Click);
            // 
            // cmdcatval
            // 
            this.cmdcatval.AutoSize = true;
            this.cmdcatval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdcatval.BackColor = System.Drawing.Color.Black;
            this.cmdcatval.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdcatval.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdcatval.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcatval.ForeColor = System.Drawing.Color.White;
            this.cmdcatval.Location = new System.Drawing.Point(334, 397);
            this.cmdcatval.Name = "cmdcatval";
            this.cmdcatval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdcatval.Size = new System.Drawing.Size(64, 23);
            this.cmdcatval.TabIndex = 88;
            this.cmdcatval.Text = "Accepter";
            this.cmdcatval.UseVisualStyleBackColor = true;
            this.cmdcatval.Visible = false;
            this.cmdcatval.Click += new System.EventHandler(this.cmdcatval_Click);
            // 
            // fraEtatOutlook
            // 
            this.fraEtatOutlook.BackColor = System.Drawing.Color.Black;
            this.fraEtatOutlook.Controls.Add(this.lblEtatOutlook);
            this.fraEtatOutlook.Cursor = System.Windows.Forms.Cursors.Default;
            this.fraEtatOutlook.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraEtatOutlook.Location = new System.Drawing.Point(64, 105);
            this.fraEtatOutlook.Name = "fraEtatOutlook";
            this.fraEtatOutlook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraEtatOutlook.Size = new System.Drawing.Size(505, 145);
            this.fraEtatOutlook.TabIndex = 16;
            this.fraEtatOutlook.Visible = false;
            // 
            // lblEtatOutlook
            // 
            this.lblEtatOutlook.BackColor = System.Drawing.Color.Black;
            this.lblEtatOutlook.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEtatOutlook.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtatOutlook.ForeColor = System.Drawing.Color.White;
            this.lblEtatOutlook.Location = new System.Drawing.Point(0, 56);
            this.lblEtatOutlook.Name = "lblEtatOutlook";
            this.lblEtatOutlook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEtatOutlook.Size = new System.Drawing.Size(505, 25);
            this.lblEtatOutlook.TabIndex = 17;
            this.lblEtatOutlook.Text = "Liaison du contact avec le fournisseur dans Outlook ..";
            this.lblEtatOutlook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CatMod
            // 
            this.CatMod.BackColor = System.Drawing.Color.Black;
            this.CatMod.Controls.Add(this.txtmodcat);
            this.CatMod.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatMod.Location = new System.Drawing.Point(144, 16);
            this.CatMod.Name = "CatMod";
            this.CatMod.Padding = new System.Windows.Forms.Padding(0);
            this.CatMod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CatMod.Size = new System.Drawing.Size(193, 49);
            this.CatMod.TabIndex = 86;
            this.CatMod.TabStop = false;
            this.CatMod.Text = "Frame1";
            this.CatMod.Visible = false;
            // 
            // txtmodcat
            // 
            this.txtmodcat.AcceptsReturn = true;
            this.txtmodcat.BackColor = System.Drawing.Color.Black;
            this.txtmodcat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmodcat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodcat.Location = new System.Drawing.Point(24, 16);
            this.txtmodcat.MaxLength = 0;
            this.txtmodcat.Name = "txtmodcat";
            this.txtmodcat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtmodcat.Size = new System.Drawing.Size(145, 22);
            this.txtmodcat.TabIndex = 87;
            this.txtmodcat.Text = "Text1";
            // 
            // cmdAnnuller
            // 
            this.cmdAnnuller.AutoSize = true;
            this.cmdAnnuller.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAnnuller.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuller.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdAnnuller.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnuller.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuller.ForeColor = System.Drawing.Color.White;
            this.cmdAnnuller.Location = new System.Drawing.Point(540, 397);
            this.cmdAnnuller.Name = "cmdAnnuller";
            this.cmdAnnuller.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuller.Size = new System.Drawing.Size(62, 23);
            this.cmdAnnuller.TabIndex = 85;
            this.cmdAnnuller.Text = "Annuller";
            this.cmdAnnuller.UseVisualStyleBackColor = true;
            this.cmdAnnuller.Click += new System.EventHandler(this.cmdAnnuller_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(597, 372);
            this.listView1.TabIndex = 80;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Actif";
            this.columnHeader1.Width = 170;
            // 
            // cmdcatenr
            // 
            this.cmdcatenr.AutoSize = true;
            this.cmdcatenr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdcatenr.BackColor = System.Drawing.Color.Black;
            this.cmdcatenr.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdcatenr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdcatenr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcatenr.ForeColor = System.Drawing.Color.White;
            this.cmdcatenr.Location = new System.Drawing.Point(469, 397);
            this.cmdcatenr.Name = "cmdcatenr";
            this.cmdcatenr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdcatenr.Size = new System.Drawing.Size(75, 23);
            this.cmdcatenr.TabIndex = 84;
            this.cmdcatenr.Text = "Enregistrer";
            this.cmdcatenr.UseVisualStyleBackColor = true;
            this.cmdcatenr.Click += new System.EventHandler(this.cmdcatenr_Click);
            // 
            // Lst_Cat
            // 
            this.Lst_Cat.BackColor = System.Drawing.Color.Black;
            this.Lst_Cat.CheckBoxes = true;
            this.Lst_Cat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Lst_Cat_ColumnHeader_1});
            this.Lst_Cat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_Cat.ForeColor = System.Drawing.Color.White;
            this.Lst_Cat.GridLines = true;
            this.Lst_Cat.HideSelection = false;
            this.Lst_Cat.Location = new System.Drawing.Point(3, 15);
            this.Lst_Cat.Name = "Lst_Cat";
            this.Lst_Cat.Size = new System.Drawing.Size(597, 372);
            this.Lst_Cat.TabIndex = 80;
            this.Lst_Cat.UseCompatibleStateImageBehavior = false;
            this.Lst_Cat.View = System.Windows.Forms.View.Details;
            // 
            // _Lst_Cat_ColumnHeader_1
            // 
            this._Lst_Cat_ColumnHeader_1.Text = "Actif";
            this._Lst_Cat_ColumnHeader_1.Width = 170;
            // 
            // cmbcatégorie
            // 
            this.cmbcatégorie.BackColor = System.Drawing.Color.White;
            this.cmbcatégorie.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbcatégorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcatégorie.ForeColor = System.Drawing.Color.White;
            this.cmbcatégorie.Location = new System.Drawing.Point(94, 120);
            this.cmbcatégorie.Name = "cmbcatégorie";
            this.cmbcatégorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbcatégorie.Size = new System.Drawing.Size(139, 22);
            this.cmbcatégorie.TabIndex = 77;
            this.cmbcatégorie.SelectedIndexChanged += new System.EventHandler(this.cmbcatégorie_SelectedIndexChanged);
            // 
            // cmdMailListFournisseur
            // 
            this.cmdMailListFournisseur.AutoSize = true;
            this.cmdMailListFournisseur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdMailListFournisseur.BackColor = System.Drawing.Color.Black;
            this.cmdMailListFournisseur.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdMailListFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMailListFournisseur.ForeColor = System.Drawing.Color.White;
            this.cmdMailListFournisseur.Location = new System.Drawing.Point(440, 456);
            this.cmdMailListFournisseur.Name = "cmdMailListFournisseur";
            this.cmdMailListFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdMailListFournisseur.Size = new System.Drawing.Size(126, 24);
            this.cmdMailListFournisseur.TabIndex = 75;
            this.cmdMailListFournisseur.Text = "Ajouter au mailing list";
            this.cmdMailListFournisseur.UseVisualStyleBackColor = true;
            this.cmdMailListFournisseur.Click += new System.EventHandler(this.cmdMailListFournisseur_Click);
            // 
            // cmdFax
            // 
            this.cmdFax.AutoSize = true;
            this.cmdFax.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdFax.BackColor = System.Drawing.Color.Black;
            this.cmdFax.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFax.ForeColor = System.Drawing.Color.White;
            this.cmdFax.Location = new System.Drawing.Point(358, 456);
            this.cmdFax.Name = "cmdFax";
            this.cmdFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFax.Size = new System.Drawing.Size(78, 24);
            this.cmdFax.TabIndex = 73;
            this.cmdFax.Text = "Envoyer Fax";
            this.cmdFax.UseVisualStyleBackColor = true;
            this.cmdFax.Click += new System.EventHandler(this.cmdFax_Click);
            // 
            // txtFax
            // 
            this.txtFax.AcceptsReturn = true;
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.ForeColor = System.Drawing.Color.White;
            this.txtFax.Location = new System.Drawing.Point(96, 180);
            this.txtFax.MaxLength = 0;
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFax.Size = new System.Drawing.Size(137, 22);
            this.txtFax.TabIndex = 14;
            this.txtFax.Text = "  ";
            // 
            // fraContact
            // 
            this.fraContact.BackColor = System.Drawing.Color.Black;
            this.fraContact.Controls.Add(this.cmdMailListContact);
            this.fraContact.Controls.Add(this.txtContactTitre);
            this.fraContact.Controls.Add(this.txtContactPage);
            this.fraContact.Controls.Add(this.txtContactEmail);
            this.fraContact.Controls.Add(this.txtContactPoste);
            this.fraContact.Controls.Add(this.txtContactTel);
            this.fraContact.Controls.Add(this.cmbcontact);
            this.fraContact.Controls.Add(this.txtContactFax);
            this.fraContact.Controls.Add(this.txtContactCell);
            this.fraContact.Controls.Add(this.cmdsupcontact);
            this.fraContact.Controls.Add(this.txtContactDom);
            this.fraContact.Controls.Add(this.CmdAddCont);
            this.fraContact.Controls.Add(this.cmdEnregistrerContact);
            this.fraContact.Controls.Add(this.cmdAnnulerContact);
            this.fraContact.Controls.Add(this.txtContact);
            this.fraContact.Controls.Add(this._Label1_8);
            this.fraContact.Controls.Add(this.Label2);
            this.fraContact.Controls.Add(this._Label1_7);
            this.fraContact.Controls.Add(this._Label1_5);
            this.fraContact.Controls.Add(this._Label1_4);
            this.fraContact.Controls.Add(this._Label1_3);
            this.fraContact.Controls.Add(this._Label1_2);
            this.fraContact.Controls.Add(this._Label1_1);
            this.fraContact.Controls.Add(this._Label1_6);
            this.fraContact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraContact.ForeColor = System.Drawing.Color.White;
            this.fraContact.Location = new System.Drawing.Point(290, 140);
            this.fraContact.Name = "fraContact";
            this.fraContact.Padding = new System.Windows.Forms.Padding(0);
            this.fraContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraContact.Size = new System.Drawing.Size(297, 305);
            this.fraContact.TabIndex = 37;
            this.fraContact.TabStop = false;
            this.fraContact.Text = "Contact";
            // 
            // cmdMailListContact
            // 
            this.cmdMailListContact.AutoSize = true;
            this.cmdMailListContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdMailListContact.BackColor = System.Drawing.Color.Black;
            this.cmdMailListContact.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdMailListContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMailListContact.ForeColor = System.Drawing.Color.White;
            this.cmdMailListContact.Location = new System.Drawing.Point(171, 264);
            this.cmdMailListContact.Name = "cmdMailListContact";
            this.cmdMailListContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdMailListContact.Size = new System.Drawing.Size(126, 24);
            this.cmdMailListContact.TabIndex = 76;
            this.cmdMailListContact.Text = "Ajouter au mailing list";
            this.cmdMailListContact.UseVisualStyleBackColor = true;
            this.cmdMailListContact.Click += new System.EventHandler(this.cmdMailListContact_Click);
            // 
            // txtContactTitre
            // 
            this.txtContactTitre.AcceptsReturn = true;
            this.txtContactTitre.BackColor = System.Drawing.Color.White;
            this.txtContactTitre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactTitre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactTitre.ForeColor = System.Drawing.Color.White;
            this.txtContactTitre.Location = new System.Drawing.Point(72, 64);
            this.txtContactTitre.MaxLength = 0;
            this.txtContactTitre.Name = "txtContactTitre";
            this.txtContactTitre.ReadOnly = true;
            this.txtContactTitre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactTitre.Size = new System.Drawing.Size(105, 22);
            this.txtContactTitre.TabIndex = 42;
            // 
            // txtContactPage
            // 
            this.txtContactPage.AcceptsReturn = true;
            this.txtContactPage.BackColor = System.Drawing.Color.White;
            this.txtContactPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactPage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPage.ForeColor = System.Drawing.Color.White;
            this.txtContactPage.Location = new System.Drawing.Point(72, 208);
            this.txtContactPage.MaxLength = 0;
            this.txtContactPage.Name = "txtContactPage";
            this.txtContactPage.ReadOnly = true;
            this.txtContactPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactPage.Size = new System.Drawing.Size(105, 22);
            this.txtContactPage.TabIndex = 57;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.AcceptsReturn = true;
            this.txtContactEmail.BackColor = System.Drawing.Color.White;
            this.txtContactEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactEmail.ForeColor = System.Drawing.Color.White;
            this.txtContactEmail.Location = new System.Drawing.Point(72, 232);
            this.txtContactEmail.MaxLength = 0;
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.ReadOnly = true;
            this.txtContactEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactEmail.Size = new System.Drawing.Size(217, 22);
            this.txtContactEmail.TabIndex = 61;
            // 
            // txtContactPoste
            // 
            this.txtContactPoste.AcceptsReturn = true;
            this.txtContactPoste.BackColor = System.Drawing.Color.White;
            this.txtContactPoste.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactPoste.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPoste.ForeColor = System.Drawing.Color.White;
            this.txtContactPoste.Location = new System.Drawing.Point(72, 136);
            this.txtContactPoste.MaxLength = 0;
            this.txtContactPoste.Name = "txtContactPoste";
            this.txtContactPoste.ReadOnly = true;
            this.txtContactPoste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactPoste.Size = new System.Drawing.Size(49, 22);
            this.txtContactPoste.TabIndex = 51;
            // 
            // txtContactTel
            // 
            this.txtContactTel.AcceptsReturn = true;
            this.txtContactTel.BackColor = System.Drawing.Color.White;
            this.txtContactTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactTel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactTel.ForeColor = System.Drawing.Color.White;
            this.txtContactTel.Location = new System.Drawing.Point(72, 88);
            this.txtContactTel.MaxLength = 0;
            this.txtContactTel.Name = "txtContactTel";
            this.txtContactTel.ReadOnly = true;
            this.txtContactTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactTel.Size = new System.Drawing.Size(105, 22);
            this.txtContactTel.TabIndex = 43;
            // 
            // cmbcontact
            // 
            this.cmbcontact.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbcontact.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbcontact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcontact.ForeColor = System.Drawing.Color.Navy;
            this.cmbcontact.Location = new System.Drawing.Point(73, 24);
            this.cmbcontact.Name = "cmbcontact";
            this.cmbcontact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbcontact.Size = new System.Drawing.Size(217, 22);
            this.cmbcontact.TabIndex = 39;
            this.cmbcontact.SelectedIndexChanged += new System.EventHandler(this.cmbContact_SelectedIndexChanged);
            // 
            // txtContactFax
            // 
            this.txtContactFax.AcceptsReturn = true;
            this.txtContactFax.BackColor = System.Drawing.Color.White;
            this.txtContactFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactFax.ForeColor = System.Drawing.Color.White;
            this.txtContactFax.Location = new System.Drawing.Point(73, 184);
            this.txtContactFax.MaxLength = 0;
            this.txtContactFax.Name = "txtContactFax";
            this.txtContactFax.ReadOnly = true;
            this.txtContactFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactFax.Size = new System.Drawing.Size(105, 22);
            this.txtContactFax.TabIndex = 55;
            this.txtContactFax.TextChanged += new System.EventHandler(this.txtContactFax_TextChanged);
            // 
            // txtContactCell
            // 
            this.txtContactCell.AcceptsReturn = true;
            this.txtContactCell.BackColor = System.Drawing.Color.White;
            this.txtContactCell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactCell.ForeColor = System.Drawing.Color.White;
            this.txtContactCell.Location = new System.Drawing.Point(73, 160);
            this.txtContactCell.MaxLength = 0;
            this.txtContactCell.Name = "txtContactCell";
            this.txtContactCell.ReadOnly = true;
            this.txtContactCell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactCell.Size = new System.Drawing.Size(105, 22);
            this.txtContactCell.TabIndex = 52;
            // 
            // cmdsupcontact
            // 
            this.cmdsupcontact.AutoSize = true;
            this.cmdsupcontact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdsupcontact.BackColor = System.Drawing.Color.Black;
            this.cmdsupcontact.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdsupcontact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsupcontact.ForeColor = System.Drawing.Color.White;
            this.cmdsupcontact.Location = new System.Drawing.Point(99, 264);
            this.cmdsupcontact.Name = "cmdsupcontact";
            this.cmdsupcontact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdsupcontact.Size = new System.Drawing.Size(68, 24);
            this.cmdsupcontact.TabIndex = 64;
            this.cmdsupcontact.Text = "Supprimer";
            this.cmdsupcontact.UseVisualStyleBackColor = true;
            this.cmdsupcontact.Click += new System.EventHandler(this.cmdsupcontact_Click);
            // 
            // txtContactDom
            // 
            this.txtContactDom.AcceptsReturn = true;
            this.txtContactDom.BackColor = System.Drawing.Color.White;
            this.txtContactDom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactDom.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactDom.ForeColor = System.Drawing.Color.White;
            this.txtContactDom.Location = new System.Drawing.Point(73, 110);
            this.txtContactDom.MaxLength = 0;
            this.txtContactDom.Name = "txtContactDom";
            this.txtContactDom.ReadOnly = true;
            this.txtContactDom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContactDom.Size = new System.Drawing.Size(105, 22);
            this.txtContactDom.TabIndex = 47;
            // 
            // CmdAddCont
            // 
            this.CmdAddCont.AutoSize = true;
            this.CmdAddCont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdAddCont.BackColor = System.Drawing.Color.Black;
            this.CmdAddCont.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmdAddCont.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddCont.ForeColor = System.Drawing.Color.White;
            this.CmdAddCont.Location = new System.Drawing.Point(8, 264);
            this.CmdAddCont.Name = "CmdAddCont";
            this.CmdAddCont.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAddCont.Size = new System.Drawing.Size(53, 24);
            this.CmdAddCont.TabIndex = 63;
            this.CmdAddCont.Text = "Ajouter";
            this.CmdAddCont.UseVisualStyleBackColor = true;
            this.CmdAddCont.Click += new System.EventHandler(this.CmdAddCont_Click);
            // 
            // cmdEnregistrerContact
            // 
            this.cmdEnregistrerContact.AutoSize = true;
            this.cmdEnregistrerContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdEnregistrerContact.BackColor = System.Drawing.Color.Black;
            this.cmdEnregistrerContact.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdEnregistrerContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnregistrerContact.ForeColor = System.Drawing.Color.White;
            this.cmdEnregistrerContact.Location = new System.Drawing.Point(8, 264);
            this.cmdEnregistrerContact.Name = "cmdEnregistrerContact";
            this.cmdEnregistrerContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdEnregistrerContact.Size = new System.Drawing.Size(71, 24);
            this.cmdEnregistrerContact.TabIndex = 62;
            this.cmdEnregistrerContact.Text = "Enregistrer";
            this.cmdEnregistrerContact.UseVisualStyleBackColor = true;
            this.cmdEnregistrerContact.Click += new System.EventHandler(this.cmdEnregistrerContact_Click);
            // 
            // cmdAnnulerContact
            // 
            this.cmdAnnulerContact.AutoSize = true;
            this.cmdAnnulerContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAnnulerContact.BackColor = System.Drawing.Color.Black;
            this.cmdAnnulerContact.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdAnnulerContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnulerContact.ForeColor = System.Drawing.Color.White;
            this.cmdAnnulerContact.Location = new System.Drawing.Point(88, 264);
            this.cmdAnnulerContact.Name = "cmdAnnulerContact";
            this.cmdAnnulerContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnulerContact.Size = new System.Drawing.Size(55, 24);
            this.cmdAnnulerContact.TabIndex = 65;
            this.cmdAnnulerContact.Text = "A&nnuler";
            this.cmdAnnulerContact.UseVisualStyleBackColor = true;
            this.cmdAnnulerContact.Click += new System.EventHandler(this.cmdAnnulerContact_Click);
            // 
            // txtContact
            // 
            this.txtContact.AcceptsReturn = true;
            this.txtContact.BackColor = System.Drawing.Color.Black;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.White;
            this.txtContact.Location = new System.Drawing.Point(72, 24);
            this.txtContact.MaxLength = 0;
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContact.Size = new System.Drawing.Size(217, 22);
            this.txtContact.TabIndex = 40;
            this.txtContact.Text = "Text1";
            this.txtContact.Visible = false;
            // 
            // _Label1_8
            // 
            this._Label1_8.AutoSize = true;
            this._Label1_8.BackColor = System.Drawing.Color.Black;
            this._Label1_8.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_8.ForeColor = System.Drawing.Color.White;
            this._Label1_8.Location = new System.Drawing.Point(8, 64);
            this._Label1_8.Name = "_Label1_8";
            this._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_8.Size = new System.Drawing.Size(36, 14);
            this._Label1_8.TabIndex = 41;
            this._Label1_8.Text = "Titre ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(8, 24);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(49, 14);
            this.Label2.TabIndex = 38;
            this.Label2.Text = "Contact";
            // 
            // _Label1_7
            // 
            this._Label1_7.AutoSize = true;
            this._Label1_7.BackColor = System.Drawing.Color.Black;
            this._Label1_7.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_7.ForeColor = System.Drawing.Color.White;
            this._Label1_7.Location = new System.Drawing.Point(8, 136);
            this._Label1_7.Name = "_Label1_7";
            this._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_7.Size = new System.Drawing.Size(39, 14);
            this._Label1_7.TabIndex = 50;
            this._Label1_7.Text = "Poste";
            // 
            // _Label1_5
            // 
            this._Label1_5.AutoSize = true;
            this._Label1_5.BackColor = System.Drawing.Color.Black;
            this._Label1_5.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_5.ForeColor = System.Drawing.Color.White;
            this._Label1_5.Location = new System.Drawing.Point(8, 232);
            this._Label1_5.Name = "_Label1_5";
            this._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_5.Size = new System.Drawing.Size(39, 14);
            this._Label1_5.TabIndex = 60;
            this._Label1_5.Text = "E-Mail";
            // 
            // _Label1_4
            // 
            this._Label1_4.AutoSize = true;
            this._Label1_4.BackColor = System.Drawing.Color.Black;
            this._Label1_4.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_4.ForeColor = System.Drawing.Color.White;
            this._Label1_4.Location = new System.Drawing.Point(8, 208);
            this._Label1_4.Name = "_Label1_4";
            this._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_4.Size = new System.Drawing.Size(49, 14);
            this._Label1_4.TabIndex = 59;
            this._Label1_4.Text = "Pagette";
            // 
            // _Label1_3
            // 
            this._Label1_3.AutoSize = true;
            this._Label1_3.BackColor = System.Drawing.Color.Black;
            this._Label1_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_3.ForeColor = System.Drawing.Color.White;
            this._Label1_3.Location = new System.Drawing.Point(8, 184);
            this._Label1_3.Name = "_Label1_3";
            this._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_3.Size = new System.Drawing.Size(25, 14);
            this._Label1_3.TabIndex = 54;
            this._Label1_3.Text = "Fax";
            // 
            // _Label1_2
            // 
            this._Label1_2.AutoSize = true;
            this._Label1_2.BackColor = System.Drawing.Color.Black;
            this._Label1_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_2.ForeColor = System.Drawing.Color.White;
            this._Label1_2.Location = new System.Drawing.Point(8, 160);
            this._Label1_2.Name = "_Label1_2";
            this._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_2.Size = new System.Drawing.Size(59, 14);
            this._Label1_2.TabIndex = 49;
            this._Label1_2.Text = "Cellulaire";
            // 
            // _Label1_1
            // 
            this._Label1_1.AutoSize = true;
            this._Label1_1.BackColor = System.Drawing.Color.Black;
            this._Label1_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_1.ForeColor = System.Drawing.Color.White;
            this._Label1_1.Location = new System.Drawing.Point(8, 88);
            this._Label1_1.Name = "_Label1_1";
            this._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_1.Size = new System.Drawing.Size(65, 14);
            this._Label1_1.TabIndex = 45;
            this._Label1_1.Text = "Telephone";
            // 
            // _Label1_6
            // 
            this._Label1_6.AutoSize = true;
            this._Label1_6.BackColor = System.Drawing.Color.Black;
            this._Label1_6.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_6.ForeColor = System.Drawing.Color.White;
            this._Label1_6.Location = new System.Drawing.Point(8, 112);
            this._Label1_6.Name = "_Label1_6";
            this._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_6.Size = new System.Drawing.Size(54, 14);
            this._Label1_6.TabIndex = 46;
            this._Label1_6.Text = "Domicile";
            // 
            // cmdRafraichir
            // 
            this.cmdRafraichir.AutoSize = true;
            this.cmdRafraichir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRafraichir.BackColor = System.Drawing.Color.Black;
            this.cmdRafraichir.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdRafraichir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRafraichir.ForeColor = System.Drawing.Color.White;
            this.cmdRafraichir.Location = new System.Drawing.Point(105, 58);
            this.cmdRafraichir.Name = "cmdRafraichir";
            this.cmdRafraichir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRafraichir.Size = new System.Drawing.Size(65, 24);
            this.cmdRafraichir.TabIndex = 3;
            this.cmdRafraichir.Text = "Rafraîchir";
            this.cmdRafraichir.UseVisualStyleBackColor = true;
            this.cmdRafraichir.Click += new System.EventHandler(this.cmdRafraichir_Click);
            // 
            // cmdreport
            // 
            this.cmdreport.AutoSize = true;
            this.cmdreport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdreport.BackColor = System.Drawing.Color.Black;
            this.cmdreport.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdreport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdreport.ForeColor = System.Drawing.Color.White;
            this.cmdreport.Location = new System.Drawing.Point(8, 456);
            this.cmdreport.Name = "cmdreport";
            this.cmdreport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdreport.Size = new System.Drawing.Size(81, 24);
            this.cmdreport.TabIndex = 67;
            this.cmdreport.Text = "&Impression";
            this.cmdreport.UseVisualStyleBackColor = true;
            this.cmdreport.Click += new System.EventHandler(this.cmdreport_Click);
            // 
            // txtSiteWeb
            // 
            this.txtSiteWeb.AcceptsReturn = true;
            this.txtSiteWeb.BackColor = System.Drawing.Color.White;
            this.txtSiteWeb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSiteWeb.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteWeb.ForeColor = System.Drawing.Color.White;
            this.txtSiteWeb.Location = new System.Drawing.Point(94, 373);
            this.txtSiteWeb.MaxLength = 0;
            this.txtSiteWeb.Name = "txtSiteWeb";
            this.txtSiteWeb.ReadOnly = true;
            this.txtSiteWeb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSiteWeb.Size = new System.Drawing.Size(137, 22);
            this.txtSiteWeb.TabIndex = 30;
            this.txtSiteWeb.Text = "  ";
            // 
            // cmdrenommer
            // 
            this.cmdrenommer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdrenommer.BackColor = System.Drawing.Color.Black;
            this.cmdrenommer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdrenommer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdrenommer.ForeColor = System.Drawing.Color.White;
            this.cmdrenommer.Location = new System.Drawing.Point(173, 58);
            this.cmdrenommer.Name = "cmdrenommer";
            this.cmdrenommer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdrenommer.Size = new System.Drawing.Size(75, 26);
            this.cmdrenommer.TabIndex = 4;
            this.cmdrenommer.Text = "Renommer";
            this.cmdrenommer.UseVisualStyleBackColor = true;
            this.cmdrenommer.Click += new System.EventHandler(this.cmdRenommer_Click);
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.AcceptsReturn = true;
            this.txtCommentaire.BackColor = System.Drawing.Color.White;
            this.txtCommentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentaire.ForeColor = System.Drawing.Color.White;
            this.txtCommentaire.Location = new System.Drawing.Point(410, 89);
            this.txtCommentaire.MaxLength = 1000;
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.ReadOnly = true;
            this.txtCommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommentaire.Size = new System.Drawing.Size(177, 43);
            this.txtCommentaire.TabIndex = 9;
            this.txtCommentaire.Text = "Text1";
            // 
            // txtRechercher
            // 
            this.txtRechercher.AcceptsReturn = true;
            this.txtRechercher.BackColor = System.Drawing.Color.White;
            this.txtRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.Color.White;
            this.txtRechercher.Location = new System.Drawing.Point(376, 8);
            this.txtRechercher.MaxLength = 0;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRechercher.Size = new System.Drawing.Size(129, 22);
            this.txtRechercher.TabIndex = 1;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // CmdModif
            // 
            this.CmdModif.AutoSize = true;
            this.CmdModif.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdModif.BackColor = System.Drawing.Color.Black;
            this.CmdModif.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmdModif.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdModif.ForeColor = System.Drawing.Color.White;
            this.CmdModif.Location = new System.Drawing.Point(298, 456);
            this.CmdModif.Name = "CmdModif";
            this.CmdModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdModif.Size = new System.Drawing.Size(59, 24);
            this.CmdModif.TabIndex = 72;
            this.CmdModif.Text = "&Modifier";
            this.CmdModif.UseVisualStyleBackColor = true;
            this.CmdModif.Click += new System.EventHandler(this.CmdModif_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = true;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(96, 206);
            this.txtEmail.MaxLength = 0;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.Size = new System.Drawing.Size(137, 22);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.Text = "  ";
            // 
            // txtTelephone
            // 
            this.txtTelephone.AcceptsReturn = true;
            this.txtTelephone.BackColor = System.Drawing.Color.White;
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephone.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.Color.White;
            this.txtTelephone.Location = new System.Drawing.Point(94, 148);
            this.txtTelephone.MaxLength = 0;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelephone.Size = new System.Drawing.Size(137, 22);
            this.txtTelephone.TabIndex = 12;
            this.txtTelephone.Text = "  ";
            // 
            // txtCP
            // 
            this.txtCP.AcceptsReturn = true;
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.ForeColor = System.Drawing.Color.White;
            this.txtCP.Location = new System.Drawing.Point(94, 344);
            this.txtCP.MaxLength = 0;
            this.txtCP.Name = "txtCP";
            this.txtCP.ReadOnly = true;
            this.txtCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCP.Size = new System.Drawing.Size(137, 22);
            this.txtCP.TabIndex = 29;
            this.txtCP.Text = "  ";
            // 
            // txtPays
            // 
            this.txtPays.AcceptsReturn = true;
            this.txtPays.BackColor = System.Drawing.Color.White;
            this.txtPays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPays.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPays.ForeColor = System.Drawing.Color.White;
            this.txtPays.Location = new System.Drawing.Point(96, 318);
            this.txtPays.MaxLength = 0;
            this.txtPays.Name = "txtPays";
            this.txtPays.ReadOnly = true;
            this.txtPays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPays.Size = new System.Drawing.Size(137, 22);
            this.txtPays.TabIndex = 27;
            this.txtPays.Text = "  ";
            // 
            // txtProvEtat
            // 
            this.txtProvEtat.AcceptsReturn = true;
            this.txtProvEtat.BackColor = System.Drawing.Color.White;
            this.txtProvEtat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProvEtat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvEtat.ForeColor = System.Drawing.Color.White;
            this.txtProvEtat.Location = new System.Drawing.Point(96, 290);
            this.txtProvEtat.MaxLength = 0;
            this.txtProvEtat.Name = "txtProvEtat";
            this.txtProvEtat.ReadOnly = true;
            this.txtProvEtat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProvEtat.Size = new System.Drawing.Size(137, 22);
            this.txtProvEtat.TabIndex = 25;
            this.txtProvEtat.Text = "  ";
            // 
            // txtVille
            // 
            this.txtVille.AcceptsReturn = true;
            this.txtVille.BackColor = System.Drawing.Color.White;
            this.txtVille.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVille.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.ForeColor = System.Drawing.Color.White;
            this.txtVille.Location = new System.Drawing.Point(96, 260);
            this.txtVille.MaxLength = 0;
            this.txtVille.Name = "txtVille";
            this.txtVille.ReadOnly = true;
            this.txtVille.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVille.Size = new System.Drawing.Size(137, 22);
            this.txtVille.TabIndex = 23;
            this.txtVille.Text = "  ";
            // 
            // txtAdresse
            // 
            this.txtAdresse.AcceptsReturn = true;
            this.txtAdresse.BackColor = System.Drawing.Color.White;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresse.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.ForeColor = System.Drawing.Color.White;
            this.txtAdresse.Location = new System.Drawing.Point(96, 234);
            this.txtAdresse.MaxLength = 0;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.ReadOnly = true;
            this.txtAdresse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdresse.Size = new System.Drawing.Size(137, 22);
            this.txtAdresse.TabIndex = 21;
            this.txtAdresse.Text = "  ";
            // 
            // CmdFerme
            // 
            this.CmdFerme.AutoSize = true;
            this.CmdFerme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdFerme.BackColor = System.Drawing.Color.Black;
            this.CmdFerme.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmdFerme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFerme.ForeColor = System.Drawing.Color.White;
            this.CmdFerme.Location = new System.Drawing.Point(562, 456);
            this.CmdFerme.Name = "CmdFerme";
            this.CmdFerme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdFerme.Size = new System.Drawing.Size(53, 24);
            this.CmdFerme.TabIndex = 74;
            this.CmdFerme.Text = "&Fermer";
            this.CmdFerme.UseVisualStyleBackColor = true;
            this.CmdFerme.Click += new System.EventHandler(this.CmdFerme_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.AutoSize = true;
            this.CmdSupp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSupp.BackColor = System.Drawing.Color.Black;
            this.CmdSupp.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmdSupp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSupp.ForeColor = System.Drawing.Color.White;
            this.CmdSupp.Location = new System.Drawing.Point(226, 456);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdSupp.Size = new System.Drawing.Size(68, 24);
            this.CmdSupp.TabIndex = 71;
            this.CmdSupp.Text = "&Supprimer";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.AutoSize = true;
            this.CmdAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdAdd.BackColor = System.Drawing.Color.Black;
            this.CmdAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmdAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdd.ForeColor = System.Drawing.Color.White;
            this.CmdAdd.Location = new System.Drawing.Point(168, 456);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAdd.Size = new System.Drawing.Size(53, 24);
            this.CmdAdd.TabIndex = 68;
            this.CmdAdd.Text = "&Ajouter";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdEnr
            // 
            this.CmdEnr.AutoSize = true;
            this.CmdEnr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdEnr.BackColor = System.Drawing.Color.Black;
            this.CmdEnr.Cursor = System.Windows.Forms.Cursors.Default;
            this.CmdEnr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdEnr.ForeColor = System.Drawing.Color.White;
            this.CmdEnr.Location = new System.Drawing.Point(93, 456);
            this.CmdEnr.Name = "CmdEnr";
            this.CmdEnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdEnr.Size = new System.Drawing.Size(71, 24);
            this.CmdEnr.TabIndex = 69;
            this.CmdEnr.Text = "&Enregistrer";
            this.CmdEnr.UseVisualStyleBackColor = true;
            this.CmdEnr.Click += new System.EventHandler(this.CmdEnr_Click);
            // 
            // cmbFournisseur
            // 
            this.cmbFournisseur.BackColor = System.Drawing.Color.White;
            this.cmbFournisseur.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFournisseur.ForeColor = System.Drawing.Color.White;
            this.cmbFournisseur.Location = new System.Drawing.Point(94, 93);
            this.cmbFournisseur.Name = "cmbFournisseur";
            this.cmbFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbFournisseur.Size = new System.Drawing.Size(275, 22);
            this.cmbFournisseur.Sorted = true;
            this.cmbFournisseur.TabIndex = 6;
            this.cmbFournisseur.SelectedIndexChanged += new System.EventHandler(this.cmbFournisseur_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(8, 120);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(73, 17);
            this.Label3.TabIndex = 78;
            this.Label3.Text = "CatégorieFournisseur";
            // 
            // lblUserModification
            // 
            this.lblUserModification.BackColor = System.Drawing.Color.Black;
            this.lblUserModification.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUserModification.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserModification.ForeColor = System.Drawing.Color.White;
            this.lblUserModification.Location = new System.Drawing.Point(168, 428);
            this.lblUserModification.Name = "lblUserModification";
            this.lblUserModification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserModification.Size = new System.Drawing.Size(89, 17);
            this.lblUserModification.TabIndex = 36;
            this.lblUserModification.Text = "Par :";
            // 
            // lblUserCreation
            // 
            this.lblUserCreation.BackColor = System.Drawing.Color.Black;
            this.lblUserCreation.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUserCreation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCreation.ForeColor = System.Drawing.Color.White;
            this.lblUserCreation.Location = new System.Drawing.Point(168, 400);
            this.lblUserCreation.Name = "lblUserCreation";
            this.lblUserCreation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserCreation.Size = new System.Drawing.Size(89, 17);
            this.lblUserCreation.TabIndex = 33;
            this.lblUserCreation.Text = "Par :";
            // 
            // lblDateModification
            // 
            this.lblDateModification.BackColor = System.Drawing.Color.Black;
            this.lblDateModification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateModification.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDateModification.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateModification.ForeColor = System.Drawing.Color.White;
            this.lblDateModification.Location = new System.Drawing.Point(96, 428);
            this.lblDateModification.Name = "lblDateModification";
            this.lblDateModification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateModification.Size = new System.Drawing.Size(65, 19);
            this.lblDateModification.TabIndex = 35;
            this.lblDateModification.Text = "2004-09-14";
            this.lblDateModification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateCreation
            // 
            this.lblDateCreation.BackColor = System.Drawing.Color.Black;
            this.lblDateCreation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateCreation.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDateCreation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreation.ForeColor = System.Drawing.Color.White;
            this.lblDateCreation.Location = new System.Drawing.Point(96, 400);
            this.lblDateCreation.Name = "lblDateCreation";
            this.lblDateCreation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateCreation.Size = new System.Drawing.Size(65, 19);
            this.lblDateCreation.TabIndex = 32;
            this.lblDateCreation.Text = "2004-09-14";
            this.lblDateCreation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _Label12_3
            // 
            this._Label12_3.BackColor = System.Drawing.Color.Black;
            this._Label12_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label12_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label12_3.ForeColor = System.Drawing.Color.White;
            this._Label12_3.Location = new System.Drawing.Point(8, 432);
            this._Label12_3.Name = "_Label12_3";
            this._Label12_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label12_3.Size = new System.Drawing.Size(81, 17);
            this._Label12_3.TabIndex = 66;
            this._Label12_3.Text = "Modification :";
            // 
            // _Label12_2
            // 
            this._Label12_2.BackColor = System.Drawing.Color.Black;
            this._Label12_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label12_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label12_2.ForeColor = System.Drawing.Color.White;
            this._Label12_2.Location = new System.Drawing.Point(8, 404);
            this._Label12_2.Name = "_Label12_2";
            this._Label12_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label12_2.Size = new System.Drawing.Size(73, 17);
            this._Label12_2.TabIndex = 34;
            this._Label12_2.Text = "Création :";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Black;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(8, 176);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(73, 17);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Fax";
            // 
            // _Label12_1
            // 
            this._Label12_1.BackColor = System.Drawing.Color.Black;
            this._Label12_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label12_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label12_1.ForeColor = System.Drawing.Color.White;
            this._Label12_1.Location = new System.Drawing.Point(8, 376);
            this._Label12_1.Name = "_Label12_1";
            this._Label12_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label12_1.Size = new System.Drawing.Size(73, 17);
            this._Label12_1.TabIndex = 31;
            this._Label12_1.Text = "Site web";
            // 
            // lblRechercher
            // 
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.BackColor = System.Drawing.Color.Black;
            this.lblRechercher.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRechercher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(269, 7);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRechercher.Size = new System.Drawing.Size(98, 19);
            this.lblRechercher.TabIndex = 0;
            this.lblRechercher.Text = "Rechercher";
            // 
            // _Label12_0
            // 
            this._Label12_0.BackColor = System.Drawing.Color.Black;
            this._Label12_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label12_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label12_0.ForeColor = System.Drawing.Color.White;
            this._Label12_0.Location = new System.Drawing.Point(8, 204);
            this._Label12_0.Name = "_Label12_0";
            this._Label12_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label12_0.Size = new System.Drawing.Size(73, 17);
            this._Label12_0.TabIndex = 18;
            this._Label12_0.Text = "E-mail";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Black;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(8, 148);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(73, 17);
            this.Label10.TabIndex = 10;
            this.Label10.Text = "Telephone";
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Black;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(8, 344);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(73, 17);
            this.Label9.TabIndex = 28;
            this.Label9.Text = "CodePostal";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Black;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(8, 316);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(49, 17);
            this.Label8.TabIndex = 26;
            this.Label8.Text = "Pays";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(8, 288);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(73, 17);
            this.Label7.TabIndex = 24;
            this.Label7.Text = "Prov/Etat";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Black;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(8, 260);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(41, 17);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Ville";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(8, 232);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(57, 17);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Adresse";
            // 
            // _Label1_0
            // 
            this._Label1_0.BackColor = System.Drawing.Color.Black;
            this._Label1_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label1_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1_0.ForeColor = System.Drawing.Color.White;
            this._Label1_0.Location = new System.Drawing.Point(8, 96);
            this._Label1_0.Name = "_Label1_0";
            this._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label1_0.Size = new System.Drawing.Size(105, 17);
            this._Label1_0.TabIndex = 8;
            this._Label1_0.Text = "Fournisseur";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fournisseur";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 232);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adresse";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 260);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ville";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 288);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Prov/Etat";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 316);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Pays";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 344);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "CodePostal";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(8, 148);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(73, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "Telephone";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(8, 204);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(73, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "E-mail";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(269, 7);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(98, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Rechercher";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(413, 72);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(90, 14);
            this.label20.TabIndex = 5;
            this.label20.Text = "Commentaires";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(8, 376);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(73, 17);
            this.label21.TabIndex = 31;
            this.label21.Text = "Site web";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(8, 176);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(73, 17);
            this.label22.TabIndex = 13;
            this.label22.Text = "Fax";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Black;
            this.label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(8, 404);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label23.Size = new System.Drawing.Size(73, 17);
            this.label23.TabIndex = 34;
            this.label23.Text = "Création :";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Black;
            this.label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(8, 432);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label24.Size = new System.Drawing.Size(81, 17);
            this.label24.TabIndex = 66;
            this.label24.Text = "Modification :";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Cursor = System.Windows.Forms.Cursors.Default;
            this.label25.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(96, 400);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label25.Size = new System.Drawing.Size(65, 19);
            this.label25.TabIndex = 32;
            this.label25.Text = "  ";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Cursor = System.Windows.Forms.Cursors.Default;
            this.label26.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(96, 428);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label26.Size = new System.Drawing.Size(65, 19);
            this.label26.TabIndex = 35;
            this.label26.Text = "  ";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Black;
            this.label29.Cursor = System.Windows.Forms.Cursors.Default;
            this.label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(8, 120);
            this.label29.Name = "label29";
            this.label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label29.Size = new System.Drawing.Size(73, 17);
            this.label29.TabIndex = 78;
            this.label29.Text = "CatégorieFournisseur";
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Cursor = System.Windows.Forms.Cursors.Default;
            this.button9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(105, 58);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(65, 24);
            this.button9.TabIndex = 3;
            this.button9.Text = "Rafraîchir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.cmdRafraichir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StatusLabel2,
            this.StatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(636, 22);
            this.statusStrip1.TabIndex = 82;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.AutoToolTip = true;
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(510, 17);
            this.StatusLabel1.Spring = true;
            this.StatusLabel1.Text = "Nom";
            this.StatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusLabel1.ToolTipText = "Nom du fournisseur";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(17, 17);
            this.StatusLabel2.Text = "Id";
            this.StatusLabel2.ToolTipText = "Identifiant du fournisseur";
            // 
            // StatusLabel3
            // 
            this.StatusLabel3.AutoToolTip = true;
            this.StatusLabel3.Name = "StatusLabel3";
            this.StatusLabel3.Size = new System.Drawing.Size(94, 17);
            this.StatusLabel3.Text = "Nom du contact";
            this.StatusLabel3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.StatusLabel3.ToolTipText = "Nom du contact";
            // 
            // txtNomFournisseur
            // 
            this.txtNomFournisseur.AcceptsReturn = true;
            this.txtNomFournisseur.BackColor = System.Drawing.Color.White;
            this.txtNomFournisseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomFournisseur.ForeColor = System.Drawing.Color.White;
            this.txtNomFournisseur.Location = new System.Drawing.Point(93, 94);
            this.txtNomFournisseur.MaxLength = 0;
            this.txtNomFournisseur.Name = "txtNomFournisseur";
            this.txtNomFournisseur.ReadOnly = true;
            this.txtNomFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomFournisseur.Size = new System.Drawing.Size(254, 22);
            this.txtNomFournisseur.TabIndex = 7;
            this.txtNomFournisseur.Visible = false;
            this.txtNomFournisseur.TextChanged += new System.EventHandler(this.txtNomFournisseur_TextChanged);
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.AutoSize = true;
            this.cmdRechercher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRechercher.BackColor = System.Drawing.Color.Gainsboro;
            this.cmdRechercher.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRechercher.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmdRechercher.Location = new System.Drawing.Point(511, 5);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercher.Size = new System.Drawing.Size(72, 24);
            this.cmdRechercher.TabIndex = 2;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = true;
            this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
            // 
            // Fournisseurs
            // 
            this.AcceptButton = this.cmdRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(636, 527);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._Categorie);
            this.Controls.Add(this.cmbcatégorie);
            this.Controls.Add(this.cmdMailListFournisseur);
            this.Controls.Add(this.cmdFax);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.fraContact);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txtNomFournisseur);
            this.Controls.Add(this.cmdRechercher);
            this.Controls.Add(this.cmdRafraichir);
            this.Controls.Add(this.cmdreport);
            this.Controls.Add(this.txtSiteWeb);
            this.Controls.Add(this.cmdrenommer);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.CmdModif);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.txtProvEtat);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.CmdFerme);
            this.Controls.Add(this.CmdSupp);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.CmdEnr);
            this.Controls.Add(this.cmbFournisseur);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblUserModification);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblUserCreation);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lblDateModification);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblDateCreation);
            this.Controls.Add(this.label23);
            this.Controls.Add(this._Label12_3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this._Label12_2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this._Label12_1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblRechercher);
            this.Controls.Add(this.label17);
            this.Controls.Add(this._Label12_0);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this._Label1_0);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(184, 130);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fournisseurs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.Fournisseurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRS_FormClosed);
            this.Load += new System.EventHandler(this.FRS_Load);
            this._Categorie.ResumeLayout(false);
            this._Categorie.PerformLayout();
            this.fraEtatOutlook.ResumeLayout(false);
            this.CatMod.ResumeLayout(false);
            this.CatMod.PerformLayout();
            this.fraContact.ResumeLayout(false);
            this.fraContact.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal System.Windows.Forms.ListView listView1;
        internal ColumnHeader columnHeader1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Button button9;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel1;
        private ToolStripStatusLabel StatusLabel2;
        private ToolStripStatusLabel StatusLabel3;
        internal System.Windows.Forms.TextBox txtNomFournisseur;
        internal System.Windows.Forms.Button cmdRechercher;

        private enum EnumMode
        {
            MODE_FRS = 0,
            MODE_CONTACT = 1,
            MODE_INACTIF = 2
        }
        private bool m_bModeAjoutContact;
        private bool m_bModeAjoutFRS;
        private bool m_bRenommer;
        private bool m_bNewContact;
        private bool m_bCategorie;
        private int m_iNoContact;
        private int m_iNoFournisseur;
        private string m_iNoCategorie;
        private string m_Tag; 
        public bool m_bAnnulerDistList;
        public Microsoft.Office.Interop.Outlook.DistListItem m_otlDistList;
        private void AfficherCatFour() 
        {
            try
            {
                int i;
                string sString;
                ADODB.Recordset rstlist;
                rstlist = new Recordset();
                sString = "Select * from Fournisseur ";
                rstlist.Open(sString, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                i = 0;
                if (!rstlist.EOF)
                {
                    while (!rstlist.EOF)
                    {
                        if (rstlist.Fields["NomFournisseur"].Value != cmbFournisseur.Text)
                            break;
                        rstlist.MoveNext();
                    }
                    var loopTo = (int)Lst_Cat.Items.Count;
                    for (i = 1; i <= loopTo; i++)
                    {
                        if (object.ReferenceEquals(rstlist.Fields["Categorie"].Value, DBNull.Value))
                            break;
                        if (Strings.InStr(1, (string)(rstlist.Fields["categorie"].Value), (string)(Lst_Cat.Items[i].Tag), CompareMethod.Text) > 0)
                        {
                            Lst_Cat.Items[i].Checked = true;
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "AfficherCatFour", ex);
            }
        }
        List<ListItem> contacts = new List<ListItem>();
        private void AfficherFournisseur()
        {
            try
            {
                SqlConnection sql = new SqlConnection(StringSQL);
                sql.Open();
                SqlDataReader rd1 = new SqlCommand($"SELECT * FROM FOURNISSEUR WHERE NOMFOURNISSEUR='{cmbFournisseur.Text.Replace("'", "''")}'", sql).ExecuteReader();
                while (rd1.Read())
                {
                    m_iNoFournisseur = int.Parse(rd1["IDFRS"].ToString());
                    txtAdresse.Text = rd1["Adresse"].ToString();
                    txtVille.Text = rd1["Ville"].ToString(); 
                    txtProvEtat.Text = rd1["Prov/Etat"].ToString();  
                    txtPays.Text = rd1["Pays"].ToString();
                    txtCP.Text = rd1["CodePostal"].ToString();
                    txtTelephone.Text = rd1["Telephonne"].ToString();
                    txtFax.Text = rd1["Fax"].ToString();
                    txtEmail.Text = rd1["E-mail"].ToString();
                    txtSiteWeb.Text = rd1["SiteWeb"].ToString();
                    txtCommentaire.Text = rd1["Commentaire"].ToString();
                    lblDateCreation.Text = rd1["DateCréation"].ToString();
                    lblUserCreation.Text = "Par : " + rd1["UserCréation"].ToString();
                    lblDateModification.Text = rd1["DateModification"].ToString();
                    lblUserModification.Text = ("Par : " + rd1["UserModification"].ToString());
                    StatusLabel2.Text = m_iNoFournisseur.ToString();
                    if (!(rd1["Categorie"] is DBNull))
                    {
                        for (int i = 0; i <= (int)cmbcatégorie.Items.Count; i++)
                        {
                            if (cmbcatégorie.Items[i].ToString() != rd1["Categorie"].ToString())
                            {
                                cmbcatégorie.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    
                }
                rd1.Close();
                sql.Close();
                sql = new SqlConnection(StringSQL);
                sql.Open();
                SqlDataReader rd = new SqlCommand($"SELECT * FROM [DBO].[CONTACT] " +
                    $"JOIN [DBO].[CONTACTFRS] ON[DBO].[CONTACT].IDCONTACT =[DBO].[CONTACTFRS].NOCONTACT" +
                    $" WHERE NOFRS = '{m_iNoFournisseur}'", sql).ExecuteReader();
                cmbcontact.Items.Clear();
                while (rd.Read())
                {
                    cmbcontact.Items.Add(new ListItem() { Text = rd[1].ToString(), Value = rd[0].ToString() });
                    StatusLabel3.Text = rd[1].ToString();
                    txtContactTitre.Text = rd["Titre"].ToString();
                    txtContactCell.Text = rd["cellulaire"].ToString();
                    txtContactPage.Text = rd["pagette"].ToString();
                    txtContactTel.Text = rd["telephonne"].ToString();
                    txtContactFax.Text = rd["fax"].ToString();
                    txtContactEmail.Text = rd["e-mail"].ToString();
                    txtContactPoste.Text = rd["noposte"].ToString();
                    txtContactDom.Text = rd["teldomicile"].ToString();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "AfficherFournisseur", ex);
            }
        }
        public void AfficherContact(int clef)
        {
            try
            {
                m_iNoContact = clef;
                ADODB.Recordset rstContact = new ADODB.Recordset();
                rstContact.Open("SELECT * FROM Contact WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (m_bModeAjoutContact == true)
                {
                    if (m_bNewContact == true)
                    {
                        ViderBarrerChampsContact(false, true);
                    }
                    else
                    {
                        ViderBarrerChampsContact(true, true);
                    }
                }
                else { ViderBarrerChampsContact(true, true); }
                if (!rstContact.EOF)
                {
                    if (!(rstContact.Fields["Titre"].Value is DBNull)) { txtContactTitre.Text = (string)(rstContact.Fields["Titre"].Value); ; }
                    if (!(rstContact.Fields["cellulaire"].Value is DBNull)) { txtContactCell.Text = (string)(rstContact.Fields["cellulaire"].Value); ; }
                    if (!(rstContact.Fields["pagette"].Value is DBNull)) { txtContactPage.Text = (string)(rstContact.Fields["pagette"].Value); ; }
                    if (!(rstContact.Fields["telephonne"].Value is DBNull)) { txtContactTel.Text = (string)(rstContact.Fields["telephonne"].Value); ; }
                    if (!(rstContact.Fields["fax"].Value is DBNull)) { txtContactFax.Text = (string)(rstContact.Fields["fax"].Value); ; }
                    if (!(rstContact.Fields["e-mail"].Value is DBNull)) { txtContactEmail.Text = (string)(rstContact.Fields["e-mail"].Value); ; }
                    if (!(rstContact.Fields["noposte"].Value is DBNull)) { txtContactPoste.Text = (string)(rstContact.Fields["noposte"].Value); ; }
                    if (!(rstContact.Fields["teldomicile"].Value is DBNull))
                    {
                        txtContactDom.Text = (string)(rstContact.Fields["teldomicile"].Value);
                    }
                }
                rstContact.Close();
                rstContact = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "AfficherContact", ex);
            }
        }
        private void cmb_modAnu_Click(object eventSender, EventArgs eventArgs) // V1.44 GLL
        {
            try
            {
                m_Tag = "";
                CatMod.Visible = false;
                cmdcatval.Visible = false;
                cmb_modAnu.Visible = false;
                cmdCatAdd.Visible = true;
                cmdcatmod.Visible = true;
                cmdcatenr.Visible = true;
                cmdAnnuller.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmb_modAnu_Click", ex);
            }
        }
        private void cmb_modCat_Click(object eventSender, EventArgs eventArgs) // V1.44 GLL
        {
            try
            {
                if (m_bCategorie == true)
                {
                    _Categorie.Visible = true;
                    _Categorie.Text = "CatégorieFournisseur pour :" + cmbFournisseur.Text;
                    AfficherCatList();
                    AfficherCatFour();
                    if (Lst_Cat.Items.Count >= 34)
                        cmdCatAdd.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmb_modCat_Click", ex);
            }
        }
        [Obsolete]
        private void cmbcatégorie_SelectedIndexChanged(object eventSender, EventArgs eventArgs) // GLL 2017-11-28 V1.44
        {
            try
            {
                if (m_bCategorie == false)
                {
                    if (cmbcatégorie.SelectedIndex != -1)
                    {
                        m_iNoCategorie = GetCategorieID(cmbcatégorie.Text);
                        AfficherCategorie();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmbCatégorie_Click", ex);
            }
        }
        /// <summary>
        /// Modification sugérée par Ghyslain pour le cas ou il y a plusieurs contacts dans la meme compagnie
        /// </summary>
        private void cmbContact_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                StatusLabel3.Text = cmbcontact.Text;
                ADODB.Recordset rd = new ADODB.Recordset();
                rd.Open($"SELECT DISTINCT [TITRE],[CELLULAIRE],[TELDOMICILE],[E-MAIL],[FAX],[PAGETTE],[NOPOSTE],[TELEPHONNE],[IDCONTACT] FROM [DBO].[CONTACT] WHERE [NOMCONTACT] LIKE '{cmbcontact.Text}%'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                if (!rd.EOF)
                {
                    /// Patch pour eviter l'erreur de convertion System.DBNull  en  string
                    /// pwe 2024-08-06
                    if (!(rd.Fields[0].Value is System.DBNull)) txtContactTitre.Text = (string)rd.Fields[0].Value;
                    if (!(rd.Fields[1].Value is System.DBNull)) txtContactCell.Text = (string)rd.Fields[1].Value;
                    if (!(rd.Fields[2].Value is System.DBNull)) txtContactDom.Text = (string)rd.Fields[2].Value;
                    if (!(rd.Fields[3].Value is System.DBNull)) txtContactEmail.Text = (string)rd.Fields[3].Value;
                    if (!(rd.Fields[4].Value is System.DBNull)) txtContactFax.Text = (string)rd.Fields[4].Value;
                    if (!(rd.Fields[5].Value is System.DBNull)) txtContactPage.Text = (string)rd.Fields[5].Value;
                    if (!(rd.Fields[6].Value is System.DBNull)) txtContactPoste.Text = (string)rd.Fields[6].Value;
                    if (!(rd.Fields[7].Value is System.DBNull)) txtContactTel.Text = (string)rd.Fields[7].Value;
                    m_iNoContact = (int)rd.Fields[8].Value;
                }
                rd.Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmbContact_Click", ex);
            }
        }
        private void cmdAnnulerContact_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                AfficherControles(EnumMode.MODE_INACTIF);
                if (m_bNewContact == true)
                {
                    m_bNewContact = false;
                }
                m_bModeAjoutContact = false;
                txtNomFournisseur.Visible = false;
                txtNomFournisseur.ReadOnly = false;
                RemplirComboContact();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmdanulcontact_Click", ex);
            }
        }
        public void RemplirComboContact()
        {
            try
            {
                ADODB.Recordset rstContact = new ADODB.Recordset();
                if (m_bModeAjoutContact == true)
                {
                    rstContact.Open("SELECT NomContact, IDContact FROM Contact WHERE Supprimé = 0 ORDER BY NomContact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstContact.Open("SELECT Contact.NomContact, Contact.IDContact FROM Contact " +
                        "INNER JOIN ContactFRS ON Contact.IDContact = ContactFRS.NoContact " +
                        "WHERE ContactFRS.NoFRS = " + m_iNoFournisseur + " ORDER BY NomContact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                cmbcontact.Items.Clear();
                while (!rstContact.EOF)
                {
                    cmbcontact.Items.Add(rstContact.Fields["NomContact"].Value);
                    cmbcontact.Tag = rstContact.Fields["IDContact"].Value;
                    rstContact.MoveNext();
                }
                rstContact.Close();
                rstContact = null;
                if (cmbcontact.Items.Count > 0)
                {
                    cmbcontact.SelectedIndex = 0;
                }
                else
                {
                    txtContactTitre.Text = string.Empty;
                    txtContactCell.Text = string.Empty;
                    txtContactDom.Text = string.Empty;
                    txtContactEmail.Text = string.Empty;
                    txtContactFax.Text = string.Empty;
                    txtContactPage.Text = string.Empty;
                    txtContactPoste.Text = string.Empty;
                    txtContactTel.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "RemplirComboContact", ex);
            }
        }
        private void EnregistrerFournisseur()
        {
            try
            {
                ADODB.Recordset rstFournisseur;
                rstFournisseur = new Recordset();
                if (m_bModeAjoutFRS == true)
                {
                    rstFournisseur.Open("SELECT * FROM Fournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstFournisseur.AddNew();
                    rstFournisseur.Fields["DateCréation"].Value = ConvertDate(DateTime.Today);
                    rstFournisseur.Fields["UserCréation"].Value = Conteneur.idInitiales.Text;
                }
                else
                {
                    rstFournisseur.Open("SELECT * FROM Fournisseur WHERE IDFRS = " + m_iNoFournisseur, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstFournisseur.Fields["DateModification"].Value = ConvertDate(DateTime.Today);
                    rstFournisseur.Fields["UserModification"].Value = Conteneur.idInitiales.Text;
                }
                rstFournisseur.Fields["NomFournisseur"].Value = txtNomFournisseur.Text;
                rstFournisseur.Fields["Adresse"].Value = txtAdresse.Text;
                rstFournisseur.Fields["Ville"].Value = txtVille.Text;
                rstFournisseur.Fields["Prov/Etat"].Value = txtProvEtat.Text;
                rstFournisseur.Fields["Pays"].Value = txtPays.Text;
                rstFournisseur.Fields["CodePostal"].Value = txtCP.Text;
                rstFournisseur.Fields["Telephonne"].Value = txtTelephone.Text;
                rstFournisseur.Fields["Fax"].Value = txtFax.Text;
                rstFournisseur.Fields["E-mail"].Value = txtEmail.Text;
                rstFournisseur.Fields["siteweb"].Value = txtSiteWeb.Text;
                rstFournisseur.Fields["Commentaire"].Value = txtCommentaire.Text;
                rstFournisseur.Fields["EntryIDOutlook"].Value = ModifierFRSExchange(int.Parse(rstFournisseur.Fields["IDFRS"].Value));
                if (m_bModeAjoutFRS == true)
                {
                    m_bModeAjoutFRS = false;
                }
                rstFournisseur.Update();
                rstFournisseur.Close();
                rstFournisseur = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "EnregistrerFournisseur", ex);
            }
        }
        private void ModifierNomFRSExchange(string sName, int iFournisseurID)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.ContactItem otlFRS;
                Microsoft.Office.Interop.Outlook.MAPIFolder folFRS;
                var bDejaOuvert = default(bool);
                lblEtatOutlook.Text = "Modification du nom du fournisseur dans Outlook ..";
                fraEtatOutlook.Visible = true;
                otlApp = OuvrirOutlook(ref bDejaOuvert);
                folFRS = GetFolder(otlApp, "Fournisseurs GRB");
                otlFRS = (Microsoft.Office.Interop.Outlook.ContactItem)folFRS.Items.Find("[User1] = " + iFournisseurID);
                if (otlFRS is null)
                {
                    MessageBox.Show("Le fournisseur " + txtNomFournisseur.Text + " n'a pas été trouvé pour la mise à jour Exchange!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fraEtatOutlook.Visible = false;
                    Application.DoEvents();
                    return;
                }
                otlFRS.CompanyName = sName;
                otlFRS.Save();
                if (bDejaOuvert == false) { otlApp.Quit(); }
                otlApp = null;
                fraEtatOutlook.Visible = false;
                Application.DoEvents();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("iFournisseurID = " + iFournisseurID, "ModifierNomFRSExchange", ex);
                fraEtatOutlook.Visible = false;
            }
        }
/// Remaniement pour Office 2016 &+ PWE 14-06-2024        
        private void LierContactFournisseur(int iFournisseurID) 
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.ContactItem itmContact;
                Microsoft.Office.Interop.Outlook.ContactItem itmFRS;
                Microsoft.Office.Interop.Outlook.MAPIFolder folFRS;
                Microsoft.Office.Interop.Outlook.MAPIFolder folContact;
                ADODB.Recordset rstContactFRS;
                ADODB.Recordset rstFRS;
                var bDejaOuvert = default(bool);
                int X;
                lblEtatOutlook.Text = "Liaison du contact avec le fournisseur dans Outlook ..";
                fraEtatOutlook.Visible = true;
                otlApp = OuvrirOutlook(ref bDejaOuvert);
                folFRS = GetFolder(otlApp, "Fournisseurs GRB");
                folContact = GetFolder(otlApp, "Contacts GRB");
                rstFRS = new Recordset();
                rstFRS.Open("SELECT EntryIDOutlook FROM Fournisseur WHERE IDFRS = " + m_iNoFournisseur, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                itmFRS = (Microsoft.Office.Interop.Outlook.ContactItem)folFRS.Items.Find("[User1] = " + iFournisseurID);
                if (!(itmFRS is null))
                {
                    while (itmFRS.Links.Count > 0)
                    {
                        itmContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Find((string)(Operators.ConcatenateObject("[User1] = ", ((dynamic)itmFRS.Links[1].Item).User1)));
                        var loopTo = (int)itmContact.Links.Count;
                        for (X = 1; X <= loopTo; X++)
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(((dynamic)itmContact.Links[1].Item).User1, itmFRS.User1, false)))
                            {
                                itmContact.Links.Remove(X);
                                itmContact.Save();
                                break;
                            }
                        }
                        itmFRS.Links.Remove(1);
                    }
                    itmFRS.Save();
                    rstFRS.Close();
                    rstFRS = null;
                    rstContactFRS = new Recordset();
                    rstContactFRS.Open("SELECT * FROM ContactFRS WHERE NoFRS = " + m_iNoFournisseur, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    while (!rstContactFRS.EOF)
                    {
                        itmContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Find((string)(Operators.ConcatenateObject("[User1] = ", rstContactFRS.Fields["NoContact"].Value)));
                        if (!(itmContact is null))
                        {
                            itmFRS.Links.Add(itmContact);
                            itmFRS.Save();
                            itmContact.Links.Add(itmFRS);
                            itmContact.Save();
                        }
                        rstContactFRS.MoveNext();
                    }
                    rstContactFRS.Close();
                    rstContactFRS = null;
                }
                else
                {
                    MessageBox.Show("Fournisseur introuvable!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rstFRS.Close();
                    rstFRS = null;
                }
                if (bDejaOuvert == false) { otlApp.Quit(); }
                otlApp = null;
                fraEtatOutlook.Visible = false;
                Application.DoEvents();
                return;
            }
            catch (Exception ex)
            {
                    AfficherErreur(txtNomFournisseur.Text, "LierContactFournisseur", ex);
                fraEtatOutlook.Visible = false;
            }
        }
        private string ModifierFRSExchange(int iFournisseurID)
        {
            string ModifierFRSExchangeRet = default;
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.ContactItem otlFRS;
                Microsoft.Office.Interop.Outlook.MAPIFolder folFRS;
                var bDejaOuvert = default(bool);
                if (m_bModeAjoutFRS == true)
                {
                    lblEtatOutlook.Text = "Ajout du fournisseur dans Outlook ..";
                }
                else
                {
                    lblEtatOutlook.Text = "Modification du fournisseur dans Outlook ..";
                }
                fraEtatOutlook.Visible = true;
                otlApp = OuvrirOutlook(ref bDejaOuvert);
                folFRS = GetFolder(otlApp, "Fournisseurs GRB");
                if (m_bModeAjoutFRS == true)
                {
                    otlFRS = (Microsoft.Office.Interop.Outlook.ContactItem)folFRS.Items.Add(Microsoft.Office.Interop.Outlook.OlItemType.olContactItem);
                    otlFRS.User1 = iFournisseurID.ToString();
                }
                else
                {
                    otlFRS = (Microsoft.Office.Interop.Outlook.ContactItem)folFRS.Items.Find("[User1] = " + iFournisseurID);
                }
                if (otlFRS is null)
                {
                    MessageBox.Show("Le fournisseur " + txtNomFournisseur.Text + " n'a pas été trouvé pour la mise à jour Exchange!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fraEtatOutlook.Visible = false;
///Il vaut mieux deactiver l'interval pour l'affichage si moins de 8GO ram  et Win11 
                    //application.DoEvents();
                    return ModifierFRSExchangeRet;
                }
                otlFRS.CompanyName = txtNomFournisseur.Text;
                otlFRS.BusinessTelephoneNumber = txtTelephone.Text;
                otlFRS.BusinessFaxNumber = txtFax.Text;
                otlFRS.Email1Address = txtEmail.Text;
                otlFRS.BusinessAddressStreet = txtAdresse.Text;
                otlFRS.BusinessAddressCity = txtVille.Text;
                otlFRS.BusinessAddressState = txtProvEtat.Text;
                otlFRS.BusinessAddressCountry = txtPays.Text;
                otlFRS.BusinessAddressPostalCode = txtCP.Text;
                otlFRS.Body = txtCommentaire.Text;
                otlFRS.WebPage = txtSiteWeb.Text;
                otlFRS.Save();
                ModifierFRSExchangeRet = otlFRS.EntryID;
                if (bDejaOuvert == false) { otlApp.Quit(); }
                otlApp = null;
                fraEtatOutlook.Visible = false;
                Application.DoEvents();
                return ModifierFRSExchangeRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("iFournisseurID = " + iFournisseurID, "ModifierFRSExchange", ex);
                fraEtatOutlook.Visible = false;
                return null;
            }
        }
        private string AjouterContactExchange(int iContactID)
        {
            string AjouterContactExchangeRet = default;
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.ContactItem otlContact;
                Microsoft.Office.Interop.Outlook.MAPIFolder folContact;
                var bDejaOuvert = default(bool);
                lblEtatOutlook.Text = "Ajout du contact dans Outlook ..";
                fraEtatOutlook.Visible = true;
                otlApp = OuvrirOutlook(ref bDejaOuvert);
                folContact = GetFolder(otlApp, "Contacts GRB");
                otlContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Add(Microsoft.Office.Interop.Outlook.OlItemType.olContactItem);
                otlContact.User1 = iContactID.ToString();
                string[] sNom = txtContact.Text.Trim().Split(' ');
                switch (sNom.Length)
                {
                    case 0: { otlContact.FirstName = sNom[0]; break; }
                    case 1:
                        {
                            otlContact.FirstName = sNom[0];
                            otlContact.LastName = sNom[1]; break;
                        }
                    case 2:
                        {
                            otlContact.FirstName = sNom[0];
                            otlContact.MiddleName = sNom[1];
                            otlContact.LastName = sNom[2]; break;
                        }
                }
                otlContact.Title = "";
                otlContact.CompanyName = txtNomFournisseur.Text;
                otlContact.JobTitle = txtContactTitre.Text;
                if (!string.IsNullOrEmpty(txtContactTel.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(txtContactPoste.Text)))
                    {
                        otlContact.BusinessTelephoneNumber = txtContactTel.Text + " Ext : " + txtContactPoste.Text;
                    }
                    else
                    {
                        otlContact.BusinessTelephoneNumber = txtContactTel.Text;
                    }
                }
                otlContact.BusinessFaxNumber = txtContactFax.Text;
                otlContact.MobileTelephoneNumber = txtContactCell.Text;
                otlContact.HomeTelephoneNumber = txtContactDom.Text;
                otlContact.PagerNumber = txtContactPage.Text;
                otlContact.Email1Address = txtContactEmail.Text;
                otlContact.Save();
                AjouterContactExchangeRet = otlContact.EntryID;
                if (bDejaOuvert == false) { otlApp.Quit(); } 
                otlApp = null;
                fraEtatOutlook.Visible = false;
                Application.DoEvents();
                return AjouterContactExchangeRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("iContactID = " + iContactID, "AjouterContactExchange", ex);
                fraEtatOutlook.Visible = false;
                return null;
            }
        }
        private void SupprimerFRSExchange(int iFournisseurID)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.ContactItem otlFRS;
                Microsoft.Office.Interop.Outlook.MAPIFolder folFRS;
                var bDejaOuvert = default(bool);
                lblEtatOutlook.Text = "Suppression du fournisseur dans Outlook ..";
                fraEtatOutlook.Visible = true;
                otlApp = OuvrirOutlook(ref bDejaOuvert);
                folFRS = GetFolder(otlApp, "Fournisseurs GRB");
                otlFRS = (Microsoft.Office.Interop.Outlook.ContactItem)folFRS.Items.Find("[User1] = " + iFournisseurID);
                if (!(otlFRS is null))
                {
                    otlFRS.Delete();
                }
                if (bDejaOuvert == false) { otlApp.Quit(); } 
                otlApp = null;
                fraEtatOutlook.Visible = false;
                Application.DoEvents();
                return;
            }
            catch (Exception ex) { AfficherErreur("Fournisseurs", "SupprimerFRSExchange", ex); fraEtatOutlook.Visible = false; }
        }
        private void cmdAnnuller_Click(object eventSender, EventArgs eventArgs)
        {
            _Categorie.Visible = false;
            RemplirComboCatégorie();
        }
        [Obsolete]
        private void cmdCatAdd_Click(object eventSender, EventArgs eventArgs) // V1.44 GLL
        {
            try
            {
                if (Lst_Cat.Items.Count >= 34)
                {
                    MessageBox.Show("Vous Avez attent le maximum de catégorie");
                    cmdCatAdd.Enabled = false;
                    return;
                }
                m_Tag = "";
                CatMod.Visible = true;
                cmdcatval.Visible = true;
                cmb_modAnu.Visible = true;
                cmdCatAdd.Visible = false;
                cmdcatmod.Visible = false;
                cmdcatenr.Visible = false;
                cmdAnnuller.Visible = false;
                txtmodcat.Focus();
                CatMod.Text = "Ajouter";
                txtmodcat.Text = "";
                return;
            }
            catch (Exception ex) { AfficherErreur("Fournisseurs", "cmdCatAdd_Click", ex); }
        }
        private void cmdcatenr_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstcat;
                int i;
                string sCat;
                rstcat = new Recordset();
                sCat = "";
                rstcat.Open("Select * FROM Fournisseur Where NomFournisseur ='" + cmbFournisseur.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstcat.EOF)
                {
                    MessageBox.Show("Erreur aucun fournisseur sélectionner");
                    return;
                }
                var loopTo = (int)Lst_Cat.Items.Count;
                for (i = 1; i <= loopTo; i++)
                {
                    if (Lst_Cat.Items[i].Checked)
                        sCat = (string)(Operators.ConcatenateObject(sCat, Lst_Cat.Items[i].Tag));
                }
                if (string.IsNullOrEmpty(sCat))
                    rstcat.Fields["Categorie"].Value = DBNull.Value;
                if (!string.IsNullOrEmpty(sCat))
                    rstcat.Fields["Categorie"].Value = sCat;
                rstcat.Update();
                rstcat.Close();
                rstcat = null;
                _Categorie.Visible = false;
                RemplirComboCatégorie();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmdcatenr_click", ex);
            }
        }
        private void cmdcatmod_Click(object eventSender, EventArgs eventArgs) 
        {
            try
            {
                m_Tag = (string)(Lst_Cat.FocusedItem.Tag);
                CatMod.Visible = true;
                cmdcatval.Visible = true;
                cmb_modAnu.Visible = true;
                cmdCatAdd.Visible = false;
                cmdcatmod.Visible = false;
                cmdcatenr.Visible = false;
                cmdAnnuller.Visible = false;
                txtmodcat.Focus();
                CatMod.Text = "Modifier";
                txtmodcat.Text = Lst_Cat.FocusedItem.Text;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmdcatmod_Click", ex);
            }
        }
        private void cmdcatval_Click(object eventSender, EventArgs eventArgs) // V1.44 GLL
        {
            ADODB.Recordset rstag;
            bool bDelete;
            rstag = new Recordset();
            bDelete = false;
            if (!string.IsNullOrEmpty(m_Tag))
            {
                rstag.Open("SELECT * FROM TBL_Categorie where Correspondance ='" + m_Tag + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstag.Fields["Nom"].Value = txtmodcat.Text;
            }
            else
            {
                rstag.Open("SELECT * FROM TBL_Categorie", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstag.EOF)
                {
                    if (rstag.Fields["nom"].Value != txtmodcat.Text)
                    {
                        MessageBox.Show("vous avez déja cette Categorie");
                        goto Fin;
                    }
                    rstag.MoveNext();
                }
                rstag.MoveFirst();
                while (!rstag.EOF)
                {
                    if (rstag.Fields["nom"].Value is DBNull)
                    {
                        rstag.Fields["Nom"].Value = txtmodcat.Text;
                        break;
                    }
                    rstag.MoveNext();
                }
            }
            if (string.IsNullOrEmpty(txtmodcat.Text))
            {
                rstag.Fields["Nom"].Value = DBNull.Value;
                bDelete = true;
            }
            rstag.Update();
        Fin:
            ///a
            rstag.Close();
            rstag = null;
            if (bDelete)
                DeleteCategorie();
            AfficherCatList();
            AfficherCatFour();
            CatMod.Visible = false;
            cmdcatval.Visible = false;
            cmb_modAnu.Visible = false;
            cmdCatAdd.Visible = true;
            cmdcatmod.Visible = true;
            cmdcatenr.Visible = true;
            cmdAnnuller.Visible = true;
            cmdcatmod.Enabled = false;
            m_Tag = "";
        }
        private void cmdEnregistrerContact_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstContactFRS;
                ADODB.Recordset rstContact;
                Cursor.Current = Cursors.WaitCursor;
                rstContactFRS = new Recordset();
                if (m_bNewContact == true)
                {
                    rstContact = new Recordset();
                    rstContact.Open("SELECT * FROM Contact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstContact.AddNew();
                    rstContact.Fields["NomContact"].Value = txtContact.Text;
                    rstContact.Fields["Titre"].Value = txtContactTitre.Text;
                    rstContact.Fields["Compagnie"].Value = txtNomFournisseur.Text;
                    rstContact.Fields["Telephonne"].Value = txtContactTel.Text;
                    rstContact.Fields["Fax"].Value = txtContactFax.Text;
                    rstContact.Fields["Pagette"].Value = txtContactPage.Text;
                    rstContact.Fields["Cellulaire"].Value = txtContactCell.Text;
                    rstContact.Fields["E-mail"].Value = txtContactEmail.Text;
                    rstContact.Fields["noposte"].Value = txtContactPoste.Text;
                    rstContact.Fields["teldomicile"].Value = txtContactDom.Text;
                    rstContact.Fields["UserCréation"].Value = Conteneur.idInitiales.Text;
                    rstContact.Fields["DateCréation"].Value = ConvertDate(DateTime.Today);
                    rstContact.Fields["EntryIDOutlook"].Value = AjouterContactExchange(int.Parse(rstContact.Fields["IDContact"].Value));
                    rstContact.Update();
                    rstContactFRS.Open(Operators.ConcatenateObject("SELECT * FROM ContactFRS WHERE NoFRS = " + m_iNoFournisseur + " And NoContact = ", rstContact.Fields["IDContact"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstContactFRS.EOF)
                    {
                        rstContactFRS.AddNew();
                        rstContactFRS.Fields["NoFRS"].Value = m_iNoFournisseur;
                        rstContactFRS.Fields["NoContact"].Value = rstContact.Fields["IDContact"].Value;
                        rstContactFRS.Update();
                    }
                    rstContact.Close();
                    rstContact = null;
                    m_bNewContact = false;
                }
                else
                {
                    rstContactFRS.Open("SELECT * FROM ContactFRS WHERE NoFRS = " + m_iNoFournisseur + " And NoContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstContactFRS.EOF)
                    {
                        rstContactFRS.AddNew();
                        rstContactFRS.Fields["NoFRS"].Value = m_iNoFournisseur;
                        rstContactFRS.Fields["NoContact"].Value = m_iNoContact;
                        rstContactFRS.Update();
                    }
                    rstContactFRS.Close();
                }
                LierContactFournisseur(m_iNoFournisseur);
                rstContactFRS = null;
                AfficherControles(EnumMode.MODE_INACTIF);
                m_bModeAjoutContact = false;
                RemplirComboContact();
                ViderBarrerChampsContact(true, false);
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmdEnregistrerContact_Click", ex);
            }
        }
        [Obsolete]
        private void cmdFax_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbFournisseur.Items.Count > 0)
                {
                    int argiNoContact = GetContactID(cmbcontact.Items[cmbcontact.SelectedIndex].ToString());
                    Form form = new Rapports();
                    form.MdiParent = this;
                    if (cmbcontact.SelectedIndex > -1)
                    {
                        form.Text = argiNoContact.ToString();
                    }
                    else
                    {
                        int argiNoContact1 = 0;
                        form.Text = argiNoContact1.ToString();
                    }
                    form.ShowDialog();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmdFax_Click", ex);
            }
        }
        [Obsolete]
        private void cmdMailListContact_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.MAPIFolder folContact;
                var itmContact = default(Microsoft.Office.Interop.Outlook.ContactItem[]);
                Microsoft.Office.Interop.Outlook.Recipient otlRecipient;
                var bDejaOuvert = default(bool);
                ADODB.Recordset rstContact;
                var sIDContact = default(string[]);
                var sContact = default(string[]);
                int X;
                bool bArrayVide;
                int iResult;
                bool bPlein;
                bool sMsgPlein;
                int iNbreRendu;
                if (cmbcontact.SelectedIndex != -1)
                {
                    bArrayVide = true;
                    iResult = (int)MessageBox.Show("Voulez-vous ajouter tous les contacts à la liste de distribution?\n\nOui - Tous les contacts\n\nNon - Contact affiché seulement", Application.ProductName, MessageBoxButtons.YesNo);
                    if (iResult == 0x06)
                    {
                        rstContact = new Recordset();
                        rstContact.Open("SELECT * FROM CONTACTFRS " +
                            "INNER JOIN CONTACT ON CONTACTFRS.NOCONTACT = CONTACT.IDCONTACT " +
                            "WHERE CONTACTFRS.NOFRS = " + GetFournisseurID(cmbFournisseur.Items[cmbFournisseur.SelectedIndex].ToString()) + 
                            " ORDER BY NomContact", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockOptimistic);
                        X = 0;
                        while (!rstContact.EOF)
                        {
                            if (!(rstContact.Fields["E-mail"].Value is DBNull))
                            {
                                if (!string.IsNullOrEmpty(Strings.Trim((string)(rstContact.Fields["E-mail"].Value))))
                                {
                                    bArrayVide = false;
                                    Array.Resize(ref sIDContact, X + 1);
                                    Array.Resize(ref itmContact, X + 1);
                                    Array.Resize(ref sContact, X + 1);
                                    sIDContact[X] = (string)(rstContact.Fields["IDContact"].Value);
                                    sContact[X] = (string)(rstContact.Fields["NomContact"].Value);
                                    X = (int)(X + 1);
                                }
                            }
                            rstContact.MoveNext();
                        }
                    }
                    else if (iResult == (int)DialogResult.No)
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim(txtContactEmail.Text)))
                        {
                            bArrayVide = false;
                            Array.Resize(ref sIDContact, 1);
                            Array.Resize(ref itmContact, 1);
                            Array.Resize(ref sContact, 1);
                            sIDContact[0] = cmbcontact.Items[cmbcontact.SelectedIndex].ToString();
                            sContact[0] = cmbcontact.Text;
                        }
                    }
                    else
                    {
                        return;
                    }
                    if (bArrayVide == false)
                    {
                        otlApp = OuvrirOutlook(ref bDejaOuvert);
                        lblEtatOutlook.Text = "Recherche des listes de distribution..";
                        fraEtatOutlook.Visible = true;
                        Form f = new ChoixMailList();
                        f.Show();
                        if (m_bAnnulerDistList == false)
                        {
                            lblEtatOutlook.Text = "Ajout du contact dans la liste de distribution..";
                            fraEtatOutlook.Visible = true;
                            folContact = GetFolder(otlApp, "Contacts GRB");
                            var loopTo = (int)Information.UBound(sIDContact);
                            for (X = 0; X <= loopTo; X++)
                                itmContact[X] = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Find("[User1] = " + sIDContact[X]);
                            bPlein = false;
                            var loopTo1 = (int)Information.UBound(itmContact);
                            for (X = 0; X <= loopTo1; X++)
                            {
                                if (!(itmContact[X] is null))
                                {
                                    if (m_otlDistList.MemberCount < 10)
                                    {
                                        otlRecipient = otlApp.Session.CreateRecipient(itmContact[X].Email1DisplayName);
                                        if (otlRecipient.Resolve() == true)
                                        {
                                            m_otlDistList.AddMember(otlRecipient);
                                            m_otlDistList.Save();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Impossible d'ajouter le contact '" + sContact[X] + "' !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        bPlein = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Contact '" + sContact[X] + "' introuvable!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            if (bPlein == true)
                            {
                                sMsgPlein = Conversions.ToBoolean("Les contacts suivants n'ont pas pu être ajouté car la liste contient déjà 10 contacts!" + "\n" + "\n");
                                iNbreRendu = X;
                                for (X = iNbreRendu; X <= (int)Information.UBound(sContact); X++)
                                {
                                    sMsgPlein = Conversions.ToBoolean(sMsgPlein + sContact[X]);
                                    if (X < Information.UBound(sContact))
                                    {
                                        sMsgPlein = Conversions.ToBoolean(sMsgPlein + "\n");
                                    }
                                }
                                MessageBox.Show($"Boites a lettre pleine{bPlein}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (bDejaOuvert == false)
                        {
                            otlApp.Quit();
                        }
                        otlApp = null;
                        fraEtatOutlook.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Le ou les contacts n'ont pas d'email!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aucun contact sélectionné!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            /// code d'érreur etrange pour du exchange a voir
            /// comme je me doutais les code 287 c du outlook local
            catch (Exception ex)
            {
                ///Patch Erreur  LocalOutlook   287 n'est pas pareil sous exchange
                ///PWE 2024-07-31
                AfficherErreur("Fournisseurs", "cmdMailListContact_Click", ex);
                fraEtatOutlook.Visible = false;
            }
        }
        [Obsolete]
        private void cmdMailListFournisseur_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.MAPIFolder folFRS;
                Microsoft.Office.Interop.Outlook.ContactItem itmFRS;
                Microsoft.Office.Interop.Outlook.Recipient otlRecipient;
                var bDejaOuvert = default(bool);
                if (cmbFournisseur.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(txtEmail.Text)))
                    {
                        otlApp = OuvrirOutlook(ref bDejaOuvert);
                        lblEtatOutlook.Text = "Recherche des listes de distribution..";
                        fraEtatOutlook.Visible = true;
                        if (m_bAnnulerDistList == false)
                        {
                            lblEtatOutlook.Text = "Ajout du fournisseur dans la liste de distribution..";
                            fraEtatOutlook.Visible = true;
                            if (m_otlDistList.MemberCount < 10)
                            {
                                folFRS = GetFolder(otlApp, "Fournisseurs GRB");
                                itmFRS = (Microsoft.Office.Interop.Outlook.ContactItem)folFRS.Items.Find("[User1] = " + (cmbFournisseur.Items[cmbFournisseur.SelectedIndex].ToString()));
                                if (!(itmFRS is null))
                                {
                                    otlRecipient = otlApp.Session.CreateRecipient(itmFRS.Email1DisplayName);
                                    if (otlRecipient.Resolve() == true)
                                    {
                                        m_otlDistList.AddMember(otlRecipient);
                                        m_otlDistList.Save();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Impossible de trouver le fournisseur!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fournisseur introuvable!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cette liste de distribution contient déjà 10 contacts!\n\nVeuillez en choisir une autre.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (bDejaOuvert == false)
                        {
                            otlApp.Quit();
                        }
                        otlApp = null;
                        fraEtatOutlook.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Ce fournisseur n'a pas d'email!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aucun fournisseur sélectionné!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                if (Information.Err().Number == 287 & Information.Erl() == 115)
                {
                    MessageBox.Show("La liste de distribution est pleine!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AfficherErreur("Fournisseurs", "cmdMailListFournisseur_Click", ex);
                }
                fraEtatOutlook.Visible = false;
            }
        }
        private void cmdRafraichir_Click(object eventSender, EventArgs eventArgs)
        {
            Cursor.Current = Cursors.WaitCursor;
            EnumFournisseur();
            for (int x = 0; x < fournisseurs.Count; x++)
            {
                cmbFournisseur.Items.Add(fournisseurs[x]);
            }
            Cursor.Current = Cursors.Default;
            return;
        }
        private void ViderBarrerChamps(bool bLocked, bool bVider)
        {
            try
            {
                if (bVider == true)
                {
                    txtAdresse.Text = string.Empty;
                    txtVille.Text = string.Empty;
                    txtProvEtat.Text = string.Empty;
                    txtPays.Text = string.Empty;
                    txtCP.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtSiteWeb.Text = string.Empty;
                    txtCommentaire.Text = string.Empty;
                    txtTelephone.Text = string.Empty;
                    txtFax.Text = string.Empty;
                    lblDateCreation.Text = string.Empty;
                    lblUserCreation.Text = string.Empty;
                    lblDateModification.Text = string.Empty;
                    lblUserModification.Text = string.Empty;
                }
                txtAdresse.ReadOnly = bLocked;
                txtVille.ReadOnly = bLocked;
                txtProvEtat.ReadOnly = bLocked;
                txtPays.ReadOnly = bLocked;
                txtCP.ReadOnly = bLocked;
                txtEmail.ReadOnly = bLocked;
                txtSiteWeb.ReadOnly = bLocked;
                txtTelephone.ReadOnly = bLocked;
                txtFax.ReadOnly = bLocked;
                txtCommentaire.ReadOnly = bLocked;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "ViderBarrerChamps", ex);
            }
        }
        private void ViderBarrerChampsContact(bool bLocked, bool bVider)
        {
            try
            {
                if (bVider == true)
                {
                    txtContactTitre.Text = string.Empty;
                    txtContactCell.Text = string.Empty;
                    txtContactDom.Text = string.Empty;
                    txtContactEmail.Text = string.Empty;
                    txtContactFax.Text = string.Empty;
                    txtContactPage.Text = string.Empty;
                    txtContactPoste.Text = string.Empty;
                    txtContactTel.Text = string.Empty;
                }
                txtContactTitre.ReadOnly = bLocked;
                txtContactCell.ReadOnly = bLocked;
                txtContactDom.ReadOnly = bLocked;
                txtContactEmail.ReadOnly = bLocked;
                txtContactFax.ReadOnly = bLocked;
                txtContactPage.ReadOnly = bLocked;
                txtContactPoste.ReadOnly = bLocked;
                txtContactTel.ReadOnly = bLocked;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "ViderBarrerChampsContact", ex);
            }
        }
        private void CmdAddCont_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sNom;
                bool bAjouter;
                if (cmbFournisseur.Items.Count > 0)
                {
                    m_bModeAjoutContact = true;
                    if (MessageBox.Show("Voulez-vous ajouter un nouveau contact?\n\nOui - Nouveau contact\n\nNon - Sélection dans la liste existant", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        m_bNewContact = true;
                        sNom = Interaction.InputBox("Quel est le nom du nouveau contact?\n\nSVP, respectez le bon orthographe!");
                        if (!string.IsNullOrEmpty(sNom))
                        {
                            if (ExisteDansBD(sNom) == true)
                            {
                                if (MessageBox.Show("Il y a déjà un contact portant ce nom!\n\nVoulez-vous l'ajouter quand même?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    bAjouter = true;
                                }
                                else
                                {
                                    bAjouter = false;
                                }
                            }
                            else if (ContientCaracteresIncorrects(sNom) == true)
                            {
                                MessageBox.Show("Il y a des caractères non permis!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bAjouter = false;
                            }
                            else
                            {
                                bAjouter = true;
                            }
                        }
                        else
                        {
                            bAjouter = false;
                        }
                        if (bAjouter == true)
                        {
                            txtContact.Text = sNom;
                            ViderBarrerChampsContact(false, true);
                            txtContactTel.Focus();
                            txtNomFournisseur.Visible = true;
                            txtNomFournisseur.ReadOnly = true;
                            AfficherControles(EnumMode.MODE_CONTACT);
                            txtContactTitre.Focus();
                        }
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        m_bNewContact = false;
                        txtNomFournisseur.Visible = true;
                        txtNomFournisseur.ReadOnly = true;
                        AfficherControles(EnumMode.MODE_CONTACT);
                        RemplirComboContact(); ;
                    }
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement de sélectionné");
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "CmdAddCont_Click", ex);
            }
        }
        private void cmdreport_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstFournisseur;
                rstFournisseur = new Recordset();
                if (MessageBox.Show("Voulez-vous imprimer ce fournisseur uniquement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstFournisseur.Open("SELECT * FROM Fournisseur WHERE IDFRS = " + m_iNoFournisseur, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else if (MessageBox.Show("Voulez-vous filtrer par la ville '" + txtVille.Text + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstFournisseur.Open("SELECT * FROM Fournisseur WHERE ville = '" + Strings.Replace(txtVille.Text, "'", "''") + "' AND Supprimé = 0 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstFournisseur.Open("SELECT * FROM Fournisseur WHERE Supprimé = 0 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                Cursor.Current = Cursors.WaitCursor;
                ControleurServeur.ViewListeFournisseur.DataSource = rstFournisseur;
                ControleurServeur.ViewListeFournisseur rp = new ControleurServeur.ViewListeFournisseur();
                rp.Text = "Rapport Client";
                rp.Icon = Icon;
                rp.MdiParent = Conteneur.ActiveForm.MdiParent;
                rp.Show();
                rstFournisseur.Close();
                rstFournisseur = null;
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmdreport_Click", ex);
            }
        }
        private void AfficherControles(EnumMode eMode)
        {
            try
            {
                var bCmbFournisseur = default(bool);
                var bTxtFournisseur = default(bool);
                var bCmbContact = default(bool);
                var bTxtContact = default(bool);
                var bTxtRechercher = default(bool);
                var bCmdAdd = default(bool);
                var bCmdEnr = default(bool);
                var bCmdModif = default(bool);
                var bCmdSupp = default(bool);
                var bFraContact = default(bool);
                var bCmdAnul = default(bool);
                var bCmdQuit = default(bool);
                var bCmdAddCont = default(bool);
                var bCmdSupContact = default(bool);
                var bCmdAnulContact = default(bool);
                var bCmdRenommer = default(bool);
                var bCmdRafraichir = default(bool);
                var bCmdImprimer = default(bool);
                var bCmdRefCont = default(bool);
                var bFax = default(bool);
                var bMailListFRS = default(bool);
                var bMailListContact = default(bool);
                switch (eMode)
                {
                    case EnumMode.MODE_FRS:
                        {
                            bTxtFournisseur = true;
                            bCmdEnr = true;
                            bCmdAnul = true;
                            m_bCategorie = true; break;
                        }
                    case EnumMode.MODE_CONTACT:
                        {
                            bFraContact = true;
                            bTxtFournisseur = true;
                            bCmdAnulContact = true;
                            bCmdRefCont = true;
                            if (m_bNewContact == true)
                            {
                                bTxtContact = true;
                            }
                            else
                            {
                                bCmbContact = true;
                            }
                            break;
                        }
                    case EnumMode.MODE_INACTIF:
                        {
                            bFraContact = true;
                            bCmbFournisseur = true;
                            bCmdImprimer = true;
                            bTxtRechercher = true;
                            bCmdRenommer = true;
                            bCmdRafraichir = true;
                            bCmdAdd = true;
                            bCmdSupp = true;
                            bCmdModif = true;
                            bCmdQuit = true;
                            bCmdAddCont = true;
                            bCmdSupContact = true;
                            bFax = true;
                            bCmbContact = true;
                            bMailListContact = true;
                            bMailListFRS = true;
                            m_bCategorie = false; break;
                        }
                }
                cmbFournisseur.Visible = bCmbFournisseur;
                txtNomFournisseur.Visible = bTxtFournisseur;
                fraContact.Visible = bFraContact;
                txtRechercher.Enabled = bTxtRechercher;
                cmdRafraichir.Enabled = bCmdRafraichir;
                cmdrenommer.Enabled = bCmdRenommer;
                cmdreport.Visible = bCmdImprimer;
                CmdAdd.Visible = bCmdAdd;
                CmdSupp.Visible = bCmdSupp;
                CmdModif.Visible = bCmdModif;
                CmdFerme.Visible = bCmdQuit;
                CmdEnr.Visible = bCmdEnr;
                CmdAddCont.Visible = bCmdAddCont;
                cmdsupcontact.Visible = bCmdSupContact;
                cmdAnnulerContact.Visible = bCmdAnulContact;
                cmdEnregistrerContact.Visible = bCmdRefCont;
                cmdFax.Visible = bFax;
                cmbcontact.Visible = bCmbContact;
                txtContact.Visible = bTxtContact;
                cmdMailListFournisseur.Visible = bMailListFRS;
                cmdMailListContact.Visible = bMailListContact;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "AfficherControles", ex);
            }
        }
        private void CmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sName;
                AfficherControles(EnumMode.MODE_FRS);
                sName = Interaction.InputBox("Veuillez entrer le nom du fournisseur\n\nSVP, respectez le bon orthographe!", "SAISIE DU NOM", "Nom du fournisseur");
                if (!string.IsNullOrEmpty(sName))
                {
                    if (!ComboContient(cmbFournisseur, sName))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        m_bModeAjoutFRS = true;
                        txtNomFournisseur.Text = sName;
                        ViderBarrerChamps(false, true);
                        txtTelephone.Focus();
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Ce fournisseur existe déjà!");
                        AfficherControles(EnumMode.MODE_INACTIF);
                    }
                }
                else
                {
                    AfficherControles(EnumMode.MODE_INACTIF);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "CmdAdd_Click", ex);
            }
        }
        [Obsolete]
        private void CmdAnul_Click(object eventSender, EventArgs eventArgs)
            //Correction segment PWE 01-04-2023
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                AfficherControles(EnumMode.MODE_INACTIF);
                m_bModeAjoutFRS = false;
                ViderBarrerChamps(true, true);
                cmbFournisseur_SelectedIndexChanged(cmbFournisseur, new EventArgs());
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "CmdAnul_Click", ex);
            }
        }
        [Obsolete]
        private void CmdEnr_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sFournisseur;
                int X;
                sFournisseur = txtNomFournisseur.Text;
                Cursor.Current = Cursors.WaitCursor;
                EnregistrerFournisseur();
                cmdRafraichir_Click(eventSender, eventArgs);
                AfficherControles(EnumMode.MODE_INACTIF);
                for (X = 0; X <= (int)(cmbFournisseur.Items.Count - 1); X++)
                {
                    if ((cmbFournisseur.Items[X].ToString() ?? "") == (sFournisseur ?? ""))
                    {
                        cmbFournisseur.SelectedIndex = X;
                        break;
                    }
                }
                cmbFournisseur.Focus();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "CmdEnr_Click", ex);
            }
        }
        private void CmdFerme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "CmdFerme_Click", ex);
            }
        }
        private void CmdModif_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbFournisseur.Items.Count > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    AfficherControles(EnumMode.MODE_FRS);
                    ViderBarrerChamps(false, false);
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement sélectionné!");
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "CmdModif_Click", ex);
            }
        }
        [Obsolete]
        private void cmdRenommer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstFournisseur;
                string sName;
                if (cmbFournisseur.Items.Count > 0)
                {
                    sName = Interaction.InputBox("Veuillez entrer le nom du Fournisseur", "Renommer fournisseur", txtNomFournisseur.Text);
                    if (!string.IsNullOrEmpty(sName))
                    {
                        if ((sName ?? "") != (txtNomFournisseur.Text ?? ""))
                        {
                            if (!ComboContient(cmbFournisseur, sName))
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                rstFournisseur = new Recordset();
                                rstFournisseur.Open("SELECT IDFrs, NomFournisseur, EntryIDOutlook FROM Fournisseur WHERE IDFRS = " + m_iNoFournisseur, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                ModifierNomFRSExchange(sName, m_iNoFournisseur);
                                txtNomFournisseur.Text = sName;
                                rstFournisseur.Fields["NomFournisseur"].Value = txtNomFournisseur.Text;
                                rstFournisseur.Update();
                                rstFournisseur.Close();
                                rstFournisseur = null;
                                cmdRafraichir_Click(eventSender, eventArgs);
                                cmbFournisseur.Text = sName;
                                m_bRenommer = true;
                                cmbFournisseur_SelectedIndexChanged(cmbFournisseur, new EventArgs());
                                m_bRenommer = false;
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Le fournisseur " + sName + " existe déjà!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement de sélectionné!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmdRenommer_Click", ex);
            }
        }
        private void cmdsupcontact_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbcontact.Items.Count > 0)
                {
                    if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        UpdateSQL("DELETE FROM ContactFRS WHERE NoFRS = " + m_iNoFournisseur + " AND NoContact = " + m_iNoContact);
                        LierContactFournisseur(m_iNoFournisseur);
                        RemplirComboContact();
                        Cursor.Current = Cursors.Default;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "cmdsupcontact_Click", ex);
            }
        }
        private void CmdSupp_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstCatalogue;
                ADODB.Recordset rstFRS;
                bool bPeutEffacer;
                if (cmbFournisseur.Items.Count > 0)
                {
                    if (MessageBox.Show("Etes-vous sur de supprimer cette enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        rstProjSoum = new Recordset();
                        rstCatalogue = new Recordset();
                        rstProjSoum.Open("SELECT * FROM Soumission_Pieces WHERE IDFRS = " + m_iNoFournisseur, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstCatalogue.Open("SELECT * FROM PiecesFRS WHERE IDFRS = " + m_iNoFournisseur, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstProjSoum.EOF)
                        {
                            rstProjSoum.Close();
                            rstProjSoum.Open("SELECT * FROM Projet_Pieces WHERE IDFRS = " + m_iNoFournisseur, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (rstProjSoum.EOF)
                            {
                                if (rstCatalogue.EOF)
                                {
                                    bPeutEffacer = true;
                                }
                                else
                                {
                                    bPeutEffacer = false;
                                }
                            }
                            else
                            {
                                bPeutEffacer = false;
                            }
                        }
                        else
                        {
                            bPeutEffacer = false;
                        }
                        rstCatalogue.Close();
                        rstCatalogue = null;
                        rstProjSoum.Close();
                        rstProjSoum = null;
                        if (cmbcontact.Items.Count > 0)
                        {
                            UpdateSQL("DELETE FROM ContactFRS WHERE NoFRS = " + m_iNoFournisseur);
                        }
                        SupprimerFRSExchange(m_iNoFournisseur);
                        if (bPeutEffacer == true)
                        {
                            UpdateSQL("DELETE FROM Fournisseur WHERE IDFRS = " + m_iNoFournisseur);
                        }
                        else
                        {
                            rstFRS = new Recordset();
                            rstFRS.Open("SELECT * FROM Fournisseur WHERE IDFRS = " + m_iNoFournisseur, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            rstFRS.Fields["Supprimé"].Value = true;
                            rstFRS.Update();
                            rstFRS.Close();
                            rstFRS = null;
                        }
                        cmdRafraichir_Click(eventSender, eventArgs);
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement sélectionné!");
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "CmdSupp_Click", ex);
            }
        }
        ///reconstruit entierement pour éliminier les boucles
        ///PWE 2024-07-16
        private void cmbFournisseur_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            StatusLabel1.Text = cmbFournisseur.Text;
                       m_iNoFournisseur = int.Parse(fournisseurs[cmbFournisseur.SelectedIndex].Value);
            StatusLabel2.Text = m_iNoFournisseur.ToString();
            AfficherFournisseur();
            //    RemplirComboContact();
        }
        /// GLL 2017-11-28 V1.44 update PWE 2024-01-03
        private void FRS_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                cmdRafraichir_Click(eventSender, eventArgs);
                RemplirComboCatégorie();
                AfficherControles(EnumMode.MODE_INACTIF);
                ActiverBoutonsGroupe();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "Form_Load", ex);
            }
        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
                CmdAdd.Enabled = g_bModificationFournisseurs;
                CmdModif.Enabled = g_bModificationFournisseurs;
                cmdrenommer.Enabled = g_bModificationFournisseurs;
                CmdSupp.Enabled = g_bModificationFournisseurs;
                CmdAddCont.Enabled = g_bModificationFournisseurs;
                cmdsupcontact.Enabled = g_bModificationFournisseurs;
                cmdMailListContact.Enabled = g_bModificationListeDistribution;
                cmdMailListFournisseur.Enabled = g_bModificationListeDistribution;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "ActiverBoutonsGroupe", ex);
            }
        }
        private void FRS_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "Form_Unload", ex);
            }
        }
        private void Lst_Cat_ItemClick(ListViewItem Item) => cmdcatmod.Enabled = true;
        private void cmdRechercher_Click(object eventSender, EventArgs eventArgs)
        {
            cmbFournisseur.Items.Clear();
            Conteneur.txtStatus.Text = $"Recherche dans les {fournisseurs.Count} fournisseurs inscrits";
            ADODB.Recordset rdRecherche = new ADODB.Recordset();
            rdRecherche.Open($"SELECT DISTINCT  [NomFournisseur],[IDFRS] FROM [DBO].[FOURNISSEUR] WHERE [NOMFOURNISSEUR] LIKE '%{txtRechercher.Text}%'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
            while (!rdRecherche.EOF)
            {
                cmbFournisseur.Items.Add(rdRecherche.Fields[0].Value);
            }
            rdRecherche.Close();
            rdRecherche = null;
            if (cmbFournisseur.Items.Count < 2 && cmbFournisseur.Items.Count > -1)
            {
                Conteneur.txtStatus.Text = $" {cmbFournisseur.Items.Count} coresspondance dans les {fournisseurs.Count} fournisseurs inscrits";
            }
            else
            {
                Conteneur.txtStatus.Text = $" {cmbFournisseur.Items.Count} coresspondances dans les {fournisseurs.Count} fournisseurs inscrits";
            }
        }
        private void txtRechercher_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (txtRechercher.Text.Length > 0)
            {
                cmbFournisseur.Items.Clear();
            }
            else
            {
                cmdRechercher.Enabled = false;
            }
        }
        private bool ExisteDansBD(string sName)
        {
            bool ExisteDansBDRet = default;
            try
            {
                ADODB.Recordset rstContact;
                rstContact = new Recordset();
                rstContact.Open("SELECT NomContact FROM Contact WHERE NomContact = '" + Strings.Replace(sName, "'", "''") + "' AND Supprimé = 0", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                if (rstContact.EOF)
                {
                    ExisteDansBDRet = false;
                }
                else
                {
                    ExisteDansBDRet = true;
                }
                rstContact.Close();
                rstContact = null;
                return ExisteDansBDRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "ExisteDansBD", ex);
                return false;
            }
        }
        private bool ContientCaracteresIncorrects(string sName)
        {
            bool ContientCaracteresIncorrectsRet = default;
            try
            {
                if (Strings.InStr(1, sName, ",") > 0 | Strings.InStr(1, sName, ";") > 0 | Strings.InStr(1, sName, ":") > 0 | Strings.InStr(1, sName, "(") > 0 | Strings.InStr(1, sName, ")") > 0)
                {
                    ContientCaracteresIncorrectsRet = true;
                }
                else
                {
                    ContientCaracteresIncorrectsRet = false;
                }
                return ContientCaracteresIncorrectsRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "ContientCaracteresIncorrects", ex);
                return false;
            }
        }
        private void AfficherCategorie() // GLL 2017-11-28 V1.44  //PWE 2024-06-01 v:2.24
        {
            try
            {
                ADODB.Recordset rstCategorie;
                ADODB.Recordset rstFournisseur;
                string sString;
                rstCategorie = new Recordset();
                rstFournisseur = new Recordset();
                sString = "Select * From Tbl_Categorie where nom <> Null";
                cmbFournisseur.Items.Clear();
                rstCategorie.Open(sString, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstCategorie.EOF)
                {
                    if (rstCategorie.Fields["Nom"].Value == cmbcatégorie.Text)
                        sString = (string)(rstCategorie.Fields["Correspondance"].Value);
                    rstCategorie.MoveNext();
                }
                rstCategorie.Close();
                rstCategorie = null;
                rstFournisseur.Open("Select * From Fournisseur where categorie <> Null", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstFournisseur.EOF)
                {
                    if (Strings.InStr(1, (string)(rstFournisseur.Fields["Categorie"].Value), sString, CompareMethod.Text) > 0)
                    {
                        cmbFournisseur.Items.Add(rstFournisseur.Fields["NomFournisseur"].Value);
                        cmbFournisseur.Tag = rstFournisseur.Fields["IDFRS"].Value;
                    }
                    rstFournisseur.MoveNext();
                }
                rstFournisseur.Close();
                rstFournisseur = null;
                if (cmbFournisseur.Items.Count > 0)
                {
                    cmbFournisseur.SelectedIndex = 0;
                    cmbFournisseur_SelectedIndexChanged(cmbFournisseur, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "AfficherCategorie", ex);
            }
        }
        private void RemplirComboCatégorie() // GLL 2017-11-28 V1.44 update requete SQL PWE  2024-07-11
        {
            try
            {
                SqlConnection sql = new SqlConnection(StringSQL);
                sql.Open();
                SqlDataReader rd = new SqlCommand("SELECT  NOM FROM TBL_CATEGORIE WHERE NOM !='' ORDER BY NOM", sql).ExecuteReader();
                while (rd.Read())
                {
                    cmbcatégorie.Items.Add(rd[0].ToString());
                }
                rd.Close();
                sql.Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "RemplirComboCatégorie", ex);
            }
        }
        private void AfficherCatList()
        /// V1.44 GLL  //update Ctrl Listview PWE V2.24
        {
            try
            {
                ADODB.Recordset rstlist = new ADODB.Recordset();
                rstlist.Open("SELECT * FROM TBL_CATEGORIE WHERE NOM !='' ORDER BY NOM", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                Lst_Cat.Items.Clear();
                while (!rstlist.EOF)
                {
                    ListViewItem itemlist = Lst_Cat.Items.Add(string.Empty);
                    itemlist.Text = (string)(rstlist.Fields["Nom"].Value);
                    itemlist.Tag = rstlist.Fields["Correspondance"].Value;
                    rstlist.MoveNext();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "AfficherCatList", ex);
            }
        }
        private void DeleteCategorie()
        /// PWE update Requete Access -> SQL Server 2019
        {
            try
            {
                ADODB.Recordset rstCategorie;
                string sString;
                rstCategorie = new Recordset();
                rstCategorie.Open("SELECT CATEGORIE FROM FOURNISSEUR WHERE CATEGORIE !=''", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockPessimistic);
                while (!rstCategorie.EOF)
                {
                    if (Strings.InStr(1, (string)(rstCategorie.Fields["categorie"].Value), m_Tag, CompareMethod.Text) > 0)
                    {
                        sString = (string)(rstCategorie.Fields["categorie"].Value);
                        sString = Strings.Replace(sString, m_Tag, "", 1);
                        if (string.IsNullOrEmpty(sString))
                        {
                            rstCategorie.Fields["categorie"].Value = DBNull.Value;
                        }
                        else
                        {
                            rstCategorie.Fields["categorie"].Value = sString;
                        }
                    }
                    rstCategorie.MoveNext();
                }
                rstCategorie.Close();
                rstCategorie = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "DeleteCategorie", ex);
            }
        }
        private void label31_Click(object sender, EventArgs e)
        {
        }
        private void txtContactFax_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtNomFournisseur_TextChanged(object sender, EventArgs e)
        {
        }
        // update PWE 2024
        /// <summary> 
        /// tbl_cat_exist() obsolete créee a chaque mise a jour de la version sur le serveur SQL       
        /// FindFieldsExist()  
        /// retirée obsolete
        /// </summary>
    }
}