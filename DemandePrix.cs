using System;
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
    public class DemandePrix : Form
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
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdNouveau = new System.Windows.Forms.Button();
            this.cmdCategorie = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdFournisseur = new System.Windows.Forms.Button();
            this.cmdPiece = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // cmdNouveau
            // 
            this.cmdNouveau.AutoSize = true;
            this.cmdNouveau.BackColor = System.Drawing.Color.Black;
            this.cmdNouveau.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNouveau.ForeColor = System.Drawing.Color.Navy;
            this.cmdNouveau.Location = new System.Drawing.Point(168, 248);
            this.cmdNouveau.Name = "cmdNouveau";
            this.cmdNouveau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdNouveau.Size = new System.Drawing.Size(103, 26);
            this.cmdNouveau.TabIndex = 10;
            this.cmdNouveau.Text = "Nouvelles pièces";
            this.cmdNouveau.UseVisualStyleBackColor = true;
            this.cmdNouveau.Click += new System.EventHandler(this.cmdNouveau_Click);
            // 
            // cmdCategorie
            // 
            this.cmdCategorie.AutoSize = true;
            this.cmdCategorie.BackColor = System.Drawing.Color.Black;
            this.cmdCategorie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCategorie.ForeColor = System.Drawing.Color.Navy;
            this.cmdCategorie.Location = new System.Drawing.Point(170, 181);
            this.cmdCategorie.Name = "cmdCategorie";
            this.cmdCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCategorie.Size = new System.Drawing.Size(97, 26);
            this.cmdCategorie.TabIndex = 8;
            this.cmdCategorie.Text = "Une catégorie";
            this.cmdCategorie.UseVisualStyleBackColor = true;
            this.cmdCategorie.Click += new System.EventHandler(this.cmdCategorie_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.AutoSize = true;
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.ForeColor = System.Drawing.Color.Navy;
            this.cmdAnnuler.Location = new System.Drawing.Point(293, 360);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(97, 26);
            this.cmdAnnuler.TabIndex = 11;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdFournisseur
            // 
            this.cmdFournisseur.AutoSize = true;
            this.cmdFournisseur.BackColor = System.Drawing.Color.Black;
            this.cmdFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFournisseur.ForeColor = System.Drawing.Color.Navy;
            this.cmdFournisseur.Location = new System.Drawing.Point(168, 216);
            this.cmdFournisseur.Name = "cmdFournisseur";
            this.cmdFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFournisseur.Size = new System.Drawing.Size(103, 26);
            this.cmdFournisseur.TabIndex = 9;
            this.cmdFournisseur.Text = "Toutes les pièces";
            this.cmdFournisseur.UseVisualStyleBackColor = true;
            this.cmdFournisseur.Click += new System.EventHandler(this.cmdFournisseur_Click);
            // 
            // cmdPiece
            // 
            this.cmdPiece.AutoSize = true;
            this.cmdPiece.BackColor = System.Drawing.Color.Black;
            this.cmdPiece.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPiece.ForeColor = System.Drawing.Color.Navy;
            this.cmdPiece.Location = new System.Drawing.Point(170, 146);
            this.cmdPiece.Name = "cmdPiece";
            this.cmdPiece.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdPiece.Size = new System.Drawing.Size(97, 26);
            this.cmdPiece.TabIndex = 7;
            this.cmdPiece.Text = "Une pièce";
            this.cmdPiece.UseVisualStyleBackColor = true;
            this.cmdPiece.Click += new System.EventHandler(this.cmdPiece_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(27, 70);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(353, 41);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Voulez-vous faire une demande de prix pour tous les pièces d\'un fournisseur, d\'un" +
    "e catégorie ou pour une pièce en particulier?";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DemandePrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 394);
            this.Controls.Add(this.cmdNouveau);
            this.Controls.Add(this.cmdCategorie);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdFournisseur);
            this.Controls.Add(this.cmdPiece);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DemandePrix";
            this.ShowInTaskbar = false;
            this.Text = "ContrôleurWebAutoGRB.DemandePrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal ToolTip ToolTip1;
        internal Button cmdNouveau;
        internal Button cmdCategorie;
        internal Button cmdAnnuler;
        internal Button cmdFournisseur;
        internal Button cmdPiece;
        internal Label Label1;
        private CatalogueMec catalogueMec;

        public DemandePrix()
        {
            InitializeComponent();
        }

        internal DemandePrix(CatalogueMec catalogueMec)
        {
            catalogueMec = catalogueMec;
        }

        private void cmdPiece_Click(object sender, EventArgs e)
        {
            try
            {
                m_eDemande = EnumModeDemande.MODE_PIECE;
                m_bDemandeAnnuler = false;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DemandePrix", "cmdPiece_Click", ex);
            }
        }
        private void cmdCategorie_Click(object sender, EventArgs e)
        {
            try
            {
                m_eDemande = EnumModeDemande.MODE_CATEGORIE;
                m_bDemandeAnnuler = false;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DemandePrix", "cmdCategorie_Click", ex);
            }
        }
        private void cmdFournisseur_Click(object sender, EventArgs e)
        {
            try
            {
                m_eDemande = EnumModeDemande.MODE_FOURNISSEUR;
                m_bDemandeAnnuler = false;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DemandePrix", "cmdFournisseur_Click", ex);
            }
        }
        private void cmdNouveau_Click(object sender, EventArgs e)
        {
            try
            {
                m_eDemande = EnumModeDemande.MODE_NOUVELLE;
                m_bDemandeAnnuler = false;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DemandePrix", "cmdNouveau_Click", ex);
            }
        }
        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            try
            {
                m_bDemandeAnnuler = true;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DemandePrix", "cmdAnnuler_Click", ex);
            }
        }
    }
}
