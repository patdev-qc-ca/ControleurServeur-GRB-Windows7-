
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
    public class ViewProblemes : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProblemes));
            lblTitreNoSoum = new System.Windows.Forms.Label();
            lblTitreBC = new System.Windows.Forms.Label();
            label60 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            label47 = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            label51 = new System.Windows.Forms.Label();
            label52 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            label42 = new System.Windows.Forms.Label();
            label43 = new System.Windows.Forms.Label();
            label44 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            lblTitreProjSoum0 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            lblTitreProjSoum8 = new System.Windows.Forms.Label();
            lblTitreProjSoum9 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            lblTitreProjSoum4 = new System.Windows.Forms.Label();
            lblTitreProjSoum5 = new System.Windows.Forms.Label();
            lblTitreProjSoum6 = new System.Windows.Forms.Label();
            lblTitreProjSoum7 = new System.Windows.Forms.Label();
            lblTitreProjSoum1 = new System.Windows.Forms.Label();
            lbltitredate = new System.Windows.Forms.Label();
            lblTitreProjSoum26 = new System.Windows.Forms.Label();
            lblTitreProjSoum27 = new System.Windows.Forms.Label();
            lblTitreProjSoum30 = new System.Windows.Forms.Label();
            lblTitreProjSoum31 = new System.Windows.Forms.Label();
            lblTitreProjSoum32 = new System.Windows.Forms.Label();
            lblTitreProjSoum18 = new System.Windows.Forms.Label();
            lblTitreProjSoum19 = new System.Windows.Forms.Label();
            lblTitreProjSoum22 = new System.Windows.Forms.Label();
            lblTitreProjSoum23 = new System.Windows.Forms.Label();
            lblTitreProjSoum24 = new System.Windows.Forms.Label();
            lblTitreProjSoum10 = new System.Windows.Forms.Label();
            lblTitreProjSoum11 = new System.Windows.Forms.Label();
            lblTitreProjSoum14 = new System.Windows.Forms.Label();
            lblTitreProjSoum15 = new System.Windows.Forms.Label();
            lblTitreProjSoum16 = new System.Windows.Forms.Label();
            lblTitreProjSoum02 = new System.Windows.Forms.Label();
            lblTitreProjSoum03 = new System.Windows.Forms.Label();
            lblTitreProjSoum06 = new System.Windows.Forms.Label();
            lblTitreProjSoum07 = new System.Windows.Forms.Label();
            lblTitreProjSoum08 = new System.Windows.Forms.Label();
            label94 = new System.Windows.Forms.Label();
            label95 = new System.Windows.Forms.Label();
            label98 = new System.Windows.Forms.Label();
            label99 = new System.Windows.Forms.Label();
            lblTitreProjSoum00 = new System.Windows.Forms.Label();
            label86 = new System.Windows.Forms.Label();
            label87 = new System.Windows.Forms.Label();
            label90 = new System.Windows.Forms.Label();
            label91 = new System.Windows.Forms.Label();
            label92 = new System.Windows.Forms.Label();
            label78 = new System.Windows.Forms.Label();
            label79 = new System.Windows.Forms.Label();
            label82 = new System.Windows.Forms.Label();
            label83 = new System.Windows.Forms.Label();
            label84 = new System.Windows.Forms.Label();
            label70 = new System.Windows.Forms.Label();
            label71 = new System.Windows.Forms.Label();
            label74 = new System.Windows.Forms.Label();
            label75 = new System.Windows.Forms.Label();
            label76 = new System.Windows.Forms.Label();
            label62 = new System.Windows.Forms.Label();
            label63 = new System.Windows.Forms.Label();
            label66 = new System.Windows.Forms.Label();
            label67 = new System.Windows.Forms.Label();
            label68 = new System.Windows.Forms.Label();
            label54 = new System.Windows.Forms.Label();
            label55 = new System.Windows.Forms.Label();
            label58 = new System.Windows.Forms.Label();
            label59 = new System.Windows.Forms.Label();
            lblNomEmploye = new System.Windows.Forms.TextBox();
            lblNoProjSoum = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTitreProjSoum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // lblTitreNoSoum
            // 
            lblTitreNoSoum.AutoSize = true;
            lblTitreNoSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreNoSoum.Location = new System.Drawing.Point(85, 68);
            lblTitreNoSoum.Name = "lblTitreNoSoum";
            lblTitreNoSoum.Size = new System.Drawing.Size(133, 16);
            lblTitreNoSoum.TabIndex = 17;
            lblTitreNoSoum.Text = "Nom de l\'employé";
            // 
            // lblTitreBC
            // 
            lblTitreBC.AutoSize = true;
            lblTitreBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lblTitreBC.Location = new System.Drawing.Point(85, 42);
            lblTitreBC.Name = "lblTitreBC";
            lblTitreBC.Size = new System.Drawing.Size(60, 16);
            lblTitreBC.TabIndex = 19;
            lblTitreBC.Text = "Projet #";
            // 
            // label60
            // 
            label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label60.Location = new System.Drawing.Point(21, 467);
            label60.Name = "label60";
            label60.Size = new System.Drawing.Size(30, 19);
            label60.TabIndex = 374;
            label60.Text = "6";
            label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.Location = new System.Drawing.Point(64, 447);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(603, 19);
            label46.TabIndex = 372;
            // 
            // label47
            // 
            label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label47.Location = new System.Drawing.Point(669, 447);
            label47.Name = "label47";
            label47.Size = new System.Drawing.Size(124, 19);
            label47.TabIndex = 371;
            // 
            // label50
            // 
            label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.Location = new System.Drawing.Point(64, 427);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(603, 19);
            label50.TabIndex = 368;
            // 
            // label51
            // 
            label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label51.Location = new System.Drawing.Point(669, 427);
            label51.Name = "label51";
            label51.Size = new System.Drawing.Size(124, 19);
            label51.TabIndex = 367;
            // 
            // label52
            // 
            label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label52.Location = new System.Drawing.Point(21, 427);
            label52.Name = "label52";
            label52.Size = new System.Drawing.Size(30, 19);
            label52.TabIndex = 366;
            label52.Text = "5";
            label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.Location = new System.Drawing.Point(64, 407);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(603, 19);
            label38.TabIndex = 364;
            // 
            // label39
            // 
            label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.Location = new System.Drawing.Point(669, 407);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(124, 19);
            label39.TabIndex = 363;
            // 
            // label42
            // 
            label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.Location = new System.Drawing.Point(64, 387);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(603, 19);
            label42.TabIndex = 360;
            // 
            // label43
            // 
            label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label43.Location = new System.Drawing.Point(669, 387);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(124, 19);
            label43.TabIndex = 359;
            // 
            // label44
            // 
            label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label44.Location = new System.Drawing.Point(21, 387);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(30, 19);
            label44.TabIndex = 358;
            label44.Text = "4";
            label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.Location = new System.Drawing.Point(64, 367);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(603, 19);
            label30.TabIndex = 356;
            // 
            // label31
            // 
            label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.Location = new System.Drawing.Point(669, 367);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(124, 19);
            label31.TabIndex = 355;
            // 
            // label34
            // 
            label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(64, 347);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(603, 19);
            label34.TabIndex = 352;
            // 
            // label35
            // 
            label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.Location = new System.Drawing.Point(669, 347);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(124, 19);
            label35.TabIndex = 351;
            // 
            // label36
            // 
            label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label36.Location = new System.Drawing.Point(21, 347);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(30, 19);
            label36.TabIndex = 350;
            label36.Text = "3";
            label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProjSoum0
            // 
            lblTitreProjSoum0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum0.Location = new System.Drawing.Point(21, 198);
            lblTitreProjSoum0.Name = "lblTitreProjSoum0";
            lblTitreProjSoum0.Size = new System.Drawing.Size(776, 20);
            lblTitreProjSoum0.TabIndex = 349;
            // 
            // label22
            // 
            label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.Location = new System.Drawing.Point(64, 327);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(603, 19);
            label22.TabIndex = 348;
            // 
            // label23
            // 
            label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(669, 327);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(124, 19);
            label23.TabIndex = 347;
            // 
            // label25
            // 
            label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.Location = new System.Drawing.Point(21, 177);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(776, 20);
            label25.TabIndex = 345;
            // 
            // label26
            // 
            label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(64, 307);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(603, 19);
            label26.TabIndex = 344;
            // 
            // label27
            // 
            label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.Location = new System.Drawing.Point(669, 307);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(124, 19);
            label27.TabIndex = 343;
            // 
            // label28
            // 
            label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.Location = new System.Drawing.Point(21, 307);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(30, 19);
            label28.TabIndex = 342;
            label28.Text = "2";
            label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProjSoum8
            // 
            lblTitreProjSoum8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum8.Location = new System.Drawing.Point(21, 156);
            lblTitreProjSoum8.Name = "lblTitreProjSoum8";
            lblTitreProjSoum8.Size = new System.Drawing.Size(776, 20);
            lblTitreProjSoum8.TabIndex = 341;
            // 
            // lblTitreProjSoum9
            // 
            lblTitreProjSoum9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum9.Location = new System.Drawing.Point(64, 287);
            lblTitreProjSoum9.Name = "lblTitreProjSoum9";
            lblTitreProjSoum9.Size = new System.Drawing.Size(603, 19);
            lblTitreProjSoum9.TabIndex = 340;
            // 
            // label20
            // 
            label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(669, 287);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(124, 19);
            label20.TabIndex = 339;
            // 
            // lblTitreProjSoum4
            // 
            lblTitreProjSoum4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum4.Location = new System.Drawing.Point(21, 135);
            lblTitreProjSoum4.Name = "lblTitreProjSoum4";
            lblTitreProjSoum4.Size = new System.Drawing.Size(776, 20);
            lblTitreProjSoum4.TabIndex = 337;
            // 
            // lblTitreProjSoum5
            // 
            lblTitreProjSoum5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum5.Location = new System.Drawing.Point(64, 267);
            lblTitreProjSoum5.Name = "lblTitreProjSoum5";
            lblTitreProjSoum5.Size = new System.Drawing.Size(603, 19);
            lblTitreProjSoum5.TabIndex = 336;
            // 
            // lblTitreProjSoum6
            // 
            lblTitreProjSoum6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum6.Location = new System.Drawing.Point(669, 267);
            lblTitreProjSoum6.Name = "lblTitreProjSoum6";
            lblTitreProjSoum6.Size = new System.Drawing.Size(124, 19);
            lblTitreProjSoum6.TabIndex = 335;
            // 
            // lblTitreProjSoum7
            // 
            lblTitreProjSoum7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum7.Location = new System.Drawing.Point(21, 267);
            lblTitreProjSoum7.Name = "lblTitreProjSoum7";
            lblTitreProjSoum7.Size = new System.Drawing.Size(30, 19);
            lblTitreProjSoum7.TabIndex = 334;
            lblTitreProjSoum7.Text = "1";
            lblTitreProjSoum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProjSoum1
            // 
            lblTitreProjSoum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum1.Location = new System.Drawing.Point(669, 241);
            lblTitreProjSoum1.Name = "lblTitreProjSoum1";
            lblTitreProjSoum1.Size = new System.Drawing.Size(124, 22);
            lblTitreProjSoum1.TabIndex = 331;
            lblTitreProjSoum1.Text = "Date";
            // 
            // lbltitredate
            // 
            lbltitredate.AutoSize = true;
            lbltitredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            lbltitredate.Location = new System.Drawing.Point(9, 112);
            lbltitredate.Name = "lbltitredate";
            lbltitredate.Size = new System.Drawing.Size(209, 16);
            lbltitredate.TabIndex = 316;
            lbltitredate.Text = "Problématique de la machine";
            // 
            // lblTitreProjSoum26
            // 
            lblTitreProjSoum26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum26.Location = new System.Drawing.Point(63, 847);
            lblTitreProjSoum26.Name = "lblTitreProjSoum26";
            lblTitreProjSoum26.Size = new System.Drawing.Size(604, 19);
            lblTitreProjSoum26.TabIndex = 452;
            // 
            // lblTitreProjSoum27
            // 
            lblTitreProjSoum27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum27.Location = new System.Drawing.Point(670, 847);
            lblTitreProjSoum27.Name = "lblTitreProjSoum27";
            lblTitreProjSoum27.Size = new System.Drawing.Size(124, 19);
            lblTitreProjSoum27.TabIndex = 451;
            // 
            // lblTitreProjSoum30
            // 
            lblTitreProjSoum30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum30.Location = new System.Drawing.Point(63, 827);
            lblTitreProjSoum30.Name = "lblTitreProjSoum30";
            lblTitreProjSoum30.Size = new System.Drawing.Size(604, 19);
            lblTitreProjSoum30.TabIndex = 448;
            // 
            // lblTitreProjSoum31
            // 
            lblTitreProjSoum31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum31.Location = new System.Drawing.Point(670, 827);
            lblTitreProjSoum31.Name = "lblTitreProjSoum31";
            lblTitreProjSoum31.Size = new System.Drawing.Size(124, 19);
            lblTitreProjSoum31.TabIndex = 447;
            // 
            // lblTitreProjSoum32
            // 
            lblTitreProjSoum32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum32.Location = new System.Drawing.Point(21, 825);
            lblTitreProjSoum32.Name = "lblTitreProjSoum32";
            lblTitreProjSoum32.Size = new System.Drawing.Size(30, 19);
            lblTitreProjSoum32.TabIndex = 446;
            lblTitreProjSoum32.Text = "15";
            lblTitreProjSoum32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProjSoum18
            // 
            lblTitreProjSoum18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum18.Location = new System.Drawing.Point(63, 807);
            lblTitreProjSoum18.Name = "lblTitreProjSoum18";
            lblTitreProjSoum18.Size = new System.Drawing.Size(604, 19);
            lblTitreProjSoum18.TabIndex = 444;
            // 
            // lblTitreProjSoum19
            // 
            lblTitreProjSoum19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum19.Location = new System.Drawing.Point(670, 807);
            lblTitreProjSoum19.Name = "lblTitreProjSoum19";
            lblTitreProjSoum19.Size = new System.Drawing.Size(124, 19);
            lblTitreProjSoum19.TabIndex = 443;
            // 
            // lblTitreProjSoum22
            // 
            lblTitreProjSoum22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum22.Location = new System.Drawing.Point(64, 787);
            lblTitreProjSoum22.Name = "lblTitreProjSoum22";
            lblTitreProjSoum22.Size = new System.Drawing.Size(603, 19);
            lblTitreProjSoum22.TabIndex = 440;
            // 
            // lblTitreProjSoum23
            // 
            lblTitreProjSoum23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum23.Location = new System.Drawing.Point(670, 787);
            lblTitreProjSoum23.Name = "lblTitreProjSoum23";
            lblTitreProjSoum23.Size = new System.Drawing.Size(124, 19);
            lblTitreProjSoum23.TabIndex = 439;
            // 
            // lblTitreProjSoum24
            // 
            lblTitreProjSoum24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum24.Location = new System.Drawing.Point(22, 785);
            lblTitreProjSoum24.Name = "lblTitreProjSoum24";
            lblTitreProjSoum24.Size = new System.Drawing.Size(30, 19);
            lblTitreProjSoum24.TabIndex = 438;
            lblTitreProjSoum24.Text = "14";
            lblTitreProjSoum24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProjSoum10
            // 
            lblTitreProjSoum10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum10.Location = new System.Drawing.Point(63, 767);
            lblTitreProjSoum10.Name = "lblTitreProjSoum10";
            lblTitreProjSoum10.Size = new System.Drawing.Size(604, 19);
            lblTitreProjSoum10.TabIndex = 436;
            // 
            // lblTitreProjSoum11
            // 
            lblTitreProjSoum11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum11.Location = new System.Drawing.Point(670, 767);
            lblTitreProjSoum11.Name = "lblTitreProjSoum11";
            lblTitreProjSoum11.Size = new System.Drawing.Size(124, 19);
            lblTitreProjSoum11.TabIndex = 435;
            // 
            // lblTitreProjSoum14
            // 
            lblTitreProjSoum14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum14.Location = new System.Drawing.Point(63, 747);
            lblTitreProjSoum14.Name = "lblTitreProjSoum14";
            lblTitreProjSoum14.Size = new System.Drawing.Size(604, 19);
            lblTitreProjSoum14.TabIndex = 432;
            // 
            // lblTitreProjSoum15
            // 
            lblTitreProjSoum15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum15.Location = new System.Drawing.Point(670, 747);
            lblTitreProjSoum15.Name = "lblTitreProjSoum15";
            lblTitreProjSoum15.Size = new System.Drawing.Size(124, 19);
            lblTitreProjSoum15.TabIndex = 431;
            // 
            // lblTitreProjSoum16
            // 
            lblTitreProjSoum16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum16.Location = new System.Drawing.Point(22, 745);
            lblTitreProjSoum16.Name = "lblTitreProjSoum16";
            lblTitreProjSoum16.Size = new System.Drawing.Size(30, 19);
            lblTitreProjSoum16.TabIndex = 430;
            lblTitreProjSoum16.Text = "13";
            lblTitreProjSoum16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreProjSoum02
            // 
            lblTitreProjSoum02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum02.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum02.Location = new System.Drawing.Point(63, 727);
            lblTitreProjSoum02.Name = "lblTitreProjSoum02";
            lblTitreProjSoum02.Size = new System.Drawing.Size(604, 19);
            lblTitreProjSoum02.TabIndex = 428;
            // 
            // lblTitreProjSoum03
            // 
            lblTitreProjSoum03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum03.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum03.Location = new System.Drawing.Point(669, 727);
            lblTitreProjSoum03.Name = "lblTitreProjSoum03";
            lblTitreProjSoum03.Size = new System.Drawing.Size(124, 19);
            lblTitreProjSoum03.TabIndex = 427;
            // 
            // lblTitreProjSoum06
            // 
            lblTitreProjSoum06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum06.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum06.Location = new System.Drawing.Point(63, 707);
            lblTitreProjSoum06.Name = "lblTitreProjSoum06";
            lblTitreProjSoum06.Size = new System.Drawing.Size(604, 19);
            lblTitreProjSoum06.TabIndex = 424;
            // 
            // lblTitreProjSoum07
            // 
            lblTitreProjSoum07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum07.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum07.Location = new System.Drawing.Point(669, 707);
            lblTitreProjSoum07.Name = "lblTitreProjSoum07";
            lblTitreProjSoum07.Size = new System.Drawing.Size(124, 19);
            lblTitreProjSoum07.TabIndex = 423;
            // 
            // lblTitreProjSoum08
            // 
            lblTitreProjSoum08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum08.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum08.Location = new System.Drawing.Point(21, 705);
            lblTitreProjSoum08.Name = "lblTitreProjSoum08";
            lblTitreProjSoum08.Size = new System.Drawing.Size(30, 19);
            lblTitreProjSoum08.TabIndex = 422;
            lblTitreProjSoum08.Text = "12";
            lblTitreProjSoum08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label94
            // 
            label94.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label94.Location = new System.Drawing.Point(63, 687);
            label94.Name = "label94";
            label94.Size = new System.Drawing.Size(604, 19);
            label94.TabIndex = 420;
            // 
            // label95
            // 
            label95.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label95.Location = new System.Drawing.Point(670, 687);
            label95.Name = "label95";
            label95.Size = new System.Drawing.Size(124, 19);
            label95.TabIndex = 419;
            // 
            // label98
            // 
            label98.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label98.Location = new System.Drawing.Point(63, 667);
            label98.Name = "label98";
            label98.Size = new System.Drawing.Size(604, 19);
            label98.TabIndex = 416;
            // 
            // label99
            // 
            label99.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label99.Location = new System.Drawing.Point(670, 667);
            label99.Name = "label99";
            label99.Size = new System.Drawing.Size(124, 19);
            label99.TabIndex = 415;
            // 
            // lblTitreProjSoum00
            // 
            lblTitreProjSoum00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTitreProjSoum00.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum00.Location = new System.Drawing.Point(22, 665);
            lblTitreProjSoum00.Name = "lblTitreProjSoum00";
            lblTitreProjSoum00.Size = new System.Drawing.Size(30, 19);
            lblTitreProjSoum00.TabIndex = 414;
            lblTitreProjSoum00.Text = "11";
            lblTitreProjSoum00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label86
            // 
            label86.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label86.Location = new System.Drawing.Point(63, 647);
            label86.Name = "label86";
            label86.Size = new System.Drawing.Size(604, 19);
            label86.TabIndex = 412;
            // 
            // label87
            // 
            label87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label87.Location = new System.Drawing.Point(669, 647);
            label87.Name = "label87";
            label87.Size = new System.Drawing.Size(124, 19);
            label87.TabIndex = 411;
            // 
            // label90
            // 
            label90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label90.Location = new System.Drawing.Point(63, 627);
            label90.Name = "label90";
            label90.Size = new System.Drawing.Size(604, 19);
            label90.TabIndex = 408;
            // 
            // label91
            // 
            label91.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label91.Location = new System.Drawing.Point(669, 627);
            label91.Name = "label91";
            label91.Size = new System.Drawing.Size(124, 19);
            label91.TabIndex = 407;
            // 
            // label92
            // 
            label92.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label92.Location = new System.Drawing.Point(21, 625);
            label92.Name = "label92";
            label92.Size = new System.Drawing.Size(30, 19);
            label92.TabIndex = 406;
            label92.Text = "10";
            label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            label78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label78.Location = new System.Drawing.Point(63, 607);
            label78.Name = "label78";
            label78.Size = new System.Drawing.Size(604, 19);
            label78.TabIndex = 404;
            // 
            // label79
            // 
            label79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label79.Location = new System.Drawing.Point(669, 607);
            label79.Name = "label79";
            label79.Size = new System.Drawing.Size(124, 19);
            label79.TabIndex = 403;
            // 
            // label82
            // 
            label82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label82.Location = new System.Drawing.Point(63, 587);
            label82.Name = "label82";
            label82.Size = new System.Drawing.Size(604, 19);
            label82.TabIndex = 400;
            // 
            // label83
            // 
            label83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label83.Location = new System.Drawing.Point(669, 587);
            label83.Name = "label83";
            label83.Size = new System.Drawing.Size(124, 19);
            label83.TabIndex = 399;
            // 
            // label84
            // 
            label84.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label84.Location = new System.Drawing.Point(22, 585);
            label84.Name = "label84";
            label84.Size = new System.Drawing.Size(30, 19);
            label84.TabIndex = 398;
            label84.Text = "9";
            label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            label70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label70.Location = new System.Drawing.Point(63, 567);
            label70.Name = "label70";
            label70.Size = new System.Drawing.Size(604, 19);
            label70.TabIndex = 396;
            // 
            // label71
            // 
            label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label71.Location = new System.Drawing.Point(669, 567);
            label71.Name = "label71";
            label71.Size = new System.Drawing.Size(124, 19);
            label71.TabIndex = 395;
            // 
            // label74
            // 
            label74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label74.Location = new System.Drawing.Point(63, 547);
            label74.Name = "label74";
            label74.Size = new System.Drawing.Size(604, 19);
            label74.TabIndex = 392;
            // 
            // label75
            // 
            label75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label75.Location = new System.Drawing.Point(669, 547);
            label75.Name = "label75";
            label75.Size = new System.Drawing.Size(124, 19);
            label75.TabIndex = 391;
            // 
            // label76
            // 
            label76.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label76.Location = new System.Drawing.Point(21, 547);
            label76.Name = "label76";
            label76.Size = new System.Drawing.Size(30, 19);
            label76.TabIndex = 390;
            label76.Text = "8";
            label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label62.Location = new System.Drawing.Point(63, 527);
            label62.Name = "label62";
            label62.Size = new System.Drawing.Size(604, 19);
            label62.TabIndex = 388;
            // 
            // label63
            // 
            label63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label63.Location = new System.Drawing.Point(669, 527);
            label63.Name = "label63";
            label63.Size = new System.Drawing.Size(124, 19);
            label63.TabIndex = 387;
            // 
            // label66
            // 
            label66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label66.Location = new System.Drawing.Point(63, 507);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(604, 19);
            label66.TabIndex = 384;
            // 
            // label67
            // 
            label67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label67.Location = new System.Drawing.Point(669, 507);
            label67.Name = "label67";
            label67.Size = new System.Drawing.Size(124, 19);
            label67.TabIndex = 383;
            // 
            // label68
            // 
            label68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label68.Location = new System.Drawing.Point(21, 507);
            label68.Name = "label68";
            label68.Size = new System.Drawing.Size(30, 19);
            label68.TabIndex = 382;
            label68.Text = "7";
            label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label54.Location = new System.Drawing.Point(63, 487);
            label54.Name = "label54";
            label54.Size = new System.Drawing.Size(604, 19);
            label54.TabIndex = 380;
            // 
            // label55
            // 
            label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label55.Location = new System.Drawing.Point(669, 487);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(124, 19);
            label55.TabIndex = 379;
            // 
            // label58
            // 
            label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label58.Location = new System.Drawing.Point(64, 467);
            label58.Name = "label58";
            label58.Size = new System.Drawing.Size(603, 19);
            label58.TabIndex = 376;
            // 
            // label59
            // 
            label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label59.Location = new System.Drawing.Point(669, 467);
            label59.Name = "label59";
            label59.Size = new System.Drawing.Size(124, 19);
            label59.TabIndex = 375;
            // 
            // lblNomEmploye
            // 
            lblNomEmploye.Location = new System.Drawing.Point(236, 64);
            lblNomEmploye.Name = "lblNomEmploye";
            lblNomEmploye.Size = new System.Drawing.Size(169, 20);
            lblNomEmploye.TabIndex = 21;
            // 
            // lblNoProjSoum
            // 
            lblNoProjSoum.Location = new System.Drawing.Point(236, 41);
            lblNoProjSoum.Name = "lblNoProjSoum";
            lblNoProjSoum.Size = new System.Drawing.Size(169, 20);
            lblNoProjSoum.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            label8.Location = new System.Drawing.Point(63, 243);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(159, 16);
            label8.TabIndex = 454;
            label8.Text = "Problèmes rencontrés";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.Location = new System.Drawing.Point(641, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(173, 73);
            pictureBox1.TabIndex = 455;
            pictureBox1.TabStop = false;
            // 
            // lblTitreProjSoum
            // 
            lblTitreProjSoum.AutoSize = true;
            lblTitreProjSoum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreProjSoum.Location = new System.Drawing.Point(21, 1);
            lblTitreProjSoum.Name = "lblTitreProjSoum";
            lblTitreProjSoum.Size = new System.Drawing.Size(202, 26);
            lblTitreProjSoum.TabIndex = 456;
            lblTitreProjSoum.Text = "Problèmes rencontrés";
            // 
            // ViewProblemes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(lblTitreProjSoum);
            Controls.Add(pictureBox1);
            Controls.Add(lblNomEmploye);
            Controls.Add(lblNoProjSoum);
            Controls.Add(label8);
            Controls.Add(label60);
            Controls.Add(lblTitreBC);
            Controls.Add(label46);
            Controls.Add(lblTitreNoSoum);
            Controls.Add(label47);
            Controls.Add(label50);
            Controls.Add(label51);
            Controls.Add(label52);
            Controls.Add(label38);
            Controls.Add(label39);
            Controls.Add(label42);
            Controls.Add(label43);
            Controls.Add(label44);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label34);
            Controls.Add(label35);
            Controls.Add(label36);
            Controls.Add(lblTitreProjSoum0);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(lblTitreProjSoum8);
            Controls.Add(lblTitreProjSoum9);
            Controls.Add(label20);
            Controls.Add(lblTitreProjSoum4);
            Controls.Add(lblTitreProjSoum5);
            Controls.Add(lblTitreProjSoum6);
            Controls.Add(lblTitreProjSoum7);
            Controls.Add(lblTitreProjSoum1);
            Controls.Add(lbltitredate);
            Controls.Add(lblTitreProjSoum26);
            Controls.Add(lblTitreProjSoum27);
            Controls.Add(lblTitreProjSoum30);
            Controls.Add(lblTitreProjSoum31);
            Controls.Add(lblTitreProjSoum32);
            Controls.Add(lblTitreProjSoum18);
            Controls.Add(lblTitreProjSoum19);
            Controls.Add(lblTitreProjSoum22);
            Controls.Add(lblTitreProjSoum23);
            Controls.Add(lblTitreProjSoum24);
            Controls.Add(lblTitreProjSoum10);
            Controls.Add(lblTitreProjSoum11);
            Controls.Add(lblTitreProjSoum14);
            Controls.Add(lblTitreProjSoum15);
            Controls.Add(lblTitreProjSoum16);
            Controls.Add(lblTitreProjSoum02);
            Controls.Add(lblTitreProjSoum03);
            Controls.Add(lblTitreProjSoum06);
            Controls.Add(lblTitreProjSoum07);
            Controls.Add(lblTitreProjSoum08);
            Controls.Add(label94);
            Controls.Add(label95);
            Controls.Add(label98);
            Controls.Add(label99);
            Controls.Add(lblTitreProjSoum00);
            Controls.Add(label86);
            Controls.Add(label87);
            Controls.Add(label90);
            Controls.Add(label91);
            Controls.Add(label92);
            Controls.Add(label78);
            Controls.Add(label79);
            Controls.Add(label82);
            Controls.Add(label83);
            Controls.Add(label84);
            Controls.Add(label70);
            Controls.Add(label71);
            Controls.Add(label74);
            Controls.Add(label75);
            Controls.Add(label76);
            Controls.Add(label62);
            Controls.Add(label63);
            Controls.Add(label66);
            Controls.Add(label67);
            Controls.Add(label68);
            Controls.Add(label54);
            Controls.Add(label55);
            Controls.Add(label58);
            Controls.Add(label59);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewProblemes";
            ShowInTaskbar = false;
            Text = "ViewProblemes";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label lblTitreNoSoum;
        internal static Label lblTitreBC;
        internal static Label label60;
        internal static Label label46;
        internal static Label label47;
        internal static Label label50;
        internal static Label label51;
        internal static Label label52;
        internal static Label label38;
        internal static Label label39;
        internal static Label label42;
        internal static Label label43;
        internal static Label label44;
        internal static Label label30;
        internal static Label label31;
        internal static Label label34;
        internal static Label label35;
        internal static Label label36;
        internal static Label lblTitreProjSoum0;
        internal static Label label22;
        internal static Label label23;
        internal static Label label25;
        internal static Label label26;
        internal static Label label27;
        internal static Label label28;
        internal static Label lblTitreProjSoum8;
        internal static Label lblTitreProjSoum9;
        internal static Label label20;
        internal static Label lblTitreProjSoum4;
        internal static Label lblTitreProjSoum5;
        internal static Label lblTitreProjSoum6;
        internal static Label lblTitreProjSoum7;
        internal static Label lblTitreProjSoum1;
        internal static Label lbltitredate;
        internal static Label lblTitreProjSoum26;
        internal static Label lblTitreProjSoum27;
        internal static Label lblTitreProjSoum30;
        internal static Label lblTitreProjSoum31;
        internal static Label lblTitreProjSoum32;
        internal static Label lblTitreProjSoum18;
        internal static Label lblTitreProjSoum19;
        internal static Label lblTitreProjSoum22;
        internal static Label lblTitreProjSoum23;
        internal static Label lblTitreProjSoum24;
        internal static Label lblTitreProjSoum10;
        internal static Label lblTitreProjSoum11;
        internal static Label lblTitreProjSoum14;
        internal static Label lblTitreProjSoum15;
        internal static Label lblTitreProjSoum16;
        internal static Label lblTitreProjSoum02;
        internal static Label lblTitreProjSoum03;
        internal static Label lblTitreProjSoum06;
        internal static Label lblTitreProjSoum07;
        internal static Label lblTitreProjSoum08;
        internal static Label label94;
        internal static Label label95;
        internal static Label label98;
        internal static Label label99;
        internal static Label lblTitreProjSoum00;
        internal static Label label86;
        internal static Label label87;
        internal static Label label90;
        internal static Label label91;
        internal static Label label92;
        internal static Label label78;
        internal static Label label79;
        internal static Label label82;
        internal static Label label83;
        internal static Label label84;
        internal static Label label70;
        internal static Label label71;
        internal static Label label74;
        internal static Label label75;
        internal static Label label76;
        internal static Label label62;
        internal static Label label63;
        internal static Label label66;
        internal static Label label67;
        internal static Label label68;
        internal static Label label54;
        internal static Label label55;
        internal static Label label58;
        internal static Label label59;
        internal static TextBox lblNomEmploye;
        internal static TextBox lblNoProjSoum;
        internal static PictureBox pictureBox1;
        internal static Label lblTitreProjSoum;
        internal static Label label8;

        public static bool Orientation { get; internal set; }
        public ViewProblemes()
        {
            InitializeComponent();
            lblNomEmploye.Text = Program.IdNomEmploye;
            lblTitreBC.Text = ViewProblemes.lblTitreProjSoum.Text;
            lblNoProjSoum.Text = ViewProblemes.lblNoProjSoum.Text;
            if (ViewProblemes.lblNomEmploye.Text == string.Empty)
            {
                lblNomEmploye.Text = Program.IdNomEmploye;
            }
            else
            {
                lblNomEmploye.Text = ViewProblemes.lblNomEmploye.Text;
            }
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
