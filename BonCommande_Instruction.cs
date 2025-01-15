using System;
using System.Diagnostics;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal  class BonCommande_Instruction : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public BonCommande_Instruction() : base()
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
        internal static TextBox txtPays;
        internal static TextBox txtAdresse;
        internal static TextBox txtCompagnie;
        internal static Label lblPays;
        internal static Label lblAdresse;
        internal static Label lblcompagnie;
        internal static GroupBox fraLabel;
        internal static TextBox txtAssistance;
        internal static TextBox txtEtat;
        internal static Button CmdEnr;
        internal static Button CmdFerme;
        internal static Label lblassistance;
        internal static Label lblEtat;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            fraLabel = new System.Windows.Forms.GroupBox();
            txtPays = new System.Windows.Forms.TextBox();
            txtAdresse = new System.Windows.Forms.TextBox();
            txtCompagnie = new System.Windows.Forms.TextBox();
            lblPays = new System.Windows.Forms.Label();
            lblAdresse = new System.Windows.Forms.Label();
            lblcompagnie = new System.Windows.Forms.Label();
            txtAssistance = new System.Windows.Forms.TextBox();
            txtEtat = new System.Windows.Forms.TextBox();
            CmdEnr = new System.Windows.Forms.Button();
            CmdFerme = new System.Windows.Forms.Button();
            lblassistance = new System.Windows.Forms.Label();
            lblEtat = new System.Windows.Forms.Label();
            fraLabel.SuspendLayout();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;//fraLabel
            fraLabel.BackColor = System.Drawing.Color.Black;
            fraLabel.Controls.Add(txtPays);
            fraLabel.Controls.Add(txtAdresse);
            fraLabel.Controls.Add(txtCompagnie);
            fraLabel.Controls.Add(lblPays);
            fraLabel.Controls.Add(lblAdresse);
            fraLabel.Controls.Add(lblcompagnie);
            fraLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraLabel.ForeColor = System.Drawing.Color.White;
            fraLabel.Location = new System.Drawing.Point(35, 64);
            fraLabel.Name = "fraLabel";
            fraLabel.Padding = new System.Windows.Forms.Padding(0);
            fraLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraLabel.Size = new System.Drawing.Size(377, 113);
            fraLabel.TabIndex = 0;
            fraLabel.TabStop = false;
            fraLabel.Text = "Étiquette";//txtPays
            txtPays.AcceptsReturn = true;
            txtPays.BackColor = System.Drawing.Color.Black;
            txtPays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtPays.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPays.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtPays.ForeColor = System.Drawing.Color.White;
            txtPays.Location = new System.Drawing.Point(96, 80);
            txtPays.MaxLength = 0;
            txtPays.Name = "txtPays";
            txtPays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPays.Size = new System.Drawing.Size(273, 20);
            txtPays.TabIndex = 6;//txtAdresse
            txtAdresse.AcceptsReturn = true;
            txtAdresse.BackColor = System.Drawing.Color.Black;
            txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAdresse.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtAdresse.ForeColor = System.Drawing.Color.White;
            txtAdresse.Location = new System.Drawing.Point(96, 56);
            txtAdresse.MaxLength = 0;
            txtAdresse.Name = "txtAdresse";
            txtAdresse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAdresse.Size = new System.Drawing.Size(273, 20);
            txtAdresse.TabIndex = 4;//txtCompagnie
            txtCompagnie.AcceptsReturn = true;
            txtCompagnie.BackColor = System.Drawing.Color.Black;
            txtCompagnie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtCompagnie.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCompagnie.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCompagnie.ForeColor = System.Drawing.Color.White;
            txtCompagnie.Location = new System.Drawing.Point(96, 32);
            txtCompagnie.MaxLength = 0;
            txtCompagnie.Name = "txtCompagnie";
            txtCompagnie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCompagnie.Size = new System.Drawing.Size(273, 20);
            txtCompagnie.TabIndex = 1;//lblPays
            lblPays.AutoSize = true;
            lblPays.BackColor = System.Drawing.Color.Black;
            lblPays.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPays.ForeColor = System.Drawing.Color.White;
            lblPays.Location = new System.Drawing.Point(8, 80);
            lblPays.Name = "lblPays";
            lblPays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPays.Size = new System.Drawing.Size(31, 14);
            lblPays.TabIndex = 5;
            lblPays.Text = "Pays";//lblAdresse
            lblAdresse.AutoSize = true;
            lblAdresse.BackColor = System.Drawing.Color.Black;
            lblAdresse.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAdresse.ForeColor = System.Drawing.Color.White;
            lblAdresse.Location = new System.Drawing.Point(8, 56);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblAdresse.Size = new System.Drawing.Size(49, 14);
            lblAdresse.TabIndex = 3;
            lblAdresse.Text = "Adresse";//lblcompagnie
            lblcompagnie.AutoSize = true;
            lblcompagnie.BackColor = System.Drawing.Color.Black;
            lblcompagnie.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblcompagnie.ForeColor = System.Drawing.Color.White;
            lblcompagnie.Location = new System.Drawing.Point(8, 32);
            lblcompagnie.Name = "lblcompagnie";
            lblcompagnie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblcompagnie.Size = new System.Drawing.Size(60, 14);
            lblcompagnie.TabIndex = 2;
            lblcompagnie.Text = "Compagnie";//txtAssistance
            txtAssistance.AcceptsReturn = true;
            txtAssistance.BackColor = System.Drawing.Color.Black;
            txtAssistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtAssistance.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAssistance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtAssistance.ForeColor = System.Drawing.Color.White;
            txtAssistance.Location = new System.Drawing.Point(131, 216);
            txtAssistance.MaxLength = 0;
            txtAssistance.Name = "txtAssistance";
            txtAssistance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAssistance.Size = new System.Drawing.Size(273, 20);
            txtAssistance.TabIndex = 9;//txtEtat
            txtEtat.AcceptsReturn = true;
            txtEtat.BackColor = System.Drawing.Color.Black;
            txtEtat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtEtat.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtEtat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtEtat.ForeColor = System.Drawing.Color.White;
            txtEtat.Location = new System.Drawing.Point(131, 192);
            txtEtat.MaxLength = 0;
            txtEtat.Name = "txtEtat";
            txtEtat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtEtat.Size = new System.Drawing.Size(113, 20);
            txtEtat.TabIndex = 7;//CmdEnr
            CmdEnr.BackColor = System.Drawing.Color.Black;
            CmdEnr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdEnr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdEnr.ForeColor = System.Drawing.Color.White;
            CmdEnr.Location = new System.Drawing.Point(211, 256);
            CmdEnr.Name = "CmdEnr";
            CmdEnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdEnr.Size = new System.Drawing.Size(97, 33);
            CmdEnr.TabIndex = 11;
            CmdEnr.Text = "&Enregistrer";
            CmdEnr.UseVisualStyleBackColor = true;
            CmdEnr.Click += new System.EventHandler(CmdEnr_Click);//CmdFerme
            CmdFerme.BackColor = System.Drawing.Color.Black;
            CmdFerme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdFerme.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdFerme.ForeColor = System.Drawing.Color.White;
            CmdFerme.Location = new System.Drawing.Point(315, 256);
            CmdFerme.Name = "CmdFerme";
            CmdFerme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdFerme.Size = new System.Drawing.Size(97, 33);
            CmdFerme.TabIndex = 12;
            CmdFerme.Text = "&Fermer";
            CmdFerme.UseVisualStyleBackColor = true;
            CmdFerme.Click += new System.EventHandler(CmdFerme_Click);//lblassistance
            lblassistance.AutoSize = true;
            lblassistance.BackColor = System.Drawing.Color.Black;
            lblassistance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblassistance.ForeColor = System.Drawing.Color.White;
            lblassistance.Location = new System.Drawing.Point(63, 218);
            lblassistance.Name = "lblassistance";
            lblassistance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblassistance.Size = new System.Drawing.Size(62, 14);
            lblassistance.TabIndex = 10;
            lblassistance.Text = "Assistance";//lblEtat
            lblEtat.AutoSize = true;
            lblEtat.BackColor = System.Drawing.Color.Black;
            lblEtat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEtat.ForeColor = System.Drawing.Color.White;
            lblEtat.Location = new System.Drawing.Point(63, 194);
            lblEtat.Name = "lblEtat";
            lblEtat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblEtat.Size = new System.Drawing.Size(25, 14);
            lblEtat.TabIndex = 8;
            lblEtat.Text = "État";//BonCommande_Instruction
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(440, 313);
            ControlBox = false;
            Controls.Add(fraLabel);
            Controls.Add(txtAssistance);
            Controls.Add(txtEtat);
            Controls.Add(CmdEnr);
            Controls.Add(CmdFerme);
            Controls.Add(lblassistance);
            Controls.Add(lblEtat);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Location = new System.Drawing.Point(3, 22);
            Name = "BonCommande_Instruction";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = true;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Text = "ControleurServeur." + Name;
            ShowInTaskbar = false;
            Text = "Bon Commande - Configuration Instruction";
            Load += new System.EventHandler(BonCommande_Instruction_Load);
            fraLabel.ResumeLayout(false);
            fraLabel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private void CmdEnr_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {

                // Enregistrement d'une modif

                ADODB.Recordset rstConfig;
                if (!string.IsNullOrEmpty(txtCompagnie.Text) & !string.IsNullOrEmpty(txtAdresse.Text) & !string.IsNullOrEmpty(txtEtat.Text) & !string.IsNullOrEmpty(txtAssistance.Text))
                {
                    rstConfig = new Recordset();
                    rstConfig.Open("SELECT * FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    // enreg les donnees
                    rstConfig.Fields["parcel_label_line1"].Value = txtCompagnie.Text;
                    rstConfig.Fields["parcel_label_line2"].Value = txtAdresse.Text;
                    rstConfig.Fields["parcel_label_line3"].Value = txtPays.Text;
                    rstConfig.Fields["parcelassist"].Value = txtAssistance.Text;
                    rstConfig.Fields["parceletat"].Value = txtEtat.Text;
                    rstConfig.Update();
                    // ferme table
                    rstConfig.Close();
                    
                    rstConfig = null;
                }
                else
                {
                    MessageBox.Show("Champs vides!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("BonCommande_Instruction", "CmdEnr_Click",ex);
            }
        }
        private void CmdFerme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // quitte le form
                Close();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("BonCommande_Instruction", "CmdFerme_Click",ex);
            }
        }
        private void AfficherDonnees()
        {
            try
            {

                // Affiche les données pour le rapport bon commande instruction

                ADODB.Recordset rstConfig;
                rstConfig = new Recordset();
                rstConfig.Open("SELECT * FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                // met les donnees dans les controls
                txtCompagnie.Text =(string)(rstConfig.Fields["parcel_label_line1"].Value);
                txtAdresse.Text =(string)(rstConfig.Fields["parcel_label_line2"].Value);
                txtPays.Text =(string)(rstConfig.Fields["parcel_label_line3"].Value);
                txtAssistance.Text =(string)(rstConfig.Fields["parcelassist"].Value);
                txtEtat.Text =(string)(rstConfig.Fields["parceletat"].Value);
                // ferme table
                rstConfig.Close();
                
                rstConfig = null;
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("BonCommande_Instruction", "AfficherDonnees",ex);
            }
        }
        private void BonCommande_Instruction_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                // affichage en mode visualisation
                AfficherDonnees();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("BonCommande_Instruction", "Form_Load",ex);
            }
        }
    }
}