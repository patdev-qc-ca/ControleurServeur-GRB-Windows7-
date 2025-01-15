using ADODB;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static ControleurServeur.Program;
using Label = System.Windows.Forms.Label;
using ListView = System.Windows.Forms.ListView;
using ListViewItem = System.Windows.Forms.ListViewItem;
using static Microsoft.VisualBasic.Interaction;
using ControleurServeur;
#pragma warning disable CS0219
namespace ControleurServeur
{
    public class Punch : Form
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
            components = new System.ComponentModel.Container();
            lvwJourSemaine2 = new System.Windows.Forms.ListView();
            lvwJourSemaine2ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine2ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            NoPunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            picPMTypePunch = new System.Windows.Forms.GroupBox();
            optPMTypePunch1 = new System.Windows.Forms.RadioButton();
            optPMTypePunch0 = new System.Windows.Forms.RadioButton();
            lvwJourSemaine7ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine7ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine6ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine6ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine5ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine5ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine4ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine4ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine4 = new System.Windows.Forms.ListView();
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine3ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine1 = new System.Windows.Forms.ListView();
            lvwJourSemaine1ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine1ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            NoPunch0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine3ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine3 = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine5 = new System.Windows.Forms.ListView();
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            mskPMHeureFin = new System.Windows.Forms.MaskedTextBox();
            mskPMHeureDebut = new System.Windows.Forms.MaskedTextBox();
            Label10 = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            cmbPMType = new System.Windows.Forms.ComboBox();
            optPMHeureDiner1 = new System.Windows.Forms.RadioButton();
            optPMHeureDiner0 = new System.Windows.Forms.RadioButton();
            cmdPMOK = new System.Windows.Forms.Button();
            Frame2 = new System.Windows.Forms.GroupBox();
            cmdPunchOut = new System.Windows.Forms.Button();
            cmdModifierPunchOut = new System.Windows.Forms.Button();
            cmdPunchIn = new System.Windows.Forms.Button();
            cmdModifierPunchIn = new System.Windows.Forms.Button();
            txtPMCommentaire = new System.Windows.Forms.TextBox();
            lvwJourColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            fraJour = new System.Windows.Forms.Panel();
            lvwJour = new System.Windows.Forms.ListView();
            lvwJourColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            fraPunchMultiple = new System.Windows.Forms.GroupBox();
            cmdPMAnnuler = new System.Windows.Forms.Button();
            txtPMClient = new System.Windows.Forms.TextBox();
            chkPMDiner = new System.Windows.Forms.CheckBox();
            mskPMNoProjet = new System.Windows.Forms.MaskedTextBox();
            lblPMTypePunch = new System.Windows.Forms.Label();
            lblPMType = new System.Windows.Forms.Label();
            Label9 = new System.Windows.Forms.Label();
            lblPMPrefixe = new System.Windows.Forms.Label();
            Label7 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            lvwEmployes = new System.Windows.Forms.ListView();
            lvwEmployesColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            cmbHeureSemaine = new System.Windows.Forms.ComboBox();
            lblNbreHeure = new System.Windows.Forms.Label();
            lblTitreHeure = new System.Windows.Forms.Label();
            fraSemaine = new System.Windows.Forms.GroupBox();
            lvwJourSemaine6 = new System.Windows.Forms.ListView();
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvwJourSemaine7 = new System.Windows.Forms.ListView();
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblNomJour0 = new System.Windows.Forms.Label();
            lblNomJour1 = new System.Windows.Forms.Label();
            lblNomJour2 = new System.Windows.Forms.Label();
            lblNomJour3 = new System.Windows.Forms.Label();
            lblNomJour4 = new System.Windows.Forms.Label();
            lblNomJour5 = new System.Windows.Forms.Label();
            lblNomJour6 = new System.Windows.Forms.Label();
            lblJour0 = new System.Windows.Forms.Label();
            lblJour1 = new System.Windows.Forms.Label();
            lblJour2 = new System.Windows.Forms.Label();
            lblJour3 = new System.Windows.Forms.Label();
            lblJour4 = new System.Windows.Forms.Label();
            lblJour5 = new System.Windows.Forms.Label();
            lblJour6 = new System.Windows.Forms.Label();
            mvwSelection = new System.Windows.Forms.DateTimePicker();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            Label3 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            lblprojet = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            lblPrefixe = new System.Windows.Forms.Label();
            lblType = new System.Windows.Forms.Label();
            lblTypePunch = new System.Windows.Forms.Label();
            txtNoProjet = new System.Windows.Forms.TextBox();
            txtEmploye = new System.Windows.Forms.TextBox();
            cmdOK = new System.Windows.Forms.Button();
            picTypePunch = new System.Windows.Forms.GroupBox();
            optTypePunch0 = new System.Windows.Forms.RadioButton();
            optTypePunch1 = new System.Windows.Forms.RadioButton();
            cmbEmploye = new System.Windows.Forms.ComboBox();
            fraHeure = new System.Windows.Forms.GroupBox();
            mskHeure = new System.Windows.Forms.MaskedTextBox();
            optHeure1 = new System.Windows.Forms.RadioButton();
            optHeure0 = new System.Windows.Forms.RadioButton();
            txtCommentaires = new System.Windows.Forms.TextBox();
            cmdAnnuler = new System.Windows.Forms.Button();
            txtClient = new System.Windows.Forms.TextBox();
            chkKM = new System.Windows.Forms.CheckBox();
            txtKM = new System.Windows.Forms.TextBox();
            chkDiner = new System.Windows.Forms.CheckBox();
            optHeureDiner0 = new System.Windows.Forms.RadioButton();
            optHeureDiner1 = new System.Windows.Forms.RadioButton();
            cmbType = new System.Windows.Forms.ComboBox();
            fraPunch = new System.Windows.Forms.GroupBox();
            picPMTypePunch.SuspendLayout();
            Frame2.SuspendLayout();
            fraJour.SuspendLayout();
            fraPunchMultiple.SuspendLayout();
            fraSemaine.SuspendLayout();
            statusStrip1.SuspendLayout();
            picTypePunch.SuspendLayout();
            fraHeure.SuspendLayout();
            fraPunch.SuspendLayout();
            SuspendLayout();
            // 
            // lvwJourSemaine2
            // 
            lvwJourSemaine2.BackColor = System.Drawing.Color.Black;
            lvwJourSemaine2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwJourSemaine2ColumnHeader1,
            lvwJourSemaine2ColumnHeader2,
            NoPunch});
            lvwJourSemaine2.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwJourSemaine2.ForeColor = System.Drawing.Color.White;
            lvwJourSemaine2.FullRowSelect = true;
            lvwJourSemaine2.GridLines = true;
            lvwJourSemaine2.HideSelection = false;
            lvwJourSemaine2.Location = new System.Drawing.Point(123, 48);
            lvwJourSemaine2.Name = "lvwJourSemaine2";
            lvwJourSemaine2.Size = new System.Drawing.Size(124, 234);
            lvwJourSemaine2.TabIndex = 44;
            lvwJourSemaine2.UseCompatibleStateImageBehavior = false;
            lvwJourSemaine2.View = System.Windows.Forms.View.Details;
            // 
            // lvwJourSemaine2ColumnHeader1
            // 
            lvwJourSemaine2ColumnHeader1.Text = "nom";
            lvwJourSemaine2ColumnHeader1.Width = 40;
            // 
            // lvwJourSemaine2ColumnHeader2
            // 
            lvwJourSemaine2ColumnHeader2.Text = "heure";
            lvwJourSemaine2ColumnHeader2.Width = 119;
            // 
            // NoPunch
            // 
            NoPunch.Text = "#Punch";
            // 
            // picPMTypePunch
            // 
            picPMTypePunch.BackColor = System.Drawing.Color.Black;
            picPMTypePunch.Controls.Add(optPMTypePunch1);
            picPMTypePunch.Controls.Add(optPMTypePunch0);
            picPMTypePunch.ForeColor = System.Drawing.Color.White;
            picPMTypePunch.Location = new System.Drawing.Point(203, 46);
            picPMTypePunch.Name = "picPMTypePunch";
            picPMTypePunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            picPMTypePunch.Size = new System.Drawing.Size(183, 49);
            picPMTypePunch.TabIndex = 79;
            picPMTypePunch.TabStop = false;
            picPMTypePunch.Text = "00";
            // 
            // optPMTypePunch1
            // 
            optPMTypePunch1.AutoSize = true;
            optPMTypePunch1.BackColor = System.Drawing.Color.Black;
            optPMTypePunch1.ForeColor = System.Drawing.Color.White;
            optPMTypePunch1.Location = new System.Drawing.Point(89, 14);
            optPMTypePunch1.Name = "optPMTypePunch1";
            optPMTypePunch1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optPMTypePunch1.Size = new System.Drawing.Size(79, 18);
            optPMTypePunch1.TabIndex = 78;
            optPMTypePunch1.TabStop = true;
            optPMTypePunch1.Text = "Mécanique";
            optPMTypePunch1.UseVisualStyleBackColor = true;
            optPMTypePunch1.CheckedChanged += new System.EventHandler(optPMTypePunch1_CheckedChanged);
            // 
            // optPMTypePunch0
            // 
            optPMTypePunch0.AutoSize = true;
            optPMTypePunch0.BackColor = System.Drawing.Color.Black;
            optPMTypePunch0.ForeColor = System.Drawing.Color.White;
            optPMTypePunch0.Location = new System.Drawing.Point(10, 14);
            optPMTypePunch0.Name = "optPMTypePunch0";
            optPMTypePunch0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optPMTypePunch0.Size = new System.Drawing.Size(74, 18);
            optPMTypePunch0.TabIndex = 77;
            optPMTypePunch0.TabStop = true;
            optPMTypePunch0.Text = "Électrique";
            optPMTypePunch0.UseVisualStyleBackColor = true;
            optPMTypePunch0.CheckedChanged += new System.EventHandler(optPMTypePunch0_CheckedChanged);
            // 
            // lvwJourSemaine7ColumnHeader2
            // 
            lvwJourSemaine7ColumnHeader2.Text = "heure";
            lvwJourSemaine7ColumnHeader2.Width = 119;
            // 
            // lvwJourSemaine7ColumnHeader1
            // 
            lvwJourSemaine7ColumnHeader1.Text = "nom";
            lvwJourSemaine7ColumnHeader1.Width = 38;
            // 
            // lvwJourSemaine6ColumnHeader2
            // 
            lvwJourSemaine6ColumnHeader2.Text = "heure";
            lvwJourSemaine6ColumnHeader2.Width = 119;
            // 
            // lvwJourSemaine6ColumnHeader1
            // 
            lvwJourSemaine6ColumnHeader1.Text = "nom";
            lvwJourSemaine6ColumnHeader1.Width = 35;
            // 
            // lvwJourSemaine5ColumnHeader2
            // 
            lvwJourSemaine5ColumnHeader2.Text = "heure";
            lvwJourSemaine5ColumnHeader2.Width = 119;
            // 
            // lvwJourSemaine5ColumnHeader1
            // 
            lvwJourSemaine5ColumnHeader1.Text = "nom";
            lvwJourSemaine5ColumnHeader1.Width = 34;
            // 
            // lvwJourSemaine4ColumnHeader2
            // 
            lvwJourSemaine4ColumnHeader2.Text = "heure";
            lvwJourSemaine4ColumnHeader2.Width = 119;
            // 
            // lvwJourSemaine4ColumnHeader1
            // 
            lvwJourSemaine4ColumnHeader1.Text = "nom";
            lvwJourSemaine4ColumnHeader1.Width = 37;
            // 
            // lvwJourSemaine4
            // 
            lvwJourSemaine4.BackColor = System.Drawing.Color.Black;
            lvwJourSemaine4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwJourSemaine4ColumnHeader1,
            lvwJourSemaine4ColumnHeader2,
            columnHeader2});
            lvwJourSemaine4.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwJourSemaine4.ForeColor = System.Drawing.Color.White;
            lvwJourSemaine4.FullRowSelect = true;
            lvwJourSemaine4.GridLines = true;
            lvwJourSemaine4.HideSelection = false;
            lvwJourSemaine4.Location = new System.Drawing.Point(370, 48);
            lvwJourSemaine4.Name = "lvwJourSemaine4";
            lvwJourSemaine4.Size = new System.Drawing.Size(124, 234);
            lvwJourSemaine4.TabIndex = 46;
            lvwJourSemaine4.UseCompatibleStateImageBehavior = false;
            lvwJourSemaine4.View = System.Windows.Forms.View.Details;
            lvwJourSemaine4.Click += new System.EventHandler(lvwJourSemaine4_Click);
            // 
            // lvwJourSemaine3ColumnHeader2
            // 
            lvwJourSemaine3ColumnHeader2.Text = "heure";
            lvwJourSemaine3ColumnHeader2.Width = 119;
            // 
            // lvwJourSemaine1
            // 
            lvwJourSemaine1.BackColor = System.Drawing.Color.Black;
            lvwJourSemaine1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwJourSemaine1ColumnHeader1,
            lvwJourSemaine1ColumnHeader2,
            NoPunch0});
            lvwJourSemaine1.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwJourSemaine1.ForeColor = System.Drawing.Color.White;
            lvwJourSemaine1.FullRowSelect = true;
            lvwJourSemaine1.GridLines = true;
            lvwJourSemaine1.HideSelection = false;
            lvwJourSemaine1.Location = new System.Drawing.Point(-1, 48);
            lvwJourSemaine1.Name = "lvwJourSemaine1";
            lvwJourSemaine1.Size = new System.Drawing.Size(124, 234);
            lvwJourSemaine1.TabIndex = 43;
            lvwJourSemaine1.UseCompatibleStateImageBehavior = false;
            lvwJourSemaine1.View = System.Windows.Forms.View.Details;
            lvwJourSemaine1.Click += new System.EventHandler(lvwJourSemaine1_Click);
            // 
            // lvwJourSemaine1ColumnHeader1
            // 
            lvwJourSemaine1ColumnHeader1.Text = "nom";
            lvwJourSemaine1ColumnHeader1.Width = 40;
            // 
            // lvwJourSemaine1ColumnHeader2
            // 
            lvwJourSemaine1ColumnHeader2.Text = "heure";
            lvwJourSemaine1ColumnHeader2.Width = 119;
            // 
            // lvwJourSemaine3ColumnHeader1
            // 
            lvwJourSemaine3ColumnHeader1.Text = "nom";
            lvwJourSemaine3ColumnHeader1.Width = 36;
            // 
            // lvwJourSemaine3
            // 
            lvwJourSemaine3.BackColor = System.Drawing.Color.Black;
            lvwJourSemaine3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwJourSemaine3ColumnHeader1,
            lvwJourSemaine3ColumnHeader2,
            columnHeader1});
            lvwJourSemaine3.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwJourSemaine3.ForeColor = System.Drawing.Color.White;
            lvwJourSemaine3.FullRowSelect = true;
            lvwJourSemaine3.GridLines = true;
            lvwJourSemaine3.HideSelection = false;
            lvwJourSemaine3.Location = new System.Drawing.Point(247, 48);
            lvwJourSemaine3.Name = "lvwJourSemaine3";
            lvwJourSemaine3.Size = new System.Drawing.Size(124, 234);
            lvwJourSemaine3.TabIndex = 45;
            lvwJourSemaine3.UseCompatibleStateImageBehavior = false;
            lvwJourSemaine3.View = System.Windows.Forms.View.Details;
            lvwJourSemaine3.Click += new System.EventHandler(lvwJourSemaine3_Click);
            // 
            // lvwJourSemaine5
            // 
            lvwJourSemaine5.BackColor = System.Drawing.Color.Black;
            lvwJourSemaine5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwJourSemaine5ColumnHeader1,
            lvwJourSemaine5ColumnHeader2,
            columnHeader3});
            lvwJourSemaine5.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwJourSemaine5.ForeColor = System.Drawing.Color.White;
            lvwJourSemaine5.FullRowSelect = true;
            lvwJourSemaine5.GridLines = true;
            lvwJourSemaine5.HideSelection = false;
            lvwJourSemaine5.Location = new System.Drawing.Point(494, 48);
            lvwJourSemaine5.Name = "lvwJourSemaine5";
            lvwJourSemaine5.Size = new System.Drawing.Size(124, 234);
            lvwJourSemaine5.TabIndex = 47;
            lvwJourSemaine5.UseCompatibleStateImageBehavior = false;
            lvwJourSemaine5.View = System.Windows.Forms.View.Details;
            lvwJourSemaine5.Click += new System.EventHandler(lvwJourSemaine5_Click);
            // 
            // mskPMHeureFin
            // 
            mskPMHeureFin.BackColor = System.Drawing.Color.Black;
            mskPMHeureFin.ForeColor = System.Drawing.Color.White;
            mskPMHeureFin.Location = new System.Drawing.Point(55, 40);
            mskPMHeureFin.Name = "mskPMHeureFin";
            mskPMHeureFin.Size = new System.Drawing.Size(65, 22);
            mskPMHeureFin.TabIndex = 60;
            // 
            // mskPMHeureDebut
            // 
            mskPMHeureDebut.BackColor = System.Drawing.Color.Black;
            mskPMHeureDebut.ForeColor = System.Drawing.Color.White;
            mskPMHeureDebut.Location = new System.Drawing.Point(55, 16);
            mskPMHeureDebut.Name = "mskPMHeureDebut";
            mskPMHeureDebut.Size = new System.Drawing.Size(65, 22);
            mskPMHeureDebut.TabIndex = 66;
            // 
            // Label10
            // 
            Label10.BackColor = System.Drawing.Color.Black;
            Label10.ForeColor = System.Drawing.Color.White;
            Label10.Location = new System.Drawing.Point(7, 40);
            Label10.Name = "Label10";
            Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label10.Size = new System.Drawing.Size(49, 17);
            Label10.TabIndex = 68;
            Label10.Text = "Fin :";
            // 
            // Label8
            // 
            Label8.BackColor = System.Drawing.Color.Black;
            Label8.ForeColor = System.Drawing.Color.White;
            Label8.Location = new System.Drawing.Point(7, 16);
            Label8.Name = "Label8";
            Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label8.Size = new System.Drawing.Size(49, 17);
            Label8.TabIndex = 67;
            Label8.Text = "Début :";
            // 
            // cmbPMType
            // 
            cmbPMType.BackColor = System.Drawing.Color.Black;
            cmbPMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPMType.ForeColor = System.Drawing.Color.White;
            cmbPMType.Location = new System.Drawing.Point(209, 164);
            cmbPMType.Name = "cmbPMType";
            cmbPMType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbPMType.Size = new System.Drawing.Size(361, 22);
            cmbPMType.TabIndex = 85;
            // 
            // optPMHeureDiner1
            // 
            optPMHeureDiner1.AutoSize = true;
            optPMHeureDiner1.BackColor = System.Drawing.Color.Black;
            optPMHeureDiner1.Enabled = false;
            optPMHeureDiner1.ForeColor = System.Drawing.Color.White;
            optPMHeureDiner1.Location = new System.Drawing.Point(409, 244);
            optPMHeureDiner1.Name = "optPMHeureDiner1";
            optPMHeureDiner1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optPMHeureDiner1.Size = new System.Drawing.Size(62, 18);
            optPMHeureDiner1.TabIndex = 75;
            optPMHeureDiner1.TabStop = true;
            optPMHeureDiner1.Text = "1 heure";
            optPMHeureDiner1.UseVisualStyleBackColor = true;
            optPMHeureDiner1.CheckedChanged += new System.EventHandler(optPMTypePunch1_CheckedChanged);
            // 
            // optPMHeureDiner0
            // 
            optPMHeureDiner0.AutoSize = true;
            optPMHeureDiner0.BackColor = System.Drawing.Color.Black;
            optPMHeureDiner0.Checked = true;
            optPMHeureDiner0.Enabled = false;
            optPMHeureDiner0.ForeColor = System.Drawing.Color.White;
            optPMHeureDiner0.Location = new System.Drawing.Point(409, 228);
            optPMHeureDiner0.Name = "optPMHeureDiner0";
            optPMHeureDiner0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optPMHeureDiner0.Size = new System.Drawing.Size(80, 18);
            optPMHeureDiner0.TabIndex = 74;
            optPMHeureDiner0.TabStop = true;
            optPMHeureDiner0.Text = "30 minutes";
            optPMHeureDiner0.UseVisualStyleBackColor = true;
            optPMHeureDiner0.CheckedChanged += new System.EventHandler(optPMTypePunch0_CheckedChanged);
            // 
            // cmdPMOK
            // 
            cmdPMOK.AutoSize = true;
            cmdPMOK.BackColor = System.Drawing.Color.Black;
            cmdPMOK.ForeColor = System.Drawing.Color.White;
            cmdPMOK.Location = new System.Drawing.Point(606, 281);
            cmdPMOK.Name = "cmdPMOK";
            cmdPMOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdPMOK.Size = new System.Drawing.Size(73, 28);
            cmdPMOK.TabIndex = 61;
            cmdPMOK.Text = "OK";
            cmdPMOK.UseVisualStyleBackColor = true;
            cmdPMOK.Click += new System.EventHandler(cmdPMOK_Click);
            // 
            // Frame2
            // 
            Frame2.BackColor = System.Drawing.Color.Black;
            Frame2.Controls.Add(mskPMHeureFin);
            Frame2.Controls.Add(mskPMHeureDebut);
            Frame2.Controls.Add(Label10);
            Frame2.Controls.Add(Label8);
            Frame2.ForeColor = System.Drawing.Color.White;
            Frame2.Location = new System.Drawing.Point(557, 204);
            Frame2.Name = "Frame2";
            Frame2.Padding = new System.Windows.Forms.Padding(0);
            Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Frame2.Size = new System.Drawing.Size(137, 65);
            Frame2.TabIndex = 59;
            Frame2.TabStop = false;
            Frame2.Text = "Heure";
            // 
            // cmdPunchOut
            // 
            cmdPunchOut.BackColor = System.Drawing.Color.Black;
            cmdPunchOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            cmdPunchOut.Location = new System.Drawing.Point(744, 361);
            cmdPunchOut.Name = "cmdPunchOut";
            cmdPunchOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdPunchOut.Size = new System.Drawing.Size(83, 25);
            cmdPunchOut.TabIndex = 5;
            cmdPunchOut.Text = "Punch out";
            cmdPunchOut.UseVisualStyleBackColor = true;
            cmdPunchOut.Click += new System.EventHandler(cmdPunchOut_Click);
            cmdPunchOut.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdPunchOut_MouseUp);
            // 
            // cmdModifierPunchOut
            // 
            cmdModifierPunchOut.AutoSize = true;
            cmdModifierPunchOut.BackColor = System.Drawing.Color.Black;
            cmdModifierPunchOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            cmdModifierPunchOut.Location = new System.Drawing.Point(443, 361);
            cmdModifierPunchOut.Name = "cmdModifierPunchOut";
            cmdModifierPunchOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdModifierPunchOut.Size = new System.Drawing.Size(137, 28);
            cmdModifierPunchOut.TabIndex = 3;
            cmdModifierPunchOut.Text = "Modifier punch out";
            cmdModifierPunchOut.UseVisualStyleBackColor = true;
            cmdModifierPunchOut.Click += new System.EventHandler(cmdModifierPunchOut_Click);
            cmdModifierPunchOut.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdModifierPunchOut_MouseUp);
            // 
            // cmdPunchIn
            // 
            cmdPunchIn.BackColor = System.Drawing.Color.Black;
            cmdPunchIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            cmdPunchIn.Location = new System.Drawing.Point(662, 361);
            cmdPunchIn.Name = "cmdPunchIn";
            cmdPunchIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdPunchIn.Size = new System.Drawing.Size(80, 25);
            cmdPunchIn.TabIndex = 4;
            cmdPunchIn.Text = "Punch in";
            cmdPunchIn.UseVisualStyleBackColor = true;
            cmdPunchIn.Click += new System.EventHandler(cmdPunchIn_Click);
            // 
            // cmdModifierPunchIn
            // 
            cmdModifierPunchIn.AutoSize = true;
            cmdModifierPunchIn.BackColor = System.Drawing.Color.Black;
            cmdModifierPunchIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            cmdModifierPunchIn.Location = new System.Drawing.Point(311, 361);
            cmdModifierPunchIn.Name = "cmdModifierPunchIn";
            cmdModifierPunchIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdModifierPunchIn.Size = new System.Drawing.Size(128, 28);
            cmdModifierPunchIn.TabIndex = 2;
            cmdModifierPunchIn.Text = "Modifier punch in";
            cmdModifierPunchIn.UseVisualStyleBackColor = true;
            cmdModifierPunchIn.MouseUp += new System.Windows.Forms.MouseEventHandler(cmdModifierPunchIn_MouseUp);
            // 
            // txtPMCommentaire
            // 
            txtPMCommentaire.AcceptsReturn = true;
            txtPMCommentaire.BackColor = System.Drawing.Color.Black;
            txtPMCommentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPMCommentaire.ForeColor = System.Drawing.Color.White;
            txtPMCommentaire.Location = new System.Drawing.Point(33, 236);
            txtPMCommentaire.MaxLength = 0;
            txtPMCommentaire.Multiline = true;
            txtPMCommentaire.Name = "txtPMCommentaire";
            txtPMCommentaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPMCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtPMCommentaire.Size = new System.Drawing.Size(337, 57);
            txtPMCommentaire.TabIndex = 58;
            // 
            // lvwJourColumnHeader8
            // 
            lvwJourColumnHeader8.Text = "KM";
            lvwJourColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            lvwJourColumnHeader8.Width = 70;
            // 
            // lvwJourColumnHeader6
            // 
            lvwJourColumnHeader6.Text = "Type";
            lvwJourColumnHeader6.Width = 180;
            // 
            // lvwJourColumnHeader5
            // 
            lvwJourColumnHeader5.Text = "Client";
            lvwJourColumnHeader5.Width = 209;
            // 
            // lvwJourColumnHeader4
            // 
            lvwJourColumnHeader4.Text = "Fin";
            lvwJourColumnHeader4.Width = 42;
            // 
            // lvwJourColumnHeader3
            // 
            lvwJourColumnHeader3.Text = "Début";
            lvwJourColumnHeader3.Width = 71;
            // 
            // lvwJourColumnHeader2
            // 
            lvwJourColumnHeader2.Text = "Projet";
            // 
            // lvwJourColumnHeader1
            // 
            lvwJourColumnHeader1.Text = "Nom";
            lvwJourColumnHeader1.Width = 62;
            // 
            // fraJour
            // 
            fraJour.BackColor = System.Drawing.Color.Black;
            fraJour.Controls.Add(lvwJour);
            fraJour.Controls.Add(cmdPunchOut);
            fraJour.Controls.Add(cmdModifierPunchOut);
            fraJour.Controls.Add(cmdPunchIn);
            fraJour.Controls.Add(fraPunchMultiple);
            fraJour.Controls.Add(cmdModifierPunchIn);
            fraJour.Controls.Add(Frame2);
            fraJour.ForeColor = System.Drawing.Color.White;
            fraJour.Location = new System.Drawing.Point(1, 71);
            fraJour.Name = "fraJour";
            fraJour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraJour.Size = new System.Drawing.Size(868, 394);
            fraJour.TabIndex = 55;
            fraJour.Paint += new System.Windows.Forms.PaintEventHandler(fraJour_Paint);
            // 
            // lvwJour
            // 
            lvwJour.BackColor = System.Drawing.Color.Black;
            lvwJour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwJourColumnHeader1,
            lvwJourColumnHeader2,
            lvwJourColumnHeader3,
            lvwJourColumnHeader4,
            lvwJourColumnHeader5,
            lvwJourColumnHeader6,
            lvwJourColumnHeader7,
            lvwJourColumnHeader8,
            columnHeader6});
            lvwJour.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwJour.ForeColor = System.Drawing.Color.White;
            lvwJour.FullRowSelect = true;
            lvwJour.GridLines = true;
            lvwJour.HideSelection = false;
            lvwJour.Location = new System.Drawing.Point(0, 3);
            lvwJour.Name = "lvwJour";
            lvwJour.Size = new System.Drawing.Size(868, 336);
            lvwJour.TabIndex = 1;
            lvwJour.UseCompatibleStateImageBehavior = false;
            lvwJour.View = System.Windows.Forms.View.Details;
            // 
            // lvwJourColumnHeader7
            // 
            lvwJourColumnHeader7.Text = "Commentaire";
            lvwJourColumnHeader7.Width = 184;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ID";
            columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            columnHeader6.Width = 90;
            // 
            // fraPunchMultiple
            // 
            fraPunchMultiple.BackColor = System.Drawing.Color.Black;
            fraPunchMultiple.Controls.Add(cmbPMType);
            fraPunchMultiple.Controls.Add(picPMTypePunch);
            fraPunchMultiple.Controls.Add(optPMHeureDiner1);
            fraPunchMultiple.Controls.Add(optPMHeureDiner0);
            fraPunchMultiple.Controls.Add(cmdPMOK);
            fraPunchMultiple.Controls.Add(txtPMCommentaire);
            fraPunchMultiple.Controls.Add(cmdPMAnnuler);
            fraPunchMultiple.Controls.Add(txtPMClient);
            fraPunchMultiple.Controls.Add(chkPMDiner);
            fraPunchMultiple.Controls.Add(mskPMNoProjet);
            fraPunchMultiple.Controls.Add(lblPMTypePunch);
            fraPunchMultiple.Controls.Add(lblPMType);
            fraPunchMultiple.Controls.Add(Label9);
            fraPunchMultiple.Controls.Add(lblPMPrefixe);
            fraPunchMultiple.Controls.Add(Label7);
            fraPunchMultiple.Controls.Add(Label6);
            fraPunchMultiple.Location = new System.Drawing.Point(874, 380);
            fraPunchMultiple.Name = "fraPunchMultiple";
            fraPunchMultiple.Padding = new System.Windows.Forms.Padding(0);
            fraPunchMultiple.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraPunchMultiple.Size = new System.Drawing.Size(371, 143);
            fraPunchMultiple.TabIndex = 61;
            fraPunchMultiple.TabStop = false;
            fraPunchMultiple.Visible = false;
            // 
            // cmdPMAnnuler
            // 
            cmdPMAnnuler.BackColor = System.Drawing.Color.Black;
            cmdPMAnnuler.ForeColor = System.Drawing.Color.White;
            cmdPMAnnuler.Location = new System.Drawing.Point(685, 281);
            cmdPMAnnuler.Name = "cmdPMAnnuler";
            cmdPMAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdPMAnnuler.Size = new System.Drawing.Size(73, 25);
            cmdPMAnnuler.TabIndex = 57;
            cmdPMAnnuler.Text = "Annuler";
            cmdPMAnnuler.UseVisualStyleBackColor = true;
            cmdPMAnnuler.Click += new System.EventHandler(cmdPMAnnuler_Click);
            // 
            // txtPMClient
            // 
            txtPMClient.AcceptsReturn = true;
            txtPMClient.BackColor = System.Drawing.Color.Black;
            txtPMClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPMClient.ForeColor = System.Drawing.Color.White;
            txtPMClient.Location = new System.Drawing.Point(333, 80);
            txtPMClient.MaxLength = 0;
            txtPMClient.Name = "txtPMClient";
            txtPMClient.ReadOnly = true;
            txtPMClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPMClient.Size = new System.Drawing.Size(361, 22);
            txtPMClient.TabIndex = 56;
            // 
            // chkPMDiner
            // 
            chkPMDiner.AutoSize = true;
            chkPMDiner.BackColor = System.Drawing.Color.Black;
            chkPMDiner.ForeColor = System.Drawing.Color.White;
            chkPMDiner.Location = new System.Drawing.Point(377, 204);
            chkPMDiner.Name = "chkPMDiner";
            chkPMDiner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkPMDiner.Size = new System.Drawing.Size(99, 18);
            chkPMDiner.TabIndex = 55;
            chkPMDiner.Text = "Heure de dîner";
            chkPMDiner.UseVisualStyleBackColor = true;
            chkPMDiner.CheckedChanged += new System.EventHandler(chkPMDiner_CheckStateChanged);
            // 
            // mskPMNoProjet
            // 
            mskPMNoProjet.BackColor = System.Drawing.Color.Black;
            mskPMNoProjet.ForeColor = System.Drawing.Color.White;
            mskPMNoProjet.Location = new System.Drawing.Point(121, 68);
            mskPMNoProjet.Mask = "#####-##";
            mskPMNoProjet.Name = "mskPMNoProjet";
            mskPMNoProjet.Size = new System.Drawing.Size(65, 22);
            mskPMNoProjet.TabIndex = 69;
            // 
            // lblPMTypePunch
            // 
            lblPMTypePunch.BackColor = System.Drawing.Color.Black;
            lblPMTypePunch.ForeColor = System.Drawing.Color.White;
            lblPMTypePunch.Location = new System.Drawing.Point(313, 60);
            lblPMTypePunch.Name = "lblPMTypePunch";
            lblPMTypePunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPMTypePunch.Size = new System.Drawing.Size(257, 17);
            lblPMTypePunch.TabIndex = 88;
            // 
            // lblPMType
            // 
            lblPMType.AutoSize = true;
            lblPMType.BackColor = System.Drawing.Color.Black;
            lblPMType.ForeColor = System.Drawing.Color.White;
            lblPMType.Location = new System.Drawing.Point(209, 148);
            lblPMType.Name = "lblPMType";
            lblPMType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPMType.Size = new System.Drawing.Size(31, 14);
            lblPMType.TabIndex = 84;
            lblPMType.Text = "Type";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = System.Drawing.Color.Black;
            Label9.ForeColor = System.Drawing.Color.White;
            Label9.Location = new System.Drawing.Point(209, 108);
            Label9.Name = "Label9";
            Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label9.Size = new System.Drawing.Size(35, 14);
            Label9.TabIndex = 64;
            Label9.Text = "Client";
            // 
            // lblPMPrefixe
            // 
            lblPMPrefixe.BackColor = System.Drawing.Color.Black;
            lblPMPrefixe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPMPrefixe.ForeColor = System.Drawing.Color.White;
            lblPMPrefixe.Location = new System.Drawing.Point(97, 68);
            lblPMPrefixe.Name = "lblPMPrefixe";
            lblPMPrefixe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPMPrefixe.Size = new System.Drawing.Size(24, 21);
            lblPMPrefixe.TabIndex = 82;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = System.Drawing.Color.Black;
            Label7.ForeColor = System.Drawing.Color.White;
            Label7.Location = new System.Drawing.Point(41, 72);
            Label7.Name = "Label7";
            Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label7.Size = new System.Drawing.Size(56, 14);
            Label7.TabIndex = 63;
            Label7.Text = "No. Projet";
            // 
            // Label6
            // 
            Label6.BackColor = System.Drawing.Color.Black;
            Label6.ForeColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(33, 220);
            Label6.Name = "Label6";
            Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label6.Size = new System.Drawing.Size(73, 17);
            Label6.TabIndex = 62;
            Label6.Text = "Commentaires";
            // 
            // lvwEmployes
            // 
            lvwEmployes.BackColor = System.Drawing.Color.Black;
            lvwEmployes.CheckBoxes = true;
            lvwEmployes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwEmployesColumnHeader1});
            lvwEmployes.ForeColor = System.Drawing.Color.White;
            lvwEmployes.FullRowSelect = true;
            lvwEmployes.GridLines = true;
            lvwEmployes.HideSelection = false;
            lvwEmployes.Location = new System.Drawing.Point(20, 111);
            lvwEmployes.Name = "lvwEmployes";
            lvwEmployes.Size = new System.Drawing.Size(561, 105);
            lvwEmployes.TabIndex = 65;
            lvwEmployes.UseCompatibleStateImageBehavior = false;
            lvwEmployes.View = System.Windows.Forms.View.Details;
            // 
            // lvwEmployesColumnHeader1
            // 
            lvwEmployesColumnHeader1.Text = "Employé";
            lvwEmployesColumnHeader1.Width = 741;
            // 
            // cmbHeureSemaine
            // 
            cmbHeureSemaine.BackColor = System.Drawing.Color.Black;
            cmbHeureSemaine.ForeColor = System.Drawing.Color.White;
            cmbHeureSemaine.Location = new System.Drawing.Point(622, 12);
            cmbHeureSemaine.Name = "cmbHeureSemaine";
            cmbHeureSemaine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbHeureSemaine.Size = new System.Drawing.Size(169, 22);
            cmbHeureSemaine.TabIndex = 59;
            // 
            // lblNbreHeure
            // 
            lblNbreHeure.AutoSize = true;
            lblNbreHeure.BackColor = System.Drawing.Color.Black;
            lblNbreHeure.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNbreHeure.ForeColor = System.Drawing.Color.Gainsboro;
            lblNbreHeure.Location = new System.Drawing.Point(793, 9);
            lblNbreHeure.Name = "lblNbreHeure";
            lblNbreHeure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNbreHeure.Size = new System.Drawing.Size(45, 26);
            lblNbreHeure.TabIndex = 60;
            lblNbreHeure.Text = "888";
            // 
            // lblTitreHeure
            // 
            lblTitreHeure.BackColor = System.Drawing.Color.Black;
            lblTitreHeure.ForeColor = System.Drawing.Color.White;
            lblTitreHeure.Location = new System.Drawing.Point(446, 15);
            lblTitreHeure.Name = "lblTitreHeure";
            lblTitreHeure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTitreHeure.Size = new System.Drawing.Size(193, 17);
            lblTitreHeure.TabIndex = 58;
            lblTitreHeure.Text = "Nombre d\'heures dans la semaine pour :";
            // 
            // fraSemaine
            // 
            fraSemaine.AutoSize = true;
            fraSemaine.BackColor = System.Drawing.Color.Black;
            fraSemaine.Controls.Add(lvwJourSemaine1);
            fraSemaine.Controls.Add(lvwJourSemaine2);
            fraSemaine.Controls.Add(lvwJourSemaine3);
            fraSemaine.Controls.Add(lvwJourSemaine4);
            fraSemaine.Controls.Add(lvwJourSemaine5);
            fraSemaine.Controls.Add(lvwJourSemaine6);
            fraSemaine.Controls.Add(lvwJourSemaine7);
            fraSemaine.Controls.Add(lblNomJour0);
            fraSemaine.Controls.Add(lblNomJour1);
            fraSemaine.Controls.Add(lblNomJour2);
            fraSemaine.Controls.Add(lblNomJour3);
            fraSemaine.Controls.Add(lblNomJour4);
            fraSemaine.Controls.Add(lblNomJour5);
            fraSemaine.Controls.Add(lblNomJour6);
            fraSemaine.Controls.Add(lblJour0);
            fraSemaine.Controls.Add(lblJour1);
            fraSemaine.Controls.Add(lblJour2);
            fraSemaine.Controls.Add(lblJour3);
            fraSemaine.Controls.Add(lblJour4);
            fraSemaine.Controls.Add(lblJour5);
            fraSemaine.Controls.Add(lblJour6);
            fraSemaine.ForeColor = System.Drawing.Color.White;
            fraSemaine.Location = new System.Drawing.Point(1, 469);
            fraSemaine.Name = "fraSemaine";
            fraSemaine.Padding = new System.Windows.Forms.Padding(0);
            fraSemaine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraSemaine.Size = new System.Drawing.Size(868, 304);
            fraSemaine.TabIndex = 57;
            fraSemaine.TabStop = false;
            // 
            // lvwJourSemaine6
            // 
            lvwJourSemaine6.BackColor = System.Drawing.Color.Black;
            lvwJourSemaine6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwJourSemaine6ColumnHeader1,
            lvwJourSemaine6ColumnHeader2,
            columnHeader4});
            lvwJourSemaine6.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwJourSemaine6.ForeColor = System.Drawing.Color.White;
            lvwJourSemaine6.FullRowSelect = true;
            lvwJourSemaine6.GridLines = true;
            lvwJourSemaine6.HideSelection = false;
            lvwJourSemaine6.Location = new System.Drawing.Point(618, 48);
            lvwJourSemaine6.Name = "lvwJourSemaine6";
            lvwJourSemaine6.Size = new System.Drawing.Size(124, 234);
            lvwJourSemaine6.TabIndex = 48;
            lvwJourSemaine6.UseCompatibleStateImageBehavior = false;
            lvwJourSemaine6.View = System.Windows.Forms.View.Details;
            lvwJourSemaine6.Click += new System.EventHandler(lvwJourSemaine6_Click);
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "#";
            // 
            // lvwJourSemaine7
            // 
            lvwJourSemaine7.BackColor = System.Drawing.Color.Black;
            lvwJourSemaine7.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwJourSemaine7ColumnHeader1,
            lvwJourSemaine7ColumnHeader2,
            columnHeader5});
            lvwJourSemaine7.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvwJourSemaine7.ForeColor = System.Drawing.Color.White;
            lvwJourSemaine7.FullRowSelect = true;
            lvwJourSemaine7.GridLines = true;
            lvwJourSemaine7.HideSelection = false;
            lvwJourSemaine7.Location = new System.Drawing.Point(741, 48);
            lvwJourSemaine7.Name = "lvwJourSemaine7";
            lvwJourSemaine7.Size = new System.Drawing.Size(124, 234);
            lvwJourSemaine7.TabIndex = 49;
            lvwJourSemaine7.UseCompatibleStateImageBehavior = false;
            lvwJourSemaine7.View = System.Windows.Forms.View.Details;
            lvwJourSemaine7.Click += new System.EventHandler(lvwJourSemaine7_Click);
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "#";
            // 
            // lblNomJour0
            // 
            lblNomJour0.AutoSize = true;
            lblNomJour0.BackColor = System.Drawing.Color.Black;
            lblNomJour0.ForeColor = System.Drawing.Color.White;
            lblNomJour0.Location = new System.Drawing.Point(7, 24);
            lblNomJour0.Name = "lblNomJour0";
            lblNomJour0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNomJour0.Size = new System.Drawing.Size(28, 14);
            lblNomJour0.TabIndex = 30;
            lblNomJour0.Text = "Dim";
            // 
            // lblNomJour1
            // 
            lblNomJour1.AutoSize = true;
            lblNomJour1.BackColor = System.Drawing.Color.Black;
            lblNomJour1.ForeColor = System.Drawing.Color.White;
            lblNomJour1.Location = new System.Drawing.Point(130, 24);
            lblNomJour1.Name = "lblNomJour1";
            lblNomJour1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNomJour1.Size = new System.Drawing.Size(24, 14);
            lblNomJour1.TabIndex = 32;
            lblNomJour1.Text = "Lun";
            // 
            // lblNomJour2
            // 
            lblNomJour2.AutoSize = true;
            lblNomJour2.BackColor = System.Drawing.Color.Black;
            lblNomJour2.ForeColor = System.Drawing.Color.White;
            lblNomJour2.Location = new System.Drawing.Point(254, 24);
            lblNomJour2.Name = "lblNomJour2";
            lblNomJour2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNomJour2.Size = new System.Drawing.Size(27, 14);
            lblNomJour2.TabIndex = 34;
            lblNomJour2.Text = "Mar";
            // 
            // lblNomJour3
            // 
            lblNomJour3.AutoSize = true;
            lblNomJour3.BackColor = System.Drawing.Color.Black;
            lblNomJour3.ForeColor = System.Drawing.Color.White;
            lblNomJour3.Location = new System.Drawing.Point(377, 24);
            lblNomJour3.Name = "lblNomJour3";
            lblNomJour3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNomJour3.Size = new System.Drawing.Size(27, 14);
            lblNomJour3.TabIndex = 35;
            lblNomJour3.Text = "Mer";
            // 
            // lblNomJour4
            // 
            lblNomJour4.AutoSize = true;
            lblNomJour4.BackColor = System.Drawing.Color.Black;
            lblNomJour4.ForeColor = System.Drawing.Color.White;
            lblNomJour4.Location = new System.Drawing.Point(501, 24);
            lblNomJour4.Name = "lblNomJour4";
            lblNomJour4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNomJour4.Size = new System.Drawing.Size(23, 14);
            lblNomJour4.TabIndex = 38;
            lblNomJour4.Text = "Jeu";
            // 
            // lblNomJour5
            // 
            lblNomJour5.AutoSize = true;
            lblNomJour5.BackColor = System.Drawing.Color.Black;
            lblNomJour5.ForeColor = System.Drawing.Color.White;
            lblNomJour5.Location = new System.Drawing.Point(624, 24);
            lblNomJour5.Name = "lblNomJour5";
            lblNomJour5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNomJour5.Size = new System.Drawing.Size(25, 14);
            lblNomJour5.TabIndex = 39;
            lblNomJour5.Text = "Ven";
            // 
            // lblNomJour6
            // 
            lblNomJour6.AutoSize = true;
            lblNomJour6.BackColor = System.Drawing.Color.Black;
            lblNomJour6.ForeColor = System.Drawing.Color.White;
            lblNomJour6.Location = new System.Drawing.Point(748, 24);
            lblNomJour6.Name = "lblNomJour6";
            lblNomJour6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNomJour6.Size = new System.Drawing.Size(29, 14);
            lblNomJour6.TabIndex = 41;
            lblNomJour6.Text = "Sam";
            // 
            // lblJour0
            // 
            lblJour0.AutoSize = true;
            lblJour0.BackColor = System.Drawing.Color.Black;
            lblJour0.ForeColor = System.Drawing.Color.White;
            lblJour0.Location = new System.Drawing.Point(39, 24);
            lblJour0.Name = "lblJour0";
            lblJour0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblJour0.Size = new System.Drawing.Size(0, 14);
            lblJour0.TabIndex = 29;
            // 
            // lblJour1
            // 
            lblJour1.AutoSize = true;
            lblJour1.BackColor = System.Drawing.Color.Black;
            lblJour1.ForeColor = System.Drawing.Color.White;
            lblJour1.Location = new System.Drawing.Point(162, 24);
            lblJour1.Name = "lblJour1";
            lblJour1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblJour1.Size = new System.Drawing.Size(0, 14);
            lblJour1.TabIndex = 31;
            // 
            // lblJour2
            // 
            lblJour2.AutoSize = true;
            lblJour2.BackColor = System.Drawing.Color.Black;
            lblJour2.ForeColor = System.Drawing.Color.White;
            lblJour2.Location = new System.Drawing.Point(286, 24);
            lblJour2.Name = "lblJour2";
            lblJour2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblJour2.Size = new System.Drawing.Size(0, 14);
            lblJour2.TabIndex = 33;
            // 
            // lblJour3
            // 
            lblJour3.AutoSize = true;
            lblJour3.BackColor = System.Drawing.Color.Black;
            lblJour3.ForeColor = System.Drawing.Color.White;
            lblJour3.Location = new System.Drawing.Point(409, 24);
            lblJour3.Name = "lblJour3";
            lblJour3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblJour3.Size = new System.Drawing.Size(0, 14);
            lblJour3.TabIndex = 36;
            // 
            // lblJour4
            // 
            lblJour4.AutoSize = true;
            lblJour4.BackColor = System.Drawing.Color.Black;
            lblJour4.ForeColor = System.Drawing.Color.White;
            lblJour4.Location = new System.Drawing.Point(533, 24);
            lblJour4.Name = "lblJour4";
            lblJour4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblJour4.Size = new System.Drawing.Size(0, 14);
            lblJour4.TabIndex = 37;
            // 
            // lblJour5
            // 
            lblJour5.AutoSize = true;
            lblJour5.BackColor = System.Drawing.Color.Black;
            lblJour5.ForeColor = System.Drawing.Color.White;
            lblJour5.Location = new System.Drawing.Point(656, 24);
            lblJour5.Name = "lblJour5";
            lblJour5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblJour5.Size = new System.Drawing.Size(0, 14);
            lblJour5.TabIndex = 40;
            // 
            // lblJour6
            // 
            lblJour6.AutoSize = true;
            lblJour6.BackColor = System.Drawing.Color.Black;
            lblJour6.ForeColor = System.Drawing.Color.White;
            lblJour6.Location = new System.Drawing.Point(787, 24);
            lblJour6.Name = "lblJour6";
            lblJour6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblJour6.Size = new System.Drawing.Size(0, 14);
            lblJour6.TabIndex = 42;
            // 
            // mvwSelection
            // 
            mvwSelection.Location = new System.Drawing.Point(231, 11);
            mvwSelection.Name = "mvwSelection";
            mvwSelection.Size = new System.Drawing.Size(200, 22);
            mvwSelection.TabIndex = 62;
            mvwSelection.ValueChanged += new System.EventHandler(mvwSelection_ValueChanged);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1,
            toolStripStatusLabel2,
            toolStripStatusLabel3});
            statusStrip1.Location = new System.Drawing.Point(0, 763);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(878, 22);
            statusStrip1.TabIndex = 63;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            toolStripStatusLabel1.Text = "Projet";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.ForeColor = System.Drawing.Color.Lime;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(707, 17);
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.Text = "Client";
            toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            toolStripStatusLabel3.Click += new System.EventHandler(toolStripStatusLabel3_Click);
            // 
            // Label3
            // 
            Label3.BackColor = System.Drawing.Color.Black;
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(167, 108);
            Label3.Name = "Label3";
            Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label3.Size = new System.Drawing.Size(49, 17);
            Label3.TabIndex = 17;
            Label3.Text = "Client";
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.Black;
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(7, 24);
            Label1.Name = "Label1";
            Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label1.Size = new System.Drawing.Size(57, 17);
            Label1.TabIndex = 7;
            Label1.Text = "Employé";
            // 
            // lblprojet
            // 
            lblprojet.AutoSize = true;
            lblprojet.BackColor = System.Drawing.Color.Black;
            lblprojet.ForeColor = System.Drawing.Color.White;
            lblprojet.Location = new System.Drawing.Point(7, 68);
            lblprojet.Name = "lblprojet";
            lblprojet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblprojet.Size = new System.Drawing.Size(56, 14);
            lblprojet.TabIndex = 10;
            lblprojet.Text = "No. Projet";
            // 
            // Label2
            // 
            Label2.BackColor = System.Drawing.Color.Black;
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(7, 211);
            Label2.Name = "Label2";
            Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label2.Size = new System.Drawing.Size(73, 17);
            Label2.TabIndex = 22;
            Label2.Text = "Commentaires";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = System.Drawing.Color.Black;
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(471, 208);
            Label4.Name = "Label4";
            Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Label4.Size = new System.Drawing.Size(24, 14);
            Label4.TabIndex = 21;
            Label4.Text = "Km";
            // 
            // lblPrefixe
            // 
            lblPrefixe.BackColor = System.Drawing.Color.Black;
            lblPrefixe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPrefixe.ForeColor = System.Drawing.Color.White;
            lblPrefixe.Location = new System.Drawing.Point(63, 67);
            lblPrefixe.Name = "lblPrefixe";
            lblPrefixe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblPrefixe.Size = new System.Drawing.Size(17, 20);
            lblPrefixe.TabIndex = 83;
            lblPrefixe.TextChanged += new System.EventHandler(lblPrefixe_TextChanged);
            // 
            // lblType
            // 
            lblType.BackColor = System.Drawing.Color.Black;
            lblType.ForeColor = System.Drawing.Color.White;
            lblType.Location = new System.Drawing.Point(167, 152);
            lblType.Name = "lblType";
            lblType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblType.Size = new System.Drawing.Size(33, 17);
            lblType.TabIndex = 86;
            lblType.Text = "Type";
            // 
            // lblTypePunch
            // 
            lblTypePunch.BackColor = System.Drawing.Color.Black;
            lblTypePunch.ForeColor = System.Drawing.Color.White;
            lblTypePunch.Location = new System.Drawing.Point(279, 56);
            lblTypePunch.Name = "lblTypePunch";
            lblTypePunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblTypePunch.Size = new System.Drawing.Size(265, 17);
            lblTypePunch.TabIndex = 89;
            // 
            // txtNoProjet
            // 
            txtNoProjet.AcceptsReturn = true;
            txtNoProjet.BackColor = System.Drawing.Color.Black;
            txtNoProjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNoProjet.ForeColor = System.Drawing.Color.White;
            txtNoProjet.Location = new System.Drawing.Point(83, 67);
            txtNoProjet.MaxLength = 0;
            txtNoProjet.Name = "txtNoProjet";
            txtNoProjet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNoProjet.Size = new System.Drawing.Size(81, 22);
            txtNoProjet.TabIndex = 12;
            txtNoProjet.TextChanged += new System.EventHandler(txtNoProjet_TextChanged);
            // 
            // txtEmploye
            // 
            txtEmploye.AcceptsReturn = true;
            txtEmploye.BackColor = System.Drawing.Color.Black;
            txtEmploye.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtEmploye.Location = new System.Drawing.Point(71, 24);
            txtEmploye.MaxLength = 0;
            txtEmploye.Name = "txtEmploye";
            txtEmploye.ReadOnly = true;
            txtEmploye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtEmploye.Size = new System.Drawing.Size(233, 22);
            txtEmploye.TabIndex = 9;
            // 
            // cmdOK
            // 
            cmdOK.BackColor = System.Drawing.Color.Black;
            cmdOK.ForeColor = System.Drawing.Color.White;
            cmdOK.Location = new System.Drawing.Point(604, 313);
            cmdOK.Name = "cmdOK";
            cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdOK.Size = new System.Drawing.Size(73, 25);
            cmdOK.TabIndex = 26;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = true;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);
            // 
            // picTypePunch
            // 
            picTypePunch.AutoSize = true;
            picTypePunch.BackColor = System.Drawing.Color.Black;
            picTypePunch.Controls.Add(optTypePunch0);
            picTypePunch.Controls.Add(optTypePunch1);
            picTypePunch.ForeColor = System.Drawing.Color.White;
            picTypePunch.Location = new System.Drawing.Point(170, 51);
            picTypePunch.Name = "picTypePunch";
            picTypePunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            picTypePunch.Size = new System.Drawing.Size(209, 64);
            picTypePunch.TabIndex = 76;
            picTypePunch.TabStop = false;
            // 
            // optTypePunch0
            // 
            optTypePunch0.BackColor = System.Drawing.Color.Black;
            optTypePunch0.ForeColor = System.Drawing.Color.White;
            optTypePunch0.Location = new System.Drawing.Point(25, 16);
            optTypePunch0.Name = "optTypePunch0";
            optTypePunch0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optTypePunch0.Size = new System.Drawing.Size(73, 17);
            optTypePunch0.TabIndex = 81;
            optTypePunch0.TabStop = true;
            optTypePunch0.Text = "Électrique";
            optTypePunch0.UseVisualStyleBackColor = true;
            optTypePunch0.CheckedChanged += new System.EventHandler(optTypePunch0_CheckedChanged);
            // 
            // optTypePunch1
            // 
            optTypePunch1.AutoSize = true;
            optTypePunch1.BackColor = System.Drawing.Color.Black;
            optTypePunch1.ForeColor = System.Drawing.Color.White;
            optTypePunch1.Location = new System.Drawing.Point(104, 17);
            optTypePunch1.Name = "optTypePunch1";
            optTypePunch1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optTypePunch1.Size = new System.Drawing.Size(79, 18);
            optTypePunch1.TabIndex = 80;
            optTypePunch1.TabStop = true;
            optTypePunch1.Text = "Mécanique";
            optTypePunch1.UseVisualStyleBackColor = true;
            optTypePunch1.CheckedChanged += new System.EventHandler(optTypePunch1_CheckedChanged);
            // 
            // cmbEmploye
            // 
            cmbEmploye.BackColor = System.Drawing.Color.Black;
            cmbEmploye.ForeColor = System.Drawing.Color.White;
            cmbEmploye.Location = new System.Drawing.Point(71, 24);
            cmbEmploye.Name = "cmbEmploye";
            cmbEmploye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbEmploye.Size = new System.Drawing.Size(233, 22);
            cmbEmploye.TabIndex = 8;
            cmbEmploye.Text = "cmbemployé";
            // 
            // fraHeure
            // 
            fraHeure.BackColor = System.Drawing.Color.Black;
            fraHeure.Controls.Add(mskHeure);
            fraHeure.Controls.Add(optHeure1);
            fraHeure.Controls.Add(optHeure0);
            fraHeure.ForeColor = System.Drawing.Color.White;
            fraHeure.Location = new System.Drawing.Point(7, 112);
            fraHeure.Name = "fraHeure";
            fraHeure.Padding = new System.Windows.Forms.Padding(0);
            fraHeure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraHeure.Size = new System.Drawing.Size(137, 65);
            fraHeure.TabIndex = 13;
            fraHeure.TabStop = false;
            fraHeure.Text = "Heure";
            // 
            // mskHeure
            // 
            mskHeure.BackColor = System.Drawing.Color.Black;
            mskHeure.ForeColor = System.Drawing.Color.White;
            mskHeure.Location = new System.Drawing.Point(21, 39);
            mskHeure.Name = "mskHeure";
            mskHeure.Size = new System.Drawing.Size(52, 22);
            mskHeure.TabIndex = 15;
            // 
            // optHeure1
            // 
            optHeure1.BackColor = System.Drawing.Color.Black;
            optHeure1.Location = new System.Drawing.Point(7, 40);
            optHeure1.Name = "optHeure1";
            optHeure1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optHeure1.Size = new System.Drawing.Size(17, 17);
            optHeure1.TabIndex = 16;
            optHeure1.TabStop = true;
            optHeure1.Text = "Système";
            optHeure1.UseVisualStyleBackColor = true;
            // 
            // optHeure0
            // 
            optHeure0.AutoSize = true;
            optHeure0.BackColor = System.Drawing.Color.Black;
            optHeure0.ForeColor = System.Drawing.Color.White;
            optHeure0.Location = new System.Drawing.Point(7, 16);
            optHeure0.Name = "optHeure0";
            optHeure0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optHeure0.Size = new System.Drawing.Size(130, 18);
            optHeure0.TabIndex = 14;
            optHeure0.TabStop = true;
            optHeure0.Text = "Heure de l\'ordinateur";
            optHeure0.UseVisualStyleBackColor = true;
            optHeure0.CheckedChanged += new System.EventHandler(optHeure0_CheckedChanged);
            // 
            // txtCommentaires
            // 
            txtCommentaires.AcceptsReturn = true;
            txtCommentaires.BackColor = System.Drawing.Color.Black;
            txtCommentaires.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCommentaires.ForeColor = System.Drawing.Color.White;
            txtCommentaires.Location = new System.Drawing.Point(7, 232);
            txtCommentaires.MaxLength = 0;
            txtCommentaires.Multiline = true;
            txtCommentaires.Name = "txtCommentaires";
            txtCommentaires.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCommentaires.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtCommentaires.Size = new System.Drawing.Size(313, 79);
            txtCommentaires.TabIndex = 24;
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.BackColor = System.Drawing.Color.Black;
            cmdAnnuler.ForeColor = System.Drawing.Color.White;
            cmdAnnuler.Location = new System.Drawing.Point(679, 313);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmdAnnuler.Size = new System.Drawing.Size(73, 25);
            cmdAnnuler.TabIndex = 25;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.UseVisualStyleBackColor = true;
            cmdAnnuler.Click += new System.EventHandler(cmdAnnuler_Click);
            // 
            // txtClient
            // 
            txtClient.AcceptsReturn = true;
            txtClient.BackColor = System.Drawing.Color.Black;
            txtClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtClient.ForeColor = System.Drawing.Color.White;
            txtClient.Location = new System.Drawing.Point(167, 124);
            txtClient.MaxLength = 0;
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtClient.Size = new System.Drawing.Size(385, 22);
            txtClient.TabIndex = 18;
            // 
            // chkKM
            // 
            chkKM.BackColor = System.Drawing.Color.Black;
            chkKM.ForeColor = System.Drawing.Color.White;
            chkKM.Location = new System.Drawing.Point(335, 208);
            chkKM.Name = "chkKM";
            chkKM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkKM.Size = new System.Drawing.Size(81, 17);
            chkKM.TabIndex = 19;
            chkKM.Text = "Kilométrage :";
            chkKM.UseVisualStyleBackColor = true;
            chkKM.CheckStateChanged += new System.EventHandler(chkKM_CheckStateChanged);
            // 
            // txtKM
            // 
            txtKM.AcceptsReturn = true;
            txtKM.BackColor = System.Drawing.Color.Black;
            txtKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtKM.Enabled = false;
            txtKM.ForeColor = System.Drawing.Color.White;
            txtKM.Location = new System.Drawing.Point(423, 208);
            txtKM.MaxLength = 0;
            txtKM.Name = "txtKM";
            txtKM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtKM.Size = new System.Drawing.Size(41, 22);
            txtKM.TabIndex = 20;
            txtKM.Leave += new System.EventHandler(txtKM_Leave);
            // 
            // chkDiner
            // 
            chkDiner.AutoSize = true;
            chkDiner.BackColor = System.Drawing.Color.Black;
            chkDiner.Checked = true;
            chkDiner.CheckState = System.Windows.Forms.CheckState.Checked;
            chkDiner.ForeColor = System.Drawing.Color.White;
            chkDiner.Location = new System.Drawing.Point(335, 232);
            chkDiner.Name = "chkDiner";
            chkDiner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chkDiner.Size = new System.Drawing.Size(99, 18);
            chkDiner.TabIndex = 23;
            chkDiner.Text = "Heure de dîner";
            chkDiner.UseVisualStyleBackColor = true;
            chkDiner.CheckStateChanged += new System.EventHandler(chkDiner_CheckStateChanged);
            // 
            // optHeureDiner0
            // 
            optHeureDiner0.AutoSize = true;
            optHeureDiner0.BackColor = System.Drawing.Color.Black;
            optHeureDiner0.Checked = true;
            optHeureDiner0.Enabled = false;
            optHeureDiner0.ForeColor = System.Drawing.Color.White;
            optHeureDiner0.Location = new System.Drawing.Point(383, 256);
            optHeureDiner0.Name = "optHeureDiner0";
            optHeureDiner0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optHeureDiner0.Size = new System.Drawing.Size(80, 18);
            optHeureDiner0.TabIndex = 72;
            optHeureDiner0.TabStop = true;
            optHeureDiner0.Text = "30 minutes";
            optHeureDiner0.UseVisualStyleBackColor = true;
            optHeureDiner0.CheckedChanged += new System.EventHandler(optHeure_CheckedChanged);
            // 
            // optHeureDiner1
            // 
            optHeureDiner1.AutoSize = true;
            optHeureDiner1.BackColor = System.Drawing.Color.Black;
            optHeureDiner1.Enabled = false;
            optHeureDiner1.ForeColor = System.Drawing.Color.White;
            optHeureDiner1.Location = new System.Drawing.Point(383, 272);
            optHeureDiner1.Name = "optHeureDiner1";
            optHeureDiner1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            optHeureDiner1.Size = new System.Drawing.Size(62, 18);
            optHeureDiner1.TabIndex = 73;
            optHeureDiner1.TabStop = true;
            optHeureDiner1.Text = "1 heure";
            optHeureDiner1.UseVisualStyleBackColor = true;
            optHeureDiner1.CheckedChanged += new System.EventHandler(optTypePunch1_CheckedChanged);
            // 
            // cmbType
            // 
            cmbType.BackColor = System.Drawing.Color.Black;
            cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbType.ForeColor = System.Drawing.Color.White;
            cmbType.Location = new System.Drawing.Point(167, 172);
            cmbType.Name = "cmbType";
            cmbType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cmbType.Size = new System.Drawing.Size(385, 22);
            cmbType.TabIndex = 87;
            // 
            // fraPunch
            // 
            fraPunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            fraPunch.BackColor = System.Drawing.Color.Black;
            fraPunch.Controls.Add(cmbType);
            fraPunch.Controls.Add(optHeureDiner1);
            fraPunch.Controls.Add(optHeureDiner0);
            fraPunch.Controls.Add(chkDiner);
            fraPunch.Controls.Add(txtKM);
            fraPunch.Controls.Add(chkKM);
            fraPunch.Controls.Add(txtClient);
            fraPunch.Controls.Add(cmdAnnuler);
            fraPunch.Controls.Add(txtCommentaires);
            fraPunch.Controls.Add(fraHeure);
            fraPunch.Controls.Add(cmbEmploye);
            fraPunch.Controls.Add(picTypePunch);
            fraPunch.Controls.Add(cmdOK);
            fraPunch.Controls.Add(txtEmploye);
            fraPunch.Controls.Add(txtNoProjet);
            fraPunch.Controls.Add(lblTypePunch);
            fraPunch.Controls.Add(lblType);
            fraPunch.Controls.Add(lblPrefixe);
            fraPunch.Controls.Add(Label4);
            fraPunch.Controls.Add(Label2);
            fraPunch.Controls.Add(lblprojet);
            fraPunch.Controls.Add(Label1);
            fraPunch.Controls.Add(Label3);
            fraPunch.ForeColor = System.Drawing.Color.LimeGreen;
            fraPunch.Location = new System.Drawing.Point(1185, 111);
            fraPunch.Name = "fraPunch";
            fraPunch.Padding = new System.Windows.Forms.Padding(0);
            fraPunch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fraPunch.Size = new System.Drawing.Size(152, 274);
            fraPunch.TabIndex = 56;
            fraPunch.TabStop = false;
            fraPunch.Text = "teste couleur";
            fraPunch.Visible = false;
            // 
            // Punch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = global::ControleurServeur.Properties.Resources.drapeauGRB;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(878, 785);
            Controls.Add(statusStrip1);
            Controls.Add(mvwSelection);
            Controls.Add(fraPunch);
            Controls.Add(fraJour);
            Controls.Add(lvwEmployes);
            Controls.Add(cmbHeureSemaine);
            Controls.Add(lblNbreHeure);
            Controls.Add(lblTitreHeure);
            Controls.Add(fraSemaine);
            Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = global::ControleurServeur.Properties.Resources.IconeApp;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Punch";
            ShowInTaskbar = false;
            Text = "Punch";
            Load += new System.EventHandler(Punch_Load);
            picPMTypePunch.ResumeLayout(false);
            picPMTypePunch.PerformLayout();
            Frame2.ResumeLayout(false);
            Frame2.PerformLayout();
            fraJour.ResumeLayout(false);
            fraJour.PerformLayout();
            fraPunchMultiple.ResumeLayout(false);
            fraPunchMultiple.PerformLayout();
            fraSemaine.ResumeLayout(false);
            fraSemaine.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            picTypePunch.ResumeLayout(false);
            picTypePunch.PerformLayout();
            fraHeure.ResumeLayout(false);
            fraHeure.PerformLayout();
            fraPunch.ResumeLayout(false);
            fraPunch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        internal static ListView lvwJourSemaine2;
        internal static ColumnHeader lvwJourSemaine2ColumnHeader1;
        internal static ColumnHeader lvwJourSemaine2ColumnHeader2;
        internal static GroupBox picPMTypePunch;
        internal static ColumnHeader lvwJourSemaine7ColumnHeader2;
        internal static ColumnHeader lvwJourSemaine7ColumnHeader1;
        internal static ColumnHeader lvwJourSemaine6ColumnHeader2;
        internal static ColumnHeader lvwJourSemaine6ColumnHeader1;
        internal static ColumnHeader lvwJourSemaine5ColumnHeader2;
        internal static ColumnHeader lvwJourSemaine5ColumnHeader1;
        internal static ColumnHeader lvwJourSemaine4ColumnHeader2;
        internal static ColumnHeader lvwJourSemaine4ColumnHeader1;
        internal static ListView lvwJourSemaine4;
        internal static ColumnHeader lvwJourSemaine3ColumnHeader2;
        internal static ListView lvwJourSemaine1;
        internal static ColumnHeader lvwJourSemaine1ColumnHeader1;
        internal static ColumnHeader lvwJourSemaine1ColumnHeader2;
        internal static ColumnHeader lvwJourSemaine3ColumnHeader1;
        internal static ListView lvwJourSemaine3;
        internal static ListView lvwJourSemaine5;
        internal static MaskedTextBox mskPMHeureFin;
        internal static MaskedTextBox mskPMHeureDebut;
        internal static Label Label10;
        internal static Label Label8;
        internal static ComboBox cmbPMType;
        internal static System.Windows.Forms.RadioButton optPMHeureDiner1;
        internal static System.Windows.Forms.RadioButton optPMHeureDiner0;
        internal static System.Windows.Forms.Button cmdPMOK;
        internal static GroupBox Frame2;
        internal static System.Windows.Forms.Button cmdPunchOut;
        internal static System.Windows.Forms.Button cmdModifierPunchOut;
        internal static System.Windows.Forms.Button cmdPunchIn;
        internal static System.Windows.Forms.Button cmdModifierPunchIn;
        internal static System.Windows.Forms.TextBox txtPMCommentaire;
        internal static ColumnHeader lvwJourColumnHeader8;
        internal static ColumnHeader lvwJourColumnHeader6;
        internal static ColumnHeader lvwJourColumnHeader5;
        internal static ColumnHeader lvwJourColumnHeader4;
        internal static ColumnHeader lvwJourColumnHeader3;
        internal static ColumnHeader lvwJourColumnHeader2;
        internal static ColumnHeader lvwJourColumnHeader1;
        internal static System.Windows.Forms.Panel fraJour;
        internal static ListView lvwJour;
        internal static ColumnHeader lvwJourColumnHeader7;
        internal static ToolTip ToolTip1;
        internal static GroupBox fraPunchMultiple;
        internal static System.Windows.Forms.Button cmdPMAnnuler;
        internal static System.Windows.Forms.TextBox txtPMClient;
        internal static System.Windows.Forms.CheckBox chkPMDiner;
        internal static ListView lvwEmployes;
        internal static ColumnHeader lvwEmployesColumnHeader1;
        internal static MaskedTextBox mskPMNoProjet;
        internal static System.Windows.Forms.RadioButton optPMTypePunch1;
        internal static System.Windows.Forms.RadioButton optPMTypePunch0;
        internal static Label lblPMTypePunch;
        internal static Label lblPMType;
        internal static Label Label9;
        internal static Label lblPMPrefixe;
        internal static Label Label7;
        internal static Label Label6;
        internal static ComboBox cmbHeureSemaine;
        internal static Label lblNbreHeure;
        internal static Label lblTitreHeure;
        internal static GroupBox fraSemaine;
        internal static ListView lvwJourSemaine6;
        internal static ListView lvwJourSemaine7;
        internal static Label lblNomJour0;
        internal static Label lblNomJour1;
        internal static Label lblNomJour2;
        internal static Label lblNomJour3;
        internal static Label lblNomJour4;
        internal static Label lblNomJour5;
        internal static Label lblNomJour6;
        internal static Label lblJour0;
        internal static Label lblJour1;
        internal static Label lblJour2;
        internal static Label lblJour3;
        internal static Label lblJour4;
        internal static Label lblJour5;
        internal static Label lblJour6;
        internal static DateTimePicker mvwSelection;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel toolStripStatusLabel1;
        internal static ToolStripStatusLabel toolStripStatusLabel2;
        internal static ToolStripStatusLabel toolStripStatusLabel3;
        ListView lvwJourSemaine = new ListView();
        int decalage = 0;

        private const int I_OPT_SYSTEME = 0;
        private const int I_OPT_MANUELLEMENT = 1;

        private const int I_OPT_ELECTRIQUE = 0;
        private const int I_OPT_MECANIQUE = 1;

        private const int I_TYPE_ELEC_INSTALLATION = 0;
        private const int I_TYPE_ELEC_MISE_SERVICE = 1;

        private const int I_TYPE_ELEC_DESSIN = 0;
        private const int I_TYPE_ELEC_FABRICATION = 1;
        private const int I_TYPE_ELEC_ASSEMBLAGE = 2;
        private const int I_TYPE_ELEC_PROG_INTERFACE = 3;
        private const int I_TYPE_ELEC_PROG_AUTOMATE = 4;
        private const int I_TYPE_ELEC_PROG_ROBOT = 5;
        private const int I_TYPE_ELEC_VISION = 6;
        private const int I_TYPE_ELEC_TEST = 7;
        private const int I_TYPE_ELEC_FORMATION = 8;
        private const int I_TYPE_ELEC_GESTION = 9;
        private const int I_TYPE_ELEC_SHIPPING = 10;
        private const int I_TYPE_ELEC_prototypage = 11;
        private const int I_TYPE_MEC_INSTALLATION = 0;
        private const int I_TYPE_MEC_DESSIN = 0;
        private const int I_TYPE_MEC_COUPE = 1;
        private const int I_TYPE_MEC_MACHINAGE = 2;
        private const int I_TYPE_MEC_SOUDURE = 3;
        private const int I_TYPE_MEC_ASSEMBLAGE = 4;
        private const int I_TYPE_MEC_PEINTURE = 5;
        private const int I_TYPE_MEC_TEST = 6;
        private const int I_TYPE_MEC_FORMATION = 7;
        private const int I_TYPE_MEC_GESTION = 8;
        private const int I_TYPE_MEC_SHIPPING = 9;
        private const int I_TYPE_MEC_prototypage = 10;
        private const int I_OPT_30_MINUTES = 0;
        private const int I_OPT_1_HEURE = 1;
        private const int I_LVW_NOM = 0;
        private const int I_LVW_PROJET = 1;
        private const int I_LVW_DEBUT = 2;
        private const int I_LVW_FIN = 3;
        private const int I_LVW_CLIENT = 4;
        private const int I_LVW_TYPE = 5;
        private const int I_LVW_COMMENTAIRE = 6;
        private const int I_LVW_KM = 7;
        private const int I_LVW_INITIALE = 0;
        private const int I_LVW_TEMPS = 1;
        internal   enum enumPunch
        {
            I_PUNCH_IN = 0,
            I_PUNCH_OUT = 1,
            I_MODIF_PUNCH_IN = 2,
            I_MODIF_PUNCH_OUT = 3
        }
        internal static enumPunch m_ePunch;
        internal static int idPunch;
        internal static int idClient;
        private DateTime m_datDateChoisie;
        internal static bool m_bModifPunch;
        private bool m_bMonthViewHasFocus;
        private int idEmployePunch = 0;
        public static  string sCommentaire;
        internal static string idProjet = "";
        private ColumnHeader NoPunch;
        private DayOfWeek iJourSemaine;
        Label lblJour = new Label();
        private ColumnHeader columnHeader2;
        private ColumnHeader NoPunch0;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        internal Label Label3;
        internal Label Label1;
        internal Label lblprojet;
        internal Label Label2;
        internal Label Label4;
        internal Label lblPrefixe;
        internal Label lblType;
        internal Label lblTypePunch;
        internal System.Windows.Forms.TextBox txtNoProjet;
        internal System.Windows.Forms.TextBox txtEmploye;
        internal System.Windows.Forms.Button cmdOK;
        internal GroupBox picTypePunch;
        internal System.Windows.Forms.RadioButton optTypePunch0;
        internal System.Windows.Forms.RadioButton optTypePunch1;
        internal ComboBox cmbEmploye;
        internal GroupBox fraHeure;
        internal MaskedTextBox mskHeure;
        internal System.Windows.Forms.RadioButton optHeure1;
        internal System.Windows.Forms.RadioButton optHeure0;
        internal System.Windows.Forms.TextBox txtCommentaires;
        internal System.Windows.Forms.Button cmdAnnuler;
        internal System.Windows.Forms.TextBox txtClient;
        internal System.Windows.Forms.CheckBox chkKM;
        internal System.Windows.Forms.TextBox txtKM;
        internal System.Windows.Forms.CheckBox chkDiner;
        internal System.Windows.Forms.RadioButton optHeureDiner0;
        internal System.Windows.Forms.RadioButton optHeureDiner1;
        internal ComboBox cmbType;
        internal GroupBox fraPunch;
        private ColumnHeader columnHeader6;
        private string heurePunch = "00:01";
        public Punch(string idLoginEmploye)
        {
            InitializeComponent();
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            SqlDataReader rd = new SqlCommand($"SELECT EMPLOYE FROM [DBO].[EMPLOYÉS] WHERE LOGINNAME='{idLoginEmploye}' AND ACTIF=1 AND SUPPRIMÉ= 0  ", sql).ExecuteReader();
            if (rd.Read())
            {
                cmbEmploye.Text = rd[0].ToString();
            }
            rd.Close();
            sql.Close();
            Afficher(IdNomEmploye);
        }
        public void Afficher(string sUserID)
        {
            try
            {
                ADODB.Recordset rstEmploye;
                int X;
                rstEmploye = null;
                optHeure0.Checked = true;
                mvwSelection.Value = DateTime.Today;
                AfficherDate();
                RemplirComboEmploye();
                cmbHeureSemaine.Items.Clear();
                var loopTo = (int)(cmbEmploye.Items.Count - 1);
                for (X = 0; X <= loopTo; X++)
                {
                    cmbHeureSemaine.Items.Add(cmbEmploye.Items[X].ToString());
                }
                cmbHeureSemaine.SelectedIndex = 0;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "Afficher", ex);
            }
        }
        private void CalculerHeureSemaine()
        {
            try
            {
                ADODB.Recordset rstPunch;
                double dblDebut;
                double dblFin;
                var dblTotal = default(double);
                string sDate;
                string sDebut;
                string sFin;
                rstPunch = new Recordset();
                rstPunch.Open($"SELECT DATE, HEUREDÉBUT, HEUREFIN FROM PUNCH " +
            $"WHERE NOEMPLOYE = {IdNoEmploye} AND DATE BETWEEN '{ConvertToUSDate(m_datDateChoisie)}' AND '{ConvertToUSDate(m_datDateChoisie.AddDays(6))}'", odbc, CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly);
                while (!rstPunch.EOF)
                {
                    sDate = (string)(rstPunch.Fields["Date"].Value);
                    if (!(rstPunch.Fields["HeureDébut"].Value is DBNull))
                    {
                        if (!string.IsNullOrEmpty((string)(rstPunch.Fields["HeureDébut"].Value).Trim()))
                        {
                            sDebut = (string)(rstPunch.Fields["HeureDébut"].Value);
                        }
                        else
                        {
                            sDebut = "";
                        }
                    }
                    else
                    {
                        sDebut = "";
                    }
                    if (!(rstPunch.Fields["HeureFin"].Value is DBNull))
                    {
                        if (!string.IsNullOrEmpty((string)(rstPunch.Fields["HeureFin"].Value).Trim()))
                        {
                            sFin = (string)(rstPunch.Fields["HeureFin"].Value);
                        }
                        else
                        {
                            sFin = "";
                        }
                    }
                    else
                    {
                        sFin = "";
                    }
                    if (!string.IsNullOrEmpty(sDebut) & !string.IsNullOrEmpty(sFin))
                    {
                        dblDebut = double.Parse(Gauche(sDebut, 2)) + double.Parse(Droite(sDebut, 2)) / 60d;
                        dblFin = double.Parse(Gauche(sFin, 2)) + double.Parse(Droite(sFin, 2)) / 60d;
                        dblTotal = dblTotal + (dblFin - dblDebut);
                    }
                    rstPunch.MoveNext();
                }
                rstPunch.Close();
                rstPunch = null;
                lblNbreHeure.Text = dblTotal.ToString();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "CalculerHeureSemaine", ex);
            }
        }
        private void AfficherDate()
        {
            try
            {
                int X;
                int decalage = 0;
                Label lblJour = default(Label);
                m_datDateChoisie = mvwSelection.Value;
                switch (m_datDateChoisie.DayOfWeek)
                {
                    case DayOfWeek.Sunday: { lvwJourSemaine = lvwJourSemaine1; decalage = 0; lblJour = lblJour0; } break;
                    case DayOfWeek.Monday: { lvwJourSemaine = lvwJourSemaine2; decalage = 1; lblJour = lblJour1; } break;
                    case DayOfWeek.Tuesday: { lvwJourSemaine = lvwJourSemaine3; decalage = 2; lblJour = lblJour2; } break;
                    case DayOfWeek.Wednesday: { lvwJourSemaine = lvwJourSemaine4; decalage = 3; lblJour = lblJour3; } break;
                    case DayOfWeek.Thursday: { lvwJourSemaine = lvwJourSemaine5; decalage = 4; lblJour = lblJour4; } break;
                    case DayOfWeek.Friday: { lvwJourSemaine = lvwJourSemaine6; decalage = 5; lblJour = lblJour5; } break;
                    case DayOfWeek.Saturday: { lvwJourSemaine = lvwJourSemaine7; decalage = 6; lblJour = lblJour6; } break;
                }
                lvwJourSemaine.Tag = m_datDateChoisie;
                lvwJourSemaine.BackColor = COLOR_GRIS;
                lblJour0.Text = m_datDateChoisie.AddDays(0 - decalage).ToShortDateString();
                lblJour1.Text = m_datDateChoisie.AddDays(1 - decalage).ToShortDateString();
                lblJour2.Text = m_datDateChoisie.AddDays(2 - decalage).ToShortDateString();
                lblJour3.Text = m_datDateChoisie.AddDays(3 - decalage).ToShortDateString();
                lblJour4.Text = m_datDateChoisie.AddDays(4 - decalage).ToShortDateString();
                lblJour5.Text = m_datDateChoisie.AddDays(5 - decalage).ToShortDateString();
                lblJour6.Text = m_datDateChoisie.AddDays(6 - decalage).ToShortDateString();
                fraJour.Visible = true;
                Text = $"Punch pour{cmbHeureSemaine.Text} {GetSemaineDelaDate(mvwSelection.Value)}";
                fraPunch.Visible = false;// seulement durant la construction
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "AfficherDate", ex);
            }
        }
        private void RemplirListViewJour()
        {
            try
            {
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstClient;
                ListViewItem itmPunch;
                Color lForeColor;
                lvwJour.Items.Clear();
                rstPunch = new Recordset();
                rstPunch.Open("SELECT * FROM Punch WHERE Date = '" + ConvertDate(m_datDateChoisie) + "' AND NoEmploye = " + IdNoEmploye + " ORDER BY HeureDébut", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstEmploye = new Recordset();
                rstClient = new Recordset();
                while (!rstPunch.EOF)
                {
                    itmPunch = lvwJour.Items.Add(string.Empty);
                    rstEmploye.Open("SELECT initiale FROM Employés WHERE NoEmploye = " + IdNoEmploye, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    itmPunch.Text = (string)(rstEmploye.Fields["initiale"].Value);
                    rstEmploye.Close();
                    itmPunch.Tag = rstPunch.Fields["IDPunch"].Value;
                    if (!(rstPunch.Fields["NoProjet"].Value is DBNull))
                    {
                        if (itmPunch.SubItems.Count > I_LVW_PROJET)
                        {
                            itmPunch.SubItems[I_LVW_PROJET].Text = (string)(rstPunch.Fields["NoProjet"].Value);
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_PROJET, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["NoProjet"].Value}"));
                        }
                    }
                    else if (itmPunch.SubItems.Count > I_LVW_PROJET)
                    {
                        itmPunch.SubItems[I_LVW_PROJET].Text = string.Empty;
                    }
                    else
                    {
                        itmPunch.SubItems.Insert(I_LVW_PROJET, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    if (!(rstPunch.Fields["HeureDébut"].Value is DBNull))
                    {
                        if (itmPunch.SubItems.Count > I_LVW_DEBUT)
                        {
                            itmPunch.SubItems[I_LVW_DEBUT].Text = (string)(rstPunch.Fields["HeureDébut"].Value);
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_DEBUT, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["HeureDébut"].Value}"));
                        }
                    }
                    else if (itmPunch.SubItems.Count > I_LVW_DEBUT)
                    {
                        itmPunch.SubItems[I_LVW_DEBUT].Text = string.Empty;
                    }
                    else
                    {
                        itmPunch.SubItems.Insert(I_LVW_DEBUT, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    if (!(rstPunch.Fields["HeureFin"].Value is DBNull))
                    {
                        if (itmPunch.SubItems.Count > I_LVW_FIN)
                        {
                            itmPunch.SubItems[I_LVW_FIN].Text = (string)(rstPunch.Fields["HeureFin"].Value);
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_FIN, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["HeureFin"].Value}"));
                        }
                        lForeColor = (COLOR_NOIR);
                    }
                    else
                    {
                        if (itmPunch.SubItems.Count > I_LVW_FIN)
                        {
                            itmPunch.SubItems[I_LVW_FIN].Text = string.Empty;
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_FIN, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        lForeColor = (COLOR_ROUGE);
                    }
                    if (!(rstPunch.Fields["NoClient"].Value is DBNull))
                    {
                        rstClient.Open($"SELECT NomClient FROM Client WHERE IDClient = {rstPunch.Fields["NoClient"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (itmPunch.SubItems.Count > I_LVW_CLIENT)
                        {
                            itmPunch.SubItems[I_LVW_CLIENT].Text = (string)(rstClient.Fields["NomClient"].Value);
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_CLIENT, new ListViewItem.ListViewSubItem(null,$"{rstClient.Fields["NomClient"].Value}"));
                        }
                        itmPunch.SubItems[I_LVW_CLIENT].Tag = rstPunch.Fields["NoClient"].Value;
                        rstClient.Close();
                    }
                    else if (itmPunch.SubItems.Count > I_LVW_CLIENT)
                    {
                        itmPunch.SubItems[I_LVW_CLIENT].Text = string.Empty;
                    }
                    else
                    {
                        itmPunch.SubItems.Insert(I_LVW_CLIENT, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    if (!(rstPunch.Fields["Type"].Value is DBNull))
                    {
                        if (Gauche(itmPunch.SubItems[I_LVW_PROJET].Text, 1) == "E")
                        {
                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                            {
                                itmPunch.SubItems[I_LVW_TYPE].Text = (string)(rstPunch.Fields["Type"].Value);
                            }
                            else
                            {
                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["Type"].Value}"));
                            }
                        }
                        else if (itmPunch.SubItems.Count > I_LVW_TYPE)
                        {
                            itmPunch.SubItems[I_LVW_TYPE].Text = (string)(rstPunch.Fields["Type"].Value);
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["Type"].Value}"));
                        }
                    }
                    if (!(rstPunch.Fields["Commentaire"].Value is DBNull))
                    {
                        if (itmPunch.SubItems.Count > I_LVW_COMMENTAIRE)
                        {
                            itmPunch.SubItems[I_LVW_COMMENTAIRE].Text = (string)(rstPunch.Fields["Commentaire"].Value);
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_COMMENTAIRE, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["Commentaire"].Value}"));
                        }
                    }
                    else if (itmPunch.SubItems.Count > I_LVW_COMMENTAIRE)
                    {
                        itmPunch.SubItems[I_LVW_COMMENTAIRE].Text = string.Empty;
                    }
                    else
                    {
                        itmPunch.SubItems.Insert(I_LVW_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, string.Empty));
                    }
                    if ((bool)(rstPunch.Fields["KM"].Value))
                    {
                        if (!(rstPunch.Fields["NbreKM"].Value is DBNull))
                        {
                            if (itmPunch.SubItems.Count > I_LVW_KM)
                            {
                                itmPunch.SubItems[I_LVW_KM].Text = (string)(rstPunch.Fields["NbreKM"].Value);
                            }
                            else
                            {
                                itmPunch.SubItems.Insert(I_LVW_KM, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["NbreKM"].Value}"));
                            }
                        }
                        else if (itmPunch.SubItems.Count > I_LVW_KM)
                        {
                            itmPunch.SubItems[I_LVW_KM].Text = 0.ToString();
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_KM, new ListViewItem.ListViewSubItem(null, 0.ToString()));
                        }
                    }
                    else if (itmPunch.SubItems.Count > I_LVW_KM)
                    {
                        itmPunch.SubItems[I_LVW_KM].Text = "";
                    }
                    else
                    {
                        itmPunch.SubItems.Insert(I_LVW_KM, new ListViewItem.ListViewSubItem(null, ""));
                    }
                    itmPunch.SubItems.Insert(I_LVW_KM+1, new ListViewItem.ListViewSubItem(null, $"{rstPunch.Fields["IDPunch"].Value}"));
                    lvwJour.Items[itmPunch.Index].ForeColor = lForeColor;
                    lvwJour.Items[itmPunch.Index].SubItems[I_LVW_PROJET].ForeColor = lForeColor;
                    lvwJour.Items[itmPunch.Index].SubItems[I_LVW_DEBUT].ForeColor = lForeColor;
                    lvwJour.Items[itmPunch.Index].SubItems[I_LVW_FIN].ForeColor = lForeColor;
                    lvwJour.Items[itmPunch.Index].SubItems[I_LVW_CLIENT].ForeColor = lForeColor;
                    lvwJour.Items[itmPunch.Index].SubItems[I_LVW_TYPE].ForeColor = lForeColor;
                    lvwJour.Items[itmPunch.Index].SubItems[I_LVW_COMMENTAIRE].ForeColor = lForeColor;
                    lvwJour.Items[itmPunch.Index].SubItems[I_LVW_KM].ForeColor = lForeColor;
                    rstPunch.MoveNext();
                }
                rstEmploye = null;
                rstClient = null;
                rstPunch.Close();
                rstPunch = null;
                if (lvwJour.Items.Count > 0)
                {
                    lvwJour.Items[lvwJour.Items.Count].Selected = true;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "RemplirListViewJour", ex);
            }
        }
        private void RemplirListViewJourAutorisation()
        {
            try
            {
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstAutorisation;
                ADODB.Recordset rstClient;
                ListViewItem itmPunch;
                Color lForeColor;
                rstAutorisation = new Recordset();
                rstAutorisation.Open("SELECT * FROM AUTORISATIONPUNCH WHERE AUTORISERPAR = " + IdNoEmploye, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstPunch = new Recordset();
                rstEmploye = new Recordset();
                rstClient = new Recordset();
                while (!rstAutorisation.EOF)
                {
                    rstPunch.Open($"SELECT * FROM Punch WHERE Date = '{ConvertDate(m_datDateChoisie)}' AND NoEmploye = {rstAutorisation.Fields["NoEmploye"].Value} ORDER BY HeureDébut", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstPunch.EOF)
                    {
                        itmPunch = lvwJour.Items.Add(string.Empty);
                        rstEmploye.Open($"SELECT initiale FROM Employés WHERE NoEmploye = {rstAutorisation.Fields["NoEmploye"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        itmPunch.Text = (string)(rstEmploye.Fields["initiale"].Value);
                        rstEmploye.Close();
                        itmPunch.Tag = rstPunch.Fields["IDPunch"].Value;
                        if (!(rstPunch.Fields["NoProjet"].Value is DBNull))
                        {
                            if (itmPunch.SubItems.Count > I_LVW_PROJET)
                            {
                                itmPunch.SubItems[I_LVW_PROJET].Text = (string)(rstPunch.Fields["NoProjet"].Value);
                            }
                            else
                            {
                                itmPunch.SubItems.Insert(I_LVW_PROJET, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["NoProjet"].Value}"));
                            }
                        }
                        else if (itmPunch.SubItems.Count > I_LVW_PROJET)
                        {
                            itmPunch.SubItems[I_LVW_PROJET].Text = string.Empty;
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_PROJET, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        if (!(rstPunch.Fields["HeureDébut"].Value is DBNull))
                        {
                            if (itmPunch.SubItems.Count > I_LVW_DEBUT)
                            {
                                itmPunch.SubItems[I_LVW_DEBUT].Text = (string)(rstPunch.Fields["HeureDébut"].Value);
                            }
                            else
                            {
                                itmPunch.SubItems.Insert(I_LVW_DEBUT, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["HeureDébut"].Value}"));
                            }
                        }
                        else if (itmPunch.SubItems.Count > I_LVW_DEBUT)
                        {
                            itmPunch.SubItems[I_LVW_DEBUT].Text = string.Empty;
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_DEBUT, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        if (!(rstPunch.Fields["HeureFin"].Value is DBNull))
                        {
                            if (itmPunch.SubItems.Count > I_LVW_FIN)
                            {
                                itmPunch.SubItems[I_LVW_FIN].Text = (string)(rstPunch.Fields["HeureFin"].Value);
                            }
                            else
                            {
                                itmPunch.SubItems.Insert(I_LVW_FIN, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["HeureFin"].Value}"));
                            }
                            lForeColor = (COLOR_NOIR);
                        }
                        else
                        {
                            if (itmPunch.SubItems.Count > I_LVW_FIN)
                            {
                                itmPunch.SubItems[I_LVW_FIN].Text = string.Empty;
                            }
                            else
                            {
                                itmPunch.SubItems.Insert(I_LVW_FIN, new ListViewItem.ListViewSubItem(null, string.Empty));
                            }
                            lForeColor = (COLOR_ROUGE);
                        }
                        if (!(rstPunch.Fields["NoClient"].Value is DBNull))
                        {
                            rstClient.Open($"SELECT NomClient FROM Client WHERE IDClient = {rstPunch.Fields["NoClient"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            if (itmPunch.SubItems.Count > I_LVW_CLIENT)
                            {
                                itmPunch.SubItems[I_LVW_CLIENT].Text = (string)(rstClient.Fields["NomClient"].Value);
                            }
                            else
                            {
                                itmPunch.SubItems.Insert(I_LVW_CLIENT, new ListViewItem.ListViewSubItem(null,$"{rstClient.Fields["NomClient"].Value}"));
                            }
                            itmPunch.SubItems[I_LVW_CLIENT].Tag = rstPunch.Fields["NoClient"].Value;
                            rstClient.Close();
                        }
                        else if (itmPunch.SubItems.Count > I_LVW_CLIENT)
                        {
                            itmPunch.SubItems[I_LVW_CLIENT].Text = string.Empty;
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_CLIENT, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        if (!(rstPunch.Fields["Type"].Value is DBNull))
                        {
                            if (Gauche(itmPunch.SubItems[I_LVW_PROJET].Text, 1) == "E")
                            {
                                switch (rstPunch.Fields["Type"].Value)
                                {
                                    case "Dessin":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Dessins électriques";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Dessins électriques"));
                                            }
                                            break;
                                        }
                                    case "Fabrication":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Fabrication";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Fabrication"));
                                            }
                                            break;
                                        }
                                    case "Assemblage":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Assemblage du panneau";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Assemblage du panneau"));
                                            }
                                            break;
                                        }
                                    case "ProgInterface":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Programmation d'interface";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Programmation d'interface"));
                                            }
                                            break;
                                        }
                                    case "ProgAutomate":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Programmation d'automate";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Programmation d'automate"));
                                            }
                                            break;
                                        }
                                    case "ProgRobot":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Programmation de robot";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Programmation de robot"));
                                            }
                                            break;
                                        }
                                    case "Vision":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Vision artificielle";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Vision artificielle"));
                                            }
                                            break;
                                        }
                                    case "Test":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Tests finaux";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Tests finaux"));
                                            }
                                            break;
                                        }
                                    case "Installation":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Installation";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Installation"));
                                            }
                                            break;
                                        }
                                    case "MiseService":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Mise en service";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Mise en service"));
                                            }
                                            break;
                                        }
                                    case "Formation":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Formation du personnel";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Formation du personnel"));
                                            }
                                            break;
                                        }
                                    case "Gestion":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Gestion du projet";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Gestion du projet"));
                                            }
                                            break;
                                        }
                                    case "Shipping":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Expédition";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Expédition"));
                                            }
                                            break;
                                        }
                                    case "Prototypage-Dévelloppement expérimental":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Prototypage-Dévelloppement expérimental";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Prototypage-Dévelloppement expérimental"));
                                            }
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                switch (rstPunch.Fields["Type"].Value)
                                {
                                    case "Dessin":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Conception et dessins";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Conception et dessins"));
                                            }
                                            break;
                                        }
                                    case "Coupe":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Coupe et préparation (sauf soudage)";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Coupe et préparation (sauf soudage)"));
                                            }
                                            break;
                                        }
                                    case "Machinage":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Machinage";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Machinage"));
                                            }
                                            break;
                                        }
                                    case "Soudure":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Coupe, soudure et meulage";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Coupe, soudure et meulage"));
                                            }
                                            break;
                                        }
                                    case "Assemblage":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Assemblage des systèmes";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Assemblage des systèmes"));
                                            }
                                            break;
                                        }
                                    case "Peinture":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Peinture et finition";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Peinture et finition"));
                                            }
                                            break;
                                        }
                                    case "Test":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Tests finaux";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Tests finaux"));
                                            }
                                            break;
                                        }
                                    case "Installation":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Installation";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Installation"));
                                            }
                                            break;
                                        }
                                    case "Formation":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Formation du personnel";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Formation du personnel"));
                                            }
                                            break;
                                        }
                                    case "Gestion":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Gestion du projet";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Gestion du projet"));
                                            }
                                            break;
                                        }
                                    case "Shipping":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Expédition";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Expédition"));
                                            }
                                            break;
                                        }
                                    case "Prototypage-Dévelloppement expérimental":
                                        {
                                            if (itmPunch.SubItems.Count > I_LVW_TYPE)
                                            {
                                                itmPunch.SubItems[I_LVW_TYPE].Text = "Prototypage-Dévelloppement expérimental";
                                            }
                                            else
                                            {
                                                itmPunch.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, "Prototypage-Dévelloppement expérimental"));
                                            }
                                            break;
                                        }
                                }
                            }
                        }
                        if (!(rstPunch.Fields["Commentaire"].Value is DBNull))
                        {
                            if (itmPunch.SubItems.Count > I_LVW_COMMENTAIRE)
                            {
                                itmPunch.SubItems[I_LVW_COMMENTAIRE].Text = (string)(rstPunch.Fields["Commentaire"].Value);
                            }
                            else
                            {
                                itmPunch.SubItems.Insert(I_LVW_COMMENTAIRE, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["Commentaire"].Value}"));
                            }
                        }
                        else if (itmPunch.SubItems.Count > I_LVW_COMMENTAIRE)
                        {
                            itmPunch.SubItems[I_LVW_COMMENTAIRE].Text = string.Empty;
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        if ((bool)rstPunch.Fields["KM"].Value == true)
                        {
                            if (itmPunch.SubItems.Count > I_LVW_KM)
                            {
                                itmPunch.SubItems[I_LVW_KM].Text = (string)(rstPunch.Fields["NbreKM"].Value);
                            }
                            else
                            {
                                itmPunch.SubItems.Insert(I_LVW_KM, new ListViewItem.ListViewSubItem(null,$"{rstPunch.Fields["NbreKM"].Value}"));
                            }
                        }
                        else if (itmPunch.SubItems.Count > I_LVW_KM)
                        {
                            itmPunch.SubItems[I_LVW_KM].Text = string.Empty;
                        }
                        else
                        {
                            itmPunch.SubItems.Insert(I_LVW_KM, new ListViewItem.ListViewSubItem(null, string.Empty));
                        }
                        lvwJour.Items[itmPunch.Index].ForeColor = lForeColor;
                        lvwJour.Items[itmPunch.Index].SubItems[I_LVW_PROJET].ForeColor = lForeColor;
                        lvwJour.Items[itmPunch.Index].SubItems[I_LVW_DEBUT].ForeColor = lForeColor;
                        lvwJour.Items[itmPunch.Index].SubItems[I_LVW_FIN].ForeColor = lForeColor;
                        lvwJour.Items[itmPunch.Index].SubItems[I_LVW_CLIENT].ForeColor = lForeColor;
                        lvwJour.Items[itmPunch.Index].SubItems[I_LVW_TYPE].ForeColor = lForeColor;
                        lvwJour.Items[itmPunch.Index].SubItems[I_LVW_COMMENTAIRE].ForeColor = lForeColor;
                        lvwJour.Items[itmPunch.Index].SubItems[I_LVW_KM].ForeColor = lForeColor;
                        rstPunch.MoveNext();
                    }
                    rstPunch.Close();
                    rstAutorisation.MoveNext();
                }
                rstPunch = null;
                rstClient = null;
                rstEmploye = null;
                rstAutorisation.Close();
                rstAutorisation = null;
                lvwJour_Click(lvwJour, new EventArgs());
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "RemplirListViewJourAutorisation", ex);
            }
        }
        private void RemplirListViewSemaineChoisie()
        {
            string sHeureDebutFin;
            Color lForeColor;
            ListView listView = new ListView();
            ADODB.Recordset rstPunch = new ADODB.Recordset();
            rstPunch.Open($"SELECT * FROM Punch WHERE Date BETWEEN '{lblJour0.Text}' AND '{lblJour6.Text}' AND NoEmploye = {IdNoEmploye} ORDER BY HeureDébut", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rstPunch.EOF)
            {
                idPunch = (int)rstPunch.Fields["IDPunch"].Value;
                if (!(rstPunch.Fields["date"].Value is DBNull))
                {
                    if (rstPunch.Fields["date"].Value == lblJour0.Text) { listView = lvwJourSemaine1; }
                    if (rstPunch.Fields["date"].Value == lblJour1.Text) { listView = lvwJourSemaine2; }
                    if (rstPunch.Fields["date"].Value == lblJour2.Text) { listView = lvwJourSemaine3; }
                    if (rstPunch.Fields["date"].Value == lblJour3.Text) { listView = lvwJourSemaine4; }
                    if (rstPunch.Fields["date"].Value == lblJour4.Text) { listView = lvwJourSemaine5; }
                    if (rstPunch.Fields["date"].Value == lblJour5.Text) { listView = lvwJourSemaine6; }
                    if (rstPunch.Fields["date"].Value == lblJour6.Text) { listView = lvwJourSemaine7; }
                }
                ListViewItem itmPunch = listView.Items.Add(string.Empty);
                itmPunch.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Conteneur.idInitiales.Text));
                sHeureDebutFin = $"{rstPunch.Fields["HeureDébut"].Value}-";
                if (!(rstPunch.Fields["HeureFin"].Value is DBNull))
                {
                    sHeureDebutFin += $"{rstPunch.Fields["HeureFin"].Value}";
                    lForeColor = (COLOR_NOIR);
                }
                else
                {
                    lForeColor = (COLOR_ROUGE);
                }
                itmPunch.SubItems.Insert(I_LVW_TEMPS, new ListViewItem.ListViewSubItem(null, sHeureDebutFin));
            }
            rstPunch.Close();
            /*
            try
            {
                if (bAujourdhui == false)
                {
                    switch (m_datDateChoisie.DayOfWeek)
                    {
                        case DayOfWeek.Sunday: { lvwJourSemaine = lvwJourSemaine1; decalage = 0; lblJour = lblJour0; lblNomJour = lblNomJour0; } break;
                        case DayOfWeek.Monday: { lvwJourSemaine = lvwJourSemaine2; decalage = 1; lblJour = lblJour1; lblNomJour = lblNomJour1; } break;
                        case DayOfWeek.Tuesday: { lvwJourSemaine = lvwJourSemaine3; decalage = 2; lblJour = lblJour2; lblNomJour = lblNomJour2; } break;
                        case DayOfWeek.Wednesday: { lvwJourSemaine = lvwJourSemaine4; decalage = 3; lblJour = lblJour3; lblNomJour = lblNomJour3; } break;
                        case DayOfWeek.Thursday: { lvwJourSemaine = lvwJourSemaine5; decalage = 4; lblJour = lblJour4; lblNomJour = lblNomJour4; } break;
                        case DayOfWeek.Friday: { lvwJourSemaine = lvwJourSemaine6; decalage = 5; lblJour = lblJour5; lblNomJour = lblNomJour5; } break;
                        case DayOfWeek.Saturday: { lvwJourSemaine = lvwJourSemaine7; decalage = 6; lblJour = lblJour6; lblNomJour = lblNomJour6; } break;
                    }
                    lblJour.ForeColor = Color.White;
                    lblNomJour.ForeColor = Color.White;
                    lvwJourSemaine.Items.Clear();
                    iJourSemaine = m_datDateChoisie.DayOfWeek;
                    datPremiereDate = m_datDateChoisie;
                    datDerniereDate = m_datDateChoisie;
                    while (!(datPremiereDate.DayOfWeek == DayOfWeek.Sunday))
                    {
                        datPremiereDate.AddDays(-1);
                    }
                    while (!(datDerniereDate.DayOfWeek == DayOfWeek.Saturday)) { datDerniereDate.AddDays(+1d); }
                    Clipboard.SetText($"SELECT * FROM Punch WHERE Date BETWEEN '{lblJour0.Text}' AND '{lblJour6.Text}' AND NoEmploye = {IdNoEmploye} ORDER BY HeureDébut");
                    lvwJourSemaine1.Tag = datDerniereDate.AddDays(0 + decalage).ToShortDateString(); lblJour0.Text = datDerniereDate.AddDays(0 + decalage).ToShortDateString();
                    lvwJourSemaine2.Tag = datDerniereDate.AddDays(0 + decalage).ToShortDateString(); lblJour1.Text = datDerniereDate.AddDays(0 + decalage).ToShortDateString();
                    lvwJourSemaine3.Tag = datDerniereDate.AddDays(0 + decalage).ToShortDateString(); lblJour2.Text = datDerniereDate.AddDays(0 + decalage).ToShortDateString();
                    lvwJourSemaine4.Tag = datDerniereDate.AddDays(0 + decalage).ToShortDateString(); lblJour3.Text = datDerniereDate.AddDays(0 + decalage).ToShortDateString();
                    lvwJourSemaine5.Tag = datDerniereDate.AddDays(0 + decalage).ToShortDateString(); lblJour4.Text = datDerniereDate.AddDays(0 + decalage).ToShortDateString();
                    lvwJourSemaine6.Tag = datDerniereDate.AddDays(0 + decalage).ToShortDateString(); lblJour5.Text = datDerniereDate.AddDays(0 + decalage).ToShortDateString();
                    lvwJourSemaine7.Tag = datDerniereDate.AddDays(0 + decalage).ToShortDateString(); lblJour6.Text = datDerniereDate.AddDays(0 + decalage).ToShortDateString();

                }
                else
                {
                    m_datDateChoisie = DateTime.Today;
                    switch (m_datDateChoisie.DayOfWeek)
                    {
                        case DayOfWeek.Sunday: { lvwJourSemaine = lvwJourSemaine1; decalage = 0; lblJour = lblJour0; lblNomJour = lblNomJour0; } break;
                        case DayOfWeek.Monday: { lvwJourSemaine = lvwJourSemaine2; decalage = 1; lblJour = lblJour1; lblNomJour = lblNomJour1; } break;
                        case DayOfWeek.Tuesday: { lvwJourSemaine = lvwJourSemaine3; decalage = 2; lblJour = lblJour2; lblNomJour = lblNomJour2; } break;
                        case DayOfWeek.Wednesday: { lvwJourSemaine = lvwJourSemaine4; decalage = 3; lblJour = lblJour3; lblNomJour = lblNomJour3; } break;
                        case DayOfWeek.Thursday: { lvwJourSemaine = lvwJourSemaine5; decalage = 4; lblJour = lblJour4; lblNomJour = lblNomJour4; } break;
                        case DayOfWeek.Friday: { lvwJourSemaine = lvwJourSemaine6; decalage = 5; lblJour = lblJour5; lblNomJour = lblNomJour5; } break;
                        case DayOfWeek.Saturday: { lvwJourSemaine = lvwJourSemaine7; decalage = 6; lblJour = lblJour6; lblNomJour = lblNomJour6; } break;
                    }
                    lblJour.ForeColor = Color.White;
                    lblNomJour.ForeColor = Color.White;
                    lvwJourSemaine.Items.Clear();
                    iJourSemaine = m_datDateChoisie.DayOfWeek;
                    datPremiereDate = m_datDateChoisie;
                    datDerniereDate = m_datDateChoisie;
                    while (!(datPremiereDate.DayOfWeek == DayOfWeek.Sunday))
                    {
                        datPremiereDate.AddDays(-1);
                    }
                    while (!(datDerniereDate.DayOfWeek == DayOfWeek.Saturday)) { datDerniereDate.AddDays(+1d); }
                    lvwJourSemaine.Items.Clear();
                    rstPunch.Open($"SELECT * FROM Punch WHERE Date = '{ConvertDate(m_datDateChoisie)}' AND NoEmploye = {IdNoEmploye}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstPunch.EOF)
                    {
                        itmSemaine = lvwJourSemaine.Items.Add(string.Empty);
                        itmSemaine.Tag = rstPunch.Fields["IDPunch"].Value;
                        itmSemaine.Text = Conteneur.idInitiales.Text; ;
                        sHeureDebutFin = $"{rstPunch.Fields["HeureDébut"].Value}-";
                        if (!(rstPunch.Fields["HeureFin"].Value is DBNull))
                        {
                            sHeureDebutFin += rstPunch.Fields["HeureFin"].Value;
                            lForeColor = (COLOR_NOIR);
                        }
                        else
                        {
                            lForeColor = (COLOR_ROUGE);
                        }
                        if (itmSemaine.SubItems.Count > I_LVW_TEMPS)
                        {
                            itmSemaine.SubItems[I_LVW_TEMPS].Text = sHeureDebutFin;
                        }
                        else
                        {
                            itmSemaine.SubItems.Insert(I_LVW_TEMPS, new ListViewItem.ListViewSubItem(null, sHeureDebutFin));
                        }
                        lvwJourSemaine.Items[itmSemaine.Index].ForeColor = lForeColor;
                        lvwJourSemaine.Items[itmSemaine.Index].SubItems[I_LVW_TEMPS].ForeColor = lForeColor;
                        rstPunch.MoveNext();
                    }
                    rstPunch.Close();
                }
                rstPunch = null;
                rstEmploye = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "RemplirListViewSemaineChoisie", ex);
            }*/
        }
        private void RemplirListViewSemaineAutorisation(bool bAujourdhui)
        {
            try
            {
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstAutorisation;
                DateTime datPremiereDate;
                DateTime datDerniereDate;
                int X;
                string sHeureDebutFin;
                ListViewItem itmSemaine;
                Color lForeColor;
                int decalage = 0;
                Label lblJour = default(Label);
                Label lblNomJour = default(Label);
                ListView lvwJourSemaine = default(ListView);
                rstPunch = new Recordset();
                rstEmploye = new Recordset();
                rstAutorisation = new Recordset();
                if (bAujourdhui == false)
                {
                    switch (m_datDateChoisie.DayOfWeek)
                    {
                        case DayOfWeek.Sunday: { lvwJourSemaine = lvwJourSemaine1; decalage = 0; lblJour = lblJour0; lblNomJour = lblNomJour0; } break;
                        case DayOfWeek.Monday: { lvwJourSemaine = lvwJourSemaine2; decalage = 1; lblJour = lblJour1; lblNomJour = lblNomJour1; } break;
                        case DayOfWeek.Tuesday: { lvwJourSemaine = lvwJourSemaine3; decalage = 2; lblJour = lblJour2; lblNomJour = lblNomJour2; } break;
                        case DayOfWeek.Wednesday: { lvwJourSemaine = lvwJourSemaine4; decalage = 3; lblJour = lblJour3; lblNomJour = lblNomJour3; } break;
                        case DayOfWeek.Thursday: { lvwJourSemaine = lvwJourSemaine5; decalage = 4; lblJour = lblJour4; lblNomJour = lblNomJour4; } break;
                        case DayOfWeek.Friday: { lvwJourSemaine = lvwJourSemaine6; decalage = 5; lblJour = lblJour5; lblNomJour = lblNomJour5; } break;
                        case DayOfWeek.Saturday: { lvwJourSemaine = lvwJourSemaine7; decalage = 6; lblJour = lblJour6; lblNomJour = lblNomJour6; } break;
                    }
                    lblJour.ForeColor = Color.White;
                    lblNomJour.ForeColor = Color.White;
                    iJourSemaine = m_datDateChoisie.DayOfWeek;
                    datPremiereDate = m_datDateChoisie;
                    datDerniereDate = m_datDateChoisie;
                    while (!(datPremiereDate.DayOfWeek == DayOfWeek.Sunday)) { datPremiereDate.AddDays(-1); }
                    while (!(datDerniereDate.DayOfWeek == DayOfWeek.Saturday)) { datDerniereDate.AddDays(+1d); }
                    rstAutorisation.Open("SELECT * FROM AutorisationPunch WHERE AutoriserPar = " + IdNoEmploye, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstAutorisation.EOF)
                    {

                        rstPunch.Open($"SELECT * FROM Punch WHERE Date BETWEEN '{ConvertDate(datPremiereDate)} ' AND '{ConvertDate(datDerniereDate)}' AND NoEmploye = {rstAutorisation.Fields["NoEmploye"].Value}  ORDER BY HeureDébut", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        while (!rstPunch.EOF)
                        {

                            itmSemaine = lvwJourSemaine.Items.Add(string.Empty);
                            itmSemaine.Tag = rstPunch.Fields["IDPunch"].Value;
                            rstEmploye.Open($"SELECT initiale FROM Employés WHERE NoEmploye = {rstAutorisation.Fields["NoEmploye"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            itmSemaine.Text = (string)(rstEmploye.Fields["initiale"].Value);
                            rstEmploye.Close();
                            sHeureDebutFin = $"{rstPunch.Fields["HeureDébut"].Value}-";
                            if (!(rstPunch.Fields["HeureFin"].Value is DBNull))
                            {
                                sHeureDebutFin += rstPunch.Fields["HeureFin"].Value;
                                lForeColor = (COLOR_NOIR);
                            }
                            else
                            {
                                lForeColor = (COLOR_ROUGE);
                            }
                            if (itmSemaine.SubItems.Count > I_LVW_TEMPS)
                            {
                                itmSemaine.SubItems[I_LVW_TEMPS].Text = sHeureDebutFin;
                            }
                            else
                            {
                                itmSemaine.SubItems.Insert(I_LVW_TEMPS, new ListViewItem.ListViewSubItem(null, sHeureDebutFin));
                            }
                            lvwJourSemaine.Items[itmSemaine.Index].ForeColor = lForeColor;
                            lvwJourSemaine.Items[itmSemaine.Index].SubItems[I_LVW_TEMPS].ForeColor = lForeColor;
                            rstPunch.MoveNext();
                        }
                        rstPunch.Close();
                        rstAutorisation.MoveNext();
                    }
                    rstAutorisation.Close();
                }
                else
                {
                    rstAutorisation.Open("SELECT * FROM AutorisationPunch WHERE AutoriserPar = " + IdNoEmploye, odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    while (!rstAutorisation.EOF)
                    {

                        rstPunch.Open($"SELECT * FROM Punch WHERE Date = '{ConvertDate(m_datDateChoisie)}' AND NoEmploye = {rstAutorisation.Fields["NoEmploye"].Value} ORDER BY HeureDébut", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        while (!rstPunch.EOF)
                        {

                            itmSemaine = lvwJourSemaine.Items.Add(string.Empty);
                            itmSemaine.Tag = rstPunch.Fields["IDPunch"].Value;
                            rstEmploye.Open($"SELECT initiale FROM Employés WHERE NoEmploye = {rstAutorisation.Fields["NoEmploye"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                            itmSemaine.Text = (string)(rstEmploye.Fields["initiale"].Value);
                            rstEmploye.Close();
                            sHeureDebutFin = $"{rstPunch.Fields["HeureDébut"].Value}-";
                            if (!(rstPunch.Fields["HeureFin"].Value is DBNull))
                            {
                                sHeureDebutFin += rstPunch.Fields["HeureFin"].Value;
                                lForeColor = (COLOR_NOIR);
                            }
                            else
                            {
                                lForeColor = (COLOR_ROUGE);
                            }
                            if (itmSemaine.SubItems.Count > I_LVW_TEMPS)
                            {
                                itmSemaine.SubItems[I_LVW_TEMPS].Text = sHeureDebutFin;
                            }
                            else
                            {
                                itmSemaine.SubItems.Insert(I_LVW_TEMPS, new ListViewItem.ListViewSubItem(null, sHeureDebutFin));
                            }
                            lvwJourSemaine.Items[itmSemaine.Index].ForeColor = lForeColor;
                            lvwJourSemaine.Items[itmSemaine.Index].SubItems[I_LVW_TEMPS].ForeColor = lForeColor;
                            rstPunch.MoveNext();
                        }
                        rstPunch.Close();
                        rstAutorisation.MoveNext();
                    }
                    rstAutorisation.Close();
                }
                rstAutorisation = null;
                rstEmploye = null;
                rstPunch = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "RemplirListViewSemaineAutorisation", ex);
            }
        }
        private void chkDiner_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkDiner.Checked)
                {
                    optHeureDiner1.Enabled = true;
                    optHeureDiner0.Enabled = true;
                }
                else
                {
                    optHeureDiner1.Enabled = false;
                    optHeureDiner0.Enabled = false;
                }
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "chkDiner_Click", ex);
            }
        }
        private void chkPMDiner_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (chkPMDiner.Checked)
                {
                    optPMHeureDiner1.Enabled = true;
                    optPMHeureDiner0.Enabled = true;
                }
                else
                {
                    optPMHeureDiner1.Enabled = false;
                    optPMHeureDiner0.Enabled = false;
                }
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "chkPMDiner_Click", ex);
            }
        }
        private void chkDiner_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    if (chkDiner.Checked)
                    {
                        chkDiner.Checked = false;
                    }
                    else
                    {
                        chkDiner.Checked = true;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "chkDiner_MouseUp", ex);
            }
        }
        private void chkPMDiner_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    if (chkPMDiner.Checked)
                    {
                        chkPMDiner.CheckState = CheckState.Unchecked;
                    }
                    else
                    {
                        chkPMDiner.CheckState = CheckState.Checked;
                    }
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "chkPMDiner_MouseUp", ex);
            }
        }
        private void chkKM_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
        }
        private void chkKM_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    if (chkKM.Checked)
                    {
                        chkKM.CheckState = CheckState.Unchecked;
                    }
                    else
                    {
                        chkKM.CheckState = CheckState.Checked;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "chkKM_MouseUp", ex);
            }
        }
        private void cmbEmploye_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtEmploye.Text = cmbEmploye.Text;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmbEmploye_Click", ex);
            }
        }
        private void cmbHeureSemaine_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                CalculerHeureSemaine();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmbHeureSemaine_Click", ex);
            }
        }
        private void cmdAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraJour.Visible = true;
                fraPunch.Visible = false;
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdAnnuler_Click", ex);
            }
        }
        private void cmdBrowseComment_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                string sProjet = txtNoProjet.Text;
                if (!string.IsNullOrEmpty(txtNoProjet.Text))
                {
                    if (!string.IsNullOrEmpty(txtClient.Text))
                    {
                        Form f = new ChoixCommentaire(sProjet);
                        f.MdiParent = Conteneur.ActiveForm.MdiParent;
                        f.Show();
                        if (!string.IsNullOrEmpty(sCommentaire))
                        {
                            txtCommentaires.Text = sCommentaire;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Numéro de projet ou soumission invalide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("Le numéro de projet ou soumission est obligatoire!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdBrowseComment_Click", ex);
            }
        }
        private void cmdBrowseCommentPM_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(mskPMNoProjet.Text))
                {
                    if (!string.IsNullOrEmpty(txtPMClient.Text))
                    {
                        Form f = new ChoixCommentaire(mskPMNoProjet.Text);
                        f.MdiParent = Conteneur.ActiveForm.MdiParent;
                        f.Show();
                        txtCommentaires.Text = sCommentaire;
                    }
                    else
                    {
                        MessageBox.Show("Numéro de projet ou soumission invalide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("Le numéro de projet ou soumission est obligaoire!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdBrowseCommentPM_Click", ex);
            }
        }
        private void cmdPMAnnuler_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                fraJour.Visible = true;
                fraPunch.Visible = false;
                fraPunchMultiple.Visible = false;
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdPMAnnuler_Click", ex);
            }
        }
        private void cmdAnnuler_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdAnnuler_Click(cmdAnnuler, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdAnnuler_MouseUp", ex);
            }
        }
        private void cmdPMAnnuler_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdPMAnnuler_Click(cmdPMAnnuler, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdPMAnnuler_MouseUp", ex);
            }
        }
        private void cmdModifierPunchIn_Click(object eventSender, EventArgs eventArgs)
        {
            if (lvwJour.Items.Count > 0)
            {
                if (VerifierModificationDate() == true)
                {
                    PunchSousControleSimple ModifierPunchIn = new PunchSousControleSimple(lvwJour.FocusedItem, true, false);
                    ModifierPunchIn.Text = "Modification du punch in";
                    ModifierPunchIn.ShowDialog();
                }
            }
            m_bMonthViewHasFocus = false;
            return;
        }
       
        private void cmdModifierPunchIn_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdModifierPunchIn_Click(cmdModifierPunchIn, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdModifierPunchIn_MouseUp", ex);
            }
        }
        private void cmdModifierPunchOut_Click(object eventSender, EventArgs eventArgs)
        {
            if (VerifierModificationDate() == true)
            {
                if (lvwJour.Items.Count > 0)
                {
                    PunchSousControleSimple ModifPunchOut = new PunchSousControleSimple(lvwJour.FocusedItem, false, true);
                    ModifPunchOut.Text = "Modification du punch out";
                    ModifPunchOut.ShowDialog();
                }
            }
            m_bMonthViewHasFocus = false;
        }
        private void cmdModifierPunchOut_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            SaveSetting("PWE.ControleurServeur", "Punch", DateTime.Now.ToString(), "Modification fin");
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdModifierPunchOut_Click(cmdModifierPunchOut, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdModifierPunchOut_MouseUp", ex);
            }
        }
        private void cmdOK_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdOK_Click(cmdOK, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdOK_MouseUp", ex);
            }
        }
        private void cmdPMOK_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    cmdPMOK_Click(cmdPMOK, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdPMOK_MouseUp", ex);
            }
        }
        private void cmdPunchIn_Click(object eventSender, EventArgs e)
        {
            PunchIn p = new PunchIn();
            p.MdiParent = Conteneur.Mdi;
            p.cmbEmploye.Text = cmbEmploye.Text;
            p.optHeure0.Checked = false;
            p.optHeure1.Checked = true;
            p.Show();
        }
        private void AfficherPunchOut()
        {
            try
            {
                ADODB.Recordset rstEmploye;
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstClient;
                int X;
                int G;
                rstPunch = new Recordset();
                rstEmploye = new Recordset();
                rstClient = new Recordset();
                rstPunch.Open($"SELECT * FROM Punch WHERE IDPunch = {(string)lvwJour.FocusedItem.Tag}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                rstEmploye.Open($"SELECT employe FROM Employés WHERE NoEmploye = {rstPunch.Fields["NoEmploye"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                for (X = 0; X <= (cmbEmploye.Items.Count - 1); X++)
                {
                    if (cmbEmploye.Items[X].ToString() == rstEmploye.Fields["Employe"].Value)
                    {
                        cmbEmploye.SelectedIndex = X;
                        break;
                    }
                }
                rstEmploye.Close();
                rstEmploye = null;
                rstClient.Open($"SELECT NomClient FROM Client WHERE IDClient = {rstPunch.Fields["NoClient"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                txtClient.Text = (string)(rstClient.Fields["NomClient"].Value);
                idClient = rstPunch.Fields["NoClient"].Value;
                rstClient.Close();
                rstClient = null;
                txtNoProjet.Text = Droite((string)(rstPunch.Fields["NoProjet"].Value), 8);
                RemplirComboType();
                AfficherTypePunch();
                if (!(rstPunch.Fields["Commentaire"].Value is DBNull))
                {
                    txtCommentaires.Text = (string)(rstPunch.Fields["Commentaire"].Value);
                }
                else
                {
                    txtCommentaires.Text = string.Empty;
                }
                if ((bool)rstPunch.Fields["KM"].Value == true)
                {
                    chkKM.Checked = (bool)rstPunch.Fields["KM"].Value;
                    if (!(rstPunch.Fields["NbreKM"].Value is DBNull))
                    {
                        txtKM.Text = (string)(rstPunch.Fields["NbreKM"].Value);
                    }
                    else
                    {
                        txtKM.Text = 0.ToString();
                    }
                }
                else
                {
                    chkKM.CheckState = CheckState.Unchecked;
                    txtKM.Text = string.Empty;
                }
                switch (Gauche((string)(rstPunch.Fields["NoProjet"].Value), 1) ?? "")
                {
                    case "E": { optTypePunch0.Checked = true; break; }
                    case "M": { optTypePunch1.Checked = true; break; }
                }
                if (!(rstPunch.Fields["Type"].Value is DBNull))
                {
                    if (Gauche((string)(rstPunch.Fields["NoProjet"].Value), 1) == "E")
                    {
                        for (G = 0; G <= cmbType.Items.Count; G++)
                        {
                            if (cmbType.Items[G] == rstPunch.Fields["Type"].Value)
                            {
                                cmbType.SelectedIndex = G;
                                break;
                            }
                        }
                    }
                    else
                    {
                        var loopTo2 = (int)cmbType.Items.Count;
                        for (G = 0; G <= loopTo2; G++)
                        {
                            if (cmbType.Items[G].ToString() == rstPunch.Fields["Type"].Value)
                            {
                                cmbType.SelectedIndex = G;
                                break;
                            }
                        }
                    }
                }
                picTypePunch.Enabled = false;
                txtNoProjet.Visible = true;
                txtEmploye.Visible = true;
                cmbEmploye.Visible = false;
                fraJour.Visible = false;
                fraPunch.Visible = true;
                fraPunchMultiple.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "AfficherPunchOut", ex);
            }
        }
        private void RemplirComboEmploye()
        {
            try
            {
                ADODB.Recordset rstAutorisation = new ADODB.Recordset();
                ListViewItem itmEmploye;
                cmbEmploye.Items.Clear();
                lvwEmployes.Items.Clear();
                cmbHeureSemaine.Items.Clear();
                foreach (DB_Employe p in Employes)
                {
                    cmbEmploye.Items.Add(p.Employes);
                    itmEmploye = lvwEmployes.Items.Add(string.Empty);
                    itmEmploye.Text = p.Employes;
                    itmEmploye.Tag = p.Noemploye.ToString();
                    cmbHeureSemaine.Items.Add(new ListItem(p.Employes, p.Noemploye.ToString()));
                    if (cmbEmploye.Items.Count == 1)
                    {
                        cmbEmploye.SelectedIndex = 0;
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "RemplirComboEmploye", ex);
            }
        }
        private void cmdPunchOut_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
        }
        private void Punch_Load(object eventSender, EventArgs eventArgs)
        {
            Text = System.Windows.Forms.Application.ProductName + ".EmulateurCrystalWeb." + Name;
            toolStripStatusLabel1.Text = GetSemaineDelaDate(mvwSelection.Value);
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
            toolStripStatusLabel3.Text = Conteneur.titrePunch;
            m_datDateChoisie = mvwSelection.Value;
            mvwSelection.Value = DateTime.Today;
            lvwJourSemaine1.BackColor = COLOR_BLANC;
            lvwJourSemaine2.BackColor = COLOR_BLANC;
            lvwJourSemaine3.BackColor = COLOR_BLANC;
            lvwJourSemaine4.BackColor = COLOR_BLANC;
            lvwJourSemaine5.BackColor = COLOR_BLANC;
            lvwJourSemaine6.BackColor = COLOR_BLANC;
            lvwJourSemaine7.BackColor = COLOR_BLANC;
            m_datDateChoisie = DateTime.Today;
            switch (m_datDateChoisie.DayOfWeek)
            {
                case DayOfWeek.Sunday: { lvwJourSemaine = lvwJourSemaine1; decalage = 0; lblJour = lblJour0; } break;
                case DayOfWeek.Monday: { lvwJourSemaine = lvwJourSemaine2; decalage = 1; lblJour = lblJour1; } break;
                case DayOfWeek.Tuesday: { lvwJourSemaine = lvwJourSemaine3; decalage = 2; lblJour = lblJour2; } break;
                case DayOfWeek.Wednesday: { lvwJourSemaine = lvwJourSemaine4; decalage = 3; lblJour = lblJour3; } break;
                case DayOfWeek.Thursday: { lvwJourSemaine = lvwJourSemaine5; decalage = 4; lblJour = lblJour4; } break;
                case DayOfWeek.Friday: { lvwJourSemaine = lvwJourSemaine6; decalage = 5; lblJour = lblJour5; } break;
                case DayOfWeek.Saturday: { lvwJourSemaine = lvwJourSemaine7; decalage = 6; lblJour = lblJour6; } break;
            }
            lblJour.ForeColor = COLOR_JAUNE;
            lvwJourSemaine.Tag = m_datDateChoisie;
            lvwJourSemaine.BackColor = COLOR_GRIS;
            fraJour.Visible = true;
            fraPunch.Visible = true;
            Table_exist();
            mvwSelection.Value = DateTime.Today;
            mvwSelection.Format = DateTimePickerFormat.Long;
            m_datDateChoisie = mvwSelection.Value;
            RemplirComboEmploye();
            cmbHeureSemaine.Text = IdNomEmploye;
            ListerPunchSemaineActive();
        }
        private void ListerPunchSemaineActive()
        {
            ListViewItem itJour = new ListViewItem();
            ADODB.Recordset rd = new ADODB.Recordset();
            double temps = 0d;
            rd.Open($"SELECT * FROM PUNCH WHERE DATE BETWEEN '{lblJour0.Text}' AND '{lblJour6.Text}' AND NoEmploye = '{IdNoEmploye}' ORDER BY HeureDébut", Program.odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
            while (!rd.EOF)
            {
                Recordset rd1 = new Recordset();
                rd1.Open($"SELECT [NOMCLIENT]FROM [DBO].[CLIENT] WHERE IDCLIENT='{rd.Fields["NoClient"].Value}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                ListViewItem itm = lvwJour.Items.Add(string.Empty);
                itm.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Conteneur.idInitiales.Text));
                itm.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, $"{rd.Fields["NoProjet"].Value}"));
                itm.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, $"{rd.Fields["HeureDébut"].Value}"));
                if(!(rd.Fields["HeureFin"].Value is DBNull))
                {
                itm.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, $"{rd.Fields["HeureFin"].Value}"));
                }
                /// si recorset2 ==EOF ou BOF 
                /*
                00007FFAC4D19D12  mov         rcx,7FFB1F8A3368h  
                00007FFAC4D19D1C  call        00007FFB244AFFB0  
                00007FFAC4D19D21  mov         r12,rax  
                00007FFAC4D19D24  mov         rcx,rbp  
                00007FFAC4D19D27  mov         r11,7FFAC4BD0D70h  
                00007FFAC4D19D31  cmp         dword ptr [rcx],ecx  
                00007FFAC4D19D33  call        qword ptr [00007FFAC4BD0D70h]  
                00007FFAC4D19D39  mov         rcx,rax  
                00007FFAC4D19D3C  xor         edx,edx  
                00007FFAC4D19D3E  mov         dword ptr [r12+8],edx  
                00007FFAC4D19D43  mov         rdx,r12  
                00007FFAC4D19D46  mov         r11,7FFAC4BD0D78h  
                00007FFAC4D19D50  cmp         dword ptr [rcx],ecx  
                00007FFAC4D19D52  call        qword ptr [00007FFAC4BD0D78h]  
                00007FFAC4D19D58  mov         rcx,rax  
                00007FFAC4D19D5B  mov         r11,7FFAC4BD0D80h  
                00007FFAC4D19D65  cmp         dword ptr [rcx],ecx  
                00007FFAC4D19D67  call        qword ptr [00007FFAC4BD0D80h]  
                ///--> plantage deplacement car Recordset2 est null (EOF|BOF=true) car le # du client n'existe pas
                00007FFAC4D19D6D  mov         r12,rax  
                00007FFAC4D19D70  xor         r13d,r13d  
                00007FFAC4D19D73  mov         rcx,21B900012F8h  
                00007FFAC4D19D7D  mov         rax,qword ptr [rcx]  
                00007FFAC4D19D80  mov         qword ptr [rsp+50h],rax  
                00007FFAC4D19D85  mov         rcx,7FFAF7070D78h  
                00007FFAC4D19D8F  call        00007FFB244AFFB0  
                00007FFAC4D19D94  mov         qword ptr [rsp+00000000000000F0h],rax  
                00007FFAC4D19D9C  mov         r8,21B90037B90h  
                00007FFAC4D19DA6  mov         rdx,qword ptr [r8]  
                00007FFAC4D19DA9  lea         r8,[rsp+0000000000000120h]  
                00007FFAC4D19DB1  mov         qword ptr [r8],r12  
                00007FFAC4D19DB4  mov         qword ptr [r8+8],r13  
                00007FFAC4D19DB8  mov         qword ptr [r8+10h],r13  
                00007FFAC4D19DBC  mov         r12,qword ptr [rsp+50h]  
                00007FFAC4D19DC1  mov         qword ptr [r8+18h],r12  
                00007FFAC4D19DC5  lea         r8,[rsp+0000000000000120h]  
                00007FFAC4D19DCD  xor         ecx,ecx  
                00007FFAC4D19DCF  call        00007FFB1FDBD870  
                00007FFAC4D19DD4  xor         edx,edx  
                00007FFAC4D19DD6  mov         r12,qword ptr [rsp+00000000000000F0h]  
                00007FFAC4D19DDE  mov         qword ptr [r12+8],rdx  */
               if(!rd1.EOF)
                {
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, $"{rd1.Fields[0].Value}"));
                }
                else
                {
                    itm.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, "Client invalide"));
                }
                itm.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, $"{rd.Fields["Type"].Value}"));
                itm.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, $"{rd.Fields["Commentaire"].Value}"));
                itm.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, $"{rd.Fields["NbreKM"].Value}"));
                itm.SubItems.Insert(8, new ListViewItem.ListViewSubItem(null, $"{rd.Fields["IDPunch"].Value}"));
                rd1.Close();
                rd1 = null;
                // injection et split jour semanine  via champs date
                if (!(rd.Fields["Date"].Value is DBNull))
                {
                    if (rd.Fields["Date"].Value == lblJour0.Text) { itJour = lvwJourSemaine1.Items.Add(string.Empty); }
                    if (rd.Fields["Date"].Value == lblJour1.Text) { itJour = lvwJourSemaine2.Items.Add(string.Empty); }
                    if (rd.Fields["Date"].Value == lblJour2.Text) { itJour = lvwJourSemaine3.Items.Add(string.Empty); }
                    if (rd.Fields["Date"].Value == lblJour3.Text) { itJour = lvwJourSemaine4.Items.Add(string.Empty); }
                    if (rd.Fields["Date"].Value == lblJour4.Text) { itJour = lvwJourSemaine5.Items.Add(string.Empty); }
                    if (rd.Fields["Date"].Value == lblJour5.Text) { itJour = lvwJourSemaine6.Items.Add(string.Empty); }
                    if (rd.Fields["Date"].Value == lblJour6.Text) { itJour = lvwJourSemaine7.Items.Add(string.Empty); }
                    itJour.SubItems.Insert(0x00, new ListViewItem.ListViewSubItem(null, Conteneur.idInitiales.Text));
                    itJour.ForeColor = Color.Blue;
                    itJour.SubItems.Insert(0x01, new ListViewItem.ListViewSubItem(null, $"{rd.Fields["HeureDébut"].Value} - {rd.Fields["HeureFin"].Value}"));
                    itJour.SubItems.Insert(0x02, new ListViewItem.ListViewSubItem(null, $"{rd.Fields["IDPunch"].Value}"));
                    rd.MoveNext();
                }
            }
            rd.Close();
            rd = null;
            //refonte algo calcul temps semaine
            Recordset rd2 = new Recordset();
            rd2.Open($"SELECT DATEDIFF(MINUTE, HEUREDÉBUT, HEUREFIN) AS 'TOTAL' FROM PUNCH " +
                $"WHERE NOEMPLOYE='{IdNoEmploye}'   " +
                $"and date between '{m_datDebut}' and '{m_datFin}'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            Clipboard.SetText($"SELECT DATEDIFF(MINUTE, HEUREDÉBUT, HEUREFIN) AS 'TOTAL' FROM PUNCH " +
                $"WHERE NOEMPLOYE='{IdNoEmploye}'   " +
                $"and date between '{m_datDebut}' and '{m_datFin}'");
            if (!rd2.EOF)
            {
                if (!(rd2.Fields[0].Value is DBNull)) /// patch si heure de fin = null
                {
                    temps = double.Parse($"{rd2.Fields[0].Value}");
                }
            }
            lblNbreHeure.Text = Math.Round(temps / 60, 2).ToString();
        }
        private void lvwJour_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (lvwJour.Items.Count > 0)
                {
                    if (lvwJour.FocusedItem.ForeColor == COLOR_ROUGE)
                    {
                        cmdModifierPunchIn.Enabled = true;
                        cmdModifierPunchOut.Enabled = false;
                    }
                    else
                    {
                        cmdModifierPunchIn.Enabled = true;
                        cmdModifierPunchOut.Enabled = true;
                    }
                }
                else
                {
                    cmdModifierPunchIn.Enabled = false;
                    cmdModifierPunchOut.Enabled = false;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "lvwJour_Click", ex);
            }
        }
        private void lvwJour_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            try
            {
                if (lvwJour.Items.Count > 0)
                {
                    if (eventArgs.KeyCode == Keys.Delete)
                    {
                        if (MessageBox.Show("Voulez-vous vraiment effacer ce punch ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            EffacerPunch();
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "lvwJour_KeyDown", ex);
            }
        }
        private void EffacerPunch()
        {
            try
            {
                UpdateSQL($"DELETE FROM Punch WHERE IDPunch = {(string)lvwJour.FocusedItem.Tag}");
                RemplirListViewSemaineChoisie();
                RemplirListViewSemaineAutorisation(false);
                RemplirListViewJour();
                RemplirListViewJourAutorisation();
                CalculerHeureSemaine();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "EffacerPunch", ex);
            }
        }
        private void mskHeure_GotFocus()
        {
            try
            {
                mskHeure.Mask = "##:##";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskHeure_GotFocus", ex);
            }
        }
        private void mskHeure_LostFocus()
        {
            try
            {
                mskHeure.Mask = string.Empty;
                if (mskHeure.Text == "__:__")
                {
                    mskHeure.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskHeure_LostFocus", ex);
            }
        }
        private void mskPMHeureDebut_GotFocus()
        {
            try
            {
                mskPMHeureDebut.Mask = "##:##";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskPMHeureDebut_GotFocus", ex);
            }
        }
        private void mskPMHeureDebut_LostFocus()
        {
            try
            {
                mskPMHeureDebut.Mask = string.Empty;
                if (mskPMHeureDebut.Text == "__:__")
                {
                    mskPMHeureDebut.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskPMHeureDebut_LostFocus", ex);
            }
        }
        private void mskPMHeureFin_GotFocus()
        {
            try
            {
                mskPMHeureFin.Mask = "##:##";
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskPMHeureFin_GotFocus", ex);
            }
        }
        private void mskPMHeureFin_LostFocus()
        {
            try
            {
                mskPMHeureFin.Mask = string.Empty;
                if (mskPMHeureFin.Text == "__:__")
                {
                    mskPMHeureFin.Text = string.Empty;
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskPMHeureFin_LostFocus", ex);
            }
        }
        private void mskNoProjet_Change()
        {
            try
            {
                if (fraPunch.Visible == true)
                {
                    if (Strings.InStr(1, txtNoProjet.Text, "_") == 0)
                    {
                        AfficherTypePunch();
                        AfficherClient();
                    }
                    else
                    {
                        txtClient.Text = string.Empty;
                    }
                }
                RemplirComboType();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskNoProjet_Change", ex);
            }
        }
        private void mskPMNoProjet_Change()
        {
            try
            {
                if (fraPunchMultiple.Visible == true)
                {
                    if (Strings.InStr(1, mskPMNoProjet.Text, "_") == 0)
                    {
                        AfficherTypePunch();
                        AfficherClient();
                    }
                    else
                    {
                        txtPMClient.Text = string.Empty;
                    }
                }
                RemplirComboType();
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskPMNoProjet_Change", ex);
            }
        }
        private void AfficherTypePunch()
        {
            string sNumero;
            string sType;
            bool bPM;
            try
            {
                if (fraPunchMultiple.Visible == true)
                {
                    sNumero = mskPMNoProjet.Text;
                    bPM = true;
                }
                else
                {
                    sNumero = txtNoProjet.Text;
                    bPM = false;
                }
                if ((Gauche(sNumero, 5) ?? "") == (Droite(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(DateTime.Today).ToString(), 1) + "3000" ?? ""))
                {
                    switch (Droite(sNumero, 2) ?? "")
                    {
                        case "60": { sType = "Petits outils && fourniture"; break; }
                        case "70": { sType = "Administration de la shop"; break; }
                        case "71": { sType = "Identification de fils, lamicoïdes, etc."; break; }
                        case "72": { sType = "Réception de marchandise"; break; }
                        case "73": { sType = "Support technique informatique et téléphone"; break; }
                        case "74": { sType = "Commissions"; break; }
                        case "75": { sType = "Site web && publications"; break; }
                        case "76": { sType = "Entretien && réparation de la bâtisse"; break; }
                        case "77": { sType = "Ménage général"; break; }
                        case "80": { sType = "Réparation des outils GRB"; break; }
                        case "81": { sType = "Lavage des véhicules"; break; }
                        case "82": { sType = "Entretien && réparation véhicules"; break; }
                        case "83": { sType = "Formation du personnel"; break; }
                        case "85": { sType = "Logiciel interne"; break; }
                        case "95": { sType = "Bâtiment"; break; }
                        case "97": { sType = "Équipement bureau && informatique"; break; }
                        case "99": { sType = "Équipements && outillage"; break; }
                        default: { sType = string.Empty; break; }
                    }
                    if (bPM == true){lblPMTypePunch.Text = sType;}else{lblTypePunch.Text = sType;}
                }
                else if (bPM == true){lblPMTypePunch.Text = string.Empty;}
                else{
                    lblTypePunch.Text = string.Empty;}
                return;
            }
            catch (Exception ex) { AfficherErreur("Punch", "AfficherTypePunch", ex); }
        }
        private void AfficherClient()
        {
            try
            {
                ADODB.Recordset rstProjSoum = new ADODB.Recordset();
                ADODB.Recordset rstClient = new ADODB.Recordset();
                int X;
                string sPrefixe;
                if (fraPunchMultiple.Visible == true)
                {
                    if (optPMTypePunch0.Checked == true){sPrefixe = "E";}else{sPrefixe = "M";}
                }
                else if (optTypePunch0.Checked == true){sPrefixe = "E";}
                else{sPrefixe = "M";}
                if (fraPunchMultiple.Visible == true)
                {
                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sPrefixe + mskPMNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }else{
                    rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + picTypePunch.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                }
                if (!rstProjSoum.EOF)
                {
                    rstClient.Open($"SELECT NomClient FROM Client WHERE IDClient = {rstProjSoum.Fields["NoClient"].Value}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                    if (fraPunchMultiple.Visible == true)
                    {
                        txtPMClient.Text = (string)(rstClient.Fields["NomClient"].Value);
                        txtPMClient.Tag = rstProjSoum.Fields["NoClient"].Value;
                    }
                    else
                    {
                        txtClient.Text = (string)(rstClient.Fields["NomClient"].Value);
                        idClient = rstProjSoum.Fields["NoClient"].Value;
                    }
                    rstClient.Close();
                    rstClient = null;
                    if ((bool)(rstProjSoum.Fields["Ouvert"].Value == false))
                    {
                        if (rstProjSoum.Fields["Type"].Value != "P")
                        {
                            MessageBox.Show("Ce projet est fermé!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MessageBox.Show("Cette soumission est fermée!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Numéro inexistant!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtClient.Text = "";
                    idClient = 0;
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "AfficherClient", ex);
            }
        }
// Cette procédure sert à éliminer un bug du controle Active X MonthView
// C'est un bug connu pas Microsoft et la solution suivante est proposée
// Il faut avoir une variable boolean mise à true si le MonthView prend le focus
// et ensuite, en cliquant sur un bouton, si le MonthView a le focus, on force le clique
        private void mvwSelection_Enter(object eventSender, EventArgs eventArgs)
        {
            try
            {
                m_bMonthViewHasFocus = true;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mvwSelection_GotFocus", ex);
            }
        }
        private void optHeure_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (optHeure0.Checked)
                {
                    mskHeure.Enabled = false;
                }
                else
                {
                    mskHeure.Enabled = true;
                    if (m_bModifPunch == false)
                    {
                        mskHeure.Focus();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "optHeure_Click", ex);
            }
        }
        private void lvwJourSemaine_Click(object eventSender, EventArgs eventArgs)
        {

        }
        // Pour changer un "m" en un "M" 
        private void mskNoProjet_KeyPress(ref int KeyAscii)
        {
            try
            {

                if (KeyAscii == 109) // 109 = m
                {
                    KeyAscii = (int)Keys.M; // M
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskNoProjet_KeyPress", ex);
            }
        }
        private void mskPMNoProjet_KeyPress(ref int KeyAscii)
        {
            try
            {
                if (KeyAscii == 109) // 109 = m
                {
                    KeyAscii = (int)Keys.M; // M
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mskPMNoProjet_KeyPress", ex);
            }
        }
// Enregistrement du punch in ou du punch out
        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            if (optHeure0.Checked)
            {
                DateTime dt = DateTime.Now;
                if (dt.Minute > 0 && dt.Minute < 5) { heurePunch = Droite("0" + dt.Hour.ToString(), 2) + ":00"; }
                if (dt.Minute > 5 && dt.Minute <24) { heurePunch = Droite("0" + dt.Hour.ToString(), 2) + ":15"; }
                if (dt.Minute > 24 && dt.Minute < 35) { heurePunch = Droite("0" + dt.Hour.ToString(), 2) + ":30"; }
                if (dt.Minute > 35 && dt.Minute < 54) { heurePunch = Droite("0" + dt.Hour.ToString(), 2) + ":45"; }
                if (dt.Minute > 54 ) { heurePunch = Droite("0" + dt.AddHours(1).ToString(), 2) + ":00"; }
            }
            if (optHeure1.Checked)
            {
                if (mskHeure.Text.Length == 5)
                {
                    for( int a= 0  ; a<5; a++)
                    {
                        if(mskHeure.Text[a]=='_')MessageBox.Show(mskHeure.Text+" n'est pas une entrée valide\n Vérifiez votre saisie",Application.ProductName+".Clock.GetPunchTime");
                        return;
                    }
                    int exHeure = int.Parse(mskHeure.Text.Split(':')[0]);
                    int exMinute=int.Parse(mskHeure.Text.Split(':')[1]);
                    if (exMinute > 0 && exMinute < 5) { heurePunch = mskHeure.Text.Split(':')[0] + ":00"; }
                    if (exMinute > 5 && exMinute < 24) { heurePunch = mskHeure.Text.Split(':')[0] + ":15"; }
                    if (exMinute > 24 && exMinute < 35) { heurePunch = mskHeure.Text.Split(':')[0] + ":30"; }
                    if (exMinute > 35 && exMinute < 54) { heurePunch = mskHeure.Text.Split(':')[0] + ":45"; }
                    if (exMinute > 54){ heurePunch = Droite("0" + exHeure + 1, 2) + ":00"; }
                }
            }
            try
            {
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstProjSoum;
                string sHeure;
                bool bModif;
                int X;
                string sPrefixe;
                var sType = default(string);
                string sNoProjet;
                bool bInstallation;
                var sHeureFin = default(string);
                string sNumero = txtNoProjet.Text;
                m_bMonthViewHasFocus = false;
                if (optHeure0.Checked == true)
                {
                    sHeure = DateTime.Now.Hour.ToString();
                    bModif = false;
                }
                else if (!string.IsNullOrEmpty(mskHeure.Text))
                {
                    if (Strings.InStr(1, mskHeure.Text, "_") == 0)
                    {
                        sHeure = GetHeure(mskHeure.Text);
                        bModif = true;
                    }
                    else
                    {
                        MessageBox.Show("Heure invalide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Heure invalide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (!string.IsNullOrEmpty(sHeure))
                {
                    if (m_ePunch == enumPunch.I_MODIF_PUNCH_IN | m_ePunch == enumPunch.I_PUNCH_IN)
                    {
                        if (cmbEmploye.SelectedIndex == -1)
                        {
                            MessageBox.Show("Le nom de l'employé et le numéro de projet sont des champs obligatoires!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    if (cmbType.SelectedIndex == -1 & cmbType.Visible == true)
                    {
                        MessageBox.Show("Le type est obligatoire!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }


                    if (m_ePunch == enumPunch.I_MODIF_PUNCH_IN)
                    {
                        if (!string.IsNullOrEmpty(lvwJour.FocusedItem.SubItems[I_LVW_FIN].Text))
                        {
                            if (sHeure == lvwJour.FocusedItem.SubItems[I_LVW_FIN].Text)
                            {
                                MessageBox.Show("L'heure de début doit être plus petite que l'heure de fin!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                return;
                            }
                        }
                    }


                    if (m_ePunch == enumPunch.I_MODIF_PUNCH_OUT | m_ePunch == enumPunch.I_PUNCH_OUT)
                    {
                        if (sHeure == lvwJour.FocusedItem.SubItems[I_LVW_DEBUT].Text)
                        {
                            MessageBox.Show("L'heure de fin doit être plus grande que l'heure de début!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }

                    if (m_ePunch == enumPunch.I_PUNCH_OUT | m_ePunch == enumPunch.I_MODIF_PUNCH_OUT)
                    {
                        if (chkDiner.Checked)
                        {
                            if (optHeureDiner0.Checked == true)
                            {
                                if (sHeure != "12:30")
                                {
                                    MessageBox.Show("La case à cocher 'Heure du dîner' ne peut être cochée seulement si l'heure de fin est plus grande que 12:30!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return;
                                }
                                else if (lvwJour.FocusedItem.SubItems[I_LVW_DEBUT].Text == "12:00")
                                {
                                    MessageBox.Show("La case à cocher 'Heure du dîner' ne peut être cochée seulement si l'heure de début est plus petite que 12:00!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return;
                                }
                            }
                            else if (sHeure == "13:00")
                            {
                                MessageBox.Show("La case à cocher 'Heure du dîner' ne peut être cochée seulement si l'heure de fin est plus grande que 13:00!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                return;
                            }
                            else if (lvwJour.FocusedItem.SubItems[I_LVW_DEBUT].Text == "12:00")
                            {
                                MessageBox.Show("La case à cocher 'Heure du dîner' ne peut être cochée seulement si l'heure de début est plus petite que 12:00!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                return;
                            }
                        }
                    }
                    if (optTypePunch0.Checked == true)
                    {
                        sPrefixe = "E";
                    }
                    else
                    {
                        sPrefixe = "M";
                    }
                    sNoProjet = txtNoProjet.Text;
                    if (cmbType.Visible == true)
                    {
                        if (IsNumeric(Droite(sNoProjet, 2)))
                        {
                            if (int.Parse(Droite(sNoProjet, 2)) >= 51 & int.Parse(Droite(sNoProjet, 2)) <= 59)
                            {
                                bInstallation = true;
                            }
                            else
                            {
                                bInstallation = false;
                            }
                        }
                        else
                        {
                            bInstallation = false;
                        }
                        if (bInstallation == true)
                        {
                            if (sPrefixe == "E")
                            {
                                switch (cmbType.SelectedIndex)
                                {
                                    case I_TYPE_ELEC_INSTALLATION:
                                        {
                                            sType = "Installation";
                                            break;
                                        }
                                    case I_TYPE_ELEC_MISE_SERVICE:
                                        {
                                            sType = "MiseService";
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                switch (cmbType.SelectedIndex)
                                {
                                    case I_TYPE_MEC_INSTALLATION:
                                        {
                                            sType = "Installation";
                                            break;
                                        }
                                }
                            }
                        }
                        else if (sPrefixe == "E")
                        {
                            sType = cmbType.Text;
                        }
                        else
                        {
                            sType = cmbType.Text;
                        }
                    }
                    if (m_ePunch == enumPunch.I_MODIF_PUNCH_IN | m_ePunch == enumPunch.I_PUNCH_IN)
                    {
                        rstProjSoum = new Recordset();
                        rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + picTypePunch.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        if (!rstProjSoum.EOF)
                        {
                            if (!string.IsNullOrEmpty(picTypePunch.Text))
                            {
                                if ((bool)rstProjSoum.Fields["Ouvert"].Value != true)
                                {
                                    if (rstProjSoum.Fields["Type"].Value == "P")
                                    {
                                        MessageBox.Show("Ce projet est fermé!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cette soumission est fermée!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    }
                                    rstProjSoum.Close();
                                    rstProjSoum = null;
                                    return;
                                }
                                else 
                                {
                                    ADODB.Recordset rdPunch = new ADODB.Recordset();
                                    rdPunch.Open("select top(1) Idpunch FROM [DBO].[Punch] order by IDPunch desc", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
                                    if (!rdPunch.EOF)
                                    {
                                       idPunch=(int) rdPunch.Fields["IDPunch"].Value;
                                    }
                                    rdPunch.Close();
                                    idPunch++;
                                    object sortie;
                                    string sql = "INSERT INTO [DBO].[PUNCH]([IDPUNCH],[NOEMPLOYE],[NOPROJET],[DATE],[HEUREDÉBUT],[MODIFFIN],[HEUREFIN],[COMMENTAIRE],[FACTURÉ],[NOFACTURE],[NOCLIENT],[KM],[NBREKM],[TYPE])VALUES(";
                                    sql += $"'{idPunch}','{IdNoEmploye}','{picTypePunch.Text}','{ConvertToUSDate(DateTime.Today)}','{heurePunch}','{0}'," +
                                        $"'','{txtCommentaires.Text}','{0}','','{idClient}','{chkKM.Checked}','{txtKM.Text}','{cmbType.Text}')";
                                    Clipboard.SetText(sql);
                                    odbc.Execute(sql, out sortie, -1);
                                    if (int.Parse(sortie.ToString()) > 0)
                                    {
                                        Conteneur.txtStatus.Text = $"Votre punch a été enregistré sous le numéro: {idPunch} ";
                                        ListViewItem item = lvwJourSemaine.Items.Add(string.Empty);
                                        item.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Conteneur.idInitiales.Text));
                                        item.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, heurePunch + "-"));
                                        item.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, idPunch.ToString()));
                                        item.SubItems[2].BackColor = COLOR_BRUN;
                                        ListViewItem itJour = lvwJour.Items.Add(string.Empty);
                                        itJour.SubItems.Insert(0, new ListViewItem.ListViewSubItem(null, Conteneur.idInitiales.Text));
                                        itJour.SubItems.Insert(1, new ListViewItem.ListViewSubItem(null, idProjet));
                                        itJour.SubItems.Insert(2, new ListViewItem.ListViewSubItem(null, heurePunch));
                                        itJour.SubItems.Insert(3, new ListViewItem.ListViewSubItem(null, string.Empty));
                                        itJour.SubItems.Insert(4, new ListViewItem.ListViewSubItem(null, txtClient.Text));
                                        itJour.SubItems.Insert(5, new ListViewItem.ListViewSubItem(null, cmbType.Text));
                                        itJour.SubItems.Insert(6, new ListViewItem.ListViewSubItem(null, txtCommentaires.Text));
                                        itJour.SubItems.Insert(7, new ListViewItem.ListViewSubItem(null, txtKM.Text));
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Le client ne doit pas être vide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                rstProjSoum.Close();
                                rstProjSoum = null;
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Numéro inexistant!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            rstProjSoum.Close();
                            rstProjSoum = null;
                            return;
                        }
                        rstProjSoum.Close();
                        rstProjSoum = null;
                    }
                    if (string.IsNullOrEmpty(Strings.Trim(txtCommentaires.Text)))
                    {
                        MessageBox.Show("Le commentaire est obligatoire!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    rstPunch = new Recordset();
                    switch (m_ePunch)
                    {
                        case enumPunch.I_PUNCH_IN:
                            {
                                rstPunch.Open($"  SELECT *,[DBO].[EMPLOYÉS].EMPLOYE FROM PUNCH" +
                                    $" JOIN [DBO].[EMPLOYÉS] ON PUNCH.NOEMPLOYE=[DBO].[EMPLOYÉS].NOEMPLOYE" +
                                    $" WHERE EMPLOYE ='{cmbEmploye.Text}'  AND DATE = '{ConvertDate(m_datDateChoisie)}'" +
                                    $" ORDER BY DATE,HEUREDÉBUT", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (!rstPunch.EOF)
                                {
                                    idEmployePunch = (int)rstPunch.Fields["noEmploye"].Value;
                                    rstPunch.MoveLast();
                                    if (!(rstPunch.Fields["HeureFin"].Value is DBNull))
                                    {
                                        rstPunch.Fields["ModifFin"].Value = bModif;
                                        rstPunch.Fields["HeureFin"].Value = sHeure;
                                        rstPunch.Update();
                                    }
                                }
                                rstPunch.AddNew();
                                rstPunch.Fields["idpunch"].Value = idPunch;
                                rstPunch.Fields["NoEmploye"].Value = idEmployePunch;
                                rstPunch.Fields["NoProjet"].Value = idProjet;
                                rstPunch.Fields["Date"].Value = ConvertToUSDate(DateTime.Today);
                                rstPunch.Fields["ModifDébut"].Value = bModif;
                                rstPunch.Fields["HeureDébut"].Value = sHeure;
                                rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                                rstPunch.Fields["NoClient"].Value = idClient;
                                if (chkKM.Checked)
                                {
                                    rstPunch.Fields["KM"].Value = true;
                                    if (!string.IsNullOrEmpty(txtKM.Text))
                                    {
                                        txtKM.Text = Strings.Replace(txtKM.Text, ".", ",");
                                        if (IsNumeric(txtKM.Text))
                                        {
                                            rstPunch.Fields["NbreKM"].Value = txtKM.Text;
                                        }
                                        else
                                        {
                                            rstPunch.Fields["NbreKM"].Value = 0;
                                        }
                                    }
                                    else
                                    {
                                        rstPunch.Fields["KM"].Value = false;
                                        rstPunch.Fields["NbreKM"].Value = "";
                                    }
                                }
                                else
                                {
                                    rstPunch.Fields["KM"].Value = false;
                                    rstPunch.Fields["NbreKM"].Value = "";
                                }
                                if (sNumero.Substring(2, 1) == "1")
                                {
                                    rstPunch.Fields["Type"].Value = "Soumission";
                                }
                                else
                                {
                                    rstPunch.Fields["Type"].Value = sType;
                                }
                                rstPunch.Update();
                                rstPunch.Close();
                                break;
                            }
                        case enumPunch.I_PUNCH_OUT:
                            {

                                if (lvwJour.FocusedItem.ForeColor == COLOR_ROUGE)
                                {

                                    rstPunch.Open($"SELECT * FROM Punch WHERE IDPunch = {lvwJour.FocusedItem.Tag}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                    if (chkDiner.Checked)
                                    {
                                        rstPunch.Fields["ModifFin"].Value = false;
                                        rstPunch.Fields["HeureFin"].Value = "12:00";
                                    }
                                    else
                                    {
                                        rstPunch.Fields["ModifFin"].Value = bModif;
                                        rstPunch.Fields["HeureFin"].Value = sHeure;
                                    }
                                    rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                                    if (chkKM.Checked)
                                    {
                                        rstPunch.Fields["KM"].Value = true;
                                        if (!string.IsNullOrEmpty(txtKM.Text))
                                        {
                                            txtKM.Text = Strings.Replace(txtKM.Text, ".", ",");
                                            if (IsNumeric(txtKM.Text))
                                            {
                                                rstPunch.Fields["NbreKM"].Value = txtKM.Text;
                                            }
                                            else
                                            {
                                                rstPunch.Fields["NbreKM"].Value = 0;
                                            }
                                        }
                                        else
                                        {
                                            rstPunch.Fields["KM"].Value = false;
                                            rstPunch.Fields["NbreKM"].Value = "";
                                        }
                                    }
                                    else
                                    {
                                        rstPunch.Fields["KM"].Value = false;
                                        rstPunch.Fields["NbreKM"].Value = "";
                                    }
                                    if (sNumero.Substring(2, 1) == "1")
                                    {
                                        rstPunch.Fields["Type"].Value = "Soumission";
                                    }
                                    else
                                    {
                                        rstPunch.Fields["Type"].Value = sType;
                                    }
                                    rstPunch.Update();
                                    if (chkDiner.Checked)
                                    {
                                        rstPunch.AddNew();
                                        rstPunch.Fields["NoEmploye"].Value = idEmployePunch;
                                        rstPunch.Fields["idpunch"].Value = idPunch;
                                        rstPunch.Fields["NoProjet"].Value = idProjet;
                                        rstPunch.Fields["Date"].Value = ConvertDate(DateTime.Today);
                                        rstPunch.Fields["ModifDébut"].Value = false;
                                        if (optHeureDiner0.Checked == true)
                                        {
                                            rstPunch.Fields["HeureDébut"].Value = "12:30";
                                        }
                                        else
                                        {
                                            rstPunch.Fields["HeureDébut"].Value = "13:00";
                                        }
                                        rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                                        rstPunch.Fields["NoClient"].Value = idClient;
                                        rstPunch.Fields["ModifFin"].Value = bModif;
                                        rstPunch.Fields["HeureFin"].Value = sHeure;
                                        if (sNumero.Substring(2, 1) == "1")
                                        {
                                            rstPunch.Fields["Type"].Value = "Soumission";
                                        }
                                        else
                                        {
                                            rstPunch.Fields["Type"].Value = sType;
                                        }
                                        rstPunch.Update();
                                    }
                                    rstPunch.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Le punch out a déjà été fait!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                break;
                            }
                        case enumPunch.I_MODIF_PUNCH_IN:
                            {

                                rstPunch.Open($"SELECT * FROM Punch WHERE IDPunch = {lvwJour.FocusedItem.Tag}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                rstPunch.Fields["idpunch"].Value = idPunch;
                                rstPunch.Fields["NoEmploye"].Value = idEmployePunch;
                                rstPunch.Fields["NoProjet"].Value = idProjet;
                                rstPunch.Fields["NoClient"].Value = idClient;
                                rstPunch.Fields["Date"].Value = ConvertToUSDate(DateTime.Today);
                                if (bModif == true)
                                {
                                    if (rstPunch.Fields["HeureDébut"].Value == sHeure)
                                    {
                                        rstPunch.Fields["ModifDébut"].Value = true;
                                    }
                                    else
                                    {
                                        rstPunch.Fields["ModifDébut"].Value = false;
                                    }
                                }
                                else
                                {
                                    rstPunch.Fields["ModifDébut"].Value = false;
                                }
                                rstPunch.Fields["HeureDébut"].Value = sHeure;
                                rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                                if (chkKM.Checked)
                                {
                                    rstPunch.Fields["KM"].Value = true;
                                    if (!string.IsNullOrEmpty(txtKM.Text))
                                    {
                                        txtKM.Text = Strings.Replace(txtKM.Text, ".", ",");
                                        if (IsNumeric(txtKM.Text))
                                        {
                                            rstPunch.Fields["NbreKM"].Value = txtKM.Text;
                                        }
                                        else
                                        {
                                            rstPunch.Fields["NbreKM"].Value = 0;
                                        }
                                    }
                                    else
                                    {
                                        rstPunch.Fields["KM"].Value = false;
                                        rstPunch.Fields["NbreKM"].Value = 0;
                                    }
                                }
                                else
                                {
                                    rstPunch.Fields["KM"].Value = false;
                                    rstPunch.Fields["NbreKM"].Value = "";
                                }
                                if (sNumero.Substring(2, 1) == "1")
                                {
                                    rstPunch.Fields["Type"].Value = "Soumission";
                                }
                                else
                                {
                                    rstPunch.Fields["Type"].Value = sType;
                                }
                                rstPunch.Update();
                                rstPunch.Close();
                                break;
                            }

                        case enumPunch.I_MODIF_PUNCH_OUT:
                            {

                                rstPunch.Open($"SELECT * FROM Punch WHERE IDPunch = {(int)lvwJour.FocusedItem.Tag}", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                                if (chkDiner.Checked)
                                {
                                    sHeureFin = (string)(rstPunch.Fields["HeureFin"].Value);
                                    rstPunch.Fields["ModifFin"].Value = false;
                                    rstPunch.Fields["HeureFin"].Value = "12:00";
                                }
                                else
                                {
                                    if (bModif == true)
                                    {
                                        if (rstPunch.Fields["HeureFin"].Value != sHeure)
                                        {
                                            rstPunch.Fields["ModifFin"].Value = true;
                                        }
                                        else
                                        {
                                            rstPunch.Fields["ModifFin"].Value = false;
                                        }
                                    }
                                    else
                                    {
                                        rstPunch.Fields["ModifFin"].Value = false;
                                    }
                                    rstPunch.Fields["HeureFin"].Value = sHeure;
                                }
                                rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                                if (chkKM.Checked)
                                {
                                    rstPunch.Fields["KM"].Value = true;
                                    if (!string.IsNullOrEmpty(txtKM.Text))
                                    {
                                        txtKM.Text = Strings.Replace(txtKM.Text, ".", ",");
                                        if (IsNumeric(txtKM.Text))
                                        {
                                            rstPunch.Fields["NbreKM"].Value = txtKM.Text;
                                        }
                                        else
                                        {
                                            rstPunch.Fields["NbreKM"].Value = 0;
                                        }
                                    }
                                    else
                                    {
                                        rstPunch.Fields["KM"].Value = false;
                                        rstPunch.Fields["NbreKM"].Value = "";
                                    }
                                }
                                else
                                {
                                    rstPunch.Fields["KM"].Value = false;
                                    rstPunch.Fields["NbreKM"].Value = "";
                                }
                                if (sNumero.Substring(2, 1) == "1")
                                {
                                    rstPunch.Fields["Type"].Value = "Soumission";
                                }
                                else
                                {
                                    rstPunch.Fields["Type"].Value = sType;
                                }
                                rstPunch.Update();
                                if (chkDiner.Checked)
                                {
                                    rstPunch.AddNew();
                                    rstPunch.Fields["idpunch"].Value = idPunch;
                                    rstPunch.Fields["NoEmploye"].Value = idEmployePunch;
                                    rstPunch.Fields["NoProjet"].Value = idProjet;
                                    rstPunch.Fields["Date"].Value = ConvertToUSDate(DateTime.Today);
                                    rstPunch.Fields["ModifDébut"].Value = false;
                                    if (optHeureDiner0.Checked == true)
                                    {
                                        rstPunch.Fields["HeureDébut"].Value = "12:30";
                                    }
                                    else
                                    {
                                        rstPunch.Fields["HeureDébut"].Value = "13:00";
                                    }
                                    rstPunch.Fields["Commentaire"].Value = txtCommentaires.Text;
                                    rstPunch.Fields["NoClient"].Value = idClient;
                                    if (bModif == true)
                                    {
                                        if (rstPunch.Fields["HeureFin"].Value != sHeureFin)
                                        {
                                            rstPunch.Fields["ModifFin"].Value = true;
                                        }
                                        else
                                        {
                                            rstPunch.Fields["ModifFin"].Value = false;
                                        }
                                    }
                                    else
                                    {
                                        rstPunch.Fields["ModifFin"].Value = false;
                                    }
                                    rstPunch.Fields["HeureFin"].Value = sHeure;
                                    rstPunch.Fields["Type"].Value = sType;
                                    rstPunch.Update();
                                }
                                rstPunch.Close();
                                break;
                            }
                    }
                    rstPunch = null;
                    RemplirListViewSemaineChoisie();
                    RemplirListViewSemaineAutorisation(true);
                    RemplirListViewJour();
                    RemplirListViewJourAutorisation();
                    CalculerHeureSemaine();
                }
                fraJour.Visible = true;
                fraPunch.Visible = false;
                fraPunchMultiple.Visible = false;

                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdOK_Click", ex);
            }
        }
                // Enregistrement du punch in ou du punch out
        private void cmdPMOK_Click(object eventSender, EventArgs eventArgs)
        {
            try
            {
                ADODB.Recordset rstPunch;
                ADODB.Recordset rstProjSoum;
                string sHeureDebut;
                string sHeureFin;
                int X;
                var bSelect = default(bool);
                string sPrefixe;
                var sType = default(string);
                bool bInstallation;
                m_bMonthViewHasFocus = false;
                if (!string.IsNullOrEmpty(mskPMHeureDebut.Text))
                {
                    if (Strings.InStr(1, mskPMHeureDebut.Text, "_") == 0)
                    {
                        sHeureDebut = GetHeure(mskPMHeureDebut.Text);
                    }
                    else
                    {
                        MessageBox.Show("Heure de début invalide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Heure de début invalide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (!string.IsNullOrEmpty(mskPMHeureFin.Text))
                {
                    if (Strings.InStr(1, mskPMHeureFin.Text, "_") == 0)
                    {
                        sHeureFin = GetHeure(mskPMHeureFin.Text);
                    }
                    else
                    {
                        MessageBox.Show("Heure de fin invalide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Heure de fin invalide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (cmbPMType.SelectedIndex == -1 & cmbPMType.Visible == true)
                {
                    MessageBox.Show("Le type est obligatoire!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                var loopTo = (int)lvwEmployes.Items.Count;
                for (X = 1; X <= loopTo; X++)
                {
                    if (lvwEmployes.Items[X].Checked == true)
                    {
                        bSelect = true;
                        break;
                    }
                }
                if (bSelect == false)
                {
                    MessageBox.Show("Vous devez choisir au moins 1 employé!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (Strings.InStr(1, mskPMNoProjet.Text, "_") > 0)
                {
                    MessageBox.Show("Le numéro de projet est obligatoire!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                if (int.Parse(sHeureDebut.Substring(0, 2)) >= int.Parse(sHeureFin.Substring(0, 2)))
                {
                    MessageBox.Show("L'heure de début doit être plus petite que l'heure de fin!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                if (chkPMDiner.Checked)
                {
                    if (optPMHeureDiner0.Checked == true)
                    {
                        if ((sHeureDebut == "12:00") | (sHeureFin == "12:30"))
                        {
                            MessageBox.Show("La case à cocher 'Heure du dîner' ne peut être cochée que si l'heure de début est plus petite que 12:00" + "\n" + " ou que l'heure de fin est plus grande que 12:30!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    else if (sHeureDebut == "12:00" | sHeureFin == "13:00")
                    {
                        MessageBox.Show("La case à cocher 'Heure du dîner' ne peut être cochée que si l'heure de début est plus petite que 12:00" + "\n" + " ou que l'heure de fin est plus grande que 13:00!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }
                if (optPMTypePunch0.Checked == true)
                {
                    sPrefixe = "E";
                }
                else
                {
                    sPrefixe = "M";
                }
                if (cmbPMType.Visible == true)
                {
                    if (IsNumeric(Droite(mskPMNoProjet.Text, 2)))
                    {
                        if (int.Parse(Droite(mskPMNoProjet.Text, 2)) >= 51 & int.Parse(Droite(mskPMNoProjet.Text, 2)) <= 59)
                        {
                            bInstallation = true;
                        }
                        else
                        {
                            bInstallation = false;
                        }
                    }
                    else
                    {
                        bInstallation = false;
                    }
                    if (bInstallation == true)
                    {
                        if (sPrefixe == "E")
                        {
                            switch (cmbPMType.SelectedIndex)
                            {
                                case I_TYPE_ELEC_INSTALLATION:
                                    {
                                        sType = "Installation";
                                        break;
                                    }
                                case I_TYPE_ELEC_MISE_SERVICE:
                                    {
                                        sType = "Formation";
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            switch (cmbPMType.SelectedIndex)
                            {
                                case I_TYPE_MEC_INSTALLATION:
                                    {
                                        sType = "Installation";
                                        break;
                                    }
                            }
                        }
                    }
                    else if (sPrefixe == "E")
                    {
                        sType = cmbPMType.Text;
                    }
                    else
                    {
                        sType = cmbPMType.Text;
                    }
                }
                rstProjSoum = new Recordset();
                rstProjSoum.Open("SELECT * FROM ProjSoum WHERE IDProjSoum = '" + sPrefixe + mskPMNoProjet.Text + "'", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                if (!rstProjSoum.EOF)
                {
                    if (!string.IsNullOrEmpty(txtPMClient.Text))
                    {
                        if ((bool)rstProjSoum.Fields["Ouvert"].Value == true)
                        {
                            if (rstProjSoum.Fields["Type"].Value == "P")
                            {
                                MessageBox.Show("Ce projet est fermé!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            else
                            {
                                MessageBox.Show("Cette soumission est fermée!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            rstProjSoum.Close();
                            rstProjSoum = null;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le client ne doit pas être vide!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        rstProjSoum.Close();
                        rstProjSoum = null;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Numéro inexistant!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    rstProjSoum.Close();
                    rstProjSoum = null;
                    return;
                }
                rstProjSoum.Close();
                rstProjSoum = null;
                if (string.IsNullOrEmpty(Strings.Trim(txtPMCommentaire.Text)))
                {
                    MessageBox.Show("Le commentaire est obligatoire!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                rstPunch = new Recordset();
                var loopTo1 = (int)lvwEmployes.Items.Count;
                for (X = 1; X <= loopTo1; X++)
                {
                    if (lvwEmployes.Items[X].Checked == true)
                    {
                        rstPunch.Open("SELECT * FROM Punch", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic);
                        rstPunch.AddNew();
                        rstPunch.Fields["NoEmploye"].Value = lvwEmployes.Items[X].Tag;
                        rstPunch.Fields["NoProjet"].Value =idProjet;
                        rstPunch.Fields["Date"].Value = ConvertToUSDate(DateTime.Today);
                        rstPunch.Fields["ModifDébut"].Value = false;
                        rstPunch.Fields["HeureDébut"].Value = sHeureDebut;
                        rstPunch.Fields["ModifFin"].Value = false;
                        if (chkPMDiner.Checked)
                        {
                            rstPunch.Fields["HeureFin"].Value = "12:00";
                        }
                        else
                        {
                            rstPunch.Fields["HeureFin"].Value = sHeureFin;
                        }
                        rstPunch.Fields["Commentaire"].Value = txtPMCommentaire.Text;
                        rstPunch.Fields["NoClient"].Value = idClient;
                        rstPunch.Fields["KM"].Value = false;
                        rstPunch.Fields["NbreKM"].Value = "";
                        rstPunch.Fields["Type"].Value = sType;
                        rstPunch.Update();
                        if (chkPMDiner.Checked)
                        {
                            rstPunch.AddNew();
                            rstPunch.Fields["NoEmploye"].Value = lvwEmployes.Items[X].Tag;
                            rstPunch.Fields["NoProjet"].Value = sPrefixe + mskPMNoProjet.Text;
                            rstPunch.Fields["Date"].Value = ConvertToUSDate(DateTime.Today);
                            rstPunch.Fields["ModifDébut"].Value = false;
                            if (optPMHeureDiner0.Checked == true)
                            {
                                rstPunch.Fields["HeureDébut"].Value = "12:30";
                            }
                            else
                            {
                                rstPunch.Fields["HeureDébut"].Value = "13:00";
                            }
                            rstPunch.Fields["Commentaire"].Value = txtPMCommentaire.Text;
                            rstPunch.Fields["NoClient"].Value = idClient;
                            rstPunch.Fields["ModifFin"].Value = false;
                            rstPunch.Fields["HeureFin"].Value = sHeureFin;
                            rstPunch.Fields["Type"].Value = sType;
                            rstPunch.Update();
                        }
                        rstPunch.Update();
                        rstPunch.Close();
                    }
                }
                rstPunch = null;
                fraPunch.Visible = false;
                RemplirListViewSemaineAutorisation(true);
                RemplirListViewJour();
                RemplirListViewJourAutorisation();
                CalculerHeureSemaine();
                fraJour.Visible = true;
                fraPunchMultiple.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "cmdPMOK_Click", ex);
            }
        }
        private string GetHeure(string sHeure)
        {
            string GetHeureRet = default;
            try
            {
                DateTime datHeure;
                bool b24Heure;
                if (IsNumeric(Gauche(sHeure, 2)) & IsNumeric(sHeure.Substring(4, 2)))
                {
                    if (int.Parse(Gauche(sHeure, 2)) < 0 | int.Parse(Gauche(sHeure, 2)) > 24 | int.Parse(sHeure.Substring(4, 2)) < 0 | int.Parse(sHeure.Substring(4, 2)) > 59)
                    {
                        MessageBox.Show("Heure incorrecte!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return GetHeureRet;
                    }
                }
                else
                {
                    MessageBox.Show("Heure incorrecte!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return GetHeureRet;
                }
                sHeure = sHeure.Replace("AM", "");
                if (sHeure.Contains("PM"))
                {
                    sHeure = sHeure.Replace("PM", "").Trim();
                    sHeure = int.Parse(Gauche(sHeure, 2)) + 12 + Droite(sHeure, sHeure.Length - 2);
                    b24Heure = true;
                }
                sHeure = Gauche(sHeure, 5);
                if (Gauche(sHeure, 2) != "24")
                {
                    datHeure = DateTime.FromOADate(int.Parse(Gauche(sHeure, 2)));
                    if (datHeure.Minute <= 5) { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 0, 0); }
                    else
                    if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datHeure) <= 24) { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 15, 0); }
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datHeure) <= 35) { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 30, 0); }
                    else if (System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datHeure) <= 54) { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 45, 0); }
                    else { datHeure = DateAndTime.TimeSerial(System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure) + 1, 0, 0); }
                    GetHeureRet = Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetHour(datHeure), 2) + ":" + Droite("0" + System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetMinute(datHeure), 2);
                }
                else
                {
                    GetHeureRet = sHeure;
                }
                return GetHeureRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "GetHeure", ex); return GetHeureRet;
            }
        }
        private void optHeure_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    if (optHeure0.Checked == false){ optHeure0.Checked = true;}
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "optHeure_MouseUp", ex);
            }
        }
        private void optTypePunch_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (optTypePunch0.Checked)
                {
                    if (Strings.InStr(1, txtNoProjet.Text, "_") == 0)
                    {
                        AfficherTypePunch();
                        AfficherClient();
                    }
                    if (fraPunch.Visible == true)
                    {
                        txtNoProjet.Focus();
                    }
                    lblPrefixe.Text = "E";
                }
                else
                {
                    lblPrefixe.Text = "M";
                }
                RemplirComboType();
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "optTypePunch_Click", ex);
            }
        }
        private void optTypePunch_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    optTypePunch_CheckedChanged(eventSender, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "optTypePunch_MouseUp", ex);
            }
        }
        private void optPMTypePunch_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (Strings.InStr(1, mskPMNoProjet.Text, "_") == 0)
                {
                    AfficherTypePunch();
                    AfficherClient();
                }
                else if (fraPunchMultiple.Visible == true)
                {
                    mskPMNoProjet.Focus();
                }
                if (optPMTypePunch0.Checked)
                {
                    lblPMPrefixe.Text = "E";
                }
                else
                {
                    lblPMPrefixe.Text = "M";
                }
                RemplirComboType();
                m_bMonthViewHasFocus = false;
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "optPMTypePunch_Click", ex);
            }
        }
        private void RemplirComboType()
        {
            bool bInstallation;
            string sType = "";
            string sNumero = string.Empty;
            cmbType.Items.Clear();
            ADODB.Recordset sq = new ADODB.Recordset();

            sq.Open($"SELECT DISTINCT [NAME]  FROM [DBO].[TBL_PUNCH_TYPE] WHERE MODE = '{lblPrefixe.Text}' ORDER BY NAME", odbc, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic, -1);
            while (!sq.EOF)
            {
                cmbType.Items.Add(sq.Fields[0].Value);
            }
            if (fraPunchMultiple.Visible == true)
            {
                txtPMCommentaire.Text = txtCommentaires.Text;
                txtPMCommentaire.Enabled = false;
                txtPMClient.Text = txtClient.Text;
                txtPMClient.Enabled = false;
                lblPMPrefixe.Text = lblPrefixe.Text;
                sType = lblPrefixe.Text;
                sNumero = mskPMNoProjet.Text;
            }
            if (int.Parse(Droite(sNumero, 2)) >= 0x33 & int.Parse(Droite(sNumero, 2)) <= 0x3B) { bInstallation = true; } else { bInstallation = false; }
            if (sType == "E") { cmbType.Items.Add("Mise en service"); }
            if (bInstallation == true) { cmbType.Items.Add("Installation"); }
            else
            if (sType == "E")
            {
                while (!sq.EOF)
                {
                    cmbType.Items.Add(sq.Fields["name"].Value);
                }
            }
            sq.Close();
        }
        private void optPMTypePunch_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            try
            {
                if (m_bMonthViewHasFocus == true)
                {
                    optPMTypePunch_CheckedChanged(eventSender, new EventArgs());
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "optPMTypePunch_MouseUp", ex);
            }
        }
        private void txtKM_Leave(object eventSender, EventArgs eventArgs)
        {
            try
            {
                txtKM.Text = Strings.Replace(txtKM.Text, ".", ",");
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "txtKM_LostFocus", ex);
            }
        }
        private void mvwSelection_SelChange(object eventSender, EventArgs eventArgs)
        {
            try
            {
                if (m_datDateChoisie.Month != mvwSelection.Value.Month | m_datDateChoisie.Year != mvwSelection.Value.Year | m_datDateChoisie.Day != mvwSelection.Value.Day)
                {
                    AfficherDate();
                    CalculerHeureSemaine();
                }
                return;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "mvwSelection_SelChange", ex);
            }
        }
        private bool VerifierModificationDate()
        {
            bool VerifierModificationDateRet = default;
            var g_bPunchSemaineAnterieure = default(bool);
            try
            {
                var bModif = default(bool);
                DateTime datSelected;
                DateTime datToday;
                DateTime datFirstDaySelected;
                DateTime datFirstDayToday;
                datSelected = mvwSelection.Value;
                datToday = DateTime.Today;
                datFirstDaySelected = GetFirstDay(datSelected);
                datFirstDayToday = GetFirstDay(datToday);
                if (!g_bPunchSemaineAnterieure)
                {
                    if (datSelected != datToday)
                    {
                        if (datToday.DayOfWeek == DayOfWeek.Sunday | datToday.DayOfWeek == DayOfWeek.Monday)
                        {
                            if (datFirstDaySelected == datFirstDayToday | DateAndTime.DateDiff(DateInterval.Day, datFirstDaySelected, datFirstDayToday) == 7L)
                            {
                                bModif = true;
                            }
                            else
                            {
                                bModif = false;
                            }
                        }
                        else if (datFirstDaySelected == datFirstDayToday)
                        {
                            bModif = true;
                        }
                    }
                    else
                    {
                        bModif = true;
                    }
                }
                else
                {
                    bModif = true;
                }
                if (bModif == false)
                {
                    MessageBox.Show("Impossible de modifier les punchs de cette journée!", Application.ProductName + ".Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                VerifierModificationDateRet = bModif;
                if (IdGroupe == 27) return true;
                return VerifierModificationDateRet;
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "VerifierModificationDate", ex);
                return false;
            }
        }
        public void Table_exist()
        {
            ADOX.Catalog adoxconnection = new ADOX.Catalog();
            int i;
            adoxconnection.let_ActiveConnection(odbc);
            for (i = 0; i < adoxconnection.Tables.Count; i++)
            {
                if ((adoxconnection.Tables[i].Name.ToLower() ?? "") == ("TBL_Punch_Type".ToLower() ?? ""))
                {
                    adoxconnection = null;
                    return;
                }
            }
            UpdateSQL("Create TABLE TBL_Punch_Type (Mode text(1), Name Text (100))");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Dessin Électrique');"); ;
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Fabrication');"); ;
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Assemblage du Panneau');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Programmation d''interface');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Programmation d''automate');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Programmation de Robot');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Vision Artificielle');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Test Finaux');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Formation du personnel');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Gestion du projet');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Expédition');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('E','Prototypage-Dévelloppement expérimental');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Conception et dessin');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Coupe et préparation(sauf soudage)');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Machinage');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Coupe,Soudure et meulage');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Assemblage des systèmes');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Peinture et Finition');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Test Finaux');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Formation du personnel');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Gestion du projet');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Expédition');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('M','Prototypage-Dévelloppement expérimental');");
            UpdateSQL("Insert into TBL_Punch_Type (mode, Name) Values ('S','Soumission');");
            UpdateSQL("CREATE TABLE [DBO].[PunchLog]( [ID] [int] IDENTITY(1,1) NOT NULL, [Connexion] [nvarchar](50) NOT NULL, [Utilisateur] [int] NOT NULL, [Poste] [nvarchar](50) NOT NULL) ");
            adoxconnection = null;
        }
        private void mvwSelection_ValueChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = GetSemaineDelaDate(mvwSelection.Value);
            Text = $"Punch pour {cmbHeureSemaine.Text} [{toolStripStatusLabel3.Text}]";
            AfficherDate();
            ListerPunch();
        }
        private void RemplirComboTypeFromPunch()
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            try
            {
                SqlDataReader rd = new SqlCommand($"SELECT DISTINCT TYPE FROM [DBO].[PUNCH] WHERE LEFT(NOPROJET,1)='E' AND COMMENTAIRE!=''", sql).ExecuteReader();
                while (rd.Read())
                {
                    cmbType.Items.Add(rd[0].ToString());
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "RemplirComboTypeFromPunch", ex);
            }
        }
        private void ListerCommentairePunch()
        {
            cmbType.Items.Clear();
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            string cmd = $"SELECT DISTINCT COMMENTAIRE FROM [DBO].[PUNCH] " +
                $"WHERE LEFT(NOPROJET,1)='{lblPrefixe.Text}' AND COMMENTAIRE!='' " +
                $"AND UPPER(TRIM(LEFT(COMMENTAIRE,1))) BETWEEN 'A' AND 'Z' " +
                $"AND TYPE = '{cmbType.Text.Replace("'", "''")}'";
            try
            {

                if (picTypePunch.Text != string.Empty & cmbType.Text != string.Empty)
                {
                    if (MessageBox.Show("Voulez vous restreindre les commentaires aux vôtres ?", Application.ProductName + ".SQL.Punch.ChoixCommentaires", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd += $" and NoEmploye='{Program.IdNoEmploye}'";
                    }
                }
                SqlDataReader rd = new SqlCommand(cmd, sql).ExecuteReader();
                while (rd.Read())
                {
                    cmbType.Items.Add(rd[0].ToString());
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "ListerCommentairePunch", ex);
            }
        }
        private void ListerPunch()
        {
            InitialiserListView();
            SqlConnection sq = new SqlConnection(StringSQL);
            ListViewItem it = default(ListViewItem);
            ListViewItem itJour = default(ListViewItem);
            string sNum = lblPrefixe.Text + txtNoProjet.Text;
            if (sNum.Contains("-") == false & sNum.Length > 2) { sNum = sNum.Substring(0, sNum.Length - 2) + "-" + Droite(sNum, 2); }
            sq.Open();
            double temps = 0d;
            if (cmbHeureSemaine.SelectedIndex != -1)
            {
                SqlDataReader rd = new SqlCommand($"SELECT  *,[DBO].[CLIENT].[NOMCLIENT] FROM [DBO].[PUNCH] " +
                    $"JOIN [DBO].[CLIENT] ON[DBO].[CLIENT].[IDCLIENT] =[DBO].[PUNCH].[NOCLIENT]" +
                    $"WHERE NOEMPLOYE = '{Employes[cmbHeureSemaine.SelectedIndex].Noemploye}' AND DATE BETWEEN '{lblJour0.Text}' and '{lblJour6.Text}' order by Date,HeureDébut ", sq).ExecuteReader();
                while (rd.Read())
                {
                    if (rd["Date"].ToString() == lblJour0.Text) { itJour = lvwJourSemaine1.Items.Add(string.Empty); }
                    if (rd["Date"].ToString() == lblJour1.Text) { itJour = lvwJourSemaine2.Items.Add(string.Empty); }
                    if (rd["Date"].ToString() == lblJour2.Text) { itJour = lvwJourSemaine3.Items.Add(string.Empty); }
                    if (rd["Date"].ToString() == lblJour3.Text) { itJour = lvwJourSemaine4.Items.Add(string.Empty); }
                    if (rd["Date"].ToString() == lblJour4.Text) { itJour = lvwJourSemaine5.Items.Add(string.Empty); }
                    if (rd["Date"].ToString() == lblJour5.Text) { itJour = lvwJourSemaine6.Items.Add(string.Empty); }
                    if (rd["Date"].ToString() == lblJour6.Text) { itJour = lvwJourSemaine7.Items.Add(string.Empty); }
                    it = lvwJour.Items.Add(string.Empty);
                    itJour.Text = Employes[cmbHeureSemaine.SelectedIndex].Initiale;
                    if (rd["HeureFin"].ToString() != string.Empty)
                    {
                        itJour.SubItems.Insert(0x01, new ListViewItem.ListViewSubItem(null, $"{ rd["HeureDébut"].ToString()} - {rd["HeureFin"].ToString()}"));
                        itJour.ForeColor = Color.DarkBlue;
                    }
                    else
                    {
                        itJour.SubItems.Insert(0x01, new ListViewItem.ListViewSubItem(null, rd["HeureDébut"].ToString()));
                        itJour.ForeColor = COLOR_ROUGE;
                    }
                    it.Text = Employes[cmbHeureSemaine.SelectedIndex].Initiale;
                    it.SubItems.Insert(I_LVW_PROJET, new ListViewItem.ListViewSubItem(null, rd["NoProjet"].ToString()));
                    it.SubItems.Insert(I_LVW_DEBUT, new ListViewItem.ListViewSubItem(null, rd["HeureDébut"].ToString()));
                    int deb = (int.Parse(rd["HeureDébut"].ToString().Split(':')[0]) * 60) + int.Parse(rd["HeureDébut"].ToString().Split(':')[1]);
                    it.SubItems.Insert(I_LVW_FIN, new ListViewItem.ListViewSubItem(null, rd["HeureFin"].ToString()));
                    int fin = (int.Parse(rd["HeureFin"].ToString().Split(':')[0]) * 60) + int.Parse(rd["HeureFin"].ToString().Split(':')[1]);
                    it.SubItems.Insert(I_LVW_CLIENT, new ListViewItem.ListViewSubItem(null, rd["nomclient"].ToString()));
                    it.SubItems[I_LVW_CLIENT].Tag = rd["noclient"].ToString();
                    it.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, rd["type"].ToString()));
                    it.SubItems.Insert(I_LVW_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, rd["Commentaire"].ToString()));
                    it.SubItems.Insert(I_LVW_COMMENTAIRE + 1, new ListViewItem.ListViewSubItem(null, rd["date"].ToString()));
                    if ((bool)rd["km"])
                    {
                        it.SubItems.Insert(I_LVW_KM, new ListViewItem.ListViewSubItem(null, rd["NbreKM"].ToString()));
                    }
                    else
                    {
                        it.SubItems.Insert(I_LVW_KM, new ListViewItem.ListViewSubItem(null, "0"));
                    }
                    if (fin > deb) { temps += (fin - deb); }
                    lblNbreHeure.Text = Math.Round(temps / 60, 2).ToString();
                }
                rd.Close();
            }
            sq.Close();
        }
        private void ListerPunchJour(string dateSelectionnee)
        {
            lvwJour.Items.Clear();
            SqlConnection sq = new SqlConnection(StringSQL);
            ListViewItem it = default(ListViewItem);
            string sNum = lblPrefixe.Text + txtNoProjet.Text;
            if (sNum.Contains("-") == false & sNum.Length > 2) { sNum = sNum.Substring(0, sNum.Length - 2) + "-" + Droite(sNum, 2); }
            sq.Open();
            if (cmbHeureSemaine.SelectedIndex != -1)
            {
                SqlDataReader rd = new SqlCommand($"SELECT  *,[DBO].[CLIENT].[NOMCLIENT] FROM [DBO].[PUNCH] " +
                    $"JOIN [DBO].[CLIENT] ON[DBO].[CLIENT].[IDCLIENT] =[DBO].[PUNCH].[NOCLIENT]" +
                    $"WHERE NOEMPLOYE = '{Employes[cmbHeureSemaine.SelectedIndex].Noemploye}' AND DATE = '{dateSelectionnee}' order by HeureDébut ", sq).ExecuteReader();
                while (rd.Read())
                {
                    it = lvwJour.Items.Add(string.Empty);
                    it.Text = Employes[cmbHeureSemaine.SelectedIndex].Initiale;
                    it.SubItems.Insert(I_LVW_PROJET, new ListViewItem.ListViewSubItem(null, rd["NoProjet"].ToString()));
                    it.SubItems.Insert(I_LVW_DEBUT, new ListViewItem.ListViewSubItem(null, rd["HeureDébut"].ToString()));
                    it.SubItems.Insert(I_LVW_FIN, new ListViewItem.ListViewSubItem(null, rd["HeureFin"].ToString()));
                    it.SubItems.Insert(I_LVW_CLIENT, new ListViewItem.ListViewSubItem(null, rd["nomclient"].ToString()));
                    it.SubItems[I_LVW_CLIENT].Tag = rd["noclient"].ToString();
                    it.SubItems.Insert(I_LVW_TYPE, new ListViewItem.ListViewSubItem(null, rd["type"].ToString()));
                    it.SubItems.Insert(I_LVW_COMMENTAIRE, new ListViewItem.ListViewSubItem(null, rd["Commentaire"].ToString()));
                    it.SubItems.Insert(I_LVW_COMMENTAIRE + 1, new ListViewItem.ListViewSubItem(null, rd["date"].ToString()));
                    if ((bool)rd["km"])
                    {
                        it.SubItems.Insert(I_LVW_KM, new ListViewItem.ListViewSubItem(null, rd["NbreKM"].ToString()));
                    }
                    else
                    {
                        it.SubItems.Insert(I_LVW_KM, new ListViewItem.ListViewSubItem(null, "0"));
                    }
                }
                rd.Close();
            }
            sq.Close();
        }
        private void InitialiserListView()
        {
            lvwJour.Items.Clear();
            lvwJourSemaine1.Items.Clear();
            lvwJourSemaine2.Items.Clear();
            lvwJourSemaine3.Items.Clear();
            lvwJourSemaine4.Items.Clear();
            lvwJourSemaine5.Items.Clear();
            lvwJourSemaine6.Items.Clear();
            lvwJourSemaine7.Items.Clear();
            lvwJourSemaine1.BackColor = COLOR_BLANC;
            lvwJourSemaine2.BackColor = COLOR_BLANC;
            lvwJourSemaine3.BackColor = COLOR_BLANC;
            lvwJourSemaine4.BackColor = COLOR_BLANC;
            lvwJourSemaine2.BackColor = COLOR_BLANC;
            lvwJourSemaine6.BackColor = COLOR_BLANC;
            lvwJourSemaine7.BackColor = COLOR_BLANC;
        }
        private void optTypePunch0_CheckedChanged(object sender, EventArgs e) => lblPrefixe.Text = "E";
        private void optTypePunch1_CheckedChanged(object sender, EventArgs e) => lblPrefixe.Text = "M";
        private void lblPrefixe_Click(object sender, EventArgs e)
        {
            picPMTypePunch.Text = $"{lblPrefixe.Text}{txtNoProjet.Text}";
            GetClientFromProject(picTypePunch.Text);
        }
        private void txtNoProjet_TextChanged(object sender, EventArgs e)
        {
            picTypePunch.Text = $"{lblPrefixe.Text}{txtNoProjet.Text}";
            string npr = txtNoProjet.Text;
            if (npr.Length > 5 & npr.Length < 10)
            {
                npr = Gauche(txtNoProjet.Text, 5) + "-" + Droite(txtNoProjet.Text, 2);
                picTypePunch.Text = lblPrefixe.Text + npr;
                idProjet = lblPrefixe.Text + npr;
                picPMTypePunch.Text = lblPrefixe.Text + npr;
                if (txtNoProjet.Text.Length == 7)
                {
                    toolStripStatusLabel1.Text = lblPrefixe.Text + npr;

                    GetClientFromProject(toolStripStatusLabel1.Text);
                }
            }
        }
        private void GetClientFromProject(string noproj)
        {
            SqlConnection sql = new SqlConnection(StringSQL);
            sql.Open();
            try
            {
                SqlDataReader rd = new SqlCommand($"SELECT DISTINCT [DBO].[CLIENT].[NOMCLIENT] FROM [DBO].[PUNCH] " +
                    $"JOIN [DBO].[CLIENT] ON[DBO].[CLIENT].IDCLIENT =[DBO].[PUNCH].NOCLIENT " +
                    $"WHERE NOPROJET = '{noproj}'", sql).ExecuteReader();
                if (rd.Read())
                {
                    txtClient.Text = rd[0].ToString();
                    toolStripStatusLabel2.Text = rd[0].ToString(); ;
                }
                else
                {
                    txtClient.Text = "Oups";
                }
            }
            catch (Exception ex)
            {
                AfficherErreur("Punch", "GetClientFromProject", ex);
            }
        }
        private void mskNoProjet_MainputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            picPMTypePunch.Text = $"{lblPrefixe.Text}{txtNoProjet.Text}";
            GetClientFromProject(picPMTypePunch.Text);
        }
        private void mskPMNoProjet_MaputRejected(object sender, MaskInputRejectedEventArgs e) => picPMTypePunch.Text = $"{lblPrefixe.Text}{mskPMNoProjet.Text}";
        private void optPMTypePunch0_CheckedChanged(object sender, EventArgs e) => lblPMPrefixe.Text = "E";
        private void optPMTypePunch1_CheckedChanged(object sender, EventArgs e) => lblPMPrefixe.Text = "M";
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e) => ListerCommentairePunch();
        private void fraPunch_Enter(object sender, EventArgs e) => MessageBox.Show("On essaye de tricher :P");
        private void lvwJourSemaine1_Click(object sender, EventArgs e) => ListerPunchJour(lblJour0.Text);
        private void lvwJourSemaine2_Click(object sender, EventArgs e) => ListerPunchJour(lblJour1.Text);
        private void lvwJourSemaine3_Click(object sender, EventArgs e) => ListerPunchJour(lblJour2.Text);
        private void lvwJourSemaine4_Click(object sender, EventArgs e) => ListerPunchJour(lblJour3.Text);
        private void lvwJourSemaine5_Click(object sender, EventArgs e) => ListerPunchJour(lblJour4.Text);
        private void lvwJourSemaine6_Click(object sender, EventArgs e) => ListerPunchJour(lblJour5.Text);
        private void lvwJourSemaine7_Click(object sender, EventArgs e) => ListerPunchJour(lblJour6.Text);
        private void lblPrefixe_TextChanged(object sender, EventArgs e)
        {
            cmbType.Items.Clear();
            if (lblPrefixe.Text != "")
            {
                if (lblPrefixe.Text == "E")
                {
                    cmbType.Items.Add("Assemblage, Soudage, Meulage");
                    cmbType.Items.Add("Dessin Électrique");
                    cmbType.Items.Add("Expédition");
                    cmbType.Items.Add("Formation du personnel -Assemblage - Soudage");
                    cmbType.Items.Add("Gestion du projet");
                    cmbType.Items.Add("Programmation d'automate");
                    cmbType.Items.Add("Programmation de Robot");
                    cmbType.Items.Add("Programmation d'interface");
                    cmbType.Items.Add("Prototypage-Dévelloppement expérimental");
                    cmbType.Items.Add("Test Finaux");
                    cmbType.Items.Add("Vision Artificielle");
                }
                else
                {
                    cmbType.Items.Add("Assemblage des systèmes");
                    cmbType.Items.Add("Assemblage, Soudage, Meulage");
                    cmbType.Items.Add("Conception et dessin");
                    cmbType.Items.Add("Coupe Assemblage Soudage");
                    cmbType.Items.Add("Coupe et préparation(sauf soudage)");
                    cmbType.Items.Add("Coupe,Soudure et meulage");
                    cmbType.Items.Add("Expédition");
                    cmbType.Items.Add("Formation du personnel");
                    cmbType.Items.Add("Formation du personnel -Assemblage - Soudage");
                    cmbType.Items.Add("Gestion du projet");
                    cmbType.Items.Add("Machinage");
                    cmbType.Items.Add("Peinture et Finition");
                    cmbType.Items.Add("Prototypage-Dévelloppement expérimental");
                    cmbType.Items.Add("Test Finaux");
                }
            }
        }
        private void cmdPunchOut_Click(object sender, EventArgs e)
        {
            if (VerifierModificationDate() == true)
            {
                if (lvwJour.Items.Count > 0)
                {
                    ListViewItem item = lvwJour.FocusedItem;
            PunchOut punchOut = new PunchOut();
                    punchOut.Text = "Punch out pour le projet " + item.SubItems[I_LVW_PROJET].Text
                         + " Débutant à " + item.SubItems[I_LVW_DEBUT].Text;
                    punchOut.idPunch = int.Parse($"{item.SubItems[8].Text}");
                    punchOut.cmbEmploye.Text = IdNomEmploye;
                    punchOut.cmbType.Text = item.SubItems[5].Text;
                    punchOut.txtCommentaires.Text = item.SubItems[6].Text;
                    punchOut.txtClient.Text= item.SubItems[4].Text;
                    punchOut.ShowInTaskbar = false;
                    punchOut.ShowDialog();
                }
            }
            m_bMonthViewHasFocus = false;
        }

        private void fraJour_Paint(object sender, PaintEventArgs e)
        {

        }

        private void optHeure0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}