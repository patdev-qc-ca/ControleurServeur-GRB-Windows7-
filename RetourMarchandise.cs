using System;
using System.Drawing;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ControleurServeur;
using ADODB;

using System.Diagnostics;
using System.Collections.Generic;

namespace ControleurServeur
{
    internal class RetourMarchandise : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public RetourMarchandise() : base() => InitializeComponent();
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
        internal TextBox txtDateRetour;
        internal Button cmdDate;
        internal Button cmdImprimer;
        internal Button cmdFermer;
        internal ComboBox cmbNoProjet;
        internal ColumnHeader _lvwProjet_ColumnHeader_1;
        internal ColumnHeader _lvwProjet_ColumnHeader_2;
        internal ColumnHeader _lvwProjet_ColumnHeader_3;
        internal ColumnHeader _lvwProjet_ColumnHeader_4;
        internal ColumnHeader _lvwProjet_ColumnHeader_5;
        internal ColumnHeader _lvwProjet_ColumnHeader_6;
        internal ColumnHeader _lvwProjet_ColumnHeader_7;
        internal ListView lvwProjet;
        internal TextBox txtNoProjet;
        private GroupBox groupBox1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel3;
        internal Label Label1;
        EnumCatalogue m_TypeProjet;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDateRetour = new System.Windows.Forms.TextBox();
            this.cmdDate = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.cmbNoProjet = new System.Windows.Forms.ComboBox();
            this.lvwProjet = new System.Windows.Forms.ListView();
            this._lvwProjet_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwProjet_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwProjet_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwProjet_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwProjet_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwProjet_ColumnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvwProjet_ColumnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNoProjet = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.mvwRetour = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDateRetour
            // 
            this.txtDateRetour.AcceptsReturn = true;
            this.txtDateRetour.BackColor = System.Drawing.Color.Black;
            this.txtDateRetour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateRetour.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateRetour.ForeColor = System.Drawing.Color.White;
            this.txtDateRetour.Location = new System.Drawing.Point(534, 38);
            this.txtDateRetour.MaxLength = 0;
            this.txtDateRetour.Name = "txtDateRetour";
            this.txtDateRetour.ReadOnly = true;
            this.txtDateRetour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateRetour.Size = new System.Drawing.Size(97, 22);
            this.txtDateRetour.TabIndex = 3;
            // 
            // cmdDate
            // 
            this.cmdDate.AutoSize = true;
            this.cmdDate.BackColor = System.Drawing.Color.Black;
            this.cmdDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDate.ForeColor = System.Drawing.Color.White;
            this.cmdDate.Location = new System.Drawing.Point(637, 34);
            this.cmdDate.Name = "cmdDate";
            this.cmdDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDate.Size = new System.Drawing.Size(27, 26);
            this.cmdDate.TabIndex = 5;
            this.cmdDate.Text = "..";
            this.cmdDate.UseVisualStyleBackColor = true;
            this.cmdDate.Click += new System.EventHandler(this.cmdDate_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.AutoSize = true;
            this.cmdImprimer.BackColor = System.Drawing.Color.Black;
            this.cmdImprimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdImprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdImprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimer.ForeColor = System.Drawing.Color.White;
            this.cmdImprimer.Location = new System.Drawing.Point(12, 555);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdImprimer.Size = new System.Drawing.Size(73, 26);
            this.cmdImprimer.TabIndex = 7;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // cmdFermer
            // 
            this.cmdFermer.AutoSize = true;
            this.cmdFermer.BackColor = System.Drawing.Color.Black;
            this.cmdFermer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermer.ForeColor = System.Drawing.Color.White;
            this.cmdFermer.Location = new System.Drawing.Point(828, 555);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFermer.Size = new System.Drawing.Size(81, 26);
            this.cmdFermer.TabIndex = 8;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.Cmdfermer_Click);
            // 
            // cmbNoProjet
            // 
            this.cmbNoProjet.BackColor = System.Drawing.Color.Black;
            this.cmbNoProjet.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNoProjet.ForeColor = System.Drawing.Color.White;
            this.cmbNoProjet.Location = new System.Drawing.Point(85, 59);
            this.cmbNoProjet.Name = "cmbNoProjet";
            this.cmbNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbNoProjet.Size = new System.Drawing.Size(145, 22);
            this.cmbNoProjet.Sorted = true;
            this.cmbNoProjet.TabIndex = 1;
            this.cmbNoProjet.SelectedIndexChanged += new System.EventHandler(this.cmbNoProjet_SelectedIndexChanged);
            // 
            // lvwProjet
            // 
            this.lvwProjet.BackColor = System.Drawing.Color.Black;
            this.lvwProjet.CheckBoxes = true;
            this.lvwProjet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvwProjet_ColumnHeader_1,
            this._lvwProjet_ColumnHeader_2,
            this._lvwProjet_ColumnHeader_3,
            this._lvwProjet_ColumnHeader_4,
            this._lvwProjet_ColumnHeader_5,
            this._lvwProjet_ColumnHeader_6,
            this._lvwProjet_ColumnHeader_7});
            this.lvwProjet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwProjet.ForeColor = System.Drawing.Color.White;
            this.lvwProjet.FullRowSelect = true;
            this.lvwProjet.GridLines = true;
            this.lvwProjet.HideSelection = false;
            this.lvwProjet.Location = new System.Drawing.Point(12, 128);
            this.lvwProjet.Name = "lvwProjet";
            this.lvwProjet.Size = new System.Drawing.Size(897, 421);
            this.lvwProjet.TabIndex = 6;
            this.lvwProjet.UseCompatibleStateImageBehavior = false;
            this.lvwProjet.View = System.Windows.Forms.View.Details;
            this.lvwProjet.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvwProjet_ItemCheck);
            // 
            // _lvwProjet_ColumnHeader_1
            // 
            this._lvwProjet_ColumnHeader_1.Text = "Qté";
            this._lvwProjet_ColumnHeader_1.Width = 77;
            // 
            // _lvwProjet_ColumnHeader_2
            // 
            this._lvwProjet_ColumnHeader_2.Text = "No. Item";
            this._lvwProjet_ColumnHeader_2.Width = 216;
            // 
            // _lvwProjet_ColumnHeader_3
            // 
            this._lvwProjet_ColumnHeader_3.Text = "Description";
            this._lvwProjet_ColumnHeader_3.Width = 448;
            // 
            // _lvwProjet_ColumnHeader_4
            // 
            this._lvwProjet_ColumnHeader_4.Text = "Manufacturier";
            this._lvwProjet_ColumnHeader_4.Width = 136;
            // 
            // _lvwProjet_ColumnHeader_5
            // 
            this._lvwProjet_ColumnHeader_5.Text = "Distributeur";
            this._lvwProjet_ColumnHeader_5.Width = 119;
            // 
            // _lvwProjet_ColumnHeader_6
            // 
            this._lvwProjet_ColumnHeader_6.Text = "No. Retour";
            this._lvwProjet_ColumnHeader_6.Width = 170;
            // 
            // _lvwProjet_ColumnHeader_7
            // 
            this._lvwProjet_ColumnHeader_7.Text = "Date";
            this._lvwProjet_ColumnHeader_7.Width = 170;
            // 
            // txtNoProjet
            // 
            this.txtNoProjet.AcceptsReturn = true;
            this.txtNoProjet.BackColor = System.Drawing.Color.Black;
            this.txtNoProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoProjet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoProjet.Location = new System.Drawing.Point(85, 59);
            this.txtNoProjet.MaxLength = 0;
            this.txtNoProjet.Name = "txtNoProjet";
            this.txtNoProjet.ReadOnly = true;
            this.txtNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoProjet.Size = new System.Drawing.Size(145, 22);
            this.txtNoProjet.TabIndex = 0;
            this.txtNoProjet.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(450, 40);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(85, 14);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Date de retour :";
            // 
            // mvwRetour
            // 
            this.mvwRetour.Location = new System.Drawing.Point(453, 64);
            this.mvwRetour.Name = "mvwRetour";
            this.mvwRetour.Size = new System.Drawing.Size(160, 22);
            this.mvwRetour.TabIndex = 9;
            this.mvwRetour.Visible = false;
            this.mvwRetour.ValueChanged += new System.EventHandler(this.mvwRetour_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 10;
            this.label2.Tag = "";
            this.label2.Text = " #Projet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.mvwRetour);
            this.groupBox1.Controls.Add(this.txtDateRetour);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdDate);
            this.groupBox1.Controls.Add(this.cmbNoProjet);
            this.groupBox1.Controls.Add(this.txtNoProjet);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(225, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 101);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de retour";
            // 
            // linkLabel3
            // 
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel3.Location = new System.Drawing.Point(178, 31);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(104, 14);
            this.linkLabel3.TabIndex = 11;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Projet mécanique";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel2.Location = new System.Drawing.Point(73, 31);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(99, 14);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Projet électrique";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(31, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 14);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Achat";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RetourMarchandise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(928, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.lvwProjet);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(3, 22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RetourMarchandise";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.RetourMarchandise";
            this.Load += new System.EventHandler(this.RetourMarchandise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private DateTimePicker mvwRetour;
        private Label label2;
        BonCommande bon = new BonCommande();

        private const int I_COL_SOUM_QUANTITE = 0;
        private const int I_COL_SOUM_PIECE = 1;
        private const int I_COL_SOUM_DESCR = 2;
        private const int I_COL_SOUM_MANUFACT = 3;
        private const int I_COL_SOUM_DISTRIB = 4;
        private const int I_COL_SOUM_NO_RETOUR = 5;
        private const int I_COL_SOUM_DATE = 6;
        private enum enumTypeRetour { PROJET = 0, ACHAT = 1 }
        private string m_sUserID;
        // Pour l'impression
        public static bool m_bAnnuleImpression;
        internal static ChoixImpressionRetourMarchandise.enumImpressionRetour m_eTypeImpression;
        ChoixQteBoite cb = new ChoixQteBoite();
        ChoixLocalisation cl = new ChoixLocalisation();
        private enumTypeRetour m_eTypeRetour;
        private dynamic g_bQteBoite;
        private dynamic g_sQteBoite;
        private EnumCatalogue eLECTRIQUE;
        private string sIDAchat;
        private int iIndexAchat;
        private string idLoginEmploye;
        public RetourMarchandise(EnumCatalogue eLECTRIQUE) => eLECTRIQUE = eLECTRIQUE;
        public RetourMarchandise(string sIDAchat, int iIndexAchat, string idLoginEmploye)
        {
            sIDAchat = sIDAchat;
            iIndexAchat = iIndexAchat;
            idLoginEmploye = idLoginEmploye;
        }
        public void Afficher(string sNoProjet, string sUserID)
        {
            try
            {
                m_eTypeRetour = enumTypeRetour.PROJET;
                m_sUserID = sUserID;
                RemplirComboProjetElec();
                RemplirComboProjetMec();
                NouveauRetour(sNoProjet);
                ShowDialog();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "Afficher", ex);
            }
        }
        private void RemplirComboProjets()
        {
            try
            {
                ADODB.Recordset rstEmploye;
                rstEmploye = new Recordset();
                rstEmploye.Open("select distinct [IDProjet] from [dbo].[Projet_Pieces]order by IDProjet asc\r\n", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstEmploye.EOF)
                {
                    cmbNoProjet.Items.Add(rstEmploye.Fields[0].Value);
                    rstEmploye.MoveNext();
                }
                rstEmploye.Close();
                rstEmploye = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMateriel", "RemplirComboProjets", ex);
            }
        }
        public void AfficherAchat(string sNoAchat, int iIndexAchat, string sUserID)
        {
            try
            {
                m_eTypeRetour = enumTypeRetour.ACHAT;
                m_sUserID = sUserID;
                RemplirComboAchats();
                NouveauRetourAchat(sNoAchat, iIndexAchat);
                ShowDialog();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "AfficherAchat", ex);
            }
        }

        private void cmbNoProjet_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                txtNoProjet.Text = cmbNoProjet.Text;
                if (m_eTypeRetour == enumTypeRetour.ACHAT)
                {

                    RemplirListViewAchat();
                }
                else
                {

                    RemplirListViewProjet();
                }
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "cmbNoProjet_Click", ex);
            }
        }
        [Obsolete]
        private void cmdImprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                var bChecked = default(bool);
                ADODB.Recordset rstProjet;
                bool bRetourPermis;
                if (cmbNoProjet.SelectedIndex > -1)
                {
                    rstProjet = new Recordset();
                    if (m_eTypeRetour == enumTypeRetour.PROJET)
                    {
                        if (cmbNoProjet.SelectedIndex == 0)
                        {
                            rstProjet.Open("SELECT Modification, Par FROM ProjetElec WHERE IDProjet = '" + Droite(txtNoProjet.Text, txtNoProjet.Text.Length - 1) + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        else
                        {
                            rstProjet.Open("SELECT Modification, Par FROM ProjetMec WHERE IDProjet = '" + Droite(txtNoProjet.Text, txtNoProjet.Text.Length - 1) + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        }
                        if (rstProjet.Fields["Modification"].Value==true)
                        {
                            bRetourPermis = true;
                        }
                        else
                        {
                            bRetourPermis = false;
                        }
                        rstProjet.Close();
                        rstProjet = null;
                    }
                    else
                    {
                        bRetourPermis = true;
                    }
                    if (bRetourPermis == true)
                    {
                        var loopTo = (int)lvwProjet.Items.Count;
                        for (X = 1; X <= loopTo; X++)
                        {
                            if (lvwProjet.Items[X].Checked == true)
                            {
                                bChecked = true;
                                break;
                            }
                        }
                        if (bChecked == true)
                        {
                            Form f = new ChoixImpressionRetourMarchandise();
                            f.MdiParent = Conteneur.ActiveForm.MdiParent;
                            f.ShowDialog();
                            if (m_bAnnuleImpression == false)
                            {
                                if (m_eTypeImpression == ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_DEMANDE_RETOUR)
                                {
                                    ImprimerDemandeRetour();
                                }
                                else
                                {
                                    ImprimerRetour();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Ce projet est en modification par {rstProjet.Fields["Par"].Value}!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez choisir un numéro de retour!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "cmdImprimer_Click", ex);
            }
        }
        private void ImprimerRetour()
        {
            try
            {
               List<String> collPiece;
               List<String> collNoLigne;
                int X;
                string sNoBC;
                sNoBC = Interaction.InputBox("Quel est le numéro du retour?", DefaultResponse: txtNoProjet.Text);
                if (!string.IsNullOrEmpty(sNoBC))
                {
                    collPiece = new List<String>();
                    collNoLigne = new List<String>();
                    var loopTo = (int)lvwProjet.Items.Count;
                    for (X = 1; X <= loopTo; X++)
                    {
                        if (lvwProjet.Items[X].Checked == true)
                        {
                            collPiece.Add(lvwProjet.Items[X].SubItems[I_COL_SOUM_PIECE].Text);
                            collNoLigne.Add(lvwProjet.Items[X].Tag.ToString());
                        }
                    }
                    if (m_eTypeRetour == enumTypeRetour.ACHAT)
                    {
                        bon.AfficherFormRetourMarchandiseAchat(Strings.Replace(Strings.Trim(Gauche(txtNoProjet.Text, Strings.InStrRev(txtNoProjet.Text, "-") - 1)), "R", ""), int.Parse(Droite(txtNoProjet.Text, 3)), sNoBC, collPiece, collNoLigne, m_sUserID, ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_RETOUR);
                    }
                    else
                    {
                        bon.AfficherFormRetourMarchandiseProjet(txtNoProjet.Text, sNoBC, collPiece, collNoLigne, m_sUserID, ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_RETOUR);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "ImprimerRetour", ex);
            }
        }
        private void ImprimerDemandeRetour()
        {
            try
            {
               List<String> collPiece;
               List<String> collNoLigne;
                int X;
                string sNoBC;
                sNoBC = Interaction.InputBox("Quel est le numéro de la demande de retour?", DefaultResponse: txtNoProjet.Text);
                if (!string.IsNullOrEmpty(sNoBC))
                {
                    collPiece = new List<String>();
                    collNoLigne = new List<String>();
                    for (X = 1; X <= lvwProjet.Items.Count; X++)
                    {
                        if (lvwProjet.Items[X].Checked == true)
                        {
                            collPiece.Add(lvwProjet.Items[X].SubItems[I_COL_SOUM_PIECE].Text);
                            collNoLigne.Add(lvwProjet.Items[X].Tag.ToString());
                        }
                    }
                    if (m_eTypeRetour == enumTypeRetour.ACHAT)
                    {
                        bon.AfficherFormRetourMarchandiseAchat(Gauche(txtNoProjet.Text, Strings.InStrRev(txtNoProjet.Text, "-") - 1).Replace("R", "").Trim(), int.Parse(Droite(txtNoProjet.Text, 3)), sNoBC, collPiece, collNoLigne, m_sUserID, ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_DEMANDE_RETOUR);
                    }
                    else
                    {
                        bon.AfficherFormRetourMarchandiseProjet(txtNoProjet.Text, sNoBC, collPiece, collNoLigne, m_sUserID, ChoixImpressionRetourMarchandise.enumImpressionRetour.MODE_DEMANDE_RETOUR);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "ImprimerDemandeRetour", ex);
            }
        }
        [Obsolete]
        private void NouveauRetour(string sNoProjet)
        {
            try
            {
                ADODB.Recordset rstProjet;
                int X;
                bool bExiste;
                var eType = default(EnumCatalogue);
                bExiste = false;
                if (ComboContient(cmbNoProjet, "R" + sNoProjet) == false)
                {
                    rstProjet = new Recordset();
                    rstProjet.Open("SELECT * FROM ProjetElec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstProjet.EOF)
                    {
                        bExiste = true;
                        eType = EnumCatalogue.ELECTRIQUE;
                    }
                    rstProjet.Close();
                    if (bExiste == false)
                    {
                        rstProjet.Open("SELECT * FROM ProjetMec WHERE IDProjet = '" + sNoProjet + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstProjet.EOF)
                        {
                            bExiste = true;
                            eType = EnumCatalogue.MECANIQUE;
                        }
                        rstProjet.Close();
                    }
                    if (bExiste == true)
                    {
                        cmbNoProjet.Items.Add("R" + sNoProjet);
                        cmbNoProjet.Tag = eType;
                        cmbNoProjet.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Projet inexistant!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    rstProjet = null;
                }
                for (X = 0; X <= (int)(cmbNoProjet.Items.Count - 1); X++)
                {
                    if (cmbNoProjet.Items[X].ToString() != "R" + sNoProjet)
                    {
                        cmbNoProjet.SelectedIndex = X;
                        return;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "NouveauRetour", ex);
            }
        }
        [Obsolete]
        private void NouveauRetourAchat(string sNoAchat, int iIndexAchat)
        {
            try
            {
                ADODB.Recordset rstAchat;
                int X;
                bool bExiste;
                var eType = default(EnumCatalogue);
                bExiste = false;
                if (ComboContient(cmbNoProjet, "R" + sNoAchat + "-" + Droite("000" + iIndexAchat, 3)) == false)
                {
                    rstAchat = new Recordset();
                    rstAchat.Open("SELECT * FROM Achat WHERE IDAchat = '" + sNoAchat + "' AND IndexAchat = " + iIndexAchat, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (!rstAchat.EOF)
                    {
                        bExiste = true;
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstAchat.Fields["Type"].Value, "M", false)))
                        {
                            eType = EnumCatalogue.MECANIQUE;
                        }
                        else
                        {
                            eType = EnumCatalogue.ELECTRIQUE;
                        }
                    }
                    rstAchat.Close();
                    rstAchat = null;
                    if (bExiste == true)
                    {
                        cmbNoProjet.Items.Add("R" + sNoAchat + "-" + Droite("000" + iIndexAchat, 3));
                        cmbNoProjet.Tag = eType;
                    }
                    else
                    {
                        MessageBox.Show("Projet inexistant!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                for (X = 0; X <= (int)(cmbNoProjet.Items.Count - 1); X++)
                {
                    if (cmbNoProjet.Items[X].ToString() != "R" + sNoAchat + "-" + Droite("000" + iIndexAchat, 3))
                    {
                        cmbNoProjet.SelectedIndex = X;
                        break;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "NouveauRetourAchat", ex);
            }
        }
        private void Cmdfermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "cmdFermer_Click", ex);
            }
        }
        private void RemplirComboProjetElec()
        {
            try
            {
                cmbNoProjet.Items.Clear();
                ADODB.Recordset rstProjet;
                rstProjet = new Recordset();

                rstProjet.Open("SELECT DISTINCT ProjetElec.IDProjet FROM ProjetElec " +
                    "INNER JOIN Projet_Pieces ON ProjetElec.IDProjet = Projet_Pieces.IDProjet " +
                    "WHERE Retour = 1 " +
                    "ORDER BY ProjetElec.IDProjet", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                while (!rstProjet.EOF)
                {
                    cmbNoProjet.Items.Add($"R{rstProjet.Fields["IDProjet"].Value}");
                    cmbNoProjet.Tag = 0;
                    rstProjet.MoveNext();
                }
                rstProjet.Close();
                rstProjet = null;
                if (cmbNoProjet.Items.Count > 0) cmbNoProjet.SelectedIndex = 0;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "RemplirComboProjetElec", ex);
            }
        }
        private void RemplirComboProjetMec()
        {
            try
            {
                cmbNoProjet.Items.Clear();
                ADODB.Recordset rstProjet;
                rstProjet = new Recordset();

                rstProjet.Open("SELECT DISTINCT ProjetMec.IDProjet FROM ProjetMec " +
                    "INNER JOIN Projet_Pieces ON ProjetMec.IDProjet = Projet_Pieces.IDProjet " +
                    "WHERE Retour = 1  " +
                    "ORDER BY ProjetMec.IDProjet", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                while (!rstProjet.EOF)
                {
                    cmbNoProjet.Items.Add($"R{rstProjet.Fields["IDProjet"].Value}");
                    cmbNoProjet.Tag = 1;
                    rstProjet.MoveNext();
                }
                rstProjet.Close();
                rstProjet = null;
                if (cmbNoProjet.Items.Count > 0) cmbNoProjet.SelectedIndex = 0;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "RemplirComboProjetMec", ex);
            }
        }
        private void RemplirComboAchats()
        {
            try
            {
                cmbNoProjet.Items.Clear();
                ADODB.Recordset rstAchat = new Recordset();
                rstAchat.Open("SELECT DISTINCT ACHAT.IDAchat, ACHAT.IndexAchat, ACHAT.Type FROM Achat " +
                    "INNER JOIN Achat_Pieces ON Achat.IDAchat = Achat_Pieces.IDAchat AND Achat.IndexAchat = Achat_Pieces.IndexAchat " +
                    "WHERE Achat_Pieces.Retour = 1 " +
                    "ORDER BY Achat.IDAchat, Achat.IndexAchat", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);

                while (!rstAchat.EOF)
                {
                    cmbNoProjet.Items.Add($"R{rstAchat.Fields["IDAchat"].Value}-{ Droite($"000{rstAchat.Fields["IndexAchat"].Value}", 3)}");
                    if (rstAchat.Fields["Type"].Value== "E")
                    {
                        cmbNoProjet.Tag = 0;
                    }
                    else
                    {
                        cmbNoProjet.Tag = 1;
                    }
                    rstAchat.MoveNext();
                }
                rstAchat.Close();
                rstAchat = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "RemplirComboAchats", ex);
            }
        }
        private void RemplirListViewProjet()
        {
            try
            {

                ADODB.Recordset rstProjet;
                ADODB.Recordset rstFRS;
                ListViewItem itmProjet;
                Color lColor;
                if (cmbNoProjet.SelectedIndex != -1)
                {
                    lvwProjet.Items.Clear();
                    rstProjet = new Recordset();
                    rstFRS = new Recordset();
                    rstProjet.Open("SELECT * FROM Projet_Pieces" +
                        " WHERE IDProjet = '" + Droite(txtNoProjet.Text, txtNoProjet.Text.Length - 1) + "' AND Left(Qté,1) = '-' " +
                        "ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    Clipboard.SetText(rstProjet.Source);
                    while (!rstProjet.EOF)
                    {

                        itmProjet = lvwProjet.Items.Add(string.Empty);
                        itmProjet.Checked = false;
                        if (rstProjet.Fields["Retour"].Value ==true){lColor = COLOR_ROUGE;}
						else if (rstProjet.Fields["Commandé"].Value ==true){lColor = COLOR_ORANGE;}
						else if (rstProjet.Fields["Recu"].Value ==true){lColor = COLOR_GRIS;}
						else if (rstProjet.Fields["MatérielInutile"].Value ==true){lColor = COLOR_BRUN;}
						else{lColor = COLOR_BLANC;}
                        itmProjet.Tag = rstProjet.Fields["NuméroLigne"].Value;
                        if (!(rstProjet.Fields["Qté"].Value is DBNull)){itmProjet.Text = (string)(rstProjet.Fields["Qté"].Value);}else{itmProjet.Text = string.Empty;}
                        itmProjet.ForeColor = lColor;
                        if (!(rstProjet.Fields["NumItem"].Value is DBNull))
                        {
                            if (itmProjet.SubItems.Count > I_COL_SOUM_PIECE)
                            {
                                itmProjet.SubItems[I_COL_SOUM_PIECE].Text = (string)(rstProjet.Fields["NumItem"].Value);
                            }
                            else
                            {
                                itmProjet.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["NumItem"].Value)));
                            }
                        }
                        else if (itmProjet.SubItems.Count > I_COL_SOUM_PIECE){itmProjet.SubItems[I_COL_SOUM_PIECE].Text = string.Empty;}
                        else{itmProjet.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty));}
                        itmProjet.SubItems[I_COL_SOUM_PIECE].ForeColor = lColor;
                        itmProjet.SubItems[I_COL_SOUM_PIECE].Tag = rstProjet.Fields["SousSection"].Value;

                        if (!(rstProjet.Fields["Desc_FR"].Value is DBNull))
                        { 
                            if (itmProjet.SubItems.Count > I_COL_SOUM_DESCR) { itmProjet.SubItems[I_COL_SOUM_DESCR].Text = (string)(rstProjet.Fields["Desc_FR"].Value); 
                            } else { 
                                itmProjet.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["Desc_FR"].Value))); 
                            }
                        }
                        else if (itmProjet.SubItems.Count > I_COL_SOUM_DESCR) { itmProjet.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; }
                        else { itmProjet.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmProjet.SubItems[I_COL_SOUM_DESCR].ForeColor = lColor;
                        if (!(rstProjet.Fields["DESC_EN"].Value is DBNull)) { itmProjet.SubItems[I_COL_SOUM_DESCR].Tag = rstProjet.Fields["Desc_EN"].Value; }
                        else { itmProjet.SubItems[I_COL_SOUM_DESCR].Tag = string.Empty; }
                        if (!(rstProjet.Fields["Manufact"].Value is DBNull)) { if (itmProjet.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjet.SubItems[I_COL_SOUM_MANUFACT].Text = (string)(rstProjet.Fields["Manufact"].Value); } else { itmProjet.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["Manufact"].Value))); } }
                        else if (itmProjet.SubItems.Count > I_COL_SOUM_MANUFACT) { itmProjet.SubItems[I_COL_SOUM_MANUFACT].Text = string.Empty; }
                        else { itmProjet.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmProjet.SubItems[I_COL_SOUM_MANUFACT].ForeColor = lColor;
                        if (!(rstProjet.Fields["IDFRS"].Value is DBNull) & (rstProjet.Fields["IDFRS"].Value > 0))
                        {
                            if (itmProjet.SubItems[I_COL_SOUM_PIECE].Text != "Texte")
                            {
                                rstFRS.Open(Operators.ConcatenateObject("SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = ", rstProjet.Fields["IDFRS"].Value), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (itmProjet.SubItems.Count > I_COL_SOUM_DISTRIB) { itmProjet.SubItems[I_COL_SOUM_DISTRIB].Text = (string)(rstFRS.Fields["NomFournisseur"].Value); } else { itmProjet.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, (string)(rstFRS.Fields["NomFournisseur"].Value))); }
                                itmProjet.SubItems[I_COL_SOUM_DISTRIB].ForeColor = lColor;
                                itmProjet.SubItems[I_COL_SOUM_DISTRIB].Tag = rstProjet.Fields["IDFRS"].Value; rstFRS.Close();
                            }
                        }
                        else if (itmProjet.SubItems.Count > I_COL_SOUM_DISTRIB) { itmProjet.SubItems[I_COL_SOUM_DISTRIB].Text = string.Empty; }
                        else { itmProjet.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        if (!(rstProjet.Fields["NoRetour"].Value is DBNull))
                        { if (itmProjet.SubItems.Count > I_COL_SOUM_NO_RETOUR) { itmProjet.SubItems[I_COL_SOUM_NO_RETOUR].Text = (string)(rstProjet.Fields["NoRetour"].Value); } else { itmProjet.SubItems.Insert(I_COL_SOUM_NO_RETOUR, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["NoRetour"].Value))); } }
                        else if (itmProjet.SubItems.Count > I_COL_SOUM_NO_RETOUR)
                        { itmProjet.SubItems[I_COL_SOUM_NO_RETOUR].Text = string.Empty; }
                        else { itmProjet.SubItems.Insert(I_COL_SOUM_NO_RETOUR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmProjet.SubItems[I_COL_SOUM_NO_RETOUR].ForeColor = lColor;
                        if (!(rstProjet.Fields["DateRetour"].Value is DBNull))
                        { if (itmProjet.SubItems.Count > I_COL_SOUM_DATE) { itmProjet.SubItems[I_COL_SOUM_DATE].Text = (string)(rstProjet.Fields["DateRetour"].Value); } else { itmProjet.SubItems.Insert(I_COL_SOUM_DATE, new ListViewItem.ListViewSubItem(null, (string)(rstProjet.Fields["DateRetour"].Value))); } }
                        else if (itmProjet.SubItems.Count > I_COL_SOUM_DATE)
                        { itmProjet.SubItems[I_COL_SOUM_DATE].Text = string.Empty; }
                        else { itmProjet.SubItems.Insert(I_COL_SOUM_DATE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmProjet.SubItems[I_COL_SOUM_DATE].ForeColor = lColor;
                        rstProjet.MoveNext();
                    }
                    rstProjet.Close();
                    rstProjet = null;
                    rstFRS = null;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "RemplirListViewProjet", ex);
            }
        }
        private void RemplirListViewAchat()
        {
            try
            {

                ADODB.Recordset rstAchat;
                ADODB.Recordset rstFRS;
                ListViewItem itmAchat;
                var lColor = default(Color);
                if (cmbNoProjet.SelectedIndex != -1)
                {
                    lvwProjet.Items.Clear();
                    rstAchat = new Recordset();
                    rstFRS = new Recordset();
                    rstAchat.Open("SELECT * FROM Achat_Pieces WHERE IDAchat = '" + Strings.Replace(Strings.Trim(Gauche(txtNoProjet.Text, Strings.InStrRev(txtNoProjet.Text, "-") - 1)), "R", "") + "' AND IndexAchat = " + int.Parse(Droite(txtNoProjet.Text, 3)) + " AND Left(Qté,1) = '-' ORDER BY NuméroLigne", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstAchat.EOF)
                    {

                        itmAchat = lvwProjet.Items.Add(string.Empty);
                        itmAchat.Checked = false;
                        if ((bool)rstAchat.Fields["Retour"].Value== true) { lColor = COLOR_ROUGE; }
                        else if ((bool)rstAchat.Fields["Commandé"].Value== true) { lColor = COLOR_ORANGE; }
                        itmAchat.Tag = rstAchat.Fields["NuméroLigne"].Value; 
                        if (!(rstAchat.Fields["Qté"].Value is DBNull)) { itmAchat.Text = (string)(rstAchat.Fields["Qté"].Value); }
                        else { itmAchat.Text = string.Empty; }
                        itmAchat.ForeColor = lColor;
                        if (!(rstAchat.Fields["PIECE"].Value is DBNull))
                        {
                            if (itmAchat.SubItems.Count > I_COL_SOUM_PIECE) { itmAchat.SubItems[I_COL_SOUM_PIECE].Text = (string)(rstAchat.Fields["PIECE"].Value); } 
                            else { itmAchat.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, (string)(rstAchat.Fields["PIECE"].Value))); }
                        }
                        else if (itmAchat.SubItems.Count > I_COL_SOUM_PIECE) { itmAchat.SubItems[I_COL_SOUM_PIECE].Text = string.Empty; }
                        else { itmAchat.SubItems.Insert(I_COL_SOUM_PIECE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmAchat.SubItems[I_COL_SOUM_PIECE].ForeColor = lColor; if (!(rstAchat.Fields["DESC_FR"].Value is DBNull))
                        {
                            if (itmAchat.SubItems.Count > I_COL_SOUM_DESCR) { itmAchat.SubItems[I_COL_SOUM_DESCR].Text = (string)(rstAchat.Fields["DESC_FR"].Value); } 
                            else { itmAchat.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, (string)(rstAchat.Fields["DESC_FR"].Value))); }
                        }
                        else if (itmAchat.SubItems.Count > I_COL_SOUM_DESCR) { itmAchat.SubItems[I_COL_SOUM_DESCR].Text = string.Empty; }
                        else { itmAchat.SubItems.Insert(I_COL_SOUM_DESCR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmAchat.SubItems[I_COL_SOUM_DESCR].ForeColor = lColor; if (!(rstAchat.Fields["DESC_EN"].Value is DBNull)) { itmAchat.SubItems[I_COL_SOUM_DESCR].Tag = rstAchat.Fields["DESC_EN"].Value; }
                        else { itmAchat.SubItems[I_COL_SOUM_DESCR].Tag = string.Empty; }
                        if (!(rstAchat.Fields["Manufact"].Value is DBNull))
                        {
                            if (itmAchat.SubItems.Count > I_COL_SOUM_MANUFACT) { itmAchat.SubItems[I_COL_SOUM_MANUFACT].Text = (string)(rstAchat.Fields["Manufact"].Value); } 
                            else { itmAchat.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, (string)(rstAchat.Fields["Manufact"].Value))); }
                        }
                        else if (itmAchat.SubItems.Count > I_COL_SOUM_MANUFACT) { itmAchat.SubItems[I_COL_SOUM_MANUFACT].Text = string.Empty; }
                        else { itmAchat.SubItems.Insert(I_COL_SOUM_MANUFACT, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmAchat.SubItems[I_COL_SOUM_MANUFACT].ForeColor = lColor;
                        if (Conversions.ToBoolean(Operators.AndObject(!(rstAchat.Fields["IDFRS"].Value is DBNull), Operators.ConditionalCompareObjectGreater(rstAchat.Fields["IDFRS"].Value, 0, false))))
                        {
                            rstFRS.Open($"SELECT NomFournisseur FROM Fournisseur WHERE IDFRS = {rstAchat.Fields["IDFRS"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (itmAchat.SubItems.Count > I_COL_SOUM_DISTRIB) { itmAchat.SubItems[I_COL_SOUM_DISTRIB].Text = (string)(rstFRS.Fields["NomFournisseur"].Value); } 
                            else { itmAchat.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, (string)(rstFRS.Fields["NomFournisseur"].Value))); }
                            itmAchat.SubItems[I_COL_SOUM_DISTRIB].ForeColor = lColor;
                            itmAchat.SubItems[I_COL_SOUM_DISTRIB].Tag = rstAchat.Fields["IDFRS"].Value;
                            rstFRS.Close();
                        }
                        else if (itmAchat.SubItems.Count > I_COL_SOUM_DISTRIB) { itmAchat.SubItems[I_COL_SOUM_DISTRIB].Text = string.Empty; }
                        else { itmAchat.SubItems.Insert(I_COL_SOUM_DISTRIB, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        if (!(rstAchat.Fields["NoRetour"].Value is DBNull))
                        {
                            if (itmAchat.SubItems.Count > I_COL_SOUM_NO_RETOUR) { itmAchat.SubItems[I_COL_SOUM_NO_RETOUR].Text = (string)(rstAchat.Fields["NoRetour"].Value); } else { itmAchat.SubItems.Insert(I_COL_SOUM_NO_RETOUR, new ListViewItem.ListViewSubItem(null, (string)(rstAchat.Fields["NoRetour"].Value))); }
                        }
                        else if (itmAchat.SubItems.Count > I_COL_SOUM_NO_RETOUR) { itmAchat.SubItems[I_COL_SOUM_NO_RETOUR].Text = string.Empty; }
                        else { itmAchat.SubItems.Insert(I_COL_SOUM_NO_RETOUR, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmAchat.SubItems[I_COL_SOUM_NO_RETOUR].ForeColor = lColor;
                        if (!(rstAchat.Fields["DateRetour"].Value is DBNull))
                        {
                            if (itmAchat.SubItems.Count > I_COL_SOUM_DATE) { itmAchat.SubItems[I_COL_SOUM_DATE].Text = (string)(rstAchat.Fields["DateRetour"].Value); } else { itmAchat.SubItems.Insert(I_COL_SOUM_DATE, new ListViewItem.ListViewSubItem(null, (string)(rstAchat.Fields["DateRetour"].Value))); }
                        }
                        else if (itmAchat.SubItems.Count > I_COL_SOUM_DATE) { itmAchat.SubItems[I_COL_SOUM_DATE].Text = string.Empty; }
                        else { itmAchat.SubItems.Insert(I_COL_SOUM_DATE, new ListViewItem.ListViewSubItem(null, string.Empty)); }
                        itmAchat.SubItems[I_COL_SOUM_DATE].ForeColor = lColor;
                        rstAchat.MoveNext();
                    }
                    rstAchat.Close();
                    rstAchat = null;
                    rstFRS = null;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "RemplirListViewAchat", ex);
            }
        }
        [Obsolete]
        public void Retour()
        {
            try
            {
                ADODB.Recordset rstBC = new ADODB.Recordset();
                ADODB.Recordset rstBCPiece = new ADODB.Recordset();
                ADODB.Recordset rstPiece = new ADODB.Recordset();
                ADODB.Recordset rstModif;
                ADODB.Recordset rstInventaire;
                ADODB.Recordset rstInvModif;
                ADODB.Recordset rstEmploye;
                string sWhere;
                string sWherePiece;
                string sWhereNoLigne;
                bool bPremier;
                bool bPremierNoLigne;
                bool bRetourFait;
                string sPiece;
                string sNoLigne;
                string sNoRetour;

                sNoRetour = ViewCommande.lblNoSoum.Text;
                rstBC.Open("SELECT * FROM BonsCommandes WHERE NoBonCommande = '" + sNoRetour + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstBCPiece.Open("SELECT NoItem, NuméroLigne FROM BonsCommandes_Pieces WHERE NoBonCommande = '" + sNoRetour + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (m_eTypeRetour == enumTypeRetour.ACHAT)
                {
                    sWhere = "(IDAchat = '" + Strings.Replace(Strings.Trim(Gauche(txtNoProjet.Text, Strings.InStrRev(txtNoProjet.Text, "-") - 1)), "R", "") + "' AND IndexAchat = " + Conversion.Int(double.Parse(Droite(txtNoProjet.Text, 3))) + ")";
                    sWherePiece = "PIECE In (";
                    sWhereNoLigne = "NuméroLigne In (";
                    bPremier = true;
                    while (!rstBCPiece.EOF)
                    {
                        if (!(rstBCPiece.Fields["NoItem"].Value is DBNull))
                        {
                            sNoLigne = (string)(rstBCPiece.Fields["NuméroLigne"].Value);
                            if (bPremier == true)
                            {
                                if (Strings.InStr(1, sNoLigne, ",") == 0)
                                {
                                    sWherePiece = sWherePiece + "'" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                    sWhereNoLigne = (string)(Operators.ConcatenateObject(sWhereNoLigne, rstBCPiece.Fields["NuméroLigne"].Value));
                                }
                                else
                                {
                                    bPremierNoLigne = true;
                                    while (Strings.InStr(1, sNoLigne, ",") > 0)
                                    {
                                        if (bPremierNoLigne == true)
                                        {
                                            sWherePiece = sWherePiece + "'" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                            sWhereNoLigne = sWhereNoLigne + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1);
                                            bPremierNoLigne = false;
                                        }
                                        else
                                        {
                                            sWherePiece = sWherePiece + ", '" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                            sWhereNoLigne = sWhereNoLigne + ", " + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1);
                                        }
                                        sNoLigne = Droite(sNoLigne, sNoLigne.Length - (Strings.InStr(1, sNoLigne, ",") + 1));
                                    }
                                    if (!string.IsNullOrEmpty(sNoLigne.Trim()))
                                    {
                                        sWherePiece = sWherePiece + ", '" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                        sWhereNoLigne = sWhereNoLigne + ", " + sNoLigne;
                                    }
                                }
                                bPremier = false;
                            }
                            else if (Strings.InStr(1, sNoLigne, ",") == 0)
                            {
                                sWherePiece += $", '{rstBCPiece.Fields["NoItem"].Value}'";
                                sWhereNoLigne = (string)(Operators.ConcatenateObject(sWhereNoLigne + ", ", rstBCPiece.Fields["NuméroLigne"].Value));
                            }
                            else
                            {
                                while (Strings.InStr(1, sNoLigne, ",") > 0)
                                {
                                    sWherePiece = sWherePiece + ", '" + $"{rstBCPiece.Fields["NoItem"].Value}".Replace( "'", "''") + "'";
                                    sWhereNoLigne = sWhereNoLigne + ", " + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1);
                                    sNoLigne = Droite(sNoLigne, Strings.Len(sNoLigne) - (Strings.InStr(1, sNoLigne, ",") + 1));
                                }
                                if (!string.IsNullOrEmpty(Strings.Trim(sNoLigne)))
                                {
                                    sWherePiece += $", '{$"{rstBCPiece.Fields["NoItem"].Value}".Replace( "'", "''")}'";
                                    sWhereNoLigne+= ", " + sNoLigne;
                                }
                            }
                        }
                        rstBCPiece.MoveNext();
                    }
                    sWherePiece = sWherePiece + ")";
                    sWhereNoLigne = sWhereNoLigne + ")";
                    sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                    rstPiece.Open("SELECT * FROM Achat_Pieces WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    sWhere = "(IDProjet = '" + Droite(txtNoProjet.Text, Strings.Len(txtNoProjet.Text) - 1) + "')";
                    sWherePiece = "NumItem In (";
                    sWhereNoLigne = "NuméroLigne In (";
                    bPremier = true;
                    while (!rstBCPiece.EOF)
                    {
                        if (!(rstBCPiece.Fields["NoItem"].Value is DBNull))
                        {
                            sNoLigne = (string)(rstBCPiece.Fields["NuméroLigne"].Value);
                            if (bPremier == true)
                            {
                                if (Strings.InStr(1, sNoLigne, ",") == 0)
                                {
                                    sWherePiece = sWherePiece + "'" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                    sWhereNoLigne = (string)(Operators.ConcatenateObject(sWhereNoLigne, rstBCPiece.Fields["NuméroLigne"].Value));
                                }
                                else
                                {
                                    bPremierNoLigne = true;
                                    while (Strings.InStr(1, sNoLigne, ",") > 0)
                                    {
                                        if (bPremierNoLigne == true)
                                        {
                                            sWherePiece = sWherePiece + "'" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                            sWhereNoLigne = sWhereNoLigne + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1);
                                            bPremierNoLigne = false;
                                        }
                                        else
                                        {
                                            sWherePiece = sWherePiece + ", '" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                            sWhereNoLigne = sWhereNoLigne + ", " + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1);
                                        }
                                        sNoLigne = Droite(sNoLigne, Strings.Len(sNoLigne) - (Strings.InStr(1, sNoLigne, ",") + 1));
                                    }
                                    if (!string.IsNullOrEmpty(Strings.Trim(sNoLigne)))
                                    {
                                        sWherePiece = sWherePiece + ", '" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                        sWhereNoLigne = sWhereNoLigne + ", " + sNoLigne;
                                    }
                                }
                                bPremier = false;
                            }
                            else if (Strings.InStr(1, sNoLigne, ",") == 0)
                            {
                                sWherePiece = (string)(Operators.ConcatenateObject(Operators.ConcatenateObject(sWherePiece + ", '", rstBCPiece.Fields["NoItem"].Value), "'"));
                                sWhereNoLigne = (string)(Operators.ConcatenateObject(sWhereNoLigne + ", ", rstBCPiece.Fields["NuméroLigne"].Value));
                            }
                            else
                            {
                                while (Strings.InStr(1, sNoLigne, ",") > 0)
                                {
                                    sWherePiece = sWherePiece + ", '" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                    sWhereNoLigne = sWhereNoLigne + ", " + Gauche(sNoLigne, Strings.InStr(1, sNoLigne, ",") - 1);
                                    sNoLigne = Droite(sNoLigne, Strings.Len(sNoLigne) - (Strings.InStr(1, sNoLigne, ",") + 1));
                                }
                                if (!string.IsNullOrEmpty(Strings.Trim(sNoLigne)))
                                {
                                    sWherePiece = sWherePiece + ", '" + Strings.Replace((string)(rstBCPiece.Fields["NoItem"].Value), "'", "''") + "'";
                                    sWhereNoLigne = sWhereNoLigne + ", " + sNoLigne;
                                }
                            }
                        }
                        rstBCPiece.MoveNext();
                    }
                    sWherePiece = sWherePiece + ")";
                    sWhereNoLigne = sWhereNoLigne + ")";
                    sWhere = sWhere + " AND " + sWherePiece + " AND " + sWhereNoLigne;
                    rstPiece.Open("SELECT * FROM Projet_Pieces WHERE " + sWhere, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                rstBCPiece.Close();
                rstBCPiece = null;
                rstInventaire = new Recordset();
                rstInvModif = new Recordset();
                while (!rstPiece.EOF)
                {
                    rstBC.MoveFirst();
                    while (!rstBC.EOF)
                    {
                        if (rstBC.Fields["NoFournisseur"].Value== rstPiece.Fields["IDFRS"].Value)
                        {
                            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPiece.Fields["Retour"].Value, true, false)))
                            {
                                bRetourFait = true;
                            }
                            else
                            {
                                bRetourFait = false;
                            }
                            rstPiece.Fields["DateRetour"].Value = txtDateRetour.Text;
                            rstPiece.Fields["Retour"].Value = true;
                            rstPiece.Fields["NoRetour"].Value = rstBC.Fields["NoBonCommande"].Value;
                            if (m_eTypeRetour == enumTypeRetour.PROJET)
                            {
                                rstPiece.Fields["MatérielInutile"].Value = false;
                            }
                            rstPiece.Update();
                            if (bRetourFait == false)
                            {
                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstPiece.Fields["IDFRS"].Value, 717, false)))
                                {
                                    if (m_eTypeRetour == enumTypeRetour.ACHAT)
                                    {
                                        sPiece = (string)(rstPiece.Fields["PIECE"].Value);
                                    }
                                    else
                                    {
                                        sPiece = (string)(rstPiece.Fields["NumItem"].Value);
                                    }
                                    if (MessageBox.Show("Voulez vous modifier l'inventaire pour la pièce " + sPiece + " ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        if (cmbNoProjet.SelectedIndex == 0)
                                        {
                                            rstInventaire.Open("SELECT * FROM InventaireElec WHERE NoItem = '" + Strings.Replace(sPiece, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                        }
                                        else
                                        {
                                            rstInventaire.Open("SELECT * FROM InventaireMec WHERE NoItem = '" + Strings.Replace(sPiece, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                        }
                                        if (rstInventaire.EOF)
                                        {
                                            rstInventaire.AddNew();
                                            rstInventaire.Fields["NoItem"].Value = sPiece;
                                            rstInventaire.Fields["Description"].Value = rstPiece.Fields["Desc_FR"].Value;
                                            rstInventaire.Fields["Manufacturier"].Value = rstPiece.Fields["Manufact"].Value;
                                            cb.Afficher((string)(rstPiece.Fields["NumItem"].Value));
                                            rstInventaire.Fields["CommandeParBoite"].Value = g_bQteBoite;
                                            rstInventaire.Fields["QteBoite"].Value = g_sQteBoite;
                                            rstInventaire.Fields["QuantitéStock"].Value = 0;
                                            rstInventaire.Fields["Commentaires"].Value = "";
                                            if (cmbNoProjet.SelectedIndex == 0)
                                            {
                                                cl.Afficher(EnumCatalogue.ELECTRIQUE, (string)(rstPiece.Fields["NumItem"].Value));
                                            }
                                            else
                                            {
                                                cl.Afficher(EnumCatalogue.MECANIQUE, (string)(rstPiece.Fields["NumItem"].Value));
                                            }
                                            rstInventaire.Fields["Localisation"].Value = g_sLocalisation;
                                            rstInventaire.Fields["Minimum"].Value = false;
                                            rstInventaire.Fields["QuantitéMinimum"].Value = "";
                                            rstInventaire.Fields["Commande"].Value = "";
                                        }
                                        if ((bool)rstInventaire.Fields["CommandeParBoite"].Value == true)
                                        {
                                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(Strings.Replace((string)(rstPiece.Fields["Qté"].Value), "-", "")) * double.Parse(rstInventaire.Fields["QteBoite"].Value)).ToString(), ".", ",");
                                        }
                                        else
                                        {
                                            rstInventaire.Fields["QuantitéStock"].Value = Strings.Replace((double.Parse(rstInventaire.Fields["QuantitéStock"].Value) + double.Parse(Strings.Replace((string)(rstPiece.Fields["Qté"].Value), "-", ""))).ToString(), ".", ",");
                                        }
                                        if (rstPiece.Fields["Prix_List"].Value != "")
                                        {
                                            rstInventaire.Fields["Prix Liste"].Value = " ";
                                        }
                                        else
                                        {
                                            rstInventaire.Fields["Prix Liste"].Value = rstPiece.Fields["Prix_List"].Value;
                                        }
                                        rstInventaire.Fields["Escompte"].Value = rstPiece.Fields["Escompte"].Value;
                                        rstInventaire.Fields["Prix net"].Value = rstPiece.Fields["Prix_Net"].Value;
                                        rstInventaire.Update();
                                        rstInventaire.Close();
                                        if (cmbNoProjet.SelectedIndex == 0)
                                        {
                                            rstInvModif.Open("SELECT * FROM InventaireElecModif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                        }
                                        else
                                        {
                                            rstInvModif.Open("SELECT * FROM InventaireMecModif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                        }
                                        rstInvModif.AddNew();
                                        rstInvModif.Fields["Date"].Value = txtDateRetour.Text;
                                        rstInvModif.Fields["IDProjet"].Value = txtNoProjet.Text;
                                        rstInvModif.Fields["NoItem"].Value = sPiece;
                                        rstInvModif.Fields["Quantité"].Value = Strings.Replace((string)(rstPiece.Fields["Qté"].Value), "-", "");
                                        rstInvModif.Fields["User"].Value = Conteneur.idInitiales.Text;
                                        rstInvModif.Update();
                                        rstInvModif.Close();
                                    }
                                }
                            }
                            break;
                        }
                        rstBC.MoveNext();
                    }
                    rstPiece.MoveNext();
                }
                rstInventaire = null;
                rstInvModif = null;
                rstPiece.Close();
                rstPiece = null;
                rstBC.Close();
                rstBC = null;
                if (m_eTypeRetour == enumTypeRetour.ACHAT)
                {
                    RemplirListViewAchat();
                }
                else
                {
                    RemplirListViewProjet();
                    // Ajout aux modifs
                    rstModif = new Recordset();
                    rstEmploye = new Recordset();
                    rstModif.Open("SELECT * FROM Projet_Modif", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstModif.AddNew();
                    rstEmploye.Open("SELECT noEmploye FROM Employés WHERE loginname = '" + IdLoginEmploye + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstModif.Fields["Type"].Value = "E";
                    rstModif.Fields["IDProjet"].Value = Droite(txtNoProjet.Text, Strings.Len(txtNoProjet.Text) - 1);
                    rstModif.Fields["noEmployé"].Value = rstEmploye.Fields["noEmploye"].Value;
                    rstModif.Fields["Date"].Value = ConvertDate(DateTime.Today);
                    rstModif.Fields["Heure"].Value = DateAndTime.TimeOfDay;
                    rstModif.Fields["TypeModif"].Value = "RETOUR";
                    rstEmploye.Close();
                    rstEmploye = null;
                    rstModif.Update();
                    rstModif.Close();
                    rstModif = null;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "Retour", ex);
            }
        }
        private void RetourMarchandise_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                txtDateRetour.Text = ConvertDate(DateTime.Today);
                RemplirComboProjets();
                if (cmbNoProjet.Items.Count > 0) cmbNoProjet.SelectedIndex = 0; 
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "Form_Load", ex);
            }
        }
        private void lvwProjet_ItemCheck(object eventSender, ItemCheckEventArgs eventArgs)
        {
            var Item = lvwProjet.Items[eventArgs.Index];
            try
            {
                if (!string.IsNullOrEmpty(Item.Text))
                {
                    if (double.Parse(Item.Text) > 0d)
                    {
                        Item.Checked = false;
                    }
                }
                else
                {
                    Item.Checked = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "lvwProjet_ItemCheck", ex);
            }
        }
        private void mvwRetour_DateClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtDateRetour.Text = ConvertDate(mvwRetour.Value);

                ((dynamic)mvwRetour).Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "mvwRetour_DateClick", ex);
            }
        }
        private void cmdDate_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtDateRetour.Text))
                {
                    mvwRetour.Value = Conversions.ToDate(txtDateRetour.Text);
                }
                else
                {
                    mvwRetour.Value = DateTime.Today;
                } ((dynamic)mvwRetour).Visible = true;
                ((dynamic)mvwRetour).Focus();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("RetourMarchandise", "cmdDate_Click", ex);
            }
        }
        private void mvwRetour_ValueChanged(object sender, EventArgs e)
        {
            txtDateRetour.Text = mvwRetour.Value.ToShortDateString();
            mvwRetour.Visible = false;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_eTypeRetour = enumTypeRetour.ACHAT;
           RemplirComboAchats();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_eTypeRetour = enumTypeRetour.PROJET;
            m_TypeProjet = EnumCatalogue.ELECTRIQUE;
            RemplirComboProjetElec();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_eTypeRetour = enumTypeRetour.PROJET;
            m_TypeProjet = EnumCatalogue.MECANIQUE;
            RemplirComboProjetMec();
        }
    }
}