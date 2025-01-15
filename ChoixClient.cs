using System;
using System.Windows.Forms;
using System.Diagnostics;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class ChoixClient : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixClient() : base()
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
        internal ToolTip ToolTip1;
        internal TextBox txtDescription;
        internal Button cmdRafraichir;
        internal Button cmdRecherche;
        internal TextBox txtRecherche;
        internal GroupBox fraRecherche;
        internal ComboBox cmbClient;
        internal Button cmdOK;
        internal Label Label2;
        internal Label Label1;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.fraRecherche = new System.Windows.Forms.GroupBox();
            this.cmdRafraichir = new System.Windows.Forms.Button();
            this.cmdRecherche = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.fraRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(12, 280);
            this.txtDescription.MaxLength = 0;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Size = new System.Drawing.Size(225, 63);
            this.txtDescription.TabIndex = 8;
            // 
            // fraRecherche
            // 
            this.fraRecherche.BackColor = System.Drawing.Color.Black;
            this.fraRecherche.Controls.Add(this.cmdRafraichir);
            this.fraRecherche.Controls.Add(this.cmdRecherche);
            this.fraRecherche.Controls.Add(this.txtRecherche);
            this.fraRecherche.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraRecherche.ForeColor = System.Drawing.Color.White;
            this.fraRecherche.Location = new System.Drawing.Point(36, 112);
            this.fraRecherche.Name = "fraRecherche";
            this.fraRecherche.Padding = new System.Windows.Forms.Padding(0);
            this.fraRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraRecherche.Size = new System.Drawing.Size(169, 81);
            this.fraRecherche.TabIndex = 1;
            this.fraRecherche.TabStop = false;
            this.fraRecherche.Text = "Recherche";
            // 
            // cmdRafraichir
            // 
            this.cmdRafraichir.AutoSize = true;
            this.cmdRafraichir.BackColor = System.Drawing.Color.Black;
            this.cmdRafraichir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdRafraichir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRafraichir.ForeColor = System.Drawing.Color.White;
            this.cmdRafraichir.Location = new System.Drawing.Point(40, 48);
            this.cmdRafraichir.Name = "cmdRafraichir";
            this.cmdRafraichir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRafraichir.Size = new System.Drawing.Size(69, 26);
            this.cmdRafraichir.TabIndex = 3;
            this.cmdRafraichir.Text = "Rafraichir";
            this.cmdRafraichir.UseVisualStyleBackColor = true;
            this.cmdRafraichir.Click += new System.EventHandler(this.cmdRafraichir_Click);
            // 
            // cmdRecherche
            // 
            this.cmdRecherche.AutoSize = true;
            this.cmdRecherche.BackColor = System.Drawing.Color.Black;
            this.cmdRecherche.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdRecherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecherche.ForeColor = System.Drawing.Color.White;
            this.cmdRecherche.Location = new System.Drawing.Point(112, 48);
            this.cmdRecherche.Name = "cmdRecherche";
            this.cmdRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRecherche.Size = new System.Drawing.Size(49, 26);
            this.cmdRecherche.TabIndex = 4;
            this.cmdRecherche.Text = "OK";
            this.cmdRecherche.UseVisualStyleBackColor = true;
            this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.AcceptsReturn = true;
            this.txtRecherche.BackColor = System.Drawing.Color.Black;
            this.txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.White;
            this.txtRecherche.Location = new System.Drawing.Point(8, 24);
            this.txtRecherche.MaxLength = 0;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecherche.Size = new System.Drawing.Size(153, 22);
            this.txtRecherche.TabIndex = 2;
            // 
            // cmbClient
            // 
            this.cmbClient.BackColor = System.Drawing.Color.Black;
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.ForeColor = System.Drawing.Color.White;
            this.cmbClient.Location = new System.Drawing.Point(12, 216);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbClient.Size = new System.Drawing.Size(225, 22);
            this.cmbClient.Sorted = true;
            this.cmbClient.TabIndex = 5;
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Black;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.Color.White;
            this.cmdOK.Location = new System.Drawing.Point(199, 366);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(65, 25);
            this.cmdOK.TabIndex = 6;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(12, 256);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(69, 14);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Description :";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(12, 88);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(89, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Pour quel client ?";
            // 
            // ChoixClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(276, 399);
            this.ControlBox = false;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.fraRecherche);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(4, 23);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixClient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContrôleurWebAutoGRB.ChoixClient";
            this.Load += new System.EventHandler(this.ChoixClient_Load);
            this.fraRecherche.ResumeLayout(false);
            this.fraRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        [Obsolete]
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (cmbClient.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(Strings.Trim(txtDescription.Text)))
                    {
                        m_iIDClient = (int)GetClientID(cmbClient.Items[cmbClient.SelectedIndex].ToString());
                        m_sDescription = txtDescription.Text;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("La description est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Le client est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixClient", "cmdOK_Click", ex);
            }
        }
        private void cmdRafraichir_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RemplirComboClient(string.Empty);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixClient", "cmdRafraichir_Click", ex);
            }
        }
        private void cmdRecherche_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                RemplirComboClient(txtRecherche.Text);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixClient", "cmdRecherche_Click", ex);
            }
        }
        [Obsolete]
        private void ChoixClient_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                RemplirComboClient(string.Empty);
                if (Facturation.m_bModifClient == true)
                {
                    for (int X = 0; X <= (cmbClient.Items.Count - 1); X++)
                    {
                        if (cmbClient.Items[X].ToString() == Facturation.IDClient)
                        {
                            cmbClient.SelectedIndex = X; break;
                        }
                    }
                    txtDescription.Text = Facturation.Description;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixClient", "Form_Load", ex);
            }
        }
        private void RemplirComboClient(string sRecherche)
        {
            try
            {
                // Remplir le combo des clients
                ADODB.Recordset rstClient;

                cmbClient.Items.Clear();
                rstClient = new Recordset();
                if (string.IsNullOrEmpty(Strings.Trim(sRecherche)))
                {
                    rstClient.Open("SELECT NomClient, IDClient FROM Client WHERE Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else if (Strings.InStr(1, sRecherche, "'") > 0)
                {
                    rstClient.Open("SELECT NomClient, IDClient FROM Client WHERE NomClient LIKE '%" + Strings.Replace(sRecherche, "'", "''") + "%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstClient.Open("SELECT NomClient, IDClient FROM Client WHERE NomClient, 'like %" + sRecherche + "%' AND Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }

                while (!rstClient.EOF)
                {
                    cmbClient.Items.Add(rstClient.Fields["NomClient"].Value);
                    cmbClient.Tag = rstClient.Fields["IDClient"].Value;
                    rstClient.MoveNext();
                }
                rstClient.Close();
                // Object rstClient peut ne pas etre détruit avant la mise en corbeille
                rstClient = null;
                // Si le combo n'est pas vide, on sélectionne le premier
                if (cmbClient.Items.Count > 0)
                {
                    cmbClient.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixClient", "RemplirComboClient", ex);
            }
        }
    }
}