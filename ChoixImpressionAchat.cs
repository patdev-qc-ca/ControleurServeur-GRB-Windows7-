using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;
using static ControleurServeur.Program;
using ADODB;
#pragma warning disable CS0649
namespace ControleurServeur
{
    internal class ChoixImpressionAchat : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixImpressionAchat() : base()
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
        internal Button cmdAnnuler;
        internal Button cmdImprimer;
        internal Label Label4;
        internal Label Label3;
        internal GroupBox fraDate;
        internal RadioButton _optCategorie_2;
        internal RadioButton _optCategorie_7;
        internal RadioButton _optCategorie_6;
        internal RadioButton _optCategorie_5;
        internal RadioButton _optCategorie_4;
        internal RadioButton _optCategorie_3;
        internal RadioButton _optCategorie_1;
        internal RadioButton _optCategorie_0;
        internal Label Label5;
        internal Label Label28;
        internal Label Label27;
        internal Label Label26;
        internal Label Label25;
        internal Label Label24;
        internal Label Label2;
        internal Label Label1;
        private DateTimePicker mskDateFin;
        internal GroupBox fraCategorie;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.fraDate = new System.Windows.Forms.GroupBox();
            this.mskDateFin = new System.Windows.Forms.DateTimePicker();
            this.mskDateDebut = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.fraCategorie = new System.Windows.Forms.GroupBox();
            this._optCategorie_2 = new System.Windows.Forms.RadioButton();
            this._optCategorie_7 = new System.Windows.Forms.RadioButton();
            this._optCategorie_6 = new System.Windows.Forms.RadioButton();
            this._optCategorie_5 = new System.Windows.Forms.RadioButton();
            this._optCategorie_4 = new System.Windows.Forms.RadioButton();
            this._optCategorie_3 = new System.Windows.Forms.RadioButton();
            this._optCategorie_1 = new System.Windows.Forms.RadioButton();
            this._optCategorie_0 = new System.Windows.Forms.RadioButton();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.fraDate.SuspendLayout();
            this.fraCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.ForeColor = System.Drawing.Color.White;
            this.cmdAnnuler.Location = new System.Drawing.Point(265, 405);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(89, 25);
            this.cmdAnnuler.TabIndex = 25;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.BackColor = System.Drawing.Color.Black;
            this.cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimer.ForeColor = System.Drawing.Color.White;
            this.cmdImprimer.Location = new System.Drawing.Point(170, 405);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImprimer.Size = new System.Drawing.Size(89, 25);
            this.cmdImprimer.TabIndex = 26;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // fraDate
            // 
            this.fraDate.BackColor = System.Drawing.Color.Black;
            this.fraDate.Controls.Add(this.mskDateFin);
            this.fraDate.Controls.Add(this.mskDateDebut);
            this.fraDate.Controls.Add(this.Label4);
            this.fraDate.Controls.Add(this.Label3);
            this.fraDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraDate.ForeColor = System.Drawing.Color.White;
            this.fraDate.Location = new System.Drawing.Point(71, 241);
            this.fraDate.Name = "fraDate";
            this.fraDate.Padding = new System.Windows.Forms.Padding(0);
            this.fraDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraDate.Size = new System.Drawing.Size(265, 126);
            this.fraDate.TabIndex = 18;
            this.fraDate.TabStop = false;
            this.fraDate.Text = "Date (AA-MM-JJ)";
            // 
            // mskDateFin
            // 
            this.mskDateFin.Location = new System.Drawing.Point(63, 56);
            this.mskDateFin.Name = "mskDateFin";
            this.mskDateFin.Size = new System.Drawing.Size(180, 20);
            this.mskDateFin.TabIndex = 26;
            this.mskDateFin.ValueChanged += new System.EventHandler(this.mskDateFin_ValueChanged);
            // 
            // mskDateDebut
            // 
            this.mskDateDebut.CalendarForeColor = System.Drawing.Color.White;
            this.mskDateDebut.CalendarMonthBackground = System.Drawing.Color.Navy;
            this.mskDateDebut.Location = new System.Drawing.Point(64, 24);
            this.mskDateDebut.Name = "mskDateDebut";
            this.mskDateDebut.Size = new System.Drawing.Size(179, 20);
            this.mskDateDebut.TabIndex = 25;
            this.mskDateDebut.Value = new System.DateTime(2024, 9, 12, 0, 0, 0, 0);
            this.mskDateDebut.ValueChanged += new System.EventHandler(this.mskDateDebut_ValueChanged);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Black;
            this.Label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(32, 56);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(25, 17);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Au :";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(32, 24);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(25, 17);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Du :";
            // 
            // fraCategorie
            // 
            this.fraCategorie.BackColor = System.Drawing.Color.Black;
            this.fraCategorie.Controls.Add(this._optCategorie_2);
            this.fraCategorie.Controls.Add(this._optCategorie_7);
            this.fraCategorie.Controls.Add(this._optCategorie_6);
            this.fraCategorie.Controls.Add(this._optCategorie_5);
            this.fraCategorie.Controls.Add(this._optCategorie_4);
            this.fraCategorie.Controls.Add(this._optCategorie_3);
            this.fraCategorie.Controls.Add(this._optCategorie_1);
            this.fraCategorie.Controls.Add(this._optCategorie_0);
            this.fraCategorie.Controls.Add(this.Label5);
            this.fraCategorie.Controls.Add(this.Label28);
            this.fraCategorie.Controls.Add(this.Label27);
            this.fraCategorie.Controls.Add(this.Label26);
            this.fraCategorie.Controls.Add(this.Label25);
            this.fraCategorie.Controls.Add(this.Label24);
            this.fraCategorie.Controls.Add(this.Label2);
            this.fraCategorie.Controls.Add(this.Label1);
            this.fraCategorie.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraCategorie.ForeColor = System.Drawing.Color.White;
            this.fraCategorie.Location = new System.Drawing.Point(71, 72);
            this.fraCategorie.Name = "fraCategorie";
            this.fraCategorie.Padding = new System.Windows.Forms.Padding(0);
            this.fraCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraCategorie.Size = new System.Drawing.Size(265, 163);
            this.fraCategorie.TabIndex = 0;
            this.fraCategorie.TabStop = false;
            this.fraCategorie.Text = "Catégories d\'ACHAT";
            // 
            // _optCategorie_2
            // 
            this._optCategorie_2.AutoSize = true;
            this._optCategorie_2.BackColor = System.Drawing.Color.Black;
            this._optCategorie_2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCategorie_2.ForeColor = System.Drawing.Color.White;
            this._optCategorie_2.Location = new System.Drawing.Point(24, 56);
            this._optCategorie_2.Name = "_optCategorie_2";
            this._optCategorie_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCategorie_2.Size = new System.Drawing.Size(76, 18);
            this._optCategorie_2.TabIndex = 5;
            this._optCategorie_2.TabStop = true;
            this._optCategorie_2.Text = "Formation";
            this._optCategorie_2.UseVisualStyleBackColor = true;
            // 
            // _optCategorie_7
            // 
            this._optCategorie_7.AutoSize = true;
            this._optCategorie_7.BackColor = System.Drawing.Color.Black;
            this._optCategorie_7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCategorie_7.ForeColor = System.Drawing.Color.White;
            this._optCategorie_7.Location = new System.Drawing.Point(24, 136);
            this._optCategorie_7.Name = "_optCategorie_7";
            this._optCategorie_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCategorie_7.Size = new System.Drawing.Size(141, 18);
            this._optCategorie_7.TabIndex = 15;
            this._optCategorie_7.TabStop = true;
            this._optCategorie_7.Text = "Équipement && outillage";
            this._optCategorie_7.UseVisualStyleBackColor = true;
            // 
            // _optCategorie_6
            // 
            this._optCategorie_6.AutoSize = true;
            this._optCategorie_6.BackColor = System.Drawing.Color.Black;
            this._optCategorie_6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCategorie_6.ForeColor = System.Drawing.Color.White;
            this._optCategorie_6.Location = new System.Drawing.Point(24, 120);
            this._optCategorie_6.Name = "_optCategorie_6";
            this._optCategorie_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCategorie_6.Size = new System.Drawing.Size(162, 18);
            this._optCategorie_6.TabIndex = 13;
            this._optCategorie_6.TabStop = true;
            this._optCategorie_6.Text = "Équipement && outillage PPE";
            this._optCategorie_6.UseVisualStyleBackColor = true;
            // 
            // _optCategorie_5
            // 
            this._optCategorie_5.AutoSize = true;
            this._optCategorie_5.BackColor = System.Drawing.Color.Black;
            this._optCategorie_5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCategorie_5.ForeColor = System.Drawing.Color.White;
            this._optCategorie_5.Location = new System.Drawing.Point(24, 104);
            this._optCategorie_5.Name = "_optCategorie_5";
            this._optCategorie_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCategorie_5.Size = new System.Drawing.Size(136, 18);
            this._optCategorie_5.TabIndex = 11;
            this._optCategorie_5.TabStop = true;
            this._optCategorie_5.Text = "Équipement de bureau";
            this._optCategorie_5.UseVisualStyleBackColor = true;
            // 
            // _optCategorie_4
            // 
            this._optCategorie_4.AutoSize = true;
            this._optCategorie_4.BackColor = System.Drawing.Color.Black;
            this._optCategorie_4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCategorie_4.ForeColor = System.Drawing.Color.White;
            this._optCategorie_4.Location = new System.Drawing.Point(24, 88);
            this._optCategorie_4.Name = "_optCategorie_4";
            this._optCategorie_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCategorie_4.Size = new System.Drawing.Size(71, 18);
            this._optCategorie_4.TabIndex = 9;
            this._optCategorie_4.TabStop = true;
            this._optCategorie_4.Text = "Bâtiment";
            this._optCategorie_4.UseVisualStyleBackColor = true;
            // 
            // _optCategorie_3
            // 
            this._optCategorie_3.AutoSize = true;
            this._optCategorie_3.BackColor = System.Drawing.Color.Black;
            this._optCategorie_3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCategorie_3.ForeColor = System.Drawing.Color.White;
            this._optCategorie_3.Location = new System.Drawing.Point(24, 72);
            this._optCategorie_3.Name = "_optCategorie_3";
            this._optCategorie_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCategorie_3.Size = new System.Drawing.Size(100, 18);
            this._optCategorie_3.TabIndex = 7;
            this._optCategorie_3.TabStop = true;
            this._optCategorie_3.Text = "Logiciel interne";
            this._optCategorie_3.UseVisualStyleBackColor = true;
            // 
            // _optCategorie_1
            // 
            this._optCategorie_1.AutoSize = true;
            this._optCategorie_1.BackColor = System.Drawing.Color.Black;
            this._optCategorie_1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCategorie_1.ForeColor = System.Drawing.Color.White;
            this._optCategorie_1.Location = new System.Drawing.Point(24, 40);
            this._optCategorie_1.Name = "_optCategorie_1";
            this._optCategorie_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCategorie_1.Size = new System.Drawing.Size(134, 18);
            this._optCategorie_1.TabIndex = 3;
            this._optCategorie_1.TabStop = true;
            this._optCategorie_1.Text = "Réparation outils GRB";
            this._optCategorie_1.UseVisualStyleBackColor = true;
            // 
            // _optCategorie_0
            // 
            this._optCategorie_0.AutoSize = true;
            this._optCategorie_0.BackColor = System.Drawing.Color.Black;
            this._optCategorie_0.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCategorie_0.ForeColor = System.Drawing.Color.White;
            this._optCategorie_0.Location = new System.Drawing.Point(24, 24);
            this._optCategorie_0.Name = "_optCategorie_0";
            this._optCategorie_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCategorie_0.Size = new System.Drawing.Size(102, 18);
            this._optCategorie_0.TabIndex = 1;
            this._optCategorie_0.TabStop = true;
            this._optCategorie_0.Text = "Stocks plancher";
            this._optCategorie_0.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(200, 56);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(19, 14);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "83";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.BackColor = System.Drawing.Color.Black;
            this.Label28.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.ForeColor = System.Drawing.Color.White;
            this.Label28.Location = new System.Drawing.Point(200, 136);
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label28.Size = new System.Drawing.Size(19, 14);
            this.Label28.TabIndex = 16;
            this.Label28.Text = "99";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.BackColor = System.Drawing.Color.Black;
            this.Label27.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ForeColor = System.Drawing.Color.White;
            this.Label27.Location = new System.Drawing.Point(200, 120);
            this.Label27.Name = "Label27";
            this.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label27.Size = new System.Drawing.Size(19, 14);
            this.Label27.TabIndex = 14;
            this.Label27.Text = "98";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.BackColor = System.Drawing.Color.Black;
            this.Label26.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.ForeColor = System.Drawing.Color.White;
            this.Label26.Location = new System.Drawing.Point(200, 104);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label26.Size = new System.Drawing.Size(19, 14);
            this.Label26.TabIndex = 12;
            this.Label26.Text = "97";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.BackColor = System.Drawing.Color.Black;
            this.Label25.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.ForeColor = System.Drawing.Color.White;
            this.Label25.Location = new System.Drawing.Point(200, 88);
            this.Label25.Name = "Label25";
            this.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label25.Size = new System.Drawing.Size(19, 14);
            this.Label25.TabIndex = 10;
            this.Label25.Text = "95";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.Black;
            this.Label24.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.White;
            this.Label24.Location = new System.Drawing.Point(200, 72);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label24.Size = new System.Drawing.Size(19, 14);
            this.Label24.TabIndex = 8;
            this.Label24.Text = "85";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(200, 40);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(19, 14);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "80";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(200, 24);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(43, 14);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "01 à 12";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ChoixImpressionAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(387, 442);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.fraDate);
            this.Controls.Add(this.fraCategorie);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixImpressionAchat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.ChoixImpressionAchat";
            this.Load += new System.EventHandler(this.ChoixImpressionAchat_Load);
            this.fraDate.ResumeLayout(false);
            this.fraCategorie.ResumeLayout(false);
            this.fraCategorie.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private DateTimePicker mskDateDebut;
        private const int I_CATEGORIE_MOIS = 0;
        private const int I_CATEGORIE_80 = 1;
        private const int I_CATEGORIE_83 = 2;
        private const int I_CATEGORIE_85 = 3;
        private const int I_CATEGORIE_95 = 4;
        private const int I_CATEGORIE_97 = 5;
        private const int I_CATEGORIE_98 = 6;
        private const int I_CATEGORIE_99 = 7;
        private enum enumDate
        {
            I_DATE_DEBUT = 0,
            I_DATE_FIN = 1
        }
        private enumDate m_eDate;
        private EnumCatalogue m_eCatalogue;
        private int m_iCategorie;
        private EnumCatalogue eCatalogue;
        public ChoixImpressionAchat(EnumCatalogue eCatalogue)
        {
            InitializeComponent();
            eCatalogue = eCatalogue;
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdDateDebut_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                var bAfficherDate = default(bool);
                m_eDate = enumDate.I_DATE_DEBUT;
                if (!string.IsNullOrEmpty(mskDateDebut.Text))
                {
                    if (Strings.InStr(1, mskDateDebut.Text, "_") == 0)
                    {
                        mskDateDebut.Value = ConvertDateTexte(mskDateDebut.Text);
                    }
                    else
                    {
                        bAfficherDate = true;
                    }
                }
                else
                {
                    bAfficherDate = true;
                }
                if (bAfficherDate == true)
                {
                    mskDateDebut.Value = DateTime.Today;
                }
                mskDateDebut.Visible = true;
                mskDateDebut.Focus();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "cmdDateDebut_Click", ex);
            }
        }
        private void cmdDateFin_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                var bAfficherDate = default(bool);
                m_eDate = enumDate.I_DATE_FIN;
                if (!string.IsNullOrEmpty(mskDateFin.Text))
                {
                    if (Strings.InStr(1, mskDateFin.Text, "_") == 0)
                    {
                        mskDateDebut.Value = ConvertDateTexte(mskDateDebut.Text);
                    }
                    else
                    {
                        bAfficherDate = true;
                    }
                }
                else
                {
                    bAfficherDate = true;
                }
                if (bAfficherDate == true)
                {
                    mskDateDebut.Value = DateTime.Today;
                }
                mskDateDebut.Visible = true;
                mskDateDebut.Focus();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "cmdDateFin_Click", ex);
            }
        }
        [Obsolete]
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstTotal;
                string sSelect;
                string sFrom;
                var sWhere = default(string);
                var sNumeroDebut = default(string);
                var sNumeroFin = default(string);
                /// modification suite remplacement des maskbox par des datepicker
                /// PWE 2024-09-05
                if (mskDateDebut.Value.ToShortDateString().Length != 10 | mskDateFin.Value.ToShortDateString().Length != 10) 
                {
                    MessageBox.Show("Date invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                switch (m_eCatalogue)
                {
                    case EnumCatalogue.ELECTRIQUE:
                        {
                            sNumeroDebut = "E" + mskDateDebut.Text.Substring(4, 1) + "3000-";
                            sNumeroFin = "E" + mskDateFin.Text.Substring(4, 1) + "3000-"; break;
                        }
                    case EnumCatalogue.MECANIQUE:
                        {
                            sNumeroDebut = "M" + mskDateDebut.Text.Substring(4, 1) + "3000-";
                            sNumeroFin = "M" + mskDateFin.Text.Substring(4, 1) + "3000-"; break;
                        }
                }
                sSelect = "ACHAT.IDACHAT, ACHAT.INDEXACHAT, ACHAT.RAISON, " +
                    "ACHAT.DATEACHAT, EMPLOYÉS.INITIALE, " + 
                    "ACHAT_PIECES.PIECE, ACHAT_PIECES.QTÉ, " + 
                    "ACHAT_PIECES.DESC_FR, ACHAT_PIECES.MANUFACT, " + 
                    "ACHAT_PIECES.PRIX_LIST , ACHAT_PIECES.ESCOMPTE, " + 
                    "ACHAT_PIECES.PRIX_NET, FOURNISSEUR.NOMFOURNISSEUR, " + 
                    "ACHAT_PIECES.PRIX_TOTAL";
                sFrom = "FOURNISSEUR INNER JOIN " + "(EMPLOYÉS INNER JOIN " + "(ACHAT " +
                    "INNER JOIN ACHAT_PIECES ON " + "(ACHAT.INDEXACHAT = ACHAT_PIECES.INDEXACHAT) " +
                    "AND (ACHAT.IDACHAT = ACHAT_PIECES.IDACHAT)) " + "ON EMPLOYÉS.NOEMPLOYE = ACHAT.ACHETEUR) " +
                    "ON FOURNISSEUR.IDFRS = ACHAT_PIECES.IDFRS";
                switch (m_iCategorie)
                {
                    case I_CATEGORIE_MOIS: { sWhere = "ACHAT.IDAchat BETWEEN '" + sNumeroDebut + mskDateDebut.Text.Substring(6, 2) + "' AND '" + sNumeroFin + mskDateFin.Text.Substring(6, 2) + "' AND DateAchat BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'"; break; }
                    case I_CATEGORIE_80: { sWhere = "ACHAT.IDAchat BETWEEN '" + sNumeroDebut + "80' AND '" + sNumeroFin + "80' AND DateAchat BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'"; break; }
                    case I_CATEGORIE_83: { sWhere = "ACHAT.IDAchat BETWEEN '" + sNumeroDebut + "83' AND '" + sNumeroFin + "83' AND DateAchat BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'"; break; }
                    case I_CATEGORIE_85: { sWhere = "ACHAT.IDAchat BETWEEN '" + sNumeroDebut + "85' AND '" + sNumeroFin + "85' AND DateAchat BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'"; break; }
                    case I_CATEGORIE_95: { sWhere = "ACHAT.IDAchat BETWEEN '" + sNumeroDebut + "95' AND '" + sNumeroFin + "95' AND DateAchat BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'"; break; }
                    case I_CATEGORIE_97: { sWhere = "ACHAT.IDAchat BETWEEN '" + sNumeroDebut + "97' AND '" + sNumeroFin + "97' AND DateAchat BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'"; break; }
                    case I_CATEGORIE_98: { sWhere = "ACHAT.IDAchat BETWEEN '" + sNumeroDebut + "98' AND '" + sNumeroFin + "98' AND DateAchat BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'"; break; }
                    case I_CATEGORIE_99: { sWhere = "ACHAT.IDAchat BETWEEN '" + sNumeroDebut + "99' AND '" + sNumeroFin + "99' AND DateAchat BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'"; break; }
                }
                rstTotal = new Recordset();
                rstPiece = new Recordset();
                /// on ne peut pas faire un sum sur un nvarchar(50)
                rstTotal.Open("SELECT Prix_total As PrixTotal FROM ACHAT_Pieces " +
                    "INNER JOIN ACHAT ON (ACHAT.IDAchat = ACHAT_Pieces.IDAchat) AND (ACHAT.IndexAchat = ACHAT_Pieces.IndexAchat) " +
                    "WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                double total = 0d;
                if (!rstTotal.EOF)
                {
                    total += double.Parse($"{rstTotal.Fields[0].Value}");
                }
                rstPiece.Open("SELECT " + sSelect + " FROM " + sFrom + " WHERE " + sWhere + " ORDER BY ACHAT.IndexAchat, PIECE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstPiece.EOF == true)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Aucun ACHAT à imprimer!", Application.ProductName+".ChoixImpressionAchat.Imprimer.NoData", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rstTotal.Close();
                    rstTotal = null;
                    rstPiece.Close();
                    rstPiece = null;
                    return;
                }
                ViewListeAchats.Orientation = false;
                ViewListeAchats.lblTotal.Text = (string)(rstTotal.Fields["PrixTotal"].Value).Replace(".", ",");
                rstTotal.Close();
                rstTotal = null;
                switch (m_iCategorie)
                {
                    case I_CATEGORIE_MOIS:
                        {
                            if ((mskDateDebut.Text.Substring(6, 2) ?? "") == (mskDateFin.Text.Substring(6, 2) ?? "") & (Gauche(mskDateDebut.Text, 4) ?? "") == (Gauche(mskDateFin.Text, 4) ?? ""))
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + mskDateDebut.Text.Substring(6, 2);
                            }
                            else
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + mskDateDebut.Text.Substring(6, 2) + " à " + sNumeroFin + mskDateFin.Text.Substring(6, 2);
                            }
                            break;
                        }
                    case I_CATEGORIE_80:
                        {
                            if ((Gauche(mskDateDebut.Text, 4) ?? "") == (Gauche(mskDateFin.Text, 4) ?? ""))
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "80";
                            }
                            else
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "80 à " + sNumeroFin + "80";
                            }
                            break;
                        }
                    case I_CATEGORIE_83:
                        {
                            if ((Gauche(mskDateDebut.Text, 4) ?? "") == (Gauche(mskDateFin.Text, 4) ?? ""))
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "83";
                            }
                            else
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "83 à " + sNumeroFin + "83";
                            }
                            break;
                        }
                    case I_CATEGORIE_85:
                        {
                            if ((Gauche(mskDateDebut.Text, 4) ?? "") == (Gauche(mskDateFin.Text, 4) ?? ""))
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "85";
                            }
                            else
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "85 à " + sNumeroFin + "85";
                            }
                            break;
                        }
                    case I_CATEGORIE_95:
                        {
                            if ((Gauche(mskDateDebut.Text, 4) ?? "") == (Gauche(mskDateFin.Text, 4) ?? ""))
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "95";
                            }
                            else
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "95 à " + sNumeroFin + "95";
                            }
                            break;
                        }
                    case I_CATEGORIE_97:
                        {
                            if ((Gauche(mskDateDebut.Text, 4) ?? "") == (Gauche(mskDateFin.Text, 4) ?? ""))
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "97";
                            }
                            else
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "97 à " + sNumeroFin + "97";
                            }
                            break;
                        }
                    case I_CATEGORIE_98:
                        {
                            if ((Gauche(mskDateDebut.Text, 4) ?? "") == (Gauche(mskDateFin.Text, 4) ?? ""))
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "98";
                            }
                            else
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "98 à " + sNumeroFin + "98";
                            }
                            break;
                        }
                    case I_CATEGORIE_99:
                        {
                            if ((Gauche(mskDateDebut.Text, 4) ?? "") == (Gauche(mskDateFin.Text, 4) ?? ""))
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "99";
                            }
                            else
                            {
                                ViewListeAchats.lblNumero.Text = sNumeroDebut + "99 à " + sNumeroFin + "99";
                            }
                            break;
                        }
                }
                ViewListeAchats.lblDate.Text = "Du " + mskDateDebut.Text + " Au " + mskDateFin.Text;
                /// modification format de sortie du grand total lors de l'impression au format "Money"
                /// PWE 2024-11-06                
                ViewListeAchats.lblGTotal.Text = Math.Round(total,2).ToString()+"$";
                rstPiece.Close();
                rstPiece = null;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "cmdImprimer_Click", ex);
            }
        }
        public void Afficher(EnumCatalogue eCatalogue)
        {
            try
            {
                _optCategorie_0.Checked = true;
                m_eCatalogue = eCatalogue;
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "Afficher", ex);
            }
        }
        [Obsolete]
        private void mskDateDebut_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "mskDateDebut_GotFocus", ex);
            }
        }
        [Obsolete]
        private void mskDateFin_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "mskDateFin_GotFocus", ex);
            }
        }
        private void mskDateDebut_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sDate;

                mskDateDebut.Text = string.Empty;
                sDate = mskDateDebut.Text;
                if (sDate.Length == 8)
                {
                    MessageBox.Show("Le format AA-MM-JJ n'est plus accecpté");
                    if (!Information.IsDate(sDate))
                    {
                        MessageBox.Show("Formatage de date invalide");
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "mskDateDebut_LostFocus", ex);
            }
        }
        [Obsolete]// date sur 8chiffre 
        private void mskDateFin_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sDate;
                mskDateFin.Text = string.Empty;
                sDate = mskDateFin.Text;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "mskDateFin_LostFocus", ex);
            }
        }
        private void mvwDate_DateClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                switch (m_eDate)
                {
                    case enumDate.I_DATE_DEBUT: { mskDateDebut.Text = ConvertDate(mskDateDebut.Value); break; }
                    case enumDate.I_DATE_FIN: { mskDateFin.Text = ConvertDate(mskDateDebut.Value); break; }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionAchat", "mvwDate_DateClick", ex);
            }
        }
        private void optCategorie_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
        }

        private void ChoixImpressionAchat_Load(object sender, EventArgs e)
        {
            mskDateDebut.Text = DateTime.Today.AddDays(-7).ToShortDateString();
            mskDateFin.Value = DateTime.Today;
        }

        private void mskDateDebut_ValueChanged(object sender, EventArgs e)
        {
            mskDateDebut.Text=mskDateDebut.Value.ToShortDateString();
        }

        private void mskDateFin_ValueChanged(object sender, EventArgs e)
        {
            mskDateFin.Text = mskDateFin.Value.ToShortDateString();
        }
    }
}