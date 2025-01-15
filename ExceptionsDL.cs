using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class ExceptionsLD : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ExceptionsLD() : base()
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
        internal static Button cmdSupprimer;
        internal static Button cmdAjouter;
        internal static ColumnHeader _lvwExceptions_ColumnHeader_1;
        internal static ListView lvwExceptions;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdSupprimer = new System.Windows.Forms.Button();
            cmdAjouter = new System.Windows.Forms.Button();
            lvwExceptions = new System.Windows.Forms.ListView();
            _lvwExceptions_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();//cmdSupprimer
            cmdSupprimer.BackColor = System.Drawing.Color.Black;
            cmdSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdSupprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdSupprimer.ForeColor = System.Drawing.Color.White;
            cmdSupprimer.Location = new System.Drawing.Point(371, 409);
            cmdSupprimer.Name = "cmdSupprimer";
            cmdSupprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSupprimer.Size = new System.Drawing.Size(97, 25);
            cmdSupprimer.TabIndex = 1;
            cmdSupprimer.Text = "Supprimer";
            cmdSupprimer.UseVisualStyleBackColor = true;
            cmdSupprimer.Click += new System.EventHandler(cmdSupprimer_Click);//cmdAjouter
            cmdAjouter.BackColor = System.Drawing.Color.Black;
            cmdAjouter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAjouter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAjouter.ForeColor = System.Drawing.Color.White;
            cmdAjouter.Location = new System.Drawing.Point(268, 409);
            cmdAjouter.Name = "cmdAjouter";
            cmdAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAjouter.Size = new System.Drawing.Size(97, 25);
            cmdAjouter.TabIndex = 0;
            cmdAjouter.Text = "Ajouter";
            cmdAjouter.UseVisualStyleBackColor = true;
            cmdAjouter.Click += new System.EventHandler(cmdAjouter_Click);//lvwExceptions
            lvwExceptions.BackColor = System.Drawing.Color.Black;
            lvwExceptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lvwExceptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwExceptions_ColumnHeader_1});
            lvwExceptions.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwExceptions.ForeColor = System.Drawing.Color.White;
            lvwExceptions.FullRowSelect = true;
            lvwExceptions.GridLines = true;
            lvwExceptions.HideSelection = false;
            lvwExceptions.Location = new System.Drawing.Point(12, 53);
            lvwExceptions.Name = "lvwExceptions";
            lvwExceptions.Size = new System.Drawing.Size(456, 335);
            lvwExceptions.TabIndex = 2;
            lvwExceptions.UseCompatibleStateImageBehavior = false;
            lvwExceptions.View = System.Windows.Forms.View.Details;
            lvwExceptions.KeyDown += new System.Windows.Forms.KeyEventHandler(lvwExceptions_KeyDown);//_lvwExceptions_ColumnHeader_1
            _lvwExceptions_ColumnHeader_1.Text = "Courriel";
            _lvwExceptions_ColumnHeader_1.Width = 447;//ExceptionsLD
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(483, 449);
            Controls.Add(cmdSupprimer);
            Controls.Add(cmdAjouter);
            Controls.Add(lvwExceptions);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(3, 29);
            Name = "ExceptionsLD";
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
            Text = "Exceptions des listes de distribution";
            Load += new System.EventHandler(ExceptionsDL_Load);
            ResumeLayout(false);
        }
        #endregion
        private void cmdAjouter_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sAdresse;
                ADODB.Recordset rstExceptions;
                sAdresse = Interaction.InputBox("Quel est l'adresse à ajouter ?");
                if ((sAdresse) != "")
                {
                    if (ValiderAdresse(sAdresse) == true)
                    {
                        rstExceptions = new Recordset();
                        rstExceptions.Open("SELECT * FROM ExceptionsDL WHERE [Exception] = '" + Strings.Replace(sAdresse, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstExceptions.EOF)
                        {
                            rstExceptions.AddNew();
                            rstExceptions.Fields["Exception"].Value = sAdresse;
                            rstExceptions.Update();
                            RemplirListBoxExceptions();
                        }
                        else
                        {
                            MessageBox.Show("Ce courriel est déjà dans la liste!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        rstExceptions.Close();
                        // Object rstExceptions peut ne pas etre détruit avant la mise en corbeille
                        rstExceptions = null;
                    }
                    else
                    {
                        MessageBox.Show("Adresse invalide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ExceptionsLD", "cmdAjouter_Click", ex);
            }
        }
        private bool ValiderAdresse(string sAdresse)
        {
            bool ValiderAdresseRet = default;
            try
            {
                bool bValide;
                bValide = true;
                if (Strings.Len(sAdresse) < 5)
                {
                    bValide = false;
                }
                if (bValide == true)
                {
                    if (Strings.InStr(1, sAdresse, "@") == 0)
                    {
                        bValide = false;
                    }
                }
                if (bValide == true)
                {
                    if (Strings.InStr(Strings.InStr(1, sAdresse, "@") + 1, sAdresse, ".") == 0)
                    {
                        bValide = false;
                    }
                }
                if (bValide == true)
                {
                    if (Gauche(sAdresse, 1) == "@")
                    {
                        bValide = false;
                    }
                }
                if (bValide == true)
                {
                    if (Droite(sAdresse, 1) == ".")
                    {
                        bValide = false;
                    }
                }
                ValiderAdresseRet = bValide;
                return ValiderAdresseRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("ExceptionsLD", "ValiderAdresse", ex); return false;
            }
        }
        private void cmdSupprimer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                SupprimerCourriel();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ExceptionsLD", "cmdSupprimer_Click", ex);
            }
        }
        private void SupprimerCourriel()
        {
            try
            {
                if (lvwExceptions.Items.Count > 0)
                {
                    if (MessageBox.Show("Voulez-vous vraiment effacer l'adresse " + lvwExceptions.FocusedItem.Text + " ? ", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UpdateSQL("DELETE FROM ExceptionsDL WHERE ID = " + lvwExceptions.FocusedItem.SubItems[1].Text);
                        RemplirListBoxExceptions();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ExceptionsLD", "SupprimerCourriel", ex);
            }
        }
        private void ExceptionsDL_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                RemplirListBoxExceptions();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ExceptionsLD", "Form_Load", ex);
            }
        }
        private void RemplirListBoxExceptions()
        {
            try
            {
                ADODB.Recordset rstExceptions;
                ListViewItem itmException;
                lvwExceptions.Items.Clear();
                rstExceptions = new Recordset();
                rstExceptions.Open("SELECT * FROM ExceptionsDL ORDER BY [Exception]", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstExceptions.EOF)
                {
                    // MSComctlLib.ListItems method lvwExceptions.ListItems.Add
                    itmException = lvwExceptions.Items.Add(string.Empty);
                    itmException.Text = (string)(rstExceptions.Fields["Exception"].Value);
                    itmException.SubItems.Insert(1,new ListViewItem.ListViewSubItem(null,$"{rstExceptions.Fields["ID"].Value}"));
                    rstExceptions.MoveNext();
                }
                rstExceptions.Close();
                // Object rstExceptions peut ne pas etre détruit avant la mise en corbeille
                rstExceptions = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ExceptionsLD", "RemplirListBoxExceptions", ex);
            }
        }
        private void lvwExceptions_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (eventArgs.KeyCode == Keys.Delete)
                {
                    SupprimerCourriel();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ExceptionsLD", "lvwExceptions_KeyDown", ex);
            }
        }
    }
}