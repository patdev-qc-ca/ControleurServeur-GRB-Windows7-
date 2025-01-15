using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ADODB;
using ControleurServeur;
using System.Diagnostics;
namespace ControleurServeur
{
    internal class Rapports : Form
    {
        #region Windows form Designer generated code 
        [DebuggerNonUserCode()]
        public Rapports() : base()
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
        internal static ComboBox cmbFournisseur2;
        internal static Button cmdRechercherFRS2;
        internal static TextBox txtMsg;
        internal static CheckBox chkProblemes;
        internal static TextBox txtObjet;
        internal static Button cmdMsg;
        internal static TextBox txtDe;
        internal static TextBox txtPage;
        internal static CheckBox chkFaxAnglais;
        internal static CheckBox chkFaxFrancais;
        internal static CheckBox chkBonLivraison;
        internal static Button cmdSelect;
        internal static CheckBox ChkFinFab;
        internal static CheckBox ChkFabFerm;
        internal static CheckBox ChkFabFermMéca;
        internal static CheckBox ChkProg;
        internal static CheckBox ChkConcept;
        internal static CheckBox ChkFourn;
        internal static CheckBox ChkClient;
        internal static CheckBox ChkBonTravail;
        internal static Label lblObjet;
        internal static Label lblDe;
        internal static Label lblPage;
        internal static GroupBox fraChoixRapport;
        internal static ComboBox cmbContactFRS;
        internal static Button cmdRechercherFRS;
        internal static Button cmdRechercherClient2;
        internal static Button cmdRechercherClient;
        internal static MaskedTextBox mskDateTravaux;
        internal static TextBox txtProjetClient;
        internal static Button cmdReport;
        internal static ComboBox cmbFournisseur;
        internal static TextBox txtTransport;
        internal static TextBox txtNomProjet;
        internal static TextBox txtNoCommande;
        internal static TextBox txtNoProjet;
        internal static TextBox txtNoSoumission;
        internal static Button cmdFermer;
        internal static ComboBox cmbGRB;
        internal static ComboBox cmbContact;
        internal static ComboBox cmbClient;
        internal static ComboBox cmbClient2;
        internal static MaskedTextBox mskHeureTravaux;
        internal static Label lblFournisseur2;
        internal static Label lblDateDue;
        internal static Label lblFormatHeurePrevue;
        internal static Label lblContactFRS;
        internal static Label lblHeureTravaux;
        internal static Label lblProjetClient;
        internal static Label lblFournisseur;
        internal static Label lblDateLivraison;
        internal static Label lblTransport;
        internal static Label lblClient2;
        internal static Label lblClient;
        internal static Label lblDate;
        internal static Label lblDateTravaux;
        internal static Label lblNomProjet;
        internal static Label lblDateCommande;
        internal static Label lblNoCommande;
        internal static Label lblNoProjet;
        internal static Label lblNoSoumission;
        internal static Label lblGRB;
        private DateTimePicker mskDateDue;
        private DateTimePicker mskDateCommande;
        private DateTimePicker mskDate;
        private DateTimePicker mskDateLivraison;
        internal static Label lblContact;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmbFournisseur2 = new System.Windows.Forms.ComboBox();
            cmdRechercherFRS2 = new System.Windows.Forms.Button();
            fraChoixRapport = new System.Windows.Forms.GroupBox();
            txtMsg = new System.Windows.Forms.TextBox();
            chkProblemes = new System.Windows.Forms.CheckBox();
            txtObjet = new System.Windows.Forms.TextBox();
            cmdMsg = new System.Windows.Forms.Button();
            txtDe = new System.Windows.Forms.TextBox();
            txtPage = new System.Windows.Forms.TextBox();
            chkFaxAnglais = new System.Windows.Forms.CheckBox();
            chkFaxFrancais = new System.Windows.Forms.CheckBox();
            chkBonLivraison = new System.Windows.Forms.CheckBox();
            cmdSelect = new System.Windows.Forms.Button();
            ChkFinFab = new System.Windows.Forms.CheckBox();
            ChkFabFerm = new System.Windows.Forms.CheckBox();
            ChkFabFermMéca = new System.Windows.Forms.CheckBox();
            ChkProg = new System.Windows.Forms.CheckBox();
            ChkConcept = new System.Windows.Forms.CheckBox();
            ChkFourn = new System.Windows.Forms.CheckBox();
            ChkClient = new System.Windows.Forms.CheckBox();
            ChkBonTravail = new System.Windows.Forms.CheckBox();
            lblObjet = new System.Windows.Forms.Label();
            lblDe = new System.Windows.Forms.Label();
            lblPage = new System.Windows.Forms.Label();
            cmbContactFRS = new System.Windows.Forms.ComboBox();
            cmdRechercherFRS = new System.Windows.Forms.Button();
            cmdRechercherClient2 = new System.Windows.Forms.Button();
            cmdRechercherClient = new System.Windows.Forms.Button();
            mskDateTravaux = new System.Windows.Forms.MaskedTextBox();
            txtProjetClient = new System.Windows.Forms.TextBox();
            cmdReport = new System.Windows.Forms.Button();
            cmbFournisseur = new System.Windows.Forms.ComboBox();
            txtTransport = new System.Windows.Forms.TextBox();
            txtNomProjet = new System.Windows.Forms.TextBox();
            txtNoCommande = new System.Windows.Forms.TextBox();
            txtNoProjet = new System.Windows.Forms.TextBox();
            txtNoSoumission = new System.Windows.Forms.TextBox();
            cmdFermer = new System.Windows.Forms.Button();
            cmbGRB = new System.Windows.Forms.ComboBox();
            cmbContact = new System.Windows.Forms.ComboBox();
            cmbClient = new System.Windows.Forms.ComboBox();
            cmbClient2 = new System.Windows.Forms.ComboBox();
            mskHeureTravaux = new System.Windows.Forms.MaskedTextBox();
            lblFournisseur2 = new System.Windows.Forms.Label();
            lblDateDue = new System.Windows.Forms.Label();
            lblFormatHeurePrevue = new System.Windows.Forms.Label();
            lblContactFRS = new System.Windows.Forms.Label();
            lblHeureTravaux = new System.Windows.Forms.Label();
            lblProjetClient = new System.Windows.Forms.Label();
            lblFournisseur = new System.Windows.Forms.Label();
            lblDateLivraison = new System.Windows.Forms.Label();
            lblTransport = new System.Windows.Forms.Label();
            lblClient2 = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblDateTravaux = new System.Windows.Forms.Label();
            lblNomProjet = new System.Windows.Forms.Label();
            lblDateCommande = new System.Windows.Forms.Label();
            lblNoCommande = new System.Windows.Forms.Label();
            lblNoProjet = new System.Windows.Forms.Label();
            lblNoSoumission = new System.Windows.Forms.Label();
            lblGRB = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            mskDateDue = new System.Windows.Forms.DateTimePicker();
            mskDateCommande = new System.Windows.Forms.DateTimePicker();
            mskDate = new System.Windows.Forms.DateTimePicker();
            mskDateLivraison = new System.Windows.Forms.DateTimePicker();
            fraChoixRapport.SuspendLayout();
            SuspendLayout();
            /*ToolTip1*/
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;
            /*cmbFournisseur2*/
            cmbFournisseur2.BackColor = System.Drawing.Color.Black;
            cmbFournisseur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFournisseur2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbFournisseur2.ForeColor = System.Drawing.Color.White;
            cmbFournisseur2.Location = new System.Drawing.Point(290, 520);
            cmbFournisseur2.Name = "cmbFournisseur2";
            cmbFournisseur2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbFournisseur2.Size = new System.Drawing.Size(273, 22);
            cmbFournisseur2.Sorted = true;
            cmbFournisseur2.TabIndex = 67;
            cmbFournisseur2.SelectedIndexChanged += new System.EventHandler(cmbFournisseur2_SelectedIndexChanged);
            /*cmdRechercherFRS2*/
            cmdRechercherFRS2.BackColor = System.Drawing.Color.Black;
            cmdRechercherFRS2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRechercherFRS2.ForeColor = System.Drawing.Color.White;
            cmdRechercherFRS2.Location = new System.Drawing.Point(570, 520);
            cmdRechercherFRS2.Name = "cmdRechercherFRS2";
            cmdRechercherFRS2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercherFRS2.Size = new System.Drawing.Size(25, 21);
            cmdRechercherFRS2.TabIndex = 66;
            cmdRechercherFRS2.Text = "..";
            cmdRechercherFRS2.UseVisualStyleBackColor = true;
            cmdRechercherFRS2.Click += new System.EventHandler(cmdRechercherFRS2_Click);
            /*fraChoixRapport*/
            fraChoixRapport.AutoSize = true;
            fraChoixRapport.BackColor = System.Drawing.Color.Black;
            fraChoixRapport.Controls.Add(txtMsg);
            fraChoixRapport.Controls.Add(chkProblemes);
            fraChoixRapport.Controls.Add(txtObjet);
            fraChoixRapport.Controls.Add(cmdMsg);
            fraChoixRapport.Controls.Add(txtDe);
            fraChoixRapport.Controls.Add(txtPage);
            fraChoixRapport.Controls.Add(chkFaxAnglais);
            fraChoixRapport.Controls.Add(chkFaxFrancais);
            fraChoixRapport.Controls.Add(chkBonLivraison);
            fraChoixRapport.Controls.Add(cmdSelect);
            fraChoixRapport.Controls.Add(ChkFinFab);
            fraChoixRapport.Controls.Add(ChkFabFerm);
            fraChoixRapport.Controls.Add(ChkFabFermMéca);
            fraChoixRapport.Controls.Add(ChkProg);
            fraChoixRapport.Controls.Add(ChkConcept);
            fraChoixRapport.Controls.Add(ChkFourn);
            fraChoixRapport.Controls.Add(ChkClient);
            fraChoixRapport.Controls.Add(ChkBonTravail);
            fraChoixRapport.Controls.Add(lblObjet);
            fraChoixRapport.Controls.Add(lblDe);
            fraChoixRapport.Controls.Add(lblPage);
            fraChoixRapport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraChoixRapport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            fraChoixRapport.Location = new System.Drawing.Point(5, 56);
            fraChoixRapport.Name = "fraChoixRapport";
            fraChoixRapport.Padding = new System.Windows.Forms.Padding(0);
            fraChoixRapport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraChoixRapport.Size = new System.Drawing.Size(272, 487);
            fraChoixRapport.TabIndex = 1;
            fraChoixRapport.TabStop = false;
            fraChoixRapport.Text = "LISTE DE RAPPORT";
            /*txtMsg*/
            txtMsg.AcceptsReturn = true;
            txtMsg.BackColor = System.Drawing.Color.White;
            txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMsg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtMsg.ForeColor = System.Drawing.Color.White;
            txtMsg.Location = new System.Drawing.Point(0, 17);
            txtMsg.MaxLength = 0;
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtMsg.Size = new System.Drawing.Size(265, 241);
            txtMsg.TabIndex = 2;
            txtMsg.Visible = false;
            txtMsg.WordWrap = false;
            /*chkProblemes*/
            chkProblemes.BackColor = System.Drawing.Color.Black;
            chkProblemes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkProblemes.ForeColor = System.Drawing.Color.White;
            chkProblemes.Location = new System.Drawing.Point(16, 240);
            chkProblemes.Name = "chkProblemes";
            chkProblemes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkProblemes.Size = new System.Drawing.Size(137, 17);
            chkProblemes.TabIndex = 65;
            chkProblemes.Text = "PROBLÈMES";
            chkProblemes.UseVisualStyleBackColor = true;
            chkProblemes.CheckStateChanged += new System.EventHandler(chkProblemes_CheckStateChanged);
            /*txtObjet*/
            txtObjet.AcceptsReturn = true;
            txtObjet.BackColor = System.Drawing.Color.White;
            txtObjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtObjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtObjet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            txtObjet.Location = new System.Drawing.Point(48, 369);
            txtObjet.MaxLength = 0;
            txtObjet.Name = "txtObjet";
            txtObjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtObjet.Size = new System.Drawing.Size(193, 22);
            txtObjet.TabIndex = 19;
            /*cmdMsg*/
            cmdMsg.BackColor = System.Drawing.Color.Black;
            cmdMsg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdMsg.ForeColor = System.Drawing.Color.White;
            cmdMsg.Location = new System.Drawing.Point(163, 276);
            cmdMsg.Name = "cmdMsg";
            cmdMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdMsg.Size = new System.Drawing.Size(73, 25);
            cmdMsg.TabIndex = 14;
            cmdMsg.Text = "Message";
            cmdMsg.UseVisualStyleBackColor = true;
            cmdMsg.Click += new System.EventHandler(cmdmsg_Click);
            /*txtDe*/
            txtDe.AcceptsReturn = true;
            txtDe.BackColor = System.Drawing.Color.White;
            txtDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDe.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            txtDe.Location = new System.Drawing.Point(48, 345);
            txtDe.MaxLength = 0;
            txtDe.Name = "txtDe";
            txtDe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDe.Size = new System.Drawing.Size(145, 22);
            txtDe.TabIndex = 17;
            /*txtPage*/
            txtPage.AcceptsReturn = true;
            txtPage.BackColor = System.Drawing.Color.White;
            txtPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            txtPage.Location = new System.Drawing.Point(48, 321);
            txtPage.MaxLength = 0;
            txtPage.Name = "txtPage";
            txtPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPage.Size = new System.Drawing.Size(49, 22);
            txtPage.TabIndex = 16;
            /*chkFaxAnglais*/
            chkFaxAnglais.AutoSize = true;
            chkFaxAnglais.BackColor = System.Drawing.Color.Black;
            chkFaxAnglais.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkFaxAnglais.ForeColor = System.Drawing.Color.White;
            chkFaxAnglais.Location = new System.Drawing.Point(16, 288);
            chkFaxAnglais.Name = "chkFaxAnglais";
            chkFaxAnglais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkFaxAnglais.Size = new System.Drawing.Size(88, 18);
            chkFaxAnglais.TabIndex = 12;
            chkFaxAnglais.Text = "Fax Anglais";
            chkFaxAnglais.UseVisualStyleBackColor = true;
            chkFaxAnglais.CheckStateChanged += new System.EventHandler(chkFaxAnglais_CheckStateChanged);
            /*chkFaxFrancais*/
            chkFaxFrancais.AutoSize = true;
            chkFaxFrancais.BackColor = System.Drawing.Color.Black;
            chkFaxFrancais.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkFaxFrancais.ForeColor = System.Drawing.Color.White;
            chkFaxFrancais.Location = new System.Drawing.Point(16, 264);
            chkFaxFrancais.Name = "chkFaxFrancais";
            chkFaxFrancais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkFaxFrancais.Size = new System.Drawing.Size(93, 18);
            chkFaxFrancais.TabIndex = 13;
            chkFaxFrancais.Text = "Fax Français";
            chkFaxFrancais.UseVisualStyleBackColor = true;
            chkFaxFrancais.CheckStateChanged += new System.EventHandler(chkFaxFrancais_CheckStateChanged);
            /*chkBonLivraison*/
            chkBonLivraison.BackColor = System.Drawing.Color.Black;
            chkBonLivraison.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkBonLivraison.ForeColor = System.Drawing.Color.White;
            chkBonLivraison.Location = new System.Drawing.Point(16, 48);
            chkBonLivraison.Name = "chkBonLivraison";
            chkBonLivraison.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkBonLivraison.Size = new System.Drawing.Size(137, 17);
            chkBonLivraison.TabIndex = 4;
            chkBonLivraison.Text = "BON DE LIVRAISON";
            chkBonLivraison.UseVisualStyleBackColor = true;
            chkBonLivraison.CheckStateChanged += new System.EventHandler(chkBonLivraison_CheckStateChanged);
            /*cmdSelect*/
            cmdSelect.BackColor = System.Drawing.Color.Black;
            cmdSelect.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdSelect.ForeColor = System.Drawing.Color.White;
            cmdSelect.Location = new System.Drawing.Point(48, 401);
            cmdSelect.Name = "cmdSelect";
            cmdSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSelect.Size = new System.Drawing.Size(137, 31);
            cmdSelect.TabIndex = 21;
            cmdSelect.Text = "Sélectionner tout";
            cmdSelect.UseVisualStyleBackColor = true;
            cmdSelect.Click += new System.EventHandler(cmdselect_Click);
            /*ChkFinFab*/
            ChkFinFab.AutoSize = true;
            ChkFinFab.BackColor = System.Drawing.Color.Black;
            ChkFinFab.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChkFinFab.ForeColor = System.Drawing.Color.White;
            ChkFinFab.Location = new System.Drawing.Point(16, 216);
            ChkFinFab.Name = "ChkFinFab";
            ChkFinFab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ChkFinFab.Size = new System.Drawing.Size(138, 18);
            ChkFinFab.TabIndex = 11;
            ChkFinFab.Text = "FINS DE FABRICATION";
            ChkFinFab.UseVisualStyleBackColor = true;
            /*ChkFabFerm*/
            ChkFabFerm.BackColor = System.Drawing.Color.Black;
            ChkFabFerm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChkFabFerm.ForeColor = System.Drawing.Color.White;
            ChkFabFerm.Location = new System.Drawing.Point(16, 192);
            ChkFabFerm.Name = "ChkFabFerm";
            ChkFabFerm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ChkFabFerm.Size = new System.Drawing.Size(233, 17);
            ChkFabFerm.TabIndex = 10;
            ChkFabFerm.Text = "FABRICATION - FERMETURE";
            ChkFabFerm.UseVisualStyleBackColor = true;
            ChkFabFerm.CheckStateChanged += new System.EventHandler(chkFabFerm_CheckStateChanged);
            /*ChkFabFermMéca*/
            ChkFabFermMéca.BackColor = System.Drawing.Color.Black;
            ChkFabFermMéca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChkFabFermMéca.ForeColor = System.Drawing.Color.White;
            ChkFabFermMéca.Location = new System.Drawing.Point(16, 168);
            ChkFabFermMéca.Name = "ChkFabFermMéca";
            ChkFabFermMéca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ChkFabFermMéca.Size = new System.Drawing.Size(241, 17);
            ChkFabFermMéca.TabIndex = 9;
            ChkFabFermMéca.Text = "FABRICATION - FERMETURE MÉCANIQUE";
            ChkFabFermMéca.UseVisualStyleBackColor = true;
            ChkFabFermMéca.CheckStateChanged += new System.EventHandler(chkFabFermMéca_CheckStateChanged);
            /*ChkProg*/
            ChkProg.BackColor = System.Drawing.Color.Black;
            ChkProg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChkProg.ForeColor = System.Drawing.Color.White;
            ChkProg.Location = new System.Drawing.Point(16, 144);
            ChkProg.Name = "ChkProg";
            ChkProg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ChkProg.Size = new System.Drawing.Size(137, 17);
            ChkProg.TabIndex = 8;
            ChkProg.Text = "PROGRAMMATION";
            ChkProg.UseVisualStyleBackColor = true;
            ChkProg.CheckStateChanged += new System.EventHandler(chkProg_CheckStateChanged);
            /*ChkConcept*/
            ChkConcept.BackColor = System.Drawing.Color.Black;
            ChkConcept.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChkConcept.ForeColor = System.Drawing.Color.White;
            ChkConcept.Location = new System.Drawing.Point(16, 120);
            ChkConcept.Name = "ChkConcept";
            ChkConcept.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ChkConcept.Size = new System.Drawing.Size(137, 17);
            ChkConcept.TabIndex = 7;
            ChkConcept.Text = "CONCEPTION";
            ChkConcept.UseVisualStyleBackColor = true;
            ChkConcept.CheckStateChanged += new System.EventHandler(chkConcept_CheckStateChanged);
            /*ChkFourn*/
            ChkFourn.BackColor = System.Drawing.Color.Black;
            ChkFourn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChkFourn.ForeColor = System.Drawing.Color.White;
            ChkFourn.Location = new System.Drawing.Point(16, 96);
            ChkFourn.Name = "ChkFourn";
            ChkFourn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ChkFourn.Size = new System.Drawing.Size(137, 17);
            ChkFourn.TabIndex = 6;
            ChkFourn.Text = "FOURNISSEUR";
            ChkFourn.UseVisualStyleBackColor = true;
            ChkFourn.CheckStateChanged += new System.EventHandler(chkFourn_CheckStateChanged);
            /*ChkClient*/
            ChkClient.BackColor = System.Drawing.Color.Black;
            ChkClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChkClient.ForeColor = System.Drawing.Color.White;
            ChkClient.Location = new System.Drawing.Point(16, 72);
            ChkClient.Name = "ChkClient";
            ChkClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ChkClient.Size = new System.Drawing.Size(137, 17);
            ChkClient.TabIndex = 5;
            ChkClient.Text = "CLIENT";
            ChkClient.UseVisualStyleBackColor = true;
            ChkClient.CheckStateChanged += new System.EventHandler(chkClient_CheckStateChanged);
            /*ChkBonTravail*/
            ChkBonTravail.BackColor = System.Drawing.Color.Black;
            ChkBonTravail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChkBonTravail.ForeColor = System.Drawing.Color.White;
            ChkBonTravail.Location = new System.Drawing.Point(16, 24);
            ChkBonTravail.Name = "ChkBonTravail";
            ChkBonTravail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ChkBonTravail.Size = new System.Drawing.Size(137, 17);
            ChkBonTravail.TabIndex = 3;
            ChkBonTravail.Text = "BON DE TRAVAIL";
            ChkBonTravail.UseVisualStyleBackColor = true;
            ChkBonTravail.CheckStateChanged += new System.EventHandler(chkBonTravail_CheckStateChanged);
            /*lblObjet*/
            lblObjet.BackColor = System.Drawing.Color.Black;
            lblObjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblObjet.ForeColor = System.Drawing.Color.White;
            lblObjet.Location = new System.Drawing.Point(16, 369);
            lblObjet.Name = "lblObjet";
            lblObjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblObjet.Size = new System.Drawing.Size(33, 17);
            lblObjet.TabIndex = 20;
            lblObjet.Text = "Objet:";
            /*lblDe*/
            lblDe.BackColor = System.Drawing.Color.Black;
            lblDe.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDe.ForeColor = System.Drawing.Color.White;
            lblDe.Location = new System.Drawing.Point(16, 345);
            lblDe.Name = "lblDe";
            lblDe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDe.Size = new System.Drawing.Size(33, 17);
            lblDe.TabIndex = 18;
            lblDe.Text = "De:";
            /*lblPage*/
            lblPage.BackColor = System.Drawing.Color.Black;
            lblPage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPage.ForeColor = System.Drawing.Color.White;
            lblPage.Location = new System.Drawing.Point(16, 321);
            lblPage.Name = "lblPage";
            lblPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPage.Size = new System.Drawing.Size(33, 17);
            lblPage.TabIndex = 15;
            lblPage.Text = "Pages";
            /*cmbContactFRS*/
            cmbContactFRS.BackColor = System.Drawing.Color.White;
            cmbContactFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbContactFRS.ForeColor = System.Drawing.Color.White;
            cmbContactFRS.Location = new System.Drawing.Point(290, 472);
            cmbContactFRS.Name = "cmbContactFRS";
            cmbContactFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbContactFRS.Size = new System.Drawing.Size(273, 22);
            cmbContactFRS.TabIndex = 64;
            cmbContactFRS.SelectedIndexChanged += new System.EventHandler(cmbContactFRS_SelectedIndexChanged);
            /*cmdRechercherFRS*/
            cmdRechercherFRS.BackColor = System.Drawing.Color.Black;
            cmdRechercherFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRechercherFRS.ForeColor = System.Drawing.Color.White;
            cmdRechercherFRS.Location = new System.Drawing.Point(570, 432);
            cmdRechercherFRS.Name = "cmdRechercherFRS";
            cmdRechercherFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercherFRS.Size = new System.Drawing.Size(25, 21);
            cmdRechercherFRS.TabIndex = 60;
            cmdRechercherFRS.Text = "..";
            cmdRechercherFRS.UseVisualStyleBackColor = true;
            cmdRechercherFRS.Click += new System.EventHandler(cmdRechercherFRS_Click);
            /*cmdRechercherClient2*/
            cmdRechercherClient2.BackColor = System.Drawing.Color.Black;
            cmdRechercherClient2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRechercherClient2.ForeColor = System.Drawing.Color.White;
            cmdRechercherClient2.Location = new System.Drawing.Point(570, 352);
            cmdRechercherClient2.Name = "cmdRechercherClient2";
            cmdRechercherClient2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercherClient2.Size = new System.Drawing.Size(25, 21);
            cmdRechercherClient2.TabIndex = 53;
            cmdRechercherClient2.Text = "..";
            cmdRechercherClient2.UseVisualStyleBackColor = true;
            cmdRechercherClient2.Click += new System.EventHandler(cmdRechercherClient2_Click);
            /*cmdRechercherClient*/
            cmdRechercherClient.BackColor = System.Drawing.Color.Black;
            cmdRechercherClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRechercherClient.ForeColor = System.Drawing.Color.White;
            cmdRechercherClient.Location = new System.Drawing.Point(570, 24);
            cmdRechercherClient.Name = "cmdRechercherClient";
            cmdRechercherClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercherClient.Size = new System.Drawing.Size(25, 21);
            cmdRechercherClient.TabIndex = 23;
            cmdRechercherClient.Text = "..";
            cmdRechercherClient.UseVisualStyleBackColor = true;
            cmdRechercherClient.Click += new System.EventHandler(cmdRechercherClient_Click);
            /*mskDateTravaux*/
            mskDateTravaux.AllowPromptAsInput = false;
            mskDateTravaux.BackColor = System.Drawing.Color.White;
            mskDateTravaux.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskDateTravaux.ForeColor = System.Drawing.Color.White;
            mskDateTravaux.Location = new System.Drawing.Point(290, 312);
            mskDateTravaux.Name = "mskDateTravaux";
            mskDateTravaux.Size = new System.Drawing.Size(73, 22);
            mskDateTravaux.TabIndex = 47;
            /*txtProjetClient*/
            txtProjetClient.AcceptsReturn = true;
            txtProjetClient.BackColor = System.Drawing.Color.White;
            txtProjetClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtProjetClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtProjetClient.ForeColor = System.Drawing.Color.White;
            txtProjetClient.Location = new System.Drawing.Point(402, 232);
            txtProjetClient.MaxLength = 0;
            txtProjetClient.Name = "txtProjetClient";
            txtProjetClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtProjetClient.Size = new System.Drawing.Size(177, 22);
            txtProjetClient.TabIndex = 39;
            /*cmdReport*/
            cmdReport.BackColor = System.Drawing.Color.Black;
            cmdReport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdReport.ForeColor = System.Drawing.Color.White;
            cmdReport.Location = new System.Drawing.Point(423, 583);
            cmdReport.Name = "cmdReport";
            cmdReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdReport.Size = new System.Drawing.Size(89, 30);
            cmdReport.TabIndex = 61;
            cmdReport.Text = "Impression";
            cmdReport.UseVisualStyleBackColor = true;
            cmdReport.Click += new System.EventHandler(cmdreport_Click);
            /*cmbFournisseur*/
            cmbFournisseur.BackColor = System.Drawing.Color.White;
            cmbFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbFournisseur.ForeColor = System.Drawing.Color.White;
            cmbFournisseur.Location = new System.Drawing.Point(290, 432);
            cmbFournisseur.Name = "cmbFournisseur";
            cmbFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbFournisseur.Size = new System.Drawing.Size(273, 22);
            cmbFournisseur.TabIndex = 59;
            cmbFournisseur.Text = "cmbFournisseur";
            cmbFournisseur.SelectedIndexChanged += new System.EventHandler(cmbFournisseur_SelectedIndexChanged);
            /*txtTransport*/
            txtTransport.AcceptsReturn = true;
            txtTransport.BackColor = System.Drawing.Color.White;
            txtTransport.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTransport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTransport.ForeColor = System.Drawing.Color.White;
            txtTransport.Location = new System.Drawing.Point(290, 392);
            txtTransport.MaxLength = 0;
            txtTransport.Name = "txtTransport";
            txtTransport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTransport.Size = new System.Drawing.Size(177, 22);
            txtTransport.TabIndex = 56;
            /*txtNomProjet*/
            txtNomProjet.AcceptsReturn = true;
            txtNomProjet.BackColor = System.Drawing.Color.White;
            txtNomProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNomProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNomProjet.ForeColor = System.Drawing.Color.White;
            txtNomProjet.Location = new System.Drawing.Point(402, 192);
            txtNomProjet.MaxLength = 0;
            txtNomProjet.Name = "txtNomProjet";
            txtNomProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNomProjet.Size = new System.Drawing.Size(177, 22);
            txtNomProjet.TabIndex = 35;
            /*txtNoCommande*/
            txtNoCommande.AcceptsReturn = true;
            txtNoCommande.BackColor = System.Drawing.Color.White;
            txtNoCommande.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoCommande.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNoCommande.ForeColor = System.Drawing.Color.White;
            txtNoCommande.Location = new System.Drawing.Point(458, 272);
            txtNoCommande.MaxLength = 0;
            txtNoCommande.Name = "txtNoCommande";
            txtNoCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoCommande.Size = new System.Drawing.Size(121, 22);
            txtNoCommande.TabIndex = 44;
            /*txtNoProjet*/
            txtNoProjet.AcceptsReturn = true;
            txtNoProjet.BackColor = System.Drawing.Color.White;
            txtNoProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNoProjet.ForeColor = System.Drawing.Color.White;
            txtNoProjet.Location = new System.Drawing.Point(290, 192);
            txtNoProjet.MaxLength = 0;
            txtNoProjet.Name = "txtNoProjet";
            txtNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoProjet.Size = new System.Drawing.Size(81, 22);
            txtNoProjet.TabIndex = 34;
            /*txtNoSoumission*/
            txtNoSoumission.AcceptsReturn = true;
            txtNoSoumission.BackColor = System.Drawing.Color.White;
            txtNoSoumission.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoSoumission.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNoSoumission.ForeColor = System.Drawing.Color.White;
            txtNoSoumission.Location = new System.Drawing.Point(290, 152);
            txtNoSoumission.MaxLength = 0;
            txtNoSoumission.Name = "txtNoSoumission";
            txtNoSoumission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoSoumission.Size = new System.Drawing.Size(81, 22);
            txtNoSoumission.TabIndex = 30;
            /*cmdFermer*/
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.White;
            cmdFermer.Location = new System.Drawing.Point(527, 583);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(89, 30);
            cmdFermer.TabIndex = 62;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(Cmdfermer_Click);
            /*cmbGRB*/
            cmbGRB.BackColor = System.Drawing.Color.White;
            cmbGRB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbGRB.ForeColor = System.Drawing.Color.White;
            cmbGRB.Location = new System.Drawing.Point(290, 104);
            cmbGRB.Name = "cmbGRB";
            cmbGRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbGRB.Size = new System.Drawing.Size(273, 22);
            cmbGRB.TabIndex = 27;
            cmbGRB.SelectedIndexChanged += new System.EventHandler(cmbSelectedIndexChanged);
            /*cmbContact*/
            cmbContact.BackColor = System.Drawing.Color.White;
            cmbContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbContact.ForeColor = System.Drawing.Color.White;
            cmbContact.Location = new System.Drawing.Point(290, 64);
            cmbContact.Name = "cmbContact";
            cmbContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbContact.Size = new System.Drawing.Size(273, 22);
            cmbContact.TabIndex = 25;
            cmbContact.SelectedIndexChanged += new System.EventHandler(cmbContact_SelectedIndexChanged);
            /*cmbClient*/
            cmbClient.BackColor = System.Drawing.Color.White;
            cmbClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbClient.ForeColor = System.Drawing.Color.White;
            cmbClient.Location = new System.Drawing.Point(290, 24);
            cmbClient.Name = "cmbClient";
            cmbClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbClient.Size = new System.Drawing.Size(273, 22);
            cmbClient.Sorted = true;
            cmbClient.TabIndex = 22;
            cmbClient.Text = "cmbClient";
            cmbClient.SelectedIndexChanged += new System.EventHandler(cmbclient_SelectedIndexChanged);
            /*cmbClient2*/
            cmbClient2.BackColor = System.Drawing.Color.Black;
            cmbClient2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbClient2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbClient2.ForeColor = System.Drawing.Color.White;
            cmbClient2.Location = new System.Drawing.Point(290, 352);
            cmbClient2.Name = "cmbClient2";
            cmbClient2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbClient2.Size = new System.Drawing.Size(273, 22);
            cmbClient2.Sorted = true;
            cmbClient2.TabIndex = 52;
            cmbClient2.SelectedIndexChanged += new System.EventHandler(cmbclient2_SelectedIndexChanged);
            /*mskHeureTravaux*/
            mskHeureTravaux.AllowPromptAsInput = false;
            mskHeureTravaux.BackColor = System.Drawing.Color.White;
            mskHeureTravaux.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskHeureTravaux.ForeColor = System.Drawing.Color.White;
            mskHeureTravaux.Location = new System.Drawing.Point(458, 312);
            mskHeureTravaux.Name = "mskHeureTravaux";
            mskHeureTravaux.Size = new System.Drawing.Size(73, 22);
            mskHeureTravaux.TabIndex = 49;
            /*lblFournisseur2*/
            lblFournisseur2.AutoSize = true;
            lblFournisseur2.BackColor = System.Drawing.Color.Black;
            lblFournisseur2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFournisseur2.ForeColor = System.Drawing.Color.White;
            lblFournisseur2.Location = new System.Drawing.Point(290, 504);
            lblFournisseur2.Name = "lblFournisseur2";
            lblFournisseur2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblFournisseur2.Size = new System.Drawing.Size(128, 14);
            lblFournisseur2.TabIndex = 68;
            lblFournisseur2.Text = "Fournisseur Expédié à";
            /*lblDateDue*/
            lblDateDue.BackColor = System.Drawing.Color.Black;
            lblDateDue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateDue.ForeColor = System.Drawing.Color.White;
            lblDateDue.Location = new System.Drawing.Point(402, 136);
            lblDateDue.Name = "lblDateDue";
            lblDateDue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateDue.Size = new System.Drawing.Size(129, 17);
            lblDateDue.TabIndex = 29;
            lblDateDue.Text = "Date dûe";
            /*lblFormatHeurePrevue*/
            lblFormatHeurePrevue.AutoSize = true;
            lblFormatHeurePrevue.BackColor = System.Drawing.Color.Black;
            lblFormatHeurePrevue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFormatHeurePrevue.ForeColor = System.Drawing.Color.White;
            lblFormatHeurePrevue.Location = new System.Drawing.Point(538, 312);
            lblFormatHeurePrevue.Name = "lblFormatHeurePrevue";
            lblFormatHeurePrevue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblFormatHeurePrevue.Size = new System.Drawing.Size(46, 14);
            lblFormatHeurePrevue.TabIndex = 50;
            lblFormatHeurePrevue.Text = "HH:MM";
            /*lblContactFRS*/
            lblContactFRS.AutoSize = true;
            lblContactFRS.BackColor = System.Drawing.Color.Black;
            lblContactFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblContactFRS.ForeColor = System.Drawing.Color.White;
            lblContactFRS.Location = new System.Drawing.Point(290, 456);
            lblContactFRS.Name = "lblContactFRS";
            lblContactFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblContactFRS.Size = new System.Drawing.Size(47, 14);
            lblContactFRS.TabIndex = 63;
            lblContactFRS.Text = "Contact";
            lblContactFRS.Visible = false;
            /*lblHeureTravaux*/
            lblHeureTravaux.AutoSize = true;
            lblHeureTravaux.BackColor = System.Drawing.Color.Black;
            lblHeureTravaux.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeureTravaux.ForeColor = System.Drawing.Color.White;
            lblHeureTravaux.Location = new System.Drawing.Point(458, 296);
            lblHeureTravaux.Name = "lblHeureTravaux";
            lblHeureTravaux.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblHeureTravaux.Size = new System.Drawing.Size(80, 14);
            lblHeureTravaux.TabIndex = 46;
            lblHeureTravaux.Text = "Heure prévue";
            /*lblProjetClient*/
            lblProjetClient.AutoSize = true;
            lblProjetClient.BackColor = System.Drawing.Color.Black;
            lblProjetClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjetClient.ForeColor = System.Drawing.Color.White;
            lblProjetClient.Location = new System.Drawing.Point(402, 216);
            lblProjetClient.Name = "lblProjetClient";
            lblProjetClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblProjetClient.Size = new System.Drawing.Size(73, 14);
            lblProjetClient.TabIndex = 37;
            lblProjetClient.Text = "Projet Client";
            /*lblFournisseur*/
            lblFournisseur.AutoSize = true;
            lblFournisseur.BackColor = System.Drawing.Color.Black;
            lblFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFournisseur.ForeColor = System.Drawing.Color.White;
            lblFournisseur.Location = new System.Drawing.Point(290, 416);
            lblFournisseur.Name = "lblFournisseur";
            lblFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblFournisseur.Size = new System.Drawing.Size(72, 14);
            lblFournisseur.TabIndex = 58;
            lblFournisseur.Text = "Fournisseur";
            /*lblDateLivraison*/
            lblDateLivraison.AutoSize = true;
            lblDateLivraison.BackColor = System.Drawing.Color.Black;
            lblDateLivraison.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateLivraison.ForeColor = System.Drawing.Color.White;
            lblDateLivraison.Location = new System.Drawing.Point(479, 377);
            lblDateLivraison.Name = "lblDateLivraison";
            lblDateLivraison.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateLivraison.Size = new System.Drawing.Size(84, 14);
            lblDateLivraison.TabIndex = 55;
            lblDateLivraison.Text = "Date livraison";
            /*lblTransport*/
            lblTransport.AutoSize = true;
            lblTransport.BackColor = System.Drawing.Color.Black;
            lblTransport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTransport.ForeColor = System.Drawing.Color.White;
            lblTransport.Location = new System.Drawing.Point(290, 376);
            lblTransport.Name = "lblTransport";
            lblTransport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTransport.Size = new System.Drawing.Size(58, 14);
            lblTransport.TabIndex = 54;
            lblTransport.Text = "Transport";
            /*lblClient2*/
            lblClient2.AutoSize = true;
            lblClient2.BackColor = System.Drawing.Color.Black;
            lblClient2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClient2.ForeColor = System.Drawing.Color.White;
            lblClient2.Location = new System.Drawing.Point(290, 336);
            lblClient2.Name = "lblClient2";
            lblClient2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblClient2.Size = new System.Drawing.Size(95, 14);
            lblClient2.TabIndex = 51;
            lblClient2.Text = "Client Expédié à";
            /*lblClient*/
            lblClient.BackColor = System.Drawing.Color.Black;
            lblClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClient.ForeColor = System.Drawing.Color.White;
            lblClient.Location = new System.Drawing.Point(290, 8);
            lblClient.Name = "lblClient";
            lblClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblClient.Size = new System.Drawing.Size(41, 17);
            lblClient.TabIndex = 0;
            lblClient.Text = "Client";
            /*lblDate*/
            lblDate.AutoSize = true;
            lblDate.BackColor = System.Drawing.Color.Black;
            lblDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDate.ForeColor = System.Drawing.Color.White;
            lblDate.Location = new System.Drawing.Point(290, 216);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDate.Size = new System.Drawing.Size(33, 14);
            lblDate.TabIndex = 36;
            lblDate.Text = "Date";
            /*lblDateTravaux*/
            lblDateTravaux.BackColor = System.Drawing.Color.Black;
            lblDateTravaux.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateTravaux.ForeColor = System.Drawing.Color.White;
            lblDateTravaux.Location = new System.Drawing.Point(290, 296);
            lblDateTravaux.Name = "lblDateTravaux";
            lblDateTravaux.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateTravaux.Size = new System.Drawing.Size(81, 17);
            lblDateTravaux.TabIndex = 45;
            lblDateTravaux.Text = "Date travaux";
            /*lblNomProjet*/
            lblNomProjet.AutoSize = true;
            lblNomProjet.BackColor = System.Drawing.Color.Black;
            lblNomProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomProjet.ForeColor = System.Drawing.Color.White;
            lblNomProjet.Location = new System.Drawing.Point(402, 176);
            lblNomProjet.Name = "lblNomProjet";
            lblNomProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNomProjet.Size = new System.Drawing.Size(66, 14);
            lblNomProjet.TabIndex = 33;
            lblNomProjet.Text = "Nom Projet";
            /*lblDateCommande*/
            lblDateCommande.AutoSize = true;
            lblDateCommande.BackColor = System.Drawing.Color.Black;
            lblDateCommande.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateCommande.ForeColor = System.Drawing.Color.White;
            lblDateCommande.Location = new System.Drawing.Point(290, 256);
            lblDateCommande.Name = "lblDateCommande";
            lblDateCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDateCommande.Size = new System.Drawing.Size(97, 14);
            lblDateCommande.TabIndex = 40;
            lblDateCommande.Text = "Date Commande";
            /*lblNoCommande*/
            lblNoCommande.AutoSize = true;
            lblNoCommande.BackColor = System.Drawing.Color.Black;
            lblNoCommande.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoCommande.ForeColor = System.Drawing.Color.White;
            lblNoCommande.Location = new System.Drawing.Point(458, 256);
            lblNoCommande.Name = "lblNoCommande";
            lblNoCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNoCommande.Size = new System.Drawing.Size(124, 14);
            lblNoCommande.TabIndex = 41;
            lblNoCommande.Text = "No. Commande Client";
            /*lblNoProjet*/
            lblNoProjet.AutoSize = true;
            lblNoProjet.BackColor = System.Drawing.Color.Black;
            lblNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoProjet.ForeColor = System.Drawing.Color.White;
            lblNoProjet.Location = new System.Drawing.Point(290, 176);
            lblNoProjet.Name = "lblNoProjet";
            lblNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNoProjet.Size = new System.Drawing.Size(59, 14);
            lblNoProjet.TabIndex = 32;
            lblNoProjet.Text = "No. Projet";
            /*lblNoSoumission*/
            lblNoSoumission.BackColor = System.Drawing.Color.Black;
            lblNoSoumission.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoSoumission.ForeColor = System.Drawing.Color.White;
            lblNoSoumission.Location = new System.Drawing.Point(290, 136);
            lblNoSoumission.Name = "lblNoSoumission";
            lblNoSoumission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNoSoumission.Size = new System.Drawing.Size(89, 17);
            lblNoSoumission.TabIndex = 28;
            lblNoSoumission.Text = "No. Soumission";
            /*lblGRB*/
            lblGRB.BackColor = System.Drawing.Color.Black;
            lblGRB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGRB.ForeColor = System.Drawing.Color.White;
            lblGRB.Location = new System.Drawing.Point(290, 88);
            lblGRB.Name = "lblGRB";
            lblGRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblGRB.Size = new System.Drawing.Size(113, 17);
            lblGRB.TabIndex = 26;
            lblGRB.Text = "Représentant GRB";
            /*lblContact*/
            lblContact.BackColor = System.Drawing.Color.Black;
            lblContact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblContact.ForeColor = System.Drawing.Color.White;
            lblContact.Location = new System.Drawing.Point(290, 48);
            lblContact.Name = "lblContact";
            lblContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblContact.Size = new System.Drawing.Size(49, 17);
            lblContact.TabIndex = 24;
            lblContact.Text = "Contact";
            /*mskDateDue*/
            mskDateDue.Location = new System.Drawing.Point(405, 153);
            mskDateDue.Name = "mskDateDue";
            mskDateDue.Size = new System.Drawing.Size(177, 22);
            mskDateDue.TabIndex = 69;
            /*mskDateCommande*/
            mskDateCommande.Location = new System.Drawing.Point(293, 272);
            mskDateCommande.Name = "mskDateCommande";
            mskDateCommande.Size = new System.Drawing.Size(159, 22);
            mskDateCommande.TabIndex = 70;
            /*mskDate*/
            mskDate.Location = new System.Drawing.Point(293, 233);
            mskDate.Name = "mskDate";
            mskDate.Size = new System.Drawing.Size(103, 22);
            mskDate.TabIndex = 71;
            /*mskDateLivraison*/
            mskDateLivraison.Location = new System.Drawing.Point(474, 395);
            mskDateLivraison.Name = "mskDateLivraison";
            mskDateLivraison.Size = new System.Drawing.Size(121, 22);
            mskDateLivraison.TabIndex = 72;
            /*Rapports*/
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(630, 620);
            Controls.Add(mskDateLivraison);
            Controls.Add(mskDate);
            Controls.Add(mskDateCommande);
            Controls.Add(mskDateDue);
            Controls.Add(cmbFournisseur2);
            Controls.Add(cmdRechercherFRS2);
            Controls.Add(fraChoixRapport);
            Controls.Add(cmbContactFRS);
            Controls.Add(cmdRechercherFRS);
            Controls.Add(cmdRechercherClient2);
            Controls.Add(cmdRechercherClient);
            Controls.Add(mskDateTravaux);
            Controls.Add(txtProjetClient);
            Controls.Add(cmdReport);
            Controls.Add(cmbFournisseur);
            Controls.Add(txtTransport);
            Controls.Add(txtNomProjet);
            Controls.Add(txtNoCommande);
            Controls.Add(txtNoProjet);
            Controls.Add(txtNoSoumission);
            Controls.Add(cmdFermer);
            Controls.Add(cmbGRB);
            Controls.Add(cmbContact);
            Controls.Add(cmbClient);
            Controls.Add(cmbClient2);
            Controls.Add(mskHeureTravaux);
            Controls.Add(lblFournisseur2);
            Controls.Add(lblDateDue);
            Controls.Add(lblFormatHeurePrevue);
            Controls.Add(lblContactFRS);
            Controls.Add(lblHeureTravaux);
            Controls.Add(lblProjetClient);
            Controls.Add(lblFournisseur);
            Controls.Add(lblDateLivraison);
            Controls.Add(lblTransport);
            Controls.Add(lblClient2);
            Controls.Add(lblClient);
            Controls.Add(lblDate);
            Controls.Add(lblDateTravaux);
            Controls.Add(lblNomProjet);
            Controls.Add(lblDateCommande);
            Controls.Add(lblNoCommande);
            Controls.Add(lblNoProjet);
            Controls.Add(lblNoSoumission);
            Controls.Add(lblGRB);
            Controls.Add(lblContact);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            Location = new System.Drawing.Point(3, 22);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Rapports";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ContrôleurWebAutoGRB.Rapports";
            Load += new System.EventHandler(InitFormulaire);
            fraChoixRapport.ResumeLayout(false);
            fraChoixRapport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private const string S_SELECT_ALL = "Sélectionner tout";
        private const string S_UNSELECT_ALL = "Désélectionner tout";
        public int m_iNoClient;
        public int m_iNoClient2;
        public int m_iNoContact;
        public int m_iNoGRB;
        public int m_iNoFRS;
        public int m_iNoFRS2;
        private bool m_bSelectAll;
        private string m_sFaxClientFRS;
        private string m_sFaxContact;
        private string m_sTelClientFRS;
        private string m_sTelContact;
        [Obsolete]
        public void Afficher(int iNoClientFRS, ref int iNoContact, ref EnumForm eForm)
        {
            try
            {
                int X;
                cmdSelect.Text = S_UNSELECT_ALL;
                cmdselect_Click(cmdSelect, new EventArgs());
                chkFaxFrancais.CheckState = CheckState.Checked;
                cmbClient.SelectedIndex = -1;
                cmbContact.SelectedIndex = -1;
                cmbFournisseur.SelectedIndex = -1;
                cmbContactFRS.SelectedIndex = -1;
                switch (eForm)
                {
                    case EnumForm.FRM_CLIENTS:
                        {
                            for (X = 0; X <= (int)(cmbClient.Items.Count - 1); X++)
                            {
                                if (m_iIDClient == 0) { m_iIDClient = int.Parse(cmbClient.Text.Split('-')[0]); }
                                if (m_iIDClient != iNoClientFRS) { cmbClient.SelectedIndex = X; break; }
                            }
                            for (X = 0; X <= (int)(cmbContact.Items.Count - 1); X++)
                            {
                                if (m_iNoContact == 0) { m_iNoContact = int.Parse(cmbContact.Text.Split('-')[0]); }
                                if (m_iNoContact != iNoContact) { cmbContact.SelectedIndex = X; break; }
                            }
                            break;
                        }
                    case EnumForm.FRM_FRS:
                        {
                            for (X = 0; X <= (int)(cmbFournisseur.Items.Count - 1); X++)
                            {
                                if (m_iNoFRS == 0) { m_iNoFRS = GetFournisseurID(cmbFournisseur.Text.Split('-')[0]); }
                                if (m_iNoFRS != iNoClientFRS) { cmbFournisseur.SelectedIndex = X; break; }
                            }
                            for (X = 0; X <= (int)(cmbContactFRS.Items.Count - 1); X++)
                            {
                                if (int.Parse(cmbContactFRS.Text.Split('-')[0]) == iNoContact) { cmbContactFRS.SelectedIndex = X; break; }
                            }
                            break;
                        }
                    case EnumForm.FRM_CONTACTS:
                        {
                            for (X = 0; X <= (int)(cmbContact.Items.Count - 1); X++)
                            {
                                if (int.Parse(cmbContact.Text.Split('-')[0])!= iNoContact) { cmbContact.SelectedIndex = X; break; }
                            }
                            break;
                        }
                }
                txtMsg.Visible = true;
                Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "Afficher", ex); }
        }
        private void chkBonLivraison_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkBonLivraison_Click", ex); }
        }
        private void chkBonTravail_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkBonTravail_Click", ex); }
        }
        private void chkClient_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkClient_Click", ex); }
        }
        private void chkFourn_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkFourn_Click", ex); }
        }
        private void chkConcept_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkConcept_Click", ex); }
        }
        private void chkProblemes_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkProblemes_Click", ex); }
        }
        private void chkProg_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkProg_Click", ex); }
        }
        private void chkFabFermMéca_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkFabFermMéca_Click", ex); }
        }
        private void chkFabFerm_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkFabFerm_Click", ex); }
        }
        private void chkFaxFrancais_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkFaxFrancais_Click", ex); }
        }
        private void chkFaxAnglais_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_bSelectAll == false) { AfficherControles(); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "chkFaxAnglais_Click", ex); }
        }
        private void cmbclient_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstClient;
                m_sTelClientFRS = "";
                m_sTelContact = "";
                m_sFaxClientFRS = "";
                m_sTelContact = "";
                if (cmbClient.SelectedIndex != -1)
                {
                    rstClient = new Recordset();
                    if (m_iIDClient > 0x0A & m_iIDClient != 0) { m_iNoClient = m_iIDClient; }
                    rstClient.Open($"SELECT Fax, Telephonne FROM Client WHERE IDClient = {int.Parse(cmbClient.Text.Split('-')[0])}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstClient.EOF)
                    {
                        if (!(rstClient.Fields["Fax"].Value is DBNull)) { m_sFaxClientFRS = (string)(rstClient.Fields["Fax"].Value); }
                        else { m_sFaxClientFRS = string.Empty; }
                        if (!(rstClient.Fields["Telephonne"].Value is DBNull)) { m_sTelClientFRS = (string)(rstClient.Fields["Telephonne"].Value); }
                        else { m_sTelClientFRS = string.Empty; }
                    }
                    rstClient.Close();
                    rstClient = null;
                    if (cmbClient.SelectedIndex > -1)
                    {
                        m_iNoClient = int.Parse(cmbClient.Text.Split('-')[0]); 
                    }
                    RemplirComboContact();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmbclient_Click", ex); }
        }
        private void AfficherControles()
        {
            try
            {
                cmbClient.Visible = false;
                cmbClient2.Visible = false;
                cmbContact.Visible = false;
                cmbContactFRS.Visible = false;
                cmbFournisseur.Visible = false;
                cmbFournisseur2.Visible = false;
                cmbGRB.Visible = false;
                cmdMsg.Visible = false;
                cmdRechercherClient.Visible = false;
                cmdRechercherClient2.Visible = false;
                cmdRechercherFRS.Visible = false;
                cmdRechercherFRS2.Visible = false;
                lblClient.Visible = false;
                lblClient2.Visible = false;
                lblContact.Visible = false;
                lblContactFRS.Visible = false;
                lblDate.Visible = false;
                lblDateCommande.Visible = false;
                lblDateDue.Visible = false;
                lblDateLivraison.Visible = false;
                lblDateTravaux.Visible = false;
                lblDe.Visible = false;
                lblFormatHeurePrevue.Visible = false;
                lblFournisseur.Visible = false;
                lblFournisseur2.Visible = false;
                lblGRB.Visible = false;
                lblHeureTravaux.Visible = false;
                lblNoCommande.Visible = false;
                lblNomProjet.Visible = false;
                lblNoProjet.Visible = false;
                lblNoSoumission.Visible = false;
                lblObjet.Visible = false;
                lblPage.Visible = false;
                lblProjetClient.Visible = false;
                lblTransport.Visible = false;
                mskDate.Visible = false;
                mskDateCommande.Visible = false;
                mskDateDue.Visible = false;
                mskDateLivraison.Visible = false;
                mskDateTravaux.Visible = false;
                mskHeureTravaux.Visible = false;
                txtDe.Visible = false;
                txtMsg.Visible = false;
                txtNoCommande.Visible = false;
                txtNomProjet.Visible = false;
                txtNoProjet.Visible = false;
                txtNoSoumission.Visible = false;
                txtObjet.Visible = false;
                txtPage.Visible = false;
                txtProjetClient.Visible = false;
                txtTransport.Visible = false;
                if (chkProblemes.Checked)
                {
                    lblGRB.Visible = true;
                    cmbGRB.Visible = true;
                    lblNoProjet.Visible = true;
                    txtNoProjet.Visible = true;
                    lblNoSoumission.Visible = true;
                    txtNoSoumission.Visible = true;
                }
                if (ChkClient.Checked | ChkFourn.Checked)
                {
                    lblDateDue.Visible = true;
                    mskDateDue.Visible = true;
                }
                if (ChkBonTravail.Checked | chkBonLivraison.Checked | ChkClient.Checked | ChkFourn.Checked | ChkConcept.Checked | ChkProg.Checked | ChkFabFermMéca.Checked | ChkFabFerm.Checked | chkFaxFrancais.Checked | chkFaxAnglais.Checked)
                {
                    cmbClient.Visible = true;
                    lblClient.Visible = true;
                    cmdRechercherClient.Visible = true;
                    cmbContact.Visible = true;
                    lblContact.Visible = true;
                    txtNoProjet.Visible = true;
                    lblNoProjet.Visible = true;
                }
                if (ChkBonTravail.Checked | chkBonLivraison.Checked)
                {
                    txtNoCommande.Visible = true;
                    lblNoCommande.Visible = true;
                }
                if (ChkBonTravail.Checked)
                {
                    cmbGRB.Visible = true;
                    lblGRB.Visible = true;
                    mskDateCommande.Visible = true;
                    lblDateCommande.Visible = true;
                    mskDateTravaux.Visible = true;
                    lblDateTravaux.Visible = true;
                    mskHeureTravaux.Visible = true;
                    lblHeureTravaux.Visible = true;
                    lblFormatHeurePrevue.Visible = true;
                }
                if (chkBonLivraison.Checked | chkFaxFrancais.Checked | chkFaxAnglais.Checked)
                {
                    cmbFournisseur.Visible = true;
                    lblFournisseur.Visible = true;
                    cmbContactFRS.Visible = true;
                    lblContactFRS.Visible = true;
                    cmdRechercherFRS.Visible = true;
                }
                if (chkBonLivraison.Checked)
                {
                    cmbClient2.Visible = true;
                    lblClient2.Visible = true;
                    cmbFournisseur2.Visible = true;
                    lblFournisseur2.Visible = true;
                    cmdRechercherClient2.Visible = true;
                    cmdRechercherFRS2.Visible = true;
                    txtTransport.Visible = true;
                    lblTransport.Visible = true;
                    mskDateLivraison.Visible = true;
                    lblDateLivraison.Visible = true;
                }
                if (ChkClient.Checked | ChkFourn.Checked | ChkConcept.Checked | ChkProg.Checked | ChkFabFermMéca.Checked | ChkFabFerm.Checked | chkFaxFrancais.Checked | chkFaxAnglais.Checked)
                {
                    txtNoSoumission.Visible = true;
                    lblNoSoumission.Visible = true;
                }
                if (ChkClient.Checked | ChkFourn.Checked | ChkConcept.Checked | ChkProg.Checked | ChkFabFermMéca.Checked | ChkFabFerm.Checked)
                {
                    txtNomProjet.Visible = true;
                    lblNomProjet.Visible = true;
                    mskDate.Visible = true;
                    lblDate.Visible = true;
                    txtProjetClient.Visible = true;
                    lblProjetClient.Visible = true;
                }
                if (chkFaxFrancais.Checked | chkFaxAnglais.Checked)
                {
                    txtPage.Visible = true;
                    lblPage.Visible = true;
                    txtDe.Visible = true;
                    lblDe.Visible = true;
                    cmdMsg.Visible = true;
                    txtObjet.Visible = true;
                    lblObjet.Visible = true;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "AfficherControles", ex); }
        }
        private void cmdRechercherClient_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sRecherche;
                sRecherche = Interaction.InputBox("Entrez le texte à rechercher.");
                RemplirComboClient(sRecherche);
                m_iNoClient = 0;
                RemplirComboContact();
                cmbClient.Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmdRechercherClient_Click", ex); }
        }
        private void cmdRechercherClient2_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sRecherche;
                sRecherche = Interaction.InputBox("Entrez le texte à rechercher.");
                RemplirComboClient2(sRecherche);
                m_iNoClient2 = 0;
                cmbClient2.Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmdRechercherClient2_Click", ex); }
        }
        private void cmdRechercherFRS_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sRecherche;
                sRecherche = Interaction.InputBox("Entrez le texte à rechercher.");
                RemplirComboFRS(sRecherche);
                m_iNoFRS = 0;
                cmbFournisseur.Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmdRechercherFRS_Click", ex); }
        }
        private void cmdRechercherFRS2_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sRecherche;
                sRecherche = Interaction.InputBox("Entrez le texte à rechercher.");
                RemplirComboFRS2(sRecherche);
                m_iNoFRS2 = 0;
                cmbFournisseur2.Focus();
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmdRechercherFRS2_Click", ex); }
        }
        [Obsolete]
        private void cmbclient2_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbClient2.SelectedIndex > -1)
                { m_iNoClient2 = int.Parse(cmbClient2.Text.Split('-')[0]); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmbclient2_Click", ex); }
        }
        [Obsolete]
        private void cmbFournisseur2_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbFournisseur2.SelectedIndex > -1) { m_iNoFRS2 = int.Parse(cmbFournisseur2.Text.Split('-')[0]); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmbFournisseur2_Click", ex); }
        }
        [Obsolete]
        private void cmbFournisseur_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstFRS;
                m_sFaxContact = "";
                m_sFaxClientFRS = "";
                m_sTelContact = "";
                m_sTelClientFRS = "";
                if (cmbFournisseur.SelectedIndex != -1)
                {
                    rstFRS = new Recordset();
                    rstFRS.Open($"SELECT FAX, TELEPHONNE FROM FOURNISSEUR WHERE IDFRS = {int.Parse(cmbFournisseur.Text.Split('-')[0])}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstFRS.EOF)
                    {
                        if (!(rstFRS.Fields["Fax"].Value is DBNull)) { m_sFaxClientFRS = (string)(rstFRS.Fields["Fax"].Value); }
                        else { m_sFaxClientFRS = string.Empty; }
                        if (!(rstFRS.Fields["Telephonne"].Value is DBNull)) { m_sTelClientFRS = (string)(rstFRS.Fields["Telephonne"].Value); }
                        else { m_sTelClientFRS = string.Empty; }
                    }
                    rstFRS.Close();
                    rstFRS = null;
                }
                if (cmbFournisseur.SelectedIndex > -1)
                { m_iNoFRS = (int)GetFournisseurID(cmbFournisseur.Items[cmbFournisseur.SelectedIndex].ToString()); }
                RemplirComboContactFRS();
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmbFournisseur_Click", ex); }
        }
        [Obsolete]
        private void cmbContact_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstContact;
                if (cmbContact.SelectedIndex != -1)
                {
                    m_iNoContact = int.Parse(cmbContact.Text.Split('-')[0]);
                    rstContact = new Recordset();
                    rstContact.Open("SELECT Telephonne, Fax FROM contact WHERE IDContact = " + m_iNoContact, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstContact.EOF)
                    {
                        if (rstContact.Fields["telephonne"].Value is DBNull) { m_sTelContact = string.Empty; }
                        else { m_sTelContact = (string)(rstContact.Fields["telephonne"].Value); }
                        if (rstContact.Fields["fax"].Value is DBNull) { m_sFaxContact = string.Empty; }
                        else { m_sFaxContact = (string)(rstContact.Fields["fax"].Value); }
                    }
                    rstContact.Close();
                    rstContact = null;
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmbContact_Click", ex); }
        }
        [Obsolete]
        private void cmbContactFRS_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstContact;
                if (cmbContactFRS.SelectedIndex != -1)
                {
                    if (cmbContact.SelectedIndex == -1)
                    {
                        rstContact = new Recordset(); rstContact.Open("SELECT Telephonne, Fax FROM Contact WHERE IDContact = " + int.Parse(cmbContactFRS.Text.Split('-')[0]), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstContact.EOF)
                        {
                            if (!(rstContact.Fields["telephonne"].Value is DBNull)) { m_sTelContact = (string)(rstContact.Fields["telephonne"].Value); }
                            else { m_sTelContact = string.Empty; }
                            if (!(rstContact.Fields["fax"].Value is DBNull)) { m_sFaxContact = (string)(rstContact.Fields["fax"].Value); }
                            else { m_sFaxContact = string.Empty; }
                        }
                        rstContact.Close(); rstContact = null;
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmbContactFRS_Click", ex); }
        }
        [Obsolete]
        private void cmbSelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbGRB.SelectedIndex > -1)
                { m_iNoGRB = int.Parse(cmbGRB.Text.Split('-')[0]); }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmbClick", ex); }
        }
        private void cmdmsg_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (txtMsg.Visible == true)
                { txtMsg.Visible = false; }
                else
                {
                    txtMsg.Visible = true;
                    txtMsg.Focus();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmdmsg_Click", ex); }
        }
        private void Cmdfermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmdFermer_Click", ex); }
        }
        [Obsolete]
        private void ImprimerBonTravail()
        {
            try
            {
                ViewBonTravail f = new ViewBonTravail();
                ViewBonTravail.Orientation = false;
                ViewBonTravail.lblClient.Text = cmbClient.Text;
                ViewBonTravail.lblContact.Text = cmbContact.Text;
                ViewBonTravail.lblTelephone.Text = m_sTelContact;
                ViewBonTravail.lblFax.Text = m_sFaxContact;
                ViewBonTravail.lblRepresentantGRB.Text = cmbGRB.Text;
                ViewBonTravail.lblBonTravail.Text = txtNoProjet.Text;
                ViewBonTravail.lblNoCommandeClient.Text = txtNoCommande.Text;
                ViewBonTravail.lblDateCommande.Text = mskDateCommande.Text;
                ViewBonTravail.lblDateHeure.Text = mskDateTravaux.Text + " " + mskHeureTravaux.Text;
               f.ShowDialog();
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerBonTravail", ex); }
        }
        [Obsolete]
        private void ImprimerBonLivraison()
        {
            try
            {
                ViewBonLivraison viewBonLivraison = new ViewBonLivraison();
                Cursor.Current = Cursors.WaitCursor;
                ADODB.Recordset rstBonLivraison = new ADODB.Recordset();
                ADODB.Recordset rstContact = new ADODB.Recordset();
                ADODB.Recordset rstFournisseur = new ADODB.Recordset();
                ADODB.Recordset rstFournisseur2 = new ADODB.Recordset();
                ADODB.Recordset rstClient = new ADODB.Recordset();
                ADODB.Recordset rstClient2 = new ADODB.Recordset();
                ViewBonLivraison.Orientation = !isLandscape;
                rstBonLivraison.Open("SELECT * FROM impression_bonlivraison WHERE user = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstFournisseur.Open("SELECT * FROM Fournisseur WHERE IDFRS = " + m_iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstFournisseur2.Open("SELECT * FROM Fournisseur WHERE IDFRS = " + m_iNoFRS2, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstClient.Open("SELECT * FROM client WHERE IDClient = " + m_iNoClient, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstClient2.Open("SELECT * FROM client WHERE IDClient = " + m_iNoClient2, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                viewBonLivraison.DataSource = rstBonLivraison;
                ViewBonLivraison.lblNoProjet.Text = txtNoProjet.Text;
                ViewBonLivraison.lblDate.Text = ConvertDate(DateTime.Today);
                if (cmbFournisseur.SelectedIndex != -1)
                {
                    ViewBonLivraison.lblVenduA.Text = cmbFournisseur.Text;
                    if (rstFournisseur.EOF)
                    {
                        ViewBonLivraison.lblVenduA.Text = string.Empty;
                    }
                    else
                    {
                        if (!(rstFournisseur.Fields["adresse"].Value is DBNull)) { ViewBonLivraison.lblAdresse1.Text = (string)(rstFournisseur.Fields["adresse"].Value); }
                        if (!(rstFournisseur.Fields["ville"].Value is DBNull)) { ViewBonLivraison.lblAdresse2.Text = (string)(rstFournisseur.Fields["ville"].Value); }
                        if (!(rstFournisseur.Fields["Prov/Etat"].Value is DBNull))
                        {
                            if (rstFournisseur.Fields["Prov/Etat"].Value != string.Empty) { ViewBonLivraison.lblAdresse3.Text = rstFournisseur.Fields["Prov/Etat"].Value; }
                            if (!(rstFournisseur.Fields["codepostal"].Value is DBNull))
                            {
                                if (rstFournisseur.Fields["CodePostal"].Value != string.Empty) { ViewBonLivraison.lblAdresse3.Text += ", " + rstFournisseur.Fields["codepostal"].Value; }
                            }
                            if (!(rstFournisseur.Fields["pays"].Value is DBNull)) { ViewBonLivraison.lblAdresse4.Text = (string)(rstFournisseur.Fields["pays"].Value); }
                        }
                    }
                    ViewBonLivraison.lblNoRef.Text = txtNoCommande.Text;
                    ViewBonLivraison.lblExpedieA.Text = cmbFournisseur2.Text;
                    if (rstFournisseur2.EOF)
                    {
                        ViewBonLivraison.lblExpedieA.Text = string.Empty;
                    }
                    else
                    {
                        if (!(rstFournisseur2.Fields["adresse"].Value is DBNull)) { ViewBonLivraison.lblAdresseExp1.Text = rstFournisseur2.Fields["adresse"].Value; }
                        if (!(rstFournisseur2.Fields["ville"].Value is DBNull)) { ViewBonLivraison.lblAdresseExp2.Text = (rstFournisseur2.Fields["ville"].Value); }
                        if (!(rstFournisseur2.Fields["prov/etat"].Value is DBNull))
                        {
                            if (rstFournisseur2.Fields["prov/etat"].Value != string.Empty) { ViewBonLivraison.lblAdresseExp3.Text = rstFournisseur2.Fields["prov/etat"].Value; }
                        }
                        if (!(rstFournisseur2.Fields["pays"].Value is DBNull)) { ViewBonLivraison.lblAdresseExp4.Text = (string)(rstFournisseur2.Fields["pays"].Value); }
                        if (!(rstFournisseur2.Fields["codepostal"].Value is DBNull))
                        {
                            if (rstFournisseur2.Fields["CodePostal"].Value != string.Empty) { ViewBonLivraison.lblAdresseExp3.Text += ", " + rstFournisseur2.Fields["codepostal"].Value; }
                        }
                    }
                    ViewBonLivraison.label8.Text = cmbContactFRS.Text;
                }
                else
                {
                    ViewBonLivraison.lblVenduA.Text = cmbClient.Text;
                    if (rstClient.EOF)
                    {
                        ViewBonLivraison.lblVenduA.Text = string.Empty;
                    }
                    else
                    {
                        if (!(rstClient.Fields["adresseliv"].Value is DBNull)) { ViewBonLivraison.lblAdresse1.Text = rstClient.Fields["adresseliv"].Value; }
                        if (!(rstClient.Fields["villeliv"].Value is DBNull)) { ViewBonLivraison.lblAdresse2.Text = (string)(rstClient.Fields["villeliv"].Value); }
                        if (!(rstClient.Fields["paysliv"].Value is DBNull))
                        {
                            if (rstClient.Fields["PaysLiv"].Value != string.Empty) { ViewBonLivraison.lblAdresse4.Text = rstClient.Fields["paysliv"].Value; }
                        }
                        if (!(rstClient.Fields["prov/etatliv"].Value is DBNull)) { ViewBonLivraison.lblAdresse3.Text = (string)(rstClient.Fields["prov/etatliv"].Value); }
                        if (!(rstClient.Fields["codepostalliv"].Value is DBNull))
                        {
                            if (rstClient.Fields["CodePostalLiv"].Value != string.Empty) { ViewBonLivraison.lblAdresse3.Text += ", " + rstClient.Fields["codepostalliv"].Value; }
                        }
                    }
                    ViewBonLivraison.lblNoRef.Text = txtNoCommande.Text;
                    ViewBonLivraison.lblVenduA.Text = cmbClient2.Text;
                    if (rstClient2.EOF)
                    {
                        ViewBonLivraison.lblVenduA.Text = string.Empty;
                    }
                    else
                    {
                        if (!(rstClient2.Fields["adresseliv"].Value is DBNull)) { ViewBonLivraison.lblAdresseExp1.Text = (string)(rstClient2.Fields["adresseliv"].Value); }
                        if (!(rstClient2.Fields["villeliv"].Value is DBNull)) { ViewBonLivraison.lblAdresseExp2.Text = (string)(rstClient2.Fields["villeliv"].Value); }
                        if (!(rstClient2.Fields["paysliv"].Value is DBNull))
                        {
                            if (rstClient2.Fields["PaysLiv"].Value != string.Empty) { ViewBonLivraison.lblAdresseExp4.Text = (string)(rstClient2.Fields["paysliv"].Value); }
                        }
                        if (!(rstClient2.Fields["prov/etatliv"].Value is DBNull)) { ViewBonLivraison.lblAdresseExp3.Text = (string)(rstClient2.Fields["prov/etatliv"].Value); }
                        if (!(rstClient2.Fields["codepostalliv"].Value is DBNull))
                        {
                            if (rstClient2.Fields["CodePostalLiv"].Value != string.Empty) { ViewBonLivraison.lblAdresseExp3.Text += ", " + rstClient2.Fields["codepostalliv"].Value; }
                        }
                    }
                    ViewBonLivraison.label8.Text = cmbContact.Text;
                }
                ViewBonLivraison.lblTransport.Text = txtTransport.Text;
                ViewBonLivraison.lblDateExp.Text = mskDateLivraison.Text;
                rstBonLivraison.Close();
                rstBonLivraison = null;
                rstFournisseur.Close();
                rstFournisseur = null;
                rstClient.Close();
                rstClient = null;
                rstClient2.Close();
                rstClient2 = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerBonLivraison", ex); }
        }
        [Obsolete]
        private void ImprimerClient()
        {
            try
            {
                ViewClients ViewClients = new ViewClients();
                ViewClients.Orientation = false;
                ViewClients.lblClient.Text = cmbClient.Text;
                ViewClients.lblContact.Text = cmbContact.Text;
                ViewClients.lblTel.Text = m_sTelContact;
                ViewClients.lblFax.Text = m_sFaxContact;
                ViewClients.lblNoSoum.Text = txtNoSoumission.Text;
                ViewClients.lblNoProj.Text = txtNoProjet.Text;
                ViewClients.lblProjetNom.Text = txtNomProjet.Text;
                ViewClients.lblDate.Text = mskDate.Text;
                ViewClients.lblDateOuverture.Text = ConvertDate(DateTime.Today);
                ViewClients.lblDateDue.Text = mskDateDue.Text;
                ViewClients.lblProjet.Text = txtProjetClient.Text;
                ViewClients.Show();
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerClient", ex); }
        }
        [Obsolete]
        private void ImprimerFournisseur()
        {
            try
            {
                ViewFournisseur.Orientation = false;
                ViewFournisseur.lblClient.Text = cmbClient.Text;
                ViewFournisseur.lblContact.Text = cmbContact.Text;
                ViewFournisseur.lblTel.Text = m_sTelContact;
                ViewFournisseur.lblFax.Text = m_sFaxContact;
                ViewFournisseur.lblNoSoum.Text = txtNoSoumission.Text;
                ViewFournisseur.lblNoProj.Text = txtNoProjet.Text;
                ViewFournisseur.lblProjetNom.Text = txtNomProjet.Text;
                ViewFournisseur.lblDate.Text = mskDate.Text;
                ViewFournisseur.lblDateOuverture.Text = ConvertDate(DateTime.Today);
                ViewFournisseur.lblDateDue.Text = mskDateDue.Text;
                ViewFournisseur.lblProjet.Text = txtProjetClient.Text;
                Form f = new ViewFournisseur();
                f.Show();
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerFournisseur", ex); }
        }
        [Obsolete]
        private void ImprimerConception()
        {
            try
            {
                ViewConception.Orientation = false;
                ViewConception.lblClient.Text = cmbClient.Text;
                ViewConception.Controls33.Text = cmbContact.Text;
                ViewConception.lblTel.Text = m_sTelContact;
                ViewConception.lblFax.Text = m_sFaxContact;
                ViewConception.lblNoSoum.Text = txtNoSoumission.Text;
                ViewConception.lblProjet.Text = txtNoProjet.Text;
                ViewConception.lblProjet.Text += txtNomProjet.Text;
                ViewConception.TextBox3.Text = mskDate.Text;
                ViewConception.TextBox2.Text = Droite(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today).ToString(), 2) + "-" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMonth(DateTime.Today).ToString() + "-" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.Today).ToString().Trim();
                ViewConception.lblTitreCommande.Text = txtProjetClient.Text;
                Form rp = new ViewConception();
                rp.Text = $"Impression demandée par {IdNomEmploye} [{Conteneur.ip}\\{Environment.UserName} ]";
                rp.Show();
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerConception", ex); }
        }
        [Obsolete]
        private void ImprimerProgrammation()
        {
            try
            {
                ViewProgrammation.Orientation = false;
                ViewProgrammation.lblClient.Text = cmbClient.Text;
                ViewProgrammation.lblContact.Text = cmbContact.Text;
                ViewProgrammation.lblTelephone.Text = m_sTelContact;
                ViewProgrammation.lblFax.Text = m_sFaxContact;
                ViewProgrammation.lblNoSoum.Text = txtNoSoumission.Text;
                ViewProgrammation.lblNoProj.Text = txtNoProjet.Text;
                ViewProgrammation.lblProjetNom.Text = txtNomProjet.Text;
                ViewProgrammation.lblDate.Text = mskDate.Text;
                ViewProgrammation.lblProjetClient.Text = txtProjetClient.Text;
                Form f = new ViewProgrammation();
                f.MdiParent = Conteneur.Mdi;
                f.Icon = Conteneur.ActiveForm.Icon;
                f.Show();
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerProgrammation", ex); }
        }
        [Obsolete]
        private void ImprimerFermetureMecanique()
        {
            try
            {
                ViewFermeMecanique.Orientation = false;
                ViewFermeMecanique.lblClient.Text = cmbClient.Text;
                ViewFermeMecanique.lblContact.Text = cmbContact.Text;
                ViewFermeMecanique.lblTel.Text = m_sTelContact;
                ViewFermeMecanique.lblFax.Text = m_sFaxContact;
                ViewFermeMecanique.lblNoSoum.Text = txtNoSoumission.Text;
                ViewFermeMecanique.lblProjet.Text = txtNoProjet.Text;
                ViewFermeMecanique.lblProjetNom.Text = txtNomProjet.Text;
                ViewFermeMecanique.lblDate.Text = mskDate.Text;
                ViewFermeMecanique.lblDateOuverture.Text = ConvertDate(DateTime.Today);
                ViewFermeMecanique.lblProjet.Text = txtProjetClient.Text;
                Form f = new ViewFermeMecanique();
                f.MdiParent = Conteneur.Mdi;
                f.Show();
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerFermetureMecanique", ex); }
        }
        [Obsolete]
        private void ImprimerFermeture()
        {
            try
            {
                ViewFabricationFermeture.Orientation = !isLandscape;
                ViewFabricationFermeture.lblClient.Text = cmbClient.Text;
                ViewFabricationFermeture.lblContact.Text = cmbContact.Text;
                ViewFabricationFermeture.lblTel.Text = m_sTelContact;
                ViewFabricationFermeture.lblFax.Text = m_sFaxContact;
                ViewFabricationFermeture.lblSoum.Text = txtNoSoumission.Text;
                ViewFabricationFermeture.lblProj.Text = txtNoProjet.Text;
                ViewFabricationFermeture.lblProjetNom.Text = txtNomProjet.Text;
                ViewFabricationFermeture.lblDate.Text = mskDate.Text;
                ViewFabricationFermeture.lblDatePrint.Text = ConvertDate(DateTime.Today);
                ViewFabricationFermeture.lblProjet.Text = txtProjetClient.Text;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerFermeture", ex); }
        }
        [Obsolete]
        private void ImprimerFinFabrication()
        {
            try
            {
                ViewFinFab.Orientation = false;
                Form rp = new ViewFinFab();
                rp.Text = "Rapport Client";
                rp.Icon = Icon;
                rp.MdiParent = Conteneur.ActiveForm.MdiParent;
                rp.Show();
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerFinFabrication", ex); }
        }
        [Obsolete]
        private void ImprimerFax(EnumLangueFax eLangue)
        {
            try
            {
                ADODB.Recordset rstBonLivraison;
                var bClient = default(bool);
                bool bClientTexte;
                var bClientListIndex = default(bool);
                var bFournisseur = default(bool);
                bool bFournisseurTexte;
                var bFournisseurListIndex = default(bool);
                var bContactClient = default(bool);
                bool bContactClientTexte;
                var bContactClientListIndex = default(bool);
                var bContactFRS = default(bool);
                bool bContactFRSTexte;
                var bContactFRSListIndex = default(bool);
                var sMessage = default(string);
                ViewFaxFrancais.Orientation = false;
                if (cmbClient.SelectedIndex != -1 | !string.IsNullOrEmpty(cmbClient.Text))
                {
                    bClient = true;
                    if (cmbClient.SelectedIndex != -1)
                    {
                        bClientListIndex = true;
                    }
                    else
                    {
                        bClientTexte = true;
                    }
                }
                if (cmbFournisseur.SelectedIndex != -1 | !string.IsNullOrEmpty(cmbFournisseur.Text))
                {
                    bFournisseur = true;
                    if (cmbFournisseur.SelectedIndex != -1)
                    {
                        bFournisseurListIndex = true;
                    }
                    else
                    {
                        bFournisseurTexte = true;
                    }
                }
                if (cmbContact.SelectedIndex != -1 | !string.IsNullOrEmpty(cmbContact.Text))
                {
                    bContactClient = true;
                    if (cmbContact.SelectedIndex != -1)
                    {
                        bContactClientListIndex = true;
                    }
                    else
                    {
                        bContactClientTexte = true;
                    }
                }
                if (cmbContactFRS.SelectedIndex != -1 | !string.IsNullOrEmpty(cmbContactFRS.Text))
                {
                    bContactFRS = true;
                    if (cmbContactFRS.SelectedIndex != -1)
                    {
                        bContactFRSListIndex = true;
                    }
                    else
                    {
                        bContactFRSTexte = true;
                    }
                }
                if (bClient == false & bFournisseur == false & bContactClient == false & bContactFRS == false)
                {
                    if (MessageBox.Show("Voulez-vous choisir un destinataire?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        return;
                    }
                }
                ViewFaxFrancais.txtDate.Text = DateTime.Today.ToShortDateString();
                if (bClient == true)
                { ViewFaxFrancais.txtlAttention.Text = cmbContact.Text; }
                else if (bFournisseur == true){ ViewFaxFrancais.txtlAttention.Text = cmbContactFRS.Text; }
                else if (bContactClient == true){ ViewFaxFrancais.txtlAttention.Text = cmbContact.Text; }
                else if (bContactFRS == true){ ViewFaxFrancais.txtlAttention.Text = cmbContactFRS.Text; }
                else{ ViewFaxFrancais.txtlAttention.Text = ""; }
                if (bClient == true){ ViewFaxFrancais.txtEntreprise.Text = cmbClient.Text; }
                else if (bFournisseur == true){ ViewFaxFrancais.txtEntreprise.Text = cmbFournisseur.Text; }
                else{ ViewFaxFrancais.txtEntreprise.Text = ""; }
                if (bClientListIndex == true & bContactClientListIndex == true){ sMessage = "Voulez-vous afficher le numéro de fax du client?\nOui - Fax du client\nNon - Fax du contact"; }
                else if (bFournisseurListIndex == true & bContactFRSListIndex == true){ sMessage = "Voulez-vous afficher le numéro de fax du fournisseur?\nOui - Fax du fournisseur\nNon - Fax du contact"; }
                if (string.IsNullOrEmpty(sMessage))
                {
                    if (bFournisseurListIndex == true | bClientListIndex == true){ViewFaxFrancais.txtFax.Text = m_sFaxClientFRS;}
                    else{ ViewFaxFrancais.txtFax.Text = m_sFaxContact;}
                }
                else if (MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { ViewFaxFrancais.txtFax.Text = m_sFaxClientFRS; }
                else{ ViewFaxFrancais.txtFax.Text = m_sFaxContact; }
                if (!string.IsNullOrEmpty(txtNoProjet.Text))
                {
                    ViewFaxFrancais.lblTitreBC.Text = "# Projet:";
                    ViewFaxFrancais.txtProjet.Text = txtNoProjet.Text;
                }
                else
                {
                    ViewFaxFrancais.lblTitreBC.Text = "# Soumission:";
                    ViewFaxFrancais.txtProjet.Text = txtNoSoumission.Text;
                }
                ViewFaxFrancais.txtPage.Text = txtPage.Text;
                ViewFaxFrancais.txtDe.Text = txtDe.Text;
                ViewFaxFrancais.txtMessage.Text = txtMsg.Text;
                ViewFaxFrancais.txtSujet.Text = txtObjet.Text;
                Form f = new ViewFaxFrancais();
                f.ShowDialog();
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerFax", ex); }
        }
        [Obsolete]
        private void ImprimerProblemes()
        {
            try
            {
                ViewProblemes.Orientation = !isLandscape;
                if (!string.IsNullOrEmpty(txtNoSoumission.Text))
                {
                    ViewProblemes.lblTitreBC.Text = "# Soum :";
                    ViewProblemes.lblNoProjSoum.Text = txtNoSoumission.Text;
                }
                else
                {
                    ViewProblemes.lblTitreBC.Text = "# Projet :";
                    ViewProblemes.lblNoProjSoum.Text = txtNoProjet.Text;
                }
                ViewProblemes.lblNomEmploye.Text = cmbGRB.Text;
                Form f = new ViewProblemes();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
            }
            catch (Exception ex) { AfficherErreur("Rapports", "ImprimerProblèmes", ex); }
        }
        private void cmdreport_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (ChkBonTravail.Checked) { ImprimerBonTravail(); }
                if (chkBonLivraison.Checked) { ImprimerBonLivraison(); }
                if (ChkClient.Checked) { ImprimerClient(); }
                if (ChkFourn.Checked) { ImprimerFournisseur(); }
                if (ChkConcept.Checked) { ImprimerConception(); }
                if (ChkProg.Checked) { ImprimerProgrammation(); }
                if (ChkFabFermMéca.Checked) { ImprimerFermetureMecanique(); }
                if (ChkFabFerm.Checked) { ImprimerFermeture(); }
                if (ChkFinFab.Checked) { ImprimerFinFabrication(); }
                if (chkProblemes.Checked) { ImprimerProblemes(); }
                if (chkFaxFrancais.Checked) { ImprimerFax(EnumLangueFax.FAX_FRANCAIS); }
                if (chkFaxAnglais.Checked) { ImprimerFax(EnumLangueFax.FAX_ANGLAIS); }
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmdreport_Click", ex); }
        }
        private void cmdselect_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int iValue;
                if ((cmdSelect.Text ?? "") == S_SELECT_ALL)
                {
                    iValue = (int)CheckState.Checked;
                    cmdSelect.Text = S_UNSELECT_ALL;
                }
                else
                {
                    iValue = (int)CheckState.Unchecked;
                    cmdSelect.Text = S_SELECT_ALL;
                }
                m_bSelectAll = true;
                ChkBonTravail.CheckState = (CheckState)iValue;
                ChkClient.CheckState = (CheckState)iValue;
                ChkConcept.CheckState = (CheckState)iValue;
                ChkFabFerm.CheckState = (CheckState)iValue;
                ChkFabFermMéca.CheckState = (CheckState)iValue;
                ChkFinFab.CheckState = (CheckState)iValue;
                ChkFourn.CheckState = (CheckState)iValue;
                ChkProg.CheckState = (CheckState)iValue;
                chkBonLivraison.CheckState = (CheckState)iValue;
                chkProblemes.CheckState = (CheckState)iValue;
                chkFaxFrancais.CheckState = (CheckState)iValue;
                chkFaxAnglais.CheckState = (CheckState)iValue;
                AfficherControles();
                m_bSelectAll = false;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "cmdselect_Click", ex); }
        }
        private void InitFormulaire(object eventSender, EventArgs eventArgs)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            try
            {
                m_iNoClient = 0;
                m_iNoClient2 = 0;
                m_iNoContact = 0;
                m_iNoFRS = 0;
                m_iNoGRB = 0;
                RemplirComboClient(string.Empty);
                RemplirComboClient2(string.Empty);
                RemplirComboContact();
                RemplirComboGRB();
                RemplirComboFRS(string.Empty);
                RemplirComboFRS2(string.Empty);
                AfficherControles();
                Cursor.Current = Cursors.Default;
                mskDate.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today) + "-" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMonth(DateTime.Today), 2) + "-" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetDayOfMonth(DateTime.Today), 2);
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "Form_Load", ex); }
        }
        private void RemplirComboFRS(string sRecherche)
        {
            try
            {
                ADODB.Recordset rstFournisseur;
                rstFournisseur = new Recordset();
                rstFournisseur.Open($"SELECT NomFournisseur, IDFRS FROM Fournisseur WHERE NomFournisseur like '%{sRecherche.Replace("'", "''")}%' AND Supprimé = 0 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbFournisseur.Items.Clear();
                while (!rstFournisseur.EOF)
                {
                    cmbFournisseur.Items.Add($"{rstFournisseur.Fields["IDFRS"].Value}-{rstFournisseur.Fields["NomFournisseur"].Value}");
                    rstFournisseur.MoveNext();
                }
                rstFournisseur.Close();
                rstFournisseur = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboFRS", ex); }
        }
        private void RemplirComboFRS2(string sRecherche)
        {
            try
            {
                ADODB.Recordset rstFournisseur;
                rstFournisseur = new Recordset();
                rstFournisseur.Open($"SELECT NomFournisseur, IDFRS FROM Fournisseur WHERE NomFournisseur like '%{sRecherche.Replace("'", "''")}%'  AND Supprimé = 0 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbFournisseur2.Items.Clear();
                while (!rstFournisseur.EOF)
                {
                    cmbFournisseur2.Items.Add($"{rstFournisseur.Fields["IDFRS"].Value}-{rstFournisseur.Fields["NomFournisseur"].Value}");
                    rstFournisseur.MoveNext();
                }
                rstFournisseur.Close();
                rstFournisseur = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboFRS2", ex); }
        }
        private void RemplirComboClient(string sRecherche)
        {
            try
            {
                ADODB.Recordset rstClient = new ADODB.Recordset();
                rstClient.Open($"SELECT NOMCLIENT, IDCLIENT FROM CLIENT WHERE NOMCLIENT LIKE '%{sRecherche.Replace("'", "''")}%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbClient.Items.Clear();
                while (!rstClient.EOF)
                {
                    cmbClient.Items.Add($"{rstClient.Fields["idclient"].Value}-{rstClient.Fields["nomclient"].Value}");
                    rstClient.MoveNext();
                }
                rstClient.Close();
                rstClient = null;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboClient", ex); }
        }
        private void RemplirComboClient2(string sRecherche)
        {
            try
            {
                ADODB.Recordset rstClient;
                rstClient = new Recordset();
                rstClient.Open($"SELECT NOMCLIENT, IDCLIENT FROM CLIENT WHERE NOMCLIENT LIKE '%{sRecherche.Replace("'", "''")}%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbClient2.Items.Clear();
                while (!rstClient.EOF)
                {
                    cmbClient2.Items.Add($"{rstClient.Fields["idclient"].Value}-{rstClient.Fields["nomclient"].Value}");
                    rstClient.MoveNext();
                }
                rstClient.Close();
                rstClient = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboClient2", ex); }
        }
        private void RemplirComboContact()
        {
            try
            {
                ADODB.Recordset rstContact;
                rstContact = new Recordset();
                if (m_iNoClient > 0)
                { rstContact.Open("SELECT Contact.IDContact, Contact.NomContact, ContactClient.NoClient FROM Contact " + "INNER JOIN ContactClient ON Contact.IDContact = ContactClient.NoContact WHERE ContactClient.noclient = '" + m_iNoClient + "' " + "ORDER BY contact.NomContact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                else
                { rstContact.Open("SELECT NomContact, IDContact FROM Contact WHERE Supprimé = 0 ORDER BY Nomcontact", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                cmbContact.Items.Clear();
                while (!rstContact.EOF)
                {
                    if (!(rstContact.Fields["NomContact"].Value is DBNull))
                    {
                        cmbContact.Items.Add($"{rstContact.Fields["IDContact"].Value}-{rstContact.Fields["NomContact"].Value}"); rstContact.MoveNext();
                    }
                }
                rstContact.Close();
                rstContact = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboContact", ex); }
        }
        private void RemplirComboContactFRS()
        {
            try
            {
                ADODB.Recordset rstContactFRS;
                ADODB.Recordset rstContact;
                if (m_iNoFRS > 0)
                {
                    rstContactFRS = new Recordset();
                    rstContactFRS.Open("SELECT * FROM ContactFRS WHERE NoFRS = " + m_iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else { return; }
                cmbContactFRS.Items.Clear();
                rstContact = new Recordset();
                while (!rstContactFRS.EOF)
                {
                    rstContact.Open(Operators.ConcatenateObject("SELECT NomContact, IDContact FROM Contact WHERE IDContact = ", rstContactFRS.Fields["NoContact"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstContact.EOF)
                    {
                        cmbContactFRS.Items.Add($"{rstContact.Fields["IDContact"].Value}-{rstContact.Fields["NomContact"].Value}");
                    }
                    rstContact.Close();
                    rstContactFRS.MoveNext();
                }
                rstContact = null;
                rstContactFRS.Close();
                rstContactFRS = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboContactFRS", ex); }
        }
        private void RemplirComboGRB()
        {
            try
            {
                ADODB.Recordset rstContactGRB;
                rstContactGRB = new Recordset();
                rstContactGRB.Open("SELECT employe, noEmploye FROM employés WHERE actif=1 ORDER BY employe", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbGRB.Items.Clear();
                while (!rstContactGRB.EOF)
                {
                    cmbGRB.Items.Add($"{rstContactGRB.Fields["noEmploye"].Value}-{rstContactGRB.Fields["Employe"].Value}");
                    rstContactGRB.MoveNext();
                }
                rstContactGRB.Close();
                rstContactGRB = null;
                return;
            }
            catch (Exception ex) { AfficherErreur("Rapports", "RemplirComboGRB", ex); }
        }
    }
}