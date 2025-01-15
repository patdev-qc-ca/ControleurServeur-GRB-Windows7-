using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;
using System.Drawing;
using ADODB;


namespace ControleurServeur
{
    class ProjSoumMecTemps : Form
    {
        #region Windows Form Designer generated code 
        public ProjSoumMecTemps() : base()
        {
            InitializeComponent();
        }
        private System.ComponentModel.IContainer components;
        internal static System.Windows.Forms.ToolTip ToolTip1;
        internal static System.Windows.Forms.TextBox txtTempsPrototypeConc;
        internal static System.Windows.Forms.TextBox txtTempsPrototypeSoum;
        internal static System.Windows.Forms.TextBox txtTempsPrototypeProj;
        internal static System.Windows.Forms.TextBox txtTempsShippingProj;
        internal static System.Windows.Forms.TextBox txtTempsShippingSoum;
        internal static System.Windows.Forms.TextBox txtTempsShippingConc;
        internal static System.Windows.Forms.TextBox txtTempsGestionConc;
        internal static System.Windows.Forms.TextBox txtTempsGestionSoum;
        internal static System.Windows.Forms.TextBox txtTempsGestionProj;
        internal static System.Windows.Forms.TextBox txtTempsInstallationConc;
        internal static System.Windows.Forms.TextBox txtTempsFormationConc;
        internal static System.Windows.Forms.TextBox txtTempsDessinConc;
        internal static System.Windows.Forms.TextBox txtTempsTestConc;
        internal static System.Windows.Forms.TextBox txtTempsPeintureConc;
        internal static System.Windows.Forms.TextBox txtTempsAssemblageConc;
        internal static System.Windows.Forms.TextBox txtTempsSoudureConc;
        internal static System.Windows.Forms.TextBox txtTempsCoupeConc;
        internal static System.Windows.Forms.TextBox txtTempsMachinageConc;
        internal static System.Windows.Forms.TextBox txtTempsMachinageProj;
        internal static System.Windows.Forms.TextBox txtTempsCoupeProj;
        internal static System.Windows.Forms.TextBox txtTempsSoudureProj;
        internal static System.Windows.Forms.TextBox txtTempsAssemblageProj;
        internal static System.Windows.Forms.TextBox txtTempsPeintureProj;
        internal static System.Windows.Forms.TextBox txtTempsTestProj;
        internal static System.Windows.Forms.TextBox txtTempsDessinProj;
        internal static System.Windows.Forms.TextBox txtTempsFormationProj;
        internal static System.Windows.Forms.TextBox txtTempsInstallationProj;
        internal static System.Windows.Forms.TextBox txtTempsInstallationSoum;
        internal static System.Windows.Forms.TextBox txtTempsFormationSoum;
        internal static System.Windows.Forms.TextBox txtTempsDessinSoum;
        internal static System.Windows.Forms.TextBox txtTempsTestSoum;
        internal static System.Windows.Forms.TextBox txtTempsPeintureSoum;
        internal static System.Windows.Forms.TextBox txtTempsAssemblageSoum;
        internal static System.Windows.Forms.TextBox txtTempsSoudureSoum;
        internal static System.Windows.Forms.TextBox txtTempsCoupeSoum;
        internal static System.Windows.Forms.TextBox txtTempsMachinageSoum;
        internal static System.Windows.Forms.Label lblPrixPrototype;
        internal static System.Windows.Forms.Label lblTempsPrototypeReel;
        internal static System.Windows.Forms.Label Label60;
        internal static System.Windows.Forms.Label Label51;
        internal static System.Windows.Forms.Label Label39;
        internal static System.Windows.Forms.Label Label59;
        internal static System.Windows.Forms.Label Label55;
        internal static System.Windows.Forms.Label Label53;
        internal static System.Windows.Forms.Label lblTempsShippingReel;
        internal static System.Windows.Forms.Label lblPrixShipping;
        internal static System.Windows.Forms.Label lblPrixInstallation;
        internal static System.Windows.Forms.Label lblPrixFormation;
        internal static System.Windows.Forms.Label lblPrixDessin;
        internal static System.Windows.Forms.Label lblPrixGestion;
        internal static System.Windows.Forms.Label lblPrixTest;
        internal static System.Windows.Forms.Label lblPrixPeinture;
        internal static System.Windows.Forms.Label lblPrixAssemblage;
        internal static System.Windows.Forms.Label lblPrixSoudure;
        internal static System.Windows.Forms.Label lblPrixCoupe;
        internal static System.Windows.Forms.Label lblPrixMachinage;
        internal static System.Windows.Forms.Label lblTempsGestionReel;
        internal static System.Windows.Forms.Label Label67;
        internal static System.Windows.Forms.Label Label66;
        internal static System.Windows.Forms.Label Label65;
        internal static System.Windows.Forms.Label lblTempsInstallationReel;
        internal static System.Windows.Forms.Label lblTempsFormationReel;
        internal static System.Windows.Forms.Label lblTempsDessinReel;
        internal static System.Windows.Forms.Label lblTempsTestReel;
        internal static System.Windows.Forms.Label lblTempsPeintureReel;
        internal static System.Windows.Forms.Label lblTempsAssemblageReel;
        internal static System.Windows.Forms.Label lblTempsSoudureReel;
        internal static System.Windows.Forms.Label lblTempsCoupeReel;
        internal static System.Windows.Forms.Label lblTempsMachinageReel;
        internal static System.Windows.Forms.Label Label58;
        internal static System.Windows.Forms.Label Label57;
        internal static System.Windows.Forms.Label Label56;
        internal static System.Windows.Forms.Label Label54;
        internal static System.Windows.Forms.Label Label49;
        internal static System.Windows.Forms.Label Label47;
        internal static System.Windows.Forms.Label Label43;
        internal static System.Windows.Forms.Label Label41;
        internal static System.Windows.Forms.Label Label40;
        internal static System.Windows.Forms.Label Label32;
        internal static System.Windows.Forms.Label Label23;
        internal static System.Windows.Forms.Label Label22;
        internal static System.Windows.Forms.Label Label21;
        internal static System.Windows.Forms.Label Label20;
        internal static System.Windows.Forms.Label Label19;
        internal static System.Windows.Forms.Label Label18;
        internal static System.Windows.Forms.Label Label17;
        internal static System.Windows.Forms.Label Label16;
        internal static System.Windows.Forms.Label Label15;
        internal static System.Windows.Forms.Label Label14;
        internal static System.Windows.Forms.Label Label13;
        internal static System.Windows.Forms.Label Label12;
        internal static System.Windows.Forms.Label Label11;
        internal static System.Windows.Forms.Label Label10;
        internal static System.Windows.Forms.Label Label9;
        internal static System.Windows.Forms.Label Label8;
        internal static System.Windows.Forms.Label Label7;
        internal static System.Windows.Forms.Label Label6;
        internal static System.Windows.Forms.Label Label5;
        internal static System.Windows.Forms.Label Label4;
        internal static System.Windows.Forms.Label Label3;
        internal static System.Windows.Forms.Label Label2;
        internal static System.Windows.Forms.Label Label1;
        internal static System.Windows.Forms.GroupBox fraRessourcesHumaines;
        internal static System.Windows.Forms.Button cmdDetail;
        internal static System.Windows.Forms.Button cmdFermer;
        internal static System.Windows.Forms.TextBox txtPrixEmballage;
        internal static System.Windows.Forms.Label Label48;
        internal static System.Windows.Forms.Label Label33;
        internal static System.Windows.Forms.Label Label24;
        internal static System.Windows.Forms.GroupBox fraManutention;
        internal static System.Windows.Forms.TextBox txtNbrePersonne;
        internal static System.Windows.Forms.TextBox txtTempsDeplacement;
        internal static System.Windows.Forms.TextBox txtTempsHebergement;
        internal static System.Windows.Forms.TextBox txtTempsRepas;
        internal static System.Windows.Forms.TextBox txtTempsUniteMobile;
        internal static System.Windows.Forms.Label lblPrixUniteMobile;
        internal static System.Windows.Forms.Label lblPrixDeplacement;
        internal static System.Windows.Forms.Label lblPrixRepas;
        internal static System.Windows.Forms.Label lblPrixHebergement;
        internal static System.Windows.Forms.Label Label31;
        internal static System.Windows.Forms.Label Label46;
        internal static System.Windows.Forms.Label Label45;
        internal static System.Windows.Forms.Label Label44;
        internal static System.Windows.Forms.Label Label42;
        internal static System.Windows.Forms.Label Label38;
        internal static System.Windows.Forms.Label Label37;
        internal static System.Windows.Forms.Label Label36;
        internal static System.Windows.Forms.Label Label35;
        internal static System.Windows.Forms.Label Label34;
        internal static System.Windows.Forms.Label Label30;
        internal static System.Windows.Forms.Label Label29;
        internal static System.Windows.Forms.Label Label28;
        internal static System.Windows.Forms.Label Label27;
        internal static System.Windows.Forms.GroupBox fraFraisSubsistences;
        internal static System.Windows.Forms.Button cmdUnlock;
        internal static System.Windows.Forms.Button cmdLock;
        internal static System.Windows.Forms.Label lblTotal;
        internal static System.Windows.Forms.Label lblTotalPrixRH;
        internal static System.Windows.Forms.Label lblTotalTempsRHProj;
        internal static System.Windows.Forms.Label lblTotalTempsRHConc;
        internal static System.Windows.Forms.Label lblTotalTempsRHReel;
        internal static System.Windows.Forms.Label lblTotalTempsRHSoum;
        internal static System.Windows.Forms.Label Label52;
        internal static System.Windows.Forms.Label lblDollarRH;
        internal static System.Windows.Forms.Label Label50;
        internal static System.Windows.Forms.Label Label26;
        internal static System.Windows.Forms.Label Label25;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.Resources.ResourceManager(typeof(ProjSoumMecTemps));
            components = new System.ComponentModel.Container();
            ToolTip1 = new ToolTip(components);
            fraRessourcesHumaines = new GroupBox();
            txtTempsPrototypeConc = new TextBox();
            txtTempsPrototypeSoum = new TextBox();
            txtTempsPrototypeProj = new TextBox();
            txtTempsShippingProj = new TextBox();
            txtTempsShippingProj.TextChanged += new EventHandler(txtTempsShippingProj_TextChanged);
            txtTempsShippingProj.Leave += new EventHandler(txtTempsShippingProj_Leave);
            txtTempsShippingSoum = new TextBox();
            txtTempsShippingSoum.TextChanged += new EventHandler(txtTempsShippingSoum_TextChanged);
            txtTempsShippingSoum.Leave += new EventHandler(txtTempsShippingSoum_Leave);
            txtTempsShippingConc = new TextBox();
            txtTempsShippingConc.TextChanged += new EventHandler(txtTempsShippingConc_TextChanged);
            txtTempsShippingConc.Leave += new EventHandler(txtTempsShippingConc_Leave);
            txtTempsGestionConc = new TextBox();
            txtTempsGestionConc.TextChanged += new EventHandler(txtTempsGestionConc_TextChanged);
            txtTempsGestionConc.Leave += new EventHandler(txtTempsGestionConc_Leave);
            txtTempsGestionSoum = new TextBox();
            txtTempsGestionSoum.TextChanged += new EventHandler(txtTempsGestionSoum_TextChanged);
            txtTempsGestionSoum.Leave += new EventHandler(txtTempsGestionSoum_Leave);
            txtTempsGestionProj = new TextBox();
            txtTempsGestionProj.TextChanged += new EventHandler(txtTempsGestionProj_TextChanged);
            txtTempsGestionProj.Leave += new EventHandler(txtTempsGestionProj_Leave);
            txtTempsInstallationConc = new TextBox();
            txtTempsInstallationConc.TextChanged += new EventHandler(txtTempsInstallationConc_TextChanged);
            txtTempsInstallationConc.Leave += new EventHandler(txtTempsInstallationConc_Leave);
            txtTempsFormationConc = new TextBox();
            txtTempsFormationConc.TextChanged += new EventHandler(txtTempsFormationConc_TextChanged);
            txtTempsFormationConc.Leave += new EventHandler(txtTempsFormationConc_Leave);
            txtTempsDessinConc = new TextBox();
            txtTempsDessinConc.TextChanged += new EventHandler(txtTempsDessinConc_TextChanged);
            txtTempsDessinConc.Leave += new EventHandler(txtTempsDessinConc_Leave);
            txtTempsTestConc = new TextBox();
            txtTempsTestConc.TextChanged += new EventHandler(txtTempsTestConc_TextChanged);
            txtTempsTestConc.Leave += new EventHandler(txtTempsTestConc_Leave);
            txtTempsPeintureConc = new TextBox();
            txtTempsPeintureConc.TextChanged += new EventHandler(txtTempsPeintureConc_TextChanged);
            txtTempsPeintureConc.Leave += new EventHandler(txtTempsPeintureConc_Leave);
            txtTempsAssemblageConc = new TextBox();
            txtTempsAssemblageConc.TextChanged += new EventHandler(txtTempsAssemblageConc_TextChanged);
            txtTempsAssemblageConc.Leave += new EventHandler(txtTempsAssemblageConc_Leave);
            txtTempsSoudureConc = new TextBox();
            txtTempsSoudureConc.TextChanged += new EventHandler(txtTempsSoudureConc_TextChanged);
            txtTempsSoudureConc.Leave += new EventHandler(txtTempsSoudureConc_Leave);
            txtTempsCoupeConc = new TextBox();
            txtTempsCoupeConc.TextChanged += new EventHandler(txtTempsCoupeConc_TextChanged);
            txtTempsCoupeConc.Leave += new EventHandler(txtTempsCoupeConc_Leave);
            txtTempsMachinageConc = new TextBox();
            txtTempsMachinageConc.TextChanged += new EventHandler(txtTempsMachinageConc_TextChanged);
            txtTempsMachinageConc.Leave += new EventHandler(txtTempsMachinageConc_Leave);
            txtTempsMachinageProj = new TextBox();
            txtTempsMachinageProj.TextChanged += new EventHandler(txtTempsMachinageProj_TextChanged);
            txtTempsMachinageProj.Leave += new EventHandler(txtTempsMachinageProj_Leave);
            txtTempsCoupeProj = new TextBox();
            txtTempsCoupeProj.TextChanged += new EventHandler(txtTempsCoupeProj_TextChanged);
            txtTempsCoupeProj.Leave += new EventHandler(txtTempsCoupeProj_Leave);
            txtTempsSoudureProj = new TextBox();
            txtTempsSoudureProj.TextChanged += new EventHandler(txtTempsSoudureProj_TextChanged);
            txtTempsSoudureProj.Leave += new EventHandler(txtTempsSoudureProj_Leave);
            txtTempsAssemblageProj = new TextBox();
            txtTempsAssemblageProj.TextChanged += new EventHandler(txtTempsAssemblageProj_TextChanged);
            txtTempsAssemblageProj.Leave += new EventHandler(txtTempsAssemblageProj_Leave);
            txtTempsPeintureProj = new TextBox();
            txtTempsPeintureProj.TextChanged += new EventHandler(txtTempsPeintureProj_TextChanged);
            txtTempsPeintureProj.Leave += new EventHandler(txtTempsPeintureProj_Leave);
            txtTempsTestProj = new TextBox();
            txtTempsTestProj.TextChanged += new EventHandler(txtTempsTestProj_TextChanged);
            txtTempsTestProj.Leave += new EventHandler(txtTempsTestProj_Leave);
            txtTempsDessinProj = new TextBox();
            txtTempsDessinProj.TextChanged += new EventHandler(txtTempsDessinProj_TextChanged);
            txtTempsDessinProj.Leave += new EventHandler(txtTempsDessinProj_Leave);
            txtTempsFormationProj = new TextBox();
            txtTempsFormationProj.TextChanged += new EventHandler(txtTempsFormationProj_TextChanged);
            txtTempsFormationProj.Leave += new EventHandler(txtTempsFormationProj_Leave);
            txtTempsInstallationProj = new TextBox();
            txtTempsInstallationProj.TextChanged += new EventHandler(txtTempsInstallationProj_TextChanged);
            txtTempsInstallationProj.Leave += new EventHandler(txtTempsInstallationProj_Leave);
            txtTempsInstallationSoum = new TextBox();
            txtTempsInstallationSoum.TextChanged += new EventHandler(txtTempsInstallationSoum_TextChanged);
            txtTempsInstallationSoum.Leave += new EventHandler(txtTempsInstallationSoum_Leave);
            txtTempsFormationSoum = new TextBox();
            txtTempsFormationSoum.TextChanged += new EventHandler(txtTempsFormationSoum_TextChanged);
            txtTempsFormationSoum.Leave += new EventHandler(txtTempsFormationSoum_Leave);
            txtTempsDessinSoum = new TextBox();
            txtTempsDessinSoum.TextChanged += new EventHandler(txtTempsDessinSoum_TextChanged);
            txtTempsDessinSoum.Leave += new EventHandler(txtTempsDessinSoum_Leave);
            txtTempsTestSoum = new TextBox();
            txtTempsTestSoum.TextChanged += new EventHandler(txtTempsTestSoum_TextChanged);
            txtTempsTestSoum.Leave += new EventHandler(txtTempsTestSoum_Leave);
            txtTempsPeintureSoum = new TextBox();
            txtTempsPeintureSoum.TextChanged += new EventHandler(txtTempsPeintureSoum_TextChanged);
            txtTempsPeintureSoum.Leave += new EventHandler(txtTempsPeintureSoum_Leave);
            txtTempsAssemblageSoum = new TextBox();
            txtTempsAssemblageSoum.TextChanged += new EventHandler(txtTempsAssemblageSoum_TextChanged);
            txtTempsAssemblageSoum.Leave += new EventHandler(txtTempsAssemblageSoum_Leave);
            txtTempsSoudureSoum = new TextBox();
            txtTempsSoudureSoum.TextChanged += new EventHandler(txtTempsSoudureSoum_TextChanged);
            txtTempsSoudureSoum.Leave += new EventHandler(txtTempsSoudureSoum_Leave);
            txtTempsCoupeSoum = new TextBox();
            txtTempsCoupeSoum.TextChanged += new EventHandler(txtTempsCoupeSoum_TextChanged);
            txtTempsCoupeSoum.Leave += new EventHandler(txtTempsCoupeSoum_Leave);
            txtTempsMachinageSoum = new TextBox();
            txtTempsMachinageSoum.TextChanged += new EventHandler(txtTempsMachinageSoum_TextChanged);
            txtTempsMachinageSoum.Leave += new EventHandler(txtTempsMachinageSoum_Leave);
            lblPrixPrototype = new Label();
            lblTempsPrototypeReel = new Label();
            Label60 = new Label();
            Label51 = new Label();
            Label39 = new Label();
            Label59 = new Label();
            Label55 = new Label();
            Label53 = new Label();
            lblTempsShippingReel = new Label();
            lblPrixShipping = new Label();
            lblPrixInstallation = new Label();
            lblPrixFormation = new Label();
            lblPrixDessin = new Label();
            lblPrixGestion = new Label();
            lblPrixTest = new Label();
            lblPrixPeinture = new Label();
            lblPrixAssemblage = new Label();
            lblPrixSoudure = new Label();
            lblPrixCoupe = new Label();
            lblPrixMachinage = new Label();
            lblTempsGestionReel = new Label();
            Label67 = new Label();
            Label66 = new Label();
            Label65 = new Label();
            lblTempsInstallationReel = new Label();
            lblTempsFormationReel = new Label();
            lblTempsDessinReel = new Label();
            lblTempsTestReel = new Label();
            lblTempsPeintureReel = new Label();
            lblTempsAssemblageReel = new Label();
            lblTempsSoudureReel = new Label();
            lblTempsCoupeReel = new Label();
            lblTempsMachinageReel = new Label();
            Label58 = new Label();
            Label57 = new Label();
            Label56 = new Label();
            Label54 = new Label();
            Label49 = new Label();
            Label47 = new Label();
            Label43 = new Label();
            Label41 = new Label();
            Label40 = new Label();
            Label32 = new Label();
            Label23 = new Label();
            Label22 = new Label();
            Label21 = new Label();
            Label20 = new Label();
            Label19 = new Label();
            Label18 = new Label();
            Label17 = new Label();
            Label16 = new Label();
            Label15 = new Label();
            Label14 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label9 = new Label();
            Label8 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            cmdDetail = new Button();
            cmdDetail.Click += new EventHandler(cmdDetail_Click);
            cmdFermer = new Button();
            cmdFermer.Click += new EventHandler(cmdFermer_Click);
            fraManutention = new GroupBox();
            txtPrixEmballage = new TextBox();
            txtPrixEmballage.KeyPress += new KeyPressEventHandler(txtPrixEmballage_KeyPress);
            txtPrixEmballage.TextChanged += new EventHandler(txtPrixEmballage_TextChanged);
            txtPrixEmballage.Leave += new EventHandler(txtPrixEmballage_Leave);
            Label48 = new Label();
            Label33 = new Label();
            Label24 = new Label();
            fraFraisSubsistences = new GroupBox();
            txtNbrePersonne = new TextBox();
            txtNbrePersonne.TextChanged += new EventHandler(txtNbrePersonne_TextChanged);
            txtTempsDeplacement = new TextBox();
            txtTempsDeplacement.TextChanged += new EventHandler(txtTempsDeplacement_TextChanged);
            txtTempsDeplacement.Leave += new EventHandler(txtTempsDeplacement_Leave);
            txtTempsHebergement = new TextBox();
            txtTempsHebergement.TextChanged += new EventHandler(txtTempsHebergement_TextChanged);
            txtTempsHebergement.Leave += new EventHandler(txtTempsHebergement_Leave);
            txtTempsRepas = new TextBox();
            txtTempsRepas.TextChanged += new EventHandler(txtTempsRepas_TextChanged);
            txtTempsRepas.Leave += new EventHandler(txtTempsRepas_Leave);
            txtTempsUniteMobile = new TextBox();
            txtTempsUniteMobile.TextChanged += new EventHandler(txtTempsUniteMobile_TextChanged);
            txtTempsUniteMobile.Leave += new EventHandler(txtTempsUniteMobile_Leave);
            lblPrixUniteMobile = new Label();
            lblPrixDeplacement = new Label();
            lblPrixRepas = new Label();
            lblPrixHebergement = new Label();
            Label31 = new Label();
            Label46 = new Label();
            Label45 = new Label();
            Label44 = new Label();
            Label42 = new Label();
            Label38 = new Label();
            Label37 = new Label();
            Label36 = new Label();
            Label35 = new Label();
            Label34 = new Label();
            Label30 = new Label();
            Label29 = new Label();
            Label28 = new Label();
            Label27 = new Label();
            cmdUnlock = new Button();
            cmdUnlock.Click += new EventHandler(cmdUnlock_Click);
            cmdLock = new Button();
            cmdLock.Click += new EventHandler(cmdLock_Click);
            lblTotal = new Label();
            lblTotalPrixRH = new Label();
            lblTotalTempsRHProj = new Label();
            lblTotalTempsRHConc = new Label();
            lblTotalTempsRHReel = new Label();
            lblTotalTempsRHSoum = new Label();
            Label52 = new Label();
            lblDollarRH = new Label();
            Label50 = new Label();
            Label26 = new Label();
            Label25 = new Label();
            fraRessourcesHumaines.SuspendLayout();
            fraManutention.SuspendLayout();
            fraFraisSubsistences.SuspendLayout();
            SuspendLayout();
            ToolTip1.Active = true;
            BackColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = "Temps";
            ClientSize = new Size(877, 612);
            Location = new Point(3, 22);
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            BackgroundImageLayout = ImageLayout.None;
            BackgroundImage = (Image)resources.GetObject("ProjSoumMecTemps.BackgroundImage");
            StartPosition = FormStartPosition.CenterScreen;
            Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AutoScaleMode = AutoScaleMode.Font;
            Enabled = true;
            KeyPreview = false;
            Cursor = Cursors.Default;
            RightToLeft = RightToLeft.No;
            ShowInTaskbar = true;
            HelpButton = false;
            WindowState = FormWindowState.Normal;
            Name = "ProjSoumMecTemps";
            fraRessourcesHumaines.BackColor = Color.Black;
            fraRessourcesHumaines.Text = "Ressources humaines";
            fraRessourcesHumaines.Font = new Font("Arial", 8.25f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            fraRessourcesHumaines.ForeColor = Color.White;
            fraRessourcesHumaines.Size = new Size(529, 361);
            fraRessourcesHumaines.Location = new Point(8, 56);
            fraRessourcesHumaines.TabIndex = 41;
            fraRessourcesHumaines.Enabled = true;
            fraRessourcesHumaines.RightToLeft = RightToLeft.No;
            fraRessourcesHumaines.Visible = true;
            fraRessourcesHumaines.Padding = new Padding(0);
            fraRessourcesHumaines.Name = "fraRessourcesHumaines";
            txtTempsPrototypeConc.AutoSize = false;
            txtTempsPrototypeConc.Size = new Size(49, 19);
            txtTempsPrototypeConc.Location = new Point(312, 320);
            txtTempsPrototypeConc.TabIndex = 141;
            txtTempsPrototypeConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsPrototypeConc.AcceptsReturn = true;
            txtTempsPrototypeConc.TextAlign = HorizontalAlignment.Left;
            txtTempsPrototypeConc.BackColor = SystemColors.Window;
            txtTempsPrototypeConc.CausesValidation = true;
            txtTempsPrototypeConc.Enabled = true;
            txtTempsPrototypeConc.ForeColor = SystemColors.WindowText;
            txtTempsPrototypeConc.HideSelection = true;
            txtTempsPrototypeConc.ReadOnly = false;
            txtTempsPrototypeConc.MaxLength = 0;
            txtTempsPrototypeConc.Cursor = Cursors.IBeam;
            txtTempsPrototypeConc.Multiline = false;
            txtTempsPrototypeConc.RightToLeft = RightToLeft.No;
            txtTempsPrototypeConc.ScrollBars = ScrollBars.None;
            txtTempsPrototypeConc.TabStop = true;
            txtTempsPrototypeConc.Visible = true;
            txtTempsPrototypeConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsPrototypeConc.Name = "txtTempsPrototypeConc";
            txtTempsPrototypeSoum.AutoSize = false;
            txtTempsPrototypeSoum.Size = new Size(49, 19);
            txtTempsPrototypeSoum.Location = new Point(200, 320);
            txtTempsPrototypeSoum.TabIndex = 140;
            txtTempsPrototypeSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsPrototypeSoum.AcceptsReturn = true;
            txtTempsPrototypeSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsPrototypeSoum.BackColor = SystemColors.Window;
            txtTempsPrototypeSoum.CausesValidation = true;
            txtTempsPrototypeSoum.Enabled = true;
            txtTempsPrototypeSoum.ForeColor = SystemColors.WindowText;
            txtTempsPrototypeSoum.HideSelection = true;
            txtTempsPrototypeSoum.ReadOnly = false;
            txtTempsPrototypeSoum.MaxLength = 0;
            txtTempsPrototypeSoum.Cursor = Cursors.IBeam;
            txtTempsPrototypeSoum.Multiline = false;
            txtTempsPrototypeSoum.RightToLeft = RightToLeft.No;
            txtTempsPrototypeSoum.ScrollBars = ScrollBars.None;
            txtTempsPrototypeSoum.TabStop = true;
            txtTempsPrototypeSoum.Visible = true;
            txtTempsPrototypeSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsPrototypeSoum.Name = "txtTempsPrototypeSoum";
            txtTempsPrototypeProj.AutoSize = false;
            txtTempsPrototypeProj.Size = new Size(49, 19);
            txtTempsPrototypeProj.Location = new Point(256, 320);
            txtTempsPrototypeProj.TabIndex = 139;
            txtTempsPrototypeProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsPrototypeProj.AcceptsReturn = true;
            txtTempsPrototypeProj.TextAlign = HorizontalAlignment.Left;
            txtTempsPrototypeProj.BackColor = SystemColors.Window;
            txtTempsPrototypeProj.CausesValidation = true;
            txtTempsPrototypeProj.Enabled = true;
            txtTempsPrototypeProj.ForeColor = SystemColors.WindowText;
            txtTempsPrototypeProj.HideSelection = true;
            txtTempsPrototypeProj.ReadOnly = false;
            txtTempsPrototypeProj.MaxLength = 0;
            txtTempsPrototypeProj.Cursor = Cursors.IBeam;
            txtTempsPrototypeProj.Multiline = false;
            txtTempsPrototypeProj.RightToLeft = RightToLeft.No;
            txtTempsPrototypeProj.ScrollBars = ScrollBars.None;
            txtTempsPrototypeProj.TabStop = true;
            txtTempsPrototypeProj.Visible = true;
            txtTempsPrototypeProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsPrototypeProj.Name = "txtTempsPrototypeProj";
            txtTempsShippingProj.AutoSize = false;
            txtTempsShippingProj.Size = new Size(49, 19);
            txtTempsShippingProj.Location = new Point(256, 296);
            txtTempsShippingProj.TabIndex = 133;
            txtTempsShippingProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsShippingProj.AcceptsReturn = true;
            txtTempsShippingProj.TextAlign = HorizontalAlignment.Left;
            txtTempsShippingProj.BackColor = SystemColors.Window;
            txtTempsShippingProj.CausesValidation = true;
            txtTempsShippingProj.Enabled = true;
            txtTempsShippingProj.ForeColor = SystemColors.WindowText;
            txtTempsShippingProj.HideSelection = true;
            txtTempsShippingProj.ReadOnly = false;
            txtTempsShippingProj.MaxLength = 0;
            txtTempsShippingProj.Cursor = Cursors.IBeam;
            txtTempsShippingProj.Multiline = false;
            txtTempsShippingProj.RightToLeft = RightToLeft.No;
            txtTempsShippingProj.ScrollBars = ScrollBars.None;
            txtTempsShippingProj.TabStop = true;
            txtTempsShippingProj.Visible = true;
            txtTempsShippingProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsShippingProj.Name = "txtTempsShippingProj";
            txtTempsShippingSoum.AutoSize = false;
            txtTempsShippingSoum.Size = new Size(49, 19);
            txtTempsShippingSoum.Location = new Point(200, 296);
            txtTempsShippingSoum.TabIndex = 132;
            txtTempsShippingSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsShippingSoum.AcceptsReturn = true;
            txtTempsShippingSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsShippingSoum.BackColor = SystemColors.Window;
            txtTempsShippingSoum.CausesValidation = true;
            txtTempsShippingSoum.Enabled = true;
            txtTempsShippingSoum.ForeColor = SystemColors.WindowText;
            txtTempsShippingSoum.HideSelection = true;
            txtTempsShippingSoum.ReadOnly = false;
            txtTempsShippingSoum.MaxLength = 0;
            txtTempsShippingSoum.Cursor = Cursors.IBeam;
            txtTempsShippingSoum.Multiline = false;
            txtTempsShippingSoum.RightToLeft = RightToLeft.No;
            txtTempsShippingSoum.ScrollBars = ScrollBars.None;
            txtTempsShippingSoum.TabStop = true;
            txtTempsShippingSoum.Visible = true;
            txtTempsShippingSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsShippingSoum.Name = "txtTempsShippingSoum";
            txtTempsShippingConc.AutoSize = false;
            txtTempsShippingConc.Size = new Size(49, 19);
            txtTempsShippingConc.Location = new Point(312, 296);
            txtTempsShippingConc.TabIndex = 131;
            txtTempsShippingConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsShippingConc.AcceptsReturn = true;
            txtTempsShippingConc.TextAlign = HorizontalAlignment.Left;
            txtTempsShippingConc.BackColor = SystemColors.Window;
            txtTempsShippingConc.CausesValidation = true;
            txtTempsShippingConc.Enabled = true;
            txtTempsShippingConc.ForeColor = SystemColors.WindowText;
            txtTempsShippingConc.HideSelection = true;
            txtTempsShippingConc.ReadOnly = false;
            txtTempsShippingConc.MaxLength = 0;
            txtTempsShippingConc.Cursor = Cursors.IBeam;
            txtTempsShippingConc.Multiline = false;
            txtTempsShippingConc.RightToLeft = RightToLeft.No;
            txtTempsShippingConc.ScrollBars = ScrollBars.None;
            txtTempsShippingConc.TabStop = true;
            txtTempsShippingConc.Visible = true;
            txtTempsShippingConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsShippingConc.Name = "txtTempsShippingConc";
            txtTempsGestionConc.AutoSize = false;
            txtTempsGestionConc.Size = new Size(49, 19);
            txtTempsGestionConc.Location = new Point(312, 272);
            txtTempsGestionConc.TabIndex = 29;
            txtTempsGestionConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsGestionConc.AcceptsReturn = true;
            txtTempsGestionConc.TextAlign = HorizontalAlignment.Left;
            txtTempsGestionConc.BackColor = SystemColors.Window;
            txtTempsGestionConc.CausesValidation = true;
            txtTempsGestionConc.Enabled = true;
            txtTempsGestionConc.ForeColor = SystemColors.WindowText;
            txtTempsGestionConc.HideSelection = true;
            txtTempsGestionConc.ReadOnly = false;
            txtTempsGestionConc.MaxLength = 0;
            txtTempsGestionConc.Cursor = Cursors.IBeam;
            txtTempsGestionConc.Multiline = false;
            txtTempsGestionConc.RightToLeft = RightToLeft.No;
            txtTempsGestionConc.ScrollBars = ScrollBars.None;
            txtTempsGestionConc.TabStop = true;
            txtTempsGestionConc.Visible = true;
            txtTempsGestionConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsGestionConc.Name = "txtTempsGestionConc";
            txtTempsGestionSoum.AutoSize = false;
            txtTempsGestionSoum.Size = new Size(49, 19);
            txtTempsGestionSoum.Location = new Point(200, 272);
            txtTempsGestionSoum.TabIndex = 9;
            txtTempsGestionSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsGestionSoum.AcceptsReturn = true;
            txtTempsGestionSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsGestionSoum.BackColor = SystemColors.Window;
            txtTempsGestionSoum.CausesValidation = true;
            txtTempsGestionSoum.Enabled = true;
            txtTempsGestionSoum.ForeColor = SystemColors.WindowText;
            txtTempsGestionSoum.HideSelection = true;
            txtTempsGestionSoum.ReadOnly = false;
            txtTempsGestionSoum.MaxLength = 0;
            txtTempsGestionSoum.Cursor = Cursors.IBeam;
            txtTempsGestionSoum.Multiline = false;
            txtTempsGestionSoum.RightToLeft = RightToLeft.No;
            txtTempsGestionSoum.ScrollBars = ScrollBars.None;
            txtTempsGestionSoum.TabStop = true;
            txtTempsGestionSoum.Visible = true;
            txtTempsGestionSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsGestionSoum.Name = "txtTempsGestionSoum";
            txtTempsGestionProj.AutoSize = false;
            txtTempsGestionProj.Size = new Size(49, 19);
            txtTempsGestionProj.Location = new Point(256, 272);
            txtTempsGestionProj.TabIndex = 19;
            txtTempsGestionProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsGestionProj.AcceptsReturn = true;
            txtTempsGestionProj.TextAlign = HorizontalAlignment.Left;
            txtTempsGestionProj.BackColor = SystemColors.Window;
            txtTempsGestionProj.CausesValidation = true;
            txtTempsGestionProj.Enabled = true;
            txtTempsGestionProj.ForeColor = SystemColors.WindowText;
            txtTempsGestionProj.HideSelection = true;
            txtTempsGestionProj.ReadOnly = false;
            txtTempsGestionProj.MaxLength = 0;
            txtTempsGestionProj.Cursor = Cursors.IBeam;
            txtTempsGestionProj.Multiline = false;
            txtTempsGestionProj.RightToLeft = RightToLeft.No;
            txtTempsGestionProj.ScrollBars = ScrollBars.None;
            txtTempsGestionProj.TabStop = true;
            txtTempsGestionProj.Visible = true;
            txtTempsGestionProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsGestionProj.Name = "txtTempsGestionProj";
            txtTempsInstallationConc.AutoSize = false;
            txtTempsInstallationConc.Size = new Size(49, 19);
            txtTempsInstallationConc.Location = new Point(312, 224);
            txtTempsInstallationConc.TabIndex = 27;
            txtTempsInstallationConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsInstallationConc.AcceptsReturn = true;
            txtTempsInstallationConc.TextAlign = HorizontalAlignment.Left;
            txtTempsInstallationConc.BackColor = SystemColors.Window;
            txtTempsInstallationConc.CausesValidation = true;
            txtTempsInstallationConc.Enabled = true;
            txtTempsInstallationConc.ForeColor = SystemColors.WindowText;
            txtTempsInstallationConc.HideSelection = true;
            txtTempsInstallationConc.ReadOnly = false;
            txtTempsInstallationConc.MaxLength = 0;
            txtTempsInstallationConc.Cursor = Cursors.IBeam;
            txtTempsInstallationConc.Multiline = false;
            txtTempsInstallationConc.RightToLeft = RightToLeft.No;
            txtTempsInstallationConc.ScrollBars = ScrollBars.None;
            txtTempsInstallationConc.TabStop = true;
            txtTempsInstallationConc.Visible = true;
            txtTempsInstallationConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsInstallationConc.Name = "txtTempsInstallationConc";
            txtTempsFormationConc.AutoSize = false;
            txtTempsFormationConc.Size = new Size(49, 19);
            txtTempsFormationConc.Location = new Point(312, 248);
            txtTempsFormationConc.TabIndex = 28;
            txtTempsFormationConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsFormationConc.AcceptsReturn = true;
            txtTempsFormationConc.TextAlign = HorizontalAlignment.Left;
            txtTempsFormationConc.BackColor = SystemColors.Window;
            txtTempsFormationConc.CausesValidation = true;
            txtTempsFormationConc.Enabled = true;
            txtTempsFormationConc.ForeColor = SystemColors.WindowText;
            txtTempsFormationConc.HideSelection = true;
            txtTempsFormationConc.ReadOnly = false;
            txtTempsFormationConc.MaxLength = 0;
            txtTempsFormationConc.Cursor = Cursors.IBeam;
            txtTempsFormationConc.Multiline = false;
            txtTempsFormationConc.RightToLeft = RightToLeft.No;
            txtTempsFormationConc.ScrollBars = ScrollBars.None;
            txtTempsFormationConc.TabStop = true;
            txtTempsFormationConc.Visible = true;
            txtTempsFormationConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsFormationConc.Name = "txtTempsFormationConc";
            txtTempsDessinConc.AutoSize = false;
            txtTempsDessinConc.Size = new Size(49, 19);
            txtTempsDessinConc.Location = new Point(312, 56);
            txtTempsDessinConc.TabIndex = 20;
            txtTempsDessinConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsDessinConc.AcceptsReturn = true;
            txtTempsDessinConc.TextAlign = HorizontalAlignment.Left;
            txtTempsDessinConc.BackColor = SystemColors.Window;
            txtTempsDessinConc.CausesValidation = true;
            txtTempsDessinConc.Enabled = true;
            txtTempsDessinConc.ForeColor = SystemColors.WindowText;
            txtTempsDessinConc.HideSelection = true;
            txtTempsDessinConc.ReadOnly = false;
            txtTempsDessinConc.MaxLength = 0;
            txtTempsDessinConc.Cursor = Cursors.IBeam;
            txtTempsDessinConc.Multiline = false;
            txtTempsDessinConc.RightToLeft = RightToLeft.No;
            txtTempsDessinConc.ScrollBars = ScrollBars.None;
            txtTempsDessinConc.TabStop = true;
            txtTempsDessinConc.Visible = true;
            txtTempsDessinConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsDessinConc.Name = "txtTempsDessinConc";
            txtTempsTestConc.AutoSize = false;
            txtTempsTestConc.Size = new Size(49, 19);
            txtTempsTestConc.Location = new Point(312, 200);
            txtTempsTestConc.TabIndex = 26;
            txtTempsTestConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsTestConc.AcceptsReturn = true;
            txtTempsTestConc.TextAlign = HorizontalAlignment.Left;
            txtTempsTestConc.BackColor = SystemColors.Window;
            txtTempsTestConc.CausesValidation = true;
            txtTempsTestConc.Enabled = true;
            txtTempsTestConc.ForeColor = SystemColors.WindowText;
            txtTempsTestConc.HideSelection = true;
            txtTempsTestConc.ReadOnly = false;
            txtTempsTestConc.MaxLength = 0;
            txtTempsTestConc.Cursor = Cursors.IBeam;
            txtTempsTestConc.Multiline = false;
            txtTempsTestConc.RightToLeft = RightToLeft.No;
            txtTempsTestConc.ScrollBars = ScrollBars.None;
            txtTempsTestConc.TabStop = true;
            txtTempsTestConc.Visible = true;
            txtTempsTestConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsTestConc.Name = "txtTempsTestConc";
            txtTempsPeintureConc.AutoSize = false;
            txtTempsPeintureConc.Size = new Size(49, 19);
            txtTempsPeintureConc.Location = new Point(312, 176);
            txtTempsPeintureConc.TabIndex = 25;
            txtTempsPeintureConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsPeintureConc.AcceptsReturn = true;
            txtTempsPeintureConc.TextAlign = HorizontalAlignment.Left;
            txtTempsPeintureConc.BackColor = SystemColors.Window;
            txtTempsPeintureConc.CausesValidation = true;
            txtTempsPeintureConc.Enabled = true;
            txtTempsPeintureConc.ForeColor = SystemColors.WindowText;
            txtTempsPeintureConc.HideSelection = true;
            txtTempsPeintureConc.ReadOnly = false;
            txtTempsPeintureConc.MaxLength = 0;
            txtTempsPeintureConc.Cursor = Cursors.IBeam;
            txtTempsPeintureConc.Multiline = false;
            txtTempsPeintureConc.RightToLeft = RightToLeft.No;
            txtTempsPeintureConc.ScrollBars = ScrollBars.None;
            txtTempsPeintureConc.TabStop = true;
            txtTempsPeintureConc.Visible = true;
            txtTempsPeintureConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsPeintureConc.Name = "txtTempsPeintureConc";
            txtTempsAssemblageConc.AutoSize = false;
            txtTempsAssemblageConc.Size = new Size(49, 19);
            txtTempsAssemblageConc.Location = new Point(312, 152);
            txtTempsAssemblageConc.TabIndex = 24;
            txtTempsAssemblageConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsAssemblageConc.AcceptsReturn = true;
            txtTempsAssemblageConc.TextAlign = HorizontalAlignment.Left;
            txtTempsAssemblageConc.BackColor = SystemColors.Window;
            txtTempsAssemblageConc.CausesValidation = true;
            txtTempsAssemblageConc.Enabled = true;
            txtTempsAssemblageConc.ForeColor = SystemColors.WindowText;
            txtTempsAssemblageConc.HideSelection = true;
            txtTempsAssemblageConc.ReadOnly = false;
            txtTempsAssemblageConc.MaxLength = 0;
            txtTempsAssemblageConc.Cursor = Cursors.IBeam;
            txtTempsAssemblageConc.Multiline = false;
            txtTempsAssemblageConc.RightToLeft = RightToLeft.No;
            txtTempsAssemblageConc.ScrollBars = ScrollBars.None;
            txtTempsAssemblageConc.TabStop = true;
            txtTempsAssemblageConc.Visible = true;
            txtTempsAssemblageConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsAssemblageConc.Name = "txtTempsAssemblageConc";
            txtTempsSoudureConc.AutoSize = false;
            txtTempsSoudureConc.Size = new Size(49, 19);
            txtTempsSoudureConc.Location = new Point(312, 128);
            txtTempsSoudureConc.TabIndex = 23;
            txtTempsSoudureConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsSoudureConc.AcceptsReturn = true;
            txtTempsSoudureConc.TextAlign = HorizontalAlignment.Left;
            txtTempsSoudureConc.BackColor = SystemColors.Window;
            txtTempsSoudureConc.CausesValidation = true;
            txtTempsSoudureConc.Enabled = true;
            txtTempsSoudureConc.ForeColor = SystemColors.WindowText;
            txtTempsSoudureConc.HideSelection = true;
            txtTempsSoudureConc.ReadOnly = false;
            txtTempsSoudureConc.MaxLength = 0;
            txtTempsSoudureConc.Cursor = Cursors.IBeam;
            txtTempsSoudureConc.Multiline = false;
            txtTempsSoudureConc.RightToLeft = RightToLeft.No;
            txtTempsSoudureConc.ScrollBars = ScrollBars.None;
            txtTempsSoudureConc.TabStop = true;
            txtTempsSoudureConc.Visible = true;
            txtTempsSoudureConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsSoudureConc.Name = "txtTempsSoudureConc";
            txtTempsCoupeConc.AutoSize = false;
            txtTempsCoupeConc.Size = new Size(49, 19);
            txtTempsCoupeConc.Location = new Point(312, 80);
            txtTempsCoupeConc.TabIndex = 21;
            txtTempsCoupeConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsCoupeConc.AcceptsReturn = true;
            txtTempsCoupeConc.TextAlign = HorizontalAlignment.Left;
            txtTempsCoupeConc.BackColor = SystemColors.Window;
            txtTempsCoupeConc.CausesValidation = true;
            txtTempsCoupeConc.Enabled = true;
            txtTempsCoupeConc.ForeColor = SystemColors.WindowText;
            txtTempsCoupeConc.HideSelection = true;
            txtTempsCoupeConc.ReadOnly = false;
            txtTempsCoupeConc.MaxLength = 0;
            txtTempsCoupeConc.Cursor = Cursors.IBeam;
            txtTempsCoupeConc.Multiline = false;
            txtTempsCoupeConc.RightToLeft = RightToLeft.No;
            txtTempsCoupeConc.ScrollBars = ScrollBars.None;
            txtTempsCoupeConc.TabStop = true;
            txtTempsCoupeConc.Visible = true;
            txtTempsCoupeConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsCoupeConc.Name = "txtTempsCoupeConc";
            txtTempsMachinageConc.AutoSize = false;
            txtTempsMachinageConc.Size = new Size(49, 19);
            txtTempsMachinageConc.Location = new Point(312, 104);
            txtTempsMachinageConc.TabIndex = 22;
            txtTempsMachinageConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsMachinageConc.AcceptsReturn = true;
            txtTempsMachinageConc.TextAlign = HorizontalAlignment.Left;
            txtTempsMachinageConc.BackColor = SystemColors.Window;
            txtTempsMachinageConc.CausesValidation = true;
            txtTempsMachinageConc.Enabled = true;
            txtTempsMachinageConc.ForeColor = SystemColors.WindowText;
            txtTempsMachinageConc.HideSelection = true;
            txtTempsMachinageConc.ReadOnly = false;
            txtTempsMachinageConc.MaxLength = 0;
            txtTempsMachinageConc.Cursor = Cursors.IBeam;
            txtTempsMachinageConc.Multiline = false;
            txtTempsMachinageConc.RightToLeft = RightToLeft.No;
            txtTempsMachinageConc.ScrollBars = ScrollBars.None;
            txtTempsMachinageConc.TabStop = true;
            txtTempsMachinageConc.Visible = true;
            txtTempsMachinageConc.BorderStyle = BorderStyle.Fixed3D;
            txtTempsMachinageConc.Name = "txtTempsMachinageConc";
            txtTempsMachinageProj.AutoSize = false;
            txtTempsMachinageProj.Size = new Size(49, 19);
            txtTempsMachinageProj.Location = new Point(256, 104);
            txtTempsMachinageProj.TabIndex = 12;
            txtTempsMachinageProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsMachinageProj.AcceptsReturn = true;
            txtTempsMachinageProj.TextAlign = HorizontalAlignment.Left;
            txtTempsMachinageProj.BackColor = SystemColors.Window;
            txtTempsMachinageProj.CausesValidation = true;
            txtTempsMachinageProj.Enabled = true;
            txtTempsMachinageProj.ForeColor = SystemColors.WindowText;
            txtTempsMachinageProj.HideSelection = true;
            txtTempsMachinageProj.ReadOnly = false;
            txtTempsMachinageProj.MaxLength = 0;
            txtTempsMachinageProj.Cursor = Cursors.IBeam;
            txtTempsMachinageProj.Multiline = false;
            txtTempsMachinageProj.RightToLeft = RightToLeft.No;
            txtTempsMachinageProj.ScrollBars = ScrollBars.None;
            txtTempsMachinageProj.TabStop = true;
            txtTempsMachinageProj.Visible = true;
            txtTempsMachinageProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsMachinageProj.Name = "txtTempsMachinageProj";
            txtTempsCoupeProj.AutoSize = false;
            txtTempsCoupeProj.Size = new Size(49, 19);
            txtTempsCoupeProj.Location = new Point(256, 80);
            txtTempsCoupeProj.TabIndex = 11;
            txtTempsCoupeProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsCoupeProj.AcceptsReturn = true;
            txtTempsCoupeProj.TextAlign = HorizontalAlignment.Left;
            txtTempsCoupeProj.BackColor = SystemColors.Window;
            txtTempsCoupeProj.CausesValidation = true;
            txtTempsCoupeProj.Enabled = true;
            txtTempsCoupeProj.ForeColor = SystemColors.WindowText;
            txtTempsCoupeProj.HideSelection = true;
            txtTempsCoupeProj.ReadOnly = false;
            txtTempsCoupeProj.MaxLength = 0;
            txtTempsCoupeProj.Cursor = Cursors.IBeam;
            txtTempsCoupeProj.Multiline = false;
            txtTempsCoupeProj.RightToLeft = RightToLeft.No;
            txtTempsCoupeProj.ScrollBars = ScrollBars.None;
            txtTempsCoupeProj.TabStop = true;
            txtTempsCoupeProj.Visible = true;
            txtTempsCoupeProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsCoupeProj.Name = "txtTempsCoupeProj";
            txtTempsSoudureProj.AutoSize = false;
            txtTempsSoudureProj.Size = new Size(49, 19);
            txtTempsSoudureProj.Location = new Point(256, 128);
            txtTempsSoudureProj.TabIndex = 13;
            txtTempsSoudureProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsSoudureProj.AcceptsReturn = true;
            txtTempsSoudureProj.TextAlign = HorizontalAlignment.Left;
            txtTempsSoudureProj.BackColor = SystemColors.Window;
            txtTempsSoudureProj.CausesValidation = true;
            txtTempsSoudureProj.Enabled = true;
            txtTempsSoudureProj.ForeColor = SystemColors.WindowText;
            txtTempsSoudureProj.HideSelection = true;
            txtTempsSoudureProj.ReadOnly = false;
            txtTempsSoudureProj.MaxLength = 0;
            txtTempsSoudureProj.Cursor = Cursors.IBeam;
            txtTempsSoudureProj.Multiline = false;
            txtTempsSoudureProj.RightToLeft = RightToLeft.No;
            txtTempsSoudureProj.ScrollBars = ScrollBars.None;
            txtTempsSoudureProj.TabStop = true;
            txtTempsSoudureProj.Visible = true;
            txtTempsSoudureProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsSoudureProj.Name = "txtTempsSoudureProj";
            txtTempsAssemblageProj.AutoSize = false;
            txtTempsAssemblageProj.Size = new Size(49, 19);
            txtTempsAssemblageProj.Location = new Point(256, 152);
            txtTempsAssemblageProj.TabIndex = 14;
            txtTempsAssemblageProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsAssemblageProj.AcceptsReturn = true;
            txtTempsAssemblageProj.TextAlign = HorizontalAlignment.Left;
            txtTempsAssemblageProj.BackColor = SystemColors.Window;
            txtTempsAssemblageProj.CausesValidation = true;
            txtTempsAssemblageProj.Enabled = true;
            txtTempsAssemblageProj.ForeColor = SystemColors.WindowText;
            txtTempsAssemblageProj.HideSelection = true;
            txtTempsAssemblageProj.ReadOnly = false;
            txtTempsAssemblageProj.MaxLength = 0;
            txtTempsAssemblageProj.Cursor = Cursors.IBeam;
            txtTempsAssemblageProj.Multiline = false;
            txtTempsAssemblageProj.RightToLeft = RightToLeft.No;
            txtTempsAssemblageProj.ScrollBars = ScrollBars.None;
            txtTempsAssemblageProj.TabStop = true;
            txtTempsAssemblageProj.Visible = true;
            txtTempsAssemblageProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsAssemblageProj.Name = "txtTempsAssemblageProj";
            txtTempsPeintureProj.AutoSize = false;
            txtTempsPeintureProj.Size = new Size(49, 19);
            txtTempsPeintureProj.Location = new Point(256, 176);
            txtTempsPeintureProj.TabIndex = 15;
            txtTempsPeintureProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsPeintureProj.AcceptsReturn = true;
            txtTempsPeintureProj.TextAlign = HorizontalAlignment.Left;
            txtTempsPeintureProj.BackColor = SystemColors.Window;
            txtTempsPeintureProj.CausesValidation = true;
            txtTempsPeintureProj.Enabled = true;
            txtTempsPeintureProj.ForeColor = SystemColors.WindowText;
            txtTempsPeintureProj.HideSelection = true;
            txtTempsPeintureProj.ReadOnly = false;
            txtTempsPeintureProj.MaxLength = 0;
            txtTempsPeintureProj.Cursor = Cursors.IBeam;
            txtTempsPeintureProj.Multiline = false;
            txtTempsPeintureProj.RightToLeft = RightToLeft.No;
            txtTempsPeintureProj.ScrollBars = ScrollBars.None;
            txtTempsPeintureProj.TabStop = true;
            txtTempsPeintureProj.Visible = true;
            txtTempsPeintureProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsPeintureProj.Name = "txtTempsPeintureProj";
            txtTempsTestProj.AutoSize = false;
            txtTempsTestProj.Size = new Size(49, 19);
            txtTempsTestProj.Location = new Point(256, 200);
            txtTempsTestProj.TabIndex = 16;
            txtTempsTestProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsTestProj.AcceptsReturn = true;
            txtTempsTestProj.TextAlign = HorizontalAlignment.Left;
            txtTempsTestProj.BackColor = SystemColors.Window;
            txtTempsTestProj.CausesValidation = true;
            txtTempsTestProj.Enabled = true;
            txtTempsTestProj.ForeColor = SystemColors.WindowText;
            txtTempsTestProj.HideSelection = true;
            txtTempsTestProj.ReadOnly = false;
            txtTempsTestProj.MaxLength = 0;
            txtTempsTestProj.Cursor = Cursors.IBeam;
            txtTempsTestProj.Multiline = false;
            txtTempsTestProj.RightToLeft = RightToLeft.No;
            txtTempsTestProj.ScrollBars = ScrollBars.None;
            txtTempsTestProj.TabStop = true;
            txtTempsTestProj.Visible = true;
            txtTempsTestProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsTestProj.Name = "txtTempsTestProj";
            txtTempsDessinProj.AutoSize = false;
            txtTempsDessinProj.Size = new Size(49, 19);
            txtTempsDessinProj.Location = new Point(256, 56);
            txtTempsDessinProj.TabIndex = 10;
            txtTempsDessinProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsDessinProj.AcceptsReturn = true;
            txtTempsDessinProj.TextAlign = HorizontalAlignment.Left;
            txtTempsDessinProj.BackColor = SystemColors.Window;
            txtTempsDessinProj.CausesValidation = true;
            txtTempsDessinProj.Enabled = true;
            txtTempsDessinProj.ForeColor = SystemColors.WindowText;
            txtTempsDessinProj.HideSelection = true;
            txtTempsDessinProj.ReadOnly = false;
            txtTempsDessinProj.MaxLength = 0;
            txtTempsDessinProj.Cursor = Cursors.IBeam;
            txtTempsDessinProj.Multiline = false;
            txtTempsDessinProj.RightToLeft = RightToLeft.No;
            txtTempsDessinProj.ScrollBars = ScrollBars.None;
            txtTempsDessinProj.TabStop = true;
            txtTempsDessinProj.Visible = true;
            txtTempsDessinProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsDessinProj.Name = "txtTempsDessinProj";
            txtTempsFormationProj.AutoSize = false;
            txtTempsFormationProj.Size = new Size(49, 19);
            txtTempsFormationProj.Location = new Point(256, 248);
            txtTempsFormationProj.TabIndex = 18;
            txtTempsFormationProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsFormationProj.AcceptsReturn = true;
            txtTempsFormationProj.TextAlign = HorizontalAlignment.Left;
            txtTempsFormationProj.BackColor = SystemColors.Window;
            txtTempsFormationProj.CausesValidation = true;
            txtTempsFormationProj.Enabled = true;
            txtTempsFormationProj.ForeColor = SystemColors.WindowText;
            txtTempsFormationProj.HideSelection = true;
            txtTempsFormationProj.ReadOnly = false;
            txtTempsFormationProj.MaxLength = 0;
            txtTempsFormationProj.Cursor = Cursors.IBeam;
            txtTempsFormationProj.Multiline = false;
            txtTempsFormationProj.RightToLeft = RightToLeft.No;
            txtTempsFormationProj.ScrollBars = ScrollBars.None;
            txtTempsFormationProj.TabStop = true;
            txtTempsFormationProj.Visible = true;
            txtTempsFormationProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsFormationProj.Name = "txtTempsFormationProj";
            txtTempsInstallationProj.AutoSize = false;
            txtTempsInstallationProj.Size = new Size(49, 19);
            txtTempsInstallationProj.Location = new Point(256, 224);
            txtTempsInstallationProj.TabIndex = 17;
            txtTempsInstallationProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsInstallationProj.AcceptsReturn = true;
            txtTempsInstallationProj.TextAlign = HorizontalAlignment.Left;
            txtTempsInstallationProj.BackColor = SystemColors.Window;
            txtTempsInstallationProj.CausesValidation = true;
            txtTempsInstallationProj.Enabled = true;
            txtTempsInstallationProj.ForeColor = SystemColors.WindowText;
            txtTempsInstallationProj.HideSelection = true;
            txtTempsInstallationProj.ReadOnly = false;
            txtTempsInstallationProj.MaxLength = 0;
            txtTempsInstallationProj.Cursor = Cursors.IBeam;
            txtTempsInstallationProj.Multiline = false;
            txtTempsInstallationProj.RightToLeft = RightToLeft.No;
            txtTempsInstallationProj.ScrollBars = ScrollBars.None;
            txtTempsInstallationProj.TabStop = true;
            txtTempsInstallationProj.Visible = true;
            txtTempsInstallationProj.BorderStyle = BorderStyle.Fixed3D;
            txtTempsInstallationProj.Name = "txtTempsInstallationProj";
            txtTempsInstallationSoum.AutoSize = false;
            txtTempsInstallationSoum.Size = new Size(49, 19);
            txtTempsInstallationSoum.Location = new Point(200, 224);
            txtTempsInstallationSoum.TabIndex = 7;
            txtTempsInstallationSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsInstallationSoum.AcceptsReturn = true;
            txtTempsInstallationSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsInstallationSoum.BackColor = SystemColors.Window;
            txtTempsInstallationSoum.CausesValidation = true;
            txtTempsInstallationSoum.Enabled = true;
            txtTempsInstallationSoum.ForeColor = SystemColors.WindowText;
            txtTempsInstallationSoum.HideSelection = true;
            txtTempsInstallationSoum.ReadOnly = false;
            txtTempsInstallationSoum.MaxLength = 0;
            txtTempsInstallationSoum.Cursor = Cursors.IBeam;
            txtTempsInstallationSoum.Multiline = false;
            txtTempsInstallationSoum.RightToLeft = RightToLeft.No;
            txtTempsInstallationSoum.ScrollBars = ScrollBars.None;
            txtTempsInstallationSoum.TabStop = true;
            txtTempsInstallationSoum.Visible = true;
            txtTempsInstallationSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsInstallationSoum.Name = "txtTempsInstallationSoum";
            txtTempsFormationSoum.AutoSize = false;
            txtTempsFormationSoum.Size = new Size(49, 19);
            txtTempsFormationSoum.Location = new Point(200, 248);
            txtTempsFormationSoum.TabIndex = 8;
            txtTempsFormationSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsFormationSoum.AcceptsReturn = true;
            txtTempsFormationSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsFormationSoum.BackColor = SystemColors.Window;
            txtTempsFormationSoum.CausesValidation = true;
            txtTempsFormationSoum.Enabled = true;
            txtTempsFormationSoum.ForeColor = SystemColors.WindowText;
            txtTempsFormationSoum.HideSelection = true;
            txtTempsFormationSoum.ReadOnly = false;
            txtTempsFormationSoum.MaxLength = 0;
            txtTempsFormationSoum.Cursor = Cursors.IBeam;
            txtTempsFormationSoum.Multiline = false;
            txtTempsFormationSoum.RightToLeft = RightToLeft.No;
            txtTempsFormationSoum.ScrollBars = ScrollBars.None;
            txtTempsFormationSoum.TabStop = true;
            txtTempsFormationSoum.Visible = true;
            txtTempsFormationSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsFormationSoum.Name = "txtTempsFormationSoum";
            txtTempsDessinSoum.AutoSize = false;
            txtTempsDessinSoum.Size = new Size(49, 19);
            txtTempsDessinSoum.Location = new Point(200, 56);
            txtTempsDessinSoum.TabIndex = 0;
            txtTempsDessinSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsDessinSoum.AcceptsReturn = true;
            txtTempsDessinSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsDessinSoum.BackColor = SystemColors.Window;
            txtTempsDessinSoum.CausesValidation = true;
            txtTempsDessinSoum.Enabled = true;
            txtTempsDessinSoum.ForeColor = SystemColors.WindowText;
            txtTempsDessinSoum.HideSelection = true;
            txtTempsDessinSoum.ReadOnly = false;
            txtTempsDessinSoum.MaxLength = 0;
            txtTempsDessinSoum.Cursor = Cursors.IBeam;
            txtTempsDessinSoum.Multiline = false;
            txtTempsDessinSoum.RightToLeft = RightToLeft.No;
            txtTempsDessinSoum.ScrollBars = ScrollBars.None;
            txtTempsDessinSoum.TabStop = true;
            txtTempsDessinSoum.Visible = true;
            txtTempsDessinSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsDessinSoum.Name = "txtTempsDessinSoum";
            txtTempsTestSoum.AutoSize = false;
            txtTempsTestSoum.Size = new Size(49, 19);
            txtTempsTestSoum.Location = new Point(200, 200);
            txtTempsTestSoum.TabIndex = 6;
            txtTempsTestSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsTestSoum.AcceptsReturn = true;
            txtTempsTestSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsTestSoum.BackColor = SystemColors.Window;
            txtTempsTestSoum.CausesValidation = true;
            txtTempsTestSoum.Enabled = true;
            txtTempsTestSoum.ForeColor = SystemColors.WindowText;
            txtTempsTestSoum.HideSelection = true;
            txtTempsTestSoum.ReadOnly = false;
            txtTempsTestSoum.MaxLength = 0;
            txtTempsTestSoum.Cursor = Cursors.IBeam;
            txtTempsTestSoum.Multiline = false;
            txtTempsTestSoum.RightToLeft = RightToLeft.No;
            txtTempsTestSoum.ScrollBars = ScrollBars.None;
            txtTempsTestSoum.TabStop = true;
            txtTempsTestSoum.Visible = true;
            txtTempsTestSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsTestSoum.Name = "txtTempsTestSoum";
            txtTempsPeintureSoum.AutoSize = false;
            txtTempsPeintureSoum.Size = new Size(49, 19);
            txtTempsPeintureSoum.Location = new Point(200, 176);
            txtTempsPeintureSoum.TabIndex = 5;
            txtTempsPeintureSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsPeintureSoum.AcceptsReturn = true;
            txtTempsPeintureSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsPeintureSoum.BackColor = SystemColors.Window;
            txtTempsPeintureSoum.CausesValidation = true;
            txtTempsPeintureSoum.Enabled = true;
            txtTempsPeintureSoum.ForeColor = SystemColors.WindowText;
            txtTempsPeintureSoum.HideSelection = true;
            txtTempsPeintureSoum.ReadOnly = false;
            txtTempsPeintureSoum.MaxLength = 0;
            txtTempsPeintureSoum.Cursor = Cursors.IBeam;
            txtTempsPeintureSoum.Multiline = false;
            txtTempsPeintureSoum.RightToLeft = RightToLeft.No;
            txtTempsPeintureSoum.ScrollBars = ScrollBars.None;
            txtTempsPeintureSoum.TabStop = true;
            txtTempsPeintureSoum.Visible = true;
            txtTempsPeintureSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsPeintureSoum.Name = "txtTempsPeintureSoum";
            txtTempsAssemblageSoum.AutoSize = false;
            txtTempsAssemblageSoum.Size = new Size(49, 19);
            txtTempsAssemblageSoum.Location = new Point(200, 152);
            txtTempsAssemblageSoum.TabIndex = 4;
            txtTempsAssemblageSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsAssemblageSoum.AcceptsReturn = true;
            txtTempsAssemblageSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsAssemblageSoum.BackColor = SystemColors.Window;
            txtTempsAssemblageSoum.CausesValidation = true;
            txtTempsAssemblageSoum.Enabled = true;
            txtTempsAssemblageSoum.ForeColor = SystemColors.WindowText;
            txtTempsAssemblageSoum.HideSelection = true;
            txtTempsAssemblageSoum.ReadOnly = false;
            txtTempsAssemblageSoum.MaxLength = 0;
            txtTempsAssemblageSoum.Cursor = Cursors.IBeam;
            txtTempsAssemblageSoum.Multiline = false;
            txtTempsAssemblageSoum.RightToLeft = RightToLeft.No;
            txtTempsAssemblageSoum.ScrollBars = ScrollBars.None;
            txtTempsAssemblageSoum.TabStop = true;
            txtTempsAssemblageSoum.Visible = true;
            txtTempsAssemblageSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsAssemblageSoum.Name = "txtTempsAssemblageSoum";
            txtTempsSoudureSoum.AutoSize = false;
            txtTempsSoudureSoum.Size = new Size(49, 19);
            txtTempsSoudureSoum.Location = new Point(200, 128);
            txtTempsSoudureSoum.TabIndex = 3;
            txtTempsSoudureSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsSoudureSoum.AcceptsReturn = true;
            txtTempsSoudureSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsSoudureSoum.BackColor = SystemColors.Window;
            txtTempsSoudureSoum.CausesValidation = true;
            txtTempsSoudureSoum.Enabled = true;
            txtTempsSoudureSoum.ForeColor = SystemColors.WindowText;
            txtTempsSoudureSoum.HideSelection = true;
            txtTempsSoudureSoum.ReadOnly = false;
            txtTempsSoudureSoum.MaxLength = 0;
            txtTempsSoudureSoum.Cursor = Cursors.IBeam;
            txtTempsSoudureSoum.Multiline = false;
            txtTempsSoudureSoum.RightToLeft = RightToLeft.No;
            txtTempsSoudureSoum.ScrollBars = ScrollBars.None;
            txtTempsSoudureSoum.TabStop = true;
            txtTempsSoudureSoum.Visible = true;
            txtTempsSoudureSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsSoudureSoum.Name = "txtTempsSoudureSoum";
            txtTempsCoupeSoum.AutoSize = false;
            txtTempsCoupeSoum.Size = new Size(49, 19);
            txtTempsCoupeSoum.Location = new Point(200, 80);
            txtTempsCoupeSoum.TabIndex = 1;
            txtTempsCoupeSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsCoupeSoum.AcceptsReturn = true;
            txtTempsCoupeSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsCoupeSoum.BackColor = SystemColors.Window;
            txtTempsCoupeSoum.CausesValidation = true;
            txtTempsCoupeSoum.Enabled = true;
            txtTempsCoupeSoum.ForeColor = SystemColors.WindowText;
            txtTempsCoupeSoum.HideSelection = true;
            txtTempsCoupeSoum.ReadOnly = false;
            txtTempsCoupeSoum.MaxLength = 0;
            txtTempsCoupeSoum.Cursor = Cursors.IBeam;
            txtTempsCoupeSoum.Multiline = false;
            txtTempsCoupeSoum.RightToLeft = RightToLeft.No;
            txtTempsCoupeSoum.ScrollBars = ScrollBars.None;
            txtTempsCoupeSoum.TabStop = true;
            txtTempsCoupeSoum.Visible = true;
            txtTempsCoupeSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsCoupeSoum.Name = "txtTempsCoupeSoum";
            txtTempsMachinageSoum.AutoSize = false;
            txtTempsMachinageSoum.Size = new Size(49, 19);
            txtTempsMachinageSoum.Location = new Point(200, 104);
            txtTempsMachinageSoum.TabIndex = 2;
            txtTempsMachinageSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsMachinageSoum.AcceptsReturn = true;
            txtTempsMachinageSoum.TextAlign = HorizontalAlignment.Left;
            txtTempsMachinageSoum.BackColor = SystemColors.Window;
            txtTempsMachinageSoum.CausesValidation = true;
            txtTempsMachinageSoum.Enabled = true;
            txtTempsMachinageSoum.ForeColor = SystemColors.WindowText;
            txtTempsMachinageSoum.HideSelection = true;
            txtTempsMachinageSoum.ReadOnly = false;
            txtTempsMachinageSoum.MaxLength = 0;
            txtTempsMachinageSoum.Cursor = Cursors.IBeam;
            txtTempsMachinageSoum.Multiline = false;
            txtTempsMachinageSoum.RightToLeft = RightToLeft.No;
            txtTempsMachinageSoum.ScrollBars = ScrollBars.None;
            txtTempsMachinageSoum.TabStop = true;
            txtTempsMachinageSoum.Visible = true;
            txtTempsMachinageSoum.BorderStyle = BorderStyle.Fixed3D;
            txtTempsMachinageSoum.Name = "txtTempsMachinageSoum";
            lblPrixPrototype.TextAlign = ContentAlignment.TopRight;
            lblPrixPrototype.BackColor = Color.White;
            lblPrixPrototype.Text = "0";
            lblPrixPrototype.Size = new Size(49, 19);
            lblPrixPrototype.Location = new Point(456, 320);
            lblPrixPrototype.TabIndex = 146;
            lblPrixPrototype.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixPrototype.Enabled = true;
            lblPrixPrototype.ForeColor = SystemColors.ControlText;
            lblPrixPrototype.Cursor = Cursors.Default;
            lblPrixPrototype.RightToLeft = RightToLeft.No;
            lblPrixPrototype.UseMnemonic = true;
            lblPrixPrototype.Visible = true;
            lblPrixPrototype.AutoSize = false;
            lblPrixPrototype.BorderStyle = BorderStyle.Fixed3D;
            lblPrixPrototype.Name = "lblPrixPrototype";
            lblTempsPrototypeReel.BackColor = Color.White;
            lblTempsPrototypeReel.Size = new Size(49, 19);
            lblTempsPrototypeReel.Location = new Point(368, 320);
            lblTempsPrototypeReel.TabIndex = 145;
            lblTempsPrototypeReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsPrototypeReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsPrototypeReel.Enabled = true;
            lblTempsPrototypeReel.ForeColor = SystemColors.ControlText;
            lblTempsPrototypeReel.Cursor = Cursors.Default;
            lblTempsPrototypeReel.RightToLeft = RightToLeft.No;
            lblTempsPrototypeReel.UseMnemonic = true;
            lblTempsPrototypeReel.Visible = true;
            lblTempsPrototypeReel.AutoSize = false;
            lblTempsPrototypeReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsPrototypeReel.Name = "lblTempsPrototypeReel";
            Label60.Text = "Prototypage-Développement :";
            Label60.ForeColor = Color.White;
            Label60.Size = new Size(137, 17);
            Label60.Location = new Point(8, 320);
            Label60.TabIndex = 144;
            Label60.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label60.TextAlign = ContentAlignment.TopLeft;
            Label60.BackColor = Color.Transparent;
            Label60.Enabled = true;
            Label60.Cursor = Cursors.Default;
            Label60.RightToLeft = RightToLeft.No;
            Label60.UseMnemonic = true;
            Label60.Visible = true;
            Label60.AutoSize = false;
            Label60.BorderStyle = BorderStyle.None;
            Label60.Name = "Label60";
            Label51.Text = "Hrs";
            Label51.ForeColor = Color.White;
            Label51.Size = new Size(17, 17);
            Label51.Location = new Point(424, 320);
            Label51.TabIndex = 143;
            Label51.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label51.TextAlign = ContentAlignment.TopLeft;
            Label51.BackColor = Color.Transparent;
            Label51.Enabled = true;
            Label51.Cursor = Cursors.Default;
            Label51.RightToLeft = RightToLeft.No;
            Label51.UseMnemonic = true;
            Label51.Visible = true;
            Label51.AutoSize = false;
            Label51.BorderStyle = BorderStyle.None;
            Label51.Name = "Label51";
            Label39.Text = "$";
            Label39.ForeColor = Color.White;
            Label39.Size = new Size(9, 17);
            Label39.Location = new Point(512, 320);
            Label39.TabIndex = 142;
            Label39.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label39.TextAlign = ContentAlignment.TopLeft;
            Label39.BackColor = Color.Transparent;
            Label39.Enabled = true;
            Label39.Cursor = Cursors.Default;
            Label39.RightToLeft = RightToLeft.No;
            Label39.UseMnemonic = true;
            Label39.Visible = true;
            Label39.AutoSize = false;
            Label39.BorderStyle = BorderStyle.None;
            Label39.Name = "Label39";
            Label59.Text = "$";
            Label59.ForeColor = Color.White;
            Label59.Size = new Size(9, 17);
            Label59.Location = new Point(512, 296);
            Label59.TabIndex = 138;
            Label59.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label59.TextAlign = ContentAlignment.TopLeft;
            Label59.BackColor = Color.Transparent;
            Label59.Enabled = true;
            Label59.Cursor = Cursors.Default;
            Label59.RightToLeft = RightToLeft.No;
            Label59.UseMnemonic = true;
            Label59.Visible = true;
            Label59.AutoSize = false;
            Label59.BorderStyle = BorderStyle.None;
            Label59.Name = "Label59";
            Label55.Text = "Hrs";
            Label55.ForeColor = Color.White;
            Label55.Size = new Size(17, 17);
            Label55.Location = new Point(424, 296);
            Label55.TabIndex = 137;
            Label55.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label55.TextAlign = ContentAlignment.TopLeft;
            Label55.BackColor = Color.Transparent;
            Label55.Enabled = true;
            Label55.Cursor = Cursors.Default;
            Label55.RightToLeft = RightToLeft.No;
            Label55.UseMnemonic = true;
            Label55.Visible = true;
            Label55.AutoSize = false;
            Label55.BorderStyle = BorderStyle.None;
            Label55.Name = "Label55";
            Label53.Text = "Expédition :";
            Label53.ForeColor = Color.White;
            Label53.Size = new Size(137, 17);
            Label53.Location = new Point(8, 296);
            Label53.TabIndex = 136;
            Label53.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label53.TextAlign = ContentAlignment.TopLeft;
            Label53.BackColor = Color.Transparent;
            Label53.Enabled = true;
            Label53.Cursor = Cursors.Default;
            Label53.RightToLeft = RightToLeft.No;
            Label53.UseMnemonic = true;
            Label53.Visible = true;
            Label53.AutoSize = false;
            Label53.BorderStyle = BorderStyle.None;
            Label53.Name = "Label53";
            lblTempsShippingReel.BackColor = Color.White;
            lblTempsShippingReel.Size = new Size(49, 19);
            lblTempsShippingReel.Location = new Point(368, 296);
            lblTempsShippingReel.TabIndex = 135;
            lblTempsShippingReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsShippingReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsShippingReel.Enabled = true;
            lblTempsShippingReel.ForeColor = SystemColors.ControlText;
            lblTempsShippingReel.Cursor = Cursors.Default;
            lblTempsShippingReel.RightToLeft = RightToLeft.No;
            lblTempsShippingReel.UseMnemonic = true;
            lblTempsShippingReel.Visible = true;
            lblTempsShippingReel.AutoSize = false;
            lblTempsShippingReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsShippingReel.Name = "lblTempsShippingReel";
            lblPrixShipping.TextAlign = ContentAlignment.TopRight;
            lblPrixShipping.BackColor = Color.White;
            lblPrixShipping.Text = "0";
            lblPrixShipping.Size = new Size(49, 19);
            lblPrixShipping.Location = new Point(456, 296);
            lblPrixShipping.TabIndex = 134;
            lblPrixShipping.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixShipping.Enabled = true;
            lblPrixShipping.ForeColor = SystemColors.ControlText;
            lblPrixShipping.Cursor = Cursors.Default;
            lblPrixShipping.RightToLeft = RightToLeft.No;
            lblPrixShipping.UseMnemonic = true;
            lblPrixShipping.Visible = true;
            lblPrixShipping.AutoSize = false;
            lblPrixShipping.BorderStyle = BorderStyle.Fixed3D;
            lblPrixShipping.Name = "lblPrixShipping";
            lblPrixInstallation.TextAlign = ContentAlignment.TopRight;
            lblPrixInstallation.BackColor = Color.White;
            lblPrixInstallation.Text = "0";
            lblPrixInstallation.Size = new Size(49, 19);
            lblPrixInstallation.Location = new Point(456, 224);
            lblPrixInstallation.TabIndex = 121;
            lblPrixInstallation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixInstallation.Enabled = true;
            lblPrixInstallation.ForeColor = SystemColors.ControlText;
            lblPrixInstallation.Cursor = Cursors.Default;
            lblPrixInstallation.RightToLeft = RightToLeft.No;
            lblPrixInstallation.UseMnemonic = true;
            lblPrixInstallation.Visible = true;
            lblPrixInstallation.AutoSize = false;
            lblPrixInstallation.BorderStyle = BorderStyle.Fixed3D;
            lblPrixInstallation.Name = "lblPrixInstallation";
            lblPrixFormation.TextAlign = ContentAlignment.TopRight;
            lblPrixFormation.BackColor = Color.White;
            lblPrixFormation.Text = "0";
            lblPrixFormation.Size = new Size(49, 19);
            lblPrixFormation.Location = new Point(456, 248);
            lblPrixFormation.TabIndex = 120;
            lblPrixFormation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixFormation.Enabled = true;
            lblPrixFormation.ForeColor = SystemColors.ControlText;
            lblPrixFormation.Cursor = Cursors.Default;
            lblPrixFormation.RightToLeft = RightToLeft.No;
            lblPrixFormation.UseMnemonic = true;
            lblPrixFormation.Visible = true;
            lblPrixFormation.AutoSize = false;
            lblPrixFormation.BorderStyle = BorderStyle.Fixed3D;
            lblPrixFormation.Name = "lblPrixFormation";
            lblPrixDessin.TextAlign = ContentAlignment.TopRight;
            lblPrixDessin.BackColor = Color.White;
            lblPrixDessin.Text = "0";
            lblPrixDessin.Size = new Size(49, 19);
            lblPrixDessin.Location = new Point(456, 56);
            lblPrixDessin.TabIndex = 119;
            lblPrixDessin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixDessin.Enabled = true;
            lblPrixDessin.ForeColor = SystemColors.ControlText;
            lblPrixDessin.Cursor = Cursors.Default;
            lblPrixDessin.RightToLeft = RightToLeft.No;
            lblPrixDessin.UseMnemonic = true;
            lblPrixDessin.Visible = true;
            lblPrixDessin.AutoSize = false;
            lblPrixDessin.BorderStyle = BorderStyle.Fixed3D;
            lblPrixDessin.Name = "lblPrixDessin";
            lblPrixGestion.TextAlign = ContentAlignment.TopRight;
            lblPrixGestion.BackColor = Color.White;
            lblPrixGestion.Text = "0";
            lblPrixGestion.Size = new Size(49, 19);
            lblPrixGestion.Location = new Point(456, 272);
            lblPrixGestion.TabIndex = 118;
            lblPrixGestion.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixGestion.Enabled = true;
            lblPrixGestion.ForeColor = SystemColors.ControlText;
            lblPrixGestion.Cursor = Cursors.Default;
            lblPrixGestion.RightToLeft = RightToLeft.No;
            lblPrixGestion.UseMnemonic = true;
            lblPrixGestion.Visible = true;
            lblPrixGestion.AutoSize = false;
            lblPrixGestion.BorderStyle = BorderStyle.Fixed3D;
            lblPrixGestion.Name = "lblPrixGestion";
            lblPrixTest.TextAlign = ContentAlignment.TopRight;
            lblPrixTest.BackColor = Color.White;
            lblPrixTest.Text = "0";
            lblPrixTest.Size = new Size(49, 19);
            lblPrixTest.Location = new Point(456, 200);
            lblPrixTest.TabIndex = 117;
            lblPrixTest.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixTest.Enabled = true;
            lblPrixTest.ForeColor = SystemColors.ControlText;
            lblPrixTest.Cursor = Cursors.Default;
            lblPrixTest.RightToLeft = RightToLeft.No;
            lblPrixTest.UseMnemonic = true;
            lblPrixTest.Visible = true;
            lblPrixTest.AutoSize = false;
            lblPrixTest.BorderStyle = BorderStyle.Fixed3D;
            lblPrixTest.Name = "lblPrixTest";
            lblPrixPeinture.TextAlign = ContentAlignment.TopRight;
            lblPrixPeinture.BackColor = Color.White;
            lblPrixPeinture.Text = "0";
            lblPrixPeinture.Size = new Size(49, 19);
            lblPrixPeinture.Location = new Point(456, 176);
            lblPrixPeinture.TabIndex = 116;
            lblPrixPeinture.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixPeinture.Enabled = true;
            lblPrixPeinture.ForeColor = SystemColors.ControlText;
            lblPrixPeinture.Cursor = Cursors.Default;
            lblPrixPeinture.RightToLeft = RightToLeft.No;
            lblPrixPeinture.UseMnemonic = true;
            lblPrixPeinture.Visible = true;
            lblPrixPeinture.AutoSize = false;
            lblPrixPeinture.BorderStyle = BorderStyle.Fixed3D;
            lblPrixPeinture.Name = "lblPrixPeinture";
            lblPrixAssemblage.TextAlign = ContentAlignment.TopRight;
            lblPrixAssemblage.BackColor = Color.White;
            lblPrixAssemblage.Text = "0";
            lblPrixAssemblage.Size = new Size(49, 19);
            lblPrixAssemblage.Location = new Point(456, 152);
            lblPrixAssemblage.TabIndex = 115;
            lblPrixAssemblage.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixAssemblage.Enabled = true;
            lblPrixAssemblage.ForeColor = SystemColors.ControlText;
            lblPrixAssemblage.Cursor = Cursors.Default;
            lblPrixAssemblage.RightToLeft = RightToLeft.No;
            lblPrixAssemblage.UseMnemonic = true;
            lblPrixAssemblage.Visible = true;
            lblPrixAssemblage.AutoSize = false;
            lblPrixAssemblage.BorderStyle = BorderStyle.Fixed3D;
            lblPrixAssemblage.Name = "lblPrixAssemblage";
            lblPrixSoudure.TextAlign = ContentAlignment.TopRight;
            lblPrixSoudure.BackColor = Color.White;
            lblPrixSoudure.Text = "0";
            lblPrixSoudure.Size = new Size(49, 19);
            lblPrixSoudure.Location = new Point(456, 128);
            lblPrixSoudure.TabIndex = 114;
            lblPrixSoudure.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixSoudure.Enabled = true;
            lblPrixSoudure.ForeColor = SystemColors.ControlText;
            lblPrixSoudure.Cursor = Cursors.Default;
            lblPrixSoudure.RightToLeft = RightToLeft.No;
            lblPrixSoudure.UseMnemonic = true;
            lblPrixSoudure.Visible = true;
            lblPrixSoudure.AutoSize = false;
            lblPrixSoudure.BorderStyle = BorderStyle.Fixed3D;
            lblPrixSoudure.Name = "lblPrixSoudure";
            lblPrixCoupe.TextAlign = ContentAlignment.TopRight;
            lblPrixCoupe.BackColor = Color.White;
            lblPrixCoupe.Text = "0";
            lblPrixCoupe.Size = new Size(49, 19);
            lblPrixCoupe.Location = new Point(456, 80);
            lblPrixCoupe.TabIndex = 113;
            lblPrixCoupe.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixCoupe.Enabled = true;
            lblPrixCoupe.ForeColor = SystemColors.ControlText;
            lblPrixCoupe.Cursor = Cursors.Default;
            lblPrixCoupe.RightToLeft = RightToLeft.No;
            lblPrixCoupe.UseMnemonic = true;
            lblPrixCoupe.Visible = true;
            lblPrixCoupe.AutoSize = false;
            lblPrixCoupe.BorderStyle = BorderStyle.Fixed3D;
            lblPrixCoupe.Name = "lblPrixCoupe";
            lblPrixMachinage.TextAlign = ContentAlignment.TopRight;
            lblPrixMachinage.BackColor = Color.White;
            lblPrixMachinage.Text = "0";
            lblPrixMachinage.Size = new Size(49, 19);
            lblPrixMachinage.Location = new Point(456, 104);
            lblPrixMachinage.TabIndex = 112;
            lblPrixMachinage.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixMachinage.Enabled = true;
            lblPrixMachinage.ForeColor = SystemColors.ControlText;
            lblPrixMachinage.Cursor = Cursors.Default;
            lblPrixMachinage.RightToLeft = RightToLeft.No;
            lblPrixMachinage.UseMnemonic = true;
            lblPrixMachinage.Visible = true;
            lblPrixMachinage.AutoSize = false;
            lblPrixMachinage.BorderStyle = BorderStyle.Fixed3D;
            lblPrixMachinage.Name = "lblPrixMachinage";
            lblTempsGestionReel.BackColor = Color.White;
            lblTempsGestionReel.Size = new Size(49, 19);
            lblTempsGestionReel.Location = new Point(368, 272);
            lblTempsGestionReel.TabIndex = 111;
            lblTempsGestionReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsGestionReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsGestionReel.Enabled = true;
            lblTempsGestionReel.ForeColor = SystemColors.ControlText;
            lblTempsGestionReel.Cursor = Cursors.Default;
            lblTempsGestionReel.RightToLeft = RightToLeft.No;
            lblTempsGestionReel.UseMnemonic = true;
            lblTempsGestionReel.Visible = true;
            lblTempsGestionReel.AutoSize = false;
            lblTempsGestionReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsGestionReel.Name = "lblTempsGestionReel";
            Label67.Text = "Gestion de projets :";
            Label67.ForeColor = Color.White;
            Label67.Size = new Size(137, 17);
            Label67.Location = new Point(8, 272);
            Label67.TabIndex = 110;
            Label67.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label67.TextAlign = ContentAlignment.TopLeft;
            Label67.BackColor = Color.Transparent;
            Label67.Enabled = true;
            Label67.Cursor = Cursors.Default;
            Label67.RightToLeft = RightToLeft.No;
            Label67.UseMnemonic = true;
            Label67.Visible = true;
            Label67.AutoSize = false;
            Label67.BorderStyle = BorderStyle.None;
            Label67.Name = "Label67";
            Label66.Text = "Hrs";
            Label66.ForeColor = Color.White;
            Label66.Size = new Size(17, 17);
            Label66.Location = new Point(424, 272);
            Label66.TabIndex = 109;
            Label66.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label66.TextAlign = ContentAlignment.TopLeft;
            Label66.BackColor = Color.Transparent;
            Label66.Enabled = true;
            Label66.Cursor = Cursors.Default;
            Label66.RightToLeft = RightToLeft.No;
            Label66.UseMnemonic = true;
            Label66.Visible = true;
            Label66.AutoSize = false;
            Label66.BorderStyle = BorderStyle.None;
            Label66.Name = "Label66";
            Label65.Text = "$";
            Label65.ForeColor = Color.White;
            Label65.Size = new Size(9, 17);
            Label65.Location = new Point(512, 272);
            Label65.TabIndex = 108;
            Label65.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label65.TextAlign = ContentAlignment.TopLeft;
            Label65.BackColor = Color.Transparent;
            Label65.Enabled = true;
            Label65.Cursor = Cursors.Default;
            Label65.RightToLeft = RightToLeft.No;
            Label65.UseMnemonic = true;
            Label65.Visible = true;
            Label65.AutoSize = false;
            Label65.BorderStyle = BorderStyle.None;
            Label65.Name = "Label65";
            lblTempsInstallationReel.BackColor = Color.White;
            lblTempsInstallationReel.Size = new Size(49, 19);
            lblTempsInstallationReel.Location = new Point(368, 224);
            lblTempsInstallationReel.TabIndex = 107;
            lblTempsInstallationReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsInstallationReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsInstallationReel.Enabled = true;
            lblTempsInstallationReel.ForeColor = SystemColors.ControlText;
            lblTempsInstallationReel.Cursor = Cursors.Default;
            lblTempsInstallationReel.RightToLeft = RightToLeft.No;
            lblTempsInstallationReel.UseMnemonic = true;
            lblTempsInstallationReel.Visible = true;
            lblTempsInstallationReel.AutoSize = false;
            lblTempsInstallationReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsInstallationReel.Name = "lblTempsInstallationReel";
            lblTempsFormationReel.BackColor = Color.White;
            lblTempsFormationReel.Size = new Size(49, 19);
            lblTempsFormationReel.Location = new Point(368, 248);
            lblTempsFormationReel.TabIndex = 106;
            lblTempsFormationReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsFormationReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsFormationReel.Enabled = true;
            lblTempsFormationReel.ForeColor = SystemColors.ControlText;
            lblTempsFormationReel.Cursor = Cursors.Default;
            lblTempsFormationReel.RightToLeft = RightToLeft.No;
            lblTempsFormationReel.UseMnemonic = true;
            lblTempsFormationReel.Visible = true;
            lblTempsFormationReel.AutoSize = false;
            lblTempsFormationReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsFormationReel.Name = "lblTempsFormationReel";
            lblTempsDessinReel.BackColor = Color.White;
            lblTempsDessinReel.Size = new Size(49, 19);
            lblTempsDessinReel.Location = new Point(368, 56);
            lblTempsDessinReel.TabIndex = 105;
            lblTempsDessinReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsDessinReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsDessinReel.Enabled = true;
            lblTempsDessinReel.ForeColor = SystemColors.ControlText;
            lblTempsDessinReel.Cursor = Cursors.Default;
            lblTempsDessinReel.RightToLeft = RightToLeft.No;
            lblTempsDessinReel.UseMnemonic = true;
            lblTempsDessinReel.Visible = true;
            lblTempsDessinReel.AutoSize = false;
            lblTempsDessinReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsDessinReel.Name = "lblTempsDessinReel";
            lblTempsTestReel.BackColor = Color.White;
            lblTempsTestReel.Size = new Size(49, 19);
            lblTempsTestReel.Location = new Point(368, 200);
            lblTempsTestReel.TabIndex = 104;
            lblTempsTestReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsTestReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsTestReel.Enabled = true;
            lblTempsTestReel.ForeColor = SystemColors.ControlText;
            lblTempsTestReel.Cursor = Cursors.Default;
            lblTempsTestReel.RightToLeft = RightToLeft.No;
            lblTempsTestReel.UseMnemonic = true;
            lblTempsTestReel.Visible = true;
            lblTempsTestReel.AutoSize = false;
            lblTempsTestReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsTestReel.Name = "lblTempsTestReel";
            lblTempsPeintureReel.BackColor = Color.White;
            lblTempsPeintureReel.Size = new Size(49, 19);
            lblTempsPeintureReel.Location = new Point(368, 176);
            lblTempsPeintureReel.TabIndex = 103;
            lblTempsPeintureReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsPeintureReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsPeintureReel.Enabled = true;
            lblTempsPeintureReel.ForeColor = SystemColors.ControlText;
            lblTempsPeintureReel.Cursor = Cursors.Default;
            lblTempsPeintureReel.RightToLeft = RightToLeft.No;
            lblTempsPeintureReel.UseMnemonic = true;
            lblTempsPeintureReel.Visible = true;
            lblTempsPeintureReel.AutoSize = false;
            lblTempsPeintureReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsPeintureReel.Name = "lblTempsPeintureReel";
            lblTempsAssemblageReel.BackColor = Color.White;
            lblTempsAssemblageReel.Size = new Size(49, 19);
            lblTempsAssemblageReel.Location = new Point(368, 152);
            lblTempsAssemblageReel.TabIndex = 102;
            lblTempsAssemblageReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsAssemblageReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsAssemblageReel.Enabled = true;
            lblTempsAssemblageReel.ForeColor = SystemColors.ControlText;
            lblTempsAssemblageReel.Cursor = Cursors.Default;
            lblTempsAssemblageReel.RightToLeft = RightToLeft.No;
            lblTempsAssemblageReel.UseMnemonic = true;
            lblTempsAssemblageReel.Visible = true;
            lblTempsAssemblageReel.AutoSize = false;
            lblTempsAssemblageReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsAssemblageReel.Name = "lblTempsAssemblageReel";
            lblTempsSoudureReel.BackColor = Color.White;
            lblTempsSoudureReel.Size = new Size(49, 19);
            lblTempsSoudureReel.Location = new Point(368, 128);
            lblTempsSoudureReel.TabIndex = 101;
            lblTempsSoudureReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsSoudureReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsSoudureReel.Enabled = true;
            lblTempsSoudureReel.ForeColor = SystemColors.ControlText;
            lblTempsSoudureReel.Cursor = Cursors.Default;
            lblTempsSoudureReel.RightToLeft = RightToLeft.No;
            lblTempsSoudureReel.UseMnemonic = true;
            lblTempsSoudureReel.Visible = true;
            lblTempsSoudureReel.AutoSize = false;
            lblTempsSoudureReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsSoudureReel.Name = "lblTempsSoudureReel";
            lblTempsCoupeReel.BackColor = Color.White;
            lblTempsCoupeReel.Size = new Size(49, 19);
            lblTempsCoupeReel.Location = new Point(368, 80);
            lblTempsCoupeReel.TabIndex = 100;
            lblTempsCoupeReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsCoupeReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsCoupeReel.Enabled = true;
            lblTempsCoupeReel.ForeColor = SystemColors.ControlText;
            lblTempsCoupeReel.Cursor = Cursors.Default;
            lblTempsCoupeReel.RightToLeft = RightToLeft.No;
            lblTempsCoupeReel.UseMnemonic = true;
            lblTempsCoupeReel.Visible = true;
            lblTempsCoupeReel.AutoSize = false;
            lblTempsCoupeReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsCoupeReel.Name = "lblTempsCoupeReel";
            lblTempsMachinageReel.BackColor = Color.White;
            lblTempsMachinageReel.Size = new Size(49, 19);
            lblTempsMachinageReel.Location = new Point(368, 104);
            lblTempsMachinageReel.TabIndex = 99;
            lblTempsMachinageReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempsMachinageReel.TextAlign = ContentAlignment.TopLeft;
            lblTempsMachinageReel.Enabled = true;
            lblTempsMachinageReel.ForeColor = SystemColors.ControlText;
            lblTempsMachinageReel.Cursor = Cursors.Default;
            lblTempsMachinageReel.RightToLeft = RightToLeft.No;
            lblTempsMachinageReel.UseMnemonic = true;
            lblTempsMachinageReel.Visible = true;
            lblTempsMachinageReel.AutoSize = false;
            lblTempsMachinageReel.BorderStyle = BorderStyle.Fixed3D;
            lblTempsMachinageReel.Name = "lblTempsMachinageReel";
            Label58.TextAlign = ContentAlignment.TopCenter;
            Label58.Text = "Réel";
            Label58.Font = new Font("Arial", 8.25f, FontStyle.Underline | FontStyle.Regular, GraphicsUnit.Point, 0);
            Label58.ForeColor = Color.White;
            Label58.Size = new Size(65, 17);
            Label58.Location = new Point(360, 32);
            Label58.TabIndex = 98;
            Label58.BackColor = Color.Transparent;
            Label58.Enabled = true;
            Label58.Cursor = Cursors.Default;
            Label58.RightToLeft = RightToLeft.No;
            Label58.UseMnemonic = true;
            Label58.Visible = true;
            Label58.AutoSize = false;
            Label58.BorderStyle = BorderStyle.None;
            Label58.Name = "Label58";
            Label57.TextAlign = ContentAlignment.TopCenter;
            Label57.Text = "Conception";
            Label57.Font = new Font("Arial", 8.25f, FontStyle.Underline | FontStyle.Regular, GraphicsUnit.Point, 0);
            Label57.ForeColor = Color.White;
            Label57.Size = new Size(81, 17);
            Label57.Location = new Point(296, 32);
            Label57.TabIndex = 97;
            Label57.BackColor = Color.Transparent;
            Label57.Enabled = true;
            Label57.Cursor = Cursors.Default;
            Label57.RightToLeft = RightToLeft.No;
            Label57.UseMnemonic = true;
            Label57.Visible = true;
            Label57.AutoSize = false;
            Label57.BorderStyle = BorderStyle.None;
            Label57.Name = "Label57";
            Label56.TextAlign = ContentAlignment.TopCenter;
            Label56.Text = "Projet";
            Label56.Font = new Font("Arial", 8.25f, FontStyle.Underline | FontStyle.Regular, GraphicsUnit.Point, 0);
            Label56.ForeColor = Color.White;
            Label56.Size = new Size(65, 17);
            Label56.Location = new Point(248, 32);
            Label56.TabIndex = 96;
            Label56.BackColor = Color.Transparent;
            Label56.Enabled = true;
            Label56.Cursor = Cursors.Default;
            Label56.RightToLeft = RightToLeft.No;
            Label56.UseMnemonic = true;
            Label56.Visible = true;
            Label56.AutoSize = false;
            Label56.BorderStyle = BorderStyle.None;
            Label56.Name = "Label56";
            Label54.TextAlign = ContentAlignment.TopCenter;
            Label54.Text = "Soumission";
            Label54.Font = new Font("Arial", 8.25f, FontStyle.Underline | FontStyle.Regular, GraphicsUnit.Point, 0);
            Label54.ForeColor = Color.White;
            Label54.Size = new Size(81, 17);
            Label54.Location = new Point(184, 32);
            Label54.TabIndex = 95;
            Label54.BackColor = Color.Transparent;
            Label54.Enabled = true;
            Label54.Cursor = Cursors.Default;
            Label54.RightToLeft = RightToLeft.No;
            Label54.UseMnemonic = true;
            Label54.Visible = true;
            Label54.AutoSize = false;
            Label54.BorderStyle = BorderStyle.None;
            Label54.Name = "Label54";
            Label49.Text = "Installation :";
            Label49.ForeColor = Color.White;
            Label49.Size = new Size(137, 17);
            Label49.Location = new Point(8, 224);
            Label49.TabIndex = 68;
            Label49.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label49.TextAlign = ContentAlignment.TopLeft;
            Label49.BackColor = Color.Transparent;
            Label49.Enabled = true;
            Label49.Cursor = Cursors.Default;
            Label49.RightToLeft = RightToLeft.No;
            Label49.UseMnemonic = true;
            Label49.Visible = true;
            Label49.AutoSize = false;
            Label49.BorderStyle = BorderStyle.None;
            Label49.Name = "Label49";
            Label47.Text = "Hrs";
            Label47.ForeColor = Color.White;
            Label47.Size = new Size(17, 17);
            Label47.Location = new Point(424, 224);
            Label47.TabIndex = 69;
            Label47.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label47.TextAlign = ContentAlignment.TopLeft;
            Label47.BackColor = Color.Transparent;
            Label47.Enabled = true;
            Label47.Cursor = Cursors.Default;
            Label47.RightToLeft = RightToLeft.No;
            Label47.UseMnemonic = true;
            Label47.Visible = true;
            Label47.AutoSize = false;
            Label47.BorderStyle = BorderStyle.None;
            Label47.Name = "Label47";
            Label43.Text = "$";
            Label43.ForeColor = Color.White;
            Label43.Size = new Size(9, 17);
            Label43.Location = new Point(512, 224);
            Label43.TabIndex = 70;
            Label43.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label43.TextAlign = ContentAlignment.TopLeft;
            Label43.BackColor = Color.Transparent;
            Label43.Enabled = true;
            Label43.Cursor = Cursors.Default;
            Label43.RightToLeft = RightToLeft.No;
            Label43.UseMnemonic = true;
            Label43.Visible = true;
            Label43.AutoSize = false;
            Label43.BorderStyle = BorderStyle.None;
            Label43.Name = "Label43";
            Label41.Text = "Formation du personnel :";
            Label41.ForeColor = Color.White;
            Label41.Size = new Size(137, 17);
            Label41.Location = new Point(8, 248);
            Label41.TabIndex = 65;
            Label41.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label41.TextAlign = ContentAlignment.TopLeft;
            Label41.BackColor = Color.Transparent;
            Label41.Enabled = true;
            Label41.Cursor = Cursors.Default;
            Label41.RightToLeft = RightToLeft.No;
            Label41.UseMnemonic = true;
            Label41.Visible = true;
            Label41.AutoSize = false;
            Label41.BorderStyle = BorderStyle.None;
            Label41.Name = "Label41";
            Label40.Text = "Hrs";
            Label40.ForeColor = Color.White;
            Label40.Size = new Size(17, 17);
            Label40.Location = new Point(424, 248);
            Label40.TabIndex = 66;
            Label40.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label40.TextAlign = ContentAlignment.TopLeft;
            Label40.BackColor = Color.Transparent;
            Label40.Enabled = true;
            Label40.Cursor = Cursors.Default;
            Label40.RightToLeft = RightToLeft.No;
            Label40.UseMnemonic = true;
            Label40.Visible = true;
            Label40.AutoSize = false;
            Label40.BorderStyle = BorderStyle.None;
            Label40.Name = "Label40";
            Label32.Text = "$";
            Label32.ForeColor = Color.White;
            Label32.Size = new Size(9, 17);
            Label32.Location = new Point(512, 248);
            Label32.TabIndex = 67;
            Label32.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label32.TextAlign = ContentAlignment.TopLeft;
            Label32.BackColor = Color.Transparent;
            Label32.Enabled = true;
            Label32.Cursor = Cursors.Default;
            Label32.RightToLeft = RightToLeft.No;
            Label32.UseMnemonic = true;
            Label32.Visible = true;
            Label32.AutoSize = false;
            Label32.BorderStyle = BorderStyle.None;
            Label32.Name = "Label32";
            Label23.Text = "$";
            Label23.ForeColor = Color.White;
            Label23.Size = new Size(9, 17);
            Label23.Location = new Point(512, 56);
            Label23.TabIndex = 64;
            Label23.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label23.TextAlign = ContentAlignment.TopLeft;
            Label23.BackColor = Color.Transparent;
            Label23.Enabled = true;
            Label23.Cursor = Cursors.Default;
            Label23.RightToLeft = RightToLeft.No;
            Label23.UseMnemonic = true;
            Label23.Visible = true;
            Label23.AutoSize = false;
            Label23.BorderStyle = BorderStyle.None;
            Label23.Name = "Label23";
            Label22.Text = "$";
            Label22.ForeColor = Color.White;
            Label22.Size = new Size(9, 17);
            Label22.Location = new Point(512, 200);
            Label22.TabIndex = 61;
            Label22.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label22.TextAlign = ContentAlignment.TopLeft;
            Label22.BackColor = Color.Transparent;
            Label22.Enabled = true;
            Label22.Cursor = Cursors.Default;
            Label22.RightToLeft = RightToLeft.No;
            Label22.UseMnemonic = true;
            Label22.Visible = true;
            Label22.AutoSize = false;
            Label22.BorderStyle = BorderStyle.None;
            Label22.Name = "Label22";
            Label21.Text = "$";
            Label21.ForeColor = Color.White;
            Label21.Size = new Size(9, 17);
            Label21.Location = new Point(512, 176);
            Label21.TabIndex = 58;
            Label21.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label21.TextAlign = ContentAlignment.TopLeft;
            Label21.BackColor = Color.Transparent;
            Label21.Enabled = true;
            Label21.Cursor = Cursors.Default;
            Label21.RightToLeft = RightToLeft.No;
            Label21.UseMnemonic = true;
            Label21.Visible = true;
            Label21.AutoSize = false;
            Label21.BorderStyle = BorderStyle.None;
            Label21.Name = "Label21";
            Label20.Text = "$";
            Label20.ForeColor = Color.White;
            Label20.Size = new Size(9, 17);
            Label20.Location = new Point(512, 152);
            Label20.TabIndex = 55;
            Label20.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label20.TextAlign = ContentAlignment.TopLeft;
            Label20.BackColor = Color.Transparent;
            Label20.Enabled = true;
            Label20.Cursor = Cursors.Default;
            Label20.RightToLeft = RightToLeft.No;
            Label20.UseMnemonic = true;
            Label20.Visible = true;
            Label20.AutoSize = false;
            Label20.BorderStyle = BorderStyle.None;
            Label20.Name = "Label20";
            Label19.Text = "$";
            Label19.ForeColor = Color.White;
            Label19.Size = new Size(9, 17);
            Label19.Location = new Point(512, 128);
            Label19.TabIndex = 52;
            Label19.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label19.TextAlign = ContentAlignment.TopLeft;
            Label19.BackColor = Color.Transparent;
            Label19.Enabled = true;
            Label19.Cursor = Cursors.Default;
            Label19.RightToLeft = RightToLeft.No;
            Label19.UseMnemonic = true;
            Label19.Visible = true;
            Label19.AutoSize = false;
            Label19.BorderStyle = BorderStyle.None;
            Label19.Name = "Label19";
            Label18.Text = "$";
            Label18.ForeColor = Color.White;
            Label18.Size = new Size(9, 17);
            Label18.Location = new Point(512, 80);
            Label18.TabIndex = 49;
            Label18.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label18.TextAlign = ContentAlignment.TopLeft;
            Label18.BackColor = Color.Transparent;
            Label18.Enabled = true;
            Label18.Cursor = Cursors.Default;
            Label18.RightToLeft = RightToLeft.No;
            Label18.UseMnemonic = true;
            Label18.Visible = true;
            Label18.AutoSize = false;
            Label18.BorderStyle = BorderStyle.None;
            Label18.Name = "Label18";
            Label17.Text = "$";
            Label17.ForeColor = Color.White;
            Label17.Size = new Size(9, 17);
            Label17.Location = new Point(512, 104);
            Label17.TabIndex = 46;
            Label17.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label17.TextAlign = ContentAlignment.TopLeft;
            Label17.BackColor = Color.Transparent;
            Label17.Enabled = true;
            Label17.Cursor = Cursors.Default;
            Label17.RightToLeft = RightToLeft.No;
            Label17.UseMnemonic = true;
            Label17.Visible = true;
            Label17.AutoSize = false;
            Label17.BorderStyle = BorderStyle.None;
            Label17.Name = "Label17";
            Label16.Text = "Hrs";
            Label16.ForeColor = Color.White;
            Label16.Size = new Size(17, 17);
            Label16.Location = new Point(424, 56);
            Label16.TabIndex = 63;
            Label16.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label16.TextAlign = ContentAlignment.TopLeft;
            Label16.BackColor = Color.Transparent;
            Label16.Enabled = true;
            Label16.Cursor = Cursors.Default;
            Label16.RightToLeft = RightToLeft.No;
            Label16.UseMnemonic = true;
            Label16.Visible = true;
            Label16.AutoSize = false;
            Label16.BorderStyle = BorderStyle.None;
            Label16.Name = "Label16";
            Label15.Text = "Hrs";
            Label15.ForeColor = Color.White;
            Label15.Size = new Size(17, 17);
            Label15.Location = new Point(424, 200);
            Label15.TabIndex = 60;
            Label15.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label15.TextAlign = ContentAlignment.TopLeft;
            Label15.BackColor = Color.Transparent;
            Label15.Enabled = true;
            Label15.Cursor = Cursors.Default;
            Label15.RightToLeft = RightToLeft.No;
            Label15.UseMnemonic = true;
            Label15.Visible = true;
            Label15.AutoSize = false;
            Label15.BorderStyle = BorderStyle.None;
            Label15.Name = "Label15";
            Label14.Text = "Hrs";
            Label14.ForeColor = Color.White;
            Label14.Size = new Size(17, 17);
            Label14.Location = new Point(424, 176);
            Label14.TabIndex = 57;
            Label14.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label14.TextAlign = ContentAlignment.TopLeft;
            Label14.BackColor = Color.Transparent;
            Label14.Enabled = true;
            Label14.Cursor = Cursors.Default;
            Label14.RightToLeft = RightToLeft.No;
            Label14.UseMnemonic = true;
            Label14.Visible = true;
            Label14.AutoSize = false;
            Label14.BorderStyle = BorderStyle.None;
            Label14.Name = "Label14";
            Label13.Text = "Hrs";
            Label13.ForeColor = Color.White;
            Label13.Size = new Size(17, 17);
            Label13.Location = new Point(424, 152);
            Label13.TabIndex = 54;
            Label13.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label13.TextAlign = ContentAlignment.TopLeft;
            Label13.BackColor = Color.Transparent;
            Label13.Enabled = true;
            Label13.Cursor = Cursors.Default;
            Label13.RightToLeft = RightToLeft.No;
            Label13.UseMnemonic = true;
            Label13.Visible = true;
            Label13.AutoSize = false;
            Label13.BorderStyle = BorderStyle.None;
            Label13.Name = "Label13";
            Label12.Text = "Hrs";
            Label12.ForeColor = Color.White;
            Label12.Size = new Size(17, 17);
            Label12.Location = new Point(424, 128);
            Label12.TabIndex = 51;
            Label12.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label12.TextAlign = ContentAlignment.TopLeft;
            Label12.BackColor = Color.Transparent;
            Label12.Enabled = true;
            Label12.Cursor = Cursors.Default;
            Label12.RightToLeft = RightToLeft.No;
            Label12.UseMnemonic = true;
            Label12.Visible = true;
            Label12.AutoSize = false;
            Label12.BorderStyle = BorderStyle.None;
            Label12.Name = "Label12";
            Label11.Text = "Hrs";
            Label11.ForeColor = Color.White;
            Label11.Size = new Size(17, 17);
            Label11.Location = new Point(424, 80);
            Label11.TabIndex = 48;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label11.TextAlign = ContentAlignment.TopLeft;
            Label11.BackColor = Color.Transparent;
            Label11.Enabled = true;
            Label11.Cursor = Cursors.Default;
            Label11.RightToLeft = RightToLeft.No;
            Label11.UseMnemonic = true;
            Label11.Visible = true;
            Label11.AutoSize = false;
            Label11.BorderStyle = BorderStyle.None;
            Label11.Name = "Label11";
            Label10.Text = "Hrs";
            Label10.ForeColor = Color.White;
            Label10.Size = new Size(17, 17);
            Label10.Location = new Point(424, 104);
            Label10.TabIndex = 45;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label10.TextAlign = ContentAlignment.TopLeft;
            Label10.BackColor = Color.Transparent;
            Label10.Enabled = true;
            Label10.Cursor = Cursors.Default;
            Label10.RightToLeft = RightToLeft.No;
            Label10.UseMnemonic = true;
            Label10.Visible = true;
            Label10.AutoSize = false;
            Label10.BorderStyle = BorderStyle.None;
            Label10.Name = "Label10";
            Label9.TextAlign = ContentAlignment.TopCenter;
            Label9.Text = "Prix";
            Label9.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.ForeColor = Color.White;
            Label9.Size = new Size(49, 17);
            Label9.Location = new Point(456, 8);
            Label9.TabIndex = 43;
            Label9.BackColor = Color.Transparent;
            Label9.Enabled = true;
            Label9.Cursor = Cursors.Default;
            Label9.RightToLeft = RightToLeft.No;
            Label9.UseMnemonic = true;
            Label9.Visible = true;
            Label9.AutoSize = false;
            Label9.BorderStyle = BorderStyle.None;
            Label9.Name = "Label9";
            Label8.TextAlign = ContentAlignment.TopCenter;
            Label8.Text = "Temps";
            Label8.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.White;
            Label8.Size = new Size(217, 17);
            Label8.Location = new Point(200, 8);
            Label8.TabIndex = 42;
            Label8.BackColor = Color.Transparent;
            Label8.Enabled = true;
            Label8.Cursor = Cursors.Default;
            Label8.RightToLeft = RightToLeft.No;
            Label8.UseMnemonic = true;
            Label8.Visible = true;
            Label8.AutoSize = false;
            Label8.BorderStyle = BorderStyle.None;
            Label8.Name = "Label8";
            Label7.Text = "Conception et dessins :";
            Label7.ForeColor = Color.White;
            Label7.Size = new Size(137, 17);
            Label7.Location = new Point(8, 56);
            Label7.TabIndex = 62;
            Label7.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.TextAlign = ContentAlignment.TopLeft;
            Label7.BackColor = Color.Transparent;
            Label7.Enabled = true;
            Label7.Cursor = Cursors.Default;
            Label7.RightToLeft = RightToLeft.No;
            Label7.UseMnemonic = true;
            Label7.Visible = true;
            Label7.AutoSize = false;
            Label7.BorderStyle = BorderStyle.None;
            Label7.Name = "Label7";
            Label6.Text = "Tests finaux :";
            Label6.ForeColor = Color.White;
            Label6.Size = new Size(137, 17);
            Label6.Location = new Point(8, 200);
            Label6.TabIndex = 59;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.TextAlign = ContentAlignment.TopLeft;
            Label6.BackColor = Color.Transparent;
            Label6.Enabled = true;
            Label6.Cursor = Cursors.Default;
            Label6.RightToLeft = RightToLeft.No;
            Label6.UseMnemonic = true;
            Label6.Visible = true;
            Label6.AutoSize = false;
            Label6.BorderStyle = BorderStyle.None;
            Label6.Name = "Label6";
            Label5.Text = "Assemblage des systèmes :";
            Label5.ForeColor = Color.White;
            Label5.Size = new Size(137, 17);
            Label5.Location = new Point(8, 152);
            Label5.TabIndex = 53;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.TextAlign = ContentAlignment.TopLeft;
            Label5.BackColor = Color.Transparent;
            Label5.Enabled = true;
            Label5.Cursor = Cursors.Default;
            Label5.RightToLeft = RightToLeft.No;
            Label5.UseMnemonic = true;
            Label5.Visible = true;
            Label5.AutoSize = false;
            Label5.BorderStyle = BorderStyle.None;
            Label5.Name = "Label5";
            Label4.Text = "Peinture et finition :";
            Label4.ForeColor = Color.White;
            Label4.Size = new Size(137, 17);
            Label4.Location = new Point(8, 176);
            Label4.TabIndex = 56;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.TextAlign = ContentAlignment.TopLeft;
            Label4.BackColor = Color.Transparent;
            Label4.Enabled = true;
            Label4.Cursor = Cursors.Default;
            Label4.RightToLeft = RightToLeft.No;
            Label4.UseMnemonic = true;
            Label4.Visible = true;
            Label4.AutoSize = false;
            Label4.BorderStyle = BorderStyle.None;
            Label4.Name = "Label4";
            Label3.Text = "Coupe, soudure et meulage :";
            Label3.ForeColor = Color.White;
            Label3.Size = new Size(137, 17);
            Label3.Location = new Point(8, 128);
            Label3.TabIndex = 50;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.TextAlign = ContentAlignment.TopLeft;
            Label3.BackColor = Color.Transparent;
            Label3.Enabled = true;
            Label3.Cursor = Cursors.Default;
            Label3.RightToLeft = RightToLeft.No;
            Label3.UseMnemonic = true;
            Label3.Visible = true;
            Label3.AutoSize = false;
            Label3.BorderStyle = BorderStyle.None;
            Label3.Name = "Label3";
            Label2.Text = "Coupe et préparation (sauf soudage) :";
            Label2.ForeColor = Color.White;
            Label2.Size = new Size(185, 17);
            Label2.Location = new Point(8, 80);
            Label2.TabIndex = 47;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.TextAlign = ContentAlignment.TopLeft;
            Label2.BackColor = Color.Transparent;
            Label2.Enabled = true;
            Label2.Cursor = Cursors.Default;
            Label2.RightToLeft = RightToLeft.No;
            Label2.UseMnemonic = true;
            Label2.Visible = true;
            Label2.AutoSize = false;
            Label2.BorderStyle = BorderStyle.None;
            Label2.Name = "Label2";
            Label1.Text = "Machinage :";
            Label1.ForeColor = Color.White;
            Label1.Size = new Size(137, 17);
            Label1.Location = new Point(8, 104);
            Label1.TabIndex = 44;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.TextAlign = ContentAlignment.TopLeft;
            Label1.BackColor = Color.Transparent;
            Label1.Enabled = true;
            Label1.Cursor = Cursors.Default;
            Label1.RightToLeft = RightToLeft.No;
            Label1.UseMnemonic = true;
            Label1.Visible = true;
            Label1.AutoSize = false;
            Label1.BorderStyle = BorderStyle.None;
            Label1.Name = "Label1";
            cmdDetail.TextAlign = ContentAlignment.MiddleCenter;
            cmdDetail.Text = "Détails";
            cmdDetail.Size = new Size(49, 25);
            cmdDetail.Location = new Point(376, 472);
            cmdDetail.TabIndex = 32;
            cmdDetail.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdDetail.BackColor = SystemColors.Control;
            cmdDetail.CausesValidation = true;
            cmdDetail.Enabled = true;
            cmdDetail.ForeColor = SystemColors.ControlText;
            cmdDetail.Cursor = Cursors.Default;
            cmdDetail.RightToLeft = RightToLeft.No;
            cmdDetail.TabStop = true;
            cmdDetail.Name = "cmdDetail";
            cmdFermer.TextAlign = ContentAlignment.MiddleCenter;
            cmdFermer.Text = "Fermer";
            cmdFermer.Size = new Size(81, 25);
            cmdFermer.Location = new Point(784, 424);
            cmdFermer.TabIndex = 40;
            cmdFermer.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdFermer.BackColor = SystemColors.Control;
            cmdFermer.CausesValidation = true;
            cmdFermer.Enabled = true;
            cmdFermer.ForeColor = SystemColors.ControlText;
            cmdFermer.Cursor = Cursors.Default;
            cmdFermer.RightToLeft = RightToLeft.No;
            cmdFermer.TabStop = true;
            cmdFermer.Name = "cmdFermer";
            fraManutention.BackColor = Color.Black;
            fraManutention.Text = "Manutention";
            fraManutention.Font = new Font("Arial", 8.25f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            fraManutention.ForeColor = Color.White;
            fraManutention.Size = new Size(321, 57);
            fraManutention.Location = new Point(544, 192);
            fraManutention.TabIndex = 86;
            fraManutention.Enabled = true;
            fraManutention.RightToLeft = RightToLeft.No;
            fraManutention.Visible = true;
            fraManutention.Padding = new Padding(0);
            fraManutention.Name = "fraManutention";
            txtPrixEmballage.AutoSize = false;
            txtPrixEmballage.TextAlign = HorizontalAlignment.Right;
            txtPrixEmballage.Size = new Size(49, 19);
            txtPrixEmballage.Location = new Point(248, 32);
            txtPrixEmballage.TabIndex = 38;
            txtPrixEmballage.Text = "0";
            txtPrixEmballage.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrixEmballage.AcceptsReturn = true;
            txtPrixEmballage.BackColor = SystemColors.Window;
            txtPrixEmballage.CausesValidation = true;
            txtPrixEmballage.Enabled = true;
            txtPrixEmballage.ForeColor = SystemColors.WindowText;
            txtPrixEmballage.HideSelection = true;
            txtPrixEmballage.ReadOnly = false;
            txtPrixEmballage.MaxLength = 0;
            txtPrixEmballage.Cursor = Cursors.IBeam;
            txtPrixEmballage.Multiline = false;
            txtPrixEmballage.RightToLeft = RightToLeft.No;
            txtPrixEmballage.ScrollBars = ScrollBars.None;
            txtPrixEmballage.TabStop = true;
            txtPrixEmballage.Visible = true;
            txtPrixEmballage.BorderStyle = BorderStyle.Fixed3D;
            txtPrixEmballage.Name = "txtPrixEmballage";
            Label48.Text = "$";
            Label48.ForeColor = Color.White;
            Label48.Size = new Size(9, 17);
            Label48.Location = new Point(304, 32);
            Label48.TabIndex = 89;
            Label48.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label48.TextAlign = ContentAlignment.TopLeft;
            Label48.BackColor = Color.Transparent;
            Label48.Enabled = true;
            Label48.Cursor = Cursors.Default;
            Label48.RightToLeft = RightToLeft.No;
            Label48.UseMnemonic = true;
            Label48.Visible = true;
            Label48.AutoSize = false;
            Label48.BorderStyle = BorderStyle.None;
            Label48.Name = "Label48";
            Label33.TextAlign = ContentAlignment.TopCenter;
            Label33.Text = "Prix";
            Label33.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            Label33.ForeColor = Color.White;
            Label33.Size = new Size(49, 17);
            Label33.Location = new Point(248, 8);
            Label33.TabIndex = 87;
            Label33.BackColor = Color.Transparent;
            Label33.Enabled = true;
            Label33.Cursor = Cursors.Default;
            Label33.RightToLeft = RightToLeft.No;
            Label33.UseMnemonic = true;
            Label33.Visible = true;
            Label33.AutoSize = false;
            Label33.BorderStyle = BorderStyle.None;
            Label33.Name = "Label33";
            Label24.Text = "Frais de transport / emballage :";
            Label24.ForeColor = Color.White;
            Label24.Size = new Size(153, 17);
            Label24.Location = new Point(8, 32);
            Label24.TabIndex = 88;
            Label24.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label24.TextAlign = ContentAlignment.TopLeft;
            Label24.BackColor = Color.Transparent;
            Label24.Enabled = true;
            Label24.Cursor = Cursors.Default;
            Label24.RightToLeft = RightToLeft.No;
            Label24.UseMnemonic = true;
            Label24.Visible = true;
            Label24.AutoSize = false;
            Label24.BorderStyle = BorderStyle.None;
            Label24.Name = "Label24";
            fraFraisSubsistences.BackColor = Color.Black;
            fraFraisSubsistences.Text = "Frais de subsistances";
            fraFraisSubsistences.Font = new Font("Arial", 8.25f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            fraFraisSubsistences.ForeColor = Color.White;
            fraFraisSubsistences.Size = new Size(321, 129);
            fraFraisSubsistences.Location = new Point(544, 56);
            fraFraisSubsistences.TabIndex = 71;
            fraFraisSubsistences.Enabled = true;
            fraFraisSubsistences.RightToLeft = RightToLeft.No;
            fraFraisSubsistences.Visible = true;
            fraFraisSubsistences.Padding = new Padding(0);
            fraFraisSubsistences.Name = "fraFraisSubsistences";
            txtNbrePersonne.AutoSize = false;
            txtNbrePersonne.Size = new Size(33, 19);
            txtNbrePersonne.Location = new Point(88, 32);
            txtNbrePersonne.MaxLength = 2;
            txtNbrePersonne.TabIndex = 33;
            txtNbrePersonne.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNbrePersonne.AcceptsReturn = true;
            txtNbrePersonne.TextAlign = HorizontalAlignment.Left;
            txtNbrePersonne.BackColor = SystemColors.Window;
            txtNbrePersonne.CausesValidation = true;
            txtNbrePersonne.Enabled = true;
            txtNbrePersonne.ForeColor = SystemColors.WindowText;
            txtNbrePersonne.HideSelection = true;
            txtNbrePersonne.ReadOnly = false;
            txtNbrePersonne.Cursor = Cursors.IBeam;
            txtNbrePersonne.Multiline = false;
            txtNbrePersonne.RightToLeft = RightToLeft.No;
            txtNbrePersonne.ScrollBars = ScrollBars.None;
            txtNbrePersonne.TabStop = true;
            txtNbrePersonne.Visible = true;
            txtNbrePersonne.BorderStyle = BorderStyle.Fixed3D;
            txtNbrePersonne.Name = "txtNbrePersonne";
            txtTempsDeplacement.AutoSize = false;
            txtTempsDeplacement.Size = new Size(49, 19);
            txtTempsDeplacement.Location = new Point(160, 80);
            txtTempsDeplacement.TabIndex = 36;
            txtTempsDeplacement.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsDeplacement.AcceptsReturn = true;
            txtTempsDeplacement.TextAlign = HorizontalAlignment.Left;
            txtTempsDeplacement.BackColor = SystemColors.Window;
            txtTempsDeplacement.CausesValidation = true;
            txtTempsDeplacement.Enabled = true;
            txtTempsDeplacement.ForeColor = SystemColors.WindowText;
            txtTempsDeplacement.HideSelection = true;
            txtTempsDeplacement.ReadOnly = false;
            txtTempsDeplacement.MaxLength = 0;
            txtTempsDeplacement.Cursor = Cursors.IBeam;
            txtTempsDeplacement.Multiline = false;
            txtTempsDeplacement.RightToLeft = RightToLeft.No;
            txtTempsDeplacement.ScrollBars = ScrollBars.None;
            txtTempsDeplacement.TabStop = true;
            txtTempsDeplacement.Visible = true;
            txtTempsDeplacement.BorderStyle = BorderStyle.Fixed3D;
            txtTempsDeplacement.Name = "txtTempsDeplacement";
            txtTempsHebergement.AutoSize = false;
            txtTempsHebergement.Size = new Size(49, 19);
            txtTempsHebergement.Location = new Point(160, 32);
            txtTempsHebergement.TabIndex = 34;
            txtTempsHebergement.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsHebergement.AcceptsReturn = true;
            txtTempsHebergement.TextAlign = HorizontalAlignment.Left;
            txtTempsHebergement.BackColor = SystemColors.Window;
            txtTempsHebergement.CausesValidation = true;
            txtTempsHebergement.Enabled = true;
            txtTempsHebergement.ForeColor = SystemColors.WindowText;
            txtTempsHebergement.HideSelection = true;
            txtTempsHebergement.ReadOnly = false;
            txtTempsHebergement.MaxLength = 0;
            txtTempsHebergement.Cursor = Cursors.IBeam;
            txtTempsHebergement.Multiline = false;
            txtTempsHebergement.RightToLeft = RightToLeft.No;
            txtTempsHebergement.ScrollBars = ScrollBars.None;
            txtTempsHebergement.TabStop = true;
            txtTempsHebergement.Visible = true;
            txtTempsHebergement.BorderStyle = BorderStyle.Fixed3D;
            txtTempsHebergement.Name = "txtTempsHebergement";
            txtTempsRepas.AutoSize = false;
            txtTempsRepas.Size = new Size(49, 19);
            txtTempsRepas.Location = new Point(160, 56);
            txtTempsRepas.TabIndex = 35;
            txtTempsRepas.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsRepas.AcceptsReturn = true;
            txtTempsRepas.TextAlign = HorizontalAlignment.Left;
            txtTempsRepas.BackColor = SystemColors.Window;
            txtTempsRepas.CausesValidation = true;
            txtTempsRepas.Enabled = true;
            txtTempsRepas.ForeColor = SystemColors.WindowText;
            txtTempsRepas.HideSelection = true;
            txtTempsRepas.ReadOnly = false;
            txtTempsRepas.MaxLength = 0;
            txtTempsRepas.Cursor = Cursors.IBeam;
            txtTempsRepas.Multiline = false;
            txtTempsRepas.RightToLeft = RightToLeft.No;
            txtTempsRepas.ScrollBars = ScrollBars.None;
            txtTempsRepas.TabStop = true;
            txtTempsRepas.Visible = true;
            txtTempsRepas.BorderStyle = BorderStyle.Fixed3D;
            txtTempsRepas.Name = "txtTempsRepas";
            txtTempsUniteMobile.AutoSize = false;
            txtTempsUniteMobile.Size = new Size(49, 19);
            txtTempsUniteMobile.Location = new Point(160, 104);
            txtTempsUniteMobile.TabIndex = 37;
            txtTempsUniteMobile.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempsUniteMobile.AcceptsReturn = true;
            txtTempsUniteMobile.TextAlign = HorizontalAlignment.Left;
            txtTempsUniteMobile.BackColor = SystemColors.Window;
            txtTempsUniteMobile.CausesValidation = true;
            txtTempsUniteMobile.Enabled = true;
            txtTempsUniteMobile.ForeColor = SystemColors.WindowText;
            txtTempsUniteMobile.HideSelection = true;
            txtTempsUniteMobile.ReadOnly = false;
            txtTempsUniteMobile.MaxLength = 0;
            txtTempsUniteMobile.Cursor = Cursors.IBeam;
            txtTempsUniteMobile.Multiline = false;
            txtTempsUniteMobile.RightToLeft = RightToLeft.No;
            txtTempsUniteMobile.ScrollBars = ScrollBars.None;
            txtTempsUniteMobile.TabStop = true;
            txtTempsUniteMobile.Visible = true;
            txtTempsUniteMobile.BorderStyle = BorderStyle.Fixed3D;
            txtTempsUniteMobile.Name = "txtTempsUniteMobile";
            lblPrixUniteMobile.TextAlign = ContentAlignment.TopRight;
            lblPrixUniteMobile.BackColor = Color.White;
            lblPrixUniteMobile.Text = "0";
            lblPrixUniteMobile.Size = new Size(49, 19);
            lblPrixUniteMobile.Location = new Point(248, 104);
            lblPrixUniteMobile.TabIndex = 130;
            lblPrixUniteMobile.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixUniteMobile.Enabled = true;
            lblPrixUniteMobile.ForeColor = SystemColors.ControlText;
            lblPrixUniteMobile.Cursor = Cursors.Default;
            lblPrixUniteMobile.RightToLeft = RightToLeft.No;
            lblPrixUniteMobile.UseMnemonic = true;
            lblPrixUniteMobile.Visible = true;
            lblPrixUniteMobile.AutoSize = false;
            lblPrixUniteMobile.BorderStyle = BorderStyle.Fixed3D;
            lblPrixUniteMobile.Name = "lblPrixUniteMobile";
            lblPrixDeplacement.TextAlign = ContentAlignment.TopRight;
            lblPrixDeplacement.BackColor = Color.White;
            lblPrixDeplacement.Text = "0";
            lblPrixDeplacement.Size = new Size(49, 19);
            lblPrixDeplacement.Location = new Point(248, 80);
            lblPrixDeplacement.TabIndex = 129;
            lblPrixDeplacement.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixDeplacement.Enabled = true;
            lblPrixDeplacement.ForeColor = SystemColors.ControlText;
            lblPrixDeplacement.Cursor = Cursors.Default;
            lblPrixDeplacement.RightToLeft = RightToLeft.No;
            lblPrixDeplacement.UseMnemonic = true;
            lblPrixDeplacement.Visible = true;
            lblPrixDeplacement.AutoSize = false;
            lblPrixDeplacement.BorderStyle = BorderStyle.Fixed3D;
            lblPrixDeplacement.Name = "lblPrixDeplacement";
            lblPrixRepas.TextAlign = ContentAlignment.TopRight;
            lblPrixRepas.BackColor = Color.White;
            lblPrixRepas.Text = "0";
            lblPrixRepas.Size = new Size(49, 19);
            lblPrixRepas.Location = new Point(248, 56);
            lblPrixRepas.TabIndex = 128;
            lblPrixRepas.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixRepas.Enabled = true;
            lblPrixRepas.ForeColor = SystemColors.ControlText;
            lblPrixRepas.Cursor = Cursors.Default;
            lblPrixRepas.RightToLeft = RightToLeft.No;
            lblPrixRepas.UseMnemonic = true;
            lblPrixRepas.Visible = true;
            lblPrixRepas.AutoSize = false;
            lblPrixRepas.BorderStyle = BorderStyle.Fixed3D;
            lblPrixRepas.Name = "lblPrixRepas";
            lblPrixHebergement.TextAlign = ContentAlignment.TopRight;
            lblPrixHebergement.BackColor = Color.White;
            lblPrixHebergement.Text = "0";
            lblPrixHebergement.Size = new Size(49, 19);
            lblPrixHebergement.Location = new Point(248, 32);
            lblPrixHebergement.TabIndex = 127;
            lblPrixHebergement.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrixHebergement.Enabled = true;
            lblPrixHebergement.ForeColor = SystemColors.ControlText;
            lblPrixHebergement.Cursor = Cursors.Default;
            lblPrixHebergement.RightToLeft = RightToLeft.No;
            lblPrixHebergement.UseMnemonic = true;
            lblPrixHebergement.Visible = true;
            lblPrixHebergement.AutoSize = false;
            lblPrixHebergement.BorderStyle = BorderStyle.Fixed3D;
            lblPrixHebergement.Name = "lblPrixHebergement";
            Label31.Text = "pers.";
            Label31.ForeColor = Color.White;
            Label31.Size = new Size(41, 17);
            Label31.Location = new Point(128, 32);
            Label31.TabIndex = 74;
            Label31.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label31.TextAlign = ContentAlignment.TopLeft;
            Label31.BackColor = Color.Transparent;
            Label31.Enabled = true;
            Label31.Cursor = Cursors.Default;
            Label31.RightToLeft = RightToLeft.No;
            Label31.UseMnemonic = true;
            Label31.Visible = true;
            Label31.AutoSize = false;
            Label31.BorderStyle = BorderStyle.None;
            Label31.Name = "Label31";
            Label46.Text = "Hébergement :";
            Label46.ForeColor = Color.White;
            Label46.Size = new Size(81, 17);
            Label46.Location = new Point(8, 32);
            Label46.TabIndex = 73;
            Label46.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label46.TextAlign = ContentAlignment.TopLeft;
            Label46.BackColor = Color.Transparent;
            Label46.Enabled = true;
            Label46.Cursor = Cursors.Default;
            Label46.RightToLeft = RightToLeft.No;
            Label46.UseMnemonic = true;
            Label46.Visible = true;
            Label46.AutoSize = false;
            Label46.BorderStyle = BorderStyle.None;
            Label46.Name = "Label46";
            Label45.Text = "Repas :";
            Label45.ForeColor = Color.White;
            Label45.Size = new Size(49, 17);
            Label45.Location = new Point(8, 56);
            Label45.TabIndex = 77;
            Label45.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label45.TextAlign = ContentAlignment.TopLeft;
            Label45.BackColor = Color.Transparent;
            Label45.Enabled = true;
            Label45.Cursor = Cursors.Default;
            Label45.RightToLeft = RightToLeft.No;
            Label45.UseMnemonic = true;
            Label45.Visible = true;
            Label45.AutoSize = false;
            Label45.BorderStyle = BorderStyle.None;
            Label45.Name = "Label45";
            Label44.Text = "Transport / déplacement : ";
            Label44.ForeColor = Color.White;
            Label44.Size = new Size(129, 17);
            Label44.Location = new Point(8, 80);
            Label44.TabIndex = 80;
            Label44.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label44.TextAlign = ContentAlignment.TopLeft;
            Label44.BackColor = Color.Transparent;
            Label44.Enabled = true;
            Label44.Cursor = Cursors.Default;
            Label44.RightToLeft = RightToLeft.No;
            Label44.UseMnemonic = true;
            Label44.Visible = true;
            Label44.AutoSize = false;
            Label44.BorderStyle = BorderStyle.None;
            Label44.Name = "Label44";
            Label42.Text = "Transport de l'unité mobile :";
            Label42.ForeColor = Color.White;
            Label42.Size = new Size(137, 17);
            Label42.Location = new Point(8, 104);
            Label42.TabIndex = 83;
            Label42.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label42.TextAlign = ContentAlignment.TopLeft;
            Label42.BackColor = Color.Transparent;
            Label42.Enabled = true;
            Label42.Cursor = Cursors.Default;
            Label42.RightToLeft = RightToLeft.No;
            Label42.UseMnemonic = true;
            Label42.Visible = true;
            Label42.AutoSize = false;
            Label42.BorderStyle = BorderStyle.None;
            Label42.Name = "Label42";
            Label38.TextAlign = ContentAlignment.TopCenter;
            Label38.Text = "Prix";
            Label38.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Regular, GraphicsUnit.Point, 0);
            Label38.ForeColor = Color.White;
            Label38.Size = new Size(49, 17);
            Label38.Location = new Point(248, 8);
            Label38.TabIndex = 72;
            Label38.BackColor = Color.Transparent;
            Label38.Enabled = true;
            Label38.Cursor = Cursors.Default;
            Label38.RightToLeft = RightToLeft.No;
            Label38.UseMnemonic = true;
            Label38.Visible = true;
            Label38.AutoSize = false;
            Label38.BorderStyle = BorderStyle.None;
            Label38.Name = "Label38";
            Label37.Text = "Jours";
            Label37.ForeColor = Color.White;
            Label37.Size = new Size(33, 17);
            Label37.Location = new Point(216, 32);
            Label37.TabIndex = 75;
            Label37.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label37.TextAlign = ContentAlignment.TopLeft;
            Label37.BackColor = Color.Transparent;
            Label37.Enabled = true;
            Label37.Cursor = Cursors.Default;
            Label37.RightToLeft = RightToLeft.No;
            Label37.UseMnemonic = true;
            Label37.Visible = true;
            Label37.AutoSize = false;
            Label37.BorderStyle = BorderStyle.None;
            Label37.Name = "Label37";
            Label36.Text = "Jours";
            Label36.ForeColor = Color.White;
            Label36.Size = new Size(25, 17);
            Label36.Location = new Point(216, 56);
            Label36.TabIndex = 78;
            Label36.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label36.TextAlign = ContentAlignment.TopLeft;
            Label36.BackColor = Color.Transparent;
            Label36.Enabled = true;
            Label36.Cursor = Cursors.Default;
            Label36.RightToLeft = RightToLeft.No;
            Label36.UseMnemonic = true;
            Label36.Visible = true;
            Label36.AutoSize = false;
            Label36.BorderStyle = BorderStyle.None;
            Label36.Name = "Label36";
            Label35.Text = "Km";
            Label35.ForeColor = Color.White;
            Label35.Size = new Size(17, 17);
            Label35.Location = new Point(216, 80);
            Label35.TabIndex = 81;
            Label35.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label35.TextAlign = ContentAlignment.TopLeft;
            Label35.BackColor = Color.Transparent;
            Label35.Enabled = true;
            Label35.Cursor = Cursors.Default;
            Label35.RightToLeft = RightToLeft.No;
            Label35.UseMnemonic = true;
            Label35.Visible = true;
            Label35.AutoSize = false;
            Label35.BorderStyle = BorderStyle.None;
            Label35.Name = "Label35";
            Label34.Text = "Km";
            Label34.ForeColor = Color.White;
            Label34.Size = new Size(17, 17);
            Label34.Location = new Point(216, 104);
            Label34.TabIndex = 84;
            Label34.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label34.TextAlign = ContentAlignment.TopLeft;
            Label34.BackColor = Color.Transparent;
            Label34.Enabled = true;
            Label34.Cursor = Cursors.Default;
            Label34.RightToLeft = RightToLeft.No;
            Label34.UseMnemonic = true;
            Label34.Visible = true;
            Label34.AutoSize = false;
            Label34.BorderStyle = BorderStyle.None;
            Label34.Name = "Label34";
            Label30.Text = "$";
            Label30.ForeColor = Color.White;
            Label30.Size = new Size(9, 17);
            Label30.Location = new Point(304, 32);
            Label30.TabIndex = 76;
            Label30.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label30.TextAlign = ContentAlignment.TopLeft;
            Label30.BackColor = Color.Transparent;
            Label30.Enabled = true;
            Label30.Cursor = Cursors.Default;
            Label30.RightToLeft = RightToLeft.No;
            Label30.UseMnemonic = true;
            Label30.Visible = true;
            Label30.AutoSize = false;
            Label30.BorderStyle = BorderStyle.None;
            Label30.Name = "Label30";
            Label29.Text = "$";
            Label29.ForeColor = Color.White;
            Label29.Size = new Size(9, 17);
            Label29.Location = new Point(304, 56);
            Label29.TabIndex = 79;
            Label29.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label29.TextAlign = ContentAlignment.TopLeft;
            Label29.BackColor = Color.Transparent;
            Label29.Enabled = true;
            Label29.Cursor = Cursors.Default;
            Label29.RightToLeft = RightToLeft.No;
            Label29.UseMnemonic = true;
            Label29.Visible = true;
            Label29.AutoSize = false;
            Label29.BorderStyle = BorderStyle.None;
            Label29.Name = "Label29";
            Label28.Text = "$";
            Label28.ForeColor = Color.White;
            Label28.Size = new Size(9, 17);
            Label28.Location = new Point(304, 80);
            Label28.TabIndex = 82;
            Label28.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label28.TextAlign = ContentAlignment.TopLeft;
            Label28.BackColor = Color.Transparent;
            Label28.Enabled = true;
            Label28.Cursor = Cursors.Default;
            Label28.RightToLeft = RightToLeft.No;
            Label28.UseMnemonic = true;
            Label28.Visible = true;
            Label28.AutoSize = false;
            Label28.BorderStyle = BorderStyle.None;
            Label28.Name = "Label28";
            Label27.Text = "$";
            Label27.ForeColor = Color.White;
            Label27.Size = new Size(9, 17);
            Label27.Location = new Point(304, 104);
            Label27.TabIndex = 85;
            Label27.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label27.TextAlign = ContentAlignment.TopLeft;
            Label27.BackColor = Color.Transparent;
            Label27.Enabled = true;
            Label27.Cursor = Cursors.Default;
            Label27.RightToLeft = RightToLeft.No;
            Label27.UseMnemonic = true;
            Label27.Visible = true;
            Label27.AutoSize = false;
            Label27.BorderStyle = BorderStyle.None;
            Label27.Name = "Label27";
            cmdUnlock.TextAlign = ContentAlignment.BottomCenter;
            cmdUnlock.Size = new Size(49, 41);
            cmdUnlock.Location = new Point(720, 528);
            cmdUnlock.Image = (Image)resources.GetObject("cmdUnlock.Image");
            cmdUnlock.TabIndex = 30;
            cmdUnlock.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdUnlock.BackColor = SystemColors.Control;
            cmdUnlock.CausesValidation = true;
            cmdUnlock.Enabled = true;
            cmdUnlock.ForeColor = SystemColors.ControlText;
            cmdUnlock.Cursor = Cursors.Default;
            cmdUnlock.RightToLeft = RightToLeft.No;
            cmdUnlock.TabStop = true;
            cmdUnlock.Name = "cmdUnlock";
            cmdLock.TextAlign = ContentAlignment.BottomCenter;
            cmdLock.Size = new Size(49, 41);
            cmdLock.Location = new Point(720, 528);
            cmdLock.Image = (Image)resources.GetObject("cmdLock.Image");
            cmdLock.TabIndex = 31;
            cmdLock.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdLock.BackColor = SystemColors.Control;
            cmdLock.CausesValidation = true;
            cmdLock.Enabled = true;
            cmdLock.ForeColor = SystemColors.ControlText;
            cmdLock.Cursor = Cursors.Default;
            cmdLock.RightToLeft = RightToLeft.No;
            cmdLock.TabStop = true;
            cmdLock.Name = "cmdLock";
            lblTotal.TextAlign = ContentAlignment.TopRight;
            lblTotal.BackColor = Color.White;
            lblTotal.Text = "0";
            lblTotal.Size = new Size(49, 19);
            lblTotal.Location = new Point(792, 264);
            lblTotal.TabIndex = 39;
            lblTotal.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Enabled = true;
            lblTotal.ForeColor = SystemColors.ControlText;
            lblTotal.Cursor = Cursors.Default;
            lblTotal.RightToLeft = RightToLeft.No;
            lblTotal.UseMnemonic = true;
            lblTotal.Visible = true;
            lblTotal.AutoSize = false;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Name = "lblTotal";
            lblTotalPrixRH.TextAlign = ContentAlignment.TopRight;
            lblTotalPrixRH.BackColor = Color.White;
            lblTotalPrixRH.Text = "0";
            lblTotalPrixRH.Size = new Size(49, 19);
            lblTotalPrixRH.Location = new Point(464, 440);
            lblTotalPrixRH.TabIndex = 126;
            lblTotalPrixRH.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPrixRH.Enabled = true;
            lblTotalPrixRH.ForeColor = SystemColors.ControlText;
            lblTotalPrixRH.Cursor = Cursors.Default;
            lblTotalPrixRH.RightToLeft = RightToLeft.No;
            lblTotalPrixRH.UseMnemonic = true;
            lblTotalPrixRH.Visible = true;
            lblTotalPrixRH.AutoSize = false;
            lblTotalPrixRH.BorderStyle = BorderStyle.Fixed3D;
            lblTotalPrixRH.Name = "lblTotalPrixRH";
            lblTotalTempsRHProj.BackColor = Color.White;
            lblTotalTempsRHProj.Size = new Size(49, 19);
            lblTotalTempsRHProj.Location = new Point(264, 440);
            lblTotalTempsRHProj.TabIndex = 125;
            lblTotalTempsRHProj.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTempsRHProj.TextAlign = ContentAlignment.TopLeft;
            lblTotalTempsRHProj.Enabled = true;
            lblTotalTempsRHProj.ForeColor = SystemColors.ControlText;
            lblTotalTempsRHProj.Cursor = Cursors.Default;
            lblTotalTempsRHProj.RightToLeft = RightToLeft.No;
            lblTotalTempsRHProj.UseMnemonic = true;
            lblTotalTempsRHProj.Visible = true;
            lblTotalTempsRHProj.AutoSize = false;
            lblTotalTempsRHProj.BorderStyle = BorderStyle.Fixed3D;
            lblTotalTempsRHProj.Name = "lblTotalTempsRHProj";
            lblTotalTempsRHConc.BackColor = Color.White;
            lblTotalTempsRHConc.Size = new Size(49, 19);
            lblTotalTempsRHConc.Location = new Point(320, 440);
            lblTotalTempsRHConc.TabIndex = 124;
            lblTotalTempsRHConc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTempsRHConc.TextAlign = ContentAlignment.TopLeft;
            lblTotalTempsRHConc.Enabled = true;
            lblTotalTempsRHConc.ForeColor = SystemColors.ControlText;
            lblTotalTempsRHConc.Cursor = Cursors.Default;
            lblTotalTempsRHConc.RightToLeft = RightToLeft.No;
            lblTotalTempsRHConc.UseMnemonic = true;
            lblTotalTempsRHConc.Visible = true;
            lblTotalTempsRHConc.AutoSize = false;
            lblTotalTempsRHConc.BorderStyle = BorderStyle.Fixed3D;
            lblTotalTempsRHConc.Name = "lblTotalTempsRHConc";
            lblTotalTempsRHReel.BackColor = Color.White;
            lblTotalTempsRHReel.Size = new Size(49, 19);
            lblTotalTempsRHReel.Location = new Point(376, 440);
            lblTotalTempsRHReel.TabIndex = 123;
            lblTotalTempsRHReel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTempsRHReel.TextAlign = ContentAlignment.TopLeft;
            lblTotalTempsRHReel.Enabled = true;
            lblTotalTempsRHReel.ForeColor = SystemColors.ControlText;
            lblTotalTempsRHReel.Cursor = Cursors.Default;
            lblTotalTempsRHReel.RightToLeft = RightToLeft.No;
            lblTotalTempsRHReel.UseMnemonic = true;
            lblTotalTempsRHReel.Visible = true;
            lblTotalTempsRHReel.AutoSize = false;
            lblTotalTempsRHReel.BorderStyle = BorderStyle.Fixed3D;
            lblTotalTempsRHReel.Name = "lblTotalTempsRHReel";
            lblTotalTempsRHSoum.BackColor = Color.White;
            lblTotalTempsRHSoum.Size = new Size(49, 19);
            lblTotalTempsRHSoum.Location = new Point(208, 440);
            lblTotalTempsRHSoum.TabIndex = 122;
            lblTotalTempsRHSoum.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTempsRHSoum.TextAlign = ContentAlignment.TopLeft;
            lblTotalTempsRHSoum.Enabled = true;
            lblTotalTempsRHSoum.ForeColor = SystemColors.ControlText;
            lblTotalTempsRHSoum.Cursor = Cursors.Default;
            lblTotalTempsRHSoum.RightToLeft = RightToLeft.No;
            lblTotalTempsRHSoum.UseMnemonic = true;
            lblTotalTempsRHSoum.Visible = true;
            lblTotalTempsRHSoum.AutoSize = false;
            lblTotalTempsRHSoum.BorderStyle = BorderStyle.Fixed3D;
            lblTotalTempsRHSoum.Name = "lblTotalTempsRHSoum";
            Label52.Text = "Total de la ressource humaine :";
            Label52.ForeColor = Color.White;
            Label52.Size = new Size(153, 17);
            Label52.Location = new Point(16, 440);
            Label52.TabIndex = 92;
            Label52.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label52.TextAlign = ContentAlignment.TopLeft;
            Label52.BackColor = Color.Transparent;
            Label52.Enabled = true;
            Label52.Cursor = Cursors.Default;
            Label52.RightToLeft = RightToLeft.No;
            Label52.UseMnemonic = true;
            Label52.Visible = true;
            Label52.AutoSize = false;
            Label52.BorderStyle = BorderStyle.None;
            Label52.Name = "Label52";
            lblDollarRH.Text = "$";
            lblDollarRH.ForeColor = Color.White;
            lblDollarRH.Size = new Size(9, 17);
            lblDollarRH.Location = new Point(520, 440);
            lblDollarRH.TabIndex = 94;
            lblDollarRH.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDollarRH.TextAlign = ContentAlignment.TopLeft;
            lblDollarRH.BackColor = Color.Transparent;
            lblDollarRH.Enabled = true;
            lblDollarRH.Cursor = Cursors.Default;
            lblDollarRH.RightToLeft = RightToLeft.No;
            lblDollarRH.UseMnemonic = true;
            lblDollarRH.Visible = true;
            lblDollarRH.AutoSize = false;
            lblDollarRH.BorderStyle = BorderStyle.None;
            lblDollarRH.Name = "lblDollarRH";
            Label50.Text = "Hrs";
            Label50.ForeColor = Color.White;
            Label50.Size = new Size(17, 17);
            Label50.Location = new Point(432, 440);
            Label50.TabIndex = 93;
            Label50.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label50.TextAlign = ContentAlignment.TopLeft;
            Label50.BackColor = Color.Transparent;
            Label50.Enabled = true;
            Label50.Cursor = Cursors.Default;
            Label50.RightToLeft = RightToLeft.No;
            Label50.UseMnemonic = true;
            Label50.Visible = true;
            Label50.AutoSize = false;
            Label50.BorderStyle = BorderStyle.None;
            Label50.Name = "Label50";
            Label26.Text = "$";
            Label26.ForeColor = Color.White;
            Label26.Size = new Size(9, 17);
            Label26.Location = new Point(848, 264);
            Label26.TabIndex = 91;
            Label26.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label26.TextAlign = ContentAlignment.TopLeft;
            Label26.BackColor = Color.Transparent;
            Label26.Enabled = true;
            Label26.Cursor = Cursors.Default;
            Label26.RightToLeft = RightToLeft.No;
            Label26.UseMnemonic = true;
            Label26.Visible = true;
            Label26.AutoSize = false;
            Label26.BorderStyle = BorderStyle.None;
            Label26.Name = "Label26";
            Label25.Text = "TOTAL :";
            Label25.ForeColor = Color.White;
            Label25.Size = new Size(41, 17);
            Label25.Location = new Point(736, 264);
            Label25.TabIndex = 90;
            Label25.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label25.TextAlign = ContentAlignment.TopLeft;
            Label25.BackColor = Color.Transparent;
            Label25.Enabled = true;
            Label25.Cursor = Cursors.Default;
            Label25.RightToLeft = RightToLeft.No;
            Label25.UseMnemonic = true;
            Label25.Visible = true;
            Label25.AutoSize = false;
            Label25.BorderStyle = BorderStyle.None;
            Label25.Name = "Label25";
            Controls.Add(fraRessourcesHumaines);
            Controls.Add(cmdDetail);
            Controls.Add(cmdFermer);
            Controls.Add(fraManutention);
            Controls.Add(fraFraisSubsistences);
            Controls.Add(cmdUnlock);
            Controls.Add(cmdLock);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalPrixRH);
            Controls.Add(lblTotalTempsRHProj);
            Controls.Add(lblTotalTempsRHConc);
            Controls.Add(lblTotalTempsRHReel);
            Controls.Add(lblTotalTempsRHSoum);
            Controls.Add(Label52);
            Controls.Add(lblDollarRH);
            Controls.Add(Label50);
            Controls.Add(Label26);
            Controls.Add(Label25);
            fraRessourcesHumaines.Controls.Add(txtTempsPrototypeConc);
            fraRessourcesHumaines.Controls.Add(txtTempsPrototypeSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsPrototypeProj);
            fraRessourcesHumaines.Controls.Add(txtTempsShippingProj);
            fraRessourcesHumaines.Controls.Add(txtTempsShippingSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsShippingConc);
            fraRessourcesHumaines.Controls.Add(txtTempsGestionConc);
            fraRessourcesHumaines.Controls.Add(txtTempsGestionSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsGestionProj);
            fraRessourcesHumaines.Controls.Add(txtTempsInstallationConc);
            fraRessourcesHumaines.Controls.Add(txtTempsFormationConc);
            fraRessourcesHumaines.Controls.Add(txtTempsDessinConc);
            fraRessourcesHumaines.Controls.Add(txtTempsTestConc);
            fraRessourcesHumaines.Controls.Add(txtTempsPeintureConc);
            fraRessourcesHumaines.Controls.Add(txtTempsAssemblageConc);
            fraRessourcesHumaines.Controls.Add(txtTempsSoudureConc);
            fraRessourcesHumaines.Controls.Add(txtTempsCoupeConc);
            fraRessourcesHumaines.Controls.Add(txtTempsMachinageConc);
            fraRessourcesHumaines.Controls.Add(txtTempsMachinageProj);
            fraRessourcesHumaines.Controls.Add(txtTempsCoupeProj);
            fraRessourcesHumaines.Controls.Add(txtTempsSoudureProj);
            fraRessourcesHumaines.Controls.Add(txtTempsAssemblageProj);
            fraRessourcesHumaines.Controls.Add(txtTempsPeintureProj);
            fraRessourcesHumaines.Controls.Add(txtTempsTestProj);
            fraRessourcesHumaines.Controls.Add(txtTempsDessinProj);
            fraRessourcesHumaines.Controls.Add(txtTempsFormationProj);
            fraRessourcesHumaines.Controls.Add(txtTempsInstallationProj);
            fraRessourcesHumaines.Controls.Add(txtTempsInstallationSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsFormationSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsDessinSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsTestSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsPeintureSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsAssemblageSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsSoudureSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsCoupeSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsMachinageSoum);
            fraRessourcesHumaines.Controls.Add(lblPrixPrototype);
            fraRessourcesHumaines.Controls.Add(lblTempsPrototypeReel);
            fraRessourcesHumaines.Controls.Add(Label60);
            fraRessourcesHumaines.Controls.Add(Label51);
            fraRessourcesHumaines.Controls.Add(Label39);
            fraRessourcesHumaines.Controls.Add(Label59);
            fraRessourcesHumaines.Controls.Add(Label55);
            fraRessourcesHumaines.Controls.Add(Label53);
            fraRessourcesHumaines.Controls.Add(lblTempsShippingReel);
            fraRessourcesHumaines.Controls.Add(lblPrixShipping);
            fraRessourcesHumaines.Controls.Add(lblPrixInstallation);
            fraRessourcesHumaines.Controls.Add(lblPrixFormation);
            fraRessourcesHumaines.Controls.Add(lblPrixDessin);
            fraRessourcesHumaines.Controls.Add(lblPrixGestion);
            fraRessourcesHumaines.Controls.Add(lblPrixTest);
            fraRessourcesHumaines.Controls.Add(lblPrixPeinture);
            fraRessourcesHumaines.Controls.Add(lblPrixAssemblage);
            fraRessourcesHumaines.Controls.Add(lblPrixSoudure);
            fraRessourcesHumaines.Controls.Add(lblPrixCoupe);
            fraRessourcesHumaines.Controls.Add(lblPrixMachinage);
            fraRessourcesHumaines.Controls.Add(lblTempsGestionReel);
            fraRessourcesHumaines.Controls.Add(Label67);
            fraRessourcesHumaines.Controls.Add(Label66);
            fraRessourcesHumaines.Controls.Add(Label65);
            fraRessourcesHumaines.Controls.Add(lblTempsInstallationReel);
            fraRessourcesHumaines.Controls.Add(lblTempsFormationReel);
            fraRessourcesHumaines.Controls.Add(lblTempsDessinReel);
            fraRessourcesHumaines.Controls.Add(lblTempsTestReel);
            fraRessourcesHumaines.Controls.Add(lblTempsPeintureReel);
            fraRessourcesHumaines.Controls.Add(lblTempsAssemblageReel);
            fraRessourcesHumaines.Controls.Add(lblTempsSoudureReel);
            fraRessourcesHumaines.Controls.Add(lblTempsCoupeReel);
            fraRessourcesHumaines.Controls.Add(lblTempsMachinageReel);
            fraRessourcesHumaines.Controls.Add(Label58);
            fraRessourcesHumaines.Controls.Add(Label57);
            fraRessourcesHumaines.Controls.Add(Label56);
            fraRessourcesHumaines.Controls.Add(Label54);
            fraRessourcesHumaines.Controls.Add(Label49);
            fraRessourcesHumaines.Controls.Add(Label47);
            fraRessourcesHumaines.Controls.Add(Label43);
            fraRessourcesHumaines.Controls.Add(Label41);
            fraRessourcesHumaines.Controls.Add(Label40);
            fraRessourcesHumaines.Controls.Add(Label32);
            fraRessourcesHumaines.Controls.Add(Label23);
            fraRessourcesHumaines.Controls.Add(Label22);
            fraRessourcesHumaines.Controls.Add(Label21);
            fraRessourcesHumaines.Controls.Add(Label20);
            fraRessourcesHumaines.Controls.Add(Label19);
            fraRessourcesHumaines.Controls.Add(Label18);
            fraRessourcesHumaines.Controls.Add(Label17);
            fraRessourcesHumaines.Controls.Add(Label16);
            fraRessourcesHumaines.Controls.Add(Label15);
            fraRessourcesHumaines.Controls.Add(Label14);
            fraRessourcesHumaines.Controls.Add(Label13);
            fraRessourcesHumaines.Controls.Add(Label12);
            fraRessourcesHumaines.Controls.Add(Label11);
            fraRessourcesHumaines.Controls.Add(Label10);
            fraRessourcesHumaines.Controls.Add(Label9);
            fraRessourcesHumaines.Controls.Add(Label8);
            fraRessourcesHumaines.Controls.Add(Label7);
            fraRessourcesHumaines.Controls.Add(Label6);
            fraRessourcesHumaines.Controls.Add(Label5);
            fraRessourcesHumaines.Controls.Add(Label4);
            fraRessourcesHumaines.Controls.Add(Label3);
            fraRessourcesHumaines.Controls.Add(Label2);
            fraRessourcesHumaines.Controls.Add(Label1);
            fraManutention.Controls.Add(txtPrixEmballage);
            fraManutention.Controls.Add(Label48);
            fraManutention.Controls.Add(Label33);
            fraManutention.Controls.Add(Label24);
            fraFraisSubsistences.Controls.Add(txtNbrePersonne);
            fraFraisSubsistences.Controls.Add(txtTempsDeplacement);
            fraFraisSubsistences.Controls.Add(txtTempsHebergement);
            fraFraisSubsistences.Controls.Add(txtTempsRepas);
            fraFraisSubsistences.Controls.Add(txtTempsUniteMobile);
            fraFraisSubsistences.Controls.Add(lblPrixUniteMobile);
            fraFraisSubsistences.Controls.Add(lblPrixDeplacement);
            fraFraisSubsistences.Controls.Add(lblPrixRepas);
            fraFraisSubsistences.Controls.Add(lblPrixHebergement);
            fraFraisSubsistences.Controls.Add(Label31);
            fraFraisSubsistences.Controls.Add(Label46);
            fraFraisSubsistences.Controls.Add(Label45);
            fraFraisSubsistences.Controls.Add(Label44);
            fraFraisSubsistences.Controls.Add(Label42);
            fraFraisSubsistences.Controls.Add(Label38);
            fraFraisSubsistences.Controls.Add(Label37);
            fraFraisSubsistences.Controls.Add(Label36);
            fraFraisSubsistences.Controls.Add(Label35);
            fraFraisSubsistences.Controls.Add(Label34);
            fraFraisSubsistences.Controls.Add(Label30);
            fraFraisSubsistences.Controls.Add(Label29);
            fraFraisSubsistences.Controls.Add(Label28);
            fraFraisSubsistences.Controls.Add(Label27);
            fraRessourcesHumaines.ResumeLayout(false);
            fraManutention.ResumeLayout(false);
            fraFraisSubsistences.ResumeLayout(false);
            Load += new EventHandler(ProjSoumMecTemps_Load);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion        
        private string m_sTauxDessin;
        private string m_sTauxCoupe;
        private string m_sTauxMachinage;
        private string m_sTauxSoudure;
        private string m_sTauxAssemblage;
        private string m_sTauxPeinture;
        private string m_sTauxTest;
        private string m_sTauxInstallation;
        private string m_sTauxFormation;
        private string m_sTauxGestion;
        private string m_sTauxShipping;
        private string m_sTauxPrototype;
        private string m_sRepas;
        private string m_sHebergement1;
        private string m_sHebergement2;
        private string m_sStandard;
        private string m_sUniteMobile;
        private string m_sTempsDessinAvant;
        private string m_sTempsCoupeAvant;
        private string m_sTempsMachinageAvant;
        private string m_sTempsSoudureAvant;
        private string m_sTempsAssemblageAvant;
        private string m_sTempsPeintureAvant;
        private string m_sTempsTestAvant;
        private string m_sTempsInstallationAvant;
        private string m_sTempsFormationAvant;
        private string m_sTempsGestionAvant;
        private string m_sTempsShippingAvant;
        private string m_sTempsPrototypeAvant;
        private string m_sTempsTotalRHAvant;
        private string m_sNoProjet;
        private string m_sNoSoumission;
        private EnumType m_eType;
        private EnumMode m_eMode;
        private bool m_bNouveauTaux; // Pour savoir si les nouveaux taux doivent être pris
        private bool m_bLocked; // Pour savoir si la section projet est barrée ou non
        private EnumType eType;
        private EnumMode eMode;
        private bool v;
        private double dblTempsPrototype;

        public ProjSoumMecTemps(string sNoProjet, string sNoSoumission, EnumType iType, EnumMode iMode, bool bNouveauTaux)
        {
            try
            {
                m_eType = iType;
                m_eMode = iMode;
                m_sNoProjet = sNoProjet;
                m_sNoSoumission = sNoSoumission;
                m_bNouveauTaux = bNouveauTaux;
                if (bNouveauTaux == true)
                {
                    InitialiserVariablesConfig();
                }
                else
                {
                    InitialiserVariablesProjSoum();
                }
                AfficherEnregistrement();
                RemplirValeursAvant();
                if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
                {
                    BarrerChamps(false);
                }
                else
                {
                    BarrerChamps(true);
                }
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "Afficher", ex);
            }
        }
        public ProjSoumMecTemps(string text, EnumType eType, EnumMode eMode, bool v)
        {
            Text = text;
            eType = eType;
            eMode = eMode;
            v = v;
        }
        private void RemplirValeursAvant()
        {
            try
            {
                m_sTempsDessinAvant = txtTempsDessinProj.Text;
                m_sTempsCoupeAvant = txtTempsCoupeProj.Text;
                m_sTempsMachinageAvant = txtTempsMachinageProj.Text;
                m_sTempsSoudureAvant = txtTempsSoudureProj.Text;
                m_sTempsAssemblageAvant = txtTempsAssemblageProj.Text;
                m_sTempsPeintureAvant = txtTempsPeintureProj.Text;
                m_sTempsTestAvant = txtTempsTestProj.Text;
                m_sTempsInstallationAvant = txtTempsInstallationProj.Text;
                m_sTempsFormationAvant = txtTempsFormationProj.Text;
                m_sTempsGestionAvant = txtTempsGestionProj.Text;
                m_sTempsShippingAvant = txtTempsShippingProj.Text;
                m_sTempsPrototypeAvant = txtTempsPrototypeProj.Text;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "RemplirValeursVant", ex);
            }
        }
        private void AfficherEnregistrement()
        {
            try
            {
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstSoum;
                ADODB.Recordset rstPunch;
                string sChamps;
                string sTable;
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    sChamps = "IDProjet";
                    sTable = "ProjetMec";
                }
                else
                {
                    sChamps = "IDSoumission";
                    sTable = "SoumissionMec";
                }
                rstProjSoum = new Recordset();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + m_sNoSoumission + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                if (!rstProjSoum.EOF & ProjSoumMec.m_bTempsDejaOuvert == false & m_eMode == EnumMode.MODE_INACTIF)
                {
                    if (m_eType == EnumType.TYPE_SOUMISSION)
                    {
                        if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull))
                        {
                            txtTempsDessinSoum.Text = (string)(rstProjSoum.Fields["TempsDessin"].Value);
                        }
                        else
                        {
                            txtTempsDessinSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsCoupe"].Value is DBNull))
                        {
                            txtTempsCoupeSoum.Text = (string)(rstProjSoum.Fields["TempsCoupe"].Value);
                        }
                        else
                        {
                            txtTempsCoupeSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsMachinage"].Value is DBNull))
                        {
                            txtTempsMachinageSoum.Text = (string)(rstProjSoum.Fields["TempsMachinage"].Value);
                        }
                        else
                        {
                            txtTempsMachinageSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsSoudure"].Value is DBNull))
                        {
                            txtTempsSoudureSoum.Text = (string)(rstProjSoum.Fields["TempsSoudure"].Value);
                        }
                        else
                        {
                            txtTempsSoudureSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull))
                        {
                            txtTempsAssemblageSoum.Text = (string)(rstProjSoum.Fields["TempsAssemblage"].Value);
                        }
                        else
                        {
                            txtTempsAssemblageSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsPeinture"].Value is DBNull))
                        {
                            txtTempsPeintureSoum.Text = (string)(rstProjSoum.Fields["TempsPeinture"].Value);
                        }
                        else
                        {
                            txtTempsPeintureSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull))
                        {
                            txtTempsTestSoum.Text = (string)(rstProjSoum.Fields["TempsTest"].Value);
                        }
                        else
                        {
                            txtTempsTestSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull))
                        {
                            txtTempsInstallationSoum.Text = (string)(rstProjSoum.Fields["TempsInstallation"].Value);
                        }
                        else
                        {
                            txtTempsInstallationSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull))
                        {
                            txtTempsFormationSoum.Text = (string)(rstProjSoum.Fields["TempsFormation"].Value);
                        }
                        else
                        {
                            txtTempsFormationSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull))
                        {
                            txtTempsGestionSoum.Text = (string)(rstProjSoum.Fields["TempsGestion"].Value);
                        }
                        else
                        {
                            txtTempsGestionSoum.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull))
                        {
                            txtTempsShippingSoum.Text = (string)(rstProjSoum.Fields["TempsShipping"].Value);
                        }
                        else
                        {
                            txtTempsShippingSoum.Text = "0.00";
                        }
                        txtTempsPrototypeSoum.Text = "0.00";
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(m_sNoSoumission))
                        {
                            rstSoum = new Recordset();
                            rstSoum.Open("SELECT * FROM SoumissionMec WHERE IDSoumission = '" + m_sNoSoumission + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (!rstSoum.EOF)
                            {
                                if (!(rstSoum.Fields["TempsDessin"].Value is DBNull))
                                {
                                    txtTempsDessinSoum.Text = (string)(rstSoum.Fields["TempsDessin"].Value);
                                }
                                else
                                {
                                    txtTempsDessinSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsCoupe"].Value is DBNull))
                                {
                                    txtTempsCoupeSoum.Text = (string)(rstSoum.Fields["TempsCoupe"].Value);
                                }
                                else
                                {
                                    txtTempsCoupeSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsMachinage"].Value is DBNull))
                                {
                                    txtTempsMachinageSoum.Text = (string)(rstSoum.Fields["TempsMachinage"].Value);
                                }
                                else
                                {
                                    txtTempsMachinageSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsSoudure"].Value is DBNull))
                                {
                                    txtTempsSoudureSoum.Text = (string)(rstSoum.Fields["TempsSoudure"].Value);
                                }
                                else
                                {
                                    txtTempsSoudureSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsAssemblage"].Value is DBNull))
                                {
                                    txtTempsAssemblageSoum.Text = (string)(rstSoum.Fields["TempsAssemblage"].Value);
                                }
                                else
                                {
                                    txtTempsAssemblageSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsPeinture"].Value is DBNull))
                                {
                                    txtTempsPeintureSoum.Text = (string)(rstSoum.Fields["TempsPeinture"].Value);
                                }
                                else
                                {
                                    txtTempsPeintureSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsTest"].Value is DBNull))
                                {
                                    txtTempsTestSoum.Text = (string)(rstSoum.Fields["TempsTest"].Value);
                                }
                                else
                                {
                                    txtTempsTestSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsInstallation"].Value is DBNull))
                                {
                                    txtTempsInstallationSoum.Text = (string)(rstSoum.Fields["TempsInstallation"].Value);
                                }
                                else
                                {
                                    txtTempsInstallationSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsFormation"].Value is DBNull))
                                {
                                    txtTempsFormationSoum.Text = (string)(rstSoum.Fields["TempsFormation"].Value);
                                }
                                else
                                {
                                    txtTempsFormationSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsGestion"].Value is DBNull))
                                {
                                    txtTempsGestionSoum.Text = (string)(rstSoum.Fields["TempsGestion"].Value);
                                }
                                else
                                {
                                    txtTempsGestionSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsShipping"].Value is DBNull))
                                {
                                    txtTempsShippingSoum.Text = (string)(rstSoum.Fields["TempsShipping"].Value);
                                }
                                else
                                {
                                    txtTempsShippingSoum.Text = "0.00";
                                }
                                txtTempsPrototypeSoum.Text = "0.00";
                            }
                            else
                            {
                                txtTempsDessinSoum.Text = 0.ToString();
                                txtTempsCoupeSoum.Text = 0.ToString();
                                txtTempsMachinageSoum.Text = 0.ToString();
                                txtTempsSoudureSoum.Text = 0.ToString();
                                txtTempsAssemblageSoum.Text = 0.ToString();
                                txtTempsPeintureSoum.Text = 0.ToString();
                                txtTempsTestSoum.Text = 0.ToString();
                                txtTempsInstallationSoum.Text = 0.ToString();
                                txtTempsFormationSoum.Text = 0.ToString();
                                txtTempsGestionSoum.Text = 0.ToString();
                                txtTempsShippingSoum.Text = 0.ToString();
                                txtTempsPrototypeSoum.Text = 0.ToString();
                            }
                            rstSoum.Close();
                            // Object rstSoum peut ne pas etre détruit avant la mise en corbeille
                            rstSoum = null;
                        }
                        else
                        {
                            txtTempsDessinSoum.Text = 0.ToString();
                            txtTempsCoupeSoum.Text = 0.ToString();
                            txtTempsMachinageSoum.Text = 0.ToString();
                            txtTempsSoudureSoum.Text = 0.ToString();
                            txtTempsAssemblageSoum.Text = 0.ToString();
                            txtTempsPeintureSoum.Text = 0.ToString();
                            txtTempsTestSoum.Text = 0.ToString();
                            txtTempsInstallationSoum.Text = 0.ToString();
                            txtTempsFormationSoum.Text = 0.ToString();
                            txtTempsGestionSoum.Text = 0.ToString();
                            txtTempsShippingSoum.Text = 0.ToString();
                            txtTempsPrototypeSoum.Text = 0.ToString();
                        }
                        m_bLocked = Conversions.ToBoolean(rstProjSoum.Fields["TempsProjBarré"].Value);
                        if (!(rstProjSoum.Fields["TempsDessinProj"].Value is DBNull))
                        {
                            txtTempsDessinProj.Text = (string)(rstProjSoum.Fields["TempsDessinProj"].Value);
                        }
                        else
                        {
                            txtTempsDessinProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsCoupeProj"].Value is DBNull))
                        {
                            txtTempsCoupeProj.Text = (string)(rstProjSoum.Fields["TempsCoupeProj"].Value);
                        }
                        else
                        {
                            txtTempsCoupeProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsMachinageProj"].Value is DBNull))
                        {
                            txtTempsMachinageProj.Text = (string)(rstProjSoum.Fields["TempsMachinageProj"].Value);
                        }
                        else
                        {
                            txtTempsMachinageProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsSoudureProj"].Value is DBNull))
                        {
                            txtTempsSoudureProj.Text = (string)(rstProjSoum.Fields["TempsSoudureProj"].Value);
                        }
                        else
                        {
                            txtTempsSoudureProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsAssemblageProj"].Value is DBNull))
                        {
                            txtTempsAssemblageProj.Text = (string)(rstProjSoum.Fields["TempsAssemblageProj"].Value);
                        }
                        else
                        {
                            txtTempsAssemblageProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsPeintureProj"].Value is DBNull))
                        {
                            txtTempsPeintureProj.Text = (string)(rstProjSoum.Fields["TempsPeintureProj"].Value);
                        }
                        else
                        {
                            txtTempsPeintureProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsTestProj"].Value is DBNull))
                        {
                            txtTempsTestProj.Text = (string)(rstProjSoum.Fields["TempsTestProj"].Value);
                        }
                        else
                        {
                            txtTempsTestProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsInstallationProj"].Value is DBNull))
                        {
                            txtTempsInstallationProj.Text = (string)(rstProjSoum.Fields["TempsInstallationProj"].Value);
                        }
                        else
                        {
                            txtTempsInstallationProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsFormationProj"].Value is DBNull))
                        {
                            txtTempsFormationProj.Text = (string)(rstProjSoum.Fields["TempsFormationProj"].Value);
                        }
                        else
                        {
                            txtTempsFormationProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsGestionProj"].Value is DBNull))
                        {
                            txtTempsGestionProj.Text = (string)(rstProjSoum.Fields["TempsGestionProj"].Value);
                        }
                        else
                        {
                            txtTempsGestionProj.Text = "0.00";
                        }
                        if (!(rstProjSoum.Fields["TempsShippingProj"].Value is DBNull))
                        {
                            txtTempsShippingProj.Text = (string)(rstProjSoum.Fields["TempsShippingProj"].Value);
                        }
                        else
                        {
                            txtTempsShippingProj.Text = "0.00";
                        }
                        txtTempsPrototypeProj.Text = "0.00";
                        if (m_bLocked == false)
                        {
                            txtTempsDessinConc.Text = string.Empty;
                            txtTempsCoupeConc.Text = string.Empty;
                            txtTempsMachinageConc.Text = string.Empty;
                            txtTempsSoudureConc.Text = string.Empty;
                            txtTempsAssemblageConc.Text = string.Empty;
                            txtTempsPeintureConc.Text = string.Empty;
                            txtTempsTestConc.Text = string.Empty;
                            txtTempsInstallationConc.Text = string.Empty;
                            txtTempsFormationConc.Text = string.Empty;
                            txtTempsGestionConc.Text = string.Empty;
                            txtTempsShippingConc.Text = string.Empty;
                            txtTempsPrototypeConc.Text = string.Empty;
                        }
                        else
                        {
                            if (!(rstProjSoum.Fields["TempsDessinConc"].Value is DBNull))
                            {
                                txtTempsDessinConc.Text = (string)(rstProjSoum.Fields["TempsDessinConc"].Value);
                            }
                            else
                            {
                                txtTempsDessinConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsCoupeConc"].Value is DBNull))
                            {
                                txtTempsCoupeConc.Text = (string)(rstProjSoum.Fields["TempsCoupeConc"].Value);
                            }
                            else
                            {
                                txtTempsCoupeConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsMachinageConc"].Value is DBNull))
                            {
                                txtTempsMachinageConc.Text = (string)(rstProjSoum.Fields["TempsMachinageConc"].Value);
                            }
                            else
                            {
                                txtTempsMachinageConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsSoudureConc"].Value is DBNull))
                            {
                                txtTempsSoudureConc.Text = (string)(rstProjSoum.Fields["TempsSoudureConc"].Value);
                            }
                            else
                            {
                                txtTempsSoudureConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsAssemblageConc"].Value is DBNull))
                            {
                                txtTempsAssemblageConc.Text = (string)(rstProjSoum.Fields["TempsAssemblageConc"].Value);
                            }
                            else
                            {
                                txtTempsAssemblageConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsPeintureConc"].Value is DBNull))
                            {
                                txtTempsPeintureConc.Text = (string)(rstProjSoum.Fields["TempsPeintureConc"].Value);
                            }
                            else
                            {
                                txtTempsPeintureConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsTestConc"].Value is DBNull))
                            {
                                txtTempsTestConc.Text = (string)(rstProjSoum.Fields["TempsTestConc"].Value);
                            }
                            else
                            {
                                txtTempsTestConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsInstallationConc"].Value is DBNull))
                            {
                                txtTempsInstallationConc.Text = (string)(rstProjSoum.Fields["TempsInstallationConc"].Value);
                            }
                            else
                            {
                                txtTempsInstallationConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsFormationConc"].Value is DBNull))
                            {
                                txtTempsFormationConc.Text = (string)(rstProjSoum.Fields["TempsFormationConc"].Value);
                            }
                            else
                            {
                                txtTempsFormationConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsGestionConc"].Value is DBNull))
                            {
                                txtTempsGestionConc.Text = (string)(rstProjSoum.Fields["TempsGestionConc"].Value);
                            }
                            else
                            {
                                txtTempsGestionConc.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsShippingConc"].Value is DBNull))
                            {
                                txtTempsShippingConc.Text = (string)(rstProjSoum.Fields["TempsShippingConc"].Value);
                            }
                            else
                            {
                                txtTempsShippingConc.Text = "0.00";
                            }
                            txtTempsPrototypeConc.Text = "0.00";
                        }
                    }
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        AfficherTempsReels();
                        CalculerTotalArgent();
                    }
                    if (!(rstProjSoum.Fields["NbrePersonne"].Value is DBNull))
                    {
                        txtNbrePersonne.Text = (string)(rstProjSoum.Fields["NbrePersonne"].Value);
                    }
                    else
                    {
                        txtNbrePersonne.Text = "0.00";
                    }
                    if (!(rstProjSoum.Fields["TempsHebergement"].Value is DBNull))
                    {
                        txtTempsHebergement.Text = (string)(rstProjSoum.Fields["TempsHebergement"].Value);
                    }
                    else
                    {
                        txtTempsHebergement.Text = "0.00";
                    }
                    if (!(rstProjSoum.Fields["TempsRepas"].Value is DBNull))
                    {
                        txtTempsRepas.Text = (string)(rstProjSoum.Fields["TempsRepas"].Value);
                    }
                    else
                    {
                        txtTempsRepas.Text = "0.00";
                    }
                    if (!(rstProjSoum.Fields["TempsTransport"].Value is DBNull))
                    {
                        txtTempsDeplacement.Text = (string)(rstProjSoum.Fields["TempsTransport"].Value);
                    }
                    else
                    {
                        txtTempsDeplacement.Text = "0.00";
                    }
                    if (!(rstProjSoum.Fields["TempsUniteMobile"].Value is DBNull))
                    {
                        txtTempsUniteMobile.Text = (string)(rstProjSoum.Fields["TempsUniteMobile"].Value);
                    }
                    else
                    {
                        txtTempsUniteMobile.Text = "0.00";
                    }
                    txtPrixEmballage.Text = (string)(rstProjSoum.Fields["PrixEmballage"].Value);
                }
                else
                {
                    if (m_eType == EnumType.TYPE_SOUMISSION)
                    {
                        txtTempsDessinSoum.Text = ProjSoumMec.m_sTempsDessin;
                        txtTempsCoupeSoum.Text = ProjSoumMec.m_sTempsCoupe;
                        txtTempsMachinageSoum.Text = ProjSoumMec.m_sTempsMachinage;
                        txtTempsSoudureSoum.Text = ProjSoumMec.m_sTempsSoudure;
                        txtTempsAssemblageSoum.Text = ProjSoumMec.m_sTempsAssemblage;
                        txtTempsPeintureSoum.Text = ProjSoumMec.m_sTempsPeinture;
                        txtTempsTestSoum.Text = ProjSoumMec.m_sTempsTest;
                        txtTempsInstallationSoum.Text = ProjSoumMec.m_sTempsInstallation;
                        txtTempsFormationSoum.Text = ProjSoumMec.m_sTempsFormation;
                        txtTempsGestionSoum.Text = ProjSoumMec.m_sTempsGestion;
                        txtTempsShippingSoum.Text = ProjSoumMec.m_sTempsShipping;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(m_sNoSoumission))
                        {
                            rstSoum = new Recordset();
                            rstSoum.Open("SELECT * FROM SoumissionMec WHERE IDSoumission = '" + m_sNoSoumission + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (!rstSoum.EOF)
                            {
                                if (!(rstSoum.Fields["TempsDessin"].Value is DBNull))
                                {
                                    txtTempsDessinSoum.Text = (string)(rstSoum.Fields["TempsDessin"].Value);
                                }
                                else
                                {
                                    txtTempsDessinSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsCoupe"].Value is DBNull))
                                {
                                    txtTempsCoupeSoum.Text = (string)(rstSoum.Fields["TempsCoupe"].Value);
                                }
                                else
                                {
                                    txtTempsCoupeSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsMachinage"].Value is DBNull))
                                {
                                    txtTempsMachinageSoum.Text = (string)(rstSoum.Fields["TempsMachinage"].Value);
                                }
                                else
                                {
                                    txtTempsMachinageSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsSoudure"].Value is DBNull))
                                {
                                    txtTempsSoudureSoum.Text = (string)(rstSoum.Fields["TempsSoudure"].Value);
                                }
                                else
                                {
                                    txtTempsSoudureSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsAssemblage"].Value is DBNull))
                                {
                                    txtTempsAssemblageSoum.Text = (string)(rstSoum.Fields["TempsAssemblage"].Value);
                                }
                                else
                                {
                                    txtTempsAssemblageSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsPeinture"].Value is DBNull))
                                {
                                    txtTempsPeintureSoum.Text = (string)(rstSoum.Fields["TempsPeinture"].Value);
                                }
                                else
                                {
                                    txtTempsPeintureSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsTest"].Value is DBNull))
                                {
                                    txtTempsTestSoum.Text = (string)(rstSoum.Fields["TempsTest"].Value);
                                }
                                else
                                {
                                    txtTempsTestSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsInstallation"].Value is DBNull))
                                {
                                    txtTempsInstallationSoum.Text = (string)(rstSoum.Fields["TempsInstallation"].Value);
                                }
                                else
                                {
                                    txtTempsInstallationSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsFormation"].Value is DBNull))
                                {
                                    txtTempsFormationSoum.Text = (string)(rstSoum.Fields["TempsFormation"].Value);
                                }
                                else
                                {
                                    txtTempsFormationSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsGestion"].Value is DBNull))
                                {
                                    txtTempsGestionSoum.Text = (string)(rstSoum.Fields["TempsGestion"].Value);
                                }
                                else
                                {
                                    txtTempsGestionSoum.Text = "0.00";
                                }
                                if (!(rstSoum.Fields["TempsShipping"].Value is DBNull))
                                {
                                    txtTempsShippingSoum.Text = (string)(rstSoum.Fields["TempsShipping"].Value);
                                }
                                else
                                {
                                    txtTempsShippingSoum.Text = "0.00";
                                }
                                txtTempsPrototypeSoum.Text = "0.00";
                            }
                            else
                            {
                                txtTempsDessinSoum.Text = 0.ToString();
                                txtTempsCoupeSoum.Text = 0.ToString();
                                txtTempsMachinageSoum.Text = 0.ToString();
                                txtTempsSoudureSoum.Text = 0.ToString();
                                txtTempsAssemblageSoum.Text = 0.ToString();
                                txtTempsPeintureSoum.Text = 0.ToString();
                                txtTempsTestSoum.Text = 0.ToString();
                                txtTempsInstallationSoum.Text = 0.ToString();
                                txtTempsFormationSoum.Text = 0.ToString();
                                txtTempsGestionSoum.Text = 0.ToString();
                                txtTempsShippingSoum.Text = 0.ToString();
                                txtTempsPrototypeSoum.Text = 0.ToString();
                            }
                            rstSoum.Close();
                            rstSoum = null;
                        }
                        else
                        {
                            txtTempsDessinSoum.Text = 0.ToString();
                            txtTempsCoupeSoum.Text = 0.ToString();
                            txtTempsMachinageSoum.Text = 0.ToString();
                            txtTempsSoudureSoum.Text = 0.ToString();
                            txtTempsAssemblageSoum.Text = 0.ToString();
                            txtTempsPeintureSoum.Text = 0.ToString();
                            txtTempsTestSoum.Text = 0.ToString();
                            txtTempsInstallationSoum.Text = 0.ToString();
                            txtTempsFormationSoum.Text = 0.ToString();
                            txtTempsGestionSoum.Text = 0.ToString();
                            txtTempsShippingSoum.Text = 0.ToString();
                            txtTempsPrototypeSoum.Text = 0.ToString();
                        }
                        m_bLocked = ProjSoumMec.m_bTempsProjLock;
                        if (m_bLocked == true)
                        {
                            if (!(rstProjSoum.Fields["TempsDessinProj"].Value is DBNull))
                            {
                                txtTempsDessinProj.Text = (string)(rstProjSoum.Fields["TempsDessinProj"].Value);
                            }
                            else
                            {
                                txtTempsDessinProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsCoupeProj"].Value is DBNull))
                            {
                                txtTempsCoupeProj.Text = (string)(rstProjSoum.Fields["TempsCoupeProj"].Value);
                            }
                            else
                            {
                                txtTempsCoupeProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsMachinageProj"].Value is DBNull))
                            {
                                txtTempsMachinageProj.Text = (string)(rstProjSoum.Fields["TempsMachinageProj"].Value);
                            }
                            else
                            {
                                txtTempsMachinageProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsSoudureProj"].Value is DBNull))
                            {
                                txtTempsSoudureProj.Text = (string)(rstProjSoum.Fields["TempsSoudureProj"].Value);
                            }
                            else
                            {
                                txtTempsSoudureProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsAssemblageProj"].Value is DBNull))
                            {
                                txtTempsAssemblageProj.Text = (string)(rstProjSoum.Fields["TempsAssemblageProj"].Value);
                            }
                            else
                            {
                                txtTempsAssemblageProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsPeintureProj"].Value is DBNull))
                            {
                                txtTempsPeintureProj.Text = (string)(rstProjSoum.Fields["TempsPeintureProj"].Value);
                            }
                            else
                            {
                                txtTempsPeintureProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsTestProj"].Value is DBNull))
                            {
                                txtTempsTestProj.Text = (string)(rstProjSoum.Fields["TempsTestProj"].Value);
                            }
                            else
                            {
                                txtTempsTestProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsInstallationProj"].Value is DBNull))
                            {
                                txtTempsInstallationProj.Text = (string)(rstProjSoum.Fields["TempsInstallationProj"].Value);
                            }
                            else
                            {
                                txtTempsInstallationProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsFormationProj"].Value is DBNull))
                            {
                                txtTempsFormationProj.Text = (string)(rstProjSoum.Fields["TempsFormationProj"].Value);
                            }
                            else
                            {
                                txtTempsFormationProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsGestionProj"].Value is DBNull))
                            {
                                txtTempsGestionProj.Text = (string)(rstProjSoum.Fields["TempsGestionProj"].Value);
                            }
                            else
                            {
                                txtTempsGestionProj.Text = "0.00";
                            }
                            if (!(rstProjSoum.Fields["TempsShippingProj"].Value is DBNull))
                            {
                                txtTempsShippingProj.Text = (string)(rstProjSoum.Fields["TempsShippingProj"].Value);
                            }
                            else
                            {
                                txtTempsShippingProj.Text = "0.00";
                            }
                            txtTempsPrototypeProj.Text = "0.00";
                            txtTempsDessinConc.Text = ProjSoumMec.m_sTempsDessinConc;
                            txtTempsCoupeConc.Text = ProjSoumMec.m_sTempsCoupeConc;
                            txtTempsMachinageConc.Text = ProjSoumMec.m_sTempsMachinageConc;
                            txtTempsSoudureConc.Text = ProjSoumMec.m_sTempsSoudureConc;
                            txtTempsAssemblageConc.Text = ProjSoumMec.m_sTempsAssemblageConc;
                            txtTempsPeintureConc.Text = ProjSoumMec.m_sTempsPeintureConc;
                            txtTempsTestConc.Text = ProjSoumMec.m_sTempsTestConc;
                            txtTempsInstallationConc.Text = ProjSoumMec.m_sTempsInstallationConc;
                            txtTempsFormationConc.Text = ProjSoumMec.m_sTempsFormationConc;
                            txtTempsGestionConc.Text = ProjSoumMec.m_sTempsGestionConc;
                            txtTempsShippingConc.Text = ProjSoumMec.m_sTempsShippingConc;
                            txtTempsPrototypeConc.Text = ProjSoumMec.m_sTempsPrototypeConc;
                        }
                        else
                        {
                            txtTempsDessinProj.Text = ProjSoumMec.m_sTempsDessinProj;
                            txtTempsCoupeProj.Text = ProjSoumMec.m_sTempsCoupeProj;
                            txtTempsMachinageProj.Text = ProjSoumMec.m_sTempsMachinageProj;
                            txtTempsSoudureProj.Text = ProjSoumMec.m_sTempsSoudureProj;
                            txtTempsAssemblageProj.Text = ProjSoumMec.m_sTempsAssemblageProj;
                            txtTempsPeintureProj.Text = ProjSoumMec.m_sTempsPeintureProj;
                            txtTempsTestProj.Text = ProjSoumMec.m_sTempsTestProj;
                            txtTempsInstallationProj.Text = ProjSoumMec.m_sTempsInstallationProj;
                            txtTempsFormationProj.Text = ProjSoumMec.m_sTempsFormationProj;
                            txtTempsGestionProj.Text = ProjSoumMec.m_sTempsGestionProj;
                            txtTempsShippingProj.Text = ProjSoumMec.m_sTempsShippingProj;
                            txtTempsPrototypeProj.Text = ProjSoumMec.m_sTempsPrototypeProj;
                        }
                    }
                    if (m_eType == EnumType.TYPE_PROJET)
                    {
                        AfficherTempsReels();
                        CalculerTotalArgent();
                    }
                    txtNbrePersonne.Text = ProjSoumMec.m_sNbrePersonne;
                    txtTempsHebergement.Text = ProjSoumMec.m_sTempsHebergement;
                    txtTempsRepas.Text = ProjSoumMec.m_sTempsRepas;
                    txtTempsDeplacement.Text = ProjSoumMec.m_sTempsTransport;
                    txtTempsUniteMobile.Text = ProjSoumMec.m_sTempsUniteMobile;
                    txtPrixEmballage.Text = ProjSoumMec.m_sPrixEmballage;
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "AfficherEnregistrement", ex);
            }
        }
        private void AfficherTempsReels()
        {
            try
            {
                ADODB.Recordset rstPunch;
                string sDateDebut;
                string sDateFin;
                string sTotal;
                string sFilterNoProjet;
                sDateDebut = "TIMESERIAL(Left(Punch.HeureDébut,2),RIGHT(Punch.HeureDébut,2),0)";
                sDateFin = "TIMESERIAL(Left(Punch.HeureFin,2),RIGHT(Punch.HeureFin,2),0)";
                sTotal = "(SUM(" + sDateFin + " - " + sDateDebut + ")* 24) As Total";
                if (Droite(m_sNoProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(m_sNoProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + m_sNoProjet + "'";
                }
                rstPunch = new Recordset();
                rstPunch.Open("SELECT Type, " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null GROUP BY Type", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                lblTempsDessinReel.Text = "0.00";
                lblTempsCoupeReel.Text = "0.00";
                lblTempsMachinageReel.Text = "0.00";
                lblTempsSoudureReel.Text = "0.00";
                lblTempsAssemblageReel.Text = "0.00";
                lblTempsPeintureReel.Text = "0.00";
                lblTempsTestReel.Text = "0.00";
                lblTempsInstallationReel.Text = "0.00";
                lblTempsFormationReel.Text = "0.00";
                lblTempsGestionReel.Text = "0.00";
                lblTempsShippingReel.Text = "0.00";
                lblTempsPrototypeReel.Text = "0.00";
                while (!rstPunch.EOF)
                {
                    if (!(rstPunch.Fields["Total"].Value is DBNull))
                    {
                        switch (rstPunch.Fields["Type"].Value)
                        {
                            case "Dessin":
                                {
                                    lblTempsDessinReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Coupe":
                                {
                                    lblTempsCoupeReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Machinage":
                                {
                                    lblTempsMachinageReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Soudure":
                                {
                                    lblTempsSoudureReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Assemblage":
                                {
                                    lblTempsAssemblageReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Peinture":
                                {
                                    lblTempsPeintureReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Test":
                                {
                                    lblTempsTestReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Installation":
                                {
                                    lblTempsInstallationReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Formation":
                                {
                                    lblTempsFormationReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Gestion":
                                {
                                    lblTempsGestionReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Shipping":
                                {
                                    lblTempsShippingReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "Prototypage-Dévelloppement expérimental":
                                {
                                    lblTempsPrototypeReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                        }
                    }
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                rstPunch.Open("SELECT " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " AND HeureFin is not null AND HeureDébut is not null", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!(rstPunch.Fields["Total"].Value is DBNull))
                {
                    lblTotalTempsRHReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                }
                else
                {
                    lblTotalTempsRHReel.Text = "0.00";
                }
                rstPunch.Close();
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "AfficherTempsReels", ex);
            }
        }
        private void CalculerTotalArgent()
        {
            try
            {
                if (Information.IsNumeric(lblTempsDessinReel.Text))
                {
                    lblPrixDessin.Text = Math.Round(double.Parse(lblTempsDessinReel.Text) * double.Parse(m_sTauxDessin), 2).ToString();
                }
                else
                {
                    lblPrixDessin.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsCoupeReel.Text))
                {
                    lblPrixCoupe.Text = Math.Round(double.Parse(lblTempsCoupeReel.Text) * double.Parse(m_sTauxCoupe), 2).ToString();
                }
                else
                {
                    lblPrixCoupe.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsMachinageReel.Text))
                {
                    lblPrixMachinage.Text = Math.Round(double.Parse(lblTempsMachinageReel.Text) * double.Parse(m_sTauxMachinage), 2).ToString();
                }
                else
                {
                    lblPrixMachinage.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsSoudureReel.Text))
                {
                    lblPrixSoudure.Text = Math.Round(double.Parse(lblTempsSoudureReel.Text) * double.Parse(m_sTauxSoudure), 2).ToString();
                }
                else
                {
                    lblPrixSoudure.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsAssemblageReel.Text))
                {
                    lblPrixAssemblage.Text = Math.Round(double.Parse(lblTempsAssemblageReel.Text) * double.Parse(m_sTauxAssemblage), 2).ToString();
                }
                else
                {
                    lblPrixAssemblage.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsPeintureReel.Text))
                {
                    lblPrixPeinture.Text = Math.Round(double.Parse(lblTempsPeintureReel.Text) * double.Parse(m_sTauxPeinture), 2).ToString();
                }
                else
                {
                    lblPrixPeinture.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsTestReel.Text))
                {
                    lblPrixTest.Text = Math.Round(double.Parse(lblTempsTestReel.Text) * double.Parse(m_sTauxTest), 2).ToString();
                }
                else
                {
                    lblPrixTest.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsInstallationReel.Text))
                {
                    lblPrixInstallation.Text = Math.Round(double.Parse(lblTempsInstallationReel.Text) * double.Parse(m_sTauxInstallation), 2).ToString();
                }
                else
                {
                    lblPrixInstallation.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsFormationReel.Text))
                {
                    lblPrixFormation.Text = Math.Round(double.Parse(lblTempsFormationReel.Text) * double.Parse(m_sTauxFormation), 2).ToString();
                }
                else
                {
                    lblPrixFormation.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsGestionReel.Text))
                {
                    lblPrixGestion.Text = Math.Round(double.Parse(lblTempsGestionReel.Text) * double.Parse(m_sTauxGestion), 2).ToString();
                }
                else
                {
                    lblPrixGestion.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsShippingReel.Text))
                {
                    lblPrixShipping.Text = Math.Round(double.Parse(lblTempsShippingReel.Text) * double.Parse(m_sTauxShipping), 2).ToString();
                }
                else
                {
                    lblPrixShipping.Text = 0.ToString();
                }
                if (Information.IsNumeric(lblTempsPrototypeReel.Text))
                {
                a281:
                    ;
                    lblPrixPrototype.Text = Math.Round(double.Parse(lblTempsPrototypeReel.Text) * double.Parse(m_sTauxGestion), 2).ToString();
                a282:
                    ;
                }
                else
                {
                a283:
                    ;
                    lblPrixPrototype.Text = 0.ToString();
                a284:
                    ;
                }
                CalculerTotal();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "CalculerTotalArgent", ex);
            }
        }
        private void BarrerChamps(bool bLocked)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    txtTempsDessinSoum.Enabled = true;
                    txtTempsCoupeSoum.Enabled = true;
                    txtTempsMachinageSoum.Enabled = true;
                    txtTempsSoudureSoum.Enabled = true;
                    txtTempsAssemblageSoum.Enabled = true;
                    txtTempsPeintureSoum.Enabled = true;
                    txtTempsTestSoum.Enabled = true;
                    txtTempsInstallationSoum.Enabled = true;
                    txtTempsFormationSoum.Enabled = true;
                    txtTempsGestionSoum.Enabled = true;
                    txtTempsShippingSoum.Enabled = true;
                    txtTempsPrototypeSoum.Enabled = true;
                    txtTempsDessinSoum.ReadOnly = bLocked;
                    txtTempsCoupeSoum.ReadOnly = bLocked;
                    txtTempsMachinageSoum.ReadOnly = bLocked;
                    txtTempsSoudureSoum.ReadOnly = bLocked;
                    txtTempsAssemblageSoum.ReadOnly = bLocked;
                    txtTempsPeintureSoum.ReadOnly = bLocked;
                    txtTempsTestSoum.ReadOnly = bLocked;
                    txtTempsInstallationSoum.ReadOnly = bLocked;
                    txtTempsFormationSoum.ReadOnly = bLocked;
                    txtTempsGestionSoum.ReadOnly = bLocked;
                    txtTempsShippingSoum.ReadOnly = bLocked;
                    txtTempsPrototypeSoum.ReadOnly = bLocked;

                    txtTempsDessinProj.Enabled = false;
                    txtTempsCoupeProj.Enabled = false;
                    txtTempsMachinageProj.Enabled = false;
                    txtTempsSoudureProj.Enabled = false;
                    txtTempsAssemblageProj.Enabled = false;
                    txtTempsPeintureProj.Enabled = false;
                    txtTempsTestProj.Enabled = false;
                    txtTempsInstallationProj.Enabled = false;
                    txtTempsFormationProj.Enabled = false;
                    txtTempsGestionProj.Enabled = false;
                    txtTempsShippingProj.Enabled = false;
                    txtTempsPrototypeProj.Enabled = false;
                    txtTempsDessinConc.Enabled = false;
                    txtTempsCoupeConc.Enabled = false;
                    txtTempsMachinageConc.Enabled = false;
                    txtTempsSoudureConc.Enabled = false;
                    txtTempsAssemblageConc.Enabled = false;
                    txtTempsPeintureConc.Enabled = false;
                    txtTempsTestConc.Enabled = false;
                    txtTempsInstallationConc.Enabled = false;
                    txtTempsFormationConc.Enabled = false;
                    txtTempsGestionConc.Enabled = false;
                    txtTempsShippingConc.Enabled = false;
                    txtTempsPrototypeConc.Enabled = false;
                    cmdLock.Visible = false;
                    cmdUnlock.Visible = false;
                }
                else if (m_bLocked == false)
                {
                    txtTempsDessinProj.Enabled = true;
                    txtTempsCoupeProj.Enabled = true;
                    txtTempsMachinageProj.Enabled = true;
                    txtTempsSoudureProj.Enabled = true;
                    txtTempsAssemblageProj.Enabled = true;
                    txtTempsPeintureProj.Enabled = true;
                    txtTempsTestProj.Enabled = true;
                    txtTempsInstallationProj.Enabled = true;
                    txtTempsFormationProj.Enabled = true;
                    txtTempsGestionProj.Enabled = true;
                    txtTempsShippingProj.Enabled = true;
                    txtTempsPrototypeProj.Enabled = true;
                    txtTempsDessinProj.ReadOnly = bLocked;
                    txtTempsCoupeProj.ReadOnly = bLocked;
                    txtTempsMachinageProj.ReadOnly = bLocked;
                    txtTempsSoudureProj.ReadOnly = bLocked;
                    txtTempsAssemblageProj.ReadOnly = bLocked;
                    txtTempsPeintureProj.ReadOnly = bLocked;
                    txtTempsTestProj.ReadOnly = bLocked;
                    txtTempsInstallationProj.ReadOnly = bLocked;
                    txtTempsFormationProj.ReadOnly = bLocked;
                    txtTempsGestionProj.ReadOnly = bLocked;
                    txtTempsShippingProj.ReadOnly = bLocked;
                a361:
                    ;
                    txtTempsPrototypeProj.ReadOnly = bLocked;
                    txtTempsDessinSoum.Enabled = false;
                    txtTempsCoupeSoum.Enabled = false;
                    txtTempsMachinageSoum.Enabled = false;
                    txtTempsSoudureSoum.Enabled = false;
                    txtTempsAssemblageSoum.Enabled = false;
                    txtTempsPeintureSoum.Enabled = false;
                    txtTempsTestSoum.Enabled = false;
                    txtTempsInstallationSoum.Enabled = false;
                    txtTempsFormationSoum.Enabled = false;
                    txtTempsGestionSoum.Enabled = false;
                    txtTempsShippingSoum.Enabled = false;
                a416:
                    ;
                    txtTempsPrototypeSoum.Enabled = false;

                    txtTempsDessinConc.Enabled = false;
                    txtTempsCoupeConc.Enabled = false;
                    txtTempsMachinageConc.Enabled = false;
                    txtTempsSoudureConc.Enabled = false;
                    txtTempsAssemblageConc.Enabled = false;
                    txtTempsPeintureConc.Enabled = false;
                    txtTempsTestConc.Enabled = false;
                    txtTempsInstallationConc.Enabled = false;
                    txtTempsFormationConc.Enabled = false;
                    txtTempsGestionConc.Enabled = false;
                    txtTempsShippingConc.Enabled = false;
                a471:
                    ;
                    txtTempsPrototypeConc.Enabled = false;
                    if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
                    {
                        if (g_bVerrouillageTempsProjet == true)
                        {
                            cmdLock.Visible = true;
                        }
                        else
                        {
                            cmdLock.Visible = false;
                        }
                        cmdUnlock.Visible = false;
                    }
                    else
                    {
                        cmdLock.Visible = false;
                        cmdUnlock.Visible = false;
                    }
                }
                else
                {
                    txtTempsDessinConc.Enabled = true;
                    txtTempsCoupeConc.Enabled = true;
                    txtTempsMachinageConc.Enabled = true;
                    txtTempsSoudureConc.Enabled = true;
                    txtTempsAssemblageConc.Enabled = true;
                    txtTempsPeintureConc.Enabled = true;
                    txtTempsTestConc.Enabled = true;
                    txtTempsInstallationConc.Enabled = true;
                    txtTempsFormationConc.Enabled = true;
                    txtTempsGestionConc.Enabled = true;
                    txtTempsShippingConc.Enabled = true;
                a586:
                    ;
                    txtTempsPrototypeConc.Enabled = true;
                    txtTempsDessinConc.ReadOnly = bLocked;
                    txtTempsCoupeConc.ReadOnly = bLocked;
                    txtTempsMachinageConc.ReadOnly = bLocked;
                    txtTempsSoudureConc.ReadOnly = bLocked;
                    txtTempsAssemblageConc.ReadOnly = bLocked;
                    txtTempsPeintureConc.ReadOnly = bLocked;
                    txtTempsTestConc.ReadOnly = bLocked;
                    txtTempsInstallationConc.ReadOnly = bLocked;
                    txtTempsFormationConc.ReadOnly = bLocked;
                    txtTempsGestionConc.ReadOnly = bLocked;
                    txtTempsShippingConc.ReadOnly = bLocked;
                a641:
                    ;
                    txtTempsPrototypeConc.ReadOnly = bLocked;
                    txtTempsDessinSoum.Enabled = false;
                    txtTempsCoupeSoum.Enabled = false;
                    txtTempsMachinageSoum.Enabled = false;
                    txtTempsSoudureSoum.Enabled = false;
                    txtTempsAssemblageSoum.Enabled = false;
                    txtTempsPeintureSoum.Enabled = false;
                    txtTempsTestSoum.Enabled = false;
                    txtTempsInstallationSoum.Enabled = false;
                    txtTempsFormationSoum.Enabled = false;
                    txtTempsGestionSoum.Enabled = false;
                    txtTempsShippingSoum.Enabled = false;
                a696:
                    ;
                    txtTempsPrototypeSoum.Enabled = false;
                    txtTempsDessinProj.Enabled = false;
                    txtTempsCoupeProj.Enabled = false;
                    txtTempsMachinageProj.Enabled = false;
                    txtTempsSoudureProj.Enabled = false;
                    txtTempsAssemblageProj.Enabled = false;
                    txtTempsPeintureProj.Enabled = false;
                    txtTempsTestProj.Enabled = false;
                    txtTempsInstallationProj.Enabled = false;
                    txtTempsFormationProj.Enabled = false;
                    txtTempsGestionProj.Enabled = false;
                    txtTempsShippingProj.Enabled = false;
                a751:
                    ;
                    txtTempsPrototypeProj.Enabled = false;
                    if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
                    {
                        if (g_bDeverrouillageTempsProjet == true)
                        {
                            cmdUnlock.Visible = true;
                        }
                        else
                        {
                            cmdUnlock.Visible = false;
                        }
                        cmdLock.Visible = false;
                    }
                    else
                    {
                        cmdLock.Visible = false;
                        cmdUnlock.Visible = false;
                    }
                }
                txtNbrePersonne.ReadOnly = bLocked;
                txtTempsHebergement.ReadOnly = bLocked;
                txtTempsRepas.ReadOnly = bLocked;
                txtTempsDeplacement.ReadOnly = bLocked;
                txtTempsUniteMobile.ReadOnly = bLocked;
                txtPrixEmballage.ReadOnly = bLocked;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "BarrerChamps", ex);
            }
        }
        private void cmdDetail_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new Form();
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    f = new DetailTemps(m_sNoProjet, EnumCatalogue.MECANIQUE, true);
                }
                else
                {
                    f = new DetailTemps(m_sNoSoumission, EnumCatalogue.MECANIQUE, false);
                }
                f.MdiParent = Conteneur.ActiveForm;
                f.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "cmdDetail_Click", ex);
            }
        }
        private void cmdFermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
                {
                    EnregistrerTemps();
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "cmdFermer_Click", ex);
            }
        }
        private void EnregistrerTemps()
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsDessinSoum.Text)) & Information.IsNumeric(txtTempsDessinSoum.Text))
                    {
                        ProjSoumMec.m_sTempsDessin = txtTempsDessinSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsDessin = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsCoupeSoum.Text)) & Information.IsNumeric(txtTempsCoupeSoum.Text))
                    {
                        ProjSoumMec.m_sTempsCoupe = txtTempsCoupeSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsCoupe = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsMachinageSoum.Text)) & Information.IsNumeric(txtTempsMachinageSoum.Text))
                    {
                        ProjSoumMec.m_sTempsMachinage = txtTempsMachinageSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsMachinage = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsSoudureSoum.Text)) & Information.IsNumeric(txtTempsSoudureSoum.Text))
                    {
                        ProjSoumMec.m_sTempsSoudure = txtTempsSoudureSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsSoudure = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsAssemblageSoum.Text)) & Information.IsNumeric(txtTempsAssemblageSoum.Text))
                    {
                        ProjSoumMec.m_sTempsAssemblage = txtTempsAssemblageSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsAssemblage = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsPeintureSoum.Text)) & Information.IsNumeric(txtTempsPeintureSoum.Text))
                    {
                        ProjSoumMec.m_sTempsPeinture = txtTempsPeintureSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsPeinture = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsTestSoum.Text)) & Information.IsNumeric(txtTempsTestSoum.Text))
                    {
                        ProjSoumMec.m_sTempsTest = txtTempsTestSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsTest = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsInstallationSoum.Text)) & Information.IsNumeric(txtTempsInstallationSoum.Text))
                    {
                        ProjSoumMec.m_sTempsInstallation = txtTempsInstallationSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsInstallation = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsFormationSoum.Text)) & Information.IsNumeric(txtTempsFormationSoum.Text))
                    {
                        ProjSoumMec.m_sTempsFormation = txtTempsFormationSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsFormation = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsGestionSoum.Text)) & Information.IsNumeric(txtTempsGestionSoum.Text))
                    {
                        ProjSoumMec.m_sTempsGestion = txtTempsGestionSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsGestion = "0.00";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(txtTempsShippingSoum.Text)) & Information.IsNumeric(txtTempsShippingSoum.Text))
                    {
                        ProjSoumMec.m_sTempsShipping = txtTempsShippingSoum.Text;
                    }
                    else
                    {
                        ProjSoumMec.m_sTempsShipping = "0.00";
                    }
                }
                else
                {
                    ProjSoumMec.m_bTempsProjLock = m_bLocked;
                    if (m_bLocked == false)
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsDessinProj.Text)) & Information.IsNumeric(txtTempsDessinProj.Text))
                        {
                            ProjSoumMec.m_sTempsDessinProj = txtTempsDessinProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsDessinProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsCoupeProj.Text)) & Information.IsNumeric(txtTempsMachinageProj.Text))
                        {
                            ProjSoumMec.m_sTempsCoupeProj = txtTempsCoupeProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsCoupeProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsMachinageProj.Text)) & Information.IsNumeric(txtTempsMachinageProj.Text))
                        {
                            ProjSoumMec.m_sTempsMachinageProj = txtTempsMachinageProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsMachinageProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsSoudureProj.Text)) & Information.IsNumeric(txtTempsSoudureProj.Text))
                        {
                            ProjSoumMec.m_sTempsSoudureProj = txtTempsSoudureProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsSoudureProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsAssemblageProj.Text)) & Information.IsNumeric(txtTempsAssemblageProj.Text))
                        {
                            ProjSoumMec.m_sTempsAssemblageProj = txtTempsAssemblageProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsAssemblageProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsPeintureProj.Text)) & Information.IsNumeric(txtTempsPeintureProj.Text))
                        {
                            ProjSoumMec.m_sTempsPeintureProj = txtTempsPeintureProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsPeintureProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsTestProj.Text)) & Information.IsNumeric(txtTempsTestProj.Text))
                        {
                            ProjSoumMec.m_sTempsTestProj = txtTempsTestProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsTestProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsInstallationProj.Text)) & Information.IsNumeric(txtTempsInstallationProj.Text))
                        {
                            ProjSoumMec.m_sTempsInstallationProj = txtTempsInstallationProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsInstallationProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsFormationProj.Text)) & Information.IsNumeric(txtTempsFormationProj.Text))
                        {
                            ProjSoumMec.m_sTempsFormationProj = txtTempsFormationProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsFormationProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsGestionProj.Text)) & Information.IsNumeric(txtTempsGestionProj.Text))
                        {
                            ProjSoumMec.m_sTempsGestionProj = txtTempsGestionProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsGestionProj = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsShippingProj.Text)) & Information.IsNumeric(txtTempsShippingProj.Text))
                        {
                            ProjSoumMec.m_sTempsShippingProj = txtTempsShippingProj.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsShippingProj = "0.00";
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsDessinConc.Text)) & Information.IsNumeric(txtTempsDessinConc.Text))
                        {
                            ProjSoumMec.m_sTempsDessinConc = txtTempsDessinConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsDessinConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsCoupeConc.Text)) & Information.IsNumeric(txtTempsCoupeConc.Text))
                        {
                            ProjSoumMec.m_sTempsCoupeConc = txtTempsCoupeConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsCoupeConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsMachinageConc.Text)) & Information.IsNumeric(txtTempsMachinageConc.Text))
                        {
                            ProjSoumMec.m_sTempsMachinageConc = txtTempsMachinageConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsMachinageConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsSoudureConc.Text)) & Information.IsNumeric(txtTempsSoudureConc.Text))
                        {
                            ProjSoumMec.m_sTempsSoudureConc = txtTempsSoudureConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsSoudureConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsAssemblageConc.Text)) & Information.IsNumeric(txtTempsAssemblageConc.Text))
                        {
                            ProjSoumMec.m_sTempsAssemblageConc = txtTempsAssemblageConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsAssemblageConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsPeintureConc.Text)) & Information.IsNumeric(txtTempsPeintureConc.Text))
                        {
                            ProjSoumMec.m_sTempsPeintureConc = txtTempsPeintureConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsPeintureConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsTestConc.Text)) & Information.IsNumeric(txtTempsTestConc.Text))
                        {
                            ProjSoumMec.m_sTempsTestConc = txtTempsTestConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsTestConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsInstallationConc.Text)) & Information.IsNumeric(txtTempsInstallationConc.Text))
                        {
                            ProjSoumMec.m_sTempsInstallationConc = txtTempsInstallationConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsInstallationConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsFormationConc.Text)) & Information.IsNumeric(txtTempsFormationConc.Text))
                        {
                            ProjSoumMec.m_sTempsFormationConc = txtTempsFormationConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsFormationConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsGestionConc.Text)) & Information.IsNumeric(txtTempsGestionConc.Text))
                        {
                            ProjSoumMec.m_sTempsGestionConc = txtTempsGestionConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsGestionConc = "0.00";
                        }
                        if (!string.IsNullOrEmpty(Strings.Trim(txtTempsShippingConc.Text)) & Information.IsNumeric(txtTempsShippingConc.Text))
                        {
                            ProjSoumMec.m_sTempsShippingConc = txtTempsShippingConc.Text;
                        }
                        else
                        {
                            ProjSoumMec.m_sTempsShippingConc = "0.00";
                        }
                    }
                }
                if (!string.IsNullOrEmpty(Strings.Trim(txtNbrePersonne.Text)) & Information.IsNumeric(txtNbrePersonne.Text))
                {
                    ProjSoumMec.m_sNbrePersonne = txtNbrePersonne.Text;
                }
                else
                {
                    ProjSoumMec.m_sNbrePersonne = "0.00";
                }
                if (!string.IsNullOrEmpty(Strings.Trim(txtTempsHebergement.Text)) & Information.IsNumeric(txtTempsHebergement.Text))
                {
                    ProjSoumMec.m_sTempsHebergement = txtTempsHebergement.Text;
                }
                else
                {
                    ProjSoumMec.m_sTempsHebergement = "0.00";
                }
                if (!string.IsNullOrEmpty(Strings.Trim(txtTempsRepas.Text)) & Information.IsNumeric(txtTempsRepas.Text))
                {
                    ProjSoumMec.m_sTempsRepas = txtTempsRepas.Text;
                }
                else
                {
                    ProjSoumMec.m_sTempsRepas = "0.00";
                }
                if (!string.IsNullOrEmpty(Strings.Trim(txtTempsDeplacement.Text)) & Information.IsNumeric(txtTempsDeplacement.Text))
                {
                    ProjSoumMec.m_sTempsTransport = txtTempsDeplacement.Text;
                }
                else
                {
                    ProjSoumMec.m_sTempsTransport = "0.00";
                }
                if (!string.IsNullOrEmpty(Strings.Trim(txtTempsUniteMobile.Text)) & Information.IsNumeric(txtTempsUniteMobile.Text))
                {
                    ProjSoumMec.m_sTempsUniteMobile = txtTempsUniteMobile.Text;
                }
                else
                {
                    ProjSoumMec.m_sTempsUniteMobile = "0.00";
                }
                if (!string.IsNullOrEmpty(Strings.Trim(txtPrixEmballage.Text)) & Information.IsNumeric(txtPrixEmballage.Text))
                {
                    ProjSoumMec.m_sPrixEmballage = txtPrixEmballage.Text;
                }
                else
                {
                    ProjSoumMec.m_sPrixEmballage = "0.00";
                }
                ProjSoumMec.m_sTauxHebergement1 = m_sHebergement1;
                ProjSoumMec.m_sTauxHebergement2 = m_sHebergement2;
                ProjSoumMec.m_sTauxRepas = m_sRepas;
                ProjSoumMec.m_sTauxTransport = m_sStandard;
                ProjSoumMec.m_sTauxUniteMobile = m_sUniteMobile;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "EnregistrerTemps", ex);
            }
        }
        private void cmdLock_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if ((m_sTempsDessinAvant ?? "") != (txtTempsDessinProj.Text ?? "") | (m_sTempsCoupeAvant ?? "") != (txtTempsCoupeProj.Text ?? "") | (m_sTempsMachinageAvant ?? "") != (txtTempsMachinageProj.Text ?? "") | (m_sTempsSoudureAvant ?? "") != (txtTempsSoudureProj.Text ?? "") | (m_sTempsAssemblageAvant ?? "") != (txtTempsAssemblageProj.Text ?? "") | (m_sTempsPeintureAvant ?? "") != (txtTempsPeintureProj.Text ?? "") | (m_sTempsTestAvant ?? "") != (txtTempsTestProj.Text ?? "") | (m_sTempsInstallationAvant ?? "") != (txtTempsInstallationProj.Text ?? "") | (m_sTempsFormationAvant ?? "") != (txtTempsFormationProj.Text ?? "") | (m_sTempsGestionAvant ?? "") != (txtTempsGestionProj.Text ?? "") | (m_sTempsShippingAvant ?? "") != (txtTempsShippingProj.Text ?? ""))
                {
                    MessageBox.Show("Veuillez enregistrer le projet en premier sinon vous allez perdre les informations qui ont été modifiées dans le temps projets!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    m_bLocked = true;
                    BarrerChamps(false);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "cmdLock_Click", ex);
            }
        }
        private void cmdUnlock_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bLocked = false;
                BarrerChamps(false);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "cmdUnlock_Click", ex);
            }
        }
        private void InitialiserVariablesConfig()
        {
            try
            {
                // Initialise les variables à partir de la table CONFIG (Pour avoir le taux
                // horaire le plus récent)
                ADODB.Recordset rstConfig;
                rstConfig = new Recordset();
                rstConfig.Open("SELECT TauxDessinMec, TauxCoupe, TauxMachinage, TauxSoudure, TauxAssemblageMec, TauxPeinture, TauxTestMec, TauxInstallationMec, TauxFormationMec, " +
                    "TauxGestionProjetsMec, TauxShippingMec, Repas, Hebergement1, Hebergement2, Standard, UniteMobile FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!(rstConfig.Fields["TauxDessinMec"].Value is DBNull))
                {
                    m_sTauxDessin = (string)(rstConfig.Fields["TauxDessinMec"].Value);
                }
                else
                {
                    m_sTauxDessin = "0.00";
                }
                if (!(rstConfig.Fields["TauxCoupe"].Value is DBNull))
                {
                    m_sTauxCoupe = (string)(rstConfig.Fields["TauxCoupe"].Value);
                }
                else
                {
                    m_sTauxCoupe = "0.00";
                }
                if (!(rstConfig.Fields["TauxMachinage"].Value is DBNull))
                {
                    m_sTauxMachinage = (string)(rstConfig.Fields["TauxMachinage"].Value);
                }
                else
                {
                    m_sTauxMachinage = "0.00";
                }
                if (!(rstConfig.Fields["TauxSoudure"].Value is DBNull))
                {
                    m_sTauxSoudure = (string)(rstConfig.Fields["TauxSoudure"].Value);
                }
                else
                {
                    m_sTauxSoudure = "0.00";
                }
                if (!(rstConfig.Fields["TauxAssemblageMec"].Value is DBNull))
                {
                    m_sTauxAssemblage = (string)(rstConfig.Fields["TauxAssemblageMec"].Value);
                }
                else
                {
                    m_sTauxAssemblage = "0.00";
                }
                if (!(rstConfig.Fields["TauxPeinture"].Value is DBNull))
                {
                    m_sTauxPeinture = (string)(rstConfig.Fields["TauxPeinture"].Value);
                }
                else
                {
                    m_sTauxPeinture = "0.00";
                }
                if (!(rstConfig.Fields["TauxTestMec"].Value is DBNull))
                {
                    m_sTauxTest = (string)(rstConfig.Fields["TauxTestMec"].Value);
                }
                else
                {
                    m_sTauxTest = "0.00";
                }
                if (!(rstConfig.Fields["TauxInstallationMec"].Value is DBNull))
                {
                    m_sTauxInstallation = (string)(rstConfig.Fields["TauxInstallationMec"].Value);
                }
                else
                {
                    m_sTauxInstallation = "0.00";
                }
                if (!(rstConfig.Fields["TauxFormationMec"].Value is DBNull))
                {
                    m_sTauxFormation = (string)(rstConfig.Fields["TauxFormationMec"].Value);
                }
                else
                {
                    m_sTauxFormation = "0.00";
                }
                if (!(rstConfig.Fields["TauxGestionProjetsMec"].Value is DBNull))
                {
                    m_sTauxGestion = (string)(rstConfig.Fields["TauxGestionProjetsMec"].Value);
                }
                else
                {
                    m_sTauxGestion = "0.00";
                }
                if (!(rstConfig.Fields["TauxShippingMec"].Value is DBNull))
                {
                    m_sTauxShipping = (string)(rstConfig.Fields["TauxShippingMec"].Value);
                }
                else
                {
                    m_sTauxShipping = "0.00";
                }
                if (!(rstConfig.Fields["TauxShippingMec"].Value is DBNull))
                {
                a296:
                    ;
                    m_sTauxPrototype = (string)(rstConfig.Fields["TauxShippingMec"].Value);
                a297:
                    ;
                }
                else
                {
                a298:
                    ;
                    m_sTauxPrototype = "0.00";
                a299:
                    ;
                }

                m_sRepas = (string)(rstConfig.Fields["Repas"].Value);
                m_sHebergement1 = (string)(rstConfig.Fields["Hebergement1"].Value);
                m_sHebergement2 = (string)(rstConfig.Fields["Hebergement2"].Value);
                m_sStandard = (string)(rstConfig.Fields["Standard"].Value);
                m_sUniteMobile = (string)(rstConfig.Fields["UniteMobile"].Value);
                rstConfig.Close();

                rstConfig = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "InitialiserVariablesConfig", ex);
            }
        }
        private void InitialiserVariablesProjSoum()
        {
            try
            {
                m_sTauxDessin = ProjSoumMec.m_sTauxDessin;
                m_sTauxCoupe = ProjSoumMec.m_sTauxCoupe;
                m_sTauxMachinage = ProjSoumMec.m_sTauxMachinage;
                m_sTauxSoudure = ProjSoumMec.m_sTauxSoudure;
                m_sTauxAssemblage = ProjSoumMec.m_sTauxAssemblage;
                m_sTauxPeinture = ProjSoumMec.m_sTauxPeinture;
                m_sTauxTest = ProjSoumMec.m_sTauxTest;
                m_sTauxInstallation = ProjSoumMec.m_sTauxInstallation;
                m_sTauxFormation = ProjSoumMec.m_sTauxFormation;
                m_sTauxGestion = ProjSoumMec.m_sTauxGestion;
                m_sTauxShipping = ProjSoumMec.m_sTauxShipping;
                m_sTauxPrototype = ProjSoumMec.m_sTauxShipping;
                m_sRepas = ProjSoumMec.m_sTauxRepas;
                m_sHebergement1 = ProjSoumMec.m_sTauxHebergement1;
                m_sHebergement2 = ProjSoumMec.m_sTauxHebergement2;
                m_sStandard = ProjSoumMec.m_sTauxTransport;
                m_sUniteMobile = ProjSoumMec.m_sTauxUniteMobile;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "InitialiserVariablesProjSoum", ex);
            }
        }
        [Obsolete]
        private void ProjSoumMecTemps_Load(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (ProjSoumMec.m_bDroitPrix == false)
                {
                    fraManutention.Visible = false;
                    lblTotalPrixRH.Visible = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "Form_Load", ex);
            }
        }
        //txtNbrePersonne.TextChanged//
        private void txtNbrePersonne_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTempsHebergement.Text))
                {
                    if (Information.IsNumeric(txtNbrePersonne.Text))
                    {
                        CalculerHebergement();
                        CalculerRepas();
                        CalculerTotal();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtNbrePersonne_Change", ex);
            }
        }
        private void txtPrixEmballage_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            switch ((int)eventArgs.KeyChar)
            {
                case 0x002E: { eventArgs.KeyChar = (Char)0X02c; } break;
                case 0x00: { eventArgs.Handled = true; } break;
            }
        }
        private void txtTempsAssemblageConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsAssemblageConc_Change", ex);
            }
        }
        //txtTempsAssemblageProj.TextChanged//
        private void txtTempsAssemblageProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsAssemblageProj_Change", ex);
            }
        }
        private void txtTempsCoupeConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsCoupeConc_Change", ex);
            }
        }
        //txtTempsCoupeProj.TextChanged//
        private void txtTempsCoupeProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsCoupeProj_Change", ex);
            }
        }
        private void txtTempsDessinConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsDessinConc_Change", ex);
            }
        }
        //txtTempsDessinProj.TextChanged//
        private void txtTempsDessinProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsDessinProj_Change", ex);
            }
        }
        //txtTempsFormationConc.TextChanged//
        private void txtTempsFormationConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsFormationConc_Change", ex);
            }
        }
        //txtTempsFormationProj.TextChanged//
        private void txtTempsFormationProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsFormationProj_Change", ex);
            }
        }
        //txtTempsGestionConc.TextChanged//
        private void txtTempsGestionConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsGestionConc_Change", ex);
            }
        }
        //txtTempsGestionProj.TextChanged//
        private void txtTempsGestionProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsGestionProj_Change", ex);
            }
        }
        //txtTempsShippingConc.TextChanged//
        private void txtTempsShippingConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsShippingConc_Change", ex);
            }
        }
        //txtTempsShippingProj.TextChanged//
        private void txtTempsShippingProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsShippingProj_Change", ex);
            }
        }
        //txtTempsInstallationConc.TextChanged//
        private void txtTempsInstallationConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsInstallationConc_Change", ex);
            }
        }
        //txtTempsInstallationProj.TextChanged//
        private void txtTempsInstallationProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsInstallationProj_Change", ex);
            }
        }
        //txtTempsMachinageConc.TextChanged//
        private void txtTempsMachinageConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsMachinageConc_Change", ex);
            }
        }
        //txtTempsMachinageProj.TextChanged//
        private void txtTempsMachinageProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsMachinageProj_Change", ex);
            }
        }
        //txtTempsMachinageSoum.TextChanged//
        private void txtTempsMachinageSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsMachinageSoum.Text))
                    {
                        lblPrixMachinage.Text = Math.Round(double.Parse(txtTempsMachinageSoum.Text) * double.Parse(m_sTauxMachinage), 2).ToString();
                    }
                    else
                    {
                        lblPrixMachinage.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsMachinageSoum_Change", ex);
            }
        }
        private void txtTempsMachinageSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsMachinageSoum.Text = Strings.Replace(txtTempsMachinageSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsMachinageSoum_LostFocus", ex);
            }
        }
        private void txtTempsMachinageProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsMachinageProj.Text = Strings.Replace(txtTempsMachinageProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsMachinageProj_LostFocus", ex);
            }
        }
        private void txtTempsMachinageConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsMachinageConc.Text = Strings.Replace(txtTempsMachinageConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsMachinageConc_LostFocus", ex);
            }
        }
        //txtTempsCoupeSoum.TextChanged//
        private void txtTempsCoupeSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsCoupeSoum.Text))
                    {
                        lblPrixCoupe.Text = Math.Round(double.Parse(txtTempsCoupeSoum.Text) * double.Parse(m_sTauxCoupe), 2).ToString();
                    }
                    else
                    {
                        lblPrixCoupe.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsCoupeSoum_Change", ex);
            }
        }
        private void txtTempsCoupeSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsCoupeSoum.Text = Strings.Replace(txtTempsCoupeSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsCoupeSoum_LostFocus", ex);
            }
        }
        private void txtTempsCoupeProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsCoupeProj.Text = Strings.Replace(txtTempsCoupeProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsCoupeProj_LostFocus", ex);
            }
        }
        private void txtTempsCoupeConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsCoupeConc.Text = Strings.Replace(txtTempsCoupeConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsCoupeConc_LostFocus", ex);
            }
        }
        //txtTempsPeintureConc.TextChanged//
        private void txtTempsPeintureConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsPeintureConc_Change", ex);
            }
        }
        //txtTempsPeintureProj.TextChanged//
        private void txtTempsPeintureProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsPeintureProj_Change", ex);
            }
        }
        //txtTempsSoudureConc.TextChanged//
        private void txtTempsSoudureConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsSoudureConc_Change", ex);
            }
        }
        //txtTempsSoudureProj.TextChanged//
        private void txtTempsSoudureProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsSoudureProj_Change", ex);
            }
        }
        //txtTempsSoudureSoum.TextChanged//
        private void txtTempsSoudureSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsSoudureSoum.Text))
                    {
                        lblPrixSoudure.Text = Math.Round(double.Parse(txtTempsSoudureSoum.Text) * double.Parse(m_sTauxSoudure), 2).ToString();
                    }
                    else
                    {
                        lblPrixSoudure.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsSoudureSoum_Change", ex);
            }
        }
        private void txtTempsSoudureSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsSoudureSoum.Text = Strings.Replace(txtTempsSoudureSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsSoudureSoum_LostFocus", ex);
            }
        }
        private void txtTempsSoudureProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsSoudureProj.Text = Strings.Replace(txtTempsSoudureProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsSoudureProj_LostFocus", ex);
            }
        }
        private void txtTempsSoudureConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsSoudureConc.Text = Strings.Replace(txtTempsSoudureConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsSoudureConc_LostFocus", ex);
            }
        }
        //txtTempsAssemblageSoum.TextChanged//
        private void txtTempsAssemblageSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsAssemblageSoum.Text))
                    {
                        lblPrixAssemblage.Text = Math.Round(double.Parse(txtTempsAssemblageSoum.Text) * double.Parse(m_sTauxAssemblage), 2).ToString();
                    }
                    else
                    {
                        lblPrixAssemblage.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsAssemblageSoum_Change", ex);
            }
        }
        private void txtTempsAssemblageSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsAssemblageSoum.Text = Strings.Replace(txtTempsAssemblageSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsAssemblageSoum_LostFocus", ex);
            }
        }
        private void txtTempsAssemblageProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsAssemblageProj.Text = Strings.Replace(txtTempsAssemblageProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsAssemblageProj_LostFocus", ex);
            }
        }
        private void txtTempsAssemblageConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsAssemblageConc.Text = Strings.Replace(txtTempsAssemblageConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsAssemblageConc_LostFocus", ex);
            }
        }
        //txtTempsPeintureSoum.TextChanged//
        private void txtTempsPeintureSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsPeintureSoum.Text))
                    {
                        lblPrixPeinture.Text = Math.Round(double.Parse(txtTempsPeintureSoum.Text) * double.Parse(m_sTauxPeinture), 2).ToString();
                    }
                    else
                    {
                        lblPrixPeinture.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsPeintureSoum_Change", ex);
            }
        }
        private void txtTempsPeintureSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsPeintureSoum.Text = Strings.Replace(txtTempsPeintureSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsPeintureSoum_LostFocus", ex);
            }
        }
        private void txtTempsPeintureProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsPeintureProj.Text = Strings.Replace(txtTempsPeintureProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsPeintureProj_LostFocus", ex);
            }
        }
        private void txtTempsPeintureConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsPeintureConc.Text = Strings.Replace(txtTempsPeintureConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsPeintureConc_LostFocus", ex);
            }
        }
        //txtTempsTestConc.TextChanged//
        private void txtTempsTestConc_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsTestConc_Change", ex);
            }
        }
        //txtTempsTestProj.TextChanged//
        private void txtTempsTestProj_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotalTemps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsTestProj_Change", ex);
            }
        }
        //txtTempsTestSoum.TextChanged//
        private void txtTempsTestSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsTestSoum.Text))
                    {
                        lblPrixTest.Text = Math.Round(double.Parse(txtTempsTestSoum.Text) * double.Parse(m_sTauxTest), 2).ToString();
                    }
                    else
                    {
                        lblPrixTest.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsTestSoum_Change", ex);
            }
        }
        private void txtTempsTestSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsTestSoum.Text = Strings.Replace(txtTempsTestSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsTestSoum_LostFocus", ex);
            }
        }
        private void txtTempsTestProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsTestProj.Text = Strings.Replace(txtTempsTestProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsTestProj_LostFocus", ex);
            }
        }
        private void txtTempsTestConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsTestConc.Text = Strings.Replace(txtTempsTestConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsTestConc_LostFocus", ex);
            }
        }
        //txtTempsInstallationSoum.TextChanged//
        private void txtTempsInstallationSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsInstallationSoum.Text))
                    {
                        lblPrixInstallation.Text = Math.Round(double.Parse(txtTempsInstallationSoum.Text) * double.Parse(m_sTauxInstallation), 2).ToString();
                    }
                    else
                    {
                        lblPrixInstallation.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsInstallationSoum_Change", ex);
            }
        }
        private void txtTempsInstallationSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsInstallationSoum.Text = Strings.Replace(txtTempsInstallationSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsInstallationSoum_LostFocus", ex);
            }
        }
        private void txtTempsInstallationProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsInstallationProj.Text = Strings.Replace(txtTempsInstallationProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsInstallationProj_LostFocus", ex);
            }
        }
        private void txtTempsInstallationConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsInstallationConc.Text = Strings.Replace(txtTempsInstallationConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsInstallationConc_LostFocus", ex);
            }
        }
        //txtTempsDessinSoum.TextChanged//
        private void txtTempsDessinSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsDessinSoum.Text))
                    {
                        lblPrixDessin.Text = Math.Round(double.Parse(txtTempsDessinSoum.Text) * double.Parse(m_sTauxDessin), 2).ToString();
                    }
                    else
                    {
                        lblPrixDessin.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsDessinSoum_Change", ex);
            }
        }
        private void txtTempsDessinSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsDessinSoum.Text = Strings.Replace(txtTempsDessinSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsDessinSoum_LostFocus", ex);
            }
        }
        private void txtTempsDessinProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsDessinProj.Text = Strings.Replace(txtTempsDessinProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsDessinProj_LostFocus", ex);
            }
        }
        private void txtTempsDessinConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsDessinConc.Text = Strings.Replace(txtTempsDessinConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsDessinConc_LostFocus", ex);
            }
        }
        //txtTempsFormationSoum.TextChanged//
        private void txtTempsFormationSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsFormationSoum.Text))
                    {
                        lblPrixFormation.Text = Math.Round(double.Parse(txtTempsFormationSoum.Text) * double.Parse(m_sTauxFormation), 2).ToString();
                    }
                    else
                    {
                        lblPrixFormation.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsFormationSoum_Change", ex);
            }
        }
        private void txtTempsFormationSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsFormationSoum.Text = Strings.Replace(txtTempsFormationSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsFormationSoum_LostFocus", ex);
            }
        }
        private void txtTempsFormationProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsFormationProj.Text = Strings.Replace(txtTempsFormationProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsFormationProj_LostFocus", ex);
            }
        }
        private void txtTempsFormationConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsFormationConc.Text = Strings.Replace(txtTempsFormationConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsFormationConc_LostFocus", ex);
            }
        }
        //txtTempsGestionSoum.TextChanged//
        private void txtTempsGestionSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsGestionSoum.Text))
                    {
                        lblPrixGestion.Text = Math.Round(double.Parse(txtTempsGestionSoum.Text) * double.Parse(m_sTauxGestion), 2).ToString();
                    }
                    else
                    {
                        lblPrixGestion.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsGestionSoum_Change", ex);
            }
        }
        private void txtTempsGestionSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsGestionSoum.Text = Strings.Replace(txtTempsGestionSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsGestionSoum_LostFocus", ex);
            }
        }
        private void txtTempsGestionProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsGestionProj.Text = Strings.Replace(txtTempsGestionProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsGestionProj_LostFocus", ex);
            }
        }
        private void txtTempsGestionConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsGestionConc.Text = Strings.Replace(txtTempsGestionConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsGestionConc_LostFocus", ex);
            }
        }
        //txtTempsShippingSoum.TextChanged//
        private void txtTempsShippingSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == EnumType.TYPE_SOUMISSION)
                {
                    if (Information.IsNumeric(txtTempsShippingSoum.Text))
                    {
                        lblPrixShipping.Text = Math.Round(double.Parse(txtTempsShippingSoum.Text) * double.Parse(m_sTauxShipping), 2).ToString();
                    }
                    else
                    {
                        lblPrixShipping.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsShippingSoum_Change", ex);
            }
        }
        private void txtTempsShippingSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsShippingSoum.Text = Strings.Replace(txtTempsShippingSoum.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsShippingSoum_LostFocus", ex);
            }
        }
        private void txtTempsShippingProj_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsShippingProj.Text = Strings.Replace(txtTempsShippingProj.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsShippingProj_LostFocus", ex);
            }
        }
        private void txtTempsShippingConc_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsShippingConc.Text = Strings.Replace(txtTempsShippingConc.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsShippingConc_LostFocus", ex);
            }
        }
        //txtTempsHebergement.TextChanged//
        private void txtTempsHebergement_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Information.IsNumeric(txtTempsHebergement.Text))
                {
                    if (!string.IsNullOrEmpty(txtNbrePersonne.Text))
                    {
                        CalculerHebergement();
                    }
                }
                CalculerTotal();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsHebergement_Change", ex);
            }
        }
        private void txtTempsHebergement_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsHebergement.Text = Strings.Replace(txtTempsHebergement.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsHebergement_LostFocus", ex);
            }
        }
        //txtTempsRepas.TextChanged//
        private void txtTempsRepas_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Information.IsNumeric(txtTempsRepas.Text))
                {
                    if (!string.IsNullOrEmpty(txtNbrePersonne.Text))
                    {
                        CalculerRepas();
                    }
                }
                CalculerTotal();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsRepas_Change", ex);
            }
        }
        private void txtTempsRepas_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsRepas.Text = Strings.Replace(txtTempsRepas.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsRepas_LostFocus", ex);
            }
        }
        //txtTempsDeplacement.TextChanged//
        private void txtTempsDeplacement_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Information.IsNumeric(txtTempsDeplacement.Text))
                {
                    lblPrixDeplacement.Text = Math.Round(double.Parse(txtTempsDeplacement.Text) * double.Parse(m_sStandard), 2).ToString();
                }
                else
                {
                    lblPrixDeplacement.Text = 0.ToString();
                }
                CalculerTotal();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsDeplacement_Change", ex);
            }
        }
        private void txtTempsDeplacement_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsDeplacement.Text = Strings.Replace(txtTempsDeplacement.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsDeplacement_LostFocus", ex);
            }
        }
        //txtTempsUniteMobile.TextChanged//
        private void txtTempsUniteMobile_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Information.IsNumeric(txtTempsUniteMobile.Text))
                {
                    lblPrixUniteMobile.Text = Math.Round(double.Parse(txtTempsUniteMobile.Text) * double.Parse(m_sUniteMobile), 2).ToString();
                }
                else
                {
                    lblPrixUniteMobile.Text = 0.ToString();
                }
                CalculerTotal();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsUniteMobile_Change", ex);
            }
        }
        private void txtTempsUniteMobile_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsUniteMobile.Text = Strings.Replace(txtTempsUniteMobile.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "txtTempsUniteMobile_LostFocus", ex);
            }
        }
        //txtPrixEmballage.TextChanged//
        private void txtPrixEmballage_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotal();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "lblPrixEmballage_Change", ex);
            }
        }
        private void txtPrixEmballage_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Information.IsNumeric(txtPrixEmballage.Text))
                {
                    txtPrixEmballage.Text = Math.Round(double.Parse(txtPrixEmballage.Text), 2).ToString();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "lblPrixEmballage_LostFocus", ex);
            }
        }
        private void CalculerHebergement()
        {
            try
            {
                double dblNbreDeux;
                double dblHebergement;
                short iReste;
                double dblNbrePers;
                double dblNbreJours;
                if (Information.IsNumeric(txtNbrePersonne.Text))
                {
                    dblNbrePers = double.Parse(txtNbrePersonne.Text);
                }
                else
                {
                    dblNbrePers = 0d;
                }
                if (Information.IsNumeric(txtTempsHebergement.Text))
                {
                    dblNbreJours = double.Parse(txtTempsHebergement.Text);
                }
                else
                {
                    dblNbreJours = 0d;
                }
                dblNbreDeux = Conversion.Int(dblNbrePers / 2d);
                iReste = (short)Math.Round((short)Math.Round(dblNbrePers) - dblNbreDeux * 2d);
                dblHebergement = dblNbreJours * (dblNbreDeux * double.Parse(m_sHebergement2) + iReste * double.Parse(m_sHebergement1));
                lblPrixHebergement.Text = Math.Round(dblHebergement, 2).ToString();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "CalculerHebergement", ex);
            }
        }
        private void CalculerRepas()
        {
            try
            {
                double dblNbrePers;
                double dblRepas;
                double dblNbreJours;
                if (Information.IsNumeric(txtNbrePersonne.Text))
                {
                    dblNbrePers = double.Parse(txtNbrePersonne.Text);
                }
                else
                {
                    dblNbrePers = 0d;
                }
                if (Information.IsNumeric(txtTempsRepas.Text))
                {
                    dblNbreJours = double.Parse(txtTempsRepas.Text);
                }
                else
                {
                    dblNbreJours = 0d;
                }
                dblRepas = dblNbreJours * dblNbrePers * double.Parse(m_sRepas);
                lblPrixRepas.Text = Math.Round(dblRepas, 2).ToString();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "CalculerRepas", ex);
            }
        }
        private void CalculerTotal()
        {
            ;
            /* Cannot convert OnErrorGoToStatementSyntax, CONVERSION ERROR: Conversion for OnErrorGoToLabelStatement not implemented, please report this issue in 'On Error GoTo AfficherErreurServeurWeb'Instruction: 145918
                        Input:
                              On Error GoTo AfficherErreurServeurWeb
                         */
            double dblTotal;
            double dblPrixEmballage;
            double dblTotalArgentRH;
            double dblPrixDessin;
            double dblPrixCoupe;
            double dblPrixMachinage;
            double dblPrixSoudure;
            double dblPrixAssemblage;
            double dblPrixPeinture;
            double dblPrixTest;
            double dblPrixInstallation;
            double dblPrixFormation;
            double dblPrixGestion;
            double dblPrixShipping;
            double dblPrixHebergement;
            double dblPrixRepas;
            double dblPrixDeplacement;
            double dblPrixUniteMobile;
            //Prix de dessin
            if (Information.IsNumeric(lblPrixDessin.Text))
            {
                dblPrixDessin = double.Parse(lblPrixDessin.Text);
            }
            else
            {
                dblPrixDessin = 0d;
            }
            //Prix de coupe et préparation
            if (Information.IsNumeric(lblPrixCoupe.Text))
            {
                dblPrixCoupe = double.Parse(lblPrixCoupe.Text);
            }
            else
            {
                dblPrixCoupe = 0d;
            }
            //Prix de machinage
            if (Information.IsNumeric(lblPrixMachinage.Text))
            {
                dblPrixMachinage = double.Parse(lblPrixMachinage.Text);
            }
            else
            {
                dblPrixMachinage = 0d;
            }
            //Prix de soudure et meulage
            if (Information.IsNumeric(lblPrixSoudure.Text))
            {
                dblPrixSoudure = double.Parse(lblPrixSoudure.Text);
            }
            else
            {
                dblPrixSoudure = 0d;
            }
            //Prix d'assemblage du système
            if (Information.IsNumeric(lblPrixAssemblage.Text))
            {
                dblPrixAssemblage = double.Parse(lblPrixAssemblage.Text);
            }
            else
            {
                dblPrixAssemblage = 0d;
            }
            //Prix de peinture et finition
            if (Information.IsNumeric(lblPrixPeinture.Text))
            {
                dblPrixPeinture = double.Parse(lblPrixPeinture.Text);
            }
            else
            {
                dblPrixPeinture = 0d;
            }
            //Prix de tests finaux
            if (Information.IsNumeric(lblPrixTest.Text))
            {
                dblPrixTest = double.Parse(lblPrixTest.Text);
            }
            else
            {
                dblPrixTest = 0d;
            }
            //Prix d'Installation
            if (Information.IsNumeric(lblPrixInstallation.Text))
            {
                dblPrixInstallation = double.Parse(lblPrixInstallation.Text);
            }
            else
            {
                dblPrixInstallation = 0d;
            }
            //Prix de formation
            if (Information.IsNumeric(lblPrixFormation.Text))
            {
                dblPrixFormation = double.Parse(lblPrixFormation.Text);
            }
            else
            {
                dblPrixFormation = 0d;
            }
            //Prix de gestion du projet
            if (Information.IsNumeric(lblPrixGestion.Text))
            {
                dblPrixGestion = double.Parse(lblPrixGestion.Text);
            }
            else
            {
                dblPrixGestion = 0d;
            }
            //Prix de shipping
            if (Information.IsNumeric(lblPrixShipping.Text))
            {
                dblPrixShipping = double.Parse(lblPrixShipping.Text);
            }
            else
            {
                dblPrixShipping = 0d;
            }
        // Prix de dévelloppement prototypage
        a371:
            ;
            if (Information.IsNumeric(lblPrixPrototype.Text))
            {
            a372:
                ;//dblPrixPrototype = CDbl(lblPrixPrototype.Caption)
            a373:
                ;
            }
            else
            {
            a374:
                ;
                // dblPrixPrototype = 0
            }
            //Prix d'hébergement
            if (Information.IsNumeric(lblPrixHebergement.Text))
            {
                dblPrixHebergement = double.Parse(lblPrixHebergement.Text);
            }
            else
            {
                dblPrixHebergement = 0d;
            }
            //Prix des repas
            if (Information.IsNumeric(lblPrixRepas.Text))
            {
                dblPrixRepas = double.Parse(lblPrixRepas.Text);
            }
            else
            {
                dblPrixRepas = 0d;
            }
            //Prix du déplacement
            if (Information.IsNumeric(lblPrixDeplacement.Text))
            {
                dblPrixDeplacement = double.Parse(lblPrixDeplacement.Text);
            }
            else
            {
                dblPrixDeplacement = 0d;
            }
            //Prix de l'unité mobile
            if (Information.IsNumeric(lblPrixUniteMobile.Text))
            {
                dblPrixUniteMobile = double.Parse(lblPrixUniteMobile.Text);
            }
            else
            {
                dblPrixUniteMobile = 0d;
            }
            //Prix de transport et emballage
            if (Information.IsNumeric(txtPrixEmballage.Text))
            {
                dblPrixEmballage = double.Parse(txtPrixEmballage.Text);
            }
            else
            {
                dblPrixEmballage = 0d;
            }
            dblTotalArgentRH = dblPrixDessin + dblPrixCoupe + dblPrixMachinage + dblPrixSoudure + dblPrixAssemblage + dblPrixPeinture + dblPrixTest + dblPrixInstallation + dblPrixFormation + dblPrixGestion + dblPrixShipping;//dblPrixPrototype
            lblTotalPrixRH.Text = dblTotalArgentRH.ToString();
            dblTotal = dblTotalArgentRH + dblPrixHebergement + dblPrixRepas + dblPrixDeplacement + dblPrixUniteMobile + dblPrixEmballage;
            lblTotal.Text = dblTotal.ToString();
            CalculerTotalTemps();
            return;
        }
        private void CalculerTotalTemps()
        {
            try
            {
                double dblTempsDessin;
                double dblTempsCoupe;
                double dblTempsMachinage;
                double dblTempsSoudure;
                double dblTempsAssemblage;
                double dblTempsPeinture;
                double dblTempsTest;
                double dblTempsInstallation;
                double dblTempsFormation;
                double dblTempsGestion;
                double dblTempsShipping;
                double dblTotalTemps;
                // SOUMISSION
                if (Information.IsNumeric(txtTempsDessinSoum.Text))
                {
                    dblTempsDessin = double.Parse(txtTempsDessinSoum.Text);
                }
                else
                {
                    dblTempsDessin = 0d;
                }
                if (Information.IsNumeric(txtTempsCoupeSoum.Text))
                {
                    dblTempsCoupe = double.Parse(txtTempsCoupeSoum.Text);
                }
                else
                {
                    dblTempsCoupe = 0d;
                }
                if (Information.IsNumeric(txtTempsMachinageSoum.Text))
                {
                    dblTempsMachinage = double.Parse(txtTempsMachinageSoum.Text);
                }
                else
                {
                    dblTempsMachinage = 0d;
                }
                if (Information.IsNumeric(txtTempsSoudureSoum.Text))
                {
                    dblTempsSoudure = double.Parse(txtTempsSoudureSoum.Text);
                }
                else
                {
                    dblTempsSoudure = 0d;
                }
                if (Information.IsNumeric(txtTempsAssemblageSoum.Text))
                {
                    dblTempsAssemblage = double.Parse(txtTempsAssemblageSoum.Text);
                }
                else
                {
                    dblTempsAssemblage = 0d;
                }
                if (Information.IsNumeric(txtTempsPeintureSoum.Text))
                {
                    dblTempsPeinture = double.Parse(txtTempsPeintureSoum.Text);
                }
                else
                {
                    dblTempsPeinture = 0d;
                }
                if (Information.IsNumeric(txtTempsTestSoum.Text))
                {
                    dblTempsTest = double.Parse(txtTempsTestSoum.Text);
                }
                else
                {
                    dblTempsTest = 0d;
                }
                if (Information.IsNumeric(txtTempsInstallationSoum.Text))
                {
                    dblTempsInstallation = double.Parse(txtTempsInstallationSoum.Text);
                }
                else
                {
                    dblTempsInstallation = 0d;
                }
                if (Information.IsNumeric(txtTempsFormationSoum.Text))
                {
                    dblTempsFormation = double.Parse(txtTempsFormationSoum.Text);
                }
                else
                {
                    dblTempsFormation = 0d;
                }
                if (Information.IsNumeric(txtTempsGestionSoum.Text))
                {
                    dblTempsGestion = double.Parse(txtTempsGestionSoum.Text);
                }
                else
                {
                    dblTempsGestion = 0d;
                }
                if (Information.IsNumeric(txtTempsShippingSoum.Text))
                {
                    dblTempsShipping = double.Parse(txtTempsShippingSoum.Text);
                }
                else
                {
                    dblTempsShipping = 0d;
                }
                dblTotalTemps = dblTempsDessin + dblTempsCoupe + dblTempsMachinage + dblTempsSoudure + dblTempsAssemblage + dblTempsPeinture + dblTempsTest + dblTempsInstallation + dblTempsFormation + dblTempsGestion + dblTempsShipping;
                lblTotalTempsRHSoum.Text = dblTotalTemps.ToString();
                // PROJET
                if (m_eType == EnumType.TYPE_PROJET)
                {
                    if (Information.IsNumeric(txtTempsDessinProj.Text))
                    {
                        dblTempsDessin = double.Parse(txtTempsDessinProj.Text);
                    }
                    else
                    {
                        dblTempsDessin = 0d;
                    }
                    if (Information.IsNumeric(txtTempsCoupeProj.Text))
                    {
                        dblTempsCoupe = double.Parse(txtTempsCoupeProj.Text);
                    }
                    else
                    {
                        dblTempsCoupe = 0d;
                    }
                    if (Information.IsNumeric(txtTempsMachinageProj.Text))
                    {
                        dblTempsMachinage = double.Parse(txtTempsMachinageProj.Text);
                    }
                    else
                    {
                        dblTempsMachinage = 0d;
                    }
                    if (Information.IsNumeric(txtTempsSoudureProj.Text))
                    {
                        dblTempsSoudure = double.Parse(txtTempsSoudureProj.Text);
                    }
                    else
                    {
                        dblTempsSoudure = 0d;
                    }
                    if (Information.IsNumeric(txtTempsAssemblageProj.Text))
                    {
                        dblTempsAssemblage = double.Parse(txtTempsAssemblageProj.Text);
                    }
                    else
                    {
                        dblTempsAssemblage = 0d;
                    }
                    if (Information.IsNumeric(txtTempsPeintureProj.Text))
                    {
                        dblTempsPeinture = double.Parse(txtTempsPeintureProj.Text);
                    }
                    else
                    {
                        dblTempsPeinture = 0d;
                    }
                    if (Information.IsNumeric(txtTempsTestProj.Text))
                    {
                        dblTempsTest = double.Parse(txtTempsTestProj.Text);
                    }
                    else
                    {
                        dblTempsTest = 0d;
                    }
                    if (Information.IsNumeric(txtTempsInstallationProj.Text))
                    {
                        dblTempsInstallation = double.Parse(txtTempsInstallationProj.Text);
                    }
                    else
                    {
                        dblTempsInstallation = 0d;
                    }
                    if (Information.IsNumeric(txtTempsFormationProj.Text))
                    {
                        dblTempsFormation = double.Parse(txtTempsFormationProj.Text);
                    }
                    else
                    {
                        dblTempsFormation = 0d;
                    }
                    if (Information.IsNumeric(txtTempsGestionProj.Text))
                    {
                        dblTempsGestion = double.Parse(txtTempsGestionProj.Text);
                    }
                    else
                    {
                        dblTempsGestion = 0d;
                    }
                    if (Information.IsNumeric(txtTempsShippingProj.Text))
                    {
                        dblTempsShipping = double.Parse(txtTempsShippingProj.Text);
                    }
                    else
                    {
                        dblTempsShipping = 0d;
                    }
                    if (Information.IsNumeric(txtTempsPrototypeProj.Text))
                    {
                    dblTempsPrototype = double.Parse(txtTempsPrototypeProj.Text);
                    }
                    else
                    {
                        dblTempsPrototype = 0;
                    }

                    dblTotalTemps = dblTempsDessin + dblTempsCoupe + dblTempsMachinage + dblTempsSoudure + dblTempsAssemblage + dblTempsPeinture + dblTempsTest + dblTempsInstallation + dblTempsFormation + dblTempsGestion + dblTempsShipping;
                    // dblTempsPrototype
                    lblTotalTempsRHProj.Text = dblTotalTemps.ToString();
                }
                // CONCEPTION
                if (m_eType == EnumType.TYPE_PROJET & m_bLocked == true)
                {
                    if (Information.IsNumeric(txtTempsDessinConc.Text))
                    {
                        dblTempsDessin = double.Parse(txtTempsDessinConc.Text);
                    }
                    else
                    {
                        dblTempsDessin = 0d;
                    }
                    if (Information.IsNumeric(txtTempsCoupeConc.Text))
                    {
                        dblTempsCoupe = double.Parse(txtTempsCoupeConc.Text);
                    }
                    else
                    {
                        dblTempsCoupe = 0d;
                    }
                    if (Information.IsNumeric(txtTempsMachinageConc.Text))
                    {
                        dblTempsMachinage = double.Parse(txtTempsMachinageConc.Text);
                    }
                    else
                    {
                        dblTempsMachinage = 0d;
                    }
                    if (Information.IsNumeric(txtTempsSoudureConc.Text))
                    {
                        dblTempsSoudure = double.Parse(txtTempsSoudureConc.Text);
                    }
                    else
                    {
                        dblTempsSoudure = 0d;
                    }
                    if (Information.IsNumeric(txtTempsAssemblageConc.Text))
                    {
                        dblTempsAssemblage = double.Parse(txtTempsAssemblageConc.Text);
                    }
                    else
                    {
                        dblTempsAssemblage = 0d;
                    }
                    if (Information.IsNumeric(txtTempsPeintureConc.Text))
                    {
                        dblTempsPeinture = double.Parse(txtTempsPeintureConc.Text);
                    }
                    else
                    {
                        dblTempsPeinture = 0d;
                    }
                    if (Information.IsNumeric(txtTempsTestConc.Text))
                    {
                        dblTempsTest = double.Parse(txtTempsTestConc.Text);
                    }
                    else
                    {
                        dblTempsTest = 0d;
                    }
                    if (Information.IsNumeric(txtTempsInstallationConc.Text))
                    {
                        dblTempsInstallation = double.Parse(txtTempsInstallationConc.Text);
                    }
                    else
                    {
                        dblTempsInstallation = 0d;
                    }
                    if (Information.IsNumeric(txtTempsFormationConc.Text))
                    {
                        dblTempsFormation = double.Parse(txtTempsFormationConc.Text);
                    }
                    else
                    {
                        dblTempsFormation = 0d;
                    }
                    if (Information.IsNumeric(txtTempsGestionConc.Text))
                    {
                        dblTempsGestion = double.Parse(txtTempsGestionConc.Text);
                    }
                    else
                    {
                        dblTempsGestion = 0d;
                    }
                    if (Information.IsNumeric(txtTempsShippingConc.Text))
                    {
                        dblTempsShipping = double.Parse(txtTempsShippingConc.Text);
                    }
                    else
                    {
                        dblTempsShipping = 0d;
                    }
                    dblTotalTemps = dblTempsDessin + dblTempsCoupe + dblTempsMachinage + dblTempsSoudure + dblTempsAssemblage + dblTempsPeinture + dblTempsTest + dblTempsInstallation + dblTempsFormation + dblTempsGestion + dblTempsShipping;
                    lblTotalTempsRHConc.Text = dblTotalTemps.ToString();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumMecTemps", "CalculerTotalTemps", ex);
            }
        }
    }
}