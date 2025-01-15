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
    public class ViewOutilsMachinerie : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOutilsMachinerie));
            this.lbldepartement = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtnom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txttype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtcout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtachat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txthorsfonction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtcommentaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldepartement
            // 
            this.lbldepartement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldepartement.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartement.Location = new System.Drawing.Point(22, 3);
            this.lbldepartement.Name = "lbldepartement";
            this.lbldepartement.Size = new System.Drawing.Size(976, 38);
            this.lbldepartement.TabIndex = 418;
            this.lbldepartement.Tag = "";
            this.lbldepartement.Text = "Département";
            this.lbldepartement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtno,
            this.txtnom,
            this.txttype,
            this.txtcout,
            this.txtachat,
            this.txthorsfonction,
            this.txtcommentaire});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1116, 708);
            this.listView1.TabIndex = 419;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtno
            // 
            this.txtno.Text = "no";
            // 
            // txtnom
            // 
            this.txtnom.Text = "Nom";
            this.txtnom.Width = 169;
            // 
            // txttype
            // 
            this.txttype.Text = "Type";
            this.txttype.Width = 98;
            // 
            // txtcout
            // 
            this.txtcout.Text = "Cout";
            this.txtcout.Width = 71;
            // 
            // txtachat
            // 
            this.txtachat.Text = "Date d\'ACHAT";
            this.txtachat.Width = 84;
            // 
            // txthorsfonction
            // 
            this.txthorsfonction.Text = "Disposition";
            this.txthorsfonction.Width = 164;
            // 
            // txtcommentaire
            // 
            this.txtcommentaire.Text = "Commentaire";
            this.txtcommentaire.Width = 367;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControleurServeur.Properties.Resources.logo_RapportGRB;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1004, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 55);
            this.pictureBox1.TabIndex = 420;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Location = new System.Drawing.Point(916, 42);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(61, 13);
            this.lblDate1.TabIndex = 421;
            this.lblDate1.Text = "2024-05-09";
            this.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewOutilsMachinerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 795);
            this.Controls.Add(this.lblDate1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbldepartement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewOutilsMachinerie";
            this.ShowInTaskbar = false;
            this.Text = this.Name;
            this.Load += new System.EventHandler(this.InitFormulaire);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal Label lbldepartement;
        internal ListView listView1;
        internal ColumnHeader txtno;
        internal ColumnHeader txtnom;
        internal ColumnHeader txttype;
        internal ColumnHeader txtcout;
        internal ColumnHeader txtachat;
        internal ColumnHeader txthorsfonction;
        internal ColumnHeader txtcommentaire;
        internal PictureBox pictureBox1;
        internal Label lblDate1;
        public ViewOutilsMachinerie()
        {
            InitializeComponent();
        }
        private void InitFormulaire(object sender, EventArgs e)
        {
            lblDate1.Text = DateTime.Now.ToString();
            Text = Application.ProductName + ".EmulateurCrystalWeb." + Name +" ["+lblDate1.Text+"]";
            if(!(DataSource is null))
            {
    //            if (!DataSource.EOF) { lbldepartement.Text = $"{DataSource.Fields["departement"].Value}"; }
                while (!DataSource.EOF)
                {
                    ListViewItem itm = listView1.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields["no_outils"].Value}"));
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields["nom_outils"].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields["type_étiquette"].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields["cout"].Value}"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields["date_achat"].Value}"));
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields["date_hors_fonction"].Value}"));
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{DataSource.Fields["commentaire"].Value}"));
                    DataSource.MoveNext();
                }
            }
        }
        internal  ADODB.Recordset DataSource;
        Bitmap memoryImage;
        internal bool Orientation;
        private void ImpressionFormulaire(object sender, PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.DefaultPageSettings.Color = false;
                printDocument1.DefaultPageSettings.Landscape = ControleurServeur.Program.isLandscape; //pour le mode paysage
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