
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
    public class ViewSommaireHeures : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSommaireHeures));
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblDateFin = new System.Windows.Forms.Label();
            lbltitredatereq = new System.Windows.Forms.Label();
            lblDateDebut = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            lblTotalSoum = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            lblSoumMec = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            lblSoumElec = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblTotalProjGRB = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblProjGRBMec = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblProjGRBElec = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            lblTotalProj = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            lblProjMec = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            lblProjElec = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            lblTotalFab = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            lblFabMec = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            lblFabElec = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            lblTotalRech = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            lblRechMec = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            lblRechElec = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            lblTotalAppels = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            lblAppelsMec = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            lblAppelsElec = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            lblGrandTotal = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(818, 50);
            label1.TabIndex = 0;
            label1.Text = "Sommaire des heures";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(13, 108);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(60, 16);
            label7.TabIndex = 45;
            label7.Text = "Date fin";
            // 
            // lblDateFin
            // 
            lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblDateFin.Location = new System.Drawing.Point(110, 108);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new System.Drawing.Size(291, 19);
            lblDateFin.TabIndex = 44;
            lblDateFin.Text = "8888-88-88";
            // 
            // lbltitredatereq
            // 
            lbltitredatereq.AutoSize = true;
            lbltitredatereq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lbltitredatereq.Location = new System.Drawing.Point(12, 78);
            lbltitredatereq.Name = "lbltitredatereq";
            lbltitredatereq.Size = new System.Drawing.Size(83, 16);
            lbltitredatereq.TabIndex = 43;
            lbltitredatereq.Text = "Date début";
            // 
            // lblDateDebut
            // 
            lblDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblDateDebut.Location = new System.Drawing.Point(110, 78);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new System.Drawing.Size(291, 19);
            lblDateDebut.TabIndex = 42;
            lblDateDebut.Text = "8888-88-88";
            // 
            // label25
            // 
            label25.BackColor = System.Drawing.Color.Transparent;
            label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.Location = new System.Drawing.Point(111, 204);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(536, 28);
            label25.TabIndex = 176;
            label25.Text = "Total des soumissions";
            label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalSoum
            // 
            lblTotalSoum.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTotalSoum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalSoum.Location = new System.Drawing.Point(653, 204);
            lblTotalSoum.Name = "lblTotalSoum";
            lblTotalSoum.Size = new System.Drawing.Size(124, 28);
            lblTotalSoum.TabIndex = 174;
            lblTotalSoum.Text = "0";
            lblTotalSoum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.BackColor = System.Drawing.Color.Transparent;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.Location = new System.Drawing.Point(111, 182);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(536, 20);
            label18.TabIndex = 172;
            label18.Text = "Soumission mécaniques";
            // 
            // lblSoumMec
            // 
            lblSoumMec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblSoumMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumMec.Location = new System.Drawing.Point(653, 182);
            lblSoumMec.Name = "lblSoumMec";
            lblSoumMec.Size = new System.Drawing.Size(124, 20);
            lblSoumMec.TabIndex = 170;
            lblSoumMec.Text = "0";
            lblSoumMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(111, 160);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(536, 20);
            label14.TabIndex = 168;
            label14.Text = "Soumission électriques";
            // 
            // lblSoumElec
            // 
            lblSoumElec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblSoumElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoumElec.Location = new System.Drawing.Point(653, 160);
            lblSoumElec.Name = "lblSoumElec";
            lblSoumElec.Size = new System.Drawing.Size(124, 20);
            lblSoumElec.TabIndex = 166;
            lblSoumElec.Text = "0";
            lblSoumElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(653, 141);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(124, 20);
            label11.TabIndex = 162;
            label11.Text = "HRS";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(111, 286);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(536, 28);
            label2.TabIndex = 182;
            label2.Text = "Total desprojets GRB";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalProjGRB
            // 
            lblTotalProjGRB.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTotalProjGRB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalProjGRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalProjGRB.Location = new System.Drawing.Point(653, 286);
            lblTotalProjGRB.Name = "lblTotalProjGRB";
            lblTotalProjGRB.Size = new System.Drawing.Size(124, 28);
            lblTotalProjGRB.TabIndex = 181;
            lblTotalProjGRB.Text = "0";
            lblTotalProjGRB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(111, 264);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(536, 20);
            label4.TabIndex = 180;
            label4.Text = "Projets GRB mécaniques";
            // 
            // lblProjGRBMec
            // 
            lblProjGRBMec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblProjGRBMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjGRBMec.Location = new System.Drawing.Point(653, 264);
            lblProjGRBMec.Name = "lblProjGRBMec";
            lblProjGRBMec.Size = new System.Drawing.Size(124, 20);
            lblProjGRBMec.TabIndex = 179;
            lblProjGRBMec.Text = "0";
            lblProjGRBMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(111, 242);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(536, 20);
            label6.TabIndex = 178;
            label6.Text = "Projets GRB électriques";
            // 
            // lblProjGRBElec
            // 
            lblProjGRBElec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblProjGRBElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjGRBElec.Location = new System.Drawing.Point(653, 242);
            lblProjGRBElec.Name = "lblProjGRBElec";
            lblProjGRBElec.Size = new System.Drawing.Size(124, 20);
            lblProjGRBElec.TabIndex = 177;
            lblProjGRBElec.Text = "0";
            lblProjGRBElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(110, 372);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(536, 28);
            label10.TabIndex = 188;
            label10.Text = "Total ";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalProj
            // 
            lblTotalProj.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTotalProj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalProj.Location = new System.Drawing.Point(652, 372);
            lblTotalProj.Name = "lblTotalProj";
            lblTotalProj.Size = new System.Drawing.Size(124, 28);
            lblTotalProj.TabIndex = 187;
            lblTotalProj.Text = "0";
            lblTotalProj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(110, 350);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(536, 20);
            label13.TabIndex = 186;
            label13.Text = "Projets mécaniques";
            // 
            // lblProjMec
            // 
            lblProjMec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblProjMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjMec.Location = new System.Drawing.Point(652, 350);
            lblProjMec.Name = "lblProjMec";
            lblProjMec.Size = new System.Drawing.Size(124, 20);
            lblProjMec.TabIndex = 185;
            lblProjMec.Text = "0";
            lblProjMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.BackColor = System.Drawing.Color.Transparent;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(110, 328);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(536, 20);
            label17.TabIndex = 184;
            label17.Text = "Projets électriques";
            // 
            // lblProjElec
            // 
            lblProjElec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblProjElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjElec.Location = new System.Drawing.Point(652, 328);
            lblProjElec.Name = "lblProjElec";
            lblProjElec.Size = new System.Drawing.Size(124, 20);
            lblProjElec.TabIndex = 183;
            lblProjElec.Text = "0";
            lblProjElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            label21.BackColor = System.Drawing.Color.Transparent;
            label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.Location = new System.Drawing.Point(110, 458);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(536, 28);
            label21.TabIndex = 194;
            label21.Text = "Total des fabrication GRB";
            label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalFab
            // 
            lblTotalFab.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTotalFab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalFab.Location = new System.Drawing.Point(652, 458);
            lblTotalFab.Name = "lblTotalFab";
            lblTotalFab.Size = new System.Drawing.Size(124, 28);
            lblTotalFab.TabIndex = 193;
            lblTotalFab.Text = "0";
            lblTotalFab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            label23.BackColor = System.Drawing.Color.Transparent;
            label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(110, 436);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(536, 20);
            label23.TabIndex = 192;
            label23.Text = "Fabrication GRB mécanique";
            // 
            // lblFabMec
            // 
            lblFabMec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblFabMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFabMec.Location = new System.Drawing.Point(652, 436);
            lblFabMec.Name = "lblFabMec";
            lblFabMec.Size = new System.Drawing.Size(124, 20);
            lblFabMec.TabIndex = 191;
            lblFabMec.Text = "0";
            lblFabMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            label26.BackColor = System.Drawing.Color.Transparent;
            label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(110, 415);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(536, 20);
            label26.TabIndex = 190;
            label26.Text = "Fabrication GRB électrique";
            // 
            // lblFabElec
            // 
            lblFabElec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblFabElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFabElec.Location = new System.Drawing.Point(652, 415);
            lblFabElec.Name = "lblFabElec";
            lblFabElec.Size = new System.Drawing.Size(124, 20);
            lblFabElec.TabIndex = 189;
            lblFabElec.Text = "0";
            lblFabElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            label29.BackColor = System.Drawing.Color.Transparent;
            label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.Location = new System.Drawing.Point(110, 547);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(536, 28);
            label29.TabIndex = 200;
            label29.Text = "Total recherche et développement ";
            label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalRech
            // 
            lblTotalRech.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTotalRech.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalRech.Location = new System.Drawing.Point(652, 547);
            lblTotalRech.Name = "lblTotalRech";
            lblTotalRech.Size = new System.Drawing.Size(124, 28);
            lblTotalRech.TabIndex = 199;
            lblTotalRech.Text = "0";
            lblTotalRech.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            label31.BackColor = System.Drawing.Color.Transparent;
            label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.Location = new System.Drawing.Point(110, 525);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(536, 20);
            label31.TabIndex = 198;
            label31.Text = "Recherche et développement  mécanique";
            // 
            // lblRechMec
            // 
            lblRechMec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblRechMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRechMec.Location = new System.Drawing.Point(652, 525);
            lblRechMec.Name = "lblRechMec";
            lblRechMec.Size = new System.Drawing.Size(124, 20);
            lblRechMec.TabIndex = 197;
            lblRechMec.Text = "0";
            lblRechMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            label33.BackColor = System.Drawing.Color.Transparent;
            label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.Location = new System.Drawing.Point(110, 504);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(536, 20);
            label33.TabIndex = 196;
            label33.Text = "Recherche et développement électrique";
            // 
            // lblRechElec
            // 
            lblRechElec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblRechElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRechElec.Location = new System.Drawing.Point(652, 504);
            lblRechElec.Name = "lblRechElec";
            lblRechElec.Size = new System.Drawing.Size(124, 20);
            lblRechElec.TabIndex = 195;
            lblRechElec.Text = "0";
            lblRechElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            label35.BackColor = System.Drawing.Color.Transparent;
            label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.Location = new System.Drawing.Point(110, 634);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(536, 28);
            label35.TabIndex = 206;
            label35.Text = "Total des appels de services ";
            label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAppels
            // 
            lblTotalAppels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalAppels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalAppels.Location = new System.Drawing.Point(652, 634);
            lblTotalAppels.Name = "lblTotalAppels";
            lblTotalAppels.Size = new System.Drawing.Size(124, 28);
            lblTotalAppels.TabIndex = 205;
            lblTotalAppels.Text = "0";
            lblTotalAppels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            label37.BackColor = System.Drawing.Color.Transparent;
            label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.Location = new System.Drawing.Point(110, 612);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(536, 20);
            label37.TabIndex = 204;
            label37.Text = "Appels de services  mécaniques";
            // 
            // lblAppelsMec
            // 
            lblAppelsMec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblAppelsMec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAppelsMec.Location = new System.Drawing.Point(652, 612);
            lblAppelsMec.Name = "lblAppelsMec";
            lblAppelsMec.Size = new System.Drawing.Size(124, 20);
            lblAppelsMec.TabIndex = 203;
            lblAppelsMec.Text = "0";
            lblAppelsMec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label39
            // 
            label39.BackColor = System.Drawing.Color.Transparent;
            label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.Location = new System.Drawing.Point(110, 591);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(536, 20);
            label39.TabIndex = 202;
            label39.Text = "Appels de services électriques";
            // 
            // lblAppelsElec
            // 
            lblAppelsElec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblAppelsElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAppelsElec.Location = new System.Drawing.Point(652, 591);
            lblAppelsElec.Name = "lblAppelsElec";
            lblAppelsElec.Size = new System.Drawing.Size(124, 20);
            lblAppelsElec.TabIndex = 201;
            lblAppelsElec.Text = "0";
            lblAppelsElec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            label41.BackColor = System.Drawing.Color.Transparent;
            label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.Location = new System.Drawing.Point(110, 683);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(536, 36);
            label41.TabIndex = 208;
            label41.Text = "GRAND TOTAL";
            label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGrandTotal.Location = new System.Drawing.Point(652, 683);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new System.Drawing.Size(124, 36);
            lblGrandTotal.TabIndex = 207;
            lblGrandTotal.Text = "0";
            lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1,
            toolStripStatusLabel2});
            statusStrip1.Location = new System.Drawing.Point(0, 1039);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(818, 22);
            statusStrip1.TabIndex = 209;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(733, 17);
            toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(70, 17);
            toolStripStatusLabel2.Text = "Page 1 sur 1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.Location = new System.Drawing.Point(637, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(177, 71);
            pictureBox1.TabIndex = 210;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // ViewSommaireHeures
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(label41);
            Controls.Add(lblGrandTotal);
            Controls.Add(label35);
            Controls.Add(lblTotalAppels);
            Controls.Add(label37);
            Controls.Add(lblAppelsMec);
            Controls.Add(label39);
            Controls.Add(lblAppelsElec);
            Controls.Add(label29);
            Controls.Add(lblTotalRech);
            Controls.Add(label31);
            Controls.Add(lblRechMec);
            Controls.Add(label33);
            Controls.Add(lblRechElec);
            Controls.Add(label21);
            Controls.Add(lblTotalFab);
            Controls.Add(label23);
            Controls.Add(lblFabMec);
            Controls.Add(label26);
            Controls.Add(lblFabElec);
            Controls.Add(label10);
            Controls.Add(lblTotalProj);
            Controls.Add(label13);
            Controls.Add(lblProjMec);
            Controls.Add(label17);
            Controls.Add(lblProjElec);
            Controls.Add(label2);
            Controls.Add(lblTotalProjGRB);
            Controls.Add(label4);
            Controls.Add(lblProjGRBMec);
            Controls.Add(label6);
            Controls.Add(lblProjGRBElec);
            Controls.Add(label25);
            Controls.Add(lblTotalSoum);
            Controls.Add(label18);
            Controls.Add(lblSoumMec);
            Controls.Add(label14);
            Controls.Add(lblSoumElec);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(lblDateFin);
            Controls.Add(lbltitredatereq);
            Controls.Add(lblDateDebut);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewSommaireHeures";
            ShowInTaskbar = false;
            Text = "A";
            Load += new System.EventHandler(ViewSommaireHeures_Load);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label label1;
        internal static Label label7;
        internal static Label lblDateFin;
        internal static Label lbltitredatereq;
        internal static Label lblDateDebut;
        internal static Label label25;
        internal static Label lblTotalSoum;
        internal static Label label18;
        internal static Label lblSoumMec;
        internal static Label label14;
        internal static Label lblSoumElec;
        internal static Label label11;
        internal static Label label2;
        internal static Label lblTotalProjGRB;
        internal static Label label4;
        internal static Label lblProjGRBMec;
        internal static Label label6;
        internal static Label lblProjGRBElec;
        internal static Label label10;
        internal static Label lblTotalProj;
        internal static Label label13;
        internal static Label lblProjMec;
        internal static Label label17;
        internal static Label lblProjElec;
        internal static Label label21;
        internal static Label lblTotalFab;
        internal static Label label23;
        internal static Label lblFabMec;
        internal static Label label26;
        internal static Label lblFabElec;
        internal static Label label29;
        internal static Label lblTotalRech;
        internal static Label label31;
        internal static Label lblRechMec;
        internal static Label label33;
        internal static Label lblRechElec;
        internal static Label label35;
        internal static Label lblTotalAppels;
        internal static Label label37;
        internal static Label lblAppelsMec;
        internal static Label label39;
        internal static Label lblAppelsElec;
        internal static Label label41;
        internal static Label lblGrandTotal;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel toolStripStatusLabel1;
        internal static ToolStripStatusLabel toolStripStatusLabel2;
        internal static PictureBox pictureBox1;

        public ViewSommaireHeures()
        {
            InitializeComponent();
        }
        public ViewSommaireHeures(bool Teste)
        {
            InitializeComponent();
            Recordset rd = new Recordset();
            int tmpGestionM = 0;
            int tmpFabricationM = 0;
            int tmpDeveloppementM = 0;
            int tmpGestionE = 0;
            int tmpFabricationE = 0;
            int tmpDeveloppementE = 0;
            rd.Open("SELECT  NOPROJET, DATE, SUM(DATEDIFF(MINUTE, HEUREDÉBUT, HEUREFIN)) AS 'TOTAL', NOCLIENT, TYPE FROM PUNCH " +
                "WHERE NOPROJET LIKE '%44001%' " +
                "GROUP BY TYPE ,NOPROJET,DATE,TYPE,NOCLIENT", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            /*
0	NoProjet
1	 Date
2	 sum(datediff(minute, HeureDébut,  HeureFin)) as 'total'
3	 NoClient
4	 Type 
       */
            if (!rd.EOF)
            {
                if (Program.Gauche($"{rd.Fields[0].Value}", 1).ToLower() == "e")
                {
                    switch ($"{rd.Fields[6].Value}")
                    {
                        case "ProgAutomate": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "ProgInterface": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "Programmation d'automate": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "Programmation de Robot": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "Programmation d'interface": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "ProgRobot": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "Prototypage - Dévelloppement": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "Prototypage - Dévelloppement expérimental": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "Vision Artificielle": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "Conception et dessin": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "Dessin Électrique": { tmpDeveloppementE += (int)rd.Fields[2].Value; } break;
                        case "Assemblage des systèmes": {tmpFabricationE  += (int)rd.Fields[2].Value; } break;
                        case "Installation": { tmpFabricationE += (int)rd.Fields[2].Value; } break;
                        case "Assemblage du Panneau": { tmpFabricationE += (int)rd.Fields[2].Value; } break;
                        case "Expédition": { tmpFabricationE += (int)rd.Fields[2].Value; } break;
                        case "Fabrication": { tmpFabricationE += (int)rd.Fields[2].Value; } break;
                        case "Formation": { tmpGestionE += (int)rd.Fields[2].Value; } break;
                        case "Formation du personnel": { tmpGestionE += (int)rd.Fields[2].Value; } break;
                        case "Formation du personnel - Assemblage -": { tmpGestionE += (int)rd.Fields[2].Value; } break;
                        case "Gestion": { tmpGestionE += (int)rd.Fields[2].Value; } break;
                        case "Gestion du projet": { tmpGestionE += (int)rd.Fields[2].Value; } break;
                        case "Soumission": { tmpGestionE += (int)rd.Fields[2].Value; } break;
                    }
                }
                else
                {
                    switch ($"{rd.Fields[6].Value}")
                    {
                        case "Assemblage": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Assemblage des systèmes": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Assemblage, Soudage, Meulage": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Coupe": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Coupe Assemblage Soudage": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Coupe et préparation(sauf soudage)": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Coupe,Soudure et meulage": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Machinage": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Peinture": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Peinture et Finition": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "Soudure": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
       /*                 case "": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                        case "": { tmpFabricationM += (int)rd.Fields[2].Value; } break;
                            /*
type

Conception et dessin
Dessin
Expédition
Formation
Formation du personnel
Formation du personnel -Assemblage -
Gestion
Gestion du projet
Installation
Prototypage-Dévelloppement
Prototypage-Dévelloppement expérimental
Shipping
Soumission
Test
Test Finaux              */
                    }
                }
            }
        }
        private void ViewSommaireHeures_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Program.IdNomEmploye + "  " + DateTime.Now.ToString();
            lblDateDebut.Text = ViewSommaireHeures.lblDateDebut.Text;
            lblDateFin.Text = ViewSommaireHeures.lblDateFin.Text;
            lblSoumElec.Text = ViewSommaireHeures.lblSoumElec.Text;
            lblSoumMec.Text = ViewSommaireHeures.lblSoumMec.Text;
            lblTotalSoum.Text = ViewSommaireHeures.lblTotalSoum.Text;
            lblProjGRBElec.Text = ViewSommaireHeures.lblProjGRBElec.Text;
            lblProjGRBMec.Text = ViewSommaireHeures.lblProjGRBMec.Text;
            lblTotalProjGRB.Text = ViewSommaireHeures.lblTotalProjGRB.Text;
            lblProjElec.Text = ViewSommaireHeures.lblProjElec.Text;
            lblProjMec.Text = ViewSommaireHeures.lblProjMec.Text;
            lblTotalProj.Text = ViewSommaireHeures.lblTotalProj.Text;
            lblFabElec.Text = ViewSommaireHeures.lblFabElec.Text;
            lblFabMec.Text = ViewSommaireHeures.lblFabMec.Text;
            lblTotalFab.Text = ViewSommaireHeures.lblTotalFab.Text;
            lblRechElec.Text = ViewSommaireHeures.lblRechElec.Text;
            lblRechMec.Text = ViewSommaireHeures.lblRechMec.Text;
            lblTotalRech.Text = ViewSommaireHeures.lblTotalRech.Text;
            lblAppelsElec.Text = ViewSommaireHeures.lblAppelsElec.Text;
            lblAppelsMec.Text = ViewSommaireHeures.lblAppelsMec.Text;
            lblTotalAppels.Text = ViewSommaireHeures.lblTotalAppels.Text;
            lblGrandTotal.Text = ViewSommaireHeures.lblGrandTotal.Text;
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        Bitmap memoryImage;
        internal static bool Orientation;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            toolStripStatusLabel1.Text = $"     {ControleurServeur.Program.IdNomEmploye} {DateTime.Now.ToString()}";
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
