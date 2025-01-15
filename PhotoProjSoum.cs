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
namespace ControleurServeur
{
    public  class PhotoProjSoum : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoProjSoum));
            listBox1 = new System.Windows.Forms.ListBox();
            webBrowser1 = new System.Windows.Forms.WebBrowser();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();//listBox1
            listBox1.BackColor = System.Drawing.Color.Black;
            listBox1.ForeColor = System.Drawing.Color.Navy;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(8, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(190, 342);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += new System.EventHandler(listBox1_SelectedIndexChanged);//webBrowser1
            webBrowser1.Location = new System.Drawing.Point(199, 57);
            webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new System.Drawing.Size(589, 341);
            webBrowser1.TabIndex = 1;//button1
            button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button1.Location = new System.Drawing.Point(199, 404);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(92, 23);
            button1.TabIndex = 2;
            button1.Text = "<- Précédente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);//button2
            button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button2.Location = new System.Drawing.Point(712, 405);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Suivante ->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);//button3
            button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button3.Location = new System.Drawing.Point(713, 446);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "&Fermer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_Click);//statusStrip1
            statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1});
            statusStrip1.Location = new System.Drawing.Point(0, 473);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(810, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";//toolStripStatusLabel1
            toolStripStatusLabel1.Image = global::ControleurServeur.Properties.Resources.Home;
            toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(764, 17);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolStripStatusLabel1.Click += new System.EventHandler(toolStripStatusLabel1_Click);//PhotoProjSoum
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(810, 495);
            Controls.Add(statusStrip1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(webBrowser1);
            Controls.Add(listBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "PhotoProjSoum";
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
            Load += new System.EventHandler(PhotoProjSoum_Load);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        internal static System.Windows.Forms.ListBox listBox1;
        internal static System.Windows.Forms.WebBrowser webBrowser1;
        internal static System.Windows.Forms.Button button1;
        internal static System.Windows.Forms.Button button2;
        internal static System.Windows.Forms.Button button3;
        internal static System.Windows.Forms.StatusStrip statusStrip1;
        internal static System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        string chemin;
        int id = -1;
        public PhotoProjSoum(string chemin)
        {
            InitializeComponent();
            chemin = chemin;
        }
        public PhotoProjSoum()
        {
            InitializeComponent();
            chemin = Program.dirCheminPhotos;
        }
  /// <summary>
  /// envisager le format JP2000
  /// le HTML5 
  /// ?
  /// </summary>
  internal void ListerImages()
        {
            string[] files = Directory.GetFiles(chemin, "*.*");
            toolStripStatusLabel1.Text = "https://production.grb.local/images/photos";
            foreach (string file in files)
                if (Program.Droite(file, 4).ToLower() == ".jpg"
                    | Program.Droite(file, 4).ToLower() == ".jpeg"
                    | Program.Droite(file, 4).ToLower() == ".png"
                    | Program.Droite(file, 4).ToLower() == ".gif" 
                    | Program.Droite(file, 4).ToLower() == ".bmp")
                {
                    listBox1.Items.Add(Program.Droite(file, file.Length - chemin.Length - 1));
                }
            if (listBox1.Items.Count < 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
        private void PhotoProjSoum_Load(object sender, EventArgs e)
        {
            ListerImages();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(chemin+"\\"+listBox1.SelectedItem.ToString());
            id = listBox1.SelectedIndex;
            toolStripStatusLabel1.Text = "https://production.grb.local/autogrb/images/photos/"+ listBox1.SelectedItem.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (id < 0) 
            { 
                button1.Enabled = false;
                id = listBox1.SelectedIndex;
            } else { 
                button1.Enabled = true;
                webBrowser1.Navigate(chemin + "\\" + listBox1.Items[id--].ToString());
            }
        }
        private void button3_Click(object sender, EventArgs e) => Close();
        private void button2_Click(object sender, EventArgs e)
        {
            if (id==listBox1.Items.Count)
            {
                button2.Enabled = false;
                id = listBox1.SelectedIndex;
            }
            else
            {
                button2.Enabled = true;
                webBrowser1.Navigate(chemin + "\\" + listBox1.Items[id++].ToString());
            }
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Form f = new ControleurServeur.InterfaceWeb(toolStripStatusLabel1.Text);
            f.MdiParent = Conteneur.Mdi;
            f.Text = toolStripStatusLabel1.Text;
            f.Show();
        }
    }
}
