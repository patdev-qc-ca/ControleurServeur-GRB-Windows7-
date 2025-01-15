
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
using ControleurServeur;
namespace ControleurServeur
{
    public class ViewReception : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReception));
            ViewTitre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblDate = new System.Windows.Forms.Label();
            lblTitreProjetAchat = new System.Windows.Forms.Label();
            lblProjetAchat = new System.Windows.Forms.Label();
            lblTitreNumero = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            Label3 = new System.Windows.Forms.ToolStripStatusLabel();
            label8 = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            Text1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtPiece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtEscompte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            txtPrixNet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ViewTitre
            // 
            ViewTitre.AutoSize = true;
            ViewTitre.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ViewTitre.Location = new System.Drawing.Point(11, 9);
            ViewTitre.Name = "ViewTitre";
            ViewTitre.Size = new System.Drawing.Size(138, 36);
            ViewTitre.TabIndex = 418;
            ViewTitre.Tag = "";
            ViewTitre.Text = "Réception";
            ViewTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Location = new System.Drawing.Point(642, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 69);
            pictureBox1.TabIndex = 419;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = System.Drawing.Color.White;
            lblDate.Location = new System.Drawing.Point(79, 60);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(40, 13);
            lblDate.TabIndex = 522;
            lblDate.Text = "lblDate";
            // 
            // lblTitreProjetAchat
            // 
            lblTitreProjetAchat.AutoSize = true;
            lblTitreProjetAchat.BackColor = System.Drawing.Color.White;
            lblTitreProjetAchat.Location = new System.Drawing.Point(14, 78);
            lblTitreProjetAchat.MinimumSize = new System.Drawing.Size(60, 19);
            lblTitreProjetAchat.Name = "lblTitreProjetAchat";
            lblTitreProjetAchat.Size = new System.Drawing.Size(60, 19);
            lblTitreProjetAchat.TabIndex = 525;
            lblTitreProjetAchat.Text = "Projet";
            // 
            // lblProjetAchat
            // 
            lblProjetAchat.AutoSize = true;
            lblProjetAchat.BackColor = System.Drawing.Color.White;
            lblProjetAchat.Location = new System.Drawing.Point(80, 78);
            lblProjetAchat.MinimumSize = new System.Drawing.Size(60, 19);
            lblProjetAchat.Name = "lblProjetAchat";
            lblProjetAchat.Size = new System.Drawing.Size(72, 19);
            lblProjetAchat.TabIndex = 526;
            lblProjetAchat.Text = "lblProjetAchat";
            // 
            // lblTitreNumero
            // 
            lblTitreNumero.AutoSize = true;
            lblTitreNumero.BackColor = System.Drawing.Color.White;
            lblTitreNumero.Location = new System.Drawing.Point(13, 59);
            lblTitreNumero.MinimumSize = new System.Drawing.Size(60, 19);
            lblTitreNumero.Name = "lblTitreNumero";
            lblTitreNumero.Size = new System.Drawing.Size(60, 19);
            lblTitreNumero.TabIndex = 533;
            lblTitreNumero.Text = "Date";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Label3});
            statusStrip1.Location = new System.Drawing.Point(0, 1039);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(818, 22);
            statusStrip1.TabIndex = 534;
            statusStrip1.Text = "statusStrip1";
            // 
            // Label3
            // 
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(803, 17);
            Label3.Spring = true;
            Label3.Text = "Page %p de %P";
            Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(709, 1075);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(42, 13);
            label8.TabIndex = 535;
            label8.Text = "TOTAL";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotal.Location = new System.Drawing.Point(757, 1071);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new System.Windows.Forms.Padding(3);
            lblTotal.Size = new System.Drawing.Size(49, 21);
            lblTotal.TabIndex = 536;
            lblTotal.Text = "lblTotal";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Text1,
            txtQuantite,
            txtPiece,
            txtEscompte,
            txtPrixNet});
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(12, 100);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(794, 952);
            listView1.TabIndex = 537;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // Text1
            // 
            Text1.Text = "Date";
            // 
            // txtQuantite
            // 
            txtQuantite.Text = "Quantité";
            // 
            // txtPiece
            // 
            txtPiece.Text = "Piece";
            // 
            // txtEscompte
            // 
            txtEscompte.Text = "Escompte";
            // 
            // txtPrixNet
            // 
            txtPrixNet.Text = "Prix net";
            // 
            // ViewReception
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(818, 1061);
            Controls.Add(listView1);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(statusStrip1);
            Controls.Add(lblDate);
            Controls.Add(lblTitreProjetAchat);
            Controls.Add(lblProjetAchat);
            Controls.Add(lblTitreNumero);
            Controls.Add(pictureBox1);
            Controls.Add(ViewTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewReception";
            ShowInTaskbar = false;
            Text = Name;
            Load += new System.EventHandler(ViewBonTravail_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static PictureBox pictureBox1;
        internal static Label ViewTitre;
        internal static Label lblDate;
        internal static Label lblTitreProjetAchat;
        internal static Label lblProjetAchat;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel Label3;
        internal static Label label8;
        internal static Label lblTotal;
        internal static ListView listView1;
        internal static ColumnHeader Text1;
        internal static ColumnHeader txtQuantite;
        internal static ColumnHeader txtPiece;
        internal static ColumnHeader txtEscompte;
        internal static ColumnHeader txtPrixNet;
        internal static Label lblTitreNumero;

        public ViewReception()
        {
            InitializeComponent();
        }
        private void ViewBonTravail_Load(object sender, EventArgs e)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            if (DataSource.EOF)
            {
                MessageBox.Show("Aucune donnée dans le tampon", Application.ProductName); return;
            }
            else
            {
                while (!DataSource.EOF)
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[19].Value}"));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[20].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[3].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[10].Value}%"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields[11].Value}"));
                    DataSource.MoveNext();
                }
            }
        }
        internal static ADODB.Recordset DataSource;
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
