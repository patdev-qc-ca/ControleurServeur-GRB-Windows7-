
namespace ControleurServeur
{
    partial class DataBaseWizzard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Sélectionnez une table");
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            Top = new System.Windows.Forms.Panel();
            Gauche = new System.Windows.Forms.Panel();
            listSQL = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            Enfant = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            Top.SuspendLayout();
            Gauche.SuspendLayout();
            Enfant.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(197, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 14);
            label1.TabIndex = 0;
            label1.Text = "DataBase Access:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(203, 17);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(618, 22);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.ForeColor = System.Drawing.Color.DarkBlue;
            button1.Location = new System.Drawing.Point(827, 15);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 24);
            button1.TabIndex = 2;
            button1.Text = "Charger une autre";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // Top
            // 
            Top.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Top.Controls.Add(button1);
            Top.Controls.Add(label1);
            Top.Controls.Add(textBox1);
            Top.Dock = System.Windows.Forms.DockStyle.Top;
            Top.Location = new System.Drawing.Point(0, 0);
            Top.Name = "Top";
            Top.Size = new System.Drawing.Size(979, 53);
            Top.TabIndex = 3;
            // 
            // Gauche
            // 
            Gauche.Controls.Add(listSQL);
            Gauche.Controls.Add(label2);
            Gauche.Dock = System.Windows.Forms.DockStyle.Left;
            Gauche.Location = new System.Drawing.Point(0, 53);
            Gauche.Name = "Gauche";
            Gauche.Size = new System.Drawing.Size(200, 587);
            Gauche.TabIndex = 4;
            // 
            // listSQL
            // 
            listSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            listSQL.FormattingEnabled = true;
            listSQL.ItemHeight = 14;
            listSQL.Location = new System.Drawing.Point(0, 22);
            listSQL.Name = "listSQL";
            listSQL.Size = new System.Drawing.Size(200, 565);
            listSQL.Sorted = true;
            listSQL.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(200, 22);
            label2.TabIndex = 0;
            label2.Text = "Tables du ServeurSQL";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Enfant
            // 
            Enfant.Controls.Add(button2);
            Enfant.Controls.Add(listView1);
            Enfant.Controls.Add(comboBox1);
            Enfant.Controls.Add(label3);
            Enfant.Dock = System.Windows.Forms.DockStyle.Fill;
            Enfant.Location = new System.Drawing.Point(200, 53);
            Enfant.Name = "Enfant";
            Enfant.Size = new System.Drawing.Size(779, 587);
            Enfant.TabIndex = 5;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.ForeColor = System.Drawing.Color.DarkBlue;
            button2.Location = new System.Drawing.Point(417, 1);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 21);
            button2.TabIndex = 3;
            button2.Text = "Comparer SQL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listView1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.ForeColor = System.Drawing.Color.Blue;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            listView1.Location = new System.Drawing.Point(0, 22);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(779, 565);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.SelectedIndexChanged += new System.EventHandler(listView1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(207, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(187, 22);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(779, 22);
            label3.TabIndex = 0;
            label3.Text = "Tables dans la base de données Access:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // DataBaseWizzard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(979, 640);
            Controls.Add(Enfant);
            Controls.Add(Gauche);
            Controls.Add(Top);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DataBaseWizzard";
            ShowInTaskbar = false;
            Text = System.Windows.Forms.Application.ProductName + ".DataBaseWizzard";
            Top.ResumeLayout(false);
            Top.PerformLayout();
            Gauche.ResumeLayout(false);
            Enfant.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        internal static System.Windows.Forms.Label label1;
        internal static System.Windows.Forms.TextBox textBox1;
        internal static System.Windows.Forms.Button button1;
        internal static System.Windows.Forms.Panel Top;
        internal static System.Windows.Forms.Panel Gauche;
        internal static System.Windows.Forms.ListBox listSQL;
        internal static System.Windows.Forms.Label label2;
        internal static System.Windows.Forms.Panel Enfant;
        internal static System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal static System.Windows.Forms.ComboBox comboBox1;
        internal static System.Windows.Forms.Label label3;
        internal static System.Windows.Forms.ListView listView1;
        internal static System.Windows.Forms.Button button2;
    }
}