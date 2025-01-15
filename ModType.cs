using System;
using System.Diagnostics;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class ModType : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public ModType() : base()
        {
            InitializeComponent();
        }
        private System.ComponentModel.IContainer components;
        internal static ToolTip ToolTip1;
        internal static TextBox txtAdd;
        internal static ComboBox Combo1;
        internal static GroupBox ADD;
        internal static RadioButton OptElec;
        internal static RadioButton OptMec;
        internal static RadioButton Opttous;
        internal static GroupBox Afficher;
        internal static Button Cmdfermer;
        internal static ColumnHeader _lsttype_ColumnHeader_1;
        internal static ColumnHeader _lsttype_ColumnHeader_2;
        internal static ListView lsttype;
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            ADD = new System.Windows.Forms.GroupBox();
            txtAdd = new System.Windows.Forms.TextBox();
            Combo1 = new System.Windows.Forms.ComboBox();
            Afficher = new System.Windows.Forms.GroupBox();
            OptElec = new System.Windows.Forms.RadioButton();
            OptMec = new System.Windows.Forms.RadioButton();
            Opttous = new System.Windows.Forms.RadioButton();
            Cmdfermer = new System.Windows.Forms.Button();
            lsttype = new System.Windows.Forms.ListView();
            _lsttype_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            _lsttype_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            CmdValider = new System.Windows.Forms.Button();
            cmdsupprimer = new System.Windows.Forms.Button();
            CmdCancel = new System.Windows.Forms.Button();
            Cmdajouter = new System.Windows.Forms.Button();
            ADD.SuspendLayout();
            Afficher.SuspendLayout();
            SuspendLayout();//ADD
            ADD.BackColor = System.Drawing.Color.Black;
            ADD.Controls.Add(txtAdd);
            ADD.Controls.Add(Combo1);
            ADD.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ADD.ForeColor = System.Drawing.Color.White;
            ADD.Location = new System.Drawing.Point(65, 192);
            ADD.Name = "ADD";
            ADD.Padding = new System.Windows.Forms.Padding(0);
            ADD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ADD.Size = new System.Drawing.Size(241, 49);
            ADD.TabIndex = 9;
            ADD.TabStop = false;
            ADD.Text = "Ajouter";
            ADD.Visible = false;//txtAdd
            txtAdd.AcceptsReturn = true;
            txtAdd.BackColor = System.Drawing.Color.Black;
            txtAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtAdd.ForeColor = System.Drawing.Color.White;
            txtAdd.Location = new System.Drawing.Point(64, 16);
            txtAdd.MaxLength = 0;
            txtAdd.Name = "txtAdd";
            txtAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAdd.Size = new System.Drawing.Size(161, 20);
            txtAdd.TabIndex = 11;
            txtAdd.Text = "Entré le Nom Ici";//Combo1
            Combo1.BackColor = System.Drawing.Color.Black;
            Combo1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Combo1.ForeColor = System.Drawing.Color.White;
            Combo1.Items.AddRange(new object[] {
            "E",
            "M"});
            Combo1.Location = new System.Drawing.Point(16, 16);
            Combo1.Name = "Combo1";
            Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Combo1.Size = new System.Drawing.Size(41, 22);
            Combo1.TabIndex = 10;
            Combo1.Text = "E";//Afficher
            Afficher.BackColor = System.Drawing.Color.Black;
            Afficher.Controls.Add(OptElec);
            Afficher.Controls.Add(OptMec);
            Afficher.Controls.Add(Opttous);
            Afficher.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Afficher.ForeColor = System.Drawing.Color.White;
            Afficher.Location = new System.Drawing.Point(3, 64);
            Afficher.Name = "Afficher";
            Afficher.Padding = new System.Windows.Forms.Padding(0);
            Afficher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Afficher.Size = new System.Drawing.Size(279, 51);
            Afficher.TabIndex = 0;
            Afficher.TabStop = false;
            Afficher.Text = "Afficher";//OptElec
            OptElec.AutoSize = true;
            OptElec.BackColor = System.Drawing.Color.Black;
            OptElec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OptElec.ForeColor = System.Drawing.Color.White;
            OptElec.Location = new System.Drawing.Point(138, 24);
            OptElec.Name = "OptElec";
            OptElec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            OptElec.Size = new System.Drawing.Size(72, 18);
            OptElec.TabIndex = 3;
            OptElec.TabStop = true;
            OptElec.Text = "Électrique";
            OptElec.UseVisualStyleBackColor = true;
            OptElec.CheckedChanged += new System.EventHandler(OptElec_CheckedChanged);//OptMec
            OptMec.AutoSize = true;
            OptMec.BackColor = System.Drawing.Color.Black;
            OptMec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OptMec.ForeColor = System.Drawing.Color.White;
            OptMec.Location = new System.Drawing.Point(62, 24);
            OptMec.Name = "OptMec";
            OptMec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            OptMec.Size = new System.Drawing.Size(77, 18);
            OptMec.TabIndex = 2;
            OptMec.TabStop = true;
            OptMec.Text = "Mecanique";
            OptMec.UseVisualStyleBackColor = true;
            OptMec.CheckedChanged += new System.EventHandler(OptMec_CheckedChanged);//Opttous
            Opttous.AutoSize = true;
            Opttous.BackColor = System.Drawing.Color.Black;
            Opttous.Checked = true;
            Opttous.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Opttous.ForeColor = System.Drawing.Color.White;
            Opttous.Location = new System.Drawing.Point(8, 24);
            Opttous.Name = "Opttous";
            Opttous.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Opttous.Size = new System.Drawing.Size(48, 18);
            Opttous.TabIndex = 1;
            Opttous.TabStop = true;
            Opttous.Text = "Tous";
            Opttous.UseVisualStyleBackColor = true;
            Opttous.CheckedChanged += new System.EventHandler(Opttous_CheckedChanged);//Cmdfermer
            Cmdfermer.AutoSize = true;
            Cmdfermer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Cmdfermer.BackColor = System.Drawing.Color.Black;
            Cmdfermer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            Cmdfermer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Cmdfermer.ForeColor = System.Drawing.Color.White;
            Cmdfermer.Location = new System.Drawing.Point(379, 474);
            Cmdfermer.Name = "Cmdfermer";
            Cmdfermer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Cmdfermer.Size = new System.Drawing.Size(53, 26);
            Cmdfermer.TabIndex = 8;
            Cmdfermer.Text = "Fermer";
            Cmdfermer.UseVisualStyleBackColor = true;
            Cmdfermer.Click += new System.EventHandler(Cmdfermer_Click);//lsttype
            lsttype.BackColor = System.Drawing.Color.Black;
            lsttype.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lsttype_ColumnHeader_1,
            _lsttype_ColumnHeader_2});
            lsttype.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lsttype.ForeColor = System.Drawing.Color.White;
            lsttype.FullRowSelect = true;
            lsttype.GridLines = true;
            lsttype.HideSelection = false;
            lsttype.Location = new System.Drawing.Point(3, 121);
            lsttype.Name = "lsttype";
            lsttype.Size = new System.Drawing.Size(429, 335);
            lsttype.TabIndex = 4;
            lsttype.UseCompatibleStateImageBehavior = false;
            lsttype.View = System.Windows.Forms.View.Details;
            lsttype.Click += new System.EventHandler(lsttype_Click);//_lsttype_ColumnHeader_1
            _lsttype_ColumnHeader_1.Text = "E/M";
            _lsttype_ColumnHeader_1.Width = 95;//_lsttype_ColumnHeader_2
            _lsttype_ColumnHeader_2.Text = "Type";
            _lsttype_ColumnHeader_2.Width = 330;//CmdValider
            CmdValider.AutoSize = true;
            CmdValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CmdValider.BackColor = System.Drawing.Color.Black;
            CmdValider.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdValider.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdValider.ForeColor = System.Drawing.Color.White;
            CmdValider.Location = new System.Drawing.Point(321, 474);
            CmdValider.Name = "CmdValider";
            CmdValider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdValider.Size = new System.Drawing.Size(52, 26);
            CmdValider.TabIndex = 16;
            CmdValider.Text = "Valider";
            CmdValider.UseVisualStyleBackColor = true;
            CmdValider.Visible = false;//cmdsupprimer
            cmdsupprimer.AutoSize = true;
            cmdsupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmdsupprimer.BackColor = System.Drawing.Color.Black;
            cmdsupprimer.Enabled = false;
            cmdsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdsupprimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdsupprimer.ForeColor = System.Drawing.Color.White;
            cmdsupprimer.Location = new System.Drawing.Point(247, 474);
            cmdsupprimer.Name = "cmdsupprimer";
            cmdsupprimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdsupprimer.Size = new System.Drawing.Size(68, 26);
            cmdsupprimer.TabIndex = 15;
            cmdsupprimer.Text = "Supprimer";
            cmdsupprimer.UseVisualStyleBackColor = true;//CmdCancel
            CmdCancel.AutoSize = true;
            CmdCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CmdCancel.BackColor = System.Drawing.Color.Black;
            CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            CmdCancel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdCancel.ForeColor = System.Drawing.Color.White;
            CmdCancel.Location = new System.Drawing.Point(184, 474);
            CmdCancel.Name = "CmdCancel";
            CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdCancel.Size = new System.Drawing.Size(57, 26);
            CmdCancel.TabIndex = 17;
            CmdCancel.Text = "Annuler";
            CmdCancel.UseVisualStyleBackColor = true;
            CmdCancel.Visible = false;//Cmdajouter
            Cmdajouter.AutoSize = true;
            Cmdajouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Cmdajouter.BackColor = System.Drawing.Color.Black;
            Cmdajouter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            Cmdajouter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Cmdajouter.ForeColor = System.Drawing.Color.White;
            Cmdajouter.Location = new System.Drawing.Point(124, 474);
            Cmdajouter.Name = "Cmdajouter";
            Cmdajouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Cmdajouter.Size = new System.Drawing.Size(54, 26);
            Cmdajouter.TabIndex = 14;
            Cmdajouter.Text = "Ajouter";
            Cmdajouter.UseVisualStyleBackColor = true;//ModType
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.IconeForms;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(436, 504);
            Controls.Add(Cmdfermer);
            Controls.Add(CmdValider);
            Controls.Add(cmdsupprimer);
            Controls.Add(CmdCancel);
            Controls.Add(Cmdajouter);
            Controls.Add(ADD);
            Controls.Add(Afficher);
            Controls.Add(lsttype);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Location = new System.Drawing.Point(576, 449);
            Name = "ModType";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
            Text = "Modifier les Types ";
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(ModType_FormClosed);
            Load += new System.EventHandler(ModType_Load);
            ADD.ResumeLayout(false);
            ADD.PerformLayout();
            Afficher.ResumeLayout(false);
            Afficher.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        internal static System.Windows.Forms.Button CmdValider;
        internal static System.Windows.Forms.Button cmdsupprimer;
        internal static System.Windows.Forms.Button CmdCancel;
        internal static System.Windows.Forms.Button Cmdajouter;
        private void Cmdajouter_Click(object eventSender, EventArgs eventArgs)
        {
            ADD.Visible = true;
            Cmdajouter.Visible = false;
            CmdValider.Visible = true;
            cmdsupprimer.Visible = false;
            CmdCancel.Visible = true;
            cmdsupprimer.Enabled = false;
        }
        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            ADD.Visible = false;
            Cmdajouter.Visible = true;
            CmdValider.Visible = false;
            cmdsupprimer.Visible = true;
            CmdCancel.Visible = false;
        }
        private void Cmdfermer_Click(object eventSender, EventArgs eventArgs) => Close();
        private void cmdsupprimer_Click(object eventSender, EventArgs eventArgs)
        {
            string Name_Renamed = lsttype.FocusedItem.SubItems[1].Text.Replace("'", "''");
            UpdateSQL($"DELETE FROM TBL_Punch_Type WHERE mode = '{lsttype.FocusedItem.Text}' And name = '{Name_Renamed}' ");
            if (Opttous.Checked == true) Opttous_CheckedChanged(Opttous, new EventArgs());
            if (OptMec.Checked == true) OptMec_CheckedChanged(OptMec, new EventArgs());
            if (OptElec.Checked == true) OptElec_CheckedChanged(OptElec, new EventArgs());
            cmdsupprimer.Enabled = false;
        }
        private void CmdValider_Click(object eventSender, EventArgs eventArgs)
        {
            txtAdd.Text.Replace("'", "''");
            UpdateSQL($"INSERT INTO TBL_PUNCH_TYPE (MODE, NAME) VALUES ('{Combo1.Text}','{txtAdd.Text}');");
            CmdValider.Visible = false;
            Cmdajouter.Visible = true;
            ADD.Visible = false;
            CmdCancel.Visible = false;
            cmdsupprimer.Visible = true;
            if (Opttous.Checked == true) Opttous_CheckedChanged(Opttous, new EventArgs());
            if (OptMec.Checked == true) OptMec_CheckedChanged(OptMec, new EventArgs());
            if (OptElec.Checked == true) OptElec_CheckedChanged(OptElec, new EventArgs());
        }
        private void ModType_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            ADODB.Recordset tbltype;
            ListViewItem LIST;
            tbltype = new Recordset();
            tbltype.Open("SELECT DISTINCT * FROM TBL_PUNCH_TYPE ORDER BY NAME ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!tbltype.EOF)
            {
                LIST = lsttype.Items.Add(string.Empty);
                LIST.Text = (string)(tbltype.Fields["mode"].Value);
                LIST.SubItems.Add(tbltype.Fields["name"].Value);
                tbltype.MoveNext();
            }
            tbltype.Close();
            tbltype = null;
        }
        private void ModType_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            try
            {
                var bInstallation = default(bool);
                var bTypeInutile = default(bool);
                FeuilleTemps.ftCmbType.Items.Clear();
                ADODB.Recordset tbltype = new ADODB.Recordset();
                if (FeuilleTemps.mskNoProjet.Text.Substring(2, 1) == "1")
                {
                    bTypeInutile = true;
                }
                if (IsNumeric(Droite(FeuilleTemps.mskNoProjet.Text, 2)))
                {
                    if (FeuilleTemps.mskNoProjet.Text.Substring(2, 4) != "3000")
                    {
                        if (int.Parse(Droite(FeuilleTemps.mskNoProjet.Text, 2)) >= 51 & int.Parse(Droite(FeuilleTemps.mskNoProjet.Text, 2)) <= 59)
                        {
                            bInstallation = true;
                        }
                    }
                    else
                    {
                        bTypeInutile = true;
                    }
                }
                if (bTypeInutile == false)
                {
                    FeuilleTemps.lblType.Visible = true;
                    FeuilleTemps.ftCmbType.Visible = true;
                    if (bInstallation == true)
                    {
                        if (FeuilleTemps.lblPrefixe.Text == "E")
                        {
                            FeuilleTemps.ftCmbType.Items.Add("Installation");
                            FeuilleTemps.ftCmbType.Items.Add("Mise en service");
                        }
                        else
                        {
                            FeuilleTemps.ftCmbType.Items.Add("Installation");
                        }
                    }
                    else if (FeuilleTemps.lblPrefixe.Text == "E")
                    {
                        tbltype.Open("select * from TBL_Punch_Type Where Mode = 'E' Order by name", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        while (!tbltype.EOF)
                        {
                            FeuilleTemps.ftCmbType.Items.Add(tbltype.Fields["Name"].Value);
                            tbltype.MoveNext();
                        }
                        tbltype.Close();
                        tbltype = null;
                    }
                    else
                    {
                        tbltype.Open("select * from TBL_Punch_Type Where Mode = 'M' Order by name ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        while (!tbltype.EOF)
                        {
                            FeuilleTemps.ftCmbType.Items.Add(tbltype.Fields["Name"].Value);
                            tbltype.MoveNext();
                        }
                        tbltype.Close();
                        tbltype = null;
                    }
                }
                else
                {
                    FeuilleTemps.lblType.Visible = false;
                    FeuilleTemps.ftCmbType.Visible = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("ModType", "RemplirComboType@FeuilleTemps", ex);
            }
        }
        private void lsttype_Click(object eventSender, EventArgs eventArgs) => cmdsupprimer.Enabled = true;
        private void OptElec_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (OptElec.Checked)
            {
                OptMec.Checked = false;
                cmdsupprimer.Enabled = false;
                Opttous.Checked = false;
                ADODB.Recordset tbltype = new ADODB.Recordset();
                lsttype.Items.Clear();
                tbltype.Open("Select * from Tbl_punch_Type where mode = 'E' Order by name ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!tbltype.EOF)
                {
                    ListViewItem LIST = lsttype.Items.Add("");
                    LIST.Text = (string)(tbltype.Fields["mode"].Value);
                    LIST.SubItems.Add(tbltype.Fields["name"].Value);
                    tbltype.MoveNext();
                }
                tbltype.Close();
                tbltype = null;
            }
        }
        private void OptMec_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (OptMec.Checked)
            {
                Opttous.Checked = false;
                cmdsupprimer.Enabled = false;
                OptElec.Checked = false;
                ADODB.Recordset tbltype = new ADODB.Recordset();
                lsttype.Items.Clear();
                tbltype.Open("SELECT DISTINCT * FROM TBL_PUNCH_TYPE WHERE MODE = 'M' ORDER BY NAME ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!tbltype.EOF)
                {
                    ListViewItem LIST = lsttype.Items.Add("");
                    LIST.Text = (string)(tbltype.Fields["mode"].Value);
                    LIST.SubItems.Add(tbltype.Fields["name"].Value);
                    tbltype.MoveNext();
                }
                tbltype.Close();
                tbltype = null;
            }
        }
        private void Opttous_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Opttous.Checked)
            {
                OptMec.Checked = false;
                OptElec.Checked = false;
                cmdsupprimer.Enabled = false;
                ADODB.Recordset tbltype = new ADODB.Recordset();
                lsttype.Items.Clear();
                tbltype.Open("SELECT  DISTINCT * FROM TBL_PUNCH_TYPE  ORDER BY NAME ", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                while (!tbltype.EOF)
                {
                    ListViewItem LIST = lsttype.Items.Add("");
                    LIST.Text = (string)(tbltype.Fields["mode"].Value);
                    LIST.SubItems.Add(tbltype.Fields["name"].Value);
                    tbltype.MoveNext();
                }
                tbltype.Close();
                tbltype = null;
            }
        }
    }
}