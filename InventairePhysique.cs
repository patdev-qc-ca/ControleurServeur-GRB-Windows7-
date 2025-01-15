using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public class InventairePhysique : Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ID_Elec = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_Meca = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAdd = new System.Windows.Forms.LinkLabel();
            this.cmdSupprimer = new System.Windows.Forms.LinkLabel();
            this.cmdModifier = new System.Windows.Forms.LinkLabel();
            this.cmdAppliquer = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.noItem = new System.Windows.Forms.TextBox();
            this.Commentaires = new System.Windows.Forms.TextBox();
            this.Manufacturier = new System.Windows.Forms.TextBox();
            this.Localisation = new System.Windows.Forms.TextBox();
            this.QteBoite = new System.Windows.Forms.TextBox();
            this.CommandeParBoite = new System.Windows.Forms.CheckBox();
            this.QuantitéStock = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_Elec,
            this.ID_Meca,
            this.fermerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ID_Elec
            // 
            this.ID_Elec.ForeColor = System.Drawing.Color.White;
            this.ID_Elec.Name = "ID_Elec";
            this.ID_Elec.Size = new System.Drawing.Size(71, 20);
            this.ID_Elec.Text = "Électrique";
            this.ID_Elec.Click += new System.EventHandler(this.ID_Elec_Click);
            // 
            // ID_Meca
            // 
            this.ID_Meca.ForeColor = System.Drawing.Color.White;
            this.ID_Meca.Name = "ID_Meca";
            this.ID_Meca.Size = new System.Drawing.Size(78, 20);
            this.ID_Meca.Text = "Mécanique";
            this.ID_Meca.Click += new System.EventHandler(this.ID_Meca_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.cmdAdd);
            this.panel1.Controls.Add(this.cmdSupprimer);
            this.panel1.Controls.Add(this.cmdModifier);
            this.panel1.Controls.Add(this.cmdAppliquer);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.noItem);
            this.panel1.Controls.Add(this.Commentaires);
            this.panel1.Controls.Add(this.Manufacturier);
            this.panel1.Controls.Add(this.Localisation);
            this.panel1.Controls.Add(this.QteBoite);
            this.panel1.Controls.Add(this.CommandeParBoite);
            this.panel1.Controls.Add(this.QuantitéStock);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 83);
            this.panel1.TabIndex = 2;
            // 
            // cmdAdd
            // 
            this.cmdAdd.AutoSize = true;
            this.cmdAdd.BackColor = System.Drawing.Color.Black;
            this.cmdAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.ForeColor = System.Drawing.Color.White;
            this.cmdAdd.LinkColor = System.Drawing.Color.White;
            this.cmdAdd.Location = new System.Drawing.Point(843, 59);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(47, 15);
            this.cmdAdd.TabIndex = 18;
            this.cmdAdd.TabStop = true;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cmdAdd_LinkClicked);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.AutoSize = true;
            this.cmdSupprimer.BackColor = System.Drawing.Color.Black;
            this.cmdSupprimer.Enabled = false;
            this.cmdSupprimer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupprimer.ForeColor = System.Drawing.Color.White;
            this.cmdSupprimer.LinkColor = System.Drawing.Color.White;
            this.cmdSupprimer.Location = new System.Drawing.Point(998, 59);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(64, 15);
            this.cmdSupprimer.TabIndex = 17;
            this.cmdSupprimer.TabStop = true;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cmdSupprimer_LinkClicked);
            // 
            // cmdModifier
            // 
            this.cmdModifier.AutoSize = true;
            this.cmdModifier.BackColor = System.Drawing.Color.Black;
            this.cmdModifier.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModifier.ForeColor = System.Drawing.Color.White;
            this.cmdModifier.LinkColor = System.Drawing.Color.White;
            this.cmdModifier.Location = new System.Drawing.Point(947, 59);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(54, 15);
            this.cmdModifier.TabIndex = 16;
            this.cmdModifier.TabStop = true;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cmdModifier_LinkClicked);
            // 
            // cmdAppliquer
            // 
            this.cmdAppliquer.AutoSize = true;
            this.cmdAppliquer.BackColor = System.Drawing.Color.Black;
            this.cmdAppliquer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAppliquer.ForeColor = System.Drawing.Color.White;
            this.cmdAppliquer.LinkColor = System.Drawing.Color.White;
            this.cmdAppliquer.Location = new System.Drawing.Point(889, 59);
            this.cmdAppliquer.Name = "cmdAppliquer";
            this.cmdAppliquer.Size = new System.Drawing.Size(61, 15);
            this.cmdAppliquer.TabIndex = 15;
            this.cmdAppliquer.TabStop = true;
            this.cmdAppliquer.Text = "Appliquer";
            this.cmdAppliquer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cmdAppliquer_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(431, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Commentaires";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(201, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantitée en stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(615, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Localisation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Manufacturier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(407, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantitée par boite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numéro d\'entrée";
            // 
            // noItem
            // 
            this.noItem.BackColor = System.Drawing.Color.Black;
            this.noItem.Enabled = false;
            this.noItem.ForeColor = System.Drawing.Color.White;
            this.noItem.Location = new System.Drawing.Point(95, 4);
            this.noItem.Name = "noItem";
            this.noItem.Size = new System.Drawing.Size(100, 22);
            this.noItem.TabIndex = 0;
            // 
            // Commentaires
            // 
            this.Commentaires.BackColor = System.Drawing.Color.Black;
            this.Commentaires.ForeColor = System.Drawing.Color.White;
            this.Commentaires.Location = new System.Drawing.Point(510, 34);
            this.Commentaires.Multiline = true;
            this.Commentaires.Name = "Commentaires";
            this.Commentaires.Size = new System.Drawing.Size(274, 38);
            this.Commentaires.TabIndex = 1;
            // 
            // Manufacturier
            // 
            this.Manufacturier.BackColor = System.Drawing.Color.Black;
            this.Manufacturier.ForeColor = System.Drawing.Color.White;
            this.Manufacturier.Location = new System.Drawing.Point(95, 56);
            this.Manufacturier.Name = "Manufacturier";
            this.Manufacturier.Size = new System.Drawing.Size(305, 22);
            this.Manufacturier.TabIndex = 2;
            // 
            // Localisation
            // 
            this.Localisation.BackColor = System.Drawing.Color.Black;
            this.Localisation.ForeColor = System.Drawing.Color.White;
            this.Localisation.Location = new System.Drawing.Point(684, 4);
            this.Localisation.Name = "Localisation";
            this.Localisation.Size = new System.Drawing.Size(100, 22);
            this.Localisation.TabIndex = 3;
            // 
            // QteBoite
            // 
            this.QteBoite.BackColor = System.Drawing.Color.Black;
            this.QteBoite.ForeColor = System.Drawing.Color.White;
            this.QteBoite.Location = new System.Drawing.Point(510, 4);
            this.QteBoite.Name = "QteBoite";
            this.QteBoite.Size = new System.Drawing.Size(100, 22);
            this.QteBoite.TabIndex = 4;
            // 
            // CommandeParBoite
            // 
            this.CommandeParBoite.AutoSize = true;
            this.CommandeParBoite.BackColor = System.Drawing.Color.Black;
            this.CommandeParBoite.ForeColor = System.Drawing.Color.White;
            this.CommandeParBoite.Location = new System.Drawing.Point(803, 6);
            this.CommandeParBoite.Name = "CommandeParBoite";
            this.CommandeParBoite.Size = new System.Drawing.Size(129, 18);
            this.CommandeParBoite.TabIndex = 5;
            this.CommandeParBoite.Text = "Commande par boite";
            this.CommandeParBoite.UseVisualStyleBackColor = true;
            // 
            // QuantitéStock
            // 
            this.QuantitéStock.BackColor = System.Drawing.Color.Black;
            this.QuantitéStock.ForeColor = System.Drawing.Color.White;
            this.QuantitéStock.Location = new System.Drawing.Point(300, 4);
            this.QuantitéStock.Name = "QuantitéStock";
            this.QuantitéStock.Size = new System.Drawing.Size(100, 22);
            this.QuantitéStock.TabIndex = 6;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Black;
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(4, 34);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 14);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(95, 31);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(305, 22);
            this.txtDescription.TabIndex = 8;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NoItem";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Manufacturier";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "QteBoites";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "QteStock";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ComParBoite";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Localisation";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Commentaire";
            this.columnHeader9.Width = 299;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1074, 518);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 518);
            this.panel2.TabIndex = 3;
            // 
            // InventairePhysique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1074, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "InventairePhysique";
            this.ShowInTaskbar = false;
            this.Text = "ControleurServeur.InventairePhysique";
            this.Load += new System.EventHandler(this.InventairePhysique_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal MenuStrip menuStrip1;
        internal ToolStripMenuItem ID_Elec;
        internal ToolStripMenuItem ID_Meca;
        internal ToolStripMenuItem fermerToolStripMenuItem;
        internal Panel panel1;
        internal TextBox noItem;
        internal TextBox Commentaires;
        internal TextBox Manufacturier;
        internal TextBox Localisation;
        internal TextBox QteBoite;
        internal CheckBox CommandeParBoite;
        internal TextBox QuantitéStock;
        internal Label lblDesc;
        internal TextBox txtDescription;
        internal LinkLabel cmdSupprimer;
        internal LinkLabel cmdModifier;
        internal LinkLabel cmdAppliquer;
        internal Label label6;
        internal Label label5;
        internal Label label4;
        internal Label label3;
        internal Label label2;
        internal Label label1;
        internal LinkLabel cmdAdd;
        internal ColumnHeader columnHeader1;
        internal ColumnHeader columnHeader2;
        internal ColumnHeader columnHeader3;
        internal ColumnHeader columnHeader4;
        internal ColumnHeader columnHeader5;
        internal ColumnHeader columnHeader6;
        internal ColumnHeader columnHeader7;
        internal ColumnHeader columnHeader8;
        internal ColumnHeader columnHeader9;
        internal ListView listView1;
        static string table = "";
        private Panel panel2;
        bool inventaireIntegral = false;
        public InventairePhysique()
        {
            InitializeComponent();
        }
        internal void UpdateTableau(object sender, EventArgs e)
        {
            if (table == "InventaireMec")
            {
                ID_Meca_Click(sender, e);
            }
            else
            {
                ID_Elec_Click(sender, e);
            }
        }
        private void InventairePhysique_Load(object sender, EventArgs e)
        {
            Icon = Conteneur.ActiveForm.Icon;
            if ((!g_bModificationInventaireElec) | (!g_bModificationInventaireMec))
            {
                cmdModifier.Enabled = false;
                noItem.Enabled = false;
                txtDescription.Enabled = false;
                Manufacturier.Enabled = false;
                CommandeParBoite.Enabled = false;
            }
            /// les droits admin bypass la restriction modif
            if (IdGroupe == 0x02)
            {
                cmdSupprimer.Enabled = true;
                cmdModifier.Enabled = true;
                noItem.Enabled = true;
                txtDescription.Enabled = true;
                Manufacturier.Enabled = true;
                CommandeParBoite.Enabled = true;
            }
            Icon = Conteneur.ActiveForm.Icon;
            listView1.ShowItemToolTips = true;
            listView1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            for (int a = 0; a < listView1.Columns.Count; a++)
            {
                listView1.Columns[a].TextAlign = HorizontalAlignment.Left;
            }
            if (MessageBox.Show("Voulez vous faire un inventaire physique intégral ?", Conteneur.ActiveForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                inventaireIntegral = true;
            }
        }
        internal void Enumerer(string table)
        {
            SqlConnection con = new SqlConnection(StringSQL);
            if (con.State == System.Data.ConnectionState.Closed) { con.Open(); }
            SqlDataReader reader = new SqlCommand($"SELECT * FROM {table}", con).ExecuteReader();
            if (inventaireIntegral == false) { listView1.Items.Clear(); }
            while (reader.Read())
            {
                ListViewItem itm = listView1.Items.Add(string.Empty);
                for (int a = 0; a < listView1.Columns.Count; a++)
                {
                    itm.SubItems.Insert(a, new ListViewItem.ListViewSubItem(null, string.Empty));
                }
                itm.Text = reader[1].ToString();
                itm.SubItems[1].Text = reader[2].ToString();
                itm.SubItems[2].Text = reader[3].ToString();
                itm.SubItems[3].Text = reader[4].ToString();
                itm.SubItems[4].Text = reader[11].ToString();
                if ((bool)reader[17] == true) { itm.SubItems[5].Text = "Oui"; } else { itm.SubItems[5].Text = "Non"; }
                itm.SubItems[6].Text = reader[0].ToString();
                itm.SubItems[7].Text = reader[9].ToString();
                itm.SubItems[8].Text = reader[8].ToString();
            }
            reader.Close();
            con.Close();
        }
        private void fermerToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void ID_Elec_Click(object sender, EventArgs e) => Enumerer("InventaireElec");
        private void ID_Meca_Click(object sender, EventArgs e) => Enumerer("InventaireMec");
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0) { return; }
            int pos = listView1.SelectedIndices[0];
            if (pos >= 0)
            {
                noItem.Text = listView1.Items[pos].Text;
                noItem.Tag = listView1.Items[pos].SubItems[6].Text;
                Commentaires.Text = listView1.Items[pos].SubItems[8].Text;
                Manufacturier.Text = listView1.Items[pos].SubItems[2].Text;
                Localisation.Text = listView1.Items[pos].SubItems[7].Text;
                QteBoite.Text = listView1.Items[pos].SubItems[3].Text;
                if (listView1.Items[pos].SubItems[5].Text == "Oui") { CommandeParBoite.Checked = true; } else { CommandeParBoite.Checked = false; }
                QuantitéStock.Text = listView1.Items[pos].SubItems[4].Text;
                txtDescription.Text = listView1.Items[pos].SubItems[1].Text;
            }
        }
        private void cmdAppliquer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recordset rd = new Recordset();
            ListViewItem it = listView1.FocusedItem;
            rd.Open($"SELECT * FROM {table} WHERE NOENREG={it.SubItems[6].Text}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                rd.Fields["NoItem"].Value = noItem.Text;
                rd.Fields["Description"].Value = txtDescription.Text;
                rd.Fields["Manufacturier"].Value = Manufacturier.Text;
                rd.Fields["QteBoite"].Value = QteBoite.Text;
                rd.Fields["Commentaires"].Value = Commentaires.Text;
                rd.Fields["Localisation"].Value = Localisation.Text;
                rd.Fields["DeviseMonétaire"].Value = "CAN";
                rd.Fields["QuantitéStock"].Value = QuantitéStock.Text;
                rd.Fields["Minimum"].Value = 0;//bool
                rd.Fields["CommandeParBoite"].Value = CommandeParBoite.Checked;//bool
                rd.Update();
            }
            rd.Close();
            rd = null;
            it.SubItems[1].Text =txtDescription.Text;
            it.SubItems[2].Text = Manufacturier.Text;
            it.SubItems[3].Text = QteBoite.Text;
            it.SubItems[4].Text = QuantitéStock.Text;
            if (CommandeParBoite.Checked == true) { it.SubItems[5].Text = "Oui"; } else { it.SubItems[5].Text = "Non"; }
            it.SubItems[7].Text = Localisation.Text;
            it.SubItems[8].Text = Commentaires.Text;
        }
        private void cmdAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int nvIndex = 1; /// pas zero 
            Recordset lasrd = new Recordset();
            lasrd.Open("SELECT TOP(1) NOENREG+1 FROM [DBO].[INVENTAIREELEC] WHERE NOENREG!='' ORDER BY NOENREG DESC\r\n", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!lasrd.EOF)
            {
                if (!(lasrd.Fields[0].Value is DBNull)) /// ca devrait pas arriver a moins d'une mauvaise sauvegarde de mémoire du a une coupre electrique
                {
                    nvIndex = int.Parse($"{lasrd.Fields[0].Value}");
                    lasrd.MoveNext();
                }
            }
            lasrd.Close();
            lasrd = null;
            Recordset rd = new Recordset();
            rd.Open($"SELECT * FROM {table}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!rd.EOF)
            {
                rd.AddNew();
                rd.Fields["NoEnreg"].Value = nvIndex;//int
                rd.Fields["NoItem"].Value =noItem.Text ;
                rd.Fields["Description"].Value = txtDescription.Text;
                rd.Fields["Manufacturier"].Value = Manufacturier.Text;
                rd.Fields["QteBoite"].Value = QteBoite.Text;
                rd.Fields["Prix Liste"].Value = string.Empty;
                rd.Fields["Escompte"].Value = string.Empty;
                rd.Fields["Prix net"].Value = string.Empty;
                rd.Fields["Commentaires"].Value = Commentaires.Text;
                rd.Fields["Localisation"].Value = Localisation.Text;
                rd.Fields["DeviseMonétaire"].Value = string.Empty;
                rd.Fields["QuantitéStock"].Value = QuantitéStock.Text;
                rd.Fields["QuantitéCommandée"].Value = string.Empty;
                rd.Fields["Minimum"].Value = 0;//bool
                rd.Fields["QuantitéMinimum"].Value = string.Empty;
                rd.Fields["Commande"].Value = string.Empty;
                rd.Fields["NoProjet"].Value = string.Empty;
                rd.Fields["CommandeParBoite"].Value = CommandeParBoite.Checked;//bool
                rd.Update();
            }
            rd.Close();
            rd = null;
        }
        private void cmdModifier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => cmdAppliquer_LinkClicked(sender, e);
        private void cmdSupprimer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0) { return; }
            int pos = listView1.SelectedIndices[0];
            if (pos >= 0)
            {
                if (listView1.Items[pos].Checked)
                {
                    if (MessageBox.Show($"La suppression sera definitive!!!\n\nVoulez vraiment supprimer la piece:\n{txtDescription.Text}\nIdentifiée comme {noItem.Text} localisée {Localisation.Text}", "Suppression à distance : Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        UpdateSQL($"DELETE FROM [DBO].{table} WHERE [NOENREG]='{listView1.Items[pos].SubItems[6].Text}'");
                        MessageBox.Show($"La référence "+ listView1.Items[pos].SubItems[6].Text + " a été supprimée");
                    }
                }
                else
                {
                    MessageBox.Show($"Administrateurs\n\n{IdNomEmploye} confirmez votre choix en cochant la case avant de cliquer supprimer", "Suppression à distance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
