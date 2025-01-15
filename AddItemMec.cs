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
namespace ControleurServeur
{
    public  class AddItemMec : Form
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
            cmbcategorie = new System.Windows.Forms.ComboBox();
            cmdOk = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            txtNoItem = new System.Windows.Forms.TextBox();
            cmbFabricant = new System.Windows.Forms.ComboBox();
            lblStainless = new System.Windows.Forms.Label();
            lblAluminium = new System.Windows.Forms.Label();
            lblPlastique = new System.Windows.Forms.Label();
            lblAcier = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            lblTitre = new System.Windows.Forms.Label();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // cmbcategorie
            // 
            cmbcategorie.BackColor = System.Drawing.Color.White;
            cmbcategorie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbcategorie.ForeColor = System.Drawing.Color.Black;
            cmbcategorie.Location = new System.Drawing.Point(119, 202);
            cmbcategorie.Name = "cmbcategorie";
            cmbcategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbcategorie.Size = new System.Drawing.Size(265, 21);
            cmbcategorie.TabIndex = 14;
            cmbcategorie.SelectedIndexChanged += new System.EventHandler(cmbcategorie_SelectedIndexChanged);
            cmbcategorie.KeyUp += new System.Windows.Forms.KeyEventHandler(cmbcategorie_KeyUp);
            // 
            // cmdOk
            // 
            cmdOk.BackColor = System.Drawing.Color.Black;
            cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOk.ForeColor = System.Drawing.Color.White;
            cmdOk.Location = new System.Drawing.Point(303, 234);
            cmdOk.Name = "cmdOk";
            cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOk.Size = new System.Drawing.Size(81, 25);
            cmdOk.TabIndex = 17;
            cmdOk.Text = "OK";
            cmdOk.UseVisualStyleBackColor = true;
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(303, 266);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(81, 25);
            cmdAnnuler.TabIndex = 18;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtNoItem
            // 
            txtNoItem.AcceptsReturn = true;
            txtNoItem.BackColor = System.Drawing.Color.Black;
            txtNoItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoItem.ForeColor = System.Drawing.Color.White;
            txtNoItem.Location = new System.Drawing.Point(119, 234);
            txtNoItem.MaxLength = 0;
            txtNoItem.Name = "txtNoItem";
            txtNoItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoItem.Size = new System.Drawing.Size(161, 20);
            txtNoItem.TabIndex = 15;
            // 
            // cmbFabricant
            // 
            cmbFabricant.BackColor = System.Drawing.Color.White;
            cmbFabricant.ForeColor = System.Drawing.Color.Black;
            cmbFabricant.Location = new System.Drawing.Point(119, 266);
            cmbFabricant.Name = "cmbFabricant";
            cmbFabricant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbFabricant.Size = new System.Drawing.Size(161, 21);
            cmbFabricant.TabIndex = 16;
            // 
            // lblStainless
            // 
            lblStainless.BackColor = System.Drawing.Color.Black;
            lblStainless.ForeColor = System.Drawing.Color.White;
            lblStainless.Location = new System.Drawing.Point(167, 146);
            lblStainless.Name = "lblStainless";
            lblStainless.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblStainless.Size = new System.Drawing.Size(121, 17);
            lblStainless.TabIndex = 23;
            lblStainless.Text = "STAINLESS : ";
            // 
            // lblAluminium
            // 
            lblAluminium.BackColor = System.Drawing.Color.Black;
            lblAluminium.ForeColor = System.Drawing.Color.White;
            lblAluminium.Location = new System.Drawing.Point(167, 162);
            lblAluminium.Name = "lblAluminium";
            lblAluminium.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblAluminium.Size = new System.Drawing.Size(121, 17);
            lblAluminium.TabIndex = 24;
            lblAluminium.Text = "ALUMINIUM : ";
            // 
            // lblPlastique
            // 
            lblPlastique.BackColor = System.Drawing.Color.Black;
            lblPlastique.ForeColor = System.Drawing.Color.White;
            lblPlastique.Location = new System.Drawing.Point(167, 130);
            lblPlastique.Name = "lblPlastique";
            lblPlastique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPlastique.Size = new System.Drawing.Size(121, 17);
            lblPlastique.TabIndex = 22;
            lblPlastique.Text = "PLASTIQUE : ";
            // 
            // lblAcier
            // 
            lblAcier.BackColor = System.Drawing.Color.Black;
            lblAcier.ForeColor = System.Drawing.Color.White;
            lblAcier.Location = new System.Drawing.Point(167, 114);
            lblAcier.Name = "lblAcier";
            lblAcier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblAcier.Size = new System.Drawing.Size(121, 17);
            lblAcier.TabIndex = 21;
            lblAcier.Text = "ACIER : ";
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(47, 114);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(121, 17);
            Label1.TabIndex = 20;
            Label1.Text = "Prochain numéro pour :";
            // 
            // Label4
            // 
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(23, 202);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(97, 17);
            Label4.TabIndex = 25;
            Label4.Text = "CatégorieFournisseur :";
            // 
            // Label2
            // 
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(23, 234);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(97, 17);
            Label2.TabIndex = 26;
            Label2.Text = "Numero d\'item :";
            // 
            // Label3
            // 
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(23, 266);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(97, 17);
            Label3.TabIndex = 27;
            Label3.Text = "Manufacturier :";
            // 
            // lblTitre
            // 
            lblTitre.BackColor = System.Drawing.Color.Black;
            lblTitre.ForeColor = System.Drawing.Color.White;
            lblTitre.Location = new System.Drawing.Point(23, 66);
            lblTitre.Name = "lblTitre";
            lblTitre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTitre.Size = new System.Drawing.Size(361, 49);
            lblTitre.TabIndex = 19;
            lblTitre.Text = "Veuillez entrez la catégorie, un numero d\'item et ensuite un manufacturier (vous " +
    "pouvez en ajouter un qui ne figure pas déjà dans la liste)";
            // 
            // ToolTip1
            // 
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // AddItemMec
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(415, 312);
            Controls.Add(cmbcategorie);
            Controls.Add(cmdOk);
            Controls.Add(cmdAnnuler);
            Controls.Add(txtNoItem);
            Controls.Add(cmbFabricant);
            Controls.Add(lblStainless);
            Controls.Add(lblAluminium);
            Controls.Add(lblPlastique);
            Controls.Add(lblAcier);
            Controls.Add(Label1);
            Controls.Add(Label4);
            Controls.Add(Label2);
            Controls.Add(Label3);
            Controls.Add(lblTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "AddItemMec";
            ShowInTaskbar = false;
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
            Load += new System.EventHandler(AddItemMec_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static ComboBox cmbcategorie;
        internal static Button cmdOk;
        internal static Button cmdAnnuler;
        internal static TextBox txtNoItem;
        internal static ComboBox cmbFabricant;
        internal static Label lblStainless;
        internal static Label lblAluminium;
        internal static Label lblPlastique;
        internal static Label lblAcier;
        internal static Label Label1;
        internal static Label Label4;
        internal static Label Label2;
        internal static Label Label3;
        internal static Label lblTitre;
        internal static ToolTip ToolTip1;

        public AddItemMec()
        {
            InitializeComponent();
        }
        private void AddItemMec_Load(object sender, EventArgs e)
        {
            Icon = Conteneur.ActiveForm.Icon;
        }
        private void cmbcategorie_KeyUp(object sender, KeyEventArgs e)
        {
            int X;
            for (X = 0; X <cmbcategorie.Items.Count; X++)
            {
            
    
                if ((cmbcategorie.Items[ X].ToString().ToUpper() ?? "") == (cmbcategorie.Text.ToUpper() ?? ""))
                {
                    cmbcategorie.SelectedIndex = X;
                    break;
                }
            }
        }
        private void cmbcategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
