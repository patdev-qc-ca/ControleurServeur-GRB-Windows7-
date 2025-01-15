using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using System.Drawing;
using static ControleurServeur.Program;

namespace ControleurServeur
{
    [DesignerGenerated()]
    internal class SoumissionSectionElec : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public SoumissionSectionElec() : base()
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
        public ToolTip ToolTip1;
        public Button cmdAnnuler;
        public Button cmdOK;
        public TextBox txtAnglais;
        public TextBox txtFrancais;
        public Label Label3;
        public Label Label2;
        public GroupBox fraAjout;
        public Button cmdModifier;
        public ColumnHeader _lvwSection_ColumnHeader_1;
        public ColumnHeader _lvwSection_ColumnHeader_2;
        public ListView lvwSection;
        public Button CmdAdd;
        public Button cmdDown;
        public Button cmdUp;
        public Button CmdFerme;
        public Button CmdSupp;
        public Label _Label1_0;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.Resources.ResourceManager(typeof(SoumissionSectionElec));
            components = new System.ComponentModel.Container();
            ToolTip1 = new ToolTip(components);
            fraAjout = new GroupBox();
            cmdAnnuler = new Button();
            cmdAnnuler.Click += new EventHandler(cmdAnnuler_Click);
            cmdOK = new Button();
            cmdOK.Click += new EventHandler(cmdOK_Click);
            txtAnglais = new TextBox();
            txtFrancais = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            cmdModifier = new Button();
            cmdModifier.Click += new EventHandler(cmdModifier_Click);
            lvwSection = new ListView();
            _lvwSection_ColumnHeader_1 = new ColumnHeader();
            _lvwSection_ColumnHeader_2 = new ColumnHeader();
            CmdAdd = new Button();
            CmdAdd.Click += new EventHandler(CmdAdd_Click);
            cmdDown = new Button();
            cmdDown.Click += new EventHandler(cmdDown_Click);
            cmdUp = new Button();
            cmdUp.Click += new EventHandler(cmdUp_Click);
            CmdFerme = new Button();
            CmdFerme.Click += new EventHandler(CmdFerme_Click);
            CmdSupp = new Button();
            CmdSupp.Click += new EventHandler(CmdSupp_Click);
            _Label1_0 = new Label();
            fraAjout.SuspendLayout();
            lvwSection.SuspendLayout();
            SuspendLayout();
            ToolTip1.Active = true;
            BackColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Text = "Sections électriques";
            ClientSize = new Size(401, 274);
            Location = new Point(3, 22);
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            BackgroundImageLayout = ImageLayout.None;
            BackgroundImage = (Image)resources.GetObject("SoumissionSectionElec.BackgroundImage");
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AutoScaleMode = AutoScaleMode.Font;
            Enabled = true;
            KeyPreview = false;
            Cursor = Cursors.Default;
            RightToLeft = RightToLeft.No;
            HelpButton = false;
            WindowState = FormWindowState.Normal;
            Name = "SoumissionSectionElec";
            fraAjout.BackColor = Color.Black;
            fraAjout.Text = "Ajout de nouvelles sections";
            fraAjout.Font = new Font("Arial", 8.25f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            fraAjout.ForeColor = Color.White;
            fraAjout.Size = new Size(305, 81);
            fraAjout.Location = new Point(16, 120);
            fraAjout.TabIndex = 3;
            fraAjout.Visible = false;
            fraAjout.Enabled = true;
            fraAjout.RightToLeft = RightToLeft.No;
            fraAjout.Padding = new Padding(0);
            fraAjout.Name = "fraAjout";
            cmdAnnuler.TextAlign = ContentAlignment.MiddleCenter;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.Size = new Size(57, 25);
            cmdAnnuler.Location = new Point(232, 16);
            cmdAnnuler.TabIndex = 4;
            cmdAnnuler.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdAnnuler.BackColor = SystemColors.Control;
            cmdAnnuler.CausesValidation = true;
            cmdAnnuler.Enabled = true;
            cmdAnnuler.ForeColor = SystemColors.ControlText;
            cmdAnnuler.Cursor = Cursors.Default;
            cmdAnnuler.RightToLeft = RightToLeft.No;
            cmdAnnuler.TabStop = true;
            cmdAnnuler.Name = "cmdAnnuler";
            cmdOK.TextAlign = ContentAlignment.MiddleCenter;
            cmdOK.Text = "OK";
            cmdOK.Size = new Size(57, 25);
            cmdOK.Location = new Point(232, 48);
            cmdOK.TabIndex = 9;
            cmdOK.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdOK.BackColor = SystemColors.Control;
            cmdOK.CausesValidation = true;
            cmdOK.Enabled = true;
            cmdOK.ForeColor = SystemColors.ControlText;
            cmdOK.Cursor = Cursors.Default;
            cmdOK.RightToLeft = RightToLeft.No;
            cmdOK.TabStop = true;
            cmdOK.Name = "cmdOK";
            txtAnglais.AutoSize = false;
            txtAnglais.Size = new Size(153, 19);
            txtAnglais.Location = new Point(64, 48);
            txtAnglais.TabIndex = 8;
            txtAnglais.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnglais.AcceptsReturn = true;
            txtAnglais.TextAlign = HorizontalAlignment.Left;
            txtAnglais.BackColor = SystemColors.Window;
            txtAnglais.CausesValidation = true;
            txtAnglais.Enabled = true;
            txtAnglais.ForeColor = SystemColors.WindowText;
            txtAnglais.HideSelection = true;
            txtAnglais.ReadOnly = false;
            txtAnglais.MaxLength = 0;
            txtAnglais.Cursor = Cursors.IBeam;
            txtAnglais.Multiline = false;
            txtAnglais.RightToLeft = RightToLeft.No;
            txtAnglais.ScrollBars = ScrollBars.None;
            txtAnglais.TabStop = true;
            txtAnglais.Visible = true;
            txtAnglais.BorderStyle = BorderStyle.Fixed3D;
            txtAnglais.Name = "txtAnglais";
            txtFrancais.AutoSize = false;
            txtFrancais.Size = new Size(153, 19);
            txtFrancais.Location = new Point(64, 24);
            txtFrancais.TabIndex = 6;
            txtFrancais.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFrancais.AcceptsReturn = true;
            txtFrancais.TextAlign = HorizontalAlignment.Left;
            txtFrancais.BackColor = SystemColors.Window;
            txtFrancais.CausesValidation = true;
            txtFrancais.Enabled = true;
            txtFrancais.ForeColor = SystemColors.WindowText;
            txtFrancais.HideSelection = true;
            txtFrancais.ReadOnly = false;
            txtFrancais.MaxLength = 0;
            txtFrancais.Cursor = Cursors.IBeam;
            txtFrancais.Multiline = false;
            txtFrancais.RightToLeft = RightToLeft.No;
            txtFrancais.ScrollBars = ScrollBars.None;
            txtFrancais.TabStop = true;
            txtFrancais.Visible = true;
            txtFrancais.BorderStyle = BorderStyle.Fixed3D;
            txtFrancais.Name = "txtFrancais";
            Label3.Text = "Anglais";
            Label3.ForeColor = Color.White;
            Label3.Size = new Size(41, 17);
            Label3.Location = new Point(16, 48);
            Label3.TabIndex = 7;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.TextAlign = ContentAlignment.TopLeft;
            Label3.BackColor = Color.Transparent;
            Label3.Enabled = true;
            Label3.Cursor = Cursors.Default;
            Label3.RightToLeft = RightToLeft.No;
            Label3.UseMnemonic = true;
            Label3.Visible = true;
            Label3.AutoSize = false;
            Label3.BorderStyle = BorderStyle.None;
            Label3.Name = "Label3";
            Label2.Text = "Français";
            Label2.ForeColor = Color.White;
            Label2.Size = new Size(41, 17);
            Label2.Location = new Point(16, 24);
            Label2.TabIndex = 5;
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
            cmdModifier.TextAlign = ContentAlignment.MiddleCenter;
            cmdModifier.BackColor = SystemColors.Control;
            cmdModifier.Text = "&Modifier";
            cmdModifier.Size = new Size(97, 33);
            cmdModifier.Location = new Point(296, 152);
            cmdModifier.TabIndex = 11;
            cmdModifier.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdModifier.CausesValidation = true;
            cmdModifier.Enabled = true;
            cmdModifier.ForeColor = SystemColors.ControlText;
            cmdModifier.Cursor = Cursors.Default;
            cmdModifier.RightToLeft = RightToLeft.No;
            cmdModifier.TabStop = true;
            cmdModifier.Name = "cmdModifier";
            lvwSection.Size = new Size(241, 193);
            lvwSection.Location = new Point(48, 72);
            lvwSection.TabIndex = 13;
            lvwSection.View = View.Details;
            lvwSection.LabelEdit = false;
            lvwSection.LabelWrap = true;
            lvwSection.HideSelection = true;
            lvwSection.FullRowSelect = true;
            lvwSection.GridLines = true;
            lvwSection.ForeColor = SystemColors.WindowText;
            lvwSection.BackColor = SystemColors.Window;
            lvwSection.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvwSection.BorderStyle = BorderStyle.Fixed3D;
            lvwSection.Name = "lvwSection";
            _lvwSection_ColumnHeader_1.Text = "Français";
            _lvwSection_ColumnHeader_1.Width = 195;
            _lvwSection_ColumnHeader_2.Text = "Anglais";
            _lvwSection_ColumnHeader_2.Width = 195;
            CmdAdd.TextAlign = ContentAlignment.MiddleCenter;
            CmdAdd.BackColor = SystemColors.Control;
            CmdAdd.Text = "&Ajouter";
            CmdAdd.Size = new Size(97, 33);
            CmdAdd.Location = new Point(296, 72);
            CmdAdd.TabIndex = 1;
            CmdAdd.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmdAdd.CausesValidation = true;
            CmdAdd.Enabled = true;
            CmdAdd.ForeColor = SystemColors.ControlText;
            CmdAdd.Cursor = Cursors.Default;
            CmdAdd.RightToLeft = RightToLeft.No;
            CmdAdd.TabStop = true;
            CmdAdd.Name = "CmdAdd";
            cmdDown.TextAlign = ContentAlignment.MiddleCenter;
            cmdDown.Text = "È";
            cmdDown.Font = new Font("Wingdings 3", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 2);
            cmdDown.Size = new Size(33, 33);
            cmdDown.Location = new Point(8, 176);
            cmdDown.TabIndex = 12;
            cmdDown.BackColor = SystemColors.Control;
            cmdDown.CausesValidation = true;
            cmdDown.Enabled = true;
            cmdDown.ForeColor = SystemColors.ControlText;
            cmdDown.Cursor = Cursors.Default;
            cmdDown.RightToLeft = RightToLeft.No;
            cmdDown.TabStop = true;
            cmdDown.Name = "cmdDown";
            cmdUp.TextAlign = ContentAlignment.MiddleCenter;
            cmdUp.Text = "Ç";
            cmdUp.Font = new Font("Wingdings 3", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 2);
            cmdUp.Size = new Size(33, 33);
            cmdUp.Location = new Point(8, 128);
            cmdUp.TabIndex = 10;
            cmdUp.BackColor = SystemColors.Control;
            cmdUp.CausesValidation = true;
            cmdUp.Enabled = true;
            cmdUp.ForeColor = SystemColors.ControlText;
            cmdUp.Cursor = Cursors.Default;
            cmdUp.RightToLeft = RightToLeft.No;
            cmdUp.TabStop = true;
            cmdUp.Name = "cmdUp";
            CmdFerme.TextAlign = ContentAlignment.MiddleCenter;
            CmdFerme.BackColor = SystemColors.Control;
            CmdFerme.Text = "&Fermer";
            CmdFerme.Size = new Size(97, 33);
            CmdFerme.Location = new Point(296, 232);
            CmdFerme.TabIndex = 14;
            CmdFerme.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmdFerme.CausesValidation = true;
            CmdFerme.Enabled = true;
            CmdFerme.ForeColor = SystemColors.ControlText;
            CmdFerme.Cursor = Cursors.Default;
            CmdFerme.RightToLeft = RightToLeft.No;
            CmdFerme.TabStop = true;
            CmdFerme.Name = "CmdFerme";
            CmdSupp.TextAlign = ContentAlignment.MiddleCenter;
            CmdSupp.BackColor = SystemColors.Control;
            CmdSupp.Text = "&Supprimer";
            CmdSupp.Size = new Size(97, 33);
            CmdSupp.Location = new Point(296, 112);
            CmdSupp.TabIndex = 2;
            CmdSupp.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmdSupp.CausesValidation = true;
            CmdSupp.Enabled = true;
            CmdSupp.ForeColor = SystemColors.ControlText;
            CmdSupp.Cursor = Cursors.Default;
            CmdSupp.RightToLeft = RightToLeft.No;
            CmdSupp.TabStop = true;
            CmdSupp.Name = "CmdSupp";
            _Label1_0.BackColor = Color.Black;
            _Label1_0.Text = "Section";
            _Label1_0.Font = new Font("Arial", 8.25f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            _Label1_0.ForeColor = Color.White;
            _Label1_0.Size = new Size(89, 17);
            _Label1_0.Location = new Point(48, 56);
            _Label1_0.TabIndex = 0;
            _Label1_0.TextAlign = ContentAlignment.TopLeft;
            _Label1_0.Enabled = true;
            _Label1_0.Cursor = Cursors.Default;
            _Label1_0.RightToLeft = RightToLeft.No;
            _Label1_0.UseMnemonic = true;
            _Label1_0.Visible = true;
            _Label1_0.AutoSize = false;
            _Label1_0.BorderStyle = BorderStyle.None;
            _Label1_0.Name = "_Label1_0";
            Controls.Add(fraAjout);
            Controls.Add(cmdModifier);
            Controls.Add(lvwSection);
            Controls.Add(CmdAdd);
            Controls.Add(cmdDown);
            Controls.Add(cmdUp);
            Controls.Add(CmdFerme);
            Controls.Add(CmdSupp);
            Controls.Add(_Label1_0);
            fraAjout.Controls.Add(cmdAnnuler);
            fraAjout.Controls.Add(cmdOK);
            fraAjout.Controls.Add(txtAnglais);
            fraAjout.Controls.Add(txtFrancais);
            fraAjout.Controls.Add(Label3);
            fraAjout.Controls.Add(Label2);
            lvwSection.Columns.Add(_lvwSection_ColumnHeader_1);
            lvwSection.Columns.Add(_lvwSection_ColumnHeader_2);
            fraAjout.ResumeLayout(false);
            lvwSection.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private const short I_COL_FRANCAIS = 0;
        private const short I_COL_ANGLAIS = 1;
        private bool m_bAjout;
        private void Sauvegarde()
        {
            ADODB.Recordset rstSection;
            short iCompteur;
            // pour tout les donnée dans lister
            rstSection = new ADODB.Recordset();
            var loopTo = (short)lvwSection.Items.Count;
            for (iCompteur = 1; iCompteur <= loopTo; iCompteur++)
            {
                rstSection.Open(Operators.ConcatenateObject("SELECT NomSectionFR, NomSectionEN, Ordre FROM SoumProjSectionElec WHERE IDSection = ", lvwSection.Items[iCompteur].Tag), odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                rstSection.Fields["Ordre"].Value = iCompteur;
                rstSection.Update();
                rstSection.Close();
            }
            rstSection = null;
            return;
        }
        private void RemplirListViewSection()
        {
            ADODB.Recordset rstSection;
            ListViewItem itmSection;
            rstSection = new ADODB.Recordset();
            rstSection.Open("SELECT * FROM SoumProjSectionElec ORDER BY Ordre", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            lvwSection.Items.Clear();
            while (!rstSection.EOF)
            {
                itmSection = lvwSection.Items.Add(string.Empty);
                itmSection.Tag = rstSection.Fields["IDSection"].Value;
                itmSection.Text = (string)(rstSection.Fields["NomSectionFR"].Value);
                if (!(rstSection.Fields["NomSectionEN"].Value is DBNull))
                {
                    if (itmSection.SubItems.Count > I_COL_ANGLAIS)
                    {
                        itmSection.SubItems[I_COL_ANGLAIS].Text = (string)(rstSection.Fields["NomSectionEN"].Value);
                    }
                    else
                    {
                        itmSection.SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, (string)(rstSection.Fields["NomSectionEN"].Value)));
                    }
                }
                else if (itmSection.SubItems.Count > I_COL_ANGLAIS)
                {
                    itmSection.SubItems[I_COL_ANGLAIS].Text = Constants.vbNullString;
                }
                else
                {
                    itmSection.SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, Constants.vbNullString));
                }
                rstSection.MoveNext();
            }
            rstSection.Close();
            rstSection = null;
            return;
        }
        private void CmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            m_bAjout = true;
            txtAnglais.Text = Constants.vbNullString;
            txtFrancais.Text = Constants.vbNullString;
            fraAjout.Visible = true;
            txtFrancais.Focus();
            return;
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            fraAjout.Visible = false;
            return;
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            ADODB.Recordset rstSection;
            ADODB.Recordset rstMaxOrdre;
            if (string.IsNullOrEmpty(Strings.Trim(txtFrancais.Text)) | string.IsNullOrEmpty(Strings.Trim(txtAnglais.Text)))
            {
                MessageBox.Show("Le nom en français et en anglais est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            rstSection = new ADODB.Recordset();
            if (m_bAjout == true)
            {
                rstSection.Open("SELECT * FROM SoumProjSectionElec WHERE NomSectionFR = '" + Strings.Replace(txtFrancais.Text, "'", "''") + "' OR NomSectionEN = '" + Strings.Replace(txtAnglais.Text, "'", "''") + "'", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                if (rstSection.EOF)
                {
                    rstMaxOrdre = new ADODB.Recordset();
                    rstMaxOrdre.Open("SELECT Max(Ordre) as MaxOrdre FROM SoumProjSectionElec", odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    rstSection.AddNew();
                    rstSection.Fields["NomSectionFR"].Value = txtFrancais.Text;
                    rstSection.Fields["NomSectionEN"].Value = txtAnglais.Text;
                    rstSection.Fields["Ordre"].Value = Operators.AddObject(rstMaxOrdre.Fields["MaxOrdre"].Value, 1);
                    rstMaxOrdre.Close();
                    rstMaxOrdre = null;
                    rstSection.Update();
                    m_bAjout = false;
                }
                else
                {
                    MessageBox.Show("Cette section existe déjà!");
                }
                rstSection.Close();
            }
            else
            {
                rstSection.Open(Operators.ConcatenateObject("SELECT * FROM SoumProjSectionElec WHERE IDSection = ", lvwSection.FocusedItem.Tag), odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                rstSection.Fields["NomSectionFR"].Value = txtFrancais.Text;
                rstSection.Fields["NomSectionEN"].Value = txtAnglais.Text;
                rstSection.Update();
                rstSection.Close();
            }
            rstSection = null;
            RemplirListViewSection();
            fraAjout.Visible = false;
            Cursor.Current = Cursors.Default;
        }
        private void cmdDown_Click(object eventSender, EventArgs eventArgs)
        {
            string sTagAvant;
            string sTagApres;
            string sFrancaisAvant;
            string sFrancaisApres;
            string sAnglaisAvant;
            string sAnglaisApres;
            short iIndex;
            iIndex = (short)lvwSection.FocusedItem.Index;
            if (iIndex < lvwSection.Items.Count)
            {
                sTagAvant = (string)(lvwSection.Items[iIndex].Tag);
                sFrancaisAvant = lvwSection.Items[iIndex].Text;
                sAnglaisAvant = lvwSection.Items[iIndex].SubItems[I_COL_ANGLAIS].Text;
                sTagApres = (string)(lvwSection.Items[iIndex + 1].Tag);
                sFrancaisApres = lvwSection.Items[iIndex + 1].Text;
                sAnglaisApres = lvwSection.Items[iIndex + 1].SubItems[I_COL_ANGLAIS].Text;
                lvwSection.Items[iIndex].Tag = sTagApres;
                lvwSection.Items[iIndex].Text = sFrancaisApres;
                if (lvwSection.Items[iIndex].SubItems.Count > I_COL_ANGLAIS)
                {
                    lvwSection.Items[iIndex].SubItems[I_COL_ANGLAIS].Text = sAnglaisApres;
                }
                else
                {
                    lvwSection.Items[iIndex].SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, sAnglaisApres));
                }
                lvwSection.Items[iIndex + 1].Tag = sTagAvant;
                lvwSection.Items[iIndex + 1].Text = sFrancaisAvant;
                if (lvwSection.Items[iIndex + 1].SubItems.Count > I_COL_ANGLAIS)
                {
                    lvwSection.Items[iIndex + 1].SubItems[I_COL_ANGLAIS].Text = sAnglaisAvant;
                }
                else
                {
                    lvwSection.Items[iIndex + 1].SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, sAnglaisAvant));
                }
                lvwSection.Items[iIndex + 1].Selected = true;
                lvwSection.FocusedItem.EnsureVisible();
            }
            return;
        }
        private void cmdUp_Click(object eventSender, EventArgs eventArgs)
        {
            string sTagAvant;
            string sTagApres;
            string sFrancaisAvant;
            string sFrancaisApres;
            string sAnglaisAvant;
            string sAnglaisApres;
            short iIndex;
            iIndex = (short)lvwSection.FocusedItem.Index;
            if (iIndex > 1)
            {
                sTagAvant = (string)(lvwSection.Items[iIndex].Tag);
                sFrancaisAvant = lvwSection.Items[iIndex].Text;
                sAnglaisAvant = lvwSection.Items[iIndex].SubItems[I_COL_ANGLAIS].Text;
                sTagApres = (string)(lvwSection.Items[iIndex - 1].Tag);
                sFrancaisApres = lvwSection.Items[iIndex - 1].Text;
                sAnglaisApres = lvwSection.Items[iIndex - 1].SubItems[I_COL_ANGLAIS].Text;
                lvwSection.Items[iIndex].Tag = sTagApres;
                lvwSection.Items[iIndex].Text = sFrancaisApres;
                if (lvwSection.Items[iIndex].SubItems.Count > I_COL_ANGLAIS)
                {
                    lvwSection.Items[iIndex].SubItems[I_COL_ANGLAIS].Text = sAnglaisApres;
                }
                else
                {
                    lvwSection.Items[iIndex].SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, sAnglaisApres));
                }
                lvwSection.Items[iIndex - 1].Tag = sTagAvant;
                lvwSection.Items[iIndex - 1].Text = sFrancaisAvant;
                if (lvwSection.Items[iIndex - 1].SubItems.Count > I_COL_ANGLAIS)
                {
                    lvwSection.Items[iIndex - 1].SubItems[I_COL_ANGLAIS].Text = sAnglaisAvant;
                }
                else
                {
                    lvwSection.Items[iIndex - 1].SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, sAnglaisAvant));
                }
                lvwSection.Items[iIndex - 1].Selected = true;
                lvwSection.FocusedItem.EnsureVisible();
            }
            return;
        }
        private void CmdFerme_Click(object eventSender, EventArgs eventArgs)
        {

            Sauvegarde();
            Close();
            return;
        }
        private void cmdModifier_Click(object eventSender, EventArgs eventArgs)
        {
            txtFrancais.Text = lvwSection.FocusedItem.Text;
            txtAnglais.Text = lvwSection.FocusedItem.SubItems[I_COL_ANGLAIS].Text;
            fraAjout.Visible = true;
            return;

        }
        private void CmdSupp_Click(object eventSender, EventArgs eventArgs)
        {

            SupprimerSection();
            return;
        }
        private void SupprimerSection()
        {
            ADODB.Recordset rstSoumission;
            if (lvwSection.Items.Count > 0)
            {
                if (MessageBox.Show("Etes-vous sur de supprimer cette enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    rstSoumission = new ADODB.Recordset();
                    rstSoumission.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT IDSection FROM Soumission_pieces WHERE IDSection = ", lvwSection.FocusedItem.Tag), " AND Type = 'E'"), odbc, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
                    if (rstSoumission.EOF)
                    {
                        UpdateSQL("DELETE * FROM SoumProjSectionElec WHERE IDsection = " + lvwSection.FocusedItem.Tag);
                        if (lvwSection.Items.Count > 0)
                        {
                            lvwSection.Items[1].Selected = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossible de supprimer une section déjà utilisé dans une soumission!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    rstSoumission.Close();
                    rstSoumission = null;
                    RemplirListViewSection();
                }
            }
            else
            {
                MessageBox.Show("Aucun enregistrement sélectionné!");
            }
            Cursor.Current = Cursors.Default;
            return;
        }
        private void SoumissionSectionElec_Load(object eventSender, EventArgs eventArgs) => RemplirListViewSection();
        private void lvwSection_Click(object eventSender, EventArgs eventArgs)
        {
            if (lvwSection.Items.Count > 0)
            {
                if (lvwSection.FocusedItem.Index == lvwSection.Items.Count)
                {
                    cmdDown.Enabled = false;
                }
                else
                {
                    cmdDown.Enabled = true;
                }
                if (lvwSection.FocusedItem.Index == 1)
                {
                    cmdUp.Enabled = false;
                }
                else
                {
                    cmdUp.Enabled = true;
                }
            }
            return;
        }
        private void lvwSection_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            txtFrancais.Text = lvwSection.FocusedItem.Text;

            txtAnglais.Text = lvwSection.FocusedItem.SubItems[I_COL_ANGLAIS].Text;
            fraAjout.Visible = true;
            return;

        }
        private void lvwSection_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            short KeyCode = (short)eventArgs.KeyCode;
            short Shift = (short)((int)eventArgs.KeyData / 0x10000);
            if (KeyCode == (int)Keys.Delete)
            {
                SupprimerSection();
            }
            return;
        }
    }
}