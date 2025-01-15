using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
using ADODB;
namespace ControleurServeur
{
    internal class Vendeur : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public Vendeur() : base()
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
        internal static System.Windows.Forms.ToolTip ToolTip1;
        internal static System.Windows.Forms.ColumnHeader _lstclient_ColumnHeader_1;
        internal static System.Windows.Forms.ListView lstclient;
        internal static System.Windows.Forms.Button cmdrechercheclient;
        internal static System.Windows.Forms.Button CmdExporter;
        internal static System.Windows.Forms.Button cmdcherche;
        internal static System.Windows.Forms.MaskedTextBox mskDateCherche;
        internal static System.Windows.Forms.ComboBox cmbClient;
        internal static System.Windows.Forms.Button CmdAdd;
        internal static System.Windows.Forms.Button CmdSupp;
        internal static System.Windows.Forms.Button CmdQuit;
        internal static System.Windows.Forms.ComboBox cmbtype;
        internal static System.Windows.Forms.TextBox txtNomCompagny;
        internal static System.Windows.Forms.MaskedTextBox txtdate;
        internal static System.Windows.Forms.TextBox txtcommentaire;
        internal static System.Windows.Forms.TextBox txtcontact;
        internal static System.Windows.Forms.Button cmdfermercontact;
        internal static System.Windows.Forms.Button cmdsave;
        internal static System.Windows.Forms.Label Label4;
        internal static System.Windows.Forms.Label lblNomcompagnie;
        internal static System.Windows.Forms.Label Label10;
        internal static System.Windows.Forms.Label Label5;
        internal static System.Windows.Forms.Label label2;
        internal static System.Windows.Forms.GroupBox fracontact;
        internal static System.Windows.Forms.ColumnHeader _lister_ColumnHeader_1;
        internal static System.Windows.Forms.ColumnHeader _lister_ColumnHeader_2;
        internal static System.Windows.Forms.ColumnHeader _lister_ColumnHeader_3;
        internal static System.Windows.Forms.ColumnHeader _lister_ColumnHeader_4;
        internal static System.Windows.Forms.ColumnHeader _lister_ColumnHeader_5;
        internal static System.Windows.Forms.ColumnHeader _lister_ColumnHeader_6;
        internal static System.Windows.Forms.ListView lister;
        internal static System.Windows.Forms.Label lbladresse;
        internal static System.Windows.Forms.Label lbltelephone;
        internal static System.Windows.Forms.Label Label1;
        internal static System.Windows.Forms.Label Label6;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendeur));
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            lstclient = new System.Windows.Forms.ListView();
            _lstclient_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cmdrechercheclient = new System.Windows.Forms.Button();
            CmdExporter = new System.Windows.Forms.Button();
            cmdcherche = new System.Windows.Forms.Button();
            mskDateCherche = new System.Windows.Forms.MaskedTextBox();
            cmbClient = new System.Windows.Forms.ComboBox();
            CmdAdd = new System.Windows.Forms.Button();
            CmdSupp = new System.Windows.Forms.Button();
            CmdQuit = new System.Windows.Forms.Button();
            fracontact = new System.Windows.Forms.GroupBox();
            cmbtype = new System.Windows.Forms.ComboBox();
            txtNomCompagny = new System.Windows.Forms.TextBox();
            txtdate = new System.Windows.Forms.MaskedTextBox();
            txtcommentaire = new System.Windows.Forms.TextBox();
            txtcontact = new System.Windows.Forms.TextBox();
            cmdfermercontact = new System.Windows.Forms.Button();
            cmdsave = new System.Windows.Forms.Button();
            Label4 = new System.Windows.Forms.Label();
            lblNomcompagnie = new System.Windows.Forms.Label();
            Label10 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lister = new System.Windows.Forms.ListView();
            _lister_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lister_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lister_ColumnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lister_ColumnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lister_ColumnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lister_ColumnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lbladresse = new System.Windows.Forms.Label();
            lbltelephone = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            fracontact.SuspendLayout();
            SuspendLayout();//lstclient
            lstclient.BackColor = System.Drawing.Color.Black;
            lstclient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lstclient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lstclient_ColumnHeader_1});
            lstclient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lstclient.ForeColor = System.Drawing.Color.White;
            lstclient.FullRowSelect = true;
            lstclient.GridLines = true;
            lstclient.HideSelection = false;
            lstclient.Location = new System.Drawing.Point(708, 10);
            lstclient.Name = "lstclient";
            lstclient.Size = new System.Drawing.Size(569, 179);
            lstclient.TabIndex = 24;
            lstclient.UseCompatibleStateImageBehavior = false;
            lstclient.View = System.Windows.Forms.View.Details;
            lstclient.Visible = false;
            lstclient.DoubleClick += new System.EventHandler(lstclient_DoubleClick);
            lstclient.Leave += new System.EventHandler(lstClient_Leave);//_lstclient_ColumnHeader_1
            _lstclient_ColumnHeader_1.Text = "Catalogue";
            _lstclient_ColumnHeader_1.Width = 565;//cmdrechercheclient
            cmdrechercheclient.BackColor = System.Drawing.Color.Black;
            cmdrechercheclient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdrechercheclient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdrechercheclient.ForeColor = System.Drawing.Color.White;
            cmdrechercheclient.Image = ((System.Drawing.Image)(resources.GetObject("cmdrechercheclient.Image")));
            cmdrechercheclient.Location = new System.Drawing.Point(321, 72);
            cmdrechercheclient.Name = "cmdrechercheclient";
            cmdrechercheclient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdrechercheclient.Size = new System.Drawing.Size(25, 25);
            cmdrechercheclient.TabIndex = 23;
            cmdrechercheclient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            cmdrechercheclient.UseVisualStyleBackColor = true;
            cmdrechercheclient.Click += new System.EventHandler(cmdrechercheclient_Click);//CmdExporter
            CmdExporter.BackColor = System.Drawing.Color.Black;
            CmdExporter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdExporter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdExporter.Location = new System.Drawing.Point(1031, 649);
            CmdExporter.Name = "CmdExporter";
            CmdExporter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdExporter.Size = new System.Drawing.Size(145, 33);
            CmdExporter.TabIndex = 22;
            CmdExporter.Text = "&Exporter vers Excel";
            CmdExporter.UseVisualStyleBackColor = true;
            CmdExporter.Click += new System.EventHandler(cmdExporter_Click);//cmdcherche
            cmdcherche.BackColor = System.Drawing.Color.Black;
            cmdcherche.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdcherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdcherche.ForeColor = System.Drawing.Color.White;
            cmdcherche.Location = new System.Drawing.Point(491, 10);
            cmdcherche.Name = "cmdcherche";
            cmdcherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdcherche.Size = new System.Drawing.Size(113, 25);
            cmdcherche.TabIndex = 4;
            cmdcherche.Text = "Cherche par date";
            cmdcherche.UseVisualStyleBackColor = true;
            cmdcherche.Click += new System.EventHandler(cmdcherche_Click);//mskDateCherche
            mskDateCherche.AllowPromptAsInput = false;
            mskDateCherche.BackColor = System.Drawing.Color.Black;
            mskDateCherche.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            mskDateCherche.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mskDateCherche.ForeColor = System.Drawing.Color.White;
            mskDateCherche.Location = new System.Drawing.Point(329, 12);
            mskDateCherche.Name = "mskDateCherche";
            mskDateCherche.Size = new System.Drawing.Size(156, 20);
            mskDateCherche.TabIndex = 3;
            mskDateCherche.Enter += new System.EventHandler(mskDateCherche_Enter);
            mskDateCherche.Leave += new System.EventHandler(mskDateCherche_Leave);//cmbClient
            cmbClient.BackColor = System.Drawing.Color.Black;
            cmbClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbClient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbClient.ForeColor = System.Drawing.Color.White;
            cmbClient.Location = new System.Drawing.Point(130, 75);
            cmbClient.Name = "cmbClient";
            cmbClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbClient.Size = new System.Drawing.Size(193, 22);
            cmbClient.Sorted = true;
            cmbClient.TabIndex = 1;
            cmbClient.Text = "cmbClient";
            cmbClient.SelectedIndexChanged += new System.EventHandler(cmbclient_SelectedIndexChanged);//CmdAdd
            CmdAdd.BackColor = System.Drawing.Color.Black;
            CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdAdd.Location = new System.Drawing.Point(703, 649);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAdd.Size = new System.Drawing.Size(97, 33);
            CmdAdd.TabIndex = 17;
            CmdAdd.Text = "&Ajouter";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += new System.EventHandler(CmdAdd_Click);//CmdSupp
            CmdSupp.BackColor = System.Drawing.Color.Black;
            CmdSupp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdSupp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdSupp.Location = new System.Drawing.Point(815, 649);
            CmdSupp.Name = "CmdSupp";
            CmdSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdSupp.Size = new System.Drawing.Size(89, 33);
            CmdSupp.TabIndex = 18;
            CmdSupp.Text = "&Supprimer";
            CmdSupp.UseVisualStyleBackColor = true;
            CmdSupp.Click += new System.EventHandler(CmdSupp_Click);//CmdQuit
            CmdQuit.BackColor = System.Drawing.Color.Black;
            CmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdQuit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdQuit.Location = new System.Drawing.Point(919, 649);
            CmdQuit.Name = "CmdQuit";
            CmdQuit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdQuit.Size = new System.Drawing.Size(97, 33);
            CmdQuit.TabIndex = 19;
            CmdQuit.Text = "&Fermer";
            CmdQuit.UseVisualStyleBackColor = true;
            CmdQuit.Click += new System.EventHandler(cmdquit_Click);//fracontact
            fracontact.BackColor = System.Drawing.Color.Black;
            fracontact.Controls.Add(cmbtype);
            fracontact.Controls.Add(txtNomCompagny);
            fracontact.Controls.Add(txtdate);
            fracontact.Controls.Add(txtcommentaire);
            fracontact.Controls.Add(txtcontact);
            fracontact.Controls.Add(cmdfermercontact);
            fracontact.Controls.Add(cmdsave);
            fracontact.Controls.Add(Label4);
            fracontact.Controls.Add(lblNomcompagnie);
            fracontact.Controls.Add(Label10);
            fracontact.Controls.Add(Label5);
            fracontact.Controls.Add(label2);
            fracontact.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fracontact.ForeColor = System.Drawing.Color.White;
            fracontact.Location = new System.Drawing.Point(453, 247);
            fracontact.Name = "fracontact";
            fracontact.Padding = new System.Windows.Forms.Padding(0);
            fracontact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fracontact.Size = new System.Drawing.Size(742, 257);
            fracontact.TabIndex = 8;
            fracontact.TabStop = false;
            fracontact.Text = "Contact";
            fracontact.Visible = false;//cmbtype
            cmbtype.BackColor = System.Drawing.Color.Black;
            cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbtype.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmbtype.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmbtype.ForeColor = System.Drawing.Color.White;
            cmbtype.Location = new System.Drawing.Point(272, 40);
            cmbtype.Name = "cmbtype";
            cmbtype.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbtype.Size = new System.Drawing.Size(217, 22);
            cmbtype.TabIndex = 27;//txtNomCompagny
            txtNomCompagny.AcceptsReturn = true;
            txtNomCompagny.BackColor = System.Drawing.Color.Black;
            txtNomCompagny.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtNomCompagny.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNomCompagny.Enabled = false;
            txtNomCompagny.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNomCompagny.ForeColor = System.Drawing.Color.White;
            txtNomCompagny.Location = new System.Drawing.Point(32, 80);
            txtNomCompagny.MaxLength = 0;
            txtNomCompagny.Name = "txtNomCompagny";
            txtNomCompagny.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNomCompagny.Size = new System.Drawing.Size(153, 20);
            txtNomCompagny.TabIndex = 20;//txtdate
            txtdate.AllowPromptAsInput = false;
            txtdate.BackColor = System.Drawing.Color.Black;
            txtdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtdate.Enabled = false;
            txtdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtdate.ForeColor = System.Drawing.Color.White;
            txtdate.Location = new System.Drawing.Point(32, 40);
            txtdate.Name = "txtdate";
            txtdate.Size = new System.Drawing.Size(81, 20);
            txtdate.TabIndex = 11;//txtcommentaire
            txtcommentaire.AcceptsReturn = true;
            txtcommentaire.BackColor = System.Drawing.Color.Black;
            txtcommentaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcommentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtcommentaire.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtcommentaire.ForeColor = System.Drawing.Color.White;
            txtcommentaire.Location = new System.Drawing.Point(32, 120);
            txtcommentaire.MaxLength = 0;
            txtcommentaire.Name = "txtcommentaire";
            txtcommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtcommentaire.Size = new System.Drawing.Size(465, 20);
            txtcommentaire.TabIndex = 14;//txtcontact
            txtcontact.AcceptsReturn = true;
            txtcontact.BackColor = System.Drawing.Color.Black;
            txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            txtcontact.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtcontact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtcontact.ForeColor = System.Drawing.Color.White;
            txtcontact.Location = new System.Drawing.Point(280, 80);
            txtcontact.MaxLength = 0;
            txtcontact.Name = "txtcontact";
            txtcontact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtcontact.Size = new System.Drawing.Size(217, 20);
            txtcontact.TabIndex = 12;//cmdfermercontact
            cmdfermercontact.BackColor = System.Drawing.Color.Black;
            cmdfermercontact.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdfermercontact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdfermercontact.ForeColor = System.Drawing.Color.White;
            cmdfermercontact.Location = new System.Drawing.Point(612, 216);
            cmdfermercontact.Name = "cmdfermercontact";
            cmdfermercontact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdfermercontact.Size = new System.Drawing.Size(105, 33);
            cmdfermercontact.TabIndex = 16;
            cmdfermercontact.Text = "Fermer";
            cmdfermercontact.UseVisualStyleBackColor = true;
            cmdfermercontact.Click += new System.EventHandler(cmdfermercontact_Click);//cmdsave
            cmdsave.BackColor = System.Drawing.Color.Black;
            cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdsave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdsave.ForeColor = System.Drawing.Color.White;
            cmdsave.Location = new System.Drawing.Point(493, 216);
            cmdsave.Name = "cmdsave";
            cmdsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdsave.Size = new System.Drawing.Size(113, 33);
            cmdsave.TabIndex = 15;
            cmdsave.Text = "Sauvegarde";
            cmdsave.UseVisualStyleBackColor = true;
            cmdsave.Click += new System.EventHandler(cmdsave_Click);//Label4
            Label4.AutoSize = true;
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(272, 24);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(25, 14);
            Label4.TabIndex = 26;
            Label4.Text = "État";//lblNomcompagnie
            lblNomcompagnie.AutoSize = true;
            lblNomcompagnie.BackColor = System.Drawing.Color.Black;
            lblNomcompagnie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomcompagnie.ForeColor = System.Drawing.Color.White;
            lblNomcompagnie.Location = new System.Drawing.Point(32, 64);
            lblNomcompagnie.Name = "lblNomcompagnie";
            lblNomcompagnie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNomcompagnie.Size = new System.Drawing.Size(99, 14);
            lblNomcompagnie.TabIndex = 21;
            lblNomcompagnie.Text = "Nom de Compagnie";//Label10
            Label10.AutoSize = true;
            Label10.BackColor = System.Drawing.Color.Black;
            Label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label10.ForeColor = System.Drawing.Color.White;
            Label10.Location = new System.Drawing.Point(32, 104);
            Label10.Name = "Label10";
            Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label10.Size = new System.Drawing.Size(69, 14);
            Label10.TabIndex = 13;
            Label10.Text = "Commentaire";//Label5
            Label5.AutoSize = true;
            Label5.BackColor = System.Drawing.Color.Black;
            Label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(272, 64);
            Label5.Name = "Label5";
            Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label5.Size = new System.Drawing.Size(44, 14);
            Label5.TabIndex = 10;
            Label5.Text = "Contact";//label2
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(32, 24);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label2.Size = new System.Drawing.Size(29, 14);
            label2.TabIndex = 9;
            label2.Text = "Date";//lister
            lister.BackColor = System.Drawing.Color.Black;
            lister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lister_ColumnHeader_1,
            _lister_ColumnHeader_2,
            _lister_ColumnHeader_3,
            _lister_ColumnHeader_4,
            _lister_ColumnHeader_5,
            _lister_ColumnHeader_6});
            lister.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lister.ForeColor = System.Drawing.Color.White;
            lister.FullRowSelect = true;
            lister.GridLines = true;
            lister.HideSelection = false;
            lister.Location = new System.Drawing.Point(36, 202);
            lister.Name = "lister";
            lister.Size = new System.Drawing.Size(1241, 419);
            lister.TabIndex = 7;
            lister.UseCompatibleStateImageBehavior = false;
            lister.View = System.Windows.Forms.View.Details;
            lister.DoubleClick += new System.EventHandler(lister_DoubleClick);
            lister.KeyDown += new System.Windows.Forms.KeyEventHandler(lister_KeyDown);//_lister_ColumnHeader_1
            _lister_ColumnHeader_1.Text = "Date";
            _lister_ColumnHeader_1.Width = 118;//_lister_ColumnHeader_2
            _lister_ColumnHeader_2.Text = "Nom de Compagnie";
            _lister_ColumnHeader_2.Width = 236;//_lister_ColumnHeader_3
            _lister_ColumnHeader_3.Text = "Contact";
            _lister_ColumnHeader_3.Width = 236;//_lister_ColumnHeader_4
            _lister_ColumnHeader_4.Text = "État";
            _lister_ColumnHeader_4.Width = 170;//_lister_ColumnHeader_5
            _lister_ColumnHeader_5.Text = "Commentaire";
            _lister_ColumnHeader_5.Width = 306;//_lister_ColumnHeader_6
            _lister_ColumnHeader_6.Text = "Enregistrer par";
            _lister_ColumnHeader_6.Width = 170;//lbladresse
            lbladresse.BackColor = System.Drawing.Color.Black;
            lbladresse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lbladresse.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbladresse.ForeColor = System.Drawing.Color.White;
            lbladresse.Location = new System.Drawing.Point(127, 112);
            lbladresse.Name = "lbladresse";
            lbladresse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lbladresse.Size = new System.Drawing.Size(565, 40);
            lbladresse.TabIndex = 25;
            lbladresse.Text = "lbladresse";//lbltelephone
            lbltelephone.BackColor = System.Drawing.Color.Black;
            lbltelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lbltelephone.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbltelephone.ForeColor = System.Drawing.Color.White;
            lbltelephone.Location = new System.Drawing.Point(127, 156);
            lbltelephone.Name = "lbltelephone";
            lbltelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lbltelephone.Size = new System.Drawing.Size(565, 33);
            lbltelephone.TabIndex = 6;
            lbltelephone.Text = "lbltelephone";//Label1
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(57, 72);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(65, 17);
            Label1.TabIndex = 0;
            Label1.Text = "NomClient";//Label6
            Label6.BackColor = System.Drawing.Color.Black;
            Label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label6.ForeColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(57, 112);
            Label6.Name = "Label6";
            Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label6.Size = new System.Drawing.Size(65, 17);
            Label6.TabIndex = 5;
            Label6.Text = "Adresse";//label11
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Black;
            label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(239, 15);
            label11.Name = "label11";
            label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label11.Size = new System.Drawing.Size(100, 14);
            label11.TabIndex = 2;
            label11.Text = "Date  AAAA-MM-JJ";//button3
            button3.BackColor = System.Drawing.Color.Black;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(1193, 649);
            button3.Name = "button3";
            button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button3.Size = new System.Drawing.Size(97, 33);
            button3.TabIndex = 19;
            button3.Text = "&Fermer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(cmdquit_Click);//Vendeur
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1319, 698);
            Controls.Add(lstclient);
            Controls.Add(cmdrechercheclient);
            Controls.Add(CmdExporter);
            Controls.Add(cmdcherche);
            Controls.Add(mskDateCherche);
            Controls.Add(cmbClient);
            Controls.Add(CmdAdd);
            Controls.Add(CmdSupp);
            Controls.Add(fracontact);
            Controls.Add(button3);
            Controls.Add(CmdQuit);
            Controls.Add(lister);
            Controls.Add(label11);
            Controls.Add(lbladresse);
            Controls.Add(lbltelephone);
            Controls.Add(Label1);
            Controls.Add(Label6);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(10, 29);
            Name = "Vendeur";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            Text = "Contacts pour vendeurs";
            Load += new System.EventHandler(vendeur_Load);
            fracontact.ResumeLayout(false);
            fracontact.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        internal static System.Windows.Forms.Label label11;
        internal static System.Windows.Forms.Button button3;
        private enum enumModeCherche
        {
            MODE_DATE = 0,
            MODE_CLIENT = 1
        }
        private bool m_bModeAjouter;
        private enumModeCherche m_eModeCherche;
        private int numéroCompagnie;
        private bool FieldOk;
        private void FindFieldsExist(ref string Name_Renamed)
        {
            try
            {
                string strName;
                ADODB.Recordset Findfield;
                int i;
                FieldOk = false;
                Findfield = new Recordset();
                Findfield.Open("Select * FROM Vendeur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                for (i = 0; i <= (int)(Findfield.Fields.Count - 1); i++)
                {
                    strName = Findfield.Fields[i].Name;
                    if ((strName ?? "") == (Name_Renamed ?? ""))
                    {
                        FieldOk = true;
                        Findfield.Close();
                        Findfield = null;
                        return;
                    }
                }
                Findfield.Close();
                Findfield = null;
                UpdateSQL("ALTER TABLE Vendeur Add " + Name_Renamed + " Text(25);");
                FieldOk = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "FindFieldsExist()", ex);
            }
        }
        private void remplir_lister()
        {
            try
            {
                ADODB.Recordset rstVendeur;
                string argName_Renamed = "EnregPar";
                FindFieldsExist(ref argName_Renamed);
                string argName_Renamed1 = "Etat";
                FindFieldsExist(ref argName_Renamed1);
                m_eModeCherche = enumModeCherche.MODE_CLIENT;
                CmdAdd.Visible = true;
                lister.Items.Clear();
                rstVendeur = new Recordset();
                rstVendeur.Open("SELECT * FROM vendeur WHERE IDClient = " + numéroCompagnie + " ORDER BY no", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstVendeur.EOF)
                {
                    ListViewItem itm = lister.Items.Add(string.Empty);
                    itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, $"20{rstVendeur.Fields["Date"].Value}"));// pour passer a l'annee sur 4o
                    if (!(rstVendeur.Fields["Contact"].Value is DBNull) | !(rstVendeur.Fields["commentaire"].Value is DBNull) | !(rstVendeur.Fields["Date"].Value is DBNull))
                    {
                        itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, cmbClient.Text.Split('-')[0]));
                    }
                    else
                    {
                        itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rstVendeur.Fields["Contact"].Value}"));
                    itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rstVendeur.Fields["Etat"].Value}"));
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rstVendeur.Fields["commentaire"].Value}"));
                    itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rstVendeur.Fields["EnregPar"].Value}"));
                    itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rstVendeur.Fields["no"].Value}"));
                    rstVendeur.MoveNext();
                }
                rstVendeur.Close();
                rstVendeur = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "remplir_lister", ex);
            }
        }
        /// Patch Erreur Convertion dynamic DBNull > System.String.Empty
        /// PWE 2024-08-09
        private void cmbclient_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstClient;
                if (cmbClient.SelectedIndex != -1)
                {
                    m_iIDClient = int.Parse(cmbClient.Text.Split('-')[1]);
                    fracontact.Visible = false;
                    m_bModeAjouter = false;
                    rstClient = new Recordset();
                    rstClient.Open($"SELECT distinct IDClient, NomClient, Compagnie, Telephonne, Fax, Pagette, Cellulaire,  Email, AdresseLiv, VilleLiv, [Prov/EtatLiv], PaysLiv, CodePostalLiv FROM Client WHERE IDClient = {m_iIDClient} ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    lbladresse.Text = string.Empty;
                    lbltelephone.Text = string.Empty;
                    numéroCompagnie = (int)rstClient.Fields[0].Value;
                    if (!(rstClient.Fields[8].Value is DBNull)) { lbladresse.Text += (string)(rstClient.Fields[8].Value); }
                    if (!(rstClient.Fields[9].Value is DBNull))
                    {
                        lbladresse.Text += (string)rstClient.Fields[9].Value;
                        if (!(rstClient.Fields[11].Value is DBNull)) { lbladresse.Text += (string)rstClient.Fields[11].Value; }
                        if (!(rstClient.Fields[10].Value is DBNull)) { lbladresse.Text += (string)rstClient.Fields[10].Value; };
                    }
                    lbladresse.Text += $", {rstClient.Fields[12].Value}";
                    lbltelephone.Text = string.Empty;
                    if ($"{rstClient.Fields[3].Value}" != string.Empty) { lbltelephone.Text += $"TÉL: {rstClient.Fields[3].Value}      "; }
                    if ($"{rstClient.Fields[4].Value}" != string.Empty) { lbltelephone.Text += $"\tFAX: {rstClient.Fields[4].Value}      "; }
                    if ($"{rstClient.Fields[5].Value}" != string.Empty) { lbltelephone.Text += $"\tPAGE: {rstClient.Fields[5].Value}"; }
                    if ($"{rstClient.Fields[6].Value}" != string.Empty) { lbltelephone.Text += $"\tCELL: {rstClient.Fields[6].Value}"; }
                    if ($"{rstClient.Fields[7].Value}" != string.Empty) { lbltelephone.Text += $"\tEMAIL: {rstClient.Fields[7].Value}"; }
                    txtNomCompagny.Text = (string)(rstClient.Fields[1].Value);
                    rstClient.Close();
                    rstClient = null;
                    remplir_lister();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "cmbclient_Click", ex);
            }
        }
        /// Methode ajout new client remaniee PWE 2024-08-09
        /// modification au niveau de la date et heure 
        /// utlisation DateTime au lieu de 'System.Threading.Thread.CurrentThread.CurrentCulture.Calendar'
        private void CmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fracontact.Visible = true;
                fracontact.Tag = numéroCompagnie;
                m_bModeAjouter = true;
                txtdate.Text = ConvertToUSDate(DateTime.Now);
                txtNomCompagny.Text = cmbClient.Text.Split('-')[0];
                txtcommentaire.Text = string.Empty;
                txtcontact.Text = string.Empty;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "CmdAdd_Click", ex);
            }
        }
        private void cmdcherche_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fracontact.Visible = false;
                remplir_lister_date();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "cmdcherche_Click", ex);
            }
        }
        private void cmdExporter_Click(object eventSender, EventArgs eventArgs)
        {
            Microsoft.Office.Interop.Excel.Application xlsheet = new Microsoft.Office.Interop.Excel.Application(); ;
            Microsoft.Office.Interop.Excel.Workbook xlworksheet = xlsheet.Workbooks.Add();
            ADODB.Recordset info;
            int row;
            int i;
            row = 1;
            if (m_eModeCherche == enumModeCherche.MODE_CLIENT)
            {
                row = 6;
                xlsheet.Cells[1, 1] = "Client:";
                xlsheet.Cells[2, 1] = "Adresse:";
                xlsheet.Cells[3, 1] = "Téléphone:";
                xlsheet.Cells[2, 3] = "Ville:";
                xlsheet.Cells[3, 3] = "Fax:";
                xlsheet.Cells[2, 5] = "Pays:";
                xlsheet.Cells[3, 5] = "Page:";
                xlsheet.Cells[2, 7] = "Province/État:";
                xlsheet.Cells[3, 7] = "Cell:";
                xlsheet.Cells[2, 9] = "Codepostal:";
                xlsheet.Cells[3, 9] = "Email:";
                xlsheet.Cells[5, 1] = "Date:";
                xlsheet.Cells[5, 2] = "Nom de la Compagnie";
                xlsheet.Cells[5, 3] = "Nom du Contact";
                xlsheet.Cells[5, 4] = "État";
                xlsheet.Cells[5, 5] = "Commentaire";
                xlsheet.Cells[5, 9] = "Enregister Par";
                {
                    var Block = xlsheet.get_Range("A1:A3;C2:C3;E2:E3;G2:G3;I2:I3");
                    Block.Font.Bold = true;
                    Block.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight;
                    Block.Font.Size = 11;
                }
                {
                    var Block1 = xlsheet.get_Range("AI5");
                    Block1.Font.Bold = true;
                    Block1.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
                    Block1.Font.Size = 11;
                }
                info = new Recordset();
                info.Open("Select * FROM client where IDClient = " + numéroCompagnie, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!info.EOF)
                {
                    xlsheet.Cells[1, 2] = info.Fields["Nomclient"].Value;
                    xlsheet.Cells[2, 2] = info.Fields["AdresseLiv"].Value;
                    xlsheet.Cells[3, 2] = info.Fields["Telephonne"].Value;
                    xlsheet.Cells[2, 4] = info.Fields["VilleLiv"].Value;
                    xlsheet.Cells[3, 4] = info.Fields["Fax"].Value;
                    xlsheet.Cells[2, 6] = info.Fields["PaysLiv"].Value;
                    xlsheet.Cells[3, 6] = info.Fields["Pagette"].Value;
                    xlsheet.Cells[2, 8] = info.Fields["Prov/EtatLiv"].Value;
                    xlsheet.Cells[3, 8] = info.Fields["Cellulaire"].Value;
                    xlsheet.Cells[3, 10] = info.Fields["CodePostalLiv"].Value;
                    xlsheet.Cells[3, 10] = info.Fields["Email"].Value;
                    info.MoveNext();
                }
                for (i = 0; i < (int)lister.Items.Count; i++)
                {
                    xlsheet.Cells[row, 1] = lister.Items[i].Text;
                    xlsheet.Cells[row, 2] = lister.Items[i].SubItems[1].Text;
                    xlsheet.Cells[row, 3] = lister.Items[i].SubItems[2].Text;
                    xlsheet.Cells[row, 4] = lister.Items[i].SubItems[3].Text;
                    xlsheet.Cells[row, 5] = lister.Items[i].SubItems[4].Text;
                    xlsheet.Cells[row, 9] = lister.Items[i].SubItems[5].Text;
                    xlsheet.get_Range("E" + row + ":H" + row).Merge();
                    row = (int)(row + 1);
                }
                xlsheet.get_Range("A:J").Columns.AutoFit();
                info.Close();
                info = null;
            }
            else
            {
                if (lister.Items.Count < 1)
                    return;
                row = 3;
                xlsheet.get_Range("A1:D1").Merge();
                xlsheet.Cells[1, 1] = "Liste en date du " + lister.Items[1].Text;
                xlsheet.Cells[2, 1] = "Date:";
                xlsheet.Cells[2, 2] = "Nom de la Compagnie";
                xlsheet.Cells[2, 3] = "Nom du Contact";
                xlsheet.Cells[2, 4] = "État";
                xlsheet.Cells[2, 5] = "Commentaire";
                xlsheet.Cells[2, 6] = "Enregister Par";
                {
                    var withBlock2 = xlsheet.get_Range("A1;A2;A2:F2");
                    withBlock2.Font.Bold = true;
                    withBlock2.Font.Size = 11;
                }
                for (i = 0; i < (int)lister.Items.Count; i++)
                {
                    xlsheet.Cells[row, 1] = lister.Items[i].Text;
                    xlsheet.Cells[row, 2] = lister.Items[i].SubItems[1].Text;
                    xlsheet.Cells[row, 3] = lister.Items[i].SubItems[2].Text;
                    xlsheet.Cells[row, 4] = lister.Items[i].SubItems[3].Text;
                    xlsheet.Cells[row, 5] = lister.Items[i].SubItems[4].Text;
                    xlsheet.Cells[row, 6] = lister.Items[i].SubItems[5].Text;
                    row = (int)(row + 1);
                }
                xlsheet.get_Range("A:F").Columns.AutoFit();
            }
            xlsheet.Visible = true;
            xlworksheet.SaveAs(Filename: $"{RootExcel}{cmbClient.Text}.xlsx");
        }
        private void cmdfermercontact_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fracontact.Visible = false;
                if (m_eModeCherche == enumModeCherche.MODE_CLIENT)
                {
                    remplir_lister();
                }
                else
                {
                    remplir_lister_date();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "cmdfermercontact_Click", ex);
            }
        }
        private void cmdquit_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "cmdquit_Click", ex);
            }
        }
        private void cmdrechercheclient_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstcatalog;
                string sDescription;
                ListViewItem itmDescription;
                sDescription = Interaction.InputBox("Quelle est le client à rechercher");
                if (!string.IsNullOrEmpty(sDescription))
                {
                    lstclient.Items.Clear();
                    sDescription = Strings.Replace(sDescription, "'", "''");
                    sDescription = "%" + sDescription + "%";
                    rstcatalog = new Recordset();
                    rstcatalog.Open("SELECT DISTINCT NomClient FROM Client WHERE  NomClient LIKE '" + sDescription + "'  ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstcatalog.EOF)
                    {
                        itmDescription = lstclient.Items.Add("");
                        itmDescription.Tag = rstcatalog.Fields["NomClient"].Value;
                        itmDescription.Text = (string)(rstcatalog.Fields["NomClient"].Value);
                        rstcatalog.MoveNext();
                    }
                    rstcatalog.Close();
                    rstcatalog = null;
                    if (lstclient.Items.Count > 0)
                    {
                        lstclient.Visible = true;
                        lstclient.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Aucun enregistrement trouvé!");
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "cmdrechercheclient_Click", ex);
            }
        }
        private void cmdsave_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstVendeur;
                rstVendeur = new Recordset();
                string argName_Renamed = "Enregistrerpar";
                FindFieldsExist(ref argName_Renamed);
                string argName_Renamed1 = "Type";
                FindFieldsExist(ref argName_Renamed1);
                if (m_bModeAjouter == true)
                {
                    rstVendeur.Open("SELECT * FROM vendeur", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstVendeur.AddNew();
                    m_bModeAjouter = false;
                }
                else
                {
                    rstVendeur.Open($"SELECT * FROM VENDEUR WHERE [NO] = {lister.FocusedItem.Tag}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                rstVendeur.Fields["IDClient"].Value = fracontact.Tag;
                rstVendeur.Fields["Date"].Value = Droite(txtdate.Text, 8);
                rstVendeur.Fields["Contact"].Value = txtcontact.Text;
                rstVendeur.Fields["commentaire"].Value = txtcommentaire.Text;
                rstVendeur.Fields["EnregPar"].Value = IdNoEmploye;
                rstVendeur.Fields["Etat"].Value = cmbtype.Text;
                rstVendeur.Update();
                rstVendeur.Close();
                rstVendeur = null;
                fracontact.Visible = false;
                if (m_eModeCherche == enumModeCherche.MODE_CLIENT)
                {
                    remplir_lister();
                }
                else
                {
                    remplir_lister_date();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "cmdsave_Click", ex);
            }
        }
        private void CmdSupp_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lister.Items.Count > 0)
                {
                    UpdateSQL("DELETE FROM Vendeur WHERE [no] = " + lister.FocusedItem.Tag.ToString());
                    remplir_lister();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "CmdSupp_Click", ex);
            }
        }
        private void vendeur_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                lbladresse.Text = string.Empty;
                lbltelephone.Text = string.Empty;
                cmbtype.Items.Add("Piste de vente");
                cmbtype.Items.Add("Opportunité");
                cmbtype.Items.Add("Soumission");
                cmbtype.Items.Add("Gain");
                cmbtype.Items.Add("Perte");
                cmbtype.Items.Add("En attente");
                cmbtype.SelectedIndex = 0;
                remplir_comboclient();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "Form_Load", ex);
            }
            remplir_lister();
        }
        private void lister_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstVendeur;
                if (lister.Items.Count != 0)
                {
                    if (m_eModeCherche == enumModeCherche.MODE_CLIENT)
                    {
                        fracontact.Visible = true;
                        fracontact.Tag = numéroCompagnie;
                        txtNomCompagny.Text = lister.FocusedItem.SubItems[1].Text;
                        txtdate.Text = lister.FocusedItem.Text;
                        txtcontact.Text = lister.FocusedItem.SubItems[2].Text;
                        if (string.IsNullOrEmpty(lister.FocusedItem.SubItems[3].Text))
                        {
                            cmbtype.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbtype.Text = lister.FocusedItem.SubItems[3].Text;
                        }
                        txtcommentaire.Text = lister.FocusedItem.SubItems[4].Text;
                        m_bModeAjouter = false;
                    }
                    else
                    {
                        rstVendeur = new Recordset();
                        rstVendeur.Open($"SELECT vendeur.etat , vendeur.no ,vendeur.idclient , vendeur.date ," +
                            $" vendeur.contact, vendeur.commentaire, client.nomclient FROM vendeur " +
                            $"inner join client on vendeur.idclient = client.idclient " +
                            $"WHERE[no] = {lister.FocusedItem.Tag} ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        fracontact.Visible = true;
                        fracontact.Tag = rstVendeur.Fields["idclient"].Value;
                        txtdate.Text = (string)(rstVendeur.Fields["Date"].Value);
                        txtNomCompagny.Text = (string)(rstVendeur.Fields["nomClient"].Value);
                        txtcontact.Text = (string)(rstVendeur.Fields["Contact"].Value);
                        txtcommentaire.Text = (string)(rstVendeur.Fields["commentaire"].Value);
                        if (rstVendeur.Fields["Etat"].Value is DBNull)
                        {
                            cmbtype.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbtype.Text = (string)(rstVendeur.Fields["Etat"].Value);
                        }
                        rstVendeur.Close();
                        rstVendeur = null;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "lister_DblClick", ex);
            }
        }
        private void lister_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (lister.Items.Count > 0)
                {
                    if (eventArgs.KeyCode == Keys.Delete)
                    {
                        UpdateSQL("DELETE FROM Vendeur WHERE [no] = " + lister.FocusedItem.Tag.ToString());
                        remplir_lister();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "lister_KeyDown", ex);
            }
        }
        private void lstclient_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            int X;
            ADODB.Recordset rstclientinfo;
            ADODB.Recordset rstVendeur;
            fracontact.Visible = false;
            ListViewItem itmvendeurrec;
            if (lstclient.Items.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                cmbClient.Text = lstclient.FocusedItem.Text;
                lstclient.Visible = false;
                rstclientinfo = new Recordset();
                rstclientinfo.Open("Select * FROM client where nomclient= '" + lstclient.FocusedItem.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                lbladresse.Text = string.Empty;
                lbltelephone.Text = string.Empty;
                if (!rstclientinfo.EOF)
                    numéroCompagnie = int.Parse(rstclientinfo.Fields["Idclient"].Value);
                while (!rstclientinfo.EOF)
                {
                    if (!(rstclientinfo.Fields["AdresseLiv"].Value is DBNull)) lbladresse.Text = (string)(Operators.AddObject(lbladresse.Text, rstclientinfo.Fields["AdresseLiv"].Value));
                    if (!(rstclientinfo.Fields["VilleLiv"].Value is DBNull)) lbladresse.Text = $"{lbladresse.Text}, {rstclientinfo.Fields["VilleLiv"].Value}";
                    if (!(rstclientinfo.Fields["PaysLiv"].Value is DBNull)) lbladresse.Text = $"{lbladresse.Text}, {rstclientinfo.Fields["PaysLiv"].Value}";
                    if (!(rstclientinfo.Fields["Prov/EtatLiv"].Value is DBNull)) lbladresse.Text = $"{lbladresse.Text}, {rstclientinfo.Fields["Prov/EtatLiv"].Value}";
                    if (!(rstclientinfo.Fields["CodePostalLiv"].Value is DBNull)) lbladresse.Text = $"{lbladresse.Text}, {rstclientinfo.Fields["CodePostalLiv"].Value}";
                    if (rstclientinfo.Fields["Telephonne"].Value != string.Empty) lbltelephone.Text = $"{lbltelephone.Text}Tél: {rstclientinfo.Fields["Telephonne"].Value}";
                    if (rstclientinfo.Fields["Fax"].Value != string.Empty) lbltelephone.Text = $"{lbltelephone.Text} Fax: {rstclientinfo.Fields["Fax"].Value}";
                    if (rstclientinfo.Fields["Pagette"].Value != string.Empty) lbltelephone.Text = $"{lbltelephone.Text} Page: {rstclientinfo.Fields["Pagette"].Value}";
                    if (rstclientinfo.Fields["Cellulaire"].Value != string.Empty) lbltelephone.Text = $"{lbltelephone.Text} Cell: {rstclientinfo.Fields["Cellulaire"].Value}";
                    if (rstclientinfo.Fields["Email"].Value != string.Empty) lbltelephone.Text = $"{lbltelephone.Text} Email: {rstclientinfo.Fields["Email"].Value}";
                    rstclientinfo.MoveNext();
                }
                lister.Items.Clear();
                m_eModeCherche = enumModeCherche.MODE_CLIENT;
                CmdAdd.Visible = true;
                rstVendeur = new Recordset();
                rstVendeur.Open("SELECT VENDEUR.ETAT , VENDEUR.ENREGPAR, VENDEUR.CONTACT, VENDEUR.COMMENTAIRE, VENDEUR.NO, VENDEUR.DATE FROM VENDEUR " +
                    "INNER JOIN CLIENT ON CLIENT.IDCLIENT = VENDEUR.IDCLIENT WHERE NOMCLIENT= '" + lstclient.FocusedItem.Text + "' " +
                    "ORDER BY no", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstVendeur.EOF)
                {
                    itmvendeurrec = lister.Items.Add(string.Empty);
                    itmvendeurrec.Tag = rstVendeur.Fields["no"].Value;
                    if (rstVendeur.Fields["Date"].Value is DBNull)
                    {
                        itmvendeurrec.Text = " ";
                    }
                    else
                    {
                        itmvendeurrec.Text = ConvertDate(DateAndTime.DateSerial(int.Parse(Gauche((string)(rstVendeur.Fields["Date"].Value), 2)),
                            int.Parse((string)(rstVendeur.Fields["Date"].Value).Substring(4, 2)),
                            int.Parse(Droite((string)(rstVendeur.Fields["Date"].Value), 2))));
                    }
                    if (rstVendeur.Fields["Contact"].Value is DBNull & rstVendeur.Fields["commentaire"].Value is DBNull & rstVendeur.Fields["Date"].Value is DBNull)
                    {
                        itmvendeurrec.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmvendeurrec.SubItems.Add(cmbClient.Text);
                    }
                    if (rstVendeur.Fields["Contact"].Value is DBNull)
                    {
                        itmvendeurrec.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmvendeurrec.SubItems.Add(rstVendeur.Fields["Contact"].Value);
                    }
                    if (rstVendeur.Fields["etat"].Value is DBNull)
                    {
                        itmvendeurrec.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmvendeurrec.SubItems.Add(rstVendeur.Fields["etat"].Value);
                    }
                    if (rstVendeur.Fields["commentaire"].Value is DBNull)
                    {
                        itmvendeurrec.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmvendeurrec.SubItems.Add(rstVendeur.Fields["commentaire"].Value);
                    }
                    if (rstVendeur.Fields["EnregPar"].Value is DBNull)
                    {
                        itmvendeurrec.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmvendeurrec.SubItems.Add("Enregpar");
                    }
                    rstVendeur.MoveNext();
                }
                rstVendeur.Close();
                rstVendeur = null;
                rstclientinfo.Close();
                rstclientinfo = null;
                Cursor.Current = Cursors.Default;
            }
        }
        private void lstClient_Leave(object eventSender, EventArgs eventArgs)
        {
            lstclient.Visible = false;
        }
        private void mskDateCherche_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Strings.Len(mskDateCherche.Text) == 10)
                {
                    mskDateCherche.Text = Droite(mskDateCherche.Text, 8);
                }
                mskDateCherche.Mask = "##-##-##";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "mskDateCherche_GotFocus", ex);
            }
        }
        private void mskDateCherche_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                mskDateCherche.Mask = string.Empty;
                if (mskDateCherche.Text == "____-__-__")
                {
                    mskDateCherche.Text = string.Empty;
                }
                else if (Strings.Len(mskDateCherche.Text) == 8)
                {
                    if (Information.IsDate(mskDateCherche.Text))
                    {
                        mskDateCherche.Text = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateAndTime.DateSerial(int.Parse(Gauche(mskDateCherche.Text, 2)), int.Parse(mskDateCherche.Text.Substring(4, 2)), int.Parse(Droite(mskDateCherche.Text, 2)))) + mskDateCherche.Text.Substring(3, 8);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "mskDateCherche_LostFocus", ex);
            }
        }
        private void remplir_comboclient()
        {
            try
            {
                ADODB.Recordset rstClient;
                rstClient = new Recordset();
                rstClient.Open("SELECT * FROM Client WHERE Supprimé = 0 ORDER BY NomClient", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                cmbClient.Items.Clear();
                if (!rstClient.EOF)
                    numéroCompagnie = (int)rstClient.Fields["idclient"].Value;
                while (!rstClient.EOF)
                {
                    cmbClient.Items.Add($"{rstClient.Fields["NomClient"].Value} - {rstClient.Fields["IDClient"].Value}");
                    rstClient.MoveNext();
                }
                rstClient.Close();
                rstClient = null;
                if (cmbClient.Items.Count > 0)
                {
                    cmbClient.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "remplir_comboclient", ex);
            }
        }
        /// Remaniement de la formule de recherche par date
        /// correction bug translate DateFormat=>FormatYear 2<>4 bits
        /// tansformation date en 10 bits et non plus 8
        /// PWE 2024-06-08
        private void remplir_lister_date()
        {
            try
            {
                ListViewItem itmVendeur;
                ADODB.Recordset rstVendeur;
                m_eModeCherche = enumModeCherche.MODE_DATE;
                CmdAdd.Visible = false;
                lister.Items.Clear();
                rstVendeur = new Recordset();
                rstVendeur.Open($"SELECT VENDEUR.NO , '20'+VENDEUR.DATE , VENDEUR.ETAT , VENDEUR.ENREGPAR , VENDEUR.CONTACT ," +
                    $" VENDEUR.COMMENTAIRE , CLIENT.NOMCLIENT FROM CLIENT " +
                    $"INNER JOIN VENDEUR ON VENDEUR.IDCLIENT = CLIENT.IDCLIENT " +
                    $"WHERE VENDEUR.DATE= '{mskDateCherche.Text}' " +
                    $"ORDER BY vendeur.no", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!rstVendeur.EOF)
                {
                    itmVendeur = lister.Items.Add(string.Empty);
                    itmVendeur.Tag = rstVendeur.Fields["no"].Value;
                    if (rstVendeur.Fields["Date"].Value is DBNull)
                    {
                        itmVendeur.Text = string.Empty;
                    }
                    else
                    {
                        itmVendeur.Text = ConvertDate(DateAndTime.DateSerial(int.Parse(Gauche((string)(rstVendeur.Fields["Date"].Value), 2)),
                            int.Parse((string)(rstVendeur.Fields["Date"].Value).Substring(4, 2)),
                            int.Parse(Droite((string)(rstVendeur.Fields["Date"].Value), 2))));
                    }
                    if (rstVendeur.Fields["nomclient"].Value is DBNull)
                    {
                        itmVendeur.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmVendeur.SubItems.Add(rstVendeur.Fields["nomclient"].Value);
                    }
                    if (rstVendeur.Fields["Contact"].Value is DBNull)
                    {
                        itmVendeur.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmVendeur.SubItems.Add(rstVendeur.Fields["Contact"].Value);
                    }
                    if (rstVendeur.Fields["etat"].Value is DBNull)
                    {
                        itmVendeur.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmVendeur.SubItems.Add(rstVendeur.Fields["etat"].Value);
                    }
                    if (rstVendeur.Fields["commentaire"].Value is DBNull)
                    {
                        itmVendeur.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmVendeur.SubItems.Add(rstVendeur.Fields["commentaire"].Value);
                    }
                    if (rstVendeur.Fields["EnregPar"].Value is DBNull)
                    {
                        itmVendeur.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        itmVendeur.SubItems.Add(rstVendeur.Fields["EnregPar"].Value);
                    }
                    rstVendeur.MoveNext();
                }
                rstVendeur.Close();
                rstVendeur = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Vendeur", "remplir_lister_date", ex);
            }
        }
    }
}