using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ControleurServeur;
using System.Diagnostics;
using ADODB;
namespace ControleurServeur
{
    internal class DetailTemps : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public DetailTemps() : base()
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
        internal static Button cmdImprimer;
        internal static Button cmdOK;
        internal static ColumnHeader _lvwTemps_ColumnHeader_1;
        internal static ColumnHeader _lvwTemps_ColumnHeader_2;
        internal static ColumnHeader _lvwTemps_ColumnHeader_3;
        internal static ListView lvwTemps;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdImprimer = new System.Windows.Forms.Button();
            cmdOK = new System.Windows.Forms.Button();
            lvwTemps = new System.Windows.Forms.ListView();
            _lvwTemps_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwTemps_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwTemps_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            SuspendLayout();//cmdImprimer
            cmdImprimer.BackColor = System.Drawing.Color.Black;
            cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdImprimer.ForeColor = System.Drawing.Color.White;
            cmdImprimer.Location = new System.Drawing.Point(300, 347);
            cmdImprimer.Name = "cmdImprimer";
            cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdImprimer.Size = new System.Drawing.Size(73, 25);
            cmdImprimer.TabIndex = 2;
            cmdImprimer.Text = "Imprimer";
            cmdImprimer.UseVisualStyleBackColor = true;
            cmdImprimer.Click += new System.EventHandler(cmdImprimer_Click);//cmdOK
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(380, 347);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(73, 25);
            cmdOK.TabIndex = 1;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);//lvwTemps
            lvwTemps.BackColor = System.Drawing.Color.Black;
            lvwTemps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwTemps_ColumnHeader_1,
            _lvwTemps_ColumnHeader_2,
            _lvwTemps_ColumnHeader_3});
            lvwTemps.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwTemps.ForeColor = System.Drawing.Color.White;
            lvwTemps.FullRowSelect = true;
            lvwTemps.GridLines = true;
            lvwTemps.HideSelection = false;
            lvwTemps.Location = new System.Drawing.Point(12, 67);
            lvwTemps.Name = "lvwTemps";
            lvwTemps.Size = new System.Drawing.Size(441, 273);
            lvwTemps.TabIndex = 0;
            lvwTemps.UseCompatibleStateImageBehavior = false;
            lvwTemps.View = System.Windows.Forms.View.Details;//_lvwTemps_ColumnHeader_1
            _lvwTemps_ColumnHeader_1.Text = "Employé";
            _lvwTemps_ColumnHeader_1.Width = 403;//_lvwTemps_ColumnHeader_2
            _lvwTemps_ColumnHeader_2.Text = "Type";
            _lvwTemps_ColumnHeader_2.Width = 236;//_lvwTemps_ColumnHeader_3
            _lvwTemps_ColumnHeader_3.Text = "Heures";
            _lvwTemps_ColumnHeader_3.Width = 366;//DetailTemps
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(463, 381);
            ControlBox = false;
            Controls.Add(cmdImprimer);
            Controls.Add(cmdOK);
            Controls.Add(lvwTemps);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(3, 22);
            Name = "DetailTemps";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Text = "ControleurServeur." + Name;
            ShowInTaskbar = false;
            Load += new System.EventHandler(DetailTemps_Load);
            ResumeLayout(false);
        }
        #endregion
        private const int I_COL_EMPLOYE = 0;
        private const int I_COL_TYPE = 1;
        private const int I_COL_HEURES = 2;
        public static string m_sNoProjet = "";
        private bool m_bProjet;
        private EnumCatalogue m_eType;
        private string sNoProjSoum;

        public DetailTemps(string sNoProjet, EnumCatalogue eType, bool bProjet)
        {
            InitializeComponent();
            try
            {
                m_eType = eType;
                m_sNoProjet = sNoProjet;
                m_bProjet = bProjet;
                RemplirListViewTemps(sNoProjet);
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DetailTemps", "Afficher", ex);
            }
        }
        private void RemplirListViewTemps(string sNoProjet)
        {
            try
            {
                ADODB.Recordset rstPunch;
                ListViewItem itmPunch;
                string sFilterNoProjet;
                if (Droite(sNoProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(sNoProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + sNoProjet + "'";
                }
                rstPunch = new Recordset();
                rstPunch.Open("SELECT Employe, Type, (Sum(TimeSerial(LEFT(HeureFin, 2), RIGHT(HeureFin, 2), 0) - TimeSerial(LEFT(HeureDébut, 2), RIGHT(HeureDébut, 2), 0)) * 24) AS TotalHeures FROM Punch INNER JOIN Employés ON Punch.NoEmploye = Employés.NoEmploye WHERE HeureDébut is Not Null And HeureFin is Not Null AND " + sFilterNoProjet + " GROUP BY Employe, Type", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPunch.EOF)
                {
                    itmPunch = lvwTemps.Items.Add(string.Empty);
                    itmPunch.Text = (string)(rstPunch.Fields["Employe"].Value);

                    if (itmPunch.SubItems.Count > I_COL_TYPE)
                    {
                        itmPunch.SubItems[I_COL_TYPE].Text = (string)(rstPunch.Fields["Type"].Value);
                    }
                    else
                    {
                        itmPunch.SubItems.Insert(I_COL_TYPE, new ListViewItem.ListViewSubItem(null, (string)(rstPunch.Fields["Type"].Value)));
                    }
                    if (itmPunch.SubItems.Count > I_COL_HEURES)
                    {
                        itmPunch.SubItems[I_COL_HEURES].Text = (string)(Math.Round(rstPunch.Fields["TotalHeures"].Value, 2));
                    }
                    else
                    {
                        itmPunch.SubItems.Insert(I_COL_HEURES, new ListViewItem.ListViewSubItem(null, (string)(Math.Round(rstPunch.Fields["TotalHeures"].Value, 2))));
                    }
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DetailTemps", "RemplirListViewTemps", ex);
            }
        }
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            int intdummie;
            try
            {
                if (m_eType == EnumCatalogue.ELECTRIQUE)
                {
                    intdummie = (int)MessageBox.Show("Désirez-vous exporter les données dans Excel ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (intdummie == 0x06)
                    {
                        vb_to_excel();
                    }
                    ImprimerDetailTempsElectriques();
                }
                else
                {
                    intdummie = (int)MessageBox.Show("Désirez-vous exporter les données dans Excel ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (intdummie == 0x06)
                    {
                        vb_to_excel();
                    }
                    ImprimerDetailTempsMecaniques();
                }

                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DetailTemps", "cmdImprimer_Click", ex);
            }
        }
        [Obsolete]
        private void ImprimerDetailTempsElectriques()
        {
            try
            {
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstImpTemps;
                ADODB.Recordset rstProjSoum;
                double dblTotal;
                string sFilterNoProjet;
                if (Droite(m_sNoProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(m_sNoProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + m_sNoProjet + "'";
                }
                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT Employe, Type, (Sum(TimeSerial(Left(HeureFin,2), RIGHT(HeureFin,2),0) - TimeSerial(Left(HeureDébut,2), RIGHT(HeureDébut,2),0)) * 24) AS TotalHeures FROM Punch " +
                    "INNER JOIN Employés ON Punch.NoEmploye = Employés.NoEmploye " +
                    "WHERE HeureDébut is Not Null And HeureFin is Not Null AND " + sFilterNoProjet + " GROUP BY Employe, Type", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                UpdateSQL("DELETE FROM ImpressionDetailTemps");
                rstImpTemps = new Recordset();
                rstImpTemps.Open("SELECT * FROM ImpressionDetailTemps", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstEmploye.EOF)
                {
                    rstImpTemps.AddNew();
                    rstImpTemps.Fields["Employe"].Value = rstEmploye.Fields["Employe"].Value;
                    if (!(rstEmploye.Fields["Type"].Value is DBNull))
                    {
                        rstImpTemps.Fields["Type"].Value = rstEmploye.Fields["Type"].Value;
                    }
                    else
                    {
                        rstImpTemps.Fields["Type"].Value = "";
                    }
                    rstImpTemps.Fields["TotalHeures"].Value = rstEmploye.Fields["TotalHeures"].Value;
                    rstImpTemps.Update();
                    rstEmploye.MoveNext();
                }
                rstEmploye.Close();
                rstEmploye = null;
                ControleurServeur.ViewTempsElec.DataSource = rstImpTemps;
                rstProjSoum = new Recordset();
                if (m_bProjet == true)
                {
                    rstProjSoum.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstProjSoum.Open("SELECT * FROM SoumissionElec WHERE IDSoumission = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                ControleurServeur.ViewTempsElec.lblNoProjet.Text = m_sNoProjet;
                if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsDessinEstime.Text = Math.Round(rstProjSoum.Fields["TempsDessin"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsDessinEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsFabrication"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsFabricationEstime.Text = Math.Round(rstProjSoum.Fields["TempsFabrication"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsFabricationEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsAssemblageEstime.Text = Math.Round(rstProjSoum.Fields["TempsAssemblage"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsAssemblageEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsProgInterface"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsProgInterfaceEstime.Text = Math.Round(rstProjSoum.Fields["TempsProgInterface"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsProgInterfaceEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsProgAutomate"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsProgAutomateEstime.Text = Math.Round(rstProjSoum.Fields["TempsProgAutomate"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsProgAutomateEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsProgRobot"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsProgRobotEstime.Text = Math.Round(rstProjSoum.Fields["TempsProgRobot"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsProgRobotEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsVision"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsVisionEstime.Text = Math.Round(rstProjSoum.Fields["TempsVision"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsVisionEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsTestEstime.Text = Math.Round(rstProjSoum.Fields["TempsTest"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsTestEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsInstallationEstime.Text = Math.Round(rstProjSoum.Fields["TempsInstallation"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsInstallationEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsMiseService"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsMiseServiceEstime.Text = Math.Round(rstProjSoum.Fields["TempsMiseService"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsMiseServiceEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsFormationEstime.Text = Math.Round(rstProjSoum.Fields["TempsFormation"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsFormationEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsGestionEstime.Text = Math.Round(rstProjSoum.Fields["TempsGestion"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsGestionEstime.Text = "0";
                }
                if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTempsShippingEstime.Text = Math.Round(rstProjSoum.Fields["TempsShipping"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTempsShippingEstime.Text = "0";
                }
                dblTotal = double.Parse(ControleurServeur.ViewTempsElec.lblTempsDessinEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsFabricationEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsAssemblageEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsProgInterfaceEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsProgAutomateEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsProgRobotEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsVisionEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsTestEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsInstallationEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsMiseServiceEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsFormationEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsGestionEstime.Text)
                + double.Parse(ControleurServeur.ViewTempsElec.lblTempsShippingEstime.Text);
                ControleurServeur.ViewTempsElec.lblTotalTempsEstime.Text = dblTotal.ToString();
                rstProjSoum.Close();
                rstProjSoum = null;
                CalculerTempsReelsElec();
                rstImpTemps.Close();
                rstImpTemps = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DetailTemps", "ImprimerDetailTempsElectriques", ex);
            }
        }
        [Obsolete]
        private void ImprimerDetailTempsMecaniques()
        {
            try
            {
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstImpTemps;
                ADODB.Recordset rstProjSoum;
                ADODB.Recordset rstSoum;
                double dblTotal;
                string sFilterNoProjet;
                if (Droite(m_sNoProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(m_sNoProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + m_sNoProjet + "'";
                }
                rstEmploye = new Recordset();
                rstEmploye.Open("SELECT Employe, Type, (Sum(TimeSerial(Left(HeureFin,2), RIGHT(HeureFin,2),0) - TimeSerial(Left(HeureDébut,2), RIGHT(HeureDébut,2),0)) * 24) AS TotalHeures FROM Punch INNER JOIN Employés ON Punch.NoEmploye = Employés.NoEmploye WHERE HeureDébut is Not Null And HeureFin is Not Null AND " + sFilterNoProjet + " GROUP BY Employe, Type", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                UpdateSQL("DELETE FROM ImpressionDetailTemps");
                rstImpTemps = new Recordset();
                rstImpTemps.Open("SELECT * FROM ImpressionDetailTemps", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstEmploye.EOF)
                {
                    rstImpTemps.AddNew();
                    rstImpTemps.Fields["Employe"].Value = rstEmploye.Fields["Employe"].Value;
                    if (!(rstEmploye.Fields["Type"].Value is DBNull))
                    {
                        rstImpTemps.Fields["Type"].Value = rstEmploye.Fields["Type"].Value;
                    }
                    else
                    {
                        rstImpTemps.Fields["Type"].Value = "";
                    }
                    rstImpTemps.Fields["TotalHeures"].Value = rstEmploye.Fields["TotalHeures"].Value;
                    rstImpTemps.Update();
                    rstEmploye.MoveNext();
                }
                rstEmploye.Close();
                rstEmploye = null;
                ControleurServeur.ViewTempsMec.DataSource = rstImpTemps;
                rstProjSoum = new Recordset();
                if (m_bProjet == true)
                {
                    rstProjSoum.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstProjSoum.Open("SELECT * FROM SoumissionMec WHERE IDSoumission = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                ControleurServeur.ViewTempsMec.lblNoProjet.Text = m_sNoProjet;
                if (m_bProjet == false)
                {
                    if (!(rstProjSoum.Fields["TempsDessin"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsDessinSoum.Text = Math.Round(rstProjSoum.Fields["TempsDessin"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsDessinSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsCoupe"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsCoupeSoum.Text = Math.Round(rstProjSoum.Fields["TempsCoupe"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsCoupeSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsMachinage"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsMachinageSoum.Text = Math.Round(rstProjSoum.Fields["TempsMachinage"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsMachinageSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsSoudure"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsSoudureSoum.Text = Math.Round(rstProjSoum.Fields["TempsSoudure"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsSoudureSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsAssemblage"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsAssemblageSoum.Text = Math.Round(rstProjSoum.Fields["TempsAssemblage"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsAssemblageSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsPeinture"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsPeintureSoum.Text = Math.Round(rstProjSoum.Fields["TempsPeinture"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsPeintureSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsTest"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsTestSoum.Text = Math.Round(rstProjSoum.Fields["TempsTest"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsTestSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsInstallation"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsInstallationSoum.Text = Math.Round(rstProjSoum.Fields["TempsInstallation"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsInstallationSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsFormation"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsFormationSoum.Text = Math.Round(rstProjSoum.Fields["TempsFormation"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsFormationSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsGestion"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsGestionSoum.Text = Math.Round(rstProjSoum.Fields["TempsGestion"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsGestionSoum.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsShipping"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsShippingSoum.Text = Math.Round(rstProjSoum.Fields["TempsShipping"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsShippingSoum.Text = "0"; }
                    ControleurServeur.ViewTempsMec.lblTempsDessinProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsCoupeProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsMachinageProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsSoudureProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsAssemblageProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsPeintureProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsTestProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsInstallationProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsFormationProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsGestionProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsShippingProj.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsDessinConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsCoupeConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsMachinageConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsSoudureConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsAssemblageConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsPeintureConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsTestConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsInstallationConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsFormationConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsGestionConc.Text = "---";
                    ControleurServeur.ViewTempsMec.lblTempsShippingConc.Text = "---";
                }
                else
                {
                    if (!(rstProjSoum.Fields["IDSoumission"].Value is DBNull))
                    {
                        rstSoum = new Recordset();
                        rstSoum.Open("SELECT * FROM SoumissionMec WHERE IDSoumission = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstSoum.EOF)
                        {
                            if (!(rstSoum.Fields["TempsDessin"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsDessinSoum.Text = Math.Round(rstSoum.Fields["TempsDessin"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsDessinSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsCoupe"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsCoupeSoum.Text = Math.Round(rstSoum.Fields["TempsCoupe"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsCoupeSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsMachinage"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsMachinageSoum.Text = Math.Round(rstSoum.Fields["TempsMachinage"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsMachinageSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsSoudure"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsSoudureSoum.Text = Math.Round(rstSoum.Fields["TempsSoudure"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsSoudureSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsAssemblage"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsAssemblageSoum.Text = Math.Round(rstSoum.Fields["TempsAssemblage"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsAssemblageSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsPeinture"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsPeintureSoum.Text = Math.Round(rstSoum.Fields["TempsPeinture"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsPeintureSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsTest"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsTestSoum.Text = Math.Round(rstSoum.Fields["TempsTest"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsTestSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsInstallation"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsInstallationSoum.Text = Math.Round(rstSoum.Fields["TempsInstallation"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsInstallationSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsFormation"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsFormationSoum.Text = Math.Round(rstSoum.Fields["TempsFormation"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsFormationSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsGestion"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsGestionSoum.Text = Math.Round(rstSoum.Fields["TempsGestion"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsGestionSoum.Text = "0"; }
                            if (!(rstSoum.Fields["TempsShipping"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsShippingSoum.Text = Math.Round(rstSoum.Fields["TempsShipping"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsShippingSoum.Text = "0"; }
                        }
                        else
                        {
                            ControleurServeur.ViewTempsMec.lblTempsDessinSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsCoupeSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsMachinageSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsSoudureSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsAssemblageSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsPeintureSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsTestSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsInstallationSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsFormationSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsGestionSoum.Text = "---";
                            ControleurServeur.ViewTempsMec.lblTempsShippingSoum.Text = "---";
                        }
                        rstSoum.Close();
                        rstSoum = null;
                    }
                    else
                    {
                        ControleurServeur.ViewTempsMec.lblTempsDessinSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsCoupeSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsMachinageSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsSoudureSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsAssemblageSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsPeintureSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsTestSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsInstallationSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsFormationSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsGestionSoum.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsShippingSoum.Text = "---";
                    }
                    if (!(rstProjSoum.Fields["TempsDessinProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsDessinProj.Text = Math.Round(rstProjSoum.Fields["TempsDessinProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsDessinProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsCoupeProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsCoupeProj.Text = Math.Round(rstProjSoum.Fields["TempsCoupeProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsCoupeProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsMachinageProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsMachinageProj.Text = Math.Round(rstProjSoum.Fields["TempsMachinageProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsMachinageProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsSoudureProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsSoudureProj.Text = Math.Round(rstProjSoum.Fields["TempsSoudureProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsSoudureProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsAssemblageProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsAssemblageProj.Text = Math.Round(rstProjSoum.Fields["TempsAssemblageProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsAssemblageProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsPeintureProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsPeintureProj.Text = Math.Round(rstProjSoum.Fields["TempsPeintureProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsPeintureProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsTestProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsTestProj.Text = Math.Round(rstProjSoum.Fields["TempsTestProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsTestProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsInstallationProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsInstallationProj.Text = Math.Round(rstProjSoum.Fields["TempsInstallationProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsInstallationProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsFormationProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsFormationProj.Text = Math.Round(rstProjSoum.Fields["TempsFormationProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsFormationProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsGestionProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsGestionProj.Text = Math.Round(rstProjSoum.Fields["TempsGestionProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsGestionProj.Text = "0"; }
                    if (!(rstProjSoum.Fields["TempsShippingProj"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsShippingProj.Text = Math.Round(rstProjSoum.Fields["TempsShippingProj"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsShippingProj.Text = "0"; }
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstProjSoum.Fields["TempsProjBarré"].Value, true, false)))
                    {
                        if (!(rstProjSoum.Fields["TempsDessinConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsDessinConc.Text = Math.Round(rstProjSoum.Fields["TempsDessinConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsDessinConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsCoupeConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsCoupeConc.Text = Math.Round(rstProjSoum.Fields["TempsCoupeConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsCoupeConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsMachinageConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsMachinageConc.Text = Math.Round(rstProjSoum.Fields["TempsMachinageConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsMachinageConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsSoudureConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsSoudureConc.Text = Math.Round(rstProjSoum.Fields["TempsSoudureConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsSoudureConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsAssemblageConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsAssemblageConc.Text = Math.Round(rstProjSoum.Fields["TempsAssemblageConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsAssemblageConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsPeintureConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsPeintureConc.Text = Math.Round(rstProjSoum.Fields["TempsPeintureConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsPeintureConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsTestConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsTestConc.Text = Math.Round(rstProjSoum.Fields["TempsTestConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsTestConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsInstallationConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsInstallationConc.Text = Math.Round(rstProjSoum.Fields["TempsInstallationConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsInstallationConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsFormationConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsFormationConc.Text = Math.Round(rstProjSoum.Fields["TempsFormationConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsFormationConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsGestionConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsGestionConc.Text = Math.Round(rstProjSoum.Fields["TempsGestionConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsGestionConc.Text = "0"; }
                        if (!(rstProjSoum.Fields["TempsShippingConc"].Value is DBNull)) { ControleurServeur.ViewTempsMec.lblTempsShippingConc.Text = Math.Round(rstProjSoum.Fields["TempsShippingConc"].Value, 2).ToString(); } else { ControleurServeur.ViewTempsMec.lblTempsShippingConc.Text = "0"; }
                    }
                    else
                    {
                        ControleurServeur.ViewTempsMec.lblTempsDessinConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsCoupeConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsMachinageConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsSoudureConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsAssemblageConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsPeintureConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsTestConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsInstallationConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsFormationConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsGestionConc.Text = "---";
                        ControleurServeur.ViewTempsMec.lblTempsShippingConc.Text = "---";
                    }
                }
                if ((ControleurServeur.ViewTempsMec.lblTempsDessinSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsCoupeSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsMachinageSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsSoudureSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsAssemblageSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsPeintureSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsTestSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsInstallationSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsFormationSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsGestionSoum.Text != "---")
                    & (ControleurServeur.ViewTempsMec.lblTempsShippingSoum.Text != "---"))
                {
                    ControleurServeur.ViewTempsMec.lblTotalTempsSoum.Text = "---";
                }
                else
                {
                    dblTotal = double.Parse(ControleurServeur.ViewTempsMec.lblTempsDessinSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsCoupeSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsMachinageSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsSoudureSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsAssemblageSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsPeintureSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsTestSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsInstallationSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsFormationSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsGestionSoum.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsShippingSoum.Text);
                    ControleurServeur.ViewTempsMec.lblTotalTempsSoum.Text = dblTotal.ToString();
                }
                if ((ControleurServeur.ViewTempsMec.lblTempsDessinProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsCoupeProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsMachinageProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsSoudureProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsAssemblageProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsPeintureProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsTestProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsInstallationProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsFormationProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsGestionProj.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsGestionProj.Text != "---"))
                {
                    ControleurServeur.ViewTempsMec.lblTotalTempsProj.Text = "---";
                }
                else
                {
                    dblTotal = double.Parse(ControleurServeur.ViewTempsMec.lblTempsDessinProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsCoupeProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsMachinageProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsSoudureProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsAssemblageProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsPeintureProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsTestProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsInstallationProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsFormationProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsGestionProj.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsShippingProj.Text);
                    ControleurServeur.ViewTempsMec.lblTotalTempsProj.Text = dblTotal.ToString();
                }
                if ((ControleurServeur.ViewTempsMec.lblTempsDessinConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsCoupeConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsMachinageConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsSoudureConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsAssemblageConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsPeintureConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsTestConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsInstallationConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsFormationConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsGestionConc.Text != "---") & (ControleurServeur.ViewTempsMec.lblTempsShippingConc.Text != "---"))
                {
                    ControleurServeur.ViewTempsMec.lblTotalTempsConc.Text = "---";
                }
                else
                {
                    dblTotal = double.Parse(ControleurServeur.ViewTempsMec.lblTempsDessinConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsCoupeConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsMachinageConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsSoudureConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsAssemblageConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsPeintureConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsTestConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsInstallationConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsFormationConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsGestionConc.Text)
                        + double.Parse(ControleurServeur.ViewTempsMec.lblTempsShippingConc.Text);
                    ControleurServeur.ViewTempsMec.lblTotalTempsConc.Text = dblTotal.ToString();
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                CalculerTempsReelsMec();
                rstImpTemps.Close();
                rstImpTemps = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DetailTemps", "ImprimerDetailTempsMecaniques", ex);
            }
        }
        private void CalculerTempsReelsElec()
        {
            try
            {
                ADODB.Recordset rstTotal;
                string sDateDebut;
                string sDateFin;
                string sTotal;
                string sFilterNoProjet;
                if (Droite(m_sNoProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(m_sNoProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + m_sNoProjet + "'";
                }
                rstTotal = new Recordset();
                sDateDebut = "TIMESERIAL(Left(Punch.HeureDébut,2),RIGHT(Punch.HeureDébut,2),0)";
                sDateFin = "TIMESERIAL(Left(Punch.HeureFin,2),RIGHT(Punch.HeureFin,2),0)";
                sTotal = "(SUM(" + sDateFin + " - " + sDateDebut + ")* 24) As Total";
                rstTotal.Open("SELECT Type, " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null GROUP BY Type", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ControleurServeur.ViewTempsElec.lblTempsDessinReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsFabricationReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsAssemblageReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsProgInterfaceReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsProgAutomateReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsProgRobotReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsVisionReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsTestReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsInstallationReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsMiseServiceReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsFormationReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsGestionReel.Text = "0";
                ControleurServeur.ViewTempsElec.lblTempsShippingReel.Text = "0";
                while (!rstTotal.EOF)
                {
                    if (!(rstTotal.Fields["Total"].Value is DBNull))
                    {
                        switch (rstTotal.Fields["Type"].Value)
                        {
                            case "Dessin": { ControleurServeur.ViewTempsElec.lblTempsDessinReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Fabrication": { ControleurServeur.ViewTempsElec.lblTempsFabricationReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Assemblage": { ControleurServeur.ViewTempsElec.lblTempsAssemblageReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "ProgInterface": { ControleurServeur.ViewTempsElec.lblTempsProgInterfaceReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "ProgAutomate": { ControleurServeur.ViewTempsElec.lblTempsProgAutomateReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "ProgRobot": { ControleurServeur.ViewTempsElec.lblTempsProgRobotReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Vision": { ControleurServeur.ViewTempsElec.lblTempsVisionReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Test": { ControleurServeur.ViewTempsElec.lblTempsTestReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Installation": { ControleurServeur.ViewTempsElec.lblTempsInstallationReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "MiseService": { ControleurServeur.ViewTempsElec.lblTempsMiseServiceReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Formation": { ControleurServeur.ViewTempsElec.lblTempsFormationReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Gestion": { ControleurServeur.ViewTempsElec.lblTempsGestionReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Shipping": { ControleurServeur.ViewTempsElec.lblTempsShippingReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Prototypage-Dévelloppement expérimental": { ControleurServeur.ViewTempsElec.lblTempsprototypeReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                        }
                    }
                    rstTotal.MoveNext();
                }
                rstTotal.Close();
                rstTotal.Open("SELECT " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!(rstTotal.Fields["Total"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsElec.lblTotalTempsReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsElec.lblTotalTempsReel.Text = "0";
                }
                rstTotal.Close();
                rstTotal = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DetailTemps", "CalculerTempsReelsElec", ex);
            }
        }
        private void CalculerTempsReelsMec()
        {
            try
            {
                ADODB.Recordset rstTotal;
                string sDateDebut;
                string sDateFin;
                string sTotal;
                string sFilterNoProjet;
                if (Droite(m_sNoProjet, 2) == "99")
                {
                    sFilterNoProjet = "LEFT(NoProjet, 6) = '" + Gauche(m_sNoProjet, 6) + "'";
                }
                else
                {
                    sFilterNoProjet = "NoProjet = '" + m_sNoProjet + "'";
                }
                rstTotal = new Recordset();
                sDateDebut = "TIMESERIAL(Left(Punch.HeureDébut,2),RIGHT(Punch.HeureDébut,2),0)";
                sDateFin = "TIMESERIAL(Left(Punch.HeureFin,2),RIGHT(Punch.HeureFin,2),0)";
                sTotal = "(SUM(" + sDateFin + " - " + sDateDebut + ")* 24) As Total";
                rstTotal.Open("SELECT Type, " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null GROUP BY Type", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                ControleurServeur.ViewTempsMec.lblTempsDessinProj.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsCoupeReel.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsMachinageReel.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsSoudureReel.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsMachinageProj.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsPeintureReel.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsInstallationProj.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsFormationProj.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsShippingProj.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsGestionReel.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsShippingReel.Text = "0";
                ControleurServeur.ViewTempsMec.lblTempsPrototypeReel.Text = "0";
                while (!rstTotal.EOF)
                {
                    if (!(rstTotal.Fields["Total"].Value is DBNull))
                    {
                        switch (rstTotal.Fields["Type"].Value)
                        {
                            case "Dessin": { ControleurServeur.ViewTempsMec.lblTempsDessinProj.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Coupe": { ControleurServeur.ViewTempsMec.lblTempsCoupeReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Machinage": { ControleurServeur.ViewTempsMec.lblTempsMachinageReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Soudure": { ControleurServeur.ViewTempsMec.lblTempsSoudureReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Assemblage": { ControleurServeur.ViewTempsMec.lblTempsMachinageProj.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Peinture": { ControleurServeur.ViewTempsMec.lblTempsPeintureReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Test": { ControleurServeur.ViewTempsMec.lblTempsInstallationProj.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Installation": { ControleurServeur.ViewTempsMec.lblTempsFormationProj.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Formation": { ControleurServeur.ViewTempsMec.lblTempsShippingProj.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Gestion": { ControleurServeur.ViewTempsMec.lblTempsGestionReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Shipping": { ControleurServeur.ViewTempsMec.lblTempsShippingReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                            case "Prototypage-Dévelloppement expérimental": { ControleurServeur.ViewTempsMec.lblTempsPrototypeReel.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString(); break; }
                        }
                    }
                    rstTotal.MoveNext();
                }
                rstTotal.Close();
                rstTotal.Open("SELECT " + sTotal + " FROM Punch WHERE " + sFilterNoProjet + " And HeureFin is not null AND HeureDébut is not null", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!(rstTotal.Fields["Total"].Value is DBNull))
                {
                    ControleurServeur.ViewTempsMec.lblTotalTempsProj.Text = Math.Round(rstTotal.Fields["Total"].Value, 2).ToString();
                }
                else
                {
                    ControleurServeur.ViewTempsMec.lblTotalTempsProj.Text = "0";
                }
                rstTotal.Close();
                rstTotal = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DetailTemps", "CalculerTempsReelsMec", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DetailTemps", "cmdOK_Click", ex);
            }
        }
        private object vb_to_excel()
        {
            int iCount;
            Microsoft.Office.Interop.Excel.Application oXLApp;
            Microsoft.Office.Interop.Excel.Workbook oXLBook;
            Microsoft.Office.Interop.Excel.Worksheet oXLSheet;
            var data_array = new object[501, 5];
            int r;
            oXLApp = new Microsoft.Office.Interop.Excel.Application();
            oXLBook = oXLApp.Workbooks.Add();
            oXLSheet = (Microsoft.Office.Interop.Excel.Worksheet)oXLBook.Worksheets[1];
            oXLApp.Visible = false;
            r = 1;
            while (!(r <= lvwTemps.Items.Count == null))
            {
                data_array[r, 1] = lvwTemps.Items[r].Text;

                data_array[r, 2] = lvwTemps.Items[r].SubItems[1].Text;

                data_array[r, 3] = double.Parse(lvwTemps.Items[r].SubItems[2].Text);
                r = (int)(r + 1);
            }
            oXLSheet.Columns[1].ColumnWidth = 30;
            oXLSheet.Columns[2].ColumnWidth = 30;
            oXLSheet.Columns[3].ColumnWidth = 10;
            oXLSheet.get_Range("A1: C1").Font.Bold = true;
            oXLSheet.get_Range("A1: C1").set_Value(value: new object[] { "Employé", "Type", "heures" });
            oXLSheet.get_Range("A2").get_Resize(r, 3).set_Value(data_array);
            oXLApp.Visible = true;
            return default;
        }
        private void Command1_Click() => vb_to_excel();
        private void DetailTemps_Load(object sender, EventArgs e)
        {
        }
    }
}