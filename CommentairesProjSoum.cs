using System;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using System.Diagnostics;
using ADODB;
namespace ControleurServeur
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal class CommentairesProjSoum : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public CommentairesProjSoum() : base()
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
        internal static Button cmdFermer;
        internal static Button cmdCopier;
        internal static Button cmdSupprimerTout;
        internal static Button cmdVider;
        internal static Button cmdAjouter;
        internal static TextBox txtAjout;
        public TreeView tvwCommentaire;
        internal static Label Label2;
        internal static Label lblNoProjSoum;
        internal static Label lblTitreNoProjSoum;
        internal static Label Label1;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdFermer = new System.Windows.Forms.Button();
            cmdCopier = new System.Windows.Forms.Button();
            cmdSupprimerTout = new System.Windows.Forms.Button();
            cmdVider = new System.Windows.Forms.Button();
            cmdAjouter = new System.Windows.Forms.Button();
            txtAjout = new System.Windows.Forms.TextBox();
            tvwCommentaire = new System.Windows.Forms.TreeView();
            Label2 = new System.Windows.Forms.Label();
            lblNoProjSoum = new System.Windows.Forms.Label();
            lblTitreNoProjSoum = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;//cmdFermer
            cmdFermer.BackColor = System.Drawing.Color.Black;
            cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.ForeColor = System.Drawing.Color.White;
            cmdFermer.Location = new System.Drawing.Point(552, 632);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(105, 33);
            cmdFermer.TabIndex = 10;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(cmdFermer_Click);//cmdCopier
            cmdCopier.BackColor = System.Drawing.Color.Black;
            cmdCopier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdCopier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdCopier.ForeColor = System.Drawing.Color.Navy;
            cmdCopier.Location = new System.Drawing.Point(8, 352);
            cmdCopier.Name = "cmdCopier";
            cmdCopier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdCopier.Size = new System.Drawing.Size(105, 33);
            cmdCopier.TabIndex = 8;
            cmdCopier.Text = "Copier en bas";
            cmdCopier.UseVisualStyleBackColor = true;
            cmdCopier.Click += new System.EventHandler(cmdCopier_Click);//cmdSupprimerTout
            cmdSupprimerTout.BackColor = System.Drawing.Color.Black;
            cmdSupprimerTout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdSupprimerTout.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdSupprimerTout.ForeColor=System.Drawing.Color.Navy;
            cmdSupprimerTout.Location = new System.Drawing.Point(552, 352);
            cmdSupprimerTout.Name = "cmdSupprimerTout";
            cmdSupprimerTout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdSupprimerTout.Size = new System.Drawing.Size(105, 33);
            cmdSupprimerTout.TabIndex = 7;
            cmdSupprimerTout.Text = "Supprimer tout";
            cmdSupprimerTout.UseVisualStyleBackColor = true;
            cmdSupprimerTout.Click += new System.EventHandler(cmdSupprimerTout_Click);//cmdVider
            cmdVider.BackColor = System.Drawing.Color.Black;
            cmdVider.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdVider.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdVider.ForeColor=System.Drawing.Color.Navy;
            cmdVider.Location = new System.Drawing.Point(440, 584);
            cmdVider.Name = "cmdVider";
            cmdVider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdVider.Size = new System.Drawing.Size(105, 33);
            cmdVider.TabIndex = 4;
            cmdVider.Text = "Vider";
            cmdVider.UseVisualStyleBackColor = true;
            cmdVider.Click += new System.EventHandler(cmdVider_Click);//cmdAjouter
            cmdAjouter.BackColor = System.Drawing.Color.Black;
            cmdAjouter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAjouter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAjouter.ForeColor=System.Drawing.Color.Navy;
            cmdAjouter.Location = new System.Drawing.Point(552, 584);
            cmdAjouter.Name = "cmdAjouter";
            cmdAjouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAjouter.Size = new System.Drawing.Size(105, 33);
            cmdAjouter.TabIndex = 2;
            cmdAjouter.Text = "Ajouter";
            cmdAjouter.UseVisualStyleBackColor = true;
            cmdAjouter.Click += new System.EventHandler(cmdAjouter_Click);//txtAjout
            txtAjout.AcceptsReturn = true;
            txtAjout.BackColor = System.Drawing.Color.Black;
            txtAjout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtAjout.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAjout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtAjout.ForeColor = System.Drawing.Color.White;
            txtAjout.Location = new System.Drawing.Point(8, 400);
            txtAjout.MaxLength = 0;
            txtAjout.Multiline = true;
            txtAjout.Name = "txtAjout";
            txtAjout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAjout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtAjout.Size = new System.Drawing.Size(649, 177);
            txtAjout.TabIndex = 1;//tvwCommentaire
            tvwCommentaire.BackColor = System.Drawing.Color.Black;
            tvwCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tvwCommentaire.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tvwCommentaire.ForeColor = System.Drawing.Color.White;
            tvwCommentaire.FullRowSelect = true;
            tvwCommentaire.Location = new System.Drawing.Point(8, 64);
            tvwCommentaire.Name = "tvwCommentaire";
            tvwCommentaire.Size = new System.Drawing.Size(649, 281);
            tvwCommentaire.TabIndex = 0;//Label2
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(8, 624);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(225, 33);
            Label2.TabIndex = 9;
            Label2.Text = "Les lignes commencées par \"--\" seront des sous-sections";//lblNoProjSoum
            lblNoProjSoum.BackColor = System.Drawing.Color.Black;
            lblNoProjSoum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoProjSoum.ForeColor = System.Drawing.Color.White;
            lblNoProjSoum.Location = new System.Drawing.Point(392, 8);
            lblNoProjSoum.Name = "lblNoProjSoum";
            lblNoProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNoProjSoum.Size = new System.Drawing.Size(225, 17);
            lblNoProjSoum.TabIndex = 6;//lblTitreNoProjSoum
            lblTitreNoProjSoum.AutoSize = true;
            lblTitreNoProjSoum.BackColor = System.Drawing.Color.Black;
            lblTitreNoProjSoum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreNoProjSoum.ForeColor = System.Drawing.Color.White;
            lblTitreNoProjSoum.Location = new System.Drawing.Point(321, 8);
            lblTitreNoProjSoum.Name = "lblTitreNoProjSoum";
            lblTitreNoProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTitreNoProjSoum.Size = new System.Drawing.Size(64, 16);
            lblTitreNoProjSoum.TabIndex = 5;
            lblTitreNoProjSoum.Text = "# Projet :";
            lblTitreNoProjSoum.TextAlign = System.Drawing.ContentAlignment.TopRight;//Label1
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(8, 584);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(225, 33);
            Label1.TabIndex = 3;
            Label1.Text = "Les lignes commencées par \"-\" seront des sections";//CommentairesProjSoum
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(662, 676);
            Controls.Add(cmdFermer);
            Controls.Add(cmdCopier);
            Controls.Add(cmdSupprimerTout);
            Controls.Add(cmdVider);
            Controls.Add(cmdAjouter);
            Controls.Add(txtAjout);
            Controls.Add(tvwCommentaire);
            Controls.Add(Label2);
            Controls.Add(lblNoProjSoum);
            Controls.Add(lblTitreNoProjSoum);
            Controls.Add(Label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Location = new System.Drawing.Point(238, 216);
            Name = "CommentairesProjSoum";
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
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        [Obsolete]
        public void Afficher(string sNoProjSoum, bool bProjet)
        {
            try
            {
                if (bProjet == true)
                {
                    lblTitreNoProjSoum.Text = "# Projet : ";
                }
                else
                {
                    lblTitreNoProjSoum.Text = "# Soumission : ";
                }
                lblNoProjSoum.Text = sNoProjSoum;
                RemplirTreeView();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CommentairesProjSoum", "Afficher", ex);
            }
        }
        [Obsolete]
        private void cmdAjouter_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstCommentaire;
                string sLigne;
                var iKeySection = default(int);
                var iKeySousSection = default(int);
                int X;
                var bSousSection = default(bool);
                if (!string.IsNullOrEmpty(Strings.Trim(txtAjout.Text)))
                {
                    if (tvwCommentaire.Nodes.Count == 0)
                    {
                        if (Gauche(txtAjout.Text.Trim(), 1) == "-" & Gauche(txtAjout.Text.Trim(), 2) != "--")
                        {
                            rstCommentaire = new Recordset();
                            rstCommentaire.Open("SELECT * FROM Commentaires WHERE NoProjSoum = '" + lblNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            string[] arr_sLigne = new string[rstCommentaire.Fields.Count];
                            var loopTo = (int)Information.UBound(arr_sLigne);
                            for (X = 0; X <= loopTo; X++)
                            {
                                sLigne = Strings.Trim(arr_sLigne[X]);
                                if (!string.IsNullOrEmpty(sLigne))
                                {
                                    rstCommentaire.AddNew();
                                    rstCommentaire.Fields["NoProjSoum"].Value = lblNoProjSoum.Text;
                                    rstCommentaire.Fields["Index"].Value = X;
                                    if (Gauche(sLigne, 2) == "--")
                                    {
                                        bSousSection = true;
                                        rstCommentaire.Fields["SousSection"].Value = true;
                                        rstCommentaire.Fields["Relative"].Value = iKeySection;
                                        iKeySousSection = (int)(iKeySousSection + 1);
                                        rstCommentaire.Fields["Key"].Value = iKeySousSection;
                                        rstCommentaire.Fields["Commentaire"].Value = Droite(sLigne, Strings.Len(sLigne) - 2);
                                    }
                                    else if (Gauche(sLigne, 1) == "-")
                                    {
                                        rstCommentaire.Fields["Section"].Value = true;
                                        iKeySection = (int)(iKeySection + 1);
                                        iKeySousSection = (int)(iKeySection * 100);
                                        bSousSection = false;
                                        rstCommentaire.Fields["Key"].Value = iKeySection;
                                        rstCommentaire.Fields["Commentaire"].Value = Droite(sLigne, Strings.Len(sLigne) - 1);
                                    }
                                    else
                                    {
                                        if (bSousSection == true)
                                        {
                                            rstCommentaire.Fields["Relative"].Value = iKeySousSection;
                                        }
                                        else
                                        {
                                            rstCommentaire.Fields["Relative"].Value = iKeySection;
                                        }
                                        rstCommentaire.Fields["Commentaire"].Value = sLigne;
                                    }
                                    rstCommentaire.Update();
                                }
                            }
                            rstCommentaire.Close();
                            // Object rstCommentaire peut ne pas etre détruit avant la mise en corbeille
                            rstCommentaire = null;
                            RemplirTreeView();
                        }
                        else
                        {
                            MessageBox.Show("La première ligne doit absolument être une section!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossible d'ajouter les commentaires, la liste doit être vide!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Rien à ajouter!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CommentairesProjSoum", "cmdAjouter_Click", ex);
            }
        }
        private void cmdCopier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                int X;
                TreeNode nodComment;
                if (tvwCommentaire.Nodes.Count > 0)
                {
                    txtAjout.Text = "";
                    var loopTo = (int)tvwCommentaire.Nodes.Count;
                    for (X = 1; X <= loopTo; X++)
                    {
                        // tvwCommentaire.Nodes a changé pour devenir une List<String> d'item'
                        nodComment = tvwCommentaire.Nodes[X];
                        if (nodComment.NodeFont.Bold == true)
                        {
                            if (string.IsNullOrEmpty(txtAjout.Text))
                            {
                                txtAjout.Text = "-" + nodComment.Text;
                            }
                            else
                            {
                                txtAjout.Text = txtAjout.Text + "\n" + "-" + nodComment.Text;
                            }
                        }
                        else if (string.IsNullOrEmpty(txtAjout.Text))
                        {
                            txtAjout.Text = nodComment.Text;
                        }
                        else
                        {
                            txtAjout.Text = txtAjout.Text + "\n" + nodComment.Text;
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CommentairesProjSoum", "cmdCopier_Click", ex);
            }
        }
        private void cmdFermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CommentairesProjSoum", "cmdFermer_Click", ex);
            }
        }
        private void cmdSupprimerTout_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (tvwCommentaire.Nodes.Count > 0)
                {
                    if (MessageBox.Show("Voulez-vous vraiment effacer tous les commentaires?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UpdateSQL("DELETE FROM Commentaires WHERE NoProjSoum = '" + lblNoProjSoum.Text + "'");
                        tvwCommentaire.Nodes.Clear();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CommentairesProjSoum", "cmdSupprimerTout_Click", ex);
            }
        }
        private void cmdVider_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtAjout.Text = "";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CommentairesProjSoum", "cmdVider_Click", ex);
            }
        }
        [Obsolete]
        private void RemplirTreeView()
        {
            try
            {
                ADODB.Recordset rstCommentaire;
                TreeNode itmCommentaire;
                tvwCommentaire.Nodes.Clear();
                rstCommentaire = new Recordset();
                rstCommentaire.Open("SELECT * FROM Commentaires WHERE NoProjSoum = '" + lblNoProjSoum.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstCommentaire.EOF)
                {
                    if (!(rstCommentaire.Fields["Commentaire"].Value is DBNull))
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstCommentaire.Fields["Section"], true, false)))
                        {
                            itmCommentaire = tvwCommentaire.Nodes.Add((string)(Operators.ConcatenateObject("KEY", rstCommentaire.Fields["Key"])), (string)(rstCommentaire.Fields["Commentaire"].Value));
                        }
                        else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstCommentaire.Fields["SousSection"], true, false)))
                        {
                            itmCommentaire = tvwCommentaire.Nodes.Find((string)(Operators.ConcatenateObject("KEY", rstCommentaire.Fields["Relative"])), true)[0].Nodes.Add((string)(Operators.ConcatenateObject("KEY", rstCommentaire.Fields["Key"].Value)), (string)(rstCommentaire.Fields["Commentaire"].Value));
                        }
                        else
                        {
                            itmCommentaire = (TreeNode)tvwCommentaire.Nodes.Find((string)(Operators.ConcatenateObject("KEY", rstCommentaire.Fields["Relative"].Value)), true)[0].Nodes.Add(rstCommentaire.Fields["Commentaire"].Value);
                        }
                        itmCommentaire.Tag = rstCommentaire.Fields["ID"];
                    }
                    rstCommentaire.MoveNext();
                }
                rstCommentaire.Close();
                // Object rstCommentaire peut ne pas etre détruit avant la mise en corbeille
                rstCommentaire = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CommentairesProjSoum", "RemplirTreeView", ex);
            }
        }
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}