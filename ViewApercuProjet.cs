using ADODB;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public  class ViewApercuProjet : Form
    {
         private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblTitreRapport = new System.Windows.Forms.Label();
            lblTitreNoProjet = new System.Windows.Forms.Label();
            lblNumero = new System.Windows.Forms.Label();
            lblTitreClient = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblTitreDescription = new System.Windows.Forms.Label();
            lblTotalElecProj0 = new System.Windows.Forms.Label();
            lblTitrePiecesElec = new System.Windows.Forms.Label();
            lblTitreImprevuElec = new System.Windows.Forms.Label();
            lblTitreAutresElec = new System.Windows.Forms.Label();
            lblTitreTotalElec = new System.Windows.Forms.Label();
            lblTotalElecSoum0 = new System.Windows.Forms.Label();
            lblTitreTempsMecDessin = new System.Windows.Forms.Label();
            lblTitreTempsMecCoupe = new System.Windows.Forms.Label();
            lblTitreTempsMecMachinage = new System.Windows.Forms.Label();
            lblTitreTempsMecSoudure = new System.Windows.Forms.Label();
            lblTitreTempsMecAssemblage = new System.Windows.Forms.Label();
            lblTitreTempsMecPeinture = new System.Windows.Forms.Label();
            lblTitreTempsMecTest = new System.Windows.Forms.Label();
            lblTitreTempsMecInstallation = new System.Windows.Forms.Label();
            lblTitreTempsMecFormation = new System.Windows.Forms.Label();
            lblTitreTempsMecGestion = new System.Windows.Forms.Label();
            lblTitreTempsMecShipping = new System.Windows.Forms.Label();
            lblTitrePiecesMec = new System.Windows.Forms.Label();
            lblTitreTempsMecTotal = new System.Windows.Forms.Label();
            lblTitreImprevuMec = new System.Windows.Forms.Label();
            lblTitreAutresMec = new System.Windows.Forms.Label();
            lblTitreTotalMec = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblTitreDate = new System.Windows.Forms.Label();
            lblTitreSoum = new System.Windows.Forms.Label();
            lblTitreHeuresSoum = new System.Windows.Forms.Label();
            lblTitreArgentSoum = new System.Windows.Forms.Label();
            lblTitreHeuresProj = new System.Windows.Forms.Label();
            lblTitreArgentProj = new System.Windows.Forms.Label();
            lblTitreRevenus = new System.Windows.Forms.Label();
            lblTitreForfaitElec = new System.Windows.Forms.Label();
            lblTitreForfaitMec = new System.Windows.Forms.Label();
            lblTitreTotalForfait = new System.Windows.Forms.Label();
            lblTitreDepenses = new System.Windows.Forms.Label();
            lblTitreTempsElecDessin = new System.Windows.Forms.Label();
            lblTitreTempsElecFabrication = new System.Windows.Forms.Label();
            lblTitreTempsElecAssemblage = new System.Windows.Forms.Label();
            lblTitreTempsElecProgInterface = new System.Windows.Forms.Label();
            lblTitreTempsElecProgAutomate = new System.Windows.Forms.Label();
            lblTitreTempsElecProgRobot = new System.Windows.Forms.Label();
            lblTitreTempsElecVision = new System.Windows.Forms.Label();
            lblTitreTempsElecTest = new System.Windows.Forms.Label();
            lblTitreTempsElecInstallation = new System.Windows.Forms.Label();
            lblTitreTempsElecMiseService = new System.Windows.Forms.Label();
            lblTitreTempsElecFormation = new System.Windows.Forms.Label();
            lblTitreTempsElecGestion = new System.Windows.Forms.Label();
            lblTitreTempsElecShipping = new System.Windows.Forms.Label();
            lblTitreTempsElecTotal = new System.Windows.Forms.Label();
            lblHeuresElecTotalProj0 = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblHeuresElecProgInterfaceSoum = new System.Windows.Forms.Label();
            lblArgentElecProgAutomateSoum = new System.Windows.Forms.Label();
            lblHeuresElecProgAutomateSoum = new System.Windows.Forms.Label();
            lblArgentElecProgRobotSoum = new System.Windows.Forms.Label();
            lblHeuresElecProgRobotSoum = new System.Windows.Forms.Label();
            lblHeuresElecVisionSoum = new System.Windows.Forms.Label();
            lblArgentElecTestSoum = new System.Windows.Forms.Label();
            lblArgentElecInstallationSoum = new System.Windows.Forms.Label();
            lblHeuresElecInstallationSoum = new System.Windows.Forms.Label();
            lblHeuresElecMiseServiceSoum = new System.Windows.Forms.Label();
            lblArgentElecMiseServiceSoum = new System.Windows.Forms.Label();
            lblHeuresElecFormationSoum = new System.Windows.Forms.Label();
            lblArgentElecFormationSoum = new System.Windows.Forms.Label();
            lblHeuresElecGestionSoum = new System.Windows.Forms.Label();
            lblArgentElecGestionSoum = new System.Windows.Forms.Label();
            lblHeuresElecShippingSoum = new System.Windows.Forms.Label();
            lblArgentElecShippingSoum = new System.Windows.Forms.Label();
            lblPiecesElecSoum = new System.Windows.Forms.Label();
            lblImprevuElecSoum = new System.Windows.Forms.Label();
            lblAutresElecSoum = new System.Windows.Forms.Label();
            lblArgentElecAssemblageProj = new System.Windows.Forms.Label();
            lblArgentElecRechercheProj = new System.Windows.Forms.Label();
            lblImprevuElecProj = new System.Windows.Forms.Label();
            lblPiecesElecProj = new System.Windows.Forms.Label();
            lblAutresElecProj = new System.Windows.Forms.Label();
            lblArgentElecTotalSoum = new System.Windows.Forms.Label();
            lblArgentElecTotalProj = new System.Windows.Forms.Label();
            lblHeuresMecDessinSoum = new System.Windows.Forms.Label();
            lblArgentMecDessinSoum = new System.Windows.Forms.Label();
            lblHeuresMecCoupeSoum = new System.Windows.Forms.Label();
            lblArgentMecCoupeSoum = new System.Windows.Forms.Label();
            lblHeuresMecMachinageSoum = new System.Windows.Forms.Label();
            lblArgentMecMachinageSoum = new System.Windows.Forms.Label();
            lblHeuresMecSoudureSoum = new System.Windows.Forms.Label();
            lblArgentMecSoudureSoum = new System.Windows.Forms.Label();
            lblHeuresMecAssemblageSoum = new System.Windows.Forms.Label();
            lblArgentMecAssemblageSoum = new System.Windows.Forms.Label();
            lblHeuresMecPeintureSoum = new System.Windows.Forms.Label();
            lblArgentMecPeintureSoum = new System.Windows.Forms.Label();
            lblHeuresMecTestSoum = new System.Windows.Forms.Label();
            lblAutresMecProj = new System.Windows.Forms.Label();
            lblTitreProfitTotal = new System.Windows.Forms.Label();
            lblArgentElecDessinSoum = new System.Windows.Forms.Label();
            lblHeuresElecDessinSoum = new System.Windows.Forms.Label();
            lblArgentElecFabricationSoum = new System.Windows.Forms.Label();
            lblHeuresElecFabricationSoum = new System.Windows.Forms.Label();
            lblArgentElecAssemblageSoum = new System.Windows.Forms.Label();
            lblHeuresElecAssemblageSoum = new System.Windows.Forms.Label();
            lblArgentElecProgInterfaceSoum = new System.Windows.Forms.Label();
            lblArgentElecVisionSoum = new System.Windows.Forms.Label();
            lblHeuresElecTestSoum = new System.Windows.Forms.Label();
            lblHeuresElecMiseServiceProj = new System.Windows.Forms.Label();
            lblArgentElecMiseServiceProj = new System.Windows.Forms.Label();
            lblHeuresElecFormationProj = new System.Windows.Forms.Label();
            lblArgentElecFormationProj = new System.Windows.Forms.Label();
            lblHeuresElecGestionProj = new System.Windows.Forms.Label();
            lblTotalForfaitProj = new System.Windows.Forms.Label();
            lblHeuresElecTotalProj = new System.Windows.Forms.Label();
            lblHeuresMecTotalProj = new System.Windows.Forms.Label();
            lblGrandTotalProj = new System.Windows.Forms.Label();
            lblTotalMecProj = new System.Windows.Forms.Label();
            lblProfitSoum = new System.Windows.Forms.Label();
            lblProfitProj = new System.Windows.Forms.Label();
            lblArgentElecVisionProj = new System.Windows.Forms.Label();
            lblHeuresElecTestProj = new System.Windows.Forms.Label();
            lblArgentElecTestProj = new System.Windows.Forms.Label();
            lblArgentMecTestSoum = new System.Windows.Forms.Label();
            lblHeuresMecInstallationSoum = new System.Windows.Forms.Label();
            lblArgentMecInstallationSoum = new System.Windows.Forms.Label();
            lblHeuresMecFormationSoum = new System.Windows.Forms.Label();
            lblArgentMecFormationSoum = new System.Windows.Forms.Label();
            lblHeuresMecGestionSoum = new System.Windows.Forms.Label();
            lblArgentMecGestionSoum = new System.Windows.Forms.Label();
            lblHeuresMecShippingSoum = new System.Windows.Forms.Label();
            lblArgentMecShippingSoum = new System.Windows.Forms.Label();
            lblHeuresMecFormationProj = new System.Windows.Forms.Label();
            lblArgentMecFormationProj = new System.Windows.Forms.Label();
            lblHeuresMecGestionProj = new System.Windows.Forms.Label();
            lblArgentMecGestionProj = new System.Windows.Forms.Label();
            lblArgentMecShippingProj = new System.Windows.Forms.Label();
            lblArgentElecInstallationProj = new System.Windows.Forms.Label();
            lblHeuresElecInstallationProj = new System.Windows.Forms.Label();
            lblPiecesMecSoum = new System.Windows.Forms.Label();
            lblImprevuMecSoum = new System.Windows.Forms.Label();
            lblAutresMecSoum = new System.Windows.Forms.Label();
            lblHeuresMecDessinProj = new System.Windows.Forms.Label();
            lblArgentMecDessinProj = new System.Windows.Forms.Label();
            lblHeuresMecCoupeProj = new System.Windows.Forms.Label();
            lblArgentMecCoupeProj = new System.Windows.Forms.Label();
            lblArgentMecMachinageProj = new System.Windows.Forms.Label();
            lblHeuresMecMachinageProj = new System.Windows.Forms.Label();
            lblHeuresMecSoudureProj = new System.Windows.Forms.Label();
            lblArgentMecSoudureProj = new System.Windows.Forms.Label();
            lblHeuresMecAssemblageProj = new System.Windows.Forms.Label();
            lblArgentMecAssemblageProj = new System.Windows.Forms.Label();
            lblHeuresMecPeintureProj = new System.Windows.Forms.Label();
            lblArgentMecPeintureProj = new System.Windows.Forms.Label();
            lblHeuresMecTestProj = new System.Windows.Forms.Label();
            lblArgentMecTestProj = new System.Windows.Forms.Label();
            lblHeuresMecInstallationProj = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblForfaitMecSoum = new System.Windows.Forms.Label();
            lblForfaitElecSoum = new System.Windows.Forms.Label();
            lblTotalForfaitSoum = new System.Windows.Forms.Label();
            lblForfaitElecProj = new System.Windows.Forms.Label();
            lblForfaitMecProj = new System.Windows.Forms.Label();
            lblHeuresElecTotalSoum = new System.Windows.Forms.Label();
            lblHeuresMecTotalSoum = new System.Windows.Forms.Label();
            lblTotalHeuresSoum = new System.Windows.Forms.Label();
            lblGrandTotalSoum = new System.Windows.Forms.Label();
            lblTotalMecSoum = new System.Windows.Forms.Label();
            lblHeuresElecDessinProj = new System.Windows.Forms.Label();
            lblArgentElecDessinProj = new System.Windows.Forms.Label();
            lblHeuresElecFabricationProj = new System.Windows.Forms.Label();
            lblArgentElecFabricationProj = new System.Windows.Forms.Label();
            lblHeuresElecAssemblageProj = new System.Windows.Forms.Label();
            lblHeuresElecProgInterfaceProj = new System.Windows.Forms.Label();
            lblArgentElecProgInterfaceProj = new System.Windows.Forms.Label();
            lblArgentElecProgAutomateProj = new System.Windows.Forms.Label();
            lblHeuresElecProgAutomateProj = new System.Windows.Forms.Label();
            lblHeuresElecProgRobotProj = new System.Windows.Forms.Label();
            lblArgentElecProgRobotProj = new System.Windows.Forms.Label();
            lblHeuresElecVisionProj = new System.Windows.Forms.Label();
            lblArgentMecTotalSoum = new System.Windows.Forms.Label();
            lblArgentMecTotalProj = new System.Windows.Forms.Label();
            lblArgentElecGestionProj = new System.Windows.Forms.Label();
            lblHeuresElecShippingProj = new System.Windows.Forms.Label();
            lblArgentElecShippingProj = new System.Windows.Forms.Label();
            lblHeuresElecRechercheProj = new System.Windows.Forms.Label();
            lblArgentMecInstallationProj = new System.Windows.Forms.Label();
            lblHeuresMecShippingProj = new System.Windows.Forms.Label();
            lblHeuresMecRechercheProj = new System.Windows.Forms.Label();
            lblArgentMecRechercheProj = new System.Windows.Forms.Label();
            lblPiecesMecProj = new System.Windows.Forms.Label();
            lblImprevuMecProj = new System.Windows.Forms.Label();
            lblTitreProj = new System.Windows.Forms.Label();
            lblTitreTotal = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitreRapport
            // 
            lblTitreRapport.AutoSize = true;
            lblTitreRapport.BackColor = System.Drawing.Color.White;
            lblTitreRapport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreRapport.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreRapport.ForeColor = System.Drawing.Color.Navy;
            lblTitreRapport.Location = new System.Drawing.Point(15, 9);
            lblTitreRapport.Name = "lblTitreRapport";
            lblTitreRapport.Size = new System.Drawing.Size(168, 28);
            lblTitreRapport.TabIndex = 303;
            lblTitreRapport.Text = "Aperçu de projets";
            lblTitreRapport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreNoProjet
            // 
            lblTitreNoProjet.BackColor = System.Drawing.Color.White;
            lblTitreNoProjet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreNoProjet.ForeColor = System.Drawing.Color.Navy;
            lblTitreNoProjet.Location = new System.Drawing.Point(190, 62);
            lblTitreNoProjet.Name = "lblTitreNoProjet";
            lblTitreNoProjet.Size = new System.Drawing.Size(108, 17);
            lblTitreNoProjet.TabIndex = 304;
            lblTitreNoProjet.Text = "Numéro du projet: ";
            lblTitreNoProjet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = System.Drawing.Color.White;
            lblNumero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNumero.ForeColor = System.Drawing.Color.Navy;
            lblNumero.Location = new System.Drawing.Point(299, 62);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new System.Drawing.Size(65, 15);
            lblNumero.TabIndex = 360;
            lblNumero.Text = "lblNumero";
            // 
            // lblTitreClient
            // 
            lblTitreClient.BackColor = System.Drawing.Color.White;
            lblTitreClient.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreClient.ForeColor = System.Drawing.Color.Navy;
            lblTitreClient.Location = new System.Drawing.Point(190, 82);
            lblTitreClient.Name = "lblTitreClient";
            lblTitreClient.Size = new System.Drawing.Size(108, 15);
            lblTitreClient.TabIndex = 361;
            lblTitreClient.Text = "Client";
            lblTitreClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = System.Drawing.Color.White;
            lblClient.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClient.ForeColor = System.Drawing.Color.Navy;
            lblClient.Location = new System.Drawing.Point(299, 81);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(54, 15);
            lblClient.TabIndex = 362;
            lblClient.Text = "lblClient";
            // 
            // lblTitreDescription
            // 
            lblTitreDescription.BackColor = System.Drawing.Color.White;
            lblTitreDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreDescription.ForeColor = System.Drawing.Color.Navy;
            lblTitreDescription.Location = new System.Drawing.Point(190, 99);
            lblTitreDescription.Name = "lblTitreDescription";
            lblTitreDescription.Size = new System.Drawing.Size(108, 17);
            lblTitreDescription.TabIndex = 363;
            lblTitreDescription.Text = "Description";
            lblTitreDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalElecProj0
            // 
            lblTotalElecProj0.BackColor = System.Drawing.Color.White;
            lblTotalElecProj0.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalElecProj0.ForeColor = System.Drawing.Color.Navy;
            lblTotalElecProj0.Location = new System.Drawing.Point(563, 472);
            lblTotalElecProj0.Name = "lblTotalElecProj0";
            lblTotalElecProj0.Size = new System.Drawing.Size(118, 14);
            lblTotalElecProj0.TabIndex = 364;
            lblTotalElecProj0.Text = "0.00";
            // 
            // lblTitrePiecesElec
            // 
            lblTitrePiecesElec.AutoSize = true;
            lblTitrePiecesElec.BackColor = System.Drawing.Color.White;
            lblTitrePiecesElec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitrePiecesElec.ForeColor = System.Drawing.Color.Navy;
            lblTitrePiecesElec.Location = new System.Drawing.Point(52, 495);
            lblTitrePiecesElec.Name = "lblTitrePiecesElec";
            lblTitrePiecesElec.Size = new System.Drawing.Size(34, 13);
            lblTitrePiecesElec.TabIndex = 365;
            lblTitrePiecesElec.Text = "Pieces";
            lblTitrePiecesElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreImprevuElec
            // 
            lblTitreImprevuElec.AutoSize = true;
            lblTitreImprevuElec.BackColor = System.Drawing.Color.White;
            lblTitreImprevuElec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreImprevuElec.ForeColor = System.Drawing.Color.Navy;
            lblTitreImprevuElec.Location = new System.Drawing.Point(52, 513);
            lblTitreImprevuElec.Name = "lblTitreImprevuElec";
            lblTitreImprevuElec.Size = new System.Drawing.Size(100, 13);
            lblTitreImprevuElec.TabIndex = 366;
            lblTitreImprevuElec.Text = "Imprévu, fournitures";
            lblTitreImprevuElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreAutresElec
            // 
            lblTitreAutresElec.AutoSize = true;
            lblTitreAutresElec.BackColor = System.Drawing.Color.White;
            lblTitreAutresElec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreAutresElec.ForeColor = System.Drawing.Color.Navy;
            lblTitreAutresElec.Location = new System.Drawing.Point(53, 532);
            lblTitreAutresElec.Name = "lblTitreAutresElec";
            lblTitreAutresElec.Size = new System.Drawing.Size(36, 13);
            lblTitreAutresElec.TabIndex = 367;
            lblTitreAutresElec.Text = "Autres";
            lblTitreAutresElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreTotalElec
            // 
            lblTitreTotalElec.AutoSize = true;
            lblTitreTotalElec.BackColor = System.Drawing.Color.White;
            lblTitreTotalElec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTotalElec.ForeColor = System.Drawing.Color.Navy;
            lblTitreTotalElec.Location = new System.Drawing.Point(53, 552);
            lblTitreTotalElec.Name = "lblTitreTotalElec";
            lblTitreTotalElec.Size = new System.Drawing.Size(75, 13);
            lblTitreTotalElec.TabIndex = 368;
            lblTitreTotalElec.Text = "Total Électrique";
            lblTitreTotalElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalElecSoum0
            // 
            lblTotalElecSoum0.BackColor = System.Drawing.Color.White;
            lblTotalElecSoum0.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalElecSoum0.ForeColor = System.Drawing.Color.Navy;
            lblTotalElecSoum0.Location = new System.Drawing.Point(328, 550);
            lblTotalElecSoum0.Name = "lblTotalElecSoum0";
            lblTotalElecSoum0.Size = new System.Drawing.Size(118, 14);
            lblTotalElecSoum0.TabIndex = 369;
            lblTotalElecSoum0.Text = "0.00";
            // 
            // lblTitreTempsMecDessin
            // 
            lblTitreTempsMecDessin.AutoSize = true;
            lblTitreTempsMecDessin.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecDessin.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecDessin.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecDessin.Location = new System.Drawing.Point(54, 577);
            lblTitreTempsMecDessin.Name = "lblTitreTempsMecDessin";
            lblTitreTempsMecDessin.Size = new System.Drawing.Size(103, 13);
            lblTitreTempsMecDessin.TabIndex = 372;
            lblTitreTempsMecDessin.Text = "Conception et dessins";
            // 
            // lblTitreTempsMecCoupe
            // 
            lblTitreTempsMecCoupe.AutoSize = true;
            lblTitreTempsMecCoupe.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecCoupe.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecCoupe.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecCoupe.Location = new System.Drawing.Point(54, 595);
            lblTitreTempsMecCoupe.Name = "lblTitreTempsMecCoupe";
            lblTitreTempsMecCoupe.Size = new System.Drawing.Size(104, 13);
            lblTitreTempsMecCoupe.TabIndex = 373;
            lblTitreTempsMecCoupe.Text = "Coupe et préparation";
            // 
            // lblTitreTempsMecMachinage
            // 
            lblTitreTempsMecMachinage.AutoSize = true;
            lblTitreTempsMecMachinage.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecMachinage.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecMachinage.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecMachinage.Location = new System.Drawing.Point(54, 614);
            lblTitreTempsMecMachinage.Name = "lblTitreTempsMecMachinage";
            lblTitreTempsMecMachinage.Size = new System.Drawing.Size(58, 13);
            lblTitreTempsMecMachinage.TabIndex = 374;
            lblTitreTempsMecMachinage.Text = "Machinage";
            // 
            // lblTitreTempsMecSoudure
            // 
            lblTitreTempsMecSoudure.AutoSize = true;
            lblTitreTempsMecSoudure.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecSoudure.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecSoudure.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecSoudure.Location = new System.Drawing.Point(53, 632);
            lblTitreTempsMecSoudure.Name = "lblTitreTempsMecSoudure";
            lblTitreTempsMecSoudure.Size = new System.Drawing.Size(130, 13);
            lblTitreTempsMecSoudure.TabIndex = 375;
            lblTitreTempsMecSoudure.Text = "Coupe, soudure et meulage";
            // 
            // lblTitreTempsMecAssemblage
            // 
            lblTitreTempsMecAssemblage.AutoSize = true;
            lblTitreTempsMecAssemblage.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecAssemblage.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecAssemblage.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecAssemblage.Location = new System.Drawing.Point(53, 650);
            lblTitreTempsMecAssemblage.Name = "lblTitreTempsMecAssemblage";
            lblTitreTempsMecAssemblage.Size = new System.Drawing.Size(119, 13);
            lblTitreTempsMecAssemblage.TabIndex = 376;
            lblTitreTempsMecAssemblage.Text = "Assemblage des systèmes";
            // 
            // lblTitreTempsMecPeinture
            // 
            lblTitreTempsMecPeinture.AutoSize = true;
            lblTitreTempsMecPeinture.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecPeinture.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecPeinture.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecPeinture.Location = new System.Drawing.Point(54, 669);
            lblTitreTempsMecPeinture.Name = "lblTitreTempsMecPeinture";
            lblTitreTempsMecPeinture.Size = new System.Drawing.Size(90, 13);
            lblTitreTempsMecPeinture.TabIndex = 377;
            lblTitreTempsMecPeinture.Text = "Peinture et finition";
            // 
            // lblTitreTempsMecTest
            // 
            lblTitreTempsMecTest.AutoSize = true;
            lblTitreTempsMecTest.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecTest.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecTest.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecTest.Location = new System.Drawing.Point(54, 687);
            lblTitreTempsMecTest.Name = "lblTitreTempsMecTest";
            lblTitreTempsMecTest.Size = new System.Drawing.Size(59, 13);
            lblTitreTempsMecTest.TabIndex = 378;
            lblTitreTempsMecTest.Text = "Tests finaux";
            // 
            // lblTitreTempsMecInstallation
            // 
            lblTitreTempsMecInstallation.AutoSize = true;
            lblTitreTempsMecInstallation.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecInstallation.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecInstallation.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecInstallation.Location = new System.Drawing.Point(54, 705);
            lblTitreTempsMecInstallation.Name = "lblTitreTempsMecInstallation";
            lblTitreTempsMecInstallation.Size = new System.Drawing.Size(58, 13);
            lblTitreTempsMecInstallation.TabIndex = 379;
            lblTitreTempsMecInstallation.Text = "Installation";
            // 
            // lblTitreTempsMecFormation
            // 
            lblTitreTempsMecFormation.AutoSize = true;
            lblTitreTempsMecFormation.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecFormation.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecFormation.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecFormation.Location = new System.Drawing.Point(53, 723);
            lblTitreTempsMecFormation.Name = "lblTitreTempsMecFormation";
            lblTitreTempsMecFormation.Size = new System.Drawing.Size(115, 13);
            lblTitreTempsMecFormation.TabIndex = 380;
            lblTitreTempsMecFormation.Text = "Formation du personnel";
            // 
            // lblTitreTempsMecGestion
            // 
            lblTitreTempsMecGestion.AutoSize = true;
            lblTitreTempsMecGestion.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecGestion.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecGestion.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecGestion.Location = new System.Drawing.Point(54, 741);
            lblTitreTempsMecGestion.Name = "lblTitreTempsMecGestion";
            lblTitreTempsMecGestion.Size = new System.Drawing.Size(85, 13);
            lblTitreTempsMecGestion.TabIndex = 381;
            lblTitreTempsMecGestion.Text = "Gestion du projet";
            // 
            // lblTitreTempsMecShipping
            // 
            lblTitreTempsMecShipping.AutoSize = true;
            lblTitreTempsMecShipping.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecShipping.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecShipping.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecShipping.Location = new System.Drawing.Point(54, 759);
            lblTitreTempsMecShipping.Name = "lblTitreTempsMecShipping";
            lblTitreTempsMecShipping.Size = new System.Drawing.Size(54, 13);
            lblTitreTempsMecShipping.TabIndex = 382;
            lblTitreTempsMecShipping.Text = "Expédition";
            // 
            // lblTitrePiecesMec
            // 
            lblTitrePiecesMec.AutoSize = true;
            lblTitrePiecesMec.BackColor = System.Drawing.Color.White;
            lblTitrePiecesMec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitrePiecesMec.ForeColor = System.Drawing.Color.Navy;
            lblTitrePiecesMec.Location = new System.Drawing.Point(54, 818);
            lblTitrePiecesMec.Name = "lblTitrePiecesMec";
            lblTitrePiecesMec.Size = new System.Drawing.Size(34, 13);
            lblTitrePiecesMec.TabIndex = 384;
            lblTitrePiecesMec.Text = "Pièces";
            lblTitrePiecesMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreTempsMecTotal
            // 
            lblTitreTempsMecTotal.AutoSize = true;
            lblTitreTempsMecTotal.BackColor = System.Drawing.Color.White;
            lblTitreTempsMecTotal.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsMecTotal.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsMecTotal.Location = new System.Drawing.Point(54, 796);
            lblTitreTempsMecTotal.Name = "lblTitreTempsMecTotal";
            lblTitreTempsMecTotal.Size = new System.Drawing.Size(76, 13);
            lblTitreTempsMecTotal.TabIndex = 383;
            lblTitreTempsMecTotal.Text = "Total des temps";
            // 
            // lblTitreImprevuMec
            // 
            lblTitreImprevuMec.AutoSize = true;
            lblTitreImprevuMec.BackColor = System.Drawing.Color.White;
            lblTitreImprevuMec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreImprevuMec.ForeColor = System.Drawing.Color.Navy;
            lblTitreImprevuMec.Location = new System.Drawing.Point(53, 836);
            lblTitreImprevuMec.Name = "lblTitreImprevuMec";
            lblTitreImprevuMec.Size = new System.Drawing.Size(100, 13);
            lblTitreImprevuMec.TabIndex = 385;
            lblTitreImprevuMec.Text = "Imprévu, fournitures";
            lblTitreImprevuMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreAutresMec
            // 
            lblTitreAutresMec.AutoSize = true;
            lblTitreAutresMec.BackColor = System.Drawing.Color.White;
            lblTitreAutresMec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreAutresMec.ForeColor = System.Drawing.Color.Navy;
            lblTitreAutresMec.Location = new System.Drawing.Point(53, 854);
            lblTitreAutresMec.Name = "lblTitreAutresMec";
            lblTitreAutresMec.Size = new System.Drawing.Size(36, 13);
            lblTitreAutresMec.TabIndex = 386;
            lblTitreAutresMec.Text = "Autres";
            lblTitreAutresMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreTotalMec
            // 
            lblTitreTotalMec.AutoSize = true;
            lblTitreTotalMec.BackColor = System.Drawing.Color.White;
            lblTitreTotalMec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTotalMec.ForeColor = System.Drawing.Color.Navy;
            lblTitreTotalMec.Location = new System.Drawing.Point(53, 872);
            lblTitreTotalMec.Name = "lblTitreTotalMec";
            lblTitreTotalMec.Size = new System.Drawing.Size(81, 13);
            lblTitreTotalMec.TabIndex = 387;
            lblTitreTotalMec.Text = "Total mécanique";
            lblTitreTotalMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Navy;
            label1.Location = new System.Drawing.Point(54, 777);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 13);
            label1.TabIndex = 388;
            label1.Text = "Dev. Expérimental";
            // 
            // lblTitreDate
            // 
            lblTitreDate.AutoSize = true;
            lblTitreDate.BackColor = System.Drawing.Color.White;
            lblTitreDate.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreDate.ForeColor = System.Drawing.Color.Navy;
            lblTitreDate.Location = new System.Drawing.Point(103, 117);
            lblTitreDate.Name = "lblTitreDate";
            lblTitreDate.Size = new System.Drawing.Size(29, 13);
            lblTitreDate.TabIndex = 389;
            lblTitreDate.Text = "Date";
            lblTitreDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreSoum
            // 
            lblTitreSoum.BackColor = System.Drawing.Color.White;
            lblTitreSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreSoum.ForeColor = System.Drawing.Color.Navy;
            lblTitreSoum.Location = new System.Drawing.Point(210, 193);
            lblTitreSoum.Name = "lblTitreSoum";
            lblTitreSoum.Size = new System.Drawing.Size(235, 15);
            lblTitreSoum.TabIndex = 390;
            lblTitreSoum.Text = "Soumission";
            lblTitreSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreHeuresSoum
            // 
            lblTitreHeuresSoum.BackColor = System.Drawing.Color.White;
            lblTitreHeuresSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreHeuresSoum.ForeColor = System.Drawing.Color.Navy;
            lblTitreHeuresSoum.Location = new System.Drawing.Point(209, 209);
            lblTitreHeuresSoum.Name = "lblTitreHeuresSoum";
            lblTitreHeuresSoum.Size = new System.Drawing.Size(119, 12);
            lblTitreHeuresSoum.TabIndex = 391;
            lblTitreHeuresSoum.Text = "Hrs";
            lblTitreHeuresSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreArgentSoum
            // 
            lblTitreArgentSoum.BackColor = System.Drawing.Color.White;
            lblTitreArgentSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreArgentSoum.ForeColor = System.Drawing.Color.Navy;
            lblTitreArgentSoum.Location = new System.Drawing.Point(326, 209);
            lblTitreArgentSoum.Name = "lblTitreArgentSoum";
            lblTitreArgentSoum.Size = new System.Drawing.Size(119, 12);
            lblTitreArgentSoum.TabIndex = 392;
            lblTitreArgentSoum.Text = "$";
            lblTitreArgentSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreHeuresProj
            // 
            lblTitreHeuresProj.BackColor = System.Drawing.Color.White;
            lblTitreHeuresProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreHeuresProj.ForeColor = System.Drawing.Color.Navy;
            lblTitreHeuresProj.Location = new System.Drawing.Point(444, 209);
            lblTitreHeuresProj.Name = "lblTitreHeuresProj";
            lblTitreHeuresProj.Size = new System.Drawing.Size(120, 13);
            lblTitreHeuresProj.TabIndex = 393;
            lblTitreHeuresProj.Text = "0.00";
            lblTitreHeuresProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreArgentProj
            // 
            lblTitreArgentProj.BackColor = System.Drawing.Color.White;
            lblTitreArgentProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreArgentProj.ForeColor = System.Drawing.Color.Navy;
            lblTitreArgentProj.Location = new System.Drawing.Point(562, 209);
            lblTitreArgentProj.Name = "lblTitreArgentProj";
            lblTitreArgentProj.Size = new System.Drawing.Size(119, 13);
            lblTitreArgentProj.TabIndex = 394;
            lblTitreArgentProj.Text = "0.00";
            lblTitreArgentProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreRevenus
            // 
            lblTitreRevenus.AutoSize = true;
            lblTitreRevenus.BackColor = System.Drawing.Color.White;
            lblTitreRevenus.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreRevenus.ForeColor = System.Drawing.Color.Navy;
            lblTitreRevenus.Location = new System.Drawing.Point(23, 133);
            lblTitreRevenus.Name = "lblTitreRevenus";
            lblTitreRevenus.Size = new System.Drawing.Size(44, 13);
            lblTitreRevenus.TabIndex = 395;
            lblTitreRevenus.Text = "Revenus";
            lblTitreRevenus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreForfaitElec
            // 
            lblTitreForfaitElec.AutoSize = true;
            lblTitreForfaitElec.BackColor = System.Drawing.Color.White;
            lblTitreForfaitElec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreForfaitElec.ForeColor = System.Drawing.Color.Navy;
            lblTitreForfaitElec.Location = new System.Drawing.Point(102, 137);
            lblTitreForfaitElec.Name = "lblTitreForfaitElec";
            lblTitreForfaitElec.Size = new System.Drawing.Size(83, 13);
            lblTitreForfaitElec.TabIndex = 396;
            lblTitreForfaitElec.Text = "Forfait électrique";
            lblTitreForfaitElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreForfaitMec
            // 
            lblTitreForfaitMec.AutoSize = true;
            lblTitreForfaitMec.BackColor = System.Drawing.Color.White;
            lblTitreForfaitMec.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreForfaitMec.ForeColor = System.Drawing.Color.Navy;
            lblTitreForfaitMec.Location = new System.Drawing.Point(102, 151);
            lblTitreForfaitMec.Name = "lblTitreForfaitMec";
            lblTitreForfaitMec.Size = new System.Drawing.Size(89, 13);
            lblTitreForfaitMec.TabIndex = 397;
            lblTitreForfaitMec.Text = "Forfait mécanique";
            lblTitreForfaitMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreTotalForfait
            // 
            lblTitreTotalForfait.AutoSize = true;
            lblTitreTotalForfait.BackColor = System.Drawing.Color.White;
            lblTitreTotalForfait.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTotalForfait.ForeColor = System.Drawing.Color.Navy;
            lblTitreTotalForfait.Location = new System.Drawing.Point(102, 169);
            lblTitreTotalForfait.Name = "lblTitreTotalForfait";
            lblTitreTotalForfait.Size = new System.Drawing.Size(29, 13);
            lblTitreTotalForfait.TabIndex = 398;
            lblTitreTotalForfait.Text = "Total";
            lblTitreTotalForfait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitreDepenses
            // 
            lblTitreDepenses.AutoSize = true;
            lblTitreDepenses.BackColor = System.Drawing.Color.White;
            lblTitreDepenses.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreDepenses.ForeColor = System.Drawing.Color.Navy;
            lblTitreDepenses.Location = new System.Drawing.Point(23, 195);
            lblTitreDepenses.Name = "lblTitreDepenses";
            lblTitreDepenses.Size = new System.Drawing.Size(49, 13);
            lblTitreDepenses.TabIndex = 399;
            lblTitreDepenses.Text = "Dépenses";
            lblTitreDepenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTempsElecDessin
            // 
            lblTitreTempsElecDessin.AutoSize = true;
            lblTitreTempsElecDessin.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecDessin.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecDessin.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecDessin.Location = new System.Drawing.Point(53, 222);
            lblTitreTempsElecDessin.Name = "lblTitreTempsElecDessin";
            lblTitreTempsElecDessin.Size = new System.Drawing.Size(35, 13);
            lblTitreTempsElecDessin.TabIndex = 401;
            lblTitreTempsElecDessin.Text = "Dessin";
            // 
            // lblTitreTempsElecFabrication
            // 
            lblTitreTempsElecFabrication.AutoSize = true;
            lblTitreTempsElecFabrication.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecFabrication.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecFabrication.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecFabrication.Location = new System.Drawing.Point(53, 240);
            lblTitreTempsElecFabrication.Name = "lblTitreTempsElecFabrication";
            lblTitreTempsElecFabrication.Size = new System.Drawing.Size(59, 13);
            lblTitreTempsElecFabrication.TabIndex = 402;
            lblTitreTempsElecFabrication.Text = "Fabrication";
            // 
            // lblTitreTempsElecAssemblage
            // 
            lblTitreTempsElecAssemblage.AutoSize = true;
            lblTitreTempsElecAssemblage.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecAssemblage.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecAssemblage.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecAssemblage.Location = new System.Drawing.Point(53, 256);
            lblTitreTempsElecAssemblage.Name = "lblTitreTempsElecAssemblage";
            lblTitreTempsElecAssemblage.Size = new System.Drawing.Size(60, 13);
            lblTitreTempsElecAssemblage.TabIndex = 403;
            lblTitreTempsElecAssemblage.Text = "Assemblage";
            // 
            // lblTitreTempsElecProgInterface
            // 
            lblTitreTempsElecProgInterface.AutoSize = true;
            lblTitreTempsElecProgInterface.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecProgInterface.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecProgInterface.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecProgInterface.Location = new System.Drawing.Point(52, 275);
            lblTitreTempsElecProgInterface.Name = "lblTitreTempsElecProgInterface";
            lblTitreTempsElecProgInterface.Size = new System.Drawing.Size(131, 13);
            lblTitreTempsElecProgInterface.TabIndex = 404;
            lblTitreTempsElecProgInterface.Text = "Programmation d\'interface";
            // 
            // lblTitreTempsElecProgAutomate
            // 
            lblTitreTempsElecProgAutomate.AutoSize = true;
            lblTitreTempsElecProgAutomate.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecProgAutomate.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecProgAutomate.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecProgAutomate.Location = new System.Drawing.Point(52, 293);
            lblTitreTempsElecProgAutomate.Name = "lblTitreTempsElecProgAutomate";
            lblTitreTempsElecProgAutomate.Size = new System.Drawing.Size(137, 13);
            lblTitreTempsElecProgAutomate.TabIndex = 405;
            lblTitreTempsElecProgAutomate.Text = "Programmation d\'automate";
            // 
            // lblTitreTempsElecProgRobot
            // 
            lblTitreTempsElecProgRobot.AutoSize = true;
            lblTitreTempsElecProgRobot.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecProgRobot.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecProgRobot.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecProgRobot.Location = new System.Drawing.Point(52, 311);
            lblTitreTempsElecProgRobot.Name = "lblTitreTempsElecProgRobot";
            lblTitreTempsElecProgRobot.Size = new System.Drawing.Size(122, 13);
            lblTitreTempsElecProgRobot.TabIndex = 406;
            lblTitreTempsElecProgRobot.Text = "Programmation de robot";
            // 
            // lblTitreTempsElecVision
            // 
            lblTitreTempsElecVision.AutoSize = true;
            lblTitreTempsElecVision.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecVision.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecVision.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecVision.Location = new System.Drawing.Point(53, 329);
            lblTitreTempsElecVision.Name = "lblTitreTempsElecVision";
            lblTitreTempsElecVision.Size = new System.Drawing.Size(33, 13);
            lblTitreTempsElecVision.TabIndex = 407;
            lblTitreTempsElecVision.Text = "Vision";
            // 
            // lblTitreTempsElecTest
            // 
            lblTitreTempsElecTest.AutoSize = true;
            lblTitreTempsElecTest.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecTest.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecTest.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecTest.Location = new System.Drawing.Point(53, 347);
            lblTitreTempsElecTest.Name = "lblTitreTempsElecTest";
            lblTitreTempsElecTest.Size = new System.Drawing.Size(24, 13);
            lblTitreTempsElecTest.TabIndex = 408;
            lblTitreTempsElecTest.Text = "Test";
            // 
            // lblTitreTempsElecInstallation
            // 
            lblTitreTempsElecInstallation.AutoSize = true;
            lblTitreTempsElecInstallation.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecInstallation.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecInstallation.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecInstallation.Location = new System.Drawing.Point(53, 366);
            lblTitreTempsElecInstallation.Name = "lblTitreTempsElecInstallation";
            lblTitreTempsElecInstallation.Size = new System.Drawing.Size(58, 13);
            lblTitreTempsElecInstallation.TabIndex = 409;
            lblTitreTempsElecInstallation.Text = "Installation";
            // 
            // lblTitreTempsElecMiseService
            // 
            lblTitreTempsElecMiseService.AutoSize = true;
            lblTitreTempsElecMiseService.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecMiseService.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecMiseService.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecMiseService.Location = new System.Drawing.Point(53, 384);
            lblTitreTempsElecMiseService.Name = "lblTitreTempsElecMiseService";
            lblTitreTempsElecMiseService.Size = new System.Drawing.Size(72, 13);
            lblTitreTempsElecMiseService.TabIndex = 410;
            lblTitreTempsElecMiseService.Text = "Mise en service";
            // 
            // lblTitreTempsElecFormation
            // 
            lblTitreTempsElecFormation.AutoSize = true;
            lblTitreTempsElecFormation.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecFormation.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecFormation.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecFormation.Location = new System.Drawing.Point(52, 402);
            lblTitreTempsElecFormation.Name = "lblTitreTempsElecFormation";
            lblTitreTempsElecFormation.Size = new System.Drawing.Size(115, 13);
            lblTitreTempsElecFormation.TabIndex = 411;
            lblTitreTempsElecFormation.Text = "Formation du personnel";
            // 
            // lblTitreTempsElecGestion
            // 
            lblTitreTempsElecGestion.AutoSize = true;
            lblTitreTempsElecGestion.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecGestion.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecGestion.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecGestion.Location = new System.Drawing.Point(53, 420);
            lblTitreTempsElecGestion.Name = "lblTitreTempsElecGestion";
            lblTitreTempsElecGestion.Size = new System.Drawing.Size(85, 13);
            lblTitreTempsElecGestion.TabIndex = 412;
            lblTitreTempsElecGestion.Text = "Gestion du projet";
            // 
            // lblTitreTempsElecShipping
            // 
            lblTitreTempsElecShipping.AutoSize = true;
            lblTitreTempsElecShipping.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecShipping.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecShipping.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecShipping.Location = new System.Drawing.Point(53, 438);
            lblTitreTempsElecShipping.Name = "lblTitreTempsElecShipping";
            lblTitreTempsElecShipping.Size = new System.Drawing.Size(54, 13);
            lblTitreTempsElecShipping.TabIndex = 413;
            lblTitreTempsElecShipping.Text = "Expédition";
            // 
            // lblTitreTempsElecTotal
            // 
            lblTitreTempsElecTotal.AutoSize = true;
            lblTitreTempsElecTotal.BackColor = System.Drawing.Color.White;
            lblTitreTempsElecTotal.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTempsElecTotal.ForeColor = System.Drawing.Color.Navy;
            lblTitreTempsElecTotal.Location = new System.Drawing.Point(53, 473);
            lblTitreTempsElecTotal.Name = "lblTitreTempsElecTotal";
            lblTitreTempsElecTotal.Size = new System.Drawing.Size(76, 13);
            lblTitreTempsElecTotal.TabIndex = 414;
            lblTitreTempsElecTotal.Text = "Total des temps";
            // 
            // lblHeuresElecTotalProj0
            // 
            lblHeuresElecTotalProj0.BackColor = System.Drawing.Color.White;
            lblHeuresElecTotalProj0.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecTotalProj0.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecTotalProj0.Location = new System.Drawing.Point(446, 550);
            lblHeuresElecTotalProj0.Name = "lblHeuresElecTotalProj0";
            lblHeuresElecTotalProj0.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecTotalProj0.TabIndex = 415;
            lblHeuresElecTotalProj0.Text = "0.00";
            // 
            // lblDate
            // 
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDate.ForeColor = System.Drawing.Color.Navy;
            lblDate.Location = new System.Drawing.Point(212, 117);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(99, 17);
            lblDate.TabIndex = 416;
            lblDate.Text = "lblDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Navy;
            label5.Location = new System.Drawing.Point(53, 455);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 13);
            label5.TabIndex = 419;
            label5.Text = "Dev. Expérimental";
            // 
            // lblHeuresElecProgInterfaceSoum
            // 
            lblHeuresElecProgInterfaceSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecProgInterfaceSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecProgInterfaceSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecProgInterfaceSoum.Location = new System.Drawing.Point(210, 274);
            lblHeuresElecProgInterfaceSoum.Name = "lblHeuresElecProgInterfaceSoum";
            lblHeuresElecProgInterfaceSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecProgInterfaceSoum.TabIndex = 423;
            lblHeuresElecProgInterfaceSoum.Text = "0.00";
            // 
            // lblArgentElecProgAutomateSoum
            // 
            lblArgentElecProgAutomateSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecProgAutomateSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecProgAutomateSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecProgAutomateSoum.Location = new System.Drawing.Point(327, 292);
            lblArgentElecProgAutomateSoum.Name = "lblArgentElecProgAutomateSoum";
            lblArgentElecProgAutomateSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecProgAutomateSoum.TabIndex = 424;
            lblArgentElecProgAutomateSoum.Text = "0.00";
            // 
            // lblHeuresElecProgAutomateSoum
            // 
            lblHeuresElecProgAutomateSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecProgAutomateSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecProgAutomateSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecProgAutomateSoum.Location = new System.Drawing.Point(210, 292);
            lblHeuresElecProgAutomateSoum.Name = "lblHeuresElecProgAutomateSoum";
            lblHeuresElecProgAutomateSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecProgAutomateSoum.TabIndex = 425;
            lblHeuresElecProgAutomateSoum.Text = "0.00";
            // 
            // lblArgentElecProgRobotSoum
            // 
            lblArgentElecProgRobotSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecProgRobotSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecProgRobotSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecProgRobotSoum.Location = new System.Drawing.Point(327, 310);
            lblArgentElecProgRobotSoum.Name = "lblArgentElecProgRobotSoum";
            lblArgentElecProgRobotSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecProgRobotSoum.TabIndex = 426;
            lblArgentElecProgRobotSoum.Text = "0.00";
            // 
            // lblHeuresElecProgRobotSoum
            // 
            lblHeuresElecProgRobotSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecProgRobotSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecProgRobotSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecProgRobotSoum.Location = new System.Drawing.Point(210, 310);
            lblHeuresElecProgRobotSoum.Name = "lblHeuresElecProgRobotSoum";
            lblHeuresElecProgRobotSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecProgRobotSoum.TabIndex = 427;
            lblHeuresElecProgRobotSoum.Text = "0.00";
            // 
            // lblHeuresElecVisionSoum
            // 
            lblHeuresElecVisionSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecVisionSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecVisionSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecVisionSoum.Location = new System.Drawing.Point(210, 328);
            lblHeuresElecVisionSoum.Name = "lblHeuresElecVisionSoum";
            lblHeuresElecVisionSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecVisionSoum.TabIndex = 428;
            lblHeuresElecVisionSoum.Text = "0.00";
            // 
            // lblArgentElecTestSoum
            // 
            lblArgentElecTestSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecTestSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecTestSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecTestSoum.Location = new System.Drawing.Point(327, 347);
            lblArgentElecTestSoum.Name = "lblArgentElecTestSoum";
            lblArgentElecTestSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecTestSoum.TabIndex = 429;
            lblArgentElecTestSoum.Text = "0.00";
            // 
            // lblArgentElecInstallationSoum
            // 
            lblArgentElecInstallationSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecInstallationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecInstallationSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecInstallationSoum.Location = new System.Drawing.Point(327, 365);
            lblArgentElecInstallationSoum.Name = "lblArgentElecInstallationSoum";
            lblArgentElecInstallationSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecInstallationSoum.TabIndex = 430;
            lblArgentElecInstallationSoum.Text = "0.00";
            // 
            // lblHeuresElecInstallationSoum
            // 
            lblHeuresElecInstallationSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecInstallationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecInstallationSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecInstallationSoum.Location = new System.Drawing.Point(210, 365);
            lblHeuresElecInstallationSoum.Name = "lblHeuresElecInstallationSoum";
            lblHeuresElecInstallationSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecInstallationSoum.TabIndex = 431;
            lblHeuresElecInstallationSoum.Text = "0.00";
            // 
            // lblHeuresElecMiseServiceSoum
            // 
            lblHeuresElecMiseServiceSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecMiseServiceSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecMiseServiceSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecMiseServiceSoum.Location = new System.Drawing.Point(210, 383);
            lblHeuresElecMiseServiceSoum.Name = "lblHeuresElecMiseServiceSoum";
            lblHeuresElecMiseServiceSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecMiseServiceSoum.TabIndex = 432;
            lblHeuresElecMiseServiceSoum.Text = "0.00";
            // 
            // lblArgentElecMiseServiceSoum
            // 
            lblArgentElecMiseServiceSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecMiseServiceSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecMiseServiceSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecMiseServiceSoum.Location = new System.Drawing.Point(327, 383);
            lblArgentElecMiseServiceSoum.Name = "lblArgentElecMiseServiceSoum";
            lblArgentElecMiseServiceSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecMiseServiceSoum.TabIndex = 433;
            lblArgentElecMiseServiceSoum.Text = "0.00";
            // 
            // lblHeuresElecFormationSoum
            // 
            lblHeuresElecFormationSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecFormationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecFormationSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecFormationSoum.Location = new System.Drawing.Point(210, 401);
            lblHeuresElecFormationSoum.Name = "lblHeuresElecFormationSoum";
            lblHeuresElecFormationSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecFormationSoum.TabIndex = 434;
            lblHeuresElecFormationSoum.Text = "0.00";
            // 
            // lblArgentElecFormationSoum
            // 
            lblArgentElecFormationSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecFormationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecFormationSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecFormationSoum.Location = new System.Drawing.Point(327, 401);
            lblArgentElecFormationSoum.Name = "lblArgentElecFormationSoum";
            lblArgentElecFormationSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecFormationSoum.TabIndex = 435;
            lblArgentElecFormationSoum.Text = "0.00";
            // 
            // lblHeuresElecGestionSoum
            // 
            lblHeuresElecGestionSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecGestionSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecGestionSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecGestionSoum.Location = new System.Drawing.Point(210, 419);
            lblHeuresElecGestionSoum.Name = "lblHeuresElecGestionSoum";
            lblHeuresElecGestionSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecGestionSoum.TabIndex = 436;
            lblHeuresElecGestionSoum.Text = "0.00";
            // 
            // lblArgentElecGestionSoum
            // 
            lblArgentElecGestionSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecGestionSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecGestionSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecGestionSoum.Location = new System.Drawing.Point(327, 419);
            lblArgentElecGestionSoum.Name = "lblArgentElecGestionSoum";
            lblArgentElecGestionSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecGestionSoum.TabIndex = 437;
            lblArgentElecGestionSoum.Text = "0.00";
            // 
            // lblHeuresElecShippingSoum
            // 
            lblHeuresElecShippingSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecShippingSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecShippingSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecShippingSoum.Location = new System.Drawing.Point(210, 438);
            lblHeuresElecShippingSoum.Name = "lblHeuresElecShippingSoum";
            lblHeuresElecShippingSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecShippingSoum.TabIndex = 438;
            lblHeuresElecShippingSoum.Text = "0.00";
            // 
            // lblArgentElecShippingSoum
            // 
            lblArgentElecShippingSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecShippingSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecShippingSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecShippingSoum.Location = new System.Drawing.Point(327, 438);
            lblArgentElecShippingSoum.Name = "lblArgentElecShippingSoum";
            lblArgentElecShippingSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecShippingSoum.TabIndex = 439;
            lblArgentElecShippingSoum.Text = "0.00";
            // 
            // lblPiecesElecSoum
            // 
            lblPiecesElecSoum.BackColor = System.Drawing.Color.White;
            lblPiecesElecSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPiecesElecSoum.ForeColor = System.Drawing.Color.Navy;
            lblPiecesElecSoum.Location = new System.Drawing.Point(328, 493);
            lblPiecesElecSoum.Name = "lblPiecesElecSoum";
            lblPiecesElecSoum.Size = new System.Drawing.Size(118, 14);
            lblPiecesElecSoum.TabIndex = 440;
            lblPiecesElecSoum.Text = "0.00";
            // 
            // lblImprevuElecSoum
            // 
            lblImprevuElecSoum.BackColor = System.Drawing.Color.White;
            lblImprevuElecSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImprevuElecSoum.ForeColor = System.Drawing.Color.Navy;
            lblImprevuElecSoum.Location = new System.Drawing.Point(328, 511);
            lblImprevuElecSoum.Name = "lblImprevuElecSoum";
            lblImprevuElecSoum.Size = new System.Drawing.Size(118, 14);
            lblImprevuElecSoum.TabIndex = 441;
            lblImprevuElecSoum.Text = "0.00";
            // 
            // lblAutresElecSoum
            // 
            lblAutresElecSoum.BackColor = System.Drawing.Color.White;
            lblAutresElecSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAutresElecSoum.ForeColor = System.Drawing.Color.Navy;
            lblAutresElecSoum.Location = new System.Drawing.Point(328, 530);
            lblAutresElecSoum.Name = "lblAutresElecSoum";
            lblAutresElecSoum.Size = new System.Drawing.Size(118, 14);
            lblAutresElecSoum.TabIndex = 442;
            lblAutresElecSoum.Text = "0.00";
            // 
            // lblArgentElecAssemblageProj
            // 
            lblArgentElecAssemblageProj.BackColor = System.Drawing.Color.White;
            lblArgentElecAssemblageProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecAssemblageProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecAssemblageProj.Location = new System.Drawing.Point(563, 256);
            lblArgentElecAssemblageProj.Name = "lblArgentElecAssemblageProj";
            lblArgentElecAssemblageProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecAssemblageProj.TabIndex = 443;
            lblArgentElecAssemblageProj.Text = "0.00";
            // 
            // lblArgentElecRechercheProj
            // 
            lblArgentElecRechercheProj.BackColor = System.Drawing.Color.White;
            lblArgentElecRechercheProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecRechercheProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecRechercheProj.Location = new System.Drawing.Point(563, 454);
            lblArgentElecRechercheProj.Name = "lblArgentElecRechercheProj";
            lblArgentElecRechercheProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecRechercheProj.TabIndex = 444;
            lblArgentElecRechercheProj.Text = "0.00";
            // 
            // lblImprevuElecProj
            // 
            lblImprevuElecProj.BackColor = System.Drawing.Color.White;
            lblImprevuElecProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImprevuElecProj.ForeColor = System.Drawing.Color.Navy;
            lblImprevuElecProj.Location = new System.Drawing.Point(565, 512);
            lblImprevuElecProj.Name = "lblImprevuElecProj";
            lblImprevuElecProj.Size = new System.Drawing.Size(118, 14);
            lblImprevuElecProj.TabIndex = 445;
            lblImprevuElecProj.Text = "0.00";
            // 
            // lblPiecesElecProj
            // 
            lblPiecesElecProj.BackColor = System.Drawing.Color.White;
            lblPiecesElecProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPiecesElecProj.ForeColor = System.Drawing.Color.Navy;
            lblPiecesElecProj.Location = new System.Drawing.Point(565, 493);
            lblPiecesElecProj.Name = "lblPiecesElecProj";
            lblPiecesElecProj.Size = new System.Drawing.Size(118, 14);
            lblPiecesElecProj.TabIndex = 446;
            lblPiecesElecProj.Text = "0.00";
            // 
            // lblAutresElecProj
            // 
            lblAutresElecProj.BackColor = System.Drawing.Color.White;
            lblAutresElecProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAutresElecProj.ForeColor = System.Drawing.Color.Navy;
            lblAutresElecProj.Location = new System.Drawing.Point(565, 531);
            lblAutresElecProj.Name = "lblAutresElecProj";
            lblAutresElecProj.Size = new System.Drawing.Size(118, 14);
            lblAutresElecProj.TabIndex = 447;
            lblAutresElecProj.Text = "0.00";
            // 
            // lblArgentElecTotalSoum
            // 
            lblArgentElecTotalSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecTotalSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecTotalSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecTotalSoum.Location = new System.Drawing.Point(327, 473);
            lblArgentElecTotalSoum.Name = "lblArgentElecTotalSoum";
            lblArgentElecTotalSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecTotalSoum.TabIndex = 448;
            lblArgentElecTotalSoum.Text = "0.00";
            // 
            // lblArgentElecTotalProj
            // 
            lblArgentElecTotalProj.BackColor = System.Drawing.Color.White;
            lblArgentElecTotalProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecTotalProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecTotalProj.Location = new System.Drawing.Point(565, 550);
            lblArgentElecTotalProj.Name = "lblArgentElecTotalProj";
            lblArgentElecTotalProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecTotalProj.TabIndex = 449;
            lblArgentElecTotalProj.Text = "0.00";
            // 
            // lblHeuresMecDessinSoum
            // 
            lblHeuresMecDessinSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecDessinSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecDessinSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecDessinSoum.Location = new System.Drawing.Point(212, 576);
            lblHeuresMecDessinSoum.Name = "lblHeuresMecDessinSoum";
            lblHeuresMecDessinSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecDessinSoum.TabIndex = 450;
            lblHeuresMecDessinSoum.Text = "0.00";
            // 
            // lblArgentMecDessinSoum
            // 
            lblArgentMecDessinSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecDessinSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecDessinSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecDessinSoum.Location = new System.Drawing.Point(328, 576);
            lblArgentMecDessinSoum.Name = "lblArgentMecDessinSoum";
            lblArgentMecDessinSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecDessinSoum.TabIndex = 451;
            lblArgentMecDessinSoum.Text = "0.00";
            // 
            // lblHeuresMecCoupeSoum
            // 
            lblHeuresMecCoupeSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecCoupeSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecCoupeSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecCoupeSoum.Location = new System.Drawing.Point(212, 594);
            lblHeuresMecCoupeSoum.Name = "lblHeuresMecCoupeSoum";
            lblHeuresMecCoupeSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecCoupeSoum.TabIndex = 452;
            lblHeuresMecCoupeSoum.Text = "0.00";
            // 
            // lblArgentMecCoupeSoum
            // 
            lblArgentMecCoupeSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecCoupeSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecCoupeSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecCoupeSoum.Location = new System.Drawing.Point(328, 594);
            lblArgentMecCoupeSoum.Name = "lblArgentMecCoupeSoum";
            lblArgentMecCoupeSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecCoupeSoum.TabIndex = 453;
            lblArgentMecCoupeSoum.Text = "0.00";
            // 
            // lblHeuresMecMachinageSoum
            // 
            lblHeuresMecMachinageSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecMachinageSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecMachinageSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecMachinageSoum.Location = new System.Drawing.Point(212, 613);
            lblHeuresMecMachinageSoum.Name = "lblHeuresMecMachinageSoum";
            lblHeuresMecMachinageSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecMachinageSoum.TabIndex = 454;
            lblHeuresMecMachinageSoum.Text = "0.00";
            // 
            // lblArgentMecMachinageSoum
            // 
            lblArgentMecMachinageSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecMachinageSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecMachinageSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecMachinageSoum.Location = new System.Drawing.Point(328, 613);
            lblArgentMecMachinageSoum.Name = "lblArgentMecMachinageSoum";
            lblArgentMecMachinageSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecMachinageSoum.TabIndex = 455;
            lblArgentMecMachinageSoum.Text = "0.00";
            // 
            // lblHeuresMecSoudureSoum
            // 
            lblHeuresMecSoudureSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecSoudureSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecSoudureSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecSoudureSoum.Location = new System.Drawing.Point(212, 631);
            lblHeuresMecSoudureSoum.Name = "lblHeuresMecSoudureSoum";
            lblHeuresMecSoudureSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecSoudureSoum.TabIndex = 456;
            lblHeuresMecSoudureSoum.Text = "0.00";
            // 
            // lblArgentMecSoudureSoum
            // 
            lblArgentMecSoudureSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecSoudureSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecSoudureSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecSoudureSoum.Location = new System.Drawing.Point(328, 631);
            lblArgentMecSoudureSoum.Name = "lblArgentMecSoudureSoum";
            lblArgentMecSoudureSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecSoudureSoum.TabIndex = 457;
            lblArgentMecSoudureSoum.Text = "0.00";
            // 
            // lblHeuresMecAssemblageSoum
            // 
            lblHeuresMecAssemblageSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecAssemblageSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecAssemblageSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecAssemblageSoum.Location = new System.Drawing.Point(212, 649);
            lblHeuresMecAssemblageSoum.Name = "lblHeuresMecAssemblageSoum";
            lblHeuresMecAssemblageSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecAssemblageSoum.TabIndex = 458;
            lblHeuresMecAssemblageSoum.Text = "0.00";
            // 
            // lblArgentMecAssemblageSoum
            // 
            lblArgentMecAssemblageSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecAssemblageSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecAssemblageSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecAssemblageSoum.Location = new System.Drawing.Point(328, 649);
            lblArgentMecAssemblageSoum.Name = "lblArgentMecAssemblageSoum";
            lblArgentMecAssemblageSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecAssemblageSoum.TabIndex = 459;
            lblArgentMecAssemblageSoum.Text = "0.00";
            // 
            // lblHeuresMecPeintureSoum
            // 
            lblHeuresMecPeintureSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecPeintureSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecPeintureSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecPeintureSoum.Location = new System.Drawing.Point(212, 668);
            lblHeuresMecPeintureSoum.Name = "lblHeuresMecPeintureSoum";
            lblHeuresMecPeintureSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecPeintureSoum.TabIndex = 460;
            lblHeuresMecPeintureSoum.Text = "0.00";
            // 
            // lblArgentMecPeintureSoum
            // 
            lblArgentMecPeintureSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecPeintureSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecPeintureSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecPeintureSoum.Location = new System.Drawing.Point(328, 668);
            lblArgentMecPeintureSoum.Name = "lblArgentMecPeintureSoum";
            lblArgentMecPeintureSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecPeintureSoum.TabIndex = 461;
            lblArgentMecPeintureSoum.Text = "0.00";
            // 
            // lblHeuresMecTestSoum
            // 
            lblHeuresMecTestSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecTestSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecTestSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecTestSoum.Location = new System.Drawing.Point(212, 686);
            lblHeuresMecTestSoum.Name = "lblHeuresMecTestSoum";
            lblHeuresMecTestSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecTestSoum.TabIndex = 462;
            lblHeuresMecTestSoum.Text = "0.00";
            // 
            // lblAutresMecProj
            // 
            lblAutresMecProj.BackColor = System.Drawing.Color.White;
            lblAutresMecProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAutresMecProj.ForeColor = System.Drawing.Color.Navy;
            lblAutresMecProj.Location = new System.Drawing.Point(565, 853);
            lblAutresMecProj.Name = "lblAutresMecProj";
            lblAutresMecProj.Size = new System.Drawing.Size(118, 14);
            lblAutresMecProj.TabIndex = 463;
            lblAutresMecProj.Text = "0.00";
            // 
            // lblTitreProfitTotal
            // 
            lblTitreProfitTotal.AutoSize = true;
            lblTitreProfitTotal.BackColor = System.Drawing.Color.White;
            lblTitreProfitTotal.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProfitTotal.ForeColor = System.Drawing.Color.Navy;
            lblTitreProfitTotal.Location = new System.Drawing.Point(53, 910);
            lblTitreProfitTotal.Name = "lblTitreProfitTotal";
            lblTitreProfitTotal.Size = new System.Drawing.Size(57, 13);
            lblTitreProfitTotal.TabIndex = 464;
            lblTitreProfitTotal.Text = "Profit total";
            lblTitreProfitTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArgentElecDessinSoum
            // 
            lblArgentElecDessinSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecDessinSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecDessinSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecDessinSoum.Location = new System.Drawing.Point(327, 222);
            lblArgentElecDessinSoum.Name = "lblArgentElecDessinSoum";
            lblArgentElecDessinSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecDessinSoum.TabIndex = 466;
            lblArgentElecDessinSoum.Text = "0.00";
            // 
            // lblHeuresElecDessinSoum
            // 
            lblHeuresElecDessinSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecDessinSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecDessinSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecDessinSoum.Location = new System.Drawing.Point(210, 222);
            lblHeuresElecDessinSoum.Name = "lblHeuresElecDessinSoum";
            lblHeuresElecDessinSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecDessinSoum.TabIndex = 467;
            lblHeuresElecDessinSoum.Text = "0.00";
            // 
            // lblArgentElecFabricationSoum
            // 
            lblArgentElecFabricationSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecFabricationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecFabricationSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecFabricationSoum.Location = new System.Drawing.Point(327, 239);
            lblArgentElecFabricationSoum.Name = "lblArgentElecFabricationSoum";
            lblArgentElecFabricationSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecFabricationSoum.TabIndex = 468;
            lblArgentElecFabricationSoum.Text = "0.00";
            // 
            // lblHeuresElecFabricationSoum
            // 
            lblHeuresElecFabricationSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecFabricationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecFabricationSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecFabricationSoum.Location = new System.Drawing.Point(210, 239);
            lblHeuresElecFabricationSoum.Name = "lblHeuresElecFabricationSoum";
            lblHeuresElecFabricationSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecFabricationSoum.TabIndex = 469;
            lblHeuresElecFabricationSoum.Text = "0.00";
            // 
            // lblArgentElecAssemblageSoum
            // 
            lblArgentElecAssemblageSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecAssemblageSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecAssemblageSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecAssemblageSoum.Location = new System.Drawing.Point(327, 256);
            lblArgentElecAssemblageSoum.Name = "lblArgentElecAssemblageSoum";
            lblArgentElecAssemblageSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecAssemblageSoum.TabIndex = 470;
            lblArgentElecAssemblageSoum.Text = "0.00";
            // 
            // lblHeuresElecAssemblageSoum
            // 
            lblHeuresElecAssemblageSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecAssemblageSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecAssemblageSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecAssemblageSoum.Location = new System.Drawing.Point(210, 256);
            lblHeuresElecAssemblageSoum.Name = "lblHeuresElecAssemblageSoum";
            lblHeuresElecAssemblageSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecAssemblageSoum.TabIndex = 471;
            lblHeuresElecAssemblageSoum.Text = "0.00";
            // 
            // lblArgentElecProgInterfaceSoum
            // 
            lblArgentElecProgInterfaceSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecProgInterfaceSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecProgInterfaceSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecProgInterfaceSoum.Location = new System.Drawing.Point(327, 274);
            lblArgentElecProgInterfaceSoum.Name = "lblArgentElecProgInterfaceSoum";
            lblArgentElecProgInterfaceSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecProgInterfaceSoum.TabIndex = 472;
            lblArgentElecProgInterfaceSoum.Text = "0.00";
            // 
            // lblArgentElecVisionSoum
            // 
            lblArgentElecVisionSoum.BackColor = System.Drawing.Color.White;
            lblArgentElecVisionSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecVisionSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecVisionSoum.Location = new System.Drawing.Point(327, 328);
            lblArgentElecVisionSoum.Name = "lblArgentElecVisionSoum";
            lblArgentElecVisionSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentElecVisionSoum.TabIndex = 473;
            lblArgentElecVisionSoum.Text = "0.00";
            // 
            // lblHeuresElecTestSoum
            // 
            lblHeuresElecTestSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecTestSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecTestSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecTestSoum.Location = new System.Drawing.Point(210, 347);
            lblHeuresElecTestSoum.Name = "lblHeuresElecTestSoum";
            lblHeuresElecTestSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecTestSoum.TabIndex = 474;
            lblHeuresElecTestSoum.Text = "0.00";
            // 
            // lblHeuresElecMiseServiceProj
            // 
            lblHeuresElecMiseServiceProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecMiseServiceProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecMiseServiceProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecMiseServiceProj.Location = new System.Drawing.Point(446, 383);
            lblHeuresElecMiseServiceProj.Name = "lblHeuresElecMiseServiceProj";
            lblHeuresElecMiseServiceProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecMiseServiceProj.TabIndex = 475;
            lblHeuresElecMiseServiceProj.Text = "0.00";
            // 
            // lblArgentElecMiseServiceProj
            // 
            lblArgentElecMiseServiceProj.BackColor = System.Drawing.Color.White;
            lblArgentElecMiseServiceProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecMiseServiceProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecMiseServiceProj.Location = new System.Drawing.Point(563, 384);
            lblArgentElecMiseServiceProj.Name = "lblArgentElecMiseServiceProj";
            lblArgentElecMiseServiceProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecMiseServiceProj.TabIndex = 476;
            lblArgentElecMiseServiceProj.Text = "0.00";
            // 
            // lblHeuresElecFormationProj
            // 
            lblHeuresElecFormationProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecFormationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecFormationProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecFormationProj.Location = new System.Drawing.Point(446, 401);
            lblHeuresElecFormationProj.Name = "lblHeuresElecFormationProj";
            lblHeuresElecFormationProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecFormationProj.TabIndex = 477;
            lblHeuresElecFormationProj.Text = "0.00";
            // 
            // lblArgentElecFormationProj
            // 
            lblArgentElecFormationProj.BackColor = System.Drawing.Color.White;
            lblArgentElecFormationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecFormationProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecFormationProj.Location = new System.Drawing.Point(563, 402);
            lblArgentElecFormationProj.Name = "lblArgentElecFormationProj";
            lblArgentElecFormationProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecFormationProj.TabIndex = 478;
            lblArgentElecFormationProj.Text = "0.00";
            // 
            // lblHeuresElecGestionProj
            // 
            lblHeuresElecGestionProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecGestionProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecGestionProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecGestionProj.Location = new System.Drawing.Point(446, 419);
            lblHeuresElecGestionProj.Name = "lblHeuresElecGestionProj";
            lblHeuresElecGestionProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecGestionProj.TabIndex = 479;
            lblHeuresElecGestionProj.Text = "0.00";
            // 
            // lblTotalForfaitProj
            // 
            lblTotalForfaitProj.BackColor = System.Drawing.Color.White;
            lblTotalForfaitProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalForfaitProj.ForeColor = System.Drawing.Color.Navy;
            lblTotalForfaitProj.Location = new System.Drawing.Point(528, 170);
            lblTotalForfaitProj.Name = "lblTotalForfaitProj";
            lblTotalForfaitProj.Size = new System.Drawing.Size(118, 14);
            lblTotalForfaitProj.TabIndex = 480;
            lblTotalForfaitProj.Text = "lblTotalForfaitProj";
            // 
            // lblHeuresElecTotalProj
            // 
            lblHeuresElecTotalProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecTotalProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecTotalProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecTotalProj.Location = new System.Drawing.Point(446, 472);
            lblHeuresElecTotalProj.Name = "lblHeuresElecTotalProj";
            lblHeuresElecTotalProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecTotalProj.TabIndex = 482;
            lblHeuresElecTotalProj.Text = "0.00";
            // 
            // lblHeuresMecTotalProj
            // 
            lblHeuresMecTotalProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecTotalProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecTotalProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecTotalProj.Location = new System.Drawing.Point(446, 795);
            lblHeuresMecTotalProj.Name = "lblHeuresMecTotalProj";
            lblHeuresMecTotalProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecTotalProj.TabIndex = 483;
            lblHeuresMecTotalProj.Text = "0.00";
            // 
            // lblGrandTotalProj
            // 
            lblGrandTotalProj.BackColor = System.Drawing.Color.White;
            lblGrandTotalProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGrandTotalProj.ForeColor = System.Drawing.Color.Navy;
            lblGrandTotalProj.Location = new System.Drawing.Point(565, 890);
            lblGrandTotalProj.Name = "lblGrandTotalProj";
            lblGrandTotalProj.Size = new System.Drawing.Size(118, 14);
            lblGrandTotalProj.TabIndex = 484;
            lblGrandTotalProj.Text = "0.00";
            // 
            // lblTotalMecProj
            // 
            lblTotalMecProj.BackColor = System.Drawing.Color.White;
            lblTotalMecProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalMecProj.ForeColor = System.Drawing.Color.Navy;
            lblTotalMecProj.Location = new System.Drawing.Point(565, 872);
            lblTotalMecProj.Name = "lblTotalMecProj";
            lblTotalMecProj.Size = new System.Drawing.Size(118, 14);
            lblTotalMecProj.TabIndex = 486;
            lblTotalMecProj.Text = "0.00";
            // 
            // lblProfitSoum
            // 
            lblProfitSoum.BackColor = System.Drawing.Color.White;
            lblProfitSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProfitSoum.ForeColor = System.Drawing.Color.Navy;
            lblProfitSoum.Location = new System.Drawing.Point(328, 909);
            lblProfitSoum.Name = "lblProfitSoum";
            lblProfitSoum.Size = new System.Drawing.Size(118, 14);
            lblProfitSoum.TabIndex = 487;
            lblProfitSoum.Text = "0.00";
            // 
            // lblProfitProj
            // 
            lblProfitProj.BackColor = System.Drawing.Color.White;
            lblProfitProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProfitProj.ForeColor = System.Drawing.Color.Navy;
            lblProfitProj.Location = new System.Drawing.Point(565, 909);
            lblProfitProj.Name = "lblProfitProj";
            lblProfitProj.Size = new System.Drawing.Size(118, 14);
            lblProfitProj.TabIndex = 488;
            lblProfitProj.Text = "0.00";
            // 
            // lblArgentElecVisionProj
            // 
            lblArgentElecVisionProj.BackColor = System.Drawing.Color.White;
            lblArgentElecVisionProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecVisionProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecVisionProj.Location = new System.Drawing.Point(563, 329);
            lblArgentElecVisionProj.Name = "lblArgentElecVisionProj";
            lblArgentElecVisionProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecVisionProj.TabIndex = 489;
            lblArgentElecVisionProj.Text = "0.00";
            // 
            // lblHeuresElecTestProj
            // 
            lblHeuresElecTestProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecTestProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecTestProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecTestProj.Location = new System.Drawing.Point(446, 347);
            lblHeuresElecTestProj.Name = "lblHeuresElecTestProj";
            lblHeuresElecTestProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecTestProj.TabIndex = 490;
            lblHeuresElecTestProj.Text = "0.00";
            // 
            // lblArgentElecTestProj
            // 
            lblArgentElecTestProj.BackColor = System.Drawing.Color.White;
            lblArgentElecTestProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecTestProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecTestProj.Location = new System.Drawing.Point(563, 348);
            lblArgentElecTestProj.Name = "lblArgentElecTestProj";
            lblArgentElecTestProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecTestProj.TabIndex = 491;
            lblArgentElecTestProj.Text = "0.00";
            // 
            // lblArgentMecTestSoum
            // 
            lblArgentMecTestSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecTestSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecTestSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecTestSoum.Location = new System.Drawing.Point(328, 686);
            lblArgentMecTestSoum.Name = "lblArgentMecTestSoum";
            lblArgentMecTestSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecTestSoum.TabIndex = 492;
            lblArgentMecTestSoum.Text = "0.00";
            // 
            // lblHeuresMecInstallationSoum
            // 
            lblHeuresMecInstallationSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecInstallationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecInstallationSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecInstallationSoum.Location = new System.Drawing.Point(212, 704);
            lblHeuresMecInstallationSoum.Name = "lblHeuresMecInstallationSoum";
            lblHeuresMecInstallationSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecInstallationSoum.TabIndex = 493;
            lblHeuresMecInstallationSoum.Text = "0.00";
            // 
            // lblArgentMecInstallationSoum
            // 
            lblArgentMecInstallationSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecInstallationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecInstallationSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecInstallationSoum.Location = new System.Drawing.Point(328, 704);
            lblArgentMecInstallationSoum.Name = "lblArgentMecInstallationSoum";
            lblArgentMecInstallationSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecInstallationSoum.TabIndex = 494;
            lblArgentMecInstallationSoum.Text = "0.00";
            // 
            // lblHeuresMecFormationSoum
            // 
            lblHeuresMecFormationSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecFormationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecFormationSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecFormationSoum.Location = new System.Drawing.Point(212, 722);
            lblHeuresMecFormationSoum.Name = "lblHeuresMecFormationSoum";
            lblHeuresMecFormationSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecFormationSoum.TabIndex = 495;
            lblHeuresMecFormationSoum.Text = "0.00";
            // 
            // lblArgentMecFormationSoum
            // 
            lblArgentMecFormationSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecFormationSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecFormationSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecFormationSoum.Location = new System.Drawing.Point(328, 722);
            lblArgentMecFormationSoum.Name = "lblArgentMecFormationSoum";
            lblArgentMecFormationSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecFormationSoum.TabIndex = 496;
            lblArgentMecFormationSoum.Text = "0.00";
            // 
            // lblHeuresMecGestionSoum
            // 
            lblHeuresMecGestionSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecGestionSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecGestionSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecGestionSoum.Location = new System.Drawing.Point(212, 740);
            lblHeuresMecGestionSoum.Name = "lblHeuresMecGestionSoum";
            lblHeuresMecGestionSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecGestionSoum.TabIndex = 497;
            lblHeuresMecGestionSoum.Text = "0.00";
            // 
            // lblArgentMecGestionSoum
            // 
            lblArgentMecGestionSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecGestionSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecGestionSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecGestionSoum.Location = new System.Drawing.Point(328, 740);
            lblArgentMecGestionSoum.Name = "lblArgentMecGestionSoum";
            lblArgentMecGestionSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecGestionSoum.TabIndex = 498;
            lblArgentMecGestionSoum.Text = "0.00";
            // 
            // lblHeuresMecShippingSoum
            // 
            lblHeuresMecShippingSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecShippingSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecShippingSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecShippingSoum.Location = new System.Drawing.Point(212, 758);
            lblHeuresMecShippingSoum.Name = "lblHeuresMecShippingSoum";
            lblHeuresMecShippingSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecShippingSoum.TabIndex = 499;
            lblHeuresMecShippingSoum.Text = "0.00";
            // 
            // lblArgentMecShippingSoum
            // 
            lblArgentMecShippingSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecShippingSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecShippingSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecShippingSoum.Location = new System.Drawing.Point(328, 758);
            lblArgentMecShippingSoum.Name = "lblArgentMecShippingSoum";
            lblArgentMecShippingSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecShippingSoum.TabIndex = 500;
            lblArgentMecShippingSoum.Text = "0.00";
            // 
            // lblHeuresMecFormationProj
            // 
            lblHeuresMecFormationProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecFormationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecFormationProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecFormationProj.Location = new System.Drawing.Point(446, 722);
            lblHeuresMecFormationProj.Name = "lblHeuresMecFormationProj";
            lblHeuresMecFormationProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecFormationProj.TabIndex = 501;
            lblHeuresMecFormationProj.Text = "0.00";
            // 
            // lblArgentMecFormationProj
            // 
            lblArgentMecFormationProj.BackColor = System.Drawing.Color.White;
            lblArgentMecFormationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecFormationProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecFormationProj.Location = new System.Drawing.Point(565, 722);
            lblArgentMecFormationProj.Name = "lblArgentMecFormationProj";
            lblArgentMecFormationProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecFormationProj.TabIndex = 502;
            lblArgentMecFormationProj.Text = "0.00";
            // 
            // lblHeuresMecGestionProj
            // 
            lblHeuresMecGestionProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecGestionProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecGestionProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecGestionProj.Location = new System.Drawing.Point(446, 740);
            lblHeuresMecGestionProj.Name = "lblHeuresMecGestionProj";
            lblHeuresMecGestionProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecGestionProj.TabIndex = 503;
            lblHeuresMecGestionProj.Text = "0.00";
            // 
            // lblArgentMecGestionProj
            // 
            lblArgentMecGestionProj.BackColor = System.Drawing.Color.White;
            lblArgentMecGestionProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecGestionProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecGestionProj.Location = new System.Drawing.Point(565, 740);
            lblArgentMecGestionProj.Name = "lblArgentMecGestionProj";
            lblArgentMecGestionProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecGestionProj.TabIndex = 504;
            lblArgentMecGestionProj.Text = "0.00";
            // 
            // lblArgentMecShippingProj
            // 
            lblArgentMecShippingProj.BackColor = System.Drawing.Color.White;
            lblArgentMecShippingProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecShippingProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecShippingProj.Location = new System.Drawing.Point(565, 758);
            lblArgentMecShippingProj.Name = "lblArgentMecShippingProj";
            lblArgentMecShippingProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecShippingProj.TabIndex = 505;
            lblArgentMecShippingProj.Text = "0.00";
            // 
            // lblArgentElecInstallationProj
            // 
            lblArgentElecInstallationProj.BackColor = System.Drawing.Color.White;
            lblArgentElecInstallationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecInstallationProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecInstallationProj.Location = new System.Drawing.Point(563, 366);
            lblArgentElecInstallationProj.Name = "lblArgentElecInstallationProj";
            lblArgentElecInstallationProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecInstallationProj.TabIndex = 506;
            lblArgentElecInstallationProj.Text = "0.00";
            // 
            // lblHeuresElecInstallationProj
            // 
            lblHeuresElecInstallationProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecInstallationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecInstallationProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecInstallationProj.Location = new System.Drawing.Point(446, 365);
            lblHeuresElecInstallationProj.Name = "lblHeuresElecInstallationProj";
            lblHeuresElecInstallationProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecInstallationProj.TabIndex = 507;
            lblHeuresElecInstallationProj.Text = "0.00";
            // 
            // lblPiecesMecSoum
            // 
            lblPiecesMecSoum.BackColor = System.Drawing.Color.White;
            lblPiecesMecSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPiecesMecSoum.ForeColor = System.Drawing.Color.Navy;
            lblPiecesMecSoum.Location = new System.Drawing.Point(328, 817);
            lblPiecesMecSoum.Name = "lblPiecesMecSoum";
            lblPiecesMecSoum.Size = new System.Drawing.Size(118, 14);
            lblPiecesMecSoum.TabIndex = 508;
            lblPiecesMecSoum.Text = "0.00";
            // 
            // lblImprevuMecSoum
            // 
            lblImprevuMecSoum.BackColor = System.Drawing.Color.White;
            lblImprevuMecSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImprevuMecSoum.ForeColor = System.Drawing.Color.Navy;
            lblImprevuMecSoum.Location = new System.Drawing.Point(328, 835);
            lblImprevuMecSoum.Name = "lblImprevuMecSoum";
            lblImprevuMecSoum.Size = new System.Drawing.Size(118, 14);
            lblImprevuMecSoum.TabIndex = 509;
            lblImprevuMecSoum.Text = "0.00";
            // 
            // lblAutresMecSoum
            // 
            lblAutresMecSoum.BackColor = System.Drawing.Color.White;
            lblAutresMecSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAutresMecSoum.ForeColor = System.Drawing.Color.Navy;
            lblAutresMecSoum.Location = new System.Drawing.Point(328, 853);
            lblAutresMecSoum.Name = "lblAutresMecSoum";
            lblAutresMecSoum.Size = new System.Drawing.Size(118, 14);
            lblAutresMecSoum.TabIndex = 510;
            lblAutresMecSoum.Text = "0.00";
            // 
            // lblHeuresMecDessinProj
            // 
            lblHeuresMecDessinProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecDessinProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecDessinProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecDessinProj.Location = new System.Drawing.Point(446, 576);
            lblHeuresMecDessinProj.Name = "lblHeuresMecDessinProj";
            lblHeuresMecDessinProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecDessinProj.TabIndex = 512;
            lblHeuresMecDessinProj.Text = "0.00";
            // 
            // lblArgentMecDessinProj
            // 
            lblArgentMecDessinProj.BackColor = System.Drawing.Color.White;
            lblArgentMecDessinProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecDessinProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecDessinProj.Location = new System.Drawing.Point(565, 576);
            lblArgentMecDessinProj.Name = "lblArgentMecDessinProj";
            lblArgentMecDessinProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecDessinProj.TabIndex = 513;
            lblArgentMecDessinProj.Text = "0.00";
            // 
            // lblHeuresMecCoupeProj
            // 
            lblHeuresMecCoupeProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecCoupeProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecCoupeProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecCoupeProj.Location = new System.Drawing.Point(446, 594);
            lblHeuresMecCoupeProj.Name = "lblHeuresMecCoupeProj";
            lblHeuresMecCoupeProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecCoupeProj.TabIndex = 514;
            lblHeuresMecCoupeProj.Text = "0.00";
            // 
            // lblArgentMecCoupeProj
            // 
            lblArgentMecCoupeProj.BackColor = System.Drawing.Color.White;
            lblArgentMecCoupeProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecCoupeProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecCoupeProj.Location = new System.Drawing.Point(565, 594);
            lblArgentMecCoupeProj.Name = "lblArgentMecCoupeProj";
            lblArgentMecCoupeProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecCoupeProj.TabIndex = 515;
            lblArgentMecCoupeProj.Text = "0.00";
            // 
            // lblArgentMecMachinageProj
            // 
            lblArgentMecMachinageProj.BackColor = System.Drawing.Color.White;
            lblArgentMecMachinageProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecMachinageProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecMachinageProj.Location = new System.Drawing.Point(565, 613);
            lblArgentMecMachinageProj.Name = "lblArgentMecMachinageProj";
            lblArgentMecMachinageProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecMachinageProj.TabIndex = 516;
            lblArgentMecMachinageProj.Text = "0.00";
            // 
            // lblHeuresMecMachinageProj
            // 
            lblHeuresMecMachinageProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecMachinageProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecMachinageProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecMachinageProj.Location = new System.Drawing.Point(446, 613);
            lblHeuresMecMachinageProj.Name = "lblHeuresMecMachinageProj";
            lblHeuresMecMachinageProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecMachinageProj.TabIndex = 517;
            lblHeuresMecMachinageProj.Text = "0.00";
            // 
            // lblHeuresMecSoudureProj
            // 
            lblHeuresMecSoudureProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecSoudureProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecSoudureProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecSoudureProj.Location = new System.Drawing.Point(446, 631);
            lblHeuresMecSoudureProj.Name = "lblHeuresMecSoudureProj";
            lblHeuresMecSoudureProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecSoudureProj.TabIndex = 518;
            lblHeuresMecSoudureProj.Text = "0.00";
            // 
            // lblArgentMecSoudureProj
            // 
            lblArgentMecSoudureProj.BackColor = System.Drawing.Color.White;
            lblArgentMecSoudureProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecSoudureProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecSoudureProj.Location = new System.Drawing.Point(565, 631);
            lblArgentMecSoudureProj.Name = "lblArgentMecSoudureProj";
            lblArgentMecSoudureProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecSoudureProj.TabIndex = 519;
            lblArgentMecSoudureProj.Text = "0.00";
            // 
            // lblHeuresMecAssemblageProj
            // 
            lblHeuresMecAssemblageProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecAssemblageProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecAssemblageProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecAssemblageProj.Location = new System.Drawing.Point(446, 649);
            lblHeuresMecAssemblageProj.Name = "lblHeuresMecAssemblageProj";
            lblHeuresMecAssemblageProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecAssemblageProj.TabIndex = 520;
            lblHeuresMecAssemblageProj.Text = "0.00";
            // 
            // lblArgentMecAssemblageProj
            // 
            lblArgentMecAssemblageProj.BackColor = System.Drawing.Color.White;
            lblArgentMecAssemblageProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecAssemblageProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecAssemblageProj.Location = new System.Drawing.Point(565, 649);
            lblArgentMecAssemblageProj.Name = "lblArgentMecAssemblageProj";
            lblArgentMecAssemblageProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecAssemblageProj.TabIndex = 521;
            lblArgentMecAssemblageProj.Text = "0.00";
            // 
            // lblHeuresMecPeintureProj
            // 
            lblHeuresMecPeintureProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecPeintureProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecPeintureProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecPeintureProj.Location = new System.Drawing.Point(446, 668);
            lblHeuresMecPeintureProj.Name = "lblHeuresMecPeintureProj";
            lblHeuresMecPeintureProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecPeintureProj.TabIndex = 522;
            lblHeuresMecPeintureProj.Text = "0.00";
            // 
            // lblArgentMecPeintureProj
            // 
            lblArgentMecPeintureProj.BackColor = System.Drawing.Color.White;
            lblArgentMecPeintureProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecPeintureProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecPeintureProj.Location = new System.Drawing.Point(565, 668);
            lblArgentMecPeintureProj.Name = "lblArgentMecPeintureProj";
            lblArgentMecPeintureProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecPeintureProj.TabIndex = 523;
            lblArgentMecPeintureProj.Text = "0.00";
            // 
            // lblHeuresMecTestProj
            // 
            lblHeuresMecTestProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecTestProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecTestProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecTestProj.Location = new System.Drawing.Point(446, 686);
            lblHeuresMecTestProj.Name = "lblHeuresMecTestProj";
            lblHeuresMecTestProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecTestProj.TabIndex = 524;
            lblHeuresMecTestProj.Text = "0.00";
            // 
            // lblArgentMecTestProj
            // 
            lblArgentMecTestProj.BackColor = System.Drawing.Color.White;
            lblArgentMecTestProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecTestProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecTestProj.Location = new System.Drawing.Point(565, 686);
            lblArgentMecTestProj.Name = "lblArgentMecTestProj";
            lblArgentMecTestProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecTestProj.TabIndex = 525;
            lblArgentMecTestProj.Text = "0.00";
            // 
            // lblHeuresMecInstallationProj
            // 
            lblHeuresMecInstallationProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecInstallationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecInstallationProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecInstallationProj.Location = new System.Drawing.Point(446, 704);
            lblHeuresMecInstallationProj.Name = "lblHeuresMecInstallationProj";
            lblHeuresMecInstallationProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecInstallationProj.TabIndex = 526;
            lblHeuresMecInstallationProj.Text = "0.00";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = System.Drawing.Color.White;
            lblDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDescription.ForeColor = System.Drawing.Color.Navy;
            lblDescription.Location = new System.Drawing.Point(299, 99);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(85, 15);
            lblDescription.TabIndex = 527;
            lblDescription.Text = "lblDescription";
            // 
            // lblForfaitMecSoum
            // 
            lblForfaitMecSoum.BackColor = System.Drawing.Color.White;
            lblForfaitMecSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblForfaitMecSoum.ForeColor = System.Drawing.Color.Navy;
            lblForfaitMecSoum.Location = new System.Drawing.Point(291, 151);
            lblForfaitMecSoum.Name = "lblForfaitMecSoum";
            lblForfaitMecSoum.Size = new System.Drawing.Size(91, 14);
            lblForfaitMecSoum.TabIndex = 528;
            lblForfaitMecSoum.Text = "lblForfaitMecSoum";
            // 
            // lblForfaitElecSoum
            // 
            lblForfaitElecSoum.BackColor = System.Drawing.Color.White;
            lblForfaitElecSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblForfaitElecSoum.ForeColor = System.Drawing.Color.Navy;
            lblForfaitElecSoum.Location = new System.Drawing.Point(291, 133);
            lblForfaitElecSoum.Name = "lblForfaitElecSoum";
            lblForfaitElecSoum.Size = new System.Drawing.Size(90, 14);
            lblForfaitElecSoum.TabIndex = 529;
            lblForfaitElecSoum.Text = "lblForfaitElecSoum";
            // 
            // lblTotalForfaitSoum
            // 
            lblTotalForfaitSoum.BackColor = System.Drawing.Color.White;
            lblTotalForfaitSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalForfaitSoum.ForeColor = System.Drawing.Color.Navy;
            lblTotalForfaitSoum.Location = new System.Drawing.Point(291, 170);
            lblTotalForfaitSoum.Name = "lblTotalForfaitSoum";
            lblTotalForfaitSoum.Size = new System.Drawing.Size(94, 14);
            lblTotalForfaitSoum.TabIndex = 530;
            lblTotalForfaitSoum.Text = "lblTotalForfaitSoum";
            // 
            // lblForfaitElecProj
            // 
            lblForfaitElecProj.BackColor = System.Drawing.Color.White;
            lblForfaitElecProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblForfaitElecProj.ForeColor = System.Drawing.Color.Navy;
            lblForfaitElecProj.Location = new System.Drawing.Point(528, 133);
            lblForfaitElecProj.Name = "lblForfaitElecProj";
            lblForfaitElecProj.Size = new System.Drawing.Size(118, 14);
            lblForfaitElecProj.TabIndex = 531;
            lblForfaitElecProj.Text = "lblForfaitElecProj";
            // 
            // lblForfaitMecProj
            // 
            lblForfaitMecProj.BackColor = System.Drawing.Color.White;
            lblForfaitMecProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblForfaitMecProj.ForeColor = System.Drawing.Color.Navy;
            lblForfaitMecProj.Location = new System.Drawing.Point(528, 151);
            lblForfaitMecProj.Name = "lblForfaitMecProj";
            lblForfaitMecProj.Size = new System.Drawing.Size(118, 14);
            lblForfaitMecProj.TabIndex = 532;
            lblForfaitMecProj.Text = "lblForfaitMecProj";
            // 
            // lblHeuresElecTotalSoum
            // 
            lblHeuresElecTotalSoum.BackColor = System.Drawing.Color.White;
            lblHeuresElecTotalSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecTotalSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecTotalSoum.Location = new System.Drawing.Point(210, 473);
            lblHeuresElecTotalSoum.Name = "lblHeuresElecTotalSoum";
            lblHeuresElecTotalSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecTotalSoum.TabIndex = 533;
            lblHeuresElecTotalSoum.Text = "0.00";
            // 
            // lblHeuresMecTotalSoum
            // 
            lblHeuresMecTotalSoum.BackColor = System.Drawing.Color.White;
            lblHeuresMecTotalSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecTotalSoum.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecTotalSoum.Location = new System.Drawing.Point(212, 796);
            lblHeuresMecTotalSoum.Name = "lblHeuresMecTotalSoum";
            lblHeuresMecTotalSoum.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecTotalSoum.TabIndex = 534;
            lblHeuresMecTotalSoum.Text = "0.00";
            // 
            // lblTotalHeuresSoum
            // 
            lblTotalHeuresSoum.BackColor = System.Drawing.Color.White;
            lblTotalHeuresSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalHeuresSoum.ForeColor = System.Drawing.Color.Navy;
            lblTotalHeuresSoum.Location = new System.Drawing.Point(212, 550);
            lblTotalHeuresSoum.Name = "lblTotalHeuresSoum";
            lblTotalHeuresSoum.Size = new System.Drawing.Size(118, 14);
            lblTotalHeuresSoum.TabIndex = 535;
            lblTotalHeuresSoum.Text = "0.00";
            // 
            // lblGrandTotalSoum
            // 
            lblGrandTotalSoum.BackColor = System.Drawing.Color.White;
            lblGrandTotalSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGrandTotalSoum.ForeColor = System.Drawing.Color.Navy;
            lblGrandTotalSoum.Location = new System.Drawing.Point(328, 890);
            lblGrandTotalSoum.Name = "lblGrandTotalSoum";
            lblGrandTotalSoum.Size = new System.Drawing.Size(118, 14);
            lblGrandTotalSoum.TabIndex = 536;
            lblGrandTotalSoum.Text = "0.00";
            // 
            // lblTotalMecSoum
            // 
            lblTotalMecSoum.BackColor = System.Drawing.Color.White;
            lblTotalMecSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalMecSoum.ForeColor = System.Drawing.Color.Navy;
            lblTotalMecSoum.Location = new System.Drawing.Point(328, 872);
            lblTotalMecSoum.Name = "lblTotalMecSoum";
            lblTotalMecSoum.Size = new System.Drawing.Size(118, 14);
            lblTotalMecSoum.TabIndex = 538;
            lblTotalMecSoum.Text = "0.00";
            // 
            // lblHeuresElecDessinProj
            // 
            lblHeuresElecDessinProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecDessinProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecDessinProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecDessinProj.Location = new System.Drawing.Point(446, 222);
            lblHeuresElecDessinProj.Name = "lblHeuresElecDessinProj";
            lblHeuresElecDessinProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecDessinProj.TabIndex = 539;
            lblHeuresElecDessinProj.Text = "0.00";
            // 
            // lblArgentElecDessinProj
            // 
            lblArgentElecDessinProj.BackColor = System.Drawing.Color.White;
            lblArgentElecDessinProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecDessinProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecDessinProj.Location = new System.Drawing.Point(563, 222);
            lblArgentElecDessinProj.Name = "lblArgentElecDessinProj";
            lblArgentElecDessinProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecDessinProj.TabIndex = 540;
            lblArgentElecDessinProj.Text = "0.00";
            // 
            // lblHeuresElecFabricationProj
            // 
            lblHeuresElecFabricationProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecFabricationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecFabricationProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecFabricationProj.Location = new System.Drawing.Point(446, 239);
            lblHeuresElecFabricationProj.Name = "lblHeuresElecFabricationProj";
            lblHeuresElecFabricationProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecFabricationProj.TabIndex = 541;
            lblHeuresElecFabricationProj.Text = "0.00";
            // 
            // lblArgentElecFabricationProj
            // 
            lblArgentElecFabricationProj.BackColor = System.Drawing.Color.White;
            lblArgentElecFabricationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecFabricationProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecFabricationProj.Location = new System.Drawing.Point(563, 239);
            lblArgentElecFabricationProj.Name = "lblArgentElecFabricationProj";
            lblArgentElecFabricationProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecFabricationProj.TabIndex = 542;
            lblArgentElecFabricationProj.Text = "0.00";
            // 
            // lblHeuresElecAssemblageProj
            // 
            lblHeuresElecAssemblageProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecAssemblageProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecAssemblageProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecAssemblageProj.Location = new System.Drawing.Point(446, 255);
            lblHeuresElecAssemblageProj.Name = "lblHeuresElecAssemblageProj";
            lblHeuresElecAssemblageProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecAssemblageProj.TabIndex = 543;
            lblHeuresElecAssemblageProj.Text = "0.00";
            // 
            // lblHeuresElecProgInterfaceProj
            // 
            lblHeuresElecProgInterfaceProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecProgInterfaceProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecProgInterfaceProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecProgInterfaceProj.Location = new System.Drawing.Point(446, 274);
            lblHeuresElecProgInterfaceProj.Name = "lblHeuresElecProgInterfaceProj";
            lblHeuresElecProgInterfaceProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecProgInterfaceProj.TabIndex = 544;
            lblHeuresElecProgInterfaceProj.Text = "0.00";
            // 
            // lblArgentElecProgInterfaceProj
            // 
            lblArgentElecProgInterfaceProj.BackColor = System.Drawing.Color.White;
            lblArgentElecProgInterfaceProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecProgInterfaceProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecProgInterfaceProj.Location = new System.Drawing.Point(563, 274);
            lblArgentElecProgInterfaceProj.Name = "lblArgentElecProgInterfaceProj";
            lblArgentElecProgInterfaceProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecProgInterfaceProj.TabIndex = 545;
            lblArgentElecProgInterfaceProj.Text = "0.00";
            // 
            // lblArgentElecProgAutomateProj
            // 
            lblArgentElecProgAutomateProj.BackColor = System.Drawing.Color.White;
            lblArgentElecProgAutomateProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecProgAutomateProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecProgAutomateProj.Location = new System.Drawing.Point(563, 292);
            lblArgentElecProgAutomateProj.Name = "lblArgentElecProgAutomateProj";
            lblArgentElecProgAutomateProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecProgAutomateProj.TabIndex = 546;
            lblArgentElecProgAutomateProj.Text = "0.00";
            // 
            // lblHeuresElecProgAutomateProj
            // 
            lblHeuresElecProgAutomateProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecProgAutomateProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecProgAutomateProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecProgAutomateProj.Location = new System.Drawing.Point(446, 292);
            lblHeuresElecProgAutomateProj.Name = "lblHeuresElecProgAutomateProj";
            lblHeuresElecProgAutomateProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecProgAutomateProj.TabIndex = 547;
            lblHeuresElecProgAutomateProj.Text = "0.00";
            // 
            // lblHeuresElecProgRobotProj
            // 
            lblHeuresElecProgRobotProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecProgRobotProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecProgRobotProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecProgRobotProj.Location = new System.Drawing.Point(446, 310);
            lblHeuresElecProgRobotProj.Name = "lblHeuresElecProgRobotProj";
            lblHeuresElecProgRobotProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecProgRobotProj.TabIndex = 548;
            lblHeuresElecProgRobotProj.Text = "0.00";
            // 
            // lblArgentElecProgRobotProj
            // 
            lblArgentElecProgRobotProj.BackColor = System.Drawing.Color.White;
            lblArgentElecProgRobotProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecProgRobotProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecProgRobotProj.Location = new System.Drawing.Point(563, 311);
            lblArgentElecProgRobotProj.Name = "lblArgentElecProgRobotProj";
            lblArgentElecProgRobotProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecProgRobotProj.TabIndex = 549;
            lblArgentElecProgRobotProj.Text = "0.00";
            // 
            // lblHeuresElecVisionProj
            // 
            lblHeuresElecVisionProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecVisionProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecVisionProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecVisionProj.Location = new System.Drawing.Point(446, 328);
            lblHeuresElecVisionProj.Name = "lblHeuresElecVisionProj";
            lblHeuresElecVisionProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecVisionProj.TabIndex = 550;
            lblHeuresElecVisionProj.Text = "0.00";
            // 
            // lblArgentMecTotalSoum
            // 
            lblArgentMecTotalSoum.BackColor = System.Drawing.Color.White;
            lblArgentMecTotalSoum.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecTotalSoum.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecTotalSoum.Location = new System.Drawing.Point(328, 795);
            lblArgentMecTotalSoum.Name = "lblArgentMecTotalSoum";
            lblArgentMecTotalSoum.Size = new System.Drawing.Size(118, 14);
            lblArgentMecTotalSoum.TabIndex = 551;
            lblArgentMecTotalSoum.Text = "0.00";
            // 
            // lblArgentMecTotalProj
            // 
            lblArgentMecTotalProj.BackColor = System.Drawing.Color.White;
            lblArgentMecTotalProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecTotalProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecTotalProj.Location = new System.Drawing.Point(565, 796);
            lblArgentMecTotalProj.Name = "lblArgentMecTotalProj";
            lblArgentMecTotalProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecTotalProj.TabIndex = 552;
            lblArgentMecTotalProj.Text = "0.00";
            // 
            // lblArgentElecGestionProj
            // 
            lblArgentElecGestionProj.BackColor = System.Drawing.Color.White;
            lblArgentElecGestionProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecGestionProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecGestionProj.Location = new System.Drawing.Point(563, 419);
            lblArgentElecGestionProj.Name = "lblArgentElecGestionProj";
            lblArgentElecGestionProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecGestionProj.TabIndex = 554;
            lblArgentElecGestionProj.Text = "0.00";
            // 
            // lblHeuresElecShippingProj
            // 
            lblHeuresElecShippingProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecShippingProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecShippingProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecShippingProj.Location = new System.Drawing.Point(446, 437);
            lblHeuresElecShippingProj.Name = "lblHeuresElecShippingProj";
            lblHeuresElecShippingProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecShippingProj.TabIndex = 555;
            lblHeuresElecShippingProj.Text = "0.00";
            // 
            // lblArgentElecShippingProj
            // 
            lblArgentElecShippingProj.BackColor = System.Drawing.Color.White;
            lblArgentElecShippingProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentElecShippingProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentElecShippingProj.Location = new System.Drawing.Point(563, 437);
            lblArgentElecShippingProj.Name = "lblArgentElecShippingProj";
            lblArgentElecShippingProj.Size = new System.Drawing.Size(118, 14);
            lblArgentElecShippingProj.TabIndex = 556;
            lblArgentElecShippingProj.Text = "0.00";
            // 
            // lblHeuresElecRechercheProj
            // 
            lblHeuresElecRechercheProj.BackColor = System.Drawing.Color.White;
            lblHeuresElecRechercheProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresElecRechercheProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresElecRechercheProj.Location = new System.Drawing.Point(446, 454);
            lblHeuresElecRechercheProj.Name = "lblHeuresElecRechercheProj";
            lblHeuresElecRechercheProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresElecRechercheProj.TabIndex = 557;
            lblHeuresElecRechercheProj.Text = "0.00";
            // 
            // lblArgentMecInstallationProj
            // 
            lblArgentMecInstallationProj.BackColor = System.Drawing.Color.White;
            lblArgentMecInstallationProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecInstallationProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecInstallationProj.Location = new System.Drawing.Point(565, 704);
            lblArgentMecInstallationProj.Name = "lblArgentMecInstallationProj";
            lblArgentMecInstallationProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecInstallationProj.TabIndex = 558;
            lblArgentMecInstallationProj.Text = "0.00";
            // 
            // lblHeuresMecShippingProj
            // 
            lblHeuresMecShippingProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecShippingProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecShippingProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecShippingProj.Location = new System.Drawing.Point(446, 758);
            lblHeuresMecShippingProj.Name = "lblHeuresMecShippingProj";
            lblHeuresMecShippingProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecShippingProj.TabIndex = 559;
            lblHeuresMecShippingProj.Text = "0.00";
            // 
            // lblHeuresMecRechercheProj
            // 
            lblHeuresMecRechercheProj.BackColor = System.Drawing.Color.White;
            lblHeuresMecRechercheProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHeuresMecRechercheProj.ForeColor = System.Drawing.Color.Navy;
            lblHeuresMecRechercheProj.Location = new System.Drawing.Point(446, 776);
            lblHeuresMecRechercheProj.Name = "lblHeuresMecRechercheProj";
            lblHeuresMecRechercheProj.Size = new System.Drawing.Size(118, 14);
            lblHeuresMecRechercheProj.TabIndex = 560;
            lblHeuresMecRechercheProj.Text = "0.00";
            // 
            // lblArgentMecRechercheProj
            // 
            lblArgentMecRechercheProj.BackColor = System.Drawing.Color.White;
            lblArgentMecRechercheProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblArgentMecRechercheProj.ForeColor = System.Drawing.Color.Navy;
            lblArgentMecRechercheProj.Location = new System.Drawing.Point(565, 777);
            lblArgentMecRechercheProj.Name = "lblArgentMecRechercheProj";
            lblArgentMecRechercheProj.Size = new System.Drawing.Size(118, 14);
            lblArgentMecRechercheProj.TabIndex = 561;
            lblArgentMecRechercheProj.Text = "0.00";
            // 
            // lblPiecesMecProj
            // 
            lblPiecesMecProj.BackColor = System.Drawing.Color.White;
            lblPiecesMecProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPiecesMecProj.ForeColor = System.Drawing.Color.Navy;
            lblPiecesMecProj.Location = new System.Drawing.Point(565, 817);
            lblPiecesMecProj.Name = "lblPiecesMecProj";
            lblPiecesMecProj.Size = new System.Drawing.Size(118, 14);
            lblPiecesMecProj.TabIndex = 562;
            lblPiecesMecProj.Text = "0.00";
            // 
            // lblImprevuMecProj
            // 
            lblImprevuMecProj.BackColor = System.Drawing.Color.White;
            lblImprevuMecProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblImprevuMecProj.ForeColor = System.Drawing.Color.Navy;
            lblImprevuMecProj.Location = new System.Drawing.Point(565, 835);
            lblImprevuMecProj.Name = "lblImprevuMecProj";
            lblImprevuMecProj.Size = new System.Drawing.Size(118, 14);
            lblImprevuMecProj.TabIndex = 563;
            lblImprevuMecProj.Text = "0.00";
            // 
            // lblTitreProj
            // 
            lblTitreProj.BackColor = System.Drawing.Color.White;
            lblTitreProj.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProj.ForeColor = System.Drawing.Color.Navy;
            lblTitreProj.Location = new System.Drawing.Point(446, 191);
            lblTitreProj.Name = "lblTitreProj";
            lblTitreProj.Size = new System.Drawing.Size(235, 17);
            lblTitreProj.TabIndex = 564;
            lblTitreProj.Text = "Projet";
            lblTitreProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreTotal
            // 
            lblTitreTotal.AutoSize = true;
            lblTitreTotal.BackColor = System.Drawing.Color.White;
            lblTitreTotal.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTotal.ForeColor = System.Drawing.Color.Navy;
            lblTitreTotal.Location = new System.Drawing.Point(54, 891);
            lblTitreTotal.Name = "lblTitreTotal";
            lblTitreTotal.Size = new System.Drawing.Size(29, 13);
            lblTitreTotal.TabIndex = 565;
            lblTitreTotal.Text = "Total";
            lblTitreTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.BackColor = System.Drawing.Color.White;
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1,
            toolStripStatusLabel2});
            statusStrip1.Location = new System.Drawing.Point(0, 1038);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(822, 23);
            statusStrip1.TabIndex = 597;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            toolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(728, 18);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            toolStripStatusLabel2.BackColor = System.Drawing.Color.White;
            toolStripStatusLabel2.ForeColor = System.Drawing.Color.Navy;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(79, 18);
            toolStripStatusLabel2.Text = "Page 1 sur 1   ";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.White;
            label3.Image = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            label3.Location = new System.Drawing.Point(632, 1);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(178, 74);
            label3.TabIndex = 417;
            label3.Click += new System.EventHandler(label3_Click);
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.White;
            label4.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Navy;
            label4.Location = new System.Drawing.Point(446, 873);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 14);
            label4.TabIndex = 598;
            label4.Text = "0.00";
            // 
            // ViewApercuProjet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(822, 1061);
            Controls.Add(label4);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitreTotal);
            Controls.Add(lblArgentElecGestionProj);
            Controls.Add(lblHeuresElecShippingProj);
            Controls.Add(lblArgentElecShippingProj);
            Controls.Add(lblHeuresElecRechercheProj);
            Controls.Add(lblArgentMecInstallationProj);
            Controls.Add(lblHeuresMecShippingProj);
            Controls.Add(lblHeuresMecRechercheProj);
            Controls.Add(lblArgentMecRechercheProj);
            Controls.Add(lblPiecesMecProj);
            Controls.Add(lblImprevuMecProj);
            Controls.Add(lblTitreProj);
            Controls.Add(lblHeuresElecDessinProj);
            Controls.Add(lblArgentElecDessinProj);
            Controls.Add(lblHeuresElecFabricationProj);
            Controls.Add(lblArgentElecFabricationProj);
            Controls.Add(lblHeuresElecAssemblageProj);
            Controls.Add(lblHeuresElecProgInterfaceProj);
            Controls.Add(lblArgentElecProgInterfaceProj);
            Controls.Add(lblArgentElecProgAutomateProj);
            Controls.Add(lblHeuresElecProgAutomateProj);
            Controls.Add(lblHeuresElecProgRobotProj);
            Controls.Add(lblArgentElecProgRobotProj);
            Controls.Add(lblHeuresElecVisionProj);
            Controls.Add(lblArgentMecTotalSoum);
            Controls.Add(lblArgentMecTotalProj);
            Controls.Add(lblDescription);
            Controls.Add(lblForfaitMecSoum);
            Controls.Add(lblForfaitElecSoum);
            Controls.Add(lblTotalForfaitSoum);
            Controls.Add(lblForfaitElecProj);
            Controls.Add(lblForfaitMecProj);
            Controls.Add(lblHeuresElecTotalSoum);
            Controls.Add(lblHeuresMecTotalSoum);
            Controls.Add(lblTotalHeuresSoum);
            Controls.Add(lblGrandTotalSoum);
            Controls.Add(lblTotalMecSoum);
            Controls.Add(lblArgentElecInstallationProj);
            Controls.Add(lblHeuresElecInstallationProj);
            Controls.Add(lblPiecesMecSoum);
            Controls.Add(lblImprevuMecSoum);
            Controls.Add(lblAutresMecSoum);
            Controls.Add(lblHeuresMecDessinProj);
            Controls.Add(lblArgentMecDessinProj);
            Controls.Add(lblHeuresMecCoupeProj);
            Controls.Add(lblArgentMecCoupeProj);
            Controls.Add(lblArgentMecMachinageProj);
            Controls.Add(lblHeuresMecMachinageProj);
            Controls.Add(lblHeuresMecSoudureProj);
            Controls.Add(lblArgentMecSoudureProj);
            Controls.Add(lblHeuresMecAssemblageProj);
            Controls.Add(lblArgentMecAssemblageProj);
            Controls.Add(lblHeuresMecPeintureProj);
            Controls.Add(lblArgentMecPeintureProj);
            Controls.Add(lblHeuresMecTestProj);
            Controls.Add(lblArgentMecTestProj);
            Controls.Add(lblHeuresMecInstallationProj);
            Controls.Add(lblTotalForfaitProj);
            Controls.Add(lblHeuresElecTotalProj);
            Controls.Add(lblHeuresMecTotalProj);
            Controls.Add(lblGrandTotalProj);
            Controls.Add(lblTotalMecProj);
            Controls.Add(lblProfitSoum);
            Controls.Add(lblProfitProj);
            Controls.Add(lblArgentElecVisionProj);
            Controls.Add(lblHeuresElecTestProj);
            Controls.Add(lblArgentElecTestProj);
            Controls.Add(lblArgentMecTestSoum);
            Controls.Add(lblHeuresMecInstallationSoum);
            Controls.Add(lblArgentMecInstallationSoum);
            Controls.Add(lblHeuresMecFormationSoum);
            Controls.Add(lblArgentMecFormationSoum);
            Controls.Add(lblHeuresMecGestionSoum);
            Controls.Add(lblArgentMecGestionSoum);
            Controls.Add(lblHeuresMecShippingSoum);
            Controls.Add(lblArgentMecShippingSoum);
            Controls.Add(lblHeuresMecFormationProj);
            Controls.Add(lblArgentMecFormationProj);
            Controls.Add(lblHeuresMecGestionProj);
            Controls.Add(lblArgentMecGestionProj);
            Controls.Add(lblArgentMecShippingProj);
            Controls.Add(lblArgentElecDessinSoum);
            Controls.Add(lblHeuresElecDessinSoum);
            Controls.Add(lblArgentElecFabricationSoum);
            Controls.Add(lblHeuresElecFabricationSoum);
            Controls.Add(lblArgentElecAssemblageSoum);
            Controls.Add(lblHeuresElecAssemblageSoum);
            Controls.Add(lblArgentElecProgInterfaceSoum);
            Controls.Add(lblArgentElecVisionSoum);
            Controls.Add(lblHeuresElecTestSoum);
            Controls.Add(lblHeuresElecMiseServiceProj);
            Controls.Add(lblArgentElecMiseServiceProj);
            Controls.Add(lblHeuresElecFormationProj);
            Controls.Add(lblArgentElecFormationProj);
            Controls.Add(lblHeuresElecGestionProj);
            Controls.Add(lblHeuresElecProgInterfaceSoum);
            Controls.Add(lblArgentElecProgAutomateSoum);
            Controls.Add(lblHeuresElecProgAutomateSoum);
            Controls.Add(lblArgentElecProgRobotSoum);
            Controls.Add(lblHeuresElecProgRobotSoum);
            Controls.Add(lblHeuresElecVisionSoum);
            Controls.Add(lblArgentElecTestSoum);
            Controls.Add(lblArgentElecInstallationSoum);
            Controls.Add(lblHeuresElecInstallationSoum);
            Controls.Add(lblHeuresElecMiseServiceSoum);
            Controls.Add(lblArgentElecMiseServiceSoum);
            Controls.Add(lblHeuresElecFormationSoum);
            Controls.Add(lblArgentElecFormationSoum);
            Controls.Add(lblHeuresElecGestionSoum);
            Controls.Add(lblArgentElecGestionSoum);
            Controls.Add(lblHeuresElecShippingSoum);
            Controls.Add(lblArgentElecShippingSoum);
            Controls.Add(lblPiecesElecSoum);
            Controls.Add(lblImprevuElecSoum);
            Controls.Add(lblAutresElecSoum);
            Controls.Add(lblArgentElecAssemblageProj);
            Controls.Add(lblArgentElecRechercheProj);
            Controls.Add(lblImprevuElecProj);
            Controls.Add(lblPiecesElecProj);
            Controls.Add(lblAutresElecProj);
            Controls.Add(lblArgentElecTotalSoum);
            Controls.Add(lblArgentElecTotalProj);
            Controls.Add(lblHeuresMecDessinSoum);
            Controls.Add(lblArgentMecDessinSoum);
            Controls.Add(lblHeuresMecCoupeSoum);
            Controls.Add(lblArgentMecCoupeSoum);
            Controls.Add(lblHeuresMecMachinageSoum);
            Controls.Add(lblArgentMecMachinageSoum);
            Controls.Add(lblHeuresMecSoudureSoum);
            Controls.Add(lblArgentMecSoudureSoum);
            Controls.Add(lblHeuresMecAssemblageSoum);
            Controls.Add(lblArgentMecAssemblageSoum);
            Controls.Add(lblHeuresMecPeintureSoum);
            Controls.Add(lblArgentMecPeintureSoum);
            Controls.Add(lblHeuresMecTestSoum);
            Controls.Add(lblAutresMecProj);
            Controls.Add(lblTitreProfitTotal);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lblDate);
            Controls.Add(lblTitreDate);
            Controls.Add(lblTitreSoum);
            Controls.Add(lblTitreHeuresSoum);
            Controls.Add(lblTitreArgentSoum);
            Controls.Add(lblTitreHeuresProj);
            Controls.Add(lblTitreArgentProj);
            Controls.Add(lblTitreRevenus);
            Controls.Add(lblTitreForfaitElec);
            Controls.Add(lblTitreForfaitMec);
            Controls.Add(lblTitreTotalForfait);
            Controls.Add(lblTitreDepenses);
            Controls.Add(lblTitreTempsElecDessin);
            Controls.Add(lblTitreTempsElecFabrication);
            Controls.Add(lblTitreTempsElecAssemblage);
            Controls.Add(lblTitreTempsElecProgInterface);
            Controls.Add(lblTitreTempsElecProgAutomate);
            Controls.Add(lblTitreTempsElecProgRobot);
            Controls.Add(lblTitreTempsElecVision);
            Controls.Add(lblTitreTempsElecTest);
            Controls.Add(lblTitreTempsElecInstallation);
            Controls.Add(lblTitreTempsElecMiseService);
            Controls.Add(lblTitreTempsElecFormation);
            Controls.Add(lblTitreTempsElecGestion);
            Controls.Add(lblTitreTempsElecShipping);
            Controls.Add(lblTitreTempsElecTotal);
            Controls.Add(lblHeuresElecTotalProj0);
            Controls.Add(label1);
            Controls.Add(lblTitreTempsMecAssemblage);
            Controls.Add(lblTitreTempsMecPeinture);
            Controls.Add(lblTitreTempsMecTest);
            Controls.Add(lblTitreTempsMecInstallation);
            Controls.Add(lblTitreTempsMecFormation);
            Controls.Add(lblTitreTempsMecGestion);
            Controls.Add(lblTitreTempsMecShipping);
            Controls.Add(lblTitrePiecesMec);
            Controls.Add(lblTitreTempsMecTotal);
            Controls.Add(lblTitreImprevuMec);
            Controls.Add(lblTitreAutresMec);
            Controls.Add(lblTitreTotalMec);
            Controls.Add(lblTotalElecProj0);
            Controls.Add(lblTitrePiecesElec);
            Controls.Add(lblTitreImprevuElec);
            Controls.Add(lblTitreAutresElec);
            Controls.Add(lblTitreTotalElec);
            Controls.Add(lblTotalElecSoum0);
            Controls.Add(lblTitreTempsMecDessin);
            Controls.Add(lblTitreTempsMecCoupe);
            Controls.Add(lblTitreTempsMecMachinage);
            Controls.Add(lblTitreTempsMecSoudure);
            Controls.Add(lblTitreDescription);
            Controls.Add(lblClient);
            Controls.Add(lblTitreClient);
            Controls.Add(lblNumero);
            Controls.Add(lblTitreNoProjet);
            Controls.Add(lblTitreRapport);
            Margin = new System.Windows.Forms.Padding(3, 21, 3, 21);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewApercuProjet";
            Text = "ViewAppercuProjet";
            Load += new System.EventHandler(ViewAppercuProjet_Load);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static    System.Windows.Forms.Label Label2;
        internal static  Label lblTitreRapport;
        internal static  Label lblTitreNoProjet;
        internal static  Label lblNumero;
        internal static  Label lblTitreClient;
        internal static  Label lblClient;
        internal static  Label lblTitreDescription;
        internal static  Label lblTotalElecProj0;
        internal static  Label lblTitrePiecesElec;
        internal static  Label lblTitreImprevuElec;
        internal static  Label lblTitreAutresElec;
        internal static  Label lblTitreTotalElec;
        internal static  Label lblTotalElecSoum0;
        internal static  Label lblTitreTempsMecDessin;
        internal static  Label lblTitreTempsMecCoupe;
        internal static  Label lblTitreTempsMecMachinage;
        internal static  Label lblTitreTempsMecSoudure;
        internal static  Label lblTitreTempsMecAssemblage;
        internal static  Label lblTitreTempsMecPeinture;
        internal static  Label lblTitreTempsMecTest;
        internal static  Label lblTitreTempsMecInstallation;
        internal static  Label lblTitreTempsMecFormation;
        internal static  Label lblTitreTempsMecGestion;
        internal static  Label lblTitreTempsMecShipping;
        internal static  Label lblTitrePiecesMec;
        internal static  Label lblTitreTempsMecTotal;
        internal static  Label lblTitreImprevuMec;
        internal static  Label lblTitreAutresMec;
        internal static  Label lblTitreTotalMec;
        internal static  Label label1;
        internal static  Label lblTitreDate;
        internal static  Label lblTitreSoum;
        internal static  Label lblTitreHeuresSoum;
        internal static  Label lblTitreArgentSoum;
        internal static  Label lblTitreHeuresProj;
        internal static  Label lblTitreArgentProj;
        internal static  Label lblTitreRevenus;
        internal static  Label lblTitreForfaitElec;
        internal static  Label lblTitreForfaitMec;
        internal static  Label lblTitreTotalForfait;
        internal static  Label lblTitreDepenses;
        internal static  Label lblTitreTempsElecDessin;
        internal static  Label lblTitreTempsElecFabrication;
        internal static  Label lblTitreTempsElecAssemblage;
        internal static  Label lblTitreTempsElecProgInterface;
        internal static  Label lblTitreTempsElecProgAutomate;
        internal static  Label lblTitreTempsElecProgRobot;
        internal static  Label lblTitreTempsElecVision;
        internal static  Label lblTitreTempsElecTest;
        internal static  Label lblTitreTempsElecInstallation;
        internal static  Label lblTitreTempsElecMiseService;
        internal static  Label lblTitreTempsElecFormation;
        internal static  Label lblTitreTempsElecGestion;
        internal static  Label lblTitreTempsElecShipping;
        internal static  Label lblTitreTempsElecTotal;
        internal static  Label lblHeuresElecTotalProj0;
        internal static  Label lblDate;
        internal static  Label label3;
        internal static  Label label5;
        internal static  Label lblHeuresElecProgInterfaceSoum;
        internal static  Label lblArgentElecProgAutomateSoum;
        internal static  Label lblHeuresElecProgAutomateSoum;
        internal static  Label lblArgentElecProgRobotSoum;
        internal static  Label lblHeuresElecProgRobotSoum;
        internal static  Label lblHeuresElecVisionSoum;
        internal static  Label lblArgentElecTestSoum;
        internal static  Label lblArgentElecInstallationSoum;
        internal static  Label lblHeuresElecInstallationSoum;
        internal static  Label lblHeuresElecMiseServiceSoum;
        internal static  Label lblArgentElecMiseServiceSoum;
        internal static  Label lblHeuresElecFormationSoum;
        internal static  Label lblArgentElecFormationSoum;
        internal static  Label lblHeuresElecGestionSoum;
        internal static  Label lblArgentElecGestionSoum;
        internal static  Label lblHeuresElecShippingSoum;
        internal static  Label lblArgentElecShippingSoum;
        internal static  Label lblPiecesElecSoum;
        internal static  Label lblImprevuElecSoum;
        internal static  Label lblAutresElecSoum;
        internal static  Label lblArgentElecAssemblageProj;
        internal static  Label lblArgentElecRechercheProj;
        internal static  Label lblImprevuElecProj;
        internal static  Label lblPiecesElecProj;
        internal static  Label lblAutresElecProj;
        internal static  Label lblArgentElecTotalSoum;
        internal static  Label lblArgentElecTotalProj;
        internal static  Label lblHeuresMecDessinSoum;
        internal static  Label lblArgentMecDessinSoum;
        internal static  Label lblHeuresMecCoupeSoum;
        internal static  Label lblArgentMecCoupeSoum;
        internal static  Label lblHeuresMecMachinageSoum;
        internal static  Label lblArgentMecMachinageSoum;
        internal static  Label lblHeuresMecSoudureSoum;
        internal static  Label lblArgentMecSoudureSoum;
        internal static  Label lblHeuresMecAssemblageSoum;
        internal static  Label lblArgentMecAssemblageSoum;
        internal static  Label lblHeuresMecPeintureSoum;
        internal static  Label lblArgentMecPeintureSoum;
        internal static  Label lblHeuresMecTestSoum;
        internal static  Label lblAutresMecProj;
        internal static  Label lblTitreProfitTotal;
        internal static  Label lblArgentElecDessinSoum;
        internal static  Label lblHeuresElecDessinSoum;
        internal static  Label lblArgentElecFabricationSoum;
        internal static  Label lblHeuresElecFabricationSoum;
        internal static  Label lblArgentElecAssemblageSoum;
        internal static  Label lblHeuresElecAssemblageSoum;
        internal static  Label lblArgentElecProgInterfaceSoum;
        internal static  Label lblArgentElecVisionSoum;
        internal static  Label lblHeuresElecTestSoum;
        internal static  Label lblHeuresElecMiseServiceProj;
        internal static  Label lblArgentElecMiseServiceProj;
        internal static  Label lblHeuresElecFormationProj;
        internal static  Label lblArgentElecFormationProj;
        internal static  Label lblHeuresElecGestionProj;
        internal static  Label lblTotalForfaitProj;
        internal static  Label lblHeuresElecTotalProj;
        internal static  Label lblHeuresMecTotalProj;
        internal static  Label lblGrandTotalProj;
        internal static  Label lblTotalMecProj;
        internal static  Label lblProfitSoum;
        internal static  System.Windows.Forms.Label lblProjetMec;
        internal static  Label lblProfitProj;
        internal static  Label lblArgentElecVisionProj;
        internal static  Label lblHeuresElecTestProj;
        internal static  Label lblArgentElecTestProj;
        internal static  Label lblArgentMecTestSoum;
        internal static  Label lblHeuresMecInstallationSoum;
        internal static  Label lblArgentMecInstallationSoum;
        internal static  Label lblHeuresMecFormationSoum;
        internal static  Label lblArgentMecFormationSoum;
        internal static  Label lblHeuresMecGestionSoum;
        internal static  Label lblArgentMecGestionSoum;
        internal static  Label lblHeuresMecShippingSoum;
        internal static  Label lblArgentMecShippingSoum;
        internal static  Label lblHeuresMecFormationProj;
        internal static  Label lblArgentMecFormationProj;
        internal static  Label lblHeuresMecGestionProj;
        internal static  Label lblArgentMecGestionProj;
        internal static  Label lblArgentMecShippingProj;
        internal static  Label lblArgentElecInstallationProj;
        internal static  Label lblHeuresElecInstallationProj;
        internal static  Label lblPiecesMecSoum;
        internal static  Label lblImprevuMecSoum;
        internal static  Label lblAutresMecSoum;
        internal static  Label lblHeuresMecDessinProj;
        internal static  Label lblArgentMecDessinProj;
        internal static  Label lblHeuresMecCoupeProj;
        internal static  Label lblArgentMecCoupeProj;
        internal static  Label lblArgentMecMachinageProj;
        internal static  Label lblHeuresMecMachinageProj;
        internal static  Label lblHeuresMecSoudureProj;
        internal static  Label lblArgentMecSoudureProj;
        internal static  Label lblHeuresMecAssemblageProj;
        internal static  Label lblArgentMecAssemblageProj;
        internal static  Label lblHeuresMecPeintureProj;
        internal static  Label lblArgentMecPeintureProj;
        internal static  Label lblHeuresMecTestProj;
        internal static  Label lblArgentMecTestProj;
        internal static  Label lblHeuresMecInstallationProj;
        internal static  Label lblDescription;
        internal static  Label lblForfaitMecSoum;
        internal static  Label lblForfaitElecSoum;
        internal static  Label lblTotalForfaitSoum;
        internal static  Label lblForfaitElecProj;
        internal static  Label lblForfaitMecProj;
        internal static  Label lblHeuresElecTotalSoum;
        internal static  Label lblHeuresMecTotalSoum;
        internal static  Label lblTotalHeuresSoum;
        internal static  Label lblGrandTotalSoum;
        internal static  Label lblTotalMecSoum;
        internal static  Label lblHeuresElecDessinProj;
        internal static  Label lblArgentElecDessinProj;
        internal static  Label lblHeuresElecFabricationProj;
        internal static  Label lblArgentElecFabricationProj;
        internal static  Label lblHeuresElecAssemblageProj;
        internal static  Label lblHeuresElecProgInterfaceProj;
        internal static  Label lblArgentElecProgInterfaceProj;
        internal static  Label lblArgentElecProgAutomateProj;
        internal static  Label lblHeuresElecProgAutomateProj;
        internal static  Label lblHeuresElecProgRobotProj;
        internal static  Label lblArgentElecProgRobotProj;
        internal static  Label lblHeuresElecVisionProj;
        internal static  Label lblArgentMecTotalSoum;
        internal static  Label lblArgentMecTotalProj;
        internal static  Label lblArgentElecGestionProj;
        internal static  Label lblHeuresElecShippingProj;
        internal static  Label lblArgentElecShippingProj;
        internal static  Label lblHeuresElecRechercheProj;
        internal static  Label lblArgentMecInstallationProj;
        internal static  Label lblHeuresMecShippingProj;
        internal static  Label lblHeuresMecRechercheProj;
        internal static  Label lblArgentMecRechercheProj;
        internal static  Label lblPiecesMecProj;
        internal static  Label lblImprevuMecProj;
        internal static  Label lblTitreProj;
        internal static  Label lblTitreTotal;
        internal static  StatusStrip statusStrip1;
        internal static  ToolStripStatusLabel toolStripStatusLabel1;
        internal static  Label label4;
        internal static  ToolStripStatusLabel toolStripStatusLabel2;

        public ViewApercuProjet()
        {
            InitializeComponent();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        public ViewApercuProjet(string noProjet)
        {
            InitializeComponent();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            if (string.IsNullOrEmpty(noProjet))
            {
                MessageBox.Show($"« {nameof(noProjet)} » ne peut pas être vide ou avoir la valeur Null.",Application.ProductName+"ViewAppercuProjet" );
            }
            InitDatas4Facturation(noProjet);
        }

        private double dblTotal;
        private double dblHebergement;
        private dynamic iNbrePersonne;
        private dynamic dblRepas;
        private dynamic dblTransport;
        private dynamic dblUniteMobile;
        private dynamic dblPrixEmballage;
        private dynamic dblTotalResteTemps;
        private dynamic dblTotalManuel;
        private ADODB.Recordset rstSoumMec;
        private ADODB.Recordset rstProjetPieces;
        private dynamic dblTotalPieces;
        internal static  Label lblTotalHeuresProj;
        private void RemplirRapportElectrique(string noProjet)
        {
            try
            {
                ADODB.Recordset rstProjetElec;
                var rstSoumElec = default(ADODB.Recordset);
                ADODB.Recordset rstProjetPieces;
                double dblTotal;
                bool bSoumission;
                int iNbrePersonne;
                var dblHebergement = default(double);
                double dblRepas;
                double dblTransport;
                double dblUniteMobile;
                double dblPrixEmballage;
                double dblTotalResteTemps;
                double dblTotalManuel;
                var dblTotalPieces = default(double);
                rstProjetElec = new Recordset();
                rstProjetElec.Open("SELECT * FROM ProjetElec WHERE IDProjet = 'E" + noProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
//                lblProjetMec.Text = "E" + noProjet;
                if (!rstProjetElec.EOF)
                {
                    bSoumission = false;
                    if (!(rstProjetElec.Fields["IDSoumission"].Value is DBNull))
                    {
                        rstSoumElec = new Recordset();
                        rstSoumElec.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + rstProjetElec.Fields["IDSoumission"].Value + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstSoumElec.EOF)
                        {
                            bSoumission = true;
                        }
                        else
                        {
                            rstSoumElec.Close();
                            rstSoumElec = null;
                        }
                    }
                    if (bSoumission == true)
                    {
                        if (!(rstSoumElec.Fields["MontantForfait"].Value is DBNull))
                        {
                           lblForfaitElecSoum.Text=rstSoumElec.Fields["MontantForfait"].Value;
                        }
                        else
                        {
                            lblForfaitElecSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsDessin"].Value is DBNull))
                        {
                            lblHeuresElecDessinSoum.Text=rstSoumElec.Fields["TempsDessin"].Value;
                            lblArgentElecDessinSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsDessin"].Value) * double.Parse(rstSoumElec.Fields["TauxDessin"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecDessinSoum.Text="0";
                            lblArgentElecDessinSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsFabrication"].Value is DBNull))
                        {
                            lblHeuresElecFabricationSoum .Text=rstSoumElec.Fields["TempsFabrication"].Value;
                            lblArgentElecFabricationSoum.Text = $"{double.Parse(rstSoumElec.Fields["TempsFabrication"].Value) * double.Parse(rstSoumElec.Fields["TauxFabrication"].Value)}";
                        }
                        else
                        {
                            lblHeuresElecFabricationSoum.Text="0";
                            lblArgentElecFabricationSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsAssemblage"].Value is DBNull))
                        {
                            lblHeuresElecAssemblageSoum .Text=rstSoumElec.Fields["TempsAssemblage"].Value;
                            lblArgentElecAssemblageSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsAssemblage"].Value) * double.Parse(rstSoumElec.Fields["TauxAssemblage"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecAssemblageSoum.Text="0";
                            lblArgentElecAssemblageSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsProgInterface"].Value is DBNull))
                        {
                            lblHeuresElecProgInterfaceSoum .Text=rstSoumElec.Fields["TempsProgInterface"].Value;
                            lblArgentElecProgInterfaceSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsProgInterface"].Value) * double.Parse(rstSoumElec.Fields["TauxProgInterface"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecProgInterfaceSoum.Text="0";
                            lblArgentElecProgInterfaceSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsProgAutomate"].Value is DBNull))
                        {
                            lblHeuresElecProgAutomateSoum .Text=rstSoumElec.Fields["TempsProgAutomate"].Value;
                            lblArgentElecProgAutomateSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsProgAutomate"].Value) * double.Parse(rstSoumElec.Fields["TauxProgAutomate"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecProgAutomateSoum.Text="0";
                            lblArgentElecProgAutomateSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsProgRobot"].Value is DBNull))
                        {
                            lblHeuresElecProgRobotSoum .Text=rstSoumElec.Fields["TempsProgRobot"].Value;
                            lblArgentElecProgRobotSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsProgRobot"].Value) * double.Parse(rstSoumElec.Fields["TauxProgRobot"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecProgRobotSoum.Text="0";
                            lblArgentElecProgRobotSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsVision"].Value is DBNull))
                        {
                            lblHeuresElecVisionSoum .Text=rstSoumElec.Fields["TempsVision"].Value;
                            lblArgentElecVisionSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsVision"].Value) * double.Parse(rstSoumElec.Fields["TauxVision"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecVisionSoum.Text="0";
                            lblArgentElecVisionSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsTest"].Value is DBNull))
                        {
                            lblHeuresElecTestSoum .Text=rstSoumElec.Fields["TempsTest"].Value;
                            lblArgentElecTestSoum.Text   = (double.Parse($"{rstSoumElec.Fields["TempsTest"].Value}") * double.Parse(rstSoumElec.Fields["TauxTest"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecTestSoum .Text=rstSoumElec.Fields["TempsTest"].Value;
                            lblArgentElecTestSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsTest"].Value) * double.Parse(rstSoumElec.Fields["TauxTest"].Value)).ToString();
                        }
                        if (!(rstSoumElec.Fields["TempsInstallation"].Value is DBNull))
                        {
                            lblHeuresElecInstallationSoum .Text=rstSoumElec.Fields["TempsInstallation"].Value;
                            lblArgentElecInstallationSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsInstallation"].Value) * double.Parse(rstSoumElec.Fields["TauxInstallation"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecInstallationSoum.Text="0";
                            lblArgentElecInstallationSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsMiseService"].Value is DBNull))
                        {
                            lblHeuresElecMiseServiceSoum .Text=rstSoumElec.Fields["TempsMiseService"].Value;
                            lblArgentElecMiseServiceSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsMiseService"].Value) * double.Parse(rstSoumElec.Fields["TauxMiseService"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecMiseServiceSoum.Text="0";
                            lblArgentElecMiseServiceSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsFormation"].Value is DBNull))
                        {
                            lblHeuresElecFormationSoum .Text=rstSoumElec.Fields["TempsFormation"].Value;
                            lblArgentElecFormationSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsFormation"].Value) * double.Parse(rstSoumElec.Fields["TauxFormation"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecFormationSoum.Text="0";
                            lblArgentElecFormationSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsGestion"].Value is DBNull))
                        {
                            lblHeuresElecGestionSoum .Text=rstSoumElec.Fields["TempsGestion"].Value;
                            lblArgentElecGestionSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsGestion"].Value) * double.Parse(rstSoumElec.Fields["TauxGestion"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecGestionSoum.Text="0";
                            lblArgentElecGestionSoum.Text="0";
                        }
                        if (!(rstSoumElec.Fields["TempsShipping"].Value is DBNull))
                        {
                            lblHeuresElecShippingSoum .Text=rstSoumElec.Fields["TempsShipping"].Value;
                            lblArgentElecShippingSoum.Text   = (double.Parse(rstSoumElec.Fields["TempsShipping"].Value) * double.Parse(rstSoumElec.Fields["TauxShipping"].Value)).ToString();
                        }
                        else
                        {
                            lblHeuresElecShippingSoum.Text="0";
                            lblArgentElecShippingSoum.Text="0";
                        }
                        lblPiecesElecSoum .Text=rstSoumElec.Fields["total_piece"].Value;
                        lblImprevuElecSoum .Text=rstSoumElec.Fields["total_imprevue"].Value;
                        if (!(rstSoumElec.Fields["NbrePersonne"].Value is DBNull))
                        {
                            iNbrePersonne = int.Parse(rstSoumElec.Fields["NbrePersonne"].Value);
                        }
                        else
                        {
                            iNbrePersonne = 0;
                        }
                        while (iNbrePersonne > 0)
                        {
                            if (iNbrePersonne >= 2)
                            {
                                dblHebergement += double.Parse(rstSoumElec.Fields["TempsHebergement"].Value) * double.Parse(rstSoumElec.Fields["TauxHebergement2"].Value) * iNbrePersonne;
                                iNbrePersonne -= 2;
                            }
                            else
                            {
                                dblHebergement += double.Parse(rstSoumElec.Fields["TempsHebergement"].Value) * double.Parse(rstSoumElec.Fields["TauxHebergement1"].Value) * iNbrePersonne; ;
                                iNbrePersonne -= 1;
                            }
                        }
                        if (!(rstSoumElec.Fields["TempsRepas"].Value is DBNull))
                        {
                            dblRepas = double.Parse(rstSoumElec.Fields["TempsRepas"].Value) * double.Parse(rstSoumElec.Fields["TauxRepas"].Value) * double.Parse(rstSoumElec.Fields["NbrePersonne"].Value);
                        }
                        else
                        {
                            dblRepas = 0d;
                        }
                        if (!(rstSoumElec.Fields["TempsTransport"].Value is DBNull))
                        {
                            dblTransport = double.Parse(rstSoumElec.Fields["TempsTransport"].Value) * double.Parse(rstSoumElec.Fields["TauxTransport"].Value);
                        }
                        else
                        {
                            dblTransport = 0d;
                        }
                        if (!(rstSoumElec.Fields["TempsUniteMobile"].Value is DBNull))
                        {
                            dblUniteMobile = double.Parse(rstSoumElec.Fields["TempsUniteMobile"].Value) * double.Parse(rstSoumElec.Fields["TauxUniteMobile"].Value);
                        }
                        else
                        {
                            dblUniteMobile = 0d;
                        }
                        if (!(rstSoumElec.Fields["PrixEmballage"].Value is DBNull))
                        {
                            dblPrixEmballage = double.Parse(rstSoumElec.Fields["PrixEmballage"].Value);
                        }
                        else
                        {
                            dblPrixEmballage = 0d;
                        }
                        dblTotalResteTemps = dblHebergement + dblRepas + dblTransport + dblUniteMobile + dblPrixEmballage;
                        if (IsNumeric(rstSoumElec.Fields["total_manuel"].Value))
                        {
                            dblTotalManuel = double.Parse(rstSoumElec.Fields["total_manuel"].Value);
                        }
                        else
                        {
                            dblTotalManuel = 0d;
                        }
                        lblAutresElecSoum.Text = (dblTotalResteTemps + dblTotalManuel).ToString();
                        rstSoumElec.Close();
                        rstSoumElec = null;
                    }
                    else
                    {
                        lblHeuresElecDessinSoum.Text = "0.00";
                        lblArgentElecDessinSoum.Text = "0.00";
                        lblHeuresElecFabricationSoum.Text = "0.00";
                        lblArgentElecFabricationSoum.Text = "0.00";
                        lblHeuresElecAssemblageSoum.Text = "0.00";
                        lblArgentElecAssemblageSoum.Text = "0.00";
                        lblHeuresElecProgInterfaceSoum.Text = "0.00";
                        lblArgentElecProgInterfaceSoum.Text = "0.00";
                        lblHeuresElecProgAutomateSoum.Text = "0.00";
                        lblArgentElecProgAutomateSoum.Text = "0.00";
                        lblHeuresElecProgRobotSoum.Text = "0.00";
                        lblArgentElecProgRobotSoum.Text = "0.00";
                        lblHeuresElecVisionSoum.Text = "0.00";
                        lblArgentElecVisionSoum.Text = "0.00";
                        lblHeuresElecTestSoum.Text = "0.00";
                        lblArgentElecTestSoum.Text = "0.00";
                        lblHeuresElecInstallationSoum.Text = "0.00";
                        lblArgentElecInstallationSoum.Text = "0.00";
                        lblHeuresElecMiseServiceSoum.Text = "0.00";
                        lblArgentElecMiseServiceSoum.Text = "0.00";
                        lblHeuresElecFormationSoum.Text = "0.00";
                        lblArgentElecFormationSoum.Text = "0.00";
                        lblHeuresElecGestionSoum.Text = "0.00";
                        lblArgentElecGestionSoum.Text = "0.00";
                        lblHeuresElecGestionSoum.Text = "0.00";
                        lblArgentElecGestionSoum.Text = "0.00";
                        lblPiecesElecSoum.Text = "0.00";
                        lblImprevuElecSoum.Text = "0.00";
                        lblAutresElecSoum.Text = "0.00";
                    }
                    RemplirTempsReelsElec("E" + noProjet);
                    if (!(rstProjetElec.Fields["MontantForfait"].Value is DBNull)) { lblForfaitElecProj.Text =rstProjetElec.Fields["MontantForfait"].Value; } else { lblForfaitElecProj.Text="0"; }
                    if (!(rstProjetElec.Fields["TauxDessin"].Value is DBNull)) { lblArgentElecDessinProj.Text   = (double.Parse(lblHeuresElecDessinProj.Text) * 50).ToString(); } else { lblArgentElecDessinProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxFabrication"].Value is DBNull)) { lblArgentElecFabricationProj.Text   = (double.Parse(lblHeuresElecFabricationProj.Text) * 50).ToString(); } else { lblArgentElecFabricationProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxAssemblage"].Value is DBNull)) { lblArgentElecAssemblageProj.Text   = (double.Parse(lblHeuresElecAssemblageProj.Text) * 50).ToString(); } else { lblArgentElecAssemblageProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxProgInterface"].Value is DBNull)) { lblArgentElecProgInterfaceProj.Text   = (double.Parse(lblHeuresElecProgInterfaceProj.Text) * 50).ToString(); } else { lblArgentElecProgInterfaceProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxProgAutomate"].Value is DBNull)) { lblArgentElecProgAutomateProj.Text   = (double.Parse(lblHeuresElecProgAutomateProj.Text) * 50).ToString(); } else { lblArgentElecProgAutomateProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxProgRobot"].Value is DBNull)) { lblArgentElecProgRobotProj.Text   = (double.Parse(lblHeuresElecProgRobotProj.Text) * 50).ToString(); } else { lblArgentElecProgRobotProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxVision"].Value is DBNull)) { lblArgentElecVisionProj.Text   = (double.Parse(lblHeuresElecVisionProj.Text) * 50).ToString(); } else { lblArgentElecVisionProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxTest"].Value is DBNull)) { lblArgentElecTestProj.Text   = (double.Parse(lblHeuresElecTestProj.Text) * 50).ToString(); } else { lblArgentElecTestProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxInstallation"].Value is DBNull)) { lblArgentElecInstallationProj.Text   = (double.Parse(lblHeuresElecInstallationProj.Text) * 50).ToString(); } else { lblArgentElecInstallationProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxMiseService"].Value is DBNull)) { lblArgentElecMiseServiceProj.Text   = (double.Parse(lblHeuresElecMiseServiceProj.Text) * 50).ToString(); } else { lblArgentElecMiseServiceProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxFormation"].Value is DBNull)) { lblArgentElecFormationProj.Text   = (double.Parse(lblHeuresElecFormationProj.Text) * 50).ToString(); } else { lblArgentElecFormationProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxGestion"].Value is DBNull)) { lblArgentElecGestionProj.Text   = (double.Parse(lblHeuresElecGestionProj.Text) * 50).ToString(); } else { lblArgentElecGestionProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxShipping"].Value is DBNull)) { lblArgentElecShippingProj.Text   = (double.Parse(lblHeuresElecShippingProj.Text) * 50).ToString(); } else { lblArgentElecShippingProj.Text  = "0"; }
                    if (!(rstProjetElec.Fields["TauxGestion"].Value is DBNull)) { lblArgentElecRechercheProj.Text   = (double.Parse(lblHeuresElecRechercheProj.Text) * 50).ToString(); } else { lblArgentElecRechercheProj.Text  = "0"; }
                    rstProjetPieces = new Recordset();
                    {
                        rstProjetPieces.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = 'E" + noProjet + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        while (!rstProjetPieces.EOF)
                        {
                            if (!string.IsNullOrEmpty($"{rstProjetPieces.Fields["Prix_total"].Value}".Trim()))
                            {
                                dblTotalPieces += double.Parse(rstProjetPieces.Fields["Prix_total"].Value) - double.Parse(rstProjetPieces.Fields["Profit_Argent"].Value);
                            }
                            rstProjetPieces.MoveNext();
                        }
                        rstProjetPieces.Close();
                        rstProjetPieces = null;
                        lblPiecesElecProj.Text = dblTotalPieces.ToString();
                        lblImprevuElecProj.Text  = "0";
                        if (!(rstProjetElec.Fields["PrixEmballage"].Value is DBNull)) { dblPrixEmballage = double.Parse(rstProjetElec.Fields["PrixEmballage"].Value); } else { dblPrixEmballage = 0d; }
                        dblTotalResteTemps = dblPrixEmballage;
                        if (IsNumeric(rstProjetElec.Fields["total_manuel"].Value)) { dblTotalManuel = double.Parse(rstProjetElec.Fields["total_manuel"].Value); } else { dblTotalManuel = 0d; }
                        lblAutresElecProj.Text = (dblTotalResteTemps + dblTotalManuel).ToString();
                        if (lblHeuresElecDessinSoum.Text!= "0.00") { dblTotal = double.Parse(lblHeuresElecDessinSoum.Text) + double.Parse(lblHeuresElecFabricationSoum.Text) + double.Parse(lblHeuresElecAssemblageSoum.Text) + double.Parse(lblHeuresElecProgInterfaceSoum.Text) + double.Parse(lblHeuresElecProgAutomateSoum.Text) + double.Parse(lblHeuresElecProgRobotSoum.Text) + double.Parse(lblHeuresElecVisionSoum.Text) + double.Parse(lblHeuresElecTestSoum.Text) + double.Parse(lblHeuresElecInstallationSoum.Text) + double.Parse(lblHeuresElecMiseServiceSoum.Text) + double.Parse(lblHeuresElecFormationSoum.Text) + double.Parse(lblHeuresElecGestionSoum.Text) + double.Parse(lblHeuresElecShippingSoum.Text); lblHeuresElecTotalSoum.Text = dblTotal.ToString(); } else { lblHeuresElecTotalSoum.Text = "0.00"; }
                        if (lblArgentElecDessinSoum.Text!= "0.00") 
                        { dblTotal = double.Parse(lblArgentElecDessinSoum.Text) + double.Parse(lblArgentElecFabricationSoum.Text) 
                                + double.Parse(lblArgentElecAssemblageSoum.Text) + double.Parse(lblArgentElecProgInterfaceSoum.Text) 
                                + double.Parse(lblArgentElecProgAutomateSoum.Text) + double.Parse(lblArgentElecProgRobotSoum.Text) 
                                + double.Parse(lblArgentElecVisionSoum.Text) + double.Parse(lblArgentElecTestSoum.Text) 
                                + double.Parse(lblArgentElecInstallationSoum.Text) + double.Parse(lblArgentElecMiseServiceSoum.Text) 
                                + double.Parse(lblArgentElecFormationSoum.Text) + double.Parse(lblArgentElecGestionSoum.Text) 
                                + double.Parse(lblArgentElecShippingSoum.Text); lblArgentElecTotalSoum.Text = dblTotal.ToString(); 
                        } else { lblArgentElecTotalSoum.Text = "0.00"; }
                        dblTotal = double.Parse(lblHeuresElecDessinProj.Text) + double.Parse(lblHeuresElecFabricationProj.Text) 
                            + double.Parse(lblHeuresElecAssemblageProj.Text) + double.Parse(lblHeuresElecProgInterfaceProj.Text) 
                            + double.Parse(lblHeuresElecProgAutomateProj.Text) + double.Parse(lblHeuresElecProgRobotProj.Text) 
                            + double.Parse(lblHeuresElecVisionProj.Text) + double.Parse(lblHeuresElecTestProj.Text) 
                            + double.Parse(lblHeuresElecInstallationProj.Text) + double.Parse(lblHeuresElecMiseServiceProj.Text) 
                            + double.Parse(lblHeuresElecFormationProj.Text) + double.Parse(lblHeuresElecGestionProj.Text) 
                            + double.Parse(lblHeuresElecShippingProj.Text) + double.Parse(lblHeuresElecRechercheProj.Text); 
                        lblHeuresElecTotalProj.Text = dblTotal.ToString(); 
                        dblTotal = double.Parse(lblArgentElecDessinProj.Text) + double.Parse(lblArgentElecFabricationProj.Text) 
                            + double.Parse(lblArgentElecAssemblageProj.Text) + double.Parse(lblArgentElecProgInterfaceProj.Text) 
                            + double.Parse(lblArgentElecProgAutomateProj.Text) + double.Parse(lblArgentElecProgRobotProj.Text) 
                            + double.Parse(lblArgentElecVisionProj.Text) + double.Parse(lblArgentElecTestProj.Text) 
                            + double.Parse(lblArgentElecInstallationProj.Text) + double.Parse(lblArgentElecMiseServiceProj.Text) 
                            + double.Parse(lblArgentElecFormationProj.Text) + double.Parse(lblArgentElecGestionProj.Text) 
                            + double.Parse(lblArgentElecShippingProj.Text) + double.Parse(lblArgentElecRechercheProj.Text); 
                        lblArgentElecTotalProj.Text = dblTotal.ToString();
                        if (lblArgentElecTotalSoum.Text != "0.00") {
                            dblTotal = double.Parse(lblArgentElecTotalSoum.Text) + double.Parse(lblPiecesElecSoum.Text) 
                                + double.Parse(lblImprevuElecSoum.Text) + double.Parse(lblAutresElecSoum.Text); 
                            lblTotalElecSoum0.Text = dblTotal.ToString(); 
                        } else { lblTotalElecSoum0.Text = "0.00"; }
                        dblTotal = double.Parse(lblArgentElecTotalProj.Text) + double.Parse(lblPiecesElecProj.Text) 
                            + double.Parse(lblImprevuElecProj.Text) + double.Parse(lblAutresElecProj.Text);
                        lblTotalElecProj0.Text = dblTotal.ToString();
                    }
                    rstProjetElec.Close();
                    rstProjetElec = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ViewAppercuProjet", "RemplirRapportElectrique", ex);
            }
        }
        private void RemplirRapportMecanique(string noProjet)
        {
            try
            {
                ADODB.Recordset rstProjetMec;
                var rstSoumMec = default(ADODB.Recordset);
                ADODB.Recordset rstProjetPieces;
                double dblTotal;
                bool bSoumission;
                int iNbrePersonne;
                var dblHebergement = default(double);
                double dblRepas;
                double dblTransport;
                double dblUniteMobile;
                double dblPrixEmballage;
                double dblTotalResteTemps;
                double dblTotalManuel;
                var dblTotalPieces = default(double);
                rstProjetMec = new Recordset();
                rstProjetMec.Open("SELECT * FROM ProjetMec WHERE IDProjet = 'M" + noProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
//                lblProjetMec.Text = "M" + noProjet;
                if (!rstProjetMec.EOF)
                {
                    bSoumission = false;
                    if (!(rstProjetMec.Fields["IDSoumission"].Value is DBNull))
                    {
                        rstSoumMec = new Recordset();
                        rstSoumMec.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM SoumissionMec WHERE IDSoumission = '", rstProjetMec.Fields["IDSoumission"].Value), "'"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstSoumMec.EOF) { bSoumission = true; } else { rstSoumMec.Close(); rstSoumMec = null; }
                    }
                    if (bSoumission == true)
                    {
                        if (!(rstSoumMec.Fields["MontantForfait"].Value is DBNull)) { lblForfaitMecSoum.Text = rstSoumMec.Fields["MontantForfait"].Value; } else { lblForfaitMecSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsDessin"].Value is DBNull)) { lblHeuresMecDessinSoum.Text = rstSoumMec.Fields["TempsDessin"].Value; lblArgentMecDessinSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsDessin"].Value) * double.Parse(rstSoumMec.Fields["TauxDessin"].Value)).ToString(); } else { lblHeuresMecDessinSoum.Text  = "0"; lblArgentMecDessinSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsCoupe"].Value is DBNull)) { lblHeuresMecCoupeSoum.Text = rstSoumMec.Fields["TempsCoupe"].Value; lblArgentMecCoupeSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsCoupe"].Value) * double.Parse(rstSoumMec.Fields["TauxCoupe"].Value)).ToString(); } else { lblHeuresMecCoupeSoum.Text  = "0"; lblArgentMecCoupeSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsMachinage"].Value is DBNull)) { lblHeuresMecMachinageSoum.Text = rstSoumMec.Fields["TempsMachinage"].Value; lblArgentMecMachinageSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsMachinage"].Value) * double.Parse(rstSoumMec.Fields["TauxMachinage"].Value)).ToString(); } else { lblHeuresMecMachinageSoum.Text  = "0"; lblArgentMecMachinageSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsSoudure"].Value is DBNull)) { lblHeuresMecSoudureSoum.Text = rstSoumMec.Fields["TempsSoudure"].Value; lblArgentMecSoudureSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsSoudure"].Value) * double.Parse(rstSoumMec.Fields["TauxSoudure"].Value)).ToString(); } else { lblHeuresMecSoudureSoum.Text  = "0"; lblArgentMecSoudureSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsAssemblage"].Value is DBNull)) { lblHeuresMecAssemblageSoum.Text = rstSoumMec.Fields["TempsAssemblage"].Value; lblArgentMecAssemblageSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsAssemblage"].Value) * double.Parse(rstSoumMec.Fields["TauxAssemblage"].Value)).ToString(); } else { lblHeuresMecAssemblageSoum.Text  = "0"; lblArgentMecAssemblageSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsPeinture"].Value is DBNull)) { lblHeuresMecPeintureSoum.Text = rstSoumMec.Fields["TempsPeinture"].Value; lblArgentMecPeintureSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsPeinture"].Value) * double.Parse(rstSoumMec.Fields["TauxPeinture"].Value)).ToString(); } else { lblHeuresMecPeintureSoum.Text  = "0"; lblArgentMecPeintureSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsTest"].Value is DBNull)) { lblHeuresMecTestSoum.Text = rstSoumMec.Fields["TempsTest"].Value; lblArgentMecTestSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsTest"].Value) * double.Parse(rstSoumMec.Fields["TauxTest"].Value)).ToString(); } else { lblHeuresMecTestSoum.Text  = "0"; lblArgentMecTestSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsInstallation"].Value is DBNull)) { lblHeuresMecInstallationSoum.Text = rstSoumMec.Fields["TempsInstallation"].Value; lblArgentMecInstallationSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsInstallation"].Value) * double.Parse(rstSoumMec.Fields["TauxInstallation"].Value)).ToString(); } else { lblHeuresMecInstallationSoum.Text  = "0"; lblArgentMecInstallationSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsFormation"].Value is DBNull)) { lblHeuresMecFormationSoum.Text = rstSoumMec.Fields["TempsFormation"].Value; lblArgentMecFormationSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsFormation"].Value) * double.Parse(rstSoumMec.Fields["TauxFormation"].Value)).ToString(); } else { lblHeuresMecFormationSoum.Text  = "0"; lblArgentMecFormationSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsGestion"].Value is DBNull)) { lblHeuresMecGestionSoum.Text = rstSoumMec.Fields["TempsGestion"].Value; lblArgentMecGestionSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsGestion"].Value) * double.Parse(rstSoumMec.Fields["TauxGestion"].Value)).ToString(); } else { lblHeuresMecGestionSoum.Text  = "0"; lblArgentMecGestionSoum.Text  = "0"; }
                        if (!(rstSoumMec.Fields["TempsShipping"].Value is DBNull)) { lblHeuresMecShippingSoum.Text = rstSoumMec.Fields["TempsShipping"].Value; lblArgentMecShippingSoum.Text   = (double.Parse(rstSoumMec.Fields["TempsShipping"].Value) * double.Parse(rstSoumMec.Fields["TauxShipping"].Value)).ToString(); } else { lblHeuresMecShippingSoum.Text  = "0"; lblArgentMecShippingSoum.Text  = "0"; }
                        lblPiecesMecSoum.Text = rstSoumMec.Fields["total_piece"].Value;
                        lblImprevuMecSoum.Text = rstSoumMec.Fields["total_imprevue"].Value;
                        iNbrePersonne = int.Parse(rstSoumMec.Fields["NbrePersonne"].Value);
                        while (iNbrePersonne > 0)
                        {
                            if (iNbrePersonne >= 2)
                            {
                                dblHebergement = double.Parse(Operators.AddObject(dblHebergement, Operators.MultiplyObject(rstSoumMec.Fields["TempsHebergement"].Value, rstSoumMec.Fields["TauxHebergement2"].Value)));
                                iNbrePersonne = (int)(iNbrePersonne - 2);
                            }
                            else
                            {
                                dblHebergement = double.Parse(Operators.AddObject(dblHebergement, Operators.MultiplyObject(rstSoumMec.Fields["TempsHebergement"].Value, rstSoumMec.Fields["TauxHebergement1"].Value)));
                                iNbrePersonne = (int)(iNbrePersonne - 1);
                            }
                        }
                        dblRepas = double.Parse(rstSoumMec.Fields["TempsRepas"].Value) * double.Parse(rstSoumMec.Fields["TauxRepas"].Value) * double.Parse(rstSoumMec.Fields["NbrePersonne"].Value);
                        dblTransport = double.Parse(rstSoumMec.Fields["TempsTransport"].Value) * double.Parse(rstSoumMec.Fields["TauxTransport"].Value);
                        dblUniteMobile = double.Parse(rstSoumMec.Fields["TempsUniteMobile"].Value) * double.Parse(rstSoumMec.Fields["TauxUniteMobile"].Value);
                        if (IsNumeric(rstSoumMec.Fields["PrixEmballage"].Value)) { dblPrixEmballage = double.Parse(rstSoumMec.Fields["PrixEmballage"].Value); } else { dblPrixEmballage = 0d; }
                        dblTotalResteTemps = dblHebergement + dblRepas + dblTransport + dblUniteMobile + dblPrixEmballage;
                        if (IsNumeric(rstSoumMec.Fields["total_manuel"].Value)) { dblTotalManuel = double.Parse(rstSoumMec.Fields["total_manuel"].Value); } else { dblTotalManuel = 0d; }
                        lblAutresMecSoum.Text = (dblTotalResteTemps + dblTotalManuel).ToString();
                        rstSoumMec.Close();
                        rstSoumMec = null;
                    }
                    else
                    {
                        lblHeuresMecDessinSoum.Text  = "0.00";
                        lblArgentMecDessinSoum.Text  = "0.00";
                        lblHeuresMecCoupeSoum.Text  = "0.00";
                        lblArgentMecCoupeSoum.Text  = "0.00";
                        lblHeuresMecMachinageSoum.Text  = "0.00";
                        lblArgentMecMachinageSoum.Text  = "0.00";
                        lblHeuresMecSoudureSoum.Text  = "0.00";
                        lblArgentMecSoudureSoum.Text  = "0.00";
                        lblHeuresMecAssemblageSoum.Text  = "0.00";
                        lblArgentMecAssemblageSoum.Text  = "0.00";
                        lblHeuresMecPeintureSoum.Text  = "0.00";
                        lblArgentMecPeintureSoum.Text  = "0.00";
                        lblHeuresMecTestSoum.Text  = "0.00";
                        lblArgentMecTestSoum.Text  = "0.00";
                        lblHeuresMecInstallationSoum.Text  = "0.00";
                        lblArgentMecInstallationSoum.Text  = "0.00";
                        lblHeuresMecFormationSoum.Text  = "0.00";
                        lblArgentMecFormationSoum.Text  = "0.00";
                        lblHeuresMecGestionSoum.Text  = "0.00";
                        lblArgentMecGestionSoum.Text  = "0.00";
                        lblHeuresMecShippingSoum.Text  = "0.00";
                        lblArgentMecShippingSoum.Text  = "0.00";
                        lblPiecesMecSoum.Text  = "0.00";
                        lblImprevuMecSoum.Text  = "0.00";
                        lblAutresMecSoum.Text  = "0.00";
                    }
                    RemplirTempsReelsMec("M" + noProjet);
                    if (!(rstProjetMec.Fields["MontantForfait"].Value is DBNull)) { lblForfaitMecProj.Text = rstProjetMec.Fields["MontantForfait"].Value; } else { lblForfaitMecProj.Text  = "0"; }
                    if (!(rstProjetMec.Fields["TauxDessin"].Value is DBNull)) { lblArgentMecDessinProj.Text   = (double.Parse(lblHeuresMecDessinProj.Text) * 50).ToString(); } else { lblArgentMecDessinProj.Text  = "0"; }
                    if (!(rstProjetMec.Fields["TauxCoupe"].Value is DBNull))
                    {
                        if (!(rstProjetMec.Fields["TauxMachinage"].Value is DBNull)) { lblArgentMecMachinageProj.Text   = (double.Parse(lblHeuresMecMachinageProj.Text) * 50).ToString(); } else { lblArgentMecMachinageProj.Text  = "0"; }
                        if (!(rstProjetMec.Fields["TauxSoudure"].Value is DBNull)) { lblArgentMecSoudureProj.Text   = (double.Parse(lblHeuresMecSoudureProj.Text) * 50).ToString(); } else { lblArgentMecSoudureProj.Text  = "0"; }
                        if (!(rstProjetMec.Fields["TauxAssemblage"].Value is DBNull)) { lblArgentMecAssemblageProj.Text   = (double.Parse(lblHeuresMecAssemblageProj.Text) * 50).ToString(); } else { lblArgentMecAssemblageProj.Text  = "0"; }
                        if (!(rstProjetMec.Fields["TauxPeinture"].Value is DBNull)) { lblArgentMecPeintureProj.Text   = (double.Parse(lblHeuresMecPeintureProj.Text) * 50).ToString(); } else { lblArgentMecPeintureProj.Text  = "0"; }
                        if (!(rstProjetMec.Fields["TauxTest"].Value is DBNull)) { lblArgentMecTestProj.Text   = (double.Parse(lblHeuresMecTestProj.Text) * 50).ToString(); } else { lblArgentMecTestProj.Text  = "0"; }
                        if (!(rstProjetMec.Fields["TauxInstallation"].Value is DBNull)) { lblArgentMecInstallationProj.Text   = (double.Parse(lblHeuresMecInstallationProj.Text) * 50).ToString(); } else { lblArgentMecInstallationProj.Text  = "0"; }
                        if (!(rstProjetMec.Fields["TauxFormation"].Value is DBNull)) { lblArgentMecFormationProj.Text   = (double.Parse(lblHeuresMecFormationProj.Text) * 50).ToString(); } else { lblArgentMecFormationProj.Text  = "0"; }
                        if (!(rstProjetMec.Fields["TauxGestion"].Value is DBNull)) { lblArgentMecGestionProj.Text   = (double.Parse(lblHeuresMecGestionProj.Text) * 50).ToString(); } else { lblArgentMecGestionProj.Text  = "0"; }
                        if (!(rstProjetMec.Fields["TauxShipping"].Value is DBNull)) { lblArgentMecShippingProj.Text   = (double.Parse(lblHeuresMecShippingProj.Text) * 50).ToString(); } else { lblArgentMecShippingProj.Text  = "0"; }
                        if (!(rstProjetMec.Fields["TauxGestion"].Value is DBNull)) { lblArgentMecRechercheProj.Text   = (double.Parse(lblHeuresMecRechercheProj.Text) * 50).ToString(); } else { lblArgentMecRechercheProj.Text  = "0"; }
                        rstProjetPieces = new Recordset();
                        rstProjetPieces.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = 'M" + noProjet + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                        while (!rstProjetPieces.EOF)
                        {
                            if (!string.IsNullOrEmpty($"{rstProjetPieces.Fields["Prix_total"].Value}".Trim()))
                            {
                                dblTotalPieces += double.Parse(rstProjetPieces.Fields["Prix_total"].Value) - double.Parse(rstProjetPieces.Fields["Profit_argent"].Value);
                            }
                            rstProjetPieces.MoveNext();
                        }
                        rstProjetPieces.Close();
                        rstProjetPieces = null;
                        lblPiecesMecProj.Text = dblTotalPieces.ToString();
                        lblImprevuMecProj.Text = 0.ToString();
                        if (IsNumeric(rstProjetMec.Fields["PrixEmballage"].Value)) { dblPrixEmballage = double.Parse(rstProjetMec.Fields["PrixEmballage"].Value); } else { dblPrixEmballage = 0d; }
                        dblTotalResteTemps = dblPrixEmballage;
                        if (IsNumeric(rstProjetMec.Fields["total_manuel"].Value)) { dblTotalManuel = double.Parse(rstProjetMec.Fields["total_manuel"].Value); } else { dblTotalManuel = 0d; }
                        lblAutresMecProj.Text = (dblTotalResteTemps + dblTotalManuel).ToString();
                        if (lblHeuresMecDessinSoum.Text!= "0.00")
                        {
                            dblTotal = double.Parse(lblHeuresMecDessinSoum.Text)
                                + double.Parse(lblHeuresMecCoupeSoum.Text)
                                + double.Parse(lblHeuresMecMachinageSoum.Text)
                                + double.Parse(lblHeuresMecSoudureSoum.Text)
                                + double.Parse(lblHeuresMecAssemblageSoum.Text)
                                + double.Parse(lblHeuresMecPeintureSoum.Text)
                                + double.Parse(lblHeuresMecTestSoum.Text)
                                + double.Parse(lblHeuresMecInstallationSoum.Text)
                                + double.Parse(lblHeuresMecFormationSoum.Text)
                                + double.Parse(lblHeuresMecGestionSoum.Text)
                                + double.Parse(lblHeuresMecShippingSoum.Text);
                            lblHeuresMecTotalSoum.Text = dblTotal.ToString();
                        }
                        else
                        {
                            lblHeuresMecTotalSoum.Text  = "0.00";
                        }
                        if (lblArgentMecDessinSoum.Text != "0.00")
                        {
                            dblTotal = double.Parse(lblArgentMecDessinSoum.Text)
                                + double.Parse(lblArgentMecCoupeSoum.Text)
                                + double.Parse(lblArgentMecMachinageSoum.Text)
                                + double.Parse(lblArgentMecSoudureSoum.Text)
                                + double.Parse(lblArgentMecAssemblageSoum.Text)
                                + double.Parse(lblArgentMecPeintureSoum.Text)
                                + double.Parse(lblArgentMecTestSoum.Text)
                                + double.Parse(lblArgentMecInstallationSoum.Text)
                                + double.Parse(lblArgentMecFormationSoum.Text)
                                + double.Parse(lblArgentMecGestionSoum.Text)
                                + double.Parse(lblArgentMecShippingSoum.Text);
                            lblArgentMecTotalSoum.Text = dblTotal.ToString();
                        }
                        else
                        {
                            lblArgentMecTotalSoum.Text  = "0.00";
                        }
                        dblTotal = double.Parse(lblHeuresMecDessinProj.Text) + double.Parse(lblHeuresMecCoupeProj.Text) 
                            + double.Parse(lblHeuresMecMachinageProj.Text) + double.Parse(lblHeuresMecSoudureProj.Text) 
                            + double.Parse(lblHeuresMecAssemblageProj.Text) + double.Parse(lblHeuresMecPeintureProj.Text) 
                            + double.Parse(lblHeuresMecTestProj.Text) + double.Parse(lblHeuresMecInstallationProj.Text) 
                            + double.Parse(lblHeuresMecFormationProj.Text) + double.Parse(lblHeuresMecGestionProj.Text) 
                            + double.Parse(lblHeuresMecShippingProj.Text) + double.Parse(lblHeuresMecRechercheProj.Text);
                        lblHeuresMecTotalProj.Text = dblTotal.ToString();
                        dblTotal = double.Parse(lblArgentMecDessinProj.Text) + double.Parse(lblArgentMecCoupeProj.Text) 
                            + double.Parse(lblArgentMecMachinageProj.Text) + double.Parse(lblArgentMecSoudureProj.Text) 
                            + double.Parse(lblArgentMecAssemblageProj.Text) + double.Parse(lblArgentMecPeintureProj.Text) 
                            + double.Parse(lblArgentMecTestProj.Text) + double.Parse(lblArgentMecInstallationProj.Text) 
                            + double.Parse(lblArgentMecFormationProj.Text) + double.Parse(lblArgentMecGestionProj.Text) 
                            + double.Parse(lblArgentMecShippingProj.Text) + double.Parse(lblArgentMecRechercheProj.Text);
                        lblArgentMecTotalProj.Text = dblTotal.ToString();
                        if (lblArgentMecTotalSoum.Text!= "0.00")
                        {
                            dblTotal = double.Parse(lblArgentMecTotalSoum.Text) + double.Parse(lblPiecesMecSoum.Text) 
                                + double.Parse(lblImprevuMecSoum.Text) + double.Parse(lblAutresMecSoum.Text);
                            lblTotalMecSoum.Text = dblTotal.ToString();
                        }
                        else
                        {
                            lblTotalMecSoum.Text  = "0.00";
                        }
                        dblTotal = double.Parse(lblArgentMecTotalProj.Text) + double.Parse(lblPiecesMecProj.Text) 
                            + double.Parse(lblImprevuMecProj.Text) + double.Parse(lblAutresMecProj.Text);
                        lblTotalMecProj.Text = dblTotal.ToString();
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ViewApercuProjet", "RemplirRapportMecanique", ex);
            }
        }
        private void RemplirTempsReelsElec(string noProjet)
        {
            try
            {
                ADODB.Recordset rstPunch;
                string sFilterNoProjet;
                string Compile1;
                string Compile2;
                Compile1 = 0.ToString();
                Compile2 = 0.ToString();
                if (Droite(noProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(noProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + noProjet + "'";
                }
                rstPunch = new Recordset();
                rstPunch.Open("SELECT * FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null order BY Type", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                double hDebut = double.Parse($"{rstPunch.Fields["HeureDébut"].Value}".Split(':')[0]) + (double.Parse($"{rstPunch.Fields["HeureDébut"].Value}".Split(':')[1]) * 5 / 3);
                double hFin = double.Parse($"{rstPunch.Fields["HeureFin"].Value}".Split(':')[0]) + (double.Parse($"{rstPunch.Fields["HeureFin"].Value}".Split(':')[1]) * 5 / 3);
                double total = hFin - hDebut;
                lblHeuresElecDessinProj.Text  = "0";
                lblHeuresElecFabricationProj.Text  = "0";
                lblHeuresElecAssemblageProj.Text  = "0";
                lblHeuresElecProgInterfaceProj.Text  = "0";
                lblHeuresElecProgAutomateProj.Text  = "0";
                lblHeuresElecProgRobotProj.Text  = "0";
                lblHeuresElecVisionProj.Text  = "0";
                lblHeuresElecTestProj.Text  = "0";
                lblHeuresElecInstallationProj.Text  = "0";
                lblHeuresElecMiseServiceProj.Text  = "0";
                lblHeuresElecFormationProj.Text  = "0";
                lblHeuresElecGestionProj.Text  = "0";
                lblHeuresElecShippingProj.Text  = "0";
                lblHeuresElecRechercheProj.Text  = "0";
                while (!rstPunch.EOF)
                {
                    if (total!= 0  )
                    {
                        switch (rstPunch.Fields["Type"].Value)
                        {
                            case "Dessin": { lblHeuresElecDessinProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Fabrication": { lblHeuresElecFabricationProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Assemblage": { lblHeuresElecAssemblageProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "ProgInterface": { lblHeuresElecProgInterfaceProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "ProgAutomate": { lblHeuresElecProgAutomateProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "ProgRobot": { lblHeuresElecProgRobotProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Vision": { lblHeuresElecVisionProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Test": { lblHeuresElecTestProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Installation": { lblHeuresElecInstallationProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "MiseService": { lblHeuresElecMiseServiceProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Formation": { lblHeuresElecFormationProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Gestion": { lblHeuresElecGestionProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Shipping": { lblHeuresElecShippingProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Prototypage-Dévelloppement expérimental": { Compile1  =  Math.Round(total, 2).ToString(); break; }
                            case "": { Compile2  =  Math.Round(total, 2).ToString(); break; }
                        }
                    }
                    rstPunch.MoveNext();
                }
                lblHeuresElecRechercheProj.Text   = (double.Parse(Compile1) + double.Parse(Compile2)).ToString();
                rstPunch.Close();
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElecTemps", "RemplirTempsReelsElec", ex);
            }
        }
        private void RemplirTempsReelsMec(string noProjet)
        {
            try
            {
                ADODB.Recordset rstPunch = new ADODB.Recordset();
                lblHeuresMecDessinProj.Text  = "0";
                lblHeuresMecCoupeProj.Text  = "0";
                lblHeuresMecMachinageProj.Text  = "0";
                lblHeuresMecSoudureProj.Text  = "0";
                lblHeuresMecAssemblageProj.Text  = "0";
                lblHeuresMecPeintureProj.Text  = "0";
                lblHeuresMecTestProj.Text  = "0";
                lblHeuresMecInstallationProj.Text  = "0";
                lblHeuresMecFormationProj.Text  = "0";
                lblHeuresMecGestionProj.Text  = "0";
                lblHeuresMecShippingProj.Text  = "0";
                string sDateDebut;
                string sDateFin;
                string sTotal;
                string sFilterNoProjet;
                string test;
                string Compile1;
                string Compile2;
                double total;
                Compile1 = 0.ToString();
                Compile2 = 0.ToString();
                if (Droite(noProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(noProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + noProjet + "'";
                }
                rstPunch.Open("SELECT * FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null order BY Type", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                if (!rstPunch.EOF)
                {
                }
                while (!rstPunch.EOF)
                {
                double hDebut = double.Parse($"{rstPunch.Fields["HeureDébut"].Value}".Split(':')[0]) + (double.Parse($"{rstPunch.Fields["HeureDébut"].Value}".Split(':')[1]) * 5 / 3);
                double hFin = double.Parse($"{rstPunch.Fields["HeureFin"].Value}".Split(':')[0]) + (double.Parse($"{rstPunch.Fields["HeureFin"].Value}".Split(':')[1]) * 5 / 3);
                 total= hFin - hDebut;
                    if (total!= 0  )
                    {
                        switch (rstPunch.Fields["Type"].Value)
                        {
                            case "Dessin": { lblHeuresMecDessinProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Coupe": { lblHeuresMecCoupeProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Machinage": { lblHeuresMecMachinageProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Soudure": { lblHeuresMecSoudureProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Assemblage": { lblHeuresMecAssemblageProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Peinture": { lblHeuresMecPeintureProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Test": { lblHeuresMecTestProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Installation": { lblHeuresMecInstallationProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Formation": { lblHeuresMecFormationProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Gestion": { lblHeuresMecGestionProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Shipping": { lblHeuresMecShippingProj.Text  =  Math.Round(total, 2).ToString(); break; }
                            case "Prototypage-Dévelloppement expérimental": { Compile1  =  Math.Round(total, 2).ToString(); break; }
                            case "": { Compile2  =  Math.Round(total, 2).ToString(); break; }
                        }
                    }
                    rstPunch.MoveNext();
                }
                lblHeuresMecRechercheProj.Text   = (double.Parse(Compile1) + double.Parse(Compile2)).ToString();
                rstPunch.Close();
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ViewApercuProjet", "RemplirTempsReelsElec", ex);
            }
        }
        void InitDatas4Facturation(string noProjet)
        {
            string sDateDebut;
            string sDateFin;
            string sTotal;
            string sFilterNoProjet;
            string test;
            string Compile1;
            string Compile2;
            Compile1 = 0.ToString();
            Compile2 = 0.ToString();
            ADODB.Recordset rdTest = new ADODB.Recordset();
            lblNumero.Text = noProjet;
            rdTest.Open($"select NomClient, Compagnie, Telephonne,noposte, Fax,  ContactGRB," +
                $" NomContact, IDProjSoum, NoClient, DateOuverture, DateFermeture, RaisonFermeture," +
                $" Ouvert, Verrouillé, Type, Description FROM [DBO].[ProjSoum] " +
                $"JOIN [DBO].[Client] on[DBO].[ProjSoum].NoClient =[DBO].[Client].IDClient " +
                $"where right(IDProjSoum,8)='{noProjet}'", ControleurServeur.Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rdTest.EOF)
            {
                lblClient.Text = rdTest.Fields["NomClient"].Value;
                lblDescription.Text = rdTest.Fields["NomClient"].Value;
                lblDate.Text = ConvertDate(DateTime.Today);
            }
            RemplirRapportElectrique(noProjet);
            RemplirRapportMecanique(noProjet);
            lblTotalForfaitSoum.Text = dblTotal.ToString();
            lblTotalForfaitProj.Text = dblTotal.ToString();
            lblProfitProj.Text = dblTotal.ToString();
        }
        private void ViewAppercuProjet_Load(object sender, EventArgs e) => Text = $"production.grb.local/AutoGRB/Content/?viewProject&{lblNumero.Text}  [{ControleurServeur.Program.IdNomEmploye}] [{DateTime.Now.ToString()}]";
        Bitmap memoryImage;
        internal static  bool Orientation;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void label3_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            toolStripStatusLabel1.Text = $"     {ControleurServeur.Program.IdNomEmploye} {DateTime.Now.ToString()}";
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
            if (MessageBox.Show("Voulez vous fermer cette vue?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
