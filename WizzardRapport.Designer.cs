
namespace ControleurServeur
{
    partial class WizzardRapport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizzardRapport));
            this.mskDateLivraison = new System.Windows.Forms.DateTimePicker();
            this.mskDate = new System.Windows.Forms.DateTimePicker();
            this.mskDateCommande = new System.Windows.Forms.DateTimePicker();
            this.mskDateDue = new System.Windows.Forms.DateTimePicker();
            this.cmbFournisseur2 = new System.Windows.Forms.ComboBox();
            this.cmdRechercherFRS2 = new System.Windows.Forms.Button();
            this.ChkFabFermMéca = new System.Windows.Forms.CheckBox();
            this.ChkProg = new System.Windows.Forms.CheckBox();
            this.ChkConcept = new System.Windows.Forms.CheckBox();
            this.ChkFourn = new System.Windows.Forms.CheckBox();
            this.ChkClient = new System.Windows.Forms.CheckBox();
            this.ChkBonTravail = new System.Windows.Forms.CheckBox();
            this.lblObjet = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.fraChoixRapport = new System.Windows.Forms.GroupBox();
            this.chkProblemes = new System.Windows.Forms.CheckBox();
            this.txtObjet = new System.Windows.Forms.TextBox();
            this.cmdMsg = new System.Windows.Forms.Button();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.chkFaxAnglais = new System.Windows.Forms.CheckBox();
            this.chkFaxFrancais = new System.Windows.Forms.CheckBox();
            this.chkBonLivraison = new System.Windows.Forms.CheckBox();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.ChkFinFab = new System.Windows.Forms.CheckBox();
            this.ChkFabFerm = new System.Windows.Forms.CheckBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.cmbContactFRS = new System.Windows.Forms.ComboBox();
            this.cmdRechercherFRS = new System.Windows.Forms.Button();
            this.cmdRechercherClient2 = new System.Windows.Forms.Button();
            this.cmdRechercherClient = new System.Windows.Forms.Button();
            this.txtProjetClient = new System.Windows.Forms.TextBox();
            this.cmdReport = new System.Windows.Forms.Button();
            this.cmbFournisseur = new System.Windows.Forms.ComboBox();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.txtNoCommande = new System.Windows.Forms.TextBox();
            this.txtNoSoumission = new System.Windows.Forms.TextBox();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.cmbGRB = new System.Windows.Forms.ComboBox();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNomProjet = new System.Windows.Forms.TextBox();
            this.txtNoProjet = new System.Windows.Forms.TextBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbClient2 = new System.Windows.Forms.ComboBox();
            this.mskHeureTravaux = new System.Windows.Forms.MaskedTextBox();
            this.lblFournisseur2 = new System.Windows.Forms.Label();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.lblFormatHeurePrevue = new System.Windows.Forms.Label();
            this.lblContactFRS = new System.Windows.Forms.Label();
            this.lblHeureTravaux = new System.Windows.Forms.Label();
            this.lblProjetClient = new System.Windows.Forms.Label();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.lblDateLivraison = new System.Windows.Forms.Label();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblClient2 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateTravaux = new System.Windows.Forms.Label();
            this.lblNomProjet = new System.Windows.Forms.Label();
            this.lblDateCommande = new System.Windows.Forms.Label();
            this.lblNoProjet = new System.Windows.Forms.Label();
            this.lblNoSoumission = new System.Windows.Forms.Label();
            this.lblGRB = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblNoCommande = new System.Windows.Forms.Label();
            this.mskDateTravaux = new System.Windows.Forms.DateTimePicker();
            this.fraChoixRapport.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskDateLivraison
            // 
            this.mskDateLivraison.Location = new System.Drawing.Point(499, 398);
            this.mskDateLivraison.Name = "mskDateLivraison";
            this.mskDateLivraison.Size = new System.Drawing.Size(121, 20);
            this.mskDateLivraison.TabIndex = 118;
            this.mskDateLivraison.ValueChanged += new System.EventHandler(this.mskDateLivraison_ValueChanged);
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(318, 237);
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(159, 20);
            this.mskDate.TabIndex = 117;
            this.mskDate.ValueChanged += new System.EventHandler(this.mskDate_ValueChanged);
            // 
            // mskDateCommande
            // 
            this.mskDateCommande.Location = new System.Drawing.Point(318, 276);
            this.mskDateCommande.Name = "mskDateCommande";
            this.mskDateCommande.Size = new System.Drawing.Size(159, 20);
            this.mskDateCommande.TabIndex = 116;
            this.mskDateCommande.ValueChanged += new System.EventHandler(this.mskDateCommande_ValueChanged);
            // 
            // mskDateDue
            // 
            this.mskDateDue.Location = new System.Drawing.Point(430, 157);
            this.mskDateDue.Name = "mskDateDue";
            this.mskDateDue.Size = new System.Drawing.Size(177, 20);
            this.mskDateDue.TabIndex = 115;
            this.mskDateDue.ValueChanged += new System.EventHandler(this.mskDateDue_ValueChanged);
            // 
            // cmbFournisseur2
            // 
            this.cmbFournisseur2.BackColor = System.Drawing.Color.Black;
            this.cmbFournisseur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFournisseur2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFournisseur2.ForeColor = System.Drawing.Color.White;
            this.cmbFournisseur2.Location = new System.Drawing.Point(315, 524);
            this.cmbFournisseur2.Name = "cmbFournisseur2";
            this.cmbFournisseur2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbFournisseur2.Size = new System.Drawing.Size(273, 22);
            this.cmbFournisseur2.Sorted = true;
            this.cmbFournisseur2.TabIndex = 113;
            this.cmbFournisseur2.SelectedIndexChanged += new System.EventHandler(this.cmbFournisseur2_SelectedIndexChanged);
            // 
            // cmdRechercherFRS2
            // 
            this.cmdRechercherFRS2.BackColor = System.Drawing.Color.Black;
            this.cmdRechercherFRS2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRechercherFRS2.ForeColor = System.Drawing.Color.Navy;
            this.cmdRechercherFRS2.Location = new System.Drawing.Point(595, 524);
            this.cmdRechercherFRS2.Name = "cmdRechercherFRS2";
            this.cmdRechercherFRS2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercherFRS2.Size = new System.Drawing.Size(25, 21);
            this.cmdRechercherFRS2.TabIndex = 112;
            this.cmdRechercherFRS2.Text = "..";
            this.cmdRechercherFRS2.UseVisualStyleBackColor = true;
            this.cmdRechercherFRS2.Click += new System.EventHandler(this.cmdRechercherFRS2_Click);
            // 
            // ChkFabFermMéca
            // 
            this.ChkFabFermMéca.BackColor = System.Drawing.Color.Black;
            this.ChkFabFermMéca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkFabFermMéca.ForeColor = System.Drawing.Color.White;
            this.ChkFabFermMéca.Location = new System.Drawing.Point(16, 168);
            this.ChkFabFermMéca.Name = "ChkFabFermMéca";
            this.ChkFabFermMéca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkFabFermMéca.Size = new System.Drawing.Size(241, 17);
            this.ChkFabFermMéca.TabIndex = 9;
            this.ChkFabFermMéca.Text = "FABRICATION - FERMETURE MÉCANIQUE";
            this.ChkFabFermMéca.UseVisualStyleBackColor = true;
            this.ChkFabFermMéca.CheckedChanged += new System.EventHandler(this.ChkFabFermMéca_CheckedChanged);
            // 
            // ChkProg
            // 
            this.ChkProg.BackColor = System.Drawing.Color.Black;
            this.ChkProg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkProg.ForeColor = System.Drawing.Color.White;
            this.ChkProg.Location = new System.Drawing.Point(16, 144);
            this.ChkProg.Name = "ChkProg";
            this.ChkProg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkProg.Size = new System.Drawing.Size(137, 17);
            this.ChkProg.TabIndex = 8;
            this.ChkProg.Text = "PROGRAMMATION";
            this.ChkProg.UseVisualStyleBackColor = true;
            this.ChkProg.CheckedChanged += new System.EventHandler(this.ChkProg_CheckedChanged);
            // 
            // ChkConcept
            // 
            this.ChkConcept.BackColor = System.Drawing.Color.Black;
            this.ChkConcept.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkConcept.ForeColor = System.Drawing.Color.White;
            this.ChkConcept.Location = new System.Drawing.Point(16, 120);
            this.ChkConcept.Name = "ChkConcept";
            this.ChkConcept.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkConcept.Size = new System.Drawing.Size(137, 17);
            this.ChkConcept.TabIndex = 7;
            this.ChkConcept.Text = "CONCEPTION";
            this.ChkConcept.UseVisualStyleBackColor = true;
            this.ChkConcept.CheckedChanged += new System.EventHandler(this.ChkConcept_CheckedChanged);
            // 
            // ChkFourn
            // 
            this.ChkFourn.BackColor = System.Drawing.Color.Black;
            this.ChkFourn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkFourn.ForeColor = System.Drawing.Color.White;
            this.ChkFourn.Location = new System.Drawing.Point(16, 96);
            this.ChkFourn.Name = "ChkFourn";
            this.ChkFourn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkFourn.Size = new System.Drawing.Size(137, 17);
            this.ChkFourn.TabIndex = 6;
            this.ChkFourn.Text = "FOURNISSEUR";
            this.ChkFourn.UseVisualStyleBackColor = true;
            this.ChkFourn.CheckedChanged += new System.EventHandler(this.ChkFourn_CheckedChanged);
            // 
            // ChkClient
            // 
            this.ChkClient.BackColor = System.Drawing.Color.Black;
            this.ChkClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkClient.ForeColor = System.Drawing.Color.White;
            this.ChkClient.Location = new System.Drawing.Point(16, 72);
            this.ChkClient.Name = "ChkClient";
            this.ChkClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkClient.Size = new System.Drawing.Size(137, 17);
            this.ChkClient.TabIndex = 5;
            this.ChkClient.Text = "CLIENT";
            this.ChkClient.UseVisualStyleBackColor = true;
            this.ChkClient.CheckedChanged += new System.EventHandler(this.ChkClient_CheckedChanged);
            // 
            // ChkBonTravail
            // 
            this.ChkBonTravail.BackColor = System.Drawing.Color.Black;
            this.ChkBonTravail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBonTravail.ForeColor = System.Drawing.Color.White;
            this.ChkBonTravail.Location = new System.Drawing.Point(16, 24);
            this.ChkBonTravail.Name = "ChkBonTravail";
            this.ChkBonTravail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkBonTravail.Size = new System.Drawing.Size(137, 17);
            this.ChkBonTravail.TabIndex = 3;
            this.ChkBonTravail.Text = "BON DE TRAVAIL";
            this.ChkBonTravail.UseVisualStyleBackColor = true;
            this.ChkBonTravail.CheckedChanged += new System.EventHandler(this.ChkBonTravail_CheckedChanged);
            // 
            // lblObjet
            // 
            this.lblObjet.AutoSize = true;
            this.lblObjet.BackColor = System.Drawing.Color.Black;
            this.lblObjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjet.ForeColor = System.Drawing.Color.White;
            this.lblObjet.Location = new System.Drawing.Point(16, 369);
            this.lblObjet.Name = "lblObjet";
            this.lblObjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblObjet.Size = new System.Drawing.Size(37, 14);
            this.lblObjet.TabIndex = 20;
            this.lblObjet.Text = "Objet:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.BackColor = System.Drawing.Color.Black;
            this.lblDe.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.ForeColor = System.Drawing.Color.White;
            this.lblDe.Location = new System.Drawing.Point(16, 345);
            this.lblDe.Name = "lblDe";
            this.lblDe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDe.Size = new System.Drawing.Size(24, 14);
            this.lblDe.TabIndex = 18;
            this.lblDe.Text = "De:";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.Black;
            this.lblPage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.White;
            this.lblPage.Location = new System.Drawing.Point(16, 321);
            this.lblPage.Name = "lblPage";
            this.lblPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPage.Size = new System.Drawing.Size(36, 14);
            this.lblPage.TabIndex = 15;
            this.lblPage.Text = "Pages";
            // 
            // fraChoixRapport
            // 
            this.fraChoixRapport.AutoSize = true;
            this.fraChoixRapport.BackColor = System.Drawing.Color.Black;
            this.fraChoixRapport.Controls.Add(this.txtMsg);
            this.fraChoixRapport.Controls.Add(this.chkProblemes);
            this.fraChoixRapport.Controls.Add(this.txtObjet);
            this.fraChoixRapport.Controls.Add(this.cmdMsg);
            this.fraChoixRapport.Controls.Add(this.txtDe);
            this.fraChoixRapport.Controls.Add(this.txtPage);
            this.fraChoixRapport.Controls.Add(this.chkFaxAnglais);
            this.fraChoixRapport.Controls.Add(this.chkFaxFrancais);
            this.fraChoixRapport.Controls.Add(this.chkBonLivraison);
            this.fraChoixRapport.Controls.Add(this.cmdSelect);
            this.fraChoixRapport.Controls.Add(this.ChkFinFab);
            this.fraChoixRapport.Controls.Add(this.ChkFabFerm);
            this.fraChoixRapport.Controls.Add(this.ChkFabFermMéca);
            this.fraChoixRapport.Controls.Add(this.ChkProg);
            this.fraChoixRapport.Controls.Add(this.ChkConcept);
            this.fraChoixRapport.Controls.Add(this.ChkFourn);
            this.fraChoixRapport.Controls.Add(this.ChkClient);
            this.fraChoixRapport.Controls.Add(this.ChkBonTravail);
            this.fraChoixRapport.Controls.Add(this.lblObjet);
            this.fraChoixRapport.Controls.Add(this.lblDe);
            this.fraChoixRapport.Controls.Add(this.lblPage);
            this.fraChoixRapport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraChoixRapport.ForeColor = System.Drawing.Color.White;
            this.fraChoixRapport.Location = new System.Drawing.Point(12, 12);
            this.fraChoixRapport.Name = "fraChoixRapport";
            this.fraChoixRapport.Padding = new System.Windows.Forms.Padding(0);
            this.fraChoixRapport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraChoixRapport.Size = new System.Drawing.Size(272, 487);
            this.fraChoixRapport.TabIndex = 74;
            this.fraChoixRapport.TabStop = false;
            this.fraChoixRapport.Text = "LISTE DE RAPPORT";
            // 
            // chkProblemes
            // 
            this.chkProblemes.BackColor = System.Drawing.Color.Black;
            this.chkProblemes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProblemes.ForeColor = System.Drawing.Color.White;
            this.chkProblemes.Location = new System.Drawing.Point(16, 240);
            this.chkProblemes.Name = "chkProblemes";
            this.chkProblemes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkProblemes.Size = new System.Drawing.Size(137, 17);
            this.chkProblemes.TabIndex = 65;
            this.chkProblemes.Text = "PROBLÈMES";
            this.chkProblemes.UseVisualStyleBackColor = true;
            this.chkProblemes.CheckedChanged += new System.EventHandler(this.chkProblemes_CheckedChanged);
            // 
            // txtObjet
            // 
            this.txtObjet.AcceptsReturn = true;
            this.txtObjet.BackColor = System.Drawing.Color.White;
            this.txtObjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjet.ForeColor = System.Drawing.Color.Navy;
            this.txtObjet.Location = new System.Drawing.Point(59, 369);
            this.txtObjet.MaxLength = 0;
            this.txtObjet.Name = "txtObjet";
            this.txtObjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtObjet.Size = new System.Drawing.Size(193, 22);
            this.txtObjet.TabIndex = 19;
            // 
            // cmdMsg
            // 
            this.cmdMsg.BackColor = System.Drawing.Color.Black;
            this.cmdMsg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMsg.ForeColor = System.Drawing.Color.Navy;
            this.cmdMsg.Location = new System.Drawing.Point(163, 276);
            this.cmdMsg.Name = "cmdMsg";
            this.cmdMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdMsg.Size = new System.Drawing.Size(73, 25);
            this.cmdMsg.TabIndex = 14;
            this.cmdMsg.Text = "Message";
            this.cmdMsg.UseVisualStyleBackColor = true;
            this.cmdMsg.Click += new System.EventHandler(this.cmdMsg_Click);
            // 
            // txtDe
            // 
            this.txtDe.AcceptsReturn = true;
            this.txtDe.BackColor = System.Drawing.Color.White;
            this.txtDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDe.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe.ForeColor = System.Drawing.Color.Navy;
            this.txtDe.Location = new System.Drawing.Point(59, 345);
            this.txtDe.MaxLength = 0;
            this.txtDe.Name = "txtDe";
            this.txtDe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDe.Size = new System.Drawing.Size(145, 22);
            this.txtDe.TabIndex = 17;
            // 
            // txtPage
            // 
            this.txtPage.AcceptsReturn = true;
            this.txtPage.BackColor = System.Drawing.Color.White;
            this.txtPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.ForeColor = System.Drawing.Color.Navy;
            this.txtPage.Location = new System.Drawing.Point(59, 321);
            this.txtPage.MaxLength = 0;
            this.txtPage.Name = "txtPage";
            this.txtPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPage.Size = new System.Drawing.Size(49, 22);
            this.txtPage.TabIndex = 16;
            // 
            // chkFaxAnglais
            // 
            this.chkFaxAnglais.AutoSize = true;
            this.chkFaxAnglais.BackColor = System.Drawing.Color.Black;
            this.chkFaxAnglais.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFaxAnglais.ForeColor = System.Drawing.Color.White;
            this.chkFaxAnglais.Location = new System.Drawing.Point(16, 288);
            this.chkFaxAnglais.Name = "chkFaxAnglais";
            this.chkFaxAnglais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFaxAnglais.Size = new System.Drawing.Size(88, 18);
            this.chkFaxAnglais.TabIndex = 12;
            this.chkFaxAnglais.Text = "Fax Anglais";
            this.chkFaxAnglais.UseVisualStyleBackColor = true;
            this.chkFaxAnglais.CheckedChanged += new System.EventHandler(this.chkFaxAnglais_CheckedChanged);
            // 
            // chkFaxFrancais
            // 
            this.chkFaxFrancais.AutoSize = true;
            this.chkFaxFrancais.BackColor = System.Drawing.Color.Black;
            this.chkFaxFrancais.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFaxFrancais.ForeColor = System.Drawing.Color.White;
            this.chkFaxFrancais.Location = new System.Drawing.Point(16, 264);
            this.chkFaxFrancais.Name = "chkFaxFrancais";
            this.chkFaxFrancais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFaxFrancais.Size = new System.Drawing.Size(93, 18);
            this.chkFaxFrancais.TabIndex = 13;
            this.chkFaxFrancais.Text = "Fax Français";
            this.chkFaxFrancais.UseVisualStyleBackColor = true;
            // 
            // chkBonLivraison
            // 
            this.chkBonLivraison.BackColor = System.Drawing.Color.Black;
            this.chkBonLivraison.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBonLivraison.ForeColor = System.Drawing.Color.White;
            this.chkBonLivraison.Location = new System.Drawing.Point(16, 48);
            this.chkBonLivraison.Name = "chkBonLivraison";
            this.chkBonLivraison.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBonLivraison.Size = new System.Drawing.Size(137, 17);
            this.chkBonLivraison.TabIndex = 4;
            this.chkBonLivraison.Text = "BON DE LIVRAISON";
            this.chkBonLivraison.UseVisualStyleBackColor = true;
            this.chkBonLivraison.CheckedChanged += new System.EventHandler(this.chkBonLivraison_CheckedChanged);
            // 
            // cmdSelect
            // 
            this.cmdSelect.BackColor = System.Drawing.Color.Black;
            this.cmdSelect.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelect.ForeColor = System.Drawing.Color.Navy;
            this.cmdSelect.Location = new System.Drawing.Point(48, 401);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSelect.Size = new System.Drawing.Size(137, 31);
            this.cmdSelect.TabIndex = 21;
            this.cmdSelect.Text = "Sélectionner tout";
            this.cmdSelect.UseVisualStyleBackColor = true;
            // 
            // ChkFinFab
            // 
            this.ChkFinFab.AutoSize = true;
            this.ChkFinFab.BackColor = System.Drawing.Color.Black;
            this.ChkFinFab.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkFinFab.ForeColor = System.Drawing.Color.White;
            this.ChkFinFab.Location = new System.Drawing.Point(16, 216);
            this.ChkFinFab.Name = "ChkFinFab";
            this.ChkFinFab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkFinFab.Size = new System.Drawing.Size(138, 18);
            this.ChkFinFab.TabIndex = 11;
            this.ChkFinFab.Text = "FINS DE FABRICATION";
            this.ChkFinFab.UseVisualStyleBackColor = true;
            this.ChkFinFab.CheckedChanged += new System.EventHandler(this.ChkFinFab_CheckedChanged);
            // 
            // ChkFabFerm
            // 
            this.ChkFabFerm.BackColor = System.Drawing.Color.Black;
            this.ChkFabFerm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkFabFerm.ForeColor = System.Drawing.Color.White;
            this.ChkFabFerm.Location = new System.Drawing.Point(16, 192);
            this.ChkFabFerm.Name = "ChkFabFerm";
            this.ChkFabFerm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkFabFerm.Size = new System.Drawing.Size(233, 17);
            this.ChkFabFerm.TabIndex = 10;
            this.ChkFabFerm.Text = "FABRICATION - FERMETURE";
            this.ChkFabFerm.UseVisualStyleBackColor = true;
            this.ChkFabFerm.CheckedChanged += new System.EventHandler(this.ChkFabFerm_CheckedChanged);
            // 
            // txtMsg
            // 
            this.txtMsg.AcceptsReturn = true;
            this.txtMsg.BackColor = System.Drawing.Color.White;
            this.txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMsg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.ForeColor = System.Drawing.Color.White;
            this.txtMsg.Location = new System.Drawing.Point(0, 21);
            this.txtMsg.MaxLength = 0;
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(265, 241);
            this.txtMsg.TabIndex = 2;
            this.txtMsg.Visible = false;
            this.txtMsg.WordWrap = false;
            // 
            // cmbContactFRS
            // 
            this.cmbContactFRS.BackColor = System.Drawing.Color.White;
            this.cmbContactFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContactFRS.ForeColor = System.Drawing.Color.White;
            this.cmbContactFRS.Location = new System.Drawing.Point(315, 476);
            this.cmbContactFRS.Name = "cmbContactFRS";
            this.cmbContactFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbContactFRS.Size = new System.Drawing.Size(273, 22);
            this.cmbContactFRS.TabIndex = 111;
            this.cmbContactFRS.SelectedIndexChanged += new System.EventHandler(this.cmbContactFRS_SelectedIndexChanged);
            // 
            // cmdRechercherFRS
            // 
            this.cmdRechercherFRS.BackColor = System.Drawing.Color.Black;
            this.cmdRechercherFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRechercherFRS.ForeColor = System.Drawing.Color.Navy;
            this.cmdRechercherFRS.Location = new System.Drawing.Point(595, 436);
            this.cmdRechercherFRS.Name = "cmdRechercherFRS";
            this.cmdRechercherFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercherFRS.Size = new System.Drawing.Size(25, 21);
            this.cmdRechercherFRS.TabIndex = 107;
            this.cmdRechercherFRS.Text = "..";
            this.cmdRechercherFRS.UseVisualStyleBackColor = true;
            this.cmdRechercherFRS.Click += new System.EventHandler(this.cmdRechercherFRS_Click);
            // 
            // cmdRechercherClient2
            // 
            this.cmdRechercherClient2.BackColor = System.Drawing.Color.Black;
            this.cmdRechercherClient2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRechercherClient2.ForeColor = System.Drawing.Color.Navy;
            this.cmdRechercherClient2.Location = new System.Drawing.Point(595, 356);
            this.cmdRechercherClient2.Name = "cmdRechercherClient2";
            this.cmdRechercherClient2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercherClient2.Size = new System.Drawing.Size(25, 21);
            this.cmdRechercherClient2.TabIndex = 101;
            this.cmdRechercherClient2.Text = "..";
            this.cmdRechercherClient2.UseVisualStyleBackColor = true;
            this.cmdRechercherClient2.Click += new System.EventHandler(this.cmdRechercherClient2_Click);
            // 
            // cmdRechercherClient
            // 
            this.cmdRechercherClient.BackColor = System.Drawing.Color.Black;
            this.cmdRechercherClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRechercherClient.ForeColor = System.Drawing.Color.Navy;
            this.cmdRechercherClient.Location = new System.Drawing.Point(595, 28);
            this.cmdRechercherClient.Name = "cmdRechercherClient";
            this.cmdRechercherClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRechercherClient.Size = new System.Drawing.Size(25, 21);
            this.cmdRechercherClient.TabIndex = 76;
            this.cmdRechercherClient.Text = "..";
            this.cmdRechercherClient.UseVisualStyleBackColor = true;
            this.cmdRechercherClient.Click += new System.EventHandler(this.cmdRechercherClient_Click);
            // 
            // txtProjetClient
            // 
            this.txtProjetClient.AcceptsReturn = true;
            this.txtProjetClient.BackColor = System.Drawing.Color.White;
            this.txtProjetClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjetClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjetClient.ForeColor = System.Drawing.Color.White;
            this.txtProjetClient.Location = new System.Drawing.Point(486, 235);
            this.txtProjetClient.MaxLength = 0;
            this.txtProjetClient.Name = "txtProjetClient";
            this.txtProjetClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProjetClient.Size = new System.Drawing.Size(155, 22);
            this.txtProjetClient.TabIndex = 90;
            // 
            // cmdReport
            // 
            this.cmdReport.BackColor = System.Drawing.Color.Black;
            this.cmdReport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReport.ForeColor = System.Drawing.Color.Navy;
            this.cmdReport.Location = new System.Drawing.Point(467, 571);
            this.cmdReport.Name = "cmdReport";
            this.cmdReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReport.Size = new System.Drawing.Size(89, 30);
            this.cmdReport.TabIndex = 108;
            this.cmdReport.Text = "Impression";
            this.cmdReport.UseVisualStyleBackColor = true;
            this.cmdReport.Click += new System.EventHandler(this.cmdReport_Click);
            // 
            // cmbFournisseur
            // 
            this.cmbFournisseur.BackColor = System.Drawing.Color.White;
            this.cmbFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFournisseur.ForeColor = System.Drawing.Color.White;
            this.cmbFournisseur.Location = new System.Drawing.Point(315, 436);
            this.cmbFournisseur.Name = "cmbFournisseur";
            this.cmbFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbFournisseur.Size = new System.Drawing.Size(273, 22);
            this.cmbFournisseur.TabIndex = 106;
            this.cmbFournisseur.Text = "cmbFournisseur";
            this.cmbFournisseur.SelectedIndexChanged += new System.EventHandler(this.cmbFournisseur_SelectedIndexChanged);
            // 
            // txtTransport
            // 
            this.txtTransport.AcceptsReturn = true;
            this.txtTransport.BackColor = System.Drawing.Color.White;
            this.txtTransport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransport.ForeColor = System.Drawing.Color.White;
            this.txtTransport.Location = new System.Drawing.Point(315, 396);
            this.txtTransport.MaxLength = 0;
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTransport.Size = new System.Drawing.Size(177, 22);
            this.txtTransport.TabIndex = 104;
            // 
            // txtNoCommande
            // 
            this.txtNoCommande.AcceptsReturn = true;
            this.txtNoCommande.BackColor = System.Drawing.Color.White;
            this.txtNoCommande.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoCommande.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoCommande.ForeColor = System.Drawing.Color.White;
            this.txtNoCommande.Location = new System.Drawing.Point(483, 276);
            this.txtNoCommande.MaxLength = 0;
            this.txtNoCommande.Name = "txtNoCommande";
            this.txtNoCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoCommande.Size = new System.Drawing.Size(121, 22);
            this.txtNoCommande.TabIndex = 93;
            // 
            // txtNoSoumission
            // 
            this.txtNoSoumission.AcceptsReturn = true;
            this.txtNoSoumission.BackColor = System.Drawing.Color.White;
            this.txtNoSoumission.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoSoumission.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoSoumission.ForeColor = System.Drawing.Color.White;
            this.txtNoSoumission.Location = new System.Drawing.Point(315, 156);
            this.txtNoSoumission.MaxLength = 0;
            this.txtNoSoumission.Name = "txtNoSoumission";
            this.txtNoSoumission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoSoumission.Size = new System.Drawing.Size(81, 22);
            this.txtNoSoumission.TabIndex = 83;
            // 
            // cmdFermer
            // 
            this.cmdFermer.BackColor = System.Drawing.Color.Black;
            this.cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermer.ForeColor = System.Drawing.Color.Navy;
            this.cmdFermer.Location = new System.Drawing.Point(571, 571);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFermer.Size = new System.Drawing.Size(89, 30);
            this.cmdFermer.TabIndex = 109;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // cmbGRB
            // 
            this.cmbGRB.BackColor = System.Drawing.Color.White;
            this.cmbGRB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGRB.ForeColor = System.Drawing.Color.White;
            this.cmbGRB.Location = new System.Drawing.Point(315, 108);
            this.cmbGRB.Name = "cmbGRB";
            this.cmbGRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbGRB.Size = new System.Drawing.Size(273, 22);
            this.cmbGRB.TabIndex = 80;
            this.cmbGRB.SelectedIndexChanged += new System.EventHandler(this.cmbGRB_SelectedIndexChanged);
            // 
            // cmbContact
            // 
            this.cmbContact.BackColor = System.Drawing.Color.White;
            this.cmbContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContact.ForeColor = System.Drawing.Color.White;
            this.cmbContact.Location = new System.Drawing.Point(315, 68);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbContact.Size = new System.Drawing.Size(273, 22);
            this.cmbContact.TabIndex = 78;
            this.cmbContact.SelectedIndexChanged += new System.EventHandler(this.cmbContact_SelectedIndexChanged);
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // txtNomProjet
            // 
            this.txtNomProjet.AcceptsReturn = true;
            this.txtNomProjet.BackColor = System.Drawing.Color.White;
            this.txtNomProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProjet.ForeColor = System.Drawing.Color.White;
            this.txtNomProjet.Location = new System.Drawing.Point(427, 196);
            this.txtNomProjet.MaxLength = 0;
            this.txtNomProjet.Name = "txtNomProjet";
            this.txtNomProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomProjet.Size = new System.Drawing.Size(177, 22);
            this.txtNomProjet.TabIndex = 87;
            // 
            // txtNoProjet
            // 
            this.txtNoProjet.AcceptsReturn = true;
            this.txtNoProjet.BackColor = System.Drawing.Color.White;
            this.txtNoProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoProjet.ForeColor = System.Drawing.Color.White;
            this.txtNoProjet.Location = new System.Drawing.Point(315, 196);
            this.txtNoProjet.MaxLength = 0;
            this.txtNoProjet.Name = "txtNoProjet";
            this.txtNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoProjet.Size = new System.Drawing.Size(81, 22);
            this.txtNoProjet.TabIndex = 86;
            // 
            // cmbClient
            // 
            this.cmbClient.BackColor = System.Drawing.Color.White;
            this.cmbClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.ForeColor = System.Drawing.Color.White;
            this.cmbClient.Location = new System.Drawing.Point(315, 28);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbClient.Size = new System.Drawing.Size(273, 22);
            this.cmbClient.Sorted = true;
            this.cmbClient.TabIndex = 75;
            this.cmbClient.Text = "cmbClient";
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // cmbClient2
            // 
            this.cmbClient2.BackColor = System.Drawing.Color.Black;
            this.cmbClient2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient2.ForeColor = System.Drawing.Color.White;
            this.cmbClient2.Location = new System.Drawing.Point(315, 356);
            this.cmbClient2.Name = "cmbClient2";
            this.cmbClient2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbClient2.Size = new System.Drawing.Size(273, 22);
            this.cmbClient2.Sorted = true;
            this.cmbClient2.TabIndex = 100;
            this.cmbClient2.SelectedIndexChanged += new System.EventHandler(this.cmbClient2_SelectedIndexChanged);
            // 
            // mskHeureTravaux
            // 
            this.mskHeureTravaux.AllowPromptAsInput = false;
            this.mskHeureTravaux.BackColor = System.Drawing.Color.White;
            this.mskHeureTravaux.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskHeureTravaux.ForeColor = System.Drawing.Color.White;
            this.mskHeureTravaux.Location = new System.Drawing.Point(483, 316);
            this.mskHeureTravaux.Name = "mskHeureTravaux";
            this.mskHeureTravaux.Size = new System.Drawing.Size(73, 22);
            this.mskHeureTravaux.TabIndex = 97;
            // 
            // lblFournisseur2
            // 
            this.lblFournisseur2.AutoSize = true;
            this.lblFournisseur2.BackColor = System.Drawing.Color.Black;
            this.lblFournisseur2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFournisseur2.ForeColor = System.Drawing.Color.White;
            this.lblFournisseur2.Location = new System.Drawing.Point(315, 508);
            this.lblFournisseur2.Name = "lblFournisseur2";
            this.lblFournisseur2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFournisseur2.Size = new System.Drawing.Size(128, 14);
            this.lblFournisseur2.TabIndex = 114;
            this.lblFournisseur2.Text = "Fournisseur Expédié à";
            // 
            // lblDateDue
            // 
            this.lblDateDue.BackColor = System.Drawing.Color.Black;
            this.lblDateDue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDue.ForeColor = System.Drawing.Color.White;
            this.lblDateDue.Location = new System.Drawing.Point(427, 140);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateDue.Size = new System.Drawing.Size(129, 17);
            this.lblDateDue.TabIndex = 82;
            this.lblDateDue.Text = "Date dûe";
            // 
            // lblFormatHeurePrevue
            // 
            this.lblFormatHeurePrevue.AutoSize = true;
            this.lblFormatHeurePrevue.BackColor = System.Drawing.Color.Black;
            this.lblFormatHeurePrevue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatHeurePrevue.ForeColor = System.Drawing.Color.White;
            this.lblFormatHeurePrevue.Location = new System.Drawing.Point(563, 316);
            this.lblFormatHeurePrevue.Name = "lblFormatHeurePrevue";
            this.lblFormatHeurePrevue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFormatHeurePrevue.Size = new System.Drawing.Size(46, 14);
            this.lblFormatHeurePrevue.TabIndex = 98;
            this.lblFormatHeurePrevue.Text = "HH:MM";
            // 
            // lblContactFRS
            // 
            this.lblContactFRS.AutoSize = true;
            this.lblContactFRS.BackColor = System.Drawing.Color.Black;
            this.lblContactFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactFRS.ForeColor = System.Drawing.Color.White;
            this.lblContactFRS.Location = new System.Drawing.Point(315, 460);
            this.lblContactFRS.Name = "lblContactFRS";
            this.lblContactFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblContactFRS.Size = new System.Drawing.Size(47, 14);
            this.lblContactFRS.TabIndex = 110;
            this.lblContactFRS.Text = "Contact";
            this.lblContactFRS.Visible = false;
            // 
            // lblHeureTravaux
            // 
            this.lblHeureTravaux.AutoSize = true;
            this.lblHeureTravaux.BackColor = System.Drawing.Color.Black;
            this.lblHeureTravaux.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeureTravaux.ForeColor = System.Drawing.Color.White;
            this.lblHeureTravaux.Location = new System.Drawing.Point(483, 300);
            this.lblHeureTravaux.Name = "lblHeureTravaux";
            this.lblHeureTravaux.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeureTravaux.Size = new System.Drawing.Size(80, 14);
            this.lblHeureTravaux.TabIndex = 95;
            this.lblHeureTravaux.Text = "Heure prévue";
            // 
            // lblProjetClient
            // 
            this.lblProjetClient.AutoSize = true;
            this.lblProjetClient.BackColor = System.Drawing.Color.Black;
            this.lblProjetClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjetClient.ForeColor = System.Drawing.Color.White;
            this.lblProjetClient.Location = new System.Drawing.Point(486, 219);
            this.lblProjetClient.Name = "lblProjetClient";
            this.lblProjetClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProjetClient.Size = new System.Drawing.Size(73, 14);
            this.lblProjetClient.TabIndex = 89;
            this.lblProjetClient.Text = "Projet Client";
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.BackColor = System.Drawing.Color.Black;
            this.lblFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblFournisseur.Location = new System.Drawing.Point(315, 420);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFournisseur.Size = new System.Drawing.Size(72, 14);
            this.lblFournisseur.TabIndex = 105;
            this.lblFournisseur.Text = "Fournisseur";
            // 
            // lblDateLivraison
            // 
            this.lblDateLivraison.AutoSize = true;
            this.lblDateLivraison.BackColor = System.Drawing.Color.Black;
            this.lblDateLivraison.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateLivraison.ForeColor = System.Drawing.Color.White;
            this.lblDateLivraison.Location = new System.Drawing.Point(504, 381);
            this.lblDateLivraison.Name = "lblDateLivraison";
            this.lblDateLivraison.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateLivraison.Size = new System.Drawing.Size(84, 14);
            this.lblDateLivraison.TabIndex = 103;
            this.lblDateLivraison.Text = "Date livraison";
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.BackColor = System.Drawing.Color.Black;
            this.lblTransport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransport.ForeColor = System.Drawing.Color.White;
            this.lblTransport.Location = new System.Drawing.Point(315, 380);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTransport.Size = new System.Drawing.Size(58, 14);
            this.lblTransport.TabIndex = 102;
            this.lblTransport.Text = "Transport";
            // 
            // lblClient2
            // 
            this.lblClient2.AutoSize = true;
            this.lblClient2.BackColor = System.Drawing.Color.Black;
            this.lblClient2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient2.ForeColor = System.Drawing.Color.White;
            this.lblClient2.Location = new System.Drawing.Point(315, 340);
            this.lblClient2.Name = "lblClient2";
            this.lblClient2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblClient2.Size = new System.Drawing.Size(95, 14);
            this.lblClient2.TabIndex = 99;
            this.lblClient2.Text = "Client Expédié à";
            // 
            // lblClient
            // 
            this.lblClient.BackColor = System.Drawing.Color.Black;
            this.lblClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(315, 12);
            this.lblClient.Name = "lblClient";
            this.lblClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblClient.Size = new System.Drawing.Size(41, 17);
            this.lblClient.TabIndex = 73;
            this.lblClient.Text = "Client";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Black;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(315, 220);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(33, 14);
            this.lblDate.TabIndex = 88;
            this.lblDate.Text = "Date";
            // 
            // lblDateTravaux
            // 
            this.lblDateTravaux.BackColor = System.Drawing.Color.Black;
            this.lblDateTravaux.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTravaux.ForeColor = System.Drawing.Color.White;
            this.lblDateTravaux.Location = new System.Drawing.Point(315, 300);
            this.lblDateTravaux.Name = "lblDateTravaux";
            this.lblDateTravaux.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateTravaux.Size = new System.Drawing.Size(81, 17);
            this.lblDateTravaux.TabIndex = 94;
            this.lblDateTravaux.Text = "Date travaux";
            // 
            // lblNomProjet
            // 
            this.lblNomProjet.AutoSize = true;
            this.lblNomProjet.BackColor = System.Drawing.Color.Black;
            this.lblNomProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProjet.ForeColor = System.Drawing.Color.White;
            this.lblNomProjet.Location = new System.Drawing.Point(427, 180);
            this.lblNomProjet.Name = "lblNomProjet";
            this.lblNomProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNomProjet.Size = new System.Drawing.Size(66, 14);
            this.lblNomProjet.TabIndex = 85;
            this.lblNomProjet.Text = "Nom Projet";
            // 
            // lblDateCommande
            // 
            this.lblDateCommande.AutoSize = true;
            this.lblDateCommande.BackColor = System.Drawing.Color.Black;
            this.lblDateCommande.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCommande.ForeColor = System.Drawing.Color.White;
            this.lblDateCommande.Location = new System.Drawing.Point(315, 260);
            this.lblDateCommande.Name = "lblDateCommande";
            this.lblDateCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDateCommande.Size = new System.Drawing.Size(97, 14);
            this.lblDateCommande.TabIndex = 91;
            this.lblDateCommande.Text = "Date Commande";
            // 
            // lblNoProjet
            // 
            this.lblNoProjet.AutoSize = true;
            this.lblNoProjet.BackColor = System.Drawing.Color.Black;
            this.lblNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoProjet.ForeColor = System.Drawing.Color.White;
            this.lblNoProjet.Location = new System.Drawing.Point(315, 180);
            this.lblNoProjet.Name = "lblNoProjet";
            this.lblNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNoProjet.Size = new System.Drawing.Size(59, 14);
            this.lblNoProjet.TabIndex = 84;
            this.lblNoProjet.Text = "No. Projet";
            // 
            // lblNoSoumission
            // 
            this.lblNoSoumission.BackColor = System.Drawing.Color.Black;
            this.lblNoSoumission.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSoumission.ForeColor = System.Drawing.Color.White;
            this.lblNoSoumission.Location = new System.Drawing.Point(315, 140);
            this.lblNoSoumission.Name = "lblNoSoumission";
            this.lblNoSoumission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNoSoumission.Size = new System.Drawing.Size(89, 17);
            this.lblNoSoumission.TabIndex = 81;
            this.lblNoSoumission.Text = "No. Soumission";
            // 
            // lblGRB
            // 
            this.lblGRB.BackColor = System.Drawing.Color.Black;
            this.lblGRB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRB.ForeColor = System.Drawing.Color.White;
            this.lblGRB.Location = new System.Drawing.Point(315, 92);
            this.lblGRB.Name = "lblGRB";
            this.lblGRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGRB.Size = new System.Drawing.Size(113, 17);
            this.lblGRB.TabIndex = 79;
            this.lblGRB.Text = "Représentant GRB";
            // 
            // lblContact
            // 
            this.lblContact.BackColor = System.Drawing.Color.Black;
            this.lblContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.White;
            this.lblContact.Location = new System.Drawing.Point(315, 52);
            this.lblContact.Name = "lblContact";
            this.lblContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblContact.Size = new System.Drawing.Size(49, 17);
            this.lblContact.TabIndex = 77;
            this.lblContact.Text = "Contact";
            // 
            // lblNoCommande
            // 
            this.lblNoCommande.AutoSize = true;
            this.lblNoCommande.BackColor = System.Drawing.Color.Black;
            this.lblNoCommande.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCommande.ForeColor = System.Drawing.Color.White;
            this.lblNoCommande.Location = new System.Drawing.Point(483, 260);
            this.lblNoCommande.Name = "lblNoCommande";
            this.lblNoCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNoCommande.Size = new System.Drawing.Size(124, 14);
            this.lblNoCommande.TabIndex = 92;
            this.lblNoCommande.Text = "No. Commande Client";
            // 
            // mskDateTravaux
            // 
            this.mskDateTravaux.Location = new System.Drawing.Point(318, 317);
            this.mskDateTravaux.Name = "mskDateTravaux";
            this.mskDateTravaux.Size = new System.Drawing.Size(159, 20);
            this.mskDateTravaux.TabIndex = 119;
            this.mskDateTravaux.ValueChanged += new System.EventHandler(this.mskDateTravaux_ValueChanged);
            // 
            // WizzardRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(674, 606);
            this.Controls.Add(this.mskDateTravaux);
            this.Controls.Add(this.mskDateLivraison);
            this.Controls.Add(this.mskDate);
            this.Controls.Add(this.mskDateCommande);
            this.Controls.Add(this.mskDateDue);
            this.Controls.Add(this.cmbFournisseur2);
            this.Controls.Add(this.cmdRechercherFRS2);
            this.Controls.Add(this.fraChoixRapport);
            this.Controls.Add(this.cmbContactFRS);
            this.Controls.Add(this.cmdRechercherFRS);
            this.Controls.Add(this.cmdRechercherClient2);
            this.Controls.Add(this.cmdRechercherClient);
            this.Controls.Add(this.txtProjetClient);
            this.Controls.Add(this.cmdReport);
            this.Controls.Add(this.cmbFournisseur);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.txtNoCommande);
            this.Controls.Add(this.txtNoSoumission);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmbGRB);
            this.Controls.Add(this.cmbContact);
            this.Controls.Add(this.txtNomProjet);
            this.Controls.Add(this.txtNoProjet);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.cmbClient2);
            this.Controls.Add(this.mskHeureTravaux);
            this.Controls.Add(this.lblFournisseur2);
            this.Controls.Add(this.lblDateDue);
            this.Controls.Add(this.lblFormatHeurePrevue);
            this.Controls.Add(this.lblContactFRS);
            this.Controls.Add(this.lblHeureTravaux);
            this.Controls.Add(this.lblProjetClient);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.lblDateLivraison);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.lblClient2);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDateTravaux);
            this.Controls.Add(this.lblNomProjet);
            this.Controls.Add(this.lblDateCommande);
            this.Controls.Add(this.lblNoProjet);
            this.Controls.Add(this.lblNoSoumission);
            this.Controls.Add(this.lblGRB);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblNoCommande);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WizzardRapport";
            this.Text = "WizzardRapport";
            this.Load += new System.EventHandler(this.Rapport2_Load);
            this.fraChoixRapport.ResumeLayout(false);
            this.fraChoixRapport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker mskDateLivraison;
        private System.Windows.Forms.DateTimePicker mskDate;
        private System.Windows.Forms.DateTimePicker mskDateCommande;
        private System.Windows.Forms.DateTimePicker mskDateDue;
        internal System.Windows.Forms.ComboBox cmbFournisseur2;
        internal System.Windows.Forms.Button cmdRechercherFRS2;
        internal System.Windows.Forms.CheckBox ChkFabFermMéca;
        internal System.Windows.Forms.CheckBox ChkProg;
        internal System.Windows.Forms.CheckBox ChkConcept;
        internal System.Windows.Forms.CheckBox ChkFourn;
        internal System.Windows.Forms.CheckBox ChkClient;
        internal System.Windows.Forms.CheckBox ChkBonTravail;
        internal System.Windows.Forms.Label lblObjet;
        internal System.Windows.Forms.Label lblDe;
        internal System.Windows.Forms.Label lblPage;
        internal System.Windows.Forms.GroupBox fraChoixRapport;
        internal System.Windows.Forms.TextBox txtMsg;
        internal System.Windows.Forms.CheckBox chkProblemes;
        internal System.Windows.Forms.TextBox txtObjet;
        internal System.Windows.Forms.Button cmdMsg;
        internal System.Windows.Forms.TextBox txtDe;
        internal System.Windows.Forms.TextBox txtPage;
        internal System.Windows.Forms.CheckBox chkFaxAnglais;
        internal System.Windows.Forms.CheckBox chkFaxFrancais;
        internal System.Windows.Forms.CheckBox chkBonLivraison;
        internal System.Windows.Forms.Button cmdSelect;
        internal System.Windows.Forms.CheckBox ChkFinFab;
        internal System.Windows.Forms.CheckBox ChkFabFerm;
        internal System.Windows.Forms.ComboBox cmbContactFRS;
        internal System.Windows.Forms.Button cmdRechercherFRS;
        internal System.Windows.Forms.Button cmdRechercherClient2;
        internal System.Windows.Forms.Button cmdRechercherClient;
        internal System.Windows.Forms.TextBox txtProjetClient;
        internal System.Windows.Forms.Button cmdReport;
        internal System.Windows.Forms.ComboBox cmbFournisseur;
        internal System.Windows.Forms.TextBox txtTransport;
        internal System.Windows.Forms.TextBox txtNoCommande;
        internal System.Windows.Forms.TextBox txtNoSoumission;
        internal System.Windows.Forms.Button cmdFermer;
        internal System.Windows.Forms.ComboBox cmbGRB;
        internal System.Windows.Forms.ComboBox cmbContact;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.TextBox txtNomProjet;
        internal System.Windows.Forms.TextBox txtNoProjet;
        internal System.Windows.Forms.ComboBox cmbClient;
        internal System.Windows.Forms.ComboBox cmbClient2;
        internal System.Windows.Forms.MaskedTextBox mskHeureTravaux;
        internal System.Windows.Forms.Label lblFournisseur2;
        internal System.Windows.Forms.Label lblDateDue;
        internal System.Windows.Forms.Label lblFormatHeurePrevue;
        internal System.Windows.Forms.Label lblContactFRS;
        internal System.Windows.Forms.Label lblHeureTravaux;
        internal System.Windows.Forms.Label lblProjetClient;
        internal System.Windows.Forms.Label lblFournisseur;
        internal System.Windows.Forms.Label lblDateLivraison;
        internal System.Windows.Forms.Label lblTransport;
        internal System.Windows.Forms.Label lblClient2;
        internal System.Windows.Forms.Label lblClient;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblDateTravaux;
        internal System.Windows.Forms.Label lblNomProjet;
        internal System.Windows.Forms.Label lblDateCommande;
        internal System.Windows.Forms.Label lblNoProjet;
        internal System.Windows.Forms.Label lblNoSoumission;
        internal System.Windows.Forms.Label lblGRB;
        internal System.Windows.Forms.Label lblContact;
        internal System.Windows.Forms.Label lblNoCommande;
        private System.Windows.Forms.DateTimePicker mskDateTravaux;
    }
}