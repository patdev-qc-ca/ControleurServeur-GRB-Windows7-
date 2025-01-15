using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;
using ADODB;
using System.Drawing;

namespace ControleurServeur
{
    internal  class RetourMateriel : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public RetourMateriel() : base()
        {
            InitializeComponent();
        }
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!(components is  null))
                {
                    components.Dispose();
                }
            }
            base.Dispose(Disposing);
        }
        private System.ComponentModel.IContainer components;
        internal static System.Windows.Forms.ToolTip ToolTip1;
        internal static System.Windows.Forms.Button cmdFermer;
        internal static System.Windows.Forms.Button cmdEnregistrer;
        internal static System.Windows.Forms.CheckBox chkMecanique;
        internal static System.Windows.Forms.ComboBox cmbEmployé;
        internal static System.Windows.Forms.TextBox txtQte;
        internal static System.Windows.Forms.ColumnHeader _lvwRecherche_ColumnHeader_1;
        internal static System.Windows.Forms.ColumnHeader _lvwRecherche_ColumnHeader_2;
        internal static System.Windows.Forms.ColumnHeader _lvwRecherche_ColumnHeader_3;
        internal static System.Windows.Forms.ListView lvwRecherche;
        internal static System.Windows.Forms.TextBox txtRecherche;
        internal static System.Windows.Forms.ComboBox cmbRecherche;
        internal static System.Windows.Forms.Button cmdRechercher;
        internal static System.Windows.Forms.Label Label5;
        internal static System.Windows.Forms.Label Label6;
        internal static System.Windows.Forms.GroupBox fraRecherche;
        internal static System.Windows.Forms.TextBox txtNoItem;
        internal static System.Windows.Forms.MaskedTextBox mskNoProjet;
        internal static System.Windows.Forms.Label lblprojet;
        internal static System.Windows.Forms.Label Label4;
        internal static System.Windows.Forms.Label Label3;
        internal static System.Windows.Forms.Label Label2;
        internal static System.Windows.Forms.Label Label1;
        internal static System.Windows.Forms.Panel fraAjout;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.Resources.ResourceManager(typeof(RetourMateriel));
            components = new System.ComponentModel.Container();
            ToolTip1 = new ToolTip(components);
            cmdFermer = new Button();
            cmdFermer.Click += new EventHandler(cmdFermer_Click);
            cmdEnregistrer = new Button();
            cmdEnregistrer.Click += new EventHandler(cmdEnregistrer_Click);
            fraAjout = new Panel();
            chkMecanique = new CheckBox();
            chkMecanique.CheckStateChanged += new EventHandler(chkMecanique_CheckStateChanged);
            cmbEmployé = new ComboBox();
            txtQte = new TextBox();
            fraRecherche = new GroupBox();
            lvwRecherche = new ListView();
            lvwRecherche.DoubleClick += new EventHandler(lvwRecherche_DoubleClick);
            _lvwRecherche_ColumnHeader_1 = new ColumnHeader();
            _lvwRecherche_ColumnHeader_2 = new ColumnHeader();
            _lvwRecherche_ColumnHeader_3 = new ColumnHeader();
            txtRecherche = new TextBox();
            cmbRecherche = new ComboBox();
            cmdRechercher = new Button();
            cmdRechercher.Click += new EventHandler(cmdRechercher_Click);
            Label5 = new Label();
            Label6 = new Label();
            txtNoItem = new TextBox();
            mskNoProjet = new MaskedTextBox();
            mskNoProjet.TextChanged += new EventHandler(mskNoProjet_TextChanged);
            lblprojet = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            fraAjout.SuspendLayout();
            fraRecherche.SuspendLayout();
            lvwRecherche.SuspendLayout();
            SuspendLayout();
            ToolTip1.Active = true;
            BackColor = System.Drawing.Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = "Retour de matériel";
            ClientSize = new Size(550, 384);
            Location = new Point(3, 22);
            MaximizeBox = false;
            BackgroundImageLayout = ImageLayout.None;
            BackgroundImage = (Image)resources.GetObject("RetourMateriel.BackgroundImage");
            StartPosition = FormStartPosition.CenterScreen;
            Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = true;
            Enabled = true;
            KeyPreview = false;
            MinimizeBox = true;
            Cursor = Cursors.Default;
            RightToLeft = RightToLeft.No;
            ShowInTaskbar = true;
            HelpButton = false;
            WindowState = FormWindowState.Normal;
            Name = "RetourMateriel";
            cmdFermer.TextAlign = ContentAlignment.MiddleCenter;
            cmdFermer.Text = "Fermer";
            cmdFermer.Size = new Size(81, 25);
            cmdFermer.Location = new Point(456, 352);
            cmdFermer.TabIndex = 19;
            cmdFermer.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdFermer.BackColor = SystemColors.Control;
            cmdFermer.CausesValidation = true;
            cmdFermer.Enabled = true;
            cmdFermer.ForeColor = SystemColors.ControlText;
            cmdFermer.Cursor = Cursors.Default;
            cmdFermer.RightToLeft = RightToLeft.No;
            cmdFermer.TabStop = true;
            cmdFermer.Name = "cmdFermer";
            cmdEnregistrer.TextAlign = ContentAlignment.MiddleCenter;
            cmdEnregistrer.Text = "Enregistrer";
            cmdEnregistrer.Size = new Size(81, 25);
            cmdEnregistrer.Location = new Point(368, 352);
            cmdEnregistrer.TabIndex = 18;
            cmdEnregistrer.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdEnregistrer.BackColor = SystemColors.Control;
            cmdEnregistrer.CausesValidation = true;
            cmdEnregistrer.Enabled = true;
            cmdEnregistrer.ForeColor = SystemColors.ControlText;
            cmdEnregistrer.Cursor = Cursors.Default;
            cmdEnregistrer.RightToLeft = RightToLeft.No;
            cmdEnregistrer.TabStop = true;
            cmdEnregistrer.Name = "cmdEnregistrer";
            fraAjout.BackColor = System.Drawing.Color.Black;
            fraAjout.BorderStyle = BorderStyle.None;
            fraAjout.Text = "Frame1";
            fraAjout.Size = new Size(529, 273);
            fraAjout.Location = new Point(8, 72);
            fraAjout.TabIndex = 0;
            fraAjout.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            fraAjout.Enabled = true;
            fraAjout.ForeColor = SystemColors.ControlText;
            fraAjout.Cursor = Cursors.Default;
            fraAjout.RightToLeft = RightToLeft.No;
            fraAjout.Visible = true;
            fraAjout.Name = "fraAjout";
            chkMecanique.BackColor = System.Drawing.Color.Black;
            chkMecanique.Text = "Mécanique";
            chkMecanique.ForeColor = Color.White;
            chkMecanique.Size = new Size(105, 17);
            chkMecanique.Location = new Point(64, 168);
            chkMecanique.TabIndex = 10;
            chkMecanique.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkMecanique.CheckAlign = ContentAlignment.MiddleLeft;
            chkMecanique.FlatStyle = FlatStyle.Standard;
            chkMecanique.CausesValidation = true;
            chkMecanique.Enabled = true;
            chkMecanique.Cursor = Cursors.Default;
            chkMecanique.RightToLeft = RightToLeft.No;
            chkMecanique.Appearance = Appearance.Normal;
            chkMecanique.TabStop = true;
            chkMecanique.CheckState = CheckState.Unchecked;
            chkMecanique.Visible = true;
            chkMecanique.Name = "chkMecanique";
            cmbEmployé.Size = new Size(145, 21);
            cmbEmployé.Location = new Point(64, 16);
            cmbEmployé.Sorted = true;
            cmbEmployé.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployé.TabIndex = 2;
            cmbEmployé.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEmployé.BackColor = SystemColors.Window;
            cmbEmployé.CausesValidation = true;
            cmbEmployé.Enabled = true;
            cmbEmployé.ForeColor = SystemColors.WindowText;
            cmbEmployé.IntegralHeight = true;
            cmbEmployé.Cursor = Cursors.Default;
            cmbEmployé.RightToLeft = RightToLeft.No;
            cmbEmployé.TabStop = true;
            cmbEmployé.Visible = true;
            cmbEmployé.Name = "cmbEmployé";
            txtQte.AutoSize = false;
            txtQte.Size = new Size(65, 19);
            txtQte.Location = new Point(88, 112);
            txtQte.TabIndex = 7;
            txtQte.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQte.AcceptsReturn = true;
            txtQte.TextAlign = HorizontalAlignment.Left;
            txtQte.BackColor = SystemColors.Window;
            txtQte.CausesValidation = true;
            txtQte.Enabled = true;
            txtQte.ForeColor = SystemColors.WindowText;
            txtQte.HideSelection = true;
            txtQte.ReadOnly = false;
            txtQte.MaxLength = 0;
            txtQte.Cursor = Cursors.IBeam;
            txtQte.Multiline = false;
            txtQte.RightToLeft = RightToLeft.No;
            txtQte.ScrollBars = ScrollBars.None;
            txtQte.TabStop = true;
            txtQte.Visible = true;
            txtQte.BorderStyle = BorderStyle.Fixed3D;
            txtQte.Name = "txtQte";
            fraRecherche.BackColor = System.Drawing.Color.Black;
            fraRecherche.Text = "Recherche";
            fraRecherche.Font = new Font("Arial", 8.25f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            fraRecherche.ForeColor = Color.White;
            fraRecherche.Size = new Size(353, 209);
            fraRecherche.Location = new Point(176, 56);
            fraRecherche.TabIndex = 11;
            fraRecherche.Enabled = true;
            fraRecherche.RightToLeft = RightToLeft.No;
            fraRecherche.Visible = true;
            fraRecherche.Padding = new Padding(0);
            fraRecherche.Name = "fraRecherche";
            lvwRecherche.Size = new Size(337, 129);
            lvwRecherche.Location = new Point(8, 72);
            lvwRecherche.TabIndex = 17;
            lvwRecherche.View = View.Details;
            lvwRecherche.LabelEdit = false;
            lvwRecherche.LabelWrap = true;
            lvwRecherche.HideSelection = true;
            lvwRecherche.FullRowSelect = true;
            lvwRecherche.GridLines = true;
            lvwRecherche.ForeColor = SystemColors.WindowText;
            lvwRecherche.BackColor = SystemColors.Window;
            lvwRecherche.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvwRecherche.BorderStyle = BorderStyle.Fixed3D;
            lvwRecherche.Name = "lvwRecherche";
            _lvwRecherche_ColumnHeader_1.Text = "No Item";
            _lvwRecherche_ColumnHeader_1.Width = 170;
            _lvwRecherche_ColumnHeader_2.Text = "Description";
            _lvwRecherche_ColumnHeader_2.Width = 170;
            _lvwRecherche_ColumnHeader_3.Text = "Manufacturier";
            _lvwRecherche_ColumnHeader_3.Width = 170;
            txtRecherche.AutoSize = false;
            txtRecherche.Size = new Size(105, 19);
            txtRecherche.Location = new Point(8, 40);
            txtRecherche.TabIndex = 14;
            txtRecherche.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecherche.AcceptsReturn = true;
            txtRecherche.TextAlign = HorizontalAlignment.Left;
            txtRecherche.BackColor = SystemColors.Window;
            txtRecherche.CausesValidation = true;
            txtRecherche.Enabled = true;
            txtRecherche.ForeColor = SystemColors.WindowText;
            txtRecherche.HideSelection = true;
            txtRecherche.ReadOnly = false;
            txtRecherche.MaxLength = 0;
            txtRecherche.Cursor = Cursors.IBeam;
            txtRecherche.Multiline = false;
            txtRecherche.RightToLeft = RightToLeft.No;
            txtRecherche.ScrollBars = ScrollBars.None;
            txtRecherche.TabStop = true;
            txtRecherche.Visible = true;
            txtRecherche.BorderStyle = BorderStyle.Fixed3D;
            txtRecherche.Name = "txtRecherche";
            cmbRecherche.Size = new Size(89, 21);
            cmbRecherche.Location = new Point(144, 40);
            cmbRecherche.Items.AddRange(new object[] { "No. Item", "Description", "Manufacturier" });
            cmbRecherche.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecherche.TabIndex = 15;
            cmbRecherche.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRecherche.BackColor = SystemColors.Window;
            cmbRecherche.CausesValidation = true;
            cmbRecherche.Enabled = true;
            cmbRecherche.ForeColor = SystemColors.WindowText;
            cmbRecherche.IntegralHeight = true;
            cmbRecherche.Cursor = Cursors.Default;
            cmbRecherche.RightToLeft = RightToLeft.No;
            cmbRecherche.TabStop = true;
            cmbRecherche.Visible = true;
            cmbRecherche.Name = "cmbRecherche";
            cmdRechercher.TextAlign = ContentAlignment.MiddleCenter;
            cmdRechercher.Text = "Afficher";
            cmdRechercher.Size = new Size(81, 25);
            cmdRechercher.Location = new Point(264, 40);
            cmdRechercher.TabIndex = 16;
            cmdRechercher.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdRechercher.BackColor = SystemColors.Control;
            cmdRechercher.CausesValidation = true;
            cmdRechercher.Enabled = true;
            cmdRechercher.ForeColor = SystemColors.ControlText;
            cmdRechercher.Cursor = Cursors.Default;
            cmdRechercher.RightToLeft = RightToLeft.No;
            cmdRechercher.TabStop = true;
            cmdRechercher.Name = "cmdRechercher";
            Label5.Text = "Texte à rechercher : ";
            Label5.ForeColor = Color.White;
            Label5.Size = new Size(105, 17);
            Label5.Location = new Point(8, 24);
            Label5.TabIndex = 12;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.TextAlign = ContentAlignment.TopLeft;
            Label5.BackColor = Color.Transparent;
            Label5.Enabled = true;
            Label5.Cursor = Cursors.Default;
            Label5.RightToLeft = RightToLeft.No;
            Label5.UseMnemonic = true;
            Label5.Visible = true;
            Label5.AutoSize = false;
            Label5.BorderStyle = BorderStyle.None;
            Label5.Name = "Label5";
            Label6.Text = "Rechercher dans : ";
            Label6.ForeColor = Color.White;
            Label6.Size = new Size(89, 17);
            Label6.Location = new Point(144, 24);
            Label6.TabIndex = 13;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.TextAlign = ContentAlignment.TopLeft;
            Label6.BackColor = Color.Transparent;
            Label6.Enabled = true;
            Label6.Cursor = Cursors.Default;
            Label6.RightToLeft = RightToLeft.No;
            Label6.UseMnemonic = true;
            Label6.Visible = true;
            Label6.AutoSize = false;
            Label6.BorderStyle = BorderStyle.None;
            Label6.Name = "Label6";
            txtNoItem.AutoSize = false;
            txtNoItem.Size = new Size(89, 19);
            txtNoItem.Location = new Point(64, 80);
            txtNoItem.TabIndex = 5;
            txtNoItem.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoItem.AcceptsReturn = true;
            txtNoItem.TextAlign = HorizontalAlignment.Left;
            txtNoItem.BackColor = SystemColors.Window;
            txtNoItem.CausesValidation = true;
            txtNoItem.Enabled = true;
            txtNoItem.ForeColor = SystemColors.WindowText;
            txtNoItem.HideSelection = true;
            txtNoItem.ReadOnly = false;
            txtNoItem.MaxLength = 0;
            txtNoItem.Cursor = Cursors.IBeam;
            txtNoItem.Multiline = false;
            txtNoItem.RightToLeft = RightToLeft.No;
            txtNoItem.ScrollBars = ScrollBars.None;
            txtNoItem.TabStop = true;
            txtNoItem.Visible = true;
            txtNoItem.BorderStyle = BorderStyle.Fixed3D;
            txtNoItem.Name = "txtNoItem";
            mskNoProjet.AllowPromptAsInput = false;
            mskNoProjet.Size = new Size(81, 17);
            mskNoProjet.Location = new Point(72, 144);
            mskNoProjet.TabIndex = 9;
            mskNoProjet.MaxLength = 8;
            mskNoProjet.Mask = "#####-##";
            mskNoProjet.PromptChar = '_';
            mskNoProjet.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskNoProjet.Name = "mskNoProjet";
            lblprojet.BackColor = System.Drawing.Color.Black;
            lblprojet.Text = "No. Projet :";
            lblprojet.ForeColor = Color.White;
            lblprojet.Size = new Size(57, 17);
            lblprojet.Location = new Point(8, 144);
            lblprojet.TabIndex = 8;
            lblprojet.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprojet.TextAlign = ContentAlignment.TopLeft;
            lblprojet.Enabled = true;
            lblprojet.Cursor = Cursors.Default;
            lblprojet.RightToLeft = RightToLeft.No;
            lblprojet.UseMnemonic = true;
            lblprojet.Visible = true;
            lblprojet.AutoSize = false;
            lblprojet.BorderStyle = BorderStyle.None;
            lblprojet.Name = "lblprojet";
            Label4.Text = "Employé : ";
            Label4.ForeColor = Color.White;
            Label4.Size = new Size(65, 17);
            Label4.Location = new Point(8, 16);
            Label4.TabIndex = 1;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.TextAlign = ContentAlignment.TopLeft;
            Label4.BackColor = Color.Transparent;
            Label4.Enabled = true;
            Label4.Cursor = Cursors.Default;
            Label4.RightToLeft = RightToLeft.No;
            Label4.UseMnemonic = true;
            Label4.Visible = true;
            Label4.AutoSize = false;
            Label4.BorderStyle = BorderStyle.None;
            Label4.Name = "Label4";
            Label3.TextAlign = ContentAlignment.TopCenter;
            Label3.Text = "---->";
            Label3.ForeColor = Color.White;
            Label3.Size = new Size(41, 17);
            Label3.Location = new Point(144, 80);
            Label3.TabIndex = 4;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.BackColor = Color.Transparent;
            Label3.Enabled = true;
            Label3.Cursor = Cursors.Default;
            Label3.RightToLeft = RightToLeft.No;
            Label3.UseMnemonic = true;
            Label3.Visible = true;
            Label3.AutoSize = false;
            Label3.BorderStyle = BorderStyle.None;
            Label3.Name = "Label3";
            Label2.Text = "Qté retournée :";
            Label2.ForeColor = Color.White;
            Label2.Size = new Size(73, 17);
            Label2.Location = new Point(8, 112);
            Label2.TabIndex = 6;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.TextAlign = ContentAlignment.TopLeft;
            Label2.BackColor = Color.Transparent;
            Label2.Enabled = true;
            Label2.Cursor = Cursors.Default;
            Label2.RightToLeft = RightToLeft.No;
            Label2.UseMnemonic = true;
            Label2.Visible = true;
            Label2.AutoSize = false;
            Label2.BorderStyle = BorderStyle.None;
            Label2.Name = "Label2";
            Label1.Text = "No. Item : ";
            Label1.ForeColor = Color.White;
            Label1.Size = new Size(65, 17);
            Label1.Location = new Point(8, 80);
            Label1.TabIndex = 3;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.TextAlign = ContentAlignment.TopLeft;
            Label1.BackColor = Color.Transparent;
            Label1.Enabled = true;
            Label1.Cursor = Cursors.Default;
            Label1.RightToLeft = RightToLeft.No;
            Label1.UseMnemonic = true;
            Label1.Visible = true;
            Label1.AutoSize = false;
            Label1.BorderStyle = BorderStyle.None;
            Label1.Name = "Label1";
            Controls.Add(cmdFermer);
            Controls.Add(cmdEnregistrer);
            Controls.Add(fraAjout);
            fraAjout.Controls.Add(chkMecanique);
            fraAjout.Controls.Add(cmbEmployé);
            fraAjout.Controls.Add(txtQte);
            fraAjout.Controls.Add(fraRecherche);
            fraAjout.Controls.Add(txtNoItem);
            fraAjout.Controls.Add(mskNoProjet);
            fraAjout.Controls.Add(lblprojet);
            fraAjout.Controls.Add(Label4);
            fraAjout.Controls.Add(Label3);
            fraAjout.Controls.Add(Label2);
            fraAjout.Controls.Add(Label1);
            fraRecherche.Controls.Add(lvwRecherche);
            fraRecherche.Controls.Add(txtRecherche);
            fraRecherche.Controls.Add(cmbRecherche);
            fraRecherche.Controls.Add(cmdRechercher);
            fraRecherche.Controls.Add(Label5);
            fraRecherche.Controls.Add(Label6);
            lvwRecherche.Columns.Add(_lvwRecherche_ColumnHeader_1);
            lvwRecherche.Columns.Add(_lvwRecherche_ColumnHeader_2);
            lvwRecherche.Columns.Add(_lvwRecherche_ColumnHeader_3);
            fraAjout.ResumeLayout(false);
            fraRecherche.ResumeLayout(false);
            lvwRecherche.ResumeLayout(false);
            Load += new EventHandler(RetourMateriel_Load);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private const int I_CMB_NO_ITEM = 0;
        private const int I_CMB_DESCRIPTION = 1;
        private const int I_CMB_MANUFACTURIER = 2;
        private const int I_LVW_RECHERCHE_NO_ITEM = 0;
        private const int I_LVW_RECHERCHE_DESCRIPTION = 1;
        private const int I_LVW_RECHERCHE_MANUFACTURIER = 2;
        private EnumCatalogue m_eCatalogue;
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
                        if (mskNoProjet.Text != "_____-__" & mskNoProjet.Text != "M_____-__")
                        {
                            if (ProjetExiste() == true)
                            {
                                if (VerifierSortie() == true)
                                {
                                    rstProjet = new Recordset();
                                    if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                                    {
                                        rstProjet.Open("SELECT Modification, Par FROM ProjetElec WHERE IDProjet = '" + mskNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                    }
                                    else
                                    {
                                        rstProjet.Open("SELECT Modification, Par FROM ProjetMec WHERE IDProjet = '" + mskNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                    }
                                    if ((bool)rstProjet.Fields["Modification"].Value == true)
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
                                            rstSortie.Fields["Qté"].Value = "-" + Math.Abs(double.Parse(txtQte.Text));
                                            rstSortie.Fields["Nom"].Value = cmbEmployé.Text;
                                            rstSortie.Fields["NoProjet"].Value = mskNoProjet.Text;
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
                                            rstInv.Fields["QuantitéStock"].Value = double.Parse(rstInv.Fields["QuantitéStock"].Value) + Math.Abs(double.Parse(txtQte.Text));
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
                                            rstHistInv.Fields["IDProjet"].Value = mskNoProjet.Text;
                                            rstHistInv.Fields["NoItem"].Value = txtNoItem.Text;
                                            rstHistInv.Fields["Quantité"].Value = Math.Abs(double.Parse(txtQte.Text));
                                            rstHistInv.Fields["User"].Value = Conteneur.idInitiales.Text;
                                            rstHistInv.Update();
                                            rstHistInv.Close();
                                            rstHistInv = null;
                                            AjouterDansProjet(mskNoProjet.Text, EnumExtra.AUCUN_EXTRA, "");
                                            rstProjet.Close();
                                            if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                                            {
                                                if (double.Parse(Droite(mskNoProjet.Text, 2)) >= 61d & double.Parse(Droite(mskNoProjet.Text, 2)) <= 80d)
                                                {
                                                    rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + mskNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                                    AjouterDansProjet((string)(Operators.ConcatenateObject(Gauche(mskNoProjet.Text, Strings.Len(mskNoProjet.Text) - 2), rstProjet.Fields["LiaisonChargeable"].Value)), EnumExtra.EXTRA_CHARGEABLE, Droite(mskNoProjet.Text, 2));
                                                    rstProjet.Close();
                                                }
                                                else if (double.Parse(Droite(mskNoProjet.Text, 2)) >= 81d & double.Parse(Droite(mskNoProjet.Text, 2)) <= 98d)
                                                {
                                                    AjouterDansProjet(Gauche(mskNoProjet.Text, Strings.Len(mskNoProjet.Text) - 2) + Droite("0" + (double.Parse(Droite(mskNoProjet.Text, 2)) - 80d), 2), EnumExtra.EXTRA_NON_CHARGEABLE, "");
                                                }
                                            }
                                            else if (double.Parse(Droite(mskNoProjet.Text, 2)) >= 61d & double.Parse(Droite(mskNoProjet.Text, 2)) <= 80d)
                                            {
                                                rstProjet.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + mskNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                                AjouterDansProjet((string)(Operators.ConcatenateObject(Gauche(mskNoProjet.Text, Strings.Len(mskNoProjet.Text) - 2), rstProjet.Fields["LiaisonChargeable"].Value)), EnumExtra.EXTRA_CHARGEABLE, Droite(mskNoProjet.Text, 2));
                                                rstProjet.Close();
                                            }
                                            else if (double.Parse(Droite(mskNoProjet.Text, 2)) >= 81d & double.Parse(Droite(mskNoProjet.Text, 2)) <= 98d)
                                            {
                                                AjouterDansProjet(Gauche(mskNoProjet.Text, Strings.Len(mskNoProjet.Text) - 2) + Droite("0" + (double.Parse(Droite(mskNoProjet.Text, 2)) - 80d), 2), EnumExtra.EXTRA_NON_CHARGEABLE, "");
                                            }
                                            MessageBox.Show("Le retour de matériel a été enregistrée!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                                        MessageBox.Show(Operators.ConcatenateObject(Operators.ConcatenateObject("Ce projet est en modification par ", rstProjet.Fields["Par"].Value), "!"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        rstProjet.Close();
                                    }
                                    rstProjet = null;
                                }
                                else
                                {
                                    MessageBox.Show("Pas assez de pièces ont été sortie pour en retourner " + txtQte.Text + "!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                AfficherErreur("RetourMateriel", "cmdEnregistrer_Click", ex);
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
                AfficherErreur("RetourMateriel", "cmdFermer_Click", ex);
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
                chkMecanique.CheckState = CheckState.Unchecked;
                mskNoProjet.Text = "_____-__";
                var loopTo = (int)(cmbEmployé.Items.Count - 1);
                for (X = 0; X <= loopTo; X++)
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
                AfficherErreur("RetourMateriel", "ViderChamps", ex);
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
                    case I_CMB_DESCRIPTION: { sWhere = "Description like '%"  + txtRecherche.Text + "%'"; break; }
                    case I_CMB_MANUFACTURIER: { sWhere = "Manufacturier like '%"  + txtRecherche.Text + "%'"; break; }
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
                AfficherErreur("RetourMateriel", "RemplirListViewRecherche", ex);
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
                AfficherErreur("RetourMateriel", "cmdRechercher_Click", ex);
            }
        }
        private void RetourMateriel_Load(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RemplirComboEmployes();
                ViderChamps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMateriel", "Form_Load", ex);
            }
        }
        private void RemplirComboProjets()
        {
            try
            {
                ADODB.Recordset rstEmploye;
                rstEmploye = new Recordset();
                rstEmploye.Open("select distinct [IDProjSoum] from [dbo].[ProjSoum]", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstEmploye.EOF)
                {
                    cmbEmployé.Items.Add(rstEmploye.Fields["Employe"].Value);
                    cmbEmployé.Tag = rstEmploye.Fields["NoEmploye"].Value;
                    rstEmploye.MoveNext();
                }
                rstEmploye.Close();
                rstEmploye = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMateriel", "RemplirComboProjets", ex);
            }
        }
        private void RemplirComboEmployes()
        {
            try
            {
                ADODB.Recordset rstEmploye;
                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT * FROM Employés WHERE actif=1", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstEmploye.EOF)
                {
                    cmbEmployé.Items.Add(rstEmploye.Fields["Employe"].Value);
                    cmbEmployé.Tag = rstEmploye.Fields["NoEmploye"].Value;
                    rstEmploye.MoveNext();
                }
                rstEmploye.Close();
                rstEmploye = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMateriel", "RemplirComboProjets", ex);
            }
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
                AfficherErreur("RetourMateriel", "lvwRecherche_DblClick", ex);
            }
        }
        private void mskNoProjet_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (fraAjout.Visible == true)
                {
                    if (Strings.InStr(1, mskNoProjet.Text, "_") == 0)
                    {
                        ProjetExiste();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMateriel", "mskNoProjet_Change", ex);
            }
        }
        private bool ProjetExiste()
        {
            bool ProjetExisteRet = default;
            try
            {
                ADODB.Recordset rstProjSoum;
                if (double.Parse(Droite(mskNoProjet.Text, 2)) >= 51d & double.Parse(Droite(mskNoProjet.Text, 2)) <= 98d)
                {
                    rstProjSoum = new Recordset();
                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + mskNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
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
                AfficherErreur("RetourMateriel", "ProjetExiste", ex); return false;
            }
        }
        private bool VerifierSortie()
        {
            bool VerifierSortieRet = default;
            try
            {
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstSection;
                string sIDSection;
                var dblQteProjet = default(double);
                rstSection = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstSection.Open("SELECT * FROM SoumProjSectionElec WHERE NomSectionFR = 'Externe'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstSection.Open("SELECT * FROM SoumProjSectionMec WHERE NomSectionFR = 'Externe'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                sIDSection = (string)(rstSection.Fields["IDSection"].Value);
                rstSection.Close();
                rstSection = null;
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + mskNoProjet.Text + "' AND IDSection = " + sIDSection + " AND SousSection = 'PAS DE SOUS-SECTION' AND NumItem = '" + Strings.Replace(txtNoItem.Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjet.EOF)
                {
                    while (!rstProjet.EOF)
                    {
                        dblQteProjet = double.Parse(Operators.AddObject(dblQteProjet, rstProjet.Fields["Qté"].Value));
                        rstProjet.MoveNext();
                    }
                    if (dblQteProjet >= Math.Abs(double.Parse(txtQte.Text)))
                    {
                        VerifierSortieRet = true;
                    }
                    else
                    {
                        MessageBox.Show("Il n'y a pas assez de " + txtNoItem.Text + " dans le projet " + mskNoProjet.Text + " pour en enlever " + Math.Abs(double.Parse(txtQte.Text)), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        VerifierSortieRet = false;
                    }
                }
                else
                {
                    MessageBox.Show("La pièce " + txtNoItem.Text + " n'a pas été sortie pour le projet " + mskNoProjet.Text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    VerifierSortieRet = false;
                }
                rstProjet.Close();
                rstProjet = null;
                return VerifierSortieRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMateriel", "VerifierSortie", ex); return false;
            }
        }
        //chkMecanique.CheckStateChanged//
        private void chkMecanique_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sTampon;
                sTampon = mskNoProjet.Text;
                // dépendant si coché mécanique affiche le mask
                if (chkMecanique.Checked)
                {
                    mskNoProjet.Mask = @"\M#####-##";
                    if (Strings.Len(sTampon) == 8)
                    {
                        mskNoProjet.Text = "M" + sTampon;
                    }
                }
                else
                {
                    mskNoProjet.Mask = "#####-##";
                    mskNoProjet.Text = Droite(sTampon, 9);
                }
                if (fraAjout.Visible == true)
                {
                    mskNoProjet.Focus();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMateriel", "chkMecanique_Click", ex);
            }
        }
        public void Afficher(EnumCatalogue eCatalogue)
        {
            try
            {
                m_eCatalogue = eCatalogue;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMateriel", "Afficher", ex);
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
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND IDSection = " + sIDSection +
                    " AND SousSection = 'PAS DE SOUS-SECTION' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
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
                    rstInv.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + Strings.Replace(txtNoItem.Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstInv.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + Strings.Replace(txtNoItem.Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
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
                rstPiece.Fields["Qté"].Value = "-" + Math.Abs(double.Parse(txtQte.Text));
                rstPiece.Fields["Desc_FR"].Value = rstInv.Fields["Description"].Value;
                rstPiece.Fields["Desc_EN"].Value = "";
                rstPiece.Fields["Manufact"].Value = rstInv.Fields["Manufacturier"].Value;
                rstPiece.Fields["Prix_list"].Value = (string)(rstInv.Fields["Prix liste"].Value);
                rstPiece.Fields["Escompte"].Value = (string)(rstInv.Fields["Escompte"].Value);
                rstPiece.Fields["Prix_net"].Value = (string)(rstInv.Fields["Prix net"].Value);
                rstPiece.Fields["OrdreSection"].Value = sOrdre;
                rstPiece.Fields["NuméroLigne"].Value = X;
                rstPiece.Fields["IDFRS"].Value = 717;
                rstPiece.Fields["Prix_Total"].Value = (string)(Operators.MultiplyObject(Operators.MultiplyObject(rstInv.Fields["Prix net"].Value, rstPiece.Fields["Qté"].Value), double.Parse(sProfit)));
                rstPiece.Fields["Profit_argent"].Value = (string)(Operators.SubtractObject(rstPiece.Fields["Prix_Total"].Value, Operators.MultiplyObject(rstInv.Fields["Prix net"].Value, rstPiece.Fields["Qté"].Value)));
                rstPiece.Fields["SousSection"].Value = "PAS DE SOUS-SECTION";
                rstPiece.Fields["PrixOrigine"].Value = Math.Round(double.Parse($"{rstInv.Fields["Prix liste"].Value}".Replace(".", ",")), 2);
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
                AfficherErreur("RetourMateriel", "AjouterDansProjet", ex);
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

                    if (!string.IsNullOrEmpty(Strings.Trim((string)(rstPiece.Fields["Temps_total"].Value))))
                    {

                        dblTempsMec += double.Parse(rstPiece.Fields["Temps_total"].Value);
                    }
                    rstPiece.MoveNext();
                }
                rstProjet.Fields["temp_mec"].Value = Strings.Replace((dblTempsMec / 10d).ToString(), ".", ",");
                rstProjet.Update();
                rstPiece.Close();
                rstPiece = null;
                rstProjet.Close();
                rstProjet = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMateriel", "CalculerTempsMecRecordset", ex);
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

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjet.Fields["SansTemps"].Value, true, false)))
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
                        if (!string.IsNullOrEmpty(Strings.Trim((string)(rstPiece.Fields["Prix_total"].Value))))
                        {
                            dblPrixPieces = double.Parse(Operators.AddObject(dblPrixPieces, rstPiece.Fields["Prix_total"].Value));
                            dblProfit = double.Parse(Operators.AddObject(dblProfit, rstPiece.Fields["Profit_Argent"].Value));
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
                    // Le prix total est le calcul des manuels (Nbre de page * prix par pages * nbre de copies) + (prix des pièces * pourcentage d'imprévus) + total des temps + total de la commission
                    dblGrandTotal = dblPrixTotal + dblCommission;
                    // Format monétaires avec 2 chiffres après la virgule
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
                AfficherErreur("RetourMateriel", "CalculerTotalRecordset", ex);
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
                double dblTotalMachinage;
                double dblTotalCoupe;
                double dblTotalSoudure;
                double dblTotalAssemblage;
                double dblTotalPeinture;
                double dblTotalTest;
                double dblTotalDessin;
                double dblTotalFormation;
                double dblTotalInstallation;
                var dblHebergement = default(double);
                double dblRepas;
                double dblTransport;
                double dblUniteMobile;
                double dblPrixEmballage;
                double dblTotalResteTemps;
                int iNbrePersonne;
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstConfig;
                string sCommission;
                string sImprevue;
                rstConfig = new Recordset();
                rstConfig.Open("SELECT * FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sCommission = (string)(rstConfig.Fields["Commission"].Value);
                sImprevue = (string)(rstConfig.Fields["Imprévus"].Value);
                rstConfig.Close();

                rstConfig = null;
                rstProjet = new Recordset();
                rstPiece = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjet + "' AND Type = 'M'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                // Pour chaque élément 
                while (!rstPiece.EOF)
                {
                    if (!string.IsNullOrEmpty(Strings.Trim((string)(rstPiece.Fields["Prix_total"].Value))))
                    {
                        // On additionne le prix total
                        dblPrixPieces = double.Parse(Operators.SubtractObject(Operators.AddObject(dblPrixPieces, rstPiece.Fields["Prix_total"].Value), rstPiece.Fields["Profit_Argent"].Value));
                        // On additionne le profit
                        dblProfit = double.Parse(Operators.AddObject(dblProfit, rstPiece.Fields["Profit_Argent"].Value));
                    }
                    rstPiece.MoveNext();
                }
                // Total des temps
                dblTotalMachinage = double.Parse(rstProjet.Fields["TempsMachinage"].Value) * double.Parse(rstProjet.Fields["TauxMachinage"].Value);
                dblTotalCoupe = double.Parse(rstProjet.Fields["TempsCoupe"].Value) * double.Parse(rstProjet.Fields["TauxCoupePréparation"].Value);
                dblTotalSoudure = double.Parse(rstProjet.Fields["TempsSoudure"].Value) * double.Parse(rstProjet.Fields["TauxAssemblageSoudure"].Value);
                dblTotalAssemblage = double.Parse(rstProjet.Fields["TempsAssemblage"].Value) * double.Parse(rstProjet.Fields["TauxAssemblageSystèmes"].Value);
                dblTotalPeinture = double.Parse(rstProjet.Fields["TempsPeinture"].Value) * double.Parse(rstProjet.Fields["TauxPeintureFinition"].Value);
                dblTotalTest = double.Parse(rstProjet.Fields["TempsTest"].Value) * double.Parse(rstProjet.Fields["TauxTestsFinaux"].Value);
                dblTotalDessin = double.Parse(rstProjet.Fields["TempsDessin"].Value) * double.Parse(rstProjet.Fields["TauxConceptionDessins"].Value);
                dblTotalFormation = double.Parse(rstProjet.Fields["TempsFormation"].Value) * double.Parse(rstProjet.Fields["TauxFormation"].Value);
                dblTotalInstallation = double.Parse(rstProjet.Fields["TempsInstallation"].Value) * double.Parse(rstProjet.Fields["TauxInstallation"].Value);
                dblTotalTemps = dblTotalMachinage + dblTotalCoupe + dblTotalSoudure + dblTotalAssemblage + dblTotalPeinture + dblTotalTest + dblTotalDessin + dblTotalFormation + dblTotalInstallation;
                if (!(rstProjet.Fields["NbrePersonne"].Value is DBNull))
                {
                    if (!string.IsNullOrEmpty(Strings.Trim((string)(rstProjet.Fields["NbrePersonne"].Value))))
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
                    if (!string.IsNullOrEmpty(Strings.Trim((string)(rstProjet.Fields["NbrePersonne"].Value))))
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
                // Correction d'un bug de Type Incompatible
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
                AfficherErreur("RetourMateriel", "CalculerTotalRecordset", ex);
            }
        }
    }
}