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
    public class ViewFabricationFermeture : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFabricationFermeture));
            ViewTitre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblDatePrint = new System.Windows.Forms.Label();
            lblGrandTotal = new System.Windows.Forms.Label();
            lblSoum = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            lblTel = new System.Windows.Forms.Label();
            Label33 = new System.Windows.Forms.Label();
            lblFax = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblProjetNom = new System.Windows.Forms.Label();
            lblDateOuverture = new System.Windows.Forms.Label();
            Label23 = new System.Windows.Forms.Label();
            Label31 = new System.Windows.Forms.Label();
            Label34 = new System.Windows.Forms.Label();
            Label35 = new System.Windows.Forms.Label();
            lblProj = new System.Windows.Forms.Label();
            Label37 = new System.Windows.Forms.Label();
            Label32 = new System.Windows.Forms.Label();
            Label24 = new System.Windows.Forms.Label();
            blDate = new System.Windows.Forms.Label();
            Label17 = new System.Windows.Forms.Label();
            Label18 = new System.Windows.Forms.Label();
            Label19 = new System.Windows.Forms.Label();
            lblProjet = new System.Windows.Forms.Label();
            Label21 = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblGrandTotalKM = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            TextBox3 = new System.Windows.Forms.Label();
            TextBox4 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // ViewTitre
            // 
            ViewTitre.AutoSize = true;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(11, 9);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(300, 36);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Fabrication - Fermeture";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(971, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblDatePrint
            // 
            lblDatePrint.AutoSize = true;
            lblDatePrint.BackColor = System.Drawing.Color.White;
            lblDatePrint.Location = new System.Drawing.Point(370, 118);
            lblDatePrint.Name = "lblDatePrint";
            lblDatePrint.Size = new System.Drawing.Size(61, 13);
            lblDatePrint.TabIndex = 565;
            lblDatePrint.Text = "lblDatePrint";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = System.Drawing.Color.White;
            lblGrandTotal.Location = new System.Drawing.Point(932, 138);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new System.Drawing.Size(70, 13);
            lblGrandTotal.TabIndex = 566;
            lblGrandTotal.Text = "lblGrandTotal";
            // 
            // lblSoum
            // 
            lblSoum.AutoSize = true;
            lblSoum.BackColor = System.Drawing.Color.White;
            lblSoum.Location = new System.Drawing.Point(645, 36);
            lblSoum.Name = "lblSoum";
            lblSoum.Size = new System.Drawing.Size(44, 13);
            lblSoum.TabIndex = 522;
            lblSoum.Text = "lblSoum";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(14, 118);
            Label5.MinimumSize = new System.Drawing.Size(60, 19);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(60, 19);
            Label5.TabIndex = 525;
            Label5.Text = "Contact";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = System.Drawing.Color.White;
            lblContact.Location = new System.Drawing.Point(81, 118);
            lblContact.MinimumSize = new System.Drawing.Size(60, 19);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(60, 19);
            lblContact.TabIndex = 526;
            lblContact.Text = "lblContact";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(272, 138);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(22, 13);
            Label6.TabIndex = 527;
            Label6.Text = "Tél";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BackColor = System.Drawing.Color.White;
            lblTel.Location = new System.Drawing.Point(300, 138);
            lblTel.Name = "lblTel";
            lblTel.Size = new System.Drawing.Size(32, 13);
            lblTel.TabIndex = 528;
            lblTel.Text = "lblTel";
            // 
            // Label33
            // 
            Label33.AutoSize = true;
            Label33.BackColor = System.Drawing.Color.White;
            Label33.Location = new System.Drawing.Point(370, 138);
            Label33.Name = "Label33";
            Label33.Size = new System.Drawing.Size(27, 13);
            Label33.TabIndex = 529;
            Label33.Text = "Fax:";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.BackColor = System.Drawing.Color.White;
            lblFax.Cursor = System.Windows.Forms.Cursors.Default;
            lblFax.Location = new System.Drawing.Point(396, 138);
            lblFax.Name = "lblFax";
            lblFax.Size = new System.Drawing.Size(34, 13);
            lblFax.TabIndex = 530;
            lblFax.Text = "lblFax";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = System.Drawing.Color.White;
            Label8.Location = new System.Drawing.Point(484, 138);
            Label8.Name = "Label8";
            Label8.Size = new System.Drawing.Size(49, 13);
            Label8.TabIndex = 531;
            Label8.Text = "Total Km";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.White;
            Label12.Location = new System.Drawing.Point(579, 36);
            Label12.MinimumSize = new System.Drawing.Size(60, 19);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(60, 19);
            Label12.TabIndex = 533;
            Label12.Text = "Soumission";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Location = new System.Drawing.Point(763, 53);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(40, 13);
            lblDate.TabIndex = 536;
            lblDate.Text = "lblDate";
            // 
            // lblProjetNom
            // 
            lblProjetNom.AutoSize = true;
            lblProjetNom.BackColor = System.Drawing.Color.White;
            lblProjetNom.Location = new System.Drawing.Point(81, 59);
            lblProjetNom.Name = "lblProjetNom";
            lblProjetNom.Size = new System.Drawing.Size(66, 13);
            lblProjetNom.TabIndex = 541;
            lblProjetNom.Text = "lblProjetNom";
            // 
            // lblDateOuverture
            // 
            lblDateOuverture.AutoSize = true;
            lblDateOuverture.BackColor = System.Drawing.Color.White;
            lblDateOuverture.Location = new System.Drawing.Point(179, 81);
            lblDateOuverture.Name = "lblDateOuverture";
            lblDateOuverture.Size = new System.Drawing.Size(87, 13);
            lblDateOuverture.TabIndex = 542;
            lblDateOuverture.Text = "lblDateOuverture";
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.BackColor = System.Drawing.Color.White;
            Label23.Location = new System.Drawing.Point(81, 81);
            Label23.Name = "Label23";
            Label23.Size = new System.Drawing.Size(92, 13);
            Label23.TabIndex = 543;
            Label23.Text = "Date d\'ouverture: ";
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.BackColor = System.Drawing.Color.White;
            Label31.Location = new System.Drawing.Point(12, 59);
            Label31.Name = "Label31";
            Label31.Size = new System.Drawing.Size(63, 13);
            Label31.TabIndex = 546;
            Label31.Text = "Projet nom: ";
            // 
            // Label34
            // 
            Label34.AutoSize = true;
            Label34.BackColor = System.Drawing.Color.White;
            Label34.Location = new System.Drawing.Point(439, 81);
            Label34.Name = "Label34";
            Label34.Size = new System.Drawing.Size(52, 13);
            Label34.TabIndex = 547;
            Label34.Text = "TextBox3";
            // 
            // Label35
            // 
            Label35.AutoSize = true;
            Label35.BackColor = System.Drawing.Color.White;
            Label35.Location = new System.Drawing.Point(730, 53);
            Label35.Name = "Label35";
            Label35.Size = new System.Drawing.Size(36, 13);
            Label35.TabIndex = 548;
            Label35.Text = "Date: ";
            // 
            // lblProj
            // 
            lblProj.AutoSize = true;
            lblProj.BackColor = System.Drawing.Color.White;
            lblProj.Location = new System.Drawing.Point(645, 59);
            lblProj.Name = "lblProj";
            lblProj.Size = new System.Drawing.Size(35, 13);
            lblProj.TabIndex = 549;
            lblProj.Text = "lblProj";
            // 
            // Label37
            // 
            Label37.AutoSize = true;
            Label37.BackColor = System.Drawing.Color.White;
            Label37.Location = new System.Drawing.Point(579, 59);
            Label37.Name = "Label37";
            Label37.Size = new System.Drawing.Size(44, 13);
            Label37.TabIndex = 550;
            Label37.Text = "Projet #";
            // 
            // Label32
            // 
            Label32.AutoSize = true;
            Label32.BackColor = System.Drawing.Color.White;
            Label32.Location = new System.Drawing.Point(14, 138);
            Label32.Name = "Label32";
            Label32.Size = new System.Drawing.Size(34, 13);
            Label32.TabIndex = 551;
            Label32.Text = "Projet";
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.BackColor = System.Drawing.Color.White;
            Label24.Location = new System.Drawing.Point(399, 81);
            Label24.Name = "Label24";
            Label24.Size = new System.Drawing.Size(42, 13);
            Label24.TabIndex = 552;
            Label24.Text = "Heure: ";
            // 
            // blDate
            // 
            blDate.AutoSize = true;
            blDate.BackColor = System.Drawing.Color.White;
            blDate.Location = new System.Drawing.Point(326, 81);
            blDate.Name = "blDate";
            blDate.Size = new System.Drawing.Size(61, 13);
            blDate.TabIndex = 553;
            blDate.Text = "8888-88-88";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.BackColor = System.Drawing.Color.White;
            Label17.Location = new System.Drawing.Point(14, 100);
            Label17.Name = "Label17";
            Label17.Size = new System.Drawing.Size(33, 13);
            Label17.TabIndex = 554;
            Label17.Text = "Client";
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.BackColor = System.Drawing.Color.White;
            Label18.Location = new System.Drawing.Point(272, 81);
            Label18.Name = "Label18";
            Label18.Size = new System.Drawing.Size(48, 13);
            Label18.TabIndex = 558;
            Label18.Text = "Date dû:";
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.BackColor = System.Drawing.Color.White;
            Label19.Location = new System.Drawing.Point(272, 118);
            Label19.Name = "Label19";
            Label19.Size = new System.Drawing.Size(92, 13);
            Label19.TabIndex = 559;
            Label19.Text = "Date de fermeture";
            // 
            // lblProjet
            // 
            lblProjet.AutoSize = true;
            lblProjet.BackColor = System.Drawing.Color.White;
            lblProjet.Location = new System.Drawing.Point(81, 138);
            lblProjet.Name = "lblProjet";
            lblProjet.Size = new System.Drawing.Size(44, 13);
            lblProjet.TabIndex = 560;
            lblProjet.Text = "lblProjet";
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.BackColor = System.Drawing.Color.White;
            Label21.Location = new System.Drawing.Point(847, 138);
            Label21.Name = "Label21";
            Label21.Size = new System.Drawing.Size(79, 13);
            Label21.TabIndex = 561;
            Label21.Text = "Facture Total:  ";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = System.Drawing.Color.White;
            lblClient.Location = new System.Drawing.Point(81, 100);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(43, 13);
            lblClient.TabIndex = 569;
            lblClient.Text = "lblClient";
            // 
            // lblGrandTotalKM
            // 
            lblGrandTotalKM.AutoSize = true;
            lblGrandTotalKM.BackColor = System.Drawing.Color.White;
            lblGrandTotalKM.Location = new System.Drawing.Point(537, 138);
            lblGrandTotalKM.Name = "lblGrandTotalKM";
            lblGrandTotalKM.Size = new System.Drawing.Size(86, 13);
            lblGrandTotalKM.TabIndex = 585;
            lblGrandTotalKM.Text = "lblGrandTotalKM";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(-3, 169);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1025, 19);
            label2.TabIndex = 586;
            label2.Text = "Documents obligatoires pour la fermeture du dossier";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(-3, 188);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(1025, 19);
            label3.TabIndex = 587;
            label3.Text = "Liste de matériel";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(-3, 226);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(1025, 19);
            label4.TabIndex = 589;
            label4.Text = "Rapport CSA";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(-3, 207);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(1025, 19);
            label7.TabIndex = 588;
            label7.Text = "Dessin tel que construit";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(-3, 264);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(1025, 19);
            label9.TabIndex = 591;
            label9.Text = "Photo";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(-3, 245);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(1025, 19);
            label10.TabIndex = 590;
            label10.Text = "Étiquette CSA";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(-3, 302);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(1025, 19);
            label11.TabIndex = 593;
            label11.Text = "Documents pour fin des fabrications";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(-3, 283);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(1025, 19);
            label13.TabIndex = 592;
            label13.Text = "Fiche technique";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(12, 321);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(86, 16);
            label14.TabIndex = 594;
            label14.Text = "Description";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(42, 337);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(99, 13);
            label15.TabIndex = 595;
            label15.Text = "Liste matériel atelier";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(790, 321);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(40, 16);
            label16.TabIndex = 596;
            label16.Text = "Date";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(876, 321);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(103, 16);
            label20.TabIndex = 597;
            label20.Text = "Nbre de page";
            label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox3
            // 
            TextBox3.AutoSize = true;
            TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox3.Location = new System.Drawing.Point(790, 339);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new System.Drawing.Size(81, 16);
            TextBox3.TabIndex = 598;
            TextBox3.Text = "8888-88-88";
            TextBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox4
            // 
            TextBox4.AutoSize = true;
            TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox4.Location = new System.Drawing.Point(876, 339);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new System.Drawing.Size(81, 16);
            TextBox4.TabIndex = 599;
            TextBox4.Text = "8888-88-88";
            TextBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.Location = new System.Drawing.Point(409, 339);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(122, 15);
            label22.TabIndex = 600;
            label22.Text = "Dessins mécaniques";
            label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(17, 362);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1121, 421);
            listView1.TabIndex = 601;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dessins";
            columnHeader2.Width = 625;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Révision";
            columnHeader3.Width = 239;
            // 
            // ViewFabricationFermeture
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1150, 795);
            Controls.Add(listView1);
            Controls.Add(label22);
            Controls.Add(TextBox4);
            Controls.Add(TextBox3);
            Controls.Add(label20);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblGrandTotalKM);
            Controls.Add(lblClient);
            Controls.Add(lblDatePrint);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblSoum);
            Controls.Add(Label5);
            Controls.Add(lblContact);
            Controls.Add(Label6);
            Controls.Add(lblTel);
            Controls.Add(Label33);
            Controls.Add(lblFax);
            Controls.Add(Label8);
            Controls.Add(Label12);
            Controls.Add(lblDate);
            Controls.Add(lblProjetNom);
            Controls.Add(lblDateOuverture);
            Controls.Add(Label23);
            Controls.Add(Label31);
            Controls.Add(Label34);
            Controls.Add(Label35);
            Controls.Add(lblProj);
            Controls.Add(Label37);
            Controls.Add(Label32);
            Controls.Add(Label24);
            Controls.Add(blDate);
            Controls.Add(Label17);
            Controls.Add(Label18);
            Controls.Add(Label19);
            Controls.Add(lblProjet);
            Controls.Add(Label21);
            Controls.Add(pictureBox1);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewFabricationFermeture";
            ShowInTaskbar = false;
            Text = "Fabrication - Fermeture";
            Load += new System.EventHandler(InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label ViewTitre;
        internal static Label lblDatePrint;
        internal static Label lblGrandTotal;
        internal static Label lblSoum;
        internal static Label Label5;
        internal static Label lblContact;
        internal static Label Label6;
        internal static Label lblTel;
        internal static Label Label33;
        internal static Label lblFax;
        internal static Label Label8;
        internal static Label Label12;
        internal static Label lblDate;
        internal static Label lblProjetNom;
        internal static Label lblDateOuverture;
        internal static Label Label23;
        internal static Label Label31;
        internal static Label Label34;
        internal static Label Label35;
        internal static Label lblProj;
        internal static Label Label37;
        internal static Label Label32;
        internal static Label Label24;
        internal static Label blDate;
        internal static Label Label17;
        internal static Label Label18;
        internal static Label Label19;
        internal static Label lblProjet;
        internal static Label Label21;
        internal static Label lblClient;
        internal static Label label2;
        internal static Label label3;
        internal static Label label4;
        internal static Label label7;
        internal static Label label9;
        internal static Label label10;
        internal static Label label11;
        internal static Label label13;
        internal static Label label14;
        internal static Label label15;
        internal static Label label16;
        internal static Label label20;
        internal static Label TextBox3;
        internal static Label TextBox4;
        internal static Label label22;
        internal static ListView listView1;
        internal static ColumnHeader columnHeader1;
        internal static ColumnHeader columnHeader2;
        internal static ColumnHeader columnHeader3;
        internal static Label lblGrandTotalKM;

        public ViewFabricationFermeture()
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