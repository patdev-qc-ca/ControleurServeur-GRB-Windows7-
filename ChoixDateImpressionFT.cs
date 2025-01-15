using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using System.Diagnostics;
#pragma warning disable CS0168
namespace ControleurServeur
{
    internal class ChoixDateImpressionFT : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixDateImpressionFT() : base()
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
        internal static Button cmdExporter;
        internal static Button cmdAnnuler;
        internal static Label Label1;
        internal static Label Label2;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdExporter = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            mskDateDebut = new System.Windows.Forms.DateTimePicker();
            mskDateFin = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();//cmdExporter
            cmdExporter.BackColor = System.Drawing.Color.Black;
            cmdExporter.Cursor = System.Windows.Forms.Cursors.Default;
            cmdExporter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdExporter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdExporter.ForeColor = System.Drawing.Color.White;
            cmdExporter.Location = new System.Drawing.Point(196, 224);
            cmdExporter.Name = "cmdExporter";
            cmdExporter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdExporter.Size = new System.Drawing.Size(73, 25);
            cmdExporter.TabIndex = 1;
            cmdExporter.Text = "Exporter";
            cmdExporter.UseVisualStyleBackColor = true;
            cmdExporter.Click += new System.EventHandler(cmdexporter_Click);//cmdAnnuler
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.Cursor = System.Windows.Forms.Cursors.Default;
            cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(275, 224);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(73, 25);
            cmdAnnuler.TabIndex = 0;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);//Label1
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Cursor = System.Windows.Forms.Cursors.Default;
            Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(115, 64);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(65, 17);
            Label1.TabIndex = 9;
            Label1.Text = "Date début :";//Label2
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Cursor = System.Windows.Forms.Cursors.Default;
            Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(115, 119);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(65, 17);
            Label2.TabIndex = 8;
            Label2.Text = "Date fin :";//mskDateDebut
            mskDateDebut.Location = new System.Drawing.Point(118, 85);
            mskDateDebut.Name = "mskDateDebut";
            mskDateDebut.Size = new System.Drawing.Size(190, 20);
            mskDateDebut.TabIndex = 11;//mskDateFin
            mskDateFin.Location = new System.Drawing.Point(118, 140);
            mskDateFin.Name = "mskDateFin";
            mskDateFin.Size = new System.Drawing.Size(190, 20);
            mskDateFin.TabIndex = 12;//ChoixDateImpressionFT
            AcceptButton = cmdExporter;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(364, 262);
            Controls.Add(mskDateFin);
            Controls.Add(mskDateDebut);
            Controls.Add(cmdExporter);
            Controls.Add(cmdAnnuler);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Cursor = System.Windows.Forms.Cursors.Default;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(3, 22);
            Name = "ChoixDateImpressionFT";
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
            Load += new System.EventHandler(ChoixDateImpressionFT_Load);
            Click += new System.EventHandler(ChoixDateImpressionFT_Click);
            ResumeLayout(false);
        }
        #endregion
        private DateTimePicker mskDateDebut;
        private DateTimePicker mskDateFin;
        private string txtEmployé;
        public ChoixDateImpressionFT(string txtEmployé)
        {
            InitializeComponent();
            txtEmployé = txtEmployé;
            Text = txtEmployé;
        }
        private enum enumDate
        {
            AUCUNE = 0,
            DEBUT = 1,
            Fin = 2
        }
        private enumDate m_eDate;
        private Microsoft.Office.Interop.Excel.Application m_xlsApp;
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFT", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdexporter_Click(object eventSender, EventArgs eventArgs)
        {//date.annee au format 4octet pas 2octet
            try
            {
                if (ValiderDate(mskDateDebut.Text) == false) { MessageBox.Show("Date de début invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (ValiderDate(mskDateFin.Text) == false) { MessageBox.Show("Date de fin invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (DateTime.Compare(mskDateDebut.Value, mskDateFin.Value) > 0) { MessageBox.Show("La date de fin doit être plus grande que la date de début!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                ExporterPunch();
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFT", "cmdExporter_Click", ex);
            }
        }
        private void ChoixDateImpressionFT_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Text = Application.ProductName + "ChoixDateImpressionFacturation [" + IdNomEmploye + "]";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFT", "Form_Click", ex);
            }
        }
        private void ChoixDateImpressionFT_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                m_eDate = enumDate.AUCUNE;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFT", "Form_Load", ex);
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
                AfficherErreur("ChoixDateImpressionFT", "ValiderDate", ex); return false;
            }
        }
        private void ExporterPunch()
        {
            try
            {
                ADODB.Recordset rstEmployes = new ADODB.Recordset();
                ADODB.Recordset rstProjets = new ADODB.Recordset();
                Microsoft.Office.Interop.Excel.Workbook xlsWorkBook;
                int iNbreEmployes = IdNoEmploye;
                int iNbreProjets = 0;
                int iNbrePages = 1;
                int iPage = 1;
                string sDateDebut = mskDateDebut.Text;
                string sDateFin = mskDateFin.Text;
                Cursor.Current = Cursors.WaitCursor;
                rstEmployes.CursorLocation = CursorLocationEnum.adUseClient;
                rstProjets.CursorLocation = CursorLocationEnum.adUseClient;
                rstProjets.Open("SELECT DISTINCT NOPROJET, RIGHT(NOPROJET, 9) FROM PUNCH " +
                    "WHERE DATE BETWEEN '" + sDateDebut + "' AND '" + sDateFin + "' ORDER BY RIGHT(NoProjet, 9)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstEmployes.Open("SELECT DISTINCT Employe FROM Punch " +
                    "INNER JOIN Employés ON Employés.NoEmploye = Punch.NoEmploye " +
                    "WHERE Date BETWEEN '" + sDateDebut + "' AND '" + sDateFin + "'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                iNbreEmployes = (int)rstEmployes.RecordCount;
                iNbreProjets = (int)rstProjets.RecordCount;
                if (iNbreProjets > 26)  /// limite de 26 entrées par page
                {
                    iNbrePages = (int)Math.Round(Conversion.Int(iNbreProjets / 26d));
                    if (iNbrePages * 26 < iNbreProjets) { iNbrePages = (int)(iNbrePages + 1); }
                }
                else { iNbrePages = 1; }
                m_xlsApp = new Microsoft.Office.Interop.Excel.Application();
                xlsWorkBook = m_xlsApp.Workbooks.Add();
                for (iPage = 1; iPage <= iNbrePages; iPage++)
                    CreerTableau(ref rstProjets, ref rstEmployes, (iPage * 43) - 42, sDateDebut, sDateFin);
                rstProjets.Close();
                rstEmployes.Close();
                rstProjets = null;
                TransfererValeurs(sDateDebut, sDateFin);
                RemplirValeurs(iNbrePages);
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.LeftMargin = m_xlsApp.Application.InchesToPoints(0d);
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.RightMargin = m_xlsApp.Application.InchesToPoints(0d);
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.TopMargin = m_xlsApp.Application.InchesToPoints(0d);
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.BottomMargin = m_xlsApp.Application.InchesToPoints(0d);
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.HeaderMargin = m_xlsApp.Application.InchesToPoints(0d);
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.FooterMargin = m_xlsApp.Application.InchesToPoints(0d);
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.CenterHorizontally = true;
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.CenterVertically = false;
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
                ((dynamic)m_xlsApp.ActiveSheet).PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperLegal;
                Cursor.Current = Cursors.Default;
                m_xlsApp.Visible = true;
                xlsWorkBook.SaveAs(Filename: $"{RootExcel}{txtEmployé}_{sDateDebut}_{sDateFin}.xlsx");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFT", "ExporterPunch", ex);
            }
        }
        private void CreerTableau(ref ADODB.Recordset rstProjets, ref ADODB.Recordset rstEmployes, int iDebut, string sDateDebut, string sDateFin)
        {
            try
            {
                int iNbreProjets;
                int iNbreEmployes;
                int X;
                var sLettre = default(string);
                iNbreProjets = (int)rstProjets.RecordCount;
                iNbreEmployes = (int)rstEmployes.RecordCount;
                m_xlsApp.Cells[iDebut, 1] = $"du {GetDateTexte(ConvertDateTexte(sDateDebut))} au {GetDateTexte(ConvertDateTexte(sDateFin))}".ToUpper();
                m_xlsApp.get_Range("A" + iDebut).Font.Bold = true;
                m_xlsApp.get_Range("A" + iDebut).Font.Underline = Microsoft.Office.Interop.Excel.XlUnderlineStyle.xlUnderlineStyleSingle;
                m_xlsApp.get_Range("A" + iDebut).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                m_xlsApp.get_Range("A" + iDebut).Font.Size = 18;
                m_xlsApp.get_Range("A" + iDebut, "AB" + iDebut).Merge();
                m_xlsApp.get_Range("B" + (iDebut + 3), "AB" + (iDebut + 3)).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                m_xlsApp.get_Range("B" + (iDebut + 3), "AB" + (iDebut + 3)).VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                m_xlsApp.get_Range("B" + (iDebut + 3), "AB" + (iDebut + 3)).Orientation = 0x5A; // orientation 90deg
                for (X = 2; X <= 27; X++)
                {
                    if (rstProjets.EOF == true) { break; }
                    else
                    {
                        m_xlsApp.Cells[iDebut + 3, X] = rstProjets.Fields["NoProjet"].Value;
                        rstProjets.MoveNext();
                    }
                }
                m_xlsApp.Cells[iDebut + 3, 28] = "TOTAL";
                rstEmployes.MoveFirst();
                for (X = 4; X <= (iNbreEmployes + 3); X++)
                {
                    m_xlsApp.Cells[iDebut + X, 1] = rstEmployes.Fields["Employe"].Value;
                    rstEmployes.MoveNext();
                }
                m_xlsApp.Cells[iDebut + X, 1] = "TOTAL";
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                m_xlsApp.get_Range($"A{iDebut + 3}:AB{iDebut + iNbreEmployes + 4}").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                m_xlsApp.get_Range("B" + (iDebut + 3) + ":AA" + (iDebut + iNbreEmployes + 4)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range("B" + (iDebut + 3) + ":AA" + (iDebut + iNbreEmployes + 4)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_xlsApp.get_Range("B" + (iDebut + 3) + ":AA" + (iDebut + iNbreEmployes + 4)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                m_xlsApp.get_Range("B" + (iDebut + 3) + ":AA" + (iDebut + iNbreEmployes + 4)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range("B" + (iDebut + 3) + ":AA" + (iDebut + iNbreEmployes + 4)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_xlsApp.get_Range("B" + (iDebut + 3) + ":AA" + (iDebut + iNbreEmployes + 4)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                m_xlsApp.get_Range("A" + (iDebut + 3) + ":AB" + (iDebut + 3)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range("A" + (iDebut + 3) + ":AB" + (iDebut + 3)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_xlsApp.get_Range("A" + (iDebut + 3) + ":AB" + (iDebut + 3)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                m_xlsApp.get_Range("A" + (iDebut + iNbreEmployes + 4) + ":AB" + (iDebut + iNbreEmployes + 4)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_xlsApp.get_Range("A" + (iDebut + iNbreEmployes + 4) + ":AB" + (iDebut + iNbreEmployes + 4)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_xlsApp.get_Range("A" + (iDebut + iNbreEmployes + 4) + ":AB" + (iDebut + iNbreEmployes + 4)).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic;
                for (X = (int)(iDebut + 4); X <= (int)(iNbreEmployes + iDebut + 4); X++)
                    m_xlsApp.Cells["AB" + X] = "=SUM(B" + X + ":AA" + X + ")";
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
                    /// possible bug sur les Excel natif 
                    /// 
                    m_xlsApp.Cells[sLettre + (iDebut + iNbreEmployes + 4)] = "=SUM(" + sLettre + (iDebut + 4) + ":" + sLettre + (iDebut + iNbreEmployes + 3) + ")";
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFT", "CreerTableau", ex);
            }
        }
        private void TransfererValeurs(string sDateDebut, string sDateFin)
        {
            try
            {
                ADODB.Recordset rstSource = new ADODB.Recordset();
                ADODB.Recordset rstDestination = new ADODB.Recordset(); ;
                string sDate;
                string sHeure;
                string sMinute;
                double dblResult;
                DateTime datTemp;
                rstSource.Open("SELECT * FROM Punch WHERE Date BETWEEN '" + sDateDebut + "' AND '" + sDateFin + "' AND HeureFin!=''", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                if (!rstSource.EOF)
                {
                    UpdateSQL("DELETE FROM PunchExcel");
                    rstDestination.Open("SELECT * FROM PunchExcel", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstSource.EOF)
                    {
                        rstDestination.AddNew();
                        rstDestination.Fields["NoEmploye"].Value = rstSource.Fields["NoEmploye"].Value;
                        rstDestination.Fields["NoProjet"].Value = rstSource.Fields["NoProjet"].Value;
                        sHeure = Gauche((string)(rstSource.Fields["HeureDébut"].Value), 2);
                        sMinute = Droite((string)(rstSource.Fields["HeureDébut"].Value), 2);
                        dblResult = int.Parse(sMinute) / 60d;
                        if (dblResult != 0d)
                        {
                            rstDestination.Fields["HeureDébut"].Value = sHeure + "," + Droite(dblResult.ToString(), dblResult.ToString().Length - Strings.InStr(1, dblResult.ToString(), ","));
                        }
                        else
                        {
                            rstDestination.Fields["HeureDébut"].Value = int.Parse(sHeure);
                        }
                        sHeure = Gauche((string)(rstSource.Fields["HeureFin"].Value), 2);
                        sMinute = Droite((string)(rstSource.Fields["HeureFin"].Value), 2);
                        dblResult = int.Parse(sMinute) / 60d;
                        if (dblResult != 0d)
                        {
                            rstDestination.Fields["HeureFin"].Value = int.Parse(sHeure) + "," + int.Parse(Droite(dblResult.ToString(), dblResult.ToString().Length - Strings.InStr(1, dblResult.ToString(), ",")));
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
                AfficherErreur("ChoixDateImpressionFT", "TransfererValeurs", ex);
            }
        }
        private void RemplirValeurs(int iNbrePages)
        {
            try
            {
                ADODB.Recordset rstPunch;
                string sNom = txtEmployé;
                int iIndexNom;
                int X;
                int iPage;
                int iPageRendu;
                int iNoRendu;
                var iDebutPage = default(int);
                var iIndexProjet = default(int);
                bool bProjetTrouve;
                rstPunch = new Recordset();
                rstPunch.Open($"SELECT EMPLOYE, NOPROJET,[HEUREDÉBUT] ,[HEUREFIN]  FROM [PUNCHEXCEL] " +
                    $"INNER JOIN EMPLOYÉS ON PUNCHEXCEL.NOEMPLOYE = EMPLOYÉS.NOEMPLOYE " +
                   $"where[DBO].[employés].employe ='{sNom}' " +
                   $"ORDER BY EMPLOYE, RIGHT(NOPROJET, 9)", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                int counter;
                double total = 0d;
                if (!rstPunch.EOF)
                {
                    iIndexNom = 4;
                    sNom = (string)(rstPunch.Fields["Employe"].Value);
                    iPageRendu = 1;
                    iNoRendu = 2;
                    while (!rstPunch.EOF)
                    {
                        if (sNom != rstPunch.Fields["Employe"].Value)
                        {
                            total += (double.Parse(rstPunch.Fields["HEUREFIN"].Value) - double.Parse(rstPunch.Fields["HEUREDÉBUT"].Value));
                            sNom = (string)(rstPunch.Fields["Employe"].Value);
                            iIndexNom = (int)(iIndexNom + 1);
                            iPageRendu = 1;
                            iNoRendu = 2;
                        }
                        else if (iNoRendu > 2)
                        {
                            iNoRendu--;
                        }
                        else if (iPageRendu > 1)
                        {
                            iPageRendu--;
                            iNoRendu = 27;
                        }
                        bProjetTrouve = false;
                        counter = iPageRendu;
                        for (iPage = counter; iPage < iNbrePages; iPage++)
                        {
                            if (iPageRendu != iPage) { iNoRendu = 2; }
                            iDebutPage = (int)(iPage * 43 - 42);
                            counter = iNoRendu;
                            for (X = counter; X <= 27; X++)
                            {
                                if (m_xlsApp.Cells[(iDebutPage + 3), X] == rstPunch.Fields["NoProjet"].Value)
                                {
                                    iIndexProjet = X;
                                    iPageRendu = iPage;
                                    iNoRendu = X;
                                    bProjetTrouve = true;
                                    break;
                                }
                            }
                            if (bProjetTrouve == true) { break; }
                        }
                        if (bProjetTrouve == false)
                        {
                            MessageBox.Show(
                                $"Le # {rstPunch.Fields["NoProjet"].Value} n'a pas pu être trouvé pour l'employé {sNom}.\n " +
                                $"Son temps de {rstPunch.Fields["Total"].Value} heures sera ajouté à cet endroit : Page   : {iPageRendu}\n " +
                                $"Rangée : {iIndexProjet}\n", $"{Application.ProductName}.ChoixDateImpressionFT.RemplirValeurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        m_xlsApp.Cells[iDebutPage + iIndexNom, iIndexProjet] = rstPunch.Fields["Total"].Value;
                        rstPunch.MoveNext();
                    }
                }
                rstPunch.Close();
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixDateImpressionFT", "RemplirValeurs", ex);
            }
        }
    }
}