using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;


namespace ControleurServeur
{
    internal class ChoixProjSoum : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixProjSoum() : base()
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
        internal Button cmdReceptionElec;
        internal Button cmdReceptionMec;
        internal GroupBox fraReception;
        internal Button cmdAchatMec;
        internal Button cmdAchatElec;
        internal GroupBox fraAchat;
        internal Button cmdProjSoumElec;
        internal Button cmdProjSoumMec;
        internal GroupBox fraProjSoum;
        internal Button cmdFermer;
        internal Label Label16;
        internal Label Label52;
        internal Label Label51;
        internal Label lblAnnee;
        internal Label Label49;
        internal Label Label48;
        internal Label Label47;
        internal Label Label46;
        internal Label Label45;
        internal Label Label44;
        internal Label Label43;
        internal Label Label42;
        internal Label Label41;
        internal Label Label40;
        internal Label Label39;
        internal Label Label38;
        internal Label Label37;
        internal Label Label36;
        internal Label Label35;
        internal Label Label34;
        internal Label Label33;
        internal Label Label32;
        internal Label Label31;
        internal Label Label30;
        internal Label Label29;
        internal Label Label28;
        internal Label Label27;
        internal Label Label26;
        internal Label Label25;
        internal Label Label24;
        internal Label Label23;
        internal Label Label22;
        internal Label Label21;
        internal Label Label20;
        internal Label Label19;
        internal Label Label18;
        internal Label Label17;
        internal Label Label10;
        internal Label Label8;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label lblExemple;
        internal Label Label1;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fraReception = new System.Windows.Forms.GroupBox();
            this.cmdReceptionElec = new System.Windows.Forms.Button();
            this.cmdReceptionMec = new System.Windows.Forms.Button();
            this.fraAchat = new System.Windows.Forms.GroupBox();
            this.cmdAchatMec = new System.Windows.Forms.Button();
            this.cmdAchatElec = new System.Windows.Forms.Button();
            this.fraProjSoum = new System.Windows.Forms.GroupBox();
            this.cmdProjSoumElec = new System.Windows.Forms.Button();
            this.cmdProjSoumMec = new System.Windows.Forms.Button();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label52 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.Label49 = new System.Windows.Forms.Label();
            this.Label48 = new System.Windows.Forms.Label();
            this.Label47 = new System.Windows.Forms.Label();
            this.Label46 = new System.Windows.Forms.Label();
            this.Label45 = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.Label42 = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblExemple = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.fraReception.SuspendLayout();
            this.fraAchat.SuspendLayout();
            this.fraProjSoum.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // fraReception
            // 
            this.fraReception.BackColor = System.Drawing.Color.Black;
            this.fraReception.Controls.Add(this.cmdReceptionElec);
            this.fraReception.Controls.Add(this.cmdReceptionMec);
            this.fraReception.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraReception.ForeColor = System.Drawing.Color.White;
            this.fraReception.Location = new System.Drawing.Point(315, 111);
            this.fraReception.Name = "fraReception";
            this.fraReception.Padding = new System.Windows.Forms.Padding(0);
            this.fraReception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraReception.Size = new System.Drawing.Size(271, 51);
            this.fraReception.TabIndex = 30;
            this.fraReception.TabStop = false;
            this.fraReception.Text = "Réception";
            // 
            // cmdReceptionElec
            // 
            this.cmdReceptionElec.BackColor = System.Drawing.Color.Black;
            this.cmdReceptionElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReceptionElec.ForeColor = System.Drawing.Color.Navy;
            this.cmdReceptionElec.Location = new System.Drawing.Point(16, 17);
            this.cmdReceptionElec.Name = "cmdReceptionElec";
            this.cmdReceptionElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReceptionElec.Size = new System.Drawing.Size(121, 25);
            this.cmdReceptionElec.TabIndex = 31;
            this.cmdReceptionElec.Text = "Électrique";
            this.cmdReceptionElec.UseVisualStyleBackColor = true;
            this.cmdReceptionElec.Click += new System.EventHandler(this.cmdReceptionElec_Click);
            // 
            // cmdReceptionMec
            // 
            this.cmdReceptionMec.BackColor = System.Drawing.Color.Black;
            this.cmdReceptionMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReceptionMec.ForeColor = System.Drawing.Color.Navy;
            this.cmdReceptionMec.Location = new System.Drawing.Point(143, 17);
            this.cmdReceptionMec.Name = "cmdReceptionMec";
            this.cmdReceptionMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReceptionMec.Size = new System.Drawing.Size(121, 25);
            this.cmdReceptionMec.TabIndex = 32;
            this.cmdReceptionMec.Text = "Mécanique";
            this.cmdReceptionMec.UseVisualStyleBackColor = true;
            this.cmdReceptionMec.Click += new System.EventHandler(this.cmdReceptionMec_Click);
            // 
            // fraAchat
            // 
            this.fraAchat.BackColor = System.Drawing.Color.Black;
            this.fraAchat.Controls.Add(this.cmdAchatMec);
            this.fraAchat.Controls.Add(this.cmdAchatElec);
            this.fraAchat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraAchat.ForeColor = System.Drawing.Color.White;
            this.fraAchat.Location = new System.Drawing.Point(315, 165);
            this.fraAchat.Name = "fraAchat";
            this.fraAchat.Padding = new System.Windows.Forms.Padding(0);
            this.fraAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraAchat.Size = new System.Drawing.Size(271, 49);
            this.fraAchat.TabIndex = 45;
            this.fraAchat.TabStop = false;
            this.fraAchat.Text = this.Name;
            // 
            // cmdAchatMec
            // 
            this.cmdAchatMec.BackColor = System.Drawing.Color.Black;
            this.cmdAchatMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAchatMec.ForeColor = System.Drawing.Color.Navy;
            this.cmdAchatMec.Location = new System.Drawing.Point(143, 18);
            this.cmdAchatMec.Name = "cmdAchatMec";
            this.cmdAchatMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAchatMec.Size = new System.Drawing.Size(121, 25);
            this.cmdAchatMec.TabIndex = 47;
            this.cmdAchatMec.Text = "Mécanique";
            this.cmdAchatMec.UseVisualStyleBackColor = true;
            this.cmdAchatMec.Click += new System.EventHandler(this.cmdAchatMec_Click);
            // 
            // cmdAchatElec
            // 
            this.cmdAchatElec.BackColor = System.Drawing.Color.Black;
            this.cmdAchatElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAchatElec.ForeColor = System.Drawing.Color.Navy;
            this.cmdAchatElec.Location = new System.Drawing.Point(16, 18);
            this.cmdAchatElec.Name = "cmdAchatElec";
            this.cmdAchatElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAchatElec.Size = new System.Drawing.Size(121, 25);
            this.cmdAchatElec.TabIndex = 46;
            this.cmdAchatElec.Text = "Électrique";
            this.cmdAchatElec.UseVisualStyleBackColor = true;
            this.cmdAchatElec.Click += new System.EventHandler(this.cmdAchatElec_Click);
            // 
            // fraProjSoum
            // 
            this.fraProjSoum.BackColor = System.Drawing.Color.Black;
            this.fraProjSoum.Controls.Add(this.cmdProjSoumElec);
            this.fraProjSoum.Controls.Add(this.cmdProjSoumMec);
            this.fraProjSoum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraProjSoum.ForeColor = System.Drawing.Color.White;
            this.fraProjSoum.Location = new System.Drawing.Point(315, 60);
            this.fraProjSoum.Name = "fraProjSoum";
            this.fraProjSoum.Padding = new System.Windows.Forms.Padding(0);
            this.fraProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraProjSoum.Size = new System.Drawing.Size(271, 48);
            this.fraProjSoum.TabIndex = 12;
            this.fraProjSoum.TabStop = false;
            this.fraProjSoum.Text = "Projet / Soumission";
            // 
            // cmdProjSoumElec
            // 
            this.cmdProjSoumElec.BackColor = System.Drawing.Color.Black;
            this.cmdProjSoumElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProjSoumElec.ForeColor = System.Drawing.Color.Navy;
            this.cmdProjSoumElec.Location = new System.Drawing.Point(16, 17);
            this.cmdProjSoumElec.Name = "cmdProjSoumElec";
            this.cmdProjSoumElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdProjSoumElec.Size = new System.Drawing.Size(121, 25);
            this.cmdProjSoumElec.TabIndex = 13;
            this.cmdProjSoumElec.Text = "Électrique";
            this.cmdProjSoumElec.UseVisualStyleBackColor = true;
            this.cmdProjSoumElec.Click += new System.EventHandler(this.cmdProjSoumElec_Click);
            // 
            // cmdProjSoumMec
            // 
            this.cmdProjSoumMec.BackColor = System.Drawing.Color.Black;
            this.cmdProjSoumMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProjSoumMec.ForeColor = System.Drawing.Color.Navy;
            this.cmdProjSoumMec.Location = new System.Drawing.Point(143, 17);
            this.cmdProjSoumMec.Name = "cmdProjSoumMec";
            this.cmdProjSoumMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdProjSoumMec.Size = new System.Drawing.Size(121, 25);
            this.cmdProjSoumMec.TabIndex = 14;
            this.cmdProjSoumMec.Text = "Mécanique";
            this.cmdProjSoumMec.UseVisualStyleBackColor = true;
            this.cmdProjSoumMec.Click += new System.EventHandler(this.cmdProjSoumMec_Click);
            // 
            // cmdFermer
            // 
            this.cmdFermer.BackColor = System.Drawing.Color.Black;
            this.cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermer.ForeColor = System.Drawing.Color.Navy;
            this.cmdFermer.Location = new System.Drawing.Point(495, 533);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFermer.Size = new System.Drawing.Size(91, 25);
            this.cmdFermer.TabIndex = 51;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Black;
            this.Label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(412, 219);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label16.Size = new System.Drawing.Size(118, 16);
            this.Label16.TabIndex = 55;
            this.Label16.Text = "(Possibilité de 999)";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label52
            // 
            this.Label52.AutoSize = true;
            this.Label52.BackColor = System.Drawing.Color.Black;
            this.Label52.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label52.ForeColor = System.Drawing.Color.White;
            this.Label52.Location = new System.Drawing.Point(84, 116);
            this.Label52.Name = "Label52";
            this.Label52.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label52.Size = new System.Drawing.Size(37, 16);
            this.Label52.TabIndex = 7;
            this.Label52.Text = "Type";
            // 
            // Label51
            // 
            this.Label51.AutoSize = true;
            this.Label51.BackColor = System.Drawing.Color.Black;
            this.Label51.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label51.ForeColor = System.Drawing.Color.White;
            this.Label51.Location = new System.Drawing.Point(60, 92);
            this.Label51.Name = "Label51";
            this.Label51.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label51.Size = new System.Drawing.Size(15, 16);
            this.Label51.TabIndex = 2;
            this.Label51.Text = "=";
            this.Label51.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.BackColor = System.Drawing.Color.Black;
            this.lblAnnee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnee.ForeColor = System.Drawing.Color.White;
            this.lblAnnee.Location = new System.Drawing.Point(28, 92);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAnnee.Size = new System.Drawing.Size(14, 16);
            this.lblAnnee.TabIndex = 3;
            this.lblAnnee.Text = "3";
            // 
            // Label49
            // 
            this.Label49.AutoSize = true;
            this.Label49.BackColor = System.Drawing.Color.Black;
            this.Label49.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label49.ForeColor = System.Drawing.Color.White;
            this.Label49.Location = new System.Drawing.Point(60, 243);
            this.Label49.Name = "Label49";
            this.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label49.Size = new System.Drawing.Size(15, 16);
            this.Label49.TabIndex = 19;
            this.Label49.Text = "=";
            this.Label49.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.BackColor = System.Drawing.Color.Black;
            this.Label48.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label48.ForeColor = System.Drawing.Color.White;
            this.Label48.Location = new System.Drawing.Point(60, 219);
            this.Label48.Name = "Label48";
            this.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label48.Size = new System.Drawing.Size(15, 16);
            this.Label48.TabIndex = 17;
            this.Label48.Text = "=";
            this.Label48.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label47
            // 
            this.Label47.AutoSize = true;
            this.Label47.BackColor = System.Drawing.Color.Black;
            this.Label47.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label47.ForeColor = System.Drawing.Color.White;
            this.Label47.Location = new System.Drawing.Point(60, 116);
            this.Label47.Name = "Label47";
            this.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label47.Size = new System.Drawing.Size(15, 16);
            this.Label47.TabIndex = 5;
            this.Label47.Text = "=";
            this.Label47.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.BackColor = System.Drawing.Color.Black;
            this.Label46.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.ForeColor = System.Drawing.Color.White;
            this.Label46.Location = new System.Drawing.Point(28, 218);
            this.Label46.Name = "Label46";
            this.Label46.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label46.Size = new System.Drawing.Size(21, 16);
            this.Label46.TabIndex = 20;
            this.Label46.Text = "ZZ";
            // 
            // Label45
            // 
            this.Label45.AutoSize = true;
            this.Label45.BackColor = System.Drawing.Color.Black;
            this.Label45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label45.ForeColor = System.Drawing.Color.White;
            this.Label45.Location = new System.Drawing.Point(28, 194);
            this.Label45.Name = "Label45";
            this.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label45.Size = new System.Drawing.Size(34, 16);
            this.Label45.TabIndex = 16;
            this.Label45.Text = "YYY";
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.BackColor = System.Drawing.Color.Black;
            this.Label44.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label44.ForeColor = System.Drawing.Color.White;
            this.Label44.Location = new System.Drawing.Point(420, 467);
            this.Label44.Name = "Label44";
            this.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label44.Size = new System.Drawing.Size(111, 16);
            this.Label44.TabIndex = 53;
            this.Label44.Text = "(Possibilité de 99)";
            this.Label44.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.BackColor = System.Drawing.Color.Black;
            this.Label43.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.ForeColor = System.Drawing.Color.White;
            this.Label43.Location = new System.Drawing.Point(292, 467);
            this.Label43.Name = "Label43";
            this.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label43.Size = new System.Drawing.Size(66, 16);
            this.Label43.TabIndex = 54;
            this.Label43.Text = "# Révision";
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.BackColor = System.Drawing.Color.Black;
            this.Label42.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.ForeColor = System.Drawing.Color.White;
            this.Label42.Location = new System.Drawing.Point(124, 467);
            this.Label42.Name = "Label42";
            this.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label42.Size = new System.Drawing.Size(48, 16);
            this.Label42.TabIndex = 52;
            this.Label42.Text = "Dessin";
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.BackColor = System.Drawing.Color.Black;
            this.Label41.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.ForeColor = System.Drawing.Color.White;
            this.Label41.Location = new System.Drawing.Point(420, 435);
            this.Label41.Name = "Label41";
            this.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label41.Size = new System.Drawing.Size(111, 16);
            this.Label41.TabIndex = 50;
            this.Label41.Text = "(Possibilité de 99)";
            this.Label41.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.BackColor = System.Drawing.Color.Black;
            this.Label40.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label40.ForeColor = System.Drawing.Color.White;
            this.Label40.Location = new System.Drawing.Point(292, 435);
            this.Label40.Name = "Label40";
            this.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label40.Size = new System.Drawing.Size(61, 16);
            this.Label40.TabIndex = 49;
            this.Label40.Text = "# Version";
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.BackColor = System.Drawing.Color.Black;
            this.Label39.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label39.ForeColor = System.Drawing.Color.White;
            this.Label39.Location = new System.Drawing.Point(124, 435);
            this.Label39.Name = "Label39";
            this.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label39.Size = new System.Drawing.Size(106, 16);
            this.Label39.TabIndex = 48;
            this.Label39.Text = "Programmation";
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.BackColor = System.Drawing.Color.Black;
            this.Label38.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label38.ForeColor = System.Drawing.Color.White;
            this.Label38.Location = new System.Drawing.Point(476, 403);
            this.Label38.Name = "Label38";
            this.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label38.Size = new System.Drawing.Size(58, 16);
            this.Label38.TabIndex = 44;
            this.Label38.Text = "(80 à 99)";
            this.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.BackColor = System.Drawing.Color.Black;
            this.Label37.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.ForeColor = System.Drawing.Color.White;
            this.Label37.Location = new System.Drawing.Point(292, 403);
            this.Label37.Name = "Label37";
            this.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label37.Size = new System.Drawing.Size(133, 16);
            this.Label37.TabIndex = 43;
            this.Label37.Text = "# Visite Non Facturée";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.BackColor = System.Drawing.Color.Black;
            this.Label36.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label36.ForeColor = System.Drawing.Color.White;
            this.Label36.Location = new System.Drawing.Point(420, 387);
            this.Label36.Name = "Label36";
            this.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label36.Size = new System.Drawing.Size(111, 16);
            this.Label36.TabIndex = 42;
            this.Label36.Text = "(Possibilité de 79)";
            this.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.BackColor = System.Drawing.Color.Black;
            this.Label35.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label35.ForeColor = System.Drawing.Color.White;
            this.Label35.Location = new System.Drawing.Point(292, 387);
            this.Label35.Name = "Label35";
            this.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label35.Size = new System.Drawing.Size(51, 16);
            this.Label35.TabIndex = 41;
            this.Label35.Text = "# Visite";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.BackColor = System.Drawing.Color.Black;
            this.Label34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.ForeColor = System.Drawing.Color.White;
            this.Label34.Location = new System.Drawing.Point(124, 387);
            this.Label34.Name = "Label34";
            this.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label34.Size = new System.Drawing.Size(145, 16);
            this.Label34.TabIndex = 40;
            this.Label34.Text = "Technicien && Matériel";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.Color.Black;
            this.Label33.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.ForeColor = System.Drawing.Color.White;
            this.Label33.Location = new System.Drawing.Point(420, 355);
            this.Label33.Name = "Label33";
            this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label33.Size = new System.Drawing.Size(111, 16);
            this.Label33.TabIndex = 39;
            this.Label33.Text = "(Possibilité de 99)";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.BackColor = System.Drawing.Color.Black;
            this.Label32.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label32.ForeColor = System.Drawing.Color.White;
            this.Label32.Location = new System.Drawing.Point(292, 355);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label32.Size = new System.Drawing.Size(51, 16);
            this.Label32.TabIndex = 38;
            this.Label32.Text = "# Visite";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.BackColor = System.Drawing.Color.Black;
            this.Label31.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label31.ForeColor = System.Drawing.Color.White;
            this.Label31.Location = new System.Drawing.Point(124, 355);
            this.Label31.Name = "Label31";
            this.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label31.Size = new System.Drawing.Size(76, 16);
            this.Label31.TabIndex = 37;
            this.Label31.Text = "Technicien";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.BackColor = System.Drawing.Color.Black;
            this.Label30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label30.ForeColor = System.Drawing.Color.White;
            this.Label30.Location = new System.Drawing.Point(476, 323);
            this.Label30.Name = "Label30";
            this.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label30.Size = new System.Drawing.Size(58, 16);
            this.Label30.TabIndex = 35;
            this.Label30.Text = "(80 à 99)";
            this.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.BackColor = System.Drawing.Color.Black;
            this.Label29.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.ForeColor = System.Drawing.Color.White;
            this.Label29.Location = new System.Drawing.Point(292, 323);
            this.Label29.Name = "Label29";
            this.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label29.Size = new System.Drawing.Size(124, 16);
            this.Label29.TabIndex = 36;
            this.Label29.Text = "# Extra Non Facturé";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.BackColor = System.Drawing.Color.Black;
            this.Label28.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.ForeColor = System.Drawing.Color.White;
            this.Label28.Location = new System.Drawing.Point(476, 307);
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label28.Size = new System.Drawing.Size(58, 16);
            this.Label28.TabIndex = 33;
            this.Label28.Text = "(60 à 79)";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.BackColor = System.Drawing.Color.Black;
            this.Label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ForeColor = System.Drawing.Color.White;
            this.Label27.Location = new System.Drawing.Point(292, 307);
            this.Label27.Name = "Label27";
            this.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label27.Size = new System.Drawing.Size(97, 16);
            this.Label27.TabIndex = 34;
            this.Label27.Text = "# Extra Facturé";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.BackColor = System.Drawing.Color.Black;
            this.Label26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.ForeColor = System.Drawing.Color.White;
            this.Label26.Location = new System.Drawing.Point(476, 291);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label26.Size = new System.Drawing.Size(58, 16);
            this.Label26.TabIndex = 28;
            this.Label26.Text = "(50 à 59)";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.BackColor = System.Drawing.Color.Black;
            this.Label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.ForeColor = System.Drawing.Color.White;
            this.Label25.Location = new System.Drawing.Point(292, 291);
            this.Label25.Name = "Label25";
            this.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label25.Size = new System.Drawing.Size(108, 16);
            this.Label25.TabIndex = 29;
            this.Label25.Text = "# Mise en service";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.Black;
            this.Label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.White;
            this.Label24.Location = new System.Drawing.Point(476, 275);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label24.Size = new System.Drawing.Size(58, 16);
            this.Label24.TabIndex = 27;
            this.Label24.Text = "(01 à 49)";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.BackColor = System.Drawing.Color.Black;
            this.Label23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.Color.White;
            this.Label23.Location = new System.Drawing.Point(292, 275);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label23.Size = new System.Drawing.Size(87, 16);
            this.Label23.TabIndex = 26;
            this.Label23.Text = "# du Panneau";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.BackColor = System.Drawing.Color.Black;
            this.Label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.Color.White;
            this.Label22.Location = new System.Drawing.Point(124, 275);
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label22.Size = new System.Drawing.Size(79, 16);
            this.Label22.TabIndex = 25;
            this.Label22.Text = "Fabrication";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.BackColor = System.Drawing.Color.Black;
            this.Label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.Color.White;
            this.Label21.Location = new System.Drawing.Point(420, 243);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label21.Size = new System.Drawing.Size(111, 16);
            this.Label21.TabIndex = 24;
            this.Label21.Text = "(Possibilité de 99)";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.BackColor = System.Drawing.Color.Black;
            this.Label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.White;
            this.Label20.Location = new System.Drawing.Point(292, 243);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label20.Size = new System.Drawing.Size(66, 16);
            this.Label20.TabIndex = 23;
            this.Label20.Text = "# Révision";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.Color.Black;
            this.Label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.Color.White;
            this.Label19.Location = new System.Drawing.Point(124, 243);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(80, 16);
            this.Label19.TabIndex = 22;
            this.Label19.Text = "Soumission";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.Color.Black;
            this.Label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.Color.White;
            this.Label18.Location = new System.Drawing.Point(84, 243);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(27, 16);
            this.Label18.TabIndex = 21;
            this.Label18.Text = "Ex.";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Black;
            this.Label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.White;
            this.Label17.Location = new System.Drawing.Point(84, 219);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(168, 16);
            this.Label17.TabIndex = 18;
            this.Label17.Text = "# Séquentiel de 3 chiffres";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Black;
            this.Label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(156, 180);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(70, 16);
            this.Label10.TabIndex = 15;
            this.Label10.Text = "9 = Dessin";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Black;
            this.Label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(156, 164);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(154, 16);
            this.Label8.TabIndex = 11;
            this.Label8.Text = "7 = Technicien && Matériel";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(156, 148);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(91, 16);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "5 = Technicien";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Black;
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(156, 132);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(94, 16);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "3 = Fabrication";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(156, 116);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(98, 16);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "1 = Soumission";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Black;
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(28, 116);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(14, 16);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "X";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(84, 92);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(48, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Année";
            // 
            // lblExemple
            // 
            this.lblExemple.AutoSize = true;
            this.lblExemple.BackColor = System.Drawing.Color.Black;
            this.lblExemple.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemple.ForeColor = System.Drawing.Color.White;
            this.lblExemple.Location = new System.Drawing.Point(312, 30);
            this.lblExemple.Name = "lblExemple";
            this.lblExemple.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExemple.Size = new System.Drawing.Size(128, 16);
            this.lblExemple.TabIndex = 1;
            this.lblExemple.Text = "Exemple : 3XYYY-ZZ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(238, 9);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(242, 19);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "NUMÉROTATION DE DOSSIER";
            // 
            // ChoixProjSoum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 564);
            this.ControlBox = false;
            this.Controls.Add(this.fraReception);
            this.Controls.Add(this.fraAchat);
            this.Controls.Add(this.fraProjSoum);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label52);
            this.Controls.Add(this.Label51);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.Label49);
            this.Controls.Add(this.Label48);
            this.Controls.Add(this.Label47);
            this.Controls.Add(this.Label46);
            this.Controls.Add(this.Label45);
            this.Controls.Add(this.Label44);
            this.Controls.Add(this.Label43);
            this.Controls.Add(this.Label42);
            this.Controls.Add(this.Label41);
            this.Controls.Add(this.Label40);
            this.Controls.Add(this.Label39);
            this.Controls.Add(this.Label38);
            this.Controls.Add(this.Label37);
            this.Controls.Add(this.Label36);
            this.Controls.Add(this.Label35);
            this.Controls.Add(this.Label34);
            this.Controls.Add(this.Label33);
            this.Controls.Add(this.Label32);
            this.Controls.Add(this.Label31);
            this.Controls.Add(this.Label30);
            this.Controls.Add(this.Label29);
            this.Controls.Add(this.Label28);
            this.Controls.Add(this.Label27);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.Label24);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblExemple);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixProjSoum";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.ChoixProjSoum";
            this.Load += new System.EventHandler(this.ChoixProjSoum_Load);
            this.fraReception.ResumeLayout(false);
            this.fraAchat.ResumeLayout(false);
            this.fraProjSoum.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        public string IdNoEmploye;
        public int m_iNoGroupe;
        public void cmdAchatElec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                ACHAT objAchat;
                var bOuvert = default(bool);
                Cursor.Current = Cursors.WaitCursor;
                for (X = 0; X <= Application.OpenForms.Count - 1; X++)
                {
                    if (Application.OpenForms[X].Text == "ACHAT électrique")
                    {
                        bOuvert = true;
                        break;
                    }
                }
                if (bOuvert == false)
                {
                    Form f = new ACHAT(EnumCatalogue.ELECTRIQUE);
                    f.MdiParent = Conteneur.Mdi;
                    f.Show();
                }
                else
                {
                    ///application.OpenForms[X].WindowState = FormWindowState.Normal;
                    ///application.OpenForms[X].BringToFront();
                    Close();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixProjSoum", "cmdAchatElec_Click", ex);
            }
        }
        private void cmdAchatMec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                var bOuvert = default(bool);
                Cursor.Current = Cursors.WaitCursor;
                for (X = 0; X <= Application.OpenForms.Count - 1; X++)
                {
                    if (Application.OpenForms[X].Text == "ACHAT mécanique")
                    {
                        bOuvert = true;
                        break;
                    }
                }
                if (bOuvert == false)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Form f = new ACHAT(EnumCatalogue.MECANIQUE);
                    f.MdiParent = Conteneur.Mdi;
                    f.Show();
                }
                else
                {
                    ///application.OpenForms[X].WindowState = FormWindowState.Normal;
                    ///application.OpenForms[X].BringToFront();
                    Close();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixProjSoum", "cmdAchatMec_Click", ex);
            }
        }
        private void cmdFermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixProjSoum", "cmdFermer_Click", ex);
            }
        }
        private void cmdProjSoumElec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ProjSoumElec f = new ProjSoumElec();
                f.MdiParent = Conteneur.Mdi;
                f.Show();
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixProjSoum", "cmdProjSoumElec_Click", ex);
            }
        }
        private void cmdProjSoumMec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ProjSoumMec f = new ProjSoumMec();
                f.MdiParent = Conteneur.Mdi;
                f.Show();
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixProjSoum", "cmdProjSoumMec_Click", ex);
            }
        }
        private void cmdReceptionElec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstGroupe;
                rstGroupe = new Recordset();
                rstGroupe.Open("SELECT ModificationReception FROM Groupes WHERE IDGroupe = " + m_iNoGroupe, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if ((bool)rstGroupe.Fields["ModificationReception"].Value == true)
                {
                    ReceptionElec f=new ReceptionElec(IdNoEmploye,"Transfert depuis l'assistant");
                    f.MdiParent = Conteneur.Mdi;
                    f.Show();
                    rstGroupe.Close();
                    rstGroupe = null;
                    Close();
                }
                else
                {
                    MessageBox.Show("Accès refusé!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rstGroupe.Close();
                    rstGroupe = null;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixProjSoum", "cmdReceptionElec_Click", ex);
            }
        }
        private void cmdReceptionMec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstGroupe = new ADODB.Recordset();
                rstGroupe.Open("SELECT ModificationReception FROM Groupes WHERE IDGroupe = " + m_iNoGroupe, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if ((bool)rstGroupe.Fields["ModificationReception"].Value == true)
                {
                    ReceptionMec f =new ReceptionMec(IdNoEmploye,"Transfert depuis l'assistant => Reception mécanique");
                    f.MdiParent = Conteneur.Mdi;
                    f.Show();
                    rstGroupe.Close();
                    rstGroupe = null;
                    Close();
                }
                else
                {
                    MessageBox.Show("Accès refusé!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rstGroupe.Close();
                    rstGroupe = null;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixProjSoum", "cmdReceptionMec_Click", ex);
            }
        }
        private void ChoixProjSoum_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                lblExemple.Text = "Exemple : " + Droite(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today).ToString(), 1) + "XYYY-ZZ";
                lblAnnee.Text = Droite(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today).ToString(), 1);
                ActiverBoutonsGroupe();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixProjSoum", "Form_Load", ex);
            }
        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
                if (g_bAffichageSoumissionsMec == true | g_bAffichageProjetsMec == true)
                {
                    cmdProjSoumMec.Enabled = true;
                }
                else
                {
                    cmdProjSoumMec.Enabled = false;
                }
                if (g_bAffichageSoumissionsElec == true | g_bAffichageProjetsElec == true)
                {
                    cmdProjSoumElec.Enabled = true;
                }
                else
                {
                    cmdProjSoumElec.Enabled = false;
                }
                if (g_bAffichageAchats == true)
                {
                    cmdAchatElec.Enabled = true;
                    cmdAchatMec.Enabled = true;
                }
                else
                {
                    cmdAchatElec.Enabled = false;
                    cmdAchatMec.Enabled = false;
                }
                if (g_bModificationReception == true)
                {
                    cmdReceptionElec.Enabled = true;
                    cmdReceptionMec.Enabled = true;
                }
                else
                {
                    cmdReceptionElec.Enabled = false;
                    cmdReceptionMec.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixProjSoum", "ActiverBoutonsGroupe", ex);
            }
        }
    }
}