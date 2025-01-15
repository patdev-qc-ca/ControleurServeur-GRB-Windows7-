using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ADODB;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using Application = System.Windows.Forms.Application;
#pragma warning disable CS0414
namespace ControleurServeur
{
    internal class Facturation : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public Facturation() : base()
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
        internal System.Windows.Forms.Button cmd_export;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.GroupBox fraType;
        internal System.Windows.Forms.Button cmdVerrouiller;
        internal System.Windows.Forms.Button cmdSommaire;
        internal System.Windows.Forms.TextBox txtDateOuverture;
        internal System.Windows.Forms.Button cmdCommentaire;
        internal System.Windows.Forms.Button cmdModifier;
        internal System.Windows.Forms.Button cmdNCRectifier;
        internal System.Windows.Forms.Button cmdReouverture;
        internal System.Windows.Forms.Button cmdImprimer;
        internal System.Windows.Forms.TextBox txtRaisonFermeture;
        internal System.Windows.Forms.TextBox txtDateFermeture;
        internal System.Windows.Forms.TextBox txtClient;
        internal System.Windows.Forms.Button cmdSupprimer;
        internal System.Windows.Forms.GroupBox fraMontrer;
        internal System.Windows.Forms.Button cmdOuvrirProjSoum;
        internal System.Windows.Forms.Button cmdFermerProjSoum;
        internal ComboBox cmbProjSoum;
        internal System.Windows.Forms.Button cmdFacturerRectifier;
        internal ComboBox cmbNoProjSoum;
        internal ColumnHeader _lvwProjets_ColumnHeader_1;
        internal ColumnHeader _lvwProjets_ColumnHeader_2;
        internal ColumnHeader _lvwProjets_ColumnHeader_3;
        internal ColumnHeader _lvwProjets_ColumnHeader_4;
        internal ColumnHeader _lvwProjets_ColumnHeader_5;
        internal ColumnHeader _lvwProjets_ColumnHeader_6;
        internal ColumnHeader _lvwProjets_ColumnHeader_7;
        internal ColumnHeader _lvwProjets_ColumnHeader_8;
        internal ListView lvwProjets;
        internal System.Windows.Forms.Button cmdFermer;
        internal System.Windows.Forms.TextBox txtNoProjSoum;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblRaisonFermeture;
        internal System.Windows.Forms.Label lblDateFermeture;
        internal System.Windows.Forms.Label lblDateOuverture;
        internal System.Windows.Forms.Label lblClient;
        internal System.Windows.Forms.Label lblHeuresNonFacturees;
        internal System.Windows.Forms.Label lblHeuresFacturees;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblHeuresTotales;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lblTitreProjSoum;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        private ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox _optMontrer_2;
        private System.Windows.Forms.CheckBox _optMontrer_1;
        private System.Windows.Forms.CheckBox _optType_1;
        private System.Windows.Forms.CheckBox _optType_0;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ColumnHeader columnHeader2;
        private static int nbClientTrouvés = 0;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmd_export = new System.Windows.Forms.Button();
            txtDescription = new System.Windows.Forms.TextBox();
            fraType = new System.Windows.Forms.GroupBox();
            _optType_1 = new System.Windows.Forms.CheckBox();
            _optType_0 = new System.Windows.Forms.CheckBox();
            cmdVerrouiller = new System.Windows.Forms.Button();
            cmdSommaire = new System.Windows.Forms.Button();
            txtDateOuverture = new System.Windows.Forms.TextBox();
            cmdCommentaire = new System.Windows.Forms.Button();
            cmdModifier = new System.Windows.Forms.Button();
            cmdNCRectifier = new System.Windows.Forms.Button();
            cmdReouverture = new System.Windows.Forms.Button();
            cmdImprimer = new System.Windows.Forms.Button();
            txtRaisonFermeture = new System.Windows.Forms.TextBox();
            txtDateFermeture = new System.Windows.Forms.TextBox();
            txtClient = new System.Windows.Forms.TextBox();
            cmdSupprimer = new System.Windows.Forms.Button();
            fraMontrer = new System.Windows.Forms.GroupBox();
            _optMontrer_2 = new System.Windows.Forms.CheckBox();
            _optMontrer_1 = new System.Windows.Forms.CheckBox();
            cmdOuvrirProjSoum = new System.Windows.Forms.Button();
            cmdFermerProjSoum = new System.Windows.Forms.Button();
            cmbProjSoum = new System.Windows.Forms.ComboBox();
            cmdFacturerRectifier = new System.Windows.Forms.Button();
            cmbNoProjSoum = new System.Windows.Forms.ComboBox();
            lvwProjets = new System.Windows.Forms.ListView();
            _lvwProjets_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwProjets_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwProjets_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwProjets_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwProjets_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwProjets_ColumnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwProjets_ColumnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwProjets_ColumnHeader_8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdFermer = new System.Windows.Forms.Button();
            txtNoProjSoum = new System.Windows.Forms.TextBox();
            Label1 = new System.Windows.Forms.Label();
            lblRaisonFermeture = new System.Windows.Forms.Label();
            lblDateFermeture = new System.Windows.Forms.Label();
            lblDateOuverture = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblHeuresNonFacturees = new System.Windows.Forms.Label();
            lblHeuresFacturees = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            lblTitreProjSoum = new System.Windows.Forms.Label();
            lblHeuresTotales = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            fraType.SuspendLayout();
            fraMontrer.SuspendLayout();
            SuspendLayout();
            // 
            // cmd_export
            // 
            cmd_export.AutoSize = true;
            cmd_export.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmd_export.BackColor = System.Drawing.Color.Black;
            cmd_export.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmd_export.ForeColor = System.Drawing.Color.Blue;
            cmd_export.Location = new System.Drawing.Point(722, 741);
            cmd_export.Name = "cmd_export";
            cmd_export.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmd_export.Size = new System.Drawing.Size(112, 24);
            cmd_export.TabIndex = 39;
            cmd_export.Text = "Exporter vers Excel";
            cmd_export.UseVisualStyleBackColor = true;
            cmd_export.Click += new System.EventHandler(cmd_export_Click);
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = true;
            txtDescription.BackColor = System.Drawing.Color.Black;
            txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDescription.ForeColor = System.Drawing.Color.White;
            txtDescription.Location = new System.Drawing.Point(347, 78);
            txtDescription.MaxLength = 0;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDescription.Size = new System.Drawing.Size(516, 22);
            txtDescription.TabIndex = 37;
            // 
            // fraType
            // 
            fraType.BackColor = System.Drawing.Color.Black;
            fraType.Controls.Add(_optType_1);
            fraType.Controls.Add(_optType_0);
            fraType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraType.ForeColor = System.Drawing.Color.White;
            fraType.Location = new System.Drawing.Point(593, 4);
            fraType.Name = "fraType";
            fraType.Padding = new System.Windows.Forms.Padding(0);
            fraType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraType.Size = new System.Drawing.Size(204, 41);
            fraType.TabIndex = 33;
            fraType.TabStop = false;
            fraType.Text = "Type";
            // 
            // _optType_1
            // 
            _optType_1.AutoSize = true;
            _optType_1.Location = new System.Drawing.Point(104, 16);
            _optType_1.Name = "_optType_1";
            _optType_1.Size = new System.Drawing.Size(86, 18);
            _optType_1.TabIndex = 36;
            _optType_1.Text = "Mécanique";
            _optType_1.UseVisualStyleBackColor = true;
            _optType_1.CheckedChanged += new System.EventHandler(_optType_1_CheckedChanged);
            // 
            // _optType_0
            // 
            _optType_0.AutoSize = true;
            _optType_0.Location = new System.Drawing.Point(21, 16);
            _optType_0.Name = "_optType_0";
            _optType_0.Size = new System.Drawing.Size(81, 18);
            _optType_0.TabIndex = 35;
            _optType_0.Text = "Électrique";
            _optType_0.UseVisualStyleBackColor = true;
            _optType_0.CheckedChanged += new System.EventHandler(_optType_0_CheckedChanged);
            // 
            // cmdVerrouiller
            // 
            cmdVerrouiller.AutoSize = true;
            cmdVerrouiller.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdVerrouiller.BackColor = System.Drawing.Color.Black;
            cmdVerrouiller.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdVerrouiller.ForeColor = System.Drawing.Color.Blue;
            cmdVerrouiller.Location = new System.Drawing.Point(906, 741);
            cmdVerrouiller.Name = "cmdVerrouiller";
            cmdVerrouiller.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdVerrouiller.Size = new System.Drawing.Size(99, 24);
            cmdVerrouiller.TabIndex = 32;
            cmdVerrouiller.Text = "Verrouiller Soum";
            cmdVerrouiller.UseVisualStyleBackColor = true;
            cmdVerrouiller.Click += new System.EventHandler(cmdVerrouiller_Click);
            // 
            // cmdSommaire
            // 
            cmdSommaire.AutoSize = true;
            cmdSommaire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdSommaire.BackColor = System.Drawing.Color.Black;
            cmdSommaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdSommaire.ForeColor = System.Drawing.Color.Blue;
            cmdSommaire.Location = new System.Drawing.Point(1034, 741);
            cmdSommaire.Name = "cmdSommaire";
            cmdSommaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSommaire.Size = new System.Drawing.Size(68, 24);
            cmdSommaire.TabIndex = 31;
            cmdSommaire.Text = "Sommaire";
            cmdSommaire.UseVisualStyleBackColor = true;
            cmdSommaire.Click += new System.EventHandler(cmdSommaire_Click);
            // 
            // txtDateOuverture
            // 
            txtDateOuverture.AcceptsReturn = true;
            txtDateOuverture.BackColor = System.Drawing.Color.Black;
            txtDateOuverture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtDateOuverture.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDateOuverture.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDateOuverture.ForeColor = System.Drawing.Color.White;
            txtDateOuverture.Location = new System.Drawing.Point(142, 75);
            txtDateOuverture.MaxLength = 0;
            txtDateOuverture.Name = "txtDateOuverture";
            txtDateOuverture.ReadOnly = true;
            txtDateOuverture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDateOuverture.Size = new System.Drawing.Size(65, 22);
            txtDateOuverture.TabIndex = 30;
            // 
            // cmdCommentaire
            // 
            cmdCommentaire.AutoSize = true;
            cmdCommentaire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdCommentaire.BackColor = System.Drawing.Color.Black;
            cmdCommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdCommentaire.ForeColor = System.Drawing.Color.Blue;
            cmdCommentaire.Location = new System.Drawing.Point(154, 741);
            cmdCommentaire.Name = "cmdCommentaire";
            cmdCommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCommentaire.Size = new System.Drawing.Size(89, 24);
            cmdCommentaire.TabIndex = 29;
            cmdCommentaire.Text = "Commentaires";
            cmdCommentaire.UseVisualStyleBackColor = true;
            cmdCommentaire.Click += new System.EventHandler(cmdCommentaire_Click);
            // 
            // cmdModifier
            // 
            cmdModifier.AutoSize = true;
            cmdModifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdModifier.BackColor = System.Drawing.Color.Black;
            cmdModifier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdModifier.ForeColor = System.Drawing.Color.Blue;
            cmdModifier.Location = new System.Drawing.Point(390, 51);
            cmdModifier.Name = "cmdModifier";
            cmdModifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdModifier.Size = new System.Drawing.Size(59, 24);
            cmdModifier.TabIndex = 28;
            cmdModifier.Text = "Modifier";
            cmdModifier.UseVisualStyleBackColor = true;
            cmdModifier.Click += new System.EventHandler(cmdModifier_Click);
            // 
            // cmdNCRectifier
            // 
            cmdNCRectifier.AutoSize = true;
            cmdNCRectifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdNCRectifier.BackColor = System.Drawing.Color.Black;
            cmdNCRectifier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdNCRectifier.ForeColor = System.Drawing.Color.Blue;
            cmdNCRectifier.Location = new System.Drawing.Point(571, 741);
            cmdNCRectifier.Name = "cmdNCRectifier";
            cmdNCRectifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdNCRectifier.Size = new System.Drawing.Size(31, 24);
            cmdNCRectifier.TabIndex = 21;
            cmdNCRectifier.Text = "NC";
            cmdNCRectifier.UseVisualStyleBackColor = true;
            cmdNCRectifier.Click += new System.EventHandler(cmdNCRectifier_Click);
            // 
            // cmdReouverture
            // 
            cmdReouverture.AutoSize = true;
            cmdReouverture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdReouverture.BackColor = System.Drawing.Color.Black;
            cmdReouverture.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdReouverture.ForeColor = System.Drawing.Color.Blue;
            cmdReouverture.Location = new System.Drawing.Point(1145, 741);
            cmdReouverture.Name = "cmdReouverture";
            cmdReouverture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdReouverture.Size = new System.Drawing.Size(110, 24);
            cmdReouverture.TabIndex = 24;
            cmdReouverture.Text = "Annuler Fermeture";
            cmdReouverture.UseVisualStyleBackColor = true;
            cmdReouverture.Click += new System.EventHandler(cmdReouverture_Click);
            // 
            // cmdImprimer
            // 
            cmdImprimer.AutoSize = true;
            cmdImprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdImprimer.BackColor = System.Drawing.Color.Black;
            cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdImprimer.ForeColor = System.Drawing.Color.Blue;
            cmdImprimer.Location = new System.Drawing.Point(25, 741);
            cmdImprimer.Name = "cmdImprimer";
            cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdImprimer.Size = new System.Drawing.Size(63, 24);
            cmdImprimer.TabIndex = 16;
            cmdImprimer.Text = "Imprimer";
            cmdImprimer.UseVisualStyleBackColor = true;
            cmdImprimer.Click += new System.EventHandler(cmdImprimer_Click);
            // 
            // txtRaisonFermeture
            // 
            txtRaisonFermeture.AcceptsReturn = true;
            txtRaisonFermeture.BackColor = System.Drawing.Color.Black;
            txtRaisonFermeture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtRaisonFermeture.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtRaisonFermeture.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtRaisonFermeture.ForeColor = System.Drawing.Color.White;
            txtRaisonFermeture.Location = new System.Drawing.Point(345, 105);
            txtRaisonFermeture.MaxLength = 0;
            txtRaisonFermeture.Name = "txtRaisonFermeture";
            txtRaisonFermeture.ReadOnly = true;
            txtRaisonFermeture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtRaisonFermeture.Size = new System.Drawing.Size(518, 22);
            txtRaisonFermeture.TabIndex = 11;
            // 
            // txtDateFermeture
            // 
            txtDateFermeture.AcceptsReturn = true;
            txtDateFermeture.BackColor = System.Drawing.Color.Black;
            txtDateFermeture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtDateFermeture.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDateFermeture.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDateFermeture.ForeColor = System.Drawing.Color.White;
            txtDateFermeture.Location = new System.Drawing.Point(142, 99);
            txtDateFermeture.MaxLength = 0;
            txtDateFermeture.Name = "txtDateFermeture";
            txtDateFermeture.ReadOnly = true;
            txtDateFermeture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDateFermeture.Size = new System.Drawing.Size(65, 22);
            txtDateFermeture.TabIndex = 4;
            txtDateFermeture.TextChanged += new System.EventHandler(txtDateFermeture_TextChanged);
            // 
            // txtClient
            // 
            txtClient.AcceptsReturn = true;
            txtClient.BackColor = System.Drawing.Color.Black;
            txtClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtClient.ForeColor = System.Drawing.Color.White;
            txtClient.Location = new System.Drawing.Point(142, 51);
            txtClient.MaxLength = 0;
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtClient.Size = new System.Drawing.Size(241, 22);
            txtClient.TabIndex = 0;
            txtClient.TextChanged += new System.EventHandler(txtClient_TextChanged);
            // 
            // cmdSupprimer
            // 
            cmdSupprimer.AutoSize = true;
            cmdSupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdSupprimer.BackColor = System.Drawing.Color.Black;
            cmdSupprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdSupprimer.ForeColor = System.Drawing.Color.Blue;
            cmdSupprimer.Location = new System.Drawing.Point(427, 741);
            cmdSupprimer.Name = "cmdSupprimer";
            cmdSupprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSupprimer.Size = new System.Drawing.Size(68, 24);
            cmdSupprimer.TabIndex = 19;
            cmdSupprimer.Text = "Supprimer";
            cmdSupprimer.UseVisualStyleBackColor = true;
            cmdSupprimer.Click += new System.EventHandler(cmdsupprimer_Click);
            // 
            // fraMontrer
            // 
            fraMontrer.BackColor = System.Drawing.Color.Black;
            fraMontrer.Controls.Add(_optMontrer_2);
            fraMontrer.Controls.Add(_optMontrer_1);
            fraMontrer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraMontrer.ForeColor = System.Drawing.Color.White;
            fraMontrer.Location = new System.Drawing.Point(803, 4);
            fraMontrer.Name = "fraMontrer";
            fraMontrer.Padding = new System.Windows.Forms.Padding(0);
            fraMontrer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraMontrer.Size = new System.Drawing.Size(203, 41);
            fraMontrer.TabIndex = 5;
            fraMontrer.TabStop = false;
            fraMontrer.Text = "Soumissions";
            // 
            // _optMontrer_2
            // 
            _optMontrer_2.AutoSize = true;
            _optMontrer_2.Location = new System.Drawing.Point(102, 16);
            _optMontrer_2.Name = "_optMontrer_2";
            _optMontrer_2.Size = new System.Drawing.Size(76, 18);
            _optMontrer_2.TabIndex = 10;
            _optMontrer_2.Text = "Fermées";
            _optMontrer_2.UseVisualStyleBackColor = true;
            _optMontrer_2.CheckedChanged += new System.EventHandler(_optMontrer_2_CheckedChanged);
            // 
            // _optMontrer_1
            // 
            _optMontrer_1.AutoSize = true;
            _optMontrer_1.Location = new System.Drawing.Point(19, 16);
            _optMontrer_1.Name = "_optMontrer_1";
            _optMontrer_1.Size = new System.Drawing.Size(77, 18);
            _optMontrer_1.TabIndex = 9;
            _optMontrer_1.Text = "Ouvertes";
            _optMontrer_1.UseVisualStyleBackColor = true;
            _optMontrer_1.CheckedChanged += new System.EventHandler(_optMontrer_1_CheckedChanged);
            // 
            // cmdOuvrirProjSoum
            // 
            cmdOuvrirProjSoum.AutoSize = true;
            cmdOuvrirProjSoum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdOuvrirProjSoum.BackColor = System.Drawing.Color.Black;
            cmdOuvrirProjSoum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOuvrirProjSoum.ForeColor = System.Drawing.Color.Blue;
            cmdOuvrirProjSoum.Location = new System.Drawing.Point(339, 741);
            cmdOuvrirProjSoum.Name = "cmdOuvrirProjSoum";
            cmdOuvrirProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOuvrirProjSoum.Size = new System.Drawing.Size(79, 24);
            cmdOuvrirProjSoum.TabIndex = 18;
            cmdOuvrirProjSoum.Text = "Ouvrir Soum";
            cmdOuvrirProjSoum.UseVisualStyleBackColor = true;
            cmdOuvrirProjSoum.Click += new System.EventHandler(cmdOuvrirProjSoum_Click);
            // 
            // cmdFermerProjSoum
            // 
            cmdFermerProjSoum.AutoSize = true;
            cmdFermerProjSoum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdFermerProjSoum.BackColor = System.Drawing.Color.Black;
            cmdFermerProjSoum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermerProjSoum.ForeColor = System.Drawing.Color.Blue;
            cmdFermerProjSoum.Location = new System.Drawing.Point(249, 741);
            cmdFermerProjSoum.Name = "cmdFermerProjSoum";
            cmdFermerProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermerProjSoum.Size = new System.Drawing.Size(84, 24);
            cmdFermerProjSoum.TabIndex = 17;
            cmdFermerProjSoum.Text = "Fermer Soum";
            cmdFermerProjSoum.UseVisualStyleBackColor = true;
            cmdFermerProjSoum.Click += new System.EventHandler(cmdFermerProjSoum_Click);
            // 
            // cmbProjSoum
            // 
            cmbProjSoum.BackColor = System.Drawing.Color.Black;
            cmbProjSoum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProjSoum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbProjSoum.ForeColor = System.Drawing.Color.White;
            cmbProjSoum.Items.AddRange(new object[] {
            "Projet",
            "Soumission"});
            cmbProjSoum.Location = new System.Drawing.Point(249, 23);
            cmbProjSoum.Name = "cmbProjSoum";
            cmbProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbProjSoum.Size = new System.Drawing.Size(97, 22);
            cmbProjSoum.Sorted = true;
            cmbProjSoum.TabIndex = 12;
            cmbProjSoum.SelectedIndexChanged += new System.EventHandler(cmbProjSoum_SelectedIndexChanged);
            // 
            // cmdFacturerRectifier
            // 
            cmdFacturerRectifier.AutoSize = true;
            cmdFacturerRectifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdFacturerRectifier.BackColor = System.Drawing.Color.Black;
            cmdFacturerRectifier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFacturerRectifier.ForeColor = System.Drawing.Color.Blue;
            cmdFacturerRectifier.Location = new System.Drawing.Point(499, 741);
            cmdFacturerRectifier.Name = "cmdFacturerRectifier";
            cmdFacturerRectifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFacturerRectifier.Size = new System.Drawing.Size(58, 24);
            cmdFacturerRectifier.TabIndex = 20;
            cmdFacturerRectifier.Text = "Facturer";
            cmdFacturerRectifier.UseVisualStyleBackColor = true;
            cmdFacturerRectifier.Click += new System.EventHandler(cmdFacturerRectifier_Click);
            // 
            // cmbNoProjSoum
            // 
            cmbNoProjSoum.BackColor = System.Drawing.Color.Black;
            cmbNoProjSoum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbNoProjSoum.ForeColor = System.Drawing.Color.White;
            cmbNoProjSoum.Location = new System.Drawing.Point(452, 21);
            cmbNoProjSoum.Name = "cmbNoProjSoum";
            cmbNoProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbNoProjSoum.Size = new System.Drawing.Size(105, 22);
            cmbNoProjSoum.Sorted = true;
            cmbNoProjSoum.TabIndex = 14;
            cmbNoProjSoum.Text = "cmbNoProjSoum";
            cmbNoProjSoum.SelectedIndexChanged += new System.EventHandler(cmbNoProjSoum_SelectedIndexChanged);
            cmbNoProjSoum.KeyUp += new System.Windows.Forms.KeyEventHandler(cmbNoProjSoum_KeyUp);
            // 
            // lvwProjets
            // 
            lvwProjets.BackColor = System.Drawing.Color.Black;
            lvwProjets.CheckBoxes = true;
            lvwProjets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwProjets_ColumnHeader_1,
            _lvwProjets_ColumnHeader_2,
            _lvwProjets_ColumnHeader_3,
            _lvwProjets_ColumnHeader_4,
            _lvwProjets_ColumnHeader_5,
            _lvwProjets_ColumnHeader_6,
            _lvwProjets_ColumnHeader_7,
            _lvwProjets_ColumnHeader_8,
            columnHeader1,
            columnHeader2});
            lvwProjets.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwProjets.ForeColor = System.Drawing.Color.White;
            lvwProjets.FullRowSelect = true;
            lvwProjets.GridLines = true;
            lvwProjets.HideSelection = false;
            lvwProjets.Location = new System.Drawing.Point(5, 134);
            lvwProjets.Name = "lvwProjets";
            lvwProjets.Size = new System.Drawing.Size(1352, 583);
            lvwProjets.TabIndex = 15;
            lvwProjets.UseCompatibleStateImageBehavior = false;
            lvwProjets.View = System.Windows.Forms.View.Details;
            lvwProjets.Click += new System.EventHandler(lvwProjets_Click);
            // 
            // _lvwProjets_ColumnHeader_1
            // 
            _lvwProjets_ColumnHeader_1.Text = "Employé";
            _lvwProjets_ColumnHeader_1.Width = 107;
            // 
            // _lvwProjets_ColumnHeader_2
            // 
            _lvwProjets_ColumnHeader_2.Text = "Date";
            _lvwProjets_ColumnHeader_2.Width = 117;
            // 
            // _lvwProjets_ColumnHeader_3
            // 
            _lvwProjets_ColumnHeader_3.Text = "Début";
            _lvwProjets_ColumnHeader_3.Width = 73;
            // 
            // _lvwProjets_ColumnHeader_4
            // 
            _lvwProjets_ColumnHeader_4.Text = "Fin";
            _lvwProjets_ColumnHeader_4.Width = 73;
            // 
            // _lvwProjets_ColumnHeader_5
            // 
            _lvwProjets_ColumnHeader_5.Text = "Description";
            _lvwProjets_ColumnHeader_5.Width = 496;
            // 
            // _lvwProjets_ColumnHeader_6
            // 
            _lvwProjets_ColumnHeader_6.Text = "Total";
            _lvwProjets_ColumnHeader_6.Width = 83;
            // 
            // _lvwProjets_ColumnHeader_7
            // 
            _lvwProjets_ColumnHeader_7.Text = "No. Facture";
            _lvwProjets_ColumnHeader_7.Width = 120;
            // 
            // _lvwProjets_ColumnHeader_8
            // 
            _lvwProjets_ColumnHeader_8.Text = "Type";
            _lvwProjets_ColumnHeader_8.Width = 200;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            columnHeader1.Width = 77;
            // 
            // cmdFermer
            // 
            cmdFermer.AutoSize = true;
            cmdFermer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.Blue;
            cmdFermer.Location = new System.Drawing.Point(1304, 741);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(53, 24);
            cmdFermer.TabIndex = 25;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(Cmdfermer_Click);
            // 
            // txtNoProjSoum
            // 
            txtNoProjSoum.AcceptsReturn = true;
            txtNoProjSoum.BackColor = System.Drawing.Color.Black;
            txtNoProjSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoProjSoum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNoProjSoum.ForeColor = System.Drawing.Color.White;
            txtNoProjSoum.Location = new System.Drawing.Point(452, 21);
            txtNoProjSoum.MaxLength = 0;
            txtNoProjSoum.Name = "txtNoProjSoum";
            txtNoProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoProjSoum.Size = new System.Drawing.Size(88, 22);
            txtNoProjSoum.TabIndex = 13;
            txtNoProjSoum.Text = "Text1";
            txtNoProjSoum.Visible = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(270, 82);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(69, 14);
            Label1.TabIndex = 38;
            Label1.Text = "Description :";
            // 
            // lblRaisonFermeture
            // 
            lblRaisonFermeture.AutoSize = true;
            lblRaisonFermeture.BackColor = System.Drawing.Color.Black;
            lblRaisonFermeture.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRaisonFermeture.ForeColor = System.Drawing.Color.White;
            lblRaisonFermeture.Location = new System.Drawing.Point(213, 107);
            lblRaisonFermeture.Name = "lblRaisonFermeture";
            lblRaisonFermeture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblRaisonFermeture.Size = new System.Drawing.Size(126, 14);
            lblRaisonFermeture.TabIndex = 9;
            lblRaisonFermeture.Text = "Raison de la fermeture :";
            // 
            // lblDateFermeture
            // 
            lblDateFermeture.AutoSize = true;
            lblDateFermeture.BackColor = System.Drawing.Color.Black;
            lblDateFermeture.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateFermeture.ForeColor = System.Drawing.Color.White;
            lblDateFermeture.Location = new System.Drawing.Point(30, 107);
            lblDateFermeture.Name = "lblDateFermeture";
            lblDateFermeture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateFermeture.Size = new System.Drawing.Size(108, 14);
            lblDateFermeture.TabIndex = 3;
            lblDateFermeture.Text = "Date de fermeture : ";
            lblDateFermeture.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDateOuverture
            // 
            lblDateOuverture.AutoSize = true;
            lblDateOuverture.BackColor = System.Drawing.Color.Black;
            lblDateOuverture.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateOuverture.ForeColor = System.Drawing.Color.White;
            lblDateOuverture.Location = new System.Drawing.Point(44, 82);
            lblDateOuverture.Name = "lblDateOuverture";
            lblDateOuverture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateOuverture.Size = new System.Drawing.Size(100, 14);
            lblDateOuverture.TabIndex = 2;
            lblDateOuverture.Text = "Date d\'ouverture : ";
            lblDateOuverture.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = System.Drawing.Color.Black;
            lblClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClient.ForeColor = System.Drawing.Color.White;
            lblClient.Location = new System.Drawing.Point(92, 56);
            lblClient.Name = "lblClient";
            lblClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblClient.Size = new System.Drawing.Size(44, 14);
            lblClient.TabIndex = 1;
            lblClient.Text = "Client : ";
            lblClient.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeuresNonFacturees
            // 
            lblHeuresNonFacturees.BackColor = System.Drawing.Color.Black;
            lblHeuresNonFacturees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblHeuresNonFacturees.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresNonFacturees.ForeColor = System.Drawing.Color.Lime;
            lblHeuresNonFacturees.Location = new System.Drawing.Point(1145, 83);
            lblHeuresNonFacturees.Name = "lblHeuresNonFacturees";
            lblHeuresNonFacturees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblHeuresNonFacturees.Size = new System.Drawing.Size(57, 17);
            lblHeuresNonFacturees.TabIndex = 27;
            // 
            // lblHeuresFacturees
            // 
            lblHeuresFacturees.BackColor = System.Drawing.Color.Black;
            lblHeuresFacturees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblHeuresFacturees.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresFacturees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            lblHeuresFacturees.Location = new System.Drawing.Point(1145, 62);
            lblHeuresFacturees.Name = "lblHeuresFacturees";
            lblHeuresFacturees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblHeuresFacturees.Size = new System.Drawing.Size(57, 17);
            lblHeuresFacturees.TabIndex = 23;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(1025, 82);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(118, 14);
            Label3.TabIndex = 26;
            Label3.Text = "Heures non facturées :";
            Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(1025, 63);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(97, 14);
            Label2.TabIndex = 22;
            Label2.Text = "Heures facturées :";
            Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitreProjSoum
            // 
            lblTitreProjSoum.AutoSize = true;
            lblTitreProjSoum.BackColor = System.Drawing.Color.Black;
            lblTitreProjSoum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum.ForeColor = System.Drawing.Color.White;
            lblTitreProjSoum.Location = new System.Drawing.Point(349, 26);
            lblTitreProjSoum.Name = "lblTitreProjSoum";
            lblTitreProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTitreProjSoum.Size = new System.Drawing.Size(100, 14);
            lblTitreProjSoum.TabIndex = 10;
            lblTitreProjSoum.Text = "Numéro de projet :";
            // 
            // lblHeuresTotales
            // 
            lblHeuresTotales.BackColor = System.Drawing.Color.Black;
            lblHeuresTotales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblHeuresTotales.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            lblHeuresTotales.Location = new System.Drawing.Point(1145, 32);
            lblHeuresTotales.Name = "lblHeuresTotales";
            lblHeuresTotales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblHeuresTotales.Size = new System.Drawing.Size(57, 17);
            lblHeuresTotales.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Black;
            label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(1025, 33);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label5.Size = new System.Drawing.Size(85, 14);
            label5.TabIndex = 40;
            label5.Text = "Heures totales :";
            label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Black;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            label4.Location = new System.Drawing.Point(1205, 32);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label4.Size = new System.Drawing.Size(57, 17);
            label4.TabIndex = 44;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Black;
            label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.Lime;
            label6.Location = new System.Drawing.Point(1205, 83);
            label6.Name = "label6";
            label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label6.Size = new System.Drawing.Size(57, 17);
            label6.TabIndex = 43;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Black;
            label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            label7.Location = new System.Drawing.Point(1205, 62);
            label7.Name = "label7";
            label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label7.Size = new System.Drawing.Size(57, 17);
            label7.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Black;
            label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(1202, 14);
            label8.Name = "label8";
            label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label8.Size = new System.Drawing.Size(56, 14);
            label8.TabIndex = 45;
            label8.Text = "Électricité";
            label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Black;
            label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(1262, 14);
            label9.Name = "label9";
            label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label9.Size = new System.Drawing.Size(61, 14);
            label9.TabIndex = 49;
            label9.Text = "Mécanique";
            label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.BackColor = System.Drawing.Color.Black;
            label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            label10.Location = new System.Drawing.Point(1265, 32);
            label10.Name = "label10";
            label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label10.Size = new System.Drawing.Size(57, 17);
            label10.TabIndex = 48;
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.Black;
            label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.Color.Lime;
            label11.Location = new System.Drawing.Point(1265, 83);
            label11.Name = "label11";
            label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label11.Size = new System.Drawing.Size(57, 17);
            label11.TabIndex = 47;
            // 
            // label12
            // 
            label12.BackColor = System.Drawing.Color.Black;
            label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            label12.Location = new System.Drawing.Point(1265, 62);
            label12.Name = "label12";
            label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label12.Size = new System.Drawing.Size(57, 17);
            label12.TabIndex = 46;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Black;
            label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.ForeColor = System.Drawing.Color.White;
            label13.Location = new System.Drawing.Point(210, 26);
            label13.Name = "label13";
            label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label13.Size = new System.Drawing.Size(34, 14);
            label13.TabIndex = 50;
            label13.Text = "Type:";
            label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.ForeColor = System.Drawing.Color.Blue;
            button1.Location = new System.Drawing.Point(870, 73);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(102, 23);
            button1.TabIndex = 51;
            button1.Text = "Mettre à jour";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(txtDescription_TextChanged);
            // 
            // button2
            // 
            button2.ForeColor = System.Drawing.Color.Blue;
            button2.Location = new System.Drawing.Point(869, 104);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(102, 23);
            button2.TabIndex = 52;
            button2.Text = "Mettre à jour";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(txtRaisonFermeture_TextChanged);
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ordre";
            // 
            // Facturation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1369, 777);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(lblHeuresTotales);
            Controls.Add(label5);
            Controls.Add(cmd_export);
            Controls.Add(txtDescription);
            Controls.Add(fraType);
            Controls.Add(cmdVerrouiller);
            Controls.Add(cmdSommaire);
            Controls.Add(txtDateOuverture);
            Controls.Add(cmdCommentaire);
            Controls.Add(cmdModifier);
            Controls.Add(cmdNCRectifier);
            Controls.Add(cmdReouverture);
            Controls.Add(cmdImprimer);
            Controls.Add(txtRaisonFermeture);
            Controls.Add(txtDateFermeture);
            Controls.Add(txtClient);
            Controls.Add(cmdSupprimer);
            Controls.Add(fraMontrer);
            Controls.Add(cmdOuvrirProjSoum);
            Controls.Add(cmdFermerProjSoum);
            Controls.Add(cmbProjSoum);
            Controls.Add(cmdFacturerRectifier);
            Controls.Add(cmbNoProjSoum);
            Controls.Add(lvwProjets);
            Controls.Add(cmdFermer);
            Controls.Add(txtNoProjSoum);
            Controls.Add(Label1);
            Controls.Add(lblRaisonFermeture);
            Controls.Add(lblDateFermeture);
            Controls.Add(lblDateOuverture);
            Controls.Add(lblClient);
            Controls.Add(lblHeuresNonFacturees);
            Controls.Add(lblHeuresFacturees);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(lblTitreProjSoum);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            Location = new System.Drawing.Point(3, 22);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Facturation";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ContrôleurWebAutoGRB.Facturation";
            Load += new System.EventHandler(Facturation_Load);
            fraType.ResumeLayout(false);
            fraType.PerformLayout();
            fraMontrer.ResumeLayout(false);
            fraMontrer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        private Microsoft.Office.Interop.Excel.Application m_xlsApp;
        // Index des colonnes du listview
        private const int I_LVW_EMPLOYE = 0;
        private const int I_LVW_DATE = 1;
        private const int I_LVW_DEBUT = 2;
        private const int I_LVW_FIN = 3;
        private const int I_LVW_DESCRIPTION = 4;
        private const int I_LVW_TOTAL = 5;
        private const int I_LVW_NO_FACTURE = 6;
        private const int I_LVW_TYPE = 7;
        // Index de optType
        private const int I_OPT_TYPE_ELECTRIQUE = 0;
        private const int I_OPT_TYPE_MECANIQUE = 1;
        private const int I_OPT_TYPE_TOUS = 2;
        // Index du combo
        private const int I_CMB_PROJET = 0;
        private const int I_CMB_SOUMISSION = 1;
        // Caption du bouton cmdFacturerRectifier
        private const string S_FACTURER = "Facturer";
        private const string S_RECTIFIER = "Rectifier";
        private const string S_NC = "NC";
        // Caption des Option Buttons
        // Si c'est un projet
        private const string S_PROJ_OUVERT = "Ouverts";
        private const string S_PROJ_FERME = "Fermés";
        private const string S_PROJ_TOUS = "Tous";
        // Si c'est une soumission
        private const string S_SOUM_OUVERT = "Ouvertes";
        private const string S_SOUM_FERME = "Fermées";
        private const string S_SOUM_TOUS = "Toutes";
        // Caption de fraMontrer
        private const string S_FRA_PROJ = "Projets";
        private const string S_FRA_SOUM = "Soumissions";
        // Index des Option Buttons
        private const int I_OPT_TOUS = 0;
        private const int I_OPT_OUVERT = 1;
        private const int I_OPT_FERME = 2;
        private enum enumType
        {
            TYPE_PROJET = 0,
            TYPE_SOUMISSION = 1
        }
        private enumType m_eType;
        public int m_iIDClient;
        public string m_sDescription;
        internal static bool m_bModifClient;
        private bool m_bLoading;
        internal static string IDClient;
        public static string Description { get; internal set; }
        //cmbNoProjSoum.SelectedIndexChanged//
        private void cmbNoProjSoum_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                rstProjSoum = new Recordset();
                txtNoProjSoum.Text = cmbNoProjSoum.Text;
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum like '%" + Droite(txtNoProjSoum.Text,8) + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["Ouvert"].Value, true, false)))
                {
                    cmdFermerProjSoum.Enabled = true;
                }
                else
                {
                    cmdFermerProjSoum.Enabled = false;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["Verrouillé"].Value, true, false)))
                {
                    if (m_eType == enumType.TYPE_SOUMISSION)
                    {
                        cmdVerrouiller.Text = "Déverrouiller Soum";
                    }
                    else
                    {
                        cmdVerrouiller.Text = "Déverrouiller Proj";
                    }
                }
                else if (m_eType == enumType.TYPE_SOUMISSION)
                {
                    cmdVerrouiller.Text = "Verrouiller Soum";
                }
                else
                {
                    cmdVerrouiller.Text = "Verrouiller Proj";
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                AfficherProjSoum();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmbNoProjSoum_Click", ex);
            }
        }
        [Obsolete]
        private void cmbNoProjSoum_KeyUp(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                for (int X = 0; X <= (cmbNoProjSoum.Items.Count - 1); X++)
                {
                    if ((cmbNoProjSoum.Items[X].ToString().ToUpper() ?? "") == (cmbNoProjSoum.Text.ToUpper() ?? ""))
                    {
                        cmbNoProjSoum.SelectedIndex = X;
                        break;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmbProjSoum_KeyUp", ex);
            }
        }
        private void AfficherProjSoum()
        {
            label6.Text = "0";
            label7.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            lblHeuresFacturees.Text = "0";
            lblHeuresNonFacturees.Text = "0";
            lblHeuresTotales.Text = "0";
            double heureFact = 0;
            double heureFactE = 0;
            double heureFactM = 0;
            double heureNonFact = 0;
            double heureNonFactE = 0;
            double heureNonFactM = 0;
            try
            {
                ADODB.Recordset rstProjSoum = new ADODB.Recordset();
                ADODB.Recordset rstClient = new ADODB.Recordset();
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum like '%" +Droite( txtNoProjSoum.Text,8) + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstClient.Open(Operators.ConcatenateObject("SELECT NomClient FROM Client WHERE IDClient = ", rstProjSoum.Fields["NoClient"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstClient.EOF)
                {
                    txtClient.Text = (string)(rstClient.Fields["NomClient"].Value);
                    txtClient.Tag = (int)rstProjSoum.Fields["NoClient"].Value;
                }
                rstClient.Close();
                rstClient = null;
                if (!(rstProjSoum.Fields["DateOuverture"].Value is DBNull))
                {
                    txtDateOuverture.Text = (string)(rstProjSoum.Fields["DateOuverture"].Value);
                }
                else
                {
                    txtDateOuverture.Text = string.Empty;
                }
                if (_optMontrer_1.Checked == true | _optMontrer_2.Checked == true)
                {
                    if (!(rstProjSoum.Fields["DateFermeture"].Value is DBNull))
                    {
                        txtDateFermeture.Text = (string)(rstProjSoum.Fields["DateFermeture"].Value);
                    }
                    else
                    {
                        txtDateFermeture.Text = string.Empty;
                    }
                    if (!(rstProjSoum.Fields["RaisonFermeture"].Value is DBNull))
                    {
                        txtRaisonFermeture.Text = (string)(rstProjSoum.Fields["RaisonFermeture"].Value);
                    }
                    else
                    {
                        txtRaisonFermeture.Text = string.Empty;
                    }
                }
                if (!(rstProjSoum.Fields["Description"].Value is DBNull))
                {
                    txtDescription.Text = (string)(rstProjSoum.Fields["Description"].Value);
                }
                else
                {
                    txtDescription.Text = string.Empty;
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                try
                {
                    SqlConnection sq = new SqlConnection(StringSQL);
                    sq.Open();
                    double temps = 0d;
                    if (cmbNoProjSoum.SelectedIndex != -1)
                    {
                        lvwProjets.Items.Clear();
                        SqlDataReader rd = new SqlCommand($"SELECT PUNCH.*,DATEDIFF(MINUTE,HEUREDÉBUT,HEUREFIN) AS 'TOTAL',EMPLOYÉS.INITIALE FROM EMPLOYÉS " +
                            $"INNER JOIN PUNCH ON EMPLOYÉS.NOEMPLOYE = PUNCH.NOEMPLOYE " +
                            $"WHERE NOPROJET LIKE '%{Droite(cmbNoProjSoum.Text,8)}' ORDER BY[DATE], HEUREDÉBUT, HEUREFIN" , sq).ExecuteReader();
                        while (rd.Read())
                        {
                            ListViewItem it =lvwProjets.Items.Add(string.Empty);
                            it.SubItems.Insert(0x00, new ListViewItem.ListViewSubItem(null, rd["initiale"].ToString()));
                            it.SubItems.Insert(0x01, new ListViewItem.ListViewSubItem(null, rd["Date"].ToString()));
                            it.SubItems.Insert(0x02, new ListViewItem.ListViewSubItem(null, rd["HeureDébut"].ToString()));
                            ///Évite le plantage si heurefin ==DBNull
                            if (rd["HeureDébut"].ToString() != string.Empty)
                            {
                                int deb = (int.Parse(rd["HeureDébut"].ToString().Split(':')[0]) * 60) + int.Parse(rd["HeureDébut"].ToString().Split(':')[1]);
                                it.SubItems.Insert(0x03, new ListViewItem.ListViewSubItem(null, rd["HeureFin"].ToString()));
                                if (rd["HeureFin"].ToString() != string.Empty)
                                {
                                    int fin = (int.Parse(rd["HeureFin"].ToString().Split(':')[0]) * 60) + int.Parse(rd["HeureFin"].ToString().Split(':')[1]);
                                    temps += (fin - deb);
                                    lblHeuresTotales.Text = Math.Round(temps/60,2).ToString();
                                }
                            }
                            it.SubItems.Insert(0x04, new ListViewItem.ListViewSubItem(null, rd["Commentaire"].ToString()));
                            it.SubItems.Insert(0x05, new ListViewItem.ListViewSubItem(null, Math.Round((double.Parse(rd["total"].ToString()) / 60), 2).ToString()));
                            it.SubItems.Insert(0x06, new ListViewItem.ListViewSubItem(null, rd["NoFacture"].ToString()));
                            it.SubItems.Insert(0x07, new ListViewItem.ListViewSubItem(null, rd["type"].ToString()));
                            it.SubItems.Insert(0x08, new ListViewItem.ListViewSubItem(null, Droite(rd["NoProjet"].ToString(), 1).ToUpper()+rd["IDPunch"].ToString()));
                            it.SubItems.Insert(0x09, new ListViewItem.ListViewSubItem(null, rd["NoProjet"].ToString().Substring(0,1)));
                            if(rd["NoProjet"].ToString().Substring(0, 1).ToUpper() == "E"){ 
                                it.ForeColor = Color.Yellow; 
                            }
                            if((bool)rd["Facturé"] ==true) { 
                                it.ForeColor = Color.Red;
                                heureFact =double.Parse(lblHeuresFacturees.Text)+ (double.Parse(rd["total"].ToString()) / 60);
                                if (it.ForeColor == Color.Yellow)
                                {
                                    heureFactE=double.Parse(label7.Text)+(double.Parse(rd["total"].ToString()) / 60);
                                }
                                else
                                {
                                    heureFactM= double.Parse(label12.Text) + (double.Parse(rd["total"].ToString()) / 60);
                                }
                            }
                            else
                            {
                                heureFact = double.Parse(lblHeuresFacturees.Text) + (double.Parse(rd["total"].ToString()) / 60);
                                if (it.ForeColor == Color.Yellow)
                                {
                                    heureNonFactE = double.Parse(label6.Text) + (double.Parse(rd["total"].ToString()) / 60);
                                }
                                else
                                {
                                    heureNonFactM = double.Parse(label11.Text) + (double.Parse(rd["total"].ToString()) / 60);
                                }

                            }
                            label12.Text = heureFactM.ToString();
                            label7.Text = heureFactE.ToString();
                            label6.Text = heureNonFactE.ToString();
                            Label1.Text = heureNonFactM.ToString();
                        }
                        rd.Close();
                    }
                    sq.Close();
                }
                catch (Exception ex)
                {
                    AfficherErreur("Facturation", "RemplirListView", ex);
                }
                //         RemplirListView();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "AfficherProjSoum", ex);
            }
        }
        [Obsolete]
        private void cmd_export_Click(object eventSender, EventArgs eventArgs)
        {
            int iCount;
            Microsoft.Office.Interop.Excel.Application oXLApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oXLBook = oXLApp.Workbooks.Add(string.Empty);
            Microsoft.Office.Interop.Excel.Worksheet oXLSheet = oXLBook.Worksheets[1];
            oXLApp.Visible = true;
            oXLSheet.Range["A1: G1"].Font.Bold = true;
            oXLSheet.Range["A:G"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            oXLSheet.Range["A1: G1"].Value = new object[] { "Employé", "Date", "Debut", "Fin", "Description", "Total", "Type" };
            for (int X = 0; X < lvwProjets.Items.Count; X++)
            {
                oXLSheet.Range["A:G"].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                oXLSheet.Range[$"A{X + 2}: G{X + 2}"].Value = new object[]
                {
                    lvwProjets.Items[X].Text,
                    lvwProjets.Items[X].SubItems[1].Text,
                    lvwProjets.Items[X].SubItems[2].Text,
                    lvwProjets.Items[X].SubItems[3].Text,
                    lvwProjets.Items[X].SubItems[4].Text,
                    float.Parse(lvwProjets.Items[X].SubItems[5].Text),
                    lvwProjets.Items[X].SubItems[7].Text
                };
            }
            //patch pour eviter l'erreur existe deja
            oXLBook.SaveAs(Filename: $"{RootExcel}{GenererNomFichierByDateTime($"Facturation_{cmbNoProjSoum.Text}_{txtClient.Text}",TypeFormatSortieFichier.ID_EXCEL_XLSX)}");
            //            oXLApp.Application.Quit();
        }
        private void cmdCommentaire_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new CommentairesProjSoum();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Text = cmbNoProjSoum.Text;
                if (cmbProjSoum.SelectedIndex == I_CMB_PROJET)
                {
                    f.ShowDialog();
                }
                else
                {
                    f.Show();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdCommentaire_Click", ex);
            }
        }
        private void cmdFacturerRectifier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sNoFacture;
                ADODB.Recordset rstFacture;
                string sWhere;
                int X;
                if ((cmdFacturerRectifier.Text ?? "") == S_FACTURER)
                {
                    sNoFacture = Interaction.InputBox("Entrez le numéro de la facture");
                    if (!string.IsNullOrEmpty(sNoFacture))
                    {
                        if (!IsNumeric(sNoFacture))
                        {
                            MessageBox.Show("Le numéro de facture est invalide", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        ListViewItem item = lvwProjets.FocusedItem;
                        if (item.Checked == false) item.Checked=true;
                        MessageBox.Show(item.SubItems[8].Name + "=" + item.SubItems[8].Text);
                        rstFacture = new Recordset();
                        rstFacture.Open($"SELECT * FROM Punch WHERE IDPunch ={item.SubItems[0x08].Text}" , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        Clipboard.SetText(rstFacture.Source);
                        while (!rstFacture.EOF)
                        {
                            rstFacture.Fields["Facturé"].Value = true; 
                            rstFacture.Fields["NoFacture"].Value = sNoFacture;
                            rstFacture.Update();
                            rstFacture.MoveNext();
                        }
                        rstFacture.Close(); 
                        rstFacture = null;
//                        RemplirListView((int)lvwProjets.FocusedItem.Index);
                    }
                }
                else
                {
                    ListViewItem item = lvwProjets.FocusedItem;
                    rstFacture = new Recordset();
                    rstFacture.Open("SELECT Facturé, NoFacture FROM Punch WHERE IDPunch="+item.SubItems[0x08].Text, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstFacture.EOF)
                    {
                        rstFacture.Fields["Facturé"].Value = false; 
                        rstFacture.Fields["NoFacture"].Value = Interaction.InputBox(item.SubItems[0x08].Text + " affiche "+ item.SubItems[0x06].Text,Application.ProductName+"."+Name+".Rectification",item.SubItems[0x06].Text,-1,-1);
                        rstFacture.Update();
                        item.Checked = true;
                        item.SubItems[6].BackColor = Color.DarkBlue;
                        item.SubItems[6].ForeColor = Color.AliceBlue;
                        rstFacture.MoveNext();
                    }
                    rstFacture.Close();
                    rstFacture = null;
    //                RemplirListView((int)lvwProjets.FocusedItem.Index);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdFacturerRectifier_Click", ex);
            }
        }
        private void cmdModifier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstProjSoum;
                if (PeutModifier() == true)
                {
                    m_bModifClient = true;
                    Form a1 = new ChoixClient();
                    a1.MdiParent = this;
                    a1.Show();
                    m_bModifClient = false;
                    if (m_iIDClient != GetClientID(txtClient.Text))
                    {
                        rstProjSoum = new Recordset(); rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstProjSoum.Fields["NoClient"].Value = m_iIDClient; rstProjSoum.Fields["Description"].Value = m_sDescription;
                        rstProjSoum.Update();
                        rstProjSoum.Close();
                        rstProjSoum = null;
                        rstPunch = new Recordset();
                        rstPunch.Open("SELECT * FROM Punch WHERE NoProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstPunch.EOF)
                        {
                            if (MessageBox.Show("Voulez-vous modifier tous les punch ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                while (!rstPunch.EOF)
                                {
                                    rstPunch.Fields["NoClient"].Value = m_iIDClient;
                                    rstPunch.Update();
                                    rstPunch.MoveNext();
                                }
                            }
                        }
                        rstPunch.Close();
                        rstPunch = null;
                        AfficherProjSoum();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdModifier_Click", ex);
            }
        }
        private bool PeutModifier()
        {
            bool PeutModifierRet = default;
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstSoumission;
                bool bPeutModifier;
                rstProjSoum = new Recordset();
                rstProjSoum.Open("SELECT Ouvert, Type FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["Ouvert"].Value, true, false)))
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["Type"].Value, "P", false)))
                    {
                        rstProjet = new Recordset();
                        rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        if (rstProjet.EOF)
                        {
                            rstProjet.Close();
                            rstProjet.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                            if (rstProjet.EOF) { bPeutModifier = true; }
                            else
                            {
                                MessageBox.Show("Le client doit être modifié dans l'écran  mécaniques!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bPeutModifier = false;
                            }
                            rstProjet.Close();
                        }
                        else
                        {
                            MessageBox.Show("Le client doit être modifié dans l'écran  électriques!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rstProjet.Close();
                            bPeutModifier = false;
                        }
                        rstProjet = null;
                    }
                    else
                    {
                        rstSoumission = new Recordset();
                        rstSoumission.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        if (rstSoumission.EOF)
                        {
                            rstSoumission.Close();
                            rstSoumission.Open("SELECT * FROM SoumissionMec WHERE IDSoumission = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                            if (rstSoumission.EOF) { bPeutModifier = true; }
                            else
                            {
                                MessageBox.Show("Le client doit être modifié dans l'écran des soumissions mécaniques!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bPeutModifier = false;
                            }
                            rstSoumission.Close();
                        }
                        else
                        {
                            MessageBox.Show("Le client doit être modifié dans l'écran des soumissions électriques!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rstSoumission.Close();
                            bPeutModifier = false;
                        }
                        rstSoumission = null;
                    }
                }
                else
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["Type"].Value, "P", false)))
                    {
                        MessageBox.Show("Ce projet est fermé!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cette soumission est fermée!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    bPeutModifier = false;
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                PeutModifierRet = bPeutModifier;
                return PeutModifierRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "PeutModifier", ex);
                return false;
            }
        }
        private void cmdNCRectifier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstFacture;
                if ((cmdNCRectifier.Text ?? "") == S_NC)
                {
                    ListViewItem item = lvwProjets.FocusedItem;
                    rstFacture = new Recordset();
                    rstFacture.Open("SELECT * FROM Punch WHERE idPunch =" + item.SubItems[8].Text, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstFacture.EOF)
                    {
                        rstFacture.Fields["Facturé"].Value = true; 
                        rstFacture.Fields["NoFacture"].Value = "NC";
                        rstFacture.Update();
                        rstFacture.MoveNext();
                    }
                    rstFacture.Close();
                    rstFacture = null;
                    RemplirListView((int)lvwProjets.FocusedItem.Index);
                }
                else
                {
                    ListViewItem item = lvwProjets.FocusedItem;
                    rstFacture = new Recordset();
                    rstFacture.Open("SELECT * FROM Punch WHERE IDPunch =" + item.SubItems[8].Text, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstFacture.EOF)
                    {
                        rstFacture.Fields["Facturé"].Value = false; 
                        rstFacture.Fields["NoFacture"].Value = string.Empty; 
                        rstFacture.Update(); 
                        rstFacture.MoveNext();
                    }
                    rstFacture.Close();
                    rstFacture = null;
                    RemplirListView((int)lvwProjets.FocusedItem.Index);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdFacturerRectifier_Click", ex);
            }
        }
        private void Cmdfermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdFermer_Click", ex);
            }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new ChoixDateImpressionFacturation();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                if (m_eType == enumType.TYPE_PROJET)
                {
                    f.Text = $"{txtNoProjSoum.Text} [{txtClient.Text}]";
                }
                else
                {
                    f.Text = $"{txtNoProjSoum.Text} [{txtClient.Text}]";
                }
                f.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdImprimer_Click", ex);
            }
        }
        [Obsolete] ///c'est plus Excel 2000
/* while (!(r <= lvwProjets.Items.Count == null))
{
data_array[r, 1] = lvwProjets.Items[r].Text;
data_array[r, 2] = lvwProjets.Items[r].SubItems[1].Text;
data_array[r, 3] = lvwProjets.Items[r].SubItems[2].Text;
data_array[r, 4] = lvwProjets.Items[r].SubItems[3].Text;
data_array[r, 5] = lvwProjets.Items[r].SubItems[4].Text; 
// Ajouter la description a la table excel 2017-06-26 GLL
data_array[r, 6] = double.Parse(lvwProjets.Items[r].SubItems[5].Text);
data_array[r, 7] = lvwProjets.Items[r].SubItems[7].Text; 
// Ajouter pour avoir le tableau complet en Excel
r = (int)(r + 1);
}*/
        /// Exporter Punch vers excel
        private void Punch2Excel()
        {
            Microsoft.Office.Interop.Excel.Application oXLApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oXLBook = oXLApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet oXLSheet = (Microsoft.Office.Interop.Excel.Worksheet)oXLBook.Worksheets[1];
            oXLApp.Visible = false;
            oXLSheet.get_Range("A1: G1").Font.Bold = true;
            oXLSheet.get_Range("A:G").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            oXLSheet.get_Range("A1: G1").set_Value(value: new object[] { "Employé", "Date", "Debut", "Fin", "Description", "Total", "Type" });//GLL                                                                                                               //         oXLSheet.get_Range("A2").get_Resize(r, 7).set_Value(data_array);
            oXLSheet.get_Range("A:G").Columns.AutoFit();
            oXLSheet.Name =$"Punch_Projet_{Droite(cmbNoProjSoum.Text,8)} ";
            for (int X = 0; X < lvwProjets.Items.Count; X++)
            {
                oXLSheet.Range["A:G"].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                oXLSheet.Range[$"A{X + 2}: G{X + 2}"].Value = new object[]
                {
                    lvwProjets.Items[X].Text,
                    lvwProjets.Items[X].SubItems[1].Text,
                    lvwProjets.Items[X].SubItems[2].Text,
                    lvwProjets.Items[X].SubItems[3].Text,
                    lvwProjets.Items[X].SubItems[4].Text,
                    float.Parse(lvwProjets.Items[X].SubItems[5].Text),
                    lvwProjets.Items[X].SubItems[7].Text
                };
            }
            oXLApp.Visible = true;
        }
        private void cmdOuvrirProjSoum_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sNumero;
                ADODB.Recordset rstProjSoum;
                var sQuestion = default(string);
                var sType = default(string);
                bool bNoValide;
                switch (m_eType)
                {
                    case enumType.TYPE_PROJET: { sQuestion = "Quel est le numéro du projet?"; sType = "P"; break; }
                    case enumType.TYPE_SOUMISSION: { sQuestion = "Quel est le numéro de la soumission?"; sType = "S"; break; }
                }
                sNumero = Interaction.InputBox(sQuestion);
                if (!string.IsNullOrEmpty(sNumero))
                {
                    bNoValide = true;
                    if (ValiderFormatNumeroProjSoum(sNumero) == false)
                    {
                        bNoValide = false;
                    }
                    if (bNoValide == true)
                    {
                        if (m_eType == enumType.TYPE_PROJET) { if (ValiderFormatProjet(sNumero) == false) { bNoValide = false; } } else if (ValiderFormatSoumission(sNumero) == false) { bNoValide = false; }
                    }
                    if (bNoValide == false)
                    {
                        return;
                    }
                    Form f = new ChoixClient();
                    f.MdiParent = Conteneur.ActiveForm.MdiParent;
                    f.ShowDialog();
                    rstProjSoum = new Recordset();
                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sNumero + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstProjSoum.EOF)
                    {
                        rstProjSoum.AddNew();
                        rstProjSoum.Fields["IDProjSoum"].Value = sNumero; rstProjSoum.Fields["NoClient"].Value = m_iIDClient; rstProjSoum.Fields["Description"].Value = m_sDescription; rstProjSoum.Fields["DateOuverture"].Value = ConvertDate(DateTime.Today); rstProjSoum.Fields["Ouvert"].Value = true; rstProjSoum.Fields["Type"].Value = sType;
                        rstProjSoum.Update();
                        RemplirComboProjSoum();
                    }
                    else
                    {
                        MessageBox.Show("Ce numéro existe déjà!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstProjSoum.Close();
                    rstProjSoum = null;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdOuvrirProjSoum_Click", ex);
            }
        }
        private void cmdFermerProjSoum_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                var sQuestion = default(string);
                string sRaison;
                switch (m_eType)
                {
                    case enumType.TYPE_PROJET: { sQuestion = "Voulez-vous vraiment fermer ce projet?"; break; }
                    case enumType.TYPE_SOUMISSION: { sQuestion = "Voulez-vous vraiment fermer cette soumission?"; break; }
                }
                if (MessageBox.Show(sQuestion, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rstProjSoum = new Recordset();
                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstProjSoum.Fields["Ouvert"].Value = false;
                    rstProjSoum.Fields["DateFermeture"].Value = ConvertDate(DateTime.Today);
                    if (m_eType == enumType.TYPE_SOUMISSION)
                    {
                        sRaison = Interaction.InputBox("Quelle est la raison de la fermeture?");
                        rstProjSoum.Fields["RaisonFermeture"].Value = sRaison;
                    }
                    rstProjSoum.Update();
                    rstProjSoum.Close();
                    rstProjSoum = null;
                    RemplirComboProjSoum();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdFermerProjSoum_Click", ex);
            }
        }
        private void cmdReouverture_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                var sQuestion = default(string);
                if (cmbNoProjSoum.SelectedIndex != -1)
                {
                    switch (m_eType)
                    {
                        case enumType.TYPE_PROJET: { sQuestion = "Voulez-vous vraiment annuler la fermeture de ce projet?"; break; }
                        case enumType.TYPE_SOUMISSION: { sQuestion = "Voulez-vous vraiment annuler la fermeture de cette soumission?"; break; }
                    }
                    if (MessageBox.Show(sQuestion, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rstProjSoum = new Recordset();
                        rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstProjSoum.Fields["Ouvert"].Value = true;
                        rstProjSoum.Fields["RaisonFermeture"].Value = DBNull.Value;
                        rstProjSoum.Update();
                        rstProjSoum.Close();
                        rstProjSoum = null;
                        ViderValeurs();
                        RemplirComboProjSoum();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdReouverture_Click", ex);
            }
        }
        private void cmdSommaire_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new ChoixDateSommairePunch();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdImprimer_Click", ex);
            }
        }
        private void cmdsupprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sMessage;
                string sErreur;
                RemplirListView();
                if (m_eType == enumType.TYPE_PROJET)
                {
                    sMessage = "Voulez-vous vraiment effacer le projet " + txtNoProjSoum.Text + "?";
                    sErreur = "Impossible de supprimer ce projet car il y a déjà des punchs!";
                }
                else
                {
                    sMessage = "Voulez-vous vraiment effacer la soumission " + txtNoProjSoum.Text + "?";
                    sErreur = "Impossible de supprimer cette soumission car il y a déjà des punchs!";
                }
                if (lvwProjets.Items.Count == 0)
                {
                    if (MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UpdateSQL("DELETE FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'");
                        ViderValeurs();
                        RemplirComboProjSoum();
                        if (cmbNoProjSoum.Items.Count == 0) { ViderValeurs(); }
                    }
                }
                else
                {
                    MessageBox.Show(sErreur, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdSupprimer_Click", ex);
            }
        }
        private void ViderValeurs()
        {
            try
            {
                txtClient.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtDateOuverture.Text = string.Empty;
                txtDateFermeture.Text = string.Empty;
                txtRaisonFermeture.Text = string.Empty;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "ViderValeurs", ex);
            }
        }
        private void cmdVerrouiller_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                rstProjSoum = new Recordset();
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + txtNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                switch (cmdVerrouiller.Text ?? "")
                {
                    case "Verrouiller Soum": { rstProjSoum.Fields["Verrouillé"].Value = true; break; }
                    case "Verrouiller Proj": { rstProjSoum.Fields["Verrouillé"].Value = true; break; }
                    case "Déverrouiller Soum": { rstProjSoum.Fields["Verrouillé"].Value = false; break; }
                    case "Déverrouiller Proj": { rstProjSoum.Fields["Verrouillé"].Value = false; break; }
                }
                rstProjSoum.Update();
                rstProjSoum.Close();
                rstProjSoum = null;
                cmbNoProjSoum_SelectedIndexChanged(cmbNoProjSoum, new EventArgs());
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmdVerrouiller_Click", ex);
            }
        }
        private void Command1_Click()
        {
            Punch2Excel();
        }
        private void Facturation_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                m_bLoading = true;
                cmbProjSoum.SelectedIndex = I_CMB_PROJET;
                cmdFacturerRectifier.Enabled = false;
                cmdNCRectifier.Enabled = false;
                m_bLoading = false;
                RemplirComboProjSoum();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "Form_Load", ex);
            }
        }
        private void cmbProjSoum_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                switch (cmbProjSoum.SelectedIndex)
                {
                    case I_CMB_PROJET:
                        {
                            m_eType = enumType.TYPE_PROJET;
                            lblTitreProjSoum.Text = "Numéro de projet";
                            cmdOuvrirProjSoum.Text = "Ouvrir Projet";
                            cmdFermerProjSoum.Text = "Fermer Projet";
                            fraMontrer.Text = S_FRA_PROJ;
                            _optMontrer_1.Text = S_PROJ_OUVERT;
                            _optMontrer_2.Text = S_PROJ_FERME;
                            break;
                        }
                    case I_CMB_SOUMISSION:
                        {
                            m_eType = enumType.TYPE_SOUMISSION;
                            lblTitreProjSoum.Text = "Numéro de soumission";
                            cmdOuvrirProjSoum.Text = "Ouvrir Soum";
                            cmdFermerProjSoum.Text = "Fermer Soum";
                            fraMontrer.Text = S_FRA_SOUM;
                            _optMontrer_1.Text = S_SOUM_OUVERT;
                            _optMontrer_2.Text = S_SOUM_FERME;
                            break;
                        }
                }
                RemplirComboProjSoum();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "cmbProjSoum_Click", ex);
            }
        }
        private void RemplirComboProjSoum()
        {
            try
            {
                ADODB.Recordset rstProjet;
                var sType = default(string);
                string sWhere=" Where ";
                if (m_bLoading == false)
                {

                    switch (m_eType)
                    {
                        case enumType.TYPE_PROJET: { sType = "P"; break; }
                        case enumType.TYPE_SOUMISSION: { sType = "S"; break; }
                    }
                    if (_optMontrer_1.Checked == true){sWhere += "Ouvert = 1 AND Type = '" + sType + "'";}
                    if (_optMontrer_2.Checked == true){sWhere += "Ouvert = 0 AND Type = '" + sType + "'";}
                    if (_optMontrer_1.Checked == true & _optMontrer_2.Checked == true){sWhere = "(Ouvert = 1 or ouvert =0) AND Type = '" + sType + "'";}
                    if (_optType_0.Checked == true){sWhere += " AND Left(IDProjSoum, 1) = 'E'";}
                    if (_optType_1.Checked == true){sWhere += " AND Left(IDProjSoum, 1) = 'M'";}
                    if (_optMontrer_1.Checked == true & _optMontrer_2.Checked == true) { sWhere += " and (Left(IDProjSoum, 1) = 'E' or Left(IDProjSoum, 1) = 'M')"; }
                    cmbNoProjSoum.Items.Clear();
                    rstProjet = new Recordset();
                    if (!_optMontrer_1.Checked  & !_optMontrer_2.Checked & !_optType_0.Checked & !_optType_1.Checked ) { sWhere = string.Empty; } // boucle init
                    rstProjet.Open("SELECT distinct IDProjSoum FROM ProjSoum " + sWhere + " ORDER BY IDProjSoum", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstProjet.EOF)
                    {
                        cmbNoProjSoum.Items.Add(Droite((string)rstProjet.Fields["IDProjSoum"].Value,8));
                        rstProjet.MoveNext();
                    }
                    rstProjet.Close();
                    rstProjet = null;
                    if (cmbNoProjSoum.Items.Count > 0)
                    {
                        cmbNoProjSoum.SelectedIndex = 0;
                    }
                    else
                    {
                        lvwProjets.Items.Clear();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "RemplirComboProjSoum", ex);
            }
        }
        private void RemplirListView(int Index = 1)
        {
            try
            {
                double dblTotalFacture = 0;
                double dblTotalNonFacture = 0;
                ADODB.Recordset rstProjet = new ADODB.Recordset();
                Color lColor;
                string sTotal;
                lvwProjets.Items.Clear();
                rstProjet.Open($"SELECT PUNCH.*,DATEDIFF(MINUTE,HEUREDÉBUT,HEUREFIN) AS 'TOTAL',EMPLOYÉS.INITIALE FROM EMPLOYÉS " +
                    $"INNER JOIN PUNCH ON EMPLOYÉS.NOEMPLOYE = PUNCH.NOEMPLOYE " +
                    $"WHERE NOPROJET LIKE '%1{Droite(txtNoProjSoum.Text,8)}' ORDER BY[DATE], HEUREDÉBUT, HEUREFIN"
                    , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstProjet.EOF)
                {
                    double valeur = Math.Round(rstProjet.Fields["Total"].Value / 60, 2);
                    if ((bool)rstProjet.Fields["Facturé"].Value)
                    {
                        lColor = COLOR_ROUGE;
                        dblTotalFacture += valeur;
                    }
                    else
                    {
                        lColor = COLOR_BLANC;
                        dblTotalNonFacture += valeur;
                    }
                    ListViewItem itmProjet = lvwProjets.Items.Add(string.Empty);
                    if (Gauche(rstProjet.Fields["NoFacture"].Value, 1).ToLower() == "e") { itmProjet.BackColor = Color.Chocolate; } else { itmProjet.BackColor = Color.DarkBlue; }
                    itmProjet.ForeColor = lColor;
                    itmProjet.SubItems.Insert(0x00, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["Initiale"].Value)));
                    itmProjet.SubItems.Insert(I_LVW_DATE, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["Date"].Value)));
                    itmProjet.SubItems.Insert(I_LVW_DEBUT, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["HeureDébut"].Value)));
                    itmProjet.SubItems.Insert(I_LVW_FIN, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["HeureFin"].Value)));
                    itmProjet.SubItems.Insert(I_LVW_DESCRIPTION, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["Commentaire"].Value)));
                    itmProjet.SubItems.Insert(I_LVW_TOTAL, new ListViewItem.ListViewSubItem(null, valeur.ToString()));
                    itmProjet.SubItems.Insert(I_LVW_NO_FACTURE, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["NoFacture"].Value)));
                    itmProjet.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["Type"].Value)));
                    itmProjet.SubItems[I_LVW_TYPE].ForeColor = lColor;
                    itmProjet.SubItems.Insert(0x08, new ListViewItem.ListViewSubItem(null, Droite(rstProjet.Fields["NoProjet"].Value, 1)+rstProjet.Fields["IDPunch"].Value));
                    itmProjet.Tag = rstProjet.Fields["IDPunch"].Value;

                    rstProjet.MoveNext();
                }
                rstProjet.Close();
                rstProjet = null;
                lblHeuresFacturees.Text = Math.Round(dblTotalFacture, 2).ToString();
                lblHeuresNonFacturees.Text = Math.Round(dblTotalNonFacture, 2).ToString();
                nbClientTrouvés = lvwProjets.Items.Count;
                MessageBox.Show("Il y a " + nbClientTrouvés + " clients corespondant aux criteres", Application.ProductName + "." + Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "RemplirListView", ex);
            }
        }
        private void VerifierSelection()
        {
            try
            {
                int X;
                var iSelected = default(int);
                var iFacture = default(int);
                var iNC = default(int);
                var iNon = default(int);
                for (X = 1; X < (int)lvwProjets.Items.Count; X++)
                {
                    if (lvwProjets.Items[X].Selected)
                    {
                        iSelected++; 
                        if (lvwProjets.Items[X].SubItems[I_LVW_NO_FACTURE].Text == "NC") { iNC++; 
                        } 
                        else if (!string.IsNullOrEmpty(lvwProjets.Items[X].SubItems[I_LVW_NO_FACTURE].Text)) { iFacture++; } 
                        else { iNon++; }
                    }
                }
                if (iSelected == iFacture)
                {
                    cmdFacturerRectifier.Enabled = true;
                    cmdNCRectifier.Enabled = false;
                    cmdFacturerRectifier.Text = S_RECTIFIER;
                }
                else if (iSelected == iNC)
                {
                    cmdFacturerRectifier.Enabled = false;
                    cmdNCRectifier.Enabled = true;
                    cmdNCRectifier.Text = S_RECTIFIER;
                }
                else if (iSelected == iNon)
                {
                    cmdFacturerRectifier.Enabled = true;
                    cmdNCRectifier.Enabled = true;
                    cmdFacturerRectifier.Text = S_FACTURER;
                    cmdNCRectifier.Text = S_NC;
                }
                else
                {
                    cmdFacturerRectifier.Enabled = false;
                    cmdNCRectifier.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "VerifierSelection", ex);
            }
        }
        private void lvwProjets_ItemClick(ListViewItem Item)
        {
            try
            {
                VerifierSelection();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "lvwProjets_ItemClick", ex);
            }
        }
        private void lvwProjets_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                VerifierSelection();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "lvwProjets_Click", ex);
            }
        }
        private void optMontrer_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            bool bFermeture = false;
            if (_optMontrer_1.Checked | _optMontrer_2.Checked) { bFermeture = true; } else { bFermeture = false; }
            lblDateFermeture.Visible = bFermeture;
            txtDateFermeture.Visible = bFermeture;
            lblRaisonFermeture.Visible = bFermeture;
            txtRaisonFermeture.Visible = bFermeture;
            cmdReouverture.Visible = bFermeture;
        }
        private void optType_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (_optType_1.Checked | _optType_0.Checked) { RemplirComboProjSoum(); }
        }
        private bool ValiderFormatSoumission(string sNoSoumission)
        {
            bool ValiderFormatSoumissionRet = default;
            try
            {
                if (sNoSoumission.Substring(3, 1) == "1")
                {
                    ValiderFormatSoumissionRet = true;
                }
                else
                {
                    MessageBox.Show("Une soumission doit absolument avoir '1' comme 3e caractère !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ValiderFormatSoumissionRet = false;
                }
                return ValiderFormatSoumissionRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("Facturation", "ValiderFormatSoumission", ex);
                return false;
            }
        }
        private bool ValiderFormatProjet(string sNoProjet)
        {
            bool ValiderFormatProjetRet = default;
            try
            {
                int iType;
                iType = int.Parse(sNoProjet.Substring(3, 1));
                if (iType == 4 | iType == 5 | iType == 7 | iType == 9)
                {
                    ValiderFormatProjetRet = true;
                }
                else
                {
                    MessageBox.Show("Un projet ouvert dans cet écran doit absolument avoir '4', '5', '7' ou '9' comme 3e caractère !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ValiderFormatProjetRet = false;
                }
                return ValiderFormatProjetRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("FacturationElec", "ValiderFormatProjet", ex);
                return false;
            }
        }
        /// modification du au plantage texte nul
        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            if (txtClient.Text.Length > 1)
            {
                IDClient = txtClient.Text;
            }
        }
        private void txtRaisonFermeture_TextChanged(object sender, EventArgs e)
        {
            Recordset rd = new Recordset();
            rd.Open($"SELECT * FROM[DBO].[PROJSOUM] WHERE RIGHT(IDPROJSOUM, 8) = '{cmbNoProjSoum.Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                rd.Fields["RaisonFermeture"].Value = txtRaisonFermeture.Text;
                if(rd.Fields["DateFermeture"].Value is DBNull)
                {
                    rd.Fields["DateFermeture"].Value = DateTime.Today.ToShortDateString();
                }
                string oldDesc = rd.Fields["Description"].Value;
                txtDateFermeture.Text = DateTime.Today.ToShortDateString();
                rd.Fields["Description"].Value = oldDesc + " Modifié par " + Conteneur.idInitiales.Text + " " + DateTime.Now.ToString();
                rd.Fields["Ouvert"].Value = 0;
                rd.Update();
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
        }
        private void txtDateFermeture_TextChanged(object sender, EventArgs e)
        {
            if (txtDateFermeture.Text == "")
            {
                txtDateFermeture.Text = DateTime.Today.ToShortDateString();
            }
            Recordset rd = new Recordset();
            rd.Open($"SELECT * FROM[DBO].[PROJSOUM] WHERE RIGHT(IDPROJSOUM, 8) = '{cmbNoProjSoum.Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                rd.Fields["DateFermeture"].Value = txtDateFermeture.Text;
                string oldDesc = $"{rd.Fields["Description"].Value}";
                rd.Fields["Description"].Value = oldDesc + " Modifié par " + Conteneur.idInitiales.Text + " " + DateTime.Now.ToString();
                rd.Fields["Ouvert"].Value = 0;
                rd.Update();
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            Recordset rd = new Recordset();
            rd.Open($"SELECT * FROM[DBO].[PROJSOUM] WHERE RIGHT(IDPROJSOUM, 8) = '{cmbNoProjSoum.Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                string rep=Interaction.InputBox(txtDescription.Text,Application.ProductName,txtDescription.Text + " Modifié par " + Conteneur.idInitiales.Text + " " + DateTime.Now.ToString());
                rd.Fields["Description"].Value = rep;
                rd.Fields["Ouvert"].Value = 0;
                rd.Update();
                txtDescription.Text = rep;
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
        }
        private void _optMontrer_1_CheckedChanged(object sender, EventArgs e) => RemplirComboProjSoum();
        private void _optMontrer_2_CheckedChanged(object sender, EventArgs e) => RemplirComboProjSoum();
        private void _optType_0_CheckedChanged(object sender, EventArgs e) => RemplirComboProjSoum();
        private void _optType_1_CheckedChanged(object sender, EventArgs e) => RemplirComboProjSoum();
    }
}