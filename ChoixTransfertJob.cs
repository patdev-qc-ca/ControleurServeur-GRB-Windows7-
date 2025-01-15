using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;


namespace ControleurServeur
{
    internal class ChoixTransfertJob : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixTransfertJob() : base()
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
        internal static Button cmdAnnuler;
        internal static Button cmdCreer;
        internal static ColumnHeader _lvwPiece_ColumnHeader_1;
        internal static ColumnHeader _lvwPiece_ColumnHeader_2;
        internal static ColumnHeader _lvwPiece_ColumnHeader_3;
        internal static ColumnHeader _lvwPiece_ColumnHeader_4;
        internal static ColumnHeader _lvwPiece_ColumnHeader_5;
        internal static ListView lvwPiece;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdDeselectAll = new System.Windows.Forms.Button();
            cmdSelectAll = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdCreer = new System.Windows.Forms.Button();
            lvwPiece = new System.Windows.Forms.ListView();
            _lvwPiece_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lvwPiece_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _lvwPiece_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            _lvwPiece_ColumnHeader_4 = new System.Windows.Forms.ColumnHeader();
            _lvwPiece_ColumnHeader_5 = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();//cmdDeselectAll
            cmdDeselectAll.BackColor = System.Drawing.Color.Black;
            cmdDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdDeselectAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdDeselectAll.ForeColor = System.Drawing.Color.White;
            cmdDeselectAll.Location = new System.Drawing.Point(86, 648);
            cmdDeselectAll.Name = "cmdDeselectAll";
            cmdDeselectAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDeselectAll.Size = new System.Drawing.Size(73, 25);
            cmdDeselectAll.TabIndex = 2;
            cmdDeselectAll.Text = "Aucun";
            cmdDeselectAll.UseVisualStyleBackColor = true;
            cmdDeselectAll.Click += new System.EventHandler(cmdDeSelectAll_Click);//cmdSelectAll
            cmdSelectAll.BackColor = System.Drawing.Color.Black;
            cmdSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdSelectAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdSelectAll.ForeColor = System.Drawing.Color.White;
            cmdSelectAll.Location = new System.Drawing.Point(6, 648);
            cmdSelectAll.Name = "cmdSelectAll";
            cmdSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSelectAll.Size = new System.Drawing.Size(73, 25);
            cmdSelectAll.TabIndex = 1;
            cmdSelectAll.Text = "Tous";
            cmdSelectAll.UseVisualStyleBackColor = true;
            cmdSelectAll.Click += new System.EventHandler(cmdSelectAll_Click);//cmdAnnuler
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(726, 648);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(81, 25);
            cmdAnnuler.TabIndex = 3;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);//cmdCreer
            cmdCreer.BackColor = System.Drawing.Color.Black;
            cmdCreer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdCreer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdCreer.ForeColor = System.Drawing.Color.White;
            cmdCreer.Location = new System.Drawing.Point(639, 648);
            cmdCreer.Name = "cmdCreer";
            cmdCreer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCreer.Size = new System.Drawing.Size(81, 25);
            cmdCreer.TabIndex = 4;
            cmdCreer.Text = "Créer le projet";
            cmdCreer.UseVisualStyleBackColor = true;
            cmdCreer.Click += new System.EventHandler(cmdCreer_Click);//lvwPiece
            lvwPiece.BackColor = System.Drawing.Color.Black;
            lvwPiece.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lvwPiece.CheckBoxes = true;
            lvwPiece.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwPiece_ColumnHeader_1,
            _lvwPiece_ColumnHeader_2,
            _lvwPiece_ColumnHeader_3,
            _lvwPiece_ColumnHeader_4,
            _lvwPiece_ColumnHeader_5});
            lvwPiece.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwPiece.ForeColor = System.Drawing.Color.White;
            lvwPiece.FullRowSelect = true;
            lvwPiece.GridLines = true;
            lvwPiece.HideSelection = false;
            lvwPiece.Location = new System.Drawing.Point(8, 64);
            lvwPiece.Name = "lvwPiece";
            lvwPiece.Size = new System.Drawing.Size(801, 557);
            lvwPiece.TabIndex = 0;
            lvwPiece.UseCompatibleStateImageBehavior = false;
            lvwPiece.View = System.Windows.Forms.View.Details;
            lvwPiece.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(lvwPiece_ItemCheck);//_lvwPiece_ColumnHeader_1
            _lvwPiece_ColumnHeader_1.Text = "Qté";
            _lvwPiece_ColumnHeader_1.Width = 53;//_lvwPiece_ColumnHeader_2
            _lvwPiece_ColumnHeader_2.Text = "No. Item";
            _lvwPiece_ColumnHeader_2.Width = 216;//_lvwPiece_ColumnHeader_3
            _lvwPiece_ColumnHeader_3.Text = "Description";
            _lvwPiece_ColumnHeader_3.Width = 448;//_lvwPiece_ColumnHeader_4
            _lvwPiece_ColumnHeader_4.Text = "Manufacturier";
            _lvwPiece_ColumnHeader_4.Width = 136;//_lvwPiece_ColumnHeader_5
            _lvwPiece_ColumnHeader_5.Text = "Fournisseur";
            _lvwPiece_ColumnHeader_5.Width = 170;//ChoixTransfertJob
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(821, 688);
            Controls.Add(cmdDeselectAll);
            Controls.Add(cmdSelectAll);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdCreer);
            Controls.Add(lvwPiece);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Location = new System.Drawing.Point(3, 22);
            Name = "ChoixTransfertJob";
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
            Load += new System.EventHandler(ChoixTransfertJob_Load);
            ResumeLayout(false);
        }
        #endregion
        private const int I_COL_QTE = 0;
        private const int I_COL_NO_ITEM = 1;
        private const int I_COL_DESCRIPTION = 2;
        private const int I_COL_MANUFACTURIER = 3;
        private const int I_COL_FOURNISSEUR = 4;
        private string m_sNoSoumission;
        private string m_sType;
        private string v;
        public ChoixTransfertJob(string text, string v)
        {
            Text = text;
            v = v;
        }
        public void Afficher(string sNoSoumission, string sType)
        {
            try
            {
                m_sNoSoumission = sNoSoumission;
                m_sType = sType;
                RemplirListViewPieces();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixTransfertJob", "Afficher", ex);
            }
        }
        [Obsolete]
        private void RemplirListViewPieces()
        {
            try
            {
                ADODB.Recordset rstPieces;
                ADODB.Recordset rstSection;
                ADODB.Recordset rstFRS;
                ListViewItem itmPieces;
                bool bPremierEnr;
                var iOrdreSection = default(int);
                var sSousSection = default(string);
                bPremierEnr = true;
                lvwPiece.Sorting = SortOrder.None;
                rstFRS = new Recordset();
                rstPieces = new Recordset();
                rstSection = new Recordset();

                rstPieces.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + m_sNoSoumission + "' AND Type = '" + m_sType + "' AND PieceExtraChargeable=0AND PieceExtraNonChargeable=0ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstPieces.EOF)
                {
                    itmPieces = lvwPiece.Items.Add(string.Empty);
                    if (bPremierEnr == true)
                    {
                        sSousSection = (string)(rstPieces.Fields["SousSection"].Value);
                        iOrdreSection = int.Parse(rstPieces.Fields["OrdreSection"].Value);
                        if (m_sType == "E")
                        {
                            rstSection.Open(Operators.ConcatenateObject("SELECT NomSectionFR FROM SoumProjSectionElec WHERE IDSection = ", rstPieces.Fields["IDSection"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstSection.Open(Operators.ConcatenateObject("SELECT NomSectionFR FROM SoumProjSectionMec WHERE IDSection = ", rstPieces.Fields["IDSection"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        if (!(rstSection.Fields["NomSectionFR"].Value is DBNull))
                        {
                            if (itmPieces.SubItems.Count > I_COL_NO_ITEM)
                            {
                                itmPieces.SubItems[I_COL_NO_ITEM].Text = (string)(rstSection.Fields["NomSectionFR"].Value);
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, (string)(rstSection.Fields["NomSectionFR"].Value)));
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
                        itmPieces = lvwPiece.Items.Add(string.Empty);
                        bPremierEnr = false;
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(iOrdreSection, rstPieces.Fields["OrdreSection"].Value, false)))
                    {
                        iOrdreSection = int.Parse(rstPieces.Fields["OrdreSection"].Value);
                        if (m_sType == "E")
                        {
                            rstSection.Open(Operators.ConcatenateObject("SELECT NomSectionFR FROM SoumProjSectionElec WHERE IDSection = ", rstPieces.Fields["IDSection"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstSection.Open(Operators.ConcatenateObject("SELECT NomSectionFR FROM SoumProjSectionMec WHERE IDSection = ", rstPieces.Fields["IDSection"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        if (!(rstSection.Fields["NomSectionFR"].Value is DBNull))
                        {

                            if (itmPieces.SubItems.Count > I_COL_NO_ITEM)
                            {
                                itmPieces.SubItems[I_COL_NO_ITEM].Text = (string)(rstSection.Fields["NomSectionFR"].Value);
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, (string)(rstSection.Fields["NomSectionFR"].Value)));
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
                        sSousSection = (string)(rstPieces.Fields["SousSection"].Value);
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
                            itmPieces.SubItems[I_COL_DESCRIPTION].Text = (string)(rstPieces.Fields["SousSection"].Value);
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, (string)(rstPieces.Fields["SousSection"].Value)));
                        }
                        itmPieces = lvwPiece.Items.Add(string.Empty);
                    }
                    else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(sSousSection, rstPieces.Fields["SousSection"].Value, false)))
                    {
                        sSousSection = (string)(rstPieces.Fields["SousSection"].Value);
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
                        itmPieces = lvwPiece.Items.Add(string.Empty);
                    }

                    if (!(rstPieces.Fields["Qté"].Value is DBNull))
                    {
                        itmPieces.Text = (string)(rstPieces.Fields["Qté"].Value);
                    }
                    else
                    {
                        itmPieces.Text = string.Empty;
                    }
                    itmPieces.Tag = rstPieces.Fields["NoEnreg"].Value;

                    if (!(rstPieces.Fields["NumItem"].Value is DBNull))
                    {

                        if (itmPieces.SubItems.Count > I_COL_NO_ITEM)
                        {
                            itmPieces.SubItems[I_COL_NO_ITEM].Text = (string)(rstPieces.Fields["NumItem"].Value);
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_NO_ITEM, new ListViewItem.ListViewSubItem(null, (string)(rstPieces.Fields["NumItem"].Value)));
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
                    itmPieces.SubItems[I_COL_NO_ITEM].Tag = rstPieces.Fields["NuméroLigne"].Value;

                    if (!(rstPieces.Fields["Desc_FR"].Value is DBNull))
                    {

                        if (itmPieces.SubItems.Count > I_COL_DESCRIPTION)
                        {
                            itmPieces.SubItems[I_COL_DESCRIPTION].Text = (string)(rstPieces.Fields["Desc_FR"].Value);
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_DESCRIPTION, new ListViewItem.ListViewSubItem(null, (string)(rstPieces.Fields["Desc_FR"].Value)));
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

                    if (!(rstPieces.Fields["Manufact"].Value is DBNull))
                    {

                        if (itmPieces.SubItems.Count > I_COL_MANUFACTURIER)
                        {
                            itmPieces.SubItems[I_COL_MANUFACTURIER].Text = (string)(rstPieces.Fields["Manufact"].Value);
                        }
                        else
                        {
                            itmPieces.SubItems.Insert(I_COL_MANUFACTURIER, new ListViewItem.ListViewSubItem(null, (string)(rstPieces.Fields["Manufact"].Value)));
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

                    if (Conversions.ToBoolean(Operators.AndObject(!(rstPieces.Fields["IDFRS"].Value is DBNull), Operators.ConditionalCompareObjectGreater(rstPieces.Fields["IDFRS"].Value, 0, false))))
                    {

                        if (itmPieces.SubItems[I_COL_NO_ITEM].Text != "Texte")
                        {
                            rstFRS.Open(Operators.ConcatenateObject("SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = ", rstPieces.Fields["IDFRS"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);


                            if (itmPieces.SubItems.Count > I_COL_FOURNISSEUR)
                            {
                                itmPieces.SubItems[I_COL_FOURNISSEUR].Text = (string)(rstFRS.Fields["NomFournisseur"].Value);
                            }
                            else
                            {
                                itmPieces.SubItems.Insert(I_COL_FOURNISSEUR, new ListViewItem.ListViewSubItem(null, (string)(rstFRS.Fields["NomFournisseur"].Value)));
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
                    rstPieces.MoveNext();
                }
                rstPieces.Close();
                rstPieces = null;
                rstFRS = null;
                rstSection = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixTransfertJob", "RemplirListViewPieces", ex);
            }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_sType == "E")
                {
                    ProjSoumElec.m_bTransfertJobCancel = true;
                }
                else
                {
                    ProjSoumMec.m_bTransfertJobCancel = true;
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixTransfertJob", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdCreer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstSoum;
                int X;
                rstSoum = new Recordset();
                rstSoum.Open("SELECT * FROM Soumission_Pieces WHERE IDSoumission = '" + m_sNoSoumission + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstSoum.EOF)
                {
                    var loopTo = (int)lvwPiece.Items.Count;
                    for (X = 1; X <= loopTo; X++)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(lvwPiece.Items[(int)X].Tag, rstSoum.Fields["NoEnreg"].Value, false)))
                        {
                            if (lvwPiece.Items[X].Checked == true)
                            {
                                rstSoum.Fields["TransfertJob"].Value = true;
                            }
                            else
                            {
                                rstSoum.Fields["TransfertJob"].Value = false;
                            }
                            rstSoum.Update();
                            break;
                        }
                    }
                    rstSoum.MoveNext();
                }
                rstSoum.Close();
                rstSoum = null;
                if (m_sType == "E")
                {
                    ProjSoumElec.m_bTransfertJobCancel = false;
                }
                else
                {
                    ProjSoumMec.m_bTransfertJobCancel = false;
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixTransfertJob", "cmdCreer_Click", ex);
            }
        }
        private void cmdSelectAll_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                var loopTo = (int)lvwPiece.Items.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(lvwPiece.Items[X].Tag, string.Empty, false)))
                    {
                        if (!string.IsNullOrEmpty(lvwPiece.Items[X].SubItems[I_COL_NO_ITEM].Text))
                        {

                            lvwPiece.Items[X].Checked = true;
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixTransfertJob", "cmdSelectAll_Click", ex);
            }
        }
        private void cmdDeSelectAll_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                var loopTo = (int)lvwPiece.Items.Count;
                for (X = 1; X <= loopTo; X++)

                    lvwPiece.Items[X].Checked = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixTransfertJob", "cmdDeselectAll_Click", ex);
            }
        }
        private void ChoixTransfertJob_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixTransfertJob", "Form_Load", ex);
            }
        }
        private void lvwPiece_ItemCheck(object eventSender, ItemCheckEventArgs eventArgs)
        {
            var Item = lvwPiece.Items[eventArgs.Index];
            try
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(Item.Tag, string.Empty, false), string.IsNullOrEmpty(Item.SubItems[I_COL_NO_ITEM].Text))))
                {
                    Item.Checked = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixTransfertJob", "lvwPiece_ItemCheck", ex);
            }
        }
    }
}