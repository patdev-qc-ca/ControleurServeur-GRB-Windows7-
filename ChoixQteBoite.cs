using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal  class ChoixQteBoite : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixQteBoite() : base()
        {
            InitializeComponent();
        }
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!(components is null))
                {
                    components.Dispose();
                }
            }
            base.Dispose(Disposing);
        }
        private System.ComponentModel.IContainer components;
        internal ToolTip ToolTip1;
        internal Button cmdOK;
        internal TextBox txtQteBoite;
        internal CheckBox chkQteBoite;
        internal Label lblQteBoite;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdOK = new System.Windows.Forms.Button();
            this.txtQteBoite = new System.Windows.Forms.TextBox();
            this.chkQteBoite = new System.Windows.Forms.CheckBox();
            this.lblQteBoite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Black;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.Color.White;
            this.cmdOK.Location = new System.Drawing.Point(191, 155);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(65, 25);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txtQteBoite
            // 
            this.txtQteBoite.AcceptsReturn = true;
            this.txtQteBoite.BackColor = System.Drawing.Color.Black;
            this.txtQteBoite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQteBoite.Enabled = false;
            this.txtQteBoite.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQteBoite.ForeColor = System.Drawing.Color.White;
            this.txtQteBoite.Location = new System.Drawing.Point(127, 107);
            this.txtQteBoite.MaxLength = 0;
            this.txtQteBoite.Name = "txtQteBoite";
            this.txtQteBoite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQteBoite.Size = new System.Drawing.Size(65, 22);
            this.txtQteBoite.TabIndex = 3;
            this.txtQteBoite.Leave += new System.EventHandler(this.txtQteBoite_Leave);
            // 
            // chkQteBoite
            // 
            this.chkQteBoite.AutoSize = true;
            this.chkQteBoite.BackColor = System.Drawing.Color.Black;
            this.chkQteBoite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkQteBoite.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQteBoite.ForeColor = System.Drawing.Color.White;
            this.chkQteBoite.Location = new System.Drawing.Point(63, 83);
            this.chkQteBoite.Name = "chkQteBoite";
            this.chkQteBoite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkQteBoite.Size = new System.Drawing.Size(126, 18);
            this.chkQteBoite.TabIndex = 1;
            this.chkQteBoite.Text = "Commande par boîte";
            this.chkQteBoite.UseVisualStyleBackColor = true;
            this.chkQteBoite.CheckStateChanged += new System.EventHandler(this.chkQteBoite_CheckStateChanged);
            // 
            // lblQteBoite
            // 
            this.lblQteBoite.AutoSize = true;
            this.lblQteBoite.BackColor = System.Drawing.Color.Black;
            this.lblQteBoite.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQteBoite.ForeColor = System.Drawing.Color.White;
            this.lblQteBoite.Location = new System.Drawing.Point(63, 107);
            this.lblQteBoite.Name = "lblQteBoite";
            this.lblQteBoite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQteBoite.Size = new System.Drawing.Size(56, 14);
            this.lblQteBoite.TabIndex = 2;
            this.lblQteBoite.Text = "Quantité :";
            // 
            // ChoixQteBoite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(279, 192);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtQteBoite);
            this.Controls.Add(this.chkQteBoite);
            this.Controls.Add(this.lblQteBoite);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixQteBoite";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.ChoixQteBoite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        public ChoixQteBoite(string text)
        {
            Text = text;
        }
        public void Afficher(string sNoPiece)
        {
            try
            {
                Show();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixQteBoite", "Afficher",ex);
            }
        }
        //chkQteBoite.CheckStateChanged//
        private void chkQteBoite_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkQteBoite.Checked)
                {
                    txtQteBoite.Enabled = true;
                }
                else
                {
                    txtQteBoite.Text = "";
                    txtQteBoite.Enabled = false;
                }
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixQteBoite", "chkQteBoite_Click",ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                g_sQteBoite = txtQteBoite.Text;
                if (chkQteBoite.Checked)
                {
                    g_bQteBoite = true;
                }
                else
                {
                    g_bQteBoite = false;
                }
                Close();
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixQteBoite", "cmdOK_Click",ex);
            }
        }
        private void txtQteBoite_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkQteBoite.Checked)
                {
                    txtQteBoite.Text = Strings.Replace(txtQteBoite.Text, ".", ",");
                    if (!IsNumeric(txtQteBoite.Text) | txtQteBoite.Text == "0")
                    {
txtQteBoite.Text = "0";
                    }
                }
                return;
            }
            catch(Exception ex)
            {
                AfficherErreur("ChoixQteBoite", "txtQteBoite_LostFocus",ex);
            }
        }
    }
}