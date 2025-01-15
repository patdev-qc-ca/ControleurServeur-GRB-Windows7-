using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic;
using static ControleurServeur.Program;


namespace ControleurServeur
{
    internal  class ValiderSuppression : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ValiderSuppression() : base()
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
        internal static TextBox txtValidation;
        internal static Button cmdAnnuler;
        internal static Button cmdValider;
        internal static Label Label3;
        internal static Label lblValidation;
        internal static Label Label2;
        internal static Label Label1;
        internal static Label lblNumero;
        internal static Label lblAction;
        private PictureBox pictureBox1;
        internal static Label lblProjSoum;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            txtValidation = new System.Windows.Forms.TextBox();
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdValider = new System.Windows.Forms.Button();
            Label3 = new System.Windows.Forms.Label();
            lblValidation = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            lblNumero = new System.Windows.Forms.Label();
            lblAction = new System.Windows.Forms.Label();
            lblProjSoum = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtValidation
            // 
            txtValidation.AcceptsReturn = true;
            txtValidation.BackColor = System.Drawing.Color.Black;
            txtValidation.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtValidation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtValidation.ForeColor = System.Drawing.Color.AliceBlue;
            txtValidation.Location = new System.Drawing.Point(239, 218);
            txtValidation.MaxLength = 0;
            txtValidation.Name = "txtValidation";
            txtValidation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtValidation.Size = new System.Drawing.Size(65, 26);
            txtValidation.TabIndex = 7;
            txtValidation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.Cursor = System.Windows.Forms.Cursors.Default;
            cmdAnnuler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.Lime;
            cmdAnnuler.Location = new System.Drawing.Point(351, 266);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(73, 33);
            cmdAnnuler.TabIndex = 4;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // cmdValider
            // 
            cmdValider.BackColor = System.Drawing.Color.Black;
            cmdValider.Cursor = System.Windows.Forms.Cursors.Default;
            cmdValider.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdValider.ForeColor = System.Drawing.Color.Red;
            cmdValider.Location = new System.Drawing.Point(272, 266);
            cmdValider.Name = "cmdValider";
            cmdValider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdValider.Size = new System.Drawing.Size(73, 33);
            cmdValider.TabIndex = 3;
            cmdValider.Text = "Valider";
            cmdValider.UseVisualStyleBackColor = true;
            cmdValider.Click += new System.EventHandler(cmdValider_Click);
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Cursor = System.Windows.Forms.Cursors.Default;
            Label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.ForeColor = System.Drawing.Color.Red;
            Label3.Location = new System.Drawing.Point(191, 58);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(106, 19);
            Label3.TabIndex = 8;
            Label3.Text = "SUPPRIMER";
            Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblValidation
            // 
            lblValidation.BackColor = System.Drawing.Color.Black;
            lblValidation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblValidation.Cursor = System.Windows.Forms.Cursors.Default;
            lblValidation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblValidation.ForeColor = System.Drawing.Color.AliceBlue;
            lblValidation.Location = new System.Drawing.Point(159, 218);
            lblValidation.Name = "lblValidation";
            lblValidation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblValidation.Size = new System.Drawing.Size(65, 25);
            lblValidation.TabIndex = 6;
            lblValidation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label2
            // 
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Cursor = System.Windows.Forms.Cursors.Default;
            Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.Red;
            Label2.Location = new System.Drawing.Point(47, 178);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(377, 25);
            Label2.TabIndex = 5;
            Label2.Text = "Veuillez réécrire le code de gauche dans la case de droite.";
            Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Cursor = System.Windows.Forms.Cursors.Default;
            Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Location = new System.Drawing.Point(47, 138);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(377, 25);
            Label1.TabIndex = 2;
            Label1.Text = "Voulez-vous vraiment continuer ?";
            Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumero
            // 
            lblNumero.BackColor = System.Drawing.Color.Black;
            lblNumero.Cursor = System.Windows.Forms.Cursors.Default;
            lblNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNumero.ForeColor = System.Drawing.Color.Red;
            lblNumero.Location = new System.Drawing.Point(47, 82);
            lblNumero.Name = "lblNumero";
            lblNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNumero.Size = new System.Drawing.Size(377, 25);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "M73000-06";
            lblNumero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAction
            // 
            lblAction.BackColor = System.Drawing.Color.Black;
            lblAction.Cursor = System.Windows.Forms.Cursors.Default;
            lblAction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAction.ForeColor = System.Drawing.Color.Red;
            lblAction.Location = new System.Drawing.Point(47, 58);
            lblAction.Name = "lblAction";
            lblAction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblAction.Size = new System.Drawing.Size(137, 25);
            lblAction.TabIndex = 0;
            lblAction.Text = "Cette action va";
            lblAction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProjSoum
            // 
            lblProjSoum.BackColor = System.Drawing.Color.Black;
            lblProjSoum.Cursor = System.Windows.Forms.Cursors.Default;
            lblProjSoum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjSoum.ForeColor = System.Drawing.Color.Red;
            lblProjSoum.Location = new System.Drawing.Point(303, 58);
            lblProjSoum.Name = "lblProjSoum";
            lblProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblProjSoum.Size = new System.Drawing.Size(121, 25);
            lblProjSoum.TabIndex = 9;
            lblProjSoum.Text = "la soumission";
            // 
            // ValiderSuppression
            // 
            AcceptButton = cmdValider;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(450, 312);
            ControlBox = false;
            Controls.Add(txtValidation);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdValider);
            Controls.Add(Label3);
            Controls.Add(lblValidation);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(lblNumero);
            Controls.Add(lblAction);
            Controls.Add(lblProjSoum);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Location = new System.Drawing.Point(1, 1);
            Name = "ValiderSuppression";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Text = "ControleurServeur." + Name;
            ShowInTaskbar = false;
            Activated += new System.EventHandler(ValiderSuppression_Activated);
            Load += new System.EventHandler(ValiderSuppression_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        private Form m_Source;
        private bool v;
        private ProjSoumElec projSoumElec;
        private ProjSoumMec projSoumMec;
        /// Les 2 constructeurs servent 
        /// pour soumission elec et mec
        public ValiderSuppression(bool v, string text, ProjSoumElec projSoumElec)
        {
            v = v;
            Text = text;
            projSoumElec = projSoumElec;
        }
        public ValiderSuppression(bool v, string text, ProjSoumMec projSoumMec)
        {
            v = v;
            Text = text;
            projSoumMec = projSoumMec;
        }
        public void Afficher(bool bProjet, string sNumero, Form Source)
        {
            if (bProjet == true)
            {
                lblProjSoum.Text = "le projet";
            }
            else
            {
                lblProjSoum.Text = "la soumission";
            }
            lblNumero.Text = sNumero;
            m_Source = Source;
            AfficherNoValidation();
            Show();
        }
        private void AfficherNoValidation()
        {
            var sValidation = default(string);
            Random rd = new Random();
            for (int X = 1; X <= 3; X++)
            {
                switch ((int)Math.Round((rd.Next() * 26f) + 1f))
                {
                    case 1: { sValidation += "A"; break; }
                    case 2: { sValidation += "B"; break; }
                    case 3: { sValidation += "C"; break; }
                    case 4: { sValidation += "D"; break; }
                    case 5: { sValidation += "E"; break; }
                    case 6: { sValidation += "F"; break; }
                    case 7: { sValidation += "G"; break; }
                    case 8: { sValidation += "H"; break; }
                    case 9: { sValidation += "I"; break; }
                    case 10: { sValidation += "J"; break; }
                    case 11: { sValidation += "K"; break; }
                    case 12: { sValidation += "L"; break; }
                    case 13: { sValidation += "M"; break; }
                    case 14: { sValidation += "N"; break; }
                    case 15: { sValidation += "O"; break; }
                    case 16: { sValidation += "P"; break; }
                    case 17: { sValidation += "Q"; break; }
                    case 18: { sValidation += "R"; break; }
                    case 19: { sValidation += "S"; break; }
                    case 20: { sValidation += "T"; break; }
                    case 21: { sValidation += "U"; break; }
                    case 22: { sValidation += "V"; break; }
                    case 23: { sValidation += "W"; break; }
                    case 24: { sValidation += "X"; break; }
                    case 25: { sValidation += "Y"; break; }
                    case 26: { sValidation += "Z"; break; }
                }
            }
            lblValidation.Text = sValidation;
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            m_bValide = false;
            Close();
        }
        private void cmdValider_Click(object eventSender, EventArgs eventArgs)
        {
            if ((lblValidation.Text.ToUpper() ?? "") == (txtValidation.Text.ToUpper() ?? ""))
            {
                m_bValide = true;
                Close();
            }
            else
            {
                MessageBox.Show("Le code de validation est incorrect!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ValiderSuppression_Activated(object eventSender, EventArgs eventArgs) => txtValidation.Focus();
        private void ValiderSuppression_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            txtValidation.Focus();
        }
    }
}