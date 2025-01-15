using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ADODB;
using System.Data.SqlClient;
using Stripe.Forwarding;
using System.Diagnostics;
using System.Collections.Generic;
namespace ControleurServeur
{
    internal class Contact : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public Contact() : base()
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
        internal static ToolTip ToolTip1;
        internal static Button cmdMailList;
        internal static Label lblEtatOutlook;
        internal static Panel fraEtatOutlook;
        internal static TextBox txtNomContact;
        internal static ComboBox cmbContact;
        internal static TextBox txtTitre;
        internal static TextBox txtCommentaire;
        internal static Button cmdFax;
        internal static Button cmdCopier;
        internal static TextBox txtTelDomicile;
        internal static Button cmdRafraichir;
        internal static Button cmdRechercher;
        internal static Button cmdreport;
        internal static TextBox txtPoste;
        internal static TextBox txtRechercher;
        internal static Button CmdModif;
        internal static TextBox txtEmail;
        internal static TextBox txtPagette;
        internal static TextBox txtFax;
        internal static TextBox txtCellulaire;
        internal static TextBox txtTelephone;
        internal static TextBox txtCompagnie;
        internal static Button CmdSupp;
        internal static Button CmdAdd;
        internal static Button CmdQuit;
        internal static MaskedTextBox mskTelephone;
        internal static MaskedTextBox mskCellulaire;
        internal static MaskedTextBox mskFax;
        internal static MaskedTextBox mskPagette;
        internal static MaskedTextBox mskTelDomicile;
        internal static Button CmdAnul;
        internal static Button CmdEnr;
        internal static Label _Label1_10;
        internal static Label _Label1_9;
        internal static Label lblUserModification;
        internal static Label lblUserCreation;
        internal static Label lblDateModification;
        internal static Label lblDateCreation;
        internal static Label _Label12_3;
        internal static Label _Label12_2;
        internal static Label _Label1_8;
        internal static Label _Label1_7;
        internal static Label lblRechercher;
        internal static Label _Label1_6;
        internal static Label _Label1_5;
        internal static Label _Label1_4;
        internal static Label _Label1_3;
        internal static Label _Label1_2;
        internal static Label _Label1_1;
        internal static Label _Label1_0;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdMailList = new System.Windows.Forms.Button();
            fraEtatOutlook = new System.Windows.Forms.Panel();
            lblEtatOutlook = new System.Windows.Forms.Label();
            txtNomContact = new System.Windows.Forms.TextBox();
            cmbContact = new System.Windows.Forms.ComboBox();
            txtTitre = new System.Windows.Forms.TextBox();
            txtCommentaire = new System.Windows.Forms.TextBox();
            cmdFax = new System.Windows.Forms.Button();
            cmdCopier = new System.Windows.Forms.Button();
            txtTelDomicile = new System.Windows.Forms.TextBox();
            cmdRafraichir = new System.Windows.Forms.Button();
            cmdRechercher = new System.Windows.Forms.Button();
            cmdreport = new System.Windows.Forms.Button();
            txtPoste = new System.Windows.Forms.TextBox();
            txtRechercher = new System.Windows.Forms.TextBox();
            CmdModif = new System.Windows.Forms.Button();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPagette = new System.Windows.Forms.TextBox();
            txtFax = new System.Windows.Forms.TextBox();
            txtCellulaire = new System.Windows.Forms.TextBox();
            txtTelephone = new System.Windows.Forms.TextBox();
            txtCompagnie = new System.Windows.Forms.TextBox();
            CmdSupp = new System.Windows.Forms.Button();
            CmdAdd = new System.Windows.Forms.Button();
            CmdQuit = new System.Windows.Forms.Button();
            mskTelephone = new System.Windows.Forms.MaskedTextBox();
            mskCellulaire = new System.Windows.Forms.MaskedTextBox();
            mskFax = new System.Windows.Forms.MaskedTextBox();
            mskPagette = new System.Windows.Forms.MaskedTextBox();
            mskTelDomicile = new System.Windows.Forms.MaskedTextBox();
            CmdAnul = new System.Windows.Forms.Button();
            CmdEnr = new System.Windows.Forms.Button();
            _Label1_10 = new System.Windows.Forms.Label();
            _Label1_9 = new System.Windows.Forms.Label();
            lblUserModification = new System.Windows.Forms.Label();
            lblUserCreation = new System.Windows.Forms.Label();
            lblDateModification = new System.Windows.Forms.Label();
            lblDateCreation = new System.Windows.Forms.Label();
            _Label12_3 = new System.Windows.Forms.Label();
            _Label12_2 = new System.Windows.Forms.Label();
            _Label1_8 = new System.Windows.Forms.Label();
            _Label1_7 = new System.Windows.Forms.Label();
            lblRechercher = new System.Windows.Forms.Label();
            _Label1_6 = new System.Windows.Forms.Label();
            _Label1_5 = new System.Windows.Forms.Label();
            _Label1_4 = new System.Windows.Forms.Label();
            _Label1_3 = new System.Windows.Forms.Label();
            _Label1_2 = new System.Windows.Forms.Label();
            _Label1_1 = new System.Windows.Forms.Label();
            _Label1_0 = new System.Windows.Forms.Label();
            fraEtatOutlook.SuspendLayout();
            SuspendLayout();
            // 
            // ToolTip1
            // 
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // cmdMailList
            // 
            cmdMailList.BackColor = System.Drawing.Color.Black;
            cmdMailList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdMailList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdMailList.ForeColor = System.Drawing.Color.White;
            cmdMailList.Location = new System.Drawing.Point(375, 464);
            cmdMailList.Name = "cmdMailList";
            cmdMailList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdMailList.Size = new System.Drawing.Size(118, 24);
            cmdMailList.TabIndex = 49;
            cmdMailList.Text = "Ajouter au mailing list";
            cmdMailList.UseVisualStyleBackColor = true;
            cmdMailList.Click += new System.EventHandler(cmdMailList_Click);
            // 
            // fraEtatOutlook
            // 
            fraEtatOutlook.BackColor = System.Drawing.Color.Black;
            fraEtatOutlook.Controls.Add(lblEtatOutlook);
            fraEtatOutlook.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraEtatOutlook.ForeColor = System.Drawing.Color.White;
            fraEtatOutlook.Location = new System.Drawing.Point(20, 84);
            fraEtatOutlook.Name = "fraEtatOutlook";
            fraEtatOutlook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraEtatOutlook.Size = new System.Drawing.Size(553, 310);
            fraEtatOutlook.TabIndex = 14;
            fraEtatOutlook.Visible = false;
            // 
            // lblEtatOutlook
            // 
            lblEtatOutlook.BackColor = System.Drawing.Color.Black;
            lblEtatOutlook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblEtatOutlook.Dock = System.Windows.Forms.DockStyle.Fill;
            lblEtatOutlook.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEtatOutlook.ForeColor = System.Drawing.Color.White;
            lblEtatOutlook.Location = new System.Drawing.Point(0, 0);
            lblEtatOutlook.Name = "lblEtatOutlook";
            lblEtatOutlook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblEtatOutlook.Size = new System.Drawing.Size(553, 310);
            lblEtatOutlook.TabIndex = 15;
            lblEtatOutlook.Text = "Recherche du client dans Outlook ..";
            lblEtatOutlook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomContact
            // 
            txtNomContact.AcceptsReturn = true;
            txtNomContact.BackColor = System.Drawing.Color.Black;
            txtNomContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtNomContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNomContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNomContact.ForeColor = System.Drawing.Color.White;
            txtNomContact.Location = new System.Drawing.Point(103, 88);
            txtNomContact.MaxLength = 0;
            txtNomContact.Name = "txtNomContact";
            txtNomContact.ReadOnly = true;
            txtNomContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNomContact.Size = new System.Drawing.Size(409, 20);
            txtNomContact.TabIndex = 5;
            txtNomContact.Text = "Text1";
            // 
            // cmbContact
            // 
            cmbContact.BackColor = System.Drawing.Color.Black;
            cmbContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbContact.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbContact.ForeColor = System.Drawing.Color.White;
            cmbContact.Location = new System.Drawing.Point(103, 88);
            cmbContact.Name = "cmbContact";
            cmbContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbContact.Size = new System.Drawing.Size(425, 22);
            cmbContact.TabIndex = 4;
            cmbContact.SelectedIndexChanged += new System.EventHandler(cmbContact_SelectedIndexChanged);
            // 
            // txtTitre
            // 
            txtTitre.AcceptsReturn = true;
            txtTitre.BackColor = System.Drawing.Color.Black;
            txtTitre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtTitre.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTitre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTitre.ForeColor = System.Drawing.Color.White;
            txtTitre.Location = new System.Drawing.Point(106, 138);
            txtTitre.MaxLength = 0;
            txtTitre.Name = "txtTitre";
            txtTitre.ReadOnly = true;
            txtTitre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTitre.Size = new System.Drawing.Size(393, 20);
            txtTitre.TabIndex = 8;
            txtTitre.Text = "Text1";
            // 
            // txtCommentaire
            // 
            txtCommentaire.AcceptsReturn = true;
            txtCommentaire.BackColor = System.Drawing.Color.Black;
            txtCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtCommentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCommentaire.ForeColor = System.Drawing.Color.White;
            txtCommentaire.Location = new System.Drawing.Point(106, 330);
            txtCommentaire.MaxLength = 0;
            txtCommentaire.Multiline = true;
            txtCommentaire.Name = "txtCommentaire";
            txtCommentaire.ReadOnly = true;
            txtCommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtCommentaire.Size = new System.Drawing.Size(393, 43);
            txtCommentaire.TabIndex = 33;
            // 
            // cmdFax
            // 
            cmdFax.BackColor = System.Drawing.Color.Black;
            cmdFax.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFax.ForeColor = System.Drawing.Color.White;
            cmdFax.Location = new System.Drawing.Point(495, 464);
            cmdFax.Name = "cmdFax";
            cmdFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFax.Size = new System.Drawing.Size(78, 24);
            cmdFax.TabIndex = 47;
            cmdFax.Text = "Envoyer Fax";
            cmdFax.UseVisualStyleBackColor = true;
            cmdFax.Click += new System.EventHandler(cmdFax_Click);
            // 
            // cmdCopier
            // 
            cmdCopier.BackColor = System.Drawing.Color.Black;
            cmdCopier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdCopier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdCopier.ForeColor = System.Drawing.Color.White;
            cmdCopier.Location = new System.Drawing.Point(103, 464);
            cmdCopier.Name = "cmdCopier";
            cmdCopier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCopier.Size = new System.Drawing.Size(48, 24);
            cmdCopier.TabIndex = 41;
            cmdCopier.Text = "&Copier";
            cmdCopier.UseVisualStyleBackColor = true;
            cmdCopier.Click += new System.EventHandler(cmdCopier_Click);
            // 
            // txtTelDomicile
            // 
            txtTelDomicile.AcceptsReturn = true;
            txtTelDomicile.BackColor = System.Drawing.Color.Black;
            txtTelDomicile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtTelDomicile.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTelDomicile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTelDomicile.ForeColor = System.Drawing.Color.White;
            txtTelDomicile.Location = new System.Drawing.Point(106, 210);
            txtTelDomicile.MaxLength = 0;
            txtTelDomicile.Name = "txtTelDomicile";
            txtTelDomicile.ReadOnly = true;
            txtTelDomicile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTelDomicile.Size = new System.Drawing.Size(393, 20);
            txtTelDomicile.TabIndex = 18;
            txtTelDomicile.Text = "Text1";
            // 
            // cmdRafraichir
            // 
            cmdRafraichir.AutoSize = true;
            cmdRafraichir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdRafraichir.BackColor = System.Drawing.Color.Black;
            cmdRafraichir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRafraichir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRafraichir.ForeColor = System.Drawing.Color.White;
            cmdRafraichir.Location = new System.Drawing.Point(534, 84);
            cmdRafraichir.Name = "cmdRafraichir";
            cmdRafraichir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRafraichir.Size = new System.Drawing.Size(68, 23);
            cmdRafraichir.TabIndex = 3;
            cmdRafraichir.Text = "Rafraîchir";
            cmdRafraichir.UseVisualStyleBackColor = true;
            cmdRafraichir.Click += new System.EventHandler(cmdRafraichir_Click);
            // 
            // cmdRechercher
            // 
            cmdRechercher.AutoSize = true;
            cmdRechercher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdRechercher.BackColor = System.Drawing.Color.Black;
            cmdRechercher.Enabled = false;
            cmdRechercher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRechercher.ForeColor = System.Drawing.Color.White;
            cmdRechercher.Location = new System.Drawing.Point(534, 12);
            cmdRechercher.Name = "cmdRechercher";
            cmdRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercher.Size = new System.Drawing.Size(78, 23);
            cmdRechercher.TabIndex = 1;
            cmdRechercher.Text = "Rechercher";
            cmdRechercher.UseVisualStyleBackColor = true;
            cmdRechercher.Click += new System.EventHandler(cmdRechercher_Click);
            // 
            // cmdreport
            // 
            cmdreport.BackColor = System.Drawing.Color.Black;
            cmdreport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdreport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdreport.ForeColor = System.Drawing.Color.White;
            cmdreport.Location = new System.Drawing.Point(19, 464);
            cmdreport.Name = "cmdreport";
            cmdreport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdreport.Size = new System.Drawing.Size(81, 24);
            cmdreport.TabIndex = 40;
            cmdreport.Text = "&Impression";
            cmdreport.UseVisualStyleBackColor = true;
            cmdreport.Click += new System.EventHandler(cmdreport_Click);
            // 
            // txtPoste
            // 
            txtPoste.AcceptsReturn = true;
            txtPoste.BackColor = System.Drawing.Color.Black;
            txtPoste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtPoste.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPoste.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtPoste.ForeColor = System.Drawing.Color.White;
            txtPoste.Location = new System.Drawing.Point(106, 186);
            txtPoste.MaxLength = 0;
            txtPoste.Name = "txtPoste";
            txtPoste.ReadOnly = true;
            txtPoste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPoste.Size = new System.Drawing.Size(393, 20);
            txtPoste.TabIndex = 17;
            txtPoste.Text = "Text1";
            // 
            // txtRechercher
            // 
            txtRechercher.AcceptsReturn = true;
            txtRechercher.BackColor = System.Drawing.Color.Black;
            txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtRechercher.ForeColor = System.Drawing.Color.White;
            txtRechercher.Location = new System.Drawing.Point(328, 16);
            txtRechercher.MaxLength = 0;
            txtRechercher.Name = "txtRechercher";
            txtRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtRechercher.Size = new System.Drawing.Size(200, 20);
            txtRechercher.TabIndex = 2;
            txtRechercher.TextChanged += new System.EventHandler(txtRechercher_TextChanged);
            // 
            // CmdModif
            // 
            CmdModif.BackColor = System.Drawing.Color.Black;
            CmdModif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdModif.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdModif.ForeColor = System.Drawing.Color.White;
            CmdModif.Location = new System.Drawing.Point(311, 464);
            CmdModif.Name = "CmdModif";
            CmdModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdModif.Size = new System.Drawing.Size(55, 24);
            CmdModif.TabIndex = 46;
            CmdModif.Text = "&Modifier";
            CmdModif.UseVisualStyleBackColor = true;
            CmdModif.Click += new System.EventHandler(CmdModif_Click);
            // 
            // txtEmail
            // 
            txtEmail.AcceptsReturn = true;
            txtEmail.BackColor = System.Drawing.Color.Black;
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtEmail.ForeColor = System.Drawing.Color.White;
            txtEmail.Location = new System.Drawing.Point(106, 306);
            txtEmail.MaxLength = 0;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtEmail.Size = new System.Drawing.Size(393, 20);
            txtEmail.TabIndex = 31;
            txtEmail.Text = "Text1";
            // 
            // txtPagette
            // 
            txtPagette.AcceptsReturn = true;
            txtPagette.BackColor = System.Drawing.Color.Black;
            txtPagette.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtPagette.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPagette.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtPagette.ForeColor = System.Drawing.Color.White;
            txtPagette.Location = new System.Drawing.Point(106, 282);
            txtPagette.MaxLength = 0;
            txtPagette.Name = "txtPagette";
            txtPagette.ReadOnly = true;
            txtPagette.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPagette.Size = new System.Drawing.Size(393, 20);
            txtPagette.TabIndex = 28;
            txtPagette.Text = "Text1";
            // 
            // txtFax
            // 
            txtFax.AcceptsReturn = true;
            txtFax.BackColor = System.Drawing.Color.Black;
            txtFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtFax.ForeColor = System.Drawing.Color.White;
            txtFax.Location = new System.Drawing.Point(106, 258);
            txtFax.MaxLength = 0;
            txtFax.Name = "txtFax";
            txtFax.ReadOnly = true;
            txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtFax.Size = new System.Drawing.Size(393, 20);
            txtFax.TabIndex = 25;
            txtFax.Text = "Text1";
            // 
            // txtCellulaire
            // 
            txtCellulaire.AcceptsReturn = true;
            txtCellulaire.BackColor = System.Drawing.Color.Black;
            txtCellulaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtCellulaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCellulaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCellulaire.ForeColor = System.Drawing.Color.White;
            txtCellulaire.Location = new System.Drawing.Point(106, 234);
            txtCellulaire.MaxLength = 0;
            txtCellulaire.Name = "txtCellulaire";
            txtCellulaire.ReadOnly = true;
            txtCellulaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCellulaire.Size = new System.Drawing.Size(393, 20);
            txtCellulaire.TabIndex = 21;
            txtCellulaire.Text = "Text1";
            // 
            // txtTelephone
            // 
            txtTelephone.AcceptsReturn = true;
            txtTelephone.BackColor = System.Drawing.Color.Black;
            txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTelephone.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTelephone.ForeColor = System.Drawing.Color.White;
            txtTelephone.Location = new System.Drawing.Point(106, 162);
            txtTelephone.MaxLength = 0;
            txtTelephone.Name = "txtTelephone";
            txtTelephone.ReadOnly = true;
            txtTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTelephone.Size = new System.Drawing.Size(393, 20);
            txtTelephone.TabIndex = 13;
            txtTelephone.Text = "Text1";
            // 
            // txtCompagnie
            // 
            txtCompagnie.AcceptsReturn = true;
            txtCompagnie.BackColor = System.Drawing.Color.Black;
            txtCompagnie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtCompagnie.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCompagnie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCompagnie.ForeColor = System.Drawing.Color.White;
            txtCompagnie.Location = new System.Drawing.Point(106, 114);
            txtCompagnie.MaxLength = 0;
            txtCompagnie.Name = "txtCompagnie";
            txtCompagnie.ReadOnly = true;
            txtCompagnie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCompagnie.Size = new System.Drawing.Size(393, 20);
            txtCompagnie.TabIndex = 7;
            txtCompagnie.Text = "Text1";
            // 
            // CmdSupp
            // 
            CmdSupp.BackColor = System.Drawing.Color.Black;
            CmdSupp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdSupp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdSupp.ForeColor = System.Drawing.Color.White;
            CmdSupp.Location = new System.Drawing.Point(239, 464);
            CmdSupp.Name = "CmdSupp";
            CmdSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdSupp.Size = new System.Drawing.Size(66, 24);
            CmdSupp.TabIndex = 45;
            CmdSupp.Text = "&Supprimer";
            CmdSupp.UseVisualStyleBackColor = true;
            CmdSupp.Click += new System.EventHandler(CmdSupp_Click);
            // 
            // CmdAdd
            // 
            CmdAdd.BackColor = System.Drawing.Color.Black;
            CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdAdd.ForeColor = System.Drawing.Color.White;
            CmdAdd.Location = new System.Drawing.Point(175, 464);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAdd.Size = new System.Drawing.Size(52, 24);
            CmdAdd.TabIndex = 44;
            CmdAdd.Text = "&Ajouter";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += new System.EventHandler(CmdAdd_Click);
            // 
            // CmdQuit
            // 
            CmdQuit.BackColor = System.Drawing.Color.Black;
            CmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdQuit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdQuit.ForeColor = System.Drawing.Color.White;
            CmdQuit.Location = new System.Drawing.Point(575, 464);
            CmdQuit.Name = "CmdQuit";
            CmdQuit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdQuit.Size = new System.Drawing.Size(51, 24);
            CmdQuit.TabIndex = 48;
            CmdQuit.Text = "&Fermer";
            CmdQuit.UseVisualStyleBackColor = true;
            CmdQuit.Click += new System.EventHandler(cmdquit_Click);
            // 
            // mskTelephone
            // 
            mskTelephone.AllowPromptAsInput = false;
            mskTelephone.BackColor = System.Drawing.Color.Black;
            mskTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskTelephone.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskTelephone.ForeColor = System.Drawing.Color.White;
            mskTelephone.Location = new System.Drawing.Point(106, 162);
            mskTelephone.Name = "mskTelephone";
            mskTelephone.Size = new System.Drawing.Size(393, 20);
            mskTelephone.TabIndex = 12;
            mskTelephone.Visible = false;
            mskTelephone.Enter += new System.EventHandler(mskTelephone_Enter);
            mskTelephone.Leave += new System.EventHandler(mskTelephone_Leave);
            // 
            // mskCellulaire
            // 
            mskCellulaire.AllowPromptAsInput = false;
            mskCellulaire.BackColor = System.Drawing.Color.Black;
            mskCellulaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskCellulaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskCellulaire.ForeColor = System.Drawing.Color.White;
            mskCellulaire.Location = new System.Drawing.Point(106, 234);
            mskCellulaire.Name = "mskCellulaire";
            mskCellulaire.Size = new System.Drawing.Size(393, 20);
            mskCellulaire.TabIndex = 22;
            mskCellulaire.Visible = false;
            mskCellulaire.Enter += new System.EventHandler(mskCellulaire_Enter);
            mskCellulaire.Leave += new System.EventHandler(mskCellulaire_Leave);
            // 
            // mskFax
            // 
            mskFax.AllowPromptAsInput = false;
            mskFax.BackColor = System.Drawing.Color.Black;
            mskFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskFax.ForeColor = System.Drawing.Color.White;
            mskFax.Location = new System.Drawing.Point(106, 258);
            mskFax.Name = "mskFax";
            mskFax.Size = new System.Drawing.Size(393, 20);
            mskFax.TabIndex = 24;
            mskFax.Visible = false;
            mskFax.Enter += new System.EventHandler(mskFax_Enter);
            mskFax.Leave += new System.EventHandler(mskFax_Leave);
            // 
            // mskPagette
            // 
            mskPagette.AllowPromptAsInput = false;
            mskPagette.BackColor = System.Drawing.Color.Black;
            mskPagette.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskPagette.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskPagette.ForeColor = System.Drawing.Color.White;
            mskPagette.Location = new System.Drawing.Point(106, 282);
            mskPagette.Name = "mskPagette";
            mskPagette.Size = new System.Drawing.Size(393, 20);
            mskPagette.TabIndex = 27;
            mskPagette.Visible = false;
            mskPagette.Enter += new System.EventHandler(mskPagette_Enter);
            mskPagette.Leave += new System.EventHandler(mskPagette_Leave);
            // 
            // mskTelDomicile
            // 
            mskTelDomicile.AllowPromptAsInput = false;
            mskTelDomicile.BackColor = System.Drawing.Color.Black;
            mskTelDomicile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskTelDomicile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskTelDomicile.ForeColor = System.Drawing.Color.White;
            mskTelDomicile.Location = new System.Drawing.Point(106, 210);
            mskTelDomicile.Name = "mskTelDomicile";
            mskTelDomicile.Size = new System.Drawing.Size(393, 20);
            mskTelDomicile.TabIndex = 19;
            mskTelDomicile.Visible = false;
            mskTelDomicile.Enter += new System.EventHandler(mskTelDomicile_Enter);
            mskTelDomicile.Leave += new System.EventHandler(mskTelDomicile_Leave);
            // 
            // CmdAnul
            // 
            CmdAnul.BackColor = System.Drawing.Color.Black;
            CmdAnul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdAnul.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdAnul.ForeColor = System.Drawing.Color.White;
            CmdAnul.Location = new System.Drawing.Point(175, 464);
            CmdAnul.Name = "CmdAnul";
            CmdAnul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAnul.Size = new System.Drawing.Size(55, 24);
            CmdAnul.TabIndex = 43;
            CmdAnul.Text = "A&nnuler";
            CmdAnul.UseVisualStyleBackColor = true;
            CmdAnul.Visible = false;
            CmdAnul.Click += new System.EventHandler(CmdAnul_Click);
            // 
            // CmdEnr
            // 
            CmdEnr.BackColor = System.Drawing.Color.Black;
            CmdEnr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdEnr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdEnr.ForeColor = System.Drawing.Color.White;
            CmdEnr.Location = new System.Drawing.Point(103, 464);
            CmdEnr.Name = "CmdEnr";
            CmdEnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdEnr.Size = new System.Drawing.Size(70, 24);
            CmdEnr.TabIndex = 42;
            CmdEnr.Text = "&Enregistrer";
            CmdEnr.UseVisualStyleBackColor = true;
            CmdEnr.Visible = false;
            CmdEnr.Click += new System.EventHandler(CmdEnr_Click);
            // 
            // _Label1_10
            // 
            _Label1_10.AutoSize = true;
            _Label1_10.BackColor = System.Drawing.Color.Black;
            _Label1_10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_10.ForeColor = System.Drawing.Color.White;
            _Label1_10.Location = new System.Drawing.Point(16, 140);
            _Label1_10.Name = "_Label1_10";
            _Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_10.Size = new System.Drawing.Size(39, 14);
            _Label1_10.TabIndex = 11;
            _Label1_10.Text = "Titre :";
            _Label1_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_9
            // 
            _Label1_9.AutoSize = true;
            _Label1_9.BackColor = System.Drawing.Color.Black;
            _Label1_9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_9.ForeColor = System.Drawing.Color.White;
            _Label1_9.Location = new System.Drawing.Point(8, 332);
            _Label1_9.Name = "_Label1_9";
            _Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_9.Size = new System.Drawing.Size(89, 14);
            _Label1_9.TabIndex = 32;
            _Label1_9.Text = "Commentaire :";
            _Label1_9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUserModification
            // 
            lblUserModification.BackColor = System.Drawing.Color.Black;
            lblUserModification.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserModification.ForeColor = System.Drawing.Color.White;
            lblUserModification.Location = new System.Drawing.Point(178, 403);
            lblUserModification.Name = "lblUserModification";
            lblUserModification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblUserModification.Size = new System.Drawing.Size(89, 17);
            lblUserModification.TabIndex = 39;
            lblUserModification.Text = "Par :";
            // 
            // lblUserCreation
            // 
            lblUserCreation.BackColor = System.Drawing.Color.Black;
            lblUserCreation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserCreation.ForeColor = System.Drawing.Color.White;
            lblUserCreation.Location = new System.Drawing.Point(178, 378);
            lblUserCreation.Name = "lblUserCreation";
            lblUserCreation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblUserCreation.Size = new System.Drawing.Size(89, 17);
            lblUserCreation.TabIndex = 36;
            lblUserCreation.Text = "Par :";
            // 
            // lblDateModification
            // 
            lblDateModification.BackColor = System.Drawing.Color.Black;
            lblDateModification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblDateModification.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateModification.ForeColor = System.Drawing.Color.White;
            lblDateModification.Location = new System.Drawing.Point(106, 402);
            lblDateModification.Name = "lblDateModification";
            lblDateModification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateModification.Size = new System.Drawing.Size(65, 19);
            lblDateModification.TabIndex = 38;
            lblDateModification.Text = "2004-09-14";
            lblDateModification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateCreation
            // 
            lblDateCreation.BackColor = System.Drawing.Color.Black;
            lblDateCreation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblDateCreation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateCreation.ForeColor = System.Drawing.Color.White;
            lblDateCreation.Location = new System.Drawing.Point(106, 378);
            lblDateCreation.Name = "lblDateCreation";
            lblDateCreation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateCreation.Size = new System.Drawing.Size(65, 19);
            lblDateCreation.TabIndex = 35;
            lblDateCreation.Text = "2004-09-14";
            lblDateCreation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _Label12_3
            // 
            _Label12_3.AutoSize = true;
            _Label12_3.BackColor = System.Drawing.Color.Black;
            _Label12_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label12_3.ForeColor = System.Drawing.Color.White;
            _Label12_3.Location = new System.Drawing.Point(8, 404);
            _Label12_3.Name = "_Label12_3";
            _Label12_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label12_3.Size = new System.Drawing.Size(80, 14);
            _Label12_3.TabIndex = 37;
            _Label12_3.Text = "Modification :";
            _Label12_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label12_2
            // 
            _Label12_2.AutoSize = true;
            _Label12_2.BackColor = System.Drawing.Color.Black;
            _Label12_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label12_2.ForeColor = System.Drawing.Color.White;
            _Label12_2.Location = new System.Drawing.Point(16, 380);
            _Label12_2.Name = "_Label12_2";
            _Label12_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label12_2.Size = new System.Drawing.Size(60, 14);
            _Label12_2.TabIndex = 34;
            _Label12_2.Text = "Création :";
            _Label12_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_8
            // 
            _Label1_8.AutoSize = true;
            _Label1_8.BackColor = System.Drawing.Color.Black;
            _Label1_8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_8.ForeColor = System.Drawing.Color.White;
            _Label1_8.Location = new System.Drawing.Point(16, 212);
            _Label1_8.Name = "_Label1_8";
            _Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_8.Size = new System.Drawing.Size(60, 14);
            _Label1_8.TabIndex = 30;
            _Label1_8.Text = "Domicile :";
            _Label1_8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_7
            // 
            _Label1_7.AutoSize = true;
            _Label1_7.BackColor = System.Drawing.Color.Black;
            _Label1_7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_7.ForeColor = System.Drawing.Color.White;
            _Label1_7.Location = new System.Drawing.Point(16, 188);
            _Label1_7.Name = "_Label1_7";
            _Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_7.Size = new System.Drawing.Size(45, 14);
            _Label1_7.TabIndex = 16;
            _Label1_7.Text = "Poste :";
            _Label1_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRechercher
            // 
            lblRechercher.BackColor = System.Drawing.Color.Black;
            lblRechercher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRechercher.ForeColor = System.Drawing.Color.White;
            lblRechercher.Location = new System.Drawing.Point(228, 18);
            lblRechercher.Name = "lblRechercher";
            lblRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblRechercher.Size = new System.Drawing.Size(97, 17);
            lblRechercher.TabIndex = 0;
            lblRechercher.Text = "Rechercher";
            // 
            // _Label1_6
            // 
            _Label1_6.AutoSize = true;
            _Label1_6.BackColor = System.Drawing.Color.Black;
            _Label1_6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_6.ForeColor = System.Drawing.Color.White;
            _Label1_6.Location = new System.Drawing.Point(16, 90);
            _Label1_6.Name = "_Label1_6";
            _Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_6.Size = new System.Drawing.Size(55, 14);
            _Label1_6.TabIndex = 10;
            _Label1_6.Text = "Contact :";
            _Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_5
            // 
            _Label1_5.AutoSize = true;
            _Label1_5.BackColor = System.Drawing.Color.Black;
            _Label1_5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_5.ForeColor = System.Drawing.Color.White;
            _Label1_5.Location = new System.Drawing.Point(16, 310);
            _Label1_5.Name = "_Label1_5";
            _Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_5.Size = new System.Drawing.Size(45, 14);
            _Label1_5.TabIndex = 29;
            _Label1_5.Text = "E-Mail :";
            _Label1_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_4
            // 
            _Label1_4.AutoSize = true;
            _Label1_4.BackColor = System.Drawing.Color.Black;
            _Label1_4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_4.ForeColor = System.Drawing.Color.White;
            _Label1_4.Location = new System.Drawing.Point(16, 286);
            _Label1_4.Name = "_Label1_4";
            _Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_4.Size = new System.Drawing.Size(55, 14);
            _Label1_4.TabIndex = 26;
            _Label1_4.Text = "Pagette :";
            _Label1_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_3
            // 
            _Label1_3.AutoSize = true;
            _Label1_3.BackColor = System.Drawing.Color.Black;
            _Label1_3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_3.ForeColor = System.Drawing.Color.White;
            _Label1_3.Location = new System.Drawing.Point(16, 262);
            _Label1_3.Name = "_Label1_3";
            _Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_3.Size = new System.Drawing.Size(31, 14);
            _Label1_3.TabIndex = 23;
            _Label1_3.Text = "Fax :";
            _Label1_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_2
            // 
            _Label1_2.AutoSize = true;
            _Label1_2.BackColor = System.Drawing.Color.Black;
            _Label1_2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_2.ForeColor = System.Drawing.Color.White;
            _Label1_2.Location = new System.Drawing.Point(16, 236);
            _Label1_2.Name = "_Label1_2";
            _Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_2.Size = new System.Drawing.Size(65, 14);
            _Label1_2.TabIndex = 20;
            _Label1_2.Text = "Cellulaire :";
            _Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_1
            // 
            _Label1_1.AutoSize = true;
            _Label1_1.BackColor = System.Drawing.Color.Black;
            _Label1_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_1.ForeColor = System.Drawing.Color.White;
            _Label1_1.Location = new System.Drawing.Point(16, 164);
            _Label1_1.Name = "_Label1_1";
            _Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_1.Size = new System.Drawing.Size(72, 14);
            _Label1_1.TabIndex = 9;
            _Label1_1.Text = "Téléphone :";
            _Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_0
            // 
            _Label1_0.AutoSize = true;
            _Label1_0.BackColor = System.Drawing.Color.Black;
            _Label1_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_0.ForeColor = System.Drawing.Color.White;
            _Label1_0.Location = new System.Drawing.Point(16, 116);
            _Label1_0.Name = "_Label1_0";
            _Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_0.Size = new System.Drawing.Size(76, 14);
            _Label1_0.TabIndex = 6;
            _Label1_0.Text = "Compagnie :";
            _Label1_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Contact
            // 
            AcceptButton = cmdRechercher;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(645, 504);
            Controls.Add(cmdMailList);
            Controls.Add(fraEtatOutlook);
            Controls.Add(txtNomContact);
            Controls.Add(cmbContact);
            Controls.Add(txtTitre);
            Controls.Add(txtCommentaire);
            Controls.Add(cmdFax);
            Controls.Add(cmdCopier);
            Controls.Add(txtTelDomicile);
            Controls.Add(cmdRafraichir);
            Controls.Add(cmdRechercher);
            Controls.Add(cmdreport);
            Controls.Add(txtPoste);
            Controls.Add(txtRechercher);
            Controls.Add(CmdModif);
            Controls.Add(txtEmail);
            Controls.Add(txtPagette);
            Controls.Add(txtFax);
            Controls.Add(txtCellulaire);
            Controls.Add(txtTelephone);
            Controls.Add(txtCompagnie);
            Controls.Add(CmdSupp);
            Controls.Add(CmdAdd);
            Controls.Add(CmdQuit);
            Controls.Add(mskTelephone);
            Controls.Add(mskCellulaire);
            Controls.Add(mskFax);
            Controls.Add(mskPagette);
            Controls.Add(mskTelDomicile);
            Controls.Add(CmdAnul);
            Controls.Add(CmdEnr);
            Controls.Add(_Label1_10);
            Controls.Add(_Label1_9);
            Controls.Add(lblUserModification);
            Controls.Add(lblUserCreation);
            Controls.Add(lblDateModification);
            Controls.Add(lblDateCreation);
            Controls.Add(_Label12_3);
            Controls.Add(_Label12_2);
            Controls.Add(_Label1_8);
            Controls.Add(_Label1_7);
            Controls.Add(lblRechercher);
            Controls.Add(_Label1_6);
            Controls.Add(_Label1_5);
            Controls.Add(_Label1_4);
            Controls.Add(_Label1_3);
            Controls.Add(_Label1_2);
            Controls.Add(_Label1_1);
            Controls.Add(_Label1_0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(222, 178);
            Name = "Contact";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
            ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Text = "ControleurServeur." + Name;
            ShowInTaskbar = false;
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(Contact_FormClosed);
            Load += new System.EventHandler(Contact_Load);
            fraEtatOutlook.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        private enum EnumMode
        {
            MODE_AJOUT_MODIF = 0,
            MODE_INACTIF = 1
        }
        private bool m_bModeAjout;
        private bool m_bRenommer;
        private int m_iNoContact;
        public bool m_bAnnulerDistList;
        public Microsoft.Office.Interop.Outlook.DistListItem m_otlDistList;
        private class DisplayContacts
        {
            public string NomContact;
            public string Compagnie;
            public int IdContact;
            public DisplayContacts(string compagnie,string nomContact,  int idContact)
            {
                NomContact = nomContact;
                Compagnie = compagnie;
                IdContact = idContact;
            }
        }
        List<DisplayContacts> cts = new List<DisplayContacts>();
        private void RemplirComboContact()
        {
            try
            {
                SqlConnection sql = new SqlConnection(StringSQL);
                sql.Open();
                SqlDataReader rd = new SqlCommand($"SELECT TRIM(NOMCONTACT), TRIM(COMPAGNIE), IDCONTACT FROM CONTACT WHERE SUPPRIMÉ = 0 AND COMPAGNIE!='' ORDER BY NOMCONTACT ASC", sql).ExecuteReader();
                cmbContact.Items.Clear();
                while (rd.Read())
                {
                    cts.Add(new DisplayContacts(rd[1].ToString(), rd[0].ToString(), (int)rd[2]));
                    cmbContact.Items.Add(rd[0].ToString() );
                }
                rd.Close();
                sql.Close();
                if (cmbContact.Items.Count > 0)
                {
                    cmbContact.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "RemplirComboContact", ex);
            }
        }
        private void EnregistrerContact()
        {
            try
            {
                ADODB.Recordset rstContact;
                rstContact = new Recordset();
                if (m_bModeAjout == true)
                {
                    rstContact.Open("SELECT * FROM Contact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstContact.AddNew();
                    rstContact.Fields["DateCréation"].Value = ConvertDate(DateTime.Today);
                    rstContact.Fields["UserCréation"].Value = Conteneur.idInitiales.Text;
                }
                else
                {
                    rstContact.Open("SELECT * FROM contact WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstContact.Fields["DateModification"].Value = ConvertDate(DateTime.Today);
                    rstContact.Fields["UserModification"].Value = Conteneur.idInitiales.Text;
                }
                rstContact.Fields["NomContact"].Value = txtNomContact.Text;
                rstContact.Fields["Compagnie"].Value = txtCompagnie.Text;
                rstContact.Fields["Titre"].Value = txtTitre.Text;
                rstContact.Fields["Telephonne"].Value = mskTelephone.Text;
                rstContact.Fields["Fax"].Value = mskFax.Text;
                rstContact.Fields["Pagette"].Value = mskPagette.Text;
                rstContact.Fields["Cellulaire"].Value = mskCellulaire.Text;
                rstContact.Fields["E-mail"].Value = txtEmail.Text;
                rstContact.Fields["NoPoste"].Value = txtPoste.Text;
                rstContact.Fields["TelDomicile"].Value = mskTelDomicile.Text;
                rstContact.Fields["Commentaire"].Value = txtCommentaire.Text;
      //          rstContact.Fields["EntryIDOutlook"].Value = ModifierContactExchange(int.Parse(rstContact.Fields["IDContact"].Value));
                if (m_bModeAjout == true)
                {
                    m_bModeAjout = false;
                }
                rstContact.Update();
                rstContact.Close();
                rstContact = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "EnregistrerContact", ex);
            }
        }
        private string ModifierContactExchange(int iContactID)
        {
            string ModifierContactExchangeRet = default;
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.ContactItem otlContact;
                Microsoft.Office.Interop.Outlook.MAPIFolder folContact;
                var bDejaOuvert = default(bool);
                string[] sNom;
                if (m_bModeAjout == true)
                {
                    lblEtatOutlook.Text = "Ajout du contact dans Outlook ..";
                }
                else
                {
                    lblEtatOutlook.Text = "Modification du contact dans Outlook ..";
                }
                fraEtatOutlook.Visible = true;
                otlApp = OuvrirOutlook(ref bDejaOuvert);
                folContact = GetFolder(otlApp, "Contacts GRB");
                if (m_bModeAjout == true)
                {
                    otlContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Add(Microsoft.Office.Interop.Outlook.OlItemType.olContactItem);
                    otlContact.User1 = iContactID.ToString();
                }
                else { otlContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Find("[User1] = " + iContactID); }
                if (otlContact is null)
                {
                    MessageBox.Show("Le contact " + txtNomContact.Text + " n'a pas été trouvé pour la mise à jour Exchange!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fraEtatOutlook.Visible = false;
                    return ModifierContactExchangeRet;
                }
                sNom = txtNomContact.Text.Split(' ');
                switch (Information.UBound(sNom))
                {
                    case 0: { otlContact.FirstName = sNom[0]; break; }
                    case 1: { otlContact.FirstName = sNom[0]; otlContact.LastName = sNom[1]; break; }
                    case 2: { otlContact.FirstName = sNom[0]; otlContact.MiddleName = sNom[1]; otlContact.LastName = sNom[2]; break; }
                }
                otlContact.Title = "";
                otlContact.CompanyName = txtCompagnie.Text;
                otlContact.JobTitle = txtTitre.Text;
                if (mskTelephone.Text != "(___) ___-____")
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(txtPoste.Text)))
                    {
                        otlContact.BusinessTelephoneNumber = mskTelephone.Text + " Ext : " + txtPoste.Text;
                    }
                    else
                    {
                        otlContact.BusinessTelephoneNumber = mskTelephone.Text;
                    }
                }
                if (mskFax.Text != "(___) ___-____") { otlContact.BusinessFaxNumber = mskFax.Text; }
                if (mskCellulaire.Text != "(___) ___-____") { otlContact.MobileTelephoneNumber = mskCellulaire.Text; }
                if (mskPagette.Text != "(___) ___-____")
                {
                    otlContact.PagerNumber = mskPagette.Text;
                }
                otlContact.Email1Address = txtEmail.Text;
                if (mskTelDomicile.Text != "(___) ___-____") { otlContact.HomeTelephoneNumber = mskTelDomicile.Text; }
                if (!string.IsNullOrEmpty(txtCommentaire.Text))
                {
                    otlContact.Body = txtCommentaire.Text;
                }
                otlContact.Save();
                ModifierContactExchangeRet = otlContact.EntryID;
                if (bDejaOuvert == false) { otlApp.Quit(); }
                otlApp = null;
                fraEtatOutlook.Visible = false;
                Application.DoEvents();
                return ModifierContactExchangeRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact\niContactID = " + iContactID, "ModifierContactExchange", ex);
                fraEtatOutlook.Visible = false;
                return null;
            }
        }
        private void SupprimerContactOutlook(int iContactID)
        {
            fraEtatOutlook.Visible = true;
            Recordset rdContact = new Recordset();
            rdContact.Open($"SELECT [NomContact],[Compagnie]  FROM [contact] where IDContact='{iContactID}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            /* ID 0 : NomContact ID 1 : Compagnie*/
            if (!rdContact.EOF)
            {
                string nom = $"{rdContact.Fields[0].Value}";
                string compagnie = $"{rdContact.Fields[1].Value}";
                lblEtatOutlook.Text = $"\\\\Outlook\\{compagnie}\\{nom}";
                if (MessageBox.Show($"Etes vous sur de vouloir supprimer \n{nom} de la compagnie {compagnie}?", Application.ProductName + "." + Name + ".SupprimerContactOutlook", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    object n, m;
                    Recordset rd = new Recordset();
                    rd.Open($"SELECT * FROM [CONTACTCLIENT] " +
                        $"JOIN CLIENT ON [DBO].[CLIENT].IDCLIENT=[DBO].[CONTACTCLIENT].NOCLIENT WHERE [NOCONTACT]='{iContactID}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                    /* ID 0 : no_enreg ID 1 : noclient ID 2 : nocontact ID 3 : IDClient ID 4 : NomClient ID 5 : Compagnie ID 6 : Telephonne ID 7 : Fax ID 8 : Pagette ID 9 : Cellulaire 
                     * ID 10 : ContactGRB ID 11 : Email ID 12 : AdresseLiv ID 13 : VilleLiv ID 14 : Prov/EtatLiv ID 15 : PaysLiv ID 16 : CodePostalLiv ID 17 : noposte ID 18 : Commentaire 
                     * ID 19 : SiteWeb ID 20 : DateCréation ID 21 : UserCréation ID 22 : DateModification ID 23 : UserModification ID 24 : EntryIDOutlook ID 25 : Béton ID 26 : Pavé 
                     * ID 27 : Pharmaceutique ID 28 : Agroalimentaire ID 29 : Meuble ID 30 : Meunerie ID 31 : Manufacturier ID 32 : Autre ID 33 : Consultant ID 34 : Asphalte ID 35 : ICPI 
                     * ID 36 : Potentiel ID 37 : ProduitsChimiques ID 38 : Supprimé ID 39 : NomContact*/
                    if (!rd.EOF)
                    {
                        if(MessageBox.Show($"Un client nommé {rd.Fields[4].Value} coresspond ID {iContactID}\n Voulez vous le supprimer aussi?",$"Suppression recursive pour {iContactID}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                            object mn;
                            odbc.Execute($"DELETE FROM [ContactClient] WHERE {rd.Fields[1].Value}", out mn, -1);
                        }
                    }
                    odbc.Execute($"DELETE FROM [OUTLOOK] WHERE [NOMCONTACT]='{nom}' AND COMPAGNIE='{compagnie}'", out n, -1);
                    odbc.Execute($"DELETE FROM [CONTACT] WHERE [NOMCONTACT]='{nom}' AND COMPAGNIE='{compagnie}'", out m, -1);
                    MessageBox.Show($"{n.ToString()} entrée supprimée dans OUTLOOK\n{m.ToString()} entrée supprimé dans CONTACTS");
                }
            }
            fraEtatOutlook.Visible = false;
        }
        private void cmdCopier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sName;
                bool bAjouter;
                sName = Interaction.InputBox("Veuillez entrer le nom du contact", "SAISIE DU NOM", "Nom du contact");
                if (!string.IsNullOrEmpty(sName))
                {
                    if (ExisteDansBD(sName) == true)
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
                    else if (ContientCaracteresIncorrects(sName) == true)
                    {
                        MessageBox.Show("Il y a des caractères non permis!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bAjouter = false;
                    }
                    else
                    {
                        bAjouter = true;
                    }
                }
                else { bAjouter = false; }
                if (bAjouter == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    AfficherControles(EnumMode.MODE_AJOUT_MODIF);
                    HideEdMask(false);
                    m_bModeAjout = true;
                    txtNomContact.Text = sName;
                    ViderBarrerChamps(false, false);
                    txtCompagnie.Focus();
                    Cursor.Current = Cursors.Default;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "cmdCopier_Click", ex);
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
                AfficherErreur("Contact", "ExisteDansBD", ex);
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
                AfficherErreur("Contact", "ContientCaracteresIncorrects", ex);
                return false;
            }
        }
        private void cmdFax_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbContact.Items.Count > 0)
                {
                    int argiNoContact = m_iNoContact;
                    Rapports r = new Rapports();
                    r.MdiParent = Conteneur.Mdi;
                    Rapports.chkFaxFrancais.Checked = true;
                    Rapports.cmbClient.Text = cmbContact.Text.Split('-')[0];
                    Rapports.cmbContact.Text= cmbContact.Text.Split('-')[1];
                    r.ShowInTaskbar = false;
                    r.ShowIcon = true;
                    r.m_iNoContact = m_iNoContact;
                    r.Text = "Envoyer un fax a ID:"+argiNoContact.ToString();
                    r.Show();
                    m_iNoContact = argiNoContact;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "cmdFax_Click", ex);
            }
        }
        [Obsolete]
        private void cmdMailList_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.MAPIFolder folContact;
                Microsoft.Office.Interop.Outlook.ContactItem itmContact;
                Microsoft.Office.Interop.Outlook.Recipient otlRecipient;
                var bDejaOuvert = default(bool);
                ADODB.Recordset rstContact;
                var sIDContact = default(string);
                var sContact = default(string);
                if (cmbContact.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
                    {
                        sIDContact = cmbContact.Text.Split('-')[2];
                        sContact = cmbContact.Text.Split('-')[0];
                    }
                    if (!string.IsNullOrEmpty(sIDContact))
                    {
                        otlApp = OuvrirOutlook(ref bDejaOuvert);
                        lblEtatOutlook.Text = "Recherche des listes de distribution..";
                        fraEtatOutlook.Visible = true;
                        ChoixMailList f = new ChoixMailList();
                        f.MdiParent = Conteneur.ActiveForm.MdiParent;
                        f.MdiParent = Conteneur.Mdi;
                        f.Show();
                        if (m_bAnnulerDistList == false)
                        {
                            lblEtatOutlook.Text = "Ajout du contact dans la liste de distribution..";
                            fraEtatOutlook.Visible = true;
                            folContact = GetFolder(otlApp, "Contacts GRB");
                            itmContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Find("[User1] = " + sIDContact);
                            if (!(itmContact is null))
                            {
                                otlRecipient = otlApp.Session.CreateRecipient(itmContact.Email1DisplayName);
                                if (otlRecipient.Resolve() == true)
                                {
                                    m_otlDistList.AddMember(otlRecipient);
                                    m_otlDistList.Save();
                                }
                                else
                                {
                                    MessageBox.Show("Impossible de trouver le contact '" + sContact + "' !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Contact '" + sContact + "' introuvable!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                if (Information.Err().Number == 287 & Information.Erl() == 145)
                {
                    MessageBox.Show("La liste de distribution est pleine!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AfficherErreur("Contact", "cmdMailList_Click", ex);
                }
                fraEtatOutlook.Visible = false;
            }
        }
        private void cmdRafraichir_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                RemplirComboContact();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "cmdRafraichir_Click", ex);
            }
        }
        [Obsolete]
        private void cmdreport_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstContact;
                rstContact = new Recordset();
                if (MessageBox.Show("Voulez-vous imprimer ce contact uniquement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstContact.Open("SELECT * FROM Contact WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    Form viewContact = new ViewContactSingle(cmbContact.Text, txtTitre.Text, txtTelDomicile.Text, txtPoste.Text, txtEmail.Text, txtPagette.Text,
                        txtFax.Text, txtCellulaire.Text, txtTelephone.Text, txtCompagnie.Text);
                    viewContact.Text = $"Impression du contact {cmbContact.Text} {IdLoginEmploye}@{Conteneur.ip} {DateTime.Now.ToString()}";
                    viewContact.Show();
                }
                else if (MessageBox.Show("Voulez-vous filtrer par la compagnie '" + txtCompagnie.Text + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstContact.Open($"SELECT COMPAGNIE,NOMCONTACT,  TELEPHONNE, NOPOSTE,PAGETTE,CELLULAIRE, FAX, [E-MAIL] FROM [CONTACT] WHERE [COMPAGNIE] LIKE  '%{txtCompagnie.Text}%' AND SUPPRIMÉ= 0   ORDER BY Compagnie,NOMCONTACT", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    ViewContactEntreprise viewContactEntreprise = new ViewContactEntreprise(txtCompagnie.Text.Replace("'", "''"));
                    ViewContactEntreprise.DataSource = rstContact;
                    viewContactEntreprise.Text = "Liste corssepondant à " + txtCompagnie.Text;
                    viewContactEntreprise.ShowDialog();
                }
                else
                {
                    rstContact.Open("SELECT * FROM Contact WHERE Supprimé = 0 ORDER BY NomContact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                Cursor.Current = Cursors.WaitCursor;
                ControleurServeur.ViewListeContact.DataSource = rstContact;
                rstContact.Close();
                rstContact = null;
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "cmdreport_Click", ex);
            }
        }
        private void AfficherControles(EnumMode eMode)
        {
            try
            {
                var bCmbContact = default(bool);
                var bTxtNomContact = default(bool);
                var bTxtRechercher = default(bool);
                var bCmdAdd = default(bool);
                var bCmdEnr = default(bool);
                var bCmdModif = default(bool);
                var bCmdSupp = default(bool);
                var bCmdAnul = default(bool);
                var bCmdQuit = default(bool);
                bool bCmdRenommer;
                bool bCmdRafraichir;
                var bCmdRechercher = default(bool);
                var bCmdImprimer = default(bool);
                var bCmdCopier = default(bool);
                var bFax = default(bool);
                var bCmdMailList = default(bool);
                switch (eMode)
                {
                    case EnumMode.MODE_AJOUT_MODIF:
                        {
                            bCmdEnr = true;
                            bCmdAnul = true;
                            bTxtNomContact = true; break;
                        }
                    case EnumMode.MODE_INACTIF:
                        {
                            bCmbContact = true;
                            bTxtRechercher = true;
                            bCmdAdd = true;
                            bCmdModif = true;
                            bCmdSupp = true;
                            bCmdQuit = true;
                            bCmdRenommer = true;
                            bCmdRafraichir = true;
                            bCmdImprimer = true;
                            bCmdCopier = true;
                            bFax = true;
                            bCmdMailList = true;
                            if (txtRechercher.Text.Trim().Length > 0)
                            {
                                bCmdRechercher = true;
                            }
                            break;
                        }
                }
                cmbContact.Visible = bCmbContact;
                txtNomContact.Visible = bTxtNomContact;
                txtRechercher.Enabled = bTxtRechercher;
                CmdAdd.Visible = bCmdAdd;
                CmdEnr.Visible = bCmdEnr;
                CmdModif.Visible = bCmdModif;
                CmdSupp.Visible = bCmdSupp;
                CmdAnul.Visible = bCmdAnul;
                CmdQuit.Visible = bCmdQuit;
                cmdRechercher.Enabled = bCmdRechercher;
                cmdreport.Visible = bCmdImprimer;
                cmdCopier.Visible = bCmdCopier;
                cmdFax.Visible = bFax;
                cmdMailList.Visible = bCmdMailList;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "AfficherControles", ex);
            }
        }
        private void CmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sName;
                bool bAjouter;
                sName = Interaction.InputBox("Veuillez entrer le nom du contact\n\nSVP, respectez le bon orthographe!", "SAISIE DU NOM", "Nom du contact");
                if (!string.IsNullOrEmpty(sName))
                {
                    if (ExisteDansBD(sName) == true)
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
                    else if (ContientCaracteresIncorrects(sName) == true)
                    {
                        MessageBox.Show("Il y a des caractères non permis!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bAjouter = false;
                    }
                    else
                    {
                        bAjouter = true;
                    }
                }
                else { bAjouter = false; }
                if (bAjouter == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    m_bModeAjout = true;
                    AfficherControles(EnumMode.MODE_AJOUT_MODIF);
                    HideEdMask(false);
                    txtNomContact.Text = sName;
                    ViderBarrerChamps(false, true);
                    txtCompagnie.Focus();
                    Cursor.Current = Cursors.Default;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "CmdAdd_Click", ex);
            }
        }
        private void ViderBarrerChamps(bool bLocked, bool bVider)
        {
            try
            {
                if (bVider == true)
                {
                    txtCompagnie.Text = string.Empty;
                    txtTelephone.Text = string.Empty;
                    txtTitre.Text = string.Empty;
                    txtPoste.Text = string.Empty;
                    txtFax.Text = string.Empty;
                    txtPagette.Text = string.Empty;
                    txtCellulaire.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtTelDomicile.Text = string.Empty;
                    txtCommentaire.Text = string.Empty;
                    lblDateCreation.Text = string.Empty;
                    lblUserCreation.Text = string.Empty;
                    lblDateModification.Text = string.Empty;
                    lblUserModification.Text = string.Empty;
                }
                txtNomContact.ReadOnly = bLocked;
                txtCompagnie.ReadOnly = bLocked;
                txtTelephone.ReadOnly = bLocked;
                txtTitre.ReadOnly = bLocked;
                txtPoste.ReadOnly = bLocked;
                txtFax.ReadOnly = bLocked;
                txtPagette.ReadOnly = bLocked;
                txtCellulaire.ReadOnly = bLocked;
                txtEmail.ReadOnly = bLocked;
                txtTelDomicile.ReadOnly = bLocked;
                txtCommentaire.ReadOnly = bLocked;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "ViderBarrerChamps", ex);
            }
        }
        /// Patch erreur convertion Dynamic.DBNull en string.empty
        /// PWE 2024-08-06
        private void AfficherContact()
        {
            ViderChamps();
            try
            {
                ADODB.Recordset rd = new ADODB.Recordset();
//                m_iNoContact = int.Parse(cmbContact.Text.Split('-')[2]);
                rd.Open("SELECT * FROM Contact WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                Clipboard.SetText(rd.Source);
                if (!rd.EOF)
                {
                    if (!(rd.Fields["Compagnie"].Value is DBNull)) txtCompagnie.Text = (string)(rd.Fields["Compagnie"].Value);
                    if (!(rd.Fields["Titre"].Value is DBNull)) txtTitre.Text = (string)(rd.Fields["Titre"].Value);
                    if (!(rd.Fields["Telephonne"].Value is DBNull)) txtTelephone.Text = (string)(rd.Fields["Telephonne"].Value);
                    if (!(rd.Fields["noPoste"].Value is DBNull)) txtPoste.Text = (string)(rd.Fields["noPoste"].Value);
                    if (!(rd.Fields["Fax"].Value is DBNull)) { txtFax.Text = (string)(rd.Fields["Fax"].Value); cmdFax.Enabled = true; } else { cmdFax.Enabled = false; }
                    if (!(rd.Fields["Pagette"].Value is DBNull)) txtPagette.Text = (string)(rd.Fields["Pagette"].Value);
                    if (!(rd.Fields["Cellulaire"].Value is DBNull)) txtCellulaire.Text = (string)(rd.Fields["Cellulaire"].Value);
                    if (!(rd.Fields["teldomicile"].Value is DBNull)) txtTelDomicile.Text = (string)(rd.Fields["teldomicile"].Value);
                    if (!(rd.Fields["E-mail"].Value is DBNull)) { txtEmail.Text = (string)(rd.Fields["E-mail"].Value); cmdMailList.Enabled = true; } else { cmdMailList.Enabled =false ;}
                    if (!(rd.Fields["Commentaire"].Value is DBNull)) txtCommentaire.Text = (string)(rd.Fields["Commentaire"].Value);
                    if (!(rd.Fields["DateCréation"].Value is DBNull)) lblDateCreation.Text = (string)(rd.Fields["DateCréation"].Value);
                    if (!(rd.Fields["UserCréation"].Value is DBNull)) lblUserCreation.Text = $"Par : {rd.Fields["UserCréation"].Value}";
                    if (!(rd.Fields["DateModification"].Value is DBNull)) lblDateModification.Text = (string)(rd.Fields["DateModification"].Value);
                    if (!(rd.Fields["UserModification"].Value is DBNull)) lblUserModification.Text = $"Par : {rd.Fields["UserModification"].Value}";
                }
                rd.Close();
                rd = null;
                    //correction paradoxe modifier si inexistant
                if (lblDateCreation.Text == "" & lblDateModification.Text != "") CorrigerParadoxeDates();
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "AfficherContact", ex);
            }
        }
        private void CorrigerParadoxeDates()
        {
            ADODB.Recordset rd = new ADODB.Recordset();
            rd.Open("SELECT * FROM Contact WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            if (lblDateCreation.Text == "" & lblDateModification.Text != "")
            {
                lblDateCreation.Text = lblDateModification.Text;
                lblUserCreation.Text = lblUserModification.Text;
                if (!rd.EOF) { 
                    rd.Fields["UserCréation"].Value = lblUserModification.Text.Replace("Par : ", string.Empty);
                    rd.Fields["DateCréation"].Value = lblDateModification.Text;
                    rd.Fields["DateModification"].Value = DateTime.Now.ToShortDateString();
                    rd.Fields["UserModification"].Value = Conteneur.idInitiales.Text;
                    rd.Fields["Commentaire"].Value = $"{Application.ProductName}.SQlTracker.Erreur.DateIncorecte{Name}\nCorrection paradoxe modifier si inexistant";
                    rd.Update();
                }
            }
            rd.Close();
            rd = null;
        }
        private void HideEdMask(bool bVisible)
        {
            try
            {
                if (m_bModeAjout == true)
                {
                    txtTelephone.Text = string.Empty;
                    txtCellulaire.Text = string.Empty;
                    txtPagette.Text = string.Empty;
                    txtFax.Text = string.Empty;
                    txtTelDomicile.Text = string.Empty;
                    mskTelephone.Text = string.Empty;
                    mskCellulaire.Text = string.Empty;
                    mskPagette.Text = string.Empty;
                    mskFax.Text = string.Empty;
                    mskTelDomicile.Text = string.Empty;
                }
                else
                {
                    mskTelephone.Text = txtTelephone.Text;
                    mskCellulaire.Text = txtCellulaire.Text;
                    mskPagette.Text = txtPagette.Text;
                    mskFax.Text = txtFax.Text;
                    mskTelDomicile.Text = txtTelDomicile.Text;
                }
                mskTelephone.Visible = !bVisible;
                mskCellulaire.Visible = !bVisible;
                mskPagette.Visible = !bVisible;
                mskFax.Visible = !bVisible;
                mskTelDomicile.Visible = !bVisible;
                txtTelephone.Visible = bVisible;
                txtCellulaire.Visible = bVisible;
                txtPagette.Visible = bVisible;
                txtFax.Visible = bVisible;
                txtTelDomicile.Visible = bVisible;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "HideEdMask", ex);
            }
        }
        [Obsolete]
        private void CmdAnul_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                HideEdMask(true);
                m_bModeAjout = false;
                AfficherControles(EnumMode.MODE_INACTIF);
                cmbContact_SelectedIndexChanged(cmbContact, new EventArgs());
                ViderBarrerChamps(true, true);
                cmbContact_SelectedIndexChanged(cmbContact, new EventArgs());
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "CmdAnul_Click", ex);
            }
        }
        [Obsolete]
        private void CmdEnr_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sContact;
                bool bSave;
                sContact = txtNomContact.Text;
                if (string.IsNullOrEmpty(Strings.Trim(txtNomContact.Text)) | string.IsNullOrEmpty(txtCompagnie.Text.Trim()))
                {
                    MessageBox.Show("Le nom du contact et la compagnie sont obligatoires!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bSave = false;
                }
                else if (m_bModeAjout == true)
                {
                    bSave = true;
                }
                else if ((Gauche(cmbContact.Text, Strings.InStr(1, cmbContact.Text, " - ") - 1).Trim() ?? "") == (txtNomContact.Text ?? ""))
                {
                    bSave = true;
                }
                else if (ExisteDansBD(txtNomContact.Text) == true)
                {
                    if (MessageBox.Show("Il y a déjà un contact portant ce nom!\n\nVoulez-vous l'ajouter quand même?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bSave = true;
                    }
                    else
                    {
                        bSave = false;
                    }
                }
                else { bSave = true; }
                if (bSave == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    EnregistrerContact();
                    HideEdMask(true);
                    RemplirComboContact();
                    AfficherControles(EnumMode.MODE_INACTIF);
                    for (int X = 0; X <= (cmbContact.Items.Count - 1); X++)
                    {
                        if ((cmbContact.Items[X].ToString().Split('-')[0] ?? "") == (sContact ?? "")) { cmbContact.SelectedIndex = X; break; }
                    }
                    cmbContact.Focus();
                    ViderBarrerChamps(true, false);
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "CmdEnr_Click", ex);
            }
        }
        private void CmdModif_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbContact.Items.Count > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    HideEdMask(false);
                    AfficherControles(EnumMode.MODE_AJOUT_MODIF);
                    ViderBarrerChamps(false, false);
                    txtCompagnie.Focus();
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
                AfficherErreur("Contact", "CmdModif_Click", ex);
            }
        }
        private void cmdquit_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "cmdquit_Click", ex);
            }
        }
        private void CmdSupp_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstContact;
                ADODB.Recordset rstLiaison;
                var bPeutEffacer = default(bool);
                if (cmbContact.Items.Count > 0)
                {
                    if (MessageBox.Show("Etes-vous sur de supprimer cette enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        rstProjSoum = new Recordset();
                        rstProjSoum.Open("SELECT * FROM SoumissionMec WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstProjSoum.EOF)
                        {
                            rstProjSoum.Close();
                            rstProjSoum.Open("SELECT * FROM ProjetMec WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (rstProjSoum.EOF)
                            {
                                rstProjSoum.Close();
                                rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (rstProjSoum.EOF)
                                {
                                    rstProjSoum.Close();
                                    rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                    if (rstProjSoum.EOF)
                                    {
                                        bPeutEffacer = true;
                                        rstProjSoum.Close();
                                        rstProjSoum = null;
                                    }
                                    else
                                    {
                                        bPeutEffacer = false;
                                        rstProjSoum.Close();
                                        rstProjSoum = null;
                                    }
                                }
                                else
                                {
                                    bPeutEffacer = false;
                                    rstProjSoum.Close();
                                    rstProjSoum = null;
                                }
                            }
                            else
                            {
                                bPeutEffacer = false;
                                rstProjSoum.Close();
                                rstProjSoum = null;
                            }
                        }
                        else
                        {
                            bPeutEffacer = false;
                            rstProjSoum.Close();
                            rstProjSoum = null;
                        }
                    }
                    SupprimerContactOutlook(m_iNoContact);
                    if (bPeutEffacer == true)
                    {
                        UpdateSQL("DELETE FROM Contact WHERE IDContact = " + m_iNoContact);
                    }
                    else
                    {
                        rstContact = new Recordset();
                        rstContact.Open("SELECT * FROM Contact WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstContact.Fields["Supprimé"].Value = true;
                        rstContact.Update();
                        rstContact.Close();
                        rstContact = null;
                    }
                    rstLiaison = new Recordset();
                    rstLiaison.Open("SELECT * FROM ContactClient WHERE NoContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstLiaison.EOF)
                    {
                        while (!rstLiaison.EOF)
                        {
                            rstLiaison.Delete();
                            rstLiaison.MoveNext();
                        }
                    }
                    rstLiaison.Close();
                    rstLiaison.Open("SELECT * FROM ContactFRS WHERE NoContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstLiaison.EOF)
                    {
                        while (!rstLiaison.EOF)
                        {
                            rstLiaison.Delete();
                            rstLiaison.MoveNext();
                        }
                    }
                    rstLiaison.Close();
                    rstLiaison = null;
                    RemplirComboContact();
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
                AfficherErreur("Contact", "CmdSupp_Click", ex);
            }
        }
        private void LierContactClient(int iContactID, int iClientID)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application otlApp;
                Microsoft.Office.Interop.Outlook.ContactItem itmContact;
                Microsoft.Office.Interop.Outlook.ContactItem itmClient;
                Microsoft.Office.Interop.Outlook.MAPIFolder folClient;
                Microsoft.Office.Interop.Outlook.MAPIFolder folContact;
                ADODB.Recordset rstContactClient;
                ADODB.Recordset rstClient;
                var bDejaOuvert = default(bool);
                int X;
                otlApp = OuvrirOutlook(ref bDejaOuvert);
                folClient = GetFolder(otlApp, "Clients GRB");
                folContact = GetFolder(otlApp, "Contacts GRB");
                rstClient = new Recordset();
                rstClient.Open("SELECT EntryIDOutlook FROM Client WHERE IDClient = " + iClientID, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                itmClient = (Microsoft.Office.Interop.Outlook.ContactItem)folClient.Items.Find("[User1] = " + iClientID);
                if (!(itmClient is null))
                {
                    while (itmClient.Links.Count > 0)
                    {
                        itmContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Find((string)(Operators.ConcatenateObject("[User1] = ", ((dynamic)itmClient.Links[1].Item).User1)));
                        var loopTo = (int)itmContact.Links.Count;
                        for (X = 1; X <= loopTo; X++)
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(((dynamic)itmContact.Links[1].Item).User1, itmClient.User1, false)))
                            {
                                itmContact.Links.Remove(X);
                                itmContact.Save();
                                break;
                            }
                        }
                        itmClient.Links.Remove(1);
                    }
                    itmClient.Save();
                    rstClient.Close();
                    rstClient = null;
                    rstContactClient = new Recordset();
                    rstContactClient.Open("SELECT * FROM ContactClient WHERE NoClient = " + iClientID, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    while (!rstContactClient.EOF)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstContactClient.Fields["NoContact"].Value, iContactID, false)))
                        {
                            itmContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Find((string)(Operators.ConcatenateObject("[User1] = ", rstContactClient.Fields["NoContact"].Value)));
                            if (!(itmContact is null))
                            {
                                itmClient.Links.Add(itmContact);
                                itmClient.Save();
                                itmContact.Links.Add(itmClient);
                                itmContact.Save();
                            }
                        }
                        rstContactClient.MoveNext();
                    }
                    rstContactClient.Close();
                    rstContactClient = null;
                }
                else
                {
                    MessageBox.Show("Client introuvable!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rstClient.Close();
                    rstClient = null;
                }
                if (bDejaOuvert == false)
                {
                    otlApp.Quit();
                }
                otlApp = null;
                Application.DoEvents();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Client", "LierContactClient", ex);
                fraEtatOutlook.Visible = false;
            }
        }
        private void LierContactFournisseur(int iContactID, int iFournisseurID)
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
                fraEtatOutlook.Visible = true;
                otlApp = OuvrirOutlook(ref bDejaOuvert);
                folFRS = GetFolder(otlApp, "Fournisseurs GRB");
                folContact = GetFolder(otlApp, "Contacts GRB");
                rstFRS = new Recordset();
                rstFRS.Open("SELECT EntryIDOutlook FROM Fournisseur WHERE IDFRS = " + iFournisseurID, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
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
                    rstContactFRS.Open("SELECT * FROM ContactFRS WHERE NoFRS = " + iFournisseurID, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    while (!rstContactFRS.EOF)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstContactFRS.Fields["NoContact"].Value, iContactID, false)))
                        {
                            itmContact = (Microsoft.Office.Interop.Outlook.ContactItem)folContact.Items.Find((string)(Operators.ConcatenateObject("[User1] = ", rstContactFRS.Fields["NoContact"].Value)));
                            if (!(itmContact is null))
                            {
                                itmFRS.Links.Add(itmContact);
                                itmFRS.Save();
                                itmContact.Links.Add(itmFRS);
                                itmContact.Save();
                            }
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
                if (bDejaOuvert == false)
                {
                    otlApp.Quit();
                }
                otlApp = null;
                fraEtatOutlook.Visible = false;
                Application.DoEvents();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Fournisseurs", "LierContactFournisseur", ex);
                fraEtatOutlook.Visible = false;
            }
        }
        /// Split id depuis le selecteur de contact
        /// index 2 dans la matrice d'affichachage
        /// PWE 2024-06-08
        public void cmbContact_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbContact.Text))
                {
                    txtNomContact.Text = cts[cmbContact.SelectedIndex].NomContact;
                }
                else { cmbContact.Text = txtNomContact.Text; }
                if (cmbContact.SelectedIndex > -1)
                {
                    if (m_bRenommer == false & m_bModeAjout == false)
                    {
                            m_iNoContact = cts[cmbContact.SelectedIndex].IdContact;
                    }
                }
                AfficherContact();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "cmbContact_Click", ex);
            }
        }
        private void Contact_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            ViderChamps();
            try
            {
                RemplirComboContact();
                HideEdMask(true);
                AfficherControles(EnumMode.MODE_INACTIF);
                ActiverBoutonsGroupe();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "Form_Load", ex);
            }
        }
        private void ViderChamps()
        {
            txtCompagnie.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtTitre.Text = string.Empty;
            txtPoste.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtPagette.Text = string.Empty;
            txtCellulaire.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelDomicile.Text = string.Empty;
            txtCommentaire.Text = string.Empty;
            lblDateCreation.Text = string.Empty;
            lblUserCreation.Text = string.Empty;
            lblDateModification.Text = string.Empty;
            lblUserModification.Text = string.Empty;
        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
                CmdAdd.Enabled = g_bModificationContacts;
                CmdModif.Enabled = g_bModificationContacts;
                CmdSupp.Enabled = g_bModificationContacts;
                cmdCopier.Enabled = g_bModificationContacts;
                cmdMailList.Enabled = g_bModificationListeDistribution;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "ActiverBoutonsGroupe", ex);
            }
        }
        private void Contact_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "Form_Unload", ex);
            }
        }
        private void mskTelephone_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskTelephone.Mask = "(###) ###-####";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskTelephone_GotFocus", ex);
            }
        }
        private void mskTelephone_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskTelephone.Mask = string.Empty;
                if (mskTelephone.Text == "(___) ___-____")
                {
                    mskTelephone.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskTelephone_LostFocus", ex);
            }
        }
        private void mskCellulaire_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskCellulaire.Mask = "(###) ###-####";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskCellulaire_GotFocus", ex);
            }
        }
        private void mskCellulaire_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskCellulaire.Mask = string.Empty;
                if (mskCellulaire.Text == "(___) ___-____")
                {
                    mskCellulaire.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskCellulaire_LostFocus", ex);
            }
        }
        private void mskFax_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskFax.Mask = "(###) ###-####";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskFax_GotFocus", ex);
            }
        }
        private void mskFax_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskFax.Mask = string.Empty;
                if (mskFax.Text == "(___) ___-____")
                {
                    mskFax.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskFax_LostFocus", ex);
            }
        }
        private void mskPagette_Enter(object eventSender, EventArgs eventArgs)
        {
            try { mskPagette.Mask = "(###) ###-####"; return; }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskPagette_GotFocus", ex);
            }
        }
        private void mskPagette_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskPagette.Mask = string.Empty;
                if (mskPagette.Text == "(___) ___-____") { mskPagette.Text = string.Empty; }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskPagette_LostFocus", ex);
            }
        }
        private void mskTelDomicile_Enter(object eventSender, EventArgs eventArgs)
        {
            try { mskTelDomicile.Mask = "(###) ###-####"; return; }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskTelDomicile_GotFocus", ex);
            }
        }
        private void mskTelDomicile_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskTelDomicile.Mask = string.Empty;
                if (mskTelDomicile.Text == "(___) ___-____") { mskTelDomicile.Text = string.Empty; }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "mskTelDomicile_LostFocus", ex);
            }
        }
        /// PWE 2024-05-17
        /// utilisattion Request like plutot que Distinct strict
        /// pour compenser les fautes d'ecriture des utilisateurs
        private void cmdRechercher_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstContact;
                string sSearch;
                sSearch = txtRechercher.Text;
                Cursor.Current = Cursors.WaitCursor;
                ViderBarrerChamps(true, true);
                rstContact = new Recordset();
                rstContact.Open("SELECT NomContact, Compagnie, IDContact FROM Contact WHERE NomContact like '%" + sSearch.Replace("'", "''") + "%' Or  Compagnie like  '%" + Strings.Replace(sSearch, "'", "''") + "%' AND Supprimé = 0 ORDER BY NomContact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbContact.Items.Clear();
                while (!rstContact.EOF)
                {
                    cmbContact.Items.Add($"{rstContact.Fields["Compagnie"].Value} - {rstContact.Fields["NomContact"].Value} - {rstContact.Fields["IDContact"].Value}");
                    rstContact.MoveNext();
                }
                rstContact.Close();
                rstContact = null;
                Cursor.Current = Cursors.Default;
                if (cmbContact.Items.Count > 0)
                {
                    cmbContact.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "cmdRechercher_Click", ex);
            }
        }
        private void txtRechercher_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (txtRechercher.Text.Trim().Length > 0) { cmdRechercher.Enabled = true; } else { cmdRechercher.Enabled = false; }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Contact", "txtRechercher_Change", ex);
            }
        }
    }
}