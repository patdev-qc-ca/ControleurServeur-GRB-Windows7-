using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ControleurServeur;
using ADODB;
using System.Diagnostics;
using System.Web.UI.WebControls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using Stripe.Climate;
using Stripe;
using Application = System.Windows.Forms.Application;
using System.ComponentModel;
using System.Collections.Generic;
#pragma warning disable CS0168
#pragma warning disable CS0219
namespace ControleurServeur
{
    internal class BonCommande : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public BonCommande() : base()
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
        internal static DateTimePicker txtDateRequise;
        internal static System.Windows.Forms.TextBox txtTotal;
        internal static System.Windows.Forms.TextBox txtCommentaire;
        internal static System.Windows.Forms.Button cmdInstructions;
        internal static System.Windows.Forms.Button cmdImprimer;
        internal static System.Windows.Forms.Button cmdFermer;
        internal static System.Windows.Forms.CheckBox chkAfficherInstructions;
        internal static System.Windows.Forms.RadioButton _optImpression_1;
        internal static System.Windows.Forms.RadioButton _optImpression_0;
        internal static GroupBox fraImpression;
        internal static System.Windows.Forms.TextBox txtComPar;
        internal static System.Windows.Forms.TextBox txtDate;
        internal static System.Windows.Forms.TextBox txtNoBC;
        internal static System.Windows.Forms.TextBox txtFax;
        internal static System.Windows.Forms.TextBox txtTelephone;
        internal static System.Windows.Forms.TextBox txtVotreNoSoum;
        internal static System.Windows.Forms.TextBox txtTransport;
        internal static ComboBox cmbContact;
        internal static ComboBox cmbFournisseur;
        internal static System.Windows.Forms.ListView lvwBonCommande;
        internal static System.Windows.Forms.Label Label12;
        internal static System.Windows.Forms.Label Label11;
        internal static System.Windows.Forms.Label Label10;
        internal static System.Windows.Forms.Label Label9;
        internal static System.Windows.Forms.Label lblNoBC;
        internal static System.Windows.Forms.Label Label7;
        internal static System.Windows.Forms.Label Label6;
        internal static System.Windows.Forms.Label lblVotreNoSoum;
        internal static System.Windows.Forms.Label Label4;
        internal static System.Windows.Forms.Label Label3;
        internal static System.Windows.Forms.Label Label2;
        internal static System.Windows.Forms.Label Label1;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            txtDateRequise = new System.Windows.Forms.DateTimePicker();
            txtTotal = new System.Windows.Forms.TextBox();
            txtCommentaire = new System.Windows.Forms.TextBox();
            cmdInstructions = new System.Windows.Forms.Button();
            cmdImprimer = new System.Windows.Forms.Button();
            cmdFermer = new System.Windows.Forms.Button();
            chkAfficherInstructions = new System.Windows.Forms.CheckBox();
            fraImpression = new System.Windows.Forms.GroupBox();
            _optImpression_1 = new System.Windows.Forms.RadioButton();
            _optImpression_0 = new System.Windows.Forms.RadioButton();
            txtComPar = new System.Windows.Forms.TextBox();
            txtDate = new System.Windows.Forms.TextBox();
            txtNoBC = new System.Windows.Forms.TextBox();
            txtFax = new System.Windows.Forms.TextBox();
            txtTelephone = new System.Windows.Forms.TextBox();
            txtVotreNoSoum = new System.Windows.Forms.TextBox();
            txtTransport = new System.Windows.Forms.TextBox();
            cmbContact = new System.Windows.Forms.ComboBox();
            cmbFournisseur = new System.Windows.Forms.ComboBox();
            lvwBonCommande = new System.Windows.Forms.ListView();
            Label12 = new System.Windows.Forms.Label();
            Label11 = new System.Windows.Forms.Label();
            Label10 = new System.Windows.Forms.Label();
            Label9 = new System.Windows.Forms.Label();
            lblNoBC = new System.Windows.Forms.Label();
            Label7 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            lblVotreNoSoum = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            fraImpression.SuspendLayout();
            SuspendLayout();
/*ToolTip1*/
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;
/*txtDateRequise*/
            txtDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDateRequise.Location = new System.Drawing.Point(93, 162);
            txtDateRequise.Name = "txtDateRequise";
            txtDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDateRequise.Size = new System.Drawing.Size(176, 20);
            txtDateRequise.TabIndex = 1;
            txtDateRequise.Visible = false;
/*txtTotal*/
            txtTotal.AcceptsReturn = true;
            txtTotal.BackColor = System.Drawing.Color.Black;
            txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTotal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTotal.ForeColor = System.Drawing.Color.White;
            txtTotal.Location = new System.Drawing.Point(694, 489);
            txtTotal.MaxLength = 0;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTotal.Size = new System.Drawing.Size(65, 20);
            txtTotal.TabIndex = 29;
/*txtCommentaire*/
            txtCommentaire.AcceptsReturn = true;
            txtCommentaire.BackColor = System.Drawing.Color.Black;
            txtCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtCommentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCommentaire.ForeColor = System.Drawing.Color.White;
            txtCommentaire.Location = new System.Drawing.Point(12, 489);
            txtCommentaire.MaxLength = 0;
            txtCommentaire.Multiline = true;
            txtCommentaire.Name = "txtCommentaire";
            txtCommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCommentaire.Size = new System.Drawing.Size(545, 75);
            txtCommentaire.TabIndex = 31;
            txtCommentaire.Text = "Text1";
/*cmdInstructions*/
            cmdInstructions.BackColor = System.Drawing.Color.Black;
            cmdInstructions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdInstructions.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdInstructions.ForeColor = System.Drawing.Color.White;
            cmdInstructions.Location = new System.Drawing.Point(310, 165);
            cmdInstructions.Name = "cmdInstructions";
            cmdInstructions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdInstructions.Size = new System.Drawing.Size(121, 25);
            cmdInstructions.TabIndex = 26;
            cmdInstructions.Text = "Modifier US Letter";
            cmdInstructions.UseVisualStyleBackColor = true;
            cmdInstructions.Click += new System.EventHandler(cmdInstructions_Click);
/*cmdImprimer*/
            cmdImprimer.BackColor = System.Drawing.Color.Black;
            cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdImprimer.ForeColor = System.Drawing.Color.White;
            cmdImprimer.Location = new System.Drawing.Point(590, 539);
            cmdImprimer.Name = "cmdImprimer";
            cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdImprimer.Size = new System.Drawing.Size(81, 25);
            cmdImprimer.TabIndex = 32;
            cmdImprimer.Text = "Imprimer";
            cmdImprimer.UseVisualStyleBackColor = true;
            cmdImprimer.Click += new System.EventHandler(cmdImprimer_Click);
/*cmdFermer*/
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.White;
            cmdFermer.Location = new System.Drawing.Point(678, 539);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(81, 25);
            cmdFermer.TabIndex = 33;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(Cmdfermer_Click);
/*chkAfficherInstructions*/
            chkAfficherInstructions.AutoSize = true;
            chkAfficherInstructions.BackColor = System.Drawing.Color.Black;
            chkAfficherInstructions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkAfficherInstructions.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkAfficherInstructions.ForeColor = System.Drawing.Color.White;
            chkAfficherInstructions.Location = new System.Drawing.Point(520, 165);
            chkAfficherInstructions.Name = "chkAfficherInstructions";
            chkAfficherInstructions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkAfficherInstructions.Size = new System.Drawing.Size(197, 18);
            chkAfficherInstructions.TabIndex = 22;
            chkAfficherInstructions.Text = "Afficher les instructions de livraison";
            chkAfficherInstructions.UseVisualStyleBackColor = true;
/*fraImpression*/
            fraImpression.BackColor = System.Drawing.Color.Black;
            fraImpression.Controls.Add(_optImpression_1);
            fraImpression.Controls.Add(_optImpression_0);
            fraImpression.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraImpression.ForeColor = System.Drawing.Color.White;
            fraImpression.Location = new System.Drawing.Point(520, 98);
            fraImpression.Name = "fraImpression";
            fraImpression.Padding = new System.Windows.Forms.Padding(0);
            fraImpression.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraImpression.Size = new System.Drawing.Size(239, 53);
            fraImpression.TabIndex = 23;
            fraImpression.TabStop = false;
            fraImpression.Text = "Impression";
/*_optImpression_1*/
            _optImpression_1.AutoSize = true;
            _optImpression_1.BackColor = System.Drawing.Color.Black;
            _optImpression_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            _optImpression_1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _optImpression_1.ForeColor = System.Drawing.Color.White;
            _optImpression_1.Location = new System.Drawing.Point(154, 20);
            _optImpression_1.Name = "_optImpression_1";
            _optImpression_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _optImpression_1.Size = new System.Drawing.Size(60, 18);
            _optImpression_1.TabIndex = 25;
            _optImpression_1.TabStop = true;
            _optImpression_1.Text = "Anglais";
            _optImpression_1.UseVisualStyleBackColor = true;
/*_optImpression_0*/
            _optImpression_0.AutoSize = true;
            _optImpression_0.BackColor = System.Drawing.Color.Black;
            _optImpression_0.Checked = true;
            _optImpression_0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            _optImpression_0.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _optImpression_0.ForeColor = System.Drawing.Color.White;
            _optImpression_0.Location = new System.Drawing.Point(83, 20);
            _optImpression_0.Name = "_optImpression_0";
            _optImpression_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _optImpression_0.Size = new System.Drawing.Size(66, 18);
            _optImpression_0.TabIndex = 24;
            _optImpression_0.TabStop = true;
            _optImpression_0.Text = "Français";
            _optImpression_0.UseVisualStyleBackColor = true;
/*txtComPar*/
            txtComPar.AcceptsReturn = true;
            txtComPar.BackColor = System.Drawing.Color.Black;
            txtComPar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtComPar.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtComPar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtComPar.ForeColor = System.Drawing.Color.White;
            txtComPar.Location = new System.Drawing.Point(534, 69);
            txtComPar.MaxLength = 0;
            txtComPar.Name = "txtComPar";
            txtComPar.ReadOnly = true;
            txtComPar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtComPar.Size = new System.Drawing.Size(225, 20);
            txtComPar.TabIndex = 18;
/*txtDate*/
            txtDate.AcceptsReturn = true;
            txtDate.BackColor = System.Drawing.Color.Black;
            txtDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDate.ForeColor = System.Drawing.Color.White;
            txtDate.Location = new System.Drawing.Point(524, 42);
            txtDate.MaxLength = 0;
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDate.Size = new System.Drawing.Size(121, 20);
            txtDate.TabIndex = 12;
/*txtNoBC*/
            txtNoBC.AcceptsReturn = true;
            txtNoBC.BackColor = System.Drawing.Color.Black;
            txtNoBC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtNoBC.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoBC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNoBC.ForeColor = System.Drawing.Color.White;
            txtNoBC.Location = new System.Drawing.Point(524, 13);
            txtNoBC.MaxLength = 0;
            txtNoBC.Name = "txtNoBC";
            txtNoBC.ReadOnly = true;
            txtNoBC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoBC.Size = new System.Drawing.Size(121, 20);
            txtNoBC.TabIndex = 6;
/*txtFax*/
            txtFax.AcceptsReturn = true;
            txtFax.BackColor = System.Drawing.Color.Black;
            txtFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtFax.ForeColor = System.Drawing.Color.White;
            txtFax.Location = new System.Drawing.Point(348, 130);
            txtFax.MaxLength = 0;
            txtFax.Name = "txtFax";
            txtFax.ReadOnly = true;
            txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtFax.Size = new System.Drawing.Size(121, 20);
            txtFax.TabIndex = 16;
/*txtTelephone*/
            txtTelephone.AcceptsReturn = true;
            txtTelephone.BackColor = System.Drawing.Color.Black;
            txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTelephone.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTelephone.ForeColor = System.Drawing.Color.White;
            txtTelephone.Location = new System.Drawing.Point(348, 98);
            txtTelephone.MaxLength = 0;
            txtTelephone.Name = "txtTelephone";
            txtTelephone.ReadOnly = true;
            txtTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTelephone.Size = new System.Drawing.Size(121, 20);
            txtTelephone.TabIndex = 10;
/*txtVotreNoSoum*/
            txtVotreNoSoum.AcceptsReturn = true;
            txtVotreNoSoum.BackColor = System.Drawing.Color.Black;
            txtVotreNoSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtVotreNoSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtVotreNoSoum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtVotreNoSoum.ForeColor = System.Drawing.Color.White;
            txtVotreNoSoum.Location = new System.Drawing.Point(345, 12);
            txtVotreNoSoum.MaxLength = 0;
            txtVotreNoSoum.Name = "txtVotreNoSoum";
            txtVotreNoSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtVotreNoSoum.Size = new System.Drawing.Size(121, 20);
            txtVotreNoSoum.TabIndex = 4;
/*txtTransport*/
            txtTransport.AcceptsReturn = true;
            txtTransport.BackColor = System.Drawing.Color.Black;
            txtTransport.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTransport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTransport.ForeColor = System.Drawing.Color.White;
            txtTransport.Location = new System.Drawing.Point(88, 130);
            txtTransport.MaxLength = 0;
            txtTransport.Name = "txtTransport";
            txtTransport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTransport.Size = new System.Drawing.Size(181, 20);
            txtTransport.TabIndex = 14;
/*cmbContact*/
            cmbContact.BackColor = System.Drawing.Color.Black;
            cmbContact.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbContact.ForeColor = System.Drawing.Color.White;
            cmbContact.Location = new System.Drawing.Point(88, 98);
            cmbContact.Name = "cmbContact";
            cmbContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbContact.Size = new System.Drawing.Size(181, 22);
            cmbContact.TabIndex = 8;
            cmbContact.SelectedIndexChanged += new System.EventHandler(cmbContact_SelectedIndexChanged);
/*cmbFournisseur*/
            cmbFournisseur.BackColor = System.Drawing.Color.Black;
            cmbFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbFournisseur.ForeColor = System.Drawing.Color.White;
            cmbFournisseur.Location = new System.Drawing.Point(88, 66);
            cmbFournisseur.Name = "cmbFournisseur";
            cmbFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbFournisseur.Size = new System.Drawing.Size(343, 22);
            cmbFournisseur.TabIndex = 2;
            cmbFournisseur.SelectedIndexChanged += new System.EventHandler(cmbFournisseur_SelectedIndexChanged);
/*lvwBonCommande*/
            lvwBonCommande.BackColor = System.Drawing.Color.Black;
            lvwBonCommande.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwBonCommande.ForeColor = System.Drawing.Color.White;
            lvwBonCommande.HideSelection = false;
            lvwBonCommande.Location = new System.Drawing.Point(12, 209);
            lvwBonCommande.Name = "lvwBonCommande";
            lvwBonCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lvwBonCommande.Size = new System.Drawing.Size(747, 257);
            lvwBonCommande.TabIndex = 27;
            lvwBonCommande.UseCompatibleStateImageBehavior = false;
/*Label12*/
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.Black;
            Label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label12.ForeColor = System.Drawing.Color.White;
            Label12.Location = new System.Drawing.Point(640, 492);
            Label12.Name = "Label12";
            Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label12.Size = new System.Drawing.Size(46, 14);
            Label12.TabIndex = 30;
            Label12.Text = "TOTAL :";
/*Label11*/
            Label11.AutoSize = true;
            Label11.BackColor = System.Drawing.Color.Black;
            Label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label11.ForeColor = System.Drawing.Color.White;
            Label11.Location = new System.Drawing.Point(12, 473);
            Label11.Name = "Label11";
            Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label11.Size = new System.Drawing.Size(81, 14);
            Label11.TabIndex = 28;
            Label11.Text = "Commentaires :";
/*Label10*/
            Label10.AutoSize = true;
            Label10.BackColor = System.Drawing.Color.Black;
            Label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label10.ForeColor = System.Drawing.Color.White;
            Label10.Location = new System.Drawing.Point(448, 72);
            Label10.Name = "Label10";
            Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label10.Size = new System.Drawing.Size(85, 14);
            Label10.TabIndex = 17;
            Label10.Text = "Commandé par :";
            Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*Label9*/
            Label9.AutoSize = true;
            Label9.BackColor = System.Drawing.Color.Black;
            Label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label9.ForeColor = System.Drawing.Color.White;
            Label9.Location = new System.Drawing.Point(483, 44);
            Label9.Name = "Label9";
            Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label9.Size = new System.Drawing.Size(35, 14);
            Label9.TabIndex = 11;
            Label9.Text = "Date :";
            Label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*lblNoBC*/
            lblNoBC.AutoSize = true;
            lblNoBC.BackColor = System.Drawing.Color.Black;
            lblNoBC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoBC.ForeColor = System.Drawing.Color.White;
            lblNoBC.Location = new System.Drawing.Point(483, 15);
            lblNoBC.Name = "lblNoBC";
            lblNoBC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNoBC.Size = new System.Drawing.Size(36, 14);
            lblNoBC.TabIndex = 5;
            lblNoBC.Text = "# BC :";
            lblNoBC.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*Label7*/
            Label7.AutoSize = true;
            Label7.BackColor = System.Drawing.Color.Black;
            Label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label7.ForeColor = System.Drawing.Color.White;
            Label7.Location = new System.Drawing.Point(288, 133);
            Label7.Name = "Label7";
            Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label7.Size = new System.Drawing.Size(31, 14);
            Label7.TabIndex = 15;
            Label7.Text = "Fax :";
            Label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*Label6*/
            Label6.AutoSize = true;
            Label6.BackColor = System.Drawing.Color.Black;
            Label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label6.ForeColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(288, 101);
            Label6.Name = "Label6";
            Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label6.Size = new System.Drawing.Size(63, 14);
            Label6.TabIndex = 9;
            Label6.Text = "Téléphone :";
            Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*lblVotreNoSoum*/
            lblVotreNoSoum.AutoSize = true;
            lblVotreNoSoum.BackColor = System.Drawing.Color.Black;
            lblVotreNoSoum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblVotreNoSoum.ForeColor = System.Drawing.Color.White;
            lblVotreNoSoum.Location = new System.Drawing.Point(259, 15);
            lblVotreNoSoum.Name = "lblVotreNoSoum";
            lblVotreNoSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblVotreNoSoum.Size = new System.Drawing.Size(78, 14);
            lblVotreNoSoum.TabIndex = 3;
            lblVotreNoSoum.Text = "Votre # Soum :";
            lblVotreNoSoum.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*Label4*/
            Label4.AutoSize = true;
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(10, 165);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(77, 14);
            Label4.TabIndex = 19;
            Label4.Text = "Date Requise :";
            Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*Label3*/
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(10, 133);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(60, 14);
            Label3.TabIndex = 13;
            Label3.Text = "Transport :";
            Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*Label2*/
            Label2.AutoSize = true;
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(10, 101);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(56, 14);
            Label2.TabIndex = 7;
            Label2.Text = "Contacts :";
            Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*Label1*/
            Label1.AutoSize = true;
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(10, 69);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(77, 14);
            Label1.TabIndex = 0;
            Label1.Text = "Fournisseurs :";
            Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
/*BonCommande*/
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(779, 580);
            Controls.Add(txtDateRequise);
            Controls.Add(txtTotal);
            Controls.Add(txtCommentaire);
            Controls.Add(cmdInstructions);
            Controls.Add(cmdImprimer);
            Controls.Add(cmdFermer);
            Controls.Add(chkAfficherInstructions);
            Controls.Add(fraImpression);
            Controls.Add(txtComPar);
            Controls.Add(txtDate);
            Controls.Add(txtNoBC);
            Controls.Add(txtFax);
            Controls.Add(txtTelephone);
            Controls.Add(txtVotreNoSoum);
            Controls.Add(txtTransport);
            Controls.Add(cmbContact);
            Controls.Add(cmbFournisseur);
            Controls.Add(lvwBonCommande);
            Controls.Add(Label12);
            Controls.Add(Label11);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(lblNoBC);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(lblVotreNoSoum);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Location = new System.Drawing.Point(-1, -1);
            Name = "BonCommande";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Text = "ControleurServeur." + Name;
            ShowInTaskbar = false;
            fraImpression.ResumeLayout(false);
            fraImpression.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private const int I_COL_QUANTITE = 0;
        private const int I_COL_NO_ITEM = 1;
        private const int I_COL_DESCR = 2;
        private const int I_COL_MANUFACT = 3;
        private const int I_COL_PRIX = 4;
        private const int I_COL_ESCOMPTE = 5;
        private const int I_COL_TOTAL = 6;
        private const int I_IMP_FRANCAIS = 0;
        private const int I_IMP_ANGLAIS = 1;
        public enum EnumFormSource { I_PROJET_MEC = 0, I_PROJET_ELEC = 1, I_ACHAT_MEC = 2, I_ACHAT_ELEC = 3, I_INVENTAIRE_MEC = 4, I_INVENTAIRE_ELEC = 5, I_RETOUR_MARCHANDISE = 6 }
        private enum enumLangage { FRANCAIS = 0, ANGLAIS = 1 }
        internal static string m_sNoProjet;
        internal static string m_sNoAchat;
        internal static int m_iIndexAchat;
        internal static bool m_bOuverture;
        internal static int m_iNoFRS;
        internal static List<String> m_collPieces;
        internal static List<String> m_collNoLigne;
        internal static string m_sEmploye;
        internal static ChoixImpressionRetourMarchandise.enumImpressionRetour m_eImpRetour;
        private enumLangage m_eLangage;
        internal static string sNoProjet;
        internal static string sNoBC;
        internal static List<String> collPiece;
        internal static List<String> collNoLigne;
        internal static EnumFormSource Procédure;
        internal static int eLangage;
        private bool telecomande;

        public BonCommande(string sNoProjet, string sNoBC, List<String> collPiece, List<String> collNoLigne, EnumFormSource i_PROJET_ELEC, int eLangage)
        {
            sNoProjet = sNoProjet;
            sNoBC = sNoBC;
            collPiece = collPiece;
            collNoLigne = collNoLigne;
            i_PROJET_ELEC = i_PROJET_ELEC;
            eLangage = eLangage;
        }
        public BonCommande(bool telecomande)
        {
            InitializeComponent();
            Icon = Conteneur.ActiveForm.Icon;
            telecomande = telecomande;
            txtDate.Text = ConvertToUSDate(DateTime.Today);
            txtComPar.Text = IdNomEmploye;
            txtNoBC.Text = ACHAT.cmbNoAchat.Text;
            m_eLangage = enumLangage.FRANCAIS;
            if (Gauche(ACHAT.cmbNoAchat.Text, 1) == "E") { Procédure = EnumFormSource.I_PROJET_ELEC; }
            if (Gauche(ACHAT.cmbNoAchat.Text, 1) == "M") { Procédure = EnumFormSource.I_PROJET_MEC; }
            if (Gauche(ACHAT.cmbNoAchat.Text, 1) == "R") { Procédure = EnumFormSource.I_RETOUR_MARCHANDISE; }
            Text = $"Bon de commande projet: {Gauche(ACHAT.cmbNoAchat.Text,9)} [{ACHAT.txtRaison.Text}]";
            txtTransport.Text = "Votre camion";
            if (ChoixBonCommande.m_collNoLigneFRS.Count > 0){foreach (string p in ChoixBonCommande.m_collNoLigneFRS){ cmbFournisseur.Items.Add(p.Split('-')[0]); }}
            if (cmbFournisseur.Items.Count > 0) { cmbFournisseur.SelectedIndex = 0; }
            lvwBonCommande.Columns.Clear();
            lvwBonCommande.View = System.Windows.Forms.View.Details;
            lvwBonCommande.Columns.Add("Quantité", 60, HorizontalAlignment.Left);
            lvwBonCommande.Columns.Add("Item #",90, HorizontalAlignment.Left);
            lvwBonCommande.Columns.Add("Description", 200, HorizontalAlignment.Left);
            lvwBonCommande.Columns.Add("Manufacturier", 190, HorizontalAlignment.Left);
            lvwBonCommande.Columns.Add("Prix", 60, HorizontalAlignment.Right);
            lvwBonCommande.Columns.Add("Escompte", 60, HorizontalAlignment.Right);
            lvwBonCommande.Columns.Add("Total", 60, HorizontalAlignment.Right);
            int items = 0;
            foreach (ListViewItem it in ChoixBonCommande.lvwPiece.Items)
            {
                if (it.Checked == true)
                {
                    if (it.SubItems[4].Text.Trim() == cmbFournisseur.Text.Trim()){items++;}
                    ListViewItem itm = lvwBonCommande.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[0].Text));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[1].Text));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[2].Text));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[3].Text));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[6].Text + "$"));
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse( ACHAT.lvwAchat.Items[it.Index].SubItems[5].Text)/100,2).ToString() + "%"));
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[8].Text+"$"));
                    itm.ForeColor = COLOR_JAUNE;
                }
            }
        }
/// <summary>
/// Classe imbriquée servant a la gestion et affichage des infos des contacts dans la section Select Fournisseur
/// </summary>
        internal class InfosContact
        {
            internal string Nom;
            internal string Telephone;
            internal string Fax;
            public InfosContact()
            {
            }
            public InfosContact(string nom, string telephone, string fax)
            {
                Nom = nom;
                Telephone = telephone;
                Fax = fax;
            }
        }
        internal List<InfosContact> ics = new List<InfosContact>();
        private void cmbContact_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (ics.Count > 0)
            {
                txtFax.Text = ics[cmbContact.SelectedIndex].Fax;
                txtTelephone.Text = ics[cmbContact.SelectedIndex].Telephone;
            }else {
                txtTelephone.Text = "NA";
                txtFax.Text = "NA";
            }
        }
/// <summary>
/// remaniement visant a exploiter les segment deja en memoire plutot que de perdre des cycles en attente et renvoi requete Serveur SQL I/O
/// </summary>
private void cmbFournisseur_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (ChoixBonCommande.m_collNoLigneFRS[cmbFournisseur.SelectedIndex].Split('-').Length > 1)
            {
                try
                {
                    m_iNoFRS = int.Parse(ChoixBonCommande.m_collNoLigneFRS[cmbFournisseur.SelectedIndex].Split('-')[1]);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show($"Erreur lors de la convertion Sting2Int pour le #fournisseur depuis " +
                        $"{ChoixBonCommande.m_collNoLigneFRS[cmbFournisseur.SelectedIndex].Split('-')[1]}" +
                        $"\n{ex.Source}\n{ex.Message}\n" + ex.Source, Application.ProductName + ". StringConverter.String2Int", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fournisseur non trouvé\n Procédure abandonnée", Application.ProductName + ".BonViewCommande.cmbFournisseur_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            RemplirComboContacts();
            try
            {
                lvwBonCommande.Items.Clear();
                foreach (ListViewItem it in ChoixBonCommande.lvwPiece.Items)
                {
                    if (it.Checked == true)
                    {
                        ListViewItem itm = lvwBonCommande.Items.Add(string.Empty);
                        itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[0].Text));
                        itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[1].Text));
                        itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[2].Text));
                        itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[3].Text));
                        itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[6].Text + "$"));
                        itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse(ACHAT.lvwAchat.Items[it.Index].SubItems[5].Text) / 100, 2).ToString() + "%"));
                        itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[it.Index].SubItems[8].Text + "$"));
                        itm.ForeColor = COLOR_JAUNE;
                    }
                }
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "cmbFournisseur_Click", ex);
            }
        }
        private void Cmdfermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sNoBC;
                if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                {
                    sNoBC = txtVotreNoSoum.Text;
                }
                else
                {
                    sNoBC = txtNoBC.Text;
                }
                UpdateSQL("DELETE FROM BonsCommandes_Pieces WHERE NoBonCommande = '" + sNoBC + "'");
                UpdateSQL("DELETE FROM BonsCommandes WHERE NoBonCommande = '" + sNoBC + "'");
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "cmdFermer_Click", ex);
            }
        }
        public void AfficherFormProjetAchat(string sNoProjet, string sNoBonCommande, List<String> collPiece, List<String> collNoLigne, EnumFormSource eForm, int iLangage)
        {
            try
            {
                if (eForm == EnumFormSource.I_ACHAT_ELEC | eForm == EnumFormSource.I_ACHAT_MEC)
                {
                    m_sNoAchat = Gauche(sNoProjet, 9);
                    m_iIndexAchat = int.Parse(Droite(sNoProjet, 3));
                }
                else
                {
                    m_sNoProjet = sNoProjet;
                }
                Procédure = eForm;
                m_eLangage = (enumLangage)iLangage;
                m_collPieces = collPiece;
                m_collNoLigne = collNoLigne;
                m_bOuverture = true;
                txtNoBC.Text = sNoBonCommande;
                UpdateSQL("DELETE FROM BONSCOMMANDES WHERE NOBONCOMMANDE = '" + txtNoBC.Text + "'");
                UpdateSQL("DELETE FROM BONSCOMMANDES_PIECES WHERE NOBONCOMMANDE = '" + txtNoBC.Text + "'");
                if (eForm == EnumFormSource.I_ACHAT_ELEC | eForm == EnumFormSource.I_ACHAT_MEC)
                {
                    EnregistrerBonCommandeAchat();
                }
                else
                {
                    EnregistrerBonCommandeProjet();
                }
                RemplirComboFournisseurs();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "AfficherFormProjet", ex);
            }
        }
        public void AfficherFormRetourMarchandiseProjet(string sNoProjet, string sNoBonCommande, List<String> collPiece, List<String> collNoLigne, string sUserID, ChoixImpressionRetourMarchandise.enumImpressionRetour eImpRetour)
        {
            try
            {
                ADODB.Recordset rstEmploye;
                Text = "Retour de marchandise";
                lblVotreNoSoum.Text = "Notre # : ";
                lblNoBC.Text = "# RMA : ";
                m_eImpRetour = eImpRetour;
                m_sNoProjet = Droite(sNoProjet, Strings.Len(sNoProjet) - 1);
                Procédure = EnumFormSource.I_RETOUR_MARCHANDISE;
                m_collPieces = collPiece;
                m_collNoLigne = collNoLigne;
                m_bOuverture = true;
                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT Employe FROM Employés WHERE loginname = '" + sUserID + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                m_sEmploye = $"{rstEmploye.Fields["Employe"].Value}";
                rstEmploye.Close();
                rstEmploye = null;
                txtVotreNoSoum.Text = sNoBonCommande;
                txtVotreNoSoum.ReadOnly = true;
                txtNoBC.ReadOnly = false;
                UpdateSQL("DELETE FROM BonsCommandes WHERE NoBonCommande = '" + txtVotreNoSoum.Text + "'");
                UpdateSQL("DELETE FROM BonsCommandes_Pieces WHERE NoBonCommande = '" + txtVotreNoSoum.Text + "'");
                EnregistrerBonCommandeRetourMarchandiseProjet();
                RemplirComboFournisseurs();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "AfficherFormRetourMarchandiseProjet", ex);
            }
        }
        public void AfficherFormRetourMarchandiseAchat(string sNoAchat, int iIndexAchat, string sNoBonCommande, List<String> collPiece, List<String> collNoLigne, string sUserID, ChoixImpressionRetourMarchandise.enumImpressionRetour eImpRetour)
        {
            try
            {
                ADODB.Recordset rstEmploye;
                Text = "Retour de marchandise";
                lblVotreNoSoum.Text = "Notre # : ";
                lblNoBC.Text = "# RMA : ";
                m_eImpRetour = eImpRetour;
                m_sNoAchat = sNoAchat;
                m_iIndexAchat = iIndexAchat;
                Procédure = EnumFormSource.I_RETOUR_MARCHANDISE;
                m_collPieces = collPiece;
                m_collNoLigne = collNoLigne;
                m_bOuverture = true;
                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT Employe FROM Employés WHERE loginname = '" + sUserID + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                m_sEmploye = $"{rstEmploye.Fields["Employe"].Value}";
                rstEmploye.Close();
                rstEmploye = null;
                txtVotreNoSoum.Text = sNoBonCommande;
                txtVotreNoSoum.ReadOnly = true;
                txtNoBC.ReadOnly = false;
                UpdateSQL("DELETE FROM BonsCommandes WHERE NoBonCommande = '" + txtVotreNoSoum.Text + "'");
                UpdateSQL("DELETE FROM BonsCommandes_Pieces WHERE NoBonCommande = '" + txtVotreNoSoum.Text + "'");
                EnregistrerBonCommandeRetourMarchandiseAchat();
                RemplirComboFournisseurs();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "AfficherFormRetourMarchandiseAchat", ex);
            }
        }
        [Obsolete]
        private void AfficherContenuFournisseur()
        {
            try
            {
                ADODB.Recordset rstBC;
                ADODB.Recordset rstFRS;
                string sNoBC;
                if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                {
                    sNoBC = txtVotreNoSoum.Text;
                }
                else
                {
                    sNoBC = txtNoBC.Text;
                }
                rstBC = new Recordset();
                rstBC.Open("SELECT * FROM BonsCommandes WHERE NoFournisseur = " + m_iNoFRS + " AND NoBonCommande = '" + sNoBC + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstBC.Fields["Attention"].Value, string.Empty, false)))
                {
                    if (ComboContient(cmbContact, $"{rstBC.Fields["Attention"].Value}") == true){cmbContact.Text = $"{rstBC.Fields["Attention"].Value}";}else{cmbContact.SelectedIndex = -1;}
                }
                else{cmbContact.SelectedIndex = -1;}
                if (!(rstBC.Fields["Transport"].Value is DBNull) | !string.IsNullOrEmpty($"{rstBC.Fields["Transport"].Value}".Trim()))
                {
                    txtTransport.Text = $"{rstBC.Fields["Transport"].Value}";
                }
                else
                {
                    txtTransport.Text = string.Empty;
                }
                if (!(rstBC.Fields["DateRequise"].Value is DBNull) | !string.IsNullOrEmpty($"{rstBC.Fields["DateRequise"].Value}".Trim()))
                {
                    txtDateRequise.Text = $"{rstBC.Fields["DateRequise"].Value}";
                }
                else
                {
                    txtDateRequise.Text = string.Empty;
                }
                if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                {
                    if (!(rstBC.Fields["VotreNoSoum"].Value is DBNull))
                    {
                        txtNoBC.Text = $"{rstBC.Fields["VotreNoSoum"].Value}";
                    }
                    else
                    {
                        txtNoBC.Text = string.Empty;
                    }
                }
                else if (!(rstBC.Fields["VotreNoSoum"].Value is DBNull))
                {
                    txtVotreNoSoum.Text = $"{rstBC.Fields["VotreNoSoum"].Value}";
                }
                else
                {
                    txtVotreNoSoum.Text = string.Empty;
                }
                rstFRS = new Recordset();
                rstFRS.Open($"SELECT Telephonne, Fax FROM Fournisseur WHERE IDFRS = {GetFournisseurID(cmbFournisseur.Items[cmbFournisseur.SelectedIndex].ToString())}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                txtTelephone.Text = $"{rstFRS.Fields["Telephonne"].Value}";
                txtFax.Text = $"{rstFRS.Fields["Fax"].Value}";
                rstFRS.Close();
                rstFRS = null;
                txtDate.Text = $"{rstBC.Fields["DateCommande"].Value}";
                txtComPar.Text = $"{rstBC.Fields["CommandePar"].Value}";
                if (!(rstBC.Fields["Commentaire"].Value is DBNull))
                {
                    txtCommentaire.Text = $"{rstBC.Fields["Commentaire"].Value}";
                }
                else
                {
                    txtCommentaire.Text = string.Empty;
                }
                txtTotal.Text = (rstBC.Fields["Total"].Value);
                chkAfficherInstructions.Checked = (bool)rstBC.Fields["AffichageInstructions"].Value;
                if (rstBC.Fields["LangueImpression"].Value == "Français")
                {
                    _optImpression_0.Checked = true;
                }
                else
                {
                    _optImpression_1.Checked = true;
                }
                rstBC.Close();
                rstBC = null;
                RemplirListView();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "AfficherContenuFournisseur", ex);
            }
        }
        private void RemplirListView()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ListViewItem itmPiece;
                int X;
                double dblEscompte;
                double dblPrix;
                string sNoBC;
                if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                {
                    sNoBC = txtVotreNoSoum.Text;
                }
                else
                {
                    sNoBC = txtNoBC.Text;
                }
                lvwBonCommande.Items.Clear();
                rstPiece = new Recordset();
                rstPiece.Open("SELECT * FROM BonsCommandes_Pieces WHERE NoBonCommande = '" + sNoBC + "' AND NoFournisseur = " + m_iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF)
                {
                    if (!(rstPiece.Fields["Qté"].Value is DBNull))
                    {
                        itmPiece = lvwBonCommande.Items.Add(string.Empty);
                        itmPiece.Text = $"{rstPiece.Fields["Qté"].Value}";
                        if (!(rstPiece.Fields["NuméroLigne"].Value is DBNull))
                        {
                            itmPiece.Tag = rstPiece.Fields["NuméroLigne"].Value;
                        }
                        if (itmPiece.SubItems.Count > I_COL_NO_ITEM)
                        {
                            itmPiece.SubItems[I_COL_NO_ITEM].Text = $"{rstPiece.Fields["NoItem"].Value}";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["NoItem"].Value}"));
                        }
                        if (!(rstPiece.Fields["Description"].Value is DBNull))
                        {
                            if (itmPiece.SubItems.Count > I_COL_DESCR)
                            {
                                itmPiece.SubItems[I_COL_DESCR].Text = $"{rstPiece.Fields["Description"].Value}";
                            }
                            else
                            {
                                itmPiece.SubItems.Insert(I_COL_DESCR, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["Description"].Value}"));
                            }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_DESCR)
                        {
                            itmPiece.SubItems[I_COL_DESCR].Text = string.Empty;
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        if (itmPiece.SubItems.Count > I_COL_MANUFACT)
                        {
                            itmPiece.SubItems[I_COL_MANUFACT].Text = $"{rstPiece.Fields["Manufact"].Value}";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_MANUFACT, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["Manufact"].Value}"));
                        }
                        if (!(rstPiece.Fields["Prix"].Value is DBNull))
                        {
                            if (itmPiece.SubItems.Count > I_COL_PRIX)
                            {
                                itmPiece.SubItems[I_COL_PRIX].Text = (rstPiece.Fields["Prix"].Value);
                            }
                            else
                            {
                                itmPiece.SubItems.Insert(I_COL_PRIX, new ListViewItem.ListViewSubItem((ListViewItem)null, (rstPiece.Fields["Prix"].Value)));
                            }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_PRIX)
                        {
                            itmPiece.SubItems[I_COL_PRIX].Text = 0.ToString();
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_PRIX, new ListViewItem.ListViewSubItem((ListViewItem)null, "0"));
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim($"{rstPiece.Fields["Escompte"].Value}")))
                        {
                            if (itmPiece.SubItems.Count > I_COL_ESCOMPTE)
                            {
                                itmPiece.SubItems[I_COL_ESCOMPTE].Text = (rstPiece.Fields["Escompte"].Value);
                            }
                            else
                            {
                                itmPiece.SubItems.Insert(I_COL_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, (rstPiece.Fields["Escompte"].Value)));
                            }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_ESCOMPTE)
                        {
                            itmPiece.SubItems[I_COL_ESCOMPTE].Text = " ";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " "));
                        }
                        if (!(rstPiece.Fields["Total"].Value is DBNull))
                        {
                            if (itmPiece.SubItems.Count > I_COL_TOTAL)
                            {
                                itmPiece.SubItems[I_COL_TOTAL].Text = rstPiece.Fields["Total"].Value;
                            }
                            else
                            {
                                itmPiece.SubItems.Insert(I_COL_TOTAL, new ListViewItem.ListViewSubItem((ListViewItem)null, $"{rstPiece.Fields["Total"].Value}"));
                            }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_TOTAL)
                        {
                            itmPiece.SubItems[I_COL_TOTAL].Text = "0";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_TOTAL, new ListViewItem.ListViewSubItem((ListViewItem)null, "0"));
                        }
                    }
                    rstPiece.MoveNext();
                }
                rstPiece.Close();
                rstPiece = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "RemplirListView", ex);
            }
        }
        private void RemplirComboContacts()
        {
            try
            {
                ADODB.Recordset rstContact;
                ADODB.Recordset rstContactFRS;
                cmbContact.Items.Clear();
                rstContactFRS = new Recordset();
                rstContact = new Recordset();
                ics.Clear();
                rstContactFRS.Open("SELECT * FROM ContactFRS WHERE NoFRS = " + m_iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstContactFRS.EOF)
                {
                    rstContact.Open(Operators.ConcatenateObject("SELECT [NOMCONTACT],[TELEPHONNE],[FAX]FROM CONTACT WHERE IDContact = ", rstContactFRS.Fields["NoContact"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstContact.EOF)
                    {
                        cmbContact.Items.Add(rstContact.Fields["NomContact"].Value);
                        ics.Add(new InfosContact($"{rstContact.Fields[0].Value}", $"{rstContact.Fields[1].Value}", $"{rstContact.Fields[2].Value}"));
                    }
                    rstContact.Close();
                    rstContactFRS.MoveNext();
                }
                rstContactFRS.Close();
                if (cmbContact.Items.Count > 0) cmbContact.SelectedIndex = 0;
                if (cmbContact.Items.Count == 1)
                   {
                       rstContact.Open($"SELECT * FROM Contact WHERE IDContact = {rstContactFRS.Fields["NoContact"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstContact.EOF)
                    {
                        txtFax.Text = rstContact.Fields[3].Value;
                        txtTelephone.Text = rstContact.Fields[4].Value;
                    }
                        rstContact.Close();
                   }
                   rstContact = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "RemplirComboContact", ex);
            }
        }
        private void RemplirComboFournisseurs()
        {
            try
            {
                ADODB.Recordset rstBC;
                if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                {
                    sNoBC = txtVotreNoSoum.Text;
                }
                    sNoBC = txtNoBC.Text;
                rstBC = new Recordset();
                rstBC.Open($"SELECT DISTINCT  [DBO].[FOURNISSEUR].NOMFOURNISSEUR ,[DBO].[ACHAT_PIECES].IDFRS FROM [DBO].[ACHAT_PIECES] " +
                    $"JOIN [DBO].[FOURNISSEUR] ON [DBO].[ACHAT_PIECES].IDFRS = [DBO].[FOURNISSEUR].IDFRS " +
                    $"WHERE IDACHAT = '{Gauche(txtNoBC.Text,9)}'" +
                    $"ORDER BY NOMFOURNISSEUR", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                
                while (!rstBC.EOF)
                {
                    cmbFournisseur.Items.Add($"{rstBC.Fields["NomFournisseur"].Value} - {rstBC.Fields["NoFournisseur"].Value}");
                    rstBC.MoveNext();
                }
                rstBC.Close();
                rstBC = null;
                if (cmbFournisseur.Items.Count > 0)
                {
                    cmbFournisseur.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "RemplirComboFournisseurs", ex);
            }
        }
        [Obsolete]

        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            ADODB.Recordset rstBC;
            ADODB.Recordset rstBCPiece = new ADODB.Recordset();
            ADODB.Recordset rstFournisseur = new ADODB.Recordset();
                int X; 
                string sNoBC=ACHAT.cmbNoAchat.Text; 
                Cursor.Current = Cursors.WaitCursor;
            try
            {
                ADODB.Recordset rstConfig = new ADODB.Recordset();
                if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE) { sNoBC = txtVotreNoSoum.Text; } else { sNoBC = txtNoBC.Text; }
      //          EnregistrerModifFournisseur(); 
                rstBC = new Recordset();
                if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                {
                    if (m_eImpRetour == ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_RETOUR) { rstBC.Open($"SELECT * FROM BONSCOMMANDES WHERE NOBONCOMMANDE = '{sNoBC}' AND NOFOURNISSEUR = {m_iNoFRS}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } else { rstBC.Open($"SELECT * FROM BONSCOMMANDES WHERE NOBONCOMMANDE = '{sNoBC}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                }
                else { rstBC.Open($"SELECT * FROM BONSCOMMANDES WHERE NOBONCOMMANDE = '{sNoBC}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                if (Procédure == EnumFormSource.I_ACHAT_ELEC | Procédure == EnumFormSource.I_PROJET_ELEC)
                {
                    while (!rstBC.EOF)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstBC.Fields["DateRequise"].Value, string.Empty, false))) {
                            rstFournisseur = new Recordset(); 
                            rstFournisseur.Open($"SELECT NOMFOURNISSEUR FROM FOURNISSEUR WHERE IDFRS = {rstBC.Fields["NoFournisseur"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); 
                            MessageBox.Show($"Le date requise est nécessaire pour le fournisseur {rstFournisseur.Fields["NomFournisseur"].Value}!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                            rstFournisseur.Close(); rstFournisseur = null; 
                            rstBC.Close(); 
                            rstBC = null;
                            Cursor.Current = Cursors.Default; return; }
                        rstBC.MoveNext();
                    }
                    rstBC.MoveFirst();
                }
                rstBCPiece.CursorLocation = CursorLocationEnum.adUseClient; 
                while (!rstBC.EOF)
                {
                    rstBCPiece.Open($"SELECT * FROM BONSCOMMANDES_PIECES WHERE NOBONCOMMANDE = '{sNoBC}' AND NOFOURNISSEUR = {rstBC.Fields["NoFournisseur"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstBCPiece.RecordCount < 15) { 
                        X = (int)(15 - rstBCPiece.RecordCount); 
                        while (!(X == 0)) { 
                            rstBCPiece.AddNew(); 
                            rstBCPiece.Fields["NoBonCommande"].Value = rstBC.Fields["NoBonCommande"].Value; 
                            rstBCPiece.Fields["NoFournisseur"].Value = rstBC.Fields["NoFournisseur"].Value; 
                            rstBCPiece.Fields["Type"].Value = rstBC.Fields["Type"].Value; rstBCPiece.Update(); 
                            X--; 
                        } 
                    }
                    rstFournisseur.Open($"SELECT * FROM FOURNISSEUR WHERE IDFRS = {rstBC.Fields["NoFournisseur"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); 
                    rstConfig.Open("SELECT PARCEL_LABEL_LINE1, PARCEL_LABEL_LINE2, PARCEL_LABEL_LINE3, PARCELASSIST, PARCELETAT FROM CONFIG", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if ((bool)rstBC.Fields["AffichageInstructions"].Value) {
                        ViewCommandeParcel.Orientation = true; 
                        ViewCommandeParcel.lblcompagnie.Text = rstConfig.Fields["parcel_label_line1"].Value; 
                        ViewCommandeParcel.lbladresse.Text = rstConfig.Fields["parcel_label_line2"].Value; 
                        ViewCommandeParcel.lblpays.Text = rstConfig.Fields["parcel_label_line3"].Value; 
                        ViewCommandeParcel.lblassist.Text = $"Should you have any questions, do not hesitate to call {rstConfig.Fields["ParcelAssist"].Value}, it will be our pleasure to assist you."; 
                        ViewCommandeParcel.lblreminder.Text = $"Please note that you are shipping to a {rstConfig.Fields["ParcelEtat"].Value} address and therefore your shipment is considered as domestic."; 
                    }
                   ViewCommande.Orientation = !isLandscape;
                    if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                    {
                        if (m_eImpRetour == ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_DEMANDE_RETOUR) {ViewCommande.lblTitre.Text = "Demande de retour de marchandise"; } else {ViewCommande.lblTitre.Text = "Retour de marchandise"; }
                    }
                    else {ViewCommande.lblTitre.Text = "Commande"; }
                    if (rstBC.Fields["LangueImpression"].Value == "Anglais")
                    {
                        if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                        {
                           ViewCommande.lblTitreBC.Text = "RMA #";
                            if (m_eImpRetour == ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_DEMANDE_RETOUR) {ViewCommande.lblTitre.Text = "RMA REQUEST"; } else {ViewCommande.lblTitre.Text = "RETURN ORDER"; }
                           ViewCommande.lblTitreNoSoum.Text = "Our #";
                        }
                        else {ViewCommande.lblTitreBC.Text = "PO #";ViewCommande.lblTitre.Text = "PURCHASE ORDER";ViewCommande.lblTitreNoSoum.Text = "Your ref #"; }
                       ViewCommande.lbltitrecommentaire.Text = "Comments:";ViewCommande.lbltitrecompar.Text = "Purchaser:";ViewCommande.lblTitreContact.Text = "ATT:";ViewCommande.lbltitredate.Text = "Date:";ViewCommande.lbltitredatereq.Text = "Date required";ViewCommande.lblTitreDescription.Text = "Description";ViewCommande.lblTitreEscompte.Text = "Discount";ViewCommande.lblTitreFax.Text = "Fax";ViewCommande.lblTitreFournisseur.Text = "SUPPLIER:";ViewCommande.lblTitreManufact.Text = "Manufacturer";ViewCommande.lblTitrePiece.Text = "Part Number";ViewCommande.lbltitredate.Text = "Page:";ViewCommande.lblTitrePrix.Text = "Unit Price";ViewCommande.lblTitreQte.Text = "Qty";ViewCommande.lblTitreTel.Text = "Telephone";ViewCommande.lblTitreTotal.Text = "Total";ViewCommande.lbltitretotalfin.Text = "TOTAL";ViewCommande.lblTitreTransport.Text = "TRANSPORT";ViewCommande.lbltypeprix.Text = $"{rstFournisseur.Fields["pays"].Value} Funds";ViewCommande.lblPiedPage.Text = "CONFIRM THE ORDER AND SHIPPING DATE";
                    }
                    else
                    if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                    {
                       ViewCommande.lblTitreBC.Text = "# RMA";
                        if (m_eImpRetour == ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_DEMANDE_RETOUR) {ViewCommande.lblTitre.Text = "DEMANDE DE RETOUR DE MARCHANDISE"; } else {ViewCommande.lblTitre.Text = "RETOUR DE MARCHANDISE"; }
                       ViewCommande.lblTitreNoSoum.Text = "Notre #";
                    }
                    else {ViewCommande.lblTitreBC.Text = "BC #";ViewCommande.lblTitre.Text = "COMMANDE";ViewCommande.lblTitreNoSoum.Text = "Votre # soum"; }
                    if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                    {
                        if (!(rstBC.Fields["VotreNoSoum"].Value is DBNull)) {ViewCommande.lblNoBC.Text = rstBC.Fields["VotreNoSoum"].Value; } else {ViewCommande.lblNoBC.Text = string.Empty; }
                    }
                    else {ViewCommande.lblNoBC.Text = rstBC.Fields["NoBonCommande"].Value; }
                    if (!(rstBC.Fields["Commentaire"].Value is DBNull)) {ViewCommande.lblCommentaire.Text = rstBC.Fields["Commentaire"].Value; } else {ViewCommande.lblCommentaire.Text = string.Empty; }
                   ViewCommande.lblCommandePar.Text = rstBC.Fields["CommandePar"].Value;
                    if (!(rstBC.Fields["Attention"].Value is DBNull)) {ViewCommande.lblContact.Text = rstBC.Fields["Attention"].Value; } else {ViewCommande.lblContact.Text = string.Empty; }
                   ViewCommande.lblDate.Text = rstBC.Fields["DateCommande"].Value;
                    if (!(rstBC.Fields["DateRequise"].Value is DBNull)) {ViewCommande.lblDateRequise.Text = rstBC.Fields["DateRequise"].Value; } else {ViewCommande.lblDateRequise.Text = string.Empty; }
                   ViewCommande.lblFax.Text = rstFournisseur.Fields["Fax"].Value;ViewCommande.lblFournisseur.Text = rstFournisseur.Fields["NomFournisseur"].Value;ViewCommande.lblTelephone.Text = rstFournisseur.Fields["telephonne"].Value;
                    if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE) {ViewCommande.lblNoSoum.Text = rstBC.Fields["NoBonCommande"].Value; }
                    else
                    if (!(rstBC.Fields["VotreNoSoum"].Value is DBNull)) {ViewCommande.lblNoSoum.Text = rstBC.Fields["VotreNoSoum"].Value; } else {ViewCommande.lblNoSoum.Text = string.Empty; }
                   ViewCommande.lblTotalFin.Text = (rstBC.Fields["total"].Value);
                    if (!(rstBC.Fields["Transport"].Value is DBNull)) {ViewCommande.lblTransport.Text = rstBC.Fields["Transport"].Value; } else {ViewCommande.lblTransport.Text = " "; }
                    if (Procédure == EnumFormSource.I_ACHAT_ELEC | Procédure == EnumFormSource.I_INVENTAIRE_ELEC | Procédure == EnumFormSource.I_PROJET_ELEC) {ViewCommande.lblCSA.Text = string.Empty; }
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstBC.Fields["AffichageInstructions"].Value, true, false))) { rstConfig.Requery();ViewCommande.lblCommentaire.Text = "Shipping Address:\n" +ViewCommande.lblCommentaire.Text; }
                    rstBCPiece.MoveFirst(); 
                    while (rstBCPiece.EOF == false)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstBCPiece.Fields["NoItem"].Value, VariantType.Null, false)))
                        {
                            if ($"{rstBCPiece.Fields["NoItem"].Value}".Length > 26) { return; }
                        }
                        rstBCPiece.MoveNext();
                    }
                    if (Procédure != EnumFormSource.I_RETOUR_MARCHANDISE)
                    {
                        if ($"{rstFournisseur.Fields["NomFournisseur"].Value}".ToUpper() != "SOLUTION GRB INC.")
                        {
                            ViewCommandeRecue.Orientation = false;
                            if (Procédure == EnumFormSource.I_PROJET_ELEC | Procédure == EnumFormSource.I_PROJET_MEC)
                            {
                                rstBCPiece.Close();
                                if (Procédure == EnumFormSource.I_PROJET_ELEC) { 
                                    rstBCPiece.Open("SELECT * FROM BONSCOMMANDES_PIECES " +
                                        "LEFT JOIN INVENTAIREELEC ON BONSCOMMANDES_PIECES.NOITEM =INVENTAIREELEC.NOITEM " +
                                        "WHERE NOBONCOMMANDE = '" + sNoBC + "' AND NOFOURNISSEUR = " + rstBC.Fields["NoFournisseur"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } else { rstBCPiece.Open("SELECT * FROM BONSCOMMANDES_PIECES " + "LEFT JOIN INVENTAIREMEC ON BONSCOMMANDES_PIECES.NOITEM = INVENTAIREMEC.NOITEM " + "WHERE NOBONCOMMANDE = '" + sNoBC + "' AND NoFournisseur = " + rstBC.Fields["NoFournisseur"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                                ViewCommandeRecue.DataSource = rstBCPiece;
                            }
                            else
                            if (Procédure == EnumFormSource.I_ACHAT_ELEC | Procédure == EnumFormSource.I_ACHAT_MEC)
                            {
                                rstBCPiece.Close();
                                if (Procédure == EnumFormSource.I_ACHAT_ELEC) { 
                                    rstBCPiece.Open($"SELECT * FROM BONSCOMMANDES_PIECES " +
                                        $"LEFT JOIN INVENTAIREELEC ON BONSCOMMANDES_PIECES.NOITEM = INVENTAIREELEC.NOITEM WHERE NOBONCOMMANDE = '{sNoBC}' AND NoFournisseur = {rstBC.Fields["NoFournisseur"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } else { rstBCPiece.Open($"SELECT * FROM BonsCommandes_Pieces LEFT JOIN InventaireMec ON BonsCommandes_Pieces.NoItem = InventaireMec.NoItem WHERE NoBonCommande = '{sNoBC}' AND NoFournisseur = {rstBC.Fields["NoFournisseur"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                                ViewCommandeRecue.DataSource = rstBCPiece;
                            }
                            ViewCommandeRecue.lblfournisseur.Text = rstFournisseur.Fields["NomFournisseur"].Value; 
                            ViewCommandeRecue.lblprojet.Text = rstBC.Fields["NoProjet"].Value; 
                            ViewCommandeRecue.lbldatereq.Text = rstBC.Fields["DateRequise"].Value;
                        }
                    }
                    else
                    if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                    {
                        if (m_eImpRetour == ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_RETOUR) { 
                            ImprimerRetour($"{rstBC.Fields["NoBonCommande"].Value}", int.Parse(rstBC.Fields["NoFournisseur"].Value), $"{rstBC.Fields["VotreNoSoum"].Value}"); 
                            ImprimerRetourDossier($"{rstBC.Fields["NoBonCommande"].Value}", int.Parse(rstBC.Fields["NoFournisseur"].Value)); 
                        }
                    }
                    rstBC.MoveNext(); rstBCPiece.Close(); rstConfig.Close(); rstFournisseur.Close();
                }
                rstFournisseur = null;
                rstConfig = null; 
                rstBCPiece = null; 
  /*              UpdateSQL("DELETE FROM BONSCOMMANDES_PIECES WHERE NOBONCOMMANDE = '" + sNoBC + "'"); 
                UpdateSQL("DELETE FROM BONSCOMMANDES WHERE NOBONCOMMANDE = '" + sNoBC + "'"); */
                Close();
                ViewCommande viewCommande = new ViewCommande();
                viewCommande.Text = Text;
                viewCommande.ShowInTaskbar = false;
                viewCommande.Show();
                Cursor.Current = Cursors.Default; return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "cmdImprimer_Click", ex);
            }
        }
        [Obsolete]
        private void ImprimerRetour(string sNoRetour, int iNoFRS, string sNoRMA)
        {
            try
            {
                ADODB.Recordset rstBCPiece;
                ADODB.Recordset rstFRS;
                rstBCPiece = new Recordset();
                rstBCPiece.Open("SELECT * FROM BONSCOMMANDES_PIECES WHERE NOBONCOMMANDE = '" + sNoRetour + "' AND NOFOURNISSEUR = " + iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViewRetour.Orientation = false;
                rstFRS = new Recordset();
                rstFRS.Open("SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = " + iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViewRetour.lblFournisseur.Text = rstFRS.Fields["NomFournisseur"].Value;
                rstFRS.Close();
                rstFRS = null;
                ViewRetour.lblNoProjet.Text = sNoRetour;
                ViewRetour.lblNoRMA.Text = sNoRMA;
                ViewRetour.lblDate.Text = ConvertDate(DateTime.Today);
                rstBCPiece.Close();
                rstBCPiece = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "ImprimerRetour", ex);
            }
        }
        [Obsolete]
        private void ImprimerRetourDossier(string sNoRetour, int iNoFRS)
        {
            try
            {
                ADODB.Recordset rstBC;
                ADODB.Recordset rstBCPiece;
                ADODB.Recordset rstFRS;
                rstBC = new Recordset();
                rstBCPiece = new Recordset();
                rstBC.Open($"SELECT * FROM BONSCOMMANDES WHERE NOBONCOMMANDE = '{sNoRetour}' AND NOFOURNISSEUR = iNoFRS", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstBCPiece.Open($"SELECT * FROM BONSCOMMANDES_PIECES WHERE NOBONCOMMANDE = '{sNoRetour}' AND NOFOURNISSEUR =  {iNoFRS}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstFRS = new Recordset();
                rstFRS.Open("SELECT * FROM Fournisseur WHERE IDFRS = " + iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ViewCommande.Orientation = false;
                ViewCommande.lblTitre.Text = "Retour de marchandise";
                ViewCommande.lblTitreBC.Text = "# RMA";
                ViewCommande.lblTitre.Text = "RETOUR DE MARCHANDISE";
                ViewCommande.lblTitreNoSoum.Text = "Notre #";
                if (!(rstBC.Fields["VotreNoSoum"].Value is DBNull)) { ViewCommande.lblNoBC.Text = rstBC.Fields["VotreNoSoum"].Value; } else { ViewCommande.lblNoBC.Text = string.Empty; }
                if (!(rstBC.Fields["Commentaire"].Value is DBNull)) { ViewCommande.lblCommentaire.Text = rstBC.Fields["Commentaire"].Value; } else { ViewCommande.lblCommentaire.Text = string.Empty; }
                ViewCommande.lblCommandePar.Text = rstBC.Fields["CommandePar"].Value;
                if (!(rstBC.Fields["Attention"].Value is DBNull)) { ViewCommande.lblContact.Text = rstBC.Fields["Attention"].Value; } else { ViewCommande.lblContact.Text = string.Empty; }
                ViewCommande.lblDate.Text = rstBC.Fields["DateCommande"].Value;
                if (!(rstBC.Fields["DateRequise"].Value is DBNull)) { ViewCommande.lblDateRequise.Text = rstBC.Fields["DateRequise"].Value; } else { ViewCommande.lblDateRequise.Text = string.Empty; }
                ViewCommande.lblFax.Text = rstFRS.Fields["Fax"].Value; 
                ViewCommande.lblFournisseur.Text = rstFRS.Fields["NomFournisseur"].Value; 
                ViewCommande.lblTelephone.Text = rstFRS.Fields["telephonne"].Value; 
                ViewCommande.lblNoSoum.Text = rstBC.Fields["NoBonCommande"].Value; 
                ViewCommande.lblTotalFin.Text = (rstBC.Fields["total"].Value);
                if (!(rstBC.Fields["Transport"].Value is DBNull)) { ViewCommande.lblTransport.Text = rstBC.Fields["Transport"].Value; } else { ViewCommande.lblTransport.Text = " "; }
                rstFRS.Close();
                rstFRS = null;
                rstBC.Close();
                rstBC = null;
                rstBCPiece.Close();
                rstBCPiece = null;
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "ImprimerRetourDossier", ex);
            }
        }
        private void cmdInstructions_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new BonCommande_Instruction();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "cmdInstructions_Click", ex);
            }
        }
        private void EnregistrerBonCommandeRetourMarchandiseProjet()
        {
            try
            {
                ADODB.Recordset rstBC;
                ADODB.Recordset rstBCPiece;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstFRS;
                int X;
                double dblTotal;
                string sWhere;
                string sWherePiece;
                string sWhereNoLigne;
                string sEscompte;
                sWhere = "(IDProjet = '" + m_sNoProjet + "')";
                sWherePiece = "Projet_Pieces.NumItem In (";
                sWhereNoLigne = "Projet_Pieces.NuméroLigne In (";
                var lo_opto = (int)m_collPieces.Count;
                for (X = 1; X <= lo_opto; X++)
                {
                    if (X != m_collPieces.Count)
                    {
                        sWherePiece += "'" + m_collPieces[X].Replace( "'", "''") + "', ";
                        sWhereNoLigne += m_collNoLigne[X]+ ", ";
                    }
                    else
                    {
                        sWherePiece += "'" + m_collPieces[X].Replace("'", "''") + "')";
                        sWhereNoLigne += m_collNoLigne[X]+")";
                    }
                }
                rstFRS = new Recordset();
                rstBC = new Recordset();
                rstPiece = new Recordset();
                rstBCPiece = new Recordset();
                sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                rstFRS.Open("SELECT DISTINCT Projet_Pieces.IDFRS, FOURNISSEUR.CondTransport FROM Projet_Pieces" +
                    " INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstBC.Open("SELECT * FROM BonsCommandes", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstFRS.EOF)
                {
                    rstBC.AddNew();
                    rstBC.Fields["NoBonCommande"].Value = txtVotreNoSoum.Text;
                    rstBC.Fields["NoFournisseur"].Value = rstFRS.Fields["IDFRS"].Value;
                    rstBC.Fields["NoProjet"].Value = m_sNoProjet;
                    rstBC.Fields["Attention"].Value = string.Empty;
                    if (Conversions.ToBoolean(Operators.AndObject(!(rstFRS.Fields["CondTransport"].Value is DBNull), Operators.ConditionalCompareObjectNotEqual(rstFRS.Fields["CondTransport"].Value, string.Empty, false))))
                    {
                        rstBC.Fields["Transport"].Value = rstFRS.Fields["CondTransport"].Value;
                    }
                    else
                    {
                        rstBC.Fields["Transport"].Value = "Votre camion";
                    }
                    rstBC.Fields["DateRequise"].Value = ConvertDate(DateTime.Today);
                    rstBC.Fields["DateCommande"].Value = ConvertDate(DateTime.Today);
                    if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE)
                    {
                        rstBC.Fields["CommandePar"].Value = m_sEmploye;
                    }
                    else
                    {
                        rstBC.Fields["CommandePar"].Value = IdNomEmploye;
                    }
                    rstBC.Fields["LangueImpression"].Value = "Français";
                    sWhere =$"(IDProjet = '{m_sNoProjet}' AND IDFRS ={ rstFRS.Fields["IDFRS"].Value})";
                    sWherePiece = "NumItem In (";
                    sWhereNoLigne = "NuméroLigne In (";
                    var lo_opto1 = (int)m_collPieces.Count;
                    for (X = 1; X <= lo_opto1; X++)
                    {
                        if (X != m_collPieces.Count)
                        {
                            sWherePiece += "'" + m_collPieces[X].Replace("'", "''") + "', ";
                            sWhereNoLigne += m_collNoLigne[X]+ ", ";
                        }
                        else
                        {
                            sWherePiece += "'" + m_collPieces[X].Replace( "'", "''") + "')";
                            sWhereNoLigne+= m_collNoLigne[X]= ")";
                        }
                    }
                    sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    dblTotal = 0d;
                    while (!rstPiece.EOF)
                    {
                        rstBCPiece.Open($"SELECT * FROM BonsCommandes_Pieces WHERE NoItem = '{$"{rstPiece.Fields["NumItem"].Value}".Replace( "'", "''")}' " +
                            $"AND NoFournisseur =  { rstPiece.Fields["IDFRS"].Value}  AND NoBonCommande = '{txtVotreNoSoum.Text} ' AND Prix = ' {rstPiece.Fields["PrixOrigine"].Value}'"
                            , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!string.IsNullOrEmpty(Strings.Trim($"{rstPiece.Fields["ESCOMPTE"].Value}")))
                        {
                            sEscompte = Strings.Replace(Strings.Replace($"{rstPiece.Fields["ESCOMPTE"].Value}", ".", ","), "%", string.Empty);
                            while (double.Parse(sEscompte) > 1d)
                                sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                            dblTotal += double.Parse(double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                        }
                        else
                        {
                            dblTotal += double.Parse(double.Parse(rstPiece.Fields["PrixOrigine"].Value) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                        }
                        if (rstBCPiece.EOF)
                        {
                            rstBCPiece.AddNew();
                            rstBCPiece.Fields["NoBonCommande"].Value = txtVotreNoSoum.Text;
                            rstBCPiece.Fields["NoFournisseur"].Value = rstPiece.Fields["IDFRS"].Value;
                            rstBCPiece.Fields["Qté"].Value = $"{rstPiece.Fields["Qté"].Value}".Replace( "-", string.Empty);
                            rstBCPiece.Fields["NoItem"].Value = rstPiece.Fields["NumItem"].Value;
                            rstBCPiece.Fields["NuméroLigne"].Value = rstPiece.Fields["NuméroLigne"].Value;
                            rstBCPiece.Fields["Description"].Value = rstPiece.Fields["Desc_fr"].Value;
                            rstBCPiece.Fields["Manufact"].Value = rstPiece.Fields["Manufact"].Value;
                            rstBCPiece.Fields["Prix"].Value = rstPiece.Fields["PrixOrigine"].Value;
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["Escompte"].Value, string.Empty, false))){rstBCPiece.Fields["Escompte"].Value = rstPiece.Fields["Escompte"].Value;}else{rstBCPiece.Fields["Escompte"].Value = "0";}
                            if (!string.IsNullOrEmpty($"{rstPiece.Fields["Escompte"].Value}".Trim())){
                                sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace( ".", ",").Replace( "%", string.Empty);
                                while (double.Parse(sEscompte) > 1d)
                                    sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                                rstBCPiece.Fields["Total"].Value = (double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                            }else{
                                rstBCPiece.Fields["Total"].Value = (double.Parse(rstPiece.Fields["PrixOrigine"].Value) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                            }
                        }
                        else
                        {
                            rstBCPiece.Fields["Qté"].Value = double.Parse(rstBCPiece.Fields["Qté"].Value) + double.Parse(rstPiece.Fields["Qté"].Value);
                            rstBCPiece.Fields["NuméroLigne"].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(rstBCPiece.Fields["NuméroLigne"].Value, ", "), rstPiece.Fields["NuméroLigne"].Value);
                            if (!string.IsNullOrEmpty($"{rstPiece.Fields["Escompte"].Value}".Trim()))
                            {
                                sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace( ".", ",").Replace( "%", string.Empty);
                                while (double.Parse(sEscompte) > 1d)
                                    sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                                rstBCPiece.Fields["Total"].Value = (double.Parse(rstBCPiece.Fields["Total"].Value) + double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value));
                            }
                            else
                            {
                                rstBCPiece.Fields["Total"].Value = (double.Parse(rstBCPiece.Fields["Total"].Value) + double.Parse(rstPiece.Fields["PrixOrigine"].Value) * double.Parse(rstPiece.Fields["Qté"].Value));
                            }
                        }
                        rstBCPiece.Update();
                        rstBCPiece.Close();
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstBC.Fields["Total"].Value = dblTotal.ToString();
                    rstBC.Update();
                    rstFRS.MoveNext();
                }
                rstFRS.Close();
                rstFRS = null;
                rstBC.Close();
                rstBC = null;
                rstPiece = null;
                rstBCPiece = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "EnregistrerBonCommandeRetourMarchandiseProjet", ex);
            }
        }
        private void EnregistrerBonCommandeRetourMarchandiseAchat()
        {
            try
            {
                ADODB.Recordset rstBC;
                ADODB.Recordset rstBCPiece;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstFRS;
                int X;
                double dblTotal;
                string sWhere;
                string sWherePiece;
                string sWhereNoLigne;
                string sEscompte;
                sWhere = "(IDAchat = '" + m_sNoAchat + "' AND IndexAchat = " + m_iIndexAchat + ")";
                sWherePiece = "Achat_Pieces.PIECE In (";
                sWhereNoLigne = "Achat_Pieces.NuméroLigne In (";
                var lo_opto = (int)m_collPieces.Count;
                for (X = 1; X <= lo_opto; X++)
                {
                    if (X != m_collPieces.Count)
                    {
                        sWherePiece += "'" +m_collPieces[X].Replace( "'", "''") + "', ";
                        sWhereNoLigne += m_collNoLigne[X]= ", ";
                    }
                    else
                    {
                        sWherePiece += "'" +m_collPieces[X].Replace("'", "''") + "')";
                        sWhereNoLigne += m_collNoLigne[X]+")";
                    }
                }
                rstFRS = new Recordset();
                rstBC = new Recordset();
                rstPiece = new Recordset();
                rstBCPiece = new Recordset();
                sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                rstFRS.Open("SELECT DISTINCT ACHAT_PIECES.IDFRS, FOURNISSEUR.CONDTRANSPORT FROM ACHAT_PIECES " +
                    "INNER JOIN FOURNISSEUR ON ACHAT_PIECES.IDFRS = FOURNISSEUR.IDFRS " +
                    "WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstBC.Open("SELECT * FROM BONSCOMMANDES", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstFRS.EOF)
                {
                    rstBC.AddNew();
                    rstBC.Fields["NoBonCommande"].Value = txtVotreNoSoum.Text;
                    rstBC.Fields["NoFournisseur"].Value = rstFRS.Fields["IDFRS"].Value;
                    rstBC.Fields["NoProjet"].Value = m_sNoAchat + " - " + m_iIndexAchat;
                    rstBC.Fields["Attention"].Value = string.Empty;
                    if (Conversions.ToBoolean(Operators.AndObject(!(rstFRS.Fields["CondTransport"].Value is DBNull), Operators.ConditionalCompareObjectNotEqual(rstFRS.Fields["CondTransport"].Value, string.Empty, false)))){rstBC.Fields["Transport"].Value = rstFRS.Fields["CondTransport"].Value;}else{rstBC.Fields["Transport"].Value = "Votre camion";}
                    rstBC.Fields["DateRequise"].Value = ConvertDate(DateTime.Today);
                    rstBC.Fields["DateCommande"].Value = ConvertDate(DateTime.Today);
                    if (Procédure == EnumFormSource.I_RETOUR_MARCHANDISE){rstBC.Fields["CommandePar"].Value = m_sEmploye;}else{rstBC.Fields["CommandePar"].Value = IdNoEmploye;}
                    rstBC.Fields["LangueImpression"].Value = "Français";
                    sWhere = $"(IDAchat = ' {m_sNoAchat} ' AND IndexAchat = {m_iIndexAchat} AND IDFRS =  {rstFRS.Fields["IDFRS"].Value})";
                    sWherePiece = "PIECE In (";
                    sWhereNoLigne = "NuméroLigne In (";
                    var lo_opto1 = (int)m_collPieces.Count;
                    for (X = 1; X <= lo_opto1; X++)
                    {
                        if (X != m_collPieces.Count)
                        {
                            sWherePiece += "'" +m_collPieces[X].Replace("'", "''") + "', ";
                            sWhereNoLigne += m_collNoLigne[X]+ ", ";
                        }
                        else
                        {
                            sWherePiece += "'" + m_collPieces[X].Replace( "'", "''") + "')";
                            sWhereNoLigne += m_collNoLigne[X]+ ")";
                        }
                    }
                    sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                    rstPiece.Open("SELECT * FROM Achat_Pieces WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    dblTotal = 0d;
                    while (!rstPiece.EOF)
                    {
                        rstBCPiece.Open($"SELECT * FROM BonsCommandes_Pieces WHERE NoItem = ' {$"{rstPiece.Fields["PIECE"].Value}".Replace( "'", "''") }' AND NoFournisseur =  {rstPiece.Fields["IDFRS"].Value},  AND NoBonCommande = '{txtVotreNoSoum.Text}' AND Prix = '{rstPiece.Fields["PrixOrigine"].Value}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!string.IsNullOrEmpty($"{rstPiece.Fields["ESCOMPTE"].Value}".Trim()))
                        {
                            sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace( ".", ",").Replace( "%", string.Empty);
                            while (double.Parse(sEscompte) > 1d)
                                sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                            dblTotal += double.Parse(double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                        }
                        else
                        {
                            dblTotal += double.Parse(double.Parse(rstPiece.Fields["PrixOrigine"].Value) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                        }
                        if (rstBCPiece.EOF)
                        {
                            rstBCPiece.AddNew();
                            rstBCPiece.Fields["NoBonCommande"].Value = txtVotreNoSoum.Text;
                            rstBCPiece.Fields["NoFournisseur"].Value = rstPiece.Fields["IDFRS"].Value;
                            rstBCPiece.Fields["Qté"].Value = $"{rstPiece.Fields["Qté"].Value}".Replace("-", string.Empty);
                            rstBCPiece.Fields["NoItem"].Value = rstPiece.Fields["PIECE"].Value;
                            rstBCPiece.Fields["NuméroLigne"].Value = rstPiece.Fields["NuméroLigne"].Value;
                            rstBCPiece.Fields["Description"].Value = rstPiece.Fields["Desc_fr"].Value;
                            rstBCPiece.Fields["Manufact"].Value = rstPiece.Fields["Manufact"].Value;
                            rstBCPiece.Fields["Prix"].Value = rstPiece.Fields["PrixOrigine"].Value;
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["Escompte"].Value, string.Empty, false)))
                            {
                                rstBCPiece.Fields["Escompte"].Value = rstPiece.Fields["Escompte"].Value;
                            }
                            else
                            {
                                rstBCPiece.Fields["Escompte"].Value = "0";
                            }
                            if (!string.IsNullOrEmpty($"{rstPiece.Fields["Escompte"].Value}".Trim()))
                            {
                                sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace(".", ",").Replace( "%", string.Empty);
                                while (double.Parse(sEscompte) > 1d)
                                    sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                                rstBCPiece.Fields["Total"].Value = (double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                            }
                            else
                            {
                                rstBCPiece.Fields["Total"].Value = (double.Parse(rstPiece.Fields["PrixOrigine"].Value) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                            }
                        }
                        else
                        {
                            rstBCPiece.Fields["Qté"].Value = double.Parse(rstBCPiece.Fields["Qté"].Value) + double.Parse(rstPiece.Fields["Qté"].Value);
                            rstBCPiece.Fields["NuméroLigne"].Value = $"{rstBCPiece.Fields["NuméroLigne"].Value}, {rstPiece.Fields["NuméroLigne"].Value}";
                            if (!string.IsNullOrEmpty($"{rstPiece.Fields["Escompte"].Value}".Trim()))
                            {
                                sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace( ".", ",").Replace("%", string.Empty);
                                while (double.Parse(sEscompte) > 1d)
                                    sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                                rstBCPiece.Fields["Total"].Value = double.Parse(rstBCPiece.Fields["Total"].Value) + double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value);
                            }
                            else
                            {
                                rstBCPiece.Fields["Total"].Value = double.Parse(rstBCPiece.Fields["Total"].Value) + double.Parse(rstPiece.Fields["PrixOrigine"].Value) * double.Parse(rstPiece.Fields["Qté"].Value);
                            }
                        }
                        rstBCPiece.Update();
                        rstBCPiece.Close();
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstBC.Fields["Total"].Value = dblTotal.ToString();
                    rstBC.Update();
                    rstFRS.MoveNext();
                }
                rstFRS.Close();
                rstFRS = null;
                rstBC.Close();
                rstBC = null;
                rstPiece = null;
                rstBCPiece = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "EnregistrerBonCommandeRetourMarchandiseAchat", ex);
            }
        }
        private void EnregistrerBonCommandeProjet()
        {
            try
            {
                ADODB.Recordset rstBC;
                ADODB.Recordset rstBCPiece;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstFRS;
                int X;
                double dblTotal;
                string sType;
                string sWhere;
                string sWherePiece;
                string sWhereNoLigne;
                string sEscompte;
                if (Procédure == EnumFormSource.I_PROJET_ELEC)
                {
                    sType = "E";
                }
                else
                {
                    sType = "M";
                }
                sWhere = "(IDProjet = '" + m_sNoProjet + "' AND Type = '" + sType + "')";
                sWherePiece = "Projet_Pieces.NumItem In (";
                sWhereNoLigne = "Projet_Pieces.NuméroLigne In (";
                var lo_opto = (int)m_collPieces.Count;
                for (X = 1; X <= lo_opto; X++)
                {
                    if (X != m_collPieces.Count)
                    {
                        sWherePiece += "'" +m_collPieces[X].Replace( "'", "''") + "', ";
                        sWhereNoLigne += m_collNoLigne[X]= ", ";
                    }
                    else
                    {
                        sWherePiece += "'" + m_collPieces[X].Replace( "'", "''") + "')";
                        sWhereNoLigne += m_collNoLigne[X]+ ")";
                    }
                }
                rstBC = new Recordset();
                rstFRS = new Recordset();
                rstPiece = new Recordset();
                rstBCPiece = new Recordset();
                sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                rstFRS.Open("SELECT DISTINCT Projet_Pieces.IDFRS, FOURNISSEUR.CondTransport FROM Projet_Pieces " +
                    "INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                    "WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstBC.Open("SELECT * FROM BonsCommandes", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstFRS.EOF)
                {
                    rstBC.AddNew();
                    rstBC.Fields["NoBonCommande"].Value = txtNoBC.Text;
                    rstBC.Fields["NoFournisseur"].Value = rstFRS.Fields["IDFRS"].Value;
                    rstBC.Fields["NoProjet"].Value = m_sNoProjet;
                    rstBC.Fields["Attention"].Value = string.Empty;
                    if (Conversions.ToBoolean(Operators.AndObject(!(rstFRS.Fields["CondTransport"].Value is DBNull), Operators.ConditionalCompareObjectNotEqual(rstFRS.Fields["CondTransport"].Value, string.Empty, false))))
                    {
                        rstBC.Fields["Transport"].Value = rstFRS.Fields["CondTransport"].Value;
                    }
                    else
                    {
                        rstBC.Fields["Transport"].Value = "Votre camion";
                    }
                    if (Procédure == EnumFormSource.I_PROJET_ELEC)
                    {
                        rstBC.Fields["DateRequise"].Value = string.Empty;
                    }
                    else
                    {
                        rstBC.Fields["DateRequise"].Value = ConvertDate(DateTime.Today);
                    }
                    rstBC.Fields["DateCommande"].Value = ConvertDate(DateTime.Today);
                    rstBC.Fields["CommandePar"].Value = IdNomEmploye;
                    if (m_eLangage == enumLangage.FRANCAIS)
                    {
                        rstBC.Fields["LangueImpression"].Value = "Français";
                    }
                    else
                    {
                        rstBC.Fields["LangueImpression"].Value = "Anglais";
                    }
                    rstBC.Fields["Type"].Value = sType;
                    sWhere = $"(IDProjet = '{m_sNoProjet}' AND IDFRS = {rstFRS.Fields["IDFRS"].Value} )";
                    sWherePiece = "NumItem In (";
                    sWhereNoLigne = "NuméroLigne In (";
                    var lo_opto1 = (int)m_collPieces.Count;
                    for (X = 1; X <= lo_opto1; X++)
                    {
                        if (X != m_collPieces.Count)
                        {
                            sWherePiece += "'"+m_collPieces[X].Replace("'", "''") + "', ";
                            sWhereNoLigne += m_collNoLigne[X]+ ", ";
                        }
                        else
                        {
                            sWherePiece += "'" + m_collPieces[X].Replace( "'", "''") + "')";
                            sWhereNoLigne+= m_collNoLigne[X]+ ")";
                        }
                    }
                    sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    dblTotal = 0d;
                    while (!rstPiece.EOF)
                    {
                        rstBCPiece.Open($"SELECT * FROM BonsCommandes_Pieces WHERE NoItem = '{$"{rstPiece.Fields["NumItem"].Value}".Replace( "'", "''")}' " +
                            $"AND NoFournisseur ={ rstPiece.Fields["IDFRS"].Value} AND NoBonCommande = '{txtNoBC.Text}' AND Prix = '{rstPiece.Fields["PrixOrigine"].Value}'",
                            odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!string.IsNullOrEmpty($"{rstPiece.Fields["ESCOMPTE"].Value}".Trim()))
                        {
                            sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace( ".", ",").Replace( "%", string.Empty);
                            while (double.Parse(sEscompte) > 1d)
                                sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                            dblTotal += double.Parse(double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                        }
                        else
                        {
                            dblTotal += double.Parse(rstPiece.Fields["Qté"].Value) * double.Parse(rstPiece.Fields["PrixOrigine"].Value);
                        }
                        if (rstBCPiece.EOF)
                        {
                            rstBCPiece.AddNew();
                            rstBCPiece.Fields["Type"].Value = sType;
                            rstBCPiece.Fields["NoBonCommande"].Value = txtNoBC.Text;
                            rstBCPiece.Fields["NoFournisseur"].Value = rstPiece.Fields["IDFRS"].Value;
                            rstBCPiece.Fields["Qté"].Value = rstPiece.Fields["Qté"].Value;
                            rstBCPiece.Fields["NoItem"].Value = rstPiece.Fields["NumItem"].Value;
                            rstBCPiece.Fields["NuméroLigne"].Value = rstPiece.Fields["NuméroLigne"].Value;
                            if ($"{rstBC.Fields["LangueImpression"].Value}"== "Français"){rstBCPiece.Fields["Description"].Value = rstPiece.Fields["DESC_FR"].Value;}else{rstBCPiece.Fields["Description"].Value = rstPiece.Fields["DESC_EN"].Value;}
                            rstBCPiece.Fields["Manufact"].Value = rstPiece.Fields["Manufact"].Value;
                            rstBCPiece.Fields["Prix"].Value = rstPiece.Fields["PrixOrigine"].Value;
                            if ($"{rstPiece.Fields["Escompte"].Value}"!= string.Empty){rstBCPiece.Fields["Escompte"].Value = rstPiece.Fields["Escompte"].Value;}else{rstBCPiece.Fields["Escompte"].Value = "0";}
                            if (!string.IsNullOrEmpty($"{rstPiece.Fields["Escompte"].Value}".Trim()))
                            {
                                sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace( ".", ",").Replace( "%", string.Empty);
                                while (double.Parse(sEscompte) > 1d)
                                    sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                                rstBCPiece.Fields["Total"].Value = (double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();
                            }else{rstBCPiece.Fields["Total"].Value = (Operators.MultiplyObject(double.Parse(rstPiece.Fields["PrixOrigine"].Value), rstPiece.Fields["Qté"].Value));}
                        }
                        else
                        {
                            rstBCPiece.Fields["Qté"].Value = double.Parse(rstBCPiece.Fields["Qté"].Value) + double.Parse(rstPiece.Fields["Qté"].Value);
                            rstBCPiece.Fields["NuméroLigne"].Value = $"{rstBCPiece.Fields["NuméroLigne"].Value}, {rstPiece.Fields["NuméroLigne"].Value}";
                            if (!string.IsNullOrEmpty($"{rstPiece.Fields["Escompte"].Value}".Trim()))
                            {
                                sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace( ".", ",").Replace( "%", string.Empty);
                                while (double.Parse(sEscompte) > 1d)
                                    sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                                rstBCPiece.Fields["Total"].Value = double.Parse(rstBCPiece.Fields["Total"].Value) + double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value);
                            }else{rstBCPiece.Fields["Total"].Value = double.Parse(rstBCPiece.Fields["Total"].Value) + double.Parse(rstPiece.Fields["PrixOrigine"].Value) * double.Parse(rstPiece.Fields["Qté"].Value);}
                        }
                        rstBCPiece.Update();
                        rstBCPiece.Close();
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstBC.Fields["Total"].Value = dblTotal.ToString();
                    rstBC.Update();
                    rstFRS.MoveNext();
                }
                rstFRS.Close();
                rstFRS = null;
                rstBC.Close();
                rstBC = null;
                rstBCPiece = null;
                rstPiece = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "EnregistrerBonCommandeProjet", ex);
            }
        }
        private void EnregistrerBonCommandeAchat()
        {
            try
            {
                ADODB.Recordset rstFRS = new ADODB.Recordset();
                ADODB.Recordset rstBC = new ADODB.Recordset();
                ADODB.Recordset rstPiece = new ADODB.Recordset();
                ADODB.Recordset rstBCPiece = new ADODB.Recordset();
                int X;
                double dblTotal;
                string sType;
                string sWhere;
                string sWherePiece;
                string sWhereNoLigne;
                string sEscompte;
                if (Procédure == EnumFormSource.I_ACHAT_ELEC) { sType = "E"; } else { sType = "M"; }
                sWhere = "(IDAchat = '" + m_sNoAchat + "' AND IndexAchat = " + m_iIndexAchat + ")";
                sWherePiece = "Achat_Pieces.PIECE In (";
                sWhereNoLigne = "Achat_Pieces.NuméroLigne In (";
                for (X = 1; X <= m_collPieces.Count; X++)
                {
                    if (X != m_collPieces.Count){sWherePiece += "'" + m_collPieces[X].Replace( "'", "''") + "', ";sWhereNoLigne += m_collNoLigne[X]+ ", ";}else{sWherePiece += "'" + m_collPieces[X].Replace( "'", "''") + "')";sWhereNoLigne += m_collNoLigne[X]+ ")";}
                }
                sWhere += " AND " + sWherePiece + " AND " + sWhereNoLigne;
                rstFRS.Open("SELECT DISTINCT ACHAT_PIECES.IDFRS, FOURNISSEUR.CONDTRANSPORT FROM ACHAT_PIECES " +
                    "INNER JOIN FOURNISSEUR ON ACHAT_PIECES.IDFRS = FOURNISSEUR.IDFRS " +
                    "WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstBC.Open("SELECT * FROM BONSCOMMANDES", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstFRS.EOF)
                {
                    rstBC.AddNew();
                    rstBC.Fields["NoBonCommande"].Value = txtNoBC.Text;
                    rstBC.Fields["NoFournisseur"].Value = rstFRS.Fields["IDFRS"].Value;
                    rstBC.Fields["NoProjet"].Value = m_sNoAchat;
                    rstBC.Fields["Attention"].Value = string.Empty;
                    if (!(rstFRS.Fields["CondTransport"].Value is DBNull)& $"{rstFRS.Fields["CondTransport"].Value}"!= string.Empty){rstBC.Fields["Transport"].Value = rstFRS.Fields["CondTransport"].Value;}else{rstBC.Fields["Transport"].Value = "Votre camion";}
                    if (Procédure == EnumFormSource.I_ACHAT_ELEC){rstBC.Fields["DateRequise"].Value = string.Empty;}else{rstBC.Fields["DateRequise"].Value = ConvertDate(DateTime.Today);}
                    rstBC.Fields["DateCommande"].Value = ConvertDate(DateTime.Today);
                    rstBC.Fields["CommandePar"].Value = IdNomEmploye;
                    rstBC.Fields["LangueImpression"].Value = "Français";
                    rstBC.Fields["Type"].Value = sType;
                    rstPiece.Open($"SELECT * FROM Achat_Pieces WHERE {sWhere} AND IDFRS = {rstFRS.Fields["IDFRS"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    dblTotal = 0d;
                    while (!rstPiece.EOF)
                    {
                        rstBCPiece.Open($"SELECT * FROM BonsCommandes_Pieces WHERE NoItem = ' {$"{rstPiece.Fields["PIECE"].Value}".Replace( "'", "''")}'" +
                            $" AND NoFournisseur =  {rstPiece.Fields["IDFRS"].Value} AND NoBonCommande = '{txtNoBC.Text}' AND Prix = ' {rstPiece.Fields["PrixOrigine"].Value}'"
                            , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!string.IsNullOrEmpty($"{rstPiece.Fields["ESCOMPTE"].Value}".Trim()))
                        {
                            sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace( ".", ",").Replace("%", string.Empty);
                            while (double.Parse(sEscompte) > 1d)
                                sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                            if (!(rstPiece.Fields["PrixOrigine"].Value is DBNull)){dblTotal+= double.Parse(double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();}
                        }
                        else if (!(rstPiece.Fields["PrixOrigine"].Value is DBNull))
                        {
                            dblTotal += double.Parse(rstPiece.Fields["Qté"].Value) * double.Parse(rstPiece.Fields["PrixOrigine"].Value);
                        }
                        if (rstBCPiece.EOF)
                        {
                            rstBCPiece.AddNew();
                            rstBCPiece.Fields["Type"].Value = sType;
                            rstBCPiece.Fields["NoBonCommande"].Value = txtNoBC.Text;
                            rstBCPiece.Fields["NoFournisseur"].Value = rstPiece.Fields["IDFRS"].Value;
                            rstBCPiece.Fields["Qté"].Value = rstPiece.Fields["Qté"].Value;
                            rstBCPiece.Fields["NoItem"].Value = rstPiece.Fields["PIECE"].Value;
                            rstBCPiece.Fields["NuméroLigne"].Value = rstPiece.Fields["NuméroLigne"].Value;
                            rstBCPiece.Fields["Description"].Value = rstPiece.Fields["Desc_fr"].Value;
                            rstBCPiece.Fields["Manufact"].Value = rstPiece.Fields["Manufact"].Value;
                            rstBCPiece.Fields["Prix"].Value = rstPiece.Fields["PrixOrigine"].Value;
                            if (!(rstPiece.Fields["Escompte"].Value is DBNull)& $"{rstPiece.Fields["Escompte"].Value}"!=string.Empty){rstBCPiece.Fields["Escompte"].Value = rstPiece.Fields["Escompte"].Value;}else{rstBCPiece.Fields["Escompte"].Value = "0";}
                            if (!string.IsNullOrEmpty($"{rstPiece.Fields["Escompte"].Value}".Trim()))
                            {
                                sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace( ".", ",").Replace( "%", string.Empty);
                                while (double.Parse(sEscompte) > 1d)
                                    sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                                if (!(rstPiece.Fields["PrixOrigine"].Value is DBNull)){rstBCPiece.Fields["Total"].Value = (double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value)).ToString();}
                            }
                            else if (!(rstPiece.Fields["PrixOrigine"].Value is DBNull)){rstBCPiece.Fields["Total"].Value = (Operators.MultiplyObject(double.Parse(rstPiece.Fields["PrixOrigine"].Value), rstPiece.Fields["Qté"].Value));}
                        }
                        else
                        {
                            rstBCPiece.Fields["Qté"].Value = double.Parse(rstBCPiece.Fields["Qté"].Value) + double.Parse(rstPiece.Fields["Qté"].Value);
                            rstBCPiece.Fields["NuméroLigne"].Value = Operators.ConcatenateObject(Operators.ConcatenateObject(rstBCPiece.Fields["NuméroLigne"].Value, ", "), rstPiece.Fields["NuméroLigne"].Value);
                            if (!string.IsNullOrEmpty($"{rstPiece.Fields["Escompte"].Value}".Trim()))
                            {
                                sEscompte = $"{rstPiece.Fields["ESCOMPTE"].Value}".Replace(".", ",").Replace( "%", string.Empty);
                                while (double.Parse(sEscompte) > 1d)
                                    sEscompte = (double.Parse(sEscompte) / 100d).ToString();
                                rstBCPiece.Fields["Total"].Value = double.Parse(rstBCPiece.Fields["Total"].Value) + double.Parse(rstPiece.Fields["PrixOrigine"].Value) * (1d - double.Parse(sEscompte)) * double.Parse(rstPiece.Fields["Qté"].Value);
                            }
                            else
                            {
                                rstBCPiece.Fields["Total"].Value = double.Parse(rstBCPiece.Fields["Total"].Value) + double.Parse(rstPiece.Fields["PrixOrigine"].Value) * double.Parse(rstPiece.Fields["Qté"].Value);
                            }
                        }
                        rstBCPiece.Update();
                        rstBCPiece.Close();
                        rstPiece.MoveNext();
                    }
                    rstBC.Fields["Total"].Value = dblTotal.ToString();
                    rstBC.Update();
                    rstFRS.MoveNext();
                    rstPiece.Close();
                }
                rstFRS.Close();
                rstFRS = null;
                rstBC.Close();
                rstBC = null;
                rstPiece = null;
                rstBCPiece = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "EnregistrerBonCommande", ex);
            }
        }
        private void EnregistrerModifFournisseur()
        {
            try
            {
                ADODB.Recordset rstBC;
                ADODB.Recordset rstBCPiece;
                int X;
                ListViewItem itmBC;
                string sNoBC = txtNoBC.Text;
                rstBC = new Recordset();
                rstBC.Open("SELECT * FROM BonsCommandes WHERE NoBonCommande = '" + sNoBC + "' AND NoFournisseur = " + m_iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstBC.Fields["Attention"].Value = cmbContact.Text;
                rstBC.Fields["Transport"].Value = txtTransport.Text;
                rstBC.Fields["DateRequise"].Value = txtDateRequise.Text;
                rstBC.Fields["VotreNoSoum"].Value = txtNoBC.Text;
                rstBC.Fields["Commentaire"].Value = txtCommentaire.Text;
                rstBC.Fields["Total"].Value = txtTotal.Text;
                rstBC.Fields["AffichageInstructions"].Value = chkAfficherInstructions.CheckState;
                if (_optImpression_0.Checked == true)
                {
                    rstBC.Fields["LangueImpression"].Value = "Français";
                }
                else
                {
                    rstBC.Fields["LangueImpression"].Value = "Anglais";
                }
                rstBC.Update();
                rstBC.Close();
                rstBC = null;
                rstBCPiece = new Recordset();
                if (Procédure != EnumFormSource.I_PROJET_ELEC & Procédure != EnumFormSource.I_PROJET_MEC)
                {
                    var lo_opto = (int)lvwBonCommande.Items.Count;
                    for (X = 1; X <= lo_opto; X++)
                    {
                        itmBC = lvwBonCommande.Items[X];
                        rstBCPiece.Open("SELECT * FROM BonsCommandes_Pieces " +
                            "WHERE NoBonCommande = '" + sNoBC + "' AND NoFournisseur = " + m_iNoFRS + " AND NoItem = '" + itmBC.SubItems[(int)I_COL_NO_ITEM].Text.Replace( "'", "''") +
                            "' AND NuméroLigne = '"+itmBC.Tag+ "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstBCPiece.EOF)
                        {
                            rstBCPiece.Fields["Qté"].Value = itmBC.Text;
                            rstBCPiece.Fields["Total"].Value = itmBC.SubItems[I_COL_TOTAL].Text;
                            rstBCPiece.Update();
                        }
                        else
                        {
                            MessageBox.Show("Impossible d'enregistrer le bon de commande!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        rstBCPiece.Close();
                    }
                    rstBCPiece = null;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("BonCommande", "EnregistrerModifFournisseur", ex);
            }
        }
    }
}