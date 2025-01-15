using System;
using System.Diagnostics;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class CategorieClient : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public CategorieClient() : base() => InitializeComponent();
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
        internal static CheckBox chkProduitsChimiques;
        internal static CheckBox chkICPI;
        internal static CheckBox chkAsphalte;
        internal static CheckBox chkConsultant;
        internal static CheckBox chkBeton;
        internal static CheckBox chkPave;
        internal static CheckBox chkPharmaceutique;
        internal static CheckBox chkMeuble;
        internal static CheckBox chkMeunerie;
        internal static CheckBox chkAgroalimentaire;
        internal static CheckBox chkManufacturier;
        internal static CheckBox chkAutre;
        internal static Panel fraCategories;
        internal static Button cmdFermer;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            fraCategories = new System.Windows.Forms.Panel();
            chkProduitsChimiques = new System.Windows.Forms.CheckBox();
            chkICPI = new System.Windows.Forms.CheckBox();
            chkAsphalte = new System.Windows.Forms.CheckBox();
            chkConsultant = new System.Windows.Forms.CheckBox();
            chkBeton = new System.Windows.Forms.CheckBox();
            chkPave = new System.Windows.Forms.CheckBox();
            chkPharmaceutique = new System.Windows.Forms.CheckBox();
            chkMeuble = new System.Windows.Forms.CheckBox();
            chkMeunerie = new System.Windows.Forms.CheckBox();
            chkAgroalimentaire = new System.Windows.Forms.CheckBox();
            chkManufacturier = new System.Windows.Forms.CheckBox();
            chkAutre = new System.Windows.Forms.CheckBox();
            cmdFermer = new System.Windows.Forms.Button();
            fraCategories.SuspendLayout();
            SuspendLayout();
            // 
            // fraCategories
            // 
            fraCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            fraCategories.Controls.Add(chkProduitsChimiques);
            fraCategories.Controls.Add(chkICPI);
            fraCategories.Controls.Add(chkAsphalte);
            fraCategories.Controls.Add(chkConsultant);
            fraCategories.Controls.Add(chkBeton);
            fraCategories.Controls.Add(chkPave);
            fraCategories.Controls.Add(chkPharmaceutique);
            fraCategories.Controls.Add(chkMeuble);
            fraCategories.Controls.Add(chkMeunerie);
            fraCategories.Controls.Add(chkAgroalimentaire);
            fraCategories.Controls.Add(chkManufacturier);
            fraCategories.Controls.Add(chkAutre);
            fraCategories.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraCategories.Location = new System.Drawing.Point(73, 66);
            fraCategories.Name = "fraCategories";
            fraCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraCategories.Size = new System.Drawing.Size(198, 304);
            fraCategories.TabIndex = 1;
            // 
            // chkProduitsChimiques
            // 
            chkProduitsChimiques.AutoSize = true;
            chkProduitsChimiques.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkProduitsChimiques.ForeColor = System.Drawing.Color.White;
            chkProduitsChimiques.Location = new System.Drawing.Point(18, 253);
            chkProduitsChimiques.Name = "chkProduitsChimiques";
            chkProduitsChimiques.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkProduitsChimiques.Size = new System.Drawing.Size(138, 20);
            chkProduitsChimiques.TabIndex = 13;
            chkProduitsChimiques.Text = "Produits chimiques";
            chkProduitsChimiques.UseVisualStyleBackColor = true;
            // 
            // chkICPI
            // 
            chkICPI.AutoSize = true;
            chkICPI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkICPI.ForeColor = System.Drawing.Color.White;
            chkICPI.Location = new System.Drawing.Point(18, 229);
            chkICPI.Name = "chkICPI";
            chkICPI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkICPI.Size = new System.Drawing.Size(51, 20);
            chkICPI.TabIndex = 12;
            chkICPI.Text = "ICPI";
            chkICPI.UseVisualStyleBackColor = true;
            // 
            // chkAsphalte
            // 
            chkAsphalte.AutoSize = true;
            chkAsphalte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkAsphalte.ForeColor = System.Drawing.Color.White;
            chkAsphalte.Location = new System.Drawing.Point(18, 205);
            chkAsphalte.Name = "chkAsphalte";
            chkAsphalte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkAsphalte.Size = new System.Drawing.Size(78, 20);
            chkAsphalte.TabIndex = 11;
            chkAsphalte.Text = "Asphalte";
            chkAsphalte.UseVisualStyleBackColor = true;
            // 
            // chkConsultant
            // 
            chkConsultant.AutoSize = true;
            chkConsultant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkConsultant.ForeColor = System.Drawing.Color.White;
            chkConsultant.Location = new System.Drawing.Point(18, 181);
            chkConsultant.Name = "chkConsultant";
            chkConsultant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkConsultant.Size = new System.Drawing.Size(89, 20);
            chkConsultant.TabIndex = 10;
            chkConsultant.Text = "Consultant";
            chkConsultant.UseVisualStyleBackColor = true;
            // 
            // chkBeton
            // 
            chkBeton.AutoSize = true;
            chkBeton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkBeton.ForeColor = System.Drawing.Color.White;
            chkBeton.Location = new System.Drawing.Point(18, 14);
            chkBeton.Name = "chkBeton";
            chkBeton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkBeton.Size = new System.Drawing.Size(61, 20);
            chkBeton.TabIndex = 9;
            chkBeton.Text = "Béton";
            chkBeton.UseVisualStyleBackColor = true;
            // 
            // chkPave
            // 
            chkPave.AutoSize = true;
            chkPave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkPave.ForeColor = System.Drawing.Color.White;
            chkPave.Location = new System.Drawing.Point(18, 38);
            chkPave.Name = "chkPave";
            chkPave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkPave.Size = new System.Drawing.Size(55, 20);
            chkPave.TabIndex = 8;
            chkPave.Text = "Pavé";
            chkPave.UseVisualStyleBackColor = true;
            // 
            // chkPharmaceutique
            // 
            chkPharmaceutique.AutoSize = true;
            chkPharmaceutique.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkPharmaceutique.ForeColor = System.Drawing.Color.White;
            chkPharmaceutique.Location = new System.Drawing.Point(18, 62);
            chkPharmaceutique.Name = "chkPharmaceutique";
            chkPharmaceutique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkPharmaceutique.Size = new System.Drawing.Size(121, 20);
            chkPharmaceutique.TabIndex = 7;
            chkPharmaceutique.Text = "Pharmaceutique";
            chkPharmaceutique.UseVisualStyleBackColor = true;
            // 
            // chkMeuble
            // 
            chkMeuble.AutoSize = true;
            chkMeuble.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkMeuble.ForeColor = System.Drawing.Color.White;
            chkMeuble.Location = new System.Drawing.Point(18, 110);
            chkMeuble.Name = "chkMeuble";
            chkMeuble.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkMeuble.Size = new System.Drawing.Size(69, 20);
            chkMeuble.TabIndex = 6;
            chkMeuble.Text = "Meuble";
            chkMeuble.UseVisualStyleBackColor = true;
            // 
            // chkMeunerie
            // 
            chkMeunerie.AutoSize = true;
            chkMeunerie.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkMeunerie.ForeColor = System.Drawing.Color.White;
            chkMeunerie.Location = new System.Drawing.Point(18, 134);
            chkMeunerie.Name = "chkMeunerie";
            chkMeunerie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkMeunerie.Size = new System.Drawing.Size(166, 20);
            chkMeunerie.TabIndex = 5;
            chkMeunerie.Text = "Meunerie, grain, engrais";
            chkMeunerie.UseVisualStyleBackColor = true;
            // 
            // chkAgroalimentaire
            // 
            chkAgroalimentaire.AutoSize = true;
            chkAgroalimentaire.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkAgroalimentaire.ForeColor = System.Drawing.Color.White;
            chkAgroalimentaire.Location = new System.Drawing.Point(18, 86);
            chkAgroalimentaire.Name = "chkAgroalimentaire";
            chkAgroalimentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkAgroalimentaire.Size = new System.Drawing.Size(117, 20);
            chkAgroalimentaire.TabIndex = 4;
            chkAgroalimentaire.Text = "Agroalimentaire";
            chkAgroalimentaire.UseVisualStyleBackColor = true;
            // 
            // chkManufacturier
            // 
            chkManufacturier.AutoSize = true;
            chkManufacturier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkManufacturier.ForeColor = System.Drawing.Color.White;
            chkManufacturier.Location = new System.Drawing.Point(18, 157);
            chkManufacturier.Name = "chkManufacturier";
            chkManufacturier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkManufacturier.Size = new System.Drawing.Size(105, 20);
            chkManufacturier.TabIndex = 3;
            chkManufacturier.Text = "Manufacturier";
            chkManufacturier.UseVisualStyleBackColor = true;
            // 
            // chkAutre
            // 
            chkAutre.AutoSize = true;
            chkAutre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkAutre.ForeColor = System.Drawing.Color.White;
            chkAutre.Location = new System.Drawing.Point(18, 277);
            chkAutre.Name = "chkAutre";
            chkAutre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkAutre.Size = new System.Drawing.Size(58, 20);
            chkAutre.TabIndex = 2;
            chkAutre.Text = "Autre";
            chkAutre.UseVisualStyleBackColor = true;
            // 
            // cmdFermer
            // 
            cmdFermer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            cmdFermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdFermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdFermer.Location = new System.Drawing.Point(210, 376);
            cmdFermer.Name = "cmdFermer";
            cmdFermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdFermer.Size = new System.Drawing.Size(89, 33);
            cmdFermer.TabIndex = 0;
            cmdFermer.Text = "Fermer";
            cmdFermer.UseVisualStyleBackColor = true;
            cmdFermer.Click += new System.EventHandler(cmdFermer_Click);
            // 
            // CategorieClient
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(311, 421);
            ControlBox = false;
            Controls.Add(fraCategories);
            Controls.Add(cmdFermer);
            Location = new System.Drawing.Point(4, 30);
            MaximizeBox = false;
            Name = "CategorieClient";
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
            Load += new System.EventHandler(CategorieClient_Load);
            fraCategories.ResumeLayout(false);
            fraCategories.PerformLayout();
            ResumeLayout(false);

        }
        #endregion
        private enum enumTypeOuverture
        {
            CLIENT = 0,
            IMPRESSION = 1
        }
        private enumTypeOuverture m_eOuverture;
        private int iNoClient;
        private string NomClient;
        /// <summary>
        /// implentation pour la routine SaveOnClose inexistante avant
        //Ajout pour patch PWE 2024-08-05
        public CategorieClient(int iNoClient, string text)
        {
            InitializeComponent();
            iNoClient = iNoClient;
            NomClient = text;
        }
        //Ajout PWE 2024-08-05
        private void EnregistrerModificaztions()
        {
            try
            {
                ADODB.Recordset rstClient = new ADODB.Recordset();
                rstClient.Open("SELECT * FROM Client WHERE IDClient = " + iNoClient, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstClient.Fields["DateModification"].Value = ConvertDate(DateTime.Today);
                rstClient.Fields["UserModification"].Value = Conteneur.idInitiales.Text;
                rstClient.Fields["Béton"].Value = chkBeton.Checked;
                rstClient.Fields["Pavé"].Value = chkPave.Checked;
                rstClient.Fields["Pharmaceutique"].Value = chkPharmaceutique.Checked;
                rstClient.Fields["Agroalimentaire"].Value = chkAgroalimentaire.Checked;
                rstClient.Fields["Meuble"].Value = chkMeuble.Checked;
                rstClient.Fields["Meunerie"].Value = chkMeunerie.Checked;
                rstClient.Fields["Manufacturier"].Value = chkManufacturier.Checked;
                rstClient.Fields["Consultant"].Value = chkConsultant.Checked;
                rstClient.Fields["Asphalte"].Value = chkAsphalte.Checked;
                rstClient.Fields["ICPI"].Value = chkICPI.Checked;
                rstClient.Fields["ProduitsChimiques"].Value = chkProduitsChimiques.Checked;
                rstClient.Fields["Autre"].Value = chkAutre.Checked;
                rstClient.Update();
                rstClient.Close();
                rstClient = null;
            }
            catch (Exception ex)
            {
                AfficherErreur("CategorieClient", "EnregistrerModifCat", ex);
            }
        }
        //Patch PWE 2024-08-05
        private void cmdFermer_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                /// se serevir des controles directement vu qu'ils sont deja bool
                if (m_eOuverture == enumTypeOuverture.CLIENT)
                {
                    Client.m_bCategorieBeton = chkBeton.Checked;
                    Client.m_bCategoriePave = chkPave.Checked;
                    Client.m_bCategoriePharmaceutique = chkPharmaceutique.Checked;
                    Client.m_bCategorieAgroalimentaire = chkAgroalimentaire.Checked;
                    Client.m_bCategorieMeuble = chkMeuble.Checked;
                    Client.m_bCategorieMeunerie = chkMeunerie.Checked;
                    Client.m_bCategorieManufacturier = chkManufacturier.Checked;
                    Client.m_bCategorieConsultant = chkConsultant.Checked;
                    Client.m_bCategorieProduitsChimiques = chkAsphalte.Checked;
                    Client.m_bCategorieAutre = chkAutre.Checked;
                }
                else
                {
                    Client.m_bImpressionBeton = chkBeton.Checked;
                    Client.m_bImpressionBeton = false;
                    Client.m_bImpressionPave = chkPave.Checked;
                    Client.m_bImpressionPharmaceutique = chkPharmaceutique.Checked;
                    Client.m_bImpressionPharmaceutique = false;
                    Client.m_bImpressionAgroAlimentaire = chkAgroalimentaire.Checked;
                    Client.m_bImpressionMeuble = chkMeuble.Checked;
                    Client.m_bImpressionMeunerie = chkMeunerie.Checked;
                    Client.m_bImpressionManufacturier = chkManufacturier.Checked;
                    Client.m_bImpressionConsultant = chkConsultant.Checked;
                    Client.m_bImpressionAsphalte = chkAsphalte.Checked;
                    Client.m_bImpressionAsphalte = false;
                    Client.m_bImpressionICPI = chkICPI.Checked;
                    Client.m_bImpressionProduitsChimiques = chkProduitsChimiques.Checked;
                    Client.m_bImpressionAutre = chkAutre.Checked;
                }
                EnregistrerModificaztions();
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CategorieClient", "cmdFermer_Click", ex);
            }
        }
        /// modification pour exploiter diretement les control en boolean
        //Patch PWE 2024-08-05
        public void AfficherClient()
        {
            try
            {
                cmdFermer.Text = "Fermer";
                chkBeton.Checked = Client.m_bCategorieBeton;
                chkPave.Checked = Client.m_bCategoriePave;
                chkPharmaceutique.Checked = Client.m_bCategoriePharmaceutique;
                chkAgroalimentaire.Checked = Client.m_bCategorieAgroalimentaire;
                chkMeuble.Checked = Client.m_bCategorieMeuble;
                chkMeunerie.Checked = Client.m_bCategorieMeunerie;
                chkManufacturier.Checked = Client.m_bCategorieManufacturier;
                chkConsultant.Checked = Client.m_bCategorieConsultant;
                chkAsphalte.Checked = Client.m_bCategorieAsphalte;
                chkICPI.Checked = Client.m_bCategorieICPI;
                chkProduitsChimiques.Checked = Client.m_bCategorieProduitsChimiques;
                chkAutre.Checked = Client.m_bCategorieAutre;
                m_eOuverture = enumTypeOuverture.CLIENT;
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CategorieClient", "AfficherClient", ex);
            }
        }
        /// décocher les controles en vue de l'impression
		//Patch PWE 2024-08-05
        public void AfficherImpression()
        {
            try
            {
                cmdFermer.Text = "Imprimer";
                chkBeton.Checked = false; ;
                chkPave.Checked = false; ;
                chkPharmaceutique.Checked = false; ;
                chkAgroalimentaire.Checked = false; ;
                chkMeuble.Checked = false; ;
                chkMeunerie.Checked = false; ;
                chkManufacturier.Checked = false; ;
                chkConsultant.Checked = false; ;
                chkAsphalte.Checked = false; ;
                chkICPI.Checked = false; ;
                chkProduitsChimiques.Checked = false; ;
                chkAutre.Checked = false; ;
                m_eOuverture = enumTypeOuverture.IMPRESSION;
                Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("CategorieClient", "AfficherImpression", ex);
            }
        }
        private void CategorieClient_Load(object sender, EventArgs e)
        {
            AfficherClient(); // ajout pour garder les catégories d'origine du client sans interférer avec la fonction Client.CmdAdd_Click
        }
    }
}