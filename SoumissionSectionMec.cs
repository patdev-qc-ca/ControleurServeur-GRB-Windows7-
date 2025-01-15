using System;
using System.Diagnostics;
using System.Windows.Forms;
using ADODB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static ControleurServeur.Program;
namespace ControleurServeur
{
    internal class SoumissionSectionMec : Form
    {
        #region Windows Form Designer generated code 
        [DebuggerNonUserCode()]
        public SoumissionSectionMec() : base()
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
        internal TextBox txtFrancais;
        internal TextBox txtAnglais;
        internal Button cmdOK;
        internal Button cmdAnnuler;
        internal Label Label2;
        internal Label Label3;
        internal GroupBox fraAjout;
        internal Button CmdSupp;
        internal Button CmdFerme;
        internal Button cmdUp;
        internal Button cmdDown;
        internal Button CmdAdd;
        internal Button cmdModifier;
        internal ColumnHeader _lvwSection_ColumnHeader_1;
        internal ColumnHeader _lvwSection_ColumnHeader_2;
        internal ListView lvwSection;
        internal Label _Label1_0;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            fraAjout = new System.Windows.Forms.GroupBox();
            txtFrancais = new System.Windows.Forms.TextBox();
            txtAnglais = new System.Windows.Forms.TextBox();
            cmdOK = new System.Windows.Forms.Button();
            cmdAnnuler = new System.Windows.Forms.Button();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            CmdSupp = new System.Windows.Forms.Button();
            CmdFerme = new System.Windows.Forms.Button();
            cmdUp = new System.Windows.Forms.Button();
            cmdDown = new System.Windows.Forms.Button();
            CmdAdd = new System.Windows.Forms.Button();
            cmdModifier = new System.Windows.Forms.Button();
            lvwSection = new System.Windows.Forms.ListView();
            _lvwSection_ColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _lvwSection_ColumnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Label1_0 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            listView2 = new System.Windows.Forms.ListView();
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label7 = new System.Windows.Forms.Label();
            listView3 = new System.Windows.Forms.ListView();
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            button13 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            button15 = new System.Windows.Forms.Button();
            button16 = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            fraAjout.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // fraAjout
            // 
            fraAjout.BackColor = System.Drawing.Color.Black;
            fraAjout.Controls.Add(txtFrancais);
            fraAjout.Controls.Add(txtAnglais);
            fraAjout.Controls.Add(cmdOK);
            fraAjout.Controls.Add(cmdAnnuler);
            fraAjout.Controls.Add(Label2);
            fraAjout.Controls.Add(Label3);
            fraAjout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fraAjout.Location = new System.Drawing.Point(11, 126);
            fraAjout.Name = "fraAjout";
            fraAjout.Padding = new System.Windows.Forms.Padding(0);
            fraAjout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraAjout.Size = new System.Drawing.Size(305, 81);
            fraAjout.TabIndex = 3;
            fraAjout.TabStop = false;
            fraAjout.Text = "Ajout de nouvelles sections";
            fraAjout.Visible = false;
            // 
            // txtFrancais
            // 
            txtFrancais.AcceptsReturn = true;
            txtFrancais.BackColor = System.Drawing.Color.Black;
            txtFrancais.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtFrancais.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtFrancais.Location = new System.Drawing.Point(64, 24);
            txtFrancais.MaxLength = 0;
            txtFrancais.Name = "txtFrancais";
            txtFrancais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtFrancais.Size = new System.Drawing.Size(153, 20);
            txtFrancais.TabIndex = 6;
            // 
            // txtAnglais
            // 
            txtAnglais.AcceptsReturn = true;
            txtAnglais.BackColor = System.Drawing.Color.Black;
            txtAnglais.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtAnglais.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtAnglais.Location = new System.Drawing.Point(64, 48);
            txtAnglais.MaxLength = 0;
            txtAnglais.Name = "txtAnglais";
            txtAnglais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAnglais.Size = new System.Drawing.Size(153, 20);
            txtAnglais.TabIndex = 8;
            // 
            // cmdOK
            // 
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            cmdOK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdOK.Location = new System.Drawing.Point(232, 48);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(57, 25);
            cmdOK.TabIndex = 9;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.Cursor = System.Windows.Forms.Cursors.Default;
            cmdAnnuler.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdAnnuler.Location = new System.Drawing.Point(232, 16);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(57, 25);
            cmdAnnuler.TabIndex = 4;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // Label2
            // 
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.Cursor = System.Windows.Forms.Cursors.Default;
            Label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.Location = new System.Drawing.Point(16, 24);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(41, 17);
            Label2.TabIndex = 5;
            Label2.Text = "Français";
            // 
            // Label3
            // 
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.Cursor = System.Windows.Forms.Cursors.Default;
            Label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.Location = new System.Drawing.Point(16, 48);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(41, 17);
            Label3.TabIndex = 7;
            Label3.Text = "Anglais";
            // 
            // CmdSupp
            // 
            CmdSupp.BackColor = System.Drawing.Color.Black;
            CmdSupp.Cursor = System.Windows.Forms.Cursors.Default;
            CmdSupp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdSupp.Location = new System.Drawing.Point(318, 389);
            CmdSupp.Name = "CmdSupp";
            CmdSupp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdSupp.Size = new System.Drawing.Size(97, 33);
            CmdSupp.TabIndex = 2;
            CmdSupp.Text = "&Supprimer";
            CmdSupp.UseVisualStyleBackColor = true;
            CmdSupp.Click += new System.EventHandler(CmdSupp_Click);
            // 
            // CmdFerme
            // 
            CmdFerme.BackColor = System.Drawing.Color.Black;
            CmdFerme.Cursor = System.Windows.Forms.Cursors.Default;
            CmdFerme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdFerme.Location = new System.Drawing.Point(524, 388);
            CmdFerme.Name = "CmdFerme";
            CmdFerme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdFerme.Size = new System.Drawing.Size(97, 33);
            CmdFerme.TabIndex = 14;
            CmdFerme.Text = "&Fermer";
            CmdFerme.UseVisualStyleBackColor = true;
            CmdFerme.Click += new System.EventHandler(CmdFerme_Click);
            // 
            // cmdUp
            // 
            cmdUp.BackColor = System.Drawing.Color.Black;
            cmdUp.Cursor = System.Windows.Forms.Cursors.Default;
            cmdUp.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            cmdUp.Location = new System.Drawing.Point(3, 134);
            cmdUp.Name = "cmdUp";
            cmdUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdUp.Size = new System.Drawing.Size(33, 33);
            cmdUp.TabIndex = 10;
            cmdUp.Text = "Ç";
            cmdUp.UseVisualStyleBackColor = true;
            cmdUp.Click += new System.EventHandler(cmdUp_Click);
            // 
            // cmdDown
            // 
            cmdDown.BackColor = System.Drawing.Color.Black;
            cmdDown.Cursor = System.Windows.Forms.Cursors.Default;
            cmdDown.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            cmdDown.Location = new System.Drawing.Point(3, 182);
            cmdDown.Name = "cmdDown";
            cmdDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdDown.Size = new System.Drawing.Size(33, 33);
            cmdDown.TabIndex = 12;
            cmdDown.Text = "È";
            cmdDown.UseVisualStyleBackColor = true;
            cmdDown.Click += new System.EventHandler(cmdDown_Click);
            // 
            // CmdAdd
            // 
            CmdAdd.BackColor = System.Drawing.Color.Black;
            CmdAdd.Cursor = System.Windows.Forms.Cursors.Default;
            CmdAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmdAdd.Location = new System.Drawing.Point(215, 388);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CmdAdd.Size = new System.Drawing.Size(97, 33);
            CmdAdd.TabIndex = 1;
            CmdAdd.Text = "&Ajouter";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += new System.EventHandler(CmdAdd_Click);
            // 
            // cmdModifier
            // 
            cmdModifier.BackColor = System.Drawing.Color.Black;
            cmdModifier.Cursor = System.Windows.Forms.Cursors.Default;
            cmdModifier.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmdModifier.Location = new System.Drawing.Point(421, 389);
            cmdModifier.Name = "cmdModifier";
            cmdModifier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdModifier.Size = new System.Drawing.Size(97, 33);
            cmdModifier.TabIndex = 11;
            cmdModifier.Text = "&Modifier";
            cmdModifier.UseVisualStyleBackColor = true;
            cmdModifier.Click += new System.EventHandler(cmdModifier_Click);
            // 
            // lvwSection
            // 
            lvwSection.BackColor = System.Drawing.Color.Black;
            lvwSection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _lvwSection_ColumnHeader_1,
            _lvwSection_ColumnHeader_2});
            lvwSection.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwSection.FullRowSelect = true;
            lvwSection.GridLines = true;
            lvwSection.HideSelection = false;
            lvwSection.Location = new System.Drawing.Point(43, 78);
            lvwSection.Name = "lvwSection";
            lvwSection.Size = new System.Drawing.Size(241, 193);
            lvwSection.TabIndex = 13;
            lvwSection.UseCompatibleStateImageBehavior = false;
            lvwSection.View = System.Windows.Forms.View.Details;
            lvwSection.Click += new System.EventHandler(lvwSection_Click);
            lvwSection.DoubleClick += new System.EventHandler(lvwSection_DoubleClick);
            // 
            // _lvwSection_ColumnHeader_1
            // 
            _lvwSection_ColumnHeader_1.Text = "Français";
            _lvwSection_ColumnHeader_1.Width = 195;
            // 
            // _lvwSection_ColumnHeader_2
            // 
            _lvwSection_ColumnHeader_2.Text = "Anglais";
            _lvwSection_ColumnHeader_2.Width = 195;
            // 
            // _Label1_0
            // 
            _Label1_0.BackColor = System.Drawing.Color.Black;
            _Label1_0.Cursor = System.Windows.Forms.Cursors.Default;
            _Label1_0.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _Label1_0.Location = new System.Drawing.Point(43, 62);
            _Label1_0.Name = "_Label1_0";
            _Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _Label1_0.Size = new System.Drawing.Size(89, 17);
            _Label1_0.TabIndex = 0;
            _Label1_0.Text = "Section";
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Black;
            label1.Cursor = System.Windows.Forms.Cursors.Default;
            label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(43, 62);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label1.Size = new System.Drawing.Size(89, 17);
            label1.TabIndex = 0;
            label1.Text = "Section";
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.Color.Black;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2});
            listView1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView1.ForeColor = System.Drawing.Color.White;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(43, 78);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(578, 305);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.Click += new System.EventHandler(lvwSection_Click);
            listView1.DoubleClick += new System.EventHandler(lvwSection_DoubleClick);
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Français";
            columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Anglais";
            columnHeader2.Width = 195;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Black;
            button1.Cursor = System.Windows.Forms.Cursors.Default;
            button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(421, 388);
            button1.Name = "button1";
            button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button1.Size = new System.Drawing.Size(97, 33);
            button1.TabIndex = 11;
            button1.Text = "&Modifier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(cmdModifier_Click);
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Black;
            button2.Cursor = System.Windows.Forms.Cursors.Default;
            button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(215, 388);
            button2.Name = "button2";
            button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button2.Size = new System.Drawing.Size(97, 33);
            button2.TabIndex = 1;
            button2.Text = "&Ajouter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(CmdAdd_Click);
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Black;
            button3.Cursor = System.Windows.Forms.Cursors.Default;
            button3.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(3, 182);
            button3.Name = "button3";
            button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button3.Size = new System.Drawing.Size(33, 33);
            button3.TabIndex = 12;
            button3.Text = "È";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(cmdDown_Click);
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Black;
            button4.Cursor = System.Windows.Forms.Cursors.Default;
            button4.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            button4.ForeColor = System.Drawing.Color.White;
            button4.Location = new System.Drawing.Point(3, 134);
            button4.Name = "button4";
            button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button4.Size = new System.Drawing.Size(33, 33);
            button4.TabIndex = 10;
            button4.Text = "Ç";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(cmdUp_Click);
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Black;
            button5.Cursor = System.Windows.Forms.Cursors.Default;
            button5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.ForeColor = System.Drawing.Color.White;
            button5.Location = new System.Drawing.Point(524, 388);
            button5.Name = "button5";
            button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button5.Size = new System.Drawing.Size(97, 33);
            button5.TabIndex = 14;
            button5.Text = "&Fermer";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(CmdFerme_Click);
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.Black;
            button6.Cursor = System.Windows.Forms.Cursors.Default;
            button6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button6.ForeColor = System.Drawing.Color.White;
            button6.Location = new System.Drawing.Point(318, 389);
            button6.Name = "button6";
            button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button6.Size = new System.Drawing.Size(97, 33);
            button6.TabIndex = 2;
            button6.Text = "&Supprimer";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(CmdSupp_Click);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Black;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(0);
            groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox1.Size = new System.Drawing.Size(305, 81);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajout de nouvelles sections";
            groupBox1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.BackColor = System.Drawing.Color.Black;
            textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox1.Location = new System.Drawing.Point(64, 24);
            textBox1.MaxLength = 0;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox1.Size = new System.Drawing.Size(153, 20);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.BackColor = System.Drawing.Color.Black;
            textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox2.Location = new System.Drawing.Point(64, 48);
            textBox2.MaxLength = 0;
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox2.Size = new System.Drawing.Size(153, 20);
            textBox2.TabIndex = 8;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.BackColor = System.Drawing.Color.Black;
            button7.Cursor = System.Windows.Forms.Cursors.Default;
            button7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button7.Location = new System.Drawing.Point(232, 48);
            button7.Name = "button7";
            button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button7.Size = new System.Drawing.Size(57, 25);
            button7.TabIndex = 9;
            button7.Text = "OK";
            button7.UseVisualStyleBackColor = true;
            button7.Click += new System.EventHandler(cmdOK_Click);
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.BackColor = System.Drawing.Color.Black;
            button8.Cursor = System.Windows.Forms.Cursors.Default;
            button8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button8.Location = new System.Drawing.Point(232, 16);
            button8.Name = "button8";
            button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button8.Size = new System.Drawing.Size(57, 25);
            button8.TabIndex = 4;
            button8.Text = "Annuler";
            button8.UseVisualStyleBackColor = true;
            button8.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Black;
            label4.Cursor = System.Windows.Forms.Cursors.Default;
            label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(16, 24);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label4.Size = new System.Drawing.Size(49, 14);
            label4.TabIndex = 5;
            label4.Text = "Français";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Black;
            label5.Cursor = System.Windows.Forms.Cursors.Default;
            label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(16, 48);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label5.Size = new System.Drawing.Size(43, 14);
            label5.TabIndex = 7;
            label5.Text = "Anglais";
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Black;
            label6.Cursor = System.Windows.Forms.Cursors.Default;
            label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(43, 62);
            label6.Name = "label6";
            label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label6.Size = new System.Drawing.Size(89, 17);
            label6.TabIndex = 0;
            label6.Text = "Section";
            // 
            // listView2
            // 
            listView2.BackColor = System.Drawing.Color.Black;
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader3,
            columnHeader4});
            listView2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.HideSelection = false;
            listView2.Location = new System.Drawing.Point(43, 78);
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(578, 305);
            listView2.TabIndex = 13;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            listView2.Click += new System.EventHandler(lvwSection_Click);
            listView2.DoubleClick += new System.EventHandler(lvwSection_DoubleClick);
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Français";
            columnHeader3.Width = 195;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Anglais";
            columnHeader4.Width = 195;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Black;
            label7.Cursor = System.Windows.Forms.Cursors.Default;
            label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(43, 62);
            label7.Name = "label7";
            label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label7.Size = new System.Drawing.Size(89, 17);
            label7.TabIndex = 0;
            label7.Text = "Section";
            // 
            // listView3
            // 
            listView3.BackColor = System.Drawing.Color.Black;
            listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader5,
            columnHeader6});
            listView3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listView3.ForeColor = System.Drawing.Color.White;
            listView3.FullRowSelect = true;
            listView3.GridLines = true;
            listView3.HideSelection = false;
            listView3.Location = new System.Drawing.Point(43, 79);
            listView3.Name = "listView3";
            listView3.Size = new System.Drawing.Size(578, 304);
            listView3.TabIndex = 13;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = System.Windows.Forms.View.Details;
            listView3.Click += new System.EventHandler(lvwSection_Click);
            listView3.DoubleClick += new System.EventHandler(lvwSection_DoubleClick);
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Français";
            columnHeader5.Width = 195;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Anglais";
            columnHeader6.Width = 195;
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.Color.Black;
            button9.Cursor = System.Windows.Forms.Cursors.Default;
            button9.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            button9.Location = new System.Drawing.Point(3, 182);
            button9.Name = "button9";
            button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button9.Size = new System.Drawing.Size(33, 33);
            button9.TabIndex = 12;
            button9.Text = "È";
            button9.UseVisualStyleBackColor = true;
            button9.Click += new System.EventHandler(cmdDown_Click);
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.Color.Black;
            button10.Cursor = System.Windows.Forms.Cursors.Default;
            button10.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            button10.Location = new System.Drawing.Point(3, 134);
            button10.Name = "button10";
            button10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button10.Size = new System.Drawing.Size(33, 33);
            button10.TabIndex = 10;
            button10.Text = "Ç";
            button10.UseVisualStyleBackColor = true;
            button10.Click += new System.EventHandler(cmdUp_Click);
            // 
            // button11
            // 
            button11.BackColor = System.Drawing.Color.Black;
            button11.Cursor = System.Windows.Forms.Cursors.Default;
            button11.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            button11.ForeColor = System.Drawing.Color.White;
            button11.Location = new System.Drawing.Point(3, 182);
            button11.Name = "button11";
            button11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button11.Size = new System.Drawing.Size(33, 33);
            button11.TabIndex = 12;
            button11.Text = "È";
            button11.UseVisualStyleBackColor = true;
            button11.Click += new System.EventHandler(cmdDown_Click);
            // 
            // button12
            // 
            button12.BackColor = System.Drawing.Color.Black;
            button12.Cursor = System.Windows.Forms.Cursors.Default;
            button12.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            button12.ForeColor = System.Drawing.Color.White;
            button12.Location = new System.Drawing.Point(3, 134);
            button12.Name = "button12";
            button12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button12.Size = new System.Drawing.Size(33, 33);
            button12.TabIndex = 10;
            button12.Text = "Ç";
            button12.UseVisualStyleBackColor = true;
            button12.Click += new System.EventHandler(cmdUp_Click);
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Black;
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button13);
            groupBox2.Controls.Add(button14);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.Location = new System.Drawing.Point(11, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(0);
            groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox2.Size = new System.Drawing.Size(305, 81);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ajout de nouvelles sections";
            groupBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.AcceptsReturn = true;
            textBox3.BackColor = System.Drawing.Color.Black;
            textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox3.Location = new System.Drawing.Point(64, 24);
            textBox3.MaxLength = 0;
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox3.Size = new System.Drawing.Size(153, 20);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.AcceptsReturn = true;
            textBox4.BackColor = System.Drawing.Color.Black;
            textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox4.Location = new System.Drawing.Point(64, 48);
            textBox4.MaxLength = 0;
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox4.Size = new System.Drawing.Size(153, 20);
            textBox4.TabIndex = 8;
            // 
            // button13
            // 
            button13.AutoSize = true;
            button13.BackColor = System.Drawing.Color.Black;
            button13.Cursor = System.Windows.Forms.Cursors.Default;
            button13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button13.Location = new System.Drawing.Point(232, 48);
            button13.Name = "button13";
            button13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button13.Size = new System.Drawing.Size(57, 25);
            button13.TabIndex = 9;
            button13.Text = "OK";
            button13.UseVisualStyleBackColor = true;
            button13.Click += new System.EventHandler(cmdOK_Click);
            // 
            // button14
            // 
            button14.AutoSize = true;
            button14.BackColor = System.Drawing.Color.Black;
            button14.Cursor = System.Windows.Forms.Cursors.Default;
            button14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button14.Location = new System.Drawing.Point(232, 16);
            button14.Name = "button14";
            button14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button14.Size = new System.Drawing.Size(57, 25);
            button14.TabIndex = 4;
            button14.Text = "Annuler";
            button14.UseVisualStyleBackColor = true;
            button14.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Black;
            label8.Cursor = System.Windows.Forms.Cursors.Default;
            label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(16, 24);
            label8.Name = "label8";
            label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label8.Size = new System.Drawing.Size(49, 14);
            label8.TabIndex = 5;
            label8.Text = "Français";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Black;
            label9.Cursor = System.Windows.Forms.Cursors.Default;
            label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(16, 48);
            label9.Name = "label9";
            label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label9.Size = new System.Drawing.Size(43, 14);
            label9.TabIndex = 7;
            label9.Text = "Anglais";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Black;
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(button15);
            groupBox3.Controls.Add(button16);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox3.ForeColor = System.Drawing.Color.White;
            groupBox3.Location = new System.Drawing.Point(14, 126);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(0);
            groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox3.Size = new System.Drawing.Size(305, 81);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ajout de nouvelles sections";
            groupBox3.Visible = false;
            // 
            // textBox5
            // 
            textBox5.AcceptsReturn = true;
            textBox5.BackColor = System.Drawing.Color.Black;
            textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox5.Location = new System.Drawing.Point(64, 24);
            textBox5.MaxLength = 0;
            textBox5.Name = "textBox5";
            textBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox5.Size = new System.Drawing.Size(153, 20);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.AcceptsReturn = true;
            textBox6.BackColor = System.Drawing.Color.Black;
            textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox6.Location = new System.Drawing.Point(64, 48);
            textBox6.MaxLength = 0;
            textBox6.Name = "textBox6";
            textBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox6.Size = new System.Drawing.Size(153, 20);
            textBox6.TabIndex = 8;
            // 
            // button15
            // 
            button15.AutoSize = true;
            button15.BackColor = System.Drawing.Color.Black;
            button15.Cursor = System.Windows.Forms.Cursors.Default;
            button15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button15.Location = new System.Drawing.Point(232, 48);
            button15.Name = "button15";
            button15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button15.Size = new System.Drawing.Size(57, 25);
            button15.TabIndex = 9;
            button15.Text = "OK";
            button15.UseVisualStyleBackColor = true;
            button15.Click += new System.EventHandler(cmdOK_Click);
            // 
            // button16
            // 
            button16.AutoSize = true;
            button16.BackColor = System.Drawing.Color.Black;
            button16.Cursor = System.Windows.Forms.Cursors.Default;
            button16.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button16.Location = new System.Drawing.Point(232, 16);
            button16.Name = "button16";
            button16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button16.Size = new System.Drawing.Size(57, 25);
            button16.TabIndex = 4;
            button16.Text = "Annuler";
            button16.UseVisualStyleBackColor = true;
            button16.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Black;
            label10.Cursor = System.Windows.Forms.Cursors.Default;
            label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(16, 24);
            label10.Name = "label10";
            label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label10.Size = new System.Drawing.Size(49, 14);
            label10.TabIndex = 5;
            label10.Text = "Français";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Black;
            label11.Cursor = System.Windows.Forms.Cursors.Default;
            label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(16, 48);
            label11.Name = "label11";
            label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label11.Size = new System.Drawing.Size(43, 14);
            label11.TabIndex = 7;
            label11.Text = "Anglais";
            // 
            // SoumissionSectionMec
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(633, 453);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button6);
            Controls.Add(fraAjout);
            Controls.Add(button5);
            Controls.Add(button12);
            Controls.Add(CmdSupp);
            Controls.Add(button4);
            Controls.Add(button11);
            Controls.Add(CmdFerme);
            Controls.Add(button10);
            Controls.Add(button3);
            Controls.Add(cmdUp);
            Controls.Add(button9);
            Controls.Add(button2);
            Controls.Add(cmdDown);
            Controls.Add(button1);
            Controls.Add(listView3);
            Controls.Add(CmdAdd);
            Controls.Add(listView1);
            Controls.Add(label7);
            Controls.Add(cmdModifier);
            Controls.Add(listView2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(lvwSection);
            Controls.Add(_Label1_0);
            Cursor = System.Windows.Forms.Cursors.Default;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = ControleurServeur.Properties.Resources.drapeauGRB;
            Cursor = System.Windows.Forms.Cursors.Default;
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            Icon = ControleurServeur.Properties.Resources.IconeApp;
            Location = new System.Drawing.Point(4, 23);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SoumissionSectionMec";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Sections mécaniques";
            Load += new System.EventHandler(SoumissionSectionMec_Load);
            fraAjout.ResumeLayout(false);
            fraAjout.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);

        }
        #endregion
        internal static Label label1;
        internal static ListView listView1;
        internal static ColumnHeader columnHeader1;
        internal static ColumnHeader columnHeader2;
        internal static Button button1;
        internal static Button button2;
        internal static Button button3;
        internal static Button button4;
        internal static Button button5;
        internal static Button button6;
        internal static GroupBox groupBox1;
        internal static TextBox textBox1;
        internal static TextBox textBox2;
        internal static Button button7;
        internal static Button button8;
        internal static Label label4;
        internal static Label label5;
        internal static Label label6;
        internal static ListView listView2;
        internal static ColumnHeader columnHeader3;
        internal static ColumnHeader columnHeader4;
        internal static Label label7;
        internal static ListView listView3;
        internal static ColumnHeader columnHeader5;
        internal static ColumnHeader columnHeader6;
        internal static Button button9;
        internal static Button button10;
        internal static Button button11;
        internal static Button button12;
        internal static GroupBox groupBox2;
        internal static TextBox textBox3;
        internal static TextBox textBox4;
        internal static Button button13;
        internal static Button button14;
        internal static Label label8;
        internal static Label label9;
        internal static GroupBox groupBox3;
        internal static TextBox textBox5;
        internal static TextBox textBox6;
        internal static Button button15;
        internal static Button button16;
        internal static Label label10;
        internal static Label label11;
        private const int I_COL_FRANCAIS = 0;
        private const int I_COL_ANGLAIS = 1;
        private bool m_bAjout;
        private void Sauvegarde()
        {
            try
            {
                ADODB.Recordset rstSection;
                int X;
                rstSection = new Recordset();
                var loopTo = (int)lvwSection.Items.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    rstSection.Open(Operators.ConcatenateObject("SELECT NomSectionFR, NomSectionEN, Ordre FROM SoumProjSectionMec WHERE IDSection = ", lvwSection.Items[X].Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstSection.Fields["Ordre"].Value = X;
                    rstSection.Update();
                    rstSection.Close();
                }
                rstSection = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "Sauvegarde", ex);
            }
        }
        private void RemplirListViewSection()
        {
            try
            {
                ADODB.Recordset rstSection;
                ListViewItem itmSection;
                rstSection = new Recordset();
                rstSection.Open("SELECT * FROM SoumProjSectionMec ORDER BY Ordre", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                lvwSection.Items.Clear();
                while (!rstSection.EOF)
                {
                    itmSection = lvwSection.Items.Add("");
                    itmSection.Tag = rstSection.Fields["IDSection"].Value;
                    itmSection.Text = (string)(rstSection.Fields["NomSectionFR"].Value);
                    if (!(rstSection.Fields["NomSectionEN"].Value is DBNull))
                    {
                        if (itmSection.SubItems.Count > I_COL_ANGLAIS)
                        {
                            itmSection.SubItems[I_COL_ANGLAIS].Text = (string)(rstSection.Fields["NomSectionEN"].Value);
                        }
                        else
                        {
                            itmSection.SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, (string)(rstSection.Fields["NomSectionEN"].Value)));
                        }
                    }
                    else if (itmSection.SubItems.Count > I_COL_ANGLAIS)
                    {
                        itmSection.SubItems[I_COL_ANGLAIS].Text = string.Empty;
                    }
                    else
                    {
                        itmSection.SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    rstSection.MoveNext();
                }
                rstSection.Close();
                rstSection = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "RemplirListViewSection", ex);
            }
        }
        private void CmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bAjout = true;
                txtAnglais.Text = string.Empty;
                txtFrancais.Text = string.Empty;
                fraAjout.Visible = true;
                txtFrancais.Focus();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "CmdAdd_Click", ex);
            }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraAjout.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstSection;
                ADODB.Recordset rstMaxOrdre;
                if (string.IsNullOrEmpty(Strings.Trim(txtFrancais.Text)) | string.IsNullOrEmpty(Strings.Trim(txtAnglais.Text)))
                {
                    MessageBox.Show("Le nom en français et est obligatoire!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                rstSection = new Recordset();
                if (m_bAjout == true)
                {
                    rstSection.Open("SELECT * FROM SoumProjSectionMec WHERE NomSectionFR = '" + Strings.Replace(txtFrancais.Text, "'", "''") + "' OR NomSectionEN = '" + Strings.Replace(txtAnglais.Text, "'", "''") + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (rstSection.EOF)
                    {
                        rstMaxOrdre = new Recordset();
                        rstMaxOrdre.Open("SELECT Max(Ordre) as MaxOrdre FROM SoumProjSectionMec", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstSection.AddNew();
                        rstSection.Fields["NomSectionFR"].Value = txtFrancais.Text;
                        rstSection.Fields["NomSectionEN"].Value = txtAnglais.Text;
                        rstSection.Fields["Ordre"].Value = Operators.AddObject(rstMaxOrdre.Fields["MaxOrdre"].Value, 1);
                        rstMaxOrdre.Close();
                        rstMaxOrdre = null;
                        rstSection.Update();
                        m_bAjout = false;
                    }
                    else
                    {
                        MessageBox.Show("Cette section existe déjà!");
                    }
                    rstSection.Close();
                    rstSection = null;
                }
                else
                {
                    rstSection.Open(Operators.ConcatenateObject("SELECT * FROM SoumProjSectionMec WHERE IDSection = ", lvwSection.FocusedItem.Tag), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    rstSection.Fields["NomSectionFR"].Value = txtFrancais.Text;
                    rstSection.Fields["NomSectionEN"].Value = txtAnglais.Text;
                    rstSection.Update();
                    rstSection.Close();
                    rstSection = null;
                }
                RemplirListViewSection();
                fraAjout.Visible = false;
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "CmdOK_Click", ex);
            }
        }
        private void cmdDown_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sTagAvant;
                string sTagApres;
                string sFrancaisAvant;
                string sFrancaisApres;
                string sAnglaisAvant;
                string sAnglaisApres;
                int iIndex;
                iIndex = (int)lvwSection.FocusedItem.Index;
                if (iIndex < lvwSection.Items.Count)
                {
                    sTagAvant = (string)(lvwSection.Items[iIndex].Tag);
                    sFrancaisAvant = lvwSection.Items[iIndex].Text;
                    sAnglaisAvant = lvwSection.Items[iIndex].SubItems[I_COL_ANGLAIS].Text;
                    sTagApres = (string)(lvwSection.Items[iIndex + 1].Tag);
                    sFrancaisApres = lvwSection.Items[iIndex + 1].Text;
                    sAnglaisApres = lvwSection.Items[iIndex + 1].SubItems[I_COL_ANGLAIS].Text;
                    lvwSection.Items[iIndex].Tag = sTagApres;
                    lvwSection.Items[iIndex].Text = sFrancaisApres;
                    if (lvwSection.Items[iIndex].SubItems.Count > I_COL_ANGLAIS)
                    {
                        lvwSection.Items[iIndex].SubItems[I_COL_ANGLAIS].Text = sAnglaisApres;
                    }
                    else
                    {
                        lvwSection.Items[iIndex].SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, sAnglaisApres));
                    }
                    lvwSection.Items[iIndex + 1].Tag = sTagAvant;
                    lvwSection.Items[iIndex + 1].Text = sFrancaisAvant;
                    if (lvwSection.Items[iIndex + 1].SubItems.Count > I_COL_ANGLAIS)
                    {
                        lvwSection.Items[iIndex + 1].SubItems[I_COL_ANGLAIS].Text = sAnglaisAvant;
                    }
                    else
                    {
                        lvwSection.Items[iIndex + 1].SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, sAnglaisAvant));
                    }
                    lvwSection.Items[iIndex + 1].Selected = true;
                    lvwSection.FocusedItem.EnsureVisible();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "cmdDown_Click", ex);
            }
        }
        private void cmdUp_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sTagAvant;
                string sTagApres;
                string sFrancaisAvant;
                string sFrancaisApres;
                string sAnglaisAvant;
                string sAnglaisApres;
                int iIndex;
                iIndex = (int)lvwSection.FocusedItem.Index;
                if (iIndex > 1)
                {

                    sTagAvant = (string)(lvwSection.Items[iIndex].Tag);
                    sFrancaisAvant = lvwSection.Items[iIndex].Text;
                    sAnglaisAvant = lvwSection.Items[iIndex].SubItems[I_COL_ANGLAIS].Text;
                    sTagApres = (string)(lvwSection.Items[iIndex - 1].Tag);
                    sFrancaisApres = lvwSection.Items[iIndex - 1].Text;
                    sAnglaisApres = lvwSection.Items[iIndex - 1].SubItems[I_COL_ANGLAIS].Text;
                    lvwSection.Items[iIndex].Tag = sTagApres;
                    lvwSection.Items[iIndex].Text = sFrancaisApres;
                    if (lvwSection.Items[iIndex].SubItems.Count > I_COL_ANGLAIS)
                    {
                        lvwSection.Items[iIndex].SubItems[I_COL_ANGLAIS].Text = sAnglaisApres;
                    }
                    else
                    {
                        lvwSection.Items[iIndex].SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, sAnglaisApres));
                    }
                    lvwSection.Items[iIndex - 1].Tag = sTagAvant;
                    lvwSection.Items[iIndex - 1].Text = sFrancaisAvant;
                    if (lvwSection.Items[iIndex - 1].SubItems.Count > I_COL_ANGLAIS)
                    {
                        lvwSection.Items[iIndex - 1].SubItems[I_COL_ANGLAIS].Text = sAnglaisAvant;
                    }
                    else
                    {
                        lvwSection.Items[iIndex - 1].SubItems.Insert(I_COL_ANGLAIS, new ListViewItem.ListViewSubItem(null, sAnglaisAvant));
                    }
                    lvwSection.Items[iIndex - 1].Selected = true;
                    lvwSection.FocusedItem.EnsureVisible();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "cmdUp_Click", ex);
            }
        }
        private void CmdFerme_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                Sauvegarde();
                Close();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "CmdFerme_Click", ex);
            }
        }
        private void cmdModifier_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtFrancais.Text = lvwSection.FocusedItem.Text;
                txtAnglais.Text = lvwSection.FocusedItem.SubItems[I_COL_ANGLAIS].Text;
                fraAjout.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "cmdModifier_Click", ex);
            }
        }
        private void CmdSupp_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstSoumission;
                if (lvwSection.Items.Count > 0)
                {
                    if (MessageBox.Show("Etes-vous sur de supprimer cette enregistrement?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        rstSoumission = new Recordset();
                        rstSoumission.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT IDSection FROM Soumission_pieces WHERE IDSection = ", lvwSection.FocusedItem.Tag), " AND Type = 'M'"), odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (rstSoumission.EOF)
                        {
                            UpdateSQL("DELETE FROM SoumProjSectionMec WHERE IDsection = " + lvwSection.FocusedItem.Tag.ToString());
                            if (lvwSection.Items.Count > 0)
                            {
                                lvwSection.Items[1].Selected = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Impossible de supprimer une section déjà utilisé dans une soumission!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        rstSoumission.Close();
                        rstSoumission = null;
                        RemplirListViewSection();
                    }
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement sélectionné!");
                }
                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "CmdSupp_Click", ex);
            }
        }
        private void SoumissionSectionMec_Load(object eventSender, EventArgs eventArgs)
        {
            Icon = Conteneur.ActiveForm.Icon;
            try
            {
                RemplirListViewSection();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "Form_Load", ex);
            }
        }
        private void lvwSection_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwSection.Items.Count > 0)
                {
                    if (lvwSection.FocusedItem.Index == lvwSection.Items.Count)
                    {
                        cmdDown.Enabled = false;
                    }
                    else
                    {
                        cmdDown.Enabled = true;
                    }
                    if (lvwSection.FocusedItem.Index == 1)
                    {
                        cmdUp.Enabled = false;
                    }
                    else
                    {
                        cmdUp.Enabled = true;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "lvwSection_Click", ex);
            }
        }
        private void lvwSection_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtFrancais.Text = lvwSection.FocusedItem.Text;
                txtAnglais.Text = lvwSection.FocusedItem.SubItems[I_COL_ANGLAIS].Text;
                fraAjout.Visible = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("SoumissionSectionMec", "lvwSection_DblClick", ex);
            }
        }
    }
}