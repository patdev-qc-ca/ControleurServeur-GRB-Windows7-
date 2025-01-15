using ADODB;
using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using static ControleurServeur.Program;
using System.Web.UI.WebControls;
using System.Collections.Generic;
#pragma warning disable CS0168
namespace ControleurServeur
{
    public class Employe : Form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        internal ToolTip ToolTip1;
        internal ComboBox cmbFamille;
        internal System.Windows.Forms.TextBox txtFamille;
        internal System.Windows.Forms.Button cmdAnnulEmploye;
        internal System.Windows.Forms.Button cmdOK;
        internal ComboBox cmbAjoutEmploye;
        internal System.Windows.Forms.Label Label9;
        internal GroupBox fraEmploye;
        internal System.Windows.Forms.Button cmdSupprimePunch;
        internal System.Windows.Forms.Button cmdAjoutPunch;
        internal System.Windows.Forms.CheckBox chkActif;
        internal ComboBox cmbEmployePunch;
        internal MaskedTextBox mskPagette;
        internal System.Windows.Forms.Button cmdConfig;
        internal ComboBox cmbGroupe;
        internal System.Windows.Forms.TextBox txtpage;
        internal System.Windows.Forms.Button cmdmodifier;
        internal System.Windows.Forms.Button cmdannuler;
        internal System.Windows.Forms.TextBox txtinitiale;
        internal System.Windows.Forms.Button cmdFermer;
        internal System.Windows.Forms.TextBox txtconfirme;
        internal System.Windows.Forms.Button cmdsupprimer;
        internal System.Windows.Forms.Button cmdajouter;
        internal System.Windows.Forms.TextBox txtpasswd;
        internal System.Windows.Forms.TextBox txtuserid;
        internal System.Windows.Forms.Button cmdenregistré;
        internal System.Windows.Forms.TextBox txtemployé;
        internal System.Windows.Forms.TextBox txtGroupe;
        internal MaskedTextBox mskTelephone;
        internal MaskedTextBox mskCellulaire;
        internal System.Windows.Forms.TextBox txtCell;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label lblPunchPour;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblconfirme;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbl;
        internal System.Windows.Forms.Label Label1;
        #region Windows Form Designer generated code
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.txtFamille = new System.Windows.Forms.TextBox();
            this.fraEmploye = new System.Windows.Forms.GroupBox();
            this.cmdAnnulEmploye = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmbAjoutEmploye = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.cmdSupprimePunch = new System.Windows.Forms.Button();
            this.cmdAjoutPunch = new System.Windows.Forms.Button();
            this.chkActif = new System.Windows.Forms.CheckBox();
            this.cmbEmployePunch = new System.Windows.Forms.ComboBox();
            this.mskPagette = new System.Windows.Forms.MaskedTextBox();
            this.cmdConfig = new System.Windows.Forms.Button();
            this.cmbGroupe = new System.Windows.Forms.ComboBox();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.cmdmodifier = new System.Windows.Forms.Button();
            this.cmdannuler = new System.Windows.Forms.Button();
            this.txtinitiale = new System.Windows.Forms.TextBox();
            this.txtconfirme = new System.Windows.Forms.TextBox();
            this.cmdsupprimer = new System.Windows.Forms.Button();
            this.cmdajouter = new System.Windows.Forms.Button();
            this.txtpasswd = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.cmbEmploye = new System.Windows.Forms.ComboBox();
            this.cmdenregistré = new System.Windows.Forms.Button();
            this.txtemployé = new System.Windows.Forms.TextBox();
            this.txtGroupe = new System.Windows.Forms.TextBox();
            this.mskTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mskCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblPunchPour = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblconfirme = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNoEmployé = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.fraEmploye.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // cmbFamille
            // 
            this.cmbFamille.BackColor = System.Drawing.Color.Black;
            this.cmbFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamille.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFamille.ForeColor = System.Drawing.Color.White;
            this.cmbFamille.Location = new System.Drawing.Point(96, 147);
            this.cmbFamille.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbFamille.Size = new System.Drawing.Size(134, 22);
            this.cmbFamille.Sorted = true;
            this.cmbFamille.TabIndex = 8;
            this.cmbFamille.SelectedIndexChanged += new System.EventHandler(this.cmbFamille_SelectedIndexChanged);
            // 
            // txtFamille
            // 
            this.txtFamille.AcceptsReturn = true;
            this.txtFamille.BackColor = System.Drawing.Color.Black;
            this.txtFamille.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFamille.ForeColor = System.Drawing.Color.White;
            this.txtFamille.Location = new System.Drawing.Point(96, 147);
            this.txtFamille.Margin = new System.Windows.Forms.Padding(2);
            this.txtFamille.MaxLength = 0;
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFamille.Size = new System.Drawing.Size(128, 22);
            this.txtFamille.TabIndex = 7;
            // 
            // fraEmploye
            // 
            this.fraEmploye.BackColor = System.Drawing.Color.Black;
            this.fraEmploye.Controls.Add(this.cmdAnnulEmploye);
            this.fraEmploye.Controls.Add(this.cmdOK);
            this.fraEmploye.Controls.Add(this.cmbAjoutEmploye);
            this.fraEmploye.Controls.Add(this.Label9);
            this.fraEmploye.ForeColor = System.Drawing.Color.White;
            this.fraEmploye.Location = new System.Drawing.Point(52, 260);
            this.fraEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.fraEmploye.Name = "fraEmploye";
            this.fraEmploye.Padding = new System.Windows.Forms.Padding(0);
            this.fraEmploye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraEmploye.Size = new System.Drawing.Size(217, 97);
            this.fraEmploye.TabIndex = 32;
            this.fraEmploye.TabStop = false;
            this.fraEmploye.Text = "Ajout d\'employé";
            this.fraEmploye.Visible = false;
            // 
            // cmdAnnulEmploye
            // 
            this.cmdAnnulEmploye.AutoSize = true;
            this.cmdAnnulEmploye.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAnnulEmploye.BackColor = System.Drawing.Color.Black;
            this.cmdAnnulEmploye.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnulEmploye.ForeColor = System.Drawing.Color.White;
            this.cmdAnnulEmploye.Location = new System.Drawing.Point(143, 62);
            this.cmdAnnulEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAnnulEmploye.Name = "cmdAnnulEmploye";
            this.cmdAnnulEmploye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnulEmploye.Size = new System.Drawing.Size(59, 23);
            this.cmdAnnulEmploye.TabIndex = 16;
            this.cmdAnnulEmploye.Text = "Annuler";
            this.cmdAnnulEmploye.UseVisualStyleBackColor = true;
            this.cmdAnnulEmploye.Click += new System.EventHandler(this.cmdAnnulEmploye_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.AutoSize = true;
            this.cmdOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdOK.BackColor = System.Drawing.Color.Black;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.ForeColor = System.Drawing.Color.White;
            this.cmdOK.Location = new System.Drawing.Point(107, 62);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(36, 23);
            this.cmdOK.TabIndex = 17;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmbAjoutEmploye
            // 
            this.cmbAjoutEmploye.BackColor = System.Drawing.Color.Black;
            this.cmbAjoutEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAjoutEmploye.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAjoutEmploye.ForeColor = System.Drawing.Color.White;
            this.cmbAjoutEmploye.Location = new System.Drawing.Point(6, 24);
            this.cmbAjoutEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAjoutEmploye.Name = "cmbAjoutEmploye";
            this.cmbAjoutEmploye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAjoutEmploye.Size = new System.Drawing.Size(128, 22);
            this.cmbAjoutEmploye.Sorted = true;
            this.cmbAjoutEmploye.TabIndex = 15;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Black;
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(12, 111);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(49, 14);
            this.Label9.TabIndex = 33;
            this.Label9.Text = "Employé";
            // 
            // cmdSupprimePunch
            // 
            this.cmdSupprimePunch.AutoSize = true;
            this.cmdSupprimePunch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSupprimePunch.BackColor = System.Drawing.Color.Black;
            this.cmdSupprimePunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSupprimePunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSupprimePunch.ForeColor = System.Drawing.Color.White;
            this.cmdSupprimePunch.Location = new System.Drawing.Point(154, 256);
            this.cmdSupprimePunch.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSupprimePunch.Name = "cmdSupprimePunch";
            this.cmdSupprimePunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSupprimePunch.Size = new System.Drawing.Size(72, 23);
            this.cmdSupprimePunch.TabIndex = 14;
            this.cmdSupprimePunch.Text = "Supprimer";
            this.cmdSupprimePunch.UseVisualStyleBackColor = true;
            this.cmdSupprimePunch.Click += new System.EventHandler(this.cmdSupprimePunch_Click);
            // 
            // cmdAjoutPunch
            // 
            this.cmdAjoutPunch.AutoSize = true;
            this.cmdAjoutPunch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAjoutPunch.BackColor = System.Drawing.Color.Black;
            this.cmdAjoutPunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAjoutPunch.ForeColor = System.Drawing.Color.White;
            this.cmdAjoutPunch.Location = new System.Drawing.Point(96, 256);
            this.cmdAjoutPunch.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAjoutPunch.Name = "cmdAjoutPunch";
            this.cmdAjoutPunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAjoutPunch.Size = new System.Drawing.Size(57, 23);
            this.cmdAjoutPunch.TabIndex = 13;
            this.cmdAjoutPunch.Text = "Ajouter";
            this.cmdAjoutPunch.UseVisualStyleBackColor = true;
            this.cmdAjoutPunch.Click += new System.EventHandler(this.cmdAjoutPunch_Click);
            // 
            // chkActif
            // 
            this.chkActif.AutoSize = true;
            this.chkActif.BackColor = System.Drawing.Color.Black;
            this.chkActif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkActif.Enabled = false;
            this.chkActif.ForeColor = System.Drawing.Color.White;
            this.chkActif.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkActif.Location = new System.Drawing.Point(234, 97);
            this.chkActif.Margin = new System.Windows.Forms.Padding(2);
            this.chkActif.Name = "chkActif";
            this.chkActif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkActif.Size = new System.Drawing.Size(49, 18);
            this.chkActif.TabIndex = 3;
            this.chkActif.Text = "Actif";
            this.chkActif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkActif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkActif.UseVisualStyleBackColor = true;
            // 
            // cmbEmployePunch
            // 
            this.cmbEmployePunch.BackColor = System.Drawing.Color.Black;
            this.cmbEmployePunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployePunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmployePunch.ForeColor = System.Drawing.Color.White;
            this.cmbEmployePunch.Location = new System.Drawing.Point(102, 234);
            this.cmbEmployePunch.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmployePunch.Name = "cmbEmployePunch";
            this.cmbEmployePunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbEmployePunch.Size = new System.Drawing.Size(122, 22);
            this.cmbEmployePunch.Sorted = true;
            this.cmbEmployePunch.TabIndex = 12;
            // 
            // mskPagette
            // 
            this.mskPagette.BackColor = System.Drawing.Color.Black;
            this.mskPagette.ForeColor = System.Drawing.Color.White;
            this.mskPagette.Location = new System.Drawing.Point(96, 283);
            this.mskPagette.Margin = new System.Windows.Forms.Padding(2);
            this.mskPagette.Name = "mskPagette";
            this.mskPagette.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskPagette.Size = new System.Drawing.Size(92, 22);
            this.mskPagette.TabIndex = 18;
            this.mskPagette.Visible = false;
            // 
            // cmdConfig
            // 
            this.cmdConfig.AutoSize = true;
            this.cmdConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdConfig.BackColor = System.Drawing.Color.Black;
            this.cmdConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdConfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdConfig.ForeColor = System.Drawing.Color.White;
            this.cmdConfig.Location = new System.Drawing.Point(234, 121);
            this.cmdConfig.Margin = new System.Windows.Forms.Padding(2);
            this.cmdConfig.Name = "cmdConfig";
            this.cmdConfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdConfig.Size = new System.Drawing.Size(87, 23);
            this.cmdConfig.TabIndex = 6;
            this.cmdConfig.Text = "Configuration";
            this.cmdConfig.UseVisualStyleBackColor = true;
            this.cmdConfig.Click += new System.EventHandler(this.cmdConfig_Click);
            // 
            // cmbGroupe
            // 
            this.cmbGroupe.BackColor = System.Drawing.Color.Black;
            this.cmbGroupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbGroupe.ForeColor = System.Drawing.Color.White;
            this.cmbGroupe.Location = new System.Drawing.Point(96, 121);
            this.cmbGroupe.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGroupe.Name = "cmbGroupe";
            this.cmbGroupe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbGroupe.Size = new System.Drawing.Size(134, 22);
            this.cmbGroupe.Sorted = true;
            this.cmbGroupe.TabIndex = 5;
            this.cmbGroupe.SelectedIndexChanged += new System.EventHandler(this.cmbGroupe_SelectedIndexChanged);
            // 
            // txtpage
            // 
            this.txtpage.AcceptsReturn = true;
            this.txtpage.BackColor = System.Drawing.Color.Black;
            this.txtpage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpage.ForeColor = System.Drawing.Color.White;
            this.txtpage.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtpage.Location = new System.Drawing.Point(96, 283);
            this.txtpage.Margin = new System.Windows.Forms.Padding(2);
            this.txtpage.MaxLength = 0;
            this.txtpage.Name = "txtpage";
            this.txtpage.ReadOnly = true;
            this.txtpage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpage.Size = new System.Drawing.Size(92, 22);
            this.txtpage.TabIndex = 37;
            // 
            // cmdmodifier
            // 
            this.cmdmodifier.AutoSize = true;
            this.cmdmodifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdmodifier.BackColor = System.Drawing.Color.Black;
            this.cmdmodifier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdmodifier.ForeColor = System.Drawing.Color.White;
            this.cmdmodifier.Location = new System.Drawing.Point(155, 368);
            this.cmdmodifier.Margin = new System.Windows.Forms.Padding(2);
            this.cmdmodifier.Name = "cmdmodifier";
            this.cmdmodifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdmodifier.Size = new System.Drawing.Size(63, 23);
            this.cmdmodifier.TabIndex = 24;
            this.cmdmodifier.Text = "Modifier";
            this.cmdmodifier.UseVisualStyleBackColor = true;
            this.cmdmodifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdannuler
            // 
            this.cmdannuler.AutoSize = true;
            this.cmdannuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdannuler.BackColor = System.Drawing.Color.Black;
            this.cmdannuler.ForeColor = System.Drawing.Color.White;
            this.cmdannuler.Location = new System.Drawing.Point(156, 368);
            this.cmdannuler.Margin = new System.Windows.Forms.Padding(2);
            this.cmdannuler.Name = "cmdannuler";
            this.cmdannuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdannuler.Size = new System.Drawing.Size(55, 24);
            this.cmdannuler.TabIndex = 23;
            this.cmdannuler.Text = "Annuler";
            this.cmdannuler.UseVisualStyleBackColor = true;
            this.cmdannuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // txtinitiale
            // 
            this.txtinitiale.AcceptsReturn = true;
            this.txtinitiale.BackColor = System.Drawing.Color.Black;
            this.txtinitiale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtinitiale.ForeColor = System.Drawing.Color.White;
            this.txtinitiale.Location = new System.Drawing.Point(96, 95);
            this.txtinitiale.Margin = new System.Windows.Forms.Padding(2);
            this.txtinitiale.MaxLength = 3;
            this.txtinitiale.Name = "txtinitiale";
            this.txtinitiale.ReadOnly = true;
            this.txtinitiale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtinitiale.Size = new System.Drawing.Size(38, 22);
            this.txtinitiale.TabIndex = 2;
            // 
            // txtconfirme
            // 
            this.txtconfirme.AcceptsReturn = true;
            this.txtconfirme.BackColor = System.Drawing.Color.Black;
            this.txtconfirme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfirme.ForeColor = System.Drawing.Color.White;
            this.txtconfirme.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtconfirme.Location = new System.Drawing.Point(96, 212);
            this.txtconfirme.Margin = new System.Windows.Forms.Padding(2);
            this.txtconfirme.MaxLength = 0;
            this.txtconfirme.Name = "txtconfirme";
            this.txtconfirme.PasswordChar = '*';
            this.txtconfirme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtconfirme.Size = new System.Drawing.Size(122, 22);
            this.txtconfirme.TabIndex = 11;
            this.txtconfirme.Visible = false;
            // 
            // cmdsupprimer
            // 
            this.cmdsupprimer.AutoSize = true;
            this.cmdsupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdsupprimer.BackColor = System.Drawing.Color.Black;
            this.cmdsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdsupprimer.ForeColor = System.Drawing.Color.White;
            this.cmdsupprimer.Location = new System.Drawing.Point(213, 368);
            this.cmdsupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.cmdsupprimer.Name = "cmdsupprimer";
            this.cmdsupprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdsupprimer.Size = new System.Drawing.Size(72, 23);
            this.cmdsupprimer.TabIndex = 25;
            this.cmdsupprimer.Text = "Supprimer";
            this.cmdsupprimer.UseVisualStyleBackColor = true;
            this.cmdsupprimer.Click += new System.EventHandler(this.cmdsupprimer_Click);
            // 
            // cmdajouter
            // 
            this.cmdajouter.AutoSize = true;
            this.cmdajouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdajouter.BackColor = System.Drawing.Color.Black;
            this.cmdajouter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdajouter.ForeColor = System.Drawing.Color.White;
            this.cmdajouter.Location = new System.Drawing.Point(85, 368);
            this.cmdajouter.Margin = new System.Windows.Forms.Padding(2);
            this.cmdajouter.Name = "cmdajouter";
            this.cmdajouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdajouter.Size = new System.Drawing.Size(57, 23);
            this.cmdajouter.TabIndex = 22;
            this.cmdajouter.Text = "Ajouter";
            this.cmdajouter.UseVisualStyleBackColor = true;
            this.cmdajouter.Click += new System.EventHandler(this.Cmdajouter_Click);
            // 
            // txtpasswd
            // 
            this.txtpasswd.AcceptsReturn = true;
            this.txtpasswd.BackColor = System.Drawing.Color.Black;
            this.txtpasswd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpasswd.ForeColor = System.Drawing.Color.White;
            this.txtpasswd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtpasswd.Location = new System.Drawing.Point(96, 192);
            this.txtpasswd.Margin = new System.Windows.Forms.Padding(2);
            this.txtpasswd.MaxLength = 0;
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.PasswordChar = '*';
            this.txtpasswd.ReadOnly = true;
            this.txtpasswd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpasswd.Size = new System.Drawing.Size(122, 22);
            this.txtpasswd.TabIndex = 10;
            // 
            // txtuserid
            // 
            this.txtuserid.AcceptsReturn = true;
            this.txtuserid.BackColor = System.Drawing.Color.Black;
            this.txtuserid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuserid.ForeColor = System.Drawing.Color.White;
            this.txtuserid.Location = new System.Drawing.Point(96, 171);
            this.txtuserid.Margin = new System.Windows.Forms.Padding(2);
            this.txtuserid.MaxLength = 0;
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.ReadOnly = true;
            this.txtuserid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtuserid.Size = new System.Drawing.Size(122, 22);
            this.txtuserid.TabIndex = 9;
            // 
            // cmbEmploye
            // 
            this.cmbEmploye.BackColor = System.Drawing.Color.Black;
            this.cmbEmploye.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmploye.ForeColor = System.Drawing.Color.White;
            this.cmbEmploye.Location = new System.Drawing.Point(96, 68);
            this.cmbEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmploye.Name = "cmbEmploye";
            this.cmbEmploye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbEmploye.Size = new System.Drawing.Size(217, 22);
            this.cmbEmploye.TabIndex = 1;
            this.cmbEmploye.Text = "cmbEmploye";
            this.cmbEmploye.SelectedIndexChanged += new System.EventHandler(this.cmbemploye_SelectedIndexChanged);
            // 
            // cmdenregistré
            // 
            this.cmdenregistré.AutoSize = true;
            this.cmdenregistré.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdenregistré.BackColor = System.Drawing.Color.Black;
            this.cmdenregistré.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdenregistré.ForeColor = System.Drawing.Color.White;
            this.cmdenregistré.Location = new System.Drawing.Point(85, 368);
            this.cmdenregistré.Margin = new System.Windows.Forms.Padding(2);
            this.cmdenregistré.Name = "cmdenregistré";
            this.cmdenregistré.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdenregistré.Size = new System.Drawing.Size(75, 23);
            this.cmdenregistré.TabIndex = 21;
            this.cmdenregistré.Text = "Enregistrer";
            this.cmdenregistré.UseVisualStyleBackColor = true;
            this.cmdenregistré.Visible = false;
            this.cmdenregistré.Click += new System.EventHandler(this.cmdenregistré_Click);
            // 
            // txtemployé
            // 
            this.txtemployé.AcceptsReturn = true;
            this.txtemployé.BackColor = System.Drawing.Color.Black;
            this.txtemployé.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemployé.ForeColor = System.Drawing.Color.White;
            this.txtemployé.Location = new System.Drawing.Point(96, 69);
            this.txtemployé.Margin = new System.Windows.Forms.Padding(2);
            this.txtemployé.MaxLength = 0;
            this.txtemployé.Name = "txtemployé";
            this.txtemployé.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtemployé.Size = new System.Drawing.Size(122, 22);
            this.txtemployé.TabIndex = 0;
            this.txtemployé.Visible = false;
            // 
            // txtGroupe
            // 
            this.txtGroupe.AcceptsReturn = true;
            this.txtGroupe.BackColor = System.Drawing.Color.Black;
            this.txtGroupe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupe.ForeColor = System.Drawing.Color.White;
            this.txtGroupe.Location = new System.Drawing.Point(96, 121);
            this.txtGroupe.Margin = new System.Windows.Forms.Padding(2);
            this.txtGroupe.MaxLength = 0;
            this.txtGroupe.Name = "txtGroupe";
            this.txtGroupe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupe.Size = new System.Drawing.Size(128, 22);
            this.txtGroupe.TabIndex = 4;
            // 
            // mskTelephone
            // 
            this.mskTelephone.BackColor = System.Drawing.Color.Black;
            this.mskTelephone.ForeColor = System.Drawing.Color.White;
            this.mskTelephone.Location = new System.Drawing.Point(96, 303);
            this.mskTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.mskTelephone.Name = "mskTelephone";
            this.mskTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTelephone.Size = new System.Drawing.Size(92, 22);
            this.mskTelephone.TabIndex = 19;
            this.mskTelephone.Visible = false;
            // 
            // mskCellulaire
            // 
            this.mskCellulaire.BackColor = System.Drawing.Color.Black;
            this.mskCellulaire.ForeColor = System.Drawing.Color.White;
            this.mskCellulaire.Location = new System.Drawing.Point(96, 322);
            this.mskCellulaire.Margin = new System.Windows.Forms.Padding(2);
            this.mskCellulaire.Name = "mskCellulaire";
            this.mskCellulaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskCellulaire.Size = new System.Drawing.Size(92, 22);
            this.mskCellulaire.TabIndex = 20;
            this.mskCellulaire.Visible = false;
            // 
            // txtCell
            // 
            this.txtCell.AcceptsReturn = true;
            this.txtCell.BackColor = System.Drawing.Color.Black;
            this.txtCell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCell.ForeColor = System.Drawing.Color.White;
            this.txtCell.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCell.Location = new System.Drawing.Point(96, 322);
            this.txtCell.Margin = new System.Windows.Forms.Padding(2);
            this.txtCell.MaxLength = 0;
            this.txtCell.Name = "txtCell";
            this.txtCell.ReadOnly = true;
            this.txtCell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCell.Size = new System.Drawing.Size(92, 22);
            this.txtCell.TabIndex = 41;
            // 
            // txtTel
            // 
            this.txtTel.AcceptsReturn = true;
            this.txtTel.BackColor = System.Drawing.Color.Black;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.ForeColor = System.Drawing.Color.White;
            this.txtTel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtTel.Location = new System.Drawing.Point(96, 303);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.MaxLength = 0;
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTel.Size = new System.Drawing.Size(92, 22);
            this.txtTel.TabIndex = 39;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Black;
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(27, 147);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(44, 14);
            this.Label10.TabIndex = 42;
            this.Label10.Text = "Famille";
            // 
            // lblPunchPour
            // 
            this.lblPunchPour.AutoSize = true;
            this.lblPunchPour.BackColor = System.Drawing.Color.Black;
            this.lblPunchPour.ForeColor = System.Drawing.Color.White;
            this.lblPunchPour.Location = new System.Drawing.Point(27, 234);
            this.lblPunchPour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPunchPour.Name = "lblPunchPour";
            this.lblPunchPour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPunchPour.Size = new System.Drawing.Size(77, 14);
            this.lblPunchPour.TabIndex = 35;
            this.lblPunchPour.Text = "Puncher pour :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Black;
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(27, 121);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(43, 14);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Groupe";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(27, 322);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(53, 14);
            this.Label7.TabIndex = 40;
            this.Label7.Text = "Cellulaire";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Black;
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(27, 303);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(57, 14);
            this.Label6.TabIndex = 38;
            this.Label6.Text = "Téléphone";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(27, 283);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(45, 14);
            this.Label5.TabIndex = 36;
            this.Label5.Text = "Pagette";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(27, 95);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(41, 14);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Initiale";
            // 
            // lblconfirme
            // 
            this.lblconfirme.AutoSize = true;
            this.lblconfirme.BackColor = System.Drawing.Color.Black;
            this.lblconfirme.ForeColor = System.Drawing.Color.White;
            this.lblconfirme.Location = new System.Drawing.Point(27, 212);
            this.lblconfirme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblconfirme.Name = "lblconfirme";
            this.lblconfirme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblconfirme.Size = new System.Drawing.Size(71, 14);
            this.lblconfirme.TabIndex = 34;
            this.lblconfirme.Text = "Confirmation";
            this.lblconfirme.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(27, 192);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(44, 14);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Passwd";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Black;
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(27, 173);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl.Size = new System.Drawing.Size(42, 14);
            this.lbl.TabIndex = 30;
            this.lbl.Text = "User id";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(27, 69);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(50, 14);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Employé";
            // 
            // txtNoEmployé
            // 
            this.txtNoEmployé.AcceptsReturn = true;
            this.txtNoEmployé.BackColor = System.Drawing.Color.Black;
            this.txtNoEmployé.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoEmployé.ForeColor = System.Drawing.Color.White;
            this.txtNoEmployé.Location = new System.Drawing.Point(189, 95);
            this.txtNoEmployé.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoEmployé.MaxLength = 3;
            this.txtNoEmployé.Name = "txtNoEmployé";
            this.txtNoEmployé.ReadOnly = true;
            this.txtNoEmployé.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoEmployé.Size = new System.Drawing.Size(38, 22);
            this.txtNoEmployé.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 44;
            this.label4.Text = "Numéro";
            // 
            // cmdFermer
            // 
            this.cmdFermer.AutoSize = true;
            this.cmdFermer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdFermer.BackColor = System.Drawing.Color.Black;
            this.cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdFermer.ForeColor = System.Drawing.Color.White;
            this.cmdFermer.Location = new System.Drawing.Point(281, 368);
            this.cmdFermer.Margin = new System.Windows.Forms.Padding(2);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFermer.Size = new System.Drawing.Size(57, 23);
            this.cmdFermer.TabIndex = 26;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.Cmdfermer_Click);
            // 
            // Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(357, 409);
            this.Controls.Add(this.txtNoEmployé);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFamille);
            this.Controls.Add(this.txtFamille);
            this.Controls.Add(this.fraEmploye);
            this.Controls.Add(this.cmdSupprimePunch);
            this.Controls.Add(this.cmdAjoutPunch);
            this.Controls.Add(this.chkActif);
            this.Controls.Add(this.cmbEmployePunch);
            this.Controls.Add(this.mskPagette);
            this.Controls.Add(this.cmdConfig);
            this.Controls.Add(this.cmbGroupe);
            this.Controls.Add(this.txtpage);
            this.Controls.Add(this.cmdmodifier);
            this.Controls.Add(this.cmdannuler);
            this.Controls.Add(this.txtinitiale);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.txtconfirme);
            this.Controls.Add(this.cmdsupprimer);
            this.Controls.Add(this.cmdajouter);
            this.Controls.Add(this.txtpasswd);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.cmbEmploye);
            this.Controls.Add(this.cmdenregistré);
            this.Controls.Add(this.txtemployé);
            this.Controls.Add(this.txtGroupe);
            this.Controls.Add(this.mskTelephone);
            this.Controls.Add(this.mskCellulaire);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.lblPunchPour);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblconfirme);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(3, 22);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employe";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.Employe";
            this.Load += new System.EventHandler(this.Employe_Load);
            this.fraEmploye.ResumeLayout(false);
            this.fraEmploye.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal System.Windows.Forms.TextBox txtNoEmployé;
        internal System.Windows.Forms.Label label4;
        internal ComboBox cmbEmploye;
        private bool m_bModeAjouter;
        private int m_iNoEmploye;
        private bool m_bModifEmploye;
        internal string IdLoginEmploye = string.Empty;
        internal static string nomUtilisateur = string.Empty;
        static int c_Famille = 0;
        static int c_groupe = 0;
        public Employe()
        {
            InitializeComponent();
        }
        // Event cmbemploye.SelectedIndexChanged may fire when form is initialized. 
        private void cmbemploye_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                AfficherEmploye();
                if (txtuserid.Text.ToUpper() == IdLoginEmploye.ToUpper())
                {
                    cmdmodifier.Enabled = true;
                }
                else
                {
                    ///activerBoutonsGroupe();
                }
                txtemployé.Text = cmbEmploye.Text;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RemplirComboGroupe()
        {
            try
            {
                ADODB.Recordset rstGroupe;
                int X;
                // Il faut vider le groupe avant de le remplir
                cmbGroupe.Items.Clear();
                rstGroupe = new Recordset();
                rstGroupe.Open("SELECT * FROM Groupes", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                while (!rstGroupe.EOF)
                {
                    // Ajout du nom du groupe dans le combo
                    cmbGroupe.Items.Add(new ListItem($"{rstGroupe.Fields[1].Value}", $"{rstGroupe.Fields[0].Value}"));
                    if (m_bModeAjouter == true)
                    {
                        if (cmbGroupe.Items[cmbGroupe.Items.Count] == S_GROUPE_DEFAUT)
                        {
                            cmbGroupe.SelectedIndex = cmbGroupe.Items.Count - 1;
                        }
                    }
                    rstGroupe.MoveNext();
                }
                rstGroupe.Close();
                rstGroupe = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "RemplirComboGroupe", ex);
            }
        }
        private void RemplirComboFamille()
        {
            try
            {
                ADODB.Recordset rstFamille;
                int X;
                cmbFamille.Items.Clear();
                rstFamille = new Recordset();
                rstFamille.Open("SELECT * FROM Famille ORDER BY Famille", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                while (!rstFamille.EOF)
                {
                    // Ajout du nom du Famille dans le combo
                    cmbFamille.Items.Add(new ListItem($"{rstFamille.Fields[1].Value}", $"{rstFamille.Fields[0].Value}"));
                    rstFamille.MoveNext();
                }
                rstFamille.Close();
                //Object rstFamille
                rstFamille = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "RemplirComboFamille", ex);
            }
        }
        private void Cmdajouter_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bModeAjouter = true;
                MontrerControles(EnumMode.MODE_AJOUT);
                RemplirComboGroupe();
                LockedChamps(EnumMode.MODE_AJOUT);
                ViderChamps();
                AfficherMasque();
                txtemployé.Focus();
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "cmdAjouter_Click", ex);
            }
        }
        private void AfficherMasque()
        {
            try
            {
                mskPagette.Text = txtpage.Text;
                mskTelephone.Text = txtTel.Text;
                mskCellulaire.Text = txtCell.Text;
                txtpage.Visible = false;
                mskPagette.Visible = true;
                txtTel.Visible = false;
                mskTelephone.Visible = true;
                txtCell.Visible = false;
                mskCellulaire.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "AfficherMasque", ex);
            }
        }
        private void CacherMasque()
        {
            try
            {
                txtpage.Text = mskPagette.Text;
                txtTel.Text = mskTelephone.Text;
                txtCell.Text = mskCellulaire.Text;
                txtpage.Visible = true;
                mskPagette.Visible = false;
                txtTel.Visible = true;
                mskTelephone.Visible = false;
                txtCell.Visible = true;
                mskCellulaire.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "CacherMasque", ex);
            }
        }
        private void ViderChamps()
        {
            try
            {

                txtemployé.Text = string.Empty;
                txtuserid.Text = string.Empty;
                txtpasswd.Text = string.Empty;
                txtconfirme.Text = string.Empty;
                txtinitiale.Text = string.Empty;
                txtCell.Text = string.Empty;
                txtpage.Text = string.Empty;
                txtTel.Text = string.Empty;
                cmbFamille.SelectedIndex = -1;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "ViderChamps", ex);
            }
        }
        private void LockedChamps(EnumMode eMode)
        {
            try
            {
                // On barre les champs par rapport à un mode
                var bIDPassTel = default(bool); // Contient le userID, le password ainsi que Cell, Tel et pagette
                var bNomGroupe = default(bool); // Contient le nom et le groupe
                var bFamille = default(bool);
                var bInitiales = default(bool); // Contient les initiales
                bool bPunch;
                bool bChkPunch;
                var bChkActif = default(bool);
                switch (eMode)
                {
                    case EnumMode.MODE_MODIF:
                        {
                            bInitiales = true;
                            bPunch = true; break;
                        }
                    case EnumMode.MODE_AJOUT: { bPunch = true; break; }
                    case EnumMode.MODE_INACTIF:
                        {
                            bIDPassTel = true;
                            bNomGroupe = true;
                            bFamille = true;
                            bInitiales = true;
                            bPunch = true;
                            bChkPunch = true;
                            bChkactif = true; break;
                        }
                    // Si le user a le droit de modifié ses infos seulement
                    case EnumMode.MODE_MODIF_NON_AUTORISE:
                        {
                            bNomGroupe = true;
                            bInitiales = true;
                            bPunch = true;
                            bChkPunch = false;
                            bChkActif = false; break;
                        }
                }
                txtCell.ReadOnly = bIDPassTel;
                txtinitiale.ReadOnly = bInitiales;
                txtpage.ReadOnly = bIDPassTel;
                txtpasswd.ReadOnly = bIDPassTel;
                txtTel.ReadOnly = bIDPassTel;
                txtuserid.ReadOnly = bIDPassTel;
                cmbGroupe.Enabled = bNomGroupe;
                cmbFamille.Enabled = bFamille;
                txtemployé.ReadOnly = bNomGroupe;
                txtGroupe.ReadOnly = bNomGroupe;
                chkActif.Enabled = !bChkActif;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "LockedChamps", ex);
            }
        }
        private void MontrerControles(EnumMode eMode)
        {
            try
            {
                // Met les controles visible/invisible
                var bCmbGroupe = default(bool);
                var bCmbFamille = default(bool);
                var bCmbEmploye = default(bool);
                var bTxtGroupe = default(bool);
                var bTxtFamille = default(bool);
                var bTxtEmploye = default(bool);
                var bAjouter = default(bool);
                var bModifier = default(bool);
                var bSupprimer = default(bool);
                var bEnregistrer = default(bool);
                var bAnnuler = default(bool);
                var bQuitter = default(bool);
                var bGroupe = default(bool);
                var bConfirmPwd = default(bool);
                var bPunchPour = default(bool);
                switch (eMode)
                {
                    case EnumMode.MODE_AJOUT:
                    case EnumMode.MODE_MODIF:
                        {
                            bTxtEmploye = true;
                            bCmbGroupe = true;
                            bCmbFamille = true;
                            bEnregistrer = true;
                            bAnnuler = true;
                            bConfirmPwd = true; break;
                        }
                    case EnumMode.MODE_MODIF_NON_AUTORISE:
                        {
                            bTxtGroupe = true;
                            bTxtFamille = true;
                            bTxtEmploye = true;
                            bEnregistrer = true;
                            bAnnuler = true;
                            bConfirmPwd = true;
                            bPunchPour = true; break;
                        }
                    case EnumMode.MODE_INACTIF:
                        {
                            bCmbEmploye = true;
                            bTxtGroupe = true;
                            bTxtFamille = true;
                            bAjouter = true;
                            bModifier = true;
                            bSupprimer = true;
                            bQuitter = true;
                            bGroupe = true;
                            bPunchPour = true; break;
                        }
                }
                txtemployé.Visible = bTxtEmploye;
                cmbEmploye.Visible = bCmbEmploye;
                txtGroupe.Visible = bTxtGroupe;
                cmbGroupe.Visible = bCmbGroupe;
                txtFamille.Visible = bTxtFamille;
                cmbFamille.Visible = bCmbFamille;
                cmdajouter.Visible = bAjouter;
                cmdmodifier.Visible = bModifier;
                cmdsupprimer.Visible = bSupprimer;
                cmdFermer.Visible = bQuitter;
                cmdenregistré.Visible = bEnregistrer;
                cmdannuler.Visible = bAnnuler;
                txtconfirme.Visible = bConfirmPwd;
                cmdConfig.Enabled = bGroupe;
                lblPunchPour.Visible = bPunchPour;
                cmbEmployePunch.Visible = bPunchPour;
                cmdAjoutPunch.Visible = bPunchPour;
                cmdSupprimePunch.Visible = bPunchPour;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "MontrerControles", ex);
            }
        }
        private void cmdAjoutPunch_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RemplirComboEmployeActif();
                fraEmploye.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "cmdAjoutPunch_Click", ex);
            }
        }
        private void cmdAnnulEmploye_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraEmploye.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "cmdAnnulEmploye_Click", ex);
            }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                MontrerControles(EnumMode.MODE_INACTIF);
                LockedChamps(EnumMode.MODE_INACTIF);
                CacherMasque();
                txtemployé.Text = cmbEmploye.Text;
                AfficherEmploye();
                ActiverBoutonsGroupe();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdConfig_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                AfficherEmploye();
                Form f = new Groupes();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                return;
                cmbemploye_SelectedIndexChanged(cmdConfig, eventArgs);
            }
            catch (Exception ex)
            {
                AfficherErreur("Employes", "cmdConfig_Click", ex);
            }
        }
        private void cmdenregistré_Click(object eventSender, EventArgs eventArgs)
        {
            var IdLoginEmploye = default(string);
            try
            {
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstUserId;
                string sEmploye;
                int X;
                sEmploye = txtemployé.Text;
                if (!string.IsNullOrEmpty(txtemployé.Text.Trim())
                    & !string.IsNullOrEmpty(txtuserid.Text.Trim())
                    & !string.IsNullOrEmpty(txtpasswd.Text.Trim())
                    & !string.IsNullOrEmpty(txtconfirme.Text.Trim())
                    & !string.IsNullOrEmpty(txtinitiale.Text.Trim())
                    & cmbFamille.SelectedIndex != -1)
                {
                    if ((txtpasswd.Text ?? "") == (txtconfirme.Text ?? ""))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        rstEmploye = new Recordset();
                        if (m_bModeAjouter == true)
                        {
                            if (ComboContient(cmbEmploye, txtemployé.Text) == false)
                            {
                                rstEmploye.Open("SELECT * FROM employés", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                while (!rstEmploye.EOF)
                                {
                                    if (rstEmploye.Fields["Initiale"].Value == txtinitiale.Text)
                                    {
                                        MessageBox.Show("Ces initiales existent déjà!");
                                        Cursor.Current = Cursors.Default;
                                        return;
                                    }
                                    if (rstEmploye.Fields["loginname"].Value == txtuserid.Text)
                                    {
                                        MessageBox.Show("User ID existant!");
                                        Cursor.Current = Cursors.Default;
                                        return;
                                    }
                                    rstEmploye.MoveNext();
                                }
                                rstEmploye.AddNew();
                            }
                            else
                            {
                                MessageBox.Show("Cet employé existe déjà!");
                                return;
                            }
                        }
                        else
                        {
                            rstEmploye.Open("SELECT * FROM employés WHERE noemploye = " + m_iNoEmploye, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (txtuserid.Text != rstEmploye.Fields["loginname"].Value)
                            {
                                if (txtuserid.Text != IdLoginEmploye)
                                {
                                    rstUserId = new Recordset();
                                    rstUserId.Open("SELECT * FROM employés", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                    while (!rstUserId.EOF)
                                    {
                                        if (rstUserId.Fields["loginname"].Value == txtuserid.Text)
                                        {
                                            MessageBox.Show("User ID existant!");
                                            rstUserId.Close();
                                            rstUserId = default;
                                            rstEmploye.Close();
                                            rstEmploye = default;
                                            return;
                                        }
                                        rstUserId.MoveNext();
                                    }
                                    rstUserId.Close();
                                    rstUserId = default;
                                }
                            }
                        }
                        rstEmploye.Fields["employe"].Value = txtemployé.Text;
                        if (IdLoginEmploye == rstEmploye.Fields["loginname"].Value)
                        {
                            IdLoginEmploye = txtuserid.Text;
                        }
                        rstEmploye.Fields["loginname"].Value = txtuserid.Text;
                        rstEmploye.Fields["passwd"].Value = txtpasswd.Text;
                        rstEmploye.Fields["initiale"].Value = txtinitiale.Text;
                        rstEmploye.Fields["Actif"].Value = chkActif.CheckState;
                        if (m_bModeAjouter == false)
                        {
                            if (chkActif.Checked == false)
                            {
                                UpdateSQL("DELETE FROM AutorisationPunch WHERE NoEmploye = " + m_iNoEmploye + " OR AutoriserPar = " + m_iNoEmploye);
                            }
                        }
                        if (string.IsNullOrEmpty(mskTelephone.Text))
                        {
                            rstEmploye.Fields["tel"].Value = " ";
                        }
                        else
                        {
                            rstEmploye.Fields["tel"].Value = mskTelephone.Text;
                        }
                        if (string.IsNullOrEmpty(mskCellulaire.Text))
                        {
                            rstEmploye.Fields["cell"].Value = " ";
                        }
                        else
                        {
                            rstEmploye.Fields["cell"].Value = mskCellulaire.Text;
                        }
                        if (string.IsNullOrEmpty(mskPagette.Text))
                        {
                            rstEmploye.Fields["page"].Value = " ";
                        }
                        else
                        {
                            rstEmploye.Fields["page"].Value = mskPagette.Text;
                        }
                        if (cmbGroupe.Visible == true)
                        {
                            rstEmploye.Fields["groupe"].Value = c_groupe;
                        }
                        if (cmbFamille.Visible == true)
                        {
                            rstEmploye.Fields["Famille"].Value = c_Famille;
                        }
                        rstEmploye.Update();
                        rstEmploye.Close();
                        rstEmploye = default;
                        Cursor.Current = Cursors.Default;
                        MontrerControles(EnumMode.MODE_INACTIF);
                        LockedChamps(EnumMode.MODE_INACTIF);
                        ActiverBoutonsGroupe();
                        RemplirComboEmploye();
                        RemplirComboEmployeActif();
                        for (X = 0; X <= cmbEmploye.Items.Count; X++)
                        {
                            if ((cmbEmploye.Items[X].ToString() ?? "") == (sEmploye ?? ""))
                            {
                                cmbEmploye.SelectedIndex = (int)X;
                                break;
                            }
                        }
                        m_bModeAjouter = false;
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe est incorrect!");
                    }
                    CacherMasque();
                }
                else
                {
                    MessageBox.Show("Champs vide!");
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "cmdenregistré_Click", ex);
            }
        }
        private void cmdModifier_Click(object eventSender, EventArgs eventArgs)
        {
            MessageBox.Show(c_Famille.ToString());
            if (txtNoEmployé.Text == IdNoEmploye.ToString()) { //changer son mot de passe 
                txtpasswd.Enabled = true;
                txtpasswd.ReadOnly = false;
                if (Conteneur.idGroupeEmploye.Text == "IT")
                {
                    cmbFamille.Enabled = true;
                    cmbGroupe.Enabled = true;
                    m_bModifEmploye = true;
                }
            }
            try
            {
                AfficherMasque();
                if (m_bModifEmploye == true)
                {
                    MontrerControles(EnumMode.MODE_MODIF);
                    RemplirComboGroupe();
                    if (!string.IsNullOrEmpty(txtGroupe.Text))
                    {
                        cmbGroupe.Text = txtGroupe.Text;
                    }
                    else
                    {
                        cmbGroupe.SelectedIndex = -1;
                    }
                    if (!string.IsNullOrEmpty(txtFamille.Text))
                    {
                        cmbFamille.Text = txtFamille.Text;
                    }
                    else
                    {
                        cmbFamille.SelectedIndex = -1;
                    }
                    LockedChamps(EnumMode.MODE_MODIF);
                }
                else
                {
                    MontrerControles(EnumMode.MODE_MODIF_NON_AUTORISE);
                    LockedChamps(EnumMode.MODE_MODIF_NON_AUTORISE);
                }
                txtconfirme.Text = txtpasswd.Text;
                m_bModeAjouter = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "cmdModifier_Click", ex);
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
                AfficherErreur("employe", "cmdFermer_Click", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstAutorisation;
                rstAutorisation = new Recordset();
                rstAutorisation.Open("SELECT * FROM AutorisationPunch", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstAutorisation.AddNew();
                rstAutorisation.Fields["NoEmploye"].Value = IdNoEmploye;
                rstAutorisation.Fields["AutoriserPar"].Value = cmbEmploye.SelectedIndex;
                rstAutorisation.Update();
                rstAutorisation.Close();
                rstAutorisation = default;
                RemplirComboEmployePunch();
                fraEmploye.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "cmdOK_Click", ex);
            }
        }
        private void cmdSupprimePunch_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int iEmploye;
                int iPunch;
                if (cmbEmployePunch.Items.Count > 0)
                {
                    iEmploye = (int)cmbEmploye.Items[cmbEmploye.SelectedIndex];
                    iPunch = (int)cmbEmployePunch.Items[cmbEmployePunch.SelectedIndex];
                    if (cmbEmployePunch.SelectedIndex > -1)
                    {
                        if (MessageBox.Show("Êtes vous sûr de vouloir supprimer cet employé?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateSQL("DELETE FROM AutorisationPunch WHERE NoEmploye = " + iPunch + " AND AutoriserPar = " + iEmploye);
                        }
                        RemplirComboEmployePunch();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "cmdSupprimePunch_Click", ex);
            }
        }
        private void cmdsupprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstFT;
                string sTampon;
                if (cmbEmploye.Items.Count > 0)
                {
                    if (MessageBox.Show("Etes-vous sur de supprimer cet enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rstFT = new Recordset();
                        rstFT.Open("SELECT * FROM Punch WHERE NoEmploye = " + m_iNoEmploye, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstFT.EOF)
                        {
                            rstProjSoum = new Recordset();
                            rstProjSoum.Open("SELECT * FROM Soumission_Modif WHERE NoEmployé = " + m_iNoEmploye, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (rstProjSoum.EOF)
                            {
                                rstProjSoum.Close();
                                rstProjSoum.Open("SELECT * FROM Projet_Modif WHERE NoEmployé = " + m_iNoEmploye, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (rstProjSoum.EOF)
                                {
                                    UpdateSQL("DELETE FROM employés WHERE noemploye = " + m_iNoEmploye);
                                    rstProjSoum.Close();
                                    rstProjSoum = default;
                                    rstFT.Close();
                                    rstFT = default;
                                    RemplirComboEmploye();
                                    if (cmbEmploye.Items.Count > 0)
                                    {
                                        cmbEmploye.SelectedIndex = 0;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Impossible d'effacer cet employé, il est utilisé dans le projet " + rstProjSoum.Fields["IDProjet"].Value + "!", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    rstProjSoum.Close();
                                    rstProjSoum = default;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Impossible d'effacer cet employé, il est utilisé dans la soumission " + rstProjSoum.Fields["IDSoumission"].Value + "!", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                rstProjSoum.Close();
                                rstProjSoum = default;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Impossible d'effacer cet employé, il est utilisé dans les feuilles de temps pour le projet " + rstFT.Fields["NoProjet"].Value + "!", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            rstFT.Close();
                            rstFT = default;
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "cmdSupprimer_Click", ex);
            }
        }
        private void Employe_Load1(object eventSender, EventArgs eventArgs)
        {
            //   RemplirComboEmploye();
            //   RemplirComboFamille();
            //   MontrerControles(EnumMode.MODE_INACTIF);
            //  LockedChamps(EnumMode.MODE_INACTIF);
            //  ActiverBoutonsGroupe();
            if (cmbEmploye.Items.Count >= 0)
            {
                cmbEmploye.SelectedIndex = 0;
            }
            Cursor.Current = Cursors.Default;
        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
                m_bModifEmploye = g_bModificationEmployes;
                cmdajouter.Enabled = m_bModifEmploye;
                cmdmodifier.Enabled = m_bModifEmploye;
                cmdsupprimer.Enabled = m_bModifEmploye;
                cmdConfig.Enabled = g_bModificationGroupes;
                cmdAjoutPunch.Enabled = g_bModificationPunchEmployes;
                cmdSupprimePunch.Enabled = g_bModificationPunchEmployes;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "ActiverBoutonsGroupe", ex);
            }
        }
        private void AfficherEmploye()
        {
            try
            {
                Text = $"Employé sélectionné : {cmbEmploye.Items[cmbEmploye.SelectedIndex].ToString()}";
                SqlConnection con = new SqlConnection(StringSQL);
                if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
                SqlDataReader rst = new SqlCommand($"SELECT DISTINCT NOEMPLOYE, LOGINNAME, PASSWD, EMPLOYE, INITIALE, TEL, PAGE, CELL, ACTIF, SUPPRIMÉ,[DBO].[FAMILLE].FAMILLE,[DBO].[GROUPES].[NOMGROUPE] FROM [DBO].[EMPLOYÉS] " +
                $"JOIN [DBO].[GROUPES] ON [DBO].[EMPLOYÉS].GROUPE=[DBO].[GROUPES].[IDGROUPE] " +
                $"JOIN [DBO].[FAMILLE] ON [DBO].[EMPLOYÉS].FAMILLE=[DBO].[FAMILLE].IDFAMILLE " +
                $"WHERE [ACTIF]=1 AND SUPPRIMÉ= 0   and employe='{cmbEmploye.SelectedItem.ToString()} '", con).ExecuteReader();
                while (rst.Read())
                {
                    txtNoEmployé.Text = rst["NOEMPLOYE"].ToString();
                    m_iNoEmploye = (int)rst["NOEMPLOYE"];
                    txtpasswd.Text = rst["PASSWD"].ToString();
                    txtuserid.Text = rst["LOGINNAME"].ToString();
                    txtinitiale.Text = rst["INITIALE"].ToString();
                    txtGroupe.Text = rst["NOMGROUPE"].ToString();
                    txtFamille.Text = rst["FAMILLE"].ToString();
                    txtCell.Text = rst["CELL"].ToString().Trim();
                    txtpage.Text = rst["PAGE"].ToString().Trim();
                    txtTel.Text = rst["TEL"].ToString().Trim();
                    chkActif.Checked = (bool)rst["Actif"];
                    nomUtilisateur = cmbEmploye.Text;
                }
                rst.Close();
                cmbEmployePunch.Items.Clear();
                rst = new SqlCommand($"SELECT [DBO].[EMPLOYÉS].EMPLOYE FROM AUTORISATIONPUNCH " +
                    $"JOIN [DBO].[EMPLOYÉS] ON[DBO].[AUTORISATIONPUNCH].NOEMPLOYE =[DBO].[EMPLOYÉS].NOEMPLOYE " +
                    $"WHERE AUTORISERPAR ='{m_iNoEmploye}'", con).ExecuteReader();
                while (rst.Read())
                {
                    cmbEmployePunch.Items.Add(rst[0].ToString());
                }
                con.Close();
                if (cmbEmployePunch.Items.Count > 0)
                {
                    cmbEmployePunch.SelectedIndex = 0;
                }
                rst.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "AfficherEmploye", ex);
            }
        }
        private void RemplirComboEmployePunch()
        {
            try
            {
                SqlConnection con = new SqlConnection(StringSQL);
                if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
                SqlDataReader rst = new SqlCommand($"SELECT [DBO].[EMPLOYÉS].EMPLOYE FROM AUTORISATIONPUNCH " +
                    $"JOIN [DBO].[EMPLOYÉS] ON[DBO].[AUTORISATIONPUNCH].NOEMPLOYE =[DBO].[EMPLOYÉS].NOEMPLOYE " +
                    $"WHERE AUTORISERPAR ='{m_iNoEmploye}'", con).ExecuteReader();
                while (rst.Read())
                {
                    cmbEmployePunch.Items.Add(rst[0].ToString());
                    txtNoEmployé.Text = rst["NOEMPLOYE"].ToString();
                    m_iNoEmploye = (int)rst["NOEMPLOYE"];
                    txtpasswd.Text = rst["PASSWD"].ToString();
                    txtuserid.Text = rst["LOGINNAME"].ToString();
                    txtinitiale.Text = rst["INITIALE"].ToString();
                    txtGroupe.Text = rst["NOMGROUPE"].ToString();
                    txtFamille.Text = rst["FAMILLE"].ToString();
                    txtCell.Text = rst["CELL"].ToString().Trim();
                    txtpage.Text = rst["PAGE"].ToString().Trim();
                    txtTel.Text = rst["TEL"].ToString().Trim();
                    chkActif.Checked = (bool)rst["Actif"];
                }
                con.Close();
                if (cmbEmployePunch.Items.Count > 0)
                {
                    cmbEmployePunch.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "RemplirComboEmployePunch", ex);
            }
        }
        private void RemplirComboEmploye()
        {
            ADODB.Recordset rstEmploye;
            rstEmploye = new Recordset();
            rstEmploye.Open("SELECT * FROM employés ORDER BY employe", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            cmbEmploye.Items.Clear();
            while (!rstEmploye.EOF)
            {
                cmbEmploye.Items.Add(rstEmploye.Fields[3].Value);
                rstEmploye.MoveNext();
            }
            rstEmploye.Close();
            //Object rstEmploye
            rstEmploye = default;
            return;
        }
        private void RemplirComboEmployeActif()
        {
            try
            {
                ADODB.Recordset rstEmploye;
                int X;
                int X2;
                bool bSupprimer;
                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT * FROM employés WHERE actif=1 ORDER BY employe", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbAjoutEmploye.Items.Clear();
                // remplis le combo employé
                /* ID 0 : noemploye 
                 * ID 1 : loginname 
                 * ID 2 : passwd 
                 * ID 3 : employe 
                 * ID 4 : initiale 
                 * ID 5 : tel 
                 * ID 6 : page 
                 * ID 7 : cell 
                 * ID 8 : Actif 
                 * ID 9 : groupe 
                 * ID 10 : Famille 
                 * ID 11 : Supprimé*/
                while (!rstEmploye.EOF)
                {
                    cmbAjoutEmploye.Items.Add(rstEmploye.Fields[3].Value);
                    rstEmploye.MoveNext();
                }
                rstEmploye.Close();
                //Object rstEmploye
                rstEmploye = default;
                X = 0;
                // Il faut enlever les employés déjà dans le combo et l'employé en cours
                while ((int)X <= cmbAjoutEmploye.Items.Count - 1)
                {
                    bSupprimer = false;
                    if ((cmbAjoutEmploye.Items[X].ToString() ?? "") == (IdNomEmploye ?? ""))
                    {
                        bSupprimer = true;
                    }
                    else
                    {
                        X2 = 0;
                        while ((int)X2 <= cmbEmployePunch.Items.Count - 1)
                        {
                            if ((cmbEmployePunch.Items[X2].ToString() ?? "") == (cmbAjoutEmploye.Items[X2].ToString() ?? ""))
                            {
                                bSupprimer = true;
                            }
                            X2 = (int)(X2 + 1);
                        }
                    }
                    if (bSupprimer == true)
                    {
                        cmbAjoutEmploye.Items.RemoveAt((int)X);
                    }
                    else
                    {
                        X = (int)(X + 1);
                    }
                }
                if (cmbAjoutEmploye.Items.Count > 0)
                {
                    cmbAjoutEmploye.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "RemplirComboEmployeActif", ex);
            }
        }
        private void mskCellulaire_GotFocus()
        {
            try
            {
                mskCellulaire.Mask = "(###) ###-####";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "mskCellulaire_GotFocus", ex);
            }
        }
        private void mskPagette_GotFocus()
        {
            try
            {
                mskPagette.Mask = "(###) ###-####";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "mskPagette_GotFocus", ex);
            }
        }
        private void mskTelephone_GotFocus()
        {
            try
            {
                mskTelephone.Mask = "(###) ###-####";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "mskTelephone_GotFocus", ex);
            }
        }
        private void mskCellulaire_LostFocus()
        {
            try
            {
                mskCellulaire.Mask = string.Empty;
                if (mskCellulaire.Text == "(___) ___-____")
                {
                    mskCellulaire.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "mskCellulaire_LostFocus", ex);
            }
        }
        private void mskPagette_LostFocus()
        {
            try
            {
                mskPagette.Mask = string.Empty;
                if (mskPagette.Text == "(___) ___-____")
                {
                    mskPagette.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "mskPagette_LostFocus", ex);
            }
        }
        //mskTelephone.LostFocus
        private void mskTelephone_LostFocus()
        {
            try
            {
                //  mskTelephone.Mask
                mskTelephone.Mask = string.Empty;
                if (mskTelephone.Text == "(___) ___-____")
                {
                    mskTelephone.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("employe", "mskTelephone_LostFocus", ex);
            }
        }
        private void Employe_Load(object sender, EventArgs e)
        {
            Icon = Conteneur.ActiveForm.Icon;
            ADODB.Recordset rs = new ADODB.Recordset();
            SqlLinkODBC(rs, "SELECT DISTINCT *  FROM [DBO].[EMPLOYÉS] WHERE ACTIF=1 AND SUPPRIMÉ= 0   ORDER BY EMPLOYE");
            while (!rs.EOF)
            {
                if (!(rs.Fields[0].Value is DBNull))
                {
                    cmbEmploye.Items.Add(rs.Fields[3].Value);
                }
                rs.MoveNext();
            }
            rs.Close();
            rs = default;
            RemplirComboFamille();
            MontrerControles(EnumMode.MODE_INACTIF);
            LockedChamps(EnumMode.MODE_INACTIF);
            ActiverBoutonsGroupe();
            if (cmbEmploye.Items.Count >= 0){cmbEmploye.SelectedIndex = 0;}
            Cursor.Current = Cursors.Default;
        }
        private void cmbGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem p in cmbGroupe.Items)
            {
                if (p.Text == cmbGroupe.Text) c_groupe = int.Parse(p.Value);
            }
        }
        private void cmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem p in cmbFamille.Items)
            {
                if (p.Text == cmbFamille.Text){c_Famille = int.Parse(p.Value);}
            }
        }
    }
}