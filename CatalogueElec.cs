#pragma warning disable CS0168
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static ControleurServeur.Program;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace ControleurServeur
{
    public class CatalogueElec : Form
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogueElec));
            txtTauxChange = new System.Windows.Forms.TextBox();
            lvwfournisseur = new System.Windows.Forms.ListView();
            Fournisseur = new System.Windows.Forms.ColumnHeader();
            PersRess = new System.Windows.Forms.ColumnHeader();
            Date = new System.Windows.Forms.ColumnHeader();
            Par = new System.Windows.Forms.ColumnHeader();
            Valide = new System.Windows.Forms.ColumnHeader();
            PrixListe = new System.Windows.Forms.ColumnHeader();
            Escompte = new System.Windows.Forms.ColumnHeader();
            PrixNet = new System.Windows.Forms.ColumnHeader();
            PrixSP = new System.Windows.Forms.ColumnHeader();
            Quoter = new System.Windows.Forms.ColumnHeader();
            cmdAddFrs = new System.Windows.Forms.Button();
            cmdSuppFrs = new System.Windows.Forms.Button();
            cmdModifFrs = new System.Windows.Forms.Button();
            chkquoter = new System.Windows.Forms.CheckBox();
            optUSA = new System.Windows.Forms.RadioButton();
            optCAN = new System.Windows.Forms.RadioButton();
            txtPrixList = new System.Windows.Forms.TextBox();
            txtPrixNet = new System.Windows.Forms.TextBox();
            txtPrixSpecial = new System.Windows.Forms.TextBox();
            mskValide = new System.Windows.Forms.MaskedTextBox();
            mskEscompte = new System.Windows.Forms.MaskedTextBox();
            cmdEnrFrs = new System.Windows.Forms.Button();
            CmdAnul = new System.Windows.Forms.Button();
            chkBoite = new System.Windows.Forms.CheckBox();
            txtQuantitéBoite = new System.Windows.Forms.TextBox();
            txtQuantiteMinimum = new System.Windows.Forms.TextBox();
            txtQuantiteStock = new System.Windows.Forms.TextBox();
            chkMinimum = new System.Windows.Forms.CheckBox();
            txtQuantiteCommande = new System.Windows.Forms.TextBox();
            Label5 = new System.Windows.Forms.Label();
            Label11 = new System.Windows.Forms.Label();
            CmdEnr = new System.Windows.Forms.Button();
            txtCategorie = new System.Windows.Forms.TextBox();
            cmdRechercherManufacturier = new System.Windows.Forms.Button();
            chkInventaire = new System.Windows.Forms.CheckBox();
            fraQuantité = new System.Windows.Forms.GroupBox();
            cmbLocalisation = new System.Windows.Forms.ComboBox();
            cmdAnnulFrs = new System.Windows.Forms.Button();
            Label2 = new System.Windows.Forms.Label();
            cmbfrs = new System.Windows.Forms.ComboBox();
            cmbPersRess = new System.Windows.Forms.ComboBox();
            optSpain = new System.Windows.Forms.RadioButton();
            lblDevise2 = new System.Windows.Forms.Label();
            lblDevise1 = new System.Windows.Forms.Label();
            _Label1_5 = new System.Windows.Forms.Label();
            imgSpain = new System.Windows.Forms.PictureBox();
            imgCanada = new System.Windows.Forms.PictureBox();
            imgEU = new System.Windows.Forms.PictureBox();
            _Label1_7 = new System.Windows.Forms.Label();
            _Label1_6 = new System.Windows.Forms.Label();
            _Label1_4 = new System.Windows.Forms.Label();
            _Label1_3 = new System.Windows.Forms.Label();
            _Label1_1 = new System.Windows.Forms.Label();
            _Label1_14 = new System.Windows.Forms.Label();
            _Label1_16 = new System.Windows.Forms.Label();
            _Label1_19 = new System.Windows.Forms.Label();
            _Label1_24 = new System.Windows.Forms.Label();
            _Label1_25 = new System.Windows.Forms.Label();
            _Label1_20 = new System.Windows.Forms.Label();
            _Label1_2 = new System.Windows.Forms.Label();
            txtLocalisation = new System.Windows.Forms.TextBox();
            txtDescriptionFR = new System.Windows.Forms.ComboBox();
            cmdTotal = new System.Windows.Forms.Button();
            cmdRechercheJob = new System.Windows.Forms.Button();
            cmdRechercheAchat = new System.Windows.Forms.Button();
            Image1 = new System.Windows.Forms.PictureBox();
            Label4 = new System.Windows.Forms.Label();
            _Label1_10 = new System.Windows.Forms.Label();
            _Label1_23 = new System.Windows.Forms.Label();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            lvwCategorie = new System.Windows.Forms.ListView();
            CmdRecherchecategorie = new System.Windows.Forms.Button();
            lvwRechercheAchat = new System.Windows.Forms.ListView();
            lvwRechercheJob = new System.Windows.Forms.ListView();
            cmdCopier = new System.Windows.Forms.Button();
            cmdRechercheInventaire = new System.Windows.Forms.Button();
            lvwFabricant = new System.Windows.Forms.ListView();
            lvwPieces = new System.Windows.Forms.ListView();
            lvwDescription = new System.Windows.Forms.ListView();
            cmdRechercherPiece = new System.Windows.Forms.Button();
            cmdChangerCategorie = new System.Windows.Forms.Button();
            cmdDemande = new System.Windows.Forms.Button();
            cmdRechercheDescrFR = new System.Windows.Forms.Button();
            txtTemps = new System.Windows.Forms.TextBox();
            frafournisseur = new System.Windows.Forms.GroupBox();
            cmbCategorie = new System.Windows.Forms.ComboBox();
            cmbNoItem = new System.Windows.Forms.ComboBox();
            CmdModif = new System.Windows.Forms.Button();
            CmdFerme = new System.Windows.Forms.Button();
            CmdSupp = new System.Windows.Forms.Button();
            CmdAdd = new System.Windows.Forms.Button();
            txtPageCat = new System.Windows.Forms.TextBox();
            txtComment = new System.Windows.Forms.TextBox();
            cmbFabricant = new System.Windows.Forms.ComboBox();
            txtFabricant = new System.Windows.Forms.TextBox();
            txtDescriptionEN = new System.Windows.Forms.TextBox();
            txtNoItem = new System.Windows.Forms.TextBox();
            _Label1_0 = new System.Windows.Forms.Label();
            txtNoItemGRB = new System.Windows.Forms.TextBox();
            fraQuantité.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(imgSpain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgCanada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgEU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Image1)).BeginInit();
            frafournisseur.SuspendLayout();
            SuspendLayout();
            // 
            // txtTauxChange
            // 
            txtTauxChange.AcceptsReturn = true;
            txtTauxChange.BackColor = System.Drawing.Color.Black;
            txtTauxChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtTauxChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTauxChange.ForeColor = System.Drawing.Color.White;
            txtTauxChange.Location = new System.Drawing.Point(241, 213);
            txtTauxChange.MaxLength = 0;
            txtTauxChange.Name = "txtTauxChange";
            txtTauxChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTauxChange.Size = new System.Drawing.Size(57, 20);
            txtTauxChange.TabIndex = 80;
            txtTauxChange.Visible = false;
            // 
            // lvwfournisseur
            // 
            lvwfournisseur.BackColor = System.Drawing.Color.Black;
            lvwfournisseur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lvwfournisseur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Fournisseur,
            PersRess,
            Date,
            Par,
            Valide,
            PrixListe,
            Escompte,
            PrixNet,
            PrixSP,
            Quoter});
            lvwfournisseur.ForeColor = System.Drawing.Color.White;
            lvwfournisseur.GridLines = true;
            lvwfournisseur.HideSelection = false;
            lvwfournisseur.Location = new System.Drawing.Point(6, 287);
            lvwfournisseur.Name = "lvwfournisseur";
            lvwfournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lvwfournisseur.Size = new System.Drawing.Size(1294, 311);
            lvwfournisseur.TabIndex = 46;
            lvwfournisseur.TabStop = false;
            lvwfournisseur.UseCompatibleStateImageBehavior = false;
            lvwfournisseur.View = System.Windows.Forms.View.Details;
            // 
            // Fournisseur
            // 
            Fournisseur.Text = "Fournisseur";
            // 
            // PersRess
            // 
            PersRess.Text = "Personne Resource";
            // 
            // Date
            // 
            Date.Text = "Date";
            // 
            // Par
            // 
            Par.Text = "Par";
            // 
            // Valide
            // 
            Valide.Text = "Valide";
            // 
            // PrixListe
            // 
            PrixListe.Text = "Prix listé";
            // 
            // Escompte
            // 
            Escompte.Text = "Escompte";
            // 
            // PrixNet
            // 
            PrixNet.Text = "Prix net";
            // 
            // PrixSP
            // 
            PrixSP.Text = "Spécial";
            // 
            // Quoter
            // 
            Quoter.Text = "Quoter";
            // 
            // cmdAddFrs
            // 
            cmdAddFrs.BackColor = System.Drawing.Color.Black;
            cmdAddFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAddFrs.ForeColor = System.Drawing.Color.White;
            cmdAddFrs.Location = new System.Drawing.Point(357, 213);
            cmdAddFrs.Name = "cmdAddFrs";
            cmdAddFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAddFrs.Size = new System.Drawing.Size(73, 25);
            cmdAddFrs.TabIndex = 66;
            cmdAddFrs.Text = "&Ajouter";
            cmdAddFrs.UseVisualStyleBackColor = true;
            cmdAddFrs.Click += new System.EventHandler(cmdAddFrs_Click);
            // 
            // cmdSuppFrs
            // 
            cmdSuppFrs.BackColor = System.Drawing.Color.Black;
            cmdSuppFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdSuppFrs.ForeColor = System.Drawing.Color.White;
            cmdSuppFrs.Location = new System.Drawing.Point(436, 213);
            cmdSuppFrs.Name = "cmdSuppFrs";
            cmdSuppFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSuppFrs.Size = new System.Drawing.Size(73, 25);
            cmdSuppFrs.TabIndex = 69;
            cmdSuppFrs.Text = "&Supprimer";
            cmdSuppFrs.UseVisualStyleBackColor = true;
            cmdSuppFrs.Click += new System.EventHandler(cmdSuppFrs_Click);
            // 
            // cmdModifFrs
            // 
            cmdModifFrs.BackColor = System.Drawing.Color.Black;
            cmdModifFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdModifFrs.ForeColor = System.Drawing.Color.White;
            cmdModifFrs.Location = new System.Drawing.Point(516, 213);
            cmdModifFrs.Name = "cmdModifFrs";
            cmdModifFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdModifFrs.Size = new System.Drawing.Size(73, 25);
            cmdModifFrs.TabIndex = 70;
            cmdModifFrs.Text = "&Modifier";
            cmdModifFrs.UseVisualStyleBackColor = true;
            cmdModifFrs.Click += new System.EventHandler(cmdModifFrs_Click);
            // 
            // chkquoter
            // 
            chkquoter.BackColor = System.Drawing.Color.Black;
            chkquoter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkquoter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkquoter.ForeColor = System.Drawing.Color.White;
            chkquoter.Location = new System.Drawing.Point(8, 104);
            chkquoter.Name = "chkquoter";
            chkquoter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkquoter.Size = new System.Drawing.Size(89, 17);
            chkquoter.TabIndex = 53;
            chkquoter.Text = "Quoter :";
            chkquoter.UseVisualStyleBackColor = true;
            // 
            // optUSA
            // 
            optUSA.BackColor = System.Drawing.Color.Black;
            optUSA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            optUSA.ForeColor = System.Drawing.Color.White;
            optUSA.Location = new System.Drawing.Point(241, 109);
            optUSA.Name = "optUSA";
            optUSA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optUSA.Size = new System.Drawing.Size(49, 17);
            optUSA.TabIndex = 63;
            optUSA.TabStop = true;
            optUSA.Text = "USA";
            optUSA.UseVisualStyleBackColor = true;
            // 
            // optCAN
            // 
            optCAN.BackColor = System.Drawing.Color.Black;
            optCAN.Checked = true;
            optCAN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            optCAN.ForeColor = System.Drawing.Color.White;
            optCAN.Location = new System.Drawing.Point(193, 109);
            optCAN.Name = "optCAN";
            optCAN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optCAN.Size = new System.Drawing.Size(49, 17);
            optCAN.TabIndex = 62;
            optCAN.TabStop = true;
            optCAN.Text = "CAN";
            optCAN.UseVisualStyleBackColor = true;
            // 
            // txtPrixList
            // 
            txtPrixList.AcceptsReturn = true;
            txtPrixList.BackColor = System.Drawing.Color.Black;
            txtPrixList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtPrixList.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixList.ForeColor = System.Drawing.Color.White;
            txtPrixList.Location = new System.Drawing.Point(88, 133);
            txtPrixList.MaxLength = 0;
            txtPrixList.Name = "txtPrixList";
            txtPrixList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixList.Size = new System.Drawing.Size(73, 20);
            txtPrixList.TabIndex = 55;
            // 
            // txtPrixNet
            // 
            txtPrixNet.AcceptsReturn = true;
            txtPrixNet.BackColor = System.Drawing.Color.Black;
            txtPrixNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtPrixNet.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixNet.ForeColor = System.Drawing.Color.White;
            txtPrixNet.Location = new System.Drawing.Point(88, 181);
            txtPrixNet.MaxLength = 0;
            txtPrixNet.Name = "txtPrixNet";
            txtPrixNet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixNet.Size = new System.Drawing.Size(57, 20);
            txtPrixNet.TabIndex = 59;
            // 
            // txtPrixSpecial
            // 
            txtPrixSpecial.AcceptsReturn = true;
            txtPrixSpecial.BackColor = System.Drawing.Color.Black;
            txtPrixSpecial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtPrixSpecial.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixSpecial.ForeColor = System.Drawing.Color.White;
            txtPrixSpecial.Location = new System.Drawing.Point(88, 205);
            txtPrixSpecial.MaxLength = 0;
            txtPrixSpecial.Name = "txtPrixSpecial";
            txtPrixSpecial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixSpecial.Size = new System.Drawing.Size(57, 20);
            txtPrixSpecial.TabIndex = 61;
            // 
            // mskValide
            // 
            mskValide.BackColor = System.Drawing.Color.Black;
            mskValide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskValide.ForeColor = System.Drawing.Color.White;
            mskValide.Location = new System.Drawing.Point(104, 80);
            mskValide.Name = "mskValide";
            mskValide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mskValide.Size = new System.Drawing.Size(81, 20);
            mskValide.TabIndex = 52;
            mskValide.TabStop = false;
            // 
            // mskEscompte
            // 
            mskEscompte.BackColor = System.Drawing.Color.Black;
            mskEscompte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskEscompte.ForeColor = System.Drawing.Color.White;
            mskEscompte.Location = new System.Drawing.Point(88, 157);
            mskEscompte.Name = "mskEscompte";
            mskEscompte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mskEscompte.Size = new System.Drawing.Size(57, 20);
            mskEscompte.TabIndex = 57;
            mskEscompte.TabStop = false;
            // 
            // cmdEnrFrs
            // 
            cmdEnrFrs.BackColor = System.Drawing.Color.Black;
            cmdEnrFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdEnrFrs.ForeColor = System.Drawing.Color.White;
            cmdEnrFrs.Location = new System.Drawing.Point(356, 213);
            cmdEnrFrs.Name = "cmdEnrFrs";
            cmdEnrFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdEnrFrs.Size = new System.Drawing.Size(73, 25);
            cmdEnrFrs.TabIndex = 67;
            cmdEnrFrs.Text = "&Enregistre";
            cmdEnrFrs.UseVisualStyleBackColor = true;
            cmdEnrFrs.Click += new System.EventHandler(cmdEnrFrs_Click);
            // 
            // CmdAnul
            // 
            CmdAnul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CmdAnul.BackColor = System.Drawing.Color.Black;
            CmdAnul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdAnul.ForeColor = System.Drawing.Color.White;
            CmdAnul.Location = new System.Drawing.Point(1052, 631);
            CmdAnul.Name = "CmdAnul";
            CmdAnul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAnul.Size = new System.Drawing.Size(80, 25);
            CmdAnul.TabIndex = 130;
            CmdAnul.Text = "A&nnuler";
            CmdAnul.UseVisualStyleBackColor = true;
            CmdAnul.Click += new System.EventHandler(CmdAnul_Click);
            // 
            // chkBoite
            // 
            chkBoite.BackColor = System.Drawing.Color.Black;
            chkBoite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkBoite.ForeColor = System.Drawing.Color.White;
            chkBoite.Location = new System.Drawing.Point(8, 24);
            chkBoite.Name = "chkBoite";
            chkBoite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkBoite.Size = new System.Drawing.Size(73, 17);
            chkBoite.TabIndex = 37;
            chkBoite.Text = "Par Boîte :";
            chkBoite.UseVisualStyleBackColor = true;
            // 
            // txtQuantitéBoite
            // 
            txtQuantitéBoite.AcceptsReturn = true;
            txtQuantitéBoite.BackColor = System.Drawing.Color.Black;
            txtQuantitéBoite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtQuantitéBoite.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuantitéBoite.Enabled = false;
            txtQuantitéBoite.ForeColor = System.Drawing.Color.White;
            txtQuantitéBoite.Location = new System.Drawing.Point(88, 24);
            txtQuantitéBoite.MaxLength = 0;
            txtQuantitéBoite.Name = "txtQuantitéBoite";
            txtQuantitéBoite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQuantitéBoite.Size = new System.Drawing.Size(41, 20);
            txtQuantitéBoite.TabIndex = 38;
            // 
            // txtQuantiteMinimum
            // 
            txtQuantiteMinimum.AcceptsReturn = true;
            txtQuantiteMinimum.BackColor = System.Drawing.Color.Black;
            txtQuantiteMinimum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtQuantiteMinimum.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuantiteMinimum.ForeColor = System.Drawing.Color.White;
            txtQuantiteMinimum.Location = new System.Drawing.Point(88, 72);
            txtQuantiteMinimum.MaxLength = 0;
            txtQuantiteMinimum.Name = "txtQuantiteMinimum";
            txtQuantiteMinimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQuantiteMinimum.Size = new System.Drawing.Size(41, 20);
            txtQuantiteMinimum.TabIndex = 42;
            // 
            // txtQuantiteStock
            // 
            txtQuantiteStock.AcceptsReturn = true;
            txtQuantiteStock.BackColor = System.Drawing.Color.Black;
            txtQuantiteStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtQuantiteStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuantiteStock.ForeColor = System.Drawing.Color.White;
            txtQuantiteStock.Location = new System.Drawing.Point(88, 48);
            txtQuantiteStock.MaxLength = 0;
            txtQuantiteStock.Name = "txtQuantiteStock";
            txtQuantiteStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQuantiteStock.Size = new System.Drawing.Size(41, 20);
            txtQuantiteStock.TabIndex = 40;
            // 
            // chkMinimum
            // 
            chkMinimum.BackColor = System.Drawing.Color.Black;
            chkMinimum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkMinimum.ForeColor = System.Drawing.Color.White;
            chkMinimum.Location = new System.Drawing.Point(8, 72);
            chkMinimum.Name = "chkMinimum";
            chkMinimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkMinimum.Size = new System.Drawing.Size(73, 17);
            chkMinimum.TabIndex = 41;
            chkMinimum.Text = "Minimum :";
            chkMinimum.UseVisualStyleBackColor = true;
            // 
            // txtQuantiteCommande
            // 
            txtQuantiteCommande.AcceptsReturn = true;
            txtQuantiteCommande.BackColor = System.Drawing.Color.Black;
            txtQuantiteCommande.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtQuantiteCommande.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuantiteCommande.ForeColor = System.Drawing.Color.White;
            txtQuantiteCommande.Location = new System.Drawing.Point(88, 96);
            txtQuantiteCommande.MaxLength = 0;
            txtQuantiteCommande.Name = "txtQuantiteCommande";
            txtQuantiteCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtQuantiteCommande.Size = new System.Drawing.Size(41, 20);
            txtQuantiteCommande.TabIndex = 44;
            // 
            // Label5
            // 
            Label5.BackColor = System.Drawing.Color.Black;
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(8, 48);
            Label5.Name = "Label5";
            Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label5.Size = new System.Drawing.Size(73, 17);
            Label5.TabIndex = 39;
            Label5.Text = "Stock :";
            // 
            // Label11
            // 
            Label11.BackColor = System.Drawing.Color.Black;
            Label11.ForeColor = System.Drawing.Color.White;
            Label11.Location = new System.Drawing.Point(8, 96);
            Label11.Name = "Label11";
            Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label11.Size = new System.Drawing.Size(73, 17);
            Label11.TabIndex = 43;
            Label11.Text = "À commander :";
            // 
            // CmdEnr
            // 
            CmdEnr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CmdEnr.BackColor = System.Drawing.Color.Black;
            CmdEnr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdEnr.ForeColor = System.Drawing.Color.White;
            CmdEnr.Location = new System.Drawing.Point(879, 631);
            CmdEnr.Name = "CmdEnr";
            CmdEnr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdEnr.Size = new System.Drawing.Size(80, 25);
            CmdEnr.TabIndex = 128;
            CmdEnr.Text = "&Enregistrer";
            CmdEnr.UseVisualStyleBackColor = true;
            CmdEnr.Click += new System.EventHandler(CmdEnr_Click);
            // 
            // txtCategorie
            // 
            txtCategorie.AcceptsReturn = true;
            txtCategorie.BackColor = System.Drawing.Color.Black;
            txtCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCategorie.ForeColor = System.Drawing.Color.White;
            txtCategorie.Location = new System.Drawing.Point(355, 17);
            txtCategorie.MaxLength = 0;
            txtCategorie.Name = "txtCategorie";
            txtCategorie.ReadOnly = true;
            txtCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCategorie.Size = new System.Drawing.Size(153, 20);
            txtCategorie.TabIndex = 90;
            // 
            // cmdRechercherManufacturier
            // 
            cmdRechercherManufacturier.AutoSize = true;
            cmdRechercherManufacturier.BackColor = System.Drawing.Color.Black;
            cmdRechercherManufacturier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercherManufacturier.ForeColor = System.Drawing.Color.White;
            cmdRechercherManufacturier.Image = ((System.Drawing.Image)(resources.GetObject("cmdRechercherManufacturier.Image")));
            cmdRechercherManufacturier.Location = new System.Drawing.Point(242, 57);
            cmdRechercherManufacturier.Name = "cmdRechercherManufacturier";
            cmdRechercherManufacturier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercherManufacturier.Size = new System.Drawing.Size(25, 25);
            cmdRechercherManufacturier.TabIndex = 95;
            cmdRechercherManufacturier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cmdRechercherManufacturier.UseVisualStyleBackColor = true;
            cmdRechercherManufacturier.Click += new System.EventHandler(cmdRechercherManufacturier_Click);
            // 
            // chkInventaire
            // 
            chkInventaire.BackColor = System.Drawing.Color.Black;
            chkInventaire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkInventaire.ForeColor = System.Drawing.Color.White;
            chkInventaire.Location = new System.Drawing.Point(546, 121);
            chkInventaire.Name = "chkInventaire";
            chkInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkInventaire.Size = new System.Drawing.Size(145, 17);
            chkInventaire.TabIndex = 112;
            chkInventaire.Text = "Présent dans l\'inventaire";
            chkInventaire.UseVisualStyleBackColor = true;
            // 
            // fraQuantité
            // 
            fraQuantité.BackColor = System.Drawing.Color.Black;
            fraQuantité.Controls.Add(chkBoite);
            fraQuantité.Controls.Add(txtQuantitéBoite);
            fraQuantité.Controls.Add(txtQuantiteMinimum);
            fraQuantité.Controls.Add(txtQuantiteStock);
            fraQuantité.Controls.Add(chkMinimum);
            fraQuantité.Controls.Add(txtQuantiteCommande);
            fraQuantité.Controls.Add(Label5);
            fraQuantité.Controls.Add(Label11);
            fraQuantité.ForeColor = System.Drawing.Color.White;
            fraQuantité.Location = new System.Drawing.Point(546, 137);
            fraQuantité.Name = "fraQuantité";
            fraQuantité.Padding = new System.Windows.Forms.Padding(0);
            fraQuantité.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraQuantité.Size = new System.Drawing.Size(145, 130);
            fraQuantité.TabIndex = 122;
            fraQuantité.TabStop = false;
            fraQuantité.Text = "Quantité";
            // 
            // cmbLocalisation
            // 
            cmbLocalisation.BackColor = System.Drawing.Color.Black;
            cmbLocalisation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbLocalisation.ForeColor = System.Drawing.Color.White;
            cmbLocalisation.Location = new System.Drawing.Point(434, 220);
            cmbLocalisation.Name = "cmbLocalisation";
            cmbLocalisation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbLocalisation.Size = new System.Drawing.Size(105, 21);
            cmbLocalisation.TabIndex = 116;
            cmbLocalisation.SelectedIndexChanged += new System.EventHandler(cmbLocalisation_SelectedIndexChanged);
            // 
            // cmdAnnulFrs
            // 
            cmdAnnulFrs.BackColor = System.Drawing.Color.Black;
            cmdAnnulFrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnulFrs.ForeColor = System.Drawing.Color.White;
            cmdAnnulFrs.Location = new System.Drawing.Point(436, 213);
            cmdAnnulFrs.Name = "cmdAnnulFrs";
            cmdAnnulFrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnulFrs.Size = new System.Drawing.Size(73, 25);
            cmdAnnulFrs.TabIndex = 68;
            cmdAnnulFrs.Text = "A&nnuler";
            cmdAnnulFrs.UseVisualStyleBackColor = true;
            cmdAnnulFrs.Click += new System.EventHandler(cmdAnnulFrs_Click);
            // 
            // Label2
            // 
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(228, 23);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(121, 17);
            Label2.TabIndex = 89;
            Label2.Text = "CatégorieFournisseur de pièce :";
            // 
            // cmbfrs
            // 
            cmbfrs.BackColor = System.Drawing.Color.Black;
            cmbfrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbfrs.ForeColor = System.Drawing.Color.White;
            cmbfrs.Location = new System.Drawing.Point(104, 32);
            cmbfrs.Name = "cmbfrs";
            cmbfrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbfrs.Size = new System.Drawing.Size(185, 21);
            cmbfrs.TabIndex = 48;
            cmbfrs.SelectedIndexChanged += new System.EventHandler(cmbfrs_SelectedIndexChanged);
            // 
            // cmbPersRess
            // 
            cmbPersRess.BackColor = System.Drawing.Color.Black;
            cmbPersRess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbPersRess.ForeColor = System.Drawing.Color.White;
            cmbPersRess.Location = new System.Drawing.Point(104, 56);
            cmbPersRess.Name = "cmbPersRess";
            cmbPersRess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbPersRess.Size = new System.Drawing.Size(145, 21);
            cmbPersRess.TabIndex = 50;
            // 
            // optSpain
            // 
            optSpain.BackColor = System.Drawing.Color.Black;
            optSpain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            optSpain.ForeColor = System.Drawing.Color.White;
            optSpain.Location = new System.Drawing.Point(289, 109);
            optSpain.Name = "optSpain";
            optSpain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optSpain.Size = new System.Drawing.Size(49, 17);
            optSpain.TabIndex = 64;
            optSpain.TabStop = true;
            optSpain.Text = "SPA";
            optSpain.UseVisualStyleBackColor = true;
            // 
            // lblDevise2
            // 
            lblDevise2.BackColor = System.Drawing.Color.Black;
            lblDevise2.ForeColor = System.Drawing.Color.White;
            lblDevise2.Location = new System.Drawing.Point(302, 213);
            lblDevise2.Name = "lblDevise2";
            lblDevise2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDevise2.Size = new System.Drawing.Size(39, 17);
            lblDevise2.TabIndex = 82;
            lblDevise2.Text = "$ USA";
            lblDevise2.Visible = false;
            // 
            // lblDevise1
            // 
            lblDevise1.BackColor = System.Drawing.Color.Black;
            lblDevise1.ForeColor = System.Drawing.Color.White;
            lblDevise1.Location = new System.Drawing.Point(185, 213);
            lblDevise1.Name = "lblDevise1";
            lblDevise1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblDevise1.Size = new System.Drawing.Size(57, 17);
            lblDevise1.TabIndex = 81;
            lblDevise1.Text = "1$ CAN =";
            lblDevise1.Visible = false;
            // 
            // _Label1_5
            // 
            _Label1_5.BackColor = System.Drawing.Color.Black;
            _Label1_5.ForeColor = System.Drawing.Color.White;
            _Label1_5.Location = new System.Drawing.Point(192, 80);
            _Label1_5.Name = "_Label1_5";
            _Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_5.Size = new System.Drawing.Size(65, 17);
            _Label1_5.TabIndex = 65;
            _Label1_5.Text = "AA-MM-JJ";
            // 
            // imgSpain
            // 
            imgSpain.Location = new System.Drawing.Point(209, 133);
            imgSpain.Name = "imgSpain";
            imgSpain.Size = new System.Drawing.Size(112, 71);
            imgSpain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgSpain.TabIndex = 83;
            imgSpain.TabStop = false;
            imgSpain.Visible = false;
            // 
            // imgCanada
            // 
            imgCanada.Location = new System.Drawing.Point(209, 133);
            imgCanada.Name = "imgCanada";
            imgCanada.Size = new System.Drawing.Size(112, 71);
            imgCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgCanada.TabIndex = 84;
            imgCanada.TabStop = false;
            imgCanada.Visible = false;
            // 
            // imgEU
            // 
            imgEU.Image = ((System.Drawing.Image)(resources.GetObject("imgEU.Image")));
            imgEU.Location = new System.Drawing.Point(209, 133);
            imgEU.Name = "imgEU";
            imgEU.Size = new System.Drawing.Size(112, 71);
            imgEU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgEU.TabIndex = 85;
            imgEU.TabStop = false;
            imgEU.Visible = false;
            // 
            // _Label1_7
            // 
            _Label1_7.BackColor = System.Drawing.Color.Black;
            _Label1_7.ForeColor = System.Drawing.Color.White;
            _Label1_7.Location = new System.Drawing.Point(10, 185);
            _Label1_7.Name = "_Label1_7";
            _Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_7.Size = new System.Drawing.Size(89, 17);
            _Label1_7.TabIndex = 113;
            _Label1_7.Text = "Catalogue :";
            // 
            // _Label1_6
            // 
            _Label1_6.BackColor = System.Drawing.Color.Black;
            _Label1_6.ForeColor = System.Drawing.Color.White;
            _Label1_6.Location = new System.Drawing.Point(282, 161);
            _Label1_6.Name = "_Label1_6";
            _Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_6.Size = new System.Drawing.Size(87, 17);
            _Label1_6.TabIndex = 110;
            _Label1_6.Text = "Commentaire :";
            _Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_4
            // 
            _Label1_4.BackColor = System.Drawing.Color.Black;
            _Label1_4.ForeColor = System.Drawing.Color.White;
            _Label1_4.Location = new System.Drawing.Point(274, 89);
            _Label1_4.Name = "_Label1_4";
            _Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_4.Size = new System.Drawing.Size(73, 17);
            _Label1_4.TabIndex = 106;
            _Label1_4.Text = "Desc. EN :";
            // 
            // _Label1_3
            // 
            _Label1_3.BackColor = System.Drawing.Color.Black;
            _Label1_3.ForeColor = System.Drawing.Color.White;
            _Label1_3.Location = new System.Drawing.Point(274, 57);
            _Label1_3.Name = "_Label1_3";
            _Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_3.Size = new System.Drawing.Size(73, 17);
            _Label1_3.TabIndex = 96;
            _Label1_3.Text = "Desc. FR :";
            // 
            // _Label1_1
            // 
            _Label1_1.BackColor = System.Drawing.Color.Black;
            _Label1_1.ForeColor = System.Drawing.Color.White;
            _Label1_1.Location = new System.Drawing.Point(10, 57);
            _Label1_1.Name = "_Label1_1";
            _Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_1.Size = new System.Drawing.Size(89, 17);
            _Label1_1.TabIndex = 92;
            _Label1_1.Text = "Manufacturier :";
            // 
            // _Label1_14
            // 
            _Label1_14.BackColor = System.Drawing.Color.Black;
            _Label1_14.ForeColor = System.Drawing.Color.White;
            _Label1_14.Location = new System.Drawing.Point(8, 32);
            _Label1_14.Name = "_Label1_14";
            _Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_14.Size = new System.Drawing.Size(81, 17);
            _Label1_14.TabIndex = 47;
            _Label1_14.Text = "Distributeur :";
            // 
            // _Label1_16
            // 
            _Label1_16.BackColor = System.Drawing.Color.Black;
            _Label1_16.ForeColor = System.Drawing.Color.White;
            _Label1_16.Location = new System.Drawing.Point(8, 133);
            _Label1_16.Name = "_Label1_16";
            _Label1_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_16.Size = new System.Drawing.Size(65, 17);
            _Label1_16.TabIndex = 54;
            _Label1_16.Text = "Prix Listé :";
            // 
            // _Label1_19
            // 
            _Label1_19.BackColor = System.Drawing.Color.Black;
            _Label1_19.ForeColor = System.Drawing.Color.White;
            _Label1_19.Location = new System.Drawing.Point(8, 157);
            _Label1_19.Name = "_Label1_19";
            _Label1_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_19.Size = new System.Drawing.Size(73, 17);
            _Label1_19.TabIndex = 56;
            _Label1_19.Text = "Escompte :";
            // 
            // _Label1_24
            // 
            _Label1_24.BackColor = System.Drawing.Color.Black;
            _Label1_24.ForeColor = System.Drawing.Color.White;
            _Label1_24.Location = new System.Drawing.Point(8, 56);
            _Label1_24.Name = "_Label1_24";
            _Label1_24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_24.Size = new System.Drawing.Size(105, 17);
            _Label1_24.TabIndex = 49;
            _Label1_24.Text = "Pers. Ress :";
            // 
            // _Label1_25
            // 
            _Label1_25.BackColor = System.Drawing.Color.Black;
            _Label1_25.ForeColor = System.Drawing.Color.White;
            _Label1_25.Location = new System.Drawing.Point(10, 145);
            _Label1_25.Name = "_Label1_25";
            _Label1_25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_25.Size = new System.Drawing.Size(89, 17);
            _Label1_25.TabIndex = 109;
            _Label1_25.Text = "Pièce GRB :";
            // 
            // _Label1_20
            // 
            _Label1_20.BackColor = System.Drawing.Color.Black;
            _Label1_20.ForeColor = System.Drawing.Color.White;
            _Label1_20.Location = new System.Drawing.Point(8, 181);
            _Label1_20.Name = "_Label1_20";
            _Label1_20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_20.Size = new System.Drawing.Size(73, 17);
            _Label1_20.TabIndex = 58;
            _Label1_20.Text = "Prix Net :";
            // 
            // _Label1_2
            // 
            _Label1_2.BackColor = System.Drawing.Color.Black;
            _Label1_2.ForeColor = System.Drawing.Color.White;
            _Label1_2.Location = new System.Drawing.Point(8, 205);
            _Label1_2.Name = "_Label1_2";
            _Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_2.Size = new System.Drawing.Size(81, 17);
            _Label1_2.TabIndex = 60;
            _Label1_2.Text = "Prix Spécial :";
            // 
            // txtLocalisation
            // 
            txtLocalisation.AcceptsReturn = true;
            txtLocalisation.BackColor = System.Drawing.Color.Black;
            txtLocalisation.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtLocalisation.ForeColor = System.Drawing.Color.White;
            txtLocalisation.Location = new System.Drawing.Point(434, 218);
            txtLocalisation.MaxLength = 0;
            txtLocalisation.Name = "txtLocalisation";
            txtLocalisation.ReadOnly = true;
            txtLocalisation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtLocalisation.Size = new System.Drawing.Size(105, 20);
            txtLocalisation.TabIndex = 117;
            txtLocalisation.Text = "Text1";
            // 
            // txtDescriptionFR
            // 
            txtDescriptionFR.BackColor = System.Drawing.Color.Black;
            txtDescriptionFR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            txtDescriptionFR.ForeColor = System.Drawing.Color.White;
            txtDescriptionFR.Location = new System.Drawing.Point(354, 57);
            txtDescriptionFR.Name = "txtDescriptionFR";
            txtDescriptionFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDescriptionFR.Size = new System.Drawing.Size(305, 21);
            txtDescriptionFR.TabIndex = 97;
            txtDescriptionFR.SelectedIndexChanged += new System.EventHandler(txtDescriptionFR_SelectedIndexChanged);
            // 
            // cmdTotal
            // 
            cmdTotal.AutoSize = true;
            cmdTotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdTotal.BackColor = System.Drawing.Color.Black;
            cmdTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdTotal.ForeColor = System.Drawing.Color.White;
            cmdTotal.Location = new System.Drawing.Point(10, 217);
            cmdTotal.Name = "cmdTotal";
            cmdTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdTotal.Size = new System.Drawing.Size(45, 22);
            cmdTotal.TabIndex = 118;
            cmdTotal.Text = "Total";
            cmdTotal.UseVisualStyleBackColor = true;
            cmdTotal.Click += new System.EventHandler(cmdTotal_Click);
            // 
            // cmdRechercheJob
            // 
            cmdRechercheJob.AutoSize = true;
            cmdRechercheJob.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdRechercheJob.BackColor = System.Drawing.Color.Black;
            cmdRechercheJob.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercheJob.ForeColor = System.Drawing.Color.White;
            cmdRechercheJob.Location = new System.Drawing.Point(55, 218);
            cmdRechercheJob.Name = "cmdRechercheJob";
            cmdRechercheJob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercheJob.Size = new System.Drawing.Size(163, 22);
            cmdRechercheJob.TabIndex = 119;
            cmdRechercheJob.Text = "Recherche dans jobs / soums";
            cmdRechercheJob.UseVisualStyleBackColor = true;
            cmdRechercheJob.Click += new System.EventHandler(cmdRechercheJob_Click);
            // 
            // cmdRechercheAchat
            // 
            cmdRechercheAchat.AutoSize = true;
            cmdRechercheAchat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdRechercheAchat.BackColor = System.Drawing.Color.Black;
            cmdRechercheAchat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercheAchat.ForeColor = System.Drawing.Color.White;
            cmdRechercheAchat.Location = new System.Drawing.Point(222, 217);
            cmdRechercheAchat.Name = "cmdRechercheAchat";
            cmdRechercheAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercheAchat.Size = new System.Drawing.Size(135, 22);
            cmdRechercheAchat.TabIndex = 134;
            cmdRechercheAchat.Text = "Recherche dans achats";
            cmdRechercheAchat.UseVisualStyleBackColor = true;
            cmdRechercheAchat.Click += new System.EventHandler(cmdRechercheAchat_Click);
            // 
            // Image1
            // 
            Image1.ErrorImage = global::ControleurServeur.Properties.Resources.Home;
            Image1.InitialImage = global::ControleurServeur.Properties.Resources.Home;
            Image1.Location = new System.Drawing.Point(380, 23);
            Image1.Name = "Image1";
            Image1.Size = new System.Drawing.Size(167, 162);
            Image1.TabIndex = 137;
            Image1.TabStop = false;
            // 
            // Label4
            // 
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(434, 202);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(65, 17);
            Label4.TabIndex = 115;
            Label4.Text = "Localisation :";
            // 
            // _Label1_10
            // 
            _Label1_10.BackColor = System.Drawing.Color.Black;
            _Label1_10.ForeColor = System.Drawing.Color.White;
            _Label1_10.Location = new System.Drawing.Point(282, 129);
            _Label1_10.Name = "_Label1_10";
            _Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_10.Size = new System.Drawing.Size(87, 17);
            _Label1_10.TabIndex = 120;
            _Label1_10.Text = "Temps :";
            _Label1_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _Label1_23
            // 
            _Label1_23.BackColor = System.Drawing.Color.Black;
            _Label1_23.ForeColor = System.Drawing.Color.White;
            _Label1_23.Location = new System.Drawing.Point(8, 80);
            _Label1_23.Name = "_Label1_23";
            _Label1_23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_23.Size = new System.Drawing.Size(97, 17);
            _Label1_23.TabIndex = 51;
            _Label1_23.Text = "Valide jusqu\'au :";
            // 
            // lvwCategorie
            // 
            lvwCategorie.BackColor = System.Drawing.Color.Black;
            lvwCategorie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lvwCategorie.ForeColor = System.Drawing.Color.White;
            lvwCategorie.GridLines = true;
            lvwCategorie.HideSelection = false;
            lvwCategorie.Location = new System.Drawing.Point(19, 327);
            lvwCategorie.Name = "lvwCategorie";
            lvwCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lvwCategorie.Size = new System.Drawing.Size(1267, 271);
            lvwCategorie.TabIndex = 136;
            lvwCategorie.TabStop = false;
            lvwCategorie.UseCompatibleStateImageBehavior = false;
            lvwCategorie.View = System.Windows.Forms.View.Details;
            lvwCategorie.Visible = false;
            // 
            // CmdRecherchecategorie
            // 
            CmdRecherchecategorie.BackColor = System.Drawing.Color.Black;
            CmdRecherchecategorie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdRecherchecategorie.ForeColor = System.Drawing.Color.White;
            CmdRecherchecategorie.Image = ((System.Drawing.Image)(resources.GetObject("CmdRecherchecategorie.Image")));
            CmdRecherchecategorie.Location = new System.Drawing.Point(666, 17);
            CmdRecherchecategorie.Name = "CmdRecherchecategorie";
            CmdRecherchecategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdRecherchecategorie.Size = new System.Drawing.Size(25, 25);
            CmdRecherchecategorie.TabIndex = 135;
            CmdRecherchecategorie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            CmdRecherchecategorie.UseVisualStyleBackColor = true;
            CmdRecherchecategorie.Click += new System.EventHandler(cmdRechercheCategorie_Click);
            // 
            // lvwRechercheAchat
            // 
            lvwRechercheAchat.BackColor = System.Drawing.Color.Black;
            lvwRechercheAchat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lvwRechercheAchat.ForeColor = System.Drawing.Color.Cyan;
            lvwRechercheAchat.FullRowSelect = true;
            lvwRechercheAchat.GridLines = true;
            lvwRechercheAchat.HideSelection = false;
            lvwRechercheAchat.Location = new System.Drawing.Point(10, 287);
            lvwRechercheAchat.Name = "lvwRechercheAchat";
            lvwRechercheAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lvwRechercheAchat.Size = new System.Drawing.Size(1294, 311);
            lvwRechercheAchat.TabIndex = 133;
            lvwRechercheAchat.TabStop = false;
            lvwRechercheAchat.UseCompatibleStateImageBehavior = false;
            lvwRechercheAchat.View = System.Windows.Forms.View.Details;
            lvwRechercheAchat.Visible = false;
            // 
            // lvwRechercheJob
            // 
            lvwRechercheJob.BackColor = System.Drawing.Color.Black;
            lvwRechercheJob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lvwRechercheJob.ForeColor = System.Drawing.Color.White;
            lvwRechercheJob.FullRowSelect = true;
            lvwRechercheJob.GridLines = true;
            lvwRechercheJob.HideSelection = false;
            lvwRechercheJob.Location = new System.Drawing.Point(6, 287);
            lvwRechercheJob.Name = "lvwRechercheJob";
            lvwRechercheJob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lvwRechercheJob.Size = new System.Drawing.Size(1294, 311);
            lvwRechercheJob.TabIndex = 108;
            lvwRechercheJob.TabStop = false;
            lvwRechercheJob.UseCompatibleStateImageBehavior = false;
            lvwRechercheJob.View = System.Windows.Forms.View.Details;
            lvwRechercheJob.Visible = false;
            // 
            // cmdCopier
            // 
            cmdCopier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdCopier.BackColor = System.Drawing.Color.Black;
            cmdCopier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdCopier.ForeColor = System.Drawing.Color.White;
            cmdCopier.Location = new System.Drawing.Point(707, 631);
            cmdCopier.Name = "cmdCopier";
            cmdCopier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCopier.Size = new System.Drawing.Size(80, 25);
            cmdCopier.TabIndex = 126;
            cmdCopier.Text = "&Copier";
            cmdCopier.UseVisualStyleBackColor = true;
            cmdCopier.Click += new System.EventHandler(cmdCopier_Click);
            // 
            // cmdRechercheInventaire
            // 
            cmdRechercheInventaire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdRechercheInventaire.BackColor = System.Drawing.Color.Black;
            cmdRechercheInventaire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercheInventaire.ForeColor = System.Drawing.Color.White;
            cmdRechercheInventaire.Location = new System.Drawing.Point(13, 631);
            cmdRechercheInventaire.Name = "cmdRechercheInventaire";
            cmdRechercheInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercheInventaire.Size = new System.Drawing.Size(80, 25);
            cmdRechercheInventaire.TabIndex = 124;
            cmdRechercheInventaire.Text = "Inventaire";
            cmdRechercheInventaire.UseVisualStyleBackColor = true;
            cmdRechercheInventaire.Click += new System.EventHandler(cmdRechercheInventaire_Click);
            // 
            // lvwFabricant
            // 
            lvwFabricant.BackColor = System.Drawing.Color.Black;
            lvwFabricant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lvwFabricant.ForeColor = System.Drawing.Color.White;
            lvwFabricant.GridLines = true;
            lvwFabricant.HideSelection = false;
            lvwFabricant.Location = new System.Drawing.Point(13, 287);
            lvwFabricant.Name = "lvwFabricant";
            lvwFabricant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lvwFabricant.Size = new System.Drawing.Size(1294, 311);
            lvwFabricant.TabIndex = 100;
            lvwFabricant.TabStop = false;
            lvwFabricant.UseCompatibleStateImageBehavior = false;
            lvwFabricant.View = System.Windows.Forms.View.Details;
            lvwFabricant.Visible = false;
            // 
            // lvwPieces
            // 
            lvwPieces.BackColor = System.Drawing.Color.Black;
            lvwPieces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lvwPieces.ForeColor = System.Drawing.Color.White;
            lvwPieces.GridLines = true;
            lvwPieces.HideSelection = false;
            lvwPieces.Location = new System.Drawing.Point(10, 287);
            lvwPieces.Name = "lvwPieces";
            lvwPieces.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lvwPieces.Size = new System.Drawing.Size(1294, 311);
            lvwPieces.TabIndex = 98;
            lvwPieces.TabStop = false;
            lvwPieces.UseCompatibleStateImageBehavior = false;
            lvwPieces.View = System.Windows.Forms.View.Details;
            lvwPieces.Visible = false;
            // 
            // lvwDescription
            // 
            lvwDescription.BackColor = System.Drawing.Color.Black;
            lvwDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lvwDescription.ForeColor = System.Drawing.Color.White;
            lvwDescription.GridLines = true;
            lvwDescription.HideSelection = false;
            lvwDescription.Location = new System.Drawing.Point(6, 287);
            lvwDescription.Name = "lvwDescription";
            lvwDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lvwDescription.Size = new System.Drawing.Size(1294, 311);
            lvwDescription.TabIndex = 99;
            lvwDescription.TabStop = false;
            lvwDescription.UseCompatibleStateImageBehavior = false;
            lvwDescription.View = System.Windows.Forms.View.Details;
            lvwDescription.Visible = false;
            // 
            // cmdRechercherPiece
            // 
            cmdRechercherPiece.AutoSize = true;
            cmdRechercherPiece.BackColor = System.Drawing.Color.Black;
            cmdRechercherPiece.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercherPiece.ForeColor = System.Drawing.Color.White;
            cmdRechercherPiece.Image = ((System.Drawing.Image)(resources.GetObject("cmdRechercherPiece.Image")));
            cmdRechercherPiece.Location = new System.Drawing.Point(242, 113);
            cmdRechercherPiece.Name = "cmdRechercherPiece";
            cmdRechercherPiece.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercherPiece.Size = new System.Drawing.Size(25, 25);
            cmdRechercherPiece.TabIndex = 105;
            cmdRechercherPiece.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cmdRechercherPiece.UseVisualStyleBackColor = true;
            cmdRechercherPiece.Click += new System.EventHandler(cmdRechercherPiece_Click);
            // 
            // cmdChangerCategorie
            // 
            cmdChangerCategorie.BackColor = System.Drawing.Color.Black;
            cmdChangerCategorie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdChangerCategorie.ForeColor = System.Drawing.Color.White;
            cmdChangerCategorie.Location = new System.Drawing.Point(538, 18);
            cmdChangerCategorie.Name = "cmdChangerCategorie";
            cmdChangerCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdChangerCategorie.Size = new System.Drawing.Size(121, 25);
            cmdChangerCategorie.TabIndex = 88;
            cmdChangerCategorie.Text = "Changer de catégorie";
            cmdChangerCategorie.UseVisualStyleBackColor = true;
            cmdChangerCategorie.Visible = false;
            cmdChangerCategorie.Click += new System.EventHandler(cmdChangerCategorie_Click);
            // 
            // cmdDemande
            // 
            cmdDemande.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdDemande.BackColor = System.Drawing.Color.Black;
            cmdDemande.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdDemande.ForeColor = System.Drawing.Color.White;
            cmdDemande.Location = new System.Drawing.Point(598, 631);
            cmdDemande.Name = "cmdDemande";
            cmdDemande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDemande.Size = new System.Drawing.Size(103, 25);
            cmdDemande.TabIndex = 125;
            cmdDemande.Text = "Demande de prix";
            cmdDemande.UseVisualStyleBackColor = true;
            cmdDemande.Click += new System.EventHandler(cmdDemande_Click);
            // 
            // cmdRechercheDescrFR
            // 
            cmdRechercheDescrFR.BackColor = System.Drawing.Color.Black;
            cmdRechercheDescrFR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRechercheDescrFR.ForeColor = System.Drawing.Color.White;
            cmdRechercheDescrFR.Image = ((System.Drawing.Image)(resources.GetObject("cmdRechercheDescrFR.Image")));
            cmdRechercheDescrFR.Location = new System.Drawing.Point(666, 57);
            cmdRechercheDescrFR.Name = "cmdRechercheDescrFR";
            cmdRechercheDescrFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRechercheDescrFR.Size = new System.Drawing.Size(25, 25);
            cmdRechercheDescrFR.TabIndex = 101;
            cmdRechercheDescrFR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cmdRechercheDescrFR.UseVisualStyleBackColor = true;
            cmdRechercheDescrFR.Click += new System.EventHandler(cmdRechercheDescrFR_Click);
            // 
            // txtTemps
            // 
            txtTemps.AcceptsReturn = true;
            txtTemps.BackColor = System.Drawing.Color.Black;
            txtTemps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtTemps.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTemps.ForeColor = System.Drawing.Color.White;
            txtTemps.Location = new System.Drawing.Point(378, 129);
            txtTemps.MaxLength = 0;
            txtTemps.Name = "txtTemps";
            txtTemps.ReadOnly = true;
            txtTemps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTemps.Size = new System.Drawing.Size(49, 20);
            txtTemps.TabIndex = 121;
            // 
            // frafournisseur
            // 
            frafournisseur.BackColor = System.Drawing.Color.Black;
            frafournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            frafournisseur.Controls.Add(txtTauxChange);
            frafournisseur.Controls.Add(cmdAddFrs);
            frafournisseur.Controls.Add(cmdSuppFrs);
            frafournisseur.Controls.Add(chkquoter);
            frafournisseur.Controls.Add(optUSA);
            frafournisseur.Controls.Add(cmdModifFrs);
            frafournisseur.Controls.Add(optCAN);
            frafournisseur.Controls.Add(txtPrixList);
            frafournisseur.Controls.Add(txtPrixNet);
            frafournisseur.Controls.Add(txtPrixSpecial);
            frafournisseur.Controls.Add(mskValide);
            frafournisseur.Controls.Add(mskEscompte);
            frafournisseur.Controls.Add(cmbfrs);
            frafournisseur.Controls.Add(cmbPersRess);
            frafournisseur.Controls.Add(optSpain);
            frafournisseur.Controls.Add(lblDevise2);
            frafournisseur.Controls.Add(cmdEnrFrs);
            frafournisseur.Controls.Add(lblDevise1);
            frafournisseur.Controls.Add(_Label1_5);
            frafournisseur.Controls.Add(cmdAnnulFrs);
            frafournisseur.Controls.Add(imgSpain);
            frafournisseur.Controls.Add(Image1);
            frafournisseur.Controls.Add(imgCanada);
            frafournisseur.Controls.Add(imgEU);
            frafournisseur.Controls.Add(_Label1_14);
            frafournisseur.Controls.Add(_Label1_16);
            frafournisseur.Controls.Add(_Label1_19);
            frafournisseur.Controls.Add(_Label1_24);
            frafournisseur.Controls.Add(_Label1_20);
            frafournisseur.Controls.Add(_Label1_2);
            frafournisseur.Controls.Add(_Label1_23);
            frafournisseur.ForeColor = System.Drawing.Color.White;
            frafournisseur.Location = new System.Drawing.Point(708, 17);
            frafournisseur.Name = "frafournisseur";
            frafournisseur.Padding = new System.Windows.Forms.Padding(0);
            frafournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            frafournisseur.Size = new System.Drawing.Size(596, 250);
            frafournisseur.TabIndex = 123;
            frafournisseur.TabStop = false;
            frafournisseur.Text = "Fournisseur";
            // 
            // cmbCategorie
            // 
            cmbCategorie.BackColor = System.Drawing.Color.Black;
            cmbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbCategorie.ForeColor = System.Drawing.Color.White;
            cmbCategorie.Location = new System.Drawing.Point(354, 17);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbCategorie.Size = new System.Drawing.Size(169, 21);
            cmbCategorie.TabIndex = 91;
            cmbCategorie.Text = "cmbCategorie";
            cmbCategorie.SelectedIndexChanged += new System.EventHandler(cmbCategorie_SelectedIndexChanged_1);
            // 
            // cmbNoItem
            // 
            cmbNoItem.BackColor = System.Drawing.Color.Black;
            cmbNoItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbNoItem.ForeColor = System.Drawing.Color.White;
            cmbNoItem.Location = new System.Drawing.Point(106, 113);
            cmbNoItem.Name = "cmbNoItem";
            cmbNoItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbNoItem.Size = new System.Drawing.Size(129, 21);
            cmbNoItem.TabIndex = 103;
            cmbNoItem.Visible = false;
            cmbNoItem.SelectedIndexChanged += new System.EventHandler(cmbNoItem_SelectedIndexChanged);
            // 
            // CmdModif
            // 
            CmdModif.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CmdModif.BackColor = System.Drawing.Color.Black;
            CmdModif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdModif.ForeColor = System.Drawing.Color.White;
            CmdModif.Location = new System.Drawing.Point(1138, 631);
            CmdModif.Name = "CmdModif";
            CmdModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdModif.Size = new System.Drawing.Size(80, 25);
            CmdModif.TabIndex = 131;
            CmdModif.Text = "&Modifier";
            CmdModif.UseVisualStyleBackColor = true;
            CmdModif.Click += new System.EventHandler(CmdModif_Click);
            // 
            // CmdFerme
            // 
            CmdFerme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CmdFerme.BackColor = System.Drawing.Color.Black;
            CmdFerme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdFerme.ForeColor = System.Drawing.Color.White;
            CmdFerme.Location = new System.Drawing.Point(1224, 631);
            CmdFerme.Name = "CmdFerme";
            CmdFerme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdFerme.Size = new System.Drawing.Size(80, 25);
            CmdFerme.TabIndex = 132;
            CmdFerme.Text = "&Fermer";
            CmdFerme.UseVisualStyleBackColor = true;
            CmdFerme.Click += new System.EventHandler(CmdFerme_Click);
            // 
            // CmdSupp
            // 
            CmdSupp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CmdSupp.BackColor = System.Drawing.Color.Black;
            CmdSupp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdSupp.ForeColor = System.Drawing.Color.White;
            CmdSupp.Location = new System.Drawing.Point(965, 631);
            CmdSupp.Name = "CmdSupp";
            CmdSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdSupp.Size = new System.Drawing.Size(80, 25);
            CmdSupp.TabIndex = 129;
            CmdSupp.Text = "&Supprimer";
            CmdSupp.UseVisualStyleBackColor = true;
            CmdSupp.Click += new System.EventHandler(CmdSupp_Click);
            // 
            // CmdAdd
            // 
            CmdAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CmdAdd.BackColor = System.Drawing.Color.Black;
            CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdAdd.ForeColor = System.Drawing.Color.White;
            CmdAdd.Location = new System.Drawing.Point(793, 631);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAdd.Size = new System.Drawing.Size(80, 25);
            CmdAdd.TabIndex = 127;
            CmdAdd.Text = "&Ajouter";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += new System.EventHandler(CmdAdd_Click);
            // 
            // txtPageCat
            // 
            txtPageCat.AcceptsReturn = true;
            txtPageCat.BackColor = System.Drawing.Color.Black;
            txtPageCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtPageCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPageCat.ForeColor = System.Drawing.Color.White;
            txtPageCat.Location = new System.Drawing.Point(106, 185);
            txtPageCat.MaxLength = 9;
            txtPageCat.Name = "txtPageCat";
            txtPageCat.ReadOnly = true;
            txtPageCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPageCat.Size = new System.Drawing.Size(129, 20);
            txtPageCat.TabIndex = 114;
            // 
            // txtComment
            // 
            txtComment.AcceptsReturn = true;
            txtComment.BackColor = System.Drawing.Color.Black;
            txtComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtComment.ForeColor = System.Drawing.Color.White;
            txtComment.Location = new System.Drawing.Point(378, 161);
            txtComment.MaxLength = 41;
            txtComment.Name = "txtComment";
            txtComment.ReadOnly = true;
            txtComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtComment.Size = new System.Drawing.Size(161, 20);
            txtComment.TabIndex = 111;
            // 
            // cmbFabricant
            // 
            cmbFabricant.BackColor = System.Drawing.Color.Black;
            cmbFabricant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbFabricant.ForeColor = System.Drawing.Color.White;
            cmbFabricant.Location = new System.Drawing.Point(106, 57);
            cmbFabricant.Name = "cmbFabricant";
            cmbFabricant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbFabricant.Size = new System.Drawing.Size(129, 21);
            cmbFabricant.TabIndex = 93;
            cmbFabricant.SelectedIndexChanged += new System.EventHandler(cmbFabricant_SelectedIndexChanged);
            // 
            // txtFabricant
            // 
            txtFabricant.AcceptsReturn = true;
            txtFabricant.BackColor = System.Drawing.Color.Black;
            txtFabricant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtFabricant.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtFabricant.Enabled = false;
            txtFabricant.ForeColor = System.Drawing.Color.White;
            txtFabricant.Location = new System.Drawing.Point(105, 79);
            txtFabricant.MaxLength = 0;
            txtFabricant.Name = "txtFabricant";
            txtFabricant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtFabricant.Size = new System.Drawing.Size(110, 20);
            txtFabricant.TabIndex = 94;
            txtFabricant.Visible = false;
            // 
            // txtDescriptionEN
            // 
            txtDescriptionEN.AcceptsReturn = true;
            txtDescriptionEN.BackColor = System.Drawing.Color.Black;
            txtDescriptionEN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtDescriptionEN.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDescriptionEN.ForeColor = System.Drawing.Color.White;
            txtDescriptionEN.Location = new System.Drawing.Point(354, 89);
            txtDescriptionEN.MaxLength = 61;
            txtDescriptionEN.Name = "txtDescriptionEN";
            txtDescriptionEN.ReadOnly = true;
            txtDescriptionEN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDescriptionEN.Size = new System.Drawing.Size(305, 20);
            txtDescriptionEN.TabIndex = 107;
            // 
            // txtNoItem
            // 
            txtNoItem.AcceptsReturn = true;
            txtNoItem.BackColor = System.Drawing.Color.Black;
            txtNoItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoItem.ForeColor = System.Drawing.Color.White;
            txtNoItem.Location = new System.Drawing.Point(106, 113);
            txtNoItem.MaxLength = 0;
            txtNoItem.Name = "txtNoItem";
            txtNoItem.ReadOnly = true;
            txtNoItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoItem.Size = new System.Drawing.Size(129, 20);
            txtNoItem.TabIndex = 104;
            // 
            // _Label1_0
            // 
            _Label1_0.BackColor = System.Drawing.Color.Black;
            _Label1_0.ForeColor = System.Drawing.Color.White;
            _Label1_0.Location = new System.Drawing.Point(10, 113);
            _Label1_0.Name = "_Label1_0";
            _Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_0.Size = new System.Drawing.Size(89, 17);
            _Label1_0.TabIndex = 102;
            _Label1_0.Text = "Pièce :";
            // 
            // txtNoItemGRB
            // 
            txtNoItemGRB.BackColor = System.Drawing.Color.Black;
            txtNoItemGRB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtNoItemGRB.ForeColor = System.Drawing.Color.White;
            txtNoItemGRB.Location = new System.Drawing.Point(105, 142);
            txtNoItemGRB.Name = "txtNoItemGRB";
            txtNoItemGRB.Size = new System.Drawing.Size(130, 20);
            txtNoItemGRB.TabIndex = 138;
            // 
            // CatalogueElec
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1312, 665);
            Controls.Add(txtNoItemGRB);
            Controls.Add(lvwfournisseur);
            Controls.Add(CmdAnul);
            Controls.Add(CmdEnr);
            Controls.Add(txtCategorie);
            Controls.Add(cmdRechercherManufacturier);
            Controls.Add(chkInventaire);
            Controls.Add(fraQuantité);
            Controls.Add(cmbLocalisation);
            Controls.Add(Label2);
            Controls.Add(_Label1_7);
            Controls.Add(_Label1_6);
            Controls.Add(_Label1_4);
            Controls.Add(_Label1_3);
            Controls.Add(_Label1_1);
            Controls.Add(_Label1_25);
            Controls.Add(txtLocalisation);
            Controls.Add(txtDescriptionFR);
            Controls.Add(cmdTotal);
            Controls.Add(cmdRechercheJob);
            Controls.Add(cmdRechercheAchat);
            Controls.Add(lvwRechercheJob);
            Controls.Add(lvwCategorie);
            Controls.Add(Label4);
            Controls.Add(_Label1_10);
            Controls.Add(CmdRecherchecategorie);
            Controls.Add(lvwRechercheAchat);
            Controls.Add(cmdCopier);
            Controls.Add(cmdRechercheInventaire);
            Controls.Add(lvwDescription);
            Controls.Add(lvwFabricant);
            Controls.Add(lvwPieces);
            Controls.Add(cmdRechercherPiece);
            Controls.Add(cmdChangerCategorie);
            Controls.Add(cmdDemande);
            Controls.Add(cmdRechercheDescrFR);
            Controls.Add(txtTemps);
            Controls.Add(frafournisseur);
            Controls.Add(cmbCategorie);
            Controls.Add(cmbNoItem);
            Controls.Add(CmdModif);
            Controls.Add(CmdFerme);
            Controls.Add(CmdSupp);
            Controls.Add(CmdAdd);
            Controls.Add(txtPageCat);
            Controls.Add(txtComment);
            Controls.Add(cmbFabricant);
            Controls.Add(txtFabricant);
            Controls.Add(txtDescriptionEN);
            Controls.Add(txtNoItem);
            Controls.Add(_Label1_0);
            ForeColor = System.Drawing.Color.White;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CatalogueElec";
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Text = "ControleurServeur." + Name;
            ShowInTaskbar = false;
            Load += new System.EventHandler(FrmCatalogueElec_Load);
            fraQuantité.ResumeLayout(false);
            fraQuantité.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(imgSpain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgCanada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgEU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Image1)).EndInit();
            frafournisseur.ResumeLayout(false);
            frafournisseur.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        internal static System.Windows.Forms.TextBox txtTauxChange;
        internal static System.Windows.Forms.ListView lvwfournisseur;
        internal static System.Windows.Forms.Button cmdAddFrs;
        internal static System.Windows.Forms.Button cmdSuppFrs;
        internal static System.Windows.Forms.Button cmdModifFrs;
        internal static System.Windows.Forms.CheckBox chkquoter;
        internal static System.Windows.Forms.RadioButton optUSA;
        internal static System.Windows.Forms.RadioButton optCAN;
        internal static System.Windows.Forms.TextBox txtPrixList;
        internal static System.Windows.Forms.TextBox txtPrixNet;
        internal static System.Windows.Forms.TextBox txtPrixSpecial;
        internal static System.Windows.Forms.MaskedTextBox mskValide;
        internal static System.Windows.Forms.MaskedTextBox mskEscompte;
        internal static System.Windows.Forms.Button cmdEnrFrs;
        internal static System.Windows.Forms.Button CmdAnul;
        internal static System.Windows.Forms.CheckBox chkBoite;
        internal static System.Windows.Forms.TextBox txtQuantitéBoite;
        internal static System.Windows.Forms.TextBox txtQuantiteMinimum;
        internal static System.Windows.Forms.TextBox txtQuantiteStock;
        internal static System.Windows.Forms.CheckBox chkMinimum;
        internal static System.Windows.Forms.TextBox txtQuantiteCommande;
        internal static System.Windows.Forms.Label Label5;
        internal static System.Windows.Forms.Label Label11;
        internal static System.Windows.Forms.Button CmdEnr;
        internal static System.Windows.Forms.TextBox txtCategorie;
        internal static System.Windows.Forms.Button cmdRechercherManufacturier;
        internal static System.Windows.Forms.CheckBox chkInventaire;
        internal static GroupBox fraQuantité;
        internal static ComboBox cmbLocalisation;
        internal static System.Windows.Forms.Button cmdAnnulFrs;
        internal static System.Windows.Forms.Label Label2;
        internal static ComboBox cmbfrs;
        internal static ComboBox cmbPersRess;
        internal static System.Windows.Forms.RadioButton optSpain;
        internal static System.Windows.Forms.Label lblDevise2;
        internal static System.Windows.Forms.Label lblDevise1;
        internal static System.Windows.Forms.Label _Label1_5;
        internal static System.Windows.Forms.PictureBox imgSpain;
        internal static System.Windows.Forms.PictureBox imgCanada;
        internal static System.Windows.Forms.PictureBox imgEU;
        internal static System.Windows.Forms.Label _Label1_7;
        internal static System.Windows.Forms.Label _Label1_6;
        internal static System.Windows.Forms.Label _Label1_4;
        internal static System.Windows.Forms.Label _Label1_3;
        internal static System.Windows.Forms.Label _Label1_1;
        internal static System.Windows.Forms.Label _Label1_14;
        internal static System.Windows.Forms.Label _Label1_16;
        internal static System.Windows.Forms.Label _Label1_19;
        internal static System.Windows.Forms.Label _Label1_24;
        internal static System.Windows.Forms.Label _Label1_25;
        internal static System.Windows.Forms.Label _Label1_20;
        internal static System.Windows.Forms.Label _Label1_2;
        internal static System.Windows.Forms.TextBox txtLocalisation;
        internal static System.Windows.Forms.ComboBox txtDescriptionFR;
        internal static System.Windows.Forms.Button cmdTotal;
        internal static System.Windows.Forms.Button cmdRechercheJob;
        internal static System.Windows.Forms.Button cmdRechercheAchat;
        internal static System.Windows.Forms.PictureBox Image1;
        internal static System.Windows.Forms.Label Label4;
        internal static System.Windows.Forms.Label _Label1_10;
        internal static System.Windows.Forms.Label _Label1_23;
        internal static System.Windows.Forms.ToolTip ToolTip1;
        internal static System.Windows.Forms.ListView lvwCategorie;
        internal static System.Windows.Forms.Button CmdRecherchecategorie;
        internal static System.Windows.Forms.ListView lvwRechercheAchat;
        internal static System.Windows.Forms.ListView lvwRechercheJob;
        internal static System.Windows.Forms.Button cmdCopier;
        internal static System.Windows.Forms.Button cmdRechercheInventaire;
        internal static System.Windows.Forms.ListView lvwFabricant;
        internal static System.Windows.Forms.ListView lvwPieces;
        internal static System.Windows.Forms.ListView lvwDescription;
        internal static System.Windows.Forms.Button cmdRechercherPiece;
        internal static System.Windows.Forms.Button cmdChangerCategorie;
        internal static System.Windows.Forms.Button cmdDemande;
        internal static System.Windows.Forms.Button cmdRechercheDescrFR;
        internal static System.Windows.Forms.TextBox txtTemps;
        internal static System.Windows.Forms.GroupBox frafournisseur;
        internal static System.Windows.Forms.ComboBox cmbCategorie;
        internal static System.Windows.Forms.ComboBox cmbNoItem;
        internal static System.Windows.Forms.Button CmdModif;
        internal static System.Windows.Forms.Button CmdFerme;
        internal static System.Windows.Forms.Button CmdSupp;
        internal static System.Windows.Forms.Button CmdAdd;
        internal static System.Windows.Forms.TextBox txtPageCat;
        internal static System.Windows.Forms.TextBox txtComment;
        internal static System.Windows.Forms.ComboBox cmbFabricant;
        internal static System.Windows.Forms.TextBox txtFabricant;
        internal static System.Windows.Forms.TextBox txtDescriptionEN;
        internal static System.Windows.Forms.TextBox txtNoItem;
        internal static System.Windows.Forms.Label _Label1_0;
        internal static System.Windows.Forms.TextBox txtNoItemGRB;
        internal static System.Windows.Forms.ColumnHeader Fournisseur;
        internal static System.Windows.Forms.ColumnHeader PersRess;
        internal static System.Windows.Forms.ColumnHeader Date;
        internal static System.Windows.Forms.ColumnHeader Par;
        internal static System.Windows.Forms.ColumnHeader Valide;
        internal static System.Windows.Forms.ColumnHeader PrixListe;
        internal static System.Windows.Forms.ColumnHeader Escompte;
        internal static System.Windows.Forms.ColumnHeader PrixNet;
        internal static System.Windows.Forms.ColumnHeader PrixSP;
        internal static System.Windows.Forms.ColumnHeader Quoter;
        internal static System.Windows.Forms.TextBox NoItemGRB;
        internal static string m_sSelectCategorie;
        internal static string m_sSelectFabricant;
        internal static string m_sSelectNoItem;
        internal static string txtNoItemGRBText;
        internal static string txtDescriptionFRText;
        internal static string cmbCategorieText;
        private const int I_COL_DES_DESCR_FR = 0;
        private const int I_COL_DES_DESCR_EN = 1;
        private const int I_COL_DES_FABRICANT = 2;
        private const int I_COL_DES_PIECE = 3;
        private const int I_COL_PIECE_PIECE = 0;
        private const int I_COL_PIECE_FABRICANT = 1;
        private const int I_COL_PIECE_DESCR_FR = 2;
        private const int I_COL_PIECE_DESCR_EN = 3;
        private const int I_COL_MAN_FABRICANT = 0;
        private const int I_COL_MAN_PIECE = 1;
        private const int I_COL_MAN_DESCR_FR = 2;
        private const int I_COL_MAN_DESCR_EN = 3;
        private const int I_COL_FRS_FRS = 0;
        private const int I_COL_FRS_PERS_RESS = 1;
        private const int I_COL_FRS_DATE = 2;
        private const int I_COL_FRS_ENTRER_PAR = 3;
        private const int I_COL_FRS_VALIDE = 4;
        private const int I_COL_FRS_PRIX_LIST = 5;
        private const int I_COL_FRS_ESCOMPTE = 6;
        private const int I_COL_FRS_PRIX_NET = 7;
        private const int I_COL_FRS_PRIX_SP = 8;
        private const int I_COL_FRS_QUOTER = 9;
        private const int I_COL_JOB_NUMERO = 0;
        private const int I_COL_JOB_QUANTITE = 1;
        private const int I_COL_ACHAT_NUMERO = 0;
        private const int I_COL_ACHAT_QUANTITE = 1;
        internal EnumModeDemande m_eDemande;
        public bool m_bDemandeAnnuler;
        public bool m_bAjout;
        public bool m_bAnnulerCopie;
        public string m_sCategorieCopie;
        public bool m_bPieceEffacée;
        private bool m_bRempliManuel;
        private string m_sNoItem;
        private EnumModeCatalogueElec m_eMode;
        private bool m_bBloqueDescription;
        private string m_sQteStockAvant;
        private bool m_bCopiePiece;
        public string sChoisirTous;
        private string text1;
        private string text2;
        private string text3;
        private List<String> m_collPieceDescFR;
        /// <summary>
        /// Modification format date passe de 2 a 4octets
        /// </summary>
        public CatalogueElec()
        {
            InitializeComponent();
        }
        public CatalogueElec(string text1, string text2, string text3)
        {
            InitializeComponent();
            text1 = text1;
            text2 = text2;
            text3 = text3;
        }
        public void ViderChamps_frs()
        {
            try
            {
                cmbfrs.Items.Clear();
                txtPrixSpecial.Text = string.Empty;
                cmbPersRess.Items.Clear();
                txtPrixList.Text = string.Empty;
                mskEscompte.Text = string.Empty;
                txtPrixNet.Text = string.Empty;
                mskValide.Text = string.Empty;
                chkquoter.Checked = false;
                optCAN.Checked = true;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "ViderChamps_frs", ex); }
        }
        public void ViderChamps_piece()
        {
            try
            {
                txtNoItemGRB.Text = string.Empty;
                txtDescriptionEN.Text = string.Empty;
                txtTemps.Text = string.Empty;
                txtComment.Text = string.Empty;
                txtQuantitéBoite.Text = string.Empty;
                txtQuantiteCommande.Text = string.Empty;
                txtQuantiteMinimum.Text = string.Empty;
                txtQuantiteStock.Text = string.Empty;
                txtLocalisation.Text = string.Empty;
                cmbLocalisation.Text = "";
                chkBoite.Checked = false;
                chkInventaire.Checked = false;
                chkMinimum.Checked = false;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "ViderChamps_piece", ex); }
        }
        public void BarrerChamps_piece(bool bLocked)
        {
            try
            {
                txtNoItem.ReadOnly = bLocked;
                txtNoItemGRB.ReadOnly = bLocked;
                txtDescriptionEN.ReadOnly = bLocked;
                txtDescriptionFR.Enabled = bLocked;
                txtTemps.ReadOnly = bLocked;
                txtComment.ReadOnly = bLocked;
                frafournisseur.Enabled = bLocked;
                chkInventaire.Enabled = !bLocked;
                if (chkInventaire.Enabled == true) { if (chkInventaire.Checked) { fraQuantité.Enabled = true; } else { fraQuantité.Enabled = false; } }
                else
                {
                    fraQuantité.Enabled = false;
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "BarrerChamps_piece", ex); }
        }
        private void MontrerControles(EnumModeCatalogueElec eMode)
        {
            try
            {
                var bCategorie = default(bool);
                var bFabricant = default(bool);
                var bNoItem = default(bool);
                var bLocalisation = default(bool);
                var bCmdAddFRS = default(bool);
                var bCmdModifFRS = default(bool);
                var bCmdSuppFRS = default(bool);
                var bCmdEnrFRS = default(bool);
                var bCmdAnnulFRS = default(bool);
                var bCmdAdd = default(bool);
                var bCmdModif = default(bool);
                var bCmdSupp = default(bool);
                var bCmdFermer = default(bool);
                var bCmdEnr = default(bool);
                var bCmdAnnul = default(bool);
                var bFraFRS = default(bool);
                var bLvwFRS = default(bool);
                var bCmdSearchMan = default(bool);
                var bCmdSearchPiece = default(bool);
                var bCmdSearchDescr = default(bool);
                var bCmdDemande = default(bool);
                var bCmbDescFR = default(bool);
                var bCopier = default(bool);
                var bChangerCat = default(bool);
                var bInventaire = default(bool);
                m_eMode = eMode;
                switch (eMode)
                {
                    case EnumModeCatalogueElec.MODE_INACTIF:
                        {
                            bCategorie = true;
                            bFabricant = true;
                            bNoItem = true;
                            bCmdAddFRS = true;
                            bCmdModifFRS = true;
                            bCmdSuppFRS = true;
                            bCmdAdd = true;
                            bCmdModif = true;
                            bCmdSupp = true;
                            bCmdFermer = true;
                            bFraFRS = true;
                            bLvwFRS = true;
                            bCmdSearchMan = true;
                            bCmdSearchPiece = true;
                            bCmdSearchDescr = true;
                            bCmdDemande = true;
                            bCopier = true;
                            bInventaire = true;
                            bCmbDescFR = true;
                            break;
                        }
                    case EnumModeCatalogueElec.MODE_AJOUT_MODIF_ELEC:
                        {
                            bCmdAddFRS = true;
                            bCmdModifFRS = true;
                            bCmdSuppFRS = true;
                            bCmdEnr = true;
                            bFabricant = true;
                            txtFabricant.Enabled = true;
                            bCmdAnnul = true;
                            bLvwFRS = true;
                            bCmdSearchDescr = true;
                            bLocalisation = true;
                            bChangerCat = true;
                            break;
                        }
                    case EnumModeCatalogueElec.MODE_AJOUT_MODIF_FRS:
                        {
                            bCmdEnrFRS = true;
                            bCmdAnnulFRS = true;
                            bFraFRS = true;
                            break;
                        }
                }
                cmbCategorie.Visible = bCategorie;
                txtCategorie.Visible = !bCategorie;
                txtDescriptionFR.Visible = !bCmbDescFR;
                cmbFabricant.Visible = bFabricant;
                txtFabricant.Visible = bFabricant;
                cmbNoItem.Visible = bNoItem;
                txtNoItem.Visible = !bNoItem;
                cmbLocalisation.Visible = bLocalisation;
                txtLocalisation.Visible = !bLocalisation;
                frafournisseur.Enabled = bFraFRS;
                lvwfournisseur.Visible = bLvwFRS;
                cmdAddFrs.Visible = bCmdAddFRS;
                cmdModifFrs.Visible = bCmdModifFRS;
                cmdSuppFrs.Visible = bCmdSuppFRS;
                cmdEnrFrs.Visible = bCmdEnrFRS;
                cmdAnnulFrs.Visible = bCmdAnnulFRS;
                CmdAdd.Visible = bCmdAdd;
                CmdModif.Visible = bCmdModif;
                CmdSupp.Visible = bCmdSupp;
                CmdFerme.Visible = bCmdFermer;
                CmdEnr.Visible = bCmdEnr;
                CmdAnul.Visible = bCmdAnnul;
                cmdDemande.Visible = bCmdDemande;
                cmdCopier.Visible = bCopier;
                cmdRechercheDescrFR.Enabled = bCmdSearchDescr;
                cmdRechercherPiece.Enabled = bCmdSearchPiece;
                cmdRechercherManufacturier.Enabled = bCmdSearchMan;
                cmdChangerCategorie.Visible = bChangerCat;
                cmdRechercheInventaire.Visible = bInventaire;
                lblDevise1.Visible = false;
                txtTauxChange.Visible = false;
                lblDevise2.Visible = false;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "MontrerControles", ex); }
        }
        private void RemplirComboPersRess()
        {
            try
            {
                Recordset rstContact = new Recordset();
                cmbPersRess.Items.Clear();
                rstContact.Open($"SELECT DISTINCT IDCONTACT, NOMCONTACT, COMPAGNIE, TELEPHONNE, FAX, CELLULAIRE, PAGETTE, [E-MAIL], NOPOSTE, TELDOMICILE, DATECRÉATION, " +
                    $"USERCRÉATION, DATEMODIFICATION, USERMODIFICATION, TITRE, ENTRYIDOUTLOOK, SUPPRIMÉ FROM CONTACT " +
                    $"JOIN [DBO].[CONTACTFRS] ON [DBO].[CONTACTFRS].NOCONTACT=[DBO].[CONTACTFRS].NOCONTACT " +
                    $"WHERE NOFRS='{idFournisseur}' AND SUPPRIMÉ = 0 AND COMPAGNIE LIKE '%{cmbfrs.Text}%' " +
                    $"ORDER BY NOMCONTACT", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstContact.EOF)
                {
                    cmbPersRess.Items.Add(new ListItem() { Text = rstContact.Fields["NomContact"].Value, Value = rstContact.Fields["IDContact"].Value });
                    rstContact.MoveNext();
                }
                rstContact.Close();
                rstContact = null;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "RemplirComboPersRess", ex); }
        }
        private void chkBoite_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == EnumModeCatalogueElec.MODE_AJOUT_MODIF_ELEC) { txtQuantitéBoite.Enabled = chkBoite.Checked; }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "chkBoite_Click", ex); }
        }
        private void chkInventaire_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == EnumModeCatalogueElec.MODE_AJOUT_MODIF_ELEC)
                {
                    fraQuantité.Enabled = chkInventaire.Checked;
                    cmbLocalisation.Enabled = chkInventaire.Checked;
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "chkInventaire_Click", ex); }
        }
        private void chkMinimum_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == EnumModeCatalogueElec.MODE_AJOUT_MODIF_ELEC)
                {
                    txtQuantiteMinimum.Enabled = chkMinimum.Checked;
                    txtQuantiteCommande.Enabled = chkMinimum.Checked;
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "chkMinimum_Click", ex); }
        }
        private void RemplirComboDescription()
        {
            try
            {
                Recordset rstCatElec;
                string sPiece;
                string sCategorie;
                string sFabricant;
                if (m_collPieceDescFR.Count > 0) m_collPieceDescFR.Clear();
                txtDescriptionFR.Items.Clear();
                sCategorie = cmbCategorie.Text.Replace("'", "''");
                sFabricant = cmbFabricant.Text.Replace("'", "''");
                rstCatElec = new Recordset();
                if (sFabricant == "---")
                {
                    if (cmbCategorie.Text == "DIVERS" | sChoisirTous == ")")
                    {
                        rstCatElec.Open("SELECT * FROM CatalogueElec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY TRIM(PIECE)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstCatElec.Open("SELECT * FROM CatalogueElec WHERE CATEGORIE = '" + sCategorie + "'" + sChoisirTous + " ORDER BY TRIM(PIECE)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                }
                else
                {
                    rstCatElec.Open("SELECT * FROM CatalogueElec WHERE CATEGORIE = '" + sCategorie + "' AND FABRICANT = '" + sFabricant + "' ORDER BY TRIM(PIECE)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstCatElec.EOF)
                {
                    if (!(rstCatElec.Fields["DESC_FR"].Value is DBNull))
                    {
                        if (rstCatElec.Fields["DESC_FR"].Value != string.Empty)
                        {
                            txtDescriptionFR.Items.Add($"{rstCatElec.Fields["DESC_FR"].Value}");

                            sPiece = $"{rstCatElec.Fields["PIECE"].Value}";

                            m_collPieceDescFR.Add(sPiece);

                        }
                    }
                    rstCatElec.MoveNext();
                }
                rstCatElec.Close();
                rstCatElec = null;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "RemplirComboDescription", ex); }
        }
        private void txtDescriptionFR_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (txtDescriptionEN.Text == string.Empty) { txtDescriptionEN.Text = txtDescriptionFR.Text; }
            try
            {
                Recordset rstCatElec;
                string sNoItem;
                string sFabricant;
                int X;
                txtDescriptionFR.Text = txtDescriptionFR.Text;
                if (m_bBloqueDescription == false)
                {
                    for (X = 0; X < cmbNoItem.Items.Count; X++)
                    {
                        if ((cmbNoItem.Items[X].ToString() == m_collPieceDescFR[txtDescriptionFR.SelectedIndex + 1]))
                        {
                            cmbNoItem.SelectedIndex = X;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtDescriptionFR_Click", ex); }/**/
        }
        private void cmbfrs_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbfrs.SelectedIndex != -1)
                {
                    lvwfournisseur.Items.Clear();
                    Recordset rd = new Recordset();
                    rd.Open($"SELECT NOMFOURNISSEUR,REP,DATE,ENTRER_PAR,VALIDE,PRIX_LIST,ESCOMPTE,PRIX_NET,PRIX_SP,QUOTER,[DBO].[PIECESFRS].IDFRS  FROM [DBO].[CATALOGUEELEC] " +
                        $"JOIN [DBO].[PIECESFRS] ON[DBO].[CATALOGUEELEC].PIECE = PIECESFRS.PIECE " +
                        $"JOIN FOURNISSEUR ON[DBO].[PIECESFRS].IDFRS = [DBO].[FOURNISSEUR].IDFRS " +
                        $"WHERE[DBO].[CATALOGUEELEC].[CATEGORIE] LIKE'%{cmbCategorie.Text}%' and NomFournisseur like '%{cmbfrs.Text}%' " +
                        $"ORDER BY FABRICANT", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                    if (!rd.EOF) { int.TryParse($"{rd.Fields[10].Value}", out idFournisseur); } else { MessageBox.Show(cmbfrs.Text + " non trouvé"); return; }
                    while (!rd.EOF)
                    {
                        ListViewItem itm = lvwfournisseur.Items.Add(string.Empty);
                        itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                        itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                        itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                        itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                        itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                        itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                        itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                        itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                        itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}"));
                        itm.SubItems.Insert(9, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[9].Value}"));
                        rd.MoveNext();
                    }
                    idFournisseur = 0;
                    cmbfrs.Tag = idFournisseur;
                    RemplirComboPersRess();
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmbfrs_Click", ex); }
        }
        private void cmbLocalisation_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtLocalisation.Text = cmbLocalisation.Text;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmbLocalisation_Click", ex); }
        }
        private void CmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                m_bBloqueDescription = true;
                Form f = new AddItemElec();
                f.Icon = Conteneur.ActiveForm.Icon;
                f.Show();
                m_bBloqueDescription = false;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "CmdAdd_Click", ex); }
        }
        private void cmdAddFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbNoItem.Items.Count > 0)
                {
                    m_bAjout = true;
                    BarrerChamps_piece(true);
                    ViderChamps_frs();
                    cmbfrs.Focus();
                    MontrerControles(EnumModeCatalogueElec.MODE_AJOUT_MODIF_FRS);
                    AfficherDrapeau();
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdAddFrs_Click", ex); }/**/
        }
        private void cmdAnnulFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                MontrerControles(EnumModeCatalogueElec.MODE_INACTIF);
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdAnnulFrs_Click", ex); }
        }
        private void CmdAnul_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtPrixNet.Enabled = true;
                txtPrixSpecial.Enabled = true;
                m_bBloqueDescription = true;
                txtFabricant.Top = 200;
                cmbFabricant.Visible = true;
                AfficherItem();
                m_bBloqueDescription = false;
                m_bCopiePiece = false;
                cmbFabricant.Visible = false;
                cmbNoItem.Visible = false;
                MontrerControles(EnumModeCatalogueElec.MODE_INACTIF);
                BarrerChamps_piece(true);
                m_sQteStockAvant = "";
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "CmdAnul_Click", ex); }
        }
        private void EnregistrerItem()
        {
            try
            {
                Recordset rstItem;
                Recordset rstItemFRS;
                Recordset rstItemFRSDest;
                Recordset rstVerif;
                Recordset rstInventaire;
                Recordset rstInvModif;
                string sNomFab;
                string sNoPiece;
                int X;
                var sPieceModif = default(string);
                string sLettre;
                sNomFab = txtFabricant.Text;
                sNoPiece = txtNoItem.Text;
                if (m_bCopiePiece == true | m_bCopiePiece == false & (sNoPiece.ToUpper() ?? "") != (m_sNoItem.ToUpper() ?? ""))
                {
                    rstVerif = new Recordset();
                    rstVerif.Open("SELECT * FROM CatalogueElec WHERE PIECE = '" + sNoPiece.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstVerif.EOF) { MessageBox.Show("Le numéro " + sNoPiece + " existe déjà!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); rstVerif.Close(); rstVerif = null; return; }
                    rstVerif.Close();
                    rstVerif = null;
                }
                if (string.IsNullOrEmpty(txtFabricant.Text) | string.IsNullOrEmpty(txtNoItem.Text) | string.IsNullOrEmpty(txtDescriptionFR.Text))
                {
                    MessageBox.Show("Les champs Manufacturier, Pièce et Desc. FR doivent être remplis!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                rstItem = new Recordset();
                rstItem.Open($"SELECT * FROM CatalogueElec WHERE PIECE = '{m_sNoItem.Replace("'", "''")}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstItemFRS = new Recordset();
                rstItemFRS.Open($"SELECT * FROM PiecesFRS WHERE PIECE = '{$"{rstItem.Fields["PIECE"].Value}".Replace("'", "''")}' AND Type = 'E'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (m_bCopiePiece == false)
                {
                    while (!rstItemFRS.EOF) { rstItemFRS.Fields["PIECE"].Value = txtNoItem.Text; rstItemFRS.Update(); rstItemFRS.MoveNext(); }
                }
                else
                {
                    rstItemFRSDest = new Recordset();
                    rstItemFRSDest.Open("SELECT * FROM PiecesFRS", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstItemFRS.EOF) { rstItemFRSDest.AddNew(); rstItemFRSDest.Fields["IDFRS"].Value = rstItemFRS.Fields["IDFRS"].Value; rstItemFRSDest.Fields["PIECE"].Value = sNoPiece; rstItemFRSDest.Fields["PRIX_SP"].Value = rstItemFRS.Fields["PRIX_SP"].Value; rstItemFRSDest.Fields["PERS_RESS"].Value = rstItemFRS.Fields["PERS_RESS"].Value; rstItemFRSDest.Fields["PRIX_LIST"].Value = rstItemFRS.Fields["PRIX_LIST"].Value; rstItemFRSDest.Fields["ESCOMPTE"].Value = rstItemFRS.Fields["ESCOMPTE"].Value; rstItemFRSDest.Fields["PRIX_NET"].Value = rstItemFRS.Fields["PRIX_NET"].Value; rstItemFRSDest.Fields["DATE"].Value = rstItemFRS.Fields["DATE"].Value; rstItemFRSDest.Fields["ENTRER_PAR"].Value = rstItemFRS.Fields["ENTRER_PAR"].Value; rstItemFRSDest.Fields["VALIDE"].Value = rstItemFRS.Fields["VALIDE"].Value; rstItemFRSDest.Fields["QUOTER"].Value = rstItemFRS.Fields["QUOTER"].Value; rstItemFRSDest.Fields["DeviseMonétaire"].Value = rstItemFRS.Fields["DeviseMonétaire"].Value; rstItemFRSDest.Fields["Type"].Value = rstItemFRS.Fields["Type"].Value; rstItemFRSDest.Update(); rstItemFRS.MoveNext(); }
                    rstItemFRSDest.Close();
                    rstItemFRSDest = null;
                }
                rstItemFRS.Close();
                rstItemFRS = null;
                if (m_bCopiePiece == true) { rstItem.AddNew(); }
                rstItem.Fields["CATEGORIE"].Value = txtCategorie.Text;
                rstItem.Fields["PIECE"].Value = sNoPiece;
                for (X = 1; X <= sNoPiece.Length; X++) { if (sNoPiece[X] >= 48 & sNoPiece[X] <= 57 | sNoPiece[X] >= 65 & sNoPiece[X] <= 90 | sNoPiece[X] >= 97 & sNoPiece[X] <= 122) { sPieceModif = sPieceModif + sNoPiece[X]; } }
                rstItem.Fields["PIECE_MODIF"].Value = sPieceModif;
                rstItem.Fields["FABRICANT"].Value = sNomFab;
                rstItem.Fields["PIECE_GRB"].Value = txtNoItemGRB.Text;
                rstItem.Fields["DESC_EN"].Value = txtDescriptionEN.Text;
                rstItem.Fields["DESC_FR"].Value = txtDescriptionFR.Text;
                rstItem.Fields["TEMPS"].Value = txtTemps.Text;
                rstItem.Fields["COMMENTAIRE"].Value = txtComment.Text;
                rstItem.Update();
                rstItem.Close();
                rstItem = null;
                if (chkInventaire.Checked)
                {
                    rstInventaire = new Recordset();
                    if (m_bCopiePiece == true) { rstInventaire.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + sNoPiece.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); } else { rstInventaire.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + m_sNoItem.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                    if (rstInventaire.EOF) { rstInventaire.AddNew(); }
                    rstInventaire.Fields["NoItem"].Value = sNoPiece;
                    rstInventaire.Fields["Description"].Value = txtDescriptionFR.Text;
                    rstInventaire.Fields["Manufacturier"].Value = sNomFab;
                    if (chkBoite.Checked) { rstInventaire.Fields["CommandeParBoite"].Value = true; rstInventaire.Fields["QteBoite"].Value = txtQuantitéBoite.Text; } else { rstInventaire.Fields["CommandeParBoite"].Value = false; rstInventaire.Fields["QteBoite"].Value = ""; }
                    rstItemFRS = new Recordset();
                    rstItemFRS.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + sNoPiece.Replace("'", "''") + "' AND IDFRS = 717", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstItemFRS.EOF) { rstItemFRS.AddNew(); rstItemFRS.Fields["PIECE"].Value = sNoPiece; rstItemFRS.Fields["IDFRS"].Value = 717; rstItemFRS.Fields["Type"].Value = "E"; rstItemFRS.Fields["PERS_RESS"].Value = DBNull.Value; rstItemFRS.Fields["PRIX_LIST"].Value = "0"; rstItemFRS.Fields["ESCOMPTE"].Value = "0"; rstItemFRS.Fields["PRIX_NET"].Value = "0"; rstItemFRS.Fields["PrixReel"].Value = "0"; rstItemFRS.Fields["DATE"].Value = ConvertDate(DateTime.Today); rstItemFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text; rstItemFRS.Fields["DeviseMonétaire"].Value = "CAN"; rstItemFRS.Update(); }
                    if (chkBoite.Checked)
                    {
                        if (IsNumeric(rstItemFRS.Fields["PRIX_LIST"].Value)) { rstInventaire.Fields["Prix Liste"].Value = Math.Round(Operators.DivideObject(rstItemFRS.Fields["PRIX_LIST"].Value, double.Parse(txtQuantitéBoite.Text)), 6); }
                        else { rstInventaire.Fields["Prix Liste"].Value = "0"; }
                        if (IsNumeric(rstItemFRS.Fields["ESCOMPTE"].Value)) { rstInventaire.Fields["Escompte"].Value = rstItemFRS.Fields["Escompte"].Value; }
                        else { rstInventaire.Fields["Escompte"].Value = "0"; }
                        if (IsNumeric(rstItemFRS.Fields["PRIX_NET"].Value)) { rstInventaire.Fields["Prix net"].Value = Math.Round(Operators.DivideObject(rstItemFRS.Fields["PRIX_NET"].Value, double.Parse(txtQuantitéBoite.Text)), 6); }
                        else { rstInventaire.Fields["Prix net"].Value = "0"; }
                    }
                    else { rstInventaire.Fields["Prix Liste"].Value = rstItemFRS.Fields["PRIX_LIST"].Value; rstInventaire.Fields["Escompte"].Value = rstItemFRS.Fields["Escompte"].Value; rstInventaire.Fields["Prix net"].Value = rstItemFRS.Fields["PRIX_NET"].Value; }
                    rstItemFRS.Close();
                    rstItemFRS = null;
                    rstInventaire.Fields["Commentaires"].Value = txtComment.Text;
                    rstInventaire.Fields["Localisation"].Value = cmbLocalisation.Text;
                    if (!string.IsNullOrEmpty((txtQuantiteStock.Text))) { rstInventaire.Fields["QuantitéStock"].Value = txtQuantiteStock.Text; } else { rstInventaire.Fields["QuantitéStock"].Value = "0"; }
                    if (chkMinimum.Checked)
                    {
                        rstInventaire.Fields["Minimum"].Value = true;
                        if (!string.IsNullOrEmpty((txtQuantiteMinimum.Text))) { rstInventaire.Fields["QuantitéMinimum"].Value = txtQuantiteMinimum.Text; }
                        else { rstInventaire.Fields["QuantitéMinimum"].Value = "0"; }
                        /// modification pour erreur suite trim char 0x20 
                        /// PWE 2024-08-01
                        if (txtQuantiteCommande.Text.Trim().Length > 0) { rstInventaire.Fields["Commande"].Value = txtQuantiteCommande.Text; }
                        else { rstInventaire.Fields["Commande"].Value = "0"; }
                    }
                    else { rstInventaire.Fields["Minimum"].Value = false; rstInventaire.Fields["QuantitéMinimum"].Value = ""; rstInventaire.Fields["Commande"].Value = ""; }
                    rstInventaire.Update();
                    rstInventaire.Close();
                    rstInventaire = null;
                }
                else if (m_bCopiePiece == true) { UpdateSQL("DELETE FROM InventaireElec WHERE NoItem = '" + sNoPiece.Replace("'", "''") + "'"); }
                else
                {
                    UpdateSQL("DELETE FROM InventaireElec WHERE NoItem = '" + m_sNoItem.Replace("'", "''") + "'");
                }
                if (m_bCopiePiece == false)
                {
                    if ((txtQuantiteStock.Text ?? "") != (m_sQteStockAvant ?? "") | !string.IsNullOrEmpty(m_sQteStockAvant) & m_sQteStockAvant != "0" & chkInventaire.CheckState == CheckState.Unchecked)
                    {
                        if (string.IsNullOrEmpty(m_sQteStockAvant))
                        {
                            m_sQteStockAvant = "0";
                        }
                        if (!IsNumeric(txtQuantiteStock.Text))
                        {
                            txtQuantiteStock.Text = "0";
                        }
                        rstInvModif = new Recordset(); rstInvModif.Open("SELECT * FROM InventaireElecModif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); rstInvModif.AddNew(); rstInvModif.Fields["Date"].Value = ConvertDate(DateTime.Today); rstInvModif.Fields["IDProjet"].Value = Interaction.InputBox("Précisez l'ajustement d'inventaire"); rstInvModif.Fields["NoItem"].Value = txtNoItem.Text; if (chkInventaire.Checked) { rstInvModif.Fields["Quantité"].Value = double.Parse(txtQuantiteStock.Text) - double.Parse(m_sQteStockAvant); }
                        else { rstInvModif.Fields["Quantité"].Value = 0d - double.Parse(m_sQteStockAvant); }
                        rstInvModif.Fields["User"].Value = Conteneur.idInitiales.Text; rstInvModif.Update(); rstInvModif.Close(); rstInvModif = null;
                    }
                }
                if ((Strings.UCase(sNoPiece) ?? "") != (Strings.UCase(m_sNoItem) ?? "") & m_bCopiePiece == false) { ModifierNoItem(m_sNoItem, sNoPiece); }
                m_sQteStockAvant = "";
                m_bRempliManuel = true;
                m_sSelectNoItem = sNoPiece;
                m_sSelectFabricant = sNomFab;
                RemplirComboLocalisation();
                RemplirComboFabricant();
                MontrerControles(EnumModeCatalogueElec.MODE_INACTIF);
                BarrerChamps_piece(true);
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "EnregistrerItem", ex); }
        }
        private void cmdChangerCategorie_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Recordset rstPiece;
                Form f = new ChoixCategorie(EnumCatalogue.ELECTRIQUE);
                if ((txtCategorie.Text ?? "") != (m_sCategorieCopie ?? ""))
                {
                    if (m_bAnnulerCopie == false)
                    {
                        rstPiece = new Recordset();
                        rstPiece.Open("SELECT * FROM CatalogueElec WHERE PIECE = '" + cmbNoItem.Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstPiece.Fields["CATEGORIE"].Value = m_sCategorieCopie; rstPiece.Update(); rstPiece.Close(); rstPiece = null;
                        ViderChamps_piece(); m_sSelectFabricant = txtFabricant.Text; RemplirComboFabricant();
                        MontrerControles(EnumModeCatalogueElec.MODE_INACTIF); BarrerChamps_piece(true);
                    }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdChangerCategorie_Click", ex); }
        }
        private void cmdCopier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bCopiePiece = true;
                CmdModif_Click(CmdModif, new EventArgs());
                chkInventaire.Checked = false;
                chkBoite.Checked = false;
                chkMinimum.Checked = false;
                txtQuantitéBoite.Text = "";
                txtQuantiteStock.Text = "";
                txtQuantiteMinimum.Text = "";
                txtQuantiteCommande.Text = "";
                cmbLocalisation.Text = "";
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdCopier_Click", ex); }
        }
        private void CmdEnr_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                bool bContinuer;
                cmbFabricant.Visible = true;
                if ((txtNoItem.Text.ToUpper() ?? "") != (m_sNoItem.ToUpper() ?? "") & m_bCopiePiece == false) { if (MessageBox.Show("Le numéro de pièce sera modifié dans toutes les soumissions, les projets et les achats. \n\nVoulez-vous continuer ? ", "Surveillance des données", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) { bContinuer = true; } else { bContinuer = false; } }
                else
                {
                    bContinuer = true;
                }
                if (bContinuer == true)
                {
                    EnregistrerItem();
                    if (m_eMode == EnumModeCatalogueElec.MODE_INACTIF) { m_bCopiePiece = false; }
                    RemplirComboDescription();
                    m_bBloqueDescription = true;
                    for (X = 0; X < txtDescriptionFR.Items.Count; X++)
                    {
                        if ((txtDescriptionFR.Items[X].ToString() ?? "") == (txtDescriptionFR.Text ?? ""))
                        {
                            txtDescriptionFR.SelectedIndex = X; break;
                        }
                    }
                    m_bBloqueDescription = false;
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "CmdEnr_Click", ex); }
        }
        private void ModifierNoItem(string sAncienNoItem, string sNouveauNoItem)
        {
            try
            {
                var iRecordProjet = default(int);
                var iRecordSoum = default(int);
                var iRecordAchat = default(int);
                object argRecordsAffected = iRecordProjet;
                odbc.Execute("UPDATE Projet_Pieces SET NumItem = '" + sNouveauNoItem.Replace("'", "''") + "' WHERE NumItem = '" + sAncienNoItem.Replace("'", "''") + "' AND Type = 'E'", out argRecordsAffected);
                iRecordProjet = Conversions.ToShort(argRecordsAffected);
                object argRecordsAffected1 = iRecordSoum;
                odbc.Execute("UPDATE Soumission_Pieces SET NumItem = '" + sNouveauNoItem.Replace("'", "''") + "' WHERE NumItem = '" + sAncienNoItem.Replace("'", "''") + "' AND Type = 'E'", out argRecordsAffected1);
                iRecordSoum = Conversions.ToShort(argRecordsAffected1);
                object argRecordsAffected2 = iRecordAchat;
                odbc.Execute("UPDATE Achat_Pieces SET PIECE = '" + sNouveauNoItem.Replace("'", "''") + "' WHERE PIECE = '" + sAncienNoItem.Replace("'", "''") + "' AND Left(IDAchat, 1) <> 'M'", out argRecordsAffected2);
                iRecordAchat = Conversions.ToShort(argRecordsAffected2);
                UpdateSQL("UPDATE InventaireElecModif SET NoItem = '" + sNouveauNoItem.Replace("'", "''") + "' WHERE NoItem = '" + sAncienNoItem.Replace("'", "''") + "'");
                MessageBox.Show("Numéros de pièces modifiés\n\nProjets : " + iRecordProjet + "\nSoumissions : " + iRecordSoum + "\nAchats : " + iRecordAchat, Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "ModifierNoItem", ex); }
        }
        private void cmdEnrFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                // Enregistrement d'un Item dans la BD
                if (string.IsNullOrEmpty((txtPrixList.Text)) & string.IsNullOrEmpty((mskEscompte.Text)) & string.IsNullOrEmpty((txtPrixNet.Text)) & string.IsNullOrEmpty((txtPrixSpecial.Text)))
                {
                    txtPrixList.Text = "0";
                    mskEscompte.Text = "0";
                    txtPrixNet.Text = "0";
                }
                if (string.IsNullOrEmpty((txtPrixList.Text))) { if (string.IsNullOrEmpty((txtPrixSpecial.Text))) { MessageBox.Show("Vous devez remplir le prix listé!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; } }
                if (string.IsNullOrEmpty((txtPrixNet.Text)) & string.IsNullOrEmpty((txtPrixSpecial.Text)))
                {
                    MessageBox.Show("Vous devez remplir le prix net ou le prix spécial!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (optUSA.Checked == true | optSpain.Checked == true)
                {
                    if (!string.IsNullOrEmpty((txtTauxChange.Text)))
                    {
                        if (!IsNumeric(txtTauxChange.Text))
                        {
                            MessageBox.Show("Le taux de change doit être numérique!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else { MessageBox.Show("Le taux de change ne doit pas être vide!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                }
                if (((txtPrixNet.Text) ?? "") != ((txtPrixList.Text) ?? "") & string.IsNullOrEmpty((txtPrixSpecial.Text))) { CalculerPrixNet(); }
                if (cmbfrs.SelectedIndex > -1) { EnregistrerFRS(); }
                else
                {
                    MessageBox.Show("Vous devez choisir un fournisseur!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdEnrFrs_Click", ex); }
        }
        private void EnregistrerFRS()
        {

            try
            {
                Recordset rstItemFRS;
                Recordset rstInv;
                Recordset rstConfig;
                bool bDistribExiste;
                var X = default(int);
                if (!string.IsNullOrEmpty(txtPrixSpecial.Text)) { if (!IsNumeric(txtPrixSpecial.Text)) { MessageBox.Show("Le prix spécial est invalide!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; } }
                if (!string.IsNullOrEmpty(txtPrixNet.Text)) { if (!IsNumeric(txtPrixNet.Text)) { MessageBox.Show("Le prix net est invalide!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; } }
                if (!string.IsNullOrEmpty(txtPrixList.Text)) { if (!IsNumeric(txtPrixList.Text)) { MessageBox.Show("Le prix listé est invalide!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; } }
                if (!string.IsNullOrEmpty(mskValide.Text.Trim())) { if (!ValiderDate(mskValide.Text)) { MessageBox.Show("La date de validité est invalide!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; } }
                bDistribExiste = false;
                if (m_bAjout == true)
                {
                    if (lvwfournisseur.Items.Count > 0)
                    {
                        for (X = 0; X < lvwfournisseur.Items.Count; X++)
                        {
                            if (lvwfournisseur.Items[X].Text == cmbfrs.Text)
                            {
                                bDistribExiste = true; break;
                            }
                        }
                    }
                }
                rstItemFRS = new Recordset();
                if (m_bAjout == true)
                {
                    rstItemFRS.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + txtNoItem.Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstItemFRS.AddNew();
                    m_bAjout = false;
                }
                else
                {
                    rstItemFRS.Open("SELECT * FROM PiecesFRS WHERE noEnreg = " + lvwfournisseur.SelectedItems[0].Tag, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                rstItemFRS.Fields["PIECE"].Value = cmbNoItem.Text;
                rstItemFRS.Fields["IDFRS"].Value = GetFournisseurFromName(cmbfrs.Items[cmbfrs.SelectedIndex].ToString());
                rstItemFRS.Fields["Type"].Value = "E";
                if (cmbPersRess.SelectedIndex > -1) { rstItemFRS.Fields["PERS_RESS"].Value = (cmbPersRess.Items[cmbPersRess.SelectedIndex].ToString()); }
                else
                {
                    rstItemFRS.Fields["PERS_RESS"].Value = DBNull.Value;
                }
                rstItemFRS.Fields["PRIX_LIST"].Value = txtPrixList.Text;
                rstItemFRS.Fields["ESCOMPTE"].Value = mskEscompte.Text;
                if (!string.IsNullOrEmpty(txtPrixSpecial.Text) | !string.IsNullOrEmpty(txtPrixNet.Text))
                {
                    if (!string.IsNullOrEmpty(txtPrixNet.Text)) { rstItemFRS.Fields["PRIX_NET"].Value = txtPrixNet.Text; rstItemFRS.Fields["PrixReel"].Value = txtPrixNet.Text; } else { rstItemFRS.Fields["PRIX_NET"].Value = string.Empty; }
                    if (!string.IsNullOrEmpty(txtPrixSpecial.Text)) { rstItemFRS.Fields["PRIX_SP"].Value = txtPrixSpecial.Text; rstItemFRS.Fields["PrixReel"].Value = txtPrixNet.Text; } else { rstItemFRS.Fields["PRIX_SP"].Value = string.Empty; }
                }
                rstItemFRS.Fields["DATE"].Value = ConvertDate(DateTime.Today);
                rstItemFRS.Fields["VALIDE"].Value = mskValide.Text;
                rstItemFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                if ((int)chkquoter.CheckState == 1) { rstItemFRS.Fields["quoter"].Value = true; }
                else
                {
                    rstItemFRS.Fields["quoter"].Value = false;
                }
                if (optCAN.Checked == true) { rstItemFRS.Fields["devisemonétaire"].Value = "CAN"; }
                else if (optUSA.Checked == true) { rstItemFRS.Fields["DeviseMonétaire"].Value = "USA"; }
                else
                {
                    rstItemFRS.Fields["DeviseMonétaire"].Value = "SPA";
                }
                rstItemFRS.Update();
                rstItemFRS.Close();
                rstItemFRS = null;
                if (optUSA.Checked == true | optSpain.Checked == true)
                {
                    rstConfig = new Recordset();
                    rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (optUSA.Checked == true) { rstConfig.Fields["TauxAmericain"].Value = txtTauxChange.Text; } else { rstConfig.Fields["TauxEspagnol"].Value = txtTauxChange.Text; }
                    rstConfig.Update();
                    rstConfig.Close();
                    rstConfig = null;
                }
                MontrerControles(EnumModeCatalogueElec.MODE_INACTIF);
                if (GetFournisseurFromName(cmbfrs.Text) == "717")
                {
                    rstInv = new Recordset();
                    rstInv.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + txtNoItem.Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstInv.EOF)
                    {
                        if (!string.IsNullOrEmpty(txtPrixNet.Text))
                        {
                            if ((bool)rstInv.Fields["CommandeParBoite"].Value == true)
                            {
                                rstInv.Fields["Prix Liste"].Value = double.Parse(txtPrixList.Text) / double.Parse($"{rstInv.Fields["QteBoite"].Value}"); rstInv.Fields["Escompte"].Value = mskEscompte.Text; rstInv.Fields["Prix net"].Value = double.Parse(txtPrixNet.Text) / double.Parse($"{rstInv.Fields["QteBoite"].Value} ");
                            }
                            else
                            {
                                rstInv.Fields["Prix Liste"].Value = txtPrixList.Text; rstInv.Fields["Escompte"].Value = mskEscompte.Text; rstInv.Fields["Prix net"].Value = txtPrixNet.Text;
                            }
                        }
                        else if ((bool)rstInv.Fields["CommandeParBoite"].Value == true) { rstInv.Fields["Prix Liste"].Value = double.Parse(txtPrixSpecial.Text) / double.Parse($"{rstInv.Fields["QteBoite"].Value}"); rstInv.Fields["Escompte"].Value = ""; rstInv.Fields["Prix net"].Value = double.Parse(txtPrixSpecial.Text) / double.Parse($"{rstInv.Fields["QteBoite"].Value}"); }
                        else { rstInv.Fields["Prix Liste"].Value = txtPrixSpecial.Text; rstInv.Fields["Escompte"].Value = ""; rstInv.Fields["Prix net"].Value = txtPrixSpecial.Text; }
                        rstInv.Update();
                    }
                    rstInv.Close();
                    rstInv = null;
                }
                //                RemplirListViewFournisseur();
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "EnregistrerFRS", ex); }
        }
        private void CmdFerme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "CmdFerme_Click", ex); }
        }
        private void CmdModif_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbNoItem.Items.Count > 0)
                {
                    MontrerControles(EnumModeCatalogueElec.MODE_AJOUT_MODIF_ELEC);
                    txtFabricant.Top = 130;
                    cmbFabricant.Visible = false;
                    m_sQteStockAvant = txtQuantiteStock.Text;
                    BarrerChamps_piece(false);
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "CmdModif_Click", ex); }
        }
        private void cmdModifFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwfournisseur.Items.Count > 0) { ModifierFournisseur(); }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdModifFrs_Click", ex); }
        }
        private void cmdRechercheCategorie_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Recordset rstcatalog;
                string sDescription;
                ListViewItem itmDescription;
                sDescription = Interaction.InputBox("Quelle est la description à rechercher?", Application.ProductName + ".InterventionManuelle", "vivo per lei", CmdRecherchecategorie.Location.X, cmbCategorie.Location.Y + 25);
                if (!string.IsNullOrEmpty(sDescription))
                {
                    lvwCategorie.Items.Clear();
                    sDescription = sDescription.Replace("'", "''");
                    sDescription = "%" + sDescription + "%";
                    rstcatalog = new Recordset();
                    rstcatalog.Open("SELECT DISTINCT CATEGORIE FROM CatalogueElec " +
                        "WHERE  Categorie LIKE '" + sDescription + "'  " +
                        "ORDER BY CATEGORIE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstcatalog.EOF) { itmDescription = lvwCategorie.Items.Add(""); itmDescription.Tag = rstcatalog.Fields["CATEGORIE"].Value; itmDescription.Text = $"{rstcatalog.Fields["CATEGORIE"].Value}"; rstcatalog.MoveNext(); }
                    rstcatalog.Close();
                    rstcatalog = null;
                    if (lvwCategorie.Items.Count > 0) { lvwCategorie.Visible = true; lvwCategorie.Focus(); } else { MessageBox.Show("Aucun enregistrement trouvé!"); }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdRechercheDescrFR_Click", ex); }
        }
        private void cmdRechercheInventaire_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new ControleurServeur.InterfaceWeb($"RechercheInventaire?Catalogue={EnumCatalogue.ELECTRIQUE}");
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Icon = Conteneur.ActiveForm.Icon;
                f.Show();
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdRechercheInventaire_Click", ex); }
        }
        private void cmdRechercheAchat_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Recordset rstAchat;
                ListViewItem itmAchat;
                Cursor.Current = Cursors.WaitCursor;
                lvwRechercheAchat.Items.Clear();
                rstAchat = new Recordset();
                rstAchat.Open("SELECT DISTINCT (IDAchat + '-' + RIGHT('00' & IndexAchat,3)) As NumeroAchat, SUM(Qté) As QtéTotale FROM Achat_Pieces " +
                    "WHERE TRIM(PIECE) = '" + (txtNoItem.Text.Replace("'", "''")) + "' " +
                    "GROUP BY  (IDAchat + '-' + RIGHT('00' & IndexAchat,3))", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstAchat.EOF)
                {
                    itmAchat = lvwRechercheAchat.Items.Add("");
                    itmAchat.Text = $"{rstAchat.Fields["NumeroAchat"].Value}";
                    if (itmAchat.SubItems.Count > I_COL_ACHAT_QUANTITE) { itmAchat.SubItems[I_COL_ACHAT_QUANTITE].Text = $"{rstAchat.Fields["QtéTotale"].Value}"; } else { itmAchat.SubItems.Insert(I_COL_ACHAT_QUANTITE, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["QtéTotale"].Value}")); }

                    rstAchat.MoveNext();
                }
                rstAchat.Close();
                rstAchat = null;
                Cursor.Current = Cursors.Default;
                if (lvwRechercheAchat.Items.Count > 0)
                {
                    lvwRechercheAchat.Visible = true;
                    lvwRechercheAchat.Focus();
                }
                else
                {
                    MessageBox.Show("Cette pièce n'a jamais été utilisée dans les achats!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdRechercheAchat_Click", ex); }
        }
        private void cmdRechercheJob_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Recordset rstProjSoum;
                ListViewItem itmProjSoum;
                Cursor.Current = Cursors.WaitCursor;
                lvwRechercheJob.Items.Clear();
                rstProjSoum = new Recordset();
                rstProjSoum.Open("SELECT DISTINCT IDProjet, distinct (Qté) As QtéTotale FROM Projet_Pieces WHERE TRIM(NumItem) = '" + (txtNoItem.Text.Replace("'", "''")) + "' And Type = 'E' GROUP BY IDProjet", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstProjSoum.EOF)
                {
                    itmProjSoum = lvwRechercheJob.Items.Add("");
                    itmProjSoum.Text = $"{rstProjSoum.Fields["IDProjet"].Value}";
                    if (itmProjSoum.SubItems.Count > I_COL_JOB_QUANTITE) { itmProjSoum.SubItems[I_COL_JOB_QUANTITE].Text = $"{rstProjSoum.Fields["QtéTotale"].Value}"; } else { itmProjSoum.SubItems.Insert(I_COL_JOB_QUANTITE, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields["QtéTotale"].Value}")); }

                    rstProjSoum.MoveNext();
                }
                rstProjSoum.Close();
                rstProjSoum.Open("SELECT DISTINCT IDSoumission, distinct (Qté) As QtéTotale FROM Soumission_Pieces WHERE TRIM(NumItem) = '" + (txtNoItem.Text.Replace("'", "''")) + "' And Type = 'E' GROUP BY IDSoumission", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstProjSoum.EOF)
                {
                    itmProjSoum = lvwRechercheJob.Items.Add("");
                    itmProjSoum.Text = $"{rstProjSoum.Fields["IDSoumission"].Value}";
                    if (itmProjSoum.SubItems.Count > I_COL_JOB_QUANTITE) { itmProjSoum.SubItems[I_COL_JOB_QUANTITE].Text = $"{rstProjSoum.Fields["QtéTotale"].Value}"; } else { itmProjSoum.SubItems.Insert(I_COL_JOB_QUANTITE, new ListViewItem.ListViewSubItem(null, $"{rstProjSoum.Fields["QtéTotale"].Value}")); }

                    rstProjSoum.MoveNext();
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                Cursor.Current = Cursors.Default;
                if (lvwRechercheJob.Items.Count > 0)
                {
                    lvwRechercheJob.Visible = true;
                    lvwRechercheJob.Focus();
                }
                else
                {
                    MessageBox.Show("Cette pièce n'a jamais été utilisée dans les jobs!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdRechercheJob_Click", ex); }
        }
        private void cmdRechercherManufacturier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Recordset rstManufact;
                string sManufact;
                ListViewItem itmManufact;
                sManufact = Interaction.InputBox("Quel est le manufacturier à rechercher?");
                sManufact = sManufact.Replace("'", "''");
                if (!string.IsNullOrEmpty(sManufact))
                {
                    lvwFabricant.Items.Clear();
                    rstManufact = new Recordset();
                    rstManufact.Open("SELECT * FROM CatalogueElec where FABRICANT like '%" + sManufact + "%' ORDER BY FABRICANT", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstManufact.EOF)
                    {
                        itmManufact = lvwFabricant.Items.Add(""); itmManufact.Tag = rstManufact.Fields["CATEGORIE"].Value;
                        itmManufact.Text = ($"{rstManufact.Fields["FABRICANT"].Value}");
                        if (itmManufact.SubItems.Count > I_COL_MAN_PIECE)
                        {
                            itmManufact.SubItems[I_COL_MAN_PIECE].Text = ($"{rstManufact.Fields["PIECE"].Value}");
                        }
                        else
                        {
                            itmManufact.SubItems.Insert(I_COL_MAN_PIECE, new ListViewItem.ListViewSubItem(null, ($"{rstManufact.Fields["PIECE"].Value}")));
                        }
                        if (!(rstManufact.Fields["DESC_FR"].Value is DBNull))
                        {
                            if (itmManufact.SubItems.Count > I_COL_MAN_DESCR_FR)
                            {
                                itmManufact.SubItems[I_COL_MAN_DESCR_FR].Text = $"{rstManufact.Fields["DESC_FR"].Value}";
                            }
                            else
                            {
                                itmManufact.SubItems.Insert(I_COL_MAN_DESCR_FR, new ListViewItem.ListViewSubItem(null, ($"{rstManufact.Fields["DESC_FR"].Value}")));
                            }
                        }
                        else if (itmManufact.SubItems.Count > I_COL_MAN_DESCR_FR)
                        {
                            itmManufact.SubItems[I_COL_MAN_DESCR_FR].Text = string.Empty;
                        }
                        else
                        {
                            itmManufact.SubItems.Insert(I_COL_MAN_DESCR_FR, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        if (!(rstManufact.Fields["DESC_EN"].Value is DBNull))
                        {
                            if (itmManufact.SubItems.Count > I_COL_MAN_DESCR_EN)
                            {
                                itmManufact.SubItems[I_COL_MAN_DESCR_EN].Text = $"{rstManufact.Fields["DESC_EN"].Value}";
                            }
                            else
                            {
                                itmManufact.SubItems.Insert(I_COL_MAN_DESCR_EN, new ListViewItem.ListViewSubItem(null, ($"{rstManufact.Fields["DESC_EN"].Value}")));
                            }
                        }
                        else if (itmManufact.SubItems.Count > I_COL_MAN_DESCR_EN)
                        {
                            itmManufact.SubItems[I_COL_MAN_DESCR_EN].Text = string.Empty;
                        }
                        else
                        {
                            itmManufact.SubItems.Insert(I_COL_MAN_DESCR_EN, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        rstManufact.MoveNext();
                    }
                    rstManufact.Close();
                    rstManufact = null;
                    if (lvwFabricant.Items.Count > 0) { lvwFabricant.Visible = true; lvwFabricant.Focus(); } else { MessageBox.Show("Aucun enregistrement trouvé!"); }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdRechercherManufacturier_Click", ex); }
        }
        private void cmdRechercherPiece_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Recordset rstPiece;
                string sPiece;
                ListViewItem itmPiece;
                int X;
                var sPieceModif = default(string);
                sPiece = Interaction.InputBox("Quelle est la pièce à rechercher?");
                if (!string.IsNullOrEmpty(sPiece))
                {
                    for (X = 1; X <= sPiece.Length; X++)
                    {
                        if (sPiece[X] >= 48 & sPiece[X] <= 57 | sPiece[X] >= 65 & sPiece[X] <= 90 | sPiece[X] >= 97 & sPiece[X] <= 122)
                        {
                            sPieceModif = sPieceModif + sPiece[X];
                        }
                    }
                    lvwPieces.Items.Clear();
                    rstPiece = new Recordset();
                    rstPiece.Open("SELECT * FROM CatalogueElec " +
                        "WHERE PIECE_MODIF like '%" + sPieceModif + "%' " +
                        "ORDER BY PIECE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstPiece.EOF)
                    {
                        itmPiece = lvwPieces.Items.Add(string.Empty); itmPiece.Text = $"{rstPiece.Fields["PIECE"].Value}";

                        if (!(rstPiece.Fields["FABRICANT"].Value is DBNull))
                        {
                            if (itmPiece.SubItems.Count > I_COL_PIECE_FABRICANT) { itmPiece.SubItems[I_COL_PIECE_FABRICANT].Text = $"{rstPiece.Fields["FABRICANT"].Value}"; }
                            else { itmPiece.SubItems.Insert(I_COL_PIECE_FABRICANT, new ListViewItem.ListViewSubItem(null, ($"{rstPiece.Fields["FABRICANT"].Value}"))); }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_PIECE_FABRICANT) { itmPiece.SubItems[I_COL_PIECE_FABRICANT].Text = string.Empty; }
                        else { itmPiece.SubItems.Insert(I_COL_PIECE_FABRICANT, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        if (!(rstPiece.Fields["DESC_FR"].Value is DBNull))
                        {
                            if (itmPiece.SubItems.Count > I_COL_PIECE_DESCR_FR) { itmPiece.SubItems[I_COL_PIECE_DESCR_FR].Text = $"{rstPiece.Fields["DESC_FR"].Value}"; }
                            else { itmPiece.SubItems.Insert(I_COL_PIECE_DESCR_FR, new ListViewItem.ListViewSubItem(null, ($"{rstPiece.Fields["DESC_FR"].Value}"))); }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_PIECE_DESCR_FR) { itmPiece.SubItems[I_COL_PIECE_DESCR_FR].Text = string.Empty; }
                        else { itmPiece.SubItems.Insert(I_COL_PIECE_DESCR_FR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        if (!(rstPiece.Fields["DESC_EN"].Value is DBNull))
                        {
                            if (itmPiece.SubItems.Count > I_COL_PIECE_DESCR_EN) { itmPiece.SubItems[I_COL_PIECE_DESCR_EN].Text = $"{rstPiece.Fields["DESC_EN"].Value}"; }
                            else { itmPiece.SubItems.Insert(I_COL_PIECE_DESCR_EN, new ListViewItem.ListViewSubItem(null, ($"{rstPiece.Fields["DESC_EN"].Value}"))); }
                        }
                        else if (itmPiece.SubItems.Count > I_COL_PIECE_DESCR_EN) { itmPiece.SubItems[I_COL_PIECE_DESCR_EN].Text = string.Empty; }
                        else { itmPiece.SubItems.Insert(I_COL_PIECE_DESCR_EN, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmPiece.Tag = rstPiece.Fields["CATEGORIE"].Value; rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstPiece = null;
                    if (lvwPieces.Items.Count > 0) { lvwPieces.Visible = true; lvwPieces.Focus(); } else { MessageBox.Show("Aucun enregistrement trouvé!"); }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdRechercherPiece_Click", ex); }
        }
        private void cmdRechercheDescrFR_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Recordset rstDescription;
                string sDescription;
                ListViewItem itmDescription;
                sDescription = Interaction.InputBox("Quelle est la description à rechercher");
                if (!string.IsNullOrEmpty(sDescription))
                {
                    lvwDescription.Items.Clear();
                    sDescription = sDescription.Replace("'", "''");
                    sDescription = "%" + sDescription + "%";
                    rstDescription = new Recordset();
                    rstDescription.Open("SELECT * FROM CatalogueElec " +
                        "WHERE DESC_FR LIKE '" + sDescription + "' OR DESC_EN LIKE '" + sDescription + "' " +
                        "ORDER BY DESC_FR, DESC_EN", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstDescription.EOF)
                    {

                        itmDescription = lvwDescription.Items.Add("");
                        itmDescription.Tag = rstDescription.Fields["CATEGORIE"].Value;
                        if (!(rstDescription.Fields["DESC_FR"].Value is DBNull)) { itmDescription.Text = $"{rstDescription.Fields["DESC_FR"].Value}"; }
                        else { itmDescription.Text = string.Empty; }
                        if (!(rstDescription.Fields["DESC_EN"].Value is DBNull))
                        {
                            if (itmDescription.SubItems.Count > I_COL_DES_DESCR_EN) { itmDescription.SubItems[I_COL_DES_DESCR_EN].Text = $"{rstDescription.Fields["DESC_EN"].Value}"; }
                            else { itmDescription.SubItems.Insert(I_COL_DES_DESCR_EN, new ListViewItem.ListViewSubItem(null, ($"{rstDescription.Fields["DESC_EN"].Value}"))); }
                        }
                        else if (itmDescription.SubItems.Count > I_COL_DES_DESCR_EN) { itmDescription.SubItems[I_COL_DES_DESCR_EN].Text = string.Empty; }
                        else { itmDescription.SubItems.Insert(I_COL_DES_DESCR_EN, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        if (!(rstDescription.Fields["FABRICANT"].Value is DBNull))
                        {
                            if (itmDescription.SubItems.Count > I_COL_DES_FABRICANT) { itmDescription.SubItems[I_COL_DES_FABRICANT].Text = $"{rstDescription.Fields["FABRICANT"].Value}"; }
                            else { itmDescription.SubItems.Insert(I_COL_DES_FABRICANT, new ListViewItem.ListViewSubItem(null, ($"{rstDescription.Fields["FABRICANT"].Value}"))); }
                        }
                        else if (itmDescription.SubItems.Count > I_COL_DES_FABRICANT) { itmDescription.SubItems[I_COL_DES_FABRICANT].Text = string.Empty; }
                        else { itmDescription.SubItems.Insert(I_COL_DES_FABRICANT, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        if (itmDescription.SubItems.Count > I_COL_DES_PIECE) { itmDescription.SubItems[I_COL_DES_PIECE].Text = $"{rstDescription.Fields["PIECE"].Value}"; }
                        else { itmDescription.SubItems.Insert(I_COL_DES_PIECE, new ListViewItem.ListViewSubItem(null, ($"{rstDescription.Fields["PIECE"].Value}"))); }
                        rstDescription.MoveNext();
                    }
                    rstDescription.Close();
                    rstDescription = null;
                    if (lvwDescription.Items.Count > 0) { lvwDescription.Visible = true; lvwDescription.Focus(); } else { MessageBox.Show("Aucun enregistrement trouvé!"); }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdRechercheDescrFR_Click", ex); }
        }
        private void cmdTotal_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sAnnee;
                Recordset rstTotal;
                double dblTotalProj;
                double dblTotalAchat;
                sAnnee = Interaction.InputBox("Pour quelle année? (AAAA)");
                if (sAnnee.Length == 4)
                {
                    if (IsNumeric(sAnnee))
                    {
                        if (short.Parse(sAnnee) <= DateTime.Today.Year)
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            rstTotal = new Recordset();
                            rstTotal.Open("SELECT distinct (Qté) As Total FROM Projet_Pieces " +
                                "INNER JOIN ProjetElec ON Projet_Pieces.IDProjet = ProjetElec.IDProjet " +
                                "WHERE TRIM(NumItem) = '" + (txtNoItem.Text.Replace("'", "''")) + "' AND Type = 'E' AND Left(Creer,4) = '" + sAnnee + "' AND RIGHT(Projet_Pieces.IDProjet,2) < '60'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (!(rstTotal.Fields["Total"].Value is DBNull))
                            {
                                dblTotalProj = double.Parse($"{rstTotal.Fields["Total"].Value} ");
                            }
                            else
                            {
                                dblTotalProj = 0d;
                            }
                            rstTotal.Close();
                            rstTotal.Open("SELECT distinct (Qté) As Total FROM Achat_Pieces " +
                                "INNER JOIN Achat ON Achat_Pieces.IDAchat = Achat.IDAchat AND Achat_Pieces.IndexAchat = Achat.IndexAchat " +
                                "WHERE TRIM(PIECE) = '" + (txtNoItem.Text.Replace("'", "''")) + "' AND Left(DateAchat,4) = '" + sAnnee + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (!(rstTotal.Fields["Total"].Value is DBNull))
                            {
                                dblTotalAchat = double.Parse($"{rstTotal.Fields["Total"].Value} ");
                            }
                            else
                            {
                                dblTotalAchat = 0d;
                            }
                            rstTotal.Close();
                            rstTotal = null;
                            Cursor.Current = Cursors.Default;
                            MessageBox.Show("Quantité utilisée en " + sAnnee + " : \n\nProjets : " + dblTotalProj + "\nAchats : " + dblTotalAchat);
                        }
                        else
                        {
                            MessageBox.Show("Année trop grande!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Année non numérique!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Strings.Len(sAnnee) != 0)
                {
                    MessageBox.Show("L'année doit être sur 4 chiffres!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdTotal_Click", ex); }
        }
        private void FrmCatalogueElec_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                lvwDescription.Visible = false;
                lvwFabricant.Visible = false;
                lvwPieces.Visible = false;
                lvwRechercheJob.Visible = false;
                lvwRechercheAchat.Visible = false;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "Form_Click", ex); }
        }
        private void fraApprob_Click()
        {
            try
            {
                lvwDescription.Visible = false;
                lvwFabricant.Visible = false;
                lvwPieces.Visible = false;
                lvwRechercheJob.Visible = false;
                lvwRechercheAchat.Visible = false;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "fraApprob_Click", ex); }
        }
        private void frafournisseur_Click()
        {
            try
            {
                lvwDescription.Visible = false;
                lvwFabricant.Visible = false;
                lvwPieces.Visible = false;
                lvwRechercheJob.Visible = false;
                lvwRechercheAchat.Visible = false;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "fraFournisseur_Click", ex); }
        }
        private void fraQuantité_Click()
        {
            try
            {
                lvwDescription.Visible = false;
                lvwFabricant.Visible = false;
                lvwPieces.Visible = false;
                lvwRechercheJob.Visible = false;
                lvwRechercheAchat.Visible = false;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "fraQuantité_Click", ex); }
        }
        private void lvwCategorie_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            ListViewItem itmDescription;
            int X;
            if (lvwCategorie.Items.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                itmDescription = lvwCategorie.SelectedItems[0];
                cmbCategorie.Text = lvwCategorie.SelectedItems[0].Text;
                cmbCategorie_SelectedIndexChanged_1(cmbCategorie, new EventArgs());
                lvwCategorie.Visible = false;
                Cursor.Current = Cursors.Default;
            }
            return;
        }
        private void lvwCategorie_LostFocus()
        {
            try
            {
                if (lvwCategorie.Visible == true) { lvwCategorie.Visible = false; }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwCategorie_LostFocus", ex); }
        }
        private void lvwDescription_KeyDown(ref int KeyCode, ref int Shift)
        {
            try
            {
                if (KeyCode == (int)Keys.Delete) { lvwDescription_DoubleClick(lvwDescription, new EventArgs()); }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwDescription_KeyDown", ex); }
        }
        private void lvwFabricant_KeyDown(ref int KeyCode, ref int Shift)
        {
            try
            {
                if (KeyCode == (int)Keys.Delete) { lvwFabricant_DoubleClick(lvwFabricant, new EventArgs()); }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwFabricant_KeyDown", ex); }
        }
        private void lvwPieces_KeyDown(ref int KeyCode, ref int Shift)
        {
            try
            {
                if (KeyCode == (int)Keys.Delete) { lvwPieces_DoubleClick(lvwPieces, new EventArgs()); }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwPieces_KeyDown", ex); }
        }
        private void lvwFabricant_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ListViewItem itmFabricant;
                int X;
                Cursor.Current = Cursors.WaitCursor;
                itmFabricant = lvwFabricant.SelectedItems[0];
                m_sSelectCategorie = ((string)(itmFabricant.Tag));
                m_sSelectFabricant = (itmFabricant.Text);
                m_sSelectNoItem = (itmFabricant.SubItems[I_COL_MAN_PIECE].Text);
                RemplirComboCategorie();
                for (X = 0; X < cmbCategorie.Items.Count; X++) { if ((cmbCategorie.Items[X].ToString() ?? "") == (((string)(itmFabricant.Tag)) ?? "")) { cmbCategorie.SelectedIndex = X; break; } }
                for (X = 0; X <= (cmbNoItem.Items.Count - 1); X++) { if ((cmbNoItem.Items[X].ToString() ?? "") == ((itmFabricant.SubItems[I_COL_MAN_PIECE].Text) ?? "")) { cmbNoItem.SelectedIndex = X; break; } }
                lvwFabricant.Visible = false;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwFabricant_DblClick", ex); }
        }
        private void lvwDescription_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ListViewItem itmDescription;
                int X;
                if (lvwDescription.Items.Count > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    itmDescription = lvwDescription.SelectedItems[0];
                    m_sSelectCategorie = (string)(itmDescription.Tag);
                    m_sSelectFabricant = (itmDescription.SubItems[I_COL_DES_FABRICANT].Text);
                    m_sSelectNoItem = (itmDescription.SubItems[I_COL_DES_PIECE].Text);
                    if (m_eMode == EnumModeCatalogueElec.MODE_INACTIF) { RemplirComboCategorie(); }
                    else
                    {
                        txtDescriptionFR.Text = itmDescription.Text;
                        txtDescriptionEN.Text = itmDescription.SubItems[I_COL_DES_DESCR_EN].Text;
                    }
                    lvwDescription.Visible = false;
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwDescription_DblClick", ex); }
        }
        private void lvwFabricant_LostFocus()
        {
            try
            {
                if (lvwFabricant.Visible == true) { lvwFabricant.Visible = false; }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwFabricant_LostFocus", ex); }
        }
        private void lvwPieces_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ListViewItem itmPieces;
                int X;
                Cursor.Current = Cursors.WaitCursor;
                itmPieces = lvwPieces.SelectedItems[0];
                m_sSelectCategorie = ((string)(itmPieces.Tag));
                m_sSelectFabricant = (itmPieces.SubItems[I_COL_PIECE_FABRICANT].Text);
                m_sSelectNoItem = (itmPieces.Text);
                RemplirComboCategorie();
                lvwPieces.Visible = false;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwPieces_DblClick", ex); }
        }
        private void CmdSupp_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sDescription;
                int X;
                if (cmbNoItem.Items.Count > 0)
                {
                    if (MessageBox.Show("Voulez-vous vraiment effacer la pièce " + txtNoItem.Text + "?", "Surveillance des données", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (chkInventaire.Checked)
                        {
                            UpdateSQL("DELETE FROM InventaireElec " +
   "WHERE NoItem = '" + cmbNoItem.Items[cmbNoItem.SelectedIndex].ToString().Replace("'", "''") + "'");
                        }
                        UpdateSQL("DELETE FROM CatalogueElec " +
                            "WHERE PIECE = '" + cmbNoItem.Items[cmbNoItem.SelectedIndex].ToString().Replace("'", "''") + "'");
                        UpdateSQL("DELETE FROM PiecesFRS " +
                            "WHERE PIECE = '" + cmbNoItem.Items[cmbNoItem.SelectedIndex].ToString().Replace("'", "''") + "'");
                        m_bRempliManuel = true; m_sSelectNoItem = string.Empty;
                        if (cmbNoItem.Items.Count > 1) { m_sSelectFabricant = cmbFabricant.Text; } else { m_sSelectFabricant = string.Empty; }
                        RemplirComboFabricant(); if (cmbFabricant.Items.Count == 0)
                        {
                            cmbNoItem.Items.Clear(); cmbCategorie.Items.RemoveAt(cmbCategorie.SelectedIndex);
                            if (cmbCategorie.Items.Count > 0) { cmbCategorie.SelectedIndex = 0; } else { ViderChamps_frs(); lvwfournisseur.Items.Clear(); ViderChamps_piece(); }
                        }
                        sDescription = txtDescriptionFR.Text;
                        for (X = 0; X < txtDescriptionFR.Items.Count; X++)
                        {
                            if ((txtDescriptionFR.Items[X].ToString() ?? "") == (sDescription ?? "")) { m_bBloqueDescription = true; txtDescriptionFR.SelectedIndex = X; m_bBloqueDescription = false; break; }
                        }
                    }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "CmdSupp_Click", ex); }
        }
        private void AfficherItem()
        {
            Recordset rstItem;
            Recordset rstInventaire;
            int X;
            ViderChamps_piece();
            rstItem = new Recordset();
            rstItem.Open("SELECT * FROM CatalogueElec " +
                "WHERE PIECE = '" + m_sNoItem.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            if (!rstItem.EOF)
            {
                if (!(rstItem.Fields["PIECE_GRB"].Value is DBNull)) { txtNoItemGRB.Text = $"{rstItem.Fields["PIECE_GRB"].Value}"; }
                if (!(rstItem.Fields["DESC_EN"].Value is DBNull)) { txtDescriptionEN.Text = $"{rstItem.Fields["DESC_EN"].Value}"; }
                else { txtDescriptionEN.Text = string.Empty; }
                if (!(rstItem.Fields["FABRICANT"].Value is DBNull)) { txtFabricant.Text = $"{rstItem.Fields["FABRICANT"].Value}"; }
                else { txtFabricant.Text = string.Empty; }
                if (!(rstItem.Fields["DESC_FR"].Value is DBNull))
                {
                    for (X = 0; X <= (txtDescriptionFR.Items.Count - 1); X++)
                    {
                        if ((txtDescriptionFR.Items[X].ToString() ?? "") == ($"{rstItem.Fields["DESC_FR"].Value}".Trim() ?? "")) { txtDescriptionFR.SelectedIndex = X; break; }
                    }
                }
                else if (txtDescriptionFR.SelectedIndex == -1) { txtDescriptionFR_SelectedIndexChanged(txtDescriptionFR, new EventArgs()); } else { txtDescriptionFR.SelectedIndex = -1; }
                if (!(rstItem.Fields["TEMPS"].Value is DBNull)) { txtTemps.Text = $"{rstItem.Fields["TEMPS"].Value}"; }
                if (!(rstItem.Fields["COMMENTAIRE"].Value is DBNull)) { txtComment.Text = $"{rstItem.Fields["COMMENTAIRE"].Value}"; }
                MessageBox.Show("Impossible de trouver la pièce!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            rstItem.Close();
            rstItem = null;
            rstInventaire = new Recordset();
            rstInventaire.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + txtNoItem.Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            if (!rstInventaire.EOF)
            {
                chkInventaire.CheckState = CheckState.Checked;
                chkBoite.CheckState = (CheckState)Math.Abs(Conversions.ToShort(rstInventaire.Fields["CommandeParBoite"].Value));
                if (chkBoite.Checked) { txtQuantitéBoite.Text = $"{rstInventaire.Fields["QteBoite"].Value}"; }
                for (X = 0; X < cmbLocalisation.Items.Count; X++)
                {
                    if (cmbLocalisation.Items[X].ToString() == rstInventaire.Fields["Localisation"].Value) { cmbLocalisation.SelectedIndex = X; break; }
                }
                txtQuantiteStock.Text = $"{rstInventaire.Fields["QuantitéStock"].Value}";
                chkMinimum.CheckState = (CheckState)Math.Abs(Conversions.ToShort(rstInventaire.Fields["Minimum"].Value));
                txtQuantiteMinimum.Text = $"{rstInventaire.Fields["QuantitéMinimum"].Value}";
                txtQuantiteCommande.Text = $"{rstInventaire.Fields["Commande"].Value}";
            }
            rstInventaire.Close();
            rstInventaire = null;
        }
        private void AfficherFRS()
        {
            try
            {
                Recordset rstItemFRS;
                int X;
                rstItemFRS = new Recordset();
                rstItemFRS.Open("SELECT * FROM PiecesFRS WHERE NoEnreg = " + lvwfournisseur.SelectedItems[0].Tag, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                for (X = 0; X <= (cmbfrs.Items.Count - 1); X++) { if (cmbfrs.Items[X].ToString() == lvwfournisseur.SelectedItems[0].Text) { cmbfrs.SelectedIndex = X; break; } }
                if (!(rstItemFRS.Fields["PERS_RESS"].Value is DBNull))
                {
                    for (X = 0; X < cmbPersRess.Items.Count; X++)
                    {
                        if (GetPersRess(cmbPersRess.Items[X].ToString()) == (int)rstItemFRS.Fields["PERS_RESS"].Value)
                        {
                            cmbPersRess.SelectedIndex = X; break;
                        }
                    }
                }
                else
                {
                    cmbPersRess.SelectedIndex = -1;
                }
                if (!(rstItemFRS.Fields["PRIX_LIST"].Value is DBNull)) { txtPrixList.Text = $"{rstItemFRS.Fields["PRIX_LIST"].Value}"; }
                if (!(rstItemFRS.Fields["ESCOMPTE"].Value is DBNull)) { mskEscompte.Text = $"{rstItemFRS.Fields["ESCOMPTE"].Value}"; }
                if (!(rstItemFRS.Fields["PRIX_NET"].Value is DBNull)) { txtPrixNet.Text = $"{rstItemFRS.Fields["PRIX_NET"].Value}"; }
                if (!(rstItemFRS.Fields["PRIX_SP"].Value is DBNull)) { txtPrixSpecial.Text = $"{rstItemFRS.Fields["PRIX_SP"].Value}"; }
                if (!(rstItemFRS.Fields["VALIDE"].Value is DBNull)) { mskValide.Text = $"{rstItemFRS.Fields["VALIDE"].Value}"; }
                if ((bool)rstItemFRS.Fields["quoter"].Value == true) { chkquoter.Checked = true; } else { chkquoter.Checked = false; }
                if ($"{rstItemFRS.Fields["DeviseMonétaire"].Value}" == "CAN") { optCAN.Checked = true; }
                else if ($"{rstItemFRS.Fields["DeviseMonétaire"].Value}" == "USA") { optUSA.Checked = true; }
                else { optSpain.Checked = true; }
                AfficherDrapeau();
                rstItemFRS.Close();
                rstItemFRS = null;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "AfficherFRS", ex); }
        }
        private void cmbNoItem_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                txtNoItem.Text = cmbNoItem.Text;
                m_sNoItem = txtNoItem.Text;
                txtNoItemGRB.Text = txtNoItem + "GRB";
                m_bBloqueDescription = true;
                AfficherItem();
                m_bBloqueDescription = false;
                Conteneur.txtStatus.Text = "Recherche infos sur la piece " + m_sNoItem;
                RemplirComboFRS();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmbNoItem_Click", ex); }
        }
        private void cmbFabricant_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                txtFabricant.Text = cmbFabricant.Text;
                RemplirComboDescription();
                m_bBloqueDescription = true;
                if (m_bRempliManuel == true) { RemplirComboNoItem(); m_bRempliManuel = false; } else { RemplirComboNoItem(); }
                m_bBloqueDescription = false;
                Cursor.Current = Cursors.Default;
                if (sChoisirTous == ")") { RemplirComboCategorie(); }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmbFabricant_Click", ex); }
        }
        private void cmdSuppFrs_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwfournisseur.Items.Count > 0) { SupprimerFournisseur(); }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdSuppFrs_Click", ex); }
        }
        private void FrmCatalogueElec_Load(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ActiverBoutonsGroupe();
                if (manufacturiers.Count > 0) { foreach (ListItem p in manufacturiers) { cmbFabricant.Items.Add(p); } }
                m_bBloqueDescription = true;
                m_collPieceDescFR = new List<String>();
                BarrerChamps_piece(true);
                MontrerControles(EnumModeCatalogueElec.MODE_INACTIF);
                RemplirComboLocalisation();
                RemplirComboCategorie();
                m_bBloqueDescription = false;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "Form_Load", ex); }
        }
        private void ActiverBoutonsGroupe()
        {
            try
            {
                CmdAdd.Enabled = (g_bModificationCatalogueElec);
                CmdSupp.Enabled = (g_bModificationCatalogueElec);
                CmdModif.Enabled = (g_bModificationCatalogueElec);
                cmdAddFrs.Enabled = (g_bModificationCatalogueElec);
                cmdSuppFrs.Enabled = (g_bModificationCatalogueElec);
                cmdModifFrs.Enabled = (g_bModificationCatalogueElec);
                cmdDemande.Enabled = (g_bModificationCatalogueElec);
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "ActiverBoutonsGroupe", ex); }
        }
        public void RemplirComboFabricant()
        {
            try
            {
                Recordset rstFabricant;
                string sCategorie;
                int X;
                sCategorie = cmbCategorie.Text.Replace("'", "''");
                rstFabricant = new Recordset();
                rstFabricant.Open("SELECT DISTINCT FABRICANT FROM CatalogueElec " +
                    "WHERE CATEGORIE = '" + sCategorie + "' " +
                    "ORDER BY FABRICANT", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbFabricant.Items.Clear();
                sChoisirTous = "";
                cmbFabricant.Items.Add("-- CHOISIR TOUS --");
                if (!rstFabricant.EOF) { rstFabricant.MoveFirst(); }
                while (!rstFabricant.EOF)
                {
                    if (!(rstFabricant.Fields["Fabricant"].Value is DBNull))
                    {
                        cmbFabricant.Items.Add(($"{rstFabricant.Fields["FABRICANT"].Value}"));
                        if (string.IsNullOrEmpty(sChoisirTous)) { sChoisirTous = $" AND(FABRICANT = '{rstFabricant.Fields["FABRICANT"].Value}'"; } else { sChoisirTous = sChoisirTous + $" OR FABRICANT = '{rstFabricant.Fields["FABRICANT"].Value}'"; }
                    }
                    rstFabricant.MoveNext();
                }
                sChoisirTous = sChoisirTous + ")";
                rstFabricant.Close();
                rstFabricant = null;
                if (cmbFabricant.Items.Count > 0)
                {
                    if (!string.IsNullOrEmpty(m_sSelectFabricant))
                    {
                        for (X = 0; X < (cmbFabricant.Items.Count - 1); X++)
                        {
                            if ((cmbFabricant.Items[X].ToString().ToUpper() ?? "") == (m_sSelectFabricant.ToUpper() ?? ""))
                            {
                                cmbFabricant.SelectedIndex = X; m_sSelectFabricant = ""; break;
                            }
                        }
                    }
                    else { cmbFabricant.SelectedIndex = 0; }
                }
                else
                {
                    cmbNoItem.Items.Clear();
                    txtDescriptionFR.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                ;
                AfficherErreur("CatalogueElec", "RemplirComboFabricant", ex);
            }
        }
        public void AfficherForm(string sCategorie, string sNomFab, string sNoItem)
        {
            try
            {
                int X;
                BarrerChamps_piece(true);
                MontrerControles(EnumModeCatalogueElec.MODE_INACTIF);
                RemplirComboCategorie();
                if (!string.IsNullOrEmpty(sCategorie))
                {
                    for (X = 0; X <= (cmbCategorie.Items.Count - 1); X++)
                    {
                        if ((cmbCategorie.Items[X].ToString() ?? "") == (sCategorie ?? ""))
                        {
                            cmbCategorie.SelectedIndex = X; break;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(sNomFab))
                {
                    for (X = 0; X <= (cmbFabricant.Items.Count - 1); X++)
                    {
                        if ((cmbFabricant.Items[X].ToString() ?? "") == (sNomFab ?? ""))
                        {
                            cmbFabricant.SelectedIndex = X; break;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(sNoItem))
                {
                    for (X = 0; X <= (cmbNoItem.Items.Count - 1); X++)
                    {
                        if ((cmbNoItem.Items[X].ToString() ?? "") == (sNoItem ?? ""))
                        {
                            cmbNoItem.SelectedIndex = X; break;
                        }
                    }
                }
                Show();
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "AfficherForm", ex); }
        }
        public void RemplirComboNoItem()
        {
            try
            {
                int X;
                string sCategorie = cmbCategorie.Text.Replace("'", "''");
                string sFabricant = cmbFabricant.Text.Replace("'", "''");
                Recordset rstNoItem = new Recordset();
                if (cmbCategorie.Text == "DIVERS" | sChoisirTous == ")") { rstNoItem.Open("SELECT PIECE FROM CatalogueElec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY TRIM(PIECE)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic); }
                else if (sFabricant == " ")
                {
                    rstNoItem.Open("SELECT PIECE FROM CatalogueElec " +
"WHERE CATEGORIE = '" + sCategorie + "'" + sChoisirTous + " " +
"ORDER BY TRIM(PIECE)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstNoItem.Open("SELECT PIECE FROM CatalogueElec " +
                        "WHERE CATEGORIE = '" + sCategorie + "' AND FABRICANT = '" + sFabricant + "' " +
                        "ORDER BY TRIM(PIECE)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                cmbNoItem.Items.Clear();
                while (!rstNoItem.EOF)
                {
                    if (!(rstNoItem.Fields["PIECE"].Value is DBNull)) { cmbNoItem.Items.Add(($"{rstNoItem.Fields["PIECE"].Value}")); }

                    rstNoItem.MoveNext();
                }
                rstNoItem.Close();
                rstNoItem = null;
                if (cmbNoItem.Items.Count > 0)
                {
                    if (!string.IsNullOrEmpty(m_sSelectNoItem))
                    {
                        for (X = 0; X <= (cmbNoItem.Items.Count - 1); X++)
                        {
                            if ((cmbNoItem.Items[X].ToString() ?? "") == (m_sSelectNoItem ?? ""))
                            {
                                cmbNoItem.SelectedIndex = X; m_sSelectNoItem = ""; break;
                            }
                        }
                    }
                    else { cmbNoItem.SelectedIndex = 0; }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "RemplirComboNoItem", ex); }
        }
        private void CalculerPrixReel(string sNoItem)
        {
            try
            {
                Recordset rstPieceFRS;
                Recordset rstConfig;
                var sPrixCalcul = default(string);
                string sTauxUSA;
                string sTauxSPA;
                rstConfig = new Recordset();
                rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                sTauxUSA = $"{rstConfig.Fields["TauxAmericain"].Value}";
                sTauxSPA = $"{rstConfig.Fields["TauxEspagnol"].Value}";
                rstConfig.Close();
                rstConfig = null;
                rstPieceFRS = new Recordset();
                rstPieceFRS.CursorLocation = CursorLocationEnum.adUseServer;
                rstPieceFRS.Open("SELECT PrixReel, PRIX_NET, PRIX_SP, DeviseMonétaire FROM PiecesFRS " +
                    "WHERE PIECE = '" + sNoItem.Replace("'", "''") + "' AND Type = 'E'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPieceFRS.EOF)
                {
                    if (!string.IsNullOrEmpty($"{rstPieceFRS.Fields["PRIX_NET"].Value}")) { sPrixCalcul = $"{rstPieceFRS.Fields["PRIX_NET"].Value}".Replace(".", ","); }
                    if (!string.IsNullOrEmpty($"{rstPieceFRS.Fields["PRIX_SP"].Value}")) { sPrixCalcul = $"{rstPieceFRS.Fields["PRIX_SP"].Value}".Replace(".", ","); }
                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "USA") { rstPieceFRS.Fields["PrixReel"].Value = Math.Round(double.Parse(sPrixCalcul) / double.Parse(sTauxUSA), 4).ToString(); }
                    else if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "SPA") { rstPieceFRS.Fields["PrixReel"].Value = Math.Round(double.Parse(sPrixCalcul) / double.Parse(sTauxSPA), 4).ToString(); }
                    else { rstPieceFRS.Fields["PrixReel"].Value = Math.Round(double.Parse(sPrixCalcul), 4).ToString(); }
                    rstPieceFRS.Update();
                    rstPieceFRS.MoveNext();
                }
                rstPieceFRS.Close();
                rstPieceFRS = null;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "CalculerPrixReel", ex); }
        }
        private void lvwDescription_LostFocus()
        {
            try
            {
                if (lvwDescription.Visible == true) { lvwDescription.Visible = false; }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwDescription_LostFocus", ex); }
        }
        private void lvwRechercheJob_LostFocus()
        {
            try
            {
                if (lvwRechercheJob.Visible == true) { lvwRechercheJob.Visible = false; }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwRechercheJob_LostFocus", ex); }
        }
        private void lvwRechercheAchat_LostFocus()
        {
            try
            {
                if (lvwRechercheAchat.Visible == true) { lvwRechercheAchat.Visible = false; }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwRechercheAchat_LostFocus", ex); }
        }
        private void lvwFournisseur_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwfournisseur.Items.Count > 0) { ModifierFournisseur(); }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwFournisseur_DblClick", ex); }
        }
        private void lvwfournisseur_KeyDown(ref int KeyCode, ref int Shift)
        {
            try
            {
                if (lvwfournisseur.Items.Count > 0)
                {
                    if (KeyCode == (int)Keys.Delete) { SupprimerFournisseur(); }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwfournisseur_KeyDown", ex); }
        }
        private void ModifierFournisseur()
        {
            try
            {
                BarrerChamps_piece(true);
                MontrerControles(EnumModeCatalogueElec.MODE_AJOUT_MODIF_FRS);
                m_bAjout = false;
                AfficherFRS();
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "ModifierFournisseur", ex); }
        }
        private void SupprimerFournisseur()
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment effacer le fournisseur " + lvwfournisseur.SelectedItems[0].Text + "?", "Surveillance des données", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    UpdateSQL("DELETE FROM PiecesFRS WHERE NoEnreg = " + lvwfournisseur.SelectedItems[0].Tag);
                    //                RemplirListViewFournisseur();
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "SupprimerFournisseur", ex); }
        }
        private void lvwPieces_LostFocus()
        {
            try
            {
                if (lvwPieces.Visible == true) { lvwPieces.Visible = false; }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "lvwPieces_LostFocus", ex); }
        }
        private void mskEscompte_GotFocus()
        {
            try
            {
                if (mskEscompte.Enabled == true) { mskEscompte.Mask = "0,####"; }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "mskEscompte_GotFocus", ex); }
        }
        private void mskEscompte_LostFocus()
        {
            try
            {
                mskEscompte.Mask = string.Empty;
                if (mskEscompte.Text == "0,____") { mskEscompte.Text = string.Empty; }
                CalculerPrixNet();
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "mskEscompte_LostFocus", ex); }
        }
        private void optCAN_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Conversions.ToBoolean(((dynamic)eventSender).Checked)) { AfficherDrapeau(); }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "optCAN_Click", ex); }
        }
        private void AfficherDrapeau()
        {
            try
            {
                if (optCAN.Checked == true)
                {
                    imgCanada.Visible = true;
                    imgEU.Visible = false;
                    imgSpain.Visible = false;
                    lblDevise1.Visible = false;
                    txtTauxChange.Visible = false;
                    lblDevise2.Visible = false;
                }
                else
                {
                    if (optUSA.Checked == true)
                    {
                        imgEU.Visible = true; imgCanada.Visible = false; imgSpain.Visible = false;
                    }
                    else
                    {
                        imgSpain.Visible = true; imgCanada.Visible = false; imgEU.Visible = false;
                    }
                    AfficherTauxChange();
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "AfficherDrapeau", ex); }
        }
        private void AfficherTauxChange()
        {
            try
            {
                Recordset rstConfig = new Recordset();
                rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (optUSA.Checked == true)
                {
                    lblDevise2.Text = "$ USA";
                    txtTauxChange.Text = $"{rstConfig.Fields["TauxAmericain"].Value}";
                }
                else
                {
                    lblDevise2.Text = "SPA";
                    txtTauxChange.Text = $"{rstConfig.Fields["TauxEspagnol"].Value}";
                }
                lblDevise1.Visible = true;
                txtTauxChange.Visible = true;
                lblDevise2.Visible = true;
                rstConfig.Close();
                rstConfig = null;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "AfficherTauxChange", ex); }
        }
        private void optSpain_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (optSpain.Checked)
                {
                    AfficherDrapeau();
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "optSpain_Click", ex); }
        }
        private void optUSA_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (optUSA.Checked)
                {
                    AfficherDrapeau();
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "optUSA_Click", ex); }
        }
        private void txtNoItem_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == EnumModeCatalogueElec.MODE_AJOUT_MODIF_ELEC) { if (txtNoItem.Text.Length > 18) { txtNoItemGRB.Text = Gauche(txtNoItem.Text, 18) + "GRB"; } else { txtNoItemGRB.Text = txtNoItem.Text + "GRB"; } }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtNoItem_Change", ex); }
        }
        private void txtPrixList_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPrixList.Text))
                {
                    txtPrixList.Text = txtPrixList.Text.Replace(".", ",");
                    if (!IsNumeric(txtPrixList.Text)) { MessageBox.Show("Valeur non numérique!", Application.ProductName + ".CatalogueElec.Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtPrixList.Text = string.Empty; }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtPrixList_LostFocus", ex); }
        }
        private void txtPrixNet_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Strings.Len(txtPrixNet.Text) > 0)
                {
                    txtPrixSpecial.Text = string.Empty;
                    txtPrixSpecial.Enabled = false;
                }
                else
                {
                    txtPrixSpecial.Enabled = true;
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtPrixNet_Change", ex); }
        }
        private void txtPrixSpecial_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Strings.Len(txtPrixSpecial.Text) > 0)
                {
                    mskEscompte.Text = string.Empty;
                    txtPrixNet.Text = string.Empty;
                    mskEscompte.Enabled = false;
                    txtPrixNet.Enabled = false;
                }
                else
                {
                    mskEscompte.Enabled = true;
                    txtPrixNet.Enabled = true;
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtPrixSpecial_Change", ex); }
        }
        private void txtPrixNet_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerPrixNet();
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtPrixNet_GotFocus", ex); }
        }
        private void CalculerPrixNet()
        {
            try
            {
                double dblEscompte;
                double dblPrix;
                if (txtPrixNet.ReadOnly == false)
                {
                    mskEscompte.Text = mskEscompte.Text.Replace("_", string.Empty);
                    mskEscompte.Text = mskEscompte.Text.Replace(".", ",");
                    if (!string.IsNullOrEmpty(mskEscompte.Text)) { dblEscompte = double.Parse(mskEscompte.Text); } else { dblEscompte = 0d; }
                    if (!string.IsNullOrEmpty(txtPrixList.Text)) { dblPrix = double.Parse(txtPrixList.Text.Replace(".", ",")); } else { dblPrix = 0d; }
                    txtPrixNet.Text = Math.Round(dblPrix * (1d - dblEscompte), 4).ToString();
                    txtPrixNet.Text = txtPrixNet.Text.Replace(".", ",");
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "CalculerPrixNet", ex); }
        }
        private void txtPrixNet_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtPrixNet.Text = txtPrixNet.Text.Replace(".", ",");
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtPrixNet_LostFocus", ex); }
        }
        private void mskValide_GotFocus()
        {
            try
            {
                if (mskValide.Text.Length == 8) { mskValide.Text = "20" + mskValide.Text; }
                mskValide.Mask = "####-##-##";
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "mskValide_GotFocus", ex); }
        }
        private void mskValide_LostFocus()
        {
            try
            {
                mskValide.Mask = string.Empty;
                if (mskValide.Text == "____-__-__") { mskValide.Text = string.Empty; }
                else if (mskValide.Text.Length == 10)
                {
                    if (ValiderDate(mskValide.Text))
                    {
                        mskValide.Text = DateTime.Parse(mskValide.Text).ToShortDateString();
                    }
                }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "mskValide_LostFocus", ex); }
        }
        public void RemplirComboCategorie()
        {
            try
            {
                Recordset rstCatalogueElec;
                int X;
                cmbCategorie.Items.Clear();
                rstCatalogueElec = new Recordset();
                rstCatalogueElec.Open("SELECT DISTINCT CATEGORIE FROM CatalogueElec " +
                    "ORDER BY CATEGORIE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstCatalogueElec.EOF)
                {
                    if (!(rstCatalogueElec.Fields["CATEGORIE"].Value is DBNull))
                    {
                        cmbCategorie.Items.Add(($"{rstCatalogueElec.Fields["CATEGORIE"].Value}".Trim().ToUpper()));
                    }
                    rstCatalogueElec.MoveNext();
                }
                rstCatalogueElec.Close();
                rstCatalogueElec = null;
                /*           if (cmbCategorie.Items.Count > 0) { if (!string.IsNullOrEmpty(m_sSelectCategorie)) { 
                              for (X = 0; X <cmbCategorie.Items.Count; X++)
                                  {
                                      if ((cmbCategorie.Items[X].ToString() ?? "") == (m_sSelectCategorie ?? ""))
                                      {
                                          cmbCategorie.SelectedIndex = X; m_sSelectCategorie = ""; break; }
                                  } } else { cmbCategorie.SelectedIndex = 0; } } */
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "RemplirComboCategorie", ex); }
        }
        private void RemplirComboFRS()
        {
            Recordset rstPieceFRS;
            string sNomTable;
            cmbfrs.Items.Clear();
            rstPieceFRS = new Recordset();
            rstPieceFRS.Open("SELECT * FROM Fournisseur WHERE Supprimé = 0 ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rstPieceFRS.EOF)
            {
                cmbfrs.Items.Add(new ListItem() { Text = rstPieceFRS.Fields["NomFournisseur"].Value, Value = $"{rstPieceFRS.Fields["IDFRS"].Value}" });
                rstPieceFRS.MoveNext();
            }
            rstPieceFRS.Close();
        }
        private void txtPrixSpecial_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtPrixSpecial.Text = txtPrixSpecial.Text.Replace(".", ",");
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtPrixSpecial_LostFocus", ex); }
        }
        private void RemplirComboLocalisation()
        {
            Recordset rstLocalisation = new Recordset();
            rstLocalisation.Open("SELECT DISTINCT Localisation FROM InventaireElec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            cmbLocalisation.Items.Clear();
            while (!rstLocalisation.EOF)
            {
                if (!(rstLocalisation.Fields["Localisation"].Value is DBNull))
                {
                    if (!string.IsNullOrEmpty($"{rstLocalisation.Fields["Localisation"].Value}"))
                    {
                        cmbLocalisation.Items.Add($"{rstLocalisation.Fields["Localisation"].Value}");
                    }
                }
                rstLocalisation.MoveNext();
            }
            rstLocalisation.Close();
            try
            {
                rstLocalisation = null;
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "RemplirComboLocalisation", ex); }
        }
        private void txtQuantitéBoite_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtQuantitéBoite.Text = txtQuantitéBoite.Text.Replace(".", ",");
                if (!IsNumeric(txtQuantitéBoite.Text) | txtQuantitéBoite.Text == "0") { txtQuantitéBoite.Text = "1"; }
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtQuantitéBoite_LostFocus", ex); }
        }
        private void txtQuantiteCommande_Leave(object eventSender, EventArgs eventArgs)
        {
            try { txtQuantiteCommande.Text = txtQuantiteCommande.Text.Replace(".", ","); }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtQuantiteCommande_LostFocus", ex); }
        }
        private void txtQuantiteMinimum_Leave(object eventSender, EventArgs eventArgs)
        {
            try { txtQuantiteMinimum.Text = txtQuantiteMinimum.Text.Replace(".", ","); }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtQuantiteMinimum_LostFocus", ex); }
        }
        private void txtQuantiteStock_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtQuantiteStock.Text = txtQuantiteStock.Text.Replace(".", ",");
            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "txtQuantiteStock_LostFocus", ex); }
        }
        private void SyncroniserFournisseursCategorie(object eventSender, EventArgs eventArgs)
        {
            cmbfrs.Items.Clear();
            Recordset rd = new Recordset();
            rd.Open($"select distinct NOMFOURNISSEUR,[DBO].[PIECESFRS].IDFRS FROM [DBO].[CATALOGUEELEC] " +
                $"JOIN [DBO].[PIECESFRS] ON[DBO].[CATALOGUEELEC].PIECE = PIECESFRS.PIECE " +
                $"JOIN FOURNISSEUR ON[DBO].[PIECESFRS].IDFRS = [DBO].[FOURNISSEUR].IDFRS " +
                $"WHERE [DBO].[CATALOGUEELEC].[CATEGORIE] LIKE '%{cmbCategorie.Text}%' ORDER BY NOMFOURNISSEUR", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            /* ID 0 : NOMFOURNISSEUR ID 1 : IDFRS*/
            while (!rd.EOF)
            {
                cmbfrs.Items.Add(new ListItem($"{rd.Fields[0].Value}", $"{rd.Fields[1].Value}"));
                rd.MoveNext();
            }
        }
        private void SyncroniserFabricantCategorie(object eventSender, EventArgs eventArgs)
        {
            cmbFabricant.Items.Clear();
            Recordset rd = new Recordset();
            rd.Open($"select distinct [FABRICANT] FROM [DBO].[CATALOGUEELEC] WHERE [CATEGORIE] LIKE'%{cmbCategorie.Text}%' ORDER BY FABRICANT", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                cmbFabricant.Items.Add($"{rd.Fields[0].Value}");
                rd.MoveNext();
            }
            if (cmbFabricant.Items.Count > 0) cmbFabricant.SelectedIndex = 0;
        }
        private void SyncroniserDescriptionCategorie(object eventSender, EventArgs eventArgs)
        {
            txtDescriptionFR.Items.Clear();
            Recordset rd = new Recordset();
            rd.Open($"select distinct [DESC_FR] FROM [DBO].[CATALOGUEELEC] WHERE [CATEGORIE] LIKE'%{cmbCategorie.Text}%' ORDER BY [DESC_FR]", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
                txtDescriptionFR.Items.Add($"{rd.Fields[0].Value}");
                rd.MoveNext();
            }
            if (txtDescriptionFR.Items.Count > 0) txtDescriptionFR.SelectedIndex = 0;
        }
        private void cmbCategorie_SelectedIndexChanged_1(object eventSender, EventArgs eventArgs)
        {
            txtCategorie.Text = cmbCategorie.Text;
            m_bRempliManuel = true;
            m_bBloqueDescription = true;
            cmbFabricant.Items.Clear();
            cmbNoItem.Items.Clear();
            ViderChamps_piece();
            RemplirComboFabricant();
            m_bBloqueDescription = false;
            lvwfournisseur.Items.Clear();
            Recordset rd = new Recordset();
            rd.Open($"SELECT NOMFOURNISSEUR,REP,DATE,ENTRER_PAR,VALIDE,PRIX_LIST,ESCOMPTE,PRIX_NET,PRIX_SP,QUOTER,[DBO].[PIECESFRS].IDFRS  FROM [DBO].[CATALOGUEELEC] " +
                $"JOIN [DBO].[PIECESFRS] ON[DBO].[CATALOGUEELEC].PIECE = PIECESFRS.PIECE " +
                $"JOIN FOURNISSEUR ON[DBO].[PIECESFRS].IDFRS = [DBO].[FOURNISSEUR].IDFRS " +
                $"WHERE [DBO].[CATALOGUEELEC].[CATEGORIE] LIKE'%{cmbCategorie.Text}%' " +
                $"ORDER BY DATE DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            /* ID 0 : NOMFOURNISSEUR ID 1 : REP ID 2 : DATE ID 3 : ENTRER_PAR ID 4 : VALIDE ID 5 : PRIX_LIST ID 6 : ESCOMPTE ID 7 : PRIX_NET ID 8 : PRIX_SP ID 9 : QUOTER ID 10 : IDFRS*/
            while (!rd.EOF)
            {
                ListViewItem itm = lvwfournisseur.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                idFournisseur = int.Parse($"{rd.Fields[10].Value}");
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[2].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[3].Value}"));
                itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[4].Value}"));
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[5].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[6].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[7].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[8].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[9].Value}"));
                rd.MoveNext();
            }
            //          if(cmbCategorie.Items.Count > 0) cmbCategorie.SelectedIndex = 0;
            SyncroniserFabricantCategorie(eventSender, eventArgs);
            txtDescriptionFR.Visible = true;
            SyncroniserDescriptionCategorie(eventSender, eventArgs);
            SyncroniserFournisseursCategorie(eventSender, eventArgs);
            /*        if (txtDescriptionFR.Items.Count > 0) txtDescriptionFR.SelectedIndex = 0;
                    if (cmbFabricant.Items.Count > 0) cmbFabricant.SelectedIndex = 0;
                    if (cmbfrs.Items.Count > 0)cmbfrs.SelectedIndex = 0;*/
        }

        private void cmdDemande_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new DemandePrix();
                f.ShowDialog();
                
                    if (m_bDemandeAnnuler == false)
                    {
                        Form a = new ChoixDemande(EnumCatalogue.ELECTRIQUE, m_eDemande);
                        a.Show();
                    }

            }
            catch (Exception ex) { AfficherErreur("CatalogueElec", "cmdDemande_Click", ex); }

        }
    }
}