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
    public class ViewTempsMec : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTempsMec));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblPrintDate = new System.Windows.Forms.ToolStripStatusLabel();
            lblPiedPage = new System.Windows.Forms.ToolStripStatusLabel();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label66 = new System.Windows.Forms.Label();
            lblTotalTempsProj = new System.Windows.Forms.Label();
            lblTotalTempsSoum = new System.Windows.Forms.Label();
            label69 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            lblTempsShippingProj = new System.Windows.Forms.Label();
            lblTempsShippingSoum = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            lblTempsGestionProj = new System.Windows.Forms.Label();
            lblTempsGestionSoum = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            label42 = new System.Windows.Forms.Label();
            lblTempsFormationProj = new System.Windows.Forms.Label();
            lblTempsFormationSoum = new System.Windows.Forms.Label();
            label45 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            lblTempsInstallationProj = new System.Windows.Forms.Label();
            lblTempsInstallationSoum = new System.Windows.Forms.Label();
            label49 = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            lblTempsTestProj = new System.Windows.Forms.Label();
            lblTempsTestSoum = new System.Windows.Forms.Label();
            label53 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            lblTempsPeintureProj = new System.Windows.Forms.Label();
            lblTempsPeintureSoum = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            lblTempsAssemblageProj = new System.Windows.Forms.Label();
            lblTempsAssemblageSoum = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            lblTempsSoudureProj = new System.Windows.Forms.Label();
            lblTempsSoudureSoum = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            lblTempsMachinageProj = new System.Windows.Forms.Label();
            lblTempsMachinageSoum = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblTempsCoupeProj = new System.Windows.Forms.Label();
            lblTempsCoupeSoum = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblTempsProj = new System.Windows.Forms.Label();
            lblTempsSoum = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblTempsDessinProj = new System.Windows.Forms.Label();
            lblTempsDessinSoum = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblNoProjet = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTitreRapport = new System.Windows.Forms.Label();
            lblTotalTempsReel = new System.Windows.Forms.Label();
            lblTotalTempsConc = new System.Windows.Forms.Label();
            lblTempsPrototypeReel = new System.Windows.Forms.Label();
            lblTempsShippingReel = new System.Windows.Forms.Label();
            lblTempsShippingConc = new System.Windows.Forms.Label();
            lblTempsGestionReel = new System.Windows.Forms.Label();
            lblTempsGestionConc = new System.Windows.Forms.Label();
            lblTempsFormationReel = new System.Windows.Forms.Label();
            lblTempsFormationConc = new System.Windows.Forms.Label();
            lblTempsInstallationReel = new System.Windows.Forms.Label();
            lblTempsInstallationConc = new System.Windows.Forms.Label();
            lblTempsTestReel = new System.Windows.Forms.Label();
            lblTempsTestConc = new System.Windows.Forms.Label();
            lblTempsPeintureReel = new System.Windows.Forms.Label();
            lblTempsPeintureConc = new System.Windows.Forms.Label();
            lblTempsAssemblageReel = new System.Windows.Forms.Label();
            lblTempsAssemblageConc = new System.Windows.Forms.Label();
            lblTempsSoudureReel = new System.Windows.Forms.Label();
            lblTempsSoudureConc = new System.Windows.Forms.Label();
            lblTempsMachinageReel = new System.Windows.Forms.Label();
            lblTempsMachinageConc = new System.Windows.Forms.Label();
            lblTempsCoupeReel = new System.Windows.Forms.Label();
            lblTempsCoupeConc = new System.Windows.Forms.Label();
            label59 = new System.Windows.Forms.Label();
            lblTempsConc = new System.Windows.Forms.Label();
            lblTempsDessinReel = new System.Windows.Forms.Label();
            lblTempsDessinConc = new System.Windows.Forms.Label();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblPrintDate,
            lblPiedPage});
            statusStrip1.Location = new System.Drawing.Point(0, 1039);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(818, 22);
            statusStrip1.TabIndex = 667;
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
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(30, 455);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(776, 638);
            listView1.TabIndex = 666;
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
            // label66
            // 
            label66.AutoSize = true;
            label66.BackColor = System.Drawing.Color.White;
            label66.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label66.Location = new System.Drawing.Point(643, 422);
            label66.Margin = new System.Windows.Forms.Padding(0);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(25, 15);
            label66.TabIndex = 665;
            label66.Text = "hrs";
            // 
            // lblTotalTempsProj
            // 
            lblTotalTempsProj.BackColor = System.Drawing.Color.White;
            lblTotalTempsProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsProj.Location = new System.Drawing.Point(355, 418);
            lblTotalTempsProj.Name = "lblTotalTempsProj";
            lblTotalTempsProj.Padding = new System.Windows.Forms.Padding(3);
            lblTotalTempsProj.Size = new System.Drawing.Size(93, 23);
            lblTotalTempsProj.TabIndex = 664;
            lblTotalTempsProj.Text = "lblTotalTempsProj";
            lblTotalTempsProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTempsSoum
            // 
            lblTotalTempsSoum.BackColor = System.Drawing.Color.White;
            lblTotalTempsSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsSoum.Location = new System.Drawing.Point(259, 418);
            lblTotalTempsSoum.Name = "lblTotalTempsSoum";
            lblTotalTempsSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTotalTempsSoum.Size = new System.Drawing.Size(93, 23);
            lblTotalTempsSoum.TabIndex = 662;
            lblTotalTempsSoum.Text = "lblTotalTempsSoum";
            lblTotalTempsSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.BackColor = System.Drawing.Color.White;
            label69.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label69.Location = new System.Drawing.Point(14, 419);
            label69.MinimumSize = new System.Drawing.Size(60, 19);
            label69.Name = "label69";
            label69.Size = new System.Drawing.Size(60, 19);
            label69.TabIndex = 663;
            label69.Text = "Total";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = System.Drawing.Color.White;
            label30.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.Location = new System.Drawing.Point(643, 391);
            label30.Margin = new System.Windows.Forms.Padding(0);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(25, 15);
            label30.TabIndex = 653;
            label30.Text = "hrs";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = System.Drawing.Color.White;
            label33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.Location = new System.Drawing.Point(14, 388);
            label33.MinimumSize = new System.Drawing.Size(60, 19);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(160, 19);
            label33.TabIndex = 651;
            label33.Text = "Prototypage Développement";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = System.Drawing.Color.White;
            label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(643, 367);
            label34.Margin = new System.Windows.Forms.Padding(0);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(25, 15);
            label34.TabIndex = 649;
            label34.Text = "hrs";
            // 
            // lblTempsShippingProj
            // 
            lblTempsShippingProj.BackColor = System.Drawing.Color.White;
            lblTempsShippingProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingProj.Location = new System.Drawing.Point(355, 363);
            lblTempsShippingProj.Name = "lblTempsShippingProj";
            lblTempsShippingProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsShippingProj.Size = new System.Drawing.Size(93, 23);
            lblTempsShippingProj.TabIndex = 648;
            lblTempsShippingProj.Text = "lblTempsShippingProj";
            lblTempsShippingProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsShippingSoum
            // 
            lblTempsShippingSoum.BackColor = System.Drawing.Color.White;
            lblTempsShippingSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingSoum.Location = new System.Drawing.Point(259, 363);
            lblTempsShippingSoum.Name = "lblTempsShippingSoum";
            lblTempsShippingSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsShippingSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsShippingSoum.TabIndex = 646;
            lblTempsShippingSoum.Text = "lblTempsShippingSoum";
            lblTempsShippingSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = System.Drawing.Color.White;
            label37.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.Location = new System.Drawing.Point(14, 364);
            label37.MinimumSize = new System.Drawing.Size(60, 19);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(111, 19);
            label37.TabIndex = 647;
            label37.Text = "Temps d\'expédition";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = System.Drawing.Color.White;
            label38.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.Location = new System.Drawing.Point(643, 342);
            label38.Margin = new System.Windows.Forms.Padding(0);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(25, 15);
            label38.TabIndex = 645;
            label38.Text = "hrs";
            // 
            // lblTempsGestionProj
            // 
            lblTempsGestionProj.BackColor = System.Drawing.Color.White;
            lblTempsGestionProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionProj.Location = new System.Drawing.Point(355, 338);
            lblTempsGestionProj.Name = "lblTempsGestionProj";
            lblTempsGestionProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsGestionProj.Size = new System.Drawing.Size(93, 23);
            lblTempsGestionProj.TabIndex = 644;
            lblTempsGestionProj.Text = "lblTempsGestionProj";
            lblTempsGestionProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsGestionSoum
            // 
            lblTempsGestionSoum.BackColor = System.Drawing.Color.White;
            lblTempsGestionSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionSoum.Location = new System.Drawing.Point(259, 338);
            lblTempsGestionSoum.Name = "lblTempsGestionSoum";
            lblTempsGestionSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsGestionSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsGestionSoum.TabIndex = 642;
            lblTempsGestionSoum.Text = "lblTempsGestionSoum";
            lblTempsGestionSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BackColor = System.Drawing.Color.White;
            label41.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.Location = new System.Drawing.Point(14, 339);
            label41.MinimumSize = new System.Drawing.Size(60, 19);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(105, 19);
            label41.TabIndex = 643;
            label41.Text = "Temps de gestion :";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = System.Drawing.Color.White;
            label42.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.Location = new System.Drawing.Point(643, 318);
            label42.Margin = new System.Windows.Forms.Padding(0);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(25, 15);
            label42.TabIndex = 641;
            label42.Text = "hrs";
            // 
            // lblTempsFormationProj
            // 
            lblTempsFormationProj.BackColor = System.Drawing.Color.White;
            lblTempsFormationProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationProj.Location = new System.Drawing.Point(355, 314);
            lblTempsFormationProj.Name = "lblTempsFormationProj";
            lblTempsFormationProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsFormationProj.Size = new System.Drawing.Size(93, 23);
            lblTempsFormationProj.TabIndex = 640;
            lblTempsFormationProj.Text = "lblTempsFormationProj";
            lblTempsFormationProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsFormationSoum
            // 
            lblTempsFormationSoum.BackColor = System.Drawing.Color.White;
            lblTempsFormationSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationSoum.Location = new System.Drawing.Point(259, 314);
            lblTempsFormationSoum.Name = "lblTempsFormationSoum";
            lblTempsFormationSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsFormationSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsFormationSoum.TabIndex = 638;
            lblTempsFormationSoum.Text = "lblTempsFormationSoum";
            lblTempsFormationSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.BackColor = System.Drawing.Color.White;
            label45.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.Location = new System.Drawing.Point(14, 315);
            label45.MinimumSize = new System.Drawing.Size(60, 19);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(120, 19);
            label45.TabIndex = 639;
            label45.Text = "Temps de formation :";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = System.Drawing.Color.White;
            label46.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.Location = new System.Drawing.Point(643, 294);
            label46.Margin = new System.Windows.Forms.Padding(0);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(25, 15);
            label46.TabIndex = 637;
            label46.Text = "hrs";
            // 
            // lblTempsInstallationProj
            // 
            lblTempsInstallationProj.BackColor = System.Drawing.Color.White;
            lblTempsInstallationProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsInstallationProj.Location = new System.Drawing.Point(355, 290);
            lblTempsInstallationProj.Name = "lblTempsInstallationProj";
            lblTempsInstallationProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsInstallationProj.Size = new System.Drawing.Size(93, 23);
            lblTempsInstallationProj.TabIndex = 636;
            lblTempsInstallationProj.Text = "lblTempsInstallationProj";
            lblTempsInstallationProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsInstallationSoum
            // 
            lblTempsInstallationSoum.BackColor = System.Drawing.Color.White;
            lblTempsInstallationSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsInstallationSoum.Location = new System.Drawing.Point(259, 290);
            lblTempsInstallationSoum.Name = "lblTempsInstallationSoum";
            lblTempsInstallationSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsInstallationSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsInstallationSoum.TabIndex = 634;
            lblTempsInstallationSoum.Text = "lblTempsInstallationSoum";
            lblTempsInstallationSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.BackColor = System.Drawing.Color.White;
            label49.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label49.Location = new System.Drawing.Point(14, 291);
            label49.MinimumSize = new System.Drawing.Size(60, 19);
            label49.Name = "label49";
            label49.Size = new System.Drawing.Size(124, 19);
            label49.TabIndex = 635;
            label49.Text = "Temps d\'installation :";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.BackColor = System.Drawing.Color.White;
            label50.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.Location = new System.Drawing.Point(643, 270);
            label50.Margin = new System.Windows.Forms.Padding(0);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(25, 15);
            label50.TabIndex = 633;
            label50.Text = "hrs";
            // 
            // lblTempsTestProj
            // 
            lblTempsTestProj.BackColor = System.Drawing.Color.White;
            lblTempsTestProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestProj.Location = new System.Drawing.Point(355, 266);
            lblTempsTestProj.Name = "lblTempsTestProj";
            lblTempsTestProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsTestProj.Size = new System.Drawing.Size(93, 23);
            lblTempsTestProj.TabIndex = 632;
            lblTempsTestProj.Text = "lblTempsTestProj";
            lblTempsTestProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsTestSoum
            // 
            lblTempsTestSoum.BackColor = System.Drawing.Color.White;
            lblTempsTestSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestSoum.Location = new System.Drawing.Point(259, 266);
            lblTempsTestSoum.Name = "lblTempsTestSoum";
            lblTempsTestSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsTestSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsTestSoum.TabIndex = 630;
            lblTempsTestSoum.Text = "lblTempsTestSoum";
            lblTempsTestSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.BackColor = System.Drawing.Color.White;
            label53.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label53.Location = new System.Drawing.Point(14, 267);
            label53.MinimumSize = new System.Drawing.Size(60, 19);
            label53.Name = "label53";
            label53.Size = new System.Drawing.Size(129, 19);
            label53.TabIndex = 631;
            label53.Text = "Temps de tests finaux :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = System.Drawing.Color.White;
            label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.Location = new System.Drawing.Point(643, 245);
            label22.Margin = new System.Windows.Forms.Padding(0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(25, 15);
            label22.TabIndex = 629;
            label22.Text = "hrs";
            // 
            // lblTempsPeintureProj
            // 
            lblTempsPeintureProj.BackColor = System.Drawing.Color.White;
            lblTempsPeintureProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsPeintureProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsPeintureProj.Location = new System.Drawing.Point(355, 241);
            lblTempsPeintureProj.Name = "lblTempsPeintureProj";
            lblTempsPeintureProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsPeintureProj.Size = new System.Drawing.Size(93, 23);
            lblTempsPeintureProj.TabIndex = 628;
            lblTempsPeintureProj.Text = "lblTempsPeintureProj";
            lblTempsPeintureProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsPeintureSoum
            // 
            lblTempsPeintureSoum.BackColor = System.Drawing.Color.White;
            lblTempsPeintureSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsPeintureSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsPeintureSoum.Location = new System.Drawing.Point(259, 241);
            lblTempsPeintureSoum.Name = "lblTempsPeintureSoum";
            lblTempsPeintureSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsPeintureSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsPeintureSoum.TabIndex = 626;
            lblTempsPeintureSoum.Text = "lblTempsProgRobotEstime";
            lblTempsPeintureSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = System.Drawing.Color.White;
            label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.Location = new System.Drawing.Point(14, 242);
            label25.MinimumSize = new System.Drawing.Size(60, 19);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(167, 19);
            label25.TabIndex = 627;
            label25.Text = "Temps de peinture et finition :";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.White;
            label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(643, 221);
            label26.Margin = new System.Windows.Forms.Padding(0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(25, 15);
            label26.TabIndex = 625;
            label26.Text = "hrs";
            // 
            // lblTempsAssemblageProj
            // 
            lblTempsAssemblageProj.BackColor = System.Drawing.Color.White;
            lblTempsAssemblageProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsAssemblageProj.Location = new System.Drawing.Point(355, 217);
            lblTempsAssemblageProj.Name = "lblTempsAssemblageProj";
            lblTempsAssemblageProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsAssemblageProj.Size = new System.Drawing.Size(93, 23);
            lblTempsAssemblageProj.TabIndex = 624;
            lblTempsAssemblageProj.Text = "lblTempsAssemblageProj";
            lblTempsAssemblageProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsAssemblageSoum
            // 
            lblTempsAssemblageSoum.BackColor = System.Drawing.Color.White;
            lblTempsAssemblageSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsAssemblageSoum.Location = new System.Drawing.Point(259, 217);
            lblTempsAssemblageSoum.Name = "lblTempsAssemblageSoum";
            lblTempsAssemblageSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsAssemblageSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsAssemblageSoum.TabIndex = 622;
            lblTempsAssemblageSoum.Text = "lblTempsAssemblageSoum";
            lblTempsAssemblageSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = System.Drawing.Color.White;
            label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.Location = new System.Drawing.Point(14, 218);
            label29.MinimumSize = new System.Drawing.Size(60, 19);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(200, 19);
            label29.TabIndex = 623;
            label29.Text = "Temps d\'assemblage des systèmes :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.White;
            label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(643, 196);
            label14.Margin = new System.Windows.Forms.Padding(0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(25, 15);
            label14.TabIndex = 621;
            label14.Text = "hrs";
            // 
            // lblTempsSoudureProj
            // 
            lblTempsSoudureProj.BackColor = System.Drawing.Color.White;
            lblTempsSoudureProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsSoudureProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsSoudureProj.Location = new System.Drawing.Point(355, 192);
            lblTempsSoudureProj.Name = "lblTempsSoudureProj";
            lblTempsSoudureProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsSoudureProj.Size = new System.Drawing.Size(93, 23);
            lblTempsSoudureProj.TabIndex = 620;
            lblTempsSoudureProj.Text = "lblTempsSoudureProj";
            lblTempsSoudureProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsSoudureSoum
            // 
            lblTempsSoudureSoum.BackColor = System.Drawing.Color.White;
            lblTempsSoudureSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsSoudureSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsSoudureSoum.Location = new System.Drawing.Point(259, 192);
            lblTempsSoudureSoum.Name = "lblTempsSoudureSoum";
            lblTempsSoudureSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsSoudureSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsSoudureSoum.TabIndex = 618;
            lblTempsSoudureSoum.Text = "lblTempsSoudureSoum";
            lblTempsSoudureSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.White;
            label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(14, 193);
            label17.MinimumSize = new System.Drawing.Size(60, 19);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(212, 19);
            label17.TabIndex = 619;
            label17.Text = "Temps de coupe, soudure et meulage :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = System.Drawing.Color.White;
            label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.Location = new System.Drawing.Point(643, 172);
            label18.Margin = new System.Windows.Forms.Padding(0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(25, 15);
            label18.TabIndex = 617;
            label18.Text = "hrs";
            // 
            // lblTempsMachinageProj
            // 
            lblTempsMachinageProj.BackColor = System.Drawing.Color.White;
            lblTempsMachinageProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMachinageProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMachinageProj.Location = new System.Drawing.Point(355, 168);
            lblTempsMachinageProj.Name = "lblTempsMachinageProj";
            lblTempsMachinageProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsMachinageProj.Size = new System.Drawing.Size(93, 23);
            lblTempsMachinageProj.TabIndex = 616;
            lblTempsMachinageProj.Text = "lblTempsMachinageProj";
            lblTempsMachinageProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsMachinageSoum
            // 
            lblTempsMachinageSoum.BackColor = System.Drawing.Color.White;
            lblTempsMachinageSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMachinageSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMachinageSoum.Location = new System.Drawing.Point(259, 168);
            lblTempsMachinageSoum.Name = "lblTempsMachinageSoum";
            lblTempsMachinageSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsMachinageSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsMachinageSoum.TabIndex = 614;
            lblTempsMachinageSoum.Text = "lblTempsMachinageSoum";
            lblTempsMachinageSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = System.Drawing.Color.White;
            label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.Location = new System.Drawing.Point(14, 169);
            label21.MinimumSize = new System.Drawing.Size(60, 19);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(126, 19);
            label21.TabIndex = 615;
            label21.Text = "Temps de machinage :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.White;
            label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(643, 148);
            label9.Margin = new System.Windows.Forms.Padding(0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(25, 15);
            label9.TabIndex = 613;
            label9.Text = "hrs";
            // 
            // lblTempsCoupeProj
            // 
            lblTempsCoupeProj.BackColor = System.Drawing.Color.White;
            lblTempsCoupeProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsCoupeProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsCoupeProj.Location = new System.Drawing.Point(355, 144);
            lblTempsCoupeProj.Name = "lblTempsCoupeProj";
            lblTempsCoupeProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsCoupeProj.Size = new System.Drawing.Size(93, 23);
            lblTempsCoupeProj.TabIndex = 612;
            lblTempsCoupeProj.Text = "lblTempsCoupeProj";
            lblTempsCoupeProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsCoupeSoum
            // 
            lblTempsCoupeSoum.BackColor = System.Drawing.Color.White;
            lblTempsCoupeSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsCoupeSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsCoupeSoum.Location = new System.Drawing.Point(259, 144);
            lblTempsCoupeSoum.Name = "lblTempsCoupeSoum";
            lblTempsCoupeSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsCoupeSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsCoupeSoum.TabIndex = 610;
            lblTempsCoupeSoum.Text = "lblTempsCoupeSoum";
            lblTempsCoupeSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.White;
            label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(14, 145);
            label13.MinimumSize = new System.Drawing.Size(60, 19);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(177, 19);
            label13.TabIndex = 611;
            label13.Text = "Temps de coupe et préparation:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(418, 66);
            label8.MinimumSize = new System.Drawing.Size(60, 19);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(60, 23);
            label8.TabIndex = 609;
            label8.Text = "Temps";
            // 
            // lblTempsProj
            // 
            lblTempsProj.AutoSize = true;
            lblTempsProj.BackColor = System.Drawing.Color.White;
            lblTempsProj.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsProj.Location = new System.Drawing.Point(370, 92);
            lblTempsProj.MinimumSize = new System.Drawing.Size(60, 19);
            lblTempsProj.Name = "lblTempsProj";
            lblTempsProj.Size = new System.Drawing.Size(60, 23);
            lblTempsProj.TabIndex = 608;
            lblTempsProj.Text = "Proj.";
            // 
            // lblTempsSoum
            // 
            lblTempsSoum.AutoSize = true;
            lblTempsSoum.BackColor = System.Drawing.Color.White;
            lblTempsSoum.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsSoum.Location = new System.Drawing.Point(280, 92);
            lblTempsSoum.MinimumSize = new System.Drawing.Size(60, 19);
            lblTempsSoum.Name = "lblTempsSoum";
            lblTempsSoum.Size = new System.Drawing.Size(60, 23);
            lblTempsSoum.TabIndex = 607;
            lblTempsSoum.Text = "Soum.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(643, 124);
            label5.Margin = new System.Windows.Forms.Padding(0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(25, 15);
            label5.TabIndex = 606;
            label5.Text = "hrs";
            // 
            // lblTempsDessinProj
            // 
            lblTempsDessinProj.BackColor = System.Drawing.Color.White;
            lblTempsDessinProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinProj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinProj.Location = new System.Drawing.Point(355, 120);
            lblTempsDessinProj.Name = "lblTempsDessinProj";
            lblTempsDessinProj.Padding = new System.Windows.Forms.Padding(3);
            lblTempsDessinProj.Size = new System.Drawing.Size(93, 23);
            lblTempsDessinProj.TabIndex = 605;
            lblTempsDessinProj.Text = "lblTempsDessinReel";
            lblTempsDessinProj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsDessinSoum
            // 
            lblTempsDessinSoum.BackColor = System.Drawing.Color.White;
            lblTempsDessinSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinSoum.Location = new System.Drawing.Point(259, 120);
            lblTempsDessinSoum.Name = "lblTempsDessinSoum";
            lblTempsDessinSoum.Padding = new System.Windows.Forms.Padding(3);
            lblTempsDessinSoum.Size = new System.Drawing.Size(93, 23);
            lblTempsDessinSoum.TabIndex = 603;
            lblTempsDessinSoum.Text = "lblTempsDessinEstime";
            lblTempsDessinSoum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(14, 121);
            label3.MinimumSize = new System.Drawing.Size(60, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(184, 19);
            label3.TabIndex = 604;
            label3.Text = "Temps de conception et dessins :";
            // 
            // lblNoProjet
            // 
            lblNoProjet.BackColor = System.Drawing.Color.White;
            lblNoProjet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoProjet.Location = new System.Drawing.Point(80, 70);
            lblNoProjet.Name = "lblNoProjet";
            lblNoProjet.Size = new System.Drawing.Size(167, 19);
            lblNoProjet.TabIndex = 601;
            lblNoProjet.Text = "lblNoProjet";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.White;
            Label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label12.Location = new System.Drawing.Point(14, 70);
            Label12.MinimumSize = new System.Drawing.Size(60, 19);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(60, 19);
            Label12.TabIndex = 602;
            Label12.Text = "Numéro";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(644, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(174, 75);
            pictureBox1.TabIndex = 600;
            pictureBox1.TabStop = false;
            // 
            // lblTitreRapport
            // 
            lblTitreRapport.AutoSize = true;
            lblTitreRapport.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreRapport.Location = new System.Drawing.Point(154, 2);
            lblTitreRapport.Name = "lblTitreRapport";
            lblTitreRapport.Size = new System.Drawing.Size(247, 36);
            lblTitreRapport.TabIndex = 599;
            lblTitreRapport.Tag = "";
            lblTitreRapport.Text = "Temps mécaniques";
            lblTitreRapport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalTempsReel
            // 
            lblTotalTempsReel.BackColor = System.Drawing.Color.White;
            lblTotalTempsReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsReel.Location = new System.Drawing.Point(546, 418);
            lblTotalTempsReel.Name = "lblTotalTempsReel";
            lblTotalTempsReel.Padding = new System.Windows.Forms.Padding(3);
            lblTotalTempsReel.Size = new System.Drawing.Size(93, 23);
            lblTotalTempsReel.TabIndex = 699;
            lblTotalTempsReel.Text = "lblTotalTempsReel";
            lblTotalTempsReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTempsConc
            // 
            lblTotalTempsConc.BackColor = System.Drawing.Color.White;
            lblTotalTempsConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalTempsConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalTempsConc.Location = new System.Drawing.Point(450, 418);
            lblTotalTempsConc.Name = "lblTotalTempsConc";
            lblTotalTempsConc.Padding = new System.Windows.Forms.Padding(3);
            lblTotalTempsConc.Size = new System.Drawing.Size(93, 23);
            lblTotalTempsConc.TabIndex = 698;
            lblTotalTempsConc.Text = "lblTotalTempsConc";
            lblTotalTempsConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsPrototypeReel
            // 
            lblTempsPrototypeReel.BackColor = System.Drawing.Color.White;
            lblTempsPrototypeReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsPrototypeReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsPrototypeReel.Location = new System.Drawing.Point(546, 387);
            lblTempsPrototypeReel.Name = "lblTempsPrototypeReel";
            lblTempsPrototypeReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsPrototypeReel.Size = new System.Drawing.Size(93, 23);
            lblTempsPrototypeReel.TabIndex = 693;
            lblTempsPrototypeReel.Text = "lblTempsPrototypeReel";
            lblTempsPrototypeReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsShippingReel
            // 
            lblTempsShippingReel.BackColor = System.Drawing.Color.White;
            lblTempsShippingReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingReel.Location = new System.Drawing.Point(546, 363);
            lblTempsShippingReel.Name = "lblTempsShippingReel";
            lblTempsShippingReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsShippingReel.Size = new System.Drawing.Size(93, 23);
            lblTempsShippingReel.TabIndex = 691;
            lblTempsShippingReel.Text = "lblTempsShippingReel";
            lblTempsShippingReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsShippingConc
            // 
            lblTempsShippingConc.BackColor = System.Drawing.Color.White;
            lblTempsShippingConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsShippingConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsShippingConc.Location = new System.Drawing.Point(450, 363);
            lblTempsShippingConc.Name = "lblTempsShippingConc";
            lblTempsShippingConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsShippingConc.Size = new System.Drawing.Size(93, 23);
            lblTempsShippingConc.TabIndex = 690;
            lblTempsShippingConc.Text = "lblTempsShippingConc";
            lblTempsShippingConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsGestionReel
            // 
            lblTempsGestionReel.BackColor = System.Drawing.Color.White;
            lblTempsGestionReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionReel.Location = new System.Drawing.Point(546, 338);
            lblTempsGestionReel.Name = "lblTempsGestionReel";
            lblTempsGestionReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsGestionReel.Size = new System.Drawing.Size(93, 23);
            lblTempsGestionReel.TabIndex = 689;
            lblTempsGestionReel.Text = "lblTempsGestionReel";
            lblTempsGestionReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsGestionConc
            // 
            lblTempsGestionConc.BackColor = System.Drawing.Color.White;
            lblTempsGestionConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsGestionConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsGestionConc.Location = new System.Drawing.Point(450, 338);
            lblTempsGestionConc.Name = "lblTempsGestionConc";
            lblTempsGestionConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsGestionConc.Size = new System.Drawing.Size(93, 23);
            lblTempsGestionConc.TabIndex = 688;
            lblTempsGestionConc.Text = "lblTempsGestionConc";
            lblTempsGestionConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsFormationReel
            // 
            lblTempsFormationReel.BackColor = System.Drawing.Color.White;
            lblTempsFormationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationReel.Location = new System.Drawing.Point(546, 314);
            lblTempsFormationReel.Name = "lblTempsFormationReel";
            lblTempsFormationReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsFormationReel.Size = new System.Drawing.Size(93, 23);
            lblTempsFormationReel.TabIndex = 687;
            lblTempsFormationReel.Text = "lblTempsFormationReel";
            lblTempsFormationReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsFormationConc
            // 
            lblTempsFormationConc.BackColor = System.Drawing.Color.White;
            lblTempsFormationConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsFormationConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsFormationConc.Location = new System.Drawing.Point(450, 314);
            lblTempsFormationConc.Name = "lblTempsFormationConc";
            lblTempsFormationConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsFormationConc.Size = new System.Drawing.Size(93, 23);
            lblTempsFormationConc.TabIndex = 686;
            lblTempsFormationConc.Text = "lblTempsFormationConc";
            lblTempsFormationConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsInstallationReel
            // 
            lblTempsInstallationReel.BackColor = System.Drawing.Color.White;
            lblTempsInstallationReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsInstallationReel.Location = new System.Drawing.Point(546, 290);
            lblTempsInstallationReel.Name = "lblTempsInstallationReel";
            lblTempsInstallationReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsInstallationReel.Size = new System.Drawing.Size(93, 23);
            lblTempsInstallationReel.TabIndex = 685;
            lblTempsInstallationReel.Text = "lblTempsInstallationReel";
            lblTempsInstallationReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsInstallationConc
            // 
            lblTempsInstallationConc.BackColor = System.Drawing.Color.White;
            lblTempsInstallationConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsInstallationConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsInstallationConc.Location = new System.Drawing.Point(450, 290);
            lblTempsInstallationConc.Name = "lblTempsInstallationConc";
            lblTempsInstallationConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsInstallationConc.Size = new System.Drawing.Size(93, 23);
            lblTempsInstallationConc.TabIndex = 684;
            lblTempsInstallationConc.Text = "lblTempsInstallationConc";
            lblTempsInstallationConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsTestReel
            // 
            lblTempsTestReel.BackColor = System.Drawing.Color.White;
            lblTempsTestReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestReel.Location = new System.Drawing.Point(546, 266);
            lblTempsTestReel.Name = "lblTempsTestReel";
            lblTempsTestReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsTestReel.Size = new System.Drawing.Size(93, 23);
            lblTempsTestReel.TabIndex = 683;
            lblTempsTestReel.Text = "lblTempsTestReel";
            lblTempsTestReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsTestConc
            // 
            lblTempsTestConc.BackColor = System.Drawing.Color.White;
            lblTempsTestConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsTestConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsTestConc.Location = new System.Drawing.Point(450, 266);
            lblTempsTestConc.Name = "lblTempsTestConc";
            lblTempsTestConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsTestConc.Size = new System.Drawing.Size(93, 23);
            lblTempsTestConc.TabIndex = 682;
            lblTempsTestConc.Text = "lblTempsTestConc";
            lblTempsTestConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsPeintureReel
            // 
            lblTempsPeintureReel.BackColor = System.Drawing.Color.White;
            lblTempsPeintureReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsPeintureReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsPeintureReel.Location = new System.Drawing.Point(546, 241);
            lblTempsPeintureReel.Name = "lblTempsPeintureReel";
            lblTempsPeintureReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsPeintureReel.Size = new System.Drawing.Size(93, 23);
            lblTempsPeintureReel.TabIndex = 681;
            lblTempsPeintureReel.Text = "lblTempsPeintureReel";
            lblTempsPeintureReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsPeintureConc
            // 
            lblTempsPeintureConc.BackColor = System.Drawing.Color.White;
            lblTempsPeintureConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsPeintureConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsPeintureConc.Location = new System.Drawing.Point(450, 241);
            lblTempsPeintureConc.Name = "lblTempsPeintureConc";
            lblTempsPeintureConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsPeintureConc.Size = new System.Drawing.Size(93, 23);
            lblTempsPeintureConc.TabIndex = 680;
            lblTempsPeintureConc.Text = "lblTempsPeintureConc";
            lblTempsPeintureConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsAssemblageReel
            // 
            lblTempsAssemblageReel.BackColor = System.Drawing.Color.White;
            lblTempsAssemblageReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsAssemblageReel.Location = new System.Drawing.Point(546, 217);
            lblTempsAssemblageReel.Name = "lblTempsAssemblageReel";
            lblTempsAssemblageReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsAssemblageReel.Size = new System.Drawing.Size(93, 23);
            lblTempsAssemblageReel.TabIndex = 679;
            lblTempsAssemblageReel.Text = "lblTempsAssemblageReel";
            lblTempsAssemblageReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsAssemblageConc
            // 
            lblTempsAssemblageConc.BackColor = System.Drawing.Color.White;
            lblTempsAssemblageConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsAssemblageConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsAssemblageConc.Location = new System.Drawing.Point(450, 217);
            lblTempsAssemblageConc.Name = "lblTempsAssemblageConc";
            lblTempsAssemblageConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsAssemblageConc.Size = new System.Drawing.Size(93, 23);
            lblTempsAssemblageConc.TabIndex = 678;
            lblTempsAssemblageConc.Text = "lblTempsAssemblageConc";
            lblTempsAssemblageConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsSoudureReel
            // 
            lblTempsSoudureReel.BackColor = System.Drawing.Color.White;
            lblTempsSoudureReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsSoudureReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsSoudureReel.Location = new System.Drawing.Point(546, 192);
            lblTempsSoudureReel.Name = "lblTempsSoudureReel";
            lblTempsSoudureReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsSoudureReel.Size = new System.Drawing.Size(93, 23);
            lblTempsSoudureReel.TabIndex = 677;
            lblTempsSoudureReel.Text = "lblTempsSoudureReel";
            lblTempsSoudureReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsSoudureConc
            // 
            lblTempsSoudureConc.BackColor = System.Drawing.Color.White;
            lblTempsSoudureConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsSoudureConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsSoudureConc.Location = new System.Drawing.Point(450, 192);
            lblTempsSoudureConc.Name = "lblTempsSoudureConc";
            lblTempsSoudureConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsSoudureConc.Size = new System.Drawing.Size(93, 23);
            lblTempsSoudureConc.TabIndex = 676;
            lblTempsSoudureConc.Text = "lblTempsSoudureConc";
            lblTempsSoudureConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsMachinageReel
            // 
            lblTempsMachinageReel.BackColor = System.Drawing.Color.White;
            lblTempsMachinageReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMachinageReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMachinageReel.Location = new System.Drawing.Point(546, 168);
            lblTempsMachinageReel.Name = "lblTempsMachinageReel";
            lblTempsMachinageReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsMachinageReel.Size = new System.Drawing.Size(93, 23);
            lblTempsMachinageReel.TabIndex = 675;
            lblTempsMachinageReel.Text = "lblTempsMachinageReel";
            lblTempsMachinageReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsMachinageConc
            // 
            lblTempsMachinageConc.BackColor = System.Drawing.Color.White;
            lblTempsMachinageConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsMachinageConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsMachinageConc.Location = new System.Drawing.Point(450, 168);
            lblTempsMachinageConc.Name = "lblTempsMachinageConc";
            lblTempsMachinageConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsMachinageConc.Size = new System.Drawing.Size(93, 23);
            lblTempsMachinageConc.TabIndex = 674;
            lblTempsMachinageConc.Text = "lblTempsMachinageConc";
            lblTempsMachinageConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsCoupeReel
            // 
            lblTempsCoupeReel.BackColor = System.Drawing.Color.White;
            lblTempsCoupeReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsCoupeReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsCoupeReel.Location = new System.Drawing.Point(546, 144);
            lblTempsCoupeReel.Name = "lblTempsCoupeReel";
            lblTempsCoupeReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsCoupeReel.Size = new System.Drawing.Size(93, 23);
            lblTempsCoupeReel.TabIndex = 673;
            lblTempsCoupeReel.Text = "lblTempsCoupeReel";
            lblTempsCoupeReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsCoupeConc
            // 
            lblTempsCoupeConc.BackColor = System.Drawing.Color.White;
            lblTempsCoupeConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsCoupeConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsCoupeConc.Location = new System.Drawing.Point(450, 144);
            lblTempsCoupeConc.Name = "lblTempsCoupeConc";
            lblTempsCoupeConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsCoupeConc.Size = new System.Drawing.Size(93, 23);
            lblTempsCoupeConc.TabIndex = 672;
            lblTempsCoupeConc.Text = "lblTempsCoupeConc";
            lblTempsCoupeConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.BackColor = System.Drawing.Color.White;
            label59.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label59.Location = new System.Drawing.Point(561, 92);
            label59.MinimumSize = new System.Drawing.Size(60, 19);
            label59.Name = "label59";
            label59.Size = new System.Drawing.Size(60, 23);
            label59.TabIndex = 671;
            label59.Text = "Réels";
            // 
            // lblTempsConc
            // 
            lblTempsConc.AutoSize = true;
            lblTempsConc.BackColor = System.Drawing.Color.White;
            lblTempsConc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsConc.Location = new System.Drawing.Point(471, 92);
            lblTempsConc.MinimumSize = new System.Drawing.Size(60, 19);
            lblTempsConc.Name = "lblTempsConc";
            lblTempsConc.Size = new System.Drawing.Size(60, 23);
            lblTempsConc.TabIndex = 670;
            lblTempsConc.Text = "Conc.";
            // 
            // lblTempsDessinReel
            // 
            lblTempsDessinReel.BackColor = System.Drawing.Color.White;
            lblTempsDessinReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinReel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinReel.Location = new System.Drawing.Point(546, 120);
            lblTempsDessinReel.Name = "lblTempsDessinReel";
            lblTempsDessinReel.Padding = new System.Windows.Forms.Padding(3);
            lblTempsDessinReel.Size = new System.Drawing.Size(93, 23);
            lblTempsDessinReel.TabIndex = 669;
            lblTempsDessinReel.Text = "lblTempsDessinReel";
            lblTempsDessinReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempsDessinConc
            // 
            lblTempsDessinConc.BackColor = System.Drawing.Color.White;
            lblTempsDessinConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTempsDessinConc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTempsDessinConc.Location = new System.Drawing.Point(450, 120);
            lblTempsDessinConc.Name = "lblTempsDessinConc";
            lblTempsDessinConc.Padding = new System.Windows.Forms.Padding(3);
            lblTempsDessinConc.Size = new System.Drawing.Size(93, 23);
            lblTempsDessinConc.TabIndex = 668;
            lblTempsDessinConc.Text = "lblTempsDessinConc";
            lblTempsDessinConc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewTempsMec
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(lblTotalTempsReel);
            Controls.Add(lblTotalTempsConc);
            Controls.Add(lblTempsPrototypeReel);
            Controls.Add(lblTempsShippingReel);
            Controls.Add(lblTempsShippingConc);
            Controls.Add(lblTempsGestionReel);
            Controls.Add(lblTempsGestionConc);
            Controls.Add(lblTempsFormationReel);
            Controls.Add(lblTempsFormationConc);
            Controls.Add(lblTempsInstallationReel);
            Controls.Add(lblTempsInstallationConc);
            Controls.Add(lblTempsTestReel);
            Controls.Add(lblTempsTestConc);
            Controls.Add(lblTempsPeintureReel);
            Controls.Add(lblTempsPeintureConc);
            Controls.Add(lblTempsAssemblageReel);
            Controls.Add(lblTempsAssemblageConc);
            Controls.Add(lblTempsSoudureReel);
            Controls.Add(lblTempsSoudureConc);
            Controls.Add(lblTempsMachinageReel);
            Controls.Add(lblTempsMachinageConc);
            Controls.Add(lblTempsCoupeReel);
            Controls.Add(lblTempsCoupeConc);
            Controls.Add(label59);
            Controls.Add(lblTempsConc);
            Controls.Add(lblTempsDessinReel);
            Controls.Add(lblTempsDessinConc);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(label66);
            Controls.Add(lblTotalTempsProj);
            Controls.Add(lblTotalTempsSoum);
            Controls.Add(label69);
            Controls.Add(label30);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(lblTempsShippingProj);
            Controls.Add(lblTempsShippingSoum);
            Controls.Add(label37);
            Controls.Add(label38);
            Controls.Add(lblTempsGestionProj);
            Controls.Add(lblTempsGestionSoum);
            Controls.Add(label41);
            Controls.Add(label42);
            Controls.Add(lblTempsFormationProj);
            Controls.Add(lblTempsFormationSoum);
            Controls.Add(label45);
            Controls.Add(label46);
            Controls.Add(lblTempsInstallationProj);
            Controls.Add(lblTempsInstallationSoum);
            Controls.Add(label49);
            Controls.Add(label50);
            Controls.Add(lblTempsTestProj);
            Controls.Add(lblTempsTestSoum);
            Controls.Add(label53);
            Controls.Add(label22);
            Controls.Add(lblTempsPeintureProj);
            Controls.Add(lblTempsPeintureSoum);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(lblTempsAssemblageProj);
            Controls.Add(lblTempsAssemblageSoum);
            Controls.Add(label29);
            Controls.Add(label14);
            Controls.Add(lblTempsSoudureProj);
            Controls.Add(lblTempsSoudureSoum);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(lblTempsMachinageProj);
            Controls.Add(lblTempsMachinageSoum);
            Controls.Add(label21);
            Controls.Add(label9);
            Controls.Add(lblTempsCoupeProj);
            Controls.Add(lblTempsCoupeSoum);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(lblTempsProj);
            Controls.Add(lblTempsSoum);
            Controls.Add(label5);
            Controls.Add(lblTempsDessinProj);
            Controls.Add(lblTempsDessinSoum);
            Controls.Add(label3);
            Controls.Add(lblNoProjet);
            Controls.Add(Label12);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitreRapport);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewTempsMec";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(ViewBonTravail_Load);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel lblPrintDate;
        internal static ToolStripStatusLabel lblPiedPage;
        internal static ListView listView1;
        internal static ColumnHeader columnHeader1;
        internal static ColumnHeader columnHeader2;
        internal static ColumnHeader columnHeader3;
        internal static Label label66;
        internal static Label lblTotalTempsProj;
        internal static Label lblTotalTempsSoum;
        internal static Label label69;
        internal static Label label30;
        internal static Label label33;
        internal static Label label34;
        internal static Label lblTempsShippingProj;
        internal static Label lblTempsShippingSoum;
        internal static Label label37;
        internal static Label label38;
        internal static Label lblTempsGestionProj;
        internal static Label lblTempsGestionSoum;
        internal static Label label41;
        internal static Label label42;
        internal static Label lblTempsFormationProj;
        internal static Label lblTempsFormationSoum;
        internal static Label label45;
        internal static Label label46;
        internal static Label lblTempsInstallationProj;
        internal static Label lblTempsInstallationSoum;
        internal static Label label49;
        internal static Label label50;
        internal static Label lblTempsTestProj;
        internal static Label lblTempsTestSoum;
        internal static Label label53;
        internal static Label label22;
        internal static Label lblTempsPeintureProj;
        internal static Label lblTempsPeintureSoum;
        internal static Label label25;
        internal static Label label26;
        internal static Label lblTempsAssemblageProj;
        internal static Label lblTempsAssemblageSoum;
        internal static Label label29;
        internal static Label label14;
        internal static Label lblTempsSoudureProj;
        internal static Label lblTempsSoudureSoum;
        internal static Label label17;
        internal static Label label18;
        internal static Label lblTempsMachinageProj;
        internal static Label lblTempsMachinageSoum;
        internal static Label label21;
        internal static Label label9;
        internal static Label lblTempsCoupeProj;
        internal static Label lblTempsCoupeSoum;
        internal static Label label13;
        internal static Label label8;
        internal static Label lblTempsProj;
        internal static Label lblTempsSoum;
        internal static Label label5;
        internal static Label lblTempsDessinProj;
        internal static Label lblTempsDessinSoum;
        internal static Label label3;
        internal static Label lblNoProjet;
        internal static Label Label12;
        internal static PictureBox pictureBox1;
        internal static Label lblTitreRapport;
        internal static Label lblTotalTempsReel;
        internal static Label lblTotalTempsConc;
        internal static Label lblTempsPrototypeReel;
        internal static Label lblTempsShippingReel;
        internal static Label lblTempsShippingConc;
        internal static Label lblTempsGestionReel;
        internal static Label lblTempsGestionConc;
        internal static Label lblTempsFormationReel;
        internal static Label lblTempsFormationConc;
        internal static Label lblTempsInstallationReel;
        internal static Label lblTempsInstallationConc;
        internal static Label lblTempsTestReel;
        internal static Label lblTempsTestConc;
        internal static Label lblTempsPeintureReel;
        internal static Label lblTempsPeintureConc;
        internal static Label lblTempsAssemblageReel;
        internal static Label lblTempsAssemblageConc;
        internal static Label lblTempsSoudureReel;
        internal static Label lblTempsSoudureConc;
        internal static Label lblTempsMachinageReel;
        internal static Label lblTempsMachinageConc;
        internal static Label lblTempsCoupeReel;
        internal static Label lblTempsCoupeConc;
        internal static Label label59;
        internal static Label lblTempsConc;
        internal static Label lblTempsDessinReel;
        internal static Label lblTempsDessinConc;

        public ViewTempsMec() => InitializeComponent();
        private void ViewBonTravail_Load(object sender, EventArgs e) => Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        internal static ADODB.Recordset DataSource;
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
    }
}
