using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using System.Diagnostics;
namespace ControleurServeur
{
    internal  class ChoixContactFRS : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixContactFRS() : base()
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
        internal Button cmdAnnuler;
        internal Button cmdOK;
        internal ComboBox cmbContactFRS;
        internal Label lblQuestion;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmbContactFRS = new System.Windows.Forms.ComboBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.ForeColor = System.Drawing.Color.White;
            this.cmdAnnuler.Location = new System.Drawing.Point(245, 175);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(65, 25);
            this.cmdAnnuler.TabIndex = 2;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Black;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.Color.White;
            this.cmdOK.Location = new System.Drawing.Point(174, 175);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(65, 25);
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmbContactFRS
            // 
            this.cmbContactFRS.BackColor = System.Drawing.Color.Black;
            this.cmbContactFRS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbContactFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContactFRS.ForeColor = System.Drawing.Color.White;
            this.cmbContactFRS.Location = new System.Drawing.Point(21, 108);
            this.cmbContactFRS.Name = "cmbContactFRS";
            this.cmbContactFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbContactFRS.Size = new System.Drawing.Size(241, 22);
            this.cmbContactFRS.TabIndex = 1;
            this.cmbContactFRS.Text = "cmbContactFRS";
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Black;
            this.lblQuestion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(21, 68);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQuestion.Size = new System.Drawing.Size(241, 33);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Qui est le contact pour .. ?";
            // 
            // ChoixContactFRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(322, 212);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmbContactFRS);
            this.Controls.Add(this.lblQuestion);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixContactFRS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.ChoixContactFRS";
            this.ResumeLayout(false);

        }
        #endregion
        private int m_iNoFRS;
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ChoixDemande.m_bAnnulerContact = true;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixContactFRS", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ChoixDemande.m_bAnnulerContact = false;
                ChoixDemande.m_sContact = cmbContactFRS.Text;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixContactFRS", "cmdOK_Click", ex);
            }
        }
        private void RemplirComboContactFRS()
        {
            try
            {
                // Remplir le combo
                ADODB.Recordset rstContactFRS;
                ADODB.Recordset rstContact;
                
                cmbContactFRS.Items.Clear();
                rstContactFRS = new Recordset();
                rstContact = new Recordset();
                rstContactFRS.Open("SELECT * FROM ContactFRS WHERE NoFRS = " + m_iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                
                while (!rstContactFRS.EOF)
                {
                    rstContact.Open(Operators.ConcatenateObject("SELECT * FROM Contact WHERE IDContact = ", rstContactFRS.Fields["NoContact"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstContact.EOF)
                    {
cmbContactFRS.Items.Add(rstContact.Fields["NomContact"].Value);
                    }
                    rstContact.Close();
                    rstContactFRS.MoveNext();
                }
                rstContact = null;
                rstContactFRS.Close();
                // Object rstContactFRS peut ne pas etre détruit avant la mise en corbeille
                rstContactFRS = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixContactFRS", "RemplirComboContactFRS", ex);
            }
        }
        public void Afficher(int iNoFRS)
        {
            try
            {
                ADODB.Recordset rstFRS;
                rstFRS = new Recordset();
                rstFRS.Open("SELECT * FROM Fournisseur WHERE IDFRS = " + iNoFRS, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                lblQuestion.Text = "Qui est le contact pour " + Strings.Replace((string)(rstFRS.Fields["NomFournisseur"].Value), "&", "&&") + "?";
                rstFRS.Close();
                rstFRS = null;
                m_iNoFRS = iNoFRS;
                RemplirComboContactFRS();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixContactFRS", "Form_Load", ex);
            }
        }
    }
}