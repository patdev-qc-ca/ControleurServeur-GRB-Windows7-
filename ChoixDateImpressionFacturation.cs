using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ControleurServeur;
using ADODB;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using System.Diagnostics;
#pragma warning disable CS0168
namespace ControleurServeur
{
    internal class ChoixDateImpressionFacturation : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixDateImpressionFacturation() : base()
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
        internal RadioButton _optChoix_1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox fra2Dates;
        internal System.Windows.Forms.Button cmdAnnuler;
        internal System.Windows.Forms.Button cmdImprimer;
        internal RadioButton _optChoixProjetEntier_1;
        internal RadioButton _optChoixProjetEntier_0;
        internal Panel Picture1;
        internal System.Windows.Forms.GroupBox fraProjetEntier;
        internal RadioButton _optChoix_0;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._optChoix_1 = new System.Windows.Forms.RadioButton();
            this.fra2Dates = new System.Windows.Forms.GroupBox();
            this.mskDateDebut = new System.Windows.Forms.DateTimePicker();
            this.mskDateFin = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.fraProjetEntier = new System.Windows.Forms.GroupBox();
            this.Picture1 = new System.Windows.Forms.Panel();
            this._optChoixProjetEntier_1 = new System.Windows.Forms.RadioButton();
            this._optChoixProjetEntier_0 = new System.Windows.Forms.RadioButton();
            this._optChoix_0 = new System.Windows.Forms.RadioButton();
            this.cmdExporter = new System.Windows.Forms.Button();
            this.fra2Dates.SuspendLayout();
            this.fraProjetEntier.SuspendLayout();
            this.Picture1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _optChoix_1
            // 
            this._optChoix_1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optChoix_1.Location = new System.Drawing.Point(0, 0);
            this._optChoix_1.Name = "_optChoix_1";
            this._optChoix_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optChoix_1.Size = new System.Drawing.Size(99, 17);
            this._optChoix_1.TabIndex = 11;
            this._optChoix_1.TabStop = true;
            this._optChoix_1.Text = "Entre 2 dates";
            this._optChoix_1.UseVisualStyleBackColor = true;
            this._optChoix_1.CheckedChanged += new System.EventHandler(this._optChoix_1_CheckedChanged);
            // 
            // fra2Dates
            // 
            this.fra2Dates.Controls.Add(this.mskDateDebut);
            this.fra2Dates.Controls.Add(this.mskDateFin);
            this.fra2Dates.Controls.Add(this._optChoix_1);
            this.fra2Dates.Controls.Add(this.Label1);
            this.fra2Dates.Controls.Add(this.Label2);
            this.fra2Dates.Enabled = false;
            this.fra2Dates.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fra2Dates.Location = new System.Drawing.Point(24, 94);
            this.fra2Dates.Name = "fra2Dates";
            this.fra2Dates.Padding = new System.Windows.Forms.Padding(0);
            this.fra2Dates.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fra2Dates.Size = new System.Drawing.Size(217, 121);
            this.fra2Dates.TabIndex = 3;
            this.fra2Dates.TabStop = false;
            // 
            // mskDateDebut
            // 
            this.mskDateDebut.Location = new System.Drawing.Point(19, 53);
            this.mskDateDebut.Name = "mskDateDebut";
            this.mskDateDebut.Size = new System.Drawing.Size(190, 22);
            this.mskDateDebut.TabIndex = 18;
            // 
            // mskDateFin
            // 
            this.mskDateFin.Location = new System.Drawing.Point(19, 91);
            this.mskDateFin.Name = "mskDateFin";
            this.mskDateFin.Size = new System.Drawing.Size(190, 22);
            this.mskDateFin.TabIndex = 17;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 32);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(65, 17);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Date début :";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 76);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(65, 17);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Date fin :";
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.Location = new System.Drawing.Point(244, 377);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(73, 25);
            this.cmdAnnuler.TabIndex = 1;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimer.Location = new System.Drawing.Point(165, 377);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImprimer.Size = new System.Drawing.Size(73, 25);
            this.cmdImprimer.TabIndex = 2;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // fraProjetEntier
            // 
            this.fraProjetEntier.Controls.Add(this.Picture1);
            this.fraProjetEntier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraProjetEntier.Location = new System.Drawing.Point(14, 59);
            this.fraProjetEntier.Name = "fraProjetEntier";
            this.fraProjetEntier.Padding = new System.Windows.Forms.Padding(0);
            this.fraProjetEntier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraProjetEntier.Size = new System.Drawing.Size(303, 280);
            this.fraProjetEntier.TabIndex = 12;
            this.fraProjetEntier.TabStop = false;
            this.fraProjetEntier.Text = "Choix de l\'impression";
            // 
            // Picture1
            // 
            this.Picture1.Controls.Add(this.fra2Dates);
            this.Picture1.Controls.Add(this._optChoixProjetEntier_1);
            this.Picture1.Controls.Add(this._optChoixProjetEntier_0);
            this.Picture1.Controls.Add(this._optChoix_0);
            this.Picture1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picture1.Location = new System.Drawing.Point(8, 28);
            this.Picture1.Name = "Picture1";
            this.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Picture1.Size = new System.Drawing.Size(270, 242);
            this.Picture1.TabIndex = 13;
            this.Picture1.TabStop = true;
            // 
            // _optChoixProjetEntier_1
            // 
            this._optChoixProjetEntier_1.AutoSize = true;
            this._optChoixProjetEntier_1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optChoixProjetEntier_1.Location = new System.Drawing.Point(24, 47);
            this._optChoixProjetEntier_1.Name = "_optChoixProjetEntier_1";
            this._optChoixProjetEntier_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optChoixProjetEntier_1.Size = new System.Drawing.Size(131, 18);
            this._optChoixProjetEntier_1.TabIndex = 15;
            this._optChoixProjetEntier_1.Text = "Prix coûtant du projet";
            this._optChoixProjetEntier_1.UseVisualStyleBackColor = true;
            this._optChoixProjetEntier_1.CheckedChanged += new System.EventHandler(this._optChoixProjetEntier_1_CheckedChanged);
            // 
            // _optChoixProjetEntier_0
            // 
            this._optChoixProjetEntier_0.AutoSize = true;
            this._optChoixProjetEntier_0.Checked = true;
            this._optChoixProjetEntier_0.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optChoixProjetEntier_0.Location = new System.Drawing.Point(24, 24);
            this._optChoixProjetEntier_0.Name = "_optChoixProjetEntier_0";
            this._optChoixProjetEntier_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optChoixProjetEntier_0.Size = new System.Drawing.Size(105, 18);
            this._optChoixProjetEntier_0.TabIndex = 14;
            this._optChoixProjetEntier_0.TabStop = true;
            this._optChoixProjetEntier_0.Text = "Liste des punchs";
            this._optChoixProjetEntier_0.UseVisualStyleBackColor = true;
            this._optChoixProjetEntier_0.CheckedChanged += new System.EventHandler(this._optChoixProjetEntier_0_CheckedChanged);
            // 
            // _optChoix_0
            // 
            this._optChoix_0.AutoSize = true;
            this._optChoix_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optChoix_0.Location = new System.Drawing.Point(24, 70);
            this._optChoix_0.Name = "_optChoix_0";
            this._optChoix_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optChoix_0.Size = new System.Drawing.Size(94, 18);
            this._optChoix_0.TabIndex = 16;
            this._optChoix_0.Text = "Projet entier";
            this._optChoix_0.UseVisualStyleBackColor = true;
            this._optChoix_0.CheckedChanged += new System.EventHandler(this._optChoix_0_CheckedChanged);
            // 
            // cmdExporter
            // 
            this.cmdExporter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdExporter.Location = new System.Drawing.Point(84, 378);
            this.cmdExporter.Name = "cmdExporter";
            this.cmdExporter.Size = new System.Drawing.Size(75, 23);
            this.cmdExporter.TabIndex = 13;
            this.cmdExporter.Text = "Exporter";
            this.cmdExporter.UseVisualStyleBackColor = true;
            this.cmdExporter.Click += new System.EventHandler(this.cmdExporter_Click);
            // 
            // ChoixDateImpressionFacturation
            // 
            this.AcceptButton = this.cmdImprimer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(327, 417);
            this.Controls.Add(this.cmdExporter);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.fraProjetEntier);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixDateImpressionFacturation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportation feuilles de temps";
            this.Load += new System.EventHandler(this.ChoixDateImpressionFacturation_Load);
            this.Click += new System.EventHandler(this.ChoixDateImpressionFacturation_Click);
            this.fra2Dates.ResumeLayout(false);
            this.fraProjetEntier.ResumeLayout(false);
            this.Picture1.ResumeLayout(false);
            this.Picture1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private DateTimePicker mskDateFin;
        private DateTimePicker mskDateDebut;
        private System.Windows.Forms.Button cmdExporter;
        private enum enumDate
        {
            AUCUNE = 0,
            DEBUT = 1,
            Fin = 2
        }
        private const int I_OPT_PROJET_ENTIER = 0;
        private const int I_OPT_2_DATES = 1;
        private const int I_OPT_LISTE_PUNCH = 0;
        private const int I_OPT_COUTANT = 1;
        private enumDate m_eDate;
        private string m_sNoProjSoum;
        private bool m_bProjet;
        private string m_sClient;
        private string m_sDescription;
        private Microsoft.Office.Interop.Excel.Application m_xlsApp;
        public ChoixDateImpressionFacturation(string sNoProjSoum, bool bProjet, string sClient, string sDescription)
        {
            InitializeComponent();
            m_sNoProjSoum = sNoProjSoum;
            m_bProjet = bProjet;
            m_sClient = sClient;
            m_sDescription = sDescription;
            try
            {
                m_sNoProjSoum = sNoProjSoum;
                m_bProjet = bProjet;
                if (bProjet == true)
                {
                    _optChoix_1.Enabled = true;
                }
                else
                {
                    _optChoix_1.Enabled = false;
                }
                m_sClient = sClient;
                m_sDescription = sDescription;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "Afficher", ex);
            }
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
                AfficherErreur("ChoixDateImpressionFacturation", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            ControleurServeur.ViewApercuProjet viewApercuProjet = new ControleurServeur.ViewApercuProjet();
            viewApercuProjet.Show();
            try
            {
                if (_optChoixProjetEntier_0.Checked == true)
                {
                    ImprimerListePunch();
                }
                else
                {
                    ImprimerPrixCoutant();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "cmdImprimer_Click", ex);
            }
        }
        [Obsolete]
        private void ImprimerListePunch()
        {
            try
            {
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstSomme;
                int X;
                var bNonComplet = default(bool);
                if (_optChoix_1.Checked == true)
                {
                    if (!string.IsNullOrEmpty(mskDateDebut.Text))
                    {
                        if (!string.IsNullOrEmpty(mskDateFin.Text))
                        {
                            if (ValiderDate(mskDateDebut.Text) == true)
                            {
                                if (ValiderDate(mskDateFin.Text) == true)
                                {
                                    if (Operators.CompareString(mskDateDebut.Text, mskDateFin.Text, false) > 0)
                                    {
                                        MessageBox.Show("La date de début doit être plus petite que la date de fin!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Date de fin non valide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Date de début non valide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La date de fin est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La date de début est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Si il y a  ou des soumissions
                if (!string.IsNullOrEmpty(m_sNoProjSoum))
                {
                    if (_optChoix_0.Checked == true)
                    {
                        for (X = 1; X <= FacturationlvwProjetsItemsCount; X++)
                        {
                            /*                        if (string.IsNullOrEmpty(Facturation.lvwProjets.Items[(int)X].SubItems[3].Text))
                                                    {
                                                        bNonComplet = true;
                                                        break;
                                                    }*/
                        }
                        if (bNonComplet == true)
                        {
                            if (MessageBox.Show("Les punchs ne sont pas complets!\n\nVoulez-vous imprimer seulement les punchs complets?", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                return;
                            }
                        }
                        rstPunch = new Recordset();
                        rstPunch.CursorLocation = CursorLocationEnum.adUseServer;
                        if (MessageBox.Show("Désirez-vous afficher les commentaires avec le type des travaux?", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.Yes)
                        {
                            rstPunch.Open("SELECT (Punch.Type & ' - ' & Punch.Commentaire) AS Comment, Punch.Date, Punch.HeureDébut, Punch.HeureFin, Punch.Facturé, Punch.NoFacture," +
                                " Employés.Initiale, Round((TimeSerial(Left(Punch.HeureFin,2), RIGHT(Punch.HeureFin,2),0) - TimeSerial(Left(Punch.HeureDébut,2)," +
                                " RIGHT(Punch.HeureDébut,2),0)) * 24, 2) As Total FROM Punch " +
                                "INNER JOIN Employés ON Punch.NoEmploye = Employés.noEmploye " +
                                "WHERE Punch.NoProjet = '" + m_sNoProjSoum + "' AND HeureFin IS NOT NULL ORDER BY [Date]", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstPunch.Open("SELECT Punch.Type AS Comment, Punch.Date, Punch.HeureDébut, Punch.HeureFin, Punch.Commentaire, Punch.Facturé, Punch.NoFacture, Employés.Initiale," +
                                " Round((TimeSerial(Left(Punch.HeureFin,2), RIGHT(Punch.HeureFin,2),0) - TimeSerial(Left(Punch.HeureDébut,2), RIGHT(Punch.HeureDébut,2),0)) * 24, 2) As Total " +
                                "FROM Punch " +
                                "INNER JOIN Employés ON Punch.NoEmploye = Employés.noEmploye" +
                                " WHERE Punch.NoProjet = '" + m_sNoProjSoum + "' AND HeureFin IS NOT NULL ORDER BY [Date]", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                    }
                    // *************************************************************************
                    else
                    {
                        for (X = 1; X <= FacturationlvwProjetsItemsCount; X++)
                        {
                            /*                            if (string.IsNullOrEmpty(Facturation.lvwProjets.Items[(int)X].SubItems[3].Text))
                                                        {
                                                            if (Operators.CompareString(Facturation.lvwProjets.Items[(int)X].SubItems[1].Text, mskDateDebut.Text, false) >= 0 & Operators.CompareString(Facturation.lvwProjets.Items[(int)X].SubItems[1].Text, mskDateFin.Text, false) >= 0)
                                                            {
                                                                bNonComplet = true;
                                                                break;
                                                            }
                                                        }*/
                        }
                        if (bNonComplet == true)
                        {
                            if (MessageBox.Show("Les punchs ne sont pas complets!\n\nVoulez-vous imprimer seulement les punchs complets?", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.No)
                            {
                                return;
                            }
                        }
                        rstPunch = new Recordset();
                        rstPunch.CursorLocation = CursorLocationEnum.adUseServer;
                        if (MessageBox.Show("Désirez-vous afficher les commentaires avec le type des travaux?", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.Yes)
                        {
                            rstPunch.Open("SELECT (Punch.Type & ' - ' & Punch.Commentaire) AS Comment, Punch.Date, Punch.HeureDébut, Punch.HeureFin, Punch.Commentaire," +
                                " Punch.Facturé, Punch.NoFacture, Employés.Initiale, Round((TimeSerial(Left(Punch.HeureFin,2), RIGHT(Punch.HeureFin,2),0) - " +
                                "TimeSerial(Left(Punch.HeureDébut,2), RIGHT(Punch.HeureDébut,2),0)) * 24, 2) As Total FROM Punch " +
                                "INNER JOIN Employés ON Punch.NoEmploye = Employés.noEmploye " +
                                "WHERE Punch.NoProjet = '" + m_sNoProjSoum + "' AND HeureFin IS NOT NULL AND [Punch.Date] BETWEEN '" + mskDateDebut.Text + "' AND '" +
                                mskDateFin.Text + "' ORDER BY [Date]", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstPunch.Open("SELECT Punch.Type AS Comment, Punch.Date, Punch.HeureDébut, Punch.HeureFin, Punch.Commentaire, Punch.Facturé, " +
                                "Punch.NoFacture, Employés.Initiale, Round((TimeSerial(Left(Punch.HeureFin,2), RIGHT(Punch.HeureFin,2),0) - TimeSerial(Left(Punch.HeureDébut,2)," +
                                " RIGHT(Punch.HeureDébut,2),0)) * 24, 2) As Total FROM Punch" +
                                " INNER JOIN Employés ON Punch.NoEmploye = Employés.noEmploye WHERE Punch.NoProjet = '" + m_sNoProjSoum + "' AND HeureFin IS NOT NULL " +
                                "AND [Punch.Date] BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "' ORDER BY [Date]", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                    }
                    ControleurServeur.ViewFacturation.Orientation = false;
                    if (m_bProjet == true)
                    {
                        ControleurServeur.ViewFacturation.lblTitreNumero.Text = "Numéro de projet :";
                    }
                    else
                    {
                        ControleurServeur.ViewFacturation.lblTitreNumero.Text = "Numéro de soumission :";
                    }
                    ControleurServeur.ViewFacturation.lblNumero.Text = m_sNoProjSoum;
                    ControleurServeur.ViewFacturation.lblClient.Text = m_sClient;
                    ControleurServeur.ViewFacturation.lblDate.Text = ConvertDate(DateTime.Today);
                    if (MessageBox.Show("Désirez-vous afficher les colonnes 'facturé' et 'no. facture'?", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        rstSomme = new Recordset();
                        if (_optChoix_0.Checked == true)
                        {
                            ///formule SQL douteuse
                            rstSomme.Open("SELECT SUM(TimeSerial(Left(HeureFin,2),RIGHT(HeureFin,2),0) - TimeSerial(Left(HeureDébut,2), RIGHT(HeureDébut,2),0)) As Total FROM Punch " +
                                "WHERE NoProjet = '" + m_sNoProjSoum + "' AND Facturé = 1 AND HeureFin IS NOT NULL", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstSomme.Open("SELECT SUM(TimeSerial(Left(HeureFin,2),RIGHT(HeureFin,2),0) - TimeSerial(Left(HeureDébut,2), RIGHT(HeureDébut,2),0)) As Total FROM Punch " +
                                "WHERE NoProjet = '" + m_sNoProjSoum + "' AND Facturé = 1 AND HeureFin IS NOT NULL AND [Date] BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        if (!(rstSomme.Fields["Total"].Value is DBNull))
                        {

                            ControleurServeur.ViewFacturation.lblHeuresFacturees = Math.Round(Operators.MultiplyObject(rstSomme.Fields["Total"].Value, 24), 4);
                        }
                        else
                        {

                            ControleurServeur.ViewFacturation.lblHeuresFacturees.Text = "0";
                        }
                        rstSomme.Close();
                        rstSomme.CursorLocation = CursorLocationEnum.adUseServer;
                        if (_optChoix_0.Checked == true)
                        {
                            //douteux
                            rstSomme.Open("SELECT SUM(TimeSerial(Left(HeureFin,2), RIGHT(HeureFin,2),0) - TimeSerial(Left(HeureDébut,2),RIGHT(HeureDébut,2),0)) As Total FROM Punch " +
                                "WHERE NoProjet = '" + m_sNoProjSoum + "' AND Facturé=0AND HeureFin IS NOT NULL", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstSomme.Open("SELECT SUM(TimeSerial(Left(HeureFin,2), RIGHT(HeureFin,2),0) - TimeSerial(Left(HeureDébut,2),RIGHT(HeureDébut,2),0)) As Total FROM Punch " +
                                "WHERE NoProjet = '" + m_sNoProjSoum + "' AND Facturé=0AND HeureFin IS NOT NULL AND [Date] BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        if (!(rstSomme.Fields["Total"].Value is DBNull))
                        {

                            ControleurServeur.ViewFacturation.lblHeuresNonFacturees = Math.Round(double.Parse(rstSomme.Fields["Total"].Value) * 24, 4);
                        }
                        else
                        {

                            ControleurServeur.ViewFacturation.lblHeuresNonFacturees.Text = "0";
                        }
                        rstSomme.Close();
                        rstSomme = null;

                        ControleurServeur.ViewFacturation.lblGrandTotal.Text = (double.Parse(ControleurServeur.ViewFacturation.lblHeuresFacturees.Text)
                            + double.Parse(ControleurServeur.ViewFacturation.lblHeuresNonFacturees.Text)).ToString();
                        if (_optChoix_0.Checked == true)
                        {
                            ControleurServeur.ViewFacturation.lblDateDebut.Text = "N/A";
                            ControleurServeur.ViewFacturation.lblDateFin.Text = "N/A";
                        }
                        else
                        {
                            ControleurServeur.ViewFacturation.lblDateDebut.Text = mskDateDebut.Text;
                            ControleurServeur.ViewFacturation.lblDateFin.Text = mskDateFin.Text;
                            Form f = new ControleurServeur.ViewFacturation();
                            f.MdiParent = Conteneur.ActiveForm.MdiParent;
                            f.Show();
                        }
                        rstPunch.Close();
                        rstPunch = null;
                    }
                    Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "ImprimerListePunch", ex);
            }
        }
        [Obsolete]
        private void ImprimerPrixCoutant()
        {
            try
            {
                double dblTotal;
                string sProjet;
                ADODB.Recordset rstDS;
                if (_optChoix_1.Checked == true)
                {
                    if (!string.IsNullOrEmpty(mskDateDebut.Text))
                    {
                        if (!string.IsNullOrEmpty(mskDateFin.Text))
                        {
                            if (ValiderDate(mskDateDebut.Text) == true)
                            {
                                if (ValiderDate(mskDateFin.Text) == true)
                                {
                                    if (Operators.CompareString(mskDateDebut.Text, mskDateFin.Text, false) > 0)
                                    {
                                        MessageBox.Show("La date de début doit être plus petite que la date de fin!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Date de fin non valide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Date de début non valide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La date de fin est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La date de début est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (Strings.Len(m_sNoProjSoum) == 9)
                {
                    sProjet = Droite(m_sNoProjSoum, 8);
                }
                else
                {
                    MessageBox.Show("Numéro de projet non valide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ControleurServeur.ViewApercuProjet.lblNumero.Text = sProjet;
                ControleurServeur.ViewApercuProjet.lblClient.Text = m_sClient;
                ControleurServeur.ViewApercuProjet.lblDescription.Text = m_sDescription;
                if (_optChoix_0.Checked == true)
                {
                    ControleurServeur.ViewApercuProjet.lblDate.Text = ConvertDate(DateTime.Today);
                }
                else
                {
                    ControleurServeur.ViewApercuProjet.lblDate.Text = "Du " + mskDateDebut.Text + " au " + mskDateFin.Text;
                }
                RemplirRapportElectrique(sProjet);
                RemplirRapportMecanique(sProjet);
                if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblForfaitElecSoum.Text)) & float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblForfaitMecSoum.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblForfaitElecSoum.Text)
+ double.Parse(ControleurServeur.ViewApercuProjet.lblForfaitMecSoum.Text);
                }
                else if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblForfaitElecSoum.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblForfaitElecSoum.Text);
                }
                else if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblForfaitMecSoum.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblForfaitMecSoum.Text);
                }
                else
                {
                    dblTotal = 0d;
                }
                ControleurServeur.ViewApercuProjet.lblTotalForfaitSoum.Text = dblTotal.ToString();
                if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblForfaitElecProj.Text)) & float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblForfaitMecProj.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblForfaitElecProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblForfaitMecProj.Text);
                }
                else if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblForfaitElecProj.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblForfaitElecProj.Text);
                }
                else if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblForfaitMecProj.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblForfaitMecProj.Text);
                }
                else
                {
                    dblTotal = 0d;
                }
                ControleurServeur.ViewApercuProjet.lblTotalForfaitProj.Text = dblTotal.ToString();
                if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTotalSoum.Text)) & float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecTotalSoum.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTotalSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecTotalSoum.Text);
                    ControleurServeur.ViewApercuProjet.lblTotalHeuresSoum.Text = dblTotal.ToString();
                }
                else if (!float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTotalSoum.Text)) & !float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecTotalSoum.Text)))
                {
                    ControleurServeur.ViewApercuProjet.lblTotalHeuresSoum.Text = "---";
                }
                else if (!float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTotalSoum.Text)))
                {
                    ControleurServeur.ViewApercuProjet.lblTotalHeuresSoum = ControleurServeur.ViewApercuProjet.lblHeuresMecTotalSoum;
                }
                else
                {
                    ControleurServeur.ViewApercuProjet.lblTotalHeuresSoum = ControleurServeur.ViewApercuProjet.lblHeuresElecTotalSoum;
                }
                if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalElecSoum0.Text)) & float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalMecSoum.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblTotalElecSoum0.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblTotalMecSoum.Text);
                    ControleurServeur.ViewApercuProjet.lblGrandTotalSoum.Text = dblTotal.ToString();
                }
                else if (!float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalElecSoum0.Text)) & !float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalMecSoum.Text)))
                {
                    ControleurServeur.ViewApercuProjet.lblGrandTotalSoum.Text = "---";
                }
                else if (!float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalElecSoum0.Text)))
                {
                    ControleurServeur.ViewApercuProjet.lblGrandTotalSoum = ControleurServeur.ViewApercuProjet.lblTotalMecSoum;
                }
                else
                {
                    ControleurServeur.ViewApercuProjet.lblGrandTotalSoum.Text = ControleurServeur.ViewApercuProjet.lblTotalElecSoum0.Text;
                }
                if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTotalProj.Text)) & float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecTotalProj.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTotalProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecTotalProj.Text);
                    ControleurServeur.ViewApercuProjet.lblTotalHeuresProj.Text = dblTotal.ToString();
                }
                else if (!float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTotalProj.Text)) & !float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecTotalProj.Text)))
                {
                    ControleurServeur.ViewApercuProjet.lblTotalHeuresProj.Text = "---";
                }
                else if (!float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTotalProj.Text)))
                {
                    ControleurServeur.ViewApercuProjet.lblTotalHeuresProj = ControleurServeur.ViewApercuProjet.lblHeuresMecTotalProj;
                }
                else
                {
                    ControleurServeur.ViewApercuProjet.lblTotalHeuresProj = ControleurServeur.ViewApercuProjet.lblHeuresElecTotalProj;
                }
                if (float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalElecProj0.Text)) & float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalMecProj.Text)))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblTotalElecProj0.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblTotalMecProj.Text);
                    ControleurServeur.ViewApercuProjet.lblGrandTotalProj.Text = dblTotal.ToString();
                }
                else if (!float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalElecProj0.Text)) & !float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalMecProj.Text)))
                {
                    ControleurServeur.ViewApercuProjet.lblGrandTotalProj.Text = "---";
                }
                else if (!float.IsNaN(float.Parse(ControleurServeur.ViewApercuProjet.lblTotalElecProj0.Text = "")))
                {
                    ControleurServeur.ViewApercuProjet.lblGrandTotalProj = ControleurServeur.ViewApercuProjet.lblTotalMecProj;
                }
                else
                {
                    ControleurServeur.ViewApercuProjet.lblGrandTotalProj.Text = ControleurServeur.ViewApercuProjet.lblTotalElecProj0.Text;
                }
                if ((ControleurServeur.ViewApercuProjet.lblTotalForfaitSoum.Text != "---") & (ControleurServeur.ViewApercuProjet.lblGrandTotalSoum.Text != "---"))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblTotalForfaitSoum.Text) - double.Parse(ControleurServeur.ViewApercuProjet.lblGrandTotalSoum.Text);
                }
                else
                {
                    dblTotal = 0d;
                }
                ControleurServeur.ViewApercuProjet.lblProfitSoum.Text = dblTotal.ToString();
                if ((ControleurServeur.ViewApercuProjet.lblTotalForfaitProj.Text != "---") & (ControleurServeur.ViewApercuProjet.lblGrandTotalProj.Text != "---"))
                {
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblTotalForfaitProj.Text) - double.Parse(ControleurServeur.ViewApercuProjet.lblGrandTotalProj.Text);
                }
                else
                {
                    dblTotal = 0d;
                }
                ControleurServeur.ViewApercuProjet.lblProfitProj.Text = dblTotal.ToString();
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "ImprimerPrixCoutant", ex);
            }
        }
        private void RemplirRapportElectrique(string sProjet)
        {
            try
            {
                ADODB.Recordset rstProjetElec;
                var rstSoumElec = default(ADODB.Recordset);
                ADODB.Recordset rstProjetPieces;
                double dblTotal;
                bool bSoumission;
                int iNbrePersonne;
                var dblHebergement = default(double);
                double dblRepas;
                double dblTransport;
                double dblUniteMobile;
                double dblPrixEmballage;
                double dblTotalResteTemps;
                double dblTotalManuel;
                var dblTotalPieces = default(double);
                rstProjetElec = new Recordset();
                rstProjetElec.Open("SELECT * FROM ProjetElec WHERE IDProjet = 'E" + sProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ControleurServeur.ViewApercuProjet.lblProjetMec.Text = "E" + sProjet;
                if (!rstProjetElec.EOF)
                {
                    bSoumission = false;
                    if (!(rstProjetElec.Fields["IDSoumission"].Value is DBNull))
                    {
                        rstSoumElec = new Recordset();
                        rstSoumElec.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM SoumissionElec " +
                            "WHERE IDSoumission = '", rstProjetElec.Fields["IDSoumission"].Value), "'"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstSoumElec.EOF)
                        {
                            bSoumission = true;
                        }
                        else
                        {
                            rstSoumElec.Close();
                            // Object rstSoumElec peut ne pas etre détruit avant la mise en corbeille
                            rstSoumElec = null;
                        }
                    }
                    if (bSoumission == true)
                    {
                        if (!(rstSoumElec.Fields["MontantForfait"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblForfaitElecSoum.Text = rstSoumElec.Fields["MontantForfait"].Value;
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblForfaitElecSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsDessin"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecDessinSoum.Text = rstSoumElec.Fields["TempsDessin"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecDessinSoum.Text = (double.Parse(rstSoumElec.Fields["TempsDessin"].Value) * double.Parse(rstSoumElec.Fields["TauxDessin"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecDessinSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecDessinSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsFabrication"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecFabricationSoum.Text = rstSoumElec.Fields["TempsFabrication"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecFabricationSoum.Text = $"{double.Parse(rstSoumElec.Fields["TempsFabrication"].Value) * double.Parse(rstSoumElec.Fields["TauxFabrication"].Value)}";
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecFabricationSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecFabricationSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsAssemblage"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecAssemblageSoum.Text = rstSoumElec.Fields["TempsAssemblage"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecAssemblageSoum.Text = (double.Parse(rstSoumElec.Fields["TempsAssemblage"].Value) * double.Parse(rstSoumElec.Fields["TauxAssemblage"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecAssemblageSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecAssemblageSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsProgInterface"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecProgInterfaceSoum.Text = rstSoumElec.Fields["TempsProgInterface"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecProgInterfaceSoum.Text = (double.Parse(rstSoumElec.Fields["TempsProgInterface"].Value) * double.Parse(rstSoumElec.Fields["TauxProgInterface"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecProgInterfaceSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecProgInterfaceSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsProgAutomate"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecProgAutomateSoum.Text = rstSoumElec.Fields["TempsProgAutomate"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecProgAutomateSoum.Text = (double.Parse(rstSoumElec.Fields["TempsProgAutomate"].Value) * double.Parse(rstSoumElec.Fields["TauxProgAutomate"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecProgAutomateSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecProgAutomateSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsProgRobot"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecProgRobotSoum.Text = rstSoumElec.Fields["TempsProgRobot"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecProgRobotSoum.Text = (double.Parse(rstSoumElec.Fields["TempsProgRobot"].Value) * double.Parse(rstSoumElec.Fields["TauxProgRobot"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecProgRobotSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecProgRobotSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsVision"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecVisionSoum.Text = rstSoumElec.Fields["TempsVision"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecVisionSoum.Text = (double.Parse(rstSoumElec.Fields["TempsVision"].Value) * double.Parse(rstSoumElec.Fields["TauxVision"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecVisionSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecVisionSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsTest"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecTestSoum.Text = rstSoumElec.Fields["TempsTest"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecTestSoum.Text = (double.Parse(rstSoumElec.Fields["TempsTest"].Value) * double.Parse(rstSoumElec.Fields["TauxTest"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecTestSoum.Text = rstSoumElec.Fields["TempsTest"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecTestSoum.Text = (double.Parse(rstSoumElec.Fields["TempsTest"].Value) * double.Parse(rstSoumElec.Fields["TauxTest"].Value)).ToString();
                        }
                        if (!(rstSoumElec.Fields["TempsInstallation"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecInstallationSoum.Text = rstSoumElec.Fields["TempsInstallation"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecInstallationSoum.Text = (double.Parse(rstSoumElec.Fields["TempsInstallation"].Value) * double.Parse(rstSoumElec.Fields["TauxInstallation"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecInstallationSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecInstallationSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsMiseService"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecMiseServiceSoum.Text = rstSoumElec.Fields["TempsMiseService"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecMiseServiceSoum.Text = (double.Parse(rstSoumElec.Fields["TempsMiseService"].Value) * double.Parse(rstSoumElec.Fields["TauxMiseService"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecMiseServiceSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecMiseServiceSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsFormation"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecFormationSoum.Text = rstSoumElec.Fields["TempsFormation"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecFormationSoum.Text = (double.Parse(rstSoumElec.Fields["TempsFormation"].Value) * double.Parse(rstSoumElec.Fields["TauxFormation"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecFormationSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecFormationSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsGestion"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecGestionSoum.Text = rstSoumElec.Fields["TempsGestion"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecGestionSoum.Text = (double.Parse(rstSoumElec.Fields["TempsGestion"].Value) * double.Parse(rstSoumElec.Fields["TauxGestion"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecGestionSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecGestionSoum.Text = "0"; ;
                        }
                        if (!(rstSoumElec.Fields["TempsShipping"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecShippingSoum.Text = rstSoumElec.Fields["TempsShipping"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentElecShippingSoum.Text = (double.Parse(rstSoumElec.Fields["TempsShipping"].Value) * double.Parse(rstSoumElec.Fields["TauxShipping"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresElecShippingSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentElecShippingSoum.Text = "0"; ;
                        }
                        ControleurServeur.ViewApercuProjet.lblPiecesElecSoum.Text = rstSoumElec.Fields["total_piece"].Value;
                        ControleurServeur.ViewApercuProjet.lblImprevuElecSoum.Text = rstSoumElec.Fields["total_imprevue"].Value;
                        if (!(rstSoumElec.Fields["NbrePersonne"].Value is DBNull))
                        {
                            iNbrePersonne = int.Parse(rstSoumElec.Fields["NbrePersonne"].Value);
                        }
                        else
                        {
                            iNbrePersonne = 0;
                        }
                        while (iNbrePersonne > 0)
                        {
                            if (iNbrePersonne >= 2)
                            {
                                dblHebergement = double.Parse(Operators.AddObject(dblHebergement, Operators.MultiplyObject(rstSoumElec.Fields["TempsHebergement"].Value, rstSoumElec.Fields["TauxHebergement2"].Value)));
                                iNbrePersonne = (int)(iNbrePersonne - 2);
                            }
                            else
                            {
                                dblHebergement = double.Parse(Operators.AddObject(dblHebergement, Operators.MultiplyObject(rstSoumElec.Fields["TempsHebergement"].Value, rstSoumElec.Fields["TauxHebergement1"].Value)));
                                iNbrePersonne = (int)(iNbrePersonne - 1);
                            }
                        }
                        if (!(rstSoumElec.Fields["TempsRepas"].Value is DBNull))
                        {
                            dblRepas = double.Parse(rstSoumElec.Fields["TempsRepas"].Value) * double.Parse(rstSoumElec.Fields["TauxRepas"].Value) * double.Parse(rstSoumElec.Fields["NbrePersonne"].Value);
                        }
                        else
                        {
                            dblRepas = 0d;
                        }
                        if (!(rstSoumElec.Fields["TempsTransport"].Value is DBNull))
                        {
                            dblTransport = double.Parse(rstSoumElec.Fields["TempsTransport"].Value) * double.Parse(rstSoumElec.Fields["TauxTransport"].Value);
                        }
                        else
                        {
                            dblTransport = 0d;
                        }
                        if (!(rstSoumElec.Fields["TempsUniteMobile"].Value is DBNull))
                        {
                            dblUniteMobile = double.Parse(rstSoumElec.Fields["TempsUniteMobile"].Value) * double.Parse(rstSoumElec.Fields["TauxUniteMobile"].Value);
                        }
                        else
                        {
                            dblUniteMobile = 0d;
                        }
                        if (!(rstSoumElec.Fields["PrixEmballage"].Value is DBNull))
                        {
                            dblPrixEmballage = double.Parse(rstSoumElec.Fields["PrixEmballage"].Value);
                        }
                        else
                        {
                            dblPrixEmballage = 0d;
                        }
                        dblTotalResteTemps = dblHebergement + dblRepas + dblTransport + dblUniteMobile + dblPrixEmballage;
                        if (IsNumeric(rstSoumElec.Fields["total_manuel"].Value))
                        {
                            dblTotalManuel = double.Parse(rstSoumElec.Fields["total_manuel"].Value);
                        }
                        else
                        {
                            dblTotalManuel = 0d;
                        }
                        ControleurServeur.ViewApercuProjet.lblAutresElecSoum.Text = (dblTotalResteTemps + dblTotalManuel).ToString();
                        rstSoumElec.Close();
                        rstSoumElec = null;
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblHeuresElecDessinSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecDessinSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecFabricationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecFabricationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecAssemblageSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecAssemblageSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecProgInterfaceSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecProgInterfaceSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecProgAutomateSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecProgAutomateSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecProgRobotSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecProgRobotSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecVisionSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecVisionSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecTestSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecTestSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecInstallationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecInstallationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecMiseServiceSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecMiseServiceSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecFormationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecFormationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecGestionSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecGestionSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresElecGestionSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentElecGestionSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblPiecesElecSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblImprevuElecSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblAutresElecSoum.Text = "---";
                    }
                    RemplirTempsReelsElec("E" + sProjet);
                    if (!(rstProjetElec.Fields["MontantForfait"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblForfaitElecProj.Text = (string)(rstProjetElec.Fields["MontantForfait"].Value);
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblForfaitElecProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxDessin"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecDessinProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecDessinProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecDessinProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxFabrication"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecFabricationProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecFabricationProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecFabricationProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxAssemblage"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecAssemblageProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecAssemblageProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecAssemblageProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxProgInterface"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecProgInterfaceProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecProgInterfaceProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecProgInterfaceProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxProgAutomate"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecProgAutomateProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecProgAutomateProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecProgAutomateProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxProgRobot"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecProgRobotProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecProgRobotProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecProgRobotProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxVision"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecVisionProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecVisionProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecVisionProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxTest"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecTestProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTestProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecTestProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxInstallation"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecInstallationProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecInstallationProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecInstallationProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxMiseService"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecMiseServiceProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecMiseServiceProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecMiseServiceProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxFormation"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecFormationProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecFormationProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecFormationProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxGestion"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecGestionProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecGestionProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecGestionProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxShipping"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecShippingProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecShippingProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecShippingProj.Text = "0"; ;
                    }
                    if (!(rstProjetElec.Fields["TauxGestion"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecRechercheProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecRechercheProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecRechercheProj.Text = "0"; ;
                    }
                    rstProjetPieces = new Recordset();
                    if (_optChoix_0.Checked == true)
                    {
                        rstProjetPieces.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = 'E" + sProjet + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    }
                    else if (Droite(sProjet, 2) == "99")
                    {
                        rstProjetPieces.Open("SELECT * FROM Projet_Pieces WHERE Left(IDProjet, 6) = '" + Gauche("E" + sProjet, 6) + "' AND DateRéception BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "' AND PieceExtraNonChargeable=0AND PieceExtraChargeable = False", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    }
                    else
                    {
                        rstProjetPieces.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = 'E" + sProjet + "' AND DateRéception BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    }
                    while (!rstProjetPieces.EOF)
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim((string)(rstProjetPieces.Fields["Prix_total"].Value))))
                        {
                            dblTotalPieces = dblTotalPieces + double.Parse(rstProjetPieces.Fields["Prix_total"].Value) - double.Parse(rstProjetPieces.Fields["Profit_Argent"].Value);
                        }
                        rstProjetPieces.MoveNext();
                    }
                    rstProjetPieces.Close();
                    rstProjetPieces = null;
                    ControleurServeur.ViewApercuProjet.lblPiecesElecProj.Text = dblTotalPieces.ToString();
                    ControleurServeur.ViewApercuProjet.lblImprevuElecProj.Text = "0"; ;
                    if (!(rstProjetElec.Fields["PrixEmballage"].Value is DBNull))
                    {
                        dblPrixEmballage = double.Parse(rstProjetElec.Fields["PrixEmballage"].Value);
                    }
                    else
                    {
                        dblPrixEmballage = 0d;
                    }
                    dblTotalResteTemps = dblPrixEmballage;
                    if (IsNumeric(rstProjetElec.Fields["total_manuel"].Value))
                    {
                        dblTotalManuel = double.Parse(rstProjetElec.Fields["total_manuel"].Value);
                    }
                    else
                    {
                        dblTotalManuel = 0d;
                    }
                    ControleurServeur.ViewApercuProjet.lblAutresElecProj.Text = (dblTotalResteTemps + dblTotalManuel).ToString();
                    // Calcul des totaux
                    // Total des temps
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(ControleurServeur.ViewApercuProjet.lblHeuresElecDessinSoum.Text, "---", false)))
                    {
                        dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecDessinSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecFabricationSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecAssemblageSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecProgInterfaceSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecProgAutomateSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecProgRobotSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecVisionSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTestSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecInstallationSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecMiseServiceSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecFormationSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecGestionSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecShippingSoum.Text);
                        ControleurServeur.ViewApercuProjet.lblHeuresElecTotalSoum.Text = dblTotal.ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblHeuresElecTotalSoum.Text = "---";
                    }
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(ControleurServeur.ViewApercuProjet.lblArgentElecDessinSoum.Text, "---", false)))
                    {
                        dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecDessinSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecFabricationSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecAssemblageSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecProgInterfaceSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecProgAutomateSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecProgRobotSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecVisionSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecTestSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecInstallationSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecMiseServiceSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecFormationSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecGestionSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecShippingSoum.Text);
                        ControleurServeur.ViewApercuProjet.lblArgentElecTotalSoum.Text = dblTotal.ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentElecTotalSoum.Text = "---";
                    }
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecDessinProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecFabricationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecAssemblageProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecProgInterfaceProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecProgAutomateProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecProgRobotProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecVisionProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecTestProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecInstallationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecMiseServiceProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecFormationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecGestionProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecShippingProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresElecRechercheProj.Text);
                    ControleurServeur.ViewApercuProjet.lblHeuresElecTotalProj.Text = dblTotal.ToString();
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecDessinProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecFabricationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecAssemblageProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecProgInterfaceProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecProgAutomateProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecProgRobotProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecVisionProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecTestProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecInstallationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecMiseServiceProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecFormationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecGestionProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecShippingProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecRechercheProj.Text);
                    ControleurServeur.ViewApercuProjet.lblArgentElecTotalProj.Text = dblTotal.ToString();
                    if (ControleurServeur.ViewApercuProjet.lblArgentElecTotalSoum.Text != "---")
                    {
                        dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecTotalSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblPiecesElecSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblImprevuElecSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblAutresElecSoum.Text);
                        ControleurServeur.ViewApercuProjet.lblTotalElecSoum0.Text = dblTotal.ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblTotalElecSoum0.Text = "---";
                    }
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblArgentElecTotalProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblPiecesElecProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblImprevuElecProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblAutresElecProj.Text);
                    ControleurServeur.ViewApercuProjet.lblTotalElecProj0.Text = dblTotal.ToString();
                }
                rstProjetElec.Close();
                rstProjetElec = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "RemplirRapportElectrique", ex);
            }
        }
        private void RemplirRapportMecanique(string sProjet)
        {
            try
            {
                ADODB.Recordset rstProjetMec;
                var rstSoumMec = default(ADODB.Recordset);
                ADODB.Recordset rstProjetPieces;
                double dblTotal;
                bool bSoumission;
                int iNbrePersonne;
                var dblHebergement = default(double);
                double dblRepas;
                double dblTransport;
                double dblUniteMobile;
                double dblPrixEmballage;
                double dblTotalResteTemps;
                double dblTotalManuel;
                var dblTotalPieces = default(double);
                rstProjetMec = new Recordset();
                rstProjetMec.Open("SELECT * FROM ProjetMec WHERE IDProjet = 'M" + sProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ControleurServeur.ViewApercuProjet.lblProjetMec.Text = "M" + sProjet;
                if (!rstProjetMec.EOF)
                {
                    bSoumission = false;
                    if (!(rstProjetMec.Fields["IDSoumission"].Value is DBNull))
                    {
                        rstSoumMec = new Recordset();
                        rstSoumMec.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM SoumissionMec WHERE IDSoumission = '", rstProjetMec.Fields["IDSoumission"].Value), "'"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstSoumMec.EOF)
                        {
                            bSoumission = true;
                        }
                        else
                        {
                            rstSoumMec.Close();
                            // Object rstSoumMec peut ne pas etre détruit avant la mise en corbeille
                            rstSoumMec = null;
                        }
                    }
                    if (bSoumission == true)
                    {
                        if (!(rstSoumMec.Fields["MontantForfait"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblForfaitMecSoum.Text = rstSoumMec.Fields["MontantForfait"].Value;
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblForfaitMecSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsDessin"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecDessinSoum.Text = rstSoumMec.Fields["TempsDessin"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecDessinSoum.Text = (double.Parse(rstSoumMec.Fields["TempsDessin"].Value) * double.Parse(rstSoumMec.Fields["TauxDessin"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecDessinSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecDessinSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsCoupe"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecCoupeSoum.Text = rstSoumMec.Fields["TempsCoupe"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecCoupeSoum.Text = (double.Parse(rstSoumMec.Fields["TempsCoupe"].Value) * double.Parse(rstSoumMec.Fields["TauxCoupe"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecCoupeSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecCoupeSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsMachinage"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecMachinageSoum.Text = rstSoumMec.Fields["TempsMachinage"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecMachinageSoum.Text = (double.Parse(rstSoumMec.Fields["TempsMachinage"].Value) * double.Parse(rstSoumMec.Fields["TauxMachinage"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecMachinageSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecMachinageSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsSoudure"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecSoudureSoum.Text = rstSoumMec.Fields["TempsSoudure"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecSoudureSoum.Text = (double.Parse(rstSoumMec.Fields["TempsSoudure"].Value) * double.Parse(rstSoumMec.Fields["TauxSoudure"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecSoudureSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecSoudureSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsAssemblage"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecAssemblageSoum.Text = rstSoumMec.Fields["TempsAssemblage"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecAssemblageSoum.Text = (double.Parse(rstSoumMec.Fields["TempsAssemblage"].Value) * double.Parse(rstSoumMec.Fields["TauxAssemblage"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecAssemblageSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecAssemblageSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsPeinture"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecPeintureSoum.Text = rstSoumMec.Fields["TempsPeinture"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecPeintureSoum.Text = (double.Parse(rstSoumMec.Fields["TempsPeinture"].Value) * double.Parse(rstSoumMec.Fields["TauxPeinture"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecPeintureSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecPeintureSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsTest"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecTestSoum.Text = rstSoumMec.Fields["TempsTest"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecTestSoum.Text = (double.Parse(rstSoumMec.Fields["TempsTest"].Value) * double.Parse(rstSoumMec.Fields["TauxTest"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecTestSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecTestSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsInstallation"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecInstallationSoum.Text = rstSoumMec.Fields["TempsInstallation"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecInstallationSoum.Text = (double.Parse(rstSoumMec.Fields["TempsInstallation"].Value) * double.Parse(rstSoumMec.Fields["TauxInstallation"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecInstallationSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecInstallationSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsFormation"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecFormationSoum.Text = rstSoumMec.Fields["TempsFormation"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecFormationSoum.Text = (double.Parse(rstSoumMec.Fields["TempsFormation"].Value) * double.Parse(rstSoumMec.Fields["TauxFormation"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecFormationSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecFormationSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsGestion"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecGestionSoum.Text = rstSoumMec.Fields["TempsGestion"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecGestionSoum.Text = (double.Parse(rstSoumMec.Fields["TempsGestion"].Value) * double.Parse(rstSoumMec.Fields["TauxGestion"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecGestionSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecGestionSoum.Text = "0"; ;
                        }
                        if (!(rstSoumMec.Fields["TempsShipping"].Value is DBNull))
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecShippingSoum.Text = rstSoumMec.Fields["TempsShipping"].Value;
                            ControleurServeur.ViewApercuProjet.lblArgentMecShippingSoum.Text = (double.Parse(rstSoumMec.Fields["TempsShipping"].Value) * double.Parse(rstSoumMec.Fields["TauxShipping"].Value)).ToString();
                        }
                        else
                        {
                            ControleurServeur.ViewApercuProjet.lblHeuresMecShippingSoum.Text = "0"; ;
                            ControleurServeur.ViewApercuProjet.lblArgentMecShippingSoum.Text = "0"; ;
                        }
                        ControleurServeur.ViewApercuProjet.lblPiecesMecSoum.Text = rstSoumMec.Fields["total_piece"].Value;
                        ControleurServeur.ViewApercuProjet.lblImprevuMecSoum.Text = rstSoumMec.Fields["total_imprevue"].Value;
                        iNbrePersonne = int.Parse(rstSoumMec.Fields["NbrePersonne"].Value);
                        while (iNbrePersonne > 0)
                        {
                            if (iNbrePersonne >= 2)
                            {
                                dblHebergement = double.Parse(Operators.AddObject(dblHebergement, Operators.MultiplyObject(rstSoumMec.Fields["TempsHebergement"].Value, rstSoumMec.Fields["TauxHebergement2"].Value)));
                                iNbrePersonne = (int)(iNbrePersonne - 2);
                            }
                            else
                            {
                                dblHebergement = double.Parse(Operators.AddObject(dblHebergement, Operators.MultiplyObject(rstSoumMec.Fields["TempsHebergement"].Value, rstSoumMec.Fields["TauxHebergement1"].Value)));
                                iNbrePersonne = (int)(iNbrePersonne - 1);
                            }
                        }
                        dblRepas = double.Parse(rstSoumMec.Fields["TempsRepas"].Value) * double.Parse(rstSoumMec.Fields["TauxRepas"].Value) * double.Parse(rstSoumMec.Fields["NbrePersonne"].Value);
                        dblTransport = double.Parse(rstSoumMec.Fields["TempsTransport"].Value) * double.Parse(rstSoumMec.Fields["TauxTransport"].Value);
                        dblUniteMobile = double.Parse(rstSoumMec.Fields["TempsUniteMobile"].Value) * double.Parse(rstSoumMec.Fields["TauxUniteMobile"].Value);
                        if (IsNumeric(rstSoumMec.Fields["PrixEmballage"].Value))
                        {
                            dblPrixEmballage = double.Parse(rstSoumMec.Fields["PrixEmballage"].Value);
                        }
                        else
                        {
                            dblPrixEmballage = 0d;
                        }
                        dblTotalResteTemps = dblHebergement + dblRepas + dblTransport + dblUniteMobile + dblPrixEmballage;
                        if (IsNumeric(rstSoumMec.Fields["total_manuel"].Value))
                        {
                            dblTotalManuel = double.Parse(rstSoumMec.Fields["total_manuel"].Value);
                        }
                        else
                        {
                            dblTotalManuel = 0d;
                        }
                        ControleurServeur.ViewApercuProjet.lblAutresMecSoum.Text = (dblTotalResteTemps + dblTotalManuel).ToString();
                        rstSoumMec.Close();
                        // Object rstSoumMec peut ne pas etre détruit avant la mise en corbeille
                        rstSoumMec = null;
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblHeuresMecDessinSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecDessinSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecCoupeSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecCoupeSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecMachinageSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecMachinageSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecSoudureSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecSoudureSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecAssemblageSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecAssemblageSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecPeintureSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecPeintureSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecTestSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecTestSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecInstallationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecInstallationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecFormationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecFormationSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecGestionSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecGestionSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblHeuresMecShippingSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblArgentMecShippingSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblPiecesMecSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblImprevuMecSoum.Text = "---";
                        ControleurServeur.ViewApercuProjet.lblAutresMecSoum.Text = "---";
                    }
                    RemplirTempsReelsMec("M" + sProjet);

                    if (!(rstProjetMec.Fields["MontantForfait"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblForfaitMecProj.Text = rstProjetMec.Fields["MontantForfait"].Value;
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblForfaitMecProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxDessin"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecDessinProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecDessinProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecDessinProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxCoupe"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecCoupeProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecCoupeProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecCoupeProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxMachinage"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecMachinageProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecMachinageProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecMachinageProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxSoudure"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecSoudureProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecSoudureProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecSoudureProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxAssemblage"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecAssemblageProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecAssemblageProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecAssemblageProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxPeinture"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecPeintureProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecPeintureProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecPeintureProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxTest"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecTestProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecTestProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecTestProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxInstallation"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecInstallationProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecInstallationProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecInstallationProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxFormation"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecFormationProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecFormationProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecFormationProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxGestion"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecGestionProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecGestionProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecGestionProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxShipping"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecShippingProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecShippingProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecShippingProj.Text = "0"; ;
                    }
                    if (!(rstProjetMec.Fields["TauxGestion"].Value is DBNull))
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecRechercheProj.Text = (double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecRechercheProj.Text) * 50).ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecRechercheProj.Text = "0"; ;
                    }
                    rstProjetPieces = new Recordset();
                    if (_optChoix_0.Checked == true)
                    {
                        rstProjetPieces.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = 'M" + sProjet + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    }
                    else if (Droite(sProjet, 2) == "99")
                    {
                        rstProjetPieces.Open("SELECT * FROM Projet_Pieces WHERE Left(IDProjet, 6) = '" + Gauche("M" + sProjet, 6) + "' AND DateRéception BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "' AND PieceExtraNonChargeable=0AND PieceExtraChargeable = False", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    }
                    else
                    {
                        rstProjetPieces.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = 'M" + sProjet + "' AND DateRéception BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                    }
                    while (!rstProjetPieces.EOF)
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim(rstProjetPieces.Fields["Prix_total"].Value)))
                        {
                            dblTotalPieces = dblTotalPieces + double.Parse(rstProjetPieces.Fields["Prix_total"].Value) - double.Parse(rstProjetPieces.Fields["Profit_argent"].Value);
                        }
                        rstProjetPieces.MoveNext();
                    }
                    rstProjetPieces.Close();
                    rstProjetPieces = null;
                    ControleurServeur.ViewApercuProjet.lblPiecesMecProj.Text = dblTotalPieces.ToString();
                    ControleurServeur.ViewApercuProjet.lblImprevuMecProj.Text = "0"; ;
                    if (IsNumeric(rstProjetMec.Fields["PrixEmballage"].Value))
                    {
                        dblPrixEmballage = double.Parse(rstProjetMec.Fields["PrixEmballage"].Value);
                    }
                    else
                    {
                        dblPrixEmballage = 0d;
                    }
                    dblTotalResteTemps = dblPrixEmballage;
                    if (IsNumeric(rstProjetMec.Fields["total_manuel"].Value))
                    {
                        dblTotalManuel = double.Parse(rstProjetMec.Fields["total_manuel"].Value);
                    }
                    else
                    {
                        dblTotalManuel = 0d;
                    }
                    ControleurServeur.ViewApercuProjet.lblAutresMecProj.Text = (dblTotalResteTemps + dblTotalManuel).ToString();
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(ControleurServeur.ViewApercuProjet.lblHeuresMecDessinSoum.Text, "---", false)))
                    {
                        dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecDessinSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecCoupeSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecMachinageSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecSoudureSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecAssemblageSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecPeintureSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecTestSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecInstallationSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecFormationSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecGestionSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecShippingSoum.Text);
                        ControleurServeur.ViewApercuProjet.lblHeuresMecTotalSoum.Text = dblTotal.ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblHeuresMecTotalSoum.Text = "---";
                    }
                    if (ControleurServeur.ViewApercuProjet.lblArgentMecDessinSoum.Text != "---")
                    {
                        dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecDessinSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecCoupeSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecMachinageSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecSoudureSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecAssemblageSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecPeintureSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecTestSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecInstallationSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecFormationSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecGestionSoum.Text)
                            + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecShippingSoum.Text);
                        ControleurServeur.ViewApercuProjet.lblArgentMecTotalSoum.Text = dblTotal.ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblArgentMecTotalSoum.Text = "---";
                    }
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecDessinProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecCoupeProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecMachinageProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecSoudureProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecAssemblageProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecPeintureProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecTestProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecInstallationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecFormationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecGestionProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecShippingProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblHeuresMecRechercheProj.Text);
                    ControleurServeur.ViewApercuProjet.lblHeuresMecTotalProj.Text = dblTotal.ToString();
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecDessinProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecCoupeProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecMachinageProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecSoudureProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecAssemblageProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecPeintureProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecTestProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecInstallationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecFormationProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecGestionProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecShippingProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecRechercheProj.Text);
                    ControleurServeur.ViewApercuProjet.lblArgentMecTotalProj.Text = dblTotal.ToString();
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(ControleurServeur.ViewApercuProjet.lblArgentMecTotalSoum.Text, "---", false)))
                    {
                        dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecTotalSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblPiecesMecSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblImprevuMecSoum.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblAutresMecSoum.Text);
                        ControleurServeur.ViewApercuProjet.lblTotalMecSoum.Text = dblTotal.ToString();
                    }
                    else
                    {
                        ControleurServeur.ViewApercuProjet.lblTotalMecSoum.Text = "---";
                    }
                    dblTotal = double.Parse(ControleurServeur.ViewApercuProjet.lblArgentMecTotalProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblPiecesMecProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblImprevuMecProj.Text) + double.Parse(ControleurServeur.ViewApercuProjet.lblAutresMecProj.Text);
                    ControleurServeur.ViewApercuProjet.lblTotalMecProj.Text = dblTotal.ToString();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "RemplirRapportMecanique", ex);
            }
        }
        private void RemplirTempsReelsElec(string sProjet)
        {
            try
            {
                ADODB.Recordset rstPunch;
                string sFilterNoProjet;
                string Compile1;
                string Compile2;
                Compile1 = 0.ToString();
                Compile2 = 0.ToString();
                if (Droite(sProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(sProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + sProjet + "'";
                }
                string sDateDebut = "TIMESERIAL(Left(Punch.HeureDébut,2),RIGHT(Punch.HeureDébut,2),0)";
                string sDateFin = "TIMESERIAL(Left(Punch.HeureFin,2),RIGHT(Punch.HeureFin,2),0)";
                string sTotal = "(SUM(" + sDateFin + " - " + sDateDebut + ")* 24) As Total";
                rstPunch = new Recordset();
                if (_optChoix_0.Checked == true)
                {
                    rstPunch.Open("SELECT Type, " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null GROUP BY Type", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                }
                else
                {
                    rstPunch.Open("SELECT Type, " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " AND HeureFin Is Not Null AND HeureDébut Is not Null AND [Date] BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "' GROUP BY Type", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                }
                ControleurServeur.ViewApercuProjet.lblHeuresElecDessinProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecFabricationProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecAssemblageProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecProgInterfaceProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecProgAutomateProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecProgRobotProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecVisionProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecTestProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecInstallationProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecMiseServiceProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecFormationProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecGestionProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecShippingProj.Text = "0"; ;
                ControleurServeur.ViewApercuProjet.lblHeuresElecRechercheProj.Text = "0"; ;
                while (!rstPunch.EOF)
                {
                    if (!(rstPunch.Fields["Total"].Value is DBNull))
                    {
                        switch (rstPunch.Fields["Type"].Value)
                        {
                            case "Dessin":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecDessinProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Fabrication":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecFabricationProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Assemblage":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecAssemblageProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "ProgInterface":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecProgInterfaceProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "ProgAutomate":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecProgAutomateProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "ProgRobot":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecProgRobotProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Vision":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecVisionProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Test":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecTestProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Installation":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecInstallationProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "MiseService":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecMiseServiceProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Formation":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecFormationProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Gestion":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecGestionProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Shipping":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresElecShippingProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Prototypage-Dévelloppement expérimental":
                                {
                                    Compile1 = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "":
                                {
                                    Compile2 = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                        }
                    }
                    rstPunch.MoveNext();
                }
                ControleurServeur.ViewApercuProjet.lblHeuresElecRechercheProj.Text = (double.Parse(Compile1) + double.Parse(Compile2)).ToString();
                rstPunch.Close();
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ProjSoumElecTemps", "RemplirTempsReelsElec", ex);
            }
        }
        private void RemplirTempsReelsMec(string sProjet)
        {
            try
            {
                ADODB.Recordset rstPunch;
                string sDateDebut;
                string sDateFin;
                string sTotal;
                string sFilterNoProjet;
                string test;
                string Compile1;
                string Compile2;
                Compile1 = 0.ToString();
                Compile2 = 0.ToString();
                if (Droite(sProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(sProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + sProjet + "'";
                }
                sDateDebut = "TIMESERIAL(Left(Punch.HeureDébut,2),RIGHT(Punch.HeureDébut,2),0)";
                sDateFin = "TIMESERIAL(Left(Punch.HeureFin,2),RIGHT(Punch.HeureFin,2),0)";
                sTotal = "(SUM(" + sDateFin + " - " + sDateDebut + ")* 24) As Total";
                rstPunch = new Recordset();
                if (_optChoix_0.Checked == true)
                {
                    rstPunch.Open("SELECT Type, " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null GROUP BY Type", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                }
                else
                {
                    rstPunch.Open("SELECT Type, " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " AND HeureFin Is Not Null AND HeureDébut Is Not Null AND [Date] BETWEEN '" + mskDateDebut.Text + "' AND '" + mskDateFin.Text + "' GROUP BY Type", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                }
                ControleurServeur.ViewApercuProjet.lblHeuresMecDessinProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecCoupeProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecMachinageProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecSoudureProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecAssemblageProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecPeintureProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecTestProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecInstallationProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecFormationProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecGestionProj.Text = "0";
                ControleurServeur.ViewApercuProjet.lblHeuresMecShippingProj.Text = "0";
                while (!rstPunch.EOF)
                {
                    if (!(rstPunch.Fields["Total"].Value is DBNull))
                    {
                        switch (rstPunch.Fields["Type"].Value)
                        {
                            case "Dessin":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecDessinProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Coupe":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecCoupeProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Machinage":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecMachinageProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Soudure":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecSoudureProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Assemblage":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecAssemblageProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Peinture":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecPeintureProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Test":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecTestProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Installation":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecInstallationProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Formation":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecFormationProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Gestion":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecGestionProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Shipping":
                                {
                                    ControleurServeur.ViewApercuProjet.lblHeuresMecShippingProj.Text = Math.Round(rstPunch.Fields["Total"].Value, 2);
                                    break;
                                }
                            case "Prototypage-Dévelloppement expérimental":
                                {
                                    Compile1 = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                            case "":
                                {
                                    Compile2 = (string)(Math.Round(rstPunch.Fields["Total"].Value, 2));
                                    break;
                                }
                        }
                    }
                    rstPunch.MoveNext();
                }
                ControleurServeur.ViewApercuProjet.lblHeuresMecRechercheProj.Text = (double.Parse(Compile1) + double.Parse(Compile2)).ToString();
                rstPunch.Close();
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "RemplirTempsReelsElec", ex);
            }
        }
        private void ChoixDateImpressionFacturation_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "Form_Click", ex);
            }
        }
        private void ChoixDateImpressionFacturation_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                _optChoix_0.Checked = true;
                _optChoixProjetEntier_0.Checked = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "Form_Load", ex);
            }
        }
        private void mvwDate_DateClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                switch (m_eDate)
                {
                    case enumDate.DEBUT: { mskDateDebut.Text = ConvertDate(mskDateFin.Value); break; }
                    case enumDate.Fin: { mskDateFin.Text = ConvertDate(mskDateFin.Value); break; }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "mvwDate_DateClick", ex);
            }
        }
        private void cmdDateDebut_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Si il y a une date valide, la date par défaut est celle-ci, sinon c'est la date
                if (!string.IsNullOrEmpty(mskDateDebut.Text.Trim()))
                {
                    if (ValiderDate(mskDateDebut.Text) == true)
                    {
                        mskDateFin.Value = Conversions.ToDate(mskDateDebut.Text);
                    }
                    else
                    {
                        mskDateFin.Value = DateTime.Today;
                    }
                }
                else
                {
                    mskDateFin.Value = DateTime.Today;
                }
                m_eDate = enumDate.DEBUT;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "cmdDateDebut_Click", ex);
            }
        }
        private void cmdDateFin_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(mskDateFin.Text.Trim()))
                {
                    if (ValiderDate(mskDateFin.Text) == true)
                    {
                        mskDateFin.Value = Conversions.ToDate(mskDateFin.Text);
                    }
                    else
                    {
                        mskDateFin.Value = DateTime.Today;
                    }
                }
                else
                {
                    mskDateFin.Value = DateTime.Today;
                }
                m_eDate = enumDate.Fin;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "cmdDateFin_Click", ex);
            }
        }
        private void CreerTableau(ref ADODB.Recordset rstProjets, ref ADODB.Recordset rstEmployes, int iDebut, string sDateDebut, string sDateFin)
        {
            try
            {
                int X;
                int iNbreProjets = (int)rstProjets.RecordCount;
                int iNbreEmployes = (int)rstEmployes.RecordCount;
                var sLettre = default(string);
                m_xlsApp.Cells[iDebut, 1] = $"DU {GetDateTexte(Conversions.ToDate(sDateDebut)).ToUpper()} AU {GetDateTexte(Conversions.ToDate(sDateFin)).ToUpper()}";
                m_xlsApp.Range["A" + iDebut].Font.Bold = true;
                //soulignement simple
                m_xlsApp.Range["A" + iDebut].Font.Underline = XlUnderlineStyle.xlUnderlineStyleSingle;
                m_xlsApp.Range["A" + iDebut].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                m_xlsApp.Range["A" + iDebut].Font.Size = 18;
                m_xlsApp.Range[$"A{iDebut}:AB{iDebut}"].Merge();
                m_xlsApp.Columns["A:A"].ColumnWidth = 21;
                m_xlsApp.Columns["B:AB"].ColumnWidth = 5;
                m_xlsApp.Columns["AB:AB"].ColumnWidth = 6.29d;
                m_xlsApp.Range[$"B{iDebut + 3}:AB{iDebut + 3}"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                m_xlsApp.Range[$"B{iDebut + 3}:AB{iDebut + 3}"].VerticalAlignment = XlHAlign.xlHAlignCenter;
                m_xlsApp.Range[$"B{iDebut + 3}:AB{iDebut + 3}"].Orientation = 90;
                for (X = 2; X <= 27; X++)
                {
                    if (rstProjets.EOF == true)
                    {
                        break;
                    }
                    else
                    {
                        m_xlsApp.Cells[iDebut + 3, X] = rstProjets.Fields["NoProjet"].Value;
                        rstProjets.MoveNext();
                    }
                }
                m_xlsApp.Cells[iDebut + 3, 28] = "TOTAL";
                if (!rstProjets.EOF)
                {
                    rstEmployes.MoveFirst();
                    for (X = 4; X <= iNbreEmployes + 3; X++)
                    {
                        m_xlsApp.Cells[(iDebut + X), 1] = rstEmployes.Fields["Employe"].Value;
                        rstEmployes.MoveNext();
                    }
                    m_xlsApp.Cells[(iDebut + X), 1] = "TOTAL";
                    m_xlsApp.Range[$"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}"].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeLeft].Weight = XlBorderWeight.xlMedium;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeLeft].ColorIndex = XlBorderWeight.xlMedium;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeTop].Weight = XlBorderWeight.xlMedium;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeTop].ColorIndex = XlColorIndex.xlColorIndexAutomatic;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeBottom].ColorIndex = XlColorIndex.xlColorIndexAutomatic;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlMedium;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeRight].ColorIndex = XlColorIndex.xlColorIndexAutomatic;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlInsideVertical].Weight = XlBorderWeight.xlThin;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlInsideVertical].ColorIndex = XlColorIndex.xlColorIndexAutomatic;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlInsideHorizontal].Weight = XlBorderWeight.xlThin;
                    m_xlsApp.Range[$"A{(iDebut + 3)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlInsideHorizontal].ColorIndex = XlColorIndex.xlColorIndexAutomatic;
                    m_xlsApp.Range[$"B{iDebut + 3}:AA{iDebut + iNbreEmployes + 4}"].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"B{iDebut + 3}:AA{iDebut + iNbreEmployes + 4}"].Borders[XlBordersIndex.xlEdgeLeft].Weight = XlBorderWeight.xlMedium;
                    m_xlsApp.Range[$"B{iDebut + 3}:AA{iDebut + iNbreEmployes + 4}"].Borders[XlBordersIndex.xlEdgeLeft].ColorIndex = XlColorIndex.xlColorIndexAutomatic;
                    m_xlsApp.Range[$"B{iDebut + 3}:AA{iDebut + iNbreEmployes + 4}"].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"B{iDebut + 3}:AA{iDebut + iNbreEmployes + 4}"].Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlMedium;
                    m_xlsApp.Range[$"B{iDebut + 3}:AA{iDebut + iNbreEmployes + 4}"].Borders[XlBordersIndex.xlEdgeRight].ColorIndex = XlColorIndex.xlColorIndexAutomatic;
                    m_xlsApp.Range[$"A{iDebut + 3}:AB{iDebut + 3}"].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"A{iDebut + 3}:AB{iDebut + 3}"].Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
                    m_xlsApp.Range[$"A{iDebut + 3}:AB{iDebut + 3}"].Borders[XlBordersIndex.xlEdgeBottom].ColorIndex = XlColorIndex.xlColorIndexAutomatic;
                    m_xlsApp.Range[$"A{(iDebut + iNbreEmployes + 4)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    m_xlsApp.Range[$"A{(iDebut + iNbreEmployes + 4)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeTop].Weight = XlBorderWeight.xlMedium;
                    m_xlsApp.Range[$"A{(iDebut + iNbreEmployes + 4)}:AB{(iDebut + iNbreEmployes + 4)}"].Borders[XlBordersIndex.xlEdgeTop].ColorIndex = XlColorIndex.xlColorIndexAutomatic;
                    for (X = (iDebut + 4); X <= (iNbreEmployes + iDebut + 4); X++)
                    {
                        m_xlsApp.Cells[$"AB{X}"] = $"=SUM(B{X}:AA{X})";
                    }
                    for (X = 2; X <= 27; X++)
                    {
                        switch (X)
                        {
                            case 2: { sLettre = "B"; break; }
                            case 3: { sLettre = "C"; break; }
                            case 4: { sLettre = "D"; break; }
                            case 5: { sLettre = "E"; break; }
                            case 6: { sLettre = "F"; break; }
                            case 7: { sLettre = "G"; break; }
                            case 8: { sLettre = "H"; break; }
                            case 9: { sLettre = "I"; break; }
                            case 10: { sLettre = "J"; break; }
                            case 11: { sLettre = "K"; break; }
                            case 12: { sLettre = "L"; break; }
                            case 13: { sLettre = "M"; break; }
                            case 14: { sLettre = "N"; break; }
                            case 15: { sLettre = "O"; break; }
                            case 16: { sLettre = "P"; break; }
                            case 17: { sLettre = "Q"; break; }
                            case 18: { sLettre = "R"; break; }
                            case 19: { sLettre = "S"; break; }
                            case 20: { sLettre = "T"; break; }
                            case 21: { sLettre = "U"; break; }
                            case 22: { sLettre = "V"; break; }
                            case 23: { sLettre = "W"; break; }
                            case 24: { sLettre = "X"; break; }
                            case 25: { sLettre = "Y"; break; }
                            case 26: { sLettre = "Z"; break; }
                            case 27: { sLettre = "AA"; break; }
                        }
                        m_xlsApp.Cells[$"{sLettre}{(iDebut + iNbreEmployes + 4)}"].Text = $"=SUM({sLettre}{(iDebut + 4)}:{sLettre}{(iDebut + iNbreEmployes + 3)})";
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "CréerTableau", ex);
            }
        }
        private void TransfererValeurs(string sDateDebut, string sDateFin)
        {
            try
            {
                ADODB.Recordset rstSource;
                ADODB.Recordset rstDestination;
                string sDate;
                string sHeure;
                string sMinute;
                double dblResult;
                DateTime datTemp;
                rstSource = new Recordset();
                rstSource.Open("SELECT * FROM Punch WHERE Date BETWEEN '" + sDateDebut + "' AND '" + sDateFin + "' AND HeureFin Is Not Null", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                if (!rstSource.EOF)
                {
                    //UpdateSQL("DELETE FROM PunchExcel");
                    rstDestination = new Recordset();
                    rstDestination.Open("SELECT * FROM PunchExcel", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstSource.EOF)
                    {
                        rstDestination.AddNew();
                        rstDestination.Fields["NoEmploye"].Value = rstSource.Fields["NoEmploye"].Value;
                        rstDestination.Fields["NoProjet"].Value = rstSource.Fields["NoProjet"].Value;
                        sHeure = Gauche(Conversions.ToString(rstSource.Fields["HeureDébut"].Value), 2);
                        sMinute = Droite(Conversions.ToString(rstSource.Fields["HeureDébut"].Value), 2);
                        dblResult = Conversions.ToShort(sMinute) / 60d;
                        if (dblResult != 0d)
                        {
                            rstDestination.Fields["HeureDébut"].Value = sHeure + "," + Droite(dblResult.ToString(), Strings.Len(dblResult.ToString()) - Strings.InStr(1, dblResult.ToString(), ","));
                        }
                        else
                        {
                            rstDestination.Fields["HeureDébut"].Value = Conversions.ToShort(sHeure);
                        }
                        sHeure = Gauche(Conversions.ToString(rstSource.Fields["HeureFin"].Value), 2);
                        sMinute = Droite(Conversions.ToString(rstSource.Fields["HeureFin"].Value), 2);
                        dblResult = Conversions.ToShort(sMinute) / 60d;
                        if (dblResult != 0d)
                        {
                            rstDestination.Fields["HeureFin"].Value = Conversions.ToShort(sHeure) + "," + Conversions.ToShort(Droite(dblResult.ToString(), Strings.Len(dblResult.ToString()) - Strings.InStr(1, dblResult.ToString(), ",")));
                        }
                        else
                        {
                            rstDestination.Fields["HeureFin"].Value = sHeure;
                        }
                        rstDestination.Update();
                        rstSource.MoveNext();
                    }
                    rstDestination.Close();
                    rstDestination = null;
                }
                rstSource.Close();
                rstSource = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "TransfererValeurs", ex);
            }
        }
        private void RemplirValeurs(int iNbrePages)
        {
            try
            {
                ADODB.Recordset rstPunch;
                string sNom;
                int iIndexNom;
                int X;
                int iPage;
                int iPageRendu;
                int iNoRendu;
                var iDebutPage = default(int);
                var iIndexProjet = default(int);
                bool bProjetTrouve;
                rstPunch = new Recordset();
                rstPunch.Open("SELECT EMPLOYE, NOPROJET, HEUREFIN,HEUREDÉBUT FROM PUNCHEXCEL " +
                    "INNER JOIN EMPLOYÉS ON PUNCHEXCEL.NOEMPLOYE = EMPLOYÉS.NOEMPLOYE  " +
                    "ORDER BY EMPLOYE, NOPROJET, RIGHT(NOPROJET, 9),HEUREFIN,HEUREDÉBUT", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                int counter;
                if (!rstPunch.EOF)
                {
                    iIndexNom = 4;
                    sNom = (string)(rstPunch.Fields["Employe"].Value);
                    iPageRendu = 1;
                    iNoRendu = 2;
                    while (!rstPunch.EOF)
                    {
                        if (sNom == rstPunch.Fields["Employe"].Value)
                        {
                            sNom = (string)(rstPunch.Fields["Employe"].Value);
                            iIndexNom = (int)(iIndexNom + 1);
                            iPageRendu = 1;
                            iNoRendu = 2;
                        }
                        else if (iNoRendu > 2)
                        {
                            iNoRendu = (int)(iNoRendu - 1);
                        }
                        else if (iPageRendu > 1)
                        {
                            iPageRendu = (int)(iPageRendu - 1);
                            iNoRendu = 27;
                        }
                        bProjetTrouve = false;
                        counter = iPageRendu;
                        for (iPage = counter; iPage <= iNbrePages; iPage++)
                        {
                            if (iPageRendu != iPage)
                            {
                                iNoRendu = 2;
                            }
                            iDebutPage = (int)(iPage * 43 - 42);
                            counter = iNoRendu;
                            for (X = counter; X <= 27; X++)
                            {
                                if (m_xlsApp.Cells[(iDebutPage + 3, X)] == rstPunch.Fields["NoProjet"].Value)
                                {
                                    iIndexProjet = X;
                                    iPageRendu = iPage;
                                    iNoRendu = X;
                                    bProjetTrouve = true;
                                    break;
                                }
                            }
                            if (bProjetTrouve == true)
                            {
                                break;
                            }
                        }
                        if (bProjetTrouve == false)
                        {
                            string msg = $"Le # {rstPunch.Fields["NoProjet"].Value} n'a pas pu être trouvé pour l'employé {sNom})\nSon temps de {rstPunch.Fields["Total"].Value} heures sera ajouté à cet endroit : \nPage   : {iPageRendu},\nRangée : {iIndexProjet}";
                            MessageBox.Show(msg);
                        }
                        m_xlsApp.Cells[(iDebutPage + iIndexNom), iIndexProjet] = float.Parse(rstPunch.Fields["HEUREFIN"].Value) - float.Parse(rstPunch.Fields["HEUREDÉBUT"].Value);
                        rstPunch.MoveNext();
                    }
                }
                rstPunch.Close();
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "RemplirValeurs", ex);
            }
        }
        private void ExporterPunch()
        {
            try
            {
                ADODB.Recordset rstEmployes;
                ADODB.Recordset rstProjets;
                Microsoft.Office.Interop.Excel.Workbook xlsWorkBook;
                int iNbreEmployes;
                int iNbreProjets;
                int iNbrePages;
                int iPage;
                string sDateDebut;
                string sDateFin;
                Cursor.Current = Cursors.WaitCursor;
                rstEmployes = new Recordset();
                rstProjets = new Recordset();
                rstEmployes.CursorLocation = CursorLocationEnum.adUseClient;
                rstProjets.CursorLocation = CursorLocationEnum.adUseClient;
                sDateDebut = mskDateDebut.Text;
                sDateFin = mskDateFin.Text;
                rstProjets.Open("SELECT DISTINCT NoProjet, RIGHT(NoProjet, 9) FROM Punch " +
                    "WHERE Date BETWEEN '" + sDateDebut + "' AND '" + sDateFin + "' ORDER BY RIGHT(NoProjet, 9)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstEmployes.Open("SELECT DISTINCT Employe FROM Punch " +
                    "INNER JOIN Employés ON Employés.NoEmploye = Punch.NoEmploye " +
                    "WHERE Date BETWEEN '" + sDateDebut + "' AND '" + sDateFin + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                iNbreEmployes = (int)rstEmployes.RecordCount;
                iNbreProjets = (int)rstProjets.RecordCount;
                if (iNbreProjets > 26)
                {
                    iNbrePages = (int)Math.Round(Conversion.Int(iNbreProjets / 26d));
                    if (iNbrePages * 26 < iNbreProjets)
                    {
                        iNbrePages = (int)(iNbrePages + 1);
                    }
                }
                else
                {
                    iNbrePages = 1;
                }
                m_xlsApp = new Microsoft.Office.Interop.Excel.Application();
                xlsWorkBook = m_xlsApp.Workbooks.Add(string.Empty);
                for (iPage = 1; iPage <= iNbrePages; iPage++)
                    CreerTableau(ref rstProjets, ref rstEmployes, (int)(iPage * 43 - 42), sDateDebut, sDateFin);
                rstProjets.Close();
                rstEmployes.Close();
                rstProjets = null;
                rstEmployes = null;
                TransfererValeurs(sDateDebut, sDateFin);
                RemplirValeurs(iNbrePages);
                m_xlsApp.ActiveSheet.PageSetup.LeftMargin = m_xlsApp.Application.InchesToPoints(0);
                m_xlsApp.ActiveSheet.PageSetup.RightMargin = m_xlsApp.Application.InchesToPoints(0);
                m_xlsApp.ActiveSheet.PageSetup.TopMargin = m_xlsApp.Application.InchesToPoints(0);
                m_xlsApp.ActiveSheet.PageSetup.BottomMargin = m_xlsApp.Application.InchesToPoints(0);
                m_xlsApp.ActiveSheet.PageSetup.HeaderMargin = m_xlsApp.Application.InchesToPoints(0);
                m_xlsApp.ActiveSheet.PageSetup.FooterMargin = m_xlsApp.Application.InchesToPoints(0);
                m_xlsApp.ActiveSheet.PageSetup.CenterHorizontally = true;
                m_xlsApp.ActiveSheet.PageSetup.CenterVertically = false;
                m_xlsApp.ActiveSheet.PageSetup.Orientation = XlPageOrientation.xlLandscape;
                /// format de la page A4
                m_xlsApp.ActiveSheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
                Cursor.Current = Cursors.Default;
                m_xlsApp.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "ExporterPunch", ex);
            }
        }
        private bool ValiderDate(string sDate)
        {
            bool ValiderDateRet = default;
            try
            {
                // Validation des dates
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
                AfficherErreur("ChoixDateImpressionFacturation", "ValiderDate", ex);
                return false;
            }
        }
        private void _optChoix_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (_optChoix_0.Checked == true)
            {
                fra2Dates.Enabled = false;
            }
            else
            {
                fra2Dates.Enabled = true;
            }
        }
        private void _optChoix_0_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void _optChoixProjetEntier_0_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void _optChoixProjetEntier_1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void _optChoix_1_CheckedChanged(object sender, EventArgs e)
        {
            if (_optChoix_1.Checked)
            {
                _optChoix_0.Checked = false;
                _optChoixProjetEntier_0.Checked = false;
                _optChoixProjetEntier_1.Checked = false;
                fra2Dates.Enabled = true;
                _optChoix_0.Enabled = false;
                _optChoixProjetEntier_0.Enabled = false;
                _optChoixProjetEntier_1.Enabled = false;
                mskDateDebut.Value = DateTime.Today.AddDays(-1);
                mskDateFin.Value = DateTime.Now.AddDays(2);
            }
        }
        private void cmdExporter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValiderDate(mskDateDebut.Text) == false)
                {
                    MessageBox.Show("Date de début invalide!", Application.ProductName + ".Calendrier.Verif", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ValiderDate(mskDateFin.Text) == false)
                {
                    MessageBox.Show("Date de fin invalide!", Application.ProductName + ".Calendrier.Verif", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Operators.CompareString(mskDateFin.Text, mskDateDebut.Text, false) < 0)
                {
                    MessageBox.Show("La date de fin doit être plus grande que la date de début!", Application.ProductName + ".Calendrier.Verif", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ExporterPunch();
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFacturation", "cmdExporter_Click", ex);
            }
        }
    }
}