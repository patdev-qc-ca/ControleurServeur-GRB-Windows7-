namespace ControleurServeur
{
    partial class ListeDistribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeDistribution));
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader9 = new System.Windows.Forms.ColumnHeader();
            columnHeader10 = new System.Windows.Forms.ColumnHeader();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button8 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            checkBox4 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            listView1.BackColor = System.Drawing.Color.Black;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            columnHeader5,
            columnHeader6,
            columnHeader7,
            columnHeader8,
            columnHeader9,
            columnHeader10});
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.HotTracking = true;
            listView1.HoverSelection = true;
            listView1.Location = new System.Drawing.Point(-1, -1);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1080, 598);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.SelectedIndexChanged += new System.EventHandler(listView1_SelectedIndexChanged);
            listView1.DoubleClick += new System.EventHandler(listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NoContact";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Contact";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "NomCompagnie";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "E-mail";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "isContact";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "isClient";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "isFournisseur";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "isChefEntreprise";
            columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "isMeatProcessing";
            columnHeader10.Width = 80;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button1.Location = new System.Drawing.Point(553, 614);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(87, 23);
            button1.TabIndex = 1;
            button1.Text = "isClients";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button2.Location = new System.Drawing.Point(642, 614);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(87, 23);
            button2.TabIndex = 2;
            button2.Text = "isFournisseurs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new System.Drawing.Point(735, 614);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(93, 23);
            button3.TabIndex = 3;
            button3.Text = "isChefEntreprise";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Location = new System.Drawing.Point(923, 614);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "Ajouter";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(button5_Click);
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(1004, 614);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "Supprimer";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(button6_Click);
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(363, 614);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "Start";
            button7.UseVisualStyleBackColor = true;
            button7.Click += new System.EventHandler(button7_Click);
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(322, 113);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(506, 236);
            panel1.TabIndex = 8;
            panel1.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(140, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(318, 21);
            comboBox1.TabIndex = 14;
            comboBox1.Visible = false;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(413, 200);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(75, 23);
            button8.TabIndex = 13;
            button8.Text = "Fermer";
            button8.UseVisualStyleBackColor = true;
            button8.Click += new System.EventHandler(button8_Click);
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Location = new System.Drawing.Point(320, 200);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(87, 23);
            button4.TabIndex = 12;
            button4.Text = "Mettre à jour";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_Click);
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new System.Drawing.Point(260, 147);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(105, 17);
            checkBox4.TabIndex = 11;
            checkBox4.Text = "Meat Processing";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(260, 128);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(103, 17);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Chef dentreprise";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(142, 147);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(80, 17);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Fournisseur";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(142, 128);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(52, 17);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Client";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(139, 100);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(319, 20);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(50, 103);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 13);
            label4.TabIndex = 6;
            label4.Text = "Courriel";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(139, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(319, 20);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(50, 77);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 13);
            label3.TabIndex = 4;
            label3.Text = "Compagnie";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(139, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(319, 20);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(50, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 13);
            label2.TabIndex = 2;
            label2.Text = "Nom du contact";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(139, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 20);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 13);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // ListeDistribution
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1082, 649);
            Controls.Add(panel1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "ListeDistribution";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}