using System;
using System.Drawing;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ADODB;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Button = System.Windows.Forms.Button;
using ListView = System.Windows.Forms.ListView;
using ListViewItem = System.Windows.Forms.ListViewItem;

#pragma warning disable CS0168
#pragma warning disable CS0414
namespace ControleurServeur
{
    internal class ChoixBonCommande : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixBonCommande() : base()
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
        internal static Button cmdDeselectAll;
        internal static Button cmdSelectAll;
        internal static Button cmdAnnulerFRS;
        internal static Button cmdOKFRS;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_1;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_2;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_3;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_4;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_5;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_6;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_7;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_8;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_9;
        internal static ColumnHeader _lvwFournisseur_ColumnHeader_10;
        internal static ListView lvwFournisseur;
        internal static GroupBox fraFournisseur;
        internal static Button cmdAnnuler;
        internal static Button cmdCommander;
        internal static ColumnHeader _lvwPiece_ColumnHeader_1;
        internal static ColumnHeader _lvwPiece_ColumnHeader_2;
        internal static ColumnHeader _lvwPiece_ColumnHeader_3;
        internal static ColumnHeader _lvwPiece_ColumnHeader_4;
        internal static ColumnHeader _lvwPiece_ColumnHeader_5;
        internal static ColumnHeader _lvwPiece_ColumnHeader_6;
        internal static ListView lvwPiece;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdDeselectAll = new System.Windows.Forms.Button();
            cmdSelectAll = new System.Windows.Forms.Button();
            fraFournisseur = new System.Windows.Forms.GroupBox();
            cmdAnnulerFRS = new System.Windows.Forms.Button();
            cmdOKFRS = new System.Windows.Forms.Button();
            lvwFournisseur = new System.Windows.Forms.ListView();
            _lvwFournisseur_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_4 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_5 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_6 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_7 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_8 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_9 = new System.Windows.Forms.ColumnHeader();
            _lvwFournisseur_ColumnHeader_10 = new System.Windows.Forms.ColumnHeader();
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdCommander = new System.Windows.Forms.Button();
            lvwPiece = new System.Windows.Forms.ListView();
            _lvwPiece_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lvwPiece_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _lvwPiece_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            _lvwPiece_ColumnHeader_4 = new System.Windows.Forms.ColumnHeader();
            _lvwPiece_ColumnHeader_5 = new System.Windows.Forms.ColumnHeader();
            _lvwPiece_ColumnHeader_6 = new System.Windows.Forms.ColumnHeader();
            fraFournisseur.SuspendLayout();
            SuspendLayout();
            // 
            // cmdDeselectAll
            // 
            cmdDeselectAll.BackColor = System.Drawing.Color.Black;
            cmdDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdDeselectAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdDeselectAll.ForeColor = System.Drawing.Color.White;
            cmdDeselectAll.Location = new System.Drawing.Point(88, 400);
            cmdDeselectAll.Name = "cmdDeselectAll";
            cmdDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDeselectAll.Size = new System.Drawing.Size(73, 25);
            cmdDeselectAll.TabIndex = 6;
            cmdDeselectAll.Text = "Aucun";
            cmdDeselectAll.UseVisualStyleBackColor = true;
            cmdDeselectAll.Click += new System.EventHandler(cmdDeSelectAll_Click);
            // 
            // cmdSelectAll
            // 
            cmdSelectAll.BackColor = System.Drawing.Color.Black;
            cmdSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdSelectAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdSelectAll.ForeColor = System.Drawing.Color.White;
            cmdSelectAll.Location = new System.Drawing.Point(8, 400);
            cmdSelectAll.Name = "cmdSelectAll";
            cmdSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSelectAll.Size = new System.Drawing.Size(73, 25);
            cmdSelectAll.TabIndex = 5;
            cmdSelectAll.Text = "Tous";
            cmdSelectAll.UseVisualStyleBackColor = true;
            cmdSelectAll.Click += new System.EventHandler(cmdSelectAll_Click);
            // 
            // fraFournisseur
            // 
            fraFournisseur.BackColor = System.Drawing.Color.Black;
            fraFournisseur.Controls.Add(cmdAnnulerFRS);
            fraFournisseur.Controls.Add(cmdOKFRS);
            fraFournisseur.Controls.Add(lvwFournisseur);
            fraFournisseur.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraFournisseur.ForeColor = System.Drawing.Color.AliceBlue;
            fraFournisseur.Location = new System.Drawing.Point(12, 54);
            fraFournisseur.Name = "fraFournisseur";
            fraFournisseur.Padding = new System.Windows.Forms.Padding(0);
            fraFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraFournisseur.Size = new System.Drawing.Size(673, 161);
            fraFournisseur.TabIndex = 0;
            fraFournisseur.TabStop = false;
            fraFournisseur.Text = "Fournisseurs";
            fraFournisseur.Visible = false;
            // 
            // cmdAnnulerFRS
            // 
            cmdAnnulerFRS.BackColor = System.Drawing.Color.Black;
            cmdAnnulerFRS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnulerFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnulerFRS.ForeColor = System.Drawing.Color.White;
            cmdAnnulerFRS.Location = new System.Drawing.Point(592, 127);
            cmdAnnulerFRS.Name = "cmdAnnulerFRS";
            cmdAnnulerFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnulerFRS.Size = new System.Drawing.Size(73, 25);
            cmdAnnulerFRS.TabIndex = 2;
            cmdAnnulerFRS.Text = "Annuler";
            cmdAnnulerFRS.UseVisualStyleBackColor = true;
            cmdAnnulerFRS.Click += new System.EventHandler(cmdAnnulerFRS_Click);
            // 
            // cmdOKFRS
            // 
            cmdOKFRS.BackColor = System.Drawing.Color.Black;
            cmdOKFRS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOKFRS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOKFRS.ForeColor = System.Drawing.Color.White;
            cmdOKFRS.Location = new System.Drawing.Point(513, 126);
            cmdOKFRS.Name = "cmdOKFRS";
            cmdOKFRS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOKFRS.Size = new System.Drawing.Size(73, 25);
            cmdOKFRS.TabIndex = 3;
            cmdOKFRS.Text = "OK";
            cmdOKFRS.UseVisualStyleBackColor = true;
            cmdOKFRS.Click += new System.EventHandler(cmdOKFRS_Click);
            // 
            // lvwFournisseur
            // 
            lvwFournisseur.BackColor = System.Drawing.Color.Black;
            lvwFournisseur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwFournisseur_ColumnHeader_1,
            _lvwFournisseur_ColumnHeader_2,
            _lvwFournisseur_ColumnHeader_3,
            _lvwFournisseur_ColumnHeader_4,
            _lvwFournisseur_ColumnHeader_5,
            _lvwFournisseur_ColumnHeader_6,
            _lvwFournisseur_ColumnHeader_7,
            _lvwFournisseur_ColumnHeader_8,
            _lvwFournisseur_ColumnHeader_9,
            _lvwFournisseur_ColumnHeader_10});
            lvwFournisseur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwFournisseur.ForeColor = System.Drawing.Color.AliceBlue;
            lvwFournisseur.FullRowSelect = true;
            lvwFournisseur.GridLines = true;
            lvwFournisseur.Location = new System.Drawing.Point(8, 16);
            lvwFournisseur.Name = "lvwFournisseur";
            lvwFournisseur.Size = new System.Drawing.Size(657, 105);
            lvwFournisseur.TabIndex = 1;
            lvwFournisseur.UseCompatibleStateImageBehavior = false;
            lvwFournisseur.View = System.Windows.Forms.View.Details;
            lvwFournisseur.DoubleClick += new System.EventHandler(lvwFournisseur_DoubleClick);
            // 
            // _lvwFournisseur_ColumnHeader_1
            // 
            _lvwFournisseur_ColumnHeader_1.Text = "Fournisseur";
            _lvwFournisseur_ColumnHeader_1.Width = 236;
            // 
            // _lvwFournisseur_ColumnHeader_2
            // 
            _lvwFournisseur_ColumnHeader_2.Text = "Pers. Ress.";
            _lvwFournisseur_ColumnHeader_2.Width = 133;
            // 
            // _lvwFournisseur_ColumnHeader_3
            // 
            _lvwFournisseur_ColumnHeader_3.Text = "Date";
            _lvwFournisseur_ColumnHeader_3.Width = 117;
            // 
            // _lvwFournisseur_ColumnHeader_4
            // 
            _lvwFournisseur_ColumnHeader_4.Text = "Par";
            _lvwFournisseur_ColumnHeader_4.Width = 54;
            // 
            // _lvwFournisseur_ColumnHeader_5
            // 
            _lvwFournisseur_ColumnHeader_5.Text = "Valide";
            _lvwFournisseur_ColumnHeader_5.Width = 117;
            // 
            // _lvwFournisseur_ColumnHeader_6
            // 
            _lvwFournisseur_ColumnHeader_6.Text = "Prix listé";
            _lvwFournisseur_ColumnHeader_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwFournisseur_ColumnHeader_6.Width = 108;
            // 
            // _lvwFournisseur_ColumnHeader_7
            // 
            _lvwFournisseur_ColumnHeader_7.Text = "Escompte";
            _lvwFournisseur_ColumnHeader_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwFournisseur_ColumnHeader_7.Width = 105;
            // 
            // _lvwFournisseur_ColumnHeader_8
            // 
            _lvwFournisseur_ColumnHeader_8.Text = "Prix net";
            _lvwFournisseur_ColumnHeader_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwFournisseur_ColumnHeader_8.Width = 108;
            // 
            // _lvwFournisseur_ColumnHeader_9
            // 
            _lvwFournisseur_ColumnHeader_9.Text = "Prix spécial";
            _lvwFournisseur_ColumnHeader_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _lvwFournisseur_ColumnHeader_9.Width = 115;
            // 
            // _lvwFournisseur_ColumnHeader_10
            // 
            _lvwFournisseur_ColumnHeader_10.Text = "Quoter";
            _lvwFournisseur_ColumnHeader_10.Width = 80;
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(600, 397);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(73, 25);
            cmdAnnuler.TabIndex = 7;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // cmdCommander
            // 
            cmdCommander.BackColor = System.Drawing.Color.Black;
            cmdCommander.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdCommander.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdCommander.ForeColor = System.Drawing.Color.White;
            cmdCommander.Location = new System.Drawing.Point(521, 397);
            cmdCommander.Name = "cmdCommander";
            cmdCommander.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCommander.Size = new System.Drawing.Size(73, 25);
            cmdCommander.TabIndex = 8;
            cmdCommander.Text = "Commander";
            cmdCommander.UseVisualStyleBackColor = true;
            cmdCommander.Click += new System.EventHandler(cmdCommander_Click);
            // 
            // lvwPiece
            // 
            lvwPiece.BackColor = System.Drawing.Color.Black;
            lvwPiece.CheckBoxes = true;
            lvwPiece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwPiece_ColumnHeader_1,
            _lvwPiece_ColumnHeader_2,
            _lvwPiece_ColumnHeader_3,
            _lvwPiece_ColumnHeader_4,
            _lvwPiece_ColumnHeader_5,
            _lvwPiece_ColumnHeader_6});
            lvwPiece.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwPiece.ForeColor = System.Drawing.Color.AliceBlue;
            lvwPiece.FullRowSelect = true;
            lvwPiece.GridLines = true;
            lvwPiece.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            lvwPiece.LabelWrap = false;
            lvwPiece.Location = new System.Drawing.Point(8, 54);
            lvwPiece.Name = "lvwPiece";
            lvwPiece.ShowItemToolTips = true;
            lvwPiece.Size = new System.Drawing.Size(673, 337);
            lvwPiece.TabIndex = 4;
            lvwPiece.UseCompatibleStateImageBehavior = false;
            lvwPiece.View = System.Windows.Forms.View.Details;
            lvwPiece.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(lvwPiece_ItemCheck);
            lvwPiece.DoubleClick += new System.EventHandler(lvwPiece_DoubleClick);
            // 
            // _lvwPiece_ColumnHeader_1
            // 
            _lvwPiece_ColumnHeader_1.Text = "Qté";
            _lvwPiece_ColumnHeader_1.Width = 53;
            // 
            // _lvwPiece_ColumnHeader_2
            // 
            _lvwPiece_ColumnHeader_2.Text = "No. Item";
            _lvwPiece_ColumnHeader_2.Width = 216;
            // 
            // _lvwPiece_ColumnHeader_3
            // 
            _lvwPiece_ColumnHeader_3.Text = "Description";
            _lvwPiece_ColumnHeader_3.Width = 448;
            // 
            // _lvwPiece_ColumnHeader_4
            // 
            _lvwPiece_ColumnHeader_4.Text = "Manufacturier";
            _lvwPiece_ColumnHeader_4.Width = 136;
            // 
            // _lvwPiece_ColumnHeader_5
            // 
            _lvwPiece_ColumnHeader_5.Text = "Fournisseur";
            _lvwPiece_ColumnHeader_5.Width = 170;
            // 
            // _lvwPiece_ColumnHeader_6
            // 
            _lvwPiece_ColumnHeader_6.Text = "Stock";
            _lvwPiece_ColumnHeader_6.Width = 170;
            // 
            // ChoixBonCommande
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(692, 434);
            Controls.Add(cmdDeselectAll);
            Controls.Add(cmdSelectAll);
            Controls.Add(fraFournisseur);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdCommander);
            Controls.Add(lvwPiece);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Location = new System.Drawing.Point(3, 22);
            Name = "ChoixBonCommande";
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
            Load += new System.EventHandler(ChoixBonCommande_Load);
            fraFournisseur.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion
        private const int I_COL_QTE = 0;
        private const int I_COL_NO_ITEM = 1;
        private const int I_COL_DESCRIPTION = 2;
        private const int I_COL_MANUFACTURIER = 3;
        private const int I_COL_FOURNISSEUR = 4;
        private const int I_COL_QTE_STOCK = 5;
        private const int I_COL_FRS_FRS = 0;
        private const int I_COL_FRS_PERS_RESS = 1;
        private const int I_COL_FRS_DATE = 2;
        private const int I_COL_FRS_ENTRER_PAR = 3;
        private const int I_COL_FRS_VALIDE = 4;
        private const int I_COL_FRS_PRIX_LIST = 5;
        private const int I_COL_FRS_ESCOMPTE = 6;
        private const int I_COL_FRS_PRIX_NET = 7;
        private const int I_COL_FRS_PRIX_SP = 8;
        private const int I_COL_FRS_QUOTER = 9;
        private enum enumLangage
        {
            FRANCAIS = 0,
            ANGLAIS = 1
        }
        private string m_sNoProjet;
        private Form m_Source;
        private string m_sType="E"; // par defaut electrique
        private string m_sIDAchat;
        private int m_iIndexAchat;
        private List<String> m_collPiece;
        private List<String> m_collNoLigne;
        private enumLangage m_eLangage;
        internal static List<String> m_collNoLigneFRS;
        private List<String> m_collPrixList;
        private List<String> m_collPrixOrigine;
        private List<String> m_collPrixNet;
        private List<String> m_collEscompte;
        private List<String> m_collPrixSP;
        private bool m_bModifFournisseurBC;
        private bool telecomande=false;

        public void AfficherAchat(string sIDAchat, int iIndexAchat, EnumCatalogue eType, Form ACHAT)
        {
            try
            {
                m_sIDAchat = sIDAchat;
                m_iIndexAchat = iIndexAchat;
                m_Source = ACHAT;
                cmdSelectAll.Visible = true;
                if (eType == EnumCatalogue.ELECTRIQUE)
                {
                    m_sType = "E";
                }
                else
                {
                    m_sType = "M";
                }
                lvwPiece.Columns.RemoveAt(I_COL_QTE_STOCK);
                RemplirListViewPieceAchat();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "AfficherAchat", ex);
            }
        }
        public ChoixBonCommande(string sNoProjet, Form Source, int iLangage)
        {
            InitializeComponent();
            telecomande = true;
            try
            {
                m_sNoProjet = sNoProjet;
                m_eLangage = (enumLangage)iLangage;
                m_Source = Source;
                if (Source.Name == "ProjSoumElec")
                {
                    m_sType = "E";
                }
                else
                {
                    m_sType = "M";
                }
                RemplirListViewPieces();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "Afficher", ex);
            }
        }
        public ChoixBonCommande(string idAchat, int Source, Program.EnumCatalogue cat)
        {
            InitializeComponent();
            telecomande = true;
            try
            {
                ShowInTaskbar = false;
                m_sIDAchat = idAchat;
                cmdSelectAll.Visible = true;
                if (cat == EnumCatalogue.ELECTRIQUE)
                {
                    m_sType = "E";
                }
                else
                {
                    m_sType = "M";
                }
                lvwPiece.Columns.RemoveAt(I_COL_QTE_STOCK);
                lvwPiece.Items.Clear();
                lvwPiece.CheckBoxes = true;
                for (int a= 0  ; a<ACHAT.lvwAchat.Items.Count; a++)
                {
                    ListViewItem itmAchat = lvwPiece.Items.Add(string.Empty);
                    itmAchat.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[a].SubItems[0].Text));
                    itmAchat.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[a].SubItems[1].Text));
                    itmAchat.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[a].SubItems[2].Text));
                    itmAchat.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[a].SubItems[3].Text));
                    itmAchat.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, ACHAT.lvwAchat.Items[a].SubItems[7].Text));
                    itmAchat.ForeColor = ACHAT.lvwAchat.Items[a].ForeColor;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "AfficherAchat", ex);
            }
        }

        public ChoixBonCommande(Form source, string sType, string sIDAchat)
        {
            InitializeComponent();
            m_Source = source;
            m_sType = sType;
            m_sIDAchat = sIDAchat;
        }

        private void RemplirListViewPieceAchat()
        {
            try
            {
                ADODB.Recordset rstAchat;
                ADODB.Recordset rstFRS;
                ListViewItem itmAchat;
                Color lColor;
                lvwPiece.Items.Clear();
                rstFRS = new Recordset();
                rstAchat = new Recordset();
                rstAchat.Open("SELECT * FROM Achat_Pieces " +
                    "WHERE IDAchat = '" + m_sIDAchat + "' AND IndexAchat = " + m_iIndexAchat + " " +
                    "ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstAchat.EOF)
                {
                    if ((bool)rstAchat.Fields["Recu"].Value == false) { lColor = COLOR_GRIS; }
                    else if ((bool)rstAchat.Fields["Commandé"].Value == true) { lColor = COLOR_ORANGE; }
                    else { lColor = COLOR_ROSE; }
                    itmAchat = lvwPiece.Items.Add(string.Empty);
                    if (!(rstAchat.Fields["Qté"].Value is DBNull)) { itmAchat.Text = $"{rstAchat.Fields["Qté"].Value}"; }
                    itmAchat.ForeColor = lColor;
                    itmAchat.Tag = rstAchat.Fields["DateRéception"].Value;
                    if (!(rstAchat.Fields["PIECE"].Value is DBNull))
                    {
                        if (itmAchat.SubItems.Count > I_COL_NO_ITEM)
                        {
                            itmAchat.SubItems[I_COL_NO_ITEM].Text = $"{rstAchat.Fields["PIECE"].Value}";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["PIECE"].Value}"));
                        }
                    }
                    else if (itmAchat.SubItems.Count > I_COL_NO_ITEM)
                    {
                        itmAchat.SubItems[I_COL_NO_ITEM].Text = string.Empty;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmAchat.SubItems[I_COL_NO_ITEM].ForeColor = lColor;
                    itmAchat.SubItems[I_COL_NO_ITEM].Tag = rstAchat.Fields["NuméroLigne"].Value;
                    if (!(rstAchat.Fields["DESC_FR"].Value is DBNull))
                    {
                        if (itmAchat.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmAchat.SubItems[I_COL_DESCRIPTION].Text = $"{rstAchat.Fields["DESC_FR"].Value}";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["DESC_FR"].Value}"));
                        }
                    }
                    else if (itmAchat.SubItems.Count > I_COL_DESCRIPTION)
                    {
                        itmAchat.SubItems[I_COL_DESCRIPTION].Text = string.Empty;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmAchat.SubItems[I_COL_DESCRIPTION].ForeColor = lColor;
                    if (!(rstAchat.Fields["Desc_EN"].Value is DBNull))
                    {
                        itmAchat.SubItems[I_COL_DESCRIPTION].Tag = rstAchat.Fields["Desc_EN"].Value;
                    }
                    else
                    {
                        itmAchat.SubItems[I_COL_DESCRIPTION].Tag = string.Empty;
                    }
                    if (!(rstAchat.Fields["Manufact"].Value is DBNull))
                    {
                        if (itmAchat.SubItems.Count > I_COL_MANUFACTURIER)
                        {
                            itmAchat.SubItems[I_COL_MANUFACTURIER].Text = $"{rstAchat.Fields["Manufact"].Value}";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, $"{rstAchat.Fields["Manufact"].Value}"));
                        }
                    }
                    else if (itmAchat.SubItems.Count > I_COL_MANUFACTURIER)
                    {
                        itmAchat.SubItems[I_COL_MANUFACTURIER].Text = string.Empty;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmAchat.SubItems[I_COL_MANUFACTURIER].ForeColor = lColor;
                    itmAchat.SubItems[I_COL_MANUFACTURIER].Tag = rstAchat.Fields["NoRetour"].Value;
                    if (!(rstAchat.Fields["IDFRS"].Value is DBNull))
                    {
                        if ((int)rstAchat.Fields["IDFRS"].Value > 0)
                        {
                            rstFRS.Open("SELECT NomFournisseur FROM Fournisseur " +
                                "WHERE IDFRS = " + rstAchat.Fields["IDFRS"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (itmAchat.SubItems.Count > I_COL_FOURNISSEUR)
                            {
                                itmAchat.SubItems[I_COL_FOURNISSEUR].Text = $"{rstFRS.Fields["NomFournisseur"].Value}";
                            }
                            else
                            {
                                itmAchat.SubItems.Insert(I_COL_FOURNISSEUR, new ListViewItem.ListViewSubItem(null, $"{rstFRS.Fields["NomFournisseur"].Value}"));
                            }
                            itmAchat.SubItems[I_COL_FOURNISSEUR].Tag = rstAchat.Fields["IDFRS"].Value;
                            rstFRS.Close();
                        }
                        else if (itmAchat.SubItems.Count > I_COL_FOURNISSEUR)
                        {
                            itmAchat.SubItems[I_COL_FOURNISSEUR].Text = " ";
                        }
                        else
                        {
                            itmAchat.SubItems.Insert(I_COL_FOURNISSEUR, new ListViewItem.ListViewSubItem(null, " "));
                        }
                    }
                    else if (itmAchat.SubItems.Count > I_COL_FOURNISSEUR)
                    {
                        itmAchat.SubItems[I_COL_FOURNISSEUR].Text = string.Empty;
                    }
                    else
                    {
                        itmAchat.SubItems.Insert(I_COL_FOURNISSEUR, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmAchat.SubItems[I_COL_FOURNISSEUR].ForeColor = lColor;
                    rstAchat.MoveNext();
                }
                rstAchat.Close();
                rstAchat = null;
                rstFRS = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "RemplirListViewAchat", ex);
            }
        }
        /// <summary>
        /// Remaniement pour l'affichage dans le listview en fonction du no projet
        /// PWE v2.23.324
        /// </summary>
        private void RemplirListViewPieces()
        {
            try
            {
                ADODB.Recordset rstPieces;
                ADODB.Recordset rstSection;
                ADODB.Recordset rstInventaire;
                ADODB.Recordset rstFRS;
                ListViewItem itmPieces;
                int X;
                bool bPremierEnr;
                var iOrdreSection = default(int);
                var sSousSection = default(string);
                string sSection;
                Color lCouleur;
                bPremierEnr = true;
                if (m_eLangage == enumLangage.ANGLAIS)
                {
                    sSection = "NomSectionEN";
                }
                else
                {
                    sSection = "NomSectionFR";
                }
                lvwPiece.Sorting = SortOrder.None;
                rstFRS = new Recordset();
                rstPieces = new Recordset();
                rstSection = new Recordset();
                rstInventaire = new Recordset();
                rstPieces.Open("SELECT * FROM Projet_Pieces " +
                    "WHERE IDProjet = '" + m_sNoProjet + "' AND Type = '" + m_sType + "' AND PieceExtraChargeable=0 AND PieceExtraNonChargeable=0 " +
                    "ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPieces.EOF)
                {
                    itmPieces = lvwPiece.Items.Add(string.Empty);
                    if (bPremierEnr == true)
                    {
                        sSousSection = $"{rstPieces.Fields["SousSection"].Value}";
                        iOrdreSection = int.Parse($"{rstPieces.Fields["OrdreSection"].Value}");
                        if (m_sType == "E")
                        {
                            rstSection.Open($"SELECT {sSection}  FROM SoumProjSectionElec " +
                                $"WHERE IDSection = {rstPieces.Fields["IDSection"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstSection.Open($"SELECT { sSection } FROM SoumProjSectionMec " +
                                $"WHERE IDSection = {rstPieces.Fields["IDSection"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        if (!(rstSection.Fields[sSection].Value is DBNull))
                        {
                            if (itmPieces.SubItems.Count > I_COL_NO_ITEM)
                            {
                                itmPieces.SubItems[I_COL_NO_ITEM].Text = $"{rstSection.Fields[sSection].Value}";
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, $"{rstSection.Fields[sSection].Value}"));
                            }
                        }
                        else if (itmPieces.SubItems.Count > I_COL_NO_ITEM)
                        {
                            itmPieces.SubItems[I_COL_NO_ITEM].Text = string.Empty;
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        rstSection.Close();
                        itmPieces = lvwPiece.Items.Add(string.Empty);
                        if (sSousSection == "PAS DE SOUS-SECTION")
                        {
                            if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                            {
                                itmPieces.SubItems[I_COL_DESCRIPTION].Text = string.Empty;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }
                        else if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmPieces.SubItems[I_COL_DESCRIPTION].Text = sSousSection;
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, sSousSection));
                        }
                        itmPieces.Tag = "PAS UNE SECTION";
                        itmPieces = lvwPiece.Items.Add(string.Empty);
                        bPremierEnr = false;
                    }
                    else if (iOrdreSection!=int.Parse($"{rstPieces.Fields["OrdreSection"].Value}"))
                    {
                        iOrdreSection = int.Parse($"{rstPieces.Fields["OrdreSection"].Value}");
                        if (m_sType == "E")
                        {
                            rstSection.Open($"SELECT { sSection } FROM SoumProjSectionElec " +
                                $"WHERE IDSection = {rstPieces.Fields["IDSection"].Value}" , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstSection.Open($"SELECT {sSection}  FROM SoumProjSectionMec " +
                                $"WHERE IDSection = {rstPieces.Fields["IDSection"].Value}" , odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        if (!(rstSection.Fields[sSection].Value is DBNull))
                        {
                            if (itmPieces.SubItems.Count > I_COL_NO_ITEM)
                            {
                                itmPieces.SubItems[I_COL_NO_ITEM].Text = $"{rstSection.Fields[sSection].Value}";
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, $"{rstSection.Fields[sSection].Value}"));
                            }
                        }
                        else if (itmPieces.SubItems.Count > I_COL_NO_ITEM)
                        {
                            itmPieces.SubItems[I_COL_NO_ITEM].Text = string.Empty;
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        rstSection.Close();
                        itmPieces = lvwPiece.Items.Add(string.Empty);
                        sSousSection = $"{rstPieces.Fields["SousSection"].Value}";
                        if (sSousSection == "PAS DE SOUS-SECTION")
                        {
                            if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                            {
                                itmPieces.SubItems[I_COL_DESCRIPTION].Text = string.Empty;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }
                        else if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmPieces.SubItems[I_COL_DESCRIPTION].Text = $"{rstPieces.Fields["SousSection"].Value}";
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, $"{rstPieces.Fields["SousSection"].Value}"));
                        }
                        itmPieces.Tag = "PAS UNE SECTION";
                        itmPieces = lvwPiece.Items.Add(string.Empty);
                    }
                    else if (sSousSection != rstPieces.Fields["SousSection"].Value)
                    {
                        sSousSection = $"{rstPieces.Fields["SousSection"].Value}";
                        if (sSousSection == "PAS DE SOUS-SECTION")
                        {
                            if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                            {
                                itmPieces.SubItems[I_COL_DESCRIPTION].Text = string.Empty;
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                        }
                        else if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmPieces.SubItems[I_COL_DESCRIPTION].Text = sSousSection;
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, sSousSection));
                        }
                        itmPieces.Tag = "PAS UNE SECTION";
                        itmPieces = lvwPiece.Items.Add(string.Empty);
                    }
                    if (!(bool)(rstPieces.Fields["Commandé"].Value))
                    {
                        lCouleur = COLOR_ORANGE;
                    }
                    else if ((bool)rstPieces.Fields["Recu"].Value==true)
                    {
                        lCouleur = COLOR_GRIS;
                    }
                    else
                    {
                        lCouleur = COLOR_ROSE;
                    }
                    if (!(rstPieces.Fields["Qté"].Value is DBNull))
                    {
                        itmPieces.Text = $"{rstPieces.Fields["Qté"].Value}";
                    }
                    else
                    {
                        itmPieces.Text = string.Empty;
                    }
                    itmPieces.ForeColor = lCouleur;
                    itmPieces.Tag = "PAS UNE SECTION";
                    if (!(rstPieces.Fields["NumItem"].Value is DBNull))
                    {
                        if (itmPieces.SubItems.Count > I_COL_NO_ITEM)
                        {
                            itmPieces.SubItems[I_COL_NO_ITEM].Text = $"{rstPieces.Fields["NumItem"].Value}";
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, $"{rstPieces.Fields["NumItem"].Value}"));
                        }
                    }
                    else if (itmPieces.SubItems.Count > I_COL_NO_ITEM)
                    {
                        itmPieces.SubItems[I_COL_NO_ITEM].Text = string.Empty;
                    }
                    else
                    {
                        itmPieces.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmPieces.SubItems[I_COL_NO_ITEM].ForeColor = lCouleur;
                    itmPieces.SubItems[I_COL_NO_ITEM].Tag = rstPieces.Fields["NuméroLigne"].Value;
                    if (m_eLangage == enumLangage.FRANCAIS)
                    {
                        if (!(rstPieces.Fields["Desc_FR"].Value is DBNull))
                        {
                            if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                            {
                                itmPieces.SubItems[I_COL_DESCRIPTION].Text = $"{rstPieces.Fields["Desc_FR"].Value}";
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, $"{rstPieces.Fields["Desc_FR"].Value}"));
                            }
                        }
                        else if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmPieces.SubItems[I_COL_DESCRIPTION].Text = string.Empty;
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                    }
                    else if (!(rstPieces.Fields["Desc_EN"].Value is DBNull))
                    {
                        if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmPieces.SubItems[I_COL_DESCRIPTION].Text = $"{rstPieces.Fields["Desc_EN"].Value}";
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, $"{rstPieces.Fields["Desc_EN"].Value}"));
                        }
                    }
                    else if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                    {
                        itmPieces.SubItems[I_COL_DESCRIPTION].Text = string.Empty;
                    }
                    else
                    {
                        itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmPieces.SubItems[I_COL_DESCRIPTION].ForeColor = lCouleur;
                    if (!(rstPieces.Fields["Manufact"].Value is DBNull))
                    {
                        if (itmPieces.SubItems.Count > I_COL_MANUFACTURIER)
                        {
                            itmPieces.SubItems[I_COL_MANUFACTURIER].Text = $"{rstPieces.Fields["Manufact"].Value}";
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, $"{rstPieces.Fields["Manufact"].Value}"));
                        }
                    }
                    else if (itmPieces.SubItems.Count > I_COL_MANUFACTURIER)
                    {
                        itmPieces.SubItems[I_COL_MANUFACTURIER].Text = string.Empty;
                    }
                    else
                    {
                        itmPieces.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmPieces.SubItems[I_COL_MANUFACTURIER].ForeColor = lCouleur;
                    if (Conversions.ToBoolean(Operators.AndObject(!(rstPieces.Fields["IDFRS"].Value is DBNull), Operators.ConditionalCompareObjectGreater(rstPieces.Fields["IDFRS"].Value, 0, false))))
                    {
                        if (itmPieces.SubItems[I_COL_NO_ITEM].Text != "Texte")
                        {
                            rstFRS.Open("SELECT NomFournisseur FROM Fournisseur " +
                                "WHERE IDFRS = " + rstPieces.Fields["IDFRS"].Value, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (itmPieces.SubItems.Count > I_COL_FOURNISSEUR)
                            {
                                itmPieces.SubItems[I_COL_FOURNISSEUR].Text = $"{rstFRS.Fields["NomFournisseur"].Value}";
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_FOURNISSEUR, new ListViewItem.ListViewSubItem(null, $"{rstFRS.Fields["NomFournisseur"].Value}"));
                            }
                            rstFRS.Close();
                        }
                    }
                    else if (itmPieces.SubItems.Count > I_COL_FOURNISSEUR)
                    {
                        itmPieces.SubItems[I_COL_FOURNISSEUR].Text = string.Empty;
                    }
                    else
                    {
                        itmPieces.SubItems.Insert(I_COL_FOURNISSEUR, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itmPieces.SubItems[I_COL_FOURNISSEUR].ForeColor = lCouleur;
                    if (m_sType == "E")
                    {
                        rstInventaire.Open($"SELECT * FROM InventaireElec " +
                            $"WHERE NoItem = '{$"{rstPieces.Fields["NumItem"].Value}".Replace( "'", "''")}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    else
                    {
                        rstInventaire.Open($"SELECT * FROM InventaireMec " +
                            $"WHERE NoItem = '{$"{rstPieces.Fields["NumItem"].Value}".Replace( "'", "''")}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    }
                    if (!rstInventaire.EOF)
                    {
                        if (itmPieces.SubItems.Count > I_COL_QTE_STOCK)
                        {
                            itmPieces.SubItems[I_COL_QTE_STOCK].Text = $"{rstInventaire.Fields["QuantitéStock"].Value}";
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_QTE_STOCK, new ListViewItem.ListViewSubItem(null, $"{rstInventaire.Fields["QuantitéStock"].Value}"));
                        }
                    }
                    rstInventaire.Close();
                    rstPieces.MoveNext();
                }
                rstPieces.Close();
                rstPieces = null;
                rstFRS = null;
                rstInventaire = null;
                rstSection = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "RemplirListViewPieces", ex);
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
                AfficherErreur("ChoixBonCommande", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdCommander_Click(object eventSender, EventArgs eventArgs)
        {
            if (telecomande == true)
            {
                int itemsChoisis = 0;
                if (lvwPiece.Items.Count > 0)
                {
                    for(int a= 0  ; a<lvwPiece.Items.Count; a++)
                    {
                        if (lvwPiece.Items[a].Checked == true)
                        {
                            itemsChoisis++;
                        }
                    }
                    if (itemsChoisis >=1) {
                        ADODB.Recordset rd = new ADODB.Recordset();
                        rd.Open($"SELECT DISTINCT  [DBO].[FOURNISSEUR].NOMFOURNISSEUR ,[DBO].[ACHAT_PIECES].IDFRS FROM [DBO].[ACHAT_PIECES] " +
                            $"JOIN [DBO].[FOURNISSEUR] ON [DBO].[ACHAT_PIECES].IDFRS=[DBO].[FOURNISSEUR].IDFRS " +
                            $"WHERE IDACHAT=LEFT('{m_sIDAchat}',9)", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                        m_collNoLigneFRS.Clear();
                        while (!rd.EOF) 
                        {
                            m_collNoLigneFRS.Add($"{rd.Fields[0].Value} - {rd.Fields[1].Value}");
                            rd.MoveNext();
                        }
                        rd.Close();
                        BonCommande bc = new BonCommande(telecomande);
                        bc.ShowInTaskbar = false;
                       
                        bc.MdiParent = Conteneur.Mdi;
                        bc.Show();
                    }
                } 

                
            }
            else
            {
                try
                {
                    bool bChecked;
                    int X;
                    string sNoBC;
                    ADODB.Recordset rstProjet;
                    bChecked = false;
                    for (X = 0; X < lvwPiece.Items.Count; X++)
                    {
                        if (lvwPiece.Items[X].Checked == true)
                        {
                            bChecked = true;
                            break;
                        }
                    }
                    if (bChecked == true)
                    {
                        m_collPiece = new List<string>();
                        m_collNoLigne = new List<string>();

                        if (telecomande==false)
                        {
                            ModifierFournisseurBD();
                        }
                        for (X = 0; X < lvwPiece.Items.Count; X++)
                        {
                            if (lvwPiece.Items[X].Checked == true)
                            {
                                m_collPiece.Add(lvwPiece.Items[X].SubItems[I_COL_NO_ITEM].Text);
                                m_collNoLigne.Add(lvwPiece.Items[X].SubItems[I_COL_NO_ITEM].Tag.ToString());
                            }
                        }
                        if (m_Source.Name != Name)
                        {
                            rstProjet = new Recordset();
                            if (m_sType == "E")
                            {
                                rstProjet.Open("SELECT ProchaineCommande FROM ProjetElec " +
                                    "WHERE IDProjet = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            }
                            else
                            {
                                rstProjet.Open("SELECT ProchaineCommande FROM ProjetMec " +
                                    "WHERE IDProjet = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            }
                            if (!(rstProjet.Fields["ProchaineCommande"].Value is DBNull))
                            {
                                sNoBC = m_sNoProjet + "-" + Droite($"00{rstProjet.Fields["ProchaineCommande"].Value}", 3);
                            }
                            else
                            {
                                sNoBC = m_sNoProjet;
                            }
                            rstProjet.Close();
                            rstProjet = null;
                        }
                        else
                        {
                            sNoBC = m_sIDAchat + "-" + Droite("00" + m_iIndexAchat, 3);
                        }
                        if (!string.IsNullOrEmpty(sNoBC))
                        {
                            BonCommande f;
                            if (m_Source.Name == "ProjSoumElec")
                            {
                                f = new BonCommande(m_sNoProjet, sNoBC, m_collPiece, m_collNoLigne, BonCommande.EnumFormSource.I_PROJET_ELEC, (int)m_eLangage);
                            }
                            else if (m_Source.Name == "ProjSoumMec")
                            {
                                f = new BonCommande(m_sNoProjet, sNoBC, m_collPiece, m_collNoLigne, BonCommande.EnumFormSource.I_PROJET_MEC, (int)m_eLangage);
                            }
                            else if (m_sType == "E")
                            {
                                f = new BonCommande(m_sIDAchat + "-" + Droite("00" + m_iIndexAchat, 3), sNoBC, m_collPiece, m_collNoLigne, BonCommande.EnumFormSource.I_ACHAT_ELEC, 0);
                            }
                            else
                            {
                                f = new BonCommande(m_sIDAchat + "-" + Droite("00" + m_iIndexAchat, 3), sNoBC, m_collPiece, m_collNoLigne, BonCommande.EnumFormSource.I_ACHAT_MEC, 0);
                            }
                            f.MdiParent = Conteneur.ActiveForm.MdiParent;
                            f.Show();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune pièce n'est sélectionnée!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                catch (Exception ex)
                {
                    AfficherErreur("ChoixBonCommande", "cmdCommander_Click", ex);
                }

            }
        }
 // filtre les elements ne contenant pas les inos minimales (s'il y en a)
        private void cmdSelectAll_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                for (int X = 0; X < lvwPiece.Items.Count; X++)
                {
                    if (lvwPiece.Items[X].SubItems[I_COL_NO_ITEM].Text != "" & lvwPiece.Items[X].SubItems[2].Text != "")
                    {
                        lvwPiece.Items[X].Checked = true;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "cmdSelectAll_Click", ex);
            }
        }
        private void cmdDeSelectAll_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                for (int X = 0; X <lvwPiece.Items.Count; X++)
                    lvwPiece.Items[X].Checked = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "cmdDeselectAll_Click", ex);
            }
        }
        private void ChoixBonCommande_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                m_collNoLigneFRS = new List<String>();
                m_collEscompte = new List<String>();
                m_collPrixList = new List<String>();
                m_collPrixNet = new List<String>();
                m_collPrixOrigine = new List<String>();
                m_collPrixSP = new List<String>();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "Form_Load", ex);
            }
        }
        private void lvwPiece_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!telecomande)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwPiece.FocusedItem.Tag, "", false)))
                    {
                        if (!string.IsNullOrEmpty(lvwPiece.FocusedItem.SubItems[I_COL_NO_ITEM].Text))
                        {
                            ChangerFournisseur();
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "lvwPiece_DblClick", ex);
            }
        }
       private void lvwPiece_ItemCheck(object eventSender, ItemCheckEventArgs eventArgs)
        {
            var Item = lvwPiece.Items[eventArgs.Index];
            try
            {
                if ((!string.IsNullOrEmpty(Item.SubItems[1].Text)) & (!string.IsNullOrEmpty(Item.SubItems[2].Text)) & (!string.IsNullOrEmpty(Item.SubItems[3].Text)))
                {
                    Item.Checked = false;
                }
                else if (double.Parse(Item.Text.Replace("*", "")) <= 0d)
                {
                    Item.Checked = false;
                }
                else
                {
                    Item.Checked = true;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "lvwPiece_ItemCheck", ex);
            }
        }
        private void ChangerFournisseur()
        {
            try
            {
                AfficherListeFournisseurs();
                if (lvwFournisseur.Items.Count == 0)
                {
                    MessageBox.Show("Il n'y a aucun fournisseur pour cette pièce!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    fraFournisseur.Visible = true;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "ChangerFournisseur", ex);
            }
        }
        private void AfficherListeFournisseurs()
        {
            try
            {
                RemplirListViewFournisseur();
                if (lvwFournisseur.Items.Count > 1)
                {
                    fraFournisseur.Visible = true;
                    lvwFournisseur.Focus();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "AfficherListeFournisseurs", ex);
            }
        }
        private void lvwFournisseur_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ChoisirFournisseur();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "lvwFournisseur_DblClick", ex);
            }
        }
        private void ChoisirFournisseur()
        {
            try
            {
                ListViewItem itmBC;
                ListViewItem itmFRS;
                itmBC = lvwPiece.FocusedItem;
                itmFRS = lvwFournisseur.FocusedItem;
                if (itmBC.SubItems.Count > I_COL_FOURNISSEUR)
                {
                    itmBC.SubItems[I_COL_FOURNISSEUR].Text = itmFRS.Text;
                }
                else
                {
                    itmBC.SubItems.Insert(I_COL_FOURNISSEUR, new ListViewItem.ListViewSubItem(null, itmFRS.Text));
                }
                itmBC.SubItems[I_COL_FOURNISSEUR].Tag = itmFRS.Tag;
                m_collNoLigneFRS.Add(itmBC.SubItems[I_COL_NO_ITEM].Tag.ToString());
                m_collEscompte.Add(itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text);
                m_collPrixList.Add(itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text);
                m_collPrixNet.Add(itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text);
                m_collPrixOrigine.Add(itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Tag.ToString());
                m_collPrixSP.Add(itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text);
                fraFournisseur.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "ChoisirFournisseur", ex);
            }
        }
        private void cmdOKFRS_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ChoisirFournisseur();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "cmdOKFRS_Click", ex);
            }
        }
        private void cmdAnnulerFRS_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraFournisseur.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "cmdAnnulerFRS_Click", ex);
            }
        }
        private void RemplirListViewFournisseur()
        {
            try
            {
                ADODB.Recordset rstPieceFRS;
                ADODB.Recordset rstContact;
                ADODB.Recordset rstFRS;
                int X;
                ListViewItem itmFRS;
                int iNoClient;
                string sDevise;
                lvwFournisseur.Items.Clear();
                rstPieceFRS = new Recordset();
                rstContact = new Recordset();
                rstFRS = new Recordset();
                rstFRS.Open("SELECT IDFRS FROM Fournisseur " +
                    "WHERE NomFournisseur = 'FOURNI PAR LE CLIENT'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                iNoClient = int.Parse($"{rstFRS.Fields["IDFRS"].Value}");
                rstFRS.Close();
                rstFRS = null;
                rstPieceFRS.Open("SELECT PiecesFRS.*, FOURNISSEUR.NomFournisseur FROM PiecesFRS " +
                    "INNER JOIN Fournisseur ON PiecesFRS.IDFRS = Fournisseur.IDFRS " +
                    "WHERE PIECE = '" + lvwPiece.FocusedItem.SubItems[(int)I_COL_NO_ITEM].Text.Replace( "'", "''") + "' AND Type = '" + m_sType + "' " +
                    "ORDER BY PrixReel", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPieceFRS.EOF)
                {
                    if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "CAN")
                    {
                        sDevise = "CAN";
                    }
                    else if (rstPieceFRS.Fields["DeviseMonétaire"].Value == "USA")
                    {
                        sDevise = "USA";
                    }
                    else
                    {
                        sDevise = "SPA";
                    }
                    itmFRS = lvwFournisseur.Items.Add(string.Empty);
                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " "));
                    }
                    if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE)
                    {
                        itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem(null, " "));
                    }

                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET)
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem(null, " "));
                    }

                    if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP)
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = " ";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem(null, " "));
                    }

                    itmFRS.Text = $"{rstPieceFRS.Fields["NomFournisseur"].Value}";
                    BonCommande.cmbFournisseur.Items.Add($"{rstPieceFRS.Fields["NomFournisseur"].Value} - {rstPieceFRS.Fields["IDFRS"].Value}");
                    itmFRS.Tag = rstPieceFRS.Fields["IDFRS"].Value;
                    if (!string.IsNullOrEmpty($"{rstPieceFRS.Fields["PERS_RESS"].Value}".Trim()))
                    {
                        rstContact.Open($"SELECT NomContact FROM Contact " +
                            $"WHERE IDContact ={rstPieceFRS.Fields["PERS_RESS"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstContact.EOF)
                        {

                            if (itmFRS.SubItems.Count > I_COL_FRS_PERS_RESS)
                            {
                                itmFRS.SubItems[I_COL_FRS_PERS_RESS].Text = $"{rstContact.Fields["NomContact"].Value}";
                            }
                            else
                            {
                                itmFRS.SubItems.Insert(I_COL_FRS_PERS_RESS, new ListViewItem.ListViewSubItem(null, $"{rstContact.Fields["NomContact"].Value}"));
                            }
                            BonCommande.cmbContact.Items.Add($"{rstContact.Fields["NomContact"].Value}");
                        }
                        rstContact.Close();
                    }
                    if (!(rstPieceFRS.Fields["Date"].Value is DBNull))
                    {

                        if (itmFRS.SubItems.Count > I_COL_FRS_DATE)
                        {
                            itmFRS.SubItems[I_COL_FRS_DATE].Text = $"{rstPieceFRS.Fields["Date"].Value}";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_DATE, new ListViewItem.ListViewSubItem(null, $"{rstPieceFRS.Fields["Date"].Value}"));
                        }
                    }

                    else if (itmFRS.SubItems.Count > I_COL_FRS_DATE)
                    {
                        itmFRS.SubItems[I_COL_FRS_DATE].Text = string.Empty;
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_DATE, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    if (!(rstPieceFRS.Fields["Entrer_Par"].Value is DBNull))
                    {

                        if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR)
                        {
                            itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = $"{rstPieceFRS.Fields["Entrer_Par"].Value}";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, $"{rstPieceFRS.Fields["Entrer_Par"].Value}"));
                        }
                    }

                    else if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR)
                    {
                        itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = string.Empty;
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    if (!(rstPieceFRS.Fields["Valide"].Value is DBNull))
                    {

                        if (itmFRS.SubItems.Count > I_COL_FRS_VALIDE)
                        {
                            itmFRS.SubItems[I_COL_FRS_VALIDE].Text = $"{rstPieceFRS.Fields["Valide"].Value}";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_VALIDE, new ListViewItem.ListViewSubItem(null, $"{rstPieceFRS.Fields["Valide"].Value}"));
                        }
                    }

                    else if (itmFRS.SubItems.Count > I_COL_FRS_VALIDE)
                    {
                        itmFRS.SubItems[I_COL_FRS_VALIDE].Text = string.Empty;
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_VALIDE, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    if (rstPieceFRS.Fields["PRIX_LIST"].Value != string.Empty)
                    {
                        if (sDevise == "USA")
                        {

                            if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                            {
                                itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_LIST"].Value), 4).ToString();
                            }
                            else
                            {
                                itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_LIST"].Value), 4).ToString()));
                            }
                        }
                        else if (sDevise == "SPA")
                        {

                            if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                            {
                                itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_LIST"].Value), 4).ToString();
                            }
                            else
                            {
                                itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_LIST"].Value), 4).ToString()));
                            }
                        }

                        else if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_LIST"].Value), 4).ToString();
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem((ListViewItem)null, Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_LIST"].Value), 4).ToString()));
                        }
                    }
                    if (rstPieceFRS.Fields["ESCOMPTE"].Value != string.Empty)
                    {

                        if (itmFRS.SubItems.Count > I_COL_FRS_ESCOMPTE)
                        {
                            itmFRS.SubItems[I_COL_FRS_ESCOMPTE].Text = (double.Parse(rstPieceFRS.Fields["ESCOMPTE"].Value) * 100d).ToString();
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_ESCOMPTE, new ListViewItem.ListViewSubItem((ListViewItem)null, (double.Parse(rstPieceFRS.Fields["ESCOMPTE"].Value) * 100d).ToString()));
                        }
                    }

                    if (rstPieceFRS.Fields["PRIX_NET"].Value != string.Empty)
                    {
                        if (sDevise == "USA")
                        {

                            if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET)
                            {
                                itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_NET"].Value), 4).ToString();
                            }
                            else
                            {
                                itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_NET"].Value), 4).ToString()));
                            }
                        }
                        else if (sDevise == "SPA")
                        {

                            if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET)
                            {
                                itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_NET"].Value), 4).ToString();
                            }
                            else
                            {
                                itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_NET"].Value), 4).ToString()));
                            }
                        }

                        else if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_NET)
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_NET].Text = Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_NET"].Value), 4).ToString();
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_PRIX_NET, new ListViewItem.ListViewSubItem((ListViewItem)null, Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_NET"].Value), 4).ToString()));
                        }
                    }
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstPieceFRS.Fields["PRIX_SP"].Value, string.Empty, false)))
                    {
                        if (sDevise == "USA")
                        {

                            if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP)
                            {
                                itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_SP"].Value), 4).ToString();
                            }
                            else
                            {
                                itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem((ListViewItem)null, Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_SP"].Value), 4).ToString()));
                            }
                        }
                        else if (sDevise == "SPA")
                        {

                            if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP)
                            {
                                itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text = Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_SP"].Value), 4).ToString();
                            }
                            else
                            {
                                itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem((ListViewItem)null, Math.Round(double.Parse(rstPieceFRS.Fields["PRIX_SP"].Value), 4).ToString()));
                            }
                        }

                        else if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_SP)
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_SP].Text =Math.Round(double.Parse($"{rstPieceFRS.Fields["PRIX_SP"].Value}"), 4).ToString();
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_PRIX_SP, new ListViewItem.ListViewSubItem((ListViewItem)null,Math.Round( double.Parse($"{rstPieceFRS.Fields["PRIX_SP"].Value}"), 4).ToString()));
                        }
                    }
                    if ((bool)rstPieceFRS.Fields["QUOTER"].Value)
                    {

                        if (itmFRS.SubItems.Count > I_COL_FRS_QUOTER)
                        {
                            itmFRS.SubItems[I_COL_FRS_QUOTER].Text = "Oui";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_QUOTER, new ListViewItem.ListViewSubItem(null, "Oui"));
                        }
                    }

                    else if (itmFRS.SubItems.Count > I_COL_FRS_QUOTER)
                    {
                        itmFRS.SubItems[I_COL_FRS_QUOTER].Text = "Non";
                    }
                    else
                    {
                        itmFRS.SubItems.Insert(I_COL_FRS_QUOTER, new ListViewItem.ListViewSubItem(null, "Non"));
                    }
                    if (string.IsNullOrEmpty(itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text))
                    {

                        if (itmFRS.SubItems.Count > I_COL_FRS_PRIX_LIST)
                        {
                            itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Text = " ";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_PRIX_LIST, new ListViewItem.ListViewSubItem(null, " "));
                        }
                    }
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(rstPieceFRS.Fields["PRIX_NET"].Value, string.Empty, false)))
                    {
                        itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Tag = $"{rstPieceFRS.Fields["PRIX_NET"].Value}".Replace(".", ",");
                    }
                    else
                    {

                        itmFRS.SubItems[I_COL_FRS_PRIX_LIST].Tag =$"{rstPieceFRS.Fields["PRIX_SP"].Value}".Replace( ".", ",");
                    }

                    if (string.IsNullOrEmpty(itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text))
                    {

                        if (itmFRS.SubItems.Count > I_COL_FRS_ENTRER_PAR)
                        {
                            itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Text = " ";
                        }
                        else
                        {
                            itmFRS.SubItems.Insert(I_COL_FRS_ENTRER_PAR, new ListViewItem.ListViewSubItem(null, " "));
                        }
                    }

                    itmFRS.SubItems[I_COL_FRS_ENTRER_PAR].Tag = rstPieceFRS.Fields["NoEnreg"].Value;
                    rstPieceFRS.MoveNext();
                }
                rstPieceFRS.Close();
                rstPieceFRS = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "RemplirListViewFournisseur", ex);
            }
        }
        private void CalculerTotalRecordsetElec(string sNoProjSoum)
        {
            try
            {
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstPunch;
                double dblTotalDessin;
                double dblTotalFabrication;
                double dblTotalAssemblage;
                double dblTotalProgInterface;
                double dblTotalProgAutomate;
                double dblTotalProgRobot;
                double dblTotalVision;
                double dblTotalTest;
                double dblTotalInstallation;
                double dblTotalMiseService;
                double dblTotalFormation;
                double dblTotalGestion;
                double dblTotalShipping;
                double dblHebergement;
                double dblRepas;
                double dblTransport;
                double dblUniteMobile;
                double dblPrixEmballage;
                double dblTotalResteTemps;
                var dblPrixPieces = default(double);
                double dblPrixTotal;
                double dblCommission;
                double dblTotalTemps;
                var dblProfit = default(double);
                double dblTotalManuel;
                double dblTotalPieceImprevue;
                double dblGrandTotal;
                string sDateDebut;
                string sDateFin;
                string sTotal;
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetElec " +
                    "WHERE IDProjet = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjet.EOF)
                {
                    rstPunch = new Recordset();
                    rstPunch.Open($"SELECT TYPE,SUM(DATEDIFF(HOUR,[HEUREDÉBUT],[HEUREFIN] )) AS TOTAL FROM PUNCH WHERE NOPROJET LIKE '{sNoProjSoum }%' AND HEUREFIN IS NOT NULL AND HEUREDÉBUT IS NOT NULL ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    dblTotalDessin = 0d;
                    dblTotalFabrication = 0d;
                    dblTotalAssemblage = 0d;
                    dblTotalProgInterface = 0d;
                    dblTotalProgAutomate = 0d;
                    dblTotalProgRobot = 0d;
                    dblTotalVision = 0d;
                    dblTotalTest = 0d;
                    dblTotalInstallation = 0d;
                    dblTotalMiseService = 0d;
                    dblTotalFormation = 0d;
                    dblTotalGestion = 0d;
                    dblTotalShipping = 0d;
                    while (!rstPunch.EOF)
                    {
                        if (!(rstPunch.Fields["Total"].Value is DBNull))
                        {
                            switch (rstPunch.Fields["Type"].Value)
                            {
                                case "Dessin": { dblTotalDessin = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxDessin"].Value}"); break; }
                                case "Fabrication": { dblTotalFabrication = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxFabrication"].Value}"); break; }
                                case "Assemblage": { dblTotalAssemblage = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxAssemblage"].Value}"); break; }
                                case "ProgInterface": { dblTotalProgInterface = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxProgInterface"].Value}"); break; }
                                case "ProgAutomate": { dblTotalProgAutomate = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxProgAutomate"].Value}"); break; }
                                case "ProgRobot": { dblTotalProgRobot = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxProgRobot"].Value}"); break; }
                                case "Vision": { dblTotalVision = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxVision"].Value}"); break; }
                                case "Test": { dblTotalTest = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxTest"].Value}"); break; }
                                case "Installation": { dblTotalInstallation = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxInstallation"].Value}"); break; }
                                case "MiseService": { dblTotalMiseService = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxMiseService"].Value}"); break; }
                                case "Formation": { dblTotalFormation = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxFormation"].Value}"); break; }
                                case "Gestion": { dblTotalGestion = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxGestion"].Value}"); break; }
                                case "Shipping": { dblTotalShipping = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxShipping"].Value}"); break; }
                            }
                        }
                        rstPunch.MoveNext();
                    }
                    rstPunch.Close();
                    rstPunch = null;
                    dblTotalTemps = dblTotalDessin + dblTotalFabrication + dblTotalAssemblage + dblTotalProgInterface + dblTotalProgAutomate + dblTotalProgRobot + dblTotalVision + dblTotalTest + dblTotalInstallation + dblTotalMiseService + dblTotalFormation + dblTotalGestion + dblTotalShipping;
                    rstPiece = new Recordset();
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjSoum + "' AND Type = 'E'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstPiece.EOF)
                    {
                        if (!string.IsNullOrEmpty($"{rstPiece.Fields["Prix_total"].Value}".Trim()))
                        {
                            dblPrixPieces = dblPrixPieces + double.Parse($"{rstPiece.Fields["Prix_total"].Value}") - double.Parse($"{rstPiece.Fields["Profit_Argent"].Value}");
                            dblProfit = dblProfit + double.Parse($"{rstPiece.Fields["Profit_Argent"].Value}");
                        }
                        rstPiece.MoveNext();
                    }
                    rstPiece.Close();
                    rstPiece = null;
                    dblHebergement = 0d;
                    dblRepas = 0d;
                    dblTransport = 0d;
                    dblUniteMobile = 0d;
                    if (IsNumeric(rstProjet.Fields["PrixEmballage"].Value))
                    {
                        dblPrixEmballage = double.Parse($"{rstProjet.Fields["PrixEmballage"].Value}");
                    }
                    else
                    {
                        dblPrixEmballage = 0d;
                    }
                    dblTotalResteTemps = dblHebergement + dblRepas + dblTransport + dblUniteMobile + dblPrixEmballage;
                    if (IsNumeric(rstProjet.Fields["total_manuel"].Value))
                    {
                        dblTotalManuel = double.Parse($"{rstProjet.Fields["total_manuel"].Value}");
                    }
                    else
                    {
                        dblTotalManuel = 0d;
                    }
                    dblTotalPieceImprevue = (dblPrixPieces + dblProfit) * (1d + double.Parse(rstProjet.Fields["Imprevue"].Value));
                    dblPrixTotal = dblTotalTemps + dblTotalManuel + dblTotalPieceImprevue + dblTotalResteTemps;
                    dblCommission = dblPrixTotal * double.Parse($"{rstProjet.Fields["Commission"].Value}");
                    dblGrandTotal = dblPrixTotal + dblCommission;
                    rstProjet.Fields["total_commission"].Value = dblCommission;
                    rstProjet.Fields["Total_manuel"].Value = dblTotalManuel;
                    rstProjet.Fields["Total_temps"].Value = dblTotalTemps;
                    rstProjet.Fields["total_imprevue"].Value = dblTotalPieceImprevue - (dblPrixPieces + dblProfit);
                    rstProjet.Fields["total_piece"].Value = dblPrixPieces;
                    rstProjet.Fields["Total_Commission"].Value = Math.Round(dblCommission, 2).ToString();
                    rstProjet.Fields["PrixTotal"].Value = Math.Round(dblGrandTotal, 2).ToString();
                    rstProjet.Fields["Total_Profit"].Value = Math.Round(dblProfit, 2).ToString();
                    rstProjet.Update();
                }
                else
                {
                    MessageBox.Show("Le projet " + sNoProjSoum + " est inexistant!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rstProjet.Close();
                rstProjet = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "CalculerTotalRecordset", ex);
            }
        }
        private void CalculerTotalRecordsetMec(string sNoProjSoum)
        {
            try
            {
                ADODB.Recordset rstProjet;
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstPunch;
                var dblPrixPieces = default(double);
                double dblPrixTotal;
                double dblCommission;
                double dblTotalTemps;
                var dblProfit = default(double);
                double dblTotalManuel;
                double dblTotalImprevue;
                double dblGrandTotal;
                double dblTotalDessin;
                double dblTotalCoupe;
                double dblTotalMachinage;
                double dblTotalSoudure;
                double dblTotalAssemblage;
                double dblTotalPeinture;
                double dblTotalTest;
                double dblTotalInstallation;
                double dblTotalFormation;
                double dblTotalGestion;
                double dblTotalShipping;
                double dblPrixEmballage;
                double dblTotalResteTemps;
                rstProjet = new Recordset();
                rstProjet.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + sNoProjSoum + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjet.EOF)
                {
                    rstPiece = new Recordset();
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + sNoProjSoum + "' AND Type = 'M'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstPiece.EOF)
                    {
                        if (!string.IsNullOrEmpty($"{rstPiece.Fields["Prix_total"].Value}".Trim()))
                        {
                            dblPrixPieces -= (double)rstPiece.Fields["Prix_total"].Value + (double)rstPiece.Fields["Profit_Argent"].Value;
                            dblProfit += (double)rstPiece.Fields["Profit_Argent"].Value;
                        }
                        rstPiece.MoveNext();
                    }
                    rstPunch = new Recordset();
                    rstPunch.Open("SELECT Type, SUM(DATEDIFF(HOUR,[HEUREDÉBUT],[HEUREFIN] )) AS TOTAL FROM Punch " +
                        "WHERE NoProjet = '" + sNoProjSoum + "' And HeureFin is not null AND HeureDébut is not null " +
                        "GROUP BY Type", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    dblTotalDessin = 0d;
                    dblTotalCoupe = 0d;
                    dblTotalMachinage = 0d;
                    dblTotalSoudure = 0d;
                    dblTotalAssemblage = 0d;
                    dblTotalPeinture = 0d;
                    dblTotalTest = 0d;
                    dblTotalInstallation = 0d;
                    dblTotalFormation = 0d;
                    dblTotalGestion = 0d;
                    dblTotalShipping = 0d;
                    while (!rstPunch.EOF)
                    {
                        if (!(rstPunch.Fields["Total"].Value is DBNull))
                        {
                            switch (rstPunch.Fields["Type"].Value)
                            {
                                case "Dessin": { dblTotalDessin = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxDessin"].Value}"); break; }
                                case "Coupe": { dblTotalCoupe = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxCoupe"].Value}"); break; }
                                case "Machinage": { dblTotalMachinage = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxMachinage"].Value}"); break; }
                                case "Soudure": { dblTotalSoudure = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxSoudure"].Value}"); break; }
                                case "Assemblage": { dblTotalAssemblage = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxAssemblage"].Value}"); break; }
                                case "Peinture": { dblTotalPeinture = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxPeinture"].Value}"); break; }
                                case "Test": { dblTotalTest = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxTest"].Value}"); break; }
                                case "Installation": { dblTotalInstallation = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxInstallation"].Value}"); break; }
                                case "Formation": { dblTotalFormation = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxFormation"].Value}"); break; }
                                case "Gestion": { dblTotalGestion = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxGestion"].Value}"); break; }
                                case "Shipping": { dblTotalShipping = double.Parse($"{rstPunch.Fields["Total"].Value}") * double.Parse($"{rstProjet.Fields["TauxShipping"].Value}"); break; }
                            }
                        }
                        rstPunch.MoveNext();
                    }
                    rstPunch.Close();
                    rstPunch = null;
                    dblTotalTemps = dblTotalDessin + dblTotalCoupe + dblTotalMachinage + dblTotalSoudure + dblTotalAssemblage + dblTotalPeinture + dblTotalTest + dblTotalInstallation + dblTotalFormation + dblTotalGestion + dblTotalShipping;
                    if (IsNumeric(rstProjet.Fields["PrixEmballage"].Value))
                    {
                        dblPrixEmballage = double.Parse($"{rstProjet.Fields["PrixEmballage"].Value}");
                    }
                    else
                    {
                        dblPrixEmballage = 0d;
                    }
                    dblTotalResteTemps = dblPrixEmballage;
                    if (IsNumeric(rstProjet.Fields["total_manuel"].Value))
                    {
                        dblTotalManuel = double.Parse($"{rstProjet.Fields["total_manuel"].Value}");
                    }
                    else
                    {
                        dblTotalManuel = 0d;
                    }
                    dblTotalImprevue = Math.Round((dblPrixPieces + dblProfit) * double.Parse(rstProjet.Fields["Imprevue"].Value), 2);
                    dblPrixTotal = dblPrixPieces + dblProfit + dblTotalTemps + dblTotalImprevue + dblTotalManuel + dblTotalResteTemps;
                    dblCommission = Math.Round(dblPrixTotal * double.Parse(rstProjet.Fields["Commission"].Value), 2);
                    dblGrandTotal = dblPrixTotal + dblCommission;
                    rstProjet.Fields["Total_Piece"].Value = Math.Round(dblPrixPieces, 2).ToString();
                    rstProjet.Fields["Total_Temps"].Value = Math.Round(dblTotalTemps, 2).ToString();
                    rstProjet.Fields["PrixTotal"].Value = Math.Round(dblGrandTotal, 2).ToString();
                    rstProjet.Fields["total_Imprevue"].Value = Math.Round(dblTotalImprevue, 2).ToString();
                    rstProjet.Fields["total_commission"].Value = Math.Round(dblCommission, 2).ToString();
                    rstProjet.Fields["total_profit"].Value = Math.Round(dblProfit, 2).ToString();
                    rstProjet.Update();
                    rstPiece.Close();
                    rstPiece = null;
                }
                else
                {
                    MessageBox.Show("Le projet " + sNoProjSoum + " est inexistant!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rstProjet.Close();
                rstProjet = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "CalculerTotalRecordset", ex);
            }
        }
        private void ModifierFournisseurBD()
        {
            try
            {
                ADODB.Recordset rstPiece;
                ADODB.Recordset rstProjet;
                string sProfit;
                int X;
                var bModif = default(bool);
                int XColl;
                var iIndexColl = default(int);
                string sLiaison;
                rstProjet = new Recordset();
                if (m_sType == "E")
                {
                    rstProjet.Open("SELECT Profit, LiaisonChargeable FROM ProjetElec WHERE IDProjet = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstProjet.Open("SELECT Profit, LiaisonChargeable FROM ProjetMec WHERE IDProjet = '" + m_sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                sProfit = $"{rstProjet.Fields["Profit"].Value}";
                if (!(rstProjet.Fields["LiaisonChargeable"].Value is DBNull))
                {
                    sLiaison = $"{rstProjet.Fields["LiaisonChargeable"].Value}";
                }
                else
                {
                    sLiaison = "";
                }
                rstProjet.Close();
                rstProjet = null;
                rstPiece = new Recordset();
                var loopTo = (int)lvwPiece.Items.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    if (lvwPiece.Items[X].Checked == true)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwPiece.Items[X].SubItems[I_COL_FOURNISSEUR].Tag, "", false)))
                        {
                            bModif = true;
                            rstPiece.Open(Operators.ConcatenateObject("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + m_sNoProjet + "' AND NuméroLigne = ", lvwPiece.Items[(int)X].SubItems[(int)I_COL_NO_ITEM].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            var loopTo1 = (int)m_collNoLigneFRS.Count;
                            for (XColl = 1; XColl <= loopTo1; XColl++)
                            {
                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(m_collNoLigneFRS[XColl], lvwPiece.Items[X].SubItems[I_COL_NO_ITEM].Tag, false)))
                                {
                                    iIndexColl = XColl;
                                    break;
                                }
                            }
                            rstPiece.Fields["IDFRS"].Value = lvwPiece.Items[X].SubItems[I_COL_FOURNISSEUR].Tag;
                            if (string.IsNullOrEmpty(m_collPrixList[iIndexColl].Trim()))
                            {
                                rstPiece.Fields["PRIX_LIST"].Value = "0";
                            }
                            else
                            {
                                rstPiece.Fields["PRIX_LIST"].Value = m_collPrixList[iIndexColl];
                                rstPiece.Fields["PrixOrigine"].Value = m_collPrixOrigine[iIndexColl];
                            }
                            if (!string.IsNullOrEmpty(m_collPrixNet[iIndexColl].Trim()))
                            {
                                rstPiece.Fields["ESCOMPTE"].Value =m_collEscompte[iIndexColl];
                                rstPiece.Fields["PRIX_NET"].Value =m_collPrixNet[iIndexColl];
                            }
                            else if (!string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text)))
                            {
                                rstPiece.Fields["PRIX_NET"].Value =m_collPrixSP[iIndexColl];
                            }
                            else
                            {
                                rstPiece.Fields["ESCOMPTE"].Value = "0";
                                rstPiece.Fields["PRIX_NET"].Value = "0";
                            }
                            rstPiece.Fields["Prix_Total"].Value =Math.Round(double.Parse($"{rstPiece.Fields["Qté"].Value}".Replace( "*", string.Empty))* double.Parse($"{ rstPiece.Fields["PRIX_NET"].Value}")* double.Parse(sProfit), 2).ToString();
                            rstPiece.Fields["Profit_argent"].Value = Math.Round(double.Parse($"{rstPiece.Fields["Prix_Total"].Value}") -(double.Parse($"{rstPiece.Fields["PRIX_NET"].Value}")* double.Parse($"{rstPiece.Fields["Qté"].Value}".Replace( "*", string.Empty))), 2).ToString();
                            rstPiece.Update();
                            rstPiece.Close();
                            if (!string.IsNullOrEmpty(sLiaison))
                            {


                                rstPiece.Open("SELECT * FROM Projet_Pieces WHERE IDProjet = '" + Gauche(m_sNoProjet, Strings.Len(m_sNoProjet) - 2) + sLiaison + "' AND Provenance = '" + Droite(m_sNoProjet, 2) + "' AND NumItem = '" + lvwPiece.Items[(int)X].SubItems[(int)I_COL_NO_ITEM].Text + "' AND Qté = '" + lvwPiece.Items[(int)X].Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                var loopTo2 = (int)m_collNoLigneFRS.Count;
                                for (XColl = 1; XColl <= loopTo2; XColl++)
                                {
                                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(m_collNoLigneFRS[XColl], lvwPiece.Items[X].SubItems[I_COL_NO_ITEM].Tag, false)))
                                    {
                                        iIndexColl = XColl;
                                        break;
                                    }
                                }
                                rstPiece.Fields["IDFRS"].Value = lvwPiece.Items[X].SubItems[I_COL_FOURNISSEUR].Tag;
                                if (string.IsNullOrEmpty(m_collPrixList[iIndexColl].Trim()))
                                {
                                    rstPiece.Fields["PRIX_LIST"].Value = "0";
                                }
                                else
                                {
                                    rstPiece.Fields["PRIX_LIST"].Value = m_collPrixList[iIndexColl];
                                    rstPiece.Fields["PrixOrigine"].Value =m_collPrixOrigine[iIndexColl];
                                }
                                if (!string.IsNullOrEmpty(m_collPrixNet[iIndexColl].Trim()))
                                {
                                    rstPiece.Fields["ESCOMPTE"].Value = m_collEscompte[iIndexColl];
                                    rstPiece.Fields["PRIX_NET"].Value = m_collPrixNet[iIndexColl];
                                }
                                else if (!string.IsNullOrEmpty(Strings.Trim(lvwFournisseur.FocusedItem.SubItems[I_COL_FRS_PRIX_SP].Text)))
                                {
                                    rstPiece.Fields["PRIX_NET"].Value = m_collPrixSP[iIndexColl];
                                }
                                else
                                {
                                    rstPiece.Fields["ESCOMPTE"].Value = "0";
                                    rstPiece.Fields["PRIX_NET"].Value = "0";
                                }

                                rstPiece.Fields["Prix_Total"].Value = Math.Round(double.Parse($"{rstPiece.Fields["Qté"].Value}".Replace( "*", string.Empty))* double.Parse($"{rstPiece.Fields["PRIX_NET"].Value}" )* double.Parse(sProfit), 2).ToString();
                                rstPiece.Fields["Profit_argent"].Value = Math.Round(double.Parse($"{rstPiece.Fields["Prix_Total"].Value}")-(double.Parse($"{rstPiece.Fields["PRIX_NET"].Value}")* double.Parse($"{rstPiece.Fields["Qté"].Value}".Replace("*", string.Empty))), 2).ToString();
                                rstPiece.Update();
                                rstPiece.Close();
                            }
                        }
                    }
                }
                rstPiece = null;
                if (bModif == true)
                {
                    if (m_sType == "E")
                    {
                        CalculerTotalRecordsetElec(m_sNoProjet);
                        if (!string.IsNullOrEmpty(sLiaison))
                        {
                            CalculerTotalRecordsetElec(Gauche(m_sNoProjet, Strings.Len(m_sNoProjet) - 2) + sLiaison);
                        }
                        ProjSoumElec.m_bModintFournisseurBC = true;
                    }
                    else
                    {
                        CalculerTotalRecordsetMec(m_sNoProjet);
                        if (!string.IsNullOrEmpty(sLiaison))
                        {
                            CalculerTotalRecordsetMec(Gauche(m_sNoProjet, Strings.Len(m_sNoProjet) - 2) + sLiaison);
                        }
                        ProjSoumMec.m_bModintFournisseurBC = true;
                    }
                }
                else if (m_sType == "E")
                {
                    ProjSoumElec.m_bModintFournisseurBC = false;
                }
                else
                {
                    m_bModifFournisseurBC = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixBonCommande", "ModifierFournisseurBD", ex);
            }
        }
    }
}