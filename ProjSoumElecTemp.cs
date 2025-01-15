using ADODB;
using Microsoft.VisualBasic.CompilerServices;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public class ProjSoumElecTemp : Form
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
        internal static System.Windows.Forms.ToolTip ToolTip1;
        internal static System.Windows.Forms.TextBox txtTempsprototypeSoum;
        internal static System.Windows.Forms.TextBox txtTempsShippingSoum;
        internal static System.Windows.Forms.TextBox txtTempsFormationSoum;
        internal static System.Windows.Forms.TextBox txtTempsGestionSoum;
        internal static System.Windows.Forms.TextBox txtTempsDessinSoum;
        internal static System.Windows.Forms.TextBox txtTempsAssemblageSoum;
        internal static System.Windows.Forms.TextBox txtTempsProgInterfaceSoum;
        internal static System.Windows.Forms.TextBox txtTempsProgAutomateSoum;
        internal static System.Windows.Forms.TextBox txtTempsProgRobotSoum;
        internal static System.Windows.Forms.TextBox txtTempsTestSoum;
        internal static System.Windows.Forms.TextBox txtTempsInstallationSoum;
        internal static System.Windows.Forms.TextBox txtTempsMiseServiceSoum;
        internal static System.Windows.Forms.TextBox txtTempsVisionSoum;
        internal static System.Windows.Forms.Label lblPrixPrototype;
        internal static System.Windows.Forms.Label lblTempsPrototypeReel;
        internal static System.Windows.Forms.Label Label64;
        internal static System.Windows.Forms.Label Label56;
        internal static System.Windows.Forms.Label Label55;
        internal static System.Windows.Forms.Label Label63;
        internal static System.Windows.Forms.Label Label62;
        internal static System.Windows.Forms.Label Label61;
        internal static System.Windows.Forms.Label lblTempsShippingReel;
        internal static System.Windows.Forms.Label lblPrixShipping;
        internal static System.Windows.Forms.Label Label60;
        internal static System.Windows.Forms.Label Label59;
        internal static System.Windows.Forms.Label Label57;
        internal static System.Windows.Forms.Label lblTempsFormationReel;
        internal static System.Windows.Forms.Label lblPrixFormation;
        internal static System.Windows.Forms.Label lblPrixGestion;
        internal static System.Windows.Forms.Label lblTempsGestionReel;
        internal static System.Windows.Forms.Label Label53;
        internal static System.Windows.Forms.Label Label51;
        internal static System.Windows.Forms.Label Label39;
        internal static System.Windows.Forms.Label Label1;
        internal static System.Windows.Forms.Label Label2;
        internal static System.Windows.Forms.Label Label3;
        internal static System.Windows.Forms.Label Label4;
        internal static System.Windows.Forms.Label Label5;
        internal static System.Windows.Forms.Label Label6;
        internal static System.Windows.Forms.Label Label7;
        internal static System.Windows.Forms.Label Label8;
        internal static System.Windows.Forms.Label Label9;
        internal static System.Windows.Forms.Label Label10;
        internal static System.Windows.Forms.Label Label11;
        internal static System.Windows.Forms.Label Label12;
        internal static System.Windows.Forms.Label Label13;
        internal static System.Windows.Forms.Label Label14;
        internal static System.Windows.Forms.Label Label15;
        internal static System.Windows.Forms.Label Label16;
        internal static System.Windows.Forms.Label Label17;
        internal static System.Windows.Forms.Label Label18;
        internal static System.Windows.Forms.Label Label19;
        internal static System.Windows.Forms.Label Label20;
        internal static System.Windows.Forms.Label Label21;
        internal static System.Windows.Forms.Label Label22;
        internal static System.Windows.Forms.Label Label23;
        internal static System.Windows.Forms.Label Label32;
        internal static System.Windows.Forms.Label Label40;
        internal static System.Windows.Forms.Label Label41;
        internal static System.Windows.Forms.Label Label43;
        internal static System.Windows.Forms.Label Label47;
        internal static System.Windows.Forms.Label Label49;
        internal static System.Windows.Forms.Label Label54;
        internal static System.Windows.Forms.Label Label58;
        internal static System.Windows.Forms.Label lblTempsDessinReel;
        internal static System.Windows.Forms.Label lblTempsFabricationReel;
        internal static System.Windows.Forms.Label lblTempsAssemblageReel;
        internal static System.Windows.Forms.Label lblTempsProgInterfaceReel;
        internal static System.Windows.Forms.Label lblTempsProgAutomateReel;
        internal static System.Windows.Forms.Label lblTempsProgRobotReel;
        internal static System.Windows.Forms.Label lblTempsTestReel;
        internal static System.Windows.Forms.Label lblTempsInstallationReel;
        internal static System.Windows.Forms.Label lblTempsMiseServiceReel;
        internal static System.Windows.Forms.Label Label65;
        internal static System.Windows.Forms.Label Label66;
        internal static System.Windows.Forms.Label Label67;
        internal static System.Windows.Forms.Label lblTempsVisionReel;
        internal static System.Windows.Forms.Label lblPrixDessin;
        internal static System.Windows.Forms.Label lblPrixFabrication;
        internal static System.Windows.Forms.Label lblPrixAssemblage;
        internal static System.Windows.Forms.Label lblPrixProgInterface;
        internal static System.Windows.Forms.Label lblPrixProgAutomate;
        internal static System.Windows.Forms.Label lblPrixProgRobot;
        internal static System.Windows.Forms.Label lblPrixVision;
        internal static System.Windows.Forms.Label lblPrixTest;
        internal static System.Windows.Forms.Label lblPrixInstallation;
        internal static System.Windows.Forms.Label lblPrixMiseService;
        internal static System.Windows.Forms.Label lblTempsFabricationSoum;
        internal static System.Windows.Forms.GroupBox fraRessourcesHumaines;
        internal static System.Windows.Forms.TextBox txtTempsUniteMobile;
        internal static System.Windows.Forms.TextBox txtTempsRepas;
        internal static System.Windows.Forms.TextBox txtTempsHebergement;
        internal static System.Windows.Forms.TextBox txtTempsDeplacement;
        internal static System.Windows.Forms.TextBox txtNbrePersonne;
        internal static System.Windows.Forms.Label Label27;
        internal static System.Windows.Forms.Label Label28;
        internal static System.Windows.Forms.Label Label29;
        internal static System.Windows.Forms.Label Label30;
        internal static System.Windows.Forms.Label Label34;
        internal static System.Windows.Forms.Label Label35;
        internal static System.Windows.Forms.Label Label36;
        internal static System.Windows.Forms.Label Label37;
        internal static System.Windows.Forms.Label Label38;
        internal static System.Windows.Forms.Label Label42;
        internal static System.Windows.Forms.Label Label44;
        internal static System.Windows.Forms.Label Label45;
        internal static System.Windows.Forms.Label Label46;
        internal static System.Windows.Forms.Label Label31;
        internal static System.Windows.Forms.Label lblPrixHebergement;
        internal static System.Windows.Forms.Label lblPrixRepas;
        internal static System.Windows.Forms.Label lblPrixDeplacement;
        internal static System.Windows.Forms.Label lblPrixUniteMobile;
        internal static System.Windows.Forms.GroupBox fraFraisSubsistences;
        internal static System.Windows.Forms.TextBox txtPrixEmballage;
        internal static System.Windows.Forms.Label Label24;
        internal static System.Windows.Forms.Label Label33;
        internal static System.Windows.Forms.Label Label48;
        internal static System.Windows.Forms.GroupBox fraManutention;
        internal static System.Windows.Forms.Button cmdFermer;
        internal static System.Windows.Forms.Button cmdDetail;
        internal static System.Windows.Forms.Label Label52;
        internal static System.Windows.Forms.Label Label25;
        internal static System.Windows.Forms.Label Label26;
        internal static System.Windows.Forms.Label Label50;
        internal static System.Windows.Forms.Label lblDollarRH;
        internal static System.Windows.Forms.Label lblTotalTempsRHSoum;
        internal static System.Windows.Forms.Label lblTotalTempsRHReel;
        internal static System.Windows.Forms.Label lblTotalPrixRH;
        internal static System.Windows.Forms.Label lblTotal;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            fraRessourcesHumaines = new System.Windows.Forms.GroupBox();
            txtTempsprototypeSoum = new System.Windows.Forms.TextBox();
            txtTempsShippingSoum = new System.Windows.Forms.TextBox();
            txtTempsFormationSoum = new System.Windows.Forms.TextBox();
            txtTempsGestionSoum = new System.Windows.Forms.TextBox();
            txtTempsDessinSoum = new System.Windows.Forms.TextBox();
            txtTempsAssemblageSoum = new System.Windows.Forms.TextBox();
            txtTempsProgInterfaceSoum = new System.Windows.Forms.TextBox();
            txtTempsProgAutomateSoum = new System.Windows.Forms.TextBox();
            txtTempsProgRobotSoum = new System.Windows.Forms.TextBox();
            txtTempsTestSoum = new System.Windows.Forms.TextBox();
            txtTempsInstallationSoum = new System.Windows.Forms.TextBox();
            txtTempsMiseServiceSoum = new System.Windows.Forms.TextBox();
            txtTempsVisionSoum = new System.Windows.Forms.TextBox();
            lblPrixPrototype = new System.Windows.Forms.Label();
            lblTempsPrototypeReel = new System.Windows.Forms.Label();
            Label64 = new System.Windows.Forms.Label();
            Label56 = new System.Windows.Forms.Label();
            Label55 = new System.Windows.Forms.Label();
            Label63 = new System.Windows.Forms.Label();
            Label62 = new System.Windows.Forms.Label();
            Label61 = new System.Windows.Forms.Label();
            lblTempsShippingReel = new System.Windows.Forms.Label();
            lblPrixShipping = new System.Windows.Forms.Label();
            Label60 = new System.Windows.Forms.Label();
            Label59 = new System.Windows.Forms.Label();
            Label57 = new System.Windows.Forms.Label();
            lblTempsFormationReel = new System.Windows.Forms.Label();
            lblPrixFormation = new System.Windows.Forms.Label();
            lblPrixGestion = new System.Windows.Forms.Label();
            lblTempsGestionReel = new System.Windows.Forms.Label();
            Label53 = new System.Windows.Forms.Label();
            Label51 = new System.Windows.Forms.Label();
            Label39 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            Label7 = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            Label9 = new System.Windows.Forms.Label();
            Label10 = new System.Windows.Forms.Label();
            Label11 = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            Label13 = new System.Windows.Forms.Label();
            Label14 = new System.Windows.Forms.Label();
            Label15 = new System.Windows.Forms.Label();
            Label16 = new System.Windows.Forms.Label();
            Label17 = new System.Windows.Forms.Label();
            Label18 = new System.Windows.Forms.Label();
            Label19 = new System.Windows.Forms.Label();
            Label20 = new System.Windows.Forms.Label();
            Label21 = new System.Windows.Forms.Label();
            Label22 = new System.Windows.Forms.Label();
            Label23 = new System.Windows.Forms.Label();
            Label32 = new System.Windows.Forms.Label();
            Label40 = new System.Windows.Forms.Label();
            Label41 = new System.Windows.Forms.Label();
            Label43 = new System.Windows.Forms.Label();
            Label47 = new System.Windows.Forms.Label();
            Label49 = new System.Windows.Forms.Label();
            Label54 = new System.Windows.Forms.Label();
            Label58 = new System.Windows.Forms.Label();
            lblTempsDessinReel = new System.Windows.Forms.Label();
            lblTempsFabricationReel = new System.Windows.Forms.Label();
            lblTempsAssemblageReel = new System.Windows.Forms.Label();
            lblTempsProgInterfaceReel = new System.Windows.Forms.Label();
            lblTempsProgAutomateReel = new System.Windows.Forms.Label();
            lblTempsProgRobotReel = new System.Windows.Forms.Label();
            lblTempsTestReel = new System.Windows.Forms.Label();
            lblTempsInstallationReel = new System.Windows.Forms.Label();
            lblTempsMiseServiceReel = new System.Windows.Forms.Label();
            Label65 = new System.Windows.Forms.Label();
            Label66 = new System.Windows.Forms.Label();
            Label67 = new System.Windows.Forms.Label();
            lblTempsVisionReel = new System.Windows.Forms.Label();
            lblPrixDessin = new System.Windows.Forms.Label();
            lblPrixFabrication = new System.Windows.Forms.Label();
            lblPrixAssemblage = new System.Windows.Forms.Label();
            lblPrixProgInterface = new System.Windows.Forms.Label();
            lblPrixProgAutomate = new System.Windows.Forms.Label();
            lblPrixProgRobot = new System.Windows.Forms.Label();
            lblPrixVision = new System.Windows.Forms.Label();
            lblPrixTest = new System.Windows.Forms.Label();
            lblPrixInstallation = new System.Windows.Forms.Label();
            lblPrixMiseService = new System.Windows.Forms.Label();
            lblTempsFabricationSoum = new System.Windows.Forms.Label();
            fraFraisSubsistences = new System.Windows.Forms.GroupBox();
            txtTempsUniteMobile = new System.Windows.Forms.TextBox();
            txtTempsRepas = new System.Windows.Forms.TextBox();
            txtTempsHebergement = new System.Windows.Forms.TextBox();
            txtTempsDeplacement = new System.Windows.Forms.TextBox();
            txtNbrePersonne = new System.Windows.Forms.TextBox();
            Label27 = new System.Windows.Forms.Label();
            Label28 = new System.Windows.Forms.Label();
            Label29 = new System.Windows.Forms.Label();
            Label30 = new System.Windows.Forms.Label();
            Label34 = new System.Windows.Forms.Label();
            Label35 = new System.Windows.Forms.Label();
            Label36 = new System.Windows.Forms.Label();
            Label37 = new System.Windows.Forms.Label();
            Label38 = new System.Windows.Forms.Label();
            Label42 = new System.Windows.Forms.Label();
            Label44 = new System.Windows.Forms.Label();
            Label45 = new System.Windows.Forms.Label();
            Label46 = new System.Windows.Forms.Label();
            Label31 = new System.Windows.Forms.Label();
            lblPrixHebergement = new System.Windows.Forms.Label();
            lblPrixRepas = new System.Windows.Forms.Label();
            lblPrixDeplacement = new System.Windows.Forms.Label();
            lblPrixUniteMobile = new System.Windows.Forms.Label();
            fraManutention = new System.Windows.Forms.GroupBox();
            txtPrixEmballage = new System.Windows.Forms.TextBox();
            Label24 = new System.Windows.Forms.Label();
            Label33 = new System.Windows.Forms.Label();
            Label48 = new System.Windows.Forms.Label();
            cmdFermer = new System.Windows.Forms.Button();
            cmdDetail = new System.Windows.Forms.Button();
            Label52 = new System.Windows.Forms.Label();
            Label25 = new System.Windows.Forms.Label();
            Label26 = new System.Windows.Forms.Label();
            Label50 = new System.Windows.Forms.Label();
            lblDollarRH = new System.Windows.Forms.Label();
            lblTotalTempsRHSoum = new System.Windows.Forms.Label();
            lblTotalTempsRHReel = new System.Windows.Forms.Label();
            lblTotalPrixRH = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            fraRessourcesHumaines.SuspendLayout();
            fraFraisSubsistences.SuspendLayout();
            fraManutention.SuspendLayout();
            SuspendLayout();//fraRessourcesHumaines
            fraRessourcesHumaines.BackColor = System.Drawing.Color.Black;
            fraRessourcesHumaines.Controls.Add(txtTempsprototypeSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsShippingSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsFormationSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsGestionSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsDessinSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsAssemblageSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsProgInterfaceSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsProgAutomateSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsProgRobotSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsTestSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsInstallationSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsMiseServiceSoum);
            fraRessourcesHumaines.Controls.Add(txtTempsVisionSoum);
            fraRessourcesHumaines.Controls.Add(lblPrixPrototype);
            fraRessourcesHumaines.Controls.Add(lblTempsPrototypeReel);
            fraRessourcesHumaines.Controls.Add(Label64);
            fraRessourcesHumaines.Controls.Add(Label56);
            fraRessourcesHumaines.Controls.Add(Label55);
            fraRessourcesHumaines.Controls.Add(Label63);
            fraRessourcesHumaines.Controls.Add(Label62);
            fraRessourcesHumaines.Controls.Add(Label61);
            fraRessourcesHumaines.Controls.Add(lblTempsShippingReel);
            fraRessourcesHumaines.Controls.Add(lblPrixShipping);
            fraRessourcesHumaines.Controls.Add(Label60);
            fraRessourcesHumaines.Controls.Add(Label59);
            fraRessourcesHumaines.Controls.Add(Label57);
            fraRessourcesHumaines.Controls.Add(lblTempsFormationReel);
            fraRessourcesHumaines.Controls.Add(lblPrixFormation);
            fraRessourcesHumaines.Controls.Add(lblPrixGestion);
            fraRessourcesHumaines.Controls.Add(lblTempsGestionReel);
            fraRessourcesHumaines.Controls.Add(Label53);
            fraRessourcesHumaines.Controls.Add(Label51);
            fraRessourcesHumaines.Controls.Add(Label39);
            fraRessourcesHumaines.Controls.Add(Label1);
            fraRessourcesHumaines.Controls.Add(Label2);
            fraRessourcesHumaines.Controls.Add(Label3);
            fraRessourcesHumaines.Controls.Add(Label4);
            fraRessourcesHumaines.Controls.Add(Label5);
            fraRessourcesHumaines.Controls.Add(Label6);
            fraRessourcesHumaines.Controls.Add(Label7);
            fraRessourcesHumaines.Controls.Add(Label8);
            fraRessourcesHumaines.Controls.Add(Label9);
            fraRessourcesHumaines.Controls.Add(Label10);
            fraRessourcesHumaines.Controls.Add(Label11);
            fraRessourcesHumaines.Controls.Add(Label12);
            fraRessourcesHumaines.Controls.Add(Label13);
            fraRessourcesHumaines.Controls.Add(Label14);
            fraRessourcesHumaines.Controls.Add(Label15);
            fraRessourcesHumaines.Controls.Add(Label16);
            fraRessourcesHumaines.Controls.Add(Label17);
            fraRessourcesHumaines.Controls.Add(Label18);
            fraRessourcesHumaines.Controls.Add(Label19);
            fraRessourcesHumaines.Controls.Add(Label20);
            fraRessourcesHumaines.Controls.Add(Label21);
            fraRessourcesHumaines.Controls.Add(Label22);
            fraRessourcesHumaines.Controls.Add(Label23);
            fraRessourcesHumaines.Controls.Add(Label32);
            fraRessourcesHumaines.Controls.Add(Label40);
            fraRessourcesHumaines.Controls.Add(Label41);
            fraRessourcesHumaines.Controls.Add(Label43);
            fraRessourcesHumaines.Controls.Add(Label47);
            fraRessourcesHumaines.Controls.Add(Label49);
            fraRessourcesHumaines.Controls.Add(Label54);
            fraRessourcesHumaines.Controls.Add(Label58);
            fraRessourcesHumaines.Controls.Add(lblTempsDessinReel);
            fraRessourcesHumaines.Controls.Add(lblTempsFabricationReel);
            fraRessourcesHumaines.Controls.Add(lblTempsAssemblageReel);
            fraRessourcesHumaines.Controls.Add(lblTempsProgInterfaceReel);
            fraRessourcesHumaines.Controls.Add(lblTempsProgAutomateReel);
            fraRessourcesHumaines.Controls.Add(lblTempsProgRobotReel);
            fraRessourcesHumaines.Controls.Add(lblTempsTestReel);
            fraRessourcesHumaines.Controls.Add(lblTempsInstallationReel);
            fraRessourcesHumaines.Controls.Add(lblTempsMiseServiceReel);
            fraRessourcesHumaines.Controls.Add(Label65);
            fraRessourcesHumaines.Controls.Add(Label66);
            fraRessourcesHumaines.Controls.Add(Label67);
            fraRessourcesHumaines.Controls.Add(lblTempsVisionReel);
            fraRessourcesHumaines.Controls.Add(lblPrixDessin);
            fraRessourcesHumaines.Controls.Add(lblPrixFabrication);
            fraRessourcesHumaines.Controls.Add(lblPrixAssemblage);
            fraRessourcesHumaines.Controls.Add(lblPrixProgInterface);
            fraRessourcesHumaines.Controls.Add(lblPrixProgAutomate);
            fraRessourcesHumaines.Controls.Add(lblPrixProgRobot);
            fraRessourcesHumaines.Controls.Add(lblPrixVision);
            fraRessourcesHumaines.Controls.Add(lblPrixTest);
            fraRessourcesHumaines.Controls.Add(lblPrixInstallation);
            fraRessourcesHumaines.Controls.Add(lblPrixMiseService);
            fraRessourcesHumaines.Controls.Add(lblTempsFabricationSoum);
            fraRessourcesHumaines.ForeColor = System.Drawing.Color.White;
            fraRessourcesHumaines.Location = new System.Drawing.Point(8, 56);
            fraRessourcesHumaines.Name = "fraRessourcesHumaines";
            fraRessourcesHumaines.Padding = new System.Windows.Forms.Padding(0);
            fraRessourcesHumaines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraRessourcesHumaines.Size = new System.Drawing.Size(385, 401);
            fraRessourcesHumaines.TabIndex = 31;
            fraRessourcesHumaines.TabStop = false;
            fraRessourcesHumaines.Text = "Ressources humaines";//txtTempsprototypeSoum
            txtTempsprototypeSoum.AcceptsReturn = true;
            txtTempsprototypeSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsprototypeSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsprototypeSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsprototypeSoum.Location = new System.Drawing.Point(168, 368);
            txtTempsprototypeSoum.MaxLength = 0;
            txtTempsprototypeSoum.Name = "txtTempsprototypeSoum";
            txtTempsprototypeSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsprototypeSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsprototypeSoum.TabIndex = 123;//txtTempsShippingSoum
            txtTempsShippingSoum.AcceptsReturn = true;
            txtTempsShippingSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsShippingSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsShippingSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsShippingSoum.Location = new System.Drawing.Point(168, 344);
            txtTempsShippingSoum.MaxLength = 0;
            txtTempsShippingSoum.Name = "txtTempsShippingSoum";
            txtTempsShippingSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsShippingSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsShippingSoum.TabIndex = 117;
            txtTempsShippingSoum.TextChanged += new System.EventHandler(txtTempsShippingSoum_TextChanged);
            txtTempsShippingSoum.Leave += new System.EventHandler(txtTempsShippingSoum_Leave);//txtTempsFormationSoum
            txtTempsFormationSoum.AcceptsReturn = true;
            txtTempsFormationSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsFormationSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsFormationSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsFormationSoum.Location = new System.Drawing.Point(168, 296);
            txtTempsFormationSoum.MaxLength = 0;
            txtTempsFormationSoum.Name = "txtTempsFormationSoum";
            txtTempsFormationSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsFormationSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsFormationSoum.TabIndex = 111;
            txtTempsFormationSoum.TextChanged += new System.EventHandler(txtTempsFormationSoum_TextChanged);
            txtTempsFormationSoum.Leave += new System.EventHandler(txtTempsFormationSoum_Leave);//txtTempsGestionSoum
            txtTempsGestionSoum.AcceptsReturn = true;
            txtTempsGestionSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsGestionSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsGestionSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsGestionSoum.Location = new System.Drawing.Point(168, 320);
            txtTempsGestionSoum.MaxLength = 0;
            txtTempsGestionSoum.Name = "txtTempsGestionSoum";
            txtTempsGestionSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsGestionSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsGestionSoum.TabIndex = 104;
            txtTempsGestionSoum.TextChanged += new System.EventHandler(txtTempsGestionSoum_TextChanged);
            txtTempsGestionSoum.Leave += new System.EventHandler(txtTempsGestionSoum_Leave);//txtTempsDessinSoum
            txtTempsDessinSoum.AcceptsReturn = true;
            txtTempsDessinSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsDessinSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsDessinSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsDessinSoum.Location = new System.Drawing.Point(168, 56);
            txtTempsDessinSoum.MaxLength = 0;
            txtTempsDessinSoum.Name = "txtTempsDessinSoum";
            txtTempsDessinSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsDessinSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsDessinSoum.TabIndex = 40;
            txtTempsDessinSoum.TextChanged += new System.EventHandler(txtTempsDessinSoum_TextChanged);
            txtTempsDessinSoum.Leave += new System.EventHandler(txtTempsDessinSoum_Leave);//txtTempsAssemblageSoum
            txtTempsAssemblageSoum.AcceptsReturn = true;
            txtTempsAssemblageSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsAssemblageSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsAssemblageSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsAssemblageSoum.Location = new System.Drawing.Point(168, 104);
            txtTempsAssemblageSoum.MaxLength = 0;
            txtTempsAssemblageSoum.Name = "txtTempsAssemblageSoum";
            txtTempsAssemblageSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsAssemblageSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsAssemblageSoum.TabIndex = 39;
            txtTempsAssemblageSoum.TextChanged += new System.EventHandler(txtTempsAssemblageSoum_TextChanged);
            txtTempsAssemblageSoum.Leave += new System.EventHandler(txtTempsAssemblageSoum_Leave);//txtTempsProgInterfaceSoum
            txtTempsProgInterfaceSoum.AcceptsReturn = true;
            txtTempsProgInterfaceSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsProgInterfaceSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsProgInterfaceSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsProgInterfaceSoum.Location = new System.Drawing.Point(168, 128);
            txtTempsProgInterfaceSoum.MaxLength = 0;
            txtTempsProgInterfaceSoum.Name = "txtTempsProgInterfaceSoum";
            txtTempsProgInterfaceSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsProgInterfaceSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsProgInterfaceSoum.TabIndex = 38;
            txtTempsProgInterfaceSoum.TextChanged += new System.EventHandler(txtTempsProgInterfaceSoum_TextChanged);
            txtTempsProgInterfaceSoum.Leave += new System.EventHandler(txtTempsProgInterfaceSoum_Leave);//txtTempsProgAutomateSoum
            txtTempsProgAutomateSoum.AcceptsReturn = true;
            txtTempsProgAutomateSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsProgAutomateSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsProgAutomateSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsProgAutomateSoum.Location = new System.Drawing.Point(168, 152);
            txtTempsProgAutomateSoum.MaxLength = 0;
            txtTempsProgAutomateSoum.Name = "txtTempsProgAutomateSoum";
            txtTempsProgAutomateSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsProgAutomateSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsProgAutomateSoum.TabIndex = 37;
            txtTempsProgAutomateSoum.TextChanged += new System.EventHandler(txtTempsProgAutomateSoum_TextChanged);
            txtTempsProgAutomateSoum.Leave += new System.EventHandler(txtTempsProgAutomateSoum_Leave);//txtTempsProgRobotSoum
            txtTempsProgRobotSoum.AcceptsReturn = true;
            txtTempsProgRobotSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsProgRobotSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsProgRobotSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsProgRobotSoum.Location = new System.Drawing.Point(168, 176);
            txtTempsProgRobotSoum.MaxLength = 0;
            txtTempsProgRobotSoum.Name = "txtTempsProgRobotSoum";
            txtTempsProgRobotSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsProgRobotSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsProgRobotSoum.TabIndex = 36;
            txtTempsProgRobotSoum.TextChanged += new System.EventHandler(txtTempsProgRobotSoum_TextChanged);
            txtTempsProgRobotSoum.Leave += new System.EventHandler(txtTempsProgRobotSoum_Leave);//txtTempsTestSoum
            txtTempsTestSoum.AcceptsReturn = true;
            txtTempsTestSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsTestSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsTestSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsTestSoum.Location = new System.Drawing.Point(168, 224);
            txtTempsTestSoum.MaxLength = 0;
            txtTempsTestSoum.Name = "txtTempsTestSoum";
            txtTempsTestSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsTestSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsTestSoum.TabIndex = 35;
            txtTempsTestSoum.TextChanged += new System.EventHandler(txtTempsTestSoum_TextChanged);
            txtTempsTestSoum.Leave += new System.EventHandler(txtTempsTestSoum_Leave);//txtTempsInstallationSoum
            txtTempsInstallationSoum.AcceptsReturn = true;
            txtTempsInstallationSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsInstallationSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsInstallationSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsInstallationSoum.Location = new System.Drawing.Point(168, 248);
            txtTempsInstallationSoum.MaxLength = 0;
            txtTempsInstallationSoum.Name = "txtTempsInstallationSoum";
            txtTempsInstallationSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsInstallationSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsInstallationSoum.TabIndex = 34;
            txtTempsInstallationSoum.TextChanged += new System.EventHandler(txtTempsInstallationSoum_TextChanged);
            txtTempsInstallationSoum.Leave += new System.EventHandler(txtTempsInstallationSoum_Leave);//txtTempsMiseServiceSoum
            txtTempsMiseServiceSoum.AcceptsReturn = true;
            txtTempsMiseServiceSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsMiseServiceSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsMiseServiceSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsMiseServiceSoum.Location = new System.Drawing.Point(168, 272);
            txtTempsMiseServiceSoum.MaxLength = 0;
            txtTempsMiseServiceSoum.Name = "txtTempsMiseServiceSoum";
            txtTempsMiseServiceSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsMiseServiceSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsMiseServiceSoum.TabIndex = 33;
            txtTempsMiseServiceSoum.TextChanged += new System.EventHandler(txtTempsMiseServiceSoum_TextChanged);
            txtTempsMiseServiceSoum.Leave += new System.EventHandler(txtTempsMiseServiceSoum_Leave);//txtTempsVisionSoum
            txtTempsVisionSoum.AcceptsReturn = true;
            txtTempsVisionSoum.BackColor = System.Drawing.SystemColors.Window;
            txtTempsVisionSoum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsVisionSoum.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsVisionSoum.Location = new System.Drawing.Point(168, 200);
            txtTempsVisionSoum.MaxLength = 0;
            txtTempsVisionSoum.Name = "txtTempsVisionSoum";
            txtTempsVisionSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsVisionSoum.Size = new System.Drawing.Size(49, 19);
            txtTempsVisionSoum.TabIndex = 32;
            txtTempsVisionSoum.TextChanged += new System.EventHandler(txtTempsVisionSoum_TextChanged);
            txtTempsVisionSoum.Leave += new System.EventHandler(txtTempsVisionSoum_Leave);//lblPrixPrototype
            lblPrixPrototype.BackColor = System.Drawing.Color.Black;
            lblPrixPrototype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixPrototype.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixPrototype.ForeColor = System.Drawing.Color.White;
            lblPrixPrototype.Location = new System.Drawing.Point(312, 368);
            lblPrixPrototype.Name = "lblPrixPrototype";
            lblPrixPrototype.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixPrototype.Size = new System.Drawing.Size(49, 19);
            lblPrixPrototype.TabIndex = 128;
            lblPrixPrototype.Text = "0";
            lblPrixPrototype.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblTempsPrototypeReel
            lblTempsPrototypeReel.BackColor = System.Drawing.Color.Black;
            lblTempsPrototypeReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsPrototypeReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsPrototypeReel.ForeColor = System.Drawing.Color.White;
            lblTempsPrototypeReel.Location = new System.Drawing.Point(224, 368);
            lblTempsPrototypeReel.Name = "lblTempsPrototypeReel";
            lblTempsPrototypeReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsPrototypeReel.Size = new System.Drawing.Size(49, 19);
            lblTempsPrototypeReel.TabIndex = 127;//Label64
            Label64.BackColor = System.Drawing.Color.Black;
            Label64.Cursor = System.Windows.Forms.Cursors.Default;
            Label64.ForeColor = System.Drawing.Color.White;
            Label64.Location = new System.Drawing.Point(8, 368);
            Label64.Name = "Label64";
            Label64.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label64.Size = new System.Drawing.Size(137, 17);
            Label64.TabIndex = 126;
            Label64.Text = "Prototypage-Développement:";//Label56
            Label56.BackColor = System.Drawing.Color.Black;
            Label56.Cursor = System.Windows.Forms.Cursors.Default;
            Label56.ForeColor = System.Drawing.Color.White;
            Label56.Location = new System.Drawing.Point(280, 368);
            Label56.Name = "Label56";
            Label56.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label56.Size = new System.Drawing.Size(17, 17);
            Label56.TabIndex = 125;
            Label56.Text = "Hrs";//Label55
            Label55.BackColor = System.Drawing.Color.Black;
            Label55.Cursor = System.Windows.Forms.Cursors.Default;
            Label55.ForeColor = System.Drawing.Color.White;
            Label55.Location = new System.Drawing.Point(368, 368);
            Label55.Name = "Label55";
            Label55.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label55.Size = new System.Drawing.Size(9, 17);
            Label55.TabIndex = 124;
            Label55.Text = "$";//Label63
            Label63.BackColor = System.Drawing.Color.Black;
            Label63.Cursor = System.Windows.Forms.Cursors.Default;
            Label63.ForeColor = System.Drawing.Color.White;
            Label63.Location = new System.Drawing.Point(368, 344);
            Label63.Name = "Label63";
            Label63.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label63.Size = new System.Drawing.Size(9, 17);
            Label63.TabIndex = 122;
            Label63.Text = "$";//Label62
            Label62.BackColor = System.Drawing.Color.Black;
            Label62.Cursor = System.Windows.Forms.Cursors.Default;
            Label62.ForeColor = System.Drawing.Color.White;
            Label62.Location = new System.Drawing.Point(280, 344);
            Label62.Name = "Label62";
            Label62.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label62.Size = new System.Drawing.Size(17, 17);
            Label62.TabIndex = 121;
            Label62.Text = "Hrs";//Label61
            Label61.BackColor = System.Drawing.Color.Black;
            Label61.Cursor = System.Windows.Forms.Cursors.Default;
            Label61.ForeColor = System.Drawing.Color.White;
            Label61.Location = new System.Drawing.Point(8, 344);
            Label61.Name = "Label61";
            Label61.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label61.Size = new System.Drawing.Size(137, 17);
            Label61.TabIndex = 120;
            Label61.Text = "Expédition :";//lblTempsShippingReel
            lblTempsShippingReel.BackColor = System.Drawing.Color.Black;
            lblTempsShippingReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsShippingReel.ForeColor = System.Drawing.Color.White;
            lblTempsShippingReel.Location = new System.Drawing.Point(224, 344);
            lblTempsShippingReel.Name = "lblTempsShippingReel";
            lblTempsShippingReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsShippingReel.Size = new System.Drawing.Size(49, 19);
            lblTempsShippingReel.TabIndex = 119;//lblPrixShipping
            lblPrixShipping.BackColor = System.Drawing.Color.Black;
            lblPrixShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixShipping.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixShipping.ForeColor = System.Drawing.Color.White;
            lblPrixShipping.Location = new System.Drawing.Point(312, 344);
            lblPrixShipping.Name = "lblPrixShipping";
            lblPrixShipping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixShipping.Size = new System.Drawing.Size(49, 19);
            lblPrixShipping.TabIndex = 118;
            lblPrixShipping.Text = "0";
            lblPrixShipping.TextAlign = System.Drawing.ContentAlignment.TopRight;//Label60
            Label60.BackColor = System.Drawing.Color.Black;
            Label60.Cursor = System.Windows.Forms.Cursors.Default;
            Label60.ForeColor = System.Drawing.Color.White;
            Label60.Location = new System.Drawing.Point(368, 296);
            Label60.Name = "Label60";
            Label60.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label60.Size = new System.Drawing.Size(9, 17);
            Label60.TabIndex = 116;
            Label60.Text = "$";//Label59
            Label59.BackColor = System.Drawing.Color.Black;
            Label59.Cursor = System.Windows.Forms.Cursors.Default;
            Label59.ForeColor = System.Drawing.Color.White;
            Label59.Location = new System.Drawing.Point(280, 296);
            Label59.Name = "Label59";
            Label59.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label59.Size = new System.Drawing.Size(17, 17);
            Label59.TabIndex = 115;
            Label59.Text = "Hrs";//Label57
            Label57.BackColor = System.Drawing.Color.Black;
            Label57.Cursor = System.Windows.Forms.Cursors.Default;
            Label57.ForeColor = System.Drawing.Color.White;
            Label57.Location = new System.Drawing.Point(8, 296);
            Label57.Name = "Label57";
            Label57.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label57.Size = new System.Drawing.Size(137, 17);
            Label57.TabIndex = 114;
            Label57.Text = "Formation du personnel :";//lblTempsFormationReel
            lblTempsFormationReel.BackColor = System.Drawing.Color.Black;
            lblTempsFormationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsFormationReel.ForeColor = System.Drawing.Color.White;
            lblTempsFormationReel.Location = new System.Drawing.Point(224, 296);
            lblTempsFormationReel.Name = "lblTempsFormationReel";
            lblTempsFormationReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsFormationReel.Size = new System.Drawing.Size(49, 19);
            lblTempsFormationReel.TabIndex = 113;//lblPrixFormation
            lblPrixFormation.BackColor = System.Drawing.Color.Black;
            lblPrixFormation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixFormation.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixFormation.ForeColor = System.Drawing.Color.White;
            lblPrixFormation.Location = new System.Drawing.Point(312, 296);
            lblPrixFormation.Name = "lblPrixFormation";
            lblPrixFormation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixFormation.Size = new System.Drawing.Size(49, 19);
            lblPrixFormation.TabIndex = 112;
            lblPrixFormation.Text = "0";
            lblPrixFormation.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixGestion
            lblPrixGestion.BackColor = System.Drawing.Color.Black;
            lblPrixGestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixGestion.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixGestion.ForeColor = System.Drawing.Color.White;
            lblPrixGestion.Location = new System.Drawing.Point(312, 320);
            lblPrixGestion.Name = "lblPrixGestion";
            lblPrixGestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixGestion.Size = new System.Drawing.Size(49, 19);
            lblPrixGestion.TabIndex = 109;
            lblPrixGestion.Text = "0";
            lblPrixGestion.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblTempsGestionReel
            lblTempsGestionReel.BackColor = System.Drawing.Color.Black;
            lblTempsGestionReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsGestionReel.ForeColor = System.Drawing.Color.White;
            lblTempsGestionReel.Location = new System.Drawing.Point(224, 320);
            lblTempsGestionReel.Name = "lblTempsGestionReel";
            lblTempsGestionReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsGestionReel.Size = new System.Drawing.Size(49, 19);
            lblTempsGestionReel.TabIndex = 108;//Label53
            Label53.BackColor = System.Drawing.Color.Black;
            Label53.Cursor = System.Windows.Forms.Cursors.Default;
            Label53.ForeColor = System.Drawing.Color.White;
            Label53.Location = new System.Drawing.Point(8, 320);
            Label53.Name = "Label53";
            Label53.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label53.Size = new System.Drawing.Size(137, 17);
            Label53.TabIndex = 107;
            Label53.Text = "Gestion du projet :";//Label51
            Label51.BackColor = System.Drawing.Color.Black;
            Label51.Cursor = System.Windows.Forms.Cursors.Default;
            Label51.ForeColor = System.Drawing.Color.White;
            Label51.Location = new System.Drawing.Point(280, 320);
            Label51.Name = "Label51";
            Label51.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label51.Size = new System.Drawing.Size(17, 17);
            Label51.TabIndex = 106;
            Label51.Text = "Hrs";//Label39
            Label39.BackColor = System.Drawing.Color.Black;
            Label39.Cursor = System.Windows.Forms.Cursors.Default;
            Label39.ForeColor = System.Drawing.Color.White;
            Label39.Location = new System.Drawing.Point(368, 320);
            Label39.Name = "Label39";
            Label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label39.Size = new System.Drawing.Size(9, 17);
            Label39.TabIndex = 105;
            Label39.Text = "$";//Label1
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Cursor = System.Windows.Forms.Cursors.Default;
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(8, 56);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(137, 17);
            Label1.TabIndex = 94;
            Label1.Text = "Dessin :";//Label2
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Cursor = System.Windows.Forms.Cursors.Default;
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(8, 80);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(137, 17);
            Label2.TabIndex = 93;
            Label2.Text = "Fabrication";//Label3
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Cursor = System.Windows.Forms.Cursors.Default;
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(8, 104);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(137, 17);
            Label3.TabIndex = 92;
            Label3.Text = "Assemblage :";//Label4
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Cursor = System.Windows.Forms.Cursors.Default;
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(8, 152);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(137, 17);
            Label4.TabIndex = 91;
            Label4.Text = "Programmation d\'automate :";//Label5
            Label5.BackColor = System.Drawing.Color.Black;
            Label5.Cursor = System.Windows.Forms.Cursors.Default;
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(8, 128);
            Label5.Name = "Label5";
            Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label5.Size = new System.Drawing.Size(137, 17);
            Label5.TabIndex = 90;
            Label5.Text = "Programmation d\'interface :";//Label6
            Label6.BackColor = System.Drawing.Color.Black;
            Label6.Cursor = System.Windows.Forms.Cursors.Default;
            Label6.ForeColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(8, 176);
            Label6.Name = "Label6";
            Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label6.Size = new System.Drawing.Size(137, 17);
            Label6.TabIndex = 89;
            Label6.Text = "Programmation de robot :";//Label7
            Label7.BackColor = System.Drawing.Color.Black;
            Label7.Cursor = System.Windows.Forms.Cursors.Default;
            Label7.ForeColor = System.Drawing.Color.White;
            Label7.Location = new System.Drawing.Point(8, 224);
            Label7.Name = "Label7";
            Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label7.Size = new System.Drawing.Size(137, 17);
            Label7.TabIndex = 88;
            Label7.Text = "Test :";//Label8
            Label8.BackColor = System.Drawing.Color.Black;
            Label8.Cursor = System.Windows.Forms.Cursors.Default;
            Label8.ForeColor = System.Drawing.Color.White;
            Label8.Location = new System.Drawing.Point(168, 8);
            Label8.Name = "Label8";
            Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label8.Size = new System.Drawing.Size(105, 17);
            Label8.TabIndex = 87;
            Label8.Text = "Temps";
            Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;//Label9
            Label9.BackColor = System.Drawing.Color.Black;
            Label9.Cursor = System.Windows.Forms.Cursors.Default;
            Label9.ForeColor = System.Drawing.Color.White;
            Label9.Location = new System.Drawing.Point(312, 8);
            Label9.Name = "Label9";
            Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label9.Size = new System.Drawing.Size(49, 17);
            Label9.TabIndex = 86;
            Label9.Text = "Prix";
            Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;//Label10
            Label10.BackColor = System.Drawing.Color.Black;
            Label10.Cursor = System.Windows.Forms.Cursors.Default;
            Label10.ForeColor = System.Drawing.Color.White;
            Label10.Location = new System.Drawing.Point(280, 56);
            Label10.Name = "Label10";
            Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label10.Size = new System.Drawing.Size(17, 17);
            Label10.TabIndex = 85;
            Label10.Text = "Hrs";//Label11
            Label11.BackColor = System.Drawing.Color.Black;
            Label11.Cursor = System.Windows.Forms.Cursors.Default;
            Label11.ForeColor = System.Drawing.Color.White;
            Label11.Location = new System.Drawing.Point(280, 80);
            Label11.Name = "Label11";
            Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label11.Size = new System.Drawing.Size(17, 17);
            Label11.TabIndex = 84;
            Label11.Text = "Hrs";//Label12
            Label12.BackColor = System.Drawing.Color.Black;
            Label12.Cursor = System.Windows.Forms.Cursors.Default;
            Label12.ForeColor = System.Drawing.Color.White;
            Label12.Location = new System.Drawing.Point(280, 104);
            Label12.Name = "Label12";
            Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label12.Size = new System.Drawing.Size(17, 17);
            Label12.TabIndex = 83;
            Label12.Text = "Hrs";//Label13
            Label13.BackColor = System.Drawing.Color.Black;
            Label13.Cursor = System.Windows.Forms.Cursors.Default;
            Label13.ForeColor = System.Drawing.Color.White;
            Label13.Location = new System.Drawing.Point(280, 128);
            Label13.Name = "Label13";
            Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label13.Size = new System.Drawing.Size(17, 17);
            Label13.TabIndex = 82;
            Label13.Text = "Hrs";//Label14
            Label14.BackColor = System.Drawing.Color.Black;
            Label14.Cursor = System.Windows.Forms.Cursors.Default;
            Label14.ForeColor = System.Drawing.Color.White;
            Label14.Location = new System.Drawing.Point(280, 152);
            Label14.Name = "Label14";
            Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label14.Size = new System.Drawing.Size(17, 17);
            Label14.TabIndex = 81;
            Label14.Text = "Hrs";//Label15
            Label15.BackColor = System.Drawing.Color.Black;
            Label15.Cursor = System.Windows.Forms.Cursors.Default;
            Label15.ForeColor = System.Drawing.Color.White;
            Label15.Location = new System.Drawing.Point(280, 176);
            Label15.Name = "Label15";
            Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label15.Size = new System.Drawing.Size(17, 17);
            Label15.TabIndex = 80;
            Label15.Text = "Hrs";//Label16
            Label16.BackColor = System.Drawing.Color.Black;
            Label16.Cursor = System.Windows.Forms.Cursors.Default;
            Label16.ForeColor = System.Drawing.Color.White;
            Label16.Location = new System.Drawing.Point(280, 224);
            Label16.Name = "Label16";
            Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label16.Size = new System.Drawing.Size(17, 17);
            Label16.TabIndex = 79;
            Label16.Text = "Hrs";//Label17
            Label17.BackColor = System.Drawing.Color.Black;
            Label17.Cursor = System.Windows.Forms.Cursors.Default;
            Label17.ForeColor = System.Drawing.Color.White;
            Label17.Location = new System.Drawing.Point(368, 56);
            Label17.Name = "Label17";
            Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label17.Size = new System.Drawing.Size(9, 17);
            Label17.TabIndex = 78;
            Label17.Text = "$";//Label18
            Label18.BackColor = System.Drawing.Color.Black;
            Label18.Cursor = System.Windows.Forms.Cursors.Default;
            Label18.ForeColor = System.Drawing.Color.White;
            Label18.Location = new System.Drawing.Point(368, 80);
            Label18.Name = "Label18";
            Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label18.Size = new System.Drawing.Size(9, 17);
            Label18.TabIndex = 77;
            Label18.Text = "$";//Label19
            Label19.BackColor = System.Drawing.Color.Black;
            Label19.Cursor = System.Windows.Forms.Cursors.Default;
            Label19.ForeColor = System.Drawing.Color.White;
            Label19.Location = new System.Drawing.Point(368, 104);
            Label19.Name = "Label19";
            Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label19.Size = new System.Drawing.Size(9, 17);
            Label19.TabIndex = 76;
            Label19.Text = "$";//Label20
            Label20.BackColor = System.Drawing.Color.Black;
            Label20.Cursor = System.Windows.Forms.Cursors.Default;
            Label20.ForeColor = System.Drawing.Color.White;
            Label20.Location = new System.Drawing.Point(368, 128);
            Label20.Name = "Label20";
            Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label20.Size = new System.Drawing.Size(9, 17);
            Label20.TabIndex = 75;
            Label20.Text = "$";//Label21
            Label21.BackColor = System.Drawing.Color.Black;
            Label21.Cursor = System.Windows.Forms.Cursors.Default;
            Label21.ForeColor = System.Drawing.Color.White;
            Label21.Location = new System.Drawing.Point(368, 152);
            Label21.Name = "Label21";
            Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label21.Size = new System.Drawing.Size(9, 17);
            Label21.TabIndex = 74;
            Label21.Text = "$";//Label22
            Label22.BackColor = System.Drawing.Color.Black;
            Label22.Cursor = System.Windows.Forms.Cursors.Default;
            Label22.ForeColor = System.Drawing.Color.White;
            Label22.Location = new System.Drawing.Point(368, 176);
            Label22.Name = "Label22";
            Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label22.Size = new System.Drawing.Size(9, 17);
            Label22.TabIndex = 73;
            Label22.Text = "$";//Label23
            Label23.BackColor = System.Drawing.Color.Black;
            Label23.Cursor = System.Windows.Forms.Cursors.Default;
            Label23.ForeColor = System.Drawing.Color.White;
            Label23.Location = new System.Drawing.Point(368, 224);
            Label23.Name = "Label23";
            Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label23.Size = new System.Drawing.Size(9, 17);
            Label23.TabIndex = 72;
            Label23.Text = "$";//Label32
            Label32.BackColor = System.Drawing.Color.Black;
            Label32.Cursor = System.Windows.Forms.Cursors.Default;
            Label32.ForeColor = System.Drawing.Color.White;
            Label32.Location = new System.Drawing.Point(368, 248);
            Label32.Name = "Label32";
            Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label32.Size = new System.Drawing.Size(9, 17);
            Label32.TabIndex = 71;
            Label32.Text = "$";//Label40
            Label40.BackColor = System.Drawing.Color.Black;
            Label40.Cursor = System.Windows.Forms.Cursors.Default;
            Label40.ForeColor = System.Drawing.Color.White;
            Label40.Location = new System.Drawing.Point(280, 248);
            Label40.Name = "Label40";
            Label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label40.Size = new System.Drawing.Size(17, 17);
            Label40.TabIndex = 70;
            Label40.Text = "Hrs";//Label41
            Label41.BackColor = System.Drawing.Color.Black;
            Label41.Cursor = System.Windows.Forms.Cursors.Default;
            Label41.ForeColor = System.Drawing.Color.White;
            Label41.Location = new System.Drawing.Point(8, 248);
            Label41.Name = "Label41";
            Label41.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label41.Size = new System.Drawing.Size(137, 17);
            Label41.TabIndex = 69;
            Label41.Text = "Installation :";//Label43
            Label43.BackColor = System.Drawing.Color.Black;
            Label43.Cursor = System.Windows.Forms.Cursors.Default;
            Label43.ForeColor = System.Drawing.Color.White;
            Label43.Location = new System.Drawing.Point(368, 272);
            Label43.Name = "Label43";
            Label43.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label43.Size = new System.Drawing.Size(9, 17);
            Label43.TabIndex = 68;
            Label43.Text = "$";//Label47
            Label47.BackColor = System.Drawing.Color.Black;
            Label47.Cursor = System.Windows.Forms.Cursors.Default;
            Label47.ForeColor = System.Drawing.Color.White;
            Label47.Location = new System.Drawing.Point(280, 272);
            Label47.Name = "Label47";
            Label47.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label47.Size = new System.Drawing.Size(17, 17);
            Label47.TabIndex = 67;
            Label47.Text = "Hrs";//Label49
            Label49.BackColor = System.Drawing.Color.Black;
            Label49.Cursor = System.Windows.Forms.Cursors.Default;
            Label49.ForeColor = System.Drawing.Color.White;
            Label49.Location = new System.Drawing.Point(8, 272);
            Label49.Name = "Label49";
            Label49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label49.Size = new System.Drawing.Size(137, 17);
            Label49.TabIndex = 66;
            Label49.Text = "Mise en service :";//Label54
            Label54.BackColor = System.Drawing.Color.Black;
            Label54.Cursor = System.Windows.Forms.Cursors.Default;
            Label54.ForeColor = System.Drawing.Color.White;
            Label54.Location = new System.Drawing.Point(152, 32);
            Label54.Name = "Label54";
            Label54.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label54.Size = new System.Drawing.Size(81, 17);
            Label54.TabIndex = 65;
            Label54.Text = "Temps";
            Label54.TextAlign = System.Drawing.ContentAlignment.TopCenter;//Label58
            Label58.BackColor = System.Drawing.Color.Black;
            Label58.Cursor = System.Windows.Forms.Cursors.Default;
            Label58.ForeColor = System.Drawing.Color.White;
            Label58.Location = new System.Drawing.Point(216, 32);
            Label58.Name = "Label58";
            Label58.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label58.Size = new System.Drawing.Size(65, 17);
            Label58.TabIndex = 64;
            Label58.Text = "Réel";
            Label58.TextAlign = System.Drawing.ContentAlignment.TopCenter;//lblTempsDessinReel
            lblTempsDessinReel.BackColor = System.Drawing.Color.Black;
            lblTempsDessinReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsDessinReel.ForeColor = System.Drawing.Color.White;
            lblTempsDessinReel.Location = new System.Drawing.Point(224, 56);
            lblTempsDessinReel.Name = "lblTempsDessinReel";
            lblTempsDessinReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsDessinReel.Size = new System.Drawing.Size(49, 19);
            lblTempsDessinReel.TabIndex = 63;//lblTempsFabricationReel
            lblTempsFabricationReel.BackColor = System.Drawing.Color.Black;
            lblTempsFabricationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFabricationReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsFabricationReel.ForeColor = System.Drawing.Color.White;
            lblTempsFabricationReel.Location = new System.Drawing.Point(224, 80);
            lblTempsFabricationReel.Name = "lblTempsFabricationReel";
            lblTempsFabricationReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsFabricationReel.Size = new System.Drawing.Size(49, 19);
            lblTempsFabricationReel.TabIndex = 62;//lblTempsAssemblageReel
            lblTempsAssemblageReel.BackColor = System.Drawing.Color.Black;
            lblTempsAssemblageReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsAssemblageReel.ForeColor = System.Drawing.Color.White;
            lblTempsAssemblageReel.Location = new System.Drawing.Point(224, 104);
            lblTempsAssemblageReel.Name = "lblTempsAssemblageReel";
            lblTempsAssemblageReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsAssemblageReel.Size = new System.Drawing.Size(49, 19);
            lblTempsAssemblageReel.TabIndex = 61;//lblTempsProgInterfaceReel
            lblTempsProgInterfaceReel.BackColor = System.Drawing.Color.Black;
            lblTempsProgInterfaceReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgInterfaceReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsProgInterfaceReel.ForeColor = System.Drawing.Color.White;
            lblTempsProgInterfaceReel.Location = new System.Drawing.Point(224, 128);
            lblTempsProgInterfaceReel.Name = "lblTempsProgInterfaceReel";
            lblTempsProgInterfaceReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsProgInterfaceReel.Size = new System.Drawing.Size(49, 19);
            lblTempsProgInterfaceReel.TabIndex = 60;//lblTempsProgAutomateReel
            lblTempsProgAutomateReel.BackColor = System.Drawing.Color.Black;
            lblTempsProgAutomateReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgAutomateReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsProgAutomateReel.ForeColor = System.Drawing.Color.White;
            lblTempsProgAutomateReel.Location = new System.Drawing.Point(224, 152);
            lblTempsProgAutomateReel.Name = "lblTempsProgAutomateReel";
            lblTempsProgAutomateReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsProgAutomateReel.Size = new System.Drawing.Size(49, 19);
            lblTempsProgAutomateReel.TabIndex = 59;//lblTempsProgRobotReel
            lblTempsProgRobotReel.BackColor = System.Drawing.Color.Black;
            lblTempsProgRobotReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgRobotReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsProgRobotReel.ForeColor = System.Drawing.Color.White;
            lblTempsProgRobotReel.Location = new System.Drawing.Point(224, 176);
            lblTempsProgRobotReel.Name = "lblTempsProgRobotReel";
            lblTempsProgRobotReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsProgRobotReel.Size = new System.Drawing.Size(49, 19);
            lblTempsProgRobotReel.TabIndex = 58;//lblTempsTestReel
            lblTempsTestReel.BackColor = System.Drawing.Color.Black;
            lblTempsTestReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsTestReel.ForeColor = System.Drawing.Color.White;
            lblTempsTestReel.Location = new System.Drawing.Point(224, 224);
            lblTempsTestReel.Name = "lblTempsTestReel";
            lblTempsTestReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsTestReel.Size = new System.Drawing.Size(49, 19);
            lblTempsTestReel.TabIndex = 57;//lblTempsInstallationReel
            lblTempsInstallationReel.BackColor = System.Drawing.Color.Black;
            lblTempsInstallationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsInstallationReel.ForeColor = System.Drawing.Color.White;
            lblTempsInstallationReel.Location = new System.Drawing.Point(224, 248);
            lblTempsInstallationReel.Name = "lblTempsInstallationReel";
            lblTempsInstallationReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsInstallationReel.Size = new System.Drawing.Size(49, 19);
            lblTempsInstallationReel.TabIndex = 56;//lblTempsMiseServiceReel
            lblTempsMiseServiceReel.BackColor = System.Drawing.Color.Black;
            lblTempsMiseServiceReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMiseServiceReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsMiseServiceReel.ForeColor = System.Drawing.Color.White;
            lblTempsMiseServiceReel.Location = new System.Drawing.Point(224, 272);
            lblTempsMiseServiceReel.Name = "lblTempsMiseServiceReel";
            lblTempsMiseServiceReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsMiseServiceReel.Size = new System.Drawing.Size(49, 19);
            lblTempsMiseServiceReel.TabIndex = 55;//Label65
            Label65.BackColor = System.Drawing.Color.Black;
            Label65.Cursor = System.Windows.Forms.Cursors.Default;
            Label65.ForeColor = System.Drawing.Color.White;
            Label65.Location = new System.Drawing.Point(368, 200);
            Label65.Name = "Label65";
            Label65.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label65.Size = new System.Drawing.Size(9, 17);
            Label65.TabIndex = 54;
            Label65.Text = "$";//Label66
            Label66.BackColor = System.Drawing.Color.Black;
            Label66.Cursor = System.Windows.Forms.Cursors.Default;
            Label66.ForeColor = System.Drawing.Color.White;
            Label66.Location = new System.Drawing.Point(280, 200);
            Label66.Name = "Label66";
            Label66.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label66.Size = new System.Drawing.Size(17, 17);
            Label66.TabIndex = 53;
            Label66.Text = "Hrs";//Label67
            Label67.BackColor = System.Drawing.Color.Black;
            Label67.Cursor = System.Windows.Forms.Cursors.Default;
            Label67.ForeColor = System.Drawing.Color.White;
            Label67.Location = new System.Drawing.Point(8, 200);
            Label67.Name = "Label67";
            Label67.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label67.Size = new System.Drawing.Size(137, 17);
            Label67.TabIndex = 52;
            Label67.Text = "Vision :";//lblTempsVisionReel
            lblTempsVisionReel.BackColor = System.Drawing.Color.Black;
            lblTempsVisionReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsVisionReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsVisionReel.ForeColor = System.Drawing.Color.White;
            lblTempsVisionReel.Location = new System.Drawing.Point(224, 200);
            lblTempsVisionReel.Name = "lblTempsVisionReel";
            lblTempsVisionReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsVisionReel.Size = new System.Drawing.Size(49, 19);
            lblTempsVisionReel.TabIndex = 51;//lblPrixDessin
            lblPrixDessin.BackColor = System.Drawing.Color.Black;
            lblPrixDessin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixDessin.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixDessin.ForeColor = System.Drawing.Color.White;
            lblPrixDessin.Location = new System.Drawing.Point(312, 56);
            lblPrixDessin.Name = "lblPrixDessin";
            lblPrixDessin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixDessin.Size = new System.Drawing.Size(49, 19);
            lblPrixDessin.TabIndex = 50;
            lblPrixDessin.Text = "0";
            lblPrixDessin.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixFabrication
            lblPrixFabrication.BackColor = System.Drawing.Color.Black;
            lblPrixFabrication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixFabrication.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixFabrication.ForeColor = System.Drawing.Color.White;
            lblPrixFabrication.Location = new System.Drawing.Point(312, 80);
            lblPrixFabrication.Name = "lblPrixFabrication";
            lblPrixFabrication.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixFabrication.Size = new System.Drawing.Size(49, 19);
            lblPrixFabrication.TabIndex = 49;
            lblPrixFabrication.Text = "0";
            lblPrixFabrication.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixAssemblage
            lblPrixAssemblage.BackColor = System.Drawing.Color.Black;
            lblPrixAssemblage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixAssemblage.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixAssemblage.ForeColor = System.Drawing.Color.White;
            lblPrixAssemblage.Location = new System.Drawing.Point(312, 104);
            lblPrixAssemblage.Name = "lblPrixAssemblage";
            lblPrixAssemblage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixAssemblage.Size = new System.Drawing.Size(49, 19);
            lblPrixAssemblage.TabIndex = 48;
            lblPrixAssemblage.Text = "0";
            lblPrixAssemblage.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixProgInterface
            lblPrixProgInterface.BackColor = System.Drawing.Color.Black;
            lblPrixProgInterface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixProgInterface.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixProgInterface.ForeColor = System.Drawing.Color.White;
            lblPrixProgInterface.Location = new System.Drawing.Point(312, 128);
            lblPrixProgInterface.Name = "lblPrixProgInterface";
            lblPrixProgInterface.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixProgInterface.Size = new System.Drawing.Size(49, 19);
            lblPrixProgInterface.TabIndex = 47;
            lblPrixProgInterface.Text = "0";
            lblPrixProgInterface.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixProgAutomate
            lblPrixProgAutomate.BackColor = System.Drawing.Color.Black;
            lblPrixProgAutomate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixProgAutomate.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixProgAutomate.ForeColor = System.Drawing.Color.White;
            lblPrixProgAutomate.Location = new System.Drawing.Point(312, 152);
            lblPrixProgAutomate.Name = "lblPrixProgAutomate";
            lblPrixProgAutomate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixProgAutomate.Size = new System.Drawing.Size(49, 19);
            lblPrixProgAutomate.TabIndex = 46;
            lblPrixProgAutomate.Text = "0";
            lblPrixProgAutomate.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixProgRobot
            lblPrixProgRobot.BackColor = System.Drawing.Color.Black;
            lblPrixProgRobot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixProgRobot.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixProgRobot.ForeColor = System.Drawing.Color.White;
            lblPrixProgRobot.Location = new System.Drawing.Point(312, 176);
            lblPrixProgRobot.Name = "lblPrixProgRobot";
            lblPrixProgRobot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixProgRobot.Size = new System.Drawing.Size(49, 19);
            lblPrixProgRobot.TabIndex = 45;
            lblPrixProgRobot.Text = "0";
            lblPrixProgRobot.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixVision
            lblPrixVision.BackColor = System.Drawing.Color.Black;
            lblPrixVision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixVision.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixVision.ForeColor = System.Drawing.Color.White;
            lblPrixVision.Location = new System.Drawing.Point(312, 200);
            lblPrixVision.Name = "lblPrixVision";
            lblPrixVision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixVision.Size = new System.Drawing.Size(49, 19);
            lblPrixVision.TabIndex = 44;
            lblPrixVision.Text = "0";
            lblPrixVision.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixTest
            lblPrixTest.BackColor = System.Drawing.Color.Black;
            lblPrixTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixTest.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixTest.ForeColor = System.Drawing.Color.White;
            lblPrixTest.Location = new System.Drawing.Point(312, 224);
            lblPrixTest.Name = "lblPrixTest";
            lblPrixTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixTest.Size = new System.Drawing.Size(49, 19);
            lblPrixTest.TabIndex = 43;
            lblPrixTest.Text = "0";
            lblPrixTest.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixInstallation
            lblPrixInstallation.BackColor = System.Drawing.Color.Black;
            lblPrixInstallation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixInstallation.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixInstallation.ForeColor = System.Drawing.Color.White;
            lblPrixInstallation.Location = new System.Drawing.Point(312, 248);
            lblPrixInstallation.Name = "lblPrixInstallation";
            lblPrixInstallation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixInstallation.Size = new System.Drawing.Size(49, 19);
            lblPrixInstallation.TabIndex = 42;
            lblPrixInstallation.Text = "0";
            lblPrixInstallation.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixMiseService
            lblPrixMiseService.BackColor = System.Drawing.Color.Black;
            lblPrixMiseService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixMiseService.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixMiseService.ForeColor = System.Drawing.Color.White;
            lblPrixMiseService.Location = new System.Drawing.Point(312, 272);
            lblPrixMiseService.Name = "lblPrixMiseService";
            lblPrixMiseService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixMiseService.Size = new System.Drawing.Size(49, 19);
            lblPrixMiseService.TabIndex = 41;
            lblPrixMiseService.Text = "0";
            lblPrixMiseService.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblTempsFabricationSoum
            lblTempsFabricationSoum.BackColor = System.Drawing.Color.Black;
            lblTempsFabricationSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFabricationSoum.Cursor = System.Windows.Forms.Cursors.Default;
            lblTempsFabricationSoum.ForeColor = System.Drawing.Color.White;
            lblTempsFabricationSoum.Location = new System.Drawing.Point(168, 80);
            lblTempsFabricationSoum.Name = "lblTempsFabricationSoum";
            lblTempsFabricationSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTempsFabricationSoum.Size = new System.Drawing.Size(49, 19);
            lblTempsFabricationSoum.TabIndex = 110;
            lblTempsFabricationSoum.Click += new System.EventHandler(lblTempsFabricationSoum_Click);//fraFraisSubsistences
            fraFraisSubsistences.BackColor = System.Drawing.Color.Black;
            fraFraisSubsistences.Controls.Add(txtTempsUniteMobile);
            fraFraisSubsistences.Controls.Add(txtTempsRepas);
            fraFraisSubsistences.Controls.Add(txtTempsHebergement);
            fraFraisSubsistences.Controls.Add(txtTempsDeplacement);
            fraFraisSubsistences.Controls.Add(txtNbrePersonne);
            fraFraisSubsistences.Controls.Add(Label27);
            fraFraisSubsistences.Controls.Add(Label28);
            fraFraisSubsistences.Controls.Add(Label29);
            fraFraisSubsistences.Controls.Add(Label30);
            fraFraisSubsistences.Controls.Add(Label34);
            fraFraisSubsistences.Controls.Add(Label35);
            fraFraisSubsistences.Controls.Add(Label36);
            fraFraisSubsistences.Controls.Add(Label37);
            fraFraisSubsistences.Controls.Add(Label38);
            fraFraisSubsistences.Controls.Add(Label42);
            fraFraisSubsistences.Controls.Add(Label44);
            fraFraisSubsistences.Controls.Add(Label45);
            fraFraisSubsistences.Controls.Add(Label46);
            fraFraisSubsistences.Controls.Add(Label31);
            fraFraisSubsistences.Controls.Add(lblPrixHebergement);
            fraFraisSubsistences.Controls.Add(lblPrixRepas);
            fraFraisSubsistences.Controls.Add(lblPrixDeplacement);
            fraFraisSubsistences.Controls.Add(lblPrixUniteMobile);
            fraFraisSubsistences.ForeColor = System.Drawing.Color.White;
            fraFraisSubsistences.Location = new System.Drawing.Point(400, 56);
            fraFraisSubsistences.Name = "fraFraisSubsistences";
            fraFraisSubsistences.Padding = new System.Windows.Forms.Padding(0);
            fraFraisSubsistences.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraFraisSubsistences.Size = new System.Drawing.Size(321, 129);
            fraFraisSubsistences.TabIndex = 7;
            fraFraisSubsistences.TabStop = false;
            fraFraisSubsistences.Text = "Frais de subsistances";//txtTempsUniteMobile
            txtTempsUniteMobile.AcceptsReturn = true;
            txtTempsUniteMobile.BackColor = System.Drawing.SystemColors.Window;
            txtTempsUniteMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsUniteMobile.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsUniteMobile.Location = new System.Drawing.Point(160, 104);
            txtTempsUniteMobile.MaxLength = 0;
            txtTempsUniteMobile.Name = "txtTempsUniteMobile";
            txtTempsUniteMobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsUniteMobile.Size = new System.Drawing.Size(49, 19);
            txtTempsUniteMobile.TabIndex = 12;
            txtTempsUniteMobile.TextChanged += new System.EventHandler(txtTempsUniteMobile_TextChanged);
            txtTempsUniteMobile.Leave += new System.EventHandler(txtTempsUniteMobile_Leave);//txtTempsRepas
            txtTempsRepas.AcceptsReturn = true;
            txtTempsRepas.BackColor = System.Drawing.SystemColors.Window;
            txtTempsRepas.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsRepas.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsRepas.Location = new System.Drawing.Point(160, 56);
            txtTempsRepas.MaxLength = 0;
            txtTempsRepas.Name = "txtTempsRepas";
            txtTempsRepas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsRepas.Size = new System.Drawing.Size(49, 19);
            txtTempsRepas.TabIndex = 11;
            txtTempsRepas.TextChanged += new System.EventHandler(txtTempsRepas_TextChanged);
            txtTempsRepas.Leave += new System.EventHandler(txtTempsRepas_Leave);//txtTempsHebergement
            txtTempsHebergement.AcceptsReturn = true;
            txtTempsHebergement.BackColor = System.Drawing.SystemColors.Window;
            txtTempsHebergement.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsHebergement.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsHebergement.Location = new System.Drawing.Point(160, 32);
            txtTempsHebergement.MaxLength = 0;
            txtTempsHebergement.Name = "txtTempsHebergement";
            txtTempsHebergement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsHebergement.Size = new System.Drawing.Size(49, 19);
            txtTempsHebergement.TabIndex = 10;
            txtTempsHebergement.TextChanged += new System.EventHandler(txtTempsHebergement_TextChanged);
            txtTempsHebergement.Leave += new System.EventHandler(txtTempsHebergement_Leave);//txtTempsDeplacement
            txtTempsDeplacement.AcceptsReturn = true;
            txtTempsDeplacement.BackColor = System.Drawing.SystemColors.Window;
            txtTempsDeplacement.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTempsDeplacement.ForeColor = System.Drawing.SystemColors.WindowText;
            txtTempsDeplacement.Location = new System.Drawing.Point(160, 80);
            txtTempsDeplacement.MaxLength = 0;
            txtTempsDeplacement.Name = "txtTempsDeplacement";
            txtTempsDeplacement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTempsDeplacement.Size = new System.Drawing.Size(49, 19);
            txtTempsDeplacement.TabIndex = 9;
            txtTempsDeplacement.TextChanged += new System.EventHandler(txtTempsDeplacement_TextChanged);
            txtTempsDeplacement.Leave += new System.EventHandler(txtTempsDeplacement_Leave);//txtNbrePersonne
            txtNbrePersonne.AcceptsReturn = true;
            txtNbrePersonne.BackColor = System.Drawing.SystemColors.Window;
            txtNbrePersonne.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNbrePersonne.ForeColor = System.Drawing.SystemColors.WindowText;
            txtNbrePersonne.Location = new System.Drawing.Point(88, 32);
            txtNbrePersonne.MaxLength = 2;
            txtNbrePersonne.Name = "txtNbrePersonne";
            txtNbrePersonne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNbrePersonne.Size = new System.Drawing.Size(33, 19);
            txtNbrePersonne.TabIndex = 8;
            txtNbrePersonne.TextChanged += new System.EventHandler(txtNbrePersonne_TextChanged);//Label27
            Label27.BackColor = System.Drawing.Color.Black;
            Label27.Cursor = System.Windows.Forms.Cursors.Default;
            Label27.ForeColor = System.Drawing.Color.White;
            Label27.Location = new System.Drawing.Point(304, 104);
            Label27.Name = "Label27";
            Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label27.Size = new System.Drawing.Size(9, 17);
            Label27.TabIndex = 30;
            Label27.Text = "$";//Label28
            Label28.BackColor = System.Drawing.Color.Black;
            Label28.Cursor = System.Windows.Forms.Cursors.Default;
            Label28.ForeColor = System.Drawing.Color.White;
            Label28.Location = new System.Drawing.Point(304, 80);
            Label28.Name = "Label28";
            Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label28.Size = new System.Drawing.Size(9, 17);
            Label28.TabIndex = 29;
            Label28.Text = "$";//Label29
            Label29.BackColor = System.Drawing.Color.Black;
            Label29.Cursor = System.Windows.Forms.Cursors.Default;
            Label29.ForeColor = System.Drawing.Color.White;
            Label29.Location = new System.Drawing.Point(304, 56);
            Label29.Name = "Label29";
            Label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label29.Size = new System.Drawing.Size(9, 17);
            Label29.TabIndex = 28;
            Label29.Text = "$";//Label30
            Label30.BackColor = System.Drawing.Color.Black;
            Label30.Cursor = System.Windows.Forms.Cursors.Default;
            Label30.ForeColor = System.Drawing.Color.White;
            Label30.Location = new System.Drawing.Point(304, 32);
            Label30.Name = "Label30";
            Label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label30.Size = new System.Drawing.Size(9, 17);
            Label30.TabIndex = 27;
            Label30.Text = "$";//Label34
            Label34.BackColor = System.Drawing.Color.Black;
            Label34.Cursor = System.Windows.Forms.Cursors.Default;
            Label34.ForeColor = System.Drawing.Color.White;
            Label34.Location = new System.Drawing.Point(216, 104);
            Label34.Name = "Label34";
            Label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label34.Size = new System.Drawing.Size(17, 17);
            Label34.TabIndex = 26;
            Label34.Text = "Km";//Label35
            Label35.BackColor = System.Drawing.Color.Black;
            Label35.Cursor = System.Windows.Forms.Cursors.Default;
            Label35.ForeColor = System.Drawing.Color.White;
            Label35.Location = new System.Drawing.Point(216, 80);
            Label35.Name = "Label35";
            Label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label35.Size = new System.Drawing.Size(17, 17);
            Label35.TabIndex = 25;
            Label35.Text = "Km";//Label36
            Label36.BackColor = System.Drawing.Color.Black;
            Label36.Cursor = System.Windows.Forms.Cursors.Default;
            Label36.ForeColor = System.Drawing.Color.White;
            Label36.Location = new System.Drawing.Point(216, 56);
            Label36.Name = "Label36";
            Label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label36.Size = new System.Drawing.Size(25, 17);
            Label36.TabIndex = 24;
            Label36.Text = "Jours";//Label37
            Label37.BackColor = System.Drawing.Color.Black;
            Label37.Cursor = System.Windows.Forms.Cursors.Default;
            Label37.ForeColor = System.Drawing.Color.White;
            Label37.Location = new System.Drawing.Point(216, 32);
            Label37.Name = "Label37";
            Label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label37.Size = new System.Drawing.Size(33, 17);
            Label37.TabIndex = 23;
            Label37.Text = "Jours";//Label38
            Label38.BackColor = System.Drawing.Color.Black;
            Label38.Cursor = System.Windows.Forms.Cursors.Default;
            Label38.ForeColor = System.Drawing.Color.White;
            Label38.Location = new System.Drawing.Point(248, 8);
            Label38.Name = "Label38";
            Label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label38.Size = new System.Drawing.Size(49, 17);
            Label38.TabIndex = 22;
            Label38.Text = "Prix";
            Label38.TextAlign = System.Drawing.ContentAlignment.TopCenter;//Label42
            Label42.BackColor = System.Drawing.Color.Black;
            Label42.Cursor = System.Windows.Forms.Cursors.Default;
            Label42.ForeColor = System.Drawing.Color.White;
            Label42.Location = new System.Drawing.Point(8, 104);
            Label42.Name = "Label42";
            Label42.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label42.Size = new System.Drawing.Size(137, 17);
            Label42.TabIndex = 21;
            Label42.Text = "Transport de l\'unité mobile :";//Label44
            Label44.BackColor = System.Drawing.Color.Black;
            Label44.Cursor = System.Windows.Forms.Cursors.Default;
            Label44.ForeColor = System.Drawing.Color.White;
            Label44.Location = new System.Drawing.Point(8, 80);
            Label44.Name = "Label44";
            Label44.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label44.Size = new System.Drawing.Size(129, 17);
            Label44.TabIndex = 20;
            Label44.Text = "Transport / déplacement : ";//Label45
            Label45.BackColor = System.Drawing.Color.Black;
            Label45.Cursor = System.Windows.Forms.Cursors.Default;
            Label45.ForeColor = System.Drawing.Color.White;
            Label45.Location = new System.Drawing.Point(8, 56);
            Label45.Name = "Label45";
            Label45.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label45.Size = new System.Drawing.Size(49, 17);
            Label45.TabIndex = 19;
            Label45.Text = "Repas :";//Label46
            Label46.BackColor = System.Drawing.Color.Black;
            Label46.Cursor = System.Windows.Forms.Cursors.Default;
            Label46.ForeColor = System.Drawing.Color.White;
            Label46.Location = new System.Drawing.Point(8, 32);
            Label46.Name = "Label46";
            Label46.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label46.Size = new System.Drawing.Size(81, 17);
            Label46.TabIndex = 18;
            Label46.Text = "Hébergement :";//Label31
            Label31.BackColor = System.Drawing.Color.Black;
            Label31.Cursor = System.Windows.Forms.Cursors.Default;
            Label31.ForeColor = System.Drawing.Color.White;
            Label31.Location = new System.Drawing.Point(128, 32);
            Label31.Name = "Label31";
            Label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label31.Size = new System.Drawing.Size(41, 17);
            Label31.TabIndex = 17;
            Label31.Text = "pers.";//lblPrixHebergement
            lblPrixHebergement.BackColor = System.Drawing.Color.Black;
            lblPrixHebergement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixHebergement.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixHebergement.ForeColor = System.Drawing.Color.White;
            lblPrixHebergement.Location = new System.Drawing.Point(248, 32);
            lblPrixHebergement.Name = "lblPrixHebergement";
            lblPrixHebergement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixHebergement.Size = new System.Drawing.Size(49, 19);
            lblPrixHebergement.TabIndex = 16;
            lblPrixHebergement.Text = "0";
            lblPrixHebergement.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixRepas
            lblPrixRepas.BackColor = System.Drawing.Color.Black;
            lblPrixRepas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixRepas.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixRepas.ForeColor = System.Drawing.Color.White;
            lblPrixRepas.Location = new System.Drawing.Point(248, 56);
            lblPrixRepas.Name = "lblPrixRepas";
            lblPrixRepas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixRepas.Size = new System.Drawing.Size(49, 19);
            lblPrixRepas.TabIndex = 15;
            lblPrixRepas.Text = "0";
            lblPrixRepas.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixDeplacement
            lblPrixDeplacement.BackColor = System.Drawing.Color.Black;
            lblPrixDeplacement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixDeplacement.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixDeplacement.ForeColor = System.Drawing.Color.White;
            lblPrixDeplacement.Location = new System.Drawing.Point(248, 80);
            lblPrixDeplacement.Name = "lblPrixDeplacement";
            lblPrixDeplacement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixDeplacement.Size = new System.Drawing.Size(49, 19);
            lblPrixDeplacement.TabIndex = 14;
            lblPrixDeplacement.Text = "0";
            lblPrixDeplacement.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblPrixUniteMobile
            lblPrixUniteMobile.BackColor = System.Drawing.Color.Black;
            lblPrixUniteMobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrixUniteMobile.Cursor = System.Windows.Forms.Cursors.Default;
            lblPrixUniteMobile.ForeColor = System.Drawing.Color.White;
            lblPrixUniteMobile.Location = new System.Drawing.Point(248, 104);
            lblPrixUniteMobile.Name = "lblPrixUniteMobile";
            lblPrixUniteMobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixUniteMobile.Size = new System.Drawing.Size(49, 19);
            lblPrixUniteMobile.TabIndex = 13;
            lblPrixUniteMobile.Text = "0";
            lblPrixUniteMobile.TextAlign = System.Drawing.ContentAlignment.TopRight;//fraManutention
            fraManutention.BackColor = System.Drawing.Color.Black;
            fraManutention.Controls.Add(txtPrixEmballage);
            fraManutention.Controls.Add(Label24);
            fraManutention.Controls.Add(Label33);
            fraManutention.Controls.Add(Label48);
            fraManutention.ForeColor = System.Drawing.Color.White;
            fraManutention.Location = new System.Drawing.Point(400, 192);
            fraManutention.Name = "fraManutention";
            fraManutention.Padding = new System.Windows.Forms.Padding(0);
            fraManutention.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraManutention.Size = new System.Drawing.Size(321, 57);
            fraManutention.TabIndex = 2;
            fraManutention.TabStop = false;
            fraManutention.Text = "Manutention";//txtPrixEmballage
            txtPrixEmballage.AcceptsReturn = true;
            txtPrixEmballage.BackColor = System.Drawing.SystemColors.Window;
            txtPrixEmballage.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixEmballage.ForeColor = System.Drawing.SystemColors.WindowText;
            txtPrixEmballage.Location = new System.Drawing.Point(248, 32);
            txtPrixEmballage.MaxLength = 0;
            txtPrixEmballage.Name = "txtPrixEmballage";
            txtPrixEmballage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixEmballage.Size = new System.Drawing.Size(49, 19);
            txtPrixEmballage.TabIndex = 3;
            txtPrixEmballage.Text = "0";
            txtPrixEmballage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtPrixEmballage.TextChanged += new System.EventHandler(txtPrixEmballage_TextChanged);
            txtPrixEmballage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPrixEmballage_KeyPress);
            txtPrixEmballage.Leave += new System.EventHandler(txtPrixEmballage_Leave);//Label24
            Label24.BackColor = System.Drawing.Color.Black;
            Label24.Cursor = System.Windows.Forms.Cursors.Default;
            Label24.ForeColor = System.Drawing.Color.White;
            Label24.Location = new System.Drawing.Point(8, 32);
            Label24.Name = "Label24";
            Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label24.Size = new System.Drawing.Size(153, 17);
            Label24.TabIndex = 6;
            Label24.Text = "Frais de transport / emballage :";//Label33
            Label33.BackColor = System.Drawing.Color.Black;
            Label33.Cursor = System.Windows.Forms.Cursors.Default;
            Label33.ForeColor = System.Drawing.Color.White;
            Label33.Location = new System.Drawing.Point(248, 8);
            Label33.Name = "Label33";
            Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label33.Size = new System.Drawing.Size(49, 17);
            Label33.TabIndex = 5;
            Label33.Text = "Prix";
            Label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;//Label48
            Label48.BackColor = System.Drawing.Color.Black;
            Label48.Cursor = System.Windows.Forms.Cursors.Default;
            Label48.ForeColor = System.Drawing.Color.White;
            Label48.Location = new System.Drawing.Point(304, 32);
            Label48.Name = "Label48";
            Label48.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label48.Size = new System.Drawing.Size(9, 17);
            Label48.TabIndex = 4;
            Label48.Text = "$";//cmdFermer
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.Cursor = System.Windows.Forms.Cursors.Default;
            cmdFermer.ForeColor = System.Drawing.Color.White;
            cmdFermer.Location = new System.Drawing.Point(640, 504);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(81, 25);
            cmdFermer.TabIndex = 1;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(cmdFermer_Click);//cmdDetail
            cmdDetail.BackColor = System.Drawing.Color.Black;
            cmdDetail.Cursor = System.Windows.Forms.Cursors.Default;
            cmdDetail.ForeColor = System.Drawing.Color.White;
            cmdDetail.Location = new System.Drawing.Point(232, 504);
            cmdDetail.Name = "cmdDetail";
            cmdDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDetail.Size = new System.Drawing.Size(49, 25);
            cmdDetail.TabIndex = 0;
            cmdDetail.Text = "Détails";
            cmdDetail.UseVisualStyleBackColor = true;
            cmdDetail.Click += new System.EventHandler(cmdDetail_Click);//Label52
            Label52.BackColor = System.Drawing.Color.Black;
            Label52.Cursor = System.Windows.Forms.Cursors.Default;
            Label52.ForeColor = System.Drawing.Color.White;
            Label52.Location = new System.Drawing.Point(16, 472);
            Label52.Name = "Label52";
            Label52.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label52.Size = new System.Drawing.Size(153, 17);
            Label52.TabIndex = 103;
            Label52.Text = "Total de la ressource humaine :";//Label25
            Label25.BackColor = System.Drawing.Color.Black;
            Label25.Cursor = System.Windows.Forms.Cursors.Default;
            Label25.ForeColor = System.Drawing.Color.White;
            Label25.Location = new System.Drawing.Point(592, 264);
            Label25.Name = "Label25";
            Label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label25.Size = new System.Drawing.Size(41, 17);
            Label25.TabIndex = 102;
            Label25.Text = "TOTAL :";//Label26
            Label26.BackColor = System.Drawing.Color.Black;
            Label26.Cursor = System.Windows.Forms.Cursors.Default;
            Label26.ForeColor = System.Drawing.Color.White;
            Label26.Location = new System.Drawing.Point(704, 264);
            Label26.Name = "Label26";
            Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label26.Size = new System.Drawing.Size(9, 17);
            Label26.TabIndex = 101;
            Label26.Text = "$";//Label50
            Label50.BackColor = System.Drawing.Color.Black;
            Label50.Cursor = System.Windows.Forms.Cursors.Default;
            Label50.ForeColor = System.Drawing.Color.White;
            Label50.Location = new System.Drawing.Point(288, 472);
            Label50.Name = "Label50";
            Label50.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label50.Size = new System.Drawing.Size(17, 17);
            Label50.TabIndex = 100;
            Label50.Text = "Hrs";//lblDollarRH
            lblDollarRH.BackColor = System.Drawing.Color.Black;
            lblDollarRH.Cursor = System.Windows.Forms.Cursors.Default;
            lblDollarRH.ForeColor = System.Drawing.Color.White;
            lblDollarRH.Location = new System.Drawing.Point(376, 472);
            lblDollarRH.Name = "lblDollarRH";
            lblDollarRH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDollarRH.Size = new System.Drawing.Size(9, 17);
            lblDollarRH.TabIndex = 99;
            lblDollarRH.Text = "$";//lblTotalTempsRHSoum
            lblTotalTempsRHSoum.BackColor = System.Drawing.Color.Black;
            lblTotalTempsRHSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsRHSoum.Cursor = System.Windows.Forms.Cursors.Default;
            lblTotalTempsRHSoum.ForeColor = System.Drawing.Color.White;
            lblTotalTempsRHSoum.Location = new System.Drawing.Point(176, 472);
            lblTotalTempsRHSoum.Name = "lblTotalTempsRHSoum";
            lblTotalTempsRHSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTotalTempsRHSoum.Size = new System.Drawing.Size(49, 19);
            lblTotalTempsRHSoum.TabIndex = 98;//lblTotalTempsRHReel
            lblTotalTempsRHReel.BackColor = System.Drawing.Color.Black;
            lblTotalTempsRHReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsRHReel.Cursor = System.Windows.Forms.Cursors.Default;
            lblTotalTempsRHReel.ForeColor = System.Drawing.Color.White;
            lblTotalTempsRHReel.Location = new System.Drawing.Point(232, 472);
            lblTotalTempsRHReel.Name = "lblTotalTempsRHReel";
            lblTotalTempsRHReel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTotalTempsRHReel.Size = new System.Drawing.Size(49, 19);
            lblTotalTempsRHReel.TabIndex = 97;//lblTotalPrixRH
            lblTotalPrixRH.BackColor = System.Drawing.Color.Black;
            lblTotalPrixRH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalPrixRH.Cursor = System.Windows.Forms.Cursors.Default;
            lblTotalPrixRH.ForeColor = System.Drawing.Color.White;
            lblTotalPrixRH.Location = new System.Drawing.Point(320, 472);
            lblTotalPrixRH.Name = "lblTotalPrixRH";
            lblTotalPrixRH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTotalPrixRH.Size = new System.Drawing.Size(49, 19);
            lblTotalPrixRH.TabIndex = 96;
            lblTotalPrixRH.Text = "0";
            lblTotalPrixRH.TextAlign = System.Drawing.ContentAlignment.TopRight;//lblTotal
            lblTotal.BackColor = System.Drawing.Color.Black;
            lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            lblTotal.ForeColor = System.Drawing.Color.White;
            lblTotal.Location = new System.Drawing.Point(648, 264);
            lblTotal.Name = "lblTotal";
            lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTotal.Size = new System.Drawing.Size(49, 19);
            lblTotal.TabIndex = 95;
            lblTotal.Text = "0";
            lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;//ProjSoumElecTemp
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(735, 540);
            ControlBox = false;
            Controls.Add(fraRessourcesHumaines);
            Controls.Add(fraFraisSubsistences);
            Controls.Add(fraManutention);
            Controls.Add(cmdFermer);
            Controls.Add(cmdDetail);
            Controls.Add(Label52);
            Controls.Add(Label25);
            Controls.Add(Label26);
            Controls.Add(Label50);
            Controls.Add(lblDollarRH);
            Controls.Add(lblTotalTempsRHSoum);
            Controls.Add(lblTotalTempsRHReel);
            Controls.Add(lblTotalPrixRH);
            Controls.Add(lblTotal);
            Cursor = System.Windows.Forms.Cursors.Default;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(3, 22);
            Name = "ProjSoumElecTemp";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            Load += new System.EventHandler(ProjSoumElecTemp_Load);
            fraRessourcesHumaines.ResumeLayout(false);
            fraFraisSubsistences.ResumeLayout(false);
            fraManutention.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        string NoProjSoum;
        short m_eType;
        short m_eMode;
        bool opt = false;
        private string m_sTauxDessin;
        private string m_sTauxFabrication;
        private string m_sTauxAssemblage;
        private string m_sTauxProgInterface;
        private string m_sTauxProgAutomate;
        private string m_sTauxProgRobot;
        private string m_sTauxVision;
        private string m_sTauxTest;
        private string m_sTauxInstallation;
        private string m_sTauxMiseService;
        private string m_sTauxFormation;
        private string m_sTauxGestion;
        private string m_sTauxShipping;
        private string m_sRepas;
        private string m_sHebergement1;
        private string m_sHebergement2;
        private string m_sStandard;
        private string m_sUniteMobile;
        private string m_sNoProjSoum;
        private bool m_bNouveauTaux;
        private bool m_bSansTemps;
        private bool bNouveauTaux;
        public ProjSoumElecTemp()
        {
            InitializeComponent();
        }
        public ProjSoumElecTemp(string noProjSoum, short eType, short eMode, bool opt)
        {
            InitializeComponent();
            NoProjSoum = noProjSoum;
            m_eType = eType;
            m_eMode = eMode;
            opt = opt;
            try
            {
                m_eType = eType; m_eMode = eMode; m_sNoProjSoum = noProjSoum; m_bNouveauTaux = bNouveauTaux; if (bNouveauTaux == true)
                {
                    InitialiserVariablesConfig();
                }
                else
                {
                    InitialiserVariablesProjSoum();
                }
                if (m_eMode == (short)EnumMode.MODE_AJOUT_MODIF)
                {
                    BarrerChamps(false);
                }
                else
                {
                    BarrerChamps(true);
                }
                AfficherEnregistrement(); ShowDialog(); return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElecTemps", "Afficher", ex);
            }
        }
        private void ProjSoumElecTemp_Load(object sender, EventArgs e)
        {
        }
        private void AfficherEnregistrement()
        {
            try
            {
                ADODB.Recordset rstProjSoum = new ADODB.Recordset();
                ADODB.Recordset rstSoum;
                string sChamps;
                string sTable; if (m_eType == (short)EnumType.TYPE_PROJET)
                {
                    sChamps = "IDProjet";
                    sTable = "ProjetElec";
                }
                else
                {
                    sChamps = "IDSoumission";
                    sTable = "SoumissionElec";
                }
                rstProjSoum.Open("SELECT * FROM " + sTable + " WHERE " + sChamps + " = '" + m_sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (!rstProjSoum.EOF & m_bTempsDejaOuvert == false & m_eMode == (short)EnumMode.MODE_INACTIF)
                {
                    m_bSansTemps = (bool)rstProjSoum.Fields["SansTemps"].Value;
                    if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull))
                    {
                        txtTempsDessinSoum.Text = (string)(rstProjSoum.Fields["TempsDessin"].Value);
                    }
                    else
                    {
                        txtTempsDessinSoum.Text = "0";
                    }
                    if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                    {
                        if (!(rstProjSoum.Fields["TempsFabrication"].Value is DBNull))
                        {
                            lblTempsFabricationSoum.Text = (string)(rstProjSoum.Fields["TempsFabrication"].Value);
                        }
                        else
                        {
                            lblTempsFabricationSoum.Text = "0";
                        }
                    }
                    else
                    {
                        lblTempsFabricationSoum.Text = CalculerTempsFabrication();
                    }
                    if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull))
                    {
                        txtTempsAssemblageSoum.Text = (string)(rstProjSoum.Fields["TempsAssemblage"].Value);
                    }
                    else
                    {
                        txtTempsAssemblageSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsProgInterface"].Value is DBNull))
                    {
                        txtTempsProgInterfaceSoum.Text = (string)(rstProjSoum.Fields["TempsProgInterface"].Value);
                    }
                    else
                    {
                        txtTempsProgInterfaceSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsProgAutomate"].Value is DBNull))
                    {
                        txtTempsProgAutomateSoum.Text = (string)(rstProjSoum.Fields["TempsProgAutomate"].Value);
                    }
                    else
                    {
                        txtTempsProgAutomateSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsProgRobot"].Value is DBNull))
                    {
                        txtTempsProgRobotSoum.Text = (string)(rstProjSoum.Fields["TempsProgRobot"].Value);
                    }
                    else
                    {
                        txtTempsProgRobotSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsVision"].Value is DBNull))
                    {
                        txtTempsVisionSoum.Text = (string)(rstProjSoum.Fields["TempsVision"].Value);
                    }
                    else
                    {
                        txtTempsVisionSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull))
                    {
                        txtTempsTestSoum.Text = (string)(rstProjSoum.Fields["TempsTest"].Value);
                    }
                    else
                    {
                        txtTempsTestSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull))
                    {
                        txtTempsInstallationSoum.Text = (string)(rstProjSoum.Fields["TempsInstallation"].Value);
                    }
                    else
                    {
                        txtTempsInstallationSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsMiseService"].Value is DBNull))
                    {
                        txtTempsMiseServiceSoum.Text = (string)(rstProjSoum.Fields["TempsMiseService"].Value);
                    }
                    else
                    {
                        txtTempsMiseServiceSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull))
                    {
                        txtTempsFormationSoum.Text = (string)(rstProjSoum.Fields["TempsFormation"].Value);
                    }
                    else
                    {
                        txtTempsFormationSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull))
                    {
                        txtTempsGestionSoum.Text = (string)(rstProjSoum.Fields["TempsGestion"].Value);
                    }
                    else
                    {
                        txtTempsGestionSoum.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull))
                    {
                        txtTempsShippingSoum.Text = (string)(rstProjSoum.Fields["TempsShipping"].Value);
                    }
                    else
                    {
                        txtTempsShippingSoum.Text = "0";
                    }
                    txtTempsprototypeSoum.Text = "0"; if (Droite(m_sNoProjSoum, 2) != "99")
                    {
                        if (!(rstProjSoum.Fields["NbrePersonne"].Value is DBNull))
                        {
                            txtNbrePersonne.Text = (string)(rstProjSoum.Fields["NbrePersonne"].Value);
                        }
                        else
                        {
                            txtNbrePersonne.Text = "0";
                        }
                        if (!(rstProjSoum.Fields["TempsHebergement"].Value is DBNull))
                        {
                            txtTempsHebergement.Text = (string)(rstProjSoum.Fields["TempsHebergement"].Value);
                        }
                        else
                        {
                            txtTempsHebergement.Text = "0";
                        }
                        if (!(rstProjSoum.Fields["TempsRepas"].Value is DBNull))
                        {
                            txtTempsRepas.Text = (string)(rstProjSoum.Fields["TempsRepas"].Value);
                        }
                        else
                        {
                            txtTempsRepas.Text = "0";
                        }
                    }
                    else
                    {
                        if (!(rstProjSoum.Fields["TotalHebergement"].Value is DBNull))
                        {
                            lblPrixHebergement.Text = (string)(rstProjSoum.Fields["TotalHebergement"].Value);
                        }
                        if (!(rstProjSoum.Fields["TotalRepas"].Value is DBNull))
                        {
                            lblPrixRepas.Text = (string)(rstProjSoum.Fields["TotalRepas"].Value);
                        }
                    }
                    if (!(rstProjSoum.Fields["TempsTransport"].Value is DBNull))
                    {
                        txtTempsDeplacement.Text = (string)(rstProjSoum.Fields["TempsTransport"].Value);
                    }
                    else
                    {
                        txtTempsDeplacement.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["TempsUniteMobile"].Value is DBNull))
                    {
                        txtTempsUniteMobile.Text = (string)(rstProjSoum.Fields["TempsUniteMobile"].Value);
                    }
                    else
                    {
                        txtTempsUniteMobile.Text = "0";
                    }
                    if (!(rstProjSoum.Fields["PrixEmballage"].Value is DBNull))
                    {
                        txtPrixEmballage.Text = (string)(rstProjSoum.Fields["PrixEmballage"].Value);
                    }
                    else
                    {
                        txtPrixEmballage.Text = "0";
                    }
                }
                else
                {
                    if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                    {
                        m_bSansTemps = ProjSoumElec.m_bSansTemps; txtTempsDessinSoum.Text = ProjSoumElec.m_sTempsDessin;
                        lblTempsFabricationSoum.Text = ProjSoumElec.m_sTempsFabrication;
                        txtTempsAssemblageSoum.Text = ProjSoumElec.m_sTempsAssemblage;
                        txtTempsProgInterfaceSoum.Text = ProjSoumElec.m_sTempsProgInterface;
                        txtTempsProgAutomateSoum.Text = ProjSoumElec.m_sTempsProgAutomate;
                        txtTempsProgRobotSoum.Text = ProjSoumElec.m_sTempsProgRobot;
                        txtTempsVisionSoum.Text = ProjSoumElec.m_sTempsVision;
                        txtTempsTestSoum.Text = ProjSoumElec.m_sTempsTest;
                        txtTempsInstallationSoum.Text = ProjSoumElec.m_sTempsInstallation;
                        txtTempsMiseServiceSoum.Text = ProjSoumElec.m_sTempsMiseService;
                        txtTempsFormationSoum.Text = ProjSoumElec.m_sTempsFormation;
                        txtTempsGestionSoum.Text = ProjSoumElec.m_sTempsGestion;
                        txtTempsShippingSoum.Text = ProjSoumElec.m_sTempsShipping;
                    }
                    else if (!rstProjSoum.EOF & !(rstProjSoum.Fields["IDSoumission"].Value is DBNull))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstProjSoum.Fields["IDSoumission"].Value, "", false)))
                        {
                            rstSoum = new Recordset(); rstSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + rstProjSoum.Fields["IDSoumission"].Value + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (!rstSoum.EOF)
                            {
                                m_bSansTemps = ProjSoumElec.m_bSansTemps; if (!(rstSoum.Fields["TempsDessin"].Value is DBNull))
                                {
                                    txtTempsDessinSoum.Text = (string)(rstSoum.Fields["TempsDessin"].Value);
                                }
                                else
                                {
                                    txtTempsDessinSoum.Text = "0";
                                }
                                if (m_eType == (short)EnumType.TYPE_PROJET)
                                {
                                    lblTempsFabricationSoum.Text = CalculerTempsFabrication();
                                }
                                else if (!(rstSoum.Fields["TempsFabrication"].Value is DBNull))
                                {
                                    lblTempsFabricationSoum.Text = (string)(rstSoum.Fields["TempsFabrication"].Value);
                                }
                                else
                                {
                                    lblTempsFabricationSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsAssemblage"].Value is DBNull))
                                {
                                    txtTempsAssemblageSoum.Text = (string)(rstSoum.Fields["TempsAssemblage"].Value);
                                }
                                else
                                {
                                    txtTempsAssemblageSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsProgInterface"].Value is DBNull))
                                {
                                    txtTempsProgInterfaceSoum.Text = (string)(rstSoum.Fields["TempsProgInterface"].Value);
                                }
                                else
                                {
                                    txtTempsProgInterfaceSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsProgAutomate"].Value is DBNull))
                                {
                                    txtTempsProgAutomateSoum.Text = (string)(rstSoum.Fields["TempsProgAutomate"].Value);
                                }
                                else
                                {
                                    txtTempsProgAutomateSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsProgRobot"].Value is DBNull))
                                {
                                    txtTempsProgRobotSoum.Text = (string)(rstSoum.Fields["TempsProgRobot"].Value);
                                }
                                else
                                {
                                    txtTempsProgRobotSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsVision"].Value is DBNull))
                                {
                                    txtTempsVisionSoum.Text = (string)(rstSoum.Fields["TempsVision"].Value);
                                }
                                else
                                {
                                    txtTempsVisionSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsTest"].Value is DBNull))
                                {
                                    txtTempsTestSoum.Text = (string)(rstSoum.Fields["TempsTest"].Value);
                                }
                                else
                                {
                                    txtTempsTestSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsInstallation"].Value is DBNull))
                                {
                                    txtTempsInstallationSoum.Text = (string)(rstSoum.Fields["TempsInstallation"].Value);
                                }
                                else
                                {
                                    txtTempsInstallationSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsMiseService"].Value is DBNull))
                                {
                                    txtTempsMiseServiceSoum.Text = (string)(rstSoum.Fields["TempsMiseService"].Value);
                                }
                                else
                                {
                                    txtTempsMiseServiceSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsFormation"].Value is DBNull))
                                {
                                    txtTempsFormationSoum.Text = (string)(rstSoum.Fields["TempsFormation"].Value);
                                }
                                else
                                {
                                    txtTempsFormationSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsGestion"].Value is DBNull))
                                {
                                    txtTempsGestionSoum.Text = (string)(rstSoum.Fields["TempsGestion"].Value);
                                }
                                else
                                {
                                    txtTempsGestionSoum.Text = "0";
                                }
                                if (!(rstSoum.Fields["TempsShipping"].Value is DBNull))
                                {
                                    txtTempsShippingSoum.Text = (string)(rstSoum.Fields["TempsShipping"].Value);
                                }
                                else
                                {
                                    txtTempsShippingSoum.Text = "0";
                                }
                            }
                            else
                            {
                                m_bSansTemps = false; txtTempsDessinSoum.Text = "0";
                                lblTempsFabricationSoum.Text = CalculerTempsFabrication();
                                txtTempsAssemblageSoum.Text = "0";
                                txtTempsProgInterfaceSoum.Text = "0";
                                txtTempsProgAutomateSoum.Text = "0";
                                txtTempsProgRobotSoum.Text = "0";
                                txtTempsVisionSoum.Text = "0";
                                txtTempsTestSoum.Text = "0";
                                txtTempsInstallationSoum.Text = "0";
                                txtTempsMiseServiceSoum.Text = "0";
                                txtTempsFormationSoum.Text = "0";
                                txtTempsGestionSoum.Text = "0";
                                txtTempsShippingSoum.Text = "0";
                            }
                            rstSoum.Close();
                            rstSoum = null;
                        }
                        else
                        {
                            m_bSansTemps = false; txtTempsDessinSoum.Text = "0";
                            lblTempsFabricationSoum.Text = CalculerTempsFabrication();
                            txtTempsAssemblageSoum.Text = "0";
                            txtTempsProgInterfaceSoum.Text = "0";
                            txtTempsProgAutomateSoum.Text = "0";
                            txtTempsProgRobotSoum.Text = "0";
                            txtTempsVisionSoum.Text = "0";
                            txtTempsTestSoum.Text = "0";
                            txtTempsInstallationSoum.Text = "0";
                            txtTempsMiseServiceSoum.Text = "0";
                            txtTempsFormationSoum.Text = "0";
                            txtTempsGestionSoum.Text = "0";
                            txtTempsShippingSoum.Text = "0";
                        }
                    }
                    else
                    {
                        m_bSansTemps = false; txtTempsDessinSoum.Text = "0";
                        lblTempsFabricationSoum.Text = CalculerTempsFabrication();
                        txtTempsAssemblageSoum.Text = "0";
                        txtTempsProgInterfaceSoum.Text = "0";
                        txtTempsProgAutomateSoum.Text = "0";
                        txtTempsProgRobotSoum.Text = "0";
                        txtTempsVisionSoum.Text = "0";
                        txtTempsTestSoum.Text = "0";
                        txtTempsInstallationSoum.Text = "0";
                        txtTempsMiseServiceSoum.Text = "0";
                        txtTempsFormationSoum.Text = "0";
                        txtTempsGestionSoum.Text = "0";
                        txtTempsShippingSoum.Text = "0";
                    }
                    txtNbrePersonne.Text = ProjSoumElec.m_sNbrePersonne;
                    txtTempsHebergement.Text = ProjSoumElec.m_sTempsHebergement;
                    txtTempsRepas.Text = ProjSoumElec.m_sTempsRepas;
                    txtTempsDeplacement.Text = ProjSoumElec.m_sTempsTransport;
                    txtTempsUniteMobile.Text = ProjSoumElec.m_sTempsUniteMobile;
                    txtPrixEmballage.Text = ProjSoumElec.m_sPrixEmballage;
                }
                if (m_eType == (short)EnumType.TYPE_PROJET)
                {
                    AfficherTempsReels(); CalculerTotalArgent();
                }
                rstProjSoum.Close();
                rstProjSoum = null; return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "AfficherEnregistrement", ex); }
        }
        private void AfficherTempsReels()
        {
            try
            {
                Recordset rstPunch;
                string sDateDebut;
                string sDateFin;
                string sTotal;
                string sFilterNoProjet; sDateDebut = "TIMESERIAL(Left(Punch.HeureDébut,2),RIGHT(Punch.HeureDébut,2),0)"; sDateFin = "TIMESERIAL(Left(Punch.HeureFin,2),RIGHT(Punch.HeureFin,2),0)"; sTotal = "(SUM(" + sDateFin + " - " + sDateDebut + ")* 24) As Total"; if (Droite(m_sNoProjSoum, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(m_sNoProjSoum, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + m_sNoProjSoum + "'";
                }
                rstPunch = new Recordset(); 
                rstPunch.Open("SELECT Type, " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null GROUP BY Type", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); lblTempsDessinReel.Text = "0";
                lblTempsFabricationReel.Text = "0";
                lblTempsAssemblageReel.Text = "0";
                lblTempsProgInterfaceReel.Text = "0";
                lblTempsProgAutomateReel.Text = "0";
                lblTempsProgRobotReel.Text = "0";
                lblTempsVisionReel.Text = "0";
                lblTempsTestReel.Text = "0";
                lblTempsInstallationReel.Text = "0";
                lblTempsMiseServiceReel.Text = "0";
                lblTempsFormationReel.Text = "0";
                lblTempsGestionReel.Text = "0";
                lblTempsShippingReel.Text = "0";
                lblTempsPrototypeReel.Text = "0"; while (!rstPunch.EOF)
                {
                    if (!(rstPunch.Fields["Total"].Value is DBNull))
                    {
                        switch (rstPunch.Fields["Type"].Value)
                        {
                            case "Dessin": { lblTempsDessinReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "Fabrication": { lblTempsFabricationReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "Assemblage": { lblTempsAssemblageReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "ProgInterface": { lblTempsProgInterfaceReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "ProgAutomate": { lblTempsProgAutomateReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "ProgRobot": { lblTempsProgRobotReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "Vision": { lblTempsVisionReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "Test": { lblTempsTestReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "Installation": { lblTempsInstallationReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "MiseService": { lblTempsMiseServiceReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "Formation": { lblTempsFormationReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "Gestion": { lblTempsGestionReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "Shipping": { lblTempsShippingReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                            case "Prototypage-Dévelloppement expérimental": { lblTempsPrototypeReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2)); break; }
                        }
                    }
                    rstPunch.MoveNext();
                }
                rstPunch.Close(); rstPunch.Open("SELECT " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); if (!(rstPunch.Fields["Total"].Value is DBNull))
                {
                    lblTotalTempsRHReel.Text = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                }
                else
                {
                    lblTotalTempsRHReel.Text = "0";
                }
                rstPunch.Close();
                rstPunch = null; return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "AfficherTempsReels", ex); }
        }
        private void CalculerTotalArgent()
        {
            try
            {
                if (IsNumeric(lblTempsDessinReel.Text))
                {
                    lblPrixDessin.Text = Math.Round(double.Parse(lblTempsDessinReel.Text) * double.Parse(m_sTauxDessin), 2).ToString();
                }
                else
                {
                    lblPrixDessin.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsFabricationReel.Text))
                {
                    lblPrixFabrication.Text = Math.Round(double.Parse(lblTempsFabricationReel.Text) * double.Parse(m_sTauxFabrication), 2).ToString();
                }
                else
                {
                    lblPrixFabrication.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsAssemblageReel.Text))
                {
                    lblPrixAssemblage.Text = Math.Round(double.Parse(lblTempsAssemblageReel.Text) * double.Parse(m_sTauxAssemblage), 2).ToString();
                }
                else
                {
                    lblPrixAssemblage.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsProgInterfaceReel.Text))
                {
                    lblPrixProgInterface.Text = Math.Round(double.Parse(lblTempsProgInterfaceReel.Text) * double.Parse(m_sTauxProgInterface), 2).ToString();
                }
                else
                {
                    lblPrixProgInterface.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsProgAutomateReel.Text))
                {
                    lblPrixProgAutomate.Text = Math.Round(double.Parse(lblTempsProgAutomateReel.Text) * double.Parse(m_sTauxProgAutomate), 2).ToString();
                }
                else
                {
                    lblPrixProgAutomate.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsProgRobotReel.Text))
                {
                    lblPrixProgRobot.Text = Math.Round(double.Parse(lblTempsProgRobotReel.Text) * double.Parse(m_sTauxProgRobot), 2).ToString();
                }
                else
                {
                    lblPrixProgRobot.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsVisionReel.Text))
                {
                    lblPrixVision.Text = Math.Round(double.Parse(lblTempsVisionReel.Text) * double.Parse(m_sTauxVision), 2).ToString();
                }
                else
                {
                    lblPrixVision.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsTestReel.Text))
                {
                    lblPrixTest.Text = Math.Round(double.Parse(lblTempsTestReel.Text) * double.Parse(m_sTauxTest), 2).ToString();
                }
                else
                {
                    lblPrixTest.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsInstallationReel.Text))
                {
                    lblPrixInstallation.Text = Math.Round(double.Parse(lblTempsInstallationReel.Text) * double.Parse(m_sTauxInstallation), 2).ToString();
                }
                else
                {
                    lblPrixInstallation.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsMiseServiceReel.Text))
                {
                    lblPrixMiseService.Text = Math.Round(double.Parse(lblTempsMiseServiceReel.Text) * double.Parse(m_sTauxMiseService), 2).ToString();
                }
                else
                {
                    lblPrixMiseService.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsFormationReel.Text))
                {
                    lblPrixFormation.Text = Math.Round(double.Parse(lblTempsFormationReel.Text) * double.Parse(m_sTauxFormation), 2).ToString();
                }
                else
                {
                    lblPrixFormation.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsGestionReel.Text))
                {
                    lblPrixGestion.Text = Math.Round(double.Parse(lblTempsGestionReel.Text) * double.Parse(m_sTauxGestion), 2).ToString();
                }
                else
                {
                    lblPrixGestion.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsShippingReel.Text))
                {
                    lblPrixShipping.Text = Math.Round(double.Parse(lblTempsShippingReel.Text) * double.Parse(m_sTauxShipping), 2).ToString();
                }
                else
                {
                    lblPrixShipping.Text = 0.ToString();
                }
                if (IsNumeric(lblTempsPrototypeReel.Text))
                {
                    lblPrixPrototype.Text = Math.Round(double.Parse(lblTempsPrototypeReel.Text) * double.Parse(m_sTauxGestion), 2).ToString();
                }
                else
                {
                    lblPrixPrototype.Text = 0.ToString();
                }
                CalculerTotal(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "CalculerTotalArgent", ex); }
        }
        private void BarrerChamps(bool bLocked)
        {
            try
            {
                txtTempsDessinSoum.ReadOnly = bLocked;
                txtTempsAssemblageSoum.ReadOnly = bLocked;
                txtTempsProgInterfaceSoum.ReadOnly = bLocked;
                txtTempsProgAutomateSoum.ReadOnly = bLocked;
                txtTempsProgRobotSoum.ReadOnly = bLocked;
                txtTempsVisionSoum.ReadOnly = bLocked;
                txtTempsTestSoum.ReadOnly = bLocked;
                txtTempsInstallationSoum.ReadOnly = bLocked;
                txtTempsMiseServiceSoum.ReadOnly = bLocked;
                txtTempsFormationSoum.ReadOnly = bLocked;
                txtTempsGestionSoum.ReadOnly = bLocked;
                txtTempsShippingSoum.ReadOnly = bLocked; txtNbrePersonne.ReadOnly = bLocked;
                txtTempsHebergement.ReadOnly = bLocked;
                txtTempsRepas.ReadOnly = bLocked;
                txtTempsDeplacement.ReadOnly = bLocked;
                txtTempsUniteMobile.ReadOnly = bLocked; txtPrixEmballage.ReadOnly = bLocked; return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "BarrerChamps", ex); }
        }
        private void cmdDetail_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new Form(); if (m_eType == (short)EnumType.TYPE_PROJET)
                {
                    f = new DetailTemps(m_sNoProjSoum, EnumCatalogue.ELECTRIQUE, true);
                }
                else
                {
                    f = new DetailTemps(m_sNoProjSoum, EnumCatalogue.ELECTRIQUE, false);
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "cmdDetail_Click", ex); }
        }
        private void cmdFermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == (short)EnumMode.MODE_AJOUT_MODIF)
                {
                    EnregistrerTemps();
                }
                Close(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "cmdFermer_Click", ex); }
        }
        private void EnregistrerTemps()
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (!string.IsNullOrEmpty(txtTempsDessinSoum.Text.Trim()) & IsNumeric(txtTempsDessinSoum.Text))
                    {
                        ProjSoumElec.m_sTempsDessin = txtTempsDessinSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsDessin = "0";
                    }
                    if (!string.IsNullOrEmpty(lblTempsFabricationSoum.Text.Trim()))
                    {
                        ProjSoumElec.m_sTempsFabrication = lblTempsFabricationSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsFabrication = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsAssemblageSoum.Text.Trim()) & IsNumeric(txtTempsAssemblageSoum.Text))
                    {
                        ProjSoumElec.m_sTempsAssemblage = txtTempsAssemblageSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsAssemblage = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsProgInterfaceSoum.Text.Trim()) & IsNumeric(txtTempsProgInterfaceSoum.Text))
                    {
                        ProjSoumElec.m_sTempsProgInterface = txtTempsProgInterfaceSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsProgInterface = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsProgAutomateSoum.Text.Trim()) & IsNumeric(txtTempsProgAutomateSoum.Text))
                    {
                        ProjSoumElec.m_sTempsProgAutomate = txtTempsProgAutomateSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsProgAutomate = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsProgRobotSoum.Text.Trim()) & IsNumeric(txtTempsProgRobotSoum.Text))
                    {
                        ProjSoumElec.m_sTempsProgRobot = txtTempsProgRobotSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsProgRobot = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsVisionSoum.Text.Trim()) & IsNumeric(txtTempsVisionSoum.Text))
                    {
                        ProjSoumElec.m_sTempsVision = txtTempsVisionSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsVision = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsTestSoum.Text.Trim()) & IsNumeric(txtTempsTestSoum.Text))
                    {
                        ProjSoumElec.m_sTempsTest = txtTempsTestSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsTest = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsInstallationSoum.Text.Trim()) & IsNumeric(txtTempsInstallationSoum.Text))
                    {
                        ProjSoumElec.m_sTempsInstallation = txtTempsInstallationSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsInstallation = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsMiseServiceSoum.Text.Trim()) & IsNumeric(txtTempsMiseServiceSoum.Text))
                    {
                        ProjSoumElec.m_sTempsMiseService = txtTempsMiseServiceSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsMiseService = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsFormationSoum.Text.Trim()) & IsNumeric(txtTempsFormationSoum.Text))
                    {
                        ProjSoumElec.m_sTempsFormation = txtTempsFormationSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsFormation = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsGestionSoum.Text.Trim()) & IsNumeric(txtTempsGestionSoum.Text))
                    {
                        ProjSoumElec.m_sTempsGestion = txtTempsGestionSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsGestion = "0";
                    }
                    if (!string.IsNullOrEmpty(txtTempsShippingSoum.Text.Trim()) & IsNumeric(txtTempsShippingSoum.Text))
                    {
                        ProjSoumElec.m_sTempsShipping = txtTempsShippingSoum.Text;
                    }
                    else
                    {
                        ProjSoumElec.m_sTempsShipping = "0";
                    }
                }
                if (m_bSansTemps == true)
                {
                    ProjSoumElec.m_bSansTemps = true;
                }
                else
                {
                    ProjSoumElec.m_bSansTemps = false;
                }
                if (!string.IsNullOrEmpty(txtNbrePersonne.Text.Trim()) & IsNumeric(txtNbrePersonne.Text))
                {
                    ProjSoumElec.m_sNbrePersonne = txtNbrePersonne.Text;
                }
                else
                {
                    ProjSoumElec.m_sNbrePersonne = "0";
                }
                if (!string.IsNullOrEmpty(txtTempsHebergement.Text.Trim()) & IsNumeric(txtTempsHebergement.Text))
                {
                    ProjSoumElec.m_sTempsHebergement = txtTempsHebergement.Text;
                }
                else
                {
                    ProjSoumElec.m_sTempsHebergement = "0";
                }
                if (!string.IsNullOrEmpty(txtTempsRepas.Text.Trim()) & IsNumeric(txtTempsRepas.Text))
                {
                    ProjSoumElec.m_sTempsRepas = txtTempsRepas.Text;
                }
                else
                {
                    ProjSoumElec.m_sTempsRepas = "0";
                }
                if (!string.IsNullOrEmpty(txtTempsDeplacement.Text.Trim()) & IsNumeric(txtTempsDeplacement.Text))
                {
                    ProjSoumElec.m_sTempsTransport = txtTempsDeplacement.Text;
                }
                else
                {
                    ProjSoumElec.m_sTempsTransport = "0";
                }
                if (!string.IsNullOrEmpty(txtTempsUniteMobile.Text.Trim()) & IsNumeric(txtTempsUniteMobile.Text))
                {
                    ProjSoumElec.m_sTempsUniteMobile = txtTempsUniteMobile.Text;
                }
                else
                {
                    ProjSoumElec.m_sTempsUniteMobile = "0";
                }
                if (!string.IsNullOrEmpty(txtPrixEmballage.Text.Trim()) & IsNumeric(txtPrixEmballage.Text))
                {
                    ProjSoumElec.m_sPrixEmballage = txtPrixEmballage.Text;
                }
                else
                {
                    ProjSoumElec.m_sPrixEmballage = "0";
                }
                ProjSoumElec.m_sTauxHebergement1 = m_sHebergement1;
                ProjSoumElec.m_sTauxHebergement2 = m_sHebergement2;
                ProjSoumElec.m_sTauxRepas = m_sRepas;
                ProjSoumElec.m_sTauxTransport = m_sStandard;
                ProjSoumElec.m_sTauxUniteMobile = m_sUniteMobile; return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "EnregistrerTemps", ex); }
        }
        private void InitialiserVariablesConfig()
        {
            try
            {
                ADODB.Recordset rstConfig; rstConfig = new Recordset(); rstConfig.Open("SELECT TauxDessinElec, TauxFabrication, TauxAssemblageElec, TauxProgInterface, TauxProgAutomate, " +
                    "TauxProgRobot, TauxVision, TauxTestElec, TauxInstallationElec, TauxMiseService, TauxFormationElec, TauxGestionProjetsElec, TauxShippingElec, Repas, Hebergement1, " +
                    "Hebergement2, Standard, UniteMobile FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!(rstConfig.Fields["TauxDessinElec"].Value is DBNull))
                {
                    m_sTauxDessin = (string)(rstConfig.Fields["TauxDessinElec"].Value);
                }
                else
                {
                    m_sTauxDessin = "0";
                }
                if (!(rstConfig.Fields["TauxFabrication"].Value is DBNull))
                {
                    m_sTauxFabrication = (string)(rstConfig.Fields["TauxFabrication"].Value);
                }
                else
                {
                    m_sTauxFabrication = "0";
                }
                if (!(rstConfig.Fields["TauxAssemblageElec"].Value is DBNull))
                {
                    m_sTauxAssemblage = (string)(rstConfig.Fields["TauxAssemblageElec"].Value);
                }
                else
                {
                    m_sTauxAssemblage = "0";
                }
                if (!(rstConfig.Fields["TauxProgInterface"].Value is DBNull))
                {
                    m_sTauxProgInterface = (string)(rstConfig.Fields["TauxProgInterface"].Value);
                }
                else
                {
                    m_sTauxProgInterface = "0";
                }
                if (!(rstConfig.Fields["TauxProgAutomate"].Value is DBNull))
                {
                    m_sTauxProgAutomate = (string)(rstConfig.Fields["TauxProgAutomate"].Value);
                }
                else
                {
                    m_sTauxProgAutomate = "0";
                }
                if (!(rstConfig.Fields["TauxProgRobot"].Value is DBNull))
                {
                    m_sTauxProgRobot = (string)(rstConfig.Fields["TauxProgRobot"].Value);
                }
                else
                {
                    m_sTauxProgRobot = "0";
                }
                if (!(rstConfig.Fields["TauxVision"].Value is DBNull))
                {
                    m_sTauxVision = (string)(rstConfig.Fields["TauxVision"].Value);
                }
                else
                {
                    m_sTauxVision = "0";
                }
                if (!(rstConfig.Fields["TauxTestElec"].Value is DBNull))
                {
                    m_sTauxTest = (string)(rstConfig.Fields["TauxTestElec"].Value);
                }
                else
                {
                    m_sTauxTest = "0";
                }
                if (!(rstConfig.Fields["TauxInstallationElec"].Value is DBNull))
                {
                    m_sTauxInstallation = (string)(rstConfig.Fields["TauxInstallationElec"].Value);
                }
                else
                {
                    m_sTauxInstallation = "0";
                }
                if (!(rstConfig.Fields["TauxMiseService"].Value is DBNull))
                {
                    m_sTauxMiseService = (string)(rstConfig.Fields["TauxMiseService"].Value);
                }
                else
                {
                    m_sTauxMiseService = "0";
                }
                if (!(rstConfig.Fields["TauxFormationElec"].Value is DBNull))
                {
                    m_sTauxFormation = (string)(rstConfig.Fields["TauxFormationElec"].Value);
                }
                else
                {
                    m_sTauxFormation = "0";
                }
                if (!(rstConfig.Fields["TauxGestionProjetsElec"].Value is DBNull))
                {
                    m_sTauxGestion = (string)(rstConfig.Fields["TauxGestionProjetsElec"].Value);
                }
                else
                {
                    m_sTauxGestion = "0";
                }
                if (!(rstConfig.Fields["TauxShippingElec"].Value is DBNull))
                {
                    m_sTauxShipping = (string)(rstConfig.Fields["TauxShippingElec"].Value);
                }
                else
                {
                    m_sTauxShipping = "0";
                }
                m_sRepas = (string)(rstConfig.Fields["Repas"].Value);
                m_sHebergement1 = (string)(rstConfig.Fields["Hebergement1"].Value);
                m_sHebergement2 = (string)(rstConfig.Fields["Hebergement2"].Value);
                m_sStandard = (string)(rstConfig.Fields["Standard"].Value);
                m_sUniteMobile = (string)(rstConfig.Fields["UniteMobile"].Value); rstConfig.Close();
                //Object rstConfig rstConfig = null;return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "InitialiserVariablesConfig", ex); }
        }
        private void InitialiserVariablesProjSoum()
        {
            try
            {
                m_sTauxDessin = ProjSoumElec.m_sTauxDessin;
                m_sTauxFabrication = ProjSoumElec.m_sTauxFabrication;
                m_sTauxAssemblage = ProjSoumElec.m_sTauxAssemblage;
                m_sTauxProgInterface = ProjSoumElec.m_sTauxProgInterface;
                m_sTauxProgAutomate = ProjSoumElec.m_sTauxProgAutomate;
                m_sTauxProgRobot = ProjSoumElec.m_sTauxProgRobot;
                m_sTauxVision = ProjSoumElec.m_sTauxVision;
                m_sTauxTest = ProjSoumElec.m_sTauxTest;
                m_sTauxInstallation = ProjSoumElec.m_sTauxInstallation;
                m_sTauxMiseService = ProjSoumElec.m_sTauxMiseService;
                m_sTauxFormation = ProjSoumElec.m_sTauxFormation;
                m_sTauxGestion = ProjSoumElec.m_sTauxGestion;
                m_sTauxShipping = ProjSoumElec.m_sTauxShipping; m_sRepas = ProjSoumElec.m_sTauxRepas;
                m_sHebergement1 = ProjSoumElec.m_sTauxHebergement1;
                m_sHebergement2 = ProjSoumElec.m_sTauxHebergement2;
                m_sStandard = ProjSoumElec.m_sTauxTransport;
                m_sUniteMobile = ProjSoumElec.m_sTauxUniteMobile; return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "InitialiserVariablesProjSoum", ex); }
        }
        private void ProjSoumElecTemps_Load(object eventSender, EventArgs eventArgs)
        {
            try
            {

            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "Form_Load", ex); }
        }
        private void txtNbrePersonne_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTempsHebergement.Text))
                {
                    if (IsNumeric(txtNbrePersonne.Text))
                    {
                        CalculerHebergement();
                        CalculerRepas(); CalculerTotal();
                    }
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtNbrePersonne_Change", ex); }
        }
        private void txtPrixEmballage_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            if (eventArgs.KeyChar == 46) // Si c'est le "."
            {
                eventArgs.KeyChar = (char)44; // Remplace par la ","
            }
        }
        private void txtTempsHebergement_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (IsNumeric(txtTempsHebergement.Text))
                {
                    if (!string.IsNullOrEmpty(txtNbrePersonne.Text))
                    {
                        CalculerHebergement();
                    }
                }
                CalculerTotal(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsHebergement_Change", ex); }
        }
        private void txtTempsHebergement_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsHebergement.Text = txtTempsHebergement.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsHebergement_LostFocus", ex); }
        }
        private void txtTempsRepas_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (IsNumeric(txtTempsRepas.Text))
                {
                    if (!string.IsNullOrEmpty(txtNbrePersonne.Text))
                    {
                        CalculerRepas();
                    }
                }
                CalculerTotal(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsRepas_Change", ex); }
        }
        private void txtTempsRepas_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsRepas.Text = txtTempsRepas.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsRepas_LostFocus", ex); }
        }
        private void txtTempsDeplacement_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (IsNumeric(txtTempsDeplacement.Text))
                {
                    lblPrixDeplacement.Text = Math.Round(double.Parse(txtTempsDeplacement.Text) * double.Parse(m_sStandard), 2).ToString();
                }
                else
                {
                    lblPrixDeplacement.Text = 0.ToString();
                }
                CalculerTotal(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsDeplacement_Change", ex); }
        }
        private void txtTempsDeplacement_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsDeplacement.Text = txtTempsDeplacement.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsDeplacement_LostFocus", ex); }
        }
        private void txtTempsUniteMobile_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (IsNumeric(txtTempsUniteMobile.Text))
                {
                    lblPrixUniteMobile.Text = Math.Round(double.Parse(txtTempsUniteMobile.Text) * double.Parse(m_sUniteMobile), 2).ToString();
                }
                else
                {
                    lblPrixUniteMobile.Text = 0.ToString();
                }
                CalculerTotal(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsUniteMobile_Change", ex); }
        }
        private void txtTempsUniteMobile_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsUniteMobile.Text = txtTempsUniteMobile.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsUniteMobile_LostFocus", ex); }
        }
        private void txtPrixEmballage_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerTotal(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "lblPrixEmballage_Change", ex); }
        }
        private void txtPrixEmballage_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (IsNumeric(txtPrixEmballage.Text))
                {
                    txtPrixEmballage.Text = Math.Round(double.Parse(txtPrixEmballage.Text.Replace(".", ",")), 2).ToString();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "lblPrixEmballage_LostFocus", ex); }
        }
        private void txtTempsDessinSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsDessinSoum.Text))
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
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsDessinSoum_Change", ex); }
        }
        private void txtTempsDessinSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsDessinSoum.Text = txtTempsDessinSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsDessinSoum_LostFocus", ex); }
        }
        private void lblTempsFabricationSoum_Change()
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (m_bSansTemps == false)
                    {
                        if (IsNumeric(lblTempsFabricationSoum.Text))
                        {
                            lblPrixFabrication.Text = Math.Round(double.Parse(lblTempsFabricationSoum.Text) * double.Parse(m_sTauxFabrication), 2).ToString();
                        }
                        else
                        {
                            lblPrixFabrication.Text = "0";
                        }
                    }
                    else
                    {
                        lblPrixFabrication.Text = "0";
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsMécanique_Change", ex); }
        }
        private void txtTempsAssemblageSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsAssemblageSoum.Text))
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
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsAssemblageSoum_Change", ex); }
        }
        private void txtTempsAssemblageSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsAssemblageSoum.Text = txtTempsAssemblageSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsAssemblageSoum_LostFocus", ex); }
        }
        private void txtTempsProgInterfaceSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsProgInterfaceSoum.Text))
                    {
                        lblPrixProgInterface.Text = Math.Round(double.Parse(txtTempsProgInterfaceSoum.Text) * double.Parse(m_sTauxProgInterface), 2).ToString();
                    }
                    else
                    {
                        lblPrixProgInterface.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsProgInterfaceSoum_Change", ex); }
        }
        private void txtTempsProgInterfaceSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsProgInterfaceSoum.Text = txtTempsProgInterfaceSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsProgInterfaceSoum_LostFocus", ex); }
        }
        private void txtTempsProgAutomateSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsProgAutomateSoum.Text))
                    {
                        lblPrixProgAutomate.Text = Math.Round(double.Parse(txtTempsProgAutomateSoum.Text) * double.Parse(m_sTauxProgAutomate), 2).ToString();
                    }
                    else
                    {
                        lblPrixProgAutomate.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsProgAutomate_Change", ex); }
        }
        private void txtTempsProgAutomateSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsProgAutomateSoum.Text = txtTempsProgAutomateSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsProgAutomate_LostFocus", ex); }
        }
        private void txtTempsProgRobotSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsProgRobotSoum.Text))
                    {
                        lblPrixProgRobot.Text = Math.Round(double.Parse(txtTempsProgRobotSoum.Text) * double.Parse(m_sTauxProgRobot), 2).ToString();
                    }
                    else
                    {
                        lblPrixProgRobot.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsProgRobotSoum_Change", ex); }
        }
        private void txtTempsProgRobotSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsProgRobotSoum.Text = txtTempsProgRobotSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsProgRobotSoum_LostFocus", ex); }
        }
        private void txtTempsVisionSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsVisionSoum.Text))
                    {
                        lblPrixVision.Text = Math.Round(double.Parse(txtTempsVisionSoum.Text) * double.Parse(m_sTauxVision), 2).ToString();
                    }
                    else
                    {
                        lblPrixVision.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsVisionSoum_Change", ex); }
        }
        private void txtTempsVisionSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsVisionSoum.Text = txtTempsVisionSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsVisionSoum_LostFocus", ex); }
        }
        private void txtTempsTestSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsTestSoum.Text))
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
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsTestSoum_Change", ex); }
        }
        private void txtTempsTestSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsTestSoum.Text = txtTempsTestSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsTestSoum_LostFocus", ex); }
        }
        private void txtTempsInstallationSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsInstallationSoum.Text))
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
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsInstallationSoum_Change", ex); }
        }
        private void txtTempsInstallationSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsInstallationSoum.Text = txtTempsInstallationSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsInstallationSoum_LostFocus", ex); }
        }
        private void txtTempsMiseServiceSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsMiseServiceSoum.Text))
                    {
                        lblPrixMiseService.Text = Math.Round(double.Parse(txtTempsMiseServiceSoum.Text) * double.Parse(m_sTauxMiseService), 2).ToString();
                    }
                    else
                    {
                        lblPrixMiseService.Text = 0.ToString();
                    }
                    CalculerTotal();
                }
                return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsMiseServiceSoum_Change", ex); }
        }
        private void txtTempsMiseServiceSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsMiseServiceSoum.Text = txtTempsMiseServiceSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsMiseServiceSoum_LostFocus", ex); }
        }
        private void txtTempsFormationSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsFormationSoum.Text))
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
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsFormationSoum_Change", ex); }
        }
        private void txtTempsFormationSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsFormationSoum.Text = txtTempsFormationSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsFormationSoum_LostFocus", ex); }
        }
        private void txtTempsGestionSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsGestionSoum.Text))
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
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsGestionSoum_Change", ex); }
        }
        private void txtTempsGestionSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsGestionSoum.Text = txtTempsGestionSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsGestionSoum_LostFocus", ex); }
        }
        private void txtTempsShippingSoum_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eType == (short)EnumType.TYPE_SOUMISSION)
                {
                    if (IsNumeric(txtTempsShippingSoum.Text))
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
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsShippingSoum_Change", ex); }
        }
        private void txtTempsShippingSoum_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtTempsShippingSoum.Text = txtTempsShippingSoum.Text.Replace(".", ","); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "txtTempsShippingSoum_LostFocus", ex); }
        }
        private void CalculerHebergement()
        {
            try
            {
                double dblNbreDeux;
                double dblHebergement;
                short iReste;
                double dblNbrePers;
                double dblNbreJours; if (IsNumeric(txtNbrePersonne.Text))
                {
                    dblNbrePers = double.Parse(txtNbrePersonne.Text);
                }
                else
                {
                    dblNbrePers = 0d;
                }
                if (IsNumeric(txtTempsHebergement.Text))
                {
                    dblNbreJours = double.Parse(txtTempsHebergement.Text);
                }
                else
                {
                    dblNbreJours = 0d;
                }
                dblNbreDeux = dblNbrePers / 2; iReste = (short)Math.Round((short)Math.Round(dblNbrePers) - dblNbreDeux * 2d); dblHebergement = dblNbreJours * (dblNbreDeux * double.Parse(m_sHebergement2) + iReste * double.Parse(m_sHebergement1)); lblPrixHebergement.Text = Math.Round(dblHebergement, 2).ToString(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "CalculerHebergement", ex); }
        }
        private void CalculerRepas()
        {
            try
            {
                double dblNbrePers;
                double dblRepas;
                double dblNbreJours; if (IsNumeric(txtNbrePersonne.Text))
                {
                    dblNbrePers = double.Parse(txtNbrePersonne.Text);
                }
                else
                {
                    dblNbrePers = 0d;
                }
                if (IsNumeric(txtTempsRepas.Text))
                {
                    dblNbreJours = double.Parse(txtTempsRepas.Text);
                }
                else
                {
                    dblNbreJours = 0d;
                }
                dblRepas = dblNbreJours * dblNbrePers * double.Parse(m_sRepas); lblPrixRepas.Text = Math.Round(dblRepas, 2).ToString(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "CalculerRepas", ex); }
        }
        private void CalculerTotal()
        {
            double dblTotal;
            double dblPrixEmballage;
            double dblTotalArgentRH;
            double dblPrixDessin;
            double dblPrixFabrication;
            double dblPrixAssemblage;
            double dblPrixProgInterface;
            double dblPrixProgAutomate;
            double dblPrixProgRobot;
            double dblPrixVision;
            double dblPrixTest;
            double dblPrixInstallation;
            double dblPrixMiseService;
            double dblPrixFormation;
            double dblPrixGestion;
            double dblPrixShipping;
            double dblPrixPrototype;
            double dblPrixHebergement;
            double dblPrixRepas;
            double dblPrixDeplacement;
            double dblPrixUniteMobile;
            if (IsNumeric(lblPrixDessin.Text))
            {
                dblPrixDessin = double.Parse(lblPrixDessin.Text);
            }
            else
            {
                dblPrixDessin = 0d;
            }
            if (IsNumeric(lblPrixFabrication.Text))
            {
                dblPrixFabrication = double.Parse(lblPrixFabrication.Text);
            }
            else
            {
                dblPrixFabrication = 0d;
            }
            if (IsNumeric(lblPrixAssemblage.Text))
            {
                dblPrixAssemblage = double.Parse(lblPrixAssemblage.Text);
            }
            else
            {
                dblPrixAssemblage = 0d;
            }
            if (IsNumeric(lblPrixProgInterface.Text))
            {
                dblPrixProgInterface = double.Parse(lblPrixProgInterface.Text);
            }
            else
            {
                dblPrixProgInterface = 0d;
            }
            if (IsNumeric(lblPrixProgAutomate.Text))
            {
                dblPrixProgAutomate = double.Parse(lblPrixProgAutomate.Text);
            }
            else
            {
                dblPrixProgAutomate = 0d;
            }
            if (IsNumeric(lblPrixProgRobot.Text))
            {
                dblPrixProgRobot = double.Parse(lblPrixProgRobot.Text);
            }
            else
            {
                dblPrixProgRobot = 0d;
            }
            if (IsNumeric(lblPrixVision.Text))
            {
                dblPrixVision = double.Parse(lblPrixVision.Text);
            }
            else
            {
                dblPrixVision = 0d;
            }
            if (IsNumeric(lblPrixTest.Text))
            {
                dblPrixTest = double.Parse(lblPrixTest.Text);
            }
            else
            {
                dblPrixTest = 0d;
            }
            if (IsNumeric(lblPrixInstallation.Text))
            {
                dblPrixInstallation = double.Parse(lblPrixInstallation.Text);
            }
            else
            {
                dblPrixInstallation = 0d;
            }
            if (IsNumeric(lblPrixMiseService.Text))
            {
                dblPrixMiseService = double.Parse(lblPrixMiseService.Text);
            }
            else
            {
                dblPrixMiseService = 0d;
            }
            if (IsNumeric(lblPrixFormation.Text))
            {
                dblPrixFormation = double.Parse(lblPrixFormation.Text);
            }
            else
            {
                dblPrixFormation = 0d;
            }
            if (IsNumeric(lblPrixGestion.Text))
            {
                dblPrixGestion = double.Parse(lblPrixGestion.Text);
            }
            else
            {
                dblPrixGestion = 0d;
            }
            if (IsNumeric(lblPrixShipping.Text))
            {
                dblPrixShipping = double.Parse(lblPrixShipping.Text);
            }
            else
            {
                dblPrixShipping = 0d;
            }
            if (IsNumeric(lblPrixPrototype.Text))
            {
                dblPrixPrototype = double.Parse(lblPrixPrototype.Text);
            }
            else
            {
                dblPrixPrototype = 0d;
            }
            if (IsNumeric(lblPrixHebergement.Text))
            {
                dblPrixHebergement = double.Parse(lblPrixHebergement.Text);
            }
            else
            {
                dblPrixHebergement = 0d;
            }
            if (IsNumeric(lblPrixRepas.Text))
            {
                dblPrixRepas = double.Parse(lblPrixRepas.Text);
            }
            else
            {
                dblPrixRepas = 0d;
            }//Prix du déplacement
            if (IsNumeric(lblPrixDeplacement.Text))
            {
                dblPrixDeplacement = double.Parse(lblPrixDeplacement.Text);
            }
            else
            {
                dblPrixDeplacement = 0d;
            }//Prix de l'unité mobile
            if (IsNumeric(lblPrixUniteMobile.Text))
            {
                dblPrixUniteMobile = double.Parse(lblPrixUniteMobile.Text);
            }
            else
            {
                dblPrixUniteMobile = 0d;
            }//Prix de transport et emballage
            if (IsNumeric(txtPrixEmballage.Text))
            {
                dblPrixEmballage = double.Parse(txtPrixEmballage.Text);
            }
            else
            {
                dblPrixEmballage = 0d;
            }
            dblTotalArgentRH = dblPrixDessin + dblPrixFabrication + dblPrixAssemblage + dblPrixProgInterface + dblPrixProgAutomate + dblPrixProgRobot + dblPrixVision + dblPrixTest + dblPrixInstallation + dblPrixMiseService + dblPrixFormation + dblPrixGestion + dblPrixShipping + dblPrixPrototype;
            lblTotalPrixRH.Text = Conversion_Renamed(dblTotalArgentRH.ToString(), EnumConvert.MODE_DECIMAL);
            dblTotal = dblTotalArgentRH + dblPrixHebergement + dblPrixRepas + dblPrixDeplacement + dblPrixUniteMobile + dblPrixEmballage;
            lblTotal.Text = Conversion_Renamed(dblTotal.ToString(), EnumConvert.MODE_DECIMAL);
            CalculerTotalTemps();
            return;
        }
        private void CalculerTotalTemps()
        {
            try
            {
                double dblTempsDessin;
                double dblTempsFabrication;
                double dblTempsAssemblage;
                double dblTempsProgInterface;
                double dblTempsProgAutomate;
                double dblTempsProgRobot;
                double dblTempsVision;
                double dblTempsTest;
                double dblTempsInstallation;
                double dblTempsMiseService;
                double dblTempsFormation;
                double dblTempsGestion;
                double dblTempsShipping;
                double dblTempsPrototype;
                double dblTotalTemps;// SOUMISSION
                if (IsNumeric(txtTempsDessinSoum.Text))
                {
                    dblTempsDessin = double.Parse(txtTempsDessinSoum.Text);
                }
                else
                {
                    dblTempsDessin = 0d;
                }
                if (m_bSansTemps == false)
                {
                    if (IsNumeric(lblTempsFabricationSoum.Text))
                    {
                        dblTempsFabrication = double.Parse(lblTempsFabricationSoum.Text);
                    }
                    else
                    {
                        dblTempsFabrication = 0d;
                    }
                }
                else
                {
                    dblTempsFabrication = 0d;
                }
                if (IsNumeric(txtTempsAssemblageSoum.Text))
                {
                    dblTempsAssemblage = double.Parse(txtTempsAssemblageSoum.Text);
                }
                else
                {
                    dblTempsAssemblage = 0d;
                }
                if (IsNumeric(txtTempsProgInterfaceSoum.Text))
                {
                    dblTempsProgInterface = double.Parse(txtTempsProgInterfaceSoum.Text);
                }
                else
                {
                    dblTempsProgInterface = 0d;
                }
                if (IsNumeric(txtTempsProgAutomateSoum.Text))
                {
                    dblTempsProgAutomate = double.Parse(txtTempsProgAutomateSoum.Text);
                }
                else
                {
                    dblTempsProgAutomate = 0d;
                }
                if (IsNumeric(txtTempsProgRobotSoum.Text))
                {
                    dblTempsProgRobot = double.Parse(txtTempsProgRobotSoum.Text);
                }
                else
                {
                    dblTempsProgRobot = 0d;
                }
                if (IsNumeric(txtTempsVisionSoum.Text))
                {
                    dblTempsVision = double.Parse(txtTempsVisionSoum.Text);
                }
                else
                {
                    dblTempsVision = 0d;
                }
                if (IsNumeric(txtTempsTestSoum.Text))
                {
                    dblTempsTest = double.Parse(txtTempsTestSoum.Text);
                }
                else
                {
                    dblTempsTest = 0d;
                }
                if (IsNumeric(txtTempsInstallationSoum.Text))
                {
                    dblTempsInstallation = double.Parse(txtTempsInstallationSoum.Text);
                }
                else
                {
                    dblTempsInstallation = 0d;
                }
                if (IsNumeric(txtTempsMiseServiceSoum.Text))
                {
                    dblTempsMiseService = double.Parse(txtTempsMiseServiceSoum.Text);
                }
                else
                {
                    dblTempsMiseService = 0d;
                }
                if (IsNumeric(txtTempsFormationSoum.Text))
                {
                    dblTempsFormation = double.Parse(txtTempsFormationSoum.Text);
                }
                else
                {
                    dblTempsFormation = 0d;
                }
                if (IsNumeric(txtTempsGestionSoum.Text))
                {
                    dblTempsGestion = double.Parse(txtTempsGestionSoum.Text);
                }
                else
                {
                    dblTempsGestion = 0d;
                }
                if (IsNumeric(txtTempsShippingSoum.Text))
                {
                    dblTempsShipping = double.Parse(txtTempsShippingSoum.Text);
                }
                else
                {
                    dblTempsShipping = 0d;
                }
                if (IsNumeric(txtTempsprototypeSoum.Text))
                {
                    dblTempsPrototype = double.Parse(txtTempsprototypeSoum.Text);
                }
                else
                {
                    dblTempsPrototype = 0d;
                }
                dblTotalTemps = dblTempsDessin + dblTempsFabrication + dblTempsAssemblage + dblTempsProgInterface + dblTempsProgAutomate + dblTempsProgRobot + dblTempsVision + dblTempsTest + dblTempsInstallation + dblTempsMiseService + dblTempsFormation + dblTempsGestion + dblTempsShipping + dblTempsPrototype; lblTotalTempsRHSoum.Text = Conversion_Renamed(dblTotalTemps.ToString(), EnumConvert.MODE_DECIMAL); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "CalculerTotalTemps", ex); }
        }
        private void lblTempsFabricationSoum_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == (short)EnumMode.MODE_AJOUT_MODIF)
                {
                    lblTempsFabricationSoum_Change();
                }
                CalculerTotal(); return;
            }
            catch (Exception ex) { AfficherErreur("ProjSoumElecTemps", "lblTempsMécanique_Click", ex); }
        }
        private string CalculerTempsFabrication()
        {
            string CalculerTempsFabricationRet = default;
            try
            {
                var dblTempsFab = default(double);
                short X;
                for (X = 1; X <= (short)ProjSoumElec.lvwSoumission.Items.Count; X++)
                {
                    if (!string.IsNullOrEmpty(ProjSoumElec.lvwSoumission.Items[X].SubItems[9].Text.Trim()))
                    {
                        dblTempsFab += double.Parse(ProjSoumElec.lvwSoumission.Items[X].SubItems[9].Text.Trim().Replace(".", ","));
                    }
                }
                return (dblTempsFab / 10d).ToString().Replace(".", ",");
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElecTemps", "CalculerTempsFabrication", ex);
                return "0,00";
            }
        }
    }
}