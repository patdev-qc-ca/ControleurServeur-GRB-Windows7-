
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleurServeur;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public class InterfaceWeb : Form
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(InterfaceWeb));
            web = new WebBrowser();
            SuspendLayout();//web
            web.Dock = DockStyle.Fill;
            web.Location = new Point(0, 0);
            web.MinimumSize = new Size(20, 20);
            web.Name = "web";
            web.Size = new Size(800, 421);
            web.TabIndex = 0;
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(web_DocumentCompleted);
            web.Navigating += new WebBrowserNavigatingEventHandler(web_Navigating);//InterfaceWeb
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(web);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "InterfaceWeb";
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Text = "ControleurServeur." + Name;
            ShowInTaskbar = false;
            Load += new EventHandler(InterfaceWeb_Load);
            Resize += new EventHandler(InterfaceWeb_Resize);
            ResumeLayout(false);
        }
        #endregion
        internal static WebBrowser web;
        public InterfaceWeb()
        {
            InitializeComponent();
        }
        public InterfaceWeb(string url)
        {
            InitializeComponent();
            web.Navigate(url);
        }
        private void InterfaceWeb_Load(object sender, EventArgs e)
        {
            web.Top = 0;
            web.Left = 0;
            web.Width = Width;
            web.Height = Height;
        }
        private void InterfaceWeb_Resize(object sender, EventArgs e)
        {
            web.Width = Width;
            web.Height = Height;
        }
        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                string log = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Bug_{dt.DayOfYear.ToString().PadLeft(3, '0')}_{dt.Year}{dt.Month.ToString().PadLeft(2, '0')}{dt.Day.ToString().PadLeft(2, '0')}.log";
                StreamWriter sw = new StreamWriter(log, true);
                sw.WriteLine($"{DateTime.Now.ToString()} => {IdNomEmploye}@{Conteneur.ip}");
                sw.WriteLine(web.DocumentTitle);
                sw.WriteLine(web.Url.Host);
                if (web.DocumentText.Length > 0) sw.WriteLine(web.DocumentText);
                sw.Close();
                Text = web.DocumentTitle;
            }
            catch (Exception ex)
            {
                int idErreur = int.Parse(Gauche(web.DocumentTitle.Trim(), 3));
                if (idErreur == 0x191)
                {
                    MessageBox.Show($"{web.Url.ToString()}\nL'erreur {web.DocumentTitle} est survenue\n\nCe problême entraine la fermeture automatique dûe à la condition LinkActivDirectory", $"{Application.ProductName}.ActivDirectory.MemberID.Reject", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    AfficherErreur("InterfaceWeb", "ActivDirectory.MemberID.Reject@web_DocumentCompleted", ex);
                    Application.Exit();
                }
                else if (idErreur >= 0x192)
                {
                    MessageBox.Show($"{web.Url.ToString()}\nL'erreur {web.DocumentTitle} est survenue\nCe problême entraine la perte potentielle d'informations", $"{Application.ProductName}.InterfaceWeb.Document.Chargement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AfficherErreur("InterfaceWeb", "Gestion.ErreurWeb@web_DocumentCompleted", ex);
                }
                else
                {
                    AfficherErreur("InterfaceWeb", "web_DocumentCompleted", ex);
                }
            }
        }
        private void web_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
        }
    }
}
