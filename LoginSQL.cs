using ADODB;
using static Microsoft.VisualBasic.Interaction;
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
    public class LoginSQL : Form
    {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServeur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDataBase = new System.Windows.Forms.ComboBox();
            this.cmbUtilisateurs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdConnexion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serveur de données";
            // 
            // txtServeur
            // 
            this.txtServeur.BackColor = System.Drawing.Color.Black;
            this.txtServeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServeur.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtServeur.Location = new System.Drawing.Point(81, 73);
            this.txtServeur.Name = "txtServeur";
            this.txtServeur.ReadOnly = true;
            this.txtServeur.Size = new System.Drawing.Size(147, 20);
            this.txtServeur.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de données";
            // 
            // cmbDataBase
            // 
            this.cmbDataBase.BackColor = System.Drawing.Color.Black;
            this.cmbDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDataBase.ForeColor = System.Drawing.Color.White;
            this.cmbDataBase.FormattingEnabled = true;
            this.cmbDataBase.Location = new System.Drawing.Point(81, 112);
            this.cmbDataBase.Name = "cmbDataBase";
            this.cmbDataBase.Size = new System.Drawing.Size(210, 21);
            this.cmbDataBase.TabIndex = 3;
            this.cmbDataBase.SelectedIndexChanged += new System.EventHandler(this.cmbDataBase_SelectedIndexChanged);
            // 
            // cmbUtilisateurs
            // 
            this.cmbUtilisateurs.BackColor = System.Drawing.Color.Black;
            this.cmbUtilisateurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUtilisateurs.ForeColor = System.Drawing.Color.White;
            this.cmbUtilisateurs.FormattingEnabled = true;
            this.cmbUtilisateurs.Location = new System.Drawing.Point(81, 170);
            this.cmbUtilisateurs.Name = "cmbUtilisateurs";
            this.cmbUtilisateurs.Size = new System.Drawing.Size(210, 21);
            this.cmbUtilisateurs.TabIndex = 5;
            this.cmbUtilisateurs.SelectedIndexChanged += new System.EventHandler(this.cmbUtilisateurs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Utilisateurs";
            // 
            // txtPasswordUser
            // 
            this.txtPasswordUser.BackColor = System.Drawing.Color.Black;
            this.txtPasswordUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordUser.ForeColor = System.Drawing.Color.White;
            this.txtPasswordUser.Location = new System.Drawing.Point(81, 215);
            this.txtPasswordUser.Name = "txtPasswordUser";
            this.txtPasswordUser.PasswordChar = '€';
            this.txtPasswordUser.Size = new System.Drawing.Size(210, 20);
            this.txtPasswordUser.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtPasswordUser, "© Patrice Waechter-Ebling 2024");
            this.txtPasswordUser.TextChanged += new System.EventHandler(this.txtPasswordUser_TextChanged);
            this.txtPasswordUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordUser_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mot de passe utilisateur";
            // 
            // IdConnexion
            // 
            this.IdConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IdConnexion.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.IdConnexion.Enabled = false;
            this.IdConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdConnexion.ForeColor = System.Drawing.Color.DarkGreen;
            this.IdConnexion.Location = new System.Drawing.Point(156, 289);
            this.IdConnexion.Name = "IdConnexion";
            this.IdConnexion.Size = new System.Drawing.Size(76, 28);
            this.IdConnexion.TabIndex = 8;
            this.IdConnexion.Text = "Connexion";
            this.IdConnexion.UseVisualStyleBackColor = true;
            this.IdConnexion.Click += new System.EventHandler(this.IdConnexion_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(238, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(326, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy;
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(311, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // LoginSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(326, 351);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IdConnexion);
            this.Controls.Add(this.txtPasswordUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbUtilisateurs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDataBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServeur);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginSQL";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleurServeur.LoginSQL";
            this.Load += new System.EventHandler(this.LoginSQL_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        internal Label label1;
        internal Label label2;
        internal ComboBox cmbDataBase;
        internal ComboBox cmbUtilisateurs;
        internal Label label3;
        internal TextBox txtPasswordUser;
        internal Label label4;
        internal Button IdConnexion;
        internal Button button2;
        internal StatusStrip statusStrip1;
        internal ToolStripStatusLabel toolStripStatusLabel1;
        internal TextBox txtServeur;
        public static Connection odbc = new Connection();
        private ToolTip toolTip1;
        public static ADODB.Recordset record = new Recordset();
        public static string NomDB { get; internal set; }
        public LoginSQL()
        {
            InitializeComponent();
        }
        private void LoginSQL_Load(object sender, EventArgs e)
        {
            toolTip1.Active = true; 
            txtServeur.Text = "production.grb.local";
            toolStripStatusLabel1.Text = "ControleurServeur." + Name;
            try
            {
                if (odbc.State == 0)
                {
                    odbc.Open($"Provider=SQLOLEDB;Data Source=production\\sqlexpress;Initial Catalog=autogrb;", "sa", "$NK#Bpl9YCm!0EKeZLdzp$Qetrz9g9bdQK7LO8L!u4oyv4rO2AOEvceyu8XIo", -1);
                }
                record.Open("SELECT name, database_id, create_date  FROM sys.databases;", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!record.EOF)
                {
                    if (!(record.Fields[0].Value is DBNull))
                    {
                        if (record.Fields[0].Value == "autogrb")
                        {
                            cmbDataBase.Items.Add(record.Fields[0].Value);
                        }
                    }
                    record.MoveNext();
                }
                if (cmbDataBase.Items.Count > 0) cmbDataBase.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                AfficherErreur("LoginSQL", "LoginSQL_Load", ex);
            }
        }
        /// Modifications PWE 2024-07-05
        /// le password ne sera plus importé
        /// poteniel risque de securité 
        private void cmbDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDataBase.SelectedIndex != -1)
                {
                    ADODB.Recordset rstTbl = new ADODB.Recordset();
                    if (cmbDataBase.SelectedItem.ToString().ToUpper() == "bugs".ToUpper())
                    {
                        SqlLinkODBC(rstTbl, cmbDataBase.SelectedItem.ToString(),
                            "SELECT DISTINCT * ,[AUTOGRB].[DBO].[GROUPES].NOMGROUPE FROM  [DBO].[UTILISATEUR] " +
                            "JOIN [AUTOGRB].[DBO].[GROUPES] ON [DBO].[UTILISATEURS].GROUPE=[AUTOGRB].[DBO].[GROUPES].IDGROUPE " +
                            "WHERE ACTIF=1 AND SUPPRIMÉ= 0   ORDER BY EMPLOYE");
                    }
                    else
                    {
                        SqlLinkODBC(rstTbl, cmbDataBase.SelectedItem.ToString(),
                            "SELECT DISTINCT * ,[DBO].[GROUPES].NOMGROUPE FROM [DBO].[EMPLOYÉS] " +
                            "JOIN [AUTOGRB].[DBO].[GROUPES] ON [DBO].[EMPLOYÉS].GROUPE=[DBO].[GROUPES].IDGROUPE " +
                            "WHERE ACTIF=1 AND SUPPRIMÉ= 0   ORDER BY EMPLOYE");
                    }
                    while (!rstTbl.EOF)
                    {
                        if (!(rstTbl.Fields[0].Value is DBNull))
                        {
                            Employes.Add(new ControleurServeur.DB_Employe
                            {
                                Noemploye = (int)rstTbl.Fields[0].Value,// EMPLOYÉS.NOEMPLOYE
                                Loginname = $"{rstTbl.Fields[1].Value}",// EMPLOYÉS.LOGINNAME
                                Passwd = string.Empty,// EMPLOYÉS.PASSWD
                                Employes = $"{rstTbl.Fields[3].Value}",// EMPLOYÉS.EMPLOYE
                                Initiale = $"{rstTbl.Fields[4].Value}",// EMPLOYÉS.INITIALE
                                Tel = $"{rstTbl.Fields[5].Value}",// EMPLOYÉS.TEL
                                Page = $"{rstTbl.Fields[6].Value}",// EMPLOYÉS.PAGE
                                Cell = $"{rstTbl.Fields[7].Value}",// EMPLOYÉS.CELL
                                Actif = (bool)rstTbl.Fields[8].Value,// EMPLOYÉS.ACTIF
                                Groupe = (int)rstTbl.Fields[9].Value,// EMPLOYÉS.GROUPE
                                Famille = (int)rstTbl.Fields[10].Value,// EMPLOYÉS.FAMILLE
                                Supprime = (bool)rstTbl.Fields[11].Value,// EMPLOYÉS.SUPPRIMÉ
                            });
                            cmbUtilisateurs.Items.Add(rstTbl.Fields[3].Value);
                        }
                        rstTbl.MoveNext();
                    }
                    toolStripStatusLabel1.Text = $"il y a {Employes.Count}  employés autorisés";
                    rstTbl.Close();
                    rstTbl = default;
                    cmbUtilisateurs.Text = GetSetting("PWE.ControleurServeur", "LoginSQL", "Nom", "");
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("LoginSQL", "cmbDataBase_SelectedIndexChanged", ex);
            }
        }
        private void txtPasswordUser_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordUser.Text.Length > 3)
            {
                IdConnexion.Enabled = true;
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.ToolTipTitle=Application.ProductName+" v:"+ Application.ProductVersion;
                toolTip1.Show(txtPasswordUser.Text,this);
            }
            else { IdConnexion.Enabled = false; }
        }
        ///Caster les valeurs dynamiques issues d'OLE-DB
        ///Stockage dans le registre Windows en cas de panne DNS
        ///adresse registre 1:
        ///Ordinateur\HKEY_CURRENT_USER\Software\VB and VBA Program Settings\Controleur\LoginSQL
        ///adresse registre 2:
        ///Ordinateur\HKEY_USERS\S-1-5-21-359240740-3635665737-3022937320-1207\Software\VB and VBA Program Settings\Controleur\LoginSQL
        private void IdConnexion_Click(object sender, EventArgs e)
        {
            if (cmbUtilisateurs.Text == "") { return; }
            try
            {
                ADODB.Recordset rstEmploye = new ADODB.Recordset();
                SqlLinkODBC(rstEmploye, cmbDataBase.Text, $"SELECT   DISTINCT * FROM [DBO].[EMPLOYÉS] WHERE ACTIF=1 AND SUPPRIMÉ= 0   AND EMPLOYE='{cmbUtilisateurs.Text}' ORDER BY EMPLOYE");
                if (rstEmploye.EOF) { return; }
                if (!rstEmploye.EOF)
                {
                    IdNoEmploye = (int)rstEmploye.Fields[0].Value;
                    IdNomEmploye = (string)rstEmploye.Fields[3].Value;
                    IdLoginEmploye = (string)rstEmploye.Fields[1].Value;
                    IdPassEmploye = (string)rstEmploye.Fields[2].Value;
                    IdGroupe = (int)rstEmploye.Fields[9].Value;
                    IdFamille = rstEmploye.Fields[10].Value;
                    IdSatut = (bool)rstEmploye.Fields[8].Value;
                    Conteneur.idInitiales.Text = (string)rstEmploye.Fields[4].Value;
                    if (IdGroupe == 2 | IdGroupe == 27) { g_admin = true; } else { g_admin = false; }
                    NomDB = cmbDataBase.Text;
                }
                if (txtPasswordUser.Text.Contains("=") | txtPasswordUser.Text.Contains(" or ") | txtPasswordUser.Text.Contains("1=1") | txtPasswordUser.Text.Contains("1 = 1") | txtPasswordUser.Text.Contains(" "))
                {
                    MessageBox.Show($"Tentative d'injection détectée\n{IdLoginEmploye}@{Conteneur.ip}", Application.ProductName + ".Sécurité.InjectionSQL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit(new CancelEventArgs(false));
                }
                int x = 0;
                if (txtPasswordUser.Text == IdPassEmploye)
                {
                    if (cmbDataBase.SelectedItem.ToString() == "AutoGRB") { GRB = true; }
                    if (cmbDataBase.SelectedItem.ToString() == "Permaroute") { Permaroute = true; }
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "NoEmploye", IdNoEmploye.ToString());
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "NomEmploye", IdNomEmploye);
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "LoginEmploye", IdLoginEmploye);
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "PassEmploye", IdPassEmploye);
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "Groupe", IdGroupe.ToString());
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "Famille", IdFamille.ToString());
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "Satut", IdSatut.ToString());
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "Initiales", Conteneur.idInitiales.Text);
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "isAdmin", g_admin.ToString());
                    SaveSetting("PWE.ControleurServeur", "LoginSQL", "NomDB", NomDB);
                    Conteneur.toolStripMenuItem18.Visible = false;
                }
                else
                {
                    x++;
                    MessageBox.Show($"{txtPasswordUser.Text} mot de passe invalide\nVérifiez votre saisie: \n\tTestHashSalt:\n\tMot de passe pour {IdNomEmploye} invalide\n\n\t\tFermeture de l'application", Application.ProductName + ".Secure.Login.Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtPasswordUser.Text = string.Empty;
                    Application.Exit();
                }
            }
            catch (Exception ex) { AfficherErreur("LoginSQL", "IdConnexion_Click", ex); }
            Close();
        }
        private void cmbUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e) {
               Application.Exit();
        }


        private void txtPasswordUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbUtilisateurs.Text == "") { return; }
                try
                {
                    ADODB.Recordset rstEmploye = new ADODB.Recordset();
                    SqlLinkODBC(rstEmploye, cmbDataBase.Text, $"SELECT   DISTINCT * FROM [DBO].[EMPLOYÉS] WHERE ACTIF=1 AND SUPPRIMÉ= 0   AND EMPLOYE='{cmbUtilisateurs.Text}' ORDER BY EMPLOYE");
                    if (rstEmploye.EOF) { return; }
                    if (!rstEmploye.EOF)
                    {
                        IdNoEmploye = (int)rstEmploye.Fields[0].Value;
                        IdNomEmploye = (string)rstEmploye.Fields[3].Value;
                        IdLoginEmploye = (string)rstEmploye.Fields[1].Value;
                        IdPassEmploye = (string)rstEmploye.Fields[2].Value;
                        IdGroupe = (int)rstEmploye.Fields[9].Value;
                        IdFamille = rstEmploye.Fields[10].Value;
                        IdSatut = (bool)rstEmploye.Fields[8].Value;
                        Conteneur.idInitiales.Text = (string)rstEmploye.Fields[4].Value;
                        if (IdGroupe == 2 | IdGroupe == 27) { g_admin = true; } else { g_admin = false; }
                        NomDB = cmbDataBase.Text;
                    }
                    if (txtPasswordUser.Text.Contains("=") | txtPasswordUser.Text.Contains(" or ") | txtPasswordUser.Text.Contains("1=1") | txtPasswordUser.Text.Contains("1 = 1") | txtPasswordUser.Text.Contains(" "))
                    {
                        MessageBox.Show($"Tentative d'injection détectée\n{IdLoginEmploye}@{Conteneur.ip}", Application.ProductName + ".Sécurité.InjectionSQL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit(new CancelEventArgs(false));
                    }
                    int x = 0;
                    if (txtPasswordUser.Text == IdPassEmploye)
                    {
                        if (cmbDataBase.SelectedItem.ToString() == "AutoGRB") { GRB = true; }
                        if (cmbDataBase.SelectedItem.ToString() == "Permaroute") { Permaroute = true; }
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "NoEmploye", IdNoEmploye.ToString());
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "NomEmploye", IdNomEmploye);
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "LoginEmploye", IdLoginEmploye);
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "PassEmploye", IdPassEmploye);
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "Groupe", IdGroupe.ToString());
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "Famille", IdFamille.ToString());
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "Satut", IdSatut.ToString());
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "Initiales", Conteneur.idInitiales.Text);
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "isAdmin", g_admin.ToString());
                        SaveSetting("PWE.ControleurServeur", "LoginSQL", "NomDB", NomDB);
                        Conteneur.toolStripMenuItem18.Visible = false;
                    }
                    else
                    {
                        x++;
                        MessageBox.Show($"{txtPasswordUser.Text} mot de passe invalide\nVérifiez votre saisie: \n\tTestHashSalt:\n\tMot de passe pour {IdNomEmploye} invalide\n\n\t\tFermeture de l'application", Application.ProductName + ".Secure.Login.Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtPasswordUser.Text = string.Empty;
                        Application.Exit();
                    }
                }
                catch (Exception ex) { AfficherErreur("LoginSQL", "IdConnexion_Click", ex); }
                Close();
            }

        }
    }
}