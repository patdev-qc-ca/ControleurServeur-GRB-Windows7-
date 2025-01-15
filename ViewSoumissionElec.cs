using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleurServeur;
namespace ControleurServeur
{
    public class ViewSoumissionElec : Form
    {
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSoumissionElec));
            label66 = new System.Windows.Forms.Label();
            lblTotalTempsRHReel = new System.Windows.Forms.Label();
            label69 = new System.Windows.Forms.Label();
            label74 = new System.Windows.Forms.Label();
            lblTempsShippingReel = new System.Windows.Forms.Label();
            lblTauxShipping = new System.Windows.Forms.Label();
            lblTitreShipping = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            lblTempsGestionReel = new System.Windows.Forms.Label();
            lblTauxGestion = new System.Windows.Forms.Label();
            lblTitreGestion = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            lblTempsFormationReel = new System.Windows.Forms.Label();
            lblTauxFormation = new System.Windows.Forms.Label();
            lblTitreFormation = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            lblTempsMiseServiceReel = new System.Windows.Forms.Label();
            lblTauxMiseService = new System.Windows.Forms.Label();
            lblTitreMiseService = new System.Windows.Forms.Label();
            label42 = new System.Windows.Forms.Label();
            lblTempsInstallationReel = new System.Windows.Forms.Label();
            lblTauxInstallation = new System.Windows.Forms.Label();
            lblTitreInstallation = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            lblTempsTestReel = new System.Windows.Forms.Label();
            lblTauxTest = new System.Windows.Forms.Label();
            lblTitreTest = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            lblTempsVisionReel = new System.Windows.Forms.Label();
            lblTauxVision = new System.Windows.Forms.Label();
            lblTitreVision = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            lblTempsProgRobotReel = new System.Windows.Forms.Label();
            lblTauxProgRobot = new System.Windows.Forms.Label();
            lblTitreProgRobot = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            lblTempsProgAutomateReel = new System.Windows.Forms.Label();
            lblTauxProgAutomate = new System.Windows.Forms.Label();
            lblTitreProgAutomate = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            lblTempsProgInterfaceReel = new System.Windows.Forms.Label();
            lblTauxProgInterface = new System.Windows.Forms.Label();
            lblTitreProgInterface = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            lblTempsAssemblageReel = new System.Windows.Forms.Label();
            lblTauxAssemblage = new System.Windows.Forms.Label();
            lblTitreAssemblage = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblTempsFabricationReel = new System.Windows.Forms.Label();
            lblTauxFabrication = new System.Windows.Forms.Label();
            lblTitreFabrication = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblTitreTemps = new System.Windows.Forms.Label();
            lblTitreTauxHoraire = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblTempsDessinReel = new System.Windows.Forms.Label();
            lblTauxDessin = new System.Windows.Forms.Label();
            lblTitreDessin = new System.Windows.Forms.Label();
            lblProjet = new System.Windows.Forms.Label();
            lblTitreProjet = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblGrosTitre = new System.Windows.Forms.Label();
            lblTitreSoumission = new System.Windows.Forms.Label();
            lblSoumission = new System.Windows.Forms.Label();
            lbldescription = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            lblTempsDessinSoum = new System.Windows.Forms.Label();
            lblTempsFabricationSoum = new System.Windows.Forms.Label();
            lblTempsAssemblageSoum = new System.Windows.Forms.Label();
            lblTempsTestSoum = new System.Windows.Forms.Label();
            lblTempsProgInterfaceSoum = new System.Windows.Forms.Label();
            lblTempsProgAutomateSoum = new System.Windows.Forms.Label();
            lblTempsProgRobotSoum = new System.Windows.Forms.Label();
            lblTempsVisionSoum = new System.Windows.Forms.Label();
            lblTempsInstallationSoum = new System.Windows.Forms.Label();
            lblTempsMiseServiceSoum = new System.Windows.Forms.Label();
            lblTempsFormationSoum = new System.Windows.Forms.Label();
            lblTempsGestionSoum = new System.Windows.Forms.Label();
            lblTempsShippingSoum = new System.Windows.Forms.Label();
            lblTauxRepas = new System.Windows.Forms.Label();
            lblTitreRepas = new System.Windows.Forms.Label();
            lblTauxHebergement2 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            lblTauxHebergement1 = new System.Windows.Forms.Label();
            lblTitreHebergement1 = new System.Windows.Forms.Label();
            lblNbrePersonne = new System.Windows.Forms.Label();
            lblTitreNbrePersonne = new System.Windows.Forms.Label();
            lblPrixManuel = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            lblPrixEmballage = new System.Windows.Forms.Label();
            lblTitreTransportEmballage = new System.Windows.Forms.Label();
            lblTauxUniteMobile = new System.Windows.Forms.Label();
            lblTitreTransportUniteMobile = new System.Windows.Forms.Label();
            lblTauxTransport = new System.Windows.Forms.Label();
            lblTitreTransportDeplacement = new System.Windows.Forms.Label();
            lblTempsUniteMobile = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            lblTempsTransport = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            lblTempsRepas = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            lblTempsHebergement = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            lblTitreQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreNoItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreManufacturier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreCoutant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreFournisseur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lbl_Profit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lbl_DateCommande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lbl_DateReception = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            shpCadrePrixReception = new System.Windows.Forms.Panel();
            lblPrixReception = new System.Windows.Forms.Label();
            lblTitrePrixReception = new System.Windows.Forms.Label();
            shpCadrePrixSoumission = new System.Windows.Forms.Panel();
            lblPrixSoumission = new System.Windows.Forms.Label();
            lblTitrePrixSoumission = new System.Windows.Forms.Label();
            shpCadreForfait = new System.Windows.Forms.Panel();
            lblForfait = new System.Windows.Forms.Label();
            lblTitreForfait = new System.Windows.Forms.Label();
            lblCommission = new System.Windows.Forms.Label();
            lblImprevue = new System.Windows.Forms.Label();
            lblProfit = new System.Windows.Forms.Label();
            lblGrandTotalAR = new System.Windows.Forms.Label();
            lblTitreGrandTotal = new System.Windows.Forms.Label();
            lblcommissionAR = new System.Windows.Forms.Label();
            lblTitreCommission = new System.Windows.Forms.Label();
            lblAutre = new System.Windows.Forms.Label();
            lblTitreAutre = new System.Windows.Forms.Label();
            lblTotalTempsAR = new System.Windows.Forms.Label();
            lblTitreTotalTemps = new System.Windows.Forms.Label();
            lblImprevueAR = new System.Windows.Forms.Label();
            lblTitreImprevue = new System.Windows.Forms.Label();
            lblTotalProfit = new System.Windows.Forms.Label();
            lblTitreProfitGlobal = new System.Windows.Forms.Label();
            lblTotalPieceAR = new System.Windows.Forms.Label();
            lblTitreTotalPiece = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblNoPage = new System.Windows.Forms.ToolStripStatusLabel();
            lblclient = new System.Windows.Forms.Label();
            lblTitreClient = new System.Windows.Forms.Label();
            lblcontact = new System.Windows.Forms.Label();
            lblTitreContact = new System.Windows.Forms.Label();
            lblNoFacture = new System.Windows.Forms.Label();
            lblTitreNoFacture = new System.Windows.Forms.Label();
            lblTotalTempsRHSoum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            shpCadrePrixReception.SuspendLayout();
            shpCadrePrixSoumission.SuspendLayout();
            shpCadreForfait.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.BackColor = System.Drawing.Color.White;
            label66.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label66.Location = new System.Drawing.Point(353, 713);
            label66.Margin = new System.Windows.Forms.Padding(0);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(40, 13);
            label66.TabIndex = 663;
            label66.Text = "heures";
            // 
            // lblTotalTempsRHReel
            // 
            lblTotalTempsRHReel.BackColor = System.Drawing.Color.White;
            lblTotalTempsRHReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsRHReel.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsRHReel.Location = new System.Drawing.Point(301, 713);
            lblTotalTempsRHReel.Name = "lblTotalTempsRHReel";
            lblTotalTempsRHReel.Size = new System.Drawing.Size(50, 17);
            lblTotalTempsRHReel.TabIndex = 662;
            lblTotalTempsRHReel.Text = "lblTotalTempsRHReel";
            lblTotalTempsRHReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.BackColor = System.Drawing.Color.White;
            label69.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label69.Location = new System.Drawing.Point(218, 715);
            label69.Name = "label69";
            label69.Size = new System.Drawing.Size(30, 13);
            label69.TabIndex = 661;
            label69.Text = "Total";
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.BackColor = System.Drawing.Color.White;
            label74.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label74.Location = new System.Drawing.Point(352, 689);
            label74.Margin = new System.Windows.Forms.Padding(0);
            label74.Name = "label74";
            label74.Size = new System.Drawing.Size(40, 13);
            label74.TabIndex = 655;
            label74.Text = "heures";
            // 
            // lblTempsShippingReel
            // 
            lblTempsShippingReel.BackColor = System.Drawing.Color.White;
            lblTempsShippingReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingReel.Location = new System.Drawing.Point(300, 687);
            lblTempsShippingReel.Name = "lblTempsShippingReel";
            lblTempsShippingReel.Size = new System.Drawing.Size(50, 19);
            lblTempsShippingReel.TabIndex = 654;
            lblTempsShippingReel.Text = "0";
            lblTempsShippingReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxShipping
            // 
            lblTauxShipping.BackColor = System.Drawing.Color.White;
            lblTauxShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxShipping.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxShipping.Location = new System.Drawing.Point(198, 687);
            lblTauxShipping.Name = "lblTauxShipping";
            lblTauxShipping.Size = new System.Drawing.Size(50, 19);
            lblTauxShipping.TabIndex = 652;
            lblTauxShipping.Text = "lblTauxShipping";
            lblTauxShipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTauxShipping.Click += new System.EventHandler(lblTempsShippingEstime_Click);
            // 
            // lblTitreShipping
            // 
            lblTitreShipping.AutoSize = true;
            lblTitreShipping.BackColor = System.Drawing.Color.White;
            lblTitreShipping.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreShipping.Location = new System.Drawing.Point(10, 686);
            lblTitreShipping.Name = "lblTitreShipping";
            lblTitreShipping.Size = new System.Drawing.Size(81, 13);
            lblTitreShipping.TabIndex = 653;
            lblTitreShipping.Text = "lblTitreShipping";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = System.Drawing.Color.White;
            label30.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.Location = new System.Drawing.Point(352, 671);
            label30.Margin = new System.Windows.Forms.Padding(0);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(40, 13);
            label30.TabIndex = 651;
            label30.Text = "heures";
            // 
            // lblTempsGestionReel
            // 
            lblTempsGestionReel.BackColor = System.Drawing.Color.White;
            lblTempsGestionReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionReel.Location = new System.Drawing.Point(300, 667);
            lblTempsGestionReel.Name = "lblTempsGestionReel";
            lblTempsGestionReel.Size = new System.Drawing.Size(50, 19);
            lblTempsGestionReel.TabIndex = 650;
            lblTempsGestionReel.Text = "0";
            lblTempsGestionReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxGestion
            // 
            lblTauxGestion.BackColor = System.Drawing.Color.White;
            lblTauxGestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxGestion.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxGestion.Location = new System.Drawing.Point(198, 667);
            lblTauxGestion.Name = "lblTauxGestion";
            lblTauxGestion.Size = new System.Drawing.Size(50, 19);
            lblTauxGestion.TabIndex = 648;
            lblTauxGestion.Text = "lblTauxGestion";
            lblTauxGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreGestion
            // 
            lblTitreGestion.AutoSize = true;
            lblTitreGestion.BackColor = System.Drawing.Color.White;
            lblTitreGestion.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreGestion.Location = new System.Drawing.Point(10, 668);
            lblTitreGestion.Name = "lblTitreGestion";
            lblTitreGestion.Size = new System.Drawing.Size(77, 13);
            lblTitreGestion.TabIndex = 649;
            lblTitreGestion.Text = "lblTitreGestion";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = System.Drawing.Color.White;
            label34.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(352, 651);
            label34.Margin = new System.Windows.Forms.Padding(0);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(40, 13);
            label34.TabIndex = 647;
            label34.Text = "heures";
            // 
            // lblTempsFormationReel
            // 
            lblTempsFormationReel.BackColor = System.Drawing.Color.White;
            lblTempsFormationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationReel.Location = new System.Drawing.Point(300, 647);
            lblTempsFormationReel.Name = "lblTempsFormationReel";
            lblTempsFormationReel.Size = new System.Drawing.Size(50, 19);
            lblTempsFormationReel.TabIndex = 646;
            lblTempsFormationReel.Text = "0";
            lblTempsFormationReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxFormation
            // 
            lblTauxFormation.BackColor = System.Drawing.Color.White;
            lblTauxFormation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxFormation.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxFormation.Location = new System.Drawing.Point(198, 647);
            lblTauxFormation.Name = "lblTauxFormation";
            lblTauxFormation.Size = new System.Drawing.Size(50, 19);
            lblTauxFormation.TabIndex = 644;
            lblTauxFormation.Text = "lblTauxFormation";
            lblTauxFormation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreFormation
            // 
            lblTitreFormation.AutoSize = true;
            lblTitreFormation.BackColor = System.Drawing.Color.White;
            lblTitreFormation.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreFormation.Location = new System.Drawing.Point(10, 648);
            lblTitreFormation.Name = "lblTitreFormation";
            lblTitreFormation.Size = new System.Drawing.Size(89, 13);
            lblTitreFormation.TabIndex = 645;
            lblTitreFormation.Text = "lblTitreFormation";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = System.Drawing.Color.White;
            label38.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.Location = new System.Drawing.Point(352, 631);
            label38.Margin = new System.Windows.Forms.Padding(0);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(40, 13);
            label38.TabIndex = 643;
            label38.Text = "heures";
            // 
            // lblTempsMiseServiceReel
            // 
            lblTempsMiseServiceReel.BackColor = System.Drawing.Color.White;
            lblTempsMiseServiceReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMiseServiceReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMiseServiceReel.Location = new System.Drawing.Point(300, 627);
            lblTempsMiseServiceReel.Name = "lblTempsMiseServiceReel";
            lblTempsMiseServiceReel.Size = new System.Drawing.Size(50, 19);
            lblTempsMiseServiceReel.TabIndex = 642;
            lblTempsMiseServiceReel.Text = "0";
            lblTempsMiseServiceReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxMiseService
            // 
            lblTauxMiseService.BackColor = System.Drawing.Color.White;
            lblTauxMiseService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxMiseService.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxMiseService.Location = new System.Drawing.Point(198, 627);
            lblTauxMiseService.Name = "lblTauxMiseService";
            lblTauxMiseService.Size = new System.Drawing.Size(50, 19);
            lblTauxMiseService.TabIndex = 640;
            lblTauxMiseService.Text = "lblTauxMiseService";
            lblTauxMiseService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreMiseService
            // 
            lblTitreMiseService.AutoSize = true;
            lblTitreMiseService.BackColor = System.Drawing.Color.White;
            lblTitreMiseService.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreMiseService.Location = new System.Drawing.Point(10, 628);
            lblTitreMiseService.Name = "lblTitreMiseService";
            lblTitreMiseService.Size = new System.Drawing.Size(98, 13);
            lblTitreMiseService.TabIndex = 641;
            lblTitreMiseService.Text = "lblTitreMiseService";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = System.Drawing.Color.White;
            label42.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.Location = new System.Drawing.Point(352, 611);
            label42.Margin = new System.Windows.Forms.Padding(0);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(40, 13);
            label42.TabIndex = 639;
            label42.Text = "heures";
            // 
            // lblTempsInstallationReel
            // 
            lblTempsInstallationReel.BackColor = System.Drawing.Color.White;
            lblTempsInstallationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsInstallationReel.Location = new System.Drawing.Point(300, 607);
            lblTempsInstallationReel.Name = "lblTempsInstallationReel";
            lblTempsInstallationReel.Size = new System.Drawing.Size(50, 19);
            lblTempsInstallationReel.TabIndex = 638;
            lblTempsInstallationReel.Text = "0";
            lblTempsInstallationReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxInstallation
            // 
            lblTauxInstallation.BackColor = System.Drawing.Color.White;
            lblTauxInstallation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxInstallation.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxInstallation.Location = new System.Drawing.Point(198, 607);
            lblTauxInstallation.Name = "lblTauxInstallation";
            lblTauxInstallation.Size = new System.Drawing.Size(50, 19);
            lblTauxInstallation.TabIndex = 636;
            lblTauxInstallation.Text = "lblTauxInstallation";
            lblTauxInstallation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreInstallation
            // 
            lblTitreInstallation.AutoSize = true;
            lblTitreInstallation.BackColor = System.Drawing.Color.White;
            lblTitreInstallation.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreInstallation.Location = new System.Drawing.Point(10, 608);
            lblTitreInstallation.Name = "lblTitreInstallation";
            lblTitreInstallation.Size = new System.Drawing.Size(95, 13);
            lblTitreInstallation.TabIndex = 637;
            lblTitreInstallation.Text = "lblTitreInstallation";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = System.Drawing.Color.White;
            label46.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.Location = new System.Drawing.Point(352, 591);
            label46.Margin = new System.Windows.Forms.Padding(0);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(40, 13);
            label46.TabIndex = 635;
            label46.Text = "heures";
            // 
            // lblTempsTestReel
            // 
            lblTempsTestReel.BackColor = System.Drawing.Color.White;
            lblTempsTestReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestReel.Location = new System.Drawing.Point(300, 587);
            lblTempsTestReel.Name = "lblTempsTestReel";
            lblTempsTestReel.Size = new System.Drawing.Size(50, 19);
            lblTempsTestReel.TabIndex = 634;
            lblTempsTestReel.Text = "0";
            lblTempsTestReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxTest
            // 
            lblTauxTest.BackColor = System.Drawing.Color.White;
            lblTauxTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxTest.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxTest.Location = new System.Drawing.Point(198, 587);
            lblTauxTest.Name = "lblTauxTest";
            lblTauxTest.Size = new System.Drawing.Size(50, 19);
            lblTauxTest.TabIndex = 632;
            lblTauxTest.Text = "lblTauxTest";
            lblTauxTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTest
            // 
            lblTitreTest.AutoSize = true;
            lblTitreTest.BackColor = System.Drawing.Color.White;
            lblTitreTest.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTest.Location = new System.Drawing.Point(10, 588);
            lblTitreTest.Name = "lblTitreTest";
            lblTitreTest.Size = new System.Drawing.Size(60, 13);
            lblTitreTest.TabIndex = 633;
            lblTitreTest.Text = "lblTitreTest";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.BackColor = System.Drawing.Color.White;
            label50.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.Location = new System.Drawing.Point(352, 571);
            label50.Margin = new System.Windows.Forms.Padding(0);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(40, 13);
            label50.TabIndex = 631;
            label50.Text = "heures";
            // 
            // lblTempsVisionReel
            // 
            lblTempsVisionReel.BackColor = System.Drawing.Color.White;
            lblTempsVisionReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsVisionReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsVisionReel.Location = new System.Drawing.Point(300, 567);
            lblTempsVisionReel.Name = "lblTempsVisionReel";
            lblTempsVisionReel.Size = new System.Drawing.Size(50, 19);
            lblTempsVisionReel.TabIndex = 630;
            lblTempsVisionReel.Text = "0";
            lblTempsVisionReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxVision
            // 
            lblTauxVision.BackColor = System.Drawing.Color.White;
            lblTauxVision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxVision.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxVision.Location = new System.Drawing.Point(198, 567);
            lblTauxVision.Name = "lblTauxVision";
            lblTauxVision.Size = new System.Drawing.Size(50, 19);
            lblTauxVision.TabIndex = 628;
            lblTauxVision.Text = "lblTauxVision";
            lblTauxVision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreVision
            // 
            lblTitreVision.AutoSize = true;
            lblTitreVision.BackColor = System.Drawing.Color.White;
            lblTitreVision.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreVision.Location = new System.Drawing.Point(10, 568);
            lblTitreVision.Name = "lblTitreVision";
            lblTitreVision.Size = new System.Drawing.Size(70, 13);
            lblTitreVision.TabIndex = 629;
            lblTitreVision.Text = "lblTitreVision";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = System.Drawing.Color.White;
            label22.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.Location = new System.Drawing.Point(352, 551);
            label22.Margin = new System.Windows.Forms.Padding(0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(40, 13);
            label22.TabIndex = 627;
            label22.Text = "heures";
            // 
            // lblTempsProgRobotReel
            // 
            lblTempsProgRobotReel.BackColor = System.Drawing.Color.White;
            lblTempsProgRobotReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgRobotReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgRobotReel.Location = new System.Drawing.Point(300, 547);
            lblTempsProgRobotReel.Name = "lblTempsProgRobotReel";
            lblTempsProgRobotReel.Size = new System.Drawing.Size(50, 19);
            lblTempsProgRobotReel.TabIndex = 626;
            lblTempsProgRobotReel.Text = "0";
            lblTempsProgRobotReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxProgRobot
            // 
            lblTauxProgRobot.BackColor = System.Drawing.Color.White;
            lblTauxProgRobot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxProgRobot.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxProgRobot.Location = new System.Drawing.Point(198, 547);
            lblTauxProgRobot.Name = "lblTauxProgRobot";
            lblTauxProgRobot.Size = new System.Drawing.Size(50, 19);
            lblTauxProgRobot.TabIndex = 624;
            lblTauxProgRobot.Text = "lblTauxProgRobot";
            lblTauxProgRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProgRobot
            // 
            lblTitreProgRobot.AutoSize = true;
            lblTitreProgRobot.BackColor = System.Drawing.Color.White;
            lblTitreProgRobot.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProgRobot.Location = new System.Drawing.Point(10, 548);
            lblTitreProgRobot.Name = "lblTitreProgRobot";
            lblTitreProgRobot.Size = new System.Drawing.Size(90, 13);
            lblTitreProgRobot.TabIndex = 625;
            lblTitreProgRobot.Text = "lblTitreProgRobot";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.White;
            label26.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(352, 531);
            label26.Margin = new System.Windows.Forms.Padding(0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(40, 13);
            label26.TabIndex = 623;
            label26.Text = "heures";
            // 
            // lblTempsProgAutomateReel
            // 
            lblTempsProgAutomateReel.BackColor = System.Drawing.Color.White;
            lblTempsProgAutomateReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgAutomateReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgAutomateReel.Location = new System.Drawing.Point(300, 527);
            lblTempsProgAutomateReel.Name = "lblTempsProgAutomateReel";
            lblTempsProgAutomateReel.Size = new System.Drawing.Size(50, 19);
            lblTempsProgAutomateReel.TabIndex = 622;
            lblTempsProgAutomateReel.Text = "0";
            lblTempsProgAutomateReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxProgAutomate
            // 
            lblTauxProgAutomate.BackColor = System.Drawing.Color.White;
            lblTauxProgAutomate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxProgAutomate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxProgAutomate.Location = new System.Drawing.Point(198, 527);
            lblTauxProgAutomate.Name = "lblTauxProgAutomate";
            lblTauxProgAutomate.Size = new System.Drawing.Size(50, 19);
            lblTauxProgAutomate.TabIndex = 620;
            lblTauxProgAutomate.Text = "lblTauxProgAutomate";
            lblTauxProgAutomate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProgAutomate
            // 
            lblTitreProgAutomate.AutoSize = true;
            lblTitreProgAutomate.BackColor = System.Drawing.Color.White;
            lblTitreProgAutomate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProgAutomate.Location = new System.Drawing.Point(10, 528);
            lblTitreProgAutomate.Name = "lblTitreProgAutomate";
            lblTitreProgAutomate.Size = new System.Drawing.Size(109, 13);
            lblTitreProgAutomate.TabIndex = 621;
            lblTitreProgAutomate.Text = "lblTitreProgAutomate";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.White;
            label14.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(352, 511);
            label14.Margin = new System.Windows.Forms.Padding(0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(40, 13);
            label14.TabIndex = 619;
            label14.Text = "heures";
            // 
            // lblTempsProgInterfaceReel
            // 
            lblTempsProgInterfaceReel.BackColor = System.Drawing.Color.White;
            lblTempsProgInterfaceReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgInterfaceReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgInterfaceReel.Location = new System.Drawing.Point(300, 507);
            lblTempsProgInterfaceReel.Name = "lblTempsProgInterfaceReel";
            lblTempsProgInterfaceReel.Size = new System.Drawing.Size(50, 19);
            lblTempsProgInterfaceReel.TabIndex = 618;
            lblTempsProgInterfaceReel.Text = "0";
            lblTempsProgInterfaceReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxProgInterface
            // 
            lblTauxProgInterface.BackColor = System.Drawing.Color.White;
            lblTauxProgInterface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxProgInterface.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxProgInterface.Location = new System.Drawing.Point(198, 507);
            lblTauxProgInterface.Name = "lblTauxProgInterface";
            lblTauxProgInterface.Size = new System.Drawing.Size(50, 19);
            lblTauxProgInterface.TabIndex = 616;
            lblTauxProgInterface.Text = "lblTauxProgInterface";
            lblTauxProgInterface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProgInterface
            // 
            lblTitreProgInterface.AutoSize = true;
            lblTitreProgInterface.BackColor = System.Drawing.Color.White;
            lblTitreProgInterface.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProgInterface.Location = new System.Drawing.Point(10, 508);
            lblTitreProgInterface.Name = "lblTitreProgInterface";
            lblTitreProgInterface.Size = new System.Drawing.Size(105, 13);
            lblTitreProgInterface.TabIndex = 617;
            lblTitreProgInterface.Text = "lblTitreProgInterface";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = System.Drawing.Color.White;
            label18.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.Location = new System.Drawing.Point(352, 491);
            label18.Margin = new System.Windows.Forms.Padding(0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(40, 13);
            label18.TabIndex = 615;
            label18.Text = "heures";
            // 
            // lblTempsAssemblageReel
            // 
            lblTempsAssemblageReel.BackColor = System.Drawing.Color.White;
            lblTempsAssemblageReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsAssemblageReel.Location = new System.Drawing.Point(300, 487);
            lblTempsAssemblageReel.Name = "lblTempsAssemblageReel";
            lblTempsAssemblageReel.Size = new System.Drawing.Size(50, 19);
            lblTempsAssemblageReel.TabIndex = 614;
            lblTempsAssemblageReel.Text = "0";
            lblTempsAssemblageReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxAssemblage
            // 
            lblTauxAssemblage.BackColor = System.Drawing.Color.White;
            lblTauxAssemblage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxAssemblage.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxAssemblage.Location = new System.Drawing.Point(198, 487);
            lblTauxAssemblage.Name = "lblTauxAssemblage";
            lblTauxAssemblage.Size = new System.Drawing.Size(50, 19);
            lblTauxAssemblage.TabIndex = 612;
            lblTauxAssemblage.Text = "lblTauxAssemblage";
            lblTauxAssemblage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreAssemblage
            // 
            lblTitreAssemblage.AutoSize = true;
            lblTitreAssemblage.BackColor = System.Drawing.Color.White;
            lblTitreAssemblage.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreAssemblage.Location = new System.Drawing.Point(10, 488);
            lblTitreAssemblage.Name = "lblTitreAssemblage";
            lblTitreAssemblage.Size = new System.Drawing.Size(98, 13);
            lblTitreAssemblage.TabIndex = 613;
            lblTitreAssemblage.Text = "lblTitreAssemblage";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.White;
            label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(352, 471);
            label9.Margin = new System.Windows.Forms.Padding(0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(40, 13);
            label9.TabIndex = 611;
            label9.Text = "heures";
            // 
            // lblTempsFabricationReel
            // 
            lblTempsFabricationReel.BackColor = System.Drawing.Color.White;
            lblTempsFabricationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFabricationReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFabricationReel.Location = new System.Drawing.Point(300, 467);
            lblTempsFabricationReel.Name = "lblTempsFabricationReel";
            lblTempsFabricationReel.Size = new System.Drawing.Size(50, 19);
            lblTempsFabricationReel.TabIndex = 610;
            lblTempsFabricationReel.Text = "0";
            lblTempsFabricationReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxFabrication
            // 
            lblTauxFabrication.BackColor = System.Drawing.Color.White;
            lblTauxFabrication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxFabrication.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxFabrication.Location = new System.Drawing.Point(198, 467);
            lblTauxFabrication.Name = "lblTauxFabrication";
            lblTauxFabrication.Size = new System.Drawing.Size(50, 19);
            lblTauxFabrication.TabIndex = 608;
            lblTauxFabrication.Text = "lblTauxFabrication";
            lblTauxFabrication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreFabrication
            // 
            lblTitreFabrication.AutoSize = true;
            lblTitreFabrication.BackColor = System.Drawing.Color.White;
            lblTitreFabrication.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreFabrication.Location = new System.Drawing.Point(10, 468);
            lblTitreFabrication.Name = "lblTitreFabrication";
            lblTitreFabrication.Size = new System.Drawing.Size(94, 13);
            lblTitreFabrication.TabIndex = 609;
            lblTitreFabrication.Text = "lblTitreFabrication";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(250, 414);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(48, 18);
            label8.TabIndex = 607;
            label8.Text = "Temps";
            // 
            // lblTitreTemps
            // 
            lblTitreTemps.AutoSize = true;
            lblTitreTemps.BackColor = System.Drawing.Color.White;
            lblTitreTemps.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTemps.Location = new System.Drawing.Point(299, 430);
            lblTitreTemps.Name = "lblTitreTemps";
            lblTitreTemps.Size = new System.Drawing.Size(70, 13);
            lblTitreTemps.TabIndex = 606;
            lblTitreTemps.Text = "lblTitreTemps";
            // 
            // lblTitreTauxHoraire
            // 
            lblTitreTauxHoraire.AutoSize = true;
            lblTitreTauxHoraire.BackColor = System.Drawing.Color.White;
            lblTitreTauxHoraire.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTauxHoraire.Location = new System.Drawing.Point(191, 430);
            lblTitreTauxHoraire.Name = "lblTitreTauxHoraire";
            lblTitreTauxHoraire.Size = new System.Drawing.Size(96, 13);
            lblTitreTauxHoraire.TabIndex = 605;
            lblTitreTauxHoraire.Text = "lblTitreTauxHoraire";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(352, 451);
            label5.Margin = new System.Windows.Forms.Padding(0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 13);
            label5.TabIndex = 604;
            label5.Text = "heures";
            // 
            // lblTempsDessinReel
            // 
            lblTempsDessinReel.BackColor = System.Drawing.Color.White;
            lblTempsDessinReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinReel.Location = new System.Drawing.Point(300, 447);
            lblTempsDessinReel.Name = "lblTempsDessinReel";
            lblTempsDessinReel.Size = new System.Drawing.Size(50, 19);
            lblTempsDessinReel.TabIndex = 603;
            lblTempsDessinReel.Text = "0";
            lblTempsDessinReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxDessin
            // 
            lblTauxDessin.BackColor = System.Drawing.Color.White;
            lblTauxDessin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxDessin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxDessin.Location = new System.Drawing.Point(198, 447);
            lblTauxDessin.Name = "lblTauxDessin";
            lblTauxDessin.Size = new System.Drawing.Size(50, 19);
            lblTauxDessin.TabIndex = 601;
            lblTauxDessin.Text = "lblTauxDessin";
            lblTauxDessin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreDessin
            // 
            lblTitreDessin.AutoSize = true;
            lblTitreDessin.BackColor = System.Drawing.Color.White;
            lblTitreDessin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreDessin.Location = new System.Drawing.Point(10, 448);
            lblTitreDessin.Name = "lblTitreDessin";
            lblTitreDessin.Size = new System.Drawing.Size(73, 13);
            lblTitreDessin.TabIndex = 602;
            lblTitreDessin.Text = "lblTitreDessin";
            // 
            // lblProjet
            // 
            lblProjet.AutoSize = true;
            lblProjet.BackColor = System.Drawing.Color.White;
            lblProjet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjet.Location = new System.Drawing.Point(57, 54);
            lblProjet.Name = "lblProjet";
            lblProjet.Size = new System.Drawing.Size(62, 18);
            lblProjet.TabIndex = 599;
            lblProjet.Text = "lblProjet";
            // 
            // lblTitreProjet
            // 
            lblTitreProjet.AutoSize = true;
            lblTitreProjet.BackColor = System.Drawing.Color.White;
            lblTitreProjet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjet.Location = new System.Drawing.Point(10, 54);
            lblTitreProjet.Name = "lblTitreProjet";
            lblTitreProjet.Size = new System.Drawing.Size(46, 18);
            lblTitreProjet.TabIndex = 600;
            lblTitreProjet.Text = "Projet";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(1003, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(147, 66);
            pictureBox1.TabIndex = 598;
            pictureBox1.TabStop = false;
            // 
            // lblGrosTitre
            // 
            lblGrosTitre.AutoSize = true;
            lblGrosTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGrosTitre.Location = new System.Drawing.Point(228, 9);
            lblGrosTitre.Name = "lblGrosTitre";
            lblGrosTitre.Size = new System.Drawing.Size(157, 36);
            lblGrosTitre.TabIndex = 597;
            lblGrosTitre.Tag = "";
            lblGrosTitre.Text = "lblGrosTitre";
            lblGrosTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitreSoumission
            // 
            lblTitreSoumission.AutoSize = true;
            lblTitreSoumission.BackColor = System.Drawing.Color.White;
            lblTitreSoumission.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreSoumission.Location = new System.Drawing.Point(146, 54);
            lblTitreSoumission.Name = "lblTitreSoumission";
            lblTitreSoumission.Size = new System.Drawing.Size(79, 18);
            lblTitreSoumission.TabIndex = 664;
            lblTitreSoumission.Text = "Soumission";
            // 
            // lblSoumission
            // 
            lblSoumission.AutoSize = true;
            lblSoumission.BackColor = System.Drawing.Color.White;
            lblSoumission.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumission.Location = new System.Drawing.Point(231, 54);
            lblSoumission.Name = "lblSoumission";
            lblSoumission.Size = new System.Drawing.Size(46, 18);
            lblSoumission.TabIndex = 665;
            lblSoumission.Text = "label4";
            // 
            // lbldescription
            // 
            lbldescription.AutoSize = true;
            lbldescription.BackColor = System.Drawing.Color.White;
            lbldescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbldescription.Location = new System.Drawing.Point(90, 72);
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new System.Drawing.Size(94, 18);
            lbldescription.TabIndex = 666;
            lbldescription.Text = "lbldescription";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.White;
            label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(10, 72);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(74, 18);
            label10.TabIndex = 667;
            label10.Text = "Desciption";
            // 
            // lblTempsDessinSoum
            // 
            lblTempsDessinSoum.BackColor = System.Drawing.Color.White;
            lblTempsDessinSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsDessinSoum.Location = new System.Drawing.Point(249, 447);
            lblTempsDessinSoum.Name = "lblTempsDessinSoum";
            lblTempsDessinSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsDessinSoum.TabIndex = 677;
            lblTempsDessinSoum.Text = "lblTempsDessinSoum";
            lblTempsDessinSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsFabricationSoum
            // 
            lblTempsFabricationSoum.BackColor = System.Drawing.Color.White;
            lblTempsFabricationSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFabricationSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFabricationSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsFabricationSoum.Location = new System.Drawing.Point(249, 467);
            lblTempsFabricationSoum.Name = "lblTempsFabricationSoum";
            lblTempsFabricationSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsFabricationSoum.TabIndex = 678;
            lblTempsFabricationSoum.Text = "lblTempsFabricationSoum";
            lblTempsFabricationSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsAssemblageSoum
            // 
            lblTempsAssemblageSoum.BackColor = System.Drawing.Color.White;
            lblTempsAssemblageSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsAssemblageSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsAssemblageSoum.Location = new System.Drawing.Point(249, 488);
            lblTempsAssemblageSoum.Name = "lblTempsAssemblageSoum";
            lblTempsAssemblageSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsAssemblageSoum.TabIndex = 679;
            lblTempsAssemblageSoum.Text = "lblTempsAssemblageSoum";
            lblTempsAssemblageSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsTestSoum
            // 
            lblTempsTestSoum.BackColor = System.Drawing.Color.White;
            lblTempsTestSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsTestSoum.Location = new System.Drawing.Point(249, 587);
            lblTempsTestSoum.Name = "lblTempsTestSoum";
            lblTempsTestSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsTestSoum.TabIndex = 680;
            lblTempsTestSoum.Text = "lblTempsTestSoum";
            lblTempsTestSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsProgInterfaceSoum
            // 
            lblTempsProgInterfaceSoum.BackColor = System.Drawing.Color.White;
            lblTempsProgInterfaceSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgInterfaceSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgInterfaceSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsProgInterfaceSoum.Location = new System.Drawing.Point(249, 508);
            lblTempsProgInterfaceSoum.Name = "lblTempsProgInterfaceSoum";
            lblTempsProgInterfaceSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsProgInterfaceSoum.TabIndex = 668;
            lblTempsProgInterfaceSoum.Text = "lblTempsProgInterfaceSoum";
            lblTempsProgInterfaceSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsProgAutomateSoum
            // 
            lblTempsProgAutomateSoum.BackColor = System.Drawing.Color.White;
            lblTempsProgAutomateSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgAutomateSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgAutomateSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsProgAutomateSoum.Location = new System.Drawing.Point(249, 528);
            lblTempsProgAutomateSoum.Name = "lblTempsProgAutomateSoum";
            lblTempsProgAutomateSoum.Size = new System.Drawing.Size(50, 18);
            lblTempsProgAutomateSoum.TabIndex = 669;
            lblTempsProgAutomateSoum.Text = "lblTempsProgAutomateSoum";
            lblTempsProgAutomateSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsProgRobotSoum
            // 
            lblTempsProgRobotSoum.BackColor = System.Drawing.Color.White;
            lblTempsProgRobotSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgRobotSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgRobotSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsProgRobotSoum.Location = new System.Drawing.Point(249, 547);
            lblTempsProgRobotSoum.Name = "lblTempsProgRobotSoum";
            lblTempsProgRobotSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsProgRobotSoum.TabIndex = 670;
            lblTempsProgRobotSoum.Text = "lblTempsProgRobotSoum";
            lblTempsProgRobotSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsVisionSoum
            // 
            lblTempsVisionSoum.BackColor = System.Drawing.Color.White;
            lblTempsVisionSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsVisionSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsVisionSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsVisionSoum.Location = new System.Drawing.Point(249, 567);
            lblTempsVisionSoum.Name = "lblTempsVisionSoum";
            lblTempsVisionSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsVisionSoum.TabIndex = 671;
            lblTempsVisionSoum.Text = "lblTempsVisionSoum";
            lblTempsVisionSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsInstallationSoum
            // 
            lblTempsInstallationSoum.BackColor = System.Drawing.Color.White;
            lblTempsInstallationSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsInstallationSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsInstallationSoum.Location = new System.Drawing.Point(249, 607);
            lblTempsInstallationSoum.Name = "lblTempsInstallationSoum";
            lblTempsInstallationSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsInstallationSoum.TabIndex = 672;
            lblTempsInstallationSoum.Text = "lblTempsInstallationSoum";
            lblTempsInstallationSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsMiseServiceSoum
            // 
            lblTempsMiseServiceSoum.BackColor = System.Drawing.Color.White;
            lblTempsMiseServiceSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMiseServiceSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMiseServiceSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsMiseServiceSoum.Location = new System.Drawing.Point(249, 627);
            lblTempsMiseServiceSoum.Name = "lblTempsMiseServiceSoum";
            lblTempsMiseServiceSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsMiseServiceSoum.TabIndex = 673;
            lblTempsMiseServiceSoum.Text = "lblTempsMiseServiceSoum";
            lblTempsMiseServiceSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsFormationSoum
            // 
            lblTempsFormationSoum.BackColor = System.Drawing.Color.White;
            lblTempsFormationSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsFormationSoum.Location = new System.Drawing.Point(249, 647);
            lblTempsFormationSoum.Name = "lblTempsFormationSoum";
            lblTempsFormationSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsFormationSoum.TabIndex = 674;
            lblTempsFormationSoum.Text = "lblTempsFormationSoum";
            lblTempsFormationSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsGestionSoum
            // 
            lblTempsGestionSoum.BackColor = System.Drawing.Color.White;
            lblTempsGestionSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsGestionSoum.Location = new System.Drawing.Point(249, 667);
            lblTempsGestionSoum.Name = "lblTempsGestionSoum";
            lblTempsGestionSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsGestionSoum.TabIndex = 675;
            lblTempsGestionSoum.Text = "lblTempsGestionSoum";
            lblTempsGestionSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsShippingSoum
            // 
            lblTempsShippingSoum.BackColor = System.Drawing.Color.White;
            lblTempsShippingSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsShippingSoum.Location = new System.Drawing.Point(249, 687);
            lblTempsShippingSoum.Name = "lblTempsShippingSoum";
            lblTempsShippingSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsShippingSoum.TabIndex = 676;
            lblTempsShippingSoum.Text = "lblTempsShippingSoum";
            lblTempsShippingSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxRepas
            // 
            lblTauxRepas.BackColor = System.Drawing.Color.White;
            lblTauxRepas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxRepas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxRepas.Location = new System.Drawing.Point(605, 602);
            lblTauxRepas.Name = "lblTauxRepas";
            lblTauxRepas.Size = new System.Drawing.Size(50, 19);
            lblTauxRepas.TabIndex = 695;
            lblTauxRepas.Text = "lblTauxRepas";
            lblTauxRepas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreRepas
            // 
            lblTitreRepas.AutoSize = true;
            lblTitreRepas.BackColor = System.Drawing.Color.White;
            lblTitreRepas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreRepas.Location = new System.Drawing.Point(417, 601);
            lblTitreRepas.Name = "lblTitreRepas";
            lblTitreRepas.Size = new System.Drawing.Size(70, 13);
            lblTitreRepas.TabIndex = 696;
            lblTitreRepas.Text = "lblTitreRepas";
            // 
            // lblTauxHebergement2
            // 
            lblTauxHebergement2.BackColor = System.Drawing.Color.White;
            lblTauxHebergement2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxHebergement2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxHebergement2.Location = new System.Drawing.Point(605, 582);
            lblTauxHebergement2.Name = "lblTauxHebergement2";
            lblTauxHebergement2.Size = new System.Drawing.Size(50, 19);
            lblTauxHebergement2.TabIndex = 693;
            lblTauxHebergement2.Text = "lblTauxHebergement2";
            lblTauxHebergement2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = System.Drawing.Color.White;
            label23.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(417, 581);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(108, 13);
            label23.TabIndex = 694;
            label23.Text = "Hébergement (2 lits) :";
            // 
            // lblTauxHebergement1
            // 
            lblTauxHebergement1.BackColor = System.Drawing.Color.White;
            lblTauxHebergement1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxHebergement1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxHebergement1.Location = new System.Drawing.Point(605, 562);
            lblTauxHebergement1.Name = "lblTauxHebergement1";
            lblTauxHebergement1.Size = new System.Drawing.Size(50, 19);
            lblTauxHebergement1.TabIndex = 691;
            lblTauxHebergement1.Text = "lblTauxHebergement1";
            lblTauxHebergement1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreHebergement1
            // 
            lblTitreHebergement1.AutoSize = true;
            lblTitreHebergement1.BackColor = System.Drawing.Color.White;
            lblTitreHebergement1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreHebergement1.Location = new System.Drawing.Point(417, 561);
            lblTitreHebergement1.Name = "lblTitreHebergement1";
            lblTitreHebergement1.Size = new System.Drawing.Size(103, 13);
            lblTitreHebergement1.TabIndex = 692;
            lblTitreHebergement1.Text = "Hébergement (1 lit) :";
            // 
            // lblNbrePersonne
            // 
            lblNbrePersonne.BackColor = System.Drawing.Color.White;
            lblNbrePersonne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblNbrePersonne.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNbrePersonne.Location = new System.Drawing.Point(605, 542);
            lblNbrePersonne.Name = "lblNbrePersonne";
            lblNbrePersonne.Size = new System.Drawing.Size(50, 19);
            lblNbrePersonne.TabIndex = 689;
            lblNbrePersonne.Text = "lblNbrePersonne";
            lblNbrePersonne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreNbrePersonne
            // 
            lblTitreNbrePersonne.AutoSize = true;
            lblTitreNbrePersonne.BackColor = System.Drawing.Color.White;
            lblTitreNbrePersonne.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreNbrePersonne.Location = new System.Drawing.Point(417, 541);
            lblTitreNbrePersonne.Name = "lblTitreNbrePersonne";
            lblTitreNbrePersonne.Size = new System.Drawing.Size(109, 13);
            lblTitreNbrePersonne.TabIndex = 690;
            lblTitreNbrePersonne.Text = "lblTitreNbrePersonne";
            // 
            // lblPrixManuel
            // 
            lblPrixManuel.BackColor = System.Drawing.Color.White;
            lblPrixManuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixManuel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrixManuel.Location = new System.Drawing.Point(605, 683);
            lblPrixManuel.Name = "lblPrixManuel";
            lblPrixManuel.Size = new System.Drawing.Size(50, 19);
            lblPrixManuel.TabIndex = 703;
            lblPrixManuel.Text = "lblPrixManuel";
            lblPrixManuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = System.Drawing.Color.White;
            label27.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.Location = new System.Drawing.Point(417, 682);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(51, 13);
            label27.TabIndex = 704;
            label27.Text = "Manuels:";
            // 
            // lblPrixEmballage
            // 
            lblPrixEmballage.BackColor = System.Drawing.Color.White;
            lblPrixEmballage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixEmballage.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrixEmballage.Location = new System.Drawing.Point(605, 662);
            lblPrixEmballage.Name = "lblPrixEmballage";
            lblPrixEmballage.Size = new System.Drawing.Size(50, 19);
            lblPrixEmballage.TabIndex = 701;
            lblPrixEmballage.Text = "lblPrixEmballage";
            lblPrixEmballage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTransportEmballage
            // 
            lblTitreTransportEmballage.AutoSize = true;
            lblTitreTransportEmballage.BackColor = System.Drawing.Color.White;
            lblTitreTransportEmballage.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTransportEmballage.Location = new System.Drawing.Point(417, 661);
            lblTitreTransportEmballage.Name = "lblTitreTransportEmballage";
            lblTitreTransportEmballage.Size = new System.Drawing.Size(135, 13);
            lblTitreTransportEmballage.TabIndex = 702;
            lblTitreTransportEmballage.Text = "lblTitreTransportEmballage";
            // 
            // lblTauxUniteMobile
            // 
            lblTauxUniteMobile.BackColor = System.Drawing.Color.White;
            lblTauxUniteMobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxUniteMobile.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxUniteMobile.Location = new System.Drawing.Point(605, 642);
            lblTauxUniteMobile.Name = "lblTauxUniteMobile";
            lblTauxUniteMobile.Size = new System.Drawing.Size(50, 19);
            lblTauxUniteMobile.TabIndex = 699;
            lblTauxUniteMobile.Text = "lblTauxUniteMobile";
            lblTauxUniteMobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTransportUniteMobile
            // 
            lblTitreTransportUniteMobile.AutoSize = true;
            lblTitreTransportUniteMobile.BackColor = System.Drawing.Color.White;
            lblTitreTransportUniteMobile.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTransportUniteMobile.Location = new System.Drawing.Point(417, 641);
            lblTitreTransportUniteMobile.Name = "lblTitreTransportUniteMobile";
            lblTitreTransportUniteMobile.Size = new System.Drawing.Size(145, 13);
            lblTitreTransportUniteMobile.TabIndex = 700;
            lblTitreTransportUniteMobile.Text = "lblTitreTransportUniteMobile";
            // 
            // lblTauxTransport
            // 
            lblTauxTransport.BackColor = System.Drawing.Color.White;
            lblTauxTransport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxTransport.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxTransport.Location = new System.Drawing.Point(605, 622);
            lblTauxTransport.Name = "lblTauxTransport";
            lblTauxTransport.Size = new System.Drawing.Size(50, 19);
            lblTauxTransport.TabIndex = 697;
            lblTauxTransport.Text = "lblTauxTransport";
            lblTauxTransport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTransportDeplacement
            // 
            lblTitreTransportDeplacement.AutoSize = true;
            lblTitreTransportDeplacement.BackColor = System.Drawing.Color.White;
            lblTitreTransportDeplacement.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTransportDeplacement.Location = new System.Drawing.Point(417, 622);
            lblTitreTransportDeplacement.Name = "lblTitreTransportDeplacement";
            lblTitreTransportDeplacement.Size = new System.Drawing.Size(150, 13);
            lblTitreTransportDeplacement.TabIndex = 698;
            lblTitreTransportDeplacement.Text = "lblTitreTransportDeplacement";
            // 
            // lblTempsUniteMobile
            // 
            lblTempsUniteMobile.BackColor = System.Drawing.Color.White;
            lblTempsUniteMobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsUniteMobile.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsUniteMobile.Location = new System.Drawing.Point(672, 628);
            lblTempsUniteMobile.Name = "lblTempsUniteMobile";
            lblTempsUniteMobile.Size = new System.Drawing.Size(50, 19);
            lblTempsUniteMobile.TabIndex = 711;
            lblTempsUniteMobile.Text = "lblTempsUniteMobile";
            lblTempsUniteMobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.White;
            label11.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(728, 631);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(21, 13);
            label11.TabIndex = 712;
            label11.Text = "km";
            // 
            // lblTempsTransport
            // 
            lblTempsTransport.BackColor = System.Drawing.Color.White;
            lblTempsTransport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTransport.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTransport.Location = new System.Drawing.Point(672, 608);
            lblTempsTransport.Name = "lblTempsTransport";
            lblTempsTransport.Size = new System.Drawing.Size(50, 19);
            lblTempsTransport.TabIndex = 709;
            lblTempsTransport.Text = "lblTempsTransport";
            lblTempsTransport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.White;
            label15.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(728, 611);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(21, 13);
            label15.TabIndex = 710;
            label15.Text = "km";
            // 
            // lblTempsRepas
            // 
            lblTempsRepas.BackColor = System.Drawing.Color.White;
            lblTempsRepas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsRepas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsRepas.Location = new System.Drawing.Point(672, 588);
            lblTempsRepas.Name = "lblTempsRepas";
            lblTempsRepas.Size = new System.Drawing.Size(50, 19);
            lblTempsRepas.TabIndex = 707;
            lblTempsRepas.Text = "lblTempsRepas";
            lblTempsRepas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = System.Drawing.Color.White;
            label19.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(728, 591);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(31, 13);
            label19.TabIndex = 708;
            label19.Text = "jours";
            // 
            // lblTempsHebergement
            // 
            lblTempsHebergement.BackColor = System.Drawing.Color.White;
            lblTempsHebergement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsHebergement.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsHebergement.Location = new System.Drawing.Point(672, 568);
            lblTempsHebergement.Name = "lblTempsHebergement";
            lblTempsHebergement.Size = new System.Drawing.Size(50, 19);
            lblTempsHebergement.TabIndex = 705;
            lblTempsHebergement.Text = "lblTempsHebergement";
            lblTempsHebergement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = System.Drawing.Color.White;
            label24.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.Location = new System.Drawing.Point(728, 571);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(31, 13);
            label24.TabIndex = 706;
            label24.Text = "jours";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lblTitreQuantite,
            lblTitreNoItem,
            lblTitreDescription,
            lblTitreManufacturier,
            lblTitreCoutant,
            lblTitreFournisseur,
            lblTitreTotal,
            lbl_Profit,
            lbl_DateCommande,
            lbl_DateReception});
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(13, 122);
            listView1.Margin = new System.Windows.Forms.Padding(0);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1123, 292);
            listView1.TabIndex = 713;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // lblTitreQuantite
            // 
            lblTitreQuantite.Text = "Qté";
            // 
            // lblTitreNoItem
            // 
            lblTitreNoItem.Text = "No. Item";
            // 
            // lblTitreDescription
            // 
            lblTitreDescription.Text = "Description";
            lblTitreDescription.Width = 202;
            // 
            // lblTitreManufacturier
            // 
            lblTitreManufacturier.Text = "Manufacturier";
            lblTitreManufacturier.Width = 209;
            // 
            // lblTitreCoutant
            // 
            lblTitreCoutant.Text = "Coutant";
            // 
            // lblTitreFournisseur
            // 
            lblTitreFournisseur.Text = "Fournisseur";
            lblTitreFournisseur.Width = 167;
            // 
            // lblTitreTotal
            // 
            lblTitreTotal.Text = "Total";
            // 
            // lbl_Profit
            // 
            lbl_Profit.Text = "Profit";
            // 
            // lbl_DateCommande
            // 
            lbl_DateCommande.Text = "Date";
            lbl_DateCommande.Width = 63;
            // 
            // lbl_DateReception
            // 
            lbl_DateReception.Text = "Date reçu";
            // 
            // shpCadrePrixReception
            // 
            shpCadrePrixReception.AutoSize = true;
            shpCadrePrixReception.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            shpCadrePrixReception.Controls.Add(lblPrixReception);
            shpCadrePrixReception.Controls.Add(lblTitrePrixReception);
            shpCadrePrixReception.Location = new System.Drawing.Point(444, 426);
            shpCadrePrixReception.Name = "shpCadrePrixReception";
            shpCadrePrixReception.Size = new System.Drawing.Size(180, 50);
            shpCadrePrixReception.TabIndex = 714;
            // 
            // lblPrixReception
            // 
            lblPrixReception.Dock = System.Windows.Forms.DockStyle.Top;
            lblPrixReception.Location = new System.Drawing.Point(0, 16);
            lblPrixReception.Name = "lblPrixReception";
            lblPrixReception.Size = new System.Drawing.Size(176, 21);
            lblPrixReception.TabIndex = 1;
            lblPrixReception.Text = "lblPrixReception";
            lblPrixReception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitrePrixReception
            // 
            lblTitrePrixReception.Dock = System.Windows.Forms.DockStyle.Top;
            lblTitrePrixReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitrePrixReception.Location = new System.Drawing.Point(0, 0);
            lblTitrePrixReception.Name = "lblTitrePrixReception";
            lblTitrePrixReception.Size = new System.Drawing.Size(176, 16);
            lblTitrePrixReception.TabIndex = 0;
            lblTitrePrixReception.Text = "Réception jusqu\'à maintenant";
            // 
            // shpCadrePrixSoumission
            // 
            shpCadrePrixSoumission.AutoSize = true;
            shpCadrePrixSoumission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            shpCadrePrixSoumission.Controls.Add(lblPrixSoumission);
            shpCadrePrixSoumission.Controls.Add(lblTitrePrixSoumission);
            shpCadrePrixSoumission.Location = new System.Drawing.Point(835, 426);
            shpCadrePrixSoumission.Name = "shpCadrePrixSoumission";
            shpCadrePrixSoumission.Size = new System.Drawing.Size(180, 50);
            shpCadrePrixSoumission.TabIndex = 715;
            // 
            // lblPrixSoumission
            // 
            lblPrixSoumission.Dock = System.Windows.Forms.DockStyle.Top;
            lblPrixSoumission.Location = new System.Drawing.Point(0, 16);
            lblPrixSoumission.Name = "lblPrixSoumission";
            lblPrixSoumission.Size = new System.Drawing.Size(176, 21);
            lblPrixSoumission.TabIndex = 1;
            lblPrixSoumission.Text = "label2";
            lblPrixSoumission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitrePrixSoumission
            // 
            lblTitrePrixSoumission.Dock = System.Windows.Forms.DockStyle.Top;
            lblTitrePrixSoumission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitrePrixSoumission.Location = new System.Drawing.Point(0, 0);
            lblTitrePrixSoumission.Name = "lblTitrePrixSoumission";
            lblTitrePrixSoumission.Size = new System.Drawing.Size(176, 16);
            lblTitrePrixSoumission.TabIndex = 0;
            lblTitrePrixSoumission.Text = "lblTitrePrixSoumission";
            // 
            // shpCadreForfait
            // 
            shpCadreForfait.AutoSize = true;
            shpCadreForfait.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            shpCadreForfait.Controls.Add(lblForfait);
            shpCadreForfait.Controls.Add(lblTitreForfait);
            shpCadreForfait.Location = new System.Drawing.Point(643, 426);
            shpCadreForfait.Name = "shpCadreForfait";
            shpCadreForfait.Size = new System.Drawing.Size(180, 50);
            shpCadreForfait.TabIndex = 716;
            // 
            // lblForfait
            // 
            lblForfait.Dock = System.Windows.Forms.DockStyle.Top;
            lblForfait.Location = new System.Drawing.Point(0, 16);
            lblForfait.Name = "lblForfait";
            lblForfait.Size = new System.Drawing.Size(176, 21);
            lblForfait.TabIndex = 1;
            lblForfait.Text = "lblForfait";
            lblForfait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreForfait
            // 
            lblTitreForfait.Dock = System.Windows.Forms.DockStyle.Top;
            lblTitreForfait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreForfait.Location = new System.Drawing.Point(0, 0);
            lblTitreForfait.Name = "lblTitreForfait";
            lblTitreForfait.Size = new System.Drawing.Size(176, 16);
            lblTitreForfait.TabIndex = 0;
            lblTitreForfait.Text = "lblTitreForfait";
            // 
            // lblCommission
            // 
            lblCommission.BackColor = System.Drawing.Color.White;
            lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblCommission.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCommission.Location = new System.Drawing.Point(908, 688);
            lblCommission.Name = "lblCommission";
            lblCommission.Size = new System.Drawing.Size(50, 19);
            lblCommission.TabIndex = 737;
            lblCommission.Text = "lblCommission";
            lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImprevue
            // 
            lblImprevue.BackColor = System.Drawing.Color.White;
            lblImprevue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblImprevue.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImprevue.Location = new System.Drawing.Point(908, 627);
            lblImprevue.Name = "lblImprevue";
            lblImprevue.Size = new System.Drawing.Size(50, 19);
            lblImprevue.TabIndex = 735;
            lblImprevue.Text = "lblImprevue";
            lblImprevue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfit
            // 
            lblProfit.BackColor = System.Drawing.Color.White;
            lblProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblProfit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProfit.Location = new System.Drawing.Point(908, 607);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new System.Drawing.Size(50, 19);
            lblProfit.TabIndex = 733;
            lblProfit.Text = "lblProfit";
            lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrandTotalAR
            // 
            lblGrandTotalAR.BackColor = System.Drawing.Color.White;
            lblGrandTotalAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblGrandTotalAR.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGrandTotalAR.Location = new System.Drawing.Point(964, 715);
            lblGrandTotalAR.Name = "lblGrandTotalAR";
            lblGrandTotalAR.Size = new System.Drawing.Size(50, 19);
            lblGrandTotalAR.TabIndex = 731;
            lblGrandTotalAR.Text = "label36";
            lblGrandTotalAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreGrandTotal
            // 
            lblTitreGrandTotal.AutoSize = true;
            lblTitreGrandTotal.BackColor = System.Drawing.Color.White;
            lblTitreGrandTotal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreGrandTotal.Location = new System.Drawing.Point(804, 715);
            lblTitreGrandTotal.Name = "lblTitreGrandTotal";
            lblTitreGrandTotal.Size = new System.Drawing.Size(93, 13);
            lblTitreGrandTotal.TabIndex = 732;
            lblTitreGrandTotal.Text = "lblTitreGrandTotal";
            // 
            // lblcommissionAR
            // 
            lblcommissionAR.BackColor = System.Drawing.Color.White;
            lblcommissionAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblcommissionAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblcommissionAR.Location = new System.Drawing.Point(964, 687);
            lblcommissionAR.Name = "lblcommissionAR";
            lblcommissionAR.Size = new System.Drawing.Size(50, 19);
            lblcommissionAR.TabIndex = 727;
            lblcommissionAR.Text = "lblcommissionAR";
            lblcommissionAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreCommission
            // 
            lblTitreCommission.AutoSize = true;
            lblTitreCommission.BackColor = System.Drawing.Color.White;
            lblTitreCommission.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreCommission.Location = new System.Drawing.Point(804, 686);
            lblTitreCommission.Name = "lblTitreCommission";
            lblTitreCommission.Size = new System.Drawing.Size(99, 13);
            lblTitreCommission.TabIndex = 728;
            lblTitreCommission.Text = "lblTitreCommission";
            // 
            // lblAutre
            // 
            lblAutre.BackColor = System.Drawing.Color.White;
            lblAutre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblAutre.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAutre.Location = new System.Drawing.Point(964, 667);
            lblAutre.Name = "lblAutre";
            lblAutre.Size = new System.Drawing.Size(50, 19);
            lblAutre.TabIndex = 725;
            lblAutre.Text = "lblAutre";
            lblAutre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreAutre
            // 
            lblTitreAutre.AutoSize = true;
            lblTitreAutre.BackColor = System.Drawing.Color.White;
            lblTitreAutre.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreAutre.Location = new System.Drawing.Point(804, 667);
            lblTitreAutre.Name = "lblTitreAutre";
            lblTitreAutre.Size = new System.Drawing.Size(67, 13);
            lblTitreAutre.TabIndex = 726;
            lblTitreAutre.Text = "lblTitreAutre";
            // 
            // lblTotalTempsAR
            // 
            lblTotalTempsAR.BackColor = System.Drawing.Color.White;
            lblTotalTempsAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsAR.Location = new System.Drawing.Point(964, 647);
            lblTotalTempsAR.Name = "lblTotalTempsAR";
            lblTotalTempsAR.Size = new System.Drawing.Size(50, 19);
            lblTotalTempsAR.TabIndex = 723;
            lblTotalTempsAR.Text = "lblTotalTempsAR";
            lblTotalTempsAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTotalTemps
            // 
            lblTitreTotalTemps.AutoSize = true;
            lblTitreTotalTemps.BackColor = System.Drawing.Color.White;
            lblTitreTotalTemps.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTotalTemps.Location = new System.Drawing.Point(804, 646);
            lblTitreTotalTemps.Name = "lblTitreTotalTemps";
            lblTitreTotalTemps.Size = new System.Drawing.Size(94, 13);
            lblTitreTotalTemps.TabIndex = 724;
            lblTitreTotalTemps.Text = "lblTitreTotalTemps";
            // 
            // lblImprevueAR
            // 
            lblImprevueAR.BackColor = System.Drawing.Color.White;
            lblImprevueAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblImprevueAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImprevueAR.Location = new System.Drawing.Point(964, 627);
            lblImprevueAR.Name = "lblImprevueAR";
            lblImprevueAR.Size = new System.Drawing.Size(50, 19);
            lblImprevueAR.TabIndex = 721;
            lblImprevueAR.Text = "lblImprevueAR";
            lblImprevueAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreImprevue
            // 
            lblTitreImprevue.AutoSize = true;
            lblTitreImprevue.BackColor = System.Drawing.Color.White;
            lblTitreImprevue.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreImprevue.Location = new System.Drawing.Point(804, 626);
            lblTitreImprevue.Name = "lblTitreImprevue";
            lblTitreImprevue.Size = new System.Drawing.Size(86, 13);
            lblTitreImprevue.TabIndex = 722;
            lblTitreImprevue.Text = "lblTitreImprevue";
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.BackColor = System.Drawing.Color.White;
            lblTotalProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalProfit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalProfit.Location = new System.Drawing.Point(964, 607);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new System.Drawing.Size(50, 19);
            lblTotalProfit.TabIndex = 719;
            lblTotalProfit.Text = "lblTotalProfit";
            lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProfitGlobal
            // 
            lblTitreProfitGlobal.AutoSize = true;
            lblTitreProfitGlobal.BackColor = System.Drawing.Color.White;
            lblTitreProfitGlobal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProfitGlobal.Location = new System.Drawing.Point(804, 606);
            lblTitreProfitGlobal.Name = "lblTitreProfitGlobal";
            lblTitreProfitGlobal.Size = new System.Drawing.Size(98, 13);
            lblTitreProfitGlobal.TabIndex = 720;
            lblTitreProfitGlobal.Text = "lblTitreProfitGlobal";
            // 
            // lblTotalPieceAR
            // 
            lblTotalPieceAR.BackColor = System.Drawing.Color.White;
            lblTotalPieceAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalPieceAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalPieceAR.Location = new System.Drawing.Point(964, 587);
            lblTotalPieceAR.Name = "lblTotalPieceAR";
            lblTotalPieceAR.Size = new System.Drawing.Size(50, 19);
            lblTotalPieceAR.TabIndex = 717;
            lblTotalPieceAR.Text = "lblTotalPieceAR";
            lblTotalPieceAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTotalPiece
            // 
            lblTitreTotalPiece.AutoSize = true;
            lblTitreTotalPiece.BackColor = System.Drawing.Color.White;
            lblTitreTotalPiece.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTotalPiece.Location = new System.Drawing.Point(804, 586);
            lblTitreTotalPiece.Name = "lblTitreTotalPiece";
            lblTitreTotalPiece.Size = new System.Drawing.Size(90, 13);
            lblTitreTotalPiece.TabIndex = 718;
            lblTitreTotalPiece.Text = "lblTitreTotalPiece";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblNoPage});
            statusStrip1.Location = new System.Drawing.Point(0, 773);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1150, 22);
            statusStrip1.TabIndex = 738;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblNoPage
            // 
            lblNoPage.Name = "lblNoPage";
            lblNoPage.Size = new System.Drawing.Size(1135, 17);
            lblNoPage.Spring = true;
            lblNoPage.Text = "lblNoPage";
            lblNoPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblclient
            // 
            lblclient.AutoSize = true;
            lblclient.BackColor = System.Drawing.Color.White;
            lblclient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblclient.Location = new System.Drawing.Point(605, 72);
            lblclient.Name = "lblclient";
            lblclient.Size = new System.Drawing.Size(59, 18);
            lblclient.TabIndex = 739;
            lblclient.Text = "lblclient";
            // 
            // lblTitreClient
            // 
            lblTitreClient.AutoSize = true;
            lblTitreClient.BackColor = System.Drawing.Color.White;
            lblTitreClient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreClient.Location = new System.Drawing.Point(525, 72);
            lblTitreClient.Name = "lblTitreClient";
            lblTitreClient.Size = new System.Drawing.Size(90, 18);
            lblTitreClient.TabIndex = 740;
            lblTitreClient.Text = "lblTitreClient";
            // 
            // lblcontact
            // 
            lblcontact.AutoSize = true;
            lblcontact.BackColor = System.Drawing.Color.White;
            lblcontact.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblcontact.Location = new System.Drawing.Point(605, 90);
            lblcontact.Name = "lblcontact";
            lblcontact.Size = new System.Drawing.Size(69, 18);
            lblcontact.TabIndex = 741;
            lblcontact.Text = "lblcontact";
            // 
            // lblTitreContact
            // 
            lblTitreContact.AutoSize = true;
            lblTitreContact.BackColor = System.Drawing.Color.White;
            lblTitreContact.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreContact.Location = new System.Drawing.Point(525, 90);
            lblTitreContact.Name = "lblTitreContact";
            lblTitreContact.Size = new System.Drawing.Size(100, 18);
            lblTitreContact.TabIndex = 742;
            lblTitreContact.Text = "lblTitreContact";
            // 
            // lblNoFacture
            // 
            lblNoFacture.AutoSize = true;
            lblNoFacture.BackColor = System.Drawing.Color.White;
            lblNoFacture.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoFacture.Location = new System.Drawing.Point(90, 96);
            lblNoFacture.Name = "lblNoFacture";
            lblNoFacture.Size = new System.Drawing.Size(88, 18);
            lblNoFacture.TabIndex = 743;
            lblNoFacture.Text = "lblNoFacture";
            // 
            // lblTitreNoFacture
            // 
            lblTitreNoFacture.AutoSize = true;
            lblTitreNoFacture.BackColor = System.Drawing.Color.White;
            lblTitreNoFacture.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreNoFacture.Location = new System.Drawing.Point(10, 96);
            lblTitreNoFacture.Name = "lblTitreNoFacture";
            lblTitreNoFacture.Size = new System.Drawing.Size(117, 18);
            lblTitreNoFacture.TabIndex = 744;
            lblTitreNoFacture.Text = "lblTitreNoFacture";
            // 
            // lblTotalTempsRHSoum
            // 
            lblTotalTempsRHSoum.BackColor = System.Drawing.Color.White;
            lblTotalTempsRHSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsRHSoum.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsRHSoum.Location = new System.Drawing.Point(249, 713);
            lblTotalTempsRHSoum.Name = "lblTotalTempsRHSoum";
            lblTotalTempsRHSoum.Size = new System.Drawing.Size(50, 17);
            lblTotalTempsRHSoum.TabIndex = 745;
            lblTotalTempsRHSoum.Text = "lblTotalTempsRHSoum";
            lblTotalTempsRHSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewSoumissionElec
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1150, 795);
            Controls.Add(lblTotalTempsRHSoum);
            Controls.Add(lblNoFacture);
            Controls.Add(lblTitreNoFacture);
            Controls.Add(lblcontact);
            Controls.Add(lblTitreContact);
            Controls.Add(lblclient);
            Controls.Add(lblTitreClient);
            Controls.Add(statusStrip1);
            Controls.Add(lblCommission);
            Controls.Add(lblImprevue);
            Controls.Add(lblProfit);
            Controls.Add(lblGrandTotalAR);
            Controls.Add(lblTitreGrandTotal);
            Controls.Add(lblcommissionAR);
            Controls.Add(lblTitreCommission);
            Controls.Add(lblAutre);
            Controls.Add(lblTitreAutre);
            Controls.Add(lblTotalTempsAR);
            Controls.Add(lblTitreTotalTemps);
            Controls.Add(lblImprevueAR);
            Controls.Add(lblTitreImprevue);
            Controls.Add(lblTotalProfit);
            Controls.Add(lblTitreProfitGlobal);
            Controls.Add(lblTotalPieceAR);
            Controls.Add(lblTitreTotalPiece);
            Controls.Add(shpCadreForfait);
            Controls.Add(shpCadrePrixSoumission);
            Controls.Add(shpCadrePrixReception);
            Controls.Add(listView1);
            Controls.Add(lblTempsUniteMobile);
            Controls.Add(label11);
            Controls.Add(lblTempsTransport);
            Controls.Add(label15);
            Controls.Add(lblTempsRepas);
            Controls.Add(label19);
            Controls.Add(lblTempsHebergement);
            Controls.Add(label24);
            Controls.Add(lblPrixManuel);
            Controls.Add(label27);
            Controls.Add(lblPrixEmballage);
            Controls.Add(lblTitreTransportEmballage);
            Controls.Add(lblTauxUniteMobile);
            Controls.Add(lblTitreTransportUniteMobile);
            Controls.Add(lblTauxTransport);
            Controls.Add(lblTitreTransportDeplacement);
            Controls.Add(lblTauxRepas);
            Controls.Add(lblTitreRepas);
            Controls.Add(lblTauxHebergement2);
            Controls.Add(label23);
            Controls.Add(lblTauxHebergement1);
            Controls.Add(lblTitreHebergement1);
            Controls.Add(lblNbrePersonne);
            Controls.Add(lblTitreNbrePersonne);
            Controls.Add(lblTempsDessinSoum);
            Controls.Add(lblTempsFabricationSoum);
            Controls.Add(lblTempsAssemblageSoum);
            Controls.Add(lblTempsTestSoum);
            Controls.Add(lblTempsProgInterfaceSoum);
            Controls.Add(lblTempsProgAutomateSoum);
            Controls.Add(lblTempsProgRobotSoum);
            Controls.Add(lblTempsVisionSoum);
            Controls.Add(lblTempsInstallationSoum);
            Controls.Add(lblTempsMiseServiceSoum);
            Controls.Add(lblTempsFormationSoum);
            Controls.Add(lblTempsGestionSoum);
            Controls.Add(lblTempsShippingSoum);
            Controls.Add(lbldescription);
            Controls.Add(label10);
            Controls.Add(lblTitreSoumission);
            Controls.Add(lblSoumission);
            Controls.Add(label66);
            Controls.Add(lblTotalTempsRHReel);
            Controls.Add(label69);
            Controls.Add(label74);
            Controls.Add(lblTempsShippingReel);
            Controls.Add(lblTauxShipping);
            Controls.Add(lblTitreShipping);
            Controls.Add(label30);
            Controls.Add(lblTempsGestionReel);
            Controls.Add(lblTauxGestion);
            Controls.Add(lblTitreGestion);
            Controls.Add(label34);
            Controls.Add(lblTempsFormationReel);
            Controls.Add(lblTauxFormation);
            Controls.Add(lblTitreFormation);
            Controls.Add(label38);
            Controls.Add(lblTempsMiseServiceReel);
            Controls.Add(lblTauxMiseService);
            Controls.Add(lblTitreMiseService);
            Controls.Add(label42);
            Controls.Add(lblTempsInstallationReel);
            Controls.Add(lblTauxInstallation);
            Controls.Add(lblTitreInstallation);
            Controls.Add(label46);
            Controls.Add(lblTempsTestReel);
            Controls.Add(lblTauxTest);
            Controls.Add(lblTitreTest);
            Controls.Add(label50);
            Controls.Add(lblTempsVisionReel);
            Controls.Add(lblTauxVision);
            Controls.Add(lblTitreVision);
            Controls.Add(label22);
            Controls.Add(lblTempsProgRobotReel);
            Controls.Add(lblTauxProgRobot);
            Controls.Add(lblTitreProgRobot);
            Controls.Add(label26);
            Controls.Add(lblTempsProgAutomateReel);
            Controls.Add(lblTauxProgAutomate);
            Controls.Add(lblTitreProgAutomate);
            Controls.Add(label14);
            Controls.Add(lblTempsProgInterfaceReel);
            Controls.Add(lblTauxProgInterface);
            Controls.Add(lblTitreProgInterface);
            Controls.Add(label18);
            Controls.Add(lblTempsAssemblageReel);
            Controls.Add(lblTauxAssemblage);
            Controls.Add(lblTitreAssemblage);
            Controls.Add(label9);
            Controls.Add(lblTempsFabricationReel);
            Controls.Add(lblTauxFabrication);
            Controls.Add(lblTitreFabrication);
            Controls.Add(label8);
            Controls.Add(lblTitreTemps);
            Controls.Add(lblTitreTauxHoraire);
            Controls.Add(label5);
            Controls.Add(lblTempsDessinReel);
            Controls.Add(lblTauxDessin);
            Controls.Add(lblTitreDessin);
            Controls.Add(lblProjet);
            Controls.Add(lblTitreProjet);
            Controls.Add(pictureBox1);
            Controls.Add(lblGrosTitre);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewSoumissionElec";
            ShowInTaskbar = false;
            Text = "heures";
            Load += new System.EventHandler(ViewBonTravail_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            shpCadrePrixReception.ResumeLayout(false);
            shpCadrePrixSoumission.ResumeLayout(false);
            shpCadreForfait.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label label66;
        internal static Label lblTotalTempsRHReel;
        internal static Label label69;
        internal static Label label74;
        internal static Label lblTempsShippingReel;
        internal static Label lblTauxShipping;
        internal static Label lblTitreShipping;
        internal static Label label30;
        internal static Label lblTempsGestionReel;
        internal static Label lblTauxGestion;
        internal static Label lblTitreGestion;
        internal static Label label34;
        internal static Label lblTempsFormationReel;
        internal static Label lblTauxFormation;
        internal static Label lblTitreFormation;
        internal static Label label38;
        internal static Label lblTempsMiseServiceReel;
        internal static Label lblTauxMiseService;
        internal static Label lblTitreMiseService;
        internal static Label label42;
        internal static Label lblTempsInstallationReel;
        internal static Label lblTauxInstallation;
        internal static Label lblTitreInstallation;
        internal static Label label46;
        internal static Label lblTempsTestReel;
        internal static Label lblTauxTest;
        internal static Label lblTitreTest;
        internal static Label label50;
        internal static Label lblTempsVisionReel;
        internal static Label lblTauxVision;
        internal static Label lblTitreVision;
        internal static Label label22;
        internal static Label lblTempsProgRobotReel;
        internal static Label lblTauxProgRobot;
        internal static Label lblTitreProgRobot;
        internal static Label label26;
        internal static Label lblTempsProgAutomateReel;
        internal static Label lblTauxProgAutomate;
        internal static Label lblTitreProgAutomate;
        internal static Label label14;
        internal static Label lblTempsProgInterfaceReel;
        internal static Label lblTauxProgInterface;
        internal static Label lblTitreProgInterface;
        internal static Label label18;
        internal static Label lblTempsAssemblageReel;
        internal static Label lblTauxAssemblage;
        internal static Label lblTitreAssemblage;
        internal static Label label9;
        internal static Label lblTempsFabricationReel;
        internal static Label lblTauxFabrication;
        internal static Label lblTitreFabrication;
        internal static Label label8;
        internal static Label lblTitreTemps;
        internal static Label lblTitreTauxHoraire;
        internal static Label label5;
        internal static Label lblTempsDessinReel;
        internal static Label lblTauxDessin;
        internal static Label lblTitreDessin;
        internal static Label lblProjet;
        internal static Label lblTitreProjet;
        internal static PictureBox pictureBox1;
        internal static Label lblGrosTitre;
        internal static Label lblTitreSoumission;
        internal static Label lblSoumission;
        internal static Label lbldescription;
        internal static Label label10;
        internal static Label lblTempsDessinSoum;
        internal static Label lblTempsFabricationSoum;
        internal static Label lblTempsAssemblageSoum;
        internal static Label lblTempsTestSoum;
        internal static Label lblTempsProgInterfaceSoum;
        internal static Label lblTempsProgAutomateSoum;
        internal static Label lblTempsProgRobotSoum;
        internal static Label lblTempsVisionSoum;
        internal static Label lblTempsInstallationSoum;
        internal static Label lblTempsMiseServiceSoum;
        internal static Label lblTempsFormationSoum;
        internal static Label lblTempsGestionSoum;
        internal static Label lblTempsShippingSoum;
        internal static Label lblTauxRepas;
        internal static Label lblTitreRepas;
        internal static Label lblTauxHebergement2;
        internal static Label label23;
        internal static Label lblTauxHebergement1;
        internal static Label lblTitreHebergement1;
        internal static Label lblNbrePersonne;
        internal static Label lblTitreNbrePersonne;
        internal static Label lblPrixManuel;
        internal static Label label27;
        internal static Label lblPrixEmballage;
        internal static Label lblTitreTransportEmballage;
        internal static Label lblTauxUniteMobile;
        internal static Label lblTitreTransportUniteMobile;
        internal static Label lblTauxTransport;
        internal static Label lblTitreTransportDeplacement;
        internal static Label lblTempsUniteMobile;
        internal static Label label11;
        internal static Label lblTempsTransport;
        internal static Label label15;
        internal static Label lblTempsRepas;
        internal static Label label19;
        internal static Label lblTempsHebergement;
        internal static Label label24;
        internal static ListView listView1;
        internal static Panel shpCadrePrixReception;
        internal static Label lblPrixReception;
        internal static Label lblTitrePrixReception;
        internal static Panel shpCadrePrixSoumission;
        internal static Label lblPrixSoumission;
        internal static Label lblTitrePrixSoumission;
        internal static Panel shpCadreForfait;
        internal static Label lblForfait;
        internal static Label lblTitreForfait;
        internal static Label lblCommission;
        internal static Label lblImprevue;
        internal static Label lblProfit;
        internal static Label lblGrandTotalAR;
        internal static Label lblTitreGrandTotal;
        internal static Label lblcommissionAR;
        internal static Label lblTitreCommission;
        internal static Label lblAutre;
        internal static Label lblTitreAutre;
        internal static Label lblTotalTempsAR;
        internal static Label lblTitreTotalTemps;
        internal static Label lblImprevueAR;
        internal static Label lblTitreImprevue;
        internal static Label lblTotalProfit;
        internal static Label lblTitreProfitGlobal;
        internal static Label lblTotalPieceAR;
        internal static Label lblTitreTotalPiece;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel lblNoPage;
        internal static ColumnHeader lblTitreQuantite;
        internal static ColumnHeader lblTitreNoItem;
        internal static ColumnHeader lblTitreDescription;
        internal static ColumnHeader lblTitreManufacturier;
        internal static ColumnHeader lblTitreCoutant;
        internal static ColumnHeader lblTitreFournisseur;
        internal static ColumnHeader lblTitreTotal;
        internal static ColumnHeader lbl_Profit;
        internal static ColumnHeader lbl_DateCommande;
        internal static ColumnHeader lbl_DateReception;
        internal static Label lblclient;
        internal static Label lblTitreClient;
        internal static Label lblcontact;
        internal static Label lblTitreContact;
        internal static Label lblNoFacture;
        internal static Label lblTotalTempsRHSoum;
        internal static Label lblTitreNoFacture;

        public ViewSoumissionElec()
        {
            InitializeComponent();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        private void ViewBonTravail_Load(object sender, EventArgs e)
        {
        }
        internal  static ADODB.Recordset DataSource;
        internal  static  bool shpCadrePrixReceptionVisible;
        public static Label lbldate;
        internal static bool Orientation;
        Bitmap memoryImage;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.DefaultPageSettings.Color = false;
                printDocument1.DefaultPageSettings.Landscape = !ControleurServeur.Program.isLandscape; //pour le mode paysage
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.PrinterSettings.Copies = 1;
                printDialog1.Document = printDocument1;
                printDocument1.PrintPage += new PrintPageEventHandler(ImpressionFormulaire);
                Graphics myGraphics = CreateGraphics();
                Size s = Size;
                memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
                Graphics memoryGraphics = Graphics.FromImage(memoryImage);
                memoryGraphics.CopyFromScreen(Left, Top, 0, 0, s);
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog();
                    PrintPreviewDialog1.ClientSize = new System.Drawing.Size(300, 400);
                    PrintPreviewDialog1.Location = new System.Drawing.Point(29, 29);
                    PrintPreviewDialog1.Name = Text;
                    PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(250, 375);
                    PrintPreviewDialog1.UseAntiAlias = true;
                    PrintPreviewDialog1.Document = printDocument1;
                    Text = "Impression sur " + printDialog1.PrinterSettings.PrinterName;
                    if (PrintPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
            }
            if (MessageBox.Show("Voulez vous fermer cette vue?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void lblTempsShippingEstime_Click(object sender, EventArgs e)
        {
        }
    }
}
