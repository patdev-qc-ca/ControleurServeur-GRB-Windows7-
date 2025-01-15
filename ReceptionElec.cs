using System;
using System.Drawing;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ADODB;
using System.Data.SqlClient;
using System.Reflection;
using ControleurServeur;
using System.Collections.Generic;

namespace ControleurServeur
{
    internal class ReceptionElec : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ReceptionElec() : base()
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
        internal Button cmdNonRecu;
        public DateTimePicker mvwReception;
        public DateTimePicker mvwDateRequise;
        internal CheckBox chkProjetAchat;
        internal CheckBox chkDateRequise;
        internal TextBox txtProjetAchat;
        internal Button cmdImprimerPieces;
        internal Button cmdFermerPieces;
        internal Button cmdAfficher;
        internal TextBox txtDateRequise;
        internal Button cmdDateRequise;
        internal GroupBox fraPiecesNonRecues;
        internal Button cmdImprimer;
        internal ComboBox cmbType;
        internal Button cmdAnnuler;
        internal ComboBox cmbNoProjet;
        internal TextBox txtNoProjet;
        internal ListView lvwProjet;
        internal Button cmdFermer;
        internal Button cmdDate;
        internal TextBox txtDateReception;
        private ColumnHeader columnHeader10;
        internal Label Label1;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdNonRecu = new System.Windows.Forms.Button();
            this.mvwReception = new System.Windows.Forms.DateTimePicker();
            this.fraPiecesNonRecues = new System.Windows.Forms.GroupBox();
            this.lvwPieces = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mvwDateRequise = new System.Windows.Forms.DateTimePicker();
            this.chkProjetAchat = new System.Windows.Forms.CheckBox();
            this.chkDateRequise = new System.Windows.Forms.CheckBox();
            this.txtProjetAchat = new System.Windows.Forms.TextBox();
            this.cmdImprimerPieces = new System.Windows.Forms.Button();
            this.cmdFermerPieces = new System.Windows.Forms.Button();
            this.cmdAfficher = new System.Windows.Forms.Button();
            this.txtDateRequise = new System.Windows.Forms.TextBox();
            this.cmdDateRequise = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmbNoProjet = new System.Windows.Forms.ComboBox();
            this.txtNoProjet = new System.Windows.Forms.TextBox();
            this.lvwProjet = new System.Windows.Forms.ListView();
            this.QUANTITE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIECE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DESCRIPTION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MANUFACTURIER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DISTRIBUTEUR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATE_RECEPTION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATE_COMMANDE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATE_REQUISE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdFermer = new System.Windows.Forms.Button();
            this.cmdDate = new System.Windows.Forms.Button();
            this.txtDateReception = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fraPiecesNonRecues.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdNonRecu
            // 
            this.cmdNonRecu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdNonRecu.BackColor = System.Drawing.Color.Black;
            this.cmdNonRecu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdNonRecu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNonRecu.ForeColor = System.Drawing.Color.White;
            this.cmdNonRecu.Location = new System.Drawing.Point(244, 640);
            this.cmdNonRecu.Name = "cmdNonRecu";
            this.cmdNonRecu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdNonRecu.Size = new System.Drawing.Size(113, 25);
            this.cmdNonRecu.TabIndex = 18;
            this.cmdNonRecu.Text = "Pièces non recues";
            this.cmdNonRecu.UseVisualStyleBackColor = true;
            this.cmdNonRecu.Click += new System.EventHandler(this.cmdNonRecu_Click);
            // 
            // mvwReception
            // 
            this.mvwReception.BackColor = System.Drawing.Color.Black;
            this.mvwReception.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvwReception.ForeColor = System.Drawing.Color.White;
            this.mvwReception.Location = new System.Drawing.Point(616, 8);
            this.mvwReception.Name = "mvwReception";
            this.mvwReception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mvwReception.Size = new System.Drawing.Size(176, 22);
            this.mvwReception.TabIndex = 3;
            this.mvwReception.Visible = false;
            // 
            // fraPiecesNonRecues
            // 
            this.fraPiecesNonRecues.BackColor = System.Drawing.Color.Black;
            this.fraPiecesNonRecues.Controls.Add(this.lvwPieces);
            this.fraPiecesNonRecues.Controls.Add(this.mvwDateRequise);
            this.fraPiecesNonRecues.Controls.Add(this.chkProjetAchat);
            this.fraPiecesNonRecues.Controls.Add(this.chkDateRequise);
            this.fraPiecesNonRecues.Controls.Add(this.txtProjetAchat);
            this.fraPiecesNonRecues.Controls.Add(this.cmdImprimerPieces);
            this.fraPiecesNonRecues.Controls.Add(this.cmdFermerPieces);
            this.fraPiecesNonRecues.Controls.Add(this.cmdAfficher);
            this.fraPiecesNonRecues.Controls.Add(this.txtDateRequise);
            this.fraPiecesNonRecues.Controls.Add(this.cmdDateRequise);
            this.fraPiecesNonRecues.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraPiecesNonRecues.ForeColor = System.Drawing.Color.White;
            this.fraPiecesNonRecues.Location = new System.Drawing.Point(12, 119);
            this.fraPiecesNonRecues.Name = "fraPiecesNonRecues";
            this.fraPiecesNonRecues.Padding = new System.Windows.Forms.Padding(0);
            this.fraPiecesNonRecues.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraPiecesNonRecues.Size = new System.Drawing.Size(1343, 569);
            this.fraPiecesNonRecues.TabIndex = 7;
            this.fraPiecesNonRecues.TabStop = false;
            this.fraPiecesNonRecues.Visible = false;
            // 
            // lvwPieces
            // 
            this.lvwPieces.BackColor = System.Drawing.SystemColors.Window;
            this.lvwPieces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvwPieces.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPieces.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwPieces.FullRowSelect = true;
            this.lvwPieces.GridLines = true;
            this.lvwPieces.HideSelection = false;
            this.lvwPieces.Location = new System.Drawing.Point(8, 87);
            this.lvwPieces.Name = "lvwPieces";
            this.lvwPieces.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvwPieces.Size = new System.Drawing.Size(1327, 437);
            this.lvwPieces.TabIndex = 23;
            this.lvwPieces.UseCompatibleStateImageBehavior = false;
            this.lvwPieces.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "# Projet";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Qté";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PIECE";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DESCRIPTION";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MANUFACTURIER";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DISTRIBUTEUR";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "DATE_RECEPTION";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "DATE_COMMANDE";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "DATE_REQUISE";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PrixPieces";
            this.columnHeader9.Width = 80;
            // 
            // mvwDateRequise
            // 
            this.mvwDateRequise.BackColor = System.Drawing.Color.Black;
            this.mvwDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvwDateRequise.ForeColor = System.Drawing.Color.White;
            this.mvwDateRequise.Location = new System.Drawing.Point(427, 39);
            this.mvwDateRequise.Name = "mvwDateRequise";
            this.mvwDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mvwDateRequise.Size = new System.Drawing.Size(176, 22);
            this.mvwDateRequise.TabIndex = 8;
            this.mvwDateRequise.Visible = false;
            this.mvwDateRequise.ValueChanged += new System.EventHandler(this.mvwDateRequise_ValueChanged);
            // 
            // chkProjetAchat
            // 
            this.chkProjetAchat.BackColor = System.Drawing.Color.Black;
            this.chkProjetAchat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkProjetAchat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProjetAchat.ForeColor = System.Drawing.Color.White;
            this.chkProjetAchat.Location = new System.Drawing.Point(8, 48);
            this.chkProjetAchat.Name = "chkProjetAchat";
            this.chkProjetAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkProjetAchat.Size = new System.Drawing.Size(105, 17);
            this.chkProjetAchat.TabIndex = 22;
            this.chkProjetAchat.Text = "Projet :";
            this.chkProjetAchat.UseVisualStyleBackColor = true;
            this.chkProjetAchat.CheckStateChanged += new System.EventHandler(this.chkProjetAchat_CheckStateChanged);
            // 
            // chkDateRequise
            // 
            this.chkDateRequise.BackColor = System.Drawing.Color.Black;
            this.chkDateRequise.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateRequise.ForeColor = System.Drawing.Color.White;
            this.chkDateRequise.Location = new System.Drawing.Point(8, 16);
            this.chkDateRequise.Name = "chkDateRequise";
            this.chkDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDateRequise.Size = new System.Drawing.Size(105, 17);
            this.chkDateRequise.TabIndex = 21;
            this.chkDateRequise.Text = "Date Requise :";
            this.chkDateRequise.UseVisualStyleBackColor = true;
            this.chkDateRequise.CheckStateChanged += new System.EventHandler(this.chkDateRequise_CheckStateChanged);
            // 
            // txtProjetAchat
            // 
            this.txtProjetAchat.AcceptsReturn = true;
            this.txtProjetAchat.BackColor = System.Drawing.SystemColors.Window;
            this.txtProjetAchat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjetAchat.Enabled = false;
            this.txtProjetAchat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjetAchat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProjetAchat.Location = new System.Drawing.Point(112, 48);
            this.txtProjetAchat.MaxLength = 0;
            this.txtProjetAchat.Name = "txtProjetAchat";
            this.txtProjetAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProjetAchat.Size = new System.Drawing.Size(97, 22);
            this.txtProjetAchat.TabIndex = 20;
            // 
            // cmdImprimerPieces
            // 
            this.cmdImprimerPieces.BackColor = System.Drawing.Color.Black;
            this.cmdImprimerPieces.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdImprimerPieces.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimerPieces.ForeColor = System.Drawing.Color.White;
            this.cmdImprimerPieces.Location = new System.Drawing.Point(17, 530);
            this.cmdImprimerPieces.Name = "cmdImprimerPieces";
            this.cmdImprimerPieces.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImprimerPieces.Size = new System.Drawing.Size(105, 25);
            this.cmdImprimerPieces.TabIndex = 13;
            this.cmdImprimerPieces.Text = "Imprimer";
            this.cmdImprimerPieces.UseVisualStyleBackColor = true;
            this.cmdImprimerPieces.Click += new System.EventHandler(this.cmdImprimerPieces_Click);
            // 
            // cmdFermerPieces
            // 
            this.cmdFermerPieces.BackColor = System.Drawing.Color.Black;
            this.cmdFermerPieces.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdFermerPieces.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermerPieces.ForeColor = System.Drawing.Color.White;
            this.cmdFermerPieces.Location = new System.Drawing.Point(1221, 530);
            this.cmdFermerPieces.Name = "cmdFermerPieces";
            this.cmdFermerPieces.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFermerPieces.Size = new System.Drawing.Size(105, 25);
            this.cmdFermerPieces.TabIndex = 14;
            this.cmdFermerPieces.Text = "Fermer";
            this.cmdFermerPieces.UseVisualStyleBackColor = true;
            this.cmdFermerPieces.Click += new System.EventHandler(this.cmdFermerPieces_Click);
            // 
            // cmdAfficher
            // 
            this.cmdAfficher.BackColor = System.Drawing.Color.Black;
            this.cmdAfficher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAfficher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAfficher.ForeColor = System.Drawing.Color.White;
            this.cmdAfficher.Location = new System.Drawing.Point(272, 32);
            this.cmdAfficher.Name = "cmdAfficher";
            this.cmdAfficher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAfficher.Size = new System.Drawing.Size(73, 27);
            this.cmdAfficher.TabIndex = 11;
            this.cmdAfficher.Text = "Afficher";
            this.cmdAfficher.UseVisualStyleBackColor = true;
            this.cmdAfficher.Click += new System.EventHandler(this.cmdAfficher_Click);
            // 
            // txtDateRequise
            // 
            this.txtDateRequise.AcceptsReturn = true;
            this.txtDateRequise.BackColor = System.Drawing.SystemColors.Window;
            this.txtDateRequise.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateRequise.Enabled = false;
            this.txtDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateRequise.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDateRequise.Location = new System.Drawing.Point(112, 16);
            this.txtDateRequise.MaxLength = 0;
            this.txtDateRequise.Name = "txtDateRequise";
            this.txtDateRequise.ReadOnly = true;
            this.txtDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateRequise.Size = new System.Drawing.Size(97, 22);
            this.txtDateRequise.TabIndex = 9;
            // 
            // cmdDateRequise
            // 
            this.cmdDateRequise.BackColor = System.Drawing.Color.Black;
            this.cmdDateRequise.Enabled = false;
            this.cmdDateRequise.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDateRequise.ForeColor = System.Drawing.Color.White;
            this.cmdDateRequise.Location = new System.Drawing.Point(216, 16);
            this.cmdDateRequise.Name = "cmdDateRequise";
            this.cmdDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDateRequise.Size = new System.Drawing.Size(25, 19);
            this.cmdDateRequise.TabIndex = 10;
            this.cmdDateRequise.Text = "...";
            this.cmdDateRequise.UseVisualStyleBackColor = true;
            this.cmdDateRequise.Click += new System.EventHandler(this.cmdDateRequise_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdImprimer.BackColor = System.Drawing.Color.Black;
            this.cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimer.ForeColor = System.Drawing.Color.White;
            this.cmdImprimer.Location = new System.Drawing.Point(12, 640);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImprimer.Size = new System.Drawing.Size(105, 25);
            this.cmdImprimer.TabIndex = 16;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.Black;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.White;
            this.cmbType.Items.AddRange(new object[] {
            "Projet",
            "ReceptionElec"});
            this.cmbType.Location = new System.Drawing.Point(208, 8);
            this.cmbType.Name = "cmbType";
            this.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbType.Size = new System.Drawing.Size(97, 22);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAnnuler.AutoSize = true;
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.ForeColor = System.Drawing.Color.White;
            this.cmdAnnuler.Location = new System.Drawing.Point(124, 640);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(120, 26);
            this.cmdAnnuler.TabIndex = 17;
            this.cmdAnnuler.Text = "Annuler la réception";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmbNoProjet
            // 
            this.cmbNoProjet.BackColor = System.Drawing.Color.Black;
            this.cmbNoProjet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNoProjet.ForeColor = System.Drawing.Color.White;
            this.cmbNoProjet.Location = new System.Drawing.Point(320, 8);
            this.cmbNoProjet.Name = "cmbNoProjet";
            this.cmbNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbNoProjet.Size = new System.Drawing.Size(145, 22);
            this.cmbNoProjet.TabIndex = 1;
            this.cmbNoProjet.SelectedIndexChanged += new System.EventHandler(this.cmbNoProjet_SelectedIndexChanged);
            this.cmbNoProjet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbNoProjet_KeyUp);
            // 
            // txtNoProjet
            // 
            this.txtNoProjet.AcceptsReturn = true;
            this.txtNoProjet.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoProjet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNoProjet.Location = new System.Drawing.Point(320, 8);
            this.txtNoProjet.MaxLength = 0;
            this.txtNoProjet.Name = "txtNoProjet";
            this.txtNoProjet.ReadOnly = true;
            this.txtNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoProjet.Size = new System.Drawing.Size(145, 22);
            this.txtNoProjet.TabIndex = 2;
            this.txtNoProjet.Visible = false;
            // 
            // lvwProjet
            // 
            this.lvwProjet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwProjet.BackColor = System.Drawing.SystemColors.Window;
            this.lvwProjet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.QUANTITE,
            this.PIECE,
            this.DESCRIPTION,
            this.MANUFACTURIER,
            this.DISTRIBUTEUR,
            this.DATE_RECEPTION,
            this.DATE_COMMANDE,
            this.DATE_REQUISE});
            this.lvwProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwProjet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwProjet.HideSelection = false;
            this.lvwProjet.Location = new System.Drawing.Point(12, 65);
            this.lvwProjet.Name = "lvwProjet";
            this.lvwProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvwProjet.Size = new System.Drawing.Size(1343, 569);
            this.lvwProjet.TabIndex = 15;
            this.lvwProjet.UseCompatibleStateImageBehavior = false;
            this.lvwProjet.View = System.Windows.Forms.View.Details;
            this.lvwProjet.Click += new System.EventHandler(this.lvwProjet_Click);
            this.lvwProjet.DoubleClick += new System.EventHandler(this.lvwProjet_DoubleClick);
            // 
            // QUANTITE
            // 
            this.QUANTITE.Text = "QUANTITE";
            // 
            // PIECE
            // 
            this.PIECE.Text = "PIECE";
            this.PIECE.Width = 120;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Text = "DESCRIPTION";
            this.DESCRIPTION.Width = 200;
            // 
            // MANUFACTURIER
            // 
            this.MANUFACTURIER.Text = "MANUFACTURIER";
            this.MANUFACTURIER.Width = 200;
            // 
            // DISTRIBUTEUR
            // 
            this.DISTRIBUTEUR.Text = "DISTRIBUTEUR";
            this.DISTRIBUTEUR.Width = 150;
            // 
            // DATE_RECEPTION
            // 
            this.DATE_RECEPTION.Text = "DATE_RECEPTION";
            this.DATE_RECEPTION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DATE_RECEPTION.Width = 90;
            // 
            // DATE_COMMANDE
            // 
            this.DATE_COMMANDE.Text = "DATE_COMMANDE";
            this.DATE_COMMANDE.Width = 90;
            // 
            // DATE_REQUISE
            // 
            this.DATE_REQUISE.Text = "DATE_REQUISE";
            this.DATE_REQUISE.Width = 90;
            // 
            // cmdFermer
            // 
            this.cmdFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFermer.BackColor = System.Drawing.Color.Black;
            this.cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermer.ForeColor = System.Drawing.Color.White;
            this.cmdFermer.Location = new System.Drawing.Point(1266, 640);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFermer.Size = new System.Drawing.Size(81, 25);
            this.cmdFermer.TabIndex = 19;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.Cmdfermer_Click);
            // 
            // cmdDate
            // 
            this.cmdDate.BackColor = System.Drawing.Color.Black;
            this.cmdDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDate.ForeColor = System.Drawing.Color.White;
            this.cmdDate.Location = new System.Drawing.Point(744, 32);
            this.cmdDate.Name = "cmdDate";
            this.cmdDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDate.Size = new System.Drawing.Size(25, 19);
            this.cmdDate.TabIndex = 6;
            this.cmdDate.Text = "...";
            this.cmdDate.UseVisualStyleBackColor = true;
            this.cmdDate.Click += new System.EventHandler(this.cmdDate_Click);
            // 
            // txtDateReception
            // 
            this.txtDateReception.AcceptsReturn = true;
            this.txtDateReception.BackColor = System.Drawing.SystemColors.Window;
            this.txtDateReception.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateReception.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateReception.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDateReception.Location = new System.Drawing.Point(640, 32);
            this.txtDateReception.MaxLength = 0;
            this.txtDateReception.Name = "txtDateReception";
            this.txtDateReception.ReadOnly = true;
            this.txtDateReception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateReception.Size = new System.Drawing.Size(97, 22);
            this.txtDateReception.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(537, 34);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(97, 19);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Date de réception :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(471, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReceptionElec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1359, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdNonRecu);
            this.Controls.Add(this.mvwReception);
            this.Controls.Add(this.fraPiecesNonRecues);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmbNoProjet);
            this.Controls.Add(this.txtNoProjet);
            this.Controls.Add(this.lvwProjet);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmdDate);
            this.Controls.Add(this.txtDateReception);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(14, 42);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceptionElec";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.ReceptionElec";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceptionElec_FormClosed);
            this.Load += new System.EventHandler(this.ReceptionElec_Load);
            this.Click += new System.EventHandler(this.ReceptionElec_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReceptionElec_KeyDown);
            this.fraPiecesNonRecues.ResumeLayout(false);
            this.fraPiecesNonRecues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal ColumnHeader QUANTITE;
        internal ColumnHeader PIECE;
        internal ColumnHeader DESCRIPTION;
        internal ColumnHeader MANUFACTURIER;
        internal ColumnHeader DISTRIBUTEUR;
        internal ColumnHeader DATE_RECEPTION;
        internal ColumnHeader DATE_COMMANDE;
        internal ColumnHeader DATE_REQUISE;
        internal ListView lvwPieces;
        internal ColumnHeader columnHeader1;
        internal ColumnHeader columnHeader2;
        internal ColumnHeader columnHeader3;
        internal ColumnHeader columnHeader4;
        internal ColumnHeader columnHeader5;
        internal ColumnHeader columnHeader6;
        internal ColumnHeader columnHeader7;
        internal ColumnHeader columnHeader8;
        internal ColumnHeader columnHeader9;
        internal Button button1;
        private const int I_COL_QUANTITE = 0;
        private const int I_COL_PIECE = 1;
        private const int I_COL_DESCRIPTION = 2;
        private const int I_COL_MANUFACTURIER = 3;
        private const int I_COL_DISTRIBUTEUR = 4;
        private const int I_COL_DATE_RECEPTION = 5;
        private const int I_COL_DATE_COMMANDE = 6;
        private const int I_COL_DATE_REQUISE = 7;
        private const int I_LVW_PROJET = 0;
        private const int I_LVW_QUANTITE = 1;
        private const int I_LVW_PIECE = 2;
        private const int I_LVW_DESCRIPTION = 3;
        private const int I_LVW_FOURNISSEUR = 4;
        private const int I_LVW_DATE_COMMANDE = 5;
        private const int I_LVW_DATE_REQUISE = 6;
        private string m_sUserID;
        private string m_sNoProjet;
        private string m_sNoAchat;
        private EnumType m_eType;
        private List<String> m_collTable;
        private int m_iIndexReception;
        private string idLoginEmploye;
        public ReceptionElec(string idLoginEmploye, string text)
        {
            InitializeComponent();
            idLoginEmploye = idLoginEmploye;
            Text = text;
            Afficher(idLoginEmploye);
        }
        private void chkDateRequise_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkDateRequise.Checked)
                {
                    txtDateRequise.Enabled = true;
                    cmdDateRequise.Enabled = true;
                }
                else
                {
                    txtDateRequise.Enabled = false;
                    cmdDateRequise.Enabled = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "chkDateRequise_Click", ex); }
        }
        private void chkProjetAchat_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkProjetAchat.Checked)
                {
                    txtProjetAchat.Enabled = true;
                }
                else
                {
                    txtProjetAchat.Enabled = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "chkProjetAchat_Click", ex); }
        }
        private void cmbNoProjet_KeyUp(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                for (int X = 0; X <= cmbNoProjet.Items.Count - 1; X++)
                {
                    if (cmbNoProjet.Items[X].ToString().ToUpper() == cmbNoProjet.Text.ToUpper())
                    {
                        cmbNoProjet.SelectedIndex = X;
                        break;
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmbNoProjet_KeyUp", ex); }
        }
        private void cmbNoProjet_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjAchat;
                string sNumero;
                rstProjAchat = new Recordset();
                sNumero = txtNoProjet.Text;
                txtProjetAchat.Text = sNumero;
                if (m_eType == EnumType.ACHAT)
                {
                    rstProjAchat.Open("SELECT * FROM Achat WHERE IDAchat = '" + Gauche(cmbNoProjet.Text, 9) + "' AND IndexAchat = " + int.Parse(Droite(cmbNoProjet.Text, 3)), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstProjAchat.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + cmbNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                if ((bool)rstProjAchat.Fields["Modification"].Value== true)
                {
                    if (m_eType == EnumType.ACHAT)
                    {
                        MessageBox.Show($"Cet ACHAT est en modification par {rstProjAchat.Fields["Par"].Value} !");
                    }
                    else
                    {
                        MessageBox.Show($"Ce projet est en modification par { rstProjAchat.Fields["Par"].Value} !");
                    }
                    rstProjAchat.Close();
                    rstProjAchat = null;
                    cmbNoProjet.Text = sNumero;
                    cmdAfficher_Click(cmbNoProjet, eventArgs);
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                m_iIndexReception = 0;
                txtNoProjet.Text = cmbNoProjet.Text;
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    RemplirListViewProjet(txtNoProjet.Text);
                }
                else
                {
                    RemplirListViewAchat(txtNoProjet.Text);
                }
            //    VerifierBoutonAnnuler();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmbNoProjet_Click", ex); }
        }
        private void cmbType_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbType.SelectedIndex == 0)
                {
                    m_eType = EnumType.TYPE_PROJET;
                    RemplirComboProjet();
                }
                else
                {
                    m_eType = EnumType.ACHAT;
                    RemplirComboAchat();
                }
                if (fraPiecesNonRecues.Visible == true)
                {
                    if (m_eType == EnumType.ACHAT)
                    {
                        chkProjetAchat.Text = "No ACHAT : ";
                    }
                    else
                    {
                        chkProjetAchat.Text = "No projet : ";
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmbType_Click", ex); }
        }
        private void cmdAfficher_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                var bRemplir = default(bool);
                if (chkProjetAchat.Checked)
                {
                    if (!string.IsNullOrEmpty(txtProjetAchat.Text.Trim()))
                    {
                        if (m_eType == EnumType.ACHAT)
                        {
                            if (txtProjetAchat.Text.Trim().Length == 13)
                            {
                                bRemplir = true;
                            }
                            else
                            {
                                MessageBox.Show("Format de numéro d'ACHAT incorrect!");
                            }
                        }
                        else if (txtProjetAchat.Text.Trim().Length == 9)
                        {
                            bRemplir = true;
                        }
                        else
                        {
                            MessageBox.Show("Format de numéro de projet incorrect!");
                        }
                    }
                    else if (m_eType == EnumType.ACHAT)
                    {
                        MessageBox.Show("Le numéro de l'ACHAT est obligatoire!");
                    }
                    else
                    {
                        MessageBox.Show("Le numéro de projet est obligatoire!");
                    }
                }
                else
                {
                    bRemplir = true;
                }
                if (bRemplir == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    RemplirListePiecesNonRecues();
                    Cursor.Current = Cursors.Default;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmdAfficher_Click", ex); }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    AnnulerReceptionProjet();
                }
                else
                {
                    AnnulerReceptionAchat();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmdAnnuler_Click", ex); }
        }
        private void AnnulerReceptionProjet()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstModif;
                ADODB.Recordset rstEmploye;
                if (lvwProjet.Items.Count > 0)
                {
                    rstProjet = new Recordset();
                    rstProjet.Open("SELECT Modification, Par FROM ProjetElec WHERE IDProjet = '" + txtNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjet.Fields["Modification"].Value, false, false)))
                    {
                        rstPiece = new Recordset();
                        rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND Type = 'E' And NuméroLigne = " + lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstPiece.Fields["Recu"].Value = false;
                        rstPiece.Fields["Commandé"].Value = true;
                        rstPiece.Fields["DateRéception"].Value = "";
                        rstPiece.Update();
                        rstModif = new Recordset();
                        rstModif.Open("SELECT * FROM Projet_Modif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstModif.AddNew();
                        rstEmploye = new Recordset();
                        rstEmploye.Open("SELECT noEmploye FROM Employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstModif.Fields["Type"].Value = "E";
                        rstModif.Fields["IDProjet"].Value = txtNoProjet.Text;
                        rstModif.Fields["noEmployé"].Value = rstEmploye.Fields["noEmploye"].Value;
                        rstModif.Fields["Date"].Value = ConvertDate(DateTime.Today);
                        rstModif.Fields["Heure"].Value = DateTime.Now.ToShortTimeString();
                        rstModif.Fields["TypeModif"].Value = "RECEPTION";
                        rstEmploye.Close();
                        rstEmploye = null;
                        rstModif.Update();
                        rstModif.Close();
                        rstModif = null;
                        rstPiece.Close();
                        rstPiece = null;
                        if (Strings.UCase(lvwProjet.FocusedItem.SubItems[I_COL_DISTRIBUTEUR].Text) == "SOLUTION GRB INC.")
                        {
                            AjouterInventaireProjet();
                        }
                        else
                        {
                            SupprimerHistorique();
                        }
                        m_iIndexReception = lvwProjet.FocusedItem.Index;
                        RemplirListViewProjet(txtNoProjet.Text);
                    }
                    else
                    {
                        MessageBox.Show("Ce projet est en modification par ", rstProjet.Fields["Par"].Value + "!");
                    }
                    rstProjet.Close();
                    rstProjet = null;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "AnnulerReceptionProjet", ex); }
        }
        private void AnnulerReceptionAchat()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstAchat;
                string sIDAchat;
                int iIndexAchat;
                if (lvwProjet.Items.Count > 0)
                {
                    sIDAchat = Gauche(txtNoProjet.Text, 9);
                    iIndexAchat = int.Parse(Droite(txtNoProjet.Text, 3));
                    rstAchat = new Recordset();
                    rstAchat.Open("SELECT Modification, Par FROM Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstAchat.Fields["Modification"].Value, false, false)))
                    {
                        rstPiece = new Recordset();
                        rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " And NuméroLigne = ", lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstPiece.Fields["Recu"].Value = false;
                        rstPiece.Fields["Commandé"].Value = true;
                        rstPiece.Fields["DateRéception"].Value = "";
                        rstPiece.Update();
                        if (Conversions.ToBoolean(Operators.OrObject(int.Parse(Droite(sIDAchat, 2)) >= 0 & int.Parse(Droite(sIDAchat, 2)) <= 12, Operators.ConditionalCompareObjectEqual(rstPiece.Fields["IDFRS"].Value, 717, false))))
                        {
                            EnleverInventaireAchat();
                        }
                        rstPiece.Close();
                        rstPiece = null;
                        m_iIndexReception = lvwProjet.FocusedItem.Index;
                        RemplirListViewAchat(txtNoProjet.Text);
                    }
                    else
                    {
                        MessageBox.Show("Cet ACHAT est en modification par " + rstAchat.Fields["Par"].Value + "!");
                    }
                    rstAchat.Close();
                    rstAchat = null;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "AnnulerReceptionAchat", ex); }
        }
        private void EnleverInventaireAchat()
        {
            try
            {
                ADODB.Recordset rstInventaire;
                var sQuantite = default(string);
                if (MessageBox.Show("Voulez-vous modifier l'inventaire?", Application.CompanyName + ".Inventaire.Enlever", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstInventaire = new Recordset();
                    rstInventaire.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstInventaire.EOF)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInventaire.Fields["CommandeParBoite"].Value, true, false)))
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwProjet.FocusedItem.SubItems[I_COL_DISTRIBUTEUR].Tag, 717, false)))
                            {
                                rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(lvwProjet.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), "", ",");
                            }
                            else
                            {
                                rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(lvwProjet.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), ".", ",");
                            }
                            sQuantite = (double.Parse(lvwProjet.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString();
                        }
                        else
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwProjet.FocusedItem.SubItems[I_COL_DISTRIBUTEUR].Tag, 717, false)))
                            {
                                rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(lvwProjet.FocusedItem.Text)).ToString(), "", ",");
                            }
                            else
                            {
                                rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(lvwProjet.FocusedItem.Text)).ToString(), ".", ",");
                            }
                            sQuantite = double.Parse(lvwProjet.FocusedItem.Text).ToString();
                        }
                        rstInventaire.Update();
                    }
                    rstInventaire.Close();
                    rstInventaire = null;
                    SupprimerHistorique(sQuantite);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "EnleverInventaireAchat", ex); }
        }
        private void AjouterInventaireProjet()
        {
            try
            {
                ADODB.Recordset rstInventaire;
                var sQuantite = default(string);
                if (MessageBox.Show("Voulez-vous modifier l'inventaire?", Application.CompanyName + ".Inventaire.Ajouter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstInventaire = new Recordset();
                    rstInventaire.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstInventaire.EOF)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInventaire.Fields["CommandeParBoite"].Value, true, false)))
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(lvwProjet.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), ".", ",");
                            sQuantite = (double.Parse(lvwProjet.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString();
                        }
                        else
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(lvwProjet.FocusedItem.Text)).ToString(), ".", ",");
                            sQuantite = double.Parse(lvwProjet.FocusedItem.Text).ToString();
                        }
                        rstInventaire.Update();
                    }
                    rstInventaire.Close();
                    rstInventaire = null;
                    SupprimerHistorique(sQuantite);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "AjouterInventaireProjet", ex); }
        }
        private void cmdDateRequise_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDateRequise.Text))
                {
                    mvwDateRequise.Value = Conversions.ToDate(txtDateRequise.Text);
                }
                else
                {
                    mvwDateRequise.Value = DateTime.Today;
                }
                mvwDateRequise.Visible = true;
                mvwDateRequise.Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmdDateRequise_Click", ex); }
        }
        private void cmdFermerPieces_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraPiecesNonRecues.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmdFermerPieces_Click", ex); }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ImprimerReception();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmdImprimer_Click", ex); }
        }
        private void ImprimerReception()
        {
            try
            {
                ChoixDateImpressionReception f;
                if (m_eType == EnumType.ACHAT)
                {
                    f = new ChoixDateImpressionReception(txtNoProjet.Text, EnumCatalogue.ELECTRIQUE, EnumType.ACHAT);
                }
                else
                {
                    f = new ChoixDateImpressionReception(txtNoProjet.Text, EnumCatalogue.ELECTRIQUE, EnumType.TYPE_PROJET);
                }
                f.MdiParent = ActiveForm.MdiParent;
                f.Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "ImprimerReception", ex); }
        }
        private void cmdImprimerPieces_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstPiece;
                rstPiece = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET) 
                { 
                    if (chkDateRequise.Checked & chkProjetAchat.Checked)
                    {
                        rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER ON Fournisseur ON Projet_Pieces.IDFRS =Fournisseur.IDFRS " +
                            "WHERE Type = 'E' AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND IDProjet = '" + txtProjetAchat.Text + "' AND DateRequise <> '' ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else if (chkDateRequise.Checked)
                    {
                        rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER ON Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                            "WHERE Type = 'E' AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND DateRequise <> '' ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else if (chkProjetAchat.Checked)
                    {
                        rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER ON Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                            "WHERE Type = 'E' AND Commandé = 1 AND IDProjet = '" + txtProjetAchat.Text + "' ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER ON Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                            "WHERE Type = 'E' AND Commandé = 1 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                }
                else if (chkDateRequise.Checked & chkProjetAchat.Checked)
                {
                    rstPiece.Open("SELECT (Achat_Pieces.IDAchat + '-' + RIGHT('00' + Achat_Pieces.IndexAchat,3)) As NoAchat, Achat_Pieces.*, Fournisseur.NomFournisseur FROM Achat_Pieces " +
                        "INNER ON Fournisseur ON Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                        "WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND IDAchat = '" + Gauche(txtProjetAchat.Text, 9) +
                        "' AND IndexAchat = " + int.Parse(Droite(txtProjetAchat.Text, 3)) + " AND DateRequise <> '' " +
                        "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else if (chkDateRequise.Checked)
                {
                    rstPiece.Open("SELECT (Achat_Pieces.IDAchat + '-' + RIGHT('00' + Achat_Pieces.IndexAchat,3)) As NoAchat, Achat_Pieces.*," +
                        " Fournisseur.NomFournisseur FROM Achat_Pieces " +
                        "INNER ON Fournisseur ON Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                        "WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND DateRequise <> '' " +
                        "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else if (chkProjetAchat.Checked)
                {
                    rstPiece.Open("SELECT (Achat_Pieces.IDAchat + '-' + RIGHT('00' + Achat_Pieces.IndexAchat,3)) As NoAchat, Achat_Pieces.*, " +
                        "Fournisseur.NomFournisseur FROM Achat_Pieces " +
                        "INNER ON Fournisseur ON Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                        "WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND IDAchat = '" + Gauche(txtProjetAchat.Text, 9) + "' AND IndexAchat = " + 
                        int.Parse(Droite(txtProjetAchat.Text, 3)) + " ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstPiece.Open("SELECT (Achat_Pieces.IDAchat + '-' + RIGHT('00' + Achat_Pieces.IndexAchat,3)) As NoAchat, Achat_Pieces.*, " +
                        "Fournisseur.NomFournisseur FROM Achat_Pieces " +
                        "INNER ON Fournisseur ON Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                        "WHERE LEN(IDAchat) = 9 AND Commandé = 1 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                ViewBackOrder.Orientation = !isLandscape;
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    ViewBackOrder.lblTitre.Text="Projets électriques : Pièces non_ reçues";
                    ViewBackOrder.lblTitreProjetAchat.Text="Projet : ";
                }
                else
                {
                    ViewBackOrder.lblTitre.Text="Achats électriques : Pièces non_ reçues";
                    ViewBackOrder.lblTitreProjetAchat.Text="ACHAT : ";
                }
                ViewBackOrder.lblDate.Text = txtDateRequise.Text;
                ViewBackOrder.lblProjetAchat.Text = txtProjetAchat.Text;
                if (m_eType == EnumType.ACHAT)
                {
                    ViewBackOrder.lblTitreNoProjet.Text="# ACHAT";
                    ViewBackOrder.txtNoItem.Text="PIECE";
               //     ViewBackOrder.txtNoProjAchat.Text="NoAchat";
                }
                ViewBackOrder f = new ViewBackOrder(cmbNoProjet.Text,true);
                f.Show();
                rstPiece.Close();
                rstPiece = null;
                return;
            }
            catch (Exception  ex) { AfficherErreur("ReceptiON Elec", "cmdImprimerPieces_Click", ex); }
        }
        private void cmdNonRecu_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                lvwPieces.Items.Clear();
                if (m_eType == EnumType.ACHAT)
                {
                    chkProjetAchat.Text = "No ACHAT : ";
                }
                else
                {
                    chkProjetAchat.Text = "No projet : ";
                }
                fraPiecesNonRecues.Visible = true;
                RemplirListePiecesNonRecues();
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmdNonRecu_Click", ex); }
        }
        private void RemplirListePiecesNonRecues()
        {
            try
            {
                ADODB.Recordset rst = new ADODB.Recordset();
                lvwPieces.Items.Clear();
                rst = new Recordset();
                if (cmbType.Text == "Projet")
                {
                    if (chkDateRequise.Checked & chkProjetAchat.Checked)
                    {
                        rst.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                            "WHERE Type = 'E' AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND IDProjet = '" + txtProjetAchat.Text + "' AND DateRequise <> '' " +
                            "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else if (chkDateRequise.Checked)
                    {
                        rst.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS" +
                            " WHERE Type = 'E' AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND DateRequise <> '' " +
                            "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else if (chkProjetAchat.Checked)
                    {
                        rst.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                            "WHERE Type = 'E' AND Commandé = 1 AND IDProjet = '" + txtProjetAchat.Text + "' " +
                            "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rst.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                            "WHERE Type = 'E' AND Commandé = 1 " +
                            "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    while (!rst.EOF)
                    {
                        ListViewItem itm = lvwProjet.Items.Add(string.Empty);
                        itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[1].Value}"));
                        itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[4].Value}"));
                        itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[3].Value}"));
                        itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[5].Value}"));
                        itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[7].Value}"));
                        itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[45].Value}"));
                        itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[29].Value}"));
                        itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[36].Value}"));
                        itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[37].Value}"));
                        itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[14].Value}"));
                        rst.MoveNext();
                    }
                    rst.Close();
                }
                else
                {
                    if (chkDateRequise.Checked & chkProjetAchat.Checked)
                    {
                        rst.Open("SELECT Achat_Pieces.*, Fournisseur.NomFournisseur FROM Achat_Pieces " +
                            "INNER JOIN Fournisseur ON Achat_Pieces.IDfrs = Fournisseur.IDFRS " +
                            "WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND IDAchat = '" + Gauche(txtProjetAchat.Text, 9) +
                            "' AND IndexAchat = " + int.Parse(Droite(txtProjetAchat.Text, 3)) + " AND DateRequise <> ''" +
                            " ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else if (chkDateRequise.Checked)
                    {
                        rst.Open("SELECT Achat_Pieces.*, Fournisseur.NomFournisseur FROM Achat_Pieces " +
                            "INNER JOIN Fournisseur ON Achat_Pieces.IDfrs = Fournisseur.IDFRS " +
                            "WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND DateRequise <> ''" +
                            " ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else if (chkProjetAchat.Checked)
                    {
                        rst.Open("SELECT Achat_Pieces.*, Fournisseur.NomFournisseur FROM Achat_Pieces " +
                            "INNER JOIN Fournisseur ON Achat_Pieces.IDfrs = Fournisseur.IDFRS WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND IDAchat = '" + Gauche(txtProjetAchat.Text, 9) +
                            "' AND IndexAchat = " + int.Parse(Droite(txtProjetAchat.Text, 3)) +
                            " ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rst.Open("SELECT Achat_Pieces.*, Fournisseur.NomFournisseur FROM Achat_Pieces " +
                            "INNER JOIN Fournisseur ON Achat_Pieces.IDfrs = Fournisseur.IDFRS " +
                            "WHERE LEN(IDAchat) = 9 AND Commandé = 1 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    while (!rst.EOF)
                    {
                        ListViewItem itm = lvwProjet.Items.Add(string.Empty);
                        itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[1].Value}"));
                        itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[5].Value}"));
                        itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[3].Value}"));
                        itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[6].Value}"));
                        itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[8].Value}"));
                        itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[28].Value}"));
                        itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[19].Value}"));
                        itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[21].Value}"));
                        itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[22].Value}"));
                        itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[13].Value}"));
                        rst.MoveNext();
                    }
                    rst.Close();

                }

            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "RemplirListePiecesNonRecues", ex); }
        }
        private void ReceptionElec_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (eventArgs.KeyCode == Keys.I)
                {
                    ImprimerReception();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "Form_KeyDown", ex); }
        }
        private void ReceptionElec_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            try
            {
                m_sNoProjet = "";
                m_sNoAchat = "";
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "Form_Unload", ex); }
        }
        private void lvwProjet_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                VerifierBoutonAnnuler();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "lvwProjet_Click", ex); }
        }
        private void lvwProjet_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    ReceptionProjet();
                }
                else
                {
                    ReceptionAchat();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "lvwProjet_DblClick", ex); }
        }
        private void ReceptionProjet()
        {

            var g_sUserID = default(object);
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstCopiePiece;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstModif;
                ADODB.Recordset rstEmploye;
                string sQuantite;
                string sTotal;
                string sProfit;
                bool bSkip;
                if (lvwProjet.Items.Count > 0)
                {
                    rstProjet = new Recordset();
                    rstProjet.Open("SELECT Modification, Par, Profit FROM ProjetElec WHERE IDProjet = '" + txtNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjet.Fields["Modification"].Value, false, false)))
                    {
                        if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(lvwProjet.FocusedItem.ForeColor), COLOR_ORANGE, false), Operators.ConditionalCompareObjectEqual(ColorTranslator.ToOle(lvwProjet.FocusedItem.ForeColor), COLOR_BLEU, false)))) // COLOR_ORANGE ou bleu
                        {
                            sQuantite = Interaction.InputBox("Quelle est la quantité reçue?");
                            sQuantite = Strings.Replace(sQuantite, ".", ",");
                            sProfit = (string)rstProjet.Fields["Profit"].Value;
                            if (!string.IsNullOrEmpty(sQuantite))
                            {
                                if (IsNumeric(sQuantite))
                                {
                                    if (double.Parse(sQuantite) > 0d)
                                    {
                                        rstPiece = new Recordset();
                                        rstEmploye = new Recordset();
                                        rstModif = new Recordset();
                                        if (double.Parse(sQuantite) == double.Parse(lvwProjet.FocusedItem.Text))
                                        {
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND Type = 'E' AND NuméroLigne = ", lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstPiece.Fields["Recu"].Value = true;
                                            rstPiece.Fields["Commandé"].Value = false;
                                            rstPiece.Fields["DateRéception"].Value = txtDateReception.Text;
                                            rstPiece.Update();
                                            // Ajout aux modif
                                            rstModif.Open("SELECT * FROM Projet_Modif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstModif.AddNew();
                                            // UPGRADE_WARNING: Couldn't resolve default property of object g_sUserID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                            rstEmploye.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT noEmploye FROM Employés WHERE loginname = '", g_sUserID), "'"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstModif.Fields["Type"].Value = "E";
                                            rstModif.Fields["IDProjet"].Value = txtNoProjet.Text;
                                            rstModif.Fields["noEmployé"].Value = rstEmploye.Fields["noEmploye"].Value;
                                            rstModif.Fields["Date"].Value = ConvertDate(DateTime.Today);
                                            rstModif.Fields["Heure"].Value = DateAndTime.TimeOfDay;
                                            rstModif.Fields["TypeModif"].Value = "RECEPTION";
                                            rstEmploye.Close();
                                            rstModif.Update();
                                            rstModif.Close();
                                            rstPiece.Close();
                                            if (Strings.UCase(lvwProjet.FocusedItem.SubItems[I_COL_DISTRIBUTEUR].Text) == "SOLUTION GRB INC.")
                                            {
                                                EnleverInventaireProjet(sQuantite);
                                            }
                                            m_iIndexReception = lvwProjet.FocusedItem.Index;
                                            RemplirListViewProjet(txtNoProjet.Text);
                                        }
                                        else if (double.Parse(sQuantite) < double.Parse(lvwProjet.FocusedItem.Text))
                                        {
                                            rstCopiePiece = new Recordset();
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND Type = 'E' AND NuméroLigne = ", lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            sTotal = (string)rstPiece.Fields["Qté"].Value;
                                            rstPiece.Fields["Qté"].Value = sQuantite;
                                            if (!string.IsNullOrEmpty(Strings.Trim((string)rstPiece.Fields["Temps"].Value)))
                                            {
                                                rstPiece.Fields["Temps_total"].Value = double.Parse(Strings.Replace((string)rstPiece.Fields["Temps"].Value, ".", ",")) * double.Parse(Strings.Replace((string)rstPiece.Fields["Qté"].Value, "*", string.Empty));
                                            }
                                            else
                                            {
                                                rstPiece.Fields["Temps_total"].Value = string.Empty;
                                            }
                                            rstPiece.Fields["Prix_Total"].Value = Conversion_Renamed((string)Math.Round(Operators.MultiplyObject(Operators.MultiplyObject(double.Parse(Strings.Replace((string)rstPiece.Fields["Qté"].Value, "*", string.Empty)), rstPiece.Fields["Prix_net"].Value), Conversions.ToSingle(sProfit)), 2), EnumConvert.MODE_PAS_FORMAT);
                                            rstPiece.Fields["Profit_argent"].Value = Conversion_Renamed((string)Math.Round(Operators.SubtractObject(rstPiece.Fields["Prix_total"].Value, Operators.MultiplyObject(rstPiece.Fields["Prix_net"].Value, double.Parse(Strings.Replace((string)rstPiece.Fields["Qté"].Value, "*", string.Empty)))), 2), EnumConvert.MODE_PAS_FORMAT);
                                            rstPiece.Fields["Recu"].Value = true;
                                            rstPiece.Fields["Commandé"].Value = false;
                                            rstPiece.Fields["DateRéception"].Value = txtDateReception.Text;
                                            rstPiece.Update();
                                            rstCopiePiece.Open("SELECT * FROM Projet_Pieces", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstCopiePiece.AddNew();
                                            rstCopiePiece.Fields["IDProjet"].Value = rstPiece.Fields["IDProjet"].Value;
                                            rstCopiePiece.Fields["IDSection"].Value = rstPiece.Fields["IDSection"].Value;
                                            rstCopiePiece.Fields["NumItem"].Value = rstPiece.Fields["NumItem"].Value;
                                            rstCopiePiece.Fields["Qté"].Value = double.Parse(sTotal) - double.Parse(sQuantite);
                                            rstCopiePiece.Fields["Desc_FR"].Value = rstPiece.Fields["Desc_FR"].Value;
                                            rstCopiePiece.Fields["Desc_EN"].Value = rstPiece.Fields["Desc_EN"].Value;
                                            rstCopiePiece.Fields["Manufact"].Value = rstPiece.Fields["Manufact"].Value;
                                            rstCopiePiece.Fields["Prix_List"].Value = rstPiece.Fields["Prix_List"].Value;
                                            rstCopiePiece.Fields["Escompte"].Value = rstPiece.Fields["Escompte"].Value;
                                            rstCopiePiece.Fields["Prix_net"].Value = rstPiece.Fields["Prix_net"].Value;
                                            rstCopiePiece.Fields["IDFRS"].Value = rstPiece.Fields["IDFRS"].Value;
                                            rstCopiePiece.Fields["Temps"].Value = rstPiece.Fields["Temps"].Value;
                                            if (!string.IsNullOrEmpty(Strings.Trim((string)rstCopiePiece.Fields["Temps"].Value)))
                                            {
                                                rstCopiePiece.Fields["Temps_total"].Value = double.Parse(Strings.Replace((string)rstCopiePiece.Fields["Temps"].Value, ".", ",")) * double.Parse(Strings.Replace((string)rstCopiePiece.Fields["Qté"].Value, "*", string.Empty));
                                            }
                                            else
                                            {
                                                rstCopiePiece.Fields["Temps_total"].Value = string.Empty;
                                            }
                                            rstCopiePiece.Fields["Prix_Total"].Value = Conversion_Renamed((string)Math.Round(Operators.MultiplyObject(Operators.MultiplyObject(double.Parse(Strings.Replace((string)rstCopiePiece.Fields["Qté"].Value, "*", string.Empty)), rstCopiePiece.Fields["Prix_net"].Value), Conversions.ToSingle(sProfit)), 2), EnumConvert.MODE_PAS_FORMAT);
                                            rstCopiePiece.Fields["Profit_Pourcent"].Value = rstPiece.Fields["Profit_Pourcent"].Value;
                                            rstCopiePiece.Fields["Profit_argent"].Value = Conversion_Renamed((string)Math.Round(Operators.SubtractObject(rstCopiePiece.Fields["Prix_total"].Value, Operators.MultiplyObject(rstCopiePiece.Fields["Prix_net"].Value, double.Parse(Strings.Replace((string)rstCopiePiece.Fields["Qté"].Value, "*", string.Empty)))), 2), EnumConvert.MODE_PAS_FORMAT);
                                            rstCopiePiece.Fields["SousSection"].Value = rstPiece.Fields["SousSection"].Value;
                                            rstCopiePiece.Fields["OrdreSection"].Value = rstPiece.Fields["OrdreSection"].Value;
                                            rstCopiePiece.Fields["NuméroLigne"].Value = Operators.AddObject(rstPiece.Fields["NuméroLigne"].Value, 1);
                                            rstCopiePiece.Fields["PrixOrigine"].Value = rstPiece.Fields["PrixOrigine"].Value;
                                            rstCopiePiece.Fields["Type"].Value = rstPiece.Fields["Type"].Value;
                                            rstCopiePiece.Fields["Visible"].Value = rstPiece.Fields["Visible"].Value;
                                            rstCopiePiece.Fields["Commandé"].Value = true;
                                            rstCopiePiece.Fields["Quoté"].Value = rstPiece.Fields["Quoté"].Value;
                                            rstCopiePiece.Fields["Recu"].Value = false;
                                            rstCopiePiece.Fields["Retour"].Value = false;
                                            rstCopiePiece.Fields["NoRetour"].Value = string.Empty;
                                            rstCopiePiece.Fields["CommandeAnnulée"].Value = false;
                                            rstCopiePiece.Fields["DateRéception"].Value = string.Empty;
                                            rstCopiePiece.Fields["Facturation"].Value = rstPiece.Fields["Facturation"].Value;
                                            rstCopiePiece.Fields["ID"].Value = "";
                                            rstCopiePiece.Fields["PieceExtra"].Value = rstPiece.Fields["PieceExtra"].Value;
                                            rstCopiePiece.Fields["DateCommande"].Value = rstPiece.Fields["DateCommande"].Value;
                                            rstCopiePiece.Fields["DateRequise"].Value = rstPiece.Fields["DateRequise"].Value;
                                            rstCopiePiece.Fields["MatérielInutile"].Value = false;
                                            rstCopiePiece.Update();
                                            rstCopiePiece.Close();
                                            rstPiece.Close();
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND Type = 'E' AND NuméroLigne >= ", Operators.AddObject(lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag, 1)), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            bSkip = false;
                                            while (!rstPiece.EOF)
                                            {
                                                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["NumItem"].Value, lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, false), Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["Qté"].Value, double.Parse(sTotal) - double.Parse(sQuantite), false)), bSkip == true)))
                                                {
                                                    rstPiece.Fields["NuméroLigne"].Value = Operators.AddObject(rstPiece.Fields["NuméroLigne"].Value, 1);
                                                    rstPiece.Update();
                                                }
                                                else
                                                {
                                                    bSkip = true;
                                                }
                                                rstPiece.MoveNext();
                                            }
                                            rstPiece.Close();
                                            rstModif.Open("SELECT * FROM Projet_Modif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstModif.AddNew();
                                            rstEmploye.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT noEmploye FROM Employés WHERE loginname = '", g_sUserID), "'"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstModif.Fields["Type"].Value = "E";
                                            rstModif.Fields["IDProjet"].Value = txtNoProjet.Text;
                                            rstModif.Fields["noEmployé"].Value = rstEmploye.Fields["noEmploye"].Value;
                                            rstModif.Fields["Date"].Value = ConvertDate(DateTime.Today);
                                            rstModif.Fields["Heure"].Value = DateAndTime.TimeOfDay;
                                            rstModif.Fields["TypeModif"].Value = "RECEPTION";
                                            rstEmploye.Close();
                                            rstModif.Update();
                                            rstModif.Close();
                                            if (Strings.UCase(lvwProjet.FocusedItem.SubItems[I_COL_DISTRIBUTEUR].Text) == "SOLUTION GRB INC.")
                                            {
                                                EnleverInventaireProjet(sQuantite);
                                            }
                                            m_iIndexReception = lvwProjet.FocusedItem.Index;
                                            RemplirListViewProjet(txtNoProjet.Text);
                                            rstCopiePiece = null;
                                        }
                                        else
                                        {
                                            MessageBox.Show("La quantité est trop grande!");
                                        }
                                        rstPiece = null;
                                        rstEmploye = null;
                                        rstModif = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("La quantité doit être plus grande que 0!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Quantité non numérique!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce projet est en modification par " + rstProjet.Fields["Par"].Value + "!");
                    }
                    rstProjet.Close();
                    rstProjet = null;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "ReceptionProjet", ex); }
        }
        private void ReceptionAchat()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstCopiePiece;
                ADODB.Recordset rstAchat;
                string sQuantite;
                string sIDAchat;
                string sTotal;
                bool bSkip;
                int iIndexAchat;
                int iIDFRS;
                if (lvwProjet.Items.Count > 0)
                {
                    sIDAchat = Gauche(txtNoProjet.Text, 9);
                    iIndexAchat = int.Parse(Droite(txtNoProjet.Text, 3));
                    rstAchat = new Recordset();
                    rstAchat.Open("SELECT Modification, Par FROM Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstAchat.Fields["Modification"].Value, false, false)))
                    {
                        if (lvwProjet.FocusedItem.ForeColor == COLOR_ORANGE | lvwProjet.FocusedItem.ForeColor == COLOR_BLEU) // COLOR_ORANGE ou bleu
                        {
                            sQuantite = Interaction.InputBox("Quelle est la quantité reçue?");
                            sQuantite = sQuantite.Replace(".", ",");
                            if (!string.IsNullOrEmpty(sQuantite))
                            {
                                if (IsNumeric(sQuantite))
                                {
                                    if (double.Parse(sQuantite) > 0d)
                                    {
                                        rstPiece = new Recordset();
                                        if (double.Parse(sQuantite) == double.Parse(lvwProjet.FocusedItem.Text))
                                        {
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " AND NuméroLigne = ", lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstPiece.Fields["Recu"].Value = true;
                                            rstPiece.Fields["Commandé"].Value = false;
                                            rstPiece.Fields["DateRéception"].Value = txtDateReception.Text;
                                            rstPiece.Update();
                                            if (Conversions.ToBoolean(Operators.OrObject(int.Parse(Droite(sIDAchat, 2)) >= 1 & int.Parse(Droite(sIDAchat, 2)) <= 12, Operators.ConditionalCompareObjectEqual(rstPiece.Fields["IDFRS"].Value, 717, false))))
                                            {
                                                AjouterInventaireAchat(sQuantite);
                                            }
                                            rstPiece.Close();
                                            m_iIndexReception = lvwProjet.FocusedItem.Index;
                                            RemplirListViewAchat(txtNoProjet.Text);
                                        }
                                        else
                                        {
                                            if (double.Parse(sQuantite) < double.Parse(lvwProjet.FocusedItem.Text))
                                            {
                                                rstCopiePiece = new Recordset();
                                                rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " AND NuméroLigne = ", lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                                sTotal = (string)rstPiece.Fields["Qté"].Value;
                                                rstPiece.Fields["Qté"].Value = sQuantite;
                                                rstPiece.Fields["Prix_Total"].Value = Conversion_Renamed((string)Math.Round(Operators.MultiplyObject(double.Parse(Strings.Replace((string)rstPiece.Fields["Qté"].Value, "*", string.Empty)), rstPiece.Fields["Prix_net"].Value), 2), EnumConvert.MODE_PAS_FORMAT);
                                                rstPiece.Fields["Recu"].Value = true;
                                                rstPiece.Fields["Commandé"].Value = false;
                                                rstPiece.Fields["DateRéception"].Value = txtDateReception.Text;
                                                rstPiece.Update();
                                                rstCopiePiece.Open("SELECT * FROM Achat_Pieces", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                                rstCopiePiece.AddNew();
                                                rstCopiePiece.Fields["IDAchat"].Value = rstPiece.Fields["IDAchat"].Value;
                                                rstCopiePiece.Fields["IndexAchat"].Value = rstPiece.Fields["IndexAchat"].Value;
                                                rstCopiePiece.Fields["PIECE"].Value = rstPiece.Fields["PIECE"].Value;
                                                rstCopiePiece.Fields["Qté"].Value = double.Parse(sTotal) - double.Parse(sQuantite);
                                                rstCopiePiece.Fields["Desc_FR"].Value = rstPiece.Fields["Desc_FR"].Value;
                                                rstCopiePiece.Fields["Desc_EN"].Value = rstPiece.Fields["Desc_EN"].Value;
                                                rstCopiePiece.Fields["Manufact"].Value = rstPiece.Fields["Manufact"].Value;
                                                rstCopiePiece.Fields["Prix_List"].Value = rstPiece.Fields["Prix_List"].Value;
                                                rstCopiePiece.Fields["Escompte"].Value = rstPiece.Fields["Escompte"].Value;
                                                rstCopiePiece.Fields["Prix_net"].Value = rstPiece.Fields["Prix_net"].Value;
                                                rstCopiePiece.Fields["IDFRS"].Value = rstPiece.Fields["IDFRS"].Value;
                                                rstCopiePiece.Fields["Prix_Total"].Value = Conversion_Renamed((string)Math.Round(Operators.MultiplyObject(double.Parse(Strings.Replace((string)rstCopiePiece.Fields["Qté"].Value, "*", string.Empty)), rstCopiePiece.Fields["Prix_net"].Value), 2), EnumConvert.MODE_PAS_FORMAT);
                                                rstCopiePiece.Fields["NuméroLigne"].Value = (int)rstPiece.Fields["NuméroLigne"].Value++;
                                                rstCopiePiece.Fields["Type"].Value = rstPiece.Fields["Type"].Value;
                                                rstCopiePiece.Fields["Commandé"].Value = true;
                                                rstCopiePiece.Fields["Recu"].Value = false;
                                                rstCopiePiece.Fields["Retour"].Value = false;
                                                rstCopiePiece.Fields["NoRetour"].Value = string.Empty;
                                                rstCopiePiece.Fields["DateRéception"].Value = string.Empty;
                                                rstCopiePiece.Fields["DateCommande"].Value = rstPiece.Fields["DateCommande"].Value;
                                                rstCopiePiece.Fields["DateRequise"].Value = rstPiece.Fields["DateRequise"].Value;
                                                rstCopiePiece.Update();
                                                rstCopiePiece.Close();
                                                iIDFRS = int.Parse(rstPiece.Fields["IDFRS"].Value);
                                                rstPiece.Close();
                                                rstPiece.Open("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " AND NuméroLigne >= " + lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                                bSkip = false;
                                                while (!rstPiece.EOF)
                                                {
                                                    if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["PIECE"].Value, lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, false), Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["Qté"].Value, double.Parse(sTotal) - double.Parse(sQuantite), false)), bSkip == true)))
                                                    {
                                                        rstPiece.Fields["NuméroLigne"].Value = Operators.AddObject(rstPiece.Fields["NuméroLigne"].Value, 1);
                                                        rstPiece.Update();
                                                    }
                                                    else
                                                    {
                                                        bSkip = true;
                                                    }
                                                    rstPiece.MoveNext();
                                                }
                                                rstPiece.Close();
                                                if (int.Parse(Droite(sIDAchat, 2)) >= 0 & int.Parse(Droite(sIDAchat, 2)) <= 12 | iIDFRS == 717)
                                                {
                                                    AjouterInventaireAchat(sQuantite);
                                                }
                                                m_iIndexReception = lvwProjet.FocusedItem.Index;
                                                RemplirListViewAchat(txtNoProjet.Text);
                                                rstCopiePiece = null;
                                            }
                                            else
                                            {
                                                MessageBox.Show("La quantité est trop grande!");
                                            }
                                            rstPiece = null;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("La quantité doit être plus grande que 0!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Quantité non numérique!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cet ACHAT est en modification par " + rstAchat.Fields["Par"].Value + "!");
                    }
                    rstAchat.Close();
                    rstAchat = null;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "ReceptionAchat", ex); }
        }
        private void EnleverInventaireProjet(string sQuantite)
        {
            var g_sLocalisation = default(object);
            var g_sQteBoite = default(object);
            var g_bQteBoite = default(object);
            try
            {
                ADODB.Recordset rstInventaire;
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstProjet;
                if (MessageBox.Show("Voulez-vous modifier l'inventaire?", Application.CompanyName + ".Inventaire.Enlever", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstInventaire = new Recordset();
                    rstInventaire.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstInventaire.EOF)
                    {
                        rstInventaire.AddNew();
                        rstInventaire.Fields["NoItem"].Value = lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text;
                        rstInventaire.Fields["Description"].Value = lvwProjet.FocusedItem.SubItems[I_COL_DESCRIPTION].Text;
                        rstInventaire.Fields["Manufacturier"].Value = lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Text;
                        Form a = new ChoixQteBoite(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text);
                        rstInventaire.Fields["CommandeParBoite"].Value = g_bQteBoite;
                        rstInventaire.Fields["QteBoite"].Value = g_sQteBoite;
                        rstInventaire.Fields["Commentaires"].Value = "";
                        rstInventaire.Fields["QuantitéStock"].Value = "0";
                        Form b = new ChoixLocalisation(EnumCatalogue.ELECTRIQUE, lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text);
                        rstInventaire.Fields["Localisation"].Value = g_sLocalisation;
                        rstInventaire.Fields["Minimum"].Value = false;
                        rstInventaire.Fields["QuantitéMinimum"].Value = "";
                        rstInventaire.Fields["Commande"].Value = "";
                    }
                    rstProjet = new Recordset();
                    rstProjet.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND NuméroLigne = ", lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInventaire.Fields["CommandeParBoite"].Value, true, false)))
                    {
                        rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(sQuantite) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), ".", ",");
                        if (!(rstProjet.Fields["Prix_List"].Value is DBNull))
                        {
                            if (!(rstInventaire.Fields["QteBoite"].Value is DBNull))
                            {
                                rstInventaire.Fields["Prix Liste"].Value = Strings.Replace((string)Operators.DivideObject(rstProjet.Fields["Prix_List"].Value, rstInventaire.Fields["QteBoite"].Value), ".", ",");
                            }
                            else
                            {
                                rstInventaire.Fields["Prix Liste"].Value = rstProjet.Fields["Prix_List"].Value;
                            }
                        }
                        else
                        {
                            rstInventaire.Fields["Prix Liste"].Value = "0";
                        }
                        rstInventaire.Fields["Escompte"].Value = rstProjet.Fields["Escompte"].Value;
                        if (!(rstInventaire.Fields["QteBoite"].Value is DBNull))
                        {
                            rstInventaire.Fields["Prix net"].Value = Strings.Replace((string)Operators.DivideObject(rstProjet.Fields["Prix_Net"].Value, rstInventaire.Fields["QteBoite"].Value), ".", ",");
                        }
                        else
                        {
                            rstInventaire.Fields["Prix net"].Value = rstProjet.Fields["Prix_Net"].Value;
                        }
                    }
                    else
                    {
                        rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(sQuantite)).ToString(), ".", ",");
                        if (!(rstProjet.Fields["Prix_List"].Value is DBNull))
                        {
                            rstInventaire.Fields["Prix Liste"].Value = rstProjet.Fields["Prix_List"].Value;
                        }
                        else
                        {
                            rstInventaire.Fields["Prix Liste"].Value = "0";
                        }
                        rstInventaire.Fields["Escompte"].Value = rstProjet.Fields["Escompte"].Value;
                        rstInventaire.Fields["Prix net"].Value = rstProjet.Fields["Prix_net"].Value;
                    }
                    rstInventaire.Update();
                    rstPieceFRS = new Recordset();
                    rstPieceFRS.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "' AND IDFRS = 717", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstPieceFRS.EOF)
                    {
                        rstPieceFRS.AddNew();
                        rstPieceFRS.Fields["IDFRS"].Value = 717;
                        rstPieceFRS.Fields["PIECE"].Value = lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text;
                        rstPieceFRS.Fields["PERS_RESS"].Value = 901;
                        rstPieceFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                        rstPieceFRS.Fields["DeviseMonétaire"].Value = "CAN";
                        rstPieceFRS.Fields["Type"].Value = "E";
                    }
                    rstPieceFRS.Fields["PRIX_LIST"].Value = rstProjet.Fields["Prix_List"].Value;
                    rstPieceFRS.Fields["ESCOMPTE"].Value = rstProjet.Fields["Escompte"].Value;
                    rstPieceFRS.Fields["PRIX_NET"].Value = rstProjet.Fields["Prix_net"].Value;
                    rstPieceFRS.Fields["DATE"].Value = txtDateReception.Text;
                    rstPieceFRS.Update();
                    rstPieceFRS.Close();
                    rstPieceFRS = null;
                    rstProjet.Close();
                    rstProjet = null;
                    if ((bool)rstInventaire.Fields["CommandeParBoite"].Value == true)
                    {
                        sQuantite = (double.Parse(sQuantite) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString().Replace(".", ",");
                    }
                    rstInventaire.Close();
                    rstInventaire = null;
                    AjouterHistorique(sQuantite);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "EnleverInventaireProjet", ex); }
        }
        private void AjouterInventaireAchat(string sQuantite)
        {
            var g_sLocalisation = default(object);
            var g_sQteBoite = default(object);
            var g_bQteBoite = default(object);
            try
            {
                ADODB.Recordset rstInventaire;
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstAchat;
                string sIDAchat;
                int iIndexAchat;
                int X;
                if (MessageBox.Show("Voulez-vous modifier l'inventaire?", Application.CompanyName + ".Inventaire.Enlever", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstInventaire = new Recordset();
                    rstInventaire.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstInventaire.EOF)
                    {
                        rstInventaire.AddNew();
                        rstInventaire.Fields["NoItem"].Value = lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text;
                        rstInventaire.Fields["Description"].Value = lvwProjet.FocusedItem.SubItems[I_COL_DESCRIPTION].Text;
                        rstInventaire.Fields["Manufacturier"].Value = lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Text;
                        Form a = new ChoixQteBoite(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text);
                        a.ShowDialog();
                        rstInventaire.Fields["CommandeParBoite"].Value = g_bQteBoite;
                        rstInventaire.Fields["QteBoite"].Value = g_sQteBoite;
                        rstInventaire.Fields["Commentaires"].Value = "";
                        rstInventaire.Fields["QuantitéStock"].Value = "0";
                        Form b = new ChoixLocalisation(EnumCatalogue.ELECTRIQUE, lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text);
                        b.ShowDialog();
                        rstInventaire.Fields["Localisation"].Value = g_sLocalisation;
                        rstInventaire.Fields["Minimum"].Value = false;
                        rstInventaire.Fields["QuantitéMinimum"].Value = "";
                        rstInventaire.Fields["Commande"].Value = "";
                    }
                    sIDAchat = Gauche(txtNoProjet.Text, 9);
                    iIndexAchat = int.Parse(Droite(txtNoProjet.Text, 3));
                    rstAchat = new Recordset();
                    rstAchat.Open(Operators.ConcatenateObject("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " AND NuméroLigne = ", lvwProjet.FocusedItem.SubItems[I_COL_MANUFACTURIER].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if ((bool)rstInventaire.Fields["CommandeParBoite"].Value == true)
                    {
                        if ((int)rstAchat.Fields["IDFRS"].Value == 717)
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = (double.Parse(rstInventaire.Fields["QuantitéStock"].Value) -
                                double.Parse(sQuantite) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString().Replace(".", ",");
                        }
                        else
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = (double.Parse(rstInventaire.Fields["QuantitéStock"].Value) +
                                double.Parse(sQuantite) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString().Replace(".", ",");
                        }
                        if (!(rstAchat.Fields["Prix_List"].Value is DBNull))
                        {
                            if (!(rstInventaire.Fields["QteBoite"].Value is DBNull))
                            {
                                rstInventaire.Fields["Prix Liste"].Value = (string)(double.Parse(rstAchat.Fields["Prix_List"].Value) / double.Parse(rstInventaire.Fields["QteBoite"].Value)).Replace(".", ",");
                            }
                            else
                            {
                                rstInventaire.Fields["Prix Liste"].Value = rstAchat.Fields["Prix_List"].Value;
                            }
                        }
                        else
                        {
                            rstInventaire.Fields["Prix Liste"].Value = "0";
                        }
                        rstInventaire.Fields["Escompte"].Value = rstAchat.Fields["Escompte"].Value;
                        if (!(rstInventaire.Fields["QteBoite"].Value is DBNull))
                        {
                            rstInventaire.Fields["Prix net"].Value = (string)(double.Parse(rstAchat.Fields["Prix_Net"].Value) / double.Parse(rstInventaire.Fields["QteBoite"].Value)).Replace(".", ",");
                        }
                        else
                        {
                            rstInventaire.Fields["Prix net"].Value = rstAchat.Fields["Prix_Net"].Value;
                        }
                    }
                    else
                    {
                        if (rstAchat.Fields["IDFRS"].Value != 717)
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = (double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(sQuantite)).ToString().Replace(".", ",");
                        }
                        else
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = (double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(sQuantite)).ToString().Replace(".", ",");
                        }
                        if (!(rstAchat.Fields["Prix_List"].Value is DBNull))
                        {
                            rstInventaire.Fields["Prix Liste"].Value = "0";
                        }
                        else
                        {
                            rstInventaire.Fields["Prix Liste"].Value = rstAchat.Fields["Prix_List"].Value;
                        }
                        rstInventaire.Fields["Escompte"].Value = rstAchat.Fields["Escompte"].Value;
                        rstInventaire.Fields["Prix net"].Value = rstAchat.Fields["Prix_Net"].Value;
                    }
                    rstInventaire.Update();
                    rstPieceFRS = new Recordset();
                    rstPieceFRS.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "' AND IDFRS = 717", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstPieceFRS.EOF)
                    {
                        rstPieceFRS.AddNew();
                        rstPieceFRS.Fields["IDFRS"].Value = 717;
                        rstPieceFRS.Fields["PIECE"].Value = lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text;
                        rstPieceFRS.Fields["PERS_RESS"].Value = 901;
                        rstPieceFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                        rstPieceFRS.Fields["DeviseMonétaire"].Value = "CAN";
                        rstPieceFRS.Fields["Type"].Value = "E";
                    }
                    rstPieceFRS.Fields["PRIX_LIST"].Value = rstAchat.Fields["Prix_List"].Value;
                    rstPieceFRS.Fields["ESCOMPTE"].Value = rstAchat.Fields["Escompte"].Value;
                    rstPieceFRS.Fields["PRIX_NET"].Value = rstAchat.Fields["Prix_net"].Value;
                    rstPieceFRS.Fields["DATE"].Value = txtDateReception.Text;
                    rstPieceFRS.Update();
                    rstPieceFRS.Close();
                    rstPieceFRS = null;
                    rstAchat.Close();
                    rstAchat = null;
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInventaire.Fields["CommandeParBoite"].Value, true, false)))
                    {
                        sQuantite = (double.Parse(sQuantite) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString();
                    }
                    rstInventaire.Close();
                    rstInventaire = null;
                    AjouterHistorique(sQuantite);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "AjouterInventaireAchat", ex); }
        }
        private void AjouterHistorique(string sQuantite)
        {
            try
            {
                ADODB.Recordset rstHist;
                rstHist = new Recordset();
                rstHist.Open("SELECT * FROM InventaireElecModif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstHist.AddNew();
                rstHist.Fields["Date"].Value = txtDateReception.Text;
                rstHist.Fields["IDProjet"].Value = txtNoProjet.Text;
                rstHist.Fields["NoItem"].Value = lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text;
                if (m_eType == EnumType.ACHAT)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwProjet.FocusedItem.SubItems[I_COL_DISTRIBUTEUR].Tag, 717, false)))
                    {
                        rstHist.Fields["Quantité"].Value = "-" + sQuantite;
                    }
                    else
                    {
                        rstHist.Fields["Quantité"].Value = sQuantite;
                    }
                }
                else
                {
                    rstHist.Fields["Quantité"].Value = "-" + sQuantite;
                }
                rstHist.Fields["User"].Value = Conteneur.idInitiales.Text;
                rstHist.Update();
                rstHist.Close();
                rstHist = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "AjouterHistorique", ex); }
        }
        private void SupprimerHistorique(string sQuantite = "")
        {
            try
            {
                ADODB.Recordset rstHist;
                rstHist = new Recordset();
                if (m_eType == EnumType.ACHAT)
                {
                    if (!string.IsNullOrEmpty(sQuantite))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwProjet.FocusedItem.SubItems[I_COL_DISTRIBUTEUR].Tag, 717, false)))
                        {
                            rstHist.Open("SELECT * FROM InventaireElecModif " +
                                "WHERE [Date] = '" + lvwProjet.FocusedItem.SubItems[I_COL_DATE_RECEPTION].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "' AND Quantité = '-" + sQuantite + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstHist.Open("SELECT * FROM InventaireElecModif " +
                                "WHERE [Date] = '" + lvwProjet.FocusedItem.SubItems[I_COL_DATE_RECEPTION].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "' AND Quantité = '" + sQuantite + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwProjet.FocusedItem.SubItems[I_COL_DISTRIBUTEUR].Tag, 717, false)))
                    {
                        rstHist.Open("SELECT * FROM InventaireElecModif " +
                            "WHERE [Date] = '" + lvwProjet.FocusedItem.SubItems[I_COL_DATE_RECEPTION].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "' AND Quantité = '-" + lvwProjet.FocusedItem.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstHist.Open("SELECT * FROM InventaireElecModif" +
                            " WHERE [Date] = '" + lvwProjet.FocusedItem.SubItems[I_COL_DATE_RECEPTION].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "' AND Quantité = '" + lvwProjet.FocusedItem.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                }
                else if (!string.IsNullOrEmpty(sQuantite))
                {
                    rstHist.Open("SELECT * FROM InventaireElecModif " +
                        "WHERE [Date] = '" + lvwProjet.FocusedItem.SubItems[I_COL_DATE_RECEPTION].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "' AND Quantité = '" + "-" + sQuantite + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstHist.Open("SELECT * FROM InventaireElecModif " +
                        "WHERE [Date] = '" + lvwProjet.FocusedItem.SubItems[I_COL_DATE_RECEPTION].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(lvwProjet.FocusedItem.SubItems[I_COL_PIECE].Text, "'", "''") + "' AND Quantité = '" + "-" + lvwProjet.FocusedItem.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                if (!rstHist.EOF)
                {
                    rstHist.Delete();
                }
                rstHist.Close();
                rstHist = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "SupprimerHistorique", ex); }
        }
        private void Cmdfermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmdFermer_Click", ex); }
        }
        private void ReceptionElec_Load(object eventSender, EventArgs eventArgs)
        {
            int X;
            txtDateReception.Text = ConvertDate(DateTime.Today);
            txtDateRequise.Text = ConvertDate(DateTime.Today);
            RemplirComboProjet();
            RemplirComboCategorie();
   /*         try
            {
                if (!string.IsNullOrEmpty(m_sNoProjet))
                {
                    cmbType.SelectedIndex = 0;
                    var loopTo = cmbNoProjet.Items.Count - 1;
                    for (X = 0; X <= loopTo; X++)
                    {
                        if (cmbNoProjet.Items[X].ToString().ToUpper() == m_sNoProjet.ToUpper())
                        {
                            cmbNoProjet.SelectedIndex = X; break;
                        }
                    }
                }
                else if (!string.IsNullOrEmpty(m_sNoAchat))
                {
                    cmbType.SelectedIndex = 1;
                    var loopTo1 = cmbNoProjet.Items.Count - 1;
                    for (X = 0; X <= loopTo1; X++)
                    {
                        if (cmbNoProjet.Items[X].ToString() == m_sNoAchat)
                        {
                            cmbNoProjet.SelectedIndex = X; break;
                        }
                    }
                }
                else
                {
                    cmbType.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "Form_Load", ex); }
            if (cmbNoProjet.Items.Count > 0)
            {
                cmbNoProjet.SelectedIndex = 0;
               // RemplirListViewProjet(cmbNoProjet.Text);
            }*/
        }

        private void RemplirComboCategorie()
        {
        }

        private void RemplirComboProjet()
        {
            try
            {
                ADODB.Recordset rstProjet;
                cmbNoProjet.Items.Clear();
                rstProjet = new Recordset();
                rstProjet.Open("SELECT IDProjet FROM ProjetElec ORDER BY IDProjet DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstProjet.EOF)
                {
                    cmbNoProjet.Items.Add(rstProjet.Fields["IDProjet"].Value);
                    rstProjet.MoveNext();
                }
                rstProjet.Close();
                rstProjet = null;
                if (cmbNoProjet.Items.Count > 0)
                {
                    cmbNoProjet.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "RemplirComboProjet", ex); }
        }
        private void RemplirComboAchat()
        {
            try
            {
                ADODB.Recordset rstAchat;
                cmbNoProjet.Items.Clear();
                rstAchat = new Recordset();
                rstAchat.Open("SELECT IDAchat, IndexAchat FROM Achat WHERE Type = 'E' ORDER BY IDAchat DESC, IndexAchat DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstAchat.EOF)
                {
                    cmbNoProjet.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(rstAchat.Fields["IDAchat"].Value, "-"), Droite((string)Operators.ConcatenateObject("000", rstAchat.Fields["IndexAchat"].Value), 3)));
                    rstAchat.MoveNext();
                }
                rstAchat.Close();
                rstAchat = null;
                if (cmbNoProjet.Items.Count > 0)
                {
                    cmbNoProjet.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "RemplirComboAchat", ex); }
        }
        private void RemplirListViewProjet(string sNoProjet)
        {
            try
            {
                ADODB.Recordset rstProjet = new Recordset();
                ADODB.Recordset rstSection = new Recordset();
                ADODB.Recordset rstFRS= new Recordset();
                bool bPremierEnr;
                var iOrdreSection = default(int);
                var sSousSection = default(string);
                Color lColor;
                lvwProjet.Items.Clear();
                bPremierEnr = true;
                rstProjet.Open("SELECT * FROM Projet_Pieces " +
                    "WHERE IDProjet = '" + sNoProjet + "' " +
                    "ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstProjet.EOF)
                {
                   ListViewItem  itmProjet = lvwProjet.Items.Add(string.Empty);
                    if (bPremierEnr == true)
                    {
                        iOrdreSection =int.Parse($"{rstProjet.Fields["OrdreSection"].Value}");
                        sSousSection = (string)rstProjet.Fields["SousSection"].Value;
                        rstSection.Open($"SELECT NomSectionFR FROM SoumProjSectionElec " +
                            $"WHERE IDSection = {rstProjet.Fields["IDSection"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!(rstSection.Fields["NomSectionFR"].Value is DBNull))
                        {
                                itmProjet.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null,$"{rstSection.Fields["NomSectionFR"].Value}"));
                        }
                        rstSection.Close();
                        itmProjet = lvwProjet.Items.Add(string.Empty);
                        if (sSousSection == "PAS DE SOUS-SECTION")
                        {
                                 itmProjet.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        else if (itmProjet.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmProjet.SubItems[I_COL_DESCRIPTION].Text = sSousSection;
                        }
                        else
                        {
                            itmProjet.SubItems.Add(sSousSection);
                        }
                        if (itmProjet.SubItems.Count > I_COL_MANUFACTURIER)
                        {
                            itmProjet.SubItems[I_COL_MANUFACTURIER].Text = " ";
                        }
                        else
                        {
                            itmProjet.SubItems.Add("");
                        }
                        itmProjet.Tag = rstProjet.Fields["IDSection"].Value;
                        itmProjet = lvwProjet.Items.Add(string.Empty);
                        bPremierEnr = false;
                    }
                    else if (iOrdreSection.ToString() != rstProjet.Fields["OrdreSection"].Value)
                    {
                        iOrdreSection = int.Parse(rstProjet.Fields["OrdreSection"].Value);
                        rstSection.Open("SELECT NomSectionFR FROM SoumProjSectionElec " +
                            "WHERE IDSection = " + rstProjet.Fields["IDSection"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!(rstSection.Fields["NomSectionFR"].Value is DBNull))
                        {
                                itmProjet.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null,$"{rstSection.Fields["NomSectionFR"].Value}"));
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        rstSection.Close();
                        itmProjet = lvwProjet.Items.Add(string.Empty);
                        sSousSection = (string)rstProjet.Fields["SousSection"].Value;
                        if (sSousSection == "PAS DE SOUS-SECTION")
                        {
                            if (itmProjet.SubItems.Count > I_COL_DESCRIPTION)
                            {
                                itmProjet.SubItems[I_COL_DESCRIPTION].Text = string.Empty;
                            }
                            else
                            {
                                itmProjet.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }
                        else if (itmProjet.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmProjet.SubItems[I_COL_DESCRIPTION].Text = (string)rstProjet.Fields["SousSection"].Value;
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null,$"{rstProjet.Fields["SousSection"].Value}"));
                        }
                        if (itmProjet.SubItems.Count > I_COL_MANUFACTURIER)
                        {
                            itmProjet.SubItems[I_COL_MANUFACTURIER].Text = " ";
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, " "));
                        }
                        itmProjet = lvwProjet.Items.Add(string.Empty);
                    }
                    else if (sSousSection != rstProjet.Fields["SousSection"].Value)
                    {
                        sSousSection = (string)rstProjet.Fields["SousSection"].Value;
                        if (sSousSection == "PAS DE SOUS-SECTION")
                        {
                            if (itmProjet.SubItems.Count > I_COL_DESCRIPTION)
                            {
                                itmProjet.SubItems[I_COL_DESCRIPTION].Text = string.Empty;
                            }
                            else
                            {
                                itmProjet.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }
                        else if (itmProjet.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmProjet.SubItems[I_COL_DESCRIPTION].Text = sSousSection;
                        }
                        else
                        {
                            itmProjet.SubItems.Add(sSousSection);
                        }
                        if (itmProjet.SubItems.Count > I_COL_MANUFACTURIER)
                        {
                            itmProjet.SubItems[I_COL_MANUFACTURIER].Text = " ";
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                    }
                    if ((bool)rstProjet.Fields["Commandé"].Value) { lColor = COLOR_ORANGE; }
                    else if ((bool)rstProjet.Fields["Recu"].Value == true) { lColor = COLOR_GRIS; }
                    else if ((bool)rstProjet.Fields["Retour"].Value) { lColor = COLOR_ROUGE; }
                    else { lColor = COLOR_ROSE; }
                    itmProjet.Tag = rstProjet.Fields["IDSection"].Value;
                    if (!(rstProjet.Fields["Qté"].Value is DBNull))
                    {
                        itmProjet.Text = (string)rstProjet.Fields["Qté"].Value;
                    }
                    else
                    {
                        itmProjet.Text = string.Empty;
                    }
                    itmProjet.ForeColor = lColor;
                    if (!(rstProjet.Fields["NumItem"].Value is DBNull))
                    {
                        if (itmProjet.SubItems.Count > I_COL_PIECE)
                        {
                            itmProjet.SubItems[I_COL_PIECE].Text = (string)rstProjet.Fields["NumItem"].Value;
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null,$"{rstProjet.Fields["NumItem"].Value}"));
                        }
                    }
                    else if (itmProjet.SubItems.Count > I_COL_PIECE)
                    {
                        itmProjet.SubItems[I_COL_PIECE].Text = string.Empty;
                    }
                    else
                    {
                        itmProjet.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmProjet.SubItems[I_COL_PIECE].ForeColor = lColor;
                    itmProjet.SubItems[I_COL_PIECE].Tag = rstProjet.Fields["SousSection"].Value;
                    if (!(rstProjet.Fields["Desc_FR"].Value is DBNull))
                    {
                        if (itmProjet.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmProjet.SubItems[I_COL_DESCRIPTION].Text = (string)rstProjet.Fields["Desc_FR"].Value;
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null,$"{rstProjet.Fields["Desc_FR"].Value}"));
                        }
                    }
                    else if (itmProjet.SubItems.Count > I_COL_DESCRIPTION)
                    {
                        itmProjet.SubItems[I_COL_DESCRIPTION].Text = string.Empty;
                    }
                    else
                    {
                        itmProjet.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmProjet.SubItems[I_COL_DESCRIPTION].ForeColor = lColor;
                    if (!(rstProjet.Fields["DESC_EN"].Value is DBNull))
                    {
                        itmProjet.SubItems[I_COL_DESCRIPTION].Tag = rstProjet.Fields["Desc_EN"].Value;
                    }
                    else
                    {
                        itmProjet.SubItems[I_COL_DESCRIPTION].Tag = string.Empty;
                    }
                    if (!(rstProjet.Fields["Manufact"].Value is DBNull))
                    {
                        if (itmProjet.SubItems.Count > I_COL_MANUFACTURIER)
                        {
                            itmProjet.SubItems[I_COL_MANUFACTURIER].Text = (string)rstProjet.Fields["Manufact"].Value;
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null,$"{rstProjet.Fields["Manufact"].Value}"));
                        }
                    }
                    else if (itmProjet.SubItems.Count > I_COL_MANUFACTURIER)
                    {
                        itmProjet.SubItems[I_COL_MANUFACTURIER].Text = string.Empty;
                    }
                    else
                    {
                        itmProjet.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmProjet.SubItems[I_COL_MANUFACTURIER].ForeColor = lColor;
                    itmProjet.SubItems[I_COL_MANUFACTURIER].Tag = rstProjet.Fields["NuméroLigne"].Value;
                    if (!(rstProjet.Fields["IDFRS"].Value is DBNull) && (rstProjet.Fields["IDFRS"].Value> 0))
                    {
                        if (itmProjet.SubItems[I_COL_PIECE].Text != "Texte")
                        {
                            rstFRS.Open(Operators.ConcatenateObject("SELECT NomFournisseur FROM Fournisseur " +
                                "WHERE IDFRS = ", rstProjet.Fields["IDFRS"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (itmProjet.SubItems.Count > I_COL_DISTRIBUTEUR)
                            {
                                itmProjet.SubItems[I_COL_DISTRIBUTEUR].Text = (string)rstFRS.Fields["NomFournisseur"].Value;
                            }
                            else
                            {
                                itmProjet.SubItems.Insert(I_COL_DISTRIBUTEUR, new ListViewItem.ListViewSubItem(null,$"{rstFRS.Fields["NomFournisseur"].Value}"));
                            }
                            itmProjet.SubItems[I_COL_DISTRIBUTEUR].ForeColor = lColor;
                            itmProjet.SubItems[I_COL_DISTRIBUTEUR].Tag = rstProjet.Fields["IDFRS"].Value;
                            rstFRS.Close();
                        }
                    }
                    else if (itmProjet.SubItems.Count > I_COL_DISTRIBUTEUR)
                    {
                        itmProjet.SubItems[I_COL_DISTRIBUTEUR].Text = string.Empty;
                    }
                    else
                    {
                        itmProjet.SubItems.Insert(I_COL_DISTRIBUTEUR, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    if (!(rstProjet.Fields["DateRéception"].Value is DBNull))
                    {
                        if (itmProjet.SubItems.Count > I_COL_DATE_RECEPTION)
                        {
                            itmProjet.SubItems[I_COL_DATE_RECEPTION].Text = (string)rstProjet.Fields["DateRéception"].Value;
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_DATE_RECEPTION, new ListViewItem.ListViewSubItem(null,$"{rstProjet.Fields["DateRéception"].Value}"));
                        }
                    }
                    else if (itmProjet.SubItems.Count > I_COL_DATE_RECEPTION)
                    {
                        itmProjet.SubItems[I_COL_DATE_RECEPTION].Text = string.Empty;
                    }
                    else
                    {
                        itmProjet.SubItems.Insert(I_COL_DATE_RECEPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmProjet.SubItems[I_COL_DATE_RECEPTION].ForeColor = lColor;
                    if (!(rstProjet.Fields["DateCommande"].Value is DBNull))
                    {
                        if (itmProjet.SubItems.Count > I_COL_DATE_COMMANDE)
                        {
                            itmProjet.SubItems[I_COL_DATE_COMMANDE].Text = (string)rstProjet.Fields["DateCommande"].Value;
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null,$"{rstProjet.Fields["DateCommande"].Value}"));
                        }
                    }
                    else if (itmProjet.SubItems.Count > I_COL_DATE_COMMANDE)
                    {
                        itmProjet.SubItems[I_COL_DATE_COMMANDE].Text = string.Empty;
                    }
                    else
                    {
                        itmProjet.SubItems.Insert(I_COL_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmProjet.SubItems[I_COL_DATE_COMMANDE].ForeColor = lColor;
                    if (!(rstProjet.Fields["DateRequise"].Value is DBNull))
                    {
                        if (itmProjet.SubItems.Count > I_COL_DATE_REQUISE)
                        {
                            itmProjet.SubItems[I_COL_DATE_REQUISE].Text = (string)rstProjet.Fields["DateRequise"].Value;
                        }
                        else
                        {
                            itmProjet.SubItems.Insert(I_COL_DATE_REQUISE, new ListViewItem.ListViewSubItem(null,$"{rstProjet.Fields["DateRequise"].Value}"));
                        }
                    }
                    else if (itmProjet.SubItems.Count > I_COL_DATE_REQUISE)
                    {
                        itmProjet.SubItems[I_COL_DATE_REQUISE].Text = string.Empty;
                    }
                    else
                    {
                        itmProjet.SubItems.Insert(I_COL_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmProjet.SubItems[I_COL_DATE_REQUISE].ForeColor = lColor;
                    rstProjet.MoveNext();
                }
                rstProjet.Close();
                rstProjet = null;
                rstFRS = null;
                rstSection = null;
                if (m_iIndexReception > 0)
                {
                    lvwProjet.Items[m_iIndexReception].Selected = true;
                    lvwProjet.Focus();
                    lvwProjet.FocusedItem.EnsureVisible();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "RemplirListViewProjet", ex); }
        }
        private void RemplirListViewAchat(string sNoProjet)
        {
            try
            {
                ADODB.Recordset rstAchat;
                ADODB.Recordset rstFRS;
                ListViewItem itmAchat;
                Color lColor;
                string sNoAchat;
                lvwProjet.Items.Clear();
                rstAchat = new Recordset();
                rstFRS = new Recordset();
                rstAchat.Open($"SELECT * FROM Achat_Pieces " +
                    $"WHERE IDAchat = '{Gauche(sNoProjet, 9)}' AND IndexAchat = {int.Parse(Droite(sNoProjet, 3))} " +
                    $"ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstAchat.EOF)
                {
                    itmAchat = lvwProjet.Items.Add(string.Empty);
                    if ((bool)rstAchat.Fields["Commandé"].Value == true)
                    {
                        lColor = COLOR_ORANGE;
                    }
                    else if ((bool)rstAchat.Fields["Recu"].Value == true)
                    {
                        lColor = COLOR_GRIS;
                    }
                    else if ((bool)rstAchat.Fields["Retour"].Value == true)
                    {
                        lColor = COLOR_ROUGE;
                    }
                    else
                    {
                        lColor = COLOR_ROSE;
                    }
                    if (!(rstAchat.Fields["Qté"].Value is DBNull))
                    {
                        itmAchat.Text = (string)rstAchat.Fields["Qté"].Value;
                    }
                    else
                    {
                        itmAchat.Text = string.Empty;
                    }
                    itmAchat.ForeColor = lColor;

                    itmAchat.SubItems.Insert(I_COL_PIECE, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["PIECE"].Value}"));
                    itmAchat.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["Desc_FR"].Value}"));
                    itmAchat.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["Manufact"].Value}"));
                    itmAchat.SubItems[I_COL_MANUFACTURIER].Tag = rstAchat.Fields["NuméroLigne"].Value;
                    if (!(rstAchat.Fields["IDFRS"].Value is DBNull & int.Parse($"{rstAchat.Fields["IDFRS"].Value}") > 0))
                    {
                        if (itmAchat.SubItems[I_COL_PIECE].Text != "Texte")
                        {
                            rstFRS.Open($"SELECT NomFournisseur FROM Fournisseur " +
                                $"WHERE IDFRS = {rstAchat.Fields["IDFRS"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (itmAchat.SubItems.Count > I_COL_DISTRIBUTEUR)
                            {
                                itmAchat.SubItems[I_COL_DISTRIBUTEUR].Text = (string)rstFRS.Fields["NomFournisseur"].Value;
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_DISTRIBUTEUR, new ListViewItem.ListViewSubItem(null, $"{rstFRS.Fields["NomFournisseur"].Value}"));
                            }
                            itmAchat.SubItems[I_COL_DISTRIBUTEUR].ForeColor = lColor;
                            itmAchat.SubItems[I_COL_DISTRIBUTEUR].Tag = rstAchat.Fields["IDFRS"].Value;
                            rstFRS.Close();
                        }
                        else if (itmAchat.SubItems.Count > I_COL_DISTRIBUTEUR)
                        {
                            itmAchat.SubItems[I_COL_DISTRIBUTEUR].Text = string.Empty;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_DISTRIBUTEUR, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        if (!(rstAchat.Fields["DateRéception"].Value is DBNull))
                        {
                            if (itmAchat.SubItems.Count > I_COL_DATE_RECEPTION)
                            {
                                itmAchat.SubItems[I_COL_DATE_RECEPTION].Text = (string)rstAchat.Fields["DateRéception"].Value;
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_DATE_RECEPTION, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["DateRéception"].Value}"));
                            }
                        }
                        else if (itmAchat.SubItems.Count > I_COL_DATE_RECEPTION)
                        {
                            itmAchat.SubItems[I_COL_DATE_RECEPTION].Text = string.Empty;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_DATE_RECEPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        itmAchat.SubItems[I_COL_DATE_RECEPTION].ForeColor = lColor;
                        if (!(rstAchat.Fields["DateCommande"].Value is DBNull))
                        {
                            if (itmAchat.SubItems.Count > I_COL_DATE_COMMANDE)
                            {
                                itmAchat.SubItems[I_COL_DATE_COMMANDE].Text = (string)rstAchat.Fields["DateCommande"].Value;
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["DateCommande"].Value}"));
                            }
                        }
                        else if (itmAchat.SubItems.Count > I_COL_DATE_COMMANDE)
                        {
                            itmAchat.SubItems[I_COL_DATE_COMMANDE].Text = string.Empty;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        itmAchat.SubItems[I_COL_DATE_COMMANDE].ForeColor = lColor;
                        if (!(rstAchat.Fields["DateRequise"].Value is DBNull))
                        {
                            if (itmAchat.SubItems.Count > I_COL_DATE_REQUISE)
                            {
                                itmAchat.SubItems[I_COL_DATE_REQUISE].Text = (string)rstAchat.Fields["DateRequise"].Value;
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["DateRequise"].Value}"));
                            }
                        }
                        else if (itmAchat.SubItems.Count > I_COL_DATE_REQUISE)
                        {
                            itmAchat.SubItems[I_COL_DATE_REQUISE].Text = string.Empty;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        itmAchat.SubItems[I_COL_DATE_REQUISE].ForeColor = lColor;
                        rstAchat.MoveNext();
                    }
                    rstAchat.Close();
                    rstAchat = null;
                    rstFRS = null;
                    if (m_iIndexReception > 0)
                    {
                        lvwProjet.Items[m_iIndexReception].Selected = true;
                        lvwProjet.Focus();
                        lvwProjet.FocusedItem.EnsureVisible();
                    }
                    return;
                }
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "RemplirListViewProjet", ex); }
        }
        private void lvwProjet_ItemClick(ListViewItem Item)
        {
            try
            {
                VerifierBoutonAnnuler();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "lvwProjet_ItemClick", ex); }
        }
        private void VerifierBoutonAnnuler()
        {
            try
            {
                if (lvwProjet.Items.Count > 0)
                {
                    if( (lvwProjet.FocusedItem.ForeColor== COLOR_GRIS)| (lvwProjet.FocusedItem.ForeColor== COLOR_BLEU)) // Gris ou bleu
                    {
                        cmdAnnuler.Enabled = true;
                    }
                    else
                    {
                        cmdAnnuler.Enabled = false;
                    }
                }
                else
                {
                    cmdAnnuler.Enabled = false;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "VerifierBoutonAnnuler", ex); }
        }
        public void Afficher(string sUserID)
        {
            try
            {
                m_sUserID = sUserID;
                Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "Afficher", ex); }
        }
        public void AfficherProjet(string sUserID, string sNoProjet)
        {
            try
            {
                m_sUserID = sUserID;
                m_sNoProjet = sNoProjet;
                ShowDialog();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "AfficherProjet", ex); }
        }
        public void AfficherAchat(string sUserID, string sNoAchat)
        {
            try
            {
                m_sUserID = sUserID;
                m_sNoAchat = sNoAchat;
                Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "AfficherAchat", ex); }
        }
        private void lvwProjet_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (eventArgs.KeyCode == Keys.Delete)
                {
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        ReceptionProjet();
                    }
                    else
                    {
                        ReceptionAchat();
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "lvwProjet_KeyDown", ex); }
        }
        private void mvwReception_DateClick(object eventSender, MonthCalendar eventArgs)
        {
            try
            {
                txtDateReception.Text = eventArgs.SelectionStart.ToShortDateString();
                mvwReception.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "mvwReception_DateClick", ex); }
        }
        private void mvwReception_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mvwReception.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "mvwReception_LostFocus", ex); }
        }
        private void mvwDateRequise_DateClick(object eventSender, MonthCalendar eventArgs)
        {
            try
            {
                txtDateRequise.Text = eventArgs.SelectionStart.ToShortDateString();
                mvwDateRequise.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "mvwDateRequise_DateClick", ex); }
        }
        private void mvwDateRequise_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mvwDateRequise.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "mvwDateRequise_LostFocus", ex); }
        }
        private void ReceptionElec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mvwReception.Visible = false;
                mvwDateRequise.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "Form_Click", ex); }
        }
        private void cmdDate_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDateReception.Text))
                {
                    mvwReception.Value = Conversions.ToDate(txtDateReception.Text);
                }
                else
                {
                    mvwReception.Value = DateTime.Today;
                }
                mvwReception.Visible = true;
                mvwReception.Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionElec", "cmdDate_Click", ex); }
        }

        private void button1_Click(object eventSender, EventArgs eventArgs)
        {
            if (cmbNoProjet.Text != "") { ListerProjet(cmbNoProjet.Text); }
        }
        private void ListerProjet(string noProjet)
        {
            if(lvwProjet.Items.Count>0) lvwProjet.Items.Clear();
            ADODB.Recordset rst = new ADODB.Recordset();
            SqlLinkODBC(rst, "autogrb", $"SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                $"INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                $"WHERE  Commandé = 1 and Right(Left(IDProjet,6),5)='{Droite(Gauche(noProjet,6),5)}' and Type ='E' ORDER BY NomFournisseur ");
            while (!rst.EOF)
            {
            ListViewItem itm = lvwProjet.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[4].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[3].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[5].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[7].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[45].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[29].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[36].Value}"));
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[37].Value}"));
                rst.MoveNext();
            }
            rst.Close();
        }

        private void mvwDateRequise_ValueChanged(object sender, EventArgs e)
        {
            txtDateReception.Text = ConvertToUSDate(mvwDateRequise.Value);
            mvwDateRequise.Visible = false;
        }
    }
}