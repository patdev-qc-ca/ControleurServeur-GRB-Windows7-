
using Stripe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ControleurServeur
{
    public  class ViewFermeMecanique : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFermeMecanique));
            lblPiedPage = new System.Windows.Forms.Label();
            lblPage = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            label125 = new System.Windows.Forms.Label();
            label60 = new System.Windows.Forms.Label();
            label45 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            label47 = new System.Windows.Forms.Label();
            label49 = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            label51 = new System.Windows.Forms.Label();
            label52 = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            label42 = new System.Windows.Forms.Label();
            label43 = new System.Windows.Forms.Label();
            label44 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label126 = new System.Windows.Forms.Label();
            label127 = new System.Windows.Forms.Label();
            label129 = new System.Windows.Forms.Label();
            label130 = new System.Windows.Forms.Label();
            label131 = new System.Windows.Forms.Label();
            label132 = new System.Windows.Forms.Label();
            label117 = new System.Windows.Forms.Label();
            label118 = new System.Windows.Forms.Label();
            label119 = new System.Windows.Forms.Label();
            label121 = new System.Windows.Forms.Label();
            label122 = new System.Windows.Forms.Label();
            label123 = new System.Windows.Forms.Label();
            label124 = new System.Windows.Forms.Label();
            label109 = new System.Windows.Forms.Label();
            label110 = new System.Windows.Forms.Label();
            label111 = new System.Windows.Forms.Label();
            label113 = new System.Windows.Forms.Label();
            label114 = new System.Windows.Forms.Label();
            label115 = new System.Windows.Forms.Label();
            label116 = new System.Windows.Forms.Label();
            label101 = new System.Windows.Forms.Label();
            label102 = new System.Windows.Forms.Label();
            label103 = new System.Windows.Forms.Label();
            label105 = new System.Windows.Forms.Label();
            label106 = new System.Windows.Forms.Label();
            label107 = new System.Windows.Forms.Label();
            label108 = new System.Windows.Forms.Label();
            label93 = new System.Windows.Forms.Label();
            label94 = new System.Windows.Forms.Label();
            label95 = new System.Windows.Forms.Label();
            label97 = new System.Windows.Forms.Label();
            label98 = new System.Windows.Forms.Label();
            label99 = new System.Windows.Forms.Label();
            label100 = new System.Windows.Forms.Label();
            label85 = new System.Windows.Forms.Label();
            label86 = new System.Windows.Forms.Label();
            label87 = new System.Windows.Forms.Label();
            label89 = new System.Windows.Forms.Label();
            label90 = new System.Windows.Forms.Label();
            label91 = new System.Windows.Forms.Label();
            label92 = new System.Windows.Forms.Label();
            label77 = new System.Windows.Forms.Label();
            label78 = new System.Windows.Forms.Label();
            label79 = new System.Windows.Forms.Label();
            label81 = new System.Windows.Forms.Label();
            label82 = new System.Windows.Forms.Label();
            label83 = new System.Windows.Forms.Label();
            label84 = new System.Windows.Forms.Label();
            label69 = new System.Windows.Forms.Label();
            label70 = new System.Windows.Forms.Label();
            label71 = new System.Windows.Forms.Label();
            label73 = new System.Windows.Forms.Label();
            label74 = new System.Windows.Forms.Label();
            label75 = new System.Windows.Forms.Label();
            label76 = new System.Windows.Forms.Label();
            label61 = new System.Windows.Forms.Label();
            label62 = new System.Windows.Forms.Label();
            label63 = new System.Windows.Forms.Label();
            label65 = new System.Windows.Forms.Label();
            label66 = new System.Windows.Forms.Label();
            label67 = new System.Windows.Forms.Label();
            label68 = new System.Windows.Forms.Label();
            label53 = new System.Windows.Forms.Label();
            label54 = new System.Windows.Forms.Label();
            label55 = new System.Windows.Forms.Label();
            label57 = new System.Windows.Forms.Label();
            label58 = new System.Windows.Forms.Label();
            label59 = new System.Windows.Forms.Label();
            label133 = new System.Windows.Forms.Label();
            label134 = new System.Windows.Forms.Label();
            label137 = new System.Windows.Forms.Label();
            label138 = new System.Windows.Forms.Label();
            label141 = new System.Windows.Forms.Label();
            label142 = new System.Windows.Forms.Label();
            label146 = new System.Windows.Forms.Label();
            label145 = new System.Windows.Forms.Label();
            label149 = new System.Windows.Forms.Label();
            label150 = new System.Windows.Forms.Label();
            label151 = new System.Windows.Forms.Label();
            label152 = new System.Windows.Forms.Label();
            label154 = new System.Windows.Forms.Label();
            label139 = new System.Windows.Forms.Label();
            label143 = new System.Windows.Forms.Label();
            label147 = new System.Windows.Forms.Label();
            label148 = new System.Windows.Forms.Label();
            label153 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblTitreCommande = new System.Windows.Forms.Label();
            lblTitrePage = new System.Windows.Forms.Label();
            lblNoSoum = new System.Windows.Forms.Label();
            lblNoBC = new System.Windows.Forms.Label();
            lblTitreBC = new System.Windows.Forms.Label();
            lblTitreNoSoum = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblFax = new System.Windows.Forms.Label();
            lblTitreFax = new System.Windows.Forms.Label();
            lblTel = new System.Windows.Forms.Label();
            lblTitreTel = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            lblTitreContact = new System.Windows.Forms.Label();
            lblTitreClient = new System.Windows.Forms.Label();
            lbTitrelProjet = new System.Windows.Forms.Label();
            lblProjet = new System.Windows.Forms.Label();
            lblDateOuverture = new System.Windows.Forms.Label();
            lblDateRequise = new System.Windows.Forms.Label();
            lbltitredatereq = new System.Windows.Forms.Label();
            lbltitredate = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // lblPiedPage
            // 
            lblPiedPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            lblPiedPage.Font = new System.Drawing.Font("Calibri", 12F);
            lblPiedPage.Location = new System.Drawing.Point(401, 983);
            lblPiedPage.Name = "lblPiedPage";
            lblPiedPage.Size = new System.Drawing.Size(314, 19);
            lblPiedPage.TabIndex = 15;
            lblPiedPage.Text = "lblPiedPage";
            lblPiedPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPage
            // 
            lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            lblPage.AutoSize = true;
            lblPage.Font = new System.Drawing.Font("Calibri", 12F);
            lblPage.Location = new System.Drawing.Point(721, 983);
            lblPage.Name = "lblPage";
            lblPage.Size = new System.Drawing.Size(85, 19);
            lblPage.TabIndex = 14;
            lblPage.Text = "Page 1 de 1";
            // 
            // lblDate
            // 
            lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblDate.Location = new System.Drawing.Point(24, 1099);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(143, 0);
            lblDate.TabIndex = 26;
            lblDate.Text = "Date * lbldate";
            lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label125
            // 
            label125.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label125.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label125.Location = new System.Drawing.Point(393, 966);
            label125.Name = "label125";
            label125.Size = new System.Drawing.Size(405, 19);
            label125.TabIndex = 453;
            // 
            // label60
            // 
            label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label60.Location = new System.Drawing.Point(26, 586);
            label60.Name = "label60";
            label60.Size = new System.Drawing.Size(37, 19);
            label60.TabIndex = 374;
            label60.Text = "6";
            label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.Location = new System.Drawing.Point(393, 566);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(405, 19);
            label45.TabIndex = 373;
            // 
            // label46
            // 
            label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.Location = new System.Drawing.Point(200, 566);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(187, 19);
            label46.TabIndex = 372;
            // 
            // label47
            // 
            label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label47.Location = new System.Drawing.Point(70, 566);
            label47.Name = "label47";
            label47.Size = new System.Drawing.Size(124, 19);
            label47.TabIndex = 371;
            // 
            // label49
            // 
            label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label49.Location = new System.Drawing.Point(393, 546);
            label49.Name = "label49";
            label49.Size = new System.Drawing.Size(405, 19);
            label49.TabIndex = 369;
            // 
            // label50
            // 
            label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.Location = new System.Drawing.Point(200, 546);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(187, 19);
            label50.TabIndex = 368;
            // 
            // label51
            // 
            label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label51.Location = new System.Drawing.Point(70, 546);
            label51.Name = "label51";
            label51.Size = new System.Drawing.Size(124, 19);
            label51.TabIndex = 367;
            // 
            // label52
            // 
            label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label52.Location = new System.Drawing.Point(26, 546);
            label52.Name = "label52";
            label52.Size = new System.Drawing.Size(37, 19);
            label52.TabIndex = 366;
            label52.Text = "5";
            label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.Location = new System.Drawing.Point(393, 526);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(405, 19);
            label37.TabIndex = 365;
            // 
            // label38
            // 
            label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.Location = new System.Drawing.Point(200, 526);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(187, 19);
            label38.TabIndex = 364;
            // 
            // label39
            // 
            label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.Location = new System.Drawing.Point(70, 526);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(124, 19);
            label39.TabIndex = 363;
            // 
            // label41
            // 
            label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.Location = new System.Drawing.Point(393, 506);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(405, 19);
            label41.TabIndex = 361;
            // 
            // label42
            // 
            label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.Location = new System.Drawing.Point(200, 506);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(187, 19);
            label42.TabIndex = 360;
            // 
            // label43
            // 
            label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label43.Location = new System.Drawing.Point(70, 506);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(124, 19);
            label43.TabIndex = 359;
            // 
            // label44
            // 
            label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label44.Location = new System.Drawing.Point(26, 506);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(37, 19);
            label44.TabIndex = 358;
            label44.Text = "4";
            label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.Location = new System.Drawing.Point(393, 486);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(405, 19);
            label29.TabIndex = 357;
            // 
            // label30
            // 
            label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.Location = new System.Drawing.Point(200, 486);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(187, 19);
            label30.TabIndex = 356;
            // 
            // label31
            // 
            label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.Location = new System.Drawing.Point(70, 486);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(124, 19);
            label31.TabIndex = 355;
            // 
            // label33
            // 
            label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.Location = new System.Drawing.Point(393, 466);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(405, 19);
            label33.TabIndex = 353;
            // 
            // label34
            // 
            label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(200, 466);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(187, 19);
            label34.TabIndex = 352;
            // 
            // label35
            // 
            label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.Location = new System.Drawing.Point(70, 466);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(124, 19);
            label35.TabIndex = 351;
            // 
            // label36
            // 
            label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label36.Location = new System.Drawing.Point(26, 466);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(37, 19);
            label36.TabIndex = 350;
            label36.Text = "3";
            label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(393, 446);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(405, 19);
            label10.TabIndex = 349;
            // 
            // label22
            // 
            label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.Location = new System.Drawing.Point(200, 446);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(187, 19);
            label22.TabIndex = 348;
            // 
            // label23
            // 
            label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(70, 446);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(124, 19);
            label23.TabIndex = 347;
            // 
            // label25
            // 
            label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.Location = new System.Drawing.Point(393, 426);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(405, 19);
            label25.TabIndex = 345;
            // 
            // label26
            // 
            label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(200, 426);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(187, 19);
            label26.TabIndex = 344;
            // 
            // label27
            // 
            label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.Location = new System.Drawing.Point(70, 426);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(124, 19);
            label27.TabIndex = 343;
            // 
            // label28
            // 
            label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.Location = new System.Drawing.Point(27, 427);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(37, 19);
            label28.TabIndex = 342;
            label28.Text = "2";
            label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.Location = new System.Drawing.Point(393, 406);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(405, 19);
            label18.TabIndex = 341;
            // 
            // label19
            // 
            label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(200, 406);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(187, 19);
            label19.TabIndex = 340;
            // 
            // label20
            // 
            label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(70, 406);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(124, 19);
            label20.TabIndex = 339;
            // 
            // label14
            // 
            label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(393, 386);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(405, 19);
            label14.TabIndex = 337;
            // 
            // label15
            // 
            label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(200, 386);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(187, 19);
            label15.TabIndex = 336;
            // 
            // label16
            // 
            label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(70, 386);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(124, 19);
            label16.TabIndex = 335;
            // 
            // label17
            // 
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(27, 388);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(37, 19);
            label17.TabIndex = 334;
            label17.Text = "1";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(393, 361);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(405, 23);
            label13.TabIndex = 333;
            label13.Text = "Commentaires";
            // 
            // label12
            // 
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(200, 361);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(187, 23);
            label12.TabIndex = 332;
            label12.Text = "Contact";
            // 
            // label11
            // 
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(70, 361);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(124, 23);
            label11.TabIndex = 331;
            label11.Text = "Date";
            // 
            // label126
            // 
            label126.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label126.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label126.Location = new System.Drawing.Point(200, 966);
            label126.Name = "label126";
            label126.Size = new System.Drawing.Size(187, 19);
            label126.TabIndex = 452;
            // 
            // label127
            // 
            label127.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label127.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label127.Location = new System.Drawing.Point(69, 966);
            label127.Name = "label127";
            label127.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            label127.Size = new System.Drawing.Size(124, 19);
            label127.TabIndex = 451;
            // 
            // label129
            // 
            label129.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label129.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label129.Location = new System.Drawing.Point(393, 946);
            label129.Name = "label129";
            label129.Size = new System.Drawing.Size(405, 19);
            label129.TabIndex = 449;
            // 
            // label130
            // 
            label130.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label130.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label130.Location = new System.Drawing.Point(200, 946);
            label130.Name = "label130";
            label130.Size = new System.Drawing.Size(187, 19);
            label130.TabIndex = 448;
            // 
            // label131
            // 
            label131.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label131.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label131.Location = new System.Drawing.Point(69, 946);
            label131.Name = "label131";
            label131.Size = new System.Drawing.Size(124, 19);
            label131.TabIndex = 447;
            // 
            // label132
            // 
            label132.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label132.Location = new System.Drawing.Point(26, 946);
            label132.Name = "label132";
            label132.Size = new System.Drawing.Size(37, 19);
            label132.TabIndex = 446;
            label132.Text = "15";
            label132.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label117
            // 
            label117.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label117.Location = new System.Drawing.Point(393, 926);
            label117.Name = "label117";
            label117.Size = new System.Drawing.Size(405, 19);
            label117.TabIndex = 445;
            // 
            // label118
            // 
            label118.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label118.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label118.Location = new System.Drawing.Point(200, 926);
            label118.Name = "label118";
            label118.Size = new System.Drawing.Size(187, 19);
            label118.TabIndex = 444;
            // 
            // label119
            // 
            label119.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label119.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label119.Location = new System.Drawing.Point(69, 926);
            label119.Name = "label119";
            label119.Size = new System.Drawing.Size(124, 19);
            label119.TabIndex = 443;
            // 
            // label121
            // 
            label121.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label121.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label121.Location = new System.Drawing.Point(393, 906);
            label121.Name = "label121";
            label121.Size = new System.Drawing.Size(405, 19);
            label121.TabIndex = 441;
            // 
            // label122
            // 
            label122.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label122.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label122.Location = new System.Drawing.Point(200, 906);
            label122.Name = "label122";
            label122.Size = new System.Drawing.Size(187, 19);
            label122.TabIndex = 440;
            // 
            // label123
            // 
            label123.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label123.Location = new System.Drawing.Point(70, 906);
            label123.Name = "label123";
            label123.Size = new System.Drawing.Size(124, 19);
            label123.TabIndex = 439;
            // 
            // label124
            // 
            label124.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label124.Location = new System.Drawing.Point(27, 906);
            label124.Name = "label124";
            label124.Size = new System.Drawing.Size(37, 19);
            label124.TabIndex = 438;
            label124.Text = "14";
            label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label109
            // 
            label109.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label109.Location = new System.Drawing.Point(393, 886);
            label109.Name = "label109";
            label109.Size = new System.Drawing.Size(405, 19);
            label109.TabIndex = 437;
            // 
            // label110
            // 
            label110.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label110.Location = new System.Drawing.Point(200, 886);
            label110.Name = "label110";
            label110.Size = new System.Drawing.Size(187, 19);
            label110.TabIndex = 436;
            // 
            // label111
            // 
            label111.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label111.Location = new System.Drawing.Point(70, 886);
            label111.Name = "label111";
            label111.Size = new System.Drawing.Size(124, 19);
            label111.TabIndex = 435;
            // 
            // label113
            // 
            label113.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label113.Location = new System.Drawing.Point(393, 866);
            label113.Name = "label113";
            label113.Size = new System.Drawing.Size(405, 19);
            label113.TabIndex = 433;
            // 
            // label114
            // 
            label114.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label114.Location = new System.Drawing.Point(200, 866);
            label114.Name = "label114";
            label114.Size = new System.Drawing.Size(187, 19);
            label114.TabIndex = 432;
            // 
            // label115
            // 
            label115.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label115.Location = new System.Drawing.Point(70, 866);
            label115.Name = "label115";
            label115.Size = new System.Drawing.Size(124, 19);
            label115.TabIndex = 431;
            // 
            // label116
            // 
            label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label116.Location = new System.Drawing.Point(27, 866);
            label116.Name = "label116";
            label116.Size = new System.Drawing.Size(37, 19);
            label116.TabIndex = 430;
            label116.Text = "13";
            label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label101
            // 
            label101.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label101.Location = new System.Drawing.Point(393, 846);
            label101.Name = "label101";
            label101.Size = new System.Drawing.Size(405, 19);
            label101.TabIndex = 429;
            // 
            // label102
            // 
            label102.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label102.Location = new System.Drawing.Point(200, 846);
            label102.Name = "label102";
            label102.Size = new System.Drawing.Size(187, 19);
            label102.TabIndex = 428;
            // 
            // label103
            // 
            label103.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label103.Location = new System.Drawing.Point(69, 846);
            label103.Name = "label103";
            label103.Size = new System.Drawing.Size(124, 19);
            label103.TabIndex = 427;
            // 
            // label105
            // 
            label105.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label105.Location = new System.Drawing.Point(393, 826);
            label105.Name = "label105";
            label105.Size = new System.Drawing.Size(405, 19);
            label105.TabIndex = 425;
            // 
            // label106
            // 
            label106.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label106.Location = new System.Drawing.Point(200, 826);
            label106.Name = "label106";
            label106.Size = new System.Drawing.Size(187, 19);
            label106.TabIndex = 424;
            // 
            // label107
            // 
            label107.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label107.Location = new System.Drawing.Point(69, 826);
            label107.Name = "label107";
            label107.Size = new System.Drawing.Size(124, 19);
            label107.TabIndex = 423;
            // 
            // label108
            // 
            label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label108.Location = new System.Drawing.Point(26, 826);
            label108.Name = "label108";
            label108.Size = new System.Drawing.Size(37, 19);
            label108.TabIndex = 422;
            label108.Text = "12";
            label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label93
            // 
            label93.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label93.Location = new System.Drawing.Point(393, 806);
            label93.Name = "label93";
            label93.Size = new System.Drawing.Size(405, 19);
            label93.TabIndex = 421;
            // 
            // label94
            // 
            label94.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label94.Location = new System.Drawing.Point(200, 806);
            label94.Name = "label94";
            label94.Size = new System.Drawing.Size(187, 19);
            label94.TabIndex = 420;
            // 
            // label95
            // 
            label95.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label95.Location = new System.Drawing.Point(70, 806);
            label95.Name = "label95";
            label95.Size = new System.Drawing.Size(124, 19);
            label95.TabIndex = 419;
            // 
            // label97
            // 
            label97.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label97.Location = new System.Drawing.Point(393, 786);
            label97.Name = "label97";
            label97.Size = new System.Drawing.Size(405, 19);
            label97.TabIndex = 417;
            // 
            // label98
            // 
            label98.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label98.Location = new System.Drawing.Point(200, 786);
            label98.Name = "label98";
            label98.Size = new System.Drawing.Size(187, 19);
            label98.TabIndex = 416;
            // 
            // label99
            // 
            label99.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label99.Location = new System.Drawing.Point(70, 786);
            label99.Name = "label99";
            label99.Size = new System.Drawing.Size(124, 19);
            label99.TabIndex = 415;
            // 
            // label100
            // 
            label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label100.Location = new System.Drawing.Point(26, 786);
            label100.Name = "label100";
            label100.Size = new System.Drawing.Size(37, 19);
            label100.TabIndex = 414;
            label100.Text = "11";
            label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label85
            // 
            label85.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label85.Location = new System.Drawing.Point(393, 766);
            label85.Name = "label85";
            label85.Size = new System.Drawing.Size(405, 19);
            label85.TabIndex = 413;
            // 
            // label86
            // 
            label86.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label86.Location = new System.Drawing.Point(200, 766);
            label86.Name = "label86";
            label86.Size = new System.Drawing.Size(187, 19);
            label86.TabIndex = 412;
            // 
            // label87
            // 
            label87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label87.Location = new System.Drawing.Point(69, 766);
            label87.Name = "label87";
            label87.Size = new System.Drawing.Size(124, 19);
            label87.TabIndex = 411;
            // 
            // label89
            // 
            label89.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label89.Location = new System.Drawing.Point(393, 746);
            label89.Name = "label89";
            label89.Size = new System.Drawing.Size(405, 19);
            label89.TabIndex = 409;
            // 
            // label90
            // 
            label90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label90.Location = new System.Drawing.Point(200, 746);
            label90.Name = "label90";
            label90.Size = new System.Drawing.Size(187, 19);
            label90.TabIndex = 408;
            // 
            // label91
            // 
            label91.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label91.Location = new System.Drawing.Point(69, 746);
            label91.Name = "label91";
            label91.Size = new System.Drawing.Size(124, 19);
            label91.TabIndex = 407;
            // 
            // label92
            // 
            label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label92.Location = new System.Drawing.Point(27, 746);
            label92.Name = "label92";
            label92.Size = new System.Drawing.Size(37, 19);
            label92.TabIndex = 406;
            label92.Text = "10";
            label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            label77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label77.Location = new System.Drawing.Point(393, 726);
            label77.Name = "label77";
            label77.Size = new System.Drawing.Size(405, 19);
            label77.TabIndex = 405;
            // 
            // label78
            // 
            label78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label78.Location = new System.Drawing.Point(200, 726);
            label78.Name = "label78";
            label78.Size = new System.Drawing.Size(187, 19);
            label78.TabIndex = 404;
            // 
            // label79
            // 
            label79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label79.Location = new System.Drawing.Point(70, 726);
            label79.Name = "label79";
            label79.Size = new System.Drawing.Size(124, 19);
            label79.TabIndex = 403;
            // 
            // label81
            // 
            label81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label81.Location = new System.Drawing.Point(393, 706);
            label81.Name = "label81";
            label81.Size = new System.Drawing.Size(405, 19);
            label81.TabIndex = 401;
            // 
            // label82
            // 
            label82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label82.Location = new System.Drawing.Point(200, 706);
            label82.Name = "label82";
            label82.Size = new System.Drawing.Size(187, 19);
            label82.TabIndex = 400;
            // 
            // label83
            // 
            label83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label83.Location = new System.Drawing.Point(70, 706);
            label83.Name = "label83";
            label83.Size = new System.Drawing.Size(124, 19);
            label83.TabIndex = 399;
            // 
            // label84
            // 
            label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label84.Location = new System.Drawing.Point(26, 706);
            label84.Name = "label84";
            label84.Size = new System.Drawing.Size(37, 19);
            label84.TabIndex = 398;
            label84.Text = "9";
            label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            label69.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label69.Location = new System.Drawing.Point(393, 686);
            label69.Name = "label69";
            label69.Size = new System.Drawing.Size(405, 19);
            label69.TabIndex = 397;
            // 
            // label70
            // 
            label70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label70.Location = new System.Drawing.Point(200, 686);
            label70.Name = "label70";
            label70.Size = new System.Drawing.Size(187, 19);
            label70.TabIndex = 396;
            // 
            // label71
            // 
            label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label71.Location = new System.Drawing.Point(70, 686);
            label71.Name = "label71";
            label71.Size = new System.Drawing.Size(124, 19);
            label71.TabIndex = 395;
            // 
            // label73
            // 
            label73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label73.Location = new System.Drawing.Point(393, 666);
            label73.Name = "label73";
            label73.Size = new System.Drawing.Size(405, 19);
            label73.TabIndex = 393;
            // 
            // label74
            // 
            label74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label74.Location = new System.Drawing.Point(200, 666);
            label74.Name = "label74";
            label74.Size = new System.Drawing.Size(187, 19);
            label74.TabIndex = 392;
            // 
            // label75
            // 
            label75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label75.Location = new System.Drawing.Point(70, 666);
            label75.Name = "label75";
            label75.Size = new System.Drawing.Size(124, 19);
            label75.TabIndex = 391;
            // 
            // label76
            // 
            label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label76.Location = new System.Drawing.Point(27, 666);
            label76.Name = "label76";
            label76.Size = new System.Drawing.Size(37, 19);
            label76.TabIndex = 390;
            label76.Text = "8";
            label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label61.Location = new System.Drawing.Point(393, 646);
            label61.Name = "label61";
            label61.Size = new System.Drawing.Size(405, 19);
            label61.TabIndex = 389;
            // 
            // label62
            // 
            label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label62.Location = new System.Drawing.Point(200, 646);
            label62.Name = "label62";
            label62.Size = new System.Drawing.Size(187, 19);
            label62.TabIndex = 388;
            // 
            // label63
            // 
            label63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label63.Location = new System.Drawing.Point(70, 646);
            label63.Name = "label63";
            label63.Size = new System.Drawing.Size(124, 19);
            label63.TabIndex = 387;
            // 
            // label65
            // 
            label65.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label65.Location = new System.Drawing.Point(393, 626);
            label65.Name = "label65";
            label65.Size = new System.Drawing.Size(405, 19);
            label65.TabIndex = 385;
            // 
            // label66
            // 
            label66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label66.Location = new System.Drawing.Point(200, 626);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(187, 19);
            label66.TabIndex = 384;
            // 
            // label67
            // 
            label67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label67.Location = new System.Drawing.Point(70, 626);
            label67.Name = "label67";
            label67.Size = new System.Drawing.Size(124, 19);
            label67.TabIndex = 383;
            // 
            // label68
            // 
            label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label68.Location = new System.Drawing.Point(26, 626);
            label68.Name = "label68";
            label68.Size = new System.Drawing.Size(37, 19);
            label68.TabIndex = 382;
            label68.Text = "7";
            label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label53.Location = new System.Drawing.Point(393, 606);
            label53.Name = "label53";
            label53.Size = new System.Drawing.Size(405, 19);
            label53.TabIndex = 381;
            // 
            // label54
            // 
            label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label54.Location = new System.Drawing.Point(200, 606);
            label54.Name = "label54";
            label54.Size = new System.Drawing.Size(187, 19);
            label54.TabIndex = 380;
            // 
            // label55
            // 
            label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label55.Location = new System.Drawing.Point(70, 606);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(124, 19);
            label55.TabIndex = 379;
            // 
            // label57
            // 
            label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label57.Location = new System.Drawing.Point(393, 586);
            label57.Name = "label57";
            label57.Size = new System.Drawing.Size(405, 19);
            label57.TabIndex = 377;
            // 
            // label58
            // 
            label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label58.Location = new System.Drawing.Point(200, 586);
            label58.Name = "label58";
            label58.Size = new System.Drawing.Size(187, 19);
            label58.TabIndex = 376;
            // 
            // label59
            // 
            label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label59.Location = new System.Drawing.Point(70, 586);
            label59.Name = "label59";
            label59.Size = new System.Drawing.Size(124, 19);
            label59.TabIndex = 375;
            // 
            // label133
            // 
            label133.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label133.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label133.Location = new System.Drawing.Point(210, 222);
            label133.Name = "label133";
            label133.Size = new System.Drawing.Size(527, 19);
            label133.TabIndex = 468;
            // 
            // label134
            // 
            label134.AutoSize = true;
            label134.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label134.Location = new System.Drawing.Point(14, 222);
            label134.Name = "label134";
            label134.Size = new System.Drawing.Size(53, 18);
            label134.TabIndex = 467;
            label134.Text = "Photo";
            // 
            // label137
            // 
            label137.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label137.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label137.Location = new System.Drawing.Point(210, 202);
            label137.Name = "label137";
            label137.Size = new System.Drawing.Size(527, 19);
            label137.TabIndex = 464;
            // 
            // label138
            // 
            label138.AutoSize = true;
            label138.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label138.Location = new System.Drawing.Point(14, 202);
            label138.Name = "label138";
            label138.Size = new System.Drawing.Size(186, 18);
            label138.TabIndex = 463;
            label138.Text = "Dessin tel que construit";
            // 
            // label141
            // 
            label141.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label141.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label141.Location = new System.Drawing.Point(210, 182);
            label141.Name = "label141";
            label141.Size = new System.Drawing.Size(527, 19);
            label141.TabIndex = 460;
            // 
            // label142
            // 
            label142.AutoSize = true;
            label142.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label142.Location = new System.Drawing.Point(14, 182);
            label142.Name = "label142";
            label142.Size = new System.Drawing.Size(132, 18);
            label142.TabIndex = 459;
            label142.Text = "Liste de matériel";
            // 
            // label146
            // 
            label146.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label146.Location = new System.Drawing.Point(14, 159);
            label146.Name = "label146";
            label146.Size = new System.Drawing.Size(724, 20);
            label146.TabIndex = 455;
            label146.Text = "obligatoires pour fermeture du dossier";
            label146.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label145
            // 
            label145.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label145.Location = new System.Drawing.Point(14, 307);
            label145.Name = "label145";
            label145.Size = new System.Drawing.Size(455, 19);
            label145.TabIndex = 478;
            label145.Text = "Dessins mécaniques";
            // 
            // label149
            // 
            label149.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label149.Location = new System.Drawing.Point(14, 288);
            label149.Name = "label149";
            label149.Size = new System.Drawing.Size(455, 18);
            label149.TabIndex = 475;
            label149.Text = "Liste de matériel atelier";
            // 
            // label150
            // 
            label150.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label150.Location = new System.Drawing.Point(-27, 286);
            label150.Name = "label150";
            label150.Size = new System.Drawing.Size(37, 20);
            label150.TabIndex = 474;
            label150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label151
            // 
            label151.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label151.Location = new System.Drawing.Point(615, 267);
            label151.Name = "label151";
            label151.Size = new System.Drawing.Size(166, 20);
            label151.TabIndex = 473;
            label151.Text = "Nombre de pages";
            // 
            // label152
            // 
            label152.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label152.Location = new System.Drawing.Point(14, 268);
            label152.Name = "label152";
            label152.Size = new System.Drawing.Size(455, 19);
            label152.TabIndex = 472;
            label152.Text = "Description";
            // 
            // label154
            // 
            label154.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label154.Location = new System.Drawing.Point(14, 248);
            label154.Name = "label154";
            label154.Size = new System.Drawing.Size(766, 18);
            label154.TabIndex = 470;
            label154.Text = "Documents pour fin de fabrication";
            label154.Click += new System.EventHandler(label154_Click);
            // 
            // label139
            // 
            label139.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label139.Location = new System.Drawing.Point(472, 268);
            label139.Name = "label139";
            label139.Size = new System.Drawing.Size(137, 19);
            label139.TabIndex = 480;
            label139.Text = "Date";
            // 
            // label143
            // 
            label143.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label143.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label143.Location = new System.Drawing.Point(472, 288);
            label143.Name = "label143";
            label143.Size = new System.Drawing.Size(137, 18);
            label143.TabIndex = 482;
            // 
            // label147
            // 
            label147.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label147.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label147.Location = new System.Drawing.Point(615, 288);
            label147.Name = "label147";
            label147.Size = new System.Drawing.Size(137, 18);
            label147.TabIndex = 481;
            // 
            // label148
            // 
            label148.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label148.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label148.Location = new System.Drawing.Point(472, 307);
            label148.Name = "label148";
            label148.Size = new System.Drawing.Size(137, 19);
            label148.TabIndex = 484;
            // 
            // label153
            // 
            label153.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label153.Location = new System.Drawing.Point(615, 307);
            label153.Name = "label153";
            label153.Size = new System.Drawing.Size(137, 20);
            label153.TabIndex = 483;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(11, 54);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(104, 16);
            label8.TabIndex = 491;
            label8.Text = "Nom du projet";
            // 
            // lblTitreCommande
            // 
            lblTitreCommande.AutoSize = true;
            lblTitreCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreCommande.Location = new System.Drawing.Point(121, 54);
            lblTitreCommande.Name = "lblTitreCommande";
            lblTitreCommande.Size = new System.Drawing.Size(134, 16);
            lblTitreCommande.TabIndex = 489;
            lblTitreCommande.Text = "lblTitreCommande";
            // 
            // lblTitrePage
            // 
            lblTitrePage.AutoSize = true;
            lblTitrePage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitrePage.ForeColor = System.Drawing.Color.Navy;
            lblTitrePage.Location = new System.Drawing.Point(71, 9);
            lblTitrePage.Name = "lblTitrePage";
            lblTitrePage.Size = new System.Drawing.Size(289, 23);
            lblTitrePage.TabIndex = 485;
            lblTitrePage.Text = "Fabrication - Fermeture Mécanique";
            // 
            // lblNoSoum
            // 
            lblNoSoum.AutoSize = true;
            lblNoSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblNoSoum.Location = new System.Drawing.Point(668, 122);
            lblNoSoum.Name = "lblNoSoum";
            lblNoSoum.Size = new System.Drawing.Size(83, 16);
            lblNoSoum.TabIndex = 487;
            lblNoSoum.Text = "lblNoSoum";
            // 
            // lblNoBC
            // 
            lblNoBC.AutoSize = true;
            lblNoBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblNoBC.Location = new System.Drawing.Point(668, 141);
            lblNoBC.Name = "lblNoBC";
            lblNoBC.Size = new System.Drawing.Size(64, 16);
            lblNoBC.TabIndex = 490;
            lblNoBC.Text = "lblNoBC";
            // 
            // lblTitreBC
            // 
            lblTitreBC.AutoSize = true;
            lblTitreBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreBC.Location = new System.Drawing.Point(576, 140);
            lblTitreBC.Name = "lblTitreBC";
            lblTitreBC.Size = new System.Drawing.Size(76, 16);
            lblTitreBC.TabIndex = 488;
            lblTitreBC.Text = "lblTitreBC";
            // 
            // lblTitreNoSoum
            // 
            lblTitreNoSoum.AutoSize = true;
            lblTitreNoSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreNoSoum.Location = new System.Drawing.Point(576, 121);
            lblTitreNoSoum.Name = "lblTitreNoSoum";
            lblTitreNoSoum.Size = new System.Drawing.Size(115, 16);
            lblTitreNoSoum.TabIndex = 486;
            lblTitreNoSoum.Text = "lblTitreNoSoum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(678, 80);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 16);
            label5.TabIndex = 506;
            label5.Text = "Heure";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(734, 80);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 16);
            label6.TabIndex = 507;
            label6.Text = "88:88:88";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label9.Location = new System.Drawing.Point(536, 76);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(81, 16);
            label9.TabIndex = 508;
            label9.Text = "8888-88-88";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(424, 76);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(109, 16);
            label7.TabIndex = 509;
            label7.Text = "Date fermeture";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblClient.Location = new System.Drawing.Point(81, 100);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(63, 16);
            lblClient.TabIndex = 503;
            lblClient.Text = "lblClient";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lblFax.Location = new System.Drawing.Point(536, 101);
            lblFax.Name = "lblFax";
            lblFax.Size = new System.Drawing.Size(38, 15);
            lblFax.TabIndex = 492;
            lblFax.Text = "lblFax";
            // 
            // lblTitreFax
            // 
            lblTitreFax.AutoSize = true;
            lblTitreFax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreFax.Location = new System.Drawing.Point(505, 101);
            lblTitreFax.Name = "lblTitreFax";
            lblTitreFax.Size = new System.Drawing.Size(25, 15);
            lblTitreFax.TabIndex = 494;
            lblTitreFax.Text = "Fax";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lblTel.Location = new System.Drawing.Point(364, 101);
            lblTel.Name = "lblTel";
            lblTel.Size = new System.Drawing.Size(35, 15);
            lblTel.TabIndex = 498;
            lblTel.Text = "lblTel";
            // 
            // lblTitreTel
            // 
            lblTitreTel.AutoSize = true;
            lblTitreTel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreTel.Location = new System.Drawing.Point(335, 101);
            lblTitreTel.Name = "lblTitreTel";
            lblTitreTel.Size = new System.Drawing.Size(25, 15);
            lblTitreTel.TabIndex = 501;
            lblTitreTel.Text = "Tél.";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblContact.Location = new System.Drawing.Point(81, 116);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(76, 16);
            lblContact.TabIndex = 500;
            lblContact.Text = "lblContact";
            // 
            // lblTitreContact
            // 
            lblTitreContact.AutoSize = true;
            lblTitreContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreContact.Location = new System.Drawing.Point(16, 115);
            lblTitreContact.Name = "lblTitreContact";
            lblTitreContact.Size = new System.Drawing.Size(59, 16);
            lblTitreContact.TabIndex = 499;
            lblTitreContact.Text = "Contact";
            // 
            // lblTitreClient
            // 
            lblTitreClient.AutoSize = true;
            lblTitreClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreClient.Location = new System.Drawing.Point(16, 99);
            lblTitreClient.Name = "lblTitreClient";
            lblTitreClient.Size = new System.Drawing.Size(46, 16);
            lblTitreClient.TabIndex = 502;
            lblTitreClient.Text = "Client";
            // 
            // lbTitrelProjet
            // 
            lbTitrelProjet.AutoSize = true;
            lbTitrelProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lbTitrelProjet.Location = new System.Drawing.Point(16, 137);
            lbTitrelProjet.Name = "lbTitrelProjet";
            lbTitrelProjet.Size = new System.Drawing.Size(48, 16);
            lbTitrelProjet.TabIndex = 504;
            lbTitrelProjet.Text = "Projet";
            // 
            // lblProjet
            // 
            lblProjet.AutoSize = true;
            lblProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblProjet.Location = new System.Drawing.Point(85, 136);
            lblProjet.Name = "lblProjet";
            lblProjet.Size = new System.Drawing.Size(65, 16);
            lblProjet.TabIndex = 505;
            lblProjet.Text = "lblProjet";
            // 
            // lblDateOuverture
            // 
            lblDateOuverture.AutoSize = true;
            lblDateOuverture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblDateOuverture.Location = new System.Drawing.Point(138, 76);
            lblDateOuverture.Name = "lblDateOuverture";
            lblDateOuverture.Size = new System.Drawing.Size(81, 16);
            lblDateOuverture.TabIndex = 495;
            lblDateOuverture.Text = "8888-88-88";
            // 
            // lblDateRequise
            // 
            lblDateRequise.AutoSize = true;
            lblDateRequise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblDateRequise.Location = new System.Drawing.Point(336, 76);
            lblDateRequise.Name = "lblDateRequise";
            lblDateRequise.Size = new System.Drawing.Size(81, 16);
            lblDateRequise.TabIndex = 493;
            lblDateRequise.Text = "8888-88-88";
            // 
            // lbltitredatereq
            // 
            lbltitredatereq.AutoSize = true;
            lbltitredatereq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lbltitredatereq.Location = new System.Drawing.Point(238, 76);
            lbltitredatereq.Name = "lbltitredatereq";
            lbltitredatereq.Size = new System.Drawing.Size(96, 16);
            lbltitredatereq.TabIndex = 497;
            lbltitredatereq.Text = "Date requise";
            // 
            // lbltitredate
            // 
            lbltitredate.AutoSize = true;
            lbltitredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lbltitredate.Location = new System.Drawing.Point(14, 76);
            lbltitredate.Name = "lbltitredate";
            lbltitredate.Size = new System.Drawing.Size(122, 16);
            lbltitredate.TabIndex = 496;
            lbltitredate.Text = "Date d\'ouverture";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.Location = new System.Drawing.Point(639, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 72);
            pictureBox1.TabIndex = 510;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // ViewFermeMecanique
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1011);
            Controls.Add(lblPage);
            Controls.Add(lblPiedPage);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(lblDate);
            Controls.Add(lblTitreCommande);
            Controls.Add(lblTitrePage);
            Controls.Add(lblNoSoum);
            Controls.Add(lblNoBC);
            Controls.Add(lblTitreBC);
            Controls.Add(lblTitreNoSoum);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(lblClient);
            Controls.Add(lblFax);
            Controls.Add(lblTitreFax);
            Controls.Add(lblTel);
            Controls.Add(lblTitreTel);
            Controls.Add(lblContact);
            Controls.Add(lblTitreContact);
            Controls.Add(lblTitreClient);
            Controls.Add(lbTitrelProjet);
            Controls.Add(lblProjet);
            Controls.Add(lblDateOuverture);
            Controls.Add(lblDateRequise);
            Controls.Add(lbltitredatereq);
            Controls.Add(lbltitredate);
            Controls.Add(label148);
            Controls.Add(label153);
            Controls.Add(label143);
            Controls.Add(label147);
            Controls.Add(label139);
            Controls.Add(label145);
            Controls.Add(label149);
            Controls.Add(label150);
            Controls.Add(label151);
            Controls.Add(label152);
            Controls.Add(label154);
            Controls.Add(label133);
            Controls.Add(label134);
            Controls.Add(label137);
            Controls.Add(label138);
            Controls.Add(label141);
            Controls.Add(label142);
            Controls.Add(label146);
            Controls.Add(label125);
            Controls.Add(label60);
            Controls.Add(label45);
            Controls.Add(label46);
            Controls.Add(label47);
            Controls.Add(label49);
            Controls.Add(label50);
            Controls.Add(label51);
            Controls.Add(label52);
            Controls.Add(label37);
            Controls.Add(label38);
            Controls.Add(label39);
            Controls.Add(label41);
            Controls.Add(label42);
            Controls.Add(label43);
            Controls.Add(label44);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(label35);
            Controls.Add(label36);
            Controls.Add(label10);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label126);
            Controls.Add(label127);
            Controls.Add(label129);
            Controls.Add(label130);
            Controls.Add(label131);
            Controls.Add(label132);
            Controls.Add(label117);
            Controls.Add(label118);
            Controls.Add(label119);
            Controls.Add(label121);
            Controls.Add(label122);
            Controls.Add(label123);
            Controls.Add(label124);
            Controls.Add(label109);
            Controls.Add(label110);
            Controls.Add(label111);
            Controls.Add(label113);
            Controls.Add(label114);
            Controls.Add(label115);
            Controls.Add(label116);
            Controls.Add(label101);
            Controls.Add(label102);
            Controls.Add(label103);
            Controls.Add(label105);
            Controls.Add(label106);
            Controls.Add(label107);
            Controls.Add(label108);
            Controls.Add(label93);
            Controls.Add(label94);
            Controls.Add(label95);
            Controls.Add(label97);
            Controls.Add(label98);
            Controls.Add(label99);
            Controls.Add(label100);
            Controls.Add(label85);
            Controls.Add(label86);
            Controls.Add(label87);
            Controls.Add(label89);
            Controls.Add(label90);
            Controls.Add(label91);
            Controls.Add(label92);
            Controls.Add(label77);
            Controls.Add(label78);
            Controls.Add(label79);
            Controls.Add(label81);
            Controls.Add(label82);
            Controls.Add(label83);
            Controls.Add(label84);
            Controls.Add(label69);
            Controls.Add(label70);
            Controls.Add(label71);
            Controls.Add(label73);
            Controls.Add(label74);
            Controls.Add(label75);
            Controls.Add(label76);
            Controls.Add(label61);
            Controls.Add(label62);
            Controls.Add(label63);
            Controls.Add(label65);
            Controls.Add(label66);
            Controls.Add(label67);
            Controls.Add(label68);
            Controls.Add(label53);
            Controls.Add(label54);
            Controls.Add(label55);
            Controls.Add(label57);
            Controls.Add(label58);
            Controls.Add(label59);
            ForeColor = System.Drawing.Color.Navy;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewFermeMecanique";
            Text = "ViewFermeMecanique";
            Load += new System.EventHandler(ViewFermeMecanique_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label lblPiedPage;
        internal static Label lblPage;
        internal static Label lblDate;
        internal static Label label125;
        internal static Label label60;
        internal static Label label45;
        internal static Label label46;
        internal static Label label47;
        internal static Label label49;
        internal static Label label50;
        internal static Label label51;
        internal static Label label52;
        internal static Label label37;
        internal static Label label38;
        internal static Label label39;
        internal static Label label41;
        internal static Label label42;
        internal static Label label43;
        internal static Label label44;
        internal static Label label29;
        internal static Label label30;
        internal static Label label31;
        internal static Label label33;
        internal static Label label34;
        internal static Label label35;
        internal static Label label36;
        internal static Label label10;
        internal static Label label22;
        internal static Label label23;
        internal static Label label25;
        internal static Label label26;
        internal static Label label27;
        internal static Label label28;
        internal static Label label18;
        internal static Label label19;
        internal static Label label20;
        internal static Label label14;
        internal static Label label15;
        internal static Label label16;
        internal static Label label17;
        internal static Label label13;
        internal static Label label12;
        internal static Label label11;
        internal static Label label126;
        internal static Label label127;
        internal static Label label129;
        internal static Label label130;
        internal static Label label131;
        internal static Label label132;
        internal static Label label117;
        internal static Label label118;
        internal static Label label119;
        internal static Label label121;
        internal static Label label122;
        internal static Label label123;
        internal static Label label124;
        internal static Label label109;
        internal static Label label110;
        internal static Label label111;
        internal static Label label113;
        internal static Label label114;
        internal static Label label115;
        internal static Label label116;
        internal static Label label101;
        internal static Label label102;
        internal static Label label103;
        internal static Label label105;
        internal static Label label106;
        internal static Label label107;
        internal static Label label108;
        internal static Label label93;
        internal static Label label94;
        internal static Label label95;
        internal static Label label97;
        internal static Label label98;
        internal static Label label99;
        internal static Label label100;
        internal static Label label85;
        internal static Label label86;
        internal static Label label87;
        internal static Label label89;
        internal static Label label90;
        internal static Label label91;
        internal static Label label92;
        internal static Label label77;
        internal static Label label78;
        internal static Label label79;
        internal static Label label81;
        internal static Label label82;
        internal static Label label83;
        internal static Label label84;
        internal static Label label69;
        internal static Label label70;
        internal static Label label71;
        internal static Label label73;
        internal static Label label74;
        internal static Label label75;
        internal static Label label76;
        internal static Label label61;
        internal static Label label62;
        internal static Label label63;
        internal static Label label65;
        internal static Label label66;
        internal static Label label67;
        internal static Label label68;
        internal static Label label53;
        internal static Label label54;
        internal static Label label55;
        internal static Label label57;
        internal static Label label58;
        internal static Label label59;
        internal static Label label133;
        internal static Label label134;
        internal static Label label137;
        internal static Label label138;
        internal static Label label141;
        internal static Label label142;
        internal static Label label146;
        internal static Label label145;
        internal static Label label149;
        internal static Label label150;
        internal static Label label151;
        internal static Label label152;
        internal static Label label154;
        internal static Label label139;
        internal static Label label143;
        internal static Label label147;
        internal static Label label148;
        internal static Label label153;
        internal static Label label8;
        internal static Label lblTitreCommande;
        internal static Label lblTitrePage;
        internal static Label lblNoSoum;
        internal static Label lblNoBC;
        internal static Label lblTitreBC;
        internal static Label lblTitreNoSoum;
        internal static Label label5;
        internal static Label label6;
        internal static Label label9;
        internal static Label label7;
        internal static Label lblClient;
        internal static Label lblFax;
        internal static Label lblTitreFax;
        internal static Label lblTel;
        internal static Label lblTitreTel;
        internal static Label lblContact;
        internal static Label lblTitreContact;
        internal static Label lblTitreClient;
        internal static Label lbTitrelProjet;
        internal static Label lblProjet;
        internal static Label lblDateOuverture;
        internal static Label lblDateRequise;
        internal static Label lbltitredatereq;
        internal static Label lbltitredate;
        internal static PictureBox pictureBox1;
        private string NoProjet;
        private string Date;
        private string IDClient;
        private string NomClient;
        private string Compagnie;
        private string Telephonne;
        private string Fax;
        private string NomContact;
        private string IDSoumission;
        private string IDProjet;
        private string NoBonCommande;
        private string Attention;
        private string DateRequise;
        private string DateCommande;
        public string DateOuverture;
        public static Label lblProjetNom { get; internal set; }
        public ViewFermeMecanique()
        {
            InitializeComponent();
            IDClient = ControleurServeur.ViewFermeMecanique.lblClient.Text;
            NomContact = ControleurServeur.ViewFermeMecanique.lblContact.Text;
            Date = ControleurServeur.ViewFermeMecanique.lblDate.Text;
            Telephonne = ControleurServeur.ViewFermeMecanique.lblTel.Text;
            IDSoumission = ControleurServeur.ViewFermeMecanique.lblNoSoum.Text;
            Fax = ControleurServeur.ViewFermeMecanique.lblFax.Text;
            NoBonCommande = ControleurServeur.ViewFermeMecanique.lblProjet.Text;
            DateCommande = ControleurServeur.ViewFermeMecanique.lblProjetNom.Text;
            DateOuverture = ControleurServeur.ViewFermeMecanique.lblDateOuverture.Text;
            DateRequise = ControleurServeur.ViewFermeMecanique.lblDate.Text;
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        public ViewFermeMecanique(string noProjet, string date, string iDClient, string nomClient, 
            string compagnie, string telephonne, string fax, string nomContact, string iDSoumission, 
            string iDProjet, string noBonCommande, string attention, string dateRequise, string dateCommande)
        {
            InitializeComponent();
            NoProjet = noProjet;
            Date = date;
            IDClient = iDClient;
            NomClient = nomClient;
            Compagnie = compagnie;
            Telephonne = telephonne;
            Fax = fax;
            NomContact = nomContact;
            IDSoumission = iDSoumission;
            IDProjet = iDProjet;
            NoBonCommande = noBonCommande;
            Attention = attention;
            DateRequise = dateRequise;
            DateCommande = dateCommande;
        }
       private void label154_Click(object sender, EventArgs e)
        {
        }
        private void ViewFermeMecanique_Load(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            lblClient.Text = NomClient;
            lblContact.Text = NomContact;
            lblDate.Text = Date;
            lblTel.Text = Telephonne;
            lblNoSoum.Text =IDSoumission ;
            lblFax.Text = Fax;
            lblNoBC.Text = NoBonCommande;
            lblTitreCommande.Text = IDProjet;
            lblDateOuverture.Text = DateCommande;
            lblProjet.Text = NoProjet;
            lblTitreCommande.Text = "";
            lblTitreNoSoum.Text = "Soumission";
            lblTitreBC.Text="B.C.#";
            lblDateRequise.Text = DateRequise;
            lblPiedPage.Text = Program.IdNomEmploye;
            if (Program.IdGroupe == 0x18) { lblPiedPage.Text += "Mode dévelopement"; }
            label9.Text = Program.ConvertDateTexte(DateRequise).AddDays(+2).ToShortDateString();
        }
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
