using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal  class ChoixImpressionInventaire : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixImpressionInventaire() : base()
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
        internal static Button cmdAnnuler;
        internal static Button cmdImprimer;
        internal static RadioButton optValeurComptable;
        internal static RadioButton optAjustementInventaire;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdImprimer = new System.Windows.Forms.Button();
            optValeurComptable = new System.Windows.Forms.RadioButton();
            optAjustementInventaire = new System.Windows.Forms.RadioButton();
            SuspendLayout();//cmdAnnuler
            cmdAnnuler.AutoSize = true;
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.Location = new System.Drawing.Point(260, 155);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(65, 26);
            cmdAnnuler.TabIndex = 3;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);//cmdImprimer
            cmdImprimer.AutoSize = true;
            cmdImprimer.BackColor = System.Drawing.Color.Black;
            cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdImprimer.Location = new System.Drawing.Point(189, 155);
            cmdImprimer.Name = "cmdImprimer";
            cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdImprimer.Size = new System.Drawing.Size(65, 26);
            cmdImprimer.TabIndex = 0;
            cmdImprimer.Text = "Imprimer";
            cmdImprimer.UseVisualStyleBackColor = true;
            cmdImprimer.Click += new System.EventHandler(cmdImprimer_Click);//optValeurComptable
            optValeurComptable.AutoSize = true;
            optValeurComptable.BackColor = System.Drawing.Color.Black;
            optValeurComptable.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            optValeurComptable.Location = new System.Drawing.Point(95, 105);
            optValeurComptable.Name = "optValeurComptable";
            optValeurComptable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optValeurComptable.Size = new System.Drawing.Size(120, 18);
            optValeurComptable.TabIndex = 2;
            optValeurComptable.TabStop = true;
            optValeurComptable.Text = "Valeurs comptables";
            optValeurComptable.UseVisualStyleBackColor = true;//optAjustementInventaire
            optAjustementInventaire.AutoSize = true;
            optAjustementInventaire.BackColor = System.Drawing.Color.Black;
            optAjustementInventaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            optAjustementInventaire.Location = new System.Drawing.Point(95, 81);
            optAjustementInventaire.Name = "optAjustementInventaire";
            optAjustementInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optAjustementInventaire.Size = new System.Drawing.Size(148, 18);
            optAjustementInventaire.TabIndex = 1;
            optAjustementInventaire.TabStop = true;
            optAjustementInventaire.Text = "Ajustement de l\'inventaire";
            optAjustementInventaire.UseVisualStyleBackColor = true;//ChoixImpressionInventaire
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(347, 205);
            ControlBox = false;
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdImprimer);
            Controls.Add(optValeurComptable);
            Controls.Add(optAjustementInventaire);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(3, 22);
            Name = "ChoixImpressionInventaire";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
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
           Load += new System.EventHandler(ChoixImpressionInventaire_Load);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        public enum enumImpressionInventaire
        {
            MODE_AJUST_INV = 0,
            MODE_VAL_COMPTABLE = 1
        }
        private Form m_Source;
        private bool m_typeImpressionExel;
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Control m_bAnnuleImpression a ete relocalise dans le module principal
                m_bAnnuleImpression = true;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionInventaire", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Control m_bAnnuleImpression a ete relocalise dans le module principal
                m_bAnnuleImpression = false;
                if (optValeurComptable.Checked == true)
                {
                    // Control m_eTypeImpression a ete relocalise dans le module principal
                    m_eTypeImpression = enumImpressionInventaire.MODE_VAL_COMPTABLE;
                }
                else
                {
                    // Control m_eTypeImpression a ete relocalise dans le module principal
                    m_eTypeImpression = enumImpressionInventaire.MODE_AJUST_INV;
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionInventaire", "cmdImprimer_Click", ex);
            }
        }
        public void Afficher(Form Source)
        {
            try
            {
                m_Source = Source;
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionInventaire", "Afficher", ex);
            }
        }
        private void ChoixImpressionInventaire_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;//Control m_typeImpressionExel a ete relocalise dans le module principal
            if (m_typeImpressionExel)
            {
                cmdImprimer.Text = "Exporter";
            }
            else
            {
                cmdImprimer.Text = "Imprimer";
            }
        }
    }
}