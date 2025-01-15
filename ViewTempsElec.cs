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
    public class ViewTempsElec : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTempsElec));
            lblTitreRapport = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblNoProjet = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            lblTempsDessinEstime = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblTempsDessinReel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblTempsFabricationReel = new System.Windows.Forms.Label();
            lblTempsFabricationEstime = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            lblTempsProgInterfaceReel = new System.Windows.Forms.Label();
            lblTempsProgInterfaceEstime = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            lblTempsAssemblageReel = new System.Windows.Forms.Label();
            lblTempsAssemblageEstime = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            lblTempsProgRobotReel = new System.Windows.Forms.Label();
            lblTempsProgRobotEstime = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            lblTempsProgAutomateReel = new System.Windows.Forms.Label();
            lblTempsProgAutomateEstime = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            lblTempsGestionReel = new System.Windows.Forms.Label();
            lblTempsGestionEstime = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            lblTempsFormationReel = new System.Windows.Forms.Label();
            lblTempsFormationEstime = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            lblTempsMiseServiceReel = new System.Windows.Forms.Label();
            lblTempsMiseServiceEstime = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            label42 = new System.Windows.Forms.Label();
            lblTempsInstallationReel = new System.Windows.Forms.Label();
            lblTempsInstallationEstime = new System.Windows.Forms.Label();
            label45 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            lblTempsTestReel = new System.Windows.Forms.Label();
            lblTempsTestEstime = new System.Windows.Forms.Label();
            label49 = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            lblTempsVisionReel = new System.Windows.Forms.Label();
            lblTempsVisionEstime = new System.Windows.Forms.Label();
            label53 = new System.Windows.Forms.Label();
            label66 = new System.Windows.Forms.Label();
            lblTotalTempsReel = new System.Windows.Forms.Label();
            lblTotalTempsEstime = new System.Windows.Forms.Label();
            label69 = new System.Windows.Forms.Label();
            label70 = new System.Windows.Forms.Label();
            lblTempsprototypeReel = new System.Windows.Forms.Label();
            Label28 = new System.Windows.Forms.Label();
            label73 = new System.Windows.Forms.Label();
            label74 = new System.Windows.Forms.Label();
            lblTempsShippingReel = new System.Windows.Forms.Label();
            lblTempsShippingEstime = new System.Windows.Forms.Label();
            label77 = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblPrintDate = new System.Windows.Forms.ToolStripStatusLabel();
            lblPiedPage = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitreRapport
            // 
            lblTitreRapport.AutoSize = true;
            lblTitreRapport.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreRapport.ForeColor = System.Drawing.Color.Navy;
            lblTitreRapport.Location = new System.Drawing.Point(154, 3);
            lblTitreRapport.Name = "lblTitreRapport";
            lblTitreRapport.Size = new System.Drawing.Size(235, 36);
            lblTitreRapport.TabIndex = 418;
            lblTitreRapport.Tag = "";
            lblTitreRapport.Text = "Temps électriques";
            lblTitreRapport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(641, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(174, 75);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblNoProjet
            // 
            lblNoProjet.BackColor = System.Drawing.Color.White;
            lblNoProjet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoProjet.ForeColor = System.Drawing.Color.Navy;
            lblNoProjet.Location = new System.Drawing.Point(83, 48);
            lblNoProjet.Name = "lblNoProjet";
            lblNoProjet.Size = new System.Drawing.Size(167, 19);
            lblNoProjet.TabIndex = 522;
            lblNoProjet.Text = "lblNoProjet";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.White;
            Label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label12.ForeColor = System.Drawing.Color.Navy;
            Label12.Location = new System.Drawing.Point(14, 48);
            Label12.MinimumSize = new System.Drawing.Size(60, 19);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(60, 19);
            Label12.TabIndex = 533;
            Label12.Text = "Numéro";
            // 
            // lblTempsDessinEstime
            // 
            lblTempsDessinEstime.BackColor = System.Drawing.Color.White;
            lblTempsDessinEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsDessinEstime.Location = new System.Drawing.Point(259, 121);
            lblTempsDessinEstime.Name = "lblTempsDessinEstime";
            lblTempsDessinEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsDessinEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsDessinEstime.TabIndex = 534;
            lblTempsDessinEstime.Text = "lblTempsDessinEstime";
            lblTempsDessinEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(14, 122);
            label3.MinimumSize = new System.Drawing.Size(60, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 19);
            label3.TabIndex = 535;
            label3.Text = "Temps de dessin :";
            // 
            // lblTempsDessinReel
            // 
            lblTempsDessinReel.BackColor = System.Drawing.Color.White;
            lblTempsDessinReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsDessinReel.Location = new System.Drawing.Point(355, 121);
            lblTempsDessinReel.Name = "lblTempsDessinReel";
            lblTempsDessinReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsDessinReel.Size = new System.Drawing.Size(93, 23);
            lblTempsDessinReel.TabIndex = 536;
            lblTempsDessinReel.Text = "lblTempsDessinReel";
            lblTempsDessinReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Navy;
            label5.Location = new System.Drawing.Point(451, 125);
            label5.Margin = new System.Windows.Forms.Padding(0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(25, 15);
            label5.TabIndex = 537;
            label5.Text = "hrs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.Navy;
            label6.Location = new System.Drawing.Point(270, 93);
            label6.MinimumSize = new System.Drawing.Size(60, 19);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 23);
            label6.TabIndex = 538;
            label6.Text = "Éstimés";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Navy;
            label7.Location = new System.Drawing.Point(360, 93);
            label7.MinimumSize = new System.Drawing.Size(60, 19);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(60, 23);
            label7.TabIndex = 539;
            label7.Text = "Réels";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.Navy;
            label8.Location = new System.Drawing.Point(316, 70);
            label8.MinimumSize = new System.Drawing.Size(60, 19);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(60, 23);
            label8.TabIndex = 540;
            label8.Text = "Temps";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.White;
            label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.Navy;
            label9.Location = new System.Drawing.Point(451, 149);
            label9.Margin = new System.Windows.Forms.Padding(0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(25, 15);
            label9.TabIndex = 544;
            label9.Text = "hrs";
            // 
            // lblTempsFabricationReel
            // 
            lblTempsFabricationReel.BackColor = System.Drawing.Color.White;
            lblTempsFabricationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFabricationReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFabricationReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsFabricationReel.Location = new System.Drawing.Point(355, 145);
            lblTempsFabricationReel.Name = "lblTempsFabricationReel";
            lblTempsFabricationReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsFabricationReel.Size = new System.Drawing.Size(93, 23);
            lblTempsFabricationReel.TabIndex = 543;
            lblTempsFabricationReel.Text = "lblTempsFabricationReel";
            lblTempsFabricationReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsFabricationEstime
            // 
            lblTempsFabricationEstime.BackColor = System.Drawing.Color.White;
            lblTempsFabricationEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFabricationEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFabricationEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsFabricationEstime.Location = new System.Drawing.Point(259, 145);
            lblTempsFabricationEstime.Name = "lblTempsFabricationEstime";
            lblTempsFabricationEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsFabricationEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsFabricationEstime.TabIndex = 541;
            lblTempsFabricationEstime.Text = "lblTempsFabricationEstime";
            lblTempsFabricationEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.White;
            label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.ForeColor = System.Drawing.Color.Navy;
            label13.Location = new System.Drawing.Point(14, 146);
            label13.MinimumSize = new System.Drawing.Size(60, 19);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(127, 19);
            label13.TabIndex = 542;
            label13.Text = "Temps de fabrication :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.White;
            label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.ForeColor = System.Drawing.Color.Navy;
            label14.Location = new System.Drawing.Point(451, 197);
            label14.Margin = new System.Windows.Forms.Padding(0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(25, 15);
            label14.TabIndex = 552;
            label14.Text = "hrs";
            // 
            // lblTempsProgInterfaceReel
            // 
            lblTempsProgInterfaceReel.BackColor = System.Drawing.Color.White;
            lblTempsProgInterfaceReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgInterfaceReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgInterfaceReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsProgInterfaceReel.Location = new System.Drawing.Point(355, 193);
            lblTempsProgInterfaceReel.Name = "lblTempsProgInterfaceReel";
            lblTempsProgInterfaceReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsProgInterfaceReel.Size = new System.Drawing.Size(93, 23);
            lblTempsProgInterfaceReel.TabIndex = 551;
            lblTempsProgInterfaceReel.Text = "lblTempsProgInterfaceReel";
            lblTempsProgInterfaceReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsProgInterfaceEstime
            // 
            lblTempsProgInterfaceEstime.BackColor = System.Drawing.Color.White;
            lblTempsProgInterfaceEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgInterfaceEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgInterfaceEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsProgInterfaceEstime.Location = new System.Drawing.Point(259, 193);
            lblTempsProgInterfaceEstime.Name = "lblTempsProgInterfaceEstime";
            lblTempsProgInterfaceEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsProgInterfaceEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsProgInterfaceEstime.TabIndex = 549;
            lblTempsProgInterfaceEstime.Text = "lblTempsProgInterfaceEstime";
            lblTempsProgInterfaceEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.White;
            label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.ForeColor = System.Drawing.Color.Navy;
            label17.Location = new System.Drawing.Point(14, 194);
            label17.MinimumSize = new System.Drawing.Size(60, 19);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(213, 19);
            label17.TabIndex = 550;
            label17.Text = "Temps de programmation d\'interface :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = System.Drawing.Color.White;
            label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.ForeColor = System.Drawing.Color.Navy;
            label18.Location = new System.Drawing.Point(451, 173);
            label18.Margin = new System.Windows.Forms.Padding(0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(25, 15);
            label18.TabIndex = 548;
            label18.Text = "hrs";
            // 
            // lblTempsAssemblageReel
            // 
            lblTempsAssemblageReel.BackColor = System.Drawing.Color.White;
            lblTempsAssemblageReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsAssemblageReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsAssemblageReel.Location = new System.Drawing.Point(355, 169);
            lblTempsAssemblageReel.Name = "lblTempsAssemblageReel";
            lblTempsAssemblageReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsAssemblageReel.Size = new System.Drawing.Size(93, 23);
            lblTempsAssemblageReel.TabIndex = 547;
            lblTempsAssemblageReel.Text = "lblTempsAssemblageReel";
            lblTempsAssemblageReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsAssemblageEstime
            // 
            lblTempsAssemblageEstime.BackColor = System.Drawing.Color.White;
            lblTempsAssemblageEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsAssemblageEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsAssemblageEstime.Location = new System.Drawing.Point(259, 169);
            lblTempsAssemblageEstime.Name = "lblTempsAssemblageEstime";
            lblTempsAssemblageEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsAssemblageEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsAssemblageEstime.TabIndex = 545;
            lblTempsAssemblageEstime.Text = "lblTempsAssemblageEstime";
            lblTempsAssemblageEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = System.Drawing.Color.White;
            label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.ForeColor = System.Drawing.Color.Navy;
            label21.Location = new System.Drawing.Point(14, 170);
            label21.MinimumSize = new System.Drawing.Size(60, 19);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(125, 19);
            label21.TabIndex = 546;
            label21.Text = "Temps d\'assemblage :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = System.Drawing.Color.White;
            label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.ForeColor = System.Drawing.Color.Navy;
            label22.Location = new System.Drawing.Point(451, 246);
            label22.Margin = new System.Windows.Forms.Padding(0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(25, 15);
            label22.TabIndex = 560;
            label22.Text = "hrs";
            // 
            // lblTempsProgRobotReel
            // 
            lblTempsProgRobotReel.BackColor = System.Drawing.Color.White;
            lblTempsProgRobotReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgRobotReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgRobotReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsProgRobotReel.Location = new System.Drawing.Point(355, 242);
            lblTempsProgRobotReel.Name = "lblTempsProgRobotReel";
            lblTempsProgRobotReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsProgRobotReel.Size = new System.Drawing.Size(93, 23);
            lblTempsProgRobotReel.TabIndex = 559;
            lblTempsProgRobotReel.Text = "lblTempsProgRobotReel";
            lblTempsProgRobotReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsProgRobotEstime
            // 
            lblTempsProgRobotEstime.BackColor = System.Drawing.Color.White;
            lblTempsProgRobotEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgRobotEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgRobotEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsProgRobotEstime.Location = new System.Drawing.Point(259, 242);
            lblTempsProgRobotEstime.Name = "lblTempsProgRobotEstime";
            lblTempsProgRobotEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsProgRobotEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsProgRobotEstime.TabIndex = 557;
            lblTempsProgRobotEstime.Text = "lblTempsProgRobotEstime";
            lblTempsProgRobotEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = System.Drawing.Color.White;
            label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.ForeColor = System.Drawing.Color.Navy;
            label25.Location = new System.Drawing.Point(14, 243);
            label25.MinimumSize = new System.Drawing.Size(60, 19);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(200, 19);
            label25.TabIndex = 558;
            label25.Text = "Temps de programmation de robot :";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.White;
            label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.ForeColor = System.Drawing.Color.Navy;
            label26.Location = new System.Drawing.Point(451, 222);
            label26.Margin = new System.Windows.Forms.Padding(0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(25, 15);
            label26.TabIndex = 556;
            label26.Text = "hrs";
            // 
            // lblTempsProgAutomateReel
            // 
            lblTempsProgAutomateReel.BackColor = System.Drawing.Color.White;
            lblTempsProgAutomateReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgAutomateReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgAutomateReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsProgAutomateReel.Location = new System.Drawing.Point(355, 218);
            lblTempsProgAutomateReel.Name = "lblTempsProgAutomateReel";
            lblTempsProgAutomateReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsProgAutomateReel.Size = new System.Drawing.Size(93, 23);
            lblTempsProgAutomateReel.TabIndex = 555;
            lblTempsProgAutomateReel.Text = "lblTempsProgAutomateReel";
            lblTempsProgAutomateReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsProgAutomateEstime
            // 
            lblTempsProgAutomateEstime.BackColor = System.Drawing.Color.White;
            lblTempsProgAutomateEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsProgAutomateEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProgAutomateEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsProgAutomateEstime.Location = new System.Drawing.Point(259, 218);
            lblTempsProgAutomateEstime.Name = "lblTempsProgAutomateEstime";
            lblTempsProgAutomateEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsProgAutomateEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsProgAutomateEstime.TabIndex = 553;
            lblTempsProgAutomateEstime.Text = "lblTempsProgAutomateEstime";
            lblTempsProgAutomateEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = System.Drawing.Color.White;
            label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.ForeColor = System.Drawing.Color.Navy;
            label29.Location = new System.Drawing.Point(14, 219);
            label29.MinimumSize = new System.Drawing.Size(60, 19);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(216, 19);
            label29.TabIndex = 554;
            label29.Text = "Temps de programmation d\'automate :";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = System.Drawing.Color.White;
            label30.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.ForeColor = System.Drawing.Color.Navy;
            label30.Location = new System.Drawing.Point(451, 392);
            label30.Margin = new System.Windows.Forms.Padding(0);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(25, 15);
            label30.TabIndex = 584;
            label30.Text = "hrs";
            // 
            // lblTempsGestionReel
            // 
            lblTempsGestionReel.BackColor = System.Drawing.Color.White;
            lblTempsGestionReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsGestionReel.Location = new System.Drawing.Point(355, 388);
            lblTempsGestionReel.Name = "lblTempsGestionReel";
            lblTempsGestionReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsGestionReel.Size = new System.Drawing.Size(93, 23);
            lblTempsGestionReel.TabIndex = 583;
            lblTempsGestionReel.Text = "lblTempsGestionReel";
            lblTempsGestionReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsGestionEstime
            // 
            lblTempsGestionEstime.BackColor = System.Drawing.Color.White;
            lblTempsGestionEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsGestionEstime.Location = new System.Drawing.Point(259, 388);
            lblTempsGestionEstime.Name = "lblTempsGestionEstime";
            lblTempsGestionEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsGestionEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsGestionEstime.TabIndex = 581;
            lblTempsGestionEstime.Text = "lblTempsGestionEstime";
            lblTempsGestionEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = System.Drawing.Color.White;
            label33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.ForeColor = System.Drawing.Color.Navy;
            label33.Location = new System.Drawing.Point(14, 389);
            label33.MinimumSize = new System.Drawing.Size(60, 19);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(157, 19);
            label33.TabIndex = 582;
            label33.Text = "Temps de gestion de projet :";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = System.Drawing.Color.White;
            label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.ForeColor = System.Drawing.Color.Navy;
            label34.Location = new System.Drawing.Point(451, 368);
            label34.Margin = new System.Windows.Forms.Padding(0);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(25, 15);
            label34.TabIndex = 580;
            label34.Text = "hrs";
            // 
            // lblTempsFormationReel
            // 
            lblTempsFormationReel.BackColor = System.Drawing.Color.White;
            lblTempsFormationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsFormationReel.Location = new System.Drawing.Point(355, 364);
            lblTempsFormationReel.Name = "lblTempsFormationReel";
            lblTempsFormationReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsFormationReel.Size = new System.Drawing.Size(93, 23);
            lblTempsFormationReel.TabIndex = 579;
            lblTempsFormationReel.Text = "lblTempsFormationReel";
            lblTempsFormationReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsFormationEstime
            // 
            lblTempsFormationEstime.BackColor = System.Drawing.Color.White;
            lblTempsFormationEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsFormationEstime.Location = new System.Drawing.Point(259, 364);
            lblTempsFormationEstime.Name = "lblTempsFormationEstime";
            lblTempsFormationEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsFormationEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsFormationEstime.TabIndex = 577;
            lblTempsFormationEstime.Text = "lblTempsFormationEstime";
            lblTempsFormationEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = System.Drawing.Color.White;
            label37.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.ForeColor = System.Drawing.Color.Navy;
            label37.Location = new System.Drawing.Point(14, 365);
            label37.MinimumSize = new System.Drawing.Size(60, 19);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(195, 19);
            label37.TabIndex = 578;
            label37.Text = "Temps de formation du personnel :";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = System.Drawing.Color.White;
            label38.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.ForeColor = System.Drawing.Color.Navy;
            label38.Location = new System.Drawing.Point(451, 343);
            label38.Margin = new System.Windows.Forms.Padding(0);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(25, 15);
            label38.TabIndex = 576;
            label38.Text = "hrs";
            // 
            // lblTempsMiseServiceReel
            // 
            lblTempsMiseServiceReel.BackColor = System.Drawing.Color.White;
            lblTempsMiseServiceReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMiseServiceReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMiseServiceReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsMiseServiceReel.Location = new System.Drawing.Point(355, 339);
            lblTempsMiseServiceReel.Name = "lblTempsMiseServiceReel";
            lblTempsMiseServiceReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsMiseServiceReel.Size = new System.Drawing.Size(93, 23);
            lblTempsMiseServiceReel.TabIndex = 575;
            lblTempsMiseServiceReel.Text = "lblTempsMiseServiceReel";
            lblTempsMiseServiceReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsMiseServiceEstime
            // 
            lblTempsMiseServiceEstime.BackColor = System.Drawing.Color.White;
            lblTempsMiseServiceEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMiseServiceEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMiseServiceEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsMiseServiceEstime.Location = new System.Drawing.Point(259, 339);
            lblTempsMiseServiceEstime.Name = "lblTempsMiseServiceEstime";
            lblTempsMiseServiceEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsMiseServiceEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsMiseServiceEstime.TabIndex = 573;
            lblTempsMiseServiceEstime.Text = "lblTempsMiseServiceEstime";
            lblTempsMiseServiceEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BackColor = System.Drawing.Color.White;
            label41.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.ForeColor = System.Drawing.Color.Navy;
            label41.Location = new System.Drawing.Point(14, 340);
            label41.MinimumSize = new System.Drawing.Size(60, 19);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(150, 19);
            label41.TabIndex = 574;
            label41.Text = "Temps de mise en service :";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = System.Drawing.Color.White;
            label42.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.ForeColor = System.Drawing.Color.Navy;
            label42.Location = new System.Drawing.Point(451, 319);
            label42.Margin = new System.Windows.Forms.Padding(0);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(25, 15);
            label42.TabIndex = 572;
            label42.Text = "hrs";
            // 
            // lblTempsInstallationReel
            // 
            lblTempsInstallationReel.BackColor = System.Drawing.Color.White;
            lblTempsInstallationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsInstallationReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsInstallationReel.Location = new System.Drawing.Point(355, 315);
            lblTempsInstallationReel.Name = "lblTempsInstallationReel";
            lblTempsInstallationReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsInstallationReel.Size = new System.Drawing.Size(93, 23);
            lblTempsInstallationReel.TabIndex = 571;
            lblTempsInstallationReel.Text = "lblTempsInstallationReel";
            lblTempsInstallationReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsInstallationEstime
            // 
            lblTempsInstallationEstime.BackColor = System.Drawing.Color.White;
            lblTempsInstallationEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsInstallationEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsInstallationEstime.Location = new System.Drawing.Point(259, 315);
            lblTempsInstallationEstime.Name = "lblTempsInstallationEstime";
            lblTempsInstallationEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsInstallationEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsInstallationEstime.TabIndex = 569;
            lblTempsInstallationEstime.Text = "lblTempsInstallationEstime";
            lblTempsInstallationEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.BackColor = System.Drawing.Color.White;
            label45.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.ForeColor = System.Drawing.Color.Navy;
            label45.Location = new System.Drawing.Point(14, 316);
            label45.MinimumSize = new System.Drawing.Size(60, 19);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(124, 19);
            label45.TabIndex = 570;
            label45.Text = "Temps d\'installation :";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = System.Drawing.Color.White;
            label46.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.ForeColor = System.Drawing.Color.Navy;
            label46.Location = new System.Drawing.Point(451, 295);
            label46.Margin = new System.Windows.Forms.Padding(0);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(25, 15);
            label46.TabIndex = 568;
            label46.Text = "hrs";
            // 
            // lblTempsTestReel
            // 
            lblTempsTestReel.BackColor = System.Drawing.Color.White;
            lblTempsTestReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsTestReel.Location = new System.Drawing.Point(355, 291);
            lblTempsTestReel.Name = "lblTempsTestReel";
            lblTempsTestReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsTestReel.Size = new System.Drawing.Size(93, 23);
            lblTempsTestReel.TabIndex = 567;
            lblTempsTestReel.Text = "lblTempsTestReel";
            lblTempsTestReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsTestEstime
            // 
            lblTempsTestEstime.BackColor = System.Drawing.Color.White;
            lblTempsTestEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsTestEstime.Location = new System.Drawing.Point(259, 291);
            lblTempsTestEstime.Name = "lblTempsTestEstime";
            lblTempsTestEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsTestEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsTestEstime.TabIndex = 565;
            lblTempsTestEstime.Text = "lblTempsTestEstime";
            lblTempsTestEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.BackColor = System.Drawing.Color.White;
            label49.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label49.ForeColor = System.Drawing.Color.Navy;
            label49.Location = new System.Drawing.Point(14, 292);
            label49.MinimumSize = new System.Drawing.Size(60, 19);
            label49.Name = "label49";
            label49.Size = new System.Drawing.Size(86, 19);
            label49.TabIndex = 566;
            label49.Text = "Temps de test :";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.BackColor = System.Drawing.Color.White;
            label50.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.ForeColor = System.Drawing.Color.Navy;
            label50.Location = new System.Drawing.Point(451, 271);
            label50.Margin = new System.Windows.Forms.Padding(0);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(25, 15);
            label50.TabIndex = 564;
            label50.Text = "hrs";
            // 
            // lblTempsVisionReel
            // 
            lblTempsVisionReel.BackColor = System.Drawing.Color.White;
            lblTempsVisionReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsVisionReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsVisionReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsVisionReel.Location = new System.Drawing.Point(355, 267);
            lblTempsVisionReel.Name = "lblTempsVisionReel";
            lblTempsVisionReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsVisionReel.Size = new System.Drawing.Size(93, 23);
            lblTempsVisionReel.TabIndex = 563;
            lblTempsVisionReel.Text = "lblTempsVisionReel";
            lblTempsVisionReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsVisionEstime
            // 
            lblTempsVisionEstime.BackColor = System.Drawing.Color.White;
            lblTempsVisionEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsVisionEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsVisionEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsVisionEstime.Location = new System.Drawing.Point(259, 267);
            lblTempsVisionEstime.Name = "lblTempsVisionEstime";
            lblTempsVisionEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsVisionEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsVisionEstime.TabIndex = 561;
            lblTempsVisionEstime.Text = "lblTempsVisionEstime";
            lblTempsVisionEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.BackColor = System.Drawing.Color.White;
            label53.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label53.ForeColor = System.Drawing.Color.Navy;
            label53.Location = new System.Drawing.Point(14, 268);
            label53.MinimumSize = new System.Drawing.Size(60, 19);
            label53.Name = "label53";
            label53.Size = new System.Drawing.Size(100, 19);
            label53.TabIndex = 562;
            label53.Text = "Temps de vision :";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.BackColor = System.Drawing.Color.White;
            label66.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label66.ForeColor = System.Drawing.Color.Navy;
            label66.Location = new System.Drawing.Point(451, 468);
            label66.Margin = new System.Windows.Forms.Padding(0);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(25, 15);
            label66.TabIndex = 596;
            label66.Text = "hrs";
            // 
            // lblTotalTempsReel
            // 
            lblTotalTempsReel.BackColor = System.Drawing.Color.White;
            lblTotalTempsReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsReel.ForeColor = System.Drawing.Color.Navy;
            lblTotalTempsReel.Location = new System.Drawing.Point(355, 464);
            lblTotalTempsReel.Name = "lblTotalTempsReel";
            lblTotalTempsReel.Padding = new System.Windows.Forms.Padding(3);
            lblTotalTempsReel.Size = new System.Drawing.Size(93, 23);
            lblTotalTempsReel.TabIndex = 595;
            lblTotalTempsReel.Text = "lblTotalTempsReel";
            lblTotalTempsReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTempsEstime
            // 
            lblTotalTempsEstime.BackColor = System.Drawing.Color.White;
            lblTotalTempsEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsEstime.ForeColor = System.Drawing.Color.Navy;
            lblTotalTempsEstime.Location = new System.Drawing.Point(259, 464);
            lblTotalTempsEstime.Name = "lblTotalTempsEstime";
            lblTotalTempsEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTotalTempsEstime.Size = new System.Drawing.Size(93, 23);
            lblTotalTempsEstime.TabIndex = 593;
            lblTotalTempsEstime.Text = "lblTotalTempsEstime";
            lblTotalTempsEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.BackColor = System.Drawing.Color.White;
            label69.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label69.ForeColor = System.Drawing.Color.Navy;
            label69.Location = new System.Drawing.Point(14, 465);
            label69.MinimumSize = new System.Drawing.Size(60, 19);
            label69.Name = "label69";
            label69.Size = new System.Drawing.Size(60, 19);
            label69.TabIndex = 594;
            label69.Text = "Total";
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.BackColor = System.Drawing.Color.White;
            label70.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label70.ForeColor = System.Drawing.Color.Navy;
            label70.Location = new System.Drawing.Point(451, 440);
            label70.Margin = new System.Windows.Forms.Padding(0);
            label70.Name = "label70";
            label70.Size = new System.Drawing.Size(25, 15);
            label70.TabIndex = 592;
            label70.Text = "hrs";
            // 
            // lblTempsprototypeReel
            // 
            lblTempsprototypeReel.BackColor = System.Drawing.Color.White;
            lblTempsprototypeReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsprototypeReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsprototypeReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsprototypeReel.Location = new System.Drawing.Point(355, 436);
            lblTempsprototypeReel.Name = "lblTempsprototypeReel";
            lblTempsprototypeReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsprototypeReel.Size = new System.Drawing.Size(93, 23);
            lblTempsprototypeReel.TabIndex = 591;
            lblTempsprototypeReel.Text = "lblTempsprototypeReel";
            lblTempsprototypeReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label28
            // 
            Label28.BackColor = System.Drawing.Color.White;
            Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Label28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label28.ForeColor = System.Drawing.Color.Navy;
            Label28.Location = new System.Drawing.Point(259, 436);
            Label28.Name = "Label28";
            Label28.Padding = new System.Windows.Forms.Padding(3);
            Label28.Size = new System.Drawing.Size(93, 23);
            Label28.TabIndex = 589;
            Label28.Text = "Label28";
            Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            label73.AutoSize = true;
            label73.BackColor = System.Drawing.Color.White;
            label73.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label73.ForeColor = System.Drawing.Color.Navy;
            label73.Location = new System.Drawing.Point(14, 437);
            label73.MinimumSize = new System.Drawing.Size(60, 19);
            label73.Name = "label73";
            label73.Size = new System.Drawing.Size(76, 19);
            label73.TabIndex = 590;
            label73.Text = "Prototypage:";
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.BackColor = System.Drawing.Color.White;
            label74.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label74.ForeColor = System.Drawing.Color.Navy;
            label74.Location = new System.Drawing.Point(451, 416);
            label74.Margin = new System.Windows.Forms.Padding(0);
            label74.Name = "label74";
            label74.Size = new System.Drawing.Size(25, 15);
            label74.TabIndex = 588;
            label74.Text = "hrs";
            // 
            // lblTempsShippingReel
            // 
            lblTempsShippingReel.BackColor = System.Drawing.Color.White;
            lblTempsShippingReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingReel.ForeColor = System.Drawing.Color.Navy;
            lblTempsShippingReel.Location = new System.Drawing.Point(355, 412);
            lblTempsShippingReel.Name = "lblTempsShippingReel";
            lblTempsShippingReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsShippingReel.Size = new System.Drawing.Size(93, 23);
            lblTempsShippingReel.TabIndex = 587;
            lblTempsShippingReel.Text = "lblTempsShippingReel";
            lblTempsShippingReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsShippingEstime
            // 
            lblTempsShippingEstime.BackColor = System.Drawing.Color.White;
            lblTempsShippingEstime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingEstime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingEstime.ForeColor = System.Drawing.Color.Navy;
            lblTempsShippingEstime.Location = new System.Drawing.Point(259, 412);
            lblTempsShippingEstime.Name = "lblTempsShippingEstime";
            lblTempsShippingEstime.Padding = new System.Windows.Forms.Padding(3);
            lblTempsShippingEstime.Size = new System.Drawing.Size(93, 23);
            lblTempsShippingEstime.TabIndex = 585;
            lblTempsShippingEstime.Text = "lblTempsShippingEstime";
            lblTempsShippingEstime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            label77.AutoSize = true;
            label77.BackColor = System.Drawing.Color.White;
            label77.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label77.ForeColor = System.Drawing.Color.Navy;
            label77.Location = new System.Drawing.Point(14, 413);
            label77.MinimumSize = new System.Drawing.Size(60, 19);
            label77.Name = "label77";
            label77.Size = new System.Drawing.Size(117, 19);
            label77.TabIndex = 586;
            label77.Text = "Temps d\'expédition :";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});
            listView1.ForeColor = System.Drawing.Color.Navy;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(17, 498);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(772, 440);
            listView1.TabIndex = 597;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nom de l\'employé";
            columnHeader1.Width = 269;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Type";
            columnHeader2.Width = 264;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Heures";
            columnHeader3.Width = 79;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblPrintDate,
            lblPiedPage});
            statusStrip1.Location = new System.Drawing.Point(0, 1039);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(818, 22);
            statusStrip1.TabIndex = 598;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblPrintDate
            // 
            lblPrintDate.Name = "lblPrintDate";
            lblPrintDate.Size = new System.Drawing.Size(734, 17);
            lblPrintDate.Spring = true;
            lblPrintDate.Text = "lblPrintDate";
            lblPrintDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPiedPage
            // 
            lblPiedPage.Name = "lblPiedPage";
            lblPiedPage.Size = new System.Drawing.Size(69, 17);
            lblPiedPage.Text = "lblPiedPage";
            // 
            // ViewTempsElec
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(label66);
            Controls.Add(lblTotalTempsReel);
            Controls.Add(lblTotalTempsEstime);
            Controls.Add(label69);
            Controls.Add(label70);
            Controls.Add(lblTempsprototypeReel);
            Controls.Add(Label28);
            Controls.Add(label73);
            Controls.Add(label74);
            Controls.Add(lblTempsShippingReel);
            Controls.Add(lblTempsShippingEstime);
            Controls.Add(label77);
            Controls.Add(label30);
            Controls.Add(lblTempsGestionReel);
            Controls.Add(lblTempsGestionEstime);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(lblTempsFormationReel);
            Controls.Add(lblTempsFormationEstime);
            Controls.Add(label37);
            Controls.Add(label38);
            Controls.Add(lblTempsMiseServiceReel);
            Controls.Add(lblTempsMiseServiceEstime);
            Controls.Add(label41);
            Controls.Add(label42);
            Controls.Add(lblTempsInstallationReel);
            Controls.Add(lblTempsInstallationEstime);
            Controls.Add(label45);
            Controls.Add(label46);
            Controls.Add(lblTempsTestReel);
            Controls.Add(lblTempsTestEstime);
            Controls.Add(label49);
            Controls.Add(label50);
            Controls.Add(lblTempsVisionReel);
            Controls.Add(lblTempsVisionEstime);
            Controls.Add(label53);
            Controls.Add(label22);
            Controls.Add(lblTempsProgRobotReel);
            Controls.Add(lblTempsProgRobotEstime);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(lblTempsProgAutomateReel);
            Controls.Add(lblTempsProgAutomateEstime);
            Controls.Add(label29);
            Controls.Add(label14);
            Controls.Add(lblTempsProgInterfaceReel);
            Controls.Add(lblTempsProgInterfaceEstime);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(lblTempsAssemblageReel);
            Controls.Add(lblTempsAssemblageEstime);
            Controls.Add(label21);
            Controls.Add(label9);
            Controls.Add(lblTempsFabricationReel);
            Controls.Add(lblTempsFabricationEstime);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblTempsDessinReel);
            Controls.Add(lblTempsDessinEstime);
            Controls.Add(label3);
            Controls.Add(lblNoProjet);
            Controls.Add(Label12);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitreRapport);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewTempsElec";
            ShowInTaskbar = false;
            Text = "ContrôleurWebAutoGRB.ViewTempsElec";
            Load += new System.EventHandler(ViewBonTravail_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label lblTitreRapport;
        internal static Label lblNoProjet;
        internal static Label lblTempsDessinEstime;
        internal static Label label3;
        internal static Label lblTempsDessinReel;
        internal static Label label5;
        internal static Label label6;
        internal static Label label7;
        internal static Label label8;
        internal static Label label9;
        internal static Label lblTempsFabricationReel;
        internal static Label lblTempsFabricationEstime;
        internal static Label label13;
        internal static Label label14;
        internal static Label lblTempsProgInterfaceReel;
        internal static Label lblTempsProgInterfaceEstime;
        internal static Label label17;
        internal static Label label18;
        internal static Label lblTempsAssemblageReel;
        internal static Label lblTempsAssemblageEstime;
        internal static Label label21;
        internal static Label label22;
        internal static Label lblTempsProgRobotReel;
        internal static Label lblTempsProgRobotEstime;
        internal static Label label25;
        internal static Label label26;
        internal static Label lblTempsProgAutomateReel;
        internal static Label lblTempsProgAutomateEstime;
        internal static Label label29;
        internal static Label label30;
        internal static Label lblTempsGestionReel;
        internal static Label lblTempsGestionEstime;
        internal static Label label33;
        internal static Label label34;
        internal static Label lblTempsFormationReel;
        internal static Label lblTempsFormationEstime;
        internal static Label label37;
        internal static Label label38;
        internal static Label lblTempsMiseServiceReel;
        internal static Label lblTempsMiseServiceEstime;
        internal static Label label41;
        internal static Label label42;
        internal static Label lblTempsInstallationReel;
        internal static Label lblTempsInstallationEstime;
        internal static Label label45;
        internal static Label label46;
        internal static Label lblTempsTestReel;
        internal static Label lblTempsTestEstime;
        internal static Label label49;
        internal static Label label50;
        internal static Label lblTempsVisionReel;
        internal static Label lblTempsVisionEstime;
        internal static Label label53;
        internal static Label label66;
        internal static Label lblTotalTempsReel;
        internal static Label lblTotalTempsEstime;
        internal static Label label69;
        internal static Label label70;
        internal static Label lblTempsprototypeReel;
        internal static Label Label28;
        internal static Label label73;
        internal static Label label74;
        internal static Label lblTempsShippingReel;
        internal static Label lblTempsShippingEstime;
        internal static Label label77;
        internal static ListView listView1;
        internal static ColumnHeader columnHeader1;
        internal static ColumnHeader columnHeader2;
        internal static ColumnHeader columnHeader3;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel lblPrintDate;
        internal static ToolStripStatusLabel lblPiedPage;
        internal static Label Label12;

        public ViewTempsElec()
        {
            InitializeComponent();
        }
        private void ViewBonTravail_Load(object sender, EventArgs e)
        {
            lblPrintDate.Text = DateTime.Now.ToString();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        internal static ADODB.Recordset DataSource;
        Bitmap memoryImage;
        internal static bool Orientation;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.DefaultPageSettings.Color = false;
            printDocument1.DefaultPageSettings.Landscape = !Program.isLandscape; //pour le mode paysage
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.PrinterSettings.Copies = 1;
            printDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(ImpressionFormulaire);
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
            memoryImage.Save($"{Name}_{Program.Now2String()}.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
