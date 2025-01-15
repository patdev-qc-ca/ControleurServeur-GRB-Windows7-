using System;
using System.Diagnostics;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class ChoixCategorie : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixCategorie() : base()
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
        internal static ComboBox cmbCategorie;
        internal static Button cmdOK;
        internal static Button cmdAnnuler;
        internal static Label Label1;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmbCategorie = new System.Windows.Forms.ComboBox();
            cmdOK = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;
            ToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(ToolTip1_Popup);//cmbCategorie
            cmbCategorie.BackColor = System.Drawing.Color.Black;
            cmbCategorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbCategorie.ForeColor = System.Drawing.Color.White;
            cmbCategorie.Location = new System.Drawing.Point(20, 95);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbCategorie.Size = new System.Drawing.Size(225, 22);
            cmbCategorie.TabIndex = 1;
            cmbCategorie.Text = "cmbCategorie";
            cmbCategorie.SelectedIndexChanged += new System.EventHandler(cmbCategorie_SelectedIndexChanged);//cmdOK
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(107, 154);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(65, 25);
            cmdOK.TabIndex = 3;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);//cmdAnnuler
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(178, 154);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(65, 25);
            cmdAnnuler.TabIndex = 2;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);//Label1
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(20, 63);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(161, 17);
            Label1.TabIndex = 0;
            Label1.Text = "Dans quelle catégorie ?";
            Label1.Click += new System.EventHandler(Label1_Click);//ChoixCategorie
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(257, 202);
            Controls.Add(cmbCategorie);
            Controls.Add(cmdOK);
            Controls.Add(cmdAnnuler);
            Controls.Add(Label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ChoixCategorie";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Text = "ControleurServeur." + Name;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dans quelle catégorie ?";
            Load += new System.EventHandler(ChoixCategorie_Load);
            ResumeLayout(false);
        }
        #endregion
        private EnumCatalogue m_eCatalogue;
        private EnumCatalogue eLECTRIQUE;
        public ChoixCategorie(EnumCatalogue eLECTRIQUE)
        {
            eLECTRIQUE = eLECTRIQUE;
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    m_bAnnulerCopie = true;
                }
                else
                {
                    m_bAnnulerCopie = true;
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCategorie", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    m_bAnnulerCopie = false;
                    m_sCategorieCopie = cmbCategorie.Text;
                }
                else
                {
                    m_bAnnulerCopie = false;
                    m_sCategorieCopie = cmbCategorie.Text;
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCategorie", "cmdOK_Click", ex);
            }
        }
        private void ChoixCategorie_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                RemplirComboCategorie();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCategorie", "Form_Load", ex);
            }
        }
        private void RemplirComboCategorie()
        {
            try
            {
                // Remplir le combo des catégories
                ADODB.Recordset rstCategorie;

                cmbCategorie.Items.Clear();
                rstCategorie = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstCategorie.Open("SELECT DISTINCT CATEGORIE FROM CatalogueElec ORDER BY CATEGORIE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstCategorie.Open("SELECT DISTINCT CATEGORIE FROM CatalogueMec ORDER BY CATEGORIE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }

                while (!rstCategorie.EOF)
                {
                    cmbCategorie.Items.Add(rstCategorie.Fields["CATEGORIE"].Value);
                    rstCategorie.MoveNext();
                }
                rstCategorie.Close();
                rstCategorie = null;
                // Si le combo n'est pas vide, on sélectionne le premier
                if (cmbCategorie.Items.Count > 0)
                {
                    cmbCategorie.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCategorie", "RemplirComboCategorie", ex);
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
                AfficherErreur("ChoixCategorie", "Afficher", ex);
            }
        }
        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }
    }
}