using System;
using System.Windows.Forms;
using ADODB;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal  class ChoixVille : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixVille() : base()
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
        internal static ComboBox cmbVille;
        internal static Button cmdOK;
        internal static Button cmdAnnuler;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmbVille = new System.Windows.Forms.ComboBox();
            cmdOK = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;//cmbVille
            cmbVille.BackColor = System.Drawing.Color.Black;
            cmbVille.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbVille.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbVille.ForeColor = System.Drawing.Color.White;
            cmbVille.Location = new System.Drawing.Point(16, 72);
            cmbVille.Name = "cmbVille";
            cmbVille.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbVille.Size = new System.Drawing.Size(225, 22);
            cmbVille.TabIndex = 1;
            cmbVille.Text = "cmbVille";//cmdOK
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(105, 123);
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
            cmdAnnuler.Location = new System.Drawing.Point(176, 123);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(65, 25);
            cmdAnnuler.TabIndex = 2;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);//ChoixVille
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(259, 160);
            ControlBox = false;
            Controls.Add(cmbVille);
            Controls.Add(cmdOK);
            Controls.Add(cmdAnnuler);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(3, 29);
            Name = "ChoixVille";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            Text = "Sélection de la ville";
            Load += new System.EventHandler(ChoixVille_Load);
            ResumeLayout(false);
        }
        #endregion
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Client.m_bAnnulerVille = true;
                Client.m_sVille = "";
                Close();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixVille", "cmdAnnuler_Click",ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Client.m_bAnnulerVille = false;
                Client.m_sVille = cmbVille.Text;
                Close();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixVille", "cmdOK_Click",ex);
            }
        }
        private void ChoixVille_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                RemplirComboVille();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixVille", "Form_Load",ex);
            }
        }
        private void RemplirComboVille()
        {
            try
            {
                // Remplir le combo des catégories
                ADODB.Recordset rstVille;
                
                cmbVille.Items.Clear();
                rstVille = new Recordset();
                rstVille.Open("SELECT DISTINCT VilleLiv FROM Client ORDER BY VilleLiv", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                
                while (!rstVille.EOF)
                {
                    if (!(rstVille.Fields["VilleLiv"].Value is DBNull))
                    {
if (!string.IsNullOrEmpty(Strings.Trim((string)(rstVille.Fields["VilleLiv"].Value))))
{
    cmbVille.Items.Add(rstVille.Fields["VilleLiv"].Value);
}
                    }
                    rstVille.MoveNext();
                }
                rstVille.Close();
                // Object rstVille peut ne pas etre détruit avant la mise en corbeille
                rstVille = null;
                // Si le combo n'est pas vide, on sélectionne le premier
                if (cmbVille.Items.Count > 0)
                {
                    cmbVille.SelectedIndex = 0;
                }
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixVille", "RemplirComboVille",ex);
            }
        }
    }
}