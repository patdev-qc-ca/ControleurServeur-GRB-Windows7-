
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
    public class ViewFournisseur : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFournisseur));
            label125 = new System.Windows.Forms.Label();
            label126 = new System.Windows.Forms.Label();
            label127 = new System.Windows.Forms.Label();
            label128 = new System.Windows.Forms.Label();
            label129 = new System.Windows.Forms.Label();
            label130 = new System.Windows.Forms.Label();
            label131 = new System.Windows.Forms.Label();
            label132 = new System.Windows.Forms.Label();
            label117 = new System.Windows.Forms.Label();
            label118 = new System.Windows.Forms.Label();
            label119 = new System.Windows.Forms.Label();
            label120 = new System.Windows.Forms.Label();
            label121 = new System.Windows.Forms.Label();
            label122 = new System.Windows.Forms.Label();
            label123 = new System.Windows.Forms.Label();
            label124 = new System.Windows.Forms.Label();
            label109 = new System.Windows.Forms.Label();
            label110 = new System.Windows.Forms.Label();
            label111 = new System.Windows.Forms.Label();
            label112 = new System.Windows.Forms.Label();
            label113 = new System.Windows.Forms.Label();
            label114 = new System.Windows.Forms.Label();
            label115 = new System.Windows.Forms.Label();
            label116 = new System.Windows.Forms.Label();
            label101 = new System.Windows.Forms.Label();
            label102 = new System.Windows.Forms.Label();
            label103 = new System.Windows.Forms.Label();
            label104 = new System.Windows.Forms.Label();
            label105 = new System.Windows.Forms.Label();
            label106 = new System.Windows.Forms.Label();
            label107 = new System.Windows.Forms.Label();
            label108 = new System.Windows.Forms.Label();
            label93 = new System.Windows.Forms.Label();
            label94 = new System.Windows.Forms.Label();
            label95 = new System.Windows.Forms.Label();
            label96 = new System.Windows.Forms.Label();
            label97 = new System.Windows.Forms.Label();
            label98 = new System.Windows.Forms.Label();
            label99 = new System.Windows.Forms.Label();
            label100 = new System.Windows.Forms.Label();
            label85 = new System.Windows.Forms.Label();
            label86 = new System.Windows.Forms.Label();
            label87 = new System.Windows.Forms.Label();
            label88 = new System.Windows.Forms.Label();
            label89 = new System.Windows.Forms.Label();
            label90 = new System.Windows.Forms.Label();
            label91 = new System.Windows.Forms.Label();
            label92 = new System.Windows.Forms.Label();
            label77 = new System.Windows.Forms.Label();
            label78 = new System.Windows.Forms.Label();
            label79 = new System.Windows.Forms.Label();
            label80 = new System.Windows.Forms.Label();
            label81 = new System.Windows.Forms.Label();
            label82 = new System.Windows.Forms.Label();
            label83 = new System.Windows.Forms.Label();
            label84 = new System.Windows.Forms.Label();
            label69 = new System.Windows.Forms.Label();
            label70 = new System.Windows.Forms.Label();
            label71 = new System.Windows.Forms.Label();
            label72 = new System.Windows.Forms.Label();
            label73 = new System.Windows.Forms.Label();
            label74 = new System.Windows.Forms.Label();
            label75 = new System.Windows.Forms.Label();
            label76 = new System.Windows.Forms.Label();
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
            label56 = new System.Windows.Forms.Label();
            label57 = new System.Windows.Forms.Label();
            label58 = new System.Windows.Forms.Label();
            label59 = new System.Windows.Forms.Label();
            lblTitrePage = new System.Windows.Forms.Label();
            label60 = new System.Windows.Forms.Label();
            label45 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            label47 = new System.Windows.Forms.Label();
            label48 = new System.Windows.Forms.Label();
            label49 = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            label51 = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblPiedPage = new System.Windows.Forms.Label();
            lblPage = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblNoSoum = new System.Windows.Forms.Label();
            lblTitreNoSoum = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTitreCommande = new System.Windows.Forms.Label();
            lblNoBC = new System.Windows.Forms.Label();
            lblTitreBC = new System.Windows.Forms.Label();
            label52 = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            label40 = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            label42 = new System.Windows.Forms.Label();
            label43 = new System.Windows.Forms.Label();
            label44 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label125
            // 
            label125.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label125.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label125.Location = new System.Drawing.Point(375, 868);
            label125.Name = "label125";
            label125.Size = new System.Drawing.Size(405, 20);
            label125.TabIndex = 309;
            // 
            // label126
            // 
            label126.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label126.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label126.Location = new System.Drawing.Point(185, 868);
            label126.Name = "label126";
            label126.Size = new System.Drawing.Size(187, 20);
            label126.TabIndex = 308;
            // 
            // label127
            // 
            label127.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label127.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label127.Location = new System.Drawing.Point(55, 868);
            label127.Name = "label127";
            label127.Size = new System.Drawing.Size(124, 20);
            label127.TabIndex = 307;
            // 
            // label128
            // 
            label128.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label128.Location = new System.Drawing.Point(16, 868);
            label128.Name = "label128";
            label128.Size = new System.Drawing.Size(37, 20);
            label128.TabIndex = 306;
            label128.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label129
            // 
            label129.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label129.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label129.Location = new System.Drawing.Point(375, 847);
            label129.Name = "label129";
            label129.Size = new System.Drawing.Size(405, 20);
            label129.TabIndex = 305;
            // 
            // label130
            // 
            label130.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label130.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label130.Location = new System.Drawing.Point(185, 847);
            label130.Name = "label130";
            label130.Size = new System.Drawing.Size(187, 20);
            label130.TabIndex = 304;
            // 
            // label131
            // 
            label131.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label131.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label131.Location = new System.Drawing.Point(55, 847);
            label131.Name = "label131";
            label131.Size = new System.Drawing.Size(124, 20);
            label131.TabIndex = 303;
            // 
            // label132
            // 
            label132.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label132.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label132.Location = new System.Drawing.Point(16, 847);
            label132.Name = "label132";
            label132.Size = new System.Drawing.Size(37, 20);
            label132.TabIndex = 302;
            label132.Text = "15";
            label132.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label117
            // 
            label117.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label117.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label117.Location = new System.Drawing.Point(376, 826);
            label117.Name = "label117";
            label117.Size = new System.Drawing.Size(405, 20);
            label117.TabIndex = 301;
            // 
            // label118
            // 
            label118.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label118.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label118.Location = new System.Drawing.Point(186, 826);
            label118.Name = "label118";
            label118.Size = new System.Drawing.Size(187, 20);
            label118.TabIndex = 300;
            // 
            // label119
            // 
            label119.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label119.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label119.Location = new System.Drawing.Point(56, 826);
            label119.Name = "label119";
            label119.Size = new System.Drawing.Size(124, 20);
            label119.TabIndex = 299;
            // 
            // label120
            // 
            label120.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label120.Location = new System.Drawing.Point(17, 826);
            label120.Name = "label120";
            label120.Size = new System.Drawing.Size(37, 20);
            label120.TabIndex = 298;
            label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label121
            // 
            label121.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label121.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label121.Location = new System.Drawing.Point(376, 805);
            label121.Name = "label121";
            label121.Size = new System.Drawing.Size(405, 20);
            label121.TabIndex = 297;
            // 
            // label122
            // 
            label122.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label122.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label122.Location = new System.Drawing.Point(186, 805);
            label122.Name = "label122";
            label122.Size = new System.Drawing.Size(187, 20);
            label122.TabIndex = 296;
            // 
            // label123
            // 
            label123.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label123.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label123.Location = new System.Drawing.Point(56, 805);
            label123.Name = "label123";
            label123.Size = new System.Drawing.Size(124, 20);
            label123.TabIndex = 295;
            // 
            // label124
            // 
            label124.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label124.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label124.Location = new System.Drawing.Point(17, 805);
            label124.Name = "label124";
            label124.Size = new System.Drawing.Size(37, 20);
            label124.TabIndex = 294;
            label124.Text = "14";
            label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label109
            // 
            label109.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label109.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label109.Location = new System.Drawing.Point(376, 784);
            label109.Name = "label109";
            label109.Size = new System.Drawing.Size(405, 20);
            label109.TabIndex = 293;
            // 
            // label110
            // 
            label110.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label110.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label110.Location = new System.Drawing.Point(186, 784);
            label110.Name = "label110";
            label110.Size = new System.Drawing.Size(187, 20);
            label110.TabIndex = 292;
            // 
            // label111
            // 
            label111.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label111.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label111.Location = new System.Drawing.Point(56, 784);
            label111.Name = "label111";
            label111.Size = new System.Drawing.Size(124, 20);
            label111.TabIndex = 291;
            // 
            // label112
            // 
            label112.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label112.Location = new System.Drawing.Point(17, 784);
            label112.Name = "label112";
            label112.Size = new System.Drawing.Size(37, 20);
            label112.TabIndex = 290;
            label112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label113
            // 
            label113.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label113.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label113.Location = new System.Drawing.Point(375, 763);
            label113.Name = "label113";
            label113.Size = new System.Drawing.Size(405, 20);
            label113.TabIndex = 289;
            // 
            // label114
            // 
            label114.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label114.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label114.Location = new System.Drawing.Point(186, 763);
            label114.Name = "label114";
            label114.Size = new System.Drawing.Size(187, 20);
            label114.TabIndex = 288;
            // 
            // label115
            // 
            label115.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label115.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label115.Location = new System.Drawing.Point(56, 763);
            label115.Name = "label115";
            label115.Size = new System.Drawing.Size(124, 20);
            label115.TabIndex = 287;
            // 
            // label116
            // 
            label116.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label116.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label116.Location = new System.Drawing.Point(17, 763);
            label116.Name = "label116";
            label116.Size = new System.Drawing.Size(37, 20);
            label116.TabIndex = 286;
            label116.Text = "13";
            label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label101
            // 
            label101.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label101.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label101.Location = new System.Drawing.Point(375, 742);
            label101.Name = "label101";
            label101.Size = new System.Drawing.Size(405, 20);
            label101.TabIndex = 285;
            // 
            // label102
            // 
            label102.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label102.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label102.Location = new System.Drawing.Point(185, 742);
            label102.Name = "label102";
            label102.Size = new System.Drawing.Size(187, 20);
            label102.TabIndex = 284;
            // 
            // label103
            // 
            label103.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label103.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label103.Location = new System.Drawing.Point(56, 742);
            label103.Name = "label103";
            label103.Size = new System.Drawing.Size(124, 20);
            label103.TabIndex = 283;
            // 
            // label104
            // 
            label104.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label104.Location = new System.Drawing.Point(16, 742);
            label104.Name = "label104";
            label104.Size = new System.Drawing.Size(37, 20);
            label104.TabIndex = 282;
            label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label105
            // 
            label105.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label105.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label105.Location = new System.Drawing.Point(375, 721);
            label105.Name = "label105";
            label105.Size = new System.Drawing.Size(405, 20);
            label105.TabIndex = 281;
            // 
            // label106
            // 
            label106.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label106.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label106.Location = new System.Drawing.Point(185, 721);
            label106.Name = "label106";
            label106.Size = new System.Drawing.Size(187, 20);
            label106.TabIndex = 280;
            // 
            // label107
            // 
            label107.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label107.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label107.Location = new System.Drawing.Point(56, 721);
            label107.Name = "label107";
            label107.Size = new System.Drawing.Size(124, 20);
            label107.TabIndex = 279;
            // 
            // label108
            // 
            label108.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label108.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label108.Location = new System.Drawing.Point(16, 721);
            label108.Name = "label108";
            label108.Size = new System.Drawing.Size(37, 20);
            label108.TabIndex = 278;
            label108.Text = "12";
            label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label93
            // 
            label93.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label93.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label93.Location = new System.Drawing.Point(375, 699);
            label93.Name = "label93";
            label93.Size = new System.Drawing.Size(405, 20);
            label93.TabIndex = 277;
            // 
            // label94
            // 
            label94.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label94.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label94.Location = new System.Drawing.Point(186, 699);
            label94.Name = "label94";
            label94.Size = new System.Drawing.Size(187, 20);
            label94.TabIndex = 276;
            // 
            // label95
            // 
            label95.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label95.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label95.Location = new System.Drawing.Point(56, 699);
            label95.Name = "label95";
            label95.Size = new System.Drawing.Size(124, 20);
            label95.TabIndex = 275;
            // 
            // label96
            // 
            label96.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label96.Location = new System.Drawing.Point(17, 699);
            label96.Name = "label96";
            label96.Size = new System.Drawing.Size(37, 20);
            label96.TabIndex = 274;
            label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label97
            // 
            label97.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label97.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label97.Location = new System.Drawing.Point(375, 678);
            label97.Name = "label97";
            label97.Size = new System.Drawing.Size(405, 20);
            label97.TabIndex = 273;
            // 
            // label98
            // 
            label98.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label98.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label98.Location = new System.Drawing.Point(186, 678);
            label98.Name = "label98";
            label98.Size = new System.Drawing.Size(187, 20);
            label98.TabIndex = 272;
            // 
            // label99
            // 
            label99.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label99.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label99.Location = new System.Drawing.Point(56, 678);
            label99.Name = "label99";
            label99.Size = new System.Drawing.Size(124, 20);
            label99.TabIndex = 271;
            // 
            // label100
            // 
            label100.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label100.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label100.Location = new System.Drawing.Point(17, 678);
            label100.Name = "label100";
            label100.Size = new System.Drawing.Size(37, 20);
            label100.TabIndex = 270;
            label100.Text = "11";
            label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label85
            // 
            label85.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label85.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label85.Location = new System.Drawing.Point(375, 657);
            label85.Name = "label85";
            label85.Size = new System.Drawing.Size(405, 20);
            label85.TabIndex = 269;
            // 
            // label86
            // 
            label86.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label86.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label86.Location = new System.Drawing.Point(185, 657);
            label86.Name = "label86";
            label86.Size = new System.Drawing.Size(187, 20);
            label86.TabIndex = 268;
            // 
            // label87
            // 
            label87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label87.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label87.Location = new System.Drawing.Point(55, 657);
            label87.Name = "label87";
            label87.Size = new System.Drawing.Size(124, 20);
            label87.TabIndex = 267;
            // 
            // label88
            // 
            label88.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label88.Location = new System.Drawing.Point(16, 657);
            label88.Name = "label88";
            label88.Size = new System.Drawing.Size(37, 20);
            label88.TabIndex = 266;
            label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label89
            // 
            label89.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label89.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label89.Location = new System.Drawing.Point(375, 636);
            label89.Name = "label89";
            label89.Size = new System.Drawing.Size(405, 20);
            label89.TabIndex = 265;
            // 
            // label90
            // 
            label90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label90.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label90.Location = new System.Drawing.Point(185, 636);
            label90.Name = "label90";
            label90.Size = new System.Drawing.Size(187, 20);
            label90.TabIndex = 264;
            // 
            // label91
            // 
            label91.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label91.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label91.Location = new System.Drawing.Point(55, 636);
            label91.Name = "label91";
            label91.Size = new System.Drawing.Size(124, 20);
            label91.TabIndex = 263;
            // 
            // label92
            // 
            label92.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label92.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label92.Location = new System.Drawing.Point(16, 635);
            label92.Name = "label92";
            label92.Size = new System.Drawing.Size(37, 20);
            label92.TabIndex = 262;
            label92.Text = "10";
            label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            label77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label77.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label77.Location = new System.Drawing.Point(376, 615);
            label77.Name = "label77";
            label77.Size = new System.Drawing.Size(405, 20);
            label77.TabIndex = 261;
            // 
            // label78
            // 
            label78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label78.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label78.Location = new System.Drawing.Point(186, 615);
            label78.Name = "label78";
            label78.Size = new System.Drawing.Size(187, 20);
            label78.TabIndex = 260;
            // 
            // label79
            // 
            label79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label79.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label79.Location = new System.Drawing.Point(56, 615);
            label79.Name = "label79";
            label79.Size = new System.Drawing.Size(124, 20);
            label79.TabIndex = 259;
            // 
            // label80
            // 
            label80.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label80.Location = new System.Drawing.Point(17, 615);
            label80.Name = "label80";
            label80.Size = new System.Drawing.Size(37, 20);
            label80.TabIndex = 258;
            label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            label81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label81.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label81.Location = new System.Drawing.Point(376, 594);
            label81.Name = "label81";
            label81.Size = new System.Drawing.Size(405, 20);
            label81.TabIndex = 257;
            // 
            // label82
            // 
            label82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label82.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label82.Location = new System.Drawing.Point(186, 594);
            label82.Name = "label82";
            label82.Size = new System.Drawing.Size(187, 20);
            label82.TabIndex = 256;
            // 
            // label83
            // 
            label83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label83.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label83.Location = new System.Drawing.Point(56, 594);
            label83.Name = "label83";
            label83.Size = new System.Drawing.Size(124, 20);
            label83.TabIndex = 255;
            // 
            // label84
            // 
            label84.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label84.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label84.Location = new System.Drawing.Point(17, 593);
            label84.Name = "label84";
            label84.Size = new System.Drawing.Size(37, 20);
            label84.TabIndex = 254;
            label84.Text = "9";
            label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            label69.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label69.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label69.Location = new System.Drawing.Point(376, 573);
            label69.Name = "label69";
            label69.Size = new System.Drawing.Size(405, 20);
            label69.TabIndex = 253;
            // 
            // label70
            // 
            label70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label70.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label70.Location = new System.Drawing.Point(186, 573);
            label70.Name = "label70";
            label70.Size = new System.Drawing.Size(187, 20);
            label70.TabIndex = 252;
            // 
            // label71
            // 
            label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label71.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label71.Location = new System.Drawing.Point(56, 573);
            label71.Name = "label71";
            label71.Size = new System.Drawing.Size(124, 20);
            label71.TabIndex = 251;
            // 
            // label72
            // 
            label72.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label72.Location = new System.Drawing.Point(16, 575);
            label72.Name = "label72";
            label72.Size = new System.Drawing.Size(37, 20);
            label72.TabIndex = 250;
            label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            label73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label73.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label73.Location = new System.Drawing.Point(376, 552);
            label73.Name = "label73";
            label73.Size = new System.Drawing.Size(405, 20);
            label73.TabIndex = 249;
            // 
            // label74
            // 
            label74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label74.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label74.Location = new System.Drawing.Point(186, 552);
            label74.Name = "label74";
            label74.Size = new System.Drawing.Size(187, 20);
            label74.TabIndex = 248;
            // 
            // label75
            // 
            label75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label75.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label75.Location = new System.Drawing.Point(56, 552);
            label75.Name = "label75";
            label75.Size = new System.Drawing.Size(124, 20);
            label75.TabIndex = 247;
            // 
            // label76
            // 
            label76.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label76.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label76.Location = new System.Drawing.Point(16, 553);
            label76.Name = "label76";
            label76.Size = new System.Drawing.Size(37, 20);
            label76.TabIndex = 246;
            label76.Text = "8";
            label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label61.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label61.Location = new System.Drawing.Point(376, 531);
            label61.Name = "label61";
            label61.Size = new System.Drawing.Size(405, 20);
            label61.TabIndex = 245;
            // 
            // label62
            // 
            label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label62.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label62.Location = new System.Drawing.Point(186, 531);
            label62.Name = "label62";
            label62.Size = new System.Drawing.Size(187, 20);
            label62.TabIndex = 244;
            // 
            // label63
            // 
            label63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label63.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label63.Location = new System.Drawing.Point(56, 531);
            label63.Name = "label63";
            label63.Size = new System.Drawing.Size(124, 20);
            label63.TabIndex = 243;
            // 
            // label64
            // 
            label64.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label64.Location = new System.Drawing.Point(16, 533);
            label64.Name = "label64";
            label64.Size = new System.Drawing.Size(37, 20);
            label64.TabIndex = 242;
            label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            label65.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label65.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label65.Location = new System.Drawing.Point(376, 510);
            label65.Name = "label65";
            label65.Size = new System.Drawing.Size(405, 20);
            label65.TabIndex = 241;
            // 
            // label66
            // 
            label66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label66.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label66.Location = new System.Drawing.Point(186, 510);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(187, 20);
            label66.TabIndex = 240;
            // 
            // label67
            // 
            label67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label67.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label67.Location = new System.Drawing.Point(56, 510);
            label67.Name = "label67";
            label67.Size = new System.Drawing.Size(124, 20);
            label67.TabIndex = 239;
            // 
            // label68
            // 
            label68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label68.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label68.Location = new System.Drawing.Point(16, 511);
            label68.Name = "label68";
            label68.Size = new System.Drawing.Size(37, 20);
            label68.TabIndex = 238;
            label68.Text = "7";
            label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label53.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label53.Location = new System.Drawing.Point(376, 489);
            label53.Name = "label53";
            label53.Size = new System.Drawing.Size(405, 20);
            label53.TabIndex = 237;
            // 
            // label54
            // 
            label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label54.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label54.Location = new System.Drawing.Point(186, 489);
            label54.Name = "label54";
            label54.Size = new System.Drawing.Size(187, 20);
            label54.TabIndex = 236;
            // 
            // label55
            // 
            label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label55.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label55.Location = new System.Drawing.Point(56, 489);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(124, 20);
            label55.TabIndex = 235;
            // 
            // label56
            // 
            label56.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label56.Location = new System.Drawing.Point(16, 491);
            label56.Name = "label56";
            label56.Size = new System.Drawing.Size(37, 20);
            label56.TabIndex = 234;
            label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label57.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label57.Location = new System.Drawing.Point(376, 468);
            label57.Name = "label57";
            label57.Size = new System.Drawing.Size(405, 20);
            label57.TabIndex = 233;
            // 
            // label58
            // 
            label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label58.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label58.Location = new System.Drawing.Point(186, 468);
            label58.Name = "label58";
            label58.Size = new System.Drawing.Size(187, 20);
            label58.TabIndex = 232;
            // 
            // label59
            // 
            label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label59.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label59.Location = new System.Drawing.Point(56, 468);
            label59.Name = "label59";
            label59.Size = new System.Drawing.Size(124, 20);
            label59.TabIndex = 231;
            // 
            // lblTitrePage
            // 
            lblTitrePage.AutoSize = true;
            lblTitrePage.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitrePage.Location = new System.Drawing.Point(39, 9);
            lblTitrePage.Name = "lblTitrePage";
            lblTitrePage.Size = new System.Drawing.Size(132, 29);
            lblTitrePage.TabIndex = 4;
            lblTitrePage.Text = "Fournisseur";
            // 
            // label60
            // 
            label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label60.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label60.Location = new System.Drawing.Point(16, 469);
            label60.Name = "label60";
            label60.Size = new System.Drawing.Size(37, 20);
            label60.TabIndex = 230;
            label60.Text = "6";
            label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label45.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.Location = new System.Drawing.Point(376, 447);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(405, 20);
            label45.TabIndex = 229;
            // 
            // label46
            // 
            label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label46.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.Location = new System.Drawing.Point(186, 447);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(187, 20);
            label46.TabIndex = 228;
            // 
            // label47
            // 
            label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label47.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label47.Location = new System.Drawing.Point(56, 447);
            label47.Name = "label47";
            label47.Size = new System.Drawing.Size(124, 20);
            label47.TabIndex = 227;
            // 
            // label48
            // 
            label48.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label48.Location = new System.Drawing.Point(16, 449);
            label48.Name = "label48";
            label48.Size = new System.Drawing.Size(37, 20);
            label48.TabIndex = 226;
            label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label49.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label49.Location = new System.Drawing.Point(376, 426);
            label49.Name = "label49";
            label49.Size = new System.Drawing.Size(405, 20);
            label49.TabIndex = 225;
            // 
            // label50
            // 
            label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label50.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.Location = new System.Drawing.Point(186, 426);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(187, 20);
            label50.TabIndex = 224;
            // 
            // label51
            // 
            label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label51.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label51.Location = new System.Drawing.Point(56, 426);
            label51.Name = "label51";
            label51.Size = new System.Drawing.Size(124, 20);
            label51.TabIndex = 223;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDate.Location = new System.Drawing.Point(606, 87);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(83, 15);
            lblDate.TabIndex = 26;
            lblDate.Text = "Date * lbldate";
            lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPiedPage
            // 
            lblPiedPage.AutoSize = true;
            lblPiedPage.Dock = System.Windows.Forms.DockStyle.Right;
            lblPiedPage.Font = new System.Drawing.Font("Calibri", 12F);
            lblPiedPage.Location = new System.Drawing.Point(676, 0);
            lblPiedPage.Name = "lblPiedPage";
            lblPiedPage.Size = new System.Drawing.Size(85, 19);
            lblPiedPage.TabIndex = 15;
            lblPiedPage.Text = "lblPiedPage";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Dock = System.Windows.Forms.DockStyle.Right;
            lblPage.Font = new System.Drawing.Font("Calibri", 12F);
            lblPage.Location = new System.Drawing.Point(761, 0);
            lblPage.Name = "lblPage";
            lblPage.Size = new System.Drawing.Size(57, 19);
            lblPage.TabIndex = 14;
            lblPage.Text = "lblPage";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(24, 62);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(88, 15);
            label8.TabIndex = 33;
            label8.Text = "Nom du projet";
            // 
            // lblNoSoum
            // 
            lblNoSoum.AutoSize = true;
            lblNoSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoSoum.Location = new System.Drawing.Point(141, 87);
            lblNoSoum.Name = "lblNoSoum";
            lblNoSoum.Size = new System.Drawing.Size(67, 15);
            lblNoSoum.TabIndex = 18;
            lblNoSoum.Text = "lblNoSoum";
            // 
            // lblTitreNoSoum
            // 
            lblTitreNoSoum.AutoSize = true;
            lblTitreNoSoum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreNoSoum.Location = new System.Drawing.Point(17, 87);
            lblTitreNoSoum.Name = "lblTitreNoSoum";
            lblTitreNoSoum.Size = new System.Drawing.Size(93, 15);
            lblTitreNoSoum.TabIndex = 17;
            lblTitreNoSoum.Text = "lblTitreNoSoum";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.Location = new System.Drawing.Point(674, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(143, 63);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblTitreCommande
            // 
            lblTitreCommande.AutoSize = true;
            lblTitreCommande.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreCommande.Location = new System.Drawing.Point(134, 62);
            lblTitreCommande.Name = "lblTitreCommande";
            lblTitreCommande.Size = new System.Drawing.Size(109, 15);
            lblTitreCommande.TabIndex = 22;
            lblTitreCommande.Text = "lblTitreCommande";
            // 
            // lblNoBC
            // 
            lblNoBC.AutoSize = true;
            lblNoBC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoBC.Location = new System.Drawing.Point(141, 106);
            lblNoBC.Name = "lblNoBC";
            lblNoBC.Size = new System.Drawing.Size(50, 15);
            lblNoBC.TabIndex = 24;
            lblNoBC.Text = "lblNoBC";
            // 
            // lblTitreBC
            // 
            lblTitreBC.AutoSize = true;
            lblTitreBC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreBC.Location = new System.Drawing.Point(17, 106);
            lblTitreBC.Name = "lblTitreBC";
            lblTitreBC.Size = new System.Drawing.Size(60, 15);
            lblTitreBC.TabIndex = 19;
            lblTitreBC.Text = "lblTitreBC";
            // 
            // label52
            // 
            label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label52.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label52.Location = new System.Drawing.Point(16, 427);
            label52.Name = "label52";
            label52.Size = new System.Drawing.Size(37, 20);
            label52.TabIndex = 222;
            label52.Text = "5";
            label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label37.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.Location = new System.Drawing.Point(376, 405);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(405, 20);
            label37.TabIndex = 221;
            // 
            // label38
            // 
            label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label38.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.Location = new System.Drawing.Point(186, 405);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(187, 20);
            label38.TabIndex = 220;
            // 
            // label39
            // 
            label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label39.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.Location = new System.Drawing.Point(56, 405);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(124, 20);
            label39.TabIndex = 219;
            // 
            // label40
            // 
            label40.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label40.Location = new System.Drawing.Point(16, 407);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(37, 20);
            label40.TabIndex = 218;
            label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label41.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.Location = new System.Drawing.Point(376, 384);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(405, 20);
            label41.TabIndex = 217;
            // 
            // label42
            // 
            label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label42.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.Location = new System.Drawing.Point(186, 384);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(187, 20);
            label42.TabIndex = 216;
            // 
            // label43
            // 
            label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label43.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label43.Location = new System.Drawing.Point(56, 384);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(124, 20);
            label43.TabIndex = 215;
            // 
            // label44
            // 
            label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label44.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label44.Location = new System.Drawing.Point(16, 385);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(37, 20);
            label44.TabIndex = 214;
            label44.Text = "4";
            label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.Location = new System.Drawing.Point(376, 363);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(405, 20);
            label29.TabIndex = 213;
            // 
            // label30
            // 
            label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label30.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.Location = new System.Drawing.Point(186, 363);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(187, 20);
            label30.TabIndex = 212;
            // 
            // label31
            // 
            label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label31.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.Location = new System.Drawing.Point(56, 363);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(124, 20);
            label31.TabIndex = 211;
            // 
            // label32
            // 
            label32.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label32.Location = new System.Drawing.Point(16, 365);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(37, 20);
            label32.TabIndex = 210;
            label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.Location = new System.Drawing.Point(376, 342);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(405, 20);
            label33.TabIndex = 209;
            // 
            // label34
            // 
            label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(186, 342);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(187, 20);
            label34.TabIndex = 208;
            // 
            // label35
            // 
            label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label35.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.Location = new System.Drawing.Point(56, 342);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(124, 20);
            label35.TabIndex = 207;
            // 
            // label36
            // 
            label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label36.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label36.Location = new System.Drawing.Point(16, 343);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(37, 20);
            label36.TabIndex = 206;
            label36.Text = "3";
            label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(376, 321);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(405, 20);
            label10.TabIndex = 205;
            // 
            // label22
            // 
            label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.Location = new System.Drawing.Point(186, 321);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(187, 20);
            label22.TabIndex = 204;
            // 
            // label23
            // 
            label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(56, 321);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(124, 20);
            label23.TabIndex = 203;
            // 
            // label24
            // 
            label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.Location = new System.Drawing.Point(16, 323);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(37, 20);
            label24.TabIndex = 202;
            label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.Location = new System.Drawing.Point(376, 300);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(405, 20);
            label25.TabIndex = 201;
            // 
            // label26
            // 
            label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(186, 300);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(187, 20);
            label26.TabIndex = 200;
            // 
            // label27
            // 
            label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.Location = new System.Drawing.Point(56, 300);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(124, 20);
            label27.TabIndex = 199;
            // 
            // label28
            // 
            label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.Location = new System.Drawing.Point(16, 301);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(37, 20);
            label28.TabIndex = 198;
            label28.Text = "2";
            label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.Location = new System.Drawing.Point(376, 279);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(405, 20);
            label18.TabIndex = 197;
            // 
            // label19
            // 
            label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(186, 279);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(187, 20);
            label19.TabIndex = 196;
            // 
            // label20
            // 
            label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(56, 279);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(124, 20);
            label20.TabIndex = 195;
            // 
            // label21
            // 
            label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.Location = new System.Drawing.Point(16, 281);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(37, 20);
            label21.TabIndex = 194;
            label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(376, 258);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(405, 20);
            label14.TabIndex = 193;
            // 
            // label15
            // 
            label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(186, 258);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(187, 20);
            label15.TabIndex = 192;
            // 
            // label16
            // 
            label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(56, 258);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(124, 20);
            label16.TabIndex = 191;
            // 
            // label17
            // 
            label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(16, 260);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(37, 20);
            label17.TabIndex = 190;
            label17.Text = "1";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(376, 236);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(405, 20);
            label13.TabIndex = 189;
            label13.Text = "Commentaires";
            // 
            // label12
            // 
            label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(186, 236);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(187, 20);
            label12.TabIndex = 188;
            label12.Text = "Contact";
            // 
            // label11
            // 
            label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(56, 236);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(124, 20);
            label11.TabIndex = 187;
            label11.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(543, 177);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 15);
            label7.TabIndex = 186;
            label7.Text = "Date fermeture";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(655, 177);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(71, 15);
            label9.TabIndex = 185;
            label9.Text = "8888-88-88";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(633, 141);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 15);
            label6.TabIndex = 184;
            label6.Text = "88:88:88";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(582, 141);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 15);
            label5.TabIndex = 183;
            label5.Text = "Heure";
            // 
            // lblProjet
            // 
            lblProjet.AutoSize = true;
            lblProjet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjet.Location = new System.Drawing.Point(90, 199);
            lblProjet.Name = "lblProjet";
            lblProjet.Size = new System.Drawing.Size(54, 15);
            lblProjet.TabIndex = 182;
            lblProjet.Text = "lblProjet";
            // 
            // lbTitrelProjet
            // 
            lbTitrelProjet.AutoSize = true;
            lbTitrelProjet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbTitrelProjet.Location = new System.Drawing.Point(21, 200);
            lbTitrelProjet.Name = "lbTitrelProjet";
            lbTitrelProjet.Size = new System.Drawing.Size(41, 15);
            lbTitrelProjet.TabIndex = 181;
            lbTitrelProjet.Text = "Projet";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClient.Location = new System.Drawing.Point(86, 163);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(52, 15);
            lblClient.TabIndex = 180;
            lblClient.Text = "lblClient";
            // 
            // lblTitreClient
            // 
            lblTitreClient.AutoSize = true;
            lblTitreClient.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreClient.Location = new System.Drawing.Point(21, 162);
            lblTitreClient.Name = "lblTitreClient";
            lblTitreClient.Size = new System.Drawing.Size(39, 15);
            lblTitreClient.TabIndex = 179;
            lblTitreClient.Text = "Client";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblPiedPage);
            panel4.Controls.Add(lblPage);
            panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel4.Location = new System.Drawing.Point(0, 1038);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(818, 23);
            panel4.TabIndex = 166;
            // 
            // lblDateOuverture
            // 
            lblDateOuverture.AutoSize = true;
            lblDateOuverture.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateOuverture.Location = new System.Drawing.Point(217, 139);
            lblDateOuverture.Name = "lblDateOuverture";
            lblDateOuverture.Size = new System.Drawing.Size(71, 15);
            lblDateOuverture.TabIndex = 171;
            lblDateOuverture.Text = "8888-88-88";
            // 
            // lblTitreContact
            // 
            lblTitreContact.AutoSize = true;
            lblTitreContact.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreContact.Location = new System.Drawing.Point(21, 178);
            lblTitreContact.Name = "lblTitreContact";
            lblTitreContact.Size = new System.Drawing.Size(49, 15);
            lblTitreContact.TabIndex = 175;
            lblTitreContact.Text = "Contact";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblContact.Location = new System.Drawing.Point(86, 177);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(62, 15);
            lblContact.TabIndex = 176;
            lblContact.Text = "lblContact";
            // 
            // lblTitreTel
            // 
            lblTitreTel.AutoSize = true;
            lblTitreTel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTel.Location = new System.Drawing.Point(308, 200);
            lblTitreTel.Name = "lblTitreTel";
            lblTitreTel.Size = new System.Drawing.Size(25, 15);
            lblTitreTel.TabIndex = 177;
            lblTitreTel.Text = "Tél.";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTel.Location = new System.Drawing.Point(337, 200);
            lblTel.Name = "lblTel";
            lblTel.Size = new System.Drawing.Size(35, 15);
            lblTel.TabIndex = 174;
            lblTel.Text = "lblTel";
            // 
            // lbltitredate
            // 
            lbltitredate.AutoSize = true;
            lbltitredate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbltitredate.Location = new System.Drawing.Point(93, 139);
            lbltitredate.Name = "lbltitredate";
            lbltitredate.Size = new System.Drawing.Size(102, 15);
            lbltitredate.TabIndex = 172;
            lbltitredate.Text = "Date d\'ouverture";
            // 
            // lbltitredatereq
            // 
            lbltitredatereq.AutoSize = true;
            lbltitredatereq.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbltitredatereq.Location = new System.Drawing.Point(338, 139);
            lbltitredatereq.Name = "lbltitredatereq";
            lbltitredatereq.Size = new System.Drawing.Size(77, 15);
            lbltitredatereq.TabIndex = 173;
            lbltitredatereq.Text = "Date requise";
            // 
            // lblDateRequise
            // 
            lblDateRequise.AutoSize = true;
            lblDateRequise.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateRequise.Location = new System.Drawing.Point(436, 139);
            lblDateRequise.Name = "lblDateRequise";
            lblDateRequise.Size = new System.Drawing.Size(71, 15);
            lblDateRequise.TabIndex = 169;
            lblDateRequise.Text = "8888-88-88";
            // 
            // lblTitreFax
            // 
            lblTitreFax.AutoSize = true;
            lblTitreFax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreFax.Location = new System.Drawing.Point(543, 200);
            lblTitreFax.Name = "lblTitreFax";
            lblTitreFax.Size = new System.Drawing.Size(25, 15);
            lblTitreFax.TabIndex = 170;
            lblTitreFax.Text = "Fax";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFax.Location = new System.Drawing.Point(574, 200);
            lblFax.Name = "lblFax";
            lblFax.Size = new System.Drawing.Size(38, 15);
            lblFax.TabIndex = 168;
            lblFax.Text = "lblFax";
            // 
            // ViewFournisseur
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(lblDate);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label125);
            Controls.Add(lblTitrePage);
            Controls.Add(label126);
            Controls.Add(label127);
            Controls.Add(lblNoSoum);
            Controls.Add(label128);
            Controls.Add(lblTitreCommande);
            Controls.Add(label129);
            Controls.Add(lblNoBC);
            Controls.Add(label130);
            Controls.Add(lblTitreNoSoum);
            Controls.Add(label131);
            Controls.Add(lblTitreBC);
            Controls.Add(label132);
            Controls.Add(label117);
            Controls.Add(label118);
            Controls.Add(label119);
            Controls.Add(label120);
            Controls.Add(label121);
            Controls.Add(label122);
            Controls.Add(label123);
            Controls.Add(label124);
            Controls.Add(label109);
            Controls.Add(label110);
            Controls.Add(label111);
            Controls.Add(label112);
            Controls.Add(label113);
            Controls.Add(label114);
            Controls.Add(label115);
            Controls.Add(label116);
            Controls.Add(label101);
            Controls.Add(label102);
            Controls.Add(label103);
            Controls.Add(label104);
            Controls.Add(label105);
            Controls.Add(label106);
            Controls.Add(label107);
            Controls.Add(label108);
            Controls.Add(label93);
            Controls.Add(label94);
            Controls.Add(label95);
            Controls.Add(label96);
            Controls.Add(label97);
            Controls.Add(label98);
            Controls.Add(label99);
            Controls.Add(label100);
            Controls.Add(label85);
            Controls.Add(label86);
            Controls.Add(label87);
            Controls.Add(label88);
            Controls.Add(label89);
            Controls.Add(label90);
            Controls.Add(label91);
            Controls.Add(label92);
            Controls.Add(label77);
            Controls.Add(label78);
            Controls.Add(label79);
            Controls.Add(label80);
            Controls.Add(label81);
            Controls.Add(label82);
            Controls.Add(label83);
            Controls.Add(label84);
            Controls.Add(label69);
            Controls.Add(label70);
            Controls.Add(label71);
            Controls.Add(label72);
            Controls.Add(label73);
            Controls.Add(label74);
            Controls.Add(label75);
            Controls.Add(label76);
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
            Controls.Add(label56);
            Controls.Add(label57);
            Controls.Add(label58);
            Controls.Add(label59);
            Controls.Add(label60);
            Controls.Add(label45);
            Controls.Add(label46);
            Controls.Add(label47);
            Controls.Add(label48);
            Controls.Add(label49);
            Controls.Add(label50);
            Controls.Add(label51);
            Controls.Add(label52);
            Controls.Add(label37);
            Controls.Add(label38);
            Controls.Add(label39);
            Controls.Add(label40);
            Controls.Add(label41);
            Controls.Add(label42);
            Controls.Add(label43);
            Controls.Add(label44);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label32);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(label35);
            Controls.Add(label36);
            Controls.Add(label10);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewFournisseur";
            Text = "ViewFournisseur";
            Load += new System.EventHandler(ViewFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label label125;
        internal static Label label126;
        internal static Label label127;
        internal static Label label128;
        internal static Label label129;
        internal static Label label130;
        internal static Label label131;
        internal static Label label132;
        internal static Label label117;
        internal static Label label118;
        internal static Label label119;
        internal static Label label120;
        internal static Label label121;
        internal static Label label122;
        internal static Label label123;
        internal static Label label124;
        internal static Label label109;
        internal static Label label110;
        internal static Label label111;
        internal static Label label112;
        internal static Label label113;
        internal static Label label114;
        internal static Label label115;
        internal static Label label116;
        internal static Label label101;
        internal static Label label102;
        internal static Label label103;
        internal static Label label104;
        internal static Label label105;
        internal static Label label106;
        internal static Label label107;
        internal static Label label108;
        internal static Label label93;
        internal static Label label94;
        internal static Label label95;
        internal static Label label96;
        internal static Label label97;
        internal static Label label98;
        internal static Label label99;
        internal static Label label100;
        internal static Label label85;
        internal static Label label86;
        internal static Label label87;
        internal static Label label88;
        internal static Label label89;
        internal static Label label90;
        internal static Label label91;
        internal static Label label92;
        internal static Label label77;
        internal static Label label78;
        internal static Label label79;
        internal static Label label80;
        internal static Label label81;
        internal static Label label82;
        internal static Label label83;
        internal static Label label84;
        internal static Label label69;
        internal static Label label70;
        internal static Label label71;
        internal static Label label72;
        internal static Label label73;
        internal static Label label74;
        internal static Label label75;
        internal static Label label76;
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
        internal static Label label56;
        internal static Label label57;
        internal static Label label58;
        internal static Label label59;
        internal static Label lblTitrePage;
        internal static Label label60;
        internal static Label label45;
        internal static Label label46;
        internal static Label label47;
        internal static Label label48;
        internal static Label label49;
        internal static Label label50;
        internal static Label label51;
        internal static Label lblDate;
        internal static Label lblPiedPage;
        internal static Label lblPage;
        internal static Label label8;
        internal static Label lblNoSoum;
        internal static Label lblTitreNoSoum;
        internal static PictureBox pictureBox1;
        internal static Label lblTitreCommande;
        internal static Label lblNoBC;
        internal static Label lblTitreBC;
        internal static Label label52;
        internal static Label label37;
        internal static Label label38;
        internal static Label label39;
        internal static Label label40;
        internal static Label label41;
        internal static Label label42;
        internal static Label label43;
        internal static Label label44;
        internal static Label label29;
        internal static Label label30;
        internal static Label label31;
        internal static Label label32;
        internal static Label label33;
        internal static Label label34;
        internal static Label label35;
        internal static Label label36;
        internal static Label label10;
        internal static Label label22;
        internal static Label label23;
        internal static Label label24;
        internal static Label label25;
        internal static Label label26;
        internal static Label label27;
        internal static Label label28;
        internal static Label label18;
        internal static Label label19;
        internal static Label label20;
        internal static Label label21;
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
        internal static  Label lblNoProj;
        internal static  Label lblProjetNom;
        internal static  Label lblDateDue;
        public static bool Orientation;
        Bitmap memoryImage;
        PrintDocument printDocument1 = new PrintDocument();
        internal static ADODB.Recordset DataSource;
        public ViewFournisseur()
        {
            InitializeComponent();
        }
        private void ViewFournisseur_Load(object sender, EventArgs e)
        {
            ViewFournisseur.Orientation = Orientation;
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.DefaultPageSettings.Color = false;
            printDocument1.DefaultPageSettings.Landscape = Program.isLandscape; //pour le mode paysage
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.PrinterSettings.Copies = 1;
            printDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(Program.ImpressionFormulaire);
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
            if (MessageBox.Show("Voulez vous fermer cette vue?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
