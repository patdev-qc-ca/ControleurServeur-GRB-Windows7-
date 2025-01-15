using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System;
using Point = System.Drawing.Point;

namespace ControleurServeur
{
    partial class Legende
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
              public ToolTip ToolTip1;
        public System.Windows.Forms.Button cmdFermer;
        public System.Windows.Forms. Button shpBrun;
        public System.Windows.Forms. Label Label14;
        public System.Windows.Forms. Label Label11;
        public System.Windows.Forms. Button shpRose;
        public System.Windows.Forms. Button shpBleu;
        public System.Windows.Forms. Label Label10;
        public System.Windows.Forms. Label Label7;
        public System.Windows.Forms. Button shpVertForet;
        public System.Windows.Forms. Button shpRed;
        public System.Windows.Forms. Label Label6;
        public System.Windows.Forms. Button shpGris;
        public System.Windows.Forms. Label Label5;
        public System.Windows.Forms. Label Label4;
        public System.Windows.Forms. Label Label3;
        public System.Windows.Forms. Label Label2;
        public System.Windows.Forms. Label Label1;
        public System.Windows.Forms. Button shpMagenta;
        public System.Windows.Forms. Button shpOrange;
        public System.Windows.Forms. Button shpVert;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button shpJaune;
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdFermer = new System.Windows.Forms.Button();
            this.shpBrun = new System.Windows.Forms.Button();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.shpRose = new System.Windows.Forms.Button();
            this.shpBleu = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.shpVertForet = new System.Windows.Forms.Button();
            this.shpRed = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.shpGris = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.shpMagenta = new System.Windows.Forms.Button();
            this.shpOrange = new System.Windows.Forms.Button();
            this.shpVert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            shpJaune = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shpJaune
            // 
            shpJaune.BackColor = System.Drawing.SystemColors.Window;
            shpJaune.FlatStyle = System.Windows.Forms.FlatStyle.System;
            shpJaune.Location = new System.Drawing.Point(16, 112);
            shpJaune.Name = "shpJaune";
            shpJaune.Size = new System.Drawing.Size(32, 32);
            shpJaune.TabIndex = 39;
            shpJaune.UseVisualStyleBackColor = true;
            // 
            // cmdFermer
            // 
            this.cmdFermer.BackColor = System.Drawing.SystemColors.Control;
            this.cmdFermer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFermer.Location = new System.Drawing.Point(275, 422);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFermer.Size = new System.Drawing.Size(65, 25);
            this.cmdFermer.TabIndex = 28;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // shpBrun
            // 
            this.shpBrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.shpBrun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.shpBrun.Location = new System.Drawing.Point(16, 184);
            this.shpBrun.Name = "shpBrun";
            this.shpBrun.Size = new System.Drawing.Size(32, 32);
            this.shpBrun.TabIndex = 38;
            this.shpBrun.UseVisualStyleBackColor = true;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(44, 245);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(209, 13);
            this.Label14.TabIndex = 13;
            this.Label14.Text = "Cette pièce est en attente d\'être retournée.";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(46, 339);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(231, 13);
            this.Label11.TabIndex = 22;
            this.Label11.Text = "Cette pièce provient d\'un extra non-chargeable.";
            // 
            // shpRose
            // 
            this.shpRose.BackColor = System.Drawing.SystemColors.Window;
            this.shpRose.Location = new System.Drawing.Point(16, 280);
            this.shpRose.Name = "shpRose";
            this.shpRose.Size = new System.Drawing.Size(32, 32);
            this.shpRose.TabIndex = 37;
            this.shpRose.UseVisualStyleBackColor = true;
            // 
            // shpBleu
            // 
            this.shpBleu.BackColor = System.Drawing.Color.Blue;
            this.shpBleu.Location = new System.Drawing.Point(16, 31);
            this.shpBleu.Name = "shpBleu";
            this.shpBleu.Size = new System.Drawing.Size(32, 32);
            this.shpBleu.TabIndex = 36;
            this.shpBleu.Text = "shapebleu";
            this.shpBleu.UseVisualStyleBackColor = true;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(46, 368);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(210, 13);
            this.Label10.TabIndex = 23;
            this.Label10.Text = "Cette pièce provient d\'un extra chargeable.";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(44, 310);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(216, 13);
            this.Label7.TabIndex = 21;
            this.Label7.Text = "La commande de cette pièce a été annulée.";
            // 
            // shpVertForet
            // 
            this.shpVertForet.BackColor = System.Drawing.SystemColors.Window;
            this.shpVertForet.Location = new System.Drawing.Point(16, 248);
            this.shpVertForet.Name = "shpVertForet";
            this.shpVertForet.Size = new System.Drawing.Size(32, 32);
            this.shpVertForet.TabIndex = 35;
            this.shpVertForet.UseVisualStyleBackColor = true;
            // 
            // shpRed
            // 
            this.shpRed.BackColor = System.Drawing.Color.Red;
            this.shpRed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.shpRed.FlatAppearance.BorderSize = 2;
            this.shpRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shpRed.Location = new System.Drawing.Point(16, 216);
            this.shpRed.Name = "shpRed";
            this.shpRed.Size = new System.Drawing.Size(32, 32);
            this.shpRed.TabIndex = 34;
            this.shpRed.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(44, 276);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(195, 13);
            this.Label6.TabIndex = 18;
            this.Label6.Text = "La pièce a été retournée au fournisseur.";
            // 
            // shpGris
            // 
            this.shpGris.BackColor = System.Drawing.SystemColors.Window;
            this.shpGris.Location = new System.Drawing.Point(16, 152);
            this.shpGris.Name = "shpGris";
            this.shpGris.Size = new System.Drawing.Size(32, 32);
            this.shpGris.TabIndex = 33;
            this.shpGris.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(46, 216);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(152, 13);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "La pièce a été reçue en entier.";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(46, 185);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(298, 13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "La soumission n\'est pas complète parce qu\'il manque des prix.";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(46, 156);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(136, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "La pièce a besoin d\'un prix.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(46, 124);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(139, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "La pièce a été commandée.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(46, 92);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(110, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "La pièce est à quoter.";
            // 
            // shpMagenta
            // 
            this.shpMagenta.BackColor = System.Drawing.SystemColors.Window;
            this.shpMagenta.Location = new System.Drawing.Point(16, 80);
            this.shpMagenta.Name = "shpMagenta";
            this.shpMagenta.Size = new System.Drawing.Size(32, 32);
            this.shpMagenta.TabIndex = 32;
            this.shpMagenta.UseVisualStyleBackColor = true;
            // 
            // shpOrange
            // 
            this.shpOrange.BackColor = System.Drawing.SystemColors.Window;
            this.shpOrange.Location = new System.Drawing.Point(16, 48);
            this.shpOrange.Name = "shpOrange";
            this.shpOrange.Size = new System.Drawing.Size(32, 32);
            this.shpOrange.TabIndex = 31;
            this.shpOrange.UseVisualStyleBackColor = true;
            // 
            // shpVert
            // 
            this.shpVert.Location = new System.Drawing.Point(16, 16);
            this.shpVert.Name = "shpVert";
            this.shpVert.Size = new System.Drawing.Size(32, 32);
            this.shpVert.TabIndex = 30;
            this.shpVert.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(16, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(16, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Magenta;
            this.button3.Location = new System.Drawing.Point(16, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(16, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 32;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(15, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 36;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(16, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 35;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(16, 240);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 23);
            this.button7.TabIndex = 34;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.Location = new System.Drawing.Point(15, 211);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(23, 23);
            this.button8.TabIndex = 33;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Blue;
            this.button11.Location = new System.Drawing.Point(15, 363);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(23, 23);
            this.button11.TabIndex = 38;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Pink;
            this.button12.Location = new System.Drawing.Point(15, 334);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(23, 23);
            this.button12.TabIndex = 37;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // Legende
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(358, 459);
            this.ControlBox = false;
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Legende";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legende";
            this.Load += new System.EventHandler(this.Legende_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}