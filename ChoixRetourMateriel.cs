using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal  class ChoixRetourMateriel : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixRetourMateriel() : base()
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
        internal static Button cmdFermer;
        internal static Button cmdMecanique;
        internal static Button cmdElectrique;
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
            cmdFermer.Location = new System.Drawing.Point(126, 174);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(80, 25);
            cmdFermer.TabIndex = 2;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(cmdFermer_Click);//cmdMecanique
            cmdMecanique.BackColor = System.Drawing.Color.Black;
            cmdMecanique.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdMecanique.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdMecanique.ForeColor = System.Drawing.Color.White;
            cmdMecanique.Location = new System.Drawing.Point(39, 116);
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
            cmdElectrique.Location = new System.Drawing.Point(39, 84);
            cmdElectrique.Name = "cmdElectrique";
            cmdElectrique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdElectrique.Size = new System.Drawing.Size(105, 25);
            cmdElectrique.TabIndex = 0;
            cmdElectrique.Text = "Électrique";
            cmdElectrique.UseVisualStyleBackColor = true;
            cmdElectrique.Click += new System.EventHandler(cmdElectrique_Click);//ChoixRetourMateriel
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(218, 211);
            ControlBox = false;
            Controls.Add(cmdFermer);
            Controls.Add(cmdMecanique);
            Controls.Add(cmdElectrique);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(3, 22);
            Name = "ChoixRetourMateriel";
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
            Load += new System.EventHandler(ChoixRetourMateriel_Load);
            ResumeLayout(false);
        }
        #endregion
        private void cmdElectrique_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Pour ouvrir le catalogue électrique
                Cursor.Current = Cursors.WaitCursor;
                Form F = new RetourMarchandise(EnumCatalogue.ELECTRIQUE);
                F.MdiParent = Conteneur.ActiveForm.MdiParent;
                F.ShowDialog();
                Close();
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixRetourMateriel", "cmdElectrique_Click",ex);
            }
        }
        private void cmdMecanique_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Pour ouvrir le catalogue mécanique
                Cursor.Current = Cursors.WaitCursor;
                Form F = new RetourMarchandise(EnumCatalogue.MECANIQUE);
                F.MdiParent = Conteneur.ActiveForm.MdiParent;
                F.ShowDialog();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixRetourMateriel", "cmdMecanique_Click",ex);
            }
        }
        private void cmdFermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixRetourMateriel", "cmdFermer_Click",ex);
            }
        }
        private void ChoixRetourMateriel_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
        }
    }
}