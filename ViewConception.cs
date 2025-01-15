using ADODB;
using Microsoft.VisualBasic;
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
using ControleurServeur;
using Application = System.Windows.Forms.Application;
namespace ControleurServeur
{
    public class ViewConception : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewConception));
            lblPage = new System.Windows.Forms.Label();
            lblPiedPage = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            Controls7 = new System.Windows.Forms.Label();
            Controls7p = new System.Windows.Forms.Label();
            lblNoSoum = new System.Windows.Forms.Label();
            lblProjet = new System.Windows.Forms.Label();
            Controls1 = new System.Windows.Forms.Label();
            Controls46 = new System.Windows.Forms.Label();
            lblTitreCommande = new System.Windows.Forms.Label();
            lblDateOuverture = new System.Windows.Forms.Label();
            Controls2 = new System.Windows.Forms.Label();
            Controls33 = new System.Windows.Forms.Label();
            TextBox1 = new System.Windows.Forms.Label();
            Controls34 = new System.Windows.Forms.Label();
            TextBox2 = new System.Windows.Forms.Label();
            Controls35 = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            Controls40 = new System.Windows.Forms.Label();
            Controls5 = new System.Windows.Forms.Label();
            Controls47 = new System.Windows.Forms.Label();
            Controls6 = new System.Windows.Forms.Label();
            lblTel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblFax = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            TextBox3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblBC = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // lblPage
            // 
            lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            lblPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPage.Location = new System.Drawing.Point(586, 1110);
            lblPage.Name = "lblPage";
            lblPage.Size = new System.Drawing.Size(236, 19);
            lblPage.TabIndex = 14;
            lblPage.Text = "Page 1 sur 1";
            lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPiedPage
            // 
            lblPiedPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblPiedPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPiedPage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPiedPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            lblPiedPage.Location = new System.Drawing.Point(0, 1110);
            lblPiedPage.Name = "lblPiedPage";
            lblPiedPage.Size = new System.Drawing.Size(565, 19);
            lblPiedPage.TabIndex = 15;
            lblPiedPage.Text = "lblPiedPage";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.Location = new System.Drawing.Point(640, 1);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(175, 72);
            pictureBox1.TabIndex = 310;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(32, 23);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 29);
            label1.TabIndex = 311;
            label1.Text = "Conception";
            // 
            // Controls7
            // 
            Controls7.AutoSize = true;
            Controls7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls7.Location = new System.Drawing.Point(34, 111);
            Controls7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls7.Name = "Controls7";
            Controls7.Size = new System.Drawing.Size(74, 14);
            Controls7.TabIndex = 312;
            Controls7.Text = "Soumission:";
            // 
            // Controls7p
            // 
            Controls7p.AutoSize = true;
            Controls7p.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls7p.Location = new System.Drawing.Point(246, 111);
            Controls7p.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls7p.Name = "Controls7p";
            Controls7p.Size = new System.Drawing.Size(38, 14);
            Controls7p.TabIndex = 313;
            Controls7p.Text = "Projet";
            // 
            // lblNoSoum
            // 
            lblNoSoum.AutoSize = true;
            lblNoSoum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoSoum.Location = new System.Drawing.Point(124, 111);
            lblNoSoum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNoSoum.Name = "lblNoSoum";
            lblNoSoum.Size = new System.Drawing.Size(67, 14);
            lblNoSoum.TabIndex = 314;
            lblNoSoum.Text = "lblNoSoum";
            // 
            // lblProjet
            // 
            lblProjet.AutoSize = true;
            lblProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProjet.Location = new System.Drawing.Point(297, 111);
            lblProjet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblProjet.Name = "lblProjet";
            lblProjet.Size = new System.Drawing.Size(53, 14);
            lblProjet.TabIndex = 315;
            lblProjet.Text = "lblProjet";
            // 
            // Controls1
            // 
            Controls1.AutoSize = true;
            Controls1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls1.Location = new System.Drawing.Point(619, 160);
            Controls1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls1.Name = "Controls1";
            Controls1.Size = new System.Drawing.Size(36, 14);
            Controls1.TabIndex = 316;
            Controls1.Text = "Date:";
            // 
            // Controls46
            // 
            Controls46.AutoSize = true;
            Controls46.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls46.Location = new System.Drawing.Point(656, 160);
            Controls46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls46.Name = "Controls46";
            Controls46.Size = new System.Drawing.Size(64, 14);
            Controls46.TabIndex = 317;
            Controls46.Text = "Controls46";
            // 
            // lblTitreCommande
            // 
            lblTitreCommande.AutoSize = true;
            lblTitreCommande.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreCommande.Location = new System.Drawing.Point(124, 92);
            lblTitreCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTitreCommande.Name = "lblTitreCommande";
            lblTitreCommande.Size = new System.Drawing.Size(108, 14);
            lblTitreCommande.TabIndex = 321;
            lblTitreCommande.Text = "lblTitreCommande";
            // 
            // lblDateOuverture
            // 
            lblDateOuverture.AutoSize = true;
            lblDateOuverture.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateOuverture.Location = new System.Drawing.Point(124, 129);
            lblDateOuverture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDateOuverture.Name = "lblDateOuverture";
            lblDateOuverture.Size = new System.Drawing.Size(101, 14);
            lblDateOuverture.TabIndex = 320;
            lblDateOuverture.Text = "lblDateOuverture";
            // 
            // Controls2
            // 
            Controls2.AutoSize = true;
            Controls2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls2.Location = new System.Drawing.Point(34, 92);
            Controls2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls2.Name = "Controls2";
            Controls2.Size = new System.Drawing.Size(68, 14);
            Controls2.TabIndex = 319;
            Controls2.Text = "Projet/Nom";
            // 
            // Controls33
            // 
            Controls33.AutoSize = true;
            Controls33.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls33.Location = new System.Drawing.Point(34, 129);
            Controls33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls33.Name = "Controls33";
            Controls33.Size = new System.Drawing.Size(101, 14);
            Controls33.TabIndex = 318;
            Controls33.Text = "Date d\'ouverture:";
            // 
            // TextBox1
            // 
            TextBox1.AutoSize = true;
            TextBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox1.Location = new System.Drawing.Point(297, 129);
            TextBox1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new System.Drawing.Size(53, 14);
            TextBox1.TabIndex = 323;
            TextBox1.Text = "TextBox1";
            // 
            // Controls34
            // 
            Controls34.AutoSize = true;
            Controls34.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls34.Location = new System.Drawing.Point(246, 129);
            Controls34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls34.Name = "Controls34";
            Controls34.Size = new System.Drawing.Size(60, 14);
            Controls34.TabIndex = 322;
            Controls34.Text = "Date dûe:";
            // 
            // TextBox2
            // 
            TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TextBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox2.Location = new System.Drawing.Point(659, 129);
            TextBox2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new System.Drawing.Size(52, 15);
            TextBox2.TabIndex = 325;
            // 
            // Controls35
            // 
            Controls35.AutoSize = true;
            Controls35.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls35.Location = new System.Drawing.Point(616, 130);
            Controls35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls35.Name = "Controls35";
            Controls35.Size = new System.Drawing.Size(43, 14);
            Controls35.TabIndex = 324;
            Controls35.Text = "Heure:";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClient.Location = new System.Drawing.Point(124, 145);
            lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(54, 14);
            lblClient.TabIndex = 327;
            lblClient.Text = "lblClient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(34, 145);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 14);
            label3.TabIndex = 326;
            label3.Text = "Client";
            // 
            // Controls40
            // 
            Controls40.AutoSize = true;
            Controls40.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls40.Location = new System.Drawing.Point(124, 160);
            Controls40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls40.Name = "Controls40";
            Controls40.Size = new System.Drawing.Size(64, 14);
            Controls40.TabIndex = 329;
            Controls40.Text = "Controls40";
            // 
            // Controls5
            // 
            Controls5.AutoSize = true;
            Controls5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls5.Location = new System.Drawing.Point(34, 160);
            Controls5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls5.Name = "Controls5";
            Controls5.Size = new System.Drawing.Size(47, 14);
            Controls5.TabIndex = 328;
            Controls5.Text = "Contact";
            // 
            // Controls47
            // 
            Controls47.AutoSize = true;
            Controls47.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls47.Location = new System.Drawing.Point(124, 176);
            Controls47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls47.Name = "Controls47";
            Controls47.Size = new System.Drawing.Size(64, 14);
            Controls47.TabIndex = 331;
            Controls47.Text = "Controls47";
            // 
            // Controls6
            // 
            Controls6.AutoSize = true;
            Controls6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls6.Location = new System.Drawing.Point(34, 176);
            Controls6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Controls6.Name = "Controls6";
            Controls6.Size = new System.Drawing.Size(41, 14);
            Controls6.TabIndex = 330;
            Controls6.Text = "Projet:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTel.Location = new System.Drawing.Point(270, 160);
            lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new System.Drawing.Size(38, 14);
            lblTel.TabIndex = 333;
            lblTel.Text = "lblTel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(246, 160);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 14);
            label4.TabIndex = 332;
            label4.Text = "Tél.:";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFax.Location = new System.Drawing.Point(445, 160);
            lblFax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFax.Name = "lblFax";
            lblFax.Size = new System.Drawing.Size(40, 14);
            lblFax.TabIndex = 335;
            lblFax.Text = "lblFax";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(421, 160);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(28, 14);
            label5.TabIndex = 334;
            label5.Text = "Fax:";
            // 
            // TextBox3
            // 
            TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TextBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox3.Location = new System.Drawing.Point(530, 129);
            TextBox3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new System.Drawing.Size(85, 17);
            TextBox3.TabIndex = 337;
            TextBox3.Text = "TextBox3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(419, 130);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(107, 14);
            label6.TabIndex = 336;
            label6.Text = "Date de fermeture";
            // 
            // lblBC
            // 
            lblBC.AutoSize = true;
            lblBC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBC.Location = new System.Drawing.Point(461, 111);
            lblBC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBC.Name = "lblBC";
            lblBC.Size = new System.Drawing.Size(35, 14);
            lblBC.TabIndex = 340;
            lblBC.Text = "lblBC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(419, 111);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(32, 14);
            label7.TabIndex = 339;
            label7.Text = "B.C.#";
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.Color.White;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4});
            listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.GridLines = true;
            listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listView1.HideSelection = false;
            listView1.LabelWrap = false;
            listView1.Location = new System.Drawing.Point(22, 213);
            listView1.Name = "listView1";
            listView1.Scrollable = false;
            listView1.ShowGroups = false;
            listView1.Size = new System.Drawing.Size(775, 817);
            listView1.TabIndex = 341;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = " ";
            columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Contact";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 252;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Commentaires";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 430;
            // 
            // ViewConception
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(lblPiedPage);
            Controls.Add(listView1);
            Controls.Add(lblPage);
            Controls.Add(lblBC);
            Controls.Add(label7);
            Controls.Add(TextBox3);
            Controls.Add(label6);
            Controls.Add(lblFax);
            Controls.Add(label5);
            Controls.Add(lblTel);
            Controls.Add(label4);
            Controls.Add(Controls47);
            Controls.Add(Controls6);
            Controls.Add(Controls40);
            Controls.Add(Controls5);
            Controls.Add(lblClient);
            Controls.Add(label3);
            Controls.Add(TextBox2);
            Controls.Add(Controls35);
            Controls.Add(TextBox1);
            Controls.Add(Controls34);
            Controls.Add(lblTitreCommande);
            Controls.Add(lblDateOuverture);
            Controls.Add(Controls2);
            Controls.Add(Controls33);
            Controls.Add(Controls46);
            Controls.Add(Controls1);
            Controls.Add(lblProjet);
            Controls.Add(lblNoSoum);
            Controls.Add(Controls7p);
            Controls.Add(Controls7);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewConception";
            ShowInTaskbar = false;
            Text = "ViewConception";
            Load += new System.EventHandler(ViewConception_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static Label lblPage;
        internal static Label lblPiedPage;
        internal static PictureBox pictureBox1;
        internal static Label label1;
        internal static Label Controls7;
        internal static Label Controls7p;
        internal static Label lblNoSoum;
        internal static Label lblProjet;
        internal static Label Controls1;
        internal static Label Controls46;
        internal static Label lblTitreCommande;
        internal static Label lblDateOuverture;
        internal static Label Controls2;
        internal static Label Controls33;
        internal static Label TextBox1;
        internal static Label Controls34;
        internal static Label TextBox2;
        internal static Label Controls35;
        internal static Label lblClient;
        internal static Label label3;
        internal static Label Controls40;
        internal static Label Controls5;
        internal static Label Controls47;
        internal static Label Controls6;
        internal static Label lblTel;
        internal static Label label4;
        internal static Label lblFax;
        internal static Label label5;
        internal static Label TextBox3;
        internal static Label label6;
        internal static Label lblBC;
        internal static Label label7;
        internal static ColumnHeader columnHeader1;
        internal static ColumnHeader columnHeader2;
        internal static ColumnHeader columnHeader3;
        internal static ColumnHeader columnHeader4;
        internal static ListView listView1;

        private void PrintForm()
        {
            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Left, Top, 0, 0, s);
        }
        bool test = false;
        public static bool Orientation { get; internal set; }
        public ViewConception(bool test)
        {
            InitializeComponent();
            test = test;
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            Recordset rd = new Recordset();
            rd.Open($"SELECT CONTACTCLIENT.NOCLIENT,COMPAGNIE,IDPROJSOUM,BONSCOMMANDES.NOBONCOMMANDE, NOMCONTACT, DATEOUVERTURE, DATEREQUISE, DATEFERMETURE,  " +
                $" DESCRIPTION, CONTACT.TELEPHONNE, CONTACT.FAX FROM[DBO].[PROJSOUM] " +
                $"JOIN[DBO].[BONSCOMMANDES] ON PROJSOUM.IDPROJSOUM = BONSCOMMANDES.NOPROJET " +
                $"JOIN[DBO].[CONTACTCLIENT] ON[DBO].[PROJSOUM].NOCLIENT =[DBO].[CONTACTCLIENT].NOCLIENT " +
                $"JOIN CONTACT ON[DBO].[CONTACTCLIENT].NOCONTACT =[DBO].[CONTACT].IDCONTACT " +
                $"WHERE CONTACTCLIENT.NOCLIENT = '7051' " +
                $"ORDER BY DATEFERMETURE DESC", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
            }
            ViewConception.Orientation = false;
            ViewConception.lblClient.Text = $"{rd.Fields[1].Value}";
            ViewConception.Controls33.Text = $"{rd.Fields[4].Value}";
            ViewConception.lblTel.Text = $"{rd.Fields[9].Value}";
            ViewConception.lblFax.Text = $"{rd.Fields[10].Value}";
            ViewConception.lblNoSoum.Text = $"{rd.Fields[2].Value}"; 
            ViewConception.lblProjet.Text = Program.Gauche($"{rd.Fields[9].Value}",9); 
            ViewConception.lblProjet.Text += $"  {rd.Fields[9].Value}";
            ViewConception.TextBox3.Text = $"{rd.Fields[7].Value}";
            ViewConception.TextBox2.Text = DateTime.Today.ToShortDateString();
            ViewConception.lblTitreCommande.Text = $"{rd.Fields[9].Value}";
            Form rp = new ViewConception();
            rp.Text = $"Impression demandée par {Program.IdNomEmploye} [{Conteneur.ip}\\{Environment.UserName} ]";
            rp.Show();
        }
        public ViewConception()
        {
            InitializeComponent();
            test = false;
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
        }
        private void EnumérerDonnées()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("");
            listView1.Columns.Add("Date");
            listView1.Columns.Add("Contact");
            listView1.Columns.Add("Commentaire");
            listView1.Columns[0].Width = 50;
            listView1.Columns[1].Width = 150;
            listView1.Columns[2].Width = 150;
            listView1.Columns[3].Width = 550;
            ADODB.Recordset rd = new ADODB.Recordset();
            rd.Open($"SELECT  top(1) * ,BONSCOMMANDES_PIECES.*,FOURNISSEUR.* FROM BONSCOMMANDES " +
                $"JOIN [DBO].[BONSCOMMANDES_PIECES] ON[DBO].[BONSCOMMANDES_PIECES].NOBONCOMMANDE =[DBO].[BONSCOMMANDES].NOBONCOMMANDE " +
                $"JOIN [DBO].[FOURNISSEUR] ON[DBO].[BONSCOMMANDES].NOFOURNISSEUR =[DBO].[FOURNISSEUR].IDFRS " +
                $"JOIN [DBO].[ProjetMec] on[DBO].[ProjetMec].IDProjet =[DBO].[BonsCommandes].NoProjet " +
                $"JOIN [DBO].[SoumissionMec] on[DBO].[ProjetMec].IDProjet =[DBO].[BonsCommandes].NoProjet " +
                $"JOIN [DBO].[Client]on[DBO].[Client].IDClient =[DBO].[SoumissionMec].IDClient " +
                $"JOIN [DBO].[contact] on[DBO].[contact].IDContact =[DBO].[SoumissionMec].IDContact " +
                $"WHERE[DBO].[BONSCOMMANDES].NOBONCOMMANDE = 'M23005-01-204' AND[DBO].[BONSCOMMANDES].NOFOURNISSEUR = '717' " +
                $"AND[DBO].[BONSCOMMANDES_PIECES].QTÉ IS NOT NULL ORDER BY[DATEREQUISE],[DATECOMMANDE]",
                Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                lblNoSoum.Text = rd.Fields[122].Value;
                lblProjet.Text = rd.Fields[49].Value;
                Controls40.Text = rd.Fields[3].Value;
                lblBC.Text = rd.Fields[0].Value;
                lblTitreCommande.Text = rd.Fields[18].Value;
                lblDateOuverture.Text = rd.Fields[7].Value;
                TextBox1.Text = rd.Fields[5].Value;
                TextBox2.Text = "";
                TextBox1.Enabled = false;
                lblClient.Text = rd.Fields[180].Value;
                TextBox3.Text = "";
                lblFax.Text = rd.Fields[36].Value;
                lblTel.Text = rd.Fields[35].Value;
                Controls47.Text = rd.Fields[125].Value;
            }
            rd.Close();
            rd = null;
            listView1.BackColor = Color.White;
            for (int a = 1; a <= 0x15; a++) //represente le range de ligne sur le doc
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{a}"));
                itm.BackColor = Color.AliceBlue;
                if (a < 0x15) { itm = listView1.Items.Add(string.Empty); }
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, string.Empty));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, string.Empty));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, string.Empty));
            }
            ListViewItem itm1 = listView1.Items.Add(string.Empty);
            lblPage.Text = $"{DateTime.Now.ToString()} Page 1 sur 1";
            return;
        }
        private void ViewConception_Load(object sender, EventArgs e)
        {
            Controls46.Text = Program.ConvertToUSDate(DateTime.Now);
            if (test == true)
            {
                lblPiedPage.Text = "production.grb.local/content/dynamics?Conception=test&&User=" + Program.IdLoginEmploye + "@" + System.Windows.Forms.Application.CompanyName;
                EnumérerDonnées();
            }
            else
            {
                lblPiedPage.Text = "production.grb.local/content/dynamics?Conception=" + lblProjet.Text;
                listView1.Columns[0].Width = 0x28;
                listView1.Columns[1].Width = 0x50;
                listView1.Columns[2].Width = 0xC8;
                listView1.Columns[3].Width = 0x1AE;
            }
        }
                    Bitmap memoryImage;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            Top = 0;
            Left = 0;
            Width = 838;
            Height = 1150; 
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
            if (MessageBox.Show("Voulez vous fermer cette vue?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
