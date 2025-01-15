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
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public class ViewCommande : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCommande));
            lblTitreCommande = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblCommandePar = new System.Windows.Forms.Label();
            lblTransport = new System.Windows.Forms.Label();
            lblTitre = new System.Windows.Forms.Label();
            lblFournisseur = new System.Windows.Forms.Label();
            lblTitreContact = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            lblTitreTel = new System.Windows.Forms.Label();
            lblTelephone = new System.Windows.Forms.Label();
            lblTitreFax = new System.Windows.Forms.Label();
            lblFax = new System.Windows.Forms.Label();
            lbltitredatereq = new System.Windows.Forms.Label();
            lblDateRequise = new System.Windows.Forms.Label();
            lblTitreFournisseur = new System.Windows.Forms.Label();
            lblPiedPage = new System.Windows.Forms.Label();
            lbltitrecompar = new System.Windows.Forms.Label();
            lblTitreBC = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lbltitredate = new System.Windows.Forms.Label();
            lblNoBC = new System.Windows.Forms.Label();
            lblCommentaire = new System.Windows.Forms.TextBox();
            lblTitreTransport = new System.Windows.Forms.Label();
            lblTotalFin = new System.Windows.Forms.Label();
            lbltypeprix = new System.Windows.Forms.Label();
            lblTitreNoSoum = new System.Windows.Forms.Label();
            lblNoSoum = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            lblTitreQte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitrePiece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreManufact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitrePrix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreEscompte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblTitreTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblCSA = new System.Windows.Forms.Label();
            lbltitrecommentaire = new System.Windows.Forms.Label();
            lblCopieCredit = new System.Windows.Forms.Label();
            lblAdresse = new System.Windows.Forms.Label();
            lbltitretotalfin = new System.Windows.Forms.Label();
            lblPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // lblTitreCommande
            // 
            lblTitreCommande.AutoSize = true;
            lblTitreCommande.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreCommande.Location = new System.Drawing.Point(11, 9);
            lblTitreCommande.Name = "lblTitreCommande";
            lblTitreCommande.Size = new System.Drawing.Size(241, 36);
            lblTitreCommande.TabIndex = 418;
            lblTitreCommande.Tag = "";
            lblTitreCommande.Text = "lblTitreCommande";
            lblTitreCommande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(863, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblCommandePar
            // 
            lblCommandePar.AutoSize = true;
            lblCommandePar.BackColor = System.Drawing.Color.White;
            lblCommandePar.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCommandePar.Location = new System.Drawing.Point(730, 121);
            lblCommandePar.Name = "lblCommandePar";
            lblCommandePar.Size = new System.Drawing.Size(96, 14);
            lblCommandePar.TabIndex = 563;
            lblCommandePar.Text = "lblCommandePar";
            lblCommandePar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTransport
            // 
            lblTransport.BackColor = System.Drawing.Color.White;
            lblTransport.Location = new System.Drawing.Point(440, 139);
            lblTransport.Name = "lblTransport";
            lblTransport.Size = new System.Drawing.Size(101, 19);
            lblTransport.TabIndex = 565;
            lblTransport.Text = "lblTransport";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.BackColor = System.Drawing.Color.White;
            lblTitre.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitre.Location = new System.Drawing.Point(16, 45);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new System.Drawing.Size(62, 17);
            lblTitre.TabIndex = 520;
            lblTitre.Text = "lblTitre";
            lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFournisseur
            // 
            lblFournisseur.BackColor = System.Drawing.Color.White;
            lblFournisseur.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFournisseur.Location = new System.Drawing.Point(91, 78);
            lblFournisseur.Name = "lblFournisseur";
            lblFournisseur.Size = new System.Drawing.Size(144, 14);
            lblFournisseur.TabIndex = 522;
            lblFournisseur.Text = "lblFournisseur";
            lblFournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitreContact
            // 
            lblTitreContact.AutoSize = true;
            lblTitreContact.BackColor = System.Drawing.Color.White;
            lblTitreContact.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreContact.Location = new System.Drawing.Point(42, 97);
            lblTitreContact.Name = "lblTitreContact";
            lblTitreContact.Size = new System.Drawing.Size(50, 14);
            lblTitreContact.TabIndex = 525;
            lblTitreContact.Text = "Contact";
            lblTitreContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContact
            // 
            lblContact.BackColor = System.Drawing.Color.White;
            lblContact.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblContact.Location = new System.Drawing.Point(91, 95);
            lblContact.MinimumSize = new System.Drawing.Size(60, 19);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(154, 19);
            lblContact.TabIndex = 526;
            lblContact.Text = "lblContact";
            lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitreTel
            // 
            lblTitreTel.AutoSize = true;
            lblTitreTel.BackColor = System.Drawing.Color.White;
            lblTitreTel.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreTel.Location = new System.Drawing.Point(354, 99);
            lblTitreTel.Name = "lblTitreTel";
            lblTitreTel.Size = new System.Drawing.Size(66, 14);
            lblTitreTel.TabIndex = 527;
            lblTitreTel.Text = "Téléphone";
            lblTitreTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.BackColor = System.Drawing.Color.White;
            lblTelephone.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTelephone.Location = new System.Drawing.Point(440, 97);
            lblTelephone.MinimumSize = new System.Drawing.Size(60, 19);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(79, 19);
            lblTelephone.TabIndex = 528;
            lblTelephone.Text = "lblTelephone";
            lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitreFax
            // 
            lblTitreFax.AutoSize = true;
            lblTitreFax.BackColor = System.Drawing.Color.White;
            lblTitreFax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreFax.Location = new System.Drawing.Point(354, 118);
            lblTitreFax.Name = "lblTitreFax";
            lblTitreFax.Size = new System.Drawing.Size(29, 14);
            lblTitreFax.TabIndex = 529;
            lblTitreFax.Text = "Fax:";
            lblTitreFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.BackColor = System.Drawing.Color.White;
            lblFax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFax.Location = new System.Drawing.Point(440, 118);
            lblFax.MinimumSize = new System.Drawing.Size(60, 19);
            lblFax.Name = "lblFax";
            lblFax.Size = new System.Drawing.Size(60, 19);
            lblFax.TabIndex = 530;
            lblFax.Text = "lblFax";
            lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltitredatereq
            // 
            lbltitredatereq.AutoSize = true;
            lbltitredatereq.BackColor = System.Drawing.Color.White;
            lbltitredatereq.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbltitredatereq.Location = new System.Drawing.Point(16, 121);
            lbltitredatereq.Name = "lbltitredatereq";
            lbltitredatereq.Size = new System.Drawing.Size(76, 14);
            lbltitredatereq.TabIndex = 531;
            lbltitredatereq.Text = "Date requise";
            lbltitredatereq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateRequise
            // 
            lblDateRequise.AutoSize = true;
            lblDateRequise.BackColor = System.Drawing.Color.White;
            lblDateRequise.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateRequise.Location = new System.Drawing.Point(135, 126);
            lblDateRequise.MinimumSize = new System.Drawing.Size(60, 19);
            lblDateRequise.Name = "lblDateRequise";
            lblDateRequise.Size = new System.Drawing.Size(110, 19);
            lblDateRequise.TabIndex = 532;
            lblDateRequise.Text = "lblDateRequise";
            lblDateRequise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitreFournisseur
            // 
            lblTitreFournisseur.AutoSize = true;
            lblTitreFournisseur.BackColor = System.Drawing.Color.White;
            lblTitreFournisseur.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreFournisseur.Location = new System.Drawing.Point(15, 78);
            lblTitreFournisseur.Name = "lblTitreFournisseur";
            lblTitreFournisseur.Size = new System.Drawing.Size(71, 14);
            lblTitreFournisseur.TabIndex = 533;
            lblTitreFournisseur.Text = "Fournisseur";
            lblTitreFournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPiedPage
            // 
            lblPiedPage.AutoSize = true;
            lblPiedPage.BackColor = System.Drawing.Color.White;
            lblPiedPage.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPiedPage.Location = new System.Drawing.Point(85, 602);
            lblPiedPage.Name = "lblPiedPage";
            lblPiedPage.Size = new System.Drawing.Size(715, 27);
            lblPiedPage.TabIndex = 536;
            lblPiedPage.Text = "CONFIRMEZ LA COMMANDE ET LA DATE DE LIVRAISON";
            lblPiedPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltitrecompar
            // 
            lbltitrecompar.AutoSize = true;
            lbltitrecompar.BackColor = System.Drawing.Color.White;
            lbltitrecompar.Location = new System.Drawing.Point(674, 120);
            lbltitrecompar.Name = "lbltitrecompar";
            lbltitrecompar.Size = new System.Drawing.Size(50, 13);
            lbltitrecompar.TabIndex = 543;
            lbltitrecompar.Text = "Acheteur";
            // 
            // lblTitreBC
            // 
            lblTitreBC.AutoSize = true;
            lblTitreBC.BackColor = System.Drawing.Color.White;
            lblTitreBC.Location = new System.Drawing.Point(676, 78);
            lblTitreBC.Name = "lblTitreBC";
            lblTitreBC.Size = new System.Drawing.Size(34, 13);
            lblTitreBC.TabIndex = 548;
            lblTitreBC.Text = "#B.C.";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Location = new System.Drawing.Point(730, 98);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(40, 13);
            lblDate.TabIndex = 549;
            lblDate.Text = "lblDate";
            // 
            // lbltitredate
            // 
            lbltitredate.AutoSize = true;
            lbltitredate.BackColor = System.Drawing.Color.White;
            lbltitredate.Location = new System.Drawing.Point(676, 99);
            lbltitredate.Name = "lbltitredate";
            lbltitredate.Size = new System.Drawing.Size(30, 13);
            lbltitredate.TabIndex = 550;
            lbltitredate.Text = "Date";
            // 
            // lblNoBC
            // 
            lblNoBC.AutoSize = true;
            lblNoBC.BackColor = System.Drawing.Color.White;
            lblNoBC.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoBC.Location = new System.Drawing.Point(730, 78);
            lblNoBC.Name = "lblNoBC";
            lblNoBC.Size = new System.Drawing.Size(50, 14);
            lblNoBC.TabIndex = 560;
            lblNoBC.Text = "lblNoBC";
            lblNoBC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommentaire
            // 
            lblCommentaire.Location = new System.Drawing.Point(66, 677);
            lblCommentaire.Multiline = true;
            lblCommentaire.Name = "lblCommentaire";
            lblCommentaire.Size = new System.Drawing.Size(675, 52);
            lblCommentaire.TabIndex = 583;
            lblCommentaire.Text = "lblCommentaire";
            // 
            // lblTitreTransport
            // 
            lblTitreTransport.AutoSize = true;
            lblTitreTransport.BackColor = System.Drawing.Color.White;
            lblTitreTransport.Location = new System.Drawing.Point(354, 139);
            lblTitreTransport.Name = "lblTitreTransport";
            lblTitreTransport.Size = new System.Drawing.Size(52, 13);
            lblTitreTransport.TabIndex = 585;
            lblTitreTransport.Text = "Transport";
            // 
            // lblTotalFin
            // 
            lblTotalFin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalFin.Location = new System.Drawing.Point(837, 690);
            lblTotalFin.Name = "lblTotalFin";
            lblTotalFin.Padding = new System.Windows.Forms.Padding(3);
            lblTotalFin.Size = new System.Drawing.Size(114, 29);
            lblTotalFin.TabIndex = 589;
            lblTotalFin.Text = "lblTotalFin";
            lblTotalFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltypeprix
            // 
            lbltypeprix.AutoSize = true;
            lbltypeprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbltypeprix.Location = new System.Drawing.Point(954, 696);
            lbltypeprix.Name = "lbltypeprix";
            lbltypeprix.Size = new System.Drawing.Size(79, 16);
            lbltypeprix.TabIndex = 591;
            lbltypeprix.Text = "lbltypeprix";
            // 
            // lblTitreNoSoum
            // 
            lblTitreNoSoum.AutoSize = true;
            lblTitreNoSoum.Location = new System.Drawing.Point(354, 79);
            lblTitreNoSoum.Name = "lblTitreNoSoum";
            lblTitreNoSoum.Size = new System.Drawing.Size(79, 13);
            lblTitreNoSoum.TabIndex = 592;
            lblTitreNoSoum.Text = "lblTitreNoSoum";
            // 
            // lblNoSoum
            // 
            lblNoSoum.AutoSize = true;
            lblNoSoum.Location = new System.Drawing.Point(440, 79);
            lblNoSoum.Name = "lblNoSoum";
            lblNoSoum.Size = new System.Drawing.Size(58, 13);
            lblNoSoum.TabIndex = 593;
            lblNoSoum.Text = "lblNoSoum";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lblTitreQte,
            lblTitrePiece,
            lblTitreDescription,
            lblTitreManufact,
            lblTitrePrix,
            lblTitreEscompte,
            lblTitreTotal});
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(17, 161);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1105, 420);
            listView1.TabIndex = 594;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // lblTitreQte
            // 
            lblTitreQte.Text = "Quantité";
            // 
            // lblTitrePiece
            // 
            lblTitrePiece.Text = "#Piece";
            // 
            // lblTitreDescription
            // 
            lblTitreDescription.Text = "Description";
            // 
            // lblTitreManufact
            // 
            lblTitreManufact.Text = "Manufacturier";
            // 
            // lblTitrePrix
            // 
            lblTitrePrix.Text = "Prix / unité";
            lblTitrePrix.Width = 67;
            // 
            // lblTitreEscompte
            // 
            lblTitreEscompte.Text = "Escompte";
            // 
            // lblTitreTotal
            // 
            lblTitreTotal.Text = "Total";
            lblTitreTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCSA
            // 
            lblCSA.AutoSize = true;
            lblCSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCSA.Location = new System.Drawing.Point(70, 635);
            lblCSA.Name = "lblCSA";
            lblCSA.Size = new System.Drawing.Size(834, 18);
            lblCSA.TabIndex = 595;
            lblCSA.Text = "Tous les items mentionnés ci-haut doivent avoir la marque CSA. Dans le cas contra" +
    "ire, veuillez nous prévenir.";
            // 
            // lbltitrecommentaire
            // 
            lbltitrecommentaire.AutoSize = true;
            lbltitrecommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbltitrecommentaire.Location = new System.Drawing.Point(64, 657);
            lbltitrecommentaire.Name = "lbltitrecommentaire";
            lbltitrecommentaire.Size = new System.Drawing.Size(114, 16);
            lbltitrecommentaire.TabIndex = 596;
            lbltitrecommentaire.Text = "Commentaires :";
            // 
            // lblCopieCredit
            // 
            lblCopieCredit.AutoSize = true;
            lblCopieCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCopieCredit.Location = new System.Drawing.Point(344, 771);
            lblCopieCredit.Name = "lblCopieCredit";
            lblCopieCredit.Size = new System.Drawing.Size(216, 16);
            lblCopieCredit.TabIndex = 598;
            lblCopieCredit.Text = "COPIE / CRÉDIT À RECEVOIR";
            // 
            // lblAdresse
            // 
            lblAdresse.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAdresse.Location = new System.Drawing.Point(0, 775);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new System.Drawing.Size(1049, 20);
            lblAdresse.TabIndex = 599;
            lblAdresse.Text = "149, rue Pierre Paradis, St-Alphonse-de-Granby, QC, J0E 2A0, Tel : (450) 372-0021" +
    ", Fax : (450) 372-3860";
            lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltitretotalfin
            // 
            lbltitretotalfin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lbltitretotalfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbltitretotalfin.Location = new System.Drawing.Point(766, 690);
            lbltitretotalfin.Name = "lbltitretotalfin";
            lbltitretotalfin.Padding = new System.Windows.Forms.Padding(3);
            lbltitretotalfin.Size = new System.Drawing.Size(65, 29);
            lbltitretotalfin.TabIndex = 600;
            lbltitretotalfin.Text = "TOTAL";
            lbltitretotalfin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new System.Drawing.Point(999, 774);
            lblPage.Name = "lblPage";
            lblPage.Size = new System.Drawing.Size(35, 13);
            lblPage.TabIndex = 601;
            lblPage.Text = "label2";
            lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewCommande
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1049, 795);
            Controls.Add(lblPage);
            Controls.Add(lbltitretotalfin);
            Controls.Add(lblAdresse);
            Controls.Add(lblCopieCredit);
            Controls.Add(lbltitrecommentaire);
            Controls.Add(lblCSA);
            Controls.Add(listView1);
            Controls.Add(lblNoSoum);
            Controls.Add(lblTitreNoSoum);
            Controls.Add(lbltypeprix);
            Controls.Add(lblTotalFin);
            Controls.Add(lblTitreTransport);
            Controls.Add(lblCommentaire);
            Controls.Add(lblCommandePar);
            Controls.Add(lblTransport);
            Controls.Add(lblTitre);
            Controls.Add(lblFournisseur);
            Controls.Add(lblTitreContact);
            Controls.Add(lblContact);
            Controls.Add(lblTitreTel);
            Controls.Add(lblTelephone);
            Controls.Add(lblTitreFax);
            Controls.Add(lblFax);
            Controls.Add(lbltitredatereq);
            Controls.Add(lblDateRequise);
            Controls.Add(lblTitreFournisseur);
            Controls.Add(lblPiedPage);
            Controls.Add(lbltitrecompar);
            Controls.Add(lblTitreBC);
            Controls.Add(lblDate);
            Controls.Add(lbltitredate);
            Controls.Add(lblNoBC);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitreCommande);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewCommande";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label lblTitreCommande;
        internal static Label lblCommandePar;
        internal static Label lblTransport;
        internal static Label lblTitre;
        internal static Label lblFournisseur;
        internal static Label lblTitreContact;
        internal static Label lblContact;
        internal static Label lblTitreTel;
        internal static Label lblTelephone;
        internal static Label lblTitreFax;
        internal static Label lblFax;
        internal static Label lbltitredatereq;
        internal static Label lblDateRequise;
        internal static Label lblTitreFournisseur;
        internal static Label lblPiedPage;
        internal static Label lbltitrecompar;
        internal static Label lblTitreBC;
        internal static Label lblDate;
        internal static Label lbltitredate;
        internal static Label lblNoBC;
        internal static TextBox lblCommentaire;
        internal static Label lblTitreTransport;
        internal static Label lblTotalFin;
        internal static Label lbltypeprix;
        internal static Label lblTitreNoSoum;
        internal static Label lblNoSoum;
        internal static ListView listView1;
        internal static ColumnHeader lblTitreQte;
        internal static ColumnHeader lblTitrePiece;
        internal static ColumnHeader lblTitreDescription;
        internal static ColumnHeader lblTitreManufact;
        internal static ColumnHeader lblTitrePrix;
        internal static ColumnHeader lblTitreEscompte;
        internal static ColumnHeader lblTitreTotal;
        internal static Label lblCSA;
        internal static Label lbltitrecommentaire;
        internal static Label lblCopieCredit;
        internal static Label lblAdresse;
        internal static Label lbltitretotalfin;
        internal static Label lblPage;
        int idFRS;
        string noBonCommande;
        public ViewCommande()
        {
            InitializeComponent();
        }
        public ViewCommande(int idFRS, string noBonCommande)
        {
            idFRS = idFRS;
            noBonCommande = noBonCommande;
            Text = Name;
            InitializeComponent();
            EnumérerDonnées(noBonCommande, idFRS);
        }
        public ViewCommande(bool telecomande)
        {
            telecomande = telecomande;
            idFRS = BonCommande.m_iNoFRS;
            noBonCommande = ACHAT.cmbNoAchat.Text;
            Text = $"Impression {noBonCommande} ak {ACHAT.cmbNoAchat.Text.Substring(0, 9)}";
            InitializeComponent();
            EnumérerDonnées(noBonCommande, idFRS);
        }
        private bool telecomande;
 
        private void EnumérerDonnées(string noBonCommande, int noFournisseur)
        {
            listView1.Items.Clear();
            double total = 0d;
            ADODB.Recordset rd = new ADODB.Recordset();
            rd.Open($"SELECT  * ,BONSCOMMANDES_PIECES.*,FOURNISSEUR.* FROM BONSCOMMANDES " +
                $"JOIN [DBO].[BONSCOMMANDES_PIECES] ON[DBO].[BONSCOMMANDES_PIECES].NOBONCOMMANDE =[DBO].[BONSCOMMANDES].NOBONCOMMANDE " +
                $"JOIN [DBO].[FOURNISSEUR] ON[DBO].[BONSCOMMANDES].NOFOURNISSEUR =[DBO].[FOURNISSEUR].IDFRS " +
                $"WHERE[DBO].[BONSCOMMANDES].NOBONCOMMANDE ='{noBonCommande}' AND[DBO].[BONSCOMMANDES].NOFOURNISSEUR = '{noFournisseur}' AND [DBO].[BONSCOMMANDES_PIECES].QTÉ IS NOT NULL " +
                $"ORDER BY[DATEREQUISE],[DATECOMMANDE]", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                if (!(rd.Fields[6].Value is DBNull)) { lblNoBC.Text = rd.Fields[6].Value; } else { lblNoBC.Text = string.Empty; }
                if (!(rd.Fields[10].Value is DBNull)) { lblCommentaire.Text = rd.Fields[10].Value; } else { lblCommentaire.Text = string.Empty; }
                lblCommandePar.Text = rd.Fields[8].Value;
                if (!(rd.Fields[3].Value is DBNull)) { lblContact.Text = rd.Fields[3].Value; } else { lblContact.Text = string.Empty; }
                lblDate.Text = rd.Fields[7].Value;
                if (!(rd.Fields[5].Value is DBNull)) { lblDateRequise.Text = rd.Fields[5].Value; } else { lblDateRequise.Text = string.Empty; }
                lblFax.Text = rd.Fields[36].Value;
                lblFournisseur.Text = rd.Fields[26].Value;
                lblTelephone.Text = rd.Fields[35].Value;
                lblNoBC.Text = rd.Fields[0].Value;
                if (!(rd.Fields[4].Value is DBNull)) { lblTransport.Text = rd.Fields[4].Value; } else { lblTransport.Text = " "; }
                lblPiedPage.Text = $"{IdNomEmploye}  {DateTime.Now.ToString()}    ";
                lblPiedPage.Visible = true;
                lblTitre.Text = $"Commande du {rd.Fields[7].Value}";
            }
            while (!rd.EOF)
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[51].Value}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[52].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[53].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[54].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[55].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[56].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[57].Value}"));
                total += double.Parse(rd.Fields[22].Value);
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            lblTotalFin.Text = $"Total: {Math.Round(total, 2)}$     ";
            for (int a = 1; a < listView1.Columns.Count - 3; a++)
            {
                listView1.Columns[a].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            return;
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            lblTitreCommande.Text = "Bon de commande";
            lblTitre.Text = "";
            Left = -2;
            Top = 0;
            FormBorderStyle = FormBorderStyle.None;
            lblDate.Text = GetDateTexte(DateTime.Now);
            listView1.Columns.Add("Quantité");
            listView1.Columns.Add("Pièce#");
            listView1.Columns.Add("Description");
            listView1.Columns.Add("Manufacturier");
            listView1.Columns.Add("Prix unité");
            listView1.Columns.Add("Escompte");
            listView1.Columns.Add("Total");
            for (int a = 0; a < listView1.Columns.Count; a++)
            {
                listView1.Columns[a].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            EnumérerDonnées("M23005-01-204", 717);
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
                printDocument1.DefaultPageSettings.Landscape = ControleurServeur.Program.isLandscape; //pour le mode paysage
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