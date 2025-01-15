using ADODB;
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
namespace ControleurServeur
{
    public class ViewBonLivraison : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBonLivraison));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblNoProjet = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblNoRef = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblAdresse4 = new System.Windows.Forms.Label();
            lblAdresse3 = new System.Windows.Forms.Label();
            lblAdresse2 = new System.Windows.Forms.Label();
            lblAdresse1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblVenduA = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            lblAdresseExp4 = new System.Windows.Forms.Label();
            lblAdresseExp3 = new System.Windows.Forms.Label();
            lblAdresseExp2 = new System.Windows.Forms.Label();
            lblAdresseExp1 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            lblExpedieA = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblDateExp = new System.Windows.Forms.Label();
            lblTransport = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            textBox2 = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            textBox1 = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(635, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(164, 68);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(68, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(357, 29);
            label1.TabIndex = 1;
            label1.Text = "BON DE LIVRAISON / PACKING SLIP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(373, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(127, 19);
            label2.TabIndex = 2;
            label2.Text = "PROJET/ PROJECT";
            // 
            // lblNoProjet
            // 
            lblNoProjet.AutoSize = true;
            lblNoProjet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoProjet.Location = new System.Drawing.Point(506, 93);
            lblNoProjet.Name = "lblNoProjet";
            lblNoProjet.Size = new System.Drawing.Size(88, 19);
            lblNoProjet.TabIndex = 3;
            lblNoProjet.Text = "lblNoProjet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(624, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 19);
            label4.TabIndex = 4;
            label4.Text = "DATE";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDate.Location = new System.Drawing.Point(674, 93);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(58, 19);
            lblDate.TabIndex = 5;
            lblDate.Text = "lblDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 19);
            label3.TabIndex = 6;
            label3.Text = "Vendu à / Sold to:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(31, 301);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Transport";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(lblNoRef);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblAdresse4);
            panel1.Controls.Add(lblAdresse3);
            panel1.Controls.Add(lblAdresse2);
            panel1.Controls.Add(lblAdresse1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblVenduA);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(30, 143);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(328, 153);
            panel1.TabIndex = 9;
            // 
            // lblNoRef
            // 
            lblNoRef.Location = new System.Drawing.Point(69, 134);
            lblNoRef.Name = "lblNoRef";
            lblNoRef.Size = new System.Drawing.Size(254, 14);
            lblNoRef.TabIndex = 14;
            lblNoRef.Text = "lblNoRef";
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(3, 116);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(59, 32);
            label9.TabIndex = 13;
            label9.Text = "Votre réf.  Your ref:";
            // 
            // lblAdresse4
            // 
            lblAdresse4.Location = new System.Drawing.Point(69, 105);
            lblAdresse4.Name = "lblAdresse4";
            lblAdresse4.Size = new System.Drawing.Size(254, 14);
            lblAdresse4.TabIndex = 12;
            lblAdresse4.Text = "lblAdresse4";
            // 
            // lblAdresse3
            // 
            lblAdresse3.Location = new System.Drawing.Point(69, 91);
            lblAdresse3.Name = "lblAdresse3";
            lblAdresse3.Size = new System.Drawing.Size(254, 14);
            lblAdresse3.TabIndex = 11;
            lblAdresse3.Text = "lblAdresse3";
            // 
            // lblAdresse2
            // 
            lblAdresse2.Location = new System.Drawing.Point(69, 77);
            lblAdresse2.Name = "lblAdresse2";
            lblAdresse2.Size = new System.Drawing.Size(254, 14);
            lblAdresse2.TabIndex = 10;
            lblAdresse2.Text = "lblAdresse2";
            // 
            // lblAdresse1
            // 
            lblAdresse1.Location = new System.Drawing.Point(69, 63);
            lblAdresse1.Name = "lblAdresse1";
            lblAdresse1.Size = new System.Drawing.Size(254, 14);
            lblAdresse1.TabIndex = 9;
            lblAdresse1.Text = "lblAdresse1";
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(3, 45);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(59, 32);
            label7.TabIndex = 8;
            label7.Text = "Adresse  Address:";
            // 
            // lblVenduA
            // 
            lblVenduA.AutoSize = true;
            lblVenduA.Dock = System.Windows.Forms.DockStyle.Top;
            lblVenduA.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblVenduA.Location = new System.Drawing.Point(0, 19);
            lblVenduA.Name = "lblVenduA";
            lblVenduA.Size = new System.Drawing.Size(62, 15);
            lblVenduA.TabIndex = 7;
            lblVenduA.Text = "lblVenduA";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblAdresseExp4);
            panel2.Controls.Add(lblAdresseExp3);
            panel2.Controls.Add(lblAdresseExp2);
            panel2.Controls.Add(lblAdresseExp1);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(lblExpedieA);
            panel2.Controls.Add(label17);
            panel2.Location = new System.Drawing.Point(439, 144);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(328, 153);
            panel2.TabIndex = 15;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(69, 134);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(254, 14);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(3, 131);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(27, 15);
            label10.TabIndex = 13;
            label10.Text = "ATT:";
            // 
            // lblAdresseExp4
            // 
            lblAdresseExp4.Location = new System.Drawing.Point(69, 105);
            lblAdresseExp4.Name = "lblAdresseExp4";
            lblAdresseExp4.Size = new System.Drawing.Size(254, 14);
            lblAdresseExp4.TabIndex = 12;
            lblAdresseExp4.Text = "lblAdresseExp4";
            // 
            // lblAdresseExp3
            // 
            lblAdresseExp3.Location = new System.Drawing.Point(69, 91);
            lblAdresseExp3.Name = "lblAdresseExp3";
            lblAdresseExp3.Size = new System.Drawing.Size(254, 14);
            lblAdresseExp3.TabIndex = 11;
            lblAdresseExp3.Text = "lblAdresseExp3";
            // 
            // lblAdresseExp2
            // 
            lblAdresseExp2.Location = new System.Drawing.Point(69, 77);
            lblAdresseExp2.Name = "lblAdresseExp2";
            lblAdresseExp2.Size = new System.Drawing.Size(254, 14);
            lblAdresseExp2.TabIndex = 10;
            lblAdresseExp2.Text = "lblAdresseExp2";
            // 
            // lblAdresseExp1
            // 
            lblAdresseExp1.Location = new System.Drawing.Point(69, 63);
            lblAdresseExp1.Name = "lblAdresseExp1";
            lblAdresseExp1.Size = new System.Drawing.Size(254, 14);
            lblAdresseExp1.TabIndex = 9;
            lblAdresseExp1.Text = "lblAdresseExp1";
            // 
            // label15
            // 
            label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(3, 45);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(59, 32);
            label15.TabIndex = 8;
            label15.Text = "Adresse  Address:";
            // 
            // lblExpedieA
            // 
            lblExpedieA.AutoSize = true;
            lblExpedieA.Dock = System.Windows.Forms.DockStyle.Top;
            lblExpedieA.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblExpedieA.Location = new System.Drawing.Point(0, 19);
            lblExpedieA.Name = "lblExpedieA";
            lblExpedieA.Size = new System.Drawing.Size(71, 15);
            lblExpedieA.TabIndex = 7;
            lblExpedieA.Text = "lblExpedieA";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = System.Windows.Forms.DockStyle.Top;
            label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(0, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(168, 19);
            label17.TabIndex = 6;
            label17.Text = "Expédié à / Shipped to:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(435, 301);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(187, 15);
            label6.TabIndex = 16;
            label6.Text = "Date de livraison / Date shipped:";
            // 
            // lblDateExp
            // 
            lblDateExp.AutoSize = true;
            lblDateExp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateExp.Location = new System.Drawing.Point(628, 301);
            lblDateExp.Name = "lblDateExp";
            lblDateExp.Size = new System.Drawing.Size(66, 15);
            lblDateExp.TabIndex = 17;
            lblDateExp.Text = "lblDateExp";
            // 
            // lblTransport
            // 
            lblTransport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTransport.Location = new System.Drawing.Point(97, 301);
            lblTransport.Name = "lblTransport";
            lblTransport.Size = new System.Drawing.Size(254, 16);
            lblTransport.TabIndex = 18;
            lblTransport.Text = "lblTransport";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            columnHeader5});
            listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(774, 672);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "QTY ORD.";
            columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "QTY SHIPPED";
            columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "BO";
            columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "DESCRIPTION";
            columnHeader4.Width = 245;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "MANUFACTURER";
            columnHeader5.Width = 220;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel3.Controls.Add(listView1);
            panel3.Location = new System.Drawing.Point(12, 329);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(778, 676);
            panel3.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(0, 961);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(802, 100);
            panel4.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(610, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(162, 21);
            textBox2.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(575, 75);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(32, 15);
            label14.TabIndex = 12;
            label14.Text = "Date";
            // 
            // panel5
            // 
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel5.Location = new System.Drawing.Point(100, 60);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(434, 32);
            panel5.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(100, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(434, 21);
            textBox1.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(16, 60);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(59, 15);
            label13.TabIndex = 9;
            label13.Text = "Signature";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(16, 37);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(77, 15);
            label12.TabIndex = 8;
            label12.Text = "Nom / Name:";
            // 
            // label11
            // 
            label11.Dock = System.Windows.Forms.DockStyle.Top;
            label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(0, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(798, 19);
            label11.TabIndex = 7;
            label11.Text = "INSPECTÉ ET REÇU EN BON ÉTAT / INSPECTED AND RECEIVED IN GOOD CONDITION";
            label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewBonLivraison
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(802, 1061);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(lblTransport);
            Controls.Add(lblDateExp);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(lblDate);
            Controls.Add(label4);
            Controls.Add(lblNoProjet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewBonLivraison";
            Text = "ViewBonLivraison";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label label1;
        internal static Label label2;
        internal static Label lblNoProjet;
        internal static Label label4;
        internal static Label lblDate;
        internal static Label label3;
        internal static Label label5;
        internal static Panel panel1;
        internal static Label lblNoRef;
        internal static Label label9;
        internal static Label lblAdresse4;
        internal static Label lblAdresse3;
        internal static Label lblAdresse2;
        internal static Label lblAdresse1;
        internal static Label label7;
        internal static Label lblVenduA;
        internal static Panel panel2;
        internal static Label label8;
        internal static Label label10;
        internal static Label lblAdresseExp4;
        internal static Label lblAdresseExp3;
        internal static Label lblAdresseExp2;
        internal static Label lblAdresseExp1;
        internal static Label label15;
        internal static Label lblExpedieA;
        internal static Label label17;
        internal static Label label6;
        internal static Label lblDateExp;
        internal static Label lblTransport;
        internal static ListView listView1;
        internal static ColumnHeader columnHeader1;
        internal static ColumnHeader columnHeader2;
        internal static ColumnHeader columnHeader3;
        internal static ColumnHeader columnHeader4;
        internal static ColumnHeader columnHeader5;
        internal static Panel panel3;
        internal static Panel panel4;
        internal static TextBox textBox2;
        internal static Label label14;
        internal static Panel panel5;
        internal static TextBox textBox1;
        internal static Label label13;
        internal static Label label12;
        internal static Label label11;
        internal static bool Orientation;
        internal ADODB.Recordset DataSource;
        private void RemplirDatas()
        {
            if (DataSource.EOF)
            {
                MessageBox.Show("Aucune donnée dans le tampon", Application.ProductName); return;
            }
            else
            {
                while (!DataSource.EOF)
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[1].Value}"));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[2].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[0].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[4].Value}"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[5].Value}"));
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[6].Value}"));
                    DataSource.MoveNext();
                }
            }
        }
        public ViewBonLivraison()
        {
            InitializeComponent();
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
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