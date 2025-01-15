using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Reflection;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Threading;
using System.IO;

using static ControleurServeur.Program;
using static ControleurServeur.Utilisateur;
using static Microsoft.VisualBasic.Interaction;
using Stripe.Climate;
using Stripe;
using Application = System.Windows.Forms.Application;

namespace ControleurServeur
{
    public class Conteneur : Form
    {
        internal static IPAddress ip = Dns.GetHostAddresses(Dns.GetHostName())[1].MapToIPv4();
        private int childFormNumber = 0;
        private Bitmap memoryImage;
        PrintDocument printDocument1 = new PrintDocument();
        internal static PrintPreviewDialog PrintPreviewDialog1;
        internal static string titrePunch = "";
        Utilisateur user = new Utilisateur();
        private System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();
        internal static ToolStripMenuItem toolStripMenuItem18;
        internal static ToolStripMenuItem punchToolStripMenuItem;
        internal static ToolStripMenuItem punchToolStripMenuItem1;
        internal static ToolStripMenuItem feuillesDeTempsToolStripMenuItem;
        internal static ToolStripMenuItem inventaireToolStripMenuItem;
        internal static ToolStripMenuItem électriqueToolStripMenuItem;
        internal static ToolStripMenuItem mécaniqueToolStripMenuItem;
        internal static ToolStripMenuItem sortieMatérielToolStripMenuItem;
        internal static ToolStripMenuItem retourMatérielToolStripMenuItem;
        internal static ToolStripMenuItem faireLinventairePhysiqueToolStripMenuItem;
        internal static ToolStripMenuItem sortieDoutilsToolStripMenuItem;
        internal static ToolStripMenuItem projetsSoumissionsToolStripMenuItem;
        internal static ToolStripMenuItem projetsEtSoumissionsToolStripMenuItem;
        internal static ToolStripMenuItem électriquesToolStripMenuItem;
        internal static ToolStripMenuItem mécaniquesToolStripMenuItem;
        internal static ToolStripMenuItem réceptionsToolStripMenuItem;
        internal static ToolStripMenuItem électriqueToolStripMenuItem6;
        internal static ToolStripMenuItem mécaniqueToolStripMenuItem6;
        internal static ToolStripSeparator toolStripMenuItem27;
        internal static ToolStripMenuItem achatsToolStripMenuItem;
        internal static ToolStripMenuItem électriqueToolStripMenuItem7;
        internal static ToolStripMenuItem mécaniqueToolStripMenuItem7;
        internal static ToolStripSeparator toolStripMenuItem26;
        internal static ToolStripMenuItem assistantToolStripMenuItem;
        internal static ToolStripMenuItem catalogueToolStripMenuItem;
        internal static ToolStripMenuItem électriqueToolStripMenuItem2;
        internal static ToolStripMenuItem mécaniqueToolStripMenuItem2;
        internal static ToolStripMenuItem employésToolStripMenuItem;
        internal static ToolStripMenuItem toolStripMenuItem8;
        internal static ToolStripMenuItem outilsToolStripMenuItem;
        internal static ToolStripMenuItem testPreviewEmulateurCrystalRepportToolStripMenuItem;
        internal static ToolStripMenuItem commandesToolStripMenuItem;
        internal static ToolStripMenuItem contactsToolStripMenuItem1;
        internal static ToolStripMenuItem horrairesToolStripMenuItem;
        internal static ToolStripMenuItem listesToolStripMenuItem;
        internal static ToolStripMenuItem formulairesToolStripMenuItem;
        internal static ToolStripMenuItem databaseWizzardToolStripMenuItem;
        internal static ToolStripMenuItem configurationDBToolStripMenuItem;
        internal static ToolStripMenuItem rapportsToolStripMenuItem;
        internal static ToolStripMenuItem testsRapportsToolStripMenuItem;
        internal static ToolStripMenuItem outilsToolStripMenuItem1;
        internal static ToolStripMenuItem screenShotToolStripMenuItem;
        internal static ToolStripMenuItem toolStripMenuItem1;
        internal static ToolStripMenuItem toolStripMenuItem2;
        internal static ToolStripMenuItem toolStripMenuItem3;
        internal static ToolStripMenuItem toolStripMenuItem4;
        internal static ToolStripMenuItem toolStripMenuItem5;
        internal static ToolStripMenuItem toolStripMenuItem7;
        internal static ToolStripMenuItem toolStripMenuItem6;
        internal static ToolStripMenuItem aideToolStripMenuItem;
        internal static ToolStripMenuItem àproposdeToolStripMenuItem;
        internal static ToolStripMenuItem lblVersion;
        internal static ToolStripMenuItem ClefHash;
        internal static ToolStripMenuItem toolStripMenuItem17;
        internal static ToolStripMenuItem lbldb;
        internal static ToolStripMenuItem lblDerniereVersion;
        internal static ToolStripMenuItem quitterToolStripMenuItem;
        internal static MenuStrip menuStrip1;
        internal static ToolStripStatusLabel txtStatus;
        internal static ToolStripStatusLabel IdNetLogin;
        internal static ToolStripStatusLabel idNoEmploye;
        internal static ToolStripStatusLabel idLoginEmploye;
        internal static ToolStripStatusLabel idGroupeEmploye;
        internal static ToolStripStatusLabel idNomEmploye;
        internal static ToolStripStatusLabel idDateToday;
        internal static ToolStripStatusLabel idNomSemaine;
        internal static ToolStripDropDownButton IdIPs;
        internal static ToolStripStatusLabel idInitiales;
        internal static ToolStripStatusLabel StatusLabel;
        internal static StatusStrip statusStrip1;
        internal static Button cmdquitter;
        internal static Button cmdPunch;
        internal static Button cmdInventaire;
        internal static Button cmdFormulaire;
        internal static PictureBox pictureBox1;
        internal static Button button2;
        internal static Button button3;
        internal static Button button4;
        internal static Panel panel1;
        internal static ToolStripMenuItem commandeToolStripMenuItem;
        internal static ToolStripMenuItem commandeRecueToolStripMenuItem;
        internal static ToolStripMenuItem commandeParcelToolStripMenuItem;
        internal static ToolStripMenuItem contactEntrepriseToolStripMenuItem;
        internal static ToolStripMenuItem toolStripMenuItem25;
        internal static ToolStripMenuItem sommaireHeuresToolStripMenuItem;
        internal static ToolStripMenuItem feuilleDeTempsToolStripMenuItem;
        internal static ToolStripMenuItem contactVilleToolStripMenuItem;
        internal static ToolStripMenuItem CmdChangerDB;
        internal static ToolStripMenuItem listeAchatsToolStripMenuItem;
        internal static ToolStripMenuItem listeClientToolStripMenuItem;
        internal static ToolStripMenuItem listeContactToolStripMenuItem;
        internal static ToolStripMenuItem listeInventaireToolStripMenuItem;
        internal static ToolStripMenuItem listePieceToolStripMenuItem;
        internal static ToolStripMenuItem listeProjetToolStripMenuItem;
        internal static ToolStripMenuItem appercuProjetToolStripMenuItem;
        internal static ToolStripMenuItem backOrderToolStripMenuItem;
        internal static ToolStripMenuItem bonTravailToolStripMenuItem;
        internal static ToolStripMenuItem clientsToolStripMenuItem1;
        internal static ToolStripMenuItem conceptionToolStripMenuItem;
        internal static ToolStripMenuItem demandePrixToolStripMenuItem;
        internal static ToolStripMenuItem facturationToolStripMenuItem1;
        internal static ToolStripMenuItem françaisToolStripMenuItem;
        internal static ToolStripMenuItem anglaisToolStripMenuItem;
        internal static ToolStripMenuItem fermeMecaniqueToolStripMenuItem;
        internal static ToolStripMenuItem fermetureToolStripMenuItem;
        internal static ToolStripMenuItem finFabricationToolStripMenuItem;
        internal static ToolStripMenuItem fournisseurToolStripMenuItem;
        internal static ToolStripMenuItem électriqueToolStripMenuItem4;
        internal static ToolStripMenuItem mécaniqueToolStripMenuItem4;
        internal static ToolStripMenuItem outilsInOutToolStripMenuItem;
        internal static ToolStripMenuItem outilsMachinerieToolStripMenuItem;
        internal static ToolStripMenuItem problemesToolStripMenuItem;
        internal static ToolStripMenuItem programmationToolStripMenuItem;
        internal static ToolStripMenuItem receptionToolStripMenuItem;
        internal static ToolStripMenuItem retourToolStripMenuItem;
        internal static ToolStripMenuItem toolStripMenuItem16;
        internal static ToolStripMenuItem toolStripMenuItem19;
        internal static ToolStripMenuItem tempsElecToolStripMenuItem;
        internal static ToolStripMenuItem tempsMecToolStripMenuItem;
        internal static ToolStripMenuItem invenaireComptableToolStripMenuItem;
        internal static ToolStripMenuItem électriqueToolStripMenuItem1;
        internal static ToolStripMenuItem mécaniqueToolStripMenuItem1;
        internal static ToolStripMenuItem toolStripMenuItem14;
        internal static ToolStripMenuItem billeteriebétaToolStripMenuItem;
        internal static ToolStripMenuItem emailsSurExchangeToolStripMenuItem;
        internal static ToolStripMenuItem captureDécranToolStripMenuItem;
        internal static LinkLabel céduleToolStripMenuItem;
        internal static LinkLabel contactsToolStripMenuItem;
        internal static LinkLabel contactsPourVendeursToolStripMenuItem;
        internal static LinkLabel listeDeDistributionToolStripMenuItem;
        internal static LinkLabel clientsToolStripMenuItem;
        internal static LinkLabel fournisseursToolStripMenuItem;
        private ToolStripMenuItem cmdRéceptionTMensuelle;
        internal static ToolStripMenuItem facturationToolStripMenuItem;
        internal static ToolStripMenuItem toolStripMenuItem21;
        internal static ToolStripMenuItem toolStripMenuItem15;
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Code généré par le Concepteur Windows Form
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conteneur));
            toolTip = new System.Windows.Forms.ToolTip(components);
            cmdPunch = new System.Windows.Forms.Button();
            cmdInventaire = new System.Windows.Forms.Button();
            cmdFormulaire = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            tmrAlarme = new System.Windows.Forms.Timer(components);
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            punchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            punchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            feuillesDeTempsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            électriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mécaniqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sortieMatérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            retourMatérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            faireLinventairePhysiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sortieDoutilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            projetsSoumissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            projetsEtSoumissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            électriquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mécaniquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            réceptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            électriqueToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            mécaniqueToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem27 = new System.Windows.Forms.ToolStripSeparator();
            achatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            électriqueToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            mécaniqueToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem26 = new System.Windows.Forms.ToolStripSeparator();
            assistantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            catalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            électriqueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            mécaniqueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            employésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            testPreviewEmulateurCrystalRepportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            commandeRecueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            commandeParcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contactsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            contactEntrepriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            contactVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            horrairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sommaireHeuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            feuilleDeTempsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            listesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listeAchatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listeInventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listeProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listePieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            formulairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            appercuProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            backOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bonTravailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            conceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            demandePrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            facturationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            françaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            anglaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fermeMecaniqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fermetureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            finFabricationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            électriqueToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            mécaniqueToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            outilsInOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            outilsMachinerieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            problemesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            programmationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            receptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            retourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            tempsElecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            tempsMecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            databaseWizzardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            configurationDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            CmdChangerDB = new System.Windows.Forms.ToolStripMenuItem();
            rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            testsRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            invenaireComptableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            électriqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            mécaniqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            cmdRéceptionTMensuelle = new System.Windows.Forms.ToolStripMenuItem();
            facturationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            outilsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            screenShotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            billeteriebétaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            emailsSurExchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            captureDécranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblVersion = new System.Windows.Forms.ToolStripMenuItem();
            ClefHash = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            lbldb = new System.Windows.Forms.ToolStripMenuItem();
            lblDerniereVersion = new System.Windows.Forms.ToolStripMenuItem();
            quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            IdNetLogin = new System.Windows.Forms.ToolStripStatusLabel();
            idNoEmploye = new System.Windows.Forms.ToolStripStatusLabel();
            idLoginEmploye = new System.Windows.Forms.ToolStripStatusLabel();
            idGroupeEmploye = new System.Windows.Forms.ToolStripStatusLabel();
            idNomEmploye = new System.Windows.Forms.ToolStripStatusLabel();
            idDateToday = new System.Windows.Forms.ToolStripStatusLabel();
            idNomSemaine = new System.Windows.Forms.ToolStripStatusLabel();
            IdIPs = new System.Windows.Forms.ToolStripDropDownButton();
            idInitiales = new System.Windows.Forms.ToolStripStatusLabel();
            StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            cmdquitter = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            clientsToolStripMenuItem = new System.Windows.Forms.LinkLabel();
            fournisseursToolStripMenuItem = new System.Windows.Forms.LinkLabel();
            céduleToolStripMenuItem = new System.Windows.Forms.LinkLabel();
            contactsToolStripMenuItem = new System.Windows.Forms.LinkLabel();
            contactsPourVendeursToolStripMenuItem = new System.Windows.Forms.LinkLabel();
            listeDeDistributionToolStripMenuItem = new System.Windows.Forms.LinkLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolTip
            // 
            toolTip.BackColor = System.Drawing.SystemColors.GrayText;
            toolTip.ForeColor = System.Drawing.Color.White;
            // 
            // cmdPunch
            // 
            cmdPunch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdPunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            cmdPunch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPunch.BackgroundImage")));
            cmdPunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            cmdPunch.Cursor = System.Windows.Forms.Cursors.Default;
            cmdPunch.Dock = System.Windows.Forms.DockStyle.Left;
            cmdPunch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            cmdPunch.ForeColor = System.Drawing.Color.Navy;
            cmdPunch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cmdPunch.Location = new System.Drawing.Point(0, 0);
            cmdPunch.Name = "cmdPunch";
            cmdPunch.Size = new System.Drawing.Size(29, 29);
            cmdPunch.TabIndex = 22;
            toolTip.SetToolTip(cmdPunch, "Punch");
            cmdPunch.UseVisualStyleBackColor = true;
            cmdPunch.Click += new System.EventHandler(punchToolStripMenuItem1_Click);
            // 
            // cmdInventaire
            // 
            cmdInventaire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdInventaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            cmdInventaire.Dock = System.Windows.Forms.DockStyle.Left;
            cmdInventaire.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            cmdInventaire.ForeColor = System.Drawing.Color.Navy;
            cmdInventaire.Image = ((System.Drawing.Image)(resources.GetObject("cmdInventaire.Image")));
            cmdInventaire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cmdInventaire.Location = new System.Drawing.Point(29, 0);
            cmdInventaire.Name = "cmdInventaire";
            cmdInventaire.Size = new System.Drawing.Size(29, 29);
            cmdInventaire.TabIndex = 23;
            toolTip.SetToolTip(cmdInventaire, "&Inventaire physique");
            cmdInventaire.UseVisualStyleBackColor = true;
            cmdInventaire.Click += new System.EventHandler(faireLinventairePhysiqueToolStripMenuItem_Click);
            // 
            // cmdFormulaire
            // 
            cmdFormulaire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdFormulaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            cmdFormulaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            cmdFormulaire.Dock = System.Windows.Forms.DockStyle.Left;
            cmdFormulaire.Enabled = false;
            cmdFormulaire.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            cmdFormulaire.ForeColor = System.Drawing.Color.Navy;
            cmdFormulaire.Image = ((System.Drawing.Image)(resources.GetObject("cmdFormulaire.Image")));
            cmdFormulaire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cmdFormulaire.Location = new System.Drawing.Point(58, 0);
            cmdFormulaire.Name = "cmdFormulaire";
            cmdFormulaire.Size = new System.Drawing.Size(29, 29);
            cmdFormulaire.TabIndex = 32;
            toolTip.SetToolTip(cmdFormulaire, "Assistant Rapports");
            cmdFormulaire.UseVisualStyleBackColor = true;
            cmdFormulaire.Click += new System.EventHandler(toolStripMenuItem14_Click);
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button2.Dock = System.Windows.Forms.DockStyle.Left;
            button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            button2.ForeColor = System.Drawing.Color.Navy;
            button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            button2.Location = new System.Drawing.Point(87, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(29, 29);
            button2.TabIndex = 37;
            toolTip.SetToolTip(button2, "Feuille de temps");
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(RaccourciFeuilleDeTemps_Click);
            // 
            // button3
            // 
            button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button3.Dock = System.Windows.Forms.DockStyle.Left;
            button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            button3.ForeColor = System.Drawing.Color.Navy;
            button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button3.Location = new System.Drawing.Point(116, 0);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(29, 29);
            button3.TabIndex = 38;
            toolTip.SetToolTip(button3, "Vos mails Exchange directement dans une fenêtre");
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button4_Click);
            // 
            // button4
            // 
            button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button4.Dock = System.Windows.Forms.DockStyle.Left;
            button4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            button4.ForeColor = System.Drawing.Color.Navy;
            button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            button4.Location = new System.Drawing.Point(145, 0);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(29, 29);
            button4.TabIndex = 39;
            toolTip.SetToolTip(button4, "Signaler un problème ou une panne");
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(toolStripButton3_Click);
            // 
            // tmrAlarme
            // 
            tmrAlarme.Enabled = true;
            tmrAlarme.Interval = 1000;
            tmrAlarme.Tick += new System.EventHandler(tmrAlarme_Tick);
            // 
            // toolStripMenuItem18
            // 
            toolStripMenuItem18.AutoToolTip = true;
            toolStripMenuItem18.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            toolStripMenuItem18.ForeColor = System.Drawing.Color.Chocolate;
            toolStripMenuItem18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem18.Image")));
            toolStripMenuItem18.Name = "toolStripMenuItem18";
            toolStripMenuItem18.Size = new System.Drawing.Size(139, 20);
            toolStripMenuItem18.Text = "Connexion Serveur";
            toolStripMenuItem18.Click += new System.EventHandler(Conteneur_Load);
            // 
            // punchToolStripMenuItem
            // 
            punchToolStripMenuItem.AutoToolTip = true;
            punchToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            punchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            punchToolStripMenuItem1,
            feuillesDeTempsToolStripMenuItem});
            punchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            punchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            punchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("punchToolStripMenuItem.Image")));
            punchToolStripMenuItem.Name = "punchToolStripMenuItem";
            punchToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            punchToolStripMenuItem.Text = "Punch";
            punchToolStripMenuItem.Click += new System.EventHandler(punchToolStripMenuItem_Click);
            // 
            // punchToolStripMenuItem1
            // 
            punchToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            punchToolStripMenuItem1.Enabled = false;
            punchToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            punchToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            punchToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("punchToolStripMenuItem1.Image")));
            punchToolStripMenuItem1.Name = "punchToolStripMenuItem1";
            punchToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            punchToolStripMenuItem1.Text = "Punch";
            punchToolStripMenuItem1.Click += new System.EventHandler(punchToolStripMenuItem1_Click);
            // 
            // feuillesDeTempsToolStripMenuItem
            // 
            feuillesDeTempsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            feuillesDeTempsToolStripMenuItem.Enabled = false;
            feuillesDeTempsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            feuillesDeTempsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            feuillesDeTempsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("feuillesDeTempsToolStripMenuItem.Image")));
            feuillesDeTempsToolStripMenuItem.Name = "feuillesDeTempsToolStripMenuItem";
            feuillesDeTempsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            feuillesDeTempsToolStripMenuItem.Text = "Feuilles de temps";
            feuillesDeTempsToolStripMenuItem.Click += new System.EventHandler(feuilleDeTempsToolStripMenuItem_Click);
            // 
            // inventaireToolStripMenuItem
            // 
            inventaireToolStripMenuItem.AutoToolTip = true;
            inventaireToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            inventaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            électriqueToolStripMenuItem,
            mécaniqueToolStripMenuItem,
            sortieMatérielToolStripMenuItem,
            retourMatérielToolStripMenuItem,
            faireLinventairePhysiqueToolStripMenuItem,
            sortieDoutilsToolStripMenuItem});
            inventaireToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            inventaireToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            inventaireToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventaireToolStripMenuItem.Image")));
            inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            inventaireToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            inventaireToolStripMenuItem.Text = "Inventaire";
            inventaireToolStripMenuItem.Click += new System.EventHandler(inventaireToolStripMenuItem_Click);
            // 
            // électriqueToolStripMenuItem
            // 
            électriqueToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            électriqueToolStripMenuItem.Enabled = false;
            électriqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            électriqueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("électriqueToolStripMenuItem.Image")));
            électriqueToolStripMenuItem.Name = "électriqueToolStripMenuItem";
            électriqueToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            électriqueToolStripMenuItem.Text = "Électrique";
            électriqueToolStripMenuItem.Click += new System.EventHandler(électriqueToolStripMenuItem_Click);
            // 
            // mécaniqueToolStripMenuItem
            // 
            mécaniqueToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            mécaniqueToolStripMenuItem.Enabled = false;
            mécaniqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            mécaniqueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mécaniqueToolStripMenuItem.Image")));
            mécaniqueToolStripMenuItem.Name = "mécaniqueToolStripMenuItem";
            mécaniqueToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            mécaniqueToolStripMenuItem.Text = "Mécanique";
            mécaniqueToolStripMenuItem.Click += new System.EventHandler(mécaniqueToolStripMenuItem_Click);
            // 
            // sortieMatérielToolStripMenuItem
            // 
            sortieMatérielToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            sortieMatérielToolStripMenuItem.Enabled = false;
            sortieMatérielToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            sortieMatérielToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortieMatérielToolStripMenuItem.Image")));
            sortieMatérielToolStripMenuItem.Name = "sortieMatérielToolStripMenuItem";
            sortieMatérielToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            sortieMatérielToolStripMenuItem.Text = "Sortie matériel";
            sortieMatérielToolStripMenuItem.Click += new System.EventHandler(sortieMatérielToolStripMenuItem_Click);
            // 
            // retourMatérielToolStripMenuItem
            // 
            retourMatérielToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            retourMatérielToolStripMenuItem.Enabled = false;
            retourMatérielToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            retourMatérielToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retourMatérielToolStripMenuItem.Image")));
            retourMatérielToolStripMenuItem.Name = "retourMatérielToolStripMenuItem";
            retourMatérielToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            retourMatérielToolStripMenuItem.Text = "Retour matériel";
            retourMatérielToolStripMenuItem.Click += new System.EventHandler(retourMatérielToolStripMenuItem_Click);
            // 
            // faireLinventairePhysiqueToolStripMenuItem
            // 
            faireLinventairePhysiqueToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            faireLinventairePhysiqueToolStripMenuItem.Enabled = false;
            faireLinventairePhysiqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            faireLinventairePhysiqueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("faireLinventairePhysiqueToolStripMenuItem.Image")));
            faireLinventairePhysiqueToolStripMenuItem.Name = "faireLinventairePhysiqueToolStripMenuItem";
            faireLinventairePhysiqueToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            faireLinventairePhysiqueToolStripMenuItem.Text = "Faire l\'inventaire physique";
            faireLinventairePhysiqueToolStripMenuItem.Click += new System.EventHandler(faireLinventairePhysiqueToolStripMenuItem_Click);
            // 
            // sortieDoutilsToolStripMenuItem
            // 
            sortieDoutilsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            sortieDoutilsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            sortieDoutilsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortieDoutilsToolStripMenuItem.Image")));
            sortieDoutilsToolStripMenuItem.Name = "sortieDoutilsToolStripMenuItem";
            sortieDoutilsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            sortieDoutilsToolStripMenuItem.Text = "Sortie d\'outils";
            sortieDoutilsToolStripMenuItem.Click += new System.EventHandler(sortieDoutilsToolStripMenuItem_Click);
            // 
            // projetsSoumissionsToolStripMenuItem
            // 
            projetsSoumissionsToolStripMenuItem.AutoToolTip = true;
            projetsSoumissionsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            projetsSoumissionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            projetsEtSoumissionsToolStripMenuItem,
            réceptionsToolStripMenuItem,
            achatsToolStripMenuItem,
            toolStripMenuItem26,
            assistantToolStripMenuItem});
            projetsSoumissionsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            projetsSoumissionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            projetsSoumissionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projetsSoumissionsToolStripMenuItem.Image")));
            projetsSoumissionsToolStripMenuItem.Name = "projetsSoumissionsToolStripMenuItem";
            projetsSoumissionsToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            projetsSoumissionsToolStripMenuItem.Text = "Projets & Soumissions";
            // 
            // projetsEtSoumissionsToolStripMenuItem
            // 
            projetsEtSoumissionsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            projetsEtSoumissionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            électriquesToolStripMenuItem,
            mécaniquesToolStripMenuItem});
            projetsEtSoumissionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            projetsEtSoumissionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projetsEtSoumissionsToolStripMenuItem.Image")));
            projetsEtSoumissionsToolStripMenuItem.Name = "projetsEtSoumissionsToolStripMenuItem";
            projetsEtSoumissionsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            projetsEtSoumissionsToolStripMenuItem.Text = "Projets Et Soumissions";
            // 
            // électriquesToolStripMenuItem
            // 
            électriquesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            électriquesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            électriquesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("électriquesToolStripMenuItem.Image")));
            électriquesToolStripMenuItem.Name = "électriquesToolStripMenuItem";
            électriquesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            électriquesToolStripMenuItem.Text = "Électriques";
            électriquesToolStripMenuItem.Click += new System.EventHandler(électriquesToolStripMenuItem_Click);
            // 
            // mécaniquesToolStripMenuItem
            // 
            mécaniquesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            mécaniquesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            mécaniquesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mécaniquesToolStripMenuItem.Image")));
            mécaniquesToolStripMenuItem.Name = "mécaniquesToolStripMenuItem";
            mécaniquesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            mécaniquesToolStripMenuItem.Text = "Mécaniques";
            mécaniquesToolStripMenuItem.Click += new System.EventHandler(mécaniquesToolStripMenuItem_Click);
            // 
            // réceptionsToolStripMenuItem
            // 
            réceptionsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            réceptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            électriqueToolStripMenuItem6,
            mécaniqueToolStripMenuItem6,
            toolStripMenuItem27});
            réceptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            réceptionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("réceptionsToolStripMenuItem.Image")));
            réceptionsToolStripMenuItem.Name = "réceptionsToolStripMenuItem";
            réceptionsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            réceptionsToolStripMenuItem.Text = "Réceptions";
            // 
            // électriqueToolStripMenuItem6
            // 
            électriqueToolStripMenuItem6.BackColor = System.Drawing.Color.Black;
            électriqueToolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            électriqueToolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("électriqueToolStripMenuItem6.Image")));
            électriqueToolStripMenuItem6.Name = "électriqueToolStripMenuItem6";
            électriqueToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            électriqueToolStripMenuItem6.Text = "Électrique";
            électriqueToolStripMenuItem6.Click += new System.EventHandler(électriqueToolStripMenuItem6_Click);
            // 
            // mécaniqueToolStripMenuItem6
            // 
            mécaniqueToolStripMenuItem6.BackColor = System.Drawing.Color.Black;
            mécaniqueToolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            mécaniqueToolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("mécaniqueToolStripMenuItem6.Image")));
            mécaniqueToolStripMenuItem6.Name = "mécaniqueToolStripMenuItem6";
            mécaniqueToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            mécaniqueToolStripMenuItem6.Text = "Mécanique";
            mécaniqueToolStripMenuItem6.Click += new System.EventHandler(mécaniqueToolStripMenuItem6_Click);
            // 
            // toolStripMenuItem27
            // 
            toolStripMenuItem27.Name = "toolStripMenuItem27";
            toolStripMenuItem27.Size = new System.Drawing.Size(177, 6);
            // 
            // achatsToolStripMenuItem
            // 
            achatsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            achatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            électriqueToolStripMenuItem7,
            mécaniqueToolStripMenuItem7});
            achatsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            achatsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("achatsToolStripMenuItem.Image")));
            achatsToolStripMenuItem.Name = "achatsToolStripMenuItem";
            achatsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            achatsToolStripMenuItem.Text = "Achats";
            // 
            // électriqueToolStripMenuItem7
            // 
            électriqueToolStripMenuItem7.BackColor = System.Drawing.Color.Black;
            électriqueToolStripMenuItem7.ForeColor = System.Drawing.Color.White;
            électriqueToolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("électriqueToolStripMenuItem7.Image")));
            électriqueToolStripMenuItem7.Name = "électriqueToolStripMenuItem7";
            électriqueToolStripMenuItem7.Size = new System.Drawing.Size(134, 22);
            électriqueToolStripMenuItem7.Text = "Électrique";
            électriqueToolStripMenuItem7.Click += new System.EventHandler(électriqueToolStripMenuItem7_Click);
            // 
            // mécaniqueToolStripMenuItem7
            // 
            mécaniqueToolStripMenuItem7.BackColor = System.Drawing.Color.Black;
            mécaniqueToolStripMenuItem7.ForeColor = System.Drawing.Color.White;
            mécaniqueToolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("mécaniqueToolStripMenuItem7.Image")));
            mécaniqueToolStripMenuItem7.Name = "mécaniqueToolStripMenuItem7";
            mécaniqueToolStripMenuItem7.Size = new System.Drawing.Size(134, 22);
            mécaniqueToolStripMenuItem7.Text = "Mécanique";
            mécaniqueToolStripMenuItem7.Click += new System.EventHandler(mécaniqueToolStripMenuItem7_Click);
            // 
            // toolStripMenuItem26
            // 
            toolStripMenuItem26.Name = "toolStripMenuItem26";
            toolStripMenuItem26.Size = new System.Drawing.Size(193, 6);
            // 
            // assistantToolStripMenuItem
            // 
            assistantToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            assistantToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            assistantToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("assistantToolStripMenuItem.Image")));
            assistantToolStripMenuItem.Name = "assistantToolStripMenuItem";
            assistantToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            assistantToolStripMenuItem.Text = "Assistant";
            assistantToolStripMenuItem.Click += new System.EventHandler(assistantToolStripMenuItem_Click);
            // 
            // catalogueToolStripMenuItem
            // 
            catalogueToolStripMenuItem.AutoToolTip = true;
            catalogueToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            catalogueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            électriqueToolStripMenuItem2,
            mécaniqueToolStripMenuItem2});
            catalogueToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            catalogueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            catalogueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("catalogueToolStripMenuItem.Image")));
            catalogueToolStripMenuItem.Name = "catalogueToolStripMenuItem";
            catalogueToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            catalogueToolStripMenuItem.Text = "Catalogue";
            // 
            // électriqueToolStripMenuItem2
            // 
            électriqueToolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            électriqueToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            électriqueToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("électriqueToolStripMenuItem2.Image")));
            électriqueToolStripMenuItem2.Name = "électriqueToolStripMenuItem2";
            électriqueToolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            électriqueToolStripMenuItem2.Text = "Électrique";
            électriqueToolStripMenuItem2.Click += new System.EventHandler(électriqueToolStripMenuItem2_Click);
            // 
            // mécaniqueToolStripMenuItem2
            // 
            mécaniqueToolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            mécaniqueToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            mécaniqueToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("mécaniqueToolStripMenuItem2.Image")));
            mécaniqueToolStripMenuItem2.Name = "mécaniqueToolStripMenuItem2";
            mécaniqueToolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            mécaniqueToolStripMenuItem2.Text = "Mécanique";
            mécaniqueToolStripMenuItem2.Click += new System.EventHandler(mécaniqueToolStripMenuItem2_Click);
            // 
            // employésToolStripMenuItem
            // 
            employésToolStripMenuItem.AutoToolTip = true;
            employésToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            employésToolStripMenuItem.Enabled = false;
            employésToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            employésToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            employésToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employésToolStripMenuItem.Image")));
            employésToolStripMenuItem.Name = "employésToolStripMenuItem";
            employésToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            employésToolStripMenuItem.Text = "Employés";
            employésToolStripMenuItem.Click += new System.EventHandler(cmdEmploye_Click);
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.AutoToolTip = true;
            toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            outilsToolStripMenuItem,
            testPreviewEmulateurCrystalRepportToolStripMenuItem,
            databaseWizzardToolStripMenuItem,
            configurationDBToolStripMenuItem,
            CmdChangerDB});
            toolStripMenuItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new System.Drawing.Size(38, 20);
            toolStripMenuItem8.Text = "I";
            // 
            // outilsToolStripMenuItem
            // 
            outilsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            outilsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            outilsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("outilsToolStripMenuItem.Image")));
            outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            outilsToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            outilsToolStripMenuItem.Text = "Configuration des outils";
            outilsToolStripMenuItem.Click += new System.EventHandler(outilsToolStripMenuItem_Click);
            // 
            // testPreviewEmulateurCrystalRepportToolStripMenuItem
            // 
            testPreviewEmulateurCrystalRepportToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            testPreviewEmulateurCrystalRepportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            commandesToolStripMenuItem,
            contactsToolStripMenuItem1,
            horrairesToolStripMenuItem,
            listesToolStripMenuItem,
            formulairesToolStripMenuItem});
            testPreviewEmulateurCrystalRepportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            testPreviewEmulateurCrystalRepportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testPreviewEmulateurCrystalRepportToolStripMenuItem.Image")));
            testPreviewEmulateurCrystalRepportToolStripMenuItem.Name = "testPreviewEmulateurCrystalRepportToolStripMenuItem";
            testPreviewEmulateurCrystalRepportToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            testPreviewEmulateurCrystalRepportToolStripMenuItem.Text = "Test Preview EmulateurCrystalRepport";
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            commandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            commandeToolStripMenuItem,
            commandeRecueToolStripMenuItem,
            commandeParcelToolStripMenuItem});
            commandesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            commandesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("commandesToolStripMenuItem.Image")));
            commandesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            commandesToolStripMenuItem.Text = "Commandes";
            // 
            // commandeToolStripMenuItem
            // 
            commandeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            commandeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            commandeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            commandeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("commandeToolStripMenuItem.Image")));
            commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            commandeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            commandeToolStripMenuItem.Text = "Commande";
            commandeToolStripMenuItem.Click += new System.EventHandler(commandeToolStripMenuItem_Click);
            // 
            // commandeRecueToolStripMenuItem
            // 
            commandeRecueToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            commandeRecueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            commandeRecueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("commandeRecueToolStripMenuItem.Image")));
            commandeRecueToolStripMenuItem.Name = "commandeRecueToolStripMenuItem";
            commandeRecueToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            commandeRecueToolStripMenuItem.Text = "CommandeRecue";
            commandeRecueToolStripMenuItem.Click += new System.EventHandler(commandeRecueToolStripMenuItem_Click);
            // 
            // commandeParcelToolStripMenuItem
            // 
            commandeParcelToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            commandeParcelToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            commandeParcelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            commandeParcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("commandeParcelToolStripMenuItem.Image")));
            commandeParcelToolStripMenuItem.Name = "commandeParcelToolStripMenuItem";
            commandeParcelToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            commandeParcelToolStripMenuItem.Text = "CommandeParcel";
            commandeParcelToolStripMenuItem.Click += new System.EventHandler(commandeParcelToolStripMenuItem_Click);
            // 
            // contactsToolStripMenuItem1
            // 
            contactsToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            contactsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            contactEntrepriseToolStripMenuItem,
            toolStripMenuItem25,
            contactVilleToolStripMenuItem});
            contactsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            contactsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("contactsToolStripMenuItem1.Image")));
            contactsToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            contactsToolStripMenuItem1.Name = "contactsToolStripMenuItem1";
            contactsToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            contactsToolStripMenuItem1.Text = "Contacts";
            // 
            // contactEntrepriseToolStripMenuItem
            // 
            contactEntrepriseToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            contactEntrepriseToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            contactEntrepriseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            contactEntrepriseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactEntrepriseToolStripMenuItem.Image")));
            contactEntrepriseToolStripMenuItem.Name = "contactEntrepriseToolStripMenuItem";
            contactEntrepriseToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            contactEntrepriseToolStripMenuItem.Text = "ContactEntreprise";
            contactEntrepriseToolStripMenuItem.Click += new System.EventHandler(contactEntrepriseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem25
            // 
            toolStripMenuItem25.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            toolStripMenuItem25.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem25.Image")));
            toolStripMenuItem25.Name = "toolStripMenuItem25";
            toolStripMenuItem25.Size = new System.Drawing.Size(173, 22);
            toolStripMenuItem25.Text = "ContactSingle";
            toolStripMenuItem25.Click += new System.EventHandler(contactSingleToolStripMenuItem_Click);
            // 
            // contactVilleToolStripMenuItem
            // 
            contactVilleToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            contactVilleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            contactVilleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactVilleToolStripMenuItem.Image")));
            contactVilleToolStripMenuItem.Name = "contactVilleToolStripMenuItem";
            contactVilleToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            contactVilleToolStripMenuItem.Text = "ContactVille";
            contactVilleToolStripMenuItem.Click += new System.EventHandler(contactVilleToolStripMenuItem_Click);
            // 
            // horrairesToolStripMenuItem
            // 
            horrairesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            horrairesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            sommaireHeuresToolStripMenuItem,
            feuilleDeTempsToolStripMenuItem,
            toolStripMenuItem15});
            horrairesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            horrairesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horrairesToolStripMenuItem.Image")));
            horrairesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            horrairesToolStripMenuItem.Name = "horrairesToolStripMenuItem";
            horrairesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            horrairesToolStripMenuItem.Text = "Horraires";
            // 
            // sommaireHeuresToolStripMenuItem
            // 
            sommaireHeuresToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            sommaireHeuresToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            sommaireHeuresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            sommaireHeuresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sommaireHeuresToolStripMenuItem.Image")));
            sommaireHeuresToolStripMenuItem.Name = "sommaireHeuresToolStripMenuItem";
            sommaireHeuresToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            sommaireHeuresToolStripMenuItem.Text = "SommaireHeures";
            sommaireHeuresToolStripMenuItem.Click += new System.EventHandler(sommaireHeuresToolStripMenuItem_Click);
            // 
            // feuilleDeTempsToolStripMenuItem
            // 
            feuilleDeTempsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            feuilleDeTempsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            feuilleDeTempsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("feuilleDeTempsToolStripMenuItem.Image")));
            feuilleDeTempsToolStripMenuItem.Name = "feuilleDeTempsToolStripMenuItem";
            feuilleDeTempsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            feuilleDeTempsToolStripMenuItem.Text = "Feuille de temps";
            feuilleDeTempsToolStripMenuItem.Click += new System.EventHandler(feuilleDeTempsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem15
            // 
            toolStripMenuItem15.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem15.BackgroundImage")));
            toolStripMenuItem15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            toolStripMenuItem15.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem15.Image")));
            toolStripMenuItem15.Name = "toolStripMenuItem15";
            toolStripMenuItem15.Size = new System.Drawing.Size(184, 22);
            toolStripMenuItem15.Text = "SommairePunchGRB";
            toolStripMenuItem15.Click += new System.EventHandler(toolStripMenuItem15_Click);
            // 
            // listesToolStripMenuItem
            // 
            listesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            listesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            listeAchatsToolStripMenuItem,
            listeClientToolStripMenuItem,
            listeContactToolStripMenuItem,
            listeInventaireToolStripMenuItem,
            listeProjetToolStripMenuItem,
            listePieceToolStripMenuItem});
            listesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            listesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listesToolStripMenuItem.Image")));
            listesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            listesToolStripMenuItem.Name = "listesToolStripMenuItem";
            listesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            listesToolStripMenuItem.Text = "Listes";
            // 
            // listeAchatsToolStripMenuItem
            // 
            listeAchatsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            listeAchatsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            listeAchatsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeAchatsToolStripMenuItem.Image")));
            listeAchatsToolStripMenuItem.Name = "listeAchatsToolStripMenuItem";
            listeAchatsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            listeAchatsToolStripMenuItem.Text = "ListeAchats";
            listeAchatsToolStripMenuItem.Click += new System.EventHandler(listeAchatsToolStripMenuItem_Click);
            // 
            // listeClientToolStripMenuItem
            // 
            listeClientToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            listeClientToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            listeClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeClientToolStripMenuItem.Image")));
            listeClientToolStripMenuItem.Name = "listeClientToolStripMenuItem";
            listeClientToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            listeClientToolStripMenuItem.Text = "ListeClient";
            listeClientToolStripMenuItem.Click += new System.EventHandler(listeClientToolStripMenuItem_Click);
            // 
            // listeContactToolStripMenuItem
            // 
            listeContactToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            listeContactToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            listeContactToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeContactToolStripMenuItem.Image")));
            listeContactToolStripMenuItem.Name = "listeContactToolStripMenuItem";
            listeContactToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            listeContactToolStripMenuItem.Text = "ListeContact";
            listeContactToolStripMenuItem.Click += new System.EventHandler(listeContactToolStripMenuItem_Click);
            // 
            // listeInventaireToolStripMenuItem
            // 
            listeInventaireToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            listeInventaireToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            listeInventaireToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeInventaireToolStripMenuItem.Image")));
            listeInventaireToolStripMenuItem.Name = "listeInventaireToolStripMenuItem";
            listeInventaireToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            listeInventaireToolStripMenuItem.Text = "ListeInventaire";
            listeInventaireToolStripMenuItem.Click += new System.EventHandler(listeInventaireToolStripMenuItem_Click);
            // 
            // listeProjetToolStripMenuItem
            // 
            listeProjetToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            listeProjetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            listeProjetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeProjetToolStripMenuItem.Image")));
            listeProjetToolStripMenuItem.Name = "listeProjetToolStripMenuItem";
            listeProjetToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            listeProjetToolStripMenuItem.Text = "ListeProjet";
            listeProjetToolStripMenuItem.Click += new System.EventHandler(listeProjetToolStripMenuItem_Click);
            // 
            // listePieceToolStripMenuItem
            // 
            listePieceToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            listePieceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            listePieceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listePieceToolStripMenuItem.Image")));
            listePieceToolStripMenuItem.Name = "listePieceToolStripMenuItem";
            listePieceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            listePieceToolStripMenuItem.Text = "ListePiece";
            listePieceToolStripMenuItem.Click += new System.EventHandler(listePieceToolStripMenuItem_Click);
            // 
            // formulairesToolStripMenuItem
            // 
            formulairesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            formulairesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            appercuProjetToolStripMenuItem,
            backOrderToolStripMenuItem,
            bonTravailToolStripMenuItem,
            clientsToolStripMenuItem1,
            conceptionToolStripMenuItem,
            demandePrixToolStripMenuItem,
            facturationToolStripMenuItem1,
            françaisToolStripMenuItem,
            anglaisToolStripMenuItem,
            fermeMecaniqueToolStripMenuItem,
            fermetureToolStripMenuItem,
            finFabricationToolStripMenuItem,
            fournisseurToolStripMenuItem,
            électriqueToolStripMenuItem4,
            mécaniqueToolStripMenuItem4,
            outilsInOutToolStripMenuItem,
            outilsMachinerieToolStripMenuItem,
            problemesToolStripMenuItem,
            programmationToolStripMenuItem,
            receptionToolStripMenuItem,
            retourToolStripMenuItem,
            toolStripMenuItem16,
            tempsElecToolStripMenuItem,
            toolStripMenuItem19,
            tempsMecToolStripMenuItem,
            toolStripMenuItem21});
            formulairesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            formulairesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("formulairesToolStripMenuItem.Image")));
            formulairesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            formulairesToolStripMenuItem.Name = "formulairesToolStripMenuItem";
            formulairesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            formulairesToolStripMenuItem.Text = "Formulaires";
            // 
            // appercuProjetToolStripMenuItem
            // 
            appercuProjetToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            appercuProjetToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("appercuProjetToolStripMenuItem.BackgroundImage")));
            appercuProjetToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            appercuProjetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            appercuProjetToolStripMenuItem.Name = "appercuProjetToolStripMenuItem";
            appercuProjetToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            appercuProjetToolStripMenuItem.Text = "AppercuProjet";
            appercuProjetToolStripMenuItem.Click += new System.EventHandler(appercuProjetToolStripMenuItem_Click);
            // 
            // backOrderToolStripMenuItem
            // 
            backOrderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            backOrderToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backOrderToolStripMenuItem.BackgroundImage")));
            backOrderToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            backOrderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            backOrderToolStripMenuItem.Name = "backOrderToolStripMenuItem";
            backOrderToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            backOrderToolStripMenuItem.Text = "BackOrder";
            backOrderToolStripMenuItem.Click += new System.EventHandler(backOrderToolStripMenuItem_Click);
            // 
            // bonTravailToolStripMenuItem
            // 
            bonTravailToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            bonTravailToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bonTravailToolStripMenuItem.BackgroundImage")));
            bonTravailToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            bonTravailToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            bonTravailToolStripMenuItem.Name = "bonTravailToolStripMenuItem";
            bonTravailToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            bonTravailToolStripMenuItem.Text = "Bon de travail";
            bonTravailToolStripMenuItem.Click += new System.EventHandler(bonTravailToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem1
            // 
            clientsToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            clientsToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientsToolStripMenuItem1.BackgroundImage")));
            clientsToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            clientsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            clientsToolStripMenuItem1.Name = "clientsToolStripMenuItem1";
            clientsToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            clientsToolStripMenuItem1.Text = "Clients";
            clientsToolStripMenuItem1.Click += new System.EventHandler(clientsToolStripMenuItem1_Click);
            // 
            // conceptionToolStripMenuItem
            // 
            conceptionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            conceptionToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("conceptionToolStripMenuItem.BackgroundImage")));
            conceptionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            conceptionToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            conceptionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            conceptionToolStripMenuItem.Name = "conceptionToolStripMenuItem";
            conceptionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            conceptionToolStripMenuItem.Text = "Conception";
            conceptionToolStripMenuItem.Click += new System.EventHandler(conceptionToolStripMenuItem_Click);
            // 
            // demandePrixToolStripMenuItem
            // 
            demandePrixToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            demandePrixToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("demandePrixToolStripMenuItem.BackgroundImage")));
            demandePrixToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            demandePrixToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            demandePrixToolStripMenuItem.Name = "demandePrixToolStripMenuItem";
            demandePrixToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            demandePrixToolStripMenuItem.Text = "Demande de prix";
            demandePrixToolStripMenuItem.Click += new System.EventHandler(demandePrixToolStripMenuItem_Click);
            // 
            // facturationToolStripMenuItem1
            // 
            facturationToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            facturationToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("facturationToolStripMenuItem1.BackgroundImage")));
            facturationToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            facturationToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            facturationToolStripMenuItem1.Name = "facturationToolStripMenuItem1";
            facturationToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            facturationToolStripMenuItem1.Text = "Facturation";
            facturationToolStripMenuItem1.Click += new System.EventHandler(facturationToolStripMenuItem1_Click);
            // 
            // françaisToolStripMenuItem
            // 
            françaisToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            françaisToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("françaisToolStripMenuItem.BackgroundImage")));
            françaisToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            françaisToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            françaisToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            françaisToolStripMenuItem.Name = "françaisToolStripMenuItem";
            françaisToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            françaisToolStripMenuItem.Text = "Fax français";
            françaisToolStripMenuItem.Click += new System.EventHandler(françaisToolStripMenuItem_Click);
            // 
            // anglaisToolStripMenuItem
            // 
            anglaisToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            anglaisToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anglaisToolStripMenuItem.BackgroundImage")));
            anglaisToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            anglaisToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            anglaisToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            anglaisToolStripMenuItem.Name = "anglaisToolStripMenuItem";
            anglaisToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            anglaisToolStripMenuItem.Text = "Fax anglais";
            anglaisToolStripMenuItem.Click += new System.EventHandler(anglaisToolStripMenuItem_Click);
            // 
            // fermeMecaniqueToolStripMenuItem
            // 
            fermeMecaniqueToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            fermeMecaniqueToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fermeMecaniqueToolStripMenuItem.BackgroundImage")));
            fermeMecaniqueToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            fermeMecaniqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            fermeMecaniqueToolStripMenuItem.Name = "fermeMecaniqueToolStripMenuItem";
            fermeMecaniqueToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            fermeMecaniqueToolStripMenuItem.Text = "Fermeture mécanique";
            fermeMecaniqueToolStripMenuItem.Click += new System.EventHandler(fermeMecaniqueToolStripMenuItem_Click);
            // 
            // fermetureToolStripMenuItem
            // 
            fermetureToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            fermetureToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fermetureToolStripMenuItem.BackgroundImage")));
            fermetureToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            fermetureToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            fermetureToolStripMenuItem.Name = "fermetureToolStripMenuItem";
            fermetureToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            fermetureToolStripMenuItem.Text = "Fermeture";
            fermetureToolStripMenuItem.Click += new System.EventHandler(fermetureToolStripMenuItem_Click);
            // 
            // finFabricationToolStripMenuItem
            // 
            finFabricationToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            finFabricationToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finFabricationToolStripMenuItem.BackgroundImage")));
            finFabricationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            finFabricationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            finFabricationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            finFabricationToolStripMenuItem.Name = "finFabricationToolStripMenuItem";
            finFabricationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            finFabricationToolStripMenuItem.Text = "Fin fabrication";
            finFabricationToolStripMenuItem.Click += new System.EventHandler(finFabricationToolStripMenuItem_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            fournisseurToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            fournisseurToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fournisseurToolStripMenuItem.BackgroundImage")));
            fournisseurToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            fournisseurToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            fournisseurToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            fournisseurToolStripMenuItem.Text = "Fournisseur";
            fournisseurToolStripMenuItem.Click += new System.EventHandler(fournisseurToolStripMenuItem_Click);
            // 
            // électriqueToolStripMenuItem4
            // 
            électriqueToolStripMenuItem4.BackColor = System.Drawing.Color.Black;
            électriqueToolStripMenuItem4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("électriqueToolStripMenuItem4.BackgroundImage")));
            électriqueToolStripMenuItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            électriqueToolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            électriqueToolStripMenuItem4.Name = "électriqueToolStripMenuItem4";
            électriqueToolStripMenuItem4.Size = new System.Drawing.Size(190, 22);
            électriqueToolStripMenuItem4.Text = "InventaireÉlectrique";
            électriqueToolStripMenuItem4.Click += new System.EventHandler(électriqueToolStripMenuItem4_Click);
            // 
            // mécaniqueToolStripMenuItem4
            // 
            mécaniqueToolStripMenuItem4.BackColor = System.Drawing.Color.Black;
            mécaniqueToolStripMenuItem4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mécaniqueToolStripMenuItem4.BackgroundImage")));
            mécaniqueToolStripMenuItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            mécaniqueToolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            mécaniqueToolStripMenuItem4.Name = "mécaniqueToolStripMenuItem4";
            mécaniqueToolStripMenuItem4.Size = new System.Drawing.Size(190, 22);
            mécaniqueToolStripMenuItem4.Text = "InventaireMécanique";
            mécaniqueToolStripMenuItem4.Click += new System.EventHandler(mécaniqueToolStripMenuItem4_Click);
            // 
            // outilsInOutToolStripMenuItem
            // 
            outilsInOutToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            outilsInOutToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("outilsInOutToolStripMenuItem.BackgroundImage")));
            outilsInOutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            outilsInOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            outilsInOutToolStripMenuItem.Name = "outilsInOutToolStripMenuItem";
            outilsInOutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            outilsInOutToolStripMenuItem.Text = "OutilsInOut";
            outilsInOutToolStripMenuItem.Click += new System.EventHandler(outilsInOutToolStripMenuItem_Click);
            // 
            // outilsMachinerieToolStripMenuItem
            // 
            outilsMachinerieToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            outilsMachinerieToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("outilsMachinerieToolStripMenuItem.BackgroundImage")));
            outilsMachinerieToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            outilsMachinerieToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            outilsMachinerieToolStripMenuItem.Name = "outilsMachinerieToolStripMenuItem";
            outilsMachinerieToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            outilsMachinerieToolStripMenuItem.Text = "OutilsMachinerie";
            outilsMachinerieToolStripMenuItem.Click += new System.EventHandler(outilsMachinerieToolStripMenuItem_Click);
            // 
            // problemesToolStripMenuItem
            // 
            problemesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            problemesToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("problemesToolStripMenuItem.BackgroundImage")));
            problemesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            problemesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            problemesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            problemesToolStripMenuItem.Name = "problemesToolStripMenuItem";
            problemesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            problemesToolStripMenuItem.Text = "Problemes";
            problemesToolStripMenuItem.Click += new System.EventHandler(problemesToolStripMenuItem_Click);
            // 
            // programmationToolStripMenuItem
            // 
            programmationToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            programmationToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("programmationToolStripMenuItem.BackgroundImage")));
            programmationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            programmationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            programmationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            programmationToolStripMenuItem.Name = "programmationToolStripMenuItem";
            programmationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            programmationToolStripMenuItem.Text = "Programmation";
            programmationToolStripMenuItem.Click += new System.EventHandler(programmationToolStripMenuItem_Click);
            // 
            // receptionToolStripMenuItem
            // 
            receptionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            receptionToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("receptionToolStripMenuItem.BackgroundImage")));
            receptionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            receptionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            receptionToolStripMenuItem.Name = "receptionToolStripMenuItem";
            receptionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            receptionToolStripMenuItem.Text = "Reception";
            receptionToolStripMenuItem.Click += new System.EventHandler(receptionToolStripMenuItem_Click);
            // 
            // retourToolStripMenuItem
            // 
            retourToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            retourToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retourToolStripMenuItem.BackgroundImage")));
            retourToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            retourToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            retourToolStripMenuItem.Name = "retourToolStripMenuItem";
            retourToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            retourToolStripMenuItem.Text = "Retour";
            retourToolStripMenuItem.Click += new System.EventHandler(retourToolStripMenuItem_Click);
            // 
            // toolStripMenuItem16
            // 
            toolStripMenuItem16.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem16.BackgroundImage")));
            toolStripMenuItem16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            toolStripMenuItem16.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem16.Name = "toolStripMenuItem16";
            toolStripMenuItem16.Size = new System.Drawing.Size(190, 22);
            toolStripMenuItem16.Text = "SoumissionElec";
            toolStripMenuItem16.Click += new System.EventHandler(toolStripMenuItem16_Click);
            // 
            // tempsElecToolStripMenuItem
            // 
            tempsElecToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            tempsElecToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tempsElecToolStripMenuItem.BackgroundImage")));
            tempsElecToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tempsElecToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            tempsElecToolStripMenuItem.Name = "tempsElecToolStripMenuItem";
            tempsElecToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            tempsElecToolStripMenuItem.Text = "TempsElec";
            tempsElecToolStripMenuItem.Click += new System.EventHandler(tempsElecToolStripMenuItem_Click);
            // 
            // toolStripMenuItem19
            // 
            toolStripMenuItem19.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem19.BackgroundImage")));
            toolStripMenuItem19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            toolStripMenuItem19.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem19.Name = "toolStripMenuItem19";
            toolStripMenuItem19.Size = new System.Drawing.Size(190, 22);
            toolStripMenuItem19.Text = "SoumissionMec";
            toolStripMenuItem19.Click += new System.EventHandler(toolStripMenuItem19_Click);
            // 
            // tempsMecToolStripMenuItem
            // 
            tempsMecToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            tempsMecToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            tempsMecToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tempsMecToolStripMenuItem.Image")));
            tempsMecToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tempsMecToolStripMenuItem.Name = "tempsMecToolStripMenuItem";
            tempsMecToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            tempsMecToolStripMenuItem.Text = "TempsMec";
            tempsMecToolStripMenuItem.Click += new System.EventHandler(tempsMecToolStripMenuItem_Click);
            // 
            // toolStripMenuItem21
            // 
            toolStripMenuItem21.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem21.BackgroundImage")));
            toolStripMenuItem21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            toolStripMenuItem21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            toolStripMenuItem21.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem21.Name = "toolStripMenuItem21";
            toolStripMenuItem21.Size = new System.Drawing.Size(190, 22);
            toolStripMenuItem21.Text = "Commande";
            toolStripMenuItem21.Click += new System.EventHandler(commandeToolStripMenuItem_Click);
            // 
            // databaseWizzardToolStripMenuItem
            // 
            databaseWizzardToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            databaseWizzardToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            databaseWizzardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("databaseWizzardToolStripMenuItem.Image")));
            databaseWizzardToolStripMenuItem.Name = "databaseWizzardToolStripMenuItem";
            databaseWizzardToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            databaseWizzardToolStripMenuItem.Text = "Synchronisation des Punchs MDB";
            databaseWizzardToolStripMenuItem.Click += new System.EventHandler(cmdConfiguration_Click);
            // 
            // configurationDBToolStripMenuItem
            // 
            configurationDBToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            configurationDBToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            configurationDBToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configurationDBToolStripMenuItem.Image")));
            configurationDBToolStripMenuItem.Name = "configurationDBToolStripMenuItem";
            configurationDBToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            configurationDBToolStripMenuItem.Text = "Configuration DB";
            configurationDBToolStripMenuItem.Click += new System.EventHandler(ConfigurationDB_Click);
            // 
            // CmdChangerDB
            // 
            CmdChangerDB.BackColor = System.Drawing.Color.Black;
            CmdChangerDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            CmdChangerDB.Image = ((System.Drawing.Image)(resources.GetObject("CmdChangerDB.Image")));
            CmdChangerDB.Name = "CmdChangerDB";
            CmdChangerDB.Size = new System.Drawing.Size(273, 22);
            CmdChangerDB.Text = "Modifier la base de donnée";
            CmdChangerDB.Click += new System.EventHandler(ModifierDB_Click);
            // 
            // rapportsToolStripMenuItem
            // 
            rapportsToolStripMenuItem.AutoToolTip = true;
            rapportsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            rapportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            testsRapportsToolStripMenuItem,
            invenaireComptableToolStripMenuItem,
            cmdRéceptionTMensuelle,
            facturationToolStripMenuItem});
            rapportsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            rapportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            rapportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rapportsToolStripMenuItem.Image")));
            rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            rapportsToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            rapportsToolStripMenuItem.Text = "Comptabilité";
            rapportsToolStripMenuItem.Click += new System.EventHandler(rapportsToolStripMenuItem_Click);
            // 
            // testsRapportsToolStripMenuItem
            // 
            testsRapportsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            testsRapportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            testsRapportsToolStripMenuItem.Name = "testsRapportsToolStripMenuItem";
            testsRapportsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            testsRapportsToolStripMenuItem.Text = "Tests Rapports";
            testsRapportsToolStripMenuItem.Click += new System.EventHandler(testsRapportsToolStripMenuItem_Click);
            // 
            // invenaireComptableToolStripMenuItem
            // 
            invenaireComptableToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            invenaireComptableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            électriqueToolStripMenuItem1,
            mécaniqueToolStripMenuItem1});
            invenaireComptableToolStripMenuItem.Enabled = false;
            invenaireComptableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            invenaireComptableToolStripMenuItem.Name = "invenaireComptableToolStripMenuItem";
            invenaireComptableToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            invenaireComptableToolStripMenuItem.Text = "Invenaire Comptable";
            // 
            // électriqueToolStripMenuItem1
            // 
            électriqueToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            électriqueToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            électriqueToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("électriqueToolStripMenuItem1.Image")));
            électriqueToolStripMenuItem1.Name = "électriqueToolStripMenuItem1";
            électriqueToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            électriqueToolStripMenuItem1.Text = "Électrique";
            électriqueToolStripMenuItem1.Click += new System.EventHandler(électriqueToolStripMenuItem1_Click);
            // 
            // mécaniqueToolStripMenuItem1
            // 
            mécaniqueToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            mécaniqueToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            mécaniqueToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("mécaniqueToolStripMenuItem1.Image")));
            mécaniqueToolStripMenuItem1.Name = "mécaniqueToolStripMenuItem1";
            mécaniqueToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            mécaniqueToolStripMenuItem1.Text = "Mécanique";
            mécaniqueToolStripMenuItem1.Click += new System.EventHandler(mécaniqueToolStripMenuItem1_Click);
            // 
            // cmdRéceptionTMensuelle
            // 
            cmdRéceptionTMensuelle.BackColor = System.Drawing.Color.Black;
            cmdRéceptionTMensuelle.ForeColor = System.Drawing.Color.White;
            cmdRéceptionTMensuelle.Image = ((System.Drawing.Image)(resources.GetObject("cmdRéceptionTMensuelle.Image")));
            cmdRéceptionTMensuelle.Name = "cmdRéceptionTMensuelle";
            cmdRéceptionTMensuelle.Size = new System.Drawing.Size(188, 22);
            cmdRéceptionTMensuelle.Text = "Bilan réception";
            cmdRéceptionTMensuelle.Click += new System.EventHandler(cmdRéceptionTMensuelle_Click);
            // 
            // facturationToolStripMenuItem
            // 
            facturationToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            facturationToolStripMenuItem.Enabled = false;
            facturationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            facturationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            facturationToolStripMenuItem.Name = "facturationToolStripMenuItem";
            facturationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            facturationToolStripMenuItem.Text = "Facturation";
            facturationToolStripMenuItem.Click += new System.EventHandler(facturationToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem1
            // 
            outilsToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            outilsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            screenShotToolStripMenuItem,
            toolStripMenuItem14,
            billeteriebétaToolStripMenuItem,
            emailsSurExchangeToolStripMenuItem,
            captureDécranToolStripMenuItem});
            outilsToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            outilsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            outilsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("outilsToolStripMenuItem1.Image")));
            outilsToolStripMenuItem1.Name = "outilsToolStripMenuItem1";
            outilsToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            outilsToolStripMenuItem1.Text = "&Outils";
            // 
            // screenShotToolStripMenuItem
            // 
            screenShotToolStripMenuItem.AutoSize = false;
            screenShotToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            screenShotToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            screenShotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("screenShotToolStripMenuItem.Image")));
            screenShotToolStripMenuItem.Name = "screenShotToolStripMenuItem";
            screenShotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            screenShotToolStripMenuItem.Text = "ScreenShot";
            screenShotToolStripMenuItem.Click += new System.EventHandler(screenShotToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            toolStripMenuItem14.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem14.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem14.Image")));
            toolStripMenuItem14.Name = "toolStripMenuItem14";
            toolStripMenuItem14.Size = new System.Drawing.Size(193, 22);
            toolStripMenuItem14.Text = "Sélecteur de rapports";
            // 
            // billeteriebétaToolStripMenuItem
            // 
            billeteriebétaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            billeteriebétaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            billeteriebétaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("billeteriebétaToolStripMenuItem.Image")));
            billeteriebétaToolStripMenuItem.Name = "billeteriebétaToolStripMenuItem";
            billeteriebétaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            billeteriebétaToolStripMenuItem.Text = "Billeterie (béta)";
            billeteriebétaToolStripMenuItem.Click += new System.EventHandler(toolStripButton3_Click);
            // 
            // emailsSurExchangeToolStripMenuItem
            // 
            emailsSurExchangeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            emailsSurExchangeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            emailsSurExchangeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emailsSurExchangeToolStripMenuItem.Image")));
            emailsSurExchangeToolStripMenuItem.Name = "emailsSurExchangeToolStripMenuItem";
            emailsSurExchangeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            emailsSurExchangeToolStripMenuItem.Text = "Emails sur Exchange";
            emailsSurExchangeToolStripMenuItem.Click += new System.EventHandler(button4_Click);
            // 
            // captureDécranToolStripMenuItem
            // 
            captureDécranToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            captureDécranToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            captureDécranToolStripMenuItem.Name = "captureDécranToolStripMenuItem";
            captureDécranToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            captureDécranToolStripMenuItem.Text = "Capture d\'écran";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem2,
            toolStripMenuItem3,
            toolStripMenuItem4,
            toolStripMenuItem5,
            toolStripMenuItem7,
            toolStripMenuItem6});
            toolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            toolStripMenuItem1.Text = "&Fenêtres";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(194, 22);
            toolStripMenuItem2.Text = "&Nouvelle fenêtre";
            toolStripMenuItem2.Click += new System.EventHandler(toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(194, 22);
            toolStripMenuItem3.Text = "&Cascade";
            toolStripMenuItem3.Click += new System.EventHandler(toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(194, 22);
            toolStripMenuItem4.Text = "Mosaïque &verticale";
            toolStripMenuItem4.Click += new System.EventHandler(toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new System.Drawing.Size(194, 22);
            toolStripMenuItem5.Text = "Mosaïque &horizontale";
            toolStripMenuItem5.Click += new System.EventHandler(toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem7.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new System.Drawing.Size(194, 22);
            toolStripMenuItem7.Text = "&Réorganiser les icônes";
            toolStripMenuItem7.Click += new System.EventHandler(toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new System.Drawing.Size(194, 22);
            toolStripMenuItem6.Text = "&Fermer tout";
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            àproposdeToolStripMenuItem,
            lblVersion,
            ClefHash});
            aideToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            aideToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            aideToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aideToolStripMenuItem.Image")));
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            aideToolStripMenuItem.Text = "&Aide";
            // 
            // àproposdeToolStripMenuItem
            // 
            àproposdeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            àproposdeToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            àproposdeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("àproposdeToolStripMenuItem.Image")));
            àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
            àproposdeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            àproposdeToolStripMenuItem.Text = "À &propos de..";
            àproposdeToolStripMenuItem.Click += new System.EventHandler(àproposdeToolStripMenuItem_Click);
            // 
            // lblVersion
            // 
            lblVersion.BackColor = System.Drawing.Color.Black;
            lblVersion.ForeColor = System.Drawing.Color.LightSeaGreen;
            lblVersion.Image = ((System.Drawing.Image)(resources.GetObject("lblVersion.Image")));
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(146, 22);
            lblVersion.Text = "Version DB";
            // 
            // ClefHash
            // 
            ClefHash.BackColor = System.Drawing.Color.Black;
            ClefHash.ForeColor = System.Drawing.Color.LightSeaGreen;
            ClefHash.Image = ((System.Drawing.Image)(resources.GetObject("ClefHash.Image")));
            ClefHash.Name = "ClefHash";
            ClefHash.Size = new System.Drawing.Size(146, 22);
            ClefHash.Text = "ClefHash";
            // 
            // toolStripMenuItem17
            // 
            toolStripMenuItem17.BackColor = System.Drawing.Color.Black;
            toolStripMenuItem17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            toolStripMenuItem17.ForeColor = System.Drawing.Color.White;
            toolStripMenuItem17.Name = "toolStripMenuItem17";
            toolStripMenuItem17.Size = new System.Drawing.Size(12, 20);
            // 
            // lbldb
            // 
            lbldb.BackColor = System.Drawing.Color.Black;
            lbldb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lbldb.ForeColor = System.Drawing.Color.White;
            lbldb.Name = "lbldb";
            lbldb.Size = new System.Drawing.Size(12, 20);
            // 
            // lblDerniereVersion
            // 
            lblDerniereVersion.BackColor = System.Drawing.Color.Black;
            lblDerniereVersion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            lblDerniereVersion.ForeColor = System.Drawing.Color.White;
            lblDerniereVersion.Name = "lblDerniereVersion";
            lblDerniereVersion.Size = new System.Drawing.Size(12, 20);
            lblDerniereVersion.Click += new System.EventHandler(lblDerniereVersion_Click);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            quitterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            quitterToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += new System.EventHandler(quitterToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Black;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem18,
            punchToolStripMenuItem,
            inventaireToolStripMenuItem,
            projetsSoumissionsToolStripMenuItem,
            catalogueToolStripMenuItem,
            employésToolStripMenuItem,
            toolStripMenuItem8,
            rapportsToolStripMenuItem,
            outilsToolStripMenuItem1,
            toolStripMenuItem1,
            aideToolStripMenuItem,
            toolStripMenuItem17,
            lbldb,
            lblDerniereVersion,
            quitterToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            menuStrip1.Size = new System.Drawing.Size(1438, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(menuStrip1_ItemClicked);
            // 
            // txtStatus
            // 
            txtStatus.ForeColor = System.Drawing.Color.White;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(1243, 17);
            txtStatus.Spring = true;
            // 
            // IdNetLogin
            // 
            IdNetLogin.Name = "IdNetLogin";
            IdNetLogin.Size = new System.Drawing.Size(0, 17);
            // 
            // idNoEmploye
            // 
            idNoEmploye.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            idNoEmploye.Name = "idNoEmploye";
            idNoEmploye.Size = new System.Drawing.Size(0, 17);
            // 
            // idLoginEmploye
            // 
            idLoginEmploye.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            idLoginEmploye.Name = "idLoginEmploye";
            idLoginEmploye.Size = new System.Drawing.Size(10, 17);
            idLoginEmploye.Text = " ";
            // 
            // idGroupeEmploye
            // 
            idGroupeEmploye.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            idGroupeEmploye.Name = "idGroupeEmploye";
            idGroupeEmploye.Size = new System.Drawing.Size(10, 17);
            idGroupeEmploye.Text = " ";
            // 
            // idNomEmploye
            // 
            idNomEmploye.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            idNomEmploye.Name = "idNomEmploye";
            idNomEmploye.Size = new System.Drawing.Size(10, 17);
            idNomEmploye.Text = " ";
            // 
            // idDateToday
            // 
            idDateToday.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            idDateToday.Name = "idDateToday";
            idDateToday.Size = new System.Drawing.Size(10, 17);
            idDateToday.Text = " ";
            // 
            // idNomSemaine
            // 
            idNomSemaine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            idNomSemaine.ForeColor = System.Drawing.Color.Brown;
            idNomSemaine.Name = "idNomSemaine";
            idNomSemaine.Size = new System.Drawing.Size(10, 17);
            idNomSemaine.Text = " ";
            // 
            // IdIPs
            // 
            IdIPs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            IdIPs.ImageTransparentColor = System.Drawing.Color.Magenta;
            IdIPs.Name = "IdIPs";
            IdIPs.Size = new System.Drawing.Size(13, 20);
            // 
            // idInitiales
            // 
            idInitiales.Name = "idInitiales";
            idInitiales.Size = new System.Drawing.Size(53, 17);
            idInitiales.Text = "Initiales";
            idInitiales.Click += new System.EventHandler(idInitiales_Click);
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            StatusLabel.ForeColor = System.Drawing.Color.White;
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(64, 17);
            StatusLabel.Text = "StatusLabel";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = System.Drawing.Color.Black;
            statusStrip1.Font = new System.Drawing.Font("Calibri", 9F);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            txtStatus,
            IdNetLogin,
            idNoEmploye,
            idLoginEmploye,
            idGroupeEmploye,
            idNomEmploye,
            idDateToday,
            idNomSemaine,
            IdIPs,
            idInitiales,
            StatusLabel});
            statusStrip1.Location = new System.Drawing.Point(0, 672);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1438, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = " ";
            // 
            // cmdquitter
            // 
            cmdquitter.AutoSize = true;
            cmdquitter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdquitter.BackColor = System.Drawing.SystemColors.Window;
            cmdquitter.Dock = System.Windows.Forms.DockStyle.Right;
            cmdquitter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            cmdquitter.ForeColor = System.Drawing.Color.Red;
            cmdquitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cmdquitter.Location = new System.Drawing.Point(1383, 0);
            cmdquitter.Name = "cmdquitter";
            cmdquitter.Size = new System.Drawing.Size(55, 29);
            cmdquitter.TabIndex = 33;
            cmdquitter.Text = "&Quitter";
            cmdquitter.UseVisualStyleBackColor = true;
            cmdquitter.Click += new System.EventHandler(quitterToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            pictureBox1.Image = global::ControleurServeur.Properties.Resources.drapeauGRB;
            pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox1.Location = new System.Drawing.Point(1285, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(98, 29);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(clientsToolStripMenuItem);
            panel1.Controls.Add(fournisseursToolStripMenuItem);
            panel1.Controls.Add(céduleToolStripMenuItem);
            panel1.Controls.Add(contactsToolStripMenuItem);
            panel1.Controls.Add(contactsPourVendeursToolStripMenuItem);
            panel1.Controls.Add(listeDeDistributionToolStripMenuItem);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cmdFormulaire);
            panel1.Controls.Add(cmdInventaire);
            panel1.Controls.Add(cmdPunch);
            panel1.Controls.Add(cmdquitter);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1438, 29);
            panel1.TabIndex = 7;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            clientsToolStripMenuItem.Dock = System.Windows.Forms.DockStyle.Right;
            clientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsToolStripMenuItem.Image")));
            clientsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            clientsToolStripMenuItem.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            clientsToolStripMenuItem.Location = new System.Drawing.Point(706, 0);
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            clientsToolStripMenuItem.TabIndex = 45;
            clientsToolStripMenuItem.TabStop = true;
            clientsToolStripMenuItem.Text = "Clients";
            clientsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            clientsToolStripMenuItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(cmdClient_Click);
            // 
            // fournisseursToolStripMenuItem
            // 
            fournisseursToolStripMenuItem.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            fournisseursToolStripMenuItem.Dock = System.Windows.Forms.DockStyle.Right;
            fournisseursToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fournisseursToolStripMenuItem.Image")));
            fournisseursToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            fournisseursToolStripMenuItem.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            fournisseursToolStripMenuItem.Location = new System.Drawing.Point(768, 0);
            fournisseursToolStripMenuItem.Name = "fournisseursToolStripMenuItem";
            fournisseursToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            fournisseursToolStripMenuItem.TabIndex = 44;
            fournisseursToolStripMenuItem.TabStop = true;
            fournisseursToolStripMenuItem.Text = "Fournisseurs";
            fournisseursToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            fournisseursToolStripMenuItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(cmdFournisseur_Click);
            // 
            // céduleToolStripMenuItem
            // 
            céduleToolStripMenuItem.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            céduleToolStripMenuItem.Dock = System.Windows.Forms.DockStyle.Right;
            céduleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("céduleToolStripMenuItem.Image")));
            céduleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            céduleToolStripMenuItem.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            céduleToolStripMenuItem.Location = new System.Drawing.Point(862, 0);
            céduleToolStripMenuItem.Name = "céduleToolStripMenuItem";
            céduleToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            céduleToolStripMenuItem.TabIndex = 43;
            céduleToolStripMenuItem.TabStop = true;
            céduleToolStripMenuItem.Text = "Cédule";
            céduleToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            céduleToolStripMenuItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(cmdCedule_Click);
            // 
            // contactsToolStripMenuItem
            // 
            contactsToolStripMenuItem.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            contactsToolStripMenuItem.Dock = System.Windows.Forms.DockStyle.Right;
            contactsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsToolStripMenuItem.Image")));
            contactsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            contactsToolStripMenuItem.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            contactsToolStripMenuItem.Location = new System.Drawing.Point(926, 0);
            contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            contactsToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            contactsToolStripMenuItem.TabIndex = 42;
            contactsToolStripMenuItem.TabStop = true;
            contactsToolStripMenuItem.Text = "Contacts";
            contactsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            contactsToolStripMenuItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(cmdContact_Click);
            // 
            // contactsPourVendeursToolStripMenuItem
            // 
            contactsPourVendeursToolStripMenuItem.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            contactsPourVendeursToolStripMenuItem.Dock = System.Windows.Forms.DockStyle.Right;
            contactsPourVendeursToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsPourVendeursToolStripMenuItem.Image")));
            contactsPourVendeursToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            contactsPourVendeursToolStripMenuItem.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            contactsPourVendeursToolStripMenuItem.Location = new System.Drawing.Point(996, 0);
            contactsPourVendeursToolStripMenuItem.Name = "contactsPourVendeursToolStripMenuItem";
            contactsPourVendeursToolStripMenuItem.Size = new System.Drawing.Size(154, 29);
            contactsPourVendeursToolStripMenuItem.TabIndex = 41;
            contactsPourVendeursToolStripMenuItem.TabStop = true;
            contactsPourVendeursToolStripMenuItem.Text = "Contacts pour vendeurs ";
            contactsPourVendeursToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            contactsPourVendeursToolStripMenuItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(cmdVendeur_Click);
            // 
            // listeDeDistributionToolStripMenuItem
            // 
            listeDeDistributionToolStripMenuItem.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            listeDeDistributionToolStripMenuItem.Dock = System.Windows.Forms.DockStyle.Right;
            listeDeDistributionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeDeDistributionToolStripMenuItem.Image")));
            listeDeDistributionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            listeDeDistributionToolStripMenuItem.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            listeDeDistributionToolStripMenuItem.Location = new System.Drawing.Point(1150, 0);
            listeDeDistributionToolStripMenuItem.Name = "listeDeDistributionToolStripMenuItem";
            listeDeDistributionToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            listeDeDistributionToolStripMenuItem.TabIndex = 40;
            listeDeDistributionToolStripMenuItem.TabStop = true;
            listeDeDistributionToolStripMenuItem.Text = "Liste de distribution ";
            listeDeDistributionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            listeDeDistributionToolStripMenuItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(cmdDistList_Click);
            // 
            // Conteneur
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1438, 694);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            HelpButton = true;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            IsMdiContainer = true;
            Name = "Conteneur";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Conteneur";
            TransparencyKey = System.Drawing.Color.Navy;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(Conteneur_FormClosing);
            Load += new System.EventHandler(Conteneur_Load);
            Resize += new System.EventHandler(Conteneur_Resize);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        private void LoginSQL_Relog(object sender, EventArgs e) => Conteneur_Load(sender, e);
        private void ViewFeuillesDeTemps_Click(object sender, EventArgs e)
        {
            ViewFeuilleTemps f = new ViewFeuilleTemps();
            f.Icon = Icon;
            f.ShowInTaskbar = false;
            f.ShowIcon = true;
            f.ShowDialog();
        }
        #endregion

        internal ToolTip toolTip;
        internal System.Windows.Forms.Timer tmrAlarme;
        internal ToolTip ToolTip1;

        public Conteneur()
        {
            InitializeComponent();
            Mdi = MdiParent;
            Text = System.Windows.Forms.Application.ProductName + ".Interface.Utilisateur." + Name;
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
        }
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "") { return titleAttribute.Title; }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }
        public string AssemblyVersion { get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); } }
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0) { return "Conception Patrice Waechter-Ebling"; }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0) { return Application.ProductName; }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0) { return ""; }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0) { return "© Patrice Waechter-Ebling 2024"; }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        /// partage le MDI actif aux enfants 
        /// requis pour interactions avec la fenetre parente
        /// Exactement comme en C++
        /// public class Conteneur{
        /// public:
        ///  HWND* mdi; 
        /// }
        static public Form Mdi { get; private set; }
        /// Logique decisionnelle remaniee en vue de corespondre
        /// a une internface user simplifiee
        /// PWE 2024-06-25
        private void ActiverBoutonsGroupe()
        {
            try
            {
                clientsToolStripMenuItem.Enabled = g_bAffichageClients;
                fournisseursToolStripMenuItem.Enabled = g_bAffichageFournisseurs;
                contactsToolStripMenuItem.Enabled = g_bAffichageContacts;
                cmdFormulaire.Enabled = g_bAffichageRapports;
                employésToolStripMenuItem.Enabled = g_bAffichageEmployes;
                céduleToolStripMenuItem.Enabled = g_bAffichageCedule;
                if (g_bAffichagePunch == true | g_bModificationFeuillesTemps == true | g_bModificationFacturation == true)
                {
                    cmdPunch.Enabled = true;
                }
                else
                {
                    cmdPunch.Enabled = false;
                }
                if (g_bAffichageSoumissionsMec == true | g_bAffichageSoumissionsElec == true | g_bAffichageProjetsMec == true | g_bAffichageProjetsElec == true)
                {
                    projetsSoumissionsToolStripMenuItem.Enabled = true;
                }
                else
                {
                    projetsSoumissionsToolStripMenuItem.Enabled = false;
                }
                if (g_bAffichageCatalogueMec == true | g_bAffichageCatalogueElec == true)
                {
                    catalogueToolStripMenuItem.Enabled = true;
                }
                else
                {
                    catalogueToolStripMenuItem.Enabled = false;
                }
                if (g_bAffichageInventaireMec == true | g_bAffichageInventaireElec == true | g_bAffichageOutils == true)
                {
                    cmdInventaire.Enabled = true;
                }
                else
                {
                    cmdInventaire.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "ActiverBoutonsGroupe", ex);
            }
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.ArrangeIcons);
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        internal void InitCommandesConteneur()
        {
            try
            {
                lbldb.Text = "Base de données:Actuel";
                lbldb.Visible = true;
                if ((int)IdGroupe == 2 || (int)IdGroupe == 27) // admin  strictement ou IT
                {
                    g_admin = true;
                    CmdChangerDB.Visible = true;
                }
                else
                {
                    //                   lbldb.Visible = false;
                    CmdChangerDB.Visible = false;
                    g_admin = false;
                }
                string sVersion;
                ADODB.Recordset rstConfig;
                ActiverBoutonsGroupe();
                Text += " [" + IdNomEmploye + "]";
                sVersion = AssemblyVersion;
                lblVersion.Text = "Version " + sVersion;
                rstConfig = new Recordset();
                if (odbc.State == 0) { MessageBox.Show("La liaison OLE DB est fermée\nAbandon du programme", Application.ProductName + ".OLEDB.Liaison", MessageBoxButtons.OK, MessageBoxIcon.Stop); Application.Exit(); }
                rstConfig.Open("SELECT DerniereVersion FROM [dbo].Config", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!(rstConfig.Fields["DerniereVersion"].Value is DBNull))
                {
                    if (rstConfig.Fields["DerniereVersion"].Value != string.Empty)
                    {
                        lblDerniereVersion.Text = "Dernière Version : " + rstConfig.Fields["DerniereVersion"].Value;
                        string idKey = GetIdSecureKeyFromServer();
                        if (idKey != string.Empty)
                        {
                            lbldb.ForeColor = COLOR_BRUN;
                            lbldb.Text = $"Base de données:{LoginSQL.NomDB} Sécurisée";
                        }
                        else
                        {
                            lbldb.ForeColor = COLOR_MAGENTA;
                            lbldb.Text = $"Base de données:{LoginSQL.NomDB} non sécurisée";
                            MessageBox.Show(idKey + " n'est pas valide comme clef", Application.ProductName + ".Serveur.GetIdSecureKey", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        lblDerniereVersion.Text = "";
                    }
                }
                else
                {
                    lblDerniereVersion.Text = "";
                }
                rstConfig.Close();
                rstConfig = null;
                if ((lblDerniereVersion.Text.Replace("Version : ", "").Trim() ?? "") == (lblVersion.Text.Replace("Version", "").Trim() ?? ""))
                {
                    lblVersion.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    lblVersion.ForeColor = Color.Red;
                }
                Cursor.Current = Cursors.Default;
                button4.Enabled = true;
                rapportsToolStripMenuItem.Enabled = g_bAffichageRapports;
                électriquesToolStripMenuItem.Enabled = g_bAffichageProjetsElec;
                mécaniquesToolStripMenuItem.Enabled = g_bAffichageProjetsMec;
                électriqueToolStripMenuItem7.Enabled = g_bAffichageSoumissionsElec;
                mécaniqueToolStripMenuItem7.Enabled = g_bAffichageSoumissionsMec;
                listeDeDistributionToolStripMenuItem.Enabled = g_bModificationListeDistribution;
                réceptionsToolStripMenuItem.Enabled= g_bModificationReception;
                employésToolStripMenuItem.Enabled = g_bAffichageEmployes;
                contactsPourVendeursToolStripMenuItem.Enabled = g_bAffichageContactsVendeurs;
                contactsToolStripMenuItem.Enabled = g_bModificationContacts;
                catalogueToolStripMenuItem.Enabled = true;
                électriqueToolStripMenuItem2.Enabled = g_bAffichageCatalogueElec;
                mécaniqueToolStripMenuItem2.Enabled = g_bAffichageCatalogueMec;
                céduleToolStripMenuItem.Enabled = g_bAffichageCedule;
                fournisseursToolStripMenuItem.Enabled = g_bAffichageFournisseurs;
                électriqueToolStripMenuItem.Enabled = g_bAffichageInventaireElec;
                mécaniqueToolStripMenuItem.Enabled = g_bAffichageInventaireMec;
                outilsToolStripMenuItem.Enabled = g_bAffichageOutils;
                sortieMatérielToolStripMenuItem.Enabled = g_bAffichageOutils;
                retourMatérielToolStripMenuItem.Enabled = g_bAffichageOutils;
                configurationDBToolStripMenuItem.Enabled = g_bAffichageConfiguration;
                faireLinventairePhysiqueToolStripMenuItem.Enabled = true; ;
                invenaireComptableToolStripMenuItem.Enabled = true;
                électriqueToolStripMenuItem1.Enabled = g_bModificationInventaireElec;
                mécaniqueToolStripMenuItem1.Enabled = g_bModificationInventaireMec;
                punchToolStripMenuItem.Enabled = g_bAffichagePunch;
                punchToolStripMenuItem1.Enabled = g_bAffichagePunch;
                feuillesDeTempsToolStripMenuItem.Enabled = g_bAffichagePunch;
                facturationToolStripMenuItem.Enabled = g_bModificationFacturation;
                clientsToolStripMenuItem.Enabled = g_bAffichageClients;
                statusStrip1.Enabled = true;
                txtStatus.Enabled = true;
                IdNetLogin.Enabled = true;
                idNoEmploye.Enabled = true;
                idLoginEmploye.Enabled = true;
                idGroupeEmploye.Enabled = true;
                idNomEmploye.Enabled = true;
                idDateToday.Enabled = true;
                idNomSemaine.Enabled = true;
                catalogueToolStripMenuItem.Enabled = g_bAffichageCatalogueMec;
                céduleToolStripMenuItem.Enabled = g_bAffichageCedule;
                clientsToolStripMenuItem.Enabled = g_bAffichageClients;
                contactsToolStripMenuItem.Enabled = g_bAffichageContacts;
                employésToolStripMenuItem.Enabled = g_bAffichageEmployes;
                cmdFormulaire.Enabled = g_bAffichageRapports;
                fournisseursToolStripMenuItem.Enabled = g_bAffichageFournisseurs;
                cmdInventaire.Enabled = true;
                projetsSoumissionsToolStripMenuItem.Enabled = g_bAffichageProjetsMec;
                cmdPunch.Enabled = g_bAffichagePunch;
                céduleToolStripMenuItem.Enabled = g_bAffichageContactsVendeurs;
                cmdFormulaire.Enabled = false;
                button3.Enabled = true;
            }
            catch (Exception ex)
            {
                AfficherErreur("Conteneur", "InitCommandesConteneur", ex);
            }
        }
        internal static void InitAlarme()
        {
            try
            {
                ADODB.Recordset rstAlarme = new ADODB.Recordset();
                rstAlarme.Open($"SELECT * [DBO].FROM Alarmes WHERE NoEmploye = {idNoEmploye}", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                LogSQL($"SELECT * [DBO].FROM Alarmes WHERE NoEmploye = {idNoEmploye}", System.Windows.Forms.Application.ProductName, "InitAlarme");
                while (!rstAlarme.EOF)
                {
                    bool bAfficher = false;
                    if (rstAlarme.Fields["Date"].Value == ConvertDate(DateTime.Today))
                    {
                        bAfficher = true;
                    }
                    else if (rstAlarme.Fields["Date"].Value == ConvertDate(DateTime.Today))
                    {
                        if (rstAlarme.Fields["Heure"].Value <= DateTime.Now.ToShortTimeString())
                        {
                            bAfficher = true;
                        }
                    }
                    if (bAfficher == true)
                    {
                        Form f = new Alarme((int)rstAlarme.Fields["IDAlarme"].Value);
                        f.MdiParent = Conteneur.Mdi;
                        f.Show();
                    }
                    rstAlarme.MoveNext();
                }
                rstAlarme.Close();
                rstAlarme = null;
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "InitAlarme", ex);
            }
        }
        internal static void InitDroitsUtilisateurs()
        {
            try
            {
                ADODB.Recordset rst = new ADODB.Recordset();
                rst.Open($"SELECT * FROM [DBO].[GROUPES] WHERE [IDGroupe] = {IdGroupe}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                LogSQL($"SELECT * FROM [DBO].[GROUPES] WHERE [IDGroupe] = {IdGroupe}", System.Windows.Forms.Application.ProductName, "InitDroitsUtilisateurs");
                if (rst.Fields[1].Value is DBNull) { AfficherErreur("Conteneur", "InitDroitsUtilisateurs", new Exception("Abandon indentification login")); System.Windows.Forms.Application.Exit(); }
                idGroupeEmploye.Text = rst.Fields[1].Value;
                idGroupeEmploye.Tag = rst.Fields[0].Value;
                g_bModificationClients = (bool)rst.Fields[22].Value;
                g_bModificationListeDistribution = (bool)rst.Fields[42].Value;
                g_bModificationFeuillesTemps = (bool)rst.Fields[27].Value;
                g_bAffichageSoumissionsElec = (bool)rst.Fields[16].Value;
                g_bAffichageProjetsElec = (bool)rst.Fields[17].Value;
                g_bModificationProjetsElec = (bool)rst.Fields[32].Value;
                g_bAffichageClients = (bool)rst.Fields[2].Value;
                g_bAffichageFournisseurs = (bool)rst.Fields[3].Value;
                g_bAffichageContacts = (bool)rst.Fields[4].Value;
                g_bAffichageContactsVendeurs = (bool)rst.Fields[5].Value;
                g_bAffichageRapports = (bool)rst.Fields[6].Value;
                g_bAffichageEmployes = (bool)rst.Fields[9].Value;
                g_bAffichageCedule = (bool)rst.Fields[10].Value;
                g_bAffichageConfiguration = (bool)rst.Fields[11].Value;
                g_bAffichagePunch = (bool)rst.Fields[12].Value;
                g_bAffichageOutils = (bool)rst.Fields[13].Value;
                g_bAffichageInventaireMec = (bool)rst.Fields[18].Value;
                g_bAffichageCatalogueMec = (bool)rst.Fields[7].Value;
                g_bAffichageSoumissionsMec = (bool)rst.Fields[14].Value;
                g_bAffichageProjetsMec = (bool)rst.Fields[15].Value;
                g_bAffichageInventaireElec = (bool)rst.Fields[19].Value;
                g_bAffichageCatalogueElec = (bool)rst.Fields[8].Value;
                g_bAffichageAchats = (bool)rst.Fields[20].Value;
                g_bModificationFournisseurs = (bool)rst.Fields[23].Value;
                g_bModificationContacts = (bool)rst.Fields[24].Value;
                g_bModificationEmployes = (bool)rst.Fields[26].Value;
                g_bModificationGroupes = (bool)rst.Fields[25].Value;
                g_bModificationOutils = (bool)rst.Fields[28].Value;
                g_bModificationFacturation = (bool)rst.Fields[21].Value;
                g_bModificationBC = (bool)rst.Fields[33].Value;
                g_bModificationPunchEmployes = (bool)rst.Fields[38].Value;
                g_bModificationInventaireMec = (bool)rst.Fields[29].Value;
                g_bModificationCatalogueMec = (bool)rst.Fields[34].Value;
                g_bModificationSoumissionsMec = (bool)rst.Fields[31].Value;
                g_bModificationProjetsMec = (bool)rst.Fields[30].Value;
                g_bModificationInventaireElec = (bool)rst.Fields[37].Value;
                g_bModificationCatalogueElec = (bool)rst.Fields[34].Value;
                g_bModificationSoumissionsElec = (bool)rst.Fields[31].Value;
                g_bSuppressionProjets = (bool)rst.Fields[41].Value;
                g_bModificationReception = (bool)rst.Fields[39].Value;
                g_bModificationRetourMarchandise = (bool)rst.Fields[40].Value;
                g_bPunchSemaineAnterieure = (bool)rst.Fields[43].Value;
                g_bVerrouillageTempsProjet = (bool)rst.Fields[44].Value;
                g_bDeverrouillageTempsProjet = (bool)rst.Fields[45].Value;
                rst.Close();
                rst = null;
            }
            catch (Exception ex)
            {
                AfficherErreur("Conteneur", "InitDroitsUtilisateurs", ex);
            }
        }
        private void Conteneur_Load(object sender, EventArgs e)
        {
            RECT rc = new RECT(Width,0,0,Height);
            if(rc.Right<0x640 & rc.Bottom < 0x438)// Resolution HD
            {
               Conteneur.txtStatus.Text=$"Ce programme a été conçu pour des résolution d'au minimum 1920x1080 \n DeskTop retourne {rc.Right}x{rc.Bottom}\n Des problèmes d'affichage peuvent survenir";
            }//Developpement.GRB.local
                    Top = 0;
            Left = 0;
            AfficherDocumentationEnligne();
            Program.Skinicone = Icon;
            StatusLabel.Text = Application.ProductName + " v:" + Application.ProductVersion;
            txtStatus.TextAlign = ContentAlignment.MiddleLeft;
            cmdRéceptionTMensuelle.Text = $"Réception {GetNomMois(DateTime.Today.Month)}{DateTime.Today.Year}";
            titrePunch = GetSemaineDelaDate(DateTime.Today);
            IdNetLogin.Text = $"{Environment.UserDomainName}\\{Environment.UserName}";
            idDateToday.Text = DateTime.Today.ToLongDateString();
            idNomSemaine.ForeColor = Color.LightSalmon;
            idNomSemaine.Text = GetSemaineDelaDate(DateTime.Today);
            cmdRéceptionTMensuelle.Text = "Bilan réception " + GetNomMois(DateTime.Today.Month - 1).ToLower() + DateTime.Today.Year;
            for (int a = 0; a < Dns.GetHostAddresses(Dns.GetHostName()).Count(); a++)
            {
                IdIPs.DropDownItems.Add(Dns.GetHostAddresses(Dns.GetHostName())[a].MapToIPv4().ToString());
                SaveSetting("PWE.ControleurServeur", "LoginSQL", $"IP Poste #{a + 1}", Dns.GetHostAddresses(Dns.GetHostName())[a].MapToIPv6().ToString().Replace(":", ""));
            }
            IdIPs.Text = ip.MapToIPv4().ToString();
            if (isDevelopper() == true)
            {
                ADODB.Recordset rstEmploye = new ADODB.Recordset();
                SqlLinkODBC(rstEmploye, "AutoGRB", $"SELECT   DISTINCT * FROM [DBO].[EMPLOYÉS] WHERE ACTIF=1 AND SUPPRIMÉ= 0   AND noEMPLOYE='277' ORDER BY EMPLOYE");
                if (rstEmploye.EOF) { return; }
                if (!rstEmploye.EOF)
                {
                    ///Caster les valeurs dynamiques issues d'OLE-DB
                    IdNoEmploye = (int)rstEmploye.Fields[0].Value;
                    IdNomEmploye = (string)rstEmploye.Fields[3].Value;
                    IdLoginEmploye = (string)rstEmploye.Fields[1].Value;
                    IdPassEmploye = (string)rstEmploye.Fields[2].Value;
                    IdGroupe = (int)rstEmploye.Fields[9].Value;
                    IdFamille = rstEmploye.Fields[10].Value;
                    IdSatut = (bool)rstEmploye.Fields[8].Value;
                    Conteneur.idInitiales.Text = (string)rstEmploye.Fields[4].Value;
                    if (IdGroupe == 2) { g_admin = true; } else { g_admin = false; }
                    LoginSQL.NomDB = "AutoGRB";
                }
            }
            else
            {
                LoginSQL login = new LoginSQL();
                login.Text = $"Connexion pour le poste : {ip}";
                login.ShowDialog();
                txtStatus.Text = "Connecté à Production";
            }
            idNoEmploye.Text = IdNoEmploye.ToString();
            idLoginEmploye.Text = IdLoginEmploye;
            idGroupeEmploye.Text = IdGroupe.ToString();
            idNomEmploye.Text = IdNomEmploye;
            idDateToday.Text = DateTime.Today.ToLongDateString();
            idInitiales.Text = Conteneur.idInitiales.Text;
            ClefHash.Text = user.HashedPassword;
            ClefHash.ToolTipText = "Clef de hasshage assignée";
            InitDroitsUtilisateurs();
            InitCommandesConteneur();
            EnumFournisseurs();
            EnumManufacturiers();
            EnumClients();
            EnumCatégorieFournisseur();
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "DataBase", LoginSQL.NomDB);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "Clef de hashage", ClefHash.Text);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "Dernière connexion", idDateToday.Text);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "Nom semaine", idNomSemaine.Text);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "Bilan réception", GetNomMois(DateTime.Today.Month - 1).ToLower() + DateTime.Today.Year);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "Login réseau", IdNetLogin.Text);
            SaveSetting("PWE.ControleurServeur", "ODBC", "VersionDB", VersionDB);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "ID", Conteneur.idNoEmploye.Text);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "Initiales", Conteneur.idInitiales.Text);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "Nom", Program.IdNomEmploye);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "Login", Program.IdLoginEmploye);
            SaveSetting("PWE.ControleurServeur", "LoginSQL", "Groupe", idGroupeEmploye.Text);
            swSQL.WriteLine($"{DateTime.Now.ToString()} Début de session pour {IdNomEmploye}@{ip.MapToIPv4()}");
            user.OpenAccessWebServer();
            IsNouvelleAnneeFiscale();
        }
        private void AfficherDocumentationEnligne()
        {
            InterfaceWeb domaine = new InterfaceWeb("https://production.grb.local/documentation");
            domaine.MdiParent = this;
            domaine.ShowInTaskbar = false;
            domaine.Show();
        }

        internal static bool isDevelopper()
        {
            if ((Environment.MachineName.ToUpper() == "I9_PATRICE")) { return true; }
            return false;
        }
        private void windowsMenu_Click(object sender, EventArgs e)
        {
            Form rp = new ViewConception(false);
            rp.Text = $"Impression demandée par {IdNomEmploye} [{Conteneur.ip}\\{Environment.UserName} ]";
            rp.MdiParent = this;
            rp.Icon = Icon;
            rp.Show();
        }
        private void configurationDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Configuration();
            f.MdiParent = this;
            f.Icon = Icon;
            f.Show();
        }
        private void Conteneur_Resize(object sender, EventArgs e)
        {
            Text = Application.ProductName + " " + Application.ProductVersion + " " + Application.CompanyName + " " + ip;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            InterfaceWeb f = new InterfaceWeb("https://mail.grb-inc.com");
            f.MdiParent = this;
            f.MaximizeBox = true;
            f.ShowInTaskbar = false;
            f.WindowState = FormWindowState.Maximized;
            f.Icon = Icon;
            f.Text = "Exchange Outlook ["+idNomEmploye+"]";
            f.Show();
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void punchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new Punch(IdLoginEmploye);
            f.Text = "Punch pour " + idNomEmploye + " [" + idNoEmploye + "]   " + GetSemaineDelaDate(DateTime.Now);
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void configurationDBToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form f = new Configuration();
            f.MdiParent = this;
            f.Text = "Configuration AutoGRB";
            f.Show();
        }
        private void employésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Employe();
            f.MdiParent = this;
            f.Icon = Icon;
            f.Show();
        }
        private void ImprimerFormulaire(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void PrintForm()
        {
            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Location.X, Location.Y, 0, 0, s);
        }
        private void électriqueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form f = new CatalogueElec();
            f.MdiParent = this;
            f.Show();
        }
        private void cmdClient_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Form F = new Client();
                F.Icon = Icon;
                F.MdiParent = this;
                F.Show();
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdClient_Click", ex);
            }
        }
        private void cmdFournisseur_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Form F = new Fournisseurs();
                F.Icon = Icon;
                F.MdiParent = this;
                F.Show();
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdFournisseur_Click", ex);
            }
        }
        private void cmdContact_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Form F = new Contact();
                F.Icon = Icon;
                F.MdiParent = this;
                F.Show();
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdContact_Click", ex);
            }
        }
        private void cmdEmploye_Click(object sender, EventArgs e)
        {
            try
            {
                // Employés
                Cursor.Current = Cursors.WaitCursor;
                Form f = new Employe();
                f.Icon = Icon;
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdEmploye_Click", ex);
            }
        }
        private void cmdPunch_Click(object sender, EventArgs e)
        {
            try
            {
                Form F = new ChoixPunch();
                F.MdiParent = this;
                F.Show();
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdPunch_Click", ex);
            }
        }
        private void cmdCedule_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Form f = new Cedule();
                f.Icon = Icon;
                f.MdiParent = this;
                f.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdCedule_Click", ex);
            }
        }
        private void cmdVendeur_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Form F = new Vendeur();
                F.MdiParent = this;
                F.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdVendeur_Click", ex);
            }
        }
        private void cmdInventaire_Click(object sender, EventArgs e)
        {
        }
        private void cmdCatalogue_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new ChoixCatalogue();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdCatalogue_Click", ex);
            }
        }
        private void cmdProjSoum_Click(object sender, EventArgs e)
        {
            try
            {
                var lSize = default(int);
                var sBuffer = default(string);
                int lLCID = GetUserDefaultLCID();
                lSize = GetLocaleInfo(lLCID, 0x0E, sBuffer, lSize);
                if (sBuffer.Replace("\0", "").Trim() == ",")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Form F = new ChoixProjSoum();
                    F.MdiParent = this;
                    F.Show();
                }
                else
                {
                    if (MessageBox.Show("Vos paramètres régionaux sont incorrects!\n\nVous devez avoir la virgule (,) comme symbole de décimal!\n\nDes erreurs vont se produire dans ce formulaire car il contient des montants d'argent!\nOutrepasser la restriction ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Form f = new ChoixProjSoum();
                        f.Icon = Conteneur.ActiveForm.Icon;
                        f.Text = "Choix porjets/soumission démarrage malgres parameteres invalides ";
                        f.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdProjSoum_Click", ex);
            }
        }
        private void cmdConfiguration_Click(object sender, EventArgs e)
        {
            SynchoniserPunch sp = new SynchoniserPunch();
            sp.Text = Conteneur.ActiveForm.Text;
            sp.MdiParent = this;
            sp.ShowInTaskbar = false;
            sp.Show();
        }
        private void cmdDistList_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(OutlookProfile, "Controleur Outlook");
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Form f = new DistList();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdDistList_Click", ex);
            }
        }
        private void feuillesDeTempsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FeuilleTemps();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void facturationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Facturation();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void électriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new InventaireElec();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void mécaniqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new InventaireMec();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void outilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new outils();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void sortieMatérielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new SortieMateriel();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void retourMatérielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new RetourMarchandise();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void électriqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new InventaireComptableElectrique();
            f.Text = "Inentaire comptable électrique demandé par " + IdNomEmploye;
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void mécaniqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new InventaireComptablMecanique();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void faireLinventairePhysiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new InventairePhysique();
            f.MdiParent = this;
            f.Icon = Conteneur.ActiveForm.Icon;
            f.Text = $"Inventaire physique réalisé par {IdNomEmploye} le {DateTime.Now.ToString()}";
            f.Show();
        }
        private void mécaniqueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form f = new CatalogueMec();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void projetsSoumissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void personnaliserToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form f = new InterfaceWeb("https://production.grb.local/bugs/Billeterie.aspx?url=Logiciel&mfa= 0  &is64=1&ID=Test");
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void idInitiales_Click(object sender, EventArgs e) => MessageBox.Show($"{idNoEmploye}\n{idNomEmploye}\n{idLoginEmploye}\n{Conteneur.idInitiales.Text}\n{idGroupeEmploye}\n{IdLoginEmploye}\n{Environment.MachineName.ToUpper()}\n{Environment.OSVersion.ToString()}\n", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void Conteneur_FormClosing(object sender, FormClosingEventArgs e)
        {
            KillingOutlookProcess(); //pour eviter le pb instance unique propre a outlook 2013 &+
        }
        private void screenShotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(ImprimerFormulaire);
            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Location.X, Location.Y, 0, 0, s);
            printDocument1.Print();
        }
        private void inventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceWeb aide=new InterfaceWeb("https://production.grb.local/documentation/");
            aide.Text = Application.ProductName + "." + Name + "  " + Application.ProductVersion;
            aide.MdiParent = this;
            aide.ShowInTaskbar = false;
            aide.WindowState = FormWindowState.Maximized;
            aide.Show();
        }
        private void tmrAlarme_Tick(object sender, EventArgs e) => toolStripMenuItem17.Text = Program.GetNomJourDateFr(DateTime.Now.DayOfWeek) + " " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void closeAllToolStripMenuItem_Click_1(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);
        private void cascadeToolStripMenuItem_Click_1(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);
        private void toolStripMenuItem7_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.ArrangeIcons);
        private void toolStripMenuItem5_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);
        private void électriqueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProjSoumElec f = new ProjSoumElec();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void mécaniqueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form f = new ProjSoumMec();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form f = new ReceptionElec();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Form f = new ReceptionMec();
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Form f = new ACHAT(Program.EnumCatalogue.ELECTRIQUE);
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Form f = new ACHAT(Program.EnumCatalogue.MECANIQUE);
            f.Icon = Icon;
            f.MdiParent = this;
            f.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f = new InterfaceWeb("https://solutiongrb.com/");
            f.MdiParent = this;
            f.Icon = Icon;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        private void lblDerniereVersion_Click(object sender, EventArgs e)
        {
            if (IdGroupe == 27)
            {
                Form f = new InterfaceWeb("{webServer}/UpdateVersionDB?do=check");
                f.MdiParent = this;
                f.Icon = Icon;
                f.Show();
            }
        }
        private void printDocument1_PrintPage(object sender,
        System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font("calibri", 8, System.Drawing.FontStyle.Bold);
            e.Graphics.DrawString(Text, printFont,
                System.Drawing.Brushes.Black, 0, 0);
            e.PageSettings.Landscape = true;
            e.Graphics.FillRectangle(Brushes.Red,
              new Rectangle(500, 500, 500, 500));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.PrinterSettings.Copies = 1;
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings.Color = false;
                printDocument1.DefaultPageSettings.Landscape = isLandscape;
                /*   format de page personalisé ex pour une photo                 
            PaperSize ps = new PaperSize();
            ps.Height = 400; // 4"
            ps.Width = 500; // 5"
            printDocument1.DefaultPageSettings.PaperSize = ps;
                */
                PrintPreviewDialog1 = new PrintPreviewDialog();
                PrintPreviewDialog1.ClientSize = new System.Drawing.Size(300, 400);
                PrintPreviewDialog1.Location = new System.Drawing.Point(29, 29);
                PrintPreviewDialog1.Name = Text;
                PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(250, 375);
                PrintPreviewDialog1.UseAntiAlias = true;
                PrintPreviewDialog1.Document = printDocument1;
                toolStripMenuItem18.Text = printDialog1.PrinterSettings.PrinterName;
                if (PrintPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    //               printDocument1.Print();
                }
            }
        }

        private void punchToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void cmdRéceptionTMensuelle_Click(object sender, EventArgs e) { Form f = new BilanReception(); f.MdiParent = this; f.Icon = Icon; f.Text = cmdRéceptionTMensuelle.Text; f.Show(); }
        private void CmdChangerDB_Click(object sender, EventArgs e) { DataBaseWizzard dbw = new DataBaseWizzard(); dbw.MdiParent = this; dbw.Icon = ControleurServeur.Properties.Resources.Auteur; dbw.Text = Application.ProductName + "." + Name+".DataBaseWizzard";dbw.ShowInTaskbar = false; dbw.Show(); }
        private void sortieDoutilsToolStripMenuItem_Click(object sender, EventArgs e){Form f = new Outils_InOut(); /*f.Text = $"Magasin gestion des outils [{IdNomEmploye}]";*/ f.Show();}
            private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Le chargement peut être très long en fonction des capacitées du serveur\nVoulez vous continuer quand même?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    WizzardRapport F = new WizzardRapport();
                    F.Icon = Icon;
                    F.Show();
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Programme", "cmdFormulaire_Click", ex);
            }
        }
        private void toolStripMenuItem19_Click(object sender, EventArgs e) { Form f = new ViewSoumissionMec(); f.Show(); }
        private void appercuProjetToolStripMenuItem_Click(object sender, EventArgs e) { string noProjet = "44001-01"; Form f = new ViewApercuProjet(noProjet); f.Show(); }//test
        private void backOrderToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewBackOrder("13005", isLandscape); f.Show(); }
        private void bonTravailToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewBonTravail(); f.Show(); }
        private void clientsToolStripMenuItem1_Click(object sender, EventArgs e) { Form f = new ViewClients(); f.Show(); }
        private void conceptionToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewConception(true); f.Show(); }
        private void commandeToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewCommande(); f.Show(); }
        private void commandeRecueToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewCommandeRecue(); f.Show(); }
        private void commandeParcelToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewCommandeParcel(); f.Show(); }
        private void contactEntrepriseToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewContactEntreprise("abb"); f.Show(); }
        private void contactSingleToolStripMenuItem_Click(object sender, EventArgs e) { ViewContactSingle f = new ViewContactSingle("abb", "syl"); f.Show(); }
        private void contactVilleToolStripMenuItem_Click(object sender, EventArgs e) { ViewContactVille f = new ViewContactVille("Granby"); f.ShowDialog(); }/// manquant
        private void demandePrixToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewDemandePrix(); f.Show(); }
        private void facturationToolStripMenuItem1_Click(object sender, EventArgs e) { Form f = new ViewFacturation(true); f.Show(); }
        private void françaisToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewFaxFrancais(DateTime.Today.ToLongDateString(), "E91045-01", string.Empty, "Benoit", "Marcel Gagné", "EXTRUSIONS DE PLASTIQUE MICRO INC.", "(450) 378-5279", "1", "", "Punch avec panneau de contrôle"); f.Show(); }
        private void anglaisToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewFaxAnglais(DateTime.Today.ToLongDateString(), "E91045-01", string.Empty, "Benoit", "Marcel Gagné", "EXTRUSIONS DE PLASTIQUE MICRO INC.", "(450) 378-5279", "1", "", "Punch avec panneau de contrôle"); f.Show(); }
        private void fermeMecaniqueToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewFermeMecanique("E73004-01", "2017-04-27", "4662", "SOLMAX INTERNATIONAL INC.", "NULL", "(450) 929-1234", "(450) 929-2550", "Louis Paré", "E71044-01", "E73004-01", "E73004-01-001", "Gilles Pinsonneaut", "2017-08-24", "2017-08-24"); f.Show(); }
        private void fermetureToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewFabricationFermeture(); f.Show(); }
        private void feuilleDeTempsToolStripMenuItem_Click(object sender, EventArgs e) { ViewFeuilleTemps f = new ViewFeuilleTemps(); f.Show(); }
        private void finFabricationToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewFinFab(); f.Show(); }
        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e) { ViewFournisseur f = new ViewFournisseur(); f.Show(); }
        private void électriqueToolStripMenuItem4_Click(object sender, EventArgs e) { Form f = new ViewInventaire(); f.Show(); }
        private void mécaniqueToolStripMenuItem4_Click(object sender, EventArgs e) { Form f = new ViewInventaire(); f.Show(); }
        private void listeAchatsToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewListeAchats(); f.Show(); }
        private void listeClientToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewListeClient(); f.Show(); }
        private void listeContactToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewListeContact(); f.Show(); }
        private void listeInventaireToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewListeInventaire(); f.Show(); }
        private void listePieceToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewListePiece(); f.Show(); }
        private void listeProjetToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewListeProjet(); f.Show(); }
        private void outilsInOutToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewOutilsInOut(); f.Show(); }
        private void outilsMachinerieToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewOutilsMachinerie(); f.Show(); }
        private void problemesToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewProblemes(); f.Show(); }
        private void programmationToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewProgrammation(); f.Show(); }
        private void toolStripMenuItem16_Click(object sender, EventArgs e) { Form f = new ViewSoumissionElec(); f.Show(); }
        private void receptionToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewReception(); f.Show(); }
        private void testsRapportsToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void retourToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewRetour(); f.Show(); }
        private void sommaireHeuresToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewSommaireHeures(); f.Show(); }
        private void toolStripMenuItem15_Click(object sender, EventArgs e) { Form f = new ViewSommairePunchGRB(); f.Show(); }
        private void tempsElecToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewTempsElec(); f.Show(); }
        private void tempsMecToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ViewTempsMec(); f.Show(); }
        private void électriqueToolStripMenuItem5_Click(object sender, EventArgs e) { }
        private void mécaniqueToolStripMenuItem5_Click_1(object sender, EventArgs e) { }
        private void rapportsToolStripMenuItem_Click(object sender, EventArgs e) { }
        /// <summary>
        /// Patch bug dans loginSQL si annuler connexion via btn cancel
        internal static void ForceExit(System.Windows.Forms.Button button2, EventArgs eventArgs) { Application.Exit(new CancelEventArgs());}
         /// envoie instruction CloseThenFinish a tous les threads
        /// </summary>
       private void électriquesToolStripMenuItem_Click(object sender, EventArgs e) { ProjSoumElec f = new ProjSoumElec(); f.MdiParent = this; f.Text = "Projets & Soumissions électriques"; f.Icon = Icon; f.Show(); }
        private void mécaniquesToolStripMenuItem_Click(object sender, EventArgs e) { Form f = new ProjSoumMec(); f.MdiParent = this; f.Text = "Projets & Soumissions mécaniques"; f.Icon = Icon; f.Show(); }
        private void électriqueToolStripMenuItem6_Click(object sender, EventArgs e) { ReceptionElec f = new ReceptionElec(); f.MdiParent = this; f.Show(); }
        private void mécaniqueToolStripMenuItem6_Click(object sender, EventArgs e) { ReceptionMec f = new ReceptionMec(); f.MdiParent = this; f.Show(); }
        private void électriqueToolStripMenuItem7_Click(object sender, EventArgs e) { ACHAT f = new ACHAT(EnumCatalogue.ELECTRIQUE); f.MdiParent = this; f.Show(); }
        private void mécaniqueToolStripMenuItem7_Click(object sender, EventArgs e) { ACHAT f = new ACHAT(EnumCatalogue.MECANIQUE); f.MdiParent = this; f.Show(); }
        private void assistantToolStripMenuItem_Click(object sender, EventArgs e) { ChoixProjSoum choixProj = new ChoixProjSoum(); choixProj.MdiParent = this; choixProj.Show(); }
        private void RaccourciFeuilleDeTemps_Click(object sender, EventArgs e) { ViewFeuilleTemps f = new ViewFeuilleTemps(); f.Show(); }


        private void ConfigurationDB_Click(object sender, EventArgs e)
        {
            Configuration cconfig = new Configuration();
            cconfig.MdiParent = this;
            cconfig.Icon = global::ControleurServeur.Properties.Resources.Auteur;
            cconfig.ShowIcon = true;
            cconfig.ShowInTaskbar = false;
            cconfig.Show();
        }

        private void ModifierDB_Click(object sender, EventArgs e)
        {

        }
    }
}