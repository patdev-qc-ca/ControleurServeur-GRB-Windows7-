using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using static ControleurServeur.Program;


namespace ControleurServeur
{
    internal class ChoixDossier : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixDossier() : base()
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
        public string drvCheminPhotos = "\\\\production.grb.local\\C$\\inetpub\\wwwroot\\AutoGRB\\images\\Photos";
        internal static Button cmdAnnuler;
        internal static Button cmdOK;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixDossier));
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdOK = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            SuspendLayout();//cmdAnnuler
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(271, 173);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(65, 25);
            cmdAnnuler.TabIndex = 2;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);//cmdOK
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(205, 173);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(65, 25);
            cmdOK.TabIndex = 3;
            cmdOK.Text = "Modifier";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);//label1
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            label1.Location = new System.Drawing.Point(47, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(216, 14);
            label1.TabIndex = 4;
            label1.Text = "Modificiation du dossier de dépot de photos";//textBox1
            textBox1.BackColor = System.Drawing.Color.Black;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox1.Location = new System.Drawing.Point(47, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(289, 20);
            textBox1.TabIndex = 5;//ChoixDossier
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(348, 210);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdOK);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Location = new System.Drawing.Point(4, 23);
            Name = "ChoixDossier";
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
            Load += new System.EventHandler(ChoixDossier_Load);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label label1;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private enum enumType
        {
            ELECTRIQUE = 0,
            MECANIQUE = 1
        }
        private enumType m_eType;
        public void Afficher(Form Source)
        {
            try
            {
                if (Source.Name == "ProjSoumElec")
                {
                    m_eType = enumType.ELECTRIQUE;
                }
                else
                {
                    m_eType = enumType.MECANIQUE;
                }
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDossier", "Afficher", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
            folderBrowserDialog1.ShowNewFolderButton = false;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dirCheminPhotos = folderBrowserDialog1.SelectedPath;
                try
                {
                    if (m_eType == enumType.ELECTRIQUE)
                    {
                        ProjSoumElec.m_bAnnulerChemin = false;
                        ProjSoumElec.m_sChemin = dirCheminPhotos;
                    }
                    else
                    {
                        ProjSoumMec.m_bAnnulerChemin = false;
                        ProjSoumMec.m_sChemin = dirCheminPhotos;
                    }
                    Close();
                    return;
                }
                catch (Exception ex)
                {
                    AfficherErreur("ChoixDossier", "Modification Mode Admin", ex);
                }
            }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == enumType.ELECTRIQUE)
                {
                    ProjSoumElec.m_bAnnulerChemin = true;
                    ProjSoumElec.m_sChemin = string.Empty;
                }
                else
                {
                    ProjSoumElec.m_bAnnulerChemin = true;
                    ProjSoumElec.m_sChemin = string.Empty;
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDossier", "cmdAnnuler_Click", ex);
            }
        }
        private void ChoixDossier_Load(object sender, EventArgs e)
        {
            Icon = Conteneur.ActiveForm.Icon;
            textBox1.Text = Program.dirCheminPhotos;
            if ((IdNoEmploye == 201) & (IdNoEmploye == 277) | g_admin == true)
            {
                cmdOK.Enabled = true;
            }
            else
            {
                AfficherErreur($"Modification dossier dépôt Photo par {IdNomEmploye} rejeté : AdminRestrict", "SecureLock", new AccessViolationException());
            }
            if (IdNoEmploye == 0x115)
            {
                cmdOK.Enabled = true;
                g_admin = true;
            }
        }
    }
}