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
namespace ControleurServeur
{
    public class ViewFinFab : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFinFab));
            this.ViewTitre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewTitre
            // 
            this.ViewTitre.AutoSize = true;
            this.ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTitre.Location = new System.Drawing.Point(98, 22);
            this.ViewTitre.Name = "ViewTitre";
            this.ViewTitre.Size = new System.Drawing.Size(446, 36);
            this.ViewTitre.TabIndex = 418;
            this.ViewTitre.Tag = "";
            this.ViewTitre.Text = "Documents pour fins de fabrication";
            this.ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            this.pictureBox1.Location = new System.Drawing.Point(972, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 69);
            this.pictureBox1.TabIndex = 419;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 420;
            this.label2.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(859, 20);
            this.textBox1.TabIndex = 421;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1026, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 423;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1023, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 422;
            this.label3.Text = "Nombre de page";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(913, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 20);
            this.textBox3.TabIndex = 425;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(910, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 424;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(48, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1061, 23);
            this.label5.TabIndex = 426;
            this.label5.Text = "Dessins mécaniques";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(48, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 427;
            this.label6.Text = "#";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(94, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 23);
            this.label7.TabIndex = 428;
            this.label7.Text = "Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(271, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(613, 23);
            this.label8.TabIndex = 429;
            this.label8.Text = "Dessins";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(886, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 23);
            this.label9.TabIndex = 430;
            this.label9.Text = "#";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(933, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 431;
            this.label10.Text = "Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(1018, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 432;
            this.label11.Text = "Nombre de page";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(1018, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 23);
            this.label12.TabIndex = 438;
            this.label12.Text = " ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(933, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 23);
            this.label13.TabIndex = 437;
            this.label13.Text = " ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(886, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 23);
            this.label14.TabIndex = 436;
            this.label14.Text = " ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(271, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(613, 23);
            this.label15.TabIndex = 435;
            this.label15.Text = " ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(94, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 23);
            this.label16.TabIndex = 434;
            this.label16.Text = " ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(48, 213);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 23);
            this.label17.TabIndex = 433;
            this.label17.Text = "1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(1018, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 23);
            this.label18.TabIndex = 444;
            this.label18.Text = " ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(933, 238);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 23);
            this.label19.TabIndex = 443;
            this.label19.Text = " ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(886, 238);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 23);
            this.label20.TabIndex = 442;
            this.label20.Text = " ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(271, 238);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(613, 23);
            this.label21.TabIndex = 441;
            this.label21.Text = " ";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(94, 238);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(174, 23);
            this.label22.TabIndex = 440;
            this.label22.Text = " ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(48, 238);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 23);
            this.label23.TabIndex = 439;
            this.label23.Text = "2";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.Location = new System.Drawing.Point(1018, 289);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 23);
            this.label24.TabIndex = 456;
            this.label24.Text = " ";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(933, 289);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 23);
            this.label25.TabIndex = 455;
            this.label25.Text = " ";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Location = new System.Drawing.Point(886, 289);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 23);
            this.label26.TabIndex = 454;
            this.label26.Text = " ";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Location = new System.Drawing.Point(271, 289);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(613, 23);
            this.label27.TabIndex = 453;
            this.label27.Text = " ";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.Location = new System.Drawing.Point(94, 289);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(174, 23);
            this.label28.TabIndex = 452;
            this.label28.Text = " ";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Location = new System.Drawing.Point(48, 289);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 23);
            this.label29.TabIndex = 451;
            this.label29.Text = "4";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label30.Location = new System.Drawing.Point(1018, 264);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 23);
            this.label30.TabIndex = 450;
            this.label30.Text = " ";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label31.Location = new System.Drawing.Point(933, 264);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(82, 23);
            this.label31.TabIndex = 449;
            this.label31.Text = " ";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Location = new System.Drawing.Point(886, 264);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 23);
            this.label32.TabIndex = 448;
            this.label32.Text = " ";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label33.Location = new System.Drawing.Point(271, 264);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(613, 23);
            this.label33.TabIndex = 447;
            this.label33.Text = " ";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label34.Location = new System.Drawing.Point(94, 264);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(174, 23);
            this.label34.TabIndex = 446;
            this.label34.Text = " ";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(48, 264);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 23);
            this.label35.TabIndex = 445;
            this.label35.Text = "3";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Location = new System.Drawing.Point(1018, 339);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(91, 23);
            this.label36.TabIndex = 468;
            this.label36.Text = " ";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label37.Location = new System.Drawing.Point(933, 339);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(82, 23);
            this.label37.TabIndex = 467;
            this.label37.Text = " ";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label38.Location = new System.Drawing.Point(886, 339);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(44, 23);
            this.label38.TabIndex = 466;
            this.label38.Text = " ";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label39.Location = new System.Drawing.Point(271, 339);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(613, 23);
            this.label39.TabIndex = 465;
            this.label39.Text = " ";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label40.Location = new System.Drawing.Point(94, 339);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(174, 23);
            this.label40.TabIndex = 464;
            this.label40.Text = " ";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label41.Location = new System.Drawing.Point(48, 339);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 23);
            this.label41.TabIndex = 463;
            this.label41.Tag = "6";
            this.label41.Text = "6";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label42.Location = new System.Drawing.Point(1018, 314);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(91, 23);
            this.label42.TabIndex = 462;
            this.label42.Text = " ";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label43.Location = new System.Drawing.Point(933, 314);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(82, 23);
            this.label43.TabIndex = 461;
            this.label43.Text = " ";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label44.Location = new System.Drawing.Point(886, 314);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(44, 23);
            this.label44.TabIndex = 460;
            this.label44.Text = " ";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label45.Location = new System.Drawing.Point(271, 314);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(613, 23);
            this.label45.TabIndex = 459;
            this.label45.Text = " ";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label46.Location = new System.Drawing.Point(94, 314);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(174, 23);
            this.label46.TabIndex = 458;
            this.label46.Text = " ";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label47.Location = new System.Drawing.Point(48, 314);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(44, 23);
            this.label47.TabIndex = 457;
            this.label47.Tag = "5";
            this.label47.Text = "5";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label48.Location = new System.Drawing.Point(1018, 390);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(91, 23);
            this.label48.TabIndex = 480;
            this.label48.Text = " ";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label49.Location = new System.Drawing.Point(933, 390);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(82, 23);
            this.label49.TabIndex = 479;
            this.label49.Text = " ";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label50.Location = new System.Drawing.Point(886, 390);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(44, 23);
            this.label50.TabIndex = 478;
            this.label50.Text = " ";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label51.Location = new System.Drawing.Point(271, 390);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(613, 23);
            this.label51.TabIndex = 477;
            this.label51.Text = " ";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label52.Location = new System.Drawing.Point(94, 390);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(174, 23);
            this.label52.TabIndex = 476;
            this.label52.Text = " ";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label53.Location = new System.Drawing.Point(48, 390);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(44, 23);
            this.label53.TabIndex = 475;
            this.label53.Text = "8";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label54.Location = new System.Drawing.Point(1018, 365);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(91, 23);
            this.label54.TabIndex = 474;
            this.label54.Text = " ";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label55.Location = new System.Drawing.Point(933, 365);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(82, 23);
            this.label55.TabIndex = 473;
            this.label55.Text = " ";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label56.Location = new System.Drawing.Point(886, 365);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(44, 23);
            this.label56.TabIndex = 472;
            this.label56.Text = " ";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            this.label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label57.Location = new System.Drawing.Point(271, 365);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(613, 23);
            this.label57.TabIndex = 471;
            this.label57.Text = " ";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label58.Location = new System.Drawing.Point(94, 365);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(174, 23);
            this.label58.TabIndex = 470;
            this.label58.Text = " ";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label59.Location = new System.Drawing.Point(48, 365);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(44, 23);
            this.label59.TabIndex = 469;
            this.label59.Text = "7";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label60.Location = new System.Drawing.Point(1018, 492);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(91, 23);
            this.label60.TabIndex = 504;
            this.label60.Text = " ";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label61.Location = new System.Drawing.Point(933, 492);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(82, 23);
            this.label61.TabIndex = 503;
            this.label61.Text = " ";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label62.Location = new System.Drawing.Point(886, 492);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(44, 23);
            this.label62.TabIndex = 502;
            this.label62.Text = " ";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label63
            // 
            this.label63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label63.Location = new System.Drawing.Point(271, 492);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(613, 23);
            this.label63.TabIndex = 501;
            this.label63.Text = " ";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label64.Location = new System.Drawing.Point(94, 492);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(174, 23);
            this.label64.TabIndex = 500;
            this.label64.Text = " ";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            this.label65.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label65.Location = new System.Drawing.Point(48, 492);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(44, 23);
            this.label65.TabIndex = 499;
            this.label65.Text = "12";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            this.label66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label66.Location = new System.Drawing.Point(1018, 467);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(91, 23);
            this.label66.TabIndex = 498;
            this.label66.Text = " ";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label67
            // 
            this.label67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label67.Location = new System.Drawing.Point(933, 467);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(82, 23);
            this.label67.TabIndex = 497;
            this.label67.Text = " ";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label68.Location = new System.Drawing.Point(886, 467);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(44, 23);
            this.label68.TabIndex = 496;
            this.label68.Text = " ";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            this.label69.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label69.Location = new System.Drawing.Point(271, 467);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(613, 23);
            this.label69.TabIndex = 495;
            this.label69.Text = " ";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label70.Location = new System.Drawing.Point(94, 467);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(174, 23);
            this.label70.TabIndex = 494;
            this.label70.Text = " ";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label71
            // 
            this.label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label71.Location = new System.Drawing.Point(48, 467);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(44, 23);
            this.label71.TabIndex = 493;
            this.label71.Text = "11";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label72.Location = new System.Drawing.Point(1018, 441);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(91, 23);
            this.label72.TabIndex = 492;
            this.label72.Text = " ";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            this.label73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label73.Location = new System.Drawing.Point(933, 441);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(82, 23);
            this.label73.TabIndex = 491;
            this.label73.Text = " ";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label74.Location = new System.Drawing.Point(886, 441);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(44, 23);
            this.label74.TabIndex = 490;
            this.label74.Text = " ";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label75
            // 
            this.label75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label75.Location = new System.Drawing.Point(271, 441);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(613, 23);
            this.label75.TabIndex = 489;
            this.label75.Text = " ";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label76
            // 
            this.label76.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label76.Location = new System.Drawing.Point(94, 441);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(174, 23);
            this.label76.TabIndex = 488;
            this.label76.Text = " ";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            this.label77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label77.Location = new System.Drawing.Point(48, 441);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(44, 23);
            this.label77.TabIndex = 487;
            this.label77.Text = "10";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label78.Location = new System.Drawing.Point(1018, 416);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(91, 23);
            this.label78.TabIndex = 486;
            this.label78.Text = " ";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label79
            // 
            this.label79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label79.Location = new System.Drawing.Point(933, 416);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(82, 23);
            this.label79.TabIndex = 485;
            this.label79.Text = " ";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label80
            // 
            this.label80.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label80.Location = new System.Drawing.Point(886, 416);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(44, 23);
            this.label80.TabIndex = 484;
            this.label80.Text = " ";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label81.Location = new System.Drawing.Point(271, 416);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(613, 23);
            this.label81.TabIndex = 483;
            this.label81.Text = " ";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label82
            // 
            this.label82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label82.Location = new System.Drawing.Point(94, 416);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(174, 23);
            this.label82.TabIndex = 482;
            this.label82.Text = " ";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label83
            // 
            this.label83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label83.Location = new System.Drawing.Point(48, 416);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(44, 23);
            this.label83.TabIndex = 481;
            this.label83.Text = "9";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label84
            // 
            this.label84.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label84.Location = new System.Drawing.Point(1018, 594);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(91, 23);
            this.label84.TabIndex = 528;
            this.label84.Text = " ";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label85
            // 
            this.label85.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label85.Location = new System.Drawing.Point(933, 594);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(82, 23);
            this.label85.TabIndex = 527;
            this.label85.Text = " ";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label86
            // 
            this.label86.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label86.Location = new System.Drawing.Point(886, 594);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(44, 23);
            this.label86.TabIndex = 526;
            this.label86.Text = " ";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label87.Location = new System.Drawing.Point(271, 594);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(613, 23);
            this.label87.TabIndex = 525;
            this.label87.Text = " ";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label88.Location = new System.Drawing.Point(94, 594);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(174, 23);
            this.label88.TabIndex = 524;
            this.label88.Text = " ";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label89
            // 
            this.label89.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label89.Location = new System.Drawing.Point(48, 594);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(44, 23);
            this.label89.TabIndex = 523;
            this.label89.Text = "16";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label90
            // 
            this.label90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label90.Location = new System.Drawing.Point(1018, 569);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(91, 23);
            this.label90.TabIndex = 522;
            this.label90.Text = " ";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label91
            // 
            this.label91.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label91.Location = new System.Drawing.Point(933, 569);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(82, 23);
            this.label91.TabIndex = 521;
            this.label91.Text = " ";
            this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label92
            // 
            this.label92.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label92.Location = new System.Drawing.Point(886, 569);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(44, 23);
            this.label92.TabIndex = 520;
            this.label92.Text = " ";
            this.label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label93
            // 
            this.label93.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label93.Location = new System.Drawing.Point(271, 569);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(613, 23);
            this.label93.TabIndex = 519;
            this.label93.Text = " ";
            this.label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label94
            // 
            this.label94.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label94.Location = new System.Drawing.Point(94, 569);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(174, 23);
            this.label94.TabIndex = 518;
            this.label94.Text = " ";
            this.label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label95
            // 
            this.label95.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label95.Location = new System.Drawing.Point(48, 569);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(44, 23);
            this.label95.TabIndex = 517;
            this.label95.Text = "15";
            this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label96
            // 
            this.label96.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label96.Location = new System.Drawing.Point(1018, 543);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(91, 23);
            this.label96.TabIndex = 516;
            this.label96.Text = " ";
            this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label97
            // 
            this.label97.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label97.Location = new System.Drawing.Point(933, 543);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(82, 23);
            this.label97.TabIndex = 515;
            this.label97.Text = " ";
            this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label98
            // 
            this.label98.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label98.Location = new System.Drawing.Point(886, 543);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(44, 23);
            this.label98.TabIndex = 514;
            this.label98.Text = " ";
            this.label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label99
            // 
            this.label99.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label99.Location = new System.Drawing.Point(271, 543);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(613, 23);
            this.label99.TabIndex = 513;
            this.label99.Text = " ";
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label100
            // 
            this.label100.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label100.Location = new System.Drawing.Point(94, 543);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(174, 23);
            this.label100.TabIndex = 512;
            this.label100.Text = " ";
            this.label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label101
            // 
            this.label101.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label101.Location = new System.Drawing.Point(48, 543);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(44, 23);
            this.label101.TabIndex = 511;
            this.label101.Text = "14";
            this.label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label102
            // 
            this.label102.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label102.Location = new System.Drawing.Point(1018, 518);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(91, 23);
            this.label102.TabIndex = 510;
            this.label102.Text = " ";
            this.label102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label103
            // 
            this.label103.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label103.Location = new System.Drawing.Point(933, 518);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(82, 23);
            this.label103.TabIndex = 509;
            this.label103.Text = " ";
            this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label104
            // 
            this.label104.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label104.Location = new System.Drawing.Point(886, 518);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(44, 23);
            this.label104.TabIndex = 508;
            this.label104.Text = " ";
            this.label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label105
            // 
            this.label105.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label105.Location = new System.Drawing.Point(271, 518);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(613, 23);
            this.label105.TabIndex = 507;
            this.label105.Text = " ";
            this.label105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label106
            // 
            this.label106.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label106.Location = new System.Drawing.Point(94, 518);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(174, 23);
            this.label106.TabIndex = 506;
            this.label106.Text = " ";
            this.label106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label107
            // 
            this.label107.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label107.Location = new System.Drawing.Point(48, 518);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(44, 23);
            this.label107.TabIndex = 505;
            this.label107.Text = "13";
            this.label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label108
            // 
            this.label108.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label108.Location = new System.Drawing.Point(1018, 696);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(91, 23);
            this.label108.TabIndex = 552;
            this.label108.Text = " ";
            this.label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label109
            // 
            this.label109.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label109.Location = new System.Drawing.Point(933, 696);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(82, 23);
            this.label109.TabIndex = 551;
            this.label109.Text = " ";
            this.label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label110
            // 
            this.label110.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label110.Location = new System.Drawing.Point(886, 696);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(44, 23);
            this.label110.TabIndex = 550;
            this.label110.Text = " ";
            this.label110.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label111
            // 
            this.label111.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label111.Location = new System.Drawing.Point(271, 696);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(613, 23);
            this.label111.TabIndex = 549;
            this.label111.Text = " ";
            this.label111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label112
            // 
            this.label112.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label112.Location = new System.Drawing.Point(94, 696);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(174, 23);
            this.label112.TabIndex = 548;
            this.label112.Text = " ";
            this.label112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label113
            // 
            this.label113.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label113.Location = new System.Drawing.Point(48, 697);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(44, 23);
            this.label113.TabIndex = 547;
            this.label113.Text = "20";
            this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label114
            // 
            this.label114.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label114.Location = new System.Drawing.Point(1018, 671);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(91, 23);
            this.label114.TabIndex = 546;
            this.label114.Text = " ";
            this.label114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label115
            // 
            this.label115.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label115.Location = new System.Drawing.Point(933, 671);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(82, 23);
            this.label115.TabIndex = 545;
            this.label115.Text = " ";
            this.label115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label116
            // 
            this.label116.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label116.Location = new System.Drawing.Point(886, 671);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(44, 23);
            this.label116.TabIndex = 544;
            this.label116.Text = " ";
            this.label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label117
            // 
            this.label117.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label117.Location = new System.Drawing.Point(271, 671);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(613, 23);
            this.label117.TabIndex = 543;
            this.label117.Text = " ";
            this.label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label118
            // 
            this.label118.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label118.Location = new System.Drawing.Point(94, 671);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(174, 23);
            this.label118.TabIndex = 542;
            this.label118.Text = " ";
            this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label119
            // 
            this.label119.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label119.Location = new System.Drawing.Point(48, 672);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(44, 23);
            this.label119.TabIndex = 541;
            this.label119.Text = "19";
            this.label119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label120
            // 
            this.label120.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label120.Location = new System.Drawing.Point(1018, 645);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(91, 23);
            this.label120.TabIndex = 540;
            this.label120.Text = " ";
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label121
            // 
            this.label121.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label121.Location = new System.Drawing.Point(933, 645);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(82, 23);
            this.label121.TabIndex = 539;
            this.label121.Text = " ";
            this.label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label122
            // 
            this.label122.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label122.Location = new System.Drawing.Point(886, 645);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(44, 23);
            this.label122.TabIndex = 538;
            this.label122.Text = " ";
            this.label122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label123
            // 
            this.label123.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label123.Location = new System.Drawing.Point(271, 645);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(613, 23);
            this.label123.TabIndex = 537;
            this.label123.Text = " ";
            this.label123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label124
            // 
            this.label124.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label124.Location = new System.Drawing.Point(94, 645);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(174, 23);
            this.label124.TabIndex = 536;
            this.label124.Text = " ";
            this.label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label125
            // 
            this.label125.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label125.Location = new System.Drawing.Point(48, 646);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(44, 23);
            this.label125.TabIndex = 535;
            this.label125.Text = "18";
            this.label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label126
            // 
            this.label126.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label126.Location = new System.Drawing.Point(1018, 620);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(91, 23);
            this.label126.TabIndex = 534;
            this.label126.Text = " ";
            this.label126.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label127
            // 
            this.label127.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label127.Location = new System.Drawing.Point(933, 620);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(82, 23);
            this.label127.TabIndex = 533;
            this.label127.Text = " ";
            this.label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label128
            // 
            this.label128.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label128.Location = new System.Drawing.Point(886, 620);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(44, 23);
            this.label128.TabIndex = 532;
            this.label128.Text = " ";
            this.label128.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label129
            // 
            this.label129.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label129.Location = new System.Drawing.Point(271, 620);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(613, 23);
            this.label129.TabIndex = 531;
            this.label129.Text = " ";
            this.label129.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label130
            // 
            this.label130.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label130.Location = new System.Drawing.Point(94, 620);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(174, 23);
            this.label130.TabIndex = 530;
            this.label130.Text = " ";
            this.label130.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label131
            // 
            this.label131.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label131.Location = new System.Drawing.Point(48, 621);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(44, 23);
            this.label131.TabIndex = 529;
            this.label131.Text = "17";
            this.label131.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label144
            // 
            this.label144.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label144.Location = new System.Drawing.Point(1018, 749);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(91, 23);
            this.label144.TabIndex = 564;
            this.label144.Text = " ";
            this.label144.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label145
            // 
            this.label145.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label145.Location = new System.Drawing.Point(933, 749);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(82, 23);
            this.label145.TabIndex = 563;
            this.label145.Text = " ";
            this.label145.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label146
            // 
            this.label146.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label146.Location = new System.Drawing.Point(886, 749);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(44, 23);
            this.label146.TabIndex = 562;
            this.label146.Text = " ";
            this.label146.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label147
            // 
            this.label147.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label147.Location = new System.Drawing.Point(271, 749);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(613, 23);
            this.label147.TabIndex = 561;
            this.label147.Text = " ";
            this.label147.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label148
            // 
            this.label148.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label148.Location = new System.Drawing.Point(94, 749);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(174, 23);
            this.label148.TabIndex = 560;
            this.label148.Text = " ";
            this.label148.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label149
            // 
            this.label149.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label149.Location = new System.Drawing.Point(48, 750);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(44, 23);
            this.label149.TabIndex = 559;
            this.label149.Text = "22";
            this.label149.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label150
            // 
            this.label150.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label150.Location = new System.Drawing.Point(1018, 723);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(91, 23);
            this.label150.TabIndex = 558;
            this.label150.Text = " ";
            this.label150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label151
            // 
            this.label151.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label151.Location = new System.Drawing.Point(933, 723);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(82, 23);
            this.label151.TabIndex = 557;
            this.label151.Text = " ";
            this.label151.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label152
            // 
            this.label152.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label152.Location = new System.Drawing.Point(886, 723);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(44, 23);
            this.label152.TabIndex = 556;
            this.label152.Text = " ";
            this.label152.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label153
            // 
            this.label153.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label153.Location = new System.Drawing.Point(271, 723);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(613, 23);
            this.label153.TabIndex = 555;
            this.label153.Text = " ";
            this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label154
            // 
            this.label154.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label154.Location = new System.Drawing.Point(94, 723);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(174, 23);
            this.label154.TabIndex = 554;
            this.label154.Text = " ";
            this.label154.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label155
            // 
            this.label155.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label155.Location = new System.Drawing.Point(48, 724);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(44, 23);
            this.label155.TabIndex = 553;
            this.label155.Text = "21";
            this.label155.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewFinFab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 795);
            this.Controls.Add(this.label144);
            this.Controls.Add(this.label145);
            this.Controls.Add(this.label146);
            this.Controls.Add(this.label147);
            this.Controls.Add(this.label148);
            this.Controls.Add(this.label149);
            this.Controls.Add(this.label150);
            this.Controls.Add(this.label151);
            this.Controls.Add(this.label152);
            this.Controls.Add(this.label153);
            this.Controls.Add(this.label154);
            this.Controls.Add(this.label155);
            this.Controls.Add(this.label108);
            this.Controls.Add(this.label109);
            this.Controls.Add(this.label110);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.label112);
            this.Controls.Add(this.label113);
            this.Controls.Add(this.label114);
            this.Controls.Add(this.label115);
            this.Controls.Add(this.label116);
            this.Controls.Add(this.label117);
            this.Controls.Add(this.label118);
            this.Controls.Add(this.label119);
            this.Controls.Add(this.label120);
            this.Controls.Add(this.label121);
            this.Controls.Add(this.label122);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label124);
            this.Controls.Add(this.label125);
            this.Controls.Add(this.label126);
            this.Controls.Add(this.label127);
            this.Controls.Add(this.label128);
            this.Controls.Add(this.label129);
            this.Controls.Add(this.label130);
            this.Controls.Add(this.label131);
            this.Controls.Add(this.label84);
            this.Controls.Add(this.label85);
            this.Controls.Add(this.label86);
            this.Controls.Add(this.label87);
            this.Controls.Add(this.label88);
            this.Controls.Add(this.label89);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.label91);
            this.Controls.Add(this.label92);
            this.Controls.Add(this.label93);
            this.Controls.Add(this.label94);
            this.Controls.Add(this.label95);
            this.Controls.Add(this.label96);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.label98);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.label104);
            this.Controls.Add(this.label105);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.label107);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.label80);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewFinFab";
            this.ShowInTaskbar = false;
            this.Text = this.Name;
            this.Load += new System.EventHandler(this.InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal PictureBox pictureBox1;
        internal Label ViewTitre;
        internal Label label2;
        internal TextBox textBox1;
        internal TextBox textBox2;
        internal Label label3;
        internal TextBox textBox3;
        internal Label label4;
        internal Label label5;
        internal Label label6;
        internal Label label7;
        internal Label label8;
        internal Label label9;
        internal Label label10;
        internal Label label11;
        internal Label label12;
        internal Label label13;
        internal Label label14;
        internal Label label15;
        internal Label label16;
        internal Label label17;
        internal Label label18;
        internal Label label19;
        internal Label label20;
        internal Label label21;
        internal Label label22;
        internal Label label23;
        internal Label label24;
        internal Label label25;
        internal Label label26;
        internal Label label27;
        internal Label label28;
        internal Label label29;
        internal Label label30;
        internal Label label31;
        internal Label label32;
        internal Label label33;
        internal Label label34;
        internal Label label35;
        internal Label label36;
        internal Label label37;
        internal Label label38;
        internal Label label39;
        internal Label label40;
        internal Label label41;
        internal Label label42;
        internal Label label43;
        internal Label label44;
        internal Label label45;
        internal Label label46;
        internal Label label47;
        internal Label label48;
        internal Label label49;
        internal Label label50;
        internal Label label51;
        internal Label label52;
        internal Label label53;
        internal Label label54;
        internal Label label55;
        internal Label label56;
        internal Label label57;
        internal Label label58;
        internal Label label59;
        internal Label label60;
        internal Label label61;
        internal Label label62;
        internal Label label63;
        internal Label label64;
        internal Label label65;
        internal Label label66;
        internal Label label67;
        internal Label label68;
        internal Label label69;
        internal Label label70;
        internal Label label71;
        internal Label label72;
        internal Label label73;
        internal Label label74;
        internal Label label75;
        internal Label label76;
        internal Label label77;
        internal Label label78;
        internal Label label79;
        internal Label label80;
        internal Label label81;
        internal Label label82;
        internal Label label83;
        internal Label label84;
        internal Label label85;
        internal Label label86;
        internal Label label87;
        internal Label label88;
        internal Label label89;
        internal Label label90;
        internal Label label91;
        internal Label label92;
        internal Label label93;
        internal Label label94;
        internal Label label95;
        internal Label label96;
        internal Label label97;
        internal Label label98;
        internal Label label99;
        internal Label label100;
        internal Label label101;
        internal Label label102;
        internal Label label103;
        internal Label label104;
        internal Label label105;
        internal Label label106;
        internal Label label107;
        internal Label label108;
        internal Label label109;
        internal Label label110;
        internal Label label111;
        internal Label label112;
        internal Label label113;
        internal Label label114;
        internal Label label115;
        internal Label label116;
        internal Label label117;
        internal Label label118;
        internal Label label119;
        internal Label label120;
        internal Label label121;
        internal Label label122;
        internal Label label123;
        internal Label label124;
        internal Label label125;
        internal Label label126;
        internal Label label127;
        internal Label label128;
        internal Label label129;
        internal Label label130;
        internal Label label131;
        internal Label label144;
        internal Label label145;
        internal Label label146;
        internal Label label147;
        internal Label label148;
        internal Label label149;
        internal Label label150;
        internal Label label151;
        internal Label label152;
        internal Label label153;
        internal Label label154;
        internal Label label155;

        public ViewFinFab()
        {
            InitializeComponent();
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
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
