using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ControleurServeur;
using ADODB;
using System.Data.SqlClient;
using System.Diagnostics;
namespace ControleurServeur
{
    internal class outils : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public outils() : base()
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
        internal Button cmdRechercher;
        internal TextBox txtRecherche;
        internal ComboBox cmbdepartement;
        internal Button CmdAdd;
        internal Button CmdSupp;
        internal Button CmdFerme;
        internal Button CmdModif;
        internal Button cmdreport;
        internal Button CmdEnr;
        internal Button CmdAnul;
        internal Button cmdDateAchat;
        internal Button cmdDateHorsfonction;
        internal TextBox txtno;
        internal ComboBox cmbetiquette;
        internal ComboBox cmbdepartement_modif;
        internal TextBox txtcommentaire;
        internal TextBox txtoutils;
        internal MaskedTextBox txtcout;
        internal MaskedTextBox txthorsfonction;
        internal MaskedTextBox txtachat;
        internal Label Label10;
        internal Label Label2;
        internal Label Label9;
        internal Label Label8;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal GroupBox fraModif;
        internal ColumnHeader _lstoutils_ColumnHeader_1;
        internal ColumnHeader _lstoutils_ColumnHeader_2;
        internal ColumnHeader _lstoutils_ColumnHeader_3;
        internal ColumnHeader _lstoutils_ColumnHeader_4;
        internal ColumnHeader _lstoutils_ColumnHeader_5;
        internal ColumnHeader _lstoutils_ColumnHeader_6;
        internal ColumnHeader _lstoutils_ColumnHeader_7;
        internal ListView lstoutils;
        internal Label lblRecherche;
        internal Label lbldepartement;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdRechercher = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.cmbdepartement = new System.Windows.Forms.ComboBox();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdSupp = new System.Windows.Forms.Button();
            this.CmdFerme = new System.Windows.Forms.Button();
            this.CmdModif = new System.Windows.Forms.Button();
            this.cmdreport = new System.Windows.Forms.Button();
            this.CmdEnr = new System.Windows.Forms.Button();
            this.CmdAnul = new System.Windows.Forms.Button();
            this.fraModif = new System.Windows.Forms.GroupBox();
            this.mvwDate = new System.Windows.Forms.DateTimePicker();
            this.cmdDateAchat = new System.Windows.Forms.Button();
            this.cmdDateHorsfonction = new System.Windows.Forms.Button();
            this.txtno = new System.Windows.Forms.TextBox();
            this.cmbetiquette = new System.Windows.Forms.ComboBox();
            this.cmbdepartement_modif = new System.Windows.Forms.ComboBox();
            this.txtcommentaire = new System.Windows.Forms.TextBox();
            this.txtoutils = new System.Windows.Forms.TextBox();
            this.txtcout = new System.Windows.Forms.MaskedTextBox();
            this.txthorsfonction = new System.Windows.Forms.MaskedTextBox();
            this.txtachat = new System.Windows.Forms.MaskedTextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lstoutils = new System.Windows.Forms.ListView();
            this._lstoutils_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lstoutils_ColumnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecherche = new System.Windows.Forms.Label();
            this.lbldepartement = new System.Windows.Forms.Label();
            this.fraModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.BackColor = System.Drawing.Color.Black;
            this.cmdRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRechercher.ForeColor = System.Drawing.Color.Blue;
            this.cmdRechercher.Location = new System.Drawing.Point(420, 24);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercher.Size = new System.Drawing.Size(73, 24);
            this.cmdRechercher.TabIndex = 2;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = true;
            this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.AcceptsReturn = true;
            this.txtRecherche.BackColor = System.Drawing.Color.Black;
            this.txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.White;
            this.txtRecherche.Location = new System.Drawing.Point(293, 26);
            this.txtRecherche.MaxLength = 0;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecherche.Size = new System.Drawing.Size(121, 22);
            this.txtRecherche.TabIndex = 4;
            // 
            // cmbdepartement
            // 
            this.cmbdepartement.BackColor = System.Drawing.Color.White;
            this.cmbdepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdepartement.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdepartement.ForeColor = System.Drawing.Color.Navy;
            this.cmbdepartement.Location = new System.Drawing.Point(109, 90);
            this.cmbdepartement.Name = "cmbdepartement";
            this.cmbdepartement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbdepartement.Size = new System.Drawing.Size(145, 22);
            this.cmbdepartement.Sorted = true;
            this.cmbdepartement.TabIndex = 3;
            this.cmbdepartement.SelectedIndexChanged += new System.EventHandler(this.cmbdepartement_SelectedIndexChanged);
            // 
            // CmdAdd
            // 
            this.CmdAdd.BackColor = System.Drawing.Color.Black;
            this.CmdAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdd.ForeColor = System.Drawing.Color.Blue;
            this.CmdAdd.Location = new System.Drawing.Point(109, 404);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAdd.Size = new System.Drawing.Size(97, 33);
            this.CmdAdd.TabIndex = 28;
            this.CmdAdd.Text = "&Ajouter";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdSupp
            // 
            this.CmdSupp.BackColor = System.Drawing.Color.Black;
            this.CmdSupp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSupp.ForeColor = System.Drawing.Color.Blue;
            this.CmdSupp.Location = new System.Drawing.Point(213, 404);
            this.CmdSupp.Name = "CmdSupp";
            this.CmdSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdSupp.Size = new System.Drawing.Size(97, 33);
            this.CmdSupp.TabIndex = 31;
            this.CmdSupp.Text = "&Supprimer";
            this.CmdSupp.UseVisualStyleBackColor = true;
            this.CmdSupp.Click += new System.EventHandler(this.CmdSupp_Click);
            // 
            // CmdFerme
            // 
            this.CmdFerme.BackColor = System.Drawing.Color.Black;
            this.CmdFerme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFerme.ForeColor = System.Drawing.Color.Blue;
            this.CmdFerme.Location = new System.Drawing.Point(421, 404);
            this.CmdFerme.Name = "CmdFerme";
            this.CmdFerme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdFerme.Size = new System.Drawing.Size(97, 33);
            this.CmdFerme.TabIndex = 33;
            this.CmdFerme.Text = "&Fermer";
            this.CmdFerme.UseVisualStyleBackColor = true;
            this.CmdFerme.Click += new System.EventHandler(this.CmdFerme_Click);
            // 
            // CmdModif
            // 
            this.CmdModif.BackColor = System.Drawing.Color.Black;
            this.CmdModif.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdModif.ForeColor = System.Drawing.Color.Blue;
            this.CmdModif.Location = new System.Drawing.Point(317, 404);
            this.CmdModif.Name = "CmdModif";
            this.CmdModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdModif.Size = new System.Drawing.Size(97, 33);
            this.CmdModif.TabIndex = 32;
            this.CmdModif.Text = "&Modifier";
            this.CmdModif.UseVisualStyleBackColor = true;
            this.CmdModif.Click += new System.EventHandler(this.CmdModif_Click);
            // 
            // cmdreport
            // 
            this.cmdreport.BackColor = System.Drawing.Color.Black;
            this.cmdreport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdreport.ForeColor = System.Drawing.Color.Blue;
            this.cmdreport.Location = new System.Drawing.Point(6, 404);
            this.cmdreport.Name = "cmdreport";
            this.cmdreport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdreport.Size = new System.Drawing.Size(97, 33);
            this.cmdreport.TabIndex = 27;
            this.cmdreport.Text = "&Impression";
            this.cmdreport.UseVisualStyleBackColor = true;
            this.cmdreport.Click += new System.EventHandler(this.cmdreport_Click);
            // 
            // CmdEnr
            // 
            this.CmdEnr.BackColor = System.Drawing.Color.Black;
            this.CmdEnr.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdEnr.ForeColor = System.Drawing.Color.White;
            this.CmdEnr.Location = new System.Drawing.Point(109, 404);
            this.CmdEnr.Name = "CmdEnr";
            this.CmdEnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdEnr.Size = new System.Drawing.Size(97, 33);
            this.CmdEnr.TabIndex = 29;
            this.CmdEnr.Text = "&Enregistrer";
            this.CmdEnr.UseVisualStyleBackColor = true;
            this.CmdEnr.Click += new System.EventHandler(this.CmdEnr_Click);
            // 
            // CmdAnul
            // 
            this.CmdAnul.BackColor = System.Drawing.Color.Black;
            this.CmdAnul.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAnul.ForeColor = System.Drawing.Color.White;
            this.CmdAnul.Location = new System.Drawing.Point(213, 404);
            this.CmdAnul.Name = "CmdAnul";
            this.CmdAnul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmdAnul.Size = new System.Drawing.Size(97, 33);
            this.CmdAnul.TabIndex = 30;
            this.CmdAnul.Text = "A&nnuler";
            this.CmdAnul.UseVisualStyleBackColor = true;
            this.CmdAnul.Click += new System.EventHandler(this.CmdAnul_Click);
            // 
            // fraModif
            // 
            this.fraModif.BackColor = System.Drawing.Color.Black;
            this.fraModif.Controls.Add(this.mvwDate);
            this.fraModif.Controls.Add(this.cmdDateAchat);
            this.fraModif.Controls.Add(this.cmdDateHorsfonction);
            this.fraModif.Controls.Add(this.txtno);
            this.fraModif.Controls.Add(this.cmbetiquette);
            this.fraModif.Controls.Add(this.cmbdepartement_modif);
            this.fraModif.Controls.Add(this.txtcommentaire);
            this.fraModif.Controls.Add(this.txtoutils);
            this.fraModif.Controls.Add(this.txtcout);
            this.fraModif.Controls.Add(this.txthorsfonction);
            this.fraModif.Controls.Add(this.txtachat);
            this.fraModif.Controls.Add(this.Label10);
            this.fraModif.Controls.Add(this.Label2);
            this.fraModif.Controls.Add(this.Label9);
            this.fraModif.Controls.Add(this.Label8);
            this.fraModif.Controls.Add(this.Label7);
            this.fraModif.Controls.Add(this.Label6);
            this.fraModif.Controls.Add(this.Label5);
            this.fraModif.Controls.Add(this.Label4);
            this.fraModif.Controls.Add(this.Label3);
            this.fraModif.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraModif.ForeColor = System.Drawing.Color.White;
            this.fraModif.Location = new System.Drawing.Point(6, 123);
            this.fraModif.Name = "fraModif";
            this.fraModif.Padding = new System.Windows.Forms.Padding(0);
            this.fraModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraModif.Size = new System.Drawing.Size(513, 241);
            this.fraModif.TabIndex = 5;
            this.fraModif.TabStop = false;
            this.fraModif.Visible = false;
            // 
            // mvwDate
            // 
            this.mvwDate.CalendarForeColor = System.Drawing.Color.White;
            this.mvwDate.CalendarMonthBackground = System.Drawing.Color.Navy;
            this.mvwDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mvwDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mvwDate.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.mvwDate.Location = new System.Drawing.Point(217, 148);
            this.mvwDate.Name = "mvwDate";
            this.mvwDate.Size = new System.Drawing.Size(200, 22);
            this.mvwDate.TabIndex = 26;
            this.mvwDate.Visible = false;
            // 
            // cmdDateAchat
            // 
            this.cmdDateAchat.AutoSize = true;
            this.cmdDateAchat.BackColor = System.Drawing.Color.Black;
            this.cmdDateAchat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDateAchat.ForeColor = System.Drawing.Color.Blue;
            this.cmdDateAchat.Location = new System.Drawing.Point(176, 136);
            this.cmdDateAchat.Name = "cmdDateAchat";
            this.cmdDateAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDateAchat.Size = new System.Drawing.Size(25, 24);
            this.cmdDateAchat.TabIndex = 19;
            this.cmdDateAchat.Text = "..";
            this.cmdDateAchat.UseVisualStyleBackColor = true;
            this.cmdDateAchat.Click += new System.EventHandler(this.cmdDateAchat_Click);
            // 
            // cmdDateHorsfonction
            // 
            this.cmdDateHorsfonction.AutoSize = true;
            this.cmdDateHorsfonction.BackColor = System.Drawing.Color.Black;
            this.cmdDateHorsfonction.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDateHorsfonction.ForeColor = System.Drawing.Color.Blue;
            this.cmdDateHorsfonction.Location = new System.Drawing.Point(176, 160);
            this.cmdDateHorsfonction.Name = "cmdDateHorsfonction";
            this.cmdDateHorsfonction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDateHorsfonction.Size = new System.Drawing.Size(25, 24);
            this.cmdDateHorsfonction.TabIndex = 23;
            this.cmdDateHorsfonction.Text = "..";
            this.cmdDateHorsfonction.UseVisualStyleBackColor = true;
            this.cmdDateHorsfonction.Click += new System.EventHandler(this.cmdDateHorsfonction_Click);
            // 
            // txtno
            // 
            this.txtno.AcceptsReturn = true;
            this.txtno.BackColor = System.Drawing.Color.White;
            this.txtno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtno.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.ForeColor = System.Drawing.Color.Navy;
            this.txtno.Location = new System.Drawing.Point(96, 64);
            this.txtno.MaxLength = 0;
            this.txtno.Name = "txtno";
            this.txtno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtno.Size = new System.Drawing.Size(73, 22);
            this.txtno.TabIndex = 12;
            // 
            // cmbetiquette
            // 
            this.cmbetiquette.BackColor = System.Drawing.Color.White;
            this.cmbetiquette.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbetiquette.ForeColor = System.Drawing.Color.Navy;
            this.cmbetiquette.Location = new System.Drawing.Point(96, 40);
            this.cmbetiquette.Name = "cmbetiquette";
            this.cmbetiquette.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbetiquette.Size = new System.Drawing.Size(169, 22);
            this.cmbetiquette.TabIndex = 9;
            this.cmbetiquette.SelectedIndexChanged += new System.EventHandler(this.cmbetiquette_SelectedIndexChanged);
            // 
            // cmbdepartement_modif
            // 
            this.cmbdepartement_modif.BackColor = System.Drawing.Color.White;
            this.cmbdepartement_modif.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdepartement_modif.ForeColor = System.Drawing.Color.Navy;
            this.cmbdepartement_modif.Location = new System.Drawing.Point(96, 16);
            this.cmbdepartement_modif.Name = "cmbdepartement_modif";
            this.cmbdepartement_modif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbdepartement_modif.Size = new System.Drawing.Size(169, 22);
            this.cmbdepartement_modif.TabIndex = 7;
            // 
            // txtcommentaire
            // 
            this.txtcommentaire.AcceptsReturn = true;
            this.txtcommentaire.BackColor = System.Drawing.Color.White;
            this.txtcommentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcommentaire.ForeColor = System.Drawing.Color.Navy;
            this.txtcommentaire.Location = new System.Drawing.Point(96, 184);
            this.txtcommentaire.MaxLength = 0;
            this.txtcommentaire.Multiline = true;
            this.txtcommentaire.Name = "txtcommentaire";
            this.txtcommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcommentaire.Size = new System.Drawing.Size(393, 43);
            this.txtcommentaire.TabIndex = 25;
            // 
            // txtoutils
            // 
            this.txtoutils.AcceptsReturn = true;
            this.txtoutils.BackColor = System.Drawing.Color.White;
            this.txtoutils.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtoutils.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoutils.ForeColor = System.Drawing.Color.Navy;
            this.txtoutils.Location = new System.Drawing.Point(96, 88);
            this.txtoutils.MaxLength = 0;
            this.txtoutils.Name = "txtoutils";
            this.txtoutils.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtoutils.Size = new System.Drawing.Size(321, 22);
            this.txtoutils.TabIndex = 14;
            // 
            // txtcout
            // 
            this.txtcout.AllowPromptAsInput = false;
            this.txtcout.BackColor = System.Drawing.Color.White;
            this.txtcout.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcout.ForeColor = System.Drawing.Color.Navy;
            this.txtcout.Location = new System.Drawing.Point(96, 112);
            this.txtcout.Name = "txtcout";
            this.txtcout.Size = new System.Drawing.Size(65, 22);
            this.txtcout.TabIndex = 16;
            // 
            // txthorsfonction
            // 
            this.txthorsfonction.AllowPromptAsInput = false;
            this.txthorsfonction.BackColor = System.Drawing.Color.White;
            this.txthorsfonction.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorsfonction.ForeColor = System.Drawing.Color.Navy;
            this.txthorsfonction.Location = new System.Drawing.Point(96, 160);
            this.txthorsfonction.Name = "txthorsfonction";
            this.txthorsfonction.Size = new System.Drawing.Size(73, 22);
            this.txthorsfonction.TabIndex = 22;
            // 
            // txtachat
            // 
            this.txtachat.AllowPromptAsInput = false;
            this.txtachat.BackColor = System.Drawing.Color.White;
            this.txtachat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtachat.ForeColor = System.Drawing.Color.Navy;
            this.txtachat.Location = new System.Drawing.Point(96, 136);
            this.txtachat.Name = "txtachat";
            this.txtachat.Size = new System.Drawing.Size(73, 22);
            this.txtachat.TabIndex = 18;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Black;
            this.Label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(219, 128);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(81, 17);
            this.Label10.TabIndex = 20;
            this.Label10.Text = "AA-MM-JJ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(8, 64);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(52, 14);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "No. Outil";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Black;
            this.Label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(8, 184);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(83, 14);
            this.Label9.TabIndex = 24;
            this.Label9.Text = "Commentaire";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Black;
            this.Label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(8, 160);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(69, 14);
            this.Label8.TabIndex = 21;
            this.Label8.Text = "Disposition";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(8, 136);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(71, 14);
            this.Label7.TabIndex = 17;
            this.Label7.Text = "Date ACHAT";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Black;
            this.Label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(8, 40);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(56, 14);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Étiquette";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(8, 112);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(33, 14);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "Coût";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Black;
            this.Label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(8, 16);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(79, 14);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Département";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(8, 88);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(32, 14);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Outil";
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
            this.lstoutils.Location = new System.Drawing.Point(5, 136);
            this.lstoutils.Name = "lstoutils";
            this.lstoutils.Size = new System.Drawing.Size(513, 225);
            this.lstoutils.TabIndex = 26;
            this.lstoutils.UseCompatibleStateImageBehavior = false;
            this.lstoutils.View = System.Windows.Forms.View.Details;
            this.lstoutils.DoubleClick += new System.EventHandler(this.lstoutils_DoubleClick);
            this.lstoutils.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstoutils_KeyDown);
            // 
            // _lstoutils_ColumnHeader_1
            // 
            this._lstoutils_ColumnHeader_1.Text = "No";
            this._lstoutils_ColumnHeader_1.Width = 59;
            // 
            // _lstoutils_ColumnHeader_2
            // 
            this._lstoutils_ColumnHeader_2.Text = "Nom";
            this._lstoutils_ColumnHeader_2.Width = 353;
            // 
            // _lstoutils_ColumnHeader_3
            // 
            this._lstoutils_ColumnHeader_3.Text = this.Name;
            this._lstoutils_ColumnHeader_3.Width = 118;
            // 
            // _lstoutils_ColumnHeader_4
            // 
            this._lstoutils_ColumnHeader_4.Text = "Disposition";
            this._lstoutils_ColumnHeader_4.Width = 118;
            // 
            // _lstoutils_ColumnHeader_5
            // 
            this._lstoutils_ColumnHeader_5.Text = "Coût";
            this._lstoutils_ColumnHeader_5.Width = 118;
            // 
            // _lstoutils_ColumnHeader_6
            // 
            this._lstoutils_ColumnHeader_6.Text = "Étiquette";
            this._lstoutils_ColumnHeader_6.Width = 118;
            // 
            // _lstoutils_ColumnHeader_7
            // 
            this._lstoutils_ColumnHeader_7.Text = "Commentaire";
            this._lstoutils_ColumnHeader_7.Width = 236;
            // 
            // lblRecherche
            // 
            this.lblRecherche.BackColor = System.Drawing.Color.Black;
            this.lblRecherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.ForeColor = System.Drawing.Color.White;
            this.lblRecherche.Location = new System.Drawing.Point(293, 10);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecherche.Size = new System.Drawing.Size(73, 17);
            this.lblRecherche.TabIndex = 1;
            this.lblRecherche.Text = "Recherche :";
            // 
            // lbldepartement
            // 
            this.lbldepartement.AutoSize = true;
            this.lbldepartement.BackColor = System.Drawing.Color.Black;
            this.lbldepartement.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartement.ForeColor = System.Drawing.Color.White;
            this.lbldepartement.Location = new System.Drawing.Point(18, 93);
            this.lbldepartement.Name = "lbldepartement";
            this.lbldepartement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbldepartement.Size = new System.Drawing.Size(79, 14);
            this.lbldepartement.TabIndex = 0;
            this.lbldepartement.Text = "Département";
            // 
            // outils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(526, 455);
            this.Controls.Add(this.cmdRechercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.cmbdepartement);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.CmdSupp);
            this.Controls.Add(this.CmdFerme);
            this.Controls.Add(this.CmdModif);
            this.Controls.Add(this.cmdreport);
            this.Controls.Add(this.CmdEnr);
            this.Controls.Add(this.CmdAnul);
            this.Controls.Add(this.fraModif);
            this.Controls.Add(this.lstoutils);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.lbldepartement);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "outils";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machinerie & Outillage";
            this.Load += new System.EventHandler(this.outils_Load);
            this.fraModif.ResumeLayout(false);
            this.fraModif.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private DateTimePicker mvwDate;
        private bool m_bDateAchat;
        private bool m_bModeAjouter;
        private void cmbetiquette_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstOutils = new ADODB.Recordset();
                rstOutils.Open("SELECT * FROM Outils WHERE type_étiquette = '" + cmbetiquette.Text + "' ORDER BY no_outils DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstOutils.EOF)
                {
                    if (IsNumeric(rstOutils.Fields["no_outils"].Value)) { txtno.Text = (string)rstOutils.Fields["no_outils"].Value; } else { txtno.Text = ""; }
                }
                rstOutils.Close();
                rstOutils = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "cmbetiquette_Click", ex); }
        }
        private void CmdAnul_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                AfficherListe();
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "CmdAnul_Click", ex); }
        }
        private void cmdDateAchat_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bDateAchat = true;
                (mvwDate).Visible = true;
                if (Information.IsDate(txtachat.Text) == true)
                {
                    mvwDate.Value = ConvertDateTexte(txtachat.Text);
                }
                else
                {
                    mvwDate.Value = DateTime.Today;
                }
                mvwDate.Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "cmdDateAchat_Click", ex); }
        }
        private void cmdDateHorsfonction_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bDateAchat = false;
                ((dynamic)mvwDate).Visible = true;
                if (Information.IsDate(txthorsfonction.Text) == true)
                {
                    mvwDate.Value = ConvertDateTexte(txthorsfonction.Text);
                }
                else
                {
                    mvwDate.Value = DateTime.Today;
                } ((dynamic)mvwDate).Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "cmdDateHorsfonction_Click", ex); }
        }
        private void CmdFerme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "CmdFerme_Click", ex); }
        }
        private void cmdRechercher_Click(object eventSender, EventArgs eventArgs)
        {
            Cursor.Current = Cursors.WaitCursor;
            lstoutils.Items.Clear();
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            SqlDataReader rd = new SqlCommand($"SELECT * FROM OUTILS WHERE NO_OUTILS LIKE '%{txtRecherche.Text}%' OR NOM_OUTILS LIKE '%{txtRecherche.Text}%' OR DATE_ACHAT LIKE '%{txtRecherche.Text}%' ORDER BY NO_OUTILS", sql).ExecuteReader();
            try
            {
                while (rd.Read())
                {
                    ListViewItem itmOutils = lstoutils.Items.Add(string.Empty);
                    itmOutils.Text = rd["no_outils"].ToString();
                    itmOutils.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, rd["nom_outils"].ToString()));
                    itmOutils.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, rd["date_achat"].ToString()));
                    itmOutils.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, rd["date_hors_fonction"].ToString()));
                    itmOutils.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, rd["cout"].ToString()));
                    itmOutils.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, rd["type_étiquette"].ToString()));
                    itmOutils.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, rd["commentaire"].ToString()));
                }
                rd.Close();
                sql.Close();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { AfficherErreur("outils", "cmdRechercher_Click", ex); }
        }
        [Obsolete]
        private void cmdreport_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstOutils;
                Cursor.Current = Cursors.WaitCursor;
                rstOutils = new Recordset();
                rstOutils.Open("SELECT * FROM OUTILS WHERE DEPARTEMENT = '" + cmbdepartement.Text + "' ORDER BY NO_OUTILS", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                Clipboard.SetText("SELECT * FROM OUTILS WHERE DEPARTEMENT = '" + cmbdepartement.Text + "' ORDER BY NO_OUTILS");
                if (!rstOutils.EOF)
                {
                    ViewOutilsMachinerie f = new ViewOutilsMachinerie();
                    f.DataSource = rstOutils;
                    f.lbldepartement.Text = $"Configuration des outils pour le département: {$"{rstOutils.Fields["departement"].Value}".ToLower()}";
                    f.lblDate1.Text =DateTime.Today.ToLongDateString();
                    f.Orientation = false;
                    f.DataSource = rstOutils;                   
                    f.MdiParent = Conteneur.ActiveForm.MdiParent;
                    f.Show();
                }
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "cmdreport_Click", ex); }
        }
        private void outils_Load(object eventSender, EventArgs eventArgs)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            lstoutils.Visible = true;
            try
            {
                RemplirDepartement();
                AfficherListe();
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "Form_Load", ex); }
        }
        public void RemplirDepartement()
        {
            try
            {
                ADODB.Recordset rstDepartement;
                rstDepartement = new Recordset();
                rstDepartement.Open("SELECT DISTINCT departement FROM outils ORDER BY departement", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbdepartement.Items.Clear();
                while (!rstDepartement.EOF)
                {
                    cmbdepartement.Items.Add(rstDepartement.Fields["departement"].Value); rstDepartement.MoveNext();
                }
                rstDepartement.Close();
                rstDepartement = null;
                if (cmbdepartement.Items.Count > 0)
                {
                    cmbdepartement.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "RemplirDepartement", ex); }
        }
        public void RemplirEtiquette()
        {
            try
            {
                ADODB.Recordset rstEtiquette;
                rstEtiquette = new Recordset();
                rstEtiquette.Open("SELECT DISTINCT type_étiquette FROM outils ORDER BY type_étiquette", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbetiquette.Items.Clear();
                while (!rstEtiquette.EOF)
                {
                    cmbetiquette.Items.Add(rstEtiquette.Fields["type_étiquette"].Value); rstEtiquette.MoveNext();
                }
                rstEtiquette.Close();
                rstEtiquette = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "RemplirEtiquette", ex); }
        }
        public void RemplirDepartementModif()
        {
            try
            {
                ADODB.Recordset rstDepartement;
                rstDepartement = new Recordset();
                rstDepartement.Open("SELECT DISTINCT departement FROM outils ORDER BY departement", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbdepartement_modif.Items.Clear();
                while (!rstDepartement.EOF)
                {
                    cmbdepartement_modif.Items.Add(rstDepartement.Fields["departement"].Value); rstDepartement.MoveNext();
                }
                rstDepartement.Close();
                rstDepartement = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "RemplirDepartementModif", ex); }
        }
        public void RemplirListViewOutils()
        {
            try
            {
                lstoutils.Items.Clear();
                lstoutils.Sorting = System.Windows.Forms.SortOrder.None;
                SqlConnection sql = new SqlConnection(StringSQL);
                sql.Open();
                SqlDataReader rd = new SqlCommand($"SELECT * FROM OUTILS WHERE DEPARTEMENT = '{cmbdepartement.Text.Replace("'", "''")}' ORDER BY NO_OUTILS", sql).ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem itmOutils = lstoutils.Items.Add(string.Empty);
                    itmOutils.Text = rd["no_outils"].ToString();
                    itmOutils.SubItems.Add(rd["nom_outils"].ToString());
                    itmOutils.SubItems.Add(rd["date_achat"].ToString());
                    itmOutils.SubItems.Add(rd["date_hors_fonction"].ToString());
                    itmOutils.SubItems.Add(rd["cout"].ToString());
                    itmOutils.SubItems.Add(rd["commentaire"].ToString());
                }
                rd.Close();
                sql.Close();
            }
            catch (Exception ex) { AfficherErreur("outils", "RemplirListViewOutils", ex); }
        }
        private void cmbdepartement_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                RemplirListViewOutils();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "cmbdepartement_Click", ex); }
        }
        private void CmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                m_bModeAjouter = true;
                AfficherModif();
                RemplirEtiquette();
                RemplirDepartementModif();
                txtachat.Text = string.Empty;
                txtcommentaire.Text = string.Empty;
                txtcout.Text = string.Empty;
                txthorsfonction.Text = string.Empty;
                txtno.Text = string.Empty;
                txtoutils.Text = string.Empty;
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "CmdAdd_Click", ex); }
        }
        private void AfficherModif()
        {
            try
            {
                fraModif.Visible = true;
                lstoutils.Visible = false;
                cmbdepartement.Visible = false;
                lbldepartement.Visible = false;
                CmdAdd.Visible = false;
                CmdSupp.Visible = false;
                CmdModif.Visible = false;
                CmdEnr.Visible = true;
                CmdAnul.Visible = true;
                lblRecherche.Visible = false;
                txtRecherche.Visible = false;
                cmdRechercher.Visible = false;
                cmdreport.Visible = false;
                CmdFerme.Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "AfficherModif", ex); }
        }
        private void AfficherListe()
        {
            try
            {
                fraModif.Visible = false;
                lstoutils.Visible = true;
                cmbdepartement.Visible = true;
                lbldepartement.Visible = true;
                CmdAdd.Visible = true;
                CmdSupp.Visible = true;
                CmdModif.Visible = true;
                CmdEnr.Visible = false;
                CmdAnul.Visible = false;
                lblRecherche.Visible = true;
                txtRecherche.Visible = true;
                cmdRechercher.Visible = true;
                cmdreport.Visible = true;
                CmdFerme.Visible = true;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "AfficherListe", ex); }
        }
        private void CmdModif_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstOutils;
                Cursor.Current = Cursors.WaitCursor;
                m_bModeAjouter = false;
                AfficherModif();
                RemplirEtiquette();
                RemplirDepartementModif();
                if (lstoutils.Items.Count > 0)
                {
                    rstOutils = new Recordset(); rstOutils.Open("SELECT * FROM outils WHERE no_outils = '" + lstoutils.FocusedItem.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); cmbdepartement_modif.Text = (string)(rstOutils.Fields["departement"].Value); cmbetiquette.Text = (string)(rstOutils.Fields["type_étiquette"].Value); txtno.Text = (string)(rstOutils.Fields["no_outils"].Value);
                    if (rstOutils.Fields["nom_outils"].Value ?? "") { txtoutils.Text = string.Empty; } else { txtoutils.Text = (string)(rstOutils.Fields["nom_outils"].Value); }
                    if (rstOutils.Fields["cout"].Value ?? "") { txtcout.Text = string.Empty; } else { txtcout.Text = (string)(rstOutils.Fields["cout"].Value); }
                    if (!(rstOutils.Fields["date_achat"].Value ?? "")) { txtachat.Text = (string)(rstOutils.Fields["date_achat"].Value); } else { txtachat.Text = string.Empty; }
                    if (!(rstOutils.Fields["date_hors_fonction"].Value ?? "")) { txthorsfonction.Text = (string)(rstOutils.Fields["date_hors_fonction"].Value); } else { txthorsfonction.Text = string.Empty; }
                    if (rstOutils.Fields["commentaire"].Value ?? "") { txtcommentaire.Text = string.Empty; } else { txtcommentaire.Text = (string)(rstOutils.Fields["commentaire"].Value); }
                    rstOutils.Close(); rstOutils = null;
                }
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "CmdModif_Click", ex); }
        }
        private void CmdSupp_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lstoutils.Items.Count > 0)
                {
                    if (MessageBox.Show("Voulez-vous supprimer cette enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) { Cursor.Current = Cursors.WaitCursor; UpdateSQL("DELETE FROM outils WHERE no_outils = '" + lstoutils.FocusedItem.Text + "'"); RemplirListViewOutils(); RemplirDepartement(); Cursor.Current = Cursors.Default; }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "CmdSupp_Click", ex); }
        }
        private void CmdEnr_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstOutils;
                ADODB.Recordset rstVerifModif;
                Cursor.Current = Cursors.WaitCursor;
                if (string.IsNullOrEmpty(cmbdepartement.Text) | string.IsNullOrEmpty(cmbetiquette.Text) | string.IsNullOrEmpty(txtno.Text))
                {
                    MessageBox.Show("Champs vide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); Cursor.Current = Cursors.Default; return;
                }
                if ((txtachat.Text.Length == 0 | txtachat.Text.Length > 1 & Information.IsDate(txtachat.Text)) & (txthorsfonction.Text.Length == 0 | txthorsfonction.Text.Length > 1) & Information.IsDate(txthorsfonction.Text))
                {
                    rstOutils = new Recordset();
                    if (m_bModeAjouter == true)
                    {
                        rstOutils.Open("SELECT * FROM outils WHERE no_outils = '" + txtno.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstOutils.EOF) { MessageBox.Show("Le numéro d'outils existe déjà!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); rstOutils.Close(); rstOutils = null; Cursor.Current = Cursors.Default; return; }
                        rstOutils.AddNew();
                    }
                    else { rstOutils.Open("SELECT * FROM outils WHERE no_outils = '" + txtno.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                    rstOutils.Fields["departement"].Value = cmbdepartement_modif.Text; rstOutils.Fields["type_étiquette"].Value = cmbetiquette.Text; rstOutils.Fields["no_outils"].Value = txtno.Text; rstOutils.Fields["nom_outils"].Value = txtoutils.Text; rstOutils.Fields["cout"].Value = txtcout.Text; rstOutils.Fields["date_achat"].Value = txtachat.Text; rstOutils.Fields["date_hors_fonction"].Value = txthorsfonction.Text; rstOutils.Fields["commentaire"].Value = txtcommentaire.Text; rstOutils.Update(); AfficherListe();
                    rstOutils.Close(); rstOutils = null; RemplirListViewOutils(); RemplirDepartement();
                }
                else
                {
                    MessageBox.Show("La date est invalide! (aaaa-mm-jj)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "CmdEnr_Click", ex); }
        }
        private void lstoutils_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CmdModif_Click(CmdModif, new EventArgs());
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "lstoutils_DblClick", ex); }
        }
        private void lstoutils_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (lstoutils.Items.Count > 0)
                {
                    if (eventArgs.KeyCode == Keys.Delete)
                    {
                        if (MessageBox.Show("Voulez-vous supprimer cette enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) { UpdateSQL("DELETE FROM outils WHERE no_outils = '" + lstoutils.FocusedItem.Text + "'"); RemplirListViewOutils(); }
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "lstoutils_KeyDown", ex); }
        }
        private void mvwDate_DateClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sDate;
                if (m_bDateAchat == true)
                {
                    txtachat.Text = ConvertDate(mvwDate.Value);
                }
                else
                {
                    txthorsfonction.Text = ConvertDate(mvwDate.Value);
                } ((dynamic)mvwDate).Visible = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("outils", "mvwDate_DateClick", ex); }
        }
    }
}