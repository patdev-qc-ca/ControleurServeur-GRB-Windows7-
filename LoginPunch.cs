using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using System.Diagnostics;
namespace ControleurServeur
{
    internal class Login : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public Login() : base()
        {
            InitializeComponent();
        }
        private System.ComponentModel.IContainer components;
        internal static System.Windows.Forms.ToolTip ToolTip1;
        internal static System.Windows.Forms.TextBox txtlogin;
        internal static System.Windows.Forms.TextBox txtpasswd;
        internal static System.Windows.Forms.Button cmdok;
        internal static System.Windows.Forms.Button cmdcancel;
        internal static System.Windows.Forms.Label Label1;
        internal static System.Windows.Forms.Label Label2;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            txtlogin = new System.Windows.Forms.TextBox();
            txtpasswd = new System.Windows.Forms.TextBox();
            cmdok = new System.Windows.Forms.Button();
            cmdcancel = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;//txtlogin
            txtlogin.AcceptsReturn = true;
            txtlogin.BackColor = System.Drawing.Color.Black;
            txtlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtlogin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtlogin.ForeColor = System.Drawing.Color.White;
            txtlogin.Location = new System.Drawing.Point(122, 66);
            txtlogin.MaxLength = 0;
            txtlogin.Name = "txtlogin";
            txtlogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtlogin.Size = new System.Drawing.Size(169, 20);
            txtlogin.TabIndex = 1;
            txtlogin.Text = "waecpatr";
            txtlogin.Enter += new System.EventHandler(txtlogin_Enter);//txtpasswd
            txtpasswd.AcceptsReturn = true;
            txtpasswd.BackColor = System.Drawing.Color.Black;
            txtpasswd.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtpasswd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtpasswd.ForeColor = System.Drawing.Color.White;
            txtpasswd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            txtpasswd.Location = new System.Drawing.Point(122, 98);
            txtpasswd.MaxLength = 0;
            txtpasswd.Name = "txtpasswd";
            txtpasswd.PasswordChar = '*';
            txtpasswd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtpasswd.Size = new System.Drawing.Size(169, 20);
            txtpasswd.TabIndex = 3;
            txtpasswd.Text = "waechter";//cmdok
            cmdok.AutoSize = true;
            cmdok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdok.BackColor = System.Drawing.Color.Black;
            cmdok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdok.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdok.ForeColor = System.Drawing.Color.White;
            cmdok.Location = new System.Drawing.Point(197, 142);
            cmdok.Name = "cmdok";
            cmdok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdok.Size = new System.Drawing.Size(34, 26);
            cmdok.TabIndex = 4;
            cmdok.Text = "OK";
            cmdok.UseVisualStyleBackColor = true;
            cmdok.Click += new System.EventHandler(cmdOK_Click);//cmdcancel
            cmdcancel.AutoSize = true;
            cmdcancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdcancel.BackColor = System.Drawing.Color.Black;
            cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdcancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdcancel.ForeColor = System.Drawing.Color.White;
            cmdcancel.Location = new System.Drawing.Point(235, 142);
            cmdcancel.Name = "cmdcancel";
            cmdcancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdcancel.Size = new System.Drawing.Size(56, 26);
            cmdcancel.TabIndex = 5;
            cmdcancel.Text = "Cancel";
            cmdcancel.UseVisualStyleBackColor = true;
            cmdcancel.Click += new System.EventHandler(cmdCancel_Click);//Label1
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(34, 66);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(73, 17);
            Label1.TabIndex = 0;
            Label1.Text = "Utilisateur:";//Label2
            Label2.AutoSize = true;
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(34, 98);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(85, 14);
            Label2.TabIndex = 2;
            Label2.Text = "Mot de passe:";//Login
            AcceptButton = cmdok;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(311, 178);
            ControlBox = false;
            Controls.Add(txtlogin);
            Controls.Add(txtpasswd);
            Controls.Add(cmdok);
            Controls.Add(cmdcancel);
            Controls.Add(Label1);
            Controls.Add(Label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Name = "Login";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            Activated += new System.EventHandler(Login_Activated);
            Load += new System.EventHandler(Login_Load);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Form m_Source;
        private object m_iNoGroupe;
        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                g_bBonPasswd = false;
                // ferme le login
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Login", "cmdcancel_Click", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstEmploye;

                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT * FROM employés WHERE loginname = '" + txtlogin.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                // Si trouve utilisateur
                if (!rstEmploye.EOF)
                {
                    // si bon mot de passe, save user et quitte loggin
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Strings.UCase(rstEmploye.Fields["passwd"].Value), Strings.UCase(txtpasswd.Text), false)))
                    {
                        g_bBonPasswd = true;
                        Interaction.SaveSetting("GRB", "CONFIG", "LoginPunch", txtlogin.Text);
                        // Control m_iNoGroupe a ete relocalise dans le module principal
                        IdGroupe = (int)rstEmploye.Fields["Groupe"].Value;
                        // Control m_sUserID a ete relocalise dans le module principal
                        IdLoginEmploye = txtlogin.Text;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe invalide!");
                    }
                }
                else
                {
                    MessageBox.Show("L'utilisateur n'existe pas!");
                }
                rstEmploye.Close();
                rstEmploye = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Login", "cmdOK_Click", ex);
            }
        }
        public void Afficher(Form Source)
        {
            try
            {
                m_Source = Source;
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Login", "Afficher", ex);
            }
        }
        // Form event Login.Activate est devenue bingtofront
        private void Login_Activated(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (string.IsNullOrEmpty(txtlogin.Text))
                {
                    txtlogin.Focus();
                }
                else
                {
                    txtpasswd.Focus();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Login", "Form_Activate", ex);
            }
        }
        private void Login_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                txtlogin.Text = Interaction.GetSetting("GRB", "CONFIG", "LoginPunch", "");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Login", "Form_Load", ex);
            }
        }
        private void txtlogin_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtlogin.Text))
                {
                    txtlogin.SelectionStart = 0;
                    txtlogin.SelectionLength = Strings.Len(txtlogin.Text);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Login", "txtlogin_GotFocus", ex);
            }
        }
    }
}