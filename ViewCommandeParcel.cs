using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ControleurServeur
{
    public class ViewCommandeParcel : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCommandeParcel));
            ViewTitre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblpays = new System.Windows.Forms.Label();
            lbladresse = new System.Windows.Forms.Label();
            lblcompagnie = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblreminder = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            lblassist = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ViewTitre
            // 
            ViewTitre.AutoSize = true;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(165, 215);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(425, 26);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Instructions - U.S. parcel service shipments only";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(560, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(177, 76);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(174, 253);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(416, 13);
            label2.TabIndex = 420;
            label2.Text = "Please ensure that all your invoices and parcels are addressed and labelled as fo" +
    "llows: ";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(lblpays);
            panel1.Controls.Add(lbladresse);
            panel1.Controls.Add(lblcompagnie);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(194, 322);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(396, 137);
            panel1.TabIndex = 421;
            // 
            // lblpays
            // 
            lblpays.AutoSize = true;
            lblpays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblpays.Location = new System.Drawing.Point(131, 97);
            lblpays.Name = "lblpays";
            lblpays.Size = new System.Drawing.Size(45, 15);
            lblpays.TabIndex = 4;
            lblpays.Text = "lblpays";
            // 
            // lbladresse
            // 
            lbladresse.AutoSize = true;
            lbladresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbladresse.Location = new System.Drawing.Point(131, 82);
            lbladresse.Name = "lbladresse";
            lbladresse.Size = new System.Drawing.Size(64, 15);
            lbladresse.TabIndex = 3;
            lbladresse.Text = "lbladresse";
            // 
            // lblcompagnie
            // 
            lblcompagnie.AutoSize = true;
            lblcompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblcompagnie.Location = new System.Drawing.Point(131, 67);
            lblcompagnie.Name = "lblcompagnie";
            lblcompagnie.Size = new System.Drawing.Size(82, 15);
            lblcompagnie.TabIndex = 2;
            lblcompagnie.Text = "lblcompagnie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(139, 42);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(152, 16);
            label4.TabIndex = 1;
            label4.Text = "SOLUTION GRB INC.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 13);
            label3.TabIndex = 0;
            label3.Text = "Your label should read: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(21, 586);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 15);
            label5.TabIndex = 422;
            label5.Text = "Reminder: ";
            // 
            // lblreminder
            // 
            lblreminder.AutoSize = true;
            lblreminder.Location = new System.Drawing.Point(102, 603);
            lblreminder.Name = "lblreminder";
            lblreminder.Size = new System.Drawing.Size(534, 13);
            lblreminder.TabIndex = 423;
            lblreminder.Text = "Please note that you are shipping to a Vermont address and therefore your shippme" +
    "nt is considered as domestic.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(102, 631);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(317, 13);
            label7.TabIndex = 424;
            label7.Text = "DO NOT SEND ANY TRUCK SHIPMENTS TO THIS ADDRESS.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(63, 660);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(663, 13);
            label8.TabIndex = 425;
            label8.Text = "The following documents are necessary for CUSTOMS CLEARANCE IN CANADA AND MUST ac" +
    "company the shipment and be accessible";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(63, 673);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(301, 13);
            label9.TabIndex = 426;
            label9.Text = "(outside of your boxes), otherwise your parcel may be returned.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(63, 696);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(651, 13);
            label10.TabIndex = 427;
            label10.Text = "3 copies of your commercial invoice (showing complete description and value (even" +
    " if no charge), Quantity, Weight, No. of Pkgs Shipped";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(63, 709);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(142, 13);
            label11.TabIndex = 428;
            label11.Text = " and the origin of the goods.)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(63, 736);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(471, 13);
            label12.TabIndex = 429;
            label12.Text = "NAFTA (North American Free Trade Agreement) Certificate of Origin (Valid and prop" +
    "erty completed)";
            // 
            // lblassist
            // 
            lblassist.AutoSize = true;
            lblassist.Location = new System.Drawing.Point(63, 791);
            lblassist.Name = "lblassist";
            lblassist.Size = new System.Drawing.Size(597, 13);
            lblassist.TabIndex = 430;
            lblassist.Text = "Should you have any questions, do not hesitate to call Visnja De Melo at 1 (888)4" +
    "08-8474, it will be our pleasure to assist you.";
            // 
            // label14
            // 
            label14.Dock = System.Windows.Forms.DockStyle.Bottom;
            label14.Location = new System.Drawing.Point(0, 842);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(738, 24);
            label14.TabIndex = 431;
            label14.Text = "Page 1 sur 1    ";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewCommandeParcel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(738, 866);
            Controls.Add(label14);
            Controls.Add(lblassist);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblreminder);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewCommandeParcel";
            Text = Name;
            Load += new System.EventHandler(InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        internal static PictureBox pictureBox1;
        internal static Label ViewTitre;
        internal static Label label2;
        internal static Panel panel1;
        internal static Label label3;
        internal static Label label4;
        internal static Label lblcompagnie;
        internal static Label lbladresse;
        internal static Label lblpays;
        internal static Label label5;
        internal static Label lblreminder;
        internal static Label label7;
        internal static Label label8;
        internal static Label label9;
        internal static Label label10;
        internal static Label label11;
        internal static Label label12;
        internal static Label lblassist;
        internal static Label label14;

        public ViewCommandeParcel() => InitializeComponent();
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
        private void InitFormulaire(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            SqlConnection sql = new SqlConnection(ControleurServeur.Program.StringSQL);
            sql.Open();
            SqlDataReader reader = new SqlCommand($"SELECT parcel_label_line1, parcel_label_line2, parcel_label_line3, ParcelAssist, ParcelEtat FROM Config", sql).ExecuteReader();
            if (reader.Read())
            {
                lblcompagnie.Text = reader["parcel_label_line1"].ToString();
                lbladresse.Text = reader["parcel_label_line2"].ToString();
                lblpays.Text = reader["parcel_label_line3"].ToString();
                lblassist.Text = $"Should you have any questions, do not hesitate to call {reader["ParcelAssist"]}, it will be our pleasure to assist you.";
                lblreminder.Text = $"Please note that you are shipping to a {reader["ParcelEtat"]} address and therefore your shipment is considered as domestic.";
            }
            reader.Close();
            sql.Close();
        }
    }
}
