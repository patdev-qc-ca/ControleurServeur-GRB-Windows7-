using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal  class ChoixImpressionRetourMarchandise : Form
    {
         #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixImpressionRetourMarchandise() : base()
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
        internal RadioButton optDemande;
        internal RadioButton optRetour;
        internal Button cmdImprimer;
        internal Button cmdAnnuler;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.optDemande = new System.Windows.Forms.RadioButton();
            this.optRetour = new System.Windows.Forms.RadioButton();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optDemande
            // 
            this.optDemande.BackColor = System.Drawing.Color.Black;
            this.optDemande.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDemande.ForeColor = System.Drawing.Color.White;
            this.optDemande.Location = new System.Drawing.Point(76, 91);
            this.optDemande.Name = "optDemande";
            this.optDemande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optDemande.Size = new System.Drawing.Size(193, 17);
            this.optDemande.TabIndex = 1;
            this.optDemande.TabStop = true;
            this.optDemande.Text = "Demande de retour de marchandise";
            this.optDemande.UseVisualStyleBackColor = true;
            // 
            // optRetour
            // 
            this.optRetour.BackColor = System.Drawing.Color.Black;
            this.optRetour.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRetour.ForeColor = System.Drawing.Color.White;
            this.optRetour.Location = new System.Drawing.Point(76, 115);
            this.optRetour.Name = "optRetour";
            this.optRetour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optRetour.Size = new System.Drawing.Size(193, 17);
            this.optRetour.TabIndex = 2;
            this.optRetour.TabStop = true;
            this.optRetour.Text = "Retour de marchandise";
            this.optRetour.UseVisualStyleBackColor = true;
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.BackColor = System.Drawing.Color.Black;
            this.cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimer.ForeColor = System.Drawing.Color.White;
            this.cmdImprimer.Location = new System.Drawing.Point(174, 163);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImprimer.Size = new System.Drawing.Size(65, 25);
            this.cmdImprimer.TabIndex = 0;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.ForeColor = System.Drawing.Color.White;
            this.cmdAnnuler.Location = new System.Drawing.Point(245, 163);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(65, 25);
            this.cmdAnnuler.TabIndex = 3;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // ChoixImpressionRetourMarchandise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(322, 196);
            this.ControlBox = false;
            this.Controls.Add(this.optDemande);
            this.Controls.Add(this.optRetour);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cmdAnnuler);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixImpressionRetourMarchandise";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.ChoixImpressionRetourMarchandise";
            this.ResumeLayout(false);

        }
        #endregion
       public enum enumImpressionRetour
        {
            MODE_DEMANDE_RETOUR = 0,
            MODE_RETOUR = 1
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RetourMarchandise.m_bAnnuleImpression = true;
                Close();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixImpressionRetourMarchandise", "cmdAnnuler_Click",ex);
            }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RetourMarchandise.m_bAnnuleImpression = false;
                if (optRetour.Checked == true)
                {
                    RetourMarchandise.m_eTypeImpression = enumImpressionRetour.MODE_RETOUR;
                }
                else
                {
                    RetourMarchandise.m_eTypeImpression = enumImpressionRetour.MODE_DEMANDE_RETOUR;
                }
                Close();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixImpressionRetourMarchandise", "cmdImprimer_Click",ex);
            }
        }
    }
}