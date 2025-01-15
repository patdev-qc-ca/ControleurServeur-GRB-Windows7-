using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;
using System.Drawing;
using System.Collections.Generic;

namespace ControleurServeur
{
    internal class Groupes : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public Groupes() : base()
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

        private Button button2;
        private System.ComponentModel.IContainer components;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkDeverrouillageTempsProjet = new System.Windows.Forms.CheckBox();
            this.chkVerrouillageTempsProjet = new System.Windows.Forms.CheckBox();
            this.chkPunchSemaineAnterieure = new System.Windows.Forms.CheckBox();
            this.chkMailingList = new System.Windows.Forms.CheckBox();
            this.chkRetourMarchandise = new System.Windows.Forms.CheckBox();
            this.chkReception = new System.Windows.Forms.CheckBox();
            this.chkSupprimerProjets = new System.Windows.Forms.CheckBox();
            this.chkModificationPunchEmployes = new System.Windows.Forms.CheckBox();
            this.chkModificationInventaireMec = new System.Windows.Forms.CheckBox();
            this.chkModificationInventaireElec = new System.Windows.Forms.CheckBox();
            this.chkModificationCatalogueElec = new System.Windows.Forms.CheckBox();
            this.chkModificationCatalogueMec = new System.Windows.Forms.CheckBox();
            this.chkModificationBonsCommandes = new System.Windows.Forms.CheckBox();
            this.chkModificationSoumissionElec = new System.Windows.Forms.CheckBox();
            this.chkModificationProjetElec = new System.Windows.Forms.CheckBox();
            this.chkModificationProjetMec = new System.Windows.Forms.CheckBox();
            this.chkModificationSoumissionMec = new System.Windows.Forms.CheckBox();
            this.chkModificationFacturation = new System.Windows.Forms.CheckBox();
            this.chkModificationOutils = new System.Windows.Forms.CheckBox();
            this.chkModificationFeuillesTemps = new System.Windows.Forms.CheckBox();
            this.chkModificationGroupes = new System.Windows.Forms.CheckBox();
            this.chkModificationEmployes = new System.Windows.Forms.CheckBox();
            this.chkModificationContacts = new System.Windows.Forms.CheckBox();
            this.chkModificationFRS = new System.Windows.Forms.CheckBox();
            this.chkModificationClients = new System.Windows.Forms.CheckBox();
            this.chkAchat = new System.Windows.Forms.CheckBox();
            this.chkInventaireMec = new System.Windows.Forms.CheckBox();
            this.chkInventaireElec = new System.Windows.Forms.CheckBox();
            this.chkCatalogueElec = new System.Windows.Forms.CheckBox();
            this.chkSoumissionElec = new System.Windows.Forms.CheckBox();
            this.chkProjetElec = new System.Windows.Forms.CheckBox();
            this.chkProjetMec = new System.Windows.Forms.CheckBox();
            this.chkSoumissionMec = new System.Windows.Forms.CheckBox();
            this.chkOutils = new System.Windows.Forms.CheckBox();
            this.chkPunch = new System.Windows.Forms.CheckBox();
            this.chkConfiguration = new System.Windows.Forms.CheckBox();
            this.chkCedule = new System.Windows.Forms.CheckBox();
            this.chkEmployes = new System.Windows.Forms.CheckBox();
            this.chkCatalogueMec = new System.Windows.Forms.CheckBox();
            this.chkRapports = new System.Windows.Forms.CheckBox();
            this.chkContactsVendeurs = new System.Windows.Forms.CheckBox();
            this.chkContacts = new System.Windows.Forms.CheckBox();
            this.chkFournisseurs = new System.Windows.Forms.CheckBox();
            this.chkClients = new System.Windows.Forms.CheckBox();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.fraModification = new System.Windows.Forms.GroupBox();
            this.cmbGroupe = new System.Windows.Forms.ComboBox();
            this.fraAffichage = new System.Windows.Forms.GroupBox();
            this.cmdEnregistrer = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.txtGroupe = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblGroupes = new System.Windows.Forms.Label();
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fraModification.SuspendLayout();
            this.fraAffichage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // chkDeverrouillageTempsProjet
            // 
            this.chkDeverrouillageTempsProjet.AutoSize = true;
            this.chkDeverrouillageTempsProjet.BackColor = System.Drawing.Color.Black;
            this.chkDeverrouillageTempsProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeverrouillageTempsProjet.ForeColor = System.Drawing.Color.White;
            this.chkDeverrouillageTempsProjet.Location = new System.Drawing.Point(184, 264);
            this.chkDeverrouillageTempsProjet.Name = "chkDeverrouillageTempsProjet";
            this.chkDeverrouillageTempsProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDeverrouillageTempsProjet.Size = new System.Drawing.Size(195, 18);
            this.chkDeverrouillageTempsProjet.TabIndex = 56;
            this.chkDeverrouillageTempsProjet.Text = "Déverrouillage du temps de projet";
            this.ToolTip1.SetToolTip(this.chkDeverrouillageTempsProjet, "Permet de faire les retours de marchandise");
            this.chkDeverrouillageTempsProjet.UseVisualStyleBackColor = true;
            // 
            // chkVerrouillageTempsProjet
            // 
            this.chkVerrouillageTempsProjet.AutoSize = true;
            this.chkVerrouillageTempsProjet.BackColor = System.Drawing.Color.Black;
            this.chkVerrouillageTempsProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVerrouillageTempsProjet.ForeColor = System.Drawing.Color.White;
            this.chkVerrouillageTempsProjet.Location = new System.Drawing.Point(184, 240);
            this.chkVerrouillageTempsProjet.Name = "chkVerrouillageTempsProjet";
            this.chkVerrouillageTempsProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkVerrouillageTempsProjet.Size = new System.Drawing.Size(181, 18);
            this.chkVerrouillageTempsProjet.TabIndex = 55;
            this.chkVerrouillageTempsProjet.Text = "Verrouillage du temps de projet";
            this.ToolTip1.SetToolTip(this.chkVerrouillageTempsProjet, "Permet de faire les retours de marchandise");
            this.chkVerrouillageTempsProjet.UseVisualStyleBackColor = true;
            // 
            // chkPunchSemaineAnterieure
            // 
            this.chkPunchSemaineAnterieure.AutoSize = true;
            this.chkPunchSemaineAnterieure.BackColor = System.Drawing.Color.Black;
            this.chkPunchSemaineAnterieure.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPunchSemaineAnterieure.ForeColor = System.Drawing.Color.White;
            this.chkPunchSemaineAnterieure.Location = new System.Drawing.Point(184, 216);
            this.chkPunchSemaineAnterieure.Name = "chkPunchSemaineAnterieure";
            this.chkPunchSemaineAnterieure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPunchSemaineAnterieure.Size = new System.Drawing.Size(206, 18);
            this.chkPunchSemaineAnterieure.TabIndex = 54;
            this.chkPunchSemaineAnterieure.Text = "Punchs dans une semaine antérieure";
            this.ToolTip1.SetToolTip(this.chkPunchSemaineAnterieure, "Permet de faire les retours de marchandise");
            this.chkPunchSemaineAnterieure.UseVisualStyleBackColor = true;
            // 
            // chkMailingList
            // 
            this.chkMailingList.AutoSize = true;
            this.chkMailingList.BackColor = System.Drawing.Color.Black;
            this.chkMailingList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMailingList.ForeColor = System.Drawing.Color.White;
            this.chkMailingList.Location = new System.Drawing.Point(184, 192);
            this.chkMailingList.Name = "chkMailingList";
            this.chkMailingList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkMailingList.Size = new System.Drawing.Size(165, 18);
            this.chkMailingList.TabIndex = 47;
            this.chkMailingList.Text = "Liste de distribution Outlook";
            this.ToolTip1.SetToolTip(this.chkMailingList, "Permet de faire les retours de marchandise");
            this.chkMailingList.UseVisualStyleBackColor = true;
            // 
            // chkRetourMarchandise
            // 
            this.chkRetourMarchandise.AutoSize = true;
            this.chkRetourMarchandise.BackColor = System.Drawing.Color.Black;
            this.chkRetourMarchandise.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRetourMarchandise.ForeColor = System.Drawing.Color.White;
            this.chkRetourMarchandise.Location = new System.Drawing.Point(184, 168);
            this.chkRetourMarchandise.Name = "chkRetourMarchandise";
            this.chkRetourMarchandise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRetourMarchandise.Size = new System.Drawing.Size(140, 18);
            this.chkRetourMarchandise.TabIndex = 45;
            this.chkRetourMarchandise.Text = "Retour de marchandise";
            this.ToolTip1.SetToolTip(this.chkRetourMarchandise, "Permet de faire les retours de marchandise");
            this.chkRetourMarchandise.UseVisualStyleBackColor = true;
            // 
            // chkReception
            // 
            this.chkReception.AutoSize = true;
            this.chkReception.BackColor = System.Drawing.Color.Black;
            this.chkReception.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReception.ForeColor = System.Drawing.Color.White;
            this.chkReception.Location = new System.Drawing.Point(184, 144);
            this.chkReception.Name = "chkReception";
            this.chkReception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkReception.Size = new System.Drawing.Size(75, 18);
            this.chkReception.TabIndex = 43;
            this.chkReception.Text = "Réception";
            this.ToolTip1.SetToolTip(this.chkReception, "Permet de faire la réception de marchandise");
            this.chkReception.UseVisualStyleBackColor = true;
            // 
            // chkSupprimerProjets
            // 
            this.chkSupprimerProjets.AutoSize = true;
            this.chkSupprimerProjets.BackColor = System.Drawing.Color.Black;
            this.chkSupprimerProjets.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSupprimerProjets.ForeColor = System.Drawing.Color.White;
            this.chkSupprimerProjets.Location = new System.Drawing.Point(184, 120);
            this.chkSupprimerProjets.Name = "chkSupprimerProjets";
            this.chkSupprimerProjets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSupprimerProjets.Size = new System.Drawing.Size(137, 18);
            this.chkSupprimerProjets.TabIndex = 41;
            this.chkSupprimerProjets.Text = "Suppression de projets";
            this.ToolTip1.SetToolTip(this.chkSupprimerProjets, "Permet de supprimer les projets");
            this.chkSupprimerProjets.UseVisualStyleBackColor = true;
            // 
            // chkModificationPunchEmployes
            // 
            this.chkModificationPunchEmployes.AutoSize = true;
            this.chkModificationPunchEmployes.BackColor = System.Drawing.Color.Black;
            this.chkModificationPunchEmployes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationPunchEmployes.ForeColor = System.Drawing.Color.White;
            this.chkModificationPunchEmployes.Location = new System.Drawing.Point(8, 240);
            this.chkModificationPunchEmployes.Name = "chkModificationPunchEmployes";
            this.chkModificationPunchEmployes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationPunchEmployes.Size = new System.Drawing.Size(106, 18);
            this.chkModificationPunchEmployes.TabIndex = 44;
            this.chkModificationPunchEmployes.Text = "Punch employés";
            this.ToolTip1.SetToolTip(this.chkModificationPunchEmployes, "Permet de modifier la liste des employés pour qui on peut puncher");
            this.chkModificationPunchEmployes.UseVisualStyleBackColor = true;
            // 
            // chkModificationInventaireMec
            // 
            this.chkModificationInventaireMec.AutoSize = true;
            this.chkModificationInventaireMec.BackColor = System.Drawing.Color.Black;
            this.chkModificationInventaireMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationInventaireMec.ForeColor = System.Drawing.Color.White;
            this.chkModificationInventaireMec.Location = new System.Drawing.Point(8, 264);
            this.chkModificationInventaireMec.Name = "chkModificationInventaireMec";
            this.chkModificationInventaireMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationInventaireMec.Size = new System.Drawing.Size(133, 18);
            this.chkModificationInventaireMec.TabIndex = 46;
            this.chkModificationInventaireMec.Text = "Inventaire mécanique";
            this.ToolTip1.SetToolTip(this.chkModificationInventaireMec, "Modification de l\'inventaire mécanique");
            this.chkModificationInventaireMec.UseVisualStyleBackColor = true;
            // 
            // chkModificationInventaireElec
            // 
            this.chkModificationInventaireElec.AutoSize = true;
            this.chkModificationInventaireElec.BackColor = System.Drawing.Color.Black;
            this.chkModificationInventaireElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationInventaireElec.ForeColor = System.Drawing.Color.White;
            this.chkModificationInventaireElec.Location = new System.Drawing.Point(184, 24);
            this.chkModificationInventaireElec.Name = "chkModificationInventaireElec";
            this.chkModificationInventaireElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationInventaireElec.Size = new System.Drawing.Size(128, 18);
            this.chkModificationInventaireElec.TabIndex = 32;
            this.chkModificationInventaireElec.Text = "Inventaire électrique";
            this.ToolTip1.SetToolTip(this.chkModificationInventaireElec, "Modification de l\'inventaire électrique");
            this.chkModificationInventaireElec.UseVisualStyleBackColor = true;
            // 
            // chkModificationCatalogueElec
            // 
            this.chkModificationCatalogueElec.AutoSize = true;
            this.chkModificationCatalogueElec.BackColor = System.Drawing.Color.Black;
            this.chkModificationCatalogueElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationCatalogueElec.ForeColor = System.Drawing.Color.White;
            this.chkModificationCatalogueElec.Location = new System.Drawing.Point(184, 48);
            this.chkModificationCatalogueElec.Name = "chkModificationCatalogueElec";
            this.chkModificationCatalogueElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationCatalogueElec.Size = new System.Drawing.Size(127, 18);
            this.chkModificationCatalogueElec.TabIndex = 35;
            this.chkModificationCatalogueElec.Text = "Catalogue électrique";
            this.ToolTip1.SetToolTip(this.chkModificationCatalogueElec, "Modication du catalogue électrique");
            this.chkModificationCatalogueElec.UseVisualStyleBackColor = true;
            // 
            // chkModificationCatalogueMec
            // 
            this.chkModificationCatalogueMec.AutoSize = true;
            this.chkModificationCatalogueMec.BackColor = System.Drawing.Color.Black;
            this.chkModificationCatalogueMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationCatalogueMec.ForeColor = System.Drawing.Color.White;
            this.chkModificationCatalogueMec.Location = new System.Drawing.Point(8, 288);
            this.chkModificationCatalogueMec.Name = "chkModificationCatalogueMec";
            this.chkModificationCatalogueMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationCatalogueMec.Size = new System.Drawing.Size(132, 18);
            this.chkModificationCatalogueMec.TabIndex = 27;
            this.chkModificationCatalogueMec.Text = "Catalogue mécanique";
            this.ToolTip1.SetToolTip(this.chkModificationCatalogueMec, "Modification du catalogue mécanique");
            this.chkModificationCatalogueMec.UseVisualStyleBackColor = true;
            // 
            // chkModificationBonsCommandes
            // 
            this.chkModificationBonsCommandes.AutoSize = true;
            this.chkModificationBonsCommandes.BackColor = System.Drawing.Color.Black;
            this.chkModificationBonsCommandes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationBonsCommandes.ForeColor = System.Drawing.Color.White;
            this.chkModificationBonsCommandes.Location = new System.Drawing.Point(8, 216);
            this.chkModificationBonsCommandes.Name = "chkModificationBonsCommandes";
            this.chkModificationBonsCommandes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationBonsCommandes.Size = new System.Drawing.Size(128, 18);
            this.chkModificationBonsCommandes.TabIndex = 42;
            this.chkModificationBonsCommandes.Text = "Bons de commandes";
            this.ToolTip1.SetToolTip(this.chkModificationBonsCommandes, "Modification des bons de commandes");
            this.chkModificationBonsCommandes.UseVisualStyleBackColor = true;
            // 
            // chkModificationSoumissionElec
            // 
            this.chkModificationSoumissionElec.AutoSize = true;
            this.chkModificationSoumissionElec.BackColor = System.Drawing.Color.Black;
            this.chkModificationSoumissionElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationSoumissionElec.ForeColor = System.Drawing.Color.White;
            this.chkModificationSoumissionElec.Location = new System.Drawing.Point(184, 72);
            this.chkModificationSoumissionElec.Name = "chkModificationSoumissionElec";
            this.chkModificationSoumissionElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationSoumissionElec.Size = new System.Drawing.Size(144, 18);
            this.chkModificationSoumissionElec.TabIndex = 37;
            this.chkModificationSoumissionElec.Text = "Soumissions électriques";
            this.ToolTip1.SetToolTip(this.chkModificationSoumissionElec, "Modification des soumissions électriques");
            this.chkModificationSoumissionElec.UseVisualStyleBackColor = true;
            // 
            // chkModificationProjetElec
            // 
            this.chkModificationProjetElec.AutoSize = true;
            this.chkModificationProjetElec.BackColor = System.Drawing.Color.Black;
            this.chkModificationProjetElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationProjetElec.ForeColor = System.Drawing.Color.White;
            this.chkModificationProjetElec.Location = new System.Drawing.Point(184, 96);
            this.chkModificationProjetElec.Name = "chkModificationProjetElec";
            this.chkModificationProjetElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationProjetElec.Size = new System.Drawing.Size(117, 18);
            this.chkModificationProjetElec.TabIndex = 39;
            this.chkModificationProjetElec.Text = "Projets électriques";
            this.ToolTip1.SetToolTip(this.chkModificationProjetElec, "Modification  électriques");
            this.chkModificationProjetElec.UseVisualStyleBackColor = true;
            // 
            // chkModificationProjetMec
            // 
            this.chkModificationProjetMec.AutoSize = true;
            this.chkModificationProjetMec.BackColor = System.Drawing.Color.Black;
            this.chkModificationProjetMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationProjetMec.ForeColor = System.Drawing.Color.White;
            this.chkModificationProjetMec.Location = new System.Drawing.Point(8, 336);
            this.chkModificationProjetMec.Name = "chkModificationProjetMec";
            this.chkModificationProjetMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationProjetMec.Size = new System.Drawing.Size(122, 18);
            this.chkModificationProjetMec.TabIndex = 31;
            this.chkModificationProjetMec.Text = "Projets mécaniques";
            this.ToolTip1.SetToolTip(this.chkModificationProjetMec, "Modification  mécaniques");
            this.chkModificationProjetMec.UseVisualStyleBackColor = true;
            // 
            // chkModificationSoumissionMec
            // 
            this.chkModificationSoumissionMec.AutoSize = true;
            this.chkModificationSoumissionMec.BackColor = System.Drawing.Color.Black;
            this.chkModificationSoumissionMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationSoumissionMec.ForeColor = System.Drawing.Color.White;
            this.chkModificationSoumissionMec.Location = new System.Drawing.Point(8, 312);
            this.chkModificationSoumissionMec.Name = "chkModificationSoumissionMec";
            this.chkModificationSoumissionMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationSoumissionMec.Size = new System.Drawing.Size(149, 18);
            this.chkModificationSoumissionMec.TabIndex = 28;
            this.chkModificationSoumissionMec.Text = "Soumissions mécaniques";
            this.ToolTip1.SetToolTip(this.chkModificationSoumissionMec, "Modification des soumissions mécaniques mécaniques");
            this.chkModificationSoumissionMec.UseVisualStyleBackColor = true;
            // 
            // chkModificationFacturation
            // 
            this.chkModificationFacturation.AutoSize = true;
            this.chkModificationFacturation.BackColor = System.Drawing.Color.Black;
            this.chkModificationFacturation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationFacturation.ForeColor = System.Drawing.Color.White;
            this.chkModificationFacturation.Location = new System.Drawing.Point(8, 192);
            this.chkModificationFacturation.Name = "chkModificationFacturation";
            this.chkModificationFacturation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationFacturation.Size = new System.Drawing.Size(82, 18);
            this.chkModificationFacturation.TabIndex = 40;
            this.chkModificationFacturation.Text = "Facturation";
            this.ToolTip1.SetToolTip(this.chkModificationFacturation, "Modification de la facturation");
            this.chkModificationFacturation.UseVisualStyleBackColor = true;
            // 
            // chkModificationOutils
            // 
            this.chkModificationOutils.AutoSize = true;
            this.chkModificationOutils.BackColor = System.Drawing.Color.Black;
            this.chkModificationOutils.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationOutils.ForeColor = System.Drawing.Color.White;
            this.chkModificationOutils.Location = new System.Drawing.Point(8, 168);
            this.chkModificationOutils.Name = "chkModificationOutils";
            this.chkModificationOutils.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationOutils.Size = new System.Drawing.Size(126, 18);
            this.chkModificationOutils.TabIndex = 38;
            this.chkModificationOutils.Text = "Outils et machinerie";
            this.ToolTip1.SetToolTip(this.chkModificationOutils, "Modification des outils et machinerie");
            this.chkModificationOutils.UseVisualStyleBackColor = true;
            // 
            // chkModificationFeuillesTemps
            // 
            this.chkModificationFeuillesTemps.AutoSize = true;
            this.chkModificationFeuillesTemps.BackColor = System.Drawing.Color.Black;
            this.chkModificationFeuillesTemps.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationFeuillesTemps.ForeColor = System.Drawing.Color.White;
            this.chkModificationFeuillesTemps.Location = new System.Drawing.Point(8, 144);
            this.chkModificationFeuillesTemps.Name = "chkModificationFeuillesTemps";
            this.chkModificationFeuillesTemps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationFeuillesTemps.Size = new System.Drawing.Size(113, 18);
            this.chkModificationFeuillesTemps.TabIndex = 36;
            this.chkModificationFeuillesTemps.Text = "Feuilles de temps";
            this.ToolTip1.SetToolTip(this.chkModificationFeuillesTemps, "Modification des feuilles de temps");
            this.chkModificationFeuillesTemps.UseVisualStyleBackColor = true;
            // 
            // chkModificationGroupes
            // 
            this.chkModificationGroupes.AutoSize = true;
            this.chkModificationGroupes.BackColor = System.Drawing.Color.Black;
            this.chkModificationGroupes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationGroupes.ForeColor = System.Drawing.Color.White;
            this.chkModificationGroupes.Location = new System.Drawing.Point(8, 120);
            this.chkModificationGroupes.Name = "chkModificationGroupes";
            this.chkModificationGroupes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationGroupes.Size = new System.Drawing.Size(124, 18);
            this.chkModificationGroupes.TabIndex = 34;
            this.chkModificationGroupes.Text = "Groupes de sécurité";
            this.ToolTip1.SetToolTip(this.chkModificationGroupes, "Modification des groupes de sécurité");
            this.chkModificationGroupes.UseVisualStyleBackColor = true;
            // 
            // chkModificationEmployes
            // 
            this.chkModificationEmployes.AutoSize = true;
            this.chkModificationEmployes.BackColor = System.Drawing.Color.Black;
            this.chkModificationEmployes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationEmployes.ForeColor = System.Drawing.Color.White;
            this.chkModificationEmployes.Location = new System.Drawing.Point(8, 96);
            this.chkModificationEmployes.Name = "chkModificationEmployes";
            this.chkModificationEmployes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationEmployes.Size = new System.Drawing.Size(74, 18);
            this.chkModificationEmployes.TabIndex = 33;
            this.chkModificationEmployes.Text = "Employés";
            this.ToolTip1.SetToolTip(this.chkModificationEmployes, "Modification des employés");
            this.chkModificationEmployes.UseVisualStyleBackColor = true;
            // 
            // chkModificationContacts
            // 
            this.chkModificationContacts.AutoSize = true;
            this.chkModificationContacts.BackColor = System.Drawing.Color.Black;
            this.chkModificationContacts.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationContacts.ForeColor = System.Drawing.Color.White;
            this.chkModificationContacts.Location = new System.Drawing.Point(8, 72);
            this.chkModificationContacts.Name = "chkModificationContacts";
            this.chkModificationContacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationContacts.Size = new System.Drawing.Size(68, 18);
            this.chkModificationContacts.TabIndex = 30;
            this.chkModificationContacts.Text = "Contacts";
            this.ToolTip1.SetToolTip(this.chkModificationContacts, "Modification");
            this.chkModificationContacts.UseVisualStyleBackColor = true;
            // 
            // chkModificationFRS
            // 
            this.chkModificationFRS.AutoSize = true;
            this.chkModificationFRS.BackColor = System.Drawing.Color.Black;
            this.chkModificationFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationFRS.ForeColor = System.Drawing.Color.White;
            this.chkModificationFRS.Location = new System.Drawing.Point(8, 48);
            this.chkModificationFRS.Name = "chkModificationFRS";
            this.chkModificationFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationFRS.Size = new System.Drawing.Size(88, 18);
            this.chkModificationFRS.TabIndex = 29;
            this.chkModificationFRS.Text = "Fournisseurs";
            this.ToolTip1.SetToolTip(this.chkModificationFRS, "Modification des fournisseurs");
            this.chkModificationFRS.UseVisualStyleBackColor = true;
            // 
            // chkModificationClients
            // 
            this.chkModificationClients.AutoSize = true;
            this.chkModificationClients.BackColor = System.Drawing.Color.Black;
            this.chkModificationClients.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificationClients.ForeColor = System.Drawing.Color.White;
            this.chkModificationClients.Location = new System.Drawing.Point(8, 24);
            this.chkModificationClients.Name = "chkModificationClients";
            this.chkModificationClients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkModificationClients.Size = new System.Drawing.Size(59, 18);
            this.chkModificationClients.TabIndex = 26;
            this.chkModificationClients.Text = "Clients";
            this.ToolTip1.SetToolTip(this.chkModificationClients, "Modification des clients");
            this.chkModificationClients.UseVisualStyleBackColor = true;
            // 
            // chkAchat
            // 
            this.chkAchat.AutoSize = true;
            this.chkAchat.BackColor = System.Drawing.Color.Black;
            this.chkAchat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAchat.ForeColor = System.Drawing.Color.White;
            this.chkAchat.Location = new System.Drawing.Point(184, 120);
            this.chkAchat.Name = "chkAchat";
            this.chkAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAchat.Size = new System.Drawing.Size(59, 18);
            this.chkAchat.TabIndex = 23;
            this.chkAchat.Text = "Achats";
            this.ToolTip1.SetToolTip(this.chkAchat, "Affichage des achats");
            this.chkAchat.UseVisualStyleBackColor = true;
            // 
            // chkInventaireMec
            // 
            this.chkInventaireMec.AutoSize = true;
            this.chkInventaireMec.BackColor = System.Drawing.Color.Black;
            this.chkInventaireMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInventaireMec.ForeColor = System.Drawing.Color.White;
            this.chkInventaireMec.Location = new System.Drawing.Point(8, 264);
            this.chkInventaireMec.Name = "chkInventaireMec";
            this.chkInventaireMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkInventaireMec.Size = new System.Drawing.Size(133, 18);
            this.chkInventaireMec.TabIndex = 7;
            this.chkInventaireMec.Text = "Inventaire mécanique";
            this.ToolTip1.SetToolTip(this.chkInventaireMec, "Affichage de l\'inventaire mécanique");
            this.chkInventaireMec.UseVisualStyleBackColor = true;
            this.chkInventaireMec.CheckStateChanged += new System.EventHandler(this.chkInventaireMec_CheckStateChanged);
            // 
            // chkInventaireElec
            // 
            this.chkInventaireElec.AutoSize = true;
            this.chkInventaireElec.BackColor = System.Drawing.Color.Black;
            this.chkInventaireElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInventaireElec.ForeColor = System.Drawing.Color.White;
            this.chkInventaireElec.Location = new System.Drawing.Point(183, 24);
            this.chkInventaireElec.Name = "chkInventaireElec";
            this.chkInventaireElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkInventaireElec.Size = new System.Drawing.Size(128, 18);
            this.chkInventaireElec.TabIndex = 15;
            this.chkInventaireElec.Text = "Inventaire électrique";
            this.ToolTip1.SetToolTip(this.chkInventaireElec, "Affichage de l\'inventaire électrique");
            this.chkInventaireElec.UseVisualStyleBackColor = true;
            this.chkInventaireElec.CheckStateChanged += new System.EventHandler(this.chkInventaireElec_CheckStateChanged);
            // 
            // chkCatalogueElec
            // 
            this.chkCatalogueElec.AutoSize = true;
            this.chkCatalogueElec.BackColor = System.Drawing.Color.Black;
            this.chkCatalogueElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCatalogueElec.ForeColor = System.Drawing.Color.White;
            this.chkCatalogueElec.Location = new System.Drawing.Point(184, 48);
            this.chkCatalogueElec.Name = "chkCatalogueElec";
            this.chkCatalogueElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCatalogueElec.Size = new System.Drawing.Size(127, 18);
            this.chkCatalogueElec.TabIndex = 17;
            this.chkCatalogueElec.Text = "Catalogue électrique";
            this.ToolTip1.SetToolTip(this.chkCatalogueElec, "Affichage du catalogue électrique");
            this.chkCatalogueElec.UseVisualStyleBackColor = true;
            this.chkCatalogueElec.CheckStateChanged += new System.EventHandler(this.chkCatalogueElec_CheckStateChanged);
            // 
            // chkSoumissionElec
            // 
            this.chkSoumissionElec.AutoSize = true;
            this.chkSoumissionElec.BackColor = System.Drawing.Color.Black;
            this.chkSoumissionElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoumissionElec.ForeColor = System.Drawing.Color.White;
            this.chkSoumissionElec.Location = new System.Drawing.Point(184, 72);
            this.chkSoumissionElec.Name = "chkSoumissionElec";
            this.chkSoumissionElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSoumissionElec.Size = new System.Drawing.Size(144, 18);
            this.chkSoumissionElec.TabIndex = 19;
            this.chkSoumissionElec.Text = "Soumissions électriques";
            this.ToolTip1.SetToolTip(this.chkSoumissionElec, "Affichage des soumissions électriques");
            this.chkSoumissionElec.UseVisualStyleBackColor = true;
            this.chkSoumissionElec.CheckStateChanged += new System.EventHandler(this.chkSoumissionElec_CheckStateChanged);
            // 
            // chkProjetElec
            // 
            this.chkProjetElec.AutoSize = true;
            this.chkProjetElec.BackColor = System.Drawing.Color.Black;
            this.chkProjetElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProjetElec.ForeColor = System.Drawing.Color.White;
            this.chkProjetElec.Location = new System.Drawing.Point(184, 96);
            this.chkProjetElec.Name = "chkProjetElec";
            this.chkProjetElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkProjetElec.Size = new System.Drawing.Size(117, 18);
            this.chkProjetElec.TabIndex = 21;
            this.chkProjetElec.Text = "Projets électriques";
            this.ToolTip1.SetToolTip(this.chkProjetElec, "Affichage  électriques");
            this.chkProjetElec.UseVisualStyleBackColor = true;
            this.chkProjetElec.CheckStateChanged += new System.EventHandler(this.chkProjetElec_CheckStateChanged);
            // 
            // chkProjetMec
            // 
            this.chkProjetMec.AutoSize = true;
            this.chkProjetMec.BackColor = System.Drawing.Color.Black;
            this.chkProjetMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProjetMec.ForeColor = System.Drawing.Color.White;
            this.chkProjetMec.Location = new System.Drawing.Point(8, 336);
            this.chkProjetMec.Name = "chkProjetMec";
            this.chkProjetMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkProjetMec.Size = new System.Drawing.Size(122, 18);
            this.chkProjetMec.TabIndex = 13;
            this.chkProjetMec.Text = "Projets mécaniques";
            this.ToolTip1.SetToolTip(this.chkProjetMec, "Affichage  mécaniques");
            this.chkProjetMec.UseVisualStyleBackColor = true;
            this.chkProjetMec.CheckStateChanged += new System.EventHandler(this.chkProjetMec_CheckStateChanged);
            // 
            // chkSoumissionMec
            // 
            this.chkSoumissionMec.AutoSize = true;
            this.chkSoumissionMec.BackColor = System.Drawing.Color.Black;
            this.chkSoumissionMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoumissionMec.ForeColor = System.Drawing.Color.White;
            this.chkSoumissionMec.Location = new System.Drawing.Point(8, 312);
            this.chkSoumissionMec.Name = "chkSoumissionMec";
            this.chkSoumissionMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSoumissionMec.Size = new System.Drawing.Size(149, 18);
            this.chkSoumissionMec.TabIndex = 11;
            this.chkSoumissionMec.Text = "Soumissions mécaniques";
            this.ToolTip1.SetToolTip(this.chkSoumissionMec, "Affichage des soumissions mécaniques");
            this.chkSoumissionMec.UseVisualStyleBackColor = true;
            this.chkSoumissionMec.CheckStateChanged += new System.EventHandler(this.chkSoumissionMec_CheckStateChanged);
            // 
            // chkOutils
            // 
            this.chkOutils.AutoSize = true;
            this.chkOutils.BackColor = System.Drawing.Color.Black;
            this.chkOutils.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOutils.ForeColor = System.Drawing.Color.White;
            this.chkOutils.Location = new System.Drawing.Point(8, 240);
            this.chkOutils.Name = "chkOutils";
            this.chkOutils.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkOutils.Size = new System.Drawing.Size(122, 18);
            this.chkOutils.TabIndex = 24;
            this.chkOutils.Text = "Outils entrée-sortie";
            this.ToolTip1.SetToolTip(this.chkOutils, "Affichage du magasin");
            this.chkOutils.UseVisualStyleBackColor = true;
            this.chkOutils.CheckStateChanged += new System.EventHandler(this.chkOutils_CheckStateChanged);
            // 
            // chkPunch
            // 
            this.chkPunch.AutoSize = true;
            this.chkPunch.BackColor = System.Drawing.Color.Black;
            this.chkPunch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPunch.ForeColor = System.Drawing.Color.White;
            this.chkPunch.Location = new System.Drawing.Point(8, 216);
            this.chkPunch.Name = "chkPunch";
            this.chkPunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPunch.Size = new System.Drawing.Size(55, 18);
            this.chkPunch.TabIndex = 22;
            this.chkPunch.Text = "Punch";
            this.ToolTip1.SetToolTip(this.chkPunch, "Affichage du punch");
            this.chkPunch.UseVisualStyleBackColor = true;
            this.chkPunch.CheckStateChanged += new System.EventHandler(this.chkPunch_CheckStateChanged);
            // 
            // chkConfiguration
            // 
            this.chkConfiguration.AutoSize = true;
            this.chkConfiguration.BackColor = System.Drawing.Color.Black;
            this.chkConfiguration.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfiguration.ForeColor = System.Drawing.Color.White;
            this.chkConfiguration.Location = new System.Drawing.Point(8, 192);
            this.chkConfiguration.Name = "chkConfiguration";
            this.chkConfiguration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkConfiguration.Size = new System.Drawing.Size(92, 18);
            this.chkConfiguration.TabIndex = 20;
            this.chkConfiguration.Text = "Configuration";
            this.ToolTip1.SetToolTip(this.chkConfiguration, "Affichage de la configuration");
            this.chkConfiguration.UseVisualStyleBackColor = true;
            // 
            // chkCedule
            // 
            this.chkCedule.AutoSize = true;
            this.chkCedule.BackColor = System.Drawing.Color.Black;
            this.chkCedule.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCedule.ForeColor = System.Drawing.Color.White;
            this.chkCedule.Location = new System.Drawing.Point(8, 168);
            this.chkCedule.Name = "chkCedule";
            this.chkCedule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCedule.Size = new System.Drawing.Size(59, 18);
            this.chkCedule.TabIndex = 18;
            this.chkCedule.Text = "Cedule";
            this.ToolTip1.SetToolTip(this.chkCedule, "Affichage de la cédule");
            this.chkCedule.UseVisualStyleBackColor = true;
            // 
            // chkEmployes
            // 
            this.chkEmployes.AutoSize = true;
            this.chkEmployes.BackColor = System.Drawing.Color.Black;
            this.chkEmployes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmployes.ForeColor = System.Drawing.Color.White;
            this.chkEmployes.Location = new System.Drawing.Point(8, 144);
            this.chkEmployes.Name = "chkEmployes";
            this.chkEmployes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkEmployes.Size = new System.Drawing.Size(74, 18);
            this.chkEmployes.TabIndex = 16;
            this.chkEmployes.Text = "Employés";
            this.ToolTip1.SetToolTip(this.chkEmployes, "Affichage des employés");
            this.chkEmployes.UseVisualStyleBackColor = true;
            this.chkEmployes.CheckStateChanged += new System.EventHandler(this.chkEmployes_CheckStateChanged);
            // 
            // chkCatalogueMec
            // 
            this.chkCatalogueMec.AutoSize = true;
            this.chkCatalogueMec.BackColor = System.Drawing.Color.Black;
            this.chkCatalogueMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCatalogueMec.ForeColor = System.Drawing.Color.White;
            this.chkCatalogueMec.Location = new System.Drawing.Point(8, 288);
            this.chkCatalogueMec.Name = "chkCatalogueMec";
            this.chkCatalogueMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCatalogueMec.Size = new System.Drawing.Size(132, 18);
            this.chkCatalogueMec.TabIndex = 9;
            this.chkCatalogueMec.Text = "Catalogue mécanique";
            this.ToolTip1.SetToolTip(this.chkCatalogueMec, "Affichage du catalogue mécaniqe");
            this.chkCatalogueMec.UseVisualStyleBackColor = true;
            this.chkCatalogueMec.CheckStateChanged += new System.EventHandler(this.chkCatalogueMec_CheckStateChanged);
            // 
            // chkRapports
            // 
            this.chkRapports.AutoSize = true;
            this.chkRapports.BackColor = System.Drawing.Color.Black;
            this.chkRapports.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRapports.ForeColor = System.Drawing.Color.White;
            this.chkRapports.Location = new System.Drawing.Point(8, 120);
            this.chkRapports.Name = "chkRapports";
            this.chkRapports.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRapports.Size = new System.Drawing.Size(70, 18);
            this.chkRapports.TabIndex = 14;
            this.chkRapports.Text = "Rapports";
            this.ToolTip1.SetToolTip(this.chkRapports, "Affichage des rapports");
            this.chkRapports.UseVisualStyleBackColor = true;
            // 
            // chkContactsVendeurs
            // 
            this.chkContactsVendeurs.AutoSize = true;
            this.chkContactsVendeurs.BackColor = System.Drawing.Color.Black;
            this.chkContactsVendeurs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContactsVendeurs.ForeColor = System.Drawing.Color.White;
            this.chkContactsVendeurs.Location = new System.Drawing.Point(8, 96);
            this.chkContactsVendeurs.Name = "chkContactsVendeurs";
            this.chkContactsVendeurs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkContactsVendeurs.Size = new System.Drawing.Size(136, 18);
            this.chkContactsVendeurs.TabIndex = 12;
            this.chkContactsVendeurs.Text = "Contacts pour vendeur";
            this.ToolTip1.SetToolTip(this.chkContactsVendeurs, "Affichage pour les vendeurs");
            this.chkContactsVendeurs.UseVisualStyleBackColor = true;
            // 
            // chkContacts
            // 
            this.chkContacts.AutoSize = true;
            this.chkContacts.BackColor = System.Drawing.Color.Black;
            this.chkContacts.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContacts.ForeColor = System.Drawing.Color.White;
            this.chkContacts.Location = new System.Drawing.Point(8, 72);
            this.chkContacts.Name = "chkContacts";
            this.chkContacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkContacts.Size = new System.Drawing.Size(68, 18);
            this.chkContacts.TabIndex = 10;
            this.chkContacts.Text = "Contacts";
            this.ToolTip1.SetToolTip(this.chkContacts, "Affichage");
            this.chkContacts.UseVisualStyleBackColor = true;
            this.chkContacts.CheckStateChanged += new System.EventHandler(this.chkContacts_CheckStateChanged);
            // 
            // chkFournisseurs
            // 
            this.chkFournisseurs.AutoSize = true;
            this.chkFournisseurs.BackColor = System.Drawing.Color.Black;
            this.chkFournisseurs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFournisseurs.ForeColor = System.Drawing.Color.White;
            this.chkFournisseurs.Location = new System.Drawing.Point(8, 48);
            this.chkFournisseurs.Name = "chkFournisseurs";
            this.chkFournisseurs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFournisseurs.Size = new System.Drawing.Size(88, 18);
            this.chkFournisseurs.TabIndex = 8;
            this.chkFournisseurs.Text = "Fournisseurs";
            this.ToolTip1.SetToolTip(this.chkFournisseurs, "Affichage des fournisseurs");
            this.chkFournisseurs.UseVisualStyleBackColor = true;
            this.chkFournisseurs.CheckStateChanged += new System.EventHandler(this.chkFournisseurs_CheckStateChanged);
            // 
            // chkClients
            // 
            this.chkClients.AutoSize = true;
            this.chkClients.BackColor = System.Drawing.Color.Black;
            this.chkClients.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClients.ForeColor = System.Drawing.Color.White;
            this.chkClients.Location = new System.Drawing.Point(8, 24);
            this.chkClients.Name = "chkClients";
            this.chkClients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkClients.Size = new System.Drawing.Size(59, 18);
            this.chkClients.TabIndex = 6;
            this.chkClients.Text = "Clients";
            this.ToolTip1.SetToolTip(this.chkClients, "Affichage des clients");
            this.chkClients.UseVisualStyleBackColor = true;
            this.chkClients.CheckStateChanged += new System.EventHandler(this.chkClients_CheckStateChanged);
            // 
            // lstUser
            // 
            this.lstUser.BackColor = System.Drawing.Color.Black;
            this.lstUser.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUser.ForeColor = System.Drawing.Color.White;
            this.lstUser.ItemHeight = 14;
            this.lstUser.Location = new System.Drawing.Point(215, 67);
            this.lstUser.Name = "lstUser";
            this.lstUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstUser.ScrollAlwaysVisible = true;
            this.lstUser.Size = new System.Drawing.Size(521, 46);
            this.lstUser.TabIndex = 4;
            // 
            // cmdFermer
            // 
            this.cmdFermer.AutoSize = true;
            this.cmdFermer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdFermer.BackColor = System.Drawing.Color.Black;
            this.cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermer.ForeColor = System.Drawing.Color.White;
            this.cmdFermer.Location = new System.Drawing.Point(679, 532);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFermer.Size = new System.Drawing.Size(57, 23);
            this.cmdFermer.TabIndex = 53;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.AutoSize = true;
            this.cmdSupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSupprimer.BackColor = System.Drawing.Color.Black;
            this.cmdSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSupprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupprimer.ForeColor = System.Drawing.Color.White;
            this.cmdSupprimer.Location = new System.Drawing.Point(543, 532);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSupprimer.Size = new System.Drawing.Size(72, 23);
            this.cmdSupprimer.TabIndex = 50;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.AutoSize = true;
            this.cmdModifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdModifier.BackColor = System.Drawing.Color.Black;
            this.cmdModifier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdModifier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModifier.ForeColor = System.Drawing.Color.White;
            this.cmdModifier.Location = new System.Drawing.Point(615, 532);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdModifier.Size = new System.Drawing.Size(63, 23);
            this.cmdModifier.TabIndex = 52;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.AutoSize = true;
            this.cmdAjouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAjouter.BackColor = System.Drawing.Color.Black;
            this.cmdAjouter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAjouter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjouter.ForeColor = System.Drawing.Color.White;
            this.cmdAjouter.Location = new System.Drawing.Point(488, 532);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAjouter.Size = new System.Drawing.Size(57, 23);
            this.cmdAjouter.TabIndex = 49;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // fraModification
            // 
            this.fraModification.BackColor = System.Drawing.Color.Black;
            this.fraModification.Controls.Add(this.chkDeverrouillageTempsProjet);
            this.fraModification.Controls.Add(this.chkVerrouillageTempsProjet);
            this.fraModification.Controls.Add(this.chkPunchSemaineAnterieure);
            this.fraModification.Controls.Add(this.chkMailingList);
            this.fraModification.Controls.Add(this.chkRetourMarchandise);
            this.fraModification.Controls.Add(this.chkReception);
            this.fraModification.Controls.Add(this.chkSupprimerProjets);
            this.fraModification.Controls.Add(this.chkModificationPunchEmployes);
            this.fraModification.Controls.Add(this.chkModificationInventaireMec);
            this.fraModification.Controls.Add(this.chkModificationInventaireElec);
            this.fraModification.Controls.Add(this.chkModificationCatalogueElec);
            this.fraModification.Controls.Add(this.chkModificationCatalogueMec);
            this.fraModification.Controls.Add(this.chkModificationBonsCommandes);
            this.fraModification.Controls.Add(this.chkModificationSoumissionElec);
            this.fraModification.Controls.Add(this.chkModificationProjetElec);
            this.fraModification.Controls.Add(this.chkModificationProjetMec);
            this.fraModification.Controls.Add(this.chkModificationSoumissionMec);
            this.fraModification.Controls.Add(this.chkModificationFacturation);
            this.fraModification.Controls.Add(this.chkModificationOutils);
            this.fraModification.Controls.Add(this.chkModificationFeuillesTemps);
            this.fraModification.Controls.Add(this.chkModificationGroupes);
            this.fraModification.Controls.Add(this.chkModificationEmployes);
            this.fraModification.Controls.Add(this.chkModificationContacts);
            this.fraModification.Controls.Add(this.chkModificationFRS);
            this.fraModification.Controls.Add(this.chkModificationClients);
            this.fraModification.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraModification.ForeColor = System.Drawing.Color.White;
            this.fraModification.Location = new System.Drawing.Point(343, 145);
            this.fraModification.Name = "fraModification";
            this.fraModification.Padding = new System.Windows.Forms.Padding(0);
            this.fraModification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraModification.Size = new System.Drawing.Size(393, 361);
            this.fraModification.TabIndex = 25;
            this.fraModification.TabStop = false;
            this.fraModification.Text = "Modification";
            // 
            // cmbGroupe
            // 
            this.cmbGroupe.BackColor = System.Drawing.Color.Black;
            this.cmbGroupe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGroupe.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupe.ForeColor = System.Drawing.Color.White;
            this.cmbGroupe.Location = new System.Drawing.Point(68, 76);
            this.cmbGroupe.Name = "cmbGroupe";
            this.cmbGroupe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbGroupe.Size = new System.Drawing.Size(137, 22);
            this.cmbGroupe.TabIndex = 2;
            this.cmbGroupe.Text = "cmbGroupe";
            this.cmbGroupe.SelectedIndexChanged += new System.EventHandler(this.cmbGroupe_SelectedIndexChanged);
            // 
            // fraAffichage
            // 
            this.fraAffichage.BackColor = System.Drawing.Color.Black;
            this.fraAffichage.Controls.Add(this.chkAchat);
            this.fraAffichage.Controls.Add(this.chkInventaireMec);
            this.fraAffichage.Controls.Add(this.chkInventaireElec);
            this.fraAffichage.Controls.Add(this.chkCatalogueElec);
            this.fraAffichage.Controls.Add(this.chkSoumissionElec);
            this.fraAffichage.Controls.Add(this.chkProjetElec);
            this.fraAffichage.Controls.Add(this.chkProjetMec);
            this.fraAffichage.Controls.Add(this.chkSoumissionMec);
            this.fraAffichage.Controls.Add(this.chkOutils);
            this.fraAffichage.Controls.Add(this.chkPunch);
            this.fraAffichage.Controls.Add(this.chkConfiguration);
            this.fraAffichage.Controls.Add(this.chkCedule);
            this.fraAffichage.Controls.Add(this.chkEmployes);
            this.fraAffichage.Controls.Add(this.chkCatalogueMec);
            this.fraAffichage.Controls.Add(this.chkRapports);
            this.fraAffichage.Controls.Add(this.chkContactsVendeurs);
            this.fraAffichage.Controls.Add(this.chkContacts);
            this.fraAffichage.Controls.Add(this.chkFournisseurs);
            this.fraAffichage.Controls.Add(this.chkClients);
            this.fraAffichage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraAffichage.ForeColor = System.Drawing.Color.White;
            this.fraAffichage.Location = new System.Drawing.Point(7, 145);
            this.fraAffichage.Name = "fraAffichage";
            this.fraAffichage.Padding = new System.Windows.Forms.Padding(0);
            this.fraAffichage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraAffichage.Size = new System.Drawing.Size(329, 361);
            this.fraAffichage.TabIndex = 5;
            this.fraAffichage.TabStop = false;
            this.fraAffichage.Text = "Affichage";
            // 
            // cmdEnregistrer
            // 
            this.cmdEnregistrer.AutoSize = true;
            this.cmdEnregistrer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdEnregistrer.BackColor = System.Drawing.Color.Black;
            this.cmdEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEnregistrer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnregistrer.ForeColor = System.Drawing.Color.White;
            this.cmdEnregistrer.Location = new System.Drawing.Point(470, 532);
            this.cmdEnregistrer.Name = "cmdEnregistrer";
            this.cmdEnregistrer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.cmdEnregistrer.TabIndex = 48;
            this.cmdEnregistrer.Text = "Enregistrer";
            this.cmdEnregistrer.UseVisualStyleBackColor = true;
            this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.AutoSize = true;
            this.cmdAnnuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.ForeColor = System.Drawing.Color.White;
            this.cmdAnnuler.Location = new System.Drawing.Point(543, 532);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(59, 23);
            this.cmdAnnuler.TabIndex = 51;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // txtGroupe
            // 
            this.txtGroupe.AcceptsReturn = true;
            this.txtGroupe.BackColor = System.Drawing.Color.Black;
            this.txtGroupe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupe.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupe.ForeColor = System.Drawing.Color.White;
            this.txtGroupe.Location = new System.Drawing.Point(68, 78);
            this.txtGroupe.MaxLength = 0;
            this.txtGroupe.Name = "txtGroupe";
            this.txtGroupe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupe.Size = new System.Drawing.Size(137, 22);
            this.txtGroupe.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(212, 50);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(182, 14);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Liste des employés dans le groupe :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGroupes
            // 
            this.lblGroupes.BackColor = System.Drawing.Color.Black;
            this.lblGroupes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupes.ForeColor = System.Drawing.Color.White;
            this.lblGroupes.Location = new System.Drawing.Point(13, 81);
            this.lblGroupes.Name = "lblGroupes";
            this.lblGroupes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGroupes.Size = new System.Drawing.Size(49, 17);
            this.lblGroupes.TabIndex = 0;
            this.lblGroupes.Text = "Groupes";
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAddUser.BackColor = System.Drawing.Color.Black;
            this.cmdAddUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAddUser.ForeColor = System.Drawing.Color.White;
            this.cmdAddUser.Location = new System.Drawing.Point(15, 532);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(321, 23);
            this.cmdAddUser.TabIndex = 54;
            this.cmdAddUser.Text = "Ajouter user";
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.cmdAddUser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(105, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "Exporter les groupes vers Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Groupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(748, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdAddUser);
            this.Controls.Add(this.lstUser);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.fraModification);
            this.Controls.Add(this.cmbGroupe);
            this.Controls.Add(this.fraAffichage);
            this.Controls.Add(this.cmdEnregistrer);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.txtGroupe);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblGroupes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(327, 163);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Groupes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration des groupes de sécurité";
            this.Load += new System.EventHandler(this.Groupes_Load);
            this.fraModification.ResumeLayout(false);
            this.fraModification.PerformLayout();
            this.fraAffichage.ResumeLayout(false);
            this.fraAffichage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal ToolTip ToolTip1;
        internal ListBox lstUser;
        internal Button cmdFermer;
        internal Button cmdSupprimer;
        internal Button cmdModifier;
        internal Button cmdAjouter;
        internal CheckBox chkDeverrouillageTempsProjet;
        internal CheckBox chkVerrouillageTempsProjet;
        internal CheckBox chkPunchSemaineAnterieure;
        internal CheckBox chkMailingList;
        internal CheckBox chkRetourMarchandise;
        internal CheckBox chkReception;
        internal CheckBox chkSupprimerProjets;
        internal CheckBox chkModificationPunchEmployes;
        internal CheckBox chkModificationInventaireMec;
        internal CheckBox chkModificationInventaireElec;
        internal CheckBox chkModificationCatalogueElec;
        internal CheckBox chkModificationCatalogueMec;
        internal CheckBox chkModificationBonsCommandes;
        internal CheckBox chkModificationSoumissionElec;
        internal CheckBox chkModificationProjetElec;
        internal CheckBox chkModificationProjetMec;
        internal CheckBox chkModificationSoumissionMec;
        internal CheckBox chkModificationFacturation;
        internal CheckBox chkModificationOutils;
        internal CheckBox chkModificationFeuillesTemps;
        internal CheckBox chkModificationGroupes;
        internal CheckBox chkModificationEmployes;
        internal CheckBox chkModificationContacts;
        internal CheckBox chkModificationFRS;
        internal CheckBox chkModificationClients;
        internal GroupBox fraModification;
        internal ComboBox cmbGroupe;
        internal CheckBox chkAchat;
        internal CheckBox chkInventaireMec;
        internal CheckBox chkInventaireElec;
        internal CheckBox chkCatalogueElec;
        internal CheckBox chkSoumissionElec;
        internal CheckBox chkProjetElec;
        internal CheckBox chkProjetMec;
        internal CheckBox chkSoumissionMec;
        internal CheckBox chkOutils;
        internal CheckBox chkPunch;
        internal CheckBox chkConfiguration;
        internal CheckBox chkCedule;
        internal CheckBox chkEmployes;
        internal CheckBox chkCatalogueMec;
        internal CheckBox chkRapports;
        internal CheckBox chkContactsVendeurs;
        internal CheckBox chkContacts;
        internal CheckBox chkFournisseurs;
        internal CheckBox chkClients;
        internal GroupBox fraAffichage;
        internal Button cmdEnregistrer;
        internal Button cmdAnnuler;
        internal TextBox txtGroupe;
        internal Label Label1;
        internal Label lblGroupes;
        private Button cmdAddUser;
        private Button button1;
        private enum EnumMode
        {
            MODE_AJOUT = 0,
            MODE_MODIF = 1,
            MODE_INACTIF = 2
        }
        private bool m_bModeAjout;
        private int m_iNoGroupe;
        private int m_iModif;
        private void chkClients_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkClients.Checked)
                {
                    chkModificationClients.Enabled = true;
                }
                else
                {
                    chkModificationClients.CheckState = CheckState.Unchecked;
                    chkModificationClients.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkClients_Click", ex);
            }
        }
        private void chkPunch_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkPunch.Checked)
                {
                    chkPunchSemaineAnterieure.Enabled = true;
                }
                else
                {
                    chkPunchSemaineAnterieure.CheckState = CheckState.Unchecked;
                    chkPunchSemaineAnterieure.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkPunch_Click", ex);
            }
        }
        private void chkSoumissionMec_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkSoumissionMec.Checked)
                {
                    chkModificationSoumissionMec.Enabled = true;
                }
                else
                {
                    chkModificationSoumissionMec.CheckState = CheckState.Unchecked;
                    chkModificationSoumissionMec.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkSoumissionMec_Click", ex);
            }
        }
        private void chkProjetMec_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkProjetMec.Checked)
                {
                    chkModificationProjetMec.Enabled = true;
                    chkVerrouillageTempsProjet.Enabled = true;
                    chkDeverrouillageTempsProjet.Enabled = true;
                }
                else
                {
                    chkModificationProjetMec.CheckState = CheckState.Unchecked;
                    chkVerrouillageTempsProjet.CheckState = CheckState.Unchecked;
                    chkDeverrouillageTempsProjet.CheckState = CheckState.Unchecked;
                    chkModificationProjetMec.Enabled = false;
                    chkVerrouillageTempsProjet.Enabled = false;
                    chkDeverrouillageTempsProjet.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkProjetMec_Click", ex);
            }
        }
        private void chkSoumissionElec_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkSoumissionElec.Checked)
                {
                    chkModificationSoumissionElec.Enabled = true;
                }
                else
                {
                    chkModificationSoumissionElec.CheckState = CheckState.Unchecked;
                    chkModificationSoumissionElec.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkSoumissionElec_Click", ex);
            }
        }
        private void chkProjetElec_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkProjetElec.Checked)
                {
                    chkModificationProjetElec.Enabled = true;
                }
                else
                {
                    chkModificationProjetElec.CheckState = CheckState.Unchecked;
                    chkModificationProjetElec.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkProjetElec_Click", ex);
            }
        }
        private void chkOutils_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkOutils.Checked)
                {
                    chkModificationOutils.Enabled = true;
                }
                else
                {
                    chkModificationOutils.CheckState = CheckState.Unchecked;
                    chkModificationOutils.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkOutils_Click", ex);
            }
        }
        private void chkFournisseurs_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkFournisseurs.Checked)
                {
                    chkModificationFRS.Enabled = true;
                }
                else
                {
                    chkModificationFRS.CheckState = CheckState.Unchecked;
                    chkModificationFRS.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkFournisseurs_Click", ex);
            }
        }
        private void chkContacts_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkContacts.Checked)
                {
                    chkModificationContacts.Enabled = true;
                }
                else
                {
                    chkModificationContacts.CheckState = CheckState.Unchecked;
                    chkModificationContacts.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkContacts_Click", ex);
            }
        }
        private void chkEmployes_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkEmployes.Checked)
                {
                    chkModificationEmployes.Enabled = true;
                    chkModificationGroupes.Enabled = true;
                    chkModificationPunchEmployes.Enabled = true;
                }
                else
                {
                    chkModificationEmployes.CheckState = CheckState.Unchecked;
                    chkModificationGroupes.CheckState = CheckState.Unchecked;
                    chkModificationPunchEmployes.CheckState = CheckState.Unchecked;
                    chkModificationEmployes.Enabled = false;
                    chkModificationGroupes.Enabled = false;
                    chkModificationPunchEmployes.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkEmployes_Click", ex);
            }
        }
        private void chkCatalogueElec_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkCatalogueElec.Checked)
                {
                    chkModificationCatalogueElec.Enabled = true;
                }
                else
                {
                    chkModificationCatalogueElec.CheckState = CheckState.Unchecked;
                    chkModificationCatalogueElec.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkCatalogueElec_Click", ex);
            }
        }
        private void chkCatalogueMec_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkCatalogueMec.Checked)
                {
                    chkModificationCatalogueMec.Enabled = true;
                }
                else
                {
                    chkModificationCatalogueMec.CheckState = CheckState.Unchecked;
                    chkModificationCatalogueMec.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkCatalogueMec_Click", ex);
            }
        }
        private void chkInventaireMec_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkInventaireMec.Checked)
                {
                    chkModificationInventaireMec.Enabled = true;
                }
                else
                {
                    chkModificationInventaireMec.CheckState = CheckState.Unchecked;
                    chkModificationInventaireMec.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkInventaireMec_Click", ex);
            }
        }
        private void chkInventaireElec_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkInventaireElec.Checked)
                {
                    chkModificationInventaireElec.Enabled = true;
                }
                else
                {
                    chkModificationInventaireElec.CheckState = CheckState.Unchecked;
                    chkModificationInventaireElec.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "chkInventaireElec_Click", ex);
            }
        }
        [Obsolete]
        private void cmbGroupe_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtGroupe.Text = cmbGroupe.Text;
                //          m_iNoGroupe = GetGroupeID(cmbGroupe.Text);
                AfficherGroupe();
                cmdModifier.Enabled = true;
                cmdSupprimer.Enabled = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "cmbGroupe_Click", ex);
            }
        }
        private void cmdAjouter_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bModeAjout = true;
                UncheckedAll();
                MontrerControles(EnumMode.MODE_AJOUT);
                txtGroupe.Text = string.Empty;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "cmdAjouter_Click", ex);
            }
        }
        [Obsolete]
        private void cmdModifier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_iNoGroupe != (int)Program.IdGroupe)
                {
                    MontrerControles(EnumMode.MODE_MODIF);
                    AfficherGroupe();
                    m_iModif = (int)cmbGroupe.SelectedIndex;
                    m_bModeAjout = false;
                }
                else
                {
                    MessageBox.Show("Impossible de modifier le groupe actuel!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "cmdModifier_Click", ex);
            }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                MontrerControles(EnumMode.MODE_INACTIF);
                AfficherGroupe();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdSupprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbGroupe.Items.Count > 0)
                {
                    AfficherUtilisateurs();
                    if ((txtGroupe.Text ?? "") != S_GROUPE_ADMIN & (txtGroupe.Text ?? "") != S_GROUPE_DEFAUT)
                    {
                        if (lstUser.Items.Count == 0)
                        {
                            UpdateSQL($"DELETE FROM Groupes WHERE NomGroupe = '{cmbGroupe.Text}'");
                            RemplirComboGroupes();
                        }
                        else
                        {
                            MessageBox.Show("Il y a des utilisateurs dans ce groupe!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous ne pouvez pas effacer ce groupe!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "cmdSupprimer_Click", ex);
            }
        }
        private void cmdEnregistrer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtGroupe.Text))
                {
                    EnregistrerGroupe();
                    MontrerControles(EnumMode.MODE_INACTIF);
                    RemplirComboGroupes();
                    cmbGroupe.SelectedIndex = m_iModif;
                }
                else
                {
                    MessageBox.Show("Le nom du groupe ne peut pas être vide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "cmdEnregistrer_Click", ex);
            }
        }
        private void EnregistrerGroupe()
        {
            try
            {
                ADODB.Recordset rstGroupes = new ADODB.Recordset();
                if (m_bModeAjout == true)
                {
                    rstGroupes.Open("SELECT * FROM Groupes", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstGroupes.AddNew();
                    m_bModeAjout = false;
                }
                else
                {
                    rstGroupes.Open("SELECT * FROM Groupes WHERE IDGroupe = " + m_iNoGroupe, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                rstGroupes.Fields["NomGroupe"].Value = txtGroupe.Text;
                rstGroupes.Fields["Clients"].Value = chkClients.CheckState;
                rstGroupes.Fields["Fournisseurs"].Value = chkFournisseurs.CheckState;
                rstGroupes.Fields["Contacts"].Value = chkContacts.CheckState;
                rstGroupes.Fields["ContactsVendeurs"].Value = chkContactsVendeurs.CheckState;
                rstGroupes.Fields["Rapport"].Value = chkRapports.CheckState;
                rstGroupes.Fields["CatalogueMec"].Value = chkCatalogueMec.CheckState;
                rstGroupes.Fields["CatalogueElec"].Value = chkCatalogueElec.CheckState;
                rstGroupes.Fields["Employes"].Value = chkEmployes.CheckState;
                rstGroupes.Fields["Cedule"].Value = chkCedule.CheckState;
                rstGroupes.Fields["Configuration"].Value = chkConfiguration.CheckState;
                rstGroupes.Fields["Punch"].Value = chkPunch.CheckState;
                rstGroupes.Fields["Outils"].Value = chkOutils.CheckState;
                rstGroupes.Fields["InventaireMec"].Value = chkInventaireMec.CheckState;
                rstGroupes.Fields["SoumissionMec"].Value = chkSoumissionMec.CheckState;
                rstGroupes.Fields["ProjetMec"].Value = chkProjetMec.CheckState;
                rstGroupes.Fields["InventaireElec"].Value = chkInventaireElec.CheckState;
                rstGroupes.Fields["SoumissionElec"].Value = chkSoumissionElec.CheckState;
                rstGroupes.Fields["ProjetElec"].Value = chkProjetElec.CheckState;
                rstGroupes.Fields["ACHAT"].Value = chkAchat.CheckState;
                rstGroupes.Fields["ModificationClients"].Value = chkModificationClients.CheckState;
                rstGroupes.Fields["ModificationFournisseurs"].Value = chkModificationFRS.CheckState;
                rstGroupes.Fields["ModificationContacts"].Value = chkModificationContacts.CheckState;
                rstGroupes.Fields["ModificationEmployes"].Value = chkModificationEmployes.CheckState;
                rstGroupes.Fields["ModificationGroupes"].Value = chkModificationGroupes.CheckState;
                rstGroupes.Fields["ModificationFeuillesTemps"].Value = chkModificationFeuillesTemps.CheckState;
                rstGroupes.Fields["ModificationOutils"].Value = chkModificationOutils.CheckState;
                rstGroupes.Fields["ModificationFacturation"].Value = chkModificationFacturation.CheckState;
                rstGroupes.Fields["ModificationInventaireMec"].Value = chkModificationInventaireMec.CheckState;
                rstGroupes.Fields["ModificationSoumissionsMec"].Value = chkModificationSoumissionMec.CheckState;
                rstGroupes.Fields["ModificationProjetsMec"].Value = chkModificationProjetMec.CheckState;
                rstGroupes.Fields["ModificationInventaireElec"].Value = chkModificationInventaireElec.CheckState;
                rstGroupes.Fields["ModificationSoumissionsElec"].Value = chkModificationSoumissionElec.CheckState;
                rstGroupes.Fields["ModificationProjetsElec"].Value = chkModificationProjetElec.CheckState;
                rstGroupes.Fields["ModificationBonsCommandes"].Value = chkModificationBonsCommandes.CheckState;
                rstGroupes.Fields["ModificationCatalogueElec"].Value = chkModificationCatalogueElec.CheckState;
                rstGroupes.Fields["ModificationCatalogueMec"].Value = chkModificationCatalogueMec.CheckState;
                rstGroupes.Fields["ModificationPunchEmployes"].Value = chkModificationPunchEmployes.CheckState;
                rstGroupes.Fields["SuppressionProjets"].Value = chkSupprimerProjets.CheckState;
                rstGroupes.Fields["ModificationReception"].Value = chkReception.CheckState;
                rstGroupes.Fields["ModificationRetourMarchandise"].Value = chkRetourMarchandise.CheckState;
                rstGroupes.Fields["ListeDistribution"].Value = chkMailingList.CheckState;
                rstGroupes.Fields["PunchSemaineAntérieure"].Value = chkPunchSemaineAnterieure.CheckState;
                rstGroupes.Fields["VerrouillageTempsProjet"].Value = chkVerrouillageTempsProjet.CheckState;
                rstGroupes.Fields["DéverrouillageTempsProjet"].Value = chkDeverrouillageTempsProjet.CheckState;
                rstGroupes.Update();
                rstGroupes.Close();
                rstGroupes = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "EnregistrerGroupe", ex);
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
                AfficherErreur("Groupes", "cmdFermer_Click", ex);
            }
        }
        private void Groupes_Load(object eventSender, EventArgs eventArgs)
        {
            cmdAddUser.Text = "Ajouter " + Employe.nomUtilisateur;
            Icon = Conteneur.ActiveForm.Icon;
            if (Conteneur.idGroupeEmploye.Text == "IT") { 
                button2.Visible = true;
            }
            try
            {
                RemplirComboGroupes();
                MontrerControles(EnumMode.MODE_INACTIF);
                return;
                if (cmbGroupe.Text == "IT")
                {
                    fraModification.Enabled = true;
                    fraAffichage.Enabled = true;
                }
                else
                {
                    fraModification.Enabled = false;
                    fraAffichage.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "Form_Load", ex);
            }
        }
        private void RemplirComboGroupes()
        {
            try
            {
                ADODB.Recordset rstGroupes;
                cmbGroupe.Items.Clear();
                rstGroupes = new Recordset();
                rstGroupes.Open("SELECT * FROM Groupes ORDER BY NomGroupe", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstGroupes.EOF)
                {
                    cmbGroupe.Items.Add(rstGroupes.Fields["NomGroupe"].Value);
                    cmbGroupe.Tag = rstGroupes.Fields["IDGroupe"].Value;
                    rstGroupes.MoveNext();
                }
                rstGroupes.Close();
                rstGroupes = null;
                if (cmbGroupe.Items.Count > 0)
                {
                    cmbGroupe.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "RemplirComboGroupes", ex);
            }
        }
        private void MontrerControles(EnumMode eMode)
        {
            try
            {
                var bCmbGroupe = default(bool);
                var bTxtGroupe = default(bool);
                var bAnnuler = default(bool);
                var bEnregistrer = default(bool);
                var bQuitter = default(bool);
                var bAjouter = default(bool);
                var bModifier = default(bool);
                var bSupprimer = default(bool);
                var bAffichage = default(bool);
                var bModification = default(bool);
                var bLockedGroupe = default(bool);
                switch (eMode)
                {
                    case EnumMode.MODE_AJOUT:
                        {
                            bTxtGroupe = true;
                            bAnnuler = true;
                            bEnregistrer = true;
                            bAffichage = true;
                            bModification = true; break;
                        }
                    case EnumMode.MODE_MODIF:
                        {
                            bTxtGroupe = true;
                            if ((txtGroupe.Text ?? "") == S_GROUPE_DEFAUT)
                            {
                                bLockedGroupe = true;
                            }
                            bAnnuler = true;
                            bEnregistrer = true;
                            bAffichage = true;
                            bModification = true; break;
                        }
                    case EnumMode.MODE_INACTIF:
                        {
                            bCmbGroupe = true;
                            bQuitter = true;
                            bAjouter = true;
                            bModifier = true;
                            bSupprimer = true; break;
                        }
                }
                txtGroupe.Visible = bTxtGroupe;
                txtGroupe.ReadOnly = bLockedGroupe;
                cmbGroupe.Visible = bCmbGroupe;
                cmdAnnuler.Visible = bAnnuler;
                cmdEnregistrer.Visible = bEnregistrer;
                cmdFermer.Visible = bQuitter;
                cmdAjouter.Visible = bAjouter;
                cmdModifier.Visible = bModifier;
                cmdSupprimer.Visible = bSupprimer;
                fraAffichage.Enabled = bAffichage;
                fraModification.Enabled = bModification;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "MontrerControles", ex);
            }
        }
        private void AfficherGroupe()
        {
            try
            {
                ADODB.Recordset rstGroupes;
                rstGroupes = new Recordset();
                rstGroupes.Open($"SELECT * FROM Groupes WHERE NomGroupe = '{cmbGroupe.Text}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                /* ID 0 : IDGroupe ID 1 : NomGroupe ID 2 : Clients ID 3 : Fournisseurs ID 4 : Contacts ID 5 : ContactsVendeurs ID 6 : Rapport ID 7 : CatalogueMec 
                 * ID 8 : CatalogueElec ID 9 : Employes ID 10 : Cedule ID 11 : Configuration ID 12 : Punch ID 13 : Outils ID 14 : SoumissionMec ID 15 : ProjetMec 
                 * ID 16 : SoumissionElec ID 17 : ProjetElec ID 18 : InventaireMec ID 19 : InventaireElec ID 20 : ACHAT ID 21 : ModificationFacturation 
                 * ID 22 : ModificationClients ID 23 : ModificationFournisseurs ID 24 : ModificationContacts ID 25 : ModificationGroupes ID 26 : ModificationEmployes 
                 * ID 27 : ModificationFeuillesTemps ID 28 : ModificationOutils ID 29 : ModificationSoumissionsMec ID 30 : ModificationProjetsMec 
                 * ID 31 : ModificationSoumissionsElec ID 32 : ModificationProjetsElec ID 33 : ModificationBonsCommandes ID 34 : ModificationCatalogueElec 
                 * ID 35 : ModificationCatalogueMec ID 36 : ModificationInventaireMec ID 37 : ModificationInventaireElec ID 38 : ModificationPunchEmployes 
                 * ID 39 : ModificationReception ID 40 : ModificationRetourMarchandise ID 41 : SuppressionProjets ID 42 : ListeDistribution ID 43 : PunchSemaineAntérieure 
                 * ID 44 : VerrouillageTempsProjet ID 45 : DéverrouillageTempsProjet*/
                m_iNoGroupe = (int)rstGroupes.Fields["IDGroupe"].Value;
                button1.Text = m_iNoGroupe.ToString();
                chkClients.Checked = (bool)rstGroupes.Fields[2].Value;
                chkFournisseurs.Checked = (bool)rstGroupes.Fields[3].Value;
                chkContacts.Checked = (bool)rstGroupes.Fields[4].Value;
                chkContactsVendeurs.Checked = (bool)rstGroupes.Fields[5].Value;
                chkRapports.Checked = (bool)rstGroupes.Fields[6].Value;
                chkCatalogueMec.Checked = (bool)rstGroupes.Fields[7].Value;
                chkCatalogueElec.Checked = (bool)rstGroupes.Fields[8].Value;
                chkEmployes.Checked = (bool)rstGroupes.Fields[9].Value;
                chkCedule.Checked = (bool)rstGroupes.Fields[10].Value;
                chkConfiguration.Checked = (bool)rstGroupes.Fields[11].Value;
                chkPunch.Checked = (bool)rstGroupes.Fields[12].Value;
                chkOutils.Checked = (bool)rstGroupes.Fields[13].Value;
                chkSoumissionMec.Checked = (bool)rstGroupes.Fields[14].Value;
                chkProjetMec.Checked = (bool)rstGroupes.Fields[15].Value;
                chkSoumissionElec.Checked = (bool)rstGroupes.Fields[16].Value;
                chkProjetElec.Checked = (bool)rstGroupes.Fields[17].Value;
                chkInventaireMec.Checked = (bool)rstGroupes.Fields[18].Value;
                chkInventaireElec.Checked = (bool)rstGroupes.Fields[19].Value;
                chkAchat.Checked = (bool)rstGroupes.Fields[20].Value;
                chkModificationFacturation.Checked = (bool)rstGroupes.Fields[21].Value;
                chkModificationClients.Checked = (bool)rstGroupes.Fields[22].Value;
                chkModificationFRS.Checked = (bool)rstGroupes.Fields[23].Value;
                chkModificationContacts.Checked = (bool)rstGroupes.Fields[24].Value;
                chkModificationGroupes.Checked = (bool)rstGroupes.Fields[25].Value;
                chkModificationEmployes.Checked = (bool)rstGroupes.Fields[26].Value;
                chkModificationFeuillesTemps.Checked = (bool)rstGroupes.Fields[27].Value;
                chkModificationOutils.Checked = (bool)rstGroupes.Fields[28].Value;
                chkModificationSoumissionMec.Checked = (bool)rstGroupes.Fields[29].Value;
                chkModificationProjetMec.Checked = (bool)rstGroupes.Fields[30].Value;
                chkModificationSoumissionElec.Checked = (bool)rstGroupes.Fields[31].Value;
                chkModificationProjetElec.Checked = (bool)rstGroupes.Fields[32].Value;
                chkModificationBonsCommandes.Checked = (bool)rstGroupes.Fields[33].Value;
                chkModificationCatalogueElec.Checked = (bool)rstGroupes.Fields[34].Value;
                chkModificationCatalogueMec.Checked = (bool)rstGroupes.Fields[35].Value;
                chkModificationInventaireMec.Checked = (bool)rstGroupes.Fields[36].Value;
                chkModificationInventaireElec.Checked = (bool)rstGroupes.Fields[37].Value;
                chkModificationPunchEmployes.Checked = (bool)rstGroupes.Fields[38].Value;
                chkReception.Checked = (bool)rstGroupes.Fields[39].Value;
                chkRetourMarchandise.Checked = (bool)rstGroupes.Fields[40].Value;
                chkSupprimerProjets.Checked = (bool)rstGroupes.Fields[41].Value;
                chkMailingList.Checked = (bool)rstGroupes.Fields[42].Value;
                chkPunchSemaineAnterieure.Checked = (bool)rstGroupes.Fields[43].Value;
                chkVerrouillageTempsProjet.Checked = (bool)rstGroupes.Fields[44].Value;
                chkDeverrouillageTempsProjet.Checked = (bool)rstGroupes.Fields[45].Value;
                if (m_iNoGroupe == 2)
                {
                    fraModification.Enabled = true;
                    fraAffichage.Enabled = true;
                    chkClients.ForeColor = COLOR_ROUGE; //Clients
                    chkFournisseurs.ForeColor = COLOR_ROUGE; //Fournisseurs
                    chkContacts.ForeColor = COLOR_ROUGE; //Contacts
                    chkContactsVendeurs.ForeColor = COLOR_ROUGE; //ContactsVendeurs
                    chkRapports.ForeColor = COLOR_ROUGE; //Rapport
                    chkCatalogueMec.ForeColor = COLOR_ROUGE; //CatalogueMec
                    chkCatalogueElec.ForeColor = COLOR_ROUGE; //CatalogueElec
                    chkEmployes.ForeColor = COLOR_ROUGE; //Employes
                    chkCedule.ForeColor = COLOR_ROUGE; //Cedule
                    chkConfiguration.ForeColor = COLOR_ROUGE; //Configuration
                    chkPunch.ForeColor = COLOR_ROUGE; //Punch
                    chkOutils.ForeColor = COLOR_ROUGE; //Outils
                    chkSoumissionMec.ForeColor = COLOR_ROUGE; //SoumissionMec
                    chkProjetMec.ForeColor = COLOR_ROUGE; //ProjetMec
                    chkSoumissionElec.ForeColor = COLOR_ROUGE; //SoumissionElec
                    chkProjetElec.ForeColor = COLOR_ROUGE; //ProjetElec
                    chkInventaireMec.ForeColor = COLOR_ROUGE; //InventaireMec
                    chkInventaireElec.ForeColor = COLOR_ROUGE; //InventaireElec
                    chkAchat.ForeColor = COLOR_ROUGE; //ACHAT
                    chkModificationFacturation.ForeColor = COLOR_ROUGE; //ModificationFacturation
                    chkModificationClients.ForeColor = COLOR_ROUGE; //ModificationClients
                    chkModificationFRS.ForeColor = COLOR_ROUGE; //ModificationFournisseurs
                    chkModificationContacts.ForeColor = COLOR_ROUGE; //ModificationContacts
                    chkModificationEmployes.ForeColor = COLOR_ROUGE; //ModificationEmployes
                    chkModificationGroupes.ForeColor = COLOR_ROUGE; //ModificationGroupes
                    chkModificationFeuillesTemps.ForeColor = COLOR_ROUGE; //ModificationFeuillesTemps
                    chkModificationOutils.ForeColor = COLOR_ROUGE; //ModificationOutils
                    chkModificationSoumissionMec.ForeColor = COLOR_ROUGE; //ModificationSoumissionsMec
                    chkModificationProjetMec.ForeColor = COLOR_ROUGE; //ModificationProjetsMec
                    chkModificationSoumissionElec.ForeColor = COLOR_ROUGE; //ModificationSoumissionsElec
                    chkModificationProjetElec.ForeColor = COLOR_ROUGE; //ModificationProjetsElec
                    chkModificationBonsCommandes.ForeColor = COLOR_ROUGE; //ModificationBonsCommandes
                    chkModificationCatalogueElec.ForeColor = COLOR_ROUGE; //ModificationCatalogueElec
                    chkModificationCatalogueMec.ForeColor = COLOR_ROUGE; //ModificationCatalogueMec
                    chkModificationInventaireMec.ForeColor = COLOR_ROUGE; //ModificationInventaireMec
                    chkModificationInventaireElec.ForeColor = COLOR_ROUGE; //ModificationInventaireElec
                    chkModificationPunchEmployes.ForeColor = COLOR_ROUGE; //ModificationPunchEmployes
                    chkSupprimerProjets.ForeColor = COLOR_ROUGE; //SuppressionProjets
                    chkReception.ForeColor = COLOR_ROUGE; //ModificationReception
                    chkRetourMarchandise.ForeColor = COLOR_ROUGE; //ModificationRetourMarchandise
                    chkMailingList.ForeColor = COLOR_ROUGE; //ListeDistribution
                    chkPunchSemaineAnterieure.ForeColor = COLOR_ROUGE; //PunchSemaineAntérieure
                    chkVerrouillageTempsProjet.ForeColor = COLOR_ROUGE; //VerrouillageTempsProjet
                    chkDeverrouillageTempsProjet.ForeColor = COLOR_ROUGE; //DéverrouillageTempsProjet
                }
                else if (m_iNoGroupe == 27)
                {
                    fraModification.Enabled = true;
                    fraAffichage.Enabled = true;
                    chkClients.ForeColor = COLOR_VERT; //Clients
                    chkFournisseurs.ForeColor = COLOR_VERT; //Fournisseurs
                    chkContacts.ForeColor = COLOR_VERT; //Contacts
                    chkContactsVendeurs.ForeColor = COLOR_VERT; //ContactsVendeurs
                    chkRapports.ForeColor = COLOR_VERT; //Rapport
                    chkCatalogueMec.ForeColor = COLOR_VERT; //CatalogueMec
                    chkCatalogueElec.ForeColor = COLOR_VERT; //CatalogueElec
                    chkEmployes.ForeColor = COLOR_VERT; //Employes
                    chkCedule.ForeColor = COLOR_VERT; //Cedule
                    chkConfiguration.ForeColor = COLOR_VERT; //Configuration
                    chkPunch.ForeColor = COLOR_VERT; //Punch
                    chkOutils.ForeColor = COLOR_VERT; //Outils
                    chkSoumissionMec.ForeColor = COLOR_VERT; //SoumissionMec
                    chkProjetMec.ForeColor = COLOR_VERT; //ProjetMec
                    chkSoumissionElec.ForeColor = COLOR_VERT; //SoumissionElec
                    chkProjetElec.ForeColor = COLOR_VERT; //ProjetElec
                    chkInventaireMec.ForeColor = COLOR_VERT; //InventaireMec
                    chkInventaireElec.ForeColor = COLOR_VERT; //InventaireElec
                    chkAchat.ForeColor = COLOR_VERT; //ACHAT
                    chkModificationFacturation.ForeColor = COLOR_VERT; //ModificationFacturation
                    chkModificationClients.ForeColor = COLOR_VERT; //ModificationClients
                    chkModificationFRS.ForeColor = COLOR_VERT; //ModificationFournisseurs
                    chkModificationContacts.ForeColor = COLOR_VERT; //ModificationContacts
                    chkModificationEmployes.ForeColor = COLOR_VERT; //ModificationEmployes
                    chkModificationGroupes.ForeColor = COLOR_VERT; //ModificationGroupes
                    chkModificationFeuillesTemps.ForeColor = COLOR_VERT; //ModificationFeuillesTemps
                    chkModificationOutils.ForeColor = COLOR_VERT; //ModificationOutils
                    chkModificationSoumissionMec.ForeColor = COLOR_VERT; //ModificationSoumissionsMec
                    chkModificationProjetMec.ForeColor = COLOR_VERT; //ModificationProjetsMec
                    chkModificationSoumissionElec.ForeColor = COLOR_VERT; //ModificationSoumissionsElec
                    chkModificationProjetElec.ForeColor = COLOR_VERT; //ModificationProjetsElec
                    chkModificationBonsCommandes.ForeColor = COLOR_VERT; //ModificationBonsCommandes
                    chkModificationCatalogueElec.ForeColor = COLOR_VERT; //ModificationCatalogueElec
                    chkModificationCatalogueMec.ForeColor = COLOR_VERT; //ModificationCatalogueMec
                    chkModificationInventaireMec.ForeColor = COLOR_VERT; //ModificationInventaireMec
                    chkModificationInventaireElec.ForeColor = COLOR_VERT; //ModificationInventaireElec
                    chkModificationPunchEmployes.ForeColor = COLOR_VERT; //ModificationPunchEmployes
                    chkSupprimerProjets.ForeColor = COLOR_VERT; //SuppressionProjets
                    chkReception.ForeColor = COLOR_VERT; //ModificationReception
                    chkRetourMarchandise.ForeColor = COLOR_VERT; //ModificationRetourMarchandise
                    chkMailingList.ForeColor = COLOR_VERT; //ListeDistribution
                    chkPunchSemaineAnterieure.ForeColor = COLOR_VERT; //PunchSemaineAntérieure
                    chkVerrouillageTempsProjet.ForeColor = COLOR_VERT; //VerrouillageTempsProjet
                    chkDeverrouillageTempsProjet.ForeColor = COLOR_VERT; //DéverrouillageTempsProjet
                    chkClients.Checked = true;
                    chkFournisseurs.Checked = true;
                    chkContacts.Checked = true;
                    chkContactsVendeurs.Checked = true;
                    chkRapports.Checked = true;
                    chkCatalogueMec.Checked = true;
                    chkCatalogueElec.Checked = true;
                    chkEmployes.Checked = true;
                    chkCedule.Checked = true;
                    chkConfiguration.Checked = true;
                    chkPunch.Checked = true;
                    chkOutils.Checked = true;
                    chkSoumissionMec.Checked = true;
                    chkProjetMec.Checked = true;
                    chkSoumissionElec.Checked = true;
                    chkProjetElec.Checked = true;
                    chkInventaireMec.Checked = true;
                    chkInventaireElec.Checked = true;
                    chkAchat.Checked = true;
                    chkModificationFacturation.Checked = true;
                    chkModificationClients.Checked = true;
                    chkModificationFRS.Checked = true;
                    chkModificationContacts.Checked = true;
                    chkModificationGroupes.Checked = true;
                    chkModificationEmployes.Checked = true;
                    chkModificationFeuillesTemps.Checked = true;
                    chkModificationOutils.Checked = true;
                    chkModificationSoumissionMec.Checked = true;
                    chkModificationProjetMec.Checked = true;
                    chkModificationSoumissionElec.Checked = true;
                    chkModificationProjetElec.Checked = true;
                    chkModificationBonsCommandes.Checked = true;
                    chkModificationCatalogueElec.Checked = true;
                    chkModificationCatalogueMec.Checked = true;
                    chkModificationInventaireMec.Checked = true;
                    chkModificationInventaireElec.Checked = true;
                    chkModificationPunchEmployes.Checked = true;
                    chkReception.Checked = true;
                    chkRetourMarchandise.Checked = true;
                    chkSupprimerProjets.Checked = true;
                    chkMailingList.Checked = true;
                    chkPunchSemaineAnterieure.Checked = true;
                    chkVerrouillageTempsProjet.Checked = true;
                    chkDeverrouillageTempsProjet.Checked = true;
                }
                else
                {
                    chkClients.ForeColor = Color.DarkBlue; //Clients
                    chkFournisseurs.ForeColor = Color.DarkBlue; //Fournisseurs
                    chkContacts.ForeColor = Color.DarkBlue; //Contacts
                    chkContactsVendeurs.ForeColor = Color.DarkBlue; //ContactsVendeurs
                    chkRapports.ForeColor = Color.DarkBlue; //Rapport
                    chkCatalogueMec.ForeColor = Color.DarkBlue; //CatalogueMec
                    chkCatalogueElec.ForeColor = Color.DarkBlue; //CatalogueElec
                    chkEmployes.ForeColor = Color.DarkBlue; //Employes
                    chkCedule.ForeColor = Color.DarkBlue; //Cedule
                    chkConfiguration.ForeColor = Color.DarkBlue; //Configuration
                    chkPunch.ForeColor = Color.DarkBlue; //Punch
                    chkOutils.ForeColor = Color.DarkBlue; //Outils
                    chkSoumissionMec.ForeColor = Color.DarkBlue; //SoumissionMec
                    chkProjetMec.ForeColor = Color.DarkBlue; //ProjetMec
                    chkSoumissionElec.ForeColor = Color.DarkBlue; //SoumissionElec
                    chkProjetElec.ForeColor = Color.DarkBlue; //ProjetElec
                    chkInventaireMec.ForeColor = Color.DarkBlue; //InventaireMec
                    chkInventaireElec.ForeColor = Color.DarkBlue; //InventaireElec
                    chkAchat.ForeColor = Color.DarkBlue; //ACHAT
                    chkModificationFacturation.ForeColor = Color.DarkBlue; //ModificationFacturation
                    chkModificationClients.ForeColor = Color.DarkBlue; //ModificationClients
                    chkModificationFRS.ForeColor = Color.DarkBlue; //ModificationFournisseurs
                    chkModificationContacts.ForeColor = Color.DarkBlue; //ModificationContacts
                    chkModificationEmployes.ForeColor = Color.DarkBlue; //ModificationEmployes
                    chkModificationGroupes.ForeColor = Color.DarkBlue; //ModificationGroupes
                    chkModificationFeuillesTemps.ForeColor = Color.DarkBlue; //ModificationFeuillesTemps
                    chkModificationOutils.ForeColor = Color.DarkBlue; //ModificationOutils
                    chkModificationSoumissionMec.ForeColor = Color.DarkBlue; //ModificationSoumissionsMec
                    chkModificationProjetMec.ForeColor = Color.DarkBlue; //ModificationProjetsMec
                    chkModificationSoumissionElec.ForeColor = Color.DarkBlue; //ModificationSoumissionsElec
                    chkModificationProjetElec.ForeColor = Color.DarkBlue; //ModificationProjetsElec
                    chkModificationBonsCommandes.ForeColor = Color.DarkBlue; //ModificationBonsCommandes
                    chkModificationCatalogueElec.ForeColor = Color.DarkBlue; //ModificationCatalogueElec
                    chkModificationCatalogueMec.ForeColor = Color.DarkBlue; //ModificationCatalogueMec
                    chkModificationInventaireMec.ForeColor = Color.DarkBlue; //ModificationInventaireMec
                    chkModificationInventaireElec.ForeColor = Color.DarkBlue; //ModificationInventaireElec
                    chkModificationPunchEmployes.ForeColor = Color.DarkBlue; //ModificationPunchEmployes
                    chkSupprimerProjets.ForeColor = Color.DarkBlue; //SuppressionProjets
                    chkReception.ForeColor = Color.DarkBlue; //ModificationReception
                    chkRetourMarchandise.ForeColor = Color.DarkBlue; //ModificationRetourMarchandise
                    chkMailingList.ForeColor = Color.DarkBlue; //ListeDistribution
                    chkPunchSemaineAnterieure.ForeColor = Color.DarkBlue; //PunchSemaineAntérieure
                    chkVerrouillageTempsProjet.ForeColor = Color.DarkBlue; //VerrouillageTempsProjet
                    chkDeverrouillageTempsProjet.ForeColor = Color.DarkBlue; //DéverrouillageTempsProjet

                }
                rstGroupes.Close();
                rstGroupes = null;
                AfficherUtilisateurs();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "AfficherGroupe", ex);
            }
        }
        [Obsolete]
        private void AfficherUtilisateurs()
        {
            try
            {
                ADODB.Recordset rstEmployes;
                lstUser.Items.Clear();
                rstEmployes = new Recordset();
                rstEmployes.Open($"SELECT * FROM EMPLOYÉS " +
                    $"JOIN [DBO].[GROUPES] ON[DBO].[EMPLOYÉS].GROUPE =[DBO].[GROUPES].[IDGROUPE] " +
                    $"WHERE[DBO].[GROUPES].[NOMGROUPE] = '{cmbGroupe.Items[cmbGroupe.SelectedIndex].ToString()}' AND[DBO].[EMPLOYÉS].ACTIF = 1 " +
                    $"ORDER BY[DBO].[GROUPES].[NOMGROUPE],[DBO].[EMPLOYÉS].EMPLOYE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstEmployes.EOF)
                {
                    lstUser.Items.Add($"{rstEmployes.Fields["noemploye"].Value} | {$"{rstEmployes.Fields["groupe"].Value}".PadLeft(3, '0')} | {rstEmployes.Fields["employe"].Value}");
                    rstEmployes.MoveNext();
                }
                rstEmployes.Close();
                rstEmployes = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "AfficherUtilisateurs", ex);
            }
        }
        private void UncheckedAll()
        {
            try
            {
                foreach (var objControl in Controls)
                {
                    if (objControl is CheckBox)
                    {
                        ((dynamic)objControl).Value = CheckState.Unchecked;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Groupes", "UncheckedAll", ex);
            }
        }
        private void cmdAddUser_Click(object sender, EventArgs e)
        {
            UpdateSQL($"UPDATE [DBO].[EMPLOYÉS] SET[GROUPE] = '{m_iNoGroupe}' WHERE [EMPLOYE]='{Employe.nomUtilisateur}'");
            AfficherUtilisateurs();
            if (MessageBox.Show("Fermeture automatique est prévue\n continuer?", "DataUpdate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmdFermer_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<DB_Groupes> Groupes= new List<DB_Groupes>();
            Recordset rd = new Recordset();
            rd.Open("SELECT * FROM [dbo].[Groupes]", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                Groupes.Add(new DB_Groupes()
                {
                    Idgroupe = (int)rd.Fields[0].Value, // IDGroupe AutoIncrémentable
                    NomGroupe = $"{rd.Fields[1].Value}", // NomGroupe
                    Clients = (bool)rd.Fields[2].Value, // Clients
                    Fournisseurs = (bool)rd.Fields[3].Value, // Fournisseurs
                    Contacts = (bool)rd.Fields[4].Value, // Contacts
                    ContactsVendeurs = (bool)rd.Fields[5].Value, // ContactsVendeurs
                    Rapport = (bool)rd.Fields[6].Value, // Rapport
                    CatalogueMec = (bool)rd.Fields[7].Value, // CatalogueMec
                    CatalogueElec = (bool)rd.Fields[8].Value, // CatalogueElec
                    Employes = (bool)rd.Fields[9].Value, // Employes
                    Cedule = (bool)rd.Fields[10].Value, // Cedule
                    Configuration = (bool)rd.Fields[11].Value, // Configuration
                    Punch = (bool)rd.Fields[12].Value, // Punch
                    Outils = (bool)rd.Fields[13].Value, // Outils
                    SoumissionMec = (bool)rd.Fields[14].Value, // SoumissionMec
                    ProjetMec = (bool)rd.Fields[15].Value, // ProjetMec
                    SoumissionElec = (bool)rd.Fields[16].Value, // SoumissionElec
                    ProjetElec = (bool)rd.Fields[17].Value, // ProjetElec
                    InventaireElec = (bool)rd.Fields[18].Value, // InventaireMec
                    InventaireMec = (bool)rd.Fields[19].Value, // InventaireElec
                    ACHAT = (bool)rd.Fields[20].Value, // Achat
                    ModificationFacturation = (bool)rd.Fields[21].Value, // ModificationFacturation
                    ModificationClients = (bool)rd.Fields[22].Value, // ModificationClients
                    ModificationFournisseurs = (bool)rd.Fields[23].Value, // ModificationFournisseurs
                    ModificationContacts = (bool)rd.Fields[24].Value, // ModificationContacts
                    ModificationGroupes = (bool)rd.Fields[25].Value, // ModificationGroupes
                    ModificationEmployes = (bool)rd.Fields[26].Value, // ModificationEmployes
                    ModificationFeuillesTemps = (bool)rd.Fields[27].Value, // ModificationFeuillesTemps
                    ModificationOutils = (bool)rd.Fields[28].Value, // ModificationOutils
                    ModificationSoumissionsMec = (bool)rd.Fields[29].Value, // ModificationSoumissionsMec
                    ModificationProjetsMec = (bool)rd.Fields[30].Value, // ModificationProjetsMec
                    ModificationSoumissionsElec = (bool)rd.Fields[31].Value, // ModificationSoumissionsElec
                    ModificationProjetsElec = (bool)rd.Fields[32].Value, // ModificationProjetsElec
                    ModificationBonsCommandes = (bool)rd.Fields[33].Value, // ModificationBonsCommandes
                    ModificationCatalogueElec = (bool)rd.Fields[34].Value, // ModificationCatalogueElec
                    ModificationCatalogueMec = (bool)rd.Fields[35].Value, // ModificationCatalogueMec
                    ModificationInventaireMec = (bool)rd.Fields[36].Value, // ModificationInventaireMec
                    ModificationInventaireElec = (bool)rd.Fields[37].Value, // ModificationInventaireElec
                    ModificationPunchEmployes = (bool)rd.Fields[38].Value, // ModificationPunchEmployes
                    ModificationReception = (bool)rd.Fields[39].Value, // ModificationReception
                    ModificationRetourMarchandise = (bool)rd.Fields[40].Value, // ModificationRetourMarchandise
                    SuppressionProjets = (bool)rd.Fields[41].Value, // SuppressionProjets
                    ListeDistribution = (bool)rd.Fields[42].Value, // ListeDistribution
                    PunchSemaineAnterieure = (bool)rd.Fields[43].Value, // PunchSemaineAntérieure
                    VerrouillageTempsProjet = (bool)rd.Fields[44].Value, // VerrouillageTempsProjet
                    DeverrouillageTempsProjet = (bool)rd.Fields[45].Value // DéverrouillageTempsProjet
                });
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            int r;
            Microsoft.Office.Interop.Excel.Application oXLApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oXLBook = oXLApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet oXLSheet = (Microsoft.Office.Interop.Excel.Worksheet)oXLBook.Worksheets[1];
            oXLApp.Visible = true;
            Conteneur.txtStatus.Text = "Transfert vers Excel de " + Text;
            oXLSheet.get_Range("B:R").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            //Cells[Y,X] en appli Web
            //Range[x,y] en appli desktop
//            oXLSheet.Cells[1, 2] = GetNomMois(DateTime.Today.Month) + DateTime.Today.Year;
            oXLSheet.get_Range("B1: R1").Font.Bold = true;
            oXLSheet.get_Range("B1: R2").set_Value(value: new object[] { "ADMINISTRATEUR", "RÉCEPTION", "VENDEUR", "PAR DÉFAUT", "SOUMISSIONNAIRE", "SUPERVISEUR", "DESSINATEUR MÉCANIQUE", "DESSINATEUR ÉLECTRIQUE", "TECHNICIEN ÉLECTRIQUE", "COMPTABILITÉ", "COORDONNATEUR DES VENTES", "CHARGÉ DE PROJET", "DIRECTION DES VENTES", "CHEF DE DÉPARTEMENT", "VENDEUR 2", "STAGIAIRE", "IT" });
            oXLSheet.get_Range("A:R").Columns.AutoFit();
            oXLSheet.Name = Application.ProductName+"."+Name;
            oXLSheet.Cells[2, 1] = "IDGROUPE";
            oXLSheet.Cells[3, 1] = "CLIENTS";
            oXLSheet.Cells[4, 1] = "FOURNISSEURS";
            oXLSheet.Cells[5, 1] = "CONTACTS";
            oXLSheet.Cells[6, 1] = "CONTACTSVENDEURS";
            oXLSheet.Cells[7, 1] = "RAPPORT";
            oXLSheet.Cells[8, 1] = "CATALOGUEMEC";
            oXLSheet.Cells[9, 1] = "CATALOGUEELEC";
            oXLSheet.Cells[10, 1] = "EMPLOYES";
            oXLSheet.Cells[11, 1] = "CEDULE";
            oXLSheet.Cells[12, 1] = "CONFIGURATION";
            oXLSheet.Cells[13, 1] = "PUNCH";
            oXLSheet.Cells[14, 1] = "OUTILS";
            oXLSheet.Cells[15, 1] = "SOUMISSIONMEC";
            oXLSheet.Cells[16, 1] = "PROJETMEC";
            oXLSheet.Cells[17, 1] = "SOUMISSIONELEC";
            oXLSheet.Cells[18, 1] = "PROJETELEC";
            oXLSheet.Cells[19, 1] = "INVENTAIREELEC";
            oXLSheet.Cells[20, 1] = "INVENTAIREMEC";
            oXLSheet.Cells[21, 1] = "ACHAT";
            oXLSheet.Cells[22, 1] = "MODIFICATION FACTURATION";
            oXLSheet.Cells[23, 1] = "MODIFICATION CLIENTS";
            oXLSheet.Cells[24, 1] = "MODIFICATION FOURNISSEURS";
            oXLSheet.Cells[25, 1] = "MODIFICATION CONTACTS";
            oXLSheet.Cells[26, 1] = "MODIFICATION GROUPES";
            oXLSheet.Cells[27, 1] = "MODIFICATION EMPLOYES";
            oXLSheet.Cells[28, 1] = "MODIFICATION FEUILLES TEMPS";
            oXLSheet.Cells[29, 1] = "MODIFICATION OUTILS";
            oXLSheet.Cells[30, 1] = "MODIFICATION SOUMISSIONS MEC";
            oXLSheet.Cells[31, 1] = "MODIFICATION PROJETS MEC";
            oXLSheet.Cells[32, 1] = "MODIFICATION SOUMISSIONS ELEC";
            oXLSheet.Cells[33, 1] = "MODIFICATION PROJETS ELEC";
            oXLSheet.Cells[34, 1] = "MODIFICATION BONS COMMANDES";
            oXLSheet.Cells[35, 1] = "MODIFICATION CATALOGUE ELEC";
            oXLSheet.Cells[36, 1] = "MODIFICATION CATALOGUE MEC";
            oXLSheet.Cells[37, 1] = "MODIFICATION INVENTAIRE MEC";
            oXLSheet.Cells[38, 1] = "MODIFICATION INVENTAIRE ELEC";
            oXLSheet.Cells[39, 1] = "MODIFICATION PUNCH EMPLOYES";
            oXLSheet.Cells[40, 1] = "MODIFICATION RECEPTION";
            oXLSheet.Cells[41, 1] = "MODIFICATION RETOUR MARCHANDISE";
            oXLSheet.Cells[42, 1] = "SUPPRESSION PROJETS";
            oXLSheet.Cells[43, 1] = "LISTE DISTRIBUTION";
            oXLSheet.Cells[44, 1] = "PUNCH SEMAINE ANTERIEURE";
            oXLSheet.Cells[45, 1] = "VERROUILLAGE TEMPS PROJET";
            oXLSheet.Cells[46, 1] = "DEVERROUILLAGE TEMPS PROJET";

            for (int x=0; x< Groupes.Count; x++)
            {
                oXLSheet.Cells[2, x + 2] = (int)Groupes[x].Idgroupe;
                oXLSheet.Cells[3, x + 2] = Bool2Int(Groupes[x].Clients);     //CLIENTS
                oXLSheet.Cells[4, x + 2] = Bool2Int(Groupes[x].Fournisseurs);     //FOURNISSEURS
                oXLSheet.Cells[5, x + 2] = Bool2Int(Groupes[x].Contacts);     //CONTACTS
                oXLSheet.Cells[6, x + 2] = Bool2Int(Groupes[x].ContactsVendeurs);     //CONTACTSVENDEURS
                oXLSheet.Cells[7, x + 2] = Bool2Int(Groupes[x].Rapport);     //RAPPORT
                oXLSheet.Cells[8, x + 2] = Bool2Int(Groupes[x].CatalogueMec);     //CATALOGUEMEC
                oXLSheet.Cells[9, x + 2] = Bool2Int(Groupes[x].CatalogueElec);     //CATALOGUEELEC
                oXLSheet.Cells[10, x + 2] = Bool2Int(Groupes[x].Employes);    //EMPLOYES
                oXLSheet.Cells[11, x + 2] = Bool2Int(Groupes[x].Cedule);    //CEDULE
                oXLSheet.Cells[12, x + 2] = Bool2Int(Groupes[x].Configuration);    //CONFIGURATION
                oXLSheet.Cells[13, x + 2] = Bool2Int(Groupes[x].Punch);    //PUNCH
                oXLSheet.Cells[14, x + 2] = Bool2Int(Groupes[x].Outils);    //OUTILS
                oXLSheet.Cells[15, x + 2] = Bool2Int(Groupes[x].SoumissionMec);    //SOUMISSIONMEC
                oXLSheet.Cells[16, x + 2] = Bool2Int(Groupes[x].ProjetMec);    //PROJETMEC
                oXLSheet.Cells[17, x + 2] = Bool2Int(Groupes[x].SoumissionElec);    //SOUMISSIONELEC
                oXLSheet.Cells[18, x + 2] = Bool2Int(Groupes[x].ProjetElec);    //PROJETELEC
                oXLSheet.Cells[19, x + 2] = Bool2Int(Groupes[x].InventaireElec);    //INVENTAIREELEC
                oXLSheet.Cells[20, x + 2] = Bool2Int(Groupes[x].InventaireMec);    //INVENTAIREMEC
                oXLSheet.Cells[21, x + 2] = Bool2Int(Groupes[x].ACHAT);    //ACHAT
                oXLSheet.Cells[22, x + 2] = Bool2Int(Groupes[x].ModificationFacturation);    //MODIFICATION FACTURATION
                oXLSheet.Cells[23, x + 2] = Bool2Int(Groupes[x].ModificationClients);    //MODIFICATION CLIENTS
                oXLSheet.Cells[24, x + 2] = Bool2Int(Groupes[x].ModificationFournisseurs);    //MODIFICATION FOURNISSEURS
                oXLSheet.Cells[25, x + 2] = Bool2Int(Groupes[x].ModificationContacts);    //MODIFICATION CONTACTS
                oXLSheet.Cells[26, x + 2] = Bool2Int(Groupes[x].ModificationGroupes);    //MODIFICATION GROUPES
                oXLSheet.Cells[27, x + 2] = Bool2Int(Groupes[x].ModificationEmployes);    //MODIFICATION EMPLOYES
                oXLSheet.Cells[28, x + 2] = Bool2Int(Groupes[x].ModificationFeuillesTemps);    //MODIFICATION FEUILLES TEMPS
                oXLSheet.Cells[29, x + 2] = Bool2Int(Groupes[x].ModificationOutils);    //MODIFICATION OUTILS
                oXLSheet.Cells[30, x + 2] = Bool2Int(Groupes[x].ModificationSoumissionsMec);    //MODIFICATION SOUMISSIONS MEC
                oXLSheet.Cells[31, x + 2] = Bool2Int(Groupes[x].ProjetMec);    //MODIFICATION PROJETS MEC
                oXLSheet.Cells[32, x + 2] = Bool2Int(Groupes[x].ModificationSoumissionsElec);    //MODIFICATION SOUMISSIONS ELEC
                oXLSheet.Cells[33, x + 2] = Bool2Int(Groupes[x].ModificationProjetsElec);    //MODIFICATION PROJETS ELEC
                oXLSheet.Cells[34, x + 2] = Bool2Int(Groupes[x].ModificationBonsCommandes);    //MODIFICATION BONS COMMANDES
                oXLSheet.Cells[35, x + 2] = Bool2Int(Groupes[x].ModificationCatalogueElec);    //MODIFICATION CATALOGUE ELEC
                oXLSheet.Cells[36, x + 2] = Bool2Int(Groupes[x].ModificationCatalogueMec);    //MODIFICATION CATALOGUE MEC
                oXLSheet.Cells[37, x + 2] = Bool2Int(Groupes[x].ModificationInventaireMec);    //MODIFICATION INVENTAIRE MEC
                oXLSheet.Cells[38, x + 2] = Bool2Int(Groupes[x].ModificationInventaireElec);    //MODIFICATION INVENTAIRE ELEC
                oXLSheet.Cells[39, x + 2] = Bool2Int(Groupes[x].ModificationPunchEmployes);    //MODIFICATION PUNCH EMPLOYES
                oXLSheet.Cells[40, x + 2] = Bool2Int(Groupes[x].ModificationReception);    //MODIFICATION RECEPTION
                oXLSheet.Cells[41, x + 2] = Bool2Int(Groupes[x].ModificationRetourMarchandise);    //MODIFICATION RETOUR MARCHANDISE
                oXLSheet.Cells[42, x + 2] = Bool2Int(Groupes[x].SuppressionProjets);    //SUPPRESSION PROJETS
                oXLSheet.Cells[43, x + 2] = Bool2Int(Groupes[x].ListeDistribution);    //LISTE DISTRIBUTION
                oXLSheet.Cells[44, x + 2] = Bool2Int(Groupes[x].PunchSemaineAnterieure);    //PUNCH SEMAINE ANTERIEURE
                oXLSheet.Cells[45, x + 2] = Bool2Int(Groupes[x].VerrouillageTempsProjet);    //VERROUILLAGE TEMPS PROJET
                oXLSheet.Cells[46, x + 2] = Bool2Int(Groupes[x].DeverrouillageTempsProjet);    //DEVERROUILLAGE TEMPS PROJET
            }
            oXLSheet.SaveAs(Filename: oXLSheet.Name + ".xlsx");// force le mode Excel 2007/2010
        }
    }
}