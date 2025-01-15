using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ADODB;
using System.Diagnostics;
using System.Drawing;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using System.Collections.Generic;
namespace ControleurServeur
{
    internal class SortieMateriel : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public SortieMateriel() : base()
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
        internal static System.Windows.Forms.Button cmdFermer;
        internal static System.Windows.Forms.Button cmdEnregistrer;
        internal static ComboBox cmbEmployé;
        internal static System.Windows.Forms.TextBox txtQte;
        internal static ColumnHeader _lvwRecherche_ColumnHeader_1;
        internal static ColumnHeader _lvwRecherche_ColumnHeader_2;
        internal static ColumnHeader _lvwRecherche_ColumnHeader_3;
        internal static System.Windows.Forms.ListView lvwRecherche;
        internal static System.Windows.Forms.TextBox txtRecherche;
        internal static ComboBox cmbRecherche;
        internal static System.Windows.Forms.Button cmdRechercher;
        internal static System.Windows.Forms.Label Label5;
        internal static System.Windows.Forms.Label Label6;
        internal static GroupBox fraRecherche;
        internal static System.Windows.Forms.TextBox txtNoItem;
        internal static System.Windows.Forms.Label lblprojet;
        internal static System.Windows.Forms.Label Label4;
        internal static System.Windows.Forms.Label Label3;
        internal static System.Windows.Forms.Label Label2;
        internal static System.Windows.Forms.Label Label1;
        internal static System.Windows.Forms.Panel fraAjout;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdFermer = new System.Windows.Forms.Button();
            cmdEnregistrer = new System.Windows.Forms.Button();
            fraAjout = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            fraRecherche = new System.Windows.Forms.GroupBox();
            panel6 = new System.Windows.Forms.Panel();
            lvwRecherche = new System.Windows.Forms.ListView();
            _lvwRecherche_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwRecherche_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwRecherche_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            panel5 = new System.Windows.Forms.Panel();
            Label6 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            txtRecherche = new System.Windows.Forms.TextBox();
            cmdRechercher = new System.Windows.Forms.Button();
            cmbRecherche = new System.Windows.Forms.ComboBox();
            panel3 = new System.Windows.Forms.Panel();
            comboBox1 = new System.Windows.Forms.ComboBox();
            Label1 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            txtQte = new System.Windows.Forms.TextBox();
            lblprojet = new System.Windows.Forms.Label();
            txtNoItem = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            cmbEmployé = new System.Windows.Forms.ComboBox();
            Label4 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            fraAjout.SuspendLayout();
            panel4.SuspendLayout();
            fraRecherche.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdFermer
            // 
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.Cursor = System.Windows.Forms.Cursors.Default;
            cmdFermer.Dock = System.Windows.Forms.DockStyle.Right;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.Navy;
            cmdFermer.Location = new System.Drawing.Point(844, 0);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(81, 32);
            cmdFermer.TabIndex = 19;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(cmdFermer_Click);
            // 
            // cmdEnregistrer
            // 
            cmdEnregistrer.BackColor = System.Drawing.Color.Black;
            cmdEnregistrer.Cursor = System.Windows.Forms.Cursors.Default;
            cmdEnregistrer.Dock = System.Windows.Forms.DockStyle.Right;
            cmdEnregistrer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdEnregistrer.ForeColor = System.Drawing.Color.Navy;
            cmdEnregistrer.Location = new System.Drawing.Point(763, 0);
            cmdEnregistrer.Name = "cmdEnregistrer";
            cmdEnregistrer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdEnregistrer.Size = new System.Drawing.Size(81, 32);
            cmdEnregistrer.TabIndex = 18;
            cmdEnregistrer.Text = "Enregistrer";
            cmdEnregistrer.UseVisualStyleBackColor = true;
            cmdEnregistrer.Click += new System.EventHandler(cmdEnregistrer_Click);
            // 
            // fraAjout
            // 
            fraAjout.BackColor = System.Drawing.Color.Black;
            fraAjout.Controls.Add(panel4);
            fraAjout.Controls.Add(panel3);
            fraAjout.Controls.Add(panel2);
            fraAjout.Cursor = System.Windows.Forms.Cursors.Default;
            fraAjout.Dock = System.Windows.Forms.DockStyle.Fill;
            fraAjout.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraAjout.Location = new System.Drawing.Point(0, 0);
            fraAjout.Name = "fraAjout";
            fraAjout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraAjout.Size = new System.Drawing.Size(925, 513);
            fraAjout.TabIndex = 0;
            fraAjout.Text = "Frame1";
            // 
            // panel4
            // 
            panel4.Controls.Add(fraRecherche);
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.Location = new System.Drawing.Point(187, 51);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(738, 462);
            panel4.TabIndex = 14;
            // 
            // fraRecherche
            // 
            fraRecherche.BackColor = System.Drawing.Color.Black;
            fraRecherche.Controls.Add(panel6);
            fraRecherche.Controls.Add(panel5);
            fraRecherche.Dock = System.Windows.Forms.DockStyle.Fill;
            fraRecherche.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraRecherche.ForeColor = System.Drawing.Color.White;
            fraRecherche.Location = new System.Drawing.Point(0, 0);
            fraRecherche.Name = "fraRecherche";
            fraRecherche.Padding = new System.Windows.Forms.Padding(0);
            fraRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraRecherche.Size = new System.Drawing.Size(738, 462);
            fraRecherche.TabIndex = 11;
            fraRecherche.TabStop = false;
            fraRecherche.Text = "Recherche";
            // 
            // panel6
            // 
            panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel6.Controls.Add(lvwRecherche);
            panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            panel6.Location = new System.Drawing.Point(0, 73);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(738, 389);
            panel6.TabIndex = 19;
            // 
            // lvwRecherche
            // 
            lvwRecherche.BackColor = System.Drawing.Color.Black;
            lvwRecherche.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwRecherche_ColumnHeader_1,
            _lvwRecherche_ColumnHeader_2,
            _lvwRecherche_ColumnHeader_3});
            lvwRecherche.Dock = System.Windows.Forms.DockStyle.Fill;
            lvwRecherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwRecherche.ForeColor = System.Drawing.Color.White;
            lvwRecherche.FullRowSelect = true;
            lvwRecherche.GridLines = true;
            lvwRecherche.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            lvwRecherche.HideSelection = false;
            lvwRecherche.Location = new System.Drawing.Point(0, 0);
            lvwRecherche.Name = "lvwRecherche";
            lvwRecherche.Size = new System.Drawing.Size(734, 385);
            lvwRecherche.TabIndex = 17;
            lvwRecherche.UseCompatibleStateImageBehavior = false;
            lvwRecherche.View = System.Windows.Forms.View.Details;
            lvwRecherche.SelectedIndexChanged += new System.EventHandler(lvwRecherche_SelectedIndexChanged);
            lvwRecherche.DoubleClick += new System.EventHandler(lvwRecherche_DoubleClick);
            // 
            // _lvwRecherche_ColumnHeader_1
            // 
            _lvwRecherche_ColumnHeader_1.Text = "No Item";
            _lvwRecherche_ColumnHeader_1.Width = 170;
            // 
            // _lvwRecherche_ColumnHeader_2
            // 
            _lvwRecherche_ColumnHeader_2.Text = "Description";
            _lvwRecherche_ColumnHeader_2.Width = 170;
            // 
            // _lvwRecherche_ColumnHeader_3
            // 
            _lvwRecherche_ColumnHeader_3.Text = "Manufacturier";
            _lvwRecherche_ColumnHeader_3.Width = 170;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Black;
            panel5.Controls.Add(Label6);
            panel5.Controls.Add(Label5);
            panel5.Controls.Add(txtRecherche);
            panel5.Controls.Add(cmdRechercher);
            panel5.Controls.Add(cmbRecherche);
            panel5.Dock = System.Windows.Forms.DockStyle.Top;
            panel5.ForeColor = System.Drawing.Color.White;
            panel5.Location = new System.Drawing.Point(0, 13);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(738, 60);
            panel5.TabIndex = 18;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = System.Drawing.Color.Black;
            Label6.Cursor = System.Windows.Forms.Cursors.Default;
            Label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label6.ForeColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(159, 10);
            Label6.Name = "Label6";
            Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label6.Size = new System.Drawing.Size(97, 14);
            Label6.TabIndex = 13;
            Label6.Text = "Rechercher dans : ";
            // 
            // Label5
            // 
            Label5.BackColor = System.Drawing.Color.Black;
            Label5.Cursor = System.Windows.Forms.Cursors.Default;
            Label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(23, 10);
            Label5.Name = "Label5";
            Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label5.Size = new System.Drawing.Size(105, 17);
            Label5.TabIndex = 12;
            Label5.Text = "Texte à rechercher : ";
            // 
            // txtRecherche
            // 
            txtRecherche.AcceptsReturn = true;
            txtRecherche.BackColor = System.Drawing.Color.Black;
            txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtRecherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtRecherche.ForeColor = System.Drawing.Color.White;
            txtRecherche.Location = new System.Drawing.Point(23, 26);
            txtRecherche.MaxLength = 0;
            txtRecherche.Name = "txtRecherche";
            txtRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtRecherche.Size = new System.Drawing.Size(105, 22);
            txtRecherche.TabIndex = 14;
            // 
            // cmdRechercher
            // 
            cmdRechercher.BackColor = System.Drawing.Color.Black;
            cmdRechercher.Cursor = System.Windows.Forms.Cursors.Default;
            cmdRechercher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRechercher.ForeColor = System.Drawing.Color.Navy;
            cmdRechercher.Location = new System.Drawing.Point(279, 26);
            cmdRechercher.Name = "cmdRechercher";
            cmdRechercher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercher.Size = new System.Drawing.Size(81, 25);
            cmdRechercher.TabIndex = 16;
            cmdRechercher.Text = "Afficher";
            cmdRechercher.UseVisualStyleBackColor = true;
            cmdRechercher.Click += new System.EventHandler(cmdRechercher_Click);
            // 
            // cmbRecherche
            // 
            cmbRecherche.BackColor = System.Drawing.Color.Black;
            cmbRecherche.Cursor = System.Windows.Forms.Cursors.Default;
            cmbRecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRecherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbRecherche.ForeColor = System.Drawing.Color.White;
            cmbRecherche.Items.AddRange(new object[] {
            "No. Item",
            "Description",
            "Manufacturier"});
            cmbRecherche.Location = new System.Drawing.Point(159, 26);
            cmbRecherche.Name = "cmbRecherche";
            cmbRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbRecherche.Size = new System.Drawing.Size(100, 22);
            cmbRecherche.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Black;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(Label1);
            panel3.Controls.Add(Label2);
            panel3.Controls.Add(Label3);
            panel3.Controls.Add(txtQte);
            panel3.Controls.Add(lblprojet);
            panel3.Controls.Add(txtNoItem);
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.ForeColor = System.Drawing.Color.White;
            panel3.Location = new System.Drawing.Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(187, 462);
            panel3.TabIndex = 13;
            panel3.Paint += new System.Windows.Forms.PaintEventHandler(panel3_Paint);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(69, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(105, 22);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Cursor = System.Windows.Forms.Cursors.Default;
            Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(13, 8);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(59, 14);
            Label1.TabIndex = 3;
            Label1.Text = "No. Item : ";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Cursor = System.Windows.Forms.Cursors.Default;
            Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(13, 40);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(65, 14);
            Label2.TabIndex = 6;
            Label2.Text = "Qté sortie : ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Cursor = System.Windows.Forms.Cursors.Default;
            Label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.Location = new System.Drawing.Point(159, 9);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(29, 14);
            Label3.TabIndex = 4;
            Label3.Text = "---->";
            Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtQte
            // 
            txtQte.AcceptsReturn = true;
            txtQte.BackColor = System.Drawing.Color.Black;
            txtQte.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQte.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtQte.ForeColor = System.Drawing.Color.White;
            txtQte.Location = new System.Drawing.Point(69, 39);
            txtQte.MaxLength = 0;
            txtQte.Name = "txtQte";
            txtQte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQte.Size = new System.Drawing.Size(65, 22);
            txtQte.TabIndex = 7;
            // 
            // lblprojet
            // 
            lblprojet.BackColor = System.Drawing.Color.Black;
            lblprojet.Cursor = System.Windows.Forms.Cursors.Default;
            lblprojet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblprojet.ForeColor = System.Drawing.Color.White;
            lblprojet.Location = new System.Drawing.Point(13, 72);
            lblprojet.Name = "lblprojet";
            lblprojet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblprojet.Size = new System.Drawing.Size(57, 17);
            lblprojet.TabIndex = 8;
            lblprojet.Text = "No. Projet :";
            // 
            // txtNoItem
            // 
            txtNoItem.AcceptsReturn = true;
            txtNoItem.BackColor = System.Drawing.Color.Black;
            txtNoItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNoItem.ForeColor = System.Drawing.Color.White;
            txtNoItem.Location = new System.Drawing.Point(69, 9);
            txtNoItem.MaxLength = 0;
            txtNoItem.Name = "txtNoItem";
            txtNoItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoItem.Size = new System.Drawing.Size(89, 22);
            txtNoItem.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Black;
            panel2.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel2.Controls.Add(cmbEmployé);
            panel2.Controls.Add(Label4);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.ForeColor = System.Drawing.Color.White;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(925, 51);
            panel2.TabIndex = 12;
            // 
            // cmbEmployé
            // 
            cmbEmployé.BackColor = System.Drawing.Color.Black;
            cmbEmployé.Cursor = System.Windows.Forms.Cursors.Default;
            cmbEmployé.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEmployé.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbEmployé.ForeColor = System.Drawing.Color.White;
            cmbEmployé.Location = new System.Drawing.Point(313, 3);
            cmbEmployé.Name = "cmbEmployé";
            cmbEmployé.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbEmployé.Size = new System.Drawing.Size(234, 22);
            cmbEmployé.Sorted = true;
            cmbEmployé.TabIndex = 2;
            cmbEmployé.SelectedIndexChanged += new System.EventHandler(cmbEmployé_SelectedIndexChanged);
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Cursor = System.Windows.Forms.Cursors.Default;
            Label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.Location = new System.Drawing.Point(251, 9);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(59, 14);
            Label4.TabIndex = 1;
            Label4.Text = "Employé : ";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(cmdEnregistrer);
            panel1.Controls.Add(cmdFermer);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(0, 481);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(925, 32);
            panel1.TabIndex = 20;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
            // 
            // SortieMateriel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(925, 513);
            Controls.Add(panel1);
            Controls.Add(fraAjout);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            Location = new System.Drawing.Point(3, 22);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SortieMateriel";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ContrôleurWebAutoGRB.SortieMateriel";
            Load += new System.EventHandler(SortieMateriel_Load);
            fraAjout.ResumeLayout(false);
            panel4.ResumeLayout(false);
            fraRecherche.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion
        internal static System.Windows.Forms.Panel panel2;
        internal static System.Windows.Forms.Panel panel1;
        internal static System.Windows.Forms.Panel panel4;
        internal static System.Windows.Forms.Panel panel6;
        internal static System.Windows.Forms.Panel panel5;
        internal static System.Windows.Forms.Panel panel3;
        internal static ComboBox comboBox1;
        private const int I_CMB_NO_ITEM = 0;
        private const int I_CMB_DESCRIPTION = 1;
        private const int I_CMB_MANUFACTURIER = 2;
        private const int I_LVW_RECHERCHE_NO_ITEM = 0;
        private const int I_LVW_RECHERCHE_DESCRIPTION = 1;
        private const int I_LVW_RECHERCHE_MANUFACTURIER = 2;
        private enum EnumExtra
        {
            AUCUN_EXTRA = 0,
            EXTRA_CHARGEABLE = 1,
            EXTRA_NON_CHARGEABLE = 2
        }
        private EnumCatalogue m_eCatalogue;
        private EnumCatalogue mECANIQUE;
        public SortieMateriel(EnumCatalogue mECANIQUE)
        {
            mECANIQUE = mECANIQUE;
        }
        [Obsolete]
        private void cmdEnregistrer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstInv;
                ADODB.Recordset rstSortie;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstHistInv;
                ADODB.Recordset rstInitiale;
                if (!string.IsNullOrEmpty(txtNoItem.Text))
                {
                    if (IsNumeric(txtQte.Text))
                    {
                        if (comboBox1.Text != "_____-__" & comboBox1.Text != "M_____-__")
                        {
                            if (ProjetExiste() == true)
                            {
                                rstProjet = new Recordset();
                                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                                {
                                    rstProjet.Open("SELECT Modification, Par FROM ProjetElec WHERE IDProjet = '" + comboBox1.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                }
                                else
                                {
                                    rstProjet.Open("SELECT Modification, Par FROM ProjetMec WHERE IDProjet = '" + comboBox1.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                }
                                if ((bool)rstProjet.Fields["Modification"].Value)
                                {
                                    rstInv = new Recordset();
                                    if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                                    {
                                        rstInv.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + txtNoItem.Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                    }
                                    else
                                    {
                                        rstInv.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + txtNoItem.Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                    }
                                    if (!rstInv.EOF)
                                    {
                                        rstSortie = new Recordset();
                                        rstSortie.Open("SELECT * FROM SortieMatériel", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                        rstSortie.AddNew();
                                        rstSortie.Fields["Qté"].Value = txtQte.Text;
                                        rstSortie.Fields["Nom"].Value = cmbEmployé.Text;
                                        rstSortie.Fields["NoProjet"].Value = comboBox1.Text;
                                        rstSortie.Fields["NoItem"].Value = txtNoItem.Text;
                                        rstSortie.Fields["Date"].Value = ConvertDate(DateTime.Today);
                                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                                        {
                                            rstSortie.Fields["Type"].Value = "E";
                                        }
                                        else
                                        {
                                            rstSortie.Fields["Type"].Value = "M";
                                        }
                                        rstSortie.Update();
                                        rstSortie.Close();
                                        rstSortie = null;
                                        rstInv.Fields["QuantitéStock"].Value = double.Parse(rstInv.Fields["QuantitéStock"].Value) - double.Parse(txtQte.Text);
                                        rstInv.Update();
                                        rstHistInv = new Recordset();
                                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                                        {
                                            rstHistInv.Open("SELECT * FROM InventaireElecModif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                        }
                                        else
                                        {
                                            rstHistInv.Open("SELECT * FROM InventaireMecModif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                        }
                                        rstHistInv.AddNew();
                                        rstHistInv.Fields["Date"].Value = ConvertDate(DateTime.Today);
                                        rstHistInv.Fields["IDProjet"].Value = comboBox1.Text;
                                        rstHistInv.Fields["NoItem"].Value = txtNoItem.Text;
                                        rstHistInv.Fields["Quantité"].Value = "-" + Math.Abs(double.Parse(txtQte.Text));
                                        rstInitiale = new Recordset();
                                        rstInitiale.Open($"SELECT * FROM Employés WHERE Employe ='{cmbEmployé.Items[cmbEmployé.SelectedIndex].ToString()}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                        rstHistInv.Fields["User"].Value = rstInitiale.Fields["Initiale"].Value;
                                        rstInitiale.Close();
                                        rstInitiale = null;
                                        rstHistInv.Update();
                                        rstHistInv.Close();
                                        rstHistInv = null;
                                        rstProjet.Close();
                                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                                        {
                                            if (double.Parse(Droite(comboBox1.Text, 2)) >= 61d & double.Parse(Droite(comboBox1.Text, 2)) <= 80d)
                                            {
                                                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + comboBox1.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                                rstProjet.Close();
                                            }
                                            else if (double.Parse(Droite(comboBox1.Text, 2)) >= 81d & double.Parse(Droite(comboBox1.Text, 2)) <= 98d)
                                            {
                                                AjouterDansProjet(Gauche(comboBox1.Text, (comboBox1.Text.Length - 2)) + Droite("0" + (double.Parse(Droite(comboBox1.Text, 2)) - 80d), 2), EnumExtra.EXTRA_NON_CHARGEABLE, "");
                                            }
                                        }
                                        else if (double.Parse(Droite(comboBox1.Text, 2)) >= 61d & double.Parse(Droite(comboBox1.Text, 2)) <= 80d)
                                        {
                                            rstProjet.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + comboBox1.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                            AjouterDansProjet(Gauche(comboBox1.Text, comboBox1.Text.Length - 2) + rstProjet.Fields["LiaisonChargeable"].Value, EnumExtra.EXTRA_CHARGEABLE, Droite(comboBox1.Text, 2));
                                            rstProjet.Close();
                                        }
                                        else if (double.Parse(Droite(comboBox1.Text, 2)) >= 81d & double.Parse(Droite(comboBox1.Text, 2)) <= 98d)
                                        {
                                            AjouterDansProjet(Gauche(comboBox1.Text, comboBox1.Text.Length - 2) + Droite("0" + (double.Parse(Droite(comboBox1.Text, 2)) - 80d), 2), EnumExtra.EXTRA_NON_CHARGEABLE, "");
                                        }
                                        rstProjet = null;
                                        MessageBox.Show("La sortie de matériel a été enregistrée!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        ViderChamps();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cette pièce n'existe pas dans l'inventaire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                    rstInv.Close();
                                    rstInv = null;
                                }
                                else
                                {
                                    MessageBox.Show($"Ce projet est en modification par {rstProjet.Fields["Par"].Value} !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    rstProjet.Close();
                                    rstProjet = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Projet inexistant!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Le numéro de projet est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantité non numérique!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Le numéro d'item est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "cmdEnregistrer_Click", ex);
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
                AfficherErreur("SortieMateriel", "cmdFermer_Click", ex);
            }
        }
        [Obsolete]
        private void ViderChamps()
        {
            try
            {
                int X;
                txtNoItem.Text = "";
                txtQte.Text = "";
                txtRecherche.Text = "";
                cmbRecherche.SelectedIndex = 0;
                comboBox1.Text = "_____-__";
                for (X = 0; X <= (cmbEmployé.Items.Count - 1); X++)
                {
                    if ((cmbEmployé.Items[X].ToString() ?? "") == (IdNomEmploye ?? ""))
                    {
                        cmbEmployé.SelectedIndex = X;
                        break;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "ViderChamps", ex);
            }
        }
        private void RemplirListViewRecherche()
        {
            try
            {
                ADODB.Recordset rstInv;
                ListViewItem itmInv;
                var sWhere = default(string);
                Cursor.Current = Cursors.WaitCursor;
                lvwRecherche.Items.Clear();
                switch (cmbRecherche.SelectedIndex)
                {
                    case I_CMB_NO_ITEM: { sWhere = "NoItem like '%" + txtRecherche.Text + "%'"; break; }
                    case I_CMB_DESCRIPTION: { sWhere = "Description like '%" + txtRecherche.Text + "'"; break; }
                    case I_CMB_MANUFACTURIER: { sWhere = "Manufacturier like '%" + txtRecherche.Text + "%'"; break; }
                }
                rstInv = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstInv.Open("SELECT * FROM InventaireElec WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstInv.Open("SELECT * FROM InventaireMec WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstInv.EOF)
                {
                    itmInv = lvwRecherche.Items.Add(string.Empty);
                    itmInv.Text = (string)(rstInv.Fields["NoItem"].Value);
                    if (itmInv.SubItems.Count > I_LVW_RECHERCHE_DESCRIPTION)
                    {
                        itmInv.SubItems[I_LVW_RECHERCHE_DESCRIPTION].Text = (string)(rstInv.Fields["Description"].Value);
                    }
                    else
                    {
                        itmInv.SubItems.Insert(I_LVW_RECHERCHE_DESCRIPTION, new ListViewItem.ListViewSubItem(null, (string)(rstInv.Fields["Description"].Value)));
                    }
                    if (itmInv.SubItems.Count > I_LVW_RECHERCHE_MANUFACTURIER)
                    {
                        itmInv.SubItems[I_LVW_RECHERCHE_MANUFACTURIER].Text = (string)(rstInv.Fields["Manufacturier"].Value);
                    }
                    else
                    {
                        itmInv.SubItems.Insert(I_LVW_RECHERCHE_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, (string)(rstInv.Fields["Manufacturier"].Value)));
                    }
                    rstInv.MoveNext();
                }
                rstInv.Close();
                rstInv = null;
                Cursor.Current = Cursors.Default;
                if (lvwRecherche.Items.Count == 0)
                {
                    MessageBox.Show("Aucun enregistrement trouvé!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "RemplirListViewRecherche", ex);
            }
        }
        private void cmdRechercher_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRecherche.Text))
                {
                    RemplirListViewRecherche();
                }
                else
                {
                    MessageBox.Show("Rien à rechercher!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "cmdRechercher_Click", ex);
            }
        }
        private void SortieMateriel_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                RemplirComboEmployes();
                ViderChamps();
                EnumListeProjets();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "Form_Load", ex);
            }
        }
        private void RemplirComboEmployes()
        {
            ADODB.Recordset rstEmploye;
            rstEmploye = new Recordset();
            rstEmploye.Open("SELECT * FROM Employés WHERE actif=1", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            cmbEmployé.Items.Add("@ll");
            while (!rstEmploye.EOF)
            {
                cmbEmployé.Items.Add(new ListItem(Text = rstEmploye.Fields["Employe"].Value, $"{rstEmploye.Fields["NoEmploye"].Value}"));
                rstEmploye.MoveNext();
            }
            rstEmploye.Close();
            rstEmploye = null;
            return;
        }
        private void lvwRecherche_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwRecherche.Items.Count > 0)
                {
                    txtNoItem.Text = lvwRecherche.FocusedItem.Text;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "lvwRecherche_DblClick", ex);
            }
        }
        private void mskNoProjet_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (fraAjout.Visible == true)
                {
                    if (Strings.InStr(1, comboBox1.Text, "_") == 0)
                    {
                        ProjetExiste();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "mskNoProjet_Change", ex);
            }
        }
        private void EnumListeProjets()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            comboBox1.Items.Clear();
            rst.Open("SELECT distinct [IDProjSoum] FROM ProjSoum", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rst.EOF)
            {
                if (int.Parse(Droite(rst.Fields[0].Value, 2)) > 50 & int.Parse(Droite(rst.Fields[0].Value, 2)) < 99)
                {
                    comboBox1.Items.Add($"{rst.Fields[0].Value}");
                }
                rst.MoveNext();
            }
            rst.Close();
            rst = null;
        }
        private void AfficherDetailsProjet()
        {
            ADODB.Recordset rst = new ADODB.Recordset();
            lvwRecherche.Items.Clear();
            lvwRecherche.Columns.Clear();
            lvwRecherche.ForeColor = Color.White;
            ListViewItem itmInv;
            if (comboBox1.Text.Substring(0, 1) == "E")
            {
                rst.Open($"SELECT [DBO].[Projet_Pieces].[NoEnreg],[NumItem],[Desc_FR],[Manufact],[Qté],[DBO].[InventaireElec].QuantitéStock FROM [DBO].[Projet_Pieces] " +
                    $"JOIN [DBO].[InventaireElec] on[DBO].[Projet_Pieces].NumItem =[DBO].[InventaireElec].NoItem " +
                    $"where[IDProjet] ='{comboBox1.Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            else
            {
                rst.Open($"SELECT [DBO].[Projet_Pieces].[NoEnreg],[NumItem],[Desc_FR],[Manufact],[Qté],[DBO].[InventaireMec].QuantitéStock FROM [DBO].[Projet_Pieces] " +
                    $"JOIN [DBO].[InventaireMec] on[DBO].[Projet_Pieces].NumItem =[DBO].[InventaireMec].NoItem " +
                    $"where[IDProjet] = '{comboBox1.Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            }
            if (!rst.EOF)
            {
                for (int a = 0; a < rst.Fields.Count; a++)
                {
                    lvwRecherche.Columns.Add(rst.Fields[a].Name);
                }
            }
            while (!rst.EOF)
            {
                itmInv = lvwRecherche.Items.Add(string.Empty);
                for (int a = 0; a < rst.Fields.Count; a++)
                {
                    if (itmInv.SubItems.Count > a)
                    {
                        itmInv.SubItems[a].Text = $"{rst.Fields[a].Value}";
                    }
                    else
                    {
                        itmInv.SubItems.Insert(a, new ListViewItem.ListViewSubItem(null, $"{rst.Fields[a].Value}"));
                    }
                }
                rst.MoveNext();
            }
            rst.Close();
            rst = null;
            for (int a = 0; a < lvwRecherche.Items.Count; a++)
            {
                if (int.Parse(lvwRecherche.Items[a].SubItems[4].Text) == 0){lvwRecherche.Items[a].ForeColor = Color.Orange;}
                if (int.Parse(lvwRecherche.Items[a].SubItems[4].Text) < 0){lvwRecherche.Items[a].ForeColor = Color.Red;}
            }
        }
        private bool ProjetExiste()
        {
            bool ProjetExisteRet = default;
            try
            {
                ADODB.Recordset rstProjSoum;
                int X;
                if (double.Parse(Droite(comboBox1.Text, 2)) >= 51d & double.Parse(Droite(comboBox1.Text, 2)) <= 98d)
                {
                    rstProjSoum = new Recordset();
                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + comboBox1.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstProjSoum.EOF)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["Ouvert"].Value, false, false)))
                        {
                            MessageBox.Show("Ce projet n'est pas ouvert!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            ProjetExisteRet = false;
                        }
                        else
                        {
                            ProjetExisteRet = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Projet inexistant!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ProjetExisteRet = false;
                    }
                    rstProjSoum.Close();
                    rstProjSoum = null;
                }
                else
                {
                    MessageBox.Show("Impossible de faire une sortie de matériel sur ce numéro!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ProjetExisteRet = false;
                }
                return ProjetExisteRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "AfficherClient", ex);
                return false;
            }
        }
        public void Afficher(EnumCatalogue eCatalogue)
        {
            try
            {
                m_eCatalogue = eCatalogue;
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "Afficher", ex);
            }
        }
        private void AjouterDansProjet(string sNoProjet, EnumExtra eExtra, string sProvenance)
        {
            try
            {
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstSection;
                ADODB.Recordset rstInv;
                int X;
                string sSection;
                var bSkip = default(bool);
                string sIDSection;
                string sOrdre;
                string sProfit;
                rstProjet = new Recordset();
                rstSection = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstSection.Open("SELECT * FROM SoumProjSectionElec WHERE NomSectionFR = 'Externe'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    sProfit = (string)(rstProjet.Fields["Profit"].Value);
                    rstProjet.Close();
                }
                else
                {
                    rstSection.Open("SELECT * FROM SoumProjSectionMec WHERE NomSectionFR = 'Externe'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstProjet.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
                    sProfit = (string)(rstProjet.Fields["Profit"].Value);
                    rstProjet.Close();
                }
                sIDSection = (string)(rstSection.Fields["IDSection"].Value);
                sOrdre = (string)(rstSection.Fields["Ordre"].Value);
                rstSection.Close();
                rstSection = null;

                rstPiece = new Recordset();
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND IDSection = " + sIDSection + " AND SousSection = 'PAS DE SOUS-SECTION' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstPiece.EOF)
                {
                    rstPiece.MoveLast();
                    X = int.Parse(Operators.AddObject(rstPiece.Fields["NuméroLigne"].Value, 1));
                }
                else
                {
                    X = 1;
                }
                rstInv = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstInv.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + txtNoItem.Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstInv.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + txtNoItem.Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                rstPiece.AddNew();
                rstPiece.Fields["IDProjet"].Value = sNoProjet;
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstPiece.Fields["Type"].Value = "E";
                }
                else
                {
                    rstPiece.Fields["Type"].Value = "M";
                }
                rstPiece.Fields["Visible"].Value = true;
                rstPiece.Fields["Facturation"].Value = "";
                rstPiece.Fields["IDSection"].Value = sIDSection;
                rstPiece.Fields["NumItem"].Value = rstInv.Fields["NoItem"].Value;
                rstPiece.Fields["Qté"].Value = txtQte.Text;
                rstPiece.Fields["Desc_FR"].Value = rstInv.Fields["Description"].Value;
                rstPiece.Fields["Desc_EN"].Value = "";
                rstPiece.Fields["Manufact"].Value = rstInv.Fields["Manufacturier"].Value;
                rstPiece.Fields["Prix_list"].Value = (string)(rstInv.Fields["Prix liste"].Value);
                rstPiece.Fields["Escompte"].Value = (string)(rstInv.Fields["Escompte"].Value);
                rstPiece.Fields["Prix_net"].Value = (string)(rstInv.Fields["Prix net"].Value);
                rstPiece.Fields["OrdreSection"].Value = sOrdre;
                rstPiece.Fields["NuméroLigne"].Value = X;
                rstPiece.Fields["IDFRS"].Value = 717;
                rstPiece.Fields["Prix_Total"].Value = (string)(Operators.MultiplyObject(Operators.MultiplyObject(rstInv.Fields["Prix net"].Value, double.Parse(txtQte.Text)), double.Parse(sProfit)));
                rstPiece.Fields["Profit_argent"].Value = float.Parse(rstPiece.Fields["Prix_Total"].Value) - (float.Parse(rstInv.Fields["Prix net"].Value) * float.Parse(txtQte.Text));
                rstPiece.Fields["SousSection"].Value = "PAS DE SOUS-SECTION";
                rstPiece.Fields["PrixOrigine"].Value = Math.Round(double.Parse(rstInv.Fields["Prix liste"].Value), 2).ToString();
                switch (eExtra)
                {
                    case EnumExtra.EXTRA_CHARGEABLE:
                        {
                            rstPiece.Fields["PieceExtraChargeable"].Value = true;
                            rstPiece.Fields["PieceExtraNonChargeable"].Value = false; break;
                        }
                    case EnumExtra.EXTRA_NON_CHARGEABLE:
                        {
                            rstPiece.Fields["PieceExtraChargeable"].Value = false;
                            rstPiece.Fields["PieceExtraNonChargeable"].Value = true; break;
                        }
                    case EnumExtra.AUCUN_EXTRA:
                        {
                            rstPiece.Fields["PieceExtraChargeable"].Value = false;
                            rstPiece.Fields["PieceExtraNonChargeable"].Value = false; break;
                        }
                }
                rstPiece.Fields["Provenance"].Value = sProvenance;
                rstPiece.Update();
                rstPiece.Close();
                rstInv.Close();
                rstInv = null;
                rstPiece.CursorLocation = CursorLocationEnum.adUseServer;
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND NuméroLigne >= " + X + " ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF)
                {
                    if (bSkip == false)
                    {
                        bSkip = true;
                    }
                    else
                    {
                        rstPiece.Fields["NuméroLigne"].Value = Operators.AddObject(rstPiece.Fields["NuméroLigne"].Value, 1);
                        rstPiece.Update();
                    }
                    rstPiece.MoveNext();
                }
                rstPiece.Close();
                rstPiece = null;
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    CalculerTempsMecRecordset(sNoProjet);
                    CalculerTotalRecordsetElec(sNoProjet);
                }
                else
                {
                    CalculerTotalRecordsetMec(sNoProjet);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "AjouterDansProjet", ex);
            }
        }
        private void CalculerTempsMecRecordset(string sNoProjet)
        {
            try
            {
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstPiece;
                var dblTempsMec = default(double);
                rstProjet = new Recordset();
                rstPiece = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet ='" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF)
                {
                    if (!string.IsNullOrEmpty(rstPiece.Fields["Temps_total"].Value).Trim())
                    {
                        dblTempsMec += double.Parse(rstPiece.Fields["Temps_total"].Value).Trim();
                    }
                    rstPiece.MoveNext();
                }
                rstProjet.Fields["temp_mec"].Value = (dblTempsMec / 10d).ToString().Replace(".", ",");
                rstProjet.Update();
                rstPiece.Close();
                rstPiece = null;
                rstProjet.Close();
                rstProjet = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "CalculerTempsMecRecordset", ex);
            }
        }
        private void CalculerTotalRecordsetElec(string sNoProjet)
        {
            try
            {
                double dblManuel;
                double dblCopies;
                double dblTempsDessin;
                double dblTempsProg;
                double dblTempsMec;
                double dblTempsElec;
                double dblTempsTest;
                double dblTempsVision;
                var dblPrixPieces = default(double);
                double dblPrixTotal;
                double dblCommission;
                double dblTotalTemps;
                var dblProfit = default(double);
                double dblTotalManuel;
                double dblTotalPieceImprevue;
                double dblGrandTotal;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstConfig;
                string sCommission;
                string sCopieManuel;
                string sImprevue;
                rstProjet = new Recordset();
                rstPiece = new Recordset();
                rstConfig = new Recordset();
                rstConfig.Open("SELECT * FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sCommission = (string)(rstConfig.Fields["Commission"].Value);
                sImprevue = (string)(rstConfig.Fields["Imprévus"].Value);
                sCopieManuel = (string)(rstConfig.Fields["PrixPagesManuel"].Value);
                rstConfig.Close();
                rstConfig = null;
                rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjet.EOF)
                {
                    if (IsNumeric(rstProjet.Fields["Manuel"].Value))
                    {
                        dblManuel = double.Parse(rstProjet.Fields["Manuel"].Value);
                    }
                    else
                    {
                        dblManuel = 0d;
                    }
                    if (IsNumeric(rstProjet.Fields["copies"].Value))
                    {
                        dblCopies = double.Parse(rstProjet.Fields["copies"].Value);
                    }
                    else
                    {
                        dblCopies = 0d;
                    }
                    if (IsNumeric(rstProjet.Fields["temp_dessin"].Value))
                    {
                        dblTempsDessin = double.Parse(rstProjet.Fields["temp_dessin"].Value);
                    }
                    else
                    {
                        dblTempsDessin = 0d;
                    }
                    if (IsNumeric(rstProjet.Fields["temp_prog"].Value))
                    {
                        dblTempsProg = double.Parse(rstProjet.Fields["temp_prog"].Value);
                    }
                    else
                    {
                        dblTempsProg = 0d;
                    }
                    if ((bool)rstProjet.Fields["SansTemps"].Value == true)
                    {
                        dblTempsMec = 0d;
                    }
                    else
                    {
                        dblTempsMec = double.Parse(rstProjet.Fields["temp_mec"].Value);
                    }
                    if (IsNumeric(rstProjet.Fields["temp_elec"].Value))
                    {
                        dblTempsElec = double.Parse(rstProjet.Fields["temp_elec"].Value);
                    }
                    else
                    {
                        dblTempsElec = 0d;
                    }
                    if (IsNumeric(rstProjet.Fields["temp_test"].Value))
                    {
                        dblTempsTest = double.Parse(rstProjet.Fields["temp_test"].Value);
                    }
                    else
                    {
                        dblTempsTest = 0d;
                    }
                    if (IsNumeric(rstProjet.Fields["temp_vision"].Value))
                    {
                        dblTempsVision = double.Parse(rstProjet.Fields["temp_vision"].Value);
                    }
                    else
                    {
                        dblTempsVision = 0d;
                    }
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND Type = 'E'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstPiece.EOF)
                    {
                        if (!string.IsNullOrEmpty((string)(rstPiece.Fields["Prix_total"].Value).Trim()))
                        {
                            dblPrixPieces += double.Parse(rstPiece.Fields["Prix_total"].Value);
                            dblProfit += double.Parse(rstPiece.Fields["Profit_Argent"].Value);
                        }
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstPiece = null;
                    dblTotalTemps = dblTempsDessin * double.Parse(rstProjet.Fields["taux_dessin"].Value) + dblTempsProg * double.Parse(rstProjet.Fields["taux_prog"].Value) + dblTempsMec * double.Parse(rstProjet.Fields["taux_mec"].Value) + dblTempsElec * double.Parse(rstProjet.Fields["taux_elec"].Value) + dblTempsTest * double.Parse(rstProjet.Fields["taux_test"].Value) + dblTempsVision * double.Parse(rstProjet.Fields["taux_vision"].Value);
                    dblTotalManuel = dblManuel * dblCopies * double.Parse(sCopieManuel);
                    dblTotalPieceImprevue = dblPrixPieces * (1d + double.Parse(sImprevue));
                    dblPrixTotal = dblTotalTemps + dblTotalManuel + dblTotalPieceImprevue;
                    dblCommission = dblPrixTotal * double.Parse(sCommission);
                    dblGrandTotal = dblPrixTotal + dblCommission;
                    rstProjet.Fields["total_commission"].Value = dblCommission;
                    rstProjet.Fields["Total_manuel"].Value = dblTotalManuel;
                    rstProjet.Fields["Total_temps"].Value = dblTotalTemps;
                    rstProjet.Fields["total_imprevue"].Value = dblTotalPieceImprevue - dblPrixPieces;
                    rstProjet.Fields["total_piece"].Value = dblPrixPieces;
                    rstProjet.Fields["Total_Commission"].Value = Math.Round(dblCommission, 2).ToString();
                    rstProjet.Fields["PrixTotal"].Value = Math.Round(dblGrandTotal, 2).ToString();
                    rstProjet.Fields["Total_Profit"].Value = Math.Round(dblProfit, 2).ToString();
                    rstProjet.Update();
                }
                rstProjet.Close();
                rstProjet = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "CalculerTotalRecordset", ex);
            }
        }
        private void CalculerTotalRecordsetMec(string sNoProjet)
        {
            try
            {
                var dblPrixPieces = default(double);
                double dblPrixTotal;
                double dblCommission;
                double dblTotalTemps;
                var dblProfit = default(double);
                double dblTotalManuel;
                double dblTotalImprevue;
                double dblGrandTotal;
                double dblTotalDessin;
                double dblTotalCoupe;
                double dblTotalMachinage;
                double dblTotalSoudure;
                double dblTotalAssemblage;
                double dblTotalPeinture;
                double dblTotalTest;
                double dblTotalInstallation;
                double dblTotalFormation;
                double dblTotalGestion;
                var dblHebergement = default(double);
                double dblRepas;
                double dblTransport;
                double dblUniteMobile;
                double dblPrixEmballage;
                double dblTotalResteTemps;
                int iNbrePersonne;
                ADODB.Recordset rstProjet = new ADODB.Recordset();
                ADODB.Recordset rstPiece = new ADODB.Recordset();
                ADODB.Recordset rstConfig = new ADODB.Recordset();
                string sCommission;
                string sImprevue;
                rstConfig.Open("SELECT * FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sCommission = (string)(rstConfig.Fields["Commission"].Value);
                sImprevue = (string)(rstConfig.Fields["Imprévus"].Value);
                rstConfig.Close();
                rstConfig = null;
                rstProjet.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND Type = 'M'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF)
                {
                    if (!string.IsNullOrEmpty((string)(rstPiece.Fields["Prix_total"].Value).Trim()))
                    {
                        dblPrixPieces = double.Parse(Operators.SubtractObject(Operators.AddObject(dblPrixPieces, rstPiece.Fields["Prix_total"].Value), rstPiece.Fields["Profit_Argent"].Value));
                        dblProfit = double.Parse(Operators.AddObject(dblProfit, rstPiece.Fields["Profit_Argent"].Value));
                    }
                    rstPiece.MoveNext();
                }
                dblTotalMachinage = double.Parse(rstProjet.Fields["TempsMachinage"].Value) * double.Parse(rstProjet.Fields["TauxMachinage"].Value);
                dblTotalCoupe = double.Parse(rstProjet.Fields["TempsCoupe"].Value) * double.Parse(rstProjet.Fields["TauxCoupePréparation"].Value);
                dblTotalSoudure = double.Parse(rstProjet.Fields["TempsSoudure"].Value) * double.Parse(rstProjet.Fields["TauxAssemblageSoudure"].Value);
                dblTotalAssemblage = double.Parse(rstProjet.Fields["TempsAssemblage"].Value) * double.Parse(rstProjet.Fields["TauxAssemblageSystèmes"].Value);
                dblTotalPeinture = double.Parse(rstProjet.Fields["TempsPeinture"].Value) * double.Parse(rstProjet.Fields["TauxPeintureFinition"].Value);
                dblTotalTest = double.Parse(rstProjet.Fields["TempsTest"].Value) * double.Parse(rstProjet.Fields["TauxTestsFinaux"].Value);
                dblTotalDessin = double.Parse(rstProjet.Fields["TempsDessin"].Value) * double.Parse(rstProjet.Fields["TauxConceptionDessins"].Value);
                dblTotalFormation = double.Parse(rstProjet.Fields["TempsFormation"].Value) * double.Parse(rstProjet.Fields["TauxFormation"].Value);
                dblTotalInstallation = double.Parse(rstProjet.Fields["TempsInstallation"].Value) * double.Parse(rstProjet.Fields["TauxInstallation"].Value);
                dblTotalGestion = double.Parse(rstProjet.Fields["TempsGestion"].Value) * double.Parse(rstProjet.Fields["TauxGestion"].Value);
                dblTotalTemps = dblTotalMachinage + dblTotalCoupe + dblTotalSoudure + dblTotalAssemblage + dblTotalPeinture + dblTotalTest + dblTotalDessin + dblTotalFormation + dblTotalInstallation;
                if (!(rstProjet.Fields["NbrePersonne"].Value is DBNull))
                {
                    if (!string.IsNullOrEmpty((string)(rstProjet.Fields["NbrePersonne"].Value).Trim()))
                    {
                        iNbrePersonne = (int)Math.Round(Conversion.Int(double.Parse(rstProjet.Fields["NbrePersonne"].Value)));
                    }
                    else
                    {
                        iNbrePersonne = 0;
                    }
                }
                else
                {
                    iNbrePersonne = 0;
                }
                while (iNbrePersonne > 0)
                {
                    if (iNbrePersonne >= 2)
                    {
                        dblHebergement = dblHebergement + double.Parse(rstProjet.Fields["TempsHebergement"].Value) * double.Parse(rstProjet.Fields["TauxHebergement2"].Value);
                        iNbrePersonne = (int)(iNbrePersonne - 2);
                    }
                    else
                    {
                        dblHebergement = dblHebergement + double.Parse(rstProjet.Fields["TempsHebergement"].Value) * double.Parse(rstProjet.Fields["TauxHebergement1"].Value);
                        iNbrePersonne = (int)(iNbrePersonne - 1);
                    }
                }
                if (!(rstProjet.Fields["NbrePersonne"].Value is DBNull))
                {
                    if (!string.IsNullOrEmpty((string)(rstProjet.Fields["NbrePersonne"].Value).Trim()))
                    {
                        dblRepas = double.Parse(rstProjet.Fields["TempsRepas"].Value) * double.Parse(rstProjet.Fields["TauxRepas"].Value) * double.Parse(rstProjet.Fields["NbrePersonne"].Value);
                    }
                    else
                    {
                        dblRepas = 0d;
                    }
                }
                else
                {
                    dblRepas = 0d;
                }
                dblTransport = double.Parse(rstProjet.Fields["TempsTransport"].Value) * double.Parse(rstProjet.Fields["TauxTransport"].Value);
                dblUniteMobile = double.Parse(rstProjet.Fields["TempsUniteMobile"].Value) * double.Parse(rstProjet.Fields["TauxUniteMobile"].Value);
                if (IsNumeric(rstProjet.Fields["PrixEmballage"].Value))
                {
                    dblPrixEmballage = double.Parse(rstProjet.Fields["PrixEmballage"].Value);
                }
                else
                {
                    dblPrixEmballage = 0d;
                }
                dblTotalResteTemps = dblHebergement + dblRepas + dblTransport + dblUniteMobile + dblPrixEmballage;
                if (IsNumeric(rstProjet.Fields["total_manuel"].Value))
                {
                    dblTotalManuel = double.Parse(rstProjet.Fields["total_manuel"].Value);
                }
                else
                {
                    dblTotalManuel = 0d;
                }
                dblTotalImprevue = (dblPrixPieces + dblProfit) * double.Parse(sImprevue);
                dblPrixTotal = dblPrixPieces + dblProfit + dblTotalTemps + dblTotalImprevue + dblTotalManuel + dblTotalResteTemps;
                dblCommission = dblPrixTotal * double.Parse(sCommission);
                dblGrandTotal = dblPrixTotal + dblCommission;
                rstProjet.Fields["Total_Piece"].Value = Math.Round(dblPrixPieces, 2).ToString();
                rstProjet.Fields["Total_Temps"].Value = Math.Round(dblTotalTemps, 2).ToString();
                rstProjet.Fields["PrixTotal"].Value = Math.Round(dblGrandTotal, 2).ToString();
                rstProjet.Fields["total_Imprevue"].Value = Math.Round(dblTotalImprevue, 2).ToString();
                rstProjet.Fields["total_commission"].Value = Math.Round(dblCommission, 2).ToString();
                rstProjet.Fields["total_profit"].Value = Math.Round(dblProfit, 2).ToString();
                rstProjet.Update();
                rstPiece.Close();
                rstPiece = null;
                rstProjet.Close();
                rstProjet = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "CalculerTotalRecordset", ex);
            }
        }
        private void cmbEmployé_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = $"Sortie de matériel pour {cmbEmployé.Text}";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (fraAjout.Visible == true)
                {
                    if (Strings.InStr(1, comboBox1.Text, "_") == 0)
                    {
                        ProjetExiste();
                    }
                }
                AfficherDetailsProjet();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SortieMateriel", "mskNoProjet_Change", ex);
            }
        }
        private void lvwRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lvwRecherche.FocusedItem;
            txtNoItem.Text = item.SubItems[1].Text;
            if (int.Parse($"{item.SubItems[5].Text}") < 1)
            {
                item.ForeColor = COLOR_ROUGE;
                MessageBox.Show("Il reste " + item.SubItems[5].Text + "dans l'inventaire", Application.ProductName + ".SortieMateriel.SortirItem",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}