using System;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class ChoixLocalisation : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ChoixLocalisation() : base()
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
        internal static ComboBox cmbLocalisation;
        internal static Button cmdOK;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmbLocalisation = new System.Windows.Forms.ComboBox();
            cmdOK = new System.Windows.Forms.Button();
            SuspendLayout();//cmbLocalisation
            cmbLocalisation.BackColor = System.Drawing.Color.Black;
            cmbLocalisation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbLocalisation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbLocalisation.ForeColor = System.Drawing.Color.White;
            cmbLocalisation.Location = new System.Drawing.Point(6, 73);
            cmbLocalisation.Name = "cmbLocalisation";
            cmbLocalisation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbLocalisation.Size = new System.Drawing.Size(241, 22);
            cmbLocalisation.TabIndex = 1;//cmdOK
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(182, 123);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(65, 25);
            cmdOK.TabIndex = 2;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);//ChoixLocalisation
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(259, 160);
            Controls.Add(cmbLocalisation);
            Controls.Add(cmdOK);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ChoixLocalisation";
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
        }
        #endregion
        private EnumCatalogue m_eCatalogue;
        private EnumCatalogue eLECTRIQUE;
        public ChoixLocalisation(EnumCatalogue eLECTRIQUE, string text)
        {
            eLECTRIQUE = eLECTRIQUE;
            Text = text;
        }
        public void Afficher(EnumCatalogue eCatalogue, string sNoPiece)
        {
            try
            {
                m_eCatalogue = eCatalogue;
                RemplirComboLocalisation();
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixLocalisation", "Afficher", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                g_sLocalisation = cmbLocalisation.Text;
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixLocalisation", "cmdOK_Click", ex);
            }
        }
        private void RemplirComboLocalisation()
        {
            try
            {
                // Remplir le combo des localisations
                ADODB.Recordset rstInv;

                cmbLocalisation.Items.Clear();
                cmbLocalisation.Items.Add("");
                rstInv = new Recordset();
                if (m_eCatalogue == EnumCatalogue.ELECTRIQUE)
                {
                    rstInv.Open("SELECT DISTINCT Localisation FROM InventaireElec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                else
                {
                    rstInv.Open("SELECT DISTINCT Localisation FROM InventaireMec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }

                while (!rstInv.EOF)
                {
                    if (!string.IsNullOrEmpty(Strings.Trim((string)(rstInv.Fields["Localisation"].Value))))
                    {
                        cmbLocalisation.Items.Add(rstInv.Fields["Localisation"].Value);
                    }
                    rstInv.MoveNext();
                }
                rstInv.Close();
                rstInv = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ChoixLocalisation", "RemplirComboContactFRS", ex);
            }
        }
    }
}