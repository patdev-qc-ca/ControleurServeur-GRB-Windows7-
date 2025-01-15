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
    public  class AfficherRapports : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfficherRapports));
            SuspendLayout();//AfficherRapports
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(690, 887);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "AfficherRapports";
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
            Load += new System.EventHandler(AfficherRapports_Load);
            Resize += new System.EventHandler(AfficherRapports_Resize);
            ResumeLayout(false);
        }
        #endregion
        WebBrowser web = new WebBrowser();
        Bitmap memoryImage;
        private PrintDocument printDocument1 = new PrintDocument();
        public AfficherRapports(string url,bool Portrait)
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(ImprimerFormulaire);
            web.Navigate(url);
            Text = url;
            if (Portrait)
            {
                Width = 805;
                Height = 1024;
            }
            else
            {
                Width = 1024;
                Height = 805;
            }
        }
        public AfficherRapports()
        {
            InitializeComponent();
        }
        internal void Navigate(string url)
        {
            web.Navigate(url);
            Text = url;
        }
        internal void ImprimerFormulaire(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e) => e.Graphics.DrawImage(memoryImage, 0, 0);
        private void AfficherRapports_Load(object sender, EventArgs e)
        {
            Icon = Conteneur.ActiveForm.Icon;
            printDocument1.PrintPage += new PrintPageEventHandler(ImprimerFormulaire);
            Text = web.Url.AbsoluteUri;
            web.Top = 0;
            web.Left = 0;
            web.Width = Width;
            web.Height = Height;
            Controls.Add(web);
            web.Show();
            if (MessageBox.Show("Voulez vous imprimer?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Graphics myGraphics = CreateGraphics();
                Size s = Size;
                memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
                Graphics memoryGraphics = Graphics.FromImage(memoryImage);
                memoryGraphics.CopyFromScreen(Location.X, Location.Y, 0, 0, s);
                printDocument1.Print();
            }
        }
        private void AfficherRapports_Resize(object sender, EventArgs e)
        {
            web.Width = Width;
            web.Height = Height;
        }
    }
}
