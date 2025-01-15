using ADODB;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public class ImpressionClient : Form
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
            toolTip4 = new System.Windows.Forms.ToolTip(components);
            cmbClient = new System.Windows.Forms.ComboBox();
            button4 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cmdRafraichir = new System.Windows.Forms.Button();
            cmdRecherche = new System.Windows.Forms.Button();
            txtRecherche = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            fraRecherche = new System.Windows.Forms.GroupBox();
            ChoixClient = new System.Windows.Forms.Panel();
            toolTip2 = new System.Windows.Forms.ToolTip(components);
            toolTip3 = new System.Windows.Forms.ToolTip(components);
            cmbCategorie = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            cmbVille = new System.Windows.Forms.ComboBox();
            cmdOK = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ChoixCategorie = new System.Windows.Forms.Panel();
            ChoixVille = new System.Windows.Forms.Panel();
            cmdFacturer = new System.Windows.Forms.Button();
            cmdPotentiel = new System.Windows.Forms.Button();
            cmdCategorie = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdTous = new System.Windows.Forms.Button();
            cmdVille = new System.Windows.Forms.Button();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            fraRecherche.SuspendLayout();
            ChoixClient.SuspendLayout();
            ChoixCategorie.SuspendLayout();
            ChoixVille.SuspendLayout();
            SuspendLayout();
            // 
            // toolTip4
            // 
            toolTip4.BackColor = System.Drawing.Color.Black;
            toolTip4.ForeColor = System.Drawing.Color.White;
            // 
            // cmbClient
            // 
            cmbClient.BackColor = System.Drawing.Color.Black;
            cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbClient.ForeColor = System.Drawing.Color.White;
            cmbClient.Location = new System.Drawing.Point(19, 30);
            cmbClient.Name = "cmbClient";
            cmbClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbClient.Size = new System.Drawing.Size(225, 22);
            cmbClient.Sorted = true;
            cmbClient.TabIndex = 11;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = System.Drawing.Color.Black;
            button4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.ForeColor = System.Drawing.Color.White;
            button4.Location = new System.Drawing.Point(444, 161);
            button4.Name = "button4";
            button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button4.Size = new System.Drawing.Size(67, 26);
            button4.TabIndex = 12;
            button4.Text = "Appliquer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_Click);
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Black;
            label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(19, 69);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label3.Size = new System.Drawing.Size(89, 17);
            label3.TabIndex = 13;
            label3.Text = "Description :";
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Black;
            label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(8, 7);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label4.Size = new System.Drawing.Size(89, 17);
            label4.TabIndex = 9;
            label4.Text = "Pour quel client ?";
            // 
            // cmdRafraichir
            // 
            cmdRafraichir.AutoSize = true;
            cmdRafraichir.BackColor = System.Drawing.Color.Black;
            cmdRafraichir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRafraichir.ForeColor = System.Drawing.Color.White;
            cmdRafraichir.Location = new System.Drawing.Point(113, 59);
            cmdRafraichir.Name = "cmdRafraichir";
            cmdRafraichir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRafraichir.Size = new System.Drawing.Size(74, 26);
            cmdRafraichir.TabIndex = 3;
            cmdRafraichir.Text = "Rafraichir";
            cmdRafraichir.UseVisualStyleBackColor = true;
            cmdRafraichir.Click += new System.EventHandler(cmdRafraichir_Click);
            // 
            // cmdRecherche
            // 
            cmdRecherche.AutoSize = true;
            cmdRecherche.BackColor = System.Drawing.Color.Black;
            cmdRecherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRecherche.ForeColor = System.Drawing.Color.White;
            cmdRecherche.Location = new System.Drawing.Point(36, 59);
            cmdRecherche.Name = "cmdRecherche";
            cmdRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRecherche.Size = new System.Drawing.Size(78, 26);
            cmdRecherche.TabIndex = 4;
            cmdRecherche.Text = "Rechercher";
            cmdRecherche.UseVisualStyleBackColor = true;
            cmdRecherche.Click += new System.EventHandler(cmdRecherche_Click);
            // 
            // txtRecherche
            // 
            txtRecherche.AcceptsReturn = true;
            txtRecherche.BackColor = System.Drawing.Color.Black;
            txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtRecherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtRecherche.ForeColor = System.Drawing.Color.White;
            txtRecherche.Location = new System.Drawing.Point(11, 24);
            txtRecherche.MaxLength = 0;
            txtRecherche.Name = "txtRecherche";
            txtRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtRecherche.Size = new System.Drawing.Size(171, 22);
            txtRecherche.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = true;
            txtDescription.BackColor = System.Drawing.Color.Black;
            txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDescription.ForeColor = System.Drawing.Color.White;
            txtDescription.Location = new System.Drawing.Point(19, 89);
            txtDescription.MaxLength = 0;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDescription.Size = new System.Drawing.Size(225, 80);
            txtDescription.TabIndex = 14;
            // 
            // fraRecherche
            // 
            fraRecherche.BackColor = System.Drawing.Color.Black;
            fraRecherche.Controls.Add(cmdRafraichir);
            fraRecherche.Controls.Add(cmdRecherche);
            fraRecherche.Controls.Add(txtRecherche);
            fraRecherche.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraRecherche.ForeColor = System.Drawing.Color.White;
            fraRecherche.Location = new System.Drawing.Point(315, 5);
            fraRecherche.Name = "fraRecherche";
            fraRecherche.Padding = new System.Windows.Forms.Padding(0);
            fraRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraRecherche.Size = new System.Drawing.Size(194, 90);
            fraRecherche.TabIndex = 10;
            fraRecherche.TabStop = false;
            fraRecherche.Text = "Recherche";
            // 
            // ChoixClient
            // 
            ChoixClient.BackColor = System.Drawing.Color.Black;
            ChoixClient.Controls.Add(txtDescription);
            ChoixClient.Controls.Add(fraRecherche);
            ChoixClient.Controls.Add(cmbClient);
            ChoixClient.Controls.Add(button4);
            ChoixClient.Controls.Add(label3);
            ChoixClient.Controls.Add(label4);
            ChoixClient.ForeColor = System.Drawing.Color.White;
            ChoixClient.Location = new System.Drawing.Point(0, 95);
            ChoixClient.Name = "ChoixClient";
            ChoixClient.Size = new System.Drawing.Size(543, 202);
            ChoixClient.TabIndex = 16;
            ChoixClient.Visible = false;
            // 
            // toolTip2
            // 
            toolTip2.BackColor = System.Drawing.Color.Black;
            toolTip2.ForeColor = System.Drawing.Color.White;
            // 
            // toolTip3
            // 
            toolTip3.BackColor = System.Drawing.Color.Black;
            toolTip3.ForeColor = System.Drawing.Color.White;
            // 
            // cmbCategorie
            // 
            cmbCategorie.BackColor = System.Drawing.Color.Black;
            cmbCategorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbCategorie.ForeColor = System.Drawing.Color.White;
            cmbCategorie.Location = new System.Drawing.Point(21, 52);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbCategorie.Size = new System.Drawing.Size(225, 22);
            cmbCategorie.TabIndex = 5;
            cmbCategorie.Text = "cmbCategorie";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = System.Drawing.Color.Black;
            button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(271, 52);
            button2.Name = "button2";
            button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button2.Size = new System.Drawing.Size(81, 26);
            button2.TabIndex = 7;
            button2.Text = "Sélectionner";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = System.Drawing.Color.Black;
            button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(352, 52);
            button3.Name = "button3";
            button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button3.Size = new System.Drawing.Size(81, 26);
            button3.TabIndex = 6;
            button3.Text = "Abandonner";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(18, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 14);
            label1.TabIndex = 0;
            label1.Text = "Choix catégorie du client";
            // 
            // cmbVille
            // 
            cmbVille.BackColor = System.Drawing.Color.Black;
            cmbVille.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbVille.ForeColor = System.Drawing.Color.White;
            cmbVille.Location = new System.Drawing.Point(18, 40);
            cmbVille.Name = "cmbVille";
            cmbVille.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbVille.Size = new System.Drawing.Size(225, 22);
            cmbVille.TabIndex = 4;
            cmbVille.Text = "cmbVille";
            // 
            // cmdOK
            // 
            cmdOK.AutoSize = true;
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(259, 40);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(81, 26);
            cmdOK.TabIndex = 6;
            cmdOK.Text = "Sélectionner";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = System.Drawing.Color.Black;
            button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(342, 40);
            button1.Name = "button1";
            button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button1.Size = new System.Drawing.Size(81, 26);
            button1.TabIndex = 5;
            button1.Text = "Abandonner";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(15, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 14);
            label2.TabIndex = 0;
            label2.Text = "Choix de la ville pour le tri";
            // 
            // ChoixCategorie
            // 
            ChoixCategorie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ChoixCategorie.BackColor = System.Drawing.Color.Black;
            ChoixCategorie.Controls.Add(cmbCategorie);
            ChoixCategorie.Controls.Add(button2);
            ChoixCategorie.Controls.Add(button3);
            ChoixCategorie.Controls.Add(label1);
            ChoixCategorie.ForeColor = System.Drawing.Color.White;
            ChoixCategorie.Location = new System.Drawing.Point(0, 297);
            ChoixCategorie.Name = "ChoixCategorie";
            ChoixCategorie.Size = new System.Drawing.Size(543, 96);
            ChoixCategorie.TabIndex = 17;
            ChoixCategorie.Visible = false;
            // 
            // ChoixVille
            // 
            ChoixVille.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ChoixVille.BackColor = System.Drawing.Color.Black;
            ChoixVille.Controls.Add(cmbVille);
            ChoixVille.Controls.Add(cmdOK);
            ChoixVille.Controls.Add(button1);
            ChoixVille.Controls.Add(label2);
            ChoixVille.ForeColor = System.Drawing.Color.White;
            ChoixVille.Location = new System.Drawing.Point(0, 393);
            ChoixVille.Name = "ChoixVille";
            ChoixVille.Size = new System.Drawing.Size(543, 80);
            ChoixVille.TabIndex = 15;
            ChoixVille.Visible = false;
            // 
            // cmdFacturer
            // 
            cmdFacturer.BackColor = System.Drawing.Color.Black;
            cmdFacturer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFacturer.ForeColor = System.Drawing.Color.White;
            cmdFacturer.Location = new System.Drawing.Point(312, 61);
            cmdFacturer.Name = "cmdFacturer";
            cmdFacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFacturer.Size = new System.Drawing.Size(97, 26);
            cmdFacturer.TabIndex = 14;
            cmdFacturer.Text = "Clients Facturés";
            cmdFacturer.UseVisualStyleBackColor = true;
            cmdFacturer.Click += new System.EventHandler(cmdFacturer_Click);
            // 
            // cmdPotentiel
            // 
            cmdPotentiel.BackColor = System.Drawing.Color.Black;
            cmdPotentiel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdPotentiel.ForeColor = System.Drawing.Color.White;
            cmdPotentiel.Location = new System.Drawing.Point(210, 61);
            cmdPotentiel.Name = "cmdPotentiel";
            cmdPotentiel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdPotentiel.Size = new System.Drawing.Size(100, 26);
            cmdPotentiel.TabIndex = 13;
            cmdPotentiel.Text = "Clients Potentiels";
            cmdPotentiel.UseVisualStyleBackColor = true;
            cmdPotentiel.Click += new System.EventHandler(cmdPotentiel_Click);
            // 
            // cmdCategorie
            // 
            cmdCategorie.BackColor = System.Drawing.Color.Black;
            cmdCategorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdCategorie.ForeColor = System.Drawing.Color.White;
            cmdCategorie.Location = new System.Drawing.Point(83, 61);
            cmdCategorie.Name = "cmdCategorie";
            cmdCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCategorie.Size = new System.Drawing.Size(125, 26);
            cmdCategorie.TabIndex = 10;
            cmdCategorie.Text = "CatégorieFournisseur";
            cmdCategorie.UseVisualStyleBackColor = true;
            cmdCategorie.Click += new System.EventHandler(cmdCategorie_Click);
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.Dock = System.Windows.Forms.DockStyle.Bottom;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(0, 511);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(556, 25);
            cmdAnnuler.TabIndex = 12;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // cmdTous
            // 
            cmdTous.BackColor = System.Drawing.Color.Black;
            cmdTous.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdTous.ForeColor = System.Drawing.Color.White;
            cmdTous.Location = new System.Drawing.Point(411, 61);
            cmdTous.Name = "cmdTous";
            cmdTous.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdTous.Size = new System.Drawing.Size(93, 26);
            cmdTous.TabIndex = 11;
            cmdTous.Text = "Tous les clients";
            cmdTous.UseVisualStyleBackColor = true;
            cmdTous.Click += new System.EventHandler(cmdTous_Click);
            // 
            // cmdVille
            // 
            cmdVille.BackColor = System.Drawing.Color.Black;
            cmdVille.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdVille.ForeColor = System.Drawing.Color.White;
            cmdVille.Location = new System.Drawing.Point(8, 61);
            cmdVille.Name = "cmdVille";
            cmdVille.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdVille.Size = new System.Drawing.Size(73, 26);
            cmdVille.TabIndex = 9;
            cmdVille.Text = "Ville";
            cmdVille.UseVisualStyleBackColor = true;
            cmdVille.Click += new System.EventHandler(cmdVille_Click);
            // 
            // ToolTip1
            // 
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // ImpressionClient
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(556, 536);
            Controls.Add(ChoixClient);
            Controls.Add(ChoixCategorie);
            Controls.Add(ChoixVille);
            Controls.Add(cmdFacturer);
            Controls.Add(cmdPotentiel);
            Controls.Add(cmdCategorie);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdTous);
            Controls.Add(cmdVille);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImpressionClient";
            ShowInTaskbar = false;
            Text = "ContrôleurWebAutoGRB.ImpressionClient";
            Load += new System.EventHandler(ImpressionClient_Load);
            fraRecherche.ResumeLayout(false);
            fraRecherche.PerformLayout();
            ChoixClient.ResumeLayout(false);
            ChoixClient.PerformLayout();
            ChoixCategorie.ResumeLayout(false);
            ChoixCategorie.PerformLayout();
            ChoixVille.ResumeLayout(false);
            ChoixVille.PerformLayout();
            ResumeLayout(false);

        }
        #endregion
        internal ToolTip toolTip4;
        internal ComboBox cmbClient;
        internal Button button4;
        internal Label label3;
        internal Label label4;
        internal Button cmdRafraichir;
        internal Button cmdRecherche;
        internal TextBox txtRecherche;
        internal TextBox txtDescription;
        internal GroupBox fraRecherche;
        internal Panel ChoixClient;
        internal ToolTip toolTip2;
        internal ToolTip toolTip3;
        internal ComboBox cmbCategorie;
        internal Button button2;
        internal Button button3;
        internal Label label1;
        internal ComboBox cmbVille;
        internal Button cmdOK;
        internal Button button1;
        internal Label label2;
        internal Panel ChoixCategorie;
        internal Panel ChoixVille;
        internal Button cmdFacturer;
        internal Button cmdPotentiel;
        internal Button cmdCategorie;
        internal Button cmdAnnuler;
        internal Button cmdTous;
        internal Button cmdVille;
        internal ToolTip ToolTip1;
        private EnumCatalogue m_eCatalogue;
        private void RemplirComboCategorie()
        {
            try
            {
                ADODB.Recordset rstCategorie = new ADODB.Recordset();
                cmbCategorie.Items.Clear();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstCategorie.Open("SELECT DISTINCT CATEGORIE FROM CatalogueElec ORDER BY CATEGORIE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstCategorie.Open("SELECT DISTINCT CATEGORIE FROM CatalogueMec ORDER BY CATEGORIE", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstCategorie.EOF)
                {
                    cmbCategorie.Items.Add(rstCategorie.Fields["CATEGORIE"].Value);
                    rstCategorie.MoveNext();
                }
                rstCategorie.Close();
                rstCategorie = null;
                if (cmbCategorie.Items.Count > 0)
                {
                    cmbCategorie.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCategorie", "RemplirComboCategorie", ex);
            }
        }
        private void RemplirComboVille()
        {
            try
            {
                ADODB.Recordset rstVille;
                cmbVille.Items.Clear();
                rstVille = new Recordset();
                rstVille.Open("SELECT DISTINCT VilleLiv FROM Client ORDER BY VilleLiv", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstVille.EOF)
                {
                    if (!(rstVille.Fields["VilleLiv"].Value is DBNull))
                    {
                        if (!string.IsNullOrEmpty((string)(rstVille.Fields["VilleLiv"].Value).Trim()))
                        {
                            cmbVille.Items.Add(rstVille.Fields["VilleLiv"].Value);
                        }
                    }
                    rstVille.MoveNext();
                }
                rstVille.Close();
                rstVille = null;
                if (cmbVille.Items.Count > 0)
                {
                    cmbVille.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixVille", "RemplirComboVille", ex);
            }
        }
        private void RemplirComboClient(string sRecherche)
        {
            try
            {
                ADODB.Recordset rstClient = new ADODB.Recordset();
                cmbClient.Items.Clear();
                if (string.IsNullOrEmpty(sRecherche.Trim()))
                {
                    rstClient.Open("SELECT NomClient, IDClient FROM Client WHERE Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else if (Strings.InStr(1, sRecherche, "'") > 0)
                {
                    rstClient.Open("SELECT NomClient, IDClient FROM Client WHERE NomClient LIKE '%" + sRecherche.Replace("'", "''") + "%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstClient.Open("SELECT NomClient, IDClient FROM Client WHERE NomClient like '%" + sRecherche + "%') > 0 AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                while (!rstClient.EOF)
                {
                    cmbClient.Items.Add(rstClient.Fields["NomClient"].Value);
                    cmbClient.Tag = rstClient.Fields["IDClient"].Value;
                    rstClient.MoveNext();
                }
                rstClient.Close();
                rstClient = null;
                if (cmbClient.Items.Count > 0)
                {
                    cmbClient.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixClient", "RemplirComboClient", ex);
            }
        }
        public ImpressionClient()
        {
            InitializeComponent();
        }
        private void cmdVille_Click(object sender, EventArgs e)
        {
            try
            {
                Client.m_bImpressionVille = true;
                Client.m_bImpressionAnnuler = false;
                Client.m_bImpressionCategorie = false;
                Client.m_bImpressionPotentiel = false;
                Client.m_bImpressionFacturer = false;
                ChoixVille.Visible = true;
                try
                {
                    RemplirComboVille();
                    return;
                }
                catch (Exception ex)
                {
                    AfficherErreur("ChoixVille", "Form_Load", ex);
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("dlgImpressionClient", "cmdVille_Click", ex);
            }
        }
        private void cmdCategorie_Click(object sender, EventArgs e)
        {
            try
            {
                Client.m_bImpressionCategorie = true;
                Client.m_bImpressionAnnuler = false;
                Client.m_bImpressionVille = false;
                Client.m_bImpressionPotentiel = false;
                Client.m_bImpressionFacturer = false;
                ChoixCategorie.Visible = true;
                try
                {
                    RemplirComboCategorie();
                    return;
                }
                catch (Exception ex)
                {
                    AfficherErreur("ChoixCategorie", "Form_Load", ex);
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("dlgImpressionClient", "cmdCategorie_Click", ex);
            }
        }
        private void cmdPotentiel_Click(object sender, EventArgs e)
        {
            try
            {
                Client.m_bImpressionVille = false;
                Client.m_bImpressionAnnuler = false;
                Client.m_bImpressionCategorie = false;
                Client.m_bImpressionPotentiel = true;
                Client.m_bImpressionFacturer = false;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("dlgImpressionClient", "cmdPotentielClick", ex);
            }
        }
        private void cmdFacturer_Click(object sender, EventArgs e)
        {
            try
            {
                Client.m_bImpressionVille = false;
                Client.m_bImpressionAnnuler = false;
                Client.m_bImpressionCategorie = false;
                Client.m_bImpressionPotentiel = false;
                Client.m_bImpressionFacturer = true;
                ChoixClient.Visible = true;
                try
                {
                    RemplirComboClient(string.Empty);
                    if (Facturation.m_bModifClient == true)
                    {
                        for (int X = 0; X <= (cmbClient.Items.Count - 1); X++)
                        {
                            if (cmbClient.Items[X].ToString() == Facturation.IDClient)
                            {
                                cmbClient.SelectedIndex = X;
                                break;
                            }
                        }
                        txtDescription.Text = Facturation.Description;
                    }
                    return;
                }
                catch (Exception ex)
                {
                    AfficherErreur("ChoixClient", "Form_Load", ex);
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("dlgImpressionClient", "cmdFacturer_Click", ex);
            }
        }
        private void cmdTous_Click(object sender, EventArgs e)
        {
            try
            {
                Client.m_bImpressionAnnuler = false;
                Client.m_bImpressionVille = false;
                Client.m_bImpressionCategorie = false;
                Client.m_bImpressionPotentiel = false;
                Client.m_bImpressionFacturer = false;
                Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("dlgImpressionClient", "cmdTous_Click", ex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    m_bAnnulerCopie = false;
                    m_sCategorieCopie = cmbCategorie.Text;
                }
                else
                {
                    m_bAnnulerCopie = false;
                    m_sCategorieCopie = cmbCategorie.Text;
                }
                ChoixCategorie.Visible = false;
                Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCategorie", "cmdOK_Click", ex);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    m_bAnnulerCopie = true;
                }
                else
                {
                    m_bAnnulerCopie = true;
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCategorie", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                Client.m_bAnnulerVille = false;
                Client.m_sVille = cmbVille.Text;
                button1_Click(sender, e);
                Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixVille", "cmdOK_Click", ex); return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Client.m_bAnnulerVille = true;
                Client.m_sVille = "";
                ChoixVille.Visible = false;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixVille", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                RemplirComboClient(txtRecherche.Text);
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixClient", "cmdRecherche_Click", ex);
            }
        }
        private void cmdRafraichir_Click(object sender, EventArgs e) => cmdRecherche_Click(sender, e);
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClient.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(txtDescription.Text)))
                    {
                        m_iIDClient = (int)GetClientID(cmbClient.Items[cmbClient.SelectedIndex].ToString());
                        m_sDescription = txtDescription.Text;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("La description est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Le client est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixClient", "cmdOK_Click", ex);
            }
        }
        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            try
            {
                Client.m_bImpressionAnnuler = true;
                Client.m_bImpressionCategorie = false;
                Client.m_bImpressionVille = false;
                Client.m_bImpressionPotentiel = false;
                Client.m_bImpressionFacturer = false;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("dlgImpressionClient", "cmdAnnuler_Click", ex);
            }
        }
        private void ImpressionClient_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName + "." + Name;
        }
    }
}