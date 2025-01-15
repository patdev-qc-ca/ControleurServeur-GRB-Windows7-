using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using System.Diagnostics;
using ADODB;

namespace ControleurServeur
{
    internal class ChoixDateImpressionReception : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixDateImpressionReception() : base()
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
        internal Button cmdImprimer;
        internal Label Label2;
        private DateTimePicker mskDateDebut;
        internal Label Label1;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.mskDateFin = new System.Windows.Forms.DateTimePicker();
            this.mskDateDebut = new System.Windows.Forms.DateTimePicker();
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
            this.cmdAnnuler.Location = new System.Drawing.Point(239, 188);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(73, 25);
            this.cmdAnnuler.TabIndex = 8;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.BackColor = System.Drawing.Color.Black;
            this.cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimer.ForeColor = System.Drawing.Color.White;
            this.cmdImprimer.Location = new System.Drawing.Point(160, 188);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImprimer.Size = new System.Drawing.Size(73, 25);
            this.cmdImprimer.TabIndex = 9;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(25, 115);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(65, 17);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Date fin :";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(25, 83);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(65, 17);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Date début :";
            // 
            // mskDateFin
            // 
            this.mskDateFin.CalendarForeColor = System.Drawing.Color.White;
            this.mskDateFin.CalendarMonthBackground = System.Drawing.Color.Navy;
            this.mskDateFin.Location = new System.Drawing.Point(105, 112);
            this.mskDateFin.Name = "mskDateFin";
            this.mskDateFin.Size = new System.Drawing.Size(200, 22);
            this.mskDateFin.TabIndex = 10;
            // 
            // mskDateDebut
            // 
            this.mskDateDebut.CalendarForeColor = System.Drawing.Color.White;
            this.mskDateDebut.CalendarMonthBackground = System.Drawing.Color.Navy;
            this.mskDateDebut.Location = new System.Drawing.Point(105, 79);
            this.mskDateDebut.Name = "mskDateDebut";
            this.mskDateDebut.Size = new System.Drawing.Size(200, 22);
            this.mskDateDebut.TabIndex = 11;
            // 
            // ChoixDateImpressionReception
            // 
            this.AcceptButton = this.cmdImprimer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(327, 229);
            this.ControlBox = false;
            this.Controls.Add(this.mskDateDebut);
            this.Controls.Add(this.mskDateFin);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixDateImpressionReception";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.ChoixDateImpressionReception";
            this.Load += new System.EventHandler(this.ChoixDateImpressionReception_Load);
            this.Click += new System.EventHandler(this.ChoixDateImpressionReception_Click);
            this.ResumeLayout(false);

        }
        #endregion
        private DateTimePicker mskDateFin;
        private enum enumDate
        {
            AUCUNE = 0,
            DEBUT = 1,
            Fin = 2
        }
        public enum enumTypeReception
        {
            PROJET = 0,
            ACHAT = 1
        }
        private enumDate m_eDate;
        private EnumCatalogue m_eCatalogue;
        private enumTypeReception m_eTypeReception;
        private string m_sNoProjet;
        private string m_sIDAchat;
        private int m_iIndexAchat;
        private EnumCatalogue mECANIQUE;
        private EnumType ACHAT;
        public ChoixDateImpressionReception(string text, EnumCatalogue mECANIQUE, EnumType ACHAT)
        {
            InitializeComponent();
            Text = text;
            mECANIQUE = mECANIQUE;
            ACHAT = ACHAT;
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionReception", "cmdAnnuler_Click", ex);
            }
        }
        [Obsolete]
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstReception = new Recordset();;
                ADODB.Recordset rstTotal = new Recordset();;
                if (ValiderDate(mskDateDebut.Text) == false)
                {
                    MessageBox.Show("Date de début invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ValiderDate(mskDateFin.Text) == false)
                {
                    MessageBox.Show("Date de fin invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Operators.CompareString(mskDateFin.Text, mskDateDebut.Text, false) < 0)
                {
                    MessageBox.Show("La date de fin doit être plus grande que la date de début!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (m_eTypeReception == enumTypeReception.PROJET)
                {
                    rstReception.Open("SELECT Projet_Pieces.*, Escompte, Prix_Net , Qté FROM Projet_Pieces WHERE IDProjet = '" + m_sNoProjet + "' AND ((Recu = 1 AND DateRéception BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "') OR (Retour = 1 AND DateRetour BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'))", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstReception.Open("SELECT Achat_Pieces.*, (Escompte / 100) As ModifEscompte, (Prix_Net * Qté) As TotalReception FROM Achat_Pieces WHERE IDAchat = '" + m_sIDAchat + "' AND IndexAchat = " + m_iIndexAchat + " AND ((Recu = 1 AND DateRéception BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "') OR (Retour = 1 AND DateRetour BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'))", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                ControleurServeur.ViewReception.DataSource = rstReception;
                ControleurServeur.ViewReception.Orientation = false; // rstReception;
                ControleurServeur.ViewReception.lblDate.Text = "Du " + mskDateDebut.Text + " Au " + mskDateFin.Text;
                if (m_eTypeReception == enumTypeReception.ACHAT)
                {
                    ControleurServeur.ViewReception.lblTitreProjetAchat.Text = "ACHAT :";
                    ControleurServeur.ViewReception.lblProjetAchat.Text = m_sIDAchat + "-" + Droite("00" + m_iIndexAchat, 3);
                    rstTotal.Open("SELECT SUM(Qté * Prix_Net) As Total FROM Achat_Pieces WHERE IDAchat = '" + m_sIDAchat + "' AND IndexAchat = " + m_iIndexAchat + " AND ((Recu = 1 AND DateRéception BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "') OR (Retour = 1 AND DateRetour BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'))", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!(rstTotal.Fields["Total"].Value.Value is DBNull))
                    {
                        ControleurServeur.ViewReception.lblTotal.Text = (rstTotal.Fields["Total"].Value.Value);
                    }
                    else
                    {
                        ControleurServeur.ViewReception.lblTotal.Text = "0";
                    }
                }
                else
                {
                    ControleurServeur.ViewReception.lblTitreProjetAchat.Text = "Projet :";
                    ControleurServeur.ViewReception.lblProjetAchat.Text = m_sNoProjet;
                    rstTotal.Open("SELECT SUM(Qté * Prix_Net) As Total FROM Projet_Pieces WHERE IDProjet = '" + m_sNoProjet + "' AND ((Recu = 1 AND DateRéception BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "') OR (Retour = 1 AND DateRetour BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'))", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!(rstTotal.Fields["Total"].Value.Value is DBNull))
                    {
                        ControleurServeur.ViewReception.lblTotal.Text = (rstTotal.Fields["Total"].Value);
                    }
                    else
                    {
                        ControleurServeur.ViewReception.lblTotal.Text = "0";
                    }
                }
                rstTotal.Close();
                // Object rstTotal peut ne pas etre détruit avant la mise en corbeille
                rstTotal = null;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionReception", "cmdImprimer_Click", ex);
            }
        }
        private void ChoixDateImpressionReception_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionReception", "Form_Click", ex);
            }
        }
        private void ChoixDateImpressionReception_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            mskDateDebut.Value = DateTime.Today.AddMonths(-1);
            mskDateFin.Value = DateTime.Today.AddDays(-1);
            try
            {
                m_eDate = enumDate.AUCUNE;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionReception", "Form_Load", ex);
            }
        }
        private bool ValiderDate(string sDate)
        {
            bool ValiderDateRet = default;
            try
            {
                if (!Information.IsDate(sDate))
                {
                    ValiderDateRet = false;
                }
                else
                {
                    ValiderDateRet = true;
                }
                return ValiderDateRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionReception", "ValiderDate", ex);
                return false;
            }
        }
        public void Afficher(string sNoProjet, EnumCatalogue eCatalogue, enumTypeReception eTypeReception)
        {
            try
            {
                m_eTypeReception = eTypeReception;
                switch (eTypeReception)
                {
                    case enumTypeReception.PROJET: { m_sNoProjet = sNoProjet; break; }
                    case enumTypeReception.ACHAT:
                        {
                            m_sIDAchat = Gauche(sNoProjet, 9);
                            m_iIndexAchat = int.Parse(Droite(sNoProjet, 3)); break;
                        }
                }
                m_eCatalogue = eCatalogue;
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionReception", "Afficher", ex);
            }
        }
    }
}