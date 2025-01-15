using System;
using System.Windows.Forms;
using System.Diagnostics;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ControleurServeur;
using ADODB;

using System.Web.UI.WebControls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using Button = System.Windows.Forms.Button;
using ListView = System.Windows.Forms.ListView;
using ControleurServeur;
using System.Collections.Generic;

namespace ControleurServeur
{
    internal class ChoixImpressionFT : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixImpressionFT() : base()
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
        internal static System.Windows.Forms.ToolTip ToolTip1;
        internal static System.Windows.Forms.Button cmdImprimer;
        internal static System.Windows.Forms.Button cmdAnnuler;
        internal static System.Windows.Forms.Button cmdAucun;
        internal static System.Windows.Forms.Button cmdTous;
        internal static System.Windows.Forms.ColumnHeader _lvwEmploye_ColumnHeader_1;
        internal static System.Windows.Forms.ListView lvwEmploye;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdImprimer = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdAucun = new System.Windows.Forms.Button();
            cmdTous = new System.Windows.Forms.Button();
            lvwEmploye = new System.Windows.Forms.ListView();
            _lvwEmploye_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            SuspendLayout();
            // 
            // cmdImprimer
            // 
            cmdImprimer.BackColor = System.Drawing.Color.Black;
            cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdImprimer.ForeColor = System.Drawing.Color.White;
            cmdImprimer.Location = new System.Drawing.Point(120, 408);
            cmdImprimer.Name = "cmdImprimer";
            cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdImprimer.Size = new System.Drawing.Size(73, 33);
            cmdImprimer.TabIndex = 4;
            cmdImprimer.Text = "Imprimer";
            cmdImprimer.UseVisualStyleBackColor = true;
            cmdImprimer.Click += new System.EventHandler(cmdImprimer_Click);
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(199, 408);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(73, 33);
            cmdAnnuler.TabIndex = 3;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // cmdAucun
            // 
            cmdAucun.BackColor = System.Drawing.Color.Black;
            cmdAucun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAucun.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAucun.ForeColor = System.Drawing.Color.White;
            cmdAucun.Location = new System.Drawing.Point(80, 368);
            cmdAucun.Name = "cmdAucun";
            cmdAucun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAucun.Size = new System.Drawing.Size(65, 25);
            cmdAucun.TabIndex = 2;
            cmdAucun.Text = "Aucun";
            cmdAucun.UseVisualStyleBackColor = true;
            cmdAucun.Click += new System.EventHandler(cmdAucun_Click);
            // 
            // cmdTous
            // 
            cmdTous.BackColor = System.Drawing.Color.Black;
            cmdTous.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdTous.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdTous.ForeColor = System.Drawing.Color.White;
            cmdTous.Location = new System.Drawing.Point(8, 368);
            cmdTous.Name = "cmdTous";
            cmdTous.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdTous.Size = new System.Drawing.Size(65, 25);
            cmdTous.TabIndex = 1;
            cmdTous.Text = "Tous";
            cmdTous.UseVisualStyleBackColor = true;
            cmdTous.Click += new System.EventHandler(cmdTous_Click);
            // 
            // lvwEmploye
            // 
            lvwEmploye.BackColor = System.Drawing.Color.Black;
            lvwEmploye.CheckBoxes = true;
            lvwEmploye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwEmploye_ColumnHeader_1});
            lvwEmploye.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwEmploye.ForeColor = System.Drawing.Color.AliceBlue;
            lvwEmploye.FullRowSelect = true;
            lvwEmploye.GridLines = true;
            lvwEmploye.HideSelection = false;
            lvwEmploye.Location = new System.Drawing.Point(7, 65);
            lvwEmploye.Name = "lvwEmploye";
            lvwEmploye.Size = new System.Drawing.Size(265, 297);
            lvwEmploye.TabIndex = 0;
            lvwEmploye.UseCompatibleStateImageBehavior = false;
            lvwEmploye.View = System.Windows.Forms.View.Details;
            // 
            // _lvwEmploye_ColumnHeader_1
            // 
            _lvwEmploye_ColumnHeader_1.Text = "Nom";
            _lvwEmploye_ColumnHeader_1.Width = 459;
            // 
            // ChoixImpressionFT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(284, 449);
            ControlBox = false;
            Controls.Add(cmdImprimer);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdAucun);
            Controls.Add(cmdTous);
            Controls.Add(lvwEmploye);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(3, 29);
            Name = "ChoixImpressionFT";
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
            Load += new System.EventHandler(ChoixImpressionFT_Load);
            ResumeLayout(false);

        }
        #endregion
        private DateTime m_datDebut;
        private DateTime m_datFin;
        private DateTime datSemaine;
        private DateTime dateTime;
        public ChoixImpressionFT(DateTime datSemaine, DateTime dateTime)
        {
            InitializeComponent();
            datSemaine = datSemaine;
            dateTime = dateTime;
            Afficher(datSemaine, datSemaine);
        }
        public void Afficher(DateTime datDebut, DateTime datFin)
        {
            try
            {
                m_datDebut = datDebut;
                m_datFin = datFin;
                RemplirListViewEmploye();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionFT", "Afficher", ex);
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
                AfficherErreur("ChoixImpressionFT", "cmdAnnuler_Click", ex);
            }
        }
        [Obsolete]
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstImpPunch;
                ADODB.Recordset rstSommeKM;
                ADODB.Recordset rstPunch;
                bool bAnnuler = false;
                double dblTotal;
                Cursor.Current = Cursors.WaitCursor;
                rstImpPunch = new Recordset();
                rstSommeKM = new Recordset();
                rstPunch = new Recordset();
                for (int X = 1; X <= lvwEmploye.Items.Count; X++)
                {
                    if (lvwEmploye.Items[X].Checked == true)
                    {
                        dblTotal = 0d;
                        UpdateSQL("DELETE FROM ImpressionPunch");
                        rstPunch.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Punch WHERE Date BETWEEN '" + ConvertDate(m_datDebut) + "' AND '" + ConvertDate(m_datFin) + "' AND NoEmploye = ", lvwEmploye.Items[(int)X].Tag), " ORDER BY Date, HeureDébut, HeureFin"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstPunch.EOF)
                        {
                            while (!rstPunch.EOF)
                            {
                                if (Conversions.ToBoolean(Operators.OrObject(rstPunch.Fields["HeureFin"].Value is DBNull, Operators.ConditionalCompareObjectEqual(rstPunch.Fields["HeureFin"].Value, string.Empty, false))))
                                {
                                    MessageBox.Show("Un punch out n'a pas été fait pour " + lvwEmploye.Items[X].Text + " !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    bAnnuler = true;
                                    break;
                                }
                                rstPunch.MoveNext();
                            }
                        }
                        else
                        {
                            Cursor.Current = Cursors.Default;
                            MessageBox.Show("Il n'y a aucun punch à imprimer pour " + lvwEmploye.Items[X].Text + " !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            bAnnuler = true;
                        }
                        rstPunch.Close();
                        if (bAnnuler == false)
                        {
                            RemplirTableImpressionPunch(X);
                            AjouterNomJour();
                            AjouterSéparateur();
                            CalculerTotal();
                            ViewFeuilleTemps.lblNom.Text = lvwEmploye.Items[X].Text;
                            ViewFeuilleTemps.lblDate.Text = "Semaine du " + GetDateTexte(m_datDebut) + " au " + GetDateTexte(m_datFin);
                            ViewFeuilleTemps.lblDatePrint.Text = ConvertDate(DateTime.Today);
                            rstImpPunch.Open("SELECT * FROM ImpressionPunch ORDER BY Date, HeureDébut", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            while (!rstImpPunch.EOF)
                            {
                                if (!(rstImpPunch.Fields["Total"].Value is DBNull))
                                {
                                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstImpPunch.Fields["Total"].Value, "", false)))
                                    {
                                        dblTotal = dblTotal + double.Parse(Gauche((string)(rstImpPunch.Fields["Total"].Value), 2));
                                        dblTotal = dblTotal + double.Parse(Droite((string)(rstImpPunch.Fields["Total"].Value), 2)) / 60d;
                                    }
                                }
                                rstImpPunch.MoveNext();
                            }
                            rstImpPunch.MoveFirst();
                            rstSommeKM.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT SUM(NbreKM) As TotalKM FROM Punch WHERE Date BETWEEN '" + ConvertDate(m_datDebut) + "' AND '" + ConvertDate(m_datFin) + "' AND NoEmploye = ", lvwEmploye.Items[(int)X].Tag), " AND KM = 1"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            ViewFeuilleTemps.Orientation = true;
                            ViewFeuilleTemps.DataSource = rstImpPunch;
                            ViewFeuilleTemps.lblGrandTotalKM.Text = Math.Round(dblTotal, 2).ToString();
                            if (!(rstSommeKM.Fields["TotalKM"].Value is DBNull))
                            {
                                ViewFeuilleTemps.lblGrandTotalKM.Text = Math.Round(rstSommeKM.Fields["TotalKM"].Value, 2);
                            }
                            else
                            {
                                ViewFeuilleTemps.lblGrandTotalKM.Text = "0";
                            }
                            ViewFeuilleTemps f = new ViewFeuilleTemps();
                            f.Show();
                            rstImpPunch.Close();
                            rstSommeKM.Close();
                        }
                    }
                }
                Cursor.Current = Cursors.Default;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionFT", "cmdImprimer_Click", ex);
            }
        }
        private void RemplirListViewEmploye()
        {
            try
            {
                ADODB.Recordset rstEmploye;
                ListViewItem itmEmploye;
                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT NoEmploye, Employe FROM Employés WHERE actif=1 ORDER BY Employe", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstEmploye.EOF)
                {
                    itmEmploye = lvwEmploye.Items.Add(string.Empty);
                    itmEmploye.SubItems.Insert(0x00, new ListViewItem.ListViewSubItem(null, $"{rstEmploye.Fields["Employe"].Value}"));
                    itmEmploye.SubItems.Insert(0x01, new ListViewItem.ListViewSubItem(null, $"{rstEmploye.Fields["NoEmploye"].Value}"));
                    rstEmploye.MoveNext();
                }
                rstEmploye.Close();
                rstEmploye = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionFT", "RemplirListViewEmploye", ex);
            }
        }
        private void RemplirTableImpressionPunch(int iIndexListView)
        {
            try
            {
                ADODB.Recordset rstImpPunch;
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstClient;
                rstPunch = new Recordset();
                rstImpPunch = new Recordset();
                rstClient = new Recordset();
                rstPunch.Open(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Punch WHERE NoEmploye = ", lvwEmploye.Items[(int)iIndexListView].Tag), " AND Date BETWEEN '"), ConvertDate(m_datDebut)), "' AND '"), ConvertDate(m_datFin)), "' ORDER BY Date, HeureDébut"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstImpPunch.Open("SELECT * FROM ImpressionPunch", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPunch.EOF)
                {
                    rstImpPunch.AddNew();
                    rstImpPunch.Fields["NoProjet"].Value = rstPunch.Fields["NoProjet"].Value;
                    rstImpPunch.Fields["Date"].Value = rstPunch.Fields["Date"].Value;
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["ModifDébut"].Value, true, false)))
                    {
                        rstImpPunch.Fields["HeureDébut"].Value = Droite((string)(Operators.ConcatenateObject("0", rstPunch.Fields["HeureDébut"].Value)), 5) + "*";
                    }
                    else
                    {
                        rstImpPunch.Fields["HeureDébut"].Value = Droite((string)(Operators.ConcatenateObject("0", rstPunch.Fields["HeureDébut"].Value)), 5);
                    }
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPunch.Fields["ModifFin"].Value, true, false)))
                    {
                        rstImpPunch.Fields["HeureFin"].Value = Droite((string)(Operators.ConcatenateObject("0", rstPunch.Fields["HeureFin"].Value)), 5) + "*";
                    }
                    else
                    {
                        rstImpPunch.Fields["HeureFin"].Value = Droite((string)(Operators.ConcatenateObject("0", rstPunch.Fields["HeureFin"].Value)), 5);
                    }
                    if (Conversions.ToBoolean(Operators.AndObject(!(rstPunch.Fields["NoClient"].Value is DBNull), Operators.ConditionalCompareObjectGreater(rstPunch.Fields["NoClient"].Value, "0", false))))
                    {
                        rstClient.Open("SELECT NomClient FROM Client WHERE IDClient = "+rstPunch.Fields["NoClient"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstImpPunch.Fields["Client"].Value = rstClient.Fields["NomClient"].Value;
                        rstClient.Close();
                    }
                    rstImpPunch.Fields["Commentaire"].Value = rstPunch.Fields["Commentaire"].Value;
                    rstImpPunch.Fields["Type"].Value = rstPunch.Fields["Type"].Value;
                    rstImpPunch.Fields["NbreKM"].Value = rstPunch.Fields["NbreKM"].Value;
                    rstImpPunch.Update();
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                rstPunch = null;
                rstImpPunch.Close();
                rstImpPunch = null;
                rstClient = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionFT", "RemplirTableImpressionPunch", ex);
            }
        }
        private void AjouterNomJour()
        {
            try
            {
                ADODB.Recordset rstImpPunch = new ADODB.Recordset();
                var sJour = default(string);
                DateTime datTemp;
                string sDate;
                rstImpPunch.CursorLocation = CursorLocationEnum.adUseServer;
                rstImpPunch.Open("SELECT * FROM ImpressionPunch ORDER BY Date, HeureDébut", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstImpPunch.EOF)
                {
                    sDate = (string)(rstImpPunch.Fields["Date"].Value);
                    datTemp = DateAndTime.DateSerial(int.Parse(Gauche(sDate, 4)), int.Parse(sDate.Substring(6, 2)), int.Parse(Droite(sDate, 2)));
                    if ((sJour ?? "") != (DateAndTime.WeekdayName(DateAndTime.Weekday(datTemp)) ?? ""))
                    {
                        rstImpPunch.Fields["NomJour"].Value = Strings.UCase(DateAndTime.WeekdayName(DateAndTime.Weekday(datTemp)));
                        sJour = DateAndTime.WeekdayName(DateAndTime.Weekday(datTemp));
                    }
                    else
                    {
                        rstImpPunch.Fields["NomJour"].Value = "";
                    }
                    rstImpPunch.Update();
                    rstImpPunch.MoveNext();
                }
                rstImpPunch.Close();
                rstImpPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionFT", "AjouterNomJour", ex);
            }
        }
        private void AjouterSéparateur()
        {
            try
            {
                ADODB.Recordset rstImpPunch;
                int iNoRec;
                var sJour = default(string);
                List<String> collDate;
                string sDate;
                int X;
                collDate = new List<String>();
                rstImpPunch = new Recordset();
                rstImpPunch.Open("SELECT * FROM ImpressionPunch ORDER BY Date, HeureDébut", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iNoRec = 1;
                while (!rstImpPunch.EOF)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(sJour, rstImpPunch.Fields["NomJour"].Value, false)))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstImpPunch.Fields["NomJour"].Value, string.Empty, false)))
                        {
                            if (iNoRec > 1)
                            {
                                sDate = (string)(rstImpPunch.Fields["Date"].Value);
                                collDate.Add(sDate);
                            }
                        }
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstImpPunch.Fields["NomJour"].Value, string.Empty, false)))
                        {
                            sJour = (string)(rstImpPunch.Fields["NomJour"].Value);
                        }
                    }
                    iNoRec = (int)(iNoRec + 1);
                    rstImpPunch.MoveNext();
                }
                var loopTo = (int)collDate.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    rstImpPunch.AddNew();
                    rstImpPunch.Fields["Date"].Value = collDate[X];
                    rstImpPunch.Fields["NomJour"].Value = string.Empty;
                    rstImpPunch.Fields["NoProjet"].Value = " ";
                    rstImpPunch.Fields["Client"].Value = string.Empty;
                    rstImpPunch.Fields["Commentaire"].Value = string.Empty;
                    rstImpPunch.Fields["HeureDébut"].Value = " ";
                    rstImpPunch.Fields["HeureFin"].Value = string.Empty;
                    rstImpPunch.Update();
                }
                rstImpPunch.Close();
                rstImpPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionFT", "AjouterSéparateur", ex);
            }
        }
        private void CalculerTotal()
        {
            try
            {
                ADODB.Recordset rstImpPunch;
                DateTime datDébut;
                DateTime datFin;
                DateTime datTotal;
                string sDate;
                string sDébut;
                string sFin;
                rstImpPunch = new Recordset();
                rstImpPunch.CursorLocation = CursorLocationEnum.adUseServer;
                rstImpPunch.Open("SELECT * FROM ImpressionPunch", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                while (!rstImpPunch.EOF)
                {
                    if (!string.IsNullOrEmpty((string)(rstImpPunch.Fields["HeureDébut"].Value).Trim()))
                    {
                        sDate = (string)(rstImpPunch.Fields["Date"].Value);
                        sDébut = Gauche((string)(rstImpPunch.Fields["HeureDébut"].Value), 5);
                        sFin = Gauche((string)(rstImpPunch.Fields["HeureFin"].Value), 5);
                        datDébut = DateTime.FromOADate(DateAndTime.DateSerial(int.Parse(Gauche(sDate, 4)), int.Parse(sDate.Substring(6, 2)),
                            int.Parse(Droite(sDate, 2))).ToOADate() + DateAndTime.TimeSerial(int.Parse(Gauche(sDébut, 2)),
                            int.Parse(sDébut.Substring(4, 2)), 0).ToOADate());
                        datFin = DateTime.FromOADate(DateAndTime.DateSerial(int.Parse(Gauche(sDate, 4)), int.Parse(sDate.Substring(6, 2)),
                            int.Parse(Droite(sDate, 2))).ToOADate() + DateAndTime.TimeSerial(int.Parse(Gauche(sFin, 2)),
                            int.Parse(sFin.Substring(4, 2)), 0).ToOADate());
                        /// dètermintion interval entre Punch Entree et sortie 
                        /// au moyen de threads sur le calendrier local
                        /// plus preci que la routine  while (AddMinutes(x++)<(int)
                        if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datDébut) == 0
                            & System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datDébut) == 0
                            & System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetSecond(datDébut) == 0
                            & System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datFin) == 0
                            & System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datFin) == 0
                            & System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetSecond(datFin) == 0
                            & DateAndTime.DateDiff(DateInterval.Day, datDébut, datFin) == 1L)
                        {
                            rstImpPunch.Fields["Total"].Value = "24:00";
                        }
                        else
                        {
                            datTotal = DateTime.FromOADate(datFin.ToOADate() - datDébut.ToOADate());
                            rstImpPunch.Fields["Total"].Value = Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datTotal), 2) + ":" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datTotal), 2);
                        }
                        rstImpPunch.Update();
                    }
                    rstImpPunch.MoveNext();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionFT", "CalculerTotal", ex);
            }
        }
        private void cmdTous_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                var loopTo = (int)lvwEmploye.Items.Count;
                for (X = 1; X <= loopTo; X++)
                    lvwEmploye.Items[X].Checked = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionFT", "cmdTous_Click", ex);
            }
        }
        private void cmdAucun_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                for (int X = 1; X <= (int)lvwEmploye.Items.Count; X++)
                    lvwEmploye.Items[X].Checked = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixImpressionFT", "cmdAucun_Click", ex);
            }
        }
        private void ChoixImpressionFT_Load(object sender, EventArgs e)
        {
            foreach (DB_Employe p in Employes)
            {
                System.Windows.Forms.ListViewItem itm = lvwEmploye.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{p.Employes} - {p.Noemploye}"));
            }
        }
    }
}