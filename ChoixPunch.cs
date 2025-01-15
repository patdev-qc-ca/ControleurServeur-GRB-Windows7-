using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal  class ChoixPunch : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixPunch() : base()
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
        internal static Button cmdPunch;
        internal static Button cmdFeuilleTemps;
        internal static Button cmdFacturation;
        internal static Button cmdFermer;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdPunch = new System.Windows.Forms.Button();
            cmdFeuilleTemps = new System.Windows.Forms.Button();
            cmdFacturation = new System.Windows.Forms.Button();
            cmdFermer = new System.Windows.Forms.Button();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;//cmdPunch
            cmdPunch.BackColor = System.Drawing.Color.Black;
            cmdPunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdPunch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdPunch.ForeColor = System.Drawing.Color.White;
            cmdPunch.Location = new System.Drawing.Point(46, 71);
            cmdPunch.Name = "cmdPunch";
            cmdPunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdPunch.Size = new System.Drawing.Size(105, 25);
            cmdPunch.TabIndex = 0;
            cmdPunch.Text = "Punch";
            cmdPunch.UseVisualStyleBackColor = true;
            cmdPunch.Click += new System.EventHandler(cmdPunch_Click);//cmdFeuilleTemps
            cmdFeuilleTemps.BackColor = System.Drawing.Color.Black;
            cmdFeuilleTemps.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdFeuilleTemps.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFeuilleTemps.ForeColor = System.Drawing.Color.White;
            cmdFeuilleTemps.Location = new System.Drawing.Point(46, 103);
            cmdFeuilleTemps.Name = "cmdFeuilleTemps";
            cmdFeuilleTemps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFeuilleTemps.Size = new System.Drawing.Size(105, 25);
            cmdFeuilleTemps.TabIndex = 1;
            cmdFeuilleTemps.Text = "Feuilles de temps";
            cmdFeuilleTemps.UseVisualStyleBackColor = true;
            cmdFeuilleTemps.Click += new System.EventHandler(cmdFeuilleTemps_Click);//cmdFacturation
            cmdFacturation.BackColor = System.Drawing.Color.Black;
            cmdFacturation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdFacturation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFacturation.ForeColor = System.Drawing.Color.White;
            cmdFacturation.Location = new System.Drawing.Point(46, 135);
            cmdFacturation.Name = "cmdFacturation";
            cmdFacturation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFacturation.Size = new System.Drawing.Size(105, 25);
            cmdFacturation.TabIndex = 2;
            cmdFacturation.Text = "Facturation";
            cmdFacturation.UseVisualStyleBackColor = true;
            cmdFacturation.Click += new System.EventHandler(cmdFacturation_Click);//cmdFermer
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.White;
            cmdFermer.Location = new System.Drawing.Point(121, 209);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(85, 25);
            cmdFermer.TabIndex = 3;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(cmdFermer_Click);//ChoixPunch
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(218, 246);
            ControlBox = false;
            Controls.Add(cmdPunch);
            Controls.Add(cmdFeuilleTemps);
            Controls.Add(cmdFacturation);
            Controls.Add(cmdFermer);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "ChoixPunch";
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
            Load += new System.EventHandler(ChoixPunch_Load);
            ResumeLayout(false);
        }
        #endregion
        public string m_sUserID; // Sert pour rechercher le userID de l'employé
        public int m_iNoGroupe;
        private void cmdFeuilleTemps_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Ouverture du form pour l'impression des feuilles de temps
                Cursor.Current = Cursors.WaitCursor;
                Form f =new FeuilleTemps();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                Close();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixPunch", "cmdFeuilleTemps_Click",ex);
            }
        }
        private void cmdFacturation_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Ouverture du form pour la facturation des clients
                Cursor.Current = Cursors.WaitCursor;
                Form F = new Facturation();
                F.MdiParent = Conteneur.ActiveForm.MdiParent;
                F.Show();
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixPunch", "cmdFacturation_Click",ex);
            }
        }
        private void cmdFermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Fermeture de la fenêtre
                Close();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixPunch", "cmdFermer_Click",ex);
            }
        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
                // Activation des boutons d'après le groupe
                // Bouton Punch
                cmdPunch.Enabled = g_bAffichagePunch;
                // Bouton "Facturation"
                cmdFacturation.Enabled = g_bModificationFacturation;
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixPunch", "ActiverBoutonsGroupe",ex);
            }
        }
        private void cmdPunch_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new Punch(IdLoginEmploye);
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixPunch", "cmdPunch_Click",ex);
            }
        }
        private void ChoixPunch_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                // Ouverture de la fenêtre
                ActiverBoutonsGroupe();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixPunch", "Form_Load",ex);
            }
        }
    }
}