using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class ChoixMailList : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixMailList() : base()
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
        internal static ColumnHeader _lvwDistList_ColumnHeader_1;
        internal static ColumnHeader _lvwDistList_ColumnHeader_2;
        internal static ColumnHeader _lvwDistList_ColumnHeader_3;
        internal static ListView lvwDistList;
        internal static Button cmdAnnuler;
        internal static Button cmdOK;
        internal static Label Label1;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            lvwDistList = new System.Windows.Forms.ListView();
            _lvwDistList_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lvwDistList_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            _lvwDistList_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdOK = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            SuspendLayout();//lvwDistList
            lvwDistList.BackColor = System.Drawing.Color.Black;
            lvwDistList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwDistList_ColumnHeader_1,
            _lvwDistList_ColumnHeader_2,
            _lvwDistList_ColumnHeader_3});
            lvwDistList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwDistList.FullRowSelect = true;
            lvwDistList.GridLines = true;
            lvwDistList.Location = new System.Drawing.Point(12, 92);
            lvwDistList.Name = "lvwDistList";
            lvwDistList.Size = new System.Drawing.Size(417, 159);
            lvwDistList.TabIndex = 3;
            lvwDistList.UseCompatibleStateImageBehavior = false;
            lvwDistList.View = System.Windows.Forms.View.Details;//_lvwDistList_ColumnHeader_1
            _lvwDistList_ColumnHeader_1.Text = "Liste";
            _lvwDistList_ColumnHeader_1.Width = 293;//_lvwDistList_ColumnHeader_2
            _lvwDistList_ColumnHeader_2.Text = "Nombre de contacts";
            _lvwDistList_ColumnHeader_2.Width = 191;//_lvwDistList_ColumnHeader_3
            _lvwDistList_ColumnHeader_3.Text = "Dossier";
            _lvwDistList_ColumnHeader_3.Width = 212;//cmdAnnuler
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(348, 289);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(81, 25);
            cmdAnnuler.TabIndex = 1;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);//cmdOK
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(261, 289);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(81, 25);
            cmdOK.TabIndex = 2;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);//Label1
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(4, 60);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(433, 33);
            Label1.TabIndex = 0;
            Label1.Text = "Dans quelle liste de distribution voulez-vous l\'ajouter ?";
            Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;//ChoixMailList
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(446, 324);
            ControlBox = false;
            Controls.Add(lvwDistList);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdOK);
            Controls.Add(Label1);
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(4, 23);
            Name = "ChoixMailList";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            Text = "Choix de la liste de distribution";
            Load += new System.EventHandler(ChoixMailList_Load);
            ResumeLayout(false);
        }
        #endregion
        private const int I_LVW_LISTE = 0;
        private const int I_LVW_NOMBRE = 1;
        private const int I_LVW_DOSSIER = 2;
        private object m_otlDistList;
        private Microsoft.Office.Interop.Outlook.Application otlApp;
        public ChoixMailList(Microsoft.Office.Interop.Outlook.Application otlApp)
        {
            otlApp = otlApp;
        }
        public void Afficher(Form Source, Microsoft.Office.Interop.Outlook.Application otlApp)
        {
            try
            {
                m_Source = Source;
                m_otlApp = otlApp;
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixMailList", "Afficher", ex);
            }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                // Control m_bAnnulerDistList a ete relocalise dans le module principal
                m_bAnnulerDistList = true;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixMailList", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.MAPIFolder folGRB;
                Microsoft.Office.Interop.Outlook.Items myItems;
                if (lvwDistList.Items.Count > 0)
                {
                    // Control m_bAnnulerDistList a ete relocalise dans le module principal
                    m_bAnnulerDistList = false;
                    
                    folGRB = GetFolder(m_otlApp, lvwDistList.FocusedItem.SubItems[I_LVW_DOSSIER].Text);
                    myItems = folGRB.Items.Restrict("[MessageClass] = 'IPM.DistList'");
                    foreach (var objItem in folGRB.Items)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(((dynamic)objItem).Class, Microsoft.Office.Interop.Outlook.OlObjectClass.olDistributionList, false)))
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(objItem, lvwDistList.FocusedItem.Text, false)))
                            {
                                m_otlDistList = objItem;
                                break;
                            }
                        }
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Il n'y a aucune liste de distribution!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixMailList", "cmdOK_Click", ex);
            }
        }
        private void ChoixMailList_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                Microsoft.Office.Interop.Outlook.MAPIFolder folGRB;
                Microsoft.Office.Interop.Outlook.Items myItems;
                object objItem;
                ListViewItem itmDL;
                folGRB = GetFolder(m_otlApp, "Contacts GRB");
                myItems = folGRB.Items.Restrict("[MessageClass] = 'IPM.DistList'");
                foreach (var currentObjItem in myItems)
                {
                    objItem = currentObjItem;
                    itmDL = lvwDistList.Items.Add(string.Empty);
                    itmDL.Text = (string)(objItem);
                    if (itmDL.SubItems.Count > I_LVW_NOMBRE)
                    {
                        itmDL.SubItems[I_LVW_NOMBRE].Text = (string)(((dynamic)objItem).MemberCount);
                    }
                    else
                    {
                        itmDL.SubItems.Insert(I_LVW_NOMBRE, new ListViewItem.ListViewSubItem((ListViewItem)null, (string)(((dynamic)objItem).MemberCount)));
                    }

                    if (itmDL.SubItems.Count > I_LVW_DOSSIER)
                    {
                        itmDL.SubItems[I_LVW_DOSSIER].Text = "Contacts GRB";
                    }
                    else
                    {
                        itmDL.SubItems.Insert(I_LVW_DOSSIER, new ListViewItem.ListViewSubItem(null, "Contacts GRB"));
                    }
                }
                folGRB = GetFolder(m_otlApp, "Clients GRB");
                myItems = folGRB.Items.Restrict("[MessageClass] = 'IPM.DistList'");
                foreach (var currentObjItem1 in myItems)
                {
                    objItem = currentObjItem1;
                    itmDL = lvwDistList.Items.Add(string.Empty);
                    itmDL.Text = (string)(objItem);
                    if (itmDL.SubItems.Count > I_LVW_NOMBRE)
                    {
                        itmDL.SubItems[I_LVW_NOMBRE].Text = (string)(((dynamic)objItem).MemberCount);
                    }
                    else
                    {
                        itmDL.SubItems.Insert(I_LVW_NOMBRE, new ListViewItem.ListViewSubItem((ListViewItem)null, (string)(((dynamic)objItem).MemberCount)));
                    }

                    if (itmDL.SubItems.Count > I_LVW_DOSSIER)
                    {
                        itmDL.SubItems[I_LVW_DOSSIER].Text = "Clients GRB";
                    }
                    else
                    {
                        itmDL.SubItems.Insert(I_LVW_DOSSIER, new ListViewItem.ListViewSubItem(null, "Clients GRB"));
                    }
                }
                folGRB = GetFolder(m_otlApp, "Fournisseurs GRB");
                myItems = folGRB.Items.Restrict("[MessageClass] = 'IPM.DistList'");
                foreach (var currentObjItem2 in myItems)
                {
                    objItem = currentObjItem2;
                    itmDL = lvwDistList.Items.Add(string.Empty);
                    itmDL.Text = (string)(objItem);
                    if (itmDL.SubItems.Count > I_LVW_NOMBRE)
                    {
                        itmDL.SubItems[I_LVW_NOMBRE].Text = (string)(((dynamic)objItem).MemberCount);
                    }
                    else
                    {
                        itmDL.SubItems.Insert(I_LVW_NOMBRE, new ListViewItem.ListViewSubItem((ListViewItem)null, (string)(((dynamic)objItem).MemberCount)));
                    }

                    if (itmDL.SubItems.Count > I_LVW_DOSSIER)
                    {
                        itmDL.SubItems[I_LVW_DOSSIER].Text = "Fournisseurs GRB";
                    }
                    else
                    {
                        itmDL.SubItems.Insert(I_LVW_DOSSIER, new ListViewItem.ListViewSubItem(null, "Fournisseurs GRB"));
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixMailList", "Form_Load", ex);
            }
        }
    }
}