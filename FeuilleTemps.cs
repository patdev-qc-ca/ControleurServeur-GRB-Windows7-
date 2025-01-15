using System;
using System.Windows.Forms;
using CursorTypeEnum = ADODB.CursorTypeEnum;
using LockTypeEnum = ADODB.LockTypeEnum;
using Recordset = ADODB.Recordset;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using System.Web.UI.WebControls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using System.Data.SqlClient;
using ListView = System.Windows.Forms.ListView;
using Label = System.Windows.Forms.Label;
using System.Diagnostics;
using ControleurServeur;

namespace ControleurServeur
{
    internal  class FeuilleTemps : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public FeuilleTemps() : base()
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
        internal System.Windows.Forms.Button CmdModifier;
        internal System.Windows.Forms.Button cmdexcel;
        internal System.Windows.Forms.Button cmdExporter;
        internal System.Windows.Forms.TextBox txtSemaine;
        internal System.Windows.Forms.Button cmdDateSemaine;
        internal System.Windows.Forms.Button cmdImprimer;
        internal ComboBox cmbEmployé;
        internal System.Windows.Forms.Button cmdEnregistrer;
        internal ColumnHeader _lvwPunch_ColumnHeader_1;
        internal ColumnHeader _lvwPunch_ColumnHeader_2;
        internal ColumnHeader _lvwPunch_ColumnHeader_3;
        internal ColumnHeader _lvwPunch_ColumnHeader_4;
        internal ColumnHeader _lvwPunch_ColumnHeader_5;
        internal ColumnHeader _lvwPunch_ColumnHeader_6;
        internal ColumnHeader _lvwPunch_ColumnHeader_7;
        internal ListView lvwPunch;
        internal System.Windows.Forms.Button cmdFermer;
        internal System.Windows.Forms.Button cmdAjouter;
        internal System.Windows.Forms.Button cmdAnnuler;
        internal Label Label6;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            CmdModifier = new System.Windows.Forms.Button();
            cmdexcel = new System.Windows.Forms.Button();
            cmdExporter = new System.Windows.Forms.Button();
            txtSemaine = new System.Windows.Forms.TextBox();
            cmdDateSemaine = new System.Windows.Forms.Button();
            cmdImprimer = new System.Windows.Forms.Button();
            cmbEmployé = new System.Windows.Forms.ComboBox();
            cmdEnregistrer = new System.Windows.Forms.Button();
            lvwPunch = new System.Windows.Forms.ListView();
            _lvwPunch_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPunch_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPunch_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPunch_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPunch_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPunch_ColumnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwPunch_ColumnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdFermer = new System.Windows.Forms.Button();
            cmdAjouter = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            Label6 = new System.Windows.Forms.Label();
            mvwDate = new System.Windows.Forms.DateTimePicker();
            cmbType = new System.Windows.Forms.ComboBox();
            Label1 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            _optTypePunch_1 = new System.Windows.Forms.RadioButton();
            Label5 = new System.Windows.Forms.Label();
            _optTypePunch_0 = new System.Windows.Forms.RadioButton();
            Label7 = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            chkKM = new System.Windows.Forms.CheckBox();
            Label4 = new System.Windows.Forms.Label();
            txtClient = new System.Windows.Forms.TextBox();
            cmdDate = new System.Windows.Forms.Button();
            txtKM = new System.Windows.Forms.TextBox();
            txtCommentaires = new System.Windows.Forms.TextBox();
            mskHeureDebut = new System.Windows.Forms.MaskedTextBox();
            mskDate = new System.Windows.Forms.MaskedTextBox();
            mskHeureFin = new System.Windows.Forms.MaskedTextBox();
            txtNoProjet = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // CmdModifier
            // 
            CmdModifier.AutoSize = true;
            CmdModifier.BackColor = System.Drawing.Color.Black;
            CmdModifier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdModifier.ForeColor=System.Drawing.Color.Navy;
            CmdModifier.Location = new System.Drawing.Point(398, 651);
            CmdModifier.Name = "CmdModifier";
            CmdModifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdModifier.Size = new System.Drawing.Size(88, 34);
            CmdModifier.TabIndex = 34;
            CmdModifier.Text = "Modifier Type";
            CmdModifier.UseVisualStyleBackColor = true;
            CmdModifier.Click += new System.EventHandler(cmdModifier_Click);
            // 
            // cmdexcel
            // 
            cmdexcel.AutoSize = true;
            cmdexcel.BackColor = System.Drawing.Color.Black;
            cmdexcel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdexcel.ForeColor=System.Drawing.Color.Navy;
            cmdexcel.Location = new System.Drawing.Point(299, 651);
            cmdexcel.Name = "cmdexcel";
            cmdexcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdexcel.Size = new System.Drawing.Size(43, 34);
            cmdexcel.TabIndex = 33;
            cmdexcel.Text = "Excel";
            cmdexcel.UseVisualStyleBackColor = true;
            cmdexcel.Click += new System.EventHandler(cmdexcel_Click);
            // 
            // cmdExporter
            // 
            cmdExporter.AutoSize = true;
            cmdExporter.BackColor = System.Drawing.Color.Black;
            cmdExporter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdExporter.ForeColor=System.Drawing.Color.Navy;
            cmdExporter.Location = new System.Drawing.Point(164, 651);
            cmdExporter.Name = "cmdExporter";
            cmdExporter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdExporter.Size = new System.Drawing.Size(59, 34);
            cmdExporter.TabIndex = 28;
            cmdExporter.Text = "Exporter";
            cmdExporter.UseVisualStyleBackColor = true;
            cmdExporter.Click += new System.EventHandler(cmdexporter_Click);
            // 
            // txtSemaine
            // 
            txtSemaine.AcceptsReturn = true;
            txtSemaine.BackColor = System.Drawing.Color.Black;
            txtSemaine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtSemaine.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtSemaine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtSemaine.ForeColor = System.Drawing.Color.White;
            txtSemaine.Location = new System.Drawing.Point(221, 3);
            txtSemaine.MaxLength = 0;
            txtSemaine.Name = "txtSemaine";
            txtSemaine.ReadOnly = true;
            txtSemaine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtSemaine.Size = new System.Drawing.Size(760, 19);
            txtSemaine.TabIndex = 2;
            txtSemaine.TextChanged += new System.EventHandler(txtSemaine_TextChanged);
            // 
            // cmdDateSemaine
            // 
            cmdDateSemaine.AutoSize = true;
            cmdDateSemaine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdDateSemaine.BackColor = System.Drawing.Color.Black;
            cmdDateSemaine.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdDateSemaine.ForeColor=System.Drawing.Color.Navy;
            cmdDateSemaine.Location = new System.Drawing.Point(724, 27);
            cmdDateSemaine.Name = "cmdDateSemaine";
            cmdDateSemaine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDateSemaine.Size = new System.Drawing.Size(125, 24);
            cmdDateSemaine.TabIndex = 4;
            cmdDateSemaine.Text = "C&hoisir une autre date";
            cmdDateSemaine.UseVisualStyleBackColor = true;
            cmdDateSemaine.Click += new System.EventHandler(cmdDateSemaine_Click);
            // 
            // cmdImprimer
            // 
            cmdImprimer.AutoSize = true;
            cmdImprimer.BackColor = System.Drawing.Color.Black;
            cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdImprimer.ForeColor=System.Drawing.Color.Navy;
            cmdImprimer.Location = new System.Drawing.Point(543, 651);
            cmdImprimer.Name = "cmdImprimer";
            cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdImprimer.Size = new System.Drawing.Size(64, 34);
            cmdImprimer.TabIndex = 23;
            cmdImprimer.Text = "Imprimer";
            cmdImprimer.UseVisualStyleBackColor = true;
            cmdImprimer.Click += new System.EventHandler(cmdImprimer_Click);
            // 
            // cmbEmployé
            // 
            cmbEmployé.BackColor = System.Drawing.Color.Black;
            cmbEmployé.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEmployé.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbEmployé.ForeColor = System.Drawing.Color.White;
            cmbEmployé.Location = new System.Drawing.Point(380, 30);
            cmbEmployé.Name = "cmbEmployé";
            cmbEmployé.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbEmployé.Size = new System.Drawing.Size(258, 22);
            cmbEmployé.Sorted = true;
            cmbEmployé.TabIndex = 1;
            cmbEmployé.SelectedIndexChanged += new System.EventHandler(cmbEmployé_SelectedIndexChanged);
            // 
            // cmdEnregistrer
            // 
            cmdEnregistrer.AutoSize = true;
            cmdEnregistrer.BackColor = System.Drawing.Color.Black;
            cmdEnregistrer.Enabled = false;
            cmdEnregistrer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdEnregistrer.ForeColor=System.Drawing.Color.Navy;
            cmdEnregistrer.Location = new System.Drawing.Point(226, 651);
            cmdEnregistrer.Name = "cmdEnregistrer";
            cmdEnregistrer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdEnregistrer.Size = new System.Drawing.Size(71, 34);
            cmdEnregistrer.TabIndex = 25;
            cmdEnregistrer.Text = "Enregistrer";
            cmdEnregistrer.UseVisualStyleBackColor = true;
            cmdEnregistrer.Click += new System.EventHandler(cmdEnregistrer_Click);
            // 
            // lvwPunch
            // 
            lvwPunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lvwPunch.BackColor = System.Drawing.Color.Black;
            lvwPunch.CheckBoxes = true;
            lvwPunch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwPunch_ColumnHeader_1,
            _lvwPunch_ColumnHeader_2,
            _lvwPunch_ColumnHeader_3,
            _lvwPunch_ColumnHeader_4,
            _lvwPunch_ColumnHeader_5,
            _lvwPunch_ColumnHeader_6,
            _lvwPunch_ColumnHeader_7});
            lvwPunch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwPunch.ForeColor=System.Drawing.Color.White;
            lvwPunch.FullRowSelect = true;
            lvwPunch.GridLines = true;
            lvwPunch.HideSelection = false;
            lvwPunch.Location = new System.Drawing.Point(0, 60);
            lvwPunch.Name = "lvwPunch";
            lvwPunch.Size = new System.Drawing.Size(992, 408);
            lvwPunch.TabIndex = 5;
            lvwPunch.UseCompatibleStateImageBehavior = false;
            lvwPunch.View = System.Windows.Forms.View.Details;
            lvwPunch.SelectedIndexChanged += new System.EventHandler(lvwPunch_SelectedIndexChanged);
            lvwPunch.Click += new System.EventHandler(lvwPunch_Click);
            lvwPunch.KeyDown += new System.Windows.Forms.KeyEventHandler(lvwPunch_KeyDown);
            // 
            // _lvwPunch_ColumnHeader_1
            // 
            _lvwPunch_ColumnHeader_1.Text = "Projet";
            _lvwPunch_ColumnHeader_1.Width = 107;
            // 
            // _lvwPunch_ColumnHeader_2
            // 
            _lvwPunch_ColumnHeader_2.Text = "Date";
            _lvwPunch_ColumnHeader_2.Width = 64;
            // 
            // _lvwPunch_ColumnHeader_3
            // 
            _lvwPunch_ColumnHeader_3.Text = "Début";
            _lvwPunch_ColumnHeader_3.Width = 41;
            // 
            // _lvwPunch_ColumnHeader_4
            // 
            _lvwPunch_ColumnHeader_4.Text = "Fin";
            _lvwPunch_ColumnHeader_4.Width = 42;
            // 
            // _lvwPunch_ColumnHeader_5
            // 
            _lvwPunch_ColumnHeader_5.Text = "Client";
            _lvwPunch_ColumnHeader_5.Width = 180;
            // 
            // _lvwPunch_ColumnHeader_6
            // 
            _lvwPunch_ColumnHeader_6.Text = "Type";
            _lvwPunch_ColumnHeader_6.Width = 170;
            // 
            // _lvwPunch_ColumnHeader_7
            // 
            _lvwPunch_ColumnHeader_7.Text = "Commentaire";
            _lvwPunch_ColumnHeader_7.Width = 184;
            // 
            // cmdFermer
            // 
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor=System.Drawing.Color.Navy;
            cmdFermer.Location = new System.Drawing.Point(912, 651);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(69, 33);
            cmdFermer.TabIndex = 27;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(Cmdfermer_Click);
            // 
            // cmdAjouter
            // 
            cmdAjouter.AutoSize = true;
            cmdAjouter.BackColor = System.Drawing.Color.Black;
            cmdAjouter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAjouter.ForeColor=System.Drawing.Color.Navy;
            cmdAjouter.Location = new System.Drawing.Point(344, 651);
            cmdAjouter.Name = "cmdAjouter";
            cmdAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAjouter.Size = new System.Drawing.Size(53, 34);
            cmdAjouter.TabIndex = 24;
            cmdAjouter.Text = "Ajouter";
            cmdAjouter.UseVisualStyleBackColor = true;
            cmdAjouter.Click += new System.EventHandler(Cmdajouter_Click);
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.AutoSize = true;
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor=System.Drawing.Color.Navy;
            cmdAnnuler.Location = new System.Drawing.Point(486, 651);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(55, 34);
            cmdAnnuler.TabIndex = 26;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = System.Drawing.Color.Black;
            Label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label6.ForeColor=System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(321, 33);
            Label6.Name = "Label6";
            Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label6.Size = new System.Drawing.Size(56, 14);
            Label6.TabIndex = 0;
            Label6.Text = "Employé :";
            // 
            // mvwDate
            // 
            mvwDate.Location = new System.Drawing.Point(855, 28);
            mvwDate.Name = "mvwDate";
            mvwDate.Size = new System.Drawing.Size(137, 22);
            mvwDate.TabIndex = 36;
            mvwDate.Visible = false;
            mvwDate.ValueChanged += new System.EventHandler(mvwDate_ValueChanged);
            // 
            // cmbType
            // 
            cmbType.BackColor = System.Drawing.Color.Black;
            cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbType.ForeColor = System.Drawing.Color.White;
            cmbType.Location = new System.Drawing.Point(291, 538);
            cmbType.Name = "cmbType";
            cmbType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbType.Size = new System.Drawing.Size(249, 22);
            cmbType.TabIndex = 35;
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(21, 514);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(89, 17);
            Label1.TabIndex = 6;
            Label1.Text = "Numéro de projet :";
            // 
            // Label2
            // 
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(21, 538);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(89, 17);
            Label2.TabIndex = 11;
            Label2.Text = "Date (AA-MM-JJ):";
            // 
            // Label3
            // 
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(21, 562);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(89, 17);
            Label3.TabIndex = 14;
            Label3.Text = "Heure de début :";
            // 
            // _optTypePunch_1
            // 
            _optTypePunch_1.AutoSize = true;
            _optTypePunch_1.BackColor = System.Drawing.Color.Black;
            _optTypePunch_1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _optTypePunch_1.ForeColor = System.Drawing.Color.White;
            _optTypePunch_1.Location = new System.Drawing.Point(117, 490);
            _optTypePunch_1.Name = "_optTypePunch_1";
            _optTypePunch_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _optTypePunch_1.Size = new System.Drawing.Size(79, 18);
            _optTypePunch_1.TabIndex = 30;
            _optTypePunch_1.TabStop = true;
            _optTypePunch_1.Text = "Mécanique";
            _optTypePunch_1.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            Label5.BackColor = System.Drawing.Color.Black;
            Label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(21, 586);
            Label5.Name = "Label5";
            Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label5.Size = new System.Drawing.Size(89, 17);
            Label5.TabIndex = 17;
            Label5.Text = "Heure de fin :";
            // 
            // _optTypePunch_0
            // 
            _optTypePunch_0.AutoSize = true;
            _optTypePunch_0.BackColor = System.Drawing.Color.Black;
            _optTypePunch_0.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _optTypePunch_0.ForeColor = System.Drawing.Color.White;
            _optTypePunch_0.Location = new System.Drawing.Point(117, 474);
            _optTypePunch_0.Name = "_optTypePunch_0";
            _optTypePunch_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _optTypePunch_0.Size = new System.Drawing.Size(74, 18);
            _optTypePunch_0.TabIndex = 29;
            _optTypePunch_0.TabStop = true;
            _optTypePunch_0.Text = "Électrique";
            _optTypePunch_0.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = System.Drawing.Color.Black;
            Label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label7.ForeColor = System.Drawing.Color.White;
            Label7.Location = new System.Drawing.Point(291, 562);
            Label7.Name = "Label7";
            Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label7.Size = new System.Drawing.Size(85, 14);
            Label7.TabIndex = 16;
            Label7.Text = "Commentaires :";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = System.Drawing.Color.Black;
            Label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label8.ForeColor = System.Drawing.Color.White;
            Label8.Location = new System.Drawing.Point(291, 482);
            Label8.Name = "Label8";
            Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label8.Size = new System.Drawing.Size(41, 14);
            Label8.TabIndex = 9;
            Label8.Text = "Client :";
            // 
            // chkKM
            // 
            chkKM.BackColor = System.Drawing.Color.Black;
            chkKM.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkKM.ForeColor=System.Drawing.Color.Navy;
            chkKM.Location = new System.Drawing.Point(61, 610);
            chkKM.Name = "chkKM";
            chkKM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkKM.Size = new System.Drawing.Size(49, 17);
            chkKM.TabIndex = 19;
            chkKM.Text = "KM :";
            chkKM.UseVisualStyleBackColor = true;
            chkKM.CheckStateChanged += new System.EventHandler(chkKM_CheckStateChanged);
            // 
            // Label4
            // 
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor=System.Drawing.Color.Navy;
            Label4.Location = new System.Drawing.Point(189, 612);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(41, 17);
            Label4.TabIndex = 22;
            Label4.Text = "Km";
            // 
            // txtClient
            // 
            txtClient.AcceptsReturn = true;
            txtClient.BackColor = System.Drawing.Color.Black;
            txtClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtClient.Enabled = false;
            txtClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtClient.ForeColor=System.Drawing.Color.Navy;
            txtClient.Location = new System.Drawing.Point(291, 498);
            txtClient.MaxLength = 0;
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtClient.Size = new System.Drawing.Size(249, 22);
            txtClient.TabIndex = 10;
            // 
            // cmdDate
            // 
            cmdDate.BackColor = System.Drawing.Color.Black;
            cmdDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdDate.ForeColor=System.Drawing.Color.Navy;
            cmdDate.Location = new System.Drawing.Point(205, 538);
            cmdDate.Name = "cmdDate";
            cmdDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDate.Size = new System.Drawing.Size(25, 21);
            cmdDate.TabIndex = 13;
            cmdDate.Text = "..";
            cmdDate.UseVisualStyleBackColor = true;
            cmdDate.Click += new System.EventHandler(cmdDate_Click);
            // 
            // txtKM
            // 
            txtKM.AcceptsReturn = true;
            txtKM.BackColor = System.Drawing.Color.Black;
            txtKM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtKM.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtKM.ForeColor = System.Drawing.Color.White;
            txtKM.Location = new System.Drawing.Point(117, 610);
            txtKM.MaxLength = 0;
            txtKM.Multiline = true;
            txtKM.Name = "txtKM";
            txtKM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtKM.Size = new System.Drawing.Size(66, 19);
            txtKM.TabIndex = 21;
            txtKM.Leave += new System.EventHandler(txtKM_Leave);
            // 
            // txtCommentaires
            // 
            txtCommentaires.AcceptsReturn = true;
            txtCommentaires.BackColor = System.Drawing.Color.Black;
            txtCommentaires.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtCommentaires.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCommentaires.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCommentaires.ForeColor = System.Drawing.Color.White;
            txtCommentaires.Location = new System.Drawing.Point(291, 578);
            txtCommentaires.MaxLength = 0;
            txtCommentaires.Multiline = true;
            txtCommentaires.Name = "txtCommentaires";
            txtCommentaires.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCommentaires.Size = new System.Drawing.Size(249, 51);
            txtCommentaires.TabIndex = 20;
            // 
            // mskHeureDebut
            // 
            mskHeureDebut.AllowPromptAsInput = false;
            mskHeureDebut.BackColor = System.Drawing.Color.Black;
            mskHeureDebut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskHeureDebut.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskHeureDebut.ForeColor = System.Drawing.Color.White;
            mskHeureDebut.Location = new System.Drawing.Point(117, 562);
            mskHeureDebut.Name = "mskHeureDebut";
            mskHeureDebut.Size = new System.Drawing.Size(113, 22);
            mskHeureDebut.TabIndex = 15;
            mskHeureDebut.Enter += new System.EventHandler(mskHeureDebut_Enter);
            mskHeureDebut.Leave += new System.EventHandler(mskHeureDebut_Leave);
            // 
            // mskDate
            // 
            mskDate.AllowPromptAsInput = false;
            mskDate.BackColor = System.Drawing.Color.Black;
            mskDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskDate.ForeColor = System.Drawing.Color.White;
            mskDate.Location = new System.Drawing.Point(117, 538);
            mskDate.Name = "mskDate";
            mskDate.Size = new System.Drawing.Size(81, 22);
            mskDate.TabIndex = 12;
            mskDate.Enter += new System.EventHandler(mskDate_Enter);
            mskDate.Leave += new System.EventHandler(mskDate_Leave);
            // 
            // mskHeureFin
            // 
            mskHeureFin.AllowPromptAsInput = false;
            mskHeureFin.BackColor = System.Drawing.Color.Black;
            mskHeureFin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskHeureFin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskHeureFin.ForeColor = System.Drawing.Color.White;
            mskHeureFin.Location = new System.Drawing.Point(117, 586);
            mskHeureFin.Name = "mskHeureFin";
            mskHeureFin.Size = new System.Drawing.Size(113, 22);
            mskHeureFin.TabIndex = 18;
            mskHeureFin.Enter += new System.EventHandler(mskHeureFin_Enter);
            mskHeureFin.Leave += new System.EventHandler(mskHeureFin_Leave);
            // 
            // txtNoProjet
            // 
            txtNoProjet.AcceptsReturn = true;
            txtNoProjet.BackColor = System.Drawing.Color.Black;
            txtNoProjet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtNoProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoProjet.Enabled = false;
            txtNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNoProjet.ForeColor = System.Drawing.Color.White;
            txtNoProjet.Location = new System.Drawing.Point(117, 514);
            txtNoProjet.MaxLength = 0;
            txtNoProjet.Multiline = true;
            txtNoProjet.Name = "txtNoProjet";
            txtNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoProjet.Size = new System.Drawing.Size(113, 19);
            txtNoProjet.TabIndex = 37;
            // 
            // FeuilleTemps
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(993, 703);
            Controls.Add(txtNoProjet);
            Controls.Add(cmbType);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(cmbEmployé);
            Controls.Add(Label3);
            Controls.Add(lvwPunch);
            Controls.Add(_optTypePunch_1);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(cmdDateSemaine);
            Controls.Add(_optTypePunch_0);
            Controls.Add(cmdFermer);
            Controls.Add(Label7);
            Controls.Add(mvwDate);
            Controls.Add(Label8);
            Controls.Add(cmdImprimer);
            Controls.Add(chkKM);
            Controls.Add(cmdAnnuler);
            Controls.Add(Label4);
            Controls.Add(CmdModifier);
            Controls.Add(txtClient);
            Controls.Add(cmdAjouter);
            Controls.Add(cmdDate);
            Controls.Add(txtSemaine);
            Controls.Add(txtKM);
            Controls.Add(cmdexcel);
            Controls.Add(txtCommentaires);
            Controls.Add(cmdExporter);
            Controls.Add(mskHeureDebut);
            Controls.Add(cmdEnregistrer);
            Controls.Add(mskDate);
            Controls.Add(mskHeureFin);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            Location = new System.Drawing.Point(3, 22);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FeuilleTemps";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ControleurServeur.FeuilleTemps";
            Load += new System.EventHandler(FeuilleTemps_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        private DateTimePicker mvwDate;
        internal ComboBox cmbType;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal System.Windows.Forms.RadioButton _optTypePunch_1;
        internal Label Label5;
        internal System.Windows.Forms.RadioButton _optTypePunch_0;
        internal Label Label7;
        internal Label Label8;
        internal System.Windows.Forms.CheckBox chkKM;
        internal Label Label4;
        internal System.Windows.Forms.TextBox txtClient;
        internal System.Windows.Forms.Button cmdDate;
        internal System.Windows.Forms.TextBox txtKM;
        internal System.Windows.Forms.TextBox txtCommentaires;
        internal MaskedTextBox mskHeureDebut;
        internal MaskedTextBox mskDate;
        internal MaskedTextBox mskHeureFin;
        internal System.Windows.Forms.TextBox txtNoProjet;
        private const int I_TYPE_ELEC_INSTALLATION = 0;
        private const int I_TYPE_ELEC_MISE_SERVICE = 1;

        private const int I_TYPE_ELEC_DESSIN = 0;
        private const int I_TYPE_ELEC_FABRICATION = 1;
        private const int I_TYPE_ELEC_ASSEMBLAGE = 2;
        private const int I_TYPE_ELEC_PROG_INTERFACE = 3;
        private const int I_TYPE_ELEC_PROG_AUTOMATE = 4;
        private const int I_TYPE_ELEC_PROG_ROBOT = 5;
        private const int I_TYPE_ELEC_VISION = 6;
        private const int I_TYPE_ELEC_TEST = 7;
        private const int I_TYPE_ELEC_FORMATION = 8;
        private const int I_TYPE_ELEC_GESTION = 9;
        private const int I_TYPE_ELEC_SHIPPING = 10;
        private const int I_TYPE_ELEC_prototypage = 11;

        private const int I_TYPE_MEC_INSTALLATION = 0;

        private const int I_TYPE_MEC_DESSIN = 0;
        private const int I_TYPE_MEC_COUPE = 1;
        private const int I_TYPE_MEC_MACHINAGE = 2;
        private const int I_TYPE_MEC_SOUDURE = 3;
        private const int I_TYPE_MEC_ASSEMBLAGE = 4;
        private const int I_TYPE_MEC_PEINTURE = 5;
        private const int I_TYPE_MEC_TEST = 6;
        private const int I_TYPE_MEC_FORMATION = 7;
        private const int I_TYPE_MEC_GESTION = 8;
        private const int I_TYPE_MEC_SHIPPING = 9;
        private const int I_TYPE_MEC_prototypage = 10;
        private const int I_LVW_PROJET = 0;
        private const int I_LVW_DATE = 1;
        private const int I_LVW_DEBUT = 2;
        private const int I_LVW_FIN = 3;
        private const int I_LVW_CLIENT = 4;
        private const int I_LVW_TYPE = 5;
        private const int I_LVW_COMMENTAIRE = 6;
        private const int I_OPT_ELECTRIQUE = 0;
        private const int I_OPT_MECANIQUE = 1;
        private enum EnumMode
        {
            MODE_INACTIF = 0,
            MODE_MODIF = 1,
            MODE_AJOUT = 2
        }
        private int m_lIDPunch;
        public DateTime m_datSemaine;
        private bool m_bModifProj;
        private EnumMode m_eMode;
        private bool m_bClick;
        internal static ListView ftCalendrier;
        internal static ComboBox ftCmbType;
        internal static MaskedTextBox mskNoProjet = new MaskedTextBox();
        internal static Label lblType = new System.Windows.Forms.Label();
        internal static Label lblPrefixe = new System.Windows.Forms.Label();
        private void ActiverControles(EnumMode eMode)
        {
            try
            {

                var bListView = default(bool);
                var bEmploye = default(bool); 
                var bSemaine = default(bool); 
                var bChamps = default(bool); 
                var bImprimer = default(bool);
                var bAjouter = default(bool);
                var bAnnuler = default(bool); 
                var bEnregistrer = default(bool);
                var bFermer = default(bool); 
                m_eMode = eMode;
                switch (eMode)
                {
                    case EnumMode.MODE_INACTIF:
                        {
                            bListView = true;
                            bEmploye = true;
                            bSemaine = true;
                            bImprimer = true;
                            bAjouter = true;
                            bFermer = true; break;
                        }

                    case EnumMode.MODE_MODIF:
                        {
                            bListView = true;
                            bEmploye = true;
                            bSemaine = true;
                            bChamps = true;
                            bImprimer = true;
                            bAjouter = true;
                            bAnnuler = true;
                            bEnregistrer = true;
                            bFermer = true; break;
                        }
                    case EnumMode.MODE_AJOUT:
                        {
                            bChamps = true;
                            bAnnuler = true;
                            bEnregistrer = true; break;
                        }
                }
                lvwPunch.Enabled = bListView;
                cmbEmployé.Enabled = bEmploye;
                cmdDateSemaine.Enabled = bSemaine;
                mskNoProjet.Enabled = bChamps;
                mskDate.Enabled = bChamps;
                cmdDate.Enabled = bChamps;
                mskHeureDebut.Enabled = bChamps;
                mskHeureFin.Enabled = bChamps;
                txtCommentaires.Enabled = bChamps;
                cmbType.Enabled = bChamps;
                _optTypePunch_0.Enabled = bChamps;
                _optTypePunch_1.Enabled = bChamps;
                if (g_bModificationFeuillesTemps == true | (cmbEmployé.Text ?? "") == (IdNomEmploye ?? ""))
                {
                    cmdEnregistrer.Enabled = bEnregistrer;
                    cmdexcel.Enabled = bImprimer;
                    cmdImprimer.Enabled = bImprimer;
                    cmdAjouter.Enabled = bAjouter;
                }
                else
                {
                    cmdEnregistrer.Enabled = false;
                    cmdexcel.Enabled = false;
                    cmdImprimer.Enabled = false;
                    cmdAjouter.Enabled = false;
                }
                cmdAnnuler.Visible = bAnnuler;
                cmdFermer.Visible = bFermer;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "ActiverControles", ex);
            }
        }

        private void chkKM_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkKM.Checked)
                {
                    txtKM.Enabled = true;
                }
                else
                {
                    txtKM.Text = "";
                    txtKM.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "chkKM_Click", ex);
            }
        }
        private void cmdexcel_Click(object eventSender, EventArgs eventArgs)
        {
            Microsoft.Office.Interop.Excel.Workbook xlworksheet;
            Microsoft.Office.Interop.Excel.Application xlsheet;
            ADODB.Recordset info;
            int row = default(int);
            int i = default(int);
            xlsheet = new Microsoft.Office.Interop.Excel.Application();
            xlworksheet = xlsheet.Workbooks.Add();
            ((dynamic)xlsheet.Cells[1, 1]).Value = "Employé";
            ((dynamic)xlsheet.Cells[1, 4]).Value = "Semaine Du:";
            ((dynamic)xlsheet.Cells[3, 1]).Value = "Projet";
            ((dynamic)xlsheet.Cells[3, 2]).Value = "Date";
            ((dynamic)xlsheet.Cells[3, 3]).Value = "Début";
            ((dynamic)xlsheet.Cells[3, 4]).Value = "Fin";
            ((dynamic)xlsheet.Cells[3, 5]).Value = "Client";
            ((dynamic)xlsheet.Cells[3, 6]).Value = "Type";
            ((dynamic)xlsheet.Cells[3, 7]).Value = "Commentaire";
            {
                var withBlock = xlsheet.get_Range("A1;D1;A3:G3");
                withBlock.Font.Bold = true;
                withBlock.Font.Size = 11;
            }
            ((dynamic)xlsheet.Cells[1, 2]).Value = cmbEmployé.Text;
            ((dynamic)xlsheet.Cells[1, 5]).Value = txtSemaine.Text;
            row = 4;
            for (i = 1; i < lvwPunch.Items.Count; i++)
            {
                ((dynamic)xlsheet.Cells[row, 1]).Value = lvwPunch.Items[i].Text;
                ((dynamic)xlsheet.Cells[row, 2]).Value = lvwPunch.Items[i].SubItems[1].Text;
                ((dynamic)xlsheet.Cells[row, 3]).Value = lvwPunch.Items[i].SubItems[2].Text;
                ((dynamic)xlsheet.Cells[row, 4]).Value = lvwPunch.Items[i].SubItems[3].Text;
                ((dynamic)xlsheet.Cells[row, 5]).Value = lvwPunch.Items[i].SubItems[4].Text;
                ((dynamic)xlsheet.Cells[row, 6]).Value = lvwPunch.Items[i].SubItems[5].Text;
                ((dynamic)xlsheet.Cells[row, 7]).Value = lvwPunch.Items[i].SubItems[6].Text;
                row = (int)(row + 1);
            }
            xlsheet.get_Range("A:G").Columns.AutoFit();
            xlsheet.Visible = true;
            xlworksheet.SaveAs(Filename: $"{RootExcel}{cmbEmployé.Text}_{txtSemaine.Text}.xlsx");
            xlsheet = null;
        }
        private void cmdModifier_Click(object eventSender, EventArgs eventArgs)
        {
            Form f = new ModType();
            f.MdiParent = Conteneur.ActiveForm.MdiParent;
            f.Show();
        }
        private void optTypePunch_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (_optTypePunch_0.Checked)
            {
                lblPrefixe.Text = "E";
            }
            else
            {
                lblPrefixe.Text = "M";
            }
            RemplirComboType();
        }
        private void Cmdajouter_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ViderChamps();
                ActiverControles(EnumMode.MODE_AJOUT);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "cmdAjouter_Click", ex);
            }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ViderChamps();
                ActiverControles(EnumMode.MODE_INACTIF);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdDateSemaine_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mvwDate.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "cmdDateSemaine_Click", ex);
            }
        }
        private void cmbEmployé_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                lvwPunch.Items.Clear();
                ViderChamps();
                ActiverControles(EnumMode.MODE_INACTIF);
                if (!string.IsNullOrEmpty(txtSemaine.Text))
                {
                    RemplirListView();
                }
                cmdEnregistrer.Enabled = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "cmbEmployé_Click", ex);
            }
        }
        private void cmdDate_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(Strings.Trim(mskDate.Text)))
                {
                    if (ValiderDate(mskDate.Text) == true)
                    {
                        mvwDate.Value = Conversions.ToDate(mskDate.Text);
                    }
                    else
                    {
                        mvwDate.Value = DateTime.Today;
                    }
                }
                else
                {
                    mvwDate.Value = DateTime.Today;
                } ((dynamic)mvwDate).Visible = true;
                ((dynamic)mvwDate).Focus();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "cmdDate_Click", ex);
            }
        }
        [Obsolete]
        private void cmdEnregistrer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstProjSoum;
                bool bInstallation;
                rstProjSoum = new Recordset();
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + lblPrefixe.Text + mskNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["Ouvert"].Value, false, false)))
                    {
                        MessageBox.Show("Ce projet est fermé!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rstProjSoum.Close();
                        rstProjSoum = null;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Projet inexistant!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rstProjSoum.Close();
                    rstProjSoum = null;
                    return;
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                if (ValiderHeure(mskHeureDebut.Text) == false)
                {
                    MessageBox.Show("L'heure de début est invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (mskHeureFin.Text != "24:00")
                {
                    if (!string.IsNullOrEmpty(mskHeureFin.Text))
                    {

                        if (ValiderHeure(mskHeureFin.Text) == false)
                        {
                            MessageBox.Show("L'heure de fin est invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if (ValiderDate(mskDate.Text) == false)
                {
                    MessageBox.Show("La date est invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(mskNoProjet.Text) | string.IsNullOrEmpty(mskDate.Text) | string.IsNullOrEmpty(mskHeureDebut.Text))
                {
                    MessageBox.Show("Champs vide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Droite(mskNoProjet.Text, 1) == "_")
                {
                    MessageBox.Show("Le numéro de projet est invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(cmbType.Text) & cmbType.Visible == true)
                {
                    MessageBox.Show("Le type est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rstPunch = new Recordset();
                if (m_eMode == EnumMode.MODE_AJOUT)
                {
                    rstPunch.Open("SELECT * FROM Punch", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstPunch.AddNew();
                }
                else
                {
                    rstPunch.Open("SELECT * FROM Punch WHERE IDPunch = " + m_lIDPunch, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                rstPunch.Fields["NoEmploye"].Value = IdNoEmploye;
                rstPunch.Fields["NoProjet"].Value = lblPrefixe.Text + mskNoProjet.Text;
                rstPunch.Fields["Date"].Value = mskDate.Text;
                rstPunch.Fields["HeureDébut"].Value = mskHeureDebut.Text;
                rstPunch.Fields["HeureFin"].Value = mskHeureFin.Text;
                if (chkKM.Checked)
                {
                    rstPunch.Fields["KM"].Value = true;
                    if (!string.IsNullOrEmpty(txtKM.Text))
                    {
                        txtKM.Text = Strings.Replace(txtKM.Text, ".", ",");
                        if (IsNumeric(txtKM.Text))
                        {
                            rstPunch.Fields["NbreKM"].Value = txtKM.Text;
                        }
                        else
                        {
                            rstPunch.Fields["NbreKM"].Value = 0;
                        }
                    }
                    else
                    {
                        txtKM.Text = 0.ToString();
                    }
                }
                else
                {
                    rstPunch.Fields["KM"].Value = false;
                    rstPunch.Fields["NbreKM"].Value = "";
                }
                if (!string.IsNullOrEmpty(txtClient.Text))
                {
                    rstPunch.Fields["NoClient"].Value = txtClient.Tag;
                }
                else
                {
                    rstPunch.Fields["NoClient"].Value = string.Empty;
                }
                if (IsNumeric(Droite(mskNoProjet.Text, 2)))
                {
                    if (int.Parse(Droite(mskNoProjet.Text, 2)) >= 51 & int.Parse(Droite(mskNoProjet.Text, 2)) <= 59)
                    {
                        bInstallation = true;
                    }
                    else
                    {
                        bInstallation = false;
                    }
                }
                else
                {
                    bInstallation = false;
                }
                if (bInstallation == true)
                {
                    if (lblPrefixe.Text == "E")
                    {
                        switch (cmbType.SelectedIndex)
                        {
                            case I_TYPE_ELEC_INSTALLATION:
                                {
                                    rstPunch.Fields["Type"].Value = "Installation";
                                    break;
                                }
                            case I_TYPE_ELEC_MISE_SERVICE:
                                {
                                    rstPunch.Fields["Type"].Value = "MiseService";
                                    break;
                                }
                        }
                    }
                    else
                    {
                        switch (cmbType.SelectedIndex)
                        {
                            case I_TYPE_MEC_INSTALLATION:
                                {
                                    rstPunch.Fields["Type"].Value = "Installation";
                                    break;
                                }
                        }
                    }
                }
                else if (lblPrefixe.Text == "E")
                {
                    rstPunch.Fields["Type"].Value = cmbType.Text;
                }
                else
                {
                    rstPunch.Fields["Type"].Value = cmbType.Text;
                }
                rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                rstPunch.Update();
                rstPunch.Close();
                rstPunch = null;
                ViderChamps();
                ActiverControles(EnumMode.MODE_INACTIF);
                RemplirListView();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "cmdEnregistrer_Click", ex);
            }
        }
        private bool ValiderDate(string sDate)
        {
            bool ValiderDateRet = default;
            try
            {
                if (!Information.IsDate(sDate))
                {
                    ValiderDateRet = false;
                }
                else
                {
                    ValiderDateRet = true;
                }
                return ValiderDateRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "ValiderDate", ex);
                return false;
            }
        }
        private bool ValiderHeure(string sHeure)
        {
            bool ValiderHeureRet = default;
            try
            {
                string sHour;
                string sMinute;
                string sSecond;
                sHour = Gauche(sHeure, 2);
                sMinute = sHeure.Substring(4, 2);
                sSecond = Droite(sHeure, 2);
                ValiderHeureRet = true;
                if (!IsNumeric(sHour))
                {
                    ValiderHeureRet = false;
                    return ValiderHeureRet;
                }
                else if (double.Parse(sHour) < 0d | double.Parse(sHour) > 23d)
                {
                    ValiderHeureRet = false;
                    return ValiderHeureRet;
                }
                if (!IsNumeric(sMinute))
                {
                    ValiderHeureRet = false;
                    return ValiderHeureRet;
                }
                else if (double.Parse(sMinute) < 0d | double.Parse(sMinute) > 59d)
                {
                    ValiderHeureRet = false;
                    return ValiderHeureRet;
                }
                if (!IsNumeric(sSecond))
                {
                    ValiderHeureRet = false;
                    return ValiderHeureRet;
                }
                else if (double.Parse(sSecond) < 0d | double.Parse(sSecond) > 59d)
                {
                    ValiderHeureRet = false;
                    return ValiderHeureRet;
                }
                return ValiderHeureRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "ValiderHeure", ex);
                return false;
            }
        }
        private void ViderChamps()
        {
            try
            {
                mskNoProjet.Text = "_____-__";
                mskDate.Text = string.Empty;
                mskHeureDebut.Text = string.Empty;
                mskHeureFin.Text = string.Empty;
                txtCommentaires.Text = string.Empty;
                txtClient.Text = string.Empty;
                chkKM.CheckState = CheckState.Unchecked;
                cmbType.SelectedIndex = -1;
                txtKM.Text = string.Empty;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "ViderChamps", ex);
            }
        }
        private void cmdexporter_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new ChoixDateImpressionFT();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "cmdExporter_Click", ex);
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
                AfficherErreur("FeuilleTemps", "cmdFermer_Click", ex);
            }
        }
        [Obsolete]
        public void RemplirListView()
        {
            try
            {
                SqlConnection sq = new SqlConnection(StringSQL);
                ListViewItem it = default(ListViewItem);
                sq.Open();
                double temps = 0d;
                if (cmbEmployé.SelectedIndex != -1)
                {
                    SqlDataReader rd = new SqlCommand($"SELECT  *,[DBO].[CLIENT].[NOMCLIENT] FROM [PUNCH] " +
                        $"JOIN [DBO].[CLIENT] ON[DBO].[CLIENT].[IDCLIENT] =[DBO].[PUNCH].[NOCLIENT]" +
                        $"WHERE NOEMPLOYE = '{Employes[cmbEmployé.SelectedIndex].Noemploye}' AND DATE BETWEEN '{m_datDebut}' and '{m_datFin}'" +
                        $" order by Date,HeureDébut ", sq).ExecuteReader();
                    while (rd.Read())
                    {
                        it = lvwPunch.Items.Add(string.Empty);
                        it.SubItems.Insert(0x00, new ListViewItem.ListViewSubItem(null, rd["NoProjet"].ToString()));
                        it.SubItems.Insert(I_LVW_DATE, new ListViewItem.ListViewSubItem(null, rd["Date"].ToString()));
                        it.SubItems.Insert(I_LVW_DEBUT, new ListViewItem.ListViewSubItem(null, rd["HeureDébut"].ToString()));
                        int deb = (int.Parse(rd["HeureDébut"].ToString().Split(':')[0]) * 60) + int.Parse(rd["HeureDébut"].ToString().Split(':')[1]);
                        it.SubItems.Insert(I_LVW_FIN, new ListViewItem.ListViewSubItem(null, rd["HeureFin"].ToString()));
                        int fin = (int.Parse(rd["HeureFin"].ToString().Split(':')[0]) * 60) + int.Parse(rd["HeureFin"].ToString().Split(':')[1]);
                        it.SubItems.Insert(I_LVW_CLIENT, new ListViewItem.ListViewSubItem(null, rd["nomclient"].ToString()));
                        it.SubItems[I_LVW_CLIENT].Tag = rd["noclient"].ToString();
                        it.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, rd["type"].ToString()));
                        it.SubItems.Insert(I_LVW_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, rd["Commentaire"].ToString()));
                        it.SubItems.Insert(I_LVW_COMMENTAIRE + 1, new ListViewItem.ListViewSubItem(null, rd["date"].ToString()));
                    }
                    rd.Close();
                }
                sq.Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "RemplirListView", ex);
            }
        }
        [Obsolete]
        private void FeuilleTemps_Load(object eventSender, EventArgs eventArgs)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            mvwDate.Value = DateTime.Today;
            lblType.AutoSize = true;
            lblType.BackColor = System.Drawing.Color.Black;
            lblType.Cursor = System.Windows.Forms.Cursors.Default;
            lblType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblType.ForeColor = System.Drawing.Color.White;
            lblType.Location = new System.Drawing.Point(286, 61);
            lblType.Name = "lblType";
            lblType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblType.Size = new System.Drawing.Size(36, 14);
            lblType.TabIndex = 32;
            lblType.Text = "Type :";
            lblPrefixe.BackColor = System.Drawing.Color.Black;
            lblPrefixe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrefixe.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrefixe.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrefixe.ForeColor = System.Drawing.Color.White;
            lblPrefixe.Location = new System.Drawing.Point(112, 53);
            lblPrefixe.Name = "lblPrefixe";
            lblPrefixe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrefixe.Size = new System.Drawing.Size(17, 19);
            lblPrefixe.TabIndex = 31;
            lblPrefixe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Controls.Add(lblPrefixe);
            Controls.Add(lblType);
            mskNoProjet.AllowPromptAsInput = false;
            mskNoProjet.BackColor = System.Drawing.Color.Black;
            mskNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskNoProjet.ForeColor = System.Drawing.Color.White;
            mskNoProjet.Location = new System.Drawing.Point(128, 53);
            mskNoProjet.Mask = "#####-##";
            mskNoProjet.Name = "mskNoProjet";
            mskNoProjet.Size = new System.Drawing.Size(65, 20);
            mskNoProjet.TabIndex = 8;
            mskNoProjet.TextChanged += new System.EventHandler(mskNoProjet_TextChanged);
            Controls.Add(mskNoProjet);
            ftCalendrier = lvwPunch;
            ftCmbType = cmbType;
            if (g_admin || IdGroupe == 27)
            {
                cmdAjouter.Enabled = true;
                CmdModifier.Enabled = true;
            }
            try
            {
                DateTime datTemp = DateTime.Today;
                RemplirComboEmploye();
                datTemp = DateTime.Today;
                m_datSemaine = GetFirstDay(datTemp);
                txtSemaine.Text = GetDateTexte(GetFirstDay(m_datSemaine));
                RemplirListView();
                RemplirComboType();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "Form_Load", ex);
            }
        }
        private void RemplirComboEmploye()
        {
            try
            {
                cmbEmployé.Items.Clear();
                foreach (DB_Employe p in Employes)
                {
                    cmbEmployé.Items.Add(new ListItem(p.Employes, p.Noemploye.ToString()));
                }
                if (cmbEmployé.Items.Count > 0)
                {
                    cmbEmployé.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "RemplirComboEmploye", ex);
            }
        }
        [Obsolete]
        private void lvwPunch_ItemClick(ListViewItem Item)
        {
            ADODB.Recordset rstPunch;
            int X;
            int G;
            if (lvwPunch.Items.Count > 0)
            {
                m_lIDPunch = int.Parse(Item.Tag.ToString());
                rstPunch = new Recordset();
                rstPunch.Open("SELECT * FROM Punch WHERE IDPunch = " + m_lIDPunch, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (Gauche((string)(rstPunch.Fields["NoProjet"].Value), 1) == "E")
                {
                    _optTypePunch_0.Checked = true;
                }
                else
                {
                    _optTypePunch_1.Checked = true;
                }
                m_bClick = true;
                mskNoProjet.Text = Droite((string)(rstPunch.Fields["NoProjet"].Value), 8);
                m_bClick = false;
                if (mskDate.Mask == "##-##-##") { mskDate.Mask = string.Empty; }
                mskDate.Text = (string)(rstPunch.Fields["Date"].Value);
                mskHeureDebut.Text = (string)(rstPunch.Fields["HeureDébut"].Value);
                if (!(rstPunch.Fields["HeureFin"].Value ?? ""))
                {
                    if (rstPunch.Fields["HeureFin"].Value != "")
                    {
                        mskHeureFin.Text = (string)(rstPunch.Fields["HeureFin"].Value);
                    }
                    else
                    {
                        mskHeureFin.Text = "__:__";
                    }
                }
                else
                {
                    mskHeureFin.Text = "__:__";
                }
                txtClient.Text = string.Empty;
                AfficherClient();
                if (!(rstPunch.Fields["Type"].Value ?? ""))
                {
                    cmbType.SelectedIndex = -1;
                    if (rstPunch.Fields["Type"].Value == "Installation")
                    {
                        cmbType.SelectedIndex = 0;
                        goto Quitter;
                    }
                    if (rstPunch.Fields["Type"].Value == "MiseService")
                    {
                        cmbType.SelectedIndex = 1;
                        goto Quitter;
                    }
                    if (Gauche((string)(rstPunch.Fields["NoProjet"].Value), 1) == "E")
                    {
                        for (G = 0; G <= (int)cmbType.Items.Count; G++)
                        {
                            if (cmbType.Items[G].ToString() == rstPunch.Fields["Type"].Value)
                            {
                                cmbType.SelectedIndex = G;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (G = 0; G <= (int)cmbType.Items.Count; G++)
                        {
                            if (cmbType.Items[G].ToString() == rstPunch.Fields["Type"].Value)
                            {
                                cmbType.SelectedIndex = G;
                                break;
                            }
                        }
                    }
                    goto Quitter;
                }
                if (!(rstPunch.Fields["Commentaire"].Value ?? ""))
                {
                    txtCommentaires.Text = (string)(rstPunch.Fields["Commentaire"].Value);
                }
                else
                {
                    txtCommentaires.Text = string.Empty;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["KM"].Value, true, false)))
                {
                    chkKM.CheckState = CheckState.Checked;
                    txtKM.Text = (string)(rstPunch.Fields["NbreKM"].Value);
                }
                else
                {
                    chkKM.CheckState = CheckState.Unchecked;
                    txtKM.Text = string.Empty;
                }
                rstPunch.Close();
                rstPunch = null;
                ActiverControles(EnumMode.MODE_MODIF);
            }
        Quitter:
            return;
        }
        private void lvwPunch_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (lvwPunch.Items.Count > 0)
                {
                    if (eventArgs.KeyCode == Keys.Delete)
                    {
                        if (MessageBox.Show("Voulez-vous vraiment effacer le punch?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateSQL("DELETE FROM Punch WHERE IDPunch = " + lvwPunch.FocusedItem.Tag);
                            RemplirListView();
                            ViderChamps();
                            if (lvwPunch.Items.Count > 0)
                            {
                                lvwPunch.Items[1].Selected = true;
                                lvwPunch_ItemClick(lvwPunch.FocusedItem);
                            }
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "lvwPunch_KeyDown", ex);
            }
        }
        private void mskNoProjet_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Strings.InStr(1, mskNoProjet.Text, "_") == 0)
                {
                    AfficherClient();
                }
                else
                {
                    txtClient.Text = string.Empty;
                }
                RemplirComboType();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "mskNoProjet_Change", ex);
            }
        }
        private void AfficherClient()
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstClient;
                int X;
                if (m_bClick == false)
                {
                    rstProjSoum = new Recordset();
                    rstClient = new Recordset();
                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + lblPrefixe.Text + mskNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstProjSoum.EOF)
                    {
                        rstClient.Open(Operators.ConcatenateObject("SELECT NomClient FROM Client WHERE IDClient = ", rstProjSoum.Fields["NoClient"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        txtClient.Text = (string)(rstClient.Fields["NomClient"].Value);
                        txtClient.Tag = rstProjSoum.Fields["NoClient"].Value;
                        rstClient.Close();
                        rstClient = null;
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["Ouvert"].Value, false, false)))
                        {
                            MessageBox.Show("Ce projet n'est pas ouvert!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Projet inexistant!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rstProjSoum.Close();
                    rstProjSoum = null;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "AfficherClient", ex);
            }
        }
        private void mvwDate_DateClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskDate.Text = ConvertDate(mvwDate.Value);

                ((dynamic)mvwDate).Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "mvwDate_DateClick", ex);
            }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new ChoixImpressionFT(m_datSemaine, GetLastDay(m_datSemaine));
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "cmdImprimer_Click", ex);
            }
        }
        [Obsolete]
        private void mskDate_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
//Suppression de l'annee sur 2 octets
//PWE 2024-03-06
return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "mskDate_GotFocus", ex);
            }
        }
        private void mskHeureDebut_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskHeureDebut.Mask = "##:##";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "mskHeureDebut_GotFocus", ex);
            }
        }
        private void mskHeureFin_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskHeureFin.Mask = "##:##";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "mskHeureFin_GotFocus", ex);
            }
        }
        [Obsolete]
        private void mskDate_Leave(object eventSender, EventArgs eventArgs)
        {
//intule de reformater l'heure sur 4 octets vu la suppression de la date sur 2 octets
            try
            {
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "mskDate_LostFocus", ex);
            }
        }
        private void mskHeureDebut_Leave(object eventSender, EventArgs eventArgs)
        {
            DateTime heure;
            try
            {
                mskHeureDebut.Mask = string.Empty;
                if (mskHeureDebut.Text == "__:__")
                {
                    mskHeureDebut.Text = string.Empty;
                }
                else
                {
                    heure = Conversions.ToDate(mskHeureDebut.Text);
                    if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure) <= 5){heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 0, 0);}
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure) <= 24){heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 15, 0);}
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure) <= 35){heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 30, 0);}
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure) <= 54){heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 45, 0);}
                    else{heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure) + 1, 0, 0);}
                    mskHeureDebut.Text = Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 2) + ":" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure), 2);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "mskHeureDebut_LostFocus", ex);
            }
        }
        private void mskHeureFin_Leave(object eventSender, EventArgs eventArgs)
        {
            DateTime heure;
            try
            {
                mskHeureFin.Mask = string.Empty;
                if (mskHeureFin.Text == "__:__")
                {
                    mskHeureFin.Text = string.Empty;
                }
                else
                {
                    heure = Conversions.ToDate(mskHeureFin.Text);
                    if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure) <= 5){heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 0, 0);}
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure) <= 24){heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 15, 0);}
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure) <= 35){heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 30, 0);}
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure) <= 54){heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 45, 0);}
                    else{heure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure) + 1, 0, 0);}
                    mskHeureFin.Text = Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(heure), 2) + ":" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(heure), 2);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "mskHeureFin_LostFocus", ex);
            }
        }
        private void txtKM_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtKM.Text = txtKM.Text.Replace( ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "txtKM_LostFocus", ex);
            }
        }
bool bInstallation;
bool bTypeInutile;
        public void RemplirComboType()
        {
  
                Recordset tbltype= new Recordset();
                cmbType.Items.Clear();
                if (mskNoProjet.Text.Substring(2, 1) == "1")
                {
                    bTypeInutile = true;
                }
                if (IsNumeric(Droite(mskNoProjet.Text, 2)))
                {
                    if (mskNoProjet.Text.Substring(2, 4) != "3000")
                    {
                        if (int.Parse(Droite(mskNoProjet.Text, 2)) >= 51 & int.Parse(Droite(mskNoProjet.Text, 2)) <= 59)
                        {
                            bInstallation = true;
                        }
                    }
                    else
                    {
                        bTypeInutile = true;
                    }
                }
                if (bTypeInutile == false)
                {
                    lblType.Visible = true;
                    cmbType.Visible = true;
                    if (bInstallation == true)
                    {
                        if (lblPrefixe.Text == "E")
                        {
                            cmbType.Items.Add("Installation");
                            cmbType.Items.Add("Mise en service");
                        }
                        else
                        {
                            cmbType.Items.Add("Installation");
                        }
                    }
                    else if (lblPrefixe.Text == "E")
                    {
                        tbltype.Open("select * FROM TBL_Punch_Type Where Mode = 'E' Order by name", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        while (!tbltype.EOF)
                        {
                            cmbType.Items.Add(tbltype.Fields["Name"].Value);
                            tbltype.MoveNext();
                        }
                        tbltype.Close();
                        
                        tbltype = null;
                    }
                    else
                    {
                        tbltype.Open("select * FROM TBL_Punch_Type Where Mode = 'M' Order by name ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        while (!tbltype.EOF)
                        {
                            cmbType.Items.Add(tbltype.Fields["Name"].Value);
                            tbltype.MoveNext();
                        }
                        tbltype.Close();
                        
                        tbltype = null;
                    }
                }
                else
                {
                    lblType.Visible = false;
                    cmbType.Visible = false;
                }
                try
            {          return;
            }
            catch (Exception ex)
            {
                AfficherErreur("FeuilleTemps", "RemplirComboType", ex);
            }
        }
        private void mvwDate_ValueChanged(object sender, EventArgs e)
        {
            txtSemaine.Text = GetSemaineDelaDate(GetFirstDay(mvwDate.Value));
            Text = $"Feuille de temps pour {cmbEmployé.Text} dans la {txtSemaine.Text}";
            mvwDate.Visible = false;
            lvwPunch.Items.Clear();
            RemplirListView();
        }
        private void lvwPunch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lvwPunch_Click(object sender, EventArgs e)
        {
            lblPrefixe.Text = lvwPunch.FocusedItem.Text[0].ToString();
            if (lblPrefixe.Text == "E")
            {
                _optTypePunch_0.Checked = true; _optTypePunch_1.Checked = false;
            }
            else
            {
                _optTypePunch_1.Checked = true; _optTypePunch_0.Checked = false;
            }
            txtNoProjet.Text = lvwPunch.FocusedItem.Text.ToUpper();
            mskDate.Text = lvwPunch.FocusedItem.SubItems[1].Text;
            mskHeureDebut.Text = lvwPunch.FocusedItem.SubItems[2].Text;
            mskHeureFin.Text = lvwPunch.FocusedItem.SubItems[3].Text;
            txtClient.Text = lvwPunch.FocusedItem.SubItems[4].Text;
            cmbType.Text = lvwPunch.FocusedItem.SubItems[5].Text;
            txtCommentaires.Text = lvwPunch.FocusedItem.SubItems[6].Text;
        }
        private void txtSemaine_TextChanged(object sender, EventArgs e)
        {
        }
    }
}