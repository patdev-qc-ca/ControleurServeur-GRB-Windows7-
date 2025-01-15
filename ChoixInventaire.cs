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
    public  class ChoixInventaire : Form
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
            cmdFermer = new System.Windows.Forms.LinkLabel();
            cmdOutils = new System.Windows.Forms.LinkLabel();
            cmdElectrique = new System.Windows.Forms.LinkLabel();
            cmdMecanique = new System.Windows.Forms.LinkLabel();
            cmdSortie = new System.Windows.Forms.LinkLabel();
            cmdRetour = new System.Windows.Forms.LinkLabel();
            button1 = new System.Windows.Forms.LinkLabel();
            SuspendLayout();//cmdFermer
            cmdFermer.AutoSize = true;
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.White;
            cmdFermer.LinkColor = System.Drawing.Color.White;
            cmdFermer.Location = new System.Drawing.Point(216, 266);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(45, 15);
            cmdFermer.TabIndex = 11;
            cmdFermer.TabStop = true;
            cmdFermer.Text = "Fermer";//cmdOutils
            cmdOutils.BackColor = System.Drawing.Color.Black;
            cmdOutils.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOutils.ForeColor = System.Drawing.Color.White;
            cmdOutils.LinkColor = System.Drawing.Color.White;
            cmdOutils.Location = new System.Drawing.Point(71, 129);
            cmdOutils.Name = "cmdOutils";
            cmdOutils.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOutils.Size = new System.Drawing.Size(121, 25);
            cmdOutils.TabIndex = 8;
            cmdOutils.TabStop = true;
            cmdOutils.Text = "Outils";
            cmdOutils.Click += new System.EventHandler(cmdOutils_Click);//cmdElectrique
            cmdElectrique.BackColor = System.Drawing.Color.Black;
            cmdElectrique.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdElectrique.ForeColor = System.Drawing.Color.White;
            cmdElectrique.LinkColor = System.Drawing.Color.White;
            cmdElectrique.Location = new System.Drawing.Point(71, 79);
            cmdElectrique.Name = "cmdElectrique";
            cmdElectrique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdElectrique.Size = new System.Drawing.Size(121, 25);
            cmdElectrique.TabIndex = 6;
            cmdElectrique.TabStop = true;
            cmdElectrique.Text = "Électrique";
            cmdElectrique.Click += new System.EventHandler(cmdElectrique_Click);//cmdMecanique
            cmdMecanique.BackColor = System.Drawing.Color.Black;
            cmdMecanique.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdMecanique.ForeColor = System.Drawing.Color.White;
            cmdMecanique.LinkColor = System.Drawing.Color.White;
            cmdMecanique.Location = new System.Drawing.Point(71, 104);
            cmdMecanique.Name = "cmdMecanique";
            cmdMecanique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdMecanique.Size = new System.Drawing.Size(121, 25);
            cmdMecanique.TabIndex = 7;
            cmdMecanique.TabStop = true;
            cmdMecanique.Text = "Mécanique";
            cmdMecanique.Click += new System.EventHandler(cmdMecanique_Click);//cmdSortie
            cmdSortie.BackColor = System.Drawing.Color.Black;
            cmdSortie.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdSortie.ForeColor = System.Drawing.Color.White;
            cmdSortie.LinkColor = System.Drawing.Color.White;
            cmdSortie.Location = new System.Drawing.Point(71, 154);
            cmdSortie.Name = "cmdSortie";
            cmdSortie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSortie.Size = new System.Drawing.Size(121, 25);
            cmdSortie.TabIndex = 9;
            cmdSortie.TabStop = true;
            cmdSortie.Text = "Sortie de matériel";
            cmdSortie.Visible = false;
            cmdSortie.Click += new System.EventHandler(cmdSortie_Click);//cmdRetour
            cmdRetour.BackColor = System.Drawing.Color.Black;
            cmdRetour.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRetour.ForeColor = System.Drawing.Color.White;
            cmdRetour.LinkColor = System.Drawing.Color.White;
            cmdRetour.Location = new System.Drawing.Point(71, 179);
            cmdRetour.Name = "cmdRetour";
            cmdRetour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRetour.Size = new System.Drawing.Size(121, 25);
            cmdRetour.TabIndex = 10;
            cmdRetour.TabStop = true;
            cmdRetour.Text = "Retour de matériel";
            cmdRetour.Visible = false;
            cmdRetour.Click += new System.EventHandler(cmdRetour_Click);//button1
            button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.LinkColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(71, 204);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(121, 23);
            button1.TabIndex = 12;
            button1.TabStop = true;
            button1.Text = "Faire l\'inventaire";
            button1.Click += new System.EventHandler(button1_Click);//ChoixInventaire
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(270, 298);
            Controls.Add(button1);
            Controls.Add(cmdFermer);
            Controls.Add(cmdOutils);
            Controls.Add(cmdElectrique);
            Controls.Add(cmdMecanique);
            Controls.Add(cmdSortie);
            Controls.Add(cmdRetour);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ChoixInventaire";
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
            Load += new System.EventHandler(ChoixInventaire_Load);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        internal static System.Windows.Forms.LinkLabel cmdFermer;
        internal static System.Windows.Forms.LinkLabel cmdOutils;
        internal static System.Windows.Forms.LinkLabel cmdElectrique;
        internal static System.Windows.Forms.LinkLabel cmdMecanique;
        internal static System.Windows.Forms.LinkLabel cmdSortie;
        internal static System.Windows.Forms.LinkLabel cmdRetour;
        internal static System.Windows.Forms.LinkLabel button1;
        public ChoixInventaire()
        {
            InitializeComponent();
        }
        private void ChoixInventaire_Load(object sender, EventArgs e)
        {
            Icon = Conteneur.ActiveForm.Icon;
        }
        private void cmdElectrique_Click(object sender, EventArgs e)
        {
            Form f = new InventaireElec();
            f.Icon = Icon;
            f.MdiParent = Conteneur.ActiveForm.MdiParent;
            f.Show();
            button1_Click(sender, e);
        }
        private void cmdMecanique_Click(object sender, EventArgs e)
        {
            Form f = new InventaireMec();
            f.Icon = Icon;
            f.MdiParent = Conteneur.ActiveForm.MdiParent;
            f.Show();
            button1_Click(sender, e);
        }
        private void cmdOutils_Click(object sender, EventArgs e)
        {
            Form f = new outils();
            f.Icon = Icon;
            f.MdiParent = Conteneur.ActiveForm.MdiParent;
            f.Show();
            button1_Click(sender, e);
        }
        private void cmdSortie_Click(object sender, EventArgs e)
        {
            Form f = new SortieMateriel();
            f.Icon = Icon;
            f.MdiParent = Conteneur.ActiveForm.MdiParent;
            f.Show();
            button1_Click(sender, e);
        }
        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form f = new RetourMarchandise();
            f.Icon = Icon;
            f.MdiParent = Conteneur.ActiveForm.MdiParent;
            f.Show();
            button1_Click(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
