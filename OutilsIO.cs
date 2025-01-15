using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ControleurServeur;
using System.Diagnostics;
using ADODB;

namespace ControleurServeur
{
    internal class Outils_InOut : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public Outils_InOut() : base()
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
        internal CheckBox chknonRetour;
        internal Button cmdsortie;
        internal ComboBox cmbemployé;
        internal Button cmdConfig;
        internal Button CmdFerme;
        internal ColumnHeader _lstoutils_ColumnHeader_1;
        internal ColumnHeader _lstoutils_ColumnHeader_2;
        internal ColumnHeader _lstoutils_ColumnHeader_3;
        internal ColumnHeader _lstoutils_ColumnHeader_4;
        internal ColumnHeader _lstoutils_ColumnHeader_5;
        internal ColumnHeader _lstoutils_ColumnHeader_6;
        internal ColumnHeader _lstoutils_ColumnHeader_7;
        internal ListView lstoutils;
        internal Button cmdreport;
        internal Button cmdretour;
        internal TextBox txtcommentaire;
        internal Button CmdEnr;
        internal TextBox txtnom;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal GroupBox fraOutils;
        private Panel panel1;
        internal ComboBox cmbDepartement;
        private DateTimePicker txtdepart;
        private Label label8;
        private GroupBox groupBox1;
        private ListView listView1;
        internal Label lblemployé;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chknonRetour = new System.Windows.Forms.CheckBox();
            this.cmdsortie = new System.Windows.Forms.Button();
            this.cmbemployé = new System.Windows.Forms.ComboBox();
            this.cmdConfig = new System.Windows.Forms.Button();
            this.CmdFerme = new System.Windows.Forms.Button();
            this.lstoutils = new System.Windows.Forms.ListView();
            this._lstoutils_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdreport = new System.Windows.Forms.Button();
            this.cmdretour = new System.Windows.Forms.Button();
            this.fraOutils = new System.Windows.Forms.GroupBox();
            this.cmbDepartement = new System.Windows.Forms.ComboBox();
            this.txtdepart = new System.Windows.Forms.DateTimePicker();
            this.txtno = new System.Windows.Forms.ComboBox();
            this.txtsortie = new System.Windows.Forms.DateTimePicker();
            this.txtcommentaire = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.CmdEnr = new System.Windows.Forms.Button();
            this.lblemployé = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.fraOutils.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chknonRetour
            // 
            this.chknonRetour.AutoSize = true;
            this.chknonRetour.BackColor = System.Drawing.Color.Black;
            this.chknonRetour.Checked = true;
            this.chknonRetour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chknonRetour.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chknonRetour.ForeColor = System.Drawing.Color.White;
            this.chknonRetour.Location = new System.Drawing.Point(292, 182);
            this.chknonRetour.Name = "chknonRetour";
            this.chknonRetour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chknonRetour.Size = new System.Drawing.Size(141, 18);
            this.chknonRetour.TabIndex = 19;
            this.chknonRetour.Text = "Outils non retournés";
            this.chknonRetour.UseVisualStyleBackColor = true;
            this.chknonRetour.CheckStateChanged += new System.EventHandler(this.chknonRetour_CheckStateChanged);
            // 
            // cmdsortie
            // 
            this.cmdsortie.BackColor = System.Drawing.Color.Black;
            this.cmdsortie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdsortie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsortie.ForeColor = System.Drawing.Color.White;
            this.cmdsortie.Location = new System.Drawing.Point(353, 108);
            this.cmdsortie.Name = "cmdsortie";
            this.cmdsortie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdsortie.Size = new System.Drawing.Size(96, 29);
            this.cmdsortie.TabIndex = 22;
            this.cmdsortie.Text = "&Sortier l\'outil";
            this.cmdsortie.UseVisualStyleBackColor = true;
            this.cmdsortie.Click += new System.EventHandler(this.cmdsortie_Click);
            // 
            // cmbemployé
            // 
            this.cmbemployé.BackColor = System.Drawing.Color.White;
            this.cmbemployé.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbemployé.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbemployé.ForeColor = System.Drawing.Color.Navy;
            this.cmbemployé.Location = new System.Drawing.Point(128, 180);
            this.cmbemployé.Name = "cmbemployé";
            this.cmbemployé.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbemployé.Size = new System.Drawing.Size(145, 22);
            this.cmbemployé.Sorted = true;
            this.cmbemployé.TabIndex = 18;
            this.cmbemployé.SelectedIndexChanged += new System.EventHandler(this.cmbEmployé_SelectedIndexChanged);
            // 
            // cmdConfig
            // 
            this.cmdConfig.BackColor = System.Drawing.Color.Black;
            this.cmdConfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdConfig.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfig.ForeColor = System.Drawing.Color.White;
            this.cmdConfig.Location = new System.Drawing.Point(420, 10);
            this.cmdConfig.Name = "cmdConfig";
            this.cmdConfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdConfig.Size = new System.Drawing.Size(112, 29);
            this.cmdConfig.TabIndex = 24;
            this.cmdConfig.Text = "&Configuration Outils";
            this.cmdConfig.UseVisualStyleBackColor = true;
            this.cmdConfig.Click += new System.EventHandler(this.cmdConfig_Click);
            // 
            // CmdFerme
            // 
            this.CmdFerme.BackColor = System.Drawing.Color.Black;
            this.CmdFerme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdFerme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFerme.ForeColor = System.Drawing.Color.White;
            this.CmdFerme.Location = new System.Drawing.Point(1071, 8);
            this.CmdFerme.Name = "CmdFerme";
            this.CmdFerme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdFerme.Size = new System.Drawing.Size(96, 29);
            this.CmdFerme.TabIndex = 25;
            this.CmdFerme.Text = "&Fermer";
            this.CmdFerme.UseVisualStyleBackColor = true;
            this.CmdFerme.Click += new System.EventHandler(this.CmdFerme_Click);
            // 
            // lstoutils
            // 
            this.lstoutils.BackColor = System.Drawing.Color.Black;
            this.lstoutils.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lstoutils_ColumnHeader_1,
            this._lstoutils_ColumnHeader_2,
            this._lstoutils_ColumnHeader_3,
            this._lstoutils_ColumnHeader_4,
            this._lstoutils_ColumnHeader_5,
            this._lstoutils_ColumnHeader_6,
            this._lstoutils_ColumnHeader_7});
            this.lstoutils.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstoutils.ForeColor = System.Drawing.Color.White;
            this.lstoutils.FullRowSelect = true;
            this.lstoutils.GridLines = true;
            this.lstoutils.HideSelection = false;
            this.lstoutils.Location = new System.Drawing.Point(13, 58);
            this.lstoutils.Name = "lstoutils";
            this.lstoutils.Size = new System.Drawing.Size(1154, 270);
            this.lstoutils.TabIndex = 20;
            this.lstoutils.UseCompatibleStateImageBehavior = false;
            this.lstoutils.View = System.Windows.Forms.View.Details;
            this.lstoutils.SelectedIndexChanged += new System.EventHandler(this.lstoutils_SelectedIndexChanged);
            // 
            // _lstoutils_ColumnHeader_1
            // 
            this._lstoutils_ColumnHeader_1.Text = "No";
            this._lstoutils_ColumnHeader_1.Width = 59;
            // 
            // _lstoutils_ColumnHeader_2
            // 
            this._lstoutils_ColumnHeader_2.Text = "Nom";
            this._lstoutils_ColumnHeader_2.Width = 384;
            // 
            // _lstoutils_ColumnHeader_3
            // 
            this._lstoutils_ColumnHeader_3.Text = "Employé";
            this._lstoutils_ColumnHeader_3.Width = 236;
            // 
            // _lstoutils_ColumnHeader_4
            // 
            this._lstoutils_ColumnHeader_4.Text = "Sortie";
            this._lstoutils_ColumnHeader_4.Width = 189;
            // 
            // _lstoutils_ColumnHeader_5
            // 
            this._lstoutils_ColumnHeader_5.Text = "Retour";
            this._lstoutils_ColumnHeader_5.Width = 189;
            // 
            // _lstoutils_ColumnHeader_6
            // 
            this._lstoutils_ColumnHeader_6.Text = "Département";
            this._lstoutils_ColumnHeader_6.Width = 170;
            // 
            // _lstoutils_ColumnHeader_7
            // 
            this._lstoutils_ColumnHeader_7.Text = "Commentaire";
            this._lstoutils_ColumnHeader_7.Width = 353;
            // 
            // cmdreport
            // 
            this.cmdreport.BackColor = System.Drawing.Color.Black;
            this.cmdreport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdreport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdreport.ForeColor = System.Drawing.Color.White;
            this.cmdreport.Location = new System.Drawing.Point(44, 10);
            this.cmdreport.Name = "cmdreport";
            this.cmdreport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdreport.Size = new System.Drawing.Size(96, 29);
            this.cmdreport.TabIndex = 21;
            this.cmdreport.Text = "&Impression";
            this.cmdreport.UseVisualStyleBackColor = true;
            this.cmdreport.Click += new System.EventHandler(this.cmdreport_Click);
            // 
            // cmdretour
            // 
            this.cmdretour.BackColor = System.Drawing.Color.Black;
            this.cmdretour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdretour.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdretour.ForeColor = System.Drawing.Color.White;
            this.cmdretour.Location = new System.Drawing.Point(353, 140);
            this.cmdretour.Name = "cmdretour";
            this.cmdretour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdretour.Size = new System.Drawing.Size(96, 29);
            this.cmdretour.TabIndex = 23;
            this.cmdretour.Text = "&Retourner l\'outil";
            this.cmdretour.UseVisualStyleBackColor = true;
            this.cmdretour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // fraOutils
            // 
            this.fraOutils.BackColor = System.Drawing.Color.Black;
            this.fraOutils.Controls.Add(this.cmbDepartement);
            this.fraOutils.Controls.Add(this.cmdsortie);
            this.fraOutils.Controls.Add(this.txtdepart);
            this.fraOutils.Controls.Add(this.cmdretour);
            this.fraOutils.Controls.Add(this.txtno);
            this.fraOutils.Controls.Add(this.txtsortie);
            this.fraOutils.Controls.Add(this.chknonRetour);
            this.fraOutils.Controls.Add(this.txtcommentaire);
            this.fraOutils.Controls.Add(this.cmbemployé);
            this.fraOutils.Controls.Add(this.txtnom);
            this.fraOutils.Controls.Add(this.Label7);
            this.fraOutils.Controls.Add(this.Label6);
            this.fraOutils.Controls.Add(this.Label5);
            this.fraOutils.Controls.Add(this.Label4);
            this.fraOutils.Controls.Add(this.Label3);
            this.fraOutils.Controls.Add(this.Label2);
            this.fraOutils.Controls.Add(this.Label1);
            this.fraOutils.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraOutils.ForeColor = System.Drawing.Color.White;
            this.fraOutils.Location = new System.Drawing.Point(12, 334);
            this.fraOutils.Name = "fraOutils";
            this.fraOutils.Padding = new System.Windows.Forms.Padding(0);
            this.fraOutils.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraOutils.Size = new System.Drawing.Size(477, 281);
            this.fraOutils.TabIndex = 1;
            this.fraOutils.TabStop = false;
            // 
            // cmbDepartement
            // 
            this.cmbDepartement.BackColor = System.Drawing.Color.White;
            this.cmbDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartement.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartement.ForeColor = System.Drawing.Color.Navy;
            this.cmbDepartement.Location = new System.Drawing.Point(127, 85);
            this.cmbDepartement.Name = "cmbDepartement";
            this.cmbDepartement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDepartement.Size = new System.Drawing.Size(145, 22);
            this.cmbDepartement.Sorted = true;
            this.cmbDepartement.TabIndex = 23;
            // 
            // txtdepart
            // 
            this.txtdepart.Location = new System.Drawing.Point(128, 149);
            this.txtdepart.Name = "txtdepart";
            this.txtdepart.Size = new System.Drawing.Size(144, 22);
            this.txtdepart.TabIndex = 22;
            // 
            // txtno
            // 
            this.txtno.ForeColor = System.Drawing.Color.Navy;
            this.txtno.FormattingEnabled = true;
            this.txtno.Location = new System.Drawing.Point(128, 21);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(321, 22);
            this.txtno.TabIndex = 21;
            this.txtno.SelectedIndexChanged += new System.EventHandler(this.txtno_SelectedIndexChanged);
            // 
            // txtsortie
            // 
            this.txtsortie.Location = new System.Drawing.Point(128, 120);
            this.txtsortie.Name = "txtsortie";
            this.txtsortie.Size = new System.Drawing.Size(144, 22);
            this.txtsortie.TabIndex = 20;
            // 
            // txtcommentaire
            // 
            this.txtcommentaire.AcceptsReturn = true;
            this.txtcommentaire.BackColor = System.Drawing.Color.White;
            this.txtcommentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcommentaire.ForeColor = System.Drawing.Color.Navy;
            this.txtcommentaire.Location = new System.Drawing.Point(128, 216);
            this.txtcommentaire.MaxLength = 0;
            this.txtcommentaire.Multiline = true;
            this.txtcommentaire.Name = "txtcommentaire";
            this.txtcommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcommentaire.Size = new System.Drawing.Size(305, 51);
            this.txtcommentaire.TabIndex = 17;
            // 
            // txtnom
            // 
            this.txtnom.AcceptsReturn = true;
            this.txtnom.BackColor = System.Drawing.Color.White;
            this.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.Enabled = false;
            this.txtnom.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.ForeColor = System.Drawing.Color.Navy;
            this.txtnom.Location = new System.Drawing.Point(128, 56);
            this.txtnom.MaxLength = 0;
            this.txtnom.Name = "txtnom";
            this.txtnom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnom.Size = new System.Drawing.Size(321, 22);
            this.txtnom.TabIndex = 4;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(40, 216);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(137, 17);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Commentaire";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Black;
            this.Label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(40, 184);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(137, 17);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "Employé";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(40, 88);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(137, 17);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Département";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Black;
            this.Label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(40, 152);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(137, 17);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Retour";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(40, 120);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(137, 17);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Sortie";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(40, 56);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(137, 17);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Nom";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(40, 24);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(49, 14);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "No Outil";
            // 
            // CmdEnr
            // 
            this.CmdEnr.BackColor = System.Drawing.Color.Black;
            this.CmdEnr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdEnr.ForeColor = System.Drawing.Color.Navy;
            this.CmdEnr.Location = new System.Drawing.Point(216, 6);
            this.CmdEnr.Name = "CmdEnr";
            this.CmdEnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdEnr.Size = new System.Drawing.Size(97, 33);
            this.CmdEnr.TabIndex = 8;
            this.CmdEnr.Text = "&Enregistrer";
            this.CmdEnr.UseVisualStyleBackColor = true;
            this.CmdEnr.Click += new System.EventHandler(this.CmdEnr_Click);
            // 
            // lblemployé
            // 
            this.lblemployé.AutoSize = true;
            this.lblemployé.BackColor = System.Drawing.Color.Black;
            this.lblemployé.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployé.ForeColor = System.Drawing.Color.White;
            this.lblemployé.Location = new System.Drawing.Point(321, 19);
            this.lblemployé.Name = "lblemployé";
            this.lblemployé.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblemployé.Size = new System.Drawing.Size(78, 23);
            this.lblemployé.TabIndex = 0;
            this.lblemployé.Text = "Employé";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdConfig);
            this.panel1.Controls.Add(this.cmdreport);
            this.panel1.Controls.Add(this.CmdFerme);
            this.panel1.Controls.Add(this.CmdEnr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 42);
            this.panel1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 14);
            this.label8.TabIndex = 27;
            this.label8.Text = "Opérateur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(495, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 280);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outils I/O";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(651, 246);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Outils_InOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1179, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstoutils);
            this.Controls.Add(this.fraOutils);
            this.Controls.Add(this.lblemployé);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Outils_InOut";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.Outils_InOut";
            this.Load += new System.EventHandler(this.Outils_InOut_Load);
            this.fraOutils.ResumeLayout(false);
            this.fraOutils.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private DateTimePicker txtsortie;
        private ComboBox txtno;
        int idEmployeOutil = 0;
        int idOutil = 0;
        private void chknonRetour_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                remplir_lister_outils();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "chknonRetour_Click", ex);
            }
        }
        private void RemplirListerIO()
        {
            ADODB.Recordset rst= new Recordset(); 
            rst.Open("SELECT *  FROM [DBO].[OUTILS_IN_OUT] JOIN EMPLOYÉS ON OUTILS_IN_OUT.NO_EMPLOYE=EMPLOYÉS.NOEMPLOYE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            listView1.Columns.Clear();
            if (!rst.EOF)
            {
                for(int c=0; c<6; c++)
                {
                    listView1.Columns.Add(rst.Fields[c].Name);
                }
            }
            while (!rst.EOF) 
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[0].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[9].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[2].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[3].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[4].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[5].Value}"));
                rst.MoveNext();
            }
            rst.Close();
            rst = null; return;
        }
        private void cmbEmployé_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                idEmployeOutil = GetEmployeID(cmbemployé.Text);
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "cmbEmployé_Click", ex);
            }
        }
        private void CmdAnul_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraOutils.Visible = true;
                lstoutils.Visible = true;
                cmbemployé.Visible = true;
                lblemployé.Visible = true;
                chknonRetour.Visible = true;// remplis le lister
                remplir_lister_outils(); return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "CmdAnul_Click", ex);
            }
        }
        private void cmdConfig_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Form f = new outils();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                Cursor.Current = Cursors.Default; return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "cmdConfig_Click", ex);
            }
        }
        private void CmdEnr_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstOutils;
                ADODB.Recordset rstOutilsInOut;
                Cursor.Current = Cursors.WaitCursor; 
                if (IsNumeric(txtno.Text))
                {
                    rstOutils = new Recordset(); rstOutils.Open("SELECT * FROM outils WHERE no_outils = '" + txtno.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);    // si existe on peut l'ajouter
                    if (!rstOutils.EOF)
                    {
                        rstOutilsInOut = new Recordset();
                        rstOutilsInOut.Open("SELECT OUTILS_IN_OUT.*, EMPLOYÉS.EMPLOYE FROM OUTILS_IN_OUT " +
                            "INNER JOIN EMPLOYÉS ON OUTILS_IN_OUT.NO_EMPLOYE = EMPLOYÉS.NOEMPLOYE " +
                            "WHERE NO_OUTILS = " + txtno.Text + " AND retour_date_heure is null", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (rstOutilsInOut.EOF)
                        {
                            rstOutilsInOut.AddNew(); rstOutilsInOut.Fields["no_outils"].Value = txtno.Text;
                            rstOutilsInOut.Fields["no_employe"].Value = cmbDepartement.Tag;
                            rstOutilsInOut.Fields["depart_date_heure"].Value = txtdepart.Text;
                            rstOutilsInOut.Fields["commentaire"].Value = txtcommentaire.Text; rstOutilsInOut.Update();
                            vider_champs();
                        }
                        else if (MessageBox.Show($"L'outils n'a pas été retourné par {rstOutilsInOut.Fields["employe"].Value}\n voulez-vous retourner l'outil pour cet employé?" +
                            $"\n\n{rstOutils.Fields["no_outils"].Value}={rstOutils.Fields["nom_outils"].Value}", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            rstOutilsInOut.Fields["commentaire"].Value = $"(Retourné par: {IdNomEmploye}) {rstOutilsInOut.Fields["commentaire"].Value}";
                            rstOutilsInOut.Fields["retour_date_heure"].Value = DateTime.Now.ToString();
                            rstOutilsInOut.Update();
                            rstOutilsInOut.AddNew();
                            rstOutilsInOut.Fields["no_outils"].Value = txtno.Text;
                            rstOutilsInOut.Fields["no_employe"].Value = cmbDepartement.Tag;
                            rstOutilsInOut.Fields["depart_date_heure"].Value = txtdepart.Text;
                            rstOutilsInOut.Fields["commentaire"].Value = txtcommentaire.Text;
                            rstOutilsInOut.Update();
                            vider_champs();
                        }
                        rstOutilsInOut.Close(); rstOutilsInOut = null; txtno.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Le numéro de l'outil n'existe pas!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Le numéro doit être numérique!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                Cursor.Current = Cursors.Default; return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "CmdEnr_Click", ex);
            }
        }
        private void CmdFerme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close(); return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "CmdFerme_Click", ex);
            }
        }
        private void InitListeSortie()
        {
            lstoutils.Visible = true;
            ListViewItem itmOutils;
            lstoutils.Items.Clear();
            lstoutils.Sorting = SortOrder.Descending;
            ADODB.Recordset rstOutilsInOut = new ADODB.Recordset();
            rstOutilsInOut.Open("select no_outils, nom_outils, departement, type_étiquette, date_achat, date_hors_fonction," +
                " commentaire FROM [DBO].[Outils] order by no_outils", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            lstoutils.Columns.Clear();
            if (!rstOutilsInOut.EOF)
            {
                for (int a = 0; a < rstOutilsInOut.Fields.Count; a++)
                {
                    lstoutils.Columns.Add(rstOutilsInOut.Fields[a].Name);
                }
            }
            while (!rstOutilsInOut.EOF)
            {
                itmOutils = lstoutils.Items.Add(string.Empty);
                for (int a = 0; a < rstOutilsInOut.Fields.Count; a++)
                {
                    if (itmOutils.SubItems.Count > a)
                    {
                        itmOutils.SubItems[a].Text = $"{rstOutilsInOut.Fields[a].Value}";
                    }
                    else
                    {
                        itmOutils.SubItems.Insert(a, new ListViewItem.ListViewSubItem(null, $"{rstOutilsInOut.Fields[a].Value}"));
                    }
                }
                rstOutilsInOut.MoveNext();
            }
            lstoutils.Refresh();
            rstOutilsInOut.Close();
            rstOutilsInOut = null;
            return;
        }
        public void remplir_lister_outils()
        {
            try
            {
                ADODB.Recordset rstOutils;
                ADODB.Recordset rstOutilsInOut;
                ADODB.Recordset rstEmploye;
                ListViewItem itmOutils;
                lstoutils.Items.Clear();
                lstoutils.Columns.Clear();
                lstoutils.Sorting = SortOrder.None; rstOutilsInOut = new Recordset();
                if (cmbemployé.Text == "*")
                {
                    if (chknonRetour.Checked)
                    {
                        rstOutilsInOut.Open("SELECT * FROM outils_in_out WHERE retour_date_heure is null ORDER BY no_enreg",
                            odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstOutilsInOut.Open("SELECT * FROM outils_in_out ORDER BY no_enreg", odbc, CursorTypeEnum.adOpenDynamic,
                            LockTypeEnum.adLockOptimistic);
                    }
                }
                else if (chknonRetour.Checked)
                {
                    rstOutilsInOut.Open("SELECT * FROM outils_in_out WHERE no_employe=" + GetEmployeID(cmbemployé.Text) +
                        " AND retour_date_heure is null ORDER BY no_enreg", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstOutilsInOut.Open("SELECT * FROM outils_in_out WHERE no_employe = '" + GetEmployeID(cmbemployé.Text) +
                        "' ORDER BY no_enreg", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                rstOutils = new Recordset();
                rstEmploye = new Recordset();
                if (!rstOutilsInOut.EOF)
                {
                    for (int a = 0; a < rstOutilsInOut.Fields.Count; a++)
                    {
                        lstoutils.Columns.Add(rstOutilsInOut.Fields[a].Name);
                    }
                }
                while (!rstOutilsInOut.EOF)
                {
                    rstOutils.Open("SELECT * FROM outils WHERE no_outils = '" + rstOutilsInOut.Fields["no_outils"].Value +
"' ORDER BY no_outils", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstEmploye.Open("SELECT * FROM employés WHERE noemploye='" + rstOutilsInOut.Fields["no_employe"].Value +
"' ORDER BY noemploye", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    itmOutils = lstoutils.Items.Add(""); 
                    itmOutils.Text = (string)(rstOutils.Fields["no_outils"].Value);
                    itmOutils.Tag = rstOutilsInOut.Fields["no_enreg"].Value; 
                    itmOutils.SubItems.Add(rstOutils.Fields["nom_outils"].Value);
                    itmOutils.SubItems.Add(rstEmploye.Fields["employe"].Value); 
                    itmOutils.SubItems[2].Tag = rstEmploye.Fields["loginname"].Value;
                    itmOutils.SubItems.Add(rstOutilsInOut.Fields["depart_date_heure"].Value);
                    itmOutils.SubItems.Add(rstOutilsInOut.Fields["loginname"].Value);
                    itmOutils.SubItems.Add(rstOutilsInOut.Fields["no_enreg"].Value);
                    if (rstOutilsInOut.Fields["retour_date_heure"].Value is DBNull)
                    {
                        itmOutils.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmOutils.SubItems.Add(rstOutilsInOut.Fields["retour_date_heure"].Value);
                    }
                    itmOutils.SubItems.Add(rstOutils.Fields["departement"].Value);
                    itmOutils.SubItems.Add(rstOutilsInOut.Fields["commentaire"].Value); rstOutilsInOut.MoveNext();
                    rstOutils.Close();
                    rstEmploye.Close();
                }
                lstoutils.Refresh();
                rstOutils = null; rstEmploye = null;
                rstOutilsInOut.Close(); rstOutilsInOut = null; return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "remplir_lister_outils", ex);
            }
        }
        public void remplir_cmbemploye()
        {
            try
            {
                ADODB.Recordset rstEmploye; rstEmploye = new Recordset(); rstEmploye.Open("SELECT NoEmploye, Employe FROM employés WHERE actif=1 ORDER BY employe",
                    odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); 
                cmbemployé.Items.Clear(); 
                cmbemployé.Items.Add("*");
                while(!rstEmploye.EOF)
                {
                    cmbemployé.Items.Add($"{rstEmploye.Fields["noEmploye"].Value}-{rstEmploye.Fields["employe"].Value}");
                    rstEmploye.MoveNext();
                }
                rstEmploye.Close(); 
                rstEmploye = null; return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "remplir_cmbemploye", ex);
            }
        }
        [Obsolete]
        private void cmdreport_Click(object eventSender, EventArgs eventArgs)
        {
            ADODB.Recordset rstOutilsInOut = new ADODB.Recordset();
            ControleurServeur.ViewOutilsInOut f = new ControleurServeur.ViewOutilsInOut();
            if (cmbemployé.Text == "*")
            {
                if (chknonRetour.Checked)
                {
                    rstOutilsInOut.Open("SELECT OUTILS_IN_OUT.*, EMPLOYÉS.EMPLOYE, OUTILS.NOM_OUTILS, OUTILS.DEPARTEMENT FROM EMPLOYÉS " +
                        "INNER JOIN (OUTILS_IN_OUT INNER JOIN OUTILS ON OUTILS_IN_OUT.NO_OUTILS = OUTILS.NO_OUTILS) " +
                        "ON EMPLOYÉS.NOEMPLOYE = OUTILS_IN_OUT.NO_EMPLOYE WHERE RETOUR_DATE_HEURE IS NULL ORDER BY NO_ENREG", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstOutilsInOut.Open("SELECT OUTILS_IN_OUT.*, EMPLOYÉS.EMPLOYE, OUTILS.NOM_OUTILS, OUTILS.DEPARTEMENT FROM EMPLOYÉS" +
                        " INNER JOIN (OUTILS_IN_OUT INNER JOIN OUTILS ON OUTILS_IN_OUT.NO_OUTILS = OUTILS.NO_OUTILS) " +
                        "ON EMPLOYÉS.NOEMPLOYE = OUTILS_IN_OUT.NO_EMPLOYE ORDER BY NO_ENREg", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
            }
            else if (chknonRetour.Checked)
            {
                rstOutilsInOut.Open("SELECT OUTILS_IN_OUT.*, EMPLOYÉS.EMPLOYE, OUTILS.NOM_OUTILS,OUTILS.DEPARTEMENT FROM EMPLOYÉS" +
                    " INNER JOIN (OUTILS_IN_OUT INNER JOIN OUTILS ON OUTILS_IN_OUT.NO_OUTILS =OUTILS.NO_OUTILS) ON EMPLOYÉS.NOEMPLOYE " +
                    "= OUTILS_IN_OUT.NO_EMPLOYE WHERE NO_EMPLOYE = '" + idEmployeOutil + "' AND retour_date_heure is null ORDER BY no_enreg", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else
            {
                rstOutilsInOut.Open("SELECT OUTILS_IN_OUT.*, EMPLOYÉS.EMPLOYE, OUTILS.NOM_OUTILS, OUTILS.DEPARTEMENT FROM EMPLOYÉS " +
                    "INNER JOIN (OUTILS_IN_OUT INNER JOIN OUTILS ON OUTILS_IN_OUT.NO_OUTILS = OUTILS.NO_OUTILS) ON EMPLOYÉS.NOEMPLOYE =" +
                    " OUTILS_IN_OUT.NO_EMPLOYE WHERE NO_EMPLOYE ='" + idEmployeOutil + "' ORDER BY no_enreg", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                f.DataSource = rstOutilsInOut;
                if (chknonRetour.Checked)
                {
                    f.lbldepartement.Text = "Liste des outils non-retourné";
                }
                else
                {
                    f.lbldepartement.Text = "Liste des outils empruntés";
                }
                f.lbldate.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Now).ToString() + "-" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMonth(DateTime.Now).ToString() + "-" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.Now).ToString();
                f.Orientation = false;
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
            }
        }
        private void cmdRetour_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstOutilsInOut;
                int X;
                Cursor.Current = Cursors.WaitCursor; rstOutilsInOut = new Recordset();
                ListViewItem itm = lstoutils.FocusedItem;
                var loopTo = (int)lstoutils.Items.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    if (lstoutils.Items[X].Selected == true)
                    {
                        rstOutilsInOut.Open("SELECT * FROM outils_in_out WHERE no_enreg='" + lstoutils.Items[(int)X].Tag + "' ORDER BY no_outils"
                            , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstOutilsInOut.Fields["retour_date_heure"].Value is DBNull)
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(IdLoginEmploye, lstoutils.Items[(int)X].SubItems[2].Tag, false)))
                            {
                                rstOutilsInOut.Fields["Commentaire"].Value = Operators.ConcatenateObject("(Retourné par: " + IdNomEmploye, Operators.AddObject(")", rstOutilsInOut.Fields["Commentaire"].Value));
                            }
                            rstOutilsInOut.Fields["retour_date_heure"].Value = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Now).ToString() + "-" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMonth(DateTime.Now).ToString(), 2) + "-" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.Now).ToString(), 2) + " " + DateAndTime.TimeOfDay.ToShortTimeString(); rstOutilsInOut.Update();
                        }
                        rstOutilsInOut.Close(); rstOutilsInOut = null;
                    }
                }
           //     remplir_lister_outils();
                Cursor.Current = Cursors.Default; return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "cmdretour_Click", ex);
            }
        }
        private void cmdsortie_Click(object eventSender, EventArgs eventArgs)
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            txtno.Items.Clear();
            rst.Open("SELECT *  FROM [dbo].[Outils_In_out]", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            if (!rst.EOF)
            {
                rst.AddNew();
                rst.Fields["no_outils"].Value =txtno.Text;
                rst.Fields["no_employe"].Value =int.Parse(cmbemployé.Text.Split('-')[0]);
                rst.Fields["depart_date_heure"].Value =DateTime.Now.ToString();
                rst.Fields["retour_date_heure"].Value =DBNull.Value;
                rst.Fields["commentaire"].Value =txtcommentaire.Text+$"\nSaisie par {IdNomEmploye}";
                rst.Update();
            }
            rst.Close();
            rst = null;

        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
                cmdConfig.Enabled = g_bModificationOutils; return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "ActiverBoutonsGroupe", ex);
            }
        }
        private void EnumNumeroOutils()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            txtno.Items.Clear();
            rst.Open("select distinct no_outils, nom_outils FROM [DBO].[Outils] order by no_outils", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rst.EOF)
            {
                txtno.Items.Add($"{rst.Fields[0].Value} - {rst.Fields[1].Value}");
                rst.MoveNext();
            }
            rst.Close();
            rst = null;
        }
        private void RemplirDepartements()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            txtno.Items.Clear();
            rst.Open("select distinct [departement] FROM [DBO].[Outils] ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rst.EOF)
            {
                cmbDepartement.Items.Add($"{rst.Fields[0].Value}");
                rst.MoveNext();
            }
            rst.Close();
            rst = null;
        }
        private void Outils_InOut_Load(object eventSender, EventArgs eventArgs)
        {
            lblemployé.Text = IdNomEmploye;
            remplir_cmbemploye();
                RemplirDepartements();
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                if (cmbemployé.Items.Count > 0){cmbemployé.Text = IdNomEmploye;}
                ActiverBoutonsGroupe();
                EnumNumeroOutils();
                lstoutils.Visible=true;
                InitListeSortie();
                RemplirListerIO();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "Form_Load", ex);
            }
        }

        private void vider_champs()
        {
            try
            {
                txtcommentaire.Text = string.Empty;
                txtdepart.Text = string.Empty;
                txtno.Text = string.Empty;
                txtnom.Text = string.Empty;
                txtsortie.Text = string.Empty; return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Outils_InOut", "vider_champs", ex);
            }
        }
        private void txtno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtno.Text != "")
            {
                idOutil = int.Parse(txtno.Text.Split('-')[0]);
                if (idOutil < 1) { MessageBox.Show(txtno.Text + "a causé une erreur lors de l'exctraction du numéro"); }
                ADODB.Recordset rst = new ADODB.Recordset();
                rst.Open($"select * FROM [DBO].[Outils] where no_outils='{idOutil}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rst.EOF)
                {
                    cmbDepartement.Text = $"{rst.Fields["departement"].Value}";
                    txtnom.Text = $"{rst.Fields["nom_outils"].Value}";
                    txtsortie.Text = $"{rst.Fields["date_hors_fonction"].Value}";
                    txtdepart.Text = $"{rst.Fields["date_achat"].Value}";
                    txtcommentaire.Text = $"{rst.Fields["commentaire"].Value}";
                    rst.MoveNext();
                }
                rst.Close();
                rst = null;

            }
        }
        private void lstoutils_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lstoutils.FocusedItem;
            txtno.Text = item.SubItems[0].Text;
            txtnom.Text = item.SubItems[1].Text;
            cmbDepartement.Text = item.SubItems[2].Text;
            txtsortie.Text = item.SubItems[4].Text;
            txtdepart.Text = item.SubItems[5].Text;
            txtcommentaire.Text = item.SubItems[6].Text;
            idOutil = int.Parse(txtno.Text);
        }
    }
}