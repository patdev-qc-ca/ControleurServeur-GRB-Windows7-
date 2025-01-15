using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ControleurServeur;
using ADODB;
using Microsoft.CodeAnalysis.Emit;
using Stripe;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using Stripe.Climate;
namespace ControleurServeur
{
    internal class InventaireElec : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public InventaireElec() : base()
        {
            InitializeComponent();
        }
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!(components is null)) { components.Dispose(); }
            }
            base.Dispose(Disposing);
        }
        private System.ComponentModel.IContainer components;
        internal ToolTip ToolTip1;
        internal CheckBox _chkChoix_0;
        internal ColumnHeader _lvwHistorique_ColumnHeader_1;
        internal ColumnHeader _lvwHistorique_ColumnHeader_2;
        internal ColumnHeader _lvwHistorique_ColumnHeader_3;
        internal ColumnHeader _lvwHistorique_ColumnHeader_4;
        internal ColumnHeader _lvwHistorique_ColumnHeader_5;
        internal ListView lvwHistorique;
        internal MaskedTextBox mskDateDebut;
        internal MaskedTextBox mskDateFin;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComboBox txtNoProjet;
        internal Label lblTitre;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._chkChoix_0 = new System.Windows.Forms.CheckBox();
            this.lvwHistorique = new System.Windows.Forms.ListView();
            this._lvwHistorique_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwHistorique_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwHistorique_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwHistorique_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwHistorique_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoProjet = new System.Windows.Forms.ComboBox();
            this.mskDateDebut = new System.Windows.Forms.MaskedTextBox();
            this.mskDateFin = new System.Windows.Forms.MaskedTextBox();
            this.txtNoPiece = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.cmdAfficherHistorique = new System.Windows.Forms.Button();
            this._chkChoix_1 = new System.Windows.Forms.CheckBox();
            this._chkChoix_2 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _chkChoix_0
            // 
            this._chkChoix_0.AutoSize = true;
            this._chkChoix_0.BackColor = System.Drawing.Color.Black;
            this._chkChoix_0.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkChoix_0.ForeColor = System.Drawing.Color.White;
            this._chkChoix_0.Location = new System.Drawing.Point(235, 29);
            this._chkChoix_0.Name = "_chkChoix_0";
            this._chkChoix_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkChoix_0.Size = new System.Drawing.Size(59, 19);
            this._chkChoix_0.TabIndex = 3;
            this._chkChoix_0.Text = "Projet";
            this._chkChoix_0.UseVisualStyleBackColor = false;
            // 
            // lvwHistorique
            // 
            this.lvwHistorique.BackColor = System.Drawing.Color.Black;
            this.lvwHistorique.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwHistorique_ColumnHeader_1,
            this._lvwHistorique_ColumnHeader_2,
            this._lvwHistorique_ColumnHeader_3,
            this._lvwHistorique_ColumnHeader_4,
            this._lvwHistorique_ColumnHeader_5});
            this.lvwHistorique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwHistorique.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwHistorique.ForeColor = System.Drawing.Color.White;
            this.lvwHistorique.FullRowSelect = true;
            this.lvwHistorique.GridLines = true;
            this.lvwHistorique.HideSelection = false;
            this.lvwHistorique.Location = new System.Drawing.Point(0, 0);
            this.lvwHistorique.Name = "lvwHistorique";
            this.lvwHistorique.Size = new System.Drawing.Size(1044, 587);
            this.lvwHistorique.TabIndex = 15;
            this.lvwHistorique.UseCompatibleStateImageBehavior = false;
            this.lvwHistorique.View = System.Windows.Forms.View.Details;
            this.lvwHistorique.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwHistorique_ColumnClick);
            this.lvwHistorique.SelectedIndexChanged += new System.EventHandler(this.lvwHistorique_SelectedIndexChanged);
            this.lvwHistorique.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwHistorique_KeyDown);
            // 
            // _lvwHistorique_ColumnHeader_1
            // 
            this._lvwHistorique_ColumnHeader_1.Text = "Date";
            this._lvwHistorique_ColumnHeader_1.Width = 112;
            // 
            // _lvwHistorique_ColumnHeader_2
            // 
            this._lvwHistorique_ColumnHeader_2.Text = "Utilisateur";
            this._lvwHistorique_ColumnHeader_2.Width = 105;
            // 
            // _lvwHistorique_ColumnHeader_3
            // 
            this._lvwHistorique_ColumnHeader_3.Text = "Projet";
            this._lvwHistorique_ColumnHeader_3.Width = 124;
            // 
            // _lvwHistorique_ColumnHeader_4
            // 
            this._lvwHistorique_ColumnHeader_4.Text = "Pièce";
            this._lvwHistorique_ColumnHeader_4.Width = 172;
            // 
            // _lvwHistorique_ColumnHeader_5
            // 
            this._lvwHistorique_ColumnHeader_5.Text = "Quantité";
            this._lvwHistorique_ColumnHeader_5.Width = 99;
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Black;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(205, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitre.Size = new System.Drawing.Size(719, 20);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Historique de l\'inventaire";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 672);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 36);
            this.panel1.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::ControleurServeur.Properties.Resources.print_pref;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.linkLabel7);
            this.groupBox2.Controls.Add(this.linkLabel6);
            this.groupBox2.Controls.Add(this.linkLabel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 36);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "         Impression";
            this.groupBox2.Visible = false;
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.LinkColor = System.Drawing.Color.White;
            this.linkLabel7.Location = new System.Drawing.Point(59, 18);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(122, 15);
            this.linkLabel7.TabIndex = 23;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "La recherche affichée";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkColor = System.Drawing.Color.White;
            this.linkLabel6.Location = new System.Drawing.Point(181, 18);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(145, 15);
            this.linkLabel6.TabIndex = 24;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "L\'ajustement d\'inventaire";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkColor = System.Drawing.Color.White;
            this.linkLabel5.Location = new System.Drawing.Point(326, 18);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(132, 15);
            this.linkLabel5.TabIndex = 25;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "L\'inventaire comptable";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.ico121;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(465, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 36);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = " ";
            this.groupBox1.Text = "       Exportation vers Excel";
            this.groupBox1.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.Location = new System.Drawing.Point(119, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 15);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "La recherche  actuelle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Lime;
            this.linkLabel2.Location = new System.Drawing.Point(245, 18);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(137, 15);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ajustement d\'inventaire";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Lime;
            this.linkLabel3.Location = new System.Drawing.Point(382, 18);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(128, 15);
            this.linkLabel3.TabIndex = 21;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "L\'nventaire comptable";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel4.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.Red;
            this.linkLabel4.Location = new System.Drawing.Point(978, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(66, 36);
            this.linkLabel4.TabIndex = 22;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Fermer";
            this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtNoProjet);
            this.panel2.Controls.Add(this.mskDateDebut);
            this.panel2.Controls.Add(this.mskDateFin);
            this.panel2.Controls.Add(this.txtNoPiece);
            this.panel2.Controls.Add(this.Label15);
            this.panel2.Controls.Add(this.lblTitre);
            this.panel2.Controls.Add(this.Label12);
            this.panel2.Controls.Add(this.cmdAfficherHistorique);
            this.panel2.Controls.Add(this._chkChoix_1);
            this.panel2.Controls.Add(this._chkChoix_0);
            this.panel2.Controls.Add(this._chkChoix_2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 85);
            this.panel2.TabIndex = 20;
            // 
            // txtNoProjet
            // 
            this.txtNoProjet.BackColor = System.Drawing.SystemColors.Control;
            this.txtNoProjet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNoProjet.FormattingEnabled = true;
            this.txtNoProjet.Location = new System.Drawing.Point(109, 54);
            this.txtNoProjet.Name = "txtNoProjet";
            this.txtNoProjet.Size = new System.Drawing.Size(304, 22);
            this.txtNoProjet.TabIndex = 17;
            // 
            // mskDateDebut
            // 
            this.mskDateDebut.AllowPromptAsInput = false;
            this.mskDateDebut.BackColor = System.Drawing.SystemColors.Control;
            this.mskDateDebut.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDateDebut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mskDateDebut.Location = new System.Drawing.Point(660, 52);
            this.mskDateDebut.Name = "mskDateDebut";
            this.mskDateDebut.Size = new System.Drawing.Size(65, 22);
            this.mskDateDebut.TabIndex = 15;
            // 
            // mskDateFin
            // 
            this.mskDateFin.AllowPromptAsInput = false;
            this.mskDateFin.BackColor = System.Drawing.SystemColors.Control;
            this.mskDateFin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDateFin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mskDateFin.Location = new System.Drawing.Point(762, 53);
            this.mskDateFin.Name = "mskDateFin";
            this.mskDateFin.Size = new System.Drawing.Size(65, 22);
            this.mskDateFin.TabIndex = 16;
            // 
            // txtNoPiece
            // 
            this.txtNoPiece.AcceptsReturn = true;
            this.txtNoPiece.BackColor = System.Drawing.SystemColors.Control;
            this.txtNoPiece.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoPiece.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPiece.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNoPiece.Location = new System.Drawing.Point(419, 53);
            this.txtNoPiece.MaxLength = 0;
            this.txtNoPiece.Name = "txtNoPiece";
            this.txtNoPiece.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoPiece.Size = new System.Drawing.Size(185, 23);
            this.txtNoPiece.TabIndex = 6;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Black;
            this.Label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(627, 57);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(25, 17);
            this.Label15.TabIndex = 9;
            this.Label15.Text = "Du :";
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Black;
            this.Label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(731, 56);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(25, 17);
            this.Label12.TabIndex = 12;
            this.Label12.Text = "Au :";
            // 
            // cmdAfficherHistorique
            // 
            this.cmdAfficherHistorique.BackColor = System.Drawing.SystemColors.Control;
            this.cmdAfficherHistorique.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAfficherHistorique.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAfficherHistorique.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAfficherHistorique.Location = new System.Drawing.Point(844, 46);
            this.cmdAfficherHistorique.Name = "cmdAfficherHistorique";
            this.cmdAfficherHistorique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAfficherHistorique.Size = new System.Drawing.Size(68, 25);
            this.cmdAfficherHistorique.TabIndex = 14;
            this.cmdAfficherHistorique.Text = "Afficher";
            this.cmdAfficherHistorique.UseVisualStyleBackColor = false;
            this.cmdAfficherHistorique.Click += new System.EventHandler(this.cmdAfficherHistorique_Click);
            // 
            // _chkChoix_1
            // 
            this._chkChoix_1.AutoSize = true;
            this._chkChoix_1.BackColor = System.Drawing.Color.Black;
            this._chkChoix_1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkChoix_1.ForeColor = System.Drawing.Color.White;
            this._chkChoix_1.Location = new System.Drawing.Point(419, 29);
            this._chkChoix_1.Name = "_chkChoix_1";
            this._chkChoix_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkChoix_1.Size = new System.Drawing.Size(55, 19);
            this._chkChoix_1.TabIndex = 4;
            this._chkChoix_1.Text = "Pièce";
            this._chkChoix_1.UseVisualStyleBackColor = false;
            // 
            // _chkChoix_2
            // 
            this._chkChoix_2.AutoSize = true;
            this._chkChoix_2.BackColor = System.Drawing.Color.Black;
            this._chkChoix_2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkChoix_2.ForeColor = System.Drawing.Color.White;
            this._chkChoix_2.Location = new System.Drawing.Point(627, 29);
            this._chkChoix_2.Name = "_chkChoix_2";
            this._chkChoix_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkChoix_2.Size = new System.Drawing.Size(51, 19);
            this._chkChoix_2.TabIndex = 7;
            this._chkChoix_2.Text = "Date";
            this._chkChoix_2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvwHistorique);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 587);
            this.panel3.TabIndex = 21;
            // 
            // InventaireElec
            // 
            this.AcceptButton = this.cmdAfficherHistorique;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1044, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.MinimizeBox = false;
            this.Name = "InventaireElec";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.InventaireElec";
            this.Load += new System.EventHandler(this.InventaireElec_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void enumNoPrjets()
        {
            try
            {
                ADODB.Recordset rstHist = new Recordset();
                rstHist.Open("SELECT distinct [IDProjet] ,[IDSoumission],[description]  FROM [autogrb].[dbo].[ProjetElec]\r\n", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                //else { rstHist.Open("SELECT * FROM InventaireElecModif ORDER BY numid DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                lvwHistorique.Items.Clear();
                while (!rstHist.EOF)
                {
                    txtNoProjet.Items.Add($"{rstHist.Fields[0].Value} ({rstHist.Fields[2].Value})");
                    rstHist.MoveNext();
                }
                rstHist.Close();
                rstHist = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireElec", "RemplirListViewFullHistorique", ex);
            }

        }
        private void lvwHistorique_KeyDown(object sender, KeyEventArgs e)
        {
        }
        #endregion
        internal Panel panel1;
        internal Panel panel2;
        internal TextBox txtNoPiece;
        internal Label Label15;
        internal Label Label12;
        internal Button cmdAfficherHistorique;
        internal CheckBox _chkChoix_1;
        internal CheckBox _chkChoix_2;
        internal Panel panel3;
        public bool m_bAnnuleImpression;
        public ChoixImpressionInventaire.enumImpressionInventaire m_eTypeImpression;
        public bool m_typeImpressionExel;
        private void RemplirListviewFullHistorique()
        {
            try
            {
                ADODB.Recordset rstHist = new Recordset();
                rstHist.Open("SELECT [DATE],[QUANTITÉ],[USER], [DBO].[INVENTAIREELEC].NOITEM, DESCRIPTION, MANUFACTURIER, QTEBOITE, [PRIX LISTE], ESCOMPTE, [PRIX NET], COMMENTAIRES, LOCALISATION, " +
                    "DEVISEMONÉTAIRE, QUANTITÉSTOCK, QUANTITÉCOMMANDÉE, MINIMUM, QUANTITÉMINIMUM, COMMANDE, NOPROJET, COMMANDEPARBOITE FROM INVENTAIREELEC " +
                    "JOIN[DBO].[INVENTAIREELECMODIF] ON[DBO].[INVENTAIREELEC].NOITEM = [DBO].[INVENTAIREELECMODIF].NOITEM " +
                    "order by[dbo].[InventaireElecModif].[IDProjet], [Date]", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); 
                //else { rstHist.Open("SELECT * FROM InventaireElecModif ORDER BY numid DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                lvwHistorique.Items.Clear();
                lvwHistorique.Columns.Clear();
                if (!rstHist.EOF)
                {
                    for (int x = 0; x < rstHist.Fields.Count; x++)
                    {
                        lvwHistorique.Columns.Add(rstHist.Fields[x].Name);
                    }
                    while (!rstHist.EOF)
                    {
                        ListViewItem itmHist = lvwHistorique.Items.Add(string.Empty);
                        itmHist.Tag = (string)rstHist.Fields[3].Value;
                        for (int x = 0; x < rstHist.Fields.Count; x++)
                        {
                            itmHist.SubItems.Insert(x, new ListViewItem.ListViewSubItem(null, $"{rstHist.Fields[x].Value}"));
                            if (x == 12)
                            {
                                if (rstHist.Fields[12].Value is DBNull)
                                {
                                    itmHist.SubItems[12].Text = "$ CAD";
                                }
                            }
                        }
                        rstHist.MoveNext();
                    }
                }
                rstHist.Close();
                rstHist = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireElec", "RemplirListViewFullHistorique", ex);
            }

        }
        private void RemplirListViewHistorique()
        {
            try
            {
                ADODB.Recordset rstHist = new Recordset();
                var sWhere = default(string);
                ListViewItem itmHist;
                if (_chkChoix_0.Checked) { sWhere = "Left(IDProjet, " + Strings.Len(txtNoProjet.Text) + ") = '" + txtNoProjet.Text + "' "; }
                if (_chkChoix_1.Checked)
                {
                    if (string.IsNullOrEmpty(sWhere)) { sWhere = "NoItem like'%" + Strings.Replace(txtNoPiece.Text, "'", "''") + "%'"; }
                    else { sWhere += " AND NoItem like'%" + Strings.Replace(txtNoPiece.Text, "'", "''") + "%' "; }
                }
                if (_chkChoix_2.Checked)
                {
                    if (string.IsNullOrEmpty(sWhere))
                    {
                        sWhere = "Date BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'";
                    }
                    else { sWhere += " AND Date BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'"; }
                }
                if (!string.IsNullOrEmpty(sWhere)) { rstHist.Open("SELECT * FROM InventaireElecModif WHERE " + sWhere + " ORDER BY numid DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                else { rstHist.Open("SELECT * FROM InventaireElecModif ORDER BY numid DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                itmHist = lvwHistorique.Items.Add(IdNomEmploye);
                lvwHistorique.Items.Clear();
                while (!rstHist.EOF)
                {
                    itmHist = lvwHistorique.Items.Add(string.Empty);
                    itmHist.Text = (string)(rstHist.Fields["Date"].Value);
                    itmHist.Tag = rstHist.Fields["numid"].Value;
                    if (itmHist.SubItems.Count > 1) { itmHist.SubItems[1].Text = (string)(rstHist.Fields["User"].Value); }
                    else { itmHist.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, (string)(rstHist.Fields["User"].Value))); }
                    if (rstHist.Fields["IDProjet"].Value != "")
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim((string)(rstHist.Fields["IDProjet"].Value))))
                        {
                            if (itmHist.SubItems.Count > 2) { itmHist.SubItems[2].Text = (string)(rstHist.Fields["IDProjet"].Value); }
                            else { itmHist.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, (string)(rstHist.Fields["IDProjet"].Value))); }
                        }
                        else if (itmHist.SubItems.Count > 2) { itmHist.SubItems[2].Text = "N/A"; }
                        else { itmHist.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, "N/A")); }
                    }
                    else if (itmHist.SubItems.Count > 2) { itmHist.SubItems[2].Text = "N/A"; }
                    else { itmHist.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, "N/A")); }
                    if (itmHist.SubItems.Count > 3) { itmHist.SubItems[3].Text = (string)(rstHist.Fields["NoItem"].Value); }
                    else { itmHist.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, (string)(rstHist.Fields["NoItem"].Value))); }
                    if (itmHist.SubItems.Count > 4) { itmHist.SubItems[4].Text = (string)(rstHist.Fields["Quantité"].Value); }
                    else { itmHist.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, (string)(rstHist.Fields["Quantité"].Value))); }
                    rstHist.MoveNext();
                }
                rstHist.Close();
                rstHist = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireElec", "RemplirListViewHistorique", ex);
            }
        }
        private void chkChoix_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            txtNoProjet.Enabled = _chkChoix_0.Checked;
            txtNoPiece.Enabled = _chkChoix_1.Checked;
            mskDateDebut.Enabled = _chkChoix_2.Checked;
            mskDateFin.Enabled = _chkChoix_2.Checked;
            cmdAfficherHistorique.Enabled = _chkChoix_2.Checked;
        }
        private void cmdAfficherHistorique_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (_chkChoix_2.Checked)
                {
                    if (!string.IsNullOrEmpty(mskDateDebut.Text) & !string.IsNullOrEmpty(mskDateFin.Text))
                    {
                        DateTime dd = DateTime.Parse(mskDateDebut.Text);
                        DateTime df = DateTime.Parse(mskDateFin.Text);
                        if (df < dd) { MessageBox.Show("La date de fin doit être plus petite que la date de début!", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    }
                    else { MessageBox.Show("Vous devez remplir tous les champs!", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }
                Cursor.Current = Cursors.WaitCursor;
                if (_chkChoix_2.Checked | _chkChoix_1.Checked | _chkChoix_0.Checked) { RemplirListViewHistorique(); }
                else {                    RemplirListviewFullHistorique(); }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireElec", "cmdAfficherHistorique_Click", ex);
            }
        }
        private void InventaireElec_Load(object eventSender, EventArgs eventArgs)
        {
                Icon = Conteneur.ActiveForm.Icon;
            try
            {
                enumNoPrjets();
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireElec", "Form_Load", ex);
            }
        }
        private void lvwHistorique_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader = lvwHistorique.Columns[eventArgs.Column];
            try
            {
                if (lvwHistorique.Items.Count > 0)
                {
                    lvwHistorique.Sort();
                    lvwHistorique.Sorting.GetHashCode();
                    if (lvwHistorique.Sorting == SortOrder.Ascending) { lvwHistorique.Sorting = SortOrder.Descending; }
                    else { lvwHistorique.Sorting = SortOrder.Ascending; }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireElec", "lvwHistorique_ColumnClick", ex);
            }
        }
        private void ModifierInventaire(string sPiece, string sQuantite)
        {
            try
            {
                ADODB.Recordset rstInv;
                if (double.Parse(sQuantite) > 0d) { sQuantite = "-" + sQuantite; }
                else { sQuantite = Strings.Replace(sQuantite, "-", ""); }
                rstInv = new Recordset();
                rstInv.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + Strings.Replace(sPiece, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstInv.Fields["QuantitéStock"].Value = double.Parse(rstInv.Fields["QuantitéStock"].Value) + double.Parse(sQuantite);
                rstInv.Update();
                rstInv.Close();
                rstInv = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireElec", "ModifierInventaire", ex);
            }
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("InventaireElec", "cmdFermer_Click", ex);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oXLApp;
            Microsoft.Office.Interop.Excel.Workbook oXLBook;
            Microsoft.Office.Interop.Excel.Worksheet oXLSheet;
            int r;
            oXLApp = new Microsoft.Office.Interop.Excel.Application();
            oXLBook = oXLApp.Workbooks.Add();
            oXLSheet = (Microsoft.Office.Interop.Excel.Worksheet)oXLBook.Worksheets[1];
            oXLSheet.Name = linkLabel1.Text;
            oXLApp.Visible = false;
            r = 1;
            oXLApp.Visible = true;
            oXLSheet.get_Range("A1: F1").Font.Bold = true;
            oXLSheet.get_Range("A:F").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            oXLSheet.get_Range("A1: F1").set_Value(value: new object[] { "Date", "Utilisateur", "Projet", "Piece", "Quantité", System.Windows.Forms.Application.ProductName + "." + Name });
            oXLApp.ActiveSheet.Range("a2").Select();
            {
                var withBlock = oXLApp.ActiveWindow;
                withBlock.FreezePanes = false;
                withBlock.ScrollRow = 1;
                withBlock.ScrollColumn = 1;
                withBlock.FreezePanes = true;
                withBlock.ScrollRow = 2;
            }
            foreach (ListViewItem p in lvwHistorique.Items)
            {
                r++;
                oXLSheet.Cells[r, 1] = p.SubItems[0].Text;
                oXLSheet.Cells[r, 2] = p.SubItems[1].Text;
                oXLSheet.Cells[r, 3] = p.SubItems[2].Text;
                oXLSheet.Cells[r, 4] = p.SubItems[3].Text;
                oXLSheet.Cells[r, 5] = p.SubItems[4].Text;
                System.Windows.Forms.Application.DoEvents();
            }
            oXLSheet.get_Range("A:FE").Columns.AutoFit();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oXLApp;
            Microsoft.Office.Interop.Excel.Workbook oXLBook;
            Microsoft.Office.Interop.Excel.Worksheet oXLSheet;
            ADODB.Recordset rstInv = new Recordset();
            int r;
            oXLApp = new Microsoft.Office.Interop.Excel.Application();
            oXLBook = oXLApp.Workbooks.Add();
            oXLSheet = (Microsoft.Office.Interop.Excel.Worksheet)oXLBook.Worksheets[1];
            oXLSheet.Name = Gauche(linkLabel2.Text, 30);// le nom de la feuille ne doit pas depasser 30carrecteres
            oXLApp.Visible = false;
            r = 1;
            oXLApp.Visible = true;
            oXLSheet.get_Range("A1: I1").Font.Bold = true;
            oXLSheet.get_Range("A:I").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            oXLSheet.get_Range("A1: I1").set_Value(value: new object[] { "Date", "Utilisateur", "Projet", "Piece", "Quantité", "Description", "Manufacturier", "Localisation", System.Windows.Forms.Application.ProductName + "." + Name });
            oXLSheet.get_Range("I1").Font.ThemeColor = 1;
            oXLApp.ActiveSheet.Range("a2").Select();
            {
                var withBlock = oXLApp.ActiveWindow;
                withBlock.FreezePanes = false;
                withBlock.ScrollRow = 1;
                withBlock.ScrollColumn = 1;
                withBlock.FreezePanes = true;
                withBlock.ScrollRow = 2;
            }
            foreach (ListViewItem p in lvwHistorique.Items)
            {
                if (rstInv.State == 1) rstInv.Close();
                rstInv.Open($"select * from InventaireElec where NoItem='{p.SubItems[3].Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                r++;
                oXLSheet.Cells[r, 1] = p.SubItems[0].Text;
                oXLSheet.Cells[r, 2] = p.SubItems[1].Text;
                oXLSheet.Cells[r, 3] = p.SubItems[2].Text;
                oXLSheet.Cells[r, 4] = p.SubItems[3].Text;
                oXLSheet.Cells[r, 5] = p.SubItems[4].Text;
                if (!rstInv.EOF)
                {
                    if ((rstInv.Fields["Description"].Value == "N/A") | (rstInv.Fields["Description"].Value is DBNull)) { oXLSheet.Cells[r, 6] = "Indisponible"; } else { oXLSheet.Cells[r, 6] = rstInv.Fields["Description"].Value; }
                    if ((rstInv.Fields["Manufacturier"].Value == "N/A") | (rstInv.Fields["Manufacturier"].Value is DBNull)) { oXLSheet.Cells[r, 7] = "Indisponible"; } else { oXLSheet.Cells[r, 7] = rstInv.Fields["Manufacturier"].Value; }
                    if ((rstInv.Fields["Localisation"].Value == "N/A") | (rstInv.Fields["Localisation"].Value is DBNull)) { oXLSheet.Cells[r, 8] = "Indisponible"; } else { oXLSheet.Cells[r, 8] = rstInv.Fields["Localisation"].Value; }
                }
                else
                {
                    oXLSheet.Cells[r, 6] = "Indisponible";
                    oXLSheet.Cells[r, 7] = "Indisponible";
                    oXLSheet.Cells[r, 8] = "Indisponible";
                }
                if (rstInv.State == 1) rstInv.Close();
                System.Windows.Forms.Application.DoEvents();
            }
            oXLSheet.get_Range("A:K").Columns.AutoFit();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oXLApp;
            Microsoft.Office.Interop.Excel.Workbook oXLBook;
            Microsoft.Office.Interop.Excel.Worksheet oXLSheet;
            ADODB.Recordset rstInv = new Recordset();
            int r;
            oXLApp = new Microsoft.Office.Interop.Excel.Application();
            oXLBook = oXLApp.Workbooks.Add();
            oXLSheet = (Microsoft.Office.Interop.Excel.Worksheet)oXLBook.Worksheets[1];
            oXLSheet.Name = Gauche(linkLabel3.Text, 30);// le nom de la feuille ne doit pas depasser 30carrecteres
            oXLApp.Visible = false;
            r = 1;
            oXLApp.Visible = true;
            oXLSheet.get_Range("A1: M1").Font.Bold = true;
            oXLSheet.get_Range("A:M").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            oXLSheet.get_Range("A1: M1").set_Value(value: new object[] { "Date", "Utilisateur", "Projet", "Piece", "Quantité", "Description", "Manufacturier",
                "Localisation", "Prix net", "Escompte", "Total",System.Windows.Forms.Application.ProductName + "." + Name });
            oXLSheet.get_Range("M1").Font.ThemeColor = 1;
            oXLApp.ActiveSheet.Range("a2").Select();
            {
                var withBlock = oXLApp.ActiveWindow;
                withBlock.FreezePanes = false;
                withBlock.ScrollRow = 1;
                withBlock.ScrollColumn = 1;
                withBlock.FreezePanes = true;
                withBlock.ScrollRow = 2;
            }
            foreach (ListViewItem p in lvwHistorique.Items)
            {
                if (rstInv.State == 1) rstInv.Close();
                rstInv.Open($"select * from InventaireElec where NoItem='{p.SubItems[3].Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                r++;
                oXLSheet.Cells[r, 1] = p.SubItems[0].Text;
                oXLSheet.Cells[r, 2] = p.SubItems[1].Text;
                oXLSheet.Cells[r, 3] = p.SubItems[2].Text;
                oXLSheet.Cells[r, 4] = p.SubItems[3].Text;
                oXLSheet.Cells[r, 5] = p.SubItems[4].Text;
                if (!rstInv.EOF)
                {
                    if ((rstInv.Fields["Description"].Value == "N/A") | (rstInv.Fields["Description"].Value is DBNull)) { oXLSheet.Cells[r, 6] = "Indisponible"; } else { oXLSheet.Cells[r, 6] = rstInv.Fields["Description"].Value; }
                    if ((rstInv.Fields["Manufacturier"].Value == "N/A") | (rstInv.Fields["Manufacturier"].Value is DBNull)) { oXLSheet.Cells[r, 7] = "Indisponible"; } else { oXLSheet.Cells[r, 7] = rstInv.Fields["Manufacturier"].Value; }
                    if ((rstInv.Fields["Localisation"].Value == "N/A") | (rstInv.Fields["Localisation"].Value is DBNull)) { oXLSheet.Cells[r, 8] = "Indisponible"; } else { oXLSheet.Cells[r, 8] = rstInv.Fields["Localisation"].Value; }
                    oXLSheet.Cells[r, 9] = rstInv.Fields["Prix net"].Value;
                    oXLSheet.Cells[r, 10] = rstInv.Fields["Escompte"].Value;
                    double pn = double.Parse(rstInv.Fields["Prix net"].Value);
                    double qt = double.Parse(rstInv.Fields["QuantitéStock"].Value);
                    oXLSheet.Cells[r, 11] = Math.Round(pn * qt, 2).ToString();
                }
                else
                {
                    oXLSheet.Cells[r, 6] = "Indisponible";
                    oXLSheet.Cells[r, 7] = "Indisponible";
                    oXLSheet.Cells[r, 8] = "Indisponible";
                    oXLSheet.Cells[r, 9] = "0.00$";
                    oXLSheet.Cells[r, 10] = "0.00$";
                    oXLSheet.Cells[r, 11] = "0.00$";
                }
                if (rstInv.State == 1) rstInv.Close();
                System.Windows.Forms.Application.DoEvents();
            }
            oXLSheet.get_Range("A:L").Columns.AutoFit();
            oXLSheet.get_Range("I:K").NumberFormat = "#,##0.00 $";
        }
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int nbpages = (lvwHistorique.Items.Count / 50) + 1;
            int page = 1;
            for (int a = 0; a < nbpages; a++)
            {
                ViewListeInventaire lvi = new ViewListeInventaire();
                lvi.Text = System.Windows.Forms.Application.ProductName + "." + Name + " <= " + linkLabel7.Text;
                lvi.Width = 805;
                lvi.Height = 1048;
                lvi.pictureBox1.Left = lvi.Width - lvi.pictureBox1.Width;
                lvi.listView1.Columns.Clear();
                lvi.lblTitre.Text = lblTitre.Text + " ";
                lvi.lblNoPage.Text = $"Page {a + 1}/{nbpages}";
                lvi.lblTitreTotal.Visible = false;
                lvi.lblTotal.Visible = false;
                if (txtNoProjet.Text != "") { lvi.lblTitre.Text += $" #: {txtNoProjet.Text}"; }
                if (mskDateDebut.Text != "" && mskDateFin.Text != "") { lvi.lblTitre.Text += $"\n {mskDateDebut.Text} => {mskDateFin.Text}"; }
                for (int x = 0; x < lvwHistorique.Columns.Count; x++)
                {
                    lvi.listView1.Columns.Add(lvwHistorique.Columns[x].Text);
                }
                for (int x = (a * 50); x < (a + 1) * 50; x++)
                {
                    ListViewItem lv = lvi.listView1.Items.Add(string.Empty);
                    lv.SubItems[0].Text = lvwHistorique.Items[x].SubItems[0].Text;
                    lv.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[1].Text));
                    lv.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[2].Text));
                    lv.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[3].Text));
                    lv.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[4].Text));
                }
                lvi.ShowDialog();
            }
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int nbpages = (lvwHistorique.Items.Count / 50) + 1;
            int page = 1;
            for (int a = 0; a < nbpages; a++)
            {
                ViewListeInventaire lvi = new ViewListeInventaire();
                lvi.Text = System.Windows.Forms.Application.ProductName + "." + Name + " <= " + linkLabel7.Text;
                lvi.Width = 805;
                lvi.Height = 1048;
                lvi.pictureBox1.Left = lvi.Width - lvi.pictureBox1.Width;
                lvi.listView1.Columns.Clear();
                lvi.lblTitre.Text = lblTitre.Text + " ";
                lvi.lblNoPage.Text = $"Page {a + 1}/{nbpages}";
                lvi.lblTitreTotal.Visible = false;
                lvi.lblTotal.Visible = false;
                if (txtNoProjet.Text != "") { lvi.lblTitre.Text += $" #: {txtNoProjet.Text}"; }
                if (mskDateDebut.Text != "" && mskDateFin.Text != "") { lvi.lblTitre.Text += $"\n {mskDateDebut.Text} => {mskDateFin.Text}"; }
                for (int x = 0; x < lvwHistorique.Columns.Count; x++)
                {
                    lvi.listView1.Columns.Add(lvwHistorique.Columns[x].Text);
                }
                for (int x = (a * 50); x < 50; x++)
                {
                    ListViewItem lv = lvi.listView1.Items.Add(string.Empty);
                    lv.SubItems[0].Text = lvwHistorique.Items[x].SubItems[0].Text;
                    lv.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[1].Text));
                    lv.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[2].Text));
                    lv.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[3].Text));
                    lv.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[4].Text));
                }
                lvi.ShowDialog();
            }
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* 
             ADODB.Recordset rstTotal = new ADODB.Recordset();
             rstInv.Open("SELECT NoItem, Description, Manufacturier, [Prix Liste], Escompte, [Prix Net], Localisation, QuantitéStock, [Prix Net] * QuantitéStock As Total FROM InventaireElec WHERE QuantitéStock <> '0' ORDER BY NoItem", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
             ControleurServeur.ViewInventaire.DataSource = rstInv;
             rstTotal.Open("SELECT SUM([Prix net] * QuantitéStock) As Total FROM InventaireElec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
             rstTotal.Close();
             rstTotal = null;
             rstInv.Close();
             rstInv = null;*/

            int nbpages = (lvwHistorique.Items.Count / 30) + 1;
            int page = 1;
            for (int a = 0; a < nbpages; a++)
            {
                ViewInventaire lvi = new ViewInventaire();
                lvi.Text = System.Windows.Forms.Application.ProductName + "." + Name + " <= " + linkLabel7.Text;
                lvi.Width = 1166;
                lvi.Height = 834;
                lvi.Orientation = isLandscape; // definit comment va se comporter le commutateur portrait/paysage lors de l'impresseion 3 fenetres plus loin
                lvi.pictureBox1.Left = lvi.Width - lvi.pictureBox1.Width;
                lvi.lblDate.Text = DateTime.Today.ToShortDateString();
                lvi.lblTitre.Text = "Inventaire Électrique";
                lvi.listView1.Columns.Clear();
                string[] colones = { "No. Item", "Description", "Manufacturier", "Localisation", "Fournisseur", "QuantiteStock", "Prix liste", "Escompte", "Prix net", "Total" };
                lvi.lblTitre.Text = lblTitre.Text + " ";
                for (int b = 0; b < colones.Length; b++)
                {
                    lvi.listView1.Columns.Add(colones[b]);
                }
                lvi.lblNoPage.Text = $"Page {a + 1}/{nbpages}";
                ADODB.Recordset rstInv = new ADODB.Recordset();
                if (page < nbpages)
                {
                    lvi.toolStripStatusLabel1.Visible = false;
                    lvi.lblTotal.Visible = false;
                }
                else
                {
                    lvi.toolStripStatusLabel1.Visible = true;
                    lvi.lblTotal.Visible = true;
                }
                if (txtNoProjet.Text != "") { lvi.lblTitre.Text += $" #: {txtNoProjet.Text}"; }
                if (mskDateDebut.Text != "" & mskDateFin.Text != "") { lvi.lblTitre.Text += $"\n {mskDateDebut.Text} => {mskDateFin.Text}"; }
                for (int x = (a * 30); x < (a + 1) + 30; x++)
                {
                    if (rstInv.State == 1) rstInv.Close();
                    rstInv.Open($"select * from InventaireElec where NoItem='{lvwHistorique.Items[x].SubItems[3].Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    double total = 0d;
                    ListViewItem lv = lvi.listView1.Items.Add(string.Empty);
                    lv.SubItems[0].Text = lvwHistorique.Items[x].SubItems[0].Text;
                    lv.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[1].Text));
                    lv.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[2].Text));
                    lv.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[3].Text));
                    lv.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, lvwHistorique.Items[x].SubItems[4].Text));
                    if (!rstInv.EOF)
                    {
                        if ((rstInv.Fields["Manufacturier"].Value == "N/A") | (rstInv.Fields["Manufacturier"].Value is DBNull))
                        { lv.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rstInv.Fields["Manufacturier"].Value}")); }
                        else { lv.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"Indisponible")); }
                        if ((rstInv.Fields["Localisation"].Value == "N/A") | (rstInv.Fields["Localisation"].Value is DBNull))
                        {
                            lv.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rstInv.Fields["Localisation"].Value}"));
                        }
                        else { lv.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"Indisponible")); }

                        if ((rstInv.Fields["Description"].Value == "N/A") | (rstInv.Fields["Description"].Value is DBNull))
                        {
                            lv.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rstInv.Fields["Description"].Value}"));
                        }
                        else { lv.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"Indisponible")); }
                        lv.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rstInv.Fields["Prix net"].Value}"));
                        lv.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rstInv.Fields["Escompte"].Value}"));
                        double pn = double.Parse(rstInv.Fields["Prix net"].Value);
                        double qt = double.Parse(rstInv.Fields["QuantitéStock"].Value);
                        total += (pn * qt);
                        lv.SubItems.Insert(10, new ListViewItem.ListViewSubItem(null, Math.Round(pn * qt, 2).ToString()));
                        lvi.lblTotal.Text = $"{total}$";
                    }
                    else
                    {
                        lv.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, "Indisponible"));
                        lv.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, "Indisponible"));
                        lv.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, "Indisponible"));
                        lv.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, "0.00$"));
                        lv.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, "0.00$"));
                        lv.SubItems.Insert(10, new ListViewItem.ListViewSubItem(null, "0.00$"));
                    }
                    if (rstInv.State == 1) rstInv.Close();
                    System.Windows.Forms.Application.DoEvents();

                }
                lvi.ShowDialog();
            }
        }
        private void lvwHistorique_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwHistorique.Items.Count > 0)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible=false;
            }
        }
        private void txtNoProjet_TextChanged(object sender, EventArgs e)
        {
            txtNoProjet.Text=txtNoProjet.Text.Trim().ToUpper();
        }

    }
}