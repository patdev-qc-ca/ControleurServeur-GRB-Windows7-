using System;
using System.Diagnostics;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class ChoixCommentaire : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixCommentaire() : base()
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
        internal static Button cmdOK;
        public TreeView tvwCommentaire;
        internal static Label lblNoProjSoum;
        internal static Label lblTitreNoProjSoum;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmdOK = new System.Windows.Forms.Button();
            tvwCommentaire = new System.Windows.Forms.TreeView();
            lblNoProjSoum = new System.Windows.Forms.Label();
            lblTitreNoProjSoum = new System.Windows.Forms.Label();
            SuspendLayout();//ToolTip1
            ToolTip1.BackColor = System.Drawing.Color.Black;
            ToolTip1.ForeColor = System.Drawing.Color.White;//cmdOK
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(575, 586);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(82, 31);
            cmdOK.TabIndex = 1;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);//tvwCommentaire
            tvwCommentaire.BackColor = System.Drawing.Color.Black;
            tvwCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tvwCommentaire.CheckBoxes = true;
            tvwCommentaire.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tvwCommentaire.ForeColor = System.Drawing.Color.White;
            tvwCommentaire.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            tvwCommentaire.Location = new System.Drawing.Point(8, 64);
            tvwCommentaire.Name = "tvwCommentaire";
            tvwCommentaire.Size = new System.Drawing.Size(649, 505);
            tvwCommentaire.TabIndex = 0;//lblNoProjSoum
            lblNoProjSoum.BackColor = System.Drawing.Color.Black;
            lblNoProjSoum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoProjSoum.ForeColor = System.Drawing.Color.White;
            lblNoProjSoum.Location = new System.Drawing.Point(392, 8);
            lblNoProjSoum.Name = "lblNoProjSoum";
            lblNoProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNoProjSoum.Size = new System.Drawing.Size(225, 17);
            lblNoProjSoum.TabIndex = 3;//lblTitreNoProjSoum
            lblTitreNoProjSoum.BackColor = System.Drawing.Color.Black;
            lblTitreNoProjSoum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitreNoProjSoum.ForeColor = System.Drawing.Color.White;
            lblTitreNoProjSoum.Location = new System.Drawing.Point(272, 8);
            lblTitreNoProjSoum.Name = "lblTitreNoProjSoum";
            lblTitreNoProjSoum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTitreNoProjSoum.Size = new System.Drawing.Size(105, 17);
            lblTitreNoProjSoum.TabIndex = 2;
            lblTitreNoProjSoum.Text = "Numéro :";
            lblTitreNoProjSoum.TextAlign = System.Drawing.ContentAlignment.TopRight;//ChoixCommentaire
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(662, 626);
            Controls.Add(cmdOK);
            Controls.Add(tvwCommentaire);
            Controls.Add(lblNoProjSoum);
            Controls.Add(lblTitreNoProjSoum);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Location = new System.Drawing.Point(238, 216);
            Name = "ChoixCommentaire";
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
            Load += new System.EventHandler(ChoixCommentaire_Load);
            ResumeLayout(false);
        }
        #endregion
        private string sProjet;
        public ChoixCommentaire(string sProjet)
        {
            sProjet = sProjet;
            Afficher(sProjet);
        }
        public void Afficher(string sNoProjSoum)
        {
            try
            {
                lblNoProjSoum.Text = sNoProjSoum;
                RemplirTreeView();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCommentaire", "Afficher", ex);
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
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstCommentaire.Fields["Section"].Value, true, false)))
                        {
                            itmCommentaire = tvwCommentaire.Nodes.Add((string)(Operators.ConcatenateObject("KEY", rstCommentaire.Fields["Key"].Value)), (string)(rstCommentaire.Fields["Commentaire"].Value));
                        }
                        else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rstCommentaire.Fields["SousSection"].Value, true, false)))
                        {
                            itmCommentaire = tvwCommentaire.Nodes.Find((string)(Operators.ConcatenateObject("KEY", rstCommentaire.Fields["Relative"].Value)), true)[0].Nodes.Add((string)(Operators.ConcatenateObject("KEY", rstCommentaire.Fields["Key"].Value)), (string)(rstCommentaire.Fields["Commentaire"].Value));
                        }
                        else
                        {
                            itmCommentaire = (TreeNode)tvwCommentaire.Nodes.Find((string)(Operators.ConcatenateObject("KEY", rstCommentaire.Fields["Relative"].Value)), true)[0].Nodes.Add(rstCommentaire.Fields["Commentaire"].Value);
                        }
                        itmCommentaire.Tag = rstCommentaire.Fields["ID"].Value;
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
                AfficherErreur("ChoixCommentaire", "RemplirTreeView", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                var sCommentaire = default(string);
                int X;
                var sSection = default(string);
                TreeNode nodComment;
                if (tvwCommentaire.Nodes.Count > 0)
                {
                    var loopTo = (int)tvwCommentaire.Nodes.Count;
                    for (X = 1; X <= loopTo; X++)
                    {
                        // tvwCommentaire.Nodes a changé pour devenir une List<String> d'item'
                        nodComment = tvwCommentaire.Nodes[X];
                        if (nodComment.NodeFont.Bold == true)
                        {
                            if (int.Parse(Strings.Replace(nodComment.Name, "KEY", "")) > 100)
                            {
                                sSection = sSection + " / " + nodComment.Text;
                            }
                            else
                            {
                                sSection = nodComment.Text;
                            }
                        }
                        else if (nodComment.Checked == true)
                        {
                            if (string.IsNullOrEmpty(sCommentaire))
                            {
                                sCommentaire = sSection + " / " + nodComment.Text;
                            }
                            else
                            {
                                sCommentaire = sCommentaire + "\n" + sSection + " / " + nodComment.Text;
                            }
                        }
                    }
                    Punch.sCommentaire = sCommentaire;
                }
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixCommentaire", "cmdOK_Click", ex);
            }
        }
        private void ChoixCommentaire_Load(object sender, EventArgs e)
        {
            Icon = MdiParent.Icon;
        }
    }
}