
using ADODB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal  class AjoutDL : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public AjoutDL() : base()
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
        internal Button cmdExceptions;
        internal GroupBox fraChoixListe;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        internal Button cmdCreer;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdExceptions = new System.Windows.Forms.Button();
            this.fraChoixListe = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdCreer = new System.Windows.Forms.Button();
            this.fraChoixListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdExceptions
            // 
            this.cmdExceptions.AutoSize = true;
            this.cmdExceptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdExceptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdExceptions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExceptions.Location = new System.Drawing.Point(252, 251);
            this.cmdExceptions.Name = "cmdExceptions";
            this.cmdExceptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdExceptions.Size = new System.Drawing.Size(138, 24);
            this.cmdExceptions.TabIndex = 16;
            this.cmdExceptions.Text = "Liste des exceptions ..";
            this.cmdExceptions.UseVisualStyleBackColor = true;
            this.cmdExceptions.Click += new System.EventHandler(this.cmdExceptions_Click);
            // 
            // fraChoixListe
            // 
            this.fraChoixListe.Controls.Add(this.cmdExceptions);
            this.fraChoixListe.Controls.Add(this.button6);
            this.fraChoixListe.Controls.Add(this.button5);
            this.fraChoixListe.Controls.Add(this.cmdCreer);
            this.fraChoixListe.Controls.Add(this.button4);
            this.fraChoixListe.Controls.Add(this.button3);
            this.fraChoixListe.Controls.Add(this.button2);
            this.fraChoixListe.Controls.Add(this.button1);
            this.fraChoixListe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraChoixListe.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.fraChoixListe.Location = new System.Drawing.Point(12, 51);
            this.fraChoixListe.Name = "fraChoixListe";
            this.fraChoixListe.Padding = new System.Windows.Forms.Padding(0);
            this.fraChoixListe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraChoixListe.Size = new System.Drawing.Size(408, 297);
            this.fraChoixListe.TabIndex = 4;
            this.fraChoixListe.TabStop = false;
            this.fraChoixListe.Text = "Choix de la liste";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.ForeColor = System.Drawing.Color.DarkBlue;
            this.button6.Location = new System.Drawing.Point(16, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(374, 27);
            this.button6.TabIndex = 21;
            this.button6.Text = "Tous les membres du groupement des chefs d\'entreprise";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.ForeColor = System.Drawing.Color.DarkBlue;
            this.button5.Location = new System.Drawing.Point(16, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(374, 27);
            this.button5.TabIndex = 20;
            this.button5.Text = "Tous les membres du Meat Processing";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(16, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(374, 27);
            this.button4.TabIndex = 19;
            this.button4.Text = "Tous les clients facturés";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(16, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(374, 27);
            this.button3.TabIndex = 18;
            this.button3.Text = "Tous les clients";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(16, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(374, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "Tous les fournisseurs";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tous les contacts";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCreer
            // 
            this.cmdCreer.AutoSize = true;
            this.cmdCreer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCreer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreer.Location = new System.Drawing.Point(142, 251);
            this.cmdCreer.Name = "cmdCreer";
            this.cmdCreer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCreer.Size = new System.Drawing.Size(104, 25);
            this.cmdCreer.TabIndex = 0;
            this.cmdCreer.Text = "Créer la liste";
            this.cmdCreer.UseVisualStyleBackColor = true;
            this.cmdCreer.Click += new System.EventHandler(this.cmdCreer_Click);
            // 
            // AjoutDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(434, 370);
            this.Controls.Add(this.fraChoixListe);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.Location = new System.Drawing.Point(11, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjoutDL";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création des listes de distribution";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AjoutDL_FormClosed);
            this.Load += new System.EventHandler(this.AjoutDL_Load);
            this.fraChoixListe.ResumeLayout(false);
            this.fraChoixListe.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private ADODB.Recordset m_rstData;
        private const int I_OPT_CONTACTS = 0;
        private const int I_OPT_CLIENTS = 1;
        private const int I_OPT_CLIENTS_FACTURES = 2;
        private const int I_OPT_FRS = 3;
        private const int I_OPT_GROUPEMENT = 4;
        private const int I_OPT_MEAT_PROCESSING = 5;
        private const int I_OPT_DOSSIER_CONTACTS = 0;
        private const int I_OPT_DOSSIER_CLIENTS = 1;
        private const int I_OPT_DOSSIER_FRS = 2;
        private Microsoft.Office.Interop.Outlook.Application m_otlApp;
        private bool m_bDejaOuvert;
        internal static System.Collections.Generic.List<string> m_arr_sException = new System.Collections.Generic.List<string>();
      private bool CreerTable()
        {
            try
            {
                object sortie;
                string sql = "IF  EXISTS(SELECT * FROM SYS.OBJECTS WHERE OBJECT_ID = OBJECT_ID(N'[DBO].[LISTEDISTRIBUTION]') AND TYPE IN (N'U'))" +
                    "\nDROP TABLE[DBO].[LISTEDISTRIBUTION]" +
                    "\nSET ANSI_NULLS ON" +
                    "\nSET QUOTED_IDENTIFIER ON";
                odbc.Execute(sql, out sortie, -1);
                sql = "\nCREATE TABLE[dbo].[ListeDistribution](" +
                    "\n[ID][int] primary key IDENTITY(1, 1) NOT NULL," +
                    "\n[NoContact] [int]  NOT NULL," +
                    "\n[Contact] [nvarchar](200) NOT NULL," +
                    "\n[NomCompagnie] [nvarchar](200) NOT NULL," +
                    "\n[EMail] [nvarchar](200) NOT NULL," +
                    "\n[isContact] [bit] NOT NULL," +
                    "\n[isClient] [bit] NOT NULL," +
                    "\n[isFournisseur] [bit] NOT NULL," +
                    "\n[isChefEntreprise] [bit] NOT NULL," +
                    "\n[isMeatProcessing] [bit] NOT NULL) ON[PRIMARY]";
                odbc.Execute(sql, out sortie, -1);
                return true;
            }catch(Exception ex){ AfficherErreur(Name, "CreerTable", ex); return false; }
        }
        private void ImporterContacts()
        {
            object sortie;
            odbc.Execute("INSERT INTO [AUTOGRB].[DBO].[LISTEDISTRIBUTION]SELECT [IDCONTACT],NOMCONTACT,[COMPAGNIE],[E-MAIL],1,0,0,0,0  FROM [DBO].[CONTACT] " +
                "WHERE LOWER(TRIM([E-MAIL])) !='' AND COMPAGNIE!='' " +
                "ORDER BY COMPAGNIE,NOMCONTACT ASC", out sortie, -1);
            Conteneur.txtStatus.Text = $"{sortie.ToString()} entrées ont étées inscrites dans la table de distribution";
        }
        private void IdentifierClient()
        {
            Recordset rds = new Recordset();
            object sortie;
            rds.Open("SELECT *  [DBO].[CLIENT] " +
                 "JOIN[DBO].[CONTACTCLIENT] ON CLIENT.IDCLIENT = CONTACTCLIENT.NOCLIENT " +
                 "FULL JOIN[DBO].[CONTACT] ON[DBO].[CONTACTCLIENT].NOCONTACT =[DBO].[CONTACT].IDCONTACT ", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            while (!rds.EOF)
            {
                odbc.Execute($"UPDATE [DBO].[LISTEDISTRIBUTION] SET ISCLIENT=1  WHERE [DBO].[LISTEDISTRIBUTION].NOCONTACT={rds.Fields[0].Value}", out sortie, -1);
                rds.MoveNext();
            }
            rds.Close();
            rds = null;
        }
        private void IdentifierFournisseur()
        {
            Recordset rds = new Recordset();
            object sortie;
            rds.Open("SELECT *  [DBO].[FOURNISSEUR]  " +
                "JOIN[DBO].[CONTACTFRS] ON[DBO].[CONTACTFRS].NOFRS = [DBO].[FOURNISSEUR].IDFRS " +
                "FULL JOIN[DBO].[CONTACT] ON[DBO].[CONTACTFRS].NOCONTACT =[DBO].[CONTACT].IDCONTACT " +
                "WHERE[DBO].[FOURNISSEUR].IDFRS != '' " +
                "ORDER BY NOMFOURNISSEUR", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            while (!rds.EOF)
            {
                odbc.Execute($"UPDATE [DBO].[LISTEDISTRIBUTION] SET ISFOURNISSEUR=1  WHERE [DBO].[LISTEDISTRIBUTION].NOCONTACT={rds.Fields[0].Value}", out sortie, -1);
                rds.MoveNext();
            }
            rds.Close();
            rds = null;
        }
        private void IdentifierChefEntreprise()
        {
            Object sortie;
            ADODB.Recordset rstData;
            rstData = new Recordset();
            rstData.CursorLocation = CursorLocationEnum.adUseClient;
            rstData.Open("SELECT IDCONTACT, [E-MAIL], IDCLIENT, EMAIL  (CONTACTCLIENT " +
                "INNER JOIN CLIENT ON CONTACTCLIENT.NOCLIENT = CLIENT.IDCLIENT) " +
                "INNER JOIN CONTACT ON CONTACTCLIENT.NOCONTACT = CONTACT.IDCONTACT " +
                "WHERE TITRE LIKE '%GROUPEMENT DES CHEFS%' AND([E-MAIL] <> '' OR EMAIL<> '') " +
                "ORDER BY CONTACT.NOMCONTACT", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly, -1);
            while (!rstData.EOF)
            {
                odbc.Execute($"update [dbo].[LISTEDISTRIBUTION] set isChefEntreprise = 1 where[NoContact] = '{rstData.Fields[0].Value}'", out sortie, -1);
                rstData.MoveNext();
            }
            rstData.Close();
            rstData = null;
        }
/// <summary>
/// Formule douteuse
/// </summary>
private void IdentifierMeatProcessing()
        {
            try
            {

                Object sortie;
                ADODB.Recordset rstData;
                rstData = new Recordset();
                rstData.CursorLocation = CursorLocationEnum.adUseClient;
                    rstData.Open("SELECT IDContact FROM (ContactClient  " +
                        "INNER JOIN Client ON ContactClient.noclient = Client.IDClient) " +
                        "INNER JOIN contact ON ContactClient.nocontact = contact.IDContact " +
                        "WHERE Titre like '%Meat Processing%' AND([E-mail] <> '' OR Email <> '') " +
                        "ORDER BY Contact.NomContact", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly,-1);
                while (!rstData.EOF)
                {

                    odbc.Execute($"update [dbo].[LISTEDISTRIBUTION] set isMeatProcessing = 1 where [NoContact] = '{rstData.Fields[0].Value}'", out sortie, -1);
                    rstData.MoveNext();
                }
                rstData.Close();
                rstData = null;
            }
            catch (Exception ex)
            {
                AfficherErreur("AjoutDL", "AjouterGroupementMeatProcessing", ex);
            }
        }
        private void EliminerContctsDejaListés()
        {
            Recordset rd = new Recordset();

            rd.Open("SELECT * FROM [DBO].[LISTEDISTRIBUTION] " +
                "JOIN[DBO].[OUTLOOK] ON TRIM([DBO].[LISTEDISTRIBUTION].NOMCOMPAGNIE) = TRIM([DBO].[LISTEDISTRIBUTION].NOMCOMPAGNIE)", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            while (!rd.EOF)
            {
              //  odbc.Execute()
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
        }
        private void ImporterAncienneTableOutlook()
        {
            Recordset rds = new Recordset();
            Recordset rdLst = new Recordset();
            Recordset rd = new Recordset();
            object sortie;
            rd.Open("SELECT ID, NOMCONTACT, COMPAGNIE, [E-MAIL]  FROM [DBO].[OUTLOOK] " +
                "WHERE [E-MAIL] IS NOT NULL AND COMPAGNIE IS NOT NULL ", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            int newID = 0x13E2; //5090 last index de liste précedent
            while (!rd.EOF)
            {
                ///Recherche comparative avec la vieille table outlook 
                ///ajoute les inexistants
                rdLst.Open($"SELECT * FROM [DBO].[LISTEDISTRIBUTION] WHERE NOMCOMPAGNIE ='{rd.Fields[1].Value}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                if (rdLst.EOF)
                {
                    newID++;
                    rdLst.AddNew();
                    rdLst.Fields[1].Value = newID;
                    rdLst.Fields[2].Value = rd.Fields[1].Value;
                    rdLst.Fields[3].Value = rd.Fields[2].Value;
                    rdLst.Fields[4].Value = rd.Fields[3].Value;
                    rdLst.Fields[5].Value = 1;
                    rdLst.Fields[6].Value = 0;
                    rdLst.Fields[7].Value = 0;
                    rdLst.Fields[8].Value = 0;
                    rdLst.Fields[9].Value = 0;
                    rdLst.Update();
                    Conteneur.txtStatus.Text = $"Ajout de { rd.Fields[1].Value} de  { rd.Fields[2].Value} ";
                }
                rdLst.Close();
                rdLst = null;
                ///Recherche comparative avec la vieille table Client
                rdLst.Open($"SELECT * FROM [DBO].[CLIENT] WHERE COMPAGNIE LIKE '%{rd.Fields[1].Value}%'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                if (rdLst.EOF)
                {
                    rdLst.Fields[6].Value = 1;
                    rdLst.Update();
                }
                rdLst.Close();
                rdLst = null;
                rd.MoveNext();
            }
            rd.Close();
            rd = null;
        }
        private void cmdCreer_Click(object eventSender, EventArgs eventArgs)
        {
         //   if (_optChoix_0.Checked)
            {
            }
        }
        private void cmdExceptions_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Form f = new ExceptionsLD();
                f.MdiParent = Conteneur.ActiveForm.MdiParent;
                f.Show();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("AjoutDL", "cmdExceptions_Click", ex);
            }
        }
        private void AjoutDL_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                m_otlApp = OuvrirOutlook(ref m_bDejaOuvert);
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("AjoutDL", "Form_Load", ex);
            }
        }
        private void AjoutDL_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            try
            {
                if (m_bDejaOuvert == false)
                {
                    m_otlApp.Quit();
                }
                m_otlApp = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("AjoutDL", "Form_Load", ex);
            }
        }
        private bool IsException(string sAdresse)
        {
            bool IsExceptionRet = default;
            try
            {
                for (int X = 0; X <m_arr_sException.Count; X++)
                {
                    if ((m_arr_sException[X] ?? "") == (sAdresse ?? ""))
                    {
                        IsExceptionRet = true;
                        break;
                    }
                }
                return IsExceptionRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("AjoutDL", "IsException", ex);
                return false;
            }
        }
        private void RemplirListeExceptions()
        {
            try
            {
                ADODB.Recordset rstExceptions = new Recordset();
                rstExceptions.Open("SELECT * FROM ExceptionsDL", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly,-1);
                while (!rstExceptions.EOF)
                {
                    m_arr_sException.Add($"{rstExceptions.Fields["Exception"].Value}");
                    rstExceptions.MoveNext();
                }
                rstExceptions.Close();
                rstExceptions = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("AjoutDL", "RemplirListeExceptions", ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous vous appreter a régénérer la liste parent ce qui entraine évidement des changements dans les listes derivées\n" +
                "\n Voulez vous vraiment poursuivre?", Application.ProductName + "." + Name + ".Rebuild", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ///Restriction Admin ou IT
                if ((IdGroupe >= 2 & IdGroupe < 27) | IdGroupe == 27)
                {
                    if (CreerTable())
                    {
                        ImporterContacts();
                        IdentifierClient();
                        IdentifierFournisseur();
                        IdentifierChefEntreprise();
                        IdentifierMeatProcessing();
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e) => IdentifierFournisseur();
        private void button3_Click(object sender, EventArgs e) => IdentifierClient();
        private void button4_Click(object sender, EventArgs e)
        {
            Recordset rd = new Recordset();
            rd.Open("SELECT DISTINCT [DBO].[CLIENT].[NOMCLIENT]  FROM [DBO].[PUNCH]  " +
                "JOIN[DBO].[CLIENT] ON[DBO].[PUNCH].NOCLIENT =[DBO].[CLIENT].IDCLIENT  " +
                "WHERE FACTURÉ = 1  " +
                "ORDER BY[DBO].[CLIENT].NOMCLIENT", odbc, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic, -1);
            List<string> str = new List<string>();
            while (!rd.EOF)
            {
                str.Add($"{rd.Fields[0].Value}");
                rd.MoveNext();
            }
            if (str.Count < 26)
            {
                string msg = "";
                for (int x = 0; x < str.Count; x++)
                {
                    msg += str[x] + "\n";
                }
                MessageBox.Show(msg, Application.ProductName + "." + Name + ".ClientFact");
            }
            rd.Close();
            rd = null;
        }
        private void button5_Click(object sender, EventArgs e) => IdentifierMeatProcessing();
        private void button6_Click(object sender, EventArgs e) => IdentifierChefEntreprise();
    }
}