using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ADODB;

using System.Web.UI.WebControls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using TextBox = System.Windows.Forms.TextBox;
using ListView = System.Windows.Forms.ListView;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;
using RadioButton = System.Windows.Forms.RadioButton;
using Stripe.Climate;

namespace ControleurServeur
{
    public  class ACHAT : Form
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
        internal static ToolTip ToolTip1;
        internal static Button cmdOKDateRequise;
        internal static Button cmdAnnulerDateRequise;
        internal static MonthCalendar mvwDateRequise;
        internal static GroupBox fraDateRequise;
        internal static Button cmdOKPieceTrouve;
        internal static Button cmdAnnulerPieceTrouve;
        internal static ColumnHeader _lvwPieceTrouve_ColumnHeader_1;
        internal static ColumnHeader _lvwPieceTrouve_ColumnHeader_2;
        internal static ColumnHeader _lvwPieceTrouve_ColumnHeader_3;
        internal static ColumnHeader _lvwPieceTrouve_ColumnHeader_4;
        internal static ColumnHeader _lvwPieceTrouve_ColumnHeader_5;
        internal static ColumnHeader _lvwPieceTrouve_ColumnHeader_6;
        internal static ListView lvwPieceTrouve;
        internal static GroupBox fraPieceTrouve;
        internal static Button cmdAnnulerPrix;
        internal static Button cmdOKPrix;
        internal static RadioButton optSpain;
        internal static RadioButton optCAN;
        internal static RadioButton optUSA;
        internal static ComboBox cmbfrs;
        internal static TextBox txtPrixNet;
        internal static TextBox txtPrixList;
        internal static TextBox txtPrixSpecial;
        internal static MaskedTextBox mskEscompte;
        internal static PictureBox imgEU;
        internal static PictureBox imgSpain;
        internal static Label _Label1_5;
        internal static Label _Label1_4;
        internal static Label _Label1_3;
        internal static Label _Label1_2;
        internal static PictureBox imgCanada;
        internal static Label _Label1_1;
        internal static GroupBox fraPrixPiece;
        internal static Button cmdReception;
        internal static Button cmdAnnulerInventaire;
        internal static Button cmdOKInventaire;
        internal static ColumnHeader _lvwInventaire_ColumnHeader_1;
        internal static ColumnHeader _lvwInventaire_ColumnHeader_2;
        internal static ColumnHeader _lvwInventaire_ColumnHeader_3;
        internal static ColumnHeader _lvwInventaire_ColumnHeader_4;
        internal static ColumnHeader _lvwInventaire_ColumnHeader_5;
        internal static ColumnHeader _lvwInventaire_ColumnHeader_6;
        internal static ColumnHeader _lvwInventaire_ColumnHeader_7;
        internal static ListView lvwInventaire;
        internal static GroupBox fraInventaire;
        internal static Button cmdInventaire;
        internal static Button cmdReset;
        internal static Button cmdRetour;
        internal static Button cmdDemande;
        internal static Button cmdTri;
        internal static TextBox txtPrixTotal;
        internal static Button cmdRafraichir;
        internal static ComboBox cmbTri;
        internal static Button cmdFermer;
        internal static Button cmdAjouter;
        internal static ComboBox cmbCategorie;
        internal static TextBox txtRaison;
        internal static ComboBox cmbNoAchat;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_1;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_2;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_3;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_4;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_5;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_6;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_7;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_8;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_9;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_10;
        internal static ListView lvwFournisseur;
        internal static GroupBox fraFournisseur;
        internal static Button cmdModifier;
        internal static Button cmdSupprimer;
        internal static Button cmdImprimer;
        internal static TextBox txtAcheteur;
        internal static Button cmdBonCommande;
        internal static ColumnHeader _lvwAchat_ColumnHeader_1;
        internal static ColumnHeader _lvwAchat_ColumnHeader_2;
        internal static ColumnHeader _lvwAchat_ColumnHeader_3;
        internal static ColumnHeader _lvwAchat_ColumnHeader_4;
        internal static ColumnHeader _lvwAchat_ColumnHeader_5;
        internal static ColumnHeader _lvwAchat_ColumnHeader_6;
        internal static ColumnHeader _lvwAchat_ColumnHeader_7;
        internal static ColumnHeader _lvwAchat_ColumnHeader_8;
        internal static ColumnHeader _lvwAchat_ColumnHeader_9;
        internal static ColumnHeader _lvwAchat_ColumnHeader_10;
        internal static ColumnHeader _lvwAchat_ColumnHeader_11;
        internal static ListView lvwAchat;
        internal static ColumnHeader _lvwPieces_ColumnHeader_1;
        internal static ColumnHeader _lvwPieces_ColumnHeader_2;
        internal static ColumnHeader _lvwPieces_ColumnHeader_3;
        internal static ColumnHeader _lvwPieces_ColumnHeader_4;
        internal static ColumnHeader _lvwPieces_ColumnHeader_5;
        internal static ColumnHeader _lvwPieces_ColumnHeader_6;
        internal static ListView lvwPieces;
        internal static TextBox txtNoAchat;
        internal static TextBox txtDate;
        internal static Button cmdEnregistrer;
        internal static Button cmdAnnuler;
        internal static Button cmdMaterielInutile;
        internal static Button cmdMauvaisPrix;
        internal static Label Label2;
        internal static Label lblPrixTotal;
        internal static Label _Label1_0;
        internal static Label lblTri;
        internal static Label lblRaison;
        internal static Label lblCategorie;
        internal static Label lblNoSoumission;
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACHAT));
            fraDateRequise = new System.Windows.Forms.GroupBox();
            cmdOKDateRequise = new System.Windows.Forms.Button();
            cmdAnnulerDateRequise = new System.Windows.Forms.Button();
            mvwDateRequise = new System.Windows.Forms.MonthCalendar();
            fraPieceTrouve = new System.Windows.Forms.GroupBox();
            cmdOKPieceTrouve = new System.Windows.Forms.Button();
            cmdAnnulerPieceTrouve = new System.Windows.Forms.Button();
            lvwPieceTrouve = new System.Windows.Forms.ListView();
            _lvwPieceTrouve_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lvwPieceTrouve_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _lvwPieceTrouve_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            _lvwPieceTrouve_ColumnHeader_4 = new System.Windows.Forms.ColumnHeader();
            _lvwPieceTrouve_ColumnHeader_5 = new System.Windows.Forms.ColumnHeader();
            _lvwPieceTrouve_ColumnHeader_6 = new System.Windows.Forms.ColumnHeader();
            fraPrixPiece = new System.Windows.Forms.GroupBox();
            cmdAnnulerPrix = new System.Windows.Forms.Button();
            cmdOKPrix = new System.Windows.Forms.Button();
            optSpain = new System.Windows.Forms.RadioButton();
            optCAN = new System.Windows.Forms.RadioButton();
            optUSA = new System.Windows.Forms.RadioButton();
            cmbfrs = new System.Windows.Forms.ComboBox();
            txtPrixNet = new System.Windows.Forms.TextBox();
            txtPrixList = new System.Windows.Forms.TextBox();
            txtPrixSpecial = new System.Windows.Forms.TextBox();
            mskEscompte = new System.Windows.Forms.MaskedTextBox();
            imgEU = new System.Windows.Forms.PictureBox();
            imgSpain = new System.Windows.Forms.PictureBox();
            _Label1_5 = new System.Windows.Forms.Label();
            _Label1_4 = new System.Windows.Forms.Label();
            _Label1_3 = new System.Windows.Forms.Label();
            _Label1_2 = new System.Windows.Forms.Label();
            imgCanada = new System.Windows.Forms.PictureBox();
            _Label1_1 = new System.Windows.Forms.Label();
            fraFournisseur = new System.Windows.Forms.GroupBox();
            lvwFournisseur = new System.Windows.Forms.ListView();
            _lvwFournisseur_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_4 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_5 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_6 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_7 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_8 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_9 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_10 = new System.Windows.Forms.ColumnHeader();
            cmdReception = new System.Windows.Forms.Button();
            fraInventaire = new System.Windows.Forms.GroupBox();
            cmdAnnulerInventaire = new System.Windows.Forms.Button();
            cmdOKInventaire = new System.Windows.Forms.Button();
            lvwInventaire = new System.Windows.Forms.ListView();
            _lvwInventaire_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lvwInventaire_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _lvwInventaire_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            _lvwInventaire_ColumnHeader_4 = new System.Windows.Forms.ColumnHeader();
            _lvwInventaire_ColumnHeader_5 = new System.Windows.Forms.ColumnHeader();
            _lvwInventaire_ColumnHeader_6 = new System.Windows.Forms.ColumnHeader();
            _lvwInventaire_ColumnHeader_7 = new System.Windows.Forms.ColumnHeader();
            cmdInventaire = new System.Windows.Forms.Button();
            cmdReset = new System.Windows.Forms.Button();
            cmdRetour = new System.Windows.Forms.Button();
            cmdDemande = new System.Windows.Forms.Button();
            cmdTri = new System.Windows.Forms.Button();
            txtPrixTotal = new System.Windows.Forms.TextBox();
            cmdRafraichir = new System.Windows.Forms.Button();
            cmbTri = new System.Windows.Forms.ComboBox();
            cmdFermer = new System.Windows.Forms.Button();
            cmdAjouter = new System.Windows.Forms.Button();
            cmbCategorie = new System.Windows.Forms.ComboBox();
            txtRaison = new System.Windows.Forms.TextBox();
            cmbNoAchat = new System.Windows.Forms.ComboBox();
            cmdModifier = new System.Windows.Forms.Button();
            cmdSupprimer = new System.Windows.Forms.Button();
            cmdImprimer = new System.Windows.Forms.Button();
            txtAcheteur = new System.Windows.Forms.TextBox();
            cmdBonCommande = new System.Windows.Forms.Button();
            lvwAchat = new System.Windows.Forms.ListView();
            _lvwAchat_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_4 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_5 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_6 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_7 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_8 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_9 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_10 = new System.Windows.Forms.ColumnHeader();
            _lvwAchat_ColumnHeader_11 = new System.Windows.Forms.ColumnHeader();
            lvwPieces = new System.Windows.Forms.ListView();
            _lvwPieces_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lvwPieces_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _lvwPieces_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            _lvwPieces_ColumnHeader_4 = new System.Windows.Forms.ColumnHeader();
            _lvwPieces_ColumnHeader_5 = new System.Windows.Forms.ColumnHeader();
            _lvwPieces_ColumnHeader_6 = new System.Windows.Forms.ColumnHeader();
            txtNoAchat = new System.Windows.Forms.TextBox();
            txtDate = new System.Windows.Forms.TextBox();
            cmdEnregistrer = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdMaterielInutile = new System.Windows.Forms.Button();
            cmdMauvaisPrix = new System.Windows.Forms.Button();
            Label2 = new System.Windows.Forms.Label();
            lblPrixTotal = new System.Windows.Forms.Label();
            _Label1_0 = new System.Windows.Forms.Label();
            lblTri = new System.Windows.Forms.Label();
            lblRaison = new System.Windows.Forms.Label();
            lblCategorie = new System.Windows.Forms.Label();
            lblNoSoumission = new System.Windows.Forms.Label();
            fraDateRequise.SuspendLayout();
            fraPieceTrouve.SuspendLayout();
            fraPrixPiece.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(imgEU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgSpain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(imgCanada)).BeginInit();
            fraFournisseur.SuspendLayout();
            fraInventaire.SuspendLayout();
            SuspendLayout();
            // 
            // fraDateRequise
            // 
            fraDateRequise.BackColor = System.Drawing.Color.Black;
            fraDateRequise.Controls.Add(cmdOKDateRequise);
            fraDateRequise.Controls.Add(cmdAnnulerDateRequise);
            fraDateRequise.Controls.Add(mvwDateRequise);
            fraDateRequise.ForeColor = System.Drawing.Color.White;
            fraDateRequise.Location = new System.Drawing.Point(1070, 63);
            fraDateRequise.Name = "fraDateRequise";
            fraDateRequise.Padding = new System.Windows.Forms.Padding(0);
            fraDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraDateRequise.Size = new System.Drawing.Size(374, 223);
            fraDateRequise.TabIndex = 60;
            fraDateRequise.TabStop = false;
            fraDateRequise.Text = "Date Requise";
            fraDateRequise.Visible = false;
            // 
            // cmdOKDateRequise
            // 
            cmdOKDateRequise.BackColor = System.Drawing.Color.Black;
            cmdOKDateRequise.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOKDateRequise.ForeColor = System.Drawing.Color.White;
            cmdOKDateRequise.Location = new System.Drawing.Point(271, 55);
            cmdOKDateRequise.Name = "cmdOKDateRequise";
            cmdOKDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOKDateRequise.Size = new System.Drawing.Size(85, 29);
            cmdOKDateRequise.TabIndex = 62;
            cmdOKDateRequise.Text = "OK";
            cmdOKDateRequise.UseVisualStyleBackColor = true;
            cmdOKDateRequise.Click += new System.EventHandler(cmdOKDateRequise_Click);
            cmdOKDateRequise.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdOKDateRequise_MouseUp);
            // 
            // cmdAnnulerDateRequise
            // 
            cmdAnnulerDateRequise.BackColor = System.Drawing.Color.Black;
            cmdAnnulerDateRequise.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnulerDateRequise.ForeColor = System.Drawing.Color.White;
            cmdAnnulerDateRequise.Location = new System.Drawing.Point(271, 92);
            cmdAnnulerDateRequise.Name = "cmdAnnulerDateRequise";
            cmdAnnulerDateRequise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnulerDateRequise.Size = new System.Drawing.Size(85, 29);
            cmdAnnulerDateRequise.TabIndex = 61;
            cmdAnnulerDateRequise.Text = "Annuler";
            cmdAnnulerDateRequise.UseVisualStyleBackColor = true;
            cmdAnnulerDateRequise.Click += new System.EventHandler(cmdAnnulerDateRequise_Click);
            cmdAnnulerDateRequise.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdAnnulerDateRequise_MouseUp);
            // 
            // mvwDateRequise
            // 
            mvwDateRequise.Location = new System.Drawing.Point(47, 28);
            mvwDateRequise.Margin = new System.Windows.Forms.Padding(10);
            mvwDateRequise.Name = "mvwDateRequise";
            mvwDateRequise.TabIndex = 63;
            mvwDateRequise.Enter += new System.EventHandler(mvwDateRequise_Enter);
            // 
            // fraPieceTrouve
            // 
            fraPieceTrouve.BackColor = System.Drawing.Color.Black;
            fraPieceTrouve.Controls.Add(cmdOKPieceTrouve);
            fraPieceTrouve.Controls.Add(cmdAnnulerPieceTrouve);
            fraPieceTrouve.Controls.Add(lvwPieceTrouve);
            fraPieceTrouve.ForeColor = System.Drawing.Color.White;
            fraPieceTrouve.Location = new System.Drawing.Point(89, 402);
            fraPieceTrouve.Name = "fraPieceTrouve";
            fraPieceTrouve.Padding = new System.Windows.Forms.Padding(0);
            fraPieceTrouve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraPieceTrouve.Size = new System.Drawing.Size(804, 212);
            fraPieceTrouve.TabIndex = 13;
            fraPieceTrouve.TabStop = false;
            fraPieceTrouve.Text = "Pièces trouvées";
            fraPieceTrouve.Visible = false;
            // 
            // cmdOKPieceTrouve
            // 
            cmdOKPieceTrouve.BackColor = System.Drawing.Color.Black;
            cmdOKPieceTrouve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOKPieceTrouve.ForeColor = System.Drawing.Color.White;
            cmdOKPieceTrouve.Location = new System.Drawing.Point(619, 174);
            cmdOKPieceTrouve.Name = "cmdOKPieceTrouve";
            cmdOKPieceTrouve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOKPieceTrouve.Size = new System.Drawing.Size(85, 29);
            cmdOKPieceTrouve.TabIndex = 16;
            cmdOKPieceTrouve.Text = "OK";
            cmdOKPieceTrouve.UseVisualStyleBackColor = true;
            cmdOKPieceTrouve.Click += new System.EventHandler(cmdOKPieceTrouve_Click);
            // 
            // cmdAnnulerPieceTrouve
            // 
            cmdAnnulerPieceTrouve.BackColor = System.Drawing.Color.Black;
            cmdAnnulerPieceTrouve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnulerPieceTrouve.ForeColor = System.Drawing.Color.White;
            cmdAnnulerPieceTrouve.Location = new System.Drawing.Point(709, 174);
            cmdAnnulerPieceTrouve.Name = "cmdAnnulerPieceTrouve";
            cmdAnnulerPieceTrouve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnulerPieceTrouve.Size = new System.Drawing.Size(85, 29);
            cmdAnnulerPieceTrouve.TabIndex = 15;
            cmdAnnulerPieceTrouve.Text = "Annuler";
            cmdAnnulerPieceTrouve.UseVisualStyleBackColor = true;
            cmdAnnulerPieceTrouve.Click += new System.EventHandler(cmdAnnulerPieceTrouve_Click);
            // 
            // lvwPieceTrouve
            // 
            lvwPieceTrouve.BackColor = System.Drawing.SystemColors.Window;
            lvwPieceTrouve.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwPieceTrouve_ColumnHeader_1,
            _lvwPieceTrouve_ColumnHeader_2,
            _lvwPieceTrouve_ColumnHeader_3,
            _lvwPieceTrouve_ColumnHeader_4,
            _lvwPieceTrouve_ColumnHeader_5,
            _lvwPieceTrouve_ColumnHeader_6});
            lvwPieceTrouve.ForeColor = System.Drawing.SystemColors.WindowText;
            lvwPieceTrouve.FullRowSelect = true;
            lvwPieceTrouve.GridLines = true;
            lvwPieceTrouve.Location = new System.Drawing.Point(9, 18);
            lvwPieceTrouve.Name = "lvwPieceTrouve";
            lvwPieceTrouve.Size = new System.Drawing.Size(784, 148);
            lvwPieceTrouve.TabIndex = 14;
            lvwPieceTrouve.UseCompatibleStateImageBehavior = false;
            lvwPieceTrouve.View = System.Windows.Forms.View.Details;
            lvwPieceTrouve.DoubleClick += new System.EventHandler(lvwPieceTrouve_DoubleClick);
            // 
            // _lvwPieceTrouve_ColumnHeader_1
            // 
            _lvwPieceTrouve_ColumnHeader_1.Text = "PIECE_GRB";
            _lvwPieceTrouve_ColumnHeader_1.Width = 161;
            // 
            // _lvwPieceTrouve_ColumnHeader_2
            // 
            _lvwPieceTrouve_ColumnHeader_2.Text = "No. d\'item";
            _lvwPieceTrouve_ColumnHeader_2.Width = 217;
            // 
            // _lvwPieceTrouve_ColumnHeader_3
            // 
            _lvwPieceTrouve_ColumnHeader_3.Text = "CatégorieFournisseur";
            _lvwPieceTrouve_ColumnHeader_3.Width = 170;
            // 
            // _lvwPieceTrouve_ColumnHeader_4
            // 
            _lvwPieceTrouve_ColumnHeader_4.Text = "Manufacturier";
            _lvwPieceTrouve_ColumnHeader_4.Width = 136;
            // 
            // _lvwPieceTrouve_ColumnHeader_5
            // 
            _lvwPieceTrouve_ColumnHeader_5.Text = "Description française";
            _lvwPieceTrouve_ColumnHeader_5.Width = 477;
            // 
            // _lvwPieceTrouve_ColumnHeader_6
            // 
            _lvwPieceTrouve_ColumnHeader_6.Text = "Description anglaise";
            _lvwPieceTrouve_ColumnHeader_6.Width = 477;
            // 
            // fraPrixPiece
            // 
            fraPrixPiece.BackColor = System.Drawing.Color.Black;
            fraPrixPiece.Controls.Add(cmdAnnulerPrix);
            fraPrixPiece.Controls.Add(cmdOKPrix);
            fraPrixPiece.Controls.Add(optSpain);
            fraPrixPiece.Controls.Add(optCAN);
            fraPrixPiece.Controls.Add(optUSA);
            fraPrixPiece.Controls.Add(cmbfrs);
            fraPrixPiece.Controls.Add(txtPrixNet);
            fraPrixPiece.Controls.Add(txtPrixList);
            fraPrixPiece.Controls.Add(txtPrixSpecial);
            fraPrixPiece.Controls.Add(mskEscompte);
            fraPrixPiece.Controls.Add(imgEU);
            fraPrixPiece.Controls.Add(imgSpain);
            fraPrixPiece.Controls.Add(_Label1_5);
            fraPrixPiece.Controls.Add(_Label1_4);
            fraPrixPiece.Controls.Add(_Label1_3);
            fraPrixPiece.Controls.Add(_Label1_2);
            fraPrixPiece.Controls.Add(imgCanada);
            fraPrixPiece.Controls.Add(_Label1_1);
            fraPrixPiece.ForeColor = System.Drawing.Color.White;
            fraPrixPiece.Location = new System.Drawing.Point(184, 219);
            fraPrixPiece.Name = "fraPrixPiece";
            fraPrixPiece.Padding = new System.Windows.Forms.Padding(0);
            fraPrixPiece.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraPrixPiece.Size = new System.Drawing.Size(692, 177);
            fraPrixPiece.TabIndex = 44;
            fraPrixPiece.TabStop = false;
            fraPrixPiece.Text = "Prix pieces";
            fraPrixPiece.Visible = false;
            // 
            // cmdAnnulerPrix
            // 
            cmdAnnulerPrix.BackColor = System.Drawing.Color.Black;
            cmdAnnulerPrix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnulerPrix.ForeColor = System.Drawing.Color.White;
            cmdAnnulerPrix.Location = new System.Drawing.Point(597, 135);
            cmdAnnulerPrix.Name = "cmdAnnulerPrix";
            cmdAnnulerPrix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnulerPrix.Size = new System.Drawing.Size(85, 29);
            cmdAnnulerPrix.TabIndex = 53;
            cmdAnnulerPrix.Text = "Annuler";
            cmdAnnulerPrix.UseVisualStyleBackColor = true;
            cmdAnnulerPrix.Click += new System.EventHandler(cmdAnnulerPrix_Click);
            // 
            // cmdOKPrix
            // 
            cmdOKPrix.BackColor = System.Drawing.Color.Black;
            cmdOKPrix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOKPrix.ForeColor = System.Drawing.Color.White;
            cmdOKPrix.Location = new System.Drawing.Point(509, 135);
            cmdOKPrix.Name = "cmdOKPrix";
            cmdOKPrix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOKPrix.Size = new System.Drawing.Size(85, 29);
            cmdOKPrix.TabIndex = 52;
            cmdOKPrix.Text = "OK";
            cmdOKPrix.UseVisualStyleBackColor = true;
            cmdOKPrix.Click += new System.EventHandler(cmdOKPrix_Click);
            // 
            // optSpain
            // 
            optSpain.BackColor = System.Drawing.Color.Black;
            optSpain.ForeColor = System.Drawing.Color.White;
            optSpain.Location = new System.Drawing.Point(625, 18);
            optSpain.Name = "optSpain";
            optSpain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optSpain.Size = new System.Drawing.Size(57, 20);
            optSpain.TabIndex = 51;
            optSpain.TabStop = true;
            optSpain.Text = "SPA";
            optSpain.UseVisualStyleBackColor = true;
            optSpain.CheckedChanged += new System.EventHandler(optSpain_CheckedChanged);
            // 
            // optCAN
            // 
            optCAN.BackColor = System.Drawing.Color.Black;
            optCAN.Checked = true;
            optCAN.ForeColor = System.Drawing.Color.White;
            optCAN.Location = new System.Drawing.Point(513, 18);
            optCAN.Name = "optCAN";
            optCAN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optCAN.Size = new System.Drawing.Size(57, 20);
            optCAN.TabIndex = 50;
            optCAN.TabStop = true;
            optCAN.Text = "CAN";
            optCAN.UseVisualStyleBackColor = true;
            optCAN.CheckedChanged += new System.EventHandler(optCAN_CheckedChanged);
            // 
            // optUSA
            // 
            optUSA.BackColor = System.Drawing.Color.Black;
            optUSA.ForeColor = System.Drawing.Color.White;
            optUSA.Location = new System.Drawing.Point(569, 18);
            optUSA.Name = "optUSA";
            optUSA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optUSA.Size = new System.Drawing.Size(57, 20);
            optUSA.TabIndex = 49;
            optUSA.TabStop = true;
            optUSA.Text = "USA";
            optUSA.UseVisualStyleBackColor = true;
            optUSA.CheckedChanged += new System.EventHandler(optUSA_CheckedChanged);
            // 
            // cmbfrs
            // 
            cmbfrs.BackColor = System.Drawing.SystemColors.Window;
            cmbfrs.ForeColor = System.Drawing.SystemColors.WindowText;
            cmbfrs.Location = new System.Drawing.Point(19, 37);
            cmbfrs.Name = "cmbfrs";
            cmbfrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbfrs.Size = new System.Drawing.Size(215, 23);
            cmbfrs.TabIndex = 48;
            // 
            // txtPrixNet
            // 
            txtPrixNet.AcceptsReturn = true;
            txtPrixNet.BackColor = System.Drawing.Color.Black;
            txtPrixNet.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixNet.ForeColor = System.Drawing.Color.White;
            txtPrixNet.Location = new System.Drawing.Point(383, 92);
            txtPrixNet.MaxLength = 0;
            txtPrixNet.Name = "txtPrixNet";
            txtPrixNet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixNet.Size = new System.Drawing.Size(66, 23);
            txtPrixNet.TabIndex = 47;
            txtPrixNet.TextChanged += new System.EventHandler(txtPrixNet_TextChanged);
            txtPrixNet.Enter += new System.EventHandler(txtPrixNet_Enter);
            txtPrixNet.Leave += new System.EventHandler(txtPrixNet_Leave);
            // 
            // txtPrixList
            // 
            txtPrixList.AcceptsReturn = true;
            txtPrixList.BackColor = System.Drawing.Color.Black;
            txtPrixList.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixList.ForeColor = System.Drawing.Color.White;
            txtPrixList.Location = new System.Drawing.Point(383, 37);
            txtPrixList.MaxLength = 0;
            txtPrixList.Name = "txtPrixList";
            txtPrixList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixList.Size = new System.Drawing.Size(84, 23);
            txtPrixList.TabIndex = 46;
            txtPrixList.Leave += new System.EventHandler(txtPrixList_Leave);
            // 
            // txtPrixSpecial
            // 
            txtPrixSpecial.AcceptsReturn = true;
            txtPrixSpecial.BackColor = System.Drawing.Color.Black;
            txtPrixSpecial.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixSpecial.ForeColor = System.Drawing.Color.White;
            txtPrixSpecial.Location = new System.Drawing.Point(383, 120);
            txtPrixSpecial.MaxLength = 0;
            txtPrixSpecial.Name = "txtPrixSpecial";
            txtPrixSpecial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixSpecial.Size = new System.Drawing.Size(66, 23);
            txtPrixSpecial.TabIndex = 45;
            txtPrixSpecial.TextChanged += new System.EventHandler(txtPrixSpecial_TextChanged);
            txtPrixSpecial.Leave += new System.EventHandler(txtPrixSpecial_Leave);
            // 
            // mskEscompte
            // 
            mskEscompte.BackColor = System.Drawing.Color.Black;
            mskEscompte.ForeColor = System.Drawing.Color.White;
            mskEscompte.Location = new System.Drawing.Point(383, 65);
            mskEscompte.Name = "mskEscompte";
            mskEscompte.Size = new System.Drawing.Size(66, 23);
            mskEscompte.TabIndex = 54;
            // 
            // imgEU
            // 
            imgEU.Location = new System.Drawing.Point(532, 46);
            imgEU.Name = "imgEU";
            imgEU.Size = new System.Drawing.Size(131, 82);
            imgEU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgEU.TabIndex = 55;
            imgEU.TabStop = false;
            imgEU.Visible = false;
            // 
            // imgSpain
            // 
            imgSpain.Location = new System.Drawing.Point(532, 46);
            imgSpain.Name = "imgSpain";
            imgSpain.Size = new System.Drawing.Size(131, 82);
            imgSpain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgSpain.TabIndex = 56;
            imgSpain.TabStop = false;
            imgSpain.Visible = false;
            // 
            // _Label1_5
            // 
            _Label1_5.BackColor = System.Drawing.Color.Black;
            _Label1_5.ForeColor = System.Drawing.Color.White;
            _Label1_5.Location = new System.Drawing.Point(289, 92);
            _Label1_5.Name = "_Label1_5";
            _Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_5.Size = new System.Drawing.Size(85, 20);
            _Label1_5.TabIndex = 59;
            _Label1_5.Text = "Prix Net :";
            // 
            // _Label1_4
            // 
            _Label1_4.BackColor = System.Drawing.Color.Black;
            _Label1_4.ForeColor = System.Drawing.Color.White;
            _Label1_4.Location = new System.Drawing.Point(289, 65);
            _Label1_4.Name = "_Label1_4";
            _Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_4.Size = new System.Drawing.Size(85, 20);
            _Label1_4.TabIndex = 58;
            _Label1_4.Text = "Escompte :";
            // 
            // _Label1_3
            // 
            _Label1_3.BackColor = System.Drawing.Color.Black;
            _Label1_3.ForeColor = System.Drawing.Color.White;
            _Label1_3.Location = new System.Drawing.Point(289, 37);
            _Label1_3.Name = "_Label1_3";
            _Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_3.Size = new System.Drawing.Size(76, 20);
            _Label1_3.TabIndex = 57;
            _Label1_3.Text = "Prix Listé :";
            // 
            // _Label1_2
            // 
            _Label1_2.BackColor = System.Drawing.Color.Black;
            _Label1_2.ForeColor = System.Drawing.Color.White;
            _Label1_2.Location = new System.Drawing.Point(19, 18);
            _Label1_2.Name = "_Label1_2";
            _Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_2.Size = new System.Drawing.Size(94, 20);
            _Label1_2.TabIndex = 56;
            _Label1_2.Text = "Distributeur :";
            // 
            // imgCanada
            // 
            imgCanada.Location = new System.Drawing.Point(532, 46);
            imgCanada.Name = "imgCanada";
            imgCanada.Size = new System.Drawing.Size(131, 82);
            imgCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgCanada.TabIndex = 60;
            imgCanada.TabStop = false;
            imgCanada.Visible = false;
            // 
            // _Label1_1
            // 
            _Label1_1.BackColor = System.Drawing.Color.Black;
            _Label1_1.ForeColor = System.Drawing.Color.White;
            _Label1_1.Location = new System.Drawing.Point(289, 120);
            _Label1_1.Name = "_Label1_1";
            _Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_1.Size = new System.Drawing.Size(94, 20);
            _Label1_1.TabIndex = 55;
            _Label1_1.Text = "Prix Spécial :";
            // 
            // fraFournisseur
            // 
            fraFournisseur.BackColor = System.Drawing.Color.Black;
            fraFournisseur.Controls.Add(lvwFournisseur);
            fraFournisseur.ForeColor = System.Drawing.Color.White;
            fraFournisseur.Location = new System.Drawing.Point(976, 447);
            fraFournisseur.Name = "fraFournisseur";
            fraFournisseur.Padding = new System.Windows.Forms.Padding(0);
            fraFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraFournisseur.Size = new System.Drawing.Size(850, 140);
            fraFournisseur.TabIndex = 27;
            fraFournisseur.TabStop = false;
            fraFournisseur.Text = "Fournisseurs";
            fraFournisseur.Visible = false;
            // 
            // lvwFournisseur
            // 
            lvwFournisseur.BackColor = System.Drawing.Color.Black;
            lvwFournisseur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwFournisseur_ColumnHeader_1,
            _lvwFournisseur_ColumnHeader_2,
            _lvwFournisseur_ColumnHeader_3,
            _lvwFournisseur_ColumnHeader_4,
            _lvwFournisseur_ColumnHeader_5,
            _lvwFournisseur_ColumnHeader_6,
            _lvwFournisseur_ColumnHeader_7,
            _lvwFournisseur_ColumnHeader_8,
            _lvwFournisseur_ColumnHeader_9,
            _lvwFournisseur_ColumnHeader_10});
            lvwFournisseur.ForeColor = System.Drawing.Color.White;
            lvwFournisseur.FullRowSelect = true;
            lvwFournisseur.GridLines = true;
            lvwFournisseur.Location = new System.Drawing.Point(9, 18);
            lvwFournisseur.Name = "lvwFournisseur";
            lvwFournisseur.Size = new System.Drawing.Size(831, 111);
            lvwFournisseur.TabIndex = 28;
            lvwFournisseur.UseCompatibleStateImageBehavior = false;
            lvwFournisseur.View = System.Windows.Forms.View.Details;
            lvwFournisseur.DoubleClick += new System.EventHandler(lvwFournisseur_DoubleClick);
            lvwFournisseur.Leave += new System.EventHandler(lvwFournisseur_Leave);
            // 
            // _lvwFournisseur_ColumnHeader_1
            // 
            _lvwFournisseur_ColumnHeader_1.Text = "Fournisseur";
            _lvwFournisseur_ColumnHeader_1.Width = 236;
            // 
            // _lvwFournisseur_ColumnHeader_2
            // 
            _lvwFournisseur_ColumnHeader_2.Text = "Pers. Ress.";
            _lvwFournisseur_ColumnHeader_2.Width = 133;
            // 
            // _lvwFournisseur_ColumnHeader_3
            // 
            _lvwFournisseur_ColumnHeader_3.Text = "Date";
            _lvwFournisseur_ColumnHeader_3.Width = 117;
            // 
            // _lvwFournisseur_ColumnHeader_4
            // 
            _lvwFournisseur_ColumnHeader_4.Text = "Par";
            _lvwFournisseur_ColumnHeader_4.Width = 54;
            // 
            // _lvwFournisseur_ColumnHeader_5
            // 
            _lvwFournisseur_ColumnHeader_5.Text = "Valide";
            _lvwFournisseur_ColumnHeader_5.Width = 117;
            // 
            // _lvwFournisseur_ColumnHeader_6
            // 
            _lvwFournisseur_ColumnHeader_6.Text = "Prix listé";
            _lvwFournisseur_ColumnHeader_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwFournisseur_ColumnHeader_6.Width = 108;
            // 
            // _lvwFournisseur_ColumnHeader_7
            // 
            _lvwFournisseur_ColumnHeader_7.Text = "Escompte";
            _lvwFournisseur_ColumnHeader_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwFournisseur_ColumnHeader_7.Width = 105;
            // 
            // _lvwFournisseur_ColumnHeader_8
            // 
            _lvwFournisseur_ColumnHeader_8.Text = "Prix net";
            _lvwFournisseur_ColumnHeader_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwFournisseur_ColumnHeader_8.Width = 108;
            // 
            // _lvwFournisseur_ColumnHeader_9
            // 
            _lvwFournisseur_ColumnHeader_9.Text = "Prix spécial";
            _lvwFournisseur_ColumnHeader_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwFournisseur_ColumnHeader_9.Width = 115;
            // 
            // _lvwFournisseur_ColumnHeader_10
            // 
            _lvwFournisseur_ColumnHeader_10.Text = "Quoter";
            _lvwFournisseur_ColumnHeader_10.Width = 80;
            // 
            // cmdReception
            // 
            cmdReception.BackColor = System.Drawing.Color.Black;
            cmdReception.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdReception.ForeColor = System.Drawing.Color.White;
            cmdReception.Location = new System.Drawing.Point(241, 685);
            cmdReception.Name = "cmdReception";
            cmdReception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdReception.Size = new System.Drawing.Size(76, 29);
            cmdReception.TabIndex = 43;
            cmdReception.Text = "Réception";
            cmdReception.UseVisualStyleBackColor = true;
            cmdReception.Click += new System.EventHandler(cmdReception_Click);
            // 
            // fraInventaire
            // 
            fraInventaire.BackColor = System.Drawing.Color.Black;
            fraInventaire.Controls.Add(cmdAnnulerInventaire);
            fraInventaire.Controls.Add(cmdOKInventaire);
            fraInventaire.Controls.Add(lvwInventaire);
            fraInventaire.ForeColor = System.Drawing.Color.White;
            fraInventaire.Location = new System.Drawing.Point(275, 164);
            fraInventaire.Name = "fraInventaire";
            fraInventaire.Padding = new System.Windows.Forms.Padding(0);
            fraInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraInventaire.Size = new System.Drawing.Size(1028, 241);
            fraInventaire.TabIndex = 18;
            fraInventaire.TabStop = false;
            fraInventaire.Text = "Inventaire à commander";
            fraInventaire.Visible = false;
            // 
            // cmdAnnulerInventaire
            // 
            cmdAnnulerInventaire.BackColor = System.Drawing.Color.Black;
            cmdAnnulerInventaire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnulerInventaire.ForeColor = System.Drawing.Color.White;
            cmdAnnulerInventaire.Location = new System.Drawing.Point(821, 203);
            cmdAnnulerInventaire.Name = "cmdAnnulerInventaire";
            cmdAnnulerInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnulerInventaire.Size = new System.Drawing.Size(94, 29);
            cmdAnnulerInventaire.TabIndex = 20;
            cmdAnnulerInventaire.Text = "Annuler";
            cmdAnnulerInventaire.UseVisualStyleBackColor = true;
            cmdAnnulerInventaire.Click += new System.EventHandler(cmdAnnulerInventaire_Click);
            // 
            // cmdOKInventaire
            // 
            cmdOKInventaire.BackColor = System.Drawing.Color.Black;
            cmdOKInventaire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOKInventaire.ForeColor = System.Drawing.Color.White;
            cmdOKInventaire.Location = new System.Drawing.Point(924, 203);
            cmdOKInventaire.Name = "cmdOKInventaire";
            cmdOKInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOKInventaire.Size = new System.Drawing.Size(94, 29);
            cmdOKInventaire.TabIndex = 21;
            cmdOKInventaire.Text = "OK";
            cmdOKInventaire.UseVisualStyleBackColor = true;
            cmdOKInventaire.Click += new System.EventHandler(cmdOKInventaire_Click);
            // 
            // lvwInventaire
            // 
            lvwInventaire.BackColor = System.Drawing.Color.Black;
            lvwInventaire.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwInventaire_ColumnHeader_1,
            _lvwInventaire_ColumnHeader_2,
            _lvwInventaire_ColumnHeader_3,
            _lvwInventaire_ColumnHeader_4,
            _lvwInventaire_ColumnHeader_5,
            _lvwInventaire_ColumnHeader_6,
            _lvwInventaire_ColumnHeader_7});
            lvwInventaire.ForeColor = System.Drawing.Color.White;
            lvwInventaire.FullRowSelect = true;
            lvwInventaire.GridLines = true;
            lvwInventaire.Location = new System.Drawing.Point(9, 18);
            lvwInventaire.Name = "lvwInventaire";
            lvwInventaire.Size = new System.Drawing.Size(1008, 176);
            lvwInventaire.TabIndex = 19;
            lvwInventaire.UseCompatibleStateImageBehavior = false;
            lvwInventaire.View = System.Windows.Forms.View.Details;
            lvwInventaire.DoubleClick += new System.EventHandler(lvwInventaire_DoubleClick);
            // 
            // _lvwInventaire_ColumnHeader_1
            // 
            _lvwInventaire_ColumnHeader_1.Text = "No. d\'item";
            _lvwInventaire_ColumnHeader_1.Width = 217;
            // 
            // _lvwInventaire_ColumnHeader_2
            // 
            _lvwInventaire_ColumnHeader_2.Text = "Manufacturier";
            _lvwInventaire_ColumnHeader_2.Width = 136;
            // 
            // _lvwInventaire_ColumnHeader_3
            // 
            _lvwInventaire_ColumnHeader_3.Text = "Description";
            _lvwInventaire_ColumnHeader_3.Width = 477;
            // 
            // _lvwInventaire_ColumnHeader_4
            // 
            _lvwInventaire_ColumnHeader_4.Text = "Commentaire";
            _lvwInventaire_ColumnHeader_4.Width = 170;
            // 
            // _lvwInventaire_ColumnHeader_5
            // 
            _lvwInventaire_ColumnHeader_5.Text = "Qté en stock";
            _lvwInventaire_ColumnHeader_5.Width = 170;
            // 
            // _lvwInventaire_ColumnHeader_6
            // 
            _lvwInventaire_ColumnHeader_6.Text = "Qté minimum";
            _lvwInventaire_ColumnHeader_6.Width = 170;
            // 
            // _lvwInventaire_ColumnHeader_7
            // 
            _lvwInventaire_ColumnHeader_7.Text = "Qté à commander";
            _lvwInventaire_ColumnHeader_7.Width = 170;
            // 
            // cmdInventaire
            // 
            cmdInventaire.BackColor = System.Drawing.Color.Black;
            cmdInventaire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdInventaire.ForeColor = System.Drawing.Color.White;
            cmdInventaire.Location = new System.Drawing.Point(877, 129);
            cmdInventaire.Name = "cmdInventaire";
            cmdInventaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdInventaire.Size = new System.Drawing.Size(160, 29);
            cmdInventaire.TabIndex = 24;
            cmdInventaire.Text = "Inventaire à commander";
            cmdInventaire.UseVisualStyleBackColor = true;
            cmdInventaire.Click += new System.EventHandler(cmdInventaire_Click);
            // 
            // cmdReset
            // 
            cmdReset.BackColor = System.Drawing.Color.Black;
            cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdReset.ForeColor = System.Drawing.Color.White;
            cmdReset.Location = new System.Drawing.Point(148, 685);
            cmdReset.Name = "cmdReset";
            cmdReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdReset.Size = new System.Drawing.Size(76, 29);
            cmdReset.TabIndex = 31;
            cmdReset.Text = "Reset";
            cmdReset.UseVisualStyleBackColor = true;
            cmdReset.Click += new System.EventHandler(cmdReset_Click);
            // 
            // cmdRetour
            // 
            cmdRetour.BackColor = System.Drawing.Color.Black;
            cmdRetour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRetour.ForeColor = System.Drawing.Color.White;
            cmdRetour.Location = new System.Drawing.Point(325, 685);
            cmdRetour.Name = "cmdRetour";
            cmdRetour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRetour.Size = new System.Drawing.Size(76, 29);
            cmdRetour.TabIndex = 32;
            cmdRetour.Text = "Retour";
            cmdRetour.UseVisualStyleBackColor = true;
            cmdRetour.Click += new System.EventHandler(cmdRetour_Click);
            // 
            // cmdDemande
            // 
            cmdDemande.BackColor = System.Drawing.Color.Black;
            cmdDemande.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdDemande.ForeColor = System.Drawing.Color.White;
            cmdDemande.Location = new System.Drawing.Point(409, 685);
            cmdDemande.Name = "cmdDemande";
            cmdDemande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDemande.Size = new System.Drawing.Size(122, 29);
            cmdDemande.TabIndex = 33;
            cmdDemande.Text = "Demande de prix";
            cmdDemande.UseVisualStyleBackColor = true;
            cmdDemande.Click += new System.EventHandler(cmdDemande_Click);
            // 
            // cmdTri
            // 
            cmdTri.BackColor = System.Drawing.Color.Black;
            cmdTri.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdTri.ForeColor = System.Drawing.Color.White;
            cmdTri.Location = new System.Drawing.Point(902, 30);
            cmdTri.Name = "cmdTri";
            cmdTri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdTri.Size = new System.Drawing.Size(76, 24);
            cmdTri.TabIndex = 25;
            cmdTri.Text = "Trier";
            cmdTri.UseVisualStyleBackColor = true;
            cmdTri.Click += new System.EventHandler(cmdTri_Click);
            // 
            // txtPrixTotal
            // 
            txtPrixTotal.AcceptsReturn = true;
            txtPrixTotal.BackColor = System.Drawing.Color.Black;
            txtPrixTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrixTotal.ForeColor = System.Drawing.Color.White;
            txtPrixTotal.Location = new System.Drawing.Point(634, 63);
            txtPrixTotal.MaxLength = 0;
            txtPrixTotal.Name = "txtPrixTotal";
            txtPrixTotal.ReadOnly = true;
            txtPrixTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPrixTotal.Size = new System.Drawing.Size(103, 23);
            txtPrixTotal.TabIndex = 6;
            txtPrixTotal.Text = "0";
            txtPrixTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdRafraichir
            // 
            cmdRafraichir.BackColor = System.Drawing.Color.Black;
            cmdRafraichir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRafraichir.ForeColor = System.Drawing.Color.White;
            cmdRafraichir.Location = new System.Drawing.Point(902, 7);
            cmdRafraichir.Name = "cmdRafraichir";
            cmdRafraichir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRafraichir.Size = new System.Drawing.Size(76, 24);
            cmdRafraichir.TabIndex = 12;
            cmdRafraichir.Text = "Rafraichir";
            cmdRafraichir.UseVisualStyleBackColor = true;
            cmdRafraichir.Click += new System.EventHandler(cmdRafraichir_Click);
            // 
            // cmbTri
            // 
            cmbTri.BackColor = System.Drawing.Color.Black;
            cmbTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTri.ForeColor = System.Drawing.Color.White;
            cmbTri.Items.AddRange(new object[] {
            "PIECE_GRB",
            "No. d\'item",
            "Manufacturier",
            "Description française",
            "Description anglaise"});
            cmbTri.Location = new System.Drawing.Point(762, 25);
            cmbTri.Name = "cmbTri";
            cmbTri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbTri.Size = new System.Drawing.Size(131, 23);
            cmbTri.TabIndex = 23;
            // 
            // cmdFermer
            // 
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdFermer.ForeColor = System.Drawing.Color.White;
            cmdFermer.Location = new System.Drawing.Point(1384, 685);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(94, 29);
            cmdFermer.TabIndex = 42;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(Cmdfermer_Click);
            // 
            // cmdAjouter
            // 
            cmdAjouter.BackColor = System.Drawing.Color.Black;
            cmdAjouter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAjouter.ForeColor = System.Drawing.Color.White;
            cmdAjouter.Location = new System.Drawing.Point(671, 685);
            cmdAjouter.Name = "cmdAjouter";
            cmdAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAjouter.Size = new System.Drawing.Size(94, 29);
            cmdAjouter.TabIndex = 36;
            cmdAjouter.Text = "Ajouter";
            cmdAjouter.UseVisualStyleBackColor = true;
            cmdAjouter.Click += new System.EventHandler(Cmdajouter_Click);
            // 
            // cmbCategorie
            // 
            cmbCategorie.BackColor = System.Drawing.Color.Black;
            cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategorie.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbCategorie.ForeColor = System.Drawing.Color.White;
            cmbCategorie.Location = new System.Drawing.Point(994, 30);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbCategorie.Size = new System.Drawing.Size(131, 21);
            cmbCategorie.TabIndex = 22;
            cmbCategorie.Visible = false;
            cmbCategorie.SelectedIndexChanged += new System.EventHandler(cmbCategorie_SelectedIndexChanged);
            // 
            // txtRaison
            // 
            txtRaison.AcceptsReturn = true;
            txtRaison.BackColor = System.Drawing.Color.Black;
            txtRaison.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtRaison.ForeColor = System.Drawing.Color.White;
            txtRaison.Location = new System.Drawing.Point(289, 36);
            txtRaison.MaxLength = 255;
            txtRaison.Name = "txtRaison";
            txtRaison.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtRaison.Size = new System.Drawing.Size(448, 23);
            txtRaison.TabIndex = 8;
            // 
            // cmbNoAchat
            // 
            cmbNoAchat.BackColor = System.Drawing.Color.Black;
            cmbNoAchat.ForeColor = System.Drawing.Color.White;
            cmbNoAchat.Location = new System.Drawing.Point(289, 8);
            cmbNoAchat.Name = "cmbNoAchat";
            cmbNoAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbNoAchat.Size = new System.Drawing.Size(178, 23);
            cmbNoAchat.TabIndex = 1;
            cmbNoAchat.SelectedIndexChanged += new System.EventHandler(cmbNoAchat_SelectedIndexChanged);
            cmbNoAchat.KeyUp += new System.Windows.Forms.KeyEventHandler(cmbNoAchat_KeyUp);
            // 
            // cmdModifier
            // 
            cmdModifier.BackColor = System.Drawing.Color.Black;
            cmdModifier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdModifier.ForeColor = System.Drawing.Color.White;
            cmdModifier.Location = new System.Drawing.Point(876, 685);
            cmdModifier.Name = "cmdModifier";
            cmdModifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdModifier.Size = new System.Drawing.Size(94, 29);
            cmdModifier.TabIndex = 41;
            cmdModifier.Text = "Modifier";
            cmdModifier.UseVisualStyleBackColor = true;
            cmdModifier.Click += new System.EventHandler(cmdModifier_Click);
            // 
            // cmdSupprimer
            // 
            cmdSupprimer.BackColor = System.Drawing.Color.Black;
            cmdSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdSupprimer.ForeColor = System.Drawing.Color.White;
            cmdSupprimer.Location = new System.Drawing.Point(773, 685);
            cmdSupprimer.Name = "cmdSupprimer";
            cmdSupprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSupprimer.Size = new System.Drawing.Size(94, 29);
            cmdSupprimer.TabIndex = 39;
            cmdSupprimer.Text = "Supprimer";
            cmdSupprimer.UseVisualStyleBackColor = true;
            cmdSupprimer.Click += new System.EventHandler(cmdsupprimer_Click);
            // 
            // cmdImprimer
            // 
            cmdImprimer.BackColor = System.Drawing.Color.Black;
            cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdImprimer.ForeColor = System.Drawing.Color.White;
            cmdImprimer.Location = new System.Drawing.Point(12, 685);
            cmdImprimer.Name = "cmdImprimer";
            cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdImprimer.Size = new System.Drawing.Size(94, 29);
            cmdImprimer.TabIndex = 30;
            cmdImprimer.Text = "Imprimer";
            cmdImprimer.UseVisualStyleBackColor = true;
            cmdImprimer.Click += new System.EventHandler(cmdImprimer_Click);
            // 
            // txtAcheteur
            // 
            txtAcheteur.AcceptsReturn = true;
            txtAcheteur.BackColor = System.Drawing.Color.Black;
            txtAcheteur.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAcheteur.ForeColor = System.Drawing.Color.White;
            txtAcheteur.Location = new System.Drawing.Point(597, 8);
            txtAcheteur.MaxLength = 0;
            txtAcheteur.Name = "txtAcheteur";
            txtAcheteur.ReadOnly = true;
            txtAcheteur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAcheteur.Size = new System.Drawing.Size(140, 23);
            txtAcheteur.TabIndex = 4;
            // 
            // cmdBonCommande
            // 
            cmdBonCommande.BackColor = System.Drawing.Color.Black;
            cmdBonCommande.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdBonCommande.ForeColor = System.Drawing.Color.White;
            cmdBonCommande.Location = new System.Drawing.Point(540, 685);
            cmdBonCommande.Name = "cmdBonCommande";
            cmdBonCommande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdBonCommande.Size = new System.Drawing.Size(122, 29);
            cmdBonCommande.TabIndex = 34;
            cmdBonCommande.Text = "Bon de commande";
            cmdBonCommande.UseVisualStyleBackColor = true;
            cmdBonCommande.Visible = false;
            cmdBonCommande.Click += new System.EventHandler(cmdBonCommande_Click);
            // 
            // lvwAchat
            // 
            lvwAchat.BackColor = System.Drawing.Color.Black;
            lvwAchat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwAchat_ColumnHeader_1,
            _lvwAchat_ColumnHeader_2,
            _lvwAchat_ColumnHeader_3,
            _lvwAchat_ColumnHeader_4,
            _lvwAchat_ColumnHeader_5,
            _lvwAchat_ColumnHeader_6,
            _lvwAchat_ColumnHeader_7,
            _lvwAchat_ColumnHeader_8,
            _lvwAchat_ColumnHeader_9,
            _lvwAchat_ColumnHeader_10,
            _lvwAchat_ColumnHeader_11});
            lvwAchat.ForeColor = System.Drawing.Color.White;
            lvwAchat.FullRowSelect = true;
            lvwAchat.GridLines = true;
            lvwAchat.Location = new System.Drawing.Point(12, 92);
            lvwAchat.Name = "lvwAchat";
            lvwAchat.Size = new System.Drawing.Size(1466, 587);
            lvwAchat.TabIndex = 29;
            lvwAchat.UseCompatibleStateImageBehavior = false;
            lvwAchat.View = System.Windows.Forms.View.Details;
            lvwAchat.DoubleClick += new System.EventHandler(lvwAchat_DoubleClick);
            lvwAchat.KeyDown += new System.Windows.Forms.KeyEventHandler(lvwAchat_KeyDown);
            lvwAchat.MouseDown += new System.Windows.Forms.MouseEventHandler(lvwAchat_MouseDown);
            // 
            // _lvwAchat_ColumnHeader_1
            // 
            _lvwAchat_ColumnHeader_1.Text = "Qté";
            _lvwAchat_ColumnHeader_1.Width = 40;
            // 
            // _lvwAchat_ColumnHeader_2
            // 
            _lvwAchat_ColumnHeader_2.Text = "No. d\'item";
            _lvwAchat_ColumnHeader_2.Width = 150;
            // 
            // _lvwAchat_ColumnHeader_3
            // 
            _lvwAchat_ColumnHeader_3.Text = "Description";
            _lvwAchat_ColumnHeader_3.Width = 348;
            // 
            // _lvwAchat_ColumnHeader_4
            // 
            _lvwAchat_ColumnHeader_4.Text = "Manufacturier";
            _lvwAchat_ColumnHeader_4.Width = 186;
            // 
            // _lvwAchat_ColumnHeader_5
            // 
            _lvwAchat_ColumnHeader_5.Text = "Prix listé";
            _lvwAchat_ColumnHeader_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwAchat_ColumnHeader_5.Width = 80;
            // 
            // _lvwAchat_ColumnHeader_6
            // 
            _lvwAchat_ColumnHeader_6.Text = "Escompte";
            _lvwAchat_ColumnHeader_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwAchat_ColumnHeader_6.Width = 65;
            // 
            // _lvwAchat_ColumnHeader_7
            // 
            _lvwAchat_ColumnHeader_7.Text = "Prix net";
            _lvwAchat_ColumnHeader_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwAchat_ColumnHeader_7.Width = 100;
            // 
            // _lvwAchat_ColumnHeader_8
            // 
            _lvwAchat_ColumnHeader_8.Text = "Distributeur";
            _lvwAchat_ColumnHeader_8.Width = 180;
            // 
            // _lvwAchat_ColumnHeader_9
            // 
            _lvwAchat_ColumnHeader_9.Text = "TOTAL";
            _lvwAchat_ColumnHeader_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwAchat_ColumnHeader_9.Width = 100;
            // 
            // _lvwAchat_ColumnHeader_10
            // 
            _lvwAchat_ColumnHeader_10.Text = "Date Commande";
            _lvwAchat_ColumnHeader_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            _lvwAchat_ColumnHeader_10.Width = 110;
            // 
            // _lvwAchat_ColumnHeader_11
            // 
            _lvwAchat_ColumnHeader_11.Text = "Date Requise";
            _lvwAchat_ColumnHeader_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            _lvwAchat_ColumnHeader_11.Width = 100;
            // 
            // lvwPieces
            // 
            lvwPieces.BackColor = System.Drawing.Color.Black;
            lvwPieces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwPieces_ColumnHeader_1,
            _lvwPieces_ColumnHeader_2,
            _lvwPieces_ColumnHeader_3,
            _lvwPieces_ColumnHeader_4,
            _lvwPieces_ColumnHeader_5,
            _lvwPieces_ColumnHeader_6});
            lvwPieces.ForeColor = System.Drawing.Color.White;
            lvwPieces.FullRowSelect = true;
            lvwPieces.GridLines = true;
            lvwPieces.Location = new System.Drawing.Point(9, 157);
            lvwPieces.Name = "lvwPieces";
            lvwPieces.Size = new System.Drawing.Size(1027, 194);
            lvwPieces.TabIndex = 26;
            lvwPieces.UseCompatibleStateImageBehavior = false;
            lvwPieces.View = System.Windows.Forms.View.Details;
            lvwPieces.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(lvwPieces_ColumnClick);
            lvwPieces.DoubleClick += new System.EventHandler(lvwPieces_DoubleClick);
            lvwPieces.KeyDown += new System.Windows.Forms.KeyEventHandler(lvwPieces_KeyDown);
            // 
            // _lvwPieces_ColumnHeader_1
            // 
            _lvwPieces_ColumnHeader_1.Text = "PIECE_GRB";
            _lvwPieces_ColumnHeader_1.Width = 161;
            // 
            // _lvwPieces_ColumnHeader_2
            // 
            _lvwPieces_ColumnHeader_2.Text = "No. d\'item";
            _lvwPieces_ColumnHeader_2.Width = 217;
            // 
            // _lvwPieces_ColumnHeader_3
            // 
            _lvwPieces_ColumnHeader_3.Text = "Manufacturier";
            _lvwPieces_ColumnHeader_3.Width = 136;
            // 
            // _lvwPieces_ColumnHeader_4
            // 
            _lvwPieces_ColumnHeader_4.Text = "Description française";
            _lvwPieces_ColumnHeader_4.Width = 477;
            // 
            // _lvwPieces_ColumnHeader_5
            // 
            _lvwPieces_ColumnHeader_5.Text = "Description anglaise";
            _lvwPieces_ColumnHeader_5.Width = 477;
            // 
            // _lvwPieces_ColumnHeader_6
            // 
            _lvwPieces_ColumnHeader_6.Text = "Commentaire";
            _lvwPieces_ColumnHeader_6.Width = 170;
            // 
            // txtNoAchat
            // 
            txtNoAchat.AcceptsReturn = true;
            txtNoAchat.BackColor = System.Drawing.Color.Black;
            txtNoAchat.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoAchat.ForeColor = System.Drawing.Color.White;
            txtNoAchat.Location = new System.Drawing.Point(289, 8);
            txtNoAchat.MaxLength = 0;
            txtNoAchat.Name = "txtNoAchat";
            txtNoAchat.ReadOnly = true;
            txtNoAchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoAchat.Size = new System.Drawing.Size(178, 23);
            txtNoAchat.TabIndex = 2;
            txtNoAchat.Visible = false;
            // 
            // txtDate
            // 
            txtDate.AcceptsReturn = true;
            txtDate.BackColor = System.Drawing.Color.Black;
            txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDate.ForeColor = System.Drawing.Color.White;
            txtDate.Location = new System.Drawing.Point(289, 59);
            txtDate.MaxLength = 0;
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDate.Size = new System.Drawing.Size(86, 23);
            txtDate.TabIndex = 10;
            // 
            // cmdEnregistrer
            // 
            cmdEnregistrer.BackColor = System.Drawing.Color.Black;
            cmdEnregistrer.ForeColor = System.Drawing.Color.White;
            cmdEnregistrer.Location = new System.Drawing.Point(773, 685);
            cmdEnregistrer.Name = "cmdEnregistrer";
            cmdEnregistrer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdEnregistrer.Size = new System.Drawing.Size(94, 29);
            cmdEnregistrer.TabIndex = 38;
            cmdEnregistrer.Text = "Enregistrer";
            cmdEnregistrer.UseVisualStyleBackColor = true;
            cmdEnregistrer.Click += new System.EventHandler(cmdEnregistrer_Click);
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(876, 685);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(94, 29);
            cmdAnnuler.TabIndex = 40;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // cmdMaterielInutile
            // 
            cmdMaterielInutile.BackColor = System.Drawing.Color.Black;
            cmdMaterielInutile.ForeColor = System.Drawing.Color.White;
            cmdMaterielInutile.Location = new System.Drawing.Point(671, 685);
            cmdMaterielInutile.Name = "cmdMaterielInutile";
            cmdMaterielInutile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdMaterielInutile.Size = new System.Drawing.Size(94, 29);
            cmdMaterielInutile.TabIndex = 37;
            cmdMaterielInutile.Text = "Inutile";
            cmdMaterielInutile.UseVisualStyleBackColor = true;
            cmdMaterielInutile.Click += new System.EventHandler(cmdMaterielInutile_Click);
            // 
            // cmdMauvaisPrix
            // 
            cmdMauvaisPrix.BackColor = System.Drawing.Color.Black;
            cmdMauvaisPrix.ForeColor = System.Drawing.Color.White;
            cmdMauvaisPrix.Location = new System.Drawing.Point(568, 685);
            cmdMauvaisPrix.Name = "cmdMauvaisPrix";
            cmdMauvaisPrix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdMauvaisPrix.Size = new System.Drawing.Size(94, 29);
            cmdMauvaisPrix.TabIndex = 35;
            cmdMauvaisPrix.Text = "Prix";
            cmdMauvaisPrix.UseVisualStyleBackColor = true;
            cmdMauvaisPrix.Click += new System.EventHandler(cmdMauvaisPrix_Click);
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(233, 62);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(213, 15);
            Label2.TabIndex = 9;
            Label2.Text = "Date                                           AA-MM-JJ";
            // 
            // lblPrixTotal
            // 
            lblPrixTotal.AutoSize = true;
            lblPrixTotal.BackColor = System.Drawing.Color.Black;
            lblPrixTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrixTotal.ForeColor = System.Drawing.Color.White;
            lblPrixTotal.Location = new System.Drawing.Point(569, 63);
            lblPrixTotal.Name = "lblPrixTotal";
            lblPrixTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrixTotal.Size = new System.Drawing.Size(61, 13);
            lblPrixTotal.TabIndex = 5;
            lblPrixTotal.Text = "Prix Total";
            // 
            // _Label1_0
            // 
            _Label1_0.AutoSize = true;
            _Label1_0.BackColor = System.Drawing.Color.Black;
            _Label1_0.ForeColor = System.Drawing.Color.White;
            _Label1_0.Location = new System.Drawing.Point(233, 8);
            _Label1_0.Name = "_Label1_0";
            _Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_0.Size = new System.Drawing.Size(50, 15);
            _Label1_0.TabIndex = 0;
            _Label1_0.Text = "Numéro";
            // 
            // lblTri
            // 
            lblTri.AutoSize = true;
            lblTri.BackColor = System.Drawing.Color.Black;
            lblTri.ForeColor = System.Drawing.Color.White;
            lblTri.Location = new System.Drawing.Point(762, 7);
            lblTri.Name = "lblTri";
            lblTri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTri.Size = new System.Drawing.Size(60, 15);
            lblTri.TabIndex = 17;
            lblTri.Text = "Trier par :";
            // 
            // lblRaison
            // 
            lblRaison.AutoSize = true;
            lblRaison.BackColor = System.Drawing.Color.Black;
            lblRaison.ForeColor = System.Drawing.Color.White;
            lblRaison.Location = new System.Drawing.Point(233, 36);
            lblRaison.Name = "lblRaison";
            lblRaison.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblRaison.Size = new System.Drawing.Size(48, 15);
            lblRaison.TabIndex = 7;
            lblRaison.Text = "Raison ";
            // 
            // lblCategorie
            // 
            lblCategorie.AutoSize = true;
            lblCategorie.BackColor = System.Drawing.Color.Black;
            lblCategorie.ForeColor = System.Drawing.Color.White;
            lblCategorie.Location = new System.Drawing.Point(994, 12);
            lblCategorie.Name = "lblCategorie";
            lblCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblCategorie.Size = new System.Drawing.Size(131, 15);
            lblCategorie.TabIndex = 11;
            lblCategorie.Text = "CatégorieFournisseur :";
            lblCategorie.Visible = false;
            // 
            // lblNoSoumission
            // 
            lblNoSoumission.AutoSize = true;
            lblNoSoumission.BackColor = System.Drawing.Color.Black;
            lblNoSoumission.ForeColor = System.Drawing.Color.White;
            lblNoSoumission.Location = new System.Drawing.Point(531, 8);
            lblNoSoumission.Name = "lblNoSoumission";
            lblNoSoumission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNoSoumission.Size = new System.Drawing.Size(55, 15);
            lblNoSoumission.TabIndex = 3;
            lblNoSoumission.Text = "Acheteur";
            // 
            // ACHAT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1489, 726);
            Controls.Add(fraDateRequise);
            Controls.Add(fraPieceTrouve);
            Controls.Add(fraPrixPiece);
            Controls.Add(cmdReception);
            Controls.Add(fraInventaire);
            Controls.Add(cmdInventaire);
            Controls.Add(cmdReset);
            Controls.Add(cmdRetour);
            Controls.Add(cmdDemande);
            Controls.Add(cmdTri);
            Controls.Add(txtPrixTotal);
            Controls.Add(cmdRafraichir);
            Controls.Add(cmbTri);
            Controls.Add(cmdFermer);
            Controls.Add(cmdAjouter);
            Controls.Add(cmbCategorie);
            Controls.Add(txtRaison);
            Controls.Add(fraFournisseur);
            Controls.Add(cmbNoAchat);
            Controls.Add(cmdModifier);
            Controls.Add(cmdSupprimer);
            Controls.Add(cmdImprimer);
            Controls.Add(txtAcheteur);
            Controls.Add(cmdBonCommande);
            Controls.Add(lvwAchat);
            Controls.Add(lvwPieces);
            Controls.Add(txtNoAchat);
            Controls.Add(txtDate);
            Controls.Add(cmdEnregistrer);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdMaterielInutile);
            Controls.Add(cmdMauvaisPrix);
            Controls.Add(Label2);
            Controls.Add(lblPrixTotal);
            Controls.Add(_Label1_0);
            Controls.Add(lblTri);
            Controls.Add(lblRaison);
            Controls.Add(lblCategorie);
            Controls.Add(lblNoSoumission);
            Location = new System.Drawing.Point(3, 22);
            Name = "Achats";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            fraDateRequise.ResumeLayout(false);
            fraPieceTrouve.ResumeLayout(false);
            fraPrixPiece.ResumeLayout(false);
            fraPrixPiece.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(imgEU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgSpain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(imgCanada)).EndInit();
            fraFournisseur.ResumeLayout(false);
            fraInventaire.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
            internal string m_sNoAchat;
        public bool m_bAnnuler { get; internal set; }
        private const int I_COL_ACHAT_QUANTITE = 0;
        private const int I_COL_ACHAT_PIECE = 1;
        private const int I_COL_ACHAT_DESCR = 2;
        private const int I_COL_ACHAT_MANUFACT = 3;
        private const int I_COL_ACHAT_PRIX_LIST = 4;
        private const int I_COL_ACHAT_ESCOMPTE = 5;
        private const int I_COL_ACHAT_PRIX_NET = 6;
        private const int I_COL_ACHAT_DISTRIB = 7;
        private const int I_COL_ACHAT_TOTAL = 8;
        private const int I_COL_ACHAT_DATE_COMMANDE = 9;
        private const int I_COL_ACHAT_DATE_REQUISE = 10;
        private const int I_COL_PIECES_PIECE_GRB = 0;
        private const int I_COL_PIECES_NO_ITEM = 1;
        private const int I_COL_PIECES_MANUFACT = 2;
        private const int I_COL_PIECES_DESCR_FR = 3;
        private const int I_COL_PIECES_DESCR_EN = 4;
        private const int I_COL_PIECES_COMMENT = 5;
        private const int I_COL_RECH_PIECE_GRB = 0;
        private const int I_COL_RECH_NO_ITEM = 1;
        private const int I_COL_RECH_CATEGORIE = 2;
        private const int I_COL_RECH_MANUFACT = 3;
        private const int I_COL_RECH_DESCR_FR = 4;
        private const int I_COL_RECH_DESCR_EN = 5;
        private const int I_COL_INV_NO_ITEM = 0;
        private const int I_COL_INV_MANUFACT = 1;
        private const int I_COL_INV_DESCR = 2;
        private const int I_COL_INV_COMMENT = 3;
        private const int I_COL_INV_QTE_STOCK = 4;
        private const int I_COL_INV_QTE_MINIMUM = 5;
        private const int I_COL_INV_QTE_COMMANDE = 6;
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
        private const int I_CMB_PIECE_GRB = 0;
        private const int I_CMB_PIECE = 1;
        private const int I_CMB_FABRICANT = 2;
        private const int I_CMB_DESCR_FR = 3;
        private const int I_CMB_DESCR_EN = 4;
        private const int I_TOP_AJOUT_MODIF = 4320;
        private const int I_HEIGHT_AJOUT_MODIF = 2535;
        private const int I_TOP_INACTIF = 1680;
        private const int I_HEIGHT_INACTIF = 5175;
        private const int I_WIDTH_CATEGORIE_ELEC = 1695;
        private const int I_WIDTH_CATEGORIE_MEC = 5175;
        private string m_sTri;
        private int m_iCol;
        private bool m_bModeAjout;
        private bool m_bModeAffichage;
        private string m_sAncienAchat;
        private EnumMode m_eMode;
        private EnumCatalogue m_eCatalogue;
        private bool m_bInventaire;
        private string m_sQuantite;
        private bool m_bRecherchePiece;
        private bool m_bPieceInutile;
        private bool m_bMauvaisPrix;
        private bool m_bMonthViewHasFocus;
        public ACHAT()
        {
            InitializeComponent();
        }
        internal ACHAT(Program.EnumCatalogue eLECTRIQUE)
        {
            InitializeComponent();
            Afficher(eLECTRIQUE);
        }
        private void AnnulerCommande()
        {
            try
            {
                ListViewItem itmAvant;
                ListViewItem itmAnnulation;
                itmAvant = lvwAchat.FocusedItem;
                itmAnnulation = lvwAchat.Items.Insert(itmAvant.Index + 1, "");
                itmAnnulation.Checked = itmAvant.Checked;
                itmAnnulation.Text = "-" + itmAvant.Text;
                itmAnnulation.Tag = itmAvant.Tag;
                if (itmAnnulation.SubItems.Count > I_COL_ACHAT_PIECE)
                {
                    itmAnnulation.SubItems[I_COL_ACHAT_PIECE].Text = itmAvant.SubItems[I_COL_ACHAT_PIECE].Text;
                }
                else
                {
                    itmAnnulation.SubItems.Insert(I_COL_ACHAT_PIECE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_PIECE].Text));
                }
                itmAnnulation.SubItems[I_COL_ACHAT_PIECE].Tag = itmAvant.SubItems[I_COL_ACHAT_PIECE].Tag;
                if (itmAnnulation.SubItems.Count > I_COL_ACHAT_DESCR)
                {
                    itmAnnulation.SubItems[I_COL_ACHAT_DESCR].Text = itmAvant.SubItems[I_COL_ACHAT_DESCR].Text;
                }
                else
                {
                    itmAnnulation.SubItems.Insert(I_COL_ACHAT_DESCR, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_DESCR].Text));
                }
                itmAnnulation.SubItems[I_COL_ACHAT_DESCR].Tag = itmAvant.SubItems[I_COL_ACHAT_DESCR].Tag;
                if (itmAnnulation.SubItems.Count > I_COL_ACHAT_MANUFACT)
                {
                    itmAnnulation.SubItems[I_COL_ACHAT_MANUFACT].Text = itmAvant.SubItems[I_COL_ACHAT_MANUFACT].Text;
                }
                else
                {
                    itmAnnulation.SubItems.Insert(I_COL_ACHAT_MANUFACT, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_MANUFACT].Text));
                }
                itmAnnulation.SubItems[I_COL_ACHAT_MANUFACT].Tag = itmAvant.SubItems[I_COL_ACHAT_MANUFACT].Tag;

                if (itmAnnulation.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                {
                    itmAnnulation.SubItems[I_COL_ACHAT_PRIX_LIST].Text = itmAvant.SubItems[I_COL_ACHAT_PRIX_LIST].Text;
                }
                else
                {
                    itmAnnulation.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_PRIX_LIST].Text));
                }
                itmAnnulation.SubItems[I_COL_ACHAT_PRIX_LIST].Tag = itmAvant.SubItems[I_COL_ACHAT_PRIX_LIST].Tag;
                if (itmAnnulation.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                {
                    itmAnnulation.SubItems[I_COL_ACHAT_ESCOMPTE].Text = itmAvant.SubItems[I_COL_ACHAT_ESCOMPTE].Text;
                }
                else
                {
                    itmAnnulation.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_ESCOMPTE].Text));
                }
                if (itmAnnulation.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                {
                    itmAnnulation.SubItems[I_COL_ACHAT_PRIX_NET].Text = itmAvant.SubItems[I_COL_ACHAT_PRIX_NET].Text;
                }
                else
                {
                    itmAnnulation.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_PRIX_NET].Text));
                }

                if (itmAnnulation.SubItems.Count > I_COL_ACHAT_DISTRIB)
                {
                    itmAnnulation.SubItems[I_COL_ACHAT_DISTRIB].Text = itmAvant.SubItems[I_COL_ACHAT_DISTRIB].Text;
                }
                else
                {
                    itmAnnulation.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_DISTRIB].Text));
                }
                itmAnnulation.SubItems[I_COL_ACHAT_DISTRIB].Tag = itmAvant.SubItems[I_COL_ACHAT_DISTRIB].Tag;

                if (itmAnnulation.SubItems.Count > I_COL_ACHAT_TOTAL)
                {
                    itmAnnulation.SubItems[I_COL_ACHAT_TOTAL].Text = "-" + itmAvant.SubItems[I_COL_ACHAT_TOTAL].Text;
                }
                else
                {
                    itmAnnulation.SubItems.Insert(I_COL_ACHAT_TOTAL, new ListViewItem.ListViewSubItem(null, "-" + itmAvant.SubItems[I_COL_ACHAT_TOTAL].Text));
                }
                itmAnnulation.ForeColor = (COLOR_VERT_FORET);
                itmAnnulation.SubItems[I_COL_ACHAT_PIECE].ForeColor = (COLOR_VERT_FORET);
                itmAnnulation.SubItems[I_COL_ACHAT_DESCR].ForeColor = (COLOR_VERT_FORET);
                itmAnnulation.SubItems[I_COL_ACHAT_DISTRIB].ForeColor = (COLOR_VERT_FORET);
                itmAnnulation.SubItems[I_COL_ACHAT_ESCOMPTE].ForeColor = (COLOR_VERT_FORET);
                itmAnnulation.SubItems[I_COL_ACHAT_MANUFACT].ForeColor = (COLOR_VERT_FORET);
                itmAnnulation.SubItems[I_COL_ACHAT_PRIX_LIST].ForeColor = (COLOR_VERT_FORET);
                itmAnnulation.SubItems[I_COL_ACHAT_PRIX_NET].ForeColor = (COLOR_VERT_FORET);
                itmAnnulation.SubItems[I_COL_ACHAT_TOTAL].ForeColor = (COLOR_VERT_FORET);
                itmAvant.ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_PIECE].ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_DESCR].ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_DISTRIB].ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_ESCOMPTE].ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_MANUFACT].ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_PRIX_LIST].ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_PRIX_NET].ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_TOTAL].ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_DATE_COMMANDE].ForeColor = (COLOR_ROSE);
                itmAvant.SubItems[I_COL_ACHAT_DATE_REQUISE].ForeColor = (COLOR_ROSE);
                lvwAchat.Refresh();
                CalculerPrix();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "AnnulerCommande", ex);
            }
        }
        private void Afficher(Program.EnumCatalogue eLECTRIQUE)
        {
            try
            {
                m_eCatalogue = eLECTRIQUE;
                switch (eLECTRIQUE)
                {
                    case EnumCatalogue.ELECTRIQUE: { Text = "ACHAT électrique"; break; }
                    case EnumCatalogue.MECANIQUE: { Text = "ACHAT mécanique"; break; }
                }
                RemplirComboAchat(string.Empty);
                RemplirComboCategorie();
                AfficherControles(EnumMode.MODE_INACTIF);
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "Afficher", ex);
            }
        }
        private void AfficherControles(EnumMode eMode)
        {
            try
            {
                var bAjouter = default(bool);
                var bModifier = default(bool);
                var bSupprimer = default(bool);
                var bEnregistrer = default(bool);
                var bAnnuler = default(bool);
                var bFermer = default(bool);
                var bImprimer = default(bool);
                var bBonCommande = default(bool);
                var bTri = default(bool);
                var bCmbAchat = default(bool);
                var bDemandePrix = default(bool);
                var bRetour = default(bool);
                var bInventaire = default(bool);
                bool bInutile;
                bool bPrix;
                var bPieces = default(bool);
                var bReception = default(bool);
                m_eMode = eMode;
                switch (eMode)
                {
                    case EnumMode.MODE_AJOUT_MODIF:
                        {
                            bEnregistrer = true;
                            bAnnuler = true;
                            bPieces = true;
                            bTri = true;
                            bInventaire = true;
                            bPrix = true;
                            bInutile = true; break;
                        }
                    case EnumMode.MODE_INACTIF:
                        {
                            bModifier = true;
                            bFermer = true;
                            bImprimer = true;
                            bAjouter = true;
                            bBonCommande = true;
                            bSupprimer = true;
                            bCmbAchat = true;
                            bDemandePrix = true;
                            bRetour = true;
                            bReception = true; break;
                        }
                }
                cmbNoAchat.Visible = bCmbAchat;
                txtNoAchat.Visible = !bCmbAchat;
                cmdAjouter.Visible = bAjouter;
                cmdModifier.Visible = bModifier;
                cmdSupprimer.Visible = bSupprimer;
                cmdEnregistrer.Visible = bEnregistrer;
                cmdAnnuler.Visible = bAnnuler;
                cmdFermer.Visible = bFermer;
                cmdImprimer.Visible = bImprimer;
                cmdBonCommande.Visible = bBonCommande;
                cmdDemande.Visible = bDemandePrix;
                cmdRetour.Visible = bRetour;
                cmdInventaire.Visible = bInventaire;
                cmdReception.Visible = bReception;
                lblCategorie.Visible = bPieces;
                cmbCategorie.Visible = bPieces;
                lvwPieces.Visible = bPieces;
                lblTri.Visible = bTri;
                cmbTri.Visible = bTri;
                cmdTri.Visible = bTri;
                cmdRafraichir.Visible = bTri;
                if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
                {
                    txtRaison.ReadOnly = false;
                }
                else
                {
                    txtRaison.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "AfficherControles", ex);
            }
        }
        private void cmbCategorie_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RemplirListViewPieces();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmbCategorie_Click", ex);
            }
        }
        private void cmbNoAchat_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sNomClient;
                string sNomContact;
                int X;
                ADODB.Recordset rstAchat;
                Cursor.Current = Cursors.WaitCursor;
                txtNoAchat.Text = cmbNoAchat.Text;
                RemplirAchat();
                string sIDAchat = Gauche(txtNoAchat.Text, Strings.InStr(1, txtNoAchat.Text, "-") + 2).Trim();
                int iIndexAchat = int.Parse(Droite(txtNoAchat.Text, txtNoAchat.Text.Length - Strings.InStrRev(txtNoAchat.Text, "-")).Trim());
                rstAchat = new Recordset();
                rstAchat.Open("SELECT Modification, Par FRom Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstAchat.Fields["Modification"].Value == true & $"{rstAchat.Fields["Par"].Value}" == Conteneur.idInitiales.Text)
                {
                    cmdReset.Visible = true;
                }
                else
                {
                    cmdReset.Visible = false;
                }
                rstAchat.Close();
                rstAchat = default;
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmbNoAchat_Click", ex);
            }
        }
        private void RemplirAchat()
        {
            try
            {
                ADODB.Recordset rstAchat;
                ADODB.Recordset rstEmploye;
                string sNoAchat = Gauche(txtNoAchat.Text, 9);
                int iIndexAchat = int.Parse(Droite(txtNoAchat.Text, 3));
                rstAchat = new Recordset();
                rstEmploye = new Recordset();
                rstAchat.Open("SELECT * FRom Achat WHERE IDAchat = '" + sNoAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstEmploye.Open("SELECT Employe FRom Employés WHERE noEmploye = " + rstAchat.Fields["Acheteur"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                txtAcheteur.Text = rstEmploye.Fields["employe"].Value;
                txtAcheteur.Tag = rstAchat.Fields["Acheteur"].Value;
                rstEmploye.Close();
                rstEmploye = default;
                txtRaison.Text = rstAchat.Fields["Raison"].Value;
                txtDate.Text = rstAchat.Fields["DateAchat"].Value;
                txtPrixTotal.Text = rstAchat.Fields["PrixTotal"].Value; ;
                rstAchat.Close();
                rstAchat = default;
                RemplirListViewAchat();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirAchat", ex);
            }
        }
        private void cmbNoAchat_KeyUp(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                for (int X = 0; X <= (cmbNoAchat.Items.Count - 1); X++)
                {
                    if ((cmbNoAchat.Items[X].ToString().ToUpper() ?? "") == (cmbNoAchat.Text.ToUpper() ?? ""))
                    {
                        cmbNoAchat.SelectedIndex = X;
                        break;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmbNoAchat_KeyUp", ex);
            }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sChamps;
                string sTable;
                string sTablePiece;
                Cursor.Current = Cursors.WaitCursor;
                m_bInventaire = false;
                m_bMauvaisPrix = false;
                m_bPieceInutile = false;
                m_bRecherchePiece = false;
                AfficherControles(EnumMode.MODE_INACTIF);
                OuvrirAchat(false);
                RemplirComboAchat(m_sAncienAchat);
                m_bModeAjout = false;
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdAnnuler_Click", ex);
            }
        }
        private void cmdAnnulerDateRequise_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraDateRequise.Visible = false;
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdAnnulerDateRequise_Click", ex);
            }
        }
        private void cmdAnnulerDateRequise_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdAnnulerDateRequise_Click(cmdAnnulerDateRequise, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdAnnulerDateRequise_MouseUp", ex);
            }
        }
        private void cmdAnnulerInventaire_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraInventaire.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdAnnulerInventaire_Click", ex);
            }
        }
        private void cmdBonCommande_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstAchat;
                rstAchat = new Recordset();
                rstAchat.Open("SELECT Modification, Par FRom Achat WHERE IDAchat = '" + Gauche(txtNoAchat.Text, 9) + "' AND IndexAchat = " + int.Parse(Droite(txtNoAchat.Text, 3)), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstAchat.Fields["Modification"].Value == false)
                {
                    if (lvwAchat.Items.Count > 0)
                    {
                        ChoixBonCommande f= new ChoixBonCommande(Gauche(txtNoAchat.Text, 9), int.Parse(Droite(txtNoAchat.Text, 3)),m_eCatalogue );
                        f.MdiParent = Conteneur.Mdi;
                        f.Text = $" Bon de commande pour le projet:{Gauche(txtNoAchat.Text, 9)} Index:{int.Parse(Droite(txtNoAchat.Text, 3))}";
                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE) { f.Text += "  Électrique"; } else { f.Text += "  Mécanique"; }
                        f.ShowInTaskbar = false;
                        f.ShowIcon = true;
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Il n'y a pas de pièces à commander pour cet ACHAT!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ce projet est en modification par " + rstAchat.Fields["Par"].Value + "!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rstAchat.Close();
                rstAchat = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdBonCommande_Click", ex);
            }
        }
        private void cmdDemande_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstAchat;
                string sIDAchat;
                int iIndexAchat;
                sIDAchat = txtNoAchat.Text.Split('-')[0].Trim()+"-"+ txtNoAchat.Text.Split('-')[1].Trim();
                iIndexAchat = int.Parse(txtNoAchat.Text.Split('-')[2].Trim());
                rstAchat = new Recordset();
                rstAchat.Open("SELECT * FRom Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (lvwAchat.SelectedItems.Count > 0)
                {

    /*                /// sert a remplir les informations manquantes dans le formulaire ViewDemandePrix
                    ViewDemandePrix.Database.Open($"SELECT DISTINCT QTÉ,PIECE, NUMÉROLIGNE,  DESC_FR,MANUFACT, DATEREQUISE, NOMFOURNISSEUR, REP, INTERNE, TELEPHONNE, FAX," +
                        $" CONDTRANSPORT FRom [DBO].[ACHAT_PIECES] " +
                        $"JOIN [DBO].[FOURNISSEUR] ON [DBO].[ACHAT_PIECES].IDFRS=[DBO].[FOURNISSEUR].IDFRS " +
                        $"WHERE  [IDACHAT]= '{sIDAchat}' AND INDEXACHAT = '{iIndexAchat}' " +
                        $"ORDER BY DATEREQUISE DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                    ViewDemandePrix.it = lvwAchat.SelectedItems;
                    ViewDemandePrix prix = new ViewDemandePrix();
                    prix.Show();*/
                }
                if ((bool)rstAchat.Fields["Modification"].Value == false)
                {
                    Form f = new ChoixDemande(true);
                    f.MdiParent = Conteneur.Mdi;
                    f.Icon = Conteneur.ActiveForm.Icon;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Cet ACHAT est en modification par " + rstAchat.Fields["Par"].Value + "!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rstAchat.Close();
                rstAchat = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdDemande_Click", ex);
            }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstAchat;
                string sIDAchat;
                int iIndexAchat;
                sIDAchat = Strings.Trim(Gauche(txtNoAchat.Text, Strings.InStr(1, txtNoAchat.Text, "-") + 2));
                iIndexAchat = int.Parse(Strings.Trim(Droite(txtNoAchat.Text, Strings.Len(txtNoAchat.Text) - Strings.InStrRev(txtNoAchat.Text, "-"))));
                rstAchat = new Recordset();
                rstAchat.Open("SELECT Modification, Par FRom Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstAchat.Fields["Modification"].Value == false)
                {
                    Form f = new ChoixImpressionAchat(m_eCatalogue);
                    f.Icon = Conteneur.ActiveForm.Icon;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Cet ACHAT est en modification par " + rstAchat.Fields["Par"].Value + "!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rstAchat.Close();
                rstAchat = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdImprimer_Click", ex);
            }
        }
        private void cmdInventaire_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RemplirListViewInventaire();
                fraInventaire.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdInventaire_Click", ex);
            }
        }
        private void cmdOKDateRequise_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwAchat.FocusedItem.SubItems.Count > I_COL_ACHAT_DATE_REQUISE)
                {
                    lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_DATE_REQUISE].Text = mvwDateRequise.SelectionStart.ToShortDateString();
                }
                else
                {
                    lvwAchat.FocusedItem.SubItems.Insert(I_COL_ACHAT_DATE_REQUISE, new ListViewItem.ListViewSubItem((ListViewItem)null, mvwDateRequise.SelectionStart.ToShortDateString()));
                }
                lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_DATE_REQUISE].ForeColor = (COLOR_ORANGE);
                fraDateRequise.Visible = false;
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdOKDateRequise_Click", ex);
            }
        }
        private void cmdOKDateRequise_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdOKDateRequise_Click(cmdOKDateRequise, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdOKDateRequise_MouseUp", ex);
            }
        }
        private void cmdOKInventaire_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bInventaire = true;
                m_bRecherchePiece = false;
                AfficherListeFournisseurs();
                if (lvwFournisseur.Items.Count == 1)
                {
                    if (MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!\nVoulez-vous en ajouter?",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        Form f = new Form();
                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                        {
                            f = new CatalogueElec(cmbCategorie.Text, lvwInventaire.FocusedItem.SubItems[I_COL_INV_MANUFACT].Text, lvwInventaire.FocusedItem.Text);
                        }
                        else
                        {
                            f = new CatalogueMec(cmbCategorie.Text, lvwInventaire.FocusedItem.SubItems[I_COL_INV_MANUFACT].Text, lvwInventaire.FocusedItem.Text);
                        }
                        f.Icon = Conteneur.ActiveForm.Icon;
                        f.Show();
                        Cursor.Current = Cursors.Default;
                        AfficherListeFournisseurs();
                    }
                }
                fraInventaire.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdOKInventaire_Click", ex);
            }
        }
        private void cmdRafraichir_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(m_sTri))
                {
                    m_sTri = string.Empty;
                    RemplirListViewPieces();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdRafraichir_Click", ex);
            }
        }
        private void cmdReset_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstAchat;
                string sIDAchat;
                int iIndexAchat;
                if (MessageBox.Show("Êtes-vous certains de ne pas être en modification sur un autre ordinateur?",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sIDAchat = Strings.Trim(Gauche(txtNoAchat.Text, Strings.InStr(1, txtNoAchat.Text, "-") + 2));
                    iIndexAchat = int.Parse(Strings.Trim(Droite(txtNoAchat.Text, Strings.Len(txtNoAchat.Text) - Strings.InStrRev(txtNoAchat.Text, "-"))));
                    rstAchat = new Recordset();
                    rstAchat.Open("SELECT Modification, Par FRom Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstAchat.Fields["Modification"].Value = false;
                    rstAchat.Fields["Par"].Value = "";
                    rstAchat.Update();
                    rstAchat.Close();
                    rstAchat = default;
                    cmdReset.Visible = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdReset_Click", ex);
            }
        }
        private void cmdTri_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_sTri = Interaction.InputBox("Quel est le texte à trier?");
                m_iCol = (int)cmbTri.SelectedIndex;
                if (!string.IsNullOrEmpty(m_sTri))
                {
                    RemplirListViewPieces();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdTri_Click", ex);
            }
        }
        private void lvwAchat_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
                {
                    if (lvwAchat.Items.Count > 0)
                    {

                        if (string.IsNullOrEmpty(Strings.Trim(lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_DISTRIB].Text)))
                        {
                            ViderChamps_frs();

                            m_bMauvaisPrix = false;

                            RemplirComboFournisseur();

                            fraPrixPiece.Visible = true;

                            fraPrixPiece.Tag = lvwAchat.FocusedItem.Index;

                            cmbfrs.Focus();
                        }
                        else
                        {
                            if (lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_PIECE].ForeColor == COLOR_ORANGE)
                            {
                                if (MessageBox.Show("Voulez-vous annuler cette commande?",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    AnnulerCommande();
                                }
                            }
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwAchat_DblClick", ex);
            }
        }
        // S'il y a plusieurs items de sélectionnés, c'est parce que l'utilisateur a sélectionné plusieurs items
        // Donc, on ne désélectionne pas
        private void lvwAchat_MouseDown(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                var iNbreSelected = default(int);
                var iIndexSelected = default(int);
                int X;
                bool bAfficherMenu;
                if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
                {
                    {
                        if (lvwAchat.Items.Count > 0)
                        {
                            for (X = 0; X <lvwAchat.Items.Count; X++)
                            {
                                if (lvwAchat.Items[X].Selected == true)
                                {
                                    iNbreSelected++;
                                    iIndexSelected = X;
                                }
                            }
                            if (iNbreSelected == 1)
                            {
                                lvwAchat.Items[iIndexSelected].Selected = false;
                            }
                            {
                                if (iNbreSelected == 1)
                                {

                                    bAfficherMenu = false;
                                    if (bAfficherMenu == true)
                                    {
                                        RemplirOptionsMenuRightClick(iNbreSelected);
                                        PopupMenu(0x101, 0, 0, 32, 0, 0, new RECT(32, 32, 60, 60));
                                    }
                                }
                            }
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwAchat_MouseDown", ex);
            }
        }
        private void RemplirOptionsMenuRightClick(int iNbreSelected)
        {
            try
            {
                var bDateRequise = default(bool);
                if (iNbreSelected == 1)
                {
                    if (lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_PIECE].ForeColor == COLOR_ORANGE)
                    {
                        bDateRequise = true;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirOptionsMenuRightClick", ex);
            }
        }
        private void lvwPieces_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader = lvwPieces.Columns[eventArgs.Column];
            try
            {
                string sTexte;
                sTexte = Interaction.InputBox("Quel est le texte à rechercher?");
                if (!string.IsNullOrEmpty(Strings.Trim(sTexte)))
                {
                    if (sTexte.Trim().Length >= 2)
                    {
                        RemplirListViewRecherche((int)(ColumnHeader.Index - 1), sTexte);
                        if (lvwPieceTrouve.Items.Count > 0)
                        {
                            fraPieceTrouve.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrements trouvés!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Il faut un minimum de 2 caractères pour rechercher!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwPieces_ColumnClick", ex);
            }
        }
        private void RechercherPiece(int iCol, string sTexte)
        {
            try
            {  /*Instruction: 67545*/
                string sValeur;
                ADODB.Recordset rstcat;
                int X;
                var bTrouverLvw = default(bool);
                var bTrouverRst = default(bool);
                int iIndexCat;
                var sChamps = default(string);
                string sCategorie;
                for (X = 0; X <lvwPieces.Items.Count ; X++)
                {
                    if (iCol > 0)
                    {

                        sValeur = lvwPieces.Items[X].SubItems[iCol].Text;
                    }
                    else
                    {
                        sValeur = lvwPieces.Items[X].Text;
                    }
                    sValeur = sValeur.ToUpper();
                    sTexte = sTexte.ToUpper();
                    if (sValeur.Contains(sTexte))
                    {
                        lvwPieces.Items[X].Selected = true;
                        lvwPieces.FocusedItem.EnsureVisible();
                        bTrouverLvw = true;
                    }
                    if (bTrouverLvw == true)
                    {
                        break;
                    }
                }
                switch (iCol)
                {
                    case I_COL_PIECES_PIECE_GRB: { sChamps = "PIECE_GRB"; break; }
                    case I_COL_PIECES_NO_ITEM: { sChamps = "PIECE"; break; }
                    case I_COL_PIECES_MANUFACT: { sChamps = "FABRICANT"; break; }
                    case I_COL_PIECES_DESCR_FR: { sChamps = "DESC_FR"; break; }
                    case I_COL_PIECES_DESCR_EN: { sChamps = "DESC_EN"; break; }
                }
                iIndexCat = (int)cmbCategorie.SelectedIndex;
                if (bTrouverLvw == false)
                {
                    rstcat = new Recordset();
                    for (X = (int)(iIndexCat + 1); X <cmbCategorie.Items.Count; X++)
                    {
                        sCategorie = cmbCategorie.Items[X].ToString().Replace("'", "''");
                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                        {
                            rstcat.Open("SELECT * FRom CatalogueElec WHERE " + sChamps + " like '%" + sTexte + "%' AND CATEGORIE = '" + sCategorie + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstcat.Open("SELECT * FRom CatalogueMec WHERE " + sChamps + " like '%" + sTexte + "%' AND CATEGORIE = '" + sCategorie + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        if (!rstcat.EOF)
                        {
                            bTrouverRst = true;
                            cmbCategorie.SelectedIndex = X;
                            RechercherPiece(iCol, sTexte);
                            break;
                        }
                        rstcat.Close();
                    }
                    if (bTrouverRst == false)
                    {
                        for (X = 0; X <(iIndexCat - 1); X++)
                        {
                            sCategorie = cmbCategorie.Items[X].ToString().Replace("'", "''");
                            if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                            {
                                rstcat.Open("SELECT * FRom CatalogueElec WHERE " + sChamps + " like '%" + sTexte + "%' AND CATEGORIE = '" + sCategorie + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            }
                            else
                            {
                                rstcat.Open("SELECT * FRom CatalogueMec WHERE " + sChamps + " like '%" + sTexte + "%' AND CATEGORIE = '" + sCategorie + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            }
                            if (!rstcat.EOF)
                            {
                                bTrouverRst = true;
                                cmbCategorie.SelectedIndex = X;
                                RechercherPiece(iCol, sTexte);
                                break;
                            }
                            rstcat.Close();
                        }
                        if (bTrouverRst == false)
                        {
                            MessageBox.Show("Aucun enregistrements trouvés!", System.Windows.Forms.Application.ProductName+".GUI."+Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    rstcat = default;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RechercherPiece", ex);
            }
        }
        private void lvwPieces_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                string sTexte;
                {
                    if (eventArgs.KeyCode == Keys.F)
                    {
                        sTexte = Interaction.InputBox("Quel est le texte à rechercher?");
                        if (!string.IsNullOrEmpty(sTexte.Trim()))
                        {
                            if (sTexte.Trim().Length >= 3)
                            {
                                RechercherPiece(I_COL_PIECES_NO_ITEM, sTexte);
                            }
                            else
                            {
                                MessageBox.Show("Il faut un minimum de 3 caractères pour rechercher!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwPieces_KeyDown", ex);
            }
        }
        private void cmdEnregistrer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 74602*/
                var iIndexAchat = default(int);

                Cursor.Current = Cursors.WaitCursor;
                foreach (Control objControl in Controls)
                {
                    if (objControl is TextBox)
                    {
                        if (objControl.Visible == true)
                        {
                            if (string.IsNullOrEmpty(Strings.Trim(objControl.Text)))
                            {
                                Cursor.Current = Cursors.Default;
                                MessageBox.Show("Vous devez remplir tous les champs!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                if (BackupPieces(txtNoAchat.Text) == false)
                {
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show("Une erreur est survenue lors de la copie de sauvegarde de l'ACHAT en cours!\n\nVoulez-vous continuer?",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;
                    }
                }
                EnregistrerAchat(txtNoAchat.Text);
                m_bInventaire = false;
                m_bMauvaisPrix = false;
                m_bPieceInutile = false;
                m_bRecherchePiece = false;
                OuvrirAchat(false);
                AfficherControles(EnumMode.MODE_INACTIF);
                if (txtNoAchat.Text.Length == 9)
                {
                    iIndexAchat = TrouverNouvelIndex();
                }
                if (iIndexAchat > 0)
                {
                    AfficherAchat(txtNoAchat.Text + "-" + Droite("00" + iIndexAchat, 3));
                }
                else
                {
                    AfficherAchat(txtNoAchat.Text);
                }
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdEnregistrer_Click", ex);
            }
        }
        private bool BackupPieces(string sNoAchat)
        {
            bool BackupPiecesRet = default;
            try
            {  /*Instruction: 78514*/
                ADODB.Recordset rstAchat;
                ADODB.Recordset rstAchatBackup;
                string sDateCopie;
                string sIDAchat;
                int iIndexAchat;
                if (m_bModeAjout == false)
                {
                    sIDAchat = Gauche(sNoAchat, 9);
                    iIndexAchat = int.Parse(Droite(sNoAchat, 3));
                }
                else
                {
                    BackupPiecesRet = true;
                    return BackupPiecesRet;
                }
                rstAchat = new Recordset();
                rstAchatBackup = new Recordset();
                rstAchat.Open("SELECT * FRom Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                rstAchatBackup.Open("SELECT * FRom Achat_Pieces_Tampon", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sDateCopie = ConvertDate(DateTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay);
                while (!rstAchat.EOF)
                {
                    rstAchatBackup.AddNew();
                    rstAchatBackup.Fields["DateCopie"].Value = sDateCopie;
                    rstAchatBackup.Fields["IDAchat"].Value = rstAchat.Fields["IDAchat"].Value;
                    rstAchatBackup.Fields["IndexAchat"].Value = rstAchat.Fields["IndexAchat"].Value;
                    rstAchatBackup.Fields["Initiales"].Value = Conteneur.idInitiales.Text;
                    rstAchatBackup.Fields["PIECE"].Value = rstAchat.Fields["PIECE"].Value;
                    rstAchatBackup.Fields["NuméroLigne"].Value = rstAchat.Fields["NuméroLigne"].Value;
                    rstAchatBackup.Fields["Qté"].Value = rstAchat.Fields["Qté"].Value;
                    rstAchatBackup.Fields["Desc_FR"].Value = rstAchat.Fields["Desc_FR"].Value;
                    rstAchatBackup.Fields["Desc_EN"].Value = rstAchat.Fields["Desc_EN"].Value;
                    rstAchatBackup.Fields["Manufact"].Value = rstAchat.Fields["Manufact"].Value;
                    rstAchatBackup.Fields["Prix_list"].Value = rstAchat.Fields["Prix_list"].Value;
                    rstAchatBackup.Fields["Escompte"].Value = rstAchat.Fields["Escompte"].Value;
                    rstAchatBackup.Fields["Prix_net"].Value = rstAchat.Fields["Prix_net"].Value;
                    rstAchatBackup.Fields["IDFRS"].Value = rstAchat.Fields["IDFRS"].Value;
                    rstAchatBackup.Fields["Prix_total"].Value = rstAchat.Fields["Prix_total"].Value;
                    rstAchatBackup.Fields["Type"].Value = rstAchat.Fields["Type"].Value;
                    rstAchatBackup.Fields["Commandé"].Value = rstAchat.Fields["Commandé"].Value;
                    rstAchatBackup.Fields["Retour"].Value = rstAchat.Fields["Retour"].Value;
                    rstAchatBackup.Fields["NoRetour"].Value = rstAchat.Fields["NoRetour"].Value;
                    rstAchatBackup.Fields["Recu"].Value = rstAchat.Fields["Recu"].Value;
                    rstAchatBackup.Fields["DateRéception"].Value = rstAchat.Fields["DateRéception"].Value;
                    rstAchatBackup.Fields["QuantitéRecue"].Value = rstAchat.Fields["QuantitéRecue"].Value;
                    rstAchatBackup.Fields["DateCommande"].Value = rstAchat.Fields["DateCommande"].Value;
                    rstAchatBackup.Fields["DateRequise"].Value = rstAchat.Fields["DateRequise"].Value;
                    rstAchatBackup.Fields["Inutile"].Value = rstAchat.Fields["Inutile"].Value;
                    rstAchatBackup.Fields["CommandeAnnulée"].Value = rstAchat.Fields["CommandeAnnulée"].Value;
                    rstAchatBackup.Fields["DateRetour"].Value = rstAchat.Fields["DateRetour"].Value;
                    rstAchatBackup.Fields["PrixOrigine"].Value = rstAchat.Fields["PrixOrigine"].Value;
                    rstAchatBackup.Fields["Devise"].Value = rstAchat.Fields["Devise"].Value;
                    rstAchatBackup.Update();
                    rstAchat.MoveNext();
                }
                rstAchat.Close();
                rstAchat = default;
                rstAchatBackup.Close();
                rstAchatBackup = default;
                BackupPiecesRet = true;
                return true;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "BackupPieces", ex); return false;
            }
        }
        private int TrouverNouvelIndex()
        {
            int TrouverNouvelIndexRet = default;
            try
            {
                ADODB.Recordset rstMax;
                int iIndex;
                rstMax = new Recordset();
                rstMax.Open("SELECT MAX(IndexAchat) AS MaxIndex FRom Achat WHERE IDAchat = '" + txtNoAchat.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iIndex = rstMax.Fields["MaxIndex"].Value;
                rstMax.Close();
                rstMax = default;
                TrouverNouvelIndexRet = iIndex;
                return TrouverNouvelIndexRet;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "TrouverNouvelIndex", ex);
                return 0;
            }
        }
        private void EnregistrerAchat(string sNoAchat)
        {
            try
            {
                ADODB.Recordset rstAchat;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstMax;
                ListViewItem itmPiece;
                var dblPrixTotal = default(double);
                string sIDAchat;
                var iIndexAchat = default(int);
                int X;
                string testgll;
                sIDAchat = Gauche(sNoAchat, 9);
                rstAchat = new Recordset();
                if (m_bModeAjout == true)
                {
                    rstAchat.Open("SELECT * FRom Achat", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstAchat.AddNew();
                    m_bModeAjout = false;
                }
                else
                {
                    iIndexAchat = int.Parse(Droite(sNoAchat, 3));
                    rstAchat.Open("SELECT * FRom Achat WHERE IDAchat" + " = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    UpdateSQL("DELETE FRom Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat);
                }

                rstAchat.Fields["IDAchat"].Value = sIDAchat;
                if (iIndexAchat == 0)
                {
                    rstMax = new Recordset();
                    rstMax.Open("SELECT MAX(IndexAchat) As MaxAchat FRom Achat WHERE IDAchat = '" + sNoAchat + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!(rstMax.Fields["MaxAchat"].Value is DBNull))
                    {
                        rstAchat.Fields["IndexAchat"].Value = rstMax.Fields["MaxAchat"].Value + 1;
                    }
                    else
                    {
                        rstAchat.Fields["IndexAchat"].Value = 1;
                    }
                    rstMax.Close();
                    rstMax = default;
                }
                else
                {
                    rstAchat.Fields["IndexAchat"].Value = iIndexAchat;
                }
                rstAchat.Fields["Raison"].Value = txtRaison.Text;
                rstAchat.Fields["DateAchat"].Value = txtDate.Text;
                rstAchat.Fields["Acheteur"].Value = txtAcheteur.Tag;
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstAchat.Fields["Type"].Value = "E";
                }
                else
                {
                    rstAchat.Fields["Type"].Value = "M";
                }
                rstPiece = new Recordset();
                rstPiece.Open("SELECT * FRom Achat_Pieces", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                for (X = 0; X <lvwAchat.Items.Count; X++)
                {
                    itmPiece = lvwAchat.Items[X];
                    rstPiece.AddNew();
                    rstPiece.Fields["IDAchat"].Value = rstAchat.Fields["IDAchat"].Value;
                    rstPiece.Fields["IndexAchat"].Value = rstAchat.Fields["IndexAchat"].Value;
                    rstPiece.Fields["PIECE"].Value = itmPiece.SubItems[I_COL_ACHAT_PIECE].Text;
                    rstPiece.Fields["NuméroLigne"].Value = X;
                    rstPiece.Fields["Qté"].Value = itmPiece.Text;
                    rstPiece.Fields["Desc_FR"].Value = itmPiece.SubItems[I_COL_ACHAT_DESCR].Text;

                    rstPiece.Fields["Desc_EN"].Value = itmPiece.SubItems[I_COL_ACHAT_DESCR].Tag;
                    rstPiece.Fields["Manufact"].Value = itmPiece.SubItems[I_COL_ACHAT_MANUFACT].Text;
                    rstPiece.Fields["Prix_list"].Value = (itmPiece.SubItems[I_COL_ACHAT_PRIX_LIST].Text, (int)4);
                    if (!string.IsNullOrEmpty(itmPiece.SubItems[I_COL_ACHAT_PRIX_LIST].Text))
                    {
                        if (itmPiece.SubItems[I_COL_ACHAT_PRIX_LIST].Tag.ToString()!= string.Empty)
                        {

                            rstPiece.Fields["PrixOrigine"].Value = Math.Round(double.Parse(itmPiece.SubItems[I_COL_ACHAT_PRIX_LIST].Tag.ToString().Replace( ".", ",")), 4).ToString().Replace( ".", ",");
                        }
                        else
                        {
                            rstPiece.Fields["PrixOrigine"].Value = "0";
                        }
                    }
                    else
                    {
                        rstPiece.Fields["PrixOrigine"].Value = "0";
                    }
                    if (!string.IsNullOrEmpty(itmPiece.SubItems[I_COL_ACHAT_TOTAL].Text))
                    {
                        rstPiece.Fields["Devise"].Value = itmPiece.SubItems[I_COL_ACHAT_TOTAL].Tag;
                    }
                    else
                    {
                        rstPiece.Fields["Devise"].Value = "";
                    }
                    if (!string.IsNullOrEmpty(Strings.Trim(itmPiece.SubItems[I_COL_ACHAT_ESCOMPTE].Text)))
                    {
                        rstPiece.Fields["Escompte"].Value = ((double.Parse(Strings.Replace(itmPiece.SubItems[I_COL_ACHAT_ESCOMPTE].Text, "%", "")) / 100d).ToString());
                    }
                    else
                    {
                        rstPiece.Fields["Escompte"].Value = "";
                    }
                    rstPiece.Fields["Prix_net"].Value = (itmPiece.SubItems[I_COL_ACHAT_PRIX_NET].Text, (int)4);
                    rstPiece.Fields["DateRéception"].Value = itmPiece.Tag;

                    rstPiece.Fields["NoRetour"].Value = itmPiece.SubItems[I_COL_ACHAT_MANUFACT].Tag;

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(itmPiece.SubItems[I_COL_ACHAT_DISTRIB].Tag, "", false)))
                    {
                        rstPiece.Fields["IDFRS"].Value = itmPiece.SubItems[I_COL_ACHAT_DISTRIB].Tag;
                    }
                    else
                    {
                        rstPiece.Fields["IDFRS"].Value = 0;
                    }

                    if ((itmPiece.SubItems[I_COL_ACHAT_PIECE].ForeColor) == COLOR_ORANGE)
                    {
                        rstPiece.Fields["Commandé"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Commandé"].Value = false;
                    }

                    if ((itmPiece.SubItems[I_COL_ACHAT_PIECE].ForeColor) == COLOR_BLEU | (itmPiece.SubItems[I_COL_ACHAT_PIECE].ForeColor) == COLOR_GRIS)
                    {
                        rstPiece.Fields["Recu"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Recu"].Value = false;
                    }

                    if ((itmPiece.SubItems[I_COL_ACHAT_PIECE].ForeColor) == COLOR_ROUGE)
                    {
                        rstPiece.Fields["Retour"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Retour"].Value = false;
                    }

                    if ((itmPiece.SubItems[I_COL_ACHAT_PIECE].ForeColor) == COLOR_BRUN)
                    {
                        rstPiece.Fields["Inutile"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["Inutile"].Value = false;
                    }

                    if ((itmPiece.SubItems[I_COL_ACHAT_PIECE].ForeColor) == COLOR_VERT_FORET)
                    {
                        rstPiece.Fields["CommandeAnnulée"].Value = true;
                    }
                    else
                    {
                        rstPiece.Fields["CommandeAnnulée"].Value = false;
                    }
                    rstPiece.Fields["Prix_Total"].Value = (itmPiece.SubItems[I_COL_ACHAT_TOTAL].Text);
                    if (!string.IsNullOrEmpty(itmPiece.SubItems[I_COL_ACHAT_DATE_COMMANDE].Text))
                    {
                        rstPiece.Fields["DateCommande"].Value = itmPiece.SubItems[I_COL_ACHAT_DATE_COMMANDE].Text;
                    }
                    else
                    {
                        rstPiece.Fields["DateCommande"].Value = "";
                    }
                    if (!string.IsNullOrEmpty(itmPiece.SubItems[I_COL_ACHAT_DATE_REQUISE].Text))
                    {
                        rstPiece.Fields["DateRequise"].Value = itmPiece.SubItems[I_COL_ACHAT_DATE_REQUISE].Text;
                    }
                    else
                    {
                        rstPiece.Fields["DateRequise"].Value = "";
                    }
                    rstPiece.Update();
                    if (rstPiece.Fields["Prix_Total"].Value != string.Empty)
                    {
                        dblPrixTotal = dblPrixTotal + rstPiece.Fields["Prix_Total"].Value;
                    }
                }
                rstAchat.Fields["PrixTotal"].Value = dblPrixTotal.ToString();
                rstAchat.Update();
                rstAchat.Close();
                rstPiece.Close();
                rstPiece = default;
                rstAchat = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "EnregistrerAchat", ex);
            }
        }
        //Remet en mode affichage le projet ou l'ACHAT voulue        
        private void AfficherAchat(string sNoAchat)
        {
            try
            {
                m_bModeAffichage = true;
                ViderChamps();
                RemplirComboAchat(sNoAchat);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "AfficherAchat", ex);
            }
        }
        private void Cmdfermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 101988*/
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdFermer_Click", ex);
            }
        }
        //Ajoute une ACHAT        
        private void Cmdajouter_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 102428*/
                ADODB.Recordset rstEmploye;
                m_bInventaire = false;
                m_bMauvaisPrix = false;
                m_bPieceInutile = false;
                m_bRecherchePiece = false;
                Form f = new AjoutAchat(m_eCatalogue);
                f.Icon = Conteneur.ActiveForm.Icon;
                f.Show();
                if (m_bAnnuler == false)
                {
                    if (!string.IsNullOrEmpty(m_sNoAchat))
                    {

                        ViderChamps();
                        txtAcheteur.Text = IdNomEmploye;
                        rstEmploye = new Recordset();
                        rstEmploye.Open("SELECT NoEmploye FROM Employés WHERE Initiale = '" + Conteneur.idInitiales.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        txtAcheteur.Tag = rstEmploye.Fields["NoEmploye"].Value;
                        rstEmploye.Close();

                        rstEmploye = default;
                        txtDate.Text = ConvertDate(DateTime.Today);


                        m_sAncienAchat = txtNoAchat.Text;

                        txtNoAchat.Text = m_sNoAchat;
                        m_bModeAjout = true;
                        m_bModeAffichage = false;

                        AfficherControles(EnumMode.MODE_AJOUT_MODIF);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdAjouter_Click", ex);
            }
        }
        //Remplir le combo des tables (Pièces)        
        private void RemplirComboCategorie()
        {
            try
            {  /*Instruction: 104495*/
                ADODB.Recordset rstCategorie;
                string sNomTable;
                cmbCategorie.Items.Clear();
                rstCategorie = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstCategorie.Open("SELECT DISTINCT CATEGORIE FROM CatalogueElec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstCategorie.Open("SELECT DISTINCT CATEGORIE FROM CatalogueMec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstCategorie.EOF)
                {
                    if (!(rstCategorie.Fields["CATEGORIE"].Value is DBNull))
                    {

                        cmbCategorie.Items.Add(rstCategorie.Fields["CATEGORIE"].Value);
                    }
                    rstCategorie.MoveNext();
                }
                rstCategorie.Close();

                rstCategorie = default;
                if (cmbCategorie.Items.Count > 0)
                {
                    cmbCategorie.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirComboCategorie", ex);
            }
        }
        // Modifier un ACHAT
        private void cmdModifier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 106607*/
                ADODB.Recordset rstAchat;
                string sIDAchat;
                int iIndexAchat;

                m_bInventaire = false;
                m_bMauvaisPrix = false;
                m_bPieceInutile = false;
                m_bRecherchePiece = false;
                if (cmbNoAchat.SelectedIndex > -1)
                {
                    sIDAchat = Strings.Trim(Gauche(txtNoAchat.Text, Strings.InStr(1, txtNoAchat.Text, "-") + 2));
                    iIndexAchat = int.Parse(Strings.Trim(Droite(txtNoAchat.Text, Strings.Len(txtNoAchat.Text) - Strings.InStrRev(txtNoAchat.Text, "-"))));
                    rstAchat = new Recordset();
                    rstAchat.Open("SELECT Modification, Par FROM Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstAchat.Fields["Modification"].Value == false)
                    {
                        rstAchat.Close();
                        rstAchat = default;
                        Cursor.Current = Cursors.WaitCursor;


                        m_sAncienAchat = txtNoAchat.Text;
                        m_bModeAjout = false;
                        m_bModeAffichage = false;
                        OuvrirAchat(true);
                        AfficherControles(EnumMode.MODE_AJOUT_MODIF);
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Cet ACHAT est en modification par " + rstAchat.Fields["Par"].Value + "!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rstAchat.Close();
                        rstAchat = default;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdModifier_Click", ex);
            }
        }
        private void cmdsupprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 109863*/
                string sIDAchat;
                int iIndexAchat;
                ADODB.Recordset rstAchat;
                if (cmbNoAchat.Items.Count > 0)
                {
                    sIDAchat = Strings.Trim(Gauche(txtNoAchat.Text, Strings.InStr(1, txtNoAchat.Text, "-") + 2));
                    iIndexAchat = int.Parse(Strings.Trim(Droite(txtNoAchat.Text, Strings.Len(txtNoAchat.Text) - Strings.InStrRev(txtNoAchat.Text, "-"))));
                    rstAchat = new Recordset();
                    rstAchat.Open("SELECT Modification, Par FROM Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstAchat.Fields["Modification"].Value == false)
                    {
                        rstAchat.Close();
                        rstAchat = default;

                        DialogResult iReponse = MessageBox.Show("Voulez-vous vraiment effacer l'ACHAT " + txtNoAchat.Text + "?",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (iReponse == DialogResult.Yes)
                        {

                            sIDAchat = Gauche(txtNoAchat.Text, 9);
                            iIndexAchat = int.Parse(Droite(txtNoAchat.Text, 3));

                            UpdateSQL("DELETE FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat);

                            UpdateSQL("DELETE FROM Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat);

                            RemplirComboAchat(string.Empty);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cet ACHAT est en modification par " + rstAchat.Fields["Par"].Value + "!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rstAchat.Close();
                        rstAchat = default;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdSupprimer_Click", ex);
            }
        }
        //Méthode qui initialise les champs
        private void ViderChamps()
        {
            try
            {  /*Instruction: 112877*/
                txtPrixTotal.Text = 0.ToString();
                txtDate.Text = string.Empty;
                txtRaison.Text = string.Empty;
                txtAcheteur.Text = string.Empty;
                lvwAchat.Items.Clear();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "ViderChamps", ex);
            }
        }
        //Rempli le combo des achats
        private void RemplirComboAchat(string sNoAchat)
        {
            try
            {  /*Instruction: 113558*/
                ADODB.Recordset rstAchat;
                string sType;
                int X;
                //  cmbNoAchat.Items.Clear();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    sType = "E";
                }
                else
                {
                    sType = "M";
                }
                rstAchat = new Recordset();
                rstAchat.Open("SELECT * FROM Achat WHERE Type = '" + sType + "' ORDER BY IDAchat DESC, IndexAchat DESC", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstAchat.EOF)
                {
                    cmbNoAchat.Items.Add(rstAchat.Fields["IDAchat"].Value + "-" + Droite("00" + rstAchat.Fields["IndexAchat"].Value, 3));
                    rstAchat.MoveNext();
                }
                rstAchat.Close();
                rstAchat = default;
                if (cmbNoAchat.Items.Count > 0)
                {
                    if (!string.IsNullOrEmpty(sNoAchat))
                    {
                        for (X = 0; X <=(cmbNoAchat.Items.Count - 1) ; X++)
                        {
                            if ((cmbNoAchat.Items[X].ToString() ?? "") == (sNoAchat ?? ""))
                            {
                                cmbNoAchat.SelectedIndex = X;
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmbNoAchat.SelectedIndex = 0;
                    }
                }
                else
                {
                    ViderChamps();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirComboAchat", ex);
            }
        }
        private void CalculerPrixReel(string sNoItem)
        {
            try
            {  /*Instruction: 115701*/
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstConfig;
                var sPrixCalcul = default(string);
                string sTauxUSA;
                string sTauxSPA;
                string sType;
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    sType = "E";
                }
                else
                {
                    sType = "M";
                }
                rstConfig = new Recordset();
                rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                sTauxUSA = rstConfig.Fields["TauxAmericain"].Value;
                sTauxSPA = rstConfig.Fields["TauxEspagnol"].Value;
                rstConfig.Close();

                rstConfig = default;
                rstPieceFRS = new Recordset();
                rstPieceFRS.CursorLocation = CursorLocationEnum.adUseServer;
                rstPieceFRS.Open("SELECT PrixReel, PRIX_NET, PRIX_SP, DeviseMonétaire FROM PiecesFRS WHERE PIECE = '" + Strings.Replace(sNoItem, "'", "''") + "' AND Type = '" + sType + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPieceFRS.EOF)
                {
                    if (rstPieceFRS.Fields["PRIX_NET"].Value != string.Empty)
                    {
                        sPrixCalcul = rstPieceFRS.Fields["PRIX_NET"].Value;
                    }
                    else
                    {
                        if (rstPieceFRS.Fields["PRIX_SP"].Value != string.Empty)
                        {
                            sPrixCalcul = rstPieceFRS.Fields["PRIX_SP"].Value;
                        }
                    }
                    sPrixCalcul = Strings.Replace(sPrixCalcul, ".", ",");
                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "USA")
                    {
                        rstPieceFRS.Fields["PrixReel"].Value = (Math.Round(double.Parse(sPrixCalcul) / double.Parse(sTauxUSA), 4).ToString(), EnumConvert.MODE_DECIMAL, (int)4);
                    }
                    else
                    {
                        if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "SPA")
                        {
                            rstPieceFRS.Fields["PrixReel"].Value = (Math.Round(double.Parse(sPrixCalcul) / double.Parse(sTauxSPA), 4).ToString(), EnumConvert.MODE_DECIMAL, (int)4);
                        }
                        else
                        {
                            rstPieceFRS.Fields["PrixReel"].Value = (sPrixCalcul, EnumConvert.MODE_DECIMAL, (int)4);
                        }
                    }
                    rstPieceFRS.Update();
                    rstPieceFRS.MoveNext();
                }
                rstPieceFRS.Close();

                rstPieceFRS = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "CalculerPrixReel", ex);
            }
        }
        //Rempli le listview des distributeur pour une pièce choisie
        private void RemplirListViewFournisseur()
        {
            try
            {  /*Instruction: 119041*/
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstContact;
                ADODB.Recordset rstFRS;
                int X;
                ListViewItem itmFRS;
                string sDevise;
                int iNoClient;
                Color lColor;
                string sType;
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    sType = "E";
                }
                else
                {
                    sType = "M";
                }
                lvwFournisseur.Items.Clear();
                rstPieceFRS = new Recordset();
                if (m_bPieceInutile == true)
                {
                    CalculerPrixReel(lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_PIECE].Text.Trim());
                    rstPieceFRS.Open("SELECT PiecesFRS.*, Fournisseur.NomFournisseur FROM PiecesFRS INNER JOIN FOURNISSEUR ON PiecesFRS.IDFRS = Fournisseur.IDFRS WHERE PIECE = '" + Strings.Trim(Strings.Replace(lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_PIECE].Text, "'", "''")) + "' AND Type = '" + sType + "' ORDER BY PrixReel", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    if (m_bInventaire == true)
                    {
                        CalculerPrixReel(lvwInventaire.FocusedItem.Text.Trim());
                        rstPieceFRS.Open("SELECT PiecesFRS.*, FOURNISSEUR.NomFournisseur FROM PiecesFRS INNER JOIN FOURNISSEUR ON PiecesFRS.IDFRS = Fournisseur.IDFRS WHERE PIECE = '" + Strings.Trim(Strings.Replace(lvwInventaire.FocusedItem.Text, "'", "''")) + "' AND Type = '" + sType + "' ORDER BY PrixReel", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        if (m_bRecherchePiece == true)
                        {

                            CalculerPrixReel(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text.Trim());

                            rstPieceFRS.Open("SELECT PiecesFRS.*, FOURNISSEUR.NomFournisseur FROM PiecesFRS INNER JOIN FOURNISSEUR ON PiecesFRS.IDFRS = Fournisseur.IDFRS WHERE PIECE = '" + Strings.Trim(Strings.Replace(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text, "'", "''")) + "' AND Type = '" + sType + "' ORDER BY PrixReel", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            CalculerPrixReel(lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text.Trim());
                            rstPieceFRS.Open("SELECT PiecesFRS.*, FOURNISSEUR.NomFournisseur FROM PiecesFRS INNER JOIN FOURNISSEUR ON PiecesFRS.IDFRS = Fournisseur.IDFRS WHERE PIECE = '" + Strings.Trim(Strings.Replace(lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text, "'", "''")) + "' AND Type = '" + sType + "' ORDER BY PrixReel", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                    }
                }
                rstFRS = new Recordset();
                rstFRS.Open("SELECT IDFRS FROM Fournisseur WHERE NomFournisseur = 'FOURNI PAR LE CLIENT'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iNoClient = rstFRS.Fields["IDFRS"].Value;
                rstFRS.Close();
                rstFRS = default;
                while (!rstPieceFRS.EOF)
                {
                    if (rstPieceFRS.Fields["IDFRS"].Value == iNoClient)
                    {
                        rstPieceFRS.MoveNext();
                        if (rstPieceFRS.EOF)
                        {
                            break;
                        }
                    }
                    // ON change la couleur de l'enregistrement selON la devise monétaire.
                    // CAN = noir, USA ou ESP = bleu
                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "CAN")
                    {
                        sDevise = "CAN";
                        lColor = COLOR_ROSE;
                    }
                    else
                    {
                        if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "USA")
                        {
                            sDevise = "USA";
                            lColor = COLOR_BLEU;
                        }
                        else
                        {
                            sDevise = "SPA";
                            lColor = COLOR_BLEU;
                        }
                    }

                    itmFRS = lvwFournisseur.Items.Add(string.Empty);
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE)
                    {
                        itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET)
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP)
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    itmFRS.Text = rstPieceFRS.Fields["NomFournisseur"].Value;
                    itmFRS.Tag = rstPieceFRS.Fields["IDFRS"].Value;
                    itmFRS.ForeColor = (lColor);
                    if (!string.IsNullOrEmpty(Strings.Trim(rstPieceFRS.Fields["PERS_RESS"].Value)))
                    {
                        rstContact = new Recordset();
                        rstContact.Open("SELECT NomContact FROM Contact WHERE IDContact = " + rstPieceFRS.Fields["PERS_RESS"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstContact.EOF)
                        {
                            if (itmFRS.SubItems.Count > I_COL_FRS_PERS_RESS)
                            {
                                itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text = rstContact.Fields["NomContact"].Value;
                            }
                            else
                            {
                                itmFRS.SubItems.Insert(I_COL_FRS_PERS_RESS, new ListViewItem.ListViewSubItem(null, rstContact.Fields["NomContact"].Value));
                            }
                            itmFRS.SubItems[I_COL_FRS_PERS_RESS].ForeColor = (lColor);
                        }
                        else
                        {
                            if (itmFRS.SubItems.Count > I_COL_FRS_PERS_RESS)
                            {
                                itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text = "";
                            }
                            else
                            {
                                itmFRS.SubItems.Insert(I_COL_FRS_PERS_RESS, new ListViewItem.ListViewSubItem(null, ""));
                            }
                        }
                        rstContact.Close();

                        rstContact = default;
                    }

                    if (!(rstPieceFRS.Fields["Date"].Value is DBNull))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_DATE)
                        {
                            itmFRS.SubItems[I_COL_FRS_DATE].Text = rstPieceFRS.Fields["Date"].Value;
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_DATE, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["Date"].Value));
                        }
                        itmFRS.SubItems[I_COL_FRS_DATE].ForeColor = (lColor);
                    }
                    else
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_DATE)
                        {
                            itmFRS.SubItems[I_COL_FRS_DATE].Text = string.Empty;
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_DATE, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                    }

                    if (!(rstPieceFRS.Fields["Entrer_Par"].Value is DBNull))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR)
                        {
                            itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = rstPieceFRS.Fields["Entrer_Par"].Value;
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["Entrer_Par"].Value));
                        }
                        itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].ForeColor = (lColor);
                    }
                    else
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR)
                        {
                            itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = string.Empty;
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                    }

                    if (!(rstPieceFRS.Fields["Valide"].Value is DBNull))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_VALIDE)
                        {
                            itmFRS.SubItems[I_COL_FRS_VALIDE].Text = rstPieceFRS.Fields["Valide"].Value;
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_VALIDE, new ListViewItem.ListViewSubItem(null, rstPieceFRS.Fields["Valide"].Value));
                        }
                        itmFRS.SubItems[I_COL_FRS_VALIDE].ForeColor = (lColor);
                    }
                    else
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_VALIDE)
                        {
                            itmFRS.SubItems[I_COL_FRS_VALIDE].Text = string.Empty;
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_VALIDE, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                    }
                    if (rstPieceFRS.Fields["PRIX_LIST"].Value != string.Empty)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = Math.Round(double.Parse($"{rstPieceFRS.Fields["PRIX_LIST"].Value}".Replace(".", ",")), 4).ToString();
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, (Math.Round(double.Parse($"{rstPieceFRS.Fields["PRIX_LIST"].Value}".Replace(".", ",")), 4).ToString())));
                        }
                        itmFRS.SubItems[I_COL_FRS_PRIX_LIST].ForeColor = (lColor);
                    }
                    if (rstPieceFRS.Fields["ESCOMPTE"].Value != string.Empty)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE)
                        {
                            itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = (double.Parse(Strings.Replace(Strings.Replace(rstPieceFRS.Fields["ESCOMPTE"].Value, "_", string.Empty), ".", ",")) * 100d);
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem(null, (double.Parse(Strings.Replace(Strings.Replace(rstPieceFRS.Fields["ESCOMPTE"].Value, "_", string.Empty), ".", ",")) * 100d)));
                        }
                        itmFRS.SubItems[I_COL_FRS_ESCOMPTE].ForeColor = (lColor);
                    }
                    if (rstPieceFRS.Fields["PRIX_NET"].Value != string.Empty)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET)
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = Math.Round(double.Parse($"{rstPieceFRS.Fields["PRIX_NET"].Value}".Replace(".", ",")), 4).ToString();
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse($"{rstPieceFRS.Fields["PRIX_NET"].Value}".Replace(".", ",")), 4).ToString()));
                        }
                        itmFRS.SubItems[I_COL_FRS_PRIX_NET].ForeColor = (lColor);
                    }
                    if (rstPieceFRS.Fields["PRIX_SP"].Value != string.Empty)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP)
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = Math.Round(double.Parse($"{rstPieceFRS.Fields["PRIX_SP"].Value}".Replace(".", ",")), 4).ToString();
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem(null, Math.Round(double.Parse($"{rstPieceFRS.Fields["PRIX_SP"].Value}".Replace(".", ",")), 4).ToString()));
                        }
                        itmFRS.SubItems[I_COL_FRS_PRIX_SP].ForeColor = (lColor);
                    }
                    if (rstPieceFRS.Fields["QUOTER"].Value == true)
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_QUOTER)
                        {
                            itmFRS.SubItems[I_COL_FRS_QUOTER].Text = "Oui";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_QUOTER, new ListViewItem.ListViewSubItem(null, "Oui"));
                        }
                    }
                    else
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_QUOTER)
                        {
                            itmFRS.SubItems[I_COL_FRS_QUOTER].Text = "Non";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_QUOTER, new ListViewItem.ListViewSubItem(null, "Non"));
                        }
                    }
                    itmFRS.SubItems[I_COL_FRS_QUOTER].ForeColor = (lColor);

                    if (string.IsNullOrEmpty(itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = " ";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " "));
                        }
                    }
                    if (rstPieceFRS.Fields["PRIX_NET"].Value != string.Empty)
                    {
                        if (rstPieceFRS.Fields["PRIX_LIST"].Value == "0,00" | rstPieceFRS.Fields["PRIX_LIST"].Value == "0")
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Tag = Strings.Replace(rstPieceFRS.Fields["PRIX_NET"].Value, ".", ",");
                        }
                        else
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Tag = Strings.Replace(rstPieceFRS.Fields["PRIX_LIST"].Value, ".", ",");
                        }
                    }
                    else
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Tag = Strings.Replace(rstPieceFRS.Fields["PRIX_SP"].Value, ".", ",");
                    }
                    if (string.IsNullOrEmpty(itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text))
                    {
                        if (itmFRS.SubItems.Count > I_COL_FRS_PERS_RESS)
                        {
                            itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text = " ";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_PERS_RESS, new ListViewItem.ListViewSubItem(null, " "));
                        }
                    }
                    itmFRS.SubItems[I_COL_FRS_PERS_RESS].Tag = sDevise;
                    rstPieceFRS.MoveNext();
                }
                rstPieceFRS.Close();

                rstPieceFRS = default;
                if (m_bPieceInutile == false)
                {
                    itmFRS = lvwFournisseur.Items.Add(string.Empty);
                    itmFRS.Text = "CHOISIR ULTÉRIEUREMENT";
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE)
                    {
                        itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET)
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP)
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem(null, " "));
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirListViewFournisseur", ex);
            }
        }
        //Rempli le listview des pièces à commander dans l'inventaire
        private void RemplirListViewInventaire()
        {
            try
            {  /*Instruction: 149141*/
                ADODB.Recordset rstInv;
                ListViewItem itmInv;
                int lStock;
                int lMinimum;
                lvwInventaire.Items.Clear();
                rstInv = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstInv.Open("SELECT * FROM InventaireElec WHERE Minimum = 1 ORDER BY NoItem", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstInv.Open("SELECT * FROM InventaireMec WHERE Minimum = 1 ORDER BY NoItem", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstInv.EOF)
                {
                    if (!(rstInv.Fields["QuantitéStock"].Value is DBNull))
                    {
                        lStock = Conversions.ToInteger(Strings.Replace(rstInv.Fields["QuantitéStock"].Value, ".", ","));
                    }
                    else
                    {
                        lStock = 0;
                    }
                    if (!(rstInv.Fields["QuantitéMinimum"].Value is DBNull))
                    {
                        lMinimum = rstInv.Fields["QuantitéMinimum"].Value;
                    }
                    else
                    {
                        lMinimum = 0;
                    }
                    if (lStock < lMinimum)
                    {

                        itmInv = lvwInventaire.Items.Add(string.Empty);

                        if (!(rstInv.Fields["NoItem"].Value is DBNull))
                        {
                            itmInv.Text = rstInv.Fields["NoItem"].Value;
                        }
                        else
                        {
                            itmInv.Text = string.Empty;
                        }

                        if (!(rstInv.Fields["Manufacturier"].Value is DBNull))
                        {
                            if (itmInv.SubItems.Count > I_COL_INV_MANUFACT)
                            {
                                itmInv.SubItems[I_COL_INV_MANUFACT].Text = rstInv.Fields["Manufacturier"].Value;
                            }
                            else
                            {
                                itmInv.SubItems.Insert(I_COL_INV_MANUFACT, new ListViewItem.ListViewSubItem(null, rstInv.Fields["Manufacturier"].Value));
                            }
                        }
                        else
                        {
                            if (itmInv.SubItems.Count > I_COL_INV_MANUFACT)
                            {
                                itmInv.SubItems[I_COL_INV_MANUFACT].Text = string.Empty;
                            }
                            else
                            {
                                itmInv.SubItems.Insert(I_COL_INV_MANUFACT, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }

                        if (!(rstInv.Fields["Description"].Value is DBNull))
                        {
                            if (itmInv.SubItems.Count > I_COL_INV_DESCR)
                            {
                                itmInv.SubItems[I_COL_INV_DESCR].Text = rstInv.Fields["Description"].Value;
                            }
                            else
                            {
                                itmInv.SubItems.Insert(I_COL_INV_DESCR, new ListViewItem.ListViewSubItem(null, rstInv.Fields["Description"].Value));
                            }
                        }
                        else
                        {
                            if (itmInv.SubItems.Count > I_COL_INV_DESCR)
                            {
                                itmInv.SubItems[I_COL_INV_DESCR].Text = string.Empty;
                            }
                            else
                            {
                                itmInv.SubItems.Insert(I_COL_INV_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }

                        if (!(rstInv.Fields["Commentaires"].Value is DBNull))
                        {
                            if (itmInv.SubItems.Count > I_COL_INV_COMMENT)
                            {
                                itmInv.SubItems[I_COL_INV_COMMENT].Text = rstInv.Fields["Commentaires"].Value;
                            }
                            else
                            {
                                itmInv.SubItems.Insert(I_COL_INV_COMMENT, new ListViewItem.ListViewSubItem(null, rstInv.Fields["Commentaires"].Value));
                            }
                        }
                        else
                        {
                            if (itmInv.SubItems.Count > I_COL_INV_COMMENT)
                            {
                                itmInv.SubItems[I_COL_INV_COMMENT].Text = "";
                            }
                            else
                            {
                                itmInv.SubItems.Insert(I_COL_INV_COMMENT, new ListViewItem.ListViewSubItem(null, ""));
                            }
                        }

                        if (itmInv.SubItems.Count > I_COL_INV_QTE_STOCK)
                        {
                            itmInv.SubItems[I_COL_INV_QTE_STOCK].Text = lStock.ToString();
                        }
                        else
                        {
                            itmInv.SubItems.Insert(I_COL_INV_QTE_STOCK, new ListViewItem.ListViewSubItem(null, lStock.ToString()));
                        }

                        if (itmInv.SubItems.Count > I_COL_INV_QTE_MINIMUM)
                        {
                            itmInv.SubItems[I_COL_INV_QTE_MINIMUM].Text = lMinimum.ToString();
                        }
                        else
                        {
                            itmInv.SubItems.Insert(I_COL_INV_QTE_MINIMUM, new ListViewItem.ListViewSubItem(null, lMinimum.ToString()));
                        }

                        if (!(rstInv.Fields["Commande"].Value is DBNull))
                        {
                            if (itmInv.SubItems.Count > I_COL_INV_QTE_COMMANDE)
                            {
                                itmInv.SubItems[I_COL_INV_QTE_COMMANDE].Text = rstInv.Fields["Commande"].Value;
                            }
                            else
                            {
                                itmInv.SubItems.Insert(I_COL_INV_QTE_COMMANDE, new ListViewItem.ListViewSubItem(null, rstInv.Fields["Commande"].Value));
                            }
                        }
                        else
                        {
                            if (itmInv.SubItems.Count > I_COL_INV_QTE_COMMANDE)
                            {
                                itmInv.SubItems[I_COL_INV_QTE_COMMANDE].Text = string.Empty;
                            }
                            else
                            {
                                itmInv.SubItems.Insert(I_COL_INV_QTE_COMMANDE, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }
                    }
                    rstInv.MoveNext();
                }
                rstInv.Close();
                rstInv = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirListViewInventaire", ex);
            }
        }
        //Rempli le listview des pièces selon la catégorie de pièce choisit
        private void RemplirListViewPieces()
        {
            try
            {  /*Instruction: 159259*/
                ADODB.Recordset rstPieces;
                var itmPieces = default(ListViewItem);
                int iIndex;
                bool bDebut;
                string sTri;
                string sCategorie;
                sTri = m_sTri;
                lvwPieces.Items.Clear();
                rstPieces = new Recordset();
                sCategorie = Strings.Replace(cmbCategorie.Text, "'", "''");
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstPieces.Open("SELECT * FROM CatalogueElec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY PIECE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstPieces.Open("SELECT * FROM CatalogueMec WHERE CATEGORIE = '" + sCategorie + "' ORDER BY PIECE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                     LogSQL(rstPieces.Source, System.Windows.Forms.Application.ProductName, "RemplirListViewPieces");
               iIndex = 1;
                Clipboard.SetText(rstPieces.Source);
                while (!rstPieces.EOF)
                {
                    if (rstPieces.Fields["PIECE"].Value != string.Empty & rstPieces.Fields["FABRICANT"].Value != string.Empty)
                    {

                        if (!string.IsNullOrEmpty(sTri))
                        {
                            bDebut = false;

                            switch (m_iCol)
                            {

                                case I_COL_PIECES_PIECE_GRB:
                                    {

                                        if ($"{rstPieces.Fields["PIECE_GRB"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {
                                            bDebut = true;
                                        }
                                        break;
                                    }
                                case I_COL_PIECES_NO_ITEM:
                                    {

                                        if ($"{rstPieces.Fields["PIECE"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {

                                            bDebut = true;
                                        }

                                        break;
                                    }
                                case I_COL_PIECES_MANUFACT:
                                    {

                                        if ($"{rstPieces.Fields["FABRICANT"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {

                                            bDebut = true;
                                        }

                                        break;
                                    }
                                case I_COL_PIECES_DESCR_FR:
                                    {

                                        if ($"{rstPieces.Fields["DESC_FR"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {

                                            bDebut = true;
                                        }

                                        break;
                                    }
                                case I_COL_PIECES_DESCR_EN:
                                    {

                                        if ($"{rstPieces.Fields["DESC_EN"].Value}".ToUpper().Contains(sTri.ToUpper()))
                                        {
                                            bDebut = true;
                                        }
                                        break;
                                    }
                            }
                            if (bDebut == true)
                            {
                                itmPieces = lvwPieces.Items.Insert(iIndex, "");
                                iIndex = (int)(iIndex + 1);
                            }
                            else
                            {
                                itmPieces = lvwPieces.Items.Add(string.Empty);
                            }
                        }
                        else
                        {
                            itmPieces = lvwPieces.Items.Add(string.Empty);
                        }

                        if (!(rstPieces.Fields["PIECE_GRB"].Value is DBNull))
                        {
                            itmPieces.Text = rstPieces.Fields["PIECE_GRB"].Value;
                        }
                        else
                        {
                            itmPieces.Text = string.Empty;
                        }

                        if (!(rstPieces.Fields["PIECE"].Value is DBNull))
                        {
                            if (itmPieces.SubItems.Count > I_COL_PIECES_NO_ITEM)
                            {
                                itmPieces.SubItems[I_COL_PIECES_NO_ITEM].Text = rstPieces.Fields["PIECE"].Value;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_PIECES_NO_ITEM, new ListViewItem.ListViewSubItem(null, rstPieces.Fields["PIECE"].Value));
                            }
                        }
                        else
                        {
                            if (itmPieces.SubItems.Count > I_COL_PIECES_NO_ITEM)
                            {
                                itmPieces.SubItems[I_COL_PIECES_NO_ITEM].Text = string.Empty;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_PIECES_NO_ITEM, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }

                        if (!(rstPieces.Fields["FABRICANT"].Value is DBNull))
                        {
                            if (itmPieces.SubItems.Count > I_COL_PIECES_MANUFACT)
                            {
                                itmPieces.SubItems[I_COL_PIECES_MANUFACT].Text = rstPieces.Fields["FABRICANT"].Value;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_PIECES_MANUFACT, new ListViewItem.ListViewSubItem(null, rstPieces.Fields["FABRICANT"].Value));
                            }
                        }
                        else
                        {
                            if (itmPieces.SubItems.Count > I_COL_PIECES_MANUFACT)
                            {
                                itmPieces.SubItems[I_COL_PIECES_MANUFACT].Text = string.Empty;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_PIECES_MANUFACT, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }

                        if (!(rstPieces.Fields["DESC_FR"].Value is DBNull))
                        {
                            if (itmPieces.SubItems.Count > I_COL_PIECES_DESCR_FR)
                            {
                                itmPieces.SubItems[I_COL_PIECES_DESCR_FR].Text = rstPieces.Fields["DESC_FR"].Value;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_PIECES_DESCR_FR, new ListViewItem.ListViewSubItem(null, rstPieces.Fields["DESC_FR"].Value));
                            }
                        }
                        else
                        {
                            if (itmPieces.SubItems.Count > I_COL_PIECES_DESCR_FR)
                            {
                                itmPieces.SubItems[I_COL_PIECES_DESCR_FR].Text = string.Empty;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_PIECES_DESCR_FR, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }
                        if (!(rstPieces.Fields["DESC_EN"].Value is DBNull))
                        {
                            if (itmPieces.SubItems.Count > I_COL_PIECES_DESCR_EN)
                            {
                                itmPieces.SubItems[I_COL_PIECES_DESCR_EN].Text = rstPieces.Fields["DESC_EN"].Value;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_PIECES_DESCR_EN, new ListViewItem.ListViewSubItem(null, rstPieces.Fields["DESC_EN"].Value));
                            }
                        }
                        else
                        {
                            if (itmPieces.SubItems.Count > I_COL_PIECES_DESCR_EN)
                            {
                                itmPieces.SubItems[I_COL_PIECES_DESCR_EN].Text = string.Empty;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_PIECES_DESCR_EN, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }
                    }

                    if (!(rstPieces.Fields["COMMENTAIRE"].Value is DBNull))
                    {
                        if (itmPieces.SubItems.Count > I_COL_PIECES_COMMENT)
                        {
                            itmPieces.SubItems[I_COL_PIECES_COMMENT].Text = rstPieces.Fields["COMMENTAIRE"].Value;
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_PIECES_COMMENT, new ListViewItem.ListViewSubItem(null, rstPieces.Fields["COMMENTAIRE"].Value));
                        }
                    }
                    else
                    {
                        if (itmPieces.SubItems.Count > I_COL_PIECES_COMMENT)
                        {
                            itmPieces.SubItems[I_COL_PIECES_COMMENT].Text = "";
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_PIECES_COMMENT, new ListViewItem.ListViewSubItem(null, ""));
                        }
                    }
                    rstPieces.MoveNext();
                }
                rstPieces.Close();
                rstPieces = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirListViewPieces", ex);
            }
        }
        //Remplis les pièces de l'ACHAT avec la BD
        private void RemplirListViewAchat()
        {
            try
            {
                ADODB.Recordset rstFRS;
                ListViewItem itmAchat;
                string sIDAchat;
                int iIndexAchat;
                Color lColor;
                bool bBold;
                lvwAchat.Items.Clear();
                sIDAchat = Gauche(txtNoAchat.Text, 9);
                iIndexAchat = int.Parse(Droite(txtNoAchat.Text, 3));
                ADODB.Recordset rstAchat = new ADODB.Recordset();
                rstAchat.Open("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                LogSQL($"SELECT * FROM Achat_Pieces WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat + " ORDER BY NuméroLigne", System.Windows.Forms.Application.ProductName,"RemplirListViewAchat" );
                while (!rstAchat.EOF)
                {
                    bBold = false;
                    if (rstAchat.Fields["Retour"].Value == true)
                    {
                        lColor = COLOR_ROUGE;
                    }
                    else
                    {
                        if (rstAchat.Fields["Recu"].Value == true)
                        {
                            lColor = COLOR_GRIS; // Gris
                        }
                        else
                        {
                            if (rstAchat.Fields["Inutile"].Value == true)
                            {
                                lColor = COLOR_BRUN;
                            }
                            else
                            {
                                if (rstAchat.Fields["IDFRS"].Value == 0)
                                {
                                    lColor = COLOR_MAGENTA;
                                }
                                else
                                {
                                    if (rstAchat.Fields["Commandé"].Value == true)
                                    {
                                        lColor = COLOR_ORANGE; // COLOR_ORANGE
                                    }
                                    else
                                    {
                                        if (rstAchat.Fields["CommandeAnnulée"].Value == true)
                                        {
                                            lColor = COLOR_VERT_FORET;
                                            bBold = true;
                                        }
                                        else
                                        {
                                            lColor = COLOR_ROSE;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    itmAchat = lvwAchat.Items.Add(string.Empty);

                    if (!(rstAchat.Fields["Qté"].Value is DBNull))
                    {
                        itmAchat.Text = rstAchat.Fields["Qté"].Value;
                    }
                    else
                    {
                        itmAchat.Text = string.Empty;
                    }
                    itmAchat.ForeColor = (lColor);
                    itmAchat.Tag = rstAchat.Fields["DateRéception"].Value;

                    if (!(rstAchat.Fields["PIECE"].Value is DBNull))
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PIECE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PIECE].Text = rstAchat.Fields["PIECE"].Value;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PIECE, new ListViewItem.ListViewSubItem(null, rstAchat.Fields["PIECE"].Value));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PIECE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PIECE].Text = string.Empty;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_PIECE].ForeColor = (lColor);

                    if (!(rstAchat.Fields["DESC_FR"].Value is DBNull))
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_DESCR)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_DESCR].Text = rstAchat.Fields["DESC_FR"].Value;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DESCR, new ListViewItem.ListViewSubItem(null, rstAchat.Fields["DESC_FR"].Value));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_DESCR)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_DESCR].Text = string.Empty;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_DESCR].ForeColor = (lColor);

                    if (!(rstAchat.Fields["Desc_EN"].Value is DBNull))
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DESCR].Tag = rstAchat.Fields["Desc_EN"].Value;
                    }
                    else
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DESCR].Tag = string.Empty;
                    }

                    if (!(rstAchat.Fields["Manufact"].Value is DBNull))
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_MANUFACT)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_MANUFACT].Text = rstAchat.Fields["Manufact"].Value;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_MANUFACT, new ListViewItem.ListViewSubItem(null, rstAchat.Fields["Manufact"].Value));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_MANUFACT)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_MANUFACT].Text = string.Empty;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_MANUFACT, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_MANUFACT].ForeColor = (lColor);
                    itmAchat.SubItems[I_COL_ACHAT_MANUFACT].Tag = rstAchat.Fields["NoRetour"].Value;
                    if (!string.IsNullOrEmpty(Strings.Trim(rstAchat.Fields["Prix_List"].Value)))
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (rstAchat.Fields["Prix_list"].Value);
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem(null, rstAchat.Fields["Prix_list"].Value));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = " ";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " "));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].ForeColor = (lColor);
                    itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Tag = rstAchat.Fields["PrixOrigine"].Value;
                    if (!string.IsNullOrEmpty(Strings.Trim(rstAchat.Fields["Escompte"].Value)))
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = (rstAchat.Fields["Escompte"].Value);
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem(null, (rstAchat.Fields["Escompte"].Value)));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = " ";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " "));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].ForeColor = (lColor);
                    if (!string.IsNullOrEmpty(Strings.Trim(rstAchat.Fields["Prix_net"].Value)))
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (rstAchat.Fields["Prix_net"].Value);
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem(null, (rstAchat.Fields["Prix_net"].Value)));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = " ";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem(null, " "));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].ForeColor = (lColor);
                    if (!(rstAchat.Fields["IDFRS"].Value is DBNull))
                    {
                        if (rstAchat.Fields["IDFRS"].Value != 0)
                        {
                            rstFRS = new Recordset();
                            rstFRS.Open("SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = " + rstAchat.Fields["IDFRS"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            LogSQL($"SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = " + rstAchat.Fields["IDFRS"].Value, System.Windows.Forms.Application.ProductName, "RemplirListViewAchat");
                            if (!rstFRS.EOF)
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_DISTRIB)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Text = rstFRS.Fields["NomFournisseur"].Value;
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, rstFRS.Fields["NomFournisseur"].Value));
                                }
                            }
                            else
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_DISTRIB)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Text = "";
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, ""));
                                }
                            }

                            itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Tag = rstAchat.Fields["IDFRS"].Value;
                            rstFRS.Close();
                            rstFRS = default;
                        }
                        else
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_DISTRIB)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Text = " ";
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, " "));
                            }
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_DISTRIB)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Text = string.Empty;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_DISTRIB].ForeColor = (lColor);
                    // Prix total
                    if (rstAchat.Fields["Prix_total"].Value != string.Empty)
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_TOTAL)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_TOTAL].Text = Math.Round(rstAchat.Fields["Prix_total"].Value, 2).ToString();
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_TOTAL, new ListViewItem.ListViewSubItem(null, (Math.Round(double.Parse(rstAchat.Fields["Prix_total"].Value), 2).ToString())));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_TOTAL)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_TOTAL].Text = " ";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_TOTAL, new ListViewItem.ListViewSubItem(null, " "));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_TOTAL].ForeColor = (lColor);
                    itmAchat.SubItems[I_COL_ACHAT_TOTAL].Tag = rstAchat.Fields["Devise"].Value;
                    if (rstAchat.Fields["DateCommande"].Value != string.Empty)
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_DATE_COMMANDE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_DATE_COMMANDE].Text = rstAchat.Fields["DateCommande"].Value;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, rstAchat.Fields["DateCommande"].Value));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_DATE_COMMANDE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_DATE_COMMANDE].Text = "";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, ""));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_DATE_COMMANDE].ForeColor = (lColor);
                    if (rstAchat.Fields["DateRequise"].Value != string.Empty)
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_DATE_REQUISE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_DATE_REQUISE].Text = rstAchat.Fields["DateRequise"].Value;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, rstAchat.Fields["DateRequise"].Value));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_DATE_REQUISE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_DATE_REQUISE].Text = "";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, ""));
                        }
                    }
                    itmAchat.SubItems[I_COL_ACHAT_DATE_REQUISE].ForeColor = (lColor);
                    rstAchat.MoveNext();
                }
                rstAchat.Close();
                rstAchat = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirListViewAchat", ex);
            }
        }
        private void lvwFournisseur_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 202898*/
                if (m_bPieceInutile == true)
                {
                    ChoisirFournisseurMateriel();
                }
                else
                {
                    ChoisirFournisseur();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwFournisseur_DblClick", ex);
            }
        }
        //On ajoute la pièce dans lvwAchat
        private void ChoisirFournisseur()
        {
            try
            {
                ADODB.Recordset rstConfig;
                string sTauxUSA;
                string sTauxSPA;
                string sQuantite;
                ListViewItem itmAchat;
                Color lColor;
                sQuantite = Interaction.InputBox("Quelle est la quantité?", DefaultResponse: m_sQuantite);
                sQuantite = Strings.Replace(sQuantite, ".", ",");
                rstConfig = new Recordset();
                rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM CONFIG", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                sTauxUSA = rstConfig.Fields["TauxAmericain"].Value;
                sTauxSPA = rstConfig.Fields["TauxEspagnol"].Value;
                rstConfig.Close();

                rstConfig = default;
                if (!string.IsNullOrEmpty(sQuantite))
                {
                    if (!IsNumeric(sQuantite))
                    {
                        MessageBox.Show("Quantité non numérique!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
                itmAchat = lvwAchat.Items.Add(string.Empty);
                if (lvwFournisseur.FocusedItem.Text == "CHOISIR ULTÉRIEUREMENT")
                {
                    lColor = COLOR_MAGENTA;
                }
                else
                {
                    lColor = COLOR_ROSE;
                }
                itmAchat.Text = sQuantite;
                itmAchat.ForeColor = (lColor);
                if (m_bRecherchePiece == true)
                {

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PIECE)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_PIECE].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_PIECE, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text));
                    }

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_DESCR)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DESCR].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_FR].Text));
                    }

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_MANUFACT)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_MANUFACT].Text = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text));
                    }

                    itmAchat.SubItems[I_COL_ACHAT_DESCR].Tag = lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_DESCR_EN].Text;
                }
                else
                {
                    if (m_bInventaire == true)
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PIECE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PIECE].Text = lvwInventaire.FocusedItem.Text;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PIECE, new ListViewItem.ListViewSubItem(null, lvwInventaire.FocusedItem.Text));
                        }
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_DESCR)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_DESCR].Text = lvwInventaire.FocusedItem.SubItems[I_COL_INV_DESCR].Text;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DESCR, new ListViewItem.ListViewSubItem(null, lvwInventaire.FocusedItem.SubItems[I_COL_INV_DESCR].Text));
                        }
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_MANUFACT)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_MANUFACT].Text = lvwInventaire.FocusedItem.SubItems[I_COL_INV_MANUFACT].Text;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwInventaire.FocusedItem.SubItems[I_COL_INV_MANUFACT].Text));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PIECE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PIECE].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PIECE, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text));
                        }
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_DESCR)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_DESCR].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DESCR, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_FR].Text));
                        }
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_MANUFACT)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_MANUFACT].Text = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text;
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_MANUFACT, new ListViewItem.ListViewSubItem(null, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text));
                        }
                        itmAchat.SubItems[I_COL_ACHAT_DESCR].Tag = lvwPieces.FocusedItem.SubItems[I_COL_PIECES_DESCR_EN].Text;
                    }
                }
                itmAchat.SubItems[I_COL_ACHAT_PIECE].ForeColor = (lColor);
                itmAchat.SubItems[I_COL_ACHAT_DESCR].ForeColor = (lColor);
                itmAchat.SubItems[I_COL_ACHAT_MANUFACT].ForeColor = (lColor);

                if (!string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text)))
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "USA", false)))
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text) / double.Parse(sTauxUSA), 4).ToString());
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text) / double.Parse(sTauxUSA), 4).ToString())));
                        }
                    }
                    else
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "SPA", false)))
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text) / double.Parse(sTauxSPA), 4).ToString());
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text) / double.Parse(sTauxSPA), 4).ToString())));
                            }
                        }
                        else
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text);
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Text)));
                            }
                        }
                    }
                }
                else
                {
                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = ("0");
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, ("0")));
                    }
                }
                itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Tag = lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_LIST].Tag;
                itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].ForeColor = (lColor);
                if (!string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text)))
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_ESCOMPTE].Text)))
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_ESCOMPTE].Text);
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_ESCOMPTE].Text)));
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = ("0");
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, ("0")));
                        }
                    }
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "USA", false)))
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text) / double.Parse(sTauxUSA), 4).ToString());
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text) / double.Parse(sTauxUSA), 4).ToString())));
                        }
                    }
                    else
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "SPA", false)))
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text) / double.Parse(sTauxSPA), 4).ToString());
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text) / double.Parse(sTauxSPA), 4).ToString())));
                            }
                        }
                        else
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text);
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_NET].Text)));
                            }
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text)))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "USA", false)))
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text) / double.Parse(sTauxUSA), 4).ToString());
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text) / double.Parse(sTauxUSA), 4).ToString())));
                            }
                        }
                        else
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PERS_RESS].Tag, "SPA", false)))
                            {

                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text) / double.Parse(sTauxSPA), 4).ToString());
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text) / double.Parse(sTauxSPA), 4).ToString())));
                                }
                            }
                            else
                            {

                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text);
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text)));
                                }
                            }
                        }
                    }
                    else
                    {
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = ("0");
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, ("0")));
                        }
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = ("0");
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, ("0")));
                        }
                    }
                }
                itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].ForeColor = (lColor);
                itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].ForeColor = (lColor);
                if (lvwFournisseur.FocusedItem.Text == "CHOISIR ULTÉRIEUREMENT")
                {
                    if (itmAchat.SubItems.Count > I_COL_ACHAT_DISTRIB)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Text = " ";
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Tag = 0.ToString();
                }
                else
                {
                    if (itmAchat.SubItems.Count > I_COL_ACHAT_DISTRIB)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Text = lvwFournisseur.FocusedItem.Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, lvwFournisseur.FocusedItem.Text));
                    }
                    itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Tag = lvwFournisseur.FocusedItem.Tag;
                }
                itmAchat.SubItems[I_COL_ACHAT_DISTRIB].ForeColor = (lColor);
                // Prix total
                if (itmAchat.SubItems.Count > I_COL_ACHAT_TOTAL)
                {
                    itmAchat.SubItems[I_COL_ACHAT_TOTAL].Text = (Math.Round(double.Parse(itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text) * double.Parse(itmAchat.Text), 2).ToString());
                }
                else
                {
                    itmAchat.SubItems.Insert(I_COL_ACHAT_TOTAL, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text) * double.Parse(itmAchat.Text), 2).ToString())));
                }
                itmAchat.SubItems[I_COL_ACHAT_TOTAL].ForeColor = (lColor);
                CalculerPrix();
                fraFournisseur.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "ChoisirFournisseur", ex);
            }
        }
        //On ajoute la pièce en négatif dans le listview
        private void ChoisirFournisseurMateriel()
        {
            try
            {
                string sQuantite;
                ListViewItem itmAncien;
                ListViewItem itmNouveau;
                sQuantite = Interaction.InputBox("Quelle est la quantité?");
                sQuantite = Strings.Replace(sQuantite, ".", ",");
                if (!string.IsNullOrEmpty(sQuantite))
                {
                    if (!IsNumeric(sQuantite))
                    {
                        MessageBox.Show("Quantité non numérique!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
                if (double.Parse(sQuantite) <= double.Parse(lvwAchat.FocusedItem.Text))
                {
                    itmAncien = lvwAchat.FocusedItem;
                    itmNouveau = lvwAchat.Items.Insert(itmAncien.Index + 1, "");
                    itmNouveau.Checked = itmAncien.Checked;
                    itmNouveau.Text = "-" + sQuantite;

                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_PIECE)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_PIECE].Text = itmAncien.SubItems[I_COL_ACHAT_PIECE].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_PIECE, new ListViewItem.ListViewSubItem(null, itmAncien.SubItems[I_COL_ACHAT_PIECE].Text));
                    }

                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_DESCR)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_DESCR].Text = itmAncien.SubItems[I_COL_ACHAT_DESCR].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_DESCR, new ListViewItem.ListViewSubItem(null, itmAncien.SubItems[I_COL_ACHAT_DESCR].Text));
                    }

                    itmNouveau.SubItems[I_COL_ACHAT_DESCR].Tag = itmAncien.SubItems[I_COL_ACHAT_DESCR].Tag;

                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_MANUFACT)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_MANUFACT].Text = itmAncien.SubItems[I_COL_ACHAT_MANUFACT].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_MANUFACT, new ListViewItem.ListViewSubItem(null, itmAncien.SubItems[I_COL_ACHAT_MANUFACT].Text));
                    }

                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_PRIX_LIST].Text = itmAncien.SubItems[I_COL_ACHAT_PRIX_LIST].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem(null, itmAncien.SubItems[I_COL_ACHAT_PRIX_LIST].Text));
                    }

                    itmNouveau.SubItems[I_COL_ACHAT_PRIX_LIST].Tag = itmAncien.SubItems[I_COL_ACHAT_PRIX_LIST].Tag;

                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_ESCOMPTE].Text = itmAncien.SubItems[I_COL_ACHAT_ESCOMPTE].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem(null, itmAncien.SubItems[I_COL_ACHAT_ESCOMPTE].Text));
                    }

                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_PRIX_NET].Text = itmAncien.SubItems[I_COL_ACHAT_PRIX_NET].Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem(null, itmAncien.SubItems[I_COL_ACHAT_PRIX_NET].Text));
                    }

                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_DISTRIB)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_DISTRIB].Text = lvwFournisseur.FocusedItem.Text;
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, lvwFournisseur.FocusedItem.Text));
                    }
                    itmNouveau.SubItems[I_COL_ACHAT_DISTRIB].Tag = lvwFournisseur.FocusedItem.Tag;
                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_TOTAL)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_TOTAL].Text = (Math.Round(double.Parse(itmNouveau.Text) * double.Parse(itmNouveau.SubItems[I_COL_ACHAT_PRIX_NET].Text), 2).ToString());
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_TOTAL, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(itmNouveau.Text) * double.Parse(itmNouveau.SubItems[I_COL_ACHAT_PRIX_NET].Text), 2).ToString())));
                    }
                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_DATE_COMMANDE)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_DATE_COMMANDE].Text = " ";
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    if (itmNouveau.SubItems.Count > I_COL_ACHAT_DATE_REQUISE)
                    {
                        itmNouveau.SubItems[I_COL_ACHAT_DATE_REQUISE].Text = " ";
                    }
                    else
                    {
                        itmNouveau.SubItems.Insert(I_COL_ACHAT_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    itmNouveau.ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_DATE_COMMANDE].ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_DATE_REQUISE].ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_DESCR].ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_DISTRIB].ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_ESCOMPTE].ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_MANUFACT].ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_PIECE].ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_PRIX_LIST].ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_PRIX_NET].ForeColor = (COLOR_BRUN);
                    itmNouveau.SubItems[I_COL_ACHAT_TOTAL].ForeColor = (COLOR_BRUN);
                    CalculerPrix();
                    fraFournisseur.Visible = false;
                    m_bPieceInutile = false;
                    if (lvwAchat.Items.Count > 0)
                    {
                        lvwAchat.Items[1].Selected = true;
                    }
                }
                else
                {
                    MessageBox.Show("Quantité trop grande!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "ChoisirFournisseurMateriel", ex);
            }
        }
        private void CalculerPrix()
        {
            try
            {
                var dblTotal = default(double);
                int X;
                if (lvwAchat.Items.Count > 0)
                {
                    for (X = 0; X <lvwAchat.Items.Count ; X++)
                    {

                        dblTotal = dblTotal + double.Parse((lvwAchat.Items[X].SubItems[I_COL_ACHAT_TOTAL].Text));
                    }
                    txtPrixTotal.Text = (dblTotal.ToString());
                }
                else
                {
                    txtPrixTotal.Text = (0.ToString());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "CalculerPrix", ex);
            }
        }
        private void lvwFournisseur_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 258285*/
                fraFournisseur.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwFournisseur_LostFocus", ex);
            }
        }
        private void lvwPieces_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 258835*/
                m_bInventaire = false;
                m_bRecherchePiece = Conversions.ToBoolean(-Conversions.ToShort(false));

                AfficherListeFournisseurs();
                if (lvwFournisseur.Items.Count == 0)
                {
                    if (MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!" + "\n" + "Voulez-vous en ajouter?",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                        {
                            Form f = new CatalogueElec(cmbCategorie.Text, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text);
                            f.Icon = Conteneur.ActiveForm.Icon;
                            f.Show();
                        }
                        else
                        {
                            Form f = new CatalogueMec(cmbCategorie.Text, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_MANUFACT].Text, lvwPieces.FocusedItem.SubItems[I_COL_PIECES_NO_ITEM].Text);
                            f.Icon = Conteneur.ActiveForm.Icon;
                            f.Show();
                        }
                        Cursor.Current = Cursors.Default;
                        AfficherListeFournisseurs();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwPieces_DblClick", ex);
            }
        }
        private void lvwInventaire_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 261678*/
                m_bInventaire = true;
                m_bRecherchePiece = false;
                AfficherListeFournisseurs();
                if (lvwFournisseur.Items.Count == 1)
                {
                    if (MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!" + "\n" + "Voulez-vous en ajouter?",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                        {
                            Form f = new CatalogueElec(cmbCategorie.Text, lvwInventaire.FocusedItem.SubItems[I_COL_INV_MANUFACT].Text, lvwInventaire.FocusedItem.SubItems[I_COL_INV_NO_ITEM].Text);
                            f.Icon = Conteneur.ActiveForm.Icon;
                            f.Show();
                        }
                        else
                        {
                            Form f = new CatalogueMec(cmbCategorie.Text, lvwInventaire.FocusedItem.SubItems[I_COL_INV_MANUFACT].Text, lvwInventaire.FocusedItem.SubItems[I_COL_INV_NO_ITEM].Text);
                            f.Icon = Conteneur.ActiveForm.Icon;
                            f.Show();
                        }
                        Cursor.Current = Cursors.Default;

                        AfficherListeFournisseurs();
                    }
                }
                fraInventaire.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwInventaire_DblClick", ex);
            }
        }
        //Méthode qui sert à afficher la liste des fournisseurs//Affiche le frame seulement s'il y a des items dans le ListView
        private void AfficherListeFournisseurs()
        {
            try
            {  /*Instruction: 264452*/
                RemplirListViewFournisseur();
                if (m_bInventaire == true)
                {
                    m_sQuantite = lvwInventaire.FocusedItem.SubItems[I_COL_INV_QTE_COMMANDE].Text;
                }
                else
                {
                    m_sQuantite = string.Empty;
                }
                if (lvwFournisseur.Items.Count > 1)
                {
                    if (m_bRecherchePiece == true)
                    {
                        fraPieceTrouve.Visible = false;
                    }
                    fraFournisseur.Visible = true;
                    lvwFournisseur.Focus();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "AfficherListeFournisseurs", ex);
            }
        }
        private void lvwAchat_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (m_eMode == EnumMode.MODE_AJOUT_MODIF)
                {
                    if (lvwAchat.Items.Count > 0)
                    {

                        if (eventArgs.KeyCode == Keys.Delete)
                        {

                            lvwAchat.Items.RemoveAt(lvwAchat.FocusedItem.Index);
                        }
                        CalculerPrix();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwAchat_KeyDown", ex);
            }
        }
        private void cmdAnnulerPrix_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraPrixPiece.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdAnnulerPrix_Click", ex);
            }
        }
        private void cmdOKPrix_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstConfig;
                ListViewItem itmAchat = default(ListViewItem);
                ListViewItem itmAvant;
                bool bPrixSpecial;
                Color lColor;
                int X;
                string sQuantite;
                string sPiece;
                string sTauxUSA;
                string sTauxSPA;
                rstConfig = new Recordset();
                rstConfig.Open("SELECT TauxAmericain, TauxEspagnol FROM Config", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                sTauxUSA = rstConfig.Fields["TauxAmericain"].Value;
                sTauxSPA = rstConfig.Fields["TauxEspagnol"].Value;
                rstConfig.Close();

                rstConfig = default;
                if (m_bMauvaisPrix == false)
                {
                    if (cmbfrs.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vous devez choisir un fournisseur!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (string.IsNullOrEmpty(Strings.Trim(txtPrixList.Text)))
                {
                    if (string.IsNullOrEmpty(Strings.Trim(txtPrixSpecial.Text)))
                    {
                        MessageBox.Show("Vous devez remplir le prix listé!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (string.IsNullOrEmpty(Strings.Trim(txtPrixNet.Text)) & string.IsNullOrEmpty(Strings.Trim(txtPrixSpecial.Text)))
                {
                    MessageBox.Show("Vous devez choisir un prix!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(txtPrixNet.Text)))
                    {
                        bPrixSpecial = false;
                    }
                    else
                    {
                        bPrixSpecial = true;
                    }
                }
                if (m_bMauvaisPrix == true)
                {
                    sQuantite = Interaction.InputBox("Quelle est la quantité!");
                    if (!string.IsNullOrEmpty(sQuantite))
                    {
                        if (!IsNumeric(sQuantite))
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                    itmAvant = lvwAchat.Items[Conversions.ToShort(fraPrixPiece.Tag)];
                    itmAchat = lvwAchat.Items.Insert(Conversions.ToShort(fraPrixPiece.Tag) + 1, "");
                    lColor = (itmAvant.SubItems[I_COL_ACHAT_PIECE].ForeColor);
                    itmAchat.Checked = itmAvant.Checked;
                    itmAchat.Text = "-" + itmAvant.Text;

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PIECE)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_PIECE].Text = itmAvant.SubItems[I_COL_ACHAT_PIECE].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_PIECE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_PIECE].Text));
                    }

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_DESCR)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DESCR].Text = itmAvant.SubItems[I_COL_ACHAT_DESCR].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_DESCR, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_DESCR].Text));
                    }

                    itmAchat.SubItems[I_COL_ACHAT_DESCR].Tag = itmAvant.SubItems[I_COL_ACHAT_DESCR].Tag;

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_MANUFACT)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_MANUFACT].Text = itmAvant.SubItems[I_COL_ACHAT_MANUFACT].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_MANUFACT, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_MANUFACT].Text));
                    }

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = itmAvant.SubItems[I_COL_ACHAT_PRIX_LIST].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_PRIX_LIST].Text));
                    }

                    itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Tag = itmAvant.SubItems[I_COL_ACHAT_PRIX_LIST].Tag;

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = itmAvant.SubItems[I_COL_ACHAT_ESCOMPTE].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_ESCOMPTE].Text));
                    }

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = itmAvant.SubItems[I_COL_ACHAT_PRIX_NET].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_PRIX_NET].Text));
                    }

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_DISTRIB)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Text = itmAvant.SubItems[I_COL_ACHAT_DISTRIB].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_DISTRIB].Text));
                    }

                    itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Tag = itmAvant.SubItems[I_COL_ACHAT_DISTRIB].Tag;

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_TOTAL)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_TOTAL].Text = "-" + itmAvant.SubItems[I_COL_ACHAT_TOTAL].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_TOTAL, new ListViewItem.ListViewSubItem(null, "-" + itmAvant.SubItems[I_COL_ACHAT_TOTAL].Text));
                    }

                    itmAchat = lvwAchat.Items.Insert(Conversions.ToShort(fraPrixPiece.Tag) + 2, "");
                    itmAchat.Checked = itmAvant.Checked;
                    itmAchat.Text = sQuantite;
                    itmAchat.ForeColor = (lColor);

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PIECE)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_PIECE].Text = itmAvant.SubItems[I_COL_ACHAT_PIECE].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_PIECE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_PIECE].Text));
                    }
                    itmAchat.SubItems[I_COL_ACHAT_PIECE].ForeColor = (lColor);

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_DESCR)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DESCR].Text = itmAvant.SubItems[I_COL_ACHAT_DESCR].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_DESCR, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_DESCR].Text));
                    }

                    itmAchat.SubItems[I_COL_ACHAT_DESCR].Tag = itmAvant.SubItems[I_COL_ACHAT_DESCR].Tag;
                    itmAchat.SubItems[I_COL_ACHAT_DESCR].ForeColor = (lColor);

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_MANUFACT)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_MANUFACT].Text = itmAvant.SubItems[I_COL_ACHAT_MANUFACT].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_MANUFACT, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_MANUFACT].Text));
                    }
                    itmAchat.SubItems[I_COL_ACHAT_MANUFACT].ForeColor = (lColor);
                    if (bPrixSpecial == false)
                    {
                        if (optUSA.Checked == true)
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxUSA), 4).ToString());
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxUSA), 4).ToString())));
                            }
                        }
                        else
                        {
                            if (optSpain.Checked == true)
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxSPA), 4).ToString());
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxSPA), 4).ToString())));
                                }
                            }
                            else
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (txtPrixList.Text);
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (txtPrixList.Text)));
                                }
                            }
                        }
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Tag = txtPrixList.Text;
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].ForeColor = (lColor);

                        if (!string.IsNullOrEmpty(mskEscompte.Text))
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = (mskEscompte.Text);
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, (mskEscompte.Text)));
                            }
                        }
                        else
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = ("0");
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, ("0")));
                            }
                        }
                        itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].ForeColor = (lColor);

                        if (optUSA.Checked == true)
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxUSA), 4).ToString());
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxUSA), 4).ToString())));
                            }
                        }
                        else
                        {
                            if (optSpain.Checked == true)
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxSPA), 4).ToString());
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxSPA), 4).ToString())));
                                }
                            }
                            else
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (txtPrixNet.Text);
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (txtPrixNet.Text)));
                                }
                            }
                        }
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Tag = itmAvant.SubItems[I_COL_ACHAT_PRIX_NET].Tag;
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].ForeColor = (lColor);
                    }
                    else
                    {
                        if (optUSA.Checked == true)
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString());
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString())));
                            }
                        }
                        else
                        {
                            if (optSpain.Checked == true)
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString());
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString())));
                                }
                            }
                            else
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (txtPrixSpecial.Text);
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (txtPrixSpecial.Text)));
                                }
                            }
                        }
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Tag = txtPrixSpecial.Text;
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].ForeColor = (lColor);
                        if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = ("0");
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, ("0")));
                        }
                        itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].ForeColor = (lColor);
                        if (optUSA.Checked == true)
                        {
                            if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString());
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString())));
                            }
                        }
                        else
                        {
                            if (optSpain.Checked == true)
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString());
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString())));
                                }
                            }
                            else
                            {
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (txtPrixSpecial.Text);
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (txtPrixSpecial.Text)));
                                }
                            }
                        }
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Tag = itmAvant.SubItems[I_COL_ACHAT_PRIX_NET].Tag;
                        itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].ForeColor = (lColor);
                    }

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_DISTRIB)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Text = itmAvant.SubItems[I_COL_ACHAT_DISTRIB].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_DISTRIB].Text));
                    }

                    itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Tag = itmAvant.SubItems[I_COL_ACHAT_DISTRIB].Tag;
                    itmAchat.SubItems[I_COL_ACHAT_DISTRIB].ForeColor = (lColor);

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_TOTAL)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_TOTAL].Text = (Math.Round(double.Parse(itmAchat.Text) * double.Parse(itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text), 2).ToString());
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_TOTAL, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(itmAchat.Text) * double.Parse(itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text), 2).ToString())));
                    }
                    itmAchat.SubItems[I_COL_ACHAT_TOTAL].ForeColor = (lColor);

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_DATE_COMMANDE)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DATE_COMMANDE].Text = itmAvant.SubItems[I_COL_ACHAT_DATE_COMMANDE].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_DATE_COMMANDE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_DATE_COMMANDE].Text));
                    }
                    itmAchat.SubItems[I_COL_ACHAT_DATE_COMMANDE].ForeColor = (lColor);

                    if (itmAchat.SubItems.Count > I_COL_ACHAT_DATE_REQUISE)
                    {
                        itmAchat.SubItems[I_COL_ACHAT_DATE_REQUISE].Text = itmAvant.SubItems[I_COL_ACHAT_DATE_REQUISE].Text;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_ACHAT_DATE_REQUISE, new ListViewItem.ListViewSubItem(null, itmAvant.SubItems[I_COL_ACHAT_DATE_REQUISE].Text));
                    }
                    itmAchat.SubItems[I_COL_ACHAT_DATE_REQUISE].ForeColor = (lColor);
                    if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_ACHAT_DATE_COMMANDE].Text))
                    {
                        itmAvant.SubItems[I_COL_ACHAT_DATE_COMMANDE].ForeColor = (COLOR_ROSE);
                    }
                    if (!string.IsNullOrEmpty(itmAvant.SubItems[I_COL_ACHAT_DATE_REQUISE].Text))
                    {
                        itmAvant.SubItems[I_COL_ACHAT_DATE_REQUISE].ForeColor = (COLOR_ROSE);
                    }
                    itmAvant.SubItems[I_COL_ACHAT_DESCR].ForeColor = (COLOR_ROSE);
                    itmAvant.SubItems[I_COL_ACHAT_DISTRIB].ForeColor = (COLOR_ROSE);
                    itmAvant.SubItems[I_COL_ACHAT_ESCOMPTE].ForeColor = (COLOR_ROSE);
                    itmAvant.SubItems[I_COL_ACHAT_MANUFACT].ForeColor = (COLOR_ROSE);
                    itmAvant.SubItems[I_COL_ACHAT_PIECE].ForeColor = (COLOR_ROSE);
                    itmAvant.SubItems[I_COL_ACHAT_PRIX_LIST].ForeColor = (COLOR_ROSE);
                    itmAvant.SubItems[I_COL_ACHAT_PRIX_NET].ForeColor = (COLOR_ROSE);
                    itmAvant.ForeColor = (COLOR_ROSE);
                    itmAvant.SubItems[I_COL_ACHAT_TOTAL].ForeColor = (COLOR_ROSE);
                    if (lvwAchat.Items.Count > 0)
                    {
                        lvwAchat.Items[1].Selected = true;
                    }
                    m_bMauvaisPrix = false;
                }
                else
                {
                    sPiece = lvwAchat.Items[(short)fraPrixPiece.Tag].SubItems[I_COL_ACHAT_PIECE].Text;
                    for (X = 1; X <lvwAchat.Items.Count; X++)
                    {
                        if ((lvwAchat.Items[X].SubItems[I_COL_ACHAT_PIECE].Text ?? "") == (sPiece ?? "") & (lvwAchat.Items[X].SubItems[I_COL_ACHAT_PIECE].ForeColor) == COLOR_MAGENTA)
                        {
                            itmAchat = lvwAchat.Items[X];
                            itmAchat.SubItems[I_COL_ACHAT_PIECE].ForeColor = (COLOR_ROSE);
                            itmAchat.SubItems[I_COL_ACHAT_DESCR].ForeColor = (COLOR_ROSE);
                            itmAchat.SubItems[I_COL_ACHAT_DISTRIB].ForeColor = (COLOR_ROSE);
                            itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].ForeColor = (COLOR_ROSE);
                            itmAchat.SubItems[I_COL_ACHAT_MANUFACT].ForeColor = (COLOR_ROSE);
                            itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].ForeColor = (COLOR_ROSE);
                            itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].ForeColor = (COLOR_ROSE);
                            itmAchat.SubItems[I_COL_ACHAT_TOTAL].ForeColor = (COLOR_ROSE);
                            itmAchat.ForeColor = (COLOR_ROSE);
                            lvwAchat.Refresh();
                            if (bPrixSpecial == false)
                            {

                                if (optUSA.Checked == true)
                                {
                                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                    {
                                        itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxUSA), 4).ToString());
                                    }
                                    else
                                    {
                                        itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxUSA), 4).ToString())));
                                    }
                                }
                                else
                                {
                                    if (optSpain.Checked == true)
                                    {

                                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                        {
                                            itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxSPA), 4).ToString());
                                        }
                                        else
                                        {
                                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixList.Text) / double.Parse(sTauxSPA), 4).ToString())));
                                        }
                                    }
                                    else
                                    {

                                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                        {
                                            itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (txtPrixList.Text);
                                        }
                                        else
                                        {
                                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (txtPrixList.Text)));
                                        }
                                    }
                                }
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Tag = txtPrixList.Text;

                                if (!string.IsNullOrEmpty(mskEscompte.Text))
                                {
                                    if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                                    {
                                        itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = (mskEscompte.Text);
                                    }
                                    else
                                    {
                                        itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, (mskEscompte.Text)));
                                    }
                                }
                                else
                                {
                                    if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                                    {
                                        itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = ("0");
                                    }
                                    else
                                    {
                                        itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, ("0")));
                                    }
                                }

                                if (optUSA.Checked == true)
                                {
                                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                    {
                                        itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxUSA), 4).ToString());
                                    }
                                    else
                                    {
                                        itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxUSA), 4).ToString())));
                                    }
                                }
                                else
                                {
                                    if (optSpain.Checked == true)
                                    {

                                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                        {
                                            itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxSPA), 4).ToString());
                                        }
                                        else
                                        {
                                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixNet.Text) / double.Parse(sTauxSPA), 4).ToString())));
                                        }
                                    }
                                    else
                                    {

                                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                        {
                                            itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (txtPrixNet.Text);
                                        }
                                        else
                                        {
                                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (txtPrixNet.Text)));
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (optUSA.Checked == true)
                                {
                                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                    {
                                        itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString());
                                    }
                                    else
                                    {
                                        itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString())));
                                    }
                                }
                                else
                                {
                                    if (optSpain.Checked == true)
                                    {

                                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                        {
                                            itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString());
                                        }
                                        else
                                        {
                                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString())));
                                        }
                                    }
                                    else
                                    {

                                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_LIST)
                                        {
                                            itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Text = (txtPrixSpecial.Text);
                                        }
                                        else
                                        {
                                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, (txtPrixSpecial.Text)));
                                        }
                                    }
                                }
                                itmAchat.SubItems[I_COL_ACHAT_PRIX_LIST].Tag = txtPrixSpecial.Text;
                                if (itmAchat.SubItems.Count > I_COL_ACHAT_ESCOMPTE)
                                {
                                    itmAchat.SubItems[I_COL_ACHAT_ESCOMPTE].Text = ("0");
                                }
                                else
                                {
                                    itmAchat.SubItems.Insert(I_COL_ACHAT_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, ("0")));
                                }
                                if (optUSA.Checked == true)
                                {
                                    if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                    {
                                        itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString());
                                    }
                                    else
                                    {
                                        itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxUSA), 4).ToString())));
                                    }
                                }
                                else
                                {
                                    if (optSpain.Checked == true)
                                    {

                                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                        {
                                            itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString());
                                        }
                                        else
                                        {
                                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(txtPrixSpecial.Text) / double.Parse(sTauxSPA), 4).ToString())));
                                        }
                                    }
                                    else
                                    {

                                        if (itmAchat.SubItems.Count > I_COL_ACHAT_PRIX_NET)
                                        {
                                            itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text = (txtPrixSpecial.Text);
                                        }
                                        else
                                        {
                                            itmAchat.SubItems.Insert(I_COL_ACHAT_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, (txtPrixSpecial.Text)));
                                        }
                                    }
                                }
                            }

                            if (itmAchat.SubItems.Count > I_COL_ACHAT_DISTRIB)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Text = cmbfrs.Items[cmbfrs.SelectedIndex].ToString();
                            }
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_DISTRIB, new ListViewItem.ListViewSubItem(null, (cmbfrs.Items[cmbfrs.SelectedIndex].ToString())));
                        }
                        itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Tag = cmbfrs.Items[cmbfrs.SelectedIndex].ToString();

                        if (itmAchat.SubItems.Count > I_COL_ACHAT_TOTAL)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_TOTAL].Text = (Math.Round(double.Parse(Strings.Replace(itmAchat.Text, "*", "")) * double.Parse(itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text), 2).ToString());
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_ACHAT_TOTAL, new ListViewItem.ListViewSubItem((ListViewItem)null, (Math.Round(double.Parse(Strings.Replace(itmAchat.Text, "*", "")) * double.Parse(itmAchat.SubItems[I_COL_ACHAT_PRIX_NET].Text), 2).ToString())));
                        }
                        if (optUSA.Checked == true)
                        {
                            itmAchat.SubItems[I_COL_ACHAT_TOTAL].Tag = "USA";
                        }
                        else
                        {
                            if (optSpain.Checked == true)
                            {
                                itmAchat.SubItems[I_COL_ACHAT_TOTAL].Tag = "SPA";
                            }
                            else
                            {
                                itmAchat.SubItems[I_COL_ACHAT_TOTAL].Tag = "CAN";
                            }
                        }
                    }
                }
                ModifierPrixCatalogue();
                fraPrixPiece.Visible = false;
                CalculerPrix();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdOKPrix_Click", ex);
            }
        }
        private void RemplirComboFournisseur()
        {
            try
            {
                ADODB.Recordset rstFRS;
                cmbfrs.Items.Clear();
                rstFRS = new Recordset();
                rstFRS.Open("SELECT PiecesFRS.*, FOURNISSEUR.NomFournisseur FROM PiecesFRS INNER JOIN Fournisseur ON PiecesFRS.IDFRS = Fournisseur.IDFRS WHERE PIECE = '" + lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_PIECE].Text.Replace("'", "''") + "' ORDER BY NomFournisseur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstFRS.EOF)
                {
                    cmbfrs.Items.Add(new ListItem($"{rstFRS.Fields["NomFournisseur"].Value}", $"{ rstFRS.Fields["IDFRS"].Value }"));
                    rstFRS.MoveNext();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirComboFournisseur", ex);
            }
        }
        public void mnuDateRequise_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (string.IsNullOrEmpty(Strings.Trim(lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_DATE_REQUISE].Text)))
                {
                    mvwDateRequise.SelectionStart = DateTime.Today;
                }
                else
                {
                    mvwDateRequise.SelectionStart = ConvertDateTexte(lvwAchat.FocusedItem.SubItems[I_COL_ACHAT_DATE_REQUISE].Text);
                }
                fraDateRequise.Top = lvwAchat.Top;
                fraDateRequise.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "mnuDateRequise_Click", ex);
            }
        }
        private void mvwDateRequise_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bMonthViewHasFocus = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "mvwDateRequise_GotFocus", ex);
            }
        }
        private void txtPrixList_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 341565*/
                if (!string.IsNullOrEmpty(txtPrixList.Text))
                {
                    txtPrixList.Text = Strings.Replace(txtPrixList.Text, ".", ",");
                    if (IsNumeric(txtPrixList.Text))
                    {
                        CalculerPrixNet();
                    }
                    else
                    {
                        MessageBox.Show("Valeur non numérique!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrixList.Text = string.Empty;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "txtPrixList_LostFocus", ex);
            }
        }
        //Quand le contenu du prix net change//Si la longueur du texte écrit est plus grand que 0      
        private void txtPrixNet_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 342781*/
                if (txtPrixNet.Text.Length>1)
                {
                    txtPrixSpecial.Text = string.Empty;
                    txtPrixSpecial.Enabled = false;
                }
                else
                {
                    txtPrixSpecial.Enabled = true;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "txtPrixNet_Change", ex);
            }
        }
        //Si le prix net prend le focus
        private void txtPrixNet_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerPrixNet();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "txtPrixNet_GotFocus", ex);
            }
        }
        private void txtPrixNet_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtPrixNet.Text = txtPrixNet.Text.Replace( ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "txtPrixNet_LostFocus", ex);
            }
        }
        private void CalculerPrixNet()
        {
            try
            {  /*Instruction: 344025*/
                double dblEscompte;
                double dblPrix;
                if (txtPrixNet.ReadOnly == false)
                {
                    mskEscompte.Text = mskEscompte.Text.Replace( "_", string.Empty);
                    mskEscompte.Text = mskEscompte.Text.Replace( "'", "''");
                    if (!string.IsNullOrEmpty(mskEscompte.Text))
                    {
                        dblEscompte = double.Parse(mskEscompte.Text);
                    }
                    else
                    {
                        dblEscompte = 0d;
                    }
                    if (!string.IsNullOrEmpty(txtPrixList.Text))
                    {
                        dblPrix = double.Parse(Strings.Replace(txtPrixList.Text, ".", ","));
                    }
                    else
                    {
                        dblPrix = 0d;
                    }
                    txtPrixNet.Text = Math.Round(dblPrix * (1d - dblEscompte), 4).ToString();
                    txtPrixNet.Text = txtPrixNet.Text.Replace( "'", "''");
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "CalculerPrixNet", ex);
            }
        }
        private void ViderChamps_frs()
        {
            try
            {
                txtPrixList.Text = string.Empty;
                mskEscompte.Text = string.Empty;
                txtPrixNet.Text = string.Empty;
                optCAN.Checked = true;
                AfficherDrapeau();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "ViderChamps_frs", ex);
            }
        }
        //Enregistrement du prix de la pièce
        private void ModifierPrixCatalogue()
        {
            try
            {  /*Instruction: 346654*/
                ADODB.Recordset rstPrix;
                double dblPrixList;
                double dblEscompte;
                double dblPrixNet;
                if (!string.IsNullOrEmpty(txtPrixList.Text.Trim()))
                {
                    dblPrixList = double.Parse(txtPrixList.Text);
                }
                else
                {
                    dblPrixList = 0d;
                }
                if (!string.IsNullOrEmpty(mskEscompte.Text))
                {
                    dblEscompte = double.Parse(mskEscompte.Text);
                }
                else
                {
                    dblEscompte = 0d;
                }
                if (!string.IsNullOrEmpty(txtPrixNet.Text.Trim()))
                {
                    dblPrixNet = double.Parse(txtPrixNet.Text);
                }
                else
                {
                    dblPrixNet = double.Parse(txtPrixSpecial.Text);
                }
                rstPrix = new Recordset();

                rstPrix.Open("SELECT * FROM PiecesFRS WHERE PIECE = '" + lvwAchat.Items[(short)fraPrixPiece.Tag].SubItems[I_COL_ACHAT_PIECE].Text.Replace( "'", "''") + "' AND IDFRS = " + GetFournisseurFromName(cmbfrs.Items[cmbfrs.SelectedIndex].ToString()), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstPrix.Fields["PRIX_LIST"].Value = dblPrixList;
                rstPrix.Fields["ESCOMPTE"].Value = dblEscompte;
                rstPrix.Fields["PRIX_NET"].Value = dblPrixNet;
                rstPrix.Fields["DATE"].Value = ConvertDate(DateTime.Today);
                rstPrix.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                if (optCAN.Checked == true)
                {
                    rstPrix.Fields["DeviseMonétaire"].Value = "CAN";
                }
                else
                {
                    if (optUSA.Checked == true)
                    {
                        rstPrix.Fields["DeviseMonétaire"].Value = "USA";
                    }
                    else
                    {
                        rstPrix.Fields["DeviseMonétaire"].Value = "SPA";
                    }
                }
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstPrix.Fields["Type"].Value = "E";
                }
                else
                {
                    rstPrix.Fields["Type"].Value = "M";
                }
                rstPrix.Update();
                rstPrix.Close();
                rstPrix = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "ModifierPrixCatalogue", ex);
            }
        }
        private void optCAN_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optCAN.Checked)
            {
                try
                {
                    AfficherDrapeau();
                    return;
                }
                catch (Exception ex)
                {
                    AfficherErreur(Name, "optCAN_Click", ex);
                }
            }
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
                }
                else
                {
                    if (optUSA.Checked == true)
                    {
                        imgEU.Visible = true;
                        imgCanada.Visible = false;
                        imgSpain.Visible = false;
                    }
                    else
                    {
                        imgSpain.Visible = true;
                        imgCanada.Visible = false;
                        imgEU.Visible = false;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "AfficherDrapeau", ex);
            }
        }

        private void optSpain_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optSpain.Checked)
            {
                try
                {
                    AfficherDrapeau();
                    return;
                }
                catch (Exception ex)
                {
                    AfficherErreur(Name, "optSpain_Click", ex);
                }
            }
        }
        private void optUSA_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optUSA.Checked)
            {
                try
                {
                    AfficherDrapeau();
                    return;
                }
                catch (Exception ex)
                {
                    AfficherErreur(Name, "optUSA_Click", ex);
                }
            }
        }
        //Quand le maskEdit prend le focus, on set le masque
        private void mskEscompte_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 352963*/
                if (mskEscompte.Enabled == true)
                {
                    mskEscompte.Mask = "0,####";
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "mskEscompte_GotFocus", ex);
            }
        }
        //Quand le maskEdit perd le focus, on enlève le mask        
        private void mskEscompte_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 353535*/
                mskEscompte.Mask = string.Empty;
                if (mskEscompte.Text == "0,____")
                {
                    mskEscompte.Text = string.Empty;
                }
                CalculerPrixNet();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "mskEscompte_LostFocus", ex);
            }
        }
        public void Commande()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstBCPiece;
                ADODB.Recordset rstBC;
                ADODB.Recordset rstFRS;
                var iIDFRS = default(int);
                string sFRS;
                string sNoBC;
                string sWhere;
                string sWherePiece;
                string sWhereNoLigne;
                var sDateRequise = default(string);
                string sNoLigne;
                bool bPremier;
                bool bPremierNoLigne;
                sFRS = ControleurServeur.ViewCommande.lblFournisseur.Text;
                sNoBC = ControleurServeur.ViewCommande.lblNoBC.Text;
                rstBC = new Recordset();
                rstFRS = new Recordset();
                rstPiece = new Recordset();
                rstBCPiece = new Recordset();
                rstBC.Open("SELECT * FROM BonsCommandes WHERE NoBonCommande = '" + sNoBC + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstBC.EOF)
                {
                    rstFRS.Open("SELECT IDFRS, NomFournisseur FROM Fournisseur WHERE IDFRS = " + rstBC.Fields["NoFournisseur"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstFRS.Fields["NomFournisseur"].Value == sFRS)
                    {
                        iIDFRS = rstFRS.Fields["IDFRS"].Value;
                        sDateRequise = rstBC.Fields["DateRequise"].Value;
                        rstFRS.Close();
                        break;
                    }
                    rstFRS.Close();
                    rstBC.MoveNext();
                }
                rstBC.Close();
                rstBC = default;
                rstFRS = default;

                rstBCPiece.Open("SELECT NoItem, NuméroLigne FROM BonsCommandes_Pieces WHERE NoFournisseur = " + iIDFRS + " AND NoBonCommande = '" + sNoBC + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sWhere = "(IDAchat = '" + Gauche(txtNoAchat.Text, 9) + "' AND IndexAchat = " + Conversion.Int(double.Parse(Droite(txtNoAchat.Text, 3))) + ")";
                sWherePiece = "PIECE In (";
                sWhereNoLigne = "NuméroLigne In (";
                bPremier = true;
                while (!rstBCPiece.EOF)
                {
                    if (!(rstBCPiece.Fields["NoItem"].Value is DBNull))
                    {
                        sNoLigne = rstBCPiece.Fields["NuméroLigne"].Value;
                        if (bPremier == true)
                        {
                            if (Strings.InStr(1, sNoLigne, ",") == 0)
                            {
                                sWherePiece+="'" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'";
                                sWhereNoLigne += rstBCPiece.Fields["NuméroLigne"].Value;
                            }
                            else
                            {
                                bPremierNoLigne = true;
                                while (Strings.InStr(1, sNoLigne, ",")== 0  )
                                {
                                    if (bPremierNoLigne == true)
                                    {
                                        sWherePiece+="'" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'";
                                        sWhereNoLigne += Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1);
                                        bPremierNoLigne = false;
                                    }
                                    else
                                    {
                                        sWherePiece+=", '" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'";
                                        sWhereNoLigne += ", " + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1);
                                    }
                                    sNoLigne = Droite(sNoLigne, Strings.Len(sNoLigne) - (Strings.InStr(1, sNoLigne, ",") + 1));
                                }
                                if (!string.IsNullOrEmpty(Strings.Trim(sNoLigne)))
                                {
                                    sWherePiece+=", '" + Strings.Replace(rstBCPiece.Fields["NoItem"].Value, "'", "''") + "'";
                                    sWhereNoLigne += ", " + sNoLigne;
                                }
                            }
                            bPremier = false;
                        }
                        else
                        {
                            if (Strings.InStr(1, sNoLigne, ",") == 0)
                            {
                                sWherePiece+=", '" + rstBCPiece.Fields["NoItem"].Value + "'";
                                sWhereNoLigne += ", " + rstBCPiece.Fields["NuméroLigne"].Value;
                            }
                            else
                            {
                                while (Strings.InStr(1, sNoLigne, ",") == 0)
                                {
                                    sWherePiece += ", '" + $"{rstBCPiece.Fields["NoItem"].Value}".Replace("'", "''") + "'";
                                    sWhereNoLigne+=", " + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1);
                                    sNoLigne = Droite(sNoLigne,sNoLigne.Length - (Strings.InStr(1, sNoLigne, ",") + 1));
                                }
                                if (!string.IsNullOrEmpty(sNoLigne.Trim()))
                                {
                                    sWherePiece+=", '" + $"{rstBCPiece.Fields["NoItem"].Value}".Replace( "'", "''") + "'";
                                    sWhereNoLigne += ", " + sNoLigne;
                                }
                            }
                        }
                    }
                    rstBCPiece.MoveNext();
                }
                sWherePiece+=")";
                sWhereNoLigne += ")";
                sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                rstBCPiece.Close();

                rstBCPiece = default;
                rstPiece.Open("SELECT * FROM Achat_Pieces WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPiece.EOF)
                {
                    rstPiece.Fields["Commandé"].Value = true;
                    rstPiece.Fields["DateCommande"].Value = ConvertDate(DateTime.Today);
                    rstPiece.Fields["DateRequise"].Value = sDateRequise;
                    rstPiece.Update();
                    rstPiece.MoveNext();
                }
                rstPiece.Close();
                rstPiece = default;
                RemplirListViewAchat();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "Commande", ex);
            }
        }
        private void cmdRetour_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 362143*/
                string sIDAchat;
                int iIndexAchat;
                ADODB.Recordset rstAchat;
                if (cmbNoAchat.Items.Count > 0)
                {
                    sIDAchat = Strings.Trim(Gauche(txtNoAchat.Text, Strings.InStr(1, txtNoAchat.Text, "-") + 2));
                    iIndexAchat = int.Parse(Droite(txtNoAchat.Text, txtNoAchat.Text.Length - Strings.InStrRev(txtNoAchat.Text, "-")).Trim());
                    rstAchat = new Recordset();
                    rstAchat.Open("SELECT Modification, Par FROM Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstAchat.Fields["Modification"].Value == false)
                    {
                        rstAchat.Close();
                        rstAchat = default;
                        Cursor.Current = Cursors.WaitCursor;
                        iIndexAchat = int.Parse(Droite(txtNoAchat.Text, 3));
                        Form f = new RetourMarchandise(sIDAchat, iIndexAchat, IdLoginEmploye);
                        f.Show();
                        cmbNoAchat_SelectedIndexChanged(cmbNoAchat, new EventArgs());
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Cet ACHAT est en modification par " + rstAchat.Fields["Par"].Value + "!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rstAchat.Close();
                        rstAchat = default;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdRetour_Click", ex);
            }
        }
        //Remplit ou vide les champs Modification et Par
        private void OuvrirAchat(bool bOuvrir)
        {
            try
            {  /*Instruction: 365100*/
                ADODB.Recordset rstAchat;
                string sIDAchat;
                int iIndexAchat;
                sIDAchat = Strings.Trim(Gauche(txtNoAchat.Text, Strings.InStr(1, txtNoAchat.Text, "-") + 2));
                iIndexAchat = int.Parse(Strings.Trim(Droite(txtNoAchat.Text, Strings.Len(txtNoAchat.Text) - Strings.InStrRev(txtNoAchat.Text, "-"))));
                rstAchat = new Recordset();
                rstAchat.CursorLocation = CursorLocationEnum.adUseServer;
                rstAchat.Open("SELECT Modification, Par FROM Achat WHERE IDAchat = '" + sIDAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstAchat.EOF)
                {
                    if (bOuvrir == true)
                    {
                        rstAchat.Fields["Modification"].Value = true;
                        rstAchat.Fields["Par"].Value = Conteneur.idInitiales.Text;
                    }
                    else
                    {
                        rstAchat.Fields["Modification"].Value = false;
                        rstAchat.Fields["Par"].Value = "";
                    }
                    rstAchat.Update();
                    rstAchat.MoveNext();
                }
                rstAchat.Close();
                rstAchat = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "OuvrirAchat", ex);
            }
        }
        private void lvwPieceTrouve_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 367093*/
                int X;
                m_bRecherchePiece = true;
                m_bInventaire = false;

                AfficherListeFournisseurs();
                if (lvwFournisseur.Items.Count == 1)
                {
                    if (MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!" + "\n" + "Voulez-vous en ajouter?",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                        {

                            Form f = new CatalogueElec(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_CATEGORIE].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text);
                        }
                        else
                        {

                            Form f = new CatalogueMec(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_CATEGORIE].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text);
                        }
                        Cursor.Current = Cursors.Default;

                        AfficherListeFournisseurs();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "lvwPieceTrouve_DblClick", ex);
            }
        }
        private void cmdOKPieceTrouve_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 370117*/
                m_bRecherchePiece = true;
                m_bInventaire = false;

                AfficherListeFournisseurs();
                if (lvwFournisseur.Items.Count == 1)
                {
                    if (MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!" + "\n" + "Voulez-vous en ajouter?",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                        {

                            Form f = new CatalogueElec(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_CATEGORIE].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text);
                            f.Icon = Conteneur.ActiveForm.Icon;
                            f.Show();
                        }
                        else
                        {

                            Form f = new CatalogueMec(lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_CATEGORIE].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_MANUFACT].Text, lvwPieceTrouve.FocusedItem.SubItems[I_COL_RECH_NO_ITEM].Text);
                            f.Icon = Conteneur.ActiveForm.Icon;
                            f.Show();
                        }
                        Cursor.Current = Cursors.Default;

                        AfficherListeFournisseurs();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdOKPieceTrouve_Click", ex);
            }
        }
        private void cmdAnnulerPieceTrouve_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 373118*/
                fraPieceTrouve.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdAnnulerPieceTrouve", ex);
            }
        }
        private void RemplirListViewRecherche(int iIndexColumn, string sTexte)
        {
            try
            {  /*Instruction: 373529*/
                ADODB.Recordset rstPiece;
                ListViewItem itmPiece;
                var X = default(int);
                var sChamps = default(string);
                var sRecherche = default(string);
                string sLettre = string.Empty;
                lvwPieceTrouve.Items.Clear();
                if (iIndexColumn == I_COL_PIECES_NO_ITEM)
                {
                    for (X = 1; X <= sTexte.Length; X++)
                    {
                        if (sLettre[X] >= 48 & sLettre[X] <= 57 | sLettre[X] >= 65 & sLettre[X] <= 90 | sLettre[X] >= 97 & sLettre[X] <= 122)
                        {
                            sRecherche = sRecherche + sLettre;
                        }
                    }
                }
                switch (iIndexColumn)
                {
                    case I_COL_PIECES_PIECE_GRB: { sChamps = "PIECE_GRB"; break; }
                    case I_COL_PIECES_NO_ITEM: { sChamps = "PIECE_MODIF"; break; }
                    case I_COL_PIECES_DESCR_EN: { sChamps = "DESC_EN"; break; }
                    case I_COL_PIECES_DESCR_FR: { sChamps = "DESC_FR"; break; }
                    case I_COL_PIECES_MANUFACT: { sChamps = "FABRICANT"; break; }
                }
                rstPiece = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    if (iIndexColumn == I_COL_PIECES_NO_ITEM)
                    {
                        rstPiece.Open("SELECT * FROM CatalogueElec WHERE " + sChamps + "like '%" + sRecherche + "%'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstPiece.Open("SELECT * FROM CatalogueElec WHERE " + sChamps + "like '%" + sRecherche + "%'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                }
                else
                {
                    if (iIndexColumn == I_COL_PIECES_NO_ITEM)
                    {
                        rstPiece.Open("SELECT * FROM CatalogueMec WHERE " + sChamps + "like '%" + sRecherche + "%'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstPiece.Open("SELECT * FROM CatalogueMec WHERE " + sChamps + "like '%" + sRecherche + "%'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                }
                while (!rstPiece.EOF)
                {

                    itmPiece = lvwPieceTrouve.Items.Add(string.Empty);
                    if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                    {
                        if (!(rstPiece.Fields["TEMPS"].Value is DBNull))
                        {
                            itmPiece.Tag = rstPiece.Fields["TEMPS"].Value;
                        }
                        else
                        {
                            itmPiece.Tag = string.Empty;
                        }
                    }
                    if (!(rstPiece.Fields["PIECE_GRB"].Value is DBNull))
                    {
                        itmPiece.Text = rstPiece.Fields["PIECE_GRB"].Value;
                    }
                    else
                    {
                        itmPiece.Text = "";
                    }
                    if (itmPiece.SubItems.Count > I_COL_RECH_NO_ITEM)
                    {
                        itmPiece.SubItems[I_COL_RECH_NO_ITEM].Text = rstPiece.Fields["PIECE"].Value;
                    }
                    else
                    {
                        itmPiece.SubItems.Insert(I_COL_RECH_NO_ITEM, new ListViewItem.ListViewSubItem(null, rstPiece.Fields["PIECE"].Value));
                    }
                    if (itmPiece.SubItems.Count > I_COL_RECH_CATEGORIE)
                    {
                        itmPiece.SubItems[I_COL_RECH_CATEGORIE].Text = cmbCategorie.Items[X].ToString();
                    }
                    else
                    {
                        itmPiece.SubItems.Insert(I_COL_RECH_CATEGORIE, new ListViewItem.ListViewSubItem(null, cmbCategorie.Items[X].ToString()));
                    }
                    if (!(rstPiece.Fields["FABRICANT"].Value is DBNull))
                    {
                        if (itmPiece.SubItems.Count > I_COL_RECH_MANUFACT)
                        {
                            itmPiece.SubItems[I_COL_RECH_MANUFACT].Text = rstPiece.Fields["FABRICANT"].Value;
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_RECH_MANUFACT, new ListViewItem.ListViewSubItem(null, rstPiece.Fields["FABRICANT"].Value));
                        }
                    }
                    else
                    {
                        if (itmPiece.SubItems.Count > I_COL_RECH_MANUFACT)
                        {
                            itmPiece.SubItems[I_COL_RECH_MANUFACT].Text = "";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_RECH_MANUFACT, new ListViewItem.ListViewSubItem(null, ""));
                        }
                    }
                    if (!(rstPiece.Fields["DESC_EN"].Value is DBNull))
                    {
                        if (itmPiece.SubItems.Count > I_COL_RECH_DESCR_EN)
                        {
                            itmPiece.SubItems[I_COL_RECH_DESCR_EN].Text = rstPiece.Fields["DESC_EN"].Value;
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_RECH_DESCR_EN, new ListViewItem.ListViewSubItem(null, rstPiece.Fields["DESC_EN"].Value));
                        }
                    }
                    else
                    {
                        if (itmPiece.SubItems.Count > I_COL_RECH_DESCR_EN)
                        {
                            itmPiece.SubItems[I_COL_RECH_DESCR_EN].Text = "";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_RECH_DESCR_EN, new ListViewItem.ListViewSubItem(null, ""));
                        }
                    }
                    if (!(rstPiece.Fields["DESC_FR"].Value is DBNull))
                    {
                        if (itmPiece.SubItems.Count > I_COL_RECH_DESCR_FR)
                        {
                            itmPiece.SubItems[I_COL_RECH_DESCR_FR].Text = rstPiece.Fields["DESC_FR"].Value;
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_RECH_DESCR_FR, new ListViewItem.ListViewSubItem(null, rstPiece.Fields["DESC_FR"].Value));
                        }
                    }
                    else
                    {
                        if (itmPiece.SubItems.Count > I_COL_RECH_DESCR_FR)
                        {
                            itmPiece.SubItems[I_COL_RECH_DESCR_FR].Text = "";
                        }
                        else
                        {
                            itmPiece.SubItems.Insert(I_COL_RECH_DESCR_FR, new ListViewItem.ListViewSubItem(null, ""));
                        }
                    }
                    rstPiece.MoveNext();
                }
                rstPiece.Close();
                rstPiece = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "RemplirListViewRecherche", ex);
            }
        }
        private void cmdMaterielInutile_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 383672*/
                ListViewItem itmAchat;
                if (lvwAchat.Items.Count > 0)
                {
                    itmAchat = lvwAchat.FocusedItem;
                    if (double.Parse(itmAchat.Text)== 0  )
                    {
                        m_bPieceInutile = true;
                        m_bRecherchePiece = false;
                        AfficherListeFournisseurs();
                        if (lvwFournisseur.Items.Count == 0)
                        {
                            MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            fraFournisseur.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La quantité est déjà dans le négatif!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdMaterielInutile_Click", ex);
            }
        }
        private void cmdMauvaisPrix_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 384945*/
                int X;
                ListViewItem itmAchat;
                if (lvwAchat.Items.Count > 0)
                {
                    itmAchat = lvwAchat.FocusedItem;
                    if (double.Parse(itmAchat.Text)== 0  )
                    {
                        ViderChamps_frs();
                        RemplirComboFournisseur();
                        for (X = 0; X <cmbfrs.Items.Count; X++)
                        {
                            if (cmbCategorie.Items[X].ToString() == itmAchat.SubItems[I_COL_ACHAT_DISTRIB].Tag)
                            {
                                cmbfrs.SelectedIndex = X;
                                break;
                            }
                        }
                        cmbfrs.Enabled = false;
                        fraPrixPiece.Tag = itmAchat.Index;
                        m_bMauvaisPrix = true;
                        fraPrixPiece.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("La quantité est déjà dans le négatif!",System.Windows.Forms.Application.ProductName+".GUI."+Name,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdMauvaisPrix_Click", ex);
            }
        }
        private void cmdReception_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                Form f = new Form();
                var bOuvert = default(bool);
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    f = new ReceptionElec(IdLoginEmploye, txtNoAchat.Text);
                    f.Icon = Conteneur.ActiveForm.Icon;
                    f.Show();
                    RemplirListViewAchat();
                }
                else
                {
                    f = new ReceptionMec(IdLoginEmploye, txtNoAchat.Text);
                    f.Icon = Conteneur.ActiveForm.Icon;
                    f.Show();
                }
                RemplirListViewAchat();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "cmdReception_Click", ex);
            }
        }
        private void txtPrixSpecial_TextChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 388642*/
                if (txtPrixSpecial.Text.Length > 0)
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
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "txtPrixSpecial_Change", ex);
            }
        }
        private void txtPrixSpecial_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {  /*Instruction: 389686*/
                txtPrixSpecial.Text = txtPrixSpecial.Text.Replace(".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur(Name, "txtPrixSpecial_LostFocus", ex);
            }
        }
    }
}
