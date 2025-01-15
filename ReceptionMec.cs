using System;
using System.Drawing;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ADODB;
using System.Diagnostics;

using ControleurServeur;
using System.Web.Configuration;
namespace ControleurServeur
{
    internal class ReceptionMec : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ReceptionMec() : base()
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
        internal static Button cmdNonRecu;
        internal static  MonthCalendar mvwReception;
        internal static  MonthCalendar mvwDateRequise;
        internal static CheckBox chkProjetAchat;
        internal static CheckBox chkDateRequise;
        internal static TextBox txtProjetAchat;
        internal static TextBox txtDateRequise;
        internal static Button cmdFermerPieces;
        internal static Button cmdImprimerPieces;
        internal static Button cmdAfficher;
        internal static ColumnHeader _lvwPieces_ColumnHeader_1;
        internal static ColumnHeader _lvwPieces_ColumnHeader_2;
        internal static ColumnHeader _lvwPieces_ColumnHeader_3;
        internal static ColumnHeader _lvwPieces_ColumnHeader_4;
        internal static ColumnHeader _lvwPieces_ColumnHeader_5;
        internal static ColumnHeader _lvwPieces_ColumnHeader_6;
        internal static ColumnHeader _lvwPieces_ColumnHeader_7;
        internal static ListView lvwPieces;
        internal static Button cmdDateRequise;
        internal static GroupBox fraPiecesNonRecues;
        internal static Button cmdImprimer;
        internal static ComboBox cmbType;
        internal static Button cmdDate;
        internal static TextBox txtDateReception;
        internal static Button cmdAnnuler;
        internal static ComboBox cmbNoProjet;
        internal static TextBox txtNoProjet;
        internal static Button cmdFermer;
        internal static ListView listView1;
        internal static ColumnHeader columnHeader1;
        internal static ColumnHeader columnHeader2;
        internal static ColumnHeader columnHeader3;
        internal static ColumnHeader columnHeader4;
        internal static ColumnHeader columnHeader5;
        internal static ColumnHeader columnHeader6;
        internal static ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        internal static Label Label1;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdNonRecu = new System.Windows.Forms.Button();
            fraPiecesNonRecues = new System.Windows.Forms.GroupBox();
            chkProjetAchat = new System.Windows.Forms.CheckBox();
            chkDateRequise = new System.Windows.Forms.CheckBox();
            txtProjetAchat = new System.Windows.Forms.TextBox();
            txtDateRequise = new System.Windows.Forms.TextBox();
            cmdFermerPieces = new System.Windows.Forms.Button();
            cmdImprimerPieces = new System.Windows.Forms.Button();
            cmdAfficher = new System.Windows.Forms.Button();
            lvwPieces = new System.Windows.Forms.ListView();
            _lvwPieces_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPieces_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPieces_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPieces_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPieces_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPieces_ColumnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPieces_ColumnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdDateRequise = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdImprimer = new System.Windows.Forms.Button();
            cmbType = new System.Windows.Forms.ComboBox();
            cmdDate = new System.Windows.Forms.Button();
            txtDateReception = new System.Windows.Forms.TextBox();
            cmdAnnuler = new System.Windows.Forms.Button();
            cmbNoProjet = new System.Windows.Forms.ComboBox();
            txtNoProjet = new System.Windows.Forms.TextBox();
            cmdFermer = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            fraPiecesNonRecues.SuspendLayout();
            SuspendLayout();
            // 
            // cmdNonRecu
            // 
            cmdNonRecu.AutoSize = true;
            cmdNonRecu.BackColor = System.Drawing.Color.Black;
            cmdNonRecu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdNonRecu.ForeColor = System.Drawing.Color.White;
            cmdNonRecu.Location = new System.Drawing.Point(242, 683);
            cmdNonRecu.Name = "cmdNonRecu";
            cmdNonRecu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdNonRecu.Size = new System.Drawing.Size(113, 26);
            cmdNonRecu.TabIndex = 17;
            cmdNonRecu.Text = "Pièces non recues";
            cmdNonRecu.UseVisualStyleBackColor = true;
            cmdNonRecu.Click += new System.EventHandler(cmdNonRecu_Click);
            // 
            // fraPiecesNonRecues
            // 
            fraPiecesNonRecues.BackColor = System.Drawing.Color.Black;
            fraPiecesNonRecues.Controls.Add(chkProjetAchat);
            fraPiecesNonRecues.Controls.Add(chkDateRequise);
            fraPiecesNonRecues.Controls.Add(txtProjetAchat);
            fraPiecesNonRecues.Controls.Add(txtDateRequise);
            fraPiecesNonRecues.Controls.Add(cmdFermerPieces);
            fraPiecesNonRecues.Controls.Add(cmdImprimerPieces);
            fraPiecesNonRecues.Controls.Add(cmdAfficher);
            fraPiecesNonRecues.Controls.Add(lvwPieces);
            fraPiecesNonRecues.Controls.Add(cmdDateRequise);
            fraPiecesNonRecues.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraPiecesNonRecues.ForeColor = System.Drawing.Color.White;
            fraPiecesNonRecues.Location = new System.Drawing.Point(8, 66);
            fraPiecesNonRecues.Name = "fraPiecesNonRecues";
            fraPiecesNonRecues.Padding = new System.Windows.Forms.Padding(0);
            fraPiecesNonRecues.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraPiecesNonRecues.Size = new System.Drawing.Size(1282, 593);
            fraPiecesNonRecues.TabIndex = 7;
            fraPiecesNonRecues.TabStop = false;
            fraPiecesNonRecues.Visible = false;
            // 
            // chkProjetAchat
            // 
            chkProjetAchat.BackColor = System.Drawing.Color.Black;
            chkProjetAchat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkProjetAchat.ForeColor = System.Drawing.Color.White;
            chkProjetAchat.Location = new System.Drawing.Point(262, 16);
            chkProjetAchat.Name = "chkProjetAchat";
            chkProjetAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkProjetAchat.Size = new System.Drawing.Size(105, 17);
            chkProjetAchat.TabIndex = 22;
            chkProjetAchat.Text = "Projet / ACHAT :";
            chkProjetAchat.UseVisualStyleBackColor = true;
            chkProjetAchat.CheckStateChanged += new System.EventHandler(chkProjetAchat_CheckStateChanged);
            // 
            // chkDateRequise
            // 
            chkDateRequise.BackColor = System.Drawing.Color.Black;
            chkDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkDateRequise.ForeColor = System.Drawing.Color.White;
            chkDateRequise.Location = new System.Drawing.Point(8, 16);
            chkDateRequise.Name = "chkDateRequise";
            chkDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkDateRequise.Size = new System.Drawing.Size(105, 17);
            chkDateRequise.TabIndex = 21;
            chkDateRequise.Text = "Date Requise :";
            chkDateRequise.UseVisualStyleBackColor = true;
            chkDateRequise.CheckStateChanged += new System.EventHandler(chkDateRequise_CheckStateChanged);
            // 
            // txtProjetAchat
            // 
            txtProjetAchat.AcceptsReturn = true;
            txtProjetAchat.BackColor = System.Drawing.SystemColors.Window;
            txtProjetAchat.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtProjetAchat.Enabled = false;
            txtProjetAchat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtProjetAchat.ForeColor = System.Drawing.SystemColors.WindowText;
            txtProjetAchat.Location = new System.Drawing.Point(373, 16);
            txtProjetAchat.MaxLength = 0;
            txtProjetAchat.Name = "txtProjetAchat";
            txtProjetAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtProjetAchat.Size = new System.Drawing.Size(97, 22);
            txtProjetAchat.TabIndex = 20;
            // 
            // txtDateRequise
            // 
            txtDateRequise.AcceptsReturn = true;
            txtDateRequise.BackColor = System.Drawing.SystemColors.Window;
            txtDateRequise.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDateRequise.Enabled = false;
            txtDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDateRequise.ForeColor = System.Drawing.SystemColors.WindowText;
            txtDateRequise.Location = new System.Drawing.Point(112, 16);
            txtDateRequise.MaxLength = 0;
            txtDateRequise.Name = "txtDateRequise";
            txtDateRequise.ReadOnly = true;
            txtDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDateRequise.Size = new System.Drawing.Size(97, 22);
            txtDateRequise.TabIndex = 19;
            // 
            // cmdFermerPieces
            // 
            cmdFermerPieces.AutoSize = true;
            cmdFermerPieces.BackColor = System.Drawing.Color.Black;
            cmdFermerPieces.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermerPieces.ForeColor = System.Drawing.Color.White;
            cmdFermerPieces.Location = new System.Drawing.Point(1184, 554);
            cmdFermerPieces.Name = "cmdFermerPieces";
            cmdFermerPieces.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermerPieces.Size = new System.Drawing.Size(81, 26);
            cmdFermerPieces.TabIndex = 13;
            cmdFermerPieces.Text = "Fermer";
            cmdFermerPieces.UseVisualStyleBackColor = true;
            cmdFermerPieces.Click += new System.EventHandler(cmdFermerPieces_Click);
            // 
            // cmdImprimerPieces
            // 
            cmdImprimerPieces.AutoSize = true;
            cmdImprimerPieces.BackColor = System.Drawing.Color.Black;
            cmdImprimerPieces.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdImprimerPieces.ForeColor = System.Drawing.Color.White;
            cmdImprimerPieces.Location = new System.Drawing.Point(8, 554);
            cmdImprimerPieces.Name = "cmdImprimerPieces";
            cmdImprimerPieces.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdImprimerPieces.Size = new System.Drawing.Size(105, 26);
            cmdImprimerPieces.TabIndex = 12;
            cmdImprimerPieces.Text = "Imprimer";
            cmdImprimerPieces.UseVisualStyleBackColor = true;
            cmdImprimerPieces.Click += new System.EventHandler(cmdImprimerPieces_Click);
            // 
            // cmdAfficher
            // 
            cmdAfficher.AutoSize = true;
            cmdAfficher.BackColor = System.Drawing.Color.Black;
            cmdAfficher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAfficher.ForeColor = System.Drawing.Color.White;
            cmdAfficher.Location = new System.Drawing.Point(485, 13);
            cmdAfficher.Name = "cmdAfficher";
            cmdAfficher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAfficher.Size = new System.Drawing.Size(73, 27);
            cmdAfficher.TabIndex = 10;
            cmdAfficher.Text = "Afficher";
            cmdAfficher.UseVisualStyleBackColor = true;
            cmdAfficher.Click += new System.EventHandler(cmdAfficher_Click);
            // 
            // lvwPieces
            // 
            lvwPieces.BackColor = System.Drawing.Color.Black;
            lvwPieces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwPieces_ColumnHeader_1,
            _lvwPieces_ColumnHeader_2,
            _lvwPieces_ColumnHeader_3,
            _lvwPieces_ColumnHeader_4,
            _lvwPieces_ColumnHeader_5,
            _lvwPieces_ColumnHeader_6,
            _lvwPieces_ColumnHeader_7});
            lvwPieces.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwPieces.ForeColor = System.Drawing.SystemColors.WindowText;
            lvwPieces.FullRowSelect = true;
            lvwPieces.GridLines = true;
            lvwPieces.HideSelection = false;
            lvwPieces.Location = new System.Drawing.Point(8, 48);
            lvwPieces.Name = "lvwPieces";
            lvwPieces.Size = new System.Drawing.Size(1257, 486);
            lvwPieces.TabIndex = 11;
            lvwPieces.UseCompatibleStateImageBehavior = false;
            lvwPieces.View = System.Windows.Forms.View.Details;
            // 
            // _lvwPieces_ColumnHeader_1
            // 
            _lvwPieces_ColumnHeader_1.Text = "# Projet";
            _lvwPieces_ColumnHeader_1.Width = 106;
            // 
            // _lvwPieces_ColumnHeader_2
            // 
            _lvwPieces_ColumnHeader_2.Text = "Qté";
            _lvwPieces_ColumnHeader_2.Width = 71;
            // 
            // _lvwPieces_ColumnHeader_3
            // 
            _lvwPieces_ColumnHeader_3.Text = "# Item";
            _lvwPieces_ColumnHeader_3.Width = 247;
            // 
            // _lvwPieces_ColumnHeader_4
            // 
            _lvwPieces_ColumnHeader_4.Text = "Description";
            _lvwPieces_ColumnHeader_4.Width = 471;
            // 
            // _lvwPieces_ColumnHeader_5
            // 
            _lvwPieces_ColumnHeader_5.Text = "Fournisseur";
            _lvwPieces_ColumnHeader_5.Width = 318;
            // 
            // _lvwPieces_ColumnHeader_6
            // 
            _lvwPieces_ColumnHeader_6.Text = "Date Commande";
            _lvwPieces_ColumnHeader_6.Width = 161;
            // 
            // _lvwPieces_ColumnHeader_7
            // 
            _lvwPieces_ColumnHeader_7.Text = "Date Requise";
            _lvwPieces_ColumnHeader_7.Width = 161;
            // 
            // cmdDateRequise
            // 
            cmdDateRequise.AutoSize = true;
            cmdDateRequise.BackColor = System.Drawing.Color.Black;
            cmdDateRequise.Enabled = false;
            cmdDateRequise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdDateRequise.ForeColor = System.Drawing.Color.White;
            cmdDateRequise.Location = new System.Drawing.Point(216, 16);
            cmdDateRequise.Name = "cmdDateRequise";
            cmdDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDateRequise.Size = new System.Drawing.Size(30, 26);
            cmdDateRequise.TabIndex = 9;
            cmdDateRequise.Text = "...";
            cmdDateRequise.UseVisualStyleBackColor = true;
            cmdDateRequise.Click += new System.EventHandler(cmdDateRequise_Click);
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.Color.Black;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            columnHeader5,
            columnHeader6,
            columnHeader7,
            columnHeader8});
            listView1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(8, 68);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1292, 608);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Qté";
            columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "#Piece";
            columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 247;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fournisseur";
            columnHeader4.Width = 471;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Recu le";
            columnHeader5.Width = 318;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Commandé le";
            columnHeader6.Width = 161;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Requis le";
            columnHeader7.Width = 161;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ID";
            // 
            // cmdImprimer
            // 
            cmdImprimer.AutoSize = true;
            cmdImprimer.BackColor = System.Drawing.Color.Black;
            cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdImprimer.ForeColor = System.Drawing.Color.White;
            cmdImprimer.Location = new System.Drawing.Point(10, 683);
            cmdImprimer.Name = "cmdImprimer";
            cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdImprimer.Size = new System.Drawing.Size(105, 26);
            cmdImprimer.TabIndex = 15;
            cmdImprimer.Text = "Imprimer";
            cmdImprimer.UseVisualStyleBackColor = true;
            cmdImprimer.Click += new System.EventHandler(cmdImprimer_Click);
            // 
            // cmbType
            // 
            cmbType.BackColor = System.Drawing.SystemColors.Window;
            cmbType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbType.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbType.Items.AddRange(new object[] {
            "Projet",
            "ACHAT"});
            cmbType.Location = new System.Drawing.Point(286, 10);
            cmbType.Name = "cmbType";
            cmbType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbType.Size = new System.Drawing.Size(89, 22);
            cmbType.TabIndex = 0;
            cmbType.SelectedIndexChanged += new System.EventHandler(cmbType_SelectedIndexChanged);
            // 
            // cmdDate
            // 
            cmdDate.AutoSize = true;
            cmdDate.BackColor = System.Drawing.Color.Black;
            cmdDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdDate.ForeColor = System.Drawing.Color.White;
            cmdDate.Location = new System.Drawing.Point(815, 4);
            cmdDate.Name = "cmdDate";
            cmdDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDate.Size = new System.Drawing.Size(30, 26);
            cmdDate.TabIndex = 6;
            cmdDate.Text = "...";
            cmdDate.UseVisualStyleBackColor = true;
            cmdDate.Click += new System.EventHandler(cmdDate_Click);
            // 
            // txtDateReception
            // 
            txtDateReception.AcceptsReturn = true;
            txtDateReception.BackColor = System.Drawing.SystemColors.Window;
            txtDateReception.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDateReception.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDateReception.ForeColor = System.Drawing.SystemColors.WindowText;
            txtDateReception.Location = new System.Drawing.Point(640, 7);
            txtDateReception.MaxLength = 0;
            txtDateReception.Name = "txtDateReception";
            txtDateReception.ReadOnly = true;
            txtDateReception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDateReception.Size = new System.Drawing.Size(169, 22);
            txtDateReception.TabIndex = 4;
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.AutoSize = true;
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(122, 683);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(118, 26);
            cmdAnnuler.TabIndex = 16;
            cmdAnnuler.Text = "Annuler la réception";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // cmbNoProjet
            // 
            cmbNoProjet.BackColor = System.Drawing.SystemColors.Window;
            cmbNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbNoProjet.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbNoProjet.Location = new System.Drawing.Point(390, 10);
            cmbNoProjet.Name = "cmbNoProjet";
            cmbNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbNoProjet.Size = new System.Drawing.Size(145, 22);
            cmbNoProjet.TabIndex = 2;
            cmbNoProjet.SelectedIndexChanged += new System.EventHandler(cmbNoProjet_SelectedIndexChanged);
            cmbNoProjet.KeyUp += new System.Windows.Forms.KeyEventHandler(cmbNoProjet_KeyUp);
            // 
            // txtNoProjet
            // 
            txtNoProjet.AcceptsReturn = true;
            txtNoProjet.BackColor = System.Drawing.SystemColors.Window;
            txtNoProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNoProjet.ForeColor = System.Drawing.SystemColors.WindowText;
            txtNoProjet.Location = new System.Drawing.Point(390, 10);
            txtNoProjet.MaxLength = 0;
            txtNoProjet.Name = "txtNoProjet";
            txtNoProjet.ReadOnly = true;
            txtNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoProjet.Size = new System.Drawing.Size(145, 22);
            txtNoProjet.TabIndex = 1;
            txtNoProjet.Visible = false;
            // 
            // cmdFermer
            // 
            cmdFermer.AutoSize = true;
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.White;
            cmdFermer.Location = new System.Drawing.Point(1215, 683);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(81, 26);
            cmdFermer.TabIndex = 18;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(Cmdfermer_Click);
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(547, 10);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(97, 19);
            Label1.TabIndex = 5;
            Label1.Text = "Date de réception :";
            // 
            // ReceptionMec
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1306, 712);
            Controls.Add(listView1);
            Controls.Add(cmdNonRecu);
            Controls.Add(fraPiecesNonRecues);
            Controls.Add(cmdImprimer);
            Controls.Add(cmbType);
            Controls.Add(cmdDate);
            Controls.Add(txtDateReception);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmbNoProjet);
            Controls.Add(txtNoProjet);
            Controls.Add(cmdFermer);
            Controls.Add(Label1);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            KeyPreview = true;
            Location = new System.Drawing.Point(14, 42);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReceptionMec";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Réception mécanique";
            Load += new System.EventHandler(ReceptionMec_Load);
            Click += new System.EventHandler(ReceptionMec_Click);
            KeyDown += new System.Windows.Forms.KeyEventHandler(ReceptionMec_KeyDown);
            fraPiecesNonRecues.ResumeLayout(false);
            fraPiecesNonRecues.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        private string m_sUserID;
        private string m_sNoProjet;
        private string m_sNoAchat;
        private EnumType m_eType;
        private int m_iIndexReception;
        private string idNoEmploye;
        private dynamic ProjetTag;

        public ReceptionMec(string idNoEmploye, string text)
        {
            InitializeComponent();
            idNoEmploye = idNoEmploye;
            Text = text;
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "chkDateRequise_Click", ex); }
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "chkProjetAchat_Click", ex); }
        }
        [Obsolete]
        private void cmbNoProjet_KeyUp(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                for (int X = 0; X <= cmbNoProjet.Items.Count - 1; X++)
                {
                    if ((cmbNoProjet.Items[X].ToString().ToUpper() ?? "") == (cmbNoProjet.Text.ToUpper() ?? ""))
                    {
                        cmbNoProjet.SelectedIndex = X;
                        break;
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmbNoProjet_KeyUp", ex); }
        }
        private void cmbNoProjet_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            RemplirListeProjet();
            lvwPieces.Items.Clear();
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
            VerifierBoutonAnnuler();
            Cursor.Current = Cursors.Default;
        }

        private void RemplirListeProjet()
        {
            if (listView1.Items.Count > 0) listView1.Items.Clear();
            ADODB.Recordset rst = new ADODB.Recordset();
            rst.Open($"SELECT[Qté],[NumItem],[Desc_FR],[Manufact] ,[DBO].[Fournisseur].NomFournisseur,[DateRéception],[DateCommande],[DateRequise],[NoEnreg] FROM Projet_Pieces " +
                $"JOIN [DBO].[Fournisseur] on[DBO].[Fournisseur].IDFRS = Projet_Pieces.IDFRS " +
                $"WHERE IDProjet = 'M99901-81' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rst.EOF)
            {
                ListViewItem itm = lvwPieces.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[0].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[1].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[2].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[3].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[4].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[5].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[6].Value}"));
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[7].Value}"));
                itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[8].Value}"));
                rst.MoveNext();
            }
            rst.Close();
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
                                MessageBox.Show("Format de numéro d'ACHAT incorrect!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (txtProjetAchat.Text.Trim().Length == 9)
                        {
                            bRemplir = true;
                        }
                        else
                        {
                            MessageBox.Show("Format de numéro de projet incorrect!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (m_eType == EnumType.ACHAT)
                    {
                        MessageBox.Show("Le numéro de l'ACHAT est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Le numéro de projet est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmdAfficher_Click", ex); }
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmdAnnuler_Click", ex); }
        }
        private void AnnulerReceptionProjet()
        {
            try
            {
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstModif;
                ADODB.Recordset rstEmploye;
                if (lvwPieces.Items.Count > 0)
                {
                    rstProjet = new Recordset();
                    rstProjet.Open("SELECT Modification, Par FROM ProjetMec WHERE IDProjet = '" + txtNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if ((bool)rstProjet.Fields["Modification"].Value == false)
                    {
                        rstPiece = new Recordset();
                        rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND Type = 'M' AND NuméroLigne = ", lvwPieces.FocusedItem.SubItems[3].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstPiece.Fields["Recu"].Value = false;
                        rstPiece.Fields["Commandé"].Value = true;
                        rstPiece.Fields["DateRéception"].Value = "";
                        rstPiece.Update();
                        rstModif = new Recordset();
                        rstModif.Open("SELECT * FROM Projet_Modif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstModif.AddNew();
                        rstEmploye = new Recordset();
                        rstEmploye.Open("SELECT noEmploye FROM Employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstModif.Fields["Type"].Value = "M";
                        rstModif.Fields["IDProjet"].Value = txtNoProjet.Text;
                        rstModif.Fields["noEmployé"].Value = rstEmploye.Fields["noEmploye"].Value;
                        rstModif.Fields["Date"].Value = ConvertDate(DateTime.Today);
                        rstModif.Fields["Heure"].Value = DateAndTime.TimeOfDay;
                        rstModif.Fields["TypeModif"].Value = "RECEPTION";
                        rstEmploye.Close();
                        rstEmploye = null;
                        rstModif.Update();
                        rstModif.Close();
                        rstModif = null;
                        rstPiece.Close();
                        rstPiece = null;
                        if (lvwPieces.FocusedItem.SubItems[4].Text.ToUpper() == "SOLUTION GRB INC.")
                        {
                            AjouterInventaireProjet();
                        }
                        SupprimerHistorique();
                        m_iIndexReception = lvwPieces.FocusedItem.Index;
                        RemplirListViewProjet(txtNoProjet.Text);
                    }
                    else
                    {
                        MessageBox.Show($"Ce projet est en modification par {rstProjet.Fields["Par"].Value}!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstProjet.Close();
                    rstProjet = null;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "AnnulerReceptionProjet", ex); }
        }
        private void AnnulerReceptionAchat()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstAchat;
                string sIDAchat;
                int iIndexAchat;
                if (lvwPieces.Items.Count > 0)
                {
                    sIDAchat = Gauche(txtNoProjet.Text, 9);
                    iIndexAchat = int.Parse(Droite(txtNoProjet.Text, 3));
                    rstAchat = new Recordset();
                    rstAchat.Open("SELECT Modification, Par FROM Achat WHERE IDAchat = '{ sIDAchat}' AND IndexAchat = {iIndexAchat}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if ((bool)rstAchat.Fields["Modification"].Value == false)
                    {
                        rstPiece = new Recordset();
                        rstPiece.Open($"SELECT * FROM Achat_Pieces WHERE IDAchat = '{sIDAchat}' AND IndexAchat = {iIndexAchat} And NuméroLigne = {lvwPieces.FocusedItem.SubItems[10].Text}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstPiece.Fields["Recu"].Value = false;
                        rstPiece.Fields["Commandé"].Value = true;
                        rstPiece.Fields["DateRéception"].Value = "";
                        rstPiece.Update();
                        if ((int.Parse(Droite(sIDAchat, 2)) >= 0 & int.Parse(Droite(sIDAchat, 2)) <= 12) | (int)rstPiece.Fields["IDFRS"].Value == 717)
                        {
                            EnleverInventaireAchat();
                        }
                        rstPiece.Close();
                        rstPiece = null;
                        m_iIndexReception = lvwPieces.FocusedItem.Index;
                        RemplirListViewAchat(txtNoProjet.Text);
                    }
                    else
                    {
                        MessageBox.Show($"Ce projet est en modification par {rstAchat.Fields["Par"].Value}!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstAchat.Close();
                    rstAchat = null;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "AnnulerReceptionAchat", ex); }
        }
        private void EnleverInventaireAchat()
        {
            try
            {
                ADODB.Recordset rstInventaire;
                var sQuantite = default(string);
                if (MessageBox.Show("Voulez-vous modifier l'inventaire?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstInventaire = new Recordset();
                    rstInventaire.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + lvwPieces.FocusedItem.SubItems[1].Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstInventaire.EOF)
                    {
                        if ((bool)rstInventaire.Fields["CommandeParBoite"].Value == true)
                        {
                            if (lvwPieces.FocusedItem.SubItems[10].Text == "717")
                            {
                                rstInventaire.Fields["QuantitéStock"].Value = double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(lvwPieces.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value).ToString().Replace("", ",");
                            }
                            else
                            {
                                rstInventaire.Fields["QuantitéStock"].Value = double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(lvwPieces.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value).ToString().Replace(".", ",");
                            }
                            sQuantite = (double.Parse(lvwPieces.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString();
                        }
                        else
                        {
                            if (lvwPieces.FocusedItem.SubItems[10].Text == "717")
                            {
                                rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(lvwPieces.FocusedItem.Text)).ToString(), "", ",");
                            }
                            else
                            {
                                rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(lvwPieces.FocusedItem.Text)).ToString(), ".", ",");
                            }
                            sQuantite = double.Parse(lvwPieces.FocusedItem.Text).ToString();
                        }
                        rstInventaire.Update();
                    }
                    rstInventaire.Close();
                    rstInventaire = null;
                    SupprimerHistorique(sQuantite);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "EnleverInventaireAchat", ex); }
        }
        private void AjouterInventaireProjet()
        {
            try
            {
                ADODB.Recordset rstInventaire;
                var sQuantite = default(string);
                if (MessageBox.Show("Voulez-vous modifier l'inventaire?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstInventaire = new Recordset();
                    rstInventaire.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + Strings.Replace(lvwPieces.FocusedItem.SubItems[1].Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstInventaire.EOF)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInventaire.Fields["CommandeParBoite"].Value, true, false)))
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(lvwPieces.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), ".", ",");
                            sQuantite = (double.Parse(lvwPieces.FocusedItem.Text) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString();
                        }
                        else
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(lvwPieces.FocusedItem.Text)).ToString(), ".", ",");
                            sQuantite = double.Parse(lvwPieces.FocusedItem.Text).ToString();
                        }
                        rstInventaire.Update();
                    }
                    rstInventaire.Close();
                    rstInventaire = null;
                    SupprimerHistorique(sQuantite);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "AjouterInventaireProjet", ex); }
        }
        private void cmdDateRequise_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDateRequise.Text))
                {
                    mvwDateRequise.SelectionStart = Conversions.ToDate(txtDateRequise.Text);
                }
                else
                {
                    mvwDateRequise.SelectionStart = DateTime.Today;
                } ((dynamic)mvwDateRequise).Visible = true;
                ((dynamic)mvwDateRequise).Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmdDateRequise_Click", ex); }
        }
        private void cmdFermerPieces_Click(object eventSender, EventArgs eventArgs)
        {
            listView1.Visible = true;
            try
            {
                fraPiecesNonRecues.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmdFermerPieces_Click", ex); }
        }
        [Obsolete]
        private void cmdImprimerPieces_Click(object eventSender, EventArgs eventArgs)
        {
            ADODB.Recordset rstPiece;
            rstPiece = new Recordset();
            if (m_eType == EnumType.TYPE_PROJET)
            {
                if (chkDateRequise.Checked & chkProjetAchat.Checked)
                {
                    rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                        "INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS" +
                        " WHERE Type = 'M' AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND IDProjet = '" + txtProjetAchat.Text + "' " +
                        "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else if (chkDateRequise.Checked)
                {
                    rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                        "INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                        "WHERE Type = 'M' AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' " +
                        "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else if (chkProjetAchat.Checked)
                {
                    rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                        "INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                        "WHERE Type = 'M' AND Commandé = 1 AND IDProjet = '" + txtProjetAchat.Text + "' " +
                        "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                        "INNER JOIN Fournisseur ON Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                        "WHERE Type = 'M' AND Commandé = 1 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
            }
            else if (chkDateRequise.Checked & chkProjetAchat.Checked)
            {
                rstPiece.Open("SELECT (Achat_Pieces.IDAchat &  '-' & RIGHT('00' & Achat_Pieces.IndexAchat,3)) AS NoAchat, Achat_Pieces.*," +
                    " Fournisseur.NomFournisseur FROM Achat_Pieces " +
                    "INNER JOIN Fournisseur ON Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                    "WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND IDAchat = '" + Gauche(txtProjetAchat.Text, 9) + "' AND IndexAchat = " + 
                    int.Parse(Droite(txtProjetAchat.Text, 3)) + 
                    " ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else if (chkDateRequise.Checked)
            {
                rstPiece.Open("SELECT (Achat_Pieces.IDAchat &  '-' & RIGHT('00' & Achat_Pieces.IndexAchat,3)) AS NoAchat, Achat_Pieces.*, " +
                    "Fournisseur.NomFournisseur FROM Achat_Pieces " +
                    "INNER JOIN Fournisseur ON Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                    "WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' " +
                    "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else if (chkProjetAchat.Checked)
            {
                rstPiece.Open("SELECT (Achat_Pieces.IDAchat &  '-' & RIGHT('00' & Achat_Pieces.IndexAchat,3)) AS NoAchat, Achat_Pieces.*, " +
                    "Fournisseur.NomFournisseur FROM Achat_Pieces " +
                    "INNER JOIN Fournisseur ON Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                    "WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND IDAchat = '" + Gauche(txtProjetAchat.Text, 9) + "' AND IndexAchat = " + int.Parse(Droite(txtProjetAchat.Text, 3)) + 
                    " ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else
            {
                rstPiece.Open("SELECT (Achat_Pieces.IDAchat &  '-' & RIGHT('00' & Achat_Pieces.IndexAchat,3)) AS NoAchat, Achat_Pieces.*" +
                    ",Fournisseur.NomFournisseur FROM Achat_Pieces " +
                    "INNER JOIN Fournisseur ON Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                    "WHERE LEN(IDAchat) = 9 AND Commandé = 1 " +
                    "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            ViewBackOrder.DataSource = rstPiece;
            if (m_eType == EnumType.TYPE_PROJET)
            {
                ViewBackOrder.lblTitre.Text = "Projets mécaniques : Pièces non reçues";
                ViewBackOrder.lblTitreProjetAchat.Text = "Projet : ";
            }
            else
            {
                ViewBackOrder.lblTitre.Text = "Achats mécaniques : Pièces non reçues";
                ViewBackOrder.lblTitreProjetAchat.Text = "ACHAT : ";
            }
            ViewBackOrder.lblDate.Text = txtDateRequise.Text;
            ViewBackOrder.lblProjetAchat.Text = txtProjetAchat.Text;
            if (m_eType == EnumType.ACHAT)
            {
                ViewBackOrder.lblTitreNoProjet.Text = "# ACHAT";
                ViewBackOrder.lblTitreNoProjet.Text = "NoAchat";
                ViewBackOrder.txtNoItem.Text = "PIECE";
            }
            try
            {
                ViewBackOrder f = new ViewBackOrder();
                f.Show();
                rstPiece.Close();
                rstPiece = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmdImprimerPieces_Click", ex); }
        }
        private void cmdNonRecu_Click(object eventSender, EventArgs eventArgs)
        {
            listView1.Visible = false;
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
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmdNonRecu_Click", ex); }
        }
        private void RemplirListePiecesNonRecues()
        {
            try
            {
                ListViewItem itmPiece;
                ADODB.Recordset rstPiece;
                lvwPieces.Items.Clear();
                rstPiece = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    if (chkDateRequise.Checked & chkProjetAchat.Checked)
                    {
                        rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER JOIN Fournisseur on Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                            "WHERE Type = 'M' AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND IDProjet = '" + txtProjetAchat.Text + "' AND DateRequise <> '' " +
                            "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else if (chkDateRequise.Checked)
                    {
                        rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER JOIN Fournisseur on Projet_Pieces.IDFRS = Fournisseur.IDFRS " +
                            "WHERE Type = 'M' AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND DateRequise <> '' " +
                            "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else if (chkProjetAchat.Checked)
                    {
                        rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER JOIN Fournisseur on Projet_Pieces.IDFRS =Fournisseur.IDFRS " +
                            "WHERE Type = 'M' AND Commandé = 1 AND IDProjet = '" + txtProjetAchat.Text + "' " +
                            "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstPiece.Open("SELECT Projet_Pieces.*, Fournisseur.NomFournisseur FROM Projet_Pieces " +
                            "INNER JOIN Fournisseur on Projet_Pieces.IDFRS = Fournisseur.IDFRS WHERE Type = 'M' AND Commandé = 1 " +
                            "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                }
                else if (chkDateRequise.Checked & chkProjetAchat.Checked)
                {
                    rstPiece.Open("SELECT Achat_Pieces.*, Fournisseur.NomFournisseur FROM Achat_Pieces " +
                        "INNER JOIN Fournisseur on Achat_Pieces.IDFRS =Fournisseur.IDFRS WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text +
                        "' AND IDAchat = '" + Gauche(txtProjetAchat.Text, 9) + "' AND IndexAchat = " + int.Parse(Droite(txtProjetAchat.Text, 3)) + " AND DateRequise <> '' " +
                        "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else if (chkDateRequise.Checked)
                {
                    rstPiece.Open("SELECT Achat_Pieces.*, Fournisseur.NomFournisseur FROM Achat_Pieces " +
                        "INNER JOIN Fournisseur on Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                        "WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND DateRequise <= '" + txtDateRequise.Text + "' AND DateRequise <> '' " +
                        "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else if (chkProjetAchat.Checked)
                {
                    rstPiece.Open("SELECT Achat_Pieces.*, Fournisseur.NomFournisseur FROM Achat_Pieces " +
                        "INNER JOIN Fournisseur on Achat_Pieces.IDFRS = Fournisseur.IDFRS WHERE LEN(IDAchat) = 9 AND Commandé = 1 AND IDAchat = '" + Gauche(txtProjetAchat.Text, 9) 
                        + "' AND IndexAchat = " + int.Parse(Droite(txtProjetAchat.Text, 3)) + 
                        " ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstPiece.Open("SELECT Achat_Pieces.*, Fournisseur.NomFournisseur FROM Achat_Pieces " +
                        "INNER JOIN Fournisseur on Achat_Pieces.IDFRS = Fournisseur.IDFRS " +
                        "WHERE LEN(IDAchat) = 9 AND Commandé = 1 " +
                        "ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstPiece.EOF)
                {
                    itmPiece = lvwPieces.Items.Add(string.Empty);
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        itmPiece.Text = $"{rstPiece.Fields["IDProjet"].Value}";
                    }
                    else
                    {
                        itmPiece.Text = $"{rstPiece.Fields["IDAchat"].Value}-{Droite($"00{rstPiece.Fields["IndexAchat"].Value}", 3)}";
                    }
                    if (itmPiece.SubItems.Count > 0)
                    {
                        itmPiece.SubItems[0].Text = $"{rstPiece.Fields["Qté"].Value}";
                    }
                    else
                    {
                        itmPiece.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["Qté"].Value}"));
                    }
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        if (itmPiece.SubItems.Count > 1)
                        {
                            itmPiece.SubItems[1].Text = $"{rstPiece.Fields["NumItem"].Value}";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["NumItem"].Value}"));
                        }
                    }
                    else if (itmPiece.SubItems.Count > 1)
                    {
                        itmPiece.SubItems[1].Text = $"{rstPiece.Fields["PIECE"].Value}";
                    }
                    else
                    {
                        itmPiece.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["PIECE"].Value}"));
                    }
                    if (itmPiece.SubItems.Count > 2)
                    {
                        itmPiece.SubItems[1].Text = $"{rstPiece.Fields["Desc_FR"].Value}";
                    }
                    else
                    {
                        itmPiece.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["Desc_FR"].Value}"));
                    }
                    if (itmPiece.SubItems.Count > 4)
                    {
                        itmPiece.SubItems[4].Text = $"{rstPiece.Fields["NomFournisseur"].Value}";
                    }
                    else
                    {
                        itmPiece.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["NomFournisseur"].Value}"));
                    }
                    if (!(rstPiece.Fields["DateCommande"].Value is DBNull))
                    {
                        if (itmPiece.SubItems.Count > 6)
                        {
                            itmPiece.SubItems[6].Text = $"{rstPiece.Fields["DateCommande"].Value}";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["DateCommande"].Value}"));
                        }
                    }
                    else if (itmPiece.SubItems.Count > 6)
                    {
                        itmPiece.SubItems[6].Text = string.Empty;
                    }
                    else
                    {
                        itmPiece.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, ""));
                    }
                    if (!(rstPiece.Fields["DateRequise"].Value is DBNull))
                    {
                        if (itmPiece.SubItems.Count > 7)
                        {
                            itmPiece.SubItems[7].Text = $"{rstPiece.Fields["DateRequise"].Value}";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rstPiece.Fields["DateRequise"].Value}"));
                        }
                    }
                    else if (itmPiece.SubItems.Count > 7)
                    {
                        itmPiece.SubItems[7].Text = string.Empty;
                    }
                    else
                    {
                        itmPiece.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, ""));
                    }
                    itmPiece.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, ""));
                    itmPiece.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, ""));
                    rstPiece.MoveNext();
                }
                rstPiece.Close();
                rstPiece = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "RemplirListePiecesNonRecues", ex); }
        }
        private void lvwPieces_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                VerifierBoutonAnnuler();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "lvwPieces_Click", ex); }
        }
        private void lvwPieces_DoubleClick(object eventSender, EventArgs eventArgs)
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "Reception", ex); }
        }
        private void ReceptionProjet()
        {
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
                if (lvwPieces.Items.Count > 0)
                {
                    rstProjet = new Recordset();
                    rstProjet.Open("SELECT Modification, Par, Profit FROM ProjetMec WHERE IDProjet = '" + txtNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjet.Fields["Modification"].Value, false, false)))
                    {
                        if (listView1.FocusedItem.ForeColor == COLOR_ORANGE | listView1.FocusedItem.ForeColor == COLOR_BLEU) // COLOR_ORANGE ou bleu
                        {
                            sQuantite = Interaction.InputBox("Quelle est la quantité recue?");
                            sQuantite = Strings.Replace(sQuantite, ".", ",");
                            sProfit = (string)rstProjet.Fields["Profit"].Value;
                            if (!string.IsNullOrEmpty(sQuantite))
                            {
                                if (IsNumeric(sQuantite))
                                {
                                    if (double.Parse(sQuantite) > 0d)
                                    {
                                        rstPiece = new Recordset();
                                        rstModif = new Recordset();
                                        rstEmploye = new Recordset();
                                        if (double.Parse(sQuantite) == double.Parse(listView1.FocusedItem.Text))
                                        {
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND Type = 'M' AND NuméroLigne = ", lvwPieces.FocusedItem.SubItems[3].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstPiece.Fields["Recu"].Value = true;
                                            rstPiece.Fields["Commandé"].Value = false;
                                            rstPiece.Fields["DateRéception"].Value = txtDateReception.Text;
                                            rstPiece.Update();
                                            rstModif.Open("SELECT * FROM Projet_Modif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstModif.AddNew();
                                            rstEmploye.Open("SELECT noEmploye FROM Employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstModif.Fields["Type"].Value = "M";
                                            rstModif.Fields["IDProjet"].Value = txtNoProjet.Text;
                                            rstModif.Fields["noEmployé"].Value = rstEmploye.Fields["noEmploye"].Value;
                                            rstModif.Fields["Date"].Value = ConvertDate(DateTime.Today);
                                            rstModif.Fields["Heure"].Value = DateAndTime.TimeOfDay;
                                            rstModif.Fields["TypeModif"].Value = "RECEPTION";
                                            rstEmploye.Close();
                                            rstModif.Update();
                                            rstModif.Close();
                                            rstPiece.Close();
                                            if (Strings.UCase(lvwPieces.FocusedItem.SubItems[4].Text) == "SOLUTION GRB INC.")
                                            {
                                                EnleverInventaireProjet(sQuantite);
                                            }
                                            m_iIndexReception = lvwPieces.FocusedItem.Index;
                                            RemplirListViewProjet(txtNoProjet.Text);
                                        }
                                        else if (double.Parse(sQuantite) < double.Parse(lvwPieces.FocusedItem.Text))
                                        {
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND Type = 'M' AND NuméroLigne = ", listView1.FocusedItem.SubItems[3].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            sTotal = (string)rstPiece.Fields["Qté"].Value;
                                            rstPiece.Fields["Qté"].Value = sQuantite;
                                            rstPiece.Fields["Prix_Total"].Value = (string)Math.Round(Operators.MultiplyObject(Operators.MultiplyObject(double.Parse(Strings.Replace((string)rstPiece.Fields["Qté"].Value, "*", string.Empty)), rstPiece.Fields["Prix_net"].Value), double.Parse(sProfit)), 2);
                                            rstPiece.Fields["Profit_argent"].Value = (string)Math.Round(Operators.SubtractObject(rstPiece.Fields["Prix_total"].Value, Operators.MultiplyObject(rstPiece.Fields["Prix_net"].Value, double.Parse(Strings.Replace((string)rstPiece.Fields["Qté"].Value, "*", string.Empty)))), 2);
                                            rstPiece.Fields["Recu"].Value = true;
                                            rstPiece.Fields["Commandé"].Value = false;
                                            rstPiece.Fields["DateRéception"].Value = txtDateReception.Text;
                                            rstPiece.Update();
                                            rstCopiePiece = new Recordset();
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
                                            rstCopiePiece.Fields["Prix_Total"].Value = (string)Math.Round(Operators.MultiplyObject(Operators.MultiplyObject(double.Parse(Strings.Replace((string)rstCopiePiece.Fields["Qté"].Value, "*", string.Empty)), rstCopiePiece.Fields["Prix_net"].Value), double.Parse(sProfit)), 2);
                                            rstCopiePiece.Fields["Profit_Pourcent"].Value = rstPiece.Fields["Profit_Pourcent"].Value;
                                            rstCopiePiece.Fields["Profit_argent"].Value = (string)Math.Round(Operators.SubtractObject(rstCopiePiece.Fields["Prix_total"].Value, Operators.MultiplyObject(rstCopiePiece.Fields["Prix_net"].Value, double.Parse(Strings.Replace((string)rstCopiePiece.Fields["Qté"].Value, "*", string.Empty)))), 2);
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
                                            rstCopiePiece = null;
                                            rstPiece.Close();
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND Type = 'M' AND NuméroLigne >= ", Operators.AddObject(lvwPieces.FocusedItem.SubItems[3].Tag, 1)), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            bSkip = false;
                                            while (!rstPiece.EOF)
                                            {
                                                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["NumItem"].Value, lvwPieces.FocusedItem.SubItems[1].Text, false), Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["Qté"].Value, double.Parse(sTotal) - double.Parse(sQuantite), false)), bSkip == true)))
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
                                            rstEmploye.Open("SELECT noEmploye FROM Employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstModif.Fields["Type"].Value = "M";
                                            rstModif.Fields["IDProjet"].Value = txtNoProjet.Text;
                                            rstModif.Fields["noEmployé"].Value = rstEmploye.Fields["noEmploye"].Value;
                                            rstModif.Fields["Date"].Value = ConvertDate(DateTime.Today);
                                            rstModif.Fields["Heure"].Value = DateAndTime.TimeOfDay;
                                            rstModif.Fields["TypeModif"].Value = "RECEPTION";
                                            rstEmploye.Close();
                                            rstModif.Update();
                                            rstModif.Close();
                                            if (Strings.UCase(lvwPieces.FocusedItem.SubItems[4].Text) == "SOLUTION GRB INC.")
                                            {
                                                EnleverInventaireProjet(sQuantite);
                                            }
                                            m_iIndexReception = lvwPieces.FocusedItem.Index;
                                            RemplirListViewProjet(txtNoProjet.Text);
                                        }
                                        else
                                        {
                                            MessageBox.Show("La quantité est trop grande!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        rstPiece = null;
                                        rstModif = null;
                                        rstEmploye = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("La quantité doit être plus grande que 0!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Quantité non numérique!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(Operators.ConcatenateObject(Operators.ConcatenateObject("Ce projet est en modification par ", rstProjet.Fields["Par"].Value), "!"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstProjet.Close();
                    rstProjet = null;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "Reception", ex); }
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
                if (listView1.Items.Count > 0)
                {
                    sIDAchat = Gauche(txtNoProjet.Text, 9);
                    iIndexAchat = int.Parse(Droite(txtNoProjet.Text, 3));
                    rstAchat = new Recordset();
                    rstAchat.Open("SELECT Modification, Par FROM Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstAchat.Fields["Modification"].Value, false, false)))
                    {
                        if (listView1.FocusedItem.ForeColor == COLOR_ORANGE | listView1.FocusedItem.ForeColor == COLOR_BLEU) // COLOR_ORANGE ou bleu
                        {
                            sQuantite = Interaction.InputBox("Quelle est la quantité reçue?");
                            sQuantite = Strings.Replace(sQuantite, ".", ",");
                            if (!string.IsNullOrEmpty(sQuantite))
                            {
                                if (IsNumeric(sQuantite))
                                {
                                    if (double.Parse(sQuantite) > 0d)
                                    {
                                        rstPiece = new Recordset();
                                        if (double.Parse(sQuantite) == double.Parse(lvwPieces.FocusedItem.Text))
                                        {
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " AND NuméroLigne = ", lvwPieces.FocusedItem.SubItems[3].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            rstPiece.Fields["Recu"].Value = true;
                                            rstPiece.Fields["Commandé"].Value = false;
                                            rstPiece.Fields["DateRéception"].Value = txtDateReception.Text;
                                            rstPiece.Update();
                                            if (Conversions.ToBoolean(Operators.OrObject(int.Parse(Droite(sIDAchat, 2)) >= 0 & int.Parse(Droite(sIDAchat, 2)) <= 12, Operators.ConditionalCompareObjectEqual(rstPiece.Fields["IDFRS"].Value, 717, false))))
                                            {
                                                AjouterInventaireAchat(sQuantite);
                                            }
                                            rstPiece.Close();
                                            m_iIndexReception = lvwPieces.FocusedItem.Index;
                                            RemplirListViewAchat(txtNoProjet.Text);
                                        }
                                        else if (double.Parse(sQuantite) < double.Parse(lvwPieces.FocusedItem.Text))
                                        {
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " AND NuméroLigne = ", lvwPieces.FocusedItem.SubItems[3].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            sTotal = (string)rstPiece.Fields["Qté"].Value;
                                            rstPiece.Fields["Qté"].Value = sQuantite;
                                            rstPiece.Fields["Prix_Total"].Value = (string)Math.Round(Operators.MultiplyObject(double.Parse(Strings.Replace((string)rstPiece.Fields["Qté"].Value, "*", string.Empty)), rstPiece.Fields["Prix_net"].Value), 2);
                                            rstPiece.Fields["Recu"].Value = true;
                                            rstPiece.Fields["Commandé"].Value = false;
                                            rstPiece.Fields["DateRéception"].Value = txtDateReception.Text;
                                            rstPiece.Update();
                                            rstCopiePiece = new Recordset();
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
                                            rstCopiePiece.Fields["Prix_Total"].Value = (string)Math.Round(Operators.MultiplyObject(double.Parse(Strings.Replace((string)rstCopiePiece.Fields["Qté"].Value, "*", string.Empty)), rstCopiePiece.Fields["Prix_net"].Value), 2);
                                            rstCopiePiece.Fields["NuméroLigne"].Value = Operators.AddObject(rstPiece.Fields["NuméroLigne"].Value, 1);
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
                                            rstCopiePiece = null;
                                            iIDFRS = 717;
                                            rstPiece.Close();
                                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " AND NuméroLigne >= ", Operators.AddObject(lvwPieces.FocusedItem.SubItems[3].Tag, 1)), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            bSkip = false;
                                            while (!rstPiece.EOF)
                                            {
                                                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["PIECE"].Value, lvwPieces.FocusedItem.SubItems[1].Text, false), Operators.ConditionalCompareObjectNotEqual(rstPiece.Fields["Qté"].Value, double.Parse(sTotal) - double.Parse(sQuantite), false)), bSkip == true)))
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
                                            m_iIndexReception = lvwPieces.FocusedItem.Index;
                                            RemplirListViewAchat(txtNoProjet.Text);
                                        }
                                        else
                                        {
                                            MessageBox.Show("La quantité est trop grande!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        rstPiece = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("La quantité doit être plus grande que 0!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Quantité non numérique!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(Operators.ConcatenateObject(Operators.ConcatenateObject("Ce projet est en modification par ", rstAchat.Fields["Par"].Value), "!"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstAchat.Close();
                    rstAchat = null;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "ReceptionAchat", ex); }
        }
        private void EnleverInventaireProjet(string sQuantite)
        {
            try
            {
                ADODB.Recordset rstInventaire;
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstProjet;
                if (MessageBox.Show("Voulez-vous modifier l'inventaire?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstInventaire = new Recordset();
                    rstInventaire.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + Strings.Replace(lvwPieces.FocusedItem.SubItems[1].Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstInventaire.EOF)
                    {
                        rstInventaire.AddNew();
                        rstInventaire.Fields["NoItem"].Value = lvwPieces.FocusedItem.SubItems[1].Text;
                        rstInventaire.Fields["Description"].Value = lvwPieces.FocusedItem.SubItems[2].Text;
                        rstInventaire.Fields["Manufacturier"].Value = lvwPieces.FocusedItem.SubItems[3].Text;
                        Form f = new ChoixQteBoite(lvwPieces.FocusedItem.SubItems[1].Text);
                        f.Show();
                        rstInventaire.Fields["CommandeParBoite"].Value = g_bQteBoite;
                        rstInventaire.Fields["QteBoite"].Value = g_sQteBoite;
                        rstInventaire.Fields["Commentaires"].Value = "";
                        rstInventaire.Fields["QuantitéStock"].Value = "0";
                        f = new ChoixLocalisation(EnumCatalogue.MECANIQUE, lvwPieces.FocusedItem.SubItems[1].Text);
                        f.Show();
                        rstInventaire.Fields["Localisation"].Value = g_sLocalisation;
                        rstInventaire.Fields["Minimum"].Value = false;
                        rstInventaire.Fields["QuantitéMinimum"].Value = "";
                        rstInventaire.Fields["Commande"].Value = "";
                    }
                    rstProjet = new Recordset();
                    rstProjet.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + txtNoProjet.Text + "' AND NuméroLigne = ", lvwPieces.FocusedItem.SubItems[3].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInventaire.Fields["CommandeParBoite"].Value, true, false)))
                    {
                        rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(sQuantite) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), ".", ",");
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstProjet.Fields["Prix_List"].Value, "", false)))
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstInventaire.Fields["QteBoite"].Value, "", false)))
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
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstInventaire.Fields["QteBoite"].Value, "", false)))
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
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstProjet.Fields["Prix_List"].Value, "", false)))
                        {
                            rstInventaire.Fields["Prix Liste"].Value = rstProjet.Fields["Prix_List"].Value;
                        }
                        else
                        {
                            rstInventaire.Fields["Prix Liste"].Value = "";
                        }
                        rstInventaire.Fields["Escompte"].Value = rstProjet.Fields["Escompte"].Value;
                        rstInventaire.Fields["Prix net"].Value = rstProjet.Fields["Prix_Net"].Value;
                    }
                    rstInventaire.Update();
                    rstPieceFRS = new Recordset();
                    rstPieceFRS.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(lvwPieces.FocusedItem.SubItems[1].Text, "'", "''") + "' AND IDFRS = 717", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstPieceFRS.EOF)
                    {
                        rstPieceFRS.AddNew();
                        rstPieceFRS.Fields["IDFRS"].Value = 717;
                        rstPieceFRS.Fields["PIECE"].Value = lvwPieces.FocusedItem.SubItems[1].Text;
                        rstPieceFRS.Fields["PERS_RESS"].Value = 901;
                        rstPieceFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                        rstPieceFRS.Fields["DeviseMonétaire"].Value = "CAN";
                        rstPieceFRS.Fields["Type"].Value = "M";
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
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInventaire.Fields["CommandeParBoite"].Value, true, false)))
                    {
                        sQuantite = Strings.Replace((double.Parse(sQuantite) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), ".", ",");
                    }
                    rstInventaire.Close();
                    rstInventaire = null;
                    AjouterHistorique(sQuantite);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "EnleverInventaireProjet", ex); }
        }
        private void AjouterInventaireAchat(string sQuantite)
        {
            try
            {
                ADODB.Recordset rstInventaire;
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstAchat;
                string sIDAchat;
                int iIndexAchat;
                int X;
                if (MessageBox.Show("Voulez-vous modifier l'inventaire?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstInventaire = new Recordset();
                    rstInventaire.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + Strings.Replace(lvwPieces.FocusedItem.SubItems[1].Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstInventaire.EOF)
                    {
                        rstInventaire.AddNew();
                        rstInventaire.Fields["NoItem"].Value = lvwPieces.FocusedItem.SubItems[1].Text;
                        rstInventaire.Fields["Description"].Value = lvwPieces.FocusedItem.SubItems[2].Text;
                        rstInventaire.Fields["Manufacturier"].Value = lvwPieces.FocusedItem.SubItems[3].Text;
                        Form f = new ChoixQteBoite(lvwPieces.FocusedItem.SubItems[1].Text);
                        f.Show();
                        rstInventaire.Fields["CommandeParBoite"].Value = g_bQteBoite;
                        rstInventaire.Fields["QteBoite"].Value = g_sQteBoite;
                        rstInventaire.Fields["Commentaires"].Value = "";
                        rstInventaire.Fields["QuantitéStock"].Value = "0";
                        f = new ChoixLocalisation(EnumCatalogue.MECANIQUE, lvwPieces.FocusedItem.SubItems[1].Text);
                        f.Show();
                        rstInventaire.Fields["Localisation"].Value = g_sLocalisation;
                        rstInventaire.Fields["Minimum"].Value = false;
                        rstInventaire.Fields["QuantitéMinimum"].Value = "";
                        rstInventaire.Fields["Commande"].Value = "";
                    }
                    sIDAchat = Gauche(txtNoProjet.Text, 9);
                    iIndexAchat = int.Parse(Droite(txtNoProjet.Text, 3));
                    rstAchat = new Recordset();
                    rstAchat.Open(Operators.ConcatenateObject("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " AND NuméroLigne = ", lvwPieces.FocusedItem.SubItems[3].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstInventaire.Fields["CommandeParBoite"].Value, true, false)))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstAchat.Fields["IDFRS"].Value, 717, false)))
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(sQuantite) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), ".", ",");
                        }
                        else
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(sQuantite) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), ".", ",");
                        }
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstAchat.Fields["Prix_List"].Value, "", false)))
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstInventaire.Fields["QteBoite"].Value, "", false)))
                            {
                                rstInventaire.Fields["Prix Liste"].Value = Strings.Replace((string)Operators.DivideObject(rstAchat.Fields["Prix_List"].Value, rstInventaire.Fields["QteBoite"].Value), ".", ",");
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
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstInventaire.Fields["QteBoite"].Value, "", false)))
                        {
                            rstInventaire.Fields["Prix net"].Value = Strings.Replace((string)Operators.DivideObject(rstAchat.Fields["Prix_Net"].Value, rstInventaire.Fields["QteBoite"].Value), ".", ",");
                        }
                        else
                        {
                            rstInventaire.Fields["Prix net"].Value = rstAchat.Fields["Prix_Net"].Value;
                        }
                    }
                    else
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstAchat.Fields["IDFRS"].Value, 717, false)))
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) - double.Parse(sQuantite)).ToString(), ".", ",");
                        }
                        else
                        {
                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(sQuantite)).ToString(), ".", ",");
                        }
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstAchat.Fields["Prix_List"].Value, "", false)))
                        {
                            rstInventaire.Fields["Prix Liste"].Value = rstAchat.Fields["Prix_List"].Value;
                        }
                        else
                        {
                            rstInventaire.Fields["Prix Liste"].Value = "0";
                        }
                        rstInventaire.Fields["Escompte"].Value = rstAchat.Fields["Escompte"].Value;
                        rstInventaire.Fields["Prix net"].Value = rstAchat.Fields["Prix_Net"].Value;
                    }
                    rstInventaire.Update();
                    rstPieceFRS = new Recordset();
                    rstPieceFRS.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(lvwPieces.FocusedItem.SubItems[1].Text, "'", "''") + "' AND IDFRS = 717", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstPieceFRS.EOF)
                    {
                        rstPieceFRS.AddNew();
                        rstPieceFRS.Fields["IDFRS"].Value = 717;
                        rstPieceFRS.Fields["PIECE"].Value = lvwPieces.FocusedItem.SubItems[1].Text;
                        rstPieceFRS.Fields["PERS_RESS"].Value = 901;
                        rstPieceFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                        rstPieceFRS.Fields["DeviseMonétaire"].Value = "CAN";
                        rstPieceFRS.Fields["Type"].Value = "M";
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "AjouterInventaireAchat", ex); }
        }
        private void AjouterHistorique(string sQuantite)
        {
            try
            {
                ADODB.Recordset rstHist;
                rstHist = new Recordset();
                rstHist.Open("SELECT * FROM InventaireMecModif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstHist.AddNew();
                rstHist.Fields["Date"].Value = txtDateReception.Text;
                rstHist.Fields["IDProjet"].Value = txtNoProjet.Text;
                rstHist.Fields["NoItem"].Value = lvwPieces.FocusedItem.SubItems[1].Text;
                if (m_eType == EnumType.ACHAT)
                {
                    if ((int)lvwPieces.FocusedItem.SubItems[4].Tag == 717)
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "AjouterHistorique", ex); }
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
                        if ((int)listView1.FocusedItem.SubItems[4].Tag == 717)
                        {
                            rstHist.Open("SELECT * FROM InventaireMecModif WHERE [Date] = '" + listView1.FocusedItem.SubItems[5].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(listView1.FocusedItem.SubItems[1].Text, "'", "''") + "' AND Quantité = '-" + sQuantite + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstHist.Open("SELECT * FROM InventaireMecModif WHERE [Date] = '" + listView1.FocusedItem.SubItems[5].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(listView1.FocusedItem.SubItems[1].Text, "'", "''") + "' AND Quantité = '" + sQuantite + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(listView1.FocusedItem.SubItems[4].Tag, 717, false)))
                    {
                        rstHist.Open("SELECT * FROM InventaireMecModif WHERE [Date] = '" + listView1.FocusedItem.SubItems[5].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(listView1.FocusedItem.SubItems[1].Text, "'", "''") + "' AND Quantité = '-" + listView1.FocusedItem.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstHist.Open("SELECT * FROM InventaireMecModif WHERE [Date] = '" + listView1.FocusedItem.SubItems[5].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(listView1.FocusedItem.SubItems[1].Text, "'", "''") + "' AND Quantité = '" + listView1.FocusedItem.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                }
                else if (!string.IsNullOrEmpty(sQuantite))
                {
                    rstHist.Open("SELECT * FROM InventaireMecModif WHERE [Date] = '" + listView1.FocusedItem.SubItems[5].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(listView1.FocusedItem.SubItems[1].Text, "'", "''") + "' AND Quantité = '" + "-" + sQuantite + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstHist.Open("SELECT * FROM InventaireMecModif WHERE [Date] = '" + listView1.FocusedItem.SubItems[5].Text + "' AND IDProjet = '" + txtNoProjet.Text + "' AND NoItem = '" + Strings.Replace(listView1.FocusedItem.SubItems[1].Text, "'", "''") + "' AND Quantité = '" + "-" + listView1.FocusedItem.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                if (!rstHist.EOF)
                {
                    rstHist.Delete();
                }
                rstHist.Close();
                rstHist = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "SupprimerHistorique", ex); }
        }
        private void Cmdfermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmdFermer_Click", ex); }
        }
        [Obsolete]
        private void ReceptionMec_Load(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                txtDateReception.Text = ConvertDate(DateTime.Today);
                txtDateRequise.Text = ConvertDate(DateTime.Today);
                if (!string.IsNullOrEmpty(m_sNoProjet))
                {
                    cmbType.SelectedIndex = 0;
                    for (X = 0; X < cmbNoProjet.Items.Count; X++)
                    {
                        if ((cmbNoProjet.Items[X].ToString() ?? "") == (m_sNoProjet ?? ""))
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
                        if ((cmbNoProjet.Items[X].ToString() ?? "") == (m_sNoAchat ?? ""))
                        {
                            cmbNoProjet.SelectedIndex = X; break;
                        }
                    }
                }
                else
                {
                    cmbType.SelectedIndex = 0;
                }
                RemplirListeProjet();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "Form_Load", ex); }
        }
        private void RemplirComboProjet()
        {
            try
            {
                ADODB.Recordset rstProjet;
                cmbNoProjet.Items.Clear();
                rstProjet = new Recordset();
                rstProjet.Open("SELECT IDProjet FROM ProjetMec ORDER BY IDProjet DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstProjet.EOF)
                {
                    cmbNoProjet.Items.Add(rstProjet.Fields[0].Value);
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "RemplirComboProjet", ex); }
        }
        private void RemplirComboAchat()
        {
            try
            {
                ADODB.Recordset rstAchat;
                cmbNoProjet.Items.Clear();
                rstAchat = new Recordset();
                rstAchat.Open("SELECT IDAchat, IndexAchat FROM Achat WHERE Type = 'M' ORDER BY IDAchat DESC, IndexAchat DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstAchat.EOF)
                {
                    cmbNoProjet.Items.Add($"{rstAchat.Fields[0].Value}-{Droite($"000{rstAchat.Fields[1].Value}", 3)}");
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "RemplirComboAchat", ex); }
        }
        [Obsolete]
        private void RemplirListViewProjet(string sNoProjet)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            Recordset rd = new Recordset();
            rd.Open($"SELECT[Qté],[NumItem],[Desc_FR],[Manufact] ,[Fournisseur].NomFournisseur,[DateRéception],[DateCommande],[DateRequise],[NoEnreg] FROM Projet_Pieces " +
         $"JOIN [DBO].[Fournisseur] on[DBO].[Fournisseur].IDFRS = Projet_Pieces.IDFRS " +
         $"WHERE IDProjet = '{sNoProjet}' ORDER BY NuméroLigne"
                , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                for (int x = 0; x < rd.Fields.Count; x++)
                {
                    listView1.Columns.Add(rd.Fields[x].Name);
                }
            }
            while (!rd.EOF)
            {
                ListViewItem itmProjet = listView1.Items.Add(string.Empty);
                itmProjet.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                itmProjet.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                itmProjet.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                itmProjet.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                itmProjet.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                itmProjet.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                itmProjet.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                itmProjet.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                itmProjet.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}"));
                rd.MoveNext();
            }
        }
        private void RemplirListViewAchat(string sNoProjet)
        {
            /* ID 0 : NoEnreg ID 1 : IDAchat ID 2 : IndexAchat ID 3 : PIECE ID 4 : NuméroLigne ID 5 : Qté ID 6 : Desc_FR ID 7 : Desc_EN ID 8 : Manufact ID 9 : Prix_list 
             * ID 10 : Escompte ID 11 : Prix_net ID 12 : IDFRS ID 13 : Prix_total ID 14 : Type ID 15 : Commandé ID 16 : Retour ID 17 : NoRetour ID 18 : Recu ID 19 : DateRéception 
             * ID 20 : QuantitéRecue ID 21 : DateCommande ID 22 : DateRequise ID 23 : Inutile ID 24 : CommandeAnnulée ID 25 : DateRetour ID 26 : PrixOrigine ID 27 : Devise 
             * ID 28 : IDFRS ID 29 : NomFournisseur ID 30 : Abbreviation ID 31 : Rep ID 32 : Interne ID 33 : Adresse ID 34 : Ville ID 35 : Prov/Etat ID 36 : Pays 
             * ID 37 : CodePostal ID 38 : Telephonne ID 39 : Fax ID 40 : E-mail ID 41 : CondTransport ID 42 : noposte ID 43 : siteweb ID 44 : commentaire ID 45 : DateCréation 
             * ID 46 : UserCréation ID 47 : DateModification ID 48 : UserModification ID 49 : EntryIDOutlook ID 50 : Supprimé ID 51 : Categorie*/
            listView1.Items.Clear();
            listView1.Columns.Clear();
            Recordset rd = new Recordset();
            if (sNoProjet.Split('-').Length != 3) return;
            string idAchat = $"{sNoProjet.Split('-')[0]}-{sNoProjet.Split('-')[1]}";
            int indexAchat = int.Parse(sNoProjet.Split('-')[2]);
            rd.Open($"SELECT * FROM Achat_Pieces " +
                $"join [DBO].[Fournisseur] on [DBO].[Fournisseur].IDFRS=[DBO].[Achat_Pieces].IDFRS " +
                $"WHERE IDAchat = '{sNoProjet}' AND IndexAchat = {indexAchat} ORDER BY NuméroLigne'"
                , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                for (int x = 0; x < rd.Fields.Count; x++) { listView1.Columns.Add(rd.Fields[x].Name); }
            }
            while (!rd.EOF)
            {
                ListViewItem itmProjet = listView1.Items.Add(string.Empty);
                itmProjet.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                itmProjet.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                itmProjet.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                itmProjet.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                itmProjet.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                itmProjet.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                itmProjet.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                itmProjet.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                itmProjet.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}"));
                if ((bool)rd.Fields["Commandé"].Value == true) { itmProjet.ForeColor = COLOR_ORANGE; }
                else if ((bool)rd.Fields["Recu"].Value == true) { itmProjet.ForeColor = COLOR_GRIS; }
                else if ((bool)rd.Fields["Retour"].Value == true) { itmProjet.ForeColor = COLOR_ROUGE; }
                else { itmProjet.ForeColor = COLOR_NOIR; }
                rd.MoveNext();
            }


            if (m_iIndexReception > 0)
            {
                lvwPieces.Items[m_iIndexReception].Selected = true;
                lvwPieces.Focus();
                lvwPieces.FocusedItem.EnsureVisible();
            }
            return;
        }
        private void lvwPieces_ItemClick(ListViewItem Item)
        {
            try
            {
                VerifierBoutonAnnuler();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "lvwPieces_ItemClick", ex); }
        }
        private void VerifierBoutonAnnuler()
        {
            try
            {
                if (lvwPieces.Items.Count > 0)
                {
                    if (lvwPieces.FocusedItem.ForeColor == COLOR_GRIS | lvwPieces.FocusedItem.ForeColor == COLOR_BLEU) // Gris ou bleu
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "VerifierBoutonAnnuler", ex); }
        }
        public void Afficher(string sUserID)
        {
            try
            {
                m_sUserID = sUserID;
                Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "Afficher", ex); }
        }
        public void AfficherProjet(string sUserID, string sNoProjet)
        {
            try
            {
                m_sUserID = sUserID;
                m_sNoProjet = sNoProjet;
                Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "AfficherProjet", ex); }
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "AfficherAchat", ex); }
        }
        private void lvwPieces_KeyDown(object eventSender, KeyEventArgs eventArgs)
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "lvwPieces_KeyDown", ex); }
        }
        private void mvwDateRequise_DateClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtDateRequise.Text = ConvertDate(mvwDateRequise.SelectionStart);
                ((dynamic)mvwDateRequise).Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "mvwDateRequise_DateClick", ex); }
        }
        private void mvwReception_DateClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtDateReception.Text = ConvertDate(mvwReception.SelectionStart);
                ((dynamic)mvwReception).Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "mvwReception_DateClick", ex); }
        }
        private void ReceptionMec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ((dynamic)mvwReception).Visible = false;
                ((dynamic)mvwDateRequise).Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "Form_Click", ex); }
        }
        private void cmdDate_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDateReception.Text))
                {
                    mvwReception.SelectionStart = Conversions.ToDate(txtDateReception.Text);
                }
                else
                {
                    mvwReception.SelectionStart = DateTime.Today;
                } ((dynamic)mvwReception).Visible = true;
                ((dynamic)mvwReception).Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmdDate_Click", ex); }
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
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmbType_Click", ex); }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ImprimerReception();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "cmdImprimer_Click", ex); }
        }
        private void ImprimerReception()
        {
            try
            {
                Form f = new Form();
                if (m_eType == EnumType.ACHAT)
                {
                    f = new ChoixDateImpressionReception(txtNoProjet.Text, EnumCatalogue.MECANIQUE, EnumType.ACHAT);
                }
                else
                {
                    f = new ChoixDateImpressionReception(txtNoProjet.Text, EnumCatalogue.MECANIQUE, EnumType.TYPE_PROJET);
                }
                f.Icon = ActiveForm.Icon;
                f.Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "ImprimerReception", ex); }
        }
        [Obsolete]
        private void ReceptionMec_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (eventArgs.KeyCode == Keys.I)
                {
                    ImprimerReception();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ReceptionMec", "Form_KeyDown", ex); }
        }
    }
}