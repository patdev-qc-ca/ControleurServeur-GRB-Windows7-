﻿
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
namespace ControleurServeur
{
    public class ViewFaxAnglais : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFaxAnglais));
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObjet = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTitreBC = new System.Windows.Forms.Label();
            this.lblTitreNoSoum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 889);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(818, 63);
            this.label8.TabIndex = 399;
            this.label8.Text = "IF YOU DID NOT RECEIVE THE NUMBER OF REGISTERED PAGE(S) ON THIS DOCUMENT, PLEASE " +
    "CONTACT US.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 952);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 109);
            this.panel1.TabIndex = 398;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(818, 109);
            this.label6.TabIndex = 0;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(82, 374);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(608, 369);
            this.textBox9.TabIndex = 397;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(82, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 396;
            this.label5.Text = "Message";
            // 
            // txtObjet
            // 
            this.txtObjet.Location = new System.Drawing.Point(130, 312);
            this.txtObjet.Name = "txtObjet";
            this.txtObjet.Size = new System.Drawing.Size(315, 20);
            this.txtObjet.TabIndex = 395;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(82, 313);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 394;
            this.label15.Text = "Objet";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(592, 309);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(79, 20);
            this.textBox7.TabIndex = 393;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(549, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 392;
            this.label14.Text = "from:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(592, 283);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(79, 20);
            this.textBox6.TabIndex = 391;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(340, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 16);
            this.label13.TabIndex = 390;
            this.label13.Text = "Total pages, including cover sheet:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(195, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(315, 20);
            this.textBox5.TabIndex = 389;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(82, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 388;
            this.label12.Text = "Compagny";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 387;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(82, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 386;
            this.label9.Text = "Fax number";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(315, 20);
            this.textBox3.TabIndex = 385;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(529, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 384;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 383;
            // 
            // lblTitreBC
            // 
            this.lblTitreBC.AutoSize = true;
            this.lblTitreBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreBC.Location = new System.Drawing.Point(466, 184);
            this.lblTitreBC.Name = "lblTitreBC";
            this.lblTitreBC.Size = new System.Drawing.Size(56, 16);
            this.lblTitreBC.TabIndex = 382;
            this.lblTitreBC.Text = "Projet#";
            // 
            // lblTitreNoSoum
            // 
            this.lblTitreNoSoum.AutoSize = true;
            this.lblTitreNoSoum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitreNoSoum.Location = new System.Drawing.Point(82, 210);
            this.lblTitreNoSoum.Name = "lblTitreNoSoum";
            this.lblTitreNoSoum.Size = new System.Drawing.Size(30, 16);
            this.lblTitreNoSoum.TabIndex = 381;
            this.lblTitreNoSoum.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(82, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 380;
            this.label7.Text = "Date ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(411, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 379;
            this.label4.Text = "Fax: (450) 372-3860";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(245, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 378;
            this.label3.Text = "Tel: (450) 372-0021";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(275, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 16);
            this.label2.TabIndex = 377;
            this.label2.Text = "St-Alphonse-de-Granby, QC J0E 2A4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(300, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 376;
            this.label1.Text = "149, rue Pierre Paradis,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleurServeur.Properties.Resources.logo_GRB_inc_2;
            this.pictureBox1.Location = new System.Drawing.Point(258, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 75);
            this.pictureBox1.TabIndex = 375;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewFaxAnglais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 1061);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObjet);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitreBC);
            this.Controls.Add(this.lblTitreNoSoum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewFaxAnglais";
            this.ShowInTaskbar = false;
            this.Text = "ViewFaxAnglais";
            this.Load += new System.EventHandler(this.ViewFaxAnglais_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal Label label8;
        internal Panel panel1;
        internal Label label6;
        internal TextBox textBox9;
        internal Label label5;
        internal TextBox txtObjet;
        internal Label label15;
        internal TextBox textBox7;
        internal Label label14;
        internal TextBox textBox6;
        internal Label label13;
        internal TextBox textBox5;
        internal Label label12;
        internal TextBox textBox4;
        internal Label label9;
        internal TextBox textBox3;
        internal TextBox textBox2;
        internal TextBox textBox1;
        internal Label lblTitreBC;
        internal Label lblTitreNoSoum;
        internal Label label7;
        internal Label label4;
        internal Label label3;
        internal Label label2;
        internal Label label1;
        internal PictureBox pictureBox1;
        internal static  string lblDate; //lblNoProjetSoum.
        internal static  string lblNoProjetSoum; //lblProjet.
        internal static  string lblProjet; //Label11.
        internal static  string lblAttention; //Label12.
        internal static  string lblEntreprise; //Label13.
        internal static  string lblFax; //Label21.
        internal static  string lblSujet; //Label5.
        internal static  string lblPage; //Label7.
        internal static  string lblDe; //Label6.
        internal static  string lblMessage; //Label4.

        public ViewFaxAnglais()
        {
            InitializeComponent();
            lblDate=DateTime.Today.ToLongDateString();
        }
        public ViewFaxAnglais(string lblDate, string lblNoProjetSoum, string lblProjet, string lblAttention, string lblEntreprise,
            string lblFax, string lblSujet, string lblPage, string lblDe, string lblMessage)
        {
            InitializeComponent();
            lblDate = lblDate;
            lblNoProjetSoum = lblNoProjetSoum;
            lblProjet = lblProjet;
            lblAttention = lblAttention;
            lblEntreprise = lblEntreprise;
            lblFax = lblFax;
            lblSujet = lblSujet;
            lblPage = lblPage;
            lblDe = lblDe;
            lblMessage = lblMessage;
        }
        private void ViewFaxAnglais_Load(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            textBox1.Text = lblDate;
            textBox2.Text = lblProjet;
            textBox3.Text = lblAttention;
            textBox4.Text = lblFax;
            textBox5.Text = lblEntreprise;
            textBox6.Text = lblPage;
            textBox7.Text = lblDe;
            txtObjet.Text = lblSujet;
            textBox9.Text = $"\n{lblMessage}";
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
