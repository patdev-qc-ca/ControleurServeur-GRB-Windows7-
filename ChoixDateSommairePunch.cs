using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ControleurServeur;
using ADODB;
using System.Diagnostics;

namespace ControleurServeur
{
    internal class ChoixDateSommairePunch : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixDateSommairePunch() : base()
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
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal ColumnHeader _lvwFamille_ColumnHeader_1;
        internal ListView lvwFamille;
        internal RadioButton _optProjets_2;
        internal RadioButton _optProjets_1;
        internal RadioButton _optProjets_0;
        internal Button cmdAnnuler;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        internal Button cmdImprimer;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lvwFamille = new System.Windows.Forms.ListView();
            this._lvwFamille_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._optProjets_2 = new System.Windows.Forms.RadioButton();
            this._optProjets_1 = new System.Windows.Forms.RadioButton();
            this._optProjets_0 = new System.Windows.Forms.RadioButton();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(47, 177);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(49, 17);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Début :";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(47, 209);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(49, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Fin :";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(103, 161);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(73, 17);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "AA-MM-JJ";
            // 
            // lvwFamille
            // 
            this.lvwFamille.BackColor = System.Drawing.Color.Black;
            this.lvwFamille.CheckBoxes = true;
            this.lvwFamille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwFamille_ColumnHeader_1});
            this.lvwFamille.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFamille.ForeColor = System.Drawing.Color.Navy;
            this.lvwFamille.FullRowSelect = true;
            this.lvwFamille.GridLines = true;
            this.lvwFamille.HideSelection = false;
            this.lvwFamille.Location = new System.Drawing.Point(40, 251);
            this.lvwFamille.Name = "lvwFamille";
            this.lvwFamille.Size = new System.Drawing.Size(243, 143);
            this.lvwFamille.TabIndex = 15;
            this.lvwFamille.UseCompatibleStateImageBehavior = false;
            this.lvwFamille.View = System.Windows.Forms.View.Details;
            // 
            // _lvwFamille_ColumnHeader_1
            // 
            this._lvwFamille_ColumnHeader_1.Text = "Famille";
            this._lvwFamille_ColumnHeader_1.Width = 236;
            // 
            // _optProjets_2
            // 
            this._optProjets_2.BackColor = System.Drawing.Color.Black;
            this._optProjets_2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optProjets_2.ForeColor = System.Drawing.Color.White;
            this._optProjets_2.Location = new System.Drawing.Point(40, 132);
            this._optProjets_2.Name = "_optProjets_2";
            this._optProjets_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optProjets_2.Size = new System.Drawing.Size(135, 17);
            this._optProjets_2.TabIndex = 16;
            this._optProjets_2.TabStop = true;
            this._optProjets_2.Text = "Sommaire des heures";
            this._optProjets_2.UseVisualStyleBackColor = true;
            // 
            // _optProjets_1
            // 
            this._optProjets_1.BackColor = System.Drawing.Color.Black;
            this._optProjets_1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optProjets_1.ForeColor = System.Drawing.Color.White;
            this._optProjets_1.Location = new System.Drawing.Point(40, 100);
            this._optProjets_1.Name = "_optProjets_1";
            this._optProjets_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optProjets_1.Size = new System.Drawing.Size(135, 17);
            this._optProjets_1.TabIndex = 4;
            this._optProjets_1.TabStop = true;
            this._optProjets_1.Text = "Projets GRB seulement";
            this._optProjets_1.UseVisualStyleBackColor = true;
            // 
            // _optProjets_0
            // 
            this._optProjets_0.BackColor = System.Drawing.Color.Black;
            this._optProjets_0.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optProjets_0.ForeColor = System.Drawing.Color.White;
            this._optProjets_0.Location = new System.Drawing.Point(40, 68);
            this._optProjets_0.Name = "_optProjets_0";
            this._optProjets_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optProjets_0.Size = new System.Drawing.Size(135, 17);
            this._optProjets_0.TabIndex = 3;
            this._optProjets_0.TabStop = true;
            this._optProjets_0.Text = "Tous les projets";
            this._optProjets_0.UseVisualStyleBackColor = true;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.ForeColor = System.Drawing.Color.Navy;
            this.cmdAnnuler.Location = new System.Drawing.Point(219, 448);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(73, 25);
            this.cmdAnnuler.TabIndex = 0;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.BackColor = System.Drawing.Color.Black;
            this.cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimer.ForeColor = System.Drawing.Color.Navy;
            this.cmdImprimer.Location = new System.Drawing.Point(140, 448);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImprimer.Size = new System.Drawing.Size(73, 25);
            this.cmdImprimer.TabIndex = 1;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(97, 207);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // ChoixDateSommairePunch
            // 
            this.AcceptButton = this.cmdImprimer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(304, 485);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lvwFamille);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._optProjets_2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this._optProjets_1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this._optProjets_0);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdImprimer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixDateSommairePunch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContrôleurWebAutoGRB.ChoixDateSommairePunch";
            this.Load += new System.EventHandler(this.ChoixDateSommairePunch_Load);
            this.Click += new System.EventHandler(this.ChoixDateSommairePunch_Click);
            this.ResumeLayout(false);

        }
        #endregion
        private const int I_OPT_TOUS_LES_PROJETS = 0;
        private const int I_OPT_PROJETS_GRB = 1;
        private const int I_OPT_SOMMAIRE_HEURES = 2;
        private enum enumDate
        {
            AUCUNE = 0,
            DEBUT = 1,
            Fin = 2
        }
        private enumDate m_eDate;
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateSommairePunch", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                var bChecked = default(bool);
                if (ValiderDate(dateTimePicker1.Text) == false)
                {
                    MessageBox.Show("Date de début invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ValiderDate(dateTimePicker2.Text) == false)
                {
                    MessageBox.Show("Date de fin invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DateTime.Compare(dateTimePicker1.Value,dateTimePicker2.Value) > 0)
                {
                    MessageBox.Show("La date de fin doit être plus grande que la date de début!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_optProjets_1.Checked == true)
                {
                    for (X = 1; X <= lvwFamille.Items.Count; X++)
                    {
                        if (lvwFamille.Items[X].Checked == true)
                        {
                            bChecked = true; break;
                        }
                    }
                    if (bChecked == false)
                    {
                        MessageBox.Show("Vous devez choisir au moins une famille d'employés!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                if (_optProjets_0.Checked == true)
                {
                    ImprimerPunchGeneral();
                }
                else if (_optProjets_1.Checked == true)
                {
                    ImprimerPunchGRB();
                }
                else
                {
                    ImprimerSommaireHeures();
                }
                Cursor.Current = Cursors.Default;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateSommairePunch", "cmdExporter_Click", ex);
            }
        }
        private void ChoixDateSommairePunch_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateSommairePunch", "Form_Click", ex);
            }
        }
        private void ChoixDateSommairePunch_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                m_eDate = enumDate.AUCUNE;
                RemplirListViewFamille();
                _optProjets_0.Checked = Conversions.ToBoolean(CheckState.Checked);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateSommairePunch", "Form_Load", ex);
            }
        }
        private void RemplirListViewFamille()
        {
            try
            {
                ADODB.Recordset rstFamille;
                ListViewItem itmFamille;
                rstFamille = new Recordset();
                rstFamille.Open("SELECT * FROM Famille ORDER BY Famille", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstFamille.EOF)
                {
                    itmFamille = lvwFamille.Items.Add(string.Empty);
                    itmFamille.Text = (string)(rstFamille.Fields["Famille"].Value);
                    itmFamille.Tag = rstFamille.Fields["IDFamille"].Value;
                    rstFamille.MoveNext();
                }
                rstFamille.Close();
                rstFamille = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateSommairePunch", "RemplirListViewFamille", ex);
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
                AfficherErreur("ChoixDateSommairePunch", "ValiderDate", ex);
                return false;
            }
        }
        [Obsolete]
        private void ImprimerPunchGeneral()
        {
            try
            {
                ADODB.Recordset rstProjets;
                ADODB.Recordset rstHeures;
                ADODB.Recordset rstSommaire;
                DateTime datDebut;
                DateTime datFin;
                double dblTotal;
                double dblSecondes;
                double dblHeures;
                UpdateSQL("DELETE FROM ImpressionSommairePunchGeneral");
                rstSommaire = new Recordset();
                rstProjets = new Recordset();
                rstHeures = new Recordset();
                rstSommaire.Open("SELECT * FROM ImpressionSommairePunchGeneral", odbc, CursorTypeEnum.adOpenDynamic,LockTypeEnum.adLockOptimistic);
                rstProjets.Open("SELECT DISTINCT NoProjet FROM Punch WHERE Date BETWEEN '" +dateTimePicker1.Value.ToShortDateString() + "' AND '" +
                    dateTimePicker2.Value.ToShortDateString()+ "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstProjets.EOF)
                {
                    rstSommaire.AddNew();
                    rstSommaire.Fields["NoProjet"].Value = rstProjets.Fields["NoProjet"].Value;
                    rstHeures.Open($"SELECT HeureDébut, HeureFin FROM Punch WHERE NoProjet = '{rstProjets.Fields["NoProjet"].Value}' AND Date BETWEEN " +
                        $"'{dateTimePicker1.Value.ToShortDateString()}' AND '{dateTimePicker2.Value.ToShortDateString()}' AND HeureFin is not Null"
                        , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    dblTotal = 0d;
                    while (!rstHeures.EOF)
                    {
                        datDebut = Conversions.ToDate(rstHeures.Fields["HeureDébut"].Value);
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstHeures.Fields["HeureFin"].Value, "24:00", false)))
                        {
                            datFin = DateAndTime.TimeSerial(24, 0, 0);
                        }
                        else
                        {
                            datFin = Conversions.ToDate(rstHeures.Fields["HeureFin"].Value);
                        }
                        dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                        dblHeures = Conversion.Int(dblSecondes / 3600d);
                        dblSecondes = dblSecondes - 3600d * dblHeures;
                        dblTotal = dblTotal + dblHeures + Math.Round(dblSecondes / 3600d, 2);
                        rstHeures.MoveNext();
                    }
                    rstHeures.Close();
                    rstSommaire.Fields["Total"].Value.Value = dblTotal;
                    rstSommaire.Update();
                    rstProjets.MoveNext();
                }
                ControleurServeur.ViewListeProjet.Orientation = false;
                ControleurServeur.ViewListeProjet.lblDateDebut.Text = dateTimePicker1.Text;
                ControleurServeur.ViewListeProjet.lblDateFin.Text = dateTimePicker2.Text;
                ViewListeProjet f = new ControleurServeur.ViewListeProjet();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                rstSommaire.Close();
                rstSommaire = null;
                rstHeures = null;
                rstProjets = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateSommairePunch", "ImprimerPunch", ex);
            }
        }
        [Obsolete]
        private void ImprimerPunchGRB()
        {
            try
            {
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstSommaire;
                DateTime datDebut;
                DateTime datFin;
                double dblTotal;
                double dblSecondes;
                double dblHeures;
                var dblTotalHeures = default(double);
                var dblTotalKM = default(double);
                string sWhere;
                var sWhereFamille = default(string);
                int X;
                UpdateSQL("DELETE FROM ImpressionSommairePunchGRB");
                rstSommaire = new Recordset();
                rstPunch = new Recordset();
                rstSommaire.Open("SELECT * FROM ImpressionSommairePunchGRB", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                sWhere = "((Left(NoProjet, 6) = 'E" + Droite(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today).ToString(), 1) + "3000' OR Left(NoProjet, 6) = 'M" + Droite(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today).ToString(), 1) + "3000') AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                var loopTo = (int)lvwFamille.Items.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    if (lvwFamille.Items[X].Checked == true)
                    {
                        if (string.IsNullOrEmpty(sWhereFamille))
                        {
                            sWhereFamille = (string)(Operators.ConcatenateObject(" AND (Famille = ", lvwFamille.Items[X].Tag));
                        }
                        else
                        {
                            sWhereFamille = (string)(Operators.ConcatenateObject(sWhereFamille + " OR Famille = ", lvwFamille.Items[X].Tag));
                        }
                    }
                }
                sWhere = sWhere + sWhereFamille + ")";
                rstPunch.Open("SELECT employe, NoProjet, Date, HeureDébut, HeureFin, NbreKM, Commentaire FROM employés " +
                    "INNER JOIN Punch ON employés.noemploye = Punch.NoEmploye WHERE " + sWhere + " " +
                    "ORDER BY employe, Date, HeureDébut, HeureFin", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPunch.EOF)
                {
                    rstSommaire.AddNew();
                    rstSommaire.Fields["Employé"].Value = rstPunch.Fields["employe"].Value;
                    rstSommaire.Fields["NoProjet"].Value = rstPunch.Fields["NoProjet"].Value;
                    rstSommaire.Fields["Date"].Value = rstPunch.Fields["Date"].Value;
                    rstSommaire.Fields["Commentaire"].Value = rstPunch.Fields["Commentaire"].Value;
                    rstSommaire.Fields["HeureDébut"].Value = rstPunch.Fields["HeureDébut"].Value;
                    rstSommaire.Fields["HeureFin"].Value = rstPunch.Fields["HeureFin"].Value;
                    rstSommaire.Fields["NbreKM"].Value = rstPunch.Fields["NbreKM"].Value;
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblTotal = dblHeures + Math.Round(dblSecondes / 3600d, 2);
                    dblTotalHeures = dblTotalHeures + dblTotal;
                    if (!(rstPunch.Fields["NbreKM"].Value is DBNull))
                    {
                        if (!string.IsNullOrEmpty(Strings.Trim((string)(rstPunch.Fields["NbreKM"].Value))))
                        {
                            dblTotalKM = double.Parse(Operators.AddObject(dblTotalKM, rstPunch.Fields["NbreKM"].Value));
                        }
                    }
                    rstSommaire.Fields["Total"].Value = dblTotal;
                    rstSommaire.Update();
                    rstPunch.MoveNext();
                }
                ControleurServeur.ViewSommairePunchGRB.lblDateDebut.Text = dateTimePicker1.Text;
                ControleurServeur.ViewSommairePunchGRB.lblDateFin.Text = dateTimePicker2.Text;
                ControleurServeur.ViewSommairePunchGRB.lblGrandTotal.Text = dblTotalHeures.ToString();
                ControleurServeur.ViewSommairePunchGRB.lblGrandTotalKM.Text = dblTotalKM.ToString();
                Form f = new ControleurServeur.ViewSommairePunchGRB();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                rstSommaire.Close();
                rstSommaire = null;
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateSommairePunch", "ImprimerPunch", ex);
            }
        }
        [Obsolete]
        private void ImprimerSommaireHeures()
        {
            try
            {
                ADODB.Recordset rstPunch;
                DateTime datDebut;
                DateTime datFin;
                var dblSoumElec = default(double);
                var dblSoumMec = default(double);
                var dblProjGRBElec = default(double);
                var dblProjGRBMec = default(double);
                var dblProjElec = default(double);
                var dblProjMec = default(double);
                var dblFabElec = default(double);
                var dblFabMec = default(double);
                var dblRechElec = default(double);
                var dblRechMec = default(double);
                var dblAppelsElec = default(double);
                var dblAppelsMec = default(double);
                double dblGrandTotal;
                double dblSecondes;
                double dblHeures;
                string sWhere;
                rstPunch = new Recordset();
                sWhere = "(LEFT(NoProjet, 1) = 'E' AND SubString(NoProjet, 3, 1) = '1' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes -= 3600d * dblHeures;
                    dblSoumElec += (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'M' AND SubString(NoProjet, 3, 1) = '1' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblSoumMec = dblSoumMec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'E' AND SubString(NoProjet, 3, 4) = '3000' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblProjGRBElec = dblProjGRBElec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'M' AND SubString(NoProjet, 3, 4) = '3000' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes -= 3600d * dblHeures;
                    dblProjGRBMec += (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                // Projets électriques
                sWhere = "LEFT(NoProjet, 1) = 'E' AND SubString(NoProjet, 3, 1) = '3' AND SubString(NoProjet, 3, 4) <> '3000' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblProjElec = dblProjElec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'M' AND SubString(NoProjet, 3, 1) = '3' AND SubString(NoProjet, 3, 4) <> '3000' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblProjMec = dblProjMec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'E' AND SubString(NoProjet, 3, 1) = '4' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblFabElec = dblFabElec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'M' AND SubString(NoProjet, 3, 1) = '4' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblFabMec = dblFabMec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'E' AND SubString(NoProjet, 3, 1) = '9' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblRechElec = dblRechElec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'M' AND SubString(NoProjet, 3, 1) = '9' AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblRechMec = dblRechMec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'E' AND (SubString(NoProjet, 3, 1) = '5' OR SubString(NoProjet, 3, 1) = '7') AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblAppelsElec = dblAppelsElec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                sWhere = "(LEFT(NoProjet, 1) = 'M' AND (SubString(NoProjet, 3, 1) = '5' OR SubString(NoProjet, 3, 1) = '7') AND Date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND HeureFin Is Not Null)";
                rstPunch.Open("SELECT Date, HeureDébut, HeureFin FROM Punch WHERE " + sWhere, odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    datDebut = Conversions.ToDate(rstPunch.Fields["HeureDébut"].Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, "24:00", false)))
                    {
                        datFin = DateAndTime.TimeSerial(24, 0, 0);
                    }
                    else
                    {
                        datFin = Conversions.ToDate(rstPunch.Fields["HeureFin"].Value);
                    }
                    dblSecondes = DateAndTime.DateDiff(DateInterval.Second, datDebut, datFin);
                    dblHeures = Conversion.Int(dblSecondes / 3600d);
                    dblSecondes = dblSecondes - 3600d * dblHeures;
                    dblAppelsMec = dblAppelsMec + (dblHeures + Math.Round(dblSecondes / 3600d, 2));
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                dblGrandTotal = dblSoumElec + dblSoumMec + dblProjGRBElec + dblProjGRBMec + dblProjElec + dblProjMec + dblFabElec + dblFabMec + dblRechElec + dblRechMec + dblAppelsElec + dblAppelsMec;
                ControleurServeur.ViewSommaireHeures.lblDateDebut.Text = dateTimePicker1.Text;
                ControleurServeur.ViewSommaireHeures.lblDateFin.Text = dateTimePicker2.Text;
                ControleurServeur.ViewSommaireHeures.lblSoumElec.Text = dblSoumElec.ToString();
                ControleurServeur.ViewSommaireHeures.lblSoumMec.Text = dblSoumMec.ToString();
                ControleurServeur.ViewSommaireHeures.lblTotalSoum.Text = $"{dblSoumElec + dblSoumMec}";
                ControleurServeur.ViewSommaireHeures.lblProjGRBElec.Text = dblProjGRBElec.ToString();
                ControleurServeur.ViewSommaireHeures.lblProjGRBMec.Text = dblProjGRBMec.ToString();
                ControleurServeur.ViewSommaireHeures.lblTotalProjGRB.Text = $"{dblProjGRBElec + dblProjGRBMec}";
                ControleurServeur.ViewSommaireHeures.lblProjElec.Text = dblProjElec.ToString();
                ControleurServeur.ViewSommaireHeures.lblProjMec.Text = dblProjMec.ToString();
                ControleurServeur.ViewSommaireHeures.lblTotalProj.Text = $"{dblProjElec + dblProjMec}";
                ControleurServeur.ViewSommaireHeures.lblFabElec.Text = dblFabElec.ToString();
                ControleurServeur.ViewSommaireHeures.lblFabMec.Text = dblFabMec.ToString();
                ControleurServeur.ViewSommaireHeures.lblTotalFab.Text = $"{dblFabElec + dblFabMec}";
                ControleurServeur.ViewSommaireHeures.lblRechElec.Text = dblRechElec.ToString();
                ControleurServeur.ViewSommaireHeures.lblRechMec.Text = dblRechMec.ToString();
                ControleurServeur.ViewSommaireHeures.lblTotalRech.Text = $"{dblRechElec + dblRechMec}";
                ControleurServeur.ViewSommaireHeures.lblAppelsElec.Text = dblAppelsElec.ToString();
                ControleurServeur.ViewSommaireHeures.lblAppelsMec.Text = dblAppelsMec.ToString();
                ControleurServeur.ViewSommaireHeures.lblTotalAppels.Text = $"{dblAppelsElec + dblAppelsMec}";
                ControleurServeur.ViewSommaireHeures.lblGrandTotal.Text = dblGrandTotal.ToString();
                Form f = new ViewSommaireHeures();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                rstPunch.Close();
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateSommairePunch", "ImprimerSommaireHeures", ex);
            }
        }
        private void _optProjets_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (_optProjets_1.Checked == true)
            {
                lvwFamille.Enabled = true;
            }
            else
            {
                lvwFamille.Enabled = false;
            }
        }
    }
}