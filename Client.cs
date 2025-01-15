using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;
using System.Collections.Generic;
#pragma warning disable CS0414
namespace ControleurServeur
{
    internal  class Client : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public Client() : base()
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
        internal System.Windows.Forms.Button cmdMailListClient;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtSiteWeb;
        internal System.Windows.Forms.TextBox txtNomClient;
        internal System.Windows.Forms.Button cmdRechercher;
        internal System.Windows.Forms.Button cmdRafraichir;
        internal System.Windows.Forms.TextBox TxtRechercher;
        internal System.Windows.Forms.Button cmdMailListContact;
        internal System.Windows.Forms.TextBox txtContactTitre;
        internal System.Windows.Forms.Button CmdAddCont;
        internal System.Windows.Forms.TextBox txtcontact_dom;
        internal System.Windows.Forms.Button cmdsupcontact;
        internal System.Windows.Forms.TextBox txtcontact_cell;
        internal System.Windows.Forms.TextBox txtcontact_fax;
        internal System.Windows.Forms.Button CmdRefCont;
        internal ComboBox cmbcontact;
        internal System.Windows.Forms.TextBox txtcontact_tel;
        internal System.Windows.Forms.TextBox txtcontact_poste;
        internal System.Windows.Forms.TextBox txtcontact_email;
        internal System.Windows.Forms.TextBox txtcontact_page;
        internal System.Windows.Forms.Button cmdanulcontact;
        internal System.Windows.Forms.TextBox txtContact;
        internal MaskedTextBox mskContactPage;
        internal MaskedTextBox mskContactFax;
        internal MaskedTextBox mskContactCell;
        internal MaskedTextBox mskContactDom;
        internal MaskedTextBox mskContactTel;
        internal System.Windows.Forms.Label _Label1_8;
        internal System.Windows.Forms.Label _Label1_6;
        internal System.Windows.Forms.Label _Label1_1;
        internal System.Windows.Forms.Label _Label1_2;
        internal System.Windows.Forms.Label _Label1_3;
        internal System.Windows.Forms.Label _Label1_4;
        internal System.Windows.Forms.Label _Label1_5;
        internal System.Windows.Forms.Label _Label1_7;
        internal System.Windows.Forms.Label Label5;
        internal GroupBox fraContact;
        internal System.Windows.Forms.Button cmdreport;
        internal System.Windows.Forms.Button cmdRenommer;
        internal System.Windows.Forms.Button CmdAdd;
        internal System.Windows.Forms.Button CmdSupp;
        internal System.Windows.Forms.Button CmdQuit;
        internal System.Windows.Forms.Button CmdEnr;
        internal System.Windows.Forms.Button CmdAnul;
        internal System.Windows.Forms.Button CmdModif;
        internal System.Windows.Forms.TextBox txtPays;
        internal System.Windows.Forms.TextBox txtCP;
        internal System.Windows.Forms.TextBox txtProvEtat;
        internal System.Windows.Forms.TextBox txtVille;
        internal System.Windows.Forms.TextBox txtAdresse;
        internal System.Windows.Forms.TextBox txtCommentaire;
        internal System.Windows.Forms.TextBox txtContactGRB;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.TextBox txtTelephone;
        internal MaskedTextBox mskTelephone;
        internal MaskedTextBox mskFax;
        internal System.Windows.Forms.Button cmdCategorie;
        internal System.Windows.Forms.CheckBox chkClientPotentiel;
        internal System.Windows.Forms.Panel fraPotentiel;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label _Label12_2;
        internal System.Windows.Forms.Label _Label12_3;
        internal System.Windows.Forms.Label lblDateCreation;
        internal System.Windows.Forms.Label lblDateModification;
        internal System.Windows.Forms.Label lblUserCreation;
        internal System.Windows.Forms.Label lblUserModification;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label _Label12_0;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label _Label1_0;

        [DebuggerStepThrough()]
        [Obsolete]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdMailListClient = new System.Windows.Forms.Button();
            txtEmail = new System.Windows.Forms.TextBox();
            txtSiteWeb = new System.Windows.Forms.TextBox();
            txtNomClient = new System.Windows.Forms.TextBox();
            cmdRechercher = new System.Windows.Forms.Button();
            cmdRafraichir = new System.Windows.Forms.Button();
            TxtRechercher = new System.Windows.Forms.TextBox();
            fraContact = new System.Windows.Forms.GroupBox();
            cmdMailListContact = new System.Windows.Forms.Button();
            txtContactTitre = new System.Windows.Forms.TextBox();
            CmdAddCont = new System.Windows.Forms.Button();
            txtcontact_dom = new System.Windows.Forms.TextBox();
            cmdsupcontact = new System.Windows.Forms.Button();
            txtcontact_cell = new System.Windows.Forms.TextBox();
            txtcontact_fax = new System.Windows.Forms.TextBox();
            cmbcontact = new System.Windows.Forms.ComboBox();
            CmdRefCont = new System.Windows.Forms.Button();
            txtcontact_tel = new System.Windows.Forms.TextBox();
            txtcontact_poste = new System.Windows.Forms.TextBox();
            txtcontact_email = new System.Windows.Forms.TextBox();
            txtcontact_page = new System.Windows.Forms.TextBox();
            cmdanulcontact = new System.Windows.Forms.Button();
            txtContact = new System.Windows.Forms.TextBox();
            mskContactPage = new System.Windows.Forms.MaskedTextBox();
            mskContactFax = new System.Windows.Forms.MaskedTextBox();
            mskContactCell = new System.Windows.Forms.MaskedTextBox();
            mskContactDom = new System.Windows.Forms.MaskedTextBox();
            mskContactTel = new System.Windows.Forms.MaskedTextBox();
            _Label1_8 = new System.Windows.Forms.Label();
            _Label1_6 = new System.Windows.Forms.Label();
            _Label1_1 = new System.Windows.Forms.Label();
            _Label1_2 = new System.Windows.Forms.Label();
            _Label1_3 = new System.Windows.Forms.Label();
            _Label1_4 = new System.Windows.Forms.Label();
            _Label1_5 = new System.Windows.Forms.Label();
            _Label1_7 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            cmdreport = new System.Windows.Forms.Button();
            cmdRenommer = new System.Windows.Forms.Button();
            CmdAdd = new System.Windows.Forms.Button();
            CmdSupp = new System.Windows.Forms.Button();
            CmdQuit = new System.Windows.Forms.Button();
            CmdEnr = new System.Windows.Forms.Button();
            CmdAnul = new System.Windows.Forms.Button();
            CmdModif = new System.Windows.Forms.Button();
            txtPays = new System.Windows.Forms.TextBox();
            txtCP = new System.Windows.Forms.TextBox();
            txtProvEtat = new System.Windows.Forms.TextBox();
            txtVille = new System.Windows.Forms.TextBox();
            txtAdresse = new System.Windows.Forms.TextBox();
            txtCommentaire = new System.Windows.Forms.TextBox();
            txtContactGRB = new System.Windows.Forms.TextBox();
            txtFax = new System.Windows.Forms.TextBox();
            txtTelephone = new System.Windows.Forms.TextBox();
            cmbClient = new System.Windows.Forms.ComboBox();
            mskTelephone = new System.Windows.Forms.MaskedTextBox();
            mskFax = new System.Windows.Forms.MaskedTextBox();
            cmdCategorie = new System.Windows.Forms.Button();
            fraPotentiel = new System.Windows.Forms.Panel();
            chkClientPotentiel = new System.Windows.Forms.CheckBox();
            Label6 = new System.Windows.Forms.Label();
            _Label12_2 = new System.Windows.Forms.Label();
            _Label12_3 = new System.Windows.Forms.Label();
            lblDateCreation = new System.Windows.Forms.Label();
            lblDateModification = new System.Windows.Forms.Label();
            lblUserCreation = new System.Windows.Forms.Label();
            lblUserModification = new System.Windows.Forms.Label();
            Label15 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label17 = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            Label14 = new System.Windows.Forms.Label();
            Label13 = new System.Windows.Forms.Label();
            _Label12_0 = new System.Windows.Forms.Label();
            Label11 = new System.Windows.Forms.Label();
            Label10 = new System.Windows.Forms.Label();
            Label9 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            _Label1_0 = new System.Windows.Forms.Label();
            txtCategorie = new System.Windows.Forms.ComboBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            fraContact.SuspendLayout();
            fraPotentiel.SuspendLayout();
            SuspendLayout();
            // 
            // ToolTip1
            // 
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // cmdMailListClient
            // 
            cmdMailListClient.AutoSize = true;
            cmdMailListClient.BackColor = System.Drawing.Color.Black;
            cmdMailListClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdMailListClient.ForeColor=System.Drawing.Color.Navy;
            cmdMailListClient.Location = new System.Drawing.Point(431, 538);
            cmdMailListClient.Name = "cmdMailListClient";
            cmdMailListClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdMailListClient.Size = new System.Drawing.Size(126, 33);
            cmdMailListClient.TabIndex = 77;
            cmdMailListClient.Text = "Ajouter au mailing list";
            cmdMailListClient.UseVisualStyleBackColor = true;
            cmdMailListClient.Click += new System.EventHandler(cmdMailListClient_Click);
            // 
            // txtEmail
            // 
            txtEmail.AcceptsReturn = true;
            txtEmail.BackColor = System.Drawing.Color.Black;
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtEmail.ForeColor = System.Drawing.Color.White;
            txtEmail.Location = new System.Drawing.Point(96, 432);
            txtEmail.MaxLength = 0;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtEmail.Size = new System.Drawing.Size(129, 22);
            txtEmail.TabIndex = 33;
            txtEmail.Text = "Text1";
            // 
            // txtSiteWeb
            // 
            txtSiteWeb.AcceptsReturn = true;
            txtSiteWeb.BackColor = System.Drawing.Color.Black;
            txtSiteWeb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtSiteWeb.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtSiteWeb.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtSiteWeb.ForeColor = System.Drawing.Color.White;
            txtSiteWeb.Location = new System.Drawing.Point(96, 404);
            txtSiteWeb.MaxLength = 0;
            txtSiteWeb.Name = "txtSiteWeb";
            txtSiteWeb.ReadOnly = true;
            txtSiteWeb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtSiteWeb.Size = new System.Drawing.Size(129, 22);
            txtSiteWeb.TabIndex = 31;
            txtSiteWeb.Text = "Text1";
            // 
            // txtNomClient
            // 
            txtNomClient.AcceptsReturn = true;
            txtNomClient.BackColor = System.Drawing.Color.Black;
            txtNomClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtNomClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNomClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNomClient.ForeColor = System.Drawing.Color.White;
            txtNomClient.Location = new System.Drawing.Point(96, 104);
            txtNomClient.MaxLength = 0;
            txtNomClient.Name = "txtNomClient";
            txtNomClient.ReadOnly = true;
            txtNomClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNomClient.Size = new System.Drawing.Size(273, 22);
            txtNomClient.TabIndex = 8;
            txtNomClient.Visible = false;
            txtNomClient.TextChanged += new System.EventHandler(txtNomClient_TextChanged);
            // 
            // cmdRechercher
            // 
            cmdRechercher.AutoSize = true;
            cmdRechercher.BackColor = System.Drawing.Color.Black;
            cmdRechercher.Enabled = false;
            cmdRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRechercher.ForeColor=System.Drawing.Color.Navy;
            cmdRechercher.Location = new System.Drawing.Point(484, 37);
            cmdRechercher.Name = "cmdRechercher";
            cmdRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercher.Size = new System.Drawing.Size(78, 26);
            cmdRechercher.TabIndex = 2;
            cmdRechercher.Text = "Rechercher";
            cmdRechercher.UseVisualStyleBackColor = true;
            cmdRechercher.Click += new System.EventHandler(cmdRechercher_Click);
            // 
            // cmdRafraichir
            // 
            cmdRafraichir.AutoSize = true;
            cmdRafraichir.BackColor = System.Drawing.Color.Black;
            cmdRafraichir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRafraichir.ForeColor=System.Drawing.Color.Navy;
            cmdRafraichir.Location = new System.Drawing.Point(104, 77);
            cmdRafraichir.Name = "cmdRafraichir";
            cmdRafraichir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRafraichir.Size = new System.Drawing.Size(68, 26);
            cmdRafraichir.TabIndex = 3;
            cmdRafraichir.Text = "Rafraîchir";
            cmdRafraichir.UseVisualStyleBackColor = true;
            cmdRafraichir.Click += new System.EventHandler(cmdRafraichir_Click);
            // 
            // TxtRechercher
            // 
            TxtRechercher.AcceptsReturn = true;
            TxtRechercher.BackColor = System.Drawing.Color.Black;
            TxtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TxtRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            TxtRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TxtRechercher.ForeColor = System.Drawing.Color.White;
            TxtRechercher.Location = new System.Drawing.Point(336, 40);
            TxtRechercher.MaxLength = 0;
            TxtRechercher.Name = "TxtRechercher";
            TxtRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TxtRechercher.Size = new System.Drawing.Size(145, 22);
            TxtRechercher.TabIndex = 1;
            TxtRechercher.TextChanged += new System.EventHandler(txtRechercher_TextChanged);
            // 
            // fraContact
            // 
            fraContact.BackColor = System.Drawing.Color.Black;
            fraContact.Controls.Add(cmdMailListContact);
            fraContact.Controls.Add(txtContactTitre);
            fraContact.Controls.Add(CmdAddCont);
            fraContact.Controls.Add(txtcontact_dom);
            fraContact.Controls.Add(cmdsupcontact);
            fraContact.Controls.Add(txtcontact_cell);
            fraContact.Controls.Add(txtcontact_fax);
            fraContact.Controls.Add(cmbcontact);
            fraContact.Controls.Add(CmdRefCont);
            fraContact.Controls.Add(txtcontact_tel);
            fraContact.Controls.Add(txtcontact_poste);
            fraContact.Controls.Add(txtcontact_email);
            fraContact.Controls.Add(txtcontact_page);
            fraContact.Controls.Add(cmdanulcontact);
            fraContact.Controls.Add(txtContact);
            fraContact.Controls.Add(mskContactPage);
            fraContact.Controls.Add(mskContactFax);
            fraContact.Controls.Add(mskContactCell);
            fraContact.Controls.Add(mskContactDom);
            fraContact.Controls.Add(mskContactTel);
            fraContact.Controls.Add(_Label1_8);
            fraContact.Controls.Add(_Label1_6);
            fraContact.Controls.Add(_Label1_1);
            fraContact.Controls.Add(_Label1_2);
            fraContact.Controls.Add(_Label1_3);
            fraContact.Controls.Add(_Label1_4);
            fraContact.Controls.Add(_Label1_5);
            fraContact.Controls.Add(_Label1_7);
            fraContact.Controls.Add(Label5);
            fraContact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraContact.ForeColor = System.Drawing.Color.White;
            fraContact.Location = new System.Drawing.Point(312, 184);
            fraContact.Name = "fraContact";
            fraContact.Padding = new System.Windows.Forms.Padding(0);
            fraContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraContact.Size = new System.Drawing.Size(297, 305);
            fraContact.TabIndex = 37;
            fraContact.TabStop = false;
            fraContact.Text = "Contact";
            // 
            // cmdMailListContact
            // 
            cmdMailListContact.AutoSize = true;
            cmdMailListContact.BackColor = System.Drawing.Color.Black;
            cmdMailListContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdMailListContact.ForeColor = System.Drawing.Color.White;
            cmdMailListContact.Location = new System.Drawing.Point(172, 265);
            cmdMailListContact.Name = "cmdMailListContact";
            cmdMailListContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdMailListContact.Size = new System.Drawing.Size(126, 33);
            cmdMailListContact.TabIndex = 66;
            cmdMailListContact.Text = "Ajouter au mailing list";
            cmdMailListContact.UseVisualStyleBackColor = true;
            cmdMailListContact.Click += new System.EventHandler(cmdMailListContact_Click);
            // 
            // txtContactTitre
            // 
            txtContactTitre.AcceptsReturn = true;
            txtContactTitre.BackColor = System.Drawing.Color.Black;
            txtContactTitre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtContactTitre.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtContactTitre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtContactTitre.ForeColor = System.Drawing.Color.White;
            txtContactTitre.Location = new System.Drawing.Point(72, 64);
            txtContactTitre.MaxLength = 0;
            txtContactTitre.Name = "txtContactTitre";
            txtContactTitre.ReadOnly = true;
            txtContactTitre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtContactTitre.Size = new System.Drawing.Size(105, 22);
            txtContactTitre.TabIndex = 45;
            // 
            // CmdAddCont
            // 
            CmdAddCont.AutoSize = true;
            CmdAddCont.BackColor = System.Drawing.Color.Black;
            CmdAddCont.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdAddCont.ForeColor=System.Drawing.Color.Navy;
            CmdAddCont.Location = new System.Drawing.Point(48, 269);
            CmdAddCont.Name = "CmdAddCont";
            CmdAddCont.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAddCont.Size = new System.Drawing.Size(73, 33);
            CmdAddCont.TabIndex = 62;
            CmdAddCont.Text = "Ajouter";
            CmdAddCont.UseVisualStyleBackColor = true;
            CmdAddCont.Click += new System.EventHandler(CmdAddCont_Click);
            // 
            // txtcontact_dom
            // 
            txtcontact_dom.AcceptsReturn = true;
            txtcontact_dom.BackColor = System.Drawing.Color.Black;
            txtcontact_dom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcontact_dom.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtcontact_dom.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtcontact_dom.ForeColor = System.Drawing.Color.White;
            txtcontact_dom.Location = new System.Drawing.Point(72, 112);
            txtcontact_dom.MaxLength = 0;
            txtcontact_dom.Name = "txtcontact_dom";
            txtcontact_dom.ReadOnly = true;
            txtcontact_dom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtcontact_dom.Size = new System.Drawing.Size(105, 22);
            txtcontact_dom.TabIndex = 49;
            // 
            // cmdsupcontact
            // 
            cmdsupcontact.AutoSize = true;
            cmdsupcontact.BackColor = System.Drawing.Color.Black;
            cmdsupcontact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdsupcontact.ForeColor=System.Drawing.Color.Navy;
            cmdsupcontact.Location = new System.Drawing.Point(87, 269);
            cmdsupcontact.Name = "cmdsupcontact";
            cmdsupcontact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdsupcontact.Size = new System.Drawing.Size(73, 33);
            cmdsupcontact.TabIndex = 65;
            cmdsupcontact.Text = "Supprimer";
            cmdsupcontact.UseVisualStyleBackColor = true;
            cmdsupcontact.Click += new System.EventHandler(cmdsupcontact_Click);
            // 
            // txtcontact_cell
            // 
            txtcontact_cell.AcceptsReturn = true;
            txtcontact_cell.BackColor = System.Drawing.Color.Black;
            txtcontact_cell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcontact_cell.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtcontact_cell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtcontact_cell.ForeColor = System.Drawing.Color.White;
            txtcontact_cell.Location = new System.Drawing.Point(72, 160);
            txtcontact_cell.MaxLength = 0;
            txtcontact_cell.Name = "txtcontact_cell";
            txtcontact_cell.ReadOnly = true;
            txtcontact_cell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtcontact_cell.Size = new System.Drawing.Size(105, 22);
            txtcontact_cell.TabIndex = 51;
            // 
            // txtcontact_fax
            // 
            txtcontact_fax.AcceptsReturn = true;
            txtcontact_fax.BackColor = System.Drawing.Color.Black;
            txtcontact_fax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcontact_fax.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtcontact_fax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtcontact_fax.ForeColor = System.Drawing.Color.White;
            txtcontact_fax.Location = new System.Drawing.Point(72, 184);
            txtcontact_fax.MaxLength = 0;
            txtcontact_fax.Name = "txtcontact_fax";
            txtcontact_fax.ReadOnly = true;
            txtcontact_fax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtcontact_fax.Size = new System.Drawing.Size(105, 22);
            txtcontact_fax.TabIndex = 55;
            // 
            // cmbcontact
            // 
            cmbcontact.BackColor = System.Drawing.Color.Black;
            cmbcontact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbcontact.ForeColor = System.Drawing.Color.White;
            cmbcontact.Location = new System.Drawing.Point(71, 24);
            cmbcontact.Name = "cmbcontact";
            cmbcontact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbcontact.Size = new System.Drawing.Size(217, 22);
            cmbcontact.TabIndex = 40;
            cmbcontact.SelectedIndexChanged += new System.EventHandler(cmbContact_SelectedIndexChanged);
            // 
            // CmdRefCont
            // 
            CmdRefCont.BackColor = System.Drawing.Color.Black;
            CmdRefCont.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdRefCont.ForeColor=System.Drawing.Color.Navy;
            CmdRefCont.Location = new System.Drawing.Point(8, 264);
            CmdRefCont.Name = "CmdRefCont";
            CmdRefCont.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdRefCont.Size = new System.Drawing.Size(73, 33);
            CmdRefCont.TabIndex = 63;
            CmdRefCont.Text = "Enregistrer";
            CmdRefCont.UseVisualStyleBackColor = true;
            CmdRefCont.Click += new System.EventHandler(CmdRefCont_Click);
            // 
            // txtcontact_tel
            // 
            txtcontact_tel.AcceptsReturn = true;
            txtcontact_tel.BackColor = System.Drawing.Color.Black;
            txtcontact_tel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcontact_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtcontact_tel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtcontact_tel.ForeColor = System.Drawing.Color.White;
            txtcontact_tel.Location = new System.Drawing.Point(72, 88);
            txtcontact_tel.MaxLength = 0;
            txtcontact_tel.Name = "txtcontact_tel";
            txtcontact_tel.ReadOnly = true;
            txtcontact_tel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtcontact_tel.Size = new System.Drawing.Size(105, 22);
            txtcontact_tel.TabIndex = 46;
            // 
            // txtcontact_poste
            // 
            txtcontact_poste.AcceptsReturn = true;
            txtcontact_poste.BackColor = System.Drawing.Color.Black;
            txtcontact_poste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcontact_poste.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtcontact_poste.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtcontact_poste.ForeColor = System.Drawing.Color.White;
            txtcontact_poste.Location = new System.Drawing.Point(72, 136);
            txtcontact_poste.MaxLength = 0;
            txtcontact_poste.Name = "txtcontact_poste";
            txtcontact_poste.ReadOnly = true;
            txtcontact_poste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtcontact_poste.Size = new System.Drawing.Size(49, 22);
            txtcontact_poste.TabIndex = 50;
            // 
            // txtcontact_email
            // 
            txtcontact_email.AcceptsReturn = true;
            txtcontact_email.BackColor = System.Drawing.Color.Black;
            txtcontact_email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcontact_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtcontact_email.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtcontact_email.ForeColor = System.Drawing.Color.White;
            txtcontact_email.Location = new System.Drawing.Point(72, 232);
            txtcontact_email.MaxLength = 0;
            txtcontact_email.Name = "txtcontact_email";
            txtcontact_email.ReadOnly = true;
            txtcontact_email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtcontact_email.Size = new System.Drawing.Size(217, 22);
            txtcontact_email.TabIndex = 60;
            // 
            // txtcontact_page
            // 
            txtcontact_page.AcceptsReturn = true;
            txtcontact_page.BackColor = System.Drawing.Color.Black;
            txtcontact_page.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcontact_page.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtcontact_page.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtcontact_page.ForeColor = System.Drawing.Color.White;
            txtcontact_page.Location = new System.Drawing.Point(72, 208);
            txtcontact_page.MaxLength = 0;
            txtcontact_page.Name = "txtcontact_page";
            txtcontact_page.ReadOnly = true;
            txtcontact_page.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtcontact_page.Size = new System.Drawing.Size(105, 22);
            txtcontact_page.TabIndex = 57;
            // 
            // cmdanulcontact
            // 
            cmdanulcontact.AutoSize = true;
            cmdanulcontact.BackColor = System.Drawing.Color.Black;
            cmdanulcontact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdanulcontact.ForeColor=System.Drawing.Color.Navy;
            cmdanulcontact.Location = new System.Drawing.Point(88, 264);
            cmdanulcontact.Name = "cmdanulcontact";
            cmdanulcontact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdanulcontact.Size = new System.Drawing.Size(73, 33);
            cmdanulcontact.TabIndex = 64;
            cmdanulcontact.Text = "A&nnuler";
            cmdanulcontact.UseVisualStyleBackColor = true;
            cmdanulcontact.Click += new System.EventHandler(cmdanulcontact_Click);
            // 
            // txtContact
            // 
            txtContact.AcceptsReturn = true;
            txtContact.BackColor = System.Drawing.Color.Black;
            txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtContact.ForeColor = System.Drawing.Color.White;
            txtContact.Location = new System.Drawing.Point(72, 24);
            txtContact.MaxLength = 0;
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtContact.Size = new System.Drawing.Size(217, 22);
            txtContact.TabIndex = 39;
            txtContact.Visible = false;
            // 
            // mskContactPage
            // 
            mskContactPage.BackColor = System.Drawing.Color.Black;
            mskContactPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskContactPage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskContactPage.ForeColor = System.Drawing.Color.White;
            mskContactPage.Location = new System.Drawing.Point(72, 208);
            mskContactPage.Name = "mskContactPage";
            mskContactPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mskContactPage.Size = new System.Drawing.Size(105, 22);
            mskContactPage.TabIndex = 58;
            mskContactPage.Visible = false;
            // 
            // mskContactFax
            // 
            mskContactFax.BackColor = System.Drawing.Color.Black;
            mskContactFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskContactFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskContactFax.ForeColor = System.Drawing.Color.White;
            mskContactFax.Location = new System.Drawing.Point(72, 184);
            mskContactFax.Name = "mskContactFax";
            mskContactFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mskContactFax.Size = new System.Drawing.Size(105, 22);
            mskContactFax.TabIndex = 54;
            mskContactFax.Visible = false;
            // 
            // mskContactCell
            // 
            mskContactCell.BackColor = System.Drawing.Color.Black;
            mskContactCell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskContactCell.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskContactCell.ForeColor = System.Drawing.Color.White;
            mskContactCell.Location = new System.Drawing.Point(72, 160);
            mskContactCell.Name = "mskContactCell";
            mskContactCell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mskContactCell.Size = new System.Drawing.Size(105, 22);
            mskContactCell.TabIndex = 53;
            mskContactCell.Visible = false;
            // 
            // mskContactDom
            // 
            mskContactDom.BackColor = System.Drawing.Color.Black;
            mskContactDom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskContactDom.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskContactDom.ForeColor = System.Drawing.Color.White;
            mskContactDom.Location = new System.Drawing.Point(72, 112);
            mskContactDom.Name = "mskContactDom";
            mskContactDom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mskContactDom.Size = new System.Drawing.Size(105, 22);
            mskContactDom.TabIndex = 48;
            mskContactDom.Visible = false;
            // 
            // mskContactTel
            // 
            mskContactTel.BackColor = System.Drawing.Color.Black;
            mskContactTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskContactTel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskContactTel.ForeColor = System.Drawing.Color.White;
            mskContactTel.Location = new System.Drawing.Point(72, 88);
            mskContactTel.Name = "mskContactTel";
            mskContactTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mskContactTel.Size = new System.Drawing.Size(105, 22);
            mskContactTel.TabIndex = 47;
            mskContactTel.Visible = false;
            // 
            // _Label1_8
            // 
            _Label1_8.BackColor = System.Drawing.Color.Black;
            _Label1_8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_8.ForeColor = System.Drawing.Color.White;
            _Label1_8.Location = new System.Drawing.Point(8, 64);
            _Label1_8.Name = "_Label1_8";
            _Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_8.Size = new System.Drawing.Size(73, 17);
            _Label1_8.TabIndex = 44;
            _Label1_8.Text = "Titre ";
            // 
            // _Label1_6
            // 
            _Label1_6.BackColor = System.Drawing.Color.Black;
            _Label1_6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_6.ForeColor = System.Drawing.Color.White;
            _Label1_6.Location = new System.Drawing.Point(8, 112);
            _Label1_6.Name = "_Label1_6";
            _Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_6.Size = new System.Drawing.Size(73, 17);
            _Label1_6.TabIndex = 42;
            _Label1_6.Text = "Domicile";
            // 
            // _Label1_1
            // 
            _Label1_1.BackColor = System.Drawing.Color.Black;
            _Label1_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_1.ForeColor = System.Drawing.Color.White;
            _Label1_1.Location = new System.Drawing.Point(8, 88);
            _Label1_1.Name = "_Label1_1";
            _Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_1.Size = new System.Drawing.Size(73, 17);
            _Label1_1.TabIndex = 41;
            _Label1_1.Text = "Telephone";
            // 
            // _Label1_2
            // 
            _Label1_2.BackColor = System.Drawing.Color.Black;
            _Label1_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_2.ForeColor = System.Drawing.Color.White;
            _Label1_2.Location = new System.Drawing.Point(8, 160);
            _Label1_2.Name = "_Label1_2";
            _Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_2.Size = new System.Drawing.Size(65, 17);
            _Label1_2.TabIndex = 52;
            _Label1_2.Text = "Cellulaire";
            // 
            // _Label1_3
            // 
            _Label1_3.BackColor = System.Drawing.Color.Black;
            _Label1_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_3.ForeColor = System.Drawing.Color.White;
            _Label1_3.Location = new System.Drawing.Point(8, 184);
            _Label1_3.Name = "_Label1_3";
            _Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_3.Size = new System.Drawing.Size(65, 17);
            _Label1_3.TabIndex = 56;
            _Label1_3.Text = "Fax";
            // 
            // _Label1_4
            // 
            _Label1_4.BackColor = System.Drawing.Color.Black;
            _Label1_4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_4.ForeColor = System.Drawing.Color.White;
            _Label1_4.Location = new System.Drawing.Point(8, 208);
            _Label1_4.Name = "_Label1_4";
            _Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_4.Size = new System.Drawing.Size(65, 17);
            _Label1_4.TabIndex = 59;
            _Label1_4.Text = "Pagette";
            // 
            // _Label1_5
            // 
            _Label1_5.BackColor = System.Drawing.Color.Black;
            _Label1_5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_5.ForeColor = System.Drawing.Color.White;
            _Label1_5.Location = new System.Drawing.Point(8, 232);
            _Label1_5.Name = "_Label1_5";
            _Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_5.Size = new System.Drawing.Size(65, 17);
            _Label1_5.TabIndex = 61;
            _Label1_5.Text = "E-Mail";
            // 
            // _Label1_7
            // 
            _Label1_7.BackColor = System.Drawing.Color.Black;
            _Label1_7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_7.ForeColor = System.Drawing.Color.White;
            _Label1_7.Location = new System.Drawing.Point(8, 136);
            _Label1_7.Name = "_Label1_7";
            _Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_7.Size = new System.Drawing.Size(73, 17);
            _Label1_7.TabIndex = 43;
            _Label1_7.Text = "Poste";
            // 
            // Label5
            // 
            Label5.BackColor = System.Drawing.Color.Black;
            Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(8, 24);
            Label5.Name = "Label5";
            Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label5.Size = new System.Drawing.Size(57, 17);
            Label5.TabIndex = 38;
            Label5.Text = "Contact";
            // 
            // cmdreport
            // 
            cmdreport.AutoSize = true;
            cmdreport.BackColor = System.Drawing.Color.Black;
            cmdreport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdreport.ForeColor=System.Drawing.Color.Navy;
            cmdreport.Location = new System.Drawing.Point(86, 538);
            cmdreport.Name = "cmdreport";
            cmdreport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdreport.Size = new System.Drawing.Size(85, 33);
            cmdreport.TabIndex = 70;
            cmdreport.Text = "&Impression";
            cmdreport.UseVisualStyleBackColor = true;
            cmdreport.Click += new System.EventHandler(cmdreport_Click);
            // 
            // cmdRenommer
            // 
            cmdRenommer.AutoSize = true;
            cmdRenommer.BackColor = System.Drawing.Color.Black;
            cmdRenommer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRenommer.ForeColor=System.Drawing.Color.Navy;
            cmdRenommer.Location = new System.Drawing.Point(171, 77);
            cmdRenommer.Name = "cmdRenommer";
            cmdRenommer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRenommer.Size = new System.Drawing.Size(72, 26);
            cmdRenommer.TabIndex = 4;
            cmdRenommer.Text = "Renommer";
            cmdRenommer.UseVisualStyleBackColor = true;
            cmdRenommer.Click += new System.EventHandler(cmdRenommer_Click);
            // 
            // CmdAdd
            // 
            CmdAdd.AutoSize = true;
            CmdAdd.BackColor = System.Drawing.Color.Black;
            CmdAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdAdd.ForeColor=System.Drawing.Color.Navy;
            CmdAdd.Location = new System.Drawing.Point(192, 538);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAdd.Size = new System.Drawing.Size(73, 33);
            CmdAdd.TabIndex = 71;
            CmdAdd.Text = "&Ajouter";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += new System.EventHandler(CmdAdd_Click);
            // 
            // CmdSupp
            // 
            CmdSupp.BackColor = System.Drawing.Color.Black;
            CmdSupp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdSupp.ForeColor=System.Drawing.Color.Navy;
            CmdSupp.Location = new System.Drawing.Point(280, 538);
            CmdSupp.Name = "CmdSupp";
            CmdSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdSupp.Size = new System.Drawing.Size(73, 33);
            CmdSupp.TabIndex = 74;
            CmdSupp.Text = "&Supprimer";
            CmdSupp.UseVisualStyleBackColor = true;
            CmdSupp.Click += new System.EventHandler(CmdSupp_Click);
            // 
            // CmdQuit
            // 
            CmdQuit.AutoSize = true;
            CmdQuit.BackColor = System.Drawing.Color.Black;
            CmdQuit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdQuit.ForeColor=System.Drawing.Color.Navy;
            CmdQuit.Location = new System.Drawing.Point(553, 538);
            CmdQuit.Name = "CmdQuit";
            CmdQuit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdQuit.Size = new System.Drawing.Size(73, 33);
            CmdQuit.TabIndex = 78;
            CmdQuit.Text = "&Fermer";
            CmdQuit.UseVisualStyleBackColor = true;
            CmdQuit.Click += new System.EventHandler(cmdquit_Click);
            // 
            // CmdEnr
            // 
            CmdEnr.BackColor = System.Drawing.Color.Black;
            CmdEnr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdEnr.ForeColor=System.Drawing.Color.Navy;
            CmdEnr.Location = new System.Drawing.Point(203, 538);
            CmdEnr.Name = "CmdEnr";
            CmdEnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdEnr.Size = new System.Drawing.Size(73, 33);
            CmdEnr.TabIndex = 72;
            CmdEnr.Text = "Enregistrer";
            CmdEnr.UseVisualStyleBackColor = true;
            CmdEnr.Click += new System.EventHandler(CmdEnr_Click);
            // 
            // CmdAnul
            // 
            CmdAnul.AutoSize = true;
            CmdAnul.BackColor = System.Drawing.Color.Black;
            CmdAnul.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdAnul.ForeColor=System.Drawing.Color.Navy;
            CmdAnul.Location = new System.Drawing.Point(279, 538);
            CmdAnul.Name = "CmdAnul";
            CmdAnul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAnul.Size = new System.Drawing.Size(73, 33);
            CmdAnul.TabIndex = 73;
            CmdAnul.Text = "A&nnuler";
            CmdAnul.UseVisualStyleBackColor = true;
            CmdAnul.Click += new System.EventHandler(CmdAnul_Click);
            // 
            // CmdModif
            // 
            CmdModif.AutoSize = true;
            CmdModif.BackColor = System.Drawing.Color.Black;
            CmdModif.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdModif.ForeColor=System.Drawing.Color.Navy;
            CmdModif.Location = new System.Drawing.Point(355, 538);
            CmdModif.Name = "CmdModif";
            CmdModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdModif.Size = new System.Drawing.Size(73, 33);
            CmdModif.TabIndex = 75;
            CmdModif.Text = "&Modifier";
            CmdModif.UseVisualStyleBackColor = true;
            CmdModif.Click += new System.EventHandler(CmdModif_Click);
            // 
            // txtPays
            // 
            txtPays.AcceptsReturn = true;
            txtPays.BackColor = System.Drawing.Color.Black;
            txtPays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtPays.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPays.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtPays.ForeColor = System.Drawing.Color.White;
            txtPays.Location = new System.Drawing.Point(96, 348);
            txtPays.MaxLength = 0;
            txtPays.Name = "txtPays";
            txtPays.ReadOnly = true;
            txtPays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPays.Size = new System.Drawing.Size(129, 22);
            txtPays.TabIndex = 27;
            txtPays.Text = "Text1";
            // 
            // txtCP
            // 
            txtCP.AcceptsReturn = true;
            txtCP.BackColor = System.Drawing.Color.Black;
            txtCP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCP.ForeColor = System.Drawing.Color.White;
            txtCP.Location = new System.Drawing.Point(96, 376);
            txtCP.MaxLength = 0;
            txtCP.Name = "txtCP";
            txtCP.ReadOnly = true;
            txtCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCP.Size = new System.Drawing.Size(129, 22);
            txtCP.TabIndex = 29;
            txtCP.Text = "Text1";
            // 
            // txtProvEtat
            // 
            txtProvEtat.AcceptsReturn = true;
            txtProvEtat.BackColor = System.Drawing.Color.Black;
            txtProvEtat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtProvEtat.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtProvEtat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtProvEtat.ForeColor = System.Drawing.Color.White;
            txtProvEtat.Location = new System.Drawing.Point(96, 320);
            txtProvEtat.MaxLength = 0;
            txtProvEtat.Name = "txtProvEtat";
            txtProvEtat.ReadOnly = true;
            txtProvEtat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtProvEtat.Size = new System.Drawing.Size(129, 22);
            txtProvEtat.TabIndex = 25;
            txtProvEtat.Text = "Text1";
            // 
            // txtVille
            // 
            txtVille.AcceptsReturn = true;
            txtVille.BackColor = System.Drawing.Color.Black;
            txtVille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtVille.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtVille.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtVille.ForeColor = System.Drawing.Color.White;
            txtVille.Location = new System.Drawing.Point(96, 292);
            txtVille.MaxLength = 0;
            txtVille.Name = "txtVille";
            txtVille.ReadOnly = true;
            txtVille.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtVille.Size = new System.Drawing.Size(129, 22);
            txtVille.TabIndex = 23;
            txtVille.Text = "Text1";
            // 
            // txtAdresse
            // 
            txtAdresse.AcceptsReturn = true;
            txtAdresse.BackColor = System.Drawing.Color.Black;
            txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAdresse.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtAdresse.ForeColor = System.Drawing.Color.White;
            txtAdresse.Location = new System.Drawing.Point(96, 264);
            txtAdresse.MaxLength = 0;
            txtAdresse.Name = "txtAdresse";
            txtAdresse.ReadOnly = true;
            txtAdresse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAdresse.Size = new System.Drawing.Size(169, 22);
            txtAdresse.TabIndex = 21;
            txtAdresse.Text = "Text1";
            // 
            // txtCommentaire
            // 
            txtCommentaire.AcceptsReturn = true;
            txtCommentaire.BackColor = System.Drawing.Color.Black;
            txtCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtCommentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCommentaire.ForeColor = System.Drawing.Color.White;
            txtCommentaire.Location = new System.Drawing.Point(432, 104);
            txtCommentaire.MaxLength = 0;
            txtCommentaire.Multiline = true;
            txtCommentaire.Name = "txtCommentaire";
            txtCommentaire.ReadOnly = true;
            txtCommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtCommentaire.Size = new System.Drawing.Size(177, 49);
            txtCommentaire.TabIndex = 9;
            txtCommentaire.Text = "Text2";
            // 
            // txtContactGRB
            // 
            txtContactGRB.AcceptsReturn = true;
            txtContactGRB.BackColor = System.Drawing.Color.Black;
            txtContactGRB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtContactGRB.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtContactGRB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtContactGRB.ForeColor = System.Drawing.Color.White;
            txtContactGRB.Location = new System.Drawing.Point(96, 236);
            txtContactGRB.MaxLength = 0;
            txtContactGRB.Name = "txtContactGRB";
            txtContactGRB.ReadOnly = true;
            txtContactGRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtContactGRB.Size = new System.Drawing.Size(129, 22);
            txtContactGRB.TabIndex = 19;
            txtContactGRB.Text = "Text1";
            // 
            // txtFax
            // 
            txtFax.AcceptsReturn = true;
            txtFax.BackColor = System.Drawing.Color.Black;
            txtFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtFax.ForeColor = System.Drawing.Color.White;
            txtFax.Location = new System.Drawing.Point(96, 208);
            txtFax.MaxLength = 0;
            txtFax.Name = "txtFax";
            txtFax.ReadOnly = true;
            txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtFax.Size = new System.Drawing.Size(129, 22);
            txtFax.TabIndex = 14;
            txtFax.Text = "Text1";
            // 
            // txtTelephone
            // 
            txtTelephone.AcceptsReturn = true;
            txtTelephone.BackColor = System.Drawing.Color.Black;
            txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTelephone.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTelephone.ForeColor = System.Drawing.Color.White;
            txtTelephone.Location = new System.Drawing.Point(96, 180);
            txtTelephone.MaxLength = 0;
            txtTelephone.Name = "txtTelephone";
            txtTelephone.ReadOnly = true;
            txtTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTelephone.Size = new System.Drawing.Size(129, 22);
            txtTelephone.TabIndex = 12;
            txtTelephone.Text = "Text1";
            // 
            // cmbClient
            // 
            cmbClient.BackColor = System.Drawing.Color.Black;
            cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbClient.ForeColor = System.Drawing.Color.White;
            cmbClient.Location = new System.Drawing.Point(96, 104);
            cmbClient.Name = "cmbClient";
            cmbClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbClient.Size = new System.Drawing.Size(289, 22);
            cmbClient.TabIndex = 7;
            cmbClient.SelectedIndexChanged += new System.EventHandler(cmbclient_SelectedIndexChanged);
            // 
            // mskTelephone
            // 
            mskTelephone.BackColor = System.Drawing.Color.Black;
            mskTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskTelephone.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskTelephone.ForeColor = System.Drawing.Color.White;
            mskTelephone.Location = new System.Drawing.Point(96, 180);
            mskTelephone.Name = "mskTelephone";
            mskTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mskTelephone.Size = new System.Drawing.Size(129, 22);
            mskTelephone.TabIndex = 11;
            mskTelephone.Visible = false;
            // 
            // mskFax
            // 
            mskFax.BackColor = System.Drawing.Color.Black;
            mskFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskFax.ForeColor = System.Drawing.Color.White;
            mskFax.Location = new System.Drawing.Point(96, 208);
            mskFax.Name = "mskFax";
            mskFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mskFax.Size = new System.Drawing.Size(129, 22);
            mskFax.TabIndex = 15;
            mskFax.Visible = false;
            // 
            // cmdCategorie
            // 
            cmdCategorie.AutoSize = true;
            cmdCategorie.BackColor = System.Drawing.Color.Black;
            cmdCategorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdCategorie.ForeColor = System.Drawing.Color.White;
            cmdCategorie.Location = new System.Drawing.Point(349, 144);
            cmdCategorie.Name = "cmdCategorie";
            cmdCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCategorie.Size = new System.Drawing.Size(27, 26);
            cmdCategorie.TabIndex = 79;
            cmdCategorie.Text = "..";
            cmdCategorie.UseVisualStyleBackColor = true;
            cmdCategorie.Click += new System.EventHandler(cmdCategorie_Click);
            // 
            // fraPotentiel
            // 
            fraPotentiel.BackColor = System.Drawing.Color.Black;
            fraPotentiel.Controls.Add(chkClientPotentiel);
            fraPotentiel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraPotentiel.ForeColor = System.Drawing.Color.White;
            fraPotentiel.Location = new System.Drawing.Point(416, 152);
            fraPotentiel.Name = "fraPotentiel";
            fraPotentiel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraPotentiel.Size = new System.Drawing.Size(161, 41);
            fraPotentiel.TabIndex = 82;
            // 
            // chkClientPotentiel
            // 
            chkClientPotentiel.BackColor = System.Drawing.Color.Black;
            chkClientPotentiel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkClientPotentiel.ForeColor = System.Drawing.Color.White;
            chkClientPotentiel.Location = new System.Drawing.Point(16, 8);
            chkClientPotentiel.Name = "chkClientPotentiel";
            chkClientPotentiel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkClientPotentiel.Size = new System.Drawing.Size(129, 17);
            chkClientPotentiel.TabIndex = 83;
            chkClientPotentiel.Text = "Client Potentiel      ";
            chkClientPotentiel.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = System.Drawing.Color.Black;
            Label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label6.ForeColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(16, 152);
            Label6.Name = "Label6";
            Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label6.Size = new System.Drawing.Size(61, 14);
            Label6.TabIndex = 81;
            Label6.Text = "Categorie";
            // 
            // _Label12_2
            // 
            _Label12_2.AutoSize = true;
            _Label12_2.BackColor = System.Drawing.Color.Black;
            _Label12_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label12_2.ForeColor = System.Drawing.Color.White;
            _Label12_2.Location = new System.Drawing.Point(16, 464);
            _Label12_2.Name = "_Label12_2";
            _Label12_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label12_2.Size = new System.Drawing.Size(60, 14);
            _Label12_2.TabIndex = 36;
            _Label12_2.Text = "Création :";
            // 
            // _Label12_3
            // 
            _Label12_3.AutoSize = true;
            _Label12_3.BackColor = System.Drawing.Color.Black;
            _Label12_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label12_3.ForeColor = System.Drawing.Color.White;
            _Label12_3.Location = new System.Drawing.Point(16, 492);
            _Label12_3.Name = "_Label12_3";
            _Label12_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label12_3.Size = new System.Drawing.Size(80, 14);
            _Label12_3.TabIndex = 69;
            _Label12_3.Text = "Modification :";
            // 
            // lblDateCreation
            // 
            lblDateCreation.BackColor = System.Drawing.Color.Black;
            lblDateCreation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblDateCreation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateCreation.ForeColor = System.Drawing.Color.White;
            lblDateCreation.Location = new System.Drawing.Point(96, 463);
            lblDateCreation.Name = "lblDateCreation";
            lblDateCreation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateCreation.Size = new System.Drawing.Size(65, 19);
            lblDateCreation.TabIndex = 34;
            lblDateCreation.Text = "2004-09-14";
            lblDateCreation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateModification
            // 
            lblDateModification.BackColor = System.Drawing.Color.Black;
            lblDateModification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblDateModification.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateModification.ForeColor = System.Drawing.Color.White;
            lblDateModification.Location = new System.Drawing.Point(97, 492);
            lblDateModification.Name = "lblDateModification";
            lblDateModification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateModification.Size = new System.Drawing.Size(65, 19);
            lblDateModification.TabIndex = 67;
            lblDateModification.Text = "2004-09-14";
            lblDateModification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserCreation
            // 
            lblUserCreation.BackColor = System.Drawing.Color.Black;
            lblUserCreation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserCreation.ForeColor = System.Drawing.Color.White;
            lblUserCreation.Location = new System.Drawing.Point(167, 464);
            lblUserCreation.Name = "lblUserCreation";
            lblUserCreation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblUserCreation.Size = new System.Drawing.Size(89, 17);
            lblUserCreation.TabIndex = 35;
            lblUserCreation.Text = "Par :";
            // 
            // lblUserModification
            // 
            lblUserModification.BackColor = System.Drawing.Color.Black;
            lblUserModification.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserModification.ForeColor = System.Drawing.Color.White;
            lblUserModification.Location = new System.Drawing.Point(168, 493);
            lblUserModification.Name = "lblUserModification";
            lblUserModification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblUserModification.Size = new System.Drawing.Size(89, 17);
            lblUserModification.TabIndex = 68;
            lblUserModification.Text = "Par :";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.BackColor = System.Drawing.Color.Black;
            Label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label15.ForeColor = System.Drawing.Color.White;
            Label15.Location = new System.Drawing.Point(16, 432);
            Label15.Name = "Label15";
            Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label15.Size = new System.Drawing.Size(39, 14);
            Label15.TabIndex = 32;
            Label15.Text = "E-Mail";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(16, 404);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(55, 14);
            Label2.TabIndex = 30;
            Label2.Text = "Site Web";
            // 
            // Label17
            // 
            Label17.BackColor = System.Drawing.Color.Black;
            Label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label17.ForeColor = System.Drawing.Color.White;
            Label17.Location = new System.Drawing.Point(352, 16);
            Label17.Name = "Label17";
            Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label17.Size = new System.Drawing.Size(113, 17);
            Label17.TabIndex = 0;
            Label17.Text = "Rechercher";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = System.Drawing.Color.Black;
            Label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label8.ForeColor = System.Drawing.Color.White;
            Label8.Location = new System.Drawing.Point(16, 236);
            Label8.Name = "Label8";
            Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label8.Size = new System.Drawing.Size(71, 14);
            Label8.TabIndex = 18;
            Label8.Text = "ContactGRB";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.BackColor = System.Drawing.Color.Black;
            Label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label14.ForeColor = System.Drawing.Color.White;
            Label14.Location = new System.Drawing.Point(16, 348);
            Label14.Name = "Label14";
            Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label14.Size = new System.Drawing.Size(33, 14);
            Label14.TabIndex = 26;
            Label14.Text = "Pays";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.BackColor = System.Drawing.Color.Black;
            Label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label13.ForeColor = System.Drawing.Color.White;
            Label13.Location = new System.Drawing.Point(16, 376);
            Label13.Name = "Label13";
            Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label13.Size = new System.Drawing.Size(73, 14);
            Label13.TabIndex = 28;
            Label13.Text = "Code Postal";
            // 
            // _Label12_0
            // 
            _Label12_0.AutoSize = true;
            _Label12_0.BackColor = System.Drawing.Color.Black;
            _Label12_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label12_0.ForeColor = System.Drawing.Color.White;
            _Label12_0.Location = new System.Drawing.Point(16, 320);
            _Label12_0.Name = "_Label12_0";
            _Label12_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label12_0.Size = new System.Drawing.Size(55, 14);
            _Label12_0.TabIndex = 24;
            _Label12_0.Text = "Prov/Etat";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.BackColor = System.Drawing.Color.Black;
            Label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label11.ForeColor = System.Drawing.Color.White;
            Label11.Location = new System.Drawing.Point(16, 292);
            Label11.Name = "Label11";
            Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label11.Size = new System.Drawing.Size(31, 14);
            Label11.TabIndex = 22;
            Label11.Text = "Ville";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = System.Drawing.Color.Black;
            Label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label10.ForeColor = System.Drawing.Color.White;
            Label10.Location = new System.Drawing.Point(16, 264);
            Label10.Name = "Label10";
            Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label10.Size = new System.Drawing.Size(55, 14);
            Label10.TabIndex = 20;
            Label10.Text = "Adresse";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = System.Drawing.Color.Black;
            Label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label9.ForeColor = System.Drawing.Color.White;
            Label9.Location = new System.Drawing.Point(432, 88);
            Label9.Name = "Label9";
            Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label9.Size = new System.Drawing.Size(90, 14);
            Label9.TabIndex = 5;
            Label9.Text = "Commentaires";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(16, 208);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(25, 14);
            Label4.TabIndex = 13;
            Label4.Text = "Fax";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(16, 180);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(65, 14);
            Label3.TabIndex = 10;
            Label3.Text = "Telephone";
            // 
            // _Label1_0
            // 
            _Label1_0.AutoSize = true;
            _Label1_0.BackColor = System.Drawing.Color.Black;
            _Label1_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_0.ForeColor = System.Drawing.Color.White;
            _Label1_0.Location = new System.Drawing.Point(16, 104);
            _Label1_0.Name = "_Label1_0";
            _Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_0.Size = new System.Drawing.Size(39, 14);
            _Label1_0.TabIndex = 6;
            _Label1_0.Text = "Client";
            // 
            // txtCategorie
            // 
            txtCategorie.BackColor = System.Drawing.Color.Black;
            txtCategorie.ForeColor = System.Drawing.Color.White;
            txtCategorie.FormattingEnabled = true;
            txtCategorie.Location = new System.Drawing.Point(96, 147);
            txtCategorie.Name = "txtCategorie";
            txtCategorie.Size = new System.Drawing.Size(247, 22);
            txtCategorie.TabIndex = 83;
            txtCategorie.SelectedIndexChanged += new System.EventHandler(txtCategorie_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = System.Drawing.Color.Black;
            linkLabel1.ForeColor = System.Drawing.Color.White;
            linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            linkLabel1.Location = new System.Drawing.Point(536, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(102, 14);
            linkLabel1.TabIndex = 84;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Imprimer cette vue";
            linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = System.Drawing.Color.Black;
            maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            maskedTextBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maskedTextBox1.ForeColor = System.Drawing.Color.White;
            maskedTextBox1.Location = new System.Drawing.Point(96, 208);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maskedTextBox1.Size = new System.Drawing.Size(129, 22);
            maskedTextBox1.TabIndex = 15;
            maskedTextBox1.Visible = false;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = System.Drawing.Color.Black;
            maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            maskedTextBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maskedTextBox2.ForeColor = System.Drawing.Color.White;
            maskedTextBox2.Location = new System.Drawing.Point(96, 180);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maskedTextBox2.Size = new System.Drawing.Size(129, 22);
            maskedTextBox2.TabIndex = 11;
            maskedTextBox2.Visible = false;
            // 
            // Client
            // 
            AcceptButton = cmdRechercher;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(638, 583);
            Controls.Add(linkLabel1);
            Controls.Add(txtCategorie);
            Controls.Add(cmdMailListClient);
            Controls.Add(txtEmail);
            Controls.Add(txtSiteWeb);
            Controls.Add(txtNomClient);
            Controls.Add(cmdRechercher);
            Controls.Add(cmdRafraichir);
            Controls.Add(TxtRechercher);
            Controls.Add(fraContact);
            Controls.Add(cmdreport);
            Controls.Add(cmdRenommer);
            Controls.Add(CmdAdd);
            Controls.Add(CmdSupp);
            Controls.Add(CmdQuit);
            Controls.Add(CmdEnr);
            Controls.Add(CmdAnul);
            Controls.Add(CmdModif);
            Controls.Add(txtPays);
            Controls.Add(txtCP);
            Controls.Add(txtProvEtat);
            Controls.Add(txtVille);
            Controls.Add(txtAdresse);
            Controls.Add(txtCommentaire);
            Controls.Add(txtContactGRB);
            Controls.Add(txtFax);
            Controls.Add(txtTelephone);
            Controls.Add(maskedTextBox2);
            Controls.Add(cmbClient);
            Controls.Add(maskedTextBox1);
            Controls.Add(mskTelephone);
            Controls.Add(mskFax);
            Controls.Add(cmdCategorie);
            Controls.Add(fraPotentiel);
            Controls.Add(Label6);
            Controls.Add(_Label12_2);
            Controls.Add(_Label12_3);
            Controls.Add(lblDateCreation);
            Controls.Add(lblDateModification);
            Controls.Add(lblUserCreation);
            Controls.Add(lblUserModification);
            Controls.Add(Label15);
            Controls.Add(Label2);
            Controls.Add(Label17);
            Controls.Add(Label8);
            Controls.Add(Label14);
            Controls.Add(Label13);
            Controls.Add(_Label12_0);
            Controls.Add(Label11);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(_Label1_0);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            Location = new System.Drawing.Point(144, 68);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Client";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clients";
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(Client_FormClosed);
            Load += new System.EventHandler(Client_Load);
            fraContact.ResumeLayout(false);
            fraContact.PerformLayout();
            fraPotentiel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        internal ComboBox txtCategorie;
        internal LinkLabel linkLabel1;
        internal MaskedTextBox maskedTextBox1;
        internal MaskedTextBox maskedTextBox2;
        internal ComboBox cmbClient;

        private enum EnumMode{MODE_CLIENT = 0,MODE_CONTACT = 1,MODE_INACTIF = 2}
        internal static int IdClient = 0;
        internal static bool m_bCategorieBeton;
        internal static bool m_bCategoriePave;
        internal static bool m_bCategoriePharmaceutique;
        internal static bool m_bCategorieAgroalimentaire;
        internal static bool m_bCategorieMeuble;
        internal static bool m_bCategorieMeunerie;
        internal static bool m_bCategorieManufacturier;
        internal static bool m_bCategorieConsultant;
        internal static bool m_bCategorieAsphalte;
        internal static bool m_bCategorieICPI;
        internal static bool m_bCategorieProduitsChimiques;
        internal static bool m_bCategorieAutre;
        internal static bool m_bImpressionAnnuler;
        internal static bool m_bImpressionVille;
        internal static bool m_bImpressionCategorie;
        internal static bool m_bImpressionPotentiel;
        internal static bool m_bImpressionFacturer;
        internal static bool m_bImpressionBeton;
        internal static bool m_bImpressionPave;
        internal static bool m_bImpressionPharmaceutique;
        internal static bool m_bImpressionAgroAlimentaire;
        internal static bool m_bImpressionMeuble;
        internal static bool m_bImpressionMeunerie;
        internal static bool m_bImpressionManufacturier;
        internal static bool m_bImpressionConsultant;
        internal static bool m_bImpressionAsphalte;
        internal static bool m_bImpressionICPI;
        internal static bool m_bImpressionProduitsChimiques;
        internal static bool m_bImpressionAutre;
        private bool m_bModeAjoutContact;
        private bool m_bModeAjoutClient;
        private int m_iNoContact;
        private int m_iNoClient;
        private bool m_bRenommer;
        private bool m_bNewContact;
        Bitmap memoryImage;
        PrintDocument printDocument1 = new PrintDocument();
        internal static bool m_bAnnulerDistList;
        public Microsoft.Office.Interop.Outlook.DistListItem m_otlDistList;
        internal static bool m_bAnnulerVille;
        public static string m_sVille;
        SqlConnection con = new SqlConnection(StringSQL);
        private EnumMode m_eMode;
        static int idClient;
        private void RemplirComboClient()
        {
            clients.Clear();
            cmbcontact.Items.Clear();
            EnumClients();
            try
            {
                foreach (ListItem p in clients)
                {
                    cmbClient.Items.Add(p);
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "RemplirComboClient", ex);
            }
        }
        private void AfficherClient()
        {
            try
            {
                ADODB.Recordset rstClient = new ADODB.Recordset();
                rstClient.Open($"SELECT *, [DBO].[CONTACT].NOMCONTACT,  [DBO].[CONTACT].TELEPHONNE, [DBO].[CONTACT].FAX, [DBO].[CONTACT].CELLULAIRE, " +
                    $"[DBO].[CONTACT].PAGETTE,[DBO].[CONTACT].[E - MAIL], [DBO].[CONTACT].NOPOSTE, [DBO].[CONTACT].TELDOMICILE, [DBO].[CONTACT].TITRE FROM [DBO].[CLIENT]" +
                    $"JOIN [DBO].[CONTACTCLIENT] ON[DBO].[CLIENT].IDCLIENT =[DBO].[CONTACTCLIENT].NOCLIENT " +
                    $"JOIN [DBO].[CONTACT] ON[DBO].[CONTACTCLIENT].NOCONTACT =[DBO].[CONTACT].IDCONTACT " +
                    $"WHERE NOMCLIENT = '{cmbClient.Items[cmbClient.SelectedIndex].ToString()}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViderBarrerChamps(true, true);
                m_iIDClient = (int)rstClient.Fields[0].Value;
                txtTelephone.Text = (string)(rstClient.Fields["Telephonne"].Value);
                txtFax.Text = (string)(rstClient.Fields["Fax"].Value);
                txtContactGRB.Text = (string)(rstClient.Fields["ContactGRB"].Value);
                txtEmail.Text = (string)(rstClient.Fields["Email"].Value);
                txtAdresse.Text = (string)(rstClient.Fields["AdresseLiv"].Value);
                txtVille.Text = (string)(rstClient.Fields["VilleLiv"].Value);
                txtProvEtat.Text = (string)(rstClient.Fields["Prov/EtatLiv"].Value);
                txtPays.Text = (string)(rstClient.Fields["PaysLiv"].Value);
                txtCP.Text = (string)(rstClient.Fields["CodePostalLiv"].Value);
                txtCommentaire.Text = (string)(rstClient.Fields["Commentaire"].Value);
                txtSiteWeb.Text = (string)(rstClient.Fields["SiteWeb"].Value);
                lblDateCreation.Text = (string)(rstClient.Fields["DateCréation"].Value);
                lblUserCreation.Text = (string)(Operators.ConcatenateObject("Par : ", rstClient.Fields["UserCréation"].Value));
                lblDateModification.Text = (string)(rstClient.Fields["DateModification"].Value);
                lblUserModification.Text = (string)(Operators.ConcatenateObject("Par : ", rstClient.Fields["UserModification"].Value));
                chkClientPotentiel.Checked = (bool)rstClient.Fields["Potentiel"].Value;
                m_bCategorieBeton = (bool)(rstClient.Fields["Béton"].Value);
                m_bCategoriePave = (bool)(rstClient.Fields["Pavé"].Value);
                m_bCategoriePharmaceutique = (bool)(rstClient.Fields["Pharmaceutique"].Value);
                m_bCategorieAgroalimentaire = (bool)(rstClient.Fields["Agroalimentaire"].Value);
                m_bCategorieMeuble = (bool)(rstClient.Fields["Meuble"].Value);
                m_bCategorieMeunerie = (bool)(rstClient.Fields["Meunerie"].Value);
                m_bCategorieManufacturier = (bool)(rstClient.Fields["Manufacturier"].Value);
                m_bCategorieConsultant = (bool)(rstClient.Fields["Consultant"].Value);
                m_bCategorieAsphalte = (bool)(rstClient.Fields["Asphalte"].Value);
                m_bCategorieICPI = (bool)(rstClient.Fields["ICPI"].Value);
                m_bCategorieProduitsChimiques = (bool)(rstClient.Fields["ProduitsChimiques"].Value);
                m_bCategorieAutre = (bool)(rstClient.Fields["Autre"].Value);
                AfficherCategories();
                rstClient.Close();
                rstClient = null;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "AfficherClient", ex);
            }
        }
        private void AfficherCategories()
        {
            try
            {
                txtCategorie.Text = "";
                if (m_bCategorieBeton == true)
                {
                    txtCategorie.Text = "Béton";
                }
                if (m_bCategoriePave == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Pavé";
                    }
                    else
                    {
                        txtCategorie.Text = "Pavé";
                    }
                }
                if (m_bCategoriePharmaceutique == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Pharmaceutique";
                    }
                    else
                    {
                        txtCategorie.Text = "Pharmaceutique";
                    }
                }
                if (m_bCategorieAgroalimentaire == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Agroalimentaire";
                    }
                    else
                    {
                        txtCategorie.Text = "Agroalimentaire";
                    }
                }
                if (m_bCategorieMeuble == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Meuble";
                    }
                    else
                    {
                        txtCategorie.Text = "Meuble";
                    }
                }
                if (m_bCategorieMeunerie == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Meunerie";
                    }
                    else
                    {
                        txtCategorie.Text = "Meunerie";
                    }
                }
                if (m_bCategorieManufacturier == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Manufacturier";
                    }
                    else
                    {
                        txtCategorie.Text = "Manufacturier";
                    }
                }
                if (m_bCategorieConsultant == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Consultant";
                    }
                    else
                    {
                        txtCategorie.Text = "Consultant";
                    }
                }
                if (m_bCategorieAsphalte == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Asphalte";
                    }
                    else
                    {
                        txtCategorie.Text = "Asphalte";
                    }
                }
                if (m_bCategorieICPI == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; ICPI";
                    }
                    else
                    {
                        txtCategorie.Text = "ICPI";
                    }
                }
                if (m_bCategorieProduitsChimiques == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Produits chimiques";
                    }
                    else
                    {
                        txtCategorie.Text = "Produits chimiques";
                    }
                }
                if (m_bCategorieAutre == true)
                {
                    if (!string.IsNullOrEmpty(txtCategorie.Text.Trim()))
                    {
                        txtCategorie.Text += "; Autre";
                    }
                    else
                    {
                        txtCategorie.Text = "Autre";
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "AfficherCategorie", ex);
            }
        }
        /// <summary>
        /// Patch bug affichage multi contacts du client
        // PWE 2024-09-01
        class AfficherDetailsContact
        {
            public string txtContactTitre;
            public string txtcontact_cell;
            public string txtcontact_page;
            public string txtcontact_tel;
            public string txtcontact_fax;
            public string txtcontact_email;
            public string txtcontact_poste;
            public string txtcontact_dom;
            public AfficherDetailsContact(){}
            public AfficherDetailsContact(string txtContactTitre, string txtcontact_cell, string txtcontact_page, string txtcontact_tel,
                string txtcontact_fax, string txtcontact_email, string txtcontact_poste, string txtcontact_dom)
            {
                txtContactTitre = txtContactTitre;
                txtcontact_cell = txtcontact_cell;
                txtcontact_page = txtcontact_page;
                txtcontact_tel = txtcontact_tel;
                txtcontact_fax = txtcontact_fax;
                txtcontact_email = txtcontact_email;
                txtcontact_poste = txtcontact_poste;
                txtcontact_dom = txtcontact_dom;
            }
        }
        internal void GetContactDetails()
        {
            lstContact.Clear();
            idClient= IdClient;
            ADODB.Recordset rd = new ADODB.Recordset();
            rd.Open($"select distinct IDContact,Compagnie ,NomContact, Telephonne, Fax, Cellulaire, Pagette, [E-mail], noposte, teldomicile,Titre FROM [DBO].[contact] " +
                $"JOIN [DBO].[ContactClient] on[DBO].[ContactClient].nocontact =[DBO].[contact].IDContact " +
                $"where[DBO].[ContactClient].[noclient] = '{IdClient}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                lstContact.Add(new AfficherDetailsContact($"{rd.Fields["Titre"].Value}",$"{rd.Fields["cellulaire"].Value}",
                    $"{rd.Fields["pagette"].Value}",$"{rd.Fields["telephonne"].Value}", $"{rd.Fields["Fax"].Value}",$"{rd.Fields["e-mail"].Value}",
                    $"{rd.Fields["noposte"].Value}",$"{rd.Fields["teldomicile"].Value}"));
                rd.MoveNext();
            }
            Conteneur.txtStatus.Text=$"Il y a {lstContact.Count} entrées dans l  table pour {cmbClient.Text} affichachage pour {cmbcontact.Text}";
        }
        /// </summary>
        List<AfficherDetailsContact> lstContact = new List<AfficherDetailsContact>();

        public void AfficherContact()
        {
            cmbcontact.Items.Clear();
            
            try
            {
                ADODB.Recordset rstContact = new ADODB.Recordset();
                rstContact.Open($"SELECT * FROM CONTACT WHERE [NOMCONTACT] ='{cmbcontact.Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
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
                else
                {
                    ViderBarrerChampsContact(true, true);
                }
                if (!rstContact.EOF)
                {
                    txtContactTitre.Text = $"{rstContact.Fields["Titre"].Value}";
                    txtcontact_cell.Text = $"{rstContact.Fields["cellulaire"].Value}";
                    txtcontact_page.Text = $"{rstContact.Fields["pagette"].Value}";
                    txtcontact_tel.Text = $"{rstContact.Fields["telephonne"].Value}";
                    txtcontact_fax.Text = $"{rstContact.Fields["Fax"].Value}";
                    txtcontact_email.Text = $"{rstContact.Fields["e-mail"].Value}";
                    txtcontact_poste.Text = $"{rstContact.Fields["noposte"].Value}";
                    txtcontact_dom.Text = $"{rstContact.Fields["teldomicile"].Value}";
                }
                rstContact.Close();
                rstContact = null;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "AfficherContact", ex);
            }
        }
        [Obsolete]
        private void cmbContact_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            m_iNoContact = int.Parse(cmbcontact.Text.Split('-')[0]);
            try
            {
                if (cmbcontact.SelectedIndex != -1)
                {
                    GetContactDetails();
                }
                AfficherContact();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "cmbContact_Click", ex);
            }
        }
        private void cmdanulcontact_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                AfficherControles(EnumMode.MODE_INACTIF);
                if (m_bNewContact == true)
                {
                    HideEdMaskContact(true);
                    m_bNewContact = false;
                }
                m_bModeAjoutContact = false;
                txtNomClient.Visible = false;
                txtNomClient.ReadOnly = false;
                RemplirComboContact();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "cmdanulcontact_Click", ex);
            }
        }
        private void cmdCategorie_Click(object eventSender, EventArgs eventArgs)
        {
            string oldNameClient = cmbClient.Text;
            txtNomClient.Text = oldNameClient;
            try
            {
                Form form = new CategorieClient(m_iNoClient, cmbClient.Text);
                form.MdiParent = Conteneur.ActiveForm.MdiParent;
                form.Text = "Catégories pour " + cmbClient.Text;
                txtNomClient.Text = oldNameClient;
                form.Show();
                cmdRafraichir_Click(eventSender, eventArgs);
                cmbClient.Text = oldNameClient;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "cmdCategorie_Click", ex);
            }
        }
        [Obsolete]
        private void cmdFax_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {

    return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "cmdFax_Click", ex);
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
                string sMsgPlein;
                int iNbreRendu;
                if (cmbcontact.SelectedIndex != -1)
                {
                    bArrayVide = true;
                    iResult = (int)MessageBox.Show("Voulez-vous ajouter tous les contacts à la liste de distribution?\n\nOui - Tous les contacts\n\nNon - Contact affiché seulement", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iResult == 0x06)
                    {
                        rstContact = new Recordset();
                        rstContact.Open("SELECT * FROM ContactClient INNER JOIN Contact ON ContactClient.NoContact = Contact.IDContact WHERE ContactClient.NoClient = " + GetClientID(cmbClient.Items[cmbClient.SelectedIndex].ToString()) + " ORDER BY NomContact", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockOptimistic);
                        X = 0;
                        while (!rstContact.EOF)
                        {
                            if (!(rstContact.Fields["E-mail"].Value is DBNull))
                            {
                                if (!string.IsNullOrEmpty((string)(rstContact.Fields["E-mail"].Value).Trim()))
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
                        if (!string.IsNullOrEmpty(txtcontact_email.Text.Trim()))
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
                        MessageBox.Show("Le ou les contacts n'ont pas d'email!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                           return;
                 }
                }
                else
                {
                    MessageBox.Show("Aucun contact sélectionné!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                if (Information.Err().Number == 287 & Information.Erl() == 305)
                {
                    MessageBox.Show("La liste de distribution est pleine!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AfficherErreur("Client", "cmdMailListContact_Click", ex);
                }
            }
        }
        [Obsolete]
        private void cmdMailListClient_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.MAPIFolder folClient;
                Microsoft.Office.Interop.Outlook.ContactItem itmClient;
                Microsoft.Office.Interop.Outlook.Recipient otlRecipient;
                var bDejaOuvert = default(bool);
                if (cmbClient.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
                    {
                        otlApp = OuvrirOutlook(ref bDejaOuvert);
                        Form f = new ChoixMailList(otlApp);
                        f.MdiParent = Conteneur.ActiveForm.MdiParent;
                        f.Show();
                        if (m_bAnnulerDistList == false)
                        {
                            if (m_otlDistList.MemberCount < 10)
                            {
                                folClient = GetFolder(otlApp, "Clients GRB");
                                itmClient = (Microsoft.Office.Interop.Outlook.ContactItem)folClient.Items.Find("[User1] = " + cmbClient.Items[cmbClient.SelectedIndex]);
                                if (!(itmClient is null))
                                {
                                    otlRecipient = otlApp.Session.CreateRecipient(itmClient.Email1DisplayName);
                                    if (otlRecipient.Resolve() == true)
                                    {
                                        m_otlDistList.AddMember(otlRecipient);
                                        m_otlDistList.Save();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Impossible de trouver le client!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Client introuvable!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    }
                    else
                    {
                        MessageBox.Show("Ce client n'a pas d'email!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aucun client sélectionné!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    AfficherErreur("Client", "cmdMailListClient_Click", ex);
                }
            }
        }
        [Obsolete]
        private void cmdreport_Click(object eventSender, EventArgs eventArgs)
        {
            ADODB.Recordset rstClient = new ADODB.Recordset();
            ControleurServeur.ViewListeClient.DataSource = rstClient;
            try
            {
                var sWhere = default(string);
                ImpressionClient f = new ImpressionClient();
                f.ShowInTaskbar = false;
                f.ShowDialog();
                if (m_bImpressionAnnuler == false)
                {
                    if (m_bImpressionVille == true)
                    {
                        Form e = new ChoixVille();
                        f.MdiParent = Conteneur.Mdi;
                        f.Show();
                        if (m_bAnnulerVille == false)
                        {
                            if (m_sVille == "") { m_sVille = "Granby"; }
                            rstClient.Open("SELECT * FROM Client WHERE VilleLiv like '%" + m_sVille.Replace("'", "''") + "%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        }
                        else
                        {
                            rstClient = null;
                            return;
                        }
                    }
                    else if (m_bImpressionCategorie == true)
                    {
                        Form a = new CategorieClient();
                        a.MdiParent = Conteneur.ActiveForm.MdiParent;
                        a.Show();
                        if (m_bImpressionBeton == true) { sWhere = "Béton=1"; }
                        if (m_bImpressionPave == true) { if (sWhere.Length > 0) { sWhere += " OR Pavé=1"; } else { sWhere = "Pavé=1"; } }
                        if (m_bImpressionPharmaceutique == true) { if (sWhere.Length > 0) { sWhere += " OR Pharmaceutique=1"; } else { sWhere = "Pharmaceutique=1"; } }
                        if (m_bImpressionAgroAlimentaire == true) { if (sWhere.Length > 0) { sWhere += " OR Agroalimentaire=1"; } else { sWhere = "Agroalimentaire=1"; } }
                        if (m_bImpressionMeuble == true) { if (sWhere.Length > 0) { sWhere += " OR Meuble=1"; } else { sWhere = "Meuble=1"; } }
                        if (m_bImpressionMeunerie == true) { if (sWhere.Length > 0) { sWhere += " OR Meunerie=1"; } else { sWhere = "Meunerie=1"; } }
                        if (m_bImpressionManufacturier == true) { if (sWhere.Length > 0) { sWhere += " OR Manufacturier=1"; } else { sWhere = "Manufacturier=1"; } }
                        if (m_bImpressionConsultant == true) { if (sWhere.Length > 0) { sWhere += " OR Consultant=1"; } else { sWhere = "Consultant=1"; } }
                        if (m_bImpressionAsphalte == true) { if (sWhere.Length > 0) { sWhere += " OR Asphalte=1"; } else { sWhere = "Asphalte=1"; } }
                        if (m_bImpressionICPI == true) { if (sWhere.Length > 0) { sWhere += " OR ICPI=1"; } else { sWhere = "ICPI=1"; } }
                        if (m_bImpressionProduitsChimiques == true) { if (sWhere.Length > 0) { sWhere += " OR ProduitsChimiques=1"; } else { sWhere = "ProduitsChimiques=1"; } }
                        if (m_bImpressionAutre == true) { if (sWhere.Length > 0) { sWhere += " OR Autre=1"; } else { sWhere = "Autre=1"; } }
                        if (sWhere.Length > 0)
                        {
                            rstClient.Open("SELECT * FROM Client WHERE " + sWhere + " AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        }
                        else
                        {
                            rstClient.Open("SELECT * FROM Client WHERE Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        }
                    }
                    else if (m_bImpressionPotentiel == true)
                    {
                        rstClient.Open("SELECT * FROM Client WHERE Potentiel = 1 AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    }
                    else if (m_bImpressionFacturer == true)
                    {
                        rstClient.Open("SELECT * FROM Client WHERE Potentiel = 0 AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    }
                    else
                    {
                        rstClient.Open("SELECT * FROM Client WHERE Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
 /// <remarks>
 /// vais devoir revoir la structuration multi pages
 /// </remarks>
Cursor.Current = Cursors.WaitCursor;
                    ViewListeClient vc = new ViewListeClient();

                    vc.ShowDialog();
                    int rows = 0;
                    int Page = 1;
                    if (m_bAnnuleImpression == true)
                    {
                        /*                        while (!rstClient.EOF)
                                                {
                                                    ///Intégration des donnees au tableau
                                                    fs.Write($"<tr><td>{rstClient.Fields[1].Value}</td>" +
                                                        $"<td>{rstClient.Fields[3].Value}</td>" +
                                                        $"<td>{rstClient.Fields[8].Value}</td>" +
                                                        $"<td>{rstClient.Fields[9].Value}</td>" +
                                                        $"<td>{rstClient.Fields[36].Value}</td>" +
                                                        $"<td>{rstClient.Fields[4].Value}</td>" +
                                                        $"<td>{rstClient.Fields[15].Value}</td></tr>");
                                                    rows++;
                                                    if (rows % 26 == 0)
                                                    {
                                                        Page++;
                                                    }
                                                }*/
                    }
                    else
                    {
                        /*                        fs.Write($"<tr>" +
                                                    $"<td>{rstClient.Fields[1].Value}</td>" +
                                                    $"<td>{rstClient.Fields[3].Value}</td>" +
                                                    $"<td>{rstClient.Fields[8].Value}</td>" +
                                                    $"<td>{rstClient.Fields[9].Value}</td>" +
                                                    $"<td>{rstClient.Fields[36].Value}</td>" +
                                                    $"<td>{rstClient.Fields[15].Value}</td>" +
                                                    $"</tr></table>");
                                                rows = 1;*/
                    }
                    ///Finalisation de la vue
                    int nPages = Math.Abs(rows / 26) + 1;
                    rstClient.Close();
                    rstClient = null;
                    Cursor.Current = Cursors.Default;
                }
                //              if (m_bImpressionVille == true) { rp.Text = "Rapport Client/Ville"; }
                //               if (m_bImpressionCategorie == true) { rp.Text = "Rapport Client/CatégorieFournisseur"; }
                //               if (m_bImpressionPotentiel == true) { rp.Text = "Rapport Client potentiel"; }
                //               if (m_bImpressionVille == true) { rp.Text = "Rapport Client/Ville"; }
                if (m_bImpressionCategorie == false
                    & m_bImpressionAnnuler == false
                    & m_bImpressionVille == false
                    & m_bImpressionPotentiel == false
                    & m_bImpressionFacturer == false
                    & cmbClient.SelectedIndex > -1)
                {
                    /*                        $"<td>{rstClient.Fields[1].Value}</td>" +
                    $"<td>{rstClient.Fields[3].Value}</td>" +
                    $"<td>{rstClient.Fields[8].Value}</td>" +
                    $"<td>{rstClient.Fields[9].Value}</td>" +
                    $"<td>{rstClient.Fields[36].Value}</td>" +
                    $"<td>{rstClient.Fields[15].Value}</td>" +
                    $"</tr></table>");
                fs5.Close();
                    //            Form rp = new AfficherRapports(Environment.CurrentDirectory + "\\LISTCLIENT.html", true);
                    rp.Text = "Rapport Client sélectionné: " + cmbClient.SelectedItem.ToString();
                    rp.Width = 1024;
                    rp.Height = 805;
                    rp.Icon = Icon;
                    rp.MdiParent = Conteneur.ActiveForm.MdiParent;
                    rp.Show();*/
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "cmdreport_Click", ex);
            }
        }
        private void AfficherControles(EnumMode eMode)
        {
            try
            {
                var bCmbClient = default(bool);
                var bTxtNomClient = default(bool);
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
                var bCmdRechercher = default(bool);
                var bFax = default(bool);
                var bMailListClient = default(bool);
                var bMailListContact = default(bool);
                var bCategorie = default(bool);
                m_eMode = eMode;
                switch (eMode)
                {
                    case EnumMode.MODE_CLIENT:
                        {
                            bTxtNomClient = true;
                            bCmdEnr = true;
                            bCmdAnul = true;
                            bCategorie = true; break;
                        }
                    case EnumMode.MODE_CONTACT:
                        {
                            bFraContact = true;
                            bTxtNomClient = true;
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
                            bCmbClient = true;
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
                            bMailListClient = true;
                            bMailListContact = true;
                            if (Strings.Len(TxtRechercher.Text) > 0)
                            {
                                bCmdRechercher = true;
                            }
                            break;
                        }
                }
                cmbClient.Visible = bCmbClient;
                txtNomClient.Visible = bTxtNomClient;
                fraContact.Visible = bFraContact;
                TxtRechercher.Enabled = bTxtRechercher;
                cmdRechercher.Enabled = bCmdRechercher;
                cmdRafraichir.Enabled = bCmdRafraichir;
                cmdRenommer.Enabled = bCmdRenommer;
                cmdreport.Visible = bCmdImprimer;
                CmdAdd.Visible = bCmdAdd;
                CmdSupp.Visible = bCmdSupp;
                CmdModif.Visible = bCmdModif;
                CmdQuit.Visible = bCmdQuit;
                CmdAnul.Visible = bCmdAnul;
                CmdEnr.Visible = bCmdEnr;
                CmdAddCont.Visible = bCmdAddCont;
                cmdsupcontact.Visible = bCmdSupContact;
                cmdanulcontact.Visible = bCmdAnulContact;
                CmdRefCont.Visible = bCmdRefCont;
                txtContact.Visible = bTxtContact;
                cmbcontact.Visible = bCmbContact;
                cmdMailListClient.Visible = bMailListClient;
                cmdMailListContact.Visible = bMailListContact;
                cmdCategorie.Visible = bCategorie;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "AfficherControles", ex);
            }
        }
        private void CmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                AfficherControles(EnumMode.MODE_CLIENT);
                string sName = Interaction.InputBox("Veuillez entrer le nom du client\n\nSVP, respectez le bon orthographe!", "SAISIE DU NOM", "Nom du client");
                if (!string.IsNullOrEmpty(sName))
                {
                    if (!ComboContient(cmbClient, sName))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        m_bModeAjoutClient = true;
                        HideEdMask(false);
                        txtNomClient.Text = sName;
                        ViderBarrerChamps(false, true);
                        mskTelephone.Focus();
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Le client " + sName + " existe déja", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AfficherControles(EnumMode.MODE_INACTIF);
                    }
                }
                else
                {
                    AfficherControles(EnumMode.MODE_INACTIF);
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "CmdAdd_Click", ex);
            }
        }
        private void ViderBarrerChamps(bool bLocked, bool bVider)
        {
            try
            {
                if (bVider == true)
                {
                    txtTelephone.Text = string.Empty;
                    mskTelephone.Text = string.Empty;
                    txtFax.Text = string.Empty;
                    mskFax.Text = string.Empty;
                    txtContactGRB.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtAdresse.Text = string.Empty;
                    txtVille.Text = string.Empty;
                    txtProvEtat.Text = string.Empty;
                    txtPays.Text = string.Empty;
                    txtCP.Text = string.Empty;
                    txtCommentaire.Text = string.Empty;
                    txtSiteWeb.Text = string.Empty;
                    lblDateCreation.Text = string.Empty;
                    lblUserCreation.Text = string.Empty;
                    lblDateModification.Text = string.Empty;
                    lblUserModification.Text = string.Empty;
                    txtCategorie.Text = string.Empty;
                    chkClientPotentiel.Checked = false;
                    m_bCategorieBeton = false;
                    m_bCategoriePave = false;
                    m_bCategoriePharmaceutique = false;
                    m_bCategorieAgroalimentaire = false;
                    m_bCategorieMeuble = false;
                    m_bCategorieMeunerie = false;
                    m_bCategorieManufacturier = false;
                    m_bCategorieConsultant = false;
                    m_bCategorieAsphalte = false;
                    m_bCategorieICPI = false;
                    m_bCategorieProduitsChimiques = false;
                    m_bCategorieAutre = false;
                }
                txtTelephone.ReadOnly = bLocked;
                txtFax.ReadOnly = bLocked;
                txtContactGRB.ReadOnly = bLocked;
                txtEmail.ReadOnly = bLocked;
                txtAdresse.ReadOnly = bLocked;
                txtVille.ReadOnly = bLocked;
                txtProvEtat.ReadOnly = bLocked;
                txtPays.ReadOnly = bLocked;
                txtCP.ReadOnly = bLocked;
                txtCommentaire.ReadOnly = bLocked;
                txtSiteWeb.ReadOnly = bLocked;
                fraPotentiel.Enabled = !bLocked;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "ViderBarrerChamps", ex);
            }
        }
        private void ViderBarrerChampsContact(bool bLocked, bool bVider)
        {
            try
            {
                if (bVider == true)
                {
                    txtContactTitre.Text = string.Empty;
                    txtcontact_cell.Text = string.Empty;
                    txtcontact_dom.Text = string.Empty;
                    txtcontact_email.Text = string.Empty;
                    txtcontact_fax.Text = string.Empty;
                    txtcontact_page.Text = string.Empty;
                    txtcontact_poste.Text = string.Empty;
                    txtcontact_tel.Text = string.Empty;
                }
                txtContactTitre.ReadOnly = bLocked;
                txtcontact_cell.ReadOnly = bLocked;
                txtcontact_dom.ReadOnly = bLocked;
                txtcontact_email.ReadOnly = bLocked;
                txtcontact_fax.ReadOnly = bLocked;
                txtcontact_page.ReadOnly = bLocked;
                txtcontact_poste.ReadOnly = bLocked;
                txtcontact_tel.ReadOnly = bLocked;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "ViderBarrerChampsContact", ex);
            }
        }
        private void CmdAddCont_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                bool bAjouter;
                if (cmbClient.Items.Count > 0)
                {
                    m_bModeAjoutContact = true;
                    if (MessageBox.Show("Voulez-vous ajouter un nouveau contact?\n\nOui - Nouveau contact\n\nNon - Sélection dans la liste existant", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        m_bNewContact = true;
                        string sNom = Interaction.InputBox("Quel est le nom du nouveau contact?\n\nSVP, respectez le bon orthographe!");
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
                            HideEdMaskContact(false);
                            mskContactTel.Focus();
                            txtNomClient.Visible = true;
                            txtNomClient.ReadOnly = true;
                            AfficherControles(EnumMode.MODE_CONTACT);
                            txtContactTitre.Focus();
                        }
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        m_bNewContact = false;
                        txtNomClient.Visible = true;
                        txtNomClient.ReadOnly = true;
                        AfficherControles(EnumMode.MODE_CONTACT);
                        RemplirComboContact();
                    }
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement de sélectionné");
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "CmdAddCont_Click", ex);
            }
        }
        private void CmdAnul_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                HideEdMask(true);
                txtCommentaire.ReadOnly = true;
                m_bModeAjoutClient = false;
                AfficherControles(EnumMode.MODE_INACTIF);
                ViderBarrerChamps(true, true);
                cmbclient_SelectedIndexChanged(cmbClient, new EventArgs());
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "CmdAnul_Click", ex);
            }
        }
        [Obsolete]
        private void CmdEnr_Click(object eventSender, EventArgs eventArgs)
        {
                 
            int X;
                string sClient = txtNomClient.Text;
                Cursor.Current = Cursors.WaitCursor;
                EnregistrerClient();
                ViderBarrerChamps(true, true);
                HideEdMask(true);
                RemplirComboClient();
                AfficherControles(EnumMode.MODE_INACTIF);
             try
            {
            for (X = 0; X <= (int)(cmbClient.Items.Count - 1); X++)
                {
                    if ((cmbClient.Items[X].ToString() ?? "") == (sClient ?? ""))
                    {
                        cmbClient.SelectedIndex = X;
                        break;
                    }
                }
                cmbClient.Focus();
                Cursor.Current = Cursors.Default;
                SqlConnection sql = new SqlConnection(StringSQL);
                sql.Open();
                clients.Clear();
                SqlDataReader rd = new SqlCommand($"SELECT [IDCLIENT],[NOMCLIENT]FROM [DBO].[CLIENT] WHERE SUPPRIMÉ= 0   order by nomclient", sql).ExecuteReader();
                while (rd.Read())
                {
                    cmbClient.Items.Add(new ListItem(rd[1].ToString().ToUpper(), rd[0].ToString()));
                }
                sql.Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "CmdEnr_Click", ex);
            }
        }
        private void EnregistrerClient()
        {
            try
            {
                ADODB.Recordset rstClient = new ADODB.Recordset();
                if (m_bModeAjoutClient == true)
                {
                    rstClient.Open("SELECT * FROM Client", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstClient.AddNew();
                    rstClient.Fields["DateCréation"].Value = ConvertDate(DateTime.Today);
                    rstClient.Fields["UserCréation"].Value = Conteneur.idInitiales.Text;
                }
                else
                {
                    rstClient.Open("SELECT * FROM Client WHERE IDClient = " + m_iNoClient, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstClient.Fields["DateModification"].Value = ConvertDate(DateTime.Today);
                    rstClient.Fields["UserModification"].Value = Conteneur.idInitiales.Text;
                }
                rstClient.Fields["NomClient"].Value = txtNomClient.Text;
                rstClient.Fields["Telephonne"].Value = mskTelephone.Text;
                rstClient.Fields["Fax"].Value = mskFax.Text;
                rstClient.Fields["ContactGRB"].Value = txtContactGRB.Text;
                rstClient.Fields["Email"].Value = txtEmail.Text;
                rstClient.Fields["AdresseLiv"].Value = txtAdresse.Text;
                rstClient.Fields["VilleLiv"].Value = txtVille.Text;
                rstClient.Fields["Prov/EtatLiv"].Value = txtProvEtat.Text;
                rstClient.Fields["PaysLiv"].Value = txtPays.Text;
                rstClient.Fields["Commentaire"].Value = txtCommentaire.Text;
                rstClient.Fields["CodePostalLiv"].Value = txtCP.Text;
                rstClient.Fields["SiteWeb"].Value = txtSiteWeb.Text;
                rstClient.Fields["Potentiel"].Value = chkClientPotentiel.Checked;
                rstClient.Fields["Béton"].Value = m_bCategorieBeton;
                rstClient.Fields["Pavé"].Value = m_bCategoriePave;
                rstClient.Fields["Pharmaceutique"].Value = m_bCategoriePharmaceutique;
                rstClient.Fields["Agroalimentaire"].Value = m_bCategorieAgroalimentaire;
                rstClient.Fields["Meuble"].Value = m_bCategorieMeuble;
                rstClient.Fields["Meunerie"].Value = m_bCategorieMeunerie;
                rstClient.Fields["Manufacturier"].Value = m_bCategorieManufacturier;
                rstClient.Fields["Consultant"].Value = m_bCategorieConsultant;
                rstClient.Fields["Asphalte"].Value = m_bCategorieAsphalte;
                rstClient.Fields["ICPI"].Value = m_bCategorieICPI;
                rstClient.Fields["ProduitsChimiques"].Value = m_bCategorieProduitsChimiques;
                rstClient.Fields["Autre"].Value = m_bCategorieAutre;
                rstClient.Fields["Supprimé"].Value = false;
                if (m_bModeAjoutClient == true) { m_bModeAjoutClient = false; }
                rstClient.Update();
                rstClient.Close();
                rstClient = null;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "EnregistrerClient", ex);
            }
        }
        private void ModifierNomClientExchange(string sName, int iClientID)
        {
        }
/// pas lancer de requete MSQN a outlook si off        
private void LierContactClient(int iClientID)
        {

        }
        private string ModifierClientExchange(int iClientID)
        {
            string ModifierClientExchangeRet = default;
            return iClientID.ToString();

        }
        private string AjouterContactExchange(int iContactID)
        {
            string AjouterContactExchangeRet = default;
            return iContactID.ToString();
  
        }
        private void SupprimerClientExchange(int iClientID)
        {
        }
        private void CmdModif_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbClient.Items.Count > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    HideEdMask(false);
                    AfficherControles(EnumMode.MODE_CLIENT);
                    ViderBarrerChamps(false, false);
                    txtNomClient.Visible = true;
                    txtNomClient.ReadOnly = true;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement de sélectionné!");
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "CmdModif_Click", ex);
            }
        }
        private void cmdquit_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "cmdquit_Click", ex);
            }
        }
        private void CmdRefCont_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstContactClient;
                ADODB.Recordset rstContact;
                Cursor.Current = Cursors.WaitCursor; rstContactClient = new Recordset();
                if (m_bNewContact == true)
                {
                    rstContact = new Recordset(); 
                    rstContact.Open("SELECT * FROM Contact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); rstContact.AddNew(); rstContact.Fields["NomContact"].Value = txtContact.Text;
                    rstContact.Fields["Titre"].Value = txtContactTitre.Text;
                    rstContact.Fields["Compagnie"].Value = txtNomClient.Text;
                    rstContact.Fields["Telephonne"].Value = mskContactTel.Text;
                    rstContact.Fields["Fax"].Value = mskContactFax.Text;
                    rstContact.Fields["Pagette"].Value = mskContactPage.Text;
                    rstContact.Fields["Cellulaire"].Value = mskContactCell.Text;
                    rstContact.Fields["E-mail"].Value = txtcontact_email.Text;
                    rstContact.Fields["NoPoste"].Value = txtcontact_poste.Text;
                    rstContact.Fields["TelDomicile"].Value = mskContactDom.Text;
                    rstContact.Fields["UserCréation"].Value = Conteneur.idInitiales.Text;
                    rstContact.Fields["DateCréation"].Value = DateTime.Today.ToShortDateString();
                    rstContact.Fields["EntryIDOutlook"].Value =string.Empty; 
                    rstContact.Update();    
                    rstContactClient.Open("SELECT * FROM ContactClient WHERE NoClient = " + m_iNoClient + " And NoContact = "+ rstContact.Fields["IDContact"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);    // Si pas déjà existant, on ajoute dans la table
                    Clipboard.SetText("SELECT * FROM ContactClient WHERE NoClient = " + m_iNoClient + " And NoContact = " + rstContact.Fields["IDContact"].Value);
                    if (rstContactClient.EOF)
                    {
                        rstContactClient.AddNew();
                        rstContactClient.Fields["NoClient"].Value = m_iNoClient;
                        rstContactClient.Fields["NoContact"].Value = rstContact.Fields["IDContact"].Value;
                    MessageBox.Show($"{m_iNoClient}\n{rstContact.Fields["IDContact"].Value}",Name);
                        rstContactClient.Update();
                    }
                    rstContact.Close();
                    rstContact = null;
                    m_bNewContact = false;
                    HideEdMaskContact(true);
                }
                else
                {
                    rstContactClient.Open("SELECT * FROM ContactClient WHERE NoClient = " + m_iNoClient + " AND NoContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);    // Si pas déjà existant, on ajoute dans la table
                    if (rstContactClient.EOF)
                    {
                        rstContactClient.AddNew();
                        rstContactClient.Fields["NoClient"].Value = m_iNoClient;
                        rstContactClient.Fields["NoContact"].Value = m_iNoContact;
                        rstContactClient.Update();
                    }
                    rstContactClient.Close();
                }
                LierContactClient(m_iNoClient);
                rstContactClient = null;
                AfficherControles(EnumMode.MODE_INACTIF);
                m_bModeAjoutContact = false;
                RemplirComboContact();
                ViderBarrerChampsContact(true, false);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "CmdRefCont_Click", ex);
            }
        }
        private void cmdRenommer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstClient;
                string sName; if (cmbClient.Items.Count > 0)
                {
                    sName = Interaction.InputBox("Veuillez entrer le nom du client", "Renommer client", txtNomClient.Text);
                    if (!string.IsNullOrEmpty(sName))
                    {
                        if ((sName ?? "") != (txtNomClient.Text ?? ""))
                        {
                            rstClient = new Recordset(); rstClient.Open("SELECT * FROM Client WHERE NomClient = '" + sName.Replace("'", "''") + "' AND Supprimé = 0", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (rstClient.EOF)
                            {
                                Cursor.Current = Cursors.WaitCursor; rstClient.Close(); rstClient.Open("SELECT NomClient, IDClient, EntryIDOutlook FROM Client WHERE IDClient = " + m_iNoClient, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); ModifierNomClientExchange(sName, m_iNoClient); txtNomClient.Text = sName;
                                rstClient.Fields["NomClient"].Value = txtNomClient.Text;
                                rstClient.Update(); rstClient.Close();
                                RemplirComboClient();
                                cmbClient.Text = sName;
                                m_bRenommer = true;
                                cmbclient_SelectedIndexChanged(cmbClient, new EventArgs());
                                m_bRenommer = false;
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Le client " + sName + " existe déjà!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop); rstClient.Close();
                            }
                            rstClient = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement de sélectionné!");
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "cmdRenommer_Click", ex);
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
                        UpdateSQL("DELETE FROM ContactClient WHERE NoClient = " + m_iNoClient + " AND NoContact = " + m_iNoContact); 
                        RemplirComboContact();
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "cmdsupcontact_Click", ex);
            }
        }
        private void CmdSupp_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjSoum = new ADODB.Recordset();
                bool bPeutEffacer;
                if (cmbClient.Items.Count > 0)
                {
                    if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        rstProjSoum.Open("SELECT * FROM SoumissionMec WHERE IDClient = " + m_iNoClient, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstProjSoum.EOF)
                        {
                            rstProjSoum.Close();
                            rstProjSoum.Open("SELECT * FROM ProjetMec WHERE IDClient = " + m_iNoClient, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (rstProjSoum.EOF)
                            {
                                rstProjSoum.Close(); rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDClient = " + m_iNoClient, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (rstProjSoum.EOF)
                                {
                                    rstProjSoum.Close(); rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDClient = " + m_iNoClient, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (rstProjSoum.EOF)
                                    {
                                        bPeutEffacer = true; rstProjSoum.Close(); rstProjSoum = null;
                                    }
                                    else
                                    {
                                        bPeutEffacer = false; rstProjSoum.Close(); rstProjSoum = null;
                                    }
                                }
                                else
                                {
                                    bPeutEffacer = false; rstProjSoum.Close(); rstProjSoum = null;
                                }
                            }
                            else
                            {
                                bPeutEffacer = false; rstProjSoum.Close(); rstProjSoum = null;
                            }
                        }
                        else
                        {
                            bPeutEffacer = false; rstProjSoum.Close(); rstProjSoum = null;
                        }
                        if (cmbcontact.Items.Count > 0)
                        {
                            UpdateSQL("DELETE FROM ContactClient WHERE NoClient = " + m_iNoClient);
                        }
                        SupprimerClientExchange(m_iNoClient);
                        if (bPeutEffacer == true)
                        {
                            UpdateSQL("DELETE FROM Client WHERE IDClient = " + m_iNoClient);
                        }
                        else
                        {
                            ADODB.Recordset rstClient = new ADODB.Recordset(); rstClient.Open("SELECT * FROM Client WHERE IDClient = " + m_iNoClient, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); rstClient.Fields["Supprimé"].Value = true; rstClient.Update(); rstClient.Close();
                            rstClient = null;
                        }
                        RemplirComboClient();
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement de sélectionné!");
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "CmdSupp_Click", ex);
            }
        }
        [Obsolete]
        internal void ListerContactClient()
        {
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            cmbcontact.Items.Clear();
            txtContactTitre.Text = string.Empty;
            txtcontact_cell.Text = string.Empty;
            txtcontact_dom.Text = string.Empty;
            txtcontact_email.Text = string.Empty;
            txtcontact_fax.Text = string.Empty;
            txtcontact_page.Text = string.Empty;
            txtcontact_poste.Text = string.Empty;
            txtcontact_tel.Text = string.Empty;
            int idC = 0;
            SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[CONTACT] " +
                $"JOIN [DBO].[CONTACTCLIENT] ON[DBO].[CONTACT].IDCONTACT =[DBO].[CONTACTCLIENT].NOCONTACT " +
                $"JOIN [DBO].[CLIENT] ON[DBO].[CONTACTCLIENT].NOCLIENT =[DBO].[CLIENT].[IDCLIENT] " +
                $"WHERE NOMCLIENT =  '{clients[cmbClient.SelectedIndex].Text}'", con).ExecuteReader();
            while (reader.Read())
            {
                if (reader[1].ToString() != "") { cmbcontact.Items.Add(reader[1].ToString()); }
                txtContactTitre.Text = reader[15].ToString();
                txtcontact_cell.Text = reader[5].ToString();
                txtcontact_dom.Text = reader[9].ToString();
                txtcontact_email.Text = reader[7].ToString();
                txtcontact_fax.Text = reader[4].ToString();
                txtcontact_page.Text = reader[6].ToString();
                txtcontact_poste.Text = reader[8].ToString();
                txtcontact_tel.Text = reader[3].ToString();
                idC++;
   //             cmbcontact.SelectedIndex =cmbcontact.Items.Count-1 ; 
            }
            reader.Close();
            con.Close();
        }
        private void cmbclient_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            IdClient=int.Parse(clients[cmbClient.SelectedIndex].Value);
            m_iNoClient = idClient;
            try
            {
                txtCategorie.Items.Clear();
                cmbcontact.Items.Clear();
                txtContact.Text = string.Empty;
                if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
                SqlDataReader reader = new SqlCommand($"SELECT * FROM [DBO].[CLIENT] where IDClient='{IdClient}'", con).ExecuteReader();
                while (reader.Read())
                {
                    m_iNoClient = (int)reader[0];
                    txtNomClient.Text = reader[1].ToString();
                    txtContactGRB.Text = reader[7].ToString();
                    txtCategorie.Text = "";
                    txtTelephone.Text = reader[3].ToString();
                    txtFax.Text = reader[4].ToString();
                    txtEmail.Text = reader[8].ToString();
                    txtAdresse.Text = reader[9].ToString();
                    txtVille.Text = reader[10].ToString();
                    txtProvEtat.Text = reader[11].ToString();
                    txtPays.Text = reader[12].ToString();
                    txtCP.Text = reader[13].ToString();
                    txtCommentaire.Text = reader[15].ToString();
                    txtSiteWeb.Text = reader[16].ToString();
                    lblDateCreation.Text = reader[17].ToString();
                    lblUserCreation.Text = $"Par: {reader[18].ToString()}";
                    lblDateModification.Text = reader[19].ToString();
                    lblUserModification.Text = $"Par: {reader[20].ToString()}";
                    Text = $"Client: { txtNomClient.Text} ID:{IdClient}";  
                    if ((bool)reader[29] == true) { txtCategorie.Items.Add("Autre"); }
                    if ((bool)reader[22] == true) { txtCategorie.Items.Add("Béton"); }
                    if ((bool)reader[23] == true) { txtCategorie.Items.Add("Pave"); }
                    if ((bool)reader[24] == true) { txtCategorie.Items.Add("Pharmaceutique"); }
                    if ((bool)reader[25] == true) { txtCategorie.Items.Add("Agroalimentaire"); }
                    if ((bool)reader[26] == true) { txtCategorie.Items.Add("Meuble"); }
                    if ((bool)reader[27] == true) { txtCategorie.Items.Add("Meunerie"); }
                    if ((bool)reader[28] == true) { txtCategorie.Items.Add("Manufacturier"); }
                    if ((bool)reader[30] == true) { txtCategorie.Items.Add("Consultant"); }
                    if ((bool)reader[31] == true) { txtCategorie.Items.Add("Asphalte"); }
                    if ((bool)reader[32] == true) { txtCategorie.Items.Add("ICPI"); }
                    if ((bool)reader[34] == true) { txtCategorie.Items.Add("Produits chimiques"); }
                    chkClientPotentiel.Checked = (bool)reader[33];
                    cmbcontact.Items.Clear();
                    cmbcontact.Items.Add(reader[36].ToString());
                }
                reader.Close();
                con.Close();
                cmbcontact.Items.Clear();
                ListerContactClient();
                if (cmbcontact.Items.Count > 1) cmbcontact.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "cmbclient_Click", ex);
            }
        }
        private void Client_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                RemplirComboClient();
                AfficherControles(EnumMode.MODE_INACTIF);
                ActiverBoutonsGroupe();
                ///patch cmbCategorie.items.count =-1 
                ///update PWE 2024-07-18
                if (CatégorieFournisseur.Count > 0)
                {
                    for (int x = 0; x < CatégorieFournisseur.Count; x++)
                    {
                        txtCategorie.Items.Add(CatégorieFournisseur[x].Text);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "Form_Load", ex);
            }
        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
                CmdAdd.Enabled = g_bModificationClients;
                CmdAddCont.Enabled = g_bModificationClients;
                CmdModif.Enabled = g_bModificationClients;
                cmdRenommer.Enabled = g_bModificationClients;
                cmdsupcontact.Enabled = g_bModificationClients;
                CmdSupp.Enabled = g_bModificationClients;
                cmdMailListClient.Enabled = g_bModificationListeDistribution;
                cmdMailListContact.Enabled = g_bModificationListeDistribution;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "ActiverBoutonsGroupe", ex);
            }
        }
        private void HideEdMask(bool bVisible)
        {
            try
            {
                if (m_bModeAjoutClient == true)
                {
                    txtTelephone.Text = string.Empty;
                    txtFax.Text = string.Empty;
                }
                else
                {
                    mskTelephone.Text = txtTelephone.Text;
                    mskFax.Text = txtFax.Text;
                }
                mskTelephone.Visible = !bVisible;
                mskFax.Visible = !bVisible;
                txtTelephone.Visible = bVisible;
                txtFax.Visible = bVisible;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "HideEdMask", ex);
            }
        }
        private void HideEdMaskContact(bool bVisible)
        {
            try
            {
                if (m_bModeAjoutContact == true)
                {
                    txtcontact_tel.Text = string.Empty;
                    txtcontact_fax.Text = string.Empty;
                    txtcontact_page.Text = string.Empty;
                    txtcontact_cell.Text = string.Empty;
                    txtcontact_dom.Text = string.Empty;
                    mskContactTel.Text = string.Empty;
                    mskContactFax.Text = string.Empty;
                    mskContactPage.Text = string.Empty;
                    mskContactCell.Text = string.Empty;
                    mskContactDom.Text = string.Empty;
                }
                mskContactTel.Visible = !bVisible;
                txtcontact_tel.Visible = bVisible;
                mskContactFax.Visible = !bVisible;
                txtcontact_fax.Visible = bVisible;
                mskContactPage.Visible = !bVisible;
                txtcontact_page.Visible = bVisible;
                mskContactCell.Visible = !bVisible;
                txtcontact_cell.Visible = bVisible;
                mskContactDom.Visible = !bVisible;
                txtcontact_dom.Visible = bVisible;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "HideEdMaskContact", ex);
            }
        }
        private void Client_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            try
            {
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "Form_Unload", ex);
            }
        }
        private void mskTelephone_GotFocus()
        {
            try
            {
                mskTelephone.Mask = "(###) ###-####";
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "mskTelephone_GotFocus", ex);
            }
        }
        private void mskTelephone_LostFocus()
        {
            try
            {
                mskTelephone.Mask = string.Empty; if (mskTelephone.Text == "(___) ___-____") { mskTelephone.Text = string.Empty; }
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "mskTelephone_LostFocus", ex);
            }
        }
        private void mskFax_GotFocus()
        {
            try
            {
                mskFax.Mask = "(###) ###-####";
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "mskFax_GotFocus", ex);
            }
        }
        private void mskFax_LostFocus()
        {
            try
            {
                mskFax.Mask = string.Empty; if (mskFax.Text == "(___) ___-____") { mskFax.Text = string.Empty; }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "mskFax_LostFocus", ex);
            }
        }
        public void RemplirComboContact()
        {
            cmbcontact.Items.Clear();
            txtContact.Text = "";
            try
            {
                ADODB.Recordset rstContact = new ADODB.Recordset();
                if (m_bModeAjoutContact == true) { rstContact.Open("SELECT NomContact, IDContact FROM contact " +
                    "WHERE Supprimé = 0 ORDER BY NomContact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                else
                {
                    rstContact.Open("SELECT Contact.NomContact, Contact.IDContact FROM Contact " +
                        "INNER JOIN ContactClient ON Contact.IDContact = ContactClient.NoContact " +
                        "WHERE ContactClient.NoClient = " + m_iNoClient + " ORDER BY NomContact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstContact.EOF)
                {
                    cmbcontact.Items.Add($"{rstContact.Fields["IDContact"].Value}-{rstContact.Fields["NomContact"].Value}");
                    rstContact.MoveNext();
                }
                rstContact.Close();
                rstContact = null;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "RemplirComboContact", ex);
            }
            if (cmbcontact.Items.Count > 0) cmbcontact.SelectedIndex = 0;
        }
        private void cmdRechercher_Click(object eventSender, EventArgs eventArgs)
        {
            cmbcontact.Items.Clear();
            txtContactTitre.Text = string.Empty;
            txtcontact_cell.Text = string.Empty;
            txtcontact_email.Text = string.Empty;
            txtcontact_fax.Text = string.Empty;
            txtcontact_page.Text = string.Empty;
            txtcontact_poste.Text = string.Empty;
            txtcontact_tel.Text = string.Empty;
            txtcontact_dom.Text = string.Empty;
            ViderBarrerChamps(false, true);
            try
            {
                ADODB.Recordset rstClient = new ADODB.Recordset();
                Cursor.Current = Cursors.WaitCursor;
                string sSearch = TxtRechercher.Text;
                rstClient.Open("SELECT NomClient, IDClient FROM Client WHERE NomClient like '%" + sSearch.Replace("'", "''") + "%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbClient.Items.Clear();
                while (!rstClient.EOF)
                {
                    cmbClient.Items.Add(rstClient.Fields["NomClient"].Value);
                    cmbClient.Tag = rstClient.Fields["IDClient"].Value;
                    rstClient.MoveNext();
                }
                rstClient.Close();
                rstClient = null; Cursor.Current = Cursors.Default;
                if (cmbClient.Items.Count > 0) { cmbClient.SelectedIndex = 0; }
                else
                {
                }
            }
            catch (Exception ex) { AfficherErreur("Client", "cmdRechercher_Click", ex); }
        }
        private void cmdRafraichir_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                RemplirComboClient(); Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { AfficherErreur("Client", "cmdRafraichir_Click", ex); }
        }
        private void txtRechercher_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Strings.Len(TxtRechercher.Text) > 0) { cmdRechercher.Enabled = true; } else { cmdRechercher.Enabled = false; }
            }
            catch (Exception ex) { AfficherErreur("Client", "txtRechercher_Change", ex); }
        }
        private void mskContactTel_GotFocus()
        {
            try
            {
                mskContactTel.Mask = "(###) ###-####";
            }
            catch (Exception ex) { AfficherErreur("Client", "mskContactTel_GotFocus", ex); }
        }
        private void mskContactTel_LostFocus()
        {
            try
            {
                mskContactTel.Mask = string.Empty;
                if (mskContactTel.Text == "(___) ___-____") { mskContactTel.Text = string.Empty; }
            }
            catch (Exception ex) { AfficherErreur("Client", "mskContactTel_LostFocus", ex); }
        }
        private void mskContactFax_GotFocus()
        {
            try
            {
                mskContactFax.Mask = "(###) ###-####";
            }
            catch (Exception ex) { AfficherErreur("Client", "mskContactFax_GotFocus", ex); }
        }
        private void mskContactFax_LostFocus()
        {
            try
            {
                mskContactFax.Mask = string.Empty;
                if (mskContactFax.Text == "(___) ___-____") { mskContactFax.Text = string.Empty; }
            }
            catch (Exception ex) { AfficherErreur("Client", "mskContactFax_LostFocus", ex); }
        }
        private void mskContactCell_GotFocus()
        {
            try
            {
                mskContactCell.Mask = "(###) ###-####";
            }
            catch (Exception ex) { AfficherErreur("Client", "mskContactCell_GotFocus", ex); }
        }
        private void mskContactCell_LostFocus()
        {
            try
            {
                mskContactCell.Mask = string.Empty;
                if (mskContactCell.Text == "(___) ___-____") { mskContactCell.Text = string.Empty; }
            }
            catch (Exception ex) { AfficherErreur("Client", "mskContactCell_LostFocus", ex); }
        }
        private void mskContactDom_GotFocus()
        {
            try { mskContactDom.Mask = "(###) ###-####"; return; }
            catch (Exception ex)
            {
                AfficherErreur("Client", "mskContactDom_GotFocus", ex);
            }
        }
        private void mskContactDom_LostFocus()
        {
            try { mskContactDom.Mask = string.Empty; if (mskContactDom.Text == "(___) ___-____") { mskContactDom.Text = string.Empty; } return; }
            catch (Exception ex)
            {
                AfficherErreur("Client", "mskContactDom_LostFocus", ex);
            }
        }
        private void mskContactPage_GotFocus()
        {
            try { mskContactPage.Mask = "(###) ###-####"; return; }
            catch (Exception ex)
            {
                AfficherErreur("Client", "mskContactPage_GotFocus", ex);
            }
        }
        private void mskContactPage_LostFocus()
        {
            try { mskContactPage.Mask = string.Empty; if (mskContactPage.Text == "(___) ___-____") { mskContactPage.Text = string.Empty; } return; }
            catch (Exception ex)
            {
                AfficherErreur("Client", "mskContactPage_LostFocus", ex);
            }
        }
        private bool ExisteDansBD(string sName)
        {
            bool ExisteDansBDRet = default;
            try
            {
                ADODB.Recordset rstContact; rstContact = new Recordset();
                rstContact.Open("SELECT NomContact FROM Contact WHERE NomContact = '" + Strings.Replace(sName, "'", "''") + "' AND Supprimé = 0", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                if (rstContact.EOF) { ExisteDansBDRet = false; } else { ExisteDansBDRet = true; }
                rstContact.Close(); rstContact = null; return ExisteDansBDRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "ExisteDansBD", ex); return false;
            }
        }
        private bool ContientCaracteresIncorrects(string sName)
        {
            bool ContientCaracteresIncorrectsRet = default; try { if (Strings.InStr(1, sName, ",") > 0 | Strings.InStr(1, sName, ";") > 0 | Strings.InStr(1, sName, ":") > 0 | Strings.InStr(1, sName, "(") > 0 | Strings.InStr(1, sName, ")") > 0) { ContientCaracteresIncorrectsRet = true; } else { ContientCaracteresIncorrectsRet = false; } return ContientCaracteresIncorrectsRet; }
            catch (Exception ex)
            {
                AfficherErreur("Client", "ContientCaracteresIncorrects", ex); return false;
            }
        }
        private void txtNomClient_TextChanged(object sender, EventArgs e)
        {
        }
        private void ImprimerFormulaire(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void PrintForm()
        {
            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Left, Top, 0, 0, s);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(ImprimerFormulaire);
            PrintForm();
            printDocument1.Print();
        }
        private void txtCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}