using System;
using System.Windows.Forms;
using ADODB;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class DistList : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public DistList() : base()
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
        internal static Button cmdCreerListe;
        internal static ColumnHeader _lvwContacts_ColumnHeader_1;
        internal static ColumnHeader _lvwContacts_ColumnHeader_2;
        internal static ColumnHeader _lvwContacts_ColumnHeader_3;
        internal static ListView lvwContacts;
        internal static GroupBox Frame2;
        internal static Button cmdAfficher;
        internal static Button cmdRafraichir;
        internal static ColumnHeader _lvwDistList_ColumnHeader_1;
        internal static ColumnHeader _lvwDistList_ColumnHeader_2;
        internal static ColumnHeader _lvwDistList_ColumnHeader_3;
        internal static ListView lvwDistList;
        internal static GroupBox Frame1;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdCreerListe = new System.Windows.Forms.Button();
            Frame2 = new System.Windows.Forms.GroupBox();
            lvwContacts = new System.Windows.Forms.ListView();
            _lvwContacts_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwContacts_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwContacts_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Frame1 = new System.Windows.Forms.GroupBox();
            cmdAfficher = new System.Windows.Forms.Button();
            cmdRafraichir = new System.Windows.Forms.Button();
            lvwDistList = new System.Windows.Forms.ListView();
            _lvwDistList_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwDistList_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwDistList_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Frame2.SuspendLayout();
            Frame1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdCreerListe
            // 
            cmdCreerListe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdCreerListe.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdCreerListe.Location = new System.Drawing.Point(628, 207);
            cmdCreerListe.Name = "cmdCreerListe";
            cmdCreerListe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCreerListe.Size = new System.Drawing.Size(137, 25);
            cmdCreerListe.TabIndex = 4;
            cmdCreerListe.Text = "Recréer les listes";
            cmdCreerListe.UseVisualStyleBackColor = true;
            cmdCreerListe.Click += new System.EventHandler(cmdCreerListe_Click);
            // 
            // Frame2
            // 
            Frame2.Controls.Add(lvwContacts);
            Frame2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Frame2.Location = new System.Drawing.Point(8, 324);
            Frame2.Name = "Frame2";
            Frame2.Padding = new System.Windows.Forms.Padding(0);
            Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Frame2.Size = new System.Drawing.Size(849, 401);
            Frame2.TabIndex = 1;
            Frame2.TabStop = false;
            Frame2.Text = "Contacts";
            // 
            // lvwContacts
            // 
            lvwContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwContacts_ColumnHeader_1,
            _lvwContacts_ColumnHeader_2,
            _lvwContacts_ColumnHeader_3});
            lvwContacts.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwContacts.FullRowSelect = true;
            lvwContacts.GridLines = true;
            lvwContacts.HideSelection = false;
            lvwContacts.Location = new System.Drawing.Point(1, 18);
            lvwContacts.Name = "lvwContacts";
            lvwContacts.Size = new System.Drawing.Size(833, 369);
            lvwContacts.TabIndex = 3;
            lvwContacts.UseCompatibleStateImageBehavior = false;
            lvwContacts.View = System.Windows.Forms.View.Details;
            lvwContacts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(lvwContacts_ColumnClick);
            lvwContacts.SelectedIndexChanged += new System.EventHandler(lvwContacts_SelectedIndexChanged);
            // 
            // _lvwContacts_ColumnHeader_1
            // 
            _lvwContacts_ColumnHeader_1.Text = "Nom";
            _lvwContacts_ColumnHeader_1.Width = 416;
            // 
            // _lvwContacts_ColumnHeader_2
            // 
            _lvwContacts_ColumnHeader_2.Text = "Courriel";
            _lvwContacts_ColumnHeader_2.Width = 236;
            // 
            // _lvwContacts_ColumnHeader_3
            // 
            _lvwContacts_ColumnHeader_3.Text = "Liste";
            _lvwContacts_ColumnHeader_3.Width = 177;
            // 
            // Frame1
            // 
            Frame1.Controls.Add(cmdCreerListe);
            Frame1.Controls.Add(cmdAfficher);
            Frame1.Controls.Add(cmdRafraichir);
            Frame1.Controls.Add(lvwDistList);
            Frame1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Frame1.Location = new System.Drawing.Point(77, 67);
            Frame1.Name = "Frame1";
            Frame1.Padding = new System.Windows.Forms.Padding(0);
            Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Frame1.Size = new System.Drawing.Size(780, 251);
            Frame1.TabIndex = 0;
            Frame1.TabStop = false;
            Frame1.Text = "Listes";
            // 
            // cmdAfficher
            // 
            cmdAfficher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAfficher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAfficher.Location = new System.Drawing.Point(540, 207);
            cmdAfficher.Name = "cmdAfficher";
            cmdAfficher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAfficher.Size = new System.Drawing.Size(82, 25);
            cmdAfficher.TabIndex = 6;
            cmdAfficher.Text = "Afficher";
            cmdAfficher.UseVisualStyleBackColor = true;
            cmdAfficher.Click += new System.EventHandler(cmdAfficher_Click);
            // 
            // cmdRafraichir
            // 
            cmdRafraichir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdRafraichir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdRafraichir.Location = new System.Drawing.Point(448, 207);
            cmdRafraichir.Name = "cmdRafraichir";
            cmdRafraichir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdRafraichir.Size = new System.Drawing.Size(86, 25);
            cmdRafraichir.TabIndex = 5;
            cmdRafraichir.Text = "Rafraîchir";
            cmdRafraichir.UseVisualStyleBackColor = true;
            cmdRafraichir.Click += new System.EventHandler(cmdRafraichir_Click);
            // 
            // lvwDistList
            // 
            lvwDistList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwDistList_ColumnHeader_1,
            _lvwDistList_ColumnHeader_2});
            lvwDistList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwDistList.FullRowSelect = true;
            lvwDistList.GridLines = true;
            lvwDistList.HideSelection = false;
            lvwDistList.Location = new System.Drawing.Point(8, 24);
            lvwDistList.Name = "lvwDistList";
            lvwDistList.Size = new System.Drawing.Size(757, 177);
            lvwDistList.TabIndex = 2;
            lvwDistList.UseCompatibleStateImageBehavior = false;
            lvwDistList.View = System.Windows.Forms.View.Details;
            lvwDistList.SelectedIndexChanged += new System.EventHandler(lvwDistList_SelectedIndexChanged);
            lvwDistList.Click += new System.EventHandler(lvwDistList_SelectedIndexChanged);
            // 
            // _lvwDistList_ColumnHeader_1
            // 
            _lvwDistList_ColumnHeader_1.Text = "Nom de la liste";
            _lvwDistList_ColumnHeader_1.Width = 631;
            // 
            // _lvwDistList_ColumnHeader_2
            // 
            _lvwDistList_ColumnHeader_2.Text = "Nombre de membres";
            _lvwDistList_ColumnHeader_2.Width = 117;
            // 
            // DistList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(875, 758);
            Controls.Add(Frame2);
            Controls.Add(Frame1);
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            Location = new System.Drawing.Point(3, 29);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DistList";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Listes de distribution";
            Load += new System.EventHandler(DistList_Load);
            Frame2.ResumeLayout(false);
            Frame1.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion
        private const int I_COL_DISTLIST_NOM = 0;
        private const int I_COL_DISTLIST_DOSSIER = 1;
        private const int I_COL_DISTLIST_NBRE = 2;
        private const int I_COL_CONTACT_NOM = 0;
        private const int I_COL_CONTACT_COURRIEL = 1;
        private const int I_COL_CONTACT_DISTLIST = 2;
        private const int I_ITM_TOUTES_LISTES = 1;
        private void RemplirListViewDistList()
        {
            Recordset rd = new Recordset();
            int nbContacts = 0;
            int nbClients = 0;
            int nbFournisseur = 0;
            int nbChefEntreprise = 0;
            int nbIsMeat = 0;
            rd.Open($"SELECT DISTINCT *  FROM [DBO].[LISTEDISTRIBUTION] " +
                $"WHERE NOMCOMPAGNIE != '' AND EMAIL != '' " +
                $"ORDER BY NOMCOMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
/*
 * ID 5 : isContact
 * ID 6 : isClient
 * ID 7 : isFournisseur
 * ID 8 : isChefEntreprise
 * ID 9 : isMeatProcessing
         */
            while (!rd.EOF)
            {
                if ((bool)rd.Fields[5].Value == true) {nbContacts++;}
                if ((bool)rd.Fields[6].Value == true) { nbClients++;}
                if ((bool)rd.Fields[7].Value == true) { nbFournisseur++; }
                if ((bool)rd.Fields[8].Value == true) { nbChefEntreprise++; }
                if ((bool)rd.Fields[9].Value == true) { nbIsMeat++; }
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
            Application.DoEvents();
            lvwDistList.Items[1].SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, nbContacts.ToString()));
            lvwDistList.Items[2].SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, nbClients.ToString()));
            lvwDistList.Items[3].SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, nbFournisseur.ToString()));
            lvwDistList.Items[4].SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, nbChefEntreprise .ToString()));
            lvwDistList.Items[5].SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, nbIsMeat.ToString()));
        }
        private void cmdAfficher_Click(object eventSender, EventArgs eventArgs)
        {
            lvwContacts.Items.Clear();
            try
            {
                Recordset rd = new Recordset();
                Conteneur.txtStatus.Text = lvwDistList.SelectedItems[0].Text;
                switch (lvwDistList.SelectedItems[0].Text)
                {
                    case "(Toutes les listes)":
                        {
                            rd.Open($"SELECT DISTINCT [EMAIL],[CONTACT],[NOMCOMPAGNIE] FROM [DBO].[LISTEDISTRIBUTION] " +
                                $"ORDER BY EMAIL, NOMCOMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        break;
                    case "Contacts GRB":
                        {
                            rd.Open($"SELECT DISTINCT [EMAIL],[CONTACT],[NOMCOMPAGNIE] FROM [DBO].[LISTEDISTRIBUTION] " +
                                $"ORDER BY EMAIL, NOMCOMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        break;
                    case "Clients GRB":
                        {
                            rd.Open($"SELECT DISTINCT [EMAIL],[CONTACT],[NOMCOMPAGNIE] FROM [DBO].[LISTEDISTRIBUTION] " +
                                $"WHERE [ISCLIENT] = 1 ORDER BY EMAIL, NOMCOMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        break;
                    case "Fournisseurs GRB":
                        {
                            rd.Open($"SELECT DISTINCT [EMAIL],[CONTACT],[NOMCOMPAGNIE] FROM [DBO].[LISTEDISTRIBUTION] " +
                                $"WHERE[isFournisseur] = 1 " +
                                $"ORDER BY EMAIL, NOMCOMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        break;
                    case "Chefs d'entreprise":
                        {
                            rd.Open($"SELECT DISTINCT [EMAIL],[CONTACT],[NOMCOMPAGNIE] FROM [DBO].[LISTEDISTRIBUTION] " +
                                $"WHERE[isChefEntreprise] = 1 " +
                                $"ORDER BY EMAIL, NOMCOMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        break;
                    case "Transformation de viande":
                        {
                            rd.Open($"SELECT DISTINCT [EMAIL],[CONTACT],[NOMCOMPAGNIE] FROM [DBO].[LISTEDISTRIBUTION] " +
                                $"WHERE[isMeatProcessing] = 1 " +
                                $"ORDER BY EMAIL, NOMCOMPAGNIE", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        break;
                }
                while (!rd.EOF)
                {
                    ListViewItem itm = lvwContacts.Items.Add(string.Empty);
                    if(rd.Fields[2].Value is DBNull)
                    {
                        itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, "Adresse couriel non assigée"));
                    }
                    else
                    {
                        if(rd.Fields[1].Value is DBNull)
                        {
                            itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"Courriel pour {rd.Fields[2].Value} inconnu"));
                        }
                        else
                        {
                            itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[1].Value}  [{rd.Fields[2].Value}]"));
                        }
                    }
                    itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields[0].Value}"));
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null,lvwDistList.FocusedItem.Text));
                    rd.MoveNext();
                }
                rd.Close();
                rd = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DistList", "cmdAfficher_Click", ex);
            }
        }
        private void cmdCreerListe_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new AjoutDL();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DistList", "cmdCreerListe_Click", ex);
            }
        }
        private void cmdRafraichir_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                RemplirListViewDistList();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DistList", "cmdRafraichir_Click", ex);
            }
        }
        private void DistList_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            lvwDistList.Items.Clear();
            lvwDistList.Items.Add("(Toutes les listes)");
            lvwDistList.Items.Add("Contacts GRB");
            lvwDistList.Items.Add("Clients GRB");
            lvwDistList.Items.Add("Fournisseurs GRB");
            lvwDistList.Items.Add("Chefs d'entreprise");
            lvwDistList.Items.Add("Transformation de viande");
          // RemplirListViewDistList();
        }
        private void lvwContacts_ColumnClick(object eventSender, ColumnClickEventArgs eventArgs)
        {
            var ColumnHeader = lvwContacts.Columns[eventArgs.Column];
            try
            {
                lvwContacts.Sorting = SortOrder.None;
                lvwContacts.Sorting.GetHashCode();
                if (lvwContacts.Sorting == SortOrder.Ascending)
                {
                    lvwContacts.Sorting = SortOrder.Descending;
                }
                else
                {
                    lvwContacts.Sorting = SortOrder.Ascending;
                }
                lvwContacts.Sort();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DistList", "lvwContacts_ColumnClick", ex);
            }
        }
  
        private void AjouterException(string sAdresse)
        {
            try
            {
                ADODB.Recordset rstExceptions;
                rstExceptions = new Recordset();
                rstExceptions.Open("SELECT * FROM ExceptionsDL WHERE [Exception] = '" + sAdresse.Replace( "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (rstExceptions.EOF)
                {
                    rstExceptions.AddNew();
                    rstExceptions.Fields["Exception"].Value = sAdresse;
                    rstExceptions.Update();
                }
                rstExceptions.Close();
                rstExceptions = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("DistList", "AjouterException", ex);
            }
        }
        private void lvwDistList_SelectedIndexChanged(object sender, EventArgs e) => cmdAfficher_Click(sender, e);
        private void lvwContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwContacts.SelectedItems[0].SubItems[1].Text != "")
            {
                if(MessageBox.Show("Voulez vous ajouter "+lvwContacts.SelectedItems[0].SubItems[1].Text+ " a la liste des exceptions?",
                    Application.ProductName + "." + Name + ".Exception.Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AjouterException(lvwContacts.SelectedItems[0].SubItems[1].Text);
                }
            }
            else
            {
                MessageBox.Show("Ce contact n'est pas conforme");
            }
        }
    }
}