
using ADODB;
using Stripe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
namespace ControleurServeur
{
    public class ViewClients : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewClients));
            this.lblTitrePage = new System.Windows.Forms.Label();
            this.lblDateOuverture = new System.Windows.Forms.Label();
            this.lblTitreCommande = new System.Windows.Forms.Label();
            this.lblTitreNoSoum = new System.Windows.Forms.Label();
            this.lblNoSoum = new System.Windows.Forms.Label();
            this.lblTitreBC = new System.Windows.Forms.Label();
            this.lblNoBC = new System.Windows.Forms.Label();
            this.lblTitreContact = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblTitreTel = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lbltitredate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbltitredatereq = new System.Windows.Forms.Label();
            this.lblDateRequise = new System.Windows.Forms.Label();
            this.lblTitreFax = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblPiedPage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitreClient = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lbTitrelProjet = new System.Windows.Forms.Label();
            this.lblProjet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitrePage
            // 
            this.lblTitrePage.AutoSize = true;
            this.lblTitrePage.BackColor = System.Drawing.Color.White;
            this.lblTitrePage.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePage.Location = new System.Drawing.Point(26, 23);
            this.lblTitrePage.Name = "lblTitrePage";
            this.lblTitrePage.Size = new System.Drawing.Size(61, 26);
            this.lblTitrePage.TabIndex = 4;
            this.lblTitrePage.Text = "Client";
            // 
            // lblDateOuverture
            // 
            this.lblDateOuverture.AutoSize = true;
            this.lblDateOuverture.BackColor = System.Drawing.Color.White;
            this.lblDateOuverture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDateOuverture.Location = new System.Drawing.Point(144, 203);
            this.lblDateOuverture.Name = "lblDateOuverture";
            this.lblDateOuverture.Size = new System.Drawing.Size(81, 16);
            this.lblDateOuverture.TabIndex = 21;
            this.lblDateOuverture.Text = "8888-88-88";
            // 
            // lblTitreCommande
            // 
            this.lblTitreCommande.AutoSize = true;
            this.lblTitreCommande.BackColor = System.Drawing.Color.White;
            this.lblTitreCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreCommande.Location = new System.Drawing.Point(146, 161);
            this.lblTitreCommande.Name = "lblTitreCommande";
            this.lblTitreCommande.Size = new System.Drawing.Size(134, 16);
            this.lblTitreCommande.TabIndex = 22;
            this.lblTitreCommande.Text = "lblTitreCommande";
            // 
            // lblTitreNoSoum
            // 
            this.lblTitreNoSoum.AutoSize = true;
            this.lblTitreNoSoum.BackColor = System.Drawing.Color.White;
            this.lblTitreNoSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreNoSoum.Location = new System.Drawing.Point(23, 121);
            this.lblTitreNoSoum.Name = "lblTitreNoSoum";
            this.lblTitreNoSoum.Size = new System.Drawing.Size(115, 16);
            this.lblTitreNoSoum.TabIndex = 17;
            this.lblTitreNoSoum.Text = "lblTitreNoSoum";
            // 
            // lblNoSoum
            // 
            this.lblNoSoum.AutoSize = true;
            this.lblNoSoum.BackColor = System.Drawing.Color.White;
            this.lblNoSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNoSoum.Location = new System.Drawing.Point(146, 121);
            this.lblNoSoum.Name = "lblNoSoum";
            this.lblNoSoum.Size = new System.Drawing.Size(83, 16);
            this.lblNoSoum.TabIndex = 18;
            this.lblNoSoum.Text = "lblNoSoum";
            // 
            // lblTitreBC
            // 
            this.lblTitreBC.AutoSize = true;
            this.lblTitreBC.BackColor = System.Drawing.Color.White;
            this.lblTitreBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreBC.Location = new System.Drawing.Point(23, 140);
            this.lblTitreBC.Name = "lblTitreBC";
            this.lblTitreBC.Size = new System.Drawing.Size(76, 16);
            this.lblTitreBC.TabIndex = 19;
            this.lblTitreBC.Text = "lblTitreBC";
            // 
            // lblNoBC
            // 
            this.lblNoBC.AutoSize = true;
            this.lblNoBC.BackColor = System.Drawing.Color.White;
            this.lblNoBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNoBC.Location = new System.Drawing.Point(146, 140);
            this.lblNoBC.Name = "lblNoBC";
            this.lblNoBC.Size = new System.Drawing.Size(64, 16);
            this.lblNoBC.TabIndex = 24;
            this.lblNoBC.Text = "lblNoBC";
            // 
            // lblTitreContact
            // 
            this.lblTitreContact.AutoSize = true;
            this.lblTitreContact.BackColor = System.Drawing.Color.White;
            this.lblTitreContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreContact.Location = new System.Drawing.Point(23, 240);
            this.lblTitreContact.Name = "lblTitreContact";
            this.lblTitreContact.Size = new System.Drawing.Size(59, 16);
            this.lblTitreContact.TabIndex = 29;
            this.lblTitreContact.Text = "Contact";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.White;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblContact.Location = new System.Drawing.Point(87, 239);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(76, 16);
            this.lblContact.TabIndex = 30;
            this.lblContact.Text = "lblContact";
            // 
            // lblTitreTel
            // 
            this.lblTitreTel.AutoSize = true;
            this.lblTitreTel.BackColor = System.Drawing.Color.White;
            this.lblTitreTel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreTel.Location = new System.Drawing.Point(416, 259);
            this.lblTitreTel.Name = "lblTitreTel";
            this.lblTitreTel.Size = new System.Drawing.Size(25, 15);
            this.lblTitreTel.TabIndex = 31;
            this.lblTitreTel.Text = "Tél.";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.White;
            this.lblTel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTel.Location = new System.Drawing.Point(445, 259);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(35, 15);
            this.lblTel.TabIndex = 28;
            this.lblTel.Text = "lblTel";
            // 
            // lbltitredate
            // 
            this.lbltitredate.AutoSize = true;
            this.lbltitredate.BackColor = System.Drawing.Color.White;
            this.lbltitredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbltitredate.Location = new System.Drawing.Point(23, 203);
            this.lbltitredate.Name = "lbltitredate";
            this.lbltitredate.Size = new System.Drawing.Size(122, 16);
            this.lbltitredate.TabIndex = 25;
            this.lbltitredate.Text = "Date d\'ouverture";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(622, 121);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(102, 16);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "Date * lbldate";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltitredatereq
            // 
            this.lbltitredatereq.AutoSize = true;
            this.lbltitredatereq.BackColor = System.Drawing.Color.White;
            this.lbltitredatereq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbltitredatereq.Location = new System.Drawing.Point(232, 203);
            this.lbltitredatereq.Name = "lbltitredatereq";
            this.lbltitredatereq.Size = new System.Drawing.Size(96, 16);
            this.lbltitredatereq.TabIndex = 27;
            this.lbltitredatereq.Text = "Date requise";
            // 
            // lblDateRequise
            // 
            this.lblDateRequise.AutoSize = true;
            this.lblDateRequise.BackColor = System.Drawing.Color.White;
            this.lblDateRequise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDateRequise.Location = new System.Drawing.Point(329, 203);
            this.lblDateRequise.Name = "lblDateRequise";
            this.lblDateRequise.Size = new System.Drawing.Size(81, 16);
            this.lblDateRequise.TabIndex = 6;
            this.lblDateRequise.Text = "8888-88-88";
            // 
            // lblTitreFax
            // 
            this.lblTitreFax.AutoSize = true;
            this.lblTitreFax.BackColor = System.Drawing.Color.White;
            this.lblTitreFax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreFax.Location = new System.Drawing.Point(561, 259);
            this.lblTitreFax.Name = "lblTitreFax";
            this.lblTitreFax.Size = new System.Drawing.Size(25, 15);
            this.lblTitreFax.TabIndex = 7;
            this.lblTitreFax.Text = "Fax";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.BackColor = System.Drawing.Color.White;
            this.lblFax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFax.Location = new System.Drawing.Point(592, 259);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(38, 15);
            this.lblFax.TabIndex = 5;
            this.lblFax.Text = "lblFax";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.White;
            this.lblPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPage.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPage.Location = new System.Drawing.Point(745, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(57, 19);
            this.lblPage.TabIndex = 14;
            this.lblPage.Text = "lblPage";
            // 
            // lblPiedPage
            // 
            this.lblPiedPage.AutoSize = true;
            this.lblPiedPage.BackColor = System.Drawing.Color.White;
            this.lblPiedPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPiedPage.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPiedPage.Location = new System.Drawing.Point(660, 0);
            this.lblPiedPage.Name = "lblPiedPage";
            this.lblPiedPage.Size = new System.Drawing.Size(85, 19);
            this.lblPiedPage.TabIndex = 15;
            this.lblPiedPage.Text = "lblPiedPage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nom du projet";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblPiedPage);
            this.panel4.Controls.Add(this.lblPage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 1041);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(802, 20);
            this.panel4.TabIndex = 0;
            // 
            // lblTitreClient
            // 
            this.lblTitreClient.AutoSize = true;
            this.lblTitreClient.BackColor = System.Drawing.Color.White;
            this.lblTitreClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreClient.Location = new System.Drawing.Point(23, 223);
            this.lblTitreClient.Name = "lblTitreClient";
            this.lblTitreClient.Size = new System.Drawing.Size(46, 16);
            this.lblTitreClient.TabIndex = 34;
            this.lblTitreClient.Text = "Client";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.White;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblClient.Location = new System.Drawing.Point(87, 225);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(63, 16);
            this.lblClient.TabIndex = 35;
            this.lblClient.Text = "lblClient";
            // 
            // lbTitrelProjet
            // 
            this.lbTitrelProjet.AutoSize = true;
            this.lbTitrelProjet.BackColor = System.Drawing.Color.White;
            this.lbTitrelProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTitrelProjet.Location = new System.Drawing.Point(23, 258);
            this.lbTitrelProjet.Name = "lbTitrelProjet";
            this.lbTitrelProjet.Size = new System.Drawing.Size(48, 16);
            this.lbTitrelProjet.TabIndex = 36;
            this.lbTitrelProjet.Text = "Projet";
            // 
            // lblProjet
            // 
            this.lblProjet.AutoSize = true;
            this.lblProjet.BackColor = System.Drawing.Color.White;
            this.lblProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProjet.Location = new System.Drawing.Point(87, 258);
            this.lblProjet.Name = "lblProjet";
            this.lblProjet.Size = new System.Drawing.Size(65, 16);
            this.lblProjet.TabIndex = 37;
            this.lblProjet.Text = "lblProjet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(617, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Heure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(663, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "88:88:88";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(415, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Date fermeture";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(523, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "8888-88-88";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(664, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 58);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 315);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(773, 630);
            this.listView1.TabIndex = 166;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "  ";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact";
            this.columnHeader3.Width = 199;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Commentaire";
            this.columnHeader4.Width = 260;
            // 
            // ViewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 1061);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTitrePage);
            this.Controls.Add(this.lblNoSoum);
            this.Controls.Add(this.lblTitreCommande);
            this.Controls.Add(this.lblNoBC);
            this.Controls.Add(this.lblTitreNoSoum);
            this.Controls.Add(this.lblTitreBC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProjet);
            this.Controls.Add(this.lbTitrelProjet);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblTitreClient);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDateOuverture);
            this.Controls.Add(this.lblTitreContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblTitreTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lbltitredate);
            this.Controls.Add(this.lbltitredatereq);
            this.Controls.Add(this.lblDateRequise);
            this.Controls.Add(this.lblTitreFax);
            this.Controls.Add(this.lblFax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewClients";
            this.ShowInTaskbar = false;
            this.Text = "ViewClients";
            this.Load += new System.EventHandler(this.ViewClients_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal Label lblDateOuverture;
        internal Label lblTitreCommande;
        internal Label lblTitreNoSoum;
        internal Label lblNoSoum;
        internal Label lblTitreBC;
        internal Label lblNoBC;
        internal Label lblTitreContact;
        internal Label lblContact;
        internal Label lblTitreTel;
        internal Label lblTel;
        internal Label lbltitredate;
        internal Label lblDate;
        internal Label lbltitredatereq;
        internal Label lblDateRequise;
        internal Label lblTitreFax;
        internal Label lblFax;
        internal Label lblTitrePage;
        internal Label lblPage;
        internal Label lblPiedPage;
        internal Label label7;
        internal Label label9;
        internal Panel panel4;
        internal Label label8;
        internal Label lblTitreClient;
        internal Label lblClient;
        internal Label lbTitrelProjet;
        internal Label lblProjet;
        internal Label label5;
        internal Label label6;
        internal PictureBox pictureBox2;
        internal static System.Windows.Forms.Label lblNoProj;
        internal static System.Windows.Forms.Label lblProjetNom;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        internal static System.Windows.Forms.Label lblDateDue;
        public bool Orientation { get; internal set; }


        public ViewClients()
        {
            InitializeComponent();
            PreviewTest();
        }
        private void PreviewTest()
        {
            Recordset db = new Recordset();
            int x = 0;
            listView1.Items.Clear();
            db.Open($"SELECT CONTACTCLIENT.NOCLIENT, COMPAGNIE, IDPROJSOUM, BONSCOMMANDES.NOBONCOMMANDE, NOMCONTACT, DATEOUVERTURE, DATEREQUISE, DATEFERMETURE," +
                $" DESCRIPTION, CONTACT.TELEPHONNE, CONTACT.FAX FROM[DBO].[PROJSOUM] " +
                $"JOIN[DBO].[BONSCOMMANDES] ON PROJSOUM.IDPROJSOUM = BONSCOMMANDES.NOPROJET " +
                $"JOIN[DBO].[CONTACTCLIENT] ON[DBO].[PROJSOUM].NOCLIENT =[DBO].[CONTACTCLIENT].NOCLIENT " +
                $"JOIN CONTACT ON[DBO].[CONTACTCLIENT].NOCONTACT =[DBO].[CONTACT].IDCONTACT " +
                $"WHERE CONTACTCLIENT.NOCLIENT = '7051' " +
                $"ORDER BY DATEFERMETURE DESC", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            if (!db.EOF)
            {
                lblDate.Text = DateTime.Today.ToLongDateString();
                lblNoSoum.Text = $"{db.Fields[2].Value}";
                lblNoBC.Text = $"{db.Fields[3].Value}";
                lblTitreCommande.Text = $"{db.Fields[8].Value}";
                lblDateOuverture.Text = $"{db.Fields[5].Value}";
                lblDateRequise.Text = $"{db.Fields[6].Value}";
                label9.Text = $"{db.Fields[7].Value}";
                lblClient.Text = $"{db.Fields[2].Value}";
                lblContact.Text = $"{db.Fields[4].Value}";
                lblProjet.Text = Program.Gauche($"{db.Fields[2].Value}",9);
                lblTel.Text = $"{db.Fields[9].Value}";
                lblFax.Text = $"{db.Fields[10].Value}";
                label6.Text = DateTime.Now.ToLongTimeString();
            }
            else { return; }
            while (!db.EOF)
            {
                x++;
                ListViewItem itm = listView1.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{x}"));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{db.Fields[7].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{db.Fields[4].Value}"));
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{db.Fields[8].Value}"));
                db.MoveNext();
            }
        }
        private void ViewClients_Load(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            lblPiedPage.Text = DateTime.Now.ToString();
            lblPage.Text = Name + " 1/1";
            for (int x=0; x<30; x++)
            {
                ListViewItem item = listView1.Items.Add(string.Empty);
                for (int b = 0; b < item.SubItems.Count; b++)
                {
                    item.SubItems[b].Text = string.Empty;
                }
                if(x %2==0)item.Text = (x / 2 + 1).ToString();
            }
        }
        Bitmap memoryImage;
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

    }
}