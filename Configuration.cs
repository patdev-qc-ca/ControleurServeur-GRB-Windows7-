using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;
using Outlook = Microsoft.Office.Interop.Outlook;
namespace ControleurServeur
{
    public class Configuration : Form
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.Button button1;
            txtShippingMec = new System.Windows.Forms.TextBox();
            txtShippingElec = new System.Windows.Forms.TextBox();
            txtRepas = new System.Windows.Forms.TextBox();
            txtUniteMobile = new System.Windows.Forms.TextBox();
            txtStandard = new System.Windows.Forms.TextBox();
            txtHebergement2 = new System.Windows.Forms.TextBox();
            txtHebergement1 = new System.Windows.Forms.TextBox();
            txtFormationElec = new System.Windows.Forms.TextBox();
            txtGestionProjetsElec = new System.Windows.Forms.TextBox();
            txtMiseEnService = new System.Windows.Forms.TextBox();
            txtInstallationElec = new System.Windows.Forms.TextBox();
            txtProgRobot = new System.Windows.Forms.TextBox();
            txtProgAutomate = new System.Windows.Forms.TextBox();
            txtGestionProjetsMec = new System.Windows.Forms.TextBox();
            txtInstallationMec = new System.Windows.Forms.TextBox();
            txtFormationMec = new System.Windows.Forms.TextBox();
            txtDessinMec = new System.Windows.Forms.TextBox();
            txtTestMec = new System.Windows.Forms.TextBox();
            txtPeinture = new System.Windows.Forms.TextBox();
            txtAssemblageMec = new System.Windows.Forms.TextBox();
            txtSoudure = new System.Windows.Forms.TextBox();
            txtCoupe = new System.Windows.Forms.TextBox();
            txtMachinage = new System.Windows.Forms.TextBox();
            txtProgVision = new System.Windows.Forms.TextBox();
            cmdFermer = new System.Windows.Forms.Button();
            txtTauxEspagnol = new System.Windows.Forms.TextBox();
            cmdExportToExcel = new System.Windows.Forms.Button();
            txtProfitMec = new System.Windows.Forms.TextBox();
            txtCheminSEE4000 = new System.Windows.Forms.TextBox();
            txtIndice = new System.Windows.Forms.TextBox();
            txtCommission = new System.Windows.Forms.TextBox();
            txtProfitElec = new System.Windows.Forms.TextBox();
            cmdAppliquer = new System.Windows.Forms.Button();
            txtImprevus = new System.Windows.Forms.TextBox();
            Label31 = new System.Windows.Forms.Label();
            Label30 = new System.Windows.Forms.Label();
            Label26 = new System.Windows.Forms.Label();
            Label25 = new System.Windows.Forms.Label();
            Label11 = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            txtDessinElec = new System.Windows.Forms.TextBox();
            txtProgInterface = new System.Windows.Forms.TextBox();
            txtTauxAmericain = new System.Windows.Forms.TextBox();
            txtAssemblageElec = new System.Windows.Forms.TextBox();
            txtFabrication = new System.Windows.Forms.TextBox();
            txtTestElec = new System.Windows.Forms.TextBox();
            Label53 = new System.Windows.Forms.Label();
            Label52 = new System.Windows.Forms.Label();
            Label51 = new System.Windows.Forms.Label();
            Label50 = new System.Windows.Forms.Label();
            Label49 = new System.Windows.Forms.Label();
            Label48 = new System.Windows.Forms.Label();
            Label47 = new System.Windows.Forms.Label();
            Label46 = new System.Windows.Forms.Label();
            txtCentPlus = new System.Windows.Forms.TextBox();
            Label18 = new System.Windows.Forms.Label();
            Label20 = new System.Windows.Forms.Label();
            Label21 = new System.Windows.Forms.Label();
            Label22 = new System.Windows.Forms.Label();
            Label23 = new System.Windows.Forms.Label();
            Label24 = new System.Windows.Forms.Label();
            Label19 = new System.Windows.Forms.Label();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            Label45 = new System.Windows.Forms.Label();
            Label44 = new System.Windows.Forms.Label();
            Label43 = new System.Windows.Forms.Label();
            Label28 = new System.Windows.Forms.Label();
            Label41 = new System.Windows.Forms.Label();
            Label29 = new System.Windows.Forms.Label();
            Label15 = new System.Windows.Forms.Label();
            cmdConfig = new System.Windows.Forms.Button();
            txtDixMoins = new System.Windows.Forms.TextBox();
            txtDixQuinze = new System.Windows.Forms.TextBox();
            txtQuinzeVingt = new System.Windows.Forms.TextBox();
            txtVingtVingtCinq = new System.Windows.Forms.TextBox();
            txtVingtCinqCinquante = new System.Windows.Forms.TextBox();
            txtCinquanteCent = new System.Windows.Forms.TextBox();
            Label1 = new System.Windows.Forms.Label();
            Label40 = new System.Windows.Forms.Label();
            Label39 = new System.Windows.Forms.Label();
            Label38 = new System.Windows.Forms.Label();
            txtLeGrand = new System.Windows.Forms.TextBox();
            txtLamine = new System.Windows.Forms.TextBox();
            txtThermo = new System.Windows.Forms.TextBox();
            txt4em = new System.Windows.Forms.TextBox();
            Label7 = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            Label9 = new System.Windows.Forms.Label();
            Label10 = new System.Windows.Forms.Label();
            Label37 = new System.Windows.Forms.Label();
            Label36 = new System.Windows.Forms.Label();
            Label35 = new System.Windows.Forms.Label();
            Label34 = new System.Windows.Forms.Label();
            Label33 = new System.Windows.Forms.Label();
            Label32 = new System.Windows.Forms.Label();
            Label27 = new System.Windows.Forms.Label();
            Label17 = new System.Windows.Forms.Label();
            Label16 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            label54 = new System.Windows.Forms.Label();
            txtVersionSQL = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.BackColor = System.Drawing.Color.Black;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.Red;
            button1.Location = new System.Drawing.Point(534, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(81, 23);
            button1.TabIndex = 119;
            button1.Text = "Patcher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // txtShippingMec
            // 
            txtShippingMec.AcceptsReturn = true;
            txtShippingMec.BackColor = System.Drawing.Color.Black;
            txtShippingMec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtShippingMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtShippingMec.ForeColor = System.Drawing.Color.White;
            txtShippingMec.Location = new System.Drawing.Point(249, 269);
            txtShippingMec.MaxLength = 0;
            txtShippingMec.Name = "txtShippingMec";
            txtShippingMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtShippingMec.Size = new System.Drawing.Size(49, 20);
            txtShippingMec.TabIndex = 106;
            // 
            // txtShippingElec
            // 
            txtShippingElec.AcceptsReturn = true;
            txtShippingElec.BackColor = System.Drawing.Color.Black;
            txtShippingElec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtShippingElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtShippingElec.ForeColor = System.Drawing.Color.White;
            txtShippingElec.Location = new System.Drawing.Point(272, 312);
            txtShippingElec.MaxLength = 0;
            txtShippingElec.Name = "txtShippingElec";
            txtShippingElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtShippingElec.Size = new System.Drawing.Size(49, 20);
            txtShippingElec.TabIndex = 104;
            // 
            // txtRepas
            // 
            txtRepas.AcceptsReturn = true;
            txtRepas.BackColor = System.Drawing.Color.Black;
            txtRepas.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtRepas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtRepas.ForeColor = System.Drawing.Color.White;
            txtRepas.Location = new System.Drawing.Point(241, 143);
            txtRepas.MaxLength = 0;
            txtRepas.Name = "txtRepas";
            txtRepas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtRepas.Size = new System.Drawing.Size(57, 20);
            txtRepas.TabIndex = 102;
            // 
            // txtUniteMobile
            // 
            txtUniteMobile.AcceptsReturn = true;
            txtUniteMobile.BackColor = System.Drawing.Color.Black;
            txtUniteMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtUniteMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtUniteMobile.ForeColor = System.Drawing.Color.White;
            txtUniteMobile.Location = new System.Drawing.Point(241, 120);
            txtUniteMobile.MaxLength = 0;
            txtUniteMobile.Name = "txtUniteMobile";
            txtUniteMobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtUniteMobile.Size = new System.Drawing.Size(57, 20);
            txtUniteMobile.TabIndex = 99;
            // 
            // txtStandard
            // 
            txtStandard.AcceptsReturn = true;
            txtStandard.BackColor = System.Drawing.Color.Black;
            txtStandard.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtStandard.ForeColor = System.Drawing.Color.White;
            txtStandard.Location = new System.Drawing.Point(241, 96);
            txtStandard.MaxLength = 0;
            txtStandard.Name = "txtStandard";
            txtStandard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtStandard.Size = new System.Drawing.Size(57, 20);
            txtStandard.TabIndex = 97;
            // 
            // txtHebergement2
            // 
            txtHebergement2.AcceptsReturn = true;
            txtHebergement2.BackColor = System.Drawing.Color.Black;
            txtHebergement2.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtHebergement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtHebergement2.ForeColor = System.Drawing.Color.White;
            txtHebergement2.Location = new System.Drawing.Point(241, 63);
            txtHebergement2.MaxLength = 0;
            txtHebergement2.Name = "txtHebergement2";
            txtHebergement2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtHebergement2.Size = new System.Drawing.Size(57, 20);
            txtHebergement2.TabIndex = 94;
            // 
            // txtHebergement1
            // 
            txtHebergement1.AcceptsReturn = true;
            txtHebergement1.BackColor = System.Drawing.Color.Black;
            txtHebergement1.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtHebergement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtHebergement1.ForeColor = System.Drawing.Color.White;
            txtHebergement1.Location = new System.Drawing.Point(241, 39);
            txtHebergement1.MaxLength = 0;
            txtHebergement1.Name = "txtHebergement1";
            txtHebergement1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtHebergement1.Size = new System.Drawing.Size(57, 20);
            txtHebergement1.TabIndex = 92;
            // 
            // txtFormationElec
            // 
            txtFormationElec.AcceptsReturn = true;
            txtFormationElec.BackColor = System.Drawing.Color.Black;
            txtFormationElec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtFormationElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtFormationElec.ForeColor = System.Drawing.Color.White;
            txtFormationElec.Location = new System.Drawing.Point(272, 264);
            txtFormationElec.MaxLength = 0;
            txtFormationElec.Name = "txtFormationElec";
            txtFormationElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtFormationElec.Size = new System.Drawing.Size(49, 20);
            txtFormationElec.TabIndex = 90;
            // 
            // txtGestionProjetsElec
            // 
            txtGestionProjetsElec.AcceptsReturn = true;
            txtGestionProjetsElec.BackColor = System.Drawing.Color.Black;
            txtGestionProjetsElec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtGestionProjetsElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtGestionProjetsElec.ForeColor = System.Drawing.Color.White;
            txtGestionProjetsElec.Location = new System.Drawing.Point(272, 288);
            txtGestionProjetsElec.MaxLength = 0;
            txtGestionProjetsElec.Name = "txtGestionProjetsElec";
            txtGestionProjetsElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtGestionProjetsElec.Size = new System.Drawing.Size(49, 20);
            txtGestionProjetsElec.TabIndex = 88;
            // 
            // txtMiseEnService
            // 
            txtMiseEnService.AcceptsReturn = true;
            txtMiseEnService.BackColor = System.Drawing.Color.Black;
            txtMiseEnService.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMiseEnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtMiseEnService.ForeColor = System.Drawing.Color.White;
            txtMiseEnService.Location = new System.Drawing.Point(272, 240);
            txtMiseEnService.MaxLength = 0;
            txtMiseEnService.Name = "txtMiseEnService";
            txtMiseEnService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtMiseEnService.Size = new System.Drawing.Size(49, 20);
            txtMiseEnService.TabIndex = 86;
            // 
            // txtInstallationElec
            // 
            txtInstallationElec.AcceptsReturn = true;
            txtInstallationElec.BackColor = System.Drawing.Color.Black;
            txtInstallationElec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtInstallationElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtInstallationElec.ForeColor = System.Drawing.Color.White;
            txtInstallationElec.Location = new System.Drawing.Point(272, 216);
            txtInstallationElec.MaxLength = 0;
            txtInstallationElec.Name = "txtInstallationElec";
            txtInstallationElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtInstallationElec.Size = new System.Drawing.Size(49, 20);
            txtInstallationElec.TabIndex = 84;
            // 
            // txtProgRobot
            // 
            txtProgRobot.AcceptsReturn = true;
            txtProgRobot.BackColor = System.Drawing.Color.Black;
            txtProgRobot.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtProgRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtProgRobot.ForeColor = System.Drawing.Color.White;
            txtProgRobot.Location = new System.Drawing.Point(272, 144);
            txtProgRobot.MaxLength = 0;
            txtProgRobot.Name = "txtProgRobot";
            txtProgRobot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtProgRobot.Size = new System.Drawing.Size(49, 20);
            txtProgRobot.TabIndex = 81;
            // 
            // txtProgAutomate
            // 
            txtProgAutomate.AcceptsReturn = true;
            txtProgAutomate.BackColor = System.Drawing.Color.Black;
            txtProgAutomate.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtProgAutomate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtProgAutomate.ForeColor = System.Drawing.Color.White;
            txtProgAutomate.Location = new System.Drawing.Point(272, 120);
            txtProgAutomate.MaxLength = 0;
            txtProgAutomate.Name = "txtProgAutomate";
            txtProgAutomate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtProgAutomate.Size = new System.Drawing.Size(49, 20);
            txtProgAutomate.TabIndex = 79;
            // 
            // txtGestionProjetsMec
            // 
            txtGestionProjetsMec.AcceptsReturn = true;
            txtGestionProjetsMec.BackColor = System.Drawing.Color.Black;
            txtGestionProjetsMec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtGestionProjetsMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtGestionProjetsMec.ForeColor = System.Drawing.Color.White;
            txtGestionProjetsMec.Location = new System.Drawing.Point(249, 245);
            txtGestionProjetsMec.MaxLength = 0;
            txtGestionProjetsMec.Name = "txtGestionProjetsMec";
            txtGestionProjetsMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtGestionProjetsMec.Size = new System.Drawing.Size(49, 20);
            txtGestionProjetsMec.TabIndex = 75;
            // 
            // txtInstallationMec
            // 
            txtInstallationMec.AcceptsReturn = true;
            txtInstallationMec.BackColor = System.Drawing.Color.Black;
            txtInstallationMec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtInstallationMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtInstallationMec.ForeColor = System.Drawing.Color.White;
            txtInstallationMec.Location = new System.Drawing.Point(249, 197);
            txtInstallationMec.MaxLength = 0;
            txtInstallationMec.Name = "txtInstallationMec";
            txtInstallationMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtInstallationMec.Size = new System.Drawing.Size(49, 20);
            txtInstallationMec.TabIndex = 45;
            // 
            // txtFormationMec
            // 
            txtFormationMec.AcceptsReturn = true;
            txtFormationMec.BackColor = System.Drawing.Color.Black;
            txtFormationMec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtFormationMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtFormationMec.ForeColor = System.Drawing.Color.White;
            txtFormationMec.Location = new System.Drawing.Point(249, 221);
            txtFormationMec.MaxLength = 0;
            txtFormationMec.Name = "txtFormationMec";
            txtFormationMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtFormationMec.Size = new System.Drawing.Size(49, 20);
            txtFormationMec.TabIndex = 41;
            // 
            // txtDessinMec
            // 
            txtDessinMec.AcceptsReturn = true;
            txtDessinMec.BackColor = System.Drawing.Color.Black;
            txtDessinMec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDessinMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDessinMec.ForeColor = System.Drawing.Color.White;
            txtDessinMec.Location = new System.Drawing.Point(249, 29);
            txtDessinMec.MaxLength = 0;
            txtDessinMec.Name = "txtDessinMec";
            txtDessinMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDessinMec.Size = new System.Drawing.Size(49, 20);
            txtDessinMec.TabIndex = 39;
            // 
            // txtTestMec
            // 
            txtTestMec.AcceptsReturn = true;
            txtTestMec.BackColor = System.Drawing.Color.Black;
            txtTestMec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTestMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTestMec.ForeColor = System.Drawing.Color.White;
            txtTestMec.Location = new System.Drawing.Point(249, 173);
            txtTestMec.MaxLength = 0;
            txtTestMec.Name = "txtTestMec";
            txtTestMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTestMec.Size = new System.Drawing.Size(49, 20);
            txtTestMec.TabIndex = 37;
            // 
            // txtPeinture
            // 
            txtPeinture.AcceptsReturn = true;
            txtPeinture.BackColor = System.Drawing.Color.Black;
            txtPeinture.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPeinture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtPeinture.ForeColor = System.Drawing.Color.White;
            txtPeinture.Location = new System.Drawing.Point(249, 149);
            txtPeinture.MaxLength = 0;
            txtPeinture.Name = "txtPeinture";
            txtPeinture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPeinture.Size = new System.Drawing.Size(49, 20);
            txtPeinture.TabIndex = 33;
            // 
            // txtAssemblageMec
            // 
            txtAssemblageMec.AcceptsReturn = true;
            txtAssemblageMec.BackColor = System.Drawing.Color.Black;
            txtAssemblageMec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAssemblageMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtAssemblageMec.ForeColor = System.Drawing.Color.White;
            txtAssemblageMec.Location = new System.Drawing.Point(249, 125);
            txtAssemblageMec.MaxLength = 0;
            txtAssemblageMec.Name = "txtAssemblageMec";
            txtAssemblageMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAssemblageMec.Size = new System.Drawing.Size(49, 20);
            txtAssemblageMec.TabIndex = 29;
            // 
            // txtSoudure
            // 
            txtSoudure.AcceptsReturn = true;
            txtSoudure.BackColor = System.Drawing.Color.Black;
            txtSoudure.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtSoudure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtSoudure.ForeColor = System.Drawing.Color.White;
            txtSoudure.Location = new System.Drawing.Point(249, 101);
            txtSoudure.MaxLength = 0;
            txtSoudure.Name = "txtSoudure";
            txtSoudure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtSoudure.Size = new System.Drawing.Size(49, 20);
            txtSoudure.TabIndex = 25;
            // 
            // txtCoupe
            // 
            txtCoupe.AcceptsReturn = true;
            txtCoupe.BackColor = System.Drawing.Color.Black;
            txtCoupe.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCoupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCoupe.ForeColor = System.Drawing.Color.White;
            txtCoupe.Location = new System.Drawing.Point(249, 53);
            txtCoupe.MaxLength = 0;
            txtCoupe.Name = "txtCoupe";
            txtCoupe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCoupe.Size = new System.Drawing.Size(49, 20);
            txtCoupe.TabIndex = 21;
            // 
            // txtMachinage
            // 
            txtMachinage.AcceptsReturn = true;
            txtMachinage.BackColor = System.Drawing.Color.Black;
            txtMachinage.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMachinage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtMachinage.ForeColor = System.Drawing.Color.White;
            txtMachinage.Location = new System.Drawing.Point(249, 77);
            txtMachinage.MaxLength = 0;
            txtMachinage.Name = "txtMachinage";
            txtMachinage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtMachinage.Size = new System.Drawing.Size(49, 20);
            txtMachinage.TabIndex = 17;
            // 
            // txtProgVision
            // 
            txtProgVision.AcceptsReturn = true;
            txtProgVision.BackColor = System.Drawing.Color.Black;
            txtProgVision.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtProgVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtProgVision.ForeColor = System.Drawing.Color.White;
            txtProgVision.Location = new System.Drawing.Point(272, 168);
            txtProgVision.MaxLength = 0;
            txtProgVision.Name = "txtProgVision";
            txtProgVision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtProgVision.Size = new System.Drawing.Size(49, 20);
            txtProgVision.TabIndex = 35;
            // 
            // cmdFermer
            // 
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.Fuchsia;
            cmdFermer.Location = new System.Drawing.Point(599, 819);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(81, 25);
            cmdFermer.TabIndex = 115;
            cmdFermer.Text = "&Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(cmdFermer_Click);
            // 
            // txtTauxEspagnol
            // 
            txtTauxEspagnol.AcceptsReturn = true;
            txtTauxEspagnol.BackColor = System.Drawing.Color.Black;
            txtTauxEspagnol.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTauxEspagnol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTauxEspagnol.ForeColor = System.Drawing.Color.White;
            txtTauxEspagnol.Location = new System.Drawing.Point(241, 193);
            txtTauxEspagnol.MaxLength = 0;
            txtTauxEspagnol.Name = "txtTauxEspagnol";
            txtTauxEspagnol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTauxEspagnol.Size = new System.Drawing.Size(57, 20);
            txtTauxEspagnol.TabIndex = 47;
            // 
            // cmdExportToExcel
            // 
            cmdExportToExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdExportToExcel.BackColor = System.Drawing.Color.Black;
            cmdExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdExportToExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            cmdExportToExcel.Location = new System.Drawing.Point(12, 818);
            cmdExportToExcel.Name = "cmdExportToExcel";
            cmdExportToExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdExportToExcel.Size = new System.Drawing.Size(175, 27);
            cmdExportToExcel.TabIndex = 108;
            cmdExportToExcel.Text = "Exporter dans Excel";
            cmdExportToExcel.UseVisualStyleBackColor = true;
            cmdExportToExcel.Click += new System.EventHandler(cmdExportToExcel_Click);
            // 
            // txtProfitMec
            // 
            txtProfitMec.AcceptsReturn = true;
            txtProfitMec.BackColor = System.Drawing.Color.Black;
            txtProfitMec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtProfitMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtProfitMec.ForeColor = System.Drawing.Color.White;
            txtProfitMec.Location = new System.Drawing.Point(264, 40);
            txtProfitMec.MaxLength = 0;
            txtProfitMec.Name = "txtProfitMec";
            txtProfitMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtProfitMec.Size = new System.Drawing.Size(57, 20);
            txtProfitMec.TabIndex = 4;
            // 
            // txtCheminSEE4000
            // 
            txtCheminSEE4000.AcceptsReturn = true;
            txtCheminSEE4000.BackColor = System.Drawing.Color.Black;
            txtCheminSEE4000.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCheminSEE4000.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCheminSEE4000.ForeColor = System.Drawing.Color.White;
            txtCheminSEE4000.Location = new System.Drawing.Point(15, 152);
            txtCheminSEE4000.MaxLength = 0;
            txtCheminSEE4000.Name = "txtCheminSEE4000";
            txtCheminSEE4000.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCheminSEE4000.Size = new System.Drawing.Size(306, 20);
            txtCheminSEE4000.TabIndex = 12;
            // 
            // txtIndice
            // 
            txtIndice.AcceptsReturn = true;
            txtIndice.BackColor = System.Drawing.Color.Black;
            txtIndice.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtIndice.ForeColor = System.Drawing.Color.White;
            txtIndice.Location = new System.Drawing.Point(264, 88);
            txtIndice.MaxLength = 0;
            txtIndice.Name = "txtIndice";
            txtIndice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtIndice.Size = new System.Drawing.Size(57, 20);
            txtIndice.TabIndex = 8;
            // 
            // txtCommission
            // 
            txtCommission.AcceptsReturn = true;
            txtCommission.BackColor = System.Drawing.Color.Black;
            txtCommission.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCommission.ForeColor = System.Drawing.Color.White;
            txtCommission.Location = new System.Drawing.Point(264, 64);
            txtCommission.MaxLength = 0;
            txtCommission.Name = "txtCommission";
            txtCommission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCommission.Size = new System.Drawing.Size(57, 20);
            txtCommission.TabIndex = 6;
            // 
            // txtProfitElec
            // 
            txtProfitElec.AcceptsReturn = true;
            txtProfitElec.BackColor = System.Drawing.Color.Black;
            txtProfitElec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtProfitElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtProfitElec.ForeColor = System.Drawing.Color.White;
            txtProfitElec.Location = new System.Drawing.Point(264, 16);
            txtProfitElec.MaxLength = 0;
            txtProfitElec.Name = "txtProfitElec";
            txtProfitElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtProfitElec.Size = new System.Drawing.Size(57, 20);
            txtProfitElec.TabIndex = 2;
            // 
            // cmdAppliquer
            // 
            cmdAppliquer.BackColor = System.Drawing.Color.Black;
            cmdAppliquer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAppliquer.ForeColor = System.Drawing.Color.Red;
            cmdAppliquer.Location = new System.Drawing.Point(519, 819);
            cmdAppliquer.Name = "cmdAppliquer";
            cmdAppliquer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAppliquer.Size = new System.Drawing.Size(73, 25);
            cmdAppliquer.TabIndex = 114;
            cmdAppliquer.Text = "&Appliquer";
            cmdAppliquer.UseVisualStyleBackColor = true;
            cmdAppliquer.Click += new System.EventHandler(cmdAppliquer_Click);
            // 
            // txtImprevus
            // 
            txtImprevus.AcceptsReturn = true;
            txtImprevus.BackColor = System.Drawing.Color.Black;
            txtImprevus.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtImprevus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtImprevus.ForeColor = System.Drawing.Color.White;
            txtImprevus.Location = new System.Drawing.Point(264, 112);
            txtImprevus.MaxLength = 0;
            txtImprevus.Name = "txtImprevus";
            txtImprevus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtImprevus.Size = new System.Drawing.Size(57, 20);
            txtImprevus.TabIndex = 10;
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.BackColor = System.Drawing.Color.Black;
            Label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label31.ForeColor = System.Drawing.Color.White;
            Label31.Location = new System.Drawing.Point(15, 44);
            Label31.Name = "Label31";
            Label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label31.Size = new System.Drawing.Size(106, 13);
            Label31.TabIndex = 3;
            Label31.Text = "Profit mécanique:";
            Label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label30
            // 
            Label30.AutoSize = true;
            Label30.BackColor = System.Drawing.Color.Black;
            Label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label30.ForeColor = System.Drawing.Color.White;
            Label30.Location = new System.Drawing.Point(15, 136);
            Label30.Name = "Label30";
            Label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label30.Size = new System.Drawing.Size(259, 13);
            Label30.TabIndex = 11;
            Label30.Text = "Chemin de la base de données de SEE4000:";
            // 
            // Label26
            // 
            Label26.AutoSize = true;
            Label26.BackColor = System.Drawing.Color.Black;
            Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label26.ForeColor = System.Drawing.Color.White;
            Label26.Location = new System.Drawing.Point(15, 92);
            Label26.Name = "Label26";
            Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label26.Size = new System.Drawing.Size(197, 13);
            Label26.TabIndex = 7;
            Label26.Text = "Indice de dessin (% du tmp dess):";
            Label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label25
            // 
            Label25.AutoSize = true;
            Label25.BackColor = System.Drawing.Color.Black;
            Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label25.ForeColor = System.Drawing.Color.White;
            Label25.Location = new System.Drawing.Point(15, 68);
            Label25.Name = "Label25";
            Label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label25.Size = new System.Drawing.Size(216, 13);
            Label25.TabIndex = 5;
            Label25.Text = "Commission (% du totale de la soum):";
            Label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.BackColor = System.Drawing.Color.Black;
            Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label11.ForeColor = System.Drawing.Color.White;
            Label11.Location = new System.Drawing.Point(15, 23);
            Label11.Name = "Label11";
            Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label11.Size = new System.Drawing.Size(101, 13);
            Label11.TabIndex = 1;
            Label11.Text = "Profit électrique:";
            Label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.Black;
            Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label12.ForeColor = System.Drawing.Color.White;
            Label12.Location = new System.Drawing.Point(15, 119);
            Label12.Name = "Label12";
            Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label12.Size = new System.Drawing.Size(147, 13);
            Label12.TabIndex = 9;
            Label12.Text = "Pourcentage d\'imprévus:";
            Label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDessinElec
            // 
            txtDessinElec.AcceptsReturn = true;
            txtDessinElec.BackColor = System.Drawing.Color.Black;
            txtDessinElec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDessinElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDessinElec.ForeColor = System.Drawing.Color.White;
            txtDessinElec.Location = new System.Drawing.Point(272, 24);
            txtDessinElec.MaxLength = 0;
            txtDessinElec.Name = "txtDessinElec";
            txtDessinElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDessinElec.Size = new System.Drawing.Size(49, 20);
            txtDessinElec.TabIndex = 15;
            // 
            // txtProgInterface
            // 
            txtProgInterface.AcceptsReturn = true;
            txtProgInterface.BackColor = System.Drawing.Color.Black;
            txtProgInterface.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtProgInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtProgInterface.ForeColor = System.Drawing.Color.White;
            txtProgInterface.Location = new System.Drawing.Point(272, 96);
            txtProgInterface.MaxLength = 0;
            txtProgInterface.Name = "txtProgInterface";
            txtProgInterface.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtProgInterface.Size = new System.Drawing.Size(49, 20);
            txtProgInterface.TabIndex = 19;
            // 
            // txtTauxAmericain
            // 
            txtTauxAmericain.AcceptsReturn = true;
            txtTauxAmericain.BackColor = System.Drawing.Color.Black;
            txtTauxAmericain.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTauxAmericain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTauxAmericain.ForeColor = System.Drawing.Color.White;
            txtTauxAmericain.Location = new System.Drawing.Point(241, 169);
            txtTauxAmericain.MaxLength = 0;
            txtTauxAmericain.Name = "txtTauxAmericain";
            txtTauxAmericain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTauxAmericain.Size = new System.Drawing.Size(57, 20);
            txtTauxAmericain.TabIndex = 43;
            // 
            // txtAssemblageElec
            // 
            txtAssemblageElec.AcceptsReturn = true;
            txtAssemblageElec.BackColor = System.Drawing.Color.Black;
            txtAssemblageElec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAssemblageElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtAssemblageElec.ForeColor = System.Drawing.Color.White;
            txtAssemblageElec.Location = new System.Drawing.Point(272, 72);
            txtAssemblageElec.MaxLength = 0;
            txtAssemblageElec.Name = "txtAssemblageElec";
            txtAssemblageElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAssemblageElec.Size = new System.Drawing.Size(49, 20);
            txtAssemblageElec.TabIndex = 23;
            // 
            // txtFabrication
            // 
            txtFabrication.AcceptsReturn = true;
            txtFabrication.BackColor = System.Drawing.Color.Black;
            txtFabrication.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtFabrication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtFabrication.ForeColor = System.Drawing.Color.White;
            txtFabrication.Location = new System.Drawing.Point(272, 48);
            txtFabrication.MaxLength = 0;
            txtFabrication.Name = "txtFabrication";
            txtFabrication.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtFabrication.Size = new System.Drawing.Size(49, 20);
            txtFabrication.TabIndex = 27;
            // 
            // txtTestElec
            // 
            txtTestElec.AcceptsReturn = true;
            txtTestElec.BackColor = System.Drawing.Color.Black;
            txtTestElec.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTestElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtTestElec.ForeColor = System.Drawing.Color.White;
            txtTestElec.Location = new System.Drawing.Point(272, 192);
            txtTestElec.MaxLength = 0;
            txtTestElec.Name = "txtTestElec";
            txtTestElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTestElec.Size = new System.Drawing.Size(49, 20);
            txtTestElec.TabIndex = 31;
            // 
            // Label53
            // 
            Label53.AutoSize = true;
            Label53.BackColor = System.Drawing.Color.Black;
            Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label53.ForeColor = System.Drawing.Color.White;
            Label53.Location = new System.Drawing.Point(14, 272);
            Label53.Name = "Label53";
            Label53.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label53.Size = new System.Drawing.Size(64, 13);
            Label53.TabIndex = 107;
            Label53.Text = "Shipping :";
            // 
            // Label52
            // 
            Label52.AutoSize = true;
            Label52.BackColor = System.Drawing.Color.Black;
            Label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label52.ForeColor = System.Drawing.Color.White;
            Label52.Location = new System.Drawing.Point(15, 317);
            Label52.Name = "Label52";
            Label52.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label52.Size = new System.Drawing.Size(64, 13);
            Label52.TabIndex = 105;
            Label52.Text = "Shipping :";
            // 
            // Label51
            // 
            Label51.AutoSize = true;
            Label51.BackColor = System.Drawing.Color.Black;
            Label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label51.ForeColor = System.Drawing.Color.White;
            Label51.Location = new System.Drawing.Point(14, 149);
            Label51.Name = "Label51";
            Label51.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label51.Size = new System.Drawing.Size(137, 13);
            Label51.TabIndex = 103;
            Label51.Text = "Repas pour 1 journée :";
            Label51.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label50
            // 
            Label50.AutoSize = true;
            Label50.BackColor = System.Drawing.Color.Black;
            Label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label50.ForeColor = System.Drawing.Color.White;
            Label50.Location = new System.Drawing.Point(14, 123);
            Label50.Name = "Label50";
            Label50.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label50.Size = new System.Drawing.Size(85, 13);
            Label50.TabIndex = 101;
            Label50.Text = "Unité mobile :";
            Label50.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label49
            // 
            Label49.AutoSize = true;
            Label49.BackColor = System.Drawing.Color.Black;
            Label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label49.ForeColor = System.Drawing.Color.White;
            Label49.Location = new System.Drawing.Point(14, 99);
            Label49.Name = "Label49";
            Label49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label49.Size = new System.Drawing.Size(117, 13);
            Label49.TabIndex = 100;
            Label49.Text = "Véhicule standard :";
            Label49.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label48
            // 
            Label48.BackColor = System.Drawing.Color.Black;
            Label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label48.ForeColor = System.Drawing.Color.White;
            Label48.Location = new System.Drawing.Point(14, 219);
            Label48.Name = "Label48";
            Label48.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label48.Size = new System.Drawing.Size(215, 13);
            Label48.TabIndex = 98;
            Label48.Text = "Prix / KM";
            Label48.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label47
            // 
            Label47.AutoSize = true;
            Label47.BackColor = System.Drawing.Color.Black;
            Label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label47.ForeColor = System.Drawing.Color.White;
            Label47.Location = new System.Drawing.Point(14, 71);
            Label47.Name = "Label47";
            Label47.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label47.Size = new System.Drawing.Size(106, 13);
            Label47.TabIndex = 96;
            Label47.Text = "Chambre à 2 lits :";
            Label47.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label46
            // 
            Label46.AutoSize = true;
            Label46.BackColor = System.Drawing.Color.Black;
            Label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label46.ForeColor = System.Drawing.Color.White;
            Label46.Location = new System.Drawing.Point(14, 47);
            Label46.Name = "Label46";
            Label46.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label46.Size = new System.Drawing.Size(100, 13);
            Label46.TabIndex = 95;
            Label46.Text = "Chambre à 1 lit :";
            Label46.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCentPlus
            // 
            txtCentPlus.AcceptsReturn = true;
            txtCentPlus.BackColor = System.Drawing.Color.Black;
            txtCentPlus.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCentPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCentPlus.ForeColor = System.Drawing.Color.White;
            txtCentPlus.Location = new System.Drawing.Point(142, 329);
            txtCentPlus.MaxLength = 0;
            txtCentPlus.Name = "txtCentPlus";
            txtCentPlus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCentPlus.Size = new System.Drawing.Size(49, 20);
            txtCentPlus.TabIndex = 71;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.BackColor = System.Drawing.Color.Black;
            Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label18.ForeColor = System.Drawing.Color.White;
            Label18.Location = new System.Drawing.Point(14, 185);
            Label18.Name = "Label18";
            Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label18.Size = new System.Drawing.Size(76, 13);
            Label18.TabIndex = 58;
            Label18.Text = "10,000$ et -";
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.BackColor = System.Drawing.Color.Black;
            Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label20.ForeColor = System.Drawing.Color.White;
            Label20.Location = new System.Drawing.Point(14, 233);
            Label20.Name = "Label20";
            Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label20.Size = new System.Drawing.Size(114, 13);
            Label20.TabIndex = 62;
            Label20.Text = "15,000$ à 20,000$";
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.BackColor = System.Drawing.Color.Black;
            Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label21.ForeColor = System.Drawing.Color.White;
            Label21.Location = new System.Drawing.Point(14, 257);
            Label21.Name = "Label21";
            Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label21.Size = new System.Drawing.Size(114, 13);
            Label21.TabIndex = 64;
            Label21.Text = "20,000$ à 25,000$";
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.BackColor = System.Drawing.Color.Black;
            Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label22.ForeColor = System.Drawing.Color.White;
            Label22.Location = new System.Drawing.Point(14, 281);
            Label22.Name = "Label22";
            Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label22.Size = new System.Drawing.Size(114, 13);
            Label22.TabIndex = 66;
            Label22.Text = "25,000$ à 50,000$";
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.BackColor = System.Drawing.Color.Black;
            Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label23.ForeColor = System.Drawing.Color.White;
            Label23.Location = new System.Drawing.Point(14, 305);
            Label23.Name = "Label23";
            Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label23.Size = new System.Drawing.Size(125, 13);
            Label23.TabIndex = 68;
            Label23.Text = "50,000$ à 100,000$ ";
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.BackColor = System.Drawing.Color.Black;
            Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label24.ForeColor = System.Drawing.Color.White;
            Label24.Location = new System.Drawing.Point(14, 329);
            Label24.Name = "Label24";
            Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label24.Size = new System.Drawing.Size(86, 13);
            Label24.TabIndex = 70;
            Label24.Text = "100,000$ et +";
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.BackColor = System.Drawing.Color.Black;
            Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label19.ForeColor = System.Drawing.Color.White;
            Label19.Location = new System.Drawing.Point(14, 209);
            Label19.Name = "Label19";
            Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label19.Size = new System.Drawing.Size(118, 13);
            Label19.TabIndex = 60;
            Label19.Text = "10,000$ à 15,000$ ";
            // 
            // ToolTip1
            // 
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // Label45
            // 
            Label45.AutoSize = true;
            Label45.BackColor = System.Drawing.Color.Black;
            Label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label45.ForeColor = System.Drawing.Color.White;
            Label45.Location = new System.Drawing.Point(15, 269);
            Label45.Name = "Label45";
            Label45.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label45.Size = new System.Drawing.Size(147, 13);
            Label45.TabIndex = 91;
            Label45.Text = "Formation du personnel :";
            // 
            // Label44
            // 
            Label44.AutoSize = true;
            Label44.BackColor = System.Drawing.Color.Black;
            Label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label44.ForeColor = System.Drawing.Color.White;
            Label44.Location = new System.Drawing.Point(15, 293);
            Label44.Name = "Label44";
            Label44.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label44.Size = new System.Drawing.Size(62, 13);
            Label44.TabIndex = 89;
            Label44.Text = "Gestion  :";
            // 
            // Label43
            // 
            Label43.AutoSize = true;
            Label43.BackColor = System.Drawing.Color.Black;
            Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label43.ForeColor = System.Drawing.Color.White;
            Label43.Location = new System.Drawing.Point(15, 245);
            Label43.Name = "Label43";
            Label43.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label43.Size = new System.Drawing.Size(104, 13);
            Label43.TabIndex = 87;
            Label43.Text = "Mise en service :";
            // 
            // Label28
            // 
            Label28.AutoSize = true;
            Label28.BackColor = System.Drawing.Color.Black;
            Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label28.ForeColor = System.Drawing.Color.White;
            Label28.Location = new System.Drawing.Point(15, 221);
            Label28.Name = "Label28";
            Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label28.Size = new System.Drawing.Size(77, 13);
            Label28.TabIndex = 85;
            Label28.Text = "Installation :";
            // 
            // Label41
            // 
            Label41.AutoSize = true;
            Label41.BackColor = System.Drawing.Color.Black;
            Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label41.ForeColor = System.Drawing.Color.White;
            Label41.Location = new System.Drawing.Point(15, 149);
            Label41.Name = "Label41";
            Label41.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label41.Size = new System.Drawing.Size(149, 13);
            Label41.TabIndex = 82;
            Label41.Text = "Programmation de robot :";
            // 
            // Label29
            // 
            Label29.AutoSize = true;
            Label29.BackColor = System.Drawing.Color.Black;
            Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label29.ForeColor = System.Drawing.Color.White;
            Label29.Location = new System.Drawing.Point(15, 125);
            Label29.Name = "Label29";
            Label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label29.Size = new System.Drawing.Size(164, 13);
            Label29.TabIndex = 80;
            Label29.Text = "Programmation d\'automate :";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.BackColor = System.Drawing.Color.Black;
            Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label15.ForeColor = System.Drawing.Color.White;
            Label15.Location = new System.Drawing.Point(733, 132);
            Label15.Name = "Label15";
            Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label15.Size = new System.Drawing.Size(0, 13);
            Label15.TabIndex = 78;
            Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdConfig
            // 
            cmdConfig.AutoSize = true;
            cmdConfig.BackColor = System.Drawing.Color.Black;
            cmdConfig.ForeColor = System.Drawing.Color.White;
            cmdConfig.Location = new System.Drawing.Point(628, 12);
            cmdConfig.Name = "cmdConfig";
            cmdConfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdConfig.Size = new System.Drawing.Size(26, 25);
            cmdConfig.TabIndex = 116;
            cmdConfig.TabStop = false;
            cmdConfig.Text = "...";
            cmdConfig.UseVisualStyleBackColor = true;
            // 
            // txtDixMoins
            // 
            txtDixMoins.AcceptsReturn = true;
            txtDixMoins.BackColor = System.Drawing.Color.Black;
            txtDixMoins.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDixMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDixMoins.ForeColor = System.Drawing.Color.White;
            txtDixMoins.Location = new System.Drawing.Point(142, 185);
            txtDixMoins.MaxLength = 0;
            txtDixMoins.Name = "txtDixMoins";
            txtDixMoins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDixMoins.Size = new System.Drawing.Size(49, 20);
            txtDixMoins.TabIndex = 59;
            // 
            // txtDixQuinze
            // 
            txtDixQuinze.AcceptsReturn = true;
            txtDixQuinze.BackColor = System.Drawing.Color.Black;
            txtDixQuinze.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDixQuinze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDixQuinze.ForeColor = System.Drawing.Color.White;
            txtDixQuinze.Location = new System.Drawing.Point(142, 209);
            txtDixQuinze.MaxLength = 0;
            txtDixQuinze.Name = "txtDixQuinze";
            txtDixQuinze.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDixQuinze.Size = new System.Drawing.Size(49, 20);
            txtDixQuinze.TabIndex = 61;
            // 
            // txtQuinzeVingt
            // 
            txtQuinzeVingt.AcceptsReturn = true;
            txtQuinzeVingt.BackColor = System.Drawing.Color.Black;
            txtQuinzeVingt.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuinzeVingt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtQuinzeVingt.ForeColor = System.Drawing.Color.White;
            txtQuinzeVingt.Location = new System.Drawing.Point(142, 233);
            txtQuinzeVingt.MaxLength = 0;
            txtQuinzeVingt.Name = "txtQuinzeVingt";
            txtQuinzeVingt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQuinzeVingt.Size = new System.Drawing.Size(49, 20);
            txtQuinzeVingt.TabIndex = 63;
            // 
            // txtVingtVingtCinq
            // 
            txtVingtVingtCinq.AcceptsReturn = true;
            txtVingtVingtCinq.BackColor = System.Drawing.Color.Black;
            txtVingtVingtCinq.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtVingtVingtCinq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtVingtVingtCinq.ForeColor = System.Drawing.Color.White;
            txtVingtVingtCinq.Location = new System.Drawing.Point(142, 257);
            txtVingtVingtCinq.MaxLength = 0;
            txtVingtVingtCinq.Name = "txtVingtVingtCinq";
            txtVingtVingtCinq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtVingtVingtCinq.Size = new System.Drawing.Size(49, 20);
            txtVingtVingtCinq.TabIndex = 65;
            // 
            // txtVingtCinqCinquante
            // 
            txtVingtCinqCinquante.AcceptsReturn = true;
            txtVingtCinqCinquante.BackColor = System.Drawing.Color.Black;
            txtVingtCinqCinquante.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtVingtCinqCinquante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtVingtCinqCinquante.ForeColor = System.Drawing.Color.White;
            txtVingtCinqCinquante.Location = new System.Drawing.Point(142, 281);
            txtVingtCinqCinquante.MaxLength = 0;
            txtVingtCinqCinquante.Name = "txtVingtCinqCinquante";
            txtVingtCinqCinquante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtVingtCinqCinquante.Size = new System.Drawing.Size(49, 20);
            txtVingtCinqCinquante.TabIndex = 67;
            // 
            // txtCinquanteCent
            // 
            txtCinquanteCent.AcceptsReturn = true;
            txtCinquanteCent.BackColor = System.Drawing.Color.Black;
            txtCinquanteCent.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCinquanteCent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCinquanteCent.ForeColor = System.Drawing.Color.White;
            txtCinquanteCent.Location = new System.Drawing.Point(142, 305);
            txtCinquanteCent.MaxLength = 0;
            txtCinquanteCent.Name = "txtCinquanteCent";
            txtCinquanteCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCinquanteCent.Size = new System.Drawing.Size(49, 20);
            txtCinquanteCent.TabIndex = 69;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(17, 248);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(62, 13);
            Label1.TabIndex = 76;
            Label1.Text = "Gestion  :";
            // 
            // Label40
            // 
            Label40.AutoSize = true;
            Label40.BackColor = System.Drawing.Color.Black;
            Label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label40.ForeColor = System.Drawing.Color.White;
            Label40.Location = new System.Drawing.Point(17, 200);
            Label40.Name = "Label40";
            Label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label40.Size = new System.Drawing.Size(77, 13);
            Label40.TabIndex = 44;
            Label40.Text = "Installation :";
            // 
            // Label39
            // 
            Label39.AutoSize = true;
            Label39.BackColor = System.Drawing.Color.Black;
            Label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label39.ForeColor = System.Drawing.Color.White;
            Label39.Location = new System.Drawing.Point(17, 224);
            Label39.Name = "Label39";
            Label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label39.Size = new System.Drawing.Size(147, 13);
            Label39.TabIndex = 40;
            Label39.Text = "Formation du personnel :";
            // 
            // Label38
            // 
            Label38.AutoSize = true;
            Label38.BackColor = System.Drawing.Color.Black;
            Label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label38.ForeColor = System.Drawing.Color.White;
            Label38.Location = new System.Drawing.Point(17, 32);
            Label38.Name = "Label38";
            Label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label38.Size = new System.Drawing.Size(140, 13);
            Label38.TabIndex = 38;
            Label38.Text = "Conception et dessins :";
            // 
            // txtLeGrand
            // 
            txtLeGrand.AcceptsReturn = true;
            txtLeGrand.BackColor = System.Drawing.Color.Black;
            txtLeGrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtLeGrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtLeGrand.ForeColor = System.Drawing.Color.White;
            txtLeGrand.Location = new System.Drawing.Point(272, 188);
            txtLeGrand.MaxLength = 0;
            txtLeGrand.Name = "txtLeGrand";
            txtLeGrand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtLeGrand.Size = new System.Drawing.Size(49, 20);
            txtLeGrand.TabIndex = 50;
            // 
            // txtLamine
            // 
            txtLamine.AcceptsReturn = true;
            txtLamine.BackColor = System.Drawing.Color.Black;
            txtLamine.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtLamine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtLamine.ForeColor = System.Drawing.Color.White;
            txtLamine.Location = new System.Drawing.Point(272, 212);
            txtLamine.MaxLength = 0;
            txtLamine.Name = "txtLamine";
            txtLamine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtLamine.Size = new System.Drawing.Size(49, 20);
            txtLamine.TabIndex = 52;
            // 
            // txtThermo
            // 
            txtThermo.AcceptsReturn = true;
            txtThermo.BackColor = System.Drawing.Color.Black;
            txtThermo.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtThermo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtThermo.ForeColor = System.Drawing.Color.White;
            txtThermo.Location = new System.Drawing.Point(272, 236);
            txtThermo.MaxLength = 0;
            txtThermo.Name = "txtThermo";
            txtThermo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtThermo.Size = new System.Drawing.Size(49, 20);
            txtThermo.TabIndex = 54;
            // 
            // txt4em
            // 
            txt4em.AcceptsReturn = true;
            txt4em.BackColor = System.Drawing.Color.Black;
            txt4em.Cursor = System.Windows.Forms.Cursors.IBeam;
            txt4em.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt4em.ForeColor = System.Drawing.Color.White;
            txt4em.Location = new System.Drawing.Point(272, 260);
            txt4em.MaxLength = 0;
            txt4em.Name = "txt4em";
            txt4em.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txt4em.Size = new System.Drawing.Size(49, 20);
            txt4em.TabIndex = 56;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = System.Drawing.Color.Black;
            Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label7.ForeColor = System.Drawing.Color.White;
            Label7.Location = new System.Drawing.Point(216, 188);
            Label7.Name = "Label7";
            Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label7.Size = new System.Drawing.Size(55, 13);
            Label7.TabIndex = 49;
            Label7.Text = "LeGrand";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = System.Drawing.Color.Black;
            Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label8.ForeColor = System.Drawing.Color.White;
            Label8.Location = new System.Drawing.Point(216, 212);
            Label8.Name = "Label8";
            Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label8.Size = new System.Drawing.Size(47, 13);
            Label8.TabIndex = 51;
            Label8.Text = "Laminé";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = System.Drawing.Color.Black;
            Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label9.ForeColor = System.Drawing.Color.White;
            Label9.Location = new System.Drawing.Point(216, 236);
            Label9.Name = "Label9";
            Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label9.Size = new System.Drawing.Size(49, 13);
            Label9.TabIndex = 53;
            Label9.Text = "Thermo";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = System.Drawing.Color.Black;
            Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label10.ForeColor = System.Drawing.Color.White;
            Label10.Location = new System.Drawing.Point(216, 260);
            Label10.Name = "Label10";
            Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label10.Size = new System.Drawing.Size(30, 13);
            Label10.TabIndex = 55;
            Label10.Text = "4em";
            // 
            // Label37
            // 
            Label37.AutoSize = true;
            Label37.BackColor = System.Drawing.Color.Black;
            Label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label37.ForeColor = System.Drawing.Color.White;
            Label37.Location = new System.Drawing.Point(17, 176);
            Label37.Name = "Label37";
            Label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label37.Size = new System.Drawing.Size(87, 13);
            Label37.TabIndex = 36;
            Label37.Text = "Tests Finaux :";
            // 
            // Label36
            // 
            Label36.AutoSize = true;
            Label36.BackColor = System.Drawing.Color.Black;
            Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label36.ForeColor = System.Drawing.Color.White;
            Label36.Location = new System.Drawing.Point(17, 152);
            Label36.Name = "Label36";
            Label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label36.Size = new System.Drawing.Size(119, 13);
            Label36.TabIndex = 32;
            Label36.Text = "Peinture et finition :";
            // 
            // Label35
            // 
            Label35.AutoSize = true;
            Label35.BackColor = System.Drawing.Color.Black;
            Label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label35.ForeColor = System.Drawing.Color.White;
            Label35.Location = new System.Drawing.Point(17, 128);
            Label35.Name = "Label35";
            Label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label35.Size = new System.Drawing.Size(161, 13);
            Label35.TabIndex = 28;
            Label35.Text = "Assemblage des systèmes :";
            // 
            // Label34
            // 
            Label34.AutoSize = true;
            Label34.BackColor = System.Drawing.Color.Black;
            Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label34.ForeColor = System.Drawing.Color.White;
            Label34.Location = new System.Drawing.Point(17, 104);
            Label34.Name = "Label34";
            Label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label34.Size = new System.Drawing.Size(170, 13);
            Label34.TabIndex = 24;
            Label34.Text = "Coupe, soudure et meulage :";
            // 
            // Label33
            // 
            Label33.AutoSize = true;
            Label33.BackColor = System.Drawing.Color.Black;
            Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label33.ForeColor = System.Drawing.Color.White;
            Label33.Location = new System.Drawing.Point(17, 56);
            Label33.Name = "Label33";
            Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label33.Size = new System.Drawing.Size(222, 13);
            Label33.TabIndex = 20;
            Label33.Text = "Coupe et préparation (sauf soudage) :";
            // 
            // Label32
            // 
            Label32.AutoSize = true;
            Label32.BackColor = System.Drawing.Color.Black;
            Label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label32.ForeColor = System.Drawing.Color.White;
            Label32.Location = new System.Drawing.Point(17, 80);
            Label32.Name = "Label32";
            Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label32.Size = new System.Drawing.Size(77, 13);
            Label32.TabIndex = 16;
            Label32.Text = "Machinage :";
            // 
            // Label27
            // 
            Label27.AutoSize = true;
            Label27.BackColor = System.Drawing.Color.Black;
            Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label27.ForeColor = System.Drawing.Color.White;
            Label27.Location = new System.Drawing.Point(15, 173);
            Label27.Name = "Label27";
            Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label27.Size = new System.Drawing.Size(153, 13);
            Label27.TabIndex = 34;
            Label27.Text = "Programmation de vision :";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.BackColor = System.Drawing.Color.Black;
            Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label17.ForeColor = System.Drawing.Color.White;
            Label17.Location = new System.Drawing.Point(14, 196);
            Label17.Name = "Label17";
            Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label17.Size = new System.Drawing.Size(162, 13);
            Label17.TabIndex = 46;
            Label17.Text = "Taux de change espagnol :";
            Label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label16
            // 
            Label16.BackColor = System.Drawing.Color.Black;
            Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label16.ForeColor = System.Drawing.Color.White;
            Label16.Location = new System.Drawing.Point(14, 172);
            Label16.Name = "Label16";
            Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label16.Size = new System.Drawing.Size(159, 13);
            Label16.TabIndex = 42;
            Label16.Text = "Taux de change américain :";
            Label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(14, 31);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(53, 13);
            Label2.TabIndex = 14;
            Label2.Text = "Dessin :";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(15, 101);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(162, 13);
            Label3.TabIndex = 18;
            Label3.Text = "Programmation d\'interface :";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(15, 77);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(82, 13);
            Label4.TabIndex = 22;
            Label4.Text = "Assemblage :";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.Black;
            Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(15, 53);
            Label5.Name = "Label5";
            Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label5.Size = new System.Drawing.Size(78, 13);
            Label5.TabIndex = 26;
            Label5.Text = "Fabrication :";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = System.Drawing.Color.Black;
            Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label6.ForeColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(15, 197);
            Label6.Name = "Label6";
            Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label6.Size = new System.Drawing.Size(40, 13);
            Label6.TabIndex = 30;
            Label6.Text = "Test :";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.BackColor = System.Drawing.Color.Black;
            label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label54.ForeColor = System.Drawing.Color.White;
            label54.Location = new System.Drawing.Point(373, 17);
            label54.Name = "label54";
            label54.Size = new System.Drawing.Size(77, 13);
            label54.TabIndex = 117;
            label54.Text = "Version SQL";
            // 
            // txtVersionSQL
            // 
            txtVersionSQL.BackColor = System.Drawing.Color.Black;
            txtVersionSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtVersionSQL.ForeColor = System.Drawing.Color.White;
            txtVersionSQL.Location = new System.Drawing.Point(457, 14);
            txtVersionSQL.Name = "txtVersionSQL";
            txtVersionSQL.Size = new System.Drawing.Size(70, 20);
            txtVersionSQL.TabIndex = 118;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Black;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            button2.Location = new System.Drawing.Point(432, 819);
            button2.Name = "button2";
            button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button2.Size = new System.Drawing.Size(73, 25);
            button2.TabIndex = 120;
            button2.Text = "&Imprimer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(Label25);
            groupBox1.Controls.Add(Label26);
            groupBox1.Controls.Add(Label12);
            groupBox1.Controls.Add(Label30);
            groupBox1.Controls.Add(Label11);
            groupBox1.Controls.Add(Label31);
            groupBox1.Controls.Add(Label19);
            groupBox1.Controls.Add(txtImprevus);
            groupBox1.Controls.Add(Label24);
            groupBox1.Controls.Add(txtLeGrand);
            groupBox1.Controls.Add(Label23);
            groupBox1.Controls.Add(txtProfitElec);
            groupBox1.Controls.Add(Label22);
            groupBox1.Controls.Add(Label21);
            groupBox1.Controls.Add(txtCommission);
            groupBox1.Controls.Add(txtDixMoins);
            groupBox1.Controls.Add(Label20);
            groupBox1.Controls.Add(Label18);
            groupBox1.Controls.Add(txtLamine);
            groupBox1.Controls.Add(txtCentPlus);
            groupBox1.Controls.Add(txtIndice);
            groupBox1.Controls.Add(txtCinquanteCent);
            groupBox1.Controls.Add(txtCheminSEE4000);
            groupBox1.Controls.Add(txtVingtCinqCinquante);
            groupBox1.Controls.Add(txtThermo);
            groupBox1.Controls.Add(txtVingtVingtCinq);
            groupBox1.Controls.Add(Label10);
            groupBox1.Controls.Add(txtDixQuinze);
            groupBox1.Controls.Add(txtProfitMec);
            groupBox1.Controls.Add(txt4em);
            groupBox1.Controls.Add(Label9);
            groupBox1.Controls.Add(txtQuinzeVingt);
            groupBox1.Controls.Add(Label7);
            groupBox1.Controls.Add(Label8);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(10, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(334, 368);
            groupBox1.TabIndex = 121;
            groupBox1.TabStop = false;
            groupBox1.Text = "Général";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Label2);
            groupBox2.Controls.Add(Label27);
            groupBox2.Controls.Add(Label29);
            groupBox2.Controls.Add(Label41);
            groupBox2.Controls.Add(Label3);
            groupBox2.Controls.Add(Label28);
            groupBox2.Controls.Add(Label4);
            groupBox2.Controls.Add(Label43);
            groupBox2.Controls.Add(Label5);
            groupBox2.Controls.Add(Label44);
            groupBox2.Controls.Add(Label6);
            groupBox2.Controls.Add(Label45);
            groupBox2.Controls.Add(Label52);
            groupBox2.Controls.Add(txtShippingElec);
            groupBox2.Controls.Add(txtTestElec);
            groupBox2.Controls.Add(txtFabrication);
            groupBox2.Controls.Add(txtAssemblageElec);
            groupBox2.Controls.Add(txtProgInterface);
            groupBox2.Controls.Add(txtDessinElec);
            groupBox2.Controls.Add(txtProgVision);
            groupBox2.Controls.Add(txtProgAutomate);
            groupBox2.Controls.Add(txtProgRobot);
            groupBox2.Controls.Add(txtInstallationElec);
            groupBox2.Controls.Add(txtMiseEnService);
            groupBox2.Controls.Add(txtGestionProjetsElec);
            groupBox2.Controls.Add(txtFormationElec);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.ForeColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(10, 436);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(334, 343);
            groupBox2.TabIndex = 122;
            groupBox2.TabStop = false;
            groupBox2.Text = "Taux électriques";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Label38);
            groupBox3.Controls.Add(Label32);
            groupBox3.Controls.Add(Label33);
            groupBox3.Controls.Add(Label34);
            groupBox3.Controls.Add(Label35);
            groupBox3.Controls.Add(Label36);
            groupBox3.Controls.Add(Label37);
            groupBox3.Controls.Add(txtShippingMec);
            groupBox3.Controls.Add(Label39);
            groupBox3.Controls.Add(Label40);
            groupBox3.Controls.Add(Label1);
            groupBox3.Controls.Add(Label53);
            groupBox3.Controls.Add(txtMachinage);
            groupBox3.Controls.Add(txtCoupe);
            groupBox3.Controls.Add(txtSoudure);
            groupBox3.Controls.Add(txtAssemblageMec);
            groupBox3.Controls.Add(txtPeinture);
            groupBox3.Controls.Add(txtTestMec);
            groupBox3.Controls.Add(txtDessinMec);
            groupBox3.Controls.Add(txtFormationMec);
            groupBox3.Controls.Add(txtInstallationMec);
            groupBox3.Controls.Add(txtGestionProjetsMec);
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox3.ForeColor = System.Drawing.Color.White;
            groupBox3.Location = new System.Drawing.Point(350, 436);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(326, 343);
            groupBox3.TabIndex = 122;
            groupBox3.TabStop = false;
            groupBox3.Text = "Taux mécaniques";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtRepas);
            groupBox4.Controls.Add(Label51);
            groupBox4.Controls.Add(Label46);
            groupBox4.Controls.Add(Label47);
            groupBox4.Controls.Add(Label49);
            groupBox4.Controls.Add(Label50);
            groupBox4.Controls.Add(txtHebergement1);
            groupBox4.Controls.Add(txtHebergement2);
            groupBox4.Controls.Add(Label48);
            groupBox4.Controls.Add(txtUniteMobile);
            groupBox4.Controls.Add(txtStandard);
            groupBox4.Controls.Add(txtTauxAmericain);
            groupBox4.Controls.Add(Label17);
            groupBox4.Controls.Add(Label16);
            groupBox4.Controls.Add(txtTauxEspagnol);
            groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox4.ForeColor = System.Drawing.Color.White;
            groupBox4.Location = new System.Drawing.Point(350, 62);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(326, 368);
            groupBox4.TabIndex = 123;
            groupBox4.TabStop = false;
            groupBox4.Text = "Prix de l\'hébergement";
            // 
            // Configuration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(692, 855);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtVersionSQL);
            Controls.Add(label54);
            Controls.Add(cmdFermer);
            Controls.Add(cmdAppliquer);
            Controls.Add(Label15);
            Controls.Add(cmdConfig);
            Controls.Add(cmdExportToExcel);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Configuration";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "ControleurServeur.Configuration";
            Load += new System.EventHandler(Configuration_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        internal static TextBox txtShippingMec;
        internal static TextBox txtShippingElec;
        internal static TextBox txtRepas;
        internal static TextBox txtUniteMobile;
        internal static TextBox txtStandard;
        internal static TextBox txtHebergement2;
        internal static TextBox txtHebergement1;
        internal static TextBox txtFormationElec;
        internal static TextBox txtGestionProjetsElec;
        internal static TextBox txtMiseEnService;
        internal static TextBox txtInstallationElec;
        internal static TextBox txtProgRobot;
        internal static TextBox txtProgAutomate;
        internal static TextBox txtGestionProjetsMec;
        internal static TextBox txtInstallationMec;
        internal static TextBox txtFormationMec;
        internal static TextBox txtDessinMec;
        internal static TextBox txtTestMec;
        internal static TextBox txtPeinture;
        internal static TextBox txtAssemblageMec;
        internal static TextBox txtSoudure;
        internal static TextBox txtCoupe;
        internal static TextBox txtMachinage;
        internal static TextBox txtProgVision;
        internal static Button cmdFermer;
        internal static TextBox txtTauxEspagnol;
        internal static Button cmdExportToExcel;
        internal static TextBox txtProfitMec;
        internal static TextBox txtCheminSEE4000;
        internal static TextBox txtIndice;
        internal static TextBox txtCommission;
        internal static TextBox txtProfitElec;
        internal static Button cmdAppliquer;
        internal static TextBox txtImprevus;
        internal static Label Label31;
        internal static Label Label30;
        internal static Label Label26;
        internal static Label Label25;
        internal static Label Label11;
        internal static Label Label12;
        internal static TextBox txtDessinElec;
        internal static TextBox txtProgInterface;
        internal static TextBox txtTauxAmericain;
        internal static TextBox txtAssemblageElec;
        internal static TextBox txtFabrication;
        internal static TextBox txtTestElec;
        internal static Label Label53;
        internal static Label Label52;
        internal static Label Label51;
        internal static Label Label50;
        internal static Label Label49;
        internal static Label Label48;
        internal static Label Label47;
        internal static Label Label46;
        internal static TextBox txtCentPlus;
        internal static Label Label18;
        internal static Label Label20;
        internal static Label Label21;
        internal static Label Label22;
        internal static Label Label23;
        internal static Label Label24;
        internal static Label Label19;
        internal static ToolTip ToolTip1;
        internal static Label Label45;
        internal static Label Label44;
        internal static Label Label43;
        internal static Label Label28;
        internal static Label Label41;
        internal static Label Label29;
        internal static Label Label15;
        internal static Button cmdConfig;
        internal static TextBox txtDixMoins;
        internal static TextBox txtDixQuinze;
        internal static TextBox txtQuinzeVingt;
        internal static TextBox txtVingtVingtCinq;
        internal static TextBox txtVingtCinqCinquante;
        internal static TextBox txtCinquanteCent;
        internal static Label Label1;
        internal static Label Label40;
        internal static Label Label39;
        internal static Label Label38;
        internal static TextBox txtLeGrand;
        internal static TextBox txtLamine;
        internal static TextBox txtThermo;
        internal static TextBox txt4em;
        internal static Label Label7;
        internal static Label Label8;
        internal static Label Label9;
        internal static Label Label10;
        internal static Label Label37;
        internal static Label Label36;
        internal static Label Label35;
        internal static Label Label34;
        internal static Label Label33;
        internal static Label Label32;
        internal static Label Label27;
        internal static Label Label17;
        internal static Label Label16;
        internal static Label Label2;
        internal static Label Label3;
        internal static Label Label4;
        internal static Label Label5;
        internal static Label Label6;
        internal static Label label54;
        internal static TextBox txtVersionSQL;
        internal static Button button2;
        internal static GroupBox groupBox1;
        internal static GroupBox groupBox2;
        internal static GroupBox groupBox3;
        internal static GroupBox groupBox4;
        SqlConnection con = new SqlConnection(StringSQL);
        SqlDataReader reader;
        private string v;
        int[] version = { 0, 0, 0 };
        public Configuration()
        {
            InitializeComponent();
            ChargerConfiguration();
        }
        /// /* Généré par GetOrdinalRequeteSQL_x64 1.0.6 
        /// © Patrice Waechter-Ebling 2024
        /// <param name="0">ProfitElec</param>
        /// <param name="1">ProfitMec</param>
        /// <param name="2">Commission</param>
        /// <param name="3">Imprévus</param>
        /// <param name="4">PrixPagesManuel</param>
        /// <param name="5">IndiceDessin</param>
        /// <param name="6">TauxAmericain</param>
        /// <param name="7">TauxEspagnol</param>
        /// <param name="8">TauxDessinElec</param>
        /// <param name="9">TauxProgInterface</param>
        /// <param name="10">TauxAssemblageElec</param>
        /// <param name="11">TauxFabrication</param>
        /// <param name="12">TauxTestElec</param>
        /// <param name="13">TauxVision</param>
        /// <param name="14">TauxProgAutomate</param>
        /// <param name="15">TauxProgRobot</param>
        /// <param name="16">TauxGestionProjetsElec</param>
        /// <param name="17">TauxInstallationElec</param>
        /// <param name="18">TauxFormationElec</param>
        /// <param name="19">TauxMiseService</param>
        /// <param name="20">TauxShippingElec</param>
        /// <param name="21">LeGrand</param>
        /// <param name="22">Lamine</param>
        /// <param name="23">Thermo</param>
        /// <param name="24">4em</param>
        /// <param name="25">fsDixMoins</param>
        /// <param name="26">fsDix</param>
        /// <param name="27">fsQuinze</param>
        /// <param name="28">fsVingt</param>
        /// <param name="29">fsVingtCinq</param>
        /// <param name="30">fsCinquante</param>
        /// <param name="31">fsCent</param>
        /// <param name="32">Parcel_label_line1</param>
        /// <param name="33">parcel_label_line2</param>
        /// <param name="34">parcel_label_line3</param>
        /// <param name="35">ParcelAssist</param>
        /// <param name="36">ParcelEtat</param>
        /// <param name="37">Hebergement1</param>
        /// <param name="38">Hebergement2</param>
        /// <param name="39">Repas</param>
        /// <param name="40">Standard</param>
        /// <param name="41">UniteMobile</param>
        /// <param name="42">CheminSee4000</param>
        /// <param name="43">TauxMachinage</param>
        /// <param name="44">TauxCoupe</param>
        /// <param name="45">TauxSoudure</param>
        /// <param name="46">TauxAssemblageMec</param>
        /// <param name="47">TauxPeinture</param>
        /// <param name="48">TauxTestMec</param>
        /// <param name="49">TauxDessinMec</param>
        /// <param name="50">TauxFormationMec</param>
        /// <param name="51">TauxInstallationMec</param>
        /// <param name="52">TauxGestionProjetsMec</param>
        /// <param name="53">TauxShippingMec</param>
        /// <param name="54">DerniereVersion</param> 
        public Configuration(string v)
        {
            InitializeComponent();
            v = v;
            try
            {
                SqlConnection con = new SqlConnection(StringSQL);
                con.Open();
                SqlDataReader dB = new SqlCommand("SELECT DISTINCT  TOP(1) *  FROM [DBO].[CONFIG] ORDER BY TAUXTESTELEC ASC\r\n", con).ExecuteReader();
                while (dB.Read())
                {
                    txtFabrication.Text = dB[11].ToString();
                    txtProfitElec.Text = dB[0].ToString();
                    txtProfitMec.Text = dB[1].ToString();
                    txtCommission.Text = dB[2].ToString();
                    txtImprevus.Text = dB[3].ToString();
                    txtProgInterface.Text = dB[4].ToString();
                    txtIndice.Text = dB[5].ToString();
                    txtTauxAmericain.Text = dB[6].ToString();
                    txtTauxEspagnol.Text = dB[7].ToString();
                    txtDessinElec.Text = dB[8].ToString();
                    txtDessinMec.Text = dB[9].ToString();
                    txtAssemblageElec.Text = dB[10].ToString();
                    txtAssemblageMec.Text = dB[46].ToString();
                    txtTestElec.Text = dB[12].ToString();
                    txtProgVision.Text = dB[13].ToString();
                    txtProgAutomate.Text = dB[14].ToString();
                    txtProgRobot.Text = dB[15].ToString();
                    txtGestionProjetsElec.Text = dB[16].ToString();
                    txtInstallationElec.Text = dB[17].ToString();
                    txtFormationElec.Text = dB[18].ToString();
                    txtMiseEnService.Text = dB[19].ToString();
                    txtShippingElec.Text = dB[20].ToString();
                    txtLeGrand.Text = dB[21].ToString();
                    txtLamine.Text = dB[22].ToString();
                    txtThermo.Text = dB[23].ToString();
                    txt4em.Text = dB[24].ToString();
                    txtDixMoins.Text = dB[25].ToString();
                    txtDixQuinze.Text = dB[26].ToString();
                    txtQuinzeVingt.Text = dB[28].ToString();
                    txtVingtVingtCinq.Text = dB[29].ToString();
                    txtVingtCinqCinquante.Text = dB[30].ToString();
                    txtCinquanteCent.Text = dB[31].ToString();
                    txtCentPlus.Text = dB[31].ToString();
                    txtHebergement1.Text = dB[37].ToString();
                    txtHebergement2.Text = dB[38].ToString();
                    txtRepas.Text = dB[39].ToString();
                    txtStandard.Text = dB[40].ToString();
                    txtUniteMobile.Text = dB[41].ToString();
                    txtCheminSEE4000.Text = dB[42].ToString();
                    txtMachinage.Text = dB[43].ToString();
                    txtCoupe.Text = dB[44].ToString();
                    txtSoudure.Text = dB[45].ToString();
                    txtPeinture.Text = dB[47].ToString();
                    txtTestMec.Text = dB[48].ToString();
                    txtDessinMec.Text = dB[49].ToString();
                    txtFormationMec.Text = dB[50].ToString();
                    txtInstallationMec.Text = dB[51].ToString();
                    txtGestionProjetsMec.Text = dB[52].ToString();
                    txtShippingMec.Text = dB[53].ToString();
                    VersionDB = dB[54].ToString();
                    txtVersionSQL.Text = VersionDB;
                    cmdFermer.Visible = false;
                    cmdAppliquer.Text = "Corriger";
                    cmdAppliquer.Left = cmdFermer.Left;
                    cmdAppliquer.BackColor = COLOR_ROUGE;
                    cmdAppliquer.ForeColor = COLOR_BLANC;
                    SauvegarderConfig();
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Configuration", "Configuration.Configuration.2", ex);
            }
        }
        /// vider la table
        /// elimine de facon permanente toutes les entrees afin de pouvoir 
        ///recreer une entree contenant la CONFIG affichee sur le formulaire
        ///j'ai opté pour le Recorset plutot que la methode SQLClient>SQLCommand>Execute
        private void SauvegarderConfig()
        {
            try
            {
                StreamWriter sw;
                if (modeDev)
                {
                    sw = new StreamWriter($"{Environment.CurrentDirectory}\\configGRB.bck", true);
                }
                else
                {
                    sw = new StreamWriter($"{Tests}\\configGRB.bck", true);
                }
                sw.WriteLine($"{DateTime.Now.ToString()} => {IdNomEmploye} => {IdGroupe}");
                for (int a = 0; a < Controls.Count; a++)
                {
                    if (Controls[a].Visible)
                    {
                        sw.WriteLine($"{Controls[a].Name}=>{Controls[a].Text}");
                    }
                }
                sw.Close();
                ADODB.Recordset rst = new ADODB.Recordset();
                SqlLinkODBC(rst, "select * from CONFIG");
                if (rst.RecordCount > 1)
                {
                    rst.Delete(AffectEnum.adAffectAll);
                    rst.AddNew();
                    rst.Fields[0].Value = txtProfitElec.Text;
                    rst.Fields[1].Value = txtProfitMec.Text;
                    rst.Fields[2].Value = txtCommission.Text;
                    rst.Fields[3].Value = txtImprevus.Text;
                    rst.Fields[4].Value = txtProgInterface.Text;
                    rst.Fields[5].Value = txtIndice.Text;
                    rst.Fields[6].Value = txtTauxAmericain.Text;
                    rst.Fields[7].Value = txtTauxEspagnol.Text;
                    rst.Fields[8].Value = txtDessinElec.Text;
                    rst.Fields[9].Value = txtDessinMec.Text;
                    rst.Fields[10].Value = txtAssemblageElec.Text;
                    rst.Fields[11].Value = txtFabrication.Text;
                    rst.Fields[12].Value = txtTestElec.Text;
                    rst.Fields[13].Value = txtProgVision.Text;
                    rst.Fields[14].Value = txtProgAutomate.Text;
                    rst.Fields[15].Value = txtProgRobot.Text;
                    rst.Fields[16].Value = txtGestionProjetsElec.Text;
                    rst.Fields[17].Value = txtInstallationElec.Text;
                    rst.Fields[18].Value = txtFormationElec.Text;
                    rst.Fields[19].Value = txtMiseEnService.Text;
                    rst.Fields[20].Value = txtShippingElec.Text;
                    rst.Fields[21].Value = txtLeGrand.Text;
                    rst.Fields[22].Value = txtLamine.Text;
                    rst.Fields[23].Value = txtThermo.Text;
                    rst.Fields[24].Value = txt4em.Text;
                    rst.Fields[25].Value = txtDixMoins.Text;
                    rst.Fields[26].Value = txtDixQuinze.Text;
                    rst.Fields[28].Value = txtQuinzeVingt.Text;
                    rst.Fields[29].Value = txtVingtVingtCinq.Text;
                    rst.Fields[30].Value = txtVingtCinqCinquante.Text;
                    rst.Fields[31].Value = txtCinquanteCent.Text;
                    rst.Fields[32].Value = "Les Produits Tourval inc";
                    rst.Fields[33].Value = "50, rue du Pacifique Est Bromont, J2L 1J5";
                    rst.Fields[34].Value = "CANADA";
                    rst.Fields[35].Value = "Chantal Couture poste 230";
                    rst.Fields[36].Value = "Québec";
                    rst.Fields[37].Value = txtHebergement1.Text;
                    rst.Fields[38].Value = txtHebergement2.Text;
                    rst.Fields[39].Value = txtRepas.Text;
                    rst.Fields[40].Value = txtStandard.Text;
                    rst.Fields[41].Value = txtUniteMobile.Text;
                    rst.Fields[42].Value = txtCheminSEE4000.Text;
                    rst.Fields[43].Value = txtMachinage.Text;
                    rst.Fields[44].Value = txtCoupe.Text;
                    rst.Fields[45].Value = txtSoudure.Text;
                    rst.Fields[46].Value = txtAssemblageMec.Text;
                    rst.Fields[47].Value = txtPeinture.Text;
                    rst.Fields[48].Value = txtTestMec.Text;
                    rst.Fields[49].Value = txtDessinMec.Text;
                    rst.Fields[50].Value = txtFormationMec.Text;
                    rst.Fields[51].Value = txtInstallationMec.Text;
                    rst.Fields[52].Value = txtGestionProjetsMec.Text;
                    rst.Fields[53].Value = txtShippingMec.Text;
                    rst.Fields[54].Value = txtVersionSQL.Text;
                    rst.Update();
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Configuration", "SauvegarderConfig", ex);
            }
        }
        private void SauvegarderModifications()
        {
            try
            {
                ADODB.Recordset rst = new ADODB.Recordset();
                SqlLinkODBC(rst, "select TOP(1) * from CONFIG");
                while (!rst.EOF)
                {
                    rst.Fields[0].Value = txtProfitElec.Text;
                    rst.Fields[1].Value = txtProfitMec.Text;
                    rst.Fields[2].Value = txtCommission.Text;
                    rst.Fields[3].Value = txtImprevus.Text;
                    rst.Fields[4].Value = txtProgInterface.Text;
                    rst.Fields[5].Value = txtIndice.Text;
                    rst.Fields[6].Value = txtTauxAmericain.Text;
                    rst.Fields[7].Value = txtTauxEspagnol.Text;
                    rst.Fields[8].Value = txtDessinElec.Text;
                    rst.Fields[9].Value = txtDessinMec.Text;
                    rst.Fields[10].Value = txtAssemblageElec.Text;
                    rst.Fields[11].Value = txtFabrication.Text;
                    rst.Fields[12].Value = txtTestElec.Text;
                    rst.Fields[13].Value = txtProgVision.Text;
                    rst.Fields[14].Value = txtProgAutomate.Text;
                    rst.Fields[15].Value = txtProgRobot.Text;
                    rst.Fields[16].Value = txtGestionProjetsElec.Text;
                    rst.Fields[17].Value = txtInstallationElec.Text;
                    rst.Fields[18].Value = txtFormationElec.Text;
                    rst.Fields[19].Value = txtMiseEnService.Text;
                    rst.Fields[20].Value = txtShippingElec.Text;
                    rst.Fields[21].Value = txtLeGrand.Text;
                    rst.Fields[22].Value = txtLamine.Text;
                    rst.Fields[23].Value = txtThermo.Text;
                    rst.Fields[24].Value = txt4em.Text;
                    rst.Fields[25].Value = txtDixMoins.Text;
                    rst.Fields[26].Value = txtDixQuinze.Text;
                    rst.Fields[28].Value = txtQuinzeVingt.Text;
                    rst.Fields[29].Value = txtVingtVingtCinq.Text;
                    rst.Fields[30].Value = txtVingtCinqCinquante.Text;
                    rst.Fields[31].Value = txtCinquanteCent.Text;
                    rst.Fields[37].Value = txtHebergement1.Text;
                    rst.Fields[38].Value = txtHebergement2.Text;
                    rst.Fields[39].Value = txtRepas.Text;
                    rst.Fields[40].Value = txtStandard.Text;
                    rst.Fields[41].Value = txtUniteMobile.Text;
                    rst.Fields[42].Value = txtCheminSEE4000.Text;
                    rst.Fields[43].Value = txtMachinage.Text;
                    rst.Fields[44].Value = txtCoupe.Text;
                    rst.Fields[45].Value = txtSoudure.Text;
                    rst.Fields[46].Value = txtAssemblageMec.Text;
                    rst.Fields[47].Value = txtPeinture.Text;
                    rst.Fields[48].Value = txtTestMec.Text;
                    rst.Fields[49].Value = txtDessinMec.Text;
                    rst.Fields[50].Value = txtFormationMec.Text;
                    rst.Fields[51].Value = txtInstallationMec.Text;
                    rst.Fields[52].Value = txtGestionProjetsMec.Text;
                    rst.Fields[53].Value = txtShippingMec.Text;
                    rst.Fields[54].Value = txtVersionSQL.Text;
                    rst.Update();
                }
                rst.Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("Configuration", "SauvegarderModifications", ex);
            }
        }
        private void RegenererConfig()
        {
            con = new SqlConnection(StringSQL);
            con.Open();
            reader = new SqlCommand(v, con).ExecuteReader();
            /// gestion des entrées excedentaires via le controle ConfigCheck 
            /// opération reservées IT
            while (reader.Read())
            {
                txtFabrication.Text = reader[11].ToString();
                txtProfitElec.Text = reader[0].ToString();
                txtProfitMec.Text = reader[1].ToString();
                txtCommission.Text = reader[2].ToString();
                txtImprevus.Text = reader[3].ToString();
                txtProgInterface.Text = reader[4].ToString();
                txtIndice.Text = reader[5].ToString();
                txtTauxAmericain.Text = reader[6].ToString();
                txtTauxEspagnol.Text = reader[7].ToString();
                txtDessinElec.Text = reader[8].ToString();
                txtDessinMec.Text = reader[9].ToString();
                txtAssemblageElec.Text = reader[10].ToString();
                txtAssemblageMec.Text = reader[46].ToString();
                txtTestElec.Text = reader[12].ToString();
                txtProgVision.Text = reader[13].ToString();
                txtProgAutomate.Text = reader[14].ToString();
                txtProgRobot.Text = reader[15].ToString();
                txtGestionProjetsElec.Text = reader[16].ToString();
                txtInstallationElec.Text = reader[17].ToString();
                txtFormationElec.Text = reader[18].ToString();
                txtMiseEnService.Text = reader[19].ToString();
                txtShippingElec.Text = reader[20].ToString();
                txtLeGrand.Text = reader[21].ToString();
                txtLamine.Text = reader[22].ToString();
                txtThermo.Text = reader[23].ToString();
                txt4em.Text = reader[24].ToString();
                txtDixMoins.Text = reader[25].ToString();
                txtDixQuinze.Text = reader[26].ToString();
                txtQuinzeVingt.Text = reader[28].ToString();
                txtVingtVingtCinq.Text = reader[29].ToString();
                txtVingtCinqCinquante.Text = reader[30].ToString();
                txtCinquanteCent.Text = reader[31].ToString();
                txtCentPlus.Text = reader[31].ToString();
                txtHebergement1.Text = reader[37].ToString();
                txtHebergement2.Text = reader[38].ToString();
                txtRepas.Text = reader[39].ToString();
                txtStandard.Text = reader[40].ToString();
                txtUniteMobile.Text = reader[41].ToString();
                txtCheminSEE4000.Text = reader[42].ToString();
                txtMachinage.Text = reader[43].ToString();
                txtCoupe.Text = reader[44].ToString();
                txtSoudure.Text = reader[45].ToString();
                txtPeinture.Text = reader[47].ToString();
                txtTestMec.Text = reader[48].ToString();
                txtDessinMec.Text = reader[49].ToString();
                txtFormationMec.Text = reader[50].ToString();
                txtInstallationMec.Text = reader[51].ToString();
                txtGestionProjetsMec.Text = reader[52].ToString();
                txtShippingMec.Text = reader[53].ToString();
                txtVersionSQL.Text = VersionDB;
            }
            if (reader != null) { reader.Close(); }
            if (con != null) { con.Close(); }
        }
        private void ChargerConfiguration()
        {
            con = new SqlConnection(StringSQL);
            int x = 0;
            con.Open();
            reader = new SqlCommand("SELECT * FROM [DBO].[CONFIG]", con).ExecuteReader();
            while (reader.Read())
            {
                x++;
                txtFabrication.Text = reader[11].ToString();
                txtProfitElec.Text = reader[0].ToString();
                txtProfitMec.Text = reader[1].ToString();
                txtCommission.Text = reader[2].ToString();
                txtImprevus.Text = reader[3].ToString();
                txtProgInterface.Text = reader[4].ToString();
                txtIndice.Text = reader[5].ToString();
                txtTauxAmericain.Text = reader[6].ToString();
                txtTauxEspagnol.Text = reader[7].ToString();
                txtDessinElec.Text = reader[8].ToString();
                txtDessinMec.Text = reader[9].ToString();
                txtAssemblageElec.Text = reader[10].ToString();
                txtAssemblageMec.Text = reader[46].ToString();
                txtTestElec.Text = reader[12].ToString();
                txtProgVision.Text = reader[13].ToString();
                txtProgAutomate.Text = reader[14].ToString();
                txtProgRobot.Text = reader[15].ToString();
                txtGestionProjetsElec.Text = reader[16].ToString();
                txtInstallationElec.Text = reader[17].ToString();
                txtFormationElec.Text = reader[18].ToString();
                txtMiseEnService.Text = reader[19].ToString();
                txtShippingElec.Text = reader[20].ToString();
                txtLeGrand.Text = reader[21].ToString();
                txtLamine.Text = reader[22].ToString();
                txtThermo.Text = reader[23].ToString();
                txt4em.Text = reader[24].ToString();
                txtDixMoins.Text = reader[25].ToString();
                txtDixQuinze.Text = reader[26].ToString();
                txtQuinzeVingt.Text = reader[28].ToString();
                txtVingtVingtCinq.Text = reader[29].ToString();
                txtVingtCinqCinquante.Text = reader[30].ToString();
                txtCinquanteCent.Text = reader[31].ToString();
                txtCentPlus.Text = reader[31].ToString();
                txtHebergement1.Text = reader[37].ToString();
                txtHebergement2.Text = reader[38].ToString();
                txtRepas.Text = reader[39].ToString();
                txtStandard.Text = reader[40].ToString();
                txtUniteMobile.Text = reader[41].ToString();
                txtCheminSEE4000.Text = reader[42].ToString();
                txtMachinage.Text = reader[43].ToString();
                txtCoupe.Text = reader[44].ToString();
                txtSoudure.Text = reader[45].ToString();
                txtPeinture.Text = reader[47].ToString();
                txtTestMec.Text = reader[48].ToString();
                txtDessinMec.Text = reader[49].ToString();
                txtFormationMec.Text = reader[50].ToString();
                txtInstallationMec.Text = reader[51].ToString();
                txtGestionProjetsMec.Text = reader[52].ToString();
                txtShippingMec.Text = reader[53].ToString();
                VersionDB = reader[54].ToString();
                txtVersionSQL.Text = VersionDB;
            }
            if (reader != null) { reader.Close(); }
            if (con != null) { con.Close(); }
            MessageBox.Show("Version distribuée d'Web." + VersionDB, Application.ProductName);
            if (x > 1)
            {
                MessageBox.Show(x.ToString() + " configurations ont étées détectées ", Application.ProductName);
                Form f = new ControleurServeur.InterfaceWeb($"{webServer}/ProblemeConfig?cfg=x&fix=1");
            }
        }
        private void Configuration_Load(object sender, EventArgs e) => Icon = Conteneur.ActiveForm.Icon;
        private void cmdFermer_Click(object sender, EventArgs e) => Close();
        private void cmdAppliquer_Click(object sender, EventArgs e)
        {
            if (cmdAppliquer.Text == "Corriger")
            {
                UpdateSQL("DELETE FROM [DBO].[CONFIG]");
                UpdateSQL("INSERT [DBO].[Config] ([ProfitElec], [ProfitMec], [Commission], [Imprévus], [PrixPagesManuel]," +
                " [IndiceDessin], [TauxAmericain], [TauxEspagnol], [TauxDessinElec], [TauxProgInterface], [TauxAssemblageElec]," +
                " [TauxFabrication], [TauxTestElec], [TauxVision], [TauxProgAutomate], [TauxProgRobot], [TauxGestionProjetsElec]," +
                " [TauxInstallationElec], [TauxFormationElec], [TauxMiseService], [TauxShippingElec], [LeGrand], [Lamine], [Thermo]," +
                " [4em], [fsDixMoins], [fsDix], [fsQuinze], [fsVingt], [fsVingtCinq], [fsCinquante], [fsCent], [Parcel_label_line1]," +
                " [parcel_label_line2], [parcel_label_line3], [ParcelAssist], [ParcelEtat], [Hebergement1], [Hebergement2], [Repas]," +
                " [Standard], [UniteMobile], [CheminSee4000], [TauxMachinage], [TauxCoupe], [TauxSoudure], [TauxAssemblageMec]," +
                " [TauxPeinture], [TauxTestMec], [TauxDessinMec], [TauxFormationMec],[TauxInstallationMec], [TauxGestionProjetsMec]," +
                " [TauxShippingMec], [DerniereVersion]) VALUES (" +
                " N'1,40', N'1,40', N'0,09', N'0,10', N'0,05', N'1', N'0,73', N'102,161', N'85', N'105', N'85', N'85', N'105', N'105'," +
                " N'105', N'105', N'85', N'100', N'85', N'100', N'60', N'1', N'1,50', N'1,75', N'2', N'0,017', N'0,015', N'0,01'," +
                " N'0,009', N'0,007', N'0,005', N'0,004', N'Les Produits Tourval inc', N'50, rue du Pacifique Est Bromont, J2L 1J5', N'CANADA '," +
                " N'Chantal Couture #230', N'Quebec', N'75', N'90', N'50', N'0,55', N'1,00', N'\\\\Serveur\\bdgrb\\SEEGRB\\Equipment.mdb', N'85'," +
                " N'85', N'85', N'85', N'85', N'85', N'85', N'85', N'85', N'85', N'60', N'2.24.180')\r\n");
            }
            SauvegarderModifications();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tmpVersion = $"{DateTime.Today.Year.ToString()[0]}.{DateTime.Now.Year.ToString().Substring(2, 2)}.{DateTime.Now.DayOfYear}";
            if (MessageBox.Show($"Voulez vous patcher la version de la DB \n de: {VersionDB}\nvers: {tmpVersion}?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateSQL($"UPDATE [DBO].[CONFIG] SET [DERNIEREVERSION]='{VersionDB}';");
                txtVersionSQL.Text = tmpVersion;
            }
        }
        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            Recordset rd = new Recordset();
            Microsoft.Office.Interop.Excel.Application oXLApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oXLBook = oXLApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet oXLSheet = (Microsoft.Office.Interop.Excel.Worksheet)oXLBook.Worksheets[1];
            rd.Open("SELECT TOP (1)* FROM [DBO].[CONFIG]", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            oXLApp.Visible = true;
            while (!rd.EOF)
            {
                Conteneur.txtStatus.Text = "Transfert vers Excel de " + Text;
                oXLSheet.get_Range("A:B").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
                oXLSheet.get_Range("A1: B1").Font.Bold = true;
                oXLSheet.get_Range("A1: B1").set_Value(value: new object[] { "Clef", "Valeur" });
                oXLSheet.get_Range("A:B").Columns.AutoFit();
                for (int x = 0; x < rd.Fields.Count; x++)
                {
                    oXLSheet.Cells[x + 2, 1] = rd.Fields[x].Name;
                    oXLSheet.Cells[x + 2, 2] = rd.Fields[x].Value;
                }
                rd.MoveNext();
            }
            oXLSheet.Cells[2, 1] = "Profit électrique:";
            oXLSheet.Cells[3, 1] = "Profit mécanique:";
            oXLSheet.Cells[4, 1] = "Commission (% du totale de la soum):";
            oXLSheet.Cells[5, 1] = "Pourcentage d\'imprévus:";
            oXLSheet.Cells[7, 1] = "Indice de dessin (% du tmp dess):";
            oXLSheet.Cells[8, 1] = "Taux de change américain :";
            oXLSheet.Cells[9, 1] = "Taux de change espagnol :";
            oXLSheet.Cells[10, 1] = "Dessin :";//3
            oXLSheet.Cells[11, 1] = "Programmation d\'interface :";//4
            oXLSheet.Cells[12, 1] = "Assemblage :";//5
            oXLSheet.Cells[13, 1] = "Fabrication :";//6
            oXLSheet.Cells[14, 1] = "Test :";//54
            oXLSheet.Cells[15, 1] = "Programmation de vision :";//17
            oXLSheet.Cells[16, 1] = "Programmation d\'automate :";//15
            oXLSheet.Cells[17, 1] = "Programmation de robot :";//29
            oXLSheet.Cells[18, 1] = "Gestion  :";//40
            oXLSheet.Cells[19, 1] = "Installation :";//41
            oXLSheet.Cells[20, 1] = "Formation du personnel :";//44
            oXLSheet.Cells[21, 1] = "Mise en service :";//28
            oXLSheet.Cells[22, 1] = "Shipping :";//52
            oXLSheet.Cells[23, 1] = "LeGrand";//8
            oXLSheet.Cells[24, 1] = "Laminé";//9
            oXLSheet.Cells[25, 1] = "Thermo";//10
            oXLSheet.Cells[26, 1] = "4em";//37
            oXLSheet.Cells[27, 1] = "10,000$ et -";//20
            oXLSheet.Cells[28, 1] = "10,000$ à 15,000$ ";//ToolTip1
            oXLSheet.Cells[29, 1] = "15,000$ à 20,000$";//21
            oXLSheet.Cells[30, 1] = "20,000$ à 25,000$";//22
            oXLSheet.Cells[31, 1] = "25,000$ à 50,000$";//23
            oXLSheet.Cells[32, 1] = "50,000$ à 100,000$ ";//24
            oXLSheet.Cells[33, 1] = "100,000$ et +";//19
            oXLSheet.Cells[39, 1] = "Chambre à 1 lit :";
            oXLSheet.Cells[40, 1] = "Chambre à 2 lits :";
            oXLSheet.Cells[41, 1] = "Repas pour 1 journée :";
            oXLSheet.Cells[42, 1] = "Véhicule standard :";
            oXLSheet.Cells[43, 1] = "Unité mobile :";
            oXLSheet.Cells[44, 1] = "Chemin de la base de données de SEE4000:";
            oXLSheet.Cells[45, 1] = "Machinage :";//27
            oXLSheet.Cells[46, 1] = "Coupe et préparation (sauf soudage) :";//32
            oXLSheet.Cells[47, 1] = "Coupe, soudure et meulage :";//33
            oXLSheet.Cells[48, 1] = "Assemblage des systèmes :";//34
            oXLSheet.Cells[49, 1] = "Peinture et finition :";//35
            oXLSheet.Cells[50, 1] = "Tests Finaux :";//36
            oXLSheet.Cells[51, 1] = "Conception et dessins :";//txtLeGrand
            oXLSheet.Cells[52, 1] = "Formation du personnel :";//38
            oXLSheet.Cells[53, 1] = "Installation :";//39
            oXLSheet.Cells[54, 1] = "Gestion  :";//40
            oXLSheet.Cells[55, 1] = "Shipping :";//51
            oXLSheet.Cells[56, 1] = "Version SQL";
            oXLSheet.Name = Name;
            oXLSheet.SaveAs(Filename: Application.ProductName + "." +oXLSheet.Name + ".xlsx");// force le mode Excel 2007/2010
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font("calibri", 9, System.Drawing.FontStyle.Bold);
            e.Graphics.DrawString($"\n\t\tConfigration DB CONFIG en date du " + DateTime.Now.ToString(), printFont, System.Drawing.Brushes.Black, 0, 0);
            string cmds = "\n\n";
            cmds += $"\n\tProfit électrique:\t" + txtProfitElec.Text;
            cmds += $"\n\tProfit mécanique:\t" + txtProfitMec.Text;
            cmds += $"\n\tCommission (% du totale de la soum):\t" + txtCommission.Text;
            cmds += $"\n\tPourcentage d'imprévus:\t" + txtImprevus.Text;
            cmds += $"\n\tPrixPagesManuel\t" + txtProgInterface.Text;
            cmds += $"\n\tIndice de dessin (% du tmp dess):\t" + txtIndice.Text;
            cmds += $"\n\tTaux de change américain :\t" + txtTauxAmericain.Text;
            cmds += $"\n\tTaux de change espagnol :\t" + txtTauxEspagnol.Text;
            cmds += $"\n\tDessin :\t" + txtDessinElec.Text;
            cmds += $"\n\tProgrammation d'interface :\t" + txtProgInterface.Text;
            cmds += $"\n\tAssemblage :\t" + txtAssemblageElec.Text;
            cmds += $"\n\tFabrication :\t" + txtFabrication.Text;
            cmds += $"\n\tTest :\t" + txtTestElec.Text;
            cmds += $"\n\tProgrammation de vision :\t" + txtProgVision.Text;
            cmds += $"\n\tProgrammation d'automate :\t" + txtProgAutomate.Text;
            cmds += $"\n\tProgrammation de robot :\t" + txtProgRobot.Text;
            cmds += $"\n\tGestion  :\t" + txtGestionProjetsElec.Text;
            cmds += $"\n\tInstallation :\t" + txtInstallationElec.Text;
            cmds += $"\n\tFormation du personnel :\t" + txtFormationElec.Text;
            cmds += $"\n\tMise en service :\t" + txtMiseEnService.Text;
            cmds += $"\n\tShipping :\t" + txtShippingElec.Text;
            cmds += $"\n\tLeGrand\t" + txtLeGrand.Text;
            cmds += $"\n\tLaminé\t" + txtLamine.Text;
            cmds += $"\n\tThermo\t" + txtThermo.Text;
            cmds += $"\n\t4em\t" + txt4em.Text;
            cmds += $"\n\t10,000$ et -\t" + txtDixMoins.Text;
            cmds += $"\n\t10,000$ à 15,000$ \t" + txtDixQuinze.Text;
            cmds += $"\n\t15,000$ à 20,000$\t" + txtQuinzeVingt.Text;
            cmds += $"\n\t20,000$ à 25,000$\t" + txtVingtVingtCinq.Text;
            cmds += $"\n\t25,000$ à 50,000$\t" + txtVingtCinqCinquante.Text;
            cmds += $"\n\t50,000$ à 100,000$ \t" + txtCinquanteCent.Text;
            cmds += $"\n\t100,000$ et +\t" + txtCentPlus.Text;
            cmds += $"\n\tParcel_label_line1\tLes Produits Tourval inc";
            cmds += $"\n\tparcel_label_line\t250, rue du Pacifique Est Bromont, J2L 1J5";
            cmds += $"\n\tparcel_label_line3\tCANADA ";
            cmds += $"\n\tParcelAssist\tChantal Couture #230";
            cmds += $"\n\tParcelEtat\tQuebec";
            cmds += $"\n\tChambre à 1 lit :\t" + txtHebergement1.Text;
            cmds += $"\n\tChambre à 2 lits :\t" + txtHebergement2.Text;
            cmds += $"\n\tRepas pour 1 journée :\t" + txtRepas.Text;
            cmds += $"\n\tVéhicule standard :\t" + txtStandard.Text;
            cmds += $"\n\tUnité mobile :\t" + txtUniteMobile.Text;
            cmds += $"\n\tChemin de la base de données de SEE4000:\t" + txtCheminSEE4000.Text;
            cmds += $"\n\tMachinage :\t" + txtMachinage.Text;
            cmds += $"\n\tCoupe et préparation (sauf soudage) :\t" + txtCoupe.Text;
            cmds += $"\n\tCoupe, soudure et meulage :\t" + txtSoudure.Text;
            cmds += $"\n\tAssemblage des systèmes :\t" + txtAssemblageMec.Text;
            cmds += $"\n\tPeinture et finition :\t" + txtPeinture.Text;
            cmds += $"\n\tTests Finaux :\t" + txtTestMec.Text;
            cmds += $"\n\tConception et dessins :\t" + txtDessinMec.Text;
            cmds += $"\n\tFormation du personnel :\t" + txtFormationMec.Text;
            cmds += $"\n\tInstallation :\t" + txtInstallationMec.Text;
            cmds += $"\n\tGestion  :\t" + txtGestionProjetsMec.Text;
            cmds += $"\n\tShipping :\t" + txtShippingMec.Text;
            cmds += $"\n\tVersion SQL\t" + VersionDB; Clipboard.SetText(cmds);
            e.Graphics.DrawString(cmds, printFont, System.Drawing.Brushes.Black, 0, 0);
            e.Graphics.DrawImage(global::ControleurServeur.Properties.Resources.SQLTime, e.PageSettings.PaperSize.Width - 64, 3);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            PrintDialog printDialog1 = new PrintDialog();
            printDocument1.DefaultPageSettings.Color = false;
            printDocument1.DefaultPageSettings.Landscape = !isLandscape;
            printDialog1.PrinterSettings.Copies = 1;
            printDialog1.Document = printDocument1;
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
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
    }
}