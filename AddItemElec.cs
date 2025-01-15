using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    public  class AddItemElec : Form
    {
        internal ToolTip ToolTip1;
        internal ComboBox cmbCategorie;
        internal Button cmdOk;
        internal Button cmdAnnuler;
        internal TextBox txtNoItem;
        internal ComboBox cmbFabricant;
        internal Label Label4;
        internal Label Label2;
        internal Label Label3;
        internal Label Label1;
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.txtNoItem = new System.Windows.Forms.TextBox();
            this.cmbFabricant = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.BackColor = System.Drawing.Color.White;
            this.cmbCategorie.ForeColor = System.Drawing.Color.Navy;
            this.cmbCategorie.Location = new System.Drawing.Point(155, 128);
            this.cmbCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCategorie.Size = new System.Drawing.Size(130, 22);
            this.cmbCategorie.Sorted = true;
            this.cmbCategorie.TabIndex = 0;
            this.cmbCategorie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbCategorie_KeyUp);
            // 
            // cmdOk
            // 
            this.cmdOk.BackColor = System.Drawing.Color.Black;
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOk.ForeColor = System.Drawing.Color.Navy;
            this.cmdOk.Location = new System.Drawing.Point(216, 214);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOk.Size = new System.Drawing.Size(69, 28);
            this.cmdOk.TabIndex = 3;
            this.cmdOk.Text = "Ajouter";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.BackColor = System.Drawing.Color.Black;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAnnuler.ForeColor = System.Drawing.Color.Navy;
            this.cmdAnnuler.Location = new System.Drawing.Point(281, 214);
            this.cmdAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAnnuler.Size = new System.Drawing.Size(69, 28);
            this.cmdAnnuler.TabIndex = 4;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // txtNoItem
            // 
            this.txtNoItem.AcceptsReturn = true;
            this.txtNoItem.BackColor = System.Drawing.Color.White;
            this.txtNoItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoItem.ForeColor = System.Drawing.Color.Navy;
            this.txtNoItem.Location = new System.Drawing.Point(155, 154);
            this.txtNoItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoItem.MaxLength = 37;
            this.txtNoItem.Name = "txtNoItem";
            this.txtNoItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoItem.Size = new System.Drawing.Size(130, 22);
            this.txtNoItem.TabIndex = 1;
            // 
            // cmbFabricant
            // 
            this.cmbFabricant.BackColor = System.Drawing.Color.White;
            this.cmbFabricant.ForeColor = System.Drawing.Color.Navy;
            this.cmbFabricant.Location = new System.Drawing.Point(155, 180);
            this.cmbFabricant.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFabricant.Name = "cmbFabricant";
            this.cmbFabricant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbFabricant.Size = new System.Drawing.Size(130, 22);
            this.cmbFabricant.Sorted = true;
            this.cmbFabricant.TabIndex = 2;
            this.cmbFabricant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFabricant_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Black;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(71, 128);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(111, 14);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "CatégorieFournisseur";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(71, 154);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(85, 14);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Numero d\'item:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(71, 180);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(77, 14);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Manufacturier";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(58, 58);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(270, 68);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Veuillez entrez un numero d\'item et ensuite choisir un manufacturier parmis ceux " +
    "dans la liste déroulante (vous pouvez en ajouter un qui ne figure pas déjà dans " +
    "la liste)";
            // 
            // AddItemElec
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(361, 251);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.txtNoItem);
            this.Controls.Add(this.cmbFabricant);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(238, 216);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemElec";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.AddItemElec";
            this.Load += new System.EventHandler(this.AddItemElec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        public AddItemElec()
        {
            InitializeComponent();
        }
        private void cmbCategorie_KeyUp(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                for (int X = 0; X <= (cmbCategorie.Items.Count - 1); X++)
                {
                    if ((cmbCategorie.Items[X].ToString().ToUpper() ?? "") == (cmbCategorie.Text.ToUpper() ?? ""))
                    {
                        cmbCategorie.SelectedIndex = (int)X;
                        break;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("AddItemElec", Application.ProductName, ex);
            }
        }
        private void cmbFabricant_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = eventArgs.KeyChar;
            if (KeyAscii <= 122 & KeyAscii >= 97) { KeyAscii = (int)(KeyAscii - 32); }
            if (KeyAscii == 0) { eventArgs.Handled = true; }
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
                AfficherErreur("AddItemElec", Application.ProductName, ex);
            }
        }
        private void AddItemElec_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                RemplirComboCategorie();
                RemplirComboManufacturier();
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("AddItemElec", "", ex);
            }
        }
        private void RemplirComboCategorie()
        {
            try
            {
                ADODB.Recordset rstCatalogueElec;
                cmbCategorie.Items.Clear();
                rstCatalogueElec = new Recordset();
                rstCatalogueElec.Open("SELECT DISTINCT CATEGORIE FROM CatalogueElec ORDER BY Categorie", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstCatalogueElec.EOF)
                {
                    cmbCategorie.Items.Add(rstCatalogueElec.Fields["CATEGORIE"].Value);
                    rstCatalogueElec.MoveNext();
                }
                rstCatalogueElec.Close();
                rstCatalogueElec = default;
                if (cmbCategorie.Items.Count > 0)
                {
                    cmbCategorie.Text = cmbCategorieText;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("AddItemElec", "RemplirComboCategorie", ex);
            }
        }
        private void RemplirComboManufacturier()
        {
            try
            {
                ADODB.Recordset rstManufacturier = new ADODB.Recordset();
                rstManufacturier.Open("SELECT DISTINCT FABRICANT FROM CatalogueElec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstManufacturier.EOF)
                {
                    if (!(rstManufacturier.Fields["FABRICANT"].Value is DBNull))
                    {
                        cmbFabricant.Items.Add(rstManufacturier.Fields["FABRICANT"].Value);
                    }
                    rstManufacturier.MoveNext();
                }
                rstManufacturier.Close();
                rstManufacturier = default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("addItemElec", "RemplirComboManufacturier", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstItem = new Recordset();
                ADODB.Recordset rstFRS;
                ADODB.Recordset rstPieceFRS;
                int X;
                int iFRS;
                var sPieceModif = default(string);
                char sLettre;
                if (txtNoItem.Text!=string.Empty)
                {
                    if (cmbFabricant.Text != string.Empty)
                    {
                        if (cmbCategorie.Text != string.Empty)
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            rstItem.Open("SELECT * FROM CatalogueElec WHERE PIECE = '" + txtNoItem.Text.Replace("'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (!rstItem.EOF)
                            {
                                MessageBox.Show("Attention! L'item # " + txtNoItem.Text + " existe déjà!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                rstItem.Close();
                                rstItem = default;
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                rstItem.AddNew();
                                rstItem.Fields["CATEGORIE"].Value = cmbCategorie.Text;
                                rstItem.Fields["FABRICANT"].Value = cmbFabricant.Text;
                                rstItem.Fields["PIECE"].Value = txtNoItem.Text;
                                  rstItem.Fields["PIECE_MODIF"].Value = txtNoItem.Text;
                                rstItem.Fields["PIECE_GRB"].Value = txtNoItem.Text + "GRB";
                                rstItem.Fields["TEMPS"].Value = 0;
                                rstItem.Update();
                                rstItem.Close();
                                rstItem = default;
                               rstFRS = new Recordset();
                                rstFRS.Open("SELECT * FROM Fournisseur WHERE NomFournisseur = 'FOURNI PAR LE CLIENT'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                iFRS = (int)rstFRS.Fields["IDFRS"].Value; //ID 746
                                rstFRS.Close();
                                rstFRS = default;
                                rstPieceFRS = new Recordset();
                                rstPieceFRS.Open("SELECT * FROM PiecesFRS", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                rstPieceFRS.AddNew();
                                rstPieceFRS.Fields["IDFRS"].Value = iFRS;
                                rstPieceFRS.Fields["PIECE"].Value = txtNoItem.Text.Trim();
                                rstPieceFRS.Fields["PERS_RESS"].Value =IdNomEmploye;
                                rstPieceFRS.Fields["PRIX_LIST"].Value = "0.00";
                                rstPieceFRS.Fields["ESCOMPTE"].Value = false;
                                rstPieceFRS.Fields["PRIX_NET"].Value = "0.00";
                                rstPieceFRS.Fields["DATE"].Value = ConvertDate(DateTime.Today);
                                rstPieceFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                                rstPieceFRS.Fields["DeviseMonétaire"].Value = "CAN";
                                rstPieceFRS.Fields["Type"].Value = "E";
                                rstPieceFRS.Update();
                               rstPieceFRS.AddNew();
                                rstPieceFRS.Fields["IDFRS"].Value = 717;
                                rstPieceFRS.Fields["PIECE"].Value = txtNoItem.Text.Trim();
                                rstPieceFRS.Fields["PRIX_LIST"].Value = 0;
                                rstPieceFRS.Fields["ESCOMPTE"].Value = 0;
                                rstPieceFRS.Fields["PRIX_NET"].Value = 0;
                                rstPieceFRS.Fields["DATE"].Value = ConvertDate(DateTime.Today);
                                rstPieceFRS.Fields["ENTRER_PAR"].Value = Conteneur.idInitiales.Text;
                                rstPieceFRS.Fields["DeviseMonétaire"].Value = "CAN";
                                rstPieceFRS.Fields["Type"].Value = "E";
                                rstPieceFRS.Update();
                                rstPieceFRS.Close();
                                rstPieceFRS = default;
                   /*              m_sSelectCategorie = cmbCategorie.Text;
                                m_sSelectFabricant = cmbFabricant.Text;
                                m_sSelectNoItem = txtNoItem.Text;*/
                                RemplirComboCategorie();
                                txtNoItemGRB = txtNoItem.Text + "GRB";
                                txtDescriptionFRText = "";
                                Close();
                            }
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Vous devez remplir tous les champs", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("addItemElec", "cmdOK_Click", ex);
            }
        }
    }
}