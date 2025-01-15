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
    public class ViewSoumissionMec : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSoumissionMec));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblNoPage = new System.Windows.Forms.ToolStripStatusLabel();
            lblDate = new System.Windows.Forms.ToolStripStatusLabel();
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
            lblTempsUniteMobile = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            lblTempsTransport = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            lblTempsRepas = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            lblTempsHebergement = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            lblPrixManuel = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            lblPrixEmballage = new System.Windows.Forms.Label();
            lblTitreTransportEmballage = new System.Windows.Forms.Label();
            lblTitreTransportUniteMobile = new System.Windows.Forms.Label();
            lblTauxTransport = new System.Windows.Forms.Label();
            lblTitreTransportDeplacement = new System.Windows.Forms.Label();
            lblTauxRepas = new System.Windows.Forms.Label();
            lblTitreRepas = new System.Windows.Forms.Label();
            lblTauxHebergement2 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            lblTauxHebergement1 = new System.Windows.Forms.Label();
            lblTitreHebergement1 = new System.Windows.Forms.Label();
            lblNbrePersonne = new System.Windows.Forms.Label();
            lblTauxUniteMobile = new System.Windows.Forms.Label();
            lblTitreNbrePersonne = new System.Windows.Forms.Label();
            lblTempsDessinSoum = new System.Windows.Forms.Label();
            lblTempsMachinageSoum = new System.Windows.Forms.Label();
            lblTempsFormationSoum = new System.Windows.Forms.Label();
            lblTempsCoupeSoum = new System.Windows.Forms.Label();
            lblCommission = new System.Windows.Forms.Label();
            lblImprevue = new System.Windows.Forms.Label();
            lblForfait = new System.Windows.Forms.Label();
            lblTitreForfait = new System.Windows.Forms.Label();
            lblPrixSoumission = new System.Windows.Forms.Label();
            lblTitrePrixSoumission = new System.Windows.Forms.Label();
            lblProfit = new System.Windows.Forms.Label();
            lblGrandTotalAR = new System.Windows.Forms.Label();
            lblTitreGrandTotal = new System.Windows.Forms.Label();
            lblcommissionAR = new System.Windows.Forms.Label();
            lblTitreCommission = new System.Windows.Forms.Label();
            lblTitrePrixReception = new System.Windows.Forms.Label();
            lblAutre = new System.Windows.Forms.Label();
            lblTitreAutre = new System.Windows.Forms.Label();
            lblTotalTempsAR = new System.Windows.Forms.Label();
            lblTitreTotalTemps = new System.Windows.Forms.Label();
            lblPrixReception = new System.Windows.Forms.Label();
            lblImprevueAR = new System.Windows.Forms.Label();
            lblTitreImprevue = new System.Windows.Forms.Label();
            lblTotalProfit = new System.Windows.Forms.Label();
            lblTitreProfitGlobal = new System.Windows.Forms.Label();
            lblTotalPieceAR = new System.Windows.Forms.Label();
            lblTitreTotalPiece = new System.Windows.Forms.Label();
            shpCadreForfait = new System.Windows.Forms.Panel();
            shpCadrePrixSoumission = new System.Windows.Forms.Panel();
            shpCadrePrixReception = new System.Windows.Forms.Panel();
            lblTempsSoudureSoum = new System.Windows.Forms.Label();
            lblTempsPeintureSoum = new System.Windows.Forms.Label();
            lblTempsTestSoum = new System.Windows.Forms.Label();
            lblTempsInstallationSoum = new System.Windows.Forms.Label();
            lblTempsGestionSoum = new System.Windows.Forms.Label();
            lblTempsShippingSoum = new System.Windows.Forms.Label();
            lbldescription = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            lblTitreSoumission = new System.Windows.Forms.Label();
            lblSoumission = new System.Windows.Forms.Label();
            label66 = new System.Windows.Forms.Label();
            lblTotalTempsReel = new System.Windows.Forms.Label();
            lblTempsShippingProj = new System.Windows.Forms.Label();
            lblTauxShipping = new System.Windows.Forms.Label();
            lblTitreShipping = new System.Windows.Forms.Label();
            lblTempsGestionProj = new System.Windows.Forms.Label();
            lblTauxGestion = new System.Windows.Forms.Label();
            lblTitreGestion = new System.Windows.Forms.Label();
            lblTempsFormationProj = new System.Windows.Forms.Label();
            lblTauxFormation = new System.Windows.Forms.Label();
            lblTitreFormation = new System.Windows.Forms.Label();
            lblTempsTestProj = new System.Windows.Forms.Label();
            lblTauxInstallation = new System.Windows.Forms.Label();
            lblTitreInstallation = new System.Windows.Forms.Label();
            lblTempsPeintureProj = new System.Windows.Forms.Label();
            lblTitreTestFinal = new System.Windows.Forms.Label();
            lblTempsAssemblageProj = new System.Windows.Forms.Label();
            lblTauxProgAutomate = new System.Windows.Forms.Label();
            lblTitrePeintureFinition = new System.Windows.Forms.Label();
            lblTempsSoudureProj = new System.Windows.Forms.Label();
            lblTauxProgInterface = new System.Windows.Forms.Label();
            lblTitreAssemblageSoudure = new System.Windows.Forms.Label();
            lblTempsMachinageProj = new System.Windows.Forms.Label();
            lblTauxAssemblage = new System.Windows.Forms.Label();
            lblTitreMachinage = new System.Windows.Forms.Label();
            lblTempsCoupeProj = new System.Windows.Forms.Label();
            lblTauxFabrication = new System.Windows.Forms.Label();
            lblTitreCoupePreparation = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblTempsDessinProj = new System.Windows.Forms.Label();
            lblTauxDessin = new System.Windows.Forms.Label();
            lblTitreConceptionDessin = new System.Windows.Forms.Label();
            lblProjet = new System.Windows.Forms.Label();
            lblTitreProjet = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblGrosTitre = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            lblTempsShippingReel = new System.Windows.Forms.Label();
            lblSoumission2 = new System.Windows.Forms.Label();
            lblTempsGestionReel = new System.Windows.Forms.Label();
            lblSoumission6 = new System.Windows.Forms.Label();
            lblTempsFormationReel = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            lblclient = new System.Windows.Forms.Label();
            lblTitreClient = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            lblTitreContact = new System.Windows.Forms.Label();
            lblNoFacture = new System.Windows.Forms.Label();
            lblTitreNoFacture = new System.Windows.Forms.Label();
            lblSoumission0 = new System.Windows.Forms.Label();
            lblSoumission1 = new System.Windows.Forms.Label();
            lblTotalTempsRHSoum = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblSoumission4 = new System.Windows.Forms.Label();
            lblSoumission5 = new System.Windows.Forms.Label();
            lblTempsMiseServiceConc = new System.Windows.Forms.Label();
            lblTempsVisionConc = new System.Windows.Forms.Label();
            label40 = new System.Windows.Forms.Label();
            lblTempsVisionReel = new System.Windows.Forms.Label();
            label42 = new System.Windows.Forms.Label();
            lblTempsMiseServiceReel = new System.Windows.Forms.Label();
            lblTempsMiseServiceSoum = new System.Windows.Forms.Label();
            lblTempsVisionSoum = new System.Windows.Forms.Label();
            lblTempsVisionProj = new System.Windows.Forms.Label();
            lblTauxVision = new System.Windows.Forms.Label();
            lblTitreVision = new System.Windows.Forms.Label();
            lblTempsMiseServiceProj = new System.Windows.Forms.Label();
            lblTauxMiseService = new System.Windows.Forms.Label();
            lblTitreMiseService = new System.Windows.Forms.Label();
            lblTauxTest = new System.Windows.Forms.Label();
            statusStrip1.SuspendLayout();
            shpCadreForfait.SuspendLayout();
            shpCadrePrixSoumission.SuspendLayout();
            shpCadrePrixReception.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblNoPage,
            lblDate});
            statusStrip1.Location = new System.Drawing.Point(0, 773);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1150, 22);
            statusStrip1.TabIndex = 863;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblNoPage
            // 
            lblNoPage.Name = "lblNoPage";
            lblNoPage.Size = new System.Drawing.Size(1091, 17);
            lblNoPage.Spring = true;
            lblNoPage.Text = "lblNoPage";
            lblNoPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(44, 17);
            lblDate.Text = "lblDate";
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
            listView1.Location = new System.Drawing.Point(14, 114);
            listView1.Margin = new System.Windows.Forms.Padding(0);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1127, 348);
            listView1.TabIndex = 842;
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
            // lblTempsUniteMobile
            // 
            lblTempsUniteMobile.BackColor = System.Drawing.Color.White;
            lblTempsUniteMobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsUniteMobile.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsUniteMobile.Location = new System.Drawing.Point(695, 641);
            lblTempsUniteMobile.Name = "lblTempsUniteMobile";
            lblTempsUniteMobile.Size = new System.Drawing.Size(50, 19);
            lblTempsUniteMobile.TabIndex = 840;
            lblTempsUniteMobile.Text = "lblTempsUniteMobile";
            lblTempsUniteMobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.White;
            label11.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(746, 643);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(21, 13);
            label11.TabIndex = 841;
            label11.Text = "km";
            // 
            // lblTempsTransport
            // 
            lblTempsTransport.BackColor = System.Drawing.Color.White;
            lblTempsTransport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTransport.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTransport.Location = new System.Drawing.Point(695, 621);
            lblTempsTransport.Name = "lblTempsTransport";
            lblTempsTransport.Size = new System.Drawing.Size(50, 19);
            lblTempsTransport.TabIndex = 838;
            lblTempsTransport.Text = "lblTempsTransport";
            lblTempsTransport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.White;
            label15.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(746, 623);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(21, 13);
            label15.TabIndex = 839;
            label15.Text = "km";
            // 
            // lblTempsRepas
            // 
            lblTempsRepas.BackColor = System.Drawing.Color.White;
            lblTempsRepas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsRepas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsRepas.Location = new System.Drawing.Point(695, 601);
            lblTempsRepas.Name = "lblTempsRepas";
            lblTempsRepas.Size = new System.Drawing.Size(50, 19);
            lblTempsRepas.TabIndex = 836;
            lblTempsRepas.Text = "lblTempsRepas";
            lblTempsRepas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = System.Drawing.Color.White;
            label19.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(746, 603);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(31, 13);
            label19.TabIndex = 837;
            label19.Text = "jours";
            // 
            // lblTempsHebergement
            // 
            lblTempsHebergement.BackColor = System.Drawing.Color.White;
            lblTempsHebergement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsHebergement.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsHebergement.Location = new System.Drawing.Point(695, 581);
            lblTempsHebergement.Name = "lblTempsHebergement";
            lblTempsHebergement.Size = new System.Drawing.Size(50, 19);
            lblTempsHebergement.TabIndex = 834;
            lblTempsHebergement.Text = "lblTempsHebergement";
            lblTempsHebergement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = System.Drawing.Color.White;
            label24.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.Location = new System.Drawing.Point(746, 583);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(31, 13);
            label24.TabIndex = 835;
            label24.Text = "jours";
            // 
            // lblPrixManuel
            // 
            lblPrixManuel.BackColor = System.Drawing.Color.White;
            lblPrixManuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixManuel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrixManuel.Location = new System.Drawing.Point(629, 671);
            lblPrixManuel.Name = "lblPrixManuel";
            lblPrixManuel.Size = new System.Drawing.Size(50, 19);
            lblPrixManuel.TabIndex = 832;
            lblPrixManuel.Text = "lblPrixManuel";
            lblPrixManuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = System.Drawing.Color.White;
            label27.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.Location = new System.Drawing.Point(473, 668);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(51, 13);
            label27.TabIndex = 833;
            label27.Text = "Manuels:";
            // 
            // lblPrixEmballage
            // 
            lblPrixEmballage.BackColor = System.Drawing.Color.White;
            lblPrixEmballage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixEmballage.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrixEmballage.Location = new System.Drawing.Point(629, 650);
            lblPrixEmballage.Name = "lblPrixEmballage";
            lblPrixEmballage.Size = new System.Drawing.Size(50, 19);
            lblPrixEmballage.TabIndex = 830;
            lblPrixEmballage.Text = "lblPrixEmballage";
            lblPrixEmballage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTransportEmballage
            // 
            lblTitreTransportEmballage.AutoSize = true;
            lblTitreTransportEmballage.BackColor = System.Drawing.Color.White;
            lblTitreTransportEmballage.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTransportEmballage.Location = new System.Drawing.Point(473, 647);
            lblTitreTransportEmballage.Name = "lblTitreTransportEmballage";
            lblTitreTransportEmballage.Size = new System.Drawing.Size(135, 13);
            lblTitreTransportEmballage.TabIndex = 831;
            lblTitreTransportEmballage.Text = "lblTitreTransportEmballage";
            // 
            // lblTitreTransportUniteMobile
            // 
            lblTitreTransportUniteMobile.AutoSize = true;
            lblTitreTransportUniteMobile.BackColor = System.Drawing.Color.White;
            lblTitreTransportUniteMobile.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTransportUniteMobile.Location = new System.Drawing.Point(473, 627);
            lblTitreTransportUniteMobile.Name = "lblTitreTransportUniteMobile";
            lblTitreTransportUniteMobile.Size = new System.Drawing.Size(145, 13);
            lblTitreTransportUniteMobile.TabIndex = 829;
            lblTitreTransportUniteMobile.Text = "lblTitreTransportUniteMobile";
            // 
            // lblTauxTransport
            // 
            lblTauxTransport.BackColor = System.Drawing.Color.White;
            lblTauxTransport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxTransport.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxTransport.Location = new System.Drawing.Point(629, 610);
            lblTauxTransport.Name = "lblTauxTransport";
            lblTauxTransport.Size = new System.Drawing.Size(50, 19);
            lblTauxTransport.TabIndex = 826;
            lblTauxTransport.Text = "lblTauxTransport";
            lblTauxTransport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTransportDeplacement
            // 
            lblTitreTransportDeplacement.AutoSize = true;
            lblTitreTransportDeplacement.BackColor = System.Drawing.Color.White;
            lblTitreTransportDeplacement.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTransportDeplacement.Location = new System.Drawing.Point(473, 608);
            lblTitreTransportDeplacement.Name = "lblTitreTransportDeplacement";
            lblTitreTransportDeplacement.Size = new System.Drawing.Size(150, 13);
            lblTitreTransportDeplacement.TabIndex = 827;
            lblTitreTransportDeplacement.Text = "lblTitreTransportDeplacement";
            // 
            // lblTauxRepas
            // 
            lblTauxRepas.BackColor = System.Drawing.Color.White;
            lblTauxRepas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxRepas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxRepas.Location = new System.Drawing.Point(629, 590);
            lblTauxRepas.Name = "lblTauxRepas";
            lblTauxRepas.Size = new System.Drawing.Size(50, 19);
            lblTauxRepas.TabIndex = 824;
            lblTauxRepas.Text = "lblTauxRepas";
            lblTauxRepas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreRepas
            // 
            lblTitreRepas.AutoSize = true;
            lblTitreRepas.BackColor = System.Drawing.Color.White;
            lblTitreRepas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreRepas.Location = new System.Drawing.Point(473, 587);
            lblTitreRepas.Name = "lblTitreRepas";
            lblTitreRepas.Size = new System.Drawing.Size(70, 13);
            lblTitreRepas.TabIndex = 825;
            lblTitreRepas.Text = "lblTitreRepas";
            // 
            // lblTauxHebergement2
            // 
            lblTauxHebergement2.BackColor = System.Drawing.Color.White;
            lblTauxHebergement2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxHebergement2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxHebergement2.Location = new System.Drawing.Point(629, 570);
            lblTauxHebergement2.Name = "lblTauxHebergement2";
            lblTauxHebergement2.Size = new System.Drawing.Size(50, 19);
            lblTauxHebergement2.TabIndex = 822;
            lblTauxHebergement2.Text = "lblTauxHebergement2";
            lblTauxHebergement2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = System.Drawing.Color.White;
            label23.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(473, 567);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(108, 13);
            label23.TabIndex = 823;
            label23.Text = "Hébergement (2 lits) :";
            // 
            // lblTauxHebergement1
            // 
            lblTauxHebergement1.BackColor = System.Drawing.Color.White;
            lblTauxHebergement1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxHebergement1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxHebergement1.Location = new System.Drawing.Point(629, 550);
            lblTauxHebergement1.Name = "lblTauxHebergement1";
            lblTauxHebergement1.Size = new System.Drawing.Size(50, 19);
            lblTauxHebergement1.TabIndex = 820;
            lblTauxHebergement1.Text = "lblTauxHebergement1";
            lblTauxHebergement1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreHebergement1
            // 
            lblTitreHebergement1.AutoSize = true;
            lblTitreHebergement1.BackColor = System.Drawing.Color.White;
            lblTitreHebergement1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreHebergement1.Location = new System.Drawing.Point(473, 547);
            lblTitreHebergement1.Name = "lblTitreHebergement1";
            lblTitreHebergement1.Size = new System.Drawing.Size(103, 13);
            lblTitreHebergement1.TabIndex = 821;
            lblTitreHebergement1.Text = "Hébergement (1 lit) :";
            // 
            // lblNbrePersonne
            // 
            lblNbrePersonne.BackColor = System.Drawing.Color.White;
            lblNbrePersonne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblNbrePersonne.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNbrePersonne.Location = new System.Drawing.Point(629, 530);
            lblNbrePersonne.Name = "lblNbrePersonne";
            lblNbrePersonne.Size = new System.Drawing.Size(50, 19);
            lblNbrePersonne.TabIndex = 818;
            lblNbrePersonne.Text = "lblNbrePersonne";
            lblNbrePersonne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxUniteMobile
            // 
            lblTauxUniteMobile.BackColor = System.Drawing.Color.White;
            lblTauxUniteMobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxUniteMobile.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxUniteMobile.Location = new System.Drawing.Point(629, 630);
            lblTauxUniteMobile.Name = "lblTauxUniteMobile";
            lblTauxUniteMobile.Size = new System.Drawing.Size(50, 19);
            lblTauxUniteMobile.TabIndex = 828;
            lblTauxUniteMobile.Text = "lblTauxUniteMobile";
            lblTauxUniteMobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreNbrePersonne
            // 
            lblTitreNbrePersonne.AutoSize = true;
            lblTitreNbrePersonne.BackColor = System.Drawing.Color.White;
            lblTitreNbrePersonne.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreNbrePersonne.Location = new System.Drawing.Point(473, 527);
            lblTitreNbrePersonne.Name = "lblTitreNbrePersonne";
            lblTitreNbrePersonne.Size = new System.Drawing.Size(109, 13);
            lblTitreNbrePersonne.TabIndex = 819;
            lblTitreNbrePersonne.Text = "lblTitreNbrePersonne";
            // 
            // lblTempsDessinSoum
            // 
            lblTempsDessinSoum.BackColor = System.Drawing.Color.White;
            lblTempsDessinSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsDessinSoum.Location = new System.Drawing.Point(213, 484);
            lblTempsDessinSoum.Name = "lblTempsDessinSoum";
            lblTempsDessinSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsDessinSoum.TabIndex = 814;
            lblTempsDessinSoum.Text = "lblTempsDessinSoum";
            lblTempsDessinSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsMachinageSoum
            // 
            lblTempsMachinageSoum.BackColor = System.Drawing.Color.White;
            lblTempsMachinageSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMachinageSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMachinageSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsMachinageSoum.Location = new System.Drawing.Point(213, 525);
            lblTempsMachinageSoum.Name = "lblTempsMachinageSoum";
            lblTempsMachinageSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsMachinageSoum.TabIndex = 816;
            lblTempsMachinageSoum.Text = "lblTempsMachinageSoum";
            lblTempsMachinageSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsFormationSoum
            // 
            lblTempsFormationSoum.BackColor = System.Drawing.Color.White;
            lblTempsFormationSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsFormationSoum.Location = new System.Drawing.Point(213, 624);
            lblTempsFormationSoum.Name = "lblTempsFormationSoum";
            lblTempsFormationSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsFormationSoum.TabIndex = 817;
            lblTempsFormationSoum.Text = "lblTempsFormationSoum";
            lblTempsFormationSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsCoupeSoum
            // 
            lblTempsCoupeSoum.BackColor = System.Drawing.Color.White;
            lblTempsCoupeSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsCoupeSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsCoupeSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsCoupeSoum.Location = new System.Drawing.Point(213, 504);
            lblTempsCoupeSoum.Name = "lblTempsCoupeSoum";
            lblTempsCoupeSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsCoupeSoum.TabIndex = 815;
            lblTempsCoupeSoum.Text = "lblTempsCoupeSoum";
            lblTempsCoupeSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommission
            // 
            lblCommission.BackColor = System.Drawing.Color.White;
            lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblCommission.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCommission.Location = new System.Drawing.Point(898, 687);
            lblCommission.Name = "lblCommission";
            lblCommission.Size = new System.Drawing.Size(50, 19);
            lblCommission.TabIndex = 862;
            lblCommission.Text = "lblCommission";
            lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImprevue
            // 
            lblImprevue.BackColor = System.Drawing.Color.White;
            lblImprevue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblImprevue.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImprevue.Location = new System.Drawing.Point(898, 626);
            lblImprevue.Name = "lblImprevue";
            lblImprevue.Size = new System.Drawing.Size(50, 19);
            lblImprevue.TabIndex = 861;
            lblImprevue.Text = "lblImprevue";
            lblImprevue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblProfit
            // 
            lblProfit.BackColor = System.Drawing.Color.White;
            lblProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblProfit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProfit.Location = new System.Drawing.Point(898, 606);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new System.Drawing.Size(50, 19);
            lblProfit.TabIndex = 860;
            lblProfit.Text = "lblProfit";
            lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrandTotalAR
            // 
            lblGrandTotalAR.BackColor = System.Drawing.Color.White;
            lblGrandTotalAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblGrandTotalAR.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGrandTotalAR.Location = new System.Drawing.Point(954, 714);
            lblGrandTotalAR.Name = "lblGrandTotalAR";
            lblGrandTotalAR.Size = new System.Drawing.Size(50, 19);
            lblGrandTotalAR.TabIndex = 858;
            lblGrandTotalAR.Text = "label36";
            lblGrandTotalAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreGrandTotal
            // 
            lblTitreGrandTotal.AutoSize = true;
            lblTitreGrandTotal.BackColor = System.Drawing.Color.White;
            lblTitreGrandTotal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreGrandTotal.Location = new System.Drawing.Point(794, 714);
            lblTitreGrandTotal.Name = "lblTitreGrandTotal";
            lblTitreGrandTotal.Size = new System.Drawing.Size(93, 13);
            lblTitreGrandTotal.TabIndex = 859;
            lblTitreGrandTotal.Text = "lblTitreGrandTotal";
            // 
            // lblcommissionAR
            // 
            lblcommissionAR.BackColor = System.Drawing.Color.White;
            lblcommissionAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblcommissionAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblcommissionAR.Location = new System.Drawing.Point(954, 686);
            lblcommissionAR.Name = "lblcommissionAR";
            lblcommissionAR.Size = new System.Drawing.Size(50, 19);
            lblcommissionAR.TabIndex = 856;
            lblcommissionAR.Text = "lblcommissionAR";
            lblcommissionAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreCommission
            // 
            lblTitreCommission.AutoSize = true;
            lblTitreCommission.BackColor = System.Drawing.Color.White;
            lblTitreCommission.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreCommission.Location = new System.Drawing.Point(794, 685);
            lblTitreCommission.Name = "lblTitreCommission";
            lblTitreCommission.Size = new System.Drawing.Size(99, 13);
            lblTitreCommission.TabIndex = 857;
            lblTitreCommission.Text = "lblTitreCommission";
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
            // lblAutre
            // 
            lblAutre.BackColor = System.Drawing.Color.White;
            lblAutre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblAutre.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAutre.Location = new System.Drawing.Point(954, 666);
            lblAutre.Name = "lblAutre";
            lblAutre.Size = new System.Drawing.Size(50, 19);
            lblAutre.TabIndex = 854;
            lblAutre.Text = "lblAutre";
            lblAutre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreAutre
            // 
            lblTitreAutre.AutoSize = true;
            lblTitreAutre.BackColor = System.Drawing.Color.White;
            lblTitreAutre.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreAutre.Location = new System.Drawing.Point(794, 666);
            lblTitreAutre.Name = "lblTitreAutre";
            lblTitreAutre.Size = new System.Drawing.Size(67, 13);
            lblTitreAutre.TabIndex = 855;
            lblTitreAutre.Text = "lblTitreAutre";
            // 
            // lblTotalTempsAR
            // 
            lblTotalTempsAR.BackColor = System.Drawing.Color.White;
            lblTotalTempsAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsAR.Location = new System.Drawing.Point(954, 646);
            lblTotalTempsAR.Name = "lblTotalTempsAR";
            lblTotalTempsAR.Size = new System.Drawing.Size(50, 19);
            lblTotalTempsAR.TabIndex = 852;
            lblTotalTempsAR.Text = "lblTotalTempsAR";
            lblTotalTempsAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTotalTemps
            // 
            lblTitreTotalTemps.AutoSize = true;
            lblTitreTotalTemps.BackColor = System.Drawing.Color.White;
            lblTitreTotalTemps.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTotalTemps.Location = new System.Drawing.Point(794, 645);
            lblTitreTotalTemps.Name = "lblTitreTotalTemps";
            lblTitreTotalTemps.Size = new System.Drawing.Size(94, 13);
            lblTitreTotalTemps.TabIndex = 853;
            lblTitreTotalTemps.Text = "lblTitreTotalTemps";
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
            // lblImprevueAR
            // 
            lblImprevueAR.BackColor = System.Drawing.Color.White;
            lblImprevueAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblImprevueAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImprevueAR.Location = new System.Drawing.Point(954, 626);
            lblImprevueAR.Name = "lblImprevueAR";
            lblImprevueAR.Size = new System.Drawing.Size(50, 19);
            lblImprevueAR.TabIndex = 850;
            lblImprevueAR.Text = "lblImprevueAR";
            lblImprevueAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreImprevue
            // 
            lblTitreImprevue.AutoSize = true;
            lblTitreImprevue.BackColor = System.Drawing.Color.White;
            lblTitreImprevue.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreImprevue.Location = new System.Drawing.Point(794, 625);
            lblTitreImprevue.Name = "lblTitreImprevue";
            lblTitreImprevue.Size = new System.Drawing.Size(86, 13);
            lblTitreImprevue.TabIndex = 851;
            lblTitreImprevue.Text = "lblTitreImprevue";
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.BackColor = System.Drawing.Color.White;
            lblTotalProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalProfit.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalProfit.Location = new System.Drawing.Point(954, 606);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new System.Drawing.Size(50, 19);
            lblTotalProfit.TabIndex = 848;
            lblTotalProfit.Text = "lblTotalProfit";
            lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProfitGlobal
            // 
            lblTitreProfitGlobal.AutoSize = true;
            lblTitreProfitGlobal.BackColor = System.Drawing.Color.White;
            lblTitreProfitGlobal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProfitGlobal.Location = new System.Drawing.Point(794, 605);
            lblTitreProfitGlobal.Name = "lblTitreProfitGlobal";
            lblTitreProfitGlobal.Size = new System.Drawing.Size(98, 13);
            lblTitreProfitGlobal.TabIndex = 849;
            lblTitreProfitGlobal.Text = "lblTitreProfitGlobal";
            // 
            // lblTotalPieceAR
            // 
            lblTotalPieceAR.BackColor = System.Drawing.Color.White;
            lblTotalPieceAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalPieceAR.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalPieceAR.Location = new System.Drawing.Point(954, 586);
            lblTotalPieceAR.Name = "lblTotalPieceAR";
            lblTotalPieceAR.Size = new System.Drawing.Size(50, 19);
            lblTotalPieceAR.TabIndex = 846;
            lblTotalPieceAR.Text = "lblTotalPieceAR";
            lblTotalPieceAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTotalPiece
            // 
            lblTitreTotalPiece.AutoSize = true;
            lblTitreTotalPiece.BackColor = System.Drawing.Color.White;
            lblTitreTotalPiece.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTotalPiece.Location = new System.Drawing.Point(794, 585);
            lblTitreTotalPiece.Name = "lblTitreTotalPiece";
            lblTitreTotalPiece.Size = new System.Drawing.Size(90, 13);
            lblTitreTotalPiece.TabIndex = 847;
            lblTitreTotalPiece.Text = "lblTitreTotalPiece";
            // 
            // shpCadreForfait
            // 
            shpCadreForfait.AutoSize = true;
            shpCadreForfait.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            shpCadreForfait.Controls.Add(lblForfait);
            shpCadreForfait.Controls.Add(lblTitreForfait);
            shpCadreForfait.Location = new System.Drawing.Point(839, 471);
            shpCadreForfait.Name = "shpCadreForfait";
            shpCadreForfait.Size = new System.Drawing.Size(180, 50);
            shpCadreForfait.TabIndex = 845;
            // 
            // shpCadrePrixSoumission
            // 
            shpCadrePrixSoumission.AutoSize = true;
            shpCadrePrixSoumission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            shpCadrePrixSoumission.Controls.Add(lblPrixSoumission);
            shpCadrePrixSoumission.Controls.Add(lblTitrePrixSoumission);
            shpCadrePrixSoumission.Location = new System.Drawing.Point(654, 471);
            shpCadrePrixSoumission.Name = "shpCadrePrixSoumission";
            shpCadrePrixSoumission.Size = new System.Drawing.Size(180, 50);
            shpCadrePrixSoumission.TabIndex = 844;
            // 
            // shpCadrePrixReception
            // 
            shpCadrePrixReception.AutoSize = true;
            shpCadrePrixReception.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            shpCadrePrixReception.Controls.Add(lblPrixReception);
            shpCadrePrixReception.Controls.Add(lblTitrePrixReception);
            shpCadrePrixReception.Location = new System.Drawing.Point(469, 471);
            shpCadrePrixReception.Name = "shpCadrePrixReception";
            shpCadrePrixReception.Size = new System.Drawing.Size(180, 50);
            shpCadrePrixReception.TabIndex = 843;
            // 
            // lblTempsSoudureSoum
            // 
            lblTempsSoudureSoum.BackColor = System.Drawing.Color.White;
            lblTempsSoudureSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsSoudureSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsSoudureSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsSoudureSoum.Location = new System.Drawing.Point(213, 545);
            lblTempsSoudureSoum.Name = "lblTempsSoudureSoum";
            lblTempsSoudureSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsSoudureSoum.TabIndex = 805;
            lblTempsSoudureSoum.Text = "lblTempsSoudureSoum";
            lblTempsSoudureSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsPeintureSoum
            // 
            lblTempsPeintureSoum.BackColor = System.Drawing.Color.White;
            lblTempsPeintureSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsPeintureSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsPeintureSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsPeintureSoum.Location = new System.Drawing.Point(213, 565);
            lblTempsPeintureSoum.Name = "lblTempsPeintureSoum";
            lblTempsPeintureSoum.Size = new System.Drawing.Size(50, 18);
            lblTempsPeintureSoum.TabIndex = 806;
            lblTempsPeintureSoum.Text = "lblTempsPeintureSoum";
            lblTempsPeintureSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsTestSoum
            // 
            lblTempsTestSoum.BackColor = System.Drawing.Color.White;
            lblTempsTestSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsTestSoum.Location = new System.Drawing.Point(213, 584);
            lblTempsTestSoum.Name = "lblTempsTestSoum";
            lblTempsTestSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsTestSoum.TabIndex = 807;
            lblTempsTestSoum.Text = "lblTempsTestSoum";
            lblTempsTestSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsInstallationSoum
            // 
            lblTempsInstallationSoum.BackColor = System.Drawing.Color.White;
            lblTempsInstallationSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsInstallationSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsInstallationSoum.Location = new System.Drawing.Point(213, 604);
            lblTempsInstallationSoum.Name = "lblTempsInstallationSoum";
            lblTempsInstallationSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsInstallationSoum.TabIndex = 808;
            lblTempsInstallationSoum.Text = "lblTempsInstallationSoum";
            lblTempsInstallationSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsGestionSoum
            // 
            lblTempsGestionSoum.BackColor = System.Drawing.Color.White;
            lblTempsGestionSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsGestionSoum.Location = new System.Drawing.Point(213, 644);
            lblTempsGestionSoum.Name = "lblTempsGestionSoum";
            lblTempsGestionSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsGestionSoum.TabIndex = 809;
            lblTempsGestionSoum.Text = "lblTempsGestionSoum";
            lblTempsGestionSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsShippingSoum
            // 
            lblTempsShippingSoum.BackColor = System.Drawing.Color.White;
            lblTempsShippingSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsShippingSoum.Location = new System.Drawing.Point(213, 664);
            lblTempsShippingSoum.Name = "lblTempsShippingSoum";
            lblTempsShippingSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsShippingSoum.TabIndex = 810;
            lblTempsShippingSoum.Text = "lblTempsShippingSoum";
            lblTempsShippingSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldescription
            // 
            lbldescription.AutoSize = true;
            lbldescription.BackColor = System.Drawing.Color.White;
            lbldescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbldescription.Location = new System.Drawing.Point(91, 70);
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new System.Drawing.Size(94, 18);
            lbldescription.TabIndex = 803;
            lbldescription.Text = "lbldescription";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.White;
            label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(11, 70);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(74, 18);
            label10.TabIndex = 804;
            label10.Text = "Desciption";
            // 
            // lblTitreSoumission
            // 
            lblTitreSoumission.AutoSize = true;
            lblTitreSoumission.BackColor = System.Drawing.Color.White;
            lblTitreSoumission.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreSoumission.Location = new System.Drawing.Point(147, 52);
            lblTitreSoumission.Name = "lblTitreSoumission";
            lblTitreSoumission.Size = new System.Drawing.Size(79, 18);
            lblTitreSoumission.TabIndex = 801;
            lblTitreSoumission.Text = "Soumission";
            // 
            // lblSoumission
            // 
            lblSoumission.AutoSize = true;
            lblSoumission.BackColor = System.Drawing.Color.White;
            lblSoumission.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumission.Location = new System.Drawing.Point(232, 52);
            lblSoumission.Name = "lblSoumission";
            lblSoumission.Size = new System.Drawing.Size(95, 18);
            lblSoumission.TabIndex = 802;
            lblSoumission.Text = "lblSoumission";
            lblSoumission.Click += new System.EventHandler(lblSoumission_Click);
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.BackColor = System.Drawing.Color.White;
            label66.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label66.Location = new System.Drawing.Point(418, 727);
            label66.Margin = new System.Windows.Forms.Padding(0);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(40, 13);
            label66.TabIndex = 800;
            label66.Text = "heures";
            // 
            // lblTotalTempsReel
            // 
            lblTotalTempsReel.BackColor = System.Drawing.Color.White;
            lblTotalTempsReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsReel.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsReel.Location = new System.Drawing.Point(367, 726);
            lblTotalTempsReel.Name = "lblTotalTempsReel";
            lblTotalTempsReel.Size = new System.Drawing.Size(50, 17);
            lblTotalTempsReel.TabIndex = 799;
            lblTotalTempsReel.Text = "lblTotalTempsReel";
            lblTotalTempsReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsShippingProj
            // 
            lblTempsShippingProj.BackColor = System.Drawing.Color.White;
            lblTempsShippingProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingProj.Location = new System.Drawing.Point(264, 664);
            lblTempsShippingProj.Name = "lblTempsShippingProj";
            lblTempsShippingProj.Size = new System.Drawing.Size(50, 19);
            lblTempsShippingProj.TabIndex = 784;
            lblTempsShippingProj.Text = "lblTempsShippingProj";
            lblTempsShippingProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxShipping
            // 
            lblTauxShipping.BackColor = System.Drawing.Color.White;
            lblTauxShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxShipping.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxShipping.Location = new System.Drawing.Point(162, 664);
            lblTauxShipping.Name = "lblTauxShipping";
            lblTauxShipping.Size = new System.Drawing.Size(50, 19);
            lblTauxShipping.TabIndex = 782;
            lblTauxShipping.Text = "lblTauxShipping";
            lblTauxShipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreShipping
            // 
            lblTitreShipping.AutoSize = true;
            lblTitreShipping.BackColor = System.Drawing.Color.White;
            lblTitreShipping.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreShipping.Location = new System.Drawing.Point(12, 664);
            lblTitreShipping.Name = "lblTitreShipping";
            lblTitreShipping.Size = new System.Drawing.Size(81, 13);
            lblTitreShipping.TabIndex = 783;
            lblTitreShipping.Text = "lblTitreShipping";
            // 
            // lblTempsGestionProj
            // 
            lblTempsGestionProj.BackColor = System.Drawing.Color.White;
            lblTempsGestionProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionProj.Location = new System.Drawing.Point(264, 644);
            lblTempsGestionProj.Name = "lblTempsGestionProj";
            lblTempsGestionProj.Size = new System.Drawing.Size(50, 19);
            lblTempsGestionProj.TabIndex = 780;
            lblTempsGestionProj.Text = "lblTempsGestionProj";
            lblTempsGestionProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxGestion
            // 
            lblTauxGestion.BackColor = System.Drawing.Color.White;
            lblTauxGestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxGestion.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxGestion.Location = new System.Drawing.Point(162, 644);
            lblTauxGestion.Name = "lblTauxGestion";
            lblTauxGestion.Size = new System.Drawing.Size(50, 19);
            lblTauxGestion.TabIndex = 778;
            lblTauxGestion.Text = "lblTauxGestion";
            lblTauxGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreGestion
            // 
            lblTitreGestion.AutoSize = true;
            lblTitreGestion.BackColor = System.Drawing.Color.White;
            lblTitreGestion.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreGestion.Location = new System.Drawing.Point(12, 644);
            lblTitreGestion.Name = "lblTitreGestion";
            lblTitreGestion.Size = new System.Drawing.Size(77, 13);
            lblTitreGestion.TabIndex = 779;
            lblTitreGestion.Text = "lblTitreGestion";
            // 
            // lblTempsFormationProj
            // 
            lblTempsFormationProj.BackColor = System.Drawing.Color.White;
            lblTempsFormationProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationProj.Location = new System.Drawing.Point(264, 624);
            lblTempsFormationProj.Name = "lblTempsFormationProj";
            lblTempsFormationProj.Size = new System.Drawing.Size(50, 19);
            lblTempsFormationProj.TabIndex = 776;
            lblTempsFormationProj.Text = "lblTempsFormationProj";
            lblTempsFormationProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxFormation
            // 
            lblTauxFormation.BackColor = System.Drawing.Color.White;
            lblTauxFormation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxFormation.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxFormation.Location = new System.Drawing.Point(162, 624);
            lblTauxFormation.Name = "lblTauxFormation";
            lblTauxFormation.Size = new System.Drawing.Size(50, 19);
            lblTauxFormation.TabIndex = 774;
            lblTauxFormation.Text = "lblTauxFormation";
            lblTauxFormation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreFormation
            // 
            lblTitreFormation.AutoSize = true;
            lblTitreFormation.BackColor = System.Drawing.Color.White;
            lblTitreFormation.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreFormation.Location = new System.Drawing.Point(12, 624);
            lblTitreFormation.Name = "lblTitreFormation";
            lblTitreFormation.Size = new System.Drawing.Size(89, 13);
            lblTitreFormation.TabIndex = 775;
            lblTitreFormation.Text = "lblTitreFormation";
            // 
            // lblTempsTestProj
            // 
            lblTempsTestProj.BackColor = System.Drawing.Color.White;
            lblTempsTestProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestProj.Location = new System.Drawing.Point(264, 604);
            lblTempsTestProj.Name = "lblTempsTestProj";
            lblTempsTestProj.Size = new System.Drawing.Size(50, 19);
            lblTempsTestProj.TabIndex = 772;
            lblTempsTestProj.Text = "lblTempsTestProj";
            lblTempsTestProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxInstallation
            // 
            lblTauxInstallation.BackColor = System.Drawing.Color.White;
            lblTauxInstallation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxInstallation.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxInstallation.Location = new System.Drawing.Point(162, 604);
            lblTauxInstallation.Name = "lblTauxInstallation";
            lblTauxInstallation.Size = new System.Drawing.Size(50, 19);
            lblTauxInstallation.TabIndex = 770;
            lblTauxInstallation.Text = "lblTauxInstallation";
            lblTauxInstallation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreInstallation
            // 
            lblTitreInstallation.AutoSize = true;
            lblTitreInstallation.BackColor = System.Drawing.Color.White;
            lblTitreInstallation.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreInstallation.Location = new System.Drawing.Point(12, 604);
            lblTitreInstallation.Name = "lblTitreInstallation";
            lblTitreInstallation.Size = new System.Drawing.Size(95, 13);
            lblTitreInstallation.TabIndex = 771;
            lblTitreInstallation.Text = "lblTitreInstallation";
            // 
            // lblTempsPeintureProj
            // 
            lblTempsPeintureProj.BackColor = System.Drawing.Color.White;
            lblTempsPeintureProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsPeintureProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsPeintureProj.Location = new System.Drawing.Point(264, 584);
            lblTempsPeintureProj.Name = "lblTempsPeintureProj";
            lblTempsPeintureProj.Size = new System.Drawing.Size(50, 19);
            lblTempsPeintureProj.TabIndex = 768;
            lblTempsPeintureProj.Text = "lblTempsPeintureProj";
            lblTempsPeintureProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTestFinal
            // 
            lblTitreTestFinal.AutoSize = true;
            lblTitreTestFinal.BackColor = System.Drawing.Color.White;
            lblTitreTestFinal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTestFinal.Location = new System.Drawing.Point(12, 584);
            lblTitreTestFinal.Name = "lblTitreTestFinal";
            lblTitreTestFinal.Size = new System.Drawing.Size(83, 13);
            lblTitreTestFinal.TabIndex = 767;
            lblTitreTestFinal.Text = "lblTitreTestFinal";
            // 
            // lblTempsAssemblageProj
            // 
            lblTempsAssemblageProj.BackColor = System.Drawing.Color.White;
            lblTempsAssemblageProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsAssemblageProj.Location = new System.Drawing.Point(264, 564);
            lblTempsAssemblageProj.Name = "lblTempsAssemblageProj";
            lblTempsAssemblageProj.Size = new System.Drawing.Size(50, 19);
            lblTempsAssemblageProj.TabIndex = 764;
            lblTempsAssemblageProj.Text = "lblTempsAssemblageProj";
            lblTempsAssemblageProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxProgAutomate
            // 
            lblTauxProgAutomate.BackColor = System.Drawing.Color.White;
            lblTauxProgAutomate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxProgAutomate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxProgAutomate.Location = new System.Drawing.Point(162, 564);
            lblTauxProgAutomate.Name = "lblTauxProgAutomate";
            lblTauxProgAutomate.Size = new System.Drawing.Size(50, 19);
            lblTauxProgAutomate.TabIndex = 762;
            lblTauxProgAutomate.Text = "lblTauxProgAutomate";
            lblTauxProgAutomate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitrePeintureFinition
            // 
            lblTitrePeintureFinition.AutoSize = true;
            lblTitrePeintureFinition.BackColor = System.Drawing.Color.White;
            lblTitrePeintureFinition.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitrePeintureFinition.Location = new System.Drawing.Point(12, 564);
            lblTitrePeintureFinition.Name = "lblTitrePeintureFinition";
            lblTitrePeintureFinition.Size = new System.Drawing.Size(117, 13);
            lblTitrePeintureFinition.TabIndex = 763;
            lblTitrePeintureFinition.Text = "lblTitrePeintureFinition";
            // 
            // lblTempsSoudureProj
            // 
            lblTempsSoudureProj.BackColor = System.Drawing.Color.White;
            lblTempsSoudureProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsSoudureProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsSoudureProj.Location = new System.Drawing.Point(264, 544);
            lblTempsSoudureProj.Name = "lblTempsSoudureProj";
            lblTempsSoudureProj.Size = new System.Drawing.Size(50, 19);
            lblTempsSoudureProj.TabIndex = 760;
            lblTempsSoudureProj.Text = "lblTempsSoudureProj";
            lblTempsSoudureProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxProgInterface
            // 
            lblTauxProgInterface.BackColor = System.Drawing.Color.White;
            lblTauxProgInterface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxProgInterface.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxProgInterface.Location = new System.Drawing.Point(162, 544);
            lblTauxProgInterface.Name = "lblTauxProgInterface";
            lblTauxProgInterface.Size = new System.Drawing.Size(50, 19);
            lblTauxProgInterface.TabIndex = 758;
            lblTauxProgInterface.Text = "lblTauxProgInterface";
            lblTauxProgInterface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreAssemblageSoudure
            // 
            lblTitreAssemblageSoudure.AutoSize = true;
            lblTitreAssemblageSoudure.BackColor = System.Drawing.Color.White;
            lblTitreAssemblageSoudure.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreAssemblageSoudure.Location = new System.Drawing.Point(12, 544);
            lblTitreAssemblageSoudure.Name = "lblTitreAssemblageSoudure";
            lblTitreAssemblageSoudure.Size = new System.Drawing.Size(137, 13);
            lblTitreAssemblageSoudure.TabIndex = 759;
            lblTitreAssemblageSoudure.Text = "lblTitreAssemblageSoudure";
            // 
            // lblTempsMachinageProj
            // 
            lblTempsMachinageProj.BackColor = System.Drawing.Color.White;
            lblTempsMachinageProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMachinageProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMachinageProj.Location = new System.Drawing.Point(264, 524);
            lblTempsMachinageProj.Name = "lblTempsMachinageProj";
            lblTempsMachinageProj.Size = new System.Drawing.Size(50, 19);
            lblTempsMachinageProj.TabIndex = 756;
            lblTempsMachinageProj.Text = "lblTempsMachinageProj";
            lblTempsMachinageProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxAssemblage
            // 
            lblTauxAssemblage.BackColor = System.Drawing.Color.White;
            lblTauxAssemblage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxAssemblage.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxAssemblage.Location = new System.Drawing.Point(162, 524);
            lblTauxAssemblage.Name = "lblTauxAssemblage";
            lblTauxAssemblage.Size = new System.Drawing.Size(50, 19);
            lblTauxAssemblage.TabIndex = 754;
            lblTauxAssemblage.Text = "lblTauxAssemblage";
            lblTauxAssemblage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreMachinage
            // 
            lblTitreMachinage.AutoSize = true;
            lblTitreMachinage.BackColor = System.Drawing.Color.White;
            lblTitreMachinage.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreMachinage.Location = new System.Drawing.Point(12, 524);
            lblTitreMachinage.Name = "lblTitreMachinage";
            lblTitreMachinage.Size = new System.Drawing.Size(93, 13);
            lblTitreMachinage.TabIndex = 755;
            lblTitreMachinage.Text = "lblTitreMachinage";
            // 
            // lblTempsCoupeProj
            // 
            lblTempsCoupeProj.BackColor = System.Drawing.Color.White;
            lblTempsCoupeProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsCoupeProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsCoupeProj.Location = new System.Drawing.Point(264, 504);
            lblTempsCoupeProj.Name = "lblTempsCoupeProj";
            lblTempsCoupeProj.Size = new System.Drawing.Size(50, 19);
            lblTempsCoupeProj.TabIndex = 752;
            lblTempsCoupeProj.Text = "lblTempsCoupeProj";
            lblTempsCoupeProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxFabrication
            // 
            lblTauxFabrication.BackColor = System.Drawing.Color.White;
            lblTauxFabrication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxFabrication.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxFabrication.Location = new System.Drawing.Point(162, 504);
            lblTauxFabrication.Name = "lblTauxFabrication";
            lblTauxFabrication.Size = new System.Drawing.Size(50, 19);
            lblTauxFabrication.TabIndex = 750;
            lblTauxFabrication.Text = "lblTauxFabrication";
            lblTauxFabrication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreCoupePreparation
            // 
            lblTitreCoupePreparation.AutoSize = true;
            lblTitreCoupePreparation.BackColor = System.Drawing.Color.White;
            lblTitreCoupePreparation.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreCoupePreparation.Location = new System.Drawing.Point(12, 504);
            lblTitreCoupePreparation.Name = "lblTitreCoupePreparation";
            lblTitreCoupePreparation.Size = new System.Drawing.Size(127, 13);
            lblTitreCoupePreparation.TabIndex = 751;
            lblTitreCoupePreparation.Text = "lblTitreCoupePreparation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(373, 469);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(32, 13);
            label7.TabIndex = 748;
            label7.Text = "Réels";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(159, 469);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 13);
            label6.TabIndex = 747;
            label6.Text = "Taux";
            // 
            // lblTempsDessinProj
            // 
            lblTempsDessinProj.BackColor = System.Drawing.Color.White;
            lblTempsDessinProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinProj.Location = new System.Drawing.Point(264, 484);
            lblTempsDessinProj.Name = "lblTempsDessinProj";
            lblTempsDessinProj.Size = new System.Drawing.Size(50, 19);
            lblTempsDessinProj.TabIndex = 745;
            lblTempsDessinProj.Text = "lblTempsDessinProj";
            lblTempsDessinProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxDessin
            // 
            lblTauxDessin.BackColor = System.Drawing.Color.White;
            lblTauxDessin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxDessin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxDessin.Location = new System.Drawing.Point(162, 484);
            lblTauxDessin.Name = "lblTauxDessin";
            lblTauxDessin.Size = new System.Drawing.Size(50, 19);
            lblTauxDessin.TabIndex = 743;
            lblTauxDessin.Text = "lblTauxDessin";
            lblTauxDessin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreConceptionDessin
            // 
            lblTitreConceptionDessin.AutoSize = true;
            lblTitreConceptionDessin.BackColor = System.Drawing.Color.White;
            lblTitreConceptionDessin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreConceptionDessin.Location = new System.Drawing.Point(12, 484);
            lblTitreConceptionDessin.Name = "lblTitreConceptionDessin";
            lblTitreConceptionDessin.Size = new System.Drawing.Size(126, 13);
            lblTitreConceptionDessin.TabIndex = 744;
            lblTitreConceptionDessin.Text = "lblTitreConceptionDessin";
            // 
            // lblProjet
            // 
            lblProjet.AutoSize = true;
            lblProjet.BackColor = System.Drawing.Color.White;
            lblProjet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjet.Location = new System.Drawing.Point(58, 52);
            lblProjet.Name = "lblProjet";
            lblProjet.Size = new System.Drawing.Size(62, 18);
            lblProjet.TabIndex = 741;
            lblProjet.Text = "lblProjet";
            // 
            // lblTitreProjet
            // 
            lblTitreProjet.AutoSize = true;
            lblTitreProjet.BackColor = System.Drawing.Color.White;
            lblTitreProjet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjet.Location = new System.Drawing.Point(11, 52);
            lblTitreProjet.Name = "lblTitreProjet";
            lblTitreProjet.Size = new System.Drawing.Size(46, 18);
            lblTitreProjet.TabIndex = 742;
            lblTitreProjet.Text = "Projet";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(1006, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(140, 58);
            pictureBox1.TabIndex = 740;
            pictureBox1.TabStop = false;
            // 
            // lblGrosTitre
            // 
            lblGrosTitre.AutoSize = true;
            lblGrosTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGrosTitre.Location = new System.Drawing.Point(229, 7);
            lblGrosTitre.Name = "lblGrosTitre";
            lblGrosTitre.Size = new System.Drawing.Size(157, 36);
            lblGrosTitre.TabIndex = 739;
            lblGrosTitre.Tag = "";
            lblGrosTitre.Text = "lblGrosTitre";
            lblGrosTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Navy;
            label2.Location = new System.Drawing.Point(315, 484);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 19);
            label2.TabIndex = 890;
            label2.Text = "label2";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.White;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(315, 525);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 19);
            label3.TabIndex = 892;
            label3.Text = "label3";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.White;
            label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Navy;
            label5.Location = new System.Drawing.Point(315, 624);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 19);
            label5.TabIndex = 893;
            label5.Text = "label5";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.White;
            label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.Navy;
            label9.Location = new System.Drawing.Point(315, 504);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(50, 19);
            label9.TabIndex = 891;
            label9.Text = "label9";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = System.Drawing.Color.White;
            label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label12.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.ForeColor = System.Drawing.Color.Navy;
            label12.Location = new System.Drawing.Point(315, 545);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(50, 19);
            label12.TabIndex = 884;
            label12.Text = "label12";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = System.Drawing.Color.White;
            label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label13.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.ForeColor = System.Drawing.Color.Navy;
            label13.Location = new System.Drawing.Point(315, 565);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(50, 18);
            label13.TabIndex = 885;
            label13.Text = "label13";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BackColor = System.Drawing.Color.White;
            label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label14.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.ForeColor = System.Drawing.Color.Navy;
            label14.Location = new System.Drawing.Point(315, 584);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(50, 19);
            label14.TabIndex = 886;
            label14.Text = "label14";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = System.Drawing.Color.White;
            label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label16.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.ForeColor = System.Drawing.Color.Navy;
            label16.Location = new System.Drawing.Point(315, 604);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(50, 19);
            label16.TabIndex = 887;
            label16.Text = "label16";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = System.Drawing.Color.White;
            label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label17.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.ForeColor = System.Drawing.Color.Navy;
            label17.Location = new System.Drawing.Point(315, 644);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(50, 19);
            label17.TabIndex = 888;
            label17.Text = "label17";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = System.Drawing.Color.White;
            label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label18.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.ForeColor = System.Drawing.Color.Navy;
            label18.Location = new System.Drawing.Point(315, 664);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(50, 19);
            label18.TabIndex = 889;
            label18.Text = "label18";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = System.Drawing.Color.White;
            label38.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.Location = new System.Drawing.Point(419, 664);
            label38.Margin = new System.Windows.Forms.Padding(0);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(40, 13);
            label38.TabIndex = 883;
            label38.Text = "heures";
            // 
            // lblTempsShippingReel
            // 
            lblTempsShippingReel.BackColor = System.Drawing.Color.White;
            lblTempsShippingReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingReel.Location = new System.Drawing.Point(367, 664);
            lblTempsShippingReel.Name = "lblTempsShippingReel";
            lblTempsShippingReel.Size = new System.Drawing.Size(50, 19);
            lblTempsShippingReel.TabIndex = 882;
            lblTempsShippingReel.Text = "lbltempsShippingReel";
            lblTempsShippingReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoumission2
            // 
            lblSoumission2.AutoSize = true;
            lblSoumission2.BackColor = System.Drawing.Color.White;
            lblSoumission2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumission2.Location = new System.Drawing.Point(419, 644);
            lblSoumission2.Margin = new System.Windows.Forms.Padding(0);
            lblSoumission2.Name = "lblSoumission2";
            lblSoumission2.Size = new System.Drawing.Size(40, 13);
            lblSoumission2.TabIndex = 881;
            lblSoumission2.Text = "heures";
            // 
            // lblTempsGestionReel
            // 
            lblTempsGestionReel.BackColor = System.Drawing.Color.White;
            lblTempsGestionReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionReel.Location = new System.Drawing.Point(367, 644);
            lblTempsGestionReel.Name = "lblTempsGestionReel";
            lblTempsGestionReel.Size = new System.Drawing.Size(50, 19);
            lblTempsGestionReel.TabIndex = 880;
            lblTempsGestionReel.Text = "lblTempsGestionReel";
            lblTempsGestionReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoumission6
            // 
            lblSoumission6.AutoSize = true;
            lblSoumission6.BackColor = System.Drawing.Color.White;
            lblSoumission6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumission6.Location = new System.Drawing.Point(419, 624);
            lblSoumission6.Margin = new System.Windows.Forms.Padding(0);
            lblSoumission6.Name = "lblSoumission6";
            lblSoumission6.Size = new System.Drawing.Size(40, 13);
            lblSoumission6.TabIndex = 879;
            lblSoumission6.Text = "heures";
            // 
            // lblTempsFormationReel
            // 
            lblTempsFormationReel.BackColor = System.Drawing.Color.White;
            lblTempsFormationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationReel.Location = new System.Drawing.Point(367, 624);
            lblTempsFormationReel.Name = "lblTempsFormationReel";
            lblTempsFormationReel.Size = new System.Drawing.Size(50, 19);
            lblTempsFormationReel.TabIndex = 878;
            lblTempsFormationReel.Text = "lblTempsMiseServiceReel";
            lblTempsFormationReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.BackColor = System.Drawing.Color.White;
            label50.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.Location = new System.Drawing.Point(419, 604);
            label50.Margin = new System.Windows.Forms.Padding(0);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(40, 13);
            label50.TabIndex = 877;
            label50.Text = "heures";
            // 
            // label25
            // 
            label25.BackColor = System.Drawing.Color.White;
            label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label25.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.Location = new System.Drawing.Point(367, 604);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(50, 19);
            label25.TabIndex = 876;
            label25.Text = "0";
            label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.White;
            label26.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(419, 584);
            label26.Margin = new System.Windows.Forms.Padding(0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(40, 13);
            label26.TabIndex = 875;
            label26.Text = "heures";
            // 
            // label28
            // 
            label28.BackColor = System.Drawing.Color.White;
            label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label28.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.Location = new System.Drawing.Point(367, 584);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(50, 19);
            label28.TabIndex = 874;
            label28.Text = "0";
            label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = System.Drawing.Color.White;
            label29.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.Location = new System.Drawing.Point(419, 564);
            label29.Margin = new System.Windows.Forms.Padding(0);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(40, 13);
            label29.TabIndex = 873;
            label29.Text = "heures";
            // 
            // label30
            // 
            label30.BackColor = System.Drawing.Color.White;
            label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label30.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.Location = new System.Drawing.Point(367, 564);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(50, 19);
            label30.TabIndex = 872;
            label30.Text = "0";
            label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = System.Drawing.Color.White;
            label31.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.Location = new System.Drawing.Point(419, 544);
            label31.Margin = new System.Windows.Forms.Padding(0);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(40, 13);
            label31.TabIndex = 871;
            label31.Text = "heures";
            // 
            // label32
            // 
            label32.BackColor = System.Drawing.Color.White;
            label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label32.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label32.Location = new System.Drawing.Point(367, 544);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(50, 19);
            label32.TabIndex = 870;
            label32.Text = "0";
            label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = System.Drawing.Color.White;
            label33.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.Location = new System.Drawing.Point(419, 524);
            label33.Margin = new System.Windows.Forms.Padding(0);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(40, 13);
            label33.TabIndex = 869;
            label33.Text = "heures";
            // 
            // label34
            // 
            label34.BackColor = System.Drawing.Color.White;
            label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label34.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(367, 524);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(50, 19);
            label34.TabIndex = 868;
            label34.Text = "0";
            label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = System.Drawing.Color.White;
            label35.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.Location = new System.Drawing.Point(419, 504);
            label35.Margin = new System.Windows.Forms.Padding(0);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(40, 13);
            label35.TabIndex = 867;
            label35.Text = "heures";
            // 
            // label36
            // 
            label36.BackColor = System.Drawing.Color.White;
            label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label36.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label36.Location = new System.Drawing.Point(367, 504);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(50, 19);
            label36.TabIndex = 866;
            label36.Text = "0";
            label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = System.Drawing.Color.White;
            label37.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.Location = new System.Drawing.Point(419, 484);
            label37.Margin = new System.Windows.Forms.Padding(0);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(40, 13);
            label37.TabIndex = 865;
            label37.Text = "heures";
            // 
            // label39
            // 
            label39.BackColor = System.Drawing.Color.White;
            label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label39.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.Location = new System.Drawing.Point(367, 484);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(50, 19);
            label39.TabIndex = 864;
            label39.Text = "0";
            label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblclient
            // 
            lblclient.AutoSize = true;
            lblclient.BackColor = System.Drawing.Color.White;
            lblclient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblclient.Location = new System.Drawing.Point(606, 72);
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
            lblTitreClient.Location = new System.Drawing.Point(526, 72);
            lblTitreClient.Name = "lblTitreClient";
            lblTitreClient.Size = new System.Drawing.Size(90, 18);
            lblTitreClient.TabIndex = 740;
            lblTitreClient.Text = "lblTitreClient";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = System.Drawing.Color.White;
            lblContact.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblContact.Location = new System.Drawing.Point(606, 90);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(69, 18);
            lblContact.TabIndex = 741;
            lblContact.Text = "lblcontact";
            // 
            // lblTitreContact
            // 
            lblTitreContact.AutoSize = true;
            lblTitreContact.BackColor = System.Drawing.Color.White;
            lblTitreContact.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreContact.Location = new System.Drawing.Point(526, 90);
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
            lblNoFacture.Location = new System.Drawing.Point(91, 96);
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
            lblTitreNoFacture.Location = new System.Drawing.Point(11, 96);
            lblTitreNoFacture.Name = "lblTitreNoFacture";
            lblTitreNoFacture.Size = new System.Drawing.Size(117, 18);
            lblTitreNoFacture.TabIndex = 744;
            lblTitreNoFacture.Text = "lblTitreNoFacture";
            // 
            // lblSoumission0
            // 
            lblSoumission0.BackColor = System.Drawing.Color.White;
            lblSoumission0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblSoumission0.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumission0.Location = new System.Drawing.Point(315, 726);
            lblSoumission0.Name = "lblSoumission0";
            lblSoumission0.Size = new System.Drawing.Size(50, 17);
            lblSoumission0.TabIndex = 894;
            lblSoumission0.Text = "lblSoumission0";
            lblSoumission0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoumission1
            // 
            lblSoumission1.BackColor = System.Drawing.Color.White;
            lblSoumission1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblSoumission1.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumission1.Location = new System.Drawing.Point(264, 726);
            lblSoumission1.Name = "lblSoumission1";
            lblSoumission1.Size = new System.Drawing.Size(50, 17);
            lblSoumission1.TabIndex = 895;
            lblSoumission1.Text = "lblSoumission1";
            lblSoumission1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTempsRHSoum
            // 
            lblTotalTempsRHSoum.BackColor = System.Drawing.Color.White;
            lblTotalTempsRHSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsRHSoum.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsRHSoum.Location = new System.Drawing.Point(213, 726);
            lblTotalTempsRHSoum.Name = "lblTotalTempsRHSoum";
            lblTotalTempsRHSoum.Size = new System.Drawing.Size(50, 17);
            lblTotalTempsRHSoum.TabIndex = 896;
            lblTotalTempsRHSoum.Text = "lblTotalTempsRHSoum";
            lblTotalTempsRHSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(210, 469);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(36, 13);
            label8.TabIndex = 897;
            label8.Text = "Soum.";
            // 
            // lblSoumission4
            // 
            lblSoumission4.AutoSize = true;
            lblSoumission4.BackColor = System.Drawing.Color.White;
            lblSoumission4.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumission4.Location = new System.Drawing.Point(261, 469);
            lblSoumission4.Name = "lblSoumission4";
            lblSoumission4.Size = new System.Drawing.Size(29, 13);
            lblSoumission4.TabIndex = 898;
            lblSoumission4.Text = "Proj.";
            // 
            // lblSoumission5
            // 
            lblSoumission5.AutoSize = true;
            lblSoumission5.BackColor = System.Drawing.Color.White;
            lblSoumission5.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumission5.Location = new System.Drawing.Point(312, 469);
            lblSoumission5.Name = "lblSoumission5";
            lblSoumission5.Size = new System.Drawing.Size(33, 13);
            lblSoumission5.TabIndex = 899;
            lblSoumission5.Text = "Conc.";
            // 
            // lblTempsMiseServiceConc
            // 
            lblTempsMiseServiceConc.BackColor = System.Drawing.Color.White;
            lblTempsMiseServiceConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMiseServiceConc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMiseServiceConc.ForeColor = System.Drawing.Color.Navy;
            lblTempsMiseServiceConc.Location = new System.Drawing.Point(315, 684);
            lblTempsMiseServiceConc.Name = "lblTempsMiseServiceConc";
            lblTempsMiseServiceConc.Size = new System.Drawing.Size(50, 19);
            lblTempsMiseServiceConc.TabIndex = 912;
            lblTempsMiseServiceConc.Text = "lblTempsMiseServiceConc";
            lblTempsMiseServiceConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsVisionConc
            // 
            lblTempsVisionConc.BackColor = System.Drawing.Color.White;
            lblTempsVisionConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsVisionConc.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsVisionConc.ForeColor = System.Drawing.Color.Navy;
            lblTempsVisionConc.Location = new System.Drawing.Point(315, 704);
            lblTempsVisionConc.Name = "lblTempsVisionConc";
            lblTempsVisionConc.Size = new System.Drawing.Size(50, 19);
            lblTempsVisionConc.TabIndex = 913;
            lblTempsVisionConc.Text = "lblTempsVisionConc";
            lblTempsVisionConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BackColor = System.Drawing.Color.White;
            label40.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label40.Location = new System.Drawing.Point(419, 704);
            label40.Margin = new System.Windows.Forms.Padding(0);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(40, 13);
            label40.TabIndex = 911;
            label40.Text = "heures";
            // 
            // lblTempsVisionReel
            // 
            lblTempsVisionReel.BackColor = System.Drawing.Color.White;
            lblTempsVisionReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsVisionReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsVisionReel.Location = new System.Drawing.Point(367, 704);
            lblTempsVisionReel.Name = "lblTempsVisionReel";
            lblTempsVisionReel.Size = new System.Drawing.Size(50, 19);
            lblTempsVisionReel.TabIndex = 910;
            lblTempsVisionReel.Text = "lblTempsVisionReel";
            lblTempsVisionReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = System.Drawing.Color.White;
            label42.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.Location = new System.Drawing.Point(419, 684);
            label42.Margin = new System.Windows.Forms.Padding(0);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(40, 13);
            label42.TabIndex = 909;
            label42.Text = "heures";
            // 
            // lblTempsMiseServiceReel
            // 
            lblTempsMiseServiceReel.BackColor = System.Drawing.Color.White;
            lblTempsMiseServiceReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMiseServiceReel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMiseServiceReel.Location = new System.Drawing.Point(367, 684);
            lblTempsMiseServiceReel.Name = "lblTempsMiseServiceReel";
            lblTempsMiseServiceReel.Size = new System.Drawing.Size(50, 19);
            lblTempsMiseServiceReel.TabIndex = 908;
            lblTempsMiseServiceReel.Text = "lblTempsMiseServiceReel";
            lblTempsMiseServiceReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsMiseServiceSoum
            // 
            lblTempsMiseServiceSoum.BackColor = System.Drawing.Color.White;
            lblTempsMiseServiceSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMiseServiceSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMiseServiceSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsMiseServiceSoum.Location = new System.Drawing.Point(213, 684);
            lblTempsMiseServiceSoum.Name = "lblTempsMiseServiceSoum";
            lblTempsMiseServiceSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsMiseServiceSoum.TabIndex = 906;
            lblTempsMiseServiceSoum.Text = "lblTempsMiseServiceSoum";
            lblTempsMiseServiceSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsVisionSoum
            // 
            lblTempsVisionSoum.BackColor = System.Drawing.Color.White;
            lblTempsVisionSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsVisionSoum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsVisionSoum.ForeColor = System.Drawing.Color.Navy;
            lblTempsVisionSoum.Location = new System.Drawing.Point(213, 704);
            lblTempsVisionSoum.Name = "lblTempsVisionSoum";
            lblTempsVisionSoum.Size = new System.Drawing.Size(50, 19);
            lblTempsVisionSoum.TabIndex = 907;
            lblTempsVisionSoum.Text = "lblTempsVisionSoum";
            lblTempsVisionSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsVisionProj
            // 
            lblTempsVisionProj.BackColor = System.Drawing.Color.White;
            lblTempsVisionProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsVisionProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsVisionProj.Location = new System.Drawing.Point(264, 704);
            lblTempsVisionProj.Name = "lblTempsVisionProj";
            lblTempsVisionProj.Size = new System.Drawing.Size(50, 19);
            lblTempsVisionProj.TabIndex = 905;
            lblTempsVisionProj.Text = "lblTempsVisionProj";
            lblTempsVisionProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxVision
            // 
            lblTauxVision.BackColor = System.Drawing.Color.White;
            lblTauxVision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxVision.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxVision.Location = new System.Drawing.Point(162, 704);
            lblTauxVision.Name = "lblTauxVision";
            lblTauxVision.Size = new System.Drawing.Size(50, 19);
            lblTauxVision.TabIndex = 903;
            lblTauxVision.Text = "lblTauxVision";
            lblTauxVision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreVision
            // 
            lblTitreVision.AutoSize = true;
            lblTitreVision.BackColor = System.Drawing.Color.White;
            lblTitreVision.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreVision.Location = new System.Drawing.Point(12, 704);
            lblTitreVision.Name = "lblTitreVision";
            lblTitreVision.Size = new System.Drawing.Size(70, 13);
            lblTitreVision.TabIndex = 904;
            lblTitreVision.Text = "lblTitreVision";
            // 
            // lblTempsMiseServiceProj
            // 
            lblTempsMiseServiceProj.BackColor = System.Drawing.Color.White;
            lblTempsMiseServiceProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMiseServiceProj.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMiseServiceProj.Location = new System.Drawing.Point(264, 684);
            lblTempsMiseServiceProj.Name = "lblTempsMiseServiceProj";
            lblTempsMiseServiceProj.Size = new System.Drawing.Size(50, 19);
            lblTempsMiseServiceProj.TabIndex = 902;
            lblTempsMiseServiceProj.Text = "lblTempsMiseServiceProj";
            lblTempsMiseServiceProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTauxMiseService
            // 
            lblTauxMiseService.BackColor = System.Drawing.Color.White;
            lblTauxMiseService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxMiseService.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxMiseService.Location = new System.Drawing.Point(162, 684);
            lblTauxMiseService.Name = "lblTauxMiseService";
            lblTauxMiseService.Size = new System.Drawing.Size(50, 19);
            lblTauxMiseService.TabIndex = 900;
            lblTauxMiseService.Text = "lblTauxMiseService";
            lblTauxMiseService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreMiseService
            // 
            lblTitreMiseService.AutoSize = true;
            lblTitreMiseService.BackColor = System.Drawing.Color.White;
            lblTitreMiseService.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreMiseService.Location = new System.Drawing.Point(12, 684);
            lblTitreMiseService.Name = "lblTitreMiseService";
            lblTitreMiseService.Size = new System.Drawing.Size(98, 13);
            lblTitreMiseService.TabIndex = 901;
            lblTitreMiseService.Text = "lblTitreMiseService";
            // 
            // lblTauxTest
            // 
            lblTauxTest.BackColor = System.Drawing.Color.White;
            lblTauxTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTauxTest.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTauxTest.Location = new System.Drawing.Point(162, 584);
            lblTauxTest.Name = "lblTauxTest";
            lblTauxTest.Size = new System.Drawing.Size(50, 19);
            lblTauxTest.TabIndex = 914;
            lblTauxTest.Text = "lblTauxTest";
            lblTauxTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTauxTest.Click += new System.EventHandler(lblTauxTest_Click);
            // 
            // ViewSoumissionMec
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1150, 795);
            Controls.Add(lblTauxTest);
            Controls.Add(lblTempsMiseServiceConc);
            Controls.Add(lblTempsVisionConc);
            Controls.Add(label40);
            Controls.Add(lblTempsVisionReel);
            Controls.Add(label42);
            Controls.Add(lblTempsMiseServiceReel);
            Controls.Add(lblTempsMiseServiceSoum);
            Controls.Add(lblTempsVisionSoum);
            Controls.Add(lblTempsVisionProj);
            Controls.Add(lblTauxVision);
            Controls.Add(lblTitreVision);
            Controls.Add(lblTempsMiseServiceProj);
            Controls.Add(lblTauxMiseService);
            Controls.Add(lblTitreMiseService);
            Controls.Add(lblSoumission5);
            Controls.Add(lblSoumission4);
            Controls.Add(label8);
            Controls.Add(lblTotalTempsRHSoum);
            Controls.Add(lblSoumission1);
            Controls.Add(lblSoumission0);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label38);
            Controls.Add(lblTempsShippingReel);
            Controls.Add(lblSoumission2);
            Controls.Add(lblTempsGestionReel);
            Controls.Add(lblSoumission6);
            Controls.Add(lblTempsFormationReel);
            Controls.Add(lblNoFacture);
            Controls.Add(lblTitreNoFacture);
            Controls.Add(lblContact);
            Controls.Add(lblTitreContact);
            Controls.Add(lblclient);
            Controls.Add(lblTitreClient);
            Controls.Add(label50);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label28);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label32);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(label35);
            Controls.Add(label36);
            Controls.Add(label37);
            Controls.Add(label39);
            Controls.Add(statusStrip1);
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
            Controls.Add(lblTauxUniteMobile);
            Controls.Add(lblTitreNbrePersonne);
            Controls.Add(lblTempsDessinSoum);
            Controls.Add(lblTempsMachinageSoum);
            Controls.Add(lblTempsFormationSoum);
            Controls.Add(lblTempsCoupeSoum);
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
            Controls.Add(lblTempsSoudureSoum);
            Controls.Add(lblTempsPeintureSoum);
            Controls.Add(lblTempsTestSoum);
            Controls.Add(lblTempsInstallationSoum);
            Controls.Add(lblTempsGestionSoum);
            Controls.Add(lblTempsShippingSoum);
            Controls.Add(lbldescription);
            Controls.Add(label10);
            Controls.Add(lblTitreSoumission);
            Controls.Add(lblSoumission);
            Controls.Add(label66);
            Controls.Add(lblTotalTempsReel);
            Controls.Add(lblTempsShippingProj);
            Controls.Add(lblTauxShipping);
            Controls.Add(lblTitreShipping);
            Controls.Add(lblTempsGestionProj);
            Controls.Add(lblTauxGestion);
            Controls.Add(lblTitreGestion);
            Controls.Add(lblTempsFormationProj);
            Controls.Add(lblTauxFormation);
            Controls.Add(lblTitreFormation);
            Controls.Add(lblTempsTestProj);
            Controls.Add(lblTauxInstallation);
            Controls.Add(lblTitreInstallation);
            Controls.Add(lblTempsPeintureProj);
            Controls.Add(lblTitreTestFinal);
            Controls.Add(lblTempsAssemblageProj);
            Controls.Add(lblTauxProgAutomate);
            Controls.Add(lblTitrePeintureFinition);
            Controls.Add(lblTempsSoudureProj);
            Controls.Add(lblTauxProgInterface);
            Controls.Add(lblTitreAssemblageSoudure);
            Controls.Add(lblTempsMachinageProj);
            Controls.Add(lblTauxAssemblage);
            Controls.Add(lblTitreMachinage);
            Controls.Add(lblTempsCoupeProj);
            Controls.Add(lblTauxFabrication);
            Controls.Add(lblTitreCoupePreparation);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblTempsDessinProj);
            Controls.Add(lblTauxDessin);
            Controls.Add(lblTitreConceptionDessin);
            Controls.Add(lblProjet);
            Controls.Add(lblTitreProjet);
            Controls.Add(pictureBox1);
            Controls.Add(lblGrosTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewSoumissionMec";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(ViewBonTravail_Load);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            shpCadreForfait.ResumeLayout(false);
            shpCadrePrixSoumission.ResumeLayout(false);
            shpCadrePrixReception.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label lblClient;
        internal static Label lblTitreClient;
        internal static Label lblContact;
        internal static Label lblTitreContact;
        internal static Label lblNoFacture;
        internal static Label lblTitreNoFacture;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel lblNoPage;
        internal static ListView listView1;
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
        internal static Label lblTempsUniteMobile;
        internal static Label label11;
        internal static Label lblTempsTransport;
        internal static Label label15;
        internal static Label lblTempsRepas;
        internal static Label label19;
        internal static Label lblTempsHebergement;
        internal static Label label24;
        internal static Label lblPrixManuel;
        internal static Label label27;
        internal static Label lblPrixEmballage;
        internal static Label lblTitreTransportEmballage;
        internal static Label lblTitreTransportUniteMobile;
        internal static Label lblTauxTransport;
        internal static Label lblTitreTransportDeplacement;
        internal static Label lblTauxRepas;
        internal static Label lblTitreRepas;
        internal static Label lblTauxHebergement2;
        internal static Label label23;
        internal static Label lblTauxHebergement1;
        internal static Label lblTitreHebergement1;
        internal static Label lblNbrePersonne;
        internal static Label lblTauxUniteMobile;
        internal static Label lblTitreNbrePersonne;
        internal static Label lblTempsDessinSoum;
        internal static Label lblTempsMachinageSoum;
        internal static Label lblTempsFormationSoum;
        internal static Label lblTempsCoupeSoum;
        internal static Label lblCommission;
        internal static Label lblImprevue;
        internal static Label lblForfait;
        internal static Label lblTitreForfait;
        internal static Label lblPrixSoumission;
        internal static Label lblTitrePrixSoumission;
        internal static Label lblProfit;
        internal static Label lblGrandTotalAR;
        internal static Label lblTitreGrandTotal;
        internal static Label lblcommissionAR;
        internal static Label lblTitreCommission;
        internal static Label lblTitrePrixReception;
        internal static Label lblAutre;
        internal static Label lblTitreAutre;
        internal static Label lblTotalTempsAR;
        internal static Label lblTitreTotalTemps;
        internal static Label lblPrixReception;
        internal static Label lblImprevueAR;
        internal static Label lblTitreImprevue;
        internal static Label lblTotalProfit;
        internal static Label lblTitreProfitGlobal;
        internal static Label lblTotalPieceAR;
        internal static Label lblTitreTotalPiece;
        internal static Panel shpCadreForfait;
        internal static Panel shpCadrePrixSoumission;
        internal static Panel shpCadrePrixReception;
        internal static Label lblTempsSoudureSoum;
        internal static Label lblTempsPeintureSoum;
        internal static Label lblTempsTestSoum;
        internal static Label lblTempsInstallationSoum;
        internal static Label lblTempsGestionSoum;
        internal static Label lblTempsShippingSoum;
        internal static Label lbldescription;
        internal static Label label10;
        internal static Label lblTitreSoumission;
        internal static Label lblSoumission;
        internal static Label label66;
        internal static Label lblTotalTempsReel;
        internal static Label lblTempsShippingProj;
        internal static Label lblTauxShipping;
        internal static Label lblTitreShipping;
        internal static Label lblTempsGestionProj;
        internal static Label lblTauxGestion;
        internal static Label lblTitreGestion;
        internal static Label lblTempsFormationProj;
        internal static Label lblTauxFormation;
        internal static Label lblTitreFormation;
        internal static Label lblTempsTestProj;
        internal static Label lblTauxInstallation;
        internal static Label lblTitreInstallation;
        internal static Label lblTempsPeintureProj;
        internal static Label lblTitreTestFinal;
        internal static Label lblTempsAssemblageProj;
        internal static Label lblTauxProgAutomate;
        internal static Label lblTitrePeintureFinition;
        internal static Label lblTempsSoudureProj;
        internal static Label lblTauxProgInterface;
        internal static Label lblTitreAssemblageSoudure;
        internal static Label lblTempsMachinageProj;
        internal static Label lblTauxAssemblage;
        internal static Label lblTitreMachinage;
        internal static Label lblTempsCoupeProj;
        internal static Label lblTauxFabrication;
        internal static Label lblTitreCoupePreparation;
        internal static Label label7;
        internal static Label label6;
        internal static Label lblTempsDessinProj;
        internal static Label lblTauxDessin;
        internal static Label lblTitreConceptionDessin;
        internal static Label lblProjet;
        internal static Label lblTitreProjet;
        internal static PictureBox pictureBox1;
        internal static Label lblGrosTitre;
        internal static Label label2;
        internal static Label label3;
        internal static Label label5;
        internal static Label label9;
        internal static Label label12;
        internal static Label label13;
        internal static Label label14;
        internal static Label label16;
        internal static Label label17;
        internal static Label label18;
        internal static Label label38;
        internal static Label lblTempsShippingReel;
        internal static Label lblSoumission2;
        internal static Label lblTempsGestionReel;
        internal static Label lblSoumission6;
        internal static Label lblTempsFormationReel;
        internal static Label label50;
        internal static Label label25;
        internal static Label label26;
        internal static Label label28;
        internal static Label label29;
        internal static Label label30;
        internal static Label label31;
        internal static Label label32;
        internal static Label label33;
        internal static Label label34;
        internal static Label label35;
        internal static Label label36;
        internal static Label label37;
        internal static Label label39;
        internal static Label lblSoumission0;
        internal static Label lblSoumission1;
        internal static Label lblTotalTempsRHSoum;
        internal static Label label8;
        internal static Label lblSoumission4;
        internal static Label lblSoumission5;
        internal static Label lblTempsMiseServiceConc;
        internal static Label lblTempsVisionConc;
        internal static Label label40;
        internal static Label lblTempsVisionReel;
        internal static Label label42;
        internal static Label lblTempsMiseServiceReel;
        internal static Label lblTempsMiseServiceSoum;
        internal static Label lblTempsVisionSoum;
        internal static Label lblTempsVisionProj;
        internal static Label lblTauxVision;
        internal static Label lblTitreVision;
        internal static Label lblTempsMiseServiceProj;
        internal static Label lblTauxMiseService;
        internal static Label lblTitreMiseService;
        internal static Label lblTauxTest;
        internal static ToolStripStatusLabel lblDate;

        public ViewSoumissionMec()
        {
            InitializeComponent();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        private void ViewBonTravail_Load(object sender, EventArgs e)
        {
        }
        internal static ADODB.Recordset DataSource;
        internal Label lblclient;
        internal static Label lblcontact;
        Bitmap memoryImage;
        internal static bool Orientation;
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
        private void lblSoumission_Click(object sender, EventArgs e)
        {
        }
        private void lblTauxTest_Click(object sender, EventArgs e)
        {
        }
    }
}