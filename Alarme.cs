using System;
using System.Diagnostics;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    internal  class Alarme : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public  Alarme() : base()
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
        internal static ToolTip ToolTip1;
        internal static Button cmdOK;
        internal static DateTimePicker mvwDate;
        internal static Button cmdDate;
        internal static TextBox txtDate;
        internal static CheckBox chkRemind;
        internal static MaskedTextBox mskHeure;
        internal static TextBox txtMessage;
        internal static Label Label4;
        internal static Label Label3;
        internal static Label Label1;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarme));
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdOK = new System.Windows.Forms.Button();
            cmdDate = new System.Windows.Forms.Button();
            txtDate = new System.Windows.Forms.TextBox();
            chkRemind = new System.Windows.Forms.CheckBox();
            mskHeure = new System.Windows.Forms.MaskedTextBox();
            txtMessage = new System.Windows.Forms.TextBox();
            Label4 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            mvwDate = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;//cmdOK
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(309, 281);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(65, 25);
            cmdOK.TabIndex = 9;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);//cmdDate
            cmdDate.BackColor = System.Drawing.Color.Black;
            cmdDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdDate.ForeColor = System.Drawing.Color.White;
            cmdDate.Location = new System.Drawing.Point(324, 187);
            cmdDate.Name = "cmdDate";
            cmdDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDate.Size = new System.Drawing.Size(25, 17);
            cmdDate.TabIndex = 6;
            cmdDate.Text = "..";
            cmdDate.UseVisualStyleBackColor = true;
            cmdDate.Click += new System.EventHandler(cmdDate_Click);//txtDate
            txtDate.AcceptsReturn = true;
            txtDate.BackColor = System.Drawing.Color.Black;
            txtDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDate.ForeColor = System.Drawing.Color.White;
            txtDate.Location = new System.Drawing.Point(244, 187);
            txtDate.MaxLength = 0;
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtDate.Size = new System.Drawing.Size(73, 20);
            txtDate.TabIndex = 4;//chkRemind
            chkRemind.AutoSize = true;
            chkRemind.BackColor = System.Drawing.Color.Black;
            chkRemind.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkRemind.ForeColor = System.Drawing.Color.White;
            chkRemind.Location = new System.Drawing.Point(92, 186);
            chkRemind.Name = "chkRemind";
            chkRemind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkRemind.Size = new System.Drawing.Size(111, 18);
            chkRemind.TabIndex = 3;
            chkRemind.Text = "Me le rappeler le :";
            chkRemind.UseVisualStyleBackColor = true;
            chkRemind.CheckStateChanged += new System.EventHandler(chkRemind_CheckStateChanged);//mskHeure
            mskHeure.AllowPromptAsInput = false;
            mskHeure.BackColor = System.Drawing.Color.Black;
            mskHeure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskHeure.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskHeure.ForeColor = System.Drawing.Color.White;
            mskHeure.Location = new System.Drawing.Point(244, 219);
            mskHeure.Name = "mskHeure";
            mskHeure.Size = new System.Drawing.Size(73, 20);
            mskHeure.TabIndex = 8;
            mskHeure.Visible = false;
            mskHeure.Enter += new System.EventHandler(mskHeure_Enter);
            mskHeure.Leave += new System.EventHandler(mskHeure_Leave);//txtMessage
            txtMessage.AcceptsReturn = true;
            txtMessage.BackColor = System.Drawing.Color.Black;
            txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMessage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtMessage.ForeColor = System.Drawing.Color.White;
            txtMessage.Location = new System.Drawing.Point(33, 116);
            txtMessage.MaxLength = 0;
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtMessage.Size = new System.Drawing.Size(323, 65);
            txtMessage.TabIndex = 2;//Label4
            Label4.AutoSize = true;
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(204, 222);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(42, 14);
            Label4.TabIndex = 7;
            Label4.Text = "Heure :";//Label3
            Label3.AutoSize = true;
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(209, 188);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(35, 14);
            Label3.TabIndex = 5;
            Label3.Text = "Date :";//Label1
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Location = new System.Drawing.Point(33, 75);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(265, 25);
            Label1.TabIndex = 0;
            Label1.Text = "Vous avez une alarme!";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;//mvwDate
            mvwDate.CalendarForeColor = System.Drawing.Color.White;
            mvwDate.CalendarMonthBackground = System.Drawing.Color.Navy;
            mvwDate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            mvwDate.Location = new System.Drawing.Point(52, 217);
            mvwDate.Name = "mvwDate";
            mvwDate.Size = new System.Drawing.Size(146, 20);
            mvwDate.TabIndex = 10;//Alarme
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(386, 318);
            ControlBox = false;
            Controls.Add(mvwDate);
            Controls.Add(cmdOK);
            Controls.Add(cmdDate);
            Controls.Add(txtDate);
            Controls.Add(chkRemind);
            Controls.Add(mskHeure);
            Controls.Add(txtMessage);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label1);
            Location = new System.Drawing.Point(3, 22);
            Name = "Alarme";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            Load += new System.EventHandler(Alarme_Load);
            Click += new System.EventHandler(Alarme_Click);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private int m_lIDAlarme;
        public static Cedule cdl = new Cedule();
        private int dynamic;
        public Alarme(int dynamic)
        {
            dynamic = dynamic;
        }
        private void chkRemind_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ActiverChamps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "chkRemind_Click", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstAlarme;
                string sType;
                rstAlarme = new Recordset();
                rstAlarme.Open("SELECT * FROM Alarmes WHERE IDAlarme = " + m_lIDAlarme, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sType = (string)(rstAlarme.Fields["TypeCédule"].Value);
                if (chkRemind.Checked)
                {
                    if (!string.IsNullOrEmpty(txtDate.Text))
                    {
                        if (!string.IsNullOrEmpty(mskHeure.Text))
                        {
                            rstAlarme.Fields["Date"].Value = txtDate.Text;
                            rstAlarme.Fields["Heure"].Value = mskHeure.Text;
                            rstAlarme.Fields["JourSemaine"].Value = DateAndTime.Weekday(Conversions.ToDate(txtDate.Text));
                            rstAlarme.Update();
                        }
                        else
                        {
                            MessageBox.Show("L'heure est invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La date est invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    rstAlarme.Delete();
                    rstAlarme.Update();
                }
                rstAlarme.Close();
                rstAlarme = null;
                if (g_bCeduleOuverte == true)
                {
                    cdl.RemplirListerJour();
                    cdl.RemplirListerSemaine();
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "cmdOK_Click", ex);
            }
        }
        private void Alarme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ((dynamic)mvwDate).Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "Form_Click", ex);
            }
        }
        private void Alarme_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                ActiverChamps();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "Form_Load", ex);
            }
        }
        private void ActiverChamps()
        {
            try
            {
                bool bActif;
                if (chkRemind.Checked)
                {
                    bActif = true;
                }
                else
                {
                    bActif = false;
                }
                txtDate.Enabled = bActif;
                mskHeure.Enabled = bActif;
                cmdDate.Enabled = bActif;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "ActiverChamps", ex);
            }
        }
        private void mvwDate_DateClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtDate.Text = ConvertDate(mvwDate.Value);
                ((dynamic)mvwDate).Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "mvwDate_DateClick", ex);
            }
        }
        public void Afficher(int lIDAlarme)
        {
            try
            {
                ADODB.Recordset rstAlarme;
                rstAlarme = new Recordset();
                m_lIDAlarme = lIDAlarme;
                rstAlarme.Open("SELECT * FROM Alarmes WHERE IDAlarme = " + lIDAlarme, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                txtMessage.Text = (string)(rstAlarme.Fields["Message"].Value);
                rstAlarme.Close();
                rstAlarme = null;
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "Afficher", ex);
            }
        }
        private void mskHeure_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskHeure.Mask = "##:##";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "mskHeure_GotFocus", ex);
            }
        }
        private void mskHeure_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskHeure.Mask = string.Empty;
                if (mskHeure.Text == "__:__")
                {
                    mskHeure.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "mskHeure_LostFocus", ex);
            }
        }
        private void cmdDate_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(Strings.Trim(txtDate.Text)))
                {
                    mvwDate.Value = Conversions.ToDate(txtDate.Text);
                }
                else
                {
                    mvwDate.Value = DateTime.Today;
                }
                mvwDate.Visible = true;
                mvwDate.Focus();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Alarme", "cmdDate_Click", ex);
            }
        }
    }
}