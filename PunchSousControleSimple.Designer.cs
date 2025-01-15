
namespace ControleurServeur
{
    partial class PunchSousControleSimple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PunchSousControleSimple));
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.optHeureDiner1 = new System.Windows.Forms.RadioButton();
            this.optHeureDiner0 = new System.Windows.Forms.RadioButton();
            this.chkDiner = new System.Windows.Forms.CheckBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.chkKM = new System.Windows.Forms.CheckBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.txtCommentaires = new System.Windows.Forms.TextBox();
            this.fraHeure = new System.Windows.Forms.GroupBox();
            this.mskHeure = new System.Windows.Forms.ComboBox();
            this.optHeure1 = new System.Windows.Forms.RadioButton();
            this.optHeure0 = new System.Windows.Forms.RadioButton();
            this.cmbEmploye = new System.Windows.Forms.ComboBox();
            this.picTypePunch = new System.Windows.Forms.GroupBox();
            this.optTypePunch0 = new System.Windows.Forms.RadioButton();
            this.optTypePunch1 = new System.Windows.Forms.RadioButton();
            this.cmdOK = new System.Windows.Forms.Button();
            this.txtEmploye = new System.Windows.Forms.TextBox();
            this.txtNoProjet = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrefixe = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblprojet = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fraHeure.SuspendLayout();
            this.picTypePunch.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.Black;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.White;
            this.cmbType.Location = new System.Drawing.Point(86, 163);
            this.cmbType.Name = "cmbType";
            this.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbType.Size = new System.Drawing.Size(385, 23);
            this.cmbType.TabIndex = 87;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // optHeureDiner1
            // 
            this.optHeureDiner1.AutoSize = true;
            this.optHeureDiner1.BackColor = System.Drawing.Color.Black;
            this.optHeureDiner1.Enabled = false;
            this.optHeureDiner1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHeureDiner1.ForeColor = System.Drawing.Color.White;
            this.optHeureDiner1.Location = new System.Drawing.Point(358, 300);
            this.optHeureDiner1.Name = "optHeureDiner1";
            this.optHeureDiner1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optHeureDiner1.Size = new System.Drawing.Size(66, 19);
            this.optHeureDiner1.TabIndex = 73;
            this.optHeureDiner1.TabStop = true;
            this.optHeureDiner1.Text = "1 heure";
            this.optHeureDiner1.UseVisualStyleBackColor = true;
            this.optHeureDiner1.CheckedChanged += new System.EventHandler(this.optHeureDiner1_CheckedChanged);
            // 
            // optHeureDiner0
            // 
            this.optHeureDiner0.AutoSize = true;
            this.optHeureDiner0.BackColor = System.Drawing.Color.Black;
            this.optHeureDiner0.Checked = true;
            this.optHeureDiner0.Enabled = false;
            this.optHeureDiner0.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHeureDiner0.ForeColor = System.Drawing.Color.White;
            this.optHeureDiner0.Location = new System.Drawing.Point(358, 284);
            this.optHeureDiner0.Name = "optHeureDiner0";
            this.optHeureDiner0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optHeureDiner0.Size = new System.Drawing.Size(86, 19);
            this.optHeureDiner0.TabIndex = 72;
            this.optHeureDiner0.TabStop = true;
            this.optHeureDiner0.Text = "30 minutes";
            this.optHeureDiner0.UseVisualStyleBackColor = true;
            this.optHeureDiner0.CheckedChanged += new System.EventHandler(this.optHeureDiner0_CheckedChanged_1);
            // 
            // chkDiner
            // 
            this.chkDiner.AutoSize = true;
            this.chkDiner.BackColor = System.Drawing.Color.Black;
            this.chkDiner.Checked = true;
            this.chkDiner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiner.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiner.ForeColor = System.Drawing.Color.White;
            this.chkDiner.Location = new System.Drawing.Point(310, 260);
            this.chkDiner.Name = "chkDiner";
            this.chkDiner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDiner.Size = new System.Drawing.Size(105, 19);
            this.chkDiner.TabIndex = 23;
            this.chkDiner.Text = "Heure de dîner";
            this.chkDiner.UseVisualStyleBackColor = true;
            this.chkDiner.CheckedChanged += new System.EventHandler(this.chkDiner_CheckedChanged);
            // 
            // txtKM
            // 
            this.txtKM.AcceptsReturn = true;
            this.txtKM.BackColor = System.Drawing.Color.Black;
            this.txtKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKM.Enabled = false;
            this.txtKM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKM.ForeColor = System.Drawing.Color.Lime;
            this.txtKM.Location = new System.Drawing.Point(398, 236);
            this.txtKM.MaxLength = 0;
            this.txtKM.Name = "txtKM";
            this.txtKM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKM.Size = new System.Drawing.Size(41, 23);
            this.txtKM.TabIndex = 20;
            this.txtKM.TextChanged += new System.EventHandler(this.txtKM_TextChanged);
            // 
            // chkKM
            // 
            this.chkKM.AutoSize = true;
            this.chkKM.BackColor = System.Drawing.Color.Black;
            this.chkKM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKM.ForeColor = System.Drawing.Color.White;
            this.chkKM.Location = new System.Drawing.Point(310, 236);
            this.chkKM.Name = "chkKM";
            this.chkKM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkKM.Size = new System.Drawing.Size(98, 19);
            this.chkKM.TabIndex = 19;
            this.chkKM.Text = "Kilométrage :";
            this.chkKM.UseVisualStyleBackColor = true;
            this.chkKM.CheckedChanged += new System.EventHandler(this.chkKM_CheckedChanged);
            // 
            // txtClient
            // 
            this.txtClient.AcceptsReturn = true;
            this.txtClient.BackColor = System.Drawing.Color.Black;
            this.txtClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClient.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.ForeColor = System.Drawing.Color.Lime;
            this.txtClient.Location = new System.Drawing.Point(87, 134);
            this.txtClient.MaxLength = 0;
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClient.Size = new System.Drawing.Size(385, 23);
            this.txtClient.TabIndex = 18;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.ForeColor = System.Drawing.Color.Navy;
            this.cmdAnnuler.Location = new System.Drawing.Point(446, 460);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(73, 25);
            this.cmdAnnuler.TabIndex = 25;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.AcceptsReturn = true;
            this.txtCommentaires.BackColor = System.Drawing.Color.Black;
            this.txtCommentaires.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCommentaires.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentaires.ForeColor = System.Drawing.Color.Lime;
            this.txtCommentaires.Location = new System.Drawing.Point(31, 366);
            this.txtCommentaires.MaxLength = 0;
            this.txtCommentaires.Multiline = true;
            this.txtCommentaires.Name = "txtCommentaires";
            this.txtCommentaires.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCommentaires.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommentaires.Size = new System.Drawing.Size(475, 56);
            this.txtCommentaires.TabIndex = 24;
            this.txtCommentaires.TextChanged += new System.EventHandler(this.txtCommentaires_TextChanged);
            // 
            // fraHeure
            // 
            this.fraHeure.BackColor = System.Drawing.Color.Black;
            this.fraHeure.Controls.Add(this.mskHeure);
            this.fraHeure.Controls.Add(this.optHeure1);
            this.fraHeure.Controls.Add(this.optHeure0);
            this.fraHeure.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraHeure.ForeColor = System.Drawing.Color.White;
            this.fraHeure.Location = new System.Drawing.Point(87, 236);
            this.fraHeure.Name = "fraHeure";
            this.fraHeure.Padding = new System.Windows.Forms.Padding(0);
            this.fraHeure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraHeure.Size = new System.Drawing.Size(200, 83);
            this.fraHeure.TabIndex = 13;
            this.fraHeure.TabStop = false;
            this.fraHeure.Text = "Heure";
            this.fraHeure.Enter += new System.EventHandler(this.fraHeure_Enter);
            // 
            // mskHeure
            // 
            this.mskHeure.FormattingEnabled = true;
            this.mskHeure.Location = new System.Drawing.Point(28, 38);
            this.mskHeure.Name = "mskHeure";
            this.mskHeure.Size = new System.Drawing.Size(84, 23);
            this.mskHeure.TabIndex = 17;
            this.mskHeure.SelectedIndexChanged += new System.EventHandler(this.mskHeure_SelectedIndexChanged);
            // 
            // optHeure1
            // 
            this.optHeure1.BackColor = System.Drawing.Color.Black;
            this.optHeure1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHeure1.Location = new System.Drawing.Point(7, 40);
            this.optHeure1.Name = "optHeure1";
            this.optHeure1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optHeure1.Size = new System.Drawing.Size(17, 17);
            this.optHeure1.TabIndex = 16;
            this.optHeure1.TabStop = true;
            this.optHeure1.Text = "Système";
            this.optHeure1.UseVisualStyleBackColor = true;
            this.optHeure1.CheckedChanged += new System.EventHandler(this.optHeure1_CheckedChanged);
            // 
            // optHeure0
            // 
            this.optHeure0.AutoSize = true;
            this.optHeure0.BackColor = System.Drawing.Color.Black;
            this.optHeure0.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHeure0.ForeColor = System.Drawing.Color.White;
            this.optHeure0.Location = new System.Drawing.Point(7, 16);
            this.optHeure0.Name = "optHeure0";
            this.optHeure0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optHeure0.Size = new System.Drawing.Size(142, 19);
            this.optHeure0.TabIndex = 14;
            this.optHeure0.TabStop = true;
            this.optHeure0.Text = "Heure de l\'ordinateur";
            this.optHeure0.UseVisualStyleBackColor = true;
            this.optHeure0.CheckedChanged += new System.EventHandler(this.optHeure0_CheckedChanged);
            // 
            // cmbEmploye
            // 
            this.cmbEmploye.BackColor = System.Drawing.Color.Black;
            this.cmbEmploye.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmploye.ForeColor = System.Drawing.Color.Lime;
            this.cmbEmploye.Location = new System.Drawing.Point(273, 18);
            this.cmbEmploye.Name = "cmbEmploye";
            this.cmbEmploye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbEmploye.Size = new System.Drawing.Size(233, 23);
            this.cmbEmploye.TabIndex = 8;
            this.cmbEmploye.Text = "cmbemployé";
            this.cmbEmploye.SelectedIndexChanged += new System.EventHandler(this.cmbEmploye_SelectedIndexChanged);
            // 
            // picTypePunch
            // 
            this.picTypePunch.AutoSize = true;
            this.picTypePunch.BackColor = System.Drawing.Color.Black;
            this.picTypePunch.Controls.Add(this.optTypePunch0);
            this.picTypePunch.Controls.Add(this.optTypePunch1);
            this.picTypePunch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picTypePunch.ForeColor = System.Drawing.Color.White;
            this.picTypePunch.Location = new System.Drawing.Point(273, 47);
            this.picTypePunch.Name = "picTypePunch";
            this.picTypePunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.picTypePunch.Size = new System.Drawing.Size(233, 65);
            this.picTypePunch.TabIndex = 76;
            this.picTypePunch.TabStop = false;
            this.picTypePunch.Enter += new System.EventHandler(this.picTypePunch_Enter);
            // 
            // optTypePunch0
            // 
            this.optTypePunch0.AutoSize = true;
            this.optTypePunch0.BackColor = System.Drawing.Color.Black;
            this.optTypePunch0.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTypePunch0.ForeColor = System.Drawing.Color.White;
            this.optTypePunch0.Location = new System.Drawing.Point(25, 24);
            this.optTypePunch0.Name = "optTypePunch0";
            this.optTypePunch0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optTypePunch0.Size = new System.Drawing.Size(80, 19);
            this.optTypePunch0.TabIndex = 81;
            this.optTypePunch0.TabStop = true;
            this.optTypePunch0.Text = "Électrique";
            this.optTypePunch0.UseVisualStyleBackColor = true;
            this.optTypePunch0.CheckedChanged += new System.EventHandler(this.optTypePunch0_CheckedChanged);
            // 
            // optTypePunch1
            // 
            this.optTypePunch1.AutoSize = true;
            this.optTypePunch1.BackColor = System.Drawing.Color.Black;
            this.optTypePunch1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTypePunch1.ForeColor = System.Drawing.Color.White;
            this.optTypePunch1.Location = new System.Drawing.Point(129, 23);
            this.optTypePunch1.Name = "optTypePunch1";
            this.optTypePunch1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optTypePunch1.Size = new System.Drawing.Size(86, 19);
            this.optTypePunch1.TabIndex = 80;
            this.optTypePunch1.TabStop = true;
            this.optTypePunch1.Text = "Mécanique";
            this.optTypePunch1.UseVisualStyleBackColor = true;
            this.optTypePunch1.CheckedChanged += new System.EventHandler(this.optTypePunch1_CheckedChanged);
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Black;
            this.cmdOK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.Color.Navy;
            this.cmdOK.Location = new System.Drawing.Point(367, 460);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(73, 25);
            this.cmdOK.TabIndex = 26;
            this.cmdOK.Text = "Valider";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txtEmploye
            // 
            this.txtEmploye.AcceptsReturn = true;
            this.txtEmploye.BackColor = System.Drawing.Color.Black;
            this.txtEmploye.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmploye.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploye.ForeColor = System.Drawing.Color.White;
            this.txtEmploye.Location = new System.Drawing.Point(272, 19);
            this.txtEmploye.MaxLength = 0;
            this.txtEmploye.Name = "txtEmploye";
            this.txtEmploye.ReadOnly = true;
            this.txtEmploye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmploye.Size = new System.Drawing.Size(216, 23);
            this.txtEmploye.TabIndex = 9;
            this.txtEmploye.TextChanged += new System.EventHandler(this.txtEmploye_TextChanged);
            // 
            // txtNoProjet
            // 
            this.txtNoProjet.AcceptsReturn = true;
            this.txtNoProjet.BackColor = System.Drawing.Color.Black;
            this.txtNoProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoProjet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoProjet.ForeColor = System.Drawing.Color.Lime;
            this.txtNoProjet.Location = new System.Drawing.Point(162, 61);
            this.txtNoProjet.MaxLength = 0;
            this.txtNoProjet.Name = "txtNoProjet";
            this.txtNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoProjet.Size = new System.Drawing.Size(81, 23);
            this.txtNoProjet.TabIndex = 12;
            this.txtNoProjet.TextChanged += new System.EventHandler(this.txtNoProjet_TextChanged);
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Black;
            this.lblType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(32, 166);
            this.lblType.Name = "lblType";
            this.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblType.Size = new System.Drawing.Size(33, 17);
            this.lblType.TabIndex = 86;
            this.lblType.Text = "Type";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblPrefixe
            // 
            this.lblPrefixe.BackColor = System.Drawing.Color.Black;
            this.lblPrefixe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrefixe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefixe.ForeColor = System.Drawing.Color.White;
            this.lblPrefixe.Location = new System.Drawing.Point(139, 62);
            this.lblPrefixe.Name = "lblPrefixe";
            this.lblPrefixe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrefixe.Size = new System.Drawing.Size(17, 20);
            this.lblPrefixe.TabIndex = 83;
            this.lblPrefixe.Click += new System.EventHandler(this.lblPrefixe_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Black;
            this.Label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(446, 236);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(24, 15);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Km";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(31, 326);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(86, 15);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Commentaires";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblprojet
            // 
            this.lblprojet.AutoSize = true;
            this.lblprojet.BackColor = System.Drawing.Color.Black;
            this.lblprojet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprojet.ForeColor = System.Drawing.Color.White;
            this.lblprojet.Location = new System.Drawing.Point(73, 64);
            this.lblprojet.Name = "lblprojet";
            this.lblprojet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblprojet.Size = new System.Drawing.Size(61, 15);
            this.lblprojet.TabIndex = 10;
            this.lblprojet.Text = "No. Projet";
            this.lblprojet.Click += new System.EventHandler(this.lblprojet_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(209, 18);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(57, 17);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Employé";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(32, 136);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(49, 17);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Client";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(384, 21);
            this.comboBox1.TabIndex = 90;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(432, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 91;
            this.button1.Text = "Utiliser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PunchSousControleSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(531, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.optHeureDiner1);
            this.Controls.Add(this.cmbEmploye);
            this.Controls.Add(this.optHeureDiner0);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.chkDiner);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.lblprojet);
            this.Controls.Add(this.chkKM);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.lblPrefixe);
            this.Controls.Add(this.txtCommentaires);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.fraHeure);
            this.Controls.Add(this.txtNoProjet);
            this.Controls.Add(this.picTypePunch);
            this.Controls.Add(this.txtEmploye);
            this.Controls.Add(this.cmdOK);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PunchSousControleSimple";
            this.Text = "PunchSousControleSimple";
            this.Load += new System.EventHandler(this.PunchSousControleSimple_Load);
            this.fraHeure.ResumeLayout(false);
            this.fraHeure.PerformLayout();
            this.picTypePunch.ResumeLayout(false);
            this.picTypePunch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbType;
        internal System.Windows.Forms.RadioButton optHeureDiner1;
        internal System.Windows.Forms.RadioButton optHeureDiner0;
        internal System.Windows.Forms.CheckBox chkDiner;
        internal System.Windows.Forms.TextBox txtKM;
        internal System.Windows.Forms.CheckBox chkKM;
        internal System.Windows.Forms.TextBox txtClient;
        internal System.Windows.Forms.Button cmdAnnuler;
        internal System.Windows.Forms.TextBox txtCommentaires;
        internal System.Windows.Forms.GroupBox fraHeure;
        internal System.Windows.Forms.RadioButton optHeure1;
        internal System.Windows.Forms.RadioButton optHeure0;
        internal System.Windows.Forms.ComboBox cmbEmploye;
        internal System.Windows.Forms.GroupBox picTypePunch;
        internal System.Windows.Forms.RadioButton optTypePunch0;
        internal System.Windows.Forms.RadioButton optTypePunch1;
        internal System.Windows.Forms.Button cmdOK;
        internal System.Windows.Forms.TextBox txtEmploye;
        internal System.Windows.Forms.TextBox txtNoProjet;
        internal System.Windows.Forms.Label lblType;
        internal System.Windows.Forms.Label lblPrefixe;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblprojet;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ComboBox mskHeure;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}