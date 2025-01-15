
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
    public  class ViewProgrammation : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProgrammation));
            lblNoSoum = new System.Windows.Forms.Label();
            lblPiedPage = new System.Windows.Forms.Label();
            lblTitreCommande = new System.Windows.Forms.Label();
            lblNoBC = new System.Windows.Forms.Label();
            lblTitreNoSoum = new System.Windows.Forms.Label();
            lblTitreBC = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblPage = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
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
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblProjet = new System.Windows.Forms.Label();
            lbTitrelProjet = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblTitreClient = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            lblDateOuverture = new System.Windows.Forms.Label();
            lblTitreContact = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            lblTitreTel = new System.Windows.Forms.Label();
            lblTel = new System.Windows.Forms.Label();
            lbltitredate = new System.Windows.Forms.Label();
            lbltitredatereq = new System.Windows.Forms.Label();
            lblDateRequise = new System.Windows.Forms.Label();
            lblTitreFax = new System.Windows.Forms.Label();
            lblFax = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label117 = new System.Windows.Forms.Label();
            label118 = new System.Windows.Forms.Label();
            label119 = new System.Windows.Forms.Label();
            label121 = new System.Windows.Forms.Label();
            label122 = new System.Windows.Forms.Label();
            label123 = new System.Windows.Forms.Label();
            label109 = new System.Windows.Forms.Label();
            label110 = new System.Windows.Forms.Label();
            label111 = new System.Windows.Forms.Label();
            label112 = new System.Windows.Forms.Label();
            label113 = new System.Windows.Forms.Label();
            label114 = new System.Windows.Forms.Label();
            label115 = new System.Windows.Forms.Label();
            label101 = new System.Windows.Forms.Label();
            label102 = new System.Windows.Forms.Label();
            label103 = new System.Windows.Forms.Label();
            label105 = new System.Windows.Forms.Label();
            label106 = new System.Windows.Forms.Label();
            label107 = new System.Windows.Forms.Label();
            label93 = new System.Windows.Forms.Label();
            label94 = new System.Windows.Forms.Label();
            label95 = new System.Windows.Forms.Label();
            label97 = new System.Windows.Forms.Label();
            label98 = new System.Windows.Forms.Label();
            label99 = new System.Windows.Forms.Label();
            label85 = new System.Windows.Forms.Label();
            label86 = new System.Windows.Forms.Label();
            label87 = new System.Windows.Forms.Label();
            label88 = new System.Windows.Forms.Label();
            label89 = new System.Windows.Forms.Label();
            label90 = new System.Windows.Forms.Label();
            label91 = new System.Windows.Forms.Label();
            label77 = new System.Windows.Forms.Label();
            label78 = new System.Windows.Forms.Label();
            label79 = new System.Windows.Forms.Label();
            label80 = new System.Windows.Forms.Label();
            label81 = new System.Windows.Forms.Label();
            label82 = new System.Windows.Forms.Label();
            label83 = new System.Windows.Forms.Label();
            label69 = new System.Windows.Forms.Label();
            label70 = new System.Windows.Forms.Label();
            label71 = new System.Windows.Forms.Label();
            label72 = new System.Windows.Forms.Label();
            label73 = new System.Windows.Forms.Label();
            label74 = new System.Windows.Forms.Label();
            label75 = new System.Windows.Forms.Label();
            label61 = new System.Windows.Forms.Label();
            label62 = new System.Windows.Forms.Label();
            label63 = new System.Windows.Forms.Label();
            label64 = new System.Windows.Forms.Label();
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
            lblTitrePage = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label133 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label56 = new System.Windows.Forms.Label();
            label40 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label48 = new System.Windows.Forms.Label();
            label76 = new System.Windows.Forms.Label();
            label84 = new System.Windows.Forms.Label();
            label92 = new System.Windows.Forms.Label();
            label100 = new System.Windows.Forms.Label();
            label108 = new System.Windows.Forms.Label();
            label116 = new System.Windows.Forms.Label();
            label120 = new System.Windows.Forms.Label();
            label124 = new System.Windows.Forms.Label();
            label125 = new System.Windows.Forms.Label();
            label126 = new System.Windows.Forms.Label();
            label127 = new System.Windows.Forms.Label();
            label128 = new System.Windows.Forms.Label();
            label129 = new System.Windows.Forms.Label();
            label130 = new System.Windows.Forms.Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNoSoum
            // 
            lblNoSoum.AutoSize = true;
            lblNoSoum.BackColor = System.Drawing.Color.White;
            lblNoSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblNoSoum.Location = new System.Drawing.Point(327, 17);
            lblNoSoum.Name = "lblNoSoum";
            lblNoSoum.Size = new System.Drawing.Size(83, 16);
            lblNoSoum.TabIndex = 18;
            lblNoSoum.Text = "lblNoSoum";
            // 
            // lblPiedPage
            // 
            lblPiedPage.AutoSize = true;
            lblPiedPage.BackColor = System.Drawing.Color.White;
            lblPiedPage.Dock = System.Windows.Forms.DockStyle.Right;
            lblPiedPage.Font = new System.Drawing.Font("Calibri", 12F);
            lblPiedPage.Location = new System.Drawing.Point(674, 0);
            lblPiedPage.Name = "lblPiedPage";
            lblPiedPage.Size = new System.Drawing.Size(85, 19);
            lblPiedPage.TabIndex = 15;
            lblPiedPage.Text = "lblPiedPage";
            // 
            // lblTitreCommande
            // 
            lblTitreCommande.AutoSize = true;
            lblTitreCommande.BackColor = System.Drawing.Color.White;
            lblTitreCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreCommande.Location = new System.Drawing.Point(74, 44);
            lblTitreCommande.Name = "lblTitreCommande";
            lblTitreCommande.Size = new System.Drawing.Size(134, 16);
            lblTitreCommande.TabIndex = 22;
            lblTitreCommande.Text = "lblTitreCommande";
            // 
            // lblNoBC
            // 
            lblNoBC.AutoSize = true;
            lblNoBC.BackColor = System.Drawing.Color.White;
            lblNoBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblNoBC.Location = new System.Drawing.Point(327, 36);
            lblNoBC.Name = "lblNoBC";
            lblNoBC.Size = new System.Drawing.Size(64, 16);
            lblNoBC.TabIndex = 24;
            lblNoBC.Text = "lblNoBC";
            // 
            // lblTitreNoSoum
            // 
            lblTitreNoSoum.AutoSize = true;
            lblTitreNoSoum.BackColor = System.Drawing.Color.White;
            lblTitreNoSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreNoSoum.Location = new System.Drawing.Point(203, 17);
            lblTitreNoSoum.Name = "lblTitreNoSoum";
            lblTitreNoSoum.Size = new System.Drawing.Size(115, 16);
            lblTitreNoSoum.TabIndex = 17;
            lblTitreNoSoum.Text = "lblTitreNoSoum";
            // 
            // lblTitreBC
            // 
            lblTitreBC.AutoSize = true;
            lblTitreBC.BackColor = System.Drawing.Color.White;
            lblTitreBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreBC.Location = new System.Drawing.Point(203, 36);
            lblTitreBC.Name = "lblTitreBC";
            lblTitreBC.Size = new System.Drawing.Size(76, 16);
            lblTitreBC.TabIndex = 19;
            lblTitreBC.Text = "lblTitreBC";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(0, 47);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 13);
            label8.TabIndex = 33;
            label8.Text = "Nom du projet";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.BackColor = System.Drawing.Color.White;
            lblPage.Dock = System.Windows.Forms.DockStyle.Right;
            lblPage.Font = new System.Drawing.Font("Calibri", 12F);
            lblPage.Location = new System.Drawing.Point(759, 0);
            lblPage.Name = "lblPage";
            lblPage.Size = new System.Drawing.Size(57, 19);
            lblPage.TabIndex = 14;
            lblPage.Text = "lblPage";
            // 
            // lblDate
            // 
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblDate.Location = new System.Drawing.Point(647, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(171, 57);
            lblDate.TabIndex = 26;
            lblDate.Text = "Date * lbldate";
            lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            label60.BackColor = System.Drawing.Color.White;
            label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label60.Location = new System.Drawing.Point(24, 878);
            label60.Name = "label60";
            label60.Size = new System.Drawing.Size(37, 20);
            label60.TabIndex = 374;
            label60.Text = "6";
            label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            label45.BackColor = System.Drawing.Color.White;
            label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.Location = new System.Drawing.Point(688, 647);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(100, 20);
            label45.TabIndex = 373;
            // 
            // label46
            // 
            label46.BackColor = System.Drawing.Color.White;
            label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.Location = new System.Drawing.Point(194, 647);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(492, 20);
            label46.TabIndex = 372;
            // 
            // label47
            // 
            label47.BackColor = System.Drawing.Color.White;
            label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label47.Location = new System.Drawing.Point(68, 647);
            label47.Name = "label47";
            label47.Size = new System.Drawing.Size(124, 20);
            label47.TabIndex = 371;
            // 
            // label49
            // 
            label49.BackColor = System.Drawing.Color.White;
            label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label49.Location = new System.Drawing.Point(688, 626);
            label49.Name = "label49";
            label49.Size = new System.Drawing.Size(100, 20);
            label49.TabIndex = 369;
            // 
            // label50
            // 
            label50.BackColor = System.Drawing.Color.White;
            label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.Location = new System.Drawing.Point(194, 626);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(492, 20);
            label50.TabIndex = 368;
            // 
            // label51
            // 
            label51.BackColor = System.Drawing.Color.White;
            label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label51.Location = new System.Drawing.Point(68, 626);
            label51.Name = "label51";
            label51.Size = new System.Drawing.Size(124, 20);
            label51.TabIndex = 367;
            // 
            // label52
            // 
            label52.BackColor = System.Drawing.Color.White;
            label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label52.Location = new System.Drawing.Point(24, 794);
            label52.Name = "label52";
            label52.Size = new System.Drawing.Size(37, 20);
            label52.TabIndex = 366;
            label52.Text = "5";
            label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            label37.BackColor = System.Drawing.Color.White;
            label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.Location = new System.Drawing.Point(688, 605);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(100, 20);
            label37.TabIndex = 365;
            // 
            // label38
            // 
            label38.BackColor = System.Drawing.Color.White;
            label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.Location = new System.Drawing.Point(194, 605);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(492, 20);
            label38.TabIndex = 364;
            // 
            // label39
            // 
            label39.BackColor = System.Drawing.Color.White;
            label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.Location = new System.Drawing.Point(68, 605);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(124, 20);
            label39.TabIndex = 363;
            // 
            // label41
            // 
            label41.BackColor = System.Drawing.Color.White;
            label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.Location = new System.Drawing.Point(688, 584);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(100, 20);
            label41.TabIndex = 361;
            // 
            // label42
            // 
            label42.BackColor = System.Drawing.Color.White;
            label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.Location = new System.Drawing.Point(194, 584);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(492, 20);
            label42.TabIndex = 360;
            // 
            // label43
            // 
            label43.BackColor = System.Drawing.Color.White;
            label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label43.Location = new System.Drawing.Point(68, 584);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(124, 20);
            label43.TabIndex = 359;
            // 
            // label44
            // 
            label44.BackColor = System.Drawing.Color.White;
            label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label44.Location = new System.Drawing.Point(24, 710);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(37, 20);
            label44.TabIndex = 358;
            label44.Text = "4";
            label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.BackColor = System.Drawing.Color.White;
            label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.Location = new System.Drawing.Point(688, 563);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(100, 20);
            label29.TabIndex = 357;
            // 
            // label30
            // 
            label30.BackColor = System.Drawing.Color.White;
            label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.Location = new System.Drawing.Point(194, 563);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(492, 20);
            label30.TabIndex = 356;
            // 
            // label31
            // 
            label31.BackColor = System.Drawing.Color.White;
            label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.Location = new System.Drawing.Point(68, 563);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(124, 20);
            label31.TabIndex = 355;
            // 
            // label33
            // 
            label33.BackColor = System.Drawing.Color.White;
            label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.Location = new System.Drawing.Point(688, 542);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(100, 20);
            label33.TabIndex = 353;
            // 
            // label34
            // 
            label34.BackColor = System.Drawing.Color.White;
            label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(194, 542);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(492, 20);
            label34.TabIndex = 352;
            // 
            // label35
            // 
            label35.BackColor = System.Drawing.Color.White;
            label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.Location = new System.Drawing.Point(68, 542);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(124, 20);
            label35.TabIndex = 351;
            // 
            // label36
            // 
            label36.BackColor = System.Drawing.Color.White;
            label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label36.Location = new System.Drawing.Point(25, 626);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(37, 20);
            label36.TabIndex = 350;
            label36.Text = "3";
            label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = System.Drawing.Color.White;
            label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(688, 521);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(100, 20);
            label10.TabIndex = 349;
            // 
            // label22
            // 
            label22.BackColor = System.Drawing.Color.White;
            label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.Location = new System.Drawing.Point(194, 521);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(492, 20);
            label22.TabIndex = 348;
            // 
            // label23
            // 
            label23.BackColor = System.Drawing.Color.White;
            label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(68, 521);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(124, 20);
            label23.TabIndex = 347;
            // 
            // label25
            // 
            label25.BackColor = System.Drawing.Color.White;
            label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.Location = new System.Drawing.Point(688, 500);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(100, 20);
            label25.TabIndex = 345;
            // 
            // label26
            // 
            label26.BackColor = System.Drawing.Color.White;
            label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(194, 500);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(492, 20);
            label26.TabIndex = 344;
            // 
            // label27
            // 
            label27.BackColor = System.Drawing.Color.White;
            label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.Location = new System.Drawing.Point(68, 500);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(124, 20);
            label27.TabIndex = 343;
            // 
            // label28
            // 
            label28.BackColor = System.Drawing.Color.White;
            label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.Location = new System.Drawing.Point(24, 542);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(37, 20);
            label28.TabIndex = 342;
            label28.Text = "2";
            label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = System.Drawing.Color.White;
            label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.Location = new System.Drawing.Point(688, 479);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(100, 20);
            label18.TabIndex = 341;
            // 
            // label19
            // 
            label19.BackColor = System.Drawing.Color.White;
            label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(194, 479);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(492, 20);
            label19.TabIndex = 340;
            // 
            // label20
            // 
            label20.BackColor = System.Drawing.Color.White;
            label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(68, 479);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(124, 20);
            label20.TabIndex = 339;
            // 
            // label14
            // 
            label14.BackColor = System.Drawing.Color.White;
            label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(688, 458);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(100, 20);
            label14.TabIndex = 337;
            // 
            // label15
            // 
            label15.BackColor = System.Drawing.Color.White;
            label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(194, 458);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(492, 20);
            label15.TabIndex = 336;
            // 
            // label16
            // 
            label16.BackColor = System.Drawing.Color.White;
            label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(68, 458);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(124, 20);
            label16.TabIndex = 335;
            // 
            // label17
            // 
            label17.BackColor = System.Drawing.Color.White;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(25, 460);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(37, 20);
            label17.TabIndex = 334;
            label17.Text = "1";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = System.Drawing.Color.White;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(688, 438);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(100, 20);
            label13.TabIndex = 333;
            label13.Text = "Date / Par";
            // 
            // label12
            // 
            label12.BackColor = System.Drawing.Color.White;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(194, 438);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(492, 20);
            label12.TabIndex = 332;
            label12.Text = "Desciption";
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.White;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(68, 438);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(124, 20);
            label11.TabIndex = 331;
            label11.Text = "Révision";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(560, 193);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(109, 16);
            label7.TabIndex = 330;
            label7.Text = "Date fermeture";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.White;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label9.Location = new System.Drawing.Point(672, 193);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(81, 16);
            label9.TabIndex = 329;
            label9.Text = "8888-88-88";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(650, 150);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 16);
            label6.TabIndex = 328;
            label6.Text = "88:88:88";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(599, 150);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 16);
            label5.TabIndex = 327;
            label5.Text = "Heure";
            // 
            // lblProjet
            // 
            lblProjet.AutoSize = true;
            lblProjet.BackColor = System.Drawing.Color.White;
            lblProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblProjet.Location = new System.Drawing.Point(107, 215);
            lblProjet.Name = "lblProjet";
            lblProjet.Size = new System.Drawing.Size(65, 16);
            lblProjet.TabIndex = 326;
            lblProjet.Text = "lblProjet";
            // 
            // lbTitrelProjet
            // 
            lbTitrelProjet.AutoSize = true;
            lbTitrelProjet.BackColor = System.Drawing.Color.White;
            lbTitrelProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lbTitrelProjet.Location = new System.Drawing.Point(38, 216);
            lbTitrelProjet.Name = "lbTitrelProjet";
            lbTitrelProjet.Size = new System.Drawing.Size(48, 16);
            lbTitrelProjet.TabIndex = 325;
            lbTitrelProjet.Text = "Projet";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = System.Drawing.Color.White;
            lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblClient.Location = new System.Drawing.Point(103, 179);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(63, 16);
            lblClient.TabIndex = 324;
            lblClient.Text = "lblClient";
            // 
            // lblTitreClient
            // 
            lblTitreClient.AutoSize = true;
            lblTitreClient.BackColor = System.Drawing.Color.White;
            lblTitreClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreClient.Location = new System.Drawing.Point(38, 178);
            lblTitreClient.Name = "lblTitreClient";
            lblTitreClient.Size = new System.Drawing.Size(46, 16);
            lblTitreClient.TabIndex = 323;
            lblTitreClient.Text = "Client";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.White;
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(lblPiedPage);
            panel4.Controls.Add(lblPage);
            panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(0, 988);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(818, 23);
            panel4.TabIndex = 310;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(lblNoSoum);
            panel3.Controls.Add(lblNoBC);
            panel3.Controls.Add(lblTitreNoSoum);
            panel3.Controls.Add(lblTitreBC);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel3.Location = new System.Drawing.Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(818, 57);
            panel3.TabIndex = 322;
            // 
            // lblDateOuverture
            // 
            lblDateOuverture.AutoSize = true;
            lblDateOuverture.BackColor = System.Drawing.Color.White;
            lblDateOuverture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblDateOuverture.Location = new System.Drawing.Point(234, 148);
            lblDateOuverture.Name = "lblDateOuverture";
            lblDateOuverture.Size = new System.Drawing.Size(81, 16);
            lblDateOuverture.TabIndex = 315;
            lblDateOuverture.Text = "8888-88-88";
            // 
            // lblTitreContact
            // 
            lblTitreContact.AutoSize = true;
            lblTitreContact.BackColor = System.Drawing.Color.White;
            lblTitreContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreContact.Location = new System.Drawing.Point(38, 194);
            lblTitreContact.Name = "lblTitreContact";
            lblTitreContact.Size = new System.Drawing.Size(59, 16);
            lblTitreContact.TabIndex = 319;
            lblTitreContact.Text = "Contact";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = System.Drawing.Color.White;
            lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblContact.Location = new System.Drawing.Point(103, 193);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(76, 16);
            lblContact.TabIndex = 320;
            lblContact.Text = "lblContact";
            // 
            // lblTitreTel
            // 
            lblTitreTel.AutoSize = true;
            lblTitreTel.BackColor = System.Drawing.Color.White;
            lblTitreTel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreTel.Location = new System.Drawing.Point(325, 216);
            lblTitreTel.Name = "lblTitreTel";
            lblTitreTel.Size = new System.Drawing.Size(25, 15);
            lblTitreTel.TabIndex = 321;
            lblTitreTel.Text = "Tél.";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BackColor = System.Drawing.Color.White;
            lblTel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lblTel.Location = new System.Drawing.Point(354, 216);
            lblTel.Name = "lblTel";
            lblTel.Size = new System.Drawing.Size(35, 15);
            lblTel.TabIndex = 318;
            lblTel.Text = "lblTel";
            // 
            // lbltitredate
            // 
            lbltitredate.AutoSize = true;
            lbltitredate.BackColor = System.Drawing.Color.White;
            lbltitredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lbltitredate.Location = new System.Drawing.Point(110, 148);
            lbltitredate.Name = "lbltitredate";
            lbltitredate.Size = new System.Drawing.Size(122, 16);
            lbltitredate.TabIndex = 316;
            lbltitredate.Text = "Date d\'ouverture";
            // 
            // lbltitredatereq
            // 
            lbltitredatereq.AutoSize = true;
            lbltitredatereq.BackColor = System.Drawing.Color.White;
            lbltitredatereq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lbltitredatereq.Location = new System.Drawing.Point(355, 148);
            lbltitredatereq.Name = "lbltitredatereq";
            lbltitredatereq.Size = new System.Drawing.Size(96, 16);
            lbltitredatereq.TabIndex = 317;
            lbltitredatereq.Text = "Date requise";
            // 
            // lblDateRequise
            // 
            lblDateRequise.AutoSize = true;
            lblDateRequise.BackColor = System.Drawing.Color.White;
            lblDateRequise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblDateRequise.Location = new System.Drawing.Point(453, 148);
            lblDateRequise.Name = "lblDateRequise";
            lblDateRequise.Size = new System.Drawing.Size(81, 16);
            lblDateRequise.TabIndex = 313;
            lblDateRequise.Text = "8888-88-88";
            // 
            // lblTitreFax
            // 
            lblTitreFax.AutoSize = true;
            lblTitreFax.BackColor = System.Drawing.Color.White;
            lblTitreFax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreFax.Location = new System.Drawing.Point(560, 216);
            lblTitreFax.Name = "lblTitreFax";
            lblTitreFax.Size = new System.Drawing.Size(25, 15);
            lblTitreFax.TabIndex = 314;
            lblTitreFax.Text = "Fax";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.BackColor = System.Drawing.Color.White;
            lblFax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lblFax.Location = new System.Drawing.Point(591, 216);
            lblFax.Name = "lblFax";
            lblFax.Size = new System.Drawing.Size(38, 15);
            lblFax.TabIndex = 312;
            lblFax.Text = "lblFax";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(628, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(190, 70);
            panel1.TabIndex = 0;
            panel1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // label117
            // 
            label117.BackColor = System.Drawing.Color.White;
            label117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label117.Location = new System.Drawing.Point(688, 1033);
            label117.Name = "label117";
            label117.Size = new System.Drawing.Size(100, 20);
            label117.TabIndex = 445;
            // 
            // label118
            // 
            label118.BackColor = System.Drawing.Color.White;
            label118.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label118.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label118.Location = new System.Drawing.Point(194, 1012);
            label118.Name = "label118";
            label118.Size = new System.Drawing.Size(492, 20);
            label118.TabIndex = 444;
            // 
            // label119
            // 
            label119.BackColor = System.Drawing.Color.White;
            label119.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label119.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label119.Location = new System.Drawing.Point(68, 1030);
            label119.Name = "label119";
            label119.Size = new System.Drawing.Size(124, 20);
            label119.TabIndex = 443;
            // 
            // label121
            // 
            label121.BackColor = System.Drawing.Color.White;
            label121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label121.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label121.Location = new System.Drawing.Point(688, 1010);
            label121.Name = "label121";
            label121.Size = new System.Drawing.Size(100, 20);
            label121.TabIndex = 441;
            // 
            // label122
            // 
            label122.BackColor = System.Drawing.Color.White;
            label122.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label122.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label122.Location = new System.Drawing.Point(194, 988);
            label122.Name = "label122";
            label122.Size = new System.Drawing.Size(492, 20);
            label122.TabIndex = 440;
            // 
            // label123
            // 
            label123.BackColor = System.Drawing.Color.White;
            label123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label123.Location = new System.Drawing.Point(68, 1010);
            label123.Name = "label123";
            label123.Size = new System.Drawing.Size(124, 20);
            label123.TabIndex = 439;
            // 
            // label109
            // 
            label109.BackColor = System.Drawing.Color.White;
            label109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label109.Location = new System.Drawing.Point(688, 988);
            label109.Name = "label109";
            label109.Size = new System.Drawing.Size(100, 20);
            label109.TabIndex = 437;
            // 
            // label110
            // 
            label110.BackColor = System.Drawing.Color.White;
            label110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label110.Location = new System.Drawing.Point(194, 965);
            label110.Name = "label110";
            label110.Size = new System.Drawing.Size(492, 20);
            label110.TabIndex = 436;
            // 
            // label111
            // 
            label111.BackColor = System.Drawing.Color.White;
            label111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label111.Location = new System.Drawing.Point(68, 987);
            label111.Name = "label111";
            label111.Size = new System.Drawing.Size(124, 20);
            label111.TabIndex = 435;
            // 
            // label112
            // 
            label112.BackColor = System.Drawing.Color.White;
            label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label112.Location = new System.Drawing.Point(9, 1013);
            label112.Name = "label112";
            label112.Size = new System.Drawing.Size(37, 20);
            label112.TabIndex = 434;
            label112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label113
            // 
            label113.BackColor = System.Drawing.Color.White;
            label113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label113.Location = new System.Drawing.Point(687, 965);
            label113.Name = "label113";
            label113.Size = new System.Drawing.Size(100, 20);
            label113.TabIndex = 433;
            // 
            // label114
            // 
            label114.BackColor = System.Drawing.Color.White;
            label114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label114.Location = new System.Drawing.Point(194, 1035);
            label114.Name = "label114";
            label114.Size = new System.Drawing.Size(492, 20);
            label114.TabIndex = 432;
            // 
            // label115
            // 
            label115.BackColor = System.Drawing.Color.White;
            label115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label115.Location = new System.Drawing.Point(68, 965);
            label115.Name = "label115";
            label115.Size = new System.Drawing.Size(124, 20);
            label115.TabIndex = 431;
            // 
            // label101
            // 
            label101.BackColor = System.Drawing.Color.White;
            label101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label101.Location = new System.Drawing.Point(687, 943);
            label101.Name = "label101";
            label101.Size = new System.Drawing.Size(100, 20);
            label101.TabIndex = 429;
            // 
            // label102
            // 
            label102.BackColor = System.Drawing.Color.White;
            label102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label102.Location = new System.Drawing.Point(193, 922);
            label102.Name = "label102";
            label102.Size = new System.Drawing.Size(492, 20);
            label102.TabIndex = 428;
            // 
            // label103
            // 
            label103.BackColor = System.Drawing.Color.White;
            label103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label103.Location = new System.Drawing.Point(67, 944);
            label103.Name = "label103";
            label103.Size = new System.Drawing.Size(124, 20);
            label103.TabIndex = 427;
            // 
            // label105
            // 
            label105.BackColor = System.Drawing.Color.White;
            label105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label105.Location = new System.Drawing.Point(687, 922);
            label105.Name = "label105";
            label105.Size = new System.Drawing.Size(100, 20);
            label105.TabIndex = 425;
            // 
            // label106
            // 
            label106.BackColor = System.Drawing.Color.White;
            label106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label106.Location = new System.Drawing.Point(193, 901);
            label106.Name = "label106";
            label106.Size = new System.Drawing.Size(492, 20);
            label106.TabIndex = 424;
            // 
            // label107
            // 
            label107.BackColor = System.Drawing.Color.White;
            label107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label107.Location = new System.Drawing.Point(67, 922);
            label107.Name = "label107";
            label107.Size = new System.Drawing.Size(124, 20);
            label107.TabIndex = 423;
            // 
            // label93
            // 
            label93.BackColor = System.Drawing.Color.White;
            label93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label93.Location = new System.Drawing.Point(687, 901);
            label93.Name = "label93";
            label93.Size = new System.Drawing.Size(100, 20);
            label93.TabIndex = 421;
            // 
            // label94
            // 
            label94.BackColor = System.Drawing.Color.White;
            label94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label94.Location = new System.Drawing.Point(193, 943);
            label94.Name = "label94";
            label94.Size = new System.Drawing.Size(492, 20);
            label94.TabIndex = 420;
            // 
            // label95
            // 
            label95.BackColor = System.Drawing.Color.White;
            label95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label95.Location = new System.Drawing.Point(68, 901);
            label95.Name = "label95";
            label95.Size = new System.Drawing.Size(124, 20);
            label95.TabIndex = 419;
            // 
            // label97
            // 
            label97.BackColor = System.Drawing.Color.White;
            label97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label97.Location = new System.Drawing.Point(687, 880);
            label97.Name = "label97";
            label97.Size = new System.Drawing.Size(100, 20);
            label97.TabIndex = 417;
            // 
            // label98
            // 
            label98.BackColor = System.Drawing.Color.White;
            label98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label98.Location = new System.Drawing.Point(193, 879);
            label98.Name = "label98";
            label98.Size = new System.Drawing.Size(492, 20);
            label98.TabIndex = 416;
            // 
            // label99
            // 
            label99.BackColor = System.Drawing.Color.White;
            label99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label99.Location = new System.Drawing.Point(67, 879);
            label99.Name = "label99";
            label99.Size = new System.Drawing.Size(124, 20);
            label99.TabIndex = 415;
            // 
            // label85
            // 
            label85.BackColor = System.Drawing.Color.White;
            label85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label85.Location = new System.Drawing.Point(687, 857);
            label85.Name = "label85";
            label85.Size = new System.Drawing.Size(100, 20);
            label85.TabIndex = 413;
            // 
            // label86
            // 
            label86.BackColor = System.Drawing.Color.White;
            label86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label86.Location = new System.Drawing.Point(193, 857);
            label86.Name = "label86";
            label86.Size = new System.Drawing.Size(492, 20);
            label86.TabIndex = 412;
            // 
            // label87
            // 
            label87.BackColor = System.Drawing.Color.White;
            label87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label87.Location = new System.Drawing.Point(67, 857);
            label87.Name = "label87";
            label87.Size = new System.Drawing.Size(124, 20);
            label87.TabIndex = 411;
            // 
            // label88
            // 
            label88.BackColor = System.Drawing.Color.White;
            label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label88.Location = new System.Drawing.Point(25, 857);
            label88.Name = "label88";
            label88.Size = new System.Drawing.Size(37, 20);
            label88.TabIndex = 410;
            label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label89
            // 
            label89.BackColor = System.Drawing.Color.White;
            label89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label89.Location = new System.Drawing.Point(687, 836);
            label89.Name = "label89";
            label89.Size = new System.Drawing.Size(100, 20);
            label89.TabIndex = 409;
            // 
            // label90
            // 
            label90.BackColor = System.Drawing.Color.White;
            label90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label90.Location = new System.Drawing.Point(193, 836);
            label90.Name = "label90";
            label90.Size = new System.Drawing.Size(492, 20);
            label90.TabIndex = 408;
            // 
            // label91
            // 
            label91.BackColor = System.Drawing.Color.White;
            label91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label91.Location = new System.Drawing.Point(67, 836);
            label91.Name = "label91";
            label91.Size = new System.Drawing.Size(124, 20);
            label91.TabIndex = 407;
            // 
            // label77
            // 
            label77.BackColor = System.Drawing.Color.White;
            label77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label77.Location = new System.Drawing.Point(688, 815);
            label77.Name = "label77";
            label77.Size = new System.Drawing.Size(100, 20);
            label77.TabIndex = 405;
            // 
            // label78
            // 
            label78.BackColor = System.Drawing.Color.White;
            label78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label78.Location = new System.Drawing.Point(194, 815);
            label78.Name = "label78";
            label78.Size = new System.Drawing.Size(492, 20);
            label78.TabIndex = 404;
            // 
            // label79
            // 
            label79.BackColor = System.Drawing.Color.White;
            label79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label79.Location = new System.Drawing.Point(68, 815);
            label79.Name = "label79";
            label79.Size = new System.Drawing.Size(124, 20);
            label79.TabIndex = 403;
            // 
            // label80
            // 
            label80.BackColor = System.Drawing.Color.White;
            label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label80.Location = new System.Drawing.Point(26, 815);
            label80.Name = "label80";
            label80.Size = new System.Drawing.Size(37, 20);
            label80.TabIndex = 402;
            label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            label81.BackColor = System.Drawing.Color.White;
            label81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label81.Location = new System.Drawing.Point(688, 794);
            label81.Name = "label81";
            label81.Size = new System.Drawing.Size(100, 20);
            label81.TabIndex = 401;
            // 
            // label82
            // 
            label82.BackColor = System.Drawing.Color.White;
            label82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label82.Location = new System.Drawing.Point(194, 794);
            label82.Name = "label82";
            label82.Size = new System.Drawing.Size(492, 20);
            label82.TabIndex = 400;
            // 
            // label83
            // 
            label83.BackColor = System.Drawing.Color.White;
            label83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label83.Location = new System.Drawing.Point(68, 794);
            label83.Name = "label83";
            label83.Size = new System.Drawing.Size(124, 20);
            label83.TabIndex = 399;
            // 
            // label69
            // 
            label69.BackColor = System.Drawing.Color.White;
            label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label69.Location = new System.Drawing.Point(688, 773);
            label69.Name = "label69";
            label69.Size = new System.Drawing.Size(100, 20);
            label69.TabIndex = 397;
            // 
            // label70
            // 
            label70.BackColor = System.Drawing.Color.White;
            label70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label70.Location = new System.Drawing.Point(194, 773);
            label70.Name = "label70";
            label70.Size = new System.Drawing.Size(492, 20);
            label70.TabIndex = 396;
            // 
            // label71
            // 
            label71.BackColor = System.Drawing.Color.White;
            label71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label71.Location = new System.Drawing.Point(68, 773);
            label71.Name = "label71";
            label71.Size = new System.Drawing.Size(124, 20);
            label71.TabIndex = 395;
            // 
            // label72
            // 
            label72.BackColor = System.Drawing.Color.White;
            label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label72.Location = new System.Drawing.Point(25, 775);
            label72.Name = "label72";
            label72.Size = new System.Drawing.Size(37, 20);
            label72.TabIndex = 394;
            label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            label73.BackColor = System.Drawing.Color.White;
            label73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label73.Location = new System.Drawing.Point(688, 752);
            label73.Name = "label73";
            label73.Size = new System.Drawing.Size(100, 20);
            label73.TabIndex = 393;
            // 
            // label74
            // 
            label74.BackColor = System.Drawing.Color.White;
            label74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label74.Location = new System.Drawing.Point(194, 752);
            label74.Name = "label74";
            label74.Size = new System.Drawing.Size(492, 20);
            label74.TabIndex = 392;
            // 
            // label75
            // 
            label75.BackColor = System.Drawing.Color.White;
            label75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label75.Location = new System.Drawing.Point(68, 752);
            label75.Name = "label75";
            label75.Size = new System.Drawing.Size(124, 20);
            label75.TabIndex = 391;
            // 
            // label61
            // 
            label61.BackColor = System.Drawing.Color.White;
            label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label61.Location = new System.Drawing.Point(688, 731);
            label61.Name = "label61";
            label61.Size = new System.Drawing.Size(100, 20);
            label61.TabIndex = 389;
            // 
            // label62
            // 
            label62.BackColor = System.Drawing.Color.White;
            label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label62.Location = new System.Drawing.Point(194, 731);
            label62.Name = "label62";
            label62.Size = new System.Drawing.Size(492, 20);
            label62.TabIndex = 388;
            // 
            // label63
            // 
            label63.BackColor = System.Drawing.Color.White;
            label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label63.Location = new System.Drawing.Point(68, 731);
            label63.Name = "label63";
            label63.Size = new System.Drawing.Size(124, 20);
            label63.TabIndex = 387;
            // 
            // label64
            // 
            label64.BackColor = System.Drawing.Color.White;
            label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label64.Location = new System.Drawing.Point(25, 733);
            label64.Name = "label64";
            label64.Size = new System.Drawing.Size(37, 20);
            label64.TabIndex = 386;
            label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            label65.BackColor = System.Drawing.Color.White;
            label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label65.Location = new System.Drawing.Point(688, 710);
            label65.Name = "label65";
            label65.Size = new System.Drawing.Size(100, 20);
            label65.TabIndex = 385;
            // 
            // label66
            // 
            label66.BackColor = System.Drawing.Color.White;
            label66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label66.Location = new System.Drawing.Point(194, 710);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(492, 20);
            label66.TabIndex = 384;
            // 
            // label67
            // 
            label67.BackColor = System.Drawing.Color.White;
            label67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label67.Location = new System.Drawing.Point(68, 710);
            label67.Name = "label67";
            label67.Size = new System.Drawing.Size(124, 20);
            label67.TabIndex = 383;
            // 
            // label68
            // 
            label68.BackColor = System.Drawing.Color.White;
            label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label68.Location = new System.Drawing.Point(24, 988);
            label68.Name = "label68";
            label68.Size = new System.Drawing.Size(37, 20);
            label68.TabIndex = 382;
            label68.Text = "7";
            label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            label53.BackColor = System.Drawing.Color.White;
            label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label53.Location = new System.Drawing.Point(688, 689);
            label53.Name = "label53";
            label53.Size = new System.Drawing.Size(100, 20);
            label53.TabIndex = 381;
            // 
            // label54
            // 
            label54.BackColor = System.Drawing.Color.White;
            label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label54.Location = new System.Drawing.Point(194, 689);
            label54.Name = "label54";
            label54.Size = new System.Drawing.Size(492, 20);
            label54.TabIndex = 380;
            // 
            // label55
            // 
            label55.BackColor = System.Drawing.Color.White;
            label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label55.Location = new System.Drawing.Point(68, 689);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(124, 20);
            label55.TabIndex = 379;
            // 
            // label57
            // 
            label57.BackColor = System.Drawing.Color.White;
            label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label57.Location = new System.Drawing.Point(688, 668);
            label57.Name = "label57";
            label57.Size = new System.Drawing.Size(100, 20);
            label57.TabIndex = 377;
            // 
            // label58
            // 
            label58.BackColor = System.Drawing.Color.White;
            label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label58.Location = new System.Drawing.Point(194, 668);
            label58.Name = "label58";
            label58.Size = new System.Drawing.Size(492, 20);
            label58.TabIndex = 376;
            // 
            // label59
            // 
            label59.BackColor = System.Drawing.Color.White;
            label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label59.Location = new System.Drawing.Point(68, 668);
            label59.Name = "label59";
            label59.Size = new System.Drawing.Size(124, 20);
            label59.TabIndex = 375;
            // 
            // lblTitrePage
            // 
            lblTitrePage.AutoSize = true;
            lblTitrePage.BackColor = System.Drawing.Color.White;
            lblTitrePage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitrePage.Location = new System.Drawing.Point(20, 9);
            lblTitrePage.Name = "lblTitrePage";
            lblTitrePage.Size = new System.Drawing.Size(132, 23);
            lblTitrePage.TabIndex = 4;
            lblTitrePage.Text = "Programmation";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(lblTitrePage);
            panel2.Controls.Add(lblTitreCommande);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(818, 70);
            panel2.TabIndex = 311;
            // 
            // label133
            // 
            label133.AutoSize = true;
            label133.BackColor = System.Drawing.Color.White;
            label133.Location = new System.Drawing.Point(109, 165);
            label133.Name = "label133";
            label133.Size = new System.Drawing.Size(118, 13);
            label133.TabIndex = 454;
            label133.Text = "Mot de passe automate";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = System.Drawing.Color.White;
            label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.Location = new System.Drawing.Point(213, 244);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(410, 20);
            label21.TabIndex = 455;
            label21.Text = "Documents obligatoires pour fermeture du dossier";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = System.Drawing.Color.White;
            label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.Location = new System.Drawing.Point(275, 417);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(259, 16);
            label24.TabIndex = 456;
            label24.Text = "Cheminement de la programmmation";
            // 
            // label56
            // 
            label56.BackColor = System.Drawing.Color.White;
            label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label56.Location = new System.Drawing.Point(25, 274);
            label56.Name = "label56";
            label56.Size = new System.Drawing.Size(37, 20);
            label56.TabIndex = 457;
            label56.Text = "1";
            label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            label40.BackColor = System.Drawing.Color.White;
            label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label40.Location = new System.Drawing.Point(68, 273);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(622, 20);
            label40.TabIndex = 459;
            label40.Text = "Liste des entrées et sorties";
            // 
            // label32
            // 
            label32.BackColor = System.Drawing.Color.White;
            label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label32.Location = new System.Drawing.Point(696, 273);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(100, 20);
            label32.TabIndex = 460;
            // 
            // label48
            // 
            label48.BackColor = System.Drawing.Color.White;
            label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label48.Location = new System.Drawing.Point(696, 295);
            label48.Name = "label48";
            label48.Size = new System.Drawing.Size(100, 20);
            label48.TabIndex = 463;
            // 
            // label76
            // 
            label76.BackColor = System.Drawing.Color.White;
            label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label76.Location = new System.Drawing.Point(68, 295);
            label76.Name = "label76";
            label76.Size = new System.Drawing.Size(622, 20);
            label76.TabIndex = 462;
            label76.Text = "Liste des registres et bits internes";
            // 
            // label84
            // 
            label84.BackColor = System.Drawing.Color.White;
            label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label84.Location = new System.Drawing.Point(25, 296);
            label84.Name = "label84";
            label84.Size = new System.Drawing.Size(37, 20);
            label84.TabIndex = 461;
            label84.Text = "2";
            label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label92
            // 
            label92.BackColor = System.Drawing.Color.White;
            label92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label92.Location = new System.Drawing.Point(696, 317);
            label92.Name = "label92";
            label92.Size = new System.Drawing.Size(100, 20);
            label92.TabIndex = 466;
            // 
            // label100
            // 
            label100.BackColor = System.Drawing.Color.White;
            label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label100.Location = new System.Drawing.Point(68, 319);
            label100.Name = "label100";
            label100.Size = new System.Drawing.Size(622, 20);
            label100.TabIndex = 465;
            label100.Text = "Dessin tel que construit";
            // 
            // label108
            // 
            label108.BackColor = System.Drawing.Color.White;
            label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label108.Location = new System.Drawing.Point(25, 317);
            label108.Name = "label108";
            label108.Size = new System.Drawing.Size(37, 20);
            label108.TabIndex = 464;
            label108.Text = "3";
            label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label116
            // 
            label116.BackColor = System.Drawing.Color.White;
            label116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label116.Location = new System.Drawing.Point(696, 339);
            label116.Name = "label116";
            label116.Size = new System.Drawing.Size(100, 20);
            label116.TabIndex = 469;
            // 
            // label120
            // 
            label120.BackColor = System.Drawing.Color.White;
            label120.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label120.Location = new System.Drawing.Point(68, 339);
            label120.Name = "label120";
            label120.Size = new System.Drawing.Size(622, 20);
            label120.TabIndex = 468;
            label120.Tag = "";
            label120.Text = "Grafset";
            // 
            // label124
            // 
            label124.BackColor = System.Drawing.Color.White;
            label124.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label124.Location = new System.Drawing.Point(25, 339);
            label124.Name = "label124";
            label124.Size = new System.Drawing.Size(37, 20);
            label124.TabIndex = 467;
            label124.Text = "4";
            label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label125
            // 
            label125.BackColor = System.Drawing.Color.White;
            label125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label125.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label125.Location = new System.Drawing.Point(354, 360);
            label125.Name = "label125";
            label125.Size = new System.Drawing.Size(442, 20);
            label125.TabIndex = 472;
            // 
            // label126
            // 
            label126.BackColor = System.Drawing.Color.White;
            label126.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label126.Location = new System.Drawing.Point(68, 360);
            label126.Name = "label126";
            label126.Size = new System.Drawing.Size(281, 20);
            label126.TabIndex = 471;
            label126.Text = "Nom et lieu de sauvegarde ";
            // 
            // label127
            // 
            label127.BackColor = System.Drawing.Color.White;
            label127.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label127.Location = new System.Drawing.Point(25, 361);
            label127.Name = "label127";
            label127.Size = new System.Drawing.Size(37, 20);
            label127.TabIndex = 470;
            label127.Text = "5";
            label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label128
            // 
            label128.BackColor = System.Drawing.Color.White;
            label128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label128.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label128.Location = new System.Drawing.Point(355, 382);
            label128.Name = "label128";
            label128.Size = new System.Drawing.Size(441, 20);
            label128.TabIndex = 475;
            // 
            // label129
            // 
            label129.BackColor = System.Drawing.Color.White;
            label129.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label129.Location = new System.Drawing.Point(68, 382);
            label129.Name = "label129";
            label129.Size = new System.Drawing.Size(281, 20);
            label129.TabIndex = 474;
            label129.Text = "Nom et lieu du noveau programme";
            // 
            // label130
            // 
            label130.BackColor = System.Drawing.Color.White;
            label130.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label130.Location = new System.Drawing.Point(25, 383);
            label130.Name = "label130";
            label130.Size = new System.Drawing.Size(37, 20);
            label130.TabIndex = 473;
            label130.Text = "6";
            label130.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewProgrammation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1011);
            Controls.Add(label128);
            Controls.Add(label129);
            Controls.Add(label130);
            Controls.Add(label125);
            Controls.Add(label126);
            Controls.Add(label127);
            Controls.Add(label116);
            Controls.Add(label120);
            Controls.Add(label124);
            Controls.Add(label92);
            Controls.Add(label100);
            Controls.Add(label108);
            Controls.Add(label48);
            Controls.Add(label76);
            Controls.Add(label84);
            Controls.Add(label32);
            Controls.Add(label40);
            Controls.Add(label56);
            Controls.Add(label24);
            Controls.Add(label21);
            Controls.Add(label133);
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
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblProjet);
            Controls.Add(lbTitrelProjet);
            Controls.Add(lblClient);
            Controls.Add(lblTitreClient);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(lblDateOuverture);
            Controls.Add(lblTitreContact);
            Controls.Add(lblContact);
            Controls.Add(lblTitreTel);
            Controls.Add(lblTel);
            Controls.Add(lbltitredate);
            Controls.Add(lbltitredatereq);
            Controls.Add(lblDateRequise);
            Controls.Add(lblTitreFax);
            Controls.Add(lblFax);
            Controls.Add(label117);
            Controls.Add(label118);
            Controls.Add(label119);
            Controls.Add(label121);
            Controls.Add(label122);
            Controls.Add(label123);
            Controls.Add(label109);
            Controls.Add(label110);
            Controls.Add(label111);
            Controls.Add(label112);
            Controls.Add(label113);
            Controls.Add(label114);
            Controls.Add(label115);
            Controls.Add(label101);
            Controls.Add(label102);
            Controls.Add(label103);
            Controls.Add(label105);
            Controls.Add(label106);
            Controls.Add(label107);
            Controls.Add(label93);
            Controls.Add(label94);
            Controls.Add(label95);
            Controls.Add(label97);
            Controls.Add(label98);
            Controls.Add(label99);
            Controls.Add(label85);
            Controls.Add(label86);
            Controls.Add(label87);
            Controls.Add(label88);
            Controls.Add(label89);
            Controls.Add(label90);
            Controls.Add(label91);
            Controls.Add(label77);
            Controls.Add(label78);
            Controls.Add(label79);
            Controls.Add(label80);
            Controls.Add(label81);
            Controls.Add(label82);
            Controls.Add(label83);
            Controls.Add(label69);
            Controls.Add(label70);
            Controls.Add(label71);
            Controls.Add(label72);
            Controls.Add(label73);
            Controls.Add(label74);
            Controls.Add(label75);
            Controls.Add(label61);
            Controls.Add(label62);
            Controls.Add(label63);
            Controls.Add(label64);
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
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewProgrammation";
            ShowInTaskbar = false;
            Text = "ViewProgrammation";
            Load += new System.EventHandler(ViewProgrammation_Load);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label lblNoSoum;
        internal static Label lblPiedPage;
        internal static Label lblTitreCommande;
        internal static Label lblNoBC;
        internal static Label lblTitreNoSoum;
        internal static Label lblTitreBC;
        internal static Label label8;
        internal static Label lblPage;
        internal static Label lblDate;
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
        internal static Label label7;
        internal static Label label9;
        internal static Label label6;
        internal static Label label5;
        internal static Label lblProjet;
        internal static Label lbTitrelProjet;
        internal static Label lblClient;
        internal static Label lblTitreClient;
        internal static Panel panel4;
        internal static Panel panel3;
        internal static Label lblDateOuverture;
        internal static Label lblTitreContact;
        internal static Label lblContact;
        internal static Label lblTitreTel;
        internal static Label lblTel;
        internal static Label lbltitredate;
        internal static Label lbltitredatereq;
        internal static Label lblDateRequise;
        internal static Label lblTitreFax;
        internal static Label lblFax;
        internal static Panel panel1;
        internal static Label label117;
        internal static Label label118;
        internal static Label label119;
        internal static Label label121;
        internal static Label label122;
        internal static Label label123;
        internal static Label label109;
        internal static Label label110;
        internal static Label label111;
        internal static Label label112;
        internal static Label label113;
        internal static Label label114;
        internal static Label label115;
        internal static Label label101;
        internal static Label label102;
        internal static Label label103;
        internal static Label label105;
        internal static Label label106;
        internal static Label label107;
        internal static Label label93;
        internal static Label label94;
        internal static Label label95;
        internal static Label label97;
        internal static Label label98;
        internal static Label label99;
        internal static Label label85;
        internal static Label label86;
        internal static Label label87;
        internal static Label label88;
        internal static Label label89;
        internal static Label label90;
        internal static Label label91;
        internal static Label label77;
        internal static Label label78;
        internal static Label label79;
        internal static Label label80;
        internal static Label label81;
        internal static Label label82;
        internal static Label label83;
        internal static Label label69;
        internal static Label label70;
        internal static Label label71;
        internal static Label label72;
        internal static Label label73;
        internal static Label label74;
        internal static Label label75;
        internal static Label label61;
        internal static Label label62;
        internal static Label label63;
        internal static Label label64;
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
        internal static Label lblTitrePage;
        internal static Panel panel2;
        internal static Label label133;
        internal static Label label21;
        internal static Label label24;
        internal static Label label56;
        internal static Label label40;
        internal static Label label32;
        internal static Label label48;
        internal static Label label76;
        internal static Label label84;
        internal static Label label92;
        internal static Label label100;
        internal static Label label108;
        internal static Label label116;
        internal static Label label120;
        internal static Label label124;
        internal static Label label125;
        internal static Label label126;
        internal static Label label127;
        internal static Label label128;
        internal static Label label129;
        internal static Label label130;
        internal static  Label lblTelephone;
        internal static  Label lblNoProj;
        internal static  Label lblProjetNom;
        internal static  Label lblProjetClient;
        public static bool Orientation { get; internal set; }
        public ViewProgrammation()
        {
            InitializeComponent();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        private void ViewProgrammation_Load(object sender, EventArgs e)
        {
            lblContact.Text = ViewProgrammation.lblContact.Text;
            lblClient.Text = ViewProgrammation.lblClient.Text;
            lblTel.Text = ViewProgrammation.lblTelephone.Text;
            lblFax.Text = ViewProgrammation.lblFax.Text;
            lblNoSoum.Text = ViewProgrammation.lblNoSoum.Text;
            lblNoBC.Text = ViewProgrammation.lblNoProj.Text;
            lblTitreCommande.Text = ViewProgrammation.lblProjetNom.Text;
            lblDate.Text = ViewProgrammation.lblDate.Text;
            lblProjet.Text = ViewProgrammation.lblProjetClient.Text;
        }
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
    }
}
