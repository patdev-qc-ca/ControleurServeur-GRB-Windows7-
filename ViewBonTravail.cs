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
    public class ViewBonTravail : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBonTravail));
            ViewTitre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Label9 = new System.Windows.Forms.Label();
            lblNoCommandeClient = new System.Windows.Forms.Label();
            Label10 = new System.Windows.Forms.Label();
            lblDateCommande = new System.Windows.Forms.Label();
            Label13 = new System.Windows.Forms.Label();
            lblTitre = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            Label7 = new System.Windows.Forms.Label();
            lblFacture = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            lblTelephone = new System.Windows.Forms.Label();
            Label33 = new System.Windows.Forms.Label();
            lblFax = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            lblRepresentantGRB = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            lblBonTravail = new System.Windows.Forms.Label();
            lblDateHeure = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label22 = new System.Windows.Forms.Label();
            Label23 = new System.Windows.Forms.Label();
            Label31 = new System.Windows.Forms.Label();
            Label34 = new System.Windows.Forms.Label();
            Label35 = new System.Windows.Forms.Label();
            Label36 = new System.Windows.Forms.Label();
            Label37 = new System.Windows.Forms.Label();
            Label32 = new System.Windows.Forms.Label();
            Label24 = new System.Windows.Forms.Label();
            Label42 = new System.Windows.Forms.Label();
            Label17 = new System.Windows.Forms.Label();
            CheckBox1 = new System.Windows.Forms.CheckBox();
            CheckBox2 = new System.Windows.Forms.CheckBox();
            Label18 = new System.Windows.Forms.Label();
            Label19 = new System.Windows.Forms.Label();
            Label20 = new System.Windows.Forms.Label();
            Label21 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox8 = new System.Windows.Forms.TextBox();
            textBox9 = new System.Windows.Forms.TextBox();
            textBox10 = new System.Windows.Forms.TextBox();
            textBox11 = new System.Windows.Forms.TextBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            textBox12 = new System.Windows.Forms.TextBox();
            checkBox4 = new System.Windows.Forms.CheckBox();
            checkBox5 = new System.Windows.Forms.CheckBox();
            textBox13 = new System.Windows.Forms.TextBox();
            textBox14 = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            checkBox6 = new System.Windows.Forms.CheckBox();
            checkBox7 = new System.Windows.Forms.CheckBox();
            listView1 = new System.Windows.Forms.ListView();
            Quantité = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            noPiece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // ViewTitre
            // 
            ViewTitre.AutoSize = true;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(11, 9);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(183, 36);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Bon de travail";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(646, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(161, 64);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = System.Drawing.Color.White;
            Label9.Location = new System.Drawing.Point(10, 946);
            Label9.Name = "Label9";
            Label9.Size = new System.Drawing.Size(172, 13);
            Label9.TabIndex = 562;
            Label9.Text = "Personel autorisé par la compagnie";
            // 
            // lblNoCommandeClient
            // 
            lblNoCommandeClient.AutoSize = true;
            lblNoCommandeClient.BackColor = System.Drawing.Color.White;
            lblNoCommandeClient.Location = new System.Drawing.Point(131, 192);
            lblNoCommandeClient.Name = "lblNoCommandeClient";
            lblNoCommandeClient.Size = new System.Drawing.Size(110, 13);
            lblNoCommandeClient.TabIndex = 563;
            lblNoCommandeClient.Text = "lblNoCommandeClient";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = System.Drawing.Color.White;
            Label10.Location = new System.Drawing.Point(12, 928);
            Label10.Name = "Label10";
            Label10.Size = new System.Drawing.Size(320, 13);
            Label10.TabIndex = 564;
            Label10.Text = "Travaux terminés à votre satisfaction ou prochaine visite acceptée";
            // 
            // lblDateCommande
            // 
            lblDateCommande.BackColor = System.Drawing.Color.White;
            lblDateCommande.Location = new System.Drawing.Point(131, 215);
            lblDateCommande.Name = "lblDateCommande";
            lblDateCommande.Size = new System.Drawing.Size(101, 19);
            lblDateCommande.TabIndex = 565;
            lblDateCommande.Text = "lblDateCommande";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.BackColor = System.Drawing.Color.White;
            Label13.Location = new System.Drawing.Point(14, 424);
            Label13.Name = "Label13";
            Label13.Size = new System.Drawing.Size(110, 13);
            Label13.TabIndex = 566;
            Label13.Text = "Retour matériel GRB?";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.BackColor = System.Drawing.Color.White;
            lblTitre.Location = new System.Drawing.Point(14, 65);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new System.Drawing.Size(38, 13);
            lblTitre.TabIndex = 520;
            lblTitre.Text = "lblTitre";
            // 
            // lblClient
            // 
            lblClient.BackColor = System.Drawing.Color.White;
            lblClient.Location = new System.Drawing.Point(131, 94);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(167, 19);
            lblClient.TabIndex = 522;
            lblClient.Text = "99999";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = System.Drawing.Color.White;
            Label7.Location = new System.Drawing.Point(422, 149);
            Label7.Name = "Label7";
            Label7.Size = new System.Drawing.Size(34, 13);
            Label7.TabIndex = 523;
            Label7.Text = "B.T.#";
            // 
            // lblFacture
            // 
            lblFacture.BackColor = System.Drawing.Color.White;
            lblFacture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblFacture.Location = new System.Drawing.Point(479, 93);
            lblFacture.MinimumSize = new System.Drawing.Size(60, 19);
            lblFacture.Name = "lblFacture";
            lblFacture.Size = new System.Drawing.Size(214, 49);
            lblFacture.TabIndex = 524;
            lblFacture.Text = "lblFacture";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(14, 111);
            Label5.MinimumSize = new System.Drawing.Size(60, 19);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(60, 19);
            Label5.TabIndex = 525;
            Label5.Text = "Contact";
            // 
            // lblContact
            // 
            lblContact.BackColor = System.Drawing.Color.White;
            lblContact.Location = new System.Drawing.Point(131, 111);
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
            Label6.Location = new System.Drawing.Point(13, 130);
            Label6.MinimumSize = new System.Drawing.Size(60, 19);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(60, 19);
            Label6.TabIndex = 527;
            Label6.Text = "Téléphone";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.BackColor = System.Drawing.Color.White;
            lblTelephone.Location = new System.Drawing.Point(131, 130);
            lblTelephone.MinimumSize = new System.Drawing.Size(60, 19);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(68, 19);
            lblTelephone.TabIndex = 528;
            lblTelephone.Text = "lblTelephone";
            // 
            // Label33
            // 
            Label33.AutoSize = true;
            Label33.BackColor = System.Drawing.Color.White;
            Label33.Location = new System.Drawing.Point(205, 130);
            Label33.Name = "Label33";
            Label33.Size = new System.Drawing.Size(27, 13);
            Label33.TabIndex = 529;
            Label33.Text = "Fax:";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.BackColor = System.Drawing.Color.White;
            lblFax.Location = new System.Drawing.Point(238, 130);
            lblFax.MinimumSize = new System.Drawing.Size(60, 19);
            lblFax.Name = "lblFax";
            lblFax.Size = new System.Drawing.Size(60, 19);
            lblFax.TabIndex = 530;
            lblFax.Text = "lblFax";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = System.Drawing.Color.White;
            Label8.Location = new System.Drawing.Point(13, 149);
            Label8.MinimumSize = new System.Drawing.Size(60, 19);
            Label8.Name = "Label8";
            Label8.Size = new System.Drawing.Size(112, 19);
            Label8.TabIndex = 531;
            Label8.Text = "Représentant de GRB";
            // 
            // lblRepresentantGRB
            // 
            lblRepresentantGRB.AutoSize = true;
            lblRepresentantGRB.BackColor = System.Drawing.Color.White;
            lblRepresentantGRB.Location = new System.Drawing.Point(131, 149);
            lblRepresentantGRB.MinimumSize = new System.Drawing.Size(60, 19);
            lblRepresentantGRB.Name = "lblRepresentantGRB";
            lblRepresentantGRB.Size = new System.Drawing.Size(104, 19);
            lblRepresentantGRB.TabIndex = 532;
            lblRepresentantGRB.Text = "lblRepresentantGRB";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = System.Drawing.Color.White;
            Label12.Location = new System.Drawing.Point(14, 93);
            Label12.MinimumSize = new System.Drawing.Size(60, 19);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(60, 19);
            Label12.TabIndex = 533;
            Label12.Text = "Client";
            // 
            // lblBonTravail
            // 
            lblBonTravail.BackColor = System.Drawing.Color.White;
            lblBonTravail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblBonTravail.Location = new System.Drawing.Point(479, 145);
            lblBonTravail.Name = "lblBonTravail";
            lblBonTravail.Size = new System.Drawing.Size(214, 20);
            lblBonTravail.TabIndex = 534;
            lblBonTravail.Text = "lblBonTravail";
            lblBonTravail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateHeure
            // 
            lblDateHeure.AutoSize = true;
            lblDateHeure.BackColor = System.Drawing.Color.White;
            lblDateHeure.Location = new System.Drawing.Point(311, 0);
            lblDateHeure.Name = "lblDateHeure";
            lblDateHeure.Size = new System.Drawing.Size(69, 13);
            lblDateHeure.TabIndex = 536;
            lblDateHeure.Text = "lblDateHeure";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(496, 961);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(52, 13);
            Label2.TabIndex = 540;
            Label2.Text = "Signature";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(14, 828);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(103, 13);
            Label3.TabIndex = 541;
            Label3.Text = "Remarque ou autres";
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.BackColor = System.Drawing.Color.White;
            Label22.Location = new System.Drawing.Point(447, 415);
            Label22.Name = "Label22";
            Label22.Size = new System.Drawing.Size(88, 13);
            Label22.TabIndex = 542;
            Label22.Text = "Travaux terminés";
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.BackColor = System.Drawing.Color.White;
            Label23.Location = new System.Drawing.Point(445, 359);
            Label23.Name = "Label23";
            Label23.Size = new System.Drawing.Size(103, 13);
            Label23.TabIndex = 543;
            Label23.Text = "Frais de subsistance";
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.BackColor = System.Drawing.Color.White;
            Label31.Location = new System.Drawing.Point(695, 392);
            Label31.Name = "Label31";
            Label31.Size = new System.Drawing.Size(27, 13);
            Label31.TabIndex = 546;
            Label31.Text = "Kms";
            // 
            // Label34
            // 
            Label34.AutoSize = true;
            Label34.BackColor = System.Drawing.Color.White;
            Label34.Location = new System.Drawing.Point(622, 374);
            Label34.Name = "Label34";
            Label34.Size = new System.Drawing.Size(138, 13);
            Label34.TabIndex = 547;
            Label34.Text = "Nombre de KM Aller/Retour";
            // 
            // Label35
            // 
            Label35.AutoSize = true;
            Label35.BackColor = System.Drawing.Color.White;
            Label35.Location = new System.Drawing.Point(547, 374);
            Label35.Name = "Label35";
            Label35.Size = new System.Drawing.Size(25, 13);
            Label35.TabIndex = 548;
            Label35.Text = "Soir";
            // 
            // Label36
            // 
            Label36.AutoSize = true;
            Label36.BackColor = System.Drawing.Color.White;
            Label36.Location = new System.Drawing.Point(498, 374);
            Label36.Name = "Label36";
            Label36.Size = new System.Drawing.Size(26, 13);
            Label36.TabIndex = 549;
            Label36.Text = "Midi";
            // 
            // Label37
            // 
            Label37.AutoSize = true;
            Label37.BackColor = System.Drawing.Color.White;
            Label37.Location = new System.Drawing.Point(445, 374);
            Label37.Name = "Label37";
            Label37.Size = new System.Drawing.Size(33, 13);
            Label37.TabIndex = 550;
            Label37.Text = "Matin";
            // 
            // Label32
            // 
            Label32.AutoSize = true;
            Label32.BackColor = System.Drawing.Color.White;
            Label32.Location = new System.Drawing.Point(556, 289);
            Label32.Name = "Label32";
            Label32.Size = new System.Drawing.Size(90, 13);
            Label32.TabIndex = 551;
            Label32.Text = "Retour au bureau";
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.BackColor = System.Drawing.Color.White;
            Label24.Location = new System.Drawing.Point(445, 289);
            Label24.Name = "Label24";
            Label24.Size = new System.Drawing.Size(90, 13);
            Label24.TabIndex = 552;
            Label24.Text = "Départ du bureau";
            // 
            // Label42
            // 
            Label42.AutoSize = true;
            Label42.BackColor = System.Drawing.Color.White;
            Label42.Location = new System.Drawing.Point(55, 286);
            Label42.Name = "Label42";
            Label42.Size = new System.Drawing.Size(118, 13);
            Label42.TabIndex = 553;
            Label42.Text = "Description des travaux";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.BackColor = System.Drawing.Color.White;
            Label17.Location = new System.Drawing.Point(14, 237);
            Label17.Name = "Label17";
            Label17.Size = new System.Drawing.Size(88, 13);
            Label17.TabIndex = 554;
            Label17.Text = "Date des travaux";
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.BackColor = System.Drawing.Color.White;
            CheckBox1.Location = new System.Drawing.Point(130, 423);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new System.Drawing.Size(40, 17);
            CheckBox1.TabIndex = 555;
            CheckBox1.Text = "oui";
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.BackColor = System.Drawing.Color.White;
            CheckBox2.Location = new System.Drawing.Point(170, 423);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new System.Drawing.Size(44, 17);
            CheckBox2.TabIndex = 556;
            CheckBox2.Text = "non";
            CheckBox2.UseVisualStyleBackColor = true;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.BackColor = System.Drawing.Color.White;
            Label18.Location = new System.Drawing.Point(360, 192);
            Label18.Name = "Label18";
            Label18.Size = new System.Drawing.Size(85, 13);
            Label18.TabIndex = 558;
            Label18.Text = "Lieu des travaux";
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.BackColor = System.Drawing.Color.White;
            Label19.Location = new System.Drawing.Point(14, 215);
            Label19.Name = "Label19";
            Label19.Size = new System.Drawing.Size(100, 13);
            Label19.TabIndex = 559;
            Label19.Text = "Date de commande";
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.BackColor = System.Drawing.Color.White;
            Label20.Location = new System.Drawing.Point(14, 192);
            Label20.Name = "Label20";
            Label20.Size = new System.Drawing.Size(112, 13);
            Label20.TabIndex = 560;
            Label20.Text = "# commande du client";
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.BackColor = System.Drawing.Color.White;
            Label21.Location = new System.Drawing.Point(422, 93);
            Label21.Name = "Label21";
            Label21.Size = new System.Drawing.Size(52, 13);
            Label21.TabIndex = 561;
            Label21.Text = "Facture à";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(363, 208);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(330, 65);
            textBox1.TabIndex = 567;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(17, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 20);
            textBox2.TabIndex = 568;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(134, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 20);
            textBox3.TabIndex = 570;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(131, 237);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 13);
            label4.TabIndex = 569;
            label4.Text = "Heure des travaux";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(12, 302);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(413, 119);
            textBox4.TabIndex = 571;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(448, 305);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(100, 20);
            textBox5.TabIndex = 572;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(559, 305);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(100, 20);
            textBox6.TabIndex = 573;
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(448, 390);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(45, 20);
            textBox7.TabIndex = 574;
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(499, 390);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(45, 20);
            textBox8.TabIndex = 575;
            // 
            // textBox9
            // 
            textBox9.Location = new System.Drawing.Point(550, 390);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(45, 20);
            textBox9.TabIndex = 576;
            // 
            // textBox10
            // 
            textBox10.Location = new System.Drawing.Point(625, 390);
            textBox10.Name = "textBox10";
            textBox10.Size = new System.Drawing.Size(64, 20);
            textBox10.TabIndex = 577;
            // 
            // textBox11
            // 
            textBox11.Location = new System.Drawing.Point(554, 335);
            textBox11.Name = "textBox11";
            textBox11.Size = new System.Drawing.Size(224, 20);
            textBox11.TabIndex = 578;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = System.Drawing.Color.White;
            checkBox3.Location = new System.Drawing.Point(12, 455);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(148, 17);
            checkBox3.TabIndex = 579;
            checkBox3.Text = "Apporter matériel du client";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.Location = new System.Drawing.Point(17, 844);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new System.Drawing.Size(773, 63);
            textBox12.TabIndex = 580;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = System.Drawing.Color.White;
            checkBox4.Location = new System.Drawing.Point(333, 927);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(40, 17);
            checkBox4.TabIndex = 581;
            checkBox4.Text = "oui";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = System.Drawing.Color.White;
            checkBox5.Location = new System.Drawing.Point(374, 927);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new System.Drawing.Size(44, 17);
            checkBox5.TabIndex = 582;
            checkBox5.Text = "non";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            textBox13.Location = new System.Drawing.Point(12, 962);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new System.Drawing.Size(435, 26);
            textBox13.TabIndex = 583;
            // 
            // textBox14
            // 
            textBox14.Location = new System.Drawing.Point(554, 936);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new System.Drawing.Size(236, 52);
            textBox14.TabIndex = 584;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(445, 337);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(96, 13);
            label11.TabIndex = 585;
            label11.Text = "Nom du technicien";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = System.Drawing.Color.White;
            checkBox6.Location = new System.Drawing.Point(537, 414);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new System.Drawing.Size(40, 17);
            checkBox6.TabIndex = 586;
            checkBox6.Text = "oui";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackColor = System.Drawing.Color.White;
            checkBox7.Location = new System.Drawing.Point(577, 414);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new System.Drawing.Size(44, 17);
            checkBox7.TabIndex = 587;
            checkBox7.Text = "non";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Quantité,
            Description,
            noPiece});
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(13, 474);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(777, 332);
            listView1.TabIndex = 588;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // Quantité
            // 
            Quantité.Text = "Quantité";
            Quantité.Width = 130;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 356;
            // 
            // noPiece
            // 
            noPiece.Text = "Piece#";
            noPiece.Width = 207;
            // 
            // ViewBonTravail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(808, 1000);
            Controls.Add(listView1);
            Controls.Add(checkBox6);
            Controls.Add(checkBox7);
            Controls.Add(label11);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(checkBox4);
            Controls.Add(checkBox5);
            Controls.Add(textBox12);
            Controls.Add(checkBox3);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Label9);
            Controls.Add(lblNoCommandeClient);
            Controls.Add(Label10);
            Controls.Add(lblDateCommande);
            Controls.Add(Label13);
            Controls.Add(lblTitre);
            Controls.Add(lblClient);
            Controls.Add(Label7);
            Controls.Add(lblFacture);
            Controls.Add(Label5);
            Controls.Add(lblContact);
            Controls.Add(Label6);
            Controls.Add(lblTelephone);
            Controls.Add(Label33);
            Controls.Add(lblFax);
            Controls.Add(Label8);
            Controls.Add(lblRepresentantGRB);
            Controls.Add(Label12);
            Controls.Add(lblBonTravail);
            Controls.Add(lblDateHeure);
            Controls.Add(Label2);
            Controls.Add(Label3);
            Controls.Add(Label22);
            Controls.Add(Label23);
            Controls.Add(Label31);
            Controls.Add(Label34);
            Controls.Add(Label35);
            Controls.Add(Label36);
            Controls.Add(Label37);
            Controls.Add(Label32);
            Controls.Add(Label24);
            Controls.Add(Label42);
            Controls.Add(Label17);
            Controls.Add(CheckBox1);
            Controls.Add(CheckBox2);
            Controls.Add(Label18);
            Controls.Add(Label19);
            Controls.Add(Label20);
            Controls.Add(Label21);
            Controls.Add(pictureBox1);
            Controls.Add(ViewTitre);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewBonTravail";
            Text = Name;
            Load += new System.EventHandler(ViewBonTravail_Load);
            Resize += new System.EventHandler(ViewBonTravail_Resize);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label ViewTitre;
        internal static Label Label9;
        internal static Label lblNoCommandeClient;
        internal static Label Label10;
        internal static Label lblDateCommande;
        internal static Label Label13;
        internal static Label lblTitre;
        internal static Label lblClient;
        internal static Label Label7;
        internal static Label lblFacture;
        internal static Label Label5;
        internal static Label lblContact;
        internal static Label Label6;
        internal static Label lblTelephone;
        internal static Label Label33;
        internal static Label lblFax;
        internal static Label Label8;
        internal static Label lblRepresentantGRB;
        internal static Label Label12;
        internal static Label lblBonTravail;
        internal static Label lblDateHeure;
        internal static Label Label2;
        internal static Label Label3;
        internal static Label Label22;
        internal static Label Label23;
        internal static Label Label31;
        internal static Label Label34;
        internal static Label Label35;
        internal static Label Label36;
        internal static Label Label37;
        internal static Label Label32;
        internal static Label Label24;
        internal static Label Label42;
        internal static Label Label17;
        internal static CheckBox CheckBox1;
        internal static CheckBox CheckBox2;
        internal static Label Label18;
        internal static Label Label19;
        internal static Label Label20;
        internal static Label Label21;
        internal static TextBox textBox1;
        internal static TextBox textBox2;
        internal static TextBox textBox3;
        internal static Label label4;
        internal static TextBox textBox4;
        internal static TextBox textBox5;
        internal static TextBox textBox6;
        internal static TextBox textBox7;
        internal static TextBox textBox8;
        internal static TextBox textBox9;
        internal static TextBox textBox10;
        internal static TextBox textBox11;
        internal static CheckBox checkBox3;
        internal static TextBox textBox12;
        internal static CheckBox checkBox4;
        internal static CheckBox checkBox5;
        internal static TextBox textBox13;
        internal static TextBox textBox14;
        internal static Label label11;
        internal static CheckBox checkBox6;
        internal static CheckBox checkBox7;
        internal static ListView listView1;
        internal static ColumnHeader Quantité;
        internal static ColumnHeader Description;
        internal static ColumnHeader noPiece;

        public ViewBonTravail()
        {
            InitializeComponent();
        }

        private void ViewBonTravail_Load(object sender, EventArgs e)
        {
            Top = 0;
            FormBorderStyle = FormBorderStyle.None;
            Left = -2;
            lblDateHeure.Text = DateTime.Now.ToString();
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
        private void ViewBonTravail_Resize(object sender, EventArgs e)
        {
            textBox5.Text = $"Dimentions {Width};{Height}";
        }
    }
}