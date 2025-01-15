using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class ChoixCatalogue : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixCatalogue() : base()
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
        internal static System.Windows.Forms.ToolTip ToolTip1;
        internal static System.Windows.Forms.Button cmdFermer;
        internal static System.Windows.Forms.Button cmdMecanique;
        internal static System.Windows.Forms.Button cmdElectrique;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdFermer = new System.Windows.Forms.Button();
            cmdMecanique = new System.Windows.Forms.Button();
            cmdElectrique = new System.Windows.Forms.Button();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;//cmdFermer
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.White;
            cmdFermer.Location = new System.Drawing.Point(135, 159);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(86, 25);
            cmdFermer.TabIndex = 2;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(cmdFermer_Click);//cmdMecanique
            cmdMecanique.BackColor = System.Drawing.Color.Black;
            cmdMecanique.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdMecanique.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdMecanique.ForeColor = System.Drawing.Color.White;
            cmdMecanique.Location = new System.Drawing.Point(44, 99);
            cmdMecanique.Name = "cmdMecanique";
            cmdMecanique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdMecanique.Size = new System.Drawing.Size(105, 25);
            cmdMecanique.TabIndex = 1;
            cmdMecanique.Text = "Mécanique";
            cmdMecanique.UseVisualStyleBackColor = true;
            cmdMecanique.Click += new System.EventHandler(cmdMecanique_Click);//cmdElectrique
            cmdElectrique.BackColor = System.Drawing.Color.Black;
            cmdElectrique.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdElectrique.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdElectrique.ForeColor = System.Drawing.Color.White;
            cmdElectrique.Location = new System.Drawing.Point(44, 68);
            cmdElectrique.Name = "cmdElectrique";
            cmdElectrique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdElectrique.Size = new System.Drawing.Size(105, 25);
            cmdElectrique.TabIndex = 0;
            cmdElectrique.Text = "Électrique";
            cmdElectrique.UseVisualStyleBackColor = true;
            cmdElectrique.Click += new System.EventHandler(cmdElectrique_Click);//ChoixCatalogue
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(233, 196);
            ControlBox = false;
            Controls.Add(cmdFermer);
            Controls.Add(cmdMecanique);
            Controls.Add(cmdElectrique);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Location = new System.Drawing.Point(3, 22);
            Name = "ChoixCatalogue";
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
            Load += new System.EventHandler(ChoixCatalogue_Load);
            ResumeLayout(false);
        }
        #endregion
        private void cmdElectrique_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Pour ouvrir le catalogue électrique
                Cursor.Current = Cursors.WaitCursor;
                Form f = new CatalogueElec();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCatalogue", "cmdElectrique_Click", ex);
            }
        }
        private void cmdMecanique_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Pour ouvrir le catalogue mécanique
                Cursor.Current = Cursors.WaitCursor;
                Form f = new CatalogueMec();
                f.MdiParent = Conteneur.Mdi;
                f.Show();
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCatalogue", "cmdMecanique_Click", ex);
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
                AfficherErreur("ChoixCatalogue", "cmdFermer_Click", ex);
            }
        }
        private void ChoixCatalogue_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                ActiverBoutonsGroupe();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCatalogue", "Form_Load", ex);
            }
        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
                if (g_bAffichageCatalogueMec == true)
                {
                    cmdMecanique.Enabled = true;
                }
                else
                {
                    cmdMecanique.Enabled = false;
                }
                if (g_bAffichageCatalogueElec == true)
                {
                    cmdElectrique.Enabled = true;
                }
                else
                {
                    cmdElectrique.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCatalogue", "ActiverBoutonsGroupe", ex);
            }
        }
    }
}